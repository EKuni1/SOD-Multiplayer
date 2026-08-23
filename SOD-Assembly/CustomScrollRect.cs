using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200057B RID: 1403
[Token(Token = "0x200057B")]
public class CustomScrollRect : ScrollRect
{
	// Token: 0x06001E61 RID: 7777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E61")]
	[Address(RVA = "0xA4F7A0", Offset = "0xA4E7A0", VA = "0x180A4F7A0")]
	public void ScrollZoom(Vector2 deltaPos)
	{
	}

	// Token: 0x06001E62 RID: 7778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E62")]
	[Address(RVA = "0xA4F7D0", Offset = "0xA4E7D0", VA = "0x180A4F7D0", Slot = "44")]
	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06001E63 RID: 7779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E63")]
	[Address(RVA = "0xA4F9C0", Offset = "0xA4E9C0", VA = "0x180A4F9C0", Slot = "45")]
	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06001E64 RID: 7780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E64")]
	[Address(RVA = "0xA4FAC0", Offset = "0xA4EAC0", VA = "0x180A4FAC0", Slot = "46")]
	public override void OnDrag(PointerEventData eventData)
	{
	}

	// Token: 0x06001E65 RID: 7781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E65")]
	[Address(RVA = "0xA4FB60", Offset = "0xA4EB60", VA = "0x180A4FB60")]
	public void SetAnchorPos(Vector2 position)
	{
	}

	// Token: 0x06001E66 RID: 7782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E66")]
	[Address(RVA = "0xA4FCE0", Offset = "0xA4ECE0", VA = "0x180A4FCE0")]
	public CustomScrollRect()
	{
	}

	// Token: 0x0400270C RID: 9996
	[Token(Token = "0x400270C")]
	[FieldOffset(Offset = "0x128")]
	public bool rightMouseScroll;

	// Token: 0x0400270D RID: 9997
	[Token(Token = "0x400270D")]
	[FieldOffset(Offset = "0x129")]
	public bool leftMouseScroll;

	// Token: 0x0400270E RID: 9998
	[Token(Token = "0x400270E")]
	[FieldOffset(Offset = "0x12A")]
	public bool isScrolling;
}
