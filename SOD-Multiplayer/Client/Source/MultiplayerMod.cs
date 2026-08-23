using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;
using System;
using System.Reflection;
using SOD_Multiplayer.Network;
using SOD_Multiplayer.UI;

namespace SOD_Multiplayer
{
    /// <summary>
    /// Hauptklasse der Multiplayer-Mod für Shadow of Doubt
    /// Wird von BepInEx geladen und initialisiert
    /// </summary>
    [BepInPlugin("com.sod.multiplayer", "Shadow of Doubt Multiplayer", "0.1.0")]
    [BepInProcess("Shadow Of Doubt.exe")]
    public class MultiplayerMod : BasePlugin
    {
        public static MultiplayerMod Instance { get; private set; }
        
        /// <summary>
        /// Netzwerk-Client für Verbindung zum Dedicated Server
        /// </summary>
        public NetworkClient NetworkClient { get; private set; }
        
        /// <summary>
        /// Server-Browser UI
        /// </summary>
        public ServerBrowserUI ServerBrowser { get; private set; }
        
        /// <summary>
        /// Ist aktuell mit einem Server verbunden?
        /// </summary>
        public bool IsConnected => NetworkClient?.IsConnected ?? false;
        
        /// <summary>
        /// Aktuelle Server-IP/Port
        /// </summary>
        public string CurrentServer { get; private set; }

        public override void Load()
        {
            Instance = this;
            
            this.Log.LogInfo("Shadow of Doubt Multiplayer Mod geladen!");
            this.Log.LogInfo("Version: 0.1.0 - Phase 1: Netzwerkverbindung");
            
            // Harmony Patches anwenden
            var harmony = new Harmony("com.sod.multiplayer");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            
            this.Log.LogInfo("Harmony Patches angewendet");
            
            // Netzwerk-Client initialisieren
            NetworkClient = new NetworkClient();
            
            // UI initialisieren (wird bei Bedarf angezeigt)
            ServerBrowser = new ServerBrowserUI();
            
            this.Log.LogInfo("Multiplayer-Mod initialisiert");
        }

        /// <summary>
        /// Verbindung zu einem Dedicated Server herstellen
        /// </summary>
        public void ConnectToServer(string ip, int port)
        {
            if (NetworkClient == null)
            {
                this.Log.LogError("NetworkClient nicht initialisiert!");
                return;
            }
            
            CurrentServer = $"{ip}:{port}";
            this.Log.LogInfo($"Verbinde zu Server: {CurrentServer}");
            
            NetworkClient.Connect(ip, port);
        }
        
        /// <summary>
        /// Verbindung zum aktuellen Server trennen
        /// </summary>
        public void Disconnect()
        {
            if (NetworkClient != null)
            {
                NetworkClient.Disconnect();
                CurrentServer = null;
            }
        }
        
        /// <summary>
        /// Prüft ob eine bestimmte Klasse/Methode im Spiel existiert
        /// HILFSMETHODE FÜR DIE ENTWICKLUNG
        /// </summary>
        public static bool TryGetGameClass(string className, out Type type)
        {
            type = null;
            try
            {
                // Versuche Assembly zu finden
                var assemblies = AppDomain.CurrentDomain.GetAssemblies();
                foreach (var asm in assemblies)
                {
                    type = asm.GetType(className, false);
                    if (type != null)
                        return true;
                }
            }
            catch (Exception ex)
            {
                Instance?.Log.LogWarning($"Fehler beim Suchen von {className}: {ex.Message}");
            }
            return false;
        }
    }
}
