using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020006B8 RID: 1720
[Token(Token = "0x20006B8")]
public class ResizePanel : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x0600268A RID: 9866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600268A")]
	[Address(RVA = "0xBEB2F0", Offset = "0xBEA2F0", VA = "0x180BEB2F0", Slot = "4")]
	public void OnPointerDown(PointerEventData data)
	{
	}

	// Token: 0x0600268B RID: 9867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600268B")]
	[Address(RVA = "0xBEB5E0", Offset = "0xBEA5E0", VA = "0x180BEB5E0", Slot = "9")]
	public virtual void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x0600268C RID: 9868 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600268C")]
	[Address(RVA = "0xBEB690", Offset = "0xBEA690", VA = "0x180BEB690", Slot = "10")]
	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x0600268D RID: 9869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600268D")]
	[Address(RVA = "0xBEB7D0", Offset = "0xBEA7D0", VA = "0x180BEB7D0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600268E RID: 9870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600268E")]
	[Address(RVA = "0xBEB970", Offset = "0xBEA970", VA = "0x180BEB970", Slot = "5")]
	public void OnEndDrag(PointerEventData data)
	{
	}

	// Token: 0x0600268F RID: 9871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600268F")]
	[Address(RVA = "0xBEBA20", Offset = "0xBEAA20", VA = "0x180BEBA20", Slot = "6")]
	public void OnDrag(PointerEventData data)
	{
	}

	// Token: 0x06002690 RID: 9872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002690")]
	[Address(RVA = "0xBEBEF0", Offset = "0xBEAEF0", VA = "0x180BEBEF0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002691 RID: 9873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002691")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ResizePanel()
	{
	}

	// Token: 0x040030A3 RID: 12451
	[Token(Token = "0x40030A3")]
	[FieldOffset(Offset = "0x18")]
	public InfoWindow controller;

	// Token: 0x040030A4 RID: 12452
	[Token(Token = "0x40030A4")]
	[FieldOffset(Offset = "0x20")]
	public bool resizingActive;

	// Token: 0x040030A5 RID: 12453
	[Token(Token = "0x40030A5")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 currentPointerPosition;

	// Token: 0x040030A6 RID: 12454
	[Token(Token = "0x40030A6")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 previousPointerPosition;

	// Token: 0x040030A7 RID: 12455
	[Token(Token = "0x40030A7")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 pivot;
}
