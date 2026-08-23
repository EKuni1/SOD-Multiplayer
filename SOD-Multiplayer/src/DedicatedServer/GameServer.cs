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
        private TcpListener _listener = null!;
        private List<ClientConnection> _clients = new();
        private string _serverName;
        private int _port;
        private string _password;
        private bool _hasPassword;
        private string _masterServerUrl;
        private string _masterToken;
        private IPAddress _bindAddress;
        private string _publicAddress;
        private string _map;
        private string _saveGame;
        private string _serverId;
        private readonly object _clientsLock = new();
        private float _hostGameTime;
        
        public const int MAX_PLAYERS = 4;
        
        public GameServer(string name, string bindAddress, string publicAddress, int port, string password, string masterServerUrl, string masterToken, string map, string saveGame)
        {
            _serverName = name;
            _port = port;
            _password = password;
            _hasPassword = !string.IsNullOrEmpty(password);
            _masterServerUrl = masterServerUrl;
            _masterToken = masterToken;
            _bindAddress = IPAddress.Parse(bindAddress);
            _publicAddress = publicAddress;
            _map = map;
            _saveGame = saveGame;
            _serverId = Guid.NewGuid().ToString();
        }
        
        public Task StartAsync()
        {
            _listener = new TcpListener(_bindAddress, _port);
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
                        return Task.CompletedTask;
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
            client.IsHost = _clients.Count == 0;

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
            lock (_clientsLock)
            {
                _clients.Add(client);
            }
            
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
        }

        public async Task HandleSessionSelected(ClientConnection client, SessionSelectedPacket packet)
        {
            if (!client.IsHost)
            {
                return;
            }

            _map = packet.MapName;
            _saveGame = packet.SaveFileName;
            await BroadcastAsync(packet);
        }

        public void SetHostGameTime(float gameTime)
        {
            _hostGameTime = gameTime;
        }
        
        public void HandlePlayerLeave(ClientConnection client)
        {
            lock (_clientsLock)
            {
                _clients.Remove(client);
            }
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
        
        internal async Task BroadcastAsync(Packet packet)
        {
            ClientConnection[] clients;
            lock (_clientsLock)
            {
                clients = _clients.ToArray();
            }

            foreach (var client in clients)
            {
                await client.SendPacketAsync(packet);
            }
        }
        
        internal async Task BroadcastToOthersAsync(ClientConnection exclude, Packet packet)
        {
            ClientConnection[] clients;
            lock (_clientsLock)
            {
                clients = _clients.ToArray();
            }

            foreach (var client in clients)
            {
                if (client != exclude)
                {
                    await client.SendPacketAsync(packet);
                }
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
                        Ip = _publicAddress,
                        Port = _port,
                        CurrentPlayers = _clients.Count,
                        MaxPlayers = MAX_PLAYERS,
                        HasPassword = _hasPassword,
                        Map = _map,
                        SaveGame = _saveGame,
                        LastHeartbeat = DateTime.UtcNow
                    };
                    
                    using (var httpClient = new System.Net.Http.HttpClient())
                    {
                        var content = new StringContent(JsonConvert.SerializeObject(serverInfo), Encoding.UTF8, "application/json");
                        httpClient.DefaultRequestHeaders.Remove("X-Master-Token");
                        httpClient.DefaultRequestHeaders.Add("X-Master-Token", _masterToken);
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
        
        private async Task<string> GetPublicIpAsync()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    return (await httpClient.GetStringAsync("https://api.ipify.org")).Trim();
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
                        TimeOfDay = DateTime.Now.ToString("HH:mm"),
                        GameTime = _hostGameTime
                    };
                    
                    ClientConnection[] clients;
                    lock (_clientsLock)
                    {
                        clients = _clients.ToArray();
                    }

                    foreach (var client in clients)
                    {
                        gameState.Players.Add(new PlayerInfo
                        {
                            Id = client.PlayerId,
                            Name = client.PlayerName,
                            PositionX = client.PositionX,
                            PositionY = client.PositionY,
                            PositionZ = client.PositionZ,
                            IsHost = client.IsHost
                        });
                    }
                    
                    await BroadcastAsync(gameState);
                }
                
                await Task.Delay(50); // 20 state updates per second
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
        private readonly SemaphoreSlim _sendGate = new(1, 1);
        
        public string PlayerId { get; set; } = "";
        public string PlayerName { get; set; } = "";
        public bool IsHost { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        
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
                if (packet == null)
                {
                    return;
                }
                
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
                        PositionX = packet.PositionX;
                        PositionY = packet.PositionY;
                        PositionZ = packet.PositionZ;
                        if (IsHost)
                        {
                            _server.SetHostGameTime(packet.GameTime);
                        }
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

                    case PacketType.SessionSelected:
                        var sessionPacket = JsonConvert.DeserializeObject<SessionSelectedPacket>(json);
                        if (sessionPacket != null)
                        {
                            await _server.HandleSessionSelected(this, sessionPacket);
                        }
                        break;

                    case PacketType.WorldEvent:
                        var worldEvent = JsonConvert.DeserializeObject<WorldEventPacket>(json);
                        if (worldEvent != null)
                        {
                            worldEvent.SenderId = PlayerId;
                            await _server.BroadcastToOthersAsync(this, worldEvent);
                        }
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
            await _sendGate.WaitAsync();
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
            finally
            {
                _sendGate.Release();
            }
        }
    }
}
