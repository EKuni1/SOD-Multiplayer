using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using Newtonsoft.Json;

namespace SOD_Multiplayer.Network
{
    /// <summary>
    /// Basis-Klasse für alle Netzwerk-Pakete (Server-Seite)
    /// Identisch mit Client-Seite für Kompatibilität
    /// </summary>
    [JsonObject]
    public abstract class NetworkPacket
    {
        [JsonProperty("packetType")]
        public string PacketType => GetType().Name;
        
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    }
    
    // ==================== CONNECTION PACKETS ====================
    
    [JsonObject]
    public class ConnectRequestPacket : NetworkPacket
    {
        [JsonProperty("playerName")]
        public string PlayerName { get; set; }
        
        [JsonProperty("clientVersion")]
        public string ClientVersion { get; set; }
    }
    
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
    
    [JsonObject]
    public class DisconnectPacket : NetworkPacket
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
    
    // ==================== PLAYER PACKETS ====================
    
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
    
    [JsonObject]
    public class PasswordChallengePacket : NetworkPacket
    {
        [JsonProperty("challenge")]
        public string Challenge { get; set; }
    }
    
    [JsonObject]
    public class PasswordResponsePacket : NetworkPacket
    {
        [JsonProperty("hashedPassword")]
        public string HashedPassword { get; set; }
    }
    
    [JsonObject]
    public class PasswordResultPacket : NetworkPacket
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
    
    // ==================== GAME STATE PACKETS ====================
    
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
}
