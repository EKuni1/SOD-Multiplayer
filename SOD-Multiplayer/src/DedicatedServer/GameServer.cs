using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SOD.Multiplayer.Shared;

namespace SOD.Multiplayer.Dedicated
{
    public class GameServer
    {
        private TcpListener _listener;
        private List<ClientConnection> _clients = new();
        private string _serverName;
        private int _port;
        private string _password;
        private bool _hasPassword;
        private string _masterServerUrl;
        private string _serverId;
        private readonly object _worldStateLock = new();
        private readonly WorldSnapshotPacket _worldSnapshot = new()
        {
            Type = PacketType.WorldSnapshot,
            Weather = "Clear"
        };
        private long _worldRevision;
        
        public const int MAX_PLAYERS = 4;
        
        public GameServer(string name, int port, string password, string masterServerUrl)
        {
            _serverName = name;
            _port = port;
            _password = password;
            _hasPassword = !string.IsNullOrEmpty(password);
            _masterServerUrl = masterServerUrl;
            _serverId = Guid.NewGuid().ToString();
        }
        
        public async Task StartAsync()
        {
            _listener = new TcpListener(IPAddress.Any, _port);
            _listener.Start();
            
            Console.WriteLine($"[Dedicated Server] Starting server '{_serverName}' on port {_port}");
            Console.WriteLine($"[Dedicated Server] Max players: {MAX_PLAYERS}");
            Console.WriteLine($"[Dedicated Server] Password protected: {_hasPassword}");
            
            // Start accepting clients
            _ = AcceptClientsAsync();
            
            // Start heartbeat to master server
            _ = SendHeartbeatAsync();
            
            // Start game loop
            _ = GameLoopAsync();
        }
        
        private async Task AcceptClientsAsync()
        {
            while (true)
            {
                try
                {
                    var client = await _listener.AcceptTcpClientAsync();
                    Console.WriteLine($"[Dedicated Server] New connection from {((IPEndPoint)client.Client.RemoteEndPoint).Address}");
                    
                    var connection = new ClientConnection(client, this);
                    _ = connection.HandleClientAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Dedicated Server] Accept error: {ex.Message}");
                }
            }
        }
        
        public async Task HandleJoinRequest(ClientConnection client, JoinRequestPacket packet)
        {
            // Check player limit
            if (_clients.Count >= MAX_PLAYERS)
            {
                var response = new JoinResponsePacket
                {
                    Type = PacketType.JoinRejected,
                    Accepted = false,
                    Reason = "Server is full"
                };
                await client.SendPacketAsync(response);
                return;
            }
            
            // Check password
            if (_hasPassword && packet.Password != _password)
            {
                var response = new JoinResponsePacket
                {
                    Type = PacketType.JoinRejected,
                    Accepted = false,
                    Reason = "Invalid password"
                };
                await client.SendPacketAsync(response);
                return;
            }
            
            // Assign player ID
            string playerId = Guid.NewGuid().ToString();
            client.PlayerId = playerId;
            client.PlayerName = packet.PlayerName;
            _clients.Add(client);
            
            Console.WriteLine($"[Dedicated Server] Player '{packet.PlayerName}' joined as {playerId}");
            
            // Send acceptance
            var acceptResponse = new JoinResponsePacket
            {
                Type = PacketType.JoinAccepted,
                Accepted = true,
                AssignedPlayerId = playerId
            };
            await client.SendPacketAsync(acceptResponse);
            
            // Notify other players
            await BroadcastToOthersAsync(client, new Packet
            {
                Type = PacketType.PlayerJoined,
                SenderId = playerId
            });
            
            // Send current player list to new player
            await SendPlayerListAsync(client);
            await client.SendPacketAsync(GetWorldSnapshot());
        }
        
        public void HandlePlayerLeave(ClientConnection client)
        {
            _clients.Remove(client);
            Console.WriteLine($"[Dedicated Server] Player '{client.PlayerName}' left");
            
            // Notify others
            BroadcastAsync(new Packet
            {
                Type = PacketType.PlayerLeft,
                SenderId = client.PlayerId
            }).Wait();
        }
        
        private async Task SendPlayerListAsync(ClientConnection client)
        {
            var gameState = new GameStatePacket
            {
                Type = PacketType.PlayerList
            };
            
            foreach (var c in _clients)
            {
                gameState.Players.Add(new PlayerInfo
                {
                    Id = c.PlayerId,
                    Name = c.PlayerName,
                    IsHost = c == _clients[0]
                });
            }
            
            await client.SendPacketAsync(gameState);
        }
        
        private async Task BroadcastAsync(Packet packet)
        {
            foreach (var client in _clients)
            {
                await client.SendPacketAsync(packet);
            }
        }
        
        private async Task BroadcastToOthersAsync(ClientConnection exclude, Packet packet)
        {
            foreach (var client in _clients)
            {
                if (client != exclude)
                {
                    await client.SendPacketAsync(packet);
                }
            }
        }

        public async Task HandlePlayerUpdateAsync(ClientConnection client, PlayerUpdatePacket packet)
        {
            await BroadcastToOthersAsync(client, new PlayerUpdatePacket
            {
                Type = PacketType.PlayerUpdate,
                SenderId = client.PlayerId,
                PositionX = packet.PositionX,
                PositionY = packet.PositionY,
                PositionZ = packet.PositionZ,
                RotationX = packet.RotationX,
                RotationY = packet.RotationY,
                RotationZ = packet.RotationZ,
                RotationW = packet.RotationW
            });
        }

        public async Task HandleWorldActionAsync(ClientConnection client, WorldActionPacket packet)
        {
            WorldActionPacket authoritativeAction;
            lock (_worldStateLock)
            {
                _worldRevision++;
                _worldSnapshot.Revision = _worldRevision;
                _worldSnapshot.ServerTick = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                _worldSnapshot.Entities.RemoveAll(entity =>
                    entity.EntityType == packet.EntityType && entity.EntityId == packet.EntityId);
                _worldSnapshot.Entities.Add(new WorldEntityState
                {
                    EntityType = packet.EntityType,
                    EntityId = packet.EntityId,
                    StateJson = packet.StateJson
                });

                authoritativeAction = new WorldActionPacket
                {
                    Type = PacketType.WorldActionBroadcast,
                    SenderId = client.PlayerId,
                    EntityType = packet.EntityType,
                    EntityId = packet.EntityId,
                    Action = packet.Action,
                    StateJson = packet.StateJson,
                    ClientTick = _worldSnapshot.ServerTick
                };
            }

            await BroadcastAsync(authoritativeAction);
        }

        public async Task HandleWorldSnapshotAsync(ClientConnection client, WorldSnapshotPacket packet)
        {
            lock (_worldStateLock)
            {
                if (_clients.Count == 0 || _clients[0] != client)
                    return;

                _worldRevision++;
                packet.Type = PacketType.WorldSnapshot;
                packet.Revision = _worldRevision;
                packet.ServerTick = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                _worldSnapshot.TimeOfDay = packet.TimeOfDay;
                _worldSnapshot.Weather = packet.Weather;
                _worldSnapshot.Entities = packet.Entities ?? new List<WorldEntityState>();
                _worldSnapshot.Citizens = packet.Citizens ?? new List<CitizenState>();
                _worldSnapshot.Revision = packet.Revision;
                _worldSnapshot.ServerTick = packet.ServerTick;
            }

            await BroadcastAsync(GetWorldSnapshot());
        }

        public async Task SendWorldSnapshotAsync(ClientConnection client)
        {
            await client.SendPacketAsync(GetWorldSnapshot());
        }

        private WorldSnapshotPacket GetWorldSnapshot()
        {
            lock (_worldStateLock)
            {
                return new WorldSnapshotPacket
                {
                    Type = PacketType.WorldSnapshot,
                    Revision = _worldSnapshot.Revision,
                    ServerTick = _worldSnapshot.ServerTick,
                    TimeOfDay = _worldSnapshot.TimeOfDay,
                    Weather = _worldSnapshot.Weather,
                    Entities = new List<WorldEntityState>(_worldSnapshot.Entities),
                    Citizens = new List<CitizenState>(_worldSnapshot.Citizens)
                };
            }
        }
        
        private async Task SendHeartbeatAsync()
        {
            while (true)
            {
                try
                {
                    var serverInfo = new ServerInfo
                    {
                        Id = _serverId,
                        Name = _serverName,
                        Ip = GetPublicIp(),
                        Port = _port,
                        CurrentPlayers = _clients.Count,
                        MaxPlayers = MAX_PLAYERS,
                        HasPassword = _hasPassword,
                        LastHeartbeat = DateTime.UtcNow
                    };
                    
                    using (var httpClient = new System.Net.Http.HttpClient())
                    {
                        var content = new StringContent(JsonConvert.SerializeObject(serverInfo), Encoding.UTF8, "application/json");
                        var response = await httpClient.PostAsync($"{_masterServerUrl}/api/servers/register", content);
                        
                        if (response.IsSuccessStatusCode)
                        {
                            Console.WriteLine($"[Dedicated Server] Heartbeat sent. Players: {_clients.Count}/{MAX_PLAYERS}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Dedicated Server] Heartbeat failed: {ex.Message}");
                }
                
                await Task.Delay(10000); // Send every 10 seconds
            }
        }
        
        private string GetPublicIp()
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    return webClient.DownloadString("https://api.ipify.org").Trim();
                }
            }
            catch
            {
                return "127.0.0.1";
            }
        }
        
        private async Task GameLoopAsync()
        {
            // Main game loop - update game state, sync players, etc.
            while (true)
            {
                // TODO: Implement game state synchronization
                // For now, just send periodic state updates
                
                if (_clients.Count > 0)
                {
                    var gameState = new GameStatePacket
                    {
                        Type = PacketType.GameState,
                        TimeOfDay = DateTime.Now.ToString("HH:mm")
                    };
                    
                    foreach (var client in _clients)
                    {
                        gameState.Players.Add(new PlayerInfo
                        {
                            Id = client.PlayerId,
                            Name = client.PlayerName
                        });
                    }
                    
                    await BroadcastAsync(gameState);
                }
                
                await Task.Delay(1000); // Update every second
            }
        }
    }
    
    public class ClientConnection
    {
        private TcpClient _client;
        private NetworkStream _stream;
        private GameServer _server;
        private byte[] _buffer = new byte[4096];
        private StringBuilder _messageBuffer = new();
        
        public string PlayerId { get; set; } = "";
        public string PlayerName { get; set; } = "";
        
        public ClientConnection(TcpClient client, GameServer server)
        {
            _client = client;
            _stream = client.GetStream();
            _server = server;
        }
        
        public async Task HandleClientAsync()
        {
            try
            {
                _ = ReadStreamAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Dedicated Server] Client handler error: {ex.Message}");
                _server.HandlePlayerLeave(this);
            }
        }
        
        private async Task ReadStreamAsync()
        {
            while (_client.Connected)
            {
                int bytesRead = await _stream.ReadAsync(_buffer, 0, _buffer.Length);
                
                if (bytesRead == 0)
                {
                    // Client disconnected
                    break;
                }
                
                string data = Encoding.UTF8.GetString(_buffer, 0, bytesRead);
                _messageBuffer.Append(data);
                
                // Process complete messages (newline delimited)
                while (_messageBuffer.ToString().Contains("\n"))
                {
                    int newlineIndex = _messageBuffer.ToString().IndexOf('\n');
                    string message = _messageBuffer.ToString().Substring(0, newlineIndex).Trim();
                    _messageBuffer.Remove(0, newlineIndex + 1);
                    
                    if (!string.IsNullOrEmpty(message))
                    {
                        await ProcessMessageAsync(message);
                    }
                }
            }
            
            _server.HandlePlayerLeave(this);
            _client.Close();
        }
        
        private async Task ProcessMessageAsync(string json)
        {
            try
            {
                var packet = JsonConvert.DeserializeObject<Packet>(json);
                
                switch (packet.Type)
                {
                    case PacketType.JoinRequest:
                        var joinRequest = JsonConvert.DeserializeObject<JoinRequestPacket>(json);
                        await _server.HandleJoinRequest(this, joinRequest);
                        break;
                        
                    case PacketType.LeaveRequest:
                        _server.HandlePlayerLeave(this);
                        break;
                        
                    case PacketType.PlayerUpdate:
                        var playerUpdate = JsonConvert.DeserializeObject<PlayerUpdatePacket>(json);
                        await _server.HandlePlayerUpdateAsync(this, playerUpdate);
                        break;

                    case PacketType.WorldAction:
                        var worldAction = JsonConvert.DeserializeObject<WorldActionPacket>(json);
                        await _server.HandleWorldActionAsync(this, worldAction);
                        break;

                    case PacketType.WorldSnapshotRequest:
                        await _server.SendWorldSnapshotAsync(this);
                        break;

                    case PacketType.WorldSnapshot:
                        var worldSnapshot = JsonConvert.DeserializeObject<WorldSnapshotPacket>(json);
                        await _server.HandleWorldSnapshotAsync(this, worldSnapshot);
                        break;
                        
                    case PacketType.ChatMessage:
                        var chatPacket = JsonConvert.DeserializeObject<ChatPacket>(json);
                        await _server.BroadcastAsync(new ChatPacket
                        {
                            Type = PacketType.ChatBroadcast,
                            SenderId = PlayerId,
                            Message = $"{PlayerName}: {chatPacket.Message}"
                        });
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Dedicated Server] Packet processing error: {ex.Message}");
            }
        }
        
        public async Task SendPacketAsync(Packet packet)
        {
            try
            {
                string json = JsonConvert.SerializeObject(packet);
                byte[] data = Encoding.UTF8.GetBytes(json + "\n");
                await _stream.WriteAsync(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Dedicated Server] Send error: {ex.Message}");
            }
        }
    }
}
