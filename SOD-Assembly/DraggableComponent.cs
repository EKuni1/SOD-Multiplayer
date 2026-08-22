using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200057D RID: 1405
[Token(Token = "0x200057D")]
public class DraggableComponent : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x1400002D RID: 45
	// (add) Token: 0x06001E6B RID: 7787 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001E6C RID: 7788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400002D")]
	public event DraggableComponent.DragEnd OnDragEnd
	{
		[Token(Token = "0x6001E6B")]
		[Address(RVA = "0xA50450", Offset = "0xA4F450", VA = "0x180A50450")]
		add
		{
		}
		[Token(Token = "0x6001E6C")]
		[Address(RVA = "0xA50540", Offset = "0xA4F540", VA = "0x180A50540")]
		remove
		{
		}
	}

	// Token: 0x06001E6D RID: 7789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E6D")]
	[Address(RVA = "0xA50630", Offset = "0xA4F630", VA = "0x180A50630")]
	private void Start()
	{
	}

	// Token: 0x06001E6E RID: 7790 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E6E")]
	[Address(RVA = "0xA50710", Offset = "0xA4F710", VA = "0x180A50710", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06001E6F RID: 7791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E6F")]
	[Address(RVA = "0xA50760", Offset = "0xA4F760", VA = "0x180A50760", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06001E70 RID: 7792 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E70")]
	[Address(RVA = "0xA50870", Offset = "0xA4F870", VA = "0x180A50870")]
	private IEnumerator MouseOver()
	{
		return null;
	}

	// Token: 0x06001E71 RID: 7793 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E71")]
	[Address(RVA = "0xA50910", Offset = "0xA4F910", VA = "0x180A50910")]
	private IEnumerator Drag()
	{
		return null;
	}

	// Token: 0x06001E72 RID: 7794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E72")]
	[Address(RVA = "0xA509B0", Offset = "0xA4F9B0", VA = "0x180A509B0")]
	private void OnDestory()
	{
	}

	// Token: 0x06001E73 RID: 7795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E73")]
	[Address(RVA = "0xA509B0", Offset = "0xA4F9B0", VA = "0x180A509B0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001E74 RID: 7796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E74")]
	[Address(RVA = "0xA509C0", Offset = "0xA4F9C0", VA = "0x180A509C0")]
	public void EndDrag()
	{
	}

	// Token: 0x06001E75 RID: 7797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E75")]
	[Address(RVA = "0xA50BD0", Offset = "0xA4FBD0", VA = "0x180A50BD0")]
	public void SetPosition(Vector2 pointerPosition, Vector2 offset)
	{
	}

	// Token: 0x06001E76 RID: 7798 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E76")]
	[Address(RVA = "0xA50D30", Offset = "0xA4FD30", VA = "0x180A50D30")]
	public DraggableComponent()
	{
	}

	// Token: 0x04002711 RID: 10001
	[Token(Token = "0x4002711")]
	[FieldOffset(Offset = "0x18")]
	private RectTransform thisRect;

	// Token: 0x04002712 RID: 10002
	[Token(Token = "0x4002712")]
	[FieldOffset(Offset = "0x20")]
	public bool isDragging;

	// Token: 0x04002713 RID: 10003
	[Token(Token = "0x4002713")]
	[FieldOffset(Offset = "0x21")]
	public bool isOver;

	// Token: 0x04002714 RID: 10004
	[Token(Token = "0x4002714")]
	[FieldOffset(Offset = "0x28")]
	public GameObject dragObject;

	// Token: 0x04002715 RID: 10005
	[Token(Token = "0x4002715")]
	[FieldOffset(Offset = "0x30")]
	private GameObject spawnedObject;

	// Token: 0x04002716 RID: 10006
	[Token(Token = "0x4002716")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform rect;

	// Token: 0x04002717 RID: 10007
	[Token(Token = "0x4002717")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 pointerOffset;

	// Token: 0x04002718 RID: 10008
	[Token(Token = "0x4002718")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 originalClickPoint;

	// Token: 0x04002719 RID: 10009
	[Token(Token = "0x4002719")]
	[FieldOffset(Offset = "0x50")]
	private bool recClick;

	// Token: 0x0400271A RID: 10010
	[Token(Token = "0x400271A")]
	[FieldOffset(Offset = "0x54")]
	private float dragThresholdCheck;

	// Token: 0x0400271B RID: 10011
	[Token(Token = "0x400271B")]
	[FieldOffset(Offset = "0x58")]
	public GameObject objectOverride;

	// Token: 0x0400271C RID: 10012
	[Token(Token = "0x400271C")]
	[FieldOffset(Offset = "0x60")]
	public string dragTag;

	// Token: 0x0200057E RID: 1406
	// (Invoke) Token: 0x06001E78 RID: 7800
	[Token(Token = "0x200057E")]
	public delegate void DragEnd(GameObject dragObj, string tag);

	// Token: 0x0200057F RID: 1407
	[Token(Token = "0x200057F")]
	private sealed class <MouseOver>d__19 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001E7B RID: 7803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E7B")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <MouseOver>d__19(int <>1__state)
		{
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E7C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0000DA40 File Offset: 0x0000BC40
		[Token(Token = "0x6001E7D")]
		[Address(RVA = "0xA50F20", Offset = "0xA4FF20", VA = "0x180A50F20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F2")]
		private object Current
		{
			[Token(Token = "0x6001E7E")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E7F")]
		[Address(RVA = "0xA512D0", Offset = "0xA502D0", VA = "0x180A512D0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F3")]
		private object Current
		{
			[Token(Token = "0x6001E80")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400271E RID: 10014
		[Token(Token = "0x400271E")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400271F RID: 10015
		[Token(Token = "0x400271F")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002720 RID: 10016
		[Token(Token = "0x4002720")]
		[FieldOffset(Offset = "0x20")]
		public DraggableComponent <>4__this;
	}

	// Token: 0x02000580 RID: 1408
	[Token(Token = "0x2000580")]
	private sealed class <Drag>d__20 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001E81 RID: 7809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E81")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Drag>d__20(int <>1__state)
		{
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E82")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x0000DA58 File Offset: 0x0000BC58
		[Token(Token = "0x6001E83")]
		[Address(RVA = "0xA51320", Offset = "0xA50320", VA = "0x180A51320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F4")]
		private object Current
		{
			[Token(Token = "0x6001E84")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E85")]
		[Address(RVA = "0xA51E10", Offset = "0xA50E10", VA = "0x180A51E10", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000F5")]
		private object Current
		{
			[Token(Token = "0x6001E86")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002721 RID: 10017
		[Token(Token = "0x4002721")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002722 RID: 10018
		[Token(Token = "0x4002722")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002723 RID: 10019
		[Token(Token = "0x4002723")]
		[FieldOffset(Offset = "0x20")]
		public DraggableComponent <>4__this;
	}
}
