using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200061F RID: 1567
[Token(Token = "0x200061F")]
public class SalesLedgerEntryController : MonoBehaviour
{
	// Token: 0x06002264 RID: 8804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002264")]
	[Address(RVA = "0xB2F410", Offset = "0xB2E410", VA = "0x180B2F410")]
	public void Setup(Company.SalesRecord newRecord, SalesLedgerContentController newSalesLedger)
	{
	}

	// Token: 0x06002265 RID: 8805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002265")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public SalesLedgerEntryController()
	{
	}

	// Token: 0x04002C02 RID: 11266
	[Token(Token = "0x4002C02")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002C03 RID: 11267
	[Token(Token = "0x4002C03")]
	[FieldOffset(Offset = "0x20")]
	public SalesLedgerContentController salesLedger;

	// Token: 0x04002C04 RID: 11268
	[Token(Token = "0x4002C04")]
	[FieldOffset(Offset = "0x28")]
	public Company.SalesRecord salesRecord;

	// Token: 0x04002C05 RID: 11269
	[Token(Token = "0x4002C05")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI descriptionText;

	// Token: 0x04002C06 RID: 11270
	[Token(Token = "0x4002C06")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI timeText;

	// Token: 0x04002C07 RID: 11271
	[Token(Token = "0x4002C07")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI nameText;

	// Token: 0x04002C08 RID: 11272
	[Token(Token = "0x4002C08")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI priceText;
}
