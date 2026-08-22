using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005CC RID: 1484
[Token(Token = "0x20005CC")]
public class ApartmentItemElementController : MonoBehaviour
{
	// Token: 0x06002099 RID: 8345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002099")]
	[Address(RVA = "0xAE10E0", Offset = "0xAE00E0", VA = "0x180AE10E0")]
	public void SetupItem(InteractablePreset newItemPreset, ApartmentItemsController newDecorController, InfoWindow newThisWindow, Interactable newWorldItemReference)
	{
	}

	// Token: 0x0600209A RID: 8346 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600209A")]
	[Address(RVA = "0xAE1620", Offset = "0xAE0620", VA = "0x180AE1620")]
	public void VisualUpdate()
	{
	}

	// Token: 0x0600209B RID: 8347 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600209B")]
	[Address(RVA = "0xAE1640", Offset = "0xAE0640", VA = "0x180AE1640")]
	public void UpdateButtonText()
	{
	}

	// Token: 0x0600209C RID: 8348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600209C")]
	[Address(RVA = "0xAE1F40", Offset = "0xAE0F40", VA = "0x180AE1F40")]
	public void OnPlaceButton()
	{
	}

	// Token: 0x0600209D RID: 8349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600209D")]
	[Address(RVA = "0xAE2690", Offset = "0xAE1690", VA = "0x180AE2690")]
	public void PurchaseConfirm()
	{
	}

	// Token: 0x0600209E RID: 8350 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600209E")]
	[Address(RVA = "0xAE2F50", Offset = "0xAE1F50", VA = "0x180AE2F50")]
	public void PurchaseCancel()
	{
	}

	// Token: 0x0600209F RID: 8351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600209F")]
	[Address(RVA = "0xAE30B0", Offset = "0xAE20B0", VA = "0x180AE30B0")]
	public void OnStorageButton()
	{
	}

	// Token: 0x060020A0 RID: 8352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020A0")]
	[Address(RVA = "0xAE3120", Offset = "0xAE2120", VA = "0x180AE3120")]
	public void OnSellButton()
	{
	}

	// Token: 0x060020A1 RID: 8353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020A1")]
	[Address(RVA = "0xAE3190", Offset = "0xAE2190", VA = "0x180AE3190")]
	public void UpdatePurchaseAbility()
	{
	}

	// Token: 0x060020A2 RID: 8354 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020A2")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ApartmentItemElementController()
	{
	}

	// Token: 0x04002A29 RID: 10793
	[Token(Token = "0x4002A29")]
	[FieldOffset(Offset = "0x18")]
	public InteractablePreset itemPreset;

	// Token: 0x04002A2A RID: 10794
	[Token(Token = "0x4002A2A")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI nameText;

	// Token: 0x04002A2B RID: 10795
	[Token(Token = "0x4002A2B")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI priceText;

	// Token: 0x04002A2C RID: 10796
	[Token(Token = "0x4002A2C")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI sellText;

	// Token: 0x04002A2D RID: 10797
	[Token(Token = "0x4002A2D")]
	[FieldOffset(Offset = "0x38")]
	public InfoWindow thisWindow;

	// Token: 0x04002A2E RID: 10798
	[Token(Token = "0x4002A2E")]
	[FieldOffset(Offset = "0x40")]
	public DecorController decorController;

	// Token: 0x04002A2F RID: 10799
	[Token(Token = "0x4002A2F")]
	[FieldOffset(Offset = "0x48")]
	public ApartmentItemsController itemsController;

	// Token: 0x04002A30 RID: 10800
	[Token(Token = "0x4002A30")]
	[FieldOffset(Offset = "0x50")]
	public Image mainImage;

	// Token: 0x04002A31 RID: 10801
	[Token(Token = "0x4002A31")]
	[FieldOffset(Offset = "0x58")]
	[NonSerialized]
	public Interactable worldItemReference;

	// Token: 0x04002A32 RID: 10802
	[Token(Token = "0x4002A32")]
	[FieldOffset(Offset = "0x60")]
	public ButtonController placeButton;

	// Token: 0x04002A33 RID: 10803
	[Token(Token = "0x4002A33")]
	[FieldOffset(Offset = "0x68")]
	public ButtonController storageButton;

	// Token: 0x04002A34 RID: 10804
	[Token(Token = "0x4002A34")]
	[FieldOffset(Offset = "0x70")]
	public ButtonController sellButton;

	// Token: 0x04002A35 RID: 10805
	[Token(Token = "0x4002A35")]
	[FieldOffset(Offset = "0x78")]
	public Image icon;

	// Token: 0x04002A36 RID: 10806
	[Token(Token = "0x4002A36")]
	[FieldOffset(Offset = "0x80")]
	public int price;

	// Token: 0x020005CD RID: 1485
	[Token(Token = "0x20005CD")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060020A4 RID: 8356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x0000DF98 File Offset: 0x0000C198
		[Token(Token = "0x60020A5")]
		[Address(RVA = "0xAE35F0", Offset = "0xAE25F0", VA = "0x180AE35F0")]
		internal bool <UpdateButtonText>b__16_0(InteractableActionsPreset item)
		{
			return default(bool);
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		[Token(Token = "0x60020A6")]
		[Address(RVA = "0xAE3790", Offset = "0xAE2790", VA = "0x180AE3790")]
		internal bool <UpdateButtonText>b__16_1(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x04002A37 RID: 10807
		[Token(Token = "0x4002A37")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ApartmentItemElementController.<>c <>9;

		// Token: 0x04002A38 RID: 10808
		[Token(Token = "0x4002A38")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__16_1;

		// Token: 0x04002A39 RID: 10809
		[Token(Token = "0x4002A39")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<InteractableActionsPreset> <>9__16_0;
	}
}
