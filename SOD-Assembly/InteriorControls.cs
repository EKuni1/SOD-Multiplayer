using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008C0 RID: 2240
[Token(Token = "0x20008C0")]
public class InteriorControls : MonoBehaviour
{
	// Token: 0x17000154 RID: 340
	// (get) Token: 0x06002A43 RID: 10819 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000154")]
	public static InteriorControls Instance
	{
		[Token(Token = "0x6002A43")]
		[Address(RVA = "0xCBD150", Offset = "0xCBC150", VA = "0x180CBD150")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002A44 RID: 10820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A44")]
	[Address(RVA = "0xCBD190", Offset = "0xCBC190", VA = "0x180CBD190")]
	private void Awake()
	{
	}

	// Token: 0x06002A45 RID: 10821 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A45")]
	[Address(RVA = "0xCBD630", Offset = "0xCBC630", VA = "0x180CBD630")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002A46 RID: 10822 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A46")]
	[Address(RVA = "0xCBD840", Offset = "0xCBC840", VA = "0x180CBD840")]
	public InteriorControls()
	{
	}

	// Token: 0x0400487C RID: 18556
	[Token(Token = "0x400487C")]
	[FieldOffset(Offset = "0x18")]
	public List<Color> woods;

	// Token: 0x0400487D RID: 18557
	[Token(Token = "0x400487D")]
	[FieldOffset(Offset = "0x20")]
	public MaterialGroupPreset.MaterialVariation defaultVariation;

	// Token: 0x0400487E RID: 18558
	[Token(Token = "0x400487E")]
	[FieldOffset(Offset = "0x28")]
	public InteractablePreset cctvPreset;

	// Token: 0x0400487F RID: 18559
	[Token(Token = "0x400487F")]
	[FieldOffset(Offset = "0x30")]
	public InteractablePreset peekUnderDoor;

	// Token: 0x04004880 RID: 18560
	[Token(Token = "0x4004880")]
	[FieldOffset(Offset = "0x38")]
	public InteractablePreset lightswitch;

	// Token: 0x04004881 RID: 18561
	[Token(Token = "0x4004881")]
	[FieldOffset(Offset = "0x40")]
	public AddressPreset lobbyAddressPreset;

	// Token: 0x04004882 RID: 18562
	[Token(Token = "0x4004882")]
	[FieldOffset(Offset = "0x48")]
	public StairwellPreset defaultStairwell;

	// Token: 0x04004883 RID: 18563
	[Token(Token = "0x4004883")]
	[FieldOffset(Offset = "0x50")]
	public StairwellPreset defaultStairwellInverted;

	// Token: 0x04004884 RID: 18564
	[Token(Token = "0x4004884")]
	[FieldOffset(Offset = "0x58")]
	public StairwellPreset defaultStairwellLarge;

	// Token: 0x04004885 RID: 18565
	[Token(Token = "0x4004885")]
	[FieldOffset(Offset = "0x60")]
	public InteractablePreset elevatorUpButton;

	// Token: 0x04004886 RID: 18566
	[Token(Token = "0x4004886")]
	[FieldOffset(Offset = "0x68")]
	public InteractablePreset elevatorDownButton;

	// Token: 0x04004887 RID: 18567
	[Token(Token = "0x4004887")]
	[FieldOffset(Offset = "0x70")]
	public InteractablePreset elevatorControls;

	// Token: 0x04004888 RID: 18568
	[Token(Token = "0x4004888")]
	[FieldOffset(Offset = "0x78")]
	public InteractablePreset doorC;

	// Token: 0x04004889 RID: 18569
	[Token(Token = "0x4004889")]
	[FieldOffset(Offset = "0x80")]
	public InteractablePreset keypad;

	// Token: 0x0400488A RID: 18570
	[Token(Token = "0x400488A")]
	[FieldOffset(Offset = "0x88")]
	public InteractablePreset cruncher;

	// Token: 0x0400488B RID: 18571
	[Token(Token = "0x400488B")]
	[FieldOffset(Offset = "0x90")]
	public InteractablePreset door;

	// Token: 0x0400488C RID: 18572
	[Token(Token = "0x400488C")]
	[FieldOffset(Offset = "0x98")]
	public InteractablePreset activeCodebreaker;

	// Token: 0x0400488D RID: 18573
	[Token(Token = "0x400488D")]
	[FieldOffset(Offset = "0xA0")]
	public InteractablePreset activeDoorWedge;

	// Token: 0x0400488E RID: 18574
	[Token(Token = "0x400488E")]
	[FieldOffset(Offset = "0xA8")]
	public InteractablePreset activeTracker;

	// Token: 0x0400488F RID: 18575
	[Token(Token = "0x400488F")]
	[FieldOffset(Offset = "0xB0")]
	public InteractablePreset activeFlashbomb;

	// Token: 0x04004890 RID: 18576
	[Token(Token = "0x4004890")]
	[FieldOffset(Offset = "0xB8")]
	public InteractablePreset activeIncapacitator;

	// Token: 0x04004891 RID: 18577
	[Token(Token = "0x4004891")]
	[FieldOffset(Offset = "0xC0")]
	public InteractablePreset flowersAffair;

	// Token: 0x04004892 RID: 18578
	[Token(Token = "0x4004892")]
	[FieldOffset(Offset = "0xC8")]
	public InteractablePreset storageBox;

	// Token: 0x04004893 RID: 18579
	[Token(Token = "0x4004893")]
	[FieldOffset(Offset = "0xD0")]
	public InteractablePreset paperclip;

	// Token: 0x04004894 RID: 18580
	[Token(Token = "0x4004894")]
	[FieldOffset(Offset = "0xD8")]
	public InteractablePreset salesLedger;

	// Token: 0x04004895 RID: 18581
	[Token(Token = "0x4004895")]
	[FieldOffset(Offset = "0xE0")]
	public InteractablePreset telephoneRouter;

	// Token: 0x04004896 RID: 18582
	[Token(Token = "0x4004896")]
	[FieldOffset(Offset = "0xE8")]
	public InteractablePreset telephoneRouterDoor;

	// Token: 0x04004897 RID: 18583
	[Token(Token = "0x4004897")]
	[FieldOffset(Offset = "0xF0")]
	public InteractablePreset saleNote;

	// Token: 0x04004898 RID: 18584
	[Token(Token = "0x4004898")]
	[FieldOffset(Offset = "0xF8")]
	public CruncherAppPreset loginApp;

	// Token: 0x04004899 RID: 18585
	[Token(Token = "0x4004899")]
	[FieldOffset(Offset = "0x100")]
	public InteractablePreset shotgun;

	// Token: 0x0400489A RID: 18586
	[Token(Token = "0x400489A")]
	[FieldOffset(Offset = "0x108")]
	public InteractablePreset codebreaker;

	// Token: 0x0400489B RID: 18587
	[Token(Token = "0x400489B")]
	[FieldOffset(Offset = "0x110")]
	public InteractablePreset doorWedge;

	// Token: 0x0400489C RID: 18588
	[Token(Token = "0x400489C")]
	[FieldOffset(Offset = "0x118")]
	public InteractablePreset tracker;

	// Token: 0x0400489D RID: 18589
	[Token(Token = "0x400489D")]
	[FieldOffset(Offset = "0x120")]
	public InteractablePreset flashbomb;

	// Token: 0x0400489E RID: 18590
	[Token(Token = "0x400489E")]
	[FieldOffset(Offset = "0x128")]
	public InteractablePreset incapacitator;

	// Token: 0x0400489F RID: 18591
	[Token(Token = "0x400489F")]
	[FieldOffset(Offset = "0x130")]
	public InteractablePreset printReader;

	// Token: 0x040048A0 RID: 18592
	[Token(Token = "0x40048A0")]
	[FieldOffset(Offset = "0x138")]
	public InteractablePreset handcuffs;

	// Token: 0x040048A1 RID: 18593
	[Token(Token = "0x40048A1")]
	[FieldOffset(Offset = "0x140")]
	public InteractablePreset policeBadge;

	// Token: 0x040048A2 RID: 18594
	[Token(Token = "0x40048A2")]
	[FieldOffset(Offset = "0x148")]
	public InteractablePreset lockpickKit;

	// Token: 0x040048A3 RID: 18595
	[Token(Token = "0x40048A3")]
	[FieldOffset(Offset = "0x150")]
	public InteractablePreset detectiveStuff;

	// Token: 0x040048A4 RID: 18596
	[Token(Token = "0x40048A4")]
	[FieldOffset(Offset = "0x158")]
	public InteractablePreset briefcaseCustom;

	// Token: 0x040048A5 RID: 18597
	[Token(Token = "0x40048A5")]
	[FieldOffset(Offset = "0x160")]
	public InteractablePreset codebreakerUsed;

	// Token: 0x040048A6 RID: 18598
	[Token(Token = "0x40048A6")]
	[FieldOffset(Offset = "0x168")]
	public InteractablePreset doorWedgeUsed;

	// Token: 0x040048A7 RID: 18599
	[Token(Token = "0x40048A7")]
	[FieldOffset(Offset = "0x170")]
	public FirstPersonItem FPCodebreaker;

	// Token: 0x040048A8 RID: 18600
	[Token(Token = "0x40048A8")]
	[FieldOffset(Offset = "0x178")]
	public FirstPersonItem FPCamera;

	// Token: 0x040048A9 RID: 18601
	[Token(Token = "0x40048A9")]
	[FieldOffset(Offset = "0x180")]
	public FirstPersonItem FPHandcuffs;

	// Token: 0x040048AA RID: 18602
	[Token(Token = "0x40048AA")]
	[FieldOffset(Offset = "0x188")]
	public FirstPersonItem FPNewspaper;

	// Token: 0x040048AB RID: 18603
	[Token(Token = "0x40048AB")]
	[FieldOffset(Offset = "0x190")]
	public MurderWeaponPreset fistsWeapon;

	// Token: 0x040048AC RID: 18604
	[Token(Token = "0x40048AC")]
	[FieldOffset(Offset = "0x198")]
	public float roomRankingRandomThreshold;

	// Token: 0x040048AD RID: 18605
	[Token(Token = "0x40048AD")]
	[FieldOffset(Offset = "0x19C")]
	public float lightZoneMinDistance;

	// Token: 0x040048AE RID: 18606
	[Token(Token = "0x40048AE")]
	[FieldOffset(Offset = "0x1A0")]
	public bool oneAreaLightPerRoom;

	// Token: 0x040048AF RID: 18607
	[Token(Token = "0x40048AF")]
	[FieldOffset(Offset = "0x1A4")]
	public int maxClustersPerRoom;

	// Token: 0x040048B0 RID: 18608
	[Token(Token = "0x40048B0")]
	[FieldOffset(Offset = "0x1A8")]
	public float roomSizeClusterAttemptMultiplier;

	// Token: 0x040048B1 RID: 18609
	[Token(Token = "0x40048B1")]
	[FieldOffset(Offset = "0x1B0")]
	public GameObject bug;

	// Token: 0x040048B2 RID: 18610
	[Token(Token = "0x40048B2")]
	[FieldOffset(Offset = "0x1B8")]
	public InteractablePreset businessCard;

	// Token: 0x040048B3 RID: 18611
	[Token(Token = "0x40048B3")]
	[FieldOffset(Offset = "0x1C0")]
	public InteractablePreset workRota;

	// Token: 0x040048B4 RID: 18612
	[Token(Token = "0x40048B4")]
	[FieldOffset(Offset = "0x1C8")]
	public InteractablePreset employmentContractHome;

	// Token: 0x040048B5 RID: 18613
	[Token(Token = "0x40048B5")]
	[FieldOffset(Offset = "0x1D0")]
	public InteractablePreset employmentContractWork;

	// Token: 0x040048B6 RID: 18614
	[Token(Token = "0x40048B6")]
	[FieldOffset(Offset = "0x1D8")]
	public InteractablePreset workID;

	// Token: 0x040048B7 RID: 18615
	[Token(Token = "0x40048B7")]
	[FieldOffset(Offset = "0x1E0")]
	public InteractablePreset wallet;

	// Token: 0x040048B8 RID: 18616
	[Token(Token = "0x40048B8")]
	[FieldOffset(Offset = "0x1E8")]
	public InteractablePreset diary;

	// Token: 0x040048B9 RID: 18617
	[Token(Token = "0x40048B9")]
	[FieldOffset(Offset = "0x1F0")]
	public InteractablePreset photo;

	// Token: 0x040048BA RID: 18618
	[Token(Token = "0x40048BA")]
	[FieldOffset(Offset = "0x1F8")]
	public InteractablePreset namePlacard;

	// Token: 0x040048BB RID: 18619
	[Token(Token = "0x40048BB")]
	[FieldOffset(Offset = "0x200")]
	public InteractablePreset employeePhoto;

	// Token: 0x040048BC RID: 18620
	[Token(Token = "0x40048BC")]
	[FieldOffset(Offset = "0x208")]
	public InteractablePreset birthdayCard;

	// Token: 0x040048BD RID: 18621
	[Token(Token = "0x40048BD")]
	[FieldOffset(Offset = "0x210")]
	public InteractablePreset note;

	// Token: 0x040048BE RID: 18622
	[Token(Token = "0x40048BE")]
	[FieldOffset(Offset = "0x218")]
	public InteractablePreset letter;

	// Token: 0x040048BF RID: 18623
	[Token(Token = "0x40048BF")]
	[FieldOffset(Offset = "0x220")]
	public InteractablePreset moneyLots;

	// Token: 0x040048C0 RID: 18624
	[Token(Token = "0x40048C0")]
	[FieldOffset(Offset = "0x228")]
	public InteractablePreset travelReceipt;

	// Token: 0x040048C1 RID: 18625
	[Token(Token = "0x40048C1")]
	[FieldOffset(Offset = "0x230")]
	public InteractablePreset vmailLetter;

	// Token: 0x040048C2 RID: 18626
	[Token(Token = "0x40048C2")]
	[FieldOffset(Offset = "0x238")]
	public InteractablePreset vmailPrintout;

	// Token: 0x040048C3 RID: 18627
	[Token(Token = "0x40048C3")]
	[FieldOffset(Offset = "0x240")]
	public InteractablePreset surveillancePrintout;

	// Token: 0x040048C4 RID: 18628
	[Token(Token = "0x40048C4")]
	[FieldOffset(Offset = "0x248")]
	public InteractablePreset vmailPrintoutStatic;

	// Token: 0x040048C5 RID: 18629
	[Token(Token = "0x40048C5")]
	[FieldOffset(Offset = "0x250")]
	public InteractablePreset key;

	// Token: 0x040048C6 RID: 18630
	[Token(Token = "0x40048C6")]
	[FieldOffset(Offset = "0x258")]
	public InteractablePreset keyTabletopOnly;

	// Token: 0x040048C7 RID: 18631
	[Token(Token = "0x40048C7")]
	[FieldOffset(Offset = "0x260")]
	public SubObjectClassPreset keyHidingPlace;

	// Token: 0x040048C8 RID: 18632
	[Token(Token = "0x40048C8")]
	[FieldOffset(Offset = "0x268")]
	public InteractablePreset noodleBox;

	// Token: 0x040048C9 RID: 18633
	[Token(Token = "0x40048C9")]
	[FieldOffset(Offset = "0x270")]
	public SubObjectClassPreset telephone;

	// Token: 0x040048CA RID: 18634
	[Token(Token = "0x40048CA")]
	[FieldOffset(Offset = "0x278")]
	public SubObjectClassPreset payphone;

	// Token: 0x040048CB RID: 18635
	[Token(Token = "0x40048CB")]
	[FieldOffset(Offset = "0x280")]
	public SubObjectClassPreset fridge;

	// Token: 0x040048CC RID: 18636
	[Token(Token = "0x40048CC")]
	[FieldOffset(Offset = "0x288")]
	public InteractablePreset suitcase;

	// Token: 0x040048CD RID: 18637
	[Token(Token = "0x40048CD")]
	[FieldOffset(Offset = "0x290")]
	public InteractablePreset hairpin;

	// Token: 0x040048CE RID: 18638
	[Token(Token = "0x40048CE")]
	[FieldOffset(Offset = "0x298")]
	public InteractablePreset residentsContract;

	// Token: 0x040048CF RID: 18639
	[Token(Token = "0x40048CF")]
	[FieldOffset(Offset = "0x2A0")]
	public InteractablePreset birthCertificate;

	// Token: 0x040048D0 RID: 18640
	[Token(Token = "0x40048D0")]
	[FieldOffset(Offset = "0x2A8")]
	public InteractablePreset bankStatement;

	// Token: 0x040048D1 RID: 18641
	[Token(Token = "0x40048D1")]
	[FieldOffset(Offset = "0x2B0")]
	public InteractablePreset medicalDetails;

	// Token: 0x040048D2 RID: 18642
	[Token(Token = "0x40048D2")]
	[FieldOffset(Offset = "0x2B8")]
	public InteractablePreset homeFilePreset;

	// Token: 0x040048D3 RID: 18643
	[Token(Token = "0x40048D3")]
	[FieldOffset(Offset = "0x2C0")]
	public EvidencePreset homeFile;

	// Token: 0x040048D4 RID: 18644
	[Token(Token = "0x40048D4")]
	[FieldOffset(Offset = "0x2C8")]
	public List<InteractablePreset> clothesOnFloor;

	// Token: 0x040048D5 RID: 18645
	[Token(Token = "0x40048D5")]
	[FieldOffset(Offset = "0x2D0")]
	public InteractablePreset bookShelf;

	// Token: 0x040048D6 RID: 18646
	[Token(Token = "0x40048D6")]
	[FieldOffset(Offset = "0x2D8")]
	public InteractablePreset bookNonShelf;

	// Token: 0x040048D7 RID: 18647
	[Token(Token = "0x40048D7")]
	[FieldOffset(Offset = "0x2E0")]
	public InteractablePreset bookNonShelfSecret;

	// Token: 0x040048D8 RID: 18648
	[Token(Token = "0x40048D8")]
	[FieldOffset(Offset = "0x2E8")]
	public InteractablePreset receipt;

	// Token: 0x040048D9 RID: 18649
	[Token(Token = "0x40048D9")]
	[FieldOffset(Offset = "0x2F0")]
	public InteractablePreset flyer;

	// Token: 0x040048DA RID: 18650
	[Token(Token = "0x40048DA")]
	[FieldOffset(Offset = "0x2F8")]
	public InteractablePreset document;

	// Token: 0x040048DB RID: 18651
	[Token(Token = "0x40048DB")]
	[FieldOffset(Offset = "0x300")]
	public InteractablePreset fieldsAd;

	// Token: 0x040048DC RID: 18652
	[Token(Token = "0x40048DC")]
	[FieldOffset(Offset = "0x308")]
	public InteractablePreset policeSupportFlyer;

	// Token: 0x040048DD RID: 18653
	[Token(Token = "0x40048DD")]
	[FieldOffset(Offset = "0x310")]
	public InteractablePreset toothbrush;

	// Token: 0x040048DE RID: 18654
	[Token(Token = "0x40048DE")]
	[FieldOffset(Offset = "0x318")]
	public InteractablePreset painkillers;

	// Token: 0x040048DF RID: 18655
	[Token(Token = "0x40048DF")]
	[FieldOffset(Offset = "0x320")]
	public InteractablePreset bandage;

	// Token: 0x040048E0 RID: 18656
	[Token(Token = "0x40048E0")]
	[FieldOffset(Offset = "0x328")]
	public InteractablePreset splint;

	// Token: 0x040048E1 RID: 18657
	[Token(Token = "0x40048E1")]
	[FieldOffset(Offset = "0x330")]
	public InteractablePreset binNote;

	// Token: 0x040048E2 RID: 18658
	[Token(Token = "0x40048E2")]
	[FieldOffset(Offset = "0x338")]
	public InteractablePreset crumpledPaper;

	// Token: 0x040048E3 RID: 18659
	[Token(Token = "0x40048E3")]
	[FieldOffset(Offset = "0x340")]
	public InteractablePreset handgun;

	// Token: 0x040048E4 RID: 18660
	[Token(Token = "0x40048E4")]
	[FieldOffset(Offset = "0x348")]
	public InteractablePreset silencer;

	// Token: 0x040048E5 RID: 18661
	[Token(Token = "0x40048E5")]
	[FieldOffset(Offset = "0x350")]
	public InteractablePreset ammo1;

	// Token: 0x040048E6 RID: 18662
	[Token(Token = "0x40048E6")]
	[FieldOffset(Offset = "0x358")]
	public InteractablePreset coffeeHomemade;

	// Token: 0x040048E7 RID: 18663
	[Token(Token = "0x40048E7")]
	[FieldOffset(Offset = "0x360")]
	public InteractablePreset teaHomemade;

	// Token: 0x040048E8 RID: 18664
	[Token(Token = "0x40048E8")]
	[FieldOffset(Offset = "0x368")]
	public InteractablePreset stovetopKettle;

	// Token: 0x040048E9 RID: 18665
	[Token(Token = "0x40048E9")]
	[FieldOffset(Offset = "0x370")]
	public InteractablePreset streetCrimeScene;

	// Token: 0x040048EA RID: 18666
	[Token(Token = "0x40048EA")]
	[FieldOffset(Offset = "0x378")]
	public InteractablePreset creditCard;

	// Token: 0x040048EB RID: 18667
	[Token(Token = "0x40048EB")]
	[FieldOffset(Offset = "0x380")]
	public InteractablePreset donorCard;

	// Token: 0x040048EC RID: 18668
	[Token(Token = "0x40048EC")]
	[FieldOffset(Offset = "0x388")]
	public SubObjectClassPreset sideJobHiddenItemClass;

	// Token: 0x040048ED RID: 18669
	[Token(Token = "0x40048ED")]
	[FieldOffset(Offset = "0x390")]
	public DoorPreset defaultDoor;

	// Token: 0x040048EE RID: 18670
	[Token(Token = "0x40048EE")]
	[FieldOffset(Offset = "0x398")]
	public RoomConfiguration bedroom;

	// Token: 0x040048EF RID: 18671
	[Token(Token = "0x40048EF")]
	[FieldOffset(Offset = "0x3A0")]
	public RoomConfiguration lounge;

	// Token: 0x040048F0 RID: 18672
	[Token(Token = "0x40048F0")]
	[FieldOffset(Offset = "0x3A8")]
	public RoomConfiguration kitchen;

	// Token: 0x040048F1 RID: 18673
	[Token(Token = "0x40048F1")]
	[FieldOffset(Offset = "0x3B0")]
	public RoomConfiguration closet;

	// Token: 0x040048F2 RID: 18674
	[Token(Token = "0x40048F2")]
	[FieldOffset(Offset = "0x3B8")]
	public FurnitureClass bed;

	// Token: 0x040048F3 RID: 18675
	[Token(Token = "0x40048F3")]
	[FieldOffset(Offset = "0x3C0")]
	public FurnitureClass bedsideCabinet;

	// Token: 0x040048F4 RID: 18676
	[Token(Token = "0x40048F4")]
	[FieldOffset(Offset = "0x3C8")]
	public FurnitureClass safe;

	// Token: 0x040048F5 RID: 18677
	[Token(Token = "0x40048F5")]
	[FieldOffset(Offset = "0x3D0")]
	public FurnitureClass television;

	// Token: 0x040048F6 RID: 18678
	[Token(Token = "0x40048F6")]
	[FieldOffset(Offset = "0x3D8")]
	public FurnitureClass telephoneTable;

	// Token: 0x040048F7 RID: 18679
	[Token(Token = "0x40048F7")]
	[FieldOffset(Offset = "0x3E0")]
	public InteractablePreset deskLamp;

	// Token: 0x040048F8 RID: 18680
	[Token(Token = "0x40048F8")]
	[FieldOffset(Offset = "0x3E8")]
	public InteractablePreset bedsideLamp;

	// Token: 0x040048F9 RID: 18681
	[Token(Token = "0x40048F9")]
	[FieldOffset(Offset = "0x3F0")]
	public InteractablePreset cityDirectory;

	// Token: 0x040048FA RID: 18682
	[Token(Token = "0x40048FA")]
	[FieldOffset(Offset = "0x3F8")]
	public GameObject roomAreaLight;

	// Token: 0x040048FB RID: 18683
	[Token(Token = "0x40048FB")]
	[FieldOffset(Offset = "0x400")]
	public Material cameraOffMaterial;

	// Token: 0x040048FC RID: 18684
	[Token(Token = "0x40048FC")]
	[FieldOffset(Offset = "0x408")]
	public Material cameraOnMaterial;

	// Token: 0x040048FD RID: 18685
	[Token(Token = "0x40048FD")]
	[FieldOffset(Offset = "0x410")]
	public Material cameraFocusMaterial;

	// Token: 0x040048FE RID: 18686
	[Token(Token = "0x40048FE")]
	[FieldOffset(Offset = "0x418")]
	public Material cameraAlertMaterial;

	// Token: 0x040048FF RID: 18687
	[Token(Token = "0x40048FF")]
	[FieldOffset(Offset = "0x420")]
	public Material newLightswitchMaterial;

	// Token: 0x04004900 RID: 18688
	[Token(Token = "0x4004900")]
	[FieldOffset(Offset = "0x428")]
	public Material newLightswithSwitchMaterial;

	// Token: 0x04004901 RID: 18689
	[Token(Token = "0x4004901")]
	[FieldOffset(Offset = "0x430")]
	public Material pulsingLightswitch;

	// Token: 0x04004902 RID: 18690
	[Token(Token = "0x4004902")]
	[FieldOffset(Offset = "0x438")]
	public Material pulsingLightswitchSwitch;

	// Token: 0x04004903 RID: 18691
	[Token(Token = "0x4004903")]
	[FieldOffset(Offset = "0x440")]
	public Color pulseColor;

	// Token: 0x04004904 RID: 18692
	[Token(Token = "0x4004904")]
	[FieldOffset(Offset = "0x450")]
	public FurnitureCluster bedCluster;

	// Token: 0x04004905 RID: 18693
	[Token(Token = "0x4004905")]
	[FieldOffset(Offset = "0x458")]
	public FurnitureCluster noticeBoardCluster;

	// Token: 0x04004906 RID: 18694
	[Token(Token = "0x4004906")]
	[FieldOffset(Offset = "0x460")]
	public FurnitureCluster deskCluster;

	// Token: 0x04004907 RID: 18695
	[Token(Token = "0x4004907")]
	[FieldOffset(Offset = "0x468")]
	public FurnitureCluster breakerBoxCluster;

	// Token: 0x04004908 RID: 18696
	[Token(Token = "0x4004908")]
	[FieldOffset(Offset = "0x470")]
	public List<GameObject> housePlantPool;

	// Token: 0x04004909 RID: 18697
	[Token(Token = "0x4004909")]
	[FieldOffset(Offset = "0x478")]
	public Color housePlantColour1;

	// Token: 0x0400490A RID: 18698
	[Token(Token = "0x400490A")]
	[FieldOffset(Offset = "0x488")]
	public Color housePlantColour2;

	// Token: 0x0400490B RID: 18699
	[Token(Token = "0x400490B")]
	[FieldOffset(Offset = "0x498")]
	public List<InteractablePreset> valuableItems;

	// Token: 0x0400490C RID: 18700
	[Token(Token = "0x400490C")]
	[FieldOffset(Offset = "0x4A0")]
	public SyncDiskPreset chapterRewardSyncDisk;

	// Token: 0x0400490D RID: 18701
	[Token(Token = "0x400490D")]
	[FieldOffset(Offset = "0x4A8")]
	public SyncDiskPreset chapterFlophouseSyncDisk;

	// Token: 0x0400490E RID: 18702
	[Token(Token = "0x400490E")]
	[FieldOffset(Offset = "0x4B0")]
	public List<InteractablePreset> meetupConsumables;

	// Token: 0x0400490F RID: 18703
	[Token(Token = "0x400490F")]
	[FieldOffset(Offset = "0x4B8")]
	public RoomConfiguration nullConfig;

	// Token: 0x04004910 RID: 18704
	[Token(Token = "0x4004910")]
	[FieldOffset(Offset = "0x4C0")]
	public RoomTypePreset nullRoomType;

	// Token: 0x04004911 RID: 18705
	[Token(Token = "0x4004911")]
	[FieldOffset(Offset = "0x4C8")]
	public RoomTypePreset bedroomType;

	// Token: 0x04004912 RID: 18706
	[Token(Token = "0x4004912")]
	[FieldOffset(Offset = "0x4D0")]
	public float airDuctYOffset;

	// Token: 0x04004913 RID: 18707
	[Token(Token = "0x4004913")]
	[FieldOffset(Offset = "0x4D8")]
	public DoorPairPreset wallVentTop;

	// Token: 0x04004914 RID: 18708
	[Token(Token = "0x4004914")]
	[FieldOffset(Offset = "0x4E0")]
	public DoorPairPreset wallVentUpper;

	// Token: 0x04004915 RID: 18709
	[Token(Token = "0x4004915")]
	[FieldOffset(Offset = "0x4E8")]
	public DoorPairPreset wallVentLower;

	// Token: 0x04004916 RID: 18710
	[Token(Token = "0x4004916")]
	[FieldOffset(Offset = "0x4F0")]
	public DoorPairPreset wallNormal;

	// Token: 0x04004917 RID: 18711
	[Token(Token = "0x4004917")]
	[FieldOffset(Offset = "0x4F8")]
	public DoorPairPreset wallVentUpperWithTopSpace;

	// Token: 0x04004918 RID: 18712
	[Token(Token = "0x4004918")]
	[FieldOffset(Offset = "0x500")]
	public DoorPairPreset wallVentLowerWithTopSpace;

	// Token: 0x04004919 RID: 18713
	[Token(Token = "0x4004919")]
	[FieldOffset(Offset = "0x508")]
	public Material ductMaterial;

	// Token: 0x0400491A RID: 18714
	[Token(Token = "0x400491A")]
	[FieldOffset(Offset = "0x510")]
	public GameObject ductStraightModel;

	// Token: 0x0400491B RID: 18715
	[Token(Token = "0x400491B")]
	[FieldOffset(Offset = "0x518")]
	public GameObject ductStraightWithPeekVent;

	// Token: 0x0400491C RID: 18716
	[Token(Token = "0x400491C")]
	[FieldOffset(Offset = "0x520")]
	public float ceilingFanSpeed;

	// Token: 0x0400491D RID: 18717
	[Token(Token = "0x400491D")]
	[FieldOffset(Offset = "0x528")]
	public List<InteriorControls.AirDuctOffset> airDuctModels;

	// Token: 0x0400491E RID: 18718
	[Token(Token = "0x400491E")]
	[FieldOffset(Offset = "0x0")]
	private static InteriorControls _instance;

	// Token: 0x020008C1 RID: 2241
	[Token(Token = "0x20008C1")]
	[Serializable]
	public class AirDuctOffset
	{
		// Token: 0x06002A47 RID: 10823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A47")]
		[Address(RVA = "0xCBDCA0", Offset = "0xCBCCA0", VA = "0x180CBDCA0")]
		public AirDuctOffset()
		{
		}

		// Token: 0x0400491F RID: 18719
		[Token(Token = "0x400491F")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04004920 RID: 18720
		[Token(Token = "0x4004920")]
		[FieldOffset(Offset = "0x18")]
		public List<Vector3> offsets;

		// Token: 0x04004921 RID: 18721
		[Token(Token = "0x4004921")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 rotation;

		// Token: 0x04004922 RID: 18722
		[Token(Token = "0x4004922")]
		[FieldOffset(Offset = "0x30")]
		public List<GameObject> prefabs;

		// Token: 0x04004923 RID: 18723
		[Token(Token = "0x4004923")]
		[FieldOffset(Offset = "0x38")]
		public List<Texture2D> maps;
	}
}
