using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200071A RID: 1818
[Token(Token = "0x200071A")]
public class FactPurchased : Fact
{
	// Token: 0x0600282D RID: 10285 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600282D")]
	[Address(RVA = "0xC1D7E0", Offset = "0xC1C7E0", VA = "0x180C1D7E0")]
	public FactPurchased(FactPreset newPreset, List<Evidence> newFromEvidence, List<Evidence> newToEvidence, List<object> newPassedObjects, List<Evidence.DataKey> overrideFromKeys, List<Evidence.DataKey> overrideToKeys, bool isCustomFact)
	{
	}

	// Token: 0x0600282E RID: 10286 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600282E")]
	[Address(RVA = "0xC1D980", Offset = "0xC1C980", VA = "0x180C1D980", Slot = "10")]
	public override string GenerateNameSuffix()
	{
		return null;
	}

	// Token: 0x040032F1 RID: 13041
	[Token(Token = "0x40032F1")]
	[FieldOffset(Offset = "0x88")]
	public Company.SalesRecord sale;
}
