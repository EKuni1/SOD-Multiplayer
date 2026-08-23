using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x02000717 RID: 1815
[Token(Token = "0x2000717")]
public class FactFavourite : Fact
{
	// Token: 0x06002825 RID: 10277 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002825")]
	[Address(RVA = "0xC1C130", Offset = "0xC1B130", VA = "0x180C1C130")]
	public FactFavourite(FactPreset newPreset, List<Evidence> newFromEvidence, List<Evidence> newToEvidence, List<object> newPassedObjects, List<Evidence.DataKey> overrideFromKeys, List<Evidence.DataKey> overrideToKeys, bool isCustomFact)
	{
	}

	// Token: 0x06002826 RID: 10278 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002826")]
	[Address(RVA = "0xC1C300", Offset = "0xC1B300", VA = "0x180C1C300", Slot = "6")]
	public override void OnDiscovery()
	{
	}

	// Token: 0x06002827 RID: 10279 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002827")]
	[Address(RVA = "0xC1C490", Offset = "0xC1B490", VA = "0x180C1C490", Slot = "13")]
	public override string GetName([Optional] Evidence.FactLink specificLink)
	{
		return null;
	}

	// Token: 0x040032EB RID: 13035
	[Token(Token = "0x40032EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Company company;
}
