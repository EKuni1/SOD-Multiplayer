using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200024B RID: 587
[Token(Token = "0x200024B")]
[Serializable]
public class NodeSaveData
{
	// Token: 0x06000D4C RID: 3404 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D4C")]
	[Address(RVA = "0x5E6D60", Offset = "0x5E5D60", VA = "0x1805E6D60")]
	public NodeSaveData()
	{
	}

	// Token: 0x04000ECB RID: 3787
	[Token(Token = "0x4000ECB")]
	[FieldOffset(Offset = "0x10")]
	public Vector2Int f_c;

	// Token: 0x04000ECC RID: 3788
	[Token(Token = "0x4000ECC")]
	[FieldOffset(Offset = "0x18")]
	public int f_h;

	// Token: 0x04000ECD RID: 3789
	[Token(Token = "0x4000ECD")]
	[FieldOffset(Offset = "0x1C")]
	public NewNode.FloorTileType f_t;

	// Token: 0x04000ECE RID: 3790
	[Token(Token = "0x4000ECE")]
	[FieldOffset(Offset = "0x20")]
	public string f_r;

	// Token: 0x04000ECF RID: 3791
	[Token(Token = "0x4000ECF")]
	[FieldOffset(Offset = "0x28")]
	public List<WallSaveData> w_d;
}
