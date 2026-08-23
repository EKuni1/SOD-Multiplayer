using HarmonyLib;
using UnityEngine;
using System.Reflection;

namespace SOD_Multiplayer.Harmony
{
    /// <summary>
    /// Patches für das Hauptmenü von Shadow of Doubt
    /// Fügt "MULTIPLAYER" Button hinzu
    /// </summary>
    [HarmonyPatch]
    public static class MainMenuPatches
    {
        private static GameObject _multiplayerButton;
        
        /// <summary>
        /// Patch: Wenn Hauptmenü erstellt wird, füge Multiplayer-Button hinzu
        /// TODO: Korrekte Klasse aus SOD-Assembly ermitteln
        /// </summary>
        [HarmonyPatch(typeof(UnityEngine.Object), nameof(UnityEngine.Object.FindObjectOfType))]
        [HarmonyPostfix]
        public static void FindObjectOfType_Postfix(System.Type type, UnityEngine.Object __result)
        {
            // Placeholder: Hier muss die korrekte MainMenu-Klasse aus SOD-Assembly verwendet werden
            // Aktuell nur als Beispiel
            
            if (_multiplayerButton != null || !MultiplayerMod.Instance?.IsConnected ?? true)
                return;
                
            // Im echten Spiel: Canvas finden und Button hinzufügen
            // Siehe ServerBrowserUI.cs für UI-Erstellung
        }
        
        /// <summary>
        /// Alternative: Patch auf eine spezifische Menu-Klasse
        /// HINWEIS: Diese Klasse muss aus der SOD-Assembly ermittelt werden
        /// </summary>
        /*
        [HarmonyPatch(typeof(ModdedMenu), "Awake")]  // Beispiel - Klasse anpassen!
        [HarmonyPostfix]
        public static void ModdedMenu_Awake_Postfix()
        {
            MultiplayerMod.Instance?.Log.LogInfo("MainMenu erkannt, Multiplayer-Button wird hinzugefügt");
            
            // Button erstellen
            CreateMultiplayerButton();
        }
        */
        
        /// <summary>
        /// Multiplayer-Button im Hauptmenü erstellen
        /// </summary>
        public static void CreateMultiplayerButton()
        {
            if (_multiplayerButton != null)
                return;
                
            // Canvas suchen
            var canvas = Object.FindObjectOfType<Canvas>();
            if (canvas == null)
            {
                MultiplayerMod.Instance?.Log.LogWarning("Kein Canvas gefunden!");
                return;
            }
            
            // Button erstellen
            _multiplayerButton = new GameObject("MultiplayerButton");
            _multiplayerButton.transform.SetParent(canvas.transform, false);
            
            var rectTransform = _multiplayerButton.AddComponent<RectTransform>();
            rectTransform.sizeDelta = new Vector2(300, 80);
            rectTransform.anchoredPosition = new Vector2(0, -150); // Unter dem Singleplayer-Button
            
            var image = _multiplayerButton.AddComponent<UnityEngine.UI.Image>();
            image.color = new Color(0.3f, 0.5f, 0.8f, 1f);
            
            var button = _multiplayerButton.AddComponent<UnityEngine.UI.Button>();
            button.onClick.AddListener(OnMultiplayerClicked);
            
            // Text
            var textObj = new GameObject("Text");
            textObj.transform.SetParent(_multiplayerButton.transform);
            var textComp = textObj.AddComponent<TextMeshProUGUI>();
            textComp.text = "MULTIPLAYER";
            textComp.fontSize = 24;
            textComp.alignment = TMPro.TextAlignmentOptions.Center;
            textComp.color = Color.white;
            
            var textRect = textObj.GetComponent<RectTransform>();
            textRect.anchorMin = Vector2.zero;
            textRect.anchorMax = Vector2.one;
            textRect.sizeDelta = Vector2.zero;
            
            MultiplayerMod.Instance?.Log.LogInfo("Multiplayer-Button erstellt");
        }
        
        /// <summary>
        /// Click-Handler für Multiplayer-Button
        /// </summary>
        private static void OnMultiplayerClicked()
        {
            MultiplayerMod.Instance?.Log.LogInfo("Multiplayer-Button geklickt!");
            
            // Server-Browser öffnen
            if (MultiplayerMod.Instance?.ServerBrowser != null)
            {
                MultiplayerMod.Instance.ServerBrowser.Show();
            }
        }
    }
    
    /// <summary>
    /// Patches für SessionData
    /// Ermöglicht Synchronisation von Spielzuständen
    /// </summary>
    [HarmonyPatch(typeof(SessionData))]
    public static class SessionDataPatches
    {
        /// <summary>
        /// Patch: SetGameTime - Synchronisiert Zeit mit Server
        /// </summary>
        [HarmonyPatch(nameof(SessionData.SetGameTime), typeof(float), typeof(int))]
        [HarmonyPrefix]
        public static bool SetGameTime_Prefix(ref float newGameTime, ref int newLeapYearCycle)
        {
            // Wenn im Multiplayer: Zeit vom Server holen, nicht lokal setzen
            if (MultiplayerMod.Instance?.IsConnected ?? false)
            {
                MultiplayerMod.Instance.Log.LogDebug($"SetGameTime gepatcht: {newGameTime}");
                // TODO: Zeit vom Server synchronisieren
                // return false verhindert die originale Methode
            }
            
            return true; // Original-Methode ausführen
        }
        
        /// <summary>
        /// Patch: SetWeather - Synchronisiert Wetter mit Server
        /// </summary>
        [HarmonyPatch(nameof(SessionData.SetWeather))]
        [HarmonyPrefix]
        public static bool SetWeather_Prefix(
            ref float newRain, ref float newWind, ref float newSnow, 
            ref float newLightning, ref float newFog)
        {
            if (MultiplayerMod.Instance?.IsConnected ?? false)
            {
                MultiplayerMod.Instance.Log.LogDebug($"SetWeather gepatcht: Rain={newRain}, Wind={newWind}");
                // TODO: Wetter vom Server synchronisieren
            }
            
            return true;
        }
        
        /// <summary>
        /// Patch: SetEnablePause - Verhindert Pause im Multiplayer
        /// </summary>
        [HarmonyPatch(nameof(SessionData.SetEnablePause))]
        [HarmonyPrefix]
        public static bool SetEnablePause_Prefix(ref bool val)
        {
            if (MultiplayerMod.Instance?.IsConnected ?? false)
            {
                // Im Multiplayer kann nicht gepaused werden (oder nur Host)
                MultiplayerMod.Instance.Log.LogDebug("Pause im Multiplayer blockiert");
                return false; // Blockiere Pause
            }
            
            return true;
        }
    }
    
    /// <summary>
    /// Patches für Player/Actor-Klassen
    /// Für Spieler-Synchronisation
    /// </summary>
    [HarmonyPatch]
    public static class PlayerPatches
    {
        /// <summary>
        /// Patch: Player Movement - Position an Server senden
        /// TODO: Korrekte Player-Klasse aus SOD-Assembly ermitteln
        /// </summary>
        /*
        [HarmonyPatch(typeof(Actor), "Update")]
        [HarmonyPostfix]
        public static void Actor_Update_Postfix(Actor __instance)
        {
            if (!MultiplayerMod.Instance?.IsConnected ?? true)
                return;
                
            // Position an Server senden (Phase 2)
            // Nur für lokalen Spieler
            if (__instance.IsLocalPlayer)
            {
                var pos = __instance.transform.position;
                var rot = __instance.transform.rotation.eulerAngles.y;
                
                var packet = new PlayerPositionPacket
                {
                    PlayerId = 0, // Lokaler Spieler ID
                    X = pos.x,
                    Y = pos.y,
                    Z = pos.z,
                    RotationY = rot
                };
                
                MultiplayerMod.Instance.NetworkClient.SendPacket(packet);
            }
        }
        */
    }
}
