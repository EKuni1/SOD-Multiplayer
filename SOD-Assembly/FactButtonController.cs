using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005F7 RID: 1527
[Token(Token = "0x20005F7")]
public class FactButtonController : ButtonController
{
	// Token: 0x06002175 RID: 8565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002175")]
	[Address(RVA = "0xB09310", Offset = "0xB08310", VA = "0x180B09310")]
	public void Setup(Evidence.FactLink newFactLink, InfoWindow newParentWindow)
	{
	}

	// Token: 0x06002176 RID: 8566 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002176")]
	[Address(RVA = "0xB098A0", Offset = "0xB088A0", VA = "0x180B098A0")]
	public void OnSeen()
	{
	}

	// Token: 0x06002177 RID: 8567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002177")]
	[Address(RVA = "0xB09960", Offset = "0xB08960", VA = "0x180B09960")]
	public void ToggleHidden(ButtonController thisButton)
	{
	}

	// Token: 0x06002178 RID: 8568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002178")]
	[Address(RVA = "0xB09A10", Offset = "0xB08A10", VA = "0x180B09A10")]
	private void OnEnable()
	{
	}

	// Token: 0x06002179 RID: 8569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002179")]
	[Address(RVA = "0xB09A30", Offset = "0xB08A30", VA = "0x180B09A30")]
	private void OnDisable()
	{
	}

	// Token: 0x0600217A RID: 8570 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600217A")]
	[Address(RVA = "0xB09A80", Offset = "0xB08A80", VA = "0x180B09A80")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600217B RID: 8571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600217B")]
	[Address(RVA = "0xB09E30", Offset = "0xB08E30", VA = "0x180B09E30", Slot = "10")]
	public override void VisualUpdate()
	{
	}

	// Token: 0x0600217C RID: 8572 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600217C")]
	[Address(RVA = "0xB0AEB0", Offset = "0xB09EB0", VA = "0x180B0AEB0", Slot = "17")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x0600217D RID: 8573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600217D")]
	[Address(RVA = "0xB0B5F0", Offset = "0xB0A5F0", VA = "0x180B0B5F0", Slot = "12")]
	public override void UpdateTooltipText()
	{
	}

	// Token: 0x0600217E RID: 8574 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600217E")]
	[Address(RVA = "0xB0B8D0", Offset = "0xB0A8D0", VA = "0x180B0B8D0", Slot = "25")]
	public override void OnHoverStart()
	{
	}

	// Token: 0x0600217F RID: 8575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600217F")]
	[Address(RVA = "0xB0B8E0", Offset = "0xB0A8E0", VA = "0x180B0B8E0", Slot = "26")]
	public override void OnHoverEnd()
	{
	}

	// Token: 0x06002180 RID: 8576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002180")]
	[Address(RVA = "0xB0B8F0", Offset = "0xB0A8F0", VA = "0x180B0B8F0")]
	public void UpdatePulsate(ButtonController hoveredButton, bool mouseOver)
	{
	}

	// Token: 0x06002181 RID: 8577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002181")]
	[Address(RVA = "0xB0BC20", Offset = "0xB0AC20", VA = "0x180B0BC20")]
	public FactButtonController()
	{
	}

	// Token: 0x04002B2A RID: 11050
	[Token(Token = "0x4002B2A")]
	[FieldOffset(Offset = "0x1A8")]
	public Evidence.FactLink link;

	// Token: 0x04002B2B RID: 11051
	[Token(Token = "0x4002B2B")]
	[FieldOffset(Offset = "0x1B0")]
	public Fact fact;

	// Token: 0x04002B2C RID: 11052
	[Token(Token = "0x4002B2C")]
	[FieldOffset(Offset = "0x1B8")]
	public ButtonController toggleHiddenButton;

	// Token: 0x04002B2D RID: 11053
	[Token(Token = "0x4002B2D")]
	[FieldOffset(Offset = "0x1C0")]
	public Image parentToThisIcon;

	// Token: 0x04002B2E RID: 11054
	[Token(Token = "0x4002B2E")]
	[FieldOffset(Offset = "0x1C8")]
	public Image childOfThisIcon;

	// Token: 0x04002B2F RID: 11055
	[Token(Token = "0x4002B2F")]
	[FieldOffset(Offset = "0x1D0")]
	public Sprite shownConnection;

	// Token: 0x04002B30 RID: 11056
	[Token(Token = "0x4002B30")]
	[FieldOffset(Offset = "0x1D8")]
	public Sprite hiddenConnection;

	// Token: 0x04002B31 RID: 11057
	[Token(Token = "0x4002B31")]
	[FieldOffset(Offset = "0x1E0")]
	public Color shownColor;

	// Token: 0x04002B32 RID: 11058
	[Token(Token = "0x4002B32")]
	[FieldOffset(Offset = "0x1F0")]
	public Color hiddenColor;

	// Token: 0x04002B33 RID: 11059
	[Token(Token = "0x4002B33")]
	[FieldOffset(Offset = "0x200")]
	public RectTransform isSeenIcon;

	// Token: 0x04002B34 RID: 11060
	[Token(Token = "0x4002B34")]
	[FieldOffset(Offset = "0x208")]
	private bool isSetup;

	// Token: 0x04002B35 RID: 11061
	[Token(Token = "0x4002B35")]
	[FieldOffset(Offset = "0x209")]
	private bool enabledFirstTime;

	// Token: 0x04002B36 RID: 11062
	[Token(Token = "0x4002B36")]
	[FieldOffset(Offset = "0x20A")]
	public bool inSlot;
}
