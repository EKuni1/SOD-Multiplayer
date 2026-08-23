using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000407 RID: 1031
[Token(Token = "0x2000407")]
public class NeonSignController : MonoBehaviour
{
	// Token: 0x06001760 RID: 5984 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001760")]
	[Address(RVA = "0x88F510", Offset = "0x88E510", VA = "0x18088F510")]
	private void OnEnable()
	{
	}

	// Token: 0x06001761 RID: 5985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001761")]
	[Address(RVA = "0x88F9D0", Offset = "0x88E9D0", VA = "0x18088F9D0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001762 RID: 5986 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001762")]
	[Address(RVA = "0x88FA90", Offset = "0x88EA90", VA = "0x18088FA90")]
	private void Update()
	{
	}

	// Token: 0x06001763 RID: 5987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001763")]
	[Address(RVA = "0x8900A0", Offset = "0x88F0A0", VA = "0x1808900A0")]
	public NeonSignController()
	{
	}

	// Token: 0x04001C65 RID: 7269
	[Token(Token = "0x4001C65")]
	[FieldOffset(Offset = "0x18")]
	public List<MeshRenderer> meshRenderers;

	// Token: 0x04001C66 RID: 7270
	[Token(Token = "0x4001C66")]
	[FieldOffset(Offset = "0x20")]
	public Light lightComponent;

	// Token: 0x04001C67 RID: 7271
	[Token(Token = "0x4001C67")]
	[FieldOffset(Offset = "0x28")]
	public List<Material> materialAnimations;

	// Token: 0x04001C68 RID: 7272
	[Token(Token = "0x4001C68")]
	[FieldOffset(Offset = "0x30")]
	public List<bool> lightBools;

	// Token: 0x04001C69 RID: 7273
	[Token(Token = "0x4001C69")]
	[FieldOffset(Offset = "0x38")]
	public int frameCursor;

	// Token: 0x04001C6A RID: 7274
	[Token(Token = "0x4001C6A")]
	[FieldOffset(Offset = "0x3C")]
	public int frameDelay;

	// Token: 0x04001C6B RID: 7275
	[Token(Token = "0x4001C6B")]
	[FieldOffset(Offset = "0x40")]
	private float frameCounter;

	// Token: 0x04001C6C RID: 7276
	[Token(Token = "0x4001C6C")]
	[FieldOffset(Offset = "0x44")]
	public bool useAddressColours;

	// Token: 0x04001C6D RID: 7277
	[Token(Token = "0x4001C6D")]
	[FieldOffset(Offset = "0x45")]
	public bool changeBaseColour;

	// Token: 0x04001C6E RID: 7278
	[Token(Token = "0x4001C6E")]
	[FieldOffset(Offset = "0x46")]
	public bool changeAltColour1;

	// Token: 0x04001C6F RID: 7279
	[Token(Token = "0x4001C6F")]
	[FieldOffset(Offset = "0x47")]
	public bool changeAltColour2;

	// Token: 0x04001C70 RID: 7280
	[Token(Token = "0x4001C70")]
	[FieldOffset(Offset = "0x48")]
	public bool changeAltColour3;

	// Token: 0x04001C71 RID: 7281
	[Token(Token = "0x4001C71")]
	[FieldOffset(Offset = "0x50")]
	public AudioEvent audioLoop;

	// Token: 0x04001C72 RID: 7282
	[Token(Token = "0x4001C72")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 localSoundOffset;

	// Token: 0x04001C73 RID: 7283
	[Token(Token = "0x4001C73")]
	[FieldOffset(Offset = "0x68")]
	private AudioController.LoopingSoundInfo loop;

	// Token: 0x04001C74 RID: 7284
	[Token(Token = "0x4001C74")]
	[FieldOffset(Offset = "0x70")]
	private NewNode closestStreetNode;
}
