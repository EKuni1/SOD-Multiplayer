using HarmonyLib;
using UnityEngine;
using SOD.Multiplayer.Client.UI;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using SOD.Multiplayer.Client.Network;
using SOD.Multiplayer.Shared;

namespace SOD.Multiplayer.Client.Harmony
{
    // Patch for the main menu to add Multiplayer button
    [HarmonyPatch(typeof(MainMenuController), "Awake")]
    public class MainMenuPatches
    {
        // Find the main menu class - adjust based on actual game assembly
        // This is a placeholder - you need to find the actual main menu class in Assembly-CSharp
        
        [HarmonyPostfix]
        public static void MainMenu_Awake_Postfix(object __instance)
        {
            if (ServerBrowserUI.Instance == null)
            {
                var uiObject = new GameObject("SODMultiplayerUI");
                uiObject.AddComponent<ServerBrowserUI>();
            }

            ServerBrowserUI.Instance.Show();
            Debug.Log("[SOD Multiplayer] Server browser UI displayed");
        }
        
        // Alternative: Patch a specific UI initialization method
        // You need to decompile Assembly-CSharp.dll to find the exact class/method names
    }

    [HarmonyPatch(typeof(MainMenuController), "SelectNewSave")]
    public class SaveSelectionPatch
    {
        [HarmonyPostfix]
        public static void SelectNewSave_Postfix(SaveGameEntryController sec)
        {
            if (sec?.info != null && ServerBrowserUI.Instance != null)
            {
                ServerBrowserUI.Instance.NotifySaveSelected(sec.info.Name);
            }
        }
    }

    [HarmonyPatch(typeof(SessionData), "Update")]
    public class SessionTimeSyncPatch
    {
        [HarmonyPostfix]
        public static void Update_Postfix(SessionData __instance)
        {
            if (!MultiplayerMod.IsHost && MultiplayerMod.SynchronizedGameTime > 0f)
            {
                __instance.gameTime = MultiplayerMod.SynchronizedGameTime;
            }
        }
    }

    internal static class WorldSync
    {
        private static bool _applyingRemoteEvent;

        public static bool IsApplyingRemoteEvent => _applyingRemoteEvent;

        public static void Apply(WorldEventPacket worldEvent)
        {
            if (worldEvent == null || NetworkClient.Active == null)
            {
                return;
            }

            _applyingRemoteEvent = true;
            try
            {
                if (worldEvent.EventType == "DoorOpen" &&
                    float.TryParse(worldEvent.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out var openAmount))
                {
                    foreach (var door in UnityEngine.Object.FindObjectsOfType<DoorMovementController>())
                    {
                        if (door.gameObject.name == worldEvent.ObjectId)
                        {
                            door.SetOpen(openAmount, null, true);
                        }
                    }
                }
                else if (worldEvent.EventType == "CaseStatus" &&
                         int.TryParse(worldEvent.ObjectId, out var caseId) &&
                         Enum.TryParse<Case.CaseStatus>(worldEvent.Value, out var caseStatus))
                {
                    var casePanel = UnityEngine.Object.FindObjectOfType<CasePanelController>();
                    if (casePanel != null)
                    {
                        foreach (var currentCase in casePanel.activeCases)
                        {
                            if (currentCase != null && currentCase.id == caseId)
                            {
                                currentCase.SetStatus(caseStatus);
                            }
                        }
                    }
                }
                else if (worldEvent.EventType == "JobState" &&
                         int.TryParse(worldEvent.ObjectId, out var jobId) &&
                         Enum.TryParse<SideJob.JobState>(worldEvent.Value, out var jobState))
                {
                    var jobs = SideJobController.Instance?.allJobsDictionary;
                    if (jobs != null && jobs.ContainsKey(jobId))
                    {
                        jobs[jobId].SetJobState(jobState, true);
                    }
                }
                else if (worldEvent.EventType == "CitizenDeath")
                {
                    var cityData = CityData.Instance;
                    if (cityData == null || cityData.citizenDirectory == null)
                    {
                        return;
                    }

                    foreach (var citizen in cityData.citizenDirectory)
                    {
                        if (citizen != null && citizen.name == worldEvent.ObjectId)
                        {
                            var animation = citizen.GetComponentInChildren<CitizenAnimationController>();
                            animation?.SetDead(true);
                        }
                    }
                }
                else if ((worldEvent.EventType == "CompanyOpen" || worldEvent.EventType == "CompanyActualOpen") &&
                         bool.TryParse(worldEvent.Value, out var isOpen))
                {
                    var cityData = CityData.Instance;
                    if (cityData?.companyDirectory != null)
                    {
                        foreach (var company in cityData.companyDirectory)
                        {
                            if (company != null && company.name == worldEvent.ObjectId)
                            {
                                company.SetOpen(isOpen, true);
                            }
                        }
                    }
                }
                else
                {
                    NetworkClient.LogInfo($"World event: {worldEvent.EventType} ({worldEvent.ObjectId}) = {worldEvent.Value}");
                }
            }
            finally
            {
                _applyingRemoteEvent = false;
            }
        }

        public static void Send(string eventType, string objectId, string value)
        {
            if (!_applyingRemoteEvent && NetworkClient.Active != null)
            {
                NetworkClient.Active.SendWorldEvent(eventType, objectId, value);
            }
        }
    }

    [HarmonyPatch(typeof(DoorMovementController), "SetOpen")]
    public class DoorSyncPatch
    {
        [HarmonyPostfix]
        public static void SetOpen_Postfix(DoorMovementController __instance, float newAjar)
        {
            if (__instance != null)
            {
                WorldSync.Send("DoorOpen", __instance.gameObject.name,
                    newAjar.ToString(CultureInfo.InvariantCulture));
            }
        }
    }

    [HarmonyPatch(typeof(Case), "SetStatus")]
    public class CaseSyncPatch
    {
        [HarmonyPostfix]
        public static void SetStatus_Postfix(Case __instance, object newStatus)
        {
            if (__instance != null)
            {
                WorldSync.Send("CaseStatus", __instance.id.ToString(CultureInfo.InvariantCulture),
                    newStatus?.ToString() ?? "");
            }
        }
    }

    [HarmonyPatch(typeof(SideJob), "SetJobState")]
    public class SideJobSyncPatch
    {
        [HarmonyPostfix]
        public static void SetJobState_Postfix(SideJob __instance, SideJob.JobState newState)
        {
            if (__instance != null)
            {
                WorldSync.Send("JobState", __instance.jobID.ToString(CultureInfo.InvariantCulture), newState.ToString());
            }
        }
    }

    [HarmonyPatch(typeof(SideJob), "SubmitCase")]
    public class SideJobSubmitSyncPatch
    {
        [HarmonyPostfix]
        public static void SubmitCase_Postfix(SideJob __instance)
        {
            if (__instance != null)
            {
                WorldSync.Send("CaseSubmitted", __instance.caseID.ToString(CultureInfo.InvariantCulture), "true");
            }
        }
    }

    [HarmonyPatch(typeof(Company), "SetOpen")]
    public class CompanyHoursSyncPatch
    {
        [HarmonyPostfix]
        public static void SetOpen_Postfix(Company __instance, bool openClosed)
        {
            if (__instance != null)
            {
                WorldSync.Send("CompanyOpen", __instance.name, openClosed.ToString());
            }
        }
    }

    [HarmonyPatch(typeof(Company), "OnActualOpen")]
    public class CompanyActualOpenSyncPatch
    {
        [HarmonyPostfix]
        public static void OnActualOpen_Postfix(Company __instance)
        {
            if (__instance != null)
            {
                WorldSync.Send("CompanyActualOpen", __instance.name, "true");
            }
        }
    }

    [HarmonyPatch(typeof(Company), "OnActualClose")]
    public class CompanyActualCloseSyncPatch
    {
        [HarmonyPostfix]
        public static void OnActualClose_Postfix(Company __instance)
        {
            if (__instance != null)
            {
                WorldSync.Send("CompanyActualOpen", __instance.name, "false");
            }
        }
    }

    [HarmonyPatch(typeof(MurderController), "OnVictimKilled")]
    public class MurderVictimKilledSyncPatch
    {
        [HarmonyPostfix]
        public static void OnVictimKilled_Postfix()
        {
            WorldSync.Send("MurderEvent", "victim-killed", "true");
        }
    }

    [HarmonyPatch(typeof(MurderController), "OnVictimDiscovery")]
    public class MurderDiscoverySyncPatch
    {
        [HarmonyPostfix]
        public static void OnVictimDiscovery_Postfix()
        {
            WorldSync.Send("MurderEvent", "victim-discovered", "true");
        }
    }

    [HarmonyPatch(typeof(Citizen), "RecieveDamage")]
    public class CitizenDamageSyncPatch
    {
        [HarmonyPostfix]
        public static void RecieveDamage_Postfix(Citizen __instance, bool enableKill)
        {
            if (__instance != null)
            {
                WorldSync.Send(enableKill ? "CitizenDeath" : "CitizenDamage", __instance.name, "damage");
            }
        }
    }
}
