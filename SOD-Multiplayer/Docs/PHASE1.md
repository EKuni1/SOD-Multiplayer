# Shadow of Doubt - Multiplayer Mod

## Projekt-Struktur

```
SOD-Multiplayer/
├── Client/                    # BepInEx Mod für Spieler
│   └── Source/
│       ├── MultiplayerMod.cs          # Hauptmod-Klasse
│       ├── Network/
│       │   ├── NetworkClient.cs       # TCP Client
│       │   └── PacketHandler.cs       # Paket-Verarbeitung
│       ├── UI/
│       │   └── ServerBrowserUI.cs     # Server-Browser Interface
│       └── Harmony/
│           └── MainMenuPatches.cs     # Spiel-Patches
│
├── DedicatedServer/           # Linux Server-Anwendung
│   └── Source/
│       ├── Program.cs                 # Entry Point
│       ├── Server/
│       │   ├── GameServer.cs          # Hauptserver
│       │   ├── PlayerManager.cs       # Spieler-Verwaltung
│       │   └── SessionManager.cs      # Session-Logik
│       ├── Network/
│       │   ├── NetworkServer.cs       # TCP Server
│       │   └── Packets.cs             # Paket-Definitionen
│       └── Master/
│           └── MasterClient.cs        # Master-Server Client
│
└── MasterServer/            # Zentrale Serverliste
    └── Source/
        ├── Program.cs                 # Entry Point
        ├── ServerListManager.cs       # Server-Verwaltung
        ├── API/
        │   └── RestAPI.cs             # REST Endpoints
        └── Models/
            └── ServerInfo.cs          # Datenmodelle
```

---

## Phase 1: Grundlegende Netzwerkverbindung (AKTUELL)

### Status: ✅ Abgeschlossen

**Implementierte Komponenten:**

#### Client-Mod
- `MultiplayerMod.cs` - BepInEx Plugin Initialisierung
- `NetworkClient.cs` - TCP Verbindung zum Dedicated Server
- `PacketHandler.cs` - JSON-basierte Paketverarbeitung
- `ServerBrowserUI.cs` - UI Placeholder (wird in Phase 4 erweitert)

#### Dedicated Server
- `GameServer.cs` - Hauptserver mit Konfiguration
- `NetworkServer.cs` - TCP Server für Client-Verbindungen
- `PlayerManager.cs` - Spieler-Join mit Passwort-Support
- `SessionManager.cs` - Session-Grundgerüst
- `MasterClient.cs` - Kommunikation mit Master-Server
- `Program.cs` - Entry Point mit Command-Line Args

#### Master Server
- `ServerListManager.cs` - Verwaltung registrierter Server
- `RestAPI.cs` - ASP.NET Core REST Endpoints
- `ServerInfo.cs` - Datenmodelle
- `Program.cs` - Entry Point

### Netzwerkprotokoll (Phase 1)

**Client ↔ Dedicated Server (TCP Port 27015):**
```json
// CONNECT_REQUEST (Client → Server)
{
  "packetType": "ConnectRequestPacket",
  "playerName": "Player1",
  "clientVersion": "0.1.0"
}

// CONNECT_RESPONSE (Server → Client)
{
  "packetType": "ConnectResponsePacket",
  "success": true,
  "serverName": "My SOD Server",
  "currentPlayers": 1,
  "maxPlayers": 4
}
```

**Dedicated Server ↔ Master Server (HTTP Port 27016):**
```bash
POST /api/servers/register
{
  "serverName": "My SOD Server",
  "port": 27015,
  "maxPlayers": 4,
  "hasPassword": false,
  "region": "EU"
}

Response: { "serverId": "abc123", "success": true }

GET /api/servers
Response: { "servers": [...], "totalCount": 1 }
```

---

## Nächste Phasen

### Phase 2: Spieler verbinden/trennen
- Vollständige Join/Leave-Logik
- Player-ID Zuweisung
- Broadcast an alle Clients

### Phase 3: 4-Spieler-Limit
- Server-seitige Prüfung
- Ablehnung bei vollem Server

### Phase 4: Serverinformationen und Serverliste
- Master-Server Integration im Client
- Server-Browser UI vervollständigen
- Heartbeat-System

### Phase 5: Passwortschutz
- SHA-256 Hashing
- Challenge-Response Authentifizierung

### Phase 6: Master-Server Integration
- Automatische Registrierung
- Heartbeat-Loop

### Phase 7: Spielzustands-Synchronisierung
- SessionData Patches
- Zeit/Wetter Sync

### Phase 8: Multiplayer-Gameplay
- Vollständige Synchronisation

---

## Kompilierung

### Voraussetzungen
- .NET 8.0 SDK
- Für Client: BepInEx IL2CPP, HarmonyX, Il2CppInterop

### Dedicated Server
```bash
cd SOD-Multiplayer/DedicatedServer/Source
dotnet new console --force
dotnet add package Newtonsoft.Json
dotnet publish -c Release -r linux-x64 --self-contained
```

### Master Server
```bash
cd SOD-Multiplayer/MasterServer/Source
dotnet new web --force
dotnet add package Newtonsoft.Json
dotnet publish -c Release -r linux-x64 --self-contained
```

### Client-Mod
```bash
# Benötigt BepInEx IL2CPP Vorlage
cd SOD-Multiplayer/Client/Source
# Kompilierung hängt von der Spiel-Installation ab
```

---

## Installation & Betrieb

### Master Server starten
```bash
./SODMasterServer --port 27016
```

### Dedicated Server starten
```bash
./SODMultiplayerServer \
  --name "Mein SOD Server" \
  --port 27015 \
  --maxplayers 4 \
  --master "http://localhost:27016" \
  --password "geheim"
```

### Client-Mod installieren
1. BepInEx IL2CPP für Shadow of Doubt installieren
2. `MultiplayerMod.dll` nach `<SOD>/BepInEx/plugins/` kopieren
3. Spiel starten
4. "MULTIPLAYER" Button im Hauptmenü klicken

---

## API Dokumentation

### Master Server REST API

#### GET /api/health
Health Check des Master Servers.

**Response:**
```json
{ "status": "ok", "servers": 3 }
```

#### POST /api/servers/register
Registriert einen Dedicated Server.

**Request:**
```json
{
  "serverName": "My Server",
  "port": 27015,
  "maxPlayers": 4,
  "hasPassword": false,
  "region": "EU",
  "version": "0.1.0"
}
```

**Response:**
```json
{ "success": true, "serverId": "abc123def" }
```

#### DELETE /api/servers/{id}
Entfernt einen Server aus der Liste.

#### PUT /api/servers/{id}/heartbeat
Sendet einen Heartbeat.

**Request:**
```json
{ "currentPlayers": 2, "timestamp": 1234567890 }
```

#### GET /api/servers
Ruft alle Online-Server ab.

**Response:**
```json
{
  "servers": [
    {
      "id": "abc123",
      "name": "My Server",
      "ipAddress": "192.168.1.100",
      "port": 27015,
      "maxPlayers": 4,
      "currentPlayers": 2,
      "hasPassword": false,
      "region": "EU",
      "status": "online"
    }
  ],
  "totalCount": 1
}
```

---

## Wichtige Hinweise

1. **Maximale Spielerzahl**: Jeder Server unterstützt maximal 4 Spieler
2. **Passwort-Sicherheit**: Passwörter werden als SHA-256 Hash übertragen
3. **Heartbeat Timeout**: Server ohne Heartbeat für 30s werden entfernt
4. **SOD-Assembly**: Die bereitgestellte Assembly dient nur zur Analyse - keine Klassen erfinden!

---

## Entwicklungshinweise

### SessionData.cs (aus SOD-Assembly analysiert)
Wichtige Methoden für spätere Phasen:
- `SessionData.Instance` - Singleton Zugriff
- `SetEnablePause(bool)` - Pause Steuerung
- `SetGameTime(...)` - Zeit Synchronisation
- `SetWeather(...)` - Wetter Synchronisation
- Events: `OnPauseChange`, `OnWeatherChange`, `OnHourChange`

### Zu implementierende Harmony-Patches
- MainMenu: "MULTIPLAYER" Button hinzufügen
- SessionData: Zeit/Wetter vom Server synchronisieren
- Actor/Player: Positionen senden/empfangen

---

## Lizenz

Dieses Projekt ist eine Community-Mod für Shadow of Doubt.
