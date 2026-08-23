using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using SOD.Multiplayer.Client.Network;
using SOD.Multiplayer.Shared;

namespace SOD.Multiplayer.Client.UI
{
    public class ServerBrowserUI : MonoBehaviour
    {
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
        
        // Master Server URL
        private string _masterServerUrl = "http://localhost:5000";
        
        public void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
                return;
            }
            
            _instance = this;
            DontDestroyOnLoad(gameObject);
            
            InitializeUI();
        }
        
        private void InitializeUI()
        {
            // Create main panel
            _serverBrowserPanel = new GameObject("ServerBrowserPanel");
            _serverBrowserPanel.AddComponent<Canvas>();
            _serverBrowserPanel.AddComponent<GraphicRaycaster>();
            
            var canvas = _serverBrowserPanel.GetComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            
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
                new Vector2(-150, -170), new Vector2(120, 40), OnRefreshClicked);
            
            // Create join button
            CreateButton(_serverBrowserPanel.transform, "JoinBtn", "JOIN SERVER", 
                new Vector2(0, -170), new Vector2(120, 40), OnJoinClicked);
            
            // Create close button
            CreateButton(_serverBrowserPanel.transform, "CloseBtn", "CLOSE", 
                new Vector2(150, -170), new Vector2(120, 40), OnCloseClicked);
            
            // Create password input (hidden by default)
            _passwordInput = CreateInputField(_serverBrowserPanel.transform, "PasswordInput", 
                "Enter Password", new Vector2(0, -230), new Vector2(200, 30));
            _passwordInput.gameObject.SetActive(false);
            
            _serverBrowserPanel.SetActive(false);
            
            UnityEngine.Debug.Log("[SOD Multiplayer] Server Browser UI initialized");
        }
        
        public void Show()
        {
            _serverBrowserPanel.SetActive(true);
            RefreshServerList();
        }
        
        public void Hide()
        {
            _serverBrowserPanel.SetActive(false);
        }
        
        private void RefreshServerList()
        {
            // Clear existing entries
            foreach (Transform child in _serverListContent)
            {
                UnityEngine.Object.Destroy(child.gameObject);
            }
            
            // Fetch server list from master server
            StartCoroutine(FetchServers());
        }
        
        private System.Collections.IEnumerator FetchServers()
        {
            using (var www = UnityEngine.Networking.UnityWebRequest.Get($"{_masterServerUrl}/api/servers"))
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
            
            _networkClient.OnConnected += () =>
            {
                UnityEngine.Debug.Log("[SOD Multiplayer] Connected to game server, sending join request");
                _networkClient.SendJoinRequest(PlayerPrefs.GetString("PlayerName", "Player1"), password);
            };
            
            _networkClient.Connect(_selectedServerIp, _selectedServerPort);
        }
        
        private void OnCloseClicked()
        {
            Hide();
        }
        
        // Helper methods to create UI elements
        private GameObject CreatePanel(Transform parent, string name, Vector2 pos, Vector2 size)
        {
            var obj = new GameObject(name);
            obj.transform.SetParent(parent, false);
            obj.AddComponent<RectTransform>().anchoredPosition = pos;
            obj.AddComponent<RectTransform>().sizeDelta = size;
            
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
        public string ServerIp { get; set; }
        public int ServerPort { get; set; }
        public bool HasPassword { get; set; }
    }
}
