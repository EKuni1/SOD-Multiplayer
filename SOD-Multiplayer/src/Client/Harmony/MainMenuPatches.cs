using HarmonyLib;
using UnityEngine;
using SOD.Multiplayer.Client.UI;

namespace SOD.Multiplayer.Client.Harmony
{
    // Patch for the main menu to add Multiplayer button and initialize UI
    [HarmonyPatch]
    public class MainMenuPatches
    {
        private static bool _uiInitialized = false;
        
        // Find a reliable main menu method to patch
        // You may need to adjust this based on actual game decompilation
        [HarmonyPostfix]
        [HarmonyPatch(typeof(UnityEngine.Object), nameof(UnityEngine.Object.FindObjectOfType))]
        public static void FindObjectOfType_Postfix(System.Type type, UnityEngine.Object __result)
        {
            // This is a fallback - we'll use a more direct approach below
        }
        
        // Alternative: Patch any Canvas creation in the game
        [HarmonyPostfix]
        [HarmonyPatch(typeof(Canvas), nameof(Canvas.Awake))]
        public static void Canvas_Awake_Postfix(Canvas __instance)
        {
            if (_uiInitialized) return;
            
            // Check if this looks like a main menu canvas
            if (__instance.gameObject.name.Contains("Menu") || __instance.gameObject.name.Contains("UI"))
            {
                InitializeMultiplayerUI();
                _uiInitialized = true;
            }
        }
        
        // More reliable: Just initialize on first update
        [HarmonyPrefix]
        [HarmonyPatch(typeof(Time), nameof(Time.time), MethodType.Getter)]
        public static void Time_get_time_Prefix()
        {
            if (!_uiInitialized && Application.isFocused)
            {
                InitializeMultiplayerUI();
                _uiInitialized = true;
            }
        }
        
        private static void InitializeMultiplayerUI()
        {
            Debug.Log("[SOD Multiplayer] Initializing Multiplayer UI...");
            
            // Create a GameObject to hold our UI component
            var uiObject = new GameObject("SOD_Multiplayer_UI");
            Object.DontDestroyOnLoad(uiObject);
            
            // Add Canvas components
            var canvas = uiObject.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.sortingOrder = 1000;
            
            uiObject.AddComponent<CanvasScaler>();
            uiObject.AddComponent<GraphicRaycaster>();
            
            // Add the ServerBrowserUI component and initialize it
            var uiComponent = uiObject.AddComponent<ServerBrowserUI>();
            uiComponent.Initialize();
            uiComponent.ToggleVisibility(false); // Start hidden
            
            Debug.Log("[SOD Multiplayer] Multiplayer UI initialized. Press Ctrl+M to toggle.");
        }
    }
}
