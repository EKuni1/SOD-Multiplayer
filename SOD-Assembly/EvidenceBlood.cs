using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020006E5 RID: 1765
[Token(Token = "0x20006E5")]
public class EvidenceBlood : Evidence
{
	// Token: 0x0600276C RID: 10092 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600276C")]
	[Address(RVA = "0xC037B0", Offset = "0xC027B0", VA = "0x180C037B0")]
	public EvidenceBlood(EvidencePreset newPreset, string newID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x0600276D RID: 10093 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600276D")]
	[Address(RVA = "0xC038C0", Offset = "0xC028C0", VA = "0x180C038C0", Slot = "10")]
	public override string GenerateNameSuffix()
	{
		return null;
	}

	// Token: 0x0400328D RID: 12941
	[Token(Token = "0x400328D")]
	[FieldOffset(Offset = "0x150")]
	public Citizen citizenController;
}
