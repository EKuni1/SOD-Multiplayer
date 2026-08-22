using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

// Token: 0x020001E7 RID: 487
[Token(Token = "0x20001E7")]
public class CityBlocks : HighlanderSingleton<CityBlocks>
{
	// Token: 0x06000BDF RID: 3039 RVA: 0x00006F48 File Offset: 0x00005148
	[Token(Token = "0x6000BDF")]
	[Address(RVA = "0x57F9F0", Offset = "0x57E9F0", VA = "0x18057F9F0")]
	public UniTask GenerateBlocks()
	{
		return default(UniTask);
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BE0")]
	[Address(RVA = "0x57FB50", Offset = "0x57EB50", VA = "0x18057FB50")]
	public CityBlocks()
	{
	}

	// Token: 0x04000C3D RID: 3133
	[Token(Token = "0x4000C3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int loadChunk;

	// Token: 0x04000C3E RID: 3134
	[Token(Token = "0x4000C3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<BlockController> blocksDirectory;

	// Token: 0x020001E8 RID: 488
	[Token(Token = "0x20001E8")]
	[StructLayout(3)]
	private struct <GenerateBlocks>d__2 : IEnumerator<object>
	{
		// Token: 0x06000BE1 RID: 3041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x57FC70", Offset = "0x57EC70", VA = "0x18057FC70", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04000C3F RID: 3135
		[Token(Token = "0x4000C3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04000C40 RID: 3136
		[Token(Token = "0x4000C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder <>t__builder;

		// Token: 0x04000C41 RID: 3137
		[Token(Token = "0x4000C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CityBlocks <>4__this;

		// Token: 0x04000C42 RID: 3138
		[Token(Token = "0x4000C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<CityTile> <randomList>5__2;

		// Token: 0x04000C43 RID: 3139
		[Token(Token = "0x4000C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<CityTile> <borderTiles>5__3;

		// Token: 0x04000C44 RID: 3140
		[Token(Token = "0x4000C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string <seed>5__4;

		// Token: 0x04000C45 RID: 3141
		[Token(Token = "0x4000C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <cityBlocksTotal>5__5;

		// Token: 0x04000C46 RID: 3142
		[Token(Token = "0x4000C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <cityBlocksProgress>5__6;

		// Token: 0x04000C47 RID: 3143
		[Token(Token = "0x4000C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;
	}
}
