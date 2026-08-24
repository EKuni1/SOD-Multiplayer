using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Injection;
using SOD.Multiplayer.Client.Network;
using SOD.Multiplayer.Shared;

namespace SOD.Multiplayer.Client.UI
{
    public class ServerBrowserUI : MonoBehaviour
    {
        public ServerBrowserUI(IntPtr ptr) : base(ptr)
        {
        }

        public ServerBrowserUI() : this(ClassInjector.DerivedConstructorPointer<ServerBrowserUI>())
        {
            ClassInjector.DerivedConstructorBody(this);
        }

        private static ServerBrowserUI _instance;
        public static ServerBrowserUI Instance => _instance;
        
        private GameObject _serverBrowserPanel;
        private Transform _serverListContent;
        private TMP_InputField _passwordInput;
        private string _selectedServerIp = "";
        private int _selectedServerPort = 7777;
        private bool _selectedServerHasPassword = false;
        
        private NetworkClient _networkClient;
        private PacketHandler _packetHandler;
        private readonly Dictionary<string, PlayerInfo> _remotePlayerStates = new();
        private float _nextPositionUpdate;
        private TextMeshProUGUI _chatOutput;
        private TMP_InputField _chatInput;
        
        // Master Server URL - configure this!
        private string _masterServerUrl = "http://localhost:5000";
        
        // Keyboard shortcut handling
        private bool _ctrlPressed = false;
        private bool _initialized = false;
        
        public void Initialize()
        {
            if (_initialized) return;
            
            Debug.Log("[SOD Multiplayer] Initializing Server Browser UI...");
            InitializeUI();
            _initialized = true;
        }
        
        public void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
                return;
            }
            
            _instance = this;
            DontDestroyOnLoad(gameObject);
            _masterServerUrl = MultiplayerMod.MasterServerUrl ?? _masterServerUrl;
            
            // Don't initialize here - wait for explicit Initialize() call
            Debug.Log("[SOD Multiplayer] ServerBrowserUI component created. Call Initialize() to setup UI.");
        }
        
        private void Update()
        {
            // Handle Ctrl+M keyboard shortcut
            if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
            {
                _ctrlPressed = true;
            }
            else if (_ctrlPressed && Input.GetKeyDown(KeyCode.M))
            {
                ToggleUI();
                _ctrlPressed = false;
            }
        }
        
        public void ToggleVisibility(bool show)
        {
            if (_serverBrowserPanel == null)
            {
                Debug.LogWarning("[SOD Multiplayer] UI not initialized yet!");
                return;
            }
            
            _serverBrowserPanel.SetActive(show);
            
            if (show)
            {
                RefreshServerList();
                Debug.Log("[SOD Multiplayer] Server Browser opened.");
            }
            else
            {
                Debug.Log("[SOD Multiplayer] Server Browser closed.");
            }
        }
        
        public void ToggleUI()
        {
            if (_serverBrowserPanel == null)
            {
                Debug.LogWarning("[SOD Multiplayer] UI not initialized yet!");
                return;
            }
            
            bool newState = !_serverBrowserPanel.activeSelf;
            ToggleVisibility(newState);
        }
        
        public void Show()
        {
            ToggleVisibility(true);
        }
        
        public void Hide()
        {
            ToggleVisibility(false);
        }
        
        private void InitializeUI()
        {
            // Create main panel
            _serverBrowserPanel = new GameObject("ServerBrowserPanel");
            _serverBrowserPanel.AddComponent<Canvas>();
            _serverBrowserPanel.AddComponent<GraphicRaycaster>();
            
            var canvas = _serverBrowserPanel.GetComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.sortingOrder = 1000; // Ensure it's on top
            
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
                new Vector2(-150, -170), new Vector2(120, 40), () => OnRefreshClicked());
            
            // Create join button
            CreateButton(_serverBrowserPanel.transform, "JoinBtn", "JOIN SERVER", 
                new Vector2(0, -170), new Vector2(120, 40), () => OnJoinClicked());
            
            // Create close button
            CreateButton(_serverBrowserPanel.transform, "CloseBtn", "CLOSE (Ctrl+M)", 
                new Vector2(150, -170), new Vector2(120, 40), OnCloseClicked);
            
            // Create password input (hidden by default)
            _passwordInput = CreateInputField(_serverBrowserPanel.transform, "PasswordInput", 
                "Enter Password", new Vector2(0, -230), new Vector2(200, 30));
            _passwordInput.gameObject.SetActive(false);

            _chatOutput = CreateLabel(_serverBrowserPanel.transform, "Chat", "", 
                new Vector2(0, -270), new Vector2(380, 40), 12, Color.white).GetComponent<TextMeshProUGUI>();
            
            // Start with panel HIDDEN - will be shown with Ctrl+M
            _serverBrowserPanel.SetActive(false);
            
            Debug.Log("[SOD Multiplayer] Server Browser UI created. Press CTRL+M to open.");
        }
        
        public void Show()
        {
            if (_serverBrowserPanel == null)
            {
                MultiplayerMod.Instance?.Log.LogError("ServerBrowserUI.Show: Panel wurde nicht erstellt.");
                return;
            }

            _serverBrowserPanel.SetActive(true);
            MultiplayerMod.Instance?.Log.LogInfo("Serverbrowser geoeffnet.");
            RefreshServerList();
        }
        
        public void Hide()
        {
            if (_serverBrowserPanel == null)
                return;

            _serverBrowserPanel.SetActive(false);
            MultiplayerMod.Instance?.Log.LogInfo("Serverbrowser geschlossen.");
        }
        
        private void RefreshServerList()
        {
            // Clear existing entries
            foreach (Transform child in _serverListContent)
            {
                UnityEngine.Object.Destroy(child.gameObject);
            }
            
            // Fetch server list from master server
            StartCoroutine(nameof(FetchServers));
        }
        
        private System.Collections.IEnumerator FetchServers()
        {
            var www = UnityEngine.Networking.UnityWebRequest.Get($"{_masterServerUrl}/api/servers");
            www.SetRequestHeader("X-Auth-Token", MultiplayerMod.MasterServerAuthToken ?? "");
            {
                
                yield return www.SendWebRequest();
                
                if (www.result == UnityEngine.Networking.UnityWebRequest.Result.Success)
                {
                    string json = www.downloadHandler.text;
                    var servers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ServerInfo>>(json);
                    
                    foreach (var server in servers)
                    {
                        CreateServerEntry(server);
                    }
                }
                else
                {
                    UnityEngine.Debug.LogError($"[SOD Multiplayer] Failed to fetch servers: {www.error}");
                    CreateLabel(_serverListContent, "Error", "Failed to load servers", 
                        Vector2.zero, new Vector2(300, 30), 16, Color.red);
                }
            }
        }
        
        private void CreateServerEntry(ServerInfo server)
        {
            var entry = CreatePanel(_serverListContent, $"Server_{server.Id}", 
                Vector2.zero, new Vector2(380, 50));
            var selectButton = entry.AddComponent<Button>();
            selectButton.targetGraphic = entry.GetComponent<Image>();
            
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
            
            // Store server info for selection
            var selectData = entry.AddComponent<ServerSelectData>();
            selectData.ServerIp = server.Ip;
            selectData.ServerPort = server.Port;
            selectData.HasPassword = server.HasPassword;
            selectButton.onClick.AddListener(DelegateSupport.ConvertDelegate<UnityEngine.Events.UnityAction>(
                () => OnServerSelected(selectData)));
        }
        
        private void OnServerSelected(ServerSelectData data)
        {
            _selectedServerIp = data.ServerIp;
            _selectedServerPort = data.ServerPort;
            _selectedServerHasPassword = data.HasPassword;
            
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
                return;
            }
            
            string password = _selectedServerHasPassword ? _passwordInput.text : "";
            
            // Initialize network client
            _networkClient = new NetworkClient();
            _packetHandler = new PacketHandler(_networkClient);
            _packetHandler.GameStateReceived += state =>
            {
                foreach (var player in state.Players)
                {
                    if (player.Id != _networkClient.PlayerId)
                        _remotePlayerStates[player.Id] = player;
                }
            };
            _packetHandler.ChatReceived += chat =>
            {
                if (_chatOutput != null)
                    _chatOutput.text = chat.Message;
            };
            
            _networkClient.OnConnected += () =>
            {
                UnityEngine.Debug.Log("[SOD Multiplayer] Connected to game server, sending join request");
                _networkClient.SendJoinRequest(PlayerPrefs.GetString("PlayerName", "Player1"), password);
            };
            
            _networkClient.Connect(_selectedServerIp, _selectedServerPort);
        }

        private void UpdateNetworkState()
        {
            if (_networkClient == null || !_networkClient.IsConnected)
                return;

            if (Time.unscaledTime >= _nextPositionUpdate && Player.Instance != null)
            {
                var position = Player.Instance.transform.position;
                _networkClient.SendPlayerUpdate(position.x, position.y, position.z);
                _nextPositionUpdate = Time.unscaledTime + 0.1f;
            }

            foreach (var state in _remotePlayerStates.Values)
            {
                if (!_remotePlayerStates.TryGetValue(state.Id, out var current))
                    continue;

                var markerName = $"SOD_RemotePlayer_{current.Id}";
                var marker = GameObject.Find(markerName);
                if (marker == null)
                {
                    marker = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    marker.name = markerName;
                    marker.transform.localScale = Vector3.one * 0.5f;
                }

                var target = new Vector3(current.PositionX, current.PositionY, current.PositionZ);
                marker.transform.position = Vector3.Lerp(marker.transform.position, target, Time.unscaledDeltaTime * 20f);
            }
        }
        
        private void OnCloseClicked()
        {
            Hide();
        }
        
        // Helper methods to create UI elements
        private GameObject CreatePanel(Transform parent, string name, Vector2 pos, Vector2 size)
        {
            if (parent == null)
                throw new InvalidOperationException($"Cannot create UI panel '{name}' without a parent.");

            var obj = new GameObject(name);
            obj.transform.SetParent(parent, false);
            var rect = obj.GetComponent<RectTransform>() ?? obj.AddComponent<RectTransform>();
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
            Vector2 pos, Vector2 size, Action onClick)
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
            
            btn.onClick.AddListener(DelegateSupport.ConvertDelegate<UnityEngine.Events.UnityAction>(onClick));
            
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

        public ServerSelectData() : this(ClassInjector.DerivedConstructorPointer<ServerSelectData>())
        {
            ClassInjector.DerivedConstructorBody(this);
        }

        public string ServerIp { get; set; }
        public int ServerPort { get; set; }
        public bool HasPassword { get; set; }
    }
}
