using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000110 RID: 272
[Token(Token = "0x2000110")]
public class Company
{
	// Token: 0x060007B1 RID: 1969 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x494500", Offset = "0x493500", VA = "0x180494500")]
	public void Setup(CompanyPreset newPreset, NewAddress newAddress)
	{
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x000052F8 File Offset: 0x000034F8
	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x496660", Offset = "0x495660", VA = "0x180496660")]
	public int GetOpenHoursCoverageCountForShift(CompanyOpenHoursPreset.CompanyShift sft)
	{
		return 0;
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x496820", Offset = "0x495820", VA = "0x180496820")]
	public void SetAddress(NewAddress newAdd)
	{
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x3FE2A0", Offset = "0x3FD2A0", VA = "0x1803FE2A0")]
	public void SetPlaceOfBusiness(NewGameLocation newLoc)
	{
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x496F20", Offset = "0x495F20", VA = "0x180496F20")]
	public void Load(CitySaveData.CompanyCitySave data, NewAddress newAddress)
	{
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x498010", Offset = "0x497010", VA = "0x180498010")]
	public void GenerateFakeSalesRecords()
	{
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x498B20", Offset = "0x497B20", VA = "0x180498B20")]
	public void UpdateName()
	{
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00005310 File Offset: 0x00003510
	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x49A370", Offset = "0x499370", VA = "0x18049A370")]
	public bool IsOpenAtThisTime(float atTime)
	{
		return default(bool);
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x00005328 File Offset: 0x00003528
	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x49A440", Offset = "0x499440", VA = "0x18049A440")]
	public bool IsOpenAtThisTime(float atTime, float decimalHour, SessionData.WeekDay day)
	{
		return default(bool);
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x00005340 File Offset: 0x00003540
	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x49A540", Offset = "0x499540", VA = "0x18049A540")]
	public bool IsOpenAtDecimalTime(SessionData.WeekDay day, float hour)
	{
		return default(bool);
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x49A5E0", Offset = "0x4995E0", VA = "0x18049A5E0")]
	public void CreateEvidence()
	{
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x49A9E0", Offset = "0x4999E0", VA = "0x18049A9E0")]
	public void CreateItemSingletons()
	{
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x49ADA0", Offset = "0x499DA0", VA = "0x18049ADA0")]
	public void SetupEvidence()
	{
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x49AF70", Offset = "0x499F70", VA = "0x18049AF70")]
	public void OpenCloseCheck()
	{
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x49B0B0", Offset = "0x49A0B0", VA = "0x18049B0B0")]
	public void SetOpen(bool openClosed, bool forceActual = false)
	{
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x49C320", Offset = "0x49B320", VA = "0x18049C320")]
	public void OnAddressCitizenEnter(Citizen cc)
	{
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x49C490", Offset = "0x49B490", VA = "0x18049C490")]
	public void OnAddressCitizenExit(Citizen cc)
	{
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x00005358 File Offset: 0x00003558
	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x49C600", Offset = "0x49B600", VA = "0x18049C600")]
	public int GetNumberOfFilledJobs()
	{
		return 0;
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x49C7A0", Offset = "0x49B7A0", VA = "0x18049C7A0")]
	public void OnActualOpen()
	{
	}

	// Token: 0x060007C4 RID: 1988 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x49CAE0", Offset = "0x49BAE0", VA = "0x18049CAE0")]
	public void OnActualClose()
	{
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x49CEE0", Offset = "0x49BEE0", VA = "0x18049CEE0")]
	public void AddSalesRecord(Human who, InteractablePreset what, float time)
	{
	}

	// Token: 0x060007C6 RID: 1990 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x49D150", Offset = "0x49C150", VA = "0x18049D150")]
	public void AddSalesRecord(Human who, List<InteractablePreset> what, float time)
	{
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x49D3C0", Offset = "0x49C3C0", VA = "0x18049D3C0")]
	public CitySaveData.CompanyCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x49D9E0", Offset = "0x49C9E0", VA = "0x18049D9E0")]
	public void UpdatePassedWorkPosition()
	{
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x49DAD0", Offset = "0x49CAD0", VA = "0x18049DAD0")]
	public void UpdateOpenHoursBasedOnStaff()
	{
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x49E610", Offset = "0x49D610", VA = "0x18049E610")]
	public Company()
	{
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x00005370 File Offset: 0x00003570
	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x49ECC0", Offset = "0x49DCC0", VA = "0x18049ECC0")]
	private bool <SetOpen>b__61_0(Actor item)
	{
		return default(bool);
	}

	// Token: 0x040007FB RID: 2043
	[Token(Token = "0x40007FB")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	// Token: 0x040007FC RID: 2044
	[Token(Token = "0x40007FC")]
	[FieldOffset(Offset = "0x18")]
	public string seed;

	// Token: 0x040007FD RID: 2045
	[Token(Token = "0x40007FD")]
	[FieldOffset(Offset = "0x20")]
	public NewAddress address;

	// Token: 0x040007FE RID: 2046
	[Token(Token = "0x40007FE")]
	[FieldOffset(Offset = "0x28")]
	public NewGameLocation placeOfBusiness;

	// Token: 0x040007FF RID: 2047
	[Token(Token = "0x40007FF")]
	[FieldOffset(Offset = "0x30")]
	public int companyID;

	// Token: 0x04000800 RID: 2048
	[Token(Token = "0x4000800")]
	[FieldOffset(Offset = "0x0")]
	public static int assignCompanyID;

	// Token: 0x04000801 RID: 2049
	[Token(Token = "0x4000801")]
	[FieldOffset(Offset = "0x38")]
	public string shortName;

	// Token: 0x04000802 RID: 2050
	[Token(Token = "0x4000802")]
	[FieldOffset(Offset = "0x40")]
	public List<string> nameAltTags;

	// Token: 0x04000803 RID: 2051
	[Token(Token = "0x4000803")]
	[FieldOffset(Offset = "0x48")]
	public int numberOfRankLevels;

	// Token: 0x04000804 RID: 2052
	[Token(Token = "0x4000804")]
	[FieldOffset(Offset = "0x4C")]
	public int numberOfJobPositions;

	// Token: 0x04000805 RID: 2053
	[Token(Token = "0x4000805")]
	[FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public CompanyPreset preset;

	// Token: 0x04000806 RID: 2054
	[Token(Token = "0x4000806")]
	[FieldOffset(Offset = "0x58")]
	public List<CompanyOpenHoursPreset.CompanyShift> shifts;

	// Token: 0x04000807 RID: 2055
	[Token(Token = "0x4000807")]
	[FieldOffset(Offset = "0x60")]
	public List<Occupation> companyRoster;

	// Token: 0x04000808 RID: 2056
	[Token(Token = "0x4000808")]
	[FieldOffset(Offset = "0x68")]
	public float topSalary;

	// Token: 0x04000809 RID: 2057
	[Token(Token = "0x4000809")]
	[FieldOffset(Offset = "0x6C")]
	public float minimumSalary;

	// Token: 0x0400080A RID: 2058
	[Token(Token = "0x400080A")]
	[FieldOffset(Offset = "0x70")]
	public Human director;

	// Token: 0x0400080B RID: 2059
	[Token(Token = "0x400080B")]
	[FieldOffset(Offset = "0x78")]
	public Human receptionist;

	// Token: 0x0400080C RID: 2060
	[Token(Token = "0x400080C")]
	[FieldOffset(Offset = "0x80")]
	public Human janitor;

	// Token: 0x0400080D RID: 2061
	[Token(Token = "0x400080D")]
	[FieldOffset(Offset = "0x88")]
	public Human security;

	// Token: 0x0400080E RID: 2062
	[Token(Token = "0x400080E")]
	[FieldOffset(Offset = "0x90")]
	public bool publicFacing;

	// Token: 0x0400080F RID: 2063
	[Token(Token = "0x400080F")]
	[FieldOffset(Offset = "0x94")]
	public Color uniformColour;

	// Token: 0x04000810 RID: 2064
	[Token(Token = "0x4000810")]
	[FieldOffset(Offset = "0xA4")]
	[NonSerialized]
	public int passedWorkLocationID;

	// Token: 0x04000811 RID: 2065
	[Token(Token = "0x4000811")]
	[FieldOffset(Offset = "0xA8")]
	[NonSerialized]
	public Interactable passedWorkPosition;

	// Token: 0x04000812 RID: 2066
	[Token(Token = "0x4000812")]
	[FieldOffset(Offset = "0xB0")]
	public bool monday;

	// Token: 0x04000813 RID: 2067
	[Token(Token = "0x4000813")]
	[FieldOffset(Offset = "0xB1")]
	public bool tuesday;

	// Token: 0x04000814 RID: 2068
	[Token(Token = "0x4000814")]
	[FieldOffset(Offset = "0xB2")]
	public bool wednesday;

	// Token: 0x04000815 RID: 2069
	[Token(Token = "0x4000815")]
	[FieldOffset(Offset = "0xB3")]
	public bool thursday;

	// Token: 0x04000816 RID: 2070
	[Token(Token = "0x4000816")]
	[FieldOffset(Offset = "0xB4")]
	public bool friday;

	// Token: 0x04000817 RID: 2071
	[Token(Token = "0x4000817")]
	[FieldOffset(Offset = "0xB5")]
	public bool saturday;

	// Token: 0x04000818 RID: 2072
	[Token(Token = "0x4000818")]
	[FieldOffset(Offset = "0xB6")]
	public bool sunday;

	// Token: 0x04000819 RID: 2073
	[Token(Token = "0x4000819")]
	[FieldOffset(Offset = "0xB8")]
	public List<SessionData.WeekDay> daysOpen;

	// Token: 0x0400081A RID: 2074
	[Token(Token = "0x400081A")]
	[FieldOffset(Offset = "0xC0")]
	public List<SessionData.WeekDay> daysClosed;

	// Token: 0x0400081B RID: 2075
	[Token(Token = "0x400081B")]
	[FieldOffset(Offset = "0xC8")]
	public Vector2 retailOpenHours;

	// Token: 0x0400081C RID: 2076
	[Token(Token = "0x400081C")]
	[FieldOffset(Offset = "0xD0")]
	public bool openForBusinessDesired;

	// Token: 0x0400081D RID: 2077
	[Token(Token = "0x400081D")]
	[FieldOffset(Offset = "0xD1")]
	public bool openForBusinessActual;

	// Token: 0x0400081E RID: 2078
	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0xD8")]
	public List<Occupation> currentStaff;

	// Token: 0x0400081F RID: 2079
	[Token(Token = "0x400081F")]
	[FieldOffset(Offset = "0xE0")]
	[NonSerialized]
	public EvidenceMultiPage employeeRoster;

	// Token: 0x04000820 RID: 2080
	[Token(Token = "0x4000820")]
	[FieldOffset(Offset = "0xE8")]
	[NonSerialized]
	public Evidence menu;

	// Token: 0x04000821 RID: 2081
	[Token(Token = "0x4000821")]
	[FieldOffset(Offset = "0xF0")]
	[NonSerialized]
	public Evidence salesRecords;

	// Token: 0x04000822 RID: 2082
	[Token(Token = "0x4000822")]
	[FieldOffset(Offset = "0xF8")]
	private bool createdEvidence;

	// Token: 0x04000823 RID: 2083
	[Token(Token = "0x4000823")]
	[FieldOffset(Offset = "0x100")]
	public Dictionary<InteractablePreset, int> prices;

	// Token: 0x04000824 RID: 2084
	[Token(Token = "0x4000824")]
	[FieldOffset(Offset = "0x108")]
	public List<Company.SalesRecord> sales;

	// Token: 0x04000825 RID: 2085
	[Token(Token = "0x4000825")]
	[FieldOffset(Offset = "0x110")]
	public Dictionary<RetailItemPreset, Evidence> itemSingletons;

	// Token: 0x04000826 RID: 2086
	[Token(Token = "0x4000826")]
	[FieldOffset(Offset = "0x118")]
	public List<string> debugAddressSet;

	// Token: 0x04000827 RID: 2087
	[Token(Token = "0x4000827")]
	[FieldOffset(Offset = "0x120")]
	public string debugLastOpenedAt;

	// Token: 0x04000828 RID: 2088
	[Token(Token = "0x4000828")]
	[FieldOffset(Offset = "0x128")]
	public string debugLastClosedAt;

	// Token: 0x02000111 RID: 273
	[Token(Token = "0x2000111")]
	[Serializable]
	public class SalesRecord
	{
		// Token: 0x060007CD RID: 1997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x49ED30", Offset = "0x49DD30", VA = "0x18049ED30")]
		public SalesRecord(Company newCompany, Human newPunter, InteractablePreset newItem, float newTime)
		{
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x49EF90", Offset = "0x49DF90", VA = "0x18049EF90")]
		public SalesRecord(Company newCompany, Human newPunter, List<InteractablePreset> newItem, float newTime)
		{
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x49F350", Offset = "0x49E350", VA = "0x18049F350")]
		public Company GetCompany()
		{
			return null;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x49F440", Offset = "0x49E440", VA = "0x18049F440")]
		public Human GetPunter()
		{
			return null;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x49F4C0", Offset = "0x49E4C0", VA = "0x18049F4C0")]
		public void SpawnFact()
		{
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00005388 File Offset: 0x00003588
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x49F9A0", Offset = "0x49E9A0", VA = "0x18049F9A0")]
		private bool <GetCompany>b__9_0(Company item)
		{
			return default(bool);
		}

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		[FieldOffset(Offset = "0x10")]
		public int companyID;

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		[FieldOffset(Offset = "0x14")]
		public int punterID;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		[FieldOffset(Offset = "0x18")]
		public List<string> items;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[FieldOffset(Offset = "0x20")]
		public float time;

		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		[FieldOffset(Offset = "0x24")]
		public float cost;

		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x400082E")]
		[FieldOffset(Offset = "0x28")]
		public int difficulty;

		// Token: 0x0400082F RID: 2095
		[Token(Token = "0x400082F")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Fact fact;
	}

	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000112")]
	private sealed class <>c__DisplayClass47_0
	{
		// Token: 0x060007D3 RID: 2003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass47_0()
		{
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000053A0 File Offset: 0x000035A0
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x49F9C0", Offset = "0x49E9C0", VA = "0x18049F9C0")]
		internal bool <Setup>b__0(CompanyOpenHoursPreset.CompanyShift item)
		{
			return default(bool);
		}

		// Token: 0x04000830 RID: 2096
		[Token(Token = "0x4000830")]
		[FieldOffset(Offset = "0x10")]
		public CompanyStructurePreset.OccupationSettings jobSettings;

		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x4000831")]
		[FieldOffset(Offset = "0x18")]
		public Predicate<CompanyOpenHoursPreset.CompanyShift> <>9__0;
	}

	// Token: 0x02000113 RID: 275
	[Token(Token = "0x2000113")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060007D6 RID: 2006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000053B8 File Offset: 0x000035B8
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x49FAB0", Offset = "0x49EAB0", VA = "0x18049FAB0")]
		internal bool <GetOpenHoursCoverageCountForShift>b__48_0(Occupation item)
		{
			return default(bool);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000053D0 File Offset: 0x000035D0
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x49FAE0", Offset = "0x49EAE0", VA = "0x18049FAE0")]
		internal bool <SetAddress>b__49_0(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000053E8 File Offset: 0x000035E8
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x49FB80", Offset = "0x49EB80", VA = "0x18049FB80")]
		internal bool <UpdateName>b__53_0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00005400 File Offset: 0x00003600
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x49FCB0", Offset = "0x49ECB0", VA = "0x18049FCB0")]
		internal bool <SetOpen>b__61_1(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00005418 File Offset: 0x00003618
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x49FD50", Offset = "0x49ED50", VA = "0x18049FD50")]
		internal bool <GetNumberOfFilledJobs>b__64_0(Occupation item)
		{
			return default(bool);
		}

		// Token: 0x04000832 RID: 2098
		[Token(Token = "0x4000832")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Company.<>c <>9;

		// Token: 0x04000833 RID: 2099
		[Token(Token = "0x4000833")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Occupation> <>9__48_0;

		// Token: 0x04000834 RID: 2100
		[Token(Token = "0x4000834")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<NewAIGoal> <>9__49_0;

		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x4000835")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<NewNode.NodeAccess> <>9__53_0;

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		[FieldOffset(Offset = "0x20")]
		public static Predicate<NewAIGoal> <>9__61_1;

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x28")]
		public static Predicate<Occupation> <>9__64_0;
	}

	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	private sealed class <>c__DisplayClass53_0
	{
		// Token: 0x060007DC RID: 2012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass53_0()
		{
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00005430 File Offset: 0x00003630
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <UpdateName>b__1(SocialStatistics.EthnicityStats item)
		{
			return default(bool);
		}

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x10")]
		public Descriptors.EthnicGroup chosenGroup;
	}

	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	private sealed class <>c__DisplayClass53_1
	{
		// Token: 0x060007DE RID: 2014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass53_1()
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00005448 File Offset: 0x00003648
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <UpdateName>b__2(SocialStatistics.EthnicityStats item)
		{
			return default(bool);
		}

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x10")]
		public Descriptors.EthnicGroup chosenGroup;
	}
}
