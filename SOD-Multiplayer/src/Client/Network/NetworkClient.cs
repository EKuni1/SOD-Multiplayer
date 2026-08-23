using System;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using SOD.Multiplayer.Shared;
using UnityEngine;

namespace SOD.Multiplayer.Client.Network
{
    public class NetworkClient
    {
        private TcpClient _client;
        private NetworkStream _stream;
        private bool _connected = false;
        private string _serverIp;
        private int _serverPort;
        private string _playerId = "";
        
        public event Action<Packet> OnPacketReceived;
        public event Action OnConnected;
        public event Action OnDisconnected;
        
        public bool IsConnected => _connected;
        public string PlayerId => _playerId;
        
        public void Connect(string ip, int port)
        {
            try
            {
                _serverIp = ip;
                _serverPort = port;
                
                _client = new TcpClient();
                _client.BeginConnect(ip, port, ConnectCallback, null);
                
                UnityEngine.Debug.Log($"[SOD Multiplayer] Connecting to {_serverIp}:{_serverPort}...");
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError($"[SOD Multiplayer] Connection failed: {ex.Message}");
                OnDisconnected?.Invoke();
            }
        }
        
        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                _client.EndConnect(ar);
                _stream = _client.GetStream();
                _connected = true;
                
                UnityEngine.Debug.Log("[SOD Multiplayer] Connected to server!");
                OnConnected?.Invoke();
                
                // Start receiving packets
                BeginReceivePacket();
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError($"[SOD Multiplayer] Connection error: {ex.Message}");
                _connected = false;
                OnDisconnected?.Invoke();
            }
        }
        
        public void Disconnect()
        {
            if (_connected)
            {
                SendPacket(new Packet { Type = PacketType.LeaveRequest, SenderId = _playerId });
            }
            
            _connected = false;
            _playerId = "";
            
            try
            {
                _stream?.Close();
                _client?.Close();
            }
            catch { }
            
            _stream = null;
            _client = null;
            
            UnityEngine.Debug.Log("[SOD Multiplayer] Disconnected from server");
            OnDisconnected?.Invoke();
        }
        
        public void SendPacket(Packet packet)
        {
            if (!_connected || _stream == null) return;
            
            try
            {
                string json = JsonConvert.SerializeObject(packet);
                byte[] data = Encoding.UTF8.GetBytes(json + "\n");
                _stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError($"[SOD Multiplayer] Send error: {ex.Message}");
                Disconnect();
            }
        }
        
        public void SendJoinRequest(string playerName, string password = "")
        {
            var packet = new JoinRequestPacket
            {
                Type = PacketType.JoinRequest,
                PlayerName = playerName,
                Password = password
            };
            SendPacket(packet);
        }
        
        public void SendPlayerUpdate(float x, float y, float z)
        {
            var packet = new PlayerUpdatePacket
            {
                Type = PacketType.PlayerUpdate,
                SenderId = _playerId,
                PositionX = x,
                PositionY = y,
                PositionZ = z
            };
            SendPacket(packet);
        }

        public void SendWorldAction(WorldEntityType entityType, string entityId, string action, string stateJson = "{}")
        {
            SendPacket(new WorldActionPacket
            {
                Type = PacketType.WorldAction,
                SenderId = _playerId,
                EntityType = entityType,
                EntityId = entityId,
                Action = action,
                StateJson = stateJson,
                ClientTick = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
            });
        }

        public void RequestWorldSnapshot()
        {
            SendPacket(new Packet { Type = PacketType.WorldSnapshotRequest, SenderId = _playerId });
        }

        public void SendWorldSnapshot(WorldSnapshotPacket snapshot)
        {
            if (snapshot == null) throw new ArgumentNullException(nameof(snapshot));
            snapshot.Type = PacketType.WorldSnapshot;
            snapshot.SenderId = _playerId;
            SendPacket(snapshot);
        }
        
        private void BeginReceivePacket()
        {
            if (!_connected || _stream == null) return;
            
            try
            {
                byte[] buffer = new byte[4096];
                _stream.BeginRead(buffer, 0, buffer.Length, ReceiveCallback, buffer);
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError($"[SOD Multiplayer] Receive error: {ex.Message}");
                Disconnect();
            }
        }
        
        private void ReceiveCallback(IAsyncResult ar)
        {
            if (!_connected || _stream == null) return;
            
            try
            {
                byte[] buffer = (byte[])ar.AsyncState;
                int bytesRead = _stream.EndRead(ar);
                
                if (bytesRead > 0)
                {
                    string json = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();
                    
                    // Handle multiple packets in one read
                    string[] packets = json.Split('\n');
                    foreach (var packetJson in packets)
                    {
                        if (string.IsNullOrWhiteSpace(packetJson)) continue;
                        
                        try
                        {
                            var packet = DeserializePacket(packetJson);
                            
                            // Handle join response specially
                            if (packet.Type == PacketType.JoinAccepted)
                            {
                                var joinResponse = JsonConvert.DeserializeObject<JoinResponsePacket>(packetJson);
                                _playerId = joinResponse.AssignedPlayerId;
                                UnityEngine.Debug.Log($"[SOD Multiplayer] Joined as player: {_playerId}");
                            }
                            
                            OnPacketReceived?.Invoke(packet);
                        }
                        catch (Exception ex)
                        {
                            UnityEngine.Debug.LogError($"[SOD Multiplayer] Packet parse error: {ex.Message}");
                        }
                    }
                }
                
                // Continue receiving
                BeginReceivePacket();
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError($"[SOD Multiplayer] Receive callback error: {ex.Message}");
                Disconnect();
            }
        }

        private Packet DeserializePacket(string json)
        {
            var header = JsonConvert.DeserializeObject<Packet>(json);
            if (header == null) throw new InvalidOperationException("Packet has no header");

            return header.Type switch
            {
                PacketType.JoinAccepted or PacketType.JoinRejected =>
                    JsonConvert.DeserializeObject<JoinResponsePacket>(json),
                PacketType.PlayerUpdate => JsonConvert.DeserializeObject<PlayerUpdatePacket>(json),
                PacketType.PlayerList or PacketType.GameState =>
                    JsonConvert.DeserializeObject<GameStatePacket>(json),
                PacketType.ChatMessage or PacketType.ChatBroadcast =>
                    JsonConvert.DeserializeObject<ChatPacket>(json),
                PacketType.WorldAction or PacketType.WorldActionBroadcast =>
                    JsonConvert.DeserializeObject<WorldActionPacket>(json),
                PacketType.WorldSnapshot => JsonConvert.DeserializeObject<WorldSnapshotPacket>(json),
                _ => header
            } ?? throw new InvalidOperationException("Packet could not be deserialized");
        }
    }
}
