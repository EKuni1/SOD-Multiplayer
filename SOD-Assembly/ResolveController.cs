using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000688 RID: 1672
[Token(Token = "0x2000688")]
public class ResolveController : MonoBehaviour
{
	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06002511 RID: 9489 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700012C")]
	public static ResolveController Instance
	{
		[Token(Token = "0x6002511")]
		[Address(RVA = "0xBB0AB0", Offset = "0xBAFAB0", VA = "0x180BB0AB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002512 RID: 9490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002512")]
	[Address(RVA = "0xBB0AF0", Offset = "0xBAFAF0", VA = "0x180BB0AF0")]
	public void Setup(WindowContentController newContentController)
	{
	}

	// Token: 0x06002513 RID: 9491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002513")]
	[Address(RVA = "0xBB1310", Offset = "0xBB0310", VA = "0x180BB1310")]
	public void UpdateResolveFields()
	{
	}

	// Token: 0x06002514 RID: 9492 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002514")]
	[Address(RVA = "0xBB1B50", Offset = "0xBB0B50", VA = "0x180BB1B50")]
	public void ValidationUpdate()
	{
	}

	// Token: 0x06002515 RID: 9493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002515")]
	[Address(RVA = "0xBB28E0", Offset = "0xBB18E0", VA = "0x180BB28E0")]
	public void SetPageSize(Vector2 newSize)
	{
	}

	// Token: 0x06002516 RID: 9494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002516")]
	[Address(RVA = "0xBB29D0", Offset = "0xBB19D0", VA = "0x180BB29D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002517 RID: 9495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002517")]
	[Address(RVA = "0xBB2A30", Offset = "0xBB1A30", VA = "0x180BB2A30")]
	public void SubmitButton()
	{
	}

	// Token: 0x06002518 RID: 9496 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002518")]
	[Address(RVA = "0xBB2B30", Offset = "0xBB1B30", VA = "0x180BB2B30")]
	public void ChangeLeadButton()
	{
	}

	// Token: 0x06002519 RID: 9497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002519")]
	[Address(RVA = "0xBB2F50", Offset = "0xBB1F50", VA = "0x180BB2F50")]
	public void CloseCaseButton()
	{
	}

	// Token: 0x0600251A RID: 9498 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600251A")]
	[Address(RVA = "0xBB3400", Offset = "0xBB2400", VA = "0x180BB3400")]
	public void CancelCloseCase()
	{
	}

	// Token: 0x0600251B RID: 9499 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600251B")]
	[Address(RVA = "0xBB3560", Offset = "0xBB2560", VA = "0x180BB3560")]
	public void ConfirmCloseCurrentCase()
	{
	}

	// Token: 0x0600251C RID: 9500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600251C")]
	[Address(RVA = "0xBB3960", Offset = "0xBB2960", VA = "0x180BB3960")]
	public ResolveController()
	{
	}

	// Token: 0x04002F34 RID: 12084
	[Token(Token = "0x4002F34")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002F35 RID: 12085
	[Token(Token = "0x4002F35")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform pageRect;

	// Token: 0x04002F36 RID: 12086
	[Token(Token = "0x4002F36")]
	[FieldOffset(Offset = "0x28")]
	public WindowContentController wcc;

	// Token: 0x04002F37 RID: 12087
	[Token(Token = "0x4002F37")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI titleText;

	// Token: 0x04002F38 RID: 12088
	[Token(Token = "0x4002F38")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI descriptionText;

	// Token: 0x04002F39 RID: 12089
	[Token(Token = "0x4002F39")]
	[FieldOffset(Offset = "0x40")]
	public GameObject inputFieldPrefab;

	// Token: 0x04002F3A RID: 12090
	[Token(Token = "0x4002F3A")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI invalidText;

	// Token: 0x04002F3B RID: 12091
	[Token(Token = "0x4002F3B")]
	[FieldOffset(Offset = "0x50")]
	public RectTransform lineBreak1;

	// Token: 0x04002F3C RID: 12092
	[Token(Token = "0x4002F3C")]
	[FieldOffset(Offset = "0x58")]
	public ButtonController submitButton;

	// Token: 0x04002F3D RID: 12093
	[Token(Token = "0x4002F3D")]
	[FieldOffset(Offset = "0x60")]
	public ButtonController changeLeadButton;

	// Token: 0x04002F3E RID: 12094
	[Token(Token = "0x4002F3E")]
	[FieldOffset(Offset = "0x68")]
	public ButtonController closeCaseButton;

	// Token: 0x04002F3F RID: 12095
	[Token(Token = "0x4002F3F")]
	[FieldOffset(Offset = "0x70")]
	public RectTransform lineBreak2;

	// Token: 0x04002F40 RID: 12096
	[Token(Token = "0x4002F40")]
	[FieldOffset(Offset = "0x78")]
	public LayoutGroup layout;

	// Token: 0x04002F41 RID: 12097
	[Token(Token = "0x4002F41")]
	[FieldOffset(Offset = "0x80")]
	public bool isSetup;

	// Token: 0x04002F42 RID: 12098
	[Token(Token = "0x4002F42")]
	[FieldOffset(Offset = "0x81")]
	public bool isValid;

	// Token: 0x04002F43 RID: 12099
	[Token(Token = "0x4002F43")]
	[FieldOffset(Offset = "0x88")]
	public List<InputFieldController> spawnedInputFields;

	// Token: 0x04002F44 RID: 12100
	[Token(Token = "0x4002F44")]
	[FieldOffset(Offset = "0x0")]
	private static ResolveController _instance;

	// Token: 0x02000689 RID: 1673
	[Token(Token = "0x2000689")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600251E RID: 9502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600251E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x0000EB50 File Offset: 0x0000CD50
		[Token(Token = "0x600251F")]
		[Address(RVA = "0xBB3B10", Offset = "0xBB2B10", VA = "0x180BB3B10")]
		internal bool <ValidationUpdate>b__21_0(Case.ResolveQuestion item)
		{
			return default(bool);
		}

		// Token: 0x04002F45 RID: 12101
		[Token(Token = "0x4002F45")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ResolveController.<>c <>9;

		// Token: 0x04002F46 RID: 12102
		[Token(Token = "0x4002F46")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Case.ResolveQuestion> <>9__21_0;
	}
}
