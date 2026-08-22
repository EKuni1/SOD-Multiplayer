using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200068A RID: 1674
[Token(Token = "0x200068A")]
public class ResolveOptionsController : MonoBehaviour
{
	// Token: 0x06002520 RID: 9504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002520")]
	[Address(RVA = "0xBB3B90", Offset = "0xBB2B90", VA = "0x180BB3B90")]
	public void Setup(WindowContentController newContentController)
	{
	}

	// Token: 0x06002521 RID: 9505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002521")]
	[Address(RVA = "0xBB41D0", Offset = "0xBB31D0", VA = "0x180BB41D0")]
	private void OnEnable()
	{
	}

	// Token: 0x06002522 RID: 9506 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002522")]
	[Address(RVA = "0xBB4600", Offset = "0xBB3600", VA = "0x180BB4600")]
	public void HelpButton()
	{
	}

	// Token: 0x06002523 RID: 9507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002523")]
	[Address(RVA = "0xBB46C0", Offset = "0xBB36C0", VA = "0x180BB46C0")]
	public void OpenJobPostButton()
	{
	}

	// Token: 0x06002524 RID: 9508 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002524")]
	[Address(RVA = "0xBB4910", Offset = "0xBB3910", VA = "0x180BB4910")]
	public void SubmitCaseButton()
	{
	}

	// Token: 0x06002525 RID: 9509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002525")]
	[Address(RVA = "0xBB4B50", Offset = "0xBB3B50", VA = "0x180BB4B50")]
	public void CloseCaseButton()
	{
	}

	// Token: 0x06002526 RID: 9510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002526")]
	[Address(RVA = "0xBB4C90", Offset = "0xBB3C90", VA = "0x180BB4C90")]
	public void SetPageSize(Vector2 newSize)
	{
	}

	// Token: 0x06002527 RID: 9511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002527")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ResolveOptionsController()
	{
	}

	// Token: 0x04002F47 RID: 12103
	[Token(Token = "0x4002F47")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002F48 RID: 12104
	[Token(Token = "0x4002F48")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform pageRect;

	// Token: 0x04002F49 RID: 12105
	[Token(Token = "0x4002F49")]
	[FieldOffset(Offset = "0x28")]
	public WindowContentController wcc;

	// Token: 0x04002F4A RID: 12106
	[Token(Token = "0x4002F4A")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI titleText;

	// Token: 0x04002F4B RID: 12107
	[Token(Token = "0x4002F4B")]
	[FieldOffset(Offset = "0x38")]
	public ButtonController submitButton;

	// Token: 0x04002F4C RID: 12108
	[Token(Token = "0x4002F4C")]
	[FieldOffset(Offset = "0x40")]
	public ButtonController openJobPostButton;
}
