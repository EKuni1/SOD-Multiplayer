using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000406 RID: 1030
[Token(Token = "0x2000406")]
public class NeonLetterFlickerController : MonoBehaviour
{
	// Token: 0x0600175C RID: 5980 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600175C")]
	[Address(RVA = "0x88EE20", Offset = "0x88DE20", VA = "0x18088EE20")]
	private void OnEnable()
	{
	}

	// Token: 0x0600175D RID: 5981 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600175D")]
	[Address(RVA = "0x88F040", Offset = "0x88E040", VA = "0x18088F040")]
	private void Update()
	{
	}

	// Token: 0x0600175E RID: 5982 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600175E")]
	[Address(RVA = "0x88F2D0", Offset = "0x88E2D0", VA = "0x18088F2D0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600175F RID: 5983 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600175F")]
	[Address(RVA = "0x88F4B0", Offset = "0x88E4B0", VA = "0x18088F4B0")]
	public NeonLetterFlickerController()
	{
	}

	// Token: 0x04001C5F RID: 7263
	[Token(Token = "0x4001C5F")]
	[FieldOffset(Offset = "0x18")]
	public CityControls.NeonMaterial neonMat;

	// Token: 0x04001C60 RID: 7264
	[Token(Token = "0x4001C60")]
	[FieldOffset(Offset = "0x20")]
	public bool state;

	// Token: 0x04001C61 RID: 7265
	[Token(Token = "0x4001C61")]
	[FieldOffset(Offset = "0x28")]
	public AudioController.LoopingSoundInfo loop;

	// Token: 0x04001C62 RID: 7266
	[Token(Token = "0x4001C62")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 soundOffset;

	// Token: 0x04001C63 RID: 7267
	[Token(Token = "0x4001C63")]
	[FieldOffset(Offset = "0x40")]
	public NewNode closestStreetNode;

	// Token: 0x04001C64 RID: 7268
	[Token(Token = "0x4001C64")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 nodeWorldPos;
}
