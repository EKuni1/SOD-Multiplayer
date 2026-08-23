using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x02000715 RID: 1813
[Token(Token = "0x2000715")]
public class FactAge : Fact
{
	// Token: 0x0600281F RID: 10271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600281F")]
	[Address(RVA = "0xC1B820", Offset = "0xC1A820", VA = "0x180C1B820")]
	public FactAge(FactPreset newPreset, List<Evidence> newFromEvidence, List<Evidence> newToEvidence, List<object> newPassedObjects, List<Evidence.DataKey> overrideFromKeys, List<Evidence.DataKey> overrideToKeys, bool isCustomFact)
	{
	}

	// Token: 0x06002820 RID: 10272 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002820")]
	[Address(RVA = "0xC1B840", Offset = "0xC1A840", VA = "0x180C1B840", Slot = "13")]
	public override string GetName([Optional] Evidence.FactLink specificLink)
	{
		return null;
	}
}
