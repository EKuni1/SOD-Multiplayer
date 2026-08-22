using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E6 RID: 230
[Token(Token = "0x20000E6")]
[Serializable]
public class Descriptors
{
	// Token: 0x06000678 RID: 1656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000678")]
	[Address(RVA = "0xE1B450", Offset = "0xE1A450", VA = "0x180E1B450")]
	public Descriptors(Human newCitizen)
	{
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000679")]
	[Address(RVA = "0xE1C180", Offset = "0xE1B180", VA = "0x180E1C180")]
	private void GenerateEthnicity()
	{
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600067A")]
	[Address(RVA = "0xE1C860", Offset = "0xE1B860", VA = "0x180E1C860")]
	public void GenerateNameAndSkinColour()
	{
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600067B")]
	[Address(RVA = "0xE1DBE0", Offset = "0xE1CBE0", VA = "0x180E1DBE0")]
	private void GenerateEyes()
	{
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600067C")]
	[Address(RVA = "0xE1DF90", Offset = "0xE1CF90", VA = "0x180E1DF90")]
	private void GenerateHair()
	{
	}

	// Token: 0x0600067D RID: 1661 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600067D")]
	[Address(RVA = "0xE1F710", Offset = "0xE1E710", VA = "0x180E1F710")]
	private void GenerateBuild()
	{
	}

	// Token: 0x0600067E RID: 1662 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600067E")]
	[Address(RVA = "0xE1FBE0", Offset = "0xE1EBE0", VA = "0x180E1FBE0")]
	private void GenerateFacialFeatures()
	{
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600067F")]
	[Address(RVA = "0xE20330", Offset = "0xE1F330", VA = "0x180E20330")]
	private void GenerateFootwearPreference()
	{
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x00004B00 File Offset: 0x00002D00
	[Token(Token = "0x6000680")]
	[Address(RVA = "0xE20980", Offset = "0xE1F980", VA = "0x180E20980")]
	public static float DescriptorComparison(Descriptors comp1, Descriptors comp2)
	{
		return 0f;
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00004B18 File Offset: 0x00002D18
	[Token(Token = "0x6000681")]
	[Address(RVA = "0xE20990", Offset = "0xE1F990", VA = "0x180E20990")]
	private bool <GenerateNameAndSkinColour>b__27_0(Citizen item)
	{
		return default(bool);
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00004B30 File Offset: 0x00002D30
	[Token(Token = "0x6000682")]
	[Address(RVA = "0x74B090", Offset = "0x74A090", VA = "0x18074B090")]
	private bool <GenerateHair>b__29_0(SocialStatistics.HairSetting item)
	{
		return default(bool);
	}

	// Token: 0x040006C2 RID: 1730
	[Token(Token = "0x40006C2")]
	[FieldOffset(Offset = "0x10")]
	[NonSerialized]
	public Human citizen;

	// Token: 0x040006C3 RID: 1731
	[Token(Token = "0x40006C3")]
	[FieldOffset(Offset = "0x18")]
	public float visualDistinctiveness;

	// Token: 0x040006C4 RID: 1732
	[Token(Token = "0x40006C4")]
	[FieldOffset(Offset = "0x1C")]
	public Descriptors.BuildType build;

	// Token: 0x040006C5 RID: 1733
	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0x20")]
	public Descriptors.Height height;

	// Token: 0x040006C6 RID: 1734
	[Token(Token = "0x40006C6")]
	[FieldOffset(Offset = "0x24")]
	public float heightCM;

	// Token: 0x040006C7 RID: 1735
	[Token(Token = "0x40006C7")]
	[FieldOffset(Offset = "0x28")]
	public float weightKG;

	// Token: 0x040006C8 RID: 1736
	[Token(Token = "0x40006C8")]
	[FieldOffset(Offset = "0x2C")]
	public int shoeSize;

	// Token: 0x040006C9 RID: 1737
	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0x30")]
	public Human.ShoeType footwear;

	// Token: 0x040006CA RID: 1738
	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0x38")]
	public List<Descriptors.EthnicitySetting> ethnicities;

	// Token: 0x040006CB RID: 1739
	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0x40")]
	public Color skinColour;

	// Token: 0x040006CC RID: 1740
	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x50")]
	public Descriptors.HairColour hairColourCategory;

	// Token: 0x040006CD RID: 1741
	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0x54")]
	public Color hairColour;

	// Token: 0x040006CE RID: 1742
	[Token(Token = "0x40006CE")]
	[FieldOffset(Offset = "0x64")]
	public Descriptors.HairStyle hairType;

	// Token: 0x040006CF RID: 1743
	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0x68")]
	public Descriptors.EyeColour eyeColour;

	// Token: 0x040006D0 RID: 1744
	[Token(Token = "0x40006D0")]
	[FieldOffset(Offset = "0x70")]
	public List<Descriptors.FacialFeaturesSetting> facialFeatures;

	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	public enum Age
	{
		// Token: 0x040006D2 RID: 1746
		[Token(Token = "0x40006D2")]
		youngAdult,
		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x40006D3")]
		adult,
		// Token: 0x040006D4 RID: 1748
		[Token(Token = "0x40006D4")]
		old
	}

	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	public enum BuildType
	{
		// Token: 0x040006D6 RID: 1750
		[Token(Token = "0x40006D6")]
		skinny,
		// Token: 0x040006D7 RID: 1751
		[Token(Token = "0x40006D7")]
		average,
		// Token: 0x040006D8 RID: 1752
		[Token(Token = "0x40006D8")]
		overweight,
		// Token: 0x040006D9 RID: 1753
		[Token(Token = "0x40006D9")]
		muscular
	}

	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	public enum Height
	{
		// Token: 0x040006DB RID: 1755
		[Token(Token = "0x40006DB")]
		veryShort,
		// Token: 0x040006DC RID: 1756
		[Token(Token = "0x40006DC")]
		hShort,
		// Token: 0x040006DD RID: 1757
		[Token(Token = "0x40006DD")]
		hAverage,
		// Token: 0x040006DE RID: 1758
		[Token(Token = "0x40006DE")]
		tall,
		// Token: 0x040006DF RID: 1759
		[Token(Token = "0x40006DF")]
		veryTall
	}

	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	public enum EthnicGroup
	{
		// Token: 0x040006E1 RID: 1761
		[Token(Token = "0x40006E1")]
		westEuropean,
		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x40006E2")]
		eastEuropean,
		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		scandinavian,
		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		mediterranean,
		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		hispanic,
		// Token: 0x040006E6 RID: 1766
		[Token(Token = "0x40006E6")]
		african,
		// Token: 0x040006E7 RID: 1767
		[Token(Token = "0x40006E7")]
		indian,
		// Token: 0x040006E8 RID: 1768
		[Token(Token = "0x40006E8")]
		chinese,
		// Token: 0x040006E9 RID: 1769
		[Token(Token = "0x40006E9")]
		japanese,
		// Token: 0x040006EA RID: 1770
		[Token(Token = "0x40006EA")]
		korean,
		// Token: 0x040006EB RID: 1771
		[Token(Token = "0x40006EB")]
		nativeAmerican,
		// Token: 0x040006EC RID: 1772
		[Token(Token = "0x40006EC")]
		middleEastern,
		// Token: 0x040006ED RID: 1773
		[Token(Token = "0x40006ED")]
		australian,
		// Token: 0x040006EE RID: 1774
		[Token(Token = "0x40006EE")]
		africanAmerican,
		// Token: 0x040006EF RID: 1775
		[Token(Token = "0x40006EF")]
		islander,
		// Token: 0x040006F0 RID: 1776
		[Token(Token = "0x40006F0")]
		northAmerican,
		// Token: 0x040006F1 RID: 1777
		[Token(Token = "0x40006F1")]
		southAmerican
	}

	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	[Serializable]
	public class EthnicitySetting : IEnumerator<object>
	{
		// Token: 0x06000683 RID: 1667 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x6000683")]
		[Address(RVA = "0xE20BF0", Offset = "0xE1FBF0", VA = "0x180E20BF0", Slot = "4")]
		public int CompareTo(Descriptors.EthnicitySetting otherObject)
		{
			return 0;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public EthnicitySetting()
		{
		}

		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x10")]
		public Descriptors.EthnicGroup group;

		// Token: 0x040006F3 RID: 1779
		[Token(Token = "0x40006F3")]
		[FieldOffset(Offset = "0x14")]
		public float ratio;

		// Token: 0x040006F4 RID: 1780
		[Token(Token = "0x40006F4")]
		[FieldOffset(Offset = "0x18")]
		public SocialStatistics.EthnicityStats stats;
	}

	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	public enum HairColour
	{
		// Token: 0x040006F6 RID: 1782
		[Token(Token = "0x40006F6")]
		black,
		// Token: 0x040006F7 RID: 1783
		[Token(Token = "0x40006F7")]
		brown,
		// Token: 0x040006F8 RID: 1784
		[Token(Token = "0x40006F8")]
		blonde,
		// Token: 0x040006F9 RID: 1785
		[Token(Token = "0x40006F9")]
		ginger,
		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x40006FA")]
		red,
		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x40006FB")]
		blue,
		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		green,
		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		purple,
		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		pink,
		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		grey,
		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		white
	}

	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	public enum HairStyle
	{
		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x4000702")]
		bald,
		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x4000703")]
		shortHair,
		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x4000704")]
		longHair
	}

	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	public enum EyeColour
	{
		// Token: 0x04000706 RID: 1798
		[Token(Token = "0x4000706")]
		blueEyes,
		// Token: 0x04000707 RID: 1799
		[Token(Token = "0x4000707")]
		brownEyes,
		// Token: 0x04000708 RID: 1800
		[Token(Token = "0x4000708")]
		greenEyes,
		// Token: 0x04000709 RID: 1801
		[Token(Token = "0x4000709")]
		greyEyes
	}

	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000EF")]
	[Serializable]
	public struct FacialFeaturesSetting
	{
		// Token: 0x0400070A RID: 1802
		[Token(Token = "0x400070A")]
		[FieldOffset(Offset = "0x0")]
		public Descriptors.FacialFeature feature;

		// Token: 0x0400070B RID: 1803
		[Token(Token = "0x400070B")]
		[FieldOffset(Offset = "0x4")]
		public int id;
	}

	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000F0")]
	public enum FacialFeature
	{
		// Token: 0x0400070D RID: 1805
		[Token(Token = "0x400070D")]
		scaring,
		// Token: 0x0400070E RID: 1806
		[Token(Token = "0x400070E")]
		beard,
		// Token: 0x0400070F RID: 1807
		[Token(Token = "0x400070F")]
		moustache,
		// Token: 0x04000710 RID: 1808
		[Token(Token = "0x4000710")]
		piercing,
		// Token: 0x04000711 RID: 1809
		[Token(Token = "0x4000711")]
		tattoo,
		// Token: 0x04000712 RID: 1810
		[Token(Token = "0x4000712")]
		glasses,
		// Token: 0x04000713 RID: 1811
		[Token(Token = "0x4000713")]
		mole
	}

	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	private sealed class <>c__DisplayClass26_0
	{
		// Token: 0x06000685 RID: 1669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass26_0()
		{
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x4810F0", Offset = "0x4800F0", VA = "0x1804810F0")]
		internal bool <GenerateEthnicity>b__0(SocialStatistics.EthnicityStats item)
		{
			return default(bool);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x4810F0", Offset = "0x4800F0", VA = "0x1804810F0")]
		internal bool <GenerateEthnicity>b__1(Descriptors.EthnicitySetting item)
		{
			return default(bool);
		}

		// Token: 0x04000714 RID: 1812
		[Token(Token = "0x4000714")]
		[FieldOffset(Offset = "0x10")]
		public Descriptors.EthnicitySetting newEth;
	}
}
