using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006C6 RID: 1734
[Token(Token = "0x20006C6")]
public class EvidenceCreator : MonoBehaviour
{
	// Token: 0x17000143 RID: 323
	// (get) Token: 0x060026B0 RID: 9904 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000143")]
	public static EvidenceCreator Instance
	{
		[Token(Token = "0x60026B0")]
		[Address(RVA = "0xBF0F60", Offset = "0xBEFF60", VA = "0x180BF0F60")]
		get
		{
			return null;
		}
	}

	// Token: 0x060026B1 RID: 9905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026B1")]
	[Address(RVA = "0xBF0FA0", Offset = "0xBEFFA0", VA = "0x180BF0FA0")]
	private void Awake()
	{
	}

	// Token: 0x060026B2 RID: 9906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026B2")]
	[Address(RVA = "0xBF12F0", Offset = "0xBF02F0", VA = "0x180BF12F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060026B3 RID: 9907 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026B3")]
	[Address(RVA = "0xBF1500", Offset = "0xBF0500", VA = "0x180BF1500")]
	public Evidence GetDateEvidence(string date, string evidenceType = "date", string parentID = "", int owner = -1, int writer = -1, int reciever = -1)
	{
		return null;
	}

	// Token: 0x060026B4 RID: 9908 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026B4")]
	[Address(RVA = "0xBF1B40", Offset = "0xBF0B40", VA = "0x180BF1B40")]
	public EvidenceTime GetTimeEvidenceRange(float time, float accuracyRange, bool limitToNow, bool round, int roundToMinutes, string evidenceType = "time", string parentID = "", int writer = -1, int receiver = -1)
	{
		return null;
	}

	// Token: 0x060026B5 RID: 9909 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026B5")]
	[Address(RVA = "0xBF1C40", Offset = "0xBF0C40", VA = "0x180BF1C40")]
	public EvidenceTime GetTimeEvidence(string evidenceID)
	{
		return null;
	}

	// Token: 0x060026B6 RID: 9910 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026B6")]
	[Address(RVA = "0xBF1FF0", Offset = "0xBF0FF0", VA = "0x180BF1FF0")]
	public EvidenceTime GetTimeEvidence(float from, float to, string evidenceType = "time", string parentID = "", int writer = -1, int reciever = -1)
	{
		return null;
	}

	// Token: 0x060026B7 RID: 9911 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026B7")]
	[Address(RVA = "0xBF27A0", Offset = "0xBF17A0", VA = "0x180BF27A0")]
	public Evidence CreateEvidence(string presetName, string newID, [Optional] Controller newController, [Optional] Human newOwner, [Optional] Human newWriter, [Optional] Human newReciever, [Optional] Evidence newParent, bool forceDiscoveryOnCreate = false, [Optional] List<object> passedObjects)
	{
		return null;
	}

	// Token: 0x060026B8 RID: 9912 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026B8")]
	[Address(RVA = "0xBF2930", Offset = "0xBF1930", VA = "0x180BF2930")]
	public Evidence CreateEvidence(EvidencePreset preset, string newID, [Optional] Controller newController, [Optional] Human newOwner, [Optional] Human newWriter, [Optional] Human newReciever, [Optional] Evidence newParent, bool forceDiscoveryOnCreate = false, [Optional] List<object> passedObjects)
	{
		return null;
	}

	// Token: 0x060026B9 RID: 9913 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026B9")]
	[Address(RVA = "0xBF34B0", Offset = "0xBF24B0", VA = "0x180BF34B0")]
	public Fact CreateFact(string presetName, [Optional] Evidence fromEvidenceSingular, [Optional] Evidence toEvidenceSingular, [Optional] List<Evidence> fromEvidence, [Optional] List<Evidence> toEvidence, bool forceDiscoveryOnCreate = false, [Optional] List<object> passedObjects, [Optional] List<Evidence.DataKey> overrideFromKeys, [Optional] List<Evidence.DataKey> overrideToKeys, bool isCustomFact = false)
	{
		return null;
	}

	// Token: 0x060026BA RID: 9914 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60026BA")]
	[Address(RVA = "0xBF3EF0", Offset = "0xBF2EF0", VA = "0x180BF3EF0")]
	public Fact CreateFactFromSerializedString(string str)
	{
		return null;
	}

	// Token: 0x060026BB RID: 9915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026BB")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public EvidenceCreator()
	{
	}

	// Token: 0x0400320D RID: 12813
	[Token(Token = "0x400320D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool globalEntries;

	// Token: 0x0400320E RID: 12814
	[Token(Token = "0x400320E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static EvidenceCreator _instance;

	// Token: 0x020006C7 RID: 1735
	[Token(Token = "0x20006C7")]
	private sealed class <>c__DisplayClass6_0
	{
		// Token: 0x060026BC RID: 9916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026BC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
		[Token(Token = "0x60026BD")]
		[Address(RVA = "0xBF4880", Offset = "0xBF3880", VA = "0x180BF4880")]
		internal bool <GetDateEvidence>b__0(EvidenceDate item)
		{
			return default(bool);
		}

		// Token: 0x0400320F RID: 12815
		[Token(Token = "0x400320F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string generateEvidenceKey;
	}

	// Token: 0x020006C8 RID: 1736
	[Token(Token = "0x20006C8")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x060026BE RID: 9918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026BE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0xBF4880", Offset = "0xBF3880", VA = "0x180BF4880")]
		internal bool <GetTimeEvidence>b__0(EvidenceTime item)
		{
			return default(bool);
		}

		// Token: 0x04003210 RID: 12816
		[Token(Token = "0x4003210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string evidenceID;
	}

	// Token: 0x020006C9 RID: 1737
	[Token(Token = "0x20006C9")]
	private sealed class <>c__DisplayClass9_0
	{
		// Token: 0x060026C0 RID: 9920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass9_0()
		{
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
		[Token(Token = "0x60026C1")]
		[Address(RVA = "0xBF4880", Offset = "0xBF3880", VA = "0x180BF4880")]
		internal bool <GetTimeEvidence>b__0(EvidenceTime item)
		{
			return default(bool);
		}

		// Token: 0x04003211 RID: 12817
		[Token(Token = "0x4003211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string generateEvidenceKey;
	}

	// Token: 0x020006CA RID: 1738
	[Token(Token = "0x20006CA")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x060026C2 RID: 9922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026C2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x0000EF10 File Offset: 0x0000D110
		[Token(Token = "0x60026C3")]
		[Address(RVA = "0xBF48E0", Offset = "0xBF38E0", VA = "0x180BF48E0")]
		internal bool <CreateFact>b__0(Fact item)
		{
			return default(bool);
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x0000EF28 File Offset: 0x0000D128
		[Token(Token = "0x60026C4")]
		[Address(RVA = "0xBF49F0", Offset = "0xBF39F0", VA = "0x180BF49F0")]
		internal bool <CreateFact>b__1(Fact item)
		{
			return default(bool);
		}

		// Token: 0x04003212 RID: 12818
		[Token(Token = "0x4003212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FactPreset preset;

		// Token: 0x04003213 RID: 12819
		[Token(Token = "0x4003213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Evidence fromEvidenceSingular;

		// Token: 0x04003214 RID: 12820
		[Token(Token = "0x4003214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Evidence toEvidenceSingular;
	}
}
