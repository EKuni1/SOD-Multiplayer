using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000704 RID: 1796
[Token(Token = "0x2000704")]
public class EvidenceReceipt : Evidence
{
	// Token: 0x060027DB RID: 10203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027DB")]
	[Address(RVA = "0xC117F0", Offset = "0xC107F0", VA = "0x180C117F0")]
	public EvidenceReceipt(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x060027DC RID: 10204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027DC")]
	[Address(RVA = "0xC11CC0", Offset = "0xC10CC0", VA = "0x180C11CC0", Slot = "12")]
	public override void BuildDataSources()
	{
	}

	// Token: 0x060027DD RID: 10205 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027DD")]
	[Address(RVA = "0xC11E70", Offset = "0xC10E70", VA = "0x180C11E70", Slot = "8")]
	public override string GenerateName()
	{
		return null;
	}

	// Token: 0x060027DE RID: 10206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027DE")]
	[Address(RVA = "0xC12140", Offset = "0xC11140", VA = "0x180C12140", Slot = "6")]
	public override void OnDiscovery()
	{
	}

	// Token: 0x040032C2 RID: 12994
	[Token(Token = "0x40032C2")]
	[FieldOffset(Offset = "0x150")]
	public Company soldHere;

	// Token: 0x040032C3 RID: 12995
	[Token(Token = "0x40032C3")]
	[FieldOffset(Offset = "0x158")]
	public float purchasedTime;

	// Token: 0x040032C4 RID: 12996
	[Token(Token = "0x40032C4")]
	[FieldOffset(Offset = "0x160")]
	public EvidenceTime purchaseTimeEvidence;

	// Token: 0x040032C5 RID: 12997
	[Token(Token = "0x40032C5")]
	[FieldOffset(Offset = "0x168")]
	public Fact fromFact;

	// Token: 0x040032C6 RID: 12998
	[Token(Token = "0x40032C6")]
	[FieldOffset(Offset = "0x170")]
	public List<InteractablePreset> purchased;

	// Token: 0x02000705 RID: 1797
	[Token(Token = "0x2000705")]
	private sealed class <>c__DisplayClass5_0
	{
		// Token: 0x060027DF RID: 10207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass5_0()
		{
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		[Token(Token = "0x60027E0")]
		[Address(RVA = "0xC122A0", Offset = "0xC112A0", VA = "0x180C122A0")]
		internal bool <.ctor>b__0(Company item)
		{
			return default(bool);
		}

		// Token: 0x040032C7 RID: 12999
		[Token(Token = "0x40032C7")]
		[FieldOffset(Offset = "0x10")]
		public Interactable.Passed passed;
	}
}
