using BepInEx;
using BepInEx.Configuration;
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
        public static bool IsHost { get; set; }
        public static float SynchronizedGameTime { get; set; }
        public HarmonyLib.Harmony HarmonyInstance { get; private set; }
        
        public override void Load()
        {
            Instance = this;
            var masterServerSetting = Config.Bind(
                "Network",
                "MasterServerUrl",
                "http://127.0.0.1:5000",
                "Adresse und Port des Master Servers.");
            MasterServerUrl = masterServerSetting.Value.TrimEnd('/');

            ClassInjector.RegisterTypeInIl2Cpp<ServerBrowserUI>();
            ClassInjector.RegisterTypeInIl2Cpp<ServerSelectData>();
            
            Log.LogInfo("Shadows of Doubt Multiplayer Mod loaded!");
            Log.LogInfo($"Master Server: {MasterServerUrl}");
            
            // Initialize Harmony
            HarmonyInstance = new HarmonyLib.Harmony("com.sod.multiplayer");
            HarmonyInstance.PatchAll();
            
            Log.LogInfo("Harmony patches applied successfully.");
        }
    }
}
