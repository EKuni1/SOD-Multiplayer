using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020006EA RID: 1770
[Token(Token = "0x20006EA")]
public class EvidenceDate : Evidence
{
	// Token: 0x06002783 RID: 10115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002783")]
	[Address(RVA = "0xC09890", Offset = "0xC08890", VA = "0x180C09890")]
	public EvidenceDate(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x06002784 RID: 10116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002784")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "12")]
	public override void BuildDataSources()
	{
	}

	// Token: 0x06002785 RID: 10117 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002785")]
	[Address(RVA = "0xC09C60", Offset = "0xC08C60", VA = "0x180C09C60", Slot = "8")]
	public override string GenerateName()
	{
		return null;
	}

	// Token: 0x04003294 RID: 12948
	[Token(Token = "0x4003294")]
	[FieldOffset(Offset = "0x150")]
	public string date;
}
