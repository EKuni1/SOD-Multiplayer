using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000841 RID: 2113
[Token(Token = "0x2000841")]
public class MotivePreset : SoCustomComparison
{
	// Token: 0x060029BD RID: 10685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029BD")]
	[Address(RVA = "0xCAD020", Offset = "0xCAC020", VA = "0x180CAD020")]
	public MotivePreset()
	{
	}

	// Token: 0x04003F9B RID: 16283
	[Token(Token = "0x4003F9B")]
	[FieldOffset(Offset = "0x20")]
	public bool allowHomelessPurps;

	// Token: 0x04003F9C RID: 16284
	[Token(Token = "0x4003F9C")]
	[FieldOffset(Offset = "0x21")]
	public bool allowJoblessPurps;

	// Token: 0x04003F9D RID: 16285
	[Token(Token = "0x4003F9D")]
	[FieldOffset(Offset = "0x22")]
	public bool purpMustLiveAtDifferentAddressToPoster;

	// Token: 0x04003F9E RID: 16286
	[Token(Token = "0x4003F9E")]
	[FieldOffset(Offset = "0x23")]
	public bool allowEnforcers;

	// Token: 0x04003F9F RID: 16287
	[Token(Token = "0x4003F9F")]
	[FieldOffset(Offset = "0x24")]
	public bool disallowEchelonHome;

	// Token: 0x04003FA0 RID: 16288
	[Token(Token = "0x4003FA0")]
	[FieldOffset(Offset = "0x28")]
	public List<MotivePreset.ModifierRule> purpTraitModifiers;

	// Token: 0x04003FA1 RID: 16289
	[Token(Token = "0x4003FA1")]
	[FieldOffset(Offset = "0x30")]
	public bool usePurpJobs;

	// Token: 0x04003FA2 RID: 16290
	[Token(Token = "0x4003FA2")]
	[FieldOffset(Offset = "0x38")]
	public List<OccupationPreset> purpJobs;

	// Token: 0x04003FA3 RID: 16291
	[Token(Token = "0x4003FA3")]
	[FieldOffset(Offset = "0x40")]
	public bool allowHomelessPosters;

	// Token: 0x04003FA4 RID: 16292
	[Token(Token = "0x4003FA4")]
	[FieldOffset(Offset = "0x41")]
	public bool allowJoblessPosters;

	// Token: 0x04003FA5 RID: 16293
	[Token(Token = "0x4003FA5")]
	[FieldOffset(Offset = "0x42")]
	public bool usePosterConnections;

	// Token: 0x04003FA6 RID: 16294
	[Token(Token = "0x4003FA6")]
	[FieldOffset(Offset = "0x48")]
	public List<Acquaintance.ConnectionType> acceptableConnections;

	// Token: 0x04003FA7 RID: 16295
	[Token(Token = "0x4003FA7")]
	[FieldOffset(Offset = "0x50")]
	public bool usePosterTraits;

	// Token: 0x04003FA8 RID: 16296
	[Token(Token = "0x4003FA8")]
	[FieldOffset(Offset = "0x58")]
	public List<MotivePreset.ModifierRule> posterTraitModifiers;

	// Token: 0x04003FA9 RID: 16297
	[Token(Token = "0x4003FA9")]
	[FieldOffset(Offset = "0x60")]
	public bool purpIsExemptFromPostingOtherJobs;

	// Token: 0x04003FAA RID: 16298
	[Token(Token = "0x4003FAA")]
	[FieldOffset(Offset = "0x61")]
	public bool purpIsExemptFromPurpingOtherJobs;

	// Token: 0x04003FAB RID: 16299
	[Token(Token = "0x4003FAB")]
	[FieldOffset(Offset = "0x62")]
	public bool posterIsExemptFromPostingOtherJobs;

	// Token: 0x04003FAC RID: 16300
	[Token(Token = "0x4003FAC")]
	[FieldOffset(Offset = "0x63")]
	public bool posterIsExemptFromPurpingOtherJobs;

	// Token: 0x02000842 RID: 2114
	[Token(Token = "0x2000842")]
	[Serializable]
	public class ModifierRule
	{
		// Token: 0x060029BE RID: 10686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029BE")]
		[Address(RVA = "0xCAD2D0", Offset = "0xCAC2D0", VA = "0x180CAD2D0")]
		public ModifierRule()
		{
		}

		// Token: 0x04003FAD RID: 16301
		[Token(Token = "0x4003FAD")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait.RuleType rule;

		// Token: 0x04003FAE RID: 16302
		[Token(Token = "0x4003FAE")]
		[FieldOffset(Offset = "0x18")]
		public List<CharacterTrait> traitList;

		// Token: 0x04003FAF RID: 16303
		[Token(Token = "0x4003FAF")]
		[FieldOffset(Offset = "0x20")]
		public bool mustPassForApplication;

		// Token: 0x04003FB0 RID: 16304
		[Token(Token = "0x4003FB0")]
		[FieldOffset(Offset = "0x24")]
		public int score;
	}
}
