using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000233 RID: 563
[Token(Token = "0x2000233")]
public class SubObjectPlacement : MonoBehaviour
{
	// Token: 0x06000CCE RID: 3278 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CCE")]
	[Address(RVA = "0x59F790", Offset = "0x59E790", VA = "0x18059F790")]
	public void OnClassChanged()
	{
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CCF")]
	[Address(RVA = "0x59F880", Offset = "0x59E880", VA = "0x18059F880")]
	public void RandomDir()
	{
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD0")]
	[Address(RVA = "0x59F960", Offset = "0x59E960", VA = "0x18059F960")]
	public void SpawnRandomObject()
	{
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD1")]
	[Address(RVA = "0x5A0150", Offset = "0x59F150", VA = "0x1805A0150")]
	public void RemoveRandomObject()
	{
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CD2")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public SubObjectPlacement()
	{
	}

	// Token: 0x04000E29 RID: 3625
	[Token(Token = "0x4000E29")]
	[FieldOffset(Offset = "0x18")]
	public SubObjectClassPreset preset;

	// Token: 0x04000E2A RID: 3626
	[Token(Token = "0x4000E2A")]
	[FieldOffset(Offset = "0x20")]
	public FurniturePreset.SubObjectOwnership belongsTo;

	// Token: 0x04000E2B RID: 3627
	[Token(Token = "0x4000E2B")]
	[FieldOffset(Offset = "0x24")]
	public int security;

	// Token: 0x04000E2C RID: 3628
	[Token(Token = "0x4000E2C")]
	[FieldOffset(Offset = "0x28")]
	public TextMesh text;

	// Token: 0x04000E2D RID: 3629
	[Token(Token = "0x4000E2D")]
	[FieldOffset(Offset = "0x30")]
	public Transform spawnedObject;

	// Token: 0x04000E2E RID: 3630
	[Token(Token = "0x4000E2E")]
	[FieldOffset(Offset = "0x38")]
	public MeshRenderer mainObject;
}
