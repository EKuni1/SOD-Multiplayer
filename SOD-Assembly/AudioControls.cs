using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008A7 RID: 2215
[Token(Token = "0x20008A7")]
public class AudioControls : MonoBehaviour
{
	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06002A0D RID: 10765 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700014B")]
	public static AudioControls Instance
	{
		[Token(Token = "0x6002A0D")]
		[Address(RVA = "0xCB4C80", Offset = "0xCB3C80", VA = "0x180CB4C80")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002A0E RID: 10766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A0E")]
	[Address(RVA = "0xCB4CC0", Offset = "0xCB3CC0", VA = "0x180CB4CC0")]
	private void Awake()
	{
	}

	// Token: 0x06002A0F RID: 10767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A0F")]
	[Address(RVA = "0xCB5010", Offset = "0xCB4010", VA = "0x180CB5010")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002A10 RID: 10768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A10")]
	[Address(RVA = "0xCB5220", Offset = "0xCB4220", VA = "0x180CB5220")]
	public AudioControls()
	{
	}

	// Token: 0x04004499 RID: 17561
	[Token(Token = "0x4004499")]
	[FieldOffset(Offset = "0x18")]
	public AudioEvent footstepShoe;

	// Token: 0x0400449A RID: 17562
	[Token(Token = "0x400449A")]
	[FieldOffset(Offset = "0x20")]
	public AudioEvent footstepBoot;

	// Token: 0x0400449B RID: 17563
	[Token(Token = "0x400449B")]
	[FieldOffset(Offset = "0x28")]
	public AudioEvent footstepHeel;

	// Token: 0x0400449C RID: 17564
	[Token(Token = "0x400449C")]
	[FieldOffset(Offset = "0x30")]
	public AudioEvent footstepWaterWade;

	// Token: 0x0400449D RID: 17565
	[Token(Token = "0x400449D")]
	[FieldOffset(Offset = "0x38")]
	public AudioEvent playerFootstepShoe;

	// Token: 0x0400449E RID: 17566
	[Token(Token = "0x400449E")]
	[FieldOffset(Offset = "0x40")]
	public AudioEvent playerFootstepBoot;

	// Token: 0x0400449F RID: 17567
	[Token(Token = "0x400449F")]
	[FieldOffset(Offset = "0x48")]
	public AudioEvent playerFootstepHeel;

	// Token: 0x040044A0 RID: 17568
	[Token(Token = "0x40044A0")]
	[FieldOffset(Offset = "0x50")]
	public AudioEvent playerFootstepDuct;

	// Token: 0x040044A1 RID: 17569
	[Token(Token = "0x40044A1")]
	[FieldOffset(Offset = "0x58")]
	public AudioEvent playerWaterWade;

	// Token: 0x040044A2 RID: 17570
	[Token(Token = "0x40044A2")]
	[FieldOffset(Offset = "0x60")]
	public AudioEvent playerLandImpactMetal;

	// Token: 0x040044A3 RID: 17571
	[Token(Token = "0x40044A3")]
	[FieldOffset(Offset = "0x68")]
	public AudioEvent playerLandImpactConcrete;

	// Token: 0x040044A4 RID: 17572
	[Token(Token = "0x40044A4")]
	[FieldOffset(Offset = "0x70")]
	public AudioEvent playerLandImpactWood;

	// Token: 0x040044A5 RID: 17573
	[Token(Token = "0x40044A5")]
	[FieldOffset(Offset = "0x78")]
	public AudioEvent playerTripSound;

	// Token: 0x040044A6 RID: 17574
	[Token(Token = "0x40044A6")]
	[FieldOffset(Offset = "0x80")]
	public AudioEvent maleSnoreLight;

	// Token: 0x040044A7 RID: 17575
	[Token(Token = "0x40044A7")]
	[FieldOffset(Offset = "0x88")]
	public AudioEvent maleSnoreHeavy;

	// Token: 0x040044A8 RID: 17576
	[Token(Token = "0x40044A8")]
	[FieldOffset(Offset = "0x90")]
	public AudioEvent maleYawn;

	// Token: 0x040044A9 RID: 17577
	[Token(Token = "0x40044A9")]
	[FieldOffset(Offset = "0x98")]
	public AudioEvent maleSnort;

	// Token: 0x040044AA RID: 17578
	[Token(Token = "0x40044AA")]
	[FieldOffset(Offset = "0xA0")]
	public AudioEvent femaleSnoreLight;

	// Token: 0x040044AB RID: 17579
	[Token(Token = "0x40044AB")]
	[FieldOffset(Offset = "0xA8")]
	public AudioEvent femaleSnoreHeavy;

	// Token: 0x040044AC RID: 17580
	[Token(Token = "0x40044AC")]
	[FieldOffset(Offset = "0xB0")]
	public AudioEvent femaleYawn;

	// Token: 0x040044AD RID: 17581
	[Token(Token = "0x40044AD")]
	[FieldOffset(Offset = "0xB8")]
	public AudioEvent femaleSnort;

	// Token: 0x040044AE RID: 17582
	[Token(Token = "0x40044AE")]
	[FieldOffset(Offset = "0xC0")]
	public AudioEvent fridgeClose;

	// Token: 0x040044AF RID: 17583
	[Token(Token = "0x40044AF")]
	[FieldOffset(Offset = "0xC8")]
	public AudioEvent fridegOpen;

	// Token: 0x040044B0 RID: 17584
	[Token(Token = "0x40044B0")]
	[FieldOffset(Offset = "0xD0")]
	public AudioEvent tvShow;

	// Token: 0x040044B1 RID: 17585
	[Token(Token = "0x40044B1")]
	[FieldOffset(Offset = "0xD8")]
	public List<AudioEvent> keypadButtons;

	// Token: 0x040044B2 RID: 17586
	[Token(Token = "0x40044B2")]
	[FieldOffset(Offset = "0xE0")]
	public AudioEvent keypadPress;

	// Token: 0x040044B3 RID: 17587
	[Token(Token = "0x40044B3")]
	[FieldOffset(Offset = "0xE8")]
	public AudioEvent keypadClear;

	// Token: 0x040044B4 RID: 17588
	[Token(Token = "0x40044B4")]
	[FieldOffset(Offset = "0xF0")]
	public AudioEvent keypadAccept;

	// Token: 0x040044B5 RID: 17589
	[Token(Token = "0x40044B5")]
	[FieldOffset(Offset = "0xF8")]
	public AudioEvent keypadDeny;

	// Token: 0x040044B6 RID: 17590
	[Token(Token = "0x40044B6")]
	[FieldOffset(Offset = "0x100")]
	public AudioEvent keypadArm;

	// Token: 0x040044B7 RID: 17591
	[Token(Token = "0x40044B7")]
	[FieldOffset(Offset = "0x108")]
	public AudioEvent payphoneMoneyIn;

	// Token: 0x040044B8 RID: 17592
	[Token(Token = "0x40044B8")]
	[FieldOffset(Offset = "0x110")]
	public AudioEvent dialTone;

	// Token: 0x040044B9 RID: 17593
	[Token(Token = "0x40044B9")]
	[FieldOffset(Offset = "0x118")]
	public AudioEvent hangUp;

	// Token: 0x040044BA RID: 17594
	[Token(Token = "0x40044BA")]
	[FieldOffset(Offset = "0x120")]
	public AudioEvent phoneLineActive;

	// Token: 0x040044BB RID: 17595
	[Token(Token = "0x40044BB")]
	[FieldOffset(Offset = "0x128")]
	public AudioEvent phoneLineRing;

	// Token: 0x040044BC RID: 17596
	[Token(Token = "0x40044BC")]
	[FieldOffset(Offset = "0x130")]
	public AudioEvent phoneLineEngaged;

	// Token: 0x040044BD RID: 17597
	[Token(Token = "0x40044BD")]
	[FieldOffset(Offset = "0x138")]
	public AudioEvent phoneConnect;

	// Token: 0x040044BE RID: 17598
	[Token(Token = "0x40044BE")]
	[FieldOffset(Offset = "0x140")]
	public AudioEvent bargeDoorContact;

	// Token: 0x040044BF RID: 17599
	[Token(Token = "0x40044BF")]
	[FieldOffset(Offset = "0x148")]
	public AudioEvent bargeDoorBreak;

	// Token: 0x040044C0 RID: 17600
	[Token(Token = "0x40044C0")]
	[FieldOffset(Offset = "0x150")]
	public AudioEvent elevatorDing;

	// Token: 0x040044C1 RID: 17601
	[Token(Token = "0x40044C1")]
	[FieldOffset(Offset = "0x158")]
	public AudioEvent neonSignLoopSmall;

	// Token: 0x040044C2 RID: 17602
	[Token(Token = "0x40044C2")]
	[FieldOffset(Offset = "0x160")]
	public AudioEvent codebreakerSuccess;

	// Token: 0x040044C3 RID: 17603
	[Token(Token = "0x40044C3")]
	[FieldOffset(Offset = "0x168")]
	public AudioEvent elevatorMovement;

	// Token: 0x040044C4 RID: 17604
	[Token(Token = "0x40044C4")]
	[FieldOffset(Offset = "0x170")]
	public AudioEvent alarmPA;

	// Token: 0x040044C5 RID: 17605
	[Token(Token = "0x40044C5")]
	[FieldOffset(Offset = "0x178")]
	public AudioEvent drinkLoop;

	// Token: 0x040044C6 RID: 17606
	[Token(Token = "0x40044C6")]
	[FieldOffset(Offset = "0x180")]
	public AudioEvent spawnPlayer;

	// Token: 0x040044C7 RID: 17607
	[Token(Token = "0x40044C7")]
	[FieldOffset(Offset = "0x188")]
	public AudioEvent throwObject;

	// Token: 0x040044C8 RID: 17608
	[Token(Token = "0x40044C8")]
	[FieldOffset(Offset = "0x190")]
	public AudioEvent pickUpItemHeld;

	// Token: 0x040044C9 RID: 17609
	[Token(Token = "0x40044C9")]
	[FieldOffset(Offset = "0x198")]
	public AudioEvent lockpick;

	// Token: 0x040044CA RID: 17610
	[Token(Token = "0x40044CA")]
	[FieldOffset(Offset = "0x1A0")]
	public AudioEvent lockpickMetal;

	// Token: 0x040044CB RID: 17611
	[Token(Token = "0x40044CB")]
	[FieldOffset(Offset = "0x1A8")]
	public AudioEvent rummage;

	// Token: 0x040044CC RID: 17612
	[Token(Token = "0x40044CC")]
	[FieldOffset(Offset = "0x1B0")]
	public AudioEvent flashlightOn;

	// Token: 0x040044CD RID: 17613
	[Token(Token = "0x40044CD")]
	[FieldOffset(Offset = "0x1B8")]
	public AudioEvent flashlightOff;

	// Token: 0x040044CE RID: 17614
	[Token(Token = "0x40044CE")]
	[FieldOffset(Offset = "0x1C0")]
	public AudioEvent handcuff;

	// Token: 0x040044CF RID: 17615
	[Token(Token = "0x40044CF")]
	[FieldOffset(Offset = "0x1C8")]
	public AudioEvent handcuffArrestEnd;

	// Token: 0x040044D0 RID: 17616
	[Token(Token = "0x40044D0")]
	[FieldOffset(Offset = "0x1D0")]
	public AudioEvent waterCoolerRefillShort;

	// Token: 0x040044D1 RID: 17617
	[Token(Token = "0x40044D1")]
	[FieldOffset(Offset = "0x1D8")]
	public AudioEvent waterCoolerRefill;

	// Token: 0x040044D2 RID: 17618
	[Token(Token = "0x40044D2")]
	[FieldOffset(Offset = "0x1E0")]
	public AudioEvent moveObjectsToStorage;

	// Token: 0x040044D3 RID: 17619
	[Token(Token = "0x40044D3")]
	[FieldOffset(Offset = "0x1E8")]
	public AudioEvent brokenBone;

	// Token: 0x040044D4 RID: 17620
	[Token(Token = "0x40044D4")]
	[FieldOffset(Offset = "0x1F0")]
	public AudioEvent ambienceWind;

	// Token: 0x040044D5 RID: 17621
	[Token(Token = "0x40044D5")]
	[FieldOffset(Offset = "0x1F8")]
	public AudioEvent ambienceRain;

	// Token: 0x040044D6 RID: 17622
	[Token(Token = "0x40044D6")]
	[FieldOffset(Offset = "0x200")]
	public AudioEvent ambienceCity;

	// Token: 0x040044D7 RID: 17623
	[Token(Token = "0x40044D7")]
	[FieldOffset(Offset = "0x208")]
	public AudioEvent ambiencePA;

	// Token: 0x040044D8 RID: 17624
	[Token(Token = "0x40044D8")]
	[FieldOffset(Offset = "0x210")]
	public AudioEvent thunder;

	// Token: 0x040044D9 RID: 17625
	[Token(Token = "0x40044D9")]
	[FieldOffset(Offset = "0x218")]
	public AudioEvent gameMessage;

	// Token: 0x040044DA RID: 17626
	[Token(Token = "0x40044DA")]
	[FieldOffset(Offset = "0x220")]
	public AudioEvent socialLevelUp;

	// Token: 0x040044DB RID: 17627
	[Token(Token = "0x40044DB")]
	[FieldOffset(Offset = "0x228")]
	public AudioEvent revealCaseResults;

	// Token: 0x040044DC RID: 17628
	[Token(Token = "0x40044DC")]
	[FieldOffset(Offset = "0x230")]
	public AudioEvent gainSocialCredit;

	// Token: 0x040044DD RID: 17629
	[Token(Token = "0x40044DD")]
	[FieldOffset(Offset = "0x238")]
	public AudioEvent newMessage;

	// Token: 0x040044DE RID: 17630
	[Token(Token = "0x40044DE")]
	[FieldOffset(Offset = "0x240")]
	public AudioEvent bountyAdded;

	// Token: 0x040044DF RID: 17631
	[Token(Token = "0x40044DF")]
	[FieldOffset(Offset = "0x248")]
	public AudioEvent bountyEscapeComplete;

	// Token: 0x040044E0 RID: 17632
	[Token(Token = "0x40044E0")]
	[FieldOffset(Offset = "0x250")]
	public AudioEvent enforcerScannerMsg;

	// Token: 0x040044E1 RID: 17633
	[Token(Token = "0x40044E1")]
	[FieldOffset(Offset = "0x258")]
	public AudioEvent speakEvent;

	// Token: 0x040044E2 RID: 17634
	[Token(Token = "0x40044E2")]
	[FieldOffset(Offset = "0x260")]
	public AudioEvent shoutEvent;

	// Token: 0x040044E3 RID: 17635
	[Token(Token = "0x40044E3")]
	[FieldOffset(Offset = "0x268")]
	public AudioEvent screamEvent;

	// Token: 0x040044E4 RID: 17636
	[Token(Token = "0x40044E4")]
	[FieldOffset(Offset = "0x270")]
	public AudioEvent threatLoop;

	// Token: 0x040044E5 RID: 17637
	[Token(Token = "0x40044E5")]
	[FieldOffset(Offset = "0x278")]
	public AudioEvent typewriter;

	// Token: 0x040044E6 RID: 17638
	[Token(Token = "0x40044E6")]
	[FieldOffset(Offset = "0x280")]
	public float typewriterKeystrokeEventDelay;

	// Token: 0x040044E7 RID: 17639
	[Token(Token = "0x40044E7")]
	[FieldOffset(Offset = "0x284")]
	public float typewriterSpaceEventDelay;

	// Token: 0x040044E8 RID: 17640
	[Token(Token = "0x40044E8")]
	[FieldOffset(Offset = "0x288")]
	public AudioEvent interfaceEvent;

	// Token: 0x040044E9 RID: 17641
	[Token(Token = "0x40044E9")]
	[FieldOffset(Offset = "0x290")]
	public AudioEvent combatSnapshot;

	// Token: 0x040044EA RID: 17642
	[Token(Token = "0x40044EA")]
	[FieldOffset(Offset = "0x298")]
	public AudioEvent trespassingSnapshot;

	// Token: 0x040044EB RID: 17643
	[Token(Token = "0x40044EB")]
	[FieldOffset(Offset = "0x2A0")]
	public AudioEvent syncMachineSnapshot;

	// Token: 0x040044EC RID: 17644
	[Token(Token = "0x40044EC")]
	[FieldOffset(Offset = "0x2A8")]
	public AudioEvent musicOnlySnapshot;

	// Token: 0x040044ED RID: 17645
	[Token(Token = "0x40044ED")]
	[FieldOffset(Offset = "0x2B0")]
	public AudioEvent hyperacusisHeavy;

	// Token: 0x040044EE RID: 17646
	[Token(Token = "0x40044EE")]
	[FieldOffset(Offset = "0x2B8")]
	public AudioEvent hyperacusisMedium;

	// Token: 0x040044EF RID: 17647
	[Token(Token = "0x40044EF")]
	[FieldOffset(Offset = "0x2C0")]
	public AudioEvent hyperacusisLight;

	// Token: 0x040044F0 RID: 17648
	[Token(Token = "0x40044F0")]
	[FieldOffset(Offset = "0x2C8")]
	public AudioEvent bassReductionHeavy;

	// Token: 0x040044F1 RID: 17649
	[Token(Token = "0x40044F1")]
	[FieldOffset(Offset = "0x2D0")]
	public AudioEvent bassReductionLight;

	// Token: 0x040044F2 RID: 17650
	[Token(Token = "0x40044F2")]
	[FieldOffset(Offset = "0x2D8")]
	public AudioEvent panelIconButton;

	// Token: 0x040044F3 RID: 17651
	[Token(Token = "0x40044F3")]
	[FieldOffset(Offset = "0x2E0")]
	public AudioEvent stickyNoteCreateButton;

	// Token: 0x040044F4 RID: 17652
	[Token(Token = "0x40044F4")]
	[FieldOffset(Offset = "0x2E8")]
	public AudioEvent folderPickUp;

	// Token: 0x040044F5 RID: 17653
	[Token(Token = "0x40044F5")]
	[FieldOffset(Offset = "0x2F0")]
	public AudioEvent folderPutDown;

	// Token: 0x040044F6 RID: 17654
	[Token(Token = "0x40044F6")]
	[FieldOffset(Offset = "0x2F8")]
	public AudioEvent stickyNotePickUp;

	// Token: 0x040044F7 RID: 17655
	[Token(Token = "0x40044F7")]
	[FieldOffset(Offset = "0x300")]
	public AudioEvent stickyNotePutDown;

	// Token: 0x040044F8 RID: 17656
	[Token(Token = "0x40044F8")]
	[FieldOffset(Offset = "0x308")]
	public AudioEvent mapSlideIn;

	// Token: 0x040044F9 RID: 17657
	[Token(Token = "0x40044F9")]
	[FieldOffset(Offset = "0x310")]
	public AudioEvent mapSlideOut;

	// Token: 0x040044FA RID: 17658
	[Token(Token = "0x40044FA")]
	[FieldOffset(Offset = "0x318")]
	public AudioEvent crossOut;

	// Token: 0x040044FB RID: 17659
	[Token(Token = "0x40044FB")]
	[FieldOffset(Offset = "0x320")]
	public AudioEvent unPin;

	// Token: 0x040044FC RID: 17660
	[Token(Token = "0x40044FC")]
	[FieldOffset(Offset = "0x328")]
	public AudioEvent closeButton;

	// Token: 0x040044FD RID: 17661
	[Token(Token = "0x40044FD")]
	[FieldOffset(Offset = "0x330")]
	public AudioEvent tab;

	// Token: 0x040044FE RID: 17662
	[Token(Token = "0x40044FE")]
	[FieldOffset(Offset = "0x338")]
	public AudioEvent folderOpen;

	// Token: 0x040044FF RID: 17663
	[Token(Token = "0x40044FF")]
	[FieldOffset(Offset = "0x340")]
	public AudioEvent folderClose;

	// Token: 0x04004500 RID: 17664
	[Token(Token = "0x4004500")]
	[FieldOffset(Offset = "0x348")]
	public AudioEvent stickyOpen;

	// Token: 0x04004501 RID: 17665
	[Token(Token = "0x4004501")]
	[FieldOffset(Offset = "0x350")]
	public AudioEvent stickyClose;

	// Token: 0x04004502 RID: 17666
	[Token(Token = "0x4004502")]
	[FieldOffset(Offset = "0x358")]
	public AudioEvent pageForward;

	// Token: 0x04004503 RID: 17667
	[Token(Token = "0x4004503")]
	[FieldOffset(Offset = "0x360")]
	public AudioEvent pageBack;

	// Token: 0x04004504 RID: 17668
	[Token(Token = "0x4004504")]
	[FieldOffset(Offset = "0x368")]
	public AudioEvent minimiseButton;

	// Token: 0x04004505 RID: 17669
	[Token(Token = "0x4004505")]
	[FieldOffset(Offset = "0x370")]
	public AudioEvent itemEditAppear;

	// Token: 0x04004506 RID: 17670
	[Token(Token = "0x4004506")]
	[FieldOffset(Offset = "0x378")]
	public AudioEvent itemEditButton;

	// Token: 0x04004507 RID: 17671
	[Token(Token = "0x4004507")]
	[FieldOffset(Offset = "0x380")]
	public AudioEvent locationSetRouteButton;

	// Token: 0x04004508 RID: 17672
	[Token(Token = "0x4004508")]
	[FieldOffset(Offset = "0x388")]
	public AudioEvent locationButton;

	// Token: 0x04004509 RID: 17673
	[Token(Token = "0x4004509")]
	[FieldOffset(Offset = "0x390")]
	public AudioEvent inLineLink;

	// Token: 0x0400450A RID: 17674
	[Token(Token = "0x400450A")]
	[FieldOffset(Offset = "0x398")]
	public AudioEvent stickyNoteEdit;

	// Token: 0x0400450B RID: 17675
	[Token(Token = "0x400450B")]
	[FieldOffset(Offset = "0x3A0")]
	public AudioEvent clearDrawing;

	// Token: 0x0400450C RID: 17676
	[Token(Token = "0x400450C")]
	[FieldOffset(Offset = "0x3A8")]
	public AudioEvent tickbox;

	// Token: 0x0400450D RID: 17677
	[Token(Token = "0x400450D")]
	[FieldOffset(Offset = "0x3B0")]
	public AudioEvent mainButtonBack;

	// Token: 0x0400450E RID: 17678
	[Token(Token = "0x400450E")]
	[FieldOffset(Offset = "0x3B8")]
	public AudioEvent mainButtonForward;

	// Token: 0x0400450F RID: 17679
	[Token(Token = "0x400450F")]
	[FieldOffset(Offset = "0x3C0")]
	public AudioEvent mainButton;

	// Token: 0x04004510 RID: 17680
	[Token(Token = "0x4004510")]
	[FieldOffset(Offset = "0x3C8")]
	public AudioEvent mapControlButton;

	// Token: 0x04004511 RID: 17681
	[Token(Token = "0x4004511")]
	[FieldOffset(Offset = "0x3D0")]
	public AudioEvent syncDiskInstall;

	// Token: 0x04004512 RID: 17682
	[Token(Token = "0x4004512")]
	[FieldOffset(Offset = "0x3D8")]
	public AudioEvent syncDiskUninstall;

	// Token: 0x04004513 RID: 17683
	[Token(Token = "0x4004513")]
	[FieldOffset(Offset = "0x3E0")]
	public AudioEvent syncDiskUpgrade;

	// Token: 0x04004514 RID: 17684
	[Token(Token = "0x4004514")]
	[FieldOffset(Offset = "0x3E8")]
	public AudioEvent syncDiskInstallStatus;

	// Token: 0x04004515 RID: 17685
	[Token(Token = "0x4004515")]
	[FieldOffset(Offset = "0x3F0")]
	public AudioEvent pickUpMoney;

	// Token: 0x04004516 RID: 17686
	[Token(Token = "0x4004516")]
	[FieldOffset(Offset = "0x3F8")]
	public AudioEvent pickUpItem;

	// Token: 0x04004517 RID: 17687
	[Token(Token = "0x4004517")]
	[FieldOffset(Offset = "0x400")]
	public AudioEvent pickUpLockpicks;

	// Token: 0x04004518 RID: 17688
	[Token(Token = "0x4004518")]
	[FieldOffset(Offset = "0x408")]
	public AudioEvent dropItem;

	// Token: 0x04004519 RID: 17689
	[Token(Token = "0x4004519")]
	[FieldOffset(Offset = "0x410")]
	public AudioEvent purchaseItem;

	// Token: 0x0400451A RID: 17690
	[Token(Token = "0x400451A")]
	[FieldOffset(Offset = "0x418")]
	public AudioEvent motionTrackerPing;

	// Token: 0x0400451B RID: 17691
	[Token(Token = "0x400451B")]
	[FieldOffset(Offset = "0x420")]
	public AudioEvent printScannerLoop;

	// Token: 0x0400451C RID: 17692
	[Token(Token = "0x400451C")]
	[FieldOffset(Offset = "0x428")]
	public AudioEvent printScannerHolster;

	// Token: 0x0400451D RID: 17693
	[Token(Token = "0x400451D")]
	[FieldOffset(Offset = "0x430")]
	public AudioEvent printScannerSelect;

	// Token: 0x0400451E RID: 17694
	[Token(Token = "0x400451E")]
	[FieldOffset(Offset = "0x438")]
	public AudioEvent caseComplete;

	// Token: 0x0400451F RID: 17695
	[Token(Token = "0x400451F")]
	[FieldOffset(Offset = "0x440")]
	public AudioEvent caseUnsolved;

	// Token: 0x04004520 RID: 17696
	[Token(Token = "0x4004520")]
	[FieldOffset(Offset = "0x448")]
	public AudioEvent newMurderCase;

	// Token: 0x04004521 RID: 17697
	[Token(Token = "0x4004521")]
	[FieldOffset(Offset = "0x450")]
	public AudioEvent newApartment;

	// Token: 0x04004522 RID: 17698
	[Token(Token = "0x4004522")]
	[FieldOffset(Offset = "0x458")]
	public AudioEvent furniturePlacement;

	// Token: 0x04004523 RID: 17699
	[Token(Token = "0x4004523")]
	[FieldOffset(Offset = "0x460")]
	public AudioEvent caseResultCorrect;

	// Token: 0x04004524 RID: 17700
	[Token(Token = "0x4004524")]
	[FieldOffset(Offset = "0x468")]
	public AudioEvent caseResultIncorrect;

	// Token: 0x04004525 RID: 17701
	[Token(Token = "0x4004525")]
	[FieldOffset(Offset = "0x470")]
	public AudioEvent caseProcessing;

	// Token: 0x04004526 RID: 17702
	[Token(Token = "0x4004526")]
	[FieldOffset(Offset = "0x478")]
	public AudioEvent caseSubmitted;

	// Token: 0x04004527 RID: 17703
	[Token(Token = "0x4004527")]
	[FieldOffset(Offset = "0x480")]
	public AudioEvent computerHDDLoading;

	// Token: 0x04004528 RID: 17704
	[Token(Token = "0x4004528")]
	[FieldOffset(Offset = "0x488")]
	public AudioEvent computerCursorClick;

	// Token: 0x04004529 RID: 17705
	[Token(Token = "0x4004529")]
	[FieldOffset(Offset = "0x490")]
	public AudioEvent computerKeyboardKey;

	// Token: 0x0400452A RID: 17706
	[Token(Token = "0x400452A")]
	[FieldOffset(Offset = "0x498")]
	public AudioEvent computerInvalidPasscode;

	// Token: 0x0400452B RID: 17707
	[Token(Token = "0x400452B")]
	[FieldOffset(Offset = "0x4A0")]
	public AudioEvent computerValidPasscode;

	// Token: 0x0400452C RID: 17708
	[Token(Token = "0x400452C")]
	[FieldOffset(Offset = "0x4A8")]
	public AudioEvent computerPrint;

	// Token: 0x0400452D RID: 17709
	[Token(Token = "0x400452D")]
	[FieldOffset(Offset = "0x4B0")]
	public AudioEvent watchAlarm;

	// Token: 0x0400452E RID: 17710
	[Token(Token = "0x400452E")]
	[FieldOffset(Offset = "0x4B8")]
	public AudioEvent timeForward;

	// Token: 0x0400452F RID: 17711
	[Token(Token = "0x400452F")]
	[FieldOffset(Offset = "0x4C0")]
	public AudioEvent timeBackward;

	// Token: 0x04004530 RID: 17712
	[Token(Token = "0x4004530")]
	[FieldOffset(Offset = "0x4C8")]
	public AudioEvent watchToggleHoursMinutes;

	// Token: 0x04004531 RID: 17713
	[Token(Token = "0x4004531")]
	[FieldOffset(Offset = "0x4D0")]
	public AudioEvent setAlarm;

	// Token: 0x04004532 RID: 17714
	[Token(Token = "0x4004532")]
	[FieldOffset(Offset = "0x4D8")]
	public AudioEvent wristwatchTickTimeLoop;

	// Token: 0x04004533 RID: 17715
	[Token(Token = "0x4004533")]
	[FieldOffset(Offset = "0x4E0")]
	public AudioEvent sentryGunFire;

	// Token: 0x04004534 RID: 17716
	[Token(Token = "0x4004534")]
	[FieldOffset(Offset = "0x4E8")]
	public AudioEvent sentryGunSearchPulse;

	// Token: 0x04004535 RID: 17717
	[Token(Token = "0x4004535")]
	[FieldOffset(Offset = "0x4F0")]
	public AudioEvent sentryGunTargetAcquire;

	// Token: 0x04004536 RID: 17718
	[Token(Token = "0x4004536")]
	[FieldOffset(Offset = "0x4F8")]
	public AudioEvent sentryGunTurnLoop;

	// Token: 0x04004537 RID: 17719
	[Token(Token = "0x4004537")]
	[FieldOffset(Offset = "0x500")]
	public AudioEvent securityCameraAlert;

	// Token: 0x04004538 RID: 17720
	[Token(Token = "0x4004538")]
	[FieldOffset(Offset = "0x508")]
	public AudioEvent collapseOnFloor;

	// Token: 0x04004539 RID: 17721
	[Token(Token = "0x4004539")]
	[FieldOffset(Offset = "0x510")]
	public AudioEvent punchHitFabric;

	// Token: 0x0400453A RID: 17722
	[Token(Token = "0x400453A")]
	[FieldOffset(Offset = "0x518")]
	public AudioEvent punchHitWood;

	// Token: 0x0400453B RID: 17723
	[Token(Token = "0x400453B")]
	[FieldOffset(Offset = "0x520")]
	public AudioEvent punchHitCarpet;

	// Token: 0x0400453C RID: 17724
	[Token(Token = "0x400453C")]
	[FieldOffset(Offset = "0x528")]
	public AudioEvent punchHitPlaster;

	// Token: 0x0400453D RID: 17725
	[Token(Token = "0x400453D")]
	[FieldOffset(Offset = "0x530")]
	public AudioEvent punchHitConcrete;

	// Token: 0x0400453E RID: 17726
	[Token(Token = "0x400453E")]
	[FieldOffset(Offset = "0x538")]
	public AudioEvent punchHitTile;

	// Token: 0x0400453F RID: 17727
	[Token(Token = "0x400453F")]
	[FieldOffset(Offset = "0x540")]
	public AudioEvent punchHitGlass;

	// Token: 0x04004540 RID: 17728
	[Token(Token = "0x4004540")]
	[FieldOffset(Offset = "0x548")]
	public AudioEvent punchHitMetal;

	// Token: 0x04004541 RID: 17729
	[Token(Token = "0x4004541")]
	[FieldOffset(Offset = "0x550")]
	public AudioEvent punchHitFlesh;

	// Token: 0x04004542 RID: 17730
	[Token(Token = "0x4004542")]
	[FieldOffset(Offset = "0x558")]
	public AudioEvent punchHitPlayer;

	// Token: 0x04004543 RID: 17731
	[Token(Token = "0x4004543")]
	[FieldOffset(Offset = "0x560")]
	public AudioEvent punchHitWall;

	// Token: 0x04004544 RID: 17732
	[Token(Token = "0x4004544")]
	[FieldOffset(Offset = "0x568")]
	public AudioEvent sniperKillShot;

	// Token: 0x04004545 RID: 17733
	[Token(Token = "0x4004545")]
	[FieldOffset(Offset = "0x570")]
	public AudioEvent sniperStreetShot;

	// Token: 0x04004546 RID: 17734
	[Token(Token = "0x4004546")]
	[FieldOffset(Offset = "0x578")]
	public AudioEvent grenadeBeep;

	// Token: 0x04004547 RID: 17735
	[Token(Token = "0x4004547")]
	[FieldOffset(Offset = "0x580")]
	public AudioEvent flashBombDetonate;

	// Token: 0x04004548 RID: 17736
	[Token(Token = "0x4004548")]
	[FieldOffset(Offset = "0x588")]
	public AudioEvent incapacitatorDetonate;

	// Token: 0x04004549 RID: 17737
	[Token(Token = "0x4004549")]
	[FieldOffset(Offset = "0x590")]
	public AudioEvent cameraFlash;

	// Token: 0x0400454A RID: 17738
	[Token(Token = "0x400454A")]
	[FieldOffset(Offset = "0x598")]
	public AudioEvent oceanSplashSmall;

	// Token: 0x0400454B RID: 17739
	[Token(Token = "0x400454B")]
	[FieldOffset(Offset = "0x5A0")]
	public AudioEvent oceanSplashMedium;

	// Token: 0x0400454C RID: 17740
	[Token(Token = "0x400454C")]
	[FieldOffset(Offset = "0x5A8")]
	public AudioEvent oceanSplashLarge;

	// Token: 0x0400454D RID: 17741
	[Token(Token = "0x400454D")]
	[FieldOffset(Offset = "0x5B0")]
	public AudioEvent dragBody;

	// Token: 0x0400454E RID: 17742
	[Token(Token = "0x400454E")]
	[FieldOffset(Offset = "0x5B8")]
	public AudioEvent umbrellaOpenNPC;

	// Token: 0x0400454F RID: 17743
	[Token(Token = "0x400454F")]
	[FieldOffset(Offset = "0x5C0")]
	public AudioEvent umbrellaCloseNPC;

	// Token: 0x04004550 RID: 17744
	[Token(Token = "0x4004550")]
	[FieldOffset(Offset = "0x5C8")]
	public AudioEvent playerEnterVent;

	// Token: 0x04004551 RID: 17745
	[Token(Token = "0x4004551")]
	[FieldOffset(Offset = "0x5D0")]
	public AudioEvent snailLoop;

	// Token: 0x04004552 RID: 17746
	[Token(Token = "0x4004552")]
	[FieldOffset(Offset = "0x5D8")]
	[NonSerialized]
	public AudioController.LoopingSoundInfo caseProcessingLoop;

	// Token: 0x04004553 RID: 17747
	[Token(Token = "0x4004553")]
	[FieldOffset(Offset = "0x0")]
	private static AudioControls _instance;
}
