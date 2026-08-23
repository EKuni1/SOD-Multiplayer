using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000864 RID: 2148
[Token(Token = "0x2000864")]
public class OccupationPreset : SoCustomComparison
{
	// Token: 0x060029D3 RID: 10707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029D3")]
	[Address(RVA = "0xCB0050", Offset = "0xCAF050", VA = "0x180CB0050")]
	public void CopyOutfitFromSelectedPreset()
	{
	}

	// Token: 0x060029D4 RID: 10708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029D4")]
	[Address(RVA = "0xCB0110", Offset = "0xCAF110", VA = "0x180CB0110")]
	public OccupationPreset()
	{
	}

	// Token: 0x040040FE RID: 16638
	[Token(Token = "0x40040FE")]
	[FieldOffset(Offset = "0x20")]
	public OccupationPreset.workType work;

	// Token: 0x040040FF RID: 16639
	[Token(Token = "0x40040FF")]
	[FieldOffset(Offset = "0x28")]
	public List<OccupationPreset.workTags> tags;

	// Token: 0x04004100 RID: 16640
	[Token(Token = "0x4004100")]
	[FieldOffset(Offset = "0x30")]
	public int jobFillPriority;

	// Token: 0x04004101 RID: 16641
	[Token(Token = "0x4004101")]
	[FieldOffset(Offset = "0x38")]
	public List<ClothesPreset> workOutfit;

	// Token: 0x04004102 RID: 16642
	[Token(Token = "0x4004102")]
	[FieldOffset(Offset = "0x40")]
	public bool selfEmployed;

	// Token: 0x04004103 RID: 16643
	[Token(Token = "0x4004103")]
	[FieldOffset(Offset = "0x41")]
	public bool receptionist;

	// Token: 0x04004104 RID: 16644
	[Token(Token = "0x4004104")]
	[FieldOffset(Offset = "0x42")]
	public bool canAskAboutJob;

	// Token: 0x04004105 RID: 16645
	[Token(Token = "0x4004105")]
	[FieldOffset(Offset = "0x43")]
	public bool janitor;

	// Token: 0x04004106 RID: 16646
	[Token(Token = "0x4004106")]
	[FieldOffset(Offset = "0x44")]
	public bool security;

	// Token: 0x04004107 RID: 16647
	[Token(Token = "0x4004107")]
	[FieldOffset(Offset = "0x45")]
	public bool isCriminal;

	// Token: 0x04004108 RID: 16648
	[Token(Token = "0x4004108")]
	[FieldOffset(Offset = "0x46")]
	public bool isPublicFacing;

	// Token: 0x04004109 RID: 16649
	[Token(Token = "0x4004109")]
	[FieldOffset(Offset = "0x48")]
	public int minimumPerCity;

	// Token: 0x0400410A RID: 16650
	[Token(Token = "0x400410A")]
	[FieldOffset(Offset = "0x4C")]
	public float societalClass;

	// Token: 0x0400410B RID: 16651
	[Token(Token = "0x400410B")]
	[FieldOffset(Offset = "0x50")]
	public float skewPersonalityTowardsJobFit;

	// Token: 0x0400410C RID: 16652
	[Token(Token = "0x400410C")]
	[FieldOffset(Offset = "0x54")]
	public bool skewHumility;

	// Token: 0x0400410D RID: 16653
	[Token(Token = "0x400410D")]
	[FieldOffset(Offset = "0x58")]
	public float humility;

	// Token: 0x0400410E RID: 16654
	[Token(Token = "0x400410E")]
	[FieldOffset(Offset = "0x5C")]
	public bool skewEmotionality;

	// Token: 0x0400410F RID: 16655
	[Token(Token = "0x400410F")]
	[FieldOffset(Offset = "0x60")]
	public float emotionality;

	// Token: 0x04004110 RID: 16656
	[Token(Token = "0x4004110")]
	[FieldOffset(Offset = "0x64")]
	public bool skewExtraversion;

	// Token: 0x04004111 RID: 16657
	[Token(Token = "0x4004111")]
	[FieldOffset(Offset = "0x68")]
	public float extraversion;

	// Token: 0x04004112 RID: 16658
	[Token(Token = "0x4004112")]
	[FieldOffset(Offset = "0x6C")]
	public bool skewAgreeableness;

	// Token: 0x04004113 RID: 16659
	[Token(Token = "0x4004113")]
	[FieldOffset(Offset = "0x70")]
	public float agreeableness;

	// Token: 0x04004114 RID: 16660
	[Token(Token = "0x4004114")]
	[FieldOffset(Offset = "0x74")]
	public bool skewConscientiousness;

	// Token: 0x04004115 RID: 16661
	[Token(Token = "0x4004115")]
	[FieldOffset(Offset = "0x78")]
	public float conscientiousness;

	// Token: 0x04004116 RID: 16662
	[Token(Token = "0x4004116")]
	[FieldOffset(Offset = "0x7C")]
	public bool skewCreativity;

	// Token: 0x04004117 RID: 16663
	[Token(Token = "0x4004117")]
	[FieldOffset(Offset = "0x80")]
	public float creativity;

	// Token: 0x04004118 RID: 16664
	[Token(Token = "0x4004118")]
	[FieldOffset(Offset = "0x84")]
	public bool shiftTimeIsImportant;

	// Token: 0x04004119 RID: 16665
	[Token(Token = "0x4004119")]
	[FieldOffset(Offset = "0x88")]
	public OccupationPreset.ShiftType shiftType;

	// Token: 0x0400411A RID: 16666
	[Token(Token = "0x400411A")]
	[FieldOffset(Offset = "0x8C")]
	public bool countsTowardsOpenHoursCoverage;

	// Token: 0x0400411B RID: 16667
	[Token(Token = "0x400411B")]
	[FieldOffset(Offset = "0x8D")]
	public bool lunchBreakAllowed;

	// Token: 0x0400411C RID: 16668
	[Token(Token = "0x400411C")]
	[FieldOffset(Offset = "0x90")]
	public OccupationPreset.JobAI jobAIPosition;

	// Token: 0x0400411D RID: 16669
	[Token(Token = "0x400411D")]
	[FieldOffset(Offset = "0x98")]
	public List<RoomConfiguration> bannedRooms;

	// Token: 0x0400411E RID: 16670
	[Token(Token = "0x400411E")]
	[FieldOffset(Offset = "0xA0")]
	public List<AIGoalPreset.GoalActionSetup> actionSetup;

	// Token: 0x0400411F RID: 16671
	[Token(Token = "0x400411F")]
	[FieldOffset(Offset = "0xA8")]
	public InteractablePreset.SpecialCase jobPostion;

	// Token: 0x04004120 RID: 16672
	[Token(Token = "0x4004120")]
	[FieldOffset(Offset = "0xAC")]
	public bool ownsWorkPosition;

	// Token: 0x04004121 RID: 16673
	[Token(Token = "0x4004121")]
	[FieldOffset(Offset = "0xB0")]
	public List<RoomConfiguration> preferredRooms;

	// Token: 0x04004122 RID: 16674
	[Token(Token = "0x4004122")]
	[FieldOffset(Offset = "0xB8")]
	public Vector2 potterFrequency;

	// Token: 0x04004123 RID: 16675
	[Token(Token = "0x4004123")]
	[FieldOffset(Offset = "0xC0")]
	public bool onlyPotterIfSomebodyElseWorking;

	// Token: 0x04004124 RID: 16676
	[Token(Token = "0x4004124")]
	[FieldOffset(Offset = "0xC8")]
	public List<AIActionPreset> potterActions;

	// Token: 0x04004125 RID: 16677
	[Token(Token = "0x4004125")]
	[FieldOffset(Offset = "0xD0")]
	public bool canPickUpLitter;

	// Token: 0x04004126 RID: 16678
	[Token(Token = "0x4004126")]
	[FieldOffset(Offset = "0xD1")]
	public bool namePlacard;

	// Token: 0x04004127 RID: 16679
	[Token(Token = "0x4004127")]
	[FieldOffset(Offset = "0xD2")]
	public bool employeePhoto;

	// Token: 0x04004128 RID: 16680
	[Token(Token = "0x4004128")]
	[FieldOffset(Offset = "0xD3")]
	public bool businessCards;

	// Token: 0x04004129 RID: 16681
	[Token(Token = "0x4004129")]
	[FieldOffset(Offset = "0xD4")]
	public bool workRota;

	// Token: 0x0400412A RID: 16682
	[Token(Token = "0x400412A")]
	[FieldOffset(Offset = "0xD5")]
	public bool employmentContract;

	// Token: 0x0400412B RID: 16683
	[Token(Token = "0x400412B")]
	[FieldOffset(Offset = "0xD8")]
	public List<InteractablePreset> jobItems;

	// Token: 0x0400412C RID: 16684
	[Token(Token = "0x400412C")]
	[FieldOffset(Offset = "0xE0")]
	public List<InteractablePreset> inventoryItems;

	// Token: 0x0400412D RID: 16685
	[Token(Token = "0x400412D")]
	[FieldOffset(Offset = "0xE8")]
	public List<GroupPreset> joinGroups;

	// Token: 0x0400412E RID: 16686
	[Token(Token = "0x400412E")]
	[FieldOffset(Offset = "0xF0")]
	public List<DialogPreset> addDialog;

	// Token: 0x0400412F RID: 16687
	[Token(Token = "0x400412F")]
	[FieldOffset(Offset = "0xF8")]
	public OccupationPreset selectedPreset;

	// Token: 0x02000865 RID: 2149
	[Token(Token = "0x2000865")]
	public enum workType
	{
		// Token: 0x04004131 RID: 16689
		[Token(Token = "0x4004131")]
		Office,
		// Token: 0x04004132 RID: 16690
		[Token(Token = "0x4004132")]
		Management,
		// Token: 0x04004133 RID: 16691
		[Token(Token = "0x4004133")]
		Labourer,
		// Token: 0x04004134 RID: 16692
		[Token(Token = "0x4004134")]
		Janitorial,
		// Token: 0x04004135 RID: 16693
		[Token(Token = "0x4004135")]
		Retail,
		// Token: 0x04004136 RID: 16694
		[Token(Token = "0x4004136")]
		Service,
		// Token: 0x04004137 RID: 16695
		[Token(Token = "0x4004137")]
		Driver,
		// Token: 0x04004138 RID: 16696
		[Token(Token = "0x4004138")]
		PublicSector,
		// Token: 0x04004139 RID: 16697
		[Token(Token = "0x4004139")]
		Enforcer,
		// Token: 0x0400413A RID: 16698
		[Token(Token = "0x400413A")]
		Criminal,
		// Token: 0x0400413B RID: 16699
		[Token(Token = "0x400413B")]
		Creative,
		// Token: 0x0400413C RID: 16700
		[Token(Token = "0x400413C")]
		Other,
		// Token: 0x0400413D RID: 16701
		[Token(Token = "0x400413D")]
		Student,
		// Token: 0x0400413E RID: 16702
		[Token(Token = "0x400413E")]
		Unemployed,
		// Token: 0x0400413F RID: 16703
		[Token(Token = "0x400413F")]
		Retired,
		// Token: 0x04004140 RID: 16704
		[Token(Token = "0x4004140")]
		Illegal
	}

	// Token: 0x02000866 RID: 2150
	[Token(Token = "0x2000866")]
	public enum ShiftType
	{
		// Token: 0x04004142 RID: 16706
		[Token(Token = "0x4004142")]
		morningShift,
		// Token: 0x04004143 RID: 16707
		[Token(Token = "0x4004143")]
		dayShift,
		// Token: 0x04004144 RID: 16708
		[Token(Token = "0x4004144")]
		eveningShift,
		// Token: 0x04004145 RID: 16709
		[Token(Token = "0x4004145")]
		nightShift
	}

	// Token: 0x02000867 RID: 2151
	[Token(Token = "0x2000867")]
	public enum JobAI
	{
		// Token: 0x04004147 RID: 16711
		[Token(Token = "0x4004147")]
		workPosition,
		// Token: 0x04004148 RID: 16712
		[Token(Token = "0x4004148")]
		random,
		// Token: 0x04004149 RID: 16713
		[Token(Token = "0x4004149")]
		randomBuilding,
		// Token: 0x0400414A RID: 16714
		[Token(Token = "0x400414A")]
		passedCompanyPosition
	}

	// Token: 0x02000868 RID: 2152
	[Token(Token = "0x2000868")]
	public enum workTags
	{
		// Token: 0x0400414C RID: 16716
		[Token(Token = "0x400414C")]
		none,
		// Token: 0x0400414D RID: 16717
		[Token(Token = "0x400414D")]
		dull,
		// Token: 0x0400414E RID: 16718
		[Token(Token = "0x400414E")]
		exciting,
		// Token: 0x0400414F RID: 16719
		[Token(Token = "0x400414F")]
		dangerous,
		// Token: 0x04004150 RID: 16720
		[Token(Token = "0x4004150")]
		menial,
		// Token: 0x04004151 RID: 16721
		[Token(Token = "0x4004151")]
		intern,
		// Token: 0x04004152 RID: 16722
		[Token(Token = "0x4004152")]
		stressful,
		// Token: 0x04004153 RID: 16723
		[Token(Token = "0x4004153")]
		cushy,
		// Token: 0x04004154 RID: 16724
		[Token(Token = "0x4004154")]
		technical,
		// Token: 0x04004155 RID: 16725
		[Token(Token = "0x4004155")]
		ceo,
		// Token: 0x04004156 RID: 16726
		[Token(Token = "0x4004156")]
		social,
		// Token: 0x04004157 RID: 16727
		[Token(Token = "0x4004157")]
		isolated,
		// Token: 0x04004158 RID: 16728
		[Token(Token = "0x4004158")]
		professional
	}

	// Token: 0x02000869 RID: 2153
	[Token(Token = "0x2000869")]
	public enum Overtime
	{
		// Token: 0x0400415A RID: 16730
		[Token(Token = "0x400415A")]
		none,
		// Token: 0x0400415B RID: 16731
		[Token(Token = "0x400415B")]
		low,
		// Token: 0x0400415C RID: 16732
		[Token(Token = "0x400415C")]
		medium,
		// Token: 0x0400415D RID: 16733
		[Token(Token = "0x400415D")]
		high,
		// Token: 0x0400415E RID: 16734
		[Token(Token = "0x400415E")]
		veryHigh
	}
}
