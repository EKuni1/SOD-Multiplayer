using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SOD_Multiplayer.UI
{
    /// <summary>
    /// Server-Browser UI für die Multiplayer-Mod
    /// Zeigt verfügbare Server und ermöglicht Verbindung
    /// </summary>
    public class ServerBrowserUI
    {
        private GameObject _mainPanel;
        private bool _isVisible;
        
        /// <summary>
        /// Ist das UI sichtbar?
        /// </summary>
        public bool IsVisible => _isVisible;
        
        public ServerBrowserUI()
        {
            // UI wird bei Bedarf erstellt
            // In Phase 4: Integration mit Master-Server für Serverliste
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
            
            // Serverliste laden (Phase 4)
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
            rectTransform.sizeDelta = new Vector2(800, 600);
            rectTransform.anchoredPosition = Vector2.zero;
            
            // Background
            var image = _mainPanel.AddComponent<Image>();
            image.color = new Color(0.1f, 0.1f, 0.1f, 0.95f);
            
            // Titel
            var titleObj = new GameObject("Title");
            titleObj.transform.SetParent(_mainPanel.transform);
            var titleText = titleObj.AddComponent<TextMeshProUGUI>();
            titleText.text = "MULTIPLAYER SERVER BROWSER";
            titleText.fontSize = 24;
            titleText.alignment = TextAlignmentOptions.Center;
            titleText.color = Color.white;
            
            var titleRect = titleObj.GetComponent<RectTransform>();
            titleRect.anchorMin = new Vector2(0, 1);
            titleRect.anchorMax = new Vector2(1, 1);
            titleRect.sizeDelta = new Vector2(0, 50);
            titleRect.anchoredPosition = new Vector2(0, -25);
            
            // Refresh Button
            var refreshBtn = CreateButton("Refresh", new Vector2(-350, -75), 150, 40, OnRefreshClicked);
            
            // Join Button
            var joinBtn = CreateButton("Join Server", new Vector2(-150, -75), 150, 40, OnJoinClicked);
            
            // Close Button
            var closeBtn = CreateButton("Close", new Vector2(350, -75), 150, 40, OnCloseClicked);
            
            // Server List Container
            var listContainer = new GameObject("ServerList");
            listContainer.transform.SetParent(_mainPanel.transform);
            var listRect = listContainer.AddComponent<RectTransform>();
            listRect.anchorMin = new Vector2(0, 0);
            listRect.anchorMax = new Vector2(1, 1);
            listRect.sizeDelta = new Vector2(-40, -160);
            listRect.anchoredPosition = new Vector2(0, -80);
            
            // Scroll View würde hier hinzugefügt werden (Phase 4)
            
            MultiplayerMod.Instance?.Log.LogInfo("Server-Browser UI erstellt");
        }
        
        /// <summary>
        /// Helper: Button erstellen
        /// </summary>
        private GameObject CreateButton(string text, Vector2 position, int width, int height, System.Action onClick)
        {
            var btnObj = new GameObject(text + "Button");
            btnObj.transform.SetParent(_mainPanel.transform);
            
            var rect = btnObj.AddComponent<RectTransform>();
            rect.anchorMin = new Vector2(0.5f, 0.5f);
            rect.anchorMax = new Vector2(0.5f, 0.5f);
            rect.sizeDelta = new Vector2(width, height);
            rect.anchoredPosition = position;
            
            var image = btnObj.AddComponent<Image>();
            image.color = new Color(0.2f, 0.4f, 0.6f, 1f);
            
            var button = btnObj.AddComponent<Button>();
            button.onClick.AddListener(() => onClick?.Invoke());
            
            var btnText = new GameObject("Text");
            btnText.transform.SetParent(btnObj.transform);
            var textComp = btnText.AddComponent<TextMeshProUGUI>();
            textComp.text = text;
            textComp.fontSize = 16;
            textComp.alignment = TextAlignmentOptions.Center;
            textComp.color = Color.white;
            
            var textRect = btnText.GetComponent<RectTransform>();
            textRect.anchorMin = Vector2.zero;
            textRect.anchorMax = Vector2.one;
            textRect.sizeDelta = Vector2.zero;
            textRect.anchoredPosition = Vector2.zero;
            
            return btnObj;
        }
        
        /// <summary>
        /// Serverliste aktualisieren
        /// </summary>
        private void RefreshServerList()
        {
            MultiplayerMod.Instance?.Log.LogInfo("Serverliste wird aktualisiert...");
            
            // Phase 4: Master-Server API aufrufen
            // GET http://master-server:27016/api/servers
            
            // Placeholder: Direkte Verbindung für Testing
            // In Phase 4 wird dies durch echte Serverliste ersetzt
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
        /// Join Button Click
        /// </summary>
        private void OnJoinClicked()
        {
            MultiplayerMod.Instance?.Log.LogInfo("Join geklickt");
            
            // Phase 2: Ausgewählten Server beitreten
            // Aktuell nur Placeholder
            MultiplayerMod.Instance?.ConnectToServer("127.0.0.1", 27015);
        }
        
        /// <summary>
        /// Close Button Click
        /// </summary>
        private void OnCloseClicked()
        {
            Hide();
        }
    }
}
