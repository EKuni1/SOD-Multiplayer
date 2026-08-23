# Shadow of Doubt - Multiplayer Mod Projekt

## Übersicht

Dieses Projekt entwickelt eine vollständige Multiplayer-Mod für Shadow of Doubt mit drei Komponenten:

1. **Client-Mod** - BepInEx/Harmony Mod für lokale Spielinstallation
2. **Dedicated Server** - Linux-Server-Anwendung für Multiplayer-Sessions (max. 4 Spieler)
3. **Master Server** - Zentrale Serverliste für Server-Discovery

---

## Aktueller Funktionsstand

### Verfügbar

- TCP-Verbindung zwischen Client und Dedicated Server mit newline-delimited JSON
- Join/Leave, Spieler-ID, Spielernamen, Host-Erkennung und Limit von vier Spielern
- Passwortprüfung beim Beitritt
- Spielerpositionen und Rotationen als typisierte Updates
- Chat-Broadcasts
- Serverregistrierung, Serverliste und Heartbeat über den Master Server
- Versionierte Welt-Snapshots mit Server-Tick und Revision
- Autoritative Weltaktionen für Fälle, Citizens, Pinboard, Türen, Firmen/Öffnungszeiten, Aufzüge, Items und Objekte
- Weltzustand wird beim Beitritt oder auf Anfrage an Clients verteilt
- Der erste Spieler ist Snapshot-Host; nur sein vollständiger Snapshot wird als Weltzustand akzeptiert

### Noch erforderliche Unity-/Harmony-Anbindung

Die Netzwerkverteilung ist vorbereitet, aber die Spiel-Assembly muss die lokalen Änderungen noch an `WorldActionPacket` und `WorldSnapshotPacket` binden. Erst diese Hooks machen die Zustände im Spiel sichtbar:

- Fall öffnen/ändern/lösen sowie Akten- und Pinboard-Verbindungen
- Bürgerpositionen und Rotationen aus einer einzigen autoritativen Quelle
- Tür öffnen, schließen, aufsperren, eintreten und klopfen
- Firmen-Öffnungszeiten aus der synchronisierten Spielzeit
- Aufzugziel, Transitstatus und Mitfahrt aller Spieler
- Gegenstände aufnehmen, ablegen, werfen und Objektzustände
- Zeit und Wetter auf `SessionData` anwenden

Bis diese Hooks ergänzt sind, sind die Pakete und Serverzustände vorhanden, die sichtbare Änderung im Unity-Spiel jedoch noch nicht garantiert.

### Verbindliche Synchronisationsregeln

- Der Dedicated Server vergibt Revisionen und Server-Ticks; Clients verwenden keine lokale Uhr als Weltquelle.
- Weltaktionen werden mit Entitätstyp, stabiler Entitäts-ID, Aktion und Zustand übertragen.
- Für reproduzierbare Bürgerpositionen müssen alle Clients dieselbe stabile Citizen-ID verwenden.
- Snapshots werden beim Join gesendet; Aktionen werden sofort an alle Clients broadcastet.
- Ein vollständiger Snapshot darf nur vom Host veröffentlicht werden.

---

## Architektur

```
┌─────────────────────────────────────────────────────────────────┐
│                    SHADOW OF DOUBT MULTIPLAYER                  │
└─────────────────────────────────────────────────────────────────┘

┌──────────────┐         ┌──────────────────┐         ┌──────────────┐
│  Client Mod  │◄───────►│  Dedicated Server │◄───────►│ Master Server│
│  (BepInEx)   │  UDP    │  (Linux, Headless)│  HTTP   │  (Registry)  │
│              │  TCP    │                  │  REST   │              │
└──────────────┘         └──────────────────┘         └──────────────┘
     │                          │                          │
     │ - Server Browser         │ - Lobby Management       │ - Server List
     │ - Player Sync            │ - Player Management      │ - Discovery API
     │ - Game State Sync        │ - Max 4 Players          │ - Heartbeats
     │ - Harmony Patches        │ - Password Protection    │
     │                          │ - Game Session Logic     │
```

---

## Entwicklungsphasen

### Phase 1: Grundlegende Netzwerkverbindung ✅
- Client ↔ Dedicated Server Kommunikation
- Basis-Netzwerkprotokoll (UDP/TCP)
- Verbindungsaufbau und -abbau

### Phase 2: Spieler verbinden/trennen ✅
- Join/Leave-System
- Spieler-Identifikation
- Connection-Handshake

### Phase 3: 4-Spieler-Limit ⏳
- Spielerzähler im Dedicated Server
- Ablehnung bei vollem Server
- UI-Anzeige der Spielerzahl

### Phase 4: Serverinformationen und Serverliste ⏳
- Master Server Registry
- Server-Browser UI
- Heartbeat-System

### Phase 5: Passwortschutz ⏳
- Passwort-Hashing (SHA-256)
- Passwort-Abfrage im Client
- Zugriffskontrolle

### Phase 6: Master-Server Integration ⏳
- Server-Registrierung
- Server-Discovery API
- Status-Updates

### Phase 7: Spielzustands-Synchronisierung 🔄
- Player-Positionen und Rotationen: Protokoll und Relay vorhanden
- Welt-Snapshot, Revisionen und Aktionen: vorhanden
- Zeit/Wetter: Pakettransport vorhanden, Unity-Anwendung benötigt Hook

### Phase 8: Multiplayer-Gameplay 🔄
- Fall-, Pinboard-, Tür-, Öffnungszeiten-, Aufzug-, Item- und Objekt-Pakete: vorhanden
- Sichtbare Anwendung in der Spiel-Assembly: noch offen
- Voice Chat (optional): offen

---

## Verzeichnisstruktur

```
SOD-Multiplayer/
├── Client/
│   ├── Source/
│   │   ├── MultiplayerMod.cs          # Hauptmod-Klasse (BepInEx)
│   │   ├── Network/
│   │   │   ├── NetworkClient.cs       # Netzwerk-Client
│   │   │   ├── PacketHandler.cs       # Paketverarbeitung
│   │   │   └── Protocol.cs            # Protokoll-Definitionen
│   │   ├── UI/
│   │   │   ├── ServerBrowserUI.cs     # Server-Browser Oberfläche
│   │   │   ├── ServerEntryUI.cs       # Server-Eintrag UI
│   │   │   └── PasswordDialog.cs      # Passwort-Dialog
│   │   ├── Harmony/
│   │   │   ├── MainMenuPatches.cs     # Hauptmenü-Patches
│   │   │   ├── SessionPatches.cs      # Session-Patches
│   │   │   └── PlayerPatches.cs       # Player-Patches
│   │   └── Sync/
│   │       ├── PlayerSync.cs          # Spieler-Synchronisation
│   │       └── GameStateSync.cs       # Spielzustand-Sync
│   └── Plugins/
│       └── (BepInEx Dependencies)
│
├── DedicatedServer/
│   ├── Source/
│   │   ├── Program.cs                 # Entry Point
│   │   ├── Server/
│   │   │   ├── GameServer.cs          # Hauptserver-Klasse
│   │   │   ├── LobbyManager.cs        # Lobby-Verwaltung
│   │   │   ├── PlayerManager.cs       # Spieler-Verwaltung (max 4)
│   │   │   └── SessionManager.cs      # Session-Logik
│   │   ├── Network/
│   │   │   ├── NetworkServer.cs       # Netzwerk-Server
│   │   │   ├── PacketHandler.cs       # Paketverarbeitung
│   │   │   └── Protocol.cs            # Protokoll-Definitionen
│   │   └── Master/
│   │       └── MasterClient.cs        # Master-Server Client
│   ├── Bin/
│   │   └── (Kompilierte Binaries)
│   └── Config/
│       └── server.cfg                 # Server-Konfiguration
│
├── MasterServer/
│   ├── Source/
│   │   ├── Program.cs                 # Entry Point
│   │   ├── ServerListManager.cs       # Serverlisten-Manager
│   │   ├── API/
│   │   │   └── RestAPI.cs             # REST API Endpoints
│   │   └── Models/
│   │       └── ServerInfo.cs          # Server-Info Modell
│   ├── Bin/
│   │   └── (Kompilierte Binaries)
│   └── Config/
│       └── master.cfg                 # Master-Server Konfiguration
│
├── Docs/
│   ├── PROTOCOL.md                    # Netzwerkprotokoll-Doku
│   ├── API.md                         # Master-Server API
│   └── INSTALLATION.md                # Installationsanleitung
│
└── Config/
    ├── sod-dedicated.service          # systemd Service (Dedicated)
    ├── sod-master.service             # systemd Service (Master)
    └── build.sh                       # Build-Skript
```

---

## Abhängigkeiten

### Client-Mod
- **BepInEx** (Unity Modding Framework)
- **HarmonyX** (Method-Hooking)
- **Il2CppInterop** (IL2CPP Unterstützung)
- **Newtonsoft.Json** (JSON Serialisierung)

### Dedicated Server
- **.NET 8.0 Runtime**
- **Newtonsoft.Json** (JSON Serialisierung)

### Master Server
- **.NET 8.0 Runtime**
- **Microsoft.AspNetCore** (REST API)
- **Newtonsoft.Json** (JSON Serialisierung)

---

## Netzwerkprotokoll

### Client ↔ Dedicated Server (UDP/TCP)
```
Port: 27015 (Standard)
Protokoll: UDP für Game-Daten, TCP für zuverlässige Daten

Paket-Typen:
- CONNECT_REQUEST / CONNECT_RESPONSE
- DISCONNECT
- PLAYER_JOIN / PLAYER_LEAVE
- PLAYER_POSITION
- PLAYER_ACTION
- GAME_STATE_UPDATE
- WORLD_ACTION / WORLD_ACTION_BROADCAST
- WORLD_SNAPSHOT_REQUEST / WORLD_SNAPSHOT
- PASSWORD_CHALLENGE / PASSWORD_RESPONSE
```

### Dedicated Server ↔ Master Server (HTTP REST)
```
Port: 27016 (Standard)

Endpoints:
POST   /api/servers/register     - Server registrieren
DELETE /api/servers/{id}         - Server deregistrieren
PUT    /api/servers/{id}/heartbeat - Heartbeat senden
GET    /api/servers              - Serverliste abrufen
```

---

## Kompilierung

### Client-Mod
```bash
cd Client/Source
dotnet build -c Release
# Output: Client/Bin/MultiplayerMod.dll
# Installieren nach: <SOD-Install>/BepInEx/plugins/
```

### Dedicated Server
```bash
cd DedicatedServer/Source
dotnet publish -c Release -r linux-x64 --self-contained
# Output: DedicatedServer/Bin/
```

### Master Server
```bash
cd MasterServer/Source
dotnet publish -c Release -r linux-x64 --self-contained
# Output: MasterServer/Bin/
```

---

## Installation

### Client-Mod
1. BepInEx für Shadow of Doubt installieren
2. `MultiplayerMod.dll` nach `<SOD>/BepInEx/plugins/` kopieren
3. Spiel starten, neuer "MULTIPLAYER" Button im Hauptmenü

### Dedicated Server (Linux)
```bash
# Systemd Service installieren
sudo cp Config/sod-dedicated.service /etc/systemd/system/
sudo systemctl daemon-reload
sudo systemctl enable sod-dedicated
sudo systemctl start sod-dedicated
```

### Master Server (Linux)
```bash
# Systemd Service installieren
sudo cp Config/sod-master.service /etc/systemd/system/
sudo systemctl daemon-reload
sudo systemctl enable sod-master
sudo systemctl start sod-master
```

---

## Konfiguration

### Dedicated Server (server.cfg)
```json
{
  "serverName": "My SOD Server",
  "maxPlayers": 4,
  "port": 27015,
  "password": "", // Leer = kein Passwort
  "masterServerUrl": "http://localhost:27016",
  "region": "EU"
}
```

### Master Server (master.cfg)
```json
{
  "bindAddress": "192.168.178.76",
  "port": 5000,
  "heartbeatTimeout": 30,
  "region": "EU",
  "authToken": "change-this-token"
}
```

---

## Testing

### Unit Tests
```bash
cd DedicatedServer/Source
dotnet test

cd MasterServer/Source
dotnet test
```

### Integration Tests
1. Master Server starten
2. Dedicated Server starten (registriert sich automatisch)
3. Client mit Mod starten
4. Server-Browser öffnen, Server sollte sichtbar sein
5. Verbindung testen (mit/ohne Passwort)

---

## Wichtige Klassen aus SOD-Assembly

Basierend auf der Analyse der bereitgestellten Assembly:

### SessionData.cs
- `SessionData.Instance` - Singleton Zugriff
- `SetEnablePause(bool)` - Pause-Steuerung
- `SetGameTime(...)` - Zeit-Synchronisation
- `SetWeather(...)` - Wetter-Synchronisation
- Events: `OnPauseChange`, `OnWeatherChange`, `OnHourChange`

### Weitere relevante Klassen (zu analysieren)
- `Actor.cs` - Spieler/NPC Darstellung
- `ActionController.cs` - Aktionen/Interaktionen
- `Interactable.cs` - Interaktive Objekte
- `CitySaveData.cs` - Spielwelt-Daten

---

## Hinweise zur Entwicklung

1. **Kein Zugriff auf das Spiel**: Die AI kann die Assembly nur analysieren, nicht ausführen
2. **Harmony-Patches**: Müssen sorgfältig getestet werden im echten Spiel
3. **IL2CPP**: Shadow of Doubt verwendet IL2CPP, Il2CppInterop erforderlich
4. **Netzwerk**: UDP für Echtzeit-Daten, TCP für zuverlässige Übertragung
5. **Sicherheit**: Passwörter immer gehasht übertragen (SHA-256)

---

## Nächste Schritte

Beginnend mit **Phase 1**: Grundlegende Netzwerkverbindung zwischen Client und Dedicated Server.

Jede Phase wird separat implementiert, dokumentiert und getestet bevor mit der nächsten fortgefahren wird.
