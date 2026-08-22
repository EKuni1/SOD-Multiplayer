using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000107 RID: 263
[Token(Token = "0x2000107")]
public class BlockController : Controller, IEnumerator<object>
{
	// Token: 0x0600075C RID: 1884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600075C")]
	[Address(RVA = "0x4812C0", Offset = "0x4802C0", VA = "0x1804812C0")]
	public void Setup(DistrictController newDistrict)
	{
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600075D")]
	[Address(RVA = "0x4814B0", Offset = "0x4804B0", VA = "0x1804814B0")]
	public void Load(CitySaveData.BlockCitySave data, DistrictController newDistrict)
	{
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600075E")]
	[Address(RVA = "0x481580", Offset = "0x480580", VA = "0x180481580")]
	public void AddCityTile(CityTile newTile)
	{
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600075F")]
	[Address(RVA = "0x481790", Offset = "0x480790", VA = "0x180481790")]
	public void UpdateAverageDensity()
	{
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000760")]
	[Address(RVA = "0x481940", Offset = "0x480940", VA = "0x180481940")]
	public void UpdateAverageLandValue()
	{
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00004F08 File Offset: 0x00003108
	[Token(Token = "0x6000761")]
	[Address(RVA = "0x481AF0", Offset = "0x480AF0", VA = "0x180481AF0", Slot = "6")]
	public int CompareTo(BlockController compare)
	{
		return 0;
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000762")]
	[Address(RVA = "0x481B70", Offset = "0x480B70", VA = "0x180481B70")]
	public CitySaveData.BlockCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000763")]
	[Address(RVA = "0x481C30", Offset = "0x480C30", VA = "0x180481C30")]
	public BlockController()
	{
	}

	// Token: 0x04000777 RID: 1911
	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0x18")]
	public int blockID;

	// Token: 0x04000778 RID: 1912
	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0x0")]
	public static int assignID;

	// Token: 0x04000779 RID: 1913
	[Token(Token = "0x4000779")]
	[FieldOffset(Offset = "0x1C")]
	public int favourVertical;

	// Token: 0x0400077A RID: 1914
	[Token(Token = "0x400077A")]
	[FieldOffset(Offset = "0x20")]
	public List<CityTile> cityTiles;

	// Token: 0x0400077B RID: 1915
	[Token(Token = "0x400077B")]
	[FieldOffset(Offset = "0x28")]
	[NonSerialized]
	public float averageDensity;

	// Token: 0x0400077C RID: 1916
	[Token(Token = "0x400077C")]
	[FieldOffset(Offset = "0x2C")]
	[NonSerialized]
	public float averageLandValue;

	// Token: 0x0400077D RID: 1917
	[Token(Token = "0x400077D")]
	[FieldOffset(Offset = "0x8")]
	public static Comparison<BlockController> LandValueComparison;

	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000766 RID: 1894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x481F30", Offset = "0x480F30", VA = "0x180481F30")]
		internal int <.cctor>b__15_0(BlockController object1, BlockController object2)
		{
			return 0;
		}

		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BlockController.<>c <>9;
	}
}
