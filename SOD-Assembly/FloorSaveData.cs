using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000246 RID: 582
[Token(Token = "0x2000246")]
[Serializable]
public class FloorSaveData
{
	// Token: 0x06000D47 RID: 3399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D47")]
	[Address(RVA = "0x5E68F0", Offset = "0x5E58F0", VA = "0x1805E68F0")]
	public FloorSaveData()
	{
	}

	// Token: 0x04000EB7 RID: 3767
	[Token(Token = "0x4000EB7")]
	[FieldOffset(Offset = "0x10")]
	public string floorName;

	// Token: 0x04000EB8 RID: 3768
	[Token(Token = "0x4000EB8")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 size;

	// Token: 0x04000EB9 RID: 3769
	[Token(Token = "0x4000EB9")]
	[FieldOffset(Offset = "0x20")]
	public int defaultFloorHeight;

	// Token: 0x04000EBA RID: 3770
	[Token(Token = "0x4000EBA")]
	[FieldOffset(Offset = "0x24")]
	public int defaultCeilingHeight;

	// Token: 0x04000EBB RID: 3771
	[Token(Token = "0x4000EBB")]
	[FieldOffset(Offset = "0x28")]
	public List<AddressSaveData> a_d;

	// Token: 0x04000EBC RID: 3772
	[Token(Token = "0x4000EBC")]
	[FieldOffset(Offset = "0x30")]
	public List<TileSaveData> t_d;
}
