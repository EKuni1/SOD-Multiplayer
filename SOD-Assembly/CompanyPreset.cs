using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007A9 RID: 1961
[Token(Token = "0x20007A9")]
public class CompanyPreset : SoCustomComparison
{
	// Token: 0x06002940 RID: 10560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002940")]
	[Address(RVA = "0xCA2360", Offset = "0xCA1360", VA = "0x180CA2360")]
	public CompanyPreset()
	{
	}

	// Token: 0x04003879 RID: 14457
	[Token(Token = "0x4003879")]
	[FieldOffset(Offset = "0x20")]
	public List<CompanyPreset.CompanyCategory> companyCategories;

	// Token: 0x0400387A RID: 14458
	[Token(Token = "0x400387A")]
	[FieldOffset(Offset = "0x28")]
	public bool createMenu;

	// Token: 0x0400387B RID: 14459
	[Token(Token = "0x400387B")]
	[FieldOffset(Offset = "0x29")]
	public bool isIllegal;

	// Token: 0x0400387C RID: 14460
	[Token(Token = "0x400387C")]
	[FieldOffset(Offset = "0x2A")]
	public bool useBuildingName;

	// Token: 0x0400387D RID: 14461
	[Token(Token = "0x400387D")]
	[FieldOffset(Offset = "0x2B")]
	public bool useBuildingOverrideName;

	// Token: 0x0400387E RID: 14462
	[Token(Token = "0x400387E")]
	[FieldOffset(Offset = "0x30")]
	public List<string> overrideSuffixList;

	// Token: 0x0400387F RID: 14463
	[Token(Token = "0x400387F")]
	[FieldOffset(Offset = "0x38")]
	public float useStreetNameChance;

	// Token: 0x04003880 RID: 14464
	[Token(Token = "0x4003880")]
	[FieldOffset(Offset = "0x3C")]
	public float useDistrictNameChance;

	// Token: 0x04003881 RID: 14465
	[Token(Token = "0x4003881")]
	[FieldOffset(Offset = "0x40")]
	public float useOwnerFirstNameChance;

	// Token: 0x04003882 RID: 14466
	[Token(Token = "0x4003882")]
	[FieldOffset(Offset = "0x44")]
	public float useOwnerSurNameChance;

	// Token: 0x04003883 RID: 14467
	[Token(Token = "0x4003883")]
	[FieldOffset(Offset = "0x48")]
	public float useCompanyNameListChance;

	// Token: 0x04003884 RID: 14468
	[Token(Token = "0x4003884")]
	[FieldOffset(Offset = "0x4C")]
	public int aliterationWeight;

	// Token: 0x04003885 RID: 14469
	[Token(Token = "0x4003885")]
	[FieldOffset(Offset = "0x50")]
	public float prefixChance;

	// Token: 0x04003886 RID: 14470
	[Token(Token = "0x4003886")]
	[FieldOffset(Offset = "0x58")]
	public List<string> prefixList;

	// Token: 0x04003887 RID: 14471
	[Token(Token = "0x4003887")]
	[FieldOffset(Offset = "0x60")]
	public float mainChance;

	// Token: 0x04003888 RID: 14472
	[Token(Token = "0x4003888")]
	[FieldOffset(Offset = "0x68")]
	public List<string> mainNamingList;

	// Token: 0x04003889 RID: 14473
	[Token(Token = "0x4003889")]
	[FieldOffset(Offset = "0x70")]
	public List<string> suffixList;

	// Token: 0x0400388A RID: 14474
	[Token(Token = "0x400388A")]
	[FieldOffset(Offset = "0x78")]
	public List<CompanyPreset.TheRule> theRules;

	// Token: 0x0400388B RID: 14475
	[Token(Token = "0x400388B")]
	[FieldOffset(Offset = "0x80")]
	public CompanyPreset.SalaryRange minimumSalary;

	// Token: 0x0400388C RID: 14476
	[Token(Token = "0x400388C")]
	[FieldOffset(Offset = "0x84")]
	public CompanyPreset.SalaryRange topSalary;

	// Token: 0x0400388D RID: 14477
	[Token(Token = "0x400388D")]
	[FieldOffset(Offset = "0x88")]
	public AnimationCurve payGradeCurve;

	// Token: 0x0400388E RID: 14478
	[Token(Token = "0x400388E")]
	[FieldOffset(Offset = "0x90")]
	public bool publicFacing;

	// Token: 0x0400388F RID: 14479
	[Token(Token = "0x400388F")]
	[FieldOffset(Offset = "0x91")]
	public bool isSelfEmployed;

	// Token: 0x04003890 RID: 14480
	[Token(Token = "0x4003890")]
	[FieldOffset(Offset = "0x92")]
	public bool autoCreate;

	// Token: 0x04003891 RID: 14481
	[Token(Token = "0x4003891")]
	[FieldOffset(Offset = "0x94")]
	public int priority;

	// Token: 0x04003892 RID: 14482
	[Token(Token = "0x4003892")]
	[FieldOffset(Offset = "0x98")]
	public float cityPopRatio;

	// Token: 0x04003893 RID: 14483
	[Token(Token = "0x4003893")]
	[FieldOffset(Offset = "0x9C")]
	public int minimumNumber;

	// Token: 0x04003894 RID: 14484
	[Token(Token = "0x4003894")]
	[FieldOffset(Offset = "0xA0")]
	public int maximumNumber;

	// Token: 0x04003895 RID: 14485
	[Token(Token = "0x4003895")]
	[FieldOffset(Offset = "0xA4")]
	public bool enableLoiteringBehaviour;

	// Token: 0x04003896 RID: 14486
	[Token(Token = "0x4003896")]
	[FieldOffset(Offset = "0xA8")]
	public List<MenuPreset> menus;

	// Token: 0x04003897 RID: 14487
	[Token(Token = "0x4003897")]
	[FieldOffset(Offset = "0xB0")]
	public bool recordSalesData;

	// Token: 0x04003898 RID: 14488
	[Token(Token = "0x4003898")]
	[FieldOffset(Offset = "0xB4")]
	public int previousFakeSalesRecords;

	// Token: 0x04003899 RID: 14489
	[Token(Token = "0x4003899")]
	[FieldOffset(Offset = "0xB8")]
	public List<CharacterTrait> requiredTraits;

	// Token: 0x0400389A RID: 14490
	[Token(Token = "0x400389A")]
	[FieldOffset(Offset = "0xC0")]
	public bool enableSelling;

	// Token: 0x0400389B RID: 14491
	[Token(Token = "0x400389B")]
	[FieldOffset(Offset = "0xC1")]
	public bool enableSellingOfIllegalItems;

	// Token: 0x0400389C RID: 14492
	[Token(Token = "0x400389C")]
	[FieldOffset(Offset = "0xC4")]
	public float sellValueMultiplier;

	// Token: 0x0400389D RID: 14493
	[Token(Token = "0x400389D")]
	[FieldOffset(Offset = "0xC8")]
	public List<Color> possibleUniformColours;

	// Token: 0x0400389E RID: 14494
	[Token(Token = "0x400389E")]
	[FieldOffset(Offset = "0xD0")]
	public CompanyOpenHoursPreset workHours;

	// Token: 0x0400389F RID: 14495
	[Token(Token = "0x400389F")]
	[FieldOffset(Offset = "0xD8")]
	public CompanyStructurePreset structure;

	// Token: 0x040038A0 RID: 14496
	[Token(Token = "0x40038A0")]
	[FieldOffset(Offset = "0xE0")]
	public bool controlsBuildingSurveillance;

	// Token: 0x040038A1 RID: 14497
	[Token(Token = "0x40038A1")]
	[FieldOffset(Offset = "0xE1")]
	public bool isHotel;

	// Token: 0x020007AA RID: 1962
	[Token(Token = "0x20007AA")]
	public enum CompanyCategory
	{
		// Token: 0x040038A3 RID: 14499
		[Token(Token = "0x40038A3")]
		meal,
		// Token: 0x040038A4 RID: 14500
		[Token(Token = "0x40038A4")]
		snack,
		// Token: 0x040038A5 RID: 14501
		[Token(Token = "0x40038A5")]
		caffeine,
		// Token: 0x040038A6 RID: 14502
		[Token(Token = "0x40038A6")]
		groceries,
		// Token: 0x040038A7 RID: 14503
		[Token(Token = "0x40038A7")]
		washing,
		// Token: 0x040038A8 RID: 14504
		[Token(Token = "0x40038A8")]
		medical,
		// Token: 0x040038A9 RID: 14505
		[Token(Token = "0x40038A9")]
		recreational,
		// Token: 0x040038AA RID: 14506
		[Token(Token = "0x40038AA")]
		retail
	}

	// Token: 0x020007AB RID: 1963
	[Token(Token = "0x20007AB")]
	public enum SalaryRange
	{
		// Token: 0x040038AC RID: 14508
		[Token(Token = "0x40038AC")]
		illegal,
		// Token: 0x040038AD RID: 14509
		[Token(Token = "0x40038AD")]
		minimumWage,
		// Token: 0x040038AE RID: 14510
		[Token(Token = "0x40038AE")]
		low,
		// Token: 0x040038AF RID: 14511
		[Token(Token = "0x40038AF")]
		average,
		// Token: 0x040038B0 RID: 14512
		[Token(Token = "0x40038B0")]
		aboveAverage,
		// Token: 0x040038B1 RID: 14513
		[Token(Token = "0x40038B1")]
		high,
		// Token: 0x040038B2 RID: 14514
		[Token(Token = "0x40038B2")]
		veryHigh,
		// Token: 0x040038B3 RID: 14515
		[Token(Token = "0x40038B3")]
		extreme,
		// Token: 0x040038B4 RID: 14516
		[Token(Token = "0x40038B4")]
		millionaire
	}

	// Token: 0x020007AC RID: 1964
	[Token(Token = "0x20007AC")]
	public enum NameComponent
	{
		// Token: 0x040038B6 RID: 14518
		[Token(Token = "0x40038B6")]
		prefix,
		// Token: 0x040038B7 RID: 14519
		[Token(Token = "0x40038B7")]
		main,
		// Token: 0x040038B8 RID: 14520
		[Token(Token = "0x40038B8")]
		suffix
	}

	// Token: 0x020007AD RID: 1965
	[Token(Token = "0x20007AD")]
	[Serializable]
	public class TheRule
	{
		// Token: 0x06002941 RID: 10561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002941")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public TheRule()
		{
		}

		// Token: 0x040038B9 RID: 14521
		[Token(Token = "0x40038B9")]
		[FieldOffset(Offset = "0x10")]
		public CompanyPreset.NameComponent component;

		// Token: 0x040038BA RID: 14522
		[Token(Token = "0x40038BA")]
		[FieldOffset(Offset = "0x14")]
		public bool exists;

		// Token: 0x040038BB RID: 14523
		[Token(Token = "0x40038BB")]
		[FieldOffset(Offset = "0x18")]
		public float chanceModifier;
	}
}
