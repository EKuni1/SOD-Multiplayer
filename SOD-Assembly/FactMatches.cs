using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000719 RID: 1817
[Token(Token = "0x2000719")]
public class FactMatches : Fact
{
	// Token: 0x0600282A RID: 10282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600282A")]
	[Address(RVA = "0xC1CAA0", Offset = "0xC1BAA0", VA = "0x180C1CAA0")]
	public FactMatches(FactPreset newPreset, List<Evidence> newFromEvidence, List<Evidence> newToEvidence, List<object> newPassedObjects, List<Evidence.DataKey> overrideFromKeys, List<Evidence.DataKey> overrideToKeys, bool isCustomFact)
	{
	}

	// Token: 0x0600282B RID: 10283 RVA: 0x0000F318 File Offset: 0x0000D518
	[Token(Token = "0x600282B")]
	[Address(RVA = "0xC1CC40", Offset = "0xC1BC40", VA = "0x180C1CC40")]
	public static bool MatchCheck(MatchPreset match, Evidence matchFrom, Evidence matchTo)
	{
		return default(bool);
	}

	// Token: 0x0600282C RID: 10284 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600282C")]
	[Address(RVA = "0xC1D7A0", Offset = "0xC1C7A0", VA = "0x180C1D7A0", Slot = "10")]
	public override string GenerateNameSuffix()
	{
		return null;
	}

	// Token: 0x040032EC RID: 13036
	[Token(Token = "0x40032EC")]
	[FieldOffset(Offset = "0x88")]
	public MatchPreset matchPreset;

	// Token: 0x040032ED RID: 13037
	[Token(Token = "0x40032ED")]
	[FieldOffset(Offset = "0x90")]
	public float timeRangeDifference;

	// Token: 0x040032EE RID: 13038
	[Token(Token = "0x40032EE")]
	[FieldOffset(Offset = "0x94")]
	public float travelTime;

	// Token: 0x040032EF RID: 13039
	[Token(Token = "0x40032EF")]
	[FieldOffset(Offset = "0x98")]
	private NewNode closest1;

	// Token: 0x040032F0 RID: 13040
	[Token(Token = "0x40032F0")]
	[FieldOffset(Offset = "0xA0")]
	private NewNode closest2;
}
