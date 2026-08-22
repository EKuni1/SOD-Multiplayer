using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000788 RID: 1928
[Token(Token = "0x2000788")]
public class BuildingPreset : SoCustomComparison
{
	// Token: 0x06002917 RID: 10519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002917")]
	[Address(RVA = "0xC691A0", Offset = "0xC681A0", VA = "0x180C691A0")]
	public void GenerateWindowData()
	{
	}

	// Token: 0x06002918 RID: 10520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002918")]
	[Address(RVA = "0xC6BA90", Offset = "0xC6AA90", VA = "0x180C6BA90")]
	public void GenerateAddonData()
	{
	}

	// Token: 0x06002919 RID: 10521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002919")]
	[Address(RVA = "0xC6D220", Offset = "0xC6C220", VA = "0x180C6D220")]
	public void CalculateMeshHeight()
	{
	}

	// Token: 0x0600291A RID: 10522 RVA: 0x0000F768 File Offset: 0x0000D968
	[Token(Token = "0x600291A")]
	[Address(RVA = "0xC6D770", Offset = "0xC6C770", VA = "0x180C6D770")]
	public Vector3 UvTo3D(Vector2 uv)
	{
		return default(Vector3);
	}

	// Token: 0x0600291B RID: 10523 RVA: 0x0000F780 File Offset: 0x0000D980
	[Token(Token = "0x600291B")]
	[Address(RVA = "0x964920", Offset = "0x963920", VA = "0x180964920")]
	public float Area(Vector2 p1, Vector2 p2, Vector2 p3)
	{
		return 0f;
	}

	// Token: 0x0600291C RID: 10524 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600291C")]
	[Address(RVA = "0xC6DCD0", Offset = "0xC6CCD0", VA = "0x180C6DCD0")]
	public BuildingPreset.InteriorFloorSetting GetFloorSetting(int floor, int index)
	{
		return null;
	}

	// Token: 0x0600291D RID: 10525 RVA: 0x0000F798 File Offset: 0x0000D998
	[Token(Token = "0x600291D")]
	[Address(RVA = "0xC6DD80", Offset = "0xC6CD80", VA = "0x180C6DD80")]
	public int GetResidenceCount()
	{
		return 0;
	}

	// Token: 0x0600291E RID: 10526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600291E")]
	[Address(RVA = "0xC6E660", Offset = "0xC6D660", VA = "0x180C6E660")]
	public BuildingPreset()
	{
	}

	// Token: 0x0400372B RID: 14123
	[Token(Token = "0x400372B")]
	[FieldOffset(Offset = "0x20")]
	public bool disable;

	// Token: 0x0400372C RID: 14124
	[Token(Token = "0x400372C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject prefab;

	// Token: 0x0400372D RID: 14125
	[Token(Token = "0x400372D")]
	[FieldOffset(Offset = "0x30")]
	public Texture2D emissionMapUnlit;

	// Token: 0x0400372E RID: 14126
	[Token(Token = "0x400372E")]
	[FieldOffset(Offset = "0x38")]
	public Texture2D emissionMapLit;

	// Token: 0x0400372F RID: 14127
	[Token(Token = "0x400372F")]
	[FieldOffset(Offset = "0x40")]
	public float buildingHeight;

	// Token: 0x04003730 RID: 14128
	[Token(Token = "0x4003730")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 lightningRodLocalPos;

	// Token: 0x04003731 RID: 14129
	[Token(Token = "0x4003731")]
	[FieldOffset(Offset = "0x50")]
	public List<MaterialGroupPreset> defaultExteriorWallMaterial;

	// Token: 0x04003732 RID: 14130
	[Token(Token = "0x4003732")]
	[FieldOffset(Offset = "0x58")]
	public Toolbox.MaterialKey exteriorKey;

	// Token: 0x04003733 RID: 14131
	[Token(Token = "0x4003733")]
	[FieldOffset(Offset = "0x60")]
	public bool enableAlleywayWalls;

	// Token: 0x04003734 RID: 14132
	[Token(Token = "0x4003734")]
	[FieldOffset(Offset = "0x61")]
	public bool enableExteriorQuoins;

	// Token: 0x04003735 RID: 14133
	[Token(Token = "0x4003735")]
	[FieldOffset(Offset = "0x62")]
	public bool overrideEvidencePhotoSettings;

	// Token: 0x04003736 RID: 14134
	[Token(Token = "0x4003736")]
	[FieldOffset(Offset = "0x64")]
	public Vector3 relativeCamPhotoPos;

	// Token: 0x04003737 RID: 14135
	[Token(Token = "0x4003737")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 relativeCamPhotoEuler;

	// Token: 0x04003738 RID: 14136
	[Token(Token = "0x4003738")]
	[FieldOffset(Offset = "0x7C")]
	public bool overrideDistrictEnvironment;

	// Token: 0x04003739 RID: 14137
	[Token(Token = "0x4003739")]
	[FieldOffset(Offset = "0x80")]
	public SessionData.SceneProfile sceneProfile;

	// Token: 0x0400373A RID: 14138
	[Token(Token = "0x400373A")]
	[FieldOffset(Offset = "0x84")]
	public int maxLostAndFound;

	// Token: 0x0400373B RID: 14139
	[Token(Token = "0x400373B")]
	[FieldOffset(Offset = "0x88")]
	public List<BuildingPreset.InteriorFloorSetting> floorLayouts;

	// Token: 0x0400373C RID: 14140
	[Token(Token = "0x400373C")]
	[FieldOffset(Offset = "0x90")]
	public List<BuildingPreset.InteriorFloorSetting> basementLayouts;

	// Token: 0x0400373D RID: 14141
	[Token(Token = "0x400373D")]
	[FieldOffset(Offset = "0x98")]
	public Vector2 controlRoomRange;

	// Token: 0x0400373E RID: 14142
	[Token(Token = "0x400373E")]
	[FieldOffset(Offset = "0xA0")]
	public List<DesignStylePreset> forceBuildingDesignStyles;

	// Token: 0x0400373F RID: 14143
	[Token(Token = "0x400373F")]
	[FieldOffset(Offset = "0xA8")]
	public StairwellPreset stairwellRegular;

	// Token: 0x04003740 RID: 14144
	[Token(Token = "0x4003740")]
	[FieldOffset(Offset = "0xB0")]
	public StairwellPreset stairwellLarge;

	// Token: 0x04003741 RID: 14145
	[Token(Token = "0x4003741")]
	[FieldOffset(Offset = "0xB8")]
	public bool buildingFeaturesEchelonFloors;

	// Token: 0x04003742 RID: 14146
	[Token(Token = "0x4003742")]
	[FieldOffset(Offset = "0xBC")]
	public int echelonFloorStart;

	// Token: 0x04003743 RID: 14147
	[Token(Token = "0x4003743")]
	[FieldOffset(Offset = "0xC0")]
	public bool overrideGrubiness;

	// Token: 0x04003744 RID: 14148
	[Token(Token = "0x4003744")]
	[FieldOffset(Offset = "0xC4")]
	public float grubinessOverride;

	// Token: 0x04003745 RID: 14149
	[Token(Token = "0x4003745")]
	[FieldOffset(Offset = "0xC8")]
	public BuildingPreset.ZoneType displayedZone;

	// Token: 0x04003746 RID: 14150
	[Token(Token = "0x4003746")]
	[FieldOffset(Offset = "0xCC")]
	public bool allowedInAllDistricts;

	// Token: 0x04003747 RID: 14151
	[Token(Token = "0x4003747")]
	[FieldOffset(Offset = "0xD0")]
	public List<DistrictPreset> allowedInDistricts;

	// Token: 0x04003748 RID: 14152
	[Token(Token = "0x4003748")]
	[FieldOffset(Offset = "0xD8")]
	public BuildingPreset.Density densityMinimum;

	// Token: 0x04003749 RID: 14153
	[Token(Token = "0x4003749")]
	[FieldOffset(Offset = "0xDC")]
	public BuildingPreset.Density densityMaximum;

	// Token: 0x0400374A RID: 14154
	[Token(Token = "0x400374A")]
	[FieldOffset(Offset = "0xE0")]
	public BuildingPreset.LandValue landValueMinimum;

	// Token: 0x0400374B RID: 14155
	[Token(Token = "0x400374B")]
	[FieldOffset(Offset = "0xE4")]
	public BuildingPreset.LandValue landValueMaximum;

	// Token: 0x0400374C RID: 14156
	[Token(Token = "0x400374C")]
	[FieldOffset(Offset = "0xE8")]
	public int minimum;

	// Token: 0x0400374D RID: 14157
	[Token(Token = "0x400374D")]
	[FieldOffset(Offset = "0xEC")]
	public int featureImportance;

	// Token: 0x0400374E RID: 14158
	[Token(Token = "0x400374E")]
	[FieldOffset(Offset = "0xF0")]
	public int hardLimit;

	// Token: 0x0400374F RID: 14159
	[Token(Token = "0x400374F")]
	[FieldOffset(Offset = "0xF4")]
	public float desiredRatio;

	// Token: 0x04003750 RID: 14160
	[Token(Token = "0x4003750")]
	[FieldOffset(Offset = "0xF8")]
	public int modernity;

	// Token: 0x04003751 RID: 14161
	[Token(Token = "0x4003751")]
	[FieldOffset(Offset = "0x100")]
	public AddressPreset lobbyPreset;

	// Token: 0x04003752 RID: 14162
	[Token(Token = "0x4003752")]
	[FieldOffset(Offset = "0x108")]
	public bool nonEnterable;

	// Token: 0x04003753 RID: 14163
	[Token(Token = "0x4003753")]
	[FieldOffset(Offset = "0x109")]
	public bool boundary;

	// Token: 0x04003754 RID: 14164
	[Token(Token = "0x4003754")]
	[FieldOffset(Offset = "0x10A")]
	public bool boundaryCorner;

	// Token: 0x04003755 RID: 14165
	[Token(Token = "0x4003755")]
	[FieldOffset(Offset = "0x10B")]
	public bool overrideNaming;

	// Token: 0x04003756 RID: 14166
	[Token(Token = "0x4003756")]
	[FieldOffset(Offset = "0x110")]
	public List<string> possibleNames;

	// Token: 0x04003757 RID: 14167
	[Token(Token = "0x4003757")]
	[FieldOffset(Offset = "0x118")]
	public bool customDrawOnMap;

	// Token: 0x04003758 RID: 14168
	[Token(Token = "0x4003758")]
	[FieldOffset(Offset = "0x120")]
	public Texture2D tex;

	// Token: 0x04003759 RID: 14169
	[Token(Token = "0x4003759")]
	[FieldOffset(Offset = "0x128")]
	public Mesh captureMesh;

	// Token: 0x0400375A RID: 14170
	[Token(Token = "0x400375A")]
	[FieldOffset(Offset = "0x130")]
	public Texture2D windowMap;

	// Token: 0x0400375B RID: 14171
	[Token(Token = "0x400375B")]
	[FieldOffset(Offset = "0x138")]
	public Texture2D addonMap;

	// Token: 0x0400375C RID: 14172
	[Token(Token = "0x400375C")]
	[FieldOffset(Offset = "0x140")]
	public List<BuildingPreset.WindowUVFloor> sortedWindows;

	// Token: 0x0400375D RID: 14173
	[Token(Token = "0x400375D")]
	[FieldOffset(Offset = "0x148")]
	public int floorCount;

	// Token: 0x0400375E RID: 14174
	[Token(Token = "0x400375E")]
	[FieldOffset(Offset = "0x14C")]
	public float meshHeight;

	// Token: 0x0400375F RID: 14175
	[Token(Token = "0x400375F")]
	[FieldOffset(Offset = "0x150")]
	public List<BuildingPreset.CableLinkPoint> cableLinkPoints;

	// Token: 0x04003760 RID: 14176
	[Token(Token = "0x4003760")]
	[FieldOffset(Offset = "0x158")]
	public AnimationCurve cableSpawnChanceOverHeight;

	// Token: 0x04003761 RID: 14177
	[Token(Token = "0x4003761")]
	[FieldOffset(Offset = "0x160")]
	public List<BuildingPreset.CableLinkPoint> sideSignPoints;

	// Token: 0x04003762 RID: 14178
	[Token(Token = "0x4003762")]
	[FieldOffset(Offset = "0x168")]
	public List<GameObject> possibleNeonSigns;

	// Token: 0x04003763 RID: 14179
	[Token(Token = "0x4003763")]
	[FieldOffset(Offset = "0x170")]
	public Vector2 signsPerBuildingRange;

	// Token: 0x04003764 RID: 14180
	[Token(Token = "0x4003764")]
	[FieldOffset(Offset = "0x178")]
	public Vector3 horizontalSignOffset;

	// Token: 0x04003765 RID: 14181
	[Token(Token = "0x4003765")]
	[FieldOffset(Offset = "0x184")]
	public bool featuresSmokestack;

	// Token: 0x04003766 RID: 14182
	[Token(Token = "0x4003766")]
	[FieldOffset(Offset = "0x188")]
	public Vector2 spawnInterval;

	// Token: 0x04003767 RID: 14183
	[Token(Token = "0x4003767")]
	[FieldOffset(Offset = "0x190")]
	public GameObject spritePrefab;

	// Token: 0x04003768 RID: 14184
	[Token(Token = "0x4003768")]
	[FieldOffset(Offset = "0x198")]
	public Vector3 spawnOffset;

	// Token: 0x04003769 RID: 14185
	[Token(Token = "0x4003769")]
	[FieldOffset(Offset = "0x1A8")]
	private Vector2[] offsetArrayX4;

	// Token: 0x02000789 RID: 1929
	[Token(Token = "0x2000789")]
	public enum Density
	{
		// Token: 0x0400376B RID: 14187
		[Token(Token = "0x400376B")]
		low,
		// Token: 0x0400376C RID: 14188
		[Token(Token = "0x400376C")]
		medium,
		// Token: 0x0400376D RID: 14189
		[Token(Token = "0x400376D")]
		high,
		// Token: 0x0400376E RID: 14190
		[Token(Token = "0x400376E")]
		veryHigh
	}

	// Token: 0x0200078A RID: 1930
	[Token(Token = "0x200078A")]
	public enum LandValue
	{
		// Token: 0x04003770 RID: 14192
		[Token(Token = "0x4003770")]
		veryLow,
		// Token: 0x04003771 RID: 14193
		[Token(Token = "0x4003771")]
		low,
		// Token: 0x04003772 RID: 14194
		[Token(Token = "0x4003772")]
		medium,
		// Token: 0x04003773 RID: 14195
		[Token(Token = "0x4003773")]
		high,
		// Token: 0x04003774 RID: 14196
		[Token(Token = "0x4003774")]
		veryHigh
	}

	// Token: 0x0200078B RID: 1931
	[Token(Token = "0x200078B")]
	[Serializable]
	public class InteriorFloorSetting
	{
		// Token: 0x0600291F RID: 10527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291F")]
		[Address(RVA = "0xC6EEA0", Offset = "0xC6DEA0", VA = "0x180C6EEA0")]
		public InteriorFloorSetting()
		{
		}

		// Token: 0x04003775 RID: 14197
		[Token(Token = "0x4003775")]
		[FieldOffset(Offset = "0x10")]
		public int floorsWithThisSetting;

		// Token: 0x04003776 RID: 14198
		[Token(Token = "0x4003776")]
		[FieldOffset(Offset = "0x18")]
		public List<TextAsset> blueprints;

		// Token: 0x04003777 RID: 14199
		[Token(Token = "0x4003777")]
		[FieldOffset(Offset = "0x20")]
		public int airVentMaximumExtrusion;

		// Token: 0x04003778 RID: 14200
		[Token(Token = "0x4003778")]
		[FieldOffset(Offset = "0x28")]
		public List<TextAsset> controlRoomVariants;

		// Token: 0x04003779 RID: 14201
		[Token(Token = "0x4003779")]
		[FieldOffset(Offset = "0x30")]
		public bool forceShowModel;

		// Token: 0x0400377A RID: 14202
		[Token(Token = "0x400377A")]
		[FieldOffset(Offset = "0x38")]
		public List<string> forceHideModels;

		// Token: 0x0400377B RID: 14203
		[Token(Token = "0x400377B")]
		[FieldOffset(Offset = "0x40")]
		public List<BuildingPreset.ForceHideModelsForRoom> forceHideModelsInRooms;

		// Token: 0x0400377C RID: 14204
		[Token(Token = "0x400377C")]
		[FieldOffset(Offset = "0x48")]
		public List<string> forceHideModelsOutside;

		// Token: 0x0400377D RID: 14205
		[Token(Token = "0x400377D")]
		[FieldOffset(Offset = "0x50")]
		public bool overrideCeilingHeight;

		// Token: 0x0400377E RID: 14206
		[Token(Token = "0x400377E")]
		[FieldOffset(Offset = "0x54")]
		public int newCeilingHeight;
	}

	// Token: 0x0200078C RID: 1932
	[Token(Token = "0x200078C")]
	[Serializable]
	public class ForceHideModelsForRoom
	{
		// Token: 0x06002920 RID: 10528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002920")]
		[Address(RVA = "0xC6F1A0", Offset = "0xC6E1A0", VA = "0x180C6F1A0")]
		public ForceHideModelsForRoom()
		{
		}

		// Token: 0x0400377F RID: 14207
		[Token(Token = "0x400377F")]
		[FieldOffset(Offset = "0x10")]
		public RoomConfiguration roomConfig;

		// Token: 0x04003780 RID: 14208
		[Token(Token = "0x4003780")]
		[FieldOffset(Offset = "0x18")]
		public List<string> forceHideModels;
	}

	// Token: 0x0200078D RID: 1933
	[Token(Token = "0x200078D")]
	public enum ZoneType
	{
		// Token: 0x04003782 RID: 14210
		[Token(Token = "0x4003782")]
		residential,
		// Token: 0x04003783 RID: 14211
		[Token(Token = "0x4003783")]
		commercial,
		// Token: 0x04003784 RID: 14212
		[Token(Token = "0x4003784")]
		industrial,
		// Token: 0x04003785 RID: 14213
		[Token(Token = "0x4003785")]
		municipal,
		// Token: 0x04003786 RID: 14214
		[Token(Token = "0x4003786")]
		publicProperty,
		// Token: 0x04003787 RID: 14215
		[Token(Token = "0x4003787")]
		privateProperty
	}

	// Token: 0x0200078E RID: 1934
	[Token(Token = "0x200078E")]
	[Serializable]
	public struct CableLinkPoint
	{
		// Token: 0x04003788 RID: 14216
		[Token(Token = "0x4003788")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 localPos;

		// Token: 0x04003789 RID: 14217
		[Token(Token = "0x4003789")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 localRot;
	}

	// Token: 0x0200078F RID: 1935
	[Token(Token = "0x200078F")]
	[Serializable]
	public class WindowUVFloor
	{
		// Token: 0x06002921 RID: 10529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002921")]
		[Address(RVA = "0xC6F270", Offset = "0xC6E270", VA = "0x180C6F270")]
		public WindowUVFloor()
		{
		}

		// Token: 0x0400378A RID: 14218
		[Token(Token = "0x400378A")]
		[FieldOffset(Offset = "0x10")]
		public List<BuildingPreset.WindowUVBlock> front;

		// Token: 0x0400378B RID: 14219
		[Token(Token = "0x400378B")]
		[FieldOffset(Offset = "0x18")]
		public List<BuildingPreset.WindowUVBlock> back;

		// Token: 0x0400378C RID: 14220
		[Token(Token = "0x400378C")]
		[FieldOffset(Offset = "0x20")]
		public List<BuildingPreset.WindowUVBlock> left;

		// Token: 0x0400378D RID: 14221
		[Token(Token = "0x400378D")]
		[FieldOffset(Offset = "0x28")]
		public List<BuildingPreset.WindowUVBlock> right;
	}

	// Token: 0x02000790 RID: 1936
	[Token(Token = "0x2000790")]
	[Serializable]
	public class WindowUVBlock
	{
		// Token: 0x06002922 RID: 10530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002922")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public WindowUVBlock()
		{
		}

		// Token: 0x0400378E RID: 14222
		[Token(Token = "0x400378E")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 originPixel;

		// Token: 0x0400378F RID: 14223
		[Token(Token = "0x400378F")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 rectSize;

		// Token: 0x04003790 RID: 14224
		[Token(Token = "0x4003790")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 centrePixel;

		// Token: 0x04003791 RID: 14225
		[Token(Token = "0x4003791")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 localMeshPositionLeft;

		// Token: 0x04003792 RID: 14226
		[Token(Token = "0x4003792")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 localMeshPositionRight;

		// Token: 0x04003793 RID: 14227
		[Token(Token = "0x4003793")]
		[FieldOffset(Offset = "0x40")]
		public int floor;

		// Token: 0x04003794 RID: 14228
		[Token(Token = "0x4003794")]
		[FieldOffset(Offset = "0x44")]
		public Vector2 side;

		// Token: 0x04003795 RID: 14229
		[Token(Token = "0x4003795")]
		[FieldOffset(Offset = "0x4C")]
		public int horizonal;
	}

	// Token: 0x02000791 RID: 1937
	[Token(Token = "0x2000791")]
	private sealed class <>c__DisplayClass71_0
	{
		// Token: 0x06002923 RID: 10531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002923")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass71_0()
		{
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		[Token(Token = "0x6002924")]
		[Address(RVA = "0xC6F4B0", Offset = "0xC6E4B0", VA = "0x180C6F4B0")]
		internal bool <GenerateWindowData>b__1(BuildingPreset.WindowUVBlock item)
		{
			return default(bool);
		}

		// Token: 0x04003796 RID: 14230
		[Token(Token = "0x4003796")]
		[FieldOffset(Offset = "0x10")]
		public BuildingPreset.WindowUVBlock thisBlock;
	}

	// Token: 0x02000792 RID: 1938
	[Token(Token = "0x2000792")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002926 RID: 10534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002926")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		[Token(Token = "0x6002927")]
		[Address(RVA = "0x481F30", Offset = "0x480F30", VA = "0x180481F30")]
		internal int <GenerateWindowData>b__71_0(BuildingPreset.WindowUVBlock p1, BuildingPreset.WindowUVBlock p2)
		{
			return 0;
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		[Token(Token = "0x6002928")]
		[Address(RVA = "0xC6F670", Offset = "0xC6E670", VA = "0x180C6F670")]
		internal bool <GenerateWindowData>b__71_2(BuildingPreset.WindowUVBlock item)
		{
			return default(bool);
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
		[Token(Token = "0x6002929")]
		[Address(RVA = "0xA12170", Offset = "0xA11170", VA = "0x180A12170")]
		internal int <GenerateWindowData>b__71_3(BuildingPreset.WindowUVBlock p1, BuildingPreset.WindowUVBlock p2)
		{
			return 0;
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x0000F810 File Offset: 0x0000DA10
		[Token(Token = "0x600292A")]
		[Address(RVA = "0xC6F6C0", Offset = "0xC6E6C0", VA = "0x180C6F6C0")]
		internal bool <GenerateWindowData>b__71_4(BuildingPreset.WindowUVBlock item)
		{
			return default(bool);
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x0000F828 File Offset: 0x0000DA28
		[Token(Token = "0x600292B")]
		[Address(RVA = "0xA12170", Offset = "0xA11170", VA = "0x180A12170")]
		internal int <GenerateWindowData>b__71_5(BuildingPreset.WindowUVBlock p1, BuildingPreset.WindowUVBlock p2)
		{
			return 0;
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x0000F840 File Offset: 0x0000DA40
		[Token(Token = "0x600292C")]
		[Address(RVA = "0xC6F710", Offset = "0xC6E710", VA = "0x180C6F710")]
		internal bool <GenerateWindowData>b__71_6(BuildingPreset.WindowUVBlock item)
		{
			return default(bool);
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x0000F858 File Offset: 0x0000DA58
		[Token(Token = "0x600292D")]
		[Address(RVA = "0xC6F760", Offset = "0xC6E760", VA = "0x180C6F760")]
		internal int <GenerateWindowData>b__71_7(BuildingPreset.WindowUVBlock p1, BuildingPreset.WindowUVBlock p2)
		{
			return 0;
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x0000F870 File Offset: 0x0000DA70
		[Token(Token = "0x600292E")]
		[Address(RVA = "0xC6F7F0", Offset = "0xC6E7F0", VA = "0x180C6F7F0")]
		internal bool <GenerateWindowData>b__71_8(BuildingPreset.WindowUVBlock item)
		{
			return default(bool);
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x0000F888 File Offset: 0x0000DA88
		[Token(Token = "0x600292F")]
		[Address(RVA = "0xC6F760", Offset = "0xC6E760", VA = "0x180C6F760")]
		internal int <GenerateWindowData>b__71_9(BuildingPreset.WindowUVBlock p1, BuildingPreset.WindowUVBlock p2)
		{
			return 0;
		}

		// Token: 0x04003797 RID: 14231
		[Token(Token = "0x4003797")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BuildingPreset.<>c <>9;

		// Token: 0x04003798 RID: 14232
		[Token(Token = "0x4003798")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<BuildingPreset.WindowUVBlock> <>9__71_0;

		// Token: 0x04003799 RID: 14233
		[Token(Token = "0x4003799")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<BuildingPreset.WindowUVBlock> <>9__71_2;

		// Token: 0x0400379A RID: 14234
		[Token(Token = "0x400379A")]
		[FieldOffset(Offset = "0x18")]
		public static Comparison<BuildingPreset.WindowUVBlock> <>9__71_3;

		// Token: 0x0400379B RID: 14235
		[Token(Token = "0x400379B")]
		[FieldOffset(Offset = "0x20")]
		public static Predicate<BuildingPreset.WindowUVBlock> <>9__71_4;

		// Token: 0x0400379C RID: 14236
		[Token(Token = "0x400379C")]
		[FieldOffset(Offset = "0x28")]
		public static Comparison<BuildingPreset.WindowUVBlock> <>9__71_5;

		// Token: 0x0400379D RID: 14237
		[Token(Token = "0x400379D")]
		[FieldOffset(Offset = "0x30")]
		public static Predicate<BuildingPreset.WindowUVBlock> <>9__71_6;

		// Token: 0x0400379E RID: 14238
		[Token(Token = "0x400379E")]
		[FieldOffset(Offset = "0x38")]
		public static Comparison<BuildingPreset.WindowUVBlock> <>9__71_7;

		// Token: 0x0400379F RID: 14239
		[Token(Token = "0x400379F")]
		[FieldOffset(Offset = "0x40")]
		public static Predicate<BuildingPreset.WindowUVBlock> <>9__71_8;

		// Token: 0x040037A0 RID: 14240
		[Token(Token = "0x40037A0")]
		[FieldOffset(Offset = "0x48")]
		public static Comparison<BuildingPreset.WindowUVBlock> <>9__71_9;
	}
}
