using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200015F RID: 351
[Token(Token = "0x200015F")]
public class ResidenceController : Controller, IEnumerator<object>
{
	// Token: 0x06000965 RID: 2405 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000965")]
	[Address(RVA = "0x500E90", Offset = "0x4FFE90", VA = "0x180500E90")]
	public void Setup(ResidencePreset newPreset, NewAddress newAddress)
	{
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000966")]
	[Address(RVA = "0x5012F0", Offset = "0x5002F0", VA = "0x1805012F0")]
	public string GetResidenceString()
	{
		return null;
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00006288 File Offset: 0x00004488
	[Token(Token = "0x6000967")]
	[Address(RVA = "0x501620", Offset = "0x500620", VA = "0x180501620")]
	public int GetResidenceNumber()
	{
		return 0;
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000968")]
	[Address(RVA = "0x501850", Offset = "0x500850", VA = "0x180501850")]
	public void AddBedroom(NewRoom newBedroom)
	{
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000969")]
	[Address(RVA = "0x501900", Offset = "0x500900", VA = "0x180501900")]
	public void Load(CitySaveData.ResidenceCitySave data, NewAddress newAddress)
	{
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600096A")]
	[Address(RVA = "0x501A70", Offset = "0x500A70", VA = "0x180501A70")]
	public CitySaveData.ResidenceCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600096B")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
	public override void CreateEvidence()
	{
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x000062A0 File Offset: 0x000044A0
	[Token(Token = "0x600096C")]
	[Address(RVA = "0x501B40", Offset = "0x500B40", VA = "0x180501B40", Slot = "6")]
	public int CompareTo(ResidenceController other)
	{
		return 0;
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600096D")]
	[Address(RVA = "0x501BE0", Offset = "0x500BE0", VA = "0x180501BE0")]
	public ResidenceController()
	{
	}

	// Token: 0x040009B0 RID: 2480
	[Token(Token = "0x40009B0")]
	[FieldOffset(Offset = "0x18")]
	public ResidencePreset preset;

	// Token: 0x040009B1 RID: 2481
	[Token(Token = "0x40009B1")]
	[FieldOffset(Offset = "0x20")]
	public NewBuilding building;

	// Token: 0x040009B2 RID: 2482
	[Token(Token = "0x40009B2")]
	[FieldOffset(Offset = "0x28")]
	public NewAddress address;

	// Token: 0x040009B3 RID: 2483
	[Token(Token = "0x40009B3")]
	[FieldOffset(Offset = "0x30")]
	public List<NewRoom> bedrooms;

	// Token: 0x040009B4 RID: 2484
	[Token(Token = "0x40009B4")]
	[FieldOffset(Offset = "0x38")]
	[NonSerialized]
	public int bedroomsTaken;

	// Token: 0x040009B5 RID: 2485
	[Token(Token = "0x40009B5")]
	[FieldOffset(Offset = "0x40")]
	[NonSerialized]
	public FurnitureLocation mailbox;

	// Token: 0x040009B6 RID: 2486
	[Token(Token = "0x40009B6")]
	[FieldOffset(Offset = "0x0")]
	public static Comparison<ResidenceController> RoommateComparison;

	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000970 RID: 2416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000062B8 File Offset: 0x000044B8
		[Token(Token = "0x6000971")]
		[Address(RVA = "0x501EC0", Offset = "0x500EC0", VA = "0x180501EC0")]
		internal bool <Setup>b__6_0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000062D0 File Offset: 0x000044D0
		[Token(Token = "0x6000972")]
		[Address(RVA = "0x501F70", Offset = "0x500F70", VA = "0x180501F70")]
		internal int <.cctor>b__16_0(ResidenceController object1, ResidenceController object2)
		{
			return 0;
		}

		// Token: 0x040009B7 RID: 2487
		[Token(Token = "0x40009B7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ResidenceController.<>c <>9;

		// Token: 0x040009B8 RID: 2488
		[Token(Token = "0x40009B8")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<NewRoom> <>9__6_0;
	}
}
