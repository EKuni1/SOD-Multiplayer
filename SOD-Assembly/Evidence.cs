using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006CF RID: 1743
[Token(Token = "0x20006CF")]
public class Evidence : CaseComponent
{
	// Token: 0x14000052 RID: 82
	// (add) Token: 0x060026E0 RID: 9952 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026E1 RID: 9953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000052")]
	public event Evidence.OnDiscover OnDiscovered
	{
		[Token(Token = "0x60026E0")]
		[Address(RVA = "0xBF54C0", Offset = "0xBF44C0", VA = "0x180BF54C0")]
		add
		{
		}
		[Token(Token = "0x60026E1")]
		[Address(RVA = "0xBF55C0", Offset = "0xBF45C0", VA = "0x180BF55C0")]
		remove
		{
		}
	}

	// Token: 0x14000053 RID: 83
	// (add) Token: 0x060026E2 RID: 9954 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026E3 RID: 9955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000053")]
	public event Evidence.NewParent OnNewParent
	{
		[Token(Token = "0x60026E2")]
		[Address(RVA = "0xBF56C0", Offset = "0xBF46C0", VA = "0x180BF56C0")]
		add
		{
		}
		[Token(Token = "0x60026E3")]
		[Address(RVA = "0xBF57C0", Offset = "0xBF47C0", VA = "0x180BF57C0")]
		remove
		{
		}
	}

	// Token: 0x14000054 RID: 84
	// (add) Token: 0x060026E4 RID: 9956 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026E5 RID: 9957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000054")]
	public event Evidence.NewChild OnNewChild
	{
		[Token(Token = "0x60026E4")]
		[Address(RVA = "0xBF58C0", Offset = "0xBF48C0", VA = "0x180BF58C0")]
		add
		{
		}
		[Token(Token = "0x60026E5")]
		[Address(RVA = "0xBF59C0", Offset = "0xBF49C0", VA = "0x180BF59C0")]
		remove
		{
		}
	}

	// Token: 0x14000055 RID: 85
	// (add) Token: 0x060026E6 RID: 9958 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026E7 RID: 9959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000055")]
	public event Evidence.RemChild OnRemoveChild
	{
		[Token(Token = "0x60026E6")]
		[Address(RVA = "0xBF5AC0", Offset = "0xBF4AC0", VA = "0x180BF5AC0")]
		add
		{
		}
		[Token(Token = "0x60026E7")]
		[Address(RVA = "0xBF5BC0", Offset = "0xBF4BC0", VA = "0x180BF5BC0")]
		remove
		{
		}
	}

	// Token: 0x14000056 RID: 86
	// (add) Token: 0x060026E8 RID: 9960 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026E9 RID: 9961 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000056")]
	public event Evidence.DiscoverChild OnDiscoverChild
	{
		[Token(Token = "0x60026E8")]
		[Address(RVA = "0xBF5CC0", Offset = "0xBF4CC0", VA = "0x180BF5CC0")]
		add
		{
		}
		[Token(Token = "0x60026E9")]
		[Address(RVA = "0xBF5DC0", Offset = "0xBF4DC0", VA = "0x180BF5DC0")]
		remove
		{
		}
	}

	// Token: 0x14000057 RID: 87
	// (add) Token: 0x060026EA RID: 9962 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026EB RID: 9963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000057")]
	public event Evidence.ConnectFact OnConnectFact
	{
		[Token(Token = "0x60026EA")]
		[Address(RVA = "0xBF5EC0", Offset = "0xBF4EC0", VA = "0x180BF5EC0")]
		add
		{
		}
		[Token(Token = "0x60026EB")]
		[Address(RVA = "0xBF5FC0", Offset = "0xBF4FC0", VA = "0x180BF5FC0")]
		remove
		{
		}
	}

	// Token: 0x14000058 RID: 88
	// (add) Token: 0x060026EC RID: 9964 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026ED RID: 9965 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000058")]
	public event Evidence.DiscoverConnectedFact OnDiscoverConnectedFact
	{
		[Token(Token = "0x60026EC")]
		[Address(RVA = "0xBF60C0", Offset = "0xBF50C0", VA = "0x180BF60C0")]
		add
		{
		}
		[Token(Token = "0x60026ED")]
		[Address(RVA = "0xBF61C0", Offset = "0xBF51C0", VA = "0x180BF61C0")]
		remove
		{
		}
	}

	// Token: 0x14000059 RID: 89
	// (add) Token: 0x060026EE RID: 9966 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026EF RID: 9967 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000059")]
	public event Evidence.DataKeyChange OnDataKeyChange
	{
		[Token(Token = "0x60026EE")]
		[Address(RVA = "0xBF62C0", Offset = "0xBF52C0", VA = "0x180BF62C0")]
		add
		{
		}
		[Token(Token = "0x60026EF")]
		[Address(RVA = "0xBF63C0", Offset = "0xBF53C0", VA = "0x180BF63C0")]
		remove
		{
		}
	}

	// Token: 0x1400005A RID: 90
	// (add) Token: 0x060026F0 RID: 9968 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026F1 RID: 9969 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400005A")]
	public event Evidence.DiscoveryChanged OnDiscoveryChanged
	{
		[Token(Token = "0x60026F0")]
		[Address(RVA = "0xBF64C0", Offset = "0xBF54C0", VA = "0x180BF64C0")]
		add
		{
		}
		[Token(Token = "0x60026F1")]
		[Address(RVA = "0xBF65C0", Offset = "0xBF55C0", VA = "0x180BF65C0")]
		remove
		{
		}
	}

	// Token: 0x1400005B RID: 91
	// (add) Token: 0x060026F2 RID: 9970 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026F3 RID: 9971 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400005B")]
	public event Evidence.MatchTypeAdded OnMatchTypeAdded
	{
		[Token(Token = "0x60026F2")]
		[Address(RVA = "0xBF66C0", Offset = "0xBF56C0", VA = "0x180BF66C0")]
		add
		{
		}
		[Token(Token = "0x60026F3")]
		[Address(RVA = "0xBF67C0", Offset = "0xBF57C0", VA = "0x180BF67C0")]
		remove
		{
		}
	}

	// Token: 0x1400005C RID: 92
	// (add) Token: 0x060026F4 RID: 9972 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026F5 RID: 9973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400005C")]
	public event Evidence.AnyPinnedChange OnAnyPinnedChange
	{
		[Token(Token = "0x60026F4")]
		[Address(RVA = "0xBF68C0", Offset = "0xBF58C0", VA = "0x180BF68C0")]
		add
		{
		}
		[Token(Token = "0x60026F5")]
		[Address(RVA = "0xBF69C0", Offset = "0xBF59C0", VA = "0x180BF69C0")]
		remove
		{
		}
	}

	// Token: 0x1400005D RID: 93
	// (add) Token: 0x060026F6 RID: 9974 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060026F7 RID: 9975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400005D")]
	public event Evidence.NoteAdded OnNoteAdded
	{
		[Token(Token = "0x60026F6")]
		[Address(RVA = "0xBF6AC0", Offset = "0xBF5AC0", VA = "0x180BF6AC0")]
		add
		{
		}
		[Token(Token = "0x60026F7")]
		[Address(RVA = "0xBF6BC0", Offset = "0xBF5BC0", VA = "0x180BF6BC0")]
		remove
		{
		}
	}

	// Token: 0x060026F8 RID: 9976 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026F8")]
	[Address(RVA = "0xBF6CC0", Offset = "0xBF5CC0", VA = "0x180BF6CC0")]
	public Evidence(EvidencePreset newPreset, string newID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x060026F9 RID: 9977 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026F9")]
	[Address(RVA = "0xBF7E30", Offset = "0xBF6E30", VA = "0x180BF7E30", Slot = "8")]
	public override string GenerateName()
	{
		return null;
	}

	// Token: 0x060026FA RID: 9978 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026FA")]
	[Address(RVA = "0xBF8050", Offset = "0xBF7050", VA = "0x180BF8050", Slot = "11")]
	public virtual void Compile()
	{
	}

	// Token: 0x060026FB RID: 9979 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026FB")]
	[Address(RVA = "0x728A20", Offset = "0x727A20", VA = "0x180728A20", Slot = "5")]
	public override string GetIdentifier()
	{
		return null;
	}

	// Token: 0x060026FC RID: 9980 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026FC")]
	[Address(RVA = "0xBF84D0", Offset = "0xBF74D0", VA = "0x180BF84D0")]
	public PinnedItemController GetPinned(List<Evidence.DataKey> inputKeys)
	{
		return null;
	}

	// Token: 0x060026FD RID: 9981 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026FD")]
	[Address(RVA = "0xBF8EF0", Offset = "0xBF7EF0", VA = "0x180BF8EF0", Slot = "9")]
	public override string FoundAtName()
	{
		return null;
	}

	// Token: 0x060026FE RID: 9982 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026FE")]
	[Address(RVA = "0xBF8F30", Offset = "0xBF7F30", VA = "0x180BF8F30")]
	private void SetupKeyTies()
	{
	}

	// Token: 0x060026FF RID: 9983 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026FF")]
	[Address(RVA = "0xBF9360", Offset = "0xBF8360", VA = "0x180BF9360", Slot = "12")]
	public virtual void BuildDataSources()
	{
	}

	// Token: 0x06002700 RID: 9984 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002700")]
	[Address(RVA = "0xBF9440", Offset = "0xBF8440", VA = "0x180BF9440")]
	public void SetParent(Evidence newParent)
	{
	}

	// Token: 0x06002701 RID: 9985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002701")]
	[Address(RVA = "0xBF96C0", Offset = "0xBF86C0", VA = "0x180BF96C0")]
	public void SetBelongsTo(Human newOwner)
	{
	}

	// Token: 0x06002702 RID: 9986 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002702")]
	[Address(RVA = "0xBF9C00", Offset = "0xBF8C00", VA = "0x180BF9C00")]
	public void SetWriter(Human newWriter)
	{
	}

	// Token: 0x06002703 RID: 9987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002703")]
	[Address(RVA = "0xBFA100", Offset = "0xBF9100", VA = "0x180BFA100")]
	public void SetReciever(Human newReciever)
	{
	}

	// Token: 0x06002704 RID: 9988 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002704")]
	[Address(RVA = "0xBFA640", Offset = "0xBF9640", VA = "0x180BFA640")]
	public void SetOverrideDDS(string newTreeID)
	{
	}

	// Token: 0x06002705 RID: 9989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002705")]
	[Address(RVA = "0xBFA6B0", Offset = "0xBF96B0", VA = "0x180BFA6B0")]
	private void AddChild(Evidence newEv)
	{
	}

	// Token: 0x06002706 RID: 9990 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002706")]
	[Address(RVA = "0xBFA7B0", Offset = "0xBF97B0", VA = "0x180BFA7B0")]
	private void RemoveChild(Evidence newEv)
	{
	}

	// Token: 0x06002707 RID: 9991 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002707")]
	[Address(RVA = "0xBFA880", Offset = "0xBF9880", VA = "0x180BFA880")]
	public void OnChildEvidenceDiscovery()
	{
	}

	// Token: 0x06002708 RID: 9992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002708")]
	[Address(RVA = "0xBFA8B0", Offset = "0xBF98B0", VA = "0x180BFA8B0")]
	public void AddFactLink(Fact newFact, List<Evidence.DataKey> newKey, bool thisIsTheFromEvidence)
	{
	}

	// Token: 0x06002709 RID: 9993 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002709")]
	[Address(RVA = "0xBFB010", Offset = "0xBFA010", VA = "0x180BFB010")]
	public void AddFactLink(Fact newFact, Evidence.DataKey newKey, bool thisIsTheFromEvidence)
	{
	}

	// Token: 0x0600270A RID: 9994 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600270A")]
	[Address(RVA = "0xBFB290", Offset = "0xBFA290", VA = "0x180BFB290")]
	private void AddFactLinkExe(Fact newFact, Evidence.DataKey newKey, bool thisIsTheFromEvidence)
	{
	}

	// Token: 0x0600270B RID: 9995 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600270B")]
	[Address(RVA = "0xBFB710", Offset = "0xBFA710", VA = "0x180BFB710")]
	public void RemoveFactLink(Fact removeThis)
	{
	}

	// Token: 0x0600270C RID: 9996 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600270C")]
	[Address(RVA = "0xBFBB00", Offset = "0xBFAB00", VA = "0x180BFBB00", Slot = "13")]
	public virtual void OnConnectedFactDiscovery(CaseComponent discovered)
	{
	}

	// Token: 0x0600270D RID: 9997 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600270D")]
	[Address(RVA = "0xBFBB30", Offset = "0xBFAB30", VA = "0x180BFBB30")]
	public void AddMatch(MatchPreset newMatch)
	{
	}

	// Token: 0x0600270E RID: 9998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600270E")]
	[Address(RVA = "0xBFBC00", Offset = "0xBFAC00", VA = "0x180BFBC00", Slot = "6")]
	public override void OnDiscovery()
	{
	}

	// Token: 0x0600270F RID: 9999 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600270F")]
	[Address(RVA = "0xBFC590", Offset = "0xBFB590", VA = "0x180BFC590", Slot = "14")]
	public virtual void AutoCreateFacts(bool discovery)
	{
	}

	// Token: 0x06002710 RID: 10000 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002710")]
	[Address(RVA = "0xBFC830", Offset = "0xBFB830", VA = "0x180BFC830")]
	public Evidence GetLinkForFact(EvidencePreset.Subject subject)
	{
		return null;
	}

	// Token: 0x06002711 RID: 10001 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002711")]
	[Address(RVA = "0xBFCD70", Offset = "0xBFBD70", VA = "0x180BFCD70", Slot = "15")]
	public virtual void MergeDataKeys(Evidence.DataKey keyOne, Evidence.DataKey keyTwo)
	{
	}

	// Token: 0x06002712 RID: 10002 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002712")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "16")]
	public virtual void NamePhotoMerge()
	{
	}

	// Token: 0x06002713 RID: 10003 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002713")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "17")]
	public virtual void OnDataKeyMerge(Evidence.DataKey keyOne, Evidence.DataKey keyTwo)
	{
	}

	// Token: 0x06002714 RID: 10004 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002714")]
	[Address(RVA = "0xBFE2D0", Offset = "0xBFD2D0", VA = "0x180BFE2D0")]
	public List<Evidence.DataKey> GetTiedKeys(Evidence.DataKey inputKey)
	{
		return null;
	}

	// Token: 0x06002715 RID: 10005 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002715")]
	[Address(RVA = "0xBFE3C0", Offset = "0xBFD3C0", VA = "0x180BFE3C0", Slot = "18")]
	public virtual List<Evidence.DataKey> GetTiedKeys(List<Evidence.DataKey> inputKeys)
	{
		return null;
	}

	// Token: 0x06002716 RID: 10006 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002716")]
	[Address(RVA = "0xBFEA10", Offset = "0xBFDA10", VA = "0x180BFEA10")]
	public List<Evidence.FactLink> GetFactsForDataKey(Evidence.DataKey inputKey)
	{
		return null;
	}

	// Token: 0x06002717 RID: 10007 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002717")]
	[Address(RVA = "0xBFEAC0", Offset = "0xBFDAC0", VA = "0x180BFEAC0")]
	public List<Evidence.FactLink> GetFactsForDataKey(List<Evidence.DataKey> inputKeys)
	{
		return null;
	}

	// Token: 0x06002718 RID: 10008 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002718")]
	[Address(RVA = "0xBFEF10", Offset = "0xBFDF10", VA = "0x180BFEF10")]
	public string GetNameForDataKey(Evidence.DataKey inputKey)
	{
		return null;
	}

	// Token: 0x06002719 RID: 10009 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002719")]
	[Address(RVA = "0xBFEFD0", Offset = "0xBFDFD0", VA = "0x180BFEFD0", Slot = "19")]
	public virtual string GetNameForDataKey(List<Evidence.DataKey> inputKeys)
	{
		return null;
	}

	// Token: 0x0600271A RID: 10010 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600271A")]
	[Address(RVA = "0xBFF4A0", Offset = "0xBFE4A0", VA = "0x180BFF4A0")]
	public void AddOrSetCustomName(Evidence.DataKey dk, string newCustomName)
	{
	}

	// Token: 0x0600271B RID: 10011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600271B")]
	[Address(RVA = "0xBFF680", Offset = "0xBFE680", VA = "0x180BFF680")]
	public void AddOrSetCustomName(List<Evidence.DataKey> dk, string newCustomName)
	{
	}

	// Token: 0x0600271C RID: 10012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600271C")]
	[Address(RVA = "0xBFF9E0", Offset = "0xBFE9E0", VA = "0x180BFF9E0")]
	public void AddDiscovery(Evidence.Discovery disc)
	{
	}

	// Token: 0x0600271D RID: 10013 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600271D")]
	[Address(RVA = "0xBFFBA0", Offset = "0xBFEBA0", VA = "0x180BFFBA0", Slot = "20")]
	public virtual void UpdateDiscoveries()
	{
	}

	// Token: 0x0600271E RID: 10014 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600271E")]
	[Address(RVA = "0xBFFF60", Offset = "0xBFEF60", VA = "0x180BFFF60", Slot = "21")]
	public virtual Sprite GetIcon()
	{
		return null;
	}

	// Token: 0x0600271F RID: 10015 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600271F")]
	[Address(RVA = "0xBFFFA0", Offset = "0xBFEFA0", VA = "0x180BFFFA0")]
	public Texture2D GetPhoto(List<Evidence.DataKey> keys)
	{
		return null;
	}

	// Token: 0x06002720 RID: 10016 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002720")]
	[Address(RVA = "0xC005E0", Offset = "0xBFF5E0", VA = "0x180C005E0", Slot = "22")]
	public virtual string GetSummary(List<Evidence.DataKey> keys)
	{
		return null;
	}

	// Token: 0x06002721 RID: 10017 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002721")]
	[Address(RVA = "0xC006C0", Offset = "0xBFF6C0", VA = "0x180C006C0")]
	public void SetNote(List<Evidence.DataKey> keys, string str)
	{
	}

	// Token: 0x06002722 RID: 10018 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002722")]
	[Address(RVA = "0xC00B20", Offset = "0xBFFB20", VA = "0x180C00B20", Slot = "23")]
	public virtual string GetNote(List<Evidence.DataKey> keys)
	{
		return null;
	}

	// Token: 0x06002723 RID: 10019 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002723")]
	[Address(RVA = "0xC00FB0", Offset = "0xBFFFB0", VA = "0x180C00FB0", Slot = "24")]
	public virtual string GetNoteComposed(List<Evidence.DataKey> keys, bool useLinks = true)
	{
		return null;
	}

	// Token: 0x06002724 RID: 10020 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002724")]
	[Address(RVA = "0xC01060", Offset = "0xC00060", VA = "0x180C01060")]
	public void OnPinnedChange()
	{
	}

	// Token: 0x06002725 RID: 10021 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002725")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "25")]
	public virtual void OnPlayerLookedAtWithinReadingRange()
	{
	}

	// Token: 0x06002726 RID: 10022 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002726")]
	[Address(RVA = "0xC01090", Offset = "0xC00090", VA = "0x180C01090")]
	public void SetImageOverride(Sprite newSprite)
	{
	}

	// Token: 0x06002727 RID: 10023 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002727")]
	[Address(RVA = "0xC010F0", Offset = "0xC000F0", VA = "0x180C010F0")]
	public void InstancingCheck()
	{
	}

	// Token: 0x06002728 RID: 10024 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002728")]
	[Address(RVA = "0x51E800", Offset = "0x51D800", VA = "0x18051E800")]
	public void SetForceSave(bool val)
	{
	}

	// Token: 0x06002729 RID: 10025 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002729")]
	[Address(RVA = "0xC02700", Offset = "0xC01700", VA = "0x180C02700")]
	public List<Evidence.DataKey> GetMergedDiscoveryLinkKeysFor(Evidence linkEvidence, Evidence.DataKey mustFeature)
	{
		return null;
	}

	// Token: 0x0600272A RID: 10026 RVA: 0x0000EF40 File Offset: 0x0000D140
	[Token(Token = "0x600272A")]
	[Address(RVA = "0xC02C10", Offset = "0xC01C10", VA = "0x180C02C10")]
	private bool <GetPinned>b__78_0(Case.CaseElement item)
	{
		return default(bool);
	}

	// Token: 0x0600272B RID: 10027 RVA: 0x0000EF58 File Offset: 0x0000D158
	[Token(Token = "0x600272B")]
	[Address(RVA = "0xC02C70", Offset = "0xC01C70", VA = "0x180C02C70")]
	private bool <MergeDataKeys>b__99_0(Evidence.DataKey item)
	{
		return default(bool);
	}

	// Token: 0x0600272C RID: 10028 RVA: 0x0000EF70 File Offset: 0x0000D170
	[Token(Token = "0x600272C")]
	[Address(RVA = "0xC02C90", Offset = "0xC01C90", VA = "0x180C02C90")]
	private bool <MergeDataKeys>b__99_1(InterfaceController.GameMessage item)
	{
		return default(bool);
	}

	// Token: 0x0600272D RID: 10029 RVA: 0x0000EF88 File Offset: 0x0000D188
	[Token(Token = "0x600272D")]
	[Address(RVA = "0xC02CC0", Offset = "0xC01CC0", VA = "0x180C02CC0")]
	private bool <InstancingCheck>b__121_0(InfoWindow item)
	{
		return default(bool);
	}

	// Token: 0x0600272E RID: 10030 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
	[Token(Token = "0x600272E")]
	[Address(RVA = "0xC02C10", Offset = "0xC01C10", VA = "0x180C02C10")]
	private bool <InstancingCheck>b__121_1(Case.CaseElement item)
	{
		return default(bool);
	}

	// Token: 0x0400321B RID: 12827
	[Token(Token = "0x400321B")]
	[FieldOffset(Offset = "0x40")]
	public string evID;

	// Token: 0x0400321C RID: 12828
	[Token(Token = "0x400321C")]
	[FieldOffset(Offset = "0x48")]
	public bool forceSave;

	// Token: 0x0400321D RID: 12829
	[Token(Token = "0x400321D")]
	[FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public Interactable interactable;

	// Token: 0x0400321E RID: 12830
	[Token(Token = "0x400321E")]
	[FieldOffset(Offset = "0x58")]
	public InteractablePreset interactablePreset;

	// Token: 0x0400321F RID: 12831
	[Token(Token = "0x400321F")]
	[FieldOffset(Offset = "0x60")]
	public EvidencePreset preset;

	// Token: 0x04003220 RID: 12832
	[Token(Token = "0x4003220")]
	[FieldOffset(Offset = "0x68")]
	public Sprite imageOverride;

	// Token: 0x04003221 RID: 12833
	[Token(Token = "0x4003221")]
	[FieldOffset(Offset = "0x70")]
	[NonSerialized]
	public Evidence parent;

	// Token: 0x04003222 RID: 12834
	[Token(Token = "0x4003222")]
	[FieldOffset(Offset = "0x78")]
	public Human writer;

	// Token: 0x04003223 RID: 12835
	[Token(Token = "0x4003223")]
	[FieldOffset(Offset = "0x80")]
	public Human reciever;

	// Token: 0x04003224 RID: 12836
	[Token(Token = "0x4003224")]
	[FieldOffset(Offset = "0x88")]
	public Human belongsTo;

	// Token: 0x04003225 RID: 12837
	[Token(Token = "0x4003225")]
	[FieldOffset(Offset = "0x90")]
	public string overrideDDS;

	// Token: 0x04003226 RID: 12838
	[Token(Token = "0x4003226")]
	[FieldOffset(Offset = "0x98")]
	public Controller controller;

	// Token: 0x04003227 RID: 12839
	[Token(Token = "0x4003227")]
	[FieldOffset(Offset = "0xA0")]
	public MetaObject meta;

	// Token: 0x04003228 RID: 12840
	[Token(Token = "0x4003228")]
	[FieldOffset(Offset = "0xA8")]
	[NonSerialized]
	public List<Evidence> children;

	// Token: 0x04003229 RID: 12841
	[Token(Token = "0x4003229")]
	[FieldOffset(Offset = "0xB0")]
	public Dictionary<Evidence.DataKey, List<Evidence.DataKey>> keyTies;

	// Token: 0x0400322A RID: 12842
	[Token(Token = "0x400322A")]
	[FieldOffset(Offset = "0xB8")]
	public List<Evidence.CustomName> customNames;

	// Token: 0x0400322B RID: 12843
	[Token(Token = "0x400322B")]
	[FieldOffset(Offset = "0xC0")]
	public Dictionary<Evidence.DataKey, List<Evidence.FactLink>> factDictionary;

	// Token: 0x0400322C RID: 12844
	[Token(Token = "0x400322C")]
	[FieldOffset(Offset = "0xC8")]
	[NonSerialized]
	public List<Evidence.FactLink> allFacts;

	// Token: 0x0400322D RID: 12845
	[Token(Token = "0x400322D")]
	[FieldOffset(Offset = "0xD0")]
	public List<Evidence.Discovery> discoveryProgress;

	// Token: 0x0400322E RID: 12846
	[Token(Token = "0x400322E")]
	[FieldOffset(Offset = "0xD8")]
	public List<MatchPreset> matches;

	// Token: 0x0400322F RID: 12847
	[Token(Token = "0x400322F")]
	[FieldOffset(Offset = "0xE0")]
	public Dictionary<Evidence.DataKey, string> notes;

	// Token: 0x0400323C RID: 12860
	[Token(Token = "0x400323C")]
	[FieldOffset(Offset = "0x148")]
	private Action OrderCheck;

	// Token: 0x020006D0 RID: 1744
	[Token(Token = "0x20006D0")]
	public enum Discovery
	{
		// Token: 0x0400323E RID: 12862
		[Token(Token = "0x400323E")]
		livesAt,
		// Token: 0x0400323F RID: 12863
		[Token(Token = "0x400323F")]
		partnerDiscovery,
		// Token: 0x04003240 RID: 12864
		[Token(Token = "0x4003240")]
		jobDiscovery,
		// Token: 0x04003241 RID: 12865
		[Token(Token = "0x4003241")]
		purchasedAt,
		// Token: 0x04003242 RID: 12866
		[Token(Token = "0x4003242")]
		phoneLocation,
		// Token: 0x04003243 RID: 12867
		[Token(Token = "0x4003243")]
		paramourDiscovery,
		// Token: 0x04003244 RID: 12868
		[Token(Token = "0x4003244")]
		phonePersonal,
		// Token: 0x04003245 RID: 12869
		[Token(Token = "0x4003245")]
		foundAt,
		// Token: 0x04003246 RID: 12870
		[Token(Token = "0x4003246")]
		foundOn,
		// Token: 0x04003247 RID: 12871
		[Token(Token = "0x4003247")]
		addressBookDiscovery,
		// Token: 0x04003248 RID: 12872
		[Token(Token = "0x4003248")]
		relationshipDiscovery,
		// Token: 0x04003249 RID: 12873
		[Token(Token = "0x4003249")]
		jobHours,
		// Token: 0x0400324A RID: 12874
		[Token(Token = "0x400324A")]
		diaryDiscovery,
		// Token: 0x0400324B RID: 12875
		[Token(Token = "0x400324B")]
		jobDiscoveryPhoto,
		// Token: 0x0400324C RID: 12876
		[Token(Token = "0x400324C")]
		dateOfBirth,
		// Token: 0x0400324D RID: 12877
		[Token(Token = "0x400324D")]
		timeOfDeath,
		// Token: 0x0400324E RID: 12878
		[Token(Token = "0x400324E")]
		referenceDiscovery,
		// Token: 0x0400324F RID: 12879
		[Token(Token = "0x400324F")]
		postedByDiscovery,
		// Token: 0x04003250 RID: 12880
		[Token(Token = "0x4003250")]
		discoverCallFrom,
		// Token: 0x04003251 RID: 12881
		[Token(Token = "0x4003251")]
		discoverCallTo
	}

	// Token: 0x020006D1 RID: 1745
	[Token(Token = "0x20006D1")]
	public enum DataKey
	{
		// Token: 0x04003253 RID: 12883
		[Token(Token = "0x4003253")]
		name,
		// Token: 0x04003254 RID: 12884
		[Token(Token = "0x4003254")]
		photo,
		// Token: 0x04003255 RID: 12885
		[Token(Token = "0x4003255")]
		fingerprints,
		// Token: 0x04003256 RID: 12886
		[Token(Token = "0x4003256")]
		code,
		// Token: 0x04003257 RID: 12887
		[Token(Token = "0x4003257")]
		voice,
		// Token: 0x04003258 RID: 12888
		[Token(Token = "0x4003258")]
		height,
		// Token: 0x04003259 RID: 12889
		[Token(Token = "0x4003259")]
		build,
		// Token: 0x0400325A RID: 12890
		[Token(Token = "0x400325A")]
		age,
		// Token: 0x0400325B RID: 12891
		[Token(Token = "0x400325B")]
		sex,
		// Token: 0x0400325C RID: 12892
		[Token(Token = "0x400325C")]
		hair,
		// Token: 0x0400325D RID: 12893
		[Token(Token = "0x400325D")]
		eyes,
		// Token: 0x0400325E RID: 12894
		[Token(Token = "0x400325E")]
		bloodType,
		// Token: 0x0400325F RID: 12895
		[Token(Token = "0x400325F")]
		shoeSize,
		// Token: 0x04003260 RID: 12896
		[Token(Token = "0x4003260")]
		facialHair,
		// Token: 0x04003261 RID: 12897
		[Token(Token = "0x4003261")]
		address,
		// Token: 0x04003262 RID: 12898
		[Token(Token = "0x4003262")]
		work,
		// Token: 0x04003263 RID: 12899
		[Token(Token = "0x4003263")]
		workHours,
		// Token: 0x04003264 RID: 12900
		[Token(Token = "0x4003264")]
		jobTitle,
		// Token: 0x04003265 RID: 12901
		[Token(Token = "0x4003265")]
		shoeSizeEstimate,
		// Token: 0x04003266 RID: 12902
		[Token(Token = "0x4003266")]
		glasses,
		// Token: 0x04003267 RID: 12903
		[Token(Token = "0x4003267")]
		dateOfBirth,
		// Token: 0x04003268 RID: 12904
		[Token(Token = "0x4003268")]
		salary,
		// Token: 0x04003269 RID: 12905
		[Token(Token = "0x4003269")]
		randomInterest,
		// Token: 0x0400326A RID: 12906
		[Token(Token = "0x400326A")]
		randomSocialClub,
		// Token: 0x0400326B RID: 12907
		[Token(Token = "0x400326B")]
		ageGroup,
		// Token: 0x0400326C RID: 12908
		[Token(Token = "0x400326C")]
		firstNameInitial,
		// Token: 0x0400326D RID: 12909
		[Token(Token = "0x400326D")]
		partnerFirstName,
		// Token: 0x0400326E RID: 12910
		[Token(Token = "0x400326E")]
		partnerJobTitle,
		// Token: 0x0400326F RID: 12911
		[Token(Token = "0x400326F")]
		partnerSocialClub,
		// Token: 0x04003270 RID: 12912
		[Token(Token = "0x4003270")]
		randomAffliction,
		// Token: 0x04003271 RID: 12913
		[Token(Token = "0x4003271")]
		heightEstimate,
		// Token: 0x04003272 RID: 12914
		[Token(Token = "0x4003272")]
		handwriting,
		// Token: 0x04003273 RID: 12915
		[Token(Token = "0x4003273")]
		livesOnFloor,
		// Token: 0x04003274 RID: 12916
		[Token(Token = "0x4003274")]
		telephoneNumber,
		// Token: 0x04003275 RID: 12917
		[Token(Token = "0x4003275")]
		livesInBuilding,
		// Token: 0x04003276 RID: 12918
		[Token(Token = "0x4003276")]
		worksInBuilding,
		// Token: 0x04003277 RID: 12919
		[Token(Token = "0x4003277")]
		location,
		// Token: 0x04003278 RID: 12920
		[Token(Token = "0x4003278")]
		blueprints,
		// Token: 0x04003279 RID: 12921
		[Token(Token = "0x4003279")]
		firstName,
		// Token: 0x0400327A RID: 12922
		[Token(Token = "0x400327A")]
		surname,
		// Token: 0x0400327B RID: 12923
		[Token(Token = "0x400327B")]
		initialedName,
		// Token: 0x0400327C RID: 12924
		[Token(Token = "0x400327C")]
		initials,
		// Token: 0x0400327D RID: 12925
		[Token(Token = "0x400327D")]
		purpose
	}

	// Token: 0x020006D2 RID: 1746
	[Token(Token = "0x20006D2")]
	[Serializable]
	public class FactLink
	{
		// Token: 0x0600272F RID: 10031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public FactLink()
		{
		}

		// Token: 0x0400327E RID: 12926
		[Token(Token = "0x400327E")]
		[FieldOffset(Offset = "0x10")]
		public Fact fact;

		// Token: 0x0400327F RID: 12927
		[Token(Token = "0x400327F")]
		[FieldOffset(Offset = "0x18")]
		public Evidence thisEvidence;

		// Token: 0x04003280 RID: 12928
		[Token(Token = "0x4003280")]
		[FieldOffset(Offset = "0x20")]
		public List<Evidence.DataKey> thisKeys;

		// Token: 0x04003281 RID: 12929
		[Token(Token = "0x4003281")]
		[FieldOffset(Offset = "0x28")]
		public List<Evidence> destinationEvidence;

		// Token: 0x04003282 RID: 12930
		[Token(Token = "0x4003282")]
		[FieldOffset(Offset = "0x30")]
		public List<Evidence.DataKey> destinationKeys;

		// Token: 0x04003283 RID: 12931
		[Token(Token = "0x4003283")]
		[FieldOffset(Offset = "0x38")]
		public bool thisIsTheFromEvidence;
	}

	// Token: 0x020006D3 RID: 1747
	[Token(Token = "0x20006D3")]
	[Serializable]
	public class CustomName
	{
		// Token: 0x06002730 RID: 10032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002730")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public CustomName()
		{
		}

		// Token: 0x04003284 RID: 12932
		[Token(Token = "0x4003284")]
		[FieldOffset(Offset = "0x10")]
		public Evidence.DataKey key;

		// Token: 0x04003285 RID: 12933
		[Token(Token = "0x4003285")]
		[FieldOffset(Offset = "0x18")]
		public string name;
	}

	// Token: 0x020006D4 RID: 1748
	// (Invoke) Token: 0x06002732 RID: 10034
	[Token(Token = "0x20006D4")]
	public delegate void OnDiscover(Evidence disc);

	// Token: 0x020006D5 RID: 1749
	// (Invoke) Token: 0x06002736 RID: 10038
	[Token(Token = "0x20006D5")]
	public delegate void NewParent();

	// Token: 0x020006D6 RID: 1750
	// (Invoke) Token: 0x0600273A RID: 10042
	[Token(Token = "0x20006D6")]
	public delegate void NewChild();

	// Token: 0x020006D7 RID: 1751
	// (Invoke) Token: 0x0600273E RID: 10046
	[Token(Token = "0x20006D7")]
	public delegate void RemChild();

	// Token: 0x020006D8 RID: 1752
	// (Invoke) Token: 0x06002742 RID: 10050
	[Token(Token = "0x20006D8")]
	public delegate void DiscoverChild();

	// Token: 0x020006D9 RID: 1753
	// (Invoke) Token: 0x06002746 RID: 10054
	[Token(Token = "0x20006D9")]
	public delegate void ConnectFact();

	// Token: 0x020006DA RID: 1754
	// (Invoke) Token: 0x0600274A RID: 10058
	[Token(Token = "0x20006DA")]
	public delegate void DiscoverConnectedFact();

	// Token: 0x020006DB RID: 1755
	// (Invoke) Token: 0x0600274E RID: 10062
	[Token(Token = "0x20006DB")]
	public delegate void DataKeyChange();

	// Token: 0x020006DC RID: 1756
	// (Invoke) Token: 0x06002752 RID: 10066
	[Token(Token = "0x20006DC")]
	public delegate void DiscoveryChanged(Evidence.Discovery newDisc);

	// Token: 0x020006DD RID: 1757
	// (Invoke) Token: 0x06002756 RID: 10070
	[Token(Token = "0x20006DD")]
	public delegate void MatchTypeAdded();

	// Token: 0x020006DE RID: 1758
	// (Invoke) Token: 0x0600275A RID: 10074
	[Token(Token = "0x20006DE")]
	public delegate void AnyPinnedChange();

	// Token: 0x020006DF RID: 1759
	// (Invoke) Token: 0x0600275E RID: 10078
	[Token(Token = "0x20006DF")]
	public delegate void NoteAdded();

	// Token: 0x020006E0 RID: 1760
	[Token(Token = "0x20006E0")]
	private sealed class <>c__DisplayClass93_0
	{
		// Token: 0x06002761 RID: 10081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002761")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass93_0()
		{
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		[Token(Token = "0x6002762")]
		[Address(RVA = "0xC02D60", Offset = "0xC01D60", VA = "0x180C02D60")]
		internal bool <RemoveFactLink>b__0(Evidence.FactLink item)
		{
			return default(bool);
		}

		// Token: 0x04003286 RID: 12934
		[Token(Token = "0x4003286")]
		[FieldOffset(Offset = "0x10")]
		public Fact removeThis;
	}

	// Token: 0x020006E1 RID: 1761
	[Token(Token = "0x20006E1")]
	private sealed class <>c__DisplayClass107_0
	{
		// Token: 0x06002763 RID: 10083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002763")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass107_0()
		{
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		[Token(Token = "0x6002764")]
		[Address(RVA = "0xC02D80", Offset = "0xC01D80", VA = "0x180C02D80")]
		internal bool <GetNameForDataKey>b__0(Evidence.DataKey item)
		{
			return default(bool);
		}

		// Token: 0x04003287 RID: 12935
		[Token(Token = "0x4003287")]
		[FieldOffset(Offset = "0x10")]
		public List<Evidence.DataKey> inputKeys;
	}

	// Token: 0x020006E2 RID: 1762
	[Token(Token = "0x20006E2")]
	private sealed class <>c__DisplayClass108_0
	{
		// Token: 0x06002765 RID: 10085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002765")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass108_0()
		{
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		[Token(Token = "0x6002766")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <AddOrSetCustomName>b__0(Evidence.CustomName item)
		{
			return default(bool);
		}

		// Token: 0x04003288 RID: 12936
		[Token(Token = "0x4003288")]
		[FieldOffset(Offset = "0x10")]
		public Evidence.DataKey dk;
	}

	// Token: 0x020006E3 RID: 1763
	[Token(Token = "0x20006E3")]
	private sealed class <>c__DisplayClass109_0
	{
		// Token: 0x06002767 RID: 10087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002767")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass109_0()
		{
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x0000F000 File Offset: 0x0000D200
		[Token(Token = "0x6002768")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <AddOrSetCustomName>b__0(Evidence.CustomName item)
		{
			return default(bool);
		}

		// Token: 0x04003289 RID: 12937
		[Token(Token = "0x4003289")]
		[FieldOffset(Offset = "0x10")]
		public Evidence.DataKey d;
	}
}
