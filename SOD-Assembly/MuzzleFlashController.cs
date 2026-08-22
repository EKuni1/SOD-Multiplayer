using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000405 RID: 1029
[Token(Token = "0x2000405")]
public class MuzzleFlashController : MonoBehaviour
{
	// Token: 0x0600175A RID: 5978 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600175A")]
	[Address(RVA = "0x88E9F0", Offset = "0x88D9F0", VA = "0x18088E9F0")]
	private void Update()
	{
	}

	// Token: 0x0600175B RID: 5979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600175B")]
	[Address(RVA = "0x88EDB0", Offset = "0x88DDB0", VA = "0x18088EDB0")]
	public MuzzleFlashController()
	{
	}

	// Token: 0x04001C56 RID: 7254
	[Token(Token = "0x4001C56")]
	[FieldOffset(Offset = "0x18")]
	public Color startColour;

	// Token: 0x04001C57 RID: 7255
	[Token(Token = "0x4001C57")]
	[FieldOffset(Offset = "0x28")]
	public Color endColour;

	// Token: 0x04001C58 RID: 7256
	[Token(Token = "0x4001C58")]
	[FieldOffset(Offset = "0x38")]
	public float maxIntensity;

	// Token: 0x04001C59 RID: 7257
	[Token(Token = "0x4001C59")]
	[FieldOffset(Offset = "0x3C")]
	public float maxRange;

	// Token: 0x04001C5A RID: 7258
	[Token(Token = "0x4001C5A")]
	[FieldOffset(Offset = "0x40")]
	public float duration;

	// Token: 0x04001C5B RID: 7259
	[Token(Token = "0x4001C5B")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve curve;

	// Token: 0x04001C5C RID: 7260
	[Token(Token = "0x4001C5C")]
	[FieldOffset(Offset = "0x50")]
	public Light light;

	// Token: 0x04001C5D RID: 7261
	[Token(Token = "0x4001C5D")]
	[FieldOffset(Offset = "0x58")]
	public float timer;

	// Token: 0x04001C5E RID: 7262
	[Token(Token = "0x4001C5E")]
	[FieldOffset(Offset = "0x5C")]
	public float progress;
}
