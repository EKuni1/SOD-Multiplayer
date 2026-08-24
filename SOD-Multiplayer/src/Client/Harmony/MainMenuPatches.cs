using System;
using HarmonyLib;
using UnityEngine;
using SOD.Multiplayer.Client.UI;
using SOD.Multiplayer.Client.Network;

namespace SOD.Multiplayer.Client.Harmony
{
    // Patch for the main menu to add Multiplayer button and initialize UI
    [HarmonyPatch]
    public class MainMenuPatches
    {
        private static bool _uiInitialized = false;
        
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
