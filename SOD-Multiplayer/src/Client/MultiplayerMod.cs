using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
using UnityEngine;
using SOD.Multiplayer.Client.UI;

namespace SOD.Multiplayer.Client
{
    [BepInPlugin("com.sod.multiplayer", "Shadows of Doubt Multiplayer", "1.0.0")]
    public class MultiplayerMod : BasePlugin
    {
        public static MultiplayerMod Instance { get; private set; }
        public static string MasterServerUrl { get; private set; }
        public static string MasterServerAuthToken { get; private set; }
        public static bool IsHost { get; set; }
        public static float SynchronizedGameTime { get; set; }
        public static int SynchronizedLeapYearCycle { get; set; }
        public static float SynchronizedRain { get; set; }
        public static float SynchronizedWind { get; set; }
        public static float SynchronizedSnow { get; set; }
        public static float SynchronizedLightning { get; set; }
        public static float SynchronizedFog { get; set; }
        public HarmonyLib.Harmony HarmonyInstance { get; private set; }
        
        public override void Load()
        {
            Instance = this;
            MasterServerUrl = Config.Bind(
                "Master Server",
                "Url",
                "http://192.168.178.76:5000",
                "URL des Master Servers für die Serverliste.").Value.TrimEnd('/');
            MasterServerAuthToken = Config.Bind(
                "Master Server",
                "AuthToken",
                "change-this-token",
                "Authentifizierungs-Token des Master Servers.").Value;
            
            Log.LogInfo("===========================================");
            Log.LogInfo("Shadows of Doubt Multiplayer Mod loaded!");
            Log.LogInfo("Version: 1.0.0");
            Log.LogInfo("Controls: Press CTRL+M to open Server Browser");
            Log.LogInfo("===========================================");
            
            ClassInjector.RegisterTypeInIl2Cpp<ServerBrowserUI>();
            ClassInjector.RegisterTypeInIl2Cpp<ServerSelectData>();
            ClassInjector.RegisterTypeInIl2Cpp<MultiplayerRuntime>();

            var runtimeObject = new GameObject("SOD Multiplayer Runtime");
            UnityEngine.Object.DontDestroyOnLoad(runtimeObject);
            runtimeObject.AddComponent<MultiplayerRuntime>();

            // Initialize Harmony only for gameplay patches.
            HarmonyInstance = new HarmonyLib.Harmony("com.sod.multiplayer");
            
            try
            {
                HarmonyInstance.PatchAll();
                Log.LogInfo("Harmony patches applied successfully.");
            }
            catch (System.Exception ex)
            {
                Log.LogError($"Failed to apply Harmony patches: {ex.Message}");
                Log.LogError($"Stack trace: {ex.StackTrace}");
            }
            
            Log.LogInfo("Multiplayer Mod initialization complete.");
            Log.LogInfo("The UI will be initialized when the game's main menu loads.");
        }
    }
}
