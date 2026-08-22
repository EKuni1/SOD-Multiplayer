using System;
using Il2CppDummyDll;

/// <summary>
/// Server Information Data Structure
/// Enthält alle Informationen über einen Multiplayer-Server
/// </summary>
[Token(Token = "0x2000601")]
public class ServerInfo
{
    [Token(Token = "0x4002510")]
    [FieldOffset(Offset = "0x10")]
    public string ServerName;
    
    [Token(Token = "0x4002511")]
    [FieldOffset(Offset = "0x18")]
    public string ServerIP;
    
    [Token(Token = "0x4002512")]
    [FieldOffset(Offset = "0x20")]
    public int ServerPort;
    
    [Token(Token = "0x4002513")]
    [FieldOffset(Offset = "0x24")]
    public int CurrentPlayers;
    
    [Token(Token = "0x4002514")]
    [FieldOffset(Offset = "0x28")]
    public int MaxPlayers;
    
    [Token(Token = "0x4002515")]
    [FieldOffset(Offset = "0x2C")]
    public bool RequiresPassword;
    
    [Token(Token = "0x4002516")]
    [FieldOffset(Offset = "0x30")]
    public string MapName;
    
    [Token(Token = "0x4002517")]
    [FieldOffset(Offset = "0x38")]
    public string GameMode;
    
    [Token(Token = "0x4002518")]
    [FieldOffset(Offset = "0x40")]
    public int Ping;
    
    [Token(Token = "0x4002519")]
    [FieldOffset(Offset = "0x48")]
    public CSteamID ServerSteamID;
    
    [Token(Token = "0x6002010")]
    [Address(RVA = "0xB01000", Offset = "0xB00000", VA = "0x180B01000")]
    public ServerInfo()
    {
        MaxPlayers = 4; // Standard: Bis zu 4 Spieler
    }
    
    [Token(Token = "0x6002011")]
    [Address(RVA = "0xB01100", Offset = "0xB00100", VA = "0x180B01100")]
    public bool HasFreeSlot()
    {
        return CurrentPlayers < MaxPlayers;
    }
    
    [Token(Token = "0x6002012")]
    [Address(RVA = "0xB01200", Offset = "0xB00200", VA = "0x180B01200")]
    public override string ToString()
    {
        return $"{ServerName} ({CurrentPlayers}/{MaxPlayers}) - {MapName}";
    }
}
