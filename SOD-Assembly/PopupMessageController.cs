using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200064E RID: 1614
[Token(Token = "0x200064E")]
public class PopupMessageController : MonoBehaviour
{
	// Token: 0x14000044 RID: 68
	// (add) Token: 0x0600238F RID: 9103 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002390 RID: 9104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000044")]
	public event PopupMessageController.LeftButton OnLeftButton
	{
		[Token(Token = "0x600238F")]
		[Address(RVA = "0xB691D0", Offset = "0xB681D0", VA = "0x180B691D0")]
		add
		{
		}
		[Token(Token = "0x6002390")]
		[Address(RVA = "0xB692D0", Offset = "0xB682D0", VA = "0x180B692D0")]
		remove
		{
		}
	}

	// Token: 0x14000045 RID: 69
	// (add) Token: 0x06002391 RID: 9105 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002392 RID: 9106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000045")]
	public event PopupMessageController.RightButton OnRightButton
	{
		[Token(Token = "0x6002391")]
		[Address(RVA = "0xB693D0", Offset = "0xB683D0", VA = "0x180B693D0")]
		add
		{
		}
		[Token(Token = "0x6002392")]
		[Address(RVA = "0xB694D0", Offset = "0xB684D0", VA = "0x180B694D0")]
		remove
		{
		}
	}

	// Token: 0x14000046 RID: 70
	// (add) Token: 0x06002393 RID: 9107 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002394 RID: 9108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000046")]
	public event PopupMessageController.LeftButton2 OnLeftButton2
	{
		[Token(Token = "0x6002393")]
		[Address(RVA = "0xB695D0", Offset = "0xB685D0", VA = "0x180B695D0")]
		add
		{
		}
		[Token(Token = "0x6002394")]
		[Address(RVA = "0xB696D0", Offset = "0xB686D0", VA = "0x180B696D0")]
		remove
		{
		}
	}

	// Token: 0x14000047 RID: 71
	// (add) Token: 0x06002395 RID: 9109 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002396 RID: 9110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000047")]
	public event PopupMessageController.RightButton2 OnRightButton2
	{
		[Token(Token = "0x6002395")]
		[Address(RVA = "0xB697D0", Offset = "0xB687D0", VA = "0x180B697D0")]
		add
		{
		}
		[Token(Token = "0x6002396")]
		[Address(RVA = "0xB698D0", Offset = "0xB688D0", VA = "0x180B698D0")]
		remove
		{
		}
	}

	// Token: 0x14000048 RID: 72
	// (add) Token: 0x06002397 RID: 9111 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002398 RID: 9112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000048")]
	public event PopupMessageController.OptionButton OnOptionButton
	{
		[Token(Token = "0x6002397")]
		[Address(RVA = "0xB699D0", Offset = "0xB689D0", VA = "0x180B699D0")]
		add
		{
		}
		[Token(Token = "0x6002398")]
		[Address(RVA = "0xB69AD0", Offset = "0xB68AD0", VA = "0x180B69AD0")]
		remove
		{
		}
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06002399 RID: 9113 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000125")]
	public static PopupMessageController Instance
	{
		[Token(Token = "0x6002399")]
		[Address(RVA = "0xB69BD0", Offset = "0xB68BD0", VA = "0x180B69BD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600239A RID: 9114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600239A")]
	[Address(RVA = "0xB69C10", Offset = "0xB68C10", VA = "0x180B69C10")]
	public void Setup()
	{
	}

	// Token: 0x0600239B RID: 9115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600239B")]
	[Address(RVA = "0xB69FF0", Offset = "0xB68FF0", VA = "0x180B69FF0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600239C RID: 9116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600239C")]
	[Address(RVA = "0xB6A200", Offset = "0xB69200", VA = "0x180B6A200")]
	private void Update()
	{
	}

	// Token: 0x0600239D RID: 9117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600239D")]
	[Address(RVA = "0xB6B060", Offset = "0xB6A060", VA = "0x180B6B060")]
	public void PopupMessage(string newMsgString, bool enableLeftButton = true, bool enableRightButton = false, string LButton = "Cancel", string RButton = "", bool anyButtonClosesMsg = true, PopupMessageController.AffectPauseState newPauseState = PopupMessageController.AffectPauseState.automatic, bool enableInputField = false, string inputFieldDefault = "", bool closeMap = false, bool enableColourPicker = false, bool enableSecondaryLeftButton = false, bool enableSecondaryRightButton = false, string LButton2 = "", string RButton2 = "", bool enableOptionButton = false, string OButton = "", bool enableTextScrollView = false, string scrollViewText = "", string mainTextPreWrittenOverride = "", bool newAllowEmptyInputField = false)
	{
	}

	// Token: 0x0600239E RID: 9118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600239E")]
	[Address(RVA = "0xB6CB80", Offset = "0xB6BB80", VA = "0x180B6CB80")]
	public void TutorialMessage(string newHelpSection, PopupMessageController.AffectPauseState newPauseState = PopupMessageController.AffectPauseState.automatic, bool closeMap = false, [Optional] List<string> newSkipBlocks)
	{
	}

	// Token: 0x0600239F RID: 9119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600239F")]
	[Address(RVA = "0xB6DB70", Offset = "0xB6CB70", VA = "0x180B6DB70")]
	public void SetHelpPage(int newNumber)
	{
	}

	// Token: 0x060023A0 RID: 9120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023A0")]
	[Address(RVA = "0xB6E3E0", Offset = "0xB6D3E0", VA = "0x180B6E3E0")]
	public void RemoveMessage()
	{
	}

	// Token: 0x060023A1 RID: 9121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023A1")]
	[Address(RVA = "0xB6EB20", Offset = "0xB6DB20", VA = "0x180B6EB20")]
	public void OnButtonPress(int buttonVal)
	{
	}

	// Token: 0x060023A2 RID: 9122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023A2")]
	[Address(RVA = "0xB6EDE0", Offset = "0xB6DDE0", VA = "0x180B6EDE0")]
	public void OnInputFieldSelect()
	{
	}

	// Token: 0x060023A3 RID: 9123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023A3")]
	[Address(RVA = "0xB6F080", Offset = "0xB6E080", VA = "0x180B6F080")]
	public void SelectDefault()
	{
	}

	// Token: 0x060023A4 RID: 9124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023A4")]
	[Address(RVA = "0xB6FF80", Offset = "0xB6EF80", VA = "0x180B6FF80")]
	public void SelectDefaultTutorial()
	{
	}

	// Token: 0x060023A5 RID: 9125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023A5")]
	[Address(RVA = "0xB70900", Offset = "0xB6F900", VA = "0x180B70900")]
	public void InputFieldValidation()
	{
	}

	// Token: 0x060023A6 RID: 9126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023A6")]
	[Address(RVA = "0xB70DA0", Offset = "0xB6FDA0", VA = "0x180B70DA0")]
	public PopupMessageController()
	{
	}

	// Token: 0x060023A7 RID: 9127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023A7")]
	[Address(RVA = "0xB71110", Offset = "0xB70110", VA = "0x180B71110")]
	private void <Setup>b__64_0(string arg0)
	{
	}

	// Token: 0x060023A8 RID: 9128 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
	[Token(Token = "0x60023A8")]
	[Address(RVA = "0xB71140", Offset = "0xB70140", VA = "0x180B71140")]
	private bool <SetHelpPage>b__69_0(string item)
	{
		return default(bool);
	}

	// Token: 0x04002D75 RID: 11637
	[Token(Token = "0x4002D75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002D76 RID: 11638
	[Token(Token = "0x4002D76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI titleText;

	// Token: 0x04002D77 RID: 11639
	[Token(Token = "0x4002D77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI bodyText;

	// Token: 0x04002D78 RID: 11640
	[Token(Token = "0x4002D78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ButtonController leftButton;

	// Token: 0x04002D79 RID: 11641
	[Token(Token = "0x4002D79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ButtonController rightButton;

	// Token: 0x04002D7A RID: 11642
	[Token(Token = "0x4002D7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ButtonController leftButton2;

	// Token: 0x04002D7B RID: 11643
	[Token(Token = "0x4002D7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonController rightButton2;

	// Token: 0x04002D7C RID: 11644
	[Token(Token = "0x4002D7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ButtonController optionButton;

	// Token: 0x04002D7D RID: 11645
	[Token(Token = "0x4002D7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public CustomScrollRect textScrollView;

	// Token: 0x04002D7E RID: 11646
	[Token(Token = "0x4002D7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RectTransform textScrollViewContent;

	// Token: 0x04002D7F RID: 11647
	[Token(Token = "0x4002D7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI scrollViewTextObject;

	// Token: 0x04002D80 RID: 11648
	[Token(Token = "0x4002D80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TMP_InputField inputField;

	// Token: 0x04002D81 RID: 11649
	[Token(Token = "0x4002D81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MultiSelectController colourPicker;

	// Token: 0x04002D82 RID: 11650
	[Token(Token = "0x4002D82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<LayoutGroup> buttonLayouts;

	// Token: 0x04002D83 RID: 11651
	[Token(Token = "0x4002D83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public CanvasGroup canvasGroup;

	// Token: 0x04002D84 RID: 11652
	[Token(Token = "0x4002D84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public CanvasRenderer vignetteRenderer;

	// Token: 0x04002D85 RID: 11653
	[Token(Token = "0x4002D85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject vignetteObject;

	// Token: 0x04002D86 RID: 11654
	[Token(Token = "0x4002D86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<GraphicRaycaster> otherCanvasRaycasters;

	// Token: 0x04002D87 RID: 11655
	[Token(Token = "0x4002D87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RectTransform tutorialRect;

	// Token: 0x04002D88 RID: 11656
	[Token(Token = "0x4002D88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMeshProUGUI tutorialTitleText;

	// Token: 0x04002D89 RID: 11657
	[Token(Token = "0x4002D89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TextMeshProUGUI tutorialBodyText;

	// Token: 0x04002D8A RID: 11658
	[Token(Token = "0x4002D8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public ButtonController tutorialLeftButton;

	// Token: 0x04002D8B RID: 11659
	[Token(Token = "0x4002D8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public ButtonController tutorialRightButton;

	// Token: 0x04002D8C RID: 11660
	[Token(Token = "0x4002D8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public InterfaceVideoController tutorialVideoPlayer;

	// Token: 0x04002D8D RID: 11661
	[Token(Token = "0x4002D8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<LayoutGroup> tutorialButtonLayouts;

	// Token: 0x04002D8E RID: 11662
	[Token(Token = "0x4002D8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public HelpContentPage helpPage;

	// Token: 0x04002D8F RID: 11663
	[Token(Token = "0x4002D8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public int helpPageNumber;

	// Token: 0x04002D90 RID: 11664
	[Token(Token = "0x4002D90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public int maxHelpPageNumber;

	// Token: 0x04002D91 RID: 11665
	[Token(Token = "0x4002D91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<string> skipBlocks;

	// Token: 0x04002D92 RID: 11666
	[Token(Token = "0x4002D92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public CanvasGroup tutorialCanvasGroup;

	// Token: 0x04002D93 RID: 11667
	[Token(Token = "0x4002D93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool active;

	// Token: 0x04002D94 RID: 11668
	[Token(Token = "0x4002D94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
	public bool tutorialActive;

	// Token: 0x04002D95 RID: 11669
	[Token(Token = "0x4002D95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public float appearProgress;

	// Token: 0x04002D96 RID: 11670
	[Token(Token = "0x4002D96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public List<string> buttonActions;

	// Token: 0x04002D97 RID: 11671
	[Token(Token = "0x4002D97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public bool anyButtonPressCloses;

	// Token: 0x04002D98 RID: 11672
	[Token(Token = "0x4002D98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
	public bool allowEmptyInputField;

	// Token: 0x04002D99 RID: 11673
	[Token(Token = "0x4002D99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private float inputFieldValidationTimer;

	// Token: 0x04002D9A RID: 11674
	[Token(Token = "0x4002D9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public bool previouslyEnabledVirtualCursor;

	// Token: 0x04002D9B RID: 11675
	[Token(Token = "0x4002D9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
	public bool affectPauseState;

	// Token: 0x04002D9C RID: 11676
	[Token(Token = "0x4002D9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11A")]
	private bool setupNav;

	// Token: 0x04002DA2 RID: 11682
	[Token(Token = "0x4002DA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PopupMessageController _instance;

	// Token: 0x0200064F RID: 1615
	[Token(Token = "0x200064F")]
	public enum AffectPauseState
	{
		// Token: 0x04002DA4 RID: 11684
		[Token(Token = "0x4002DA4")]
		automatic,
		// Token: 0x04002DA5 RID: 11685
		[Token(Token = "0x4002DA5")]
		yes,
		// Token: 0x04002DA6 RID: 11686
		[Token(Token = "0x4002DA6")]
		no
	}

	// Token: 0x02000650 RID: 1616
	// (Invoke) Token: 0x060023AA RID: 9130
	[Token(Token = "0x2000650")]
	public delegate void LeftButton();

	// Token: 0x02000651 RID: 1617
	// (Invoke) Token: 0x060023AE RID: 9134
	[Token(Token = "0x2000651")]
	public delegate void RightButton();

	// Token: 0x02000652 RID: 1618
	// (Invoke) Token: 0x060023B2 RID: 9138
	[Token(Token = "0x2000652")]
	public delegate void LeftButton2();

	// Token: 0x02000653 RID: 1619
	// (Invoke) Token: 0x060023B6 RID: 9142
	[Token(Token = "0x2000653")]
	public delegate void RightButton2();

	// Token: 0x02000654 RID: 1620
	// (Invoke) Token: 0x060023BA RID: 9146
	[Token(Token = "0x2000654")]
	public delegate void OptionButton();
}
