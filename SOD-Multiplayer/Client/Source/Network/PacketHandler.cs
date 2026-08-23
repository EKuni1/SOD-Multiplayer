using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;

namespace SOD_Multiplayer.Network
{
    /// <summary>
    /// Basis-Klasse für alle Netzwerk-Pakete
    /// </summary>
    [JsonObject]
    public abstract class NetworkPacket
    {
        /// <summary>
        /// Typ des Pakets für Routing
        /// </summary>
        [JsonProperty("packetType")]
        public string PacketType => GetType().Name;
        
        /// <summary>
        /// Zeitstempel wann das Paket erstellt wurde
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    }
    
    // ==================== CONNECTION PACKETS ====================
    
    /// <summary>
    /// Anfrage zur Verbindung mit dem Server (Client → Server)
    /// </summary>
    [JsonObject]
    public class ConnectRequestPacket : NetworkPacket
    {
        [JsonProperty("playerName")]
        public string PlayerName { get; set; }
        
        [JsonProperty("clientVersion")]
        public string ClientVersion { get; set; }
    }
    
    /// <summary>
    /// Antwort auf Verbindungsanfrage (Server → Client)
    /// </summary>
    [JsonObject]
    public class ConnectResponsePacket : NetworkPacket
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        
        [JsonProperty("reason")]
        public string Reason { get; set; }
        
        [JsonProperty("serverName")]
        public string ServerName { get; set; }
        
        [JsonProperty("currentPlayers")]
        public int CurrentPlayers { get; set; }
        
        [JsonProperty("maxPlayers")]
        public int MaxPlayers { get; set; }
    }
    
    /// <summary>
    /// Verbindung trennen (Bidirektional)
    /// </summary>
    [JsonObject]
    public class DisconnectPacket : NetworkPacket
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
    
    // ==================== PLAYER PACKETS ====================
    
    /// <summary>
    /// Spieler ist beigetreten (Server → Client)
    /// </summary>
    [JsonObject]
    public class PlayerJoinPacket : NetworkPacket
    {
        [JsonProperty("playerId")]
        public int PlayerId { get; set; }
        
        [JsonProperty("playerName")]
        public string PlayerName { get; set; }
        
        [JsonProperty("isLocalPlayer")]
        public bool IsLocalPlayer { get; set; }
    }
    
    /// <summary>
    /// Spieler hat verlassen (Server → Client)
    /// </summary>
    [JsonObject]
    public class PlayerLeavePacket : NetworkPacket
    {
        [JsonProperty("playerId")]
        public int PlayerId { get; set; }
        
        [JsonProperty("playerName")]
        public string PlayerName { get; set; }
        
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
    
    /// <summary>
    /// Spieler-Position (Client → Server / Server → Client)
    /// </summary>
    [JsonObject]
    public class PlayerPositionPacket : NetworkPacket
    {
        [JsonProperty("playerId")]
        public int PlayerId { get; set; }
        
        [JsonProperty("x")]
        public float X { get; set; }
        
        [JsonProperty("y")]
        public float Y { get; set; }
        
        [JsonProperty("z")]
        public float Z { get; set; }
        
        [JsonProperty("rotationY")]
        public float RotationY { get; set; }
    }
    
    // ==================== PASSWORD PACKETS ====================
    
    /// <summary>
    /// Passwort-Abfrage (Server → Client)
    /// </summary>
    [JsonObject]
    public class PasswordChallengePacket : NetworkPacket
    {
        [JsonProperty("challenge")]
        public string Challenge { get; set; }
    }
    
    /// <summary>
    /// Passwort-Antwort (Client → Server)
    /// </summary>
    [JsonObject]
    public class PasswordResponsePacket : NetworkPacket
    {
        [JsonProperty("hashedPassword")]
        public string HashedPassword { get; set; }
    }
    
    /// <summary>
    /// Passwort-Ergebnis (Server → Client)
    /// </summary>
    [JsonObject]
    public class PasswordResultPacket : NetworkPacket
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
    
    // ==================== GAME STATE PACKETS ====================
    
    /// <summary>
    /// Spielzeit aktualisieren (Server → Client)
    /// </summary>
    [JsonObject]
    public class GameTimePacket : NetworkPacket
    {
        [JsonProperty("gameTime")]
        public float GameTime { get; set; }
        
        [JsonProperty("day")]
        public int Day { get; set; }
        
        [JsonProperty("date")]
        public int Date { get; set; }
        
        [JsonProperty("month")]
        public int Month { get; set; }
        
        [JsonProperty("year")]
        public int Year { get; set; }
    }
    
    /// <summary>
    /// Wetter aktualisieren (Server → Client)
    /// </summary>
    [JsonObject]
    public class WeatherPacket : NetworkPacket
    {
        [JsonProperty("rain")]
        public float Rain { get; set; }
        
        [JsonProperty("wind")]
        public float Wind { get; set; }
        
        [JsonProperty("snow")]
        public float Snow { get; set; }
        
        [JsonProperty("lightning")]
        public float Lightning { get; set; }
        
        [JsonProperty("fog")]
        public float Fog { get; set; }
    }
    
    // ==================== PACKET HANDLER ====================
    
    /// <summary>
    /// Verarbeitet eingehende Pakete und ruft entsprechende Handler auf
    /// </summary>
    public class PacketHandler
    {
        private readonly NetworkClient _client;
        private readonly Dictionary<string, Action<NetworkPacket>> _handlers = new Dictionary<string, Action<NetworkPacket>>();
        
        public PacketHandler(NetworkClient client)
        {
            _client = client;
        }
        
        /// <summary>
        /// Handler für einen bestimmten Paket-Typ registrieren
        /// </summary>
        public void RegisterHandler<T>(Action<T> handler) where T : NetworkPacket
        {
            var packetType = typeof(T).Name;
            _handlers[packetType] = (packet) => handler((T)packet);
            
            MultiplayerMod.Instance?.Log.LogDebug($"Handler registriert: {packetType}");
        }
        
        /// <summary>
        /// Eingehendes Paket verarbeiten
        /// </summary>
        public void HandlePacket(NetworkPacket packet)
        {
            if (packet == null)
                return;
                
            var packetType = packet.PacketType;
            
            if (_handlers.TryGetValue(packetType, out var handler))
            {
                try
                {
                    handler.Invoke(packet);
                }
                catch (Exception ex)
                {
                    MultiplayerMod.Instance?.Log.LogError($"Fehler im Handler {packetType}: {ex.Message}");
                }
            }
            else
            {
                MultiplayerMod.Instance?.Log.LogWarning($"Kein Handler für {packetType}");
            }
        }
        
        /// <summary>
        /// Paket aus JSON deserialisieren
        /// </summary>
        public NetworkPacket DeserializePacket(string packetType, string json)
        {
            try
            {
                var type = Type.GetType($"SOD_Multiplayer.Network.{packetType}, SODMultiplayerClient");
                if (type == null)
                {
                    // Fallback: Suche in aktueller Assembly
                    foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                    {
                        type = asm.GetType($"SOD_Multiplayer.Network.{packetType}", false);
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
                MultiplayerMod.Instance?.Log.LogError($"Deserialisierungsfehler: {ex.Message}");
            }
            
            return null;
        }
    }
}
