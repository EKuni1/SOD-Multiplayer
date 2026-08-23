using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace SOD_Multiplayer.Network
{
    /// <summary>
    /// Verwaltet einen verbundenen Client
    /// </summary>
    public class ConnectedClient
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public TcpClient TcpClient { get; set; }
        public NetworkStream Stream { get; set; }
        public DateTime LastActivity { get; set; } = DateTime.UtcNow;
        public bool IsAuthenticated { get; set; }
        
        public void UpdateActivity()
        {
            LastActivity = DateTime.UtcNow;
        }
    }
    
    /// <summary>
    /// TCP-Server für Client-Verbindungen
    /// </summary>
    public class NetworkServer
    {
        private TcpListener _listener;
        private Thread _acceptThread;
        private bool _isRunning;
        
        /// <summary>
        /// Alle verbundenen Clients
        /// </summary>
        private readonly List<ConnectedClient> _clients = new List<ConnectedClient>();
        private readonly object _clientsLock = new object();
        
        /// <summary>
        /// Server-Port
        /// </summary>
        public int Port { get; private set; }
        
        /// <summary>
        /// Ist der Server laufend?
        /// </summary>
        public bool IsRunning => _isRunning;
        
        /// <summary>
        /// Aktuelle Spielerzahl
        /// </summary>
        public int PlayerCount
        {
            get
            {
                lock (_clientsLock)
                {
                    return _clients.Count;
                }
            }
        }
        
        /// <summary>
        /// Maximale Spielerzahl (wird von GameServer gesetzt)
        /// </summary>
        public int MaxPlayers { get; set; } = 4;
        
        /// <summary>
        /// Event wenn Client verbindet
        /// </summary>
        public event Action<ConnectedClient> OnClientConnected;
        
        /// <summary>
        /// Event wenn Client trennt
        /// </summary>
        public event Action<ConnectedClient> OnClientDisconnected;
        
        /// <summary>
        /// Event wenn Paket empfangen wird
        /// </summary>
        public event Action<ConnectedClient, NetworkPacket> OnPacketReceived;
        
        public NetworkServer(int port)
        {
            Port = port;
        }
        
        /// <summary>
        /// Server starten
        /// </summary>
        public void Start()
        {
            if (_isRunning)
            {
                Console.WriteLine("[NetworkServer] Bereits laufend!");
                return;
            }
            
            try
            {
                _listener = new TcpListener(IPAddress.Any, Port);
                _listener.Start();
                _isRunning = true;
                
                Console.WriteLine($"[NetworkServer] Gestartet auf Port {Port}");
                
                // Accept-Thread starten
                _acceptThread = new Thread(AcceptLoop)
                {
                    Name = "NetworkServer-Accept",
                    IsBackground = true
                };
                _acceptThread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[NetworkServer] Fehler beim Start: {ex.Message}");
                _isRunning = false;
            }
        }
        
        /// <summary>
        /// Server stoppen
        /// </summary>
        public void Stop()
        {
            _isRunning = false;
            
            try
            {
                _listener?.Stop();
                
                // Alle Clients trennen
                lock (_clientsLock)
                {
                    foreach (var client in _clients)
                    {
                        DisconnectClient(client, "Server shutting down");
                    }
                    _clients.Clear();
                }
                
                Console.WriteLine("[NetworkServer] Gestoppt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[NetworkServer] Fehler beim Stoppen: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Accept-Schleife für neue Verbindungen
        /// </summary>
        private void AcceptLoop()
        {
            while (_isRunning)
            {
                try
                {
                    var tcpClient = _listener.AcceptTcpClient();
                    Console.WriteLine($"[NetworkServer] Neue Verbindung von {tcpClient.Client.RemoteEndPoint}");
                    
                    // Client verarbeiten
                    var client = new ConnectedClient
                    {
                        TcpClient = tcpClient,
                        Stream = tcpClient.GetStream(),
                        PlayerId = -1, // Wird bei Join zugewiesen
                        PlayerName = "Unknown"
                    };
                    
                    lock (_clientsLock)
                    {
                        // Max Players prüfen
                        if (_clients.Count >= MaxPlayers)
                        {
                            SendToClient(client, new ConnectResponsePacket
                            {
                                Success = false,
                                Reason = "Server is full"
                            });
                            tcpClient.Close();
                            continue;
                        }
                        
                        _clients.Add(client);
                    }
                    
                    // Receive-Thread für diesen Client starten
                    var receiveThread = new Thread(() => ReceiveLoop(client))
                    {
                        Name = $"Client-{client.PlayerId}-Receive",
                        IsBackground = true
                    };
                    receiveThread.Start();
                    
                    OnClientConnected?.Invoke(client);
                }
                catch (Exception ex)
                {
                    if (_isRunning)
                    {
                        Console.WriteLine($"[NetworkServer] Accept-Fehler: {ex.Message}");
                    }
                }
            }
        }
        
        /// <summary>
        /// Empfangsschleife für einen Client
        /// </summary>
        private void ReceiveLoop(ConnectedClient client)
        {
            var buffer = new byte[4096];
            
            while (_isRunning && client.TcpClient?.Connected == true)
            {
                try
                {
                    // Länge lesen (4 bytes)
                    int bytesRead = client.Stream.Read(buffer, 0, 4);
                    if (bytesRead < 4)
                        break;
                    
                    int packetLength = BitConverter.ToInt32(buffer, 0);
                    if (packetLength <= 0 || packetLength > 4096)
                    {
                        Console.WriteLine($"[NetworkServer] Ungültige Paket-Länge: {packetLength}");
                        break;
                    }
                    
                    // Paket-Daten lesen
                    bytesRead = client.Stream.Read(buffer, 0, packetLength);
                    if (bytesRead < packetLength)
                        break;
                    
                    var json = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    var packet = ParsePacket(json);
                    
                    if (packet != null)
                    {
                        client.UpdateActivity();
                        OnPacketReceived?.Invoke(client, packet);
                    }
                }
                catch (Exception ex)
                {
                    if (_isRunning)
                    {
                        Console.WriteLine($"[NetworkServer] Receive-Fehler von {client.PlayerName}: {ex.Message}");
                    }
                    break;
                }
            }
            
            // Client trennen
            DisconnectClient(client, "Connection lost");
        }
        
        /// <summary>
        /// Paket aus JSON parsen
        /// </summary>
        private NetworkPacket ParsePacket(string json)
        {
            try
            {
                // PacketType auslesen
                var typeData = JsonConvert.DeserializeObject<PacketTypeWrapper>(json);
                if (typeData == null || string.IsNullOrEmpty(typeData.PacketType))
                    return null;
                
                // Typ ermitteln
                var type = Type.GetType($"SOD_Multiplayer.Network.{typeData.PacketType}, SODMultiplayerServer");
                if (type == null)
                {
                    // Fallback
                    foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                    {
                        type = asm.GetType($"SOD_Multiplayer.Network.{typeData.PacketType}", false);
                        if (type != null)
                            break;
                    }
                }
                
                if (type != null && typeof(NetworkPacket).IsAssignableFrom(type))
                {
                    return JsonConvert.DeserializeObject(json, type) as NetworkPacket;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[NetworkServer] Parse-Fehler: {ex.Message}");
            }
            
            return null;
        }
        
        /// <summary>
        /// Client trennen
        /// </summary>
        public void DisconnectClient(ConnectedClient client, string reason)
        {
            if (client == null)
                return;
                
            try
            {
                // DISCONNECT Packet senden
                SendToClient(client, new DisconnectPacket { Reason = reason });
                
                client.TcpClient?.Close();
                
                lock (_clientsLock)
                {
                    _clients.Remove(client);
                }
                
                Console.WriteLine($"[NetworkServer] {client.PlayerName} getrennt: {reason}");
                OnClientDisconnected?.Invoke(client);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[NetworkServer] Fehler beim Trennen: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Paket an einen Client senden
        /// </summary>
        public void SendToClient(ConnectedClient client, NetworkPacket packet)
        {
            if (client?.Stream == null)
                return;
                
            try
            {
                var json = JsonConvert.SerializeObject(packet);
                var data = Encoding.UTF8.GetBytes(json);
                
                // Länge als Prefix
                var lengthPrefix = BitConverter.GetBytes(data.Length);
                client.Stream.Write(lengthPrefix, 0, 4);
                client.Stream.Write(data, 0, data.Length);
                client.Stream.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[NetworkServer] Sende-Fehler zu {client.PlayerName}: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Paket an alle Clients senden (Broadcast)
        /// </summary>
        public void BroadcastToAll(NetworkPacket packet, ConnectedClient exclude = null)
        {
            lock (_clientsLock)
            {
                foreach (var client in _clients)
                {
                    if (client != exclude)
                    {
                        SendToClient(client, packet);
                    }
                }
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
