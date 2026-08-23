using System;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Concurrent;
using Newtonsoft.Json;

namespace SOD_Multiplayer.Network
{
    /// <summary>
    /// Netzwerk-Client für Verbindung zum Dedicated Server
    /// Verwendet TCP für zuverlässige Kommunikation
    /// </summary>
    public class NetworkClient
    {
        private TcpClient _tcpClient;
        private NetworkStream _stream;
        private Thread _receiveThread;
        private bool _isConnected;
        private readonly object _lock = new object();
        
        /// <summary>
        /// Eingehende Pakete werden hier gespeichert und vom Main-Thread verarbeitet
        /// </summary>
        private readonly ConcurrentQueue<NetworkPacket> _incomingPackets = new ConcurrentQueue<NetworkPacket>();
        
        /// <summary>
        /// Callbacks für verschiedene Paket-Typen
        /// </summary>
        private readonly PacketHandler _packetHandler;
        
        /// <summary>
        /// Ist der Client verbunden?
        /// </summary>
        public bool IsConnected => _isConnected;
        
        /// <summary>
        /// Aktuelle Server-Adresse
        /// </summary>
        public string ServerAddress { get; private set; }
        
        /// <summary>
        /// Aktueller Server-Port
        /// </summary>
        public int ServerPort { get; private set; }
        
        /// <summary>
        /// Event wenn Verbindung hergestellt wurde
        /// </summary>
        public event Action OnConnected;
        
        /// <summary>
        /// Event wenn Verbindung getrennt wurde
        /// </summary>
        public event Action OnDisconnected;
        
        /// <summary>
        /// Event wenn ein Fehler auftritt
        /// </summary>
        public event Action<string> OnError;

        public NetworkClient()
        {
            _packetHandler = new PacketHandler(this);
            RegisterDefaultHandlers();
        }
        
        /// <summary>
        /// Standard-Paket-Handler registrieren
        /// </summary>
        private void RegisterDefaultHandlers()
        {
            // Phase 1: Basis-Verbindung
            _packetHandler.RegisterHandler<ConnectResponsePacket>(HandleConnectResponse);
            _packetHandler.RegisterHandler<DisconnectPacket>(HandleDisconnect);
        }
        
        /// <summary>
        /// Verbindung zu einem Dedicated Server herstellen
        /// </summary>
        public void Connect(string ip, int port)
        {
            if (_isConnected)
            {
                MultiplayerMod.Instance?.Log.LogWarning("Bereits verbunden! Erst trennen.");
                return;
            }
            
            try
            {
                ServerAddress = ip;
                ServerPort = port;
                
                _tcpClient = new TcpClient();
                _tcpClient.Connect(ip, port);
                
                _stream = _tcpClient.GetStream();
                _isConnected = true;
                
                MultiplayerMod.Instance?.Log.LogInfo($"Verbunden mit {ip}:{port}");
                
                // Receive-Thread starten
                _receiveThread = new Thread(ReceiveLoop)
                {
                    Name = "NetworkClient-Receive",
                    IsBackground = true
                };
                _receiveThread.Start();
                
                // CONNECT_REQUEST senden
                SendConnectRequest();
            }
            catch (Exception ex)
            {
                MultiplayerMod.Instance?.Log.LogError($"Verbindungsfehler: {ex.Message}");
                _isConnected = false;
                OnError?.Invoke(ex.Message);
            }
        }
        
        /// <summary>
        /// Verbindung trennen
        /// </summary>
        public void Disconnect()
        {
            if (!_isConnected)
                return;
                
            lock (_lock)
            {
                try
                {
                    // DISCONNECT Packet senden
                    SendPacket(new DisconnectPacket 
                    { 
                        Reason = "Client disconnected" 
                    });
                    
                    _isConnected = false;
                    _stream?.Close();
                    _tcpClient?.Close();
                    
                    MultiplayerMod.Instance?.Log.LogInfo("Verbindung getrennt");
                    OnDisconnected?.Invoke();
                }
                catch (Exception ex)
                {
                    MultiplayerMod.Instance?.Log.LogError($"Fehler beim Trennen: {ex.Message}");
                }
                finally
                {
                    _stream = null;
                    _tcpClient = null;
                }
            }
        }
        
        /// <summary>
        /// CONNECT_REQUEST an Server senden
        /// </summary>
        private void SendConnectRequest()
        {
            var packet = new ConnectRequestPacket
            {
                // Placeholder - wird in späteren Phasen erweitert
                PlayerName = "Player1", // TODO: Vom Spiel holen
                ClientVersion = "0.1.0"
            };
            
            SendPacket(packet);
            MultiplayerMod.Instance?.Log.LogInfo("CONNECT_REQUEST gesendet");
        }
        
        /// <summary>
        /// Antwort auf CONNECT_REQUEST verarbeiten
        /// </summary>
        private void HandleConnectResponse(ConnectResponsePacket packet)
        {
            if (packet.Success)
            {
                MultiplayerMod.Instance?.Log.LogInfo("Verbindung erfolgreich! Server: " + packet.ServerName);
                OnConnected?.Invoke();
            }
            else
            {
                MultiplayerMod.Instance?.Log.LogError("Verbindung abgelehnt: " + packet.Reason);
                Disconnect();
                OnError?.Invoke(packet.Reason);
            }
        }
        
        /// <summary>
        /// DISCONNECT Packet verarbeiten
        /// </summary>
        private void HandleDisconnect(DisconnectPacket packet)
        {
            MultiplayerMod.Instance?.Log.LogInfo("Server hat Verbindung getrennt: " + packet.Reason);
            Disconnect();
        }
        
        /// <summary>
        /// Empfangsschleife im eigenen Thread
        /// </summary>
        private void ReceiveLoop()
        {
            var buffer = new byte[4096];
            
            while (_isConnected && _tcpClient?.Connected == true)
            {
                try
                {
                    int bytesRead = _stream.Read(buffer, 0, buffer.Length);
                    
                    if (bytesRead <= 0)
                    {
                        MultiplayerMod.Instance?.Log.LogWarning("Verbindung vom Server getrennt");
                        break;
                    }
                    
                    // Paket parsen
                    var json = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    var packet = ParsePacket(json);
                    
                    if (packet != null)
                    {
                        _incomingPackets.Enqueue(packet);
                    }
                }
                catch (Exception ex)
                {
                    if (_isConnected)
                    {
                        MultiplayerMod.Instance?.Log.LogError($"Empfangsfehler: {ex.Message}");
                    }
                    break;
                }
            }
            
            // Verbindung trennen
            if (_isConnected)
            {
                Disconnect();
            }
        }
        
        /// <summary>
        /// Paket aus JSON parsen
        /// </summary>
        private NetworkPacket ParsePacket(string json)
        {
            try
            {
                // Ersten Teil parsen um PacketType zu bekommen
                var typeData = JsonConvert.DeserializeObject<PacketTypeWrapper>(json);
                if (typeData == null || string.IsNullOrEmpty(typeData.PacketType))
                    return null;
                
                // Richtigen Packet-Typ erstellen
                return _packetHandler.DeserializePacket(typeData.PacketType, json);
            }
            catch (Exception ex)
            {
                MultiplayerMod.Instance?.Log.LogError($"Fehler beim Parsen: {ex.Message}");
                return null;
            }
        }
        
        /// <summary>
        /// Paket an Server senden
        /// </summary>
        public void SendPacket(NetworkPacket packet)
        {
            if (!_isConnected || _stream == null)
            {
                MultiplayerMod.Instance?.Log.LogWarning("Nicht verbunden! Paket nicht gesendet: " + packet?.GetType().Name);
                return;
            }
            
            lock (_lock)
            {
                try
                {
                    var json = JsonConvert.SerializeObject(packet);
                    var data = System.Text.Encoding.UTF8.GetBytes(json);
                    
                    // Länge als Prefix senden (4 bytes)
                    var lengthPrefix = BitConverter.GetBytes(data.Length);
                    _stream.Write(lengthPrefix, 0, 4);
                    _stream.Write(data, 0, data.Length);
                    _stream.Flush();
                    
                    MultiplayerMod.Instance?.Log.LogDebug($"Gesendet: {packet.GetType().Name} ({data.Length} bytes)");
                }
                catch (Exception ex)
                {
                    MultiplayerMod.Instance?.Log.LogError($"Sendefehler: {ex.Message}");
                    Disconnect();
                }
            }
        }
        
        /// <summary>
        /// Eingehende Pakete verarbeiten (muss vom Main-Thread aufgerufen werden)
        /// </summary>
        public void ProcessIncomingPackets()
        {
            while (_incomingPackets.TryDequeue(out var packet))
            {
                _packetHandler.HandlePacket(packet);
            }
        }
        
        /// <summary>
        /// Wrapper-Klasse zum Auslesen des PacketType
        /// </summary>
        private class PacketTypeWrapper
        {
            public string PacketType { get; set; }
        }
    }
}
