using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020006E4 RID: 1764
[Token(Token = "0x20006E4")]
public class EvidenceBirthdayCard : Evidence
{
	// Token: 0x06002769 RID: 10089 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002769")]
	[Address(RVA = "0xC02E10", Offset = "0xC01E10", VA = "0x180C02E10")]
	public EvidenceBirthdayCard(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x0600276A RID: 10090 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600276A")]
	[Address(RVA = "0xC03300", Offset = "0xC02300", VA = "0x180C03300", Slot = "12")]
	public override void BuildDataSources()
	{
	}

	// Token: 0x0600276B RID: 10091 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600276B")]
	[Address(RVA = "0xC03710", Offset = "0xC02710", VA = "0x180C03710", Slot = "8")]
	public override string GenerateName()
	{
		return null;
	}

	// Token: 0x0400328A RID: 12938
	[Token(Token = "0x400328A")]
	[FieldOffset(Offset = "0x150")]
	public Citizen birthdayCitizen;

	// Token: 0x0400328B RID: 12939
	[Token(Token = "0x400328B")]
	[FieldOffset(Offset = "0x158")]
	public Human from;

	// Token: 0x0400328C RID: 12940
	[Token(Token = "0x400328C")]
	[FieldOffset(Offset = "0x160")]
	public Acquaintance relationship;
}
