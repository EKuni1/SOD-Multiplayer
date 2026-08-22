using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000222 RID: 546
[Token(Token = "0x2000222")]
public class DebugGraffitiScaler : MonoBehaviour
{
	// Token: 0x06000C8C RID: 3212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C8C")]
	[Address(RVA = "0x59A920", Offset = "0x599920", VA = "0x18059A920")]
	public void LoadArt()
	{
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C8D")]
	[Address(RVA = "0x59AA70", Offset = "0x599A70", VA = "0x18059AA70")]
	public void SetScale()
	{
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C8E")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void SavePixelScale()
	{
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0x59AC60", Offset = "0x599C60", VA = "0x18059AC60")]
	public DebugGraffitiScaler()
	{
	}

	// Token: 0x04000DCB RID: 3531
	[Token(Token = "0x4000DCB")]
	[FieldOffset(Offset = "0x18")]
	public ArtPreset art;

	// Token: 0x04000DCC RID: 3532
	[Token(Token = "0x4000DCC")]
	[FieldOffset(Offset = "0x20")]
	public DecalProjector decal;

	// Token: 0x04000DCD RID: 3533
	[Token(Token = "0x4000DCD")]
	[FieldOffset(Offset = "0x28")]
	public float pixelScaleMultiplier;
}
