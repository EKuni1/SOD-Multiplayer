using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000634 RID: 1588
[Token(Token = "0x2000634")]
public class DragCoverage : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>, IDisposable
{
	// Token: 0x14000040 RID: 64
	// (add) Token: 0x060022D7 RID: 8919 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060022D8 RID: 8920 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000040")]
	public event DragCoverage.OnDragCoverage OnDragged
	{
		[Token(Token = "0x60022D7")]
		[Address(RVA = "0xB409C0", Offset = "0xB3F9C0", VA = "0x180B409C0")]
		add
		{
		}
		[Token(Token = "0x60022D8")]
		[Address(RVA = "0xB40AB0", Offset = "0xB3FAB0", VA = "0x180B40AB0")]
		remove
		{
		}
	}

	// Token: 0x060022D9 RID: 8921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022D9")]
	[Address(RVA = "0xB40BA0", Offset = "0xB3FBA0", VA = "0x180B40BA0", Slot = "4")]
	public void OnPointerDown(PointerEventData data)
	{
	}

	// Token: 0x060022DA RID: 8922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022DA")]
	[Address(RVA = "0xB40C60", Offset = "0xB3FC60", VA = "0x180B40C60", Slot = "8")]
	public virtual void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x060022DB RID: 8923 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022DB")]
	[Address(RVA = "0xB40D10", Offset = "0xB3FD10", VA = "0x180B40D10", Slot = "9")]
	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x060022DC RID: 8924 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022DC")]
	[Address(RVA = "0xB40E40", Offset = "0xB3FE40", VA = "0x180B40E40", Slot = "5")]
	public void OnDrag(PointerEventData data)
	{
	}

	// Token: 0x060022DD RID: 8925 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022DD")]
	[Address(RVA = "0xB41040", Offset = "0xB40040", VA = "0x180B41040")]
	private void OnDestroy()
	{
	}

	// Token: 0x060022DE RID: 8926 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022DE")]
	[Address(RVA = "0xB411E0", Offset = "0xB401E0", VA = "0x180B411E0")]
	public void SetSize(float newSize)
	{
	}

	// Token: 0x060022DF RID: 8927 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022DF")]
	[Address(RVA = "0xB412C0", Offset = "0xB402C0", VA = "0x180B412C0")]
	public DragCoverage()
	{
	}

	// Token: 0x04002CA2 RID: 11426
	[Token(Token = "0x4002CA2")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform parentRect;

	// Token: 0x04002CA3 RID: 11427
	[Token(Token = "0x4002CA3")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 currentPointerPosition;

	// Token: 0x04002CA4 RID: 11428
	[Token(Token = "0x4002CA4")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 previousPointerPosition;

	// Token: 0x04002CA5 RID: 11429
	[Token(Token = "0x4002CA5")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 pivot;

	// Token: 0x04002CA6 RID: 11430
	[Token(Token = "0x4002CA6")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 sizeRange;

	// Token: 0x04002CA7 RID: 11431
	[Token(Token = "0x4002CA7")]
	[FieldOffset(Offset = "0x40")]
	public float edgeBuffer;

	// Token: 0x02000635 RID: 1589
	// (Invoke) Token: 0x060022E1 RID: 8929
	[Token(Token = "0x2000635")]
	public delegate void OnDragCoverage();
}
