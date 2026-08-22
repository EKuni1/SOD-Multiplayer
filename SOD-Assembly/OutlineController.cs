using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200053F RID: 1343
[Token(Token = "0x200053F")]
public class OutlineController : MonoBehaviour
{
	// Token: 0x06001D40 RID: 7488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D40")]
	[Address(RVA = "0xA19540", Offset = "0xA18540", VA = "0x180A19540")]
	public void Setup()
	{
	}

	// Token: 0x06001D41 RID: 7489 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D41")]
	[Address(RVA = "0xA19550", Offset = "0xA18550", VA = "0x180A19550")]
	public void SetOutlineActive(bool val)
	{
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D42")]
	[Address(RVA = "0xA19810", Offset = "0xA18810", VA = "0x180A19810")]
	public void SetColor(Color newCol)
	{
	}

	// Token: 0x06001D43 RID: 7491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D43")]
	[Address(RVA = "0xA19AD0", Offset = "0xA18AD0", VA = "0x180A19AD0")]
	public void SetAlpha(float val)
	{
	}

	// Token: 0x06001D44 RID: 7492 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D44")]
	[Address(RVA = "0xA19D80", Offset = "0xA18D80", VA = "0x180A19D80")]
	public OutlineController()
	{
	}

	// Token: 0x040025BC RID: 9660
	[Token(Token = "0x40025BC")]
	[FieldOffset(Offset = "0x18")]
	public int normalLayer;

	// Token: 0x040025BD RID: 9661
	[Token(Token = "0x40025BD")]
	[FieldOffset(Offset = "0x20")]
	public Actor actor;

	// Token: 0x040025BE RID: 9662
	[Token(Token = "0x40025BE")]
	[FieldOffset(Offset = "0x28")]
	public List<MeshRenderer> meshesToOutline;

	// Token: 0x040025BF RID: 9663
	[Token(Token = "0x40025BF")]
	[FieldOffset(Offset = "0x30")]
	public bool outlineActive;

	// Token: 0x040025C0 RID: 9664
	[Token(Token = "0x40025C0")]
	[FieldOffset(Offset = "0x31")]
	public bool isSetup;
}
