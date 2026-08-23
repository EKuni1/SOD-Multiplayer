using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E1 RID: 481
[Token(Token = "0x20001E1")]
public class BuildingSwapController : MonoBehaviour
{
	// Token: 0x06000BBE RID: 3006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x57B5D0", Offset = "0x57A5D0", VA = "0x18057B5D0")]
	private void Update()
	{
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BBF")]
	[Address(RVA = "0x57B6F0", Offset = "0x57A6F0", VA = "0x18057B6F0")]
	private void ReRollBuilding(int buildingID)
	{
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000BC0")]
	[Address(RVA = "0x57C1D0", Offset = "0x57B1D0", VA = "0x18057C1D0")]
	private Transform GetGameObjectAtPosition()
	{
		return null;
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BC1")]
	[Address(RVA = "0x57C4F0", Offset = "0x57B4F0", VA = "0x18057C4F0")]
	public BuildingSwapController()
	{
	}

	// Token: 0x04000C27 RID: 3111
	[Token(Token = "0x4000C27")]
	[FieldOffset(Offset = "0x18")]
	public CityTile activeTile;

	// Token: 0x04000C28 RID: 3112
	[Token(Token = "0x4000C28")]
	[FieldOffset(Offset = "0x20")]
	private List<CityBuildings.PickBuilding> selectionList;

	// Token: 0x020001E2 RID: 482
	[Token(Token = "0x20001E2")]
	private sealed class <>c__DisplayClass3_0
	{
		// Token: 0x06000BC2 RID: 3010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass3_0()
		{
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00006F00 File Offset: 0x00005100
		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x57C5F0", Offset = "0x57B5F0", VA = "0x18057C5F0")]
		internal bool <ReRollBuilding>b__1(NewBuilding n)
		{
			return default(bool);
		}

		// Token: 0x04000C29 RID: 3113
		[Token(Token = "0x4000C29")]
		[FieldOffset(Offset = "0x10")]
		public BuildingPreset item;
	}

	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x20001E3")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000BC5 RID: 3013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00006F18 File Offset: 0x00005118
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x57C700", Offset = "0x57B700", VA = "0x18057C700")]
		internal int <ReRollBuilding>b__3_0(CityBuildings.PickBuilding p1, CityBuildings.PickBuilding p2)
		{
			return 0;
		}

		// Token: 0x04000C2A RID: 3114
		[Token(Token = "0x4000C2A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BuildingSwapController.<>c <>9;

		// Token: 0x04000C2B RID: 3115
		[Token(Token = "0x4000C2B")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<CityBuildings.PickBuilding> <>9__3_0;
	}
}
