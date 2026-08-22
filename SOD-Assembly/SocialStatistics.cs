using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008C6 RID: 2246
[Token(Token = "0x20008C6")]
public class SocialStatistics : MonoBehaviour
{
	// Token: 0x17000158 RID: 344
	// (get) Token: 0x06002A56 RID: 10838 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000158")]
	public static SocialStatistics Instance
	{
		[Token(Token = "0x6002A56")]
		[Address(RVA = "0xCBF590", Offset = "0xCBE590", VA = "0x180CBF590")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002A57 RID: 10839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A57")]
	[Address(RVA = "0xCBF5D0", Offset = "0xCBE5D0", VA = "0x180CBF5D0")]
	private void Awake()
	{
	}

	// Token: 0x06002A58 RID: 10840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A58")]
	[Address(RVA = "0xCBF920", Offset = "0xCBE920", VA = "0x180CBF920")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002A59 RID: 10841 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A59")]
	[Address(RVA = "0xCBFB30", Offset = "0xCBEB30", VA = "0x180CBFB30")]
	public SocialStatistics()
	{
	}

	// Token: 0x04004A3A RID: 19002
	[Token(Token = "0x4004A3A")]
	[FieldOffset(Offset = "0x18")]
	public float genderNonBinaryThreshold;

	// Token: 0x04004A3B RID: 19003
	[Token(Token = "0x4004A3B")]
	[FieldOffset(Offset = "0x1C")]
	public float transThreshold;

	// Token: 0x04004A3C RID: 19004
	[Token(Token = "0x4004A3C")]
	[FieldOffset(Offset = "0x20")]
	public float sexualityStraightThreshold;

	// Token: 0x04004A3D RID: 19005
	[Token(Token = "0x4004A3D")]
	[FieldOffset(Offset = "0x24")]
	public float sexualityGayThreshold;

	// Token: 0x04004A3E RID: 19006
	[Token(Token = "0x4004A3E")]
	[FieldOffset(Offset = "0x28")]
	public float asexualChance;

	// Token: 0x04004A3F RID: 19007
	[Token(Token = "0x4004A3F")]
	[FieldOffset(Offset = "0x30")]
	public CharacterTrait maleTrait;

	// Token: 0x04004A40 RID: 19008
	[Token(Token = "0x4004A40")]
	[FieldOffset(Offset = "0x38")]
	public CharacterTrait femaleTrait;

	// Token: 0x04004A41 RID: 19009
	[Token(Token = "0x4004A41")]
	[FieldOffset(Offset = "0x40")]
	public CharacterTrait nbTrait;

	// Token: 0x04004A42 RID: 19010
	[Token(Token = "0x4004A42")]
	[FieldOffset(Offset = "0x48")]
	public CharacterTrait AttractedToMaleTrait;

	// Token: 0x04004A43 RID: 19011
	[Token(Token = "0x4004A43")]
	[FieldOffset(Offset = "0x50")]
	public CharacterTrait AttractedToFemaleTrait;

	// Token: 0x04004A44 RID: 19012
	[Token(Token = "0x4004A44")]
	[FieldOffset(Offset = "0x58")]
	public CharacterTrait AttractedToNBTrait;

	// Token: 0x04004A45 RID: 19013
	[Token(Token = "0x4004A45")]
	[FieldOffset(Offset = "0x60")]
	public CharacterTrait relationshipTrait;

	// Token: 0x04004A46 RID: 19014
	[Token(Token = "0x4004A46")]
	[FieldOffset(Offset = "0x68")]
	public List<Color> lipstickColours;

	// Token: 0x04004A47 RID: 19015
	[Token(Token = "0x4004A47")]
	[FieldOffset(Offset = "0x70")]
	public int[] ageRanges;

	// Token: 0x04004A48 RID: 19016
	[Token(Token = "0x4004A48")]
	[FieldOffset(Offset = "0x78")]
	public List<SocialStatistics.EthnicityFrequency> ethnicityFrequencies;

	// Token: 0x04004A49 RID: 19017
	[Token(Token = "0x4004A49")]
	[FieldOffset(Offset = "0x80")]
	public int chanceOf2ndEthnicity;

	// Token: 0x04004A4A RID: 19018
	[Token(Token = "0x4004A4A")]
	[FieldOffset(Offset = "0x84")]
	public float districtEthnictiyDominanceMultiplier;

	// Token: 0x04004A4B RID: 19019
	[Token(Token = "0x4004A4B")]
	[FieldOffset(Offset = "0x88")]
	public List<SocialStatistics.EthnicityStats> ethnicityStats;

	// Token: 0x04004A4C RID: 19020
	[Token(Token = "0x4004A4C")]
	[FieldOffset(Offset = "0x90")]
	public float averageHeight;

	// Token: 0x04004A4D RID: 19021
	[Token(Token = "0x4004A4D")]
	[FieldOffset(Offset = "0x94")]
	public float averageWeight;

	// Token: 0x04004A4E RID: 19022
	[Token(Token = "0x4004A4E")]
	[FieldOffset(Offset = "0x98")]
	public Vector2 heightMinMax;

	// Token: 0x04004A4F RID: 19023
	[Token(Token = "0x4004A4F")]
	[FieldOffset(Offset = "0xA0")]
	public int skinnyRatio;

	// Token: 0x04004A50 RID: 19024
	[Token(Token = "0x4004A50")]
	[FieldOffset(Offset = "0xA4")]
	public int averageRatio;

	// Token: 0x04004A51 RID: 19025
	[Token(Token = "0x4004A51")]
	[FieldOffset(Offset = "0xA8")]
	public int overweightRatio;

	// Token: 0x04004A52 RID: 19026
	[Token(Token = "0x4004A52")]
	[FieldOffset(Offset = "0xAC")]
	public int muscleyRatio;

	// Token: 0x04004A53 RID: 19027
	[Token(Token = "0x4004A53")]
	[FieldOffset(Offset = "0xB0")]
	public float bloodOPosRatio;

	// Token: 0x04004A54 RID: 19028
	[Token(Token = "0x4004A54")]
	[FieldOffset(Offset = "0xB4")]
	public float bloodAPosRatio;

	// Token: 0x04004A55 RID: 19029
	[Token(Token = "0x4004A55")]
	[FieldOffset(Offset = "0xB8")]
	public float bloodBPosRatio;

	// Token: 0x04004A56 RID: 19030
	[Token(Token = "0x4004A56")]
	[FieldOffset(Offset = "0xBC")]
	public float bloodONegRatio;

	// Token: 0x04004A57 RID: 19031
	[Token(Token = "0x4004A57")]
	[FieldOffset(Offset = "0xC0")]
	public float bloodANegRatio;

	// Token: 0x04004A58 RID: 19032
	[Token(Token = "0x4004A58")]
	[FieldOffset(Offset = "0xC4")]
	public float bloodABPosRatio;

	// Token: 0x04004A59 RID: 19033
	[Token(Token = "0x4004A59")]
	[FieldOffset(Offset = "0xC8")]
	public float bloodBNegRatio;

	// Token: 0x04004A5A RID: 19034
	[Token(Token = "0x4004A5A")]
	[FieldOffset(Offset = "0xCC")]
	public float bloodABNegRatio;

	// Token: 0x04004A5B RID: 19035
	[Token(Token = "0x4004A5B")]
	[FieldOffset(Offset = "0xD0")]
	public List<SocialStatistics.HairSetting> hairColourSettings;

	// Token: 0x04004A5C RID: 19036
	[Token(Token = "0x4004A5C")]
	[FieldOffset(Offset = "0xD8")]
	public int RedHairRatio;

	// Token: 0x04004A5D RID: 19037
	[Token(Token = "0x4004A5D")]
	[FieldOffset(Offset = "0xDC")]
	public int blueHairRatio;

	// Token: 0x04004A5E RID: 19038
	[Token(Token = "0x4004A5E")]
	[FieldOffset(Offset = "0xE0")]
	public int greenHairRatio;

	// Token: 0x04004A5F RID: 19039
	[Token(Token = "0x4004A5F")]
	[FieldOffset(Offset = "0xE4")]
	public int purpleHairRatio;

	// Token: 0x04004A60 RID: 19040
	[Token(Token = "0x4004A60")]
	[FieldOffset(Offset = "0xE8")]
	public int pinkHairRatio;

	// Token: 0x04004A61 RID: 19041
	[Token(Token = "0x4004A61")]
	[FieldOffset(Offset = "0xEC")]
	public int scaringRatio;

	// Token: 0x04004A62 RID: 19042
	[Token(Token = "0x4004A62")]
	[FieldOffset(Offset = "0xF0")]
	public int menWithBeards;

	// Token: 0x04004A63 RID: 19043
	[Token(Token = "0x4004A63")]
	[FieldOffset(Offset = "0xF4")]
	public int menWithMoustaches;

	// Token: 0x04004A64 RID: 19044
	[Token(Token = "0x4004A64")]
	[FieldOffset(Offset = "0xF8")]
	public int piercingRatio;

	// Token: 0x04004A65 RID: 19045
	[Token(Token = "0x4004A65")]
	[FieldOffset(Offset = "0xFC")]
	public int TattooRatio;

	// Token: 0x04004A66 RID: 19046
	[Token(Token = "0x4004A66")]
	[FieldOffset(Offset = "0x100")]
	public int glassesRatio;

	// Token: 0x04004A67 RID: 19047
	[Token(Token = "0x4004A67")]
	[FieldOffset(Offset = "0x104")]
	public int moleRatio;

	// Token: 0x04004A68 RID: 19048
	[Token(Token = "0x4004A68")]
	[FieldOffset(Offset = "0x108")]
	public int frecklesRatio;

	// Token: 0x04004A69 RID: 19049
	[Token(Token = "0x4004A69")]
	[FieldOffset(Offset = "0x10C")]
	public float seriousRelationshipsRatio;

	// Token: 0x04004A6A RID: 19050
	[Token(Token = "0x4004A6A")]
	[FieldOffset(Offset = "0x110")]
	public List<string> slangGreetingDefault;

	// Token: 0x04004A6B RID: 19051
	[Token(Token = "0x4004A6B")]
	[FieldOffset(Offset = "0x118")]
	public List<string> slangGreetingMale;

	// Token: 0x04004A6C RID: 19052
	[Token(Token = "0x4004A6C")]
	[FieldOffset(Offset = "0x120")]
	public List<string> slangGreetingFemale;

	// Token: 0x04004A6D RID: 19053
	[Token(Token = "0x4004A6D")]
	[FieldOffset(Offset = "0x128")]
	public List<string> slangGreetingLover;

	// Token: 0x04004A6E RID: 19054
	[Token(Token = "0x4004A6E")]
	[FieldOffset(Offset = "0x130")]
	public List<string> slangCurse;

	// Token: 0x04004A6F RID: 19055
	[Token(Token = "0x4004A6F")]
	[FieldOffset(Offset = "0x138")]
	public List<string> slangCurseNoun;

	// Token: 0x04004A70 RID: 19056
	[Token(Token = "0x4004A70")]
	[FieldOffset(Offset = "0x140")]
	public List<string> slangPraiseNoun;

	// Token: 0x04004A71 RID: 19057
	[Token(Token = "0x4004A71")]
	[FieldOffset(Offset = "0x148")]
	public List<Color> favouriteColoursPool;

	// Token: 0x04004A72 RID: 19058
	[Token(Token = "0x4004A72")]
	[FieldOffset(Offset = "0x0")]
	private static SocialStatistics _instance;

	// Token: 0x020008C7 RID: 2247
	[Token(Token = "0x20008C7")]
	[Serializable]
	public class EthnicityFrequency : IEnumerator<object>
	{
		// Token: 0x06002A5A RID: 10842 RVA: 0x0000FB88 File Offset: 0x0000DD88
		[Token(Token = "0x6002A5A")]
		[Address(RVA = "0xCC00B0", Offset = "0xCBF0B0", VA = "0x180CC00B0", Slot = "4")]
		public int CompareTo(SocialStatistics.EthnicityFrequency otherObject)
		{
			return 0;
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public EthnicityFrequency()
		{
		}

		// Token: 0x04004A73 RID: 19059
		[Token(Token = "0x4004A73")]
		[FieldOffset(Offset = "0x10")]
		public Descriptors.EthnicGroup ethnicity;

		// Token: 0x04004A74 RID: 19060
		[Token(Token = "0x4004A74")]
		[FieldOffset(Offset = "0x14")]
		public int frequency;
	}

	// Token: 0x020008C8 RID: 2248
	[Token(Token = "0x20008C8")]
	[Serializable]
	public class HairSetting
	{
		// Token: 0x06002A5C RID: 10844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5C")]
		[Address(RVA = "0xCC00E0", Offset = "0xCBF0E0", VA = "0x180CC00E0")]
		public HairSetting()
		{
		}

		// Token: 0x04004A75 RID: 19061
		[Token(Token = "0x4004A75")]
		[FieldOffset(Offset = "0x10")]
		public Descriptors.HairColour colour;

		// Token: 0x04004A76 RID: 19062
		[Token(Token = "0x4004A76")]
		[FieldOffset(Offset = "0x14")]
		public Color hairColourRange1;

		// Token: 0x04004A77 RID: 19063
		[Token(Token = "0x4004A77")]
		[FieldOffset(Offset = "0x24")]
		public Color hairColourRange2;
	}

	// Token: 0x020008C9 RID: 2249
	[Token(Token = "0x20008C9")]
	[Serializable]
	public class EthnicityStats
	{
		// Token: 0x06002A5D RID: 10845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5D")]
		[Address(RVA = "0xCC0100", Offset = "0xCBF100", VA = "0x180CC0100")]
		public EthnicityStats()
		{
		}

		// Token: 0x04004A78 RID: 19064
		[Token(Token = "0x4004A78")]
		[FieldOffset(Offset = "0x10")]
		public Descriptors.EthnicGroup group;

		// Token: 0x04004A79 RID: 19065
		[Token(Token = "0x4004A79")]
		[FieldOffset(Offset = "0x14")]
		public Color skinColourRange1;

		// Token: 0x04004A7A RID: 19066
		[Token(Token = "0x4004A7A")]
		[FieldOffset(Offset = "0x24")]
		public Color skinColourRange2;

		// Token: 0x04004A7B RID: 19067
		[Token(Token = "0x4004A7B")]
		[FieldOffset(Offset = "0x34")]
		public int blackHairRatio;

		// Token: 0x04004A7C RID: 19068
		[Token(Token = "0x4004A7C")]
		[FieldOffset(Offset = "0x38")]
		public int brownHairRatio;

		// Token: 0x04004A7D RID: 19069
		[Token(Token = "0x4004A7D")]
		[FieldOffset(Offset = "0x3C")]
		public int blondeHairRatio;

		// Token: 0x04004A7E RID: 19070
		[Token(Token = "0x4004A7E")]
		[FieldOffset(Offset = "0x40")]
		public int gingerHairRatio;

		// Token: 0x04004A7F RID: 19071
		[Token(Token = "0x4004A7F")]
		[FieldOffset(Offset = "0x44")]
		public int RedHairRatio;

		// Token: 0x04004A80 RID: 19072
		[Token(Token = "0x4004A80")]
		[FieldOffset(Offset = "0x48")]
		public int blueHairRatio;

		// Token: 0x04004A81 RID: 19073
		[Token(Token = "0x4004A81")]
		[FieldOffset(Offset = "0x4C")]
		public int greenHairRatio;

		// Token: 0x04004A82 RID: 19074
		[Token(Token = "0x4004A82")]
		[FieldOffset(Offset = "0x50")]
		public int purpleHairRatio;

		// Token: 0x04004A83 RID: 19075
		[Token(Token = "0x4004A83")]
		[FieldOffset(Offset = "0x54")]
		public int pinkHairRatio;

		// Token: 0x04004A84 RID: 19076
		[Token(Token = "0x4004A84")]
		[FieldOffset(Offset = "0x58")]
		public int greyHairRatio;

		// Token: 0x04004A85 RID: 19077
		[Token(Token = "0x4004A85")]
		[FieldOffset(Offset = "0x5C")]
		public int whiteHairRatio;

		// Token: 0x04004A86 RID: 19078
		[Token(Token = "0x4004A86")]
		[FieldOffset(Offset = "0x60")]
		public int baldHairRatioMale;

		// Token: 0x04004A87 RID: 19079
		[Token(Token = "0x4004A87")]
		[FieldOffset(Offset = "0x64")]
		public int shortHairRatioMale;

		// Token: 0x04004A88 RID: 19080
		[Token(Token = "0x4004A88")]
		[FieldOffset(Offset = "0x68")]
		public int longHairRatioMale;

		// Token: 0x04004A89 RID: 19081
		[Token(Token = "0x4004A89")]
		[FieldOffset(Offset = "0x6C")]
		public int baldHairRatioFemale;

		// Token: 0x04004A8A RID: 19082
		[Token(Token = "0x4004A8A")]
		[FieldOffset(Offset = "0x70")]
		public int shortHairRatioFemale;

		// Token: 0x04004A8B RID: 19083
		[Token(Token = "0x4004A8B")]
		[FieldOffset(Offset = "0x74")]
		public int longHairRatioFemale;

		// Token: 0x04004A8C RID: 19084
		[Token(Token = "0x4004A8C")]
		[FieldOffset(Offset = "0x78")]
		public int straightHairRatioMale;

		// Token: 0x04004A8D RID: 19085
		[Token(Token = "0x4004A8D")]
		[FieldOffset(Offset = "0x7C")]
		public int curlyHairRatioMale;

		// Token: 0x04004A8E RID: 19086
		[Token(Token = "0x4004A8E")]
		[FieldOffset(Offset = "0x80")]
		public int balingHairRatioMale;

		// Token: 0x04004A8F RID: 19087
		[Token(Token = "0x4004A8F")]
		[FieldOffset(Offset = "0x84")]
		public int messyHairRatioMale;

		// Token: 0x04004A90 RID: 19088
		[Token(Token = "0x4004A90")]
		[FieldOffset(Offset = "0x88")]
		public int styledHairRatioMale;

		// Token: 0x04004A91 RID: 19089
		[Token(Token = "0x4004A91")]
		[FieldOffset(Offset = "0x8C")]
		public int mohawkHairRatioMale;

		// Token: 0x04004A92 RID: 19090
		[Token(Token = "0x4004A92")]
		[FieldOffset(Offset = "0x90")]
		public int afroHairRatioMale;

		// Token: 0x04004A93 RID: 19091
		[Token(Token = "0x4004A93")]
		[FieldOffset(Offset = "0x94")]
		public int straightHairRatioFemale;

		// Token: 0x04004A94 RID: 19092
		[Token(Token = "0x4004A94")]
		[FieldOffset(Offset = "0x98")]
		public int curlyHairRatioFemale;

		// Token: 0x04004A95 RID: 19093
		[Token(Token = "0x4004A95")]
		[FieldOffset(Offset = "0x9C")]
		public int balingHairRatioFemale;

		// Token: 0x04004A96 RID: 19094
		[Token(Token = "0x4004A96")]
		[FieldOffset(Offset = "0xA0")]
		public int messyHairRatioFemale;

		// Token: 0x04004A97 RID: 19095
		[Token(Token = "0x4004A97")]
		[FieldOffset(Offset = "0xA4")]
		public int styledHairRatioFemale;

		// Token: 0x04004A98 RID: 19096
		[Token(Token = "0x4004A98")]
		[FieldOffset(Offset = "0xA8")]
		public int mohawkHairRatioFemale;

		// Token: 0x04004A99 RID: 19097
		[Token(Token = "0x4004A99")]
		[FieldOffset(Offset = "0xAC")]
		public int afroHairRatioFemale;

		// Token: 0x04004A9A RID: 19098
		[Token(Token = "0x4004A9A")]
		[FieldOffset(Offset = "0xB0")]
		public int blueEyesRatio;

		// Token: 0x04004A9B RID: 19099
		[Token(Token = "0x4004A9B")]
		[FieldOffset(Offset = "0xB4")]
		public int brownEyesRatio;

		// Token: 0x04004A9C RID: 19100
		[Token(Token = "0x4004A9C")]
		[FieldOffset(Offset = "0xB8")]
		public int greenEyesRatio;

		// Token: 0x04004A9D RID: 19101
		[Token(Token = "0x4004A9D")]
		[FieldOffset(Offset = "0xBC")]
		public int greyEyesRatio;

		// Token: 0x04004A9E RID: 19102
		[Token(Token = "0x4004A9E")]
		[FieldOffset(Offset = "0xC0")]
		public bool overrideFirst;

		// Token: 0x04004A9F RID: 19103
		[Token(Token = "0x4004A9F")]
		[FieldOffset(Offset = "0xC4")]
		public Descriptors.EthnicGroup overrideNameFirst;

		// Token: 0x04004AA0 RID: 19104
		[Token(Token = "0x4004AA0")]
		[FieldOffset(Offset = "0xC8")]
		public bool overrideSur;

		// Token: 0x04004AA1 RID: 19105
		[Token(Token = "0x4004AA1")]
		[FieldOffset(Offset = "0xCC")]
		public Descriptors.EthnicGroup overrideNameSur;

		// Token: 0x04004AA2 RID: 19106
		[Token(Token = "0x4004AA2")]
		[FieldOffset(Offset = "0xD0")]
		public List<Descriptors.EthnicGroup> culturalSimilarities;

		// Token: 0x04004AA3 RID: 19107
		[Token(Token = "0x4004AA3")]
		[FieldOffset(Offset = "0xD8")]
		public List<CharacterTrait> ethTraits;
	}
}
