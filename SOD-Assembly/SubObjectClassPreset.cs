using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000899 RID: 2201
[Token(Token = "0x2000899")]
public class SubObjectClassPreset : SoCustomComparison
{
	// Token: 0x06002A05 RID: 10757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A05")]
	[Address(RVA = "0xCB3DB0", Offset = "0xCB2DB0", VA = "0x180CB3DB0")]
	public SubObjectClassPreset()
	{
	}

	// Token: 0x04004396 RID: 17302
	[Token(Token = "0x4004396")]
	[FieldOffset(Offset = "0x20")]
	public bool limitCountPerObject;

	// Token: 0x04004397 RID: 17303
	[Token(Token = "0x4004397")]
	[FieldOffset(Offset = "0x24")]
	public int maxPerObject;

	// Token: 0x04004398 RID: 17304
	[Token(Token = "0x4004398")]
	[FieldOffset(Offset = "0x28")]
	public float perObjectSpawnChance;

	// Token: 0x04004399 RID: 17305
	[Token(Token = "0x4004399")]
	[FieldOffset(Offset = "0x2C")]
	public float perInstanceSpawnChance;

	// Token: 0x0400439A RID: 17306
	[Token(Token = "0x400439A")]
	[FieldOffset(Offset = "0x30")]
	public List<CharacterTrait.TraitPickRule> perInstanceModifiers;

	// Token: 0x0400439B RID: 17307
	[Token(Token = "0x400439B")]
	[FieldOffset(Offset = "0x38")]
	public SubObjectClassPreset.PlacementTypeLimit typeLimit;

	// Token: 0x0200089A RID: 2202
	[Token(Token = "0x200089A")]
	public enum PlacementTypeLimit
	{
		// Token: 0x0400439D RID: 17309
		[Token(Token = "0x400439D")]
		all,
		// Token: 0x0400439E RID: 17310
		[Token(Token = "0x400439E")]
		companyOnly,
		// Token: 0x0400439F RID: 17311
		[Token(Token = "0x400439F")]
		homeOnly,
		// Token: 0x040043A0 RID: 17312
		[Token(Token = "0x40043A0")]
		indoorsOnly,
		// Token: 0x040043A1 RID: 17313
		[Token(Token = "0x40043A1")]
		outdoorsOnly
	}
}
