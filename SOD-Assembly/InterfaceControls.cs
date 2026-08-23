using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020008BB RID: 2235
[Token(Token = "0x20008BB")]
public class InterfaceControls : MonoBehaviour
{
	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06002A3D RID: 10813 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000153")]
	public static InterfaceControls Instance
	{
		[Token(Token = "0x6002A3D")]
		[Address(RVA = "0xCBC2C0", Offset = "0xCBB2C0", VA = "0x180CBC2C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002A3E RID: 10814 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A3E")]
	[Address(RVA = "0xCBC300", Offset = "0xCBB300", VA = "0x180CBC300")]
	private void Awake()
	{
	}

	// Token: 0x06002A3F RID: 10815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A3F")]
	[Address(RVA = "0xCBC740", Offset = "0xCBB740", VA = "0x180CBC740")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002A40 RID: 10816 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A40")]
	[Address(RVA = "0xCBC950", Offset = "0xCBB950", VA = "0x180CBC950")]
	public InterfaceControls()
	{
	}

	// Token: 0x04004799 RID: 18329
	[Token(Token = "0x4004799")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 interactionCursorMin;

	// Token: 0x0400479A RID: 18330
	[Token(Token = "0x400479A")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 interactionCursorMax;

	// Token: 0x0400479B RID: 18331
	[Token(Token = "0x400479B")]
	[FieldOffset(Offset = "0x28")]
	public float interactionCursorSpeed;

	// Token: 0x0400479C RID: 18332
	[Token(Token = "0x400479C")]
	[FieldOffset(Offset = "0x2C")]
	public Color interactionTextColour;

	// Token: 0x0400479D RID: 18333
	[Token(Token = "0x400479D")]
	[FieldOffset(Offset = "0x3C")]
	public Color interactionTextDistanceColour;

	// Token: 0x0400479E RID: 18334
	[Token(Token = "0x400479E")]
	[FieldOffset(Offset = "0x4C")]
	public Color interactionTextIllegalColour;

	// Token: 0x0400479F RID: 18335
	[Token(Token = "0x400479F")]
	[FieldOffset(Offset = "0x5C")]
	public float lowHealthIndicatorThreshold;

	// Token: 0x040047A0 RID: 18336
	[Token(Token = "0x40047A0")]
	[FieldOffset(Offset = "0x60")]
	public float controlIconDisplayTime;

	// Token: 0x040047A1 RID: 18337
	[Token(Token = "0x40047A1")]
	[FieldOffset(Offset = "0x64")]
	public bool enableTooltips;

	// Token: 0x040047A2 RID: 18338
	[Token(Token = "0x40047A2")]
	[FieldOffset(Offset = "0x68")]
	public float tooltipWidth;

	// Token: 0x040047A3 RID: 18339
	[Token(Token = "0x40047A3")]
	[FieldOffset(Offset = "0x70")]
	public GameObject tooltipObjectPrefab;

	// Token: 0x040047A4 RID: 18340
	[Token(Token = "0x40047A4")]
	[FieldOffset(Offset = "0x78")]
	public float toolTipDelay;

	// Token: 0x040047A5 RID: 18341
	[Token(Token = "0x40047A5")]
	[FieldOffset(Offset = "0x7C")]
	public float toolTipFadeInSpeed;

	// Token: 0x040047A6 RID: 18342
	[Token(Token = "0x40047A6")]
	[FieldOffset(Offset = "0x80")]
	public Color defaultTextColour;

	// Token: 0x040047A7 RID: 18343
	[Token(Token = "0x40047A7")]
	[FieldOffset(Offset = "0x90")]
	public float contextMenuWidth;

	// Token: 0x040047A8 RID: 18344
	[Token(Token = "0x40047A8")]
	[FieldOffset(Offset = "0x98")]
	public RectTransform minimapRootParent;

	// Token: 0x040047A9 RID: 18345
	[Token(Token = "0x40047A9")]
	[FieldOffset(Offset = "0xA0")]
	public Sprite playerApartmentSprite;

	// Token: 0x040047AA RID: 18346
	[Token(Token = "0x40047AA")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject mapLoadingGraphic;

	// Token: 0x040047AB RID: 18347
	[Token(Token = "0x40047AB")]
	[FieldOffset(Offset = "0xB0")]
	public Sprite unknownIconLarge;

	// Token: 0x040047AC RID: 18348
	[Token(Token = "0x40047AC")]
	[FieldOffset(Offset = "0xB8")]
	public Sprite companyIconLarge;

	// Token: 0x040047AD RID: 18349
	[Token(Token = "0x40047AD")]
	[FieldOffset(Offset = "0xC0")]
	public float doubleClickDelay;

	// Token: 0x040047AE RID: 18350
	[Token(Token = "0x40047AE")]
	[FieldOffset(Offset = "0xC8")]
	public Sprite stickyNoteButtonSprite;

	// Token: 0x040047AF RID: 18351
	[Token(Token = "0x40047AF")]
	[FieldOffset(Offset = "0xD0")]
	public Sprite lockedSprite;

	// Token: 0x040047B0 RID: 18352
	[Token(Token = "0x40047B0")]
	[FieldOffset(Offset = "0xD8")]
	public Sprite unlockedSprite;

	// Token: 0x040047B1 RID: 18353
	[Token(Token = "0x40047B1")]
	[FieldOffset(Offset = "0xE0")]
	public Canvas hudCanvas;

	// Token: 0x040047B2 RID: 18354
	[Token(Token = "0x40047B2")]
	[FieldOffset(Offset = "0xE8")]
	public RectTransform hudCanvasRect;

	// Token: 0x040047B3 RID: 18355
	[Token(Token = "0x40047B3")]
	[FieldOffset(Offset = "0xF0")]
	public RectTransform speechBubbleParent;

	// Token: 0x040047B4 RID: 18356
	[Token(Token = "0x40047B4")]
	[FieldOffset(Offset = "0xF8")]
	public RectTransform reticleContainer;

	// Token: 0x040047B5 RID: 18357
	[Token(Token = "0x40047B5")]
	[FieldOffset(Offset = "0x100")]
	public RectTransform locationTextContainer;

	// Token: 0x040047B6 RID: 18358
	[Token(Token = "0x40047B6")]
	[FieldOffset(Offset = "0x108")]
	public List<RectTransform> screenshotModeToggleObjects;

	// Token: 0x040047B7 RID: 18359
	[Token(Token = "0x40047B7")]
	[FieldOffset(Offset = "0x110")]
	public List<RectTransform> screenShotModeAllowDialogObjects;

	// Token: 0x040047B8 RID: 18360
	[Token(Token = "0x40047B8")]
	[FieldOffset(Offset = "0x118")]
	public Color interactionControlTextColourNormal;

	// Token: 0x040047B9 RID: 18361
	[Token(Token = "0x40047B9")]
	[FieldOffset(Offset = "0x128")]
	public Color windowTakeItemIconDefaultColor;

	// Token: 0x040047BA RID: 18362
	[Token(Token = "0x40047BA")]
	[FieldOffset(Offset = "0x138")]
	[NonSerialized]
	public string interactionControlTextNormalHex;

	// Token: 0x040047BB RID: 18363
	[Token(Token = "0x40047BB")]
	[FieldOffset(Offset = "0x140")]
	public Color interactionControlTextColourIllegal;

	// Token: 0x040047BC RID: 18364
	[Token(Token = "0x40047BC")]
	[FieldOffset(Offset = "0x150")]
	[NonSerialized]
	public string interactionControlTextIllegalHex;

	// Token: 0x040047BD RID: 18365
	[Token(Token = "0x40047BD")]
	[FieldOffset(Offset = "0x158")]
	public float gameMessageTextRevealSpeed;

	// Token: 0x040047BE RID: 18366
	[Token(Token = "0x40047BE")]
	[FieldOffset(Offset = "0x15C")]
	public float gameMessageDestroyDelay;

	// Token: 0x040047BF RID: 18367
	[Token(Token = "0x40047BF")]
	[FieldOffset(Offset = "0x160")]
	public RectTransform weaponSwitchAnchor;

	// Token: 0x040047C0 RID: 18368
	[Token(Token = "0x40047C0")]
	[FieldOffset(Offset = "0x168")]
	public Transform firstPersonItemsParent;

	// Token: 0x040047C1 RID: 18369
	[Token(Token = "0x40047C1")]
	[FieldOffset(Offset = "0x170")]
	public Color interactionTextNormalColour;

	// Token: 0x040047C2 RID: 18370
	[Token(Token = "0x40047C2")]
	[FieldOffset(Offset = "0x180")]
	public Color trespassingEscalationZero;

	// Token: 0x040047C3 RID: 18371
	[Token(Token = "0x40047C3")]
	[FieldOffset(Offset = "0x190")]
	public Color trespassingEscalationOne;

	// Token: 0x040047C4 RID: 18372
	[Token(Token = "0x40047C4")]
	[FieldOffset(Offset = "0x1A0")]
	public RectTransform fastForwardArrow;

	// Token: 0x040047C5 RID: 18373
	[Token(Token = "0x40047C5")]
	[FieldOffset(Offset = "0x1A8")]
	public float movieBarHeight;

	// Token: 0x040047C6 RID: 18374
	[Token(Token = "0x40047C6")]
	[FieldOffset(Offset = "0x1B0")]
	public TextMeshProUGUI lockpicksText;

	// Token: 0x040047C7 RID: 18375
	[Token(Token = "0x40047C7")]
	[FieldOffset(Offset = "0x1B8")]
	public TextMeshProUGUI cashText;

	// Token: 0x040047C8 RID: 18376
	[Token(Token = "0x40047C8")]
	[FieldOffset(Offset = "0x1C0")]
	public TextMeshProUGUI socialRankText;

	// Token: 0x040047C9 RID: 18377
	[Token(Token = "0x40047C9")]
	[FieldOffset(Offset = "0x1C8")]
	public TextMeshProUGUI plottedRouteText;

	// Token: 0x040047CA RID: 18378
	[Token(Token = "0x40047CA")]
	[FieldOffset(Offset = "0x1D0")]
	public AnimationCurve notificationGlowCurve;

	// Token: 0x040047CB RID: 18379
	[Token(Token = "0x40047CB")]
	[FieldOffset(Offset = "0x1D8")]
	public Color notificationColorMax;

	// Token: 0x040047CC RID: 18380
	[Token(Token = "0x40047CC")]
	[FieldOffset(Offset = "0x1E8")]
	public Color notificationColorMin;

	// Token: 0x040047CD RID: 18381
	[Token(Token = "0x40047CD")]
	[FieldOffset(Offset = "0x1F8")]
	public Color messageGrey;

	// Token: 0x040047CE RID: 18382
	[Token(Token = "0x40047CE")]
	[FieldOffset(Offset = "0x208")]
	public Color messageRed;

	// Token: 0x040047CF RID: 18383
	[Token(Token = "0x40047CF")]
	[FieldOffset(Offset = "0x218")]
	public Color messageGreen;

	// Token: 0x040047D0 RID: 18384
	[Token(Token = "0x40047D0")]
	[FieldOffset(Offset = "0x228")]
	public Color messageBlue;

	// Token: 0x040047D1 RID: 18385
	[Token(Token = "0x40047D1")]
	[FieldOffset(Offset = "0x238")]
	public Color messageYellow;

	// Token: 0x040047D2 RID: 18386
	[Token(Token = "0x40047D2")]
	[FieldOffset(Offset = "0x248")]
	public Sprite starchLogo;

	// Token: 0x040047D3 RID: 18387
	[Token(Token = "0x40047D3")]
	[FieldOffset(Offset = "0x250")]
	public Sprite elGenLogo;

	// Token: 0x040047D4 RID: 18388
	[Token(Token = "0x40047D4")]
	[FieldOffset(Offset = "0x258")]
	public Sprite kensingtonLogo;

	// Token: 0x040047D5 RID: 18389
	[Token(Token = "0x40047D5")]
	[FieldOffset(Offset = "0x260")]
	public Sprite KaizenLogo;

	// Token: 0x040047D6 RID: 18390
	[Token(Token = "0x40047D6")]
	[FieldOffset(Offset = "0x268")]
	public Sprite candorLogo;

	// Token: 0x040047D7 RID: 18391
	[Token(Token = "0x40047D7")]
	[FieldOffset(Offset = "0x270")]
	public Sprite blackMarketLogo;

	// Token: 0x040047D8 RID: 18392
	[Token(Token = "0x40047D8")]
	[FieldOffset(Offset = "0x278")]
	public List<InterfaceControls.IconConfig> iconReference;

	// Token: 0x040047D9 RID: 18393
	[Token(Token = "0x40047D9")]
	[FieldOffset(Offset = "0x280")]
	public Material arrow;

	// Token: 0x040047DA RID: 18394
	[Token(Token = "0x40047DA")]
	[FieldOffset(Offset = "0x288")]
	public Material spotted;

	// Token: 0x040047DB RID: 18395
	[Token(Token = "0x40047DB")]
	[FieldOffset(Offset = "0x290")]
	public Material speech;

	// Token: 0x040047DC RID: 18396
	[Token(Token = "0x40047DC")]
	[FieldOffset(Offset = "0x298")]
	public float awarenessDistanceThreshold;

	// Token: 0x040047DD RID: 18397
	[Token(Token = "0x40047DD")]
	[FieldOffset(Offset = "0x29C")]
	public Color spottedNormalEmission;

	// Token: 0x040047DE RID: 18398
	[Token(Token = "0x40047DE")]
	[FieldOffset(Offset = "0x2AC")]
	public Color arrowNormalEmission;

	// Token: 0x040047DF RID: 18399
	[Token(Token = "0x40047DF")]
	[FieldOffset(Offset = "0x2BC")]
	public Color awarenessAlertEmission;

	// Token: 0x040047E0 RID: 18400
	[Token(Token = "0x40047E0")]
	[FieldOffset(Offset = "0x2CC")]
	public Vector2 textSpaceBuffer;

	// Token: 0x040047E1 RID: 18401
	[Token(Token = "0x40047E1")]
	[FieldOffset(Offset = "0x2D4")]
	public float textBubbleMinWidth;

	// Token: 0x040047E2 RID: 18402
	[Token(Token = "0x40047E2")]
	[FieldOffset(Offset = "0x2D8")]
	public float textBubbleMaxWidth;

	// Token: 0x040047E3 RID: 18403
	[Token(Token = "0x40047E3")]
	[FieldOffset(Offset = "0x2DC")]
	public Color playerSpeechColour;

	// Token: 0x040047E4 RID: 18404
	[Token(Token = "0x40047E4")]
	[FieldOffset(Offset = "0x2EC")]
	public Color callerSpeechColour;

	// Token: 0x040047E5 RID: 18405
	[Token(Token = "0x40047E5")]
	[FieldOffset(Offset = "0x2FC")]
	public float visualTalkDisplaySpeed;

	// Token: 0x040047E6 RID: 18406
	[Token(Token = "0x40047E6")]
	[FieldOffset(Offset = "0x300")]
	public float visualTalkDisplayDestroyDelay;

	// Token: 0x040047E7 RID: 18407
	[Token(Token = "0x40047E7")]
	[FieldOffset(Offset = "0x304")]
	public float visualTalkDisplayStringLengthModifier;

	// Token: 0x040047E8 RID: 18408
	[Token(Token = "0x40047E8")]
	[FieldOffset(Offset = "0x308")]
	public float visualTalkTextSize;

	// Token: 0x040047E9 RID: 18409
	[Token(Token = "0x40047E9")]
	[FieldOffset(Offset = "0x30C")]
	public Vector2 speechMinMaxScale;

	// Token: 0x040047EA RID: 18410
	[Token(Token = "0x40047EA")]
	[FieldOffset(Offset = "0x314")]
	public Vector2 indicatorMinMaxScale;

	// Token: 0x040047EB RID: 18411
	[Token(Token = "0x40047EB")]
	[FieldOffset(Offset = "0x31C")]
	public float maxIndicatorDistance;

	// Token: 0x040047EC RID: 18412
	[Token(Token = "0x40047EC")]
	[FieldOffset(Offset = "0x320")]
	public Vector2 uiPointerDistanceRange;

	// Token: 0x040047ED RID: 18413
	[Token(Token = "0x40047ED")]
	[FieldOffset(Offset = "0x328")]
	public TextMeshProUGUI caseSolvedText;

	// Token: 0x040047EE RID: 18414
	[Token(Token = "0x40047EE")]
	[FieldOffset(Offset = "0x330")]
	public List<CanvasRenderer> screenMessageFadeRenderers;

	// Token: 0x040047EF RID: 18415
	[Token(Token = "0x40047EF")]
	[FieldOffset(Offset = "0x338")]
	public RectTransform resolveQuestionsDisplayParent;

	// Token: 0x040047F0 RID: 18416
	[Token(Token = "0x40047F0")]
	[FieldOffset(Offset = "0x340")]
	public AnimationCurve caseSolvedAlphaAnim;

	// Token: 0x040047F1 RID: 18417
	[Token(Token = "0x40047F1")]
	[FieldOffset(Offset = "0x348")]
	public AnimationCurve caseSolvedKerningAnim;

	// Token: 0x040047F2 RID: 18418
	[Token(Token = "0x40047F2")]
	[FieldOffset(Offset = "0x350")]
	public Vector2 handbookWindowPosition;

	// Token: 0x040047F3 RID: 18419
	[Token(Token = "0x40047F3")]
	[FieldOffset(Offset = "0x358")]
	public Vector2 lightOrbSize;

	// Token: 0x040047F4 RID: 18420
	[Token(Token = "0x40047F4")]
	[FieldOffset(Offset = "0x360")]
	public AnimationCurve stealthModeOrbSizeTransitionIn;

	// Token: 0x040047F5 RID: 18421
	[Token(Token = "0x40047F5")]
	[FieldOffset(Offset = "0x368")]
	public AnimationCurve stealthModeOrbSizeTransitionOut;

	// Token: 0x040047F6 RID: 18422
	[Token(Token = "0x40047F6")]
	[FieldOffset(Offset = "0x370")]
	public RectTransform lightOrbRect;

	// Token: 0x040047F7 RID: 18423
	[Token(Token = "0x40047F7")]
	[FieldOffset(Offset = "0x378")]
	public Image lightOrbFillImg;

	// Token: 0x040047F8 RID: 18424
	[Token(Token = "0x40047F8")]
	[FieldOffset(Offset = "0x380")]
	public Image lightOrbOutline;

	// Token: 0x040047F9 RID: 18425
	[Token(Token = "0x40047F9")]
	[FieldOffset(Offset = "0x388")]
	public Image seenImg;

	// Token: 0x040047FA RID: 18426
	[Token(Token = "0x40047FA")]
	[FieldOffset(Offset = "0x390")]
	public CanvasRenderer seenRenderer;

	// Token: 0x040047FB RID: 18427
	[Token(Token = "0x40047FB")]
	[FieldOffset(Offset = "0x398")]
	public JuiceController seenJuice;

	// Token: 0x040047FC RID: 18428
	[Token(Token = "0x40047FC")]
	[FieldOffset(Offset = "0x3A0")]
	public RectTransform interactionRect;

	// Token: 0x040047FD RID: 18429
	[Token(Token = "0x40047FD")]
	[FieldOffset(Offset = "0x3A8")]
	public RectTransform interactionULRect;

	// Token: 0x040047FE RID: 18430
	[Token(Token = "0x40047FE")]
	[FieldOffset(Offset = "0x3B0")]
	public RectTransform interactionURRect;

	// Token: 0x040047FF RID: 18431
	[Token(Token = "0x40047FF")]
	[FieldOffset(Offset = "0x3B8")]
	public RectTransform interactionBLRect;

	// Token: 0x04004800 RID: 18432
	[Token(Token = "0x4004800")]
	[FieldOffset(Offset = "0x3C0")]
	public RectTransform interactionBRRect;

	// Token: 0x04004801 RID: 18433
	[Token(Token = "0x4004801")]
	[FieldOffset(Offset = "0x3C8")]
	public List<Image> interactionFadeInImages;

	// Token: 0x04004802 RID: 18434
	[Token(Token = "0x4004802")]
	[FieldOffset(Offset = "0x3D0")]
	public List<Image> interactionBoundImages;

	// Token: 0x04004803 RID: 18435
	[Token(Token = "0x4004803")]
	[FieldOffset(Offset = "0x3D8")]
	public RectTransform interactionTextContainer;

	// Token: 0x04004804 RID: 18436
	[Token(Token = "0x4004804")]
	[FieldOffset(Offset = "0x3E0")]
	public TextMeshProUGUI interactionText;

	// Token: 0x04004805 RID: 18437
	[Token(Token = "0x4004805")]
	[FieldOffset(Offset = "0x3E8")]
	public RectTransform readingTextContainer;

	// Token: 0x04004806 RID: 18438
	[Token(Token = "0x4004806")]
	[FieldOffset(Offset = "0x3F0")]
	public CanvasRenderer readingContainerRend;

	// Token: 0x04004807 RID: 18439
	[Token(Token = "0x4004807")]
	[FieldOffset(Offset = "0x3F8")]
	public TextMeshProUGUI readingText;

	// Token: 0x04004808 RID: 18440
	[Token(Token = "0x4004808")]
	[FieldOffset(Offset = "0x400")]
	public CanvasRenderer readingTextRend;

	// Token: 0x04004809 RID: 18441
	[Token(Token = "0x4004809")]
	[FieldOffset(Offset = "0x408")]
	public Vector2 readingBoxMaxSize;

	// Token: 0x0400480A RID: 18442
	[Token(Token = "0x400480A")]
	[FieldOffset(Offset = "0x410")]
	public RectTransform haveKeyIcon;

	// Token: 0x0400480B RID: 18443
	[Token(Token = "0x400480B")]
	[FieldOffset(Offset = "0x418")]
	public RectTransform lockedIcon;

	// Token: 0x0400480C RID: 18444
	[Token(Token = "0x400480C")]
	[FieldOffset(Offset = "0x420")]
	public Image lockedImg;

	// Token: 0x0400480D RID: 18445
	[Token(Token = "0x400480D")]
	[FieldOffset(Offset = "0x428")]
	public RectTransform forbiddenIcon;

	// Token: 0x0400480E RID: 18446
	[Token(Token = "0x400480E")]
	[FieldOffset(Offset = "0x430")]
	public RectTransform seenIcon;

	// Token: 0x0400480F RID: 18447
	[Token(Token = "0x400480F")]
	[FieldOffset(Offset = "0x438")]
	public TextMeshProUGUI lockStrengthText;

	// Token: 0x04004810 RID: 18448
	[Token(Token = "0x4004810")]
	[FieldOffset(Offset = "0x440")]
	public RectTransform actionInteractionDisplay;

	// Token: 0x04004811 RID: 18449
	[Token(Token = "0x4004811")]
	[FieldOffset(Offset = "0x448")]
	public RectTransform actionInteractionAnchor;

	// Token: 0x04004812 RID: 18450
	[Token(Token = "0x4004812")]
	[FieldOffset(Offset = "0x450")]
	public TextMeshProUGUI actionInteractionText;

	// Token: 0x04004813 RID: 18451
	[Token(Token = "0x4004813")]
	[FieldOffset(Offset = "0x458")]
	public Color unheardSoundIconColour;

	// Token: 0x04004814 RID: 18452
	[Token(Token = "0x4004814")]
	[FieldOffset(Offset = "0x468")]
	public Color heardSoundIconColour;

	// Token: 0x04004815 RID: 18453
	[Token(Token = "0x4004815")]
	[FieldOffset(Offset = "0x478")]
	public Vector2 stringWidthRange;

	// Token: 0x04004816 RID: 18454
	[Token(Token = "0x4004816")]
	[FieldOffset(Offset = "0x480")]
	public float autoPinDistance;

	// Token: 0x04004817 RID: 18455
	[Token(Token = "0x4004817")]
	[FieldOffset(Offset = "0x484")]
	public float pinnedEvidenceRadius;

	// Token: 0x04004818 RID: 18456
	[Token(Token = "0x4004818")]
	[FieldOffset(Offset = "0x488")]
	public int angleStepsCount;

	// Token: 0x04004819 RID: 18457
	[Token(Token = "0x4004819")]
	[FieldOffset(Offset = "0x490")]
	public Rigidbody2D caseBoardRigidbody;

	// Token: 0x0400481A RID: 18458
	[Token(Token = "0x400481A")]
	[FieldOffset(Offset = "0x498")]
	public RectTransform caseBoardCursorRBContainer;

	// Token: 0x0400481B RID: 18459
	[Token(Token = "0x400481B")]
	[FieldOffset(Offset = "0x4A0")]
	public Rigidbody2D caseBoardCursorRigidbody;

	// Token: 0x0400481C RID: 18460
	[Token(Token = "0x400481C")]
	[FieldOffset(Offset = "0x4A8")]
	public RectTransform caseBoardContentContainer;

	// Token: 0x0400481D RID: 18461
	[Token(Token = "0x400481D")]
	[FieldOffset(Offset = "0x4B0")]
	public float pinnedLinearDrag;

	// Token: 0x0400481E RID: 18462
	[Token(Token = "0x400481E")]
	[FieldOffset(Offset = "0x4B4")]
	public float movingLinearDrag;

	// Token: 0x0400481F RID: 18463
	[Token(Token = "0x400481F")]
	[FieldOffset(Offset = "0x4B8")]
	public RawImage cameraScreenshot;

	// Token: 0x04004820 RID: 18464
	[Token(Token = "0x4004820")]
	[FieldOffset(Offset = "0x4C0")]
	public RenderTexture cameraScreenshotRenderTex;

	// Token: 0x04004821 RID: 18465
	[Token(Token = "0x4004821")]
	[FieldOffset(Offset = "0x4C8")]
	public float pinnedMovementIntertiaMultiplier;

	// Token: 0x04004822 RID: 18466
	[Token(Token = "0x4004822")]
	[FieldOffset(Offset = "0x4CC")]
	public Color defaultCaseFileColour;

	// Token: 0x04004823 RID: 18467
	[Token(Token = "0x4004823")]
	[FieldOffset(Offset = "0x4DC")]
	public int maximumEvidenceItemHistory;

	// Token: 0x04004824 RID: 18468
	[Token(Token = "0x4004824")]
	[FieldOffset(Offset = "0x4E0")]
	public List<InterfaceControls.PinColours> pinColours;

	// Token: 0x04004825 RID: 18469
	[Token(Token = "0x4004825")]
	[FieldOffset(Offset = "0x4E8")]
	public Sprite citizenPhoto;

	// Token: 0x04004826 RID: 18470
	[Token(Token = "0x4004826")]
	[FieldOffset(Offset = "0x4F0")]
	public bool minimizeEvidenceOnPinned;

	// Token: 0x04004827 RID: 18471
	[Token(Token = "0x4004827")]
	[FieldOffset(Offset = "0x4F4")]
	public Color markedLinkColour;

	// Token: 0x04004828 RID: 18472
	[Token(Token = "0x4004828")]
	[FieldOffset(Offset = "0x504")]
	public Color neutralColour;

	// Token: 0x04004829 RID: 18473
	[Token(Token = "0x4004829")]
	[FieldOffset(Offset = "0x514")]
	public Color incriminatingColour;

	// Token: 0x0400482A RID: 18474
	[Token(Token = "0x400482A")]
	[FieldOffset(Offset = "0x524")]
	public Color innocentColour;

	// Token: 0x0400482B RID: 18475
	[Token(Token = "0x400482B")]
	[FieldOffset(Offset = "0x538")]
	public Texture2D nullPhotoReference;

	// Token: 0x0400482C RID: 18476
	[Token(Token = "0x400482C")]
	[FieldOffset(Offset = "0x540")]
	public Vector2 defaultWindowLocation;

	// Token: 0x0400482D RID: 18477
	[Token(Token = "0x400482D")]
	[FieldOffset(Offset = "0x548")]
	public Vector2 windowCountOffset;

	// Token: 0x0400482E RID: 18478
	[Token(Token = "0x400482E")]
	[FieldOffset(Offset = "0x550")]
	public float minimizingAnimationSpeed;

	// Token: 0x0400482F RID: 18479
	[Token(Token = "0x400482F")]
	[FieldOffset(Offset = "0x554")]
	public Color selectionColour;

	// Token: 0x04004830 RID: 18480
	[Token(Token = "0x4004830")]
	[FieldOffset(Offset = "0x564")]
	public Color nonSelectionColour;

	// Token: 0x04004831 RID: 18481
	[Token(Token = "0x4004831")]
	[FieldOffset(Offset = "0x578")]
	public Sprite closeSprite;

	// Token: 0x04004832 RID: 18482
	[Token(Token = "0x4004832")]
	[FieldOffset(Offset = "0x580")]
	public Color closeColour;

	// Token: 0x04004833 RID: 18483
	[Token(Token = "0x4004833")]
	[FieldOffset(Offset = "0x590")]
	public Sprite minimizeSprite;

	// Token: 0x04004834 RID: 18484
	[Token(Token = "0x4004834")]
	[FieldOffset(Offset = "0x598")]
	public Color minimizeColour;

	// Token: 0x04004835 RID: 18485
	[Token(Token = "0x4004835")]
	[FieldOffset(Offset = "0x5A8")]
	public Texture2D normalCursor;

	// Token: 0x04004836 RID: 18486
	[Token(Token = "0x4004836")]
	[FieldOffset(Offset = "0x5B0")]
	public Texture2D cursorMove;

	// Token: 0x04004837 RID: 18487
	[Token(Token = "0x4004837")]
	[FieldOffset(Offset = "0x5B8")]
	public Texture2D cursorResizeHorizonal;

	// Token: 0x04004838 RID: 18488
	[Token(Token = "0x4004838")]
	[FieldOffset(Offset = "0x5C0")]
	public Texture2D cursorResizeVertical;

	// Token: 0x04004839 RID: 18489
	[Token(Token = "0x4004839")]
	[FieldOffset(Offset = "0x5C8")]
	public Texture2D cursorResizeDiagonalRightLeft;

	// Token: 0x0400483A RID: 18490
	[Token(Token = "0x400483A")]
	[FieldOffset(Offset = "0x5D0")]
	public Texture2D cursorResizeDiagonalLeftRight;

	// Token: 0x0400483B RID: 18491
	[Token(Token = "0x400483B")]
	[FieldOffset(Offset = "0x5D8")]
	public Texture2D cursorTarget;

	// Token: 0x0400483C RID: 18492
	[Token(Token = "0x400483C")]
	[FieldOffset(Offset = "0x5E0")]
	public Texture2D cursorButton;

	// Token: 0x0400483D RID: 18493
	[Token(Token = "0x400483D")]
	[FieldOffset(Offset = "0x5E8")]
	public Texture2D cursorTextEdit;

	// Token: 0x0400483E RID: 18494
	[Token(Token = "0x400483E")]
	[FieldOffset(Offset = "0x5F0")]
	public Sprite reactionInvestigateSightSprite;

	// Token: 0x0400483F RID: 18495
	[Token(Token = "0x400483F")]
	[FieldOffset(Offset = "0x5F8")]
	public Sprite reactionInvestigateSoundSprite;

	// Token: 0x04004840 RID: 18496
	[Token(Token = "0x4004840")]
	[FieldOffset(Offset = "0x600")]
	public Sprite reactionPersueSprite;

	// Token: 0x04004841 RID: 18497
	[Token(Token = "0x4004841")]
	[FieldOffset(Offset = "0x608")]
	public Sprite reactionSearchSprite;

	// Token: 0x04004842 RID: 18498
	[Token(Token = "0x4004842")]
	[FieldOffset(Offset = "0x610")]
	public Sprite reactionAvoidSprite;

	// Token: 0x04004843 RID: 18499
	[Token(Token = "0x4004843")]
	[FieldOffset(Offset = "0x618")]
	public Texture reactionInvestigateSightTex;

	// Token: 0x04004844 RID: 18500
	[Token(Token = "0x4004844")]
	[FieldOffset(Offset = "0x620")]
	public Texture reactionInvestigateSoundTex;

	// Token: 0x04004845 RID: 18501
	[Token(Token = "0x4004845")]
	[FieldOffset(Offset = "0x628")]
	public Texture reactionPersueTex;

	// Token: 0x04004846 RID: 18502
	[Token(Token = "0x4004846")]
	[FieldOffset(Offset = "0x630")]
	public Texture reactionSearchTex;

	// Token: 0x04004847 RID: 18503
	[Token(Token = "0x4004847")]
	[FieldOffset(Offset = "0x638")]
	public Texture reactionAvoidTex;

	// Token: 0x04004848 RID: 18504
	[Token(Token = "0x4004848")]
	[FieldOffset(Offset = "0x0")]
	private static InterfaceControls _instance;

	// Token: 0x020008BC RID: 2236
	[Token(Token = "0x20008BC")]
	public enum Icon
	{
		// Token: 0x0400484A RID: 18506
		[Token(Token = "0x400484A")]
		lookingGlass,
		// Token: 0x0400484B RID: 18507
		[Token(Token = "0x400484B")]
		lightBulb,
		// Token: 0x0400484C RID: 18508
		[Token(Token = "0x400484C")]
		key,
		// Token: 0x0400484D RID: 18509
		[Token(Token = "0x400484D")]
		agent,
		// Token: 0x0400484E RID: 18510
		[Token(Token = "0x400484E")]
		citizen,
		// Token: 0x0400484F RID: 18511
		[Token(Token = "0x400484F")]
		pin,
		// Token: 0x04004850 RID: 18512
		[Token(Token = "0x4004850")]
		footprint,
		// Token: 0x04004851 RID: 18513
		[Token(Token = "0x4004851")]
		document,
		// Token: 0x04004852 RID: 18514
		[Token(Token = "0x4004852")]
		door,
		// Token: 0x04004853 RID: 18515
		[Token(Token = "0x4004853")]
		location,
		// Token: 0x04004854 RID: 18516
		[Token(Token = "0x4004854")]
		questionMark,
		// Token: 0x04004855 RID: 18517
		[Token(Token = "0x4004855")]
		eye,
		// Token: 0x04004856 RID: 18518
		[Token(Token = "0x4004856")]
		books,
		// Token: 0x04004857 RID: 18519
		[Token(Token = "0x4004857")]
		star,
		// Token: 0x04004858 RID: 18520
		[Token(Token = "0x4004858")]
		building,
		// Token: 0x04004859 RID: 18521
		[Token(Token = "0x4004859")]
		hand,
		// Token: 0x0400485A RID: 18522
		[Token(Token = "0x400485A")]
		run,
		// Token: 0x0400485B RID: 18523
		[Token(Token = "0x400485B")]
		money,
		// Token: 0x0400485C RID: 18524
		[Token(Token = "0x400485C")]
		message,
		// Token: 0x0400485D RID: 18525
		[Token(Token = "0x400485D")]
		lockpick,
		// Token: 0x0400485E RID: 18526
		[Token(Token = "0x400485E")]
		notebook,
		// Token: 0x0400485F RID: 18527
		[Token(Token = "0x400485F")]
		empty,
		// Token: 0x04004860 RID: 18528
		[Token(Token = "0x4004860")]
		skull,
		// Token: 0x04004861 RID: 18529
		[Token(Token = "0x4004861")]
		passedOut,
		// Token: 0x04004862 RID: 18530
		[Token(Token = "0x4004862")]
		telephone,
		// Token: 0x04004863 RID: 18531
		[Token(Token = "0x4004863")]
		printScanner,
		// Token: 0x04004864 RID: 18532
		[Token(Token = "0x4004864")]
		resolve,
		// Token: 0x04004865 RID: 18533
		[Token(Token = "0x4004865")]
		time,
		// Token: 0x04004866 RID: 18534
		[Token(Token = "0x4004866")]
		tick,
		// Token: 0x04004867 RID: 18535
		[Token(Token = "0x4004867")]
		cross,
		// Token: 0x04004868 RID: 18536
		[Token(Token = "0x4004868")]
		camera,
		// Token: 0x04004869 RID: 18537
		[Token(Token = "0x4004869")]
		vandalism,
		// Token: 0x0400486A RID: 18538
		[Token(Token = "0x400486A")]
		robbery,
		// Token: 0x0400486B RID: 18539
		[Token(Token = "0x400486B")]
		picture,
		// Token: 0x0400486C RID: 18540
		[Token(Token = "0x400486C")]
		fist,
		// Token: 0x0400486D RID: 18541
		[Token(Token = "0x400486D")]
		handcuffs,
		// Token: 0x0400486E RID: 18542
		[Token(Token = "0x400486E")]
		trash,
		// Token: 0x0400486F RID: 18543
		[Token(Token = "0x400486F")]
		food
	}

	// Token: 0x020008BD RID: 2237
	[Token(Token = "0x20008BD")]
	[Serializable]
	public class IconConfig
	{
		// Token: 0x06002A41 RID: 10817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A41")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public IconConfig()
		{
		}

		// Token: 0x04004870 RID: 18544
		[Token(Token = "0x4004870")]
		[FieldOffset(Offset = "0x10")]
		public InterfaceControls.Icon iconType;

		// Token: 0x04004871 RID: 18545
		[Token(Token = "0x4004871")]
		[FieldOffset(Offset = "0x18")]
		public Sprite sprite;
	}

	// Token: 0x020008BE RID: 2238
	[Token(Token = "0x20008BE")]
	public enum EvidenceColours
	{
		// Token: 0x04004873 RID: 18547
		[Token(Token = "0x4004873")]
		red,
		// Token: 0x04004874 RID: 18548
		[Token(Token = "0x4004874")]
		blue,
		// Token: 0x04004875 RID: 18549
		[Token(Token = "0x4004875")]
		yellow,
		// Token: 0x04004876 RID: 18550
		[Token(Token = "0x4004876")]
		green,
		// Token: 0x04004877 RID: 18551
		[Token(Token = "0x4004877")]
		purple,
		// Token: 0x04004878 RID: 18552
		[Token(Token = "0x4004878")]
		white,
		// Token: 0x04004879 RID: 18553
		[Token(Token = "0x4004879")]
		black
	}

	// Token: 0x020008BF RID: 2239
	[Token(Token = "0x20008BF")]
	[Serializable]
	public class PinColours
	{
		// Token: 0x06002A42 RID: 10818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A42")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public PinColours()
		{
		}

		// Token: 0x0400487A RID: 18554
		[Token(Token = "0x400487A")]
		[FieldOffset(Offset = "0x10")]
		public InterfaceControls.EvidenceColours colour;

		// Token: 0x0400487B RID: 18555
		[Token(Token = "0x400487B")]
		[FieldOffset(Offset = "0x14")]
		public Color actualColour;
	}
}
