using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020006B4 RID: 1716
[Token(Token = "0x20006B4")]
public class DragPanel : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>, IDisposable
{
	// Token: 0x1400004E RID: 78
	// (add) Token: 0x06002664 RID: 9828 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002665 RID: 9829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400004E")]
	public event DragPanel.DragEnd OnDragEnd
	{
		[Token(Token = "0x6002664")]
		[Address(RVA = "0xBE8E80", Offset = "0xBE7E80", VA = "0x180BE8E80")]
		add
		{
		}
		[Token(Token = "0x6002665")]
		[Address(RVA = "0xBE8F70", Offset = "0xBE7F70", VA = "0x180BE8F70")]
		remove
		{
		}
	}

	// Token: 0x06002666 RID: 9830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002666")]
	[Address(RVA = "0xBE9060", Offset = "0xBE8060", VA = "0x180BE9060")]
	private void Start()
	{
	}

	// Token: 0x06002667 RID: 9831 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002667")]
	[Address(RVA = "0xBE93F0", Offset = "0xBE83F0", VA = "0x180BE93F0", Slot = "11")]
	public virtual void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06002668 RID: 9832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002668")]
	[Address(RVA = "0xBE94A0", Offset = "0xBE84A0", VA = "0x180BE94A0", Slot = "12")]
	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06002669 RID: 9833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002669")]
	[Address(RVA = "0xBE95D0", Offset = "0xBE85D0", VA = "0x180BE95D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600266A RID: 9834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600266A")]
	[Address(RVA = "0xBE9770", Offset = "0xBE8770", VA = "0x180BE9770", Slot = "13")]
	public virtual void OnPointerDown(PointerEventData data)
	{
	}

	// Token: 0x0600266B RID: 9835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600266B")]
	[Address(RVA = "0xBE9970", Offset = "0xBE8970", VA = "0x180BE9970", Slot = "14")]
	public virtual void OnBeginDrag(PointerEventData data)
	{
	}

	// Token: 0x0600266C RID: 9836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600266C")]
	[Address(RVA = "0xBE99E0", Offset = "0xBE89E0", VA = "0x180BE99E0", Slot = "15")]
	public virtual void OnEndDrag(PointerEventData data)
	{
	}

	// Token: 0x0600266D RID: 9837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600266D")]
	[Address(RVA = "0xBE9A90", Offset = "0xBE8A90", VA = "0x180BE9A90", Slot = "16")]
	public virtual void OnDrag(PointerEventData data)
	{
	}

	// Token: 0x0600266E RID: 9838 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600266E")]
	[Address(RVA = "0xBEA070", Offset = "0xBE9070", VA = "0x180BEA070")]
	private IEnumerator Drag(PointerEventData data)
	{
		return null;
	}

	// Token: 0x0600266F RID: 9839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600266F")]
	[Address(RVA = "0xBEA110", Offset = "0xBE9110", VA = "0x180BEA110", Slot = "17")]
	public virtual void EndDrag()
	{
	}

	// Token: 0x06002670 RID: 9840 RVA: 0x0000EE80 File Offset: 0x0000D080
	[Token(Token = "0x6002670")]
	[Address(RVA = "0xBEA560", Offset = "0xBE9560", VA = "0x180BEA560")]
	public Vector2 ClampToWindow(PointerEventData data)
	{
		return default(Vector2);
	}

	// Token: 0x06002671 RID: 9841 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002671")]
	[Address(RVA = "0xBEA690", Offset = "0xBE9690", VA = "0x180BEA690", Slot = "18")]
	public virtual void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x06002672 RID: 9842 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002672")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "19")]
	public virtual void OnLeftClick()
	{
	}

	// Token: 0x06002673 RID: 9843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002673")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "20")]
	public virtual void OnRightClick()
	{
	}

	// Token: 0x06002674 RID: 9844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002674")]
	[Address(RVA = "0xBEA900", Offset = "0xBE9900", VA = "0x180BEA900", Slot = "21")]
	public virtual void OnLeftDoubleClick()
	{
	}

	// Token: 0x06002675 RID: 9845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002675")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "22")]
	public virtual void OnRightDoubleClick()
	{
	}

	// Token: 0x06002676 RID: 9846 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002676")]
	[Address(RVA = "0xBEAA20", Offset = "0xBE9A20", VA = "0x180BEAA20")]
	public DragPanel()
	{
	}

	// Token: 0x04003092 RID: 12434
	[Token(Token = "0x4003092")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 pointerOffset;

	// Token: 0x04003093 RID: 12435
	[Token(Token = "0x4003093")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform parentRect;

	// Token: 0x04003094 RID: 12436
	[Token(Token = "0x4003094")]
	[FieldOffset(Offset = "0x28")]
	public InfoWindow parentWindow;

	// Token: 0x04003095 RID: 12437
	[Token(Token = "0x4003095")]
	[FieldOffset(Offset = "0x30")]
	public bool draggableComponent;

	// Token: 0x04003096 RID: 12438
	[Token(Token = "0x4003096")]
	[FieldOffset(Offset = "0x38")]
	public string dragTag;

	// Token: 0x04003097 RID: 12439
	[Token(Token = "0x4003097")]
	[FieldOffset(Offset = "0x40")]
	public bool isDragging;

	// Token: 0x04003098 RID: 12440
	[Token(Token = "0x4003098")]
	[FieldOffset(Offset = "0x44")]
	private float lastLeftClick;

	// Token: 0x04003099 RID: 12441
	[Token(Token = "0x4003099")]
	[FieldOffset(Offset = "0x48")]
	private float lastRightClick;

	// Token: 0x0400309B RID: 12443
	[Token(Token = "0x400309B")]
	[FieldOffset(Offset = "0x58")]
	private List<Image> rayTargets;

	// Token: 0x020006B5 RID: 1717
	// (Invoke) Token: 0x06002678 RID: 9848
	[Token(Token = "0x20006B5")]
	public delegate void DragEnd(GameObject dragObj, string tag);

	// Token: 0x020006B6 RID: 1718
	[Token(Token = "0x20006B6")]
	private sealed class <Drag>d__21 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600267B RID: 9851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267B")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Drag>d__21(int <>1__state)
		{
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x0000EE98 File Offset: 0x0000D098
		[Token(Token = "0x600267D")]
		[Address(RVA = "0xBEABA0", Offset = "0xBE9BA0", VA = "0x180BEABA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000141")]
		private object Current
		{
			[Token(Token = "0x600267E")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600267F")]
		[Address(RVA = "0xBEB030", Offset = "0xBEA030", VA = "0x180BEB030", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000142")]
		private object Current
		{
			[Token(Token = "0x6002680")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400309C RID: 12444
		[Token(Token = "0x400309C")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400309D RID: 12445
		[Token(Token = "0x400309D")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400309E RID: 12446
		[Token(Token = "0x400309E")]
		[FieldOffset(Offset = "0x20")]
		public DragPanel <>4__this;
	}
}
