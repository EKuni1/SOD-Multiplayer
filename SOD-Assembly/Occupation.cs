using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200015D RID: 349
[Token(Token = "0x200015D")]
public class Occupation : IEnumerator<object>
{
	// Token: 0x06000958 RID: 2392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000958")]
	[Address(RVA = "0x4FEDE0", Offset = "0x4FDDE0", VA = "0x1804FEDE0")]
	public void Setup()
	{
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000959")]
	[Address(RVA = "0x4FF630", Offset = "0x4FE630", VA = "0x1804FF630")]
	public void Load(CitySaveData.OccupationCitySave data, Company newCompany)
	{
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x00006210 File Offset: 0x00004410
	[Token(Token = "0x600095A")]
	[Address(RVA = "0x4FFA00", Offset = "0x4FEA00", VA = "0x1804FFA00")]
	public bool IsAtWork(float atTime)
	{
		return default(bool);
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600095B")]
	[Address(RVA = "0x4FFC20", Offset = "0x4FEC20", VA = "0x1804FFC20")]
	public CitySaveData.OccupationCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600095C")]
	[Address(RVA = "0x4FFF60", Offset = "0x4FEF60", VA = "0x1804FFF60")]
	public string GetWorkingHoursString()
	{
		return null;
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x00006228 File Offset: 0x00004428
	[Token(Token = "0x600095D")]
	[Address(RVA = "0x5007E0", Offset = "0x4FF7E0", VA = "0x1805007E0", Slot = "4")]
	public int CompareTo(Occupation paygrade)
	{
		return 0;
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600095E")]
	[Address(RVA = "0x500860", Offset = "0x4FF860", VA = "0x180500860")]
	public Occupation()
	{
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x00006240 File Offset: 0x00004440
	[Token(Token = "0x6000960")]
	[Address(RVA = "0x500CF0", Offset = "0x4FFCF0", VA = "0x180500CF0")]
	private bool <GenerateSaveData>b__26_0(CompanyOpenHoursPreset.CompanyShift item)
	{
		return default(bool);
	}

	// Token: 0x04000996 RID: 2454
	[Token(Token = "0x4000996")]
	[FieldOffset(Offset = "0x10")]
	public int id;

	// Token: 0x04000997 RID: 2455
	[Token(Token = "0x4000997")]
	[FieldOffset(Offset = "0x0")]
	[NonSerialized]
	public static int idAssign;

	// Token: 0x04000998 RID: 2456
	[Token(Token = "0x4000998")]
	[FieldOffset(Offset = "0x18")]
	public OccupationPreset preset;

	// Token: 0x04000999 RID: 2457
	[Token(Token = "0x4000999")]
	[FieldOffset(Offset = "0x20")]
	public string name;

	// Token: 0x0400099A RID: 2458
	[Token(Token = "0x400099A")]
	[FieldOffset(Offset = "0x28")]
	public Company employer;

	// Token: 0x0400099B RID: 2459
	[Token(Token = "0x400099B")]
	[FieldOffset(Offset = "0x30")]
	public bool isAgent;

	// Token: 0x0400099C RID: 2460
	[Token(Token = "0x400099C")]
	[FieldOffset(Offset = "0x31")]
	public bool teamLeader;

	// Token: 0x0400099D RID: 2461
	[Token(Token = "0x400099D")]
	[FieldOffset(Offset = "0x38")]
	public Occupation boss;

	// Token: 0x0400099E RID: 2462
	[Token(Token = "0x400099E")]
	[FieldOffset(Offset = "0x40")]
	public float paygrade;

	// Token: 0x0400099F RID: 2463
	[Token(Token = "0x400099F")]
	[FieldOffset(Offset = "0x44")]
	public int teamID;

	// Token: 0x040009A0 RID: 2464
	[Token(Token = "0x40009A0")]
	[FieldOffset(Offset = "0x48")]
	public bool isOwner;

	// Token: 0x040009A1 RID: 2465
	[Token(Token = "0x40009A1")]
	[FieldOffset(Offset = "0x4C")]
	public OccupationPreset.workType work;

	// Token: 0x040009A2 RID: 2466
	[Token(Token = "0x40009A2")]
	[FieldOffset(Offset = "0x50")]
	public List<OccupationPreset.workTags> tags;

	// Token: 0x040009A3 RID: 2467
	[Token(Token = "0x40009A3")]
	[FieldOffset(Offset = "0x58")]
	public CompanyOpenHoursPreset.CompanyShift shift;

	// Token: 0x040009A4 RID: 2468
	[Token(Token = "0x40009A4")]
	[FieldOffset(Offset = "0x60")]
	public float workHours;

	// Token: 0x040009A5 RID: 2469
	[Token(Token = "0x40009A5")]
	[FieldOffset(Offset = "0x64")]
	public float startTimeDecimalHour;

	// Token: 0x040009A6 RID: 2470
	[Token(Token = "0x40009A6")]
	[FieldOffset(Offset = "0x68")]
	public float endTimeDecialHour;

	// Token: 0x040009A7 RID: 2471
	[Token(Token = "0x40009A7")]
	[FieldOffset(Offset = "0x6C")]
	public bool lunchBreak;

	// Token: 0x040009A8 RID: 2472
	[Token(Token = "0x40009A8")]
	[FieldOffset(Offset = "0x70")]
	public float lunchBreakHoursAfterStart;

	// Token: 0x040009A9 RID: 2473
	[Token(Token = "0x40009A9")]
	[FieldOffset(Offset = "0x78")]
	[NonSerialized]
	public List<SessionData.WeekDay> workDaysList;

	// Token: 0x040009AA RID: 2474
	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x80")]
	public float salary;

	// Token: 0x040009AB RID: 2475
	[Token(Token = "0x40009AB")]
	[FieldOffset(Offset = "0x88")]
	public string salaryString;

	// Token: 0x040009AC RID: 2476
	[Token(Token = "0x40009AC")]
	[FieldOffset(Offset = "0x90")]
	public Human employee;

	// Token: 0x040009AD RID: 2477
	[Token(Token = "0x40009AD")]
	[FieldOffset(Offset = "0x8")]
	public static Comparison<Occupation> SalaryComparison;

	// Token: 0x040009AE RID: 2478
	[Token(Token = "0x40009AE")]
	[FieldOffset(Offset = "0x10")]
	public static Comparison<Occupation> FillPriorityComparison;

	// Token: 0x0200015E RID: 350
	[Token(Token = "0x200015E")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000962 RID: 2402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000962")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00006258 File Offset: 0x00004458
		[Token(Token = "0x6000963")]
		[Address(RVA = "0x500DB0", Offset = "0x4FFDB0", VA = "0x180500DB0")]
		internal int <.cctor>b__32_0(Occupation object1, Occupation object2)
		{
			return 0;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00006270 File Offset: 0x00004470
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x500E40", Offset = "0x4FFE40", VA = "0x180500E40")]
		internal int <.cctor>b__32_1(Occupation object1, Occupation object2)
		{
			return 0;
		}

		// Token: 0x040009AF RID: 2479
		[Token(Token = "0x40009AF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Occupation.<>c <>9;
	}
}
