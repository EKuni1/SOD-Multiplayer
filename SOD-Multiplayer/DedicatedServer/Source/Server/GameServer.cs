using System;
using System.Collections.Generic;
using SOD_Multiplayer.Network;

namespace SOD_Multiplayer.Server
{
    /// <summary>
    /// Hauptserver-Klasse für den Dedicated Multiplayer Server
    /// Verwaltet alle Komponenten und koordiniert das Spiel
    /// </summary>
    public class GameServer
    {
        private NetworkServer _networkServer;
        private PlayerManager _playerManager;
        private SessionManager _sessionManager;
        private MasterClient _masterClient;
        
        /// <summary>
        /// Server-Konfiguration
        /// </summary>
        public ServerConfig Config { get; private set; }
        
        /// <summary>
        /// Ist der Server laufend?
        /// </summary>
        public bool IsRunning { get; private set; }
        
        /// <summary>
        /// Aktuelle Spielerzahl
        /// </summary>
        public int PlayerCount => _playerManager?.PlayerCount ?? 0;
        
        /// <summary>
        /// Maximale Spielerzahl
        /// </summary>
        public int MaxPlayers => Config?.MaxPlayers ?? 4;
        
        public GameServer(ServerConfig config)
        {
            Config = config;
            Initialize();
        }
        
        /// <summary>
        /// Alle Komponenten initialisieren
        /// </summary>
        private void Initialize()
        {
            Console.WriteLine("[GameServer] Initialisierung...");
            
            // Netzwerk-Server
            _networkServer = new NetworkServer(Config.Port);
            _networkServer.MaxPlayers = Config.MaxPlayers;
            
            // Player Manager
            _playerManager = new PlayerManager(_networkServer);
            
            // Session Manager
            _sessionManager = new SessionManager(_networkServer, _playerManager);
            
            // Master Client (für Server-Registrierung)
            if (!string.IsNullOrEmpty(Config.MasterServerUrl))
            {
                _masterClient = new MasterClient(Config.MasterServerUrl, Config);
            }
            
            // Events verbinden
            _networkServer.OnPacketReceived += HandlePacket;
            
            Console.WriteLine("[GameServer] Initialisierung abgeschlossen");
        }
        
        /// <summary>
        /// Server starten
        /// </summary>
        public void Start()
        {
            if (IsRunning)
            {
                Console.WriteLine("[GameServer] Bereits laufend!");
                return;
            }
            
            Console.WriteLine($"[GameServer] Starte Server '{Config.ServerName}'...");
            Console.WriteLine($"[GameServer] Port: {Config.Port}");
            Console.WriteLine($"[GameServer] Max Players: {Config.MaxPlayers}");
            Console.WriteLine($"[GameServer] Passwort: {(string.IsNullOrEmpty(Config.Password) ? "Nein" : "Ja")}");
            
            // Netzwerk-Server starten
            _networkServer.Start();
            
            // Session starten
            _sessionManager.Start();
            
            // Bei Master-Server registrieren
            _masterClient?.RegisterServer();
            
            IsRunning = true;
            
            Console.WriteLine("[GameServer] Server ist online!");
        }
        
        /// <summary>
        /// Server stoppen
        /// </summary>
        public void Stop()
        {
            if (!IsRunning)
                return;
                
            Console.WriteLine("[GameServer] Stoppe Server...");
            
            // Von Master-Server abmelden
            _masterClient?.UnregisterServer();
            
            // Session stoppen
            _sessionManager.Stop();
            
            // Netzwerk-Server stoppen
            _networkServer.Stop();
            
            IsRunning = false;
            
            Console.WriteLine("[GameServer] Server gestoppt");
        }
        
        /// <summary>
        /// Eingehende Pakete verarbeiten
        /// </summary>
        private void HandlePacket(ConnectedClient client, NetworkPacket packet)
        {
            try
            {
                Console.WriteLine($"[GameServer] Paket von {client.PlayerName}: {packet.PacketType}");
                
                switch (packet)
                {
                    case ConnectRequestPacket connectReq:
                        _playerManager.HandleConnectRequest(client, connectReq);
                        break;
                        
                    case DisconnectPacket disconnect:
                        _playerManager.HandleDisconnect(client, disconnect.Reason);
                        break;
                        
                    case PlayerPositionPacket position:
                        _sessionManager.HandlePlayerPosition(client, position);
                        break;
                        
                    case PasswordResponsePacket passwordResp:
                        _playerManager.HandlePasswordResponse(client, passwordResp);
                        break;
                        
                    default:
                        Console.WriteLine($"[GameServer] Unbekannter Paket-Typ: {packet.PacketType}");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GameServer] Fehler bei Paket-Verarbeitung: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Heartbeat an Master-Server senden (wird periodisch aufgerufen)
        /// </summary>
        public void SendHeartbeat()
        {
            _masterClient?.SendHeartbeat(PlayerCount);
        }
        
        /// <summary>
        /// Broadcast an alle Clients
        /// </summary>
        public void BroadcastToAll(NetworkPacket packet, ConnectedClient exclude = null)
        {
            _networkServer?.BroadcastToAll(packet, exclude);
        }
    }
    
    /// <summary>
    /// Server-Konfiguration
    /// </summary>
    public class ServerConfig
    {
        public string ServerName { get; set; } = "SOD Multiplayer Server";
        public int Port { get; set; } = 27015;
        public int MaxPlayers { get; set; } = 4;
        public string Password { get; set; } = "";
        public string MasterServerUrl { get; set; } = "http://localhost:27016";
        public string Region { get; set; } = "EU";
    }
}
