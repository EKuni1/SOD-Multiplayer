using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007F1 RID: 2033
[Token(Token = "0x20007F1")]
public class FurnitureCluster : SoCustomComparison
{
	// Token: 0x0600297F RID: 10623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600297F")]
	[Address(RVA = "0xCA78E0", Offset = "0xCA68E0", VA = "0x180CA78E0")]
	public void UpdatePreCalculatedLimits()
	{
	}

	// Token: 0x06002980 RID: 10624 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002980")]
	[Address(RVA = "0xCA7E90", Offset = "0xCA6E90", VA = "0x180CA7E90")]
	public FurnitureCluster()
	{
	}

	// Token: 0x04003B4B RID: 15179
	[Token(Token = "0x4003B4B")]
	[FieldOffset(Offset = "0x20")]
	public bool disable;

	// Token: 0x04003B4C RID: 15180
	[Token(Token = "0x4003B4C")]
	[FieldOffset(Offset = "0x28")]
	public List<FurnitureCluster.FurnitureClusterRule> clusterElements;

	// Token: 0x04003B4D RID: 15181
	[Token(Token = "0x4003B4D")]
	[FieldOffset(Offset = "0x30")]
	public float placementChance;

	// Token: 0x04003B4E RID: 15182
	[Token(Token = "0x4003B4E")]
	[FieldOffset(Offset = "0x34")]
	public float roomPriority;

	// Token: 0x04003B4F RID: 15183
	[Token(Token = "0x4003B4F")]
	[FieldOffset(Offset = "0x38")]
	public List<CharacterTrait.TraitPickRule> modifyPriorityTraits;

	// Token: 0x04003B50 RID: 15184
	[Token(Token = "0x4003B50")]
	[FieldOffset(Offset = "0x40")]
	public List<CharacterTrait.TraitPickRule> modifyPlacementChanceTraits;

	// Token: 0x04003B51 RID: 15185
	[Token(Token = "0x4003B51")]
	[FieldOffset(Offset = "0x48")]
	public bool essentialFurniture;

	// Token: 0x04003B52 RID: 15186
	[Token(Token = "0x4003B52")]
	[FieldOffset(Offset = "0x49")]
	public bool updatePreCalculated;

	// Token: 0x04003B53 RID: 15187
	[Token(Token = "0x4003B53")]
	[FieldOffset(Offset = "0x4C")]
	public int calculatedMinRoomSize;

	// Token: 0x04003B54 RID: 15188
	[Token(Token = "0x4003B54")]
	[FieldOffset(Offset = "0x50")]
	public int minimumZeroNodeWallCount;

	// Token: 0x04003B55 RID: 15189
	[Token(Token = "0x4003B55")]
	[FieldOffset(Offset = "0x54")]
	public int maximumZeroNodeWallCount;

	// Token: 0x04003B56 RID: 15190
	[Token(Token = "0x4003B56")]
	[FieldOffset(Offset = "0x58")]
	public List<FurnitureClass> zeroNodeClasses;

	// Token: 0x04003B57 RID: 15191
	[Token(Token = "0x4003B57")]
	[FieldOffset(Offset = "0x60")]
	public int minimumRoomSize;

	// Token: 0x04003B58 RID: 15192
	[Token(Token = "0x4003B58")]
	[FieldOffset(Offset = "0x64")]
	public bool useMaximumRoomSize;

	// Token: 0x04003B59 RID: 15193
	[Token(Token = "0x4003B59")]
	[FieldOffset(Offset = "0x68")]
	public int maximumRoomSize;

	// Token: 0x04003B5A RID: 15194
	[Token(Token = "0x4003B5A")]
	[FieldOffset(Offset = "0x6C")]
	public bool useCustomZeroNodeMinWallCount;

	// Token: 0x04003B5B RID: 15195
	[Token(Token = "0x4003B5B")]
	[FieldOffset(Offset = "0x70")]
	public int customZeroNodeMinWallCount;

	// Token: 0x04003B5C RID: 15196
	[Token(Token = "0x4003B5C")]
	[FieldOffset(Offset = "0x74")]
	public bool useCustomZeroNodeMaxWallCount;

	// Token: 0x04003B5D RID: 15197
	[Token(Token = "0x4003B5D")]
	[FieldOffset(Offset = "0x78")]
	public int customZeroNodeMaxWallCount;

	// Token: 0x04003B5E RID: 15198
	[Token(Token = "0x4003B5E")]
	[FieldOffset(Offset = "0x80")]
	public List<FurnitureClass.FurnitureWallRule> zeroNodeWallRules;

	// Token: 0x04003B5F RID: 15199
	[Token(Token = "0x4003B5F")]
	[FieldOffset(Offset = "0x88")]
	public FurnitureCluster.AllowedOpenPlan allowedInOpenPlan;

	// Token: 0x04003B60 RID: 15200
	[Token(Token = "0x4003B60")]
	[FieldOffset(Offset = "0x8C")]
	public bool allowInResidential;

	// Token: 0x04003B61 RID: 15201
	[Token(Token = "0x4003B61")]
	[FieldOffset(Offset = "0x8D")]
	public bool allowInCompanies;

	// Token: 0x04003B62 RID: 15202
	[Token(Token = "0x4003B62")]
	[FieldOffset(Offset = "0x8E")]
	public bool allowOnStreets;

	// Token: 0x04003B63 RID: 15203
	[Token(Token = "0x4003B63")]
	[FieldOffset(Offset = "0x8F")]
	public bool coastalOnly;

	// Token: 0x04003B64 RID: 15204
	[Token(Token = "0x4003B64")]
	[FieldOffset(Offset = "0x90")]
	public bool limitToDistricts;

	// Token: 0x04003B65 RID: 15205
	[Token(Token = "0x4003B65")]
	[FieldOffset(Offset = "0x98")]
	public List<DistrictPreset> allowedInDistricts;

	// Token: 0x04003B66 RID: 15206
	[Token(Token = "0x4003B66")]
	[FieldOffset(Offset = "0xA0")]
	public bool banFromDistricts;

	// Token: 0x04003B67 RID: 15207
	[Token(Token = "0x4003B67")]
	[FieldOffset(Offset = "0xA8")]
	public List<DistrictPreset> notAllowedInDistricts;

	// Token: 0x04003B68 RID: 15208
	[Token(Token = "0x4003B68")]
	[FieldOffset(Offset = "0xB0")]
	public bool skipIfNoAddressInhabitants;

	// Token: 0x04003B69 RID: 15209
	[Token(Token = "0x4003B69")]
	[FieldOffset(Offset = "0xB1")]
	public bool onlySkipNoInhabitantsIfResidenceOrCompany;

	// Token: 0x04003B6A RID: 15210
	[Token(Token = "0x4003B6A")]
	[FieldOffset(Offset = "0xB8")]
	public List<RoomClassPreset> dontSkipNoInhabitantsIfIn;

	// Token: 0x04003B6B RID: 15211
	[Token(Token = "0x4003B6B")]
	[FieldOffset(Offset = "0xC0")]
	public List<RoomTypeFilter> allowedRoomFilters;

	// Token: 0x04003B6C RID: 15212
	[Token(Token = "0x4003B6C")]
	[FieldOffset(Offset = "0xC8")]
	public bool limitPerRoom;

	// Token: 0x04003B6D RID: 15213
	[Token(Token = "0x4003B6D")]
	[FieldOffset(Offset = "0xCC")]
	public int maximumPerRoom;

	// Token: 0x04003B6E RID: 15214
	[Token(Token = "0x4003B6E")]
	[FieldOffset(Offset = "0xD0")]
	public bool limitPerAddress;

	// Token: 0x04003B6F RID: 15215
	[Token(Token = "0x4003B6F")]
	[FieldOffset(Offset = "0xD4")]
	public int maximumPerAddress;

	// Token: 0x04003B70 RID: 15216
	[Token(Token = "0x4003B70")]
	[FieldOffset(Offset = "0xD8")]
	public bool limitToFloor;

	// Token: 0x04003B71 RID: 15217
	[Token(Token = "0x4003B71")]
	[FieldOffset(Offset = "0xDC")]
	public int allowedOnFloor;

	// Token: 0x04003B72 RID: 15218
	[Token(Token = "0x4003B72")]
	[FieldOffset(Offset = "0xE0")]
	public bool limitToFloorRange;

	// Token: 0x04003B73 RID: 15219
	[Token(Token = "0x4003B73")]
	[FieldOffset(Offset = "0xE4")]
	public Vector2Int allowedOnFloorRange;

	// Token: 0x04003B74 RID: 15220
	[Token(Token = "0x4003B74")]
	[FieldOffset(Offset = "0xEC")]
	public bool wealthLimit;

	// Token: 0x04003B75 RID: 15221
	[Token(Token = "0x4003B75")]
	[FieldOffset(Offset = "0xF0")]
	public float minimumWealth;

	// Token: 0x04003B76 RID: 15222
	[Token(Token = "0x4003B76")]
	[FieldOffset(Offset = "0xF4")]
	public float maximumWealth;

	// Token: 0x04003B77 RID: 15223
	[Token(Token = "0x4003B77")]
	[FieldOffset(Offset = "0xF8")]
	public bool useRoomGrub;

	// Token: 0x04003B78 RID: 15224
	[Token(Token = "0x4003B78")]
	[FieldOffset(Offset = "0xFC")]
	public float minimumGrub;

	// Token: 0x04003B79 RID: 15225
	[Token(Token = "0x4003B79")]
	[FieldOffset(Offset = "0x100")]
	public float maximumGrub;

	// Token: 0x04003B7A RID: 15226
	[Token(Token = "0x4003B7A")]
	[FieldOffset(Offset = "0x104")]
	public bool useBuildingResidences;

	// Token: 0x04003B7B RID: 15227
	[Token(Token = "0x4003B7B")]
	[FieldOffset(Offset = "0x108")]
	public int minimumResidences;

	// Token: 0x04003B7C RID: 15228
	[Token(Token = "0x4003B7C")]
	[FieldOffset(Offset = "0x10C")]
	public int maximumResidences;

	// Token: 0x04003B7D RID: 15229
	[Token(Token = "0x4003B7D")]
	[FieldOffset(Offset = "0x110")]
	public List<FurnitureCluster> addClustersOnSuccess;

	// Token: 0x04003B7E RID: 15230
	[Token(Token = "0x4003B7E")]
	[FieldOffset(Offset = "0x118")]
	public List<FurnitureCluster> removeClustersOnSuccess;

	// Token: 0x04003B7F RID: 15231
	[Token(Token = "0x4003B7F")]
	[FieldOffset(Offset = "0x120")]
	public List<FurnitureCluster> removeClustersOnFail;

	// Token: 0x04003B80 RID: 15232
	[Token(Token = "0x4003B80")]
	[FieldOffset(Offset = "0x128")]
	public bool securityDoor;

	// Token: 0x04003B81 RID: 15233
	[Token(Token = "0x4003B81")]
	[FieldOffset(Offset = "0x129")]
	public bool isBreakerBox;

	// Token: 0x04003B82 RID: 15234
	[Token(Token = "0x4003B82")]
	[FieldOffset(Offset = "0x12A")]
	public bool enableDebug;

	// Token: 0x020007F2 RID: 2034
	[Token(Token = "0x20007F2")]
	public enum FurnitureRuleOption
	{
		// Token: 0x04003B84 RID: 15236
		[Token(Token = "0x4003B84")]
		mustFeature,
		// Token: 0x04003B85 RID: 15237
		[Token(Token = "0x4003B85")]
		cantFeature,
		// Token: 0x04003B86 RID: 15238
		[Token(Token = "0x4003B86")]
		canFeature
	}

	// Token: 0x020007F3 RID: 2035
	[Token(Token = "0x20007F3")]
	public enum WallRule
	{
		// Token: 0x04003B88 RID: 15240
		[Token(Token = "0x4003B88")]
		nothing,
		// Token: 0x04003B89 RID: 15241
		[Token(Token = "0x4003B89")]
		wallNoDoor,
		// Token: 0x04003B8A RID: 15242
		[Token(Token = "0x4003B8A")]
		onlyWall,
		// Token: 0x04003B8B RID: 15243
		[Token(Token = "0x4003B8B")]
		doorway,
		// Token: 0x04003B8C RID: 15244
		[Token(Token = "0x4003B8C")]
		door,
		// Token: 0x04003B8D RID: 15245
		[Token(Token = "0x4003B8D")]
		bannister,
		// Token: 0x04003B8E RID: 15246
		[Token(Token = "0x4003B8E")]
		window
	}

	// Token: 0x020007F4 RID: 2036
	[Token(Token = "0x20007F4")]
	public enum FurnitureFacing
	{
		// Token: 0x04003B90 RID: 15248
		[Token(Token = "0x4003B90")]
		down,
		// Token: 0x04003B91 RID: 15249
		[Token(Token = "0x4003B91")]
		up,
		// Token: 0x04003B92 RID: 15250
		[Token(Token = "0x4003B92")]
		left,
		// Token: 0x04003B93 RID: 15251
		[Token(Token = "0x4003B93")]
		right
	}

	// Token: 0x020007F5 RID: 2037
	[Token(Token = "0x20007F5")]
	public enum AllowedOpenPlan
	{
		// Token: 0x04003B95 RID: 15253
		[Token(Token = "0x4003B95")]
		yes,
		// Token: 0x04003B96 RID: 15254
		[Token(Token = "0x4003B96")]
		no,
		// Token: 0x04003B97 RID: 15255
		[Token(Token = "0x4003B97")]
		openPlanOnly
	}

	// Token: 0x020007F6 RID: 2038
	[Token(Token = "0x20007F6")]
	[Serializable]
	public class FurnitureClusterRule
	{
		// Token: 0x06002981 RID: 10625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002981")]
		[Address(RVA = "0xCA8650", Offset = "0xCA7650", VA = "0x180CA8650")]
		public FurnitureClusterRule()
		{
		}

		// Token: 0x04003B98 RID: 15256
		[Token(Token = "0x4003B98")]
		[FieldOffset(Offset = "0x10")]
		public bool onlyValidIfPreviousObjectPlaced;

		// Token: 0x04003B99 RID: 15257
		[Token(Token = "0x4003B99")]
		[FieldOffset(Offset = "0x18")]
		public List<Vector2> placements;

		// Token: 0x04003B9A RID: 15258
		[Token(Token = "0x4003B9A")]
		[FieldOffset(Offset = "0x20")]
		public FurnitureClass furnitureClass;

		// Token: 0x04003B9B RID: 15259
		[Token(Token = "0x4003B9B")]
		[FieldOffset(Offset = "0x28")]
		public FurnitureCluster.FurnitureFacing facing;

		// Token: 0x04003B9C RID: 15260
		[Token(Token = "0x4003B9C")]
		[FieldOffset(Offset = "0x2C")]
		public bool importantToCluster;

		// Token: 0x04003B9D RID: 15261
		[Token(Token = "0x4003B9D")]
		[FieldOffset(Offset = "0x30")]
		public float chanceOfPlacementAttempt;

		// Token: 0x04003B9E RID: 15262
		[Token(Token = "0x4003B9E")]
		[FieldOffset(Offset = "0x34")]
		public int placementScoreBoost;

		// Token: 0x04003B9F RID: 15263
		[Token(Token = "0x4003B9F")]
		[FieldOffset(Offset = "0x38")]
		public bool useFovBlock;

		// Token: 0x04003BA0 RID: 15264
		[Token(Token = "0x4003BA0")]
		[FieldOffset(Offset = "0x3C")]
		public Vector2 blockDirection;

		// Token: 0x04003BA1 RID: 15265
		[Token(Token = "0x4003BA1")]
		[FieldOffset(Offset = "0x44")]
		public int maxFOVBlockDistance;

		// Token: 0x04003BA2 RID: 15266
		[Token(Token = "0x4003BA2")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 localScale;

		// Token: 0x04003BA3 RID: 15267
		[Token(Token = "0x4003BA3")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 positionOffset;
	}

	// Token: 0x020007F7 RID: 2039
	[Token(Token = "0x20007F7")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002983 RID: 10627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002983")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x0000F948 File Offset: 0x0000DB48
		[Token(Token = "0x6002984")]
		[Address(RVA = "0xCA8850", Offset = "0xCA7850", VA = "0x180CA8850")]
		internal bool <UpdatePreCalculatedLimits>b__61_0(Vector2 item)
		{
			return default(bool);
		}

		// Token: 0x04003BA4 RID: 15268
		[Token(Token = "0x4003BA4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FurnitureCluster.<>c <>9;

		// Token: 0x04003BA5 RID: 15269
		[Token(Token = "0x4003BA5")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Vector2> <>9__61_0;
	}
}
