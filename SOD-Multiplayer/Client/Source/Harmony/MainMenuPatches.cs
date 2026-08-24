using HarmonyLib;
using UnityEngine;
using System.Reflection;

namespace SOD_Multiplayer.Harmony
{
    /// <summary>
    /// Patches für das Hauptmenü von Shadow of Doubt
    /// Initialisiert die Multiplayer-UI wenn das Spiel bereit ist
    /// </summary>
    [HarmonyPatch]
    public static class MainMenuPatches
    {
        private static bool _uiInitialized = false;
        
        /// <summary>
        /// Patch: Time.get_time wird verwendet um zu erkennen wann das Spiel läuft
        /// Dies ist ein zuverlässiger Weg um zu wissen wann UI erstellt werden kann
        /// </summary>
        [HarmonyPatch(typeof(Time), nameof(Time.time))]
        [HarmonyPostfix]
        public static void Time_Postfix()
        {
            if (_uiInitialized || MultiplayerMod.Instance?.ServerBrowser == null)
                return;
            
            // UI einmalig initialisieren
            _uiInitialized = true;
            MultiplayerMod.Instance.Log.LogInfo("Game is ready, initializing ServerBrowserUI");
            
            // UI wird durch ServerBrowserUI selbst erstellt bei erstem Aufruf
            // Wir müssen hier nichts tun außer das Flag zu setzen
        }
        
        /// <summary>
        /// Alternative: Patch auf Scene Loading
        /// </summary>
        [HarmonyPatch(typeof(UnityEngine.SceneManagement.SceneManager), "LoadScene", typeof(string))]
        [HarmonyPostfix]
        public static void SceneManager_LoadScene_Postfix(string sceneName)
        {
            if (sceneName.Contains("Menu") || sceneName.Contains("Main"))
            {
                MultiplayerMod.Instance?.Log.LogInfo($"Menu scene loaded: {sceneName}");
            }
        }
    }
    
    /// <summary>
    /// Patches für SessionData - nur Platzhalter bis echte Klasse gefunden
    /// </summary>
    public static class SessionDataPatches
    {
        // TODO: Echte SessionData-Klasse aus SOD-Assembly ermitteln
        // Diese Patches werden aktiviert sobald die korrekte Klasse bekannt ist
    }
    
    /// <summary>
    /// Patches für Player/Actor-Klassen
    /// </summary>
    public static class PlayerPatches
    {
        // TODO: Echte Player/Actor-Klasse aus SOD-Assembly ermitteln
    }
}
