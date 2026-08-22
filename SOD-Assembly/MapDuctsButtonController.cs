using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000648 RID: 1608
[Token(Token = "0x2000648")]
public class MapDuctsButtonController : ButtonController
{
	// Token: 0x06002372 RID: 9074 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002372")]
	[Address(RVA = "0xB63C70", Offset = "0xB62C70", VA = "0x180B63C70")]
	public void Setup(NewFloor newAddress)
	{
	}

	// Token: 0x06002373 RID: 9075 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002373")]
	[Address(RVA = "0xB63F00", Offset = "0xB62F00", VA = "0x180B63F00")]
	public void UpdateMapImageEndOfFrame()
	{
	}

	// Token: 0x06002374 RID: 9076 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002374")]
	[Address(RVA = "0xB63F90", Offset = "0xB62F90", VA = "0x180B63F90")]
	public void GenerateMapImage()
	{
	}

	// Token: 0x06002375 RID: 9077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002375")]
	[Address(RVA = "0xB667B0", Offset = "0xB657B0", VA = "0x180B667B0")]
	public MapDuctsButtonController()
	{
	}

	// Token: 0x04002D4D RID: 11597
	[Token(Token = "0x4002D4D")]
	[FieldOffset(Offset = "0x1A8")]
	public NewFloor floor;

	// Token: 0x04002D4E RID: 11598
	[Token(Token = "0x4002D4E")]
	[FieldOffset(Offset = "0x1B0")]
	public Vector2 range;

	// Token: 0x04002D4F RID: 11599
	[Token(Token = "0x4002D4F")]
	[FieldOffset(Offset = "0x1B8")]
	public Image generatedImage;

	// Token: 0x04002D50 RID: 11600
	[Token(Token = "0x4002D50")]
	[FieldOffset(Offset = "0x1C0")]
	public Texture2D tex;

	// Token: 0x04002D51 RID: 11601
	[Token(Token = "0x4002D51")]
	[FieldOffset(Offset = "0x1C8")]
	public bool rebuildImage;

	// Token: 0x04002D52 RID: 11602
	[Token(Token = "0x4002D52")]
	[FieldOffset(Offset = "0x1D0")]
	private Action UpdateMapTex;

	// Token: 0x02000649 RID: 1609
	[Token(Token = "0x2000649")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002377 RID: 9079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002377")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x0000E688 File Offset: 0x0000C888
		[Token(Token = "0x6002378")]
		[Address(RVA = "0x9517D0", Offset = "0x9507D0", VA = "0x1809517D0")]
		internal bool <GenerateMapImage>b__8_0(Vector3Int item)
		{
			return default(bool);
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		[Token(Token = "0x6002379")]
		[Address(RVA = "0xB66870", Offset = "0xB65870", VA = "0x180B66870")]
		internal bool <GenerateMapImage>b__8_1(Vector3Int item)
		{
			return default(bool);
		}

		// Token: 0x04002D53 RID: 11603
		[Token(Token = "0x4002D53")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MapDuctsButtonController.<>c <>9;

		// Token: 0x04002D54 RID: 11604
		[Token(Token = "0x4002D54")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Vector3Int> <>9__8_0;

		// Token: 0x04002D55 RID: 11605
		[Token(Token = "0x4002D55")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<Vector3Int> <>9__8_1;
	}
}
