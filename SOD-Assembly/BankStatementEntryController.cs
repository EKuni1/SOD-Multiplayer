using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020005D3 RID: 1491
[Token(Token = "0x20005D3")]
public class BankStatementEntryController : MonoBehaviour
{
	// Token: 0x060020B7 RID: 8375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020B7")]
	[Address(RVA = "0xAE7C80", Offset = "0xAE6C80", VA = "0x180AE7C80")]
	public void Setup(string text, int amount, int balance)
	{
	}

	// Token: 0x060020B8 RID: 8376 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020B8")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public BankStatementEntryController()
	{
	}

	// Token: 0x04002A4B RID: 10827
	[Token(Token = "0x4002A4B")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002A4C RID: 10828
	[Token(Token = "0x4002A4C")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI descriptionText;

	// Token: 0x04002A4D RID: 10829
	[Token(Token = "0x4002A4D")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI amountText;

	// Token: 0x04002A4E RID: 10830
	[Token(Token = "0x4002A4E")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI balanceText;
}
