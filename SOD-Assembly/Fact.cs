using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x02000712 RID: 1810
[Token(Token = "0x2000712")]
public class Fact : CaseComponent
{
	// Token: 0x1400005F RID: 95
	// (add) Token: 0x06002806 RID: 10246 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002807 RID: 10247 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400005F")]
	public event Fact.ConnectingEvidenceChangeDataKey OnConnectingEvidenceChangeDataKey
	{
		[Token(Token = "0x6002806")]
		[Address(RVA = "0xC17F10", Offset = "0xC16F10", VA = "0x180C17F10")]
		add
		{
		}
		[Token(Token = "0x6002807")]
		[Address(RVA = "0xC18000", Offset = "0xC17000", VA = "0x180C18000")]
		remove
		{
		}
	}

	// Token: 0x14000060 RID: 96
	// (add) Token: 0x06002808 RID: 10248 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002809 RID: 10249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000060")]
	public event Fact.IsSeen OnSeen
	{
		[Token(Token = "0x6002808")]
		[Address(RVA = "0xC180F0", Offset = "0xC170F0", VA = "0x180C180F0")]
		add
		{
		}
		[Token(Token = "0x6002809")]
		[Address(RVA = "0xC181F0", Offset = "0xC171F0", VA = "0x180C181F0")]
		remove
		{
		}
	}

	// Token: 0x0600280A RID: 10250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600280A")]
	[Address(RVA = "0xC182F0", Offset = "0xC172F0", VA = "0x180C182F0")]
	public Fact(FactPreset newPreset, List<Evidence> newFromEvidence, List<Evidence> newToEvidence, List<object> newPassedObjects, List<Evidence.DataKey> overrideFromKeys, List<Evidence.DataKey> overrideToKeys, bool isCustomFact)
	{
	}

	// Token: 0x0600280B RID: 10251 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600280B")]
	[Address(RVA = "0xC18CC0", Offset = "0xC17CC0", VA = "0x180C18CC0", Slot = "5")]
	public override string GetIdentifier()
	{
		return null;
	}

	// Token: 0x0600280C RID: 10252 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600280C")]
	[Address(RVA = "0xC191F0", Offset = "0xC181F0", VA = "0x180C191F0", Slot = "8")]
	public override string GenerateName()
	{
		return null;
	}

	// Token: 0x0600280D RID: 10253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600280D")]
	[Address(RVA = "0xC19520", Offset = "0xC18520", VA = "0x180C19520", Slot = "11")]
	public virtual void ConnectFact()
	{
	}

	// Token: 0x0600280E RID: 10254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600280E")]
	[Address(RVA = "0xC198A0", Offset = "0xC188A0", VA = "0x180C198A0", Slot = "6")]
	public override void OnDiscovery()
	{
	}

	// Token: 0x0600280F RID: 10255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600280F")]
	[Address(RVA = "0xC1A220", Offset = "0xC19220", VA = "0x180C1A220")]
	public void SetSeen()
	{
	}

	// Token: 0x06002810 RID: 10256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002810")]
	[Address(RVA = "0xC1A250", Offset = "0xC19250", VA = "0x180C1A250", Slot = "12")]
	public virtual void OnConnectedEvidenceDiscovery(CaseComponent discovered)
	{
	}

	// Token: 0x06002811 RID: 10257 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002811")]
	[Address(RVA = "0xC1A2E0", Offset = "0xC192E0", VA = "0x180C1A2E0", Slot = "13")]
	public virtual string GetName([Optional] Evidence.FactLink specificLink)
	{
		return null;
	}

	// Token: 0x06002812 RID: 10258 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002812")]
	[Address(RVA = "0xC1A7A0", Offset = "0xC197A0", VA = "0x180C1A7A0")]
	public Evidence GetOther(Evidence ev)
	{
		return null;
	}

	// Token: 0x06002813 RID: 10259 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002813")]
	[Address(RVA = "0xC1A940", Offset = "0xC19940", VA = "0x180C1A940")]
	public List<Evidence> GetOther(List<Evidence> ev)
	{
		return null;
	}

	// Token: 0x06002814 RID: 10260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002814")]
	[Address(RVA = "0xB40030", Offset = "0xB3F030", VA = "0x180B40030")]
	public void OnConnectionsChangedDataKeys()
	{
	}

	// Token: 0x06002815 RID: 10261 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002815")]
	[Address(RVA = "0xC1AB10", Offset = "0xC19B10", VA = "0x180C1AB10")]
	public string GetSerializedString()
	{
		return null;
	}

	// Token: 0x06002816 RID: 10262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002816")]
	[Address(RVA = "0xC1B7C0", Offset = "0xC1A7C0", VA = "0x180C1B7C0", Slot = "14")]
	public virtual void SetCustomName(string str)
	{
	}

	// Token: 0x040032E1 RID: 13025
	[Token(Token = "0x40032E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[NonSerialized]
	public FactPreset preset;

	// Token: 0x040032E2 RID: 13026
	[Token(Token = "0x40032E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Evidence> fromEvidence;

	// Token: 0x040032E3 RID: 13027
	[Token(Token = "0x40032E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Evidence> toEvidence;

	// Token: 0x040032E4 RID: 13028
	[Token(Token = "0x40032E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<Evidence.DataKey> fromDataKeys;

	// Token: 0x040032E5 RID: 13029
	[Token(Token = "0x40032E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Evidence.DataKey> toDataKeys;

	// Token: 0x040032E6 RID: 13030
	[Token(Token = "0x40032E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool isSeen;

	// Token: 0x040032E7 RID: 13031
	[Token(Token = "0x40032E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool isCustom;

	// Token: 0x040032E8 RID: 13032
	[Token(Token = "0x40032E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string customName;

	// Token: 0x02000713 RID: 1811
	// (Invoke) Token: 0x06002818 RID: 10264
	[Token(Token = "0x2000713")]
	public delegate void ConnectingEvidenceChangeDataKey();

	// Token: 0x02000714 RID: 1812
	// (Invoke) Token: 0x0600281C RID: 10268
	[Token(Token = "0x2000714")]
	public delegate void IsSeen();
}
