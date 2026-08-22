using System;

namespace SOD_Multiplayer.MasterServer.Models
{
    /// <summary>
    /// Server-Informationen für die Serverliste
    /// </summary>
    public class ServerInfo
    {
        /// <summary>
        /// Eindeutige Server-ID
        /// </summary>
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        
        /// <summary>
        /// Server-Name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// IP-Adresse oder Hostname
        /// </summary>
        public string IpAddress { get; set; }
        
        /// <summary>
        /// Game-Port
        /// </summary>
        public int Port { get; set; }
        
        /// <summary>
        /// Maximale Spielerzahl
        /// </summary>
        public int MaxPlayers { get; set; } = 4;
        
        /// <summary>
        /// Aktuelle Spielerzahl
        /// </summary>
        public int CurrentPlayers { get; set; }
        
        /// <summary>
        /// Hat der Server ein Passwort?
        /// </summary>
        public bool HasPassword { get; set; }
        
        /// <summary>
        /// Region (EU, US, etc.)
        /// </summary>
        public string Region { get; set; } = "EU";
        
        /// <summary>
        /// Server-Version
        /// </summary>
        public string Version { get; set; } = "0.1.0";
        
        /// <summary>
        /// Zeitpunkt der Registrierung
        /// </summary>
        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
        
        /// <summary>
        /// Letzter Heartbeat
        /// </summary>
        public DateTime LastHeartbeat { get; set; } = DateTime.UtcNow;
        
        /// <summary>
        /// Ist der Server online?
        /// </summary>
        public bool IsOnline => (DateTime.UtcNow - LastHeartbeat).TotalSeconds < 30;
        
        /// <summary>
        /// Status als String
        /// </summary>
        public string Status => IsOnline ? "online" : "offline";
    }
    
    /// <summary>
    /// Request für Server-Registrierung
    /// </summary>
    public class RegisterServerRequest
    {
        public string ServerName { get; set; }
        public int Port { get; set; }
        public int MaxPlayers { get; set; } = 4;
        public bool HasPassword { get; set; }
        public string Region { get; set; } = "EU";
        public string Version { get; set; } = "0.1.0";
    }
    
    /// <summary>
    /// Response für Server-Registrierung
    /// </summary>
    public class RegisterServerResponse
    {
        public bool Success { get; set; }
        public string ServerId { get; set; }
        public string Message { get; set; }
    }
    
    /// <summary>
    /// Request für Heartbeat
    /// </summary>
    public class HeartbeatRequest
    {
        public int CurrentPlayers { get; set; }
        public long Timestamp { get; set; }
    }
    
    /// <summary>
    /// Response für Serverliste
    /// </summary>
    public class ServerListResponse
    {
        public ServerInfo[] Servers { get; set; } = Array.Empty<ServerInfo>();
        public int TotalCount { get; set; }
    }
}
