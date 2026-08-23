using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine.UI;

// Token: 0x02000620 RID: 1568
[Token(Token = "0x2000620")]
public class ShopSelectButtonController : ButtonController
{
	// Token: 0x06002266 RID: 8806 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002266")]
	[Address(RVA = "0xB30330", Offset = "0xB2F330", VA = "0x180B30330")]
	public void Setup(InteractablePreset newPreset, int newPrice, BuyInterfaceController newBuyController, InfoWindow newThisWindow, [Optional] SyncDiskPreset newSyncDisk, bool newTemp = false, [Optional] Interactable newSellInteractable, bool newSellMode = false)
	{
	}

	// Token: 0x06002267 RID: 8807 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002267")]
	[Address(RVA = "0xB30550", Offset = "0xB2F550", VA = "0x180B30550", Slot = "11")]
	public override void UpdateButtonText()
	{
	}

	// Token: 0x06002268 RID: 8808 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002268")]
	[Address(RVA = "0xB30BA0", Offset = "0xB2FBA0", VA = "0x180B30BA0")]
	public void UpdateTooltip()
	{
	}

	// Token: 0x06002269 RID: 8809 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002269")]
	[Address(RVA = "0xB31450", Offset = "0xB30450", VA = "0x180B31450", Slot = "17")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x0600226A RID: 8810 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600226A")]
	[Address(RVA = "0xB31A50", Offset = "0xB30A50", VA = "0x180B31A50")]
	public void PurchaseExecute()
	{
	}

	// Token: 0x0600226B RID: 8811 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600226B")]
	[Address(RVA = "0xB32510", Offset = "0xB31510", VA = "0x180B32510")]
	public void SellExecute()
	{
	}

	// Token: 0x0600226C RID: 8812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600226C")]
	[Address(RVA = "0xB32B50", Offset = "0xB31B50", VA = "0x180B32B50")]
	public void Cancel()
	{
	}

	// Token: 0x0600226D RID: 8813 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600226D")]
	[Address(RVA = "0xB32D40", Offset = "0xB31D40", VA = "0x180B32D40")]
	public void UpdatePurchaseAbility()
	{
	}

	// Token: 0x0600226E RID: 8814 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600226E")]
	[Address(RVA = "0xA2C450", Offset = "0xA2B450", VA = "0x180A2C450")]
	public ShopSelectButtonController()
	{
	}

	// Token: 0x0600226F RID: 8815 RVA: 0x0000E298 File Offset: 0x0000C498
	[Token(Token = "0x600226F")]
	[Address(RVA = "0xB33070", Offset = "0xB32070", VA = "0x180B33070")]
	private bool <UpdateButtonText>b__12_0(StatusController.FineRecord item)
	{
		return default(bool);
	}

	// Token: 0x06002270 RID: 8816 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
	[Token(Token = "0x6002270")]
	[Address(RVA = "0xB330B0", Offset = "0xB320B0", VA = "0x180B330B0")]
	private bool <SellExecute>b__16_0(FirstPersonItemController.InventorySlot item)
	{
		return default(bool);
	}

	// Token: 0x06002271 RID: 8817 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
	[Token(Token = "0x6002271")]
	[Address(RVA = "0xB33070", Offset = "0xB32070", VA = "0x180B33070")]
	private bool <UpdatePurchaseAbility>b__18_0(StatusController.FineRecord item)
	{
		return default(bool);
	}

	// Token: 0x04002C09 RID: 11273
	[Token(Token = "0x4002C09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public InteractablePreset preset;

	// Token: 0x04002C0A RID: 11274
	[Token(Token = "0x4002C0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public Interactable sellInteractable;

	// Token: 0x04002C0B RID: 11275
	[Token(Token = "0x4002C0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public SyncDiskPreset syncDisk;

	// Token: 0x04002C0C RID: 11276
	[Token(Token = "0x4002C0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public int price;

	// Token: 0x04002C0D RID: 11277
	[Token(Token = "0x4002C0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public TextMeshProUGUI priceText;

	// Token: 0x04002C0E RID: 11278
	[Token(Token = "0x4002C0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public TextMeshProUGUI specialText;

	// Token: 0x04002C0F RID: 11279
	[Token(Token = "0x4002C0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public InfoWindow thisWindow;

	// Token: 0x04002C10 RID: 11280
	[Token(Token = "0x4002C10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public BuyInterfaceController buyController;

	// Token: 0x04002C11 RID: 11281
	[Token(Token = "0x4002C11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public Image mainImage;

	// Token: 0x04002C12 RID: 11282
	[Token(Token = "0x4002C12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public bool todayOnly;

	// Token: 0x04002C13 RID: 11283
	[Token(Token = "0x4002C13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
	public bool sellMode;
}
