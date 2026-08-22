using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000706 RID: 1798
[Token(Token = "0x2000706")]
public class EvidenceRetailItem : Evidence
{
	// Token: 0x060027E1 RID: 10209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027E1")]
	[Address(RVA = "0xC122D0", Offset = "0xC112D0", VA = "0x180C122D0")]
	public EvidenceRetailItem(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x060027E2 RID: 10210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027E2")]
	[Address(RVA = "0xC12890", Offset = "0xC11890", VA = "0x180C12890", Slot = "12")]
	public override void BuildDataSources()
	{
	}

	// Token: 0x060027E3 RID: 10211 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027E3")]
	[Address(RVA = "0xC129F0", Offset = "0xC119F0", VA = "0x180C129F0", Slot = "22")]
	public override string GetSummary(List<Evidence.DataKey> keys)
	{
		return null;
	}

	// Token: 0x060027E4 RID: 10212 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027E4")]
	[Address(RVA = "0xC12B60", Offset = "0xC11B60", VA = "0x180C12B60", Slot = "8")]
	public override string GenerateName()
	{
		return null;
	}

	// Token: 0x060027E5 RID: 10213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027E5")]
	[Address(RVA = "0xC13030", Offset = "0xC12030", VA = "0x180C13030", Slot = "6")]
	public override void OnDiscovery()
	{
	}

	// Token: 0x040032C8 RID: 13000
	[Token(Token = "0x40032C8")]
	[FieldOffset(Offset = "0x150")]
	public Company soldHere;

	// Token: 0x040032C9 RID: 13001
	[Token(Token = "0x40032C9")]
	[FieldOffset(Offset = "0x158")]
	public RetailItemPreset retailItem;

	// Token: 0x040032CA RID: 13002
	[Token(Token = "0x40032CA")]
	[FieldOffset(Offset = "0x160")]
	public EvidenceTime purchaseTimeEvidence;

	// Token: 0x040032CB RID: 13003
	[Token(Token = "0x40032CB")]
	[FieldOffset(Offset = "0x168")]
	public float purchaseTime;

	// Token: 0x040032CC RID: 13004
	[Token(Token = "0x40032CC")]
	[FieldOffset(Offset = "0x16C")]
	public bool isAbstract;

	// Token: 0x040032CD RID: 13005
	[Token(Token = "0x40032CD")]
	[FieldOffset(Offset = "0x170")]
	public Fact soldAtFact;

	// Token: 0x02000707 RID: 1799
	[Token(Token = "0x2000707")]
	private sealed class <>c__DisplayClass6_0
	{
		// Token: 0x060027E6 RID: 10214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		[Token(Token = "0x60027E7")]
		[Address(RVA = "0xC13240", Offset = "0xC12240", VA = "0x180C13240")]
		internal bool <.ctor>b__0(Company item)
		{
			return default(bool);
		}

		// Token: 0x040032CE RID: 13006
		[Token(Token = "0x40032CE")]
		[FieldOffset(Offset = "0x10")]
		public Interactable.Passed passed;
	}
}
