using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000048 RID: 72
[Token(Token = "0x2000048")]
public class WindowCameraController : MonoBehaviour
{
	// Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x5D23F0", Offset = "0x5D13F0", VA = "0x1805D23F0")]
	private void Awake()
	{
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x5D2490", Offset = "0x5D1490", VA = "0x1805D2490")]
	private void Start()
	{
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x5D2570", Offset = "0x5D1570", VA = "0x1805D2570")]
	private void Update()
	{
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x5D2670", Offset = "0x5D1670", VA = "0x1805D2670")]
	private void UpdateCamPos()
	{
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x5D2930", Offset = "0x5D1930", VA = "0x1805D2930")]
	public WindowCameraController()
	{
	}

	// Token: 0x04000203 RID: 515
	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x18")]
	public GameObject cameraObj;

	// Token: 0x04000204 RID: 516
	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x20")]
	private Camera cam;

	// Token: 0x04000205 RID: 517
	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x28")]
	public GameObject followObj;

	// Token: 0x04000206 RID: 518
	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 camHeightLimit;

	// Token: 0x04000207 RID: 519
	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 camPos;

	// Token: 0x04000208 RID: 520
	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x44")]
	public bool isActive;
}
