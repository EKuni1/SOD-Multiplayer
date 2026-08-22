using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C6 RID: 198
[Token(Token = "0x20000C6")]
public class CityConstructor : MonoBehaviour
{
	// Token: 0x14000009 RID: 9
	// (add) Token: 0x060005DA RID: 1498 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060005DB RID: 1499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000009")]
	public event CityConstructor.OnStartGame OnGameStarted
	{
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xDF09E0", Offset = "0xDEF9E0", VA = "0x180DF09E0")]
		add
		{
		}
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xDF0AE0", Offset = "0xDEFAE0", VA = "0x180DF0AE0")]
		remove
		{
		}
	}

	// Token: 0x1400000A RID: 10
	// (add) Token: 0x060005DC RID: 1500 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400000A")]
	public event CityConstructor.LoadFinalize OnLoadFinalize
	{
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xDF0BE0", Offset = "0xDEFBE0", VA = "0x180DF0BE0")]
		add
		{
		}
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xDF0CE0", Offset = "0xDEFCE0", VA = "0x180DF0CE0")]
		remove
		{
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x060005DE RID: 1502 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000027")]
	public static CityConstructor Instance
	{
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xDF0DE0", Offset = "0xDEFDE0", VA = "0x180DF0DE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005DF")]
	[Address(RVA = "0xDF0E20", Offset = "0xDEFE20", VA = "0x180DF0E20")]
	private void Awake()
	{
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E0")]
	[Address(RVA = "0xDF11B0", Offset = "0xDF01B0", VA = "0x180DF11B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E1")]
	[Address(RVA = "0xDF13C0", Offset = "0xDF03C0", VA = "0x180DF13C0")]
	public void DestroySelf()
	{
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E2")]
	[Address(RVA = "0xDF14D0", Offset = "0xDF04D0", VA = "0x180DF14D0")]
	public void GenerateNewCity()
	{
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E3")]
	[Address(RVA = "0xDF1880", Offset = "0xDF0880", VA = "0x180DF1880")]
	public void LoadSaveGame()
	{
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E4")]
	[Address(RVA = "0xDF1A40", Offset = "0xDF0A40", VA = "0x180DF1A40")]
	public void IncompatibleVersionConfirm()
	{
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E5")]
	[Address(RVA = "0xDF1BB0", Offset = "0xDF0BB0", VA = "0x180DF1BB0")]
	public void IncompatibleVersionCancel()
	{
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E6")]
	[Address(RVA = "0xDF1E20", Offset = "0xDF0E20", VA = "0x180DF1E20")]
	private void GenerateCityFromShareCode()
	{
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E7")]
	[Address(RVA = "0xDF21A0", Offset = "0xDF11A0", VA = "0x180DF21A0")]
	public void LoadCityStartNewGame()
	{
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E8")]
	[Address(RVA = "0xDF21B0", Offset = "0xDF11B0", VA = "0x180DF21B0")]
	public void StartLoading()
	{
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E9")]
	[Address(RVA = "0xDF39E0", Offset = "0xDF29E0", VA = "0x180DF39E0")]
	private void Update()
	{
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005EA")]
	[Address(RVA = "0xDF7B60", Offset = "0xDF6B60", VA = "0x180DF7B60")]
	public void StopCityConstructionAtEndOfLoadState(CityConstructor.LoadState stopHereState)
	{
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005EB")]
	[Address(RVA = "0xDF7B70", Offset = "0xDF6B70", VA = "0x180DF7B70")]
	public void ClearCityConstructionHoldStatus()
	{
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005EC")]
	[Address(RVA = "0xDF7BD0", Offset = "0xDF6BD0", VA = "0x180DF7BD0")]
	private void WriteSavingTimings(ref CityConstructor.CollectedLoadTimeInfo info)
	{
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005ED")]
	[Address(RVA = "0xDF9300", Offset = "0xDF8300", VA = "0x180DF9300")]
	private void WriteRoomDecorTimings(ref CityConstructor.CollectedLoadTimeInfo info)
	{
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005EE")]
	[Address(RVA = "0xDFA3C0", Offset = "0xDF93C0", VA = "0x180DFA3C0")]
	private void WriteGeneratedObjectDetails()
	{
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005EF")]
	[Address(RVA = "0xDFCEB0", Offset = "0xDFBEB0", VA = "0x180DFCEB0")]
	private void SetLoadingText()
	{
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005F0")]
	[Address(RVA = "0xDFCFE0", Offset = "0xDFBFE0", VA = "0x180DFCFE0")]
	private void GatherData()
	{
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005F1")]
	[Address(RVA = "0xDFE590", Offset = "0xDFD590", VA = "0x180DFE590")]
	private void Finalized()
	{
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005F2")]
	[Address(RVA = "0xE013B0", Offset = "0xE003B0", VA = "0x180E013B0")]
	private void FinalizePostSave()
	{
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005F3")]
	[Address(RVA = "0xE02270", Offset = "0xE01270", VA = "0x180E02270")]
	public void SetPreSim(bool val)
	{
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005F4")]
	[Address(RVA = "0xE02AE0", Offset = "0xE01AE0", VA = "0x180E02AE0")]
	public void StartGame()
	{
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005F5")]
	[Address(RVA = "0xE04890", Offset = "0xE03890", VA = "0x180E04890")]
	public void TriggerStartEvent()
	{
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005F6")]
	[Address(RVA = "0xE04B00", Offset = "0xE03B00", VA = "0x180E04B00")]
	private void EnableTutorial()
	{
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005F7")]
	[Address(RVA = "0xE04CC0", Offset = "0xE03CC0", VA = "0x180E04CC0")]
	private void DisableTutorial()
	{
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60005F8")]
	[Address(RVA = "0xE04E80", Offset = "0xE03E80", VA = "0x180E04E80")]
	private IEnumerator SaveCityData()
	{
		return null;
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x000046E0 File Offset: 0x000028E0
	[Token(Token = "0x60005F9")]
	[Address(RVA = "0xE04F20", Offset = "0xE03F20", VA = "0x180E04F20")]
	public bool IsUsingCityEditor()
	{
		return default(bool);
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005FA")]
	[Address(RVA = "0xE050D0", Offset = "0xE040D0", VA = "0x180E050D0")]
	public void Cancel()
	{
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005FB")]
	[Address(RVA = "0xE05130", Offset = "0xE04130", VA = "0x180E05130")]
	public void CreateSelfEmployed(CompanyPreset company, Human employee, Interactable workLocation)
	{
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60005FC")]
	[Address(RVA = "0xE05790", Offset = "0xE04790", VA = "0x180E05790")]
	public Task LoadFullCityDataAsync()
	{
		return null;
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60005FD")]
	[Address(RVA = "0xE05950", Offset = "0xE04950", VA = "0x180E05950")]
	public Task LoadSaveStateFile()
	{
		return null;
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005FE")]
	[Address(RVA = "0xE05B10", Offset = "0xE04B10", VA = "0x180E05B10")]
	public CityConstructor()
	{
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x3ED9D0", Offset = "0x3EC9D0", VA = "0x1803ED9D0")]
	private void <LoadFullCityDataAsync>b__66_0(CitySaveData output)
	{
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000600")]
	[Address(RVA = "0x3EDA40", Offset = "0x3ECA40", VA = "0x1803EDA40")]
	private void <LoadSaveStateFile>b__67_0(StateSaveData output)
	{
	}

	// Token: 0x040005A5 RID: 1445
	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[NonSerialized]
	public CitySaveData currentData;

	// Token: 0x040005A6 RID: 1446
	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public StateSaveData saveState;

	// Token: 0x040005A7 RID: 1447
	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool generateNew;

	// Token: 0x040005A8 RID: 1448
	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool isLoaded;

	// Token: 0x040005A9 RID: 1449
	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool useCityConstructionHold;

	// Token: 0x040005AA RID: 1450
	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int saveChunk;

	// Token: 0x040005AB RID: 1451
	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Evidence> evidenceToCompile;

	// Token: 0x040005AC RID: 1452
	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CityConstructor.LoadState loadState;

	// Token: 0x040005AD RID: 1453
	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public CityConstructor.LoadState cityConstructorHoldState;

	// Token: 0x040005AE RID: 1454
	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<CityConstructor.LoadState> allLoadStates;

	// Token: 0x040005AF RID: 1455
	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int loadCursor;

	// Token: 0x040005B0 RID: 1456
	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float loadingProgress;

	// Token: 0x040005B1 RID: 1457
	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool stateComplete;

	// Token: 0x040005B2 RID: 1458
	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool loadingOperationActive;

	// Token: 0x040005B3 RID: 1459
	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	public bool preSimActive;

	// Token: 0x040005B4 RID: 1460
	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
	public bool preSimOccured;

	// Token: 0x040005B5 RID: 1461
	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Dictionary<int, NewWall> loadingWallsReference;

	// Token: 0x040005B6 RID: 1462
	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Dictionary<int, FurnitureLocation> loadingFurnitureReference;

	// Token: 0x040005B7 RID: 1463
	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Interactable> updateSwitchState;

	// Token: 0x040005B8 RID: 1464
	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float timeStamp;

	// Token: 0x040005B9 RID: 1465
	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[NonSerialized]
	public CityConstructor.CollectedLoadTimeInfo debugLoadTime;

	// Token: 0x040005BC RID: 1468
	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CityConstructor _instance;

	// Token: 0x040005BD RID: 1469
	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Task loadFullCityDataTask;

	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	public enum LoadState
	{
		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		parsingFile,
		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		setupCityBoundary,
		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		generateDistricts,
		// Token: 0x040005C2 RID: 1474
		[Token(Token = "0x40005C2")]
		generateBlocks,
		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x40005C3")]
		generateDensity,
		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		generateBuildings,
		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		generatePathfinding,
		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		generateBlueprints,
		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		generateCompanies,
		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		connectRooms,
		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		generateCitizens,
		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		generateRelationships,
		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		gatherData,
		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		generateAirDucts,
		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		generateEvidence,
		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x40005CE")]
		generateInteriors,
		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		prepareCitizens,
		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		loadObjects,
		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		finalizing,
		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		savingData,
		// Token: 0x040005D3 RID: 1491
		[Token(Token = "0x40005D3")]
		loadState,
		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		preSim,
		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		loadComplete
	}

	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	[Serializable]
	public class CollectedLoadTimeInfo
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000601")]
		[Address(RVA = "0xE05ED0", Offset = "0xE04ED0", VA = "0x180E05ED0")]
		public CollectedLoadTimeInfo()
		{
		}

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string build;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string citySize;

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool generateNew;

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<CityConstructor.LoadState, int> loadTimes;

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<NewRoom, List<CityConstructor.DecorClusterGenerationTimeInfo>> decorTimes;
	}

	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	[Serializable]
	public class DecorClusterGenerationTimeInfo
	{
		// Token: 0x06000602 RID: 1538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DecorClusterGenerationTimeInfo()
		{
		}

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurnitureCluster cluster;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool found;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float time;
	}

	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	[Serializable]
	public class DecorTotalTime
	{
		// Token: 0x06000603 RID: 1539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DecorTotalTime()
		{
		}

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewRoom room;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float totalTime;
	}

	// Token: 0x020000CB RID: 203
	// (Invoke) Token: 0x06000605 RID: 1541
	[Token(Token = "0x20000CB")]
	public delegate void OnStartGame();

	// Token: 0x020000CC RID: 204
	// (Invoke) Token: 0x06000609 RID: 1545
	[Token(Token = "0x20000CC")]
	public delegate void LoadFinalize();

	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	[StructLayout(3)]
	private struct <LoadSaveGame>d__40 : IEnumerator<object>
	{
		// Token: 0x0600060C RID: 1548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060C")]
		[Address(RVA = "0xE06070", Offset = "0xE05070", VA = "0x180E06070", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x6F8FA0", Offset = "0x6F7FA0", VA = "0x1806F8FA0", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		// Token: 0x040005E2 RID: 1506
		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CityConstructor <>4__this;

		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__1;
	}

	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	private sealed class <>c__DisplayClass47_0
	{
		// Token: 0x0600060E RID: 1550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass47_0()
		{
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000046F8 File Offset: 0x000028F8
		[Token(Token = "0x600060F")]
		[Address(RVA = "0xE077D0", Offset = "0xE067D0", VA = "0x180E077D0")]
		internal bool <Update>b__0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x040005E4 RID: 1508
		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewNode.NodeAccess acc;
	}

	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	private sealed class <>c__DisplayClass50_0
	{
		// Token: 0x06000610 RID: 1552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass50_0()
		{
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x6000611")]
		[Address(RVA = "0xE07810", Offset = "0xE06810", VA = "0x180E07810")]
		internal bool <WriteSavingTimings>b__0(CityConstructor.LoadState item)
		{
			return default(bool);
		}

		// Token: 0x040005E5 RID: 1509
		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string loadState;
	}

	// Token: 0x020000D0 RID: 208
	[Token(Token = "0x20000D0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000613 RID: 1555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x6000614")]
		[Address(RVA = "0xE07970", Offset = "0xE06970", VA = "0x180E07970")]
		internal int <WriteRoomDecorTimings>b__51_1(CityConstructor.DecorClusterGenerationTimeInfo p2, CityConstructor.DecorClusterGenerationTimeInfo p1)
		{
			return 0;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x57C700", Offset = "0x57B700", VA = "0x18057C700")]
		internal int <WriteRoomDecorTimings>b__51_0(CityConstructor.DecorTotalTime p2, CityConstructor.DecorTotalTime p1)
		{
			return 0;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x6000616")]
		[Address(RVA = "0xE07A00", Offset = "0xE06A00", VA = "0x180E07A00")]
		internal int <WriteGeneratedObjectDetails>b__52_0(Interactable p2, Interactable p1)
		{
			return 0;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00004770 File Offset: 0x00002970
		[Token(Token = "0x6000617")]
		[Address(RVA = "0xE07A50", Offset = "0xE06A50", VA = "0x180E07A50")]
		internal bool <GatherData>b__54_0(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00004788 File Offset: 0x00002988
		[Token(Token = "0x6000618")]
		[Address(RVA = "0xE07AC0", Offset = "0xE06AC0", VA = "0x180E07AC0")]
		internal bool <FinalizePostSave>b__56_0(StreetController item)
		{
			return default(bool);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x4E73D0", Offset = "0x4E63D0", VA = "0x1804E73D0")]
		internal bool <StartGame>b__58_1(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x600061A")]
		[Address(RVA = "0xE07B60", Offset = "0xE06B60", VA = "0x180E07B60")]
		internal bool <StartGame>b__58_2(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x600061B")]
		[Address(RVA = "0xE07C00", Offset = "0xE06C00", VA = "0x180E07C00")]
		internal bool <StartGame>b__58_0(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x600061C")]
		[Address(RVA = "0xE07C30", Offset = "0xE06C30", VA = "0x180E07C30")]
		internal bool <StartGame>b__58_3(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x040005E6 RID: 1510
		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CityConstructor.<>c <>9;

		// Token: 0x040005E7 RID: 1511
		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<CityConstructor.DecorClusterGenerationTimeInfo> <>9__51_1;

		// Token: 0x040005E8 RID: 1512
		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Comparison<CityConstructor.DecorTotalTime> <>9__51_0;

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Comparison<Interactable> <>9__52_0;

		// Token: 0x040005EA RID: 1514
		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<NewAddress> <>9__54_0;

		// Token: 0x040005EB RID: 1515
		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<StreetController> <>9__56_0;

		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<NewNode.NodeAccess> <>9__58_1;

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<NewAddress> <>9__58_2;

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Predicate<FurnitureLocation> <>9__58_0;

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Predicate<FurnitureLocation> <>9__58_3;
	}

	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	private sealed class <>c__DisplayClass62_0
	{
		// Token: 0x0600061D RID: 1565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass62_0()
		{
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061E")]
		[Address(RVA = "0xE07CD0", Offset = "0xE06CD0", VA = "0x180E07CD0")]
		internal void <SaveCityData>b__0()
		{
		}

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string cityInfoPath;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string writeString;

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string cityDataPath;
	}

	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	private sealed class <>c__DisplayClass62_1
	{
		// Token: 0x0600061F RID: 1567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass62_1()
		{
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000620")]
		[Address(RVA = "0xE07E50", Offset = "0xE06E50", VA = "0x180E07E50")]
		internal void <SaveCityData>b__1()
		{
		}

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string jsonString;

		// Token: 0x040005F4 RID: 1524
		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CityConstructor.<>c__DisplayClass62_0 CS$<>8__locals1;
	}

	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	private sealed class <>c__DisplayClass62_2
	{
		// Token: 0x06000621 RID: 1569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass62_2()
		{
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000622")]
		[Address(RVA = "0xE07FD0", Offset = "0xE06FD0", VA = "0x180E07FD0")]
		internal void <SaveCityData>b__2()
		{
		}

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string jsonString;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CityConstructor.<>c__DisplayClass62_0 CS$<>8__locals2;
	}

	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	private sealed class <SaveCityData>d__62 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000623 RID: 1571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <SaveCityData>d__62(int <>1__state)
		{
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x6000625")]
		[Address(RVA = "0xE08150", Offset = "0xE07150", VA = "0x180E08150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000028")]
		private object Current
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000627")]
		[Address(RVA = "0xE0A810", Offset = "0xE09810", VA = "0x180E0A810", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000029")]
		private object Current
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CityConstructor <>4__this;

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CityConstructor.<>c__DisplayClass62_0 <>8__1;

		// Token: 0x040005FB RID: 1531
		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <cursor>5__2;

		// Token: 0x040005FC RID: 1532
		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<CityTile> <cityTiles>5__3;

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Stopwatch <stopWatch>5__4;

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Task <writeCityInfoTask>5__5;

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string <compressedCityPath>5__6;

		// Token: 0x04000600 RID: 1536
		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Task<bool> <tempCompressionTask>5__7;

		// Token: 0x04000601 RID: 1537
		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Task <tempTask>5__8;
	}

	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	private sealed class <>c__DisplayClass66_0
	{
		// Token: 0x06000629 RID: 1577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass66_0()
		{
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062A")]
		[Address(RVA = "0xE0A860", Offset = "0xE09860", VA = "0x180E0A860")]
		internal void <LoadFullCityDataAsync>b__1()
		{
		}

		// Token: 0x04000602 RID: 1538
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string jsonString;
	}

	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	[StructLayout(3)]
	private struct <LoadFullCityDataAsync>d__66 : IEnumerator<object>
	{
		// Token: 0x0600062B RID: 1579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062B")]
		[Address(RVA = "0xE0AA90", Offset = "0xE09A90", VA = "0x180E0AA90", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062C")]
		[Address(RVA = "0xE0B5C0", Offset = "0xE0A5C0", VA = "0x180E0B5C0", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CityConstructor <>4__this;

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CityConstructor.<>c__DisplayClass66_0 <>8__1;

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Stopwatch <stopWatch>5__2;

		// Token: 0x04000608 RID: 1544
		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<bool> <>u__1;

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter <>u__2;
	}

	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	private sealed class <>c__DisplayClass67_0
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass67_0()
		{
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062E")]
		[Address(RVA = "0xE0B620", Offset = "0xE0A620", VA = "0x180E0B620")]
		internal void <LoadSaveStateFile>b__1()
		{
		}

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string jsonString;
	}

	// Token: 0x020000D8 RID: 216
	[Token(Token = "0x20000D8")]
	[StructLayout(3)]
	private struct <LoadSaveStateFile>d__67 : IEnumerator<object>
	{
		// Token: 0x0600062F RID: 1583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062F")]
		[Address(RVA = "0xE0B850", Offset = "0xE0A850", VA = "0x180E0B850", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000630")]
		[Address(RVA = "0xE0C2C0", Offset = "0xE0B2C0", VA = "0x180E0C2C0", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CityConstructor <>4__this;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CityConstructor.<>c__DisplayClass67_0 <>8__1;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Stopwatch <stopWatch>5__2;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<bool> <>u__1;

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter <>u__2;
	}
}
