using System;
using HarmonyLib;
using Il2CppInterop.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using SOD.Multiplayer.Client.UI;
using SOD.Multiplayer.Client.Network;

namespace SOD.Multiplayer.Client.Harmony
{
    public static class MainMenuPatches
    {
        private static GameObject _uiObject;
        private static GameObject _multiplayerButton;

        public static void Apply(HarmonyLib.Harmony harmony)
        {
            var menuType = AccessTools.TypeByName("MainMenuController");
            var awake = menuType == null ? null : AccessTools.Method(menuType, "Awake");

            if (awake == null)
            {
                MultiplayerMod.Instance?.Log.LogWarning(
                    "MainMenuController.Awake nicht gefunden; Main-Menu-Integration bleibt deaktiviert.");
                return;
            }

            harmony.Patch(awake, postfix: new HarmonyMethod(typeof(MainMenuPatches), nameof(MainMenu_Awake_Postfix)));
            var selectSave = AccessTools.Method(menuType, "SelectNewSave");
            if (selectSave != null)
                harmony.Patch(selectSave, postfix: new HarmonyMethod(typeof(MainMenuPatches), nameof(SelectNewSave_Postfix)));
            MultiplayerMod.Instance?.Log.LogInfo("MainMenuController.Awake erfolgreich gepatcht.");
        }

        private static void MainMenu_Awake_Postfix()
        {
            if (_uiObject != null)
                return;

            _uiObject = new GameObject("SOD Multiplayer");
            UnityEngine.Object.DontDestroyOnLoad(_uiObject);
            var browser = _uiObject.AddComponent<ServerBrowserUI>();

            var canvas = UnityEngine.Object.FindObjectOfType<Canvas>();
            if (canvas == null)
                return;

            _multiplayerButton = new GameObject("MultiplayerButton");
            _multiplayerButton.transform.SetParent(canvas.transform, false);
            var rect = _multiplayerButton.AddComponent<RectTransform>();
            rect.sizeDelta = new Vector2(260, 55);
            rect.anchoredPosition = new Vector2(0, -180);

            var image = _multiplayerButton.AddComponent<Image>();
            image.color = new Color(0.2f, 0.45f, 0.75f, 1f);
            var button = _multiplayerButton.AddComponent<Button>();
            button.targetGraphic = image;
            button.onClick.AddListener(DelegateSupport.ConvertDelegate<UnityEngine.Events.UnityAction>(
                () => browser.Show()));

            var labelObject = new GameObject("Text");
            labelObject.transform.SetParent(_multiplayerButton.transform, false);
            var labelRect = labelObject.AddComponent<RectTransform>();
            labelRect.anchorMin = Vector2.zero;
            labelRect.anchorMax = Vector2.one;
            labelRect.sizeDelta = Vector2.zero;
            var label = labelObject.AddComponent<TextMeshProUGUI>();
            label.text = "MULTIPLAYER";
            label.fontSize = 20;
            label.alignment = TextAlignmentOptions.Center;
            label.color = Color.white;
        }

        private static void SelectNewSave_Postfix(object __0)
        {
            if (NetworkClient.Active == null || __0 == null)
                return;

            var info = __0.GetType().GetField("info")?.GetValue(__0) as System.IO.FileInfo;
            if (info == null)
                return;

            NetworkClient.Active.SendSessionSelected(info.FullName, "");
            MultiplayerMod.Instance?.Log.LogInfo($"Savegame an Server gemeldet: {info.Name}");
        }
    }
}
