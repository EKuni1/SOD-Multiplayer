using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000686 RID: 1670
[Token(Token = "0x2000686")]
public class PhoneNumberEntryController : MonoBehaviour
{
	// Token: 0x06002501 RID: 9473 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002501")]
	[Address(RVA = "0xBAD730", Offset = "0xBAC730", VA = "0x180BAD730")]
	public void Setup(GameplayController.PhoneNumber newNumber)
	{
	}

	// Token: 0x06002502 RID: 9474 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002502")]
	[Address(RVA = "0xBADBB0", Offset = "0xBACBB0", VA = "0x180BADBB0")]
	public void VisualUpdate()
	{
	}

	// Token: 0x06002503 RID: 9475 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002503")]
	[Address(RVA = "0xBAE3F0", Offset = "0xBAD3F0", VA = "0x180BAE3F0")]
	public void ActiveCodeInputCheck(KeypadController keypad)
	{
	}

	// Token: 0x06002504 RID: 9476 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002504")]
	[Address(RVA = "0xBAE5F0", Offset = "0xBAD5F0", VA = "0x180BAE5F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002505 RID: 9477 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002505")]
	[Address(RVA = "0xBAEA90", Offset = "0xBADA90", VA = "0x180BAEA90")]
	public void OpenLocation()
	{
	}

	// Token: 0x06002506 RID: 9478 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002506")]
	[Address(RVA = "0xBAEB80", Offset = "0xBADB80", VA = "0x180BAEB80")]
	public void OpenEvidence()
	{
	}

	// Token: 0x06002507 RID: 9479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002507")]
	[Address(RVA = "0xBAEC70", Offset = "0xBADC70", VA = "0x180BAEC70")]
	public void EnterCode()
	{
	}

	// Token: 0x06002508 RID: 9480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002508")]
	[Address(RVA = "0xBAF180", Offset = "0xBAE180", VA = "0x180BAF180")]
	public PhoneNumberEntryController()
	{
	}

	// Token: 0x04002F21 RID: 12065
	[Token(Token = "0x4002F21")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002F22 RID: 12066
	[Token(Token = "0x4002F22")]
	[FieldOffset(Offset = "0x20")]
	public Telephone telephone;

	// Token: 0x04002F23 RID: 12067
	[Token(Token = "0x4002F23")]
	[FieldOffset(Offset = "0x28")]
	public GameplayController.PhoneNumber number;

	// Token: 0x04002F24 RID: 12068
	[Token(Token = "0x4002F24")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI text;

	// Token: 0x04002F25 RID: 12069
	[Token(Token = "0x4002F25")]
	[FieldOffset(Offset = "0x38")]
	public ButtonController openLocationButton;

	// Token: 0x04002F26 RID: 12070
	[Token(Token = "0x4002F26")]
	[FieldOffset(Offset = "0x40")]
	public ButtonController openEvidenceButton;

	// Token: 0x04002F27 RID: 12071
	[Token(Token = "0x4002F27")]
	[FieldOffset(Offset = "0x48")]
	public ButtonController enterCodeButton;

	// Token: 0x04002F28 RID: 12072
	[Token(Token = "0x4002F28")]
	[FieldOffset(Offset = "0x50")]
	public Image icon;

	// Token: 0x04002F29 RID: 12073
	[Token(Token = "0x4002F29")]
	[FieldOffset(Offset = "0x58")]
	public string nameString;

	// Token: 0x04002F2A RID: 12074
	[Token(Token = "0x4002F2A")]
	[FieldOffset(Offset = "0x60")]
	public string passcodeString;

	// Token: 0x04002F2B RID: 12075
	[Token(Token = "0x4002F2B")]
	[FieldOffset(Offset = "0x68")]
	private List<Human> citizenSubscriptions;
}
