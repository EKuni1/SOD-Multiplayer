using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020006B9 RID: 1721
[Token(Token = "0x20006B9")]
public class WindowExtraControlsController : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x06002692 RID: 9874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002692")]
	[Address(RVA = "0xBEC090", Offset = "0xBEB090", VA = "0x180BEC090")]
	private void Awake()
	{
	}

	// Token: 0x06002693 RID: 9875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002693")]
	[Address(RVA = "0xA49E60", Offset = "0xA48E60", VA = "0x180A49E60", Slot = "6")]
	public virtual void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06002694 RID: 9876 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002694")]
	[Address(RVA = "0xBEC0F0", Offset = "0xBEB0F0", VA = "0x180BEC0F0", Slot = "7")]
	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06002695 RID: 9877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002695")]
	[Address(RVA = "0xBEC200", Offset = "0xBEB200", VA = "0x180BEC200")]
	public void SetEnableDrawingControls(bool val)
	{
	}

	// Token: 0x06002696 RID: 9878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002696")]
	[Address(RVA = "0xBED0C0", Offset = "0xBEC0C0", VA = "0x180BED0C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002697 RID: 9879 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002697")]
	[Address(RVA = "0xBED5A0", Offset = "0xBEC5A0", VA = "0x180BED5A0")]
	private void Update()
	{
	}

	// Token: 0x06002698 RID: 9880 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002698")]
	[Address(RVA = "0xBEDBF0", Offset = "0xBECBF0", VA = "0x180BEDBF0")]
	public void ToggleDrawingMode(ButtonController pressedButton)
	{
	}

	// Token: 0x06002699 RID: 9881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002699")]
	[Address(RVA = "0xBEDD60", Offset = "0xBECD60", VA = "0x180BEDD60")]
	public void OnChangeDrawingColour()
	{
	}

	// Token: 0x0600269A RID: 9882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600269A")]
	[Address(RVA = "0xBEDDC0", Offset = "0xBECDC0", VA = "0x180BEDDC0")]
	public void ToggleEraser(ButtonController pressedButton)
	{
	}

	// Token: 0x0600269B RID: 9883 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600269B")]
	[Address(RVA = "0xBEDED0", Offset = "0xBECED0", VA = "0x180BEDED0")]
	public void ClearDrawing(ButtonController pressedButton)
	{
	}

	// Token: 0x0600269C RID: 9884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600269C")]
	[Address(RVA = "0xBEDF00", Offset = "0xBECF00", VA = "0x180BEDF00")]
	public WindowExtraControlsController()
	{
	}

	// Token: 0x040030A8 RID: 12456
	[Token(Token = "0x40030A8")]
	[FieldOffset(Offset = "0x18")]
	public bool isOver;

	// Token: 0x040030A9 RID: 12457
	[Token(Token = "0x40030A9")]
	[FieldOffset(Offset = "0x1C")]
	public float fade;

	// Token: 0x040030AA RID: 12458
	[Token(Token = "0x40030AA")]
	[FieldOffset(Offset = "0x20")]
	public RawImage mouseOverDetector;

	// Token: 0x040030AB RID: 12459
	[Token(Token = "0x40030AB")]
	[FieldOffset(Offset = "0x28")]
	public bool drawingControlsEnabled;

	// Token: 0x040030AC RID: 12460
	[Token(Token = "0x40030AC")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform drawingControls;

	// Token: 0x040030AD RID: 12461
	[Token(Token = "0x40030AD")]
	[FieldOffset(Offset = "0x38")]
	public List<CanvasRenderer> drawingRenderers;

	// Token: 0x040030AE RID: 12462
	[Token(Token = "0x40030AE")]
	[FieldOffset(Offset = "0x40")]
	public DrawingController drawingController;

	// Token: 0x040030AF RID: 12463
	[Token(Token = "0x40030AF")]
	[FieldOffset(Offset = "0x48")]
	public ButtonController toggleDrawingButton;

	// Token: 0x040030B0 RID: 12464
	[Token(Token = "0x40030B0")]
	[FieldOffset(Offset = "0x50")]
	public ColourSelectorButtonController colourButton;

	// Token: 0x040030B1 RID: 12465
	[Token(Token = "0x40030B1")]
	[FieldOffset(Offset = "0x58")]
	public ButtonController eraserButton;

	// Token: 0x040030B2 RID: 12466
	[Token(Token = "0x40030B2")]
	[FieldOffset(Offset = "0x60")]
	public ButtonController clearButton;
}
