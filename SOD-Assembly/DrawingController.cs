using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000561 RID: 1377
[Token(Token = "0x2000561")]
public class DrawingController : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x06001DE6 RID: 7654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DE6")]
	[Address(RVA = "0xA3CE40", Offset = "0xA3BE40", VA = "0x180A3CE40")]
	private void Awake()
	{
	}

	// Token: 0x06001DE7 RID: 7655 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DE7")]
	[Address(RVA = "0xA3D160", Offset = "0xA3C160", VA = "0x180A3D160", Slot = "6")]
	public virtual void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06001DE8 RID: 7656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DE8")]
	[Address(RVA = "0xA3D170", Offset = "0xA3C170", VA = "0x180A3D170", Slot = "7")]
	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06001DE9 RID: 7657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DE9")]
	[Address(RVA = "0xA3D280", Offset = "0xA3C280", VA = "0x180A3D280")]
	public void SetDrawingActive(bool val)
	{
	}

	// Token: 0x06001DEA RID: 7658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DEA")]
	[Address(RVA = "0xA3D510", Offset = "0xA3C510", VA = "0x180A3D510")]
	public void ResetDrawingTexture()
	{
	}

	// Token: 0x06001DEB RID: 7659 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DEB")]
	[Address(RVA = "0xA3D920", Offset = "0xA3C920", VA = "0x180A3D920")]
	public void SetEraserMode(bool val)
	{
	}

	// Token: 0x06001DEC RID: 7660 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DEC")]
	[Address(RVA = "0xA3D9E0", Offset = "0xA3C9E0", VA = "0x180A3D9E0")]
	public void SetBrushColour(Color newCol)
	{
	}

	// Token: 0x06001DED RID: 7661 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DED")]
	[Address(RVA = "0xA3DA20", Offset = "0xA3CA20", VA = "0x180A3DA20")]
	public void SetBrushImage(Texture2D newBrush)
	{
	}

	// Token: 0x06001DEE RID: 7662 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DEE")]
	[Address(RVA = "0xA3DB50", Offset = "0xA3CB50", VA = "0x180A3DB50")]
	private void Update()
	{
	}

	// Token: 0x06001DEF RID: 7663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DEF")]
	[Address(RVA = "0xA3E840", Offset = "0xA3D840", VA = "0x180A3E840")]
	public DrawingController()
	{
	}

	// Token: 0x04002665 RID: 9829
	[Token(Token = "0x4002665")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform container;

	// Token: 0x04002666 RID: 9830
	[Token(Token = "0x4002666")]
	[FieldOffset(Offset = "0x20")]
	public RawImage img;

	// Token: 0x04002667 RID: 9831
	[Token(Token = "0x4002667")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform drawBrushRect;

	// Token: 0x04002668 RID: 9832
	[Token(Token = "0x4002668")]
	[FieldOffset(Offset = "0x30")]
	public RawImage brushImage;

	// Token: 0x04002669 RID: 9833
	[Token(Token = "0x4002669")]
	[FieldOffset(Offset = "0x38")]
	public Texture2D drawingTex;

	// Token: 0x0400266A RID: 9834
	[Token(Token = "0x400266A")]
	[FieldOffset(Offset = "0x40")]
	public bool isOver;

	// Token: 0x0400266B RID: 9835
	[Token(Token = "0x400266B")]
	[FieldOffset(Offset = "0x41")]
	public bool drawingActive;

	// Token: 0x0400266C RID: 9836
	[Token(Token = "0x400266C")]
	[FieldOffset(Offset = "0x42")]
	public bool eraserMode;

	// Token: 0x0400266D RID: 9837
	[Token(Token = "0x400266D")]
	[FieldOffset(Offset = "0x43")]
	private bool lastPosValid;

	// Token: 0x0400266E RID: 9838
	[Token(Token = "0x400266E")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 lastValidLocalPos;

	// Token: 0x0400266F RID: 9839
	[Token(Token = "0x400266F")]
	[FieldOffset(Offset = "0x4C")]
	public Color brushColour;

	// Token: 0x04002670 RID: 9840
	[Token(Token = "0x4002670")]
	[FieldOffset(Offset = "0x60")]
	public Texture2D brush;

	// Token: 0x04002671 RID: 9841
	[Token(Token = "0x4002671")]
	[FieldOffset(Offset = "0x68")]
	public Vector2 brushSize;

	// Token: 0x04002672 RID: 9842
	[Token(Token = "0x4002672")]
	[FieldOffset(Offset = "0x70")]
	public bool startedDraw;

	// Token: 0x04002673 RID: 9843
	[Token(Token = "0x4002673")]
	[FieldOffset(Offset = "0x71")]
	public bool setupButtons;

	// Token: 0x04002674 RID: 9844
	[Token(Token = "0x4002674")]
	[FieldOffset(Offset = "0x78")]
	public WindowExtraControlsController windowButtonsController;

	// Token: 0x04002675 RID: 9845
	[Token(Token = "0x4002675")]
	[FieldOffset(Offset = "0x80")]
	public ButtonController toggleDrawingButton;

	// Token: 0x04002676 RID: 9846
	[Token(Token = "0x4002676")]
	[FieldOffset(Offset = "0x88")]
	public ColourSelectorButtonController colourButton;

	// Token: 0x04002677 RID: 9847
	[Token(Token = "0x4002677")]
	[FieldOffset(Offset = "0x90")]
	public ButtonController eraserButton;

	// Token: 0x04002678 RID: 9848
	[Token(Token = "0x4002678")]
	[FieldOffset(Offset = "0x98")]
	public ButtonController clearButton;
}
