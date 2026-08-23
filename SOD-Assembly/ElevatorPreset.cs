using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007D2 RID: 2002
[Token(Token = "0x20007D2")]
public class ElevatorPreset : SoCustomComparison
{
	// Token: 0x0600295F RID: 10591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600295F")]
	[Address(RVA = "0x5C7970", Offset = "0x5C6970", VA = "0x1805C7970")]
	public ElevatorPreset()
	{
	}

	// Token: 0x040039F6 RID: 14838
	[Token(Token = "0x40039F6")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> stairWellPrefabs;

	// Token: 0x040039F7 RID: 14839
	[Token(Token = "0x40039F7")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> stairsPrefabs;

	// Token: 0x040039F8 RID: 14840
	[Token(Token = "0x40039F8")]
	[FieldOffset(Offset = "0x30")]
	public float rotationOffset;

	// Token: 0x040039F9 RID: 14841
	[Token(Token = "0x40039F9")]
	[FieldOffset(Offset = "0x38")]
	public Material bottomMaterial;

	// Token: 0x040039FA RID: 14842
	[Token(Token = "0x40039FA")]
	[FieldOffset(Offset = "0x40")]
	public Material topMaterial;
}
