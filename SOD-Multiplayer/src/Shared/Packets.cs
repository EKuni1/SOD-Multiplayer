using System;
using System.Collections.Generic;

namespace SOD.Multiplayer.Shared
{
    // Packet Types
    public enum PacketType
    {
        // Client -> Server
        JoinRequest = 1,
        LeaveRequest = 2,
        PlayerUpdate = 3,
        ChatMessage = 4,
        SessionSelected = 5,
        WorldEvent = 6,
        
        // Server -> Client
        JoinAccepted = 10,
        JoinRejected = 11,
        PlayerJoined = 12,
        PlayerLeft = 13,
        PlayerList = 14,
        GameState = 15,
        ChatBroadcast = 16,
        
        // Master Server
        ServerRegister = 20,
        ServerHeartbeat = 21,
        ServerListRequest = 22,
        ServerListResponse = 23
    }

    // Base Packet
    public class Packet
    {
        public PacketType Type { get; set; }
        public string SenderId { get; set; } = "";
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float GameTime { get; set; }
    }

    public class WorldEventPacket : Packet
    {
        public string EventType { get; set; } = "";
        public string ObjectId { get; set; } = "";
        public string Value { get; set; } = "";
        public float NumericValue { get; set; }
    }

    // Connection Packets
    public class JoinRequestPacket : Packet
    {
        public string PlayerName { get; set; } = "";
        public string Password { get; set; } = "";
    }

    public class JoinResponsePacket : Packet
    {
        public bool Accepted { get; set; }
        public string Reason { get; set; } = "";
        public string AssignedPlayerId { get; set; } = "";
    }

    public class SessionSelectedPacket : Packet
    {
        public string SaveFileName { get; set; } = "";
        public string MapName { get; set; } = "";
    }

    // Player Info
    public class PlayerInfo
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public bool IsHost { get; set; }
    }

    // Server Info for Master Server
    public class ServerInfo
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "Unknown";
        public string Ip { get; set; } = "";
        public int Port { get; set; } = 7777;
        public int CurrentPlayers { get; set; }
        public int MaxPlayers { get; set; } = 4;
        public bool HasPassword { get; set; }
        public string Map { get; set; } = "";
        public string SaveGame { get; set; } = "";
        public DateTime LastHeartbeat { get; set; } = DateTime.UtcNow;
    }

    // Game State Sync
    public class GameStatePacket : Packet
    {
        public List<PlayerInfo> Players { get; set; } = new();
        public string TimeOfDay { get; set; } = "12:00";
        public float GameTime { get; set; }
        public string CurrentMission { get; set; } = "";
    }

    // Chat
    public class ChatPacket : Packet
    {
        public string Message { get; set; } = "";
        public bool IsGlobal { get; set; } = false;
    }
}
