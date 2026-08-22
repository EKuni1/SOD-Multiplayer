using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001E9 RID: 489
[Token(Token = "0x20001E9")]
public class CityBoundaryAndTiles : HighlanderSingleton<CityBoundaryAndTiles>
{
	// Token: 0x06000BE3 RID: 3043 RVA: 0x00006F60 File Offset: 0x00005160
	[Token(Token = "0x6000BE3")]
	[Address(RVA = "0x581760", Offset = "0x580760", VA = "0x180581760")]
	public UniTask SetupCityBoundary()
	{
		return default(UniTask);
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x581890", Offset = "0x580890", VA = "0x180581890")]
	public CityBoundaryAndTiles()
	{
	}

	// Token: 0x04000C48 RID: 3144
	[Token(Token = "0x4000C48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float boundaryLeft;

	// Token: 0x04000C49 RID: 3145
	[Token(Token = "0x4000C49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float boundaryRight;

	// Token: 0x04000C4A RID: 3146
	[Token(Token = "0x4000C4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float boundaryUp;

	// Token: 0x04000C4B RID: 3147
	[Token(Token = "0x4000C4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float boundaryDown;

	// Token: 0x04000C4C RID: 3148
	[Token(Token = "0x4000C4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject cityTilePrefab;

	// Token: 0x04000C4D RID: 3149
	[Token(Token = "0x4000C4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Dictionary<Vector2Int, CityTile> cityTiles;

	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	[StructLayout(3)]
	private struct <SetupCityBoundary>d__6 : IEnumerator<object>
	{
		// Token: 0x06000BE5 RID: 3045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x5819C0", Offset = "0x5809C0", VA = "0x1805819C0", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04000C4E RID: 3150
		[Token(Token = "0x4000C4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04000C4F RID: 3151
		[Token(Token = "0x4000C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder <>t__builder;

		// Token: 0x04000C50 RID: 3152
		[Token(Token = "0x4000C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CityBoundaryAndTiles <>4__this;

		// Token: 0x04000C51 RID: 3153
		[Token(Token = "0x4000C51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;
	}
}
