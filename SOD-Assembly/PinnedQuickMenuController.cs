using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000563 RID: 1379
[Token(Token = "0x2000563")]
public class PinnedQuickMenuController : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x06001DF6 RID: 7670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DF6")]
	[Address(RVA = "0xA3EC70", Offset = "0xA3DC70", VA = "0x180A3EC70")]
	public void Setup(PinnedItemController newParent)
	{
	}

	// Token: 0x06001DF7 RID: 7671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DF7")]
	[Address(RVA = "0xA3FC60", Offset = "0xA3EC60", VA = "0x180A3FC60")]
	public void Remove(bool instant = false)
	{
	}

	// Token: 0x06001DF8 RID: 7672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DF8")]
	[Address(RVA = "0xA3FDB0", Offset = "0xA3EDB0", VA = "0x180A3FDB0")]
	private void Update()
	{
	}

	// Token: 0x06001DF9 RID: 7673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DF9")]
	[Address(RVA = "0xA40AF0", Offset = "0xA3FAF0", VA = "0x180A40AF0")]
	public void LocateOnMapButton()
	{
	}

	// Token: 0x06001DFA RID: 7674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DFA")]
	[Address(RVA = "0xA40C50", Offset = "0xA3FC50", VA = "0x180A40C50")]
	public void PlotRouteButton()
	{
	}

	// Token: 0x06001DFB RID: 7675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DFB")]
	[Address(RVA = "0xA40DB0", Offset = "0xA3FDB0", VA = "0x180A40DB0")]
	public void ToggleCollapseButton()
	{
	}

	// Token: 0x06001DFC RID: 7676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DFC")]
	[Address(RVA = "0xA40ED0", Offset = "0xA3FED0", VA = "0x180A40ED0")]
	public void ToggleCrossOutButton()
	{
	}

	// Token: 0x06001DFD RID: 7677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DFD")]
	[Address(RVA = "0xA40FF0", Offset = "0xA3FFF0", VA = "0x180A40FF0")]
	public void StickyNoteButton()
	{
	}

	// Token: 0x06001DFE RID: 7678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DFE")]
	[Address(RVA = "0xA41110", Offset = "0xA40110", VA = "0x180A41110")]
	public void NewLinkButton()
	{
	}

	// Token: 0x06001DFF RID: 7679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DFF")]
	[Address(RVA = "0xA41260", Offset = "0xA40260", VA = "0x180A41260")]
	public void ContextMenuButton()
	{
	}

	// Token: 0x06001E00 RID: 7680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E00")]
	[Address(RVA = "0xA41470", Offset = "0xA40470", VA = "0x180A41470", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06001E01 RID: 7681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E01")]
	[Address(RVA = "0xA41480", Offset = "0xA40480", VA = "0x180A41480", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06001E02 RID: 7682 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E02")]
	[Address(RVA = "0xA41690", Offset = "0xA40690", VA = "0x180A41690")]
	public PinnedQuickMenuController()
	{
	}

	// Token: 0x04002681 RID: 9857
	[Token(Token = "0x4002681")]
	[FieldOffset(Offset = "0x18")]
	public List<CanvasRenderer> renderers;

	// Token: 0x04002682 RID: 9858
	[Token(Token = "0x4002682")]
	[FieldOffset(Offset = "0x20")]
	public PinnedItemController parentPinned;

	// Token: 0x04002683 RID: 9859
	[Token(Token = "0x4002683")]
	[FieldOffset(Offset = "0x28")]
	public ButtonController locateOnMapButton;

	// Token: 0x04002684 RID: 9860
	[Token(Token = "0x4002684")]
	[FieldOffset(Offset = "0x30")]
	public ButtonController plotRouteButton;

	// Token: 0x04002685 RID: 9861
	[Token(Token = "0x4002685")]
	[FieldOffset(Offset = "0x38")]
	public ButtonController toggleCollapseButton;

	// Token: 0x04002686 RID: 9862
	[Token(Token = "0x4002686")]
	[FieldOffset(Offset = "0x40")]
	public ButtonController toggleCrossOutButton;

	// Token: 0x04002687 RID: 9863
	[Token(Token = "0x4002687")]
	[FieldOffset(Offset = "0x48")]
	public ButtonController stickyNoteButton;

	// Token: 0x04002688 RID: 9864
	[Token(Token = "0x4002688")]
	[FieldOffset(Offset = "0x50")]
	public ButtonController newLinkButton;

	// Token: 0x04002689 RID: 9865
	[Token(Token = "0x4002689")]
	[FieldOffset(Offset = "0x58")]
	public ButtonController contextMenuButton;

	// Token: 0x0400268A RID: 9866
	[Token(Token = "0x400268A")]
	[FieldOffset(Offset = "0x60")]
	public List<ButtonController> activeButtons;

	// Token: 0x0400268B RID: 9867
	[Token(Token = "0x400268B")]
	[FieldOffset(Offset = "0x68")]
	public bool isOver;

	// Token: 0x0400268C RID: 9868
	[Token(Token = "0x400268C")]
	[FieldOffset(Offset = "0x69")]
	public bool active;

	// Token: 0x0400268D RID: 9869
	[Token(Token = "0x400268D")]
	[FieldOffset(Offset = "0x6C")]
	public float appearProgress;
}
