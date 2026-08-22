using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using SOD_Multiplayer.MasterServer.Models;

namespace SOD_Multiplayer.MasterServer
{
    /// <summary>
    /// Verwaltet die Serverliste für den Master-Server
    /// </summary>
    public class ServerListManager
    {
        /// <summary>
        /// Alle registrierten Server
        /// </summary>
        private readonly ConcurrentDictionary<string, ServerInfo> _servers = new ConcurrentDictionary<string, ServerInfo>();
        
        /// <summary>
        /// Cleanup-Timer für inaktive Server
        /// </summary>
        private Timer _cleanupTimer;
        
        /// <summary>
        /// Anzahl der Server
        /// </summary>
        public int ServerCount => _servers.Count;
        
        public ServerListManager()
        {
            // Cleanup-Timer starten (alle 30 Sekunden)
            _cleanupTimer = new Timer(CleanupInactiveServers, null, TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(30));
            
            Console.WriteLine("[ServerListManager] Initialisiert");
        }
        
        /// <summary>
        /// Server registrieren
        /// </summary>
        public ServerInfo RegisterServer(RegisterServerRequest request, string clientIp)
        {
            var server = new ServerInfo
            {
                Id = Guid.NewGuid().ToString("N"),
                Name = request.ServerName ?? "Unknown Server",
                IpAddress = clientIp,
                Port = request.Port,
                MaxPlayers = Math.Min(request.MaxPlayers, 4), // Max 4 erzwingen
                CurrentPlayers = 0,
                HasPassword = request.HasPassword,
                Region = request.Region ?? "EU",
                Version = request.Version ?? "0.1.0",
                RegisteredAt = DateTime.UtcNow,
                LastHeartbeat = DateTime.UtcNow
            };
            
            if (_servers.TryAdd(server.Id, server))
            {
                Console.WriteLine($"[ServerListManager] Server registriert: {server.Name} ({server.Id})");
                return server;
            }
            
            return null;
        }
        
        /// <summary>
        /// Server deregistrieren
        /// </summary>
        public bool UnregisterServer(string serverId)
        {
            if (_servers.TryRemove(serverId, out var server))
            {
                Console.WriteLine($"[ServerListManager] Server entfernt: {server.Name} ({serverId})");
                return true;
            }
            
            return false;
        }
        
        /// <summary>
        /// Heartbeat empfangen
        /// </summary>
        public bool ReceiveHeartbeat(string serverId, int currentPlayers)
        {
            if (_servers.TryGetValue(serverId, out var server))
            {
                server.LastHeartbeat = DateTime.UtcNow;
                server.CurrentPlayers = currentPlayers;
                return true;
            }
            
            return false;
        }
        
        /// <summary>
        /// Alle Online-Server holen
        /// </summary>
        public List<ServerInfo> GetOnlineServers()
        {
            return _servers.Values.Where(s => s.IsOnline).ToList();
        }
        
        /// <summary>
        /// Server nach ID holen
        /// </summary>
        public ServerInfo GetServerById(string serverId)
        {
            _servers.TryGetValue(serverId, out var server);
            return server;
        }
        
        /// <summary>
        /// Inaktive Server entfernen (Timeout: 30 Sekunden)
        /// </summary>
        private void CleanupInactiveServers(object state)
        {
            var now = DateTime.UtcNow;
            var toRemove = new List<string>();
            
            foreach (var server in _servers.Values)
            {
                if ((now - server.LastHeartbeat).TotalSeconds > 30)
                {
                    toRemove.Add(server.Id);
                }
            }
            
            foreach (var id in toRemove)
            {
                if (_servers.TryRemove(id, out var server))
                {
                    Console.WriteLine($"[ServerListManager] Server timeout: {server.Name} ({id})");
                }
            }
            
            if (toRemove.Count > 0)
            {
                Console.WriteLine($"[ServerListManager] {toRemove.Count} inaktive Server entfernt");
            }
        }
        
        /// <summary>
        /// Manager stoppen
        /// </summary>
        public void Stop()
        {
            _cleanupTimer?.Dispose();
            _servers.Clear();
        }
    }
}
