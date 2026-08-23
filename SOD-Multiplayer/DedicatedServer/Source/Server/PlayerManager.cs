using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using SOD_Multiplayer.Network;

namespace SOD_Multiplayer.Server
{
    /// <summary>
    /// Verwaltet Spieler auf dem Server
    /// Handhabt Join/Leave, Player-IDs und Passwort-Prüfung
    /// </summary>
    public class PlayerManager
    {
        private readonly NetworkServer _networkServer;
        private readonly object _lock = new object();
        
        /// <summary>
        /// Nächste zu vergebende Player-ID
        /// </summary>
        private int _nextPlayerId = 1;
        
        /// <summary>
        /// Verbundene Spieler
        /// </summary>
        private readonly Dictionary<int, ConnectedClient> _players = new Dictionary<int, ConnectedClient>();
        
        /// <summary>
        /// Aktuelle Spielerzahl
        /// </summary>
        public int PlayerCount => _players.Count;
        
        /// <summary>
        /// Maximale Spielerzahl
        /// </summary>
        public int MaxPlayers => _networkServer.MaxPlayers;
        
        public PlayerManager(NetworkServer networkServer)
        {
            _networkServer = networkServer;
        }
        
        /// <summary>
        /// CONNECT_REQUEST verarbeiten
        /// </summary>
        public void HandleConnectRequest(ConnectedClient client, ConnectRequestPacket packet)
        {
            Console.WriteLine($"[PlayerManager] Connect-Anfrage von {packet.PlayerName}");
            
            // Client-Version prüfen
            if (packet.ClientVersion != "0.1.0")
            {
                _networkServer.SendToClient(client, new ConnectResponsePacket
                {
                    Success = false,
                    Reason = $"Incompatible version! Server: 0.1.0, Client: {packet.ClientVersion}"
                });
                _networkServer.DisconnectClient(client, "Version mismatch");
                return;
            }
            
            // Spielername speichern
            client.PlayerName = packet.PlayerName ?? "Unknown";
            
            // Prüfen ob Passwort erforderlich ist
            var gameServer = GameServerInstance.Instance;
            if (!string.IsNullOrEmpty(gameServer?.Config.Password))
            {
                // Passwort-Abfrage senden
                Console.WriteLine($"[PlayerManager] Passwort-Abfrage für {client.PlayerName}");
                _networkServer.SendToClient(client, new PasswordChallengePacket
                {
                    Challenge = GenerateChallenge()
                });
                return;
            }
            
            // Kein Passwort - direkt verbinden
            AcceptPlayer(client);
        }
        
        /// <summary>
        /// PASSWORD_RESPONSE verarbeiten
        /// </summary>
        public void HandlePasswordResponse(ConnectedClient client, PasswordResponsePacket packet)
        {
            Console.WriteLine($"[PlayerManager] Passwort-Antwort von {client.PlayerName}");
            
            var gameServer = GameServerInstance.Instance;
            if (gameServer == null || string.IsNullOrEmpty(gameServer.Config.Password))
            {
                _networkServer.SendToClient(client, new PasswordResultPacket
                {
                    Success = false,
                    Reason = "Server does not require password"
                });
                return;
            }
            
            // Passwort hashen und vergleichen
            var expectedHash = HashPassword(gameServer.Config.Password);
            
            if (packet.HashedPassword == expectedHash)
            {
                Console.WriteLine($"[PlayerManager] Passwort korrekt für {client.PlayerName}");
                _networkServer.SendToClient(client, new PasswordResultPacket
                {
                    Success = true
                });
                
                // Spieler akzeptieren
                AcceptPlayer(client);
            }
            else
            {
                Console.WriteLine($"[PlayerManager] Falsches Passwort von {client.PlayerName}");
                _networkServer.SendToClient(client, new PasswordResultPacket
                {
                    Success = false,
                    Reason = "Wrong password"
                });
                _networkServer.DisconnectClient(client, "Wrong password");
            }
        }
        
        /// <summary>
        /// Spieler akzeptieren und ins Spiel aufnehmen
        /// </summary>
        private void AcceptPlayer(ConnectedClient client)
        {
            lock (_lock)
            {
                // Max Players prüfen
                if (_players.Count >= MaxPlayers)
                {
                    _networkServer.SendToClient(client, new ConnectResponsePacket
                    {
                        Success = false,
                        Reason = "Server is full",
                        CurrentPlayers = _players.Count,
                        MaxPlayers = MaxPlayers
                    });
                    _networkServer.DisconnectClient(client, "Server full");
                    return;
                }
                
                // Player-ID zuweisen
                client.PlayerId = _nextPlayerId++;
                _players[client.PlayerId] = client;
                client.IsAuthenticated = true;
                
                Console.WriteLine($"[PlayerManager] {client.PlayerName} verbunden als Player {client.PlayerId}");
                
                // CONNECT_RESPONSE senden
                var gameServer = GameServerInstance.Instance;
                _networkServer.SendToClient(client, new ConnectResponsePacket
                {
                    Success = true,
                    ServerName = gameServer?.Config.ServerName ?? "SOD Server",
                    CurrentPlayers = _players.Count,
                    MaxPlayers = MaxPlayers
                });
                
                // PLAYER_JOIN an alle broadcasten
                var joinPacket = new PlayerJoinPacket
                {
                    PlayerId = client.PlayerId,
                    PlayerName = client.PlayerName,
                    IsLocalPlayer = true // Für diesen Client
                };
                _networkServer.SendToClient(client, joinPacket);
                
                // Andere Clients informieren
                joinPacket.IsLocalPlayer = false;
                _networkServer.BroadcastToAll(joinPacket, client);
                
                // Existierende Spieler dem neuen Client zeigen
                foreach (var otherPlayer in _players.Values)
                {
                    if (otherPlayer.PlayerId != client.PlayerId)
                    {
                        _networkServer.SendToClient(client, new PlayerJoinPacket
                        {
                            PlayerId = otherPlayer.PlayerId,
                            PlayerName = otherPlayer.PlayerName,
                            IsLocalPlayer = false
                        });
                    }
                }
            }
        }
        
        /// <summary>
        /// DISCONNECT verarbeiten
        /// </summary>
        public void HandleDisconnect(ConnectedClient client, string reason)
        {
            RemovePlayer(client.PlayerId, reason ?? "Client disconnected");
        }
        
        /// <summary>
        /// Spieler entfernen
        /// </summary>
        public void RemovePlayer(int playerId, string reason)
        {
            lock (_lock)
            {
                if (!_players.TryGetValue(playerId, out var client))
                    return;
                    
                Console.WriteLine($"[PlayerManager] {client.PlayerName} entfernt: {reason}");
                
                // PLAYER_LEAVE broadcasten
                var leavePacket = new PlayerLeavePacket
                {
                    PlayerId = playerId,
                    PlayerName = client.PlayerName,
                    Reason = reason
                };
                _networkServer.BroadcastToAll(leavePacket);
                
                _players.Remove(playerId);
                _networkServer.DisconnectClient(client, reason);
            }
        }
        
        /// <summary>
        /// Zufällige Challenge für Passwort-Hashing generieren
        /// </summary>
        private string GenerateChallenge()
        {
            var bytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }
            return Convert.ToBase64String(bytes);
        }
        
        /// <summary>
        /// Passwort hashen (SHA-256)
        /// </summary>
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
        
        /// <summary>
        /// Client nach Player-ID suchen
        /// </summary>
        public ConnectedClient GetPlayerById(int playerId)
        {
            lock (_lock)
            {
                _players.TryGetValue(playerId, out var client);
                return client;
            }
        }
        
        /// <summary>
        /// Alle Spieler holen
        /// </summary>
        public List<ConnectedClient> GetAllPlayers()
        {
            lock (_lock)
            {
                return new List<ConnectedClient>(_players.Values);
            }
        }
    }
    
    /// <summary>
    /// Singleton-Zugriff auf GameServer Instance
    /// Wird benötigt für Config-Zugriff in PlayerManager
    /// </summary>
    public static class GameServerInstance
    {
        public static GameServer Instance { get; set; }
    }
}
