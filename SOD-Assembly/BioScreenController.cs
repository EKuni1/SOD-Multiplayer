using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200065B RID: 1627
[Token(Token = "0x200065B")]
public class BioScreenController : MonoBehaviour
{
	// Token: 0x14000049 RID: 73
	// (add) Token: 0x060023DC RID: 9180 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060023DD RID: 9181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000049")]
	public event BioScreenController.InventoryOpenChange OnInventoryOpenChange
	{
		[Token(Token = "0x60023DC")]
		[Address(RVA = "0xB74650", Offset = "0xB73650", VA = "0x180B74650")]
		add
		{
		}
		[Token(Token = "0x60023DD")]
		[Address(RVA = "0xB74750", Offset = "0xB73750", VA = "0x180B74750")]
		remove
		{
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x060023DE RID: 9182 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000126")]
	public static BioScreenController Instance
	{
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0xB74850", Offset = "0xB73850", VA = "0x180B74850")]
		get
		{
			return null;
		}
	}

	// Token: 0x060023DF RID: 9183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023DF")]
	[Address(RVA = "0xB74890", Offset = "0xB73890", VA = "0x180B74890")]
	private void Awake()
	{
	}

	// Token: 0x060023E0 RID: 9184 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023E0")]
	[Address(RVA = "0xB74E00", Offset = "0xB73E00", VA = "0x180B74E00")]
	private void OnDestroy()
	{
	}

	// Token: 0x060023E1 RID: 9185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023E1")]
	[Address(RVA = "0xB75010", Offset = "0xB74010", VA = "0x180B75010")]
	private void Start()
	{
	}

	// Token: 0x060023E2 RID: 9186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023E2")]
	[Address(RVA = "0xB752E0", Offset = "0xB742E0", VA = "0x180B752E0")]
	public void SetMaxSocialCreditLevels(int newMax)
	{
	}

	// Token: 0x060023E3 RID: 9187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023E3")]
	[Address(RVA = "0xB76500", Offset = "0xB75500", VA = "0x180B76500")]
	public void SetInventoryOpen(bool val, bool forceUpdate, bool resumeGame = true)
	{
	}

	// Token: 0x060023E4 RID: 9188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023E4")]
	[Address(RVA = "0xB76FA0", Offset = "0xB75FA0", VA = "0x180B76FA0")]
	public void HoverSlot(FirstPersonItemController.InventorySlot newSlot)
	{
	}

	// Token: 0x060023E5 RID: 9189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023E5")]
	[Address(RVA = "0xB773A0", Offset = "0xB763A0", VA = "0x180B773A0")]
	public void SelectSlot(FirstPersonItemController.InventorySlot newSlot, bool closeInventory = false, bool forceUpdate = false, bool cancelAutoUmbrella = true)
	{
	}

	// Token: 0x060023E6 RID: 9190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023E6")]
	[Address(RVA = "0xB77CA0", Offset = "0xB76CA0", VA = "0x180B77CA0")]
	public void UpdateButtons()
	{
	}

	// Token: 0x060023E7 RID: 9191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023E7")]
	[Address(RVA = "0xB77FF0", Offset = "0xB76FF0", VA = "0x180B77FF0")]
	public void UpdateDecorEditButton()
	{
	}

	// Token: 0x060023E8 RID: 9192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023E8")]
	[Address(RVA = "0xB78430", Offset = "0xB77430", VA = "0x180B78430")]
	public void UpdateSummary()
	{
	}

	// Token: 0x060023E9 RID: 9193 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60023E9")]
	[Address(RVA = "0xB787B0", Offset = "0xB777B0", VA = "0x180B787B0")]
	public InventorySquareController SpawnSlotObject(FirstPersonItemController.InventorySlot slot)
	{
		return null;
	}

	// Token: 0x060023EA RID: 9194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023EA")]
	[Address(RVA = "0xB78890", Offset = "0xB77890", VA = "0x180B78890")]
	public void OnChangePoints(bool allowLevelChangeDisplay)
	{
	}

	// Token: 0x060023EB RID: 9195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023EB")]
	[Address(RVA = "0xB79A30", Offset = "0xB78A30", VA = "0x180B79A30")]
	public void UpdateSocialCreditPerks()
	{
	}

	// Token: 0x060023EC RID: 9196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023EC")]
	[Address(RVA = "0xB7A420", Offset = "0xB79420", VA = "0x180B7A420")]
	public void NewSocialCreditPerk(SocialControls.SocialCreditBuff newPerk, bool allowDisplay = true)
	{
	}

	// Token: 0x060023ED RID: 9197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023ED")]
	[Address(RVA = "0xB7A630", Offset = "0xB79630", VA = "0x180B7A630")]
	public void UpdateLevelBlipsWithPerkTooltips()
	{
	}

	// Token: 0x060023EE RID: 9198 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60023EE")]
	[Address(RVA = "0xB7A920", Offset = "0xB79920", VA = "0x180B7A920")]
	private IEnumerator DisplayNewPerk(SocialControls.SocialCreditBuff newPerk, float delayTime)
	{
		return null;
	}

	// Token: 0x060023EF RID: 9199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023EF")]
	[Address(RVA = "0xB7A9D0", Offset = "0xB799D0", VA = "0x180B7A9D0")]
	private void Update()
	{
	}

	// Token: 0x060023F0 RID: 9200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023F0")]
	[Address(RVA = "0xB7CF90", Offset = "0xB7BF90", VA = "0x180B7CF90")]
	public void AddSocialCredit()
	{
	}

	// Token: 0x060023F1 RID: 9201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023F1")]
	[Address(RVA = "0xB7D060", Offset = "0xB7C060", VA = "0x180B7D060")]
	public void DecorEditButton()
	{
	}

	// Token: 0x060023F2 RID: 9202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023F2")]
	[Address(RVA = "0xB7D390", Offset = "0xB7C390", VA = "0x180B7D390")]
	public void DropButton()
	{
	}

	// Token: 0x060023F3 RID: 9203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023F3")]
	[Address(RVA = "0xB7D400", Offset = "0xB7C400", VA = "0x180B7D400")]
	public void InspectButton()
	{
	}

	// Token: 0x060023F4 RID: 9204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023F4")]
	[Address(RVA = "0xB7D580", Offset = "0xB7C580", VA = "0x180B7D580")]
	public void ScanButton()
	{
	}

	// Token: 0x060023F5 RID: 9205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023F5")]
	[Address(RVA = "0xB7D6C0", Offset = "0xB7C6C0", VA = "0x180B7D6C0")]
	public void OnScanComplete(Interactable scanCompleteOn)
	{
	}

	// Token: 0x060023F6 RID: 9206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023F6")]
	[Address(RVA = "0xB7E4A0", Offset = "0xB7D4A0", VA = "0x180B7E4A0")]
	public void EquipButton()
	{
	}

	// Token: 0x060023F7 RID: 9207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023F7")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void MoreOptionsButton()
	{
	}

	// Token: 0x060023F8 RID: 9208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023F8")]
	[Address(RVA = "0xB7E4E0", Offset = "0xB7D4E0", VA = "0x180B7E4E0")]
	public void CloseButton()
	{
	}

	// Token: 0x060023F9 RID: 9209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023F9")]
	[Address(RVA = "0xB7E500", Offset = "0xB7D500", VA = "0x180B7E500")]
	public BioScreenController()
	{
	}

	// Token: 0x04002DD4 RID: 11732
	[Token(Token = "0x4002DD4")]
	[FieldOffset(Offset = "0x18")]
	public Canvas canvasParent;

	// Token: 0x04002DD5 RID: 11733
	[Token(Token = "0x4002DD5")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform socialCreditDisplayParent;

	// Token: 0x04002DD6 RID: 11734
	[Token(Token = "0x4002DD6")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform levelBarBlipParent;

	// Token: 0x04002DD7 RID: 11735
	[Token(Token = "0x4002DD7")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform socialLevelBarRect;

	// Token: 0x04002DD8 RID: 11736
	[Token(Token = "0x4002DD8")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform barFill;

	// Token: 0x04002DD9 RID: 11737
	[Token(Token = "0x4002DD9")]
	[FieldOffset(Offset = "0x40")]
	public JuiceController barJuice;

	// Token: 0x04002DDA RID: 11738
	[Token(Token = "0x4002DDA")]
	[FieldOffset(Offset = "0x48")]
	public List<CanvasRenderer> socialCreditRenderers;

	// Token: 0x04002DDB RID: 11739
	[Token(Token = "0x4002DDB")]
	[FieldOffset(Offset = "0x50")]
	public RectTransform inventoryParentRect;

	// Token: 0x04002DDC RID: 11740
	[Token(Token = "0x4002DDC")]
	[FieldOffset(Offset = "0x58")]
	public RectTransform solidBG;

	// Token: 0x04002DDD RID: 11741
	[Token(Token = "0x4002DDD")]
	[FieldOffset(Offset = "0x60")]
	public ButtonController closeButton;

	// Token: 0x04002DDE RID: 11742
	[Token(Token = "0x4002DDE")]
	[FieldOffset(Offset = "0x68")]
	public RectTransform equipmentParentRect;

	// Token: 0x04002DDF RID: 11743
	[Token(Token = "0x4002DDF")]
	[FieldOffset(Offset = "0x70")]
	public RectTransform itemsParentRect;

	// Token: 0x04002DE0 RID: 11744
	[Token(Token = "0x4002DE0")]
	[FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI inventoryTitleText;

	// Token: 0x04002DE1 RID: 11745
	[Token(Token = "0x4002DE1")]
	[FieldOffset(Offset = "0x80")]
	public TextMeshProUGUI cashText;

	// Token: 0x04002DE2 RID: 11746
	[Token(Token = "0x4002DE2")]
	[FieldOffset(Offset = "0x88")]
	public RectTransform summaryTextRect;

	// Token: 0x04002DE3 RID: 11747
	[Token(Token = "0x4002DE3")]
	[FieldOffset(Offset = "0x90")]
	public TextMeshProUGUI summaryText;

	// Token: 0x04002DE4 RID: 11748
	[Token(Token = "0x4002DE4")]
	[FieldOffset(Offset = "0x98")]
	public RectTransform buttonAreaParent;

	// Token: 0x04002DE5 RID: 11749
	[Token(Token = "0x4002DE5")]
	[FieldOffset(Offset = "0xA0")]
	public ButtonController dropButton;

	// Token: 0x04002DE6 RID: 11750
	[Token(Token = "0x4002DE6")]
	[FieldOffset(Offset = "0xA8")]
	public ButtonController inspectButton;

	// Token: 0x04002DE7 RID: 11751
	[Token(Token = "0x4002DE7")]
	[FieldOffset(Offset = "0xB0")]
	public ButtonController scanButton;

	// Token: 0x04002DE8 RID: 11752
	[Token(Token = "0x4002DE8")]
	[FieldOffset(Offset = "0xB8")]
	public ButtonController moreOptionsButton;

	// Token: 0x04002DE9 RID: 11753
	[Token(Token = "0x4002DE9")]
	[FieldOffset(Offset = "0xC0")]
	public ButtonController editDecorButton;

	// Token: 0x04002DEA RID: 11754
	[Token(Token = "0x4002DEA")]
	[FieldOffset(Offset = "0xC8")]
	public RectTransform scanProgressBar;

	// Token: 0x04002DEB RID: 11755
	[Token(Token = "0x4002DEB")]
	[FieldOffset(Offset = "0xD0")]
	public ButtonController selectNothingButton;

	// Token: 0x04002DEC RID: 11756
	[Token(Token = "0x4002DEC")]
	[FieldOffset(Offset = "0xD8")]
	public InventorySquareController nothingSquare;

	// Token: 0x04002DED RID: 11757
	[Token(Token = "0x4002DED")]
	[FieldOffset(Offset = "0xE0")]
	public List<CanvasRenderer> inventoryRenderers;

	// Token: 0x04002DEE RID: 11758
	[Token(Token = "0x4002DEE")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject levelBlipPrefab;

	// Token: 0x04002DEF RID: 11759
	[Token(Token = "0x4002DEF")]
	[FieldOffset(Offset = "0xF0")]
	public Color clearedLevel;

	// Token: 0x04002DF0 RID: 11760
	[Token(Token = "0x4002DF0")]
	[FieldOffset(Offset = "0x100")]
	public Color futureLevel;

	// Token: 0x04002DF1 RID: 11761
	[Token(Token = "0x4002DF1")]
	[FieldOffset(Offset = "0x110")]
	public GameObject inventorySquarePrefab;

	// Token: 0x04002DF2 RID: 11762
	[Token(Token = "0x4002DF2")]
	[FieldOffset(Offset = "0x118")]
	public Sprite equipmentBGIcon;

	// Token: 0x04002DF3 RID: 11763
	[Token(Token = "0x4002DF3")]
	[FieldOffset(Offset = "0x120")]
	public Sprite itemBGIcon;

	// Token: 0x04002DF4 RID: 11764
	[Token(Token = "0x4002DF4")]
	[FieldOffset(Offset = "0x128")]
	public int maxLevels;

	// Token: 0x04002DF5 RID: 11765
	[Token(Token = "0x4002DF5")]
	[FieldOffset(Offset = "0x12C")]
	public int maxPoints;

	// Token: 0x04002DF6 RID: 11766
	[Token(Token = "0x4002DF6")]
	[FieldOffset(Offset = "0x130")]
	public float desiredBarFillLevel;

	// Token: 0x04002DF7 RID: 11767
	[Token(Token = "0x4002DF7")]
	[FieldOffset(Offset = "0x134")]
	public float barHeight;

	// Token: 0x04002DF8 RID: 11768
	[Token(Token = "0x4002DF8")]
	[FieldOffset(Offset = "0x138")]
	public int currentLevel;

	// Token: 0x04002DF9 RID: 11769
	[Token(Token = "0x4002DF9")]
	[FieldOffset(Offset = "0x140")]
	private List<ButtonController> levelBlips;

	// Token: 0x04002DFA RID: 11770
	[Token(Token = "0x4002DFA")]
	[FieldOffset(Offset = "0x148")]
	public float socialCreditBarDisplayTimer;

	// Token: 0x04002DFB RID: 11771
	[Token(Token = "0x4002DFB")]
	[FieldOffset(Offset = "0x14C")]
	public float socialCreditDisplayProgress;

	// Token: 0x04002DFC RID: 11772
	[Token(Token = "0x4002DFC")]
	[FieldOffset(Offset = "0x150")]
	private ButtonController currentLevelBlip;

	// Token: 0x04002DFD RID: 11773
	[Token(Token = "0x4002DFD")]
	[FieldOffset(Offset = "0x158")]
	public bool openedFromPause;

	// Token: 0x04002DFE RID: 11774
	[Token(Token = "0x4002DFE")]
	[FieldOffset(Offset = "0x159")]
	public bool isOpen;

	// Token: 0x04002DFF RID: 11775
	[Token(Token = "0x4002DFF")]
	[FieldOffset(Offset = "0x15C")]
	public float inventoryDisplayProgress;

	// Token: 0x04002E00 RID: 11776
	[Token(Token = "0x4002E00")]
	[FieldOffset(Offset = "0x160")]
	[NonSerialized]
	public FirstPersonItemController.InventorySlot hoveredSlot;

	// Token: 0x04002E01 RID: 11777
	[Token(Token = "0x4002E01")]
	[FieldOffset(Offset = "0x168")]
	[NonSerialized]
	public FirstPersonItemController.InventorySlot selectedSlot;

	// Token: 0x04002E02 RID: 11778
	[Token(Token = "0x4002E02")]
	[FieldOffset(Offset = "0x170")]
	public int hoverIndex;

	// Token: 0x04002E03 RID: 11779
	[Token(Token = "0x4002E03")]
	[FieldOffset(Offset = "0x178")]
	private string summaryTextToDisplay;

	// Token: 0x04002E04 RID: 11780
	[Token(Token = "0x4002E04")]
	[FieldOffset(Offset = "0x180")]
	private float summaryTextProgress;

	// Token: 0x04002E05 RID: 11781
	[Token(Token = "0x4002E05")]
	[FieldOffset(Offset = "0x188")]
	[NonSerialized]
	public Interactable scanningItem;

	// Token: 0x04002E06 RID: 11782
	[Token(Token = "0x4002E06")]
	[FieldOffset(Offset = "0x190")]
	public float scanProgress;

	// Token: 0x04002E07 RID: 11783
	[Token(Token = "0x4002E07")]
	[FieldOffset(Offset = "0x198")]
	private AudioController.LoopingSoundInfo scannerLoop;

	// Token: 0x04002E08 RID: 11784
	[Token(Token = "0x4002E08")]
	[FieldOffset(Offset = "0x1A0")]
	public Dictionary<Interactable, List<Interactable>> scannedObjectsPrintsCache;

	// Token: 0x04002E0A RID: 11786
	[Token(Token = "0x4002E0A")]
	[FieldOffset(Offset = "0x0")]
	private static BioScreenController _instance;

	// Token: 0x0200065C RID: 1628
	// (Invoke) Token: 0x060023FB RID: 9211
	[Token(Token = "0x200065C")]
	public delegate void InventoryOpenChange();

	// Token: 0x0200065D RID: 1629
	[Token(Token = "0x200065D")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060023FF RID: 9215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x0000E718 File Offset: 0x0000C918
		[Token(Token = "0x6002400")]
		[Address(RVA = "0x477780", Offset = "0x476780", VA = "0x180477780")]
		internal bool <SetInventoryOpen>b__64_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x0000E730 File Offset: 0x0000C930
		[Token(Token = "0x6002401")]
		[Address(RVA = "0xB7E8D0", Offset = "0xB7D8D0", VA = "0x180B7E8D0")]
		internal bool <UpdateButtons>b__67_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x0000E748 File Offset: 0x0000C948
		[Token(Token = "0x6002402")]
		[Address(RVA = "0xB7E8F0", Offset = "0xB7D8F0", VA = "0x180B7E8F0")]
		internal bool <OnChangePoints>b__71_0(Case item)
		{
			return default(bool);
		}

		// Token: 0x04002E0B RID: 11787
		[Token(Token = "0x4002E0B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BioScreenController.<>c <>9;

		// Token: 0x04002E0C RID: 11788
		[Token(Token = "0x4002E0C")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__64_0;

		// Token: 0x04002E0D RID: 11789
		[Token(Token = "0x4002E0D")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__67_0;

		// Token: 0x04002E0E RID: 11790
		[Token(Token = "0x4002E0E")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<Case> <>9__71_0;
	}

	// Token: 0x0200065E RID: 1630
	[Token(Token = "0x200065E")]
	private sealed class <>c__DisplayClass72_0
	{
		// Token: 0x06002403 RID: 9219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002403")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass72_0()
		{
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0000E760 File Offset: 0x0000C960
		[Token(Token = "0x6002404")]
		[Address(RVA = "0xB7E910", Offset = "0xB7D910", VA = "0x180B7E910")]
		internal bool <UpdateSocialCreditPerks>b__0(SocialControls.SocialCreditBuff item)
		{
			return default(bool);
		}

		// Token: 0x04002E0F RID: 11791
		[Token(Token = "0x4002E0F")]
		[FieldOffset(Offset = "0x10")]
		public SocialControls.SocialCreditBuff buff;
	}

	// Token: 0x0200065F RID: 1631
	[Token(Token = "0x200065F")]
	private sealed class <DisplayNewPerk>d__75 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06002405 RID: 9221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002405")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <DisplayNewPerk>d__75(int <>1__state)
		{
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002406")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0000E778 File Offset: 0x0000C978
		[Token(Token = "0x6002407")]
		[Address(RVA = "0xB7E980", Offset = "0xB7D980", VA = "0x180B7E980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06002408 RID: 9224 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000127")]
		private object Current
		{
			[Token(Token = "0x6002408")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002409")]
		[Address(RVA = "0xB7ECE0", Offset = "0xB7DCE0", VA = "0x180B7ECE0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000128")]
		private object Current
		{
			[Token(Token = "0x600240A")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002E10 RID: 11792
		[Token(Token = "0x4002E10")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002E11 RID: 11793
		[Token(Token = "0x4002E11")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002E12 RID: 11794
		[Token(Token = "0x4002E12")]
		[FieldOffset(Offset = "0x20")]
		public float delayTime;

		// Token: 0x04002E13 RID: 11795
		[Token(Token = "0x4002E13")]
		[FieldOffset(Offset = "0x28")]
		public SocialControls.SocialCreditBuff newPerk;
	}
}
