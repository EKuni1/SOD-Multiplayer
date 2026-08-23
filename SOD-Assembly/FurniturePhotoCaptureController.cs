using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200022D RID: 557
[Token(Token = "0x200022D")]
public class FurniturePhotoCaptureController : MonoBehaviour
{
	// Token: 0x06000CB0 RID: 3248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB0")]
	[Address(RVA = "0x59EFB0", Offset = "0x59DFB0", VA = "0x18059EFB0")]
	public void LoadIndex()
	{
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CB1")]
	[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0")]
	private List<FurniturePreset> GetValidPresets()
	{
		return null;
	}

	// Token: 0x06000CB2 RID: 3250 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB2")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void LoadSingle()
	{
	}

	// Token: 0x06000CB3 RID: 3251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB3")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void UpdatePositions()
	{
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB4")]
	[Address(RVA = "0x59F000", Offset = "0x59E000", VA = "0x18059F000")]
	public void NextIndex()
	{
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB5")]
	[Address(RVA = "0x59F070", Offset = "0x59E070", VA = "0x18059F070")]
	public void PreviousIndex()
	{
	}

	// Token: 0x06000CB6 RID: 3254 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB6")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CaptureSingle()
	{
	}

	// Token: 0x06000CB7 RID: 3255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB7")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CaptureAllSpawnableInteractables()
	{
	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CB8")]
	[Address(RVA = "0x59F0F0", Offset = "0x59E0F0", VA = "0x18059F0F0")]
	public FurniturePhotoCaptureController()
	{
	}

	// Token: 0x04000E0C RID: 3596
	[Token(Token = "0x4000E0C")]
	[FieldOffset(Offset = "0x18")]
	public Transform spawnParent;

	// Token: 0x04000E0D RID: 3597
	[Token(Token = "0x4000E0D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject spawnedObject;

	// Token: 0x04000E0E RID: 3598
	[Token(Token = "0x4000E0E")]
	[FieldOffset(Offset = "0x28")]
	public Camera captureCam;

	// Token: 0x04000E0F RID: 3599
	[Token(Token = "0x4000E0F")]
	[FieldOffset(Offset = "0x30")]
	public int resolution;

	// Token: 0x04000E10 RID: 3600
	[Token(Token = "0x4000E10")]
	[FieldOffset(Offset = "0x38")]
	public Sprite captured;

	// Token: 0x04000E11 RID: 3601
	[Token(Token = "0x4000E11")]
	[FieldOffset(Offset = "0x40")]
	public InteractablePreset prefabOverrideObject;

	// Token: 0x04000E12 RID: 3602
	[Token(Token = "0x4000E12")]
	[FieldOffset(Offset = "0x48")]
	public GameObject prefabOverride;

	// Token: 0x04000E13 RID: 3603
	[Token(Token = "0x4000E13")]
	[FieldOffset(Offset = "0x50")]
	public float scale;

	// Token: 0x04000E14 RID: 3604
	[Token(Token = "0x4000E14")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 itemPos;

	// Token: 0x04000E15 RID: 3605
	[Token(Token = "0x4000E15")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 itemEuler;

	// Token: 0x04000E16 RID: 3606
	[Token(Token = "0x4000E16")]
	[FieldOffset(Offset = "0x6C")]
	public Vector2 captureIndex;

	// Token: 0x04000E17 RID: 3607
	[Token(Token = "0x4000E17")]
	[FieldOffset(Offset = "0x78")]
	public FurniturePreset captureSingle;
}
