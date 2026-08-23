using System;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using SOD_Multiplayer.Network;

namespace SOD_Multiplayer.UI
{
    /// <summary>
    /// Server-Browser UI für die Multiplayer-Mod
    /// Zeigt verfügbare Server und ermöglicht Verbindung
    /// PHASE 4: Vollständige Serverliste mit Master-Server Integration
    /// </summary>
    public class ServerBrowserUI
    {
        private GameObject _mainPanel;
        private bool _isVisible;
        private List<ServerInfoData> _serverList = new List<ServerInfoData>();
        private ServerInfoData _selectedServer;
        private GameObject _serverListContainer;
        private GameObject _passwordPanel;
        private TMP_InputField _passwordInput;
        private string _masterServerUrl = "http://localhost:27016";
        
        /// <summary>
        /// Ist das UI sichtbar?
        /// </summary>
        public bool IsVisible => _isVisible;
        
        public ServerBrowserUI()
        {
            LoadConfig();
        }
        
        private void LoadConfig()
        {
            // Config laden - wird später aus Datei gelesen
            _masterServerUrl = Environment.GetEnvironmentVariable("SOD_MASTER_SERVER") ?? "http://localhost:27016";
            MultiplayerMod.Instance?.Log.LogInfo($"Master Server URL: {_masterServerUrl}");
        }
        
        /// <summary>
        /// Server-Browser anzeigen
        /// </summary>
        public void Show()
        {
            if (_isVisible)
                return;
                
            CreateUI();
            _isVisible = true;
            
            MultiplayerMod.Instance?.Log.LogInfo("Server-Browser geöffnet");
            
            // Serverliste laden
            RefreshServerList();
        }
        
        /// <summary>
        /// Server-Browser verstecken
        /// </summary>
        public void Hide()
        {
            if (!_isVisible)
                return;
                
            if (_mainPanel != null)
            {
                Object.Destroy(_mainPanel);
                _mainPanel = null;
            }
            
            _isVisible = false;
            MultiplayerMod.Instance?.Log.LogInfo("Server-Browser geschlossen");
        }
        
        /// <summary>
        /// UI erstellen
        /// </summary>
        private void CreateUI()
        {
            // Canvas finden oder erstellen
            var canvas = Object.FindObjectOfType<Canvas>();
            if (canvas == null)
            {
                var canvasObj = new GameObject("MultiplayerCanvas");
                canvas = canvasObj.AddComponent<Canvas>();
                canvas.renderMode = RenderMode.ScreenSpaceOverlay;
                Object.DontDestroyOnLoad(canvasObj);
            }
            
            // Hauptpanel
            _mainPanel = new GameObject("ServerBrowserPanel");
            _mainPanel.transform.SetParent(canvas.transform, false);
            
            // RectTransform
            var rectTransform = _mainPanel.AddComponent<RectTransform>();
            rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
            rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
            rectTransform.sizeDelta = new Vector2(900, 650);
            rectTransform.anchoredPosition = Vector2.zero;
            
            // Background
            var image = _mainPanel.AddComponent<Image>();
            image.color = new Color(0.1f, 0.1f, 0.15f, 0.98f);
            
            // Titel
            CreateTitle("MULTIPLAYER SERVER BROWSER");
            
            // Refresh Button
            CreateButton("Refresh", new Vector2(-380, -60), 140, 40, OnRefreshClicked, new Color(0.2f, 0.5f, 0.3f, 1f));
            
            // Join Button
            CreateButton("Join Server", new Vector2(-200, -60), 160, 40, OnJoinClicked, new Color(0.2f, 0.4f, 0.7f, 1f));
            
            // Direct Connect Button
            CreateButton("Direct Connect", new Vector2(0, -60), 160, 40, OnDirectConnectClicked, new Color(0.5f, 0.4f, 0.2f, 1f));
            
            // Close Button
            CreateButton("Close", new Vector2(380, -60), 140, 40, OnCloseClicked, new Color(0.6f, 0.2f, 0.2f, 1f));
            
            // Status Label
            var statusObj = CreateLabel("Status: Ready", new Vector2(-430, -35), 900, 25);
            statusObj.name = "StatusLabel";
            
            // Server List Container mit Scroll View
            CreateServerListContainer();
            
            // Password Panel (versteckt)
            CreatePasswordPanel();
            
            MultiplayerMod.Instance?.Log.LogInfo("Server-Browser UI erstellt");
        }
        
        private GameObject CreateTitle(string text)
        {
            var titleObj = new GameObject("Title");
            titleObj.transform.SetParent(_mainPanel.transform);
            var titleText = titleObj.AddComponent<TextMeshProUGUI>();
            titleText.text = text;
            titleText.fontSize = 28;
            titleText.alignment = TextAlignmentOptions.Center;
            titleText.color = new Color(0.9f, 0.9f, 1f, 1f);
            titleText.fontStyle = FontStyles.Bold;
            
            var titleRect = titleObj.GetComponent<RectTransform>();
            titleRect.anchorMin = new Vector2(0, 1);
            titleRect.anchorMax = new Vector2(1, 1);
            titleRect.sizeDelta = new Vector2(0, 60);
            titleRect.anchoredPosition = new Vector2(0, -30);
            
            return titleObj;
        }
        
        private GameObject CreateLabel(string text, Vector2 position, int width, int height)
        {
            var labelObj = new GameObject("Label");
            labelObj.transform.SetParent(_mainPanel.transform);
            
            var rect = labelObj.AddComponent<RectTransform>();
            rect.anchorMin = new Vector2(0.5f, 0.5f);
            rect.anchorMax = new Vector2(0.5f, 0.5f);
            rect.sizeDelta = new Vector2(width, height);
            rect.anchoredPosition = position;
            
            var label = labelObj.AddComponent<TextMeshProUGUI>();
            label.text = text;
            label.fontSize = 14;
            label.alignment = TextAlignmentOptions.Left;
            label.color = Color.white;
            
            return labelObj;
        }
        
        /// <summary>
        /// Helper: Button erstellen
        /// </summary>
        private GameObject CreateButton(string text, Vector2 position, int width, int height, System.Action onClick, Color? color = null)
        {
            var btnObj = new GameObject(text.Replace(" ", "") + "Button");
            btnObj.transform.SetParent(_mainPanel.transform);
            
            var rect = btnObj.AddComponent<RectTransform>();
            rect.anchorMin = new Vector2(0.5f, 0.5f);
            rect.anchorMax = new Vector2(0.5f, 0.5f);
            rect.sizeDelta = new Vector2(width, height);
            rect.anchoredPosition = position;
            
            var image = btnObj.AddComponent<Image>();
            image.color = color ?? new Color(0.2f, 0.4f, 0.6f, 1f);
            
            var button = btnObj.AddComponent<Button>();
            button.onClick.AddListener(() => onClick?.Invoke());
            
            // Button Text
            var btnText = new GameObject("Text");
            btnText.transform.SetParent(btnObj.transform);
            var textComp = btnText.AddComponent<TextMeshProUGUI>();
            textComp.text = text;
            textComp.fontSize = 16;
            textComp.alignment = TextAlignmentOptions.Center;
            textComp.color = Color.white;
            textComp.fontStyle = FontStyles.Bold;
            
            var textRect = btnText.GetComponent<RectTransform>();
            textRect.anchorMin = Vector2.zero;
            textRect.anchorMax = Vector2.one;
            textRect.sizeDelta = Vector2.zero;
            textRect.anchoredPosition = Vector2.zero;
            
            return btnObj;
        }
        
        /// <summary>
        /// Server List Container mit Scroll View erstellen
        /// </summary>
        private void CreateServerListContainer()
        {
            // Scroll View
            var scrollObj = new GameObject("ServerListScroll");
            scrollObj.transform.SetParent(_mainPanel.transform);
            var scrollRect = scrollObj.AddComponent<RectTransform>();
            scrollRect.anchorMin = new Vector2(0, 0);
            scrollRect.anchorMax = new Vector2(1, 1);
            scrollRect.sizeDelta = new Vector2(-60, -180);
            scrollRect.anchoredPosition = new Vector2(0, -90);
            
            var scrollView = scrollObj.AddComponent<UnityEngine.UI.ScrollView>();
            scrollView.horizontal = false;
            scrollView.vertical = true;
            
            // Viewport
            var viewportObj = new GameObject("Viewport");
            viewportObj.transform.SetParent(scrollObj.transform);
            var viewportRect = viewportObj.AddComponent<RectTransform>();
            viewportRect.anchorMin = Vector2.zero;
            viewportRect.anchorMax = Vector2.one;
            viewportRect.sizeDelta = new Vector2(-20, 0);
            viewportRect.anchoredPosition = Vector2.zero;
            
            var viewportImage = viewportObj.AddComponent<Image>();
            viewportImage.color = new Color(0.15f, 0.15f, 0.2f, 0.5f);
            
            var mask = viewportObj.AddComponent<UnityEngine.UI.Mask>();
            scrollRect.viewport = viewportRect;
            
            // Content
            _serverListContainer = new GameObject("ServerListContent");
            _serverListContainer.transform.SetParent(viewportObj.transform);
            var contentRect = _serverListContainer.AddComponent<RectTransform>();
            contentRect.anchorMin = new Vector2(0, 1);
            contentRect.anchorMax = new Vector2(1, 1);
            contentRect.sizeDelta = new Vector2(0, 500);
            contentRect.pivot = new Vector2(0, 1);
            
            scrollRect.content = contentRect;
            
            // Scrollbar
            var scrollbarObj = new GameObject("Scrollbar");
            scrollbarObj.transform.SetParent(scrollObj.transform);
            var scrollbarRect = scrollbarObj.AddComponent<RectTransform>();
            scrollbarRect.anchorMin = new Vector2(1, 0);
            scrollbarRect.anchorMax = new Vector2(1, 1);
            scrollbarRect.sizeDelta = new Vector2(20, 0);
            scrollbarRect.anchoredPosition = Vector2.zero;
            
            var scrollbar = scrollbarObj.AddComponent<UnityEngine.UI.Scrollbar>();
            scrollbar.direction = UnityEngine.UI.Scrollbar.Direction.BottomToTop;
            scrollRect.verticalScrollbar = scrollbar;
            
            MultiplayerMod.Instance?.Log.LogInfo("Server List Container erstellt");
        }
        
        /// <summary>
        /// Password Input Panel erstellen
        /// </summary>
        private void CreatePasswordPanel()
        {
            _passwordPanel = new GameObject("PasswordPanel");
            _passwordPanel.transform.SetParent(_mainPanel.transform);
            _passwordPanel.SetActive(false);
            
            var rect = _passwordPanel.AddComponent<RectTransform>();
            rect.anchorMin = new Vector2(0.5f, 0.5f);
            rect.anchorMax = new Vector2(0.5f, 0.5f);
            rect.sizeDelta = new Vector2(400, 200);
            rect.anchoredPosition = Vector2.zero;
            
            var image = _passwordPanel.AddComponent<Image>();
            image.color = new Color(0.2f, 0.15f, 0.15f, 0.98f);
            
            // Title
            var titleObj = new GameObject("PasswordTitle");
            titleObj.transform.SetParent(_passwordPanel.transform);
            var title = titleObj.AddComponent<TextMeshProUGUI>();
            title.text = "SERVER PASSWORD";
            title.fontSize = 20;
            title.alignment = TextAlignmentOptions.Center;
            title.color = Color.white;
            var titleRect = titleObj.GetComponent<RectTransform>();
            titleRect.anchorMin = new Vector2(0, 1);
            titleRect.anchorMax = new Vector2(1, 1);
            titleRect.sizeDelta = new Vector2(0, 40);
            titleRect.anchoredPosition = new Vector2(0, -20);
            
            // Input Field
            var inputObj = new GameObject("PasswordInput");
            inputObj.transform.SetParent(_passwordPanel.transform);
            var inputRect = inputObj.AddComponent<RectTransform>();
            inputRect.anchorMin = new Vector2(0.1f, 0.4f);
            inputRect.anchorMax = new Vector2(0.9f, 0.6f);
            inputRect.anchoredPosition = Vector2.zero;
            
            var inputImage = inputObj.AddComponent<Image>();
            inputImage.color = new Color(0.1f, 0.1f, 0.1f, 1f);
            
            _passwordInput = inputObj.AddComponent<TMP_InputField>();
            _passwordInput.contentType = TMPro.InputField.ContentType.Password;
            _passwordInput.placeholder = CreatePlaceholder(inputObj, "Enter password...");
            
            // Submit Button
            CreateButton("Join", new Vector2(-100, -60), 120, 35, OnPasswordSubmit, new Color(0.3f, 0.5f, 0.3f, 1f))
                .transform.SetParent(_passwordPanel.transform);
            
            // Cancel Button
            CreateButton("Cancel", new Vector2(100, -60), 120, 35, OnPasswordCancel, new Color(0.5f, 0.3f, 0.3f, 1f))
                .transform.SetParent(_passwordPanel.transform);
        }
        
        private GameObject CreatePlaceholder(GameObject parent, string text)
        {
            var obj = new GameObject("Placeholder");
            obj.transform.SetParent(parent.transform);
            var tmp = obj.AddComponent<TextMeshProUGUI>();
            tmp.text = text;
            tmp.fontSize = 14;
            tmp.color = new Color(0.5f, 0.5f, 0.5f, 1f);
            var rect = obj.GetComponent<RectTransform>();
            rect.anchorMin = Vector2.zero;
            rect.anchorMax = Vector2.one;
            rect.offsetMin = new Vector2(10, 5);
            rect.offsetMax = new Vector2(-10, -5);
            return obj;
        }
        
        /// <summary>
        /// Serverliste aktualisieren (PHASE 4 - Master Server API)
        /// </summary>
        private void RefreshServerList()
        {
            UpdateStatus("Loading server list...");
            _serverList.Clear();
            ClearServerListEntries();
            
            MultiplayerMod.Instance?.Log.LogInfo($"Lade Serverliste von {_masterServerUrl}...");
            
            // Async HTTP Request an Master Server
            try
            {
                var request = UnityWebRequest.Get($"{_masterServerUrl}/api/servers");
                var operation = request.SendWebRequest();
                
                // Callback wenn Request fertig
                var coroutine = WaitForRequest(request, operation);
                MultiplayerMod.Instance?.StartCoroutine(coroutine);
            }
            catch (Exception ex)
            {
                MultiplayerMod.Instance?.Log.LogError($"Fehler beim Laden der Serverliste: {ex.Message}");
                UpdateStatus("Error loading servers");
            }
        }
        
        private System.Collections.IEnumerator WaitForRequest(UnityWebRequest request, UnityWebRequestAsyncOperation operation)
        {
            yield return operation;
            
            if (request.Result == UnityWebRequest.Result.Success)
            {
                var json = request.downloadHandler.text;
                ParseServerList(json);
                UpdateStatus($"Loaded {_serverList.Count} servers");
            }
            else
            {
                MultiplayerMod.Instance?.Log.LogError($"Master Server Error: {request.error}");
                UpdateStatus("Failed to connect to master server");
                
                // Demo-Daten für Testing ohne Master Server
                AddDemoServers();
            }
            
            request.Dispose();
        }
        
        private void ParseServerList(string json)
        {
            try
            {
                var response = JsonConvert.DeserializeObject<ServerListResponse>(json);
                if (response?.Servers != null)
                {
                    _serverList = new List<ServerInfoData>(response.Servers);
                    RenderServerList();
                }
            }
            catch (Exception ex)
            {
                MultiplayerMod.Instance?.Log.LogError($"Fehler beim Parsen: {ex.Message}");
            }
        }
        
        private void AddDemoServers()
        {
            // Demo-Server für Testing
            _serverList.Add(new ServerInfoData
            {
                Id = "demo1",
                Name = "SOD Multiplayer #1",
                Ip = "127.0.0.1",
                Port = 27015,
                Players = 1,
                MaxPlayers = 4,
                PasswordProtected = false,
                Map = "Procedural City",
                LastSeen = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
            });
            
            _serverList.Add(new ServerInfoData
            {
                Id = "demo2",
                Name = "Private Server [PW]",
                Ip = "192.168.1.100",
                Port = 27015,
                Players = 2,
                MaxPlayers = 4,
                PasswordProtected = true,
                Map = "Salem",
                LastSeen = DateTimeOffset.UtcNow.ToUnixTimeSeconds()
            });
            
            RenderServerList();
        }
        
        private void RenderServerList()
        {
            ClearServerListEntries();
            
            if (_serverList.Count == 0)
            {
                var noServersLabel = CreateLabel("No servers found", new Vector2(0, -200), 800, 30);
                noServersLabel.transform.SetParent(_serverListContainer.transform);
                var rect = noServersLabel.GetComponent<RectTransform>();
                rect.anchorMin = new Vector2(0.5f, 0.5f);
                rect.anchorMax = new Vector2(0.5f, 0.5f);
                var label = noServersLabel.GetComponent<TextMeshProUGUI>();
                label.alignment = TextAlignmentOptions.Center;
                label.fontSize = 18;
                label.color = new Color(0.7f, 0.7f, 0.7f, 1f);
                return;
            }
            
            float yOffset = -10;
            foreach (var server in _serverList)
            {
                var entry = CreateServerEntry(server, yOffset);
                entry.transform.SetParent(_serverListContainer.transform);
                yOffset -= 55;
            }
            
            // Content height anpassen
            var contentRect = _serverListContainer.GetComponent<RectTransform>();
            contentRect.sizeDelta = new Vector2(0, Mathf.Max(500, _serverList.Count * 55 + 20));
        }
        
        private GameObject CreateServerEntry(ServerInfoData server, float yOffset)
        {
            var entryObj = new GameObject($"Server_{server.Id}");
            var rect = entryObj.AddComponent<RectTransform>();
            rect.anchorMin = new Vector2(0, 1);
            rect.anchorMax = new Vector2(1, 1);
            rect.sizeDelta = new Vector2(-20, 50);
            rect.anchoredPosition = new Vector2(0, yOffset);
            
            // Background
            var image = entryObj.AddComponent<Image>();
            image.color = new Color(0.15f, 0.15f, 0.2f, 0.8f);
            
            // Button für Click
            var button = entryObj.AddComponent<Button>();
            button.onClick.AddListener(() => SelectServer(server));
            
            // Server Name
            var nameObj = new GameObject("Name");
            nameObj.transform.SetParent(entryObj.transform);
            var nameRect = nameObj.AddComponent<RectTransform>();
            nameRect.anchorMin = new Vector2(0, 0);
            nameRect.anchorMax = new Vector2(0.4f, 1);
            nameRect.offsetMin = new Vector2(10, 5);
            nameRect.offsetMax = new Vector2(-10, -5);
            var nameLabel = nameObj.AddComponent<TextMeshProUGUI>();
            nameLabel.text = server.Name;
            nameLabel.fontSize = 16;
            nameLabel.color = Color.white;
            if (server.PasswordProtected)
                nameLabel.text += " 🔒";
            
            // IP:Port
            var ipObj = new GameObject("IP");
            ipObj.transform.SetParent(entryObj.transform);
            var ipRect = ipObj.AddComponent<RectTransform>();
            ipRect.anchorMin = new Vector2(0.4f, 0);
            ipRect.anchorMax = new Vector2(0.65f, 1);
            var ipLabel = ipObj.AddComponent<TextMeshProUGUI>();
            ipLabel.text = $"{server.Ip}:{server.Port}";
            ipLabel.fontSize = 12;
            ipLabel.color = new Color(0.8f, 0.8f, 0.8f, 1f);
            
            // Players
            var playersObj = new GameObject("Players");
            playersObj.transform.SetParent(entryObj.transform);
            var playersRect = playersObj.AddComponent<RectTransform>();
            playersRect.anchorMin = new Vector2(0.65f, 0);
            playersRect.anchorMax = new Vector2(0.85f, 1);
            var playersLabel = playersObj.AddComponent<TextMeshProUGUI>();
            playersLabel.text = $"{server.Players}/{server.MaxPlayers}";
            playersLabel.fontSize = 14;
            playersLabel.color = server.Players >= server.MaxPlayers ? 
                new Color(1f, 0.3f, 0.3f, 1f) : new Color(0.3f, 1f, 0.3f, 1f);
            
            // Map
            var mapObj = new GameObject("Map");
            mapObj.transform.SetParent(entryObj.transform);
            var mapRect = mapObj.AddComponent<RectTransform>();
            mapRect.anchorMin = new Vector2(0.85f, 0);
            mapRect.anchorMax = new Vector2(1f, 1);
            var mapLabel = mapObj.AddComponent<TextMeshProUGUI>();
            mapLabel.text = server.Map;
            mapLabel.fontSize = 12;
            mapLabel.color = new Color(0.7f, 0.7f, 0.7f, 1f);
            mapLabel.alignment = TextAlignmentOptions.Right;
            
            return entryObj;
        }
        
        private void ClearServerListEntries()
        {
            for (int i = _serverListContainer.transform.childCount - 1; i >= 0; i--)
            {
                GameObject.Destroy(_serverListContainer.transform.GetChild(i).gameObject);
            }
        }
        
        private void SelectServer(ServerInfoData server)
        {
            _selectedServer = server;
            MultiplayerMod.Instance?.Log.LogInfo($"Server ausgewählt: {server.Name}");
            
            // Visuelles Feedback
            // (In vollständiger Version Highlight des Eintrags)
        }
        
        private void OnDirectConnectClicked()
        {
            // Direct Connect Dialog (vereinfacht)
            MultiplayerMod.Instance?.ConnectToServer("127.0.0.1", 27015);
        }
        
        /// <summary>
        /// Join Button Click
        /// </summary>
        private void OnJoinClicked()
        {
            if (_selectedServer == null)
            {
                UpdateStatus("Please select a server first");
                return;
            }
            
            MultiplayerMod.Instance?.Log.LogInfo($"Join geklickt: {_selectedServer.Name}");
            
            // Passwort erforderlich?
            if (_selectedServer.PasswordProtected)
            {
                ShowPasswordPanel();
            }
            else
            {
                JoinSelectedServer();
            }
        }
        
        private void ShowPasswordPanel()
        {
            _passwordPanel.SetActive(true);
            _passwordInput?.ActivateInputField();
        }
        
        private void HidePasswordPanel()
        {
            _passwordPanel.SetActive(false);
            _passwordInput.text = "";
        }
        
        private void OnPasswordSubmit()
        {
            var password = _passwordInput.text;
            HidePasswordPanel();
            
            if (!string.IsNullOrEmpty(password))
            {
                JoinSelectedServer(password);
            }
        }
        
        private void OnPasswordCancel()
        {
            HidePasswordPanel();
        }
        
        private void JoinSelectedServer(string password = "")
        {
            if (_selectedServer == null)
                return;
                
            MultiplayerMod.Instance?.Log.LogInfo($"Verbinde mit {_selectedServer.Ip}:{_selectedServer.Port}");
            UpdateStatus($"Connecting to {_selectedServer.Name}...");
            
            MultiplayerMod.Instance?.ConnectToServer(_selectedServer.Ip, _selectedServer.Port, password);
            
            Hide();
        }
        
        /// <summary>
        /// Refresh Button Click
        /// </summary>
        private void OnRefreshClicked()
        {
            MultiplayerMod.Instance?.Log.LogInfo("Refresh geklickt");
            RefreshServerList();
        }
        
        /// <summary>
        /// Close Button Click
        /// </summary>
        private void OnCloseClicked()
        {
            Hide();
        }
        
        private void UpdateStatus(string message)
        {
            var statusLabel = _mainPanel?.transform.Find("StatusLabel")?.GetComponent<TextMeshProUGUI>();
            if (statusLabel != null)
            {
                statusLabel.text = $"Status: {message}";
            }
        }
    }
    
    /// <summary>
    /// Server Info Datenklasse für UI
    /// </summary>
    public class ServerInfoData
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("ip")]
        public string Ip { get; set; }
        
        [JsonProperty("port")]
        public int Port { get; set; }
        
        [JsonProperty("players")]
        public int Players { get; set; }
        
        [JsonProperty("maxPlayers")]
        public int MaxPlayers { get; set; }
        
        [JsonProperty("passwordProtected")]
        public bool PasswordProtected { get; set; }
        
        [JsonProperty("map")]
        public string Map { get; set; }
        
        [JsonProperty("lastSeen")]
        public long LastSeen { get; set; }
    }
    
    /// <summary>
    /// Server List Response vom Master Server
    /// </summary>
    public class ServerListResponse
    {
        [JsonProperty("servers")]
        public ServerInfoData[] Servers { get; set; }
        
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
    }
}
