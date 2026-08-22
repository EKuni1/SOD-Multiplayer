using System;
using System.Reflection;
using HarmonyLib;
using Il2CppDummyDll;

/// <summary>
/// SOD Multiplayer Mod - Harmony Patches
/// Fügt Multiplayer-Unterstützung in das Basisspiel ein
/// </summary>
[Token(Token = "0x2000604")]
public class MultiplayerPatches
{
    [Token(Token = "0x4002550")]
    [FieldOffset(Offset = "0x10")]
    private static readonly string HarmonyID = "com.sod.multiplayer.mod";
    
    [Token(Token = "0x6002050")]
    [Address(RVA = "0xB04000", Offset = "0xB03000", VA = "0x180B04000")]
    public static void ApplyAllPatches()
    {
        var harmony = new Harmony(HarmonyID);
        
        try
        {
            // MainMenuController patchen für Multiplayer-Button
            harmony.Patch(
                typeof(MainMenuController).GetMethod("Start", BindingFlags.NonPublic | BindingFlags.Instance),
                postfix: new HarmonyMethod(typeof(MultiplayerPatches).GetMethod(nameof(MainMenuStartPostfix)))
            );
            
            // Game Initialisierung patchen
            harmony.Patch(
                typeof(Game).GetMethod("Awake", BindingFlags.NonPublic | BindingFlags.Instance),
                postfix: new HarmonyMethod(typeof(MultiplayerPatches).GetMethod(nameof(GameAwakePostfix)))
            );
            
            // SessionData patchen für Multiplayer-Sync
            harmony.Patch(
                typeof(SessionData).GetMethod("Awake", BindingFlags.NonPublic | BindingFlags.Instance),
                prefix: new HarmonyMethod(typeof(MultiplayerPatches).GetMethod(nameof(SessionDataAwakePrefix))),
                postfix: new HarmonyMethod(typeof(MultiplayerPatches).GetMethod(nameof(SessionDataAwakePostfix)))
            );
            
            UnityEngine.Debug.Log($"[SOD Multiplayer] Alle Harmony-Patches erfolgreich angewendet");
        }
        catch (Exception ex)
        {
            UnityEngine.Debug.LogError($"[SOD Multiplayer] Fehler beim Anwenden der Patches: {ex.Message}");
        }
    }
    
    // Token: 0x02000605 RID: 1541
    [Token(Token = "0x2000605")]
    public class MainMenuPatch
    {
        // Token: 0x06002051 RID: 8273
        [Token(Token = "0x6002051")]
        [Address(RVA = "0xB04100", Offset = "0xB03100", VA = "0x180B04100")]
        public static void MainMenuStartPostfix(MainMenuController __instance)
        {
            // Multiplayer-Button zum Hauptmenü hinzufügen
            try
            {
                var multiplayerButton = CreateMultiplayerButton(__instance);
                if (multiplayerButton != null)
                {
                    UnityEngine.Debug.Log("[SOD Multiplayer] Multiplayer-Button zum Menü hinzugefügt");
                }
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError($"[SOD Multiplayer] Fehler beim Erstellen des Multiplayer-Buttons: {ex.Message}");
            }
        }
        
        [Token(Token = "0x6002052")]
        [Address(RVA = "0xB04200", Offset = "0xB03200", VA = "0x180B04200")]
        private static UnityEngine.GameObject CreateMultiplayerButton(MainMenuController menu)
        {
            // Suche nach existierenden Buttons im Menü
            var buttons = menu.GetComponentsInChildren<UnityEngine.UI.Button>(true);
            
            if (buttons.Length == 0)
                return null;
            
            // Kopiere einen existierenden Button als Vorlage
            var template = buttons[0].gameObject;
            var multiplayerButton = UnityEngine.Object.Instantiate(template, template.transform.parent);
            multiplayerButton.name = "MultiplayerButton";
            
            var textComponent = multiplayerButton.GetComponentInChildren<UnityEngine.UI.Text>();
            if (textComponent != null)
                textComponent.text = "MULTIPLAYER";
            
            var buttonComponent = multiplayerButton.GetComponent<UnityEngine.UI.Button>();
            if (buttonComponent != null)
            {
                // OnClick Event hinzufügen
                var onClickEvent = new UnityEngine.UI.Button.ButtonClickedEvent();
                onClickEvent.AddListener(() => OpenServerBrowser());
                buttonComponent.onClick = onClickEvent;
            }
            
            return multiplayerButton;
        }
        
        [Token(Token = "0x6002053")]
        [Address(RVA = "0xB04300", Offset = "0xB03300", VA = "0x180B04300")]
        private static void OpenServerBrowser()
        {
            var manager = MultiplayerManager.Instance;
            if (manager != null)
            {
                // Server Browser UI anzeigen
                var browser = UnityEngine.Object.FindObjectOfType<ServerBrowserUI>();
                if (browser != null)
                {
                    browser.gameObject.SetActive(true);
                    browser.RefreshServerList();
                }
                else
                {
                    UnityEngine.Debug.LogError("[SOD Multiplayer] ServerBrowserUI nicht gefunden!");
                }
            }
        }
    }
    
    // Token: 0x02000606 RID: 1542
    [Token(Token = "0x2000606")]
    public class GamePatch
    {
        // Token: 0x06002054 RID: 8276
        [Token(Token = "0x6002054")]
        [Address(RVA = "0xB04400", Offset = "0xB03400", VA = "0x180B04400")]
        public static void GameAwakePostfix(Game __instance)
        {
            // Multiplayer Manager initialisieren wenn das Spiel startet
            try
            {
                var manager = MultiplayerManager.Instance;
                UnityEngine.Debug.Log("[SOD Multiplayer] MultiplayerManager durch Game-Patch initialisiert");
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.LogError($"[SOD Multiplayer] Fehler in GameAwakePostfix: {ex.Message}");
            }
        }
    }
    
    // Token: 0x02000607 RID: 1543
    [Token(Token = "0x2000607")]
    public class SessionDataPatch
    {
        // Token: 0x06002055 RID: 8277
        [Token(Token = "0x6002055")]
        [Address(RVA = "0xB04500", Offset = "0xB03500", VA = "0x180B04500")]
        public static bool SessionDataAwakePrefix(SessionData __instance)
        {
            // Prüfen ob wir im Multiplayer-Modus sind
            var manager = MultiplayerManager.Instance;
            if (manager != null && manager.IsConnected())
            {
                // Multiplayer-Session wird geladen - bestimmte Initialisierungen überspringen
                UnityEngine.Debug.Log("[SOD Multiplayer] SessionData wird im Multiplayer-Modus initialisiert");
                // Return false um originale Methode zu überspringen (wenn nötig)
            }
            
            return true; // Originale Methode ausführen
        }
        
        // Token: 0x06002056 RID: 8278
        [Token(Token = "0x6002056")]
        [Address(RVA = "0xB04600", Offset = "0xB03600", VA = "0x180B04600")]
        public static void SessionDataAwakePostfix(SessionData __instance)
        {
            // Nach der Initialisierung Multiplayer-spezifische Einstellungen vornehmen
            var manager = MultiplayerManager.Instance;
            if (manager != null && manager.IsConnected())
            {
                // Lobby-ID in SessionData speichern
                var lobbyID = manager.GetCurrentLobbyID();
                if (lobbyID.IsValid)
                {
                    UnityEngine.Debug.Log($"[SOD Multiplayer] Session mit Lobby {lobbyID} verknüpft");
                }
            }
        }
    }
    
    [Token(Token = "0x6002057")]
    [Address(RVA = "0xB04700", Offset = "0xB03700", VA = "0x180B04700")]
    public static void RemoveAllPatches()
    {
        var harmony = new Harmony(HarmonyID);
        harmony.UnpatchSelf();
        UnityEngine.Debug.Log("[SOD Multiplayer] Alle Patches entfernt");
    }
}
