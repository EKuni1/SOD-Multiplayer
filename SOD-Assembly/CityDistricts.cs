using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F3 RID: 499
[Token(Token = "0x20001F3")]
public class CityDistricts : HighlanderSingleton<CityDistricts>
{
	// Token: 0x06000BF7 RID: 3063 RVA: 0x00006FF0 File Offset: 0x000051F0
	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0x5844A0", Offset = "0x5834A0", VA = "0x1805844A0")]
	public UniTask GenerateDistricts()
	{
		return default(UniTask);
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0x5845D0", Offset = "0x5835D0", VA = "0x1805845D0")]
	public CityDistricts()
	{
	}

	// Token: 0x04000C68 RID: 3176
	[Token(Token = "0x4000C68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject districtPrefab;

	// Token: 0x04000C69 RID: 3177
	[Token(Token = "0x4000C69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<DistrictController> districtDirectory;

	// Token: 0x020001F4 RID: 500
	[Token(Token = "0x20001F4")]
	public class DistrictPlacement
	{
		// Token: 0x06000BF9 RID: 3065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x5846E0", Offset = "0x5836E0", VA = "0x1805846E0")]
		public DistrictPlacement()
		{
		}

		// Token: 0x04000C6A RID: 3178
		[Token(Token = "0x4000C6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float score;

		// Token: 0x04000C6B RID: 3179
		[Token(Token = "0x4000C6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<CityTile> tiles;

		// Token: 0x04000C6C RID: 3180
		[Token(Token = "0x4000C6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<CityTile> innerTiles;

		// Token: 0x04000C6D RID: 3181
		[Token(Token = "0x4000C6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<CityTile> edgeTiles;
	}

	// Token: 0x020001F5 RID: 501
	[Token(Token = "0x20001F5")]
	private sealed class <>c__DisplayClass3_0
	{
		// Token: 0x06000BFA RID: 3066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass3_0()
		{
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00007008 File Offset: 0x00005208
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x5848A0", Offset = "0x5838A0", VA = "0x1805848A0")]
		internal int <GenerateDistricts>b__1(DistrictPreset p1, DistrictPreset p2)
		{
			return 0;
		}

		// Token: 0x04000C6E RID: 3182
		[Token(Token = "0x4000C6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string seed;

		// Token: 0x04000C6F RID: 3183
		[Token(Token = "0x4000C6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Comparison<DistrictPreset> <>9__1;
	}

	// Token: 0x020001F6 RID: 502
	[Token(Token = "0x20001F6")]
	private sealed class <>c__DisplayClass3_1
	{
		// Token: 0x06000BFC RID: 3068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass3_1()
		{
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00007020 File Offset: 0x00005220
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x5849F0", Offset = "0x5839F0", VA = "0x1805849F0")]
		internal bool <GenerateDistricts>b__2(CityTile item)
		{
			return default(bool);
		}

		// Token: 0x04000C70 RID: 3184
		[Token(Token = "0x4000C70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 searchVector;
	}

	// Token: 0x020001F7 RID: 503
	[Token(Token = "0x20001F7")]
	private sealed class <>c__DisplayClass3_2
	{
		// Token: 0x06000BFE RID: 3070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass3_2()
		{
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00007038 File Offset: 0x00005238
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x584A40", Offset = "0x583A40", VA = "0x180584A40")]
		internal bool <GenerateDistricts>b__4(DistrictController item)
		{
			return default(bool);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00007050 File Offset: 0x00005250
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x584AA0", Offset = "0x583AA0", VA = "0x180584AA0")]
		internal bool <GenerateDistricts>b__5(BlockController item)
		{
			return default(bool);
		}

		// Token: 0x04000C71 RID: 3185
		[Token(Token = "0x4000C71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public KeyValuePair<Vector2Int, CityTile> pair;
	}

	// Token: 0x020001F8 RID: 504
	[Token(Token = "0x20001F8")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000C02 RID: 3074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00007068 File Offset: 0x00005268
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x584BB0", Offset = "0x583BB0", VA = "0x180584BB0")]
		internal bool <GenerateDistricts>b__3_0(DistrictPreset item)
		{
			return default(bool);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00007080 File Offset: 0x00005280
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x584BD0", Offset = "0x583BD0", VA = "0x180584BD0")]
		internal int <GenerateDistricts>b__3_3(CityDistricts.DistrictPlacement p1, CityDistricts.DistrictPlacement p2)
		{
			return 0;
		}

		// Token: 0x04000C72 RID: 3186
		[Token(Token = "0x4000C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CityDistricts.<>c <>9;

		// Token: 0x04000C73 RID: 3187
		[Token(Token = "0x4000C73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<DistrictPreset> <>9__3_0;

		// Token: 0x04000C74 RID: 3188
		[Token(Token = "0x4000C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Comparison<CityDistricts.DistrictPlacement> <>9__3_3;
	}

	// Token: 0x020001F9 RID: 505
	[Token(Token = "0x20001F9")]
	[StructLayout(3)]
	private struct <GenerateDistricts>d__3 : IEnumerator<object>
	{
		// Token: 0x06000C05 RID: 3077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x584C60", Offset = "0x583C60", VA = "0x180584C60", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04000C75 RID: 3189
		[Token(Token = "0x4000C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04000C76 RID: 3190
		[Token(Token = "0x4000C76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder <>t__builder;

		// Token: 0x04000C77 RID: 3191
		[Token(Token = "0x4000C77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CityDistricts <>4__this;

		// Token: 0x04000C78 RID: 3192
		[Token(Token = "0x4000C78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;
	}
}
