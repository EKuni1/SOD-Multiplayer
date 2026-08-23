using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020005F9 RID: 1529
[Token(Token = "0x20005F9")]
public class InfoWindow : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x14000037 RID: 55
	// (add) Token: 0x06002186 RID: 8582 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002187 RID: 8583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000037")]
	public event InfoWindow.ResizedWindow OnResizedWindow
	{
		[Token(Token = "0x6002186")]
		[Address(RVA = "0xB0CA30", Offset = "0xB0BA30", VA = "0x180B0CA30")]
		add
		{
		}
		[Token(Token = "0x6002187")]
		[Address(RVA = "0xB0CB30", Offset = "0xB0BB30", VA = "0x180B0CB30")]
		remove
		{
		}
	}

	// Token: 0x14000038 RID: 56
	// (add) Token: 0x06002188 RID: 8584 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002189 RID: 8585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000038")]
	public event InfoWindow.WindowClosed OnWindowClosed
	{
		[Token(Token = "0x6002188")]
		[Address(RVA = "0xB0CC30", Offset = "0xB0BC30", VA = "0x180B0CC30")]
		add
		{
		}
		[Token(Token = "0x6002189")]
		[Address(RVA = "0xB0CD30", Offset = "0xB0BD30", VA = "0x180B0CD30")]
		remove
		{
		}
	}

	// Token: 0x14000039 RID: 57
	// (add) Token: 0x0600218A RID: 8586 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600218B RID: 8587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000039")]
	public event InfoWindow.WindowRefresh OnWindowRefresh
	{
		[Token(Token = "0x600218A")]
		[Address(RVA = "0xB0CE30", Offset = "0xB0BE30", VA = "0x180B0CE30")]
		add
		{
		}
		[Token(Token = "0x600218B")]
		[Address(RVA = "0xB0CF30", Offset = "0xB0BF30", VA = "0x180B0CF30")]
		remove
		{
		}
	}

	// Token: 0x1400003A RID: 58
	// (add) Token: 0x0600218C RID: 8588 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600218D RID: 8589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400003A")]
	public event InfoWindow.WorldInteractionStateUpdate OnUpdateWorldInteractionState
	{
		[Token(Token = "0x600218C")]
		[Address(RVA = "0xB0D030", Offset = "0xB0C030", VA = "0x180B0D030")]
		add
		{
		}
		[Token(Token = "0x600218D")]
		[Address(RVA = "0xB0D130", Offset = "0xB0C130", VA = "0x180B0D130")]
		remove
		{
		}
	}

	// Token: 0x0600218E RID: 8590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600218E")]
	[Address(RVA = "0xB0D230", Offset = "0xB0C230", VA = "0x180B0D230")]
	public void Setup(WindowStylePreset newPreset, Evidence newEv, List<Evidence.DataKey> newKeys, bool worldInteraction = false, [Optional] Interactable newInteractable, [Optional] Case newCase, [Optional] Case.CaseElement newForcePinnedCaseElement, bool passedDialogSuccess = true)
	{
	}

	// Token: 0x0600218F RID: 8591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600218F")]
	[Address(RVA = "0xB0EF00", Offset = "0xB0DF00", VA = "0x180B0EF00")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002190 RID: 8592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002190")]
	[Address(RVA = "0xB0F4A0", Offset = "0xB0E4A0", VA = "0x180B0F4A0")]
	public void SetWorldInteraction(bool val)
	{
	}

	// Token: 0x06002191 RID: 8593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002191")]
	[Address(RVA = "0xB0F7B0", Offset = "0xB0E7B0", VA = "0x180B0F7B0")]
	public void RefreshTakeButton()
	{
	}

	// Token: 0x06002192 RID: 8594 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002192")]
	[Address(RVA = "0xB0FE30", Offset = "0xB0EE30", VA = "0x180B0FE30")]
	public void CancelWorldInteractionButton()
	{
	}

	// Token: 0x06002193 RID: 8595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002193")]
	[Address(RVA = "0xB0FE50", Offset = "0xB0EE50", VA = "0x180B0FE50")]
	public void LoadTab(WindowTabPreset tabPreset)
	{
	}

	// Token: 0x06002194 RID: 8596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002194")]
	[Address(RVA = "0xB11360", Offset = "0xB10360", VA = "0x180B11360")]
	public void OnResizeWindow()
	{
	}

	// Token: 0x06002195 RID: 8597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002195")]
	[Address(RVA = "0xB11980", Offset = "0xB10980", VA = "0x180B11980")]
	public void UpdateTabButtons()
	{
	}

	// Token: 0x06002196 RID: 8598 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002196")]
	[Address(RVA = "0xB12070", Offset = "0xB11070", VA = "0x180B12070")]
	public void SetActiveContent(WindowContentController wcc)
	{
	}

	// Token: 0x06002197 RID: 8599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002197")]
	[Address(RVA = "0xB131E0", Offset = "0xB121E0", VA = "0x180B131E0")]
	public void InstanceUpdateComplete()
	{
	}

	// Token: 0x06002198 RID: 8600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002198")]
	[Address(RVA = "0xB13370", Offset = "0xB12370", VA = "0x180B13370")]
	public void UpdateEvidenceKeys()
	{
	}

	// Token: 0x06002199 RID: 8601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002199")]
	[Address(RVA = "0xB13990", Offset = "0xB12990", VA = "0x180B13990")]
	public void SetName(string newName)
	{
	}

	// Token: 0x0600219A RID: 8602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600219A")]
	[Address(RVA = "0xB13D50", Offset = "0xB12D50", VA = "0x180B13D50")]
	public void ResizeWindow(Vector2 sizeDelta)
	{
	}

	// Token: 0x0600219B RID: 8603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600219B")]
	[Address(RVA = "0xB14240", Offset = "0xB13240", VA = "0x180B14240")]
	public void CloseWindow(bool animate = true)
	{
	}

	// Token: 0x0600219C RID: 8604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600219C")]
	[Address(RVA = "0xB14CF0", Offset = "0xB13CF0", VA = "0x180B14CF0")]
	public void TogglePinned()
	{
	}

	// Token: 0x0600219D RID: 8605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600219D")]
	[Address(RVA = "0xB15040", Offset = "0xB14040", VA = "0x180B15040")]
	public void PinnedUpdateCheck()
	{
	}

	// Token: 0x0600219E RID: 8606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600219E")]
	[Address(RVA = "0xB15600", Offset = "0xB14600", VA = "0x180B15600")]
	public void OnWindowPinnedChange(bool isPinned, Case.CaseElement newCaseElement)
	{
	}

	// Token: 0x0600219F RID: 8607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600219F")]
	[Address(RVA = "0xB15A60", Offset = "0xB14A60", VA = "0x180B15A60")]
	public void SetClosable(bool newClosble)
	{
	}

	// Token: 0x060021A0 RID: 8608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021A0")]
	[Address(RVA = "0xB15C00", Offset = "0xB14C00", VA = "0x180B15C00")]
	public void SetAnchoredPosition(Vector2 newPos)
	{
	}

	// Token: 0x060021A1 RID: 8609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021A1")]
	[Address(RVA = "0xB16660", Offset = "0xB15660", VA = "0x180B16660")]
	public void SetPivot(Vector2 p)
	{
	}

	// Token: 0x060021A2 RID: 8610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021A2")]
	[Address(RVA = "0xB16A90", Offset = "0xB15A90", VA = "0x180B16A90", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x060021A3 RID: 8611 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021A3")]
	[Address(RVA = "0xB17070", Offset = "0xB16070", VA = "0x180B17070", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x060021A4 RID: 8612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021A4")]
	[Address(RVA = "0xB17370", Offset = "0xB16370", VA = "0x180B17370")]
	public void UpdatePinColour()
	{
	}

	// Token: 0x060021A5 RID: 8613 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021A5")]
	[Address(RVA = "0xB17470", Offset = "0xB16470", VA = "0x180B17470")]
	public void Rename()
	{
	}

	// Token: 0x060021A6 RID: 8614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021A6")]
	[Address(RVA = "0xB177A0", Offset = "0xB167A0", VA = "0x180B177A0")]
	public void OnEditName()
	{
	}

	// Token: 0x060021A7 RID: 8615 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021A7")]
	[Address(RVA = "0xB17950", Offset = "0xB16950", VA = "0x180B17950")]
	public void SetColourRed()
	{
	}

	// Token: 0x060021A8 RID: 8616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021A8")]
	[Address(RVA = "0xB179A0", Offset = "0xB169A0", VA = "0x180B179A0")]
	public void SetColourBlue()
	{
	}

	// Token: 0x060021A9 RID: 8617 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021A9")]
	[Address(RVA = "0xB179F0", Offset = "0xB169F0", VA = "0x180B179F0")]
	public void SetColourYellow()
	{
	}

	// Token: 0x060021AA RID: 8618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021AA")]
	[Address(RVA = "0xB17A40", Offset = "0xB16A40", VA = "0x180B17A40")]
	public void SetColourGreen()
	{
	}

	// Token: 0x060021AB RID: 8619 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021AB")]
	[Address(RVA = "0xB17A90", Offset = "0xB16A90", VA = "0x180B17A90")]
	public void SetColourPurple()
	{
	}

	// Token: 0x060021AC RID: 8620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021AC")]
	[Address(RVA = "0xB17AE0", Offset = "0xB16AE0", VA = "0x180B17AE0")]
	public void SetColourWhite()
	{
	}

	// Token: 0x060021AD RID: 8621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021AD")]
	[Address(RVA = "0xB17B30", Offset = "0xB16B30", VA = "0x180B17B30")]
	public void SetColourBlack()
	{
	}

	// Token: 0x060021AE RID: 8622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021AE")]
	[Address(RVA = "0xB17B80", Offset = "0xB16B80", VA = "0x180B17B80")]
	public void SetSelected(bool val)
	{
	}

	// Token: 0x060021AF RID: 8623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021AF")]
	[Address(RVA = "0xB17E30", Offset = "0xB16E30", VA = "0x180B17E30")]
	public void UpdateControllerSelected()
	{
	}

	// Token: 0x060021B0 RID: 8624 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021B0")]
	[Address(RVA = "0xB17FF0", Offset = "0xB16FF0", VA = "0x180B17FF0")]
	public void UpdateControllerNavigationEndOfFrame()
	{
	}

	// Token: 0x060021B1 RID: 8625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021B1")]
	[Address(RVA = "0xB18100", Offset = "0xB17100", VA = "0x180B18100")]
	public void OnClearTextButton()
	{
	}

	// Token: 0x060021B2 RID: 8626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021B2")]
	[Address(RVA = "0xB18960", Offset = "0xB17960", VA = "0x180B18960")]
	public void OnTakeItemButton()
	{
	}

	// Token: 0x060021B3 RID: 8627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021B3")]
	[Address(RVA = "0xB18C10", Offset = "0xB17C10", VA = "0x180B18C10")]
	public void OnTakeConfirm()
	{
	}

	// Token: 0x060021B4 RID: 8628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021B4")]
	[Address(RVA = "0xB193C0", Offset = "0xB183C0", VA = "0x180B193C0")]
	public void OnTakeCancel()
	{
	}

	// Token: 0x060021B5 RID: 8629 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60021B5")]
	[Address(RVA = "0xB19520", Offset = "0xB18520", VA = "0x180B19520")]
	private IEnumerator UpdateControllerNavigation()
	{
		return null;
	}

	// Token: 0x060021B6 RID: 8630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021B6")]
	[Address(RVA = "0xB195C0", Offset = "0xB185C0", VA = "0x180B195C0")]
	public void ExecuteUpdateControllerNavigation()
	{
	}

	// Token: 0x060021B7 RID: 8631 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021B7")]
	[Address(RVA = "0xB19850", Offset = "0xB18850", VA = "0x180B19850")]
	public void ExecuteKeyMerge()
	{
	}

	// Token: 0x060021B8 RID: 8632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021B8")]
	[Address(RVA = "0xB19890", Offset = "0xB18890", VA = "0x180B19890")]
	public void SpawnFingerprintOwner()
	{
	}

	// Token: 0x060021B9 RID: 8633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021B9")]
	[Address(RVA = "0xB19980", Offset = "0xB18980", VA = "0x180B19980")]
	public void RestoreAnchoredPosition()
	{
	}

	// Token: 0x060021BA RID: 8634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021BA")]
	[Address(RVA = "0xB199A0", Offset = "0xB189A0", VA = "0x180B199A0")]
	public InfoWindow()
	{
	}

	// Token: 0x060021BB RID: 8635 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
	[Token(Token = "0x60021BB")]
	[Address(RVA = "0xB19CD0", Offset = "0xB18CD0", VA = "0x180B19CD0")]
	private bool <PinnedUpdateCheck>b__94_0(Case.CaseElement item)
	{
		return default(bool);
	}

	// Token: 0x04002B3F RID: 11071
	[Token(Token = "0x4002B3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public WindowStylePreset preset;

	// Token: 0x04002B40 RID: 11072
	[Token(Token = "0x4002B40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Canvas windowCanvas;

	// Token: 0x04002B41 RID: 11073
	[Token(Token = "0x4002B41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public CanvasGroup windowCanvasGroup;

	// Token: 0x04002B42 RID: 11074
	[Token(Token = "0x4002B42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Canvas contentConvas;

	// Token: 0x04002B43 RID: 11075
	[Token(Token = "0x4002B43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CanvasGroup contentCanvasGroup;

	// Token: 0x04002B44 RID: 11076
	[Token(Token = "0x4002B44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform background;

	// Token: 0x04002B45 RID: 11077
	[Token(Token = "0x4002B45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI titleText;

	// Token: 0x04002B46 RID: 11078
	[Token(Token = "0x4002B46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RectTransform rect;

	// Token: 0x04002B47 RID: 11079
	[Token(Token = "0x4002B47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ResizePanel[] resizeZones;

	// Token: 0x04002B48 RID: 11080
	[Token(Token = "0x4002B48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public CustomScrollRect scrollRect;

	// Token: 0x04002B49 RID: 11081
	[Token(Token = "0x4002B49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject tabBar;

	// Token: 0x04002B4A RID: 11082
	[Token(Token = "0x4002B4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonController closeButton;

	// Token: 0x04002B4B RID: 11083
	[Token(Token = "0x4002B4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public PinFolderButtonController pinButton;

	// Token: 0x04002B4C RID: 11084
	[Token(Token = "0x4002B4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ItemController item;

	// Token: 0x04002B4D RID: 11085
	[Token(Token = "0x4002B4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public WindowContentController activeContent;

	// Token: 0x04002B4E RID: 11086
	[Token(Token = "0x4002B4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RectTransform contentRect;

	// Token: 0x04002B4F RID: 11087
	[Token(Token = "0x4002B4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Scrollbar horzScrollBar;

	// Token: 0x04002B50 RID: 11088
	[Token(Token = "0x4002B50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Scrollbar vertScrollBar;

	// Token: 0x04002B51 RID: 11089
	[Token(Token = "0x4002B51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RectTransform activeTabRect;

	// Token: 0x04002B52 RID: 11090
	[Token(Token = "0x4002B52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public RectTransform pageRect;

	// Token: 0x04002B53 RID: 11091
	[Token(Token = "0x4002B53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image typeIcon;

	// Token: 0x04002B54 RID: 11092
	[Token(Token = "0x4002B54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Image closeButtonIcon;

	// Token: 0x04002B55 RID: 11093
	[Token(Token = "0x4002B55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public RectTransform dragZone;

	// Token: 0x04002B56 RID: 11094
	[Token(Token = "0x4002B56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public RectTransform controllerSelect;

	// Token: 0x04002B57 RID: 11095
	[Token(Token = "0x4002B57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public JuiceController controllerSelectJuice;

	// Token: 0x04002B58 RID: 11096
	[Token(Token = "0x4002B58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public ControllerViewRectScroll controllerScrollView;

	// Token: 0x04002B59 RID: 11097
	[Token(Token = "0x4002B59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public RectTransform interactionIconRect;

	// Token: 0x04002B5A RID: 11098
	[Token(Token = "0x4002B5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public ButtonController clearTextButton;

	// Token: 0x04002B5B RID: 11099
	[Token(Token = "0x4002B5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public ButtonController takeItemButton;

	// Token: 0x04002B5C RID: 11100
	[Token(Token = "0x4002B5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool closable;

	// Token: 0x04002B5D RID: 11101
	[Token(Token = "0x4002B5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
	public bool pinnable;

	// Token: 0x04002B5E RID: 11102
	[Token(Token = "0x4002B5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x102")]
	public bool pinned;

	// Token: 0x04002B5F RID: 11103
	[Token(Token = "0x4002B5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x103")]
	public bool selected;

	// Token: 0x04002B60 RID: 11104
	[Token(Token = "0x4002B60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[NonSerialized]
	public Case.CaseElement currentPinnedCaseElement;

	// Token: 0x04002B61 RID: 11105
	[Token(Token = "0x4002B61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[NonSerialized]
	public Case.CaseElement forcedPinnedCaseElement;

	// Token: 0x04002B62 RID: 11106
	[Token(Token = "0x4002B62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public bool isOver;

	// Token: 0x04002B63 RID: 11107
	[Token(Token = "0x4002B63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
	public bool isWorldInteraction;

	// Token: 0x04002B64 RID: 11108
	[Token(Token = "0x4002B64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11A")]
	private bool updateNav;

	// Token: 0x04002B65 RID: 11109
	[Token(Token = "0x4002B65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11B")]
	public bool forceDisablePin;

	// Token: 0x04002B66 RID: 11110
	[Token(Token = "0x4002B66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public bool forceDisableClose;

	// Token: 0x04002B67 RID: 11111
	[Token(Token = "0x4002B67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
	public bool dialogSuccess;

	// Token: 0x04002B68 RID: 11112
	[Token(Token = "0x4002B68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Sprite iconLarge;

	// Token: 0x04002B69 RID: 11113
	[Token(Token = "0x4002B69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public InterfaceControls.EvidenceColours evColour;

	// Token: 0x04002B6A RID: 11114
	[Token(Token = "0x4002B6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Image pinOverlay;

	// Token: 0x04002B6B RID: 11115
	[Token(Token = "0x4002B6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public Image pinColour;

	// Token: 0x04002B6C RID: 11116
	[Token(Token = "0x4002B6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Image pinColourPressed;

	// Token: 0x04002B6D RID: 11117
	[Token(Token = "0x4002B6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Color pinColourActual;

	// Token: 0x04002B6E RID: 11118
	[Token(Token = "0x4002B6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Color baseColour;

	// Token: 0x04002B6F RID: 11119
	[Token(Token = "0x4002B6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Color flashColour;

	// Token: 0x04002B70 RID: 11120
	[Token(Token = "0x4002B70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public Color borderColour;

	// Token: 0x04002B71 RID: 11121
	[Token(Token = "0x4002B71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public bool resizable;

	// Token: 0x04002B72 RID: 11122
	[Token(Token = "0x4002B72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	public Vector2 defaultSize;

	// Token: 0x04002B73 RID: 11123
	[Token(Token = "0x4002B73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	public float centringTollerance;

	// Token: 0x04002B74 RID: 11124
	[Token(Token = "0x4002B74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public Evidence passedEvidence;

	// Token: 0x04002B75 RID: 11125
	[Token(Token = "0x4002B75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public List<Evidence.DataKey> passedKeys;

	// Token: 0x04002B76 RID: 11126
	[Token(Token = "0x4002B76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public List<Evidence.DataKey> evidenceKeys;

	// Token: 0x04002B77 RID: 11127
	[Token(Token = "0x4002B77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public List<WindowContentController> contentPages;

	// Token: 0x04002B78 RID: 11128
	[Token(Token = "0x4002B78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public List<WindowTabController> tabs;

	// Token: 0x04002B79 RID: 11129
	[Token(Token = "0x4002B79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	[NonSerialized]
	public Interactable passedInteractable;

	// Token: 0x04002B7A RID: 11130
	[Token(Token = "0x4002B7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	[NonSerialized]
	public Case passedCase;

	// Token: 0x04002B7B RID: 11131
	[Token(Token = "0x4002B7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public Evidence.DataKey debugKeyOne;

	// Token: 0x04002B7C RID: 11132
	[Token(Token = "0x4002B7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
	public Evidence.DataKey debugKeyTwo;

	// Token: 0x04002B7D RID: 11133
	[Token(Token = "0x4002B7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public Vector2 debugSetAnchoredPosition;

	// Token: 0x020005FA RID: 1530
	// (Invoke) Token: 0x060021BD RID: 8637
	[Token(Token = "0x20005FA")]
	public delegate void ResizedWindow();

	// Token: 0x020005FB RID: 1531
	// (Invoke) Token: 0x060021C1 RID: 8641
	[Token(Token = "0x20005FB")]
	public delegate void WindowClosed();

	// Token: 0x020005FC RID: 1532
	// (Invoke) Token: 0x060021C5 RID: 8645
	[Token(Token = "0x20005FC")]
	public delegate void WindowRefresh();

	// Token: 0x020005FD RID: 1533
	// (Invoke) Token: 0x060021C9 RID: 8649
	[Token(Token = "0x20005FD")]
	public delegate void WorldInteractionStateUpdate();

	// Token: 0x020005FE RID: 1534
	[Token(Token = "0x20005FE")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060021CD RID: 8653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		[Token(Token = "0x60021CE")]
		[Address(RVA = "0xB19DF0", Offset = "0xB18DF0", VA = "0x180B19DF0")]
		internal bool <Setup>b__79_0(WindowContentController item)
		{
			return default(bool);
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		[Token(Token = "0x60021CF")]
		[Address(RVA = "0xB19E60", Offset = "0xB18E60", VA = "0x180B19E60")]
		internal bool <OnDestroy>b__80_0(WindowTabController item)
		{
			return default(bool);
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		[Token(Token = "0x60021D0")]
		[Address(RVA = "0xB19E90", Offset = "0xB18E90", VA = "0x180B19E90")]
		internal bool <RefreshTakeButton>b__82_0(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x0000E100 File Offset: 0x0000C300
		[Token(Token = "0x60021D1")]
		[Address(RVA = "0xB19E90", Offset = "0xB18E90", VA = "0x180B19E90")]
		internal bool <RefreshTakeButton>b__82_1(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x0000E118 File Offset: 0x0000C318
		[Token(Token = "0x60021D2")]
		[Address(RVA = "0xB19E90", Offset = "0xB18E90", VA = "0x180B19E90")]
		internal bool <OnTakeConfirm>b__116_0(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x04002B82 RID: 11138
		[Token(Token = "0x4002B82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly InfoWindow.<>c <>9;

		// Token: 0x04002B83 RID: 11139
		[Token(Token = "0x4002B83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<WindowContentController> <>9__79_0;

		// Token: 0x04002B84 RID: 11140
		[Token(Token = "0x4002B84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<WindowTabController> <>9__80_0;

		// Token: 0x04002B85 RID: 11141
		[Token(Token = "0x4002B85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__82_0;

		// Token: 0x04002B86 RID: 11142
		[Token(Token = "0x4002B86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__82_1;

		// Token: 0x04002B87 RID: 11143
		[Token(Token = "0x4002B87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__116_0;
	}

	// Token: 0x020005FF RID: 1535
	[Token(Token = "0x20005FF")]
	private sealed class <>c__DisplayClass84_0
	{
		// Token: 0x060021D3 RID: 8659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass84_0()
		{
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D4")]
		[Address(RVA = "0xB19F30", Offset = "0xB18F30", VA = "0x180B19F30")]
		internal void <LoadTab>b__0()
		{
		}

		// Token: 0x04002B88 RID: 11144
		[Token(Token = "0x4002B88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InfoWindow <>4__this;

		// Token: 0x04002B89 RID: 11145
		[Token(Token = "0x4002B89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WindowContentController newWcc;
	}

	// Token: 0x02000600 RID: 1536
	[Token(Token = "0x2000600")]
	private sealed class <UpdateControllerNavigation>d__118 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060021D5 RID: 8661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D5")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <UpdateControllerNavigation>d__118(int <>1__state)
		{
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0000E130 File Offset: 0x0000C330
		[Token(Token = "0x60021D7")]
		[Address(RVA = "0xB19F60", Offset = "0xB18F60", VA = "0x180B19F60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700011A")]
		private object Current
		{
			[Token(Token = "0x60021D8")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021D9")]
		[Address(RVA = "0xB1A020", Offset = "0xB19020", VA = "0x180B1A020", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700011B")]
		private object Current
		{
			[Token(Token = "0x60021DA")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002B8A RID: 11146
		[Token(Token = "0x4002B8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002B8B RID: 11147
		[Token(Token = "0x4002B8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002B8C RID: 11148
		[Token(Token = "0x4002B8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InfoWindow <>4__this;

		// Token: 0x04002B8D RID: 11149
		[Token(Token = "0x4002B8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <waitedFrame>5__2;
	}
}
