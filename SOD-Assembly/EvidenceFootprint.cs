using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020006EF RID: 1775
[Token(Token = "0x20006EF")]
public class EvidenceFootprint : Evidence
{
	// Token: 0x06002796 RID: 10134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002796")]
	[Address(RVA = "0xC09F90", Offset = "0xC08F90", VA = "0x180C09F90")]
	public EvidenceFootprint(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x06002797 RID: 10135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002797")]
	[Address(RVA = "0xC0BAD0", Offset = "0xC0AAD0", VA = "0x180C0BAD0", Slot = "6")]
	public override void OnDiscovery()
	{
	}

	// Token: 0x06002798 RID: 10136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002798")]
	[Address(RVA = "0xC0BBB0", Offset = "0xC0ABB0", VA = "0x180C0BBB0", Slot = "12")]
	public override void BuildDataSources()
	{
	}

	// Token: 0x06002799 RID: 10137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002799")]
	[Address(RVA = "0xC0BBC0", Offset = "0xC0ABC0", VA = "0x180C0BBC0")]
	public void UpdateSummary()
	{
	}

	// Token: 0x0600279A RID: 10138 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600279A")]
	[Address(RVA = "0xC0BFC0", Offset = "0xC0AFC0", VA = "0x180C0BFC0", Slot = "19")]
	public override string GetNameForDataKey(List<Evidence.DataKey> inputKeys)
	{
		return null;
	}

	// Token: 0x0600279B RID: 10139 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
	[Token(Token = "0x600279B")]
	[Address(RVA = "0xC02CC0", Offset = "0xC01CC0", VA = "0x180C02CC0")]
	private bool <UpdateSummary>b__3_0(InfoWindow item)
	{
		return default(bool);
	}
}
