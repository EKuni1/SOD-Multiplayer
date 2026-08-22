using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000249 RID: 585
[Token(Token = "0x2000249")]
[Serializable]
public class RoomSaveData
{
	// Token: 0x06000D4A RID: 3402 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D4A")]
	[Address(RVA = "0x5E6C90", Offset = "0x5E5C90", VA = "0x1805E6C90")]
	public RoomSaveData()
	{
	}

	// Token: 0x04000EC1 RID: 3777
	[Token(Token = "0x4000EC1")]
	[FieldOffset(Offset = "0x10")]
	public int id;

	// Token: 0x04000EC2 RID: 3778
	[Token(Token = "0x4000EC2")]
	[FieldOffset(Offset = "0x18")]
	public List<NodeSaveData> n_d;

	// Token: 0x04000EC3 RID: 3779
	[Token(Token = "0x4000EC3")]
	[FieldOffset(Offset = "0x20")]
	public string l;
}
