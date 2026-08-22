using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020005D4 RID: 1492
[Token(Token = "0x20005D4")]
public class ButtonController : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x14000032 RID: 50
	// (add) Token: 0x060020B9 RID: 8377 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060020BA RID: 8378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000032")]
	public event ButtonController.Press OnPress
	{
		[Token(Token = "0x60020B9")]
		[Address(RVA = "0xAE7D90", Offset = "0xAE6D90", VA = "0x180AE7D90")]
		add
		{
		}
		[Token(Token = "0x60020BA")]
		[Address(RVA = "0xAE7E90", Offset = "0xAE6E90", VA = "0x180AE7E90")]
		remove
		{
		}
	}

	// Token: 0x14000033 RID: 51
	// (add) Token: 0x060020BB RID: 8379 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060020BC RID: 8380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000033")]
	public event ButtonController.HoverChange OnHoverChange
	{
		[Token(Token = "0x60020BB")]
		[Address(RVA = "0xAE7F90", Offset = "0xAE6F90", VA = "0x180AE7F90")]
		add
		{
		}
		[Token(Token = "0x60020BC")]
		[Address(RVA = "0xAE8090", Offset = "0xAE7090", VA = "0x180AE8090")]
		remove
		{
		}
	}

	// Token: 0x14000034 RID: 52
	// (add) Token: 0x060020BD RID: 8381 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060020BE RID: 8382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000034")]
	public event ButtonController.ButtonDown OnButtonDown
	{
		[Token(Token = "0x60020BD")]
		[Address(RVA = "0xAE8190", Offset = "0xAE7190", VA = "0x180AE8190")]
		add
		{
		}
		[Token(Token = "0x60020BE")]
		[Address(RVA = "0xAE8290", Offset = "0xAE7290", VA = "0x180AE8290")]
		remove
		{
		}
	}

	// Token: 0x14000035 RID: 53
	// (add) Token: 0x060020BF RID: 8383 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060020C0 RID: 8384 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000035")]
	public event ButtonController.ButtonUp OnButtonUp
	{
		[Token(Token = "0x60020BF")]
		[Address(RVA = "0xAE8390", Offset = "0xAE7390", VA = "0x180AE8390")]
		add
		{
		}
		[Token(Token = "0x60020C0")]
		[Address(RVA = "0xAE8490", Offset = "0xAE7490", VA = "0x180AE8490")]
		remove
		{
		}
	}

	// Token: 0x060020C1 RID: 8385 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020C1")]
	[Address(RVA = "0xAE8590", Offset = "0xAE7590", VA = "0x180AE8590", Slot = "9")]
	public virtual void SetupReferences()
	{
	}

	// Token: 0x060020C2 RID: 8386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020C2")]
	[Address(RVA = "0xAE9430", Offset = "0xAE8430", VA = "0x180AE9430")]
	private void Start()
	{
	}

	// Token: 0x060020C3 RID: 8387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020C3")]
	[Address(RVA = "0xAE9450", Offset = "0xAE8450", VA = "0x180AE9450", Slot = "10")]
	public virtual void VisualUpdate()
	{
	}

	// Token: 0x060020C4 RID: 8388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020C4")]
	[Address(RVA = "0xAE9470", Offset = "0xAE8470", VA = "0x180AE9470", Slot = "11")]
	public virtual void UpdateButtonText()
	{
	}

	// Token: 0x060020C5 RID: 8389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020C5")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "12")]
	public virtual void UpdateTooltipText()
	{
	}

	// Token: 0x060020C6 RID: 8390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020C6")]
	[Address(RVA = "0xAE9850", Offset = "0xAE8850", VA = "0x180AE9850", Slot = "13")]
	public virtual void SetInteractable(bool val)
	{
	}

	// Token: 0x060020C7 RID: 8391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020C7")]
	[Address(RVA = "0xAEA0F0", Offset = "0xAE90F0", VA = "0x180AEA0F0", Slot = "14")]
	public virtual void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x060020C8 RID: 8392 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020C8")]
	[Address(RVA = "0xAEB160", Offset = "0xAEA160", VA = "0x180AEB160", Slot = "15")]
	public virtual void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x060020C9 RID: 8393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020C9")]
	[Address(RVA = "0xAEB210", Offset = "0xAEA210", VA = "0x180AEB210", Slot = "16")]
	public virtual void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x060020CA RID: 8394 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020CA")]
	[Address(RVA = "0xAEB240", Offset = "0xAEA240", VA = "0x180AEB240", Slot = "17")]
	public virtual void OnLeftClick()
	{
	}

	// Token: 0x060020CB RID: 8395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020CB")]
	[Address(RVA = "0xAEB2E0", Offset = "0xAEA2E0", VA = "0x180AEB2E0", Slot = "18")]
	public virtual void OnRightClick()
	{
	}

	// Token: 0x060020CC RID: 8396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020CC")]
	[Address(RVA = "0xAEB2E0", Offset = "0xAEA2E0", VA = "0x180AEB2E0", Slot = "19")]
	public virtual void OnLeftDoubleClick()
	{
	}

	// Token: 0x060020CD RID: 8397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020CD")]
	[Address(RVA = "0xAEB2E0", Offset = "0xAEA2E0", VA = "0x180AEB2E0", Slot = "20")]
	public virtual void OnRightDoubleClick()
	{
	}

	// Token: 0x060020CE RID: 8398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020CE")]
	[Address(RVA = "0xAEB360", Offset = "0xAEA360", VA = "0x180AEB360", Slot = "21")]
	public virtual void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x060020CF RID: 8399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020CF")]
	[Address(RVA = "0xAEBB80", Offset = "0xAEAB80", VA = "0x180AEBB80", Slot = "22")]
	public virtual void OnSelect()
	{
	}

	// Token: 0x060020D0 RID: 8400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020D0")]
	[Address(RVA = "0xAECA40", Offset = "0xAEBA40", VA = "0x180AECA40")]
	public void AutoScroll()
	{
	}

	// Token: 0x060020D1 RID: 8401 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020D1")]
	[Address(RVA = "0xAECCE0", Offset = "0xAEBCE0", VA = "0x180AECCE0")]
	private void SendTextContentToVirtualKeyboard()
	{
	}

	// Token: 0x060020D2 RID: 8402 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020D2")]
	[Address(RVA = "0xAECD60", Offset = "0xAEBD60", VA = "0x180AECD60")]
	private void OnEnable()
	{
	}

	// Token: 0x060020D3 RID: 8403 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020D3")]
	[Address(RVA = "0xAED140", Offset = "0xAEC140", VA = "0x180AED140")]
	private void OnDisable()
	{
	}

	// Token: 0x060020D4 RID: 8404 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020D4")]
	[Address(RVA = "0xAED4E0", Offset = "0xAEC4E0", VA = "0x180AED4E0", Slot = "23")]
	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x060020D5 RID: 8405 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020D5")]
	[Address(RVA = "0xAED9A0", Offset = "0xAEC9A0", VA = "0x180AED9A0", Slot = "24")]
	public virtual void OnDeselect()
	{
	}

	// Token: 0x060020D6 RID: 8406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020D6")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "25")]
	public virtual void OnHoverStart()
	{
	}

	// Token: 0x060020D7 RID: 8407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020D7")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "26")]
	public virtual void OnHoverEnd()
	{
	}

	// Token: 0x060020D8 RID: 8408 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020D8")]
	[Address(RVA = "0xAEE340", Offset = "0xAED340", VA = "0x180AEE340", Slot = "27")]
	public virtual void SetButtonBaseColour(Color col)
	{
	}

	// Token: 0x060020D9 RID: 8409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020D9")]
	[Address(RVA = "0xAEE8B0", Offset = "0xAED8B0", VA = "0x180AEE8B0")]
	public void SetupAdditionalHighlight()
	{
	}

	// Token: 0x060020DA RID: 8410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020DA")]
	[Address(RVA = "0xAEEF70", Offset = "0xAEDF70", VA = "0x180AEEF70", Slot = "28")]
	public virtual void UpdateAdditionalHighlight()
	{
	}

	// Token: 0x060020DB RID: 8411 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020DB")]
	[Address(RVA = "0xAEF380", Offset = "0xAEE380", VA = "0x180AEF380")]
	public void SetForceAdditionalHighlight(bool newVal)
	{
	}

	// Token: 0x060020DC RID: 8412 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020DC")]
	[Address(RVA = "0xAEF3A0", Offset = "0xAEE3A0", VA = "0x180AEF3A0")]
	public void Flash(int repeat, Color flashColour)
	{
	}

	// Token: 0x060020DD RID: 8413 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60020DD")]
	[Address(RVA = "0xAEF470", Offset = "0xAEE470", VA = "0x180AEF470")]
	public IEnumerator FlashColour(int repeat, Color flashColour)
	{
		return null;
	}

	// Token: 0x060020DE RID: 8414 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60020DE")]
	[Address(RVA = "0xAEF540", Offset = "0xAEE540", VA = "0x180AEF540")]
	public IEnumerator RefreshNavEndOfFrame()
	{
		return null;
	}

	// Token: 0x060020DF RID: 8415 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020DF")]
	[Address(RVA = "0xAEF5E0", Offset = "0xAEE5E0", VA = "0x180AEF5E0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060020E0 RID: 8416 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020E0")]
	[Address(RVA = "0xAEF7F0", Offset = "0xAEE7F0", VA = "0x180AEF7F0")]
	public void RefreshAutomaticNavigation()
	{
	}

	// Token: 0x060020E1 RID: 8417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020E1")]
	[Address(RVA = "0xAEF840", Offset = "0xAEE840", VA = "0x180AEF840", Slot = "29")]
	public virtual void RefreshAutomaticNavigation(bool enableLeft, bool enableRight, bool enableUp, bool enableDown, bool includeInactive)
	{
	}

	// Token: 0x060020E2 RID: 8418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020E2")]
	[Address(RVA = "0xAF2010", Offset = "0xAF1010", VA = "0x180AF2010")]
	public ButtonController()
	{
	}

	// Token: 0x04002A4F RID: 10831
	[Token(Token = "0x4002A4F")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002A50 RID: 10832
	[Token(Token = "0x4002A50")]
	[FieldOffset(Offset = "0x20")]
	public Button button;

	// Token: 0x04002A51 RID: 10833
	[Token(Token = "0x4002A51")]
	[FieldOffset(Offset = "0x28")]
	public CanvasRenderer rend;

	// Token: 0x04002A52 RID: 10834
	[Token(Token = "0x4002A52")]
	[FieldOffset(Offset = "0x30")]
	public Image background;

	// Token: 0x04002A53 RID: 10835
	[Token(Token = "0x4002A53")]
	[FieldOffset(Offset = "0x38")]
	public Image icon;

	// Token: 0x04002A54 RID: 10836
	[Token(Token = "0x4002A54")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI text;

	// Token: 0x04002A55 RID: 10837
	[Token(Token = "0x4002A55")]
	[FieldOffset(Offset = "0x48")]
	public TooltipController tooltip;

	// Token: 0x04002A56 RID: 10838
	[Token(Token = "0x4002A56")]
	[FieldOffset(Offset = "0x50")]
	public JuiceController juice;

	// Token: 0x04002A57 RID: 10839
	[Token(Token = "0x4002A57")]
	[FieldOffset(Offset = "0x58")]
	public NotificationController notifications;

	// Token: 0x04002A58 RID: 10840
	[Token(Token = "0x4002A58")]
	[FieldOffset(Offset = "0x60")]
	[NonSerialized]
	public object genericReference;

	// Token: 0x04002A59 RID: 10841
	[Token(Token = "0x4002A59")]
	[FieldOffset(Offset = "0x68")]
	public InfoWindow parentWindow;

	// Token: 0x04002A5A RID: 10842
	[Token(Token = "0x4002A5A")]
	[FieldOffset(Offset = "0x70")]
	[NonSerialized]
	public Evidence windowOf;

	// Token: 0x04002A5B RID: 10843
	[Token(Token = "0x4002A5B")]
	[FieldOffset(Offset = "0x78")]
	public WindowTabController tabOf;

	// Token: 0x04002A5C RID: 10844
	[Token(Token = "0x4002A5C")]
	[FieldOffset(Offset = "0x80")]
	public RectTransform additionalHighlightRect;

	// Token: 0x04002A5D RID: 10845
	[Token(Token = "0x4002A5D")]
	[FieldOffset(Offset = "0x88")]
	public bool isOver;

	// Token: 0x04002A5E RID: 10846
	[Token(Token = "0x4002A5E")]
	[FieldOffset(Offset = "0x89")]
	public bool forceAdditionalHighlighted;

	// Token: 0x04002A5F RID: 10847
	[Token(Token = "0x4002A5F")]
	[FieldOffset(Offset = "0x8A")]
	public bool additionalHighlighted;

	// Token: 0x04002A60 RID: 10848
	[Token(Token = "0x4002A60")]
	[FieldOffset(Offset = "0x8B")]
	public bool interactable;

	// Token: 0x04002A61 RID: 10849
	[Token(Token = "0x4002A61")]
	[FieldOffset(Offset = "0x8C")]
	public bool setupReferences;

	// Token: 0x04002A62 RID: 10850
	[Token(Token = "0x4002A62")]
	[FieldOffset(Offset = "0x8D")]
	public bool isVirtualKeyboardCharacterButton;

	// Token: 0x04002A63 RID: 10851
	[Token(Token = "0x4002A63")]
	[FieldOffset(Offset = "0x90")]
	private float lastLeftClick;

	// Token: 0x04002A64 RID: 10852
	[Token(Token = "0x4002A64")]
	[FieldOffset(Offset = "0x94")]
	private float lastRightClick;

	// Token: 0x04002A65 RID: 10853
	[Token(Token = "0x4002A65")]
	[FieldOffset(Offset = "0x98")]
	public Color baseColour;

	// Token: 0x04002A66 RID: 10854
	[Token(Token = "0x4002A66")]
	[FieldOffset(Offset = "0xA8")]
	public bool scrollRectAutoScroll;

	// Token: 0x04002A67 RID: 10855
	[Token(Token = "0x4002A67")]
	[FieldOffset(Offset = "0xA9")]
	public bool scrollVertical;

	// Token: 0x04002A68 RID: 10856
	[Token(Token = "0x4002A68")]
	[FieldOffset(Offset = "0xAA")]
	public bool scrollHorizontal;

	// Token: 0x04002A69 RID: 10857
	[Token(Token = "0x4002A69")]
	[FieldOffset(Offset = "0xAB")]
	public bool findableForAutoNavigation;

	// Token: 0x04002A6A RID: 10858
	[Token(Token = "0x4002A6A")]
	[FieldOffset(Offset = "0xAC")]
	public bool refreshControllerNavigationOnSetup;

	// Token: 0x04002A6B RID: 10859
	[Token(Token = "0x4002A6B")]
	[FieldOffset(Offset = "0xAD")]
	public bool refreshControllerNavigationOnSelect;

	// Token: 0x04002A6C RID: 10860
	[Token(Token = "0x4002A6C")]
	[FieldOffset(Offset = "0xAE")]
	public bool refreshControllerNavigationOnPress;

	// Token: 0x04002A6D RID: 10861
	[Token(Token = "0x4002A6D")]
	[FieldOffset(Offset = "0xAF")]
	public bool includeInactiveSelectables;

	// Token: 0x04002A6E RID: 10862
	[Token(Token = "0x4002A6E")]
	[FieldOffset(Offset = "0xB0")]
	public int selectableSearchParentHierarchyThreshold;

	// Token: 0x04002A6F RID: 10863
	[Token(Token = "0x4002A6F")]
	[FieldOffset(Offset = "0xB4")]
	public bool isEvidenceWindowButton;

	// Token: 0x04002A70 RID: 10864
	[Token(Token = "0x4002A70")]
	[FieldOffset(Offset = "0xB5")]
	public bool allowLeftNavigation;

	// Token: 0x04002A71 RID: 10865
	[Token(Token = "0x4002A71")]
	[FieldOffset(Offset = "0xB6")]
	public bool allowRightNavigation;

	// Token: 0x04002A72 RID: 10866
	[Token(Token = "0x4002A72")]
	[FieldOffset(Offset = "0xB7")]
	public bool allowUpNavigation;

	// Token: 0x04002A73 RID: 10867
	[Token(Token = "0x4002A73")]
	[FieldOffset(Offset = "0xB8")]
	public bool allowDownNavigation;

	// Token: 0x04002A74 RID: 10868
	[Token(Token = "0x4002A74")]
	[FieldOffset(Offset = "0xB9")]
	public bool selectSaveGameObjectOnUp;

	// Token: 0x04002A75 RID: 10869
	[Token(Token = "0x4002A75")]
	[FieldOffset(Offset = "0xBA")]
	public bool preferForwardButtonOnRight;

	// Token: 0x04002A76 RID: 10870
	[Token(Token = "0x4002A76")]
	[FieldOffset(Offset = "0xBC")]
	public ButtonController.NavRectPoint thisNavRectPoint;

	// Token: 0x04002A77 RID: 10871
	[Token(Token = "0x4002A77")]
	[FieldOffset(Offset = "0xC0")]
	public ButtonController.NavRectPoint otherNavRectPoint;

	// Token: 0x04002A78 RID: 10872
	[Token(Token = "0x4002A78")]
	[FieldOffset(Offset = "0xC8")]
	public List<string> ignoreParentsNamed;

	// Token: 0x04002A79 RID: 10873
	[Token(Token = "0x4002A79")]
	[FieldOffset(Offset = "0xD0")]
	public bool secondaryIsRightClick;

	// Token: 0x04002A7A RID: 10874
	[Token(Token = "0x4002A7A")]
	[FieldOffset(Offset = "0xD8")]
	public List<ButtonController.PreferNav> preferNavRankings;

	// Token: 0x04002A7B RID: 10875
	[Token(Token = "0x4002A7B")]
	[FieldOffset(Offset = "0xE0")]
	public bool useAutomaticText;

	// Token: 0x04002A7C RID: 10876
	[Token(Token = "0x4002A7C")]
	[FieldOffset(Offset = "0xE8")]
	public string textDictionary;

	// Token: 0x04002A7D RID: 10877
	[Token(Token = "0x4002A7D")]
	[FieldOffset(Offset = "0xF0")]
	public string textReference;

	// Token: 0x04002A7E RID: 10878
	[Token(Token = "0x4002A7E")]
	[FieldOffset(Offset = "0xF8")]
	public Strings.Casing casing;

	// Token: 0x04002A7F RID: 10879
	[Token(Token = "0x4002A7F")]
	[FieldOffset(Offset = "0x100")]
	public string menuMouseoverReference;

	// Token: 0x04002A80 RID: 10880
	[Token(Token = "0x4002A80")]
	[FieldOffset(Offset = "0x108")]
	public float uninteractableTextAlpha;

	// Token: 0x04002A81 RID: 10881
	[Token(Token = "0x4002A81")]
	[FieldOffset(Offset = "0x10C")]
	public float interactableTextAlpha;

	// Token: 0x04002A82 RID: 10882
	[Token(Token = "0x4002A82")]
	[FieldOffset(Offset = "0x110")]
	public int defaultSelectionPriority;

	// Token: 0x04002A83 RID: 10883
	[Token(Token = "0x4002A83")]
	[FieldOffset(Offset = "0x114")]
	public bool useAdditionalHighlight;

	// Token: 0x04002A84 RID: 10884
	[Token(Token = "0x4002A84")]
	[FieldOffset(Offset = "0x118")]
	public GameObject additionalHighlightPrefab;

	// Token: 0x04002A85 RID: 10885
	[Token(Token = "0x4002A85")]
	[FieldOffset(Offset = "0x120")]
	public Color additionalHighlightColour;

	// Token: 0x04002A86 RID: 10886
	[Token(Token = "0x4002A86")]
	[FieldOffset(Offset = "0x130")]
	public Color additionalHighlightUninteractableColour;

	// Token: 0x04002A87 RID: 10887
	[Token(Token = "0x4002A87")]
	[FieldOffset(Offset = "0x140")]
	public bool additionalHighlightAtFront;

	// Token: 0x04002A88 RID: 10888
	[Token(Token = "0x4002A88")]
	[FieldOffset(Offset = "0x144")]
	public Vector4 additionalHighlightRectModifier;

	// Token: 0x04002A89 RID: 10889
	[Token(Token = "0x4002A89")]
	[FieldOffset(Offset = "0x158")]
	private Image additionalHImage;

	// Token: 0x04002A8A RID: 10890
	[Token(Token = "0x4002A8A")]
	[FieldOffset(Offset = "0x160")]
	public bool nudgeOnClick;

	// Token: 0x04002A8B RID: 10891
	[Token(Token = "0x4002A8B")]
	[FieldOffset(Offset = "0x161")]
	public bool glowOnHighlight;

	// Token: 0x04002A8C RID: 10892
	[Token(Token = "0x4002A8C")]
	[FieldOffset(Offset = "0x162")]
	public bool useGenericAudioSounds;

	// Token: 0x04002A8D RID: 10893
	[Token(Token = "0x4002A8D")]
	[FieldOffset(Offset = "0x164")]
	public ButtonController.ButtonAudioType buttonType;

	// Token: 0x04002A8E RID: 10894
	[Token(Token = "0x4002A8E")]
	[FieldOffset(Offset = "0x168")]
	public AudioEvent buttonDown;

	// Token: 0x04002A8F RID: 10895
	[Token(Token = "0x4002A8F")]
	[FieldOffset(Offset = "0x170")]
	public AudioEvent clickPrimary;

	// Token: 0x04002A90 RID: 10896
	[Token(Token = "0x4002A90")]
	[FieldOffset(Offset = "0x178")]
	public AudioEvent clickSecondary;

	// Token: 0x04002A91 RID: 10897
	[Token(Token = "0x4002A91")]
	[FieldOffset(Offset = "0x180")]
	public AudioEvent rightClick;

	// Token: 0x020005D5 RID: 1493
	[Token(Token = "0x20005D5")]
	public enum NavRectPoint
	{
		// Token: 0x04002A97 RID: 10903
		[Token(Token = "0x4002A97")]
		center,
		// Token: 0x04002A98 RID: 10904
		[Token(Token = "0x4002A98")]
		min,
		// Token: 0x04002A99 RID: 10905
		[Token(Token = "0x4002A99")]
		max
	}

	// Token: 0x020005D6 RID: 1494
	[Token(Token = "0x20005D6")]
	public enum ButtonAudioType
	{
		// Token: 0x04002A9B RID: 10907
		[Token(Token = "0x4002A9B")]
		normal,
		// Token: 0x04002A9C RID: 10908
		[Token(Token = "0x4002A9C")]
		forward,
		// Token: 0x04002A9D RID: 10909
		[Token(Token = "0x4002A9D")]
		back,
		// Token: 0x04002A9E RID: 10910
		[Token(Token = "0x4002A9E")]
		tickBox
	}

	// Token: 0x020005D7 RID: 1495
	[Token(Token = "0x20005D7")]
	public class NavRanking
	{
		// Token: 0x060020E3 RID: 8419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public NavRanking()
		{
		}

		// Token: 0x04002A9F RID: 10911
		[Token(Token = "0x4002A9F")]
		[FieldOffset(Offset = "0x10")]
		public ButtonController button;

		// Token: 0x04002AA0 RID: 10912
		[Token(Token = "0x4002AA0")]
		[FieldOffset(Offset = "0x18")]
		public float score;

		// Token: 0x04002AA1 RID: 10913
		[Token(Token = "0x4002AA1")]
		[FieldOffset(Offset = "0x1C")]
		public int dir;
	}

	// Token: 0x020005D8 RID: 1496
	[Token(Token = "0x20005D8")]
	[Serializable]
	public class PreferNav
	{
		// Token: 0x060020E4 RID: 8420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public PreferNav()
		{
		}

		// Token: 0x04002AA2 RID: 10914
		[Token(Token = "0x4002AA2")]
		[FieldOffset(Offset = "0x10")]
		public ButtonController button;

		// Token: 0x04002AA3 RID: 10915
		[Token(Token = "0x4002AA3")]
		[FieldOffset(Offset = "0x18")]
		public float score;

		// Token: 0x04002AA4 RID: 10916
		[Token(Token = "0x4002AA4")]
		[FieldOffset(Offset = "0x1C")]
		public ButtonController.NavDir dir;
	}

	// Token: 0x020005D9 RID: 1497
	[Token(Token = "0x20005D9")]
	public enum NavDir
	{
		// Token: 0x04002AA6 RID: 10918
		[Token(Token = "0x4002AA6")]
		up,
		// Token: 0x04002AA7 RID: 10919
		[Token(Token = "0x4002AA7")]
		down,
		// Token: 0x04002AA8 RID: 10920
		[Token(Token = "0x4002AA8")]
		left,
		// Token: 0x04002AA9 RID: 10921
		[Token(Token = "0x4002AA9")]
		right
	}

	// Token: 0x020005DA RID: 1498
	// (Invoke) Token: 0x060020E6 RID: 8422
	[Token(Token = "0x20005DA")]
	public delegate void Press(ButtonController thisButton);

	// Token: 0x020005DB RID: 1499
	// (Invoke) Token: 0x060020EA RID: 8426
	[Token(Token = "0x20005DB")]
	public delegate void HoverChange(ButtonController thisButton, bool mouseOver);

	// Token: 0x020005DC RID: 1500
	// (Invoke) Token: 0x060020EE RID: 8430
	[Token(Token = "0x20005DC")]
	public delegate void ButtonDown(ButtonController thisButton);

	// Token: 0x020005DD RID: 1501
	// (Invoke) Token: 0x060020F2 RID: 8434
	[Token(Token = "0x20005DD")]
	public delegate void ButtonUp(ButtonController thisButton);

	// Token: 0x020005DE RID: 1502
	[Token(Token = "0x20005DE")]
	private sealed class <FlashColour>d__116 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060020F5 RID: 8437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <FlashColour>d__116(int <>1__state)
		{
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x0000DFF8 File Offset: 0x0000C1F8
		[Token(Token = "0x60020F7")]
		[Address(RVA = "0xAF2550", Offset = "0xAF1550", VA = "0x180AF2550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000116")]
		private object Current
		{
			[Token(Token = "0x60020F8")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F9")]
		[Address(RVA = "0xAF27A0", Offset = "0xAF17A0", VA = "0x180AF27A0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000117")]
		private object Current
		{
			[Token(Token = "0x60020FA")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002AAA RID: 10922
		[Token(Token = "0x4002AAA")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002AAB RID: 10923
		[Token(Token = "0x4002AAB")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002AAC RID: 10924
		[Token(Token = "0x4002AAC")]
		[FieldOffset(Offset = "0x20")]
		public ButtonController <>4__this;

		// Token: 0x04002AAD RID: 10925
		[Token(Token = "0x4002AAD")]
		[FieldOffset(Offset = "0x28")]
		public Color flashColour;

		// Token: 0x04002AAE RID: 10926
		[Token(Token = "0x4002AAE")]
		[FieldOffset(Offset = "0x38")]
		public int repeat;

		// Token: 0x04002AAF RID: 10927
		[Token(Token = "0x4002AAF")]
		[FieldOffset(Offset = "0x3C")]
		private int <cycle>5__2;

		// Token: 0x04002AB0 RID: 10928
		[Token(Token = "0x4002AB0")]
		[FieldOffset(Offset = "0x40")]
		private float <progress>5__3;

		// Token: 0x04002AB1 RID: 10929
		[Token(Token = "0x4002AB1")]
		[FieldOffset(Offset = "0x44")]
		private float <speed>5__4;
	}

	// Token: 0x020005DF RID: 1503
	[Token(Token = "0x20005DF")]
	private sealed class <RefreshNavEndOfFrame>d__117 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060020FB RID: 8443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FB")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <RefreshNavEndOfFrame>d__117(int <>1__state)
		{
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x0000E010 File Offset: 0x0000C210
		[Token(Token = "0x60020FD")]
		[Address(RVA = "0xAF27F0", Offset = "0xAF17F0", VA = "0x180AF27F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000118")]
		private object Current
		{
			[Token(Token = "0x60020FE")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FF")]
		[Address(RVA = "0xAF28E0", Offset = "0xAF18E0", VA = "0x180AF28E0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06002100 RID: 8448 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000119")]
		private object Current
		{
			[Token(Token = "0x6002100")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002AB2 RID: 10930
		[Token(Token = "0x4002AB2")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002AB3 RID: 10931
		[Token(Token = "0x4002AB3")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002AB4 RID: 10932
		[Token(Token = "0x4002AB4")]
		[FieldOffset(Offset = "0x20")]
		public ButtonController <>4__this;

		// Token: 0x04002AB5 RID: 10933
		[Token(Token = "0x4002AB5")]
		[FieldOffset(Offset = "0x28")]
		private bool <waited>5__2;
	}

	// Token: 0x020005E0 RID: 1504
	[Token(Token = "0x20005E0")]
	private sealed class <>c__DisplayClass120_0
	{
		// Token: 0x06002101 RID: 8449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002101")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass120_0()
		{
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x0000E028 File Offset: 0x0000C228
		[Token(Token = "0x6002102")]
		[Address(RVA = "0xAF2930", Offset = "0xAF1930", VA = "0x180AF2930")]
		internal bool <RefreshAutomaticNavigation>b__1(ButtonController.PreferNav item)
		{
			return default(bool);
		}

		// Token: 0x04002AB6 RID: 10934
		[Token(Token = "0x4002AB6")]
		[FieldOffset(Offset = "0x10")]
		public ButtonController.NavRanking nr;
	}

	// Token: 0x020005E1 RID: 1505
	[Token(Token = "0x20005E1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002104 RID: 8452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002104")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x0000E040 File Offset: 0x0000C240
		[Token(Token = "0x6002105")]
		[Address(RVA = "0x874FD0", Offset = "0x873FD0", VA = "0x180874FD0")]
		internal int <RefreshAutomaticNavigation>b__120_0(ButtonController.NavRanking p1, ButtonController.NavRanking p2)
		{
			return 0;
		}

		// Token: 0x04002AB7 RID: 10935
		[Token(Token = "0x4002AB7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ButtonController.<>c <>9;

		// Token: 0x04002AB8 RID: 10936
		[Token(Token = "0x4002AB8")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<ButtonController.NavRanking> <>9__120_0;
	}
}
