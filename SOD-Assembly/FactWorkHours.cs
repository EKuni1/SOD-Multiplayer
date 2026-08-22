using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x0200071B RID: 1819
[Token(Token = "0x200071B")]
public class FactWorkHours : Fact
{
	// Token: 0x0600282F RID: 10287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600282F")]
	[Address(RVA = "0xC1B820", Offset = "0xC1A820", VA = "0x180C1B820")]
	public FactWorkHours(FactPreset newPreset, List<Evidence> newFromEvidence, List<Evidence> newToEvidence, List<object> newPassedObjects, List<Evidence.DataKey> overrideFromKeys, List<Evidence.DataKey> overrideToKeys, bool isCustomFact)
	{
	}

	// Token: 0x06002830 RID: 10288 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002830")]
	[Address(RVA = "0xC1DD00", Offset = "0xC1CD00", VA = "0x180C1DD00", Slot = "13")]
	public override string GetName([Optional] Evidence.FactLink specificLink)
	{
		return null;
	}
}
