using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020006B3 RID: 1715
[Token(Token = "0x20006B3")]
public class DragCasePanel : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x06002659 RID: 9817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002659")]
	[Address(RVA = "0xBE7350", Offset = "0xBE6350", VA = "0x180BE7350")]
	public void Setup(PinnedItemController newController)
	{
	}

	// Token: 0x0600265A RID: 9818 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600265A")]
	[Address(RVA = "0xBE75C0", Offset = "0xBE65C0", VA = "0x180BE75C0", Slot = "4")]
	public void OnPointerDown(PointerEventData data)
	{
	}

	// Token: 0x0600265B RID: 9819 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600265B")]
	[Address(RVA = "0xBE7C20", Offset = "0xBE6C20", VA = "0x180BE7C20", Slot = "5")]
	public void OnDrag(PointerEventData data)
	{
	}

	// Token: 0x0600265C RID: 9820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600265C")]
	[Address(RVA = "0xBE7F90", Offset = "0xBE6F90", VA = "0x180BE7F90")]
	public void ForceDrag(Vector2 cursorPosition)
	{
	}

	// Token: 0x0600265D RID: 9821 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600265D")]
	[Address(RVA = "0xBE82D0", Offset = "0xBE72D0", VA = "0x180BE82D0")]
	public void ForceDragController(Vector2 newLocalPosition)
	{
	}

	// Token: 0x0600265E RID: 9822 RVA: 0x0000EE38 File Offset: 0x0000D038
	[Token(Token = "0x600265E")]
	[Address(RVA = "0xBE8650", Offset = "0xBE7650", VA = "0x180BE8650")]
	private Vector2 ClampCursor(Vector2 rawPointerPosition)
	{
		return default(Vector2);
	}

	// Token: 0x0600265F RID: 9823 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600265F")]
	[Address(RVA = "0xBE8740", Offset = "0xBE7740", VA = "0x180BE8740")]
	public void SetPositionCursor(Vector2 pointerPosition, Vector2 offset)
	{
	}

	// Token: 0x06002660 RID: 9824 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002660")]
	[Address(RVA = "0xBE88D0", Offset = "0xBE78D0", VA = "0x180BE88D0")]
	public void SetPositionDirect(Vector2 localPosition)
	{
	}

	// Token: 0x06002661 RID: 9825 RVA: 0x0000EE50 File Offset: 0x0000D050
	[Token(Token = "0x6002661")]
	[Address(RVA = "0xBE8980", Offset = "0xBE7980", VA = "0x180BE8980")]
	private Vector2 ClampToCorkboard(Vector2 original)
	{
		return default(Vector2);
	}

	// Token: 0x06002662 RID: 9826 RVA: 0x0000EE68 File Offset: 0x0000D068
	[Token(Token = "0x6002662")]
	[Address(RVA = "0xBE8B80", Offset = "0xBE7B80", VA = "0x180BE8B80")]
	private Vector2 RadiusClamp(Vector2 original, Vector2 point, float radius)
	{
		return default(Vector2);
	}

	// Token: 0x06002663 RID: 9827 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002663")]
	[Address(RVA = "0xBE8CD0", Offset = "0xBE7CD0", VA = "0x180BE8CD0")]
	public DragCasePanel()
	{
	}

	// Token: 0x0400308B RID: 12427
	[Token(Token = "0x400308B")]
	[FieldOffset(Offset = "0x18")]
	private Vector2 pointerOffset;

	// Token: 0x0400308C RID: 12428
	[Token(Token = "0x400308C")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform pinnedContainer;

	// Token: 0x0400308D RID: 12429
	[Token(Token = "0x400308D")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform panelRect;

	// Token: 0x0400308E RID: 12430
	[Token(Token = "0x400308E")]
	[FieldOffset(Offset = "0x30")]
	public PinnedItemController itemController;

	// Token: 0x0400308F RID: 12431
	[Token(Token = "0x400308F")]
	[FieldOffset(Offset = "0x38")]
	public bool multipleParentInstances;

	// Token: 0x04003090 RID: 12432
	[Token(Token = "0x4003090")]
	[FieldOffset(Offset = "0x40")]
	private List<DragCasePanel> pinnedFiles;

	// Token: 0x04003091 RID: 12433
	[Token(Token = "0x4003091")]
	[FieldOffset(Offset = "0x48")]
	public List<Vector2> offsets;
}
