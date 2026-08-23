using System;
using HarmonyLib;
using Newtonsoft.Json;
using SOD.Multiplayer.Client.Network;
using SOD.Multiplayer.Shared;
using UnityEngine;

namespace SOD.Multiplayer.Client.Harmony
{
    public static class WorldSync
    {
        private static bool _applyingRemoteState;

        public static void Apply(WorldActionPacket packet)
        {
            if (_applyingRemoteState || packet == null)
                return;

            if (packet.EntityType == WorldEntityType.Door)
            {
                var state = JsonConvert.DeserializeObject<DoorState>(packet.StateJson);
                if (state != null)
                    ApplyDoor(packet.EntityId, state.Ajar);
            }
            else if (packet.EntityType == WorldEntityType.Object && packet.Action == "SessionState")
            {
                var state = JsonConvert.DeserializeObject<SessionState>(packet.StateJson);
                if (state != null)
                    ApplySessionState(state);
            }
            else if (packet.EntityType == WorldEntityType.Company && packet.Action == "SetOpen")
            {
                var state = JsonConvert.DeserializeObject<OpenState>(packet.StateJson);
                if (state != null)
                    ApplyCompany(packet.EntityId, state.Open);
            }
            else if (packet.EntityType == WorldEntityType.Object && packet.Action == "JobState")
            {
                var state = JsonConvert.DeserializeObject<JobState>(packet.StateJson);
                if (state != null)
                    ApplyJob(state.JobId, state.State);
            }
            else if (packet.EntityType == WorldEntityType.Citizen && packet.Action == "SetDead")
            {
                var state = JsonConvert.DeserializeObject<DeadState>(packet.StateJson);
                if (state != null)
                    ApplyCitizenDeath(packet.EntityId, state.Dead);
            }
            else if (packet.EntityType == WorldEntityType.Case && packet.Action == "SetStatus")
            {
                var state = JsonConvert.DeserializeObject<CaseStatusState>(packet.StateJson);
                if (state != null)
                    ApplyCaseStatus(state.CaseId, state.Status);
            }
            else if (packet.EntityType == WorldEntityType.Pinboard && packet.Action == "PinPosition")
            {
                var state = JsonConvert.DeserializeObject<PinPositionState>(packet.StateJson);
                if (state != null)
                    ApplyPinPosition(state.CaseId, state.ElementId, state.X, state.Y);
            }
        }

        public static void Apply(WorldSnapshotPacket packet)
        {
            if (packet == null)
                return;

            foreach (var entity in packet.Entities ?? new System.Collections.Generic.List<WorldEntityState>())
            {
                Apply(new WorldActionPacket
                {
                    EntityType = entity.EntityType,
                    EntityId = entity.EntityId,
                    StateJson = entity.StateJson
                });
            }
        }

        public static void SendDoorState(DoorMovementController door, float ajar)
        {
            if (_applyingRemoteState || !IsConnectedHost())
                return;

            NetworkClient.Active.SendWorldAction(
                WorldEntityType.Door,
                door.gameObject.name,
                "SetOpen",
                JsonConvert.SerializeObject(new DoorState { Ajar = ajar }));
        }

        public static void SendSessionState(SessionState state)
        {
            if (_applyingRemoteState || !IsConnectedHost())
                return;

            NetworkClient.Active.SendWorldAction(
                WorldEntityType.Object,
                "SessionData",
                "SessionState",
                JsonConvert.SerializeObject(state));
        }

        public static void SendCompanyState(Company company, bool open)
        {
            if (!IsConnectedHost())
                return;

            NetworkClient.Active.SendWorldAction(
                WorldEntityType.Company,
                company.name,
                "SetOpen",
                JsonConvert.SerializeObject(new OpenState { Open = open }));
        }

        public static void SendJobState(SideJob job, SideJob.JobState state)
        {
            if (!IsConnectedHost())
                return;

            NetworkClient.Active.SendWorldAction(
                WorldEntityType.Object,
                $"SideJob:{job.jobID}",
                "JobState",
                JsonConvert.SerializeObject(new JobState { JobId = job.jobID, State = (int)state }));
        }

        public static void SendCitizenDeath(Citizen citizen, bool dead)
        {
            if (!IsConnectedHost())
                return;

            NetworkClient.Active.SendWorldAction(
                WorldEntityType.Citizen,
                citizen.gameObject.name,
                "SetDead",
                JsonConvert.SerializeObject(new DeadState { Dead = dead }));
        }

        public static void SendCaseStatus(Case value)
        {
            if (!IsConnectedHost())
                return;

            NetworkClient.Active.SendWorldAction(
                WorldEntityType.Case,
                value.id.ToString(),
                "SetStatus",
                JsonConvert.SerializeObject(new CaseStatusState
                {
                    CaseId = value.id,
                    Status = (int)value.caseStatus
                }));
        }

        public static void SendPinPosition(CasePanelController panel, Case.CaseElement element)
        {
            if (!IsConnectedHost() || panel == null || element == null || panel.spawnedPins == null)
                return;

            foreach (var pin in panel.spawnedPins)
            {
                if (pin.caseElement != element || pin.pinnedRect == null)
                    continue;

                NetworkClient.Active.SendWorldAction(
                    WorldEntityType.Pinboard,
                    $"{element.caseID}:{element.id}",
                    "PinPosition",
                    JsonConvert.SerializeObject(new PinPositionState
                    {
                        CaseId = element.caseID,
                        ElementId = element.id,
                        X = pin.pinnedRect.anchoredPosition.x,
                        Y = pin.pinnedRect.anchoredPosition.y
                    }));
                return;
            }
        }

        private static bool IsConnectedHost()
        {
            return NetworkClient.Active != null
                && NetworkClient.Active.IsConnected
                && MultiplayerMod.IsHost;
        }

        private static void ApplyDoor(string id, float ajar)
        {
            foreach (var door in UnityEngine.Object.FindObjectsOfType<DoorMovementController>())
            {
                if (door.gameObject.name != id)
                    continue;

                _applyingRemoteState = true;
                try
                {
                    door.SetOpen(ajar, null, true);
                }
                finally
                {
                    _applyingRemoteState = false;
                }
                return;
            }
        }

        private static void ApplySessionState(SessionState state)
        {
            MultiplayerMod.SynchronizedGameTime = state.GameTime;
            MultiplayerMod.SynchronizedLeapYearCycle = state.LeapYearCycle;
            MultiplayerMod.SynchronizedRain = state.Rain;
            MultiplayerMod.SynchronizedWind = state.Wind;
            MultiplayerMod.SynchronizedSnow = state.Snow;
            MultiplayerMod.SynchronizedLightning = state.Lightning;
            MultiplayerMod.SynchronizedFog = state.Fog;

            if (SessionData.Instance == null)
                return;

            _applyingRemoteState = true;
            try
            {
                SessionData.Instance.SetGameTime(state.GameTime, state.LeapYearCycle);
                SessionData.Instance.SetWeather(
                    state.Rain,
                    state.Wind,
                    state.Snow,
                    state.Lightning,
                    state.Fog,
                    0.1f,
                    true);
            }
            finally
            {
                _applyingRemoteState = false;
            }
        }

        private static void ApplyCompany(string id, bool open)
        {
            if (CityData.Instance?.companyDirectory == null)
                return;

            foreach (var company in CityData.Instance.companyDirectory)
            {
                if (company.name != id)
                    continue;

                _applyingRemoteState = true;
                try { company.SetOpen(open, true); }
                finally { _applyingRemoteState = false; }
                return;
            }
        }

        private static void ApplyJob(int jobId, int state)
        {
            var jobs = SideJobController.Instance?.allJobsDictionary;
            if (jobs == null || !jobs.TryGetValue(jobId, out var job))
                return;

            _applyingRemoteState = true;
            try { job.SetJobState((SideJob.JobState)state, true); }
            finally { _applyingRemoteState = false; }
        }

        private static void ApplyCitizenDeath(string id, bool dead)
        {
            foreach (var controller in UnityEngine.Object.FindObjectsOfType<CitizenAnimationController>())
            {
                if (controller.gameObject.name != id)
                    continue;

                _applyingRemoteState = true;
                try { controller.SetDead(dead); }
                finally { _applyingRemoteState = false; }
                return;
            }
        }

        private static void ApplyCaseStatus(int caseId, int status)
        {
            var panel = CasePanelController.Instance;
            if (panel == null)
                return;

            if (ApplyCaseStatus(panel.activeCases, caseId, status)
                || ApplyCaseStatus(panel.archivedCases, caseId, status))
                return;
        }

        private static bool ApplyCaseStatus(Il2CppSystem.Collections.Generic.List<Case> cases, int caseId, int status)
        {
            if (cases == null)
                return false;

            foreach (var value in cases)
            {
                if (value.id != caseId)
                    continue;

                _applyingRemoteState = true;
                try { value.SetStatus((Case.CaseStatus)status); }
                finally { _applyingRemoteState = false; }
                return true;
            }

            return false;
        }

        private static void ApplyPinPosition(int caseId, string elementId, float x, float y)
        {
            var panel = CasePanelController.Instance;
            if (panel?.spawnedPins == null)
                return;

            foreach (var pin in panel.spawnedPins)
            {
                if (pin.caseElement == null || pin.caseElement.caseID != caseId || pin.caseElement.id != elementId || pin.pinnedRect == null)
                    continue;

                pin.pinnedRect.anchoredPosition = new Vector2(x, y);
                return;
            }
        }

        public sealed class DoorState
        {
            public float Ajar { get; set; }
        }

        public sealed class SessionState
        {
            public float GameTime { get; set; }
            public int LeapYearCycle { get; set; }
            public float Rain { get; set; }
            public float Wind { get; set; }
            public float Snow { get; set; }
            public float Lightning { get; set; }
            public float Fog { get; set; }
        }

        public sealed class OpenState { public bool Open { get; set; } }
        public sealed class JobState { public int JobId { get; set; } public int State { get; set; } }
        public sealed class DeadState { public bool Dead { get; set; } }
        public sealed class CaseStatusState { public int CaseId { get; set; } public int Status { get; set; } }
        public sealed class PinPositionState { public int CaseId { get; set; } public string ElementId { get; set; } = ""; public float X { get; set; } public float Y { get; set; } }
    }

    [HarmonyPatch(typeof(DoorMovementController), nameof(DoorMovementController.SetOpen))]
    public static class DoorStatePatch
    {
        [HarmonyPostfix]
        private static void Postfix(DoorMovementController __instance, float newAjar)
        {
            WorldSync.SendDoorState(__instance, newAjar);
        }
    }

    [HarmonyPatch(typeof(SessionData), nameof(SessionData.SetGameTime), typeof(float), typeof(int))]
    public static class SessionTimePatch
    {
        [HarmonyPostfix]
        private static void Postfix(float newGameTime, int newLeapYearCycle)
        {
            if (!MultiplayerMod.IsHost || SessionData.Instance == null)
                return;

            WorldSync.SendSessionState(new WorldSync.SessionState
            {
                GameTime = newGameTime,
                LeapYearCycle = newLeapYearCycle,
                Rain = MultiplayerMod.SynchronizedRain,
                Wind = MultiplayerMod.SynchronizedWind,
                Snow = MultiplayerMod.SynchronizedSnow,
                Lightning = MultiplayerMod.SynchronizedLightning,
                Fog = MultiplayerMod.SynchronizedFog
            });
        }
    }

    [HarmonyPatch(typeof(SessionData), nameof(SessionData.SetWeather),
        typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(bool))]
    public static class SessionWeatherPatch
    {
        [HarmonyPostfix]
        private static void Postfix(
            float newRain,
            float newWind,
            float newSnow,
            float newLightning,
            float newFog)
        {
            if (!MultiplayerMod.IsHost || SessionData.Instance == null)
                return;

            WorldSync.SendSessionState(new WorldSync.SessionState
            {
                GameTime = MultiplayerMod.SynchronizedGameTime,
                LeapYearCycle = MultiplayerMod.SynchronizedLeapYearCycle,
                Rain = newRain,
                Wind = newWind,
                Snow = newSnow,
                Lightning = newLightning,
                Fog = newFog
            });
        }
    }

    [HarmonyPatch(typeof(Company), nameof(Company.SetOpen), typeof(bool), typeof(bool))]
    public static class CompanyStatePatch
    {
        [HarmonyPostfix]
        private static void Postfix(Company __instance, bool openClosed)
        {
            WorldSync.SendCompanyState(__instance, openClosed);
        }
    }

    [HarmonyPatch(typeof(SideJob), nameof(SideJob.SetJobState), typeof(SideJob.JobState), typeof(bool))]
    public static class SideJobStatePatch
    {
        [HarmonyPostfix]
        private static void Postfix(SideJob __instance, SideJob.JobState newState)
        {
            WorldSync.SendJobState(__instance, newState);
        }
    }

    [HarmonyPatch(typeof(CitizenAnimationController), nameof(CitizenAnimationController.SetDead), typeof(bool))]
    public static class CitizenDeathPatch
    {
        [HarmonyPostfix]
        private static void Postfix(CitizenAnimationController __instance, bool val)
        {
            if (__instance != null)
                WorldSync.SendCitizenDeath(__instance.GetComponent<Citizen>(), val);
        }
    }

    [HarmonyPatch(typeof(Case), nameof(Case.SetStatus), typeof(Case.CaseStatus), typeof(bool))]
    public static class CaseStatusPatch
    {
        [HarmonyPostfix]
        private static void Postfix(Case __instance)
        {
            WorldSync.SendCaseStatus(__instance);
        }
    }

    [HarmonyPatch(typeof(CasePanelController), nameof(CasePanelController.PinToCasePanel),
        typeof(Case), typeof(Evidence), typeof(Evidence.DataKey), typeof(bool), typeof(Vector2), typeof(bool))]
    public static class CasePinPatch
    {
        [HarmonyPostfix]
        private static void Postfix(CasePanelController __instance, Case toCase, Evidence ev, Evidence.DataKey evKey)
        {
            if (toCase?.caseElements == null)
                return;

            foreach (var element in toCase.caseElements)
            {
                if (element.pinnedController != null && element.pinnedController.evidence == ev)
                    WorldSync.SendPinPosition(__instance, element);
            }
        }
    }
}
