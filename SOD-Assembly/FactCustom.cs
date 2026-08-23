using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x02000716 RID: 1814
[Token(Token = "0x2000716")]
public class FactCustom : Fact
{
	// Token: 0x06002821 RID: 10273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002821")]
	[Address(RVA = "0xC1BF80", Offset = "0xC1AF80", VA = "0x180C1BF80")]
	public FactCustom(FactPreset newPreset, List<Evidence> newFromEvidence, List<Evidence> newToEvidence, List<object> newPassedObjects, List<Evidence.DataKey> overrideFromKeys, List<Evidence.DataKey> overrideToKeys, bool isCustomFact)
	{
	}

	// Token: 0x06002822 RID: 10274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002822")]
	[Address(RVA = "0xC1C0B0", Offset = "0xC1B0B0", VA = "0x180C1C0B0", Slot = "14")]
	public override void SetCustomName(string str)
	{
	}

	// Token: 0x06002823 RID: 10275 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002823")]
	[Address(RVA = "0xC1C120", Offset = "0xC1B120", VA = "0x180C1C120", Slot = "8")]
	public override string GenerateName()
	{
		return null;
	}

	// Token: 0x06002824 RID: 10276 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002824")]
	[Address(RVA = "0xC1C120", Offset = "0xC1B120", VA = "0x180C1C120", Slot = "13")]
	public override string GetName([Optional] Evidence.FactLink specificLink)
	{
		return null;
	}
}
