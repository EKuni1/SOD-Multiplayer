using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020007AE RID: 1966
[Token(Token = "0x20007AE")]
public class CompanyStructurePreset : SoCustomComparison
{
	// Token: 0x06002942 RID: 10562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002942")]
	[Address(RVA = "0x5C7970", Offset = "0x5C6970", VA = "0x1805C7970")]
	public CompanyStructurePreset()
	{
	}

	// Token: 0x040038BC RID: 14524
	[Token(Token = "0x40038BC")]
	[FieldOffset(Offset = "0x20")]
	public CompanyStructurePreset.BossConfig companyStructure;

	// Token: 0x020007AF RID: 1967
	[Token(Token = "0x20007AF")]
	[Serializable]
	public class OccupationSettings
	{
		// Token: 0x06002943 RID: 10563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002943")]
		[Address(RVA = "0xCA2930", Offset = "0xCA1930", VA = "0x180CA2930")]
		public OccupationSettings()
		{
		}

		// Token: 0x040038BD RID: 14525
		[Token(Token = "0x40038BD")]
		[FieldOffset(Offset = "0x10")]
		public OccupationPreset occupation;

		// Token: 0x040038BE RID: 14526
		[Token(Token = "0x40038BE")]
		[FieldOffset(Offset = "0x18")]
		public int positionsMinimum;

		// Token: 0x040038BF RID: 14527
		[Token(Token = "0x40038BF")]
		[FieldOffset(Offset = "0x1C")]
		public int positionsMaximum;

		// Token: 0x040038C0 RID: 14528
		[Token(Token = "0x40038C0")]
		[FieldOffset(Offset = "0x20")]
		public float payGrade;
	}

	// Token: 0x020007B0 RID: 1968
	[Token(Token = "0x20007B0")]
	[Serializable]
	public class BossConfig : CompanyStructurePreset.OccupationSettings
	{
		// Token: 0x06002944 RID: 10564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002944")]
		[Address(RVA = "0xCA2950", Offset = "0xCA1950", VA = "0x180CA2950")]
		public BossConfig()
		{
		}

		// Token: 0x040038C1 RID: 14529
		[Token(Token = "0x40038C1")]
		[FieldOffset(Offset = "0x28")]
		public List<CompanyStructurePreset.Hierarchy1Config> subordinates;
	}

	// Token: 0x020007B1 RID: 1969
	[Token(Token = "0x20007B1")]
	[Serializable]
	public class Hierarchy1Config : CompanyStructurePreset.OccupationSettings
	{
		// Token: 0x06002945 RID: 10565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002945")]
		[Address(RVA = "0xCA2A20", Offset = "0xCA1A20", VA = "0x180CA2A20")]
		public Hierarchy1Config()
		{
		}

		// Token: 0x040038C2 RID: 14530
		[Token(Token = "0x40038C2")]
		[FieldOffset(Offset = "0x28")]
		public List<CompanyStructurePreset.Hierarchy2Config> subordinates;
	}

	// Token: 0x020007B2 RID: 1970
	[Token(Token = "0x20007B2")]
	[Serializable]
	public class Hierarchy2Config : CompanyStructurePreset.OccupationSettings
	{
		// Token: 0x06002946 RID: 10566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002946")]
		[Address(RVA = "0xCA2AF0", Offset = "0xCA1AF0", VA = "0x180CA2AF0")]
		public Hierarchy2Config()
		{
		}

		// Token: 0x040038C3 RID: 14531
		[Token(Token = "0x40038C3")]
		[FieldOffset(Offset = "0x28")]
		public List<CompanyStructurePreset.Hierarchy3Config> subordinates;
	}

	// Token: 0x020007B3 RID: 1971
	[Token(Token = "0x20007B3")]
	[Serializable]
	public class Hierarchy3Config : CompanyStructurePreset.OccupationSettings
	{
		// Token: 0x06002947 RID: 10567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002947")]
		[Address(RVA = "0xCA2BC0", Offset = "0xCA1BC0", VA = "0x180CA2BC0")]
		public Hierarchy3Config()
		{
		}

		// Token: 0x040038C4 RID: 14532
		[Token(Token = "0x40038C4")]
		[FieldOffset(Offset = "0x28")]
		public List<CompanyStructurePreset.OccupationSettings> subordinates;
	}

	// Token: 0x020007B4 RID: 1972
	[Token(Token = "0x20007B4")]
	[Serializable]
	public class Hierarchy4Config : CompanyStructurePreset.OccupationSettings
	{
		// Token: 0x06002948 RID: 10568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002948")]
		[Address(RVA = "0xCA2930", Offset = "0xCA1930", VA = "0x180CA2930")]
		public Hierarchy4Config()
		{
		}
	}
}
