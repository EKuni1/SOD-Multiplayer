using System;
using HarmonyLib;
using SOD.Multiplayer.Client.Network;

namespace SOD.Multiplayer.Client.Harmony
{
    public static class MainMenuPatches
    {
        public static void Apply(HarmonyLib.Harmony harmony)
        {
            var menuType = AccessTools.TypeByName("MainMenuController");
            var selectSave = menuType == null ? null : AccessTools.Method(menuType, "SelectNewSave");
            if (selectSave != null)
                harmony.Patch(selectSave, postfix: new HarmonyMethod(typeof(MainMenuPatches), nameof(SelectNewSave_Postfix)));
            MultiplayerMod.Instance?.Log.LogInfo("Separate Multiplayer-Menue aktiv: Ctrl+M");
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
