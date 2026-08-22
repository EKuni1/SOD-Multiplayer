using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000660 RID: 1632
[Token(Token = "0x2000660")]
public class InventorySquareController : ButtonController
{
	// Token: 0x0600240B RID: 9227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600240B")]
	[Address(RVA = "0xB7ED30", Offset = "0xB7DD30", VA = "0x180B7ED30")]
	public void Setup(FirstPersonItemController.InventorySlot newSlot)
	{
	}

	// Token: 0x0600240C RID: 9228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600240C")]
	[Address(RVA = "0xB7F290", Offset = "0xB7E290", VA = "0x180B7F290")]
	public void OnUpdateContent()
	{
	}

	// Token: 0x0600240D RID: 9229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600240D")]
	[Address(RVA = "0xB7FC40", Offset = "0xB7EC40", VA = "0x180B7FC40")]
	public void UpdateHotkeyDisplay()
	{
	}

	// Token: 0x0600240E RID: 9230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600240E")]
	[Address(RVA = "0xB7FC50", Offset = "0xB7EC50", VA = "0x180B7FC50", Slot = "25")]
	public override void OnHoverStart()
	{
	}

	// Token: 0x0600240F RID: 9231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600240F")]
	[Address(RVA = "0xB7FCB0", Offset = "0xB7ECB0", VA = "0x180B7FCB0", Slot = "26")]
	public override void OnHoverEnd()
	{
	}

	// Token: 0x06002410 RID: 9232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002410")]
	[Address(RVA = "0xB7FD50", Offset = "0xB7ED50", VA = "0x180B7FD50", Slot = "17")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x06002411 RID: 9233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002411")]
	[Address(RVA = "0xB7FE10", Offset = "0xB7EE10", VA = "0x180B7FE10", Slot = "18")]
	public override void OnRightClick()
	{
	}

	// Token: 0x06002412 RID: 9234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002412")]
	[Address(RVA = "0xB7FFC0", Offset = "0xB7EFC0", VA = "0x180B7FFC0")]
	public InventorySquareController()
	{
	}

	// Token: 0x04002E14 RID: 11796
	[Token(Token = "0x4002E14")]
	[FieldOffset(Offset = "0x1A8")]
	public List<CanvasRenderer> renderers;

	// Token: 0x04002E15 RID: 11797
	[Token(Token = "0x4002E15")]
	[FieldOffset(Offset = "0x1B0")]
	public FirstPersonItemController.InventorySlot slot;

	// Token: 0x04002E16 RID: 11798
	[Token(Token = "0x4002E16")]
	[FieldOffset(Offset = "0x1B8")]
	public RectTransform stolenIcon;

	// Token: 0x04002E17 RID: 11799
	[Token(Token = "0x4002E17")]
	[FieldOffset(Offset = "0x1C0")]
	public RectTransform equipmentIcon;

	// Token: 0x04002E18 RID: 11800
	[Token(Token = "0x4002E18")]
	[FieldOffset(Offset = "0x1C8")]
	public RectTransform selected;

	// Token: 0x02000661 RID: 1633
	[Token(Token = "0x2000661")]
	private sealed class <>c__DisplayClass6_0
	{
		// Token: 0x06002413 RID: 9235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002413")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x0000E790 File Offset: 0x0000C990
		[Token(Token = "0x6002414")]
		[Address(RVA = "0x70EAC0", Offset = "0x70DAC0", VA = "0x18070EAC0")]
		internal bool <OnUpdateContent>b__0(StatusController.FineRecord item)
		{
			return default(bool);
		}

		// Token: 0x04002E19 RID: 11801
		[Token(Token = "0x4002E19")]
		[FieldOffset(Offset = "0x10")]
		public Interactable slotInteractable;
	}
}
