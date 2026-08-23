using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020006F3 RID: 1779
[Token(Token = "0x20006F3")]
public class EvidenceMultiPage : Evidence
{
	// Token: 0x1400005E RID: 94
	// (add) Token: 0x060027A8 RID: 10152 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060027A9 RID: 10153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400005E")]
	public event EvidenceMultiPage.PageChanged OnPageChanged
	{
		[Token(Token = "0x60027A8")]
		[Address(RVA = "0xC0E2B0", Offset = "0xC0D2B0", VA = "0x180C0E2B0")]
		add
		{
		}
		[Token(Token = "0x60027A9")]
		[Address(RVA = "0xC0E3B0", Offset = "0xC0D3B0", VA = "0x180C0E3B0")]
		remove
		{
		}
	}

	// Token: 0x060027AA RID: 10154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027AA")]
	[Address(RVA = "0xC0E4B0", Offset = "0xC0D4B0", VA = "0x180C0E4B0")]
	public EvidenceMultiPage(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x060027AB RID: 10155 RVA: 0x0000F120 File Offset: 0x0000D320
	[Token(Token = "0x60027AB")]
	[Address(RVA = "0xC0E630", Offset = "0xC0D630", VA = "0x180C0E630")]
	public int AddStringContentToNewPage(string newStr, string appendSeperation = "\n\n", int order = -1)
	{
		return 0;
	}

	// Token: 0x060027AC RID: 10156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027AC")]
	[Address(RVA = "0xC0E990", Offset = "0xC0D990", VA = "0x180C0E990")]
	public void AddStringContentToPage(int page, string newStr, string appendSeperation = "\n\n", int order = -1)
	{
	}

	// Token: 0x060027AD RID: 10157 RVA: 0x0000F138 File Offset: 0x0000D338
	[Token(Token = "0x60027AD")]
	[Address(RVA = "0xC0ECC0", Offset = "0xC0DCC0", VA = "0x180C0ECC0")]
	public int AddContainedMetaObjectToNewPage(MetaObject containedMetaObject)
	{
		return 0;
	}

	// Token: 0x060027AE RID: 10158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027AE")]
	[Address(RVA = "0xC0EFA0", Offset = "0xC0DFA0", VA = "0x180C0EFA0")]
	public void AddContainedMetaObjectToPage(int page, MetaObject containedMetaObject)
	{
	}

	// Token: 0x060027AF RID: 10159 RVA: 0x0000F150 File Offset: 0x0000D350
	[Token(Token = "0x60027AF")]
	[Address(RVA = "0xC0F240", Offset = "0xC0E240", VA = "0x180C0F240")]
	public int AddEvidenceToNewPage(Evidence evidenceToAdd)
	{
		return 0;
	}

	// Token: 0x060027B0 RID: 10160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027B0")]
	[Address(RVA = "0xC0F570", Offset = "0xC0E570", VA = "0x180C0F570")]
	public void AddEvidenceToPage(int page, Evidence evidenceToAdd)
	{
	}

	// Token: 0x060027B1 RID: 10161 RVA: 0x0000F168 File Offset: 0x0000D368
	[Token(Token = "0x60027B1")]
	[Address(RVA = "0xC0F850", Offset = "0xC0E850", VA = "0x180C0F850")]
	public int AddEvidenceDiscoveryToNewPage(Evidence evidenceToApplyTo, Evidence.Discovery discovery)
	{
		return 0;
	}

	// Token: 0x060027B2 RID: 10162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027B2")]
	[Address(RVA = "0xC0FBA0", Offset = "0xC0EBA0", VA = "0x180C0FBA0")]
	public void AddEvidenceDiscoveryToPage(int page, Evidence evidenceToApplyTo, Evidence.Discovery discovery)
	{
	}

	// Token: 0x060027B3 RID: 10163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027B3")]
	[Address(RVA = "0xC0FE90", Offset = "0xC0EE90", VA = "0x180C0FE90")]
	public void SetPage(int newPage, bool loopPages)
	{
	}

	// Token: 0x060027B4 RID: 10164 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027B4")]
	[Address(RVA = "0xC10290", Offset = "0xC0F290", VA = "0x180C10290")]
	public List<EvidenceMultiPage.MultiPageContent> GetContentForPage(int newPage)
	{
		return null;
	}

	// Token: 0x060027B5 RID: 10165 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027B5")]
	[Address(RVA = "0xC10750", Offset = "0xC0F750", VA = "0x180C10750")]
	public string GetCurrentPageStringContent()
	{
		return null;
	}

	// Token: 0x060027B6 RID: 10166 RVA: 0x0000F180 File Offset: 0x0000D380
	[Token(Token = "0x60027B6")]
	[Address(RVA = "0xC10A40", Offset = "0xC0FA40", VA = "0x180C10A40")]
	private bool <GetCurrentPageStringContent>b__18_0(EvidenceMultiPage.MultiPageContent item)
	{
		return default(bool);
	}

	// Token: 0x0400329E RID: 12958
	[Token(Token = "0x400329E")]
	[FieldOffset(Offset = "0x150")]
	public List<EvidenceMultiPage.MultiPageContent> pageContent;

	// Token: 0x0400329F RID: 12959
	[Token(Token = "0x400329F")]
	[FieldOffset(Offset = "0x158")]
	public int page;

	// Token: 0x020006F4 RID: 1780
	[Token(Token = "0x20006F4")]
	[Serializable]
	public class MultiPageContent
	{
		// Token: 0x060027B7 RID: 10167 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60027B7")]
		[Address(RVA = "0xC10A60", Offset = "0xC0FA60", VA = "0x180C10A60")]
		public Evidence GetEvidence()
		{
			return null;
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B8")]
		[Address(RVA = "0xC10AE0", Offset = "0xC0FAE0", VA = "0x180C10AE0")]
		public MultiPageContent()
		{
		}

		// Token: 0x040032A1 RID: 12961
		[Token(Token = "0x40032A1")]
		[FieldOffset(Offset = "0x10")]
		public int page;

		// Token: 0x040032A2 RID: 12962
		[Token(Token = "0x40032A2")]
		[FieldOffset(Offset = "0x18")]
		public string evID;

		// Token: 0x040032A3 RID: 12963
		[Token(Token = "0x40032A3")]
		[FieldOffset(Offset = "0x20")]
		public int meta;

		// Token: 0x040032A4 RID: 12964
		[Token(Token = "0x40032A4")]
		[FieldOffset(Offset = "0x28")]
		public string discEvID;

		// Token: 0x040032A5 RID: 12965
		[Token(Token = "0x40032A5")]
		[FieldOffset(Offset = "0x30")]
		public Evidence.Discovery disc;

		// Token: 0x040032A6 RID: 12966
		[Token(Token = "0x40032A6")]
		[FieldOffset(Offset = "0x38")]
		public string seperation;

		// Token: 0x040032A7 RID: 12967
		[Token(Token = "0x40032A7")]
		[FieldOffset(Offset = "0x40")]
		public string str;

		// Token: 0x040032A8 RID: 12968
		[Token(Token = "0x40032A8")]
		[FieldOffset(Offset = "0x48")]
		public int order;
	}

	// Token: 0x020006F5 RID: 1781
	// (Invoke) Token: 0x060027BA RID: 10170
	[Token(Token = "0x20006F5")]
	public delegate void PageChanged(int newPage);

	// Token: 0x020006F6 RID: 1782
	[Token(Token = "0x20006F6")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x060027BD RID: 10173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x0000F198 File Offset: 0x0000D398
		[Token(Token = "0x60027BE")]
		[Address(RVA = "0xC10BF0", Offset = "0xC0FBF0", VA = "0x180C10BF0")]
		internal bool <AddStringContentToNewPage>b__0(EvidenceMultiPage.MultiPageContent item)
		{
			return default(bool);
		}

		// Token: 0x040032A9 RID: 12969
		[Token(Token = "0x40032A9")]
		[FieldOffset(Offset = "0x10")]
		public EvidenceMultiPage <>4__this;

		// Token: 0x040032AA RID: 12970
		[Token(Token = "0x40032AA")]
		[FieldOffset(Offset = "0x18")]
		public string newStr;
	}

	// Token: 0x020006F7 RID: 1783
	[Token(Token = "0x20006F7")]
	private sealed class <>c__DisplayClass9_0
	{
		// Token: 0x060027BF RID: 10175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass9_0()
		{
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		[Token(Token = "0x60027C0")]
		[Address(RVA = "0xC10C60", Offset = "0xC0FC60", VA = "0x180C10C60")]
		internal bool <AddStringContentToPage>b__0(EvidenceMultiPage.MultiPageContent item)
		{
			return default(bool);
		}

		// Token: 0x040032AB RID: 12971
		[Token(Token = "0x40032AB")]
		[FieldOffset(Offset = "0x10")]
		public int page;

		// Token: 0x040032AC RID: 12972
		[Token(Token = "0x40032AC")]
		[FieldOffset(Offset = "0x18")]
		public string newStr;
	}

	// Token: 0x020006F8 RID: 1784
	[Token(Token = "0x20006F8")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x060027C1 RID: 10177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
		[Token(Token = "0x60027C2")]
		[Address(RVA = "0xC10CC0", Offset = "0xC0FCC0", VA = "0x180C10CC0")]
		internal bool <AddContainedMetaObjectToNewPage>b__0(EvidenceMultiPage.MultiPageContent item)
		{
			return default(bool);
		}

		// Token: 0x040032AD RID: 12973
		[Token(Token = "0x40032AD")]
		[FieldOffset(Offset = "0x10")]
		public MetaObject containedMetaObject;
	}

	// Token: 0x020006F9 RID: 1785
	[Token(Token = "0x20006F9")]
	private sealed class <>c__DisplayClass11_0
	{
		// Token: 0x060027C3 RID: 10179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass11_0()
		{
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
		[Token(Token = "0x60027C4")]
		[Address(RVA = "0xC10CC0", Offset = "0xC0FCC0", VA = "0x180C10CC0")]
		internal bool <AddContainedMetaObjectToPage>b__0(EvidenceMultiPage.MultiPageContent item)
		{
			return default(bool);
		}

		// Token: 0x040032AE RID: 12974
		[Token(Token = "0x40032AE")]
		[FieldOffset(Offset = "0x10")]
		public MetaObject containedMetaObject;
	}

	// Token: 0x020006FA RID: 1786
	[Token(Token = "0x20006FA")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x060027C5 RID: 10181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		[Token(Token = "0x60027C6")]
		[Address(RVA = "0xC10CF0", Offset = "0xC0FCF0", VA = "0x180C10CF0")]
		internal bool <AddEvidenceToNewPage>b__0(EvidenceMultiPage.MultiPageContent item)
		{
			return default(bool);
		}

		// Token: 0x040032AF RID: 12975
		[Token(Token = "0x40032AF")]
		[FieldOffset(Offset = "0x10")]
		public EvidenceMultiPage <>4__this;

		// Token: 0x040032B0 RID: 12976
		[Token(Token = "0x40032B0")]
		[FieldOffset(Offset = "0x18")]
		public Evidence evidenceToAdd;
	}

	// Token: 0x020006FB RID: 1787
	[Token(Token = "0x20006FB")]
	private sealed class <>c__DisplayClass13_0
	{
		// Token: 0x060027C7 RID: 10183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass13_0()
		{
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x0000F210 File Offset: 0x0000D410
		[Token(Token = "0x60027C8")]
		[Address(RVA = "0xC10D70", Offset = "0xC0FD70", VA = "0x180C10D70")]
		internal bool <AddEvidenceToPage>b__0(EvidenceMultiPage.MultiPageContent item)
		{
			return default(bool);
		}

		// Token: 0x040032B1 RID: 12977
		[Token(Token = "0x40032B1")]
		[FieldOffset(Offset = "0x10")]
		public int page;

		// Token: 0x040032B2 RID: 12978
		[Token(Token = "0x40032B2")]
		[FieldOffset(Offset = "0x18")]
		public Evidence evidenceToAdd;
	}

	// Token: 0x020006FC RID: 1788
	[Token(Token = "0x20006FC")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x060027C9 RID: 10185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x0000F228 File Offset: 0x0000D428
		[Token(Token = "0x60027CA")]
		[Address(RVA = "0xC10DE0", Offset = "0xC0FDE0", VA = "0x180C10DE0")]
		internal bool <AddEvidenceDiscoveryToNewPage>b__0(EvidenceMultiPage.MultiPageContent item)
		{
			return default(bool);
		}

		// Token: 0x040032B3 RID: 12979
		[Token(Token = "0x40032B3")]
		[FieldOffset(Offset = "0x10")]
		public EvidenceMultiPage <>4__this;

		// Token: 0x040032B4 RID: 12980
		[Token(Token = "0x40032B4")]
		[FieldOffset(Offset = "0x18")]
		public Evidence evidenceToApplyTo;

		// Token: 0x040032B5 RID: 12981
		[Token(Token = "0x40032B5")]
		[FieldOffset(Offset = "0x20")]
		public Evidence.Discovery discovery;
	}

	// Token: 0x020006FD RID: 1789
	[Token(Token = "0x20006FD")]
	private sealed class <>c__DisplayClass15_0
	{
		// Token: 0x060027CB RID: 10187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027CB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass15_0()
		{
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x0000F240 File Offset: 0x0000D440
		[Token(Token = "0x60027CC")]
		[Address(RVA = "0xC10E80", Offset = "0xC0FE80", VA = "0x180C10E80")]
		internal bool <AddEvidenceDiscoveryToPage>b__0(EvidenceMultiPage.MultiPageContent item)
		{
			return default(bool);
		}

		// Token: 0x040032B6 RID: 12982
		[Token(Token = "0x40032B6")]
		[FieldOffset(Offset = "0x10")]
		public int page;

		// Token: 0x040032B7 RID: 12983
		[Token(Token = "0x40032B7")]
		[FieldOffset(Offset = "0x18")]
		public Evidence evidenceToApplyTo;

		// Token: 0x040032B8 RID: 12984
		[Token(Token = "0x40032B8")]
		[FieldOffset(Offset = "0x20")]
		public Evidence.Discovery discovery;
	}

	// Token: 0x020006FE RID: 1790
	[Token(Token = "0x20006FE")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x060027CD RID: 10189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027CD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x0000F258 File Offset: 0x0000D458
		[Token(Token = "0x60027CE")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <SetPage>b__0(EvidenceMultiPage.MultiPageContent item)
		{
			return default(bool);
		}

		// Token: 0x040032B9 RID: 12985
		[Token(Token = "0x40032B9")]
		[FieldOffset(Offset = "0x10")]
		public int newPage;
	}

	// Token: 0x020006FF RID: 1791
	[Token(Token = "0x20006FF")]
	private sealed class <>c__DisplayClass16_1
	{
		// Token: 0x060027CF RID: 10191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027CF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass16_1()
		{
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x0000F270 File Offset: 0x0000D470
		[Token(Token = "0x60027D0")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <SetPage>b__1(EvidenceMultiPage.MultiPageContent item)
		{
			return default(bool);
		}

		// Token: 0x040032BA RID: 12986
		[Token(Token = "0x40032BA")]
		[FieldOffset(Offset = "0x10")]
		public int tryPage;
	}

	// Token: 0x02000700 RID: 1792
	[Token(Token = "0x2000700")]
	private sealed class <>c__DisplayClass17_0
	{
		// Token: 0x060027D1 RID: 10193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass17_0()
		{
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x0000F288 File Offset: 0x0000D488
		[Token(Token = "0x60027D2")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <GetContentForPage>b__0(EvidenceMultiPage.MultiPageContent item)
		{
			return default(bool);
		}

		// Token: 0x040032BB RID: 12987
		[Token(Token = "0x40032BB")]
		[FieldOffset(Offset = "0x10")]
		public int newPage;
	}

	// Token: 0x02000701 RID: 1793
	[Token(Token = "0x2000701")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060027D4 RID: 10196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		[Token(Token = "0x60027D5")]
		[Address(RVA = "0xC10FC0", Offset = "0xC0FFC0", VA = "0x180C10FC0")]
		internal int <GetContentForPage>b__17_1(EvidenceMultiPage.MultiPageContent p1, EvidenceMultiPage.MultiPageContent p2)
		{
			return 0;
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		[Token(Token = "0x60027D6")]
		[Address(RVA = "0xC10FC0", Offset = "0xC0FFC0", VA = "0x180C10FC0")]
		internal int <GetCurrentPageStringContent>b__18_1(EvidenceMultiPage.MultiPageContent p1, EvidenceMultiPage.MultiPageContent p2)
		{
			return 0;
		}

		// Token: 0x040032BC RID: 12988
		[Token(Token = "0x40032BC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EvidenceMultiPage.<>c <>9;

		// Token: 0x040032BD RID: 12989
		[Token(Token = "0x40032BD")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<EvidenceMultiPage.MultiPageContent> <>9__17_1;

		// Token: 0x040032BE RID: 12990
		[Token(Token = "0x40032BE")]
		[FieldOffset(Offset = "0x10")]
		public static Comparison<EvidenceMultiPage.MultiPageContent> <>9__18_1;
	}
}
