using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200011D RID: 285
[Token(Token = "0x200011D")]
public class DistrictController : Controller, IEnumerator<object>
{
	// Token: 0x06000822 RID: 2082 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000822")]
	[Address(RVA = "0x4AE140", Offset = "0x4AD140", VA = "0x1804AE140")]
	public void Setup(DistrictPreset newPreset)
	{
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000823")]
	[Address(RVA = "0x4AE3B0", Offset = "0x4AD3B0", VA = "0x1804AE3B0")]
	public void Load(CitySaveData.DistrictCitySave data)
	{
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000824")]
	[Address(RVA = "0x4AE930", Offset = "0x4AD930", VA = "0x1804AE930")]
	public void AddCityTile(CityTile newCityTile)
	{
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000825")]
	[Address(RVA = "0x4AED90", Offset = "0x4ADD90", VA = "0x1804AED90")]
	public void AddBlock(BlockController newBlock)
	{
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000826")]
	[Address(RVA = "0x4AEEF0", Offset = "0x4ADEF0", VA = "0x1804AEEF0")]
	public void PopulateData()
	{
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000827")]
	[Address(RVA = "0x4AF5A0", Offset = "0x4AE5A0", VA = "0x1804AF5A0")]
	public void UpdateName()
	{
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x00005658 File Offset: 0x00003858
	[Token(Token = "0x6000828")]
	[Address(RVA = "0x4AFF60", Offset = "0x4AEF60", VA = "0x1804AFF60")]
	public Descriptors.EthnicGroup EthnictiyBasedOnDominance()
	{
		return Descriptors.EthnicGroup.westEuropean;
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x00005670 File Offset: 0x00003870
	[Token(Token = "0x6000829")]
	[Address(RVA = "0x4B0100", Offset = "0x4AF100", VA = "0x1804B0100", Slot = "6")]
	public int CompareTo(DistrictController otherObject)
	{
		return 0;
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600082A")]
	[Address(RVA = "0x4B0180", Offset = "0x4AF180", VA = "0x1804B0180")]
	public CitySaveData.DistrictCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600082B")]
	[Address(RVA = "0x4B0680", Offset = "0x4AF680", VA = "0x1804B0680")]
	public DistrictController()
	{
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x00005688 File Offset: 0x00003888
	[Token(Token = "0x600082D")]
	[Address(RVA = "0x4B0910", Offset = "0x4AF910", VA = "0x1804B0910")]
	private bool <UpdateName>b__13_0(DistrictController item)
	{
		return default(bool);
	}

	// Token: 0x04000853 RID: 2131
	[Token(Token = "0x4000853")]
	[FieldOffset(Offset = "0x18")]
	public int districtID;

	// Token: 0x04000854 RID: 2132
	[Token(Token = "0x4000854")]
	[FieldOffset(Offset = "0x0")]
	public static int assignID;

	// Token: 0x04000855 RID: 2133
	[Token(Token = "0x4000855")]
	[FieldOffset(Offset = "0x20")]
	public string seed;

	// Token: 0x04000856 RID: 2134
	[Token(Token = "0x4000856")]
	[FieldOffset(Offset = "0x28")]
	public List<BlockController> blocks;

	// Token: 0x04000857 RID: 2135
	[Token(Token = "0x4000857")]
	[FieldOffset(Offset = "0x30")]
	public List<CityTile> cityTiles;

	// Token: 0x04000858 RID: 2136
	[Token(Token = "0x4000858")]
	[FieldOffset(Offset = "0x38")]
	public DistrictPreset preset;

	// Token: 0x04000859 RID: 2137
	[Token(Token = "0x4000859")]
	[FieldOffset(Offset = "0x40")]
	public float averageLandValue;

	// Token: 0x0400085A RID: 2138
	[Token(Token = "0x400085A")]
	[FieldOffset(Offset = "0x48")]
	public List<SocialStatistics.EthnicityFrequency> dominantEthnicities;

	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x0600082E RID: 2094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x000056A0 File Offset: 0x000038A0
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x4810F0", Offset = "0x4800F0", VA = "0x1804810F0")]
		internal bool <PopulateData>b__0(SocialStatistics.EthnicityFrequency item)
		{
			return default(bool);
		}

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x400085B")]
		[FieldOffset(Offset = "0x10")]
		public SocialStatistics.EthnicityFrequency freq;
	}
}
