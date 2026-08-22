using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200068B RID: 1675
[Token(Token = "0x200068B")]
public class ResultsController : MonoBehaviour
{
	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06002528 RID: 9512 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700012D")]
	public static ResultsController Instance
	{
		[Token(Token = "0x6002528")]
		[Address(RVA = "0xBB4DF0", Offset = "0xBB3DF0", VA = "0x180BB4DF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002529 RID: 9513 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002529")]
	[Address(RVA = "0xBB4E30", Offset = "0xBB3E30", VA = "0x180BB4E30")]
	public void Setup(WindowContentController newContentController)
	{
	}

	// Token: 0x0600252A RID: 9514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600252A")]
	[Address(RVA = "0xBB5690", Offset = "0xBB4690", VA = "0x180BB5690")]
	public void UpdateResolveFields()
	{
	}

	// Token: 0x0600252B RID: 9515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600252B")]
	[Address(RVA = "0xBB5E20", Offset = "0xBB4E20", VA = "0x180BB5E20")]
	public void SetPageSize(Vector2 newSize)
	{
	}

	// Token: 0x0600252C RID: 9516 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600252C")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CloseCaseButton()
	{
	}

	// Token: 0x0600252D RID: 9517 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600252D")]
	[Address(RVA = "0xBB5F80", Offset = "0xBB4F80", VA = "0x180BB5F80")]
	public ResultsController()
	{
	}

	// Token: 0x04002F4D RID: 12109
	[Token(Token = "0x4002F4D")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002F4E RID: 12110
	[Token(Token = "0x4002F4E")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform pageRect;

	// Token: 0x04002F4F RID: 12111
	[Token(Token = "0x4002F4F")]
	[FieldOffset(Offset = "0x28")]
	public WindowContentController wcc;

	// Token: 0x04002F50 RID: 12112
	[Token(Token = "0x4002F50")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI titleText;

	// Token: 0x04002F51 RID: 12113
	[Token(Token = "0x4002F51")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI descriptionText;

	// Token: 0x04002F52 RID: 12114
	[Token(Token = "0x4002F52")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI successText;

	// Token: 0x04002F53 RID: 12115
	[Token(Token = "0x4002F53")]
	[FieldOffset(Offset = "0x48")]
	public GameObject inputFieldPrefab;

	// Token: 0x04002F54 RID: 12116
	[Token(Token = "0x4002F54")]
	[FieldOffset(Offset = "0x50")]
	public ButtonController closeCaseButton;

	// Token: 0x04002F55 RID: 12117
	[Token(Token = "0x4002F55")]
	[FieldOffset(Offset = "0x58")]
	public LayoutGroup layout;

	// Token: 0x04002F56 RID: 12118
	[Token(Token = "0x4002F56")]
	[FieldOffset(Offset = "0x60")]
	public ProgressBarController questionsBar;

	// Token: 0x04002F57 RID: 12119
	[Token(Token = "0x4002F57")]
	[FieldOffset(Offset = "0x68")]
	public ProgressBarController victimsBar;

	// Token: 0x04002F58 RID: 12120
	[Token(Token = "0x4002F58")]
	[FieldOffset(Offset = "0x70")]
	public Image rankImage;

	// Token: 0x04002F59 RID: 12121
	[Token(Token = "0x4002F59")]
	[FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI rankText;

	// Token: 0x04002F5A RID: 12122
	[Token(Token = "0x4002F5A")]
	[FieldOffset(Offset = "0x80")]
	public bool isSetup;

	// Token: 0x04002F5B RID: 12123
	[Token(Token = "0x4002F5B")]
	[FieldOffset(Offset = "0x88")]
	public List<InputFieldController> spawnedInputFields;

	// Token: 0x04002F5C RID: 12124
	[Token(Token = "0x4002F5C")]
	[FieldOffset(Offset = "0x0")]
	private static ResultsController _instance;
}
