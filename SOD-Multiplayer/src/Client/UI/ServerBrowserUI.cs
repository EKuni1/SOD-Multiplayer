using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using SOD.Multiplayer.Client.Network;
using SOD.Multiplayer.Client.Harmony;
using SOD.Multiplayer.Shared;

namespace SOD.Multiplayer.Client.UI
{
    public class ServerBrowserUI : MonoBehaviour
    {
        private static ServerBrowserUI _instance;
        public static ServerBrowserUI Instance => _instance;

        public ServerBrowserUI(IntPtr ptr) : base(ptr)
        {
        }
        
        private GameObject _serverBrowserPanel;
        private Transform _serverListContent;
        private TMP_InputField _passwordInput;
        private string _selectedServerIp = "";
        private int _selectedServerPort = 7777;
        private bool _selectedServerHasPassword = false;
        private bool _isHost;
        private GameObject _statusLabel;
        private readonly ConcurrentQueue<Action> _mainThreadActions = new();
        private readonly Dictionary<string, GameObject> _remotePlayers = new();
        private readonly Dictionary<string, Vector3> _remotePlayerTargets = new();
        private float _nextPositionUpdate;
        private float _nextPositionLog;
        
        private NetworkClient _networkClient;
        private PacketHandler _packetHandler;
        private bool _requestInProgress;
        private string _pendingServerJson;
        private string _pendingRequestError;
        
        // Master Server URL
        private string _masterServerUrl = "http://127.0.0.1:5000";
        
        public void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
                return;
            }
            
            _instance = this;
            _masterServerUrl = MultiplayerMod.MasterServerUrl ?? _masterServerUrl;
            transform.SetParent(null, false);
            DontDestroyOnLoad(gameObject);
            
            InitializeUI();
        }
        
        private void InitializeUI()
        {
            // Create main panel
            _serverBrowserPanel = new GameObject("ServerBrowserPanel");
            var rootRect = _serverBrowserPanel.GetComponent<RectTransform>();
            if (rootRect == null)
            {
                rootRect = _serverBrowserPanel.AddComponent<RectTransform>();
            }

            _serverBrowserPanel.AddComponent<Canvas>();
            var canvasScaler = _serverBrowserPanel.AddComponent<CanvasScaler>();
            _serverBrowserPanel.AddComponent<GraphicRaycaster>();

            rootRect.anchorMin = new Vector2(0.5f, 0.5f);
            rootRect.anchorMax = new Vector2(0.5f, 0.5f);
            rootRect.anchoredPosition = Vector2.zero;
            rootRect.sizeDelta = new Vector2(Screen.width, Screen.height);
            rootRect.offsetMin = Vector2.zero;
            rootRect.offsetMax = Vector2.zero;
            
            var canvas = _serverBrowserPanel.GetComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.overrideSorting = true;
            canvas.sortingOrder = 1000;
            canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            canvasScaler.referenceResolution = new Vector2(1920, 1080);
            
            // Add background
            var bg = _serverBrowserPanel.AddComponent<Image>();
            bg.color = new Color(0, 0, 0, 0.9f);
            
            // Create title
            CreateLabel(_serverBrowserPanel.transform, "Title", "MULTIPLAYER SERVER BROWSER", 
                new Vector2(0, 250), new Vector2(400, 50), 24, Color.white);
            
            // Create server list container
            var listContainer = CreatePanel(_serverBrowserPanel.transform, "ServerListContainer", 
                new Vector2(0, 0), new Vector2(400, 300));
            _serverListContent = listContainer.transform;
            
            // Create refresh button
            CreateButton(_serverBrowserPanel.transform, "RefreshBtn", "REFRESH LIST", 
                new Vector2(-150, -170), new Vector2(120, 40),
                Il2CppInterop.Runtime.DelegateSupport.ConvertDelegate<UnityEngine.Events.UnityAction>(OnRefreshClicked));
            
            // Create join button
            CreateButton(_serverBrowserPanel.transform, "JoinBtn", "JOIN SERVER", 
                new Vector2(0, -170), new Vector2(120, 40),
                Il2CppInterop.Runtime.DelegateSupport.ConvertDelegate<UnityEngine.Events.UnityAction>(OnJoinClicked));

            // Create host button
            CreateButton(_serverBrowserPanel.transform, "HostBtn", "HOST / LOAD SAVE", 
                new Vector2(0, -220), new Vector2(180, 40),
                Il2CppInterop.Runtime.DelegateSupport.ConvertDelegate<UnityEngine.Events.UnityAction>(OnHostClicked));
            
            // Create close button
            CreateButton(_serverBrowserPanel.transform, "CloseBtn", "CLOSE", 
                new Vector2(150, -170), new Vector2(120, 40),
                Il2CppInterop.Runtime.DelegateSupport.ConvertDelegate<UnityEngine.Events.UnityAction>(OnCloseClicked));
            
            // Create password input (hidden by default)
            _passwordInput = CreateInputField(_serverBrowserPanel.transform, "PasswordInput", 
                "Enter Password", new Vector2(0, -230), new Vector2(200, 30));
            _passwordInput.gameObject.SetActive(false);
            
            _serverBrowserPanel.SetActive(false);
            
            UnityEngine.Debug.Log("[SOD Multiplayer] Server Browser UI initialized");
        }
        
        public void Show()
        {
            if (_serverBrowserPanel == null || _serverListContent == null)
            {
                UnityEngine.Debug.LogError("[SOD Multiplayer] Server browser UI is not initialized");
                return;
            }

            _serverBrowserPanel.SetActive(true);
            RefreshServerList();
        }
        
        public void Hide()
        {
            _serverBrowserPanel.SetActive(false);
        }

        public void Update()
        {
            while (_mainThreadActions.TryDequeue(out var action))
            {
                action();
            }

            if (_networkClient != null && _networkClient.IsConnected && Time.time >= _nextPositionUpdate)
            {
                _nextPositionUpdate = Time.time + 0.1f;
                if (Player.Instance != null)
                {
                    var position = Player.Instance.transform.position;
                    _networkClient.SendPlayerUpdate(position.x, position.y, position.z);
                }
            }

            if (_pendingServerJson != null)
            {
                var json = _pendingServerJson;
                _pendingServerJson = null;
                _requestInProgress = false;
                PopulateServerList(json);
            }
            else if (_pendingRequestError != null)
            {
                var error = _pendingRequestError;
                _pendingRequestError = null;
                _requestInProgress = false;
                ShowServerListError(error);
            }
        }
        
        private void RefreshServerList()
        {
            // Clear existing entries
            for (var index = _serverListContent.childCount - 1; index >= 0; index--)
            {
                var child = _serverListContent.GetChild(index);
                UnityEngine.Object.Destroy(child.gameObject);
            }
            
            _statusLabel = CreateLabel(_serverListContent, "Status", "Loading servers...", 
                Vector2.zero, new Vector2(300, 30), 16, Color.white);

            if (_requestInProgress)
            {
                return;
            }

            _requestInProgress = true;
            Task.Run(async () =>
            {
                try
                {
                    using (var client = new HttpClient())
                    {
                        _pendingServerJson = await client.GetStringAsync(
                            $"{_masterServerUrl}/api/servers");
                    }
                }
                catch (Exception ex)
                {
                    _pendingRequestError = ex.Message;
                }
            });
        }
        
        private void PopulateServerList(string json)
        {
            for (var index = _serverListContent.childCount - 1; index >= 0; index--)
            {
                var child = _serverListContent.GetChild(index);
                UnityEngine.Object.Destroy(child.gameObject);
            }

            var servers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ServerInfo>>(json);
            if (servers == null || servers.Count == 0)
            {
                CreateLabel(_serverListContent, "Status", "No servers available", 
                    Vector2.zero, new Vector2(300, 30), 16, Color.white);
                return;
            }

            for (var index = 0; index < servers.Count; index++)
            {
                CreateServerEntry(servers[index], index);
            }
        }

        private void ShowServerListError(string error)
        {
            for (var index = _serverListContent.childCount - 1; index >= 0; index--)
            {
                var child = _serverListContent.GetChild(index);
                UnityEngine.Object.Destroy(child.gameObject);
            }

            UnityEngine.Debug.LogError($"[SOD Multiplayer] Failed to fetch servers: {error}");
            CreateLabel(_serverListContent, "Error", "Failed to load servers", 
                Vector2.zero, new Vector2(300, 30), 16, Color.red);
        }
        
        private void CreateServerEntry(ServerInfo server, int index)
        {
            var entry = CreatePanel(_serverListContent, $"Server_{server.Id}", 
            new Vector2(0, 125 - (index * 70)), new Vector2(380, 65));
            
            // Server name
            CreateLabel(entry.transform, "Name", server.Name, 
                new Vector2(-180, 0), new Vector2(150, 30), 14, Color.white);
            
            // Players
            CreateLabel(entry.transform, "Players", $"{server.CurrentPlayers}/{server.MaxPlayers}", 
                new Vector2(-50, 0), new Vector2(60, 30), 14, Color.yellow);
            
            // Password indicator
            string pwdStatus = server.HasPassword ? "[PWD]" : "";
            Color pwdColor = server.HasPassword ? Color.red : Color.green;
            CreateLabel(entry.transform, "Password", pwdStatus, 
                new Vector2(50, 0), new Vector2(50, 30), 14, pwdColor);

            CreateLabel(entry.transform, "Map", $"Map: {server.Map} | Save: {server.SaveGame}",
                new Vector2(0, -24), new Vector2(360, 20), 10, Color.gray);
            
            // Store server info for selection
            var selectData = entry.AddComponent<ServerSelectData>();
            selectData.ServerIp = server.Ip;
            selectData.ServerPort = server.Port;
            selectData.HasPassword = server.HasPassword;

            var selectButton = entry.AddComponent<Button>();
            selectButton.targetGraphic = entry.GetComponent<Image>();
            selectButton.onClick.AddListener(
                Il2CppInterop.Runtime.DelegateSupport.ConvertDelegate<UnityEngine.Events.UnityAction>(
                    () => OnServerSelected(selectData)));
        }
        
        private void OnServerSelected(ServerSelectData data)
        {
            _selectedServerIp = data.ServerIp;
            _selectedServerPort = data.ServerPort;
            _selectedServerHasPassword = data.HasPassword;
            SetStatus($"Selected: {data.ServerIp}:{data.ServerPort}", Color.yellow);
            
            if (data.HasPassword)
            {
                _passwordInput.gameObject.SetActive(true);
            }
            else
            {
                _passwordInput.gameObject.SetActive(false);
            }
        }
        
        private void OnRefreshClicked()
        {
            RefreshServerList();
        }
        
        private void OnJoinClicked()
        {
            if (string.IsNullOrEmpty(_selectedServerIp))
            {
                UnityEngine.Debug.LogWarning("[SOD Multiplayer] No server selected");
                SetStatus("Select a server first", Color.red);
                return;
            }

            SetStatus($"Connecting to {_selectedServerIp}:{_selectedServerPort}...", Color.yellow);
            _isHost = false;
            MultiplayerMod.IsHost = false;
            
            string password = _selectedServerHasPassword ? _passwordInput.text : "";
            
            // Initialize network client
            _networkClient = new NetworkClient();
            _packetHandler = new PacketHandler(_networkClient);
            
            _networkClient.OnConnected += () =>
            {
                NetworkClient.LogInfo("Connected to game server, sending join request");
                Dispatch(() =>
                {
                    SetStatus("Connected. Joining...", Color.yellow);
                    _networkClient.SendJoinRequest(PlayerPrefs.GetString("PlayerName", "Player1"), password);
                });
            };

            _networkClient.OnDisconnected += () => Dispatch(() => SetStatus("Disconnected", Color.red));
            _networkClient.OnJoinAccepted += response => Dispatch(() =>
            {
                SetStatus("Joined. Select the matching save and map.", Color.green);
                Hide();
                OpenNativeLoadMenu();
            });
            _networkClient.OnJoinRejected += reason => Dispatch(() => SetStatus($"Join rejected: {reason}", Color.red));
            _networkClient.OnGameStateReceived += gameState => Dispatch(() => UpdateRemotePlayers(gameState));
            _networkClient.OnWorldEvent += worldEvent => Dispatch(() => WorldSync.Apply(worldEvent));
            _networkClient.OnSessionSelected += session => Dispatch(() =>
                SetStatus($"Host selected save: {session.SaveFileName}", Color.green));
            
            _networkClient.Connect(_selectedServerIp, _selectedServerPort);
        }

        private void OnHostClicked()
        {
            if (string.IsNullOrEmpty(_selectedServerIp))
            {
                SetStatus("Select a server first", Color.red);
                return;
            }

            SetStatus("Connecting host...", Color.yellow);
            _isHost = true;
            MultiplayerMod.IsHost = true;
            _networkClient = new NetworkClient();
            _packetHandler = new PacketHandler(_networkClient);

            _networkClient.OnConnected += () =>
            {
                Dispatch(() =>
                {
                    SetStatus("Connected. Loading save menu...", Color.yellow);
                    string password = _selectedServerHasPassword ? _passwordInput.text : "";
                    _networkClient.SendJoinRequest(PlayerPrefs.GetString("PlayerName", "Host"), password);
                });
            };
            _networkClient.OnJoinAccepted += response =>
            {
                Dispatch(() =>
                {
                    SetStatus("Host connected. Select your save and map.", Color.green);
                    Hide();
                    OpenNativeLoadMenu();
                });
            };
            _networkClient.OnJoinRejected += reason => Dispatch(() => SetStatus($"Host rejected: {reason}", Color.red));
            _networkClient.OnDisconnected += () => Dispatch(() => SetStatus("Disconnected", Color.red));
            _networkClient.OnSessionSelected += session => Dispatch(() =>
                SetStatus($"Host selected save: {session.SaveFileName}", Color.green));
            _networkClient.OnGameStateReceived += gameState => Dispatch(() => UpdateRemotePlayers(gameState));
            _networkClient.OnWorldEvent += worldEvent => Dispatch(() => WorldSync.Apply(worldEvent));

            _networkClient.Connect(_selectedServerIp, _selectedServerPort);
        }

        public void NotifySaveSelected(string saveFileName)
        {
            if (_isHost && _networkClient != null && _networkClient.IsConnected)
            {
                _networkClient.SendSessionSelected(saveFileName);
                SetStatus($"Save selected: {saveFileName}", Color.green);
            }
        }

        private void SetStatus(string message, Color color)
        {
            if (_statusLabel != null)
            {
                var statusText = _statusLabel.GetComponent<TMP_Text>();
                statusText.text = message;
                statusText.color = color;
            }
            UnityEngine.Debug.Log($"[SOD Multiplayer] {message}");
        }

        private void UpdateRemotePlayers(GameStatePacket gameState)
        {
            if (!_isHost && SessionData.Instance != null && gameState.GameTime > 0f)
            {
                MultiplayerMod.SynchronizedGameTime = gameState.GameTime;
            }

            var activeIds = new HashSet<string>();
            foreach (var player in gameState.Players)
            {
                if (string.IsNullOrEmpty(player.Id) || player.Id == _networkClient.PlayerId)
                {
                    continue;
                }

                activeIds.Add(player.Id);
                if (Time.time >= _nextPositionLog)
                {
                    NetworkClient.LogInfo($"Remote player {player.Id} position: {player.PositionX:F2}, {player.PositionY:F2}, {player.PositionZ:F2}");
                }
                if (!_remotePlayers.TryGetValue(player.Id, out var marker))
                {
                    marker = new GameObject($"SODRemotePlayer_{player.Id}");
                    marker.name = $"SODRemotePlayer_{player.Id}";
                    marker.transform.localScale = new Vector3(0.8f, 1.4f, 0.8f);
                    var meshFilter = marker.AddComponent<MeshFilter>();
                    var meshRenderer = marker.AddComponent<MeshRenderer>();
                    meshFilter.mesh = Resources.GetBuiltinResource<Mesh>("Cube.fbx");
                    var localRenderer = Player.Instance != null
                        ? Player.Instance.GetComponentInChildren<MeshRenderer>()
                        : null;
                    if (localRenderer == null || localRenderer.sharedMaterial == null)
                    {
                        NetworkClient.LogError("Could not create remote marker: no player material available");
                        Destroy(marker);
                        continue;
                    }

                    meshRenderer.sharedMaterial = localRenderer.sharedMaterial;
                    _remotePlayers[player.Id] = marker;
                }

                marker.SetActive(true);
                var targetPosition = new Vector3(player.PositionX, player.PositionY, player.PositionZ);
                _remotePlayerTargets[player.Id] = targetPosition;
                marker.transform.position = Vector3.Lerp(
                    marker.transform.position,
                    targetPosition,
                    Mathf.Clamp01(Time.deltaTime * 20f));
            }

            if (Time.time >= _nextPositionLog)
            {
                _nextPositionLog = Time.time + 2f;
            }

            foreach (var remotePlayer in new List<KeyValuePair<string, GameObject>>(_remotePlayers))
            {
                if (!activeIds.Contains(remotePlayer.Key))
                {
                    Destroy(remotePlayer.Value);
                    _remotePlayers.Remove(remotePlayer.Key);
                    _remotePlayerTargets.Remove(remotePlayer.Key);
                }
            }
        }

        private void OpenNativeLoadMenu()
        {
            if (MainMenuController.Instance != null)
            {
                MainMenuController.Instance.LoadGame();
            }
            else
            {
                UnityEngine.Debug.LogError("[SOD Multiplayer] Main menu is not available");
            }
        }

        private void Dispatch(Action action)
        {
            _mainThreadActions.Enqueue(action);
        }
        
        private void OnCloseClicked()
        {
            Hide();
        }
        
        // Helper methods to create UI elements
        private GameObject CreatePanel(Transform parent, string name, Vector2 pos, Vector2 size)
        {
            var obj = new GameObject(name);
            var rect = obj.GetComponent<RectTransform>();
            if (rect == null)
            {
                rect = obj.AddComponent<RectTransform>();
            }

            rect.SetParent(parent, false);
            rect.anchoredPosition = pos;
            rect.sizeDelta = size;
            
            var img = obj.AddComponent<Image>();
            img.color = new Color(0.2f, 0.2f, 0.2f, 0.8f);
            
            return obj;
        }
        
        private GameObject CreateLabel(Transform parent, string name, string text, 
            Vector2 pos, Vector2 size, int fontSize, Color color)
        {
            var obj = new GameObject(name);
            obj.transform.SetParent(parent, false);
            var rect = obj.AddComponent<RectTransform>();
            rect.anchoredPosition = pos;
            rect.sizeDelta = size;
            
            var txt = obj.AddComponent<TextMeshProUGUI>();
            txt.text = text;
            txt.fontSize = fontSize;
            txt.color = color;
            txt.alignment = TextAlignmentOptions.Center;
            
            return obj;
        }
        
        private GameObject CreateButton(Transform parent, string name, string text, 
            Vector2 pos, Vector2 size, UnityEngine.Events.UnityAction onClick)
        {
            var obj = CreatePanel(parent, name, pos, size);
            obj.GetComponent<Image>().color = new Color(0.3f, 0.3f, 0.3f, 0.9f);
            
            var btn = obj.AddComponent<Button>();
            btn.targetGraphic = obj.GetComponent<Image>();
            
            // Add text to button
            var textObj = new GameObject("Text");
            textObj.transform.SetParent(obj.transform, false);
            var textRect = textObj.AddComponent<RectTransform>();
            textRect.anchorMin = Vector2.zero;
            textRect.anchorMax = Vector2.one;
            textRect.sizeDelta = Vector2.zero;
            
            var tmp = textObj.AddComponent<TextMeshProUGUI>();
            tmp.text = text;
            tmp.fontSize = 16;
            tmp.color = Color.white;
            tmp.alignment = TextAlignmentOptions.Center;
            
            btn.onClick.AddListener(onClick);
            
            return obj;
        }
        
        private TMP_InputField CreateInputField(Transform parent, string name, string placeholder, 
            Vector2 pos, Vector2 size)
        {
            var obj = CreatePanel(parent, name, pos, size);
            obj.GetComponent<Image>().color = new Color(0.1f, 0.1f, 0.1f, 0.9f);
            
            var input = obj.AddComponent<TMP_InputField>();
            
            // Add text component
            var textObj = new GameObject("Text");
            textObj.transform.SetParent(obj.transform, false);
            var textRect = textObj.AddComponent<RectTransform>();
            textRect.anchorMin = Vector2.zero;
            textRect.anchorMax = Vector2.one;
            textRect.sizeDelta = new Vector2(-20, -10);
            
            var tmp = textObj.AddComponent<TextMeshProUGUI>();
            tmp.fontSize = 14;
            tmp.color = Color.white;
            tmp.alignment = TextAlignmentOptions.Left;
            
            input.textComponent = tmp;
            input.placeholder = new GameObject("Placeholder").AddComponent<TextMeshProUGUI>();
            ((TextMeshProUGUI)input.placeholder).text = placeholder;
            ((TextMeshProUGUI)input.placeholder).color = new Color(1, 1, 1, 0.5f);
            
            return input;
        }
    }
    
    // Component to store server selection data
    public class ServerSelectData : MonoBehaviour
    {
        public ServerSelectData(IntPtr ptr) : base(ptr)
        {
        }

        public string ServerIp { get; set; }
        public int ServerPort { get; set; }
        public bool HasPassword { get; set; }
    }
}
