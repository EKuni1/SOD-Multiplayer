using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

/// <summary>
/// SOD Multiplayer Mod - Haupt-Manager für Multiplayer-Funktionalität
/// Verwaltet die Verbindung zum Hauptserver und die Kommunikation mit anderen Spielern
/// </summary>
[Token(Token = "0x2000602")]
public class MultiplayerManager : MonoBehaviour
{
    [Token(Token = "0x4002520")]
    [FieldOffset(Offset = "0x18")]
    private static MultiplayerManager _instance;
    
    [Token(Token = "0x4002521")]
    [FieldOffset(Offset = "0x20")]
    public static MultiplayerManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("MultiplayerManager");
                _instance = go.AddComponent<MultiplayerManager>();
                DontDestroyOnLoad(go);
            }
            return _instance;
        }
    }
    
    [Token(Token = "0x4002522")]
    [FieldOffset(Offset = "0x28")]
    private bool isInitialized;
    
    [Token(Token = "0x4002523")]
    [FieldOffset(Offset = "0x2C")]
    private bool isConnected;
    
    [Token(Token = "0x4002524")]
    [FieldOffset(Offset = "0x30")]
    private CSteamID currentLobbyID;
    
    [Token(Token = "0x4002525")]
    [FieldOffset(Offset = "0x38")]
    private List<ServerInfo> cachedServerList;
    
    [Token(Token = "0x4002526")]
    [FieldOffset(Offset = "0x40")]
    private HSteamNetConnection serverConnection;
    
    [Token(Token = "0x4002527")]
    [FieldOffset(Offset = "0x48")]
    public string MasterServerAddress;
    
    [Token(Token = "0x4002528")]
    [FieldOffset(Offset = "0x50")]
    public int MasterServerPort;
    
    // Callbacks für Steam Networking
    [Token(Token = "0x4002529")]
    [FieldOffset(Offset = "0x58")]
    protected Callback<LobbyCreated_t> m_LobbyCreated;
    
    [Token(Token = "0x4002530")]
    [FieldOffset(Offset = "0x60")]
    protected Callback<LobbyEnter_t> m_LobbyEnter;
    
    [Token(Token = "0x4002531")]
    [FieldOffset(Offset = "0x68")]
    protected Callback<LobbyMatchList_t> m_LobbyMatchList;
    
    [Token(Token = "0x6002020")]
    [Address(RVA = "0xB02000", Offset = "0xB01000", VA = "0x180B02000")]
    public void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }
        
        _instance = this;
        DontDestroyOnLoad(gameObject);
        Initialize();
    }
    
    [Token(Token = "0x6002021")]
    [Address(RVA = "0xB02100", Offset = "0xB01100", VA = "0x180B02100")]
    private void Initialize()
    {
        if (isInitialized)
            return;
        
        // Standard Master Server Adresse (Linux Server)
        MasterServerAddress = "master.shadowofdoubt.multiplayer";
        MasterServerPort = 27015;
        
        // Steam Callbacks registrieren
        m_LobbyCreated = Callback<LobbyCreated_t>.Create(OnLobbyCreated);
        m_LobbyEnter = Callback<LobbyEnter_t>.Create(OnLobbyEnter);
        m_LobbyMatchList = Callback<LobbyMatchList_t>.Create(OnLobbyMatchList);
        
        isInitialized = true;
        Debug.Log("[SOD Multiplayer] Manager initialisiert");
    }
    
    [Token(Token = "0x6002022")]
    [Address(RVA = "0xB02200", Offset = "0xB01200", VA = "0x180B02200")]
    public void RequestServerList()
    {
        if (!isInitialized)
        {
            Debug.LogError("[SOD Multiplayer] Manager nicht initialisiert!");
            return;
        }
        
        Debug.Log("[SOD Multiplayer] Anfrage an Master-Server gesendet");
        
        // Steam Lobby-Suche starten
        SteamMatchmaking.AddRequestLobbyListDistance(ELobbyDistance.k_ELobbyDistanceWorldwide);
        SteamMatchmaking.AddRequestLobbyListMaxSlotsAvailable(1); // Mindestens 1 freier Slot
        SteamMatchmaking.AddRequestLobbyListFilterSlotsAvailable(1);
        SteamMatchmaking.AddRequestLobbyListResultCountFilter(100); // Maximal 100 Server
        
        // Suche ausführen
        SteamAPICall_t hSteamAPICall = SteamMatchmaking.RequestLobbyList();
        
        cachedServerList = new List<ServerInfo>();
    }
    
    [Token(Token = "0x6002023")]
    [Address(RVA = "0xB02300", Offset = "0xB01300", VA = "0x180B02300")]
    private void OnLobbyMatchList(LobbyMatchList_t callback)
    {
        Debug.Log($"[SOD Multiplayer] {callback.m_nLobbiesMatching} Lobbys gefunden");
        
        cachedServerList.Clear();
        
        for (uint i = 0; i < callback.m_nLobbiesMatching; i++)
        {
            CSteamID lobbyID = SteamMatchmaking.GetLobbyByIndex((int)i);
            
            string name = SteamMatchmaking.GetLobbyData(lobbyID, "name");
            string mapName = SteamMatchmaking.GetLobbyData(lobbyID, "map");
            string maxPlayersStr = SteamMatchmaking.GetLobbyData(lobbyID, "max_players");
            string passwordStr = SteamMatchmaking.GetLobbyData(lobbyID, "password");
            
            int.TryParse(SteamMatchmaking.GetLobbyData(lobbyID, "players"), out int currentPlayers);
            int.TryParse(maxPlayersStr, out int maxPlayers);
            bool requiresPassword = passwordStr == "true";
            
            ServerInfo server = new ServerInfo
            {
                ServerName = name ?? "Unbekannter Server",
                ServerSteamID = lobbyID,
                CurrentPlayers = currentPlayers,
                MaxPlayers = Math.Min(maxPlayers, 4), // Maximal 4 Spieler
                MapName = mapName ?? "Standard",
                RequiresPassword = requiresPassword
            };
            
            cachedServerList.Add(server);
        }
        
        // UI aktualisieren
        ServerBrowserUI browser = FindObjectOfType<ServerBrowserUI>();
        if (browser != null)
        {
            browser.UpdateServerList(cachedServerList);
        }
    }
    
    [Token(Token = "0x6002024")]
    [Address(RVA = "0xB02400", Offset = "0xB01400", VA = "0x180B02400")]
    public void JoinServer(ServerInfo server, string password = "")
    {
        if (server == null)
        {
            Debug.LogError("[SOD Multiplayer] Kein Server ausgewählt");
            return;
        }
        
        Debug.Log($"[SOD Multiplayer] Versuche Server zu joinen: {server.ServerName}");
        
        // Passwort setzen falls erforderlich
        if (server.RequiresPassword && !string.IsNullOrEmpty(password))
        {
            SteamMatchmaking.SetLobbyJoinSecret(server.ServerSteamID, password);
        }
        
        // Server joinen
        SteamAPICall_t hSteamAPICall = SteamMatchmaking.JoinLobby(server.ServerSteamID);
    }
    
    [Token(Token = "0x6002025")]
    [Address(RVA = "0xB02500", Offset = "0xB01500", VA = "0x180B02500")]
    private void OnLobbyEnter(LobbyEnter_t callback)
    {
        Debug.Log($"[SOD Multiplayer] Lobby betreten: {callback.m_rgfChatRoomEnterResponse}");
        
        if (callback.m_rgfChatRoomEnterResponse == (uint)EChatRoomEnterResponse.Success)
        {
            currentLobbyID = new CSteamID(callback.m_ulSteamIDLobby);
            isConnected = true;
            
            Debug.Log($"[SOD Multiplayer] Erfolgreich verbunden mit Lobby: {currentLobbyID}");
            
            // Spiel laden / synchronisieren
            SynchronizeGameState();
        }
        else
        {
            Debug.LogError($"[SOD Multiplayer] Fehler beim Verbinden: {(EChatRoomEnterResponse)callback.m_rgfChatRoomEnterResponse}");
            isConnected = false;
        }
    }
    
    [Token(Token = "0x6002026")]
    [Address(RVA = "0xB02600", Offset = "0xB01600", VA = "0x180B02600")]
    public void CreateServer(string serverName, string mapName, string password = "", int maxPlayers = 4)
    {
        if (!isInitialized)
        {
            Debug.LogError("[SOD Multiplayer] Manager nicht initialisiert!");
            return;
        }
        
        Debug.Log($"[SOD Multiplayer] Erstelle neuen Server: {serverName}");
        
        // Lobby erstellen
        SteamMatchmaking.CreateLobby(ELobbyType.k_ELobbyTypeFriendsOnly, maxPlayers);
        
        // Lobby-Daten setzen
        SteamMatchmaking.SetLobbyData(new CSteamID(), "name", serverName);
        SteamMatchmaking.SetLobbyData(new CSteamID(), "map", mapName);
        SteamMatchmaking.SetLobbyData(new CSteamID(), "max_players", maxPlayers.ToString());
        SteamMatchmaking.SetLobbyData(new CSteamID(), "password", string.IsNullOrEmpty(password) ? "false" : "true");
        
        if (!string.IsNullOrEmpty(password))
        {
            SteamMatchmaking.SetLobbyJoinSecret(new CSteamID(), password);
        }
    }
    
    [Token(Token = "0x6002027")]
    [Address(RVA = "0xB02700", Offset = "0xB01700", VA = "0x180B02700")]
    private void OnLobbyCreated(LobbyCreated_t callback)
    {
        Debug.Log($"[SOD Multiplayer] Lobby erstellt: {callback.m_eResult}");
        
        if (callback.m_eResult == EResult.k_EResultOK)
        {
            currentLobbyID = new CSteamID(callback.m_ulSteamIDLobby);
            isConnected = true;
            
            Debug.Log($"[SOD Multiplayer] Server erfolgreich erstellt: {currentLobbyID}");
        }
        else
        {
            Debug.LogError($"[SOD Multiplayer] Fehler beim Erstellen: {callback.m_eResult}");
        }
    }
    
    [Token(Token = "0x6002028")]
    [Address(RVA = "0xB02800", Offset = "0xB01800", VA = "0x180B02800")]
    private void SynchronizeGameState()
    {
        // Spielzustand mit anderen Spielern synchronisieren
        // Hier werden Harmony-Hooks verwendet um den Spielzustand zu syncen
        
        Debug.Log("[SOD Multiplayer] Synchronisiere Spielzustand...");
        
        // Session-Daten synchronisieren
        var sessionData = SessionData.Instance;
        if (sessionData != null)
        {
            // Session-Daten für Multiplayer vorbereiten
            PrepareSessionForMultiplayer(sessionData);
        }
    }
    
    [Token(Token = "0x6002029")]
    [Address(RVA = "0xB02900", Offset = "0xB01900", VA = "0x180B02900")]
    private void PrepareSessionForMultiplayer(SessionData sessionData)
    {
        // Session-Daten für Multiplayer anpassen
        // Diese Methode wird durch Harmony-Patches erweitert
    }
    
    [Token(Token = "0x6002030")]
    [Address(RVA = "0xB02A00", Offset = "0xB01A00", VA = "0x180B02A00")]
    public void LeaveServer()
    {
        if (currentLobbyID.IsValid)
        {
            SteamMatchmaking.LeaveLobby(currentLobbyID);
            currentLobbyID = new CSteamID();
            isConnected = false;
            
            Debug.Log("[SOD Multiplayer] Server verlassen");
        }
    }
    
    [Token(Token = "0x6002031")]
    [Address(RVA = "0xB02B00", Offset = "0xB01B00", VA = "0x180B02B00")]
    public bool IsConnected()
    {
        return isConnected && currentLobbyID.IsValid;
    }
    
    [Token(Token = "0x6002032")]
    [Address(RVA = "0xB02C00", Offset = "0xB01C00", VA = "0x180B02C00")]
    public CSteamID GetCurrentLobbyID()
    {
        return currentLobbyID;
    }
}
