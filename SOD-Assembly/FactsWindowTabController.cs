using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005F8 RID: 1528
[Token(Token = "0x20005F8")]
public class FactsWindowTabController : MonoBehaviour
{
	// Token: 0x06002182 RID: 8578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002182")]
	[Address(RVA = "0xB0BC50", Offset = "0xB0AC50", VA = "0x180B0BC50")]
	public void Setup(InfoWindow newWindow)
	{
	}

	// Token: 0x06002183 RID: 8579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002183")]
	[Address(RVA = "0xB0C2B0", Offset = "0xB0B2B0", VA = "0x180B0C2B0")]
	public void UpdateSlotContent()
	{
	}

	// Token: 0x06002184 RID: 8580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002184")]
	[Address(RVA = "0xB0C2F0", Offset = "0xB0B2F0", VA = "0x180B0C2F0")]
	public void OnWindowResize()
	{
	}

	// Token: 0x06002185 RID: 8581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002185")]
	[Address(RVA = "0xB0C9D0", Offset = "0xB0B9D0", VA = "0x180B0C9D0")]
	public FactsWindowTabController()
	{
	}

	// Token: 0x04002B37 RID: 11063
	[Token(Token = "0x4002B37")]
	[FieldOffset(Offset = "0x18")]
	public InfoWindow parentWindow;

	// Token: 0x04002B38 RID: 11064
	[Token(Token = "0x4002B38")]
	[FieldOffset(Offset = "0x20")]
	public Evidence evidence;

	// Token: 0x04002B39 RID: 11065
	[Token(Token = "0x4002B39")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform rect;

	// Token: 0x04002B3A RID: 11066
	[Token(Token = "0x4002B3A")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform scrollRectRect;

	// Token: 0x04002B3B RID: 11067
	[Token(Token = "0x4002B3B")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform parentRect;

	// Token: 0x04002B3C RID: 11068
	[Token(Token = "0x4002B3C")]
	[FieldOffset(Offset = "0x40")]
	public WindowContentController contentController;

	// Token: 0x04002B3D RID: 11069
	[Token(Token = "0x4002B3D")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 nativeSize;

	// Token: 0x04002B3E RID: 11070
	[Token(Token = "0x4002B3E")]
	[FieldOffset(Offset = "0x50")]
	public float fitScale;
}
