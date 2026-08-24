using BepInEx;
using HarmonyLib;
using UnityEngine;
using System.Reflection;

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
            
            Log.LogInfo("===========================================");
            Log.LogInfo("Shadows of Doubt Multiplayer Mod loaded!");
            Log.LogInfo("Version: 1.0.0");
            Log.LogInfo("Controls: Press CTRL+M to open Server Browser");
            Log.LogInfo("===========================================");
            
            // Initialize Harmony
            HarmonyInstance = new Harmony("com.sod.multiplayer");
            
            try
            {
                HarmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
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
