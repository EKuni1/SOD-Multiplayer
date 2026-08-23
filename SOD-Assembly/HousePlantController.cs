using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000456 RID: 1110
[Token(Token = "0x2000456")]
public class HousePlantController : MonoBehaviour
{
	// Token: 0x060018E9 RID: 6377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018E9")]
	[Address(RVA = "0x953370", Offset = "0x952370", VA = "0x180953370")]
	private void OnEnable()
	{
	}

	// Token: 0x060018EA RID: 6378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018EA")]
	[Address(RVA = "0x953C60", Offset = "0x952C60", VA = "0x180953C60")]
	public HousePlantController()
	{
	}

	// Token: 0x04001E18 RID: 7704
	[Token(Token = "0x4001E18")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 spawnLocalPosition;

	// Token: 0x04001E19 RID: 7705
	[Token(Token = "0x4001E19")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 sizeScale;

	// Token: 0x04001E1A RID: 7706
	[Token(Token = "0x4001E1A")]
	[FieldOffset(Offset = "0x2C")]
	public int poolIndex;

	// Token: 0x04001E1B RID: 7707
	[Token(Token = "0x4001E1B")]
	[FieldOffset(Offset = "0x30")]
	public float scaleIndex;

	// Token: 0x04001E1C RID: 7708
	[Token(Token = "0x4001E1C")]
	[FieldOffset(Offset = "0x34")]
	public float rotation;

	// Token: 0x04001E1D RID: 7709
	[Token(Token = "0x4001E1D")]
	[FieldOffset(Offset = "0x38")]
	public float colourLerp;

	// Token: 0x04001E1E RID: 7710
	[Token(Token = "0x4001E1E")]
	[FieldOffset(Offset = "0x40")]
	public GameObject spawnedPlant;

	// Token: 0x04001E1F RID: 7711
	[Token(Token = "0x4001E1F")]
	[FieldOffset(Offset = "0x48")]
	public bool isLoaded;
}
