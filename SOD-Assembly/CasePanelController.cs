using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000554 RID: 1364
[Token(Token = "0x2000554")]
public class CasePanelController : PanelController
{
	// Token: 0x14000029 RID: 41
	// (add) Token: 0x06001D90 RID: 7568 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001D91 RID: 7569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000029")]
	public event CasePanelController.PinnedChange OnPinnedChange
	{
		[Token(Token = "0x6001D90")]
		[Address(RVA = "0xA2C460", Offset = "0xA2B460", VA = "0x180A2C460")]
		add
		{
		}
		[Token(Token = "0x6001D91")]
		[Address(RVA = "0xA2C560", Offset = "0xA2B560", VA = "0x180A2C560")]
		remove
		{
		}
	}

	// Token: 0x1400002A RID: 42
	// (add) Token: 0x06001D92 RID: 7570 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001D93 RID: 7571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400002A")]
	public event CasePanelController.PinEvidence OnPinEvidence
	{
		[Token(Token = "0x6001D92")]
		[Address(RVA = "0xA2C660", Offset = "0xA2B660", VA = "0x180A2C660")]
		add
		{
		}
		[Token(Token = "0x6001D93")]
		[Address(RVA = "0xA2C760", Offset = "0xA2B760", VA = "0x180A2C760")]
		remove
		{
		}
	}

	// Token: 0x1400002B RID: 43
	// (add) Token: 0x06001D94 RID: 7572 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001D95 RID: 7573 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400002B")]
	public event CasePanelController.UnpinEvidence OnUnpinEvidence
	{
		[Token(Token = "0x6001D94")]
		[Address(RVA = "0xA2C860", Offset = "0xA2B860", VA = "0x180A2C860")]
		add
		{
		}
		[Token(Token = "0x6001D95")]
		[Address(RVA = "0xA2C960", Offset = "0xA2B960", VA = "0x180A2C960")]
		remove
		{
		}
	}

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x06001D96 RID: 7574 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000EB")]
	public static CasePanelController Instance
	{
		[Token(Token = "0x6001D96")]
		[Address(RVA = "0xA2CA60", Offset = "0xA2BA60", VA = "0x180A2CA60")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001D97 RID: 7575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D97")]
	[Address(RVA = "0xA2CAA0", Offset = "0xA2BAA0", VA = "0x180A2CAA0")]
	private void Awake()
	{
	}

	// Token: 0x06001D98 RID: 7576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D98")]
	[Address(RVA = "0xA2CDF0", Offset = "0xA2BDF0", VA = "0x180A2CDF0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001D99 RID: 7577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D99")]
	[Address(RVA = "0xA2D000", Offset = "0xA2C000", VA = "0x180A2D000")]
	private void Start()
	{
	}

	// Token: 0x06001D9A RID: 7578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D9A")]
	[Address(RVA = "0xA2D010", Offset = "0xA2C010", VA = "0x180A2D010")]
	public void UpdateCaseControls()
	{
	}

	// Token: 0x06001D9B RID: 7579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D9B")]
	[Address(RVA = "0xA2D750", Offset = "0xA2C750", VA = "0x180A2D750")]
	public void SelectNoCaseButton()
	{
	}

	// Token: 0x06001D9C RID: 7580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D9C")]
	[Address(RVA = "0xA2D7E0", Offset = "0xA2C7E0", VA = "0x180A2D7E0")]
	public void NewCustomCaseButton()
	{
	}

	// Token: 0x06001D9D RID: 7581 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D9D")]
	[Address(RVA = "0xA2D910", Offset = "0xA2C910", VA = "0x180A2D910")]
	public Case CreateNewCase(Case.CaseType newType, Case.CaseStatus newStatus, bool isSilent = false, string caseName = "New Case")
	{
		return null;
	}

	// Token: 0x06001D9E RID: 7582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D9E")]
	[Address(RVA = "0xA2E000", Offset = "0xA2D000", VA = "0x180A2E000")]
	public void OnCreateNewCustomCase()
	{
	}

	// Token: 0x06001D9F RID: 7583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D9F")]
	[Address(RVA = "0xA2E240", Offset = "0xA2D240", VA = "0x180A2E240")]
	public void OnCancelNewCustomCase()
	{
	}

	// Token: 0x06001DA0 RID: 7584 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DA0")]
	[Address(RVA = "0xA2E3A0", Offset = "0xA2D3A0", VA = "0x180A2E3A0")]
	public void UpdateCloseCaseButton()
	{
	}

	// Token: 0x06001DA1 RID: 7585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DA1")]
	[Address(RVA = "0xA2F000", Offset = "0xA2E000", VA = "0x180A2F000")]
	private void Update()
	{
	}

	// Token: 0x06001DA2 RID: 7586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DA2")]
	[Address(RVA = "0xA2F2B0", Offset = "0xA2E2B0", VA = "0x180A2F2B0")]
	public void CloseCaseButton()
	{
	}

	// Token: 0x06001DA3 RID: 7587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DA3")]
	[Address(RVA = "0xA2F4C0", Offset = "0xA2E4C0", VA = "0x180A2F4C0")]
	public void CloseCase(Case closeThisCase)
	{
	}

	// Token: 0x06001DA4 RID: 7588 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DA4")]
	[Address(RVA = "0xA2F560", Offset = "0xA2E560", VA = "0x180A2F560")]
	public void SetActiveCase(Case newCase)
	{
	}

	// Token: 0x06001DA5 RID: 7589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DA5")]
	[Address(RVA = "0xA2FAD0", Offset = "0xA2EAD0", VA = "0x180A2FAD0")]
	public void UpdateCaseButtonsActive()
	{
	}

	// Token: 0x06001DA6 RID: 7590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DA6")]
	[Address(RVA = "0xA2FC80", Offset = "0xA2EC80", VA = "0x180A2FC80")]
	public void NewStickyNoteButton()
	{
	}

	// Token: 0x06001DA7 RID: 7591 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DA7")]
	[Address(RVA = "0xA2FC90", Offset = "0xA2EC90", VA = "0x180A2FC90")]
	public InfoWindow NewStickyNote()
	{
		return null;
	}

	// Token: 0x06001DA8 RID: 7592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DA8")]
	[Address(RVA = "0xA301E0", Offset = "0xA2F1E0", VA = "0x180A301E0")]
	public void OnCreateNewCasePopup()
	{
	}

	// Token: 0x06001DA9 RID: 7593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DA9")]
	[Address(RVA = "0xA30380", Offset = "0xA2F380", VA = "0x180A30380")]
	public void onCreateNewCasePopupCancel()
	{
	}

	// Token: 0x06001DAA RID: 7594 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DAA")]
	[Address(RVA = "0xA304E0", Offset = "0xA2F4E0", VA = "0x180A304E0")]
	public void PinToCasePanel(Case toCase, Evidence ev, Evidence.DataKey evKey, bool forceAutoPin = false, [Optional] Vector2 localPostion, bool debugFlag = false)
	{
	}

	// Token: 0x06001DAB RID: 7595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DAB")]
	[Address(RVA = "0xA305E0", Offset = "0xA2F5E0", VA = "0x180A305E0")]
	public void PinToCasePanel(Case toCase, Evidence ev, List<Evidence.DataKey> evKeys, bool forceAutoPin = false, [Optional] Vector2 localPostion, bool debugFlag = false)
	{
	}

	// Token: 0x06001DAC RID: 7596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DAC")]
	[Address(RVA = "0xA31530", Offset = "0xA30530", VA = "0x180A31530")]
	public void UnPinFromCasePanel(Case thisCase, Evidence ev, List<Evidence.DataKey> evKeys, bool uniqueKeysOnly = false, [Optional] Case.CaseElement forceElement)
	{
	}

	// Token: 0x06001DAD RID: 7597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DAD")]
	[Address(RVA = "0xA31F80", Offset = "0xA30F80", VA = "0x180A31F80")]
	public void UpdatePinned()
	{
	}

	// Token: 0x06001DAE RID: 7598 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DAE")]
	[Address(RVA = "0xA32CE0", Offset = "0xA31CE0", VA = "0x180A32CE0")]
	public void UpdateStrings()
	{
	}

	// Token: 0x06001DAF RID: 7599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DAF")]
	[Address(RVA = "0xA33CC0", Offset = "0xA32CC0", VA = "0x180A33CC0")]
	public void CustomStringLinkSelection(PinnedItemController pinnedItem, bool holdButtonMode = false)
	{
	}

	// Token: 0x06001DB0 RID: 7600 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DB0")]
	[Address(RVA = "0xA33F80", Offset = "0xA32F80", VA = "0x180A33F80")]
	private IEnumerator CustomStringLink(bool holdButtonMode = false)
	{
		return null;
	}

	// Token: 0x06001DB1 RID: 7601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DB1")]
	[Address(RVA = "0xA34040", Offset = "0xA33040", VA = "0x180A34040")]
	private void OnDisable()
	{
	}

	// Token: 0x06001DB2 RID: 7602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DB2")]
	[Address(RVA = "0xA341D0", Offset = "0xA331D0", VA = "0x180A341D0")]
	public void CancelCustomStringLinkSelection()
	{
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DB3")]
	[Address(RVA = "0xA34490", Offset = "0xA33490", VA = "0x180A34490")]
	public void FinishCustomStringLinkSelection(PinnedItemController target)
	{
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DB4")]
	[Address(RVA = "0xA34BE0", Offset = "0xA33BE0", VA = "0x180A34BE0")]
	public void OnContinueFactName()
	{
	}

	// Token: 0x06001DB5 RID: 7605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DB5")]
	[Address(RVA = "0xA34EF0", Offset = "0xA33EF0", VA = "0x180A34EF0")]
	public void OnCancelCustomFact()
	{
	}

	// Token: 0x06001DB6 RID: 7606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DB6")]
	[Address(RVA = "0xA35260", Offset = "0xA34260", VA = "0x180A35260")]
	public void UpdateResolveNotifications()
	{
	}

	// Token: 0x06001DB7 RID: 7607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DB7")]
	[Address(RVA = "0xA35460", Offset = "0xA34460", VA = "0x180A35460")]
	public void SetPickModeActive(bool val, InputFieldController forField)
	{
	}

	// Token: 0x06001DB8 RID: 7608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DB8")]
	[Address(RVA = "0xA35AC0", Offset = "0xA34AC0", VA = "0x180A35AC0")]
	public void OnShowCaseBoard()
	{
	}

	// Token: 0x06001DB9 RID: 7609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DB9")]
	[Address(RVA = "0xA35B30", Offset = "0xA34B30", VA = "0x180A35B30")]
	public void OnHideCaseBoard()
	{
	}

	// Token: 0x06001DBA RID: 7610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DBA")]
	[Address(RVA = "0xA35D90", Offset = "0xA34D90", VA = "0x180A35D90")]
	public void SetControllerMode(bool isActive, CasePanelController.ControllerSelectMode newMode)
	{
	}

	// Token: 0x06001DBB RID: 7611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DBB")]
	[Address(RVA = "0xA36B00", Offset = "0xA35B00", VA = "0x180A36B00")]
	public void SetSelectedWindow(InfoWindow newWindow, bool forceUpdate = false, bool snapVirtualCursor = false)
	{
	}

	// Token: 0x06001DBC RID: 7612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DBC")]
	[Address(RVA = "0xA376A0", Offset = "0xA366A0", VA = "0x180A376A0")]
	public void SetSelectedPinned(PinnedItemController newPinned, bool forceUpdate = false)
	{
	}

	// Token: 0x06001DBD RID: 7613 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DBD")]
	[Address(RVA = "0xA38280", Offset = "0xA37280", VA = "0x180A38280")]
	public void ControllerNavigate(Vector2 direction)
	{
	}

	// Token: 0x06001DBE RID: 7614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DBE")]
	[Address(RVA = "0xA39340", Offset = "0xA38340", VA = "0x180A39340")]
	public void ShoulderNavigate(bool right)
	{
	}

	// Token: 0x06001DBF RID: 7615 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DBF")]
	[Address(RVA = "0xA3A540", Offset = "0xA39540", VA = "0x180A3A540")]
	public PinnedItemController GetClosestPinnedToCentre()
	{
		return null;
	}

	// Token: 0x06001DC0 RID: 7616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DC0")]
	[Address(RVA = "0xA3A910", Offset = "0xA39910", VA = "0x180A3A910")]
	public void DisplayCorrectMurderQuestions()
	{
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DC1")]
	[Address(RVA = "0xA3AAE0", Offset = "0xA39AE0", VA = "0x180A3AAE0")]
	public void ValidateCase()
	{
	}

	// Token: 0x06001DC2 RID: 7618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DC2")]
	[Address(RVA = "0xA3AB60", Offset = "0xA39B60", VA = "0x180A3AB60")]
	public void AdvanceSideMission()
	{
	}

	// Token: 0x06001DC3 RID: 7619 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DC3")]
	[Address(RVA = "0xA3AC10", Offset = "0xA39C10", VA = "0x180A3AC10")]
	public void CompleteSideMission()
	{
	}

	// Token: 0x06001DC4 RID: 7620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DC4")]
	[Address(RVA = "0xA3ACA0", Offset = "0xA39CA0", VA = "0x180A3ACA0")]
	public CasePanelController()
	{
	}

	// Token: 0x06001DC5 RID: 7621 RVA: 0x0000D908 File Offset: 0x0000BB08
	[Token(Token = "0x6001DC5")]
	[Address(RVA = "0xA3B020", Offset = "0xA3A020", VA = "0x180A3B020")]
	private bool <OnContinueFactName>b__90_0(StringController item)
	{
		return default(bool);
	}

	// Token: 0x06001DC6 RID: 7622 RVA: 0x0000D920 File Offset: 0x0000BB20
	[Token(Token = "0x6001DC6")]
	[Address(RVA = "0xA3B1F0", Offset = "0xA3A1F0", VA = "0x180A3B1F0")]
	private bool <OnContinueFactName>b__90_1(Fact item2)
	{
		return default(bool);
	}

	// Token: 0x0400261F RID: 9759
	[Token(Token = "0x400261F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform corkBoard;

	// Token: 0x04002620 RID: 9760
	[Token(Token = "0x4002620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RectTransform pinnedContainer;

	// Token: 0x04002621 RID: 9761
	[Token(Token = "0x4002621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RectTransform stringContainer;

	// Token: 0x04002622 RID: 9762
	[Token(Token = "0x4002622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RectTransform caseButtonParent;

	// Token: 0x04002623 RID: 9763
	[Token(Token = "0x4002623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ButtonController newCaseButton;

	// Token: 0x04002624 RID: 9764
	[Token(Token = "0x4002624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ButtonController closeCaseButton;

	// Token: 0x04002625 RID: 9765
	[Token(Token = "0x4002625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RectTransform caseDisplayArea;

	// Token: 0x04002626 RID: 9766
	[Token(Token = "0x4002626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RectTransform closeCaseDisplayArea;

	// Token: 0x04002627 RID: 9767
	[Token(Token = "0x4002627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Sprite resolveSprite;

	// Token: 0x04002628 RID: 9768
	[Token(Token = "0x4002628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Sprite archiveSprite;

	// Token: 0x04002629 RID: 9769
	[Token(Token = "0x4002629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Sprite collectHandInSprite;

	// Token: 0x0400262A RID: 9770
	[Token(Token = "0x400262A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[NonSerialized]
	public Case activeCase;

	// Token: 0x0400262B RID: 9771
	[Token(Token = "0x400262B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<Case> activeCases;

	// Token: 0x0400262C RID: 9772
	[Token(Token = "0x400262C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<Case> archivedCases;

	// Token: 0x0400262D RID: 9773
	[Token(Token = "0x400262D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<CaseButtonController> spawnedCaseButtons;

	// Token: 0x0400262E RID: 9774
	[Token(Token = "0x400262E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool pickModeActive;

	// Token: 0x0400262F RID: 9775
	[Token(Token = "0x400262F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public InputFieldController pickForField;

	// Token: 0x04002630 RID: 9776
	[Token(Token = "0x4002630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool customLinkSelectionMode;

	// Token: 0x04002631 RID: 9777
	[Token(Token = "0x4002631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public PinnedItemController customStringLinkSelection;

	// Token: 0x04002632 RID: 9778
	[Token(Token = "0x4002632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public RectTransform customString;

	// Token: 0x04002633 RID: 9779
	[Token(Token = "0x4002633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private FactCustom newestCreatedFact;

	// Token: 0x04002634 RID: 9780
	[Token(Token = "0x4002634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<PinnedItemController> spawnedPins;

	// Token: 0x04002635 RID: 9781
	[Token(Token = "0x4002635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<StringController> spawnedStrings;

	// Token: 0x04002636 RID: 9782
	[Token(Token = "0x4002636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float caseCloseTransition;

	// Token: 0x04002637 RID: 9783
	[Token(Token = "0x4002637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public bool controllerMode;

	// Token: 0x04002638 RID: 9784
	[Token(Token = "0x4002638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public InfoWindow selectedWindow;

	// Token: 0x04002639 RID: 9785
	[Token(Token = "0x4002639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public PinnedItemController selectedPinned;

	// Token: 0x0400263A RID: 9786
	[Token(Token = "0x400263A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public ButtonController selectedTopBarButton;

	// Token: 0x0400263B RID: 9787
	[Token(Token = "0x400263B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public CasePanelController.ControllerSelectMode currentSelectMode;

	// Token: 0x0400263C RID: 9788
	[Token(Token = "0x400263C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public RectTransform upgradesSelect;

	// Token: 0x0400263D RID: 9789
	[Token(Token = "0x400263D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public JuiceController upgradesSelectJuice;

	// Token: 0x0400263E RID: 9790
	[Token(Token = "0x400263E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public RectTransform boardSelect;

	// Token: 0x0400263F RID: 9791
	[Token(Token = "0x400263F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public JuiceController boardSelectJuice;

	// Token: 0x04002640 RID: 9792
	[Token(Token = "0x4002640")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public RectTransform mapSelect;

	// Token: 0x04002641 RID: 9793
	[Token(Token = "0x4002641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public JuiceController mapSelectJuice;

	// Token: 0x04002642 RID: 9794
	[Token(Token = "0x4002642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public ButtonController notebookButton;

	// Token: 0x04002643 RID: 9795
	[Token(Token = "0x4002643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public ButtonController stickNoteButton;

	// Token: 0x04002644 RID: 9796
	[Token(Token = "0x4002644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public ButtonController selectNoCaseButton;

	// Token: 0x04002645 RID: 9797
	[Token(Token = "0x4002645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public ViewportMouseOver caseboardMO;

	// Token: 0x04002646 RID: 9798
	[Token(Token = "0x4002646")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public ControllerViewRectScroll caseboardScroll;

	// Token: 0x04002647 RID: 9799
	[Token(Token = "0x4002647")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public ViewportMouseOver mapMO;

	// Token: 0x04002648 RID: 9800
	[Token(Token = "0x4002648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public ControllerViewRectScroll mapScroll;

	// Token: 0x04002649 RID: 9801
	[Token(Token = "0x4002649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public ViewportMouseOver upgradesMO;

	// Token: 0x0400264A RID: 9802
	[Token(Token = "0x400264A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public ControllerViewRectScroll upgradesScroll;

	// Token: 0x0400264E RID: 9806
	[Token(Token = "0x400264E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CasePanelController _instance;

	// Token: 0x0400264F RID: 9807
	[Token(Token = "0x400264F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public int debugSideMissionIndex;

	// Token: 0x02000555 RID: 1365
	[Token(Token = "0x2000555")]
	public class StringConnection
	{
		// Token: 0x06001DC7 RID: 7623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC7")]
		[Address(RVA = "0xA3B200", Offset = "0xA3A200", VA = "0x180A3B200")]
		public StringConnection(PinnedItemController fromPinned, PinnedItemController toPinned)
		{
		}

		// Token: 0x04002650 RID: 9808
		[Token(Token = "0x4002650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PinnedItemController from;

		// Token: 0x04002651 RID: 9809
		[Token(Token = "0x4002651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PinnedItemController to;

		// Token: 0x04002652 RID: 9810
		[Token(Token = "0x4002652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Evidence.FactLink> links;

		// Token: 0x04002653 RID: 9811
		[Token(Token = "0x4002653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Fact> facts;
	}

	// Token: 0x02000556 RID: 1366
	[Token(Token = "0x2000556")]
	public enum ControllerSelectMode
	{
		// Token: 0x04002655 RID: 9813
		[Token(Token = "0x4002655")]
		caseBoard,
		// Token: 0x04002656 RID: 9814
		[Token(Token = "0x4002656")]
		windows
	}

	// Token: 0x02000557 RID: 1367
	// (Invoke) Token: 0x06001DC9 RID: 7625
	[Token(Token = "0x2000557")]
	public delegate void PinnedChange();

	// Token: 0x02000558 RID: 1368
	// (Invoke) Token: 0x06001DCD RID: 7629
	[Token(Token = "0x2000558")]
	public delegate void PinEvidence(Evidence evidence);

	// Token: 0x02000559 RID: 1369
	// (Invoke) Token: 0x06001DD1 RID: 7633
	[Token(Token = "0x2000559")]
	public delegate void UnpinEvidence(Evidence evidence);

	// Token: 0x0200055A RID: 1370
	[Token(Token = "0x200055A")]
	private sealed class <>c__DisplayClass81_0
	{
		// Token: 0x06001DD4 RID: 7636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass81_0()
		{
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x0000D938 File Offset: 0x0000BB38
		[Token(Token = "0x6001DD5")]
		[Address(RVA = "0x80E010", Offset = "0x80D010", VA = "0x18080E010")]
		internal bool <PinToCasePanel>b__0(PinnedItemController item)
		{
			return default(bool);
		}

		// Token: 0x04002657 RID: 9815
		[Token(Token = "0x4002657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Case.CaseElement newElement;
	}

	// Token: 0x0200055B RID: 1371
	[Token(Token = "0x200055B")]
	private sealed class <>c__DisplayClass82_0
	{
		// Token: 0x06001DD6 RID: 7638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass82_0()
		{
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x0000D950 File Offset: 0x0000BB50
		[Token(Token = "0x6001DD7")]
		[Address(RVA = "0xA3B440", Offset = "0xA3A440", VA = "0x180A3B440")]
		internal bool <UnPinFromCasePanel>b__0(Case.CaseElement item)
		{
			return default(bool);
		}

		// Token: 0x04002658 RID: 9816
		[Token(Token = "0x4002658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Evidence ev;
	}

	// Token: 0x0200055C RID: 1372
	[Token(Token = "0x200055C")]
	private sealed class <>c__DisplayClass84_0
	{
		// Token: 0x06001DD8 RID: 7640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass84_0()
		{
		}

		// Token: 0x04002659 RID: 9817
		[Token(Token = "0x4002659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PinnedItemController pic;
	}

	// Token: 0x0200055D RID: 1373
	[Token(Token = "0x200055D")]
	private sealed class <>c__DisplayClass84_1
	{
		// Token: 0x06001DD9 RID: 7641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DD9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass84_1()
		{
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x0000D968 File Offset: 0x0000BB68
		[Token(Token = "0x6001DDA")]
		[Address(RVA = "0xA3B4B0", Offset = "0xA3A4B0", VA = "0x180A3B4B0")]
		internal bool <UpdateStrings>b__0(CasePanelController.StringConnection item)
		{
			return default(bool);
		}

		// Token: 0x0400265A RID: 9818
		[Token(Token = "0x400265A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PinnedItemController otherPinned;

		// Token: 0x0400265B RID: 9819
		[Token(Token = "0x400265B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CasePanelController.<>c__DisplayClass84_0 CS$<>8__locals1;
	}

	// Token: 0x0200055E RID: 1374
	[Token(Token = "0x200055E")]
	private sealed class <>c__DisplayClass84_2
	{
		// Token: 0x06001DDB RID: 7643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DDB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass84_2()
		{
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x0000D980 File Offset: 0x0000BB80
		[Token(Token = "0x6001DDC")]
		[Address(RVA = "0xA3BA40", Offset = "0xA3AA40", VA = "0x180A3BA40")]
		internal bool <UpdateStrings>b__1(CasePanelController.StringConnection item)
		{
			return default(bool);
		}

		// Token: 0x0400265C RID: 9820
		[Token(Token = "0x400265C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StringController spawned;
	}

	// Token: 0x0200055F RID: 1375
	[Token(Token = "0x200055F")]
	private sealed class <CustomStringLink>d__86 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001DDD RID: 7645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DDD")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <CustomStringLink>d__86(int <>1__state)
		{
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DDE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x0000D998 File Offset: 0x0000BB98
		[Token(Token = "0x6001DDF")]
		[Address(RVA = "0xA3BA60", Offset = "0xA3AA60", VA = "0x180A3BA60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000EC")]
		private object Current
		{
			[Token(Token = "0x6001DE0")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE1")]
		[Address(RVA = "0xA3CB20", Offset = "0xA3BB20", VA = "0x180A3CB20", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000ED")]
		private object Current
		{
			[Token(Token = "0x6001DE2")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400265D RID: 9821
		[Token(Token = "0x400265D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400265E RID: 9822
		[Token(Token = "0x400265E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400265F RID: 9823
		[Token(Token = "0x400265F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CasePanelController <>4__this;

		// Token: 0x04002660 RID: 9824
		[Token(Token = "0x4002660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool holdButtonMode;

		// Token: 0x04002661 RID: 9825
		[Token(Token = "0x4002661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RectTransform <fromRect>5__2;

		// Token: 0x04002662 RID: 9826
		[Token(Token = "0x4002662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <waitFrames>5__3;
	}

	// Token: 0x02000560 RID: 1376
	[Token(Token = "0x2000560")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001DE4 RID: 7652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DE4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
		[Token(Token = "0x6001DE5")]
		[Address(RVA = "0xA3CC20", Offset = "0xA3BC20", VA = "0x180A3CC20")]
		internal bool <ShoulderNavigate>b__100_0(CaseButtonController item)
		{
			return default(bool);
		}

		// Token: 0x04002663 RID: 9827
		[Token(Token = "0x4002663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CasePanelController.<>c <>9;

		// Token: 0x04002664 RID: 9828
		[Token(Token = "0x4002664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<CaseButtonController> <>9__100_0;
	}
}
