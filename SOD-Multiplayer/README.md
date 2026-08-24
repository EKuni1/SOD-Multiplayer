# Shadows of Doubt Multiplayer Mod

A complete multiplayer modification for Shadows of Doubt enabling up to 4 players to play together.

## Project Structure

```
SOD-Multiplayer/
├── src/
│   ├── Client/           # BepInEx mod for game clients
│   ├── DedicatedServer/  # Linux game server
│   ├── MasterServer/     # Server list/master server
│   └── Shared/           # Shared packet definitions
└── README.md
```

## Components

### 1. Client Mod
- BepInEx plugin installed in your Shadows of Doubt game folder
- Adds multiplayer UI (Server Browser)
- Handles network communication with dedicated servers
- **Controls: Press CTRL+M to open/close the Server Browser**

### 2. Dedicated Server
- Standalone Linux application
- Runs the game simulation
- Supports up to 4 players per server
- Can be password protected

### 3. Master Server
- Central server list service
- Game servers register here
- Clients fetch server lists from here
- REST API on port 5000

## Prerequisites

### For Building Client Mod:
1. **.NET 6.0 SDK** or higher
2. **Shadows of Doubt** installed (Steam version)
3. **BepInEx IL2CPP** installed in your game folder
4. Path to game: `E:\Games\Shadows of Doubt` (or update Directory.Build.props)

### For Running Servers:
1. **.NET 6.0 Runtime** (Linux x64)
2. Linux server with open ports (7777 for game, 5000 for master)

## Building

### Step 1: Configure Game Path

Edit `src/Directory.Build.props` with your actual game path:

```xml
<Project>
  <PropertyGroup>
    <SODGamePath>E:\Games\Shadows of Doubt</SODGamePath>
  </PropertyGroup>
</Project>
```

**Important:** The following files must exist in your game folder:
- `BepInEx/core/BepInEx.Core.dll`
- `BepInEx/core/0Harmony.dll`
- `MelonLoader/Managed/UnityEngine.CoreModule.dll`
- `MelonLoader/Managed/UnityEngine.UI.dll`
- `MelonLoader/Managed/Unity.TextMeshPro.dll`
- `MelonLoader/Managed/Assembly-CSharp.dll`

### Step 2: Build Client Mod

```bash
cd SOD-Multiplayer/src

# Build Shared library first
dotnet build Shared/SOD.Multiplayer.Shared.csproj -c Release

# Build Client Mod
dotnet build Client/MultiplayerMod.csproj -c Release
```

### Step 3: Install Client Mod

Copy the built DLL to your BepInEx plugins folder:

```bash
# Windows example
copy "Client\bin\Release\net6.0\SOD.Multiplayer.Client.dll" "E:\Games\Shadows of Doubt\BepInEx\plugins\"
```

### Step 4: Build Servers (Linux)

```bash
cd SOD-Multiplayer/src

# Build Dedicated Server
dotnet publish DedicatedServer/SOD.Multiplayer.Dedicated.csproj \
  -c Release \
  -r linux-x64 \
  --self-contained true \
  -o ./publish/DedicatedServer

# Build Master Server
dotnet publish MasterServer/SOD.Multiplayer.Master.csproj \
  -c Release \
  -r linux-x64 \
  --self-contained true \
  -o ./publish/MasterServer
```

## Running

### Starting Master Server (Linux)

```bash
cd /path/to/publish/MasterServer
export MASTER_PORT=5000
./SOD.Multiplayer.Master
```

The master server will listen on `http://0.0.0.0:5000`

### Starting Dedicated Server (Linux)

Create a config file `server_config.json`:

```json
{
  "ServerName": "My SOD Server",
  "Port": 7777,
  "MaxPlayers": 4,
  "Password": "",
  "MasterServerUrl": "http://your-master-server-ip:5000"
}
```

Then run:

```bash
cd /path/to/publish/DedicatedServer
./SOD.Multiplayer.Dedicated
```

### Playing the Game

1. Start Shadows of Doubt with BepInEx
2. Wait for the main menu to load
3. Watch for log messages: `[SOD Multiplayer] ServerBrowserUI initialized. Press CTRL+M to toggle.`
4. **Press CTRL+M** to open the Server Browser
5. Click "REFRESH LIST" to fetch servers from master server
6. Select a server and click "JOIN SERVER"
7. If password protected, enter the password

## Troubleshooting

### UI doesn't appear / CTRL+M doesn't work

1. Check BepInEx log file: `E:\Games\Shadows of Doubt\BepInEx\LogOutput.log`
2. Look for lines containing "[SOD Multiplayer]"
3. Verify all Harmony patches applied successfully
4. Make sure you're pressing both CTRL and M together
5. Try Left CTRL or Right CTRL

### Build errors about missing assemblies

Ensure your game path is correct in `Directory.Build.props` and these files exist:
- `$(SODGamePath)\BepInEx\core\BepInEx.Core.dll`
- `$(SODGamePath)\BepInEx\core\0Harmony.dll`
- `$(SODGamePath)\MelonLoader\Managed\UnityEngine.CoreModule.dll`
- `$(SODGamePath)\MelonLoader\Managed\Assembly-CSharp.dll`

If using BepInEx 6.x (IL2CPP), paths might be different. Adjust accordingly.

### Cannot connect to server

1. Verify master server is running: `curl http://localhost:5000/api/servers`
2. Check firewall settings (ports 5000 and 7777)
3. Ensure dedicated server registered with master server
4. Check server logs for connection errors

### Server not showing in list

1. Verify dedicated server sent registration to master server
2. Check master server logs for registration
3. Ensure heartbeat interval is working (every 10 seconds)
4. Server may be removed if no heartbeat for 30 seconds

## Network Ports

| Component | Port | Protocol |
|-----------|------|----------|
| Master Server API | 5000 | HTTP/TCP |
| Dedicated Server | 7777 | TCP |

## Configuration

### Master Server Environment Variables

- `MASTER_PORT` (default: 5000) - API port
- `SERVER_TIMEOUT_SECONDS` (default: 30) - Remove servers without heartbeat

### Dedicated Server Config (server_config.json)

```json
{
  "ServerName": "My Server",
  "Port": 7777,
  "MaxPlayers": 4,
  "Password": "optional_password",
  "MasterServerUrl": "http://master-ip:5000"
}
```

## Development Phases

Current Status: **Phase 4 Complete**

- ✅ Phase 1: Basic network connection
- ✅ Phase 2: Player connect/disconnect
- ✅ Phase 3: 4-player limit enforcement
- ✅ Phase 4: Server browser & master server
- ✅ Phase 5: Password protection
- ⏳ Phase 6: Game state synchronization
- ⏳ Phase 7: Multiplayer gameplay

## License

This project is for educational purposes. Respect the game developers' terms of service.

## Support

Check logs in:
- Client: `E:\Games\Shadows of Doubt\BepInEx\LogOutput.log`
- Dedicated Server: Console output / syslog
- Master Server: Console output / syslog

Look for `[SOD Multiplayer]` prefix in logs.
