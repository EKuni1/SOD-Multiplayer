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
            var packet = new Packet
            {
                Type = PacketType.PlayerUpdate,
                SenderId = _playerId
            };
            
            // You can extend this with position data
            SendPacket(packet);
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
                            var packet = JsonConvert.DeserializeObject<Packet>(packetJson);
                            
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
    }
}
