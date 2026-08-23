using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000718 RID: 1816
[Token(Token = "0x2000718")]
public class FactJob : Fact
{
	// Token: 0x06002828 RID: 10280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002828")]
	[Address(RVA = "0xC1B820", Offset = "0xC1A820", VA = "0x180C1B820")]
	public FactJob(FactPreset newPreset, List<Evidence> newFromEvidence, List<Evidence> newToEvidence, List<object> newPassedObjects, List<Evidence.DataKey> overrideFromKeys, List<Evidence.DataKey> overrideToKeys, bool isCustomFact)
	{
	}

	// Token: 0x06002829 RID: 10281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002829")]
	[Address(RVA = "0xC1C940", Offset = "0xC1B940", VA = "0x180C1C940", Slot = "6")]
	public override void OnDiscovery()
	{
	}
}
