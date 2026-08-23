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
        private readonly StringBuilder _messageBuffer = new();
        
        public event Action<Packet> OnPacketReceived;
        public event Action OnConnected;
        public event Action OnDisconnected;
        public event Action<JoinResponsePacket> OnJoinAccepted;
        public event Action<string> OnJoinRejected;
        public event Action<SessionSelectedPacket> OnSessionSelected;
        public event Action<GameStatePacket> OnGameStateReceived;
        public event Action<WorldEventPacket> OnWorldEvent;
        public static NetworkClient Active { get; private set; }
        
        public bool IsConnected => _connected;
        public string PlayerId => _playerId;
        
        public void Connect(string ip, int port)
        {
            try
            {
                Active = this;
                _serverIp = ip;
                _serverPort = port;
                
                _client = new TcpClient();
                _client.BeginConnect(ip, port, ConnectCallback, null);
                
                LogInfo($"Connecting to {_serverIp}:{_serverPort}...");
            }
            catch (Exception ex)
            {
                LogError($"Connection failed: {ex.Message}");
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
                
                LogInfo("Connected to server!");
                OnConnected?.Invoke();
                
                // Start receiving packets
                BeginReceivePacket();
            }
            catch (Exception ex)
            {
                LogError($"Connection error: {ex.Message}");
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
            
            LogInfo("Disconnected from server");
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
                LogError($"Send error: {ex.Message}");
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

        public void SendSessionSelected(string saveFileName, string mapName = "")
        {
            SendPacket(new SessionSelectedPacket
            {
                Type = PacketType.SessionSelected,
                SaveFileName = saveFileName,
                MapName = mapName
            });
        }
        
        public void SendPlayerUpdate(float x, float y, float z)
        {
            var packet = new Packet
            {
                Type = PacketType.PlayerUpdate,
                SenderId = _playerId,
                PositionX = x,
                PositionY = y,
                PositionZ = z,
                GameTime = SessionData.Instance != null ? SessionData.Instance.gameTime : 0f
            };
            SendPacket(packet);
        }

        public void SendWorldEvent(string eventType, string objectId, string value = "", float numericValue = 0f)
        {
            SendPacket(new WorldEventPacket
            {
                Type = PacketType.WorldEvent,
                SenderId = _playerId,
                EventType = eventType,
                ObjectId = objectId,
                Value = value,
                NumericValue = numericValue
            });
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
                LogError($"Receive error: {ex.Message}");
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
                    _messageBuffer.Append(Encoding.UTF8.GetString(buffer, 0, bytesRead));
                    int newlineIndex;
                    while ((newlineIndex = _messageBuffer.ToString().IndexOf('\n')) >= 0)
                    {
                        string packetJson = _messageBuffer.ToString(0, newlineIndex).Trim();
                        _messageBuffer.Remove(0, newlineIndex + 1);
                        if (string.IsNullOrWhiteSpace(packetJson)) continue;
                        
                        try
                        {
                            var packet = DeserializePacket(packetJson);
                            if (packet == null)
                            {
                                continue;
                            }
                            
                            // Handle join response specially
                            if (packet.Type == PacketType.JoinAccepted)
                            {
                                var joinResponse = packet as JoinResponsePacket;
                                if (joinResponse == null)
                                {
                                    continue;
                                }
                                _playerId = joinResponse.AssignedPlayerId;
                                LogInfo($"Joined as player: {_playerId}");
                                OnJoinAccepted?.Invoke(joinResponse);
                            }
                            else if (packet.Type == PacketType.JoinRejected)
                            {
                                var joinResponse = packet as JoinResponsePacket;
                                OnJoinRejected?.Invoke(joinResponse?.Reason ?? "Join rejected");
                            }
                            
                            OnPacketReceived?.Invoke(packet);
                            if (packet is GameStatePacket gameState)
                            {
                                OnGameStateReceived?.Invoke(gameState);
                            }
                            else if (packet is WorldEventPacket worldEvent)
                            {
                                OnWorldEvent?.Invoke(worldEvent);
                            }
                        }
                        catch (Exception ex)
                        {
                            LogError($"Packet parse error: {ex.Message}");
                        }
                    }
                }
                
                // Continue receiving
                BeginReceivePacket();
            }
            catch (Exception ex)
            {
                LogError($"Receive callback error: {ex.Message}");
                Disconnect();
            }
        }

        private static Packet DeserializePacket(string json)
        {
            var header = JsonConvert.DeserializeObject<Packet>(json);
            if (header == null)
            {
                return null;
            }

            return header.Type switch
            {
                PacketType.JoinAccepted or PacketType.JoinRejected =>
                    JsonConvert.DeserializeObject<JoinResponsePacket>(json),
                PacketType.GameState or PacketType.PlayerList =>
                    JsonConvert.DeserializeObject<GameStatePacket>(json),
                PacketType.ChatBroadcast => JsonConvert.DeserializeObject<ChatPacket>(json),
                PacketType.SessionSelected => JsonConvert.DeserializeObject<SessionSelectedPacket>(json),
                PacketType.WorldEvent => JsonConvert.DeserializeObject<WorldEventPacket>(json),
                PacketType.JoinRequest => JsonConvert.DeserializeObject<JoinRequestPacket>(json),
                _ => header
            };
        }

        internal static void LogInfo(string message)
        {
            MultiplayerMod.Instance?.Log.LogInfo($"[SOD Multiplayer] {message}");
        }

        internal static void LogError(string message)
        {
            MultiplayerMod.Instance?.Log.LogError($"[SOD Multiplayer] {message}");
        }
    }
}
