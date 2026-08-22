using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200083B RID: 2107
[Token(Token = "0x200083B")]
public class MaterialGroupPreset : SoCustomComparison
{
	// Token: 0x060029B9 RID: 10681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029B9")]
	[Address(RVA = "0xCACB90", Offset = "0xCABB90", VA = "0x180CACB90")]
	public MaterialGroupPreset()
	{
	}

	// Token: 0x04003F62 RID: 16226
	[Token(Token = "0x4003F62")]
	[FieldOffset(Offset = "0x20")]
	public Material material;

	// Token: 0x04003F63 RID: 16227
	[Token(Token = "0x4003F63")]
	[FieldOffset(Offset = "0x28")]
	public List<MaterialGroupPreset.MaterialVariation> variations;

	// Token: 0x04003F64 RID: 16228
	[Token(Token = "0x4003F64")]
	[FieldOffset(Offset = "0x30")]
	public float concrete;

	// Token: 0x04003F65 RID: 16229
	[Token(Token = "0x4003F65")]
	[FieldOffset(Offset = "0x34")]
	public float plaster;

	// Token: 0x04003F66 RID: 16230
	[Token(Token = "0x4003F66")]
	[FieldOffset(Offset = "0x38")]
	public float wood;

	// Token: 0x04003F67 RID: 16231
	[Token(Token = "0x4003F67")]
	[FieldOffset(Offset = "0x3C")]
	public float carpet;

	// Token: 0x04003F68 RID: 16232
	[Token(Token = "0x4003F68")]
	[FieldOffset(Offset = "0x40")]
	public float tile;

	// Token: 0x04003F69 RID: 16233
	[Token(Token = "0x4003F69")]
	[FieldOffset(Offset = "0x44")]
	public float metal;

	// Token: 0x04003F6A RID: 16234
	[Token(Token = "0x4003F6A")]
	[FieldOffset(Offset = "0x48")]
	public float glass;

	// Token: 0x04003F6B RID: 16235
	[Token(Token = "0x4003F6B")]
	[FieldOffset(Offset = "0x4C")]
	public float fabric;

	// Token: 0x04003F6C RID: 16236
	[Token(Token = "0x4003F6C")]
	[FieldOffset(Offset = "0x50")]
	public MaterialGroupPreset noFloorReplacement;

	// Token: 0x04003F6D RID: 16237
	[Token(Token = "0x4003F6D")]
	[FieldOffset(Offset = "0x58")]
	public bool allowFootprints;

	// Token: 0x04003F6E RID: 16238
	[Token(Token = "0x4003F6E")]
	[FieldOffset(Offset = "0x5C")]
	public float affectFootprintDirt;

	// Token: 0x04003F6F RID: 16239
	[Token(Token = "0x4003F6F")]
	[FieldOffset(Offset = "0x60")]
	public float grubFootprintDirtMultiplier;

	// Token: 0x04003F70 RID: 16240
	[Token(Token = "0x4003F70")]
	[FieldOffset(Offset = "0x64")]
	public MaterialGroupPreset.MaterialType materialType;

	// Token: 0x04003F71 RID: 16241
	[Token(Token = "0x4003F71")]
	[FieldOffset(Offset = "0x68")]
	public float minimumWealth;

	// Token: 0x04003F72 RID: 16242
	[Token(Token = "0x4003F72")]
	[FieldOffset(Offset = "0x70")]
	public List<MaterialGroupPreset.MaterialSettings> designStyles;

	// Token: 0x04003F73 RID: 16243
	[Token(Token = "0x4003F73")]
	[FieldOffset(Offset = "0x78")]
	public List<RoomTypeFilter> allowedRoomFilters;

	// Token: 0x04003F74 RID: 16244
	[Token(Token = "0x4003F74")]
	[FieldOffset(Offset = "0x80")]
	public bool purchasable;

	// Token: 0x04003F75 RID: 16245
	[Token(Token = "0x4003F75")]
	[FieldOffset(Offset = "0x84")]
	public int price;

	// Token: 0x04003F76 RID: 16246
	[Token(Token = "0x4003F76")]
	[FieldOffset(Offset = "0x88")]
	public Sprite decorSprite;

	// Token: 0x0200083C RID: 2108
	[Token(Token = "0x200083C")]
	[Serializable]
	public class MaterialSettings
	{
		// Token: 0x060029BA RID: 10682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BA")]
		[Address(RVA = "0xCACDD0", Offset = "0xCABDD0", VA = "0x180CACDD0")]
		public MaterialSettings()
		{
		}

		// Token: 0x04003F77 RID: 16247
		[Token(Token = "0x4003F77")]
		[FieldOffset(Offset = "0x10")]
		public DesignStylePreset designStyle;

		// Token: 0x04003F78 RID: 16248
		[Token(Token = "0x4003F78")]
		[FieldOffset(Offset = "0x18")]
		public int weighting;
	}

	// Token: 0x0200083D RID: 2109
	[Token(Token = "0x200083D")]
	public enum MaterialType
	{
		// Token: 0x04003F7A RID: 16250
		[Token(Token = "0x4003F7A")]
		walls,
		// Token: 0x04003F7B RID: 16251
		[Token(Token = "0x4003F7B")]
		floor,
		// Token: 0x04003F7C RID: 16252
		[Token(Token = "0x4003F7C")]
		ceiling,
		// Token: 0x04003F7D RID: 16253
		[Token(Token = "0x4003F7D")]
		other
	}

	// Token: 0x0200083E RID: 2110
	[Token(Token = "0x200083E")]
	public enum MaterialColour
	{
		// Token: 0x04003F7F RID: 16255
		[Token(Token = "0x4003F7F")]
		anyPrimary,
		// Token: 0x04003F80 RID: 16256
		[Token(Token = "0x4003F80")]
		anySecondary,
		// Token: 0x04003F81 RID: 16257
		[Token(Token = "0x4003F81")]
		anyPrimaryOrNeutral,
		// Token: 0x04003F82 RID: 16258
		[Token(Token = "0x4003F82")]
		anySecondaryOrNeutral,
		// Token: 0x04003F83 RID: 16259
		[Token(Token = "0x4003F83")]
		any1,
		// Token: 0x04003F84 RID: 16260
		[Token(Token = "0x4003F84")]
		any2,
		// Token: 0x04003F85 RID: 16261
		[Token(Token = "0x4003F85")]
		any1OrNeutral,
		// Token: 0x04003F86 RID: 16262
		[Token(Token = "0x4003F86")]
		any2OrNeutral,
		// Token: 0x04003F87 RID: 16263
		[Token(Token = "0x4003F87")]
		any,
		// Token: 0x04003F88 RID: 16264
		[Token(Token = "0x4003F88")]
		primary1,
		// Token: 0x04003F89 RID: 16265
		[Token(Token = "0x4003F89")]
		primary2,
		// Token: 0x04003F8A RID: 16266
		[Token(Token = "0x4003F8A")]
		secondary1,
		// Token: 0x04003F8B RID: 16267
		[Token(Token = "0x4003F8B")]
		secondary2,
		// Token: 0x04003F8C RID: 16268
		[Token(Token = "0x4003F8C")]
		neutral,
		// Token: 0x04003F8D RID: 16269
		[Token(Token = "0x4003F8D")]
		wood,
		// Token: 0x04003F8E RID: 16270
		[Token(Token = "0x4003F8E")]
		none,
		// Token: 0x04003F8F RID: 16271
		[Token(Token = "0x4003F8F")]
		anyPrimaryOrSecondary
	}

	// Token: 0x0200083F RID: 2111
	[Token(Token = "0x200083F")]
	[Serializable]
	public class MaterialVariation
	{
		// Token: 0x060029BB RID: 10683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BB")]
		[Address(RVA = "0xCACDE0", Offset = "0xCABDE0", VA = "0x180CACDE0")]
		public MaterialVariation()
		{
		}

		// Token: 0x04003F90 RID: 16272
		[Token(Token = "0x4003F90")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04003F91 RID: 16273
		[Token(Token = "0x4003F91")]
		[FieldOffset(Offset = "0x18")]
		public MaterialGroupPreset.MaterialColour main;

		// Token: 0x04003F92 RID: 16274
		[Token(Token = "0x4003F92")]
		[FieldOffset(Offset = "0x1C")]
		public MaterialGroupPreset.MaterialColour colour1;

		// Token: 0x04003F93 RID: 16275
		[Token(Token = "0x4003F93")]
		[FieldOffset(Offset = "0x20")]
		public MaterialGroupPreset.MaterialColour colour2;

		// Token: 0x04003F94 RID: 16276
		[Token(Token = "0x4003F94")]
		[FieldOffset(Offset = "0x24")]
		public MaterialGroupPreset.MaterialColour colour3;
	}
}
