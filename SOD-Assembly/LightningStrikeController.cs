using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200037F RID: 895
[Token(Token = "0x200037F")]
public class LightningStrikeController : MonoBehaviour
{
	// Token: 0x060013FC RID: 5116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013FC")]
	[Address(RVA = "0x7A6DA0", Offset = "0x7A5DA0", VA = "0x1807A6DA0")]
	private void Start()
	{
	}

	// Token: 0x060013FD RID: 5117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013FD")]
	[Address(RVA = "0x7A6E10", Offset = "0x7A5E10", VA = "0x1807A6E10")]
	private void Update()
	{
	}

	// Token: 0x060013FE RID: 5118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013FE")]
	[Address(RVA = "0x7A6F50", Offset = "0x7A5F50", VA = "0x1807A6F50")]
	public LightningStrikeController()
	{
	}

	// Token: 0x04001879 RID: 6265
	[Token(Token = "0x4001879")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 aliveTime;

	// Token: 0x0400187A RID: 6266
	[Token(Token = "0x400187A")]
	[FieldOffset(Offset = "0x20")]
	public float timer;

	// Token: 0x0400187B RID: 6267
	[Token(Token = "0x400187B")]
	[FieldOffset(Offset = "0x28")]
	public Transform startPoint;

	// Token: 0x0400187C RID: 6268
	[Token(Token = "0x400187C")]
	[FieldOffset(Offset = "0x30")]
	public Transform endPoint;
}
