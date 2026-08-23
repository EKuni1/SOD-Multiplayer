using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000231 RID: 561
[Token(Token = "0x2000231")]
public class ObjectPhotoCaptureController : MonoBehaviour
{
	// Token: 0x06000CC3 RID: 3267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CC3")]
	[Address(RVA = "0x59F490", Offset = "0x59E490", VA = "0x18059F490")]
	public void LoadIndex()
	{
	}

	// Token: 0x06000CC4 RID: 3268 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CC4")]
	[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0")]
	private List<InteractablePreset> GetValidPresets()
	{
		return null;
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CC5")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void LoadSingle()
	{
	}

	// Token: 0x06000CC6 RID: 3270 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void UpdatePositions()
	{
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0x59F4E0", Offset = "0x59E4E0", VA = "0x18059F4E0")]
	public void NextIndex()
	{
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CC8")]
	[Address(RVA = "0x59F550", Offset = "0x59E550", VA = "0x18059F550")]
	public void PreviousIndex()
	{
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CC9")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CaptureSingle()
	{
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CCA")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CaptureAllSpawnableInteractables()
	{
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CCB")]
	[Address(RVA = "0x59F5D0", Offset = "0x59E5D0", VA = "0x18059F5D0")]
	public ObjectPhotoCaptureController()
	{
	}

	// Token: 0x04000E1C RID: 3612
	[Token(Token = "0x4000E1C")]
	[FieldOffset(Offset = "0x18")]
	public Transform spawnParent;

	// Token: 0x04000E1D RID: 3613
	[Token(Token = "0x4000E1D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject spawnedObject;

	// Token: 0x04000E1E RID: 3614
	[Token(Token = "0x4000E1E")]
	[FieldOffset(Offset = "0x28")]
	public Camera captureCam;

	// Token: 0x04000E1F RID: 3615
	[Token(Token = "0x4000E1F")]
	[FieldOffset(Offset = "0x30")]
	public int resolution;

	// Token: 0x04000E20 RID: 3616
	[Token(Token = "0x4000E20")]
	[FieldOffset(Offset = "0x38")]
	public Sprite captured;

	// Token: 0x04000E21 RID: 3617
	[Token(Token = "0x4000E21")]
	[FieldOffset(Offset = "0x40")]
	public Sprite icon;

	// Token: 0x04000E22 RID: 3618
	[Token(Token = "0x4000E22")]
	[FieldOffset(Offset = "0x48")]
	public InteractablePreset prefabOverrideObject;

	// Token: 0x04000E23 RID: 3619
	[Token(Token = "0x4000E23")]
	[FieldOffset(Offset = "0x50")]
	public GameObject prefabOverride;

	// Token: 0x04000E24 RID: 3620
	[Token(Token = "0x4000E24")]
	[FieldOffset(Offset = "0x58")]
	public float scale;

	// Token: 0x04000E25 RID: 3621
	[Token(Token = "0x4000E25")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 itemPos;

	// Token: 0x04000E26 RID: 3622
	[Token(Token = "0x4000E26")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 itemEuler;

	// Token: 0x04000E27 RID: 3623
	[Token(Token = "0x4000E27")]
	[FieldOffset(Offset = "0x74")]
	public Vector2 captureIndex;

	// Token: 0x04000E28 RID: 3624
	[Token(Token = "0x4000E28")]
	[FieldOffset(Offset = "0x80")]
	public InteractablePreset captureSingle;
}
