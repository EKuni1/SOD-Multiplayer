using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000694 RID: 1684
[Token(Token = "0x2000694")]
public class UIPointerController : MonoBehaviour
{
	// Token: 0x06002563 RID: 9571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002563")]
	[Address(RVA = "0xBBE3F0", Offset = "0xBBD3F0", VA = "0x180BBE3F0")]
	public void Setup(Objective newObj)
	{
	}

	// Token: 0x06002564 RID: 9572 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002564")]
	[Address(RVA = "0xBBE800", Offset = "0xBBD800", VA = "0x180BBE800")]
	private void Update()
	{
	}

	// Token: 0x06002565 RID: 9573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002565")]
	[Address(RVA = "0xBBF2F0", Offset = "0xBBE2F0", VA = "0x180BBF2F0")]
	public void Remove()
	{
	}

	// Token: 0x06002566 RID: 9574 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002566")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public UIPointerController()
	{
	}

	// Token: 0x04002FB2 RID: 12210
	[Token(Token = "0x4002FB2")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002FB3 RID: 12211
	[Token(Token = "0x4002FB3")]
	[FieldOffset(Offset = "0x20")]
	public CanvasRenderer rend;

	// Token: 0x04002FB4 RID: 12212
	[Token(Token = "0x4002FB4")]
	[FieldOffset(Offset = "0x28")]
	public float alpha;

	// Token: 0x04002FB5 RID: 12213
	[Token(Token = "0x4002FB5")]
	[FieldOffset(Offset = "0x2C")]
	public float fadeIn;

	// Token: 0x04002FB6 RID: 12214
	[Token(Token = "0x4002FB6")]
	[FieldOffset(Offset = "0x30")]
	public Objective objective;

	// Token: 0x04002FB7 RID: 12215
	[Token(Token = "0x4002FB7")]
	[FieldOffset(Offset = "0x38")]
	public Image img;

	// Token: 0x04002FB8 RID: 12216
	[Token(Token = "0x4002FB8")]
	[FieldOffset(Offset = "0x40")]
	public float distance;

	// Token: 0x04002FB9 RID: 12217
	[Token(Token = "0x4002FB9")]
	[FieldOffset(Offset = "0x48")]
	public NewNode node;
}
