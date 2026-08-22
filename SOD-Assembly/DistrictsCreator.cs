using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000192 RID: 402
[Token(Token = "0x2000192")]
public class DistrictsCreator : Creator
{
	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000A44 RID: 2628 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000045")]
	public static DistrictsCreator Instance
	{
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x5363F0", Offset = "0x5353F0", VA = "0x1805363F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A45")]
	[Address(RVA = "0x536430", Offset = "0x535430", VA = "0x180536430")]
	private void Awake()
	{
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A46")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "4")]
	public override void StartLoading()
	{
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A47")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public DistrictsCreator()
	{
	}

	// Token: 0x04000A6E RID: 2670
	[Token(Token = "0x4000A6E")]
	[FieldOffset(Offset = "0x0")]
	private static DistrictsCreator _instance;

	// Token: 0x02000193 RID: 403
	[Token(Token = "0x2000193")]
	public class DistrictPlacement
	{
		// Token: 0x06000A48 RID: 2632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x536780", Offset = "0x535780", VA = "0x180536780")]
		public DistrictPlacement()
		{
		}

		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4000A6F")]
		[FieldOffset(Offset = "0x10")]
		public float score;

		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4000A70")]
		[FieldOffset(Offset = "0x18")]
		public List<CityTile> tiles;

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		[FieldOffset(Offset = "0x20")]
		public List<CityTile> innerTiles;

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		[FieldOffset(Offset = "0x28")]
		public List<CityTile> edgeTiles;
	}
}
