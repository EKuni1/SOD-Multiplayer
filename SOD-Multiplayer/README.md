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

---

## Aktueller Stand fuer weitere Entwicklung

Dieser Abschnitt beschreibt den Code, der aktuell unter `src/` gebaut wird. Die Verzeichnisse
`Client/Source`, `DedicatedServer/Source` und `MasterServer/Source` enthalten einen aelteren
Entwurf und duerfen fuer neue Aenderungen nicht als Referenz verwendet werden.

### Lokale Spielinstallation

Die Referenzen des Client-Projekts zeigen auf:

```text
E:\Games\Shadows of Doubt
```

Der Pfad wird in `src/Directory.Build.props` als `SODGamePath` gesetzt. Die relevanten Dateien
kommen aus `BepInEx/core` und `BepInEx/interop`:

- `BepInEx.Unity.IL2CPP.dll`
- `Il2CppInterop.Runtime.dll`
- `UnityEngine.CoreModule.dll`
- `UnityEngine.UIModule.dll`
- `UnityEngine.UI.dll`
- `UnityEngine.UnityWebRequestModule.dll`
- `Unity.TextMeshPro.dll`
- `Assembly-CSharp.dll`
- `Il2Cppmscorlib.dll`
- `Il2CppSystem.dll`

### Build-Befehle

Aus dem Repository-Hauptverzeichnis:

```powershell
dotnet build .\SOD-Multiplayer\src\Client\MultiplayerMod.csproj -c Release
dotnet build .\SOD-Multiplayer\src\DedicatedServer\SOD.Multiplayer.Dedicated.csproj -c Release
dotnet build .\SOD-Multiplayer\src\MasterServer\SOD.Multiplayer.Master.csproj -c Release
```

Die Client-DLL liegt danach unter:

```text
SOD-Multiplayer\src\Client\bin\Release\MultiplayerMod.dll
```

Sie wird nach `E:\Games\Shadows of Doubt\BepInEx\plugins\` kopiert.

### Config-Dateien

Der Master Server liest `master.cfg` neben seiner Anwendung. Beim normalen Build wird die Datei
nach `src/MasterServer/bin/Release/net6.0/master.cfg` kopiert:

```json
{
  "bindAddress": "192.168.178.76",
  "port": 5000,
  "heartbeatTimeout": 30,
  "region": "EU",
  "authToken": "change-this-token"
}
```

Der Pfad kann mit `SOD_MASTER_CONFIG` ueberschrieben werden. Der Dedicated Server verwendet:

- `SOD_MASTER_URL`, Standard `http://192.168.178.76:5000`
- `SOD_MASTER_AUTH_TOKEN`, Standard `change-this-token`
- `SOD_SERVER_NAME`
- `SOD_SERVER_PORT`
- `SOD_SERVER_PASSWORD`

Der Client erzeugt seine BepInEx-Konfiguration unter:

```text
E:\Games\Shadows of Doubt\BepInEx\config\com.sod.multiplayer.cfg
```

Die Eintraege heissen `Url` und `AuthToken` in der Sektion `Master Server`.

### Netzwerkablauf

1. Der Master Server startet zuerst und bindet an `BindAddress:Port`.
2. Der Dedicated Server startet seinen TCP-Listener und sendet alle zehn Sekunden einen
   Registrierungs-Heartbeat per HTTP.
3. Der Client laedt die Master-URL aus der BepInEx-Config und fordert `/api/servers` an.
4. Der Client verbindet sich per TCP mit dem ausgewaehlten Dedicated Server.
5. Der erste erfolgreiche Join wird serverseitig als Host markiert.
6. Weltaktionen werden vom Dedicated Server mit Revision und Serverzeit verteilt.

Master-HTTP-Endpunkte:

- `GET /api/health` ist ungeschuetzt.
- `GET /api/servers` benoetigt `X-Auth-Token`.
- `POST /api/servers/register` benoetigt `X-Auth-Token`.
- `DELETE /api/servers/{id}` benoetigt `X-Auth-Token`.

Der Client sendet das Token mit `X-Auth-Token`. Der Dedicated Server verwendet denselben Header
bei Registrierung und Heartbeat. Das Token darf nicht im oeffentlichen Repository verbleiben.

### Aktuell implementierte Client-Funktionen

- BepInEx-Plugin-Laden unter IL2CPP
- Registrierung von `ServerBrowserUI`, `ServerSelectData` und `RuntimeDiagnostics`
- dynamischer Patch von `MainMenuController.Awake`
- Multiplayer-Button und Serverbrowser
- Serverauswahl und Passwortfeld
- TCP-Join/Leave und Host-Erkennung
- Host-Savegame-Auswahl ueber `SessionSelectedPacket`
- Spielzeit und Wetter als Session-Weltzustand
- Tuerstatus ueber `DoorMovementController.SetOpen`
- Firmenstatus ueber `Company.SetOpen`
- Nebenjobstatus ueber `SideJob.SetJobState`
- Case-Status ueber `Case.SetStatus`
- Pointboard-Pinpositionen ueber `CaseElement.caseID`, `CaseElement.id` und `pinnedRect`
- Buerger-Tod ueber `CitizenAnimationController.SetDead`
- Spielerpositionen im Serverzustand
- interpolierte Remote-Spieler-Marker
- eingehende Chatnachrichten im UI
- persistenter Welt-Snapshot in `world-state.json`

### WorldSync-Regeln

`src/Client/Harmony/WorldSync.cs` ist die zentrale Bruecke zwischen Harmony und Netzwerk.

- Jeder ausgehende Hook prueft `NetworkClient.Active`, Verbindung und Hoststatus.
- Eingehende Events werden mit `_applyingRemoteState` markiert.
- Diese Markierung verhindert, dass das Anwenden eines Remote-Events erneut ein Sende-Event ausloest.
- IDs muessen stabil sein. GameObject-Namen sind nur ein Fallback und nicht fuer globale Eindeutigkeit
  geeignet.
- Unity-Objekte duerfen nur auf dem Unity-Hauptthread veraendert werden.

### Laufzeitdiagnose

`RuntimeDiagnostics` schreibt waehrend des Spiels regelmaessige NDJSON-Aufzeichnungen. Gespeichert
werden Spiel- und Unity-Version, erkannte Spielmethoden, Szene, SessionData, Cases, Pins, Firmen,
Jobs, Tueren, Buerger, Netzwerkstatus sowie eingehende und ausgehende Pakete.

Der Zielordner ist:

```text
<Application.persistentDataPath>\SOD-Multiplayer\diagnostics\
```

Die Dateien heissen `session-YYYYMMDD-HHMMSS.ndjson`. Beim Testen sollten folgende Aktionen
ausgefuehrt werden, damit die naechste Implementierungsrunde belastbare Daten erhaelt:

1. Master Server starten und Serverliste laden.
2. Zwei Clients verbinden.
3. Eine Tuer oeffnen und schliessen.
4. Zeit und Wetter veraendern.
5. Einen Case oeffnen, einen Pin verschieben und eine Verbindung erstellen/loesen.
6. Einen Nebenjob und eine Firma veraendern.
7. Einen Buerger beschaedigen oder toeten.
8. Einen Aufzug rufen und ein Item aufnehmen/ablegen.
9. Chatnachrichten senden und einen Client trennen.

### Noch zu implementieren

Die folgenden Funktionen sind im Protokoll beziehungsweise in Teilen der Snapshot-Struktur
vorbereitet, aber noch nicht vollstaendig in der Spielassembly angewendet:

- Pointboard-Verbindungen zwischen zwei Pins: `StringConnection`-Create/Delete
- vollstaendige Case-Elemente und Evidence-Zustaende
- Aufzugziel, Aufzugbewegung und Mitfahrer
- Item-ID, Besitzer, Weltposition und Inventar-Slots
- Buergerposition, Rotation, Schaden und stabile Citizen-ID
- echte Remote-Spielerobjekte statt Test-Wuerfel-Marker
- Remote-Spieler-Entfernung nach `PlayerLeft`
- Chat-Eingabefeld und Senden per UI
- atomisches Schreiben und Laden von `world-state.json`

### Vorgehen fuer neue Spielpatches

1. Die echte Signatur in `SOD-Assembly` oder der installierten `Assembly-CSharp.dll` pruefen.
2. Einen neuen `WorldEntityType` oder eine eindeutige Aktion festlegen.
3. ID und serialisierbaren Zustand in `WorldActionPacket` aufnehmen.
4. Im Host-Postfix nur senden, niemals lokale Objekte im Netzwerkthread veraendern.
5. In `WorldSync.Apply` anhand der ID suchen und unter Remote-State-Schutz anwenden.
6. Einen Diagnose-Snapshot und einen Zwei-Client-Test ausfuehren.
7. Alle drei Projekte bauen, bevor die DLL ins Spiel kopiert wird.

### Bekannte technische Risiken

- Die Spielassembly ist IL2CPP-generiert; Unity-Listen sind haeufig `Il2CppSystem`-Listen und
  nicht direkt mit .NET-LINQ kompatibel.
- `Harmony.PatchAll()` darf keine Patchklasse mit unbestimmtem Ziel enthalten. Dynamische Ziele
  muessen vor `Patch` mit `AccessTools.Method` geprueft werden.
- `MonoBehaviour`-Klassen benoetigen IL2CPP-Konstruktoren mit `IntPtr` sowie Registrierung durch
  `ClassInjector.RegisterTypeInIl2Cpp<T>()`.
- Die aktuelle Kommunikation verwendet TCP und Klartext-Passwoerter. Fuer oeffentliche Server
  sind TLS oder Challenge-Response und ein sicher verwaltetes Token erforderlich.
- .NET 6 ist im verwendeten SDK als veraltet markiert. Ein Upgrade muss gegen die BepInEx-/Unity-
  Abhaengigkeiten getestet werden.
