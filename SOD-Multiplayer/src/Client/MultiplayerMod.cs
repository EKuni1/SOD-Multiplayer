using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using UnityEngine;

namespace SOD.Multiplayer.Client
{
    [BepInPlugin("com.sod.multiplayer", "Shadows of Doubt Multiplayer", "1.0.0")]
    public class MultiplayerMod : BasePlugin
    {
        public static MultiplayerMod Instance { get; private set; }
        public static string MasterServerUrl { get; private set; }
        public HarmonyLib.Harmony HarmonyInstance { get; private set; }
        
        public override void Load()
        {
            Instance = this;
            MasterServerUrl = Config.Bind(
                "Master Server",
                "Url",
                "http://localhost:27016",
                "URL des Master Servers für die Serverliste.").Value.TrimEnd('/');
            
            Log.LogInfo("Shadows of Doubt Multiplayer Mod loaded!");
            Log.LogInfo($"Master Server URL: {MasterServerUrl}");
            
            // Initialize Harmony
            HarmonyInstance = new HarmonyLib.Harmony("com.sod.multiplayer");
            HarmonyInstance.PatchAll();
            
            Log.LogInfo("Harmony patches applied successfully.");
        }
    }
}
