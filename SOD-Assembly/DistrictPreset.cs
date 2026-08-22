using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007C7 RID: 1991
[Token(Token = "0x20007C7")]
public class DistrictPreset : SoCustomComparison
{
	// Token: 0x06002957 RID: 10583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002957")]
	[Address(RVA = "0xCA3BF0", Offset = "0xCA2BF0", VA = "0x180CA3BF0")]
	public void CopyFrom()
	{
	}

	// Token: 0x06002958 RID: 10584 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002958")]
	[Address(RVA = "0xCA3F00", Offset = "0xCA2F00", VA = "0x180CA3F00")]
	public DistrictPreset()
	{
	}

	// Token: 0x0400396C RID: 14700
	[Token(Token = "0x400396C")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 generationPriority;

	// Token: 0x0400396D RID: 14701
	[Token(Token = "0x400396D")]
	[FieldOffset(Offset = "0x28")]
	public bool limitToOne;

	// Token: 0x0400396E RID: 14702
	[Token(Token = "0x400396E")]
	[FieldOffset(Offset = "0x2C")]
	public float cityRatio;

	// Token: 0x0400396F RID: 14703
	[Token(Token = "0x400396F")]
	[FieldOffset(Offset = "0x30")]
	public int minimumSize;

	// Token: 0x04003970 RID: 14704
	[Token(Token = "0x4003970")]
	[FieldOffset(Offset = "0x34")]
	public int maximumSize;

	// Token: 0x04003971 RID: 14705
	[Token(Token = "0x4003971")]
	[FieldOffset(Offset = "0x38")]
	public bool mustBeOnCoast;

	// Token: 0x04003972 RID: 14706
	[Token(Token = "0x4003972")]
	[FieldOffset(Offset = "0x3C")]
	public float centreWeighting;

	// Token: 0x04003973 RID: 14707
	[Token(Token = "0x4003973")]
	[FieldOffset(Offset = "0x40")]
	public int aliterationWeight;

	// Token: 0x04003974 RID: 14708
	[Token(Token = "0x4003974")]
	[FieldOffset(Offset = "0x44")]
	public float prefixOrSuffixChance;

	// Token: 0x04003975 RID: 14709
	[Token(Token = "0x4003975")]
	[FieldOffset(Offset = "0x48")]
	public List<string> prefixList;

	// Token: 0x04003976 RID: 14710
	[Token(Token = "0x4003976")]
	[FieldOffset(Offset = "0x50")]
	public float mainChance;

	// Token: 0x04003977 RID: 14711
	[Token(Token = "0x4003977")]
	[FieldOffset(Offset = "0x58")]
	public List<string> mainNamingList;

	// Token: 0x04003978 RID: 14712
	[Token(Token = "0x4003978")]
	[FieldOffset(Offset = "0x60")]
	public List<string> suffixList;

	// Token: 0x04003979 RID: 14713
	[Token(Token = "0x4003979")]
	[FieldOffset(Offset = "0x68")]
	public BuildingPreset.Density minimumDensity;

	// Token: 0x0400397A RID: 14714
	[Token(Token = "0x400397A")]
	[FieldOffset(Offset = "0x6C")]
	public BuildingPreset.Density maximumDensity;

	// Token: 0x0400397B RID: 14715
	[Token(Token = "0x400397B")]
	[FieldOffset(Offset = "0x70")]
	public BuildingPreset.LandValue minimumLandValue;

	// Token: 0x0400397C RID: 14716
	[Token(Token = "0x400397C")]
	[FieldOffset(Offset = "0x74")]
	public BuildingPreset.LandValue maximumLandValue;

	// Token: 0x0400397D RID: 14717
	[Token(Token = "0x400397D")]
	[FieldOffset(Offset = "0x78")]
	public bool affectEthnicity;

	// Token: 0x0400397E RID: 14718
	[Token(Token = "0x400397E")]
	[FieldOffset(Offset = "0x80")]
	public List<SocialStatistics.EthnicityFrequency> ethnicityFrequencyModifiers;

	// Token: 0x0400397F RID: 14719
	[Token(Token = "0x400397F")]
	[FieldOffset(Offset = "0x88")]
	public SessionData.SceneProfile sceneProfile;

	// Token: 0x04003980 RID: 14720
	[Token(Token = "0x4003980")]
	[FieldOffset(Offset = "0x8C")]
	public bool alterStreetAreaLighting;

	// Token: 0x04003981 RID: 14721
	[Token(Token = "0x4003981")]
	[FieldOffset(Offset = "0x90")]
	public List<Color> possibleColours;

	// Token: 0x04003982 RID: 14722
	[Token(Token = "0x4003982")]
	[FieldOffset(Offset = "0x98")]
	public DistrictPreset.AffectStreetAreaLights lightOperation;

	// Token: 0x04003983 RID: 14723
	[Token(Token = "0x4003983")]
	[FieldOffset(Offset = "0x9C")]
	public float lightAmount;

	// Token: 0x04003984 RID: 14724
	[Token(Token = "0x4003984")]
	[FieldOffset(Offset = "0xA0")]
	public float brightnessModifier;

	// Token: 0x04003985 RID: 14725
	[Token(Token = "0x4003985")]
	[FieldOffset(Offset = "0xA8")]
	public DistrictPreset copyFrom;

	// Token: 0x020007C8 RID: 1992
	[Token(Token = "0x20007C8")]
	public enum AffectStreetAreaLights
	{
		// Token: 0x04003987 RID: 14727
		[Token(Token = "0x4003987")]
		lerp,
		// Token: 0x04003988 RID: 14728
		[Token(Token = "0x4003988")]
		multiply,
		// Token: 0x04003989 RID: 14729
		[Token(Token = "0x4003989")]
		add
	}
}
