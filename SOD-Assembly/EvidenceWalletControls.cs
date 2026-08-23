using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020005F6 RID: 1526
[Token(Token = "0x20005F6")]
public class EvidenceWalletControls : MonoBehaviour
{
	// Token: 0x0600216E RID: 8558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600216E")]
	[Address(RVA = "0xB071E0", Offset = "0xB061E0", VA = "0x180B071E0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600216F RID: 8559 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600216F")]
	[Address(RVA = "0xB07430", Offset = "0xB06430", VA = "0x180B07430")]
	private void OnDisable()
	{
	}

	// Token: 0x06002170 RID: 8560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002170")]
	[Address(RVA = "0xB07670", Offset = "0xB06670", VA = "0x180B07670")]
	public void CheckEnabled()
	{
	}

	// Token: 0x06002171 RID: 8561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002171")]
	[Address(RVA = "0xB07D40", Offset = "0xB06D40", VA = "0x180B07D40")]
	public void VisualUpdate(int walletIndex)
	{
	}

	// Token: 0x06002172 RID: 8562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002172")]
	[Address(RVA = "0xB08580", Offset = "0xB07580", VA = "0x180B08580")]
	public void OnButtonPress()
	{
	}

	// Token: 0x06002173 RID: 8563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002173")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public EvidenceWalletControls()
	{
	}

	// Token: 0x04002B22 RID: 11042
	[Token(Token = "0x4002B22")]
	[FieldOffset(Offset = "0x18")]
	public InfoWindow parentWindow;

	// Token: 0x04002B23 RID: 11043
	[Token(Token = "0x4002B23")]
	[FieldOffset(Offset = "0x20")]
	public Sprite moneySprite;

	// Token: 0x04002B24 RID: 11044
	[Token(Token = "0x4002B24")]
	[FieldOffset(Offset = "0x28")]
	public Sprite cardSprite;

	// Token: 0x04002B25 RID: 11045
	[Token(Token = "0x4002B25")]
	[FieldOffset(Offset = "0x30")]
	public Sprite keySprite;

	// Token: 0x04002B26 RID: 11046
	[Token(Token = "0x4002B26")]
	[FieldOffset(Offset = "0x0")]
	public static List<EvidenceWalletControls> allItems;

	// Token: 0x04002B27 RID: 11047
	[Token(Token = "0x4002B27")]
	[FieldOffset(Offset = "0x38")]
	public ButtonController button;

	// Token: 0x04002B28 RID: 11048
	[Token(Token = "0x4002B28")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI buttonText;

	// Token: 0x04002B29 RID: 11049
	[Token(Token = "0x4002B29")]
	[FieldOffset(Offset = "0x48")]
	[NonSerialized]
	public Human.WalletItem itemRef;
}
