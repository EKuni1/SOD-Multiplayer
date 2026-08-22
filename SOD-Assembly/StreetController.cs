using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000174 RID: 372
[Token(Token = "0x2000174")]
public class StreetController : NewGameLocation, IEnumerator<object>
{
	// Token: 0x060009AD RID: 2477 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009AD")]
	[Address(RVA = "0x51EDE0", Offset = "0x51DDE0", VA = "0x18051EDE0")]
	public void Setup(DistrictController newDistrict)
	{
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009AE")]
	[Address(RVA = "0x51F0C0", Offset = "0x51E0C0", VA = "0x18051F0C0")]
	public void Load(CitySaveData.StreetCitySave data)
	{
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009AF")]
	[Address(RVA = "0x5204A0", Offset = "0x51F4A0", VA = "0x1805204A0")]
	public void AddTile(NewTile newTile)
	{
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B0")]
	[Address(RVA = "0x5207C0", Offset = "0x51F7C0", VA = "0x1805207C0")]
	public void RemoveTile(NewTile newTile)
	{
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B1")]
	[Address(RVA = "0x5208D0", Offset = "0x51F8D0", VA = "0x1805208D0")]
	public void SetAsAlley()
	{
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B2")]
	[Address(RVA = "0x520A70", Offset = "0x51FA70", VA = "0x180520A70")]
	public void SetAsBackstreet()
	{
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B3")]
	[Address(RVA = "0x520C10", Offset = "0x51FC10", VA = "0x180520C10")]
	public void SetAsStreet()
	{
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B4")]
	[Address(RVA = "0x520DB0", Offset = "0x51FDB0", VA = "0x180520DB0")]
	public void UpdateNameCustom(string userStreetName)
	{
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B5")]
	[Address(RVA = "0x520EA0", Offset = "0x51FEA0", VA = "0x180520EA0")]
	public void UpdateName(bool forceTrueRandom = false)
	{
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x000065A0 File Offset: 0x000047A0
	[Token(Token = "0x60009B6")]
	[Address(RVA = "0x5221C0", Offset = "0x5211C0", VA = "0x1805221C0", Slot = "10")]
	public override bool IsOutside()
	{
		return default(bool);
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x5221D0", Offset = "0x5211D0", VA = "0x1805221D0")]
	public void AddChunk(PathFinder.StreetChunk newChunk)
	{
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009B8")]
	[Address(RVA = "0x522280", Offset = "0x521280", VA = "0x180522280")]
	public List<StreetController> GetNeighboringStreets()
	{
		return null;
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x000065B8 File Offset: 0x000047B8
	[Token(Token = "0x60009B9")]
	[Address(RVA = "0x522880", Offset = "0x521880", VA = "0x180522880", Slot = "11")]
	public int CompareTo(StreetController otherObject)
	{
		return 0;
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BA")]
	[Address(RVA = "0x522910", Offset = "0x521910", VA = "0x180522910", Slot = "5")]
	public override void CreateEvidence()
	{
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BB")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "4")]
	public override void SetupEvidence()
	{
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009BC")]
	[Address(RVA = "0x522AC0", Offset = "0x521AC0", VA = "0x180522AC0")]
	public CitySaveData.StreetCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BD")]
	[Address(RVA = "0x523400", Offset = "0x522400", VA = "0x180523400")]
	public void LoadStreetTiles()
	{
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BE")]
	[Address(RVA = "0x524AF0", Offset = "0x523AF0", VA = "0x180524AF0")]
	public void LoadSections()
	{
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BF")]
	[Address(RVA = "0x525270", Offset = "0x524270", VA = "0x180525270")]
	public void AddForStaticBatching(GameObject obj, Mesh objectMesh, Material objectMat)
	{
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C0")]
	[Address(RVA = "0x525970", Offset = "0x524970", VA = "0x180525970")]
	public void ExecuteStaticBatching()
	{
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009C1")]
	[Address(RVA = "0x525D90", Offset = "0x524D90", VA = "0x180525D90")]
	private StreetTilePreset.StreetSectionModel GetModel(StreetTilePreset.StreetSection section, string seed)
	{
		return null;
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x5260B0", Offset = "0x5250B0", VA = "0x1805260B0")]
	public NewNode GetDestinationNode()
	{
		return null;
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x5266A0", Offset = "0x5256A0", VA = "0x1805266A0")]
	public void Redecorate()
	{
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009C4")]
	[Address(RVA = "0x526790", Offset = "0x525790", VA = "0x180526790")]
	public StreetController()
	{
	}

	// Token: 0x040009D6 RID: 2518
	[Token(Token = "0x40009D6")]
	[FieldOffset(Offset = "0x118")]
	public int streetID;

	// Token: 0x040009D7 RID: 2519
	[Token(Token = "0x40009D7")]
	[FieldOffset(Offset = "0x0")]
	public static int assignID;

	// Token: 0x040009D8 RID: 2520
	[Token(Token = "0x40009D8")]
	[FieldOffset(Offset = "0x11C")]
	public bool isPlayerEditedName;

	// Token: 0x040009D9 RID: 2521
	[Token(Token = "0x40009D9")]
	[FieldOffset(Offset = "0x120")]
	public string playerEditedStreetName;

	// Token: 0x040009DA RID: 2522
	[Token(Token = "0x40009DA")]
	[FieldOffset(Offset = "0x128")]
	public List<NewTile> tiles;

	// Token: 0x040009DB RID: 2523
	[Token(Token = "0x40009DB")]
	[FieldOffset(Offset = "0x130")]
	public string streetSuffix;

	// Token: 0x040009DC RID: 2524
	[Token(Token = "0x40009DC")]
	[FieldOffset(Offset = "0x138")]
	public bool isAlley;

	// Token: 0x040009DD RID: 2525
	[Token(Token = "0x40009DD")]
	[FieldOffset(Offset = "0x139")]
	public bool isBackstreet;

	// Token: 0x040009DE RID: 2526
	[Token(Token = "0x40009DE")]
	[FieldOffset(Offset = "0x13C")]
	public float normalizedFootfall;

	// Token: 0x040009DF RID: 2527
	[Token(Token = "0x40009DF")]
	[FieldOffset(Offset = "0x140")]
	public int chunkSize;

	// Token: 0x040009E0 RID: 2528
	[Token(Token = "0x40009E0")]
	[FieldOffset(Offset = "0x148")]
	private Dictionary<NewRoom.StaticBatchKey, List<GameObject>> staticBatchDictionary;

	// Token: 0x040009E1 RID: 2529
	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0x150")]
	public List<PathFinder.StreetChunk> streetChunks;

	// Token: 0x040009E2 RID: 2530
	[Token(Token = "0x40009E2")]
	[FieldOffset(Offset = "0x158")]
	public List<StreetController.StreetTile> streetSections;

	// Token: 0x040009E3 RID: 2531
	[Token(Token = "0x40009E3")]
	[FieldOffset(Offset = "0x160")]
	public Dictionary<MeshRenderer, StreetTilePreset.StreetSectionModel> loadedModelReference;

	// Token: 0x040009E4 RID: 2532
	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0x168")]
	public List<StreetController> sharedGroundElements;

	// Token: 0x040009E5 RID: 2533
	[Token(Token = "0x40009E5")]
	[FieldOffset(Offset = "0x170")]
	public List<string> debugAddressSet;

	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	[Serializable]
	public class StreetTile
	{
		// Token: 0x060009C6 RID: 2502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x526DA0", Offset = "0x525DA0", VA = "0x180526DA0")]
		public StreetTile(string chunkName, Vector3 newWorldPos, StreetTilePreset.StreetSection newSection, int newAngle)
		{
		}

		// Token: 0x040009E6 RID: 2534
		[Token(Token = "0x40009E6")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040009E7 RID: 2535
		[Token(Token = "0x40009E7")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 worldPos;

		// Token: 0x040009E8 RID: 2536
		[Token(Token = "0x40009E8")]
		[FieldOffset(Offset = "0x24")]
		public StreetTilePreset.StreetSection section;

		// Token: 0x040009E9 RID: 2537
		[Token(Token = "0x40009E9")]
		[FieldOffset(Offset = "0x28")]
		public int angle;
	}

	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	private sealed class <>c__DisplayClass18_0
	{
		// Token: 0x060009C7 RID: 2503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass18_0()
		{
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x000065D0 File Offset: 0x000047D0
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x526E20", Offset = "0x525E20", VA = "0x180526E20")]
		internal bool <Load>b__0(DistrictController item)
		{
			return default(bool);
		}

		// Token: 0x040009EA RID: 2538
		[Token(Token = "0x40009EA")]
		[FieldOffset(Offset = "0x10")]
		public CitySaveData.StreetCitySave data;
	}

	// Token: 0x02000177 RID: 375
	[Token(Token = "0x2000177")]
	private sealed class <>c__DisplayClass18_1
	{
		// Token: 0x060009C9 RID: 2505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass18_1()
		{
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x000065E8 File Offset: 0x000047E8
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x526E50", Offset = "0x525E50", VA = "0x180526E50")]
		internal bool <Load>b__1(StreetController item)
		{
			return default(bool);
		}

		// Token: 0x040009EB RID: 2539
		[Token(Token = "0x40009EB")]
		[FieldOffset(Offset = "0x10")]
		public int stID;
	}

	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	private sealed class <>c__DisplayClass18_2
	{
		// Token: 0x060009CB RID: 2507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass18_2()
		{
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00006600 File Offset: 0x00004800
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x526E70", Offset = "0x525E70", VA = "0x180526E70")]
		internal bool <Load>b__2(CitySaveData.CityTileCitySave item)
		{
			return default(bool);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00006618 File Offset: 0x00004818
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x4810F0", Offset = "0x4800F0", VA = "0x1804810F0")]
		internal bool <Load>b__3(CitySaveData.TileCitySave item)
		{
			return default(bool);
		}

		// Token: 0x040009EC RID: 2540
		[Token(Token = "0x40009EC")]
		[FieldOffset(Offset = "0x10")]
		public NewTile foundTile;
	}

	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	private sealed class <>c__DisplayClass18_3
	{
		// Token: 0x060009CE RID: 2510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass18_3()
		{
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00006630 File Offset: 0x00004830
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x526EC0", Offset = "0x525EC0", VA = "0x180526EC0")]
		internal bool <Load>b__4(StateSaveData.RoomStateSave item)
		{
			return default(bool);
		}

		// Token: 0x040009ED RID: 2541
		[Token(Token = "0x40009ED")]
		[FieldOffset(Offset = "0x10")]
		public CitySaveData.RoomCitySave room;
	}

	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	private sealed class <>c__DisplayClass25_0
	{
		// Token: 0x060009D0 RID: 2512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass25_0()
		{
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00006648 File Offset: 0x00004848
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <UpdateName>b__0(SocialStatistics.EthnicityStats item)
		{
			return default(bool);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00006660 File Offset: 0x00004860
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x526F40", Offset = "0x525F40", VA = "0x180526F40")]
		internal bool <UpdateName>b__1(StreetController item)
		{
			return default(bool);
		}

		// Token: 0x040009EE RID: 2542
		[Token(Token = "0x40009EE")]
		[FieldOffset(Offset = "0x10")]
		public Descriptors.EthnicGroup chosenGroup;

		// Token: 0x040009EF RID: 2543
		[Token(Token = "0x40009EF")]
		[FieldOffset(Offset = "0x18")]
		public StreetController <>4__this;
	}

	// Token: 0x0200017B RID: 379
	[Token(Token = "0x200017B")]
	private sealed class <>c__DisplayClass37_0
	{
		// Token: 0x060009D3 RID: 2515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass37_0()
		{
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00006678 File Offset: 0x00004878
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x527150", Offset = "0x526150", VA = "0x180527150")]
		internal bool <GetModel>b__0(StreetTilePreset item)
		{
			return default(bool);
		}

		// Token: 0x040009F0 RID: 2544
		[Token(Token = "0x40009F0")]
		[FieldOffset(Offset = "0x10")]
		public StreetTilePreset.StreetSection section;
	}
}
