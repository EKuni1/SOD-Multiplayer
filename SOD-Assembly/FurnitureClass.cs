using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007E6 RID: 2022
[Token(Token = "0x20007E6")]
public class FurnitureClass : SoCustomComparison
{
	// Token: 0x06002973 RID: 10611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002973")]
	[Address(RVA = "0xCA6690", Offset = "0xCA5690", VA = "0x180CA6690")]
	public void CopyBlockedAccess()
	{
	}

	// Token: 0x06002974 RID: 10612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002974")]
	[Address(RVA = "0xCA6750", Offset = "0xCA5750", VA = "0x180CA6750")]
	public void CopySublocations()
	{
	}

	// Token: 0x06002975 RID: 10613 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002975")]
	[Address(RVA = "0xCA6820", Offset = "0xCA5820", VA = "0x180CA6820")]
	public void BlockSolid()
	{
	}

	// Token: 0x06002976 RID: 10614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002976")]
	[Address(RVA = "0xCA6AD0", Offset = "0xCA5AD0", VA = "0x180CA6AD0")]
	public void BlockAllButFront()
	{
	}

	// Token: 0x06002977 RID: 10615 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002977")]
	[Address(RVA = "0xCA6D60", Offset = "0xCA5D60", VA = "0x180CA6D60")]
	public void UpdatePreCalculatedLimits()
	{
	}

	// Token: 0x06002978 RID: 10616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002978")]
	[Address(RVA = "0xCA7160", Offset = "0xCA6160", VA = "0x180CA7160")]
	public FurnitureClass()
	{
	}

	// Token: 0x04003AD9 RID: 15065
	[Token(Token = "0x4003AD9")]
	[FieldOffset(Offset = "0x20")]
	public List<FurnitureClass.FurnitureWallRule> wallRules;

	// Token: 0x04003ADA RID: 15066
	[Token(Token = "0x4003ADA")]
	[FieldOffset(Offset = "0x28")]
	public List<FurnitureClass.FurnitureNodeRule> nodeRules;

	// Token: 0x04003ADB RID: 15067
	[Token(Token = "0x4003ADB")]
	[FieldOffset(Offset = "0x30")]
	public List<FurnitureClass.BlockedAccess> blockedAccess;

	// Token: 0x04003ADC RID: 15068
	[Token(Token = "0x4003ADC")]
	[FieldOffset(Offset = "0x38")]
	public List<FurnitureClass.CustomNodeWeighting> customNodeWeights;

	// Token: 0x04003ADD RID: 15069
	[Token(Token = "0x4003ADD")]
	[FieldOffset(Offset = "0x40")]
	public bool updatePreCalculated;

	// Token: 0x04003ADE RID: 15070
	[Token(Token = "0x4003ADE")]
	[FieldOffset(Offset = "0x44")]
	public int minimumZeroNodeWallCount;

	// Token: 0x04003ADF RID: 15071
	[Token(Token = "0x4003ADF")]
	[FieldOffset(Offset = "0x48")]
	public int maximumZeroNodeWallCount;

	// Token: 0x04003AE0 RID: 15072
	[Token(Token = "0x4003AE0")]
	[FieldOffset(Offset = "0x4C")]
	public bool canFaceDiagonally;

	// Token: 0x04003AE1 RID: 15073
	[Token(Token = "0x4003AE1")]
	[FieldOffset(Offset = "0x4D")]
	public bool limitPerRoom;

	// Token: 0x04003AE2 RID: 15074
	[Token(Token = "0x4003AE2")]
	[FieldOffset(Offset = "0x50")]
	public int maximumNumberPerRoom;

	// Token: 0x04003AE3 RID: 15075
	[Token(Token = "0x4003AE3")]
	[FieldOffset(Offset = "0x54")]
	public bool limitPerAddress;

	// Token: 0x04003AE4 RID: 15076
	[Token(Token = "0x4003AE4")]
	[FieldOffset(Offset = "0x58")]
	public int maximumNumberPerAddress;

	// Token: 0x04003AE5 RID: 15077
	[Token(Token = "0x4003AE5")]
	[FieldOffset(Offset = "0x5C")]
	public bool limitToFloor;

	// Token: 0x04003AE6 RID: 15078
	[Token(Token = "0x4003AE6")]
	[FieldOffset(Offset = "0x60")]
	public int allowedOnFloor;

	// Token: 0x04003AE7 RID: 15079
	[Token(Token = "0x4003AE7")]
	[FieldOffset(Offset = "0x64")]
	public bool limitToFloorRange;

	// Token: 0x04003AE8 RID: 15080
	[Token(Token = "0x4003AE8")]
	[FieldOffset(Offset = "0x68")]
	public Vector2 allowedOnFloorRange;

	// Token: 0x04003AE9 RID: 15081
	[Token(Token = "0x4003AE9")]
	[FieldOffset(Offset = "0x70")]
	public bool limitPerBuildingResidence;

	// Token: 0x04003AEA RID: 15082
	[Token(Token = "0x4003AEA")]
	[FieldOffset(Offset = "0x74")]
	public int perBuildingResidences;

	// Token: 0x04003AEB RID: 15083
	[Token(Token = "0x4003AEB")]
	[FieldOffset(Offset = "0x78")]
	public bool limitPerJobs;

	// Token: 0x04003AEC RID: 15084
	[Token(Token = "0x4003AEC")]
	[FieldOffset(Offset = "0x7C")]
	public int perJobs;

	// Token: 0x04003AED RID: 15085
	[Token(Token = "0x4003AED")]
	[FieldOffset(Offset = "0x80")]
	public List<FurnitureClass> awayFromClasses;

	// Token: 0x04003AEE RID: 15086
	[Token(Token = "0x4003AEE")]
	[FieldOffset(Offset = "0x88")]
	public float minimumNodeDistance;

	// Token: 0x04003AEF RID: 15087
	[Token(Token = "0x4003AEF")]
	[FieldOffset(Offset = "0x8C")]
	public Vector2 objectSize;

	// Token: 0x04003AF0 RID: 15088
	[Token(Token = "0x4003AF0")]
	[FieldOffset(Offset = "0x94")]
	public bool tall;

	// Token: 0x04003AF1 RID: 15089
	[Token(Token = "0x4003AF1")]
	[FieldOffset(Offset = "0x95")]
	public bool wallPiece;

	// Token: 0x04003AF2 RID: 15090
	[Token(Token = "0x4003AF2")]
	[FieldOffset(Offset = "0x96")]
	public bool useWallSnappingInDecorMode;

	// Token: 0x04003AF3 RID: 15091
	[Token(Token = "0x4003AF3")]
	[FieldOffset(Offset = "0x97")]
	public bool windowPiece;

	// Token: 0x04003AF4 RID: 15092
	[Token(Token = "0x4003AF4")]
	[FieldOffset(Offset = "0x98")]
	public bool occupiesTile;

	// Token: 0x04003AF5 RID: 15093
	[Token(Token = "0x4003AF5")]
	[FieldOffset(Offset = "0x99")]
	public bool allowedOnStairwell;

	// Token: 0x04003AF6 RID: 15094
	[Token(Token = "0x4003AF6")]
	[FieldOffset(Offset = "0x9A")]
	public bool onlyOnStairwell;

	// Token: 0x04003AF7 RID: 15095
	[Token(Token = "0x4003AF7")]
	[FieldOffset(Offset = "0x9B")]
	public bool allowIfNoFloor;

	// Token: 0x04003AF8 RID: 15096
	[Token(Token = "0x4003AF8")]
	[FieldOffset(Offset = "0x9C")]
	public bool ceilingPiece;

	// Token: 0x04003AF9 RID: 15097
	[Token(Token = "0x4003AF9")]
	[FieldOffset(Offset = "0x9D")]
	public bool requiresCeiling;

	// Token: 0x04003AFA RID: 15098
	[Token(Token = "0x4003AFA")]
	[FieldOffset(Offset = "0x9E")]
	public bool blocksCeiling;

	// Token: 0x04003AFB RID: 15099
	[Token(Token = "0x4003AFB")]
	[FieldOffset(Offset = "0x9F")]
	public bool allowLightswitch;

	// Token: 0x04003AFC RID: 15100
	[Token(Token = "0x4003AFC")]
	[FieldOffset(Offset = "0xA0")]
	public bool raiseLightswitch;

	// Token: 0x04003AFD RID: 15101
	[Token(Token = "0x4003AFD")]
	[FieldOffset(Offset = "0xA4")]
	public float lightswitchYOffset;

	// Token: 0x04003AFE RID: 15102
	[Token(Token = "0x4003AFE")]
	[FieldOffset(Offset = "0xA8")]
	public bool noBlocking;

	// Token: 0x04003AFF RID: 15103
	[Token(Token = "0x4003AFF")]
	[FieldOffset(Offset = "0xA9")]
	public bool noPassThrough;

	// Token: 0x04003B00 RID: 15104
	[Token(Token = "0x4003B00")]
	[FieldOffset(Offset = "0xAA")]
	public bool noAccessNeeded;

	// Token: 0x04003B01 RID: 15105
	[Token(Token = "0x4003B01")]
	[FieldOffset(Offset = "0xAB")]
	public bool blockDefaultSublocations;

	// Token: 0x04003B02 RID: 15106
	[Token(Token = "0x4003B02")]
	[FieldOffset(Offset = "0xAC")]
	public bool ignoreGeometryInPhysicsCheck;

	// Token: 0x04003B03 RID: 15107
	[Token(Token = "0x4003B03")]
	[FieldOffset(Offset = "0xB0")]
	public List<FurnitureClass.FurniureWalkSubLocations> sublocations;

	// Token: 0x04003B04 RID: 15108
	[Token(Token = "0x4003B04")]
	[FieldOffset(Offset = "0xB8")]
	public int aiRobberyPriority;

	// Token: 0x04003B05 RID: 15109
	[Token(Token = "0x4003B05")]
	[FieldOffset(Offset = "0xBC")]
	public bool isSecurityCamera;

	// Token: 0x04003B06 RID: 15110
	[Token(Token = "0x4003B06")]
	[FieldOffset(Offset = "0xC0")]
	public FurnitureClass.OwnershipClass ownershipClass;

	// Token: 0x04003B07 RID: 15111
	[Token(Token = "0x4003B07")]
	[FieldOffset(Offset = "0xC4")]
	public FurnitureClass.OwnershipSource ownershipSource;

	// Token: 0x04003B08 RID: 15112
	[Token(Token = "0x4003B08")]
	[FieldOffset(Offset = "0xC8")]
	public int assignBelongsToOwners;

	// Token: 0x04003B09 RID: 15113
	[Token(Token = "0x4003B09")]
	[FieldOffset(Offset = "0xCC")]
	public bool preferCouples;

	// Token: 0x04003B0A RID: 15114
	[Token(Token = "0x4003B0A")]
	[FieldOffset(Offset = "0xCD")]
	public bool copyFromPreviouslyPlacedInCluster;

	// Token: 0x04003B0B RID: 15115
	[Token(Token = "0x4003B0B")]
	[FieldOffset(Offset = "0xCE")]
	public bool onlyPickFromRoomOwners;

	// Token: 0x04003B0C RID: 15116
	[Token(Token = "0x4003B0C")]
	[FieldOffset(Offset = "0xCF")]
	public bool skipIfNoAddressInhabitants;

	// Token: 0x04003B0D RID: 15117
	[Token(Token = "0x4003B0D")]
	[FieldOffset(Offset = "0xD0")]
	public bool assignHomelessOwners;

	// Token: 0x04003B0E RID: 15118
	[Token(Token = "0x4003B0E")]
	[FieldOffset(Offset = "0xD1")]
	public bool assignMailbox;

	// Token: 0x04003B0F RID: 15119
	[Token(Token = "0x4003B0F")]
	[FieldOffset(Offset = "0xD2")]
	public bool discourageMissionPhotos;

	// Token: 0x04003B10 RID: 15120
	[Token(Token = "0x4003B10")]
	[FieldOffset(Offset = "0xD8")]
	public FurnitureClass copyFrom;

	// Token: 0x020007E7 RID: 2023
	[Token(Token = "0x20007E7")]
	public enum FurnitureRuleOption
	{
		// Token: 0x04003B12 RID: 15122
		[Token(Token = "0x4003B12")]
		mustFeature,
		// Token: 0x04003B13 RID: 15123
		[Token(Token = "0x4003B13")]
		cantFeature,
		// Token: 0x04003B14 RID: 15124
		[Token(Token = "0x4003B14")]
		canFeature
	}

	// Token: 0x020007E8 RID: 2024
	[Token(Token = "0x20007E8")]
	public enum WallRule
	{
		// Token: 0x04003B16 RID: 15126
		[Token(Token = "0x4003B16")]
		nothing,
		// Token: 0x04003B17 RID: 15127
		[Token(Token = "0x4003B17")]
		wall,
		// Token: 0x04003B18 RID: 15128
		[Token(Token = "0x4003B18")]
		window,
		// Token: 0x04003B19 RID: 15129
		[Token(Token = "0x4003B19")]
		windowLarge,
		// Token: 0x04003B1A RID: 15130
		[Token(Token = "0x4003B1A")]
		entrance,
		// Token: 0x04003B1B RID: 15131
		[Token(Token = "0x4003B1B")]
		ventUpper,
		// Token: 0x04003B1C RID: 15132
		[Token(Token = "0x4003B1C")]
		ventLower,
		// Token: 0x04003B1D RID: 15133
		[Token(Token = "0x4003B1D")]
		wallOrUpperVent,
		// Token: 0x04003B1E RID: 15134
		[Token(Token = "0x4003B1E")]
		ventTop,
		// Token: 0x04003B1F RID: 15135
		[Token(Token = "0x4003B1F")]
		entranceDoorOnly,
		// Token: 0x04003B20 RID: 15136
		[Token(Token = "0x4003B20")]
		entranceToRoomOfType,
		// Token: 0x04003B21 RID: 15137
		[Token(Token = "0x4003B21")]
		anyWindow,
		// Token: 0x04003B22 RID: 15138
		[Token(Token = "0x4003B22")]
		entraceDivider,
		// Token: 0x04003B23 RID: 15139
		[Token(Token = "0x4003B23")]
		securityDoorDivider,
		// Token: 0x04003B24 RID: 15140
		[Token(Token = "0x4003B24")]
		fence,
		// Token: 0x04003B25 RID: 15141
		[Token(Token = "0x4003B25")]
		addressEntrance,
		// Token: 0x04003B26 RID: 15142
		[Token(Token = "0x4003B26")]
		lightswitch
	}

	// Token: 0x020007E9 RID: 2025
	[Token(Token = "0x20007E9")]
	[Serializable]
	public class FurniureWalkSubLocations
	{
		// Token: 0x06002979 RID: 10617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002979")]
		[Address(RVA = "0xCA7600", Offset = "0xCA6600", VA = "0x180CA7600")]
		public FurniureWalkSubLocations()
		{
		}

		// Token: 0x04003B27 RID: 15143
		[Token(Token = "0x4003B27")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 offset;

		// Token: 0x04003B28 RID: 15144
		[Token(Token = "0x4003B28")]
		[FieldOffset(Offset = "0x18")]
		public List<Vector3> sublocations;
	}

	// Token: 0x020007EA RID: 2026
	[Token(Token = "0x20007EA")]
	[Serializable]
	public class FurnitureNodeRule
	{
		// Token: 0x0600297A RID: 10618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297A")]
		[Address(RVA = "0xCA7710", Offset = "0xCA6710", VA = "0x180CA7710")]
		public FurnitureNodeRule()
		{
		}

		// Token: 0x04003B29 RID: 15145
		[Token(Token = "0x4003B29")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 offset;

		// Token: 0x04003B2A RID: 15146
		[Token(Token = "0x4003B2A")]
		[FieldOffset(Offset = "0x18")]
		public FurnitureClass.FurnitureRuleOption option;

		// Token: 0x04003B2B RID: 15147
		[Token(Token = "0x4003B2B")]
		[FieldOffset(Offset = "0x1C")]
		public bool anyOccupiedTile;

		// Token: 0x04003B2C RID: 15148
		[Token(Token = "0x4003B2C")]
		[FieldOffset(Offset = "0x20")]
		public FurnitureClass furnitureClass;

		// Token: 0x04003B2D RID: 15149
		[Token(Token = "0x4003B2D")]
		[FieldOffset(Offset = "0x28")]
		public int addScore;
	}

	// Token: 0x020007EB RID: 2027
	[Token(Token = "0x20007EB")]
	[Serializable]
	public class FurnitureWallRule
	{
		// Token: 0x0600297B RID: 10619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297B")]
		[Address(RVA = "0xCA7710", Offset = "0xCA6710", VA = "0x180CA7710")]
		public FurnitureWallRule()
		{
		}

		// Token: 0x04003B2E RID: 15150
		[Token(Token = "0x4003B2E")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 nodeOffset;

		// Token: 0x04003B2F RID: 15151
		[Token(Token = "0x4003B2F")]
		[FieldOffset(Offset = "0x18")]
		public CityData.BlockingDirection wallDirection;

		// Token: 0x04003B30 RID: 15152
		[Token(Token = "0x4003B30")]
		[FieldOffset(Offset = "0x1C")]
		public FurnitureClass.FurnitureRuleOption option;

		// Token: 0x04003B31 RID: 15153
		[Token(Token = "0x4003B31")]
		[FieldOffset(Offset = "0x20")]
		public FurnitureClass.WallRule tag;

		// Token: 0x04003B32 RID: 15154
		[Token(Token = "0x4003B32")]
		[FieldOffset(Offset = "0x28")]
		public RoomConfiguration roomType;

		// Token: 0x04003B33 RID: 15155
		[Token(Token = "0x4003B33")]
		[FieldOffset(Offset = "0x30")]
		public int addScore;
	}

	// Token: 0x020007EC RID: 2028
	[Token(Token = "0x20007EC")]
	[Serializable]
	public class BlockedAccess
	{
		// Token: 0x0600297C RID: 10620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297C")]
		[Address(RVA = "0xCA7770", Offset = "0xCA6770", VA = "0x180CA7770")]
		public BlockedAccess()
		{
		}

		// Token: 0x04003B34 RID: 15156
		[Token(Token = "0x4003B34")]
		[FieldOffset(Offset = "0x10")]
		public bool disabled;

		// Token: 0x04003B35 RID: 15157
		[Token(Token = "0x4003B35")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 nodeOffset;

		// Token: 0x04003B36 RID: 15158
		[Token(Token = "0x4003B36")]
		[FieldOffset(Offset = "0x1C")]
		public bool blockExteriorDiagonals;

		// Token: 0x04003B37 RID: 15159
		[Token(Token = "0x4003B37")]
		[FieldOffset(Offset = "0x20")]
		public List<CityData.BlockingDirection> blocked;
	}

	// Token: 0x020007ED RID: 2029
	[Token(Token = "0x20007ED")]
	[Serializable]
	public class CustomNodeWeighting
	{
		// Token: 0x0600297D RID: 10621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297D")]
		[Address(RVA = "0xCA7880", Offset = "0xCA6880", VA = "0x180CA7880")]
		public CustomNodeWeighting()
		{
		}

		// Token: 0x04003B38 RID: 15160
		[Token(Token = "0x4003B38")]
		[FieldOffset(Offset = "0x10")]
		public bool disabled;

		// Token: 0x04003B39 RID: 15161
		[Token(Token = "0x4003B39")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 nodeOffset;

		// Token: 0x04003B3A RID: 15162
		[Token(Token = "0x4003B3A")]
		[FieldOffset(Offset = "0x1C")]
		public float nodeWeightModifier;
	}

	// Token: 0x020007EE RID: 2030
	[Token(Token = "0x20007EE")]
	[Serializable]
	public class SubObject
	{
		// Token: 0x0600297E RID: 10622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public SubObject()
		{
		}

		// Token: 0x04003B3B RID: 15163
		[Token(Token = "0x4003B3B")]
		[FieldOffset(Offset = "0x10")]
		public SubObjectClassPreset preset;

		// Token: 0x04003B3C RID: 15164
		[Token(Token = "0x4003B3C")]
		[FieldOffset(Offset = "0x18")]
		public string parent;

		// Token: 0x04003B3D RID: 15165
		[Token(Token = "0x4003B3D")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 localPos;

		// Token: 0x04003B3E RID: 15166
		[Token(Token = "0x4003B3E")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 localRot;
	}

	// Token: 0x020007EF RID: 2031
	[Token(Token = "0x20007EF")]
	public enum OwnershipClass
	{
		// Token: 0x04003B40 RID: 15168
		[Token(Token = "0x4003B40")]
		none,
		// Token: 0x04003B41 RID: 15169
		[Token(Token = "0x4003B41")]
		bed,
		// Token: 0x04003B42 RID: 15170
		[Token(Token = "0x4003B42")]
		desk,
		// Token: 0x04003B43 RID: 15171
		[Token(Token = "0x4003B43")]
		locker,
		// Token: 0x04003B44 RID: 15172
		[Token(Token = "0x4003B44")]
		drawers,
		// Token: 0x04003B45 RID: 15173
		[Token(Token = "0x4003B45")]
		noticeBoard,
		// Token: 0x04003B46 RID: 15174
		[Token(Token = "0x4003B46")]
		safe,
		// Token: 0x04003B47 RID: 15175
		[Token(Token = "0x4003B47")]
		mailboxes
	}

	// Token: 0x020007F0 RID: 2032
	[Token(Token = "0x20007F0")]
	public enum OwnershipSource
	{
		// Token: 0x04003B49 RID: 15177
		[Token(Token = "0x4003B49")]
		addressInhabitants,
		// Token: 0x04003B4A RID: 15178
		[Token(Token = "0x4003B4A")]
		buildingResidences
	}
}
