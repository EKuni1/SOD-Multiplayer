using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000839 RID: 2105
[Token(Token = "0x2000839")]
public class MatchPreset : SoCustomComparison
{
	// Token: 0x060029B8 RID: 10680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029B8")]
	[Address(RVA = "0xCAC9A0", Offset = "0xCAB9A0", VA = "0x180CAC9A0")]
	public MatchPreset()
	{
	}

	// Token: 0x04003F54 RID: 16212
	[Token(Token = "0x4003F54")]
	[FieldOffset(Offset = "0x20")]
	public bool canOnlyBeMatchedWith;

	// Token: 0x04003F55 RID: 16213
	[Token(Token = "0x4003F55")]
	[FieldOffset(Offset = "0x28")]
	public List<MatchPreset.MatchCondition> matchConditions;

	// Token: 0x04003F56 RID: 16214
	[Token(Token = "0x4003F56")]
	[FieldOffset(Offset = "0x30")]
	public bool onlyMatchWithMatchParents;

	// Token: 0x04003F57 RID: 16215
	[Token(Token = "0x4003F57")]
	[FieldOffset(Offset = "0x31")]
	public bool canMatchWithItself;

	// Token: 0x04003F58 RID: 16216
	[Token(Token = "0x4003F58")]
	[FieldOffset(Offset = "0x38")]
	public MatchPreset onlyMatchWithThis;

	// Token: 0x04003F59 RID: 16217
	[Token(Token = "0x4003F59")]
	[FieldOffset(Offset = "0x40")]
	public List<Evidence.DataKey> linkFromKeys;

	// Token: 0x04003F5A RID: 16218
	[Token(Token = "0x4003F5A")]
	[FieldOffset(Offset = "0x48")]
	public List<Evidence.DataKey> linkToKeys;

	// Token: 0x0200083A RID: 2106
	[Token(Token = "0x200083A")]
	public enum MatchCondition
	{
		// Token: 0x04003F5C RID: 16220
		[Token(Token = "0x4003F5C")]
		bloodGroup,
		// Token: 0x04003F5D RID: 16221
		[Token(Token = "0x4003F5D")]
		fingerprint,
		// Token: 0x04003F5E RID: 16222
		[Token(Token = "0x4003F5E")]
		time,
		// Token: 0x04003F5F RID: 16223
		[Token(Token = "0x4003F5F")]
		visualDescriptors,
		// Token: 0x04003F60 RID: 16224
		[Token(Token = "0x4003F60")]
		retailPresetMatch,
		// Token: 0x04003F61 RID: 16225
		[Token(Token = "0x4003F61")]
		murderWeapon
	}
}
