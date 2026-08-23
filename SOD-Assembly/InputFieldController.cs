using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000601 RID: 1537
[Token(Token = "0x2000601")]
public class InputFieldController : MonoBehaviour
{
	// Token: 0x060021DB RID: 8667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021DB")]
	[Address(RVA = "0xB1A070", Offset = "0xB19070", VA = "0x180B1A070")]
	public void Setup(Case.ResolveQuestion newQuestion, Case newCase, bool newResultsMode = false)
	{
	}

	// Token: 0x060021DC RID: 8668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021DC")]
	[Address(RVA = "0xB1B2D0", Offset = "0xB1A2D0", VA = "0x180B1B2D0")]
	public void ProgressChange(Case.ResolveQuestion q)
	{
	}

	// Token: 0x060021DD RID: 8669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021DD")]
	[Address(RVA = "0xB1B3A0", Offset = "0xB1A3A0", VA = "0x180B1B3A0")]
	public void OpenTextInputButton()
	{
	}

	// Token: 0x060021DE RID: 8670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021DE")]
	[Address(RVA = "0xB1B710", Offset = "0xB1A710", VA = "0x180B1B710")]
	public void OnInputTextPopupCancel()
	{
	}

	// Token: 0x060021DF RID: 8671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021DF")]
	[Address(RVA = "0xB1B870", Offset = "0xB1A870", VA = "0x180B1B870")]
	public void OnInputTextPopupConfirm()
	{
	}

	// Token: 0x060021E0 RID: 8672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021E0")]
	[Address(RVA = "0xB1BA50", Offset = "0xB1AA50", VA = "0x180B1BA50")]
	private void OnDestroy()
	{
	}

	// Token: 0x060021E1 RID: 8673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021E1")]
	[Address(RVA = "0xB1BC20", Offset = "0xB1AC20", VA = "0x180B1BC20")]
	public void OnInputEdited()
	{
	}

	// Token: 0x060021E2 RID: 8674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021E2")]
	[Address(RVA = "0xB1BF60", Offset = "0xB1AF60", VA = "0x180B1BF60")]
	public void UpdateCheckbox()
	{
	}

	// Token: 0x060021E3 RID: 8675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021E3")]
	[Address(RVA = "0xB1BFF0", Offset = "0xB1AFF0", VA = "0x180B1BFF0")]
	public void OnSelectButton()
	{
	}

	// Token: 0x060021E4 RID: 8676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021E4")]
	[Address(RVA = "0xB1C060", Offset = "0xB1B060", VA = "0x180B1C060")]
	public void SetSelectedEvidence(Evidence newI)
	{
	}

	// Token: 0x060021E5 RID: 8677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021E5")]
	[Address(RVA = "0xB1C450", Offset = "0xB1B450", VA = "0x180B1C450")]
	public void OnPick(Evidence newSelection, List<Evidence.DataKey> keys)
	{
	}

	// Token: 0x060021E6 RID: 8678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021E6")]
	[Address(RVA = "0xB1C710", Offset = "0xB1B710", VA = "0x180B1C710")]
	public InputFieldController()
	{
	}

	// Token: 0x04002B8E RID: 11150
	[Token(Token = "0x4002B8E")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002B8F RID: 11151
	[Token(Token = "0x4002B8F")]
	[FieldOffset(Offset = "0x20")]
	public ButtonController inputNameButton;

	// Token: 0x04002B90 RID: 11152
	[Token(Token = "0x4002B90")]
	[FieldOffset(Offset = "0x28")]
	public ButtonController selectButton;

	// Token: 0x04002B91 RID: 11153
	[Token(Token = "0x4002B91")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI titleText;

	// Token: 0x04002B92 RID: 11154
	[Token(Token = "0x4002B92")]
	[FieldOffset(Offset = "0x38")]
	public Image checkbox;

	// Token: 0x04002B93 RID: 11155
	[Token(Token = "0x4002B93")]
	[FieldOffset(Offset = "0x40")]
	public Sprite tickSprite;

	// Token: 0x04002B94 RID: 11156
	[Token(Token = "0x4002B94")]
	[FieldOffset(Offset = "0x48")]
	public Sprite crossSprite;

	// Token: 0x04002B95 RID: 11157
	[Token(Token = "0x4002B95")]
	[FieldOffset(Offset = "0x50")]
	public Sprite emptySprite;

	// Token: 0x04002B96 RID: 11158
	[Token(Token = "0x4002B96")]
	[FieldOffset(Offset = "0x58")]
	public ProgressBarController progress;

	// Token: 0x04002B97 RID: 11159
	[Token(Token = "0x4002B97")]
	[FieldOffset(Offset = "0x60")]
	public RectTransform rewardedGraphic;

	// Token: 0x04002B98 RID: 11160
	[Token(Token = "0x4002B98")]
	[FieldOffset(Offset = "0x68")]
	public bool resultsMode;

	// Token: 0x04002B99 RID: 11161
	[Token(Token = "0x4002B99")]
	[FieldOffset(Offset = "0x70")]
	public Case belongsToCase;

	// Token: 0x04002B9A RID: 11162
	[Token(Token = "0x4002B9A")]
	[FieldOffset(Offset = "0x78")]
	public Case.ResolveQuestion question;

	// Token: 0x04002B9B RID: 11163
	[Token(Token = "0x4002B9B")]
	[FieldOffset(Offset = "0x80")]
	[NonSerialized]
	public Evidence inputtedEvidence;

	// Token: 0x04002B9C RID: 11164
	[Token(Token = "0x4002B9C")]
	[FieldOffset(Offset = "0x88")]
	public Color invalidInputColor;

	// Token: 0x04002B9D RID: 11165
	[Token(Token = "0x4002B9D")]
	[FieldOffset(Offset = "0x98")]
	public Color validInputColor;

	// Token: 0x02000602 RID: 1538
	[Token(Token = "0x2000602")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x060021E7 RID: 8679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x0000E148 File Offset: 0x0000C348
		[Token(Token = "0x60021E8")]
		[Address(RVA = "0xB1C780", Offset = "0xB1B780", VA = "0x180B1C780")]
		internal bool <Setup>b__0(Citizen item)
		{
			return default(bool);
		}

		// Token: 0x04002B9E RID: 11166
		[Token(Token = "0x4002B9E")]
		[FieldOffset(Offset = "0x10")]
		public int number;
	}

	// Token: 0x02000603 RID: 1539
	[Token(Token = "0x2000603")]
	private sealed class <>c__DisplayClass16_1
	{
		// Token: 0x060021E9 RID: 8681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass16_1()
		{
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x0000E160 File Offset: 0x0000C360
		[Token(Token = "0x60021EA")]
		[Address(RVA = "0xB1C7A0", Offset = "0xB1B7A0", VA = "0x180B1C7A0")]
		internal bool <Setup>b__1(NewGameLocation item)
		{
			return default(bool);
		}

		// Token: 0x04002B9F RID: 11167
		[Token(Token = "0x4002B9F")]
		[FieldOffset(Offset = "0x10")]
		public int number;
	}
}
