using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000679 RID: 1657
[Token(Token = "0x2000679")]
public class HelpController : MonoBehaviour
{
	// Token: 0x1700012A RID: 298
	// (get) Token: 0x060024B8 RID: 9400 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700012A")]
	public static HelpController Instance
	{
		[Token(Token = "0x60024B8")]
		[Address(RVA = "0xBA0560", Offset = "0xB9F560", VA = "0x180BA0560")]
		get
		{
			return null;
		}
	}

	// Token: 0x060024B9 RID: 9401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024B9")]
	[Address(RVA = "0xBA05A0", Offset = "0xB9F5A0", VA = "0x180BA05A0")]
	public void Setup(WindowContentController newContentController)
	{
	}

	// Token: 0x060024BA RID: 9402 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024BA")]
	[Address(RVA = "0xBA0D50", Offset = "0xB9FD50", VA = "0x180BA0D50")]
	public void SetPageSize(Vector2 newSize)
	{
	}

	// Token: 0x060024BB RID: 9403 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024BB")]
	[Address(RVA = "0xBA0EB0", Offset = "0xB9FEB0", VA = "0x180BA0EB0")]
	public void DisplayHelpContents()
	{
	}

	// Token: 0x060024BC RID: 9404 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024BC")]
	[Address(RVA = "0xBA12E0", Offset = "0xBA02E0", VA = "0x180BA12E0")]
	public void UpdateHelpButtonList()
	{
	}

	// Token: 0x060024BD RID: 9405 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024BD")]
	[Address(RVA = "0xBA2240", Offset = "0xBA1240", VA = "0x180BA2240")]
	private void OnDestroy()
	{
	}

	// Token: 0x060024BE RID: 9406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024BE")]
	[Address(RVA = "0xBA26A0", Offset = "0xBA16A0", VA = "0x180BA26A0")]
	private void OnDisable()
	{
	}

	// Token: 0x060024BF RID: 9407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024BF")]
	[Address(RVA = "0xBA27F0", Offset = "0xBA17F0", VA = "0x180BA27F0")]
	private void OnEnable()
	{
	}

	// Token: 0x060024C0 RID: 9408 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024C0")]
	[Address(RVA = "0xBA2940", Offset = "0xBA1940", VA = "0x180BA2940")]
	public void ClearSearchButton()
	{
	}

	// Token: 0x060024C1 RID: 9409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024C1")]
	[Address(RVA = "0xBA29A0", Offset = "0xBA19A0", VA = "0x180BA29A0")]
	public void DisplayHelpPage(ButtonController button)
	{
	}

	// Token: 0x060024C2 RID: 9410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024C2")]
	[Address(RVA = "0xBA29E0", Offset = "0xBA19E0", VA = "0x180BA29E0")]
	public void DisplayHelpPage(string pageName)
	{
	}

	// Token: 0x060024C3 RID: 9411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024C3")]
	[Address(RVA = "0xBA2A20", Offset = "0xBA1A20", VA = "0x180BA2A20")]
	public void LoadHelpPage(string h)
	{
	}

	// Token: 0x060024C4 RID: 9412 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024C4")]
	[Address(RVA = "0xBA3750", Offset = "0xBA2750", VA = "0x180BA3750")]
	public HelpController()
	{
	}

	// Token: 0x04002ECA RID: 11978
	[Token(Token = "0x4002ECA")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002ECB RID: 11979
	[Token(Token = "0x4002ECB")]
	[FieldOffset(Offset = "0x20")]
	public WindowContentController wcc;

	// Token: 0x04002ECC RID: 11980
	[Token(Token = "0x4002ECC")]
	[FieldOffset(Offset = "0x28")]
	public bool isSetup;

	// Token: 0x04002ECD RID: 11981
	[Token(Token = "0x4002ECD")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform helpContents;

	// Token: 0x04002ECE RID: 11982
	[Token(Token = "0x4002ECE")]
	[FieldOffset(Offset = "0x38")]
	public TMP_InputField searchInputField;

	// Token: 0x04002ECF RID: 11983
	[Token(Token = "0x4002ECF")]
	[FieldOffset(Offset = "0x40")]
	public RectTransform helpContentButtonParent;

	// Token: 0x04002ED0 RID: 11984
	[Token(Token = "0x4002ED0")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI contentsText;

	// Token: 0x04002ED1 RID: 11985
	[Token(Token = "0x4002ED1")]
	[FieldOffset(Offset = "0x50")]
	public List<InterfaceVideoController> videos;

	// Token: 0x04002ED2 RID: 11986
	[Token(Token = "0x4002ED2")]
	[FieldOffset(Offset = "0x58")]
	public GameObject page;

	// Token: 0x04002ED3 RID: 11987
	[Token(Token = "0x4002ED3")]
	[FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI helpTitle;

	// Token: 0x04002ED4 RID: 11988
	[Token(Token = "0x4002ED4")]
	[FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI helpContent;

	// Token: 0x04002ED5 RID: 11989
	[Token(Token = "0x4002ED5")]
	[FieldOffset(Offset = "0x70")]
	public ButtonController backButtonTop;

	// Token: 0x04002ED6 RID: 11990
	[Token(Token = "0x4002ED6")]
	[FieldOffset(Offset = "0x78")]
	public ButtonController backButtonBottom;

	// Token: 0x04002ED7 RID: 11991
	[Token(Token = "0x4002ED7")]
	[FieldOffset(Offset = "0x80")]
	public VerticalLayoutGroup layoutGroup;

	// Token: 0x04002ED8 RID: 11992
	[Token(Token = "0x4002ED8")]
	[FieldOffset(Offset = "0x88")]
	public List<ButtonController> helpContentButtons;

	// Token: 0x04002ED9 RID: 11993
	[Token(Token = "0x4002ED9")]
	[FieldOffset(Offset = "0x90")]
	public GameObject helpContentButtonPrefab;

	// Token: 0x04002EDA RID: 11994
	[Token(Token = "0x4002EDA")]
	[FieldOffset(Offset = "0x0")]
	private static HelpController _instance;
}
