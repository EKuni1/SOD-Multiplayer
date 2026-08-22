using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004C9 RID: 1225
[Token(Token = "0x20004C9")]
[Serializable]
public class CitySaveData
{
	// Token: 0x06001B6C RID: 7020 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B6C")]
	[Address(RVA = "0x9BA400", Offset = "0x9B9400", VA = "0x1809BA400")]
	public CitySaveData()
	{
	}

	// Token: 0x040021A2 RID: 8610
	[Token(Token = "0x40021A2")]
	[FieldOffset(Offset = "0x10")]
	public string build;

	// Token: 0x040021A3 RID: 8611
	[Token(Token = "0x40021A3")]
	[FieldOffset(Offset = "0x18")]
	public string cityName;

	// Token: 0x040021A4 RID: 8612
	[Token(Token = "0x40021A4")]
	[FieldOffset(Offset = "0x20")]
	public string seed;

	// Token: 0x040021A5 RID: 8613
	[Token(Token = "0x40021A5")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 citySize;

	// Token: 0x040021A6 RID: 8614
	[Token(Token = "0x40021A6")]
	[FieldOffset(Offset = "0x30")]
	public int population;

	// Token: 0x040021A7 RID: 8615
	[Token(Token = "0x40021A7")]
	[FieldOffset(Offset = "0x34")]
	public int playersApartment;

	// Token: 0x040021A8 RID: 8616
	[Token(Token = "0x40021A8")]
	[FieldOffset(Offset = "0x38")]
	public List<CitySaveData.DistrictCitySave> districts;

	// Token: 0x040021A9 RID: 8617
	[Token(Token = "0x40021A9")]
	[FieldOffset(Offset = "0x40")]
	public List<CitySaveData.StreetCitySave> streets;

	// Token: 0x040021AA RID: 8618
	[Token(Token = "0x40021AA")]
	[FieldOffset(Offset = "0x48")]
	public List<CitySaveData.CityTileCitySave> cityTiles;

	// Token: 0x040021AB RID: 8619
	[Token(Token = "0x40021AB")]
	[FieldOffset(Offset = "0x50")]
	public List<CitySaveData.HumanCitySave> citizens;

	// Token: 0x040021AC RID: 8620
	[Token(Token = "0x40021AC")]
	[FieldOffset(Offset = "0x58")]
	public List<Interactable> interactables;

	// Token: 0x040021AD RID: 8621
	[Token(Token = "0x40021AD")]
	[FieldOffset(Offset = "0x60")]
	public List<GroupsController.SocialGroup> groups;

	// Token: 0x040021AE RID: 8622
	[Token(Token = "0x40021AE")]
	[FieldOffset(Offset = "0x68")]
	public List<PipeConstructor.PipeGroup> pipes;

	// Token: 0x040021AF RID: 8623
	[Token(Token = "0x40021AF")]
	[FieldOffset(Offset = "0x70")]
	public List<CitySaveData.OccupationCitySave> criminals;

	// Token: 0x040021B0 RID: 8624
	[Token(Token = "0x40021B0")]
	[FieldOffset(Offset = "0x78")]
	public List<CitySaveData.EvidenceStateSave> multiPage;

	// Token: 0x040021B1 RID: 8625
	[Token(Token = "0x40021B1")]
	[FieldOffset(Offset = "0x80")]
	public List<MetaObject> metas;

	// Token: 0x020004CA RID: 1226
	[Token(Token = "0x20004CA")]
	[Serializable]
	public class DistrictCitySave
	{
		// Token: 0x06001B6D RID: 7021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B6D")]
		[Address(RVA = "0x9BAB40", Offset = "0x9B9B40", VA = "0x1809BAB40")]
		public DistrictCitySave()
		{
		}

		// Token: 0x040021B2 RID: 8626
		[Token(Token = "0x40021B2")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040021B3 RID: 8627
		[Token(Token = "0x40021B3")]
		[FieldOffset(Offset = "0x18")]
		public string preset;

		// Token: 0x040021B4 RID: 8628
		[Token(Token = "0x40021B4")]
		[FieldOffset(Offset = "0x20")]
		public int districtID;

		// Token: 0x040021B5 RID: 8629
		[Token(Token = "0x40021B5")]
		[FieldOffset(Offset = "0x28")]
		public List<CitySaveData.BlockCitySave> blocks;

		// Token: 0x040021B6 RID: 8630
		[Token(Token = "0x40021B6")]
		[FieldOffset(Offset = "0x30")]
		public float averageLandValue;

		// Token: 0x040021B7 RID: 8631
		[Token(Token = "0x40021B7")]
		[FieldOffset(Offset = "0x38")]
		public List<SocialStatistics.EthnicityFrequency> dominantEthnicities;
	}

	// Token: 0x020004CB RID: 1227
	[Token(Token = "0x20004CB")]
	[Serializable]
	public class BlockCitySave
	{
		// Token: 0x06001B6E RID: 7022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public BlockCitySave()
		{
		}

		// Token: 0x040021B8 RID: 8632
		[Token(Token = "0x40021B8")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040021B9 RID: 8633
		[Token(Token = "0x40021B9")]
		[FieldOffset(Offset = "0x18")]
		public int blockID;

		// Token: 0x040021BA RID: 8634
		[Token(Token = "0x40021BA")]
		[FieldOffset(Offset = "0x1C")]
		public float averageDensity;

		// Token: 0x040021BB RID: 8635
		[Token(Token = "0x40021BB")]
		[FieldOffset(Offset = "0x20")]
		public float averageLandValue;
	}

	// Token: 0x020004CC RID: 1228
	[Token(Token = "0x20004CC")]
	[Serializable]
	public class CityTileCitySave
	{
		// Token: 0x06001B6F RID: 7023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x9BACB0", Offset = "0x9B9CB0", VA = "0x1809BACB0")]
		public CityTileCitySave()
		{
		}

		// Token: 0x040021BC RID: 8636
		[Token(Token = "0x40021BC")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040021BD RID: 8637
		[Token(Token = "0x40021BD")]
		[FieldOffset(Offset = "0x18")]
		public int blockID;

		// Token: 0x040021BE RID: 8638
		[Token(Token = "0x40021BE")]
		[FieldOffset(Offset = "0x1C")]
		public int districtID;

		// Token: 0x040021BF RID: 8639
		[Token(Token = "0x40021BF")]
		[FieldOffset(Offset = "0x20")]
		public Vector2Int cityCoord;

		// Token: 0x040021C0 RID: 8640
		[Token(Token = "0x40021C0")]
		[FieldOffset(Offset = "0x28")]
		public CitySaveData.BuildingCitySave building;

		// Token: 0x040021C1 RID: 8641
		[Token(Token = "0x40021C1")]
		[FieldOffset(Offset = "0x30")]
		public List<CitySaveData.TileCitySave> outsideTiles;

		// Token: 0x040021C2 RID: 8642
		[Token(Token = "0x40021C2")]
		[FieldOffset(Offset = "0x38")]
		public BuildingPreset.Density density;

		// Token: 0x040021C3 RID: 8643
		[Token(Token = "0x40021C3")]
		[FieldOffset(Offset = "0x3C")]
		public BuildingPreset.LandValue landValue;
	}

	// Token: 0x020004CD RID: 1229
	[Token(Token = "0x20004CD")]
	[Serializable]
	public class BuildingCitySave
	{
		// Token: 0x06001B70 RID: 7024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x9BAD80", Offset = "0x9B9D80", VA = "0x1809BAD80")]
		public BuildingCitySave()
		{
		}

		// Token: 0x040021C4 RID: 8644
		[Token(Token = "0x40021C4")]
		[FieldOffset(Offset = "0x10")]
		public int buildingID;

		// Token: 0x040021C5 RID: 8645
		[Token(Token = "0x40021C5")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040021C6 RID: 8646
		[Token(Token = "0x40021C6")]
		[FieldOffset(Offset = "0x20")]
		public List<CitySaveData.FloorCitySave> floors;

		// Token: 0x040021C7 RID: 8647
		[Token(Token = "0x40021C7")]
		[FieldOffset(Offset = "0x28")]
		public string preset;

		// Token: 0x040021C8 RID: 8648
		[Token(Token = "0x40021C8")]
		[FieldOffset(Offset = "0x30")]
		public NewBuilding.Direction facing;

		// Token: 0x040021C9 RID: 8649
		[Token(Token = "0x40021C9")]
		[FieldOffset(Offset = "0x34")]
		public bool isInaccessible;

		// Token: 0x040021CA RID: 8650
		[Token(Token = "0x40021CA")]
		[FieldOffset(Offset = "0x38")]
		public List<NewBuilding.SideSign> sideSigns;

		// Token: 0x040021CB RID: 8651
		[Token(Token = "0x40021CB")]
		[FieldOffset(Offset = "0x40")]
		public List<CitySaveData.AirDuctGroupCitySave> airDucts;

		// Token: 0x040021CC RID: 8652
		[Token(Token = "0x40021CC")]
		[FieldOffset(Offset = "0x48")]
		public string designStyle;

		// Token: 0x040021CD RID: 8653
		[Token(Token = "0x40021CD")]
		[FieldOffset(Offset = "0x50")]
		public Color wood;

		// Token: 0x040021CE RID: 8654
		[Token(Token = "0x40021CE")]
		[FieldOffset(Offset = "0x60")]
		public string floorMaterial;

		// Token: 0x040021CF RID: 8655
		[Token(Token = "0x40021CF")]
		[FieldOffset(Offset = "0x68")]
		public Toolbox.MaterialKey floorMatKey;

		// Token: 0x040021D0 RID: 8656
		[Token(Token = "0x40021D0")]
		[FieldOffset(Offset = "0x70")]
		public string ceilingMaterial;

		// Token: 0x040021D1 RID: 8657
		[Token(Token = "0x40021D1")]
		[FieldOffset(Offset = "0x78")]
		public Toolbox.MaterialKey ceilingMatKey;

		// Token: 0x040021D2 RID: 8658
		[Token(Token = "0x40021D2")]
		[FieldOffset(Offset = "0x80")]
		public string defaultWallMaterial;

		// Token: 0x040021D3 RID: 8659
		[Token(Token = "0x40021D3")]
		[FieldOffset(Offset = "0x88")]
		public Toolbox.MaterialKey defaultWallKey;

		// Token: 0x040021D4 RID: 8660
		[Token(Token = "0x40021D4")]
		[FieldOffset(Offset = "0x90")]
		public string extWallMaterial;

		// Token: 0x040021D5 RID: 8661
		[Token(Token = "0x40021D5")]
		[FieldOffset(Offset = "0x98")]
		public Toolbox.MaterialKey extWallKey;

		// Token: 0x040021D6 RID: 8662
		[Token(Token = "0x40021D6")]
		[FieldOffset(Offset = "0xA0")]
		public string colourScheme;

		// Token: 0x040021D7 RID: 8663
		[Token(Token = "0x40021D7")]
		[FieldOffset(Offset = "0xA8")]
		public string floorMatOverride;

		// Token: 0x040021D8 RID: 8664
		[Token(Token = "0x40021D8")]
		[FieldOffset(Offset = "0xB0")]
		public string ceilingMatOverride;

		// Token: 0x040021D9 RID: 8665
		[Token(Token = "0x40021D9")]
		[FieldOffset(Offset = "0xB8")]
		public string wallMatOverride;

		// Token: 0x040021DA RID: 8666
		[Token(Token = "0x40021DA")]
		[FieldOffset(Offset = "0xC0")]
		public string floorMatOverrideB;

		// Token: 0x040021DB RID: 8667
		[Token(Token = "0x40021DB")]
		[FieldOffset(Offset = "0xC8")]
		public string ceilingMatOverrideB;

		// Token: 0x040021DC RID: 8668
		[Token(Token = "0x40021DC")]
		[FieldOffset(Offset = "0xD0")]
		public string wallMatOverrideB;
	}

	// Token: 0x020004CE RID: 1230
	[Token(Token = "0x20004CE")]
	[Serializable]
	public class AirDuctGroupCitySave
	{
		// Token: 0x06001B71 RID: 7025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x9BAEF0", Offset = "0x9B9EF0", VA = "0x1809BAEF0")]
		public AirDuctGroupCitySave()
		{
		}

		// Token: 0x040021DD RID: 8669
		[Token(Token = "0x40021DD")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040021DE RID: 8670
		[Token(Token = "0x40021DE")]
		[FieldOffset(Offset = "0x14")]
		public bool ext;

		// Token: 0x040021DF RID: 8671
		[Token(Token = "0x40021DF")]
		[FieldOffset(Offset = "0x18")]
		public List<int> airVents;

		// Token: 0x040021E0 RID: 8672
		[Token(Token = "0x40021E0")]
		[FieldOffset(Offset = "0x20")]
		public List<CitySaveData.AirDuctSegmentCitySave> airDucts;

		// Token: 0x040021E1 RID: 8673
		[Token(Token = "0x40021E1")]
		[FieldOffset(Offset = "0x28")]
		public List<int> ventRooms;

		// Token: 0x040021E2 RID: 8674
		[Token(Token = "0x40021E2")]
		[FieldOffset(Offset = "0x30")]
		public List<int> adjoining;
	}

	// Token: 0x020004CF RID: 1231
	[Token(Token = "0x20004CF")]
	[Serializable]
	public class AirDuctSegmentCitySave
	{
		// Token: 0x06001B72 RID: 7026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B72")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public AirDuctSegmentCitySave()
		{
		}

		// Token: 0x040021E3 RID: 8675
		[Token(Token = "0x40021E3")]
		[FieldOffset(Offset = "0x10")]
		public int level;

		// Token: 0x040021E4 RID: 8676
		[Token(Token = "0x40021E4")]
		[FieldOffset(Offset = "0x14")]
		public int index;

		// Token: 0x040021E5 RID: 8677
		[Token(Token = "0x40021E5")]
		[FieldOffset(Offset = "0x18")]
		public Vector3Int duct;

		// Token: 0x040021E6 RID: 8678
		[Token(Token = "0x40021E6")]
		[FieldOffset(Offset = "0x24")]
		public Vector3Int previous;

		// Token: 0x040021E7 RID: 8679
		[Token(Token = "0x40021E7")]
		[FieldOffset(Offset = "0x30")]
		public Vector3Int next;

		// Token: 0x040021E8 RID: 8680
		[Token(Token = "0x40021E8")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3Int node;

		// Token: 0x040021E9 RID: 8681
		[Token(Token = "0x40021E9")]
		[FieldOffset(Offset = "0x48")]
		public bool peek;

		// Token: 0x040021EA RID: 8682
		[Token(Token = "0x40021EA")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3Int addRot;
	}

	// Token: 0x020004D0 RID: 1232
	[Token(Token = "0x20004D0")]
	[Serializable]
	public class AirVentSave
	{
		// Token: 0x06001B73 RID: 7027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B73")]
		[Address(RVA = "0x9BB130", Offset = "0x9BA130", VA = "0x1809BB130")]
		public AirVentSave()
		{
		}

		// Token: 0x040021EB RID: 8683
		[Token(Token = "0x40021EB")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040021EC RID: 8684
		[Token(Token = "0x40021EC")]
		[FieldOffset(Offset = "0x14")]
		public NewAddress.AirVent ventType;

		// Token: 0x040021ED RID: 8685
		[Token(Token = "0x40021ED")]
		[FieldOffset(Offset = "0x18")]
		public int wall;

		// Token: 0x040021EE RID: 8686
		[Token(Token = "0x40021EE")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3Int node;

		// Token: 0x040021EF RID: 8687
		[Token(Token = "0x40021EF")]
		[FieldOffset(Offset = "0x28")]
		public Vector3Int rNode;
	}

	// Token: 0x020004D1 RID: 1233
	[Token(Token = "0x20004D1")]
	[Serializable]
	public class FloorCitySave
	{
		// Token: 0x06001B74 RID: 7028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B74")]
		[Address(RVA = "0x9BB140", Offset = "0x9BA140", VA = "0x1809BB140")]
		public FloorCitySave()
		{
		}

		// Token: 0x040021F0 RID: 8688
		[Token(Token = "0x40021F0")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040021F1 RID: 8689
		[Token(Token = "0x40021F1")]
		[FieldOffset(Offset = "0x18")]
		public int floorID;

		// Token: 0x040021F2 RID: 8690
		[Token(Token = "0x40021F2")]
		[FieldOffset(Offset = "0x1C")]
		public int floor;

		// Token: 0x040021F3 RID: 8691
		[Token(Token = "0x40021F3")]
		[FieldOffset(Offset = "0x20")]
		public List<CitySaveData.AddressCitySave> addresses;

		// Token: 0x040021F4 RID: 8692
		[Token(Token = "0x40021F4")]
		[FieldOffset(Offset = "0x28")]
		public List<CitySaveData.TileCitySave> tiles;

		// Token: 0x040021F5 RID: 8693
		[Token(Token = "0x40021F5")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 size;

		// Token: 0x040021F6 RID: 8694
		[Token(Token = "0x40021F6")]
		[FieldOffset(Offset = "0x38")]
		public int defaultFloorHeight;

		// Token: 0x040021F7 RID: 8695
		[Token(Token = "0x40021F7")]
		[FieldOffset(Offset = "0x3C")]
		public int defaultCeilingHeight;

		// Token: 0x040021F8 RID: 8696
		[Token(Token = "0x40021F8")]
		[FieldOffset(Offset = "0x40")]
		public int layoutIndex;

		// Token: 0x040021F9 RID: 8697
		[Token(Token = "0x40021F9")]
		[FieldOffset(Offset = "0x44")]
		public bool echelons;

		// Token: 0x040021FA RID: 8698
		[Token(Token = "0x40021FA")]
		[FieldOffset(Offset = "0x48")]
		public int breakerSec;

		// Token: 0x040021FB RID: 8699
		[Token(Token = "0x40021FB")]
		[FieldOffset(Offset = "0x4C")]
		public int breakerLights;

		// Token: 0x040021FC RID: 8700
		[Token(Token = "0x40021FC")]
		[FieldOffset(Offset = "0x50")]
		public int breakerDoors;
	}

	// Token: 0x020004D2 RID: 1234
	[Token(Token = "0x20004D2")]
	[Serializable]
	public class TileCitySave
	{
		// Token: 0x06001B75 RID: 7029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public TileCitySave()
		{
		}

		// Token: 0x040021FD RID: 8701
		[Token(Token = "0x40021FD")]
		[FieldOffset(Offset = "0x10")]
		public int tileID;

		// Token: 0x040021FE RID: 8702
		[Token(Token = "0x40021FE")]
		[FieldOffset(Offset = "0x14")]
		public Vector2Int floorCoord;

		// Token: 0x040021FF RID: 8703
		[Token(Token = "0x40021FF")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3Int globalTileCoord;

		// Token: 0x04002200 RID: 8704
		[Token(Token = "0x4002200")]
		[FieldOffset(Offset = "0x28")]
		public bool isEdge;

		// Token: 0x04002201 RID: 8705
		[Token(Token = "0x4002201")]
		[FieldOffset(Offset = "0x2C")]
		public int rotation;

		// Token: 0x04002202 RID: 8706
		[Token(Token = "0x4002202")]
		[FieldOffset(Offset = "0x30")]
		public bool isEntrance;

		// Token: 0x04002203 RID: 8707
		[Token(Token = "0x4002203")]
		[FieldOffset(Offset = "0x31")]
		public bool isMainEntrance;

		// Token: 0x04002204 RID: 8708
		[Token(Token = "0x4002204")]
		[FieldOffset(Offset = "0x32")]
		public bool isStairwell;

		// Token: 0x04002205 RID: 8709
		[Token(Token = "0x4002205")]
		[FieldOffset(Offset = "0x34")]
		public int stairwellRotation;

		// Token: 0x04002206 RID: 8710
		[Token(Token = "0x4002206")]
		[FieldOffset(Offset = "0x38")]
		public bool isElevator;

		// Token: 0x04002207 RID: 8711
		[Token(Token = "0x4002207")]
		[FieldOffset(Offset = "0x3C")]
		public int elevatorRotation;

		// Token: 0x04002208 RID: 8712
		[Token(Token = "0x4002208")]
		[FieldOffset(Offset = "0x40")]
		public bool isTop;

		// Token: 0x04002209 RID: 8713
		[Token(Token = "0x4002209")]
		[FieldOffset(Offset = "0x41")]
		public bool isBottom;
	}

	// Token: 0x020004D3 RID: 1235
	[Token(Token = "0x20004D3")]
	[Serializable]
	public class StreetCitySave
	{
		// Token: 0x06001B76 RID: 7030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B76")]
		[Address(RVA = "0x9BB2E0", Offset = "0x9BA2E0", VA = "0x1809BB2E0")]
		public StreetCitySave()
		{
		}

		// Token: 0x0400220A RID: 8714
		[Token(Token = "0x400220A")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400220B RID: 8715
		[Token(Token = "0x400220B")]
		[FieldOffset(Offset = "0x18")]
		public AddressPreset.AccessType access;

		// Token: 0x0400220C RID: 8716
		[Token(Token = "0x400220C")]
		[FieldOffset(Offset = "0x20")]
		public List<CitySaveData.RoomCitySave> rooms;

		// Token: 0x0400220D RID: 8717
		[Token(Token = "0x400220D")]
		[FieldOffset(Offset = "0x28")]
		public string designStyle;

		// Token: 0x0400220E RID: 8718
		[Token(Token = "0x400220E")]
		[FieldOffset(Offset = "0x30")]
		public int streetID;

		// Token: 0x0400220F RID: 8719
		[Token(Token = "0x400220F")]
		[FieldOffset(Offset = "0x34")]
		public int district;

		// Token: 0x04002210 RID: 8720
		[Token(Token = "0x4002210")]
		[FieldOffset(Offset = "0x38")]
		public List<Vector3Int> tiles;

		// Token: 0x04002211 RID: 8721
		[Token(Token = "0x4002211")]
		[FieldOffset(Offset = "0x40")]
		public string streetSuffix;

		// Token: 0x04002212 RID: 8722
		[Token(Token = "0x4002212")]
		[FieldOffset(Offset = "0x48")]
		public bool isAlley;

		// Token: 0x04002213 RID: 8723
		[Token(Token = "0x4002213")]
		[FieldOffset(Offset = "0x49")]
		public bool isBackstreet;

		// Token: 0x04002214 RID: 8724
		[Token(Token = "0x4002214")]
		[FieldOffset(Offset = "0x50")]
		public List<int> sharedGround;

		// Token: 0x04002215 RID: 8725
		[Token(Token = "0x4002215")]
		[FieldOffset(Offset = "0x58")]
		public List<StreetController.StreetTile> streetTiles;
	}

	// Token: 0x020004D4 RID: 1236
	[Token(Token = "0x20004D4")]
	[Serializable]
	public class AddressCitySave
	{
		// Token: 0x06001B77 RID: 7031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B77")]
		[Address(RVA = "0x9BB4C0", Offset = "0x9BA4C0", VA = "0x1809BB4C0")]
		public AddressCitySave()
		{
		}

		// Token: 0x04002216 RID: 8726
		[Token(Token = "0x4002216")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04002217 RID: 8727
		[Token(Token = "0x4002217")]
		[FieldOffset(Offset = "0x18")]
		public int residenceNumber;

		// Token: 0x04002218 RID: 8728
		[Token(Token = "0x4002218")]
		[FieldOffset(Offset = "0x1C")]
		public bool isLobby;

		// Token: 0x04002219 RID: 8729
		[Token(Token = "0x4002219")]
		[FieldOffset(Offset = "0x1D")]
		public bool isOutside;

		// Token: 0x0400221A RID: 8730
		[Token(Token = "0x400221A")]
		[FieldOffset(Offset = "0x20")]
		public AddressPreset.AccessType access;

		// Token: 0x0400221B RID: 8731
		[Token(Token = "0x400221B")]
		[FieldOffset(Offset = "0x28")]
		public List<CitySaveData.RoomCitySave> rooms;

		// Token: 0x0400221C RID: 8732
		[Token(Token = "0x400221C")]
		[FieldOffset(Offset = "0x30")]
		public string designStyle;

		// Token: 0x0400221D RID: 8733
		[Token(Token = "0x400221D")]
		[FieldOffset(Offset = "0x38")]
		public bool neonHor;

		// Token: 0x0400221E RID: 8734
		[Token(Token = "0x400221E")]
		[FieldOffset(Offset = "0x39")]
		public bool neonVer;

		// Token: 0x0400221F RID: 8735
		[Token(Token = "0x400221F")]
		[FieldOffset(Offset = "0x3C")]
		public int neonVerticalIndex;

		// Token: 0x04002220 RID: 8736
		[Token(Token = "0x4002220")]
		[FieldOffset(Offset = "0x40")]
		public int neonColour;

		// Token: 0x04002221 RID: 8737
		[Token(Token = "0x4002221")]
		[FieldOffset(Offset = "0x48")]
		public string neonFont;

		// Token: 0x04002222 RID: 8738
		[Token(Token = "0x4002222")]
		[FieldOffset(Offset = "0x50")]
		public float landValue;

		// Token: 0x04002223 RID: 8739
		[Token(Token = "0x4002223")]
		[FieldOffset(Offset = "0x58")]
		public GameplayController.Passcode passcode;

		// Token: 0x04002224 RID: 8740
		[Token(Token = "0x4002224")]
		[FieldOffset(Offset = "0x60")]
		public List<Vector3> protectedNodes;

		// Token: 0x04002225 RID: 8741
		[Token(Token = "0x4002225")]
		[FieldOffset(Offset = "0x68")]
		public int id;

		// Token: 0x04002226 RID: 8742
		[Token(Token = "0x4002226")]
		[FieldOffset(Offset = "0x70")]
		public string address;

		// Token: 0x04002227 RID: 8743
		[Token(Token = "0x4002227")]
		[FieldOffset(Offset = "0x78")]
		public string preset;

		// Token: 0x04002228 RID: 8744
		[Token(Token = "0x4002228")]
		[FieldOffset(Offset = "0x80")]
		public Color wood;

		// Token: 0x04002229 RID: 8745
		[Token(Token = "0x4002229")]
		[FieldOffset(Offset = "0x90")]
		public CitySaveData.ResidenceCitySave residence;

		// Token: 0x0400222A RID: 8746
		[Token(Token = "0x400222A")]
		[FieldOffset(Offset = "0x98")]
		public CitySaveData.CompanyCitySave company;

		// Token: 0x0400222B RID: 8747
		[Token(Token = "0x400222B")]
		[FieldOffset(Offset = "0xA0")]
		public bool isOutsideAddress;

		// Token: 0x0400222C RID: 8748
		[Token(Token = "0x400222C")]
		[FieldOffset(Offset = "0xA1")]
		public bool isLobbyAddress;

		// Token: 0x0400222D RID: 8749
		[Token(Token = "0x400222D")]
		[FieldOffset(Offset = "0xA4")]
		public int breakerSec;

		// Token: 0x0400222E RID: 8750
		[Token(Token = "0x400222E")]
		[FieldOffset(Offset = "0xA8")]
		public int breakerLights;

		// Token: 0x0400222F RID: 8751
		[Token(Token = "0x400222F")]
		[FieldOffset(Offset = "0xAC")]
		public int breakerDoors;
	}

	// Token: 0x020004D5 RID: 1237
	[Token(Token = "0x20004D5")]
	[Serializable]
	public class ResidenceCitySave
	{
		// Token: 0x06001B78 RID: 7032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ResidenceCitySave()
		{
		}

		// Token: 0x04002230 RID: 8752
		[Token(Token = "0x4002230")]
		[FieldOffset(Offset = "0x10")]
		public string preset;

		// Token: 0x04002231 RID: 8753
		[Token(Token = "0x4002231")]
		[FieldOffset(Offset = "0x18")]
		public int mail;
	}

	// Token: 0x020004D6 RID: 1238
	[Token(Token = "0x20004D6")]
	[Serializable]
	public class CompanyCitySave
	{
		// Token: 0x06001B79 RID: 7033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B79")]
		[Address(RVA = "0x9BB650", Offset = "0x9BA650", VA = "0x1809BB650")]
		public CompanyCitySave()
		{
		}

		// Token: 0x04002232 RID: 8754
		[Token(Token = "0x4002232")]
		[FieldOffset(Offset = "0x10")]
		public string preset;

		// Token: 0x04002233 RID: 8755
		[Token(Token = "0x4002233")]
		[FieldOffset(Offset = "0x18")]
		public int id;

		// Token: 0x04002234 RID: 8756
		[Token(Token = "0x4002234")]
		[FieldOffset(Offset = "0x20")]
		public List<CitySaveData.OccupationCitySave> companyRoster;

		// Token: 0x04002235 RID: 8757
		[Token(Token = "0x4002235")]
		[FieldOffset(Offset = "0x28")]
		public string shortName;

		// Token: 0x04002236 RID: 8758
		[Token(Token = "0x4002236")]
		[FieldOffset(Offset = "0x30")]
		public List<string> nameAltTags;

		// Token: 0x04002237 RID: 8759
		[Token(Token = "0x4002237")]
		[FieldOffset(Offset = "0x38")]
		public int passedWorkLocation;

		// Token: 0x04002238 RID: 8760
		[Token(Token = "0x4002238")]
		[FieldOffset(Offset = "0x40")]
		public List<string> menuItems;

		// Token: 0x04002239 RID: 8761
		[Token(Token = "0x4002239")]
		[FieldOffset(Offset = "0x48")]
		public List<int> itemCosts;
	}

	// Token: 0x020004D7 RID: 1239
	[Token(Token = "0x20004D7")]
	[Serializable]
	public class OccupationCitySave
	{
		// Token: 0x06001B7A RID: 7034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7A")]
		[Address(RVA = "0x9BB860", Offset = "0x9BA860", VA = "0x1809BB860")]
		public OccupationCitySave()
		{
		}

		// Token: 0x0400223A RID: 8762
		[Token(Token = "0x400223A")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x0400223B RID: 8763
		[Token(Token = "0x400223B")]
		[FieldOffset(Offset = "0x18")]
		public string preset;

		// Token: 0x0400223C RID: 8764
		[Token(Token = "0x400223C")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x0400223D RID: 8765
		[Token(Token = "0x400223D")]
		[FieldOffset(Offset = "0x28")]
		public bool teamLeader;

		// Token: 0x0400223E RID: 8766
		[Token(Token = "0x400223E")]
		[FieldOffset(Offset = "0x2C")]
		public int boss;

		// Token: 0x0400223F RID: 8767
		[Token(Token = "0x400223F")]
		[FieldOffset(Offset = "0x30")]
		public float paygrade;

		// Token: 0x04002240 RID: 8768
		[Token(Token = "0x4002240")]
		[FieldOffset(Offset = "0x34")]
		public int teamID;

		// Token: 0x04002241 RID: 8769
		[Token(Token = "0x4002241")]
		[FieldOffset(Offset = "0x38")]
		public bool isOwner;

		// Token: 0x04002242 RID: 8770
		[Token(Token = "0x4002242")]
		[FieldOffset(Offset = "0x3C")]
		public OccupationPreset.workType work;

		// Token: 0x04002243 RID: 8771
		[Token(Token = "0x4002243")]
		[FieldOffset(Offset = "0x40")]
		public List<OccupationPreset.workTags> tags;

		// Token: 0x04002244 RID: 8772
		[Token(Token = "0x4002244")]
		[FieldOffset(Offset = "0x48")]
		public int shift;

		// Token: 0x04002245 RID: 8773
		[Token(Token = "0x4002245")]
		[FieldOffset(Offset = "0x4C")]
		public float startTime;

		// Token: 0x04002246 RID: 8774
		[Token(Token = "0x4002246")]
		[FieldOffset(Offset = "0x50")]
		public float endTime;

		// Token: 0x04002247 RID: 8775
		[Token(Token = "0x4002247")]
		[FieldOffset(Offset = "0x58")]
		public List<SessionData.WeekDay> workDaysList;

		// Token: 0x04002248 RID: 8776
		[Token(Token = "0x4002248")]
		[FieldOffset(Offset = "0x60")]
		public float salary;

		// Token: 0x04002249 RID: 8777
		[Token(Token = "0x4002249")]
		[FieldOffset(Offset = "0x68")]
		public string salaryString;
	}

	// Token: 0x020004D8 RID: 1240
	[Token(Token = "0x20004D8")]
	[Serializable]
	public class RoomCitySave
	{
		// Token: 0x06001B7B RID: 7035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7B")]
		[Address(RVA = "0x9BBAC0", Offset = "0x9BAAC0", VA = "0x1809BBAC0")]
		public RoomCitySave()
		{
		}

		// Token: 0x0400224A RID: 8778
		[Token(Token = "0x400224A")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400224B RID: 8779
		[Token(Token = "0x400224B")]
		[FieldOffset(Offset = "0x18")]
		public List<CitySaveData.NodeCitySave> nodes;

		// Token: 0x0400224C RID: 8780
		[Token(Token = "0x400224C")]
		[FieldOffset(Offset = "0x20")]
		public List<string> openPlanElements;

		// Token: 0x0400224D RID: 8781
		[Token(Token = "0x400224D")]
		[FieldOffset(Offset = "0x28")]
		public List<CitySaveData.LightZoneSave> lightZones;

		// Token: 0x0400224E RID: 8782
		[Token(Token = "0x400224E")]
		[FieldOffset(Offset = "0x30")]
		public List<int> commonRooms;

		// Token: 0x0400224F RID: 8783
		[Token(Token = "0x400224F")]
		[FieldOffset(Offset = "0x38")]
		public int floorID;

		// Token: 0x04002250 RID: 8784
		[Token(Token = "0x4002250")]
		[FieldOffset(Offset = "0x3C")]
		public int id;

		// Token: 0x04002251 RID: 8785
		[Token(Token = "0x4002251")]
		[FieldOffset(Offset = "0x40")]
		public int fID;

		// Token: 0x04002252 RID: 8786
		[Token(Token = "0x4002252")]
		[FieldOffset(Offset = "0x44")]
		public int iID;

		// Token: 0x04002253 RID: 8787
		[Token(Token = "0x4002253")]
		[FieldOffset(Offset = "0x48")]
		public string preset;

		// Token: 0x04002254 RID: 8788
		[Token(Token = "0x4002254")]
		[FieldOffset(Offset = "0x50")]
		public bool reachableFromEntrance;

		// Token: 0x04002255 RID: 8789
		[Token(Token = "0x4002255")]
		[FieldOffset(Offset = "0x51")]
		public bool isOutsideWindow;

		// Token: 0x04002256 RID: 8790
		[Token(Token = "0x4002256")]
		[FieldOffset(Offset = "0x52")]
		public bool allowCoving;

		// Token: 0x04002257 RID: 8791
		[Token(Token = "0x4002257")]
		[FieldOffset(Offset = "0x58")]
		public string floorMaterial;

		// Token: 0x04002258 RID: 8792
		[Token(Token = "0x4002258")]
		[FieldOffset(Offset = "0x60")]
		public Toolbox.MaterialKey floorMatKey;

		// Token: 0x04002259 RID: 8793
		[Token(Token = "0x4002259")]
		[FieldOffset(Offset = "0x68")]
		public string ceilingMaterial;

		// Token: 0x0400225A RID: 8794
		[Token(Token = "0x400225A")]
		[FieldOffset(Offset = "0x70")]
		public Toolbox.MaterialKey ceilingMatKey;

		// Token: 0x0400225B RID: 8795
		[Token(Token = "0x400225B")]
		[FieldOffset(Offset = "0x78")]
		public string defaultWallMaterial;

		// Token: 0x0400225C RID: 8796
		[Token(Token = "0x400225C")]
		[FieldOffset(Offset = "0x80")]
		public Toolbox.MaterialKey defaultWallKey;

		// Token: 0x0400225D RID: 8797
		[Token(Token = "0x400225D")]
		[FieldOffset(Offset = "0x88")]
		public Toolbox.MaterialKey miscKey;

		// Token: 0x0400225E RID: 8798
		[Token(Token = "0x400225E")]
		[FieldOffset(Offset = "0x90")]
		public string colourScheme;

		// Token: 0x0400225F RID: 8799
		[Token(Token = "0x400225F")]
		[FieldOffset(Offset = "0x98")]
		public string mainLightPreset;

		// Token: 0x04002260 RID: 8800
		[Token(Token = "0x4002260")]
		[FieldOffset(Offset = "0xA0")]
		public bool isBaseNullRoom;

		// Token: 0x04002261 RID: 8801
		[Token(Token = "0x4002261")]
		[FieldOffset(Offset = "0xA4")]
		public Vector3 middle;

		// Token: 0x04002262 RID: 8802
		[Token(Token = "0x4002262")]
		[FieldOffset(Offset = "0xB0")]
		public List<CitySaveData.FurnitureClusterCitySave> f;

		// Token: 0x04002263 RID: 8803
		[Token(Token = "0x4002263")]
		[FieldOffset(Offset = "0xB8")]
		public List<int> owners;

		// Token: 0x04002264 RID: 8804
		[Token(Token = "0x4002264")]
		[FieldOffset(Offset = "0xC0")]
		public List<CitySaveData.AirVentSave> airVents;

		// Token: 0x04002265 RID: 8805
		[Token(Token = "0x4002265")]
		[FieldOffset(Offset = "0xC8")]
		public GameplayController.Passcode password;

		// Token: 0x04002266 RID: 8806
		[Token(Token = "0x4002266")]
		[FieldOffset(Offset = "0xD0")]
		public int cf;

		// Token: 0x04002267 RID: 8807
		[Token(Token = "0x4002267")]
		[FieldOffset(Offset = "0xD8")]
		public List<CitySaveData.CullTreeSave> cullTree;

		// Token: 0x04002268 RID: 8808
		[Token(Token = "0x4002268")]
		[FieldOffset(Offset = "0xE0")]
		public List<int> above;

		// Token: 0x04002269 RID: 8809
		[Token(Token = "0x4002269")]
		[FieldOffset(Offset = "0xE8")]
		public List<int> below;

		// Token: 0x0400226A RID: 8810
		[Token(Token = "0x400226A")]
		[FieldOffset(Offset = "0xF0")]
		public List<int> adj;

		// Token: 0x0400226B RID: 8811
		[Token(Token = "0x400226B")]
		[FieldOffset(Offset = "0xF8")]
		public List<int> occ;
	}

	// Token: 0x020004D9 RID: 1241
	[Token(Token = "0x20004D9")]
	[Serializable]
	public class CullTreeSave
	{
		// Token: 0x06001B7C RID: 7036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public CullTreeSave()
		{
		}

		// Token: 0x0400226C RID: 8812
		[Token(Token = "0x400226C")]
		[FieldOffset(Offset = "0x10")]
		public int r;

		// Token: 0x0400226D RID: 8813
		[Token(Token = "0x400226D")]
		[FieldOffset(Offset = "0x18")]
		public List<int> d;
	}

	// Token: 0x020004DA RID: 1242
	[Token(Token = "0x20004DA")]
	[Serializable]
	public class LightZoneSave
	{
		// Token: 0x06001B7D RID: 7037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7D")]
		[Address(RVA = "0x9BC1A0", Offset = "0x9BB1A0", VA = "0x1809BC1A0")]
		public LightZoneSave()
		{
		}

		// Token: 0x0400226E RID: 8814
		[Token(Token = "0x400226E")]
		[FieldOffset(Offset = "0x10")]
		public List<Vector3Int> n;

		// Token: 0x0400226F RID: 8815
		[Token(Token = "0x400226F")]
		[FieldOffset(Offset = "0x18")]
		public Color areaLightColour;

		// Token: 0x04002270 RID: 8816
		[Token(Token = "0x4002270")]
		[FieldOffset(Offset = "0x28")]
		public float areaLightBright;
	}

	// Token: 0x020004DB RID: 1243
	[Token(Token = "0x20004DB")]
	[Serializable]
	public class NodeCitySave
	{
		// Token: 0x06001B7E RID: 7038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7E")]
		[Address(RVA = "0x9BC260", Offset = "0x9BB260", VA = "0x1809BC260")]
		public NodeCitySave()
		{
		}

		// Token: 0x04002271 RID: 8817
		[Token(Token = "0x4002271")]
		[FieldOffset(Offset = "0x10")]
		public Vector3Int nc;

		// Token: 0x04002272 RID: 8818
		[Token(Token = "0x4002272")]
		[FieldOffset(Offset = "0x20")]
		public List<CitySaveData.WallCitySave> w;

		// Token: 0x04002273 RID: 8819
		[Token(Token = "0x4002273")]
		[FieldOffset(Offset = "0x28")]
		public NewNode.FloorTileType ft;

		// Token: 0x04002274 RID: 8820
		[Token(Token = "0x4002274")]
		[FieldOffset(Offset = "0x30")]
		public string fr;

		// Token: 0x04002275 RID: 8821
		[Token(Token = "0x4002275")]
		[FieldOffset(Offset = "0x38")]
		public string frr;
	}

	// Token: 0x020004DC RID: 1244
	[Token(Token = "0x20004DC")]
	[Serializable]
	public class WallCitySave
	{
		// Token: 0x06001B7F RID: 7039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7F")]
		[Address(RVA = "0x9BC330", Offset = "0x9BB330", VA = "0x1809BC330")]
		public WallCitySave()
		{
		}

		// Token: 0x04002276 RID: 8822
		[Token(Token = "0x4002276")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 wo;

		// Token: 0x04002277 RID: 8823
		[Token(Token = "0x4002277")]
		[FieldOffset(Offset = "0x18")]
		public int id;

		// Token: 0x04002278 RID: 8824
		[Token(Token = "0x4002278")]
		[FieldOffset(Offset = "0x20")]
		public string p;

		// Token: 0x04002279 RID: 8825
		[Token(Token = "0x4002279")]
		[FieldOffset(Offset = "0x28")]
		public int ow;

		// Token: 0x0400227A RID: 8826
		[Token(Token = "0x400227A")]
		[FieldOffset(Offset = "0x2C")]
		public int pw;

		// Token: 0x0400227B RID: 8827
		[Token(Token = "0x400227B")]
		[FieldOffset(Offset = "0x30")]
		public int cw;

		// Token: 0x0400227C RID: 8828
		[Token(Token = "0x400227C")]
		[FieldOffset(Offset = "0x34")]
		public bool oo;

		// Token: 0x0400227D RID: 8829
		[Token(Token = "0x400227D")]
		[FieldOffset(Offset = "0x35")]
		public bool oa;

		// Token: 0x0400227E RID: 8830
		[Token(Token = "0x400227E")]
		[FieldOffset(Offset = "0x38")]
		public int cl;

		// Token: 0x0400227F RID: 8831
		[Token(Token = "0x400227F")]
		[FieldOffset(Offset = "0x3C")]
		public bool sw;

		// Token: 0x04002280 RID: 8832
		[Token(Token = "0x4002280")]
		[FieldOffset(Offset = "0x40")]
		public List<CitySaveData.WallFrontageSave> fr;

		// Token: 0x04002281 RID: 8833
		[Token(Token = "0x4002281")]
		[FieldOffset(Offset = "0x48")]
		public bool dm;

		// Token: 0x04002282 RID: 8834
		[Token(Token = "0x4002282")]
		[FieldOffset(Offset = "0x50")]
		public Toolbox.MaterialKey dmk;

		// Token: 0x04002283 RID: 8835
		[Token(Token = "0x4002283")]
		[FieldOffset(Offset = "0x58")]
		public float ds;

		// Token: 0x04002284 RID: 8836
		[Token(Token = "0x4002284")]
		[FieldOffset(Offset = "0x5C")]
		public float ls;
	}

	// Token: 0x020004DD RID: 1245
	[Token(Token = "0x20004DD")]
	[Serializable]
	public class WallFrontageSave
	{
		// Token: 0x06001B80 RID: 7040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B80")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public WallFrontageSave()
		{
		}

		// Token: 0x04002285 RID: 8837
		[Token(Token = "0x4002285")]
		[FieldOffset(Offset = "0x10")]
		public string str;

		// Token: 0x04002286 RID: 8838
		[Token(Token = "0x4002286")]
		[FieldOffset(Offset = "0x18")]
		public Toolbox.MaterialKey matKey;

		// Token: 0x04002287 RID: 8839
		[Token(Token = "0x4002287")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 o;
	}

	// Token: 0x020004DE RID: 1246
	[Token(Token = "0x20004DE")]
	[Serializable]
	public class FurnitureClusterCitySave
	{
		// Token: 0x06001B81 RID: 7041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B81")]
		[Address(RVA = "0x9BC410", Offset = "0x9BB410", VA = "0x1809BC410")]
		public FurnitureClusterCitySave()
		{
		}

		// Token: 0x04002288 RID: 8840
		[Token(Token = "0x4002288")]
		[FieldOffset(Offset = "0x10")]
		public string cluster;

		// Token: 0x04002289 RID: 8841
		[Token(Token = "0x4002289")]
		[FieldOffset(Offset = "0x18")]
		public Vector3Int anchorNode;

		// Token: 0x0400228A RID: 8842
		[Token(Token = "0x400228A")]
		[FieldOffset(Offset = "0x24")]
		public int angle;

		// Token: 0x0400228B RID: 8843
		[Token(Token = "0x400228B")]
		[FieldOffset(Offset = "0x28")]
		public List<CitySaveData.FurnitureClusterObjectCitySave> objs;
	}

	// Token: 0x020004DF RID: 1247
	[Token(Token = "0x20004DF")]
	[Serializable]
	public class FurnitureClusterObjectCitySave
	{
		// Token: 0x06001B82 RID: 7042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B82")]
		[Address(RVA = "0x9BC4E0", Offset = "0x9BB4E0", VA = "0x1809BC4E0")]
		public FurnitureClusterObjectCitySave()
		{
		}

		// Token: 0x0400228C RID: 8844
		[Token(Token = "0x400228C")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x0400228D RID: 8845
		[Token(Token = "0x400228D")]
		[FieldOffset(Offset = "0x18")]
		public List<string> furnitureClasses;

		// Token: 0x0400228E RID: 8846
		[Token(Token = "0x400228E")]
		[FieldOffset(Offset = "0x20")]
		public int angle;

		// Token: 0x0400228F RID: 8847
		[Token(Token = "0x400228F")]
		[FieldOffset(Offset = "0x24")]
		public Vector3Int anchorNode;

		// Token: 0x04002290 RID: 8848
		[Token(Token = "0x4002290")]
		[FieldOffset(Offset = "0x30")]
		public List<Vector3Int> coversNodes;

		// Token: 0x04002291 RID: 8849
		[Token(Token = "0x4002291")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 offset;

		// Token: 0x04002292 RID: 8850
		[Token(Token = "0x4002292")]
		[FieldOffset(Offset = "0x48")]
		public string furniture;

		// Token: 0x04002293 RID: 8851
		[Token(Token = "0x4002293")]
		[FieldOffset(Offset = "0x50")]
		public string art;

		// Token: 0x04002294 RID: 8852
		[Token(Token = "0x4002294")]
		[FieldOffset(Offset = "0x58")]
		public bool up;

		// Token: 0x04002295 RID: 8853
		[Token(Token = "0x4002295")]
		[FieldOffset(Offset = "0x5C")]
		public Vector3 scale;

		// Token: 0x04002296 RID: 8854
		[Token(Token = "0x4002296")]
		[FieldOffset(Offset = "0x68")]
		public Toolbox.MaterialKey matKey;

		// Token: 0x04002297 RID: 8855
		[Token(Token = "0x4002297")]
		[FieldOffset(Offset = "0x70")]
		public Toolbox.MaterialKey artMatKet;

		// Token: 0x04002298 RID: 8856
		[Token(Token = "0x4002298")]
		[FieldOffset(Offset = "0x78")]
		public List<int> owners;
	}

	// Token: 0x020004E0 RID: 1248
	[Token(Token = "0x20004E0")]
	[Serializable]
	public class HumanCitySave
	{
		// Token: 0x06001B83 RID: 7043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B83")]
		[Address(RVA = "0x9BC5A0", Offset = "0x9BB5A0", VA = "0x1809BC5A0")]
		public HumanCitySave()
		{
		}

		// Token: 0x04002299 RID: 8857
		[Token(Token = "0x4002299")]
		[FieldOffset(Offset = "0x10")]
		public int humanID;

		// Token: 0x0400229A RID: 8858
		[Token(Token = "0x400229A")]
		[FieldOffset(Offset = "0x14")]
		public int home;

		// Token: 0x0400229B RID: 8859
		[Token(Token = "0x400229B")]
		[FieldOffset(Offset = "0x18")]
		public float speedModifier;

		// Token: 0x0400229C RID: 8860
		[Token(Token = "0x400229C")]
		[FieldOffset(Offset = "0x1C")]
		public int job;

		// Token: 0x0400229D RID: 8861
		[Token(Token = "0x400229D")]
		[FieldOffset(Offset = "0x20")]
		public string birthday;

		// Token: 0x0400229E RID: 8862
		[Token(Token = "0x400229E")]
		[FieldOffset(Offset = "0x28")]
		public float societalClass;

		// Token: 0x0400229F RID: 8863
		[Token(Token = "0x400229F")]
		[FieldOffset(Offset = "0x30")]
		public Descriptors descriptors;

		// Token: 0x040022A0 RID: 8864
		[Token(Token = "0x40022A0")]
		[FieldOffset(Offset = "0x38")]
		public Human.BloodType blood;

		// Token: 0x040022A1 RID: 8865
		[Token(Token = "0x40022A1")]
		[FieldOffset(Offset = "0x40")]
		public string citizenName;

		// Token: 0x040022A2 RID: 8866
		[Token(Token = "0x40022A2")]
		[FieldOffset(Offset = "0x48")]
		public string firstName;

		// Token: 0x040022A3 RID: 8867
		[Token(Token = "0x40022A3")]
		[FieldOffset(Offset = "0x50")]
		public string casualName;

		// Token: 0x040022A4 RID: 8868
		[Token(Token = "0x40022A4")]
		[FieldOffset(Offset = "0x58")]
		public string surName;

		// Token: 0x040022A5 RID: 8869
		[Token(Token = "0x40022A5")]
		[FieldOffset(Offset = "0x60")]
		public bool homeless;

		// Token: 0x040022A6 RID: 8870
		[Token(Token = "0x40022A6")]
		[FieldOffset(Offset = "0x64")]
		public float slangUsage;

		// Token: 0x040022A7 RID: 8871
		[Token(Token = "0x40022A7")]
		[FieldOffset(Offset = "0x68")]
		public float genderScale;

		// Token: 0x040022A8 RID: 8872
		[Token(Token = "0x40022A8")]
		[FieldOffset(Offset = "0x6C")]
		public Human.Gender gender;

		// Token: 0x040022A9 RID: 8873
		[Token(Token = "0x40022A9")]
		[FieldOffset(Offset = "0x70")]
		public Human.Gender bGender;

		// Token: 0x040022AA RID: 8874
		[Token(Token = "0x40022AA")]
		[FieldOffset(Offset = "0x74")]
		public float sexuality;

		// Token: 0x040022AB RID: 8875
		[Token(Token = "0x40022AB")]
		[FieldOffset(Offset = "0x78")]
		public float homosexuality;

		// Token: 0x040022AC RID: 8876
		[Token(Token = "0x40022AC")]
		[FieldOffset(Offset = "0x80")]
		public List<Human.Gender> attractedTo;

		// Token: 0x040022AD RID: 8877
		[Token(Token = "0x40022AD")]
		[FieldOffset(Offset = "0x88")]
		public int partner;

		// Token: 0x040022AE RID: 8878
		[Token(Token = "0x40022AE")]
		[FieldOffset(Offset = "0x8C")]
		public int paramour;

		// Token: 0x040022AF RID: 8879
		[Token(Token = "0x40022AF")]
		[FieldOffset(Offset = "0x90")]
		public string anniversary;

		// Token: 0x040022B0 RID: 8880
		[Token(Token = "0x40022B0")]
		[FieldOffset(Offset = "0x98")]
		public float sleepNeedMultiplier;

		// Token: 0x040022B1 RID: 8881
		[Token(Token = "0x40022B1")]
		[FieldOffset(Offset = "0x9C")]
		public float snoring;

		// Token: 0x040022B2 RID: 8882
		[Token(Token = "0x40022B2")]
		[FieldOffset(Offset = "0xA0")]
		public float snoreDelay;

		// Token: 0x040022B3 RID: 8883
		[Token(Token = "0x40022B3")]
		[FieldOffset(Offset = "0xA4")]
		public float humility;

		// Token: 0x040022B4 RID: 8884
		[Token(Token = "0x40022B4")]
		[FieldOffset(Offset = "0xA8")]
		public float emotionality;

		// Token: 0x040022B5 RID: 8885
		[Token(Token = "0x40022B5")]
		[FieldOffset(Offset = "0xAC")]
		public float extraversion;

		// Token: 0x040022B6 RID: 8886
		[Token(Token = "0x40022B6")]
		[FieldOffset(Offset = "0xB0")]
		public float agreeableness;

		// Token: 0x040022B7 RID: 8887
		[Token(Token = "0x40022B7")]
		[FieldOffset(Offset = "0xB4")]
		public float conscientiousness;

		// Token: 0x040022B8 RID: 8888
		[Token(Token = "0x40022B8")]
		[FieldOffset(Offset = "0xB8")]
		public float creativity;

		// Token: 0x040022B9 RID: 8889
		[Token(Token = "0x40022B9")]
		[FieldOffset(Offset = "0xC0")]
		public List<CitySaveData.AcquaintanceCitySave> acquaintances;

		// Token: 0x040022BA RID: 8890
		[Token(Token = "0x40022BA")]
		[FieldOffset(Offset = "0xC8")]
		public List<CitySaveData.CharTraitSave> traits;

		// Token: 0x040022BB RID: 8891
		[Token(Token = "0x40022BB")]
		[FieldOffset(Offset = "0xD0")]
		public GameplayController.Passcode password;

		// Token: 0x040022BC RID: 8892
		[Token(Token = "0x40022BC")]
		[FieldOffset(Offset = "0xD8")]
		public float maxHealth;

		// Token: 0x040022BD RID: 8893
		[Token(Token = "0x40022BD")]
		[FieldOffset(Offset = "0xDC")]
		public float recoveryRate;

		// Token: 0x040022BE RID: 8894
		[Token(Token = "0x40022BE")]
		[FieldOffset(Offset = "0xE0")]
		public float combatSkill;

		// Token: 0x040022BF RID: 8895
		[Token(Token = "0x40022BF")]
		[FieldOffset(Offset = "0xE4")]
		public float combatHeft;

		// Token: 0x040022C0 RID: 8896
		[Token(Token = "0x40022C0")]
		[FieldOffset(Offset = "0xE8")]
		public float maxNerve;

		// Token: 0x040022C1 RID: 8897
		[Token(Token = "0x40022C1")]
		[FieldOffset(Offset = "0xEC")]
		public float breathRecovery;

		// Token: 0x040022C2 RID: 8898
		[Token(Token = "0x40022C2")]
		[FieldOffset(Offset = "0xF0")]
		public string handwriting;

		// Token: 0x040022C3 RID: 8899
		[Token(Token = "0x40022C3")]
		[FieldOffset(Offset = "0xF8")]
		public int sightingMemory;

		// Token: 0x040022C4 RID: 8900
		[Token(Token = "0x40022C4")]
		[FieldOffset(Offset = "0x100")]
		public List<string> favItems;

		// Token: 0x040022C5 RID: 8901
		[Token(Token = "0x40022C5")]
		[FieldOffset(Offset = "0x108")]
		public List<int> favItemRanks;

		// Token: 0x040022C6 RID: 8902
		[Token(Token = "0x40022C6")]
		[FieldOffset(Offset = "0x110")]
		public List<CompanyPreset.CompanyCategory> favCat;

		// Token: 0x040022C7 RID: 8903
		[Token(Token = "0x40022C7")]
		[FieldOffset(Offset = "0x118")]
		public List<int> favAddresses;

		// Token: 0x040022C8 RID: 8904
		[Token(Token = "0x40022C8")]
		[FieldOffset(Offset = "0x120")]
		public List<CitizenOutfitController.Outfit> outfits;

		// Token: 0x040022C9 RID: 8905
		[Token(Token = "0x40022C9")]
		[FieldOffset(Offset = "0x128")]
		public int favCol;
	}

	// Token: 0x020004E1 RID: 1249
	[Token(Token = "0x20004E1")]
	[Serializable]
	public class CharTraitSave
	{
		// Token: 0x06001B84 RID: 7044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x791A40", Offset = "0x790A40", VA = "0x180791A40")]
		public CharTraitSave()
		{
		}

		// Token: 0x040022CA RID: 8906
		[Token(Token = "0x40022CA")]
		[FieldOffset(Offset = "0x10")]
		public int traitID;

		// Token: 0x040022CB RID: 8907
		[Token(Token = "0x40022CB")]
		[FieldOffset(Offset = "0x18")]
		public string trait;

		// Token: 0x040022CC RID: 8908
		[Token(Token = "0x40022CC")]
		[FieldOffset(Offset = "0x20")]
		public int reason;

		// Token: 0x040022CD RID: 8909
		[Token(Token = "0x40022CD")]
		[FieldOffset(Offset = "0x28")]
		public string date;
	}

	// Token: 0x020004E2 RID: 1250
	[Token(Token = "0x20004E2")]
	[Serializable]
	public class AcquaintanceCitySave
	{
		// Token: 0x06001B85 RID: 7045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x9BCCD0", Offset = "0x9BBCD0", VA = "0x1809BCCD0")]
		public AcquaintanceCitySave()
		{
		}

		// Token: 0x040022CE RID: 8910
		[Token(Token = "0x40022CE")]
		[FieldOffset(Offset = "0x10")]
		public int from;

		// Token: 0x040022CF RID: 8911
		[Token(Token = "0x40022CF")]
		[FieldOffset(Offset = "0x14")]
		public int with;

		// Token: 0x040022D0 RID: 8912
		[Token(Token = "0x40022D0")]
		[FieldOffset(Offset = "0x18")]
		public List<Acquaintance.ConnectionType> connections;

		// Token: 0x040022D1 RID: 8913
		[Token(Token = "0x40022D1")]
		[FieldOffset(Offset = "0x20")]
		public Acquaintance.ConnectionType secret;

		// Token: 0x040022D2 RID: 8914
		[Token(Token = "0x40022D2")]
		[FieldOffset(Offset = "0x24")]
		public float compatible;

		// Token: 0x040022D3 RID: 8915
		[Token(Token = "0x40022D3")]
		[FieldOffset(Offset = "0x28")]
		public float known;

		// Token: 0x040022D4 RID: 8916
		[Token(Token = "0x40022D4")]
		[FieldOffset(Offset = "0x2C")]
		public float like;

		// Token: 0x040022D5 RID: 8917
		[Token(Token = "0x40022D5")]
		[FieldOffset(Offset = "0x30")]
		public List<Evidence.DataKey> dataKeys;
	}

	// Token: 0x020004E3 RID: 1251
	[Token(Token = "0x20004E3")]
	[Serializable]
	public class EvidenceStateSave
	{
		// Token: 0x06001B86 RID: 7046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B86")]
		[Address(RVA = "0x9BCE60", Offset = "0x9BBE60", VA = "0x1809BCE60")]
		public EvidenceStateSave()
		{
		}

		// Token: 0x040022D6 RID: 8918
		[Token(Token = "0x40022D6")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040022D7 RID: 8919
		[Token(Token = "0x40022D7")]
		[FieldOffset(Offset = "0x18")]
		public int page;

		// Token: 0x040022D8 RID: 8920
		[Token(Token = "0x40022D8")]
		[FieldOffset(Offset = "0x20")]
		public List<EvidenceMultiPage.MultiPageContent> mpContent;
	}
}
