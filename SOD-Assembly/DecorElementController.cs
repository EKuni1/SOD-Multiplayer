using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005EF RID: 1519
[Token(Token = "0x20005EF")]
public class DecorElementController : MonoBehaviour
{
	// Token: 0x0600213B RID: 8507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600213B")]
	[Address(RVA = "0xAFC250", Offset = "0xAFB250", VA = "0x180AFC250")]
	public void Setup(MaterialGroupPreset newPreset, DecorController newDecorController, InfoWindow newThisWindow)
	{
	}

	// Token: 0x0600213C RID: 8508 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600213C")]
	[Address(RVA = "0xAFC4E0", Offset = "0xAFB4E0", VA = "0x180AFC4E0")]
	private Texture2D GenerateDecorIcon(int size = 128)
	{
		return null;
	}

	// Token: 0x0600213D RID: 8509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600213D")]
	[Address(RVA = "0xAFC6D0", Offset = "0xAFB6D0", VA = "0x180AFC6D0")]
	public void SetupFurniture(FurniturePreset newFurniture, FurnishingsController newDecorController, InfoWindow newThisWindow, FurnitureLocation newWorldFurnReference)
	{
	}

	// Token: 0x0600213E RID: 8510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600213E")]
	[Address(RVA = "0xAFCCD0", Offset = "0xAFBCD0", VA = "0x180AFCCD0")]
	public void VisualUpdate()
	{
	}

	// Token: 0x0600213F RID: 8511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600213F")]
	[Address(RVA = "0xAFCCF0", Offset = "0xAFBCF0", VA = "0x180AFCCF0")]
	public void UpdateButtonText()
	{
	}

	// Token: 0x06002140 RID: 8512 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002140")]
	[Address(RVA = "0xAFD490", Offset = "0xAFC490", VA = "0x180AFD490")]
	public void OnPlaceButton()
	{
	}

	// Token: 0x06002141 RID: 8513 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002141")]
	[Address(RVA = "0xAFD9D0", Offset = "0xAFC9D0", VA = "0x180AFD9D0")]
	public void OnStorageButton()
	{
	}

	// Token: 0x06002142 RID: 8514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002142")]
	[Address(RVA = "0xAFDA40", Offset = "0xAFCA40", VA = "0x180AFDA40")]
	public void OnSellButton()
	{
	}

	// Token: 0x06002143 RID: 8515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002143")]
	[Address(RVA = "0xAFDAB0", Offset = "0xAFCAB0", VA = "0x180AFDAB0")]
	public void UpdatePurchaseAbility()
	{
	}

	// Token: 0x06002144 RID: 8516 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002144")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public DecorElementController()
	{
	}

	// Token: 0x04002AE7 RID: 10983
	[Token(Token = "0x4002AE7")]
	[FieldOffset(Offset = "0x18")]
	public MaterialGroupPreset preset;

	// Token: 0x04002AE8 RID: 10984
	[Token(Token = "0x4002AE8")]
	[FieldOffset(Offset = "0x20")]
	public FurniturePreset furniture;

	// Token: 0x04002AE9 RID: 10985
	[Token(Token = "0x4002AE9")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI nameText;

	// Token: 0x04002AEA RID: 10986
	[Token(Token = "0x4002AEA")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI priceText;

	// Token: 0x04002AEB RID: 10987
	[Token(Token = "0x4002AEB")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI sellText;

	// Token: 0x04002AEC RID: 10988
	[Token(Token = "0x4002AEC")]
	[FieldOffset(Offset = "0x40")]
	public InfoWindow thisWindow;

	// Token: 0x04002AED RID: 10989
	[Token(Token = "0x4002AED")]
	[FieldOffset(Offset = "0x48")]
	public DecorController decorController;

	// Token: 0x04002AEE RID: 10990
	[Token(Token = "0x4002AEE")]
	[FieldOffset(Offset = "0x50")]
	public FurnishingsController furnishingsController;

	// Token: 0x04002AEF RID: 10991
	[Token(Token = "0x4002AEF")]
	[FieldOffset(Offset = "0x58")]
	public Image mainImage;

	// Token: 0x04002AF0 RID: 10992
	[Token(Token = "0x4002AF0")]
	[FieldOffset(Offset = "0x60")]
	public FurnitureLocation worldFurnitureReference;

	// Token: 0x04002AF1 RID: 10993
	[Token(Token = "0x4002AF1")]
	[FieldOffset(Offset = "0x68")]
	public ButtonController placeButton;

	// Token: 0x04002AF2 RID: 10994
	[Token(Token = "0x4002AF2")]
	[FieldOffset(Offset = "0x70")]
	public ButtonController storageButton;

	// Token: 0x04002AF3 RID: 10995
	[Token(Token = "0x4002AF3")]
	[FieldOffset(Offset = "0x78")]
	public ButtonController sellButton;

	// Token: 0x04002AF4 RID: 10996
	[Token(Token = "0x4002AF4")]
	[FieldOffset(Offset = "0x80")]
	public Image icon;

	// Token: 0x04002AF5 RID: 10997
	[Token(Token = "0x4002AF5")]
	[FieldOffset(Offset = "0x88")]
	public Sprite chairIcon;

	// Token: 0x04002AF6 RID: 10998
	[Token(Token = "0x4002AF6")]
	[FieldOffset(Offset = "0x90")]
	public Sprite tableIcon;

	// Token: 0x04002AF7 RID: 10999
	[Token(Token = "0x4002AF7")]
	[FieldOffset(Offset = "0x98")]
	public Sprite unitIcon;

	// Token: 0x04002AF8 RID: 11000
	[Token(Token = "0x4002AF8")]
	[FieldOffset(Offset = "0xA0")]
	public Sprite electronicsIcon;

	// Token: 0x04002AF9 RID: 11001
	[Token(Token = "0x4002AF9")]
	[FieldOffset(Offset = "0xA8")]
	public Sprite structuralIcon;

	// Token: 0x04002AFA RID: 11002
	[Token(Token = "0x4002AFA")]
	[FieldOffset(Offset = "0xB0")]
	public Sprite decorationIcon;

	// Token: 0x04002AFB RID: 11003
	[Token(Token = "0x4002AFB")]
	[FieldOffset(Offset = "0xB8")]
	public Sprite miscIcon;

	// Token: 0x04002AFC RID: 11004
	[Token(Token = "0x4002AFC")]
	[FieldOffset(Offset = "0xC0")]
	public int price;
}
