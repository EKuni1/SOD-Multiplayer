using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200070D RID: 1805
[Token(Token = "0x200070D")]
public class EvidenceTime : Evidence
{
	// Token: 0x060027F6 RID: 10230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027F6")]
	[Address(RVA = "0xC15900", Offset = "0xC14900", VA = "0x180C15900")]
	public EvidenceTime(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x060027F7 RID: 10231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027F7")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "12")]
	public override void BuildDataSources()
	{
	}

	// Token: 0x060027F8 RID: 10232 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027F8")]
	[Address(RVA = "0xC15E20", Offset = "0xC14E20", VA = "0x180C15E20", Slot = "8")]
	public override string GenerateName()
	{
		return null;
	}

	// Token: 0x060027F9 RID: 10233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027F9")]
	[Address(RVA = "0xC16010", Offset = "0xC15010", VA = "0x180C16010", Slot = "6")]
	public override void OnDiscovery()
	{
	}

	// Token: 0x040032D6 RID: 13014
	[Token(Token = "0x40032D6")]
	[FieldOffset(Offset = "0x150")]
	public float timeFrom;

	// Token: 0x040032D7 RID: 13015
	[Token(Token = "0x40032D7")]
	[FieldOffset(Offset = "0x154")]
	public float timeTo;

	// Token: 0x040032D8 RID: 13016
	[Token(Token = "0x40032D8")]
	[FieldOffset(Offset = "0x158")]
	public string duration;
}
