# SOD Multiplayer Mod

Eine Multiplayer-Mod für Shadow of Doubt die es bis zu 4 Spielern ermöglicht, gemeinsam zu spielen.

## Features

- **Server Browser**: Zeigt alle verfügbaren Multiplayer-Server an
- **Master Server**: Zentraler Linux-Server verbindet alle Spieler
- **Passwortschutz**: Server können mit einem Passwort gesichert werden
- **Bis zu 4 Spieler**: Unterstützt bis zu 4 gleichzeitige Spieler pro Server
- **Steam Integration**: Nutzt Steam Networking für stabile Verbindungen

## Installation

1. Kopieren Sie alle `.cs` Dateien aus diesem Ordner in Ihr SOD-Assembly Verzeichnis
2. Stellen Sie sicher, dass Harmony und Steamworks Referenzen vorhanden sind
3. Kompilieren Sie das Projekt neu

## Verwendung

### Im Spiel

1. Starten Sie Shadow of Doubt mit der Mod
2. Klicken Sie im Hauptmenü auf den neuen "MULTIPLAYER" Button
3. Der Server Browser zeigt alle verfügbaren Server an
4. Wählen Sie einen Server und klicken Sie auf "JOIN"
5. Geben Sie bei passwortgeschützten Servern das Passwort ein

### Eigener Server

```csharp
// Server erstellen
MultiplayerManager.Instance.CreateServer(
    serverName: "Mein SOD Server",
    mapName: "Random City",
    password: "geheim123", // Optional
    maxPlayers: 4
);
```

## Dateistruktur

```
SOD-Multiplayer-Mod/
├── ServerBrowserUI.cs          # UI für die Serverliste
├── ServerInfo.cs               # Datenstruktur für Serverinformationen
├── MultiplayerManager.cs       # Haupt-Manager für Multiplayer
├── ServerEntryController.cs    # UI Controller für Server-Einträge
├── MultiplayerPatches.cs       # Harmony Patches
└── README.md                   # Diese Datei
```

## Technische Details

### Server Browser UI
- `ServerBrowserUI`: Haupt-UI Komponente
- `ServerEntryController`: Individual Server Eintrag
- `ServerInfo`: Datenstruktur mit Server-Informationen

### Multiplayer Manager
- `MultiplayerManager`: Singleton Manager für alle Multiplayer-Funktionen
- Verwendet Steam Matchmaking für Lobby-Management
- Unterstützt passwortgeschützte Lobbys
- Maximal 4 Spieler pro Lobby

### Harmony Patches
- `MainMenuController.Start`: Fügt Multiplayer-Button hinzu
- `Game.Awake`: Initialisiert Multiplayer Manager
- `SessionData.Awake`: Synchronisiert Session-Daten

## Master Server Konfiguration (Linux)

Der Master Server läuft auf einem Linux-Server und koordiniert die Serverliste:

```bash
# Beispielhafter Start des Master Servers
./sod-master-server --port 27015 --max-servers 100
```

### Master Server API

- **Adresse**: `master.shadowofdoubt.multiplayer`
- **Port**: `27015`
- **Protokoll**: UDP/TCP

## Anforderungen

- Shadow of Doubt (Steam Version)
- BepInEx oder ähnliches Mod-Loader Framework
- HarmonyX für Runtime-Patching
- Steamworks.NET für Steam Integration

## Bekannte Einschränkungen

- Nur bis zu 4 Spieler gleichzeitig
- Alle Spieler müssen dieselbe Mod-Version haben
- Host muss das Spiel laufen lassen

## Fehlerbehebung

### Server werden nicht angezeigt
- Überprüfen Sie Ihre Internetverbindung
- Stellen Sie sicher, dass Steam läuft
- Überprüfen Sie die Firewall-Einstellungen

### Verbindung fehlgeschlagen
- Überprüfen Sie das Passwort
- Stellen Sie sicher, dass der Server noch freie Slots hat
- Restarten Sie das Spiel

## Entwicklung

### Build

```bash
dotnet build Assembly-CSharp.csproj
```

### Debugging

Debug-Logs erscheinen in der BepInEx Konsole mit dem Prefix `[SOD Multiplayer]`

## Lizenz

Diese Mod wurde für Bildungs- und Gemeinschaftszwecke erstellt.

## Support

Bei Fragen oder Problemen wenden Sie sich an die Community oder öffnen Sie ein Issue.

---

**Hinweis**: Diese Mod ist ein inoffizielles Projekt und steht in keiner Verbindung zu den Entwicklern von Shadow of Doubt.
