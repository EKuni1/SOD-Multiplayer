using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200053D RID: 1341
[Token(Token = "0x200053D")]
public class BugController : MonoBehaviour
{
	// Token: 0x06001D3B RID: 7483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D3B")]
	[Address(RVA = "0xA18210", Offset = "0xA17210", VA = "0x180A18210")]
	public void Setup(NewRoom newRoom)
	{
	}

	// Token: 0x06001D3C RID: 7484 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D3C")]
	[Address(RVA = "0xA18810", Offset = "0xA17810", VA = "0x180A18810")]
	private void Update()
	{
	}

	// Token: 0x06001D3D RID: 7485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D3D")]
	[Address(RVA = "0xA191A0", Offset = "0xA181A0", VA = "0x180A191A0")]
	public BugController()
	{
	}

	// Token: 0x040025B4 RID: 9652
	[Token(Token = "0x40025B4")]
	[FieldOffset(Offset = "0x18")]
	public NewRoom room;

	// Token: 0x040025B5 RID: 9653
	[Token(Token = "0x40025B5")]
	[FieldOffset(Offset = "0x20")]
	private List<NewNode> nodes;

	// Token: 0x040025B6 RID: 9654
	[Token(Token = "0x40025B6")]
	[FieldOffset(Offset = "0x28")]
	public float speed;

	// Token: 0x040025B7 RID: 9655
	[Token(Token = "0x40025B7")]
	[FieldOffset(Offset = "0x2C")]
	public float turnSpeed;

	// Token: 0x040025B8 RID: 9656
	[Token(Token = "0x40025B8")]
	[FieldOffset(Offset = "0x30")]
	private bool newJourney;

	// Token: 0x040025B9 RID: 9657
	[Token(Token = "0x40025B9")]
	[FieldOffset(Offset = "0x38")]
	private NewNode destinationNode;

	// Token: 0x040025BA RID: 9658
	[Token(Token = "0x40025BA")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 destinationPos;
}
