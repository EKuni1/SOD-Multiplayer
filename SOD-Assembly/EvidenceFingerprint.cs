using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020006ED RID: 1773
[Token(Token = "0x20006ED")]
public class EvidenceFingerprint : Evidence
{
	// Token: 0x0600278B RID: 10123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600278B")]
	[Address(RVA = "0xC09F90", Offset = "0xC08F90", VA = "0x180C09F90")]
	public EvidenceFingerprint(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x0600278C RID: 10124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600278C")]
	[Address(RVA = "0xC09FA0", Offset = "0xC08FA0", VA = "0x180C09FA0", Slot = "6")]
	public override void OnDiscovery()
	{
	}

	// Token: 0x0600278D RID: 10125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600278D")]
	[Address(RVA = "0xC0A4F0", Offset = "0xC094F0", VA = "0x180C0A4F0", Slot = "12")]
	public override void BuildDataSources()
	{
	}

	// Token: 0x0600278E RID: 10126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600278E")]
	[Address(RVA = "0xC0A500", Offset = "0xC09500", VA = "0x180C0A500")]
	public void UpdateSummary()
	{
	}

	// Token: 0x0600278F RID: 10127 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600278F")]
	[Address(RVA = "0xC0A900", Offset = "0xC09900", VA = "0x180C0A900", Slot = "19")]
	public override string GetNameForDataKey(List<Evidence.DataKey> inputKeys)
	{
		return null;
	}

	// Token: 0x06002790 RID: 10128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002790")]
	[Address(RVA = "0xC0B2B0", Offset = "0xC0A2B0", VA = "0x180C0B2B0")]
	public void OnCitizensDataKeyChange()
	{
	}

	// Token: 0x06002791 RID: 10129 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002791")]
	[Address(RVA = "0xC0B3E0", Offset = "0xC0A3E0", VA = "0x180C0B3E0", Slot = "24")]
	public override string GetNoteComposed(List<Evidence.DataKey> keys, bool useLinks = true)
	{
		return null;
	}

	// Token: 0x06002792 RID: 10130 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002792")]
	[Address(RVA = "0xC0B490", Offset = "0xC0A490", VA = "0x180C0B490", Slot = "23")]
	public override string GetNote(List<Evidence.DataKey> keys)
	{
		return null;
	}

	// Token: 0x06002793 RID: 10131 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
	[Token(Token = "0x6002793")]
	[Address(RVA = "0xC02CC0", Offset = "0xC01CC0", VA = "0x180C02CC0")]
	private bool <UpdateSummary>b__3_0(InfoWindow item)
	{
		return default(bool);
	}

	// Token: 0x020006EE RID: 1774
	[Token(Token = "0x20006EE")]
	private sealed class <>c__DisplayClass4_0
	{
		// Token: 0x06002794 RID: 10132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002794")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass4_0()
		{
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x0000F0D8 File Offset: 0x0000D2D8
		[Token(Token = "0x6002795")]
		[Address(RVA = "0xC0BA40", Offset = "0xC0AA40", VA = "0x180C0BA40")]
		internal bool <GetNameForDataKey>b__0(Evidence.DataKey item)
		{
			return default(bool);
		}

		// Token: 0x0400329A RID: 12954
		[Token(Token = "0x400329A")]
		[FieldOffset(Offset = "0x10")]
		public List<Evidence.DataKey> inputKeys;
	}
}
