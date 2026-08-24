using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Il2CppInterop.Runtime.Injection;
using Newtonsoft.Json;
using UnityEngine;
using SOD.Multiplayer.Client.Network;
using SOD.Multiplayer.Shared;

namespace SOD.Multiplayer.Client
{
    public sealed class RuntimeDiagnostics : MonoBehaviour
    {
        private static readonly ConcurrentQueue<DiagnosticRecord> Pending = new();
        private static RuntimeDiagnostics _instance;
        private static string _filePath;
        private float _nextSnapshot;

        public RuntimeDiagnostics(IntPtr ptr) : base(ptr)
        {
        }

        public RuntimeDiagnostics() : this(ClassInjector.DerivedConstructorPointer<RuntimeDiagnostics>())
        {
            ClassInjector.DerivedConstructorBody(this);
        }

        public static void Start()
        {
            if (_instance != null)
                return;

            var directory = Path.Combine(Application.persistentDataPath, "SOD-Multiplayer", "diagnostics");
            Directory.CreateDirectory(directory);
            _filePath = Path.Combine(directory, $"session-{DateTime.UtcNow:yyyyMMdd-HHmmss}.ndjson");
            var host = new GameObject("SOD Multiplayer Diagnostics");
            DontDestroyOnLoad(host);
            _instance = host.AddComponent<RuntimeDiagnostics>();
            Record("session_started", new { GameVersion = Application.version, UnityVersion = Application.unityVersion });
            CaptureAssemblySurface();
        }

        public static void Record(string eventName, object data = null)
        {
            Pending.Enqueue(new DiagnosticRecord
            {
                Timestamp = DateTime.UtcNow,
                Event = eventName,
                Data = data
            });
        }

        public static void RecordPacket(Packet packet, string direction)
        {
            if (packet == null)
                return;

            Record("packet", new
            {
                Direction = direction,
                Type = packet.Type.ToString(),
                packet.SenderId,
                Payload = JsonConvert.SerializeObject(packet)
            });
        }

        private void Update()
        {
            while (Pending.TryDequeue(out var record))
                File.AppendAllText(_filePath, JsonConvert.SerializeObject(record) + Environment.NewLine);

            if (Time.unscaledTime < _nextSnapshot)
                return;

            _nextSnapshot = Time.unscaledTime + 2f;
            CaptureRuntimeSnapshot();
        }

        private static void CaptureAssemblySurface()
        {
            var names = new[]
            {
                "MainMenuController", "SessionData", "DoorMovementController", "Case",
                "CasePanelController", "SideJob", "SideJobController", "Company",
                "Citizen", "CitizenAnimationController", "Elevator", "FirstPersonItemController",
                "Interactable", "PinnedItemController"
            };

            var result = new List<object>();
            foreach (var name in names)
            {
                var type = AccessToolsType(name);
                if (type == null)
                {
                    result.Add(new { Name = name, Found = false });
                    continue;
                }

                result.Add(new
                {
                    Name = name,
                    Found = true,
                    Methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                        .Where(method => method.Name is "Awake" or "SelectNewSave" or "Update" or "SetGameTime" or "SetWeather" or "SetOpen" or "SetStatus" or "SetJobState" or "SetDead" or "CallElevator" or "PickUpItem" or "EmptySlot" or "PinToCasePanel" or "FinishCustomStringLinkSelection")
                        .Select(method => new
                        {
                            method.Name,
                            Parameters = method.GetParameters().Select(parameter => parameter.ParameterType.FullName).ToArray()
                        }).ToArray()
                });
            }
            Record("assembly_surface", result);
        }

        private static void CaptureRuntimeSnapshot()
        {
            try
            {
                var session = SessionData.Instance;
                var cases = CasePanelController.Instance;
                var snapshot = new
                {
                    Scene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name,
                    Connected = NetworkClient.Active?.IsConnected ?? false,
                    PlayerId = NetworkClient.Active?.PlayerId,
                    IsHost = MultiplayerMod.IsHost,
                    GameTime = session?.gameTime,
                    Cases = cases == null ? null : new
                    {
                        Active = CollectCases(cases.activeCases),
                        Pins = CollectPins(cases.spawnedPins)
                    },
                    Companies = CollectCompanies(CityData.Instance?.companyDirectory),
                    Jobs = CollectJobs(SideJobController.Instance?.allJobsDictionary),
                    Doors = UnityEngine.Object.FindObjectsOfType<DoorMovementController>().Select(door => new { Id = door.gameObject.name, door.isOpen, door.isAnimating }).ToArray(),
                    Citizens = UnityEngine.Object.FindObjectsOfType<CitizenAnimationController>().Select(citizen => new { Id = citizen.gameObject.name }).ToArray()
                };
                Record("runtime_snapshot", snapshot);
            }
            catch (Exception ex)
            {
                Record("diagnostics_error", new { ex.Message, ex.StackTrace });
            }
        }

        private static object[] CollectCases(Il2CppSystem.Collections.Generic.List<Case> source)
        {
            if (source == null)
                return Array.Empty<object>();

            var result = new List<object>();
            foreach (var value in source)
                result.Add(new { value.id, Status = value.caseStatus.ToString() });
            return result.ToArray();
        }

        private static object[] CollectPins(Il2CppSystem.Collections.Generic.List<PinnedItemController> source)
        {
            if (source == null)
                return Array.Empty<object>();

            var result = new List<object>();
            foreach (var pin in source)
            {
                result.Add(new
                {
                    CaseId = pin.caseElement?.caseID,
                    ElementId = pin.caseElement?.id,
                    Position = pin.pinnedRect == null ? (Vector2?)null : pin.pinnedRect.anchoredPosition,
                    Evidence = pin.evidence?.GetType().FullName
                });
            }
            return result.ToArray();
        }

        private static object[] CollectCompanies(Il2CppSystem.Collections.Generic.List<Company> source)
        {
            if (source == null)
                return Array.Empty<object>();

            var result = new List<object>();
            foreach (var company in source)
                result.Add(new { company.name, company.shortName });
            return result.ToArray();
        }

        private static object[] CollectJobs(Il2CppSystem.Collections.Generic.Dictionary<int, SideJob> source)
        {
            if (source == null)
                return Array.Empty<object>();

            var result = new List<object>();
            foreach (var pair in source)
                result.Add(new { Id = pair.Key, State = pair.Value.state.ToString() });
            return result.ToArray();
        }

        private static Type AccessToolsType(string name)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .Select(assembly => assembly.GetType(name, false))
                .FirstOrDefault(type => type != null);
        }

        private sealed class DiagnosticRecord
        {
            public DateTime Timestamp { get; set; }
            public string Event { get; set; }
            public object Data { get; set; }
        }
    }
}
