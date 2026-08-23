# Shadow of Doubt Multiplayer Mod - Phasen 2, 3, 4 Implementierung

## Übersicht

Dieses Dokument beschreibt die Implementierung der Phasen 2-4 des Multiplayer-Projekts.

---

## Phase 2: Spieler verbinden/trennen

### Client-Seite (NetworkClient.cs)

**Status:** ✅ Implementiert in `/workspace/SOD-Multiplayer/Client/Source/Network/NetworkClient.cs`

**Funktionen:**
- `Connect(string ip, int port)` - Stellt TCP-Verbindung zum Dedicated Server her
- `Disconnect()` - Trennt Verbindung ordnungsgemäß
- `SendPacket(NetworkPacket packet)` - Sendet JSON-pakete mit Längen-Prefix
- `ProcessIncomingPackets()` - Verarbeitet eingehende Pakete im Main-Thread

**Paket-Typen:**
```csharp
ConnectRequestPacket    // Client → Server: Join-Anfrage
ConnectResponsePacket   // Server → Client: Antwort (Erfolg/Misserfolg)
DisconnectPacket        // Bidirektional: Trennungs-Nachricht
PlayerJoinPacket        // Server → Client: Neuer Spieler beigetreten
PlayerLeavePacket       // Server → Client: Spieler verlassen
```

### Server-Seite (PlayerManager.cs)

**Status:** ✅ Implementiert in `/workspace/SOD-Multiplayer/DedicatedServer/Source/Server/PlayerManager.cs`

**Funktionen:**
- `HandleConnectRequest()` - Verarbeitet Join-Anfragen
- `HandleDisconnect()` - Verarbeitet Trennungen
- `AcceptPlayer()` - Nimmt Spieler in Session auf
- `RemovePlayer()` - Entfernt Spieler aus Session

**Ablauf:**
1. Client sendet `ConnectRequestPacket` mit Spielername
2. Server prüft Passwort (falls erforderlich) → Phase 5
3. Server prüft Max Players → Phase 3
4. Bei Erfolg: Player-ID zuweisen, `ConnectResponsePacket` senden
5. `PlayerJoinPacket` an alle Clients broadcasten

---

## Phase 3: 4-Spieler-Limit

### Server-Seite (GameServer.cs & PlayerManager.cs)

**Status:** ✅ Implementiert

**Konfiguration:**
```csharp
public class ServerConfig
{
    public int MaxPlayers { get; set; } = 4;  // Standard: 4 Spieler
}
```

**Durchsetzung:**
```csharp
// In PlayerManager.AcceptPlayer()
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
```

**NetworkServer.cs:**
- `MaxPlayers` Property wird von GameServer gesetzt
- `PlayerCount` Property gibt aktuelle Spielerzahl zurück
- AcceptLoop prüft Limit bevor Client angenommen wird

---

## Phase 4: Serverinformationen und Serverliste

### Master Server API (RestAPI.cs)

**Status:** ✅ Implementiert in `/workspace/SOD-Multiplayer/MasterServer/Source/API/RestAPI.cs`

**Endpoints:**

| Method | Endpoint | Beschreibung |
|--------|----------|--------------|
| GET | `/api/servers` | Liste aller Server |
| POST | `/api/servers/register` | Server registrieren |
| DELETE | `/api/servers/{id}` | Server deregistrieren |
| PUT | `/api/servers/{id}/heartbeat` | Heartbeat senden |
| GET | `/api/servers/{id}` | Einzelner Server |
| GET | `/api/health` | Health Check |

**ServerInfo Datenstruktur:**
```json
{
  "id": "server-uuid",
  "name": "SOD Multiplayer #1",
  "ip": "192.168.1.100",
  "port": 27015,
  "players": 2,
  "maxPlayers": 4,
  "passwordProtected": true,
  "map": "Procedural City",
  "lastSeen": 1693847200
}
```

### Client UI (ServerBrowserUI.cs)

**Status:** ✅ Erweitert in Phase 4

**Features:**
- Scrollbare Server-Liste mit Unity UI
- Anzeige: Name, IP:Port, Spielerzahl, Map, Passwort-Icon
- Refresh-Button lädt Serverliste neu
- Click auf Server-Eintrag wählt Server aus
- Direct Connect Button für manuelle Eingabe
- Password Panel für geschützte Server

**Master Server Kommunikation:**
```csharp
// HTTP GET Request an Master Server
var request = UnityWebRequest.Get($"{_masterServerUrl}/api/servers");
yield return request.SendWebRequest();

// JSON parsen
var response = JsonConvert.DeserializeObject<ServerListResponse>(json);
_serverList = response.Servers.ToList();
```

**Fallback:** Wenn Master Server nicht erreichbar, werden Demo-Server angezeigt.

### Dedicated Server Registrierung (MasterClient.cs)

**Status:** ✅ Implementiert

**Ablauf:**
1. Beim Start: POST `/api/servers/register` mit Server-Infos
2. Alle 10 Sekunden: PUT `/api/servers/{id}/heartbeat` mit aktueller Spielerzahl
3. Beim Stoppen: DELETE `/api/servers/{id}`

---

## Phase 5: Passwortschutz

### Server-Seite (PlayerManager.cs)

**Status:** ✅ Implementiert

**Ablauf:**
1. Client sendet `ConnectRequestPacket`
2. Server erkennt Passwort-Konfiguration
3. Server sendet `PasswordChallengePacket` mit zufälligem Challenge-String
4. Client berechnet Hash: `SHA256(Challenge + Password)`
5. Client sendet `PasswordResponsePacket` mit Hash
6. Server vergleicht mit eigenem Hash
7. Bei Übereinstimmung: `PasswordResultPacket { success = true }`
8. Bei Fehler: `PasswordResultPacket { success = false }` + Disconnect

**Hash-Berechnung:**
```csharp
private string HashPassword(string password)
{
    using (var sha256 = SHA256.Create())
    {
        var bytes = Encoding.UTF8.GetBytes(password);
        var hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }
}
```

### Client-Seite (ServerBrowserUI.cs)

**Status:** ✅ Implementiert

**UI-Elemente:**
- Password Panel (Overlay)
- TMP_InputField (Password-Modus)
- Join/Cancel Buttons

**Logik:**
```csharp
if (_selectedServer.PasswordProtected)
{
    ShowPasswordPanel();  // Zeigt Password-Dialog
}
else
{
    JoinSelectedServer(); // Direkter Join
}
```

---

## Zusammenfassung

| Phase | Status | Client | Server | Master |
|-------|--------|--------|--------|--------|
| 1. Netzwerkverbindung | ✅ | NetworkClient.cs | NetworkServer.cs | - |
| 2. Verbinden/Trennen | ✅ | PacketHandler.cs | PlayerManager.cs | - |
| 3. 4-Spieler-Limit | ✅ | - | GameServer.cs | - |
| 4. Serverliste | ✅ | ServerBrowserUI.cs | MasterClient.cs | RestAPI.cs |
| 5. Passwortschutz | ✅ | ServerBrowserUI.cs | PlayerManager.cs | - |

## Nächste Schritte

**Phase 6:** Spielzustands-Synchronisation (Positionen, Zeit, Wetter)
**Phase 7:** Multiplayer-Gameplay (Interaktionen, Events)
**Phase 8:** Optimierung, Testing, Release

