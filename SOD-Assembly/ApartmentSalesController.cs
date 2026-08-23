using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005CE RID: 1486
[Token(Token = "0x20005CE")]
public class ApartmentSalesController : MonoBehaviour
{
	// Token: 0x060020A7 RID: 8359 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020A7")]
	[Address(RVA = "0xAE3820", Offset = "0xAE2820", VA = "0x180AE3820")]
	private void OnEnable()
	{
	}

	// Token: 0x060020A8 RID: 8360 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020A8")]
	[Address(RVA = "0xAE3C10", Offset = "0xAE2C10", VA = "0x180AE3C10")]
	private void OnDisable()
	{
	}

	// Token: 0x060020A9 RID: 8361 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020A9")]
	[Address(RVA = "0xAE3E50", Offset = "0xAE2E50", VA = "0x180AE3E50")]
	public void UpdateDetails()
	{
	}

	// Token: 0x060020AA RID: 8362 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020AA")]
	[Address(RVA = "0xAE4590", Offset = "0xAE3590", VA = "0x180AE4590")]
	public void OnPurchaseButton()
	{
	}

	// Token: 0x060020AB RID: 8363 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020AB")]
	[Address(RVA = "0xAE4E00", Offset = "0xAE3E00", VA = "0x180AE4E00")]
	public void ConfirmApartmentPurchase()
	{
	}

	// Token: 0x060020AC RID: 8364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020AC")]
	[Address(RVA = "0xAE5B10", Offset = "0xAE4B10", VA = "0x180AE5B10")]
	public void CancelApartmentPurchase()
	{
	}

	// Token: 0x060020AD RID: 8365 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020AD")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ApartmentSalesController()
	{
	}

	// Token: 0x04002A3A RID: 10810
	[Token(Token = "0x4002A3A")]
	[FieldOffset(Offset = "0x18")]
	public WindowContentController windowContent;

	// Token: 0x04002A3B RID: 10811
	[Token(Token = "0x4002A3B")]
	[FieldOffset(Offset = "0x20")]
	public InfoWindow parentWindow;

	// Token: 0x04002A3C RID: 10812
	[Token(Token = "0x4002A3C")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI dataText;

	// Token: 0x04002A3D RID: 10813
	[Token(Token = "0x4002A3D")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI descriptionText;

	// Token: 0x04002A3E RID: 10814
	[Token(Token = "0x4002A3E")]
	[FieldOffset(Offset = "0x38")]
	public ButtonController purchaseButton;

	// Token: 0x04002A3F RID: 10815
	[Token(Token = "0x4002A3F")]
	[FieldOffset(Offset = "0x40")]
	public RawImage img;
}
