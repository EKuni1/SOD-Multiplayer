using System;
using Il2CppDummyDll;

// Token: 0x020007B5 RID: 1973
[Token(Token = "0x20007B5")]
public class CriminalPreset : SoCustomComparison
{
	// Token: 0x06002949 RID: 10569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002949")]
	[Address(RVA = "0xCA2C90", Offset = "0xCA1C90", VA = "0x180CA2C90")]
	public CriminalPreset()
	{
	}

	// Token: 0x040038C5 RID: 14533
	[Token(Token = "0x40038C5")]
	[FieldOffset(Offset = "0x20")]
	public CriminalPreset.CriminalType type;

	// Token: 0x040038C6 RID: 14534
	[Token(Token = "0x40038C6")]
	[FieldOffset(Offset = "0x24")]
	public bool canBeAgent;

	// Token: 0x040038C7 RID: 14535
	[Token(Token = "0x40038C7")]
	[FieldOffset(Offset = "0x25")]
	public bool canHaveJob;

	// Token: 0x040038C8 RID: 14536
	[Token(Token = "0x40038C8")]
	[FieldOffset(Offset = "0x28")]
	public int suggestedRank;

	// Token: 0x040038C9 RID: 14537
	[Token(Token = "0x40038C9")]
	[FieldOffset(Offset = "0x30")]
	public CriminalPreset boss;

	// Token: 0x040038CA RID: 14538
	[Token(Token = "0x40038CA")]
	[FieldOffset(Offset = "0x38")]
	public int positionsMin;

	// Token: 0x040038CB RID: 14539
	[Token(Token = "0x40038CB")]
	[FieldOffset(Offset = "0x3C")]
	public int positionsMax;

	// Token: 0x040038CC RID: 14540
	[Token(Token = "0x40038CC")]
	[FieldOffset(Offset = "0x40")]
	public float desiredCrimePerDay;

	// Token: 0x020007B6 RID: 1974
	[Token(Token = "0x20007B6")]
	public enum CriminalType
	{
		// Token: 0x040038CE RID: 14542
		[Token(Token = "0x40038CE")]
		serialKiller
	}
}
