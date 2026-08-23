using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200064A RID: 1610
[Token(Token = "0x200064A")]
public class MapPinButtonController : ButtonController
{
	// Token: 0x0600237A RID: 9082 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600237A")]
	[Address(RVA = "0xB66880", Offset = "0xB65880", VA = "0x180B66880")]
	public void Setup(InfoWindow newWindow)
	{
	}

	// Token: 0x0600237B RID: 9083 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600237B")]
	[Address(RVA = "0xB66AA0", Offset = "0xB65AA0", VA = "0x180B66AA0", Slot = "19")]
	public override void OnLeftDoubleClick()
	{
	}

	// Token: 0x0600237C RID: 9084 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600237C")]
	[Address(RVA = "0xB66BC0", Offset = "0xB65BC0", VA = "0x180B66BC0", Slot = "25")]
	public override void OnHoverStart()
	{
	}

	// Token: 0x0600237D RID: 9085 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600237D")]
	[Address(RVA = "0xA2C450", Offset = "0xA2B450", VA = "0x180A2C450")]
	public MapPinButtonController()
	{
	}

	// Token: 0x04002D56 RID: 11606
	[Token(Token = "0x4002D56")]
	[FieldOffset(Offset = "0x1A8")]
	public RawImage pin;

	// Token: 0x04002D57 RID: 11607
	[Token(Token = "0x4002D57")]
	[FieldOffset(Offset = "0x1B0")]
	public InfoWindow evWindow;

	// Token: 0x04002D58 RID: 11608
	[Token(Token = "0x4002D58")]
	[FieldOffset(Offset = "0x1B8")]
	public CanvasRenderer canvasRend;
}
