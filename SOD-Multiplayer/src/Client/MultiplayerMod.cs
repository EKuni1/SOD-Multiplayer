using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace SOD.Multiplayer.Client
{
    [BepInPlugin("com.sod.multiplayer", "Shadows of Doubt Multiplayer", "1.0.0")]
    public class MultiplayerMod : BasePlugin
    {
        public static MultiplayerMod Instance { get; private set; }
        public Harmony HarmonyInstance { get; private set; }
        
        public override void Load()
        {
            Instance = this;
            
            Log.LogInfo("Shadows of Doubt Multiplayer Mod loaded!");
            
            // Initialize Harmony
            HarmonyInstance = new Harmony("com.sod.multiplayer");
            HarmonyInstance.PatchAll();
            
            Log.LogInfo("Harmony patches applied successfully.");
        }
    }
}
