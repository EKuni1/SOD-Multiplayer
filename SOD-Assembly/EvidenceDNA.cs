using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020006EC RID: 1772
[Token(Token = "0x20006EC")]
public class EvidenceDNA : Evidence
{
	// Token: 0x06002788 RID: 10120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002788")]
	[Address(RVA = "0xC09D70", Offset = "0xC08D70", VA = "0x180C09D70")]
	public EvidenceDNA(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x06002789 RID: 10121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002789")]
	[Address(RVA = "0xC09E80", Offset = "0xC08E80", VA = "0x180C09E80", Slot = "6")]
	public override void OnDiscovery()
	{
	}

	// Token: 0x04003297 RID: 12951
	[Token(Token = "0x4003297")]
	[FieldOffset(Offset = "0x150")]
	public Citizen citizenController;

	// Token: 0x04003298 RID: 12952
	[Token(Token = "0x4003298")]
	[FieldOffset(Offset = "0x0")]
	public static int DNAAssign;

	// Token: 0x04003299 RID: 12953
	[Token(Token = "0x4003299")]
	[FieldOffset(Offset = "0x4")]
	public static int DNAAssignLoop;
}
