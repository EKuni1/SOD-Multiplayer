using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200088F RID: 2191
[Token(Token = "0x200088F")]
public class SpatterPatternPreset : SoCustomComparison
{
	// Token: 0x060029FF RID: 10751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029FF")]
	[Address(RVA = "0xCB3B90", Offset = "0xCB2B90", VA = "0x180CB3B90")]
	public SpatterPatternPreset()
	{
	}

	// Token: 0x04004327 RID: 17191
	[Token(Token = "0x4004327")]
	[FieldOffset(Offset = "0x20")]
	public int spatterCount;

	// Token: 0x04004328 RID: 17192
	[Token(Token = "0x4004328")]
	[FieldOffset(Offset = "0x24")]
	public float maxAngleX;

	// Token: 0x04004329 RID: 17193
	[Token(Token = "0x4004329")]
	[FieldOffset(Offset = "0x28")]
	public float maxAngleY;

	// Token: 0x0400432A RID: 17194
	[Token(Token = "0x400432A")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 rayLength;

	// Token: 0x0400432B RID: 17195
	[Token(Token = "0x400432B")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve spreadCurve;

	// Token: 0x0400432C RID: 17196
	[Token(Token = "0x400432C")]
	[FieldOffset(Offset = "0x40")]
	public Material heavyMaterial;

	// Token: 0x0400432D RID: 17197
	[Token(Token = "0x400432D")]
	[FieldOffset(Offset = "0x48")]
	public Material mediumMaterial;

	// Token: 0x0400432E RID: 17198
	[Token(Token = "0x400432E")]
	[FieldOffset(Offset = "0x50")]
	public Material lightMaterial;
}
