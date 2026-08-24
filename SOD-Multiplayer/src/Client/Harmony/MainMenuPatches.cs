using HarmonyLib;
using UnityEngine;
using SOD.Multiplayer.Client.UI;

namespace SOD.Multiplayer.Client.Harmony
{
    [HarmonyPatch(typeof(MainMenuController), "Awake")]
    public static class MainMenuPatches
    {
        private static GameObject _uiObject;

        [HarmonyPostfix]
        private static void MainMenu_Awake_Postfix()
        {
            if (ServerBrowserUI.Instance == null)
            {
                _uiObject = new GameObject("SOD Multiplayer Browser");
                UnityEngine.Object.DontDestroyOnLoad(_uiObject);
                var browser = _uiObject.AddComponent<ServerBrowserUI>();
                browser.Initialize();
                browser.Show();
                Debug.Log("[SOD Multiplayer] Separate server browser opened from main menu.");
                return;
            }

            ServerBrowserUI.Instance.Show();
        }
    }
}
