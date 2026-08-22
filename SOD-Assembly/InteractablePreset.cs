using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200080B RID: 2059
[Token(Token = "0x200080B")]
public class InteractablePreset : SoCustomComparison
{
	// Token: 0x0600298F RID: 10639 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600298F")]
	[Address(RVA = "0xCA9910", Offset = "0xCA8910", VA = "0x180CA9910")]
	public List<InteractablePreset.InteractionAction> GetActions(int lockedInPhase = 0)
	{
		return null;
	}

	// Token: 0x06002990 RID: 10640 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002990")]
	[Address(RVA = "0xCA9C00", Offset = "0xCA8C00", VA = "0x180CA9C00")]
	public PhysicsProfile GetPhysicsProfile()
	{
		return null;
	}

	// Token: 0x06002991 RID: 10641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002991")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CopyFPSHeldPostionFromTransform()
	{
	}

	// Token: 0x06002992 RID: 10642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002992")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CalculateDroppedAngleHeightBoost()
	{
	}

	// Token: 0x06002993 RID: 10643 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002993")]
	[Address(RVA = "0xCA9C70", Offset = "0xCA8C70", VA = "0x180CA9C70")]
	public void SpawnIntoInventory()
	{
	}

	// Token: 0x06002994 RID: 10644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002994")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void SetToZeroValue()
	{
	}

	// Token: 0x06002995 RID: 10645 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002995")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CreateOwnEvidence()
	{
	}

	// Token: 0x06002996 RID: 10646 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002996")]
	[Address(RVA = "0xCAA140", Offset = "0xCA9140", VA = "0x180CAA140")]
	public InteractablePreset()
	{
	}

	// Token: 0x04003C73 RID: 15475
	[Token(Token = "0x4003C73")]
	[FieldOffset(Offset = "0x20")]
	public bool spawnable;

	// Token: 0x04003C74 RID: 15476
	[Token(Token = "0x4003C74")]
	[FieldOffset(Offset = "0x28")]
	public GameObject prefab;

	// Token: 0x04003C75 RID: 15477
	[Token(Token = "0x4003C75")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 prefabLocalEuler;

	// Token: 0x04003C76 RID: 15478
	[Token(Token = "0x4003C76")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 prefabLocalScale;

	// Token: 0x04003C77 RID: 15479
	[Token(Token = "0x4003C77")]
	[FieldOffset(Offset = "0x48")]
	public bool dontSaveWithSaveGames;

	// Token: 0x04003C78 RID: 15480
	[Token(Token = "0x4003C78")]
	[FieldOffset(Offset = "0x49")]
	public bool onlySaveWithSaveGamesIfWorldObject;

	// Token: 0x04003C79 RID: 15481
	[Token(Token = "0x4003C79")]
	[FieldOffset(Offset = "0x4A")]
	public bool excludeFromObjectPooling;

	// Token: 0x04003C7A RID: 15482
	[Token(Token = "0x4003C7A")]
	[FieldOffset(Offset = "0x4B")]
	public bool excludeFromVisibilityRangeChecks;

	// Token: 0x04003C7B RID: 15483
	[Token(Token = "0x4003C7B")]
	[FieldOffset(Offset = "0x4C")]
	public ObjectPoolingController.ObjectLoadRange spawnRange;

	// Token: 0x04003C7C RID: 15484
	[Token(Token = "0x4003C7C")]
	[FieldOffset(Offset = "0x50")]
	public bool showWorldObjectInSceneCapture;

	// Token: 0x04003C7D RID: 15485
	[Token(Token = "0x4003C7D")]
	[FieldOffset(Offset = "0x51")]
	public bool captureStateInSceneCapture;

	// Token: 0x04003C7E RID: 15486
	[Token(Token = "0x4003C7E")]
	[FieldOffset(Offset = "0x52")]
	public bool createProxy;

	// Token: 0x04003C7F RID: 15487
	[Token(Token = "0x4003C7F")]
	[FieldOffset(Offset = "0x53")]
	public bool onlyCreateProxyInDetailedCapture;

	// Token: 0x04003C80 RID: 15488
	[Token(Token = "0x4003C80")]
	[FieldOffset(Offset = "0x54")]
	public ObjectPoolingController.ObjectLoadRange createProxyAtRange;

	// Token: 0x04003C81 RID: 15489
	[Token(Token = "0x4003C81")]
	[FieldOffset(Offset = "0x58")]
	public bool inheritColouringFromDecor;

	// Token: 0x04003C82 RID: 15490
	[Token(Token = "0x4003C82")]
	[FieldOffset(Offset = "0x5C")]
	public FurniturePreset.ShareColours shareColoursWithFurniture;

	// Token: 0x04003C83 RID: 15491
	[Token(Token = "0x4003C83")]
	[FieldOffset(Offset = "0x60")]
	public bool useOwnColourSettings;

	// Token: 0x04003C84 RID: 15492
	[Token(Token = "0x4003C84")]
	[FieldOffset(Offset = "0x64")]
	public InteractablePreset.InteractableColourSetting mainColour;

	// Token: 0x04003C85 RID: 15493
	[Token(Token = "0x4003C85")]
	[FieldOffset(Offset = "0x68")]
	public InteractablePreset.InteractableColourSetting customColour1;

	// Token: 0x04003C86 RID: 15494
	[Token(Token = "0x4003C86")]
	[FieldOffset(Offset = "0x6C")]
	public InteractablePreset.InteractableColourSetting customColour2;

	// Token: 0x04003C87 RID: 15495
	[Token(Token = "0x4003C87")]
	[FieldOffset(Offset = "0x70")]
	public InteractablePreset.InteractableColourSetting customColour3;

	// Token: 0x04003C88 RID: 15496
	[Token(Token = "0x4003C88")]
	[FieldOffset(Offset = "0x74")]
	public bool inheritGrubValue;

	// Token: 0x04003C89 RID: 15497
	[Token(Token = "0x4003C89")]
	[FieldOffset(Offset = "0x75")]
	public bool autoName;

	// Token: 0x04003C8A RID: 15498
	[Token(Token = "0x4003C8A")]
	[FieldOffset(Offset = "0x76")]
	public bool includeBelongsTo;

	// Token: 0x04003C8B RID: 15499
	[Token(Token = "0x4003C8B")]
	[FieldOffset(Offset = "0x77")]
	public bool useNameShorthand;

	// Token: 0x04003C8C RID: 15500
	[Token(Token = "0x4003C8C")]
	[FieldOffset(Offset = "0x78")]
	public bool useApartmentName;

	// Token: 0x04003C8D RID: 15501
	[Token(Token = "0x4003C8D")]
	[FieldOffset(Offset = "0x80")]
	public LightingPreset isLight;

	// Token: 0x04003C8E RID: 15502
	[Token(Token = "0x4003C8E")]
	[FieldOffset(Offset = "0x88")]
	public InteractablePreset.Switch lightswitch;

	// Token: 0x04003C8F RID: 15503
	[Token(Token = "0x4003C8F")]
	[FieldOffset(Offset = "0x8C")]
	public bool allowUnscrewed;

	// Token: 0x04003C90 RID: 15504
	[Token(Token = "0x4003C90")]
	[FieldOffset(Offset = "0x8D")]
	public bool isMainLight;

	// Token: 0x04003C91 RID: 15505
	[Token(Token = "0x4003C91")]
	[FieldOffset(Offset = "0x8E")]
	public bool forceIncludeOnStreetLightLayer;

	// Token: 0x04003C92 RID: 15506
	[Token(Token = "0x4003C92")]
	[FieldOffset(Offset = "0x90")]
	public Sprite staticImage;

	// Token: 0x04003C93 RID: 15507
	[Token(Token = "0x4003C93")]
	[FieldOffset(Offset = "0x98")]
	public Vector3 imagePos;

	// Token: 0x04003C94 RID: 15508
	[Token(Token = "0x4003C94")]
	[FieldOffset(Offset = "0xA4")]
	public Vector3 imageRot;

	// Token: 0x04003C95 RID: 15509
	[Token(Token = "0x4003C95")]
	[FieldOffset(Offset = "0xB0")]
	public float imageScale;

	// Token: 0x04003C96 RID: 15510
	[Token(Token = "0x4003C96")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject imagePrefabOverride;

	// Token: 0x04003C97 RID: 15511
	[Token(Token = "0x4003C97")]
	[FieldOffset(Offset = "0xC0")]
	public Sprite iconOverride;

	// Token: 0x04003C98 RID: 15512
	[Token(Token = "0x4003C98")]
	[FieldOffset(Offset = "0xC8")]
	public InteractablePreset.ItemClass itemClass;

	// Token: 0x04003C99 RID: 15513
	[Token(Token = "0x4003C99")]
	[FieldOffset(Offset = "0xCC")]
	public bool allowInApartmentStorage;

	// Token: 0x04003C9A RID: 15514
	[Token(Token = "0x4003C9A")]
	[FieldOffset(Offset = "0xCD")]
	public bool allowInApartmentShop;

	// Token: 0x04003C9B RID: 15515
	[Token(Token = "0x4003C9B")]
	[FieldOffset(Offset = "0xCE")]
	public bool disableMoveToStorage;

	// Token: 0x04003C9C RID: 15516
	[Token(Token = "0x4003C9C")]
	[FieldOffset(Offset = "0xD0")]
	public InteractablePreset.ApartmentPlacementMode apartmentPlacementMode;

	// Token: 0x04003C9D RID: 15517
	[Token(Token = "0x4003C9D")]
	[FieldOffset(Offset = "0xD8")]
	public List<FurniturePreset> mustTouchFurniture;

	// Token: 0x04003C9E RID: 15518
	[Token(Token = "0x4003C9E")]
	[FieldOffset(Offset = "0xE0")]
	public bool useMaterialOverride;

	// Token: 0x04003C9F RID: 15519
	[Token(Token = "0x4003C9F")]
	[FieldOffset(Offset = "0xE8")]
	public AudioController.SoundMaterialOverride materialOverride;

	// Token: 0x04003CA0 RID: 15520
	[Token(Token = "0x4003CA0")]
	[FieldOffset(Offset = "0xF0")]
	public List<InteractableActionsPreset> actionsPreset;

	// Token: 0x04003CA1 RID: 15521
	[Token(Token = "0x4003CA1")]
	[FieldOffset(Offset = "0xF8")]
	public bool onlyIllegalIfInNonPublic;

	// Token: 0x04003CA2 RID: 15522
	[Token(Token = "0x4003CA2")]
	[FieldOffset(Offset = "0xFC")]
	public float rangeModifier;

	// Token: 0x04003CA3 RID: 15523
	[Token(Token = "0x4003CA3")]
	[FieldOffset(Offset = "0x100")]
	public PhysicsProfile physicsProfile;

	// Token: 0x04003CA4 RID: 15524
	[Token(Token = "0x4003CA4")]
	[FieldOffset(Offset = "0x108")]
	public bool overrideMass;

	// Token: 0x04003CA5 RID: 15525
	[Token(Token = "0x4003CA5")]
	[FieldOffset(Offset = "0x109")]
	public bool forcePhysicsAlwaysOn;

	// Token: 0x04003CA6 RID: 15526
	[Token(Token = "0x4003CA6")]
	[FieldOffset(Offset = "0x10A")]
	public bool reactWithExternalStimuli;

	// Token: 0x04003CA7 RID: 15527
	[Token(Token = "0x4003CA7")]
	[FieldOffset(Offset = "0x10C")]
	public float mass;

	// Token: 0x04003CA8 RID: 15528
	[Token(Token = "0x4003CA8")]
	[FieldOffset(Offset = "0x110")]
	public bool breakable;

	// Token: 0x04003CA9 RID: 15529
	[Token(Token = "0x4003CA9")]
	[FieldOffset(Offset = "0x118")]
	public ParticleEffect particleProfile;

	// Token: 0x04003CAA RID: 15530
	[Token(Token = "0x4003CAA")]
	[FieldOffset(Offset = "0x120")]
	public bool overrideShatterSettings;

	// Token: 0x04003CAB RID: 15531
	[Token(Token = "0x4003CAB")]
	[FieldOffset(Offset = "0x124")]
	public Vector3 shardSize;

	// Token: 0x04003CAC RID: 15532
	[Token(Token = "0x4003CAC")]
	[FieldOffset(Offset = "0x130")]
	public int shardEveryXPixels;

	// Token: 0x04003CAD RID: 15533
	[Token(Token = "0x4003CAD")]
	[FieldOffset(Offset = "0x134")]
	public bool overrideSpatterSettings;

	// Token: 0x04003CAE RID: 15534
	[Token(Token = "0x4003CAE")]
	[FieldOffset(Offset = "0x138")]
	public SpatterPatternPreset spatterSimulation;

	// Token: 0x04003CAF RID: 15535
	[Token(Token = "0x4003CAF")]
	[FieldOffset(Offset = "0x140")]
	public float spatterCountMultiplier;

	// Token: 0x04003CB0 RID: 15536
	[Token(Token = "0x4003CB0")]
	[FieldOffset(Offset = "0x144")]
	public bool overrideFurnitureSetting;

	// Token: 0x04003CB1 RID: 15537
	[Token(Token = "0x4003CB1")]
	[FieldOffset(Offset = "0x148")]
	public PlayerTransitionPreset enterTransition;

	// Token: 0x04003CB2 RID: 15538
	[Token(Token = "0x4003CB2")]
	[FieldOffset(Offset = "0x150")]
	public PlayerTransitionPreset exitTransition;

	// Token: 0x04003CB3 RID: 15539
	[Token(Token = "0x4003CB3")]
	[FieldOffset(Offset = "0x158")]
	public PlayerTransitionPreset enterTransition2;

	// Token: 0x04003CB4 RID: 15540
	[Token(Token = "0x4003CB4")]
	[FieldOffset(Offset = "0x160")]
	public PlayerTransitionPreset exitTransition2;

	// Token: 0x04003CB5 RID: 15541
	[Token(Token = "0x4003CB5")]
	[FieldOffset(Offset = "0x168")]
	public List<InteractablePreset.IfSwitchStateSFX> switchSFX;

	// Token: 0x04003CB6 RID: 15542
	[Token(Token = "0x4003CB6")]
	[FieldOffset(Offset = "0x170")]
	public bool startingSwitchState;

	// Token: 0x04003CB7 RID: 15543
	[Token(Token = "0x4003CB7")]
	[FieldOffset(Offset = "0x171")]
	public bool startingCustomState1;

	// Token: 0x04003CB8 RID: 15544
	[Token(Token = "0x4003CB8")]
	[FieldOffset(Offset = "0x172")]
	public bool startingCustomState2;

	// Token: 0x04003CB9 RID: 15545
	[Token(Token = "0x4003CB9")]
	[FieldOffset(Offset = "0x173")]
	public bool startingCustomState3;

	// Token: 0x04003CBA RID: 15546
	[Token(Token = "0x4003CBA")]
	[FieldOffset(Offset = "0x174")]
	public bool startingLockState;

	// Token: 0x04003CBB RID: 15547
	[Token(Token = "0x4003CBB")]
	[FieldOffset(Offset = "0x178")]
	public Vector2 value;

	// Token: 0x04003CBC RID: 15548
	[Token(Token = "0x4003CBC")]
	[FieldOffset(Offset = "0x180")]
	public int AIPriority;

	// Token: 0x04003CBD RID: 15549
	[Token(Token = "0x4003CBD")]
	[FieldOffset(Offset = "0x184")]
	public bool disableForSocialGroups;

	// Token: 0x04003CBE RID: 15550
	[Token(Token = "0x4003CBE")]
	[FieldOffset(Offset = "0x188")]
	public float pickDistanceMultiplier;

	// Token: 0x04003CBF RID: 15551
	[Token(Token = "0x4003CBF")]
	[FieldOffset(Offset = "0x190")]
	public List<InteractablePreset.AIUsePriority> perActionPrioritySettings;

	// Token: 0x04003CC0 RID: 15552
	[Token(Token = "0x4003CC0")]
	[FieldOffset(Offset = "0x198")]
	public bool tamperEnabled;

	// Token: 0x04003CC1 RID: 15553
	[Token(Token = "0x4003CC1")]
	[FieldOffset(Offset = "0x1A0")]
	public List<InteractablePreset.ObjectResetBehaviour> resetBehaviour;

	// Token: 0x04003CC2 RID: 15554
	[Token(Token = "0x4003CC2")]
	[FieldOffset(Offset = "0x1A8")]
	public InteractablePreset.AIUseSetting useSetting;

	// Token: 0x04003CC3 RID: 15555
	[Token(Token = "0x4003CC3")]
	[FieldOffset(Offset = "0x1B0")]
	public bool readingEnabled;

	// Token: 0x04003CC4 RID: 15556
	[Token(Token = "0x4003CC4")]
	[FieldOffset(Offset = "0x1B1")]
	public bool readyingEnabledOnlyWithSwitchIsTue;

	// Token: 0x04003CC5 RID: 15557
	[Token(Token = "0x4003CC5")]
	[FieldOffset(Offset = "0x1B2")]
	public bool readingEnabledOnlyWithKaizenSkill;

	// Token: 0x04003CC6 RID: 15558
	[Token(Token = "0x4003CC6")]
	[FieldOffset(Offset = "0x1B4")]
	public InteractablePreset.ReadingModeSource readingSource;

	// Token: 0x04003CC7 RID: 15559
	[Token(Token = "0x4003CC7")]
	[FieldOffset(Offset = "0x1B8")]
	public bool discoverOnRead;

	// Token: 0x04003CC8 RID: 15560
	[Token(Token = "0x4003CC8")]
	[FieldOffset(Offset = "0x1BC")]
	public float pageTurnReadingDelay;

	// Token: 0x04003CC9 RID: 15561
	[Token(Token = "0x4003CC9")]
	[FieldOffset(Offset = "0x1C0")]
	public bool distanceRecognitionEnabled;

	// Token: 0x04003CCA RID: 15562
	[Token(Token = "0x4003CCA")]
	[FieldOffset(Offset = "0x1C1")]
	public bool distanceRecognitionOnly;

	// Token: 0x04003CCB RID: 15563
	[Token(Token = "0x4003CCB")]
	[FieldOffset(Offset = "0x1C4")]
	public float recognitionRange;

	// Token: 0x04003CCC RID: 15564
	[Token(Token = "0x4003CCC")]
	[FieldOffset(Offset = "0x1C8")]
	public List<SubObjectClassPreset> subObjectClasses;

	// Token: 0x04003CCD RID: 15565
	[Token(Token = "0x4003CCD")]
	[FieldOffset(Offset = "0x1D0")]
	public List<SubObjectClassPreset> backupClasses;

	// Token: 0x04003CCE RID: 15566
	[Token(Token = "0x4003CCE")]
	[FieldOffset(Offset = "0x1D8")]
	public InteractablePreset.AutoPlacement autoPlacement;

	// Token: 0x04003CCF RID: 15567
	[Token(Token = "0x4003CCF")]
	[FieldOffset(Offset = "0x1DC")]
	public bool alwaysPlaceAtGameLocation;

	// Token: 0x04003CD0 RID: 15568
	[Token(Token = "0x4003CD0")]
	[FieldOffset(Offset = "0x1E0")]
	public int frequencyPerGamelocationMin;

	// Token: 0x04003CD1 RID: 15569
	[Token(Token = "0x4003CD1")]
	[FieldOffset(Offset = "0x1E4")]
	public int frequencyPerGameLocationMax;

	// Token: 0x04003CD2 RID: 15570
	[Token(Token = "0x4003CD2")]
	[FieldOffset(Offset = "0x1E8")]
	public int perGameLocationObjectPriority;

	// Token: 0x04003CD3 RID: 15571
	[Token(Token = "0x4003CD3")]
	[FieldOffset(Offset = "0x1EC")]
	public bool placeIfFiltersPresentInOwner;

	// Token: 0x04003CD4 RID: 15572
	[Token(Token = "0x4003CD4")]
	[FieldOffset(Offset = "0x1ED")]
	public bool placeAtHome;

	// Token: 0x04003CD5 RID: 15573
	[Token(Token = "0x4003CD5")]
	[FieldOffset(Offset = "0x1EE")]
	public bool placeAtWork;

	// Token: 0x04003CD6 RID: 15574
	[Token(Token = "0x4003CD6")]
	[FieldOffset(Offset = "0x1F0")]
	public List<InteractablePreset.TraitPick> traitModifiers;

	// Token: 0x04003CD7 RID: 15575
	[Token(Token = "0x4003CD7")]
	[FieldOffset(Offset = "0x1F8")]
	public int frequencyPerOwnerMin;

	// Token: 0x04003CD8 RID: 15576
	[Token(Token = "0x4003CD8")]
	[FieldOffset(Offset = "0x1FC")]
	public int frequencyPerOwnerMax;

	// Token: 0x04003CD9 RID: 15577
	[Token(Token = "0x4003CD9")]
	[FieldOffset(Offset = "0x200")]
	public bool multiplyByMessiness;

	// Token: 0x04003CDA RID: 15578
	[Token(Token = "0x4003CDA")]
	[FieldOffset(Offset = "0x204")]
	public int perOwnerObjectPriority;

	// Token: 0x04003CDB RID: 15579
	[Token(Token = "0x4003CDB")]
	[FieldOffset(Offset = "0x208")]
	public EvidencePreset.BelongsToSetting writerIs;

	// Token: 0x04003CDC RID: 15580
	[Token(Token = "0x4003CDC")]
	[FieldOffset(Offset = "0x20C")]
	public EvidencePreset.BelongsToSetting receiverIs;

	// Token: 0x04003CDD RID: 15581
	[Token(Token = "0x4003CDD")]
	[FieldOffset(Offset = "0x210")]
	public bool canBeFromSelf;

	// Token: 0x04003CDE RID: 15582
	[Token(Token = "0x4003CDE")]
	[FieldOffset(Offset = "0x211")]
	public bool limitPerObject;

	// Token: 0x04003CDF RID: 15583
	[Token(Token = "0x4003CDF")]
	[FieldOffset(Offset = "0x214")]
	public int perObjectLimit;

	// Token: 0x04003CE0 RID: 15584
	[Token(Token = "0x4003CE0")]
	[FieldOffset(Offset = "0x218")]
	public bool limitPerRoom;

	// Token: 0x04003CE1 RID: 15585
	[Token(Token = "0x4003CE1")]
	[FieldOffset(Offset = "0x21C")]
	public int perRoomLimit;

	// Token: 0x04003CE2 RID: 15586
	[Token(Token = "0x4003CE2")]
	[FieldOffset(Offset = "0x220")]
	public bool limitPerAddress;

	// Token: 0x04003CE3 RID: 15587
	[Token(Token = "0x4003CE3")]
	[FieldOffset(Offset = "0x224")]
	public int perAddressLimit;

	// Token: 0x04003CE4 RID: 15588
	[Token(Token = "0x4003CE4")]
	[FieldOffset(Offset = "0x228")]
	public bool limitInResidential;

	// Token: 0x04003CE5 RID: 15589
	[Token(Token = "0x4003CE5")]
	[FieldOffset(Offset = "0x22C")]
	public int perResidentialLimit;

	// Token: 0x04003CE6 RID: 15590
	[Token(Token = "0x4003CE6")]
	[FieldOffset(Offset = "0x230")]
	public bool limitInCommercial;

	// Token: 0x04003CE7 RID: 15591
	[Token(Token = "0x4003CE7")]
	[FieldOffset(Offset = "0x234")]
	public int perCommercialLimit;

	// Token: 0x04003CE8 RID: 15592
	[Token(Token = "0x4003CE8")]
	[FieldOffset(Offset = "0x238")]
	public List<RoomConfiguration> banFromRooms;

	// Token: 0x04003CE9 RID: 15593
	[Token(Token = "0x4003CE9")]
	[FieldOffset(Offset = "0x240")]
	public bool limitToCertainRooms;

	// Token: 0x04003CEA RID: 15594
	[Token(Token = "0x4003CEA")]
	[FieldOffset(Offset = "0x248")]
	public List<RoomConfiguration> onlyInRooms;

	// Token: 0x04003CEB RID: 15595
	[Token(Token = "0x4003CEB")]
	[FieldOffset(Offset = "0x250")]
	public bool limitToCertainBuildings;

	// Token: 0x04003CEC RID: 15596
	[Token(Token = "0x4003CEC")]
	[FieldOffset(Offset = "0x258")]
	public List<BuildingPreset> onlyInBuildings;

	// Token: 0x04003CED RID: 15597
	[Token(Token = "0x4003CED")]
	[FieldOffset(Offset = "0x260")]
	public EvidencePreset attemptToStoreInFolder;

	// Token: 0x04003CEE RID: 15598
	[Token(Token = "0x4003CEE")]
	[FieldOffset(Offset = "0x268")]
	public float folderPlacementChance;

	// Token: 0x04003CEF RID: 15599
	[Token(Token = "0x4003CEF")]
	[FieldOffset(Offset = "0x26C")]
	public bool dontPlaceIfNoFolder;

	// Token: 0x04003CF0 RID: 15600
	[Token(Token = "0x4003CF0")]
	[FieldOffset(Offset = "0x26D")]
	public bool folderOwnershipMustMatch;

	// Token: 0x04003CF1 RID: 15601
	[Token(Token = "0x4003CF1")]
	[FieldOffset(Offset = "0x26E")]
	public bool useSubSpawning;

	// Token: 0x04003CF2 RID: 15602
	[Token(Token = "0x4003CF2")]
	[FieldOffset(Offset = "0x270")]
	public int securityLevel;

	// Token: 0x04003CF3 RID: 15603
	[Token(Token = "0x4003CF3")]
	[FieldOffset(Offset = "0x274")]
	public InteractablePreset.OwnedPlacementRule ownedRule;

	// Token: 0x04003CF4 RID: 15604
	[Token(Token = "0x4003CF4")]
	[FieldOffset(Offset = "0x278")]
	public bool overrideWithOnlyOwnedSpawnAtWork;

	// Token: 0x04003CF5 RID: 15605
	[Token(Token = "0x4003CF5")]
	[FieldOffset(Offset = "0x280")]
	public SubObjectClassPreset subSpawnClass;

	// Token: 0x04003CF6 RID: 15606
	[Token(Token = "0x4003CF6")]
	[FieldOffset(Offset = "0x288")]
	public List<InteractablePreset.SubSpawnSlot> subSpawnPositions;

	// Token: 0x04003CF7 RID: 15607
	[Token(Token = "0x4003CF7")]
	[FieldOffset(Offset = "0x290")]
	public InteractablePreset.RelocationAuthority relocationAuthority;

	// Token: 0x04003CF8 RID: 15608
	[Token(Token = "0x4003CF8")]
	[FieldOffset(Offset = "0x294")]
	public bool relocateIfPlacedInPlayersHome;

	// Token: 0x04003CF9 RID: 15609
	[Token(Token = "0x4003CF9")]
	[FieldOffset(Offset = "0x295")]
	public bool AIWillCorrectPosition;

	// Token: 0x04003CFA RID: 15610
	[Token(Token = "0x4003CFA")]
	[FieldOffset(Offset = "0x296")]
	public bool useEvidence;

	// Token: 0x04003CFB RID: 15611
	[Token(Token = "0x4003CFB")]
	[FieldOffset(Offset = "0x298")]
	public EvidencePreset useSingleton;

	// Token: 0x04003CFC RID: 15612
	[Token(Token = "0x4003CFC")]
	[FieldOffset(Offset = "0x2A0")]
	public InteractablePreset.FindEvidence findEvidence;

	// Token: 0x04003CFD RID: 15613
	[Token(Token = "0x4003CFD")]
	[FieldOffset(Offset = "0x2A8")]
	public EvidencePreset spawnEvidence;

	// Token: 0x04003CFE RID: 15614
	[Token(Token = "0x4003CFE")]
	[FieldOffset(Offset = "0x2B0")]
	public bool locationIsParent;

	// Token: 0x04003CFF RID: 15615
	[Token(Token = "0x4003CFF")]
	[FieldOffset(Offset = "0x2B8")]
	public string summaryMessageSource;

	// Token: 0x04003D00 RID: 15616
	[Token(Token = "0x4003D00")]
	[FieldOffset(Offset = "0x2C0")]
	public bool overrideEvidencePhotoSettings;

	// Token: 0x04003D01 RID: 15617
	[Token(Token = "0x4003D01")]
	[FieldOffset(Offset = "0x2C4")]
	public Vector3 relativeCamPhotoPos;

	// Token: 0x04003D02 RID: 15618
	[Token(Token = "0x4003D02")]
	[FieldOffset(Offset = "0x2D0")]
	public Vector3 relativeCamPhotoEuler;

	// Token: 0x04003D03 RID: 15619
	[Token(Token = "0x4003D03")]
	[FieldOffset(Offset = "0x2E0")]
	public InteractablePreset includeLock;

	// Token: 0x04003D04 RID: 15620
	[Token(Token = "0x4003D04")]
	[FieldOffset(Offset = "0x2E8")]
	public Vector3 lockOffset;

	// Token: 0x04003D05 RID: 15621
	[Token(Token = "0x4003D05")]
	[FieldOffset(Offset = "0x2F4")]
	public RoomConfiguration.RoomPasswordPreference passwordSource;

	// Token: 0x04003D06 RID: 15622
	[Token(Token = "0x4003D06")]
	[FieldOffset(Offset = "0x2F8")]
	public AudioEvent attemptedOpenSound;

	// Token: 0x04003D07 RID: 15623
	[Token(Token = "0x4003D07")]
	[FieldOffset(Offset = "0x300")]
	public bool armLockOnClose;

	// Token: 0x04003D08 RID: 15624
	[Token(Token = "0x4003D08")]
	[FieldOffset(Offset = "0x304")]
	public Vector2 lockStrength;

	// Token: 0x04003D09 RID: 15625
	[Token(Token = "0x4003D09")]
	[FieldOffset(Offset = "0x30C")]
	public bool isSelfLock;

	// Token: 0x04003D0A RID: 15626
	[Token(Token = "0x4003D0A")]
	[FieldOffset(Offset = "0x30D")]
	public bool useMaterialChanges;

	// Token: 0x04003D0B RID: 15627
	[Token(Token = "0x4003D0B")]
	[FieldOffset(Offset = "0x310")]
	public Material lockOffMaterial;

	// Token: 0x04003D0C RID: 15628
	[Token(Token = "0x4003D0C")]
	[FieldOffset(Offset = "0x318")]
	public Material lockOnMaterial;

	// Token: 0x04003D0D RID: 15629
	[Token(Token = "0x4003D0D")]
	[FieldOffset(Offset = "0x320")]
	public bool isComputer;

	// Token: 0x04003D0E RID: 15630
	[Token(Token = "0x4003D0E")]
	[FieldOffset(Offset = "0x328")]
	public CruncherAppPreset bootApp;

	// Token: 0x04003D0F RID: 15631
	[Token(Token = "0x4003D0F")]
	[FieldOffset(Offset = "0x330")]
	public CruncherAppPreset logInApp;

	// Token: 0x04003D10 RID: 15632
	[Token(Token = "0x4003D10")]
	[FieldOffset(Offset = "0x338")]
	public CruncherAppPreset desktopApp;

	// Token: 0x04003D11 RID: 15633
	[Token(Token = "0x4003D11")]
	[FieldOffset(Offset = "0x340")]
	public List<CruncherAppPreset> additionalApps;

	// Token: 0x04003D12 RID: 15634
	[Token(Token = "0x4003D12")]
	[FieldOffset(Offset = "0x348")]
	public bool fingerprintsEnabled;

	// Token: 0x04003D13 RID: 15635
	[Token(Token = "0x4003D13")]
	[FieldOffset(Offset = "0x34C")]
	public RoomConfiguration.PrintsSource printsSource;

	// Token: 0x04003D14 RID: 15636
	[Token(Token = "0x4003D14")]
	[FieldOffset(Offset = "0x350")]
	public float fingerprintDensity;

	// Token: 0x04003D15 RID: 15637
	[Token(Token = "0x4003D15")]
	[FieldOffset(Offset = "0x354")]
	public bool enableDynamicFingerprints;

	// Token: 0x04003D16 RID: 15638
	[Token(Token = "0x4003D16")]
	[FieldOffset(Offset = "0x355")]
	public bool disableDynamicFingerprintsFromStaticPrintsSources;

	// Token: 0x04003D17 RID: 15639
	[Token(Token = "0x4003D17")]
	[FieldOffset(Offset = "0x356")]
	public bool overrideMaxDynamicFingerprints;

	// Token: 0x04003D18 RID: 15640
	[Token(Token = "0x4003D18")]
	[FieldOffset(Offset = "0x358")]
	public int maxDynamicFingerprints;

	// Token: 0x04003D19 RID: 15641
	[Token(Token = "0x4003D19")]
	[FieldOffset(Offset = "0x360")]
	public FirstPersonItem fpsItem;

	// Token: 0x04003D1A RID: 15642
	[Token(Token = "0x4003D1A")]
	[FieldOffset(Offset = "0x368")]
	public bool isInventoryItem;

	// Token: 0x04003D1B RID: 15643
	[Token(Token = "0x4003D1B")]
	[FieldOffset(Offset = "0x36C")]
	public Vector3 fpsItemOffset;

	// Token: 0x04003D1C RID: 15644
	[Token(Token = "0x4003D1C")]
	[FieldOffset(Offset = "0x378")]
	public Vector3 fpsItemRotation;

	// Token: 0x04003D1D RID: 15645
	[Token(Token = "0x4003D1D")]
	[FieldOffset(Offset = "0x384")]
	public Vector3 fpsItemScaleModifier;

	// Token: 0x04003D1E RID: 15646
	[Token(Token = "0x4003D1E")]
	[FieldOffset(Offset = "0x390")]
	public float consumableAmount;

	// Token: 0x04003D1F RID: 15647
	[Token(Token = "0x4003D1F")]
	[FieldOffset(Offset = "0x394")]
	public bool destroyWhenAllConsumed;

	// Token: 0x04003D20 RID: 15648
	[Token(Token = "0x4003D20")]
	[FieldOffset(Offset = "0x395")]
	public bool useSameModelAsTrash;

	// Token: 0x04003D21 RID: 15649
	[Token(Token = "0x4003D21")]
	[FieldOffset(Offset = "0x398")]
	public InteractablePreset trashItem;

	// Token: 0x04003D22 RID: 15650
	[Token(Token = "0x4003D22")]
	[FieldOffset(Offset = "0x3A0")]
	public AudioEvent playerConsumeLoop;

	// Token: 0x04003D23 RID: 15651
	[Token(Token = "0x4003D23")]
	[FieldOffset(Offset = "0x3A8")]
	public AudioEvent takeOneEvent;

	// Token: 0x04003D24 RID: 15652
	[Token(Token = "0x4003D24")]
	[FieldOffset(Offset = "0x3B0")]
	public Human.DisposalType disposal;

	// Token: 0x04003D25 RID: 15653
	[Token(Token = "0x4003D25")]
	[FieldOffset(Offset = "0x3B4")]
	public float chanceOfDroppedAngle;

	// Token: 0x04003D26 RID: 15654
	[Token(Token = "0x4003D26")]
	[FieldOffset(Offset = "0x3B8")]
	public float droppedAngleHeightBoost;

	// Token: 0x04003D27 RID: 15655
	[Token(Token = "0x4003D27")]
	[FieldOffset(Offset = "0x3C0")]
	public MurderWeaponPreset weapon;

	// Token: 0x04003D28 RID: 15656
	[Token(Token = "0x4003D28")]
	[FieldOffset(Offset = "0x3C8")]
	public bool inventoryCarryItem;

	// Token: 0x04003D29 RID: 15657
	[Token(Token = "0x4003D29")]
	[FieldOffset(Offset = "0x3C9")]
	public bool requiredCarryAnimation;

	// Token: 0x04003D2A RID: 15658
	[Token(Token = "0x4003D2A")]
	[FieldOffset(Offset = "0x3CC")]
	public int aiCarryAnimation;

	// Token: 0x04003D2B RID: 15659
	[Token(Token = "0x4003D2B")]
	[FieldOffset(Offset = "0x3D0")]
	public Vector3 aiHeldObjectPosition;

	// Token: 0x04003D2C RID: 15660
	[Token(Token = "0x4003D2C")]
	[FieldOffset(Offset = "0x3DC")]
	public Vector3 aiHeldObjectRotation;

	// Token: 0x04003D2D RID: 15661
	[Token(Token = "0x4003D2D")]
	[FieldOffset(Offset = "0x3E8")]
	public bool putDownAtHome;

	// Token: 0x04003D2E RID: 15662
	[Token(Token = "0x4003D2E")]
	[FieldOffset(Offset = "0x3E9")]
	public bool takeWith;

	// Token: 0x04003D2F RID: 15663
	[Token(Token = "0x4003D2F")]
	[FieldOffset(Offset = "0x3F0")]
	public List<SubObjectClassPreset> putDownPositions;

	// Token: 0x04003D30 RID: 15664
	[Token(Token = "0x4003D30")]
	[FieldOffset(Offset = "0x3F8")]
	public List<SubObjectClassPreset> backupPutDownPositions;

	// Token: 0x04003D31 RID: 15665
	[Token(Token = "0x4003D31")]
	[FieldOffset(Offset = "0x400")]
	public InteractablePreset.SpecialCase specialCaseFlag;

	// Token: 0x04003D32 RID: 15666
	[Token(Token = "0x4003D32")]
	[FieldOffset(Offset = "0x404")]
	public bool affectRoomSteamLevel;

	// Token: 0x04003D33 RID: 15667
	[Token(Token = "0x4003D33")]
	[FieldOffset(Offset = "0x405")]
	public bool isPayphone;

	// Token: 0x04003D34 RID: 15668
	[Token(Token = "0x4003D34")]
	[FieldOffset(Offset = "0x406")]
	public bool isClock;

	// Token: 0x04003D35 RID: 15669
	[Token(Token = "0x4003D35")]
	[FieldOffset(Offset = "0x407")]
	public bool isMoney;

	// Token: 0x04003D36 RID: 15670
	[Token(Token = "0x4003D36")]
	[FieldOffset(Offset = "0x408")]
	public bool entertainmentSource;

	// Token: 0x04003D37 RID: 15671
	[Token(Token = "0x4003D37")]
	[FieldOffset(Offset = "0x409")]
	public bool isHeatSource;

	// Token: 0x04003D38 RID: 15672
	[Token(Token = "0x4003D38")]
	[FieldOffset(Offset = "0x40A")]
	public bool markAsTrashOnCreate;

	// Token: 0x04003D39 RID: 15673
	[Token(Token = "0x4003D39")]
	[FieldOffset(Offset = "0x40B")]
	public bool isLitter;

	// Token: 0x04003D3A RID: 15674
	[Token(Token = "0x4003D3A")]
	[FieldOffset(Offset = "0x40C")]
	public bool isDecal;

	// Token: 0x04003D3B RID: 15675
	[Token(Token = "0x4003D3B")]
	[FieldOffset(Offset = "0x40D")]
	public bool isMovableChair;

	// Token: 0x04003D3C RID: 15676
	[Token(Token = "0x4003D3C")]
	[FieldOffset(Offset = "0x40E")]
	public bool bedRightSide;

	// Token: 0x04003D3D RID: 15677
	[Token(Token = "0x4003D3D")]
	[FieldOffset(Offset = "0x40F")]
	public bool resetSwitchStates;

	// Token: 0x04003D3E RID: 15678
	[Token(Token = "0x4003D3E")]
	[FieldOffset(Offset = "0x410")]
	public float resetTimer;

	// Token: 0x04003D3F RID: 15679
	[Token(Token = "0x4003D3F")]
	[FieldOffset(Offset = "0x414")]
	public bool dontSaveSwitchStates;

	// Token: 0x04003D40 RID: 15680
	[Token(Token = "0x4003D40")]
	[FieldOffset(Offset = "0x415")]
	public bool dontLoadSwitchStates;

	// Token: 0x04003D41 RID: 15681
	[Token(Token = "0x4003D41")]
	[FieldOffset(Offset = "0x416")]
	public bool recordCreationTime;

	// Token: 0x04003D42 RID: 15682
	[Token(Token = "0x4003D42")]
	[FieldOffset(Offset = "0x418")]
	public List<AudioEvent> musicTracks;

	// Token: 0x04003D43 RID: 15683
	[Token(Token = "0x4003D43")]
	[FieldOffset(Offset = "0x420")]
	public RetailItemPreset retailItem;

	// Token: 0x04003D44 RID: 15684
	[Token(Token = "0x4003D44")]
	[FieldOffset(Offset = "0x428")]
	public MenuPreset menuOverride;

	// Token: 0x04003D45 RID: 15685
	[Token(Token = "0x4003D45")]
	[FieldOffset(Offset = "0x430")]
	public AudioEvent hourlyChime;

	// Token: 0x04003D46 RID: 15686
	[Token(Token = "0x4003D46")]
	[FieldOffset(Offset = "0x438")]
	public bool chimeEqualToHour;

	// Token: 0x04003D47 RID: 15687
	[Token(Token = "0x4003D47")]
	[FieldOffset(Offset = "0x43C")]
	public float chimeDelay;

	// Token: 0x04003D48 RID: 15688
	[Token(Token = "0x4003D48")]
	[FieldOffset(Offset = "0x440")]
	public AudioEvent searchLoop;

	// Token: 0x0200080C RID: 2060
	[Token(Token = "0x200080C")]
	[Serializable]
	public class AIUseSetting
	{
		// Token: 0x06002997 RID: 10647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002997")]
		[Address(RVA = "0xCAAE20", Offset = "0xCA9E20", VA = "0x180CAAE20")]
		public AIUseSetting()
		{
		}

		// Token: 0x04003D49 RID: 15689
		[Token(Token = "0x4003D49")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 usageOffset;

		// Token: 0x04003D4A RID: 15690
		[Token(Token = "0x4003D4A")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 facingOffset;

		// Token: 0x04003D4B RID: 15691
		[Token(Token = "0x4003D4B")]
		[FieldOffset(Offset = "0x28")]
		public bool useNodeFloorPosition;

		// Token: 0x04003D4C RID: 15692
		[Token(Token = "0x4003D4C")]
		[FieldOffset(Offset = "0x29")]
		public bool useDoorBehaviour;

		// Token: 0x04003D4D RID: 15693
		[Token(Token = "0x4003D4D")]
		[FieldOffset(Offset = "0x2A")]
		public bool useSittingOffset;

		// Token: 0x04003D4E RID: 15694
		[Token(Token = "0x4003D4E")]
		[FieldOffset(Offset = "0x2B")]
		public bool useArmsStandingOffset;
	}

	// Token: 0x0200080D RID: 2061
	[Token(Token = "0x200080D")]
	public enum InteractionKey
	{
		// Token: 0x04003D50 RID: 15696
		[Token(Token = "0x4003D50")]
		none,
		// Token: 0x04003D51 RID: 15697
		[Token(Token = "0x4003D51")]
		primary,
		// Token: 0x04003D52 RID: 15698
		[Token(Token = "0x4003D52")]
		secondary,
		// Token: 0x04003D53 RID: 15699
		[Token(Token = "0x4003D53")]
		alternative,
		// Token: 0x04003D54 RID: 15700
		[Token(Token = "0x4003D54")]
		scrollAxisUp,
		// Token: 0x04003D55 RID: 15701
		[Token(Token = "0x4003D55")]
		scrollAxisDown,
		// Token: 0x04003D56 RID: 15702
		[Token(Token = "0x4003D56")]
		jump,
		// Token: 0x04003D57 RID: 15703
		[Token(Token = "0x4003D57")]
		crouch,
		// Token: 0x04003D58 RID: 15704
		[Token(Token = "0x4003D58")]
		sprint,
		// Token: 0x04003D59 RID: 15705
		[Token(Token = "0x4003D59")]
		flashlight,
		// Token: 0x04003D5A RID: 15706
		[Token(Token = "0x4003D5A")]
		caseBoard,
		// Token: 0x04003D5B RID: 15707
		[Token(Token = "0x4003D5B")]
		map,
		// Token: 0x04003D5C RID: 15708
		[Token(Token = "0x4003D5C")]
		notebook,
		// Token: 0x04003D5D RID: 15709
		[Token(Token = "0x4003D5D")]
		moveHorizontal,
		// Token: 0x04003D5E RID: 15710
		[Token(Token = "0x4003D5E")]
		moveVertical,
		// Token: 0x04003D5F RID: 15711
		[Token(Token = "0x4003D5F")]
		lookHorizontal,
		// Token: 0x04003D60 RID: 15712
		[Token(Token = "0x4003D60")]
		lookVertical,
		// Token: 0x04003D61 RID: 15713
		[Token(Token = "0x4003D61")]
		WeaponSelect,
		// Token: 0x04003D62 RID: 15714
		[Token(Token = "0x4003D62")]
		nearestInteractable,
		// Token: 0x04003D63 RID: 15715
		[Token(Token = "0x4003D63")]
		CaseBoardZoomAxis,
		// Token: 0x04003D64 RID: 15716
		[Token(Token = "0x4003D64")]
		MoveEvidenceAxisX,
		// Token: 0x04003D65 RID: 15717
		[Token(Token = "0x4003D65")]
		MoveEvidenceAxisY,
		// Token: 0x04003D66 RID: 15718
		[Token(Token = "0x4003D66")]
		ContentMoveAxisX,
		// Token: 0x04003D67 RID: 15719
		[Token(Token = "0x4003D67")]
		ContentMoveAxisY,
		// Token: 0x04003D68 RID: 15720
		[Token(Token = "0x4003D68")]
		SelectLeft,
		// Token: 0x04003D69 RID: 15721
		[Token(Token = "0x4003D69")]
		SelectRight,
		// Token: 0x04003D6A RID: 15722
		[Token(Token = "0x4003D6A")]
		SelectUp,
		// Token: 0x04003D6B RID: 15723
		[Token(Token = "0x4003D6B")]
		SelectDown,
		// Token: 0x04003D6C RID: 15724
		[Token(Token = "0x4003D6C")]
		CreateString,
		// Token: 0x04003D6D RID: 15725
		[Token(Token = "0x4003D6D")]
		LeanLeft,
		// Token: 0x04003D6E RID: 15726
		[Token(Token = "0x4003D6E")]
		LeanRight,
		// Token: 0x04003D6F RID: 15727
		[Token(Token = "0x4003D6F")]
		Back,
		// Token: 0x04003D70 RID: 15728
		[Token(Token = "0x4003D70")]
		Select,
		// Token: 0x04003D71 RID: 15729
		[Token(Token = "0x4003D71")]
		Menu,
		// Token: 0x04003D72 RID: 15730
		[Token(Token = "0x4003D72")]
		MoveEvidence
	}

	// Token: 0x0200080E RID: 2062
	[Token(Token = "0x200080E")]
	public enum Switch
	{
		// Token: 0x04003D74 RID: 15732
		[Token(Token = "0x4003D74")]
		switchState,
		// Token: 0x04003D75 RID: 15733
		[Token(Token = "0x4003D75")]
		custom1,
		// Token: 0x04003D76 RID: 15734
		[Token(Token = "0x4003D76")]
		custom2,
		// Token: 0x04003D77 RID: 15735
		[Token(Token = "0x4003D77")]
		custom3,
		// Token: 0x04003D78 RID: 15736
		[Token(Token = "0x4003D78")]
		lockState,
		// Token: 0x04003D79 RID: 15737
		[Token(Token = "0x4003D79")]
		lockedIn,
		// Token: 0x04003D7A RID: 15738
		[Token(Token = "0x4003D7A")]
		sprinting,
		// Token: 0x04003D7B RID: 15739
		[Token(Token = "0x4003D7B")]
		enforcersInside,
		// Token: 0x04003D7C RID: 15740
		[Token(Token = "0x4003D7C")]
		ko,
		// Token: 0x04003D7D RID: 15741
		[Token(Token = "0x4003D7D")]
		securityGrid,
		// Token: 0x04003D7E RID: 15742
		[Token(Token = "0x4003D7E")]
		carryPhysicsObject
	}

	// Token: 0x0200080F RID: 2063
	[Token(Token = "0x200080F")]
	[Serializable]
	public class SwitchState
	{
		// Token: 0x06002998 RID: 10648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002998")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public SwitchState()
		{
		}

		// Token: 0x04003D7F RID: 15743
		[Token(Token = "0x4003D7F")]
		[FieldOffset(Offset = "0x10")]
		public InteractablePreset.Switch switchState;

		// Token: 0x04003D80 RID: 15744
		[Token(Token = "0x4003D80")]
		[FieldOffset(Offset = "0x14")]
		public bool boolIs;
	}

	// Token: 0x02000810 RID: 2064
	[Token(Token = "0x2000810")]
	[Serializable]
	public class IfSwitchState
	{
		// Token: 0x06002999 RID: 10649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002999")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public IfSwitchState()
		{
		}

		// Token: 0x04003D81 RID: 15745
		[Token(Token = "0x4003D81")]
		[FieldOffset(Offset = "0x10")]
		public InteractablePreset.Switch switchState;

		// Token: 0x04003D82 RID: 15746
		[Token(Token = "0x4003D82")]
		[FieldOffset(Offset = "0x14")]
		public bool boolIs;
	}

	// Token: 0x02000811 RID: 2065
	[Token(Token = "0x2000811")]
	[Serializable]
	public class IfSwitchStateSFX
	{
		// Token: 0x0600299A RID: 10650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299A")]
		[Address(RVA = "0xCAAE40", Offset = "0xCA9E40", VA = "0x180CAAE40")]
		public IfSwitchStateSFX()
		{
		}

		// Token: 0x04003D83 RID: 15747
		[Token(Token = "0x4003D83")]
		[FieldOffset(Offset = "0x10")]
		public InteractablePreset.Switch switchState;

		// Token: 0x04003D84 RID: 15748
		[Token(Token = "0x4003D84")]
		[FieldOffset(Offset = "0x14")]
		public bool boolIs;

		// Token: 0x04003D85 RID: 15749
		[Token(Token = "0x4003D85")]
		[FieldOffset(Offset = "0x18")]
		public AudioEvent triggerAudio;

		// Token: 0x04003D86 RID: 15750
		[Token(Token = "0x4003D86")]
		[FieldOffset(Offset = "0x20")]
		public bool isLoop;

		// Token: 0x04003D87 RID: 15751
		[Token(Token = "0x4003D87")]
		[FieldOffset(Offset = "0x21")]
		public bool isBroadcast;

		// Token: 0x04003D88 RID: 15752
		[Token(Token = "0x4003D88")]
		[FieldOffset(Offset = "0x22")]
		public bool isMusicPlayer;

		// Token: 0x04003D89 RID: 15753
		[Token(Token = "0x4003D89")]
		[FieldOffset(Offset = "0x24")]
		public AudioController.StopType stop;

		// Token: 0x04003D8A RID: 15754
		[Token(Token = "0x4003D8A")]
		[FieldOffset(Offset = "0x28")]
		public bool passOpenParam;

		// Token: 0x04003D8B RID: 15755
		[Token(Token = "0x4003D8B")]
		[FieldOffset(Offset = "0x29")]
		public bool passCSParam;

		// Token: 0x04003D8C RID: 15756
		[Token(Token = "0x4003D8C")]
		[FieldOffset(Offset = "0x2A")]
		public bool passDoorDirParam;

		// Token: 0x04003D8D RID: 15757
		[Token(Token = "0x4003D8D")]
		[FieldOffset(Offset = "0x2B")]
		public bool onlyIfInSyncBed;

		// Token: 0x04003D8E RID: 15758
		[Token(Token = "0x4003D8E")]
		[FieldOffset(Offset = "0x2C")]
		public bool onlyIfNotInSyncBed;

		// Token: 0x04003D8F RID: 15759
		[Token(Token = "0x4003D8F")]
		[FieldOffset(Offset = "0x2D")]
		public bool onlyIfNeonSign;
	}

	// Token: 0x02000812 RID: 2066
	[Token(Token = "0x2000812")]
	[Serializable]
	public class InteractionAction
	{
		// Token: 0x0600299B RID: 10651 RVA: 0x0000F960 File Offset: 0x0000DB60
		[Token(Token = "0x600299B")]
		[Address(RVA = "0xCAAE50", Offset = "0xCA9E50", VA = "0x180CAAE50")]
		public InteractablePreset.InteractionKey GetInteractionKey()
		{
			return InteractablePreset.InteractionKey.none;
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299C")]
		[Address(RVA = "0xCAAE70", Offset = "0xCA9E70", VA = "0x180CAAE70")]
		public InteractionAction()
		{
		}

		// Token: 0x04003D90 RID: 15760
		[Token(Token = "0x4003D90")]
		[FieldOffset(Offset = "0x10")]
		public string interactionName;

		// Token: 0x04003D91 RID: 15761
		[Token(Token = "0x4003D91")]
		[FieldOffset(Offset = "0x18")]
		public AIActionPreset action;

		// Token: 0x04003D92 RID: 15762
		[Token(Token = "0x4003D92")]
		[FieldOffset(Offset = "0x20")]
		public bool useDefaultKeySetting;

		// Token: 0x04003D93 RID: 15763
		[Token(Token = "0x4003D93")]
		[FieldOffset(Offset = "0x24")]
		public InteractablePreset.InteractionKey keyOverride;

		// Token: 0x04003D94 RID: 15764
		[Token(Token = "0x4003D94")]
		[FieldOffset(Offset = "0x28")]
		public InteractablePreset.InteractionAction.SpecialCase specialCase;

		// Token: 0x04003D95 RID: 15765
		[Token(Token = "0x4003D95")]
		[FieldOffset(Offset = "0x2C")]
		public bool usableByAI;

		// Token: 0x04003D96 RID: 15766
		[Token(Token = "0x4003D96")]
		[FieldOffset(Offset = "0x30")]
		public float aiUsageDelay;

		// Token: 0x04003D97 RID: 15767
		[Token(Token = "0x4003D97")]
		[FieldOffset(Offset = "0x38")]
		public List<InteractablePreset.SwitchState> effectSwitchStates;

		// Token: 0x04003D98 RID: 15768
		[Token(Token = "0x4003D98")]
		[FieldOffset(Offset = "0x40")]
		public List<InteractablePreset.IfSwitchState> onlyActiveIf;

		// Token: 0x04003D99 RID: 15769
		[Token(Token = "0x4003D99")]
		[FieldOffset(Offset = "0x48")]
		public bool actionIsIllegal;

		// Token: 0x04003D9A RID: 15770
		[Token(Token = "0x4003D9A")]
		[FieldOffset(Offset = "0x49")]
		public bool availableWhileIllegal;

		// Token: 0x04003D9B RID: 15771
		[Token(Token = "0x4003D9B")]
		[FieldOffset(Offset = "0x4A")]
		public bool availableWhileWitnessesToIllegal;

		// Token: 0x04003D9C RID: 15772
		[Token(Token = "0x4003D9C")]
		[FieldOffset(Offset = "0x4B")]
		public bool onlyAvailableToRestrainedWhileIllegal;

		// Token: 0x04003D9D RID: 15773
		[Token(Token = "0x4003D9D")]
		[FieldOffset(Offset = "0x4C")]
		public bool availableWhileLockedIn;

		// Token: 0x04003D9E RID: 15774
		[Token(Token = "0x4003D9E")]
		[FieldOffset(Offset = "0x4D")]
		public bool availableWhileJumping;

		// Token: 0x04003D9F RID: 15775
		[Token(Token = "0x4003D9F")]
		[FieldOffset(Offset = "0x50")]
		public int actionCost;

		// Token: 0x04003DA0 RID: 15776
		[Token(Token = "0x4003DA0")]
		[FieldOffset(Offset = "0x54")]
		public bool useStrikethrough;

		// Token: 0x04003DA1 RID: 15777
		[Token(Token = "0x4003DA1")]
		[FieldOffset(Offset = "0x55")]
		public bool isHidingPlace;

		// Token: 0x04003DA2 RID: 15778
		[Token(Token = "0x4003DA2")]
		[FieldOffset(Offset = "0x56")]
		public bool onlyHidingPlaceIfPublic;

		// Token: 0x04003DA3 RID: 15779
		[Token(Token = "0x4003DA3")]
		[FieldOffset(Offset = "0x58")]
		public AudioEvent soundEvent;

		// Token: 0x04003DA4 RID: 15780
		[Token(Token = "0x4003DA4")]
		[FieldOffset(Offset = "0x60")]
		public bool playOnTrigger;

		// Token: 0x02000813 RID: 2067
		[Token(Token = "0x2000813")]
		public enum SpecialCase
		{
			// Token: 0x04003DA6 RID: 15782
			[Token(Token = "0x4003DA6")]
			none,
			// Token: 0x04003DA7 RID: 15783
			[Token(Token = "0x4003DA7")]
			takeSwap,
			// Token: 0x04003DA8 RID: 15784
			[Token(Token = "0x4003DA8")]
			onlyIfDeadAsleepOrUncon,
			// Token: 0x04003DA9 RID: 15785
			[Token(Token = "0x4003DA9")]
			availableInFastForward,
			// Token: 0x04003DAA RID: 15786
			[Token(Token = "0x4003DAA")]
			onlyAvailableInFastForward,
			// Token: 0x04003DAB RID: 15787
			[Token(Token = "0x4003DAB")]
			caseFormsNeeded,
			// Token: 0x04003DAC RID: 15788
			[Token(Token = "0x4003DAC")]
			activeCaseHandInReady,
			// Token: 0x04003DAD RID: 15789
			[Token(Token = "0x4003DAD")]
			search,
			// Token: 0x04003DAE RID: 15790
			[Token(Token = "0x4003DAE")]
			knockOnDoor,
			// Token: 0x04003DAF RID: 15791
			[Token(Token = "0x4003DAF")]
			putBack,
			// Token: 0x04003DB0 RID: 15792
			[Token(Token = "0x4003DB0")]
			originalPlace,
			// Token: 0x04003DB1 RID: 15793
			[Token(Token = "0x4003DB1")]
			onlyIfRestrained,
			// Token: 0x04003DB2 RID: 15794
			[Token(Token = "0x4003DB2")]
			onlyIfNotRestrained,
			// Token: 0x04003DB3 RID: 15795
			[Token(Token = "0x4003DB3")]
			ifInventoryItemDrawn,
			// Token: 0x04003DB4 RID: 15796
			[Token(Token = "0x4003DB4")]
			onlyIfSick,
			// Token: 0x04003DB5 RID: 15797
			[Token(Token = "0x4003DB5")]
			nonCombat,
			// Token: 0x04003DB6 RID: 15798
			[Token(Token = "0x4003DB6")]
			onlyIfMultiPageHasPages,
			// Token: 0x04003DB7 RID: 15799
			[Token(Token = "0x4003DB7")]
			onlyInNormalTimeAndAwakeNonDialog,
			// Token: 0x04003DB8 RID: 15800
			[Token(Token = "0x4003DB8")]
			nonDialog,
			// Token: 0x04003DB9 RID: 15801
			[Token(Token = "0x4003DB9")]
			decorPlacementPurchase,
			// Token: 0x04003DBA RID: 15802
			[Token(Token = "0x4003DBA")]
			furniturePlacement,
			// Token: 0x04003DBB RID: 15803
			[Token(Token = "0x4003DBB")]
			decorItemPlacement,
			// Token: 0x04003DBC RID: 15804
			[Token(Token = "0x4003DBC")]
			citizenReturn,
			// Token: 0x04003DBD RID: 15805
			[Token(Token = "0x4003DBD")]
			nonCombatOrRestrained,
			// Token: 0x04003DBE RID: 15806
			[Token(Token = "0x4003DBE")]
			validTransitionZone,
			// Token: 0x04003DBF RID: 15807
			[Token(Token = "0x4003DBF")]
			onlyIfRegularRotation,
			// Token: 0x04003DC0 RID: 15808
			[Token(Token = "0x4003DC0")]
			takePrintsFromBody
		}
	}

	// Token: 0x02000814 RID: 2068
	[Token(Token = "0x2000814")]
	public enum InteractableColourSetting
	{
		// Token: 0x04003DC2 RID: 15810
		[Token(Token = "0x4003DC2")]
		none,
		// Token: 0x04003DC3 RID: 15811
		[Token(Token = "0x4003DC3")]
		ownersFavColour,
		// Token: 0x04003DC4 RID: 15812
		[Token(Token = "0x4003DC4")]
		randomColour,
		// Token: 0x04003DC5 RID: 15813
		[Token(Token = "0x4003DC5")]
		randomDecorColour,
		// Token: 0x04003DC6 RID: 15814
		[Token(Token = "0x4003DC6")]
		syncDisk
	}

	// Token: 0x02000815 RID: 2069
	[Token(Token = "0x2000815")]
	public enum ItemClass
	{
		// Token: 0x04003DC8 RID: 15816
		[Token(Token = "0x4003DC8")]
		consumable,
		// Token: 0x04003DC9 RID: 15817
		[Token(Token = "0x4003DC9")]
		medical,
		// Token: 0x04003DCA RID: 15818
		[Token(Token = "0x4003DCA")]
		equipment,
		// Token: 0x04003DCB RID: 15819
		[Token(Token = "0x4003DCB")]
		document,
		// Token: 0x04003DCC RID: 15820
		[Token(Token = "0x4003DCC")]
		misc,
		// Token: 0x04003DCD RID: 15821
		[Token(Token = "0x4003DCD")]
		electronics
	}

	// Token: 0x02000816 RID: 2070
	[Token(Token = "0x2000816")]
	public enum ApartmentPlacementMode
	{
		// Token: 0x04003DCF RID: 15823
		[Token(Token = "0x4003DCF")]
		physics,
		// Token: 0x04003DD0 RID: 15824
		[Token(Token = "0x4003DD0")]
		vertical,
		// Token: 0x04003DD1 RID: 15825
		[Token(Token = "0x4003DD1")]
		ceiling
	}

	// Token: 0x02000817 RID: 2071
	[Token(Token = "0x2000817")]
	[Serializable]
	public class AIUsePriority
	{
		// Token: 0x0600299D RID: 10653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299D")]
		[Address(RVA = "0xCAAFF0", Offset = "0xCA9FF0", VA = "0x180CAAFF0")]
		public AIUsePriority()
		{
		}

		// Token: 0x04003DD2 RID: 15826
		[Token(Token = "0x4003DD2")]
		[FieldOffset(Offset = "0x10")]
		public List<AIActionPreset> actions;

		// Token: 0x04003DD3 RID: 15827
		[Token(Token = "0x4003DD3")]
		[FieldOffset(Offset = "0x18")]
		public float AIPriority;

		// Token: 0x04003DD4 RID: 15828
		[Token(Token = "0x4003DD4")]
		[FieldOffset(Offset = "0x1C")]
		public float pickDistanceMultiplier;
	}

	// Token: 0x02000818 RID: 2072
	[Token(Token = "0x2000818")]
	[Serializable]
	public class ObjectResetBehaviour
	{
		// Token: 0x0600299E RID: 10654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299E")]
		[Address(RVA = "0xCAB000", Offset = "0xCAA000", VA = "0x180CAB000")]
		public ObjectResetBehaviour()
		{
		}

		// Token: 0x04003DD5 RID: 15829
		[Token(Token = "0x4003DD5")]
		[FieldOffset(Offset = "0x10")]
		public InteractablePreset.Switch ifSwitchState;

		// Token: 0x04003DD6 RID: 15830
		[Token(Token = "0x4003DD6")]
		[FieldOffset(Offset = "0x14")]
		public bool ifSwitchBool;

		// Token: 0x04003DD7 RID: 15831
		[Token(Token = "0x4003DD7")]
		[FieldOffset(Offset = "0x18")]
		public InteractablePreset.ObjectResetCondition ifCondition;

		// Token: 0x04003DD8 RID: 15832
		[Token(Token = "0x4003DD8")]
		[FieldOffset(Offset = "0x20")]
		public AIGoalPreset ifGoal;

		// Token: 0x04003DD9 RID: 15833
		[Token(Token = "0x4003DD9")]
		[FieldOffset(Offset = "0x28")]
		public InteractablePreset.ObjectResetScope scope;

		// Token: 0x04003DDA RID: 15834
		[Token(Token = "0x4003DDA")]
		[FieldOffset(Offset = "0x2C")]
		public bool onlyIfObjectBelongsTo;

		// Token: 0x04003DDB RID: 15835
		[Token(Token = "0x4003DDB")]
		[FieldOffset(Offset = "0x2D")]
		public bool onlyIfAuthority;

		// Token: 0x04003DDC RID: 15836
		[Token(Token = "0x4003DDC")]
		[FieldOffset(Offset = "0x2E")]
		public bool onlyIfLastOccupant;

		// Token: 0x04003DDD RID: 15837
		[Token(Token = "0x4003DDD")]
		[FieldOffset(Offset = "0x2F")]
		public bool onlyIfHome;

		// Token: 0x04003DDE RID: 15838
		[Token(Token = "0x4003DDE")]
		[FieldOffset(Offset = "0x30")]
		public List<AIActionPreset> insertActions;
	}

	// Token: 0x02000819 RID: 2073
	[Token(Token = "0x2000819")]
	public enum ObjectResetCondition
	{
		// Token: 0x04003DE0 RID: 15840
		[Token(Token = "0x4003DE0")]
		leavingLocation,
		// Token: 0x04003DE1 RID: 15841
		[Token(Token = "0x4003DE1")]
		goalActive,
		// Token: 0x04003DE2 RID: 15842
		[Token(Token = "0x4003DE2")]
		goalActivated,
		// Token: 0x04003DE3 RID: 15843
		[Token(Token = "0x4003DE3")]
		goalDeactivated
	}

	// Token: 0x0200081A RID: 2074
	[Token(Token = "0x200081A")]
	public enum ObjectResetScope
	{
		// Token: 0x04003DE5 RID: 15845
		[Token(Token = "0x4003DE5")]
		ifInSameRoom,
		// Token: 0x04003DE6 RID: 15846
		[Token(Token = "0x4003DE6")]
		ifInSameLocation
	}

	// Token: 0x0200081B RID: 2075
	[Token(Token = "0x200081B")]
	public enum ReadingModeSource
	{
		// Token: 0x04003DE8 RID: 15848
		[Token(Token = "0x4003DE8")]
		evidenceNote,
		// Token: 0x04003DE9 RID: 15849
		[Token(Token = "0x4003DE9")]
		multipageEvidence,
		// Token: 0x04003DEA RID: 15850
		[Token(Token = "0x4003DEA")]
		time,
		// Token: 0x04003DEB RID: 15851
		[Token(Token = "0x4003DEB")]
		bookPreset,
		// Token: 0x04003DEC RID: 15852
		[Token(Token = "0x4003DEC")]
		recordPreset,
		// Token: 0x04003DED RID: 15853
		[Token(Token = "0x4003DED")]
		syncDiskPreset,
		// Token: 0x04003DEE RID: 15854
		[Token(Token = "0x4003DEE")]
		mainEvidenceText,
		// Token: 0x04003DEF RID: 15855
		[Token(Token = "0x4003DEF")]
		kaizenSkillDisplay
	}

	// Token: 0x0200081C RID: 2076
	[Token(Token = "0x200081C")]
	public enum AutoPlacement
	{
		// Token: 0x04003DF1 RID: 15857
		[Token(Token = "0x4003DF1")]
		always,
		// Token: 0x04003DF2 RID: 15858
		[Token(Token = "0x4003DF2")]
		onlyInCompany,
		// Token: 0x04003DF3 RID: 15859
		[Token(Token = "0x4003DF3")]
		onlyInHomes,
		// Token: 0x04003DF4 RID: 15860
		[Token(Token = "0x4003DF4")]
		onlyOnStreet,
		// Token: 0x04003DF5 RID: 15861
		[Token(Token = "0x4003DF5")]
		never
	}

	// Token: 0x0200081D RID: 2077
	[Token(Token = "0x200081D")]
	[Serializable]
	public class TraitPick
	{
		// Token: 0x0600299F RID: 10655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299F")]
		[Address(RVA = "0xCAB0D0", Offset = "0xCAA0D0", VA = "0x180CAB0D0")]
		public TraitPick()
		{
		}

		// Token: 0x04003DF6 RID: 15862
		[Token(Token = "0x4003DF6")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait.RuleType rule;

		// Token: 0x04003DF7 RID: 15863
		[Token(Token = "0x4003DF7")]
		[FieldOffset(Offset = "0x18")]
		public List<CharacterTrait> traitList;

		// Token: 0x04003DF8 RID: 15864
		[Token(Token = "0x4003DF8")]
		[FieldOffset(Offset = "0x20")]
		public bool mustPassForApplication;

		// Token: 0x04003DF9 RID: 15865
		[Token(Token = "0x4003DF9")]
		[FieldOffset(Offset = "0x24")]
		public int appliedFrequencyMin;

		// Token: 0x04003DFA RID: 15866
		[Token(Token = "0x4003DFA")]
		[FieldOffset(Offset = "0x28")]
		public int appliedFrequencyMax;
	}

	// Token: 0x0200081E RID: 2078
	[Token(Token = "0x200081E")]
	public enum OwnedPlacementRule
	{
		// Token: 0x04003DFC RID: 15868
		[Token(Token = "0x4003DFC")]
		nonOwnedOnly,
		// Token: 0x04003DFD RID: 15869
		[Token(Token = "0x4003DFD")]
		ownedOnly,
		// Token: 0x04003DFE RID: 15870
		[Token(Token = "0x4003DFE")]
		prioritiseNonOwned,
		// Token: 0x04003DFF RID: 15871
		[Token(Token = "0x4003DFF")]
		prioritiseOwned,
		// Token: 0x04003E00 RID: 15872
		[Token(Token = "0x4003E00")]
		both
	}

	// Token: 0x0200081F RID: 2079
	[Token(Token = "0x200081F")]
	public enum RelocationAuthority
	{
		// Token: 0x04003E02 RID: 15874
		[Token(Token = "0x4003E02")]
		AIAndOwnersCanRelocate,
		// Token: 0x04003E03 RID: 15875
		[Token(Token = "0x4003E03")]
		ownerCanRelocate,
		// Token: 0x04003E04 RID: 15876
		[Token(Token = "0x4003E04")]
		anyoneCanRelocate,
		// Token: 0x04003E05 RID: 15877
		[Token(Token = "0x4003E05")]
		nooneCanRelocate
	}

	// Token: 0x02000820 RID: 2080
	[Token(Token = "0x2000820")]
	public enum FindEvidence
	{
		// Token: 0x04003E07 RID: 15879
		[Token(Token = "0x4003E07")]
		none,
		// Token: 0x04003E08 RID: 15880
		[Token(Token = "0x4003E08")]
		residentsContract,
		// Token: 0x04003E09 RID: 15881
		[Token(Token = "0x4003E09")]
		sideJob,
		// Token: 0x04003E0A RID: 15882
		[Token(Token = "0x4003E0A")]
		companyRoster,
		// Token: 0x04003E0B RID: 15883
		[Token(Token = "0x4003E0B")]
		addressKey,
		// Token: 0x04003E0C RID: 15884
		[Token(Token = "0x4003E0C")]
		businessCard,
		// Token: 0x04003E0D RID: 15885
		[Token(Token = "0x4003E0D")]
		namePlacard,
		// Token: 0x04003E0E RID: 15886
		[Token(Token = "0x4003E0E")]
		photo,
		// Token: 0x04003E0F RID: 15887
		[Token(Token = "0x4003E0F")]
		calendar,
		// Token: 0x04003E10 RID: 15888
		[Token(Token = "0x4003E10")]
		retailItem,
		// Token: 0x04003E11 RID: 15889
		[Token(Token = "0x4003E11")]
		workID,
		// Token: 0x04003E12 RID: 15890
		[Token(Token = "0x4003E12")]
		salesRecords,
		// Token: 0x04003E13 RID: 15891
		[Token(Token = "0x4003E13")]
		diary,
		// Token: 0x04003E14 RID: 15892
		[Token(Token = "0x4003E14")]
		menu,
		// Token: 0x04003E15 RID: 15893
		[Token(Token = "0x4003E15")]
		homeFile,
		// Token: 0x04003E16 RID: 15894
		[Token(Token = "0x4003E16")]
		birthCertificate,
		// Token: 0x04003E17 RID: 15895
		[Token(Token = "0x4003E17")]
		bankStatement,
		// Token: 0x04003E18 RID: 15896
		[Token(Token = "0x4003E18")]
		medicalDetails,
		// Token: 0x04003E19 RID: 15897
		[Token(Token = "0x4003E19")]
		IDCard,
		// Token: 0x04003E1A RID: 15898
		[Token(Token = "0x4003E1A")]
		addressBook,
		// Token: 0x04003E1B RID: 15899
		[Token(Token = "0x4003E1B")]
		residentRoster,
		// Token: 0x04003E1C RID: 15900
		[Token(Token = "0x4003E1C")]
		telephone,
		// Token: 0x04003E1D RID: 15901
		[Token(Token = "0x4003E1D")]
		callLogs,
		// Token: 0x04003E1E RID: 15902
		[Token(Token = "0x4003E1E")]
		hospitalBed
	}

	// Token: 0x02000821 RID: 2081
	[Token(Token = "0x2000821")]
	public enum SpecialCase
	{
		// Token: 0x04003E20 RID: 15904
		[Token(Token = "0x4003E20")]
		none,
		// Token: 0x04003E21 RID: 15905
		[Token(Token = "0x4003E21")]
		sleepPosition,
		// Token: 0x04003E22 RID: 15906
		[Token(Token = "0x4003E22")]
		workDesk,
		// Token: 0x04003E23 RID: 15907
		[Token(Token = "0x4003E23")]
		workCounter,
		// Token: 0x04003E24 RID: 15908
		[Token(Token = "0x4003E24")]
		workKitchen,
		// Token: 0x04003E25 RID: 15909
		[Token(Token = "0x4003E25")]
		securityDoor,
		// Token: 0x04003E26 RID: 15910
		[Token(Token = "0x4003E26")]
		alarmSystem,
		// Token: 0x04003E27 RID: 15911
		[Token(Token = "0x4003E27")]
		sentryGun,
		// Token: 0x04003E28 RID: 15912
		[Token(Token = "0x4003E28")]
		securityCamera,
		// Token: 0x04003E29 RID: 15913
		[Token(Token = "0x4003E29")]
		interestBook,
		// Token: 0x04003E2A RID: 15914
		[Token(Token = "0x4003E2A")]
		bookStack,
		// Token: 0x04003E2B RID: 15915
		[Token(Token = "0x4003E2B")]
		thrownItem,
		// Token: 0x04003E2C RID: 15916
		[Token(Token = "0x4003E2C")]
		fingerprint,
		// Token: 0x04003E2D RID: 15917
		[Token(Token = "0x4003E2D")]
		shower,
		// Token: 0x04003E2E RID: 15918
		[Token(Token = "0x4003E2E")]
		syncDisk,
		// Token: 0x04003E2F RID: 15919
		[Token(Token = "0x4003E2F")]
		unused1,
		// Token: 0x04003E30 RID: 15920
		[Token(Token = "0x4003E30")]
		unused2,
		// Token: 0x04003E31 RID: 15921
		[Token(Token = "0x4003E31")]
		codebreaker,
		// Token: 0x04003E32 RID: 15922
		[Token(Token = "0x4003E32")]
		doorWedge,
		// Token: 0x04003E33 RID: 15923
		[Token(Token = "0x4003E33")]
		telephone,
		// Token: 0x04003E34 RID: 15924
		[Token(Token = "0x4003E34")]
		hospitalBed,
		// Token: 0x04003E35 RID: 15925
		[Token(Token = "0x4003E35")]
		syncBed,
		// Token: 0x04003E36 RID: 15926
		[Token(Token = "0x4003E36")]
		padlock,
		// Token: 0x04003E37 RID: 15927
		[Token(Token = "0x4003E37")]
		salesLedger,
		// Token: 0x04003E38 RID: 15928
		[Token(Token = "0x4003E38")]
		caseTray,
		// Token: 0x04003E39 RID: 15929
		[Token(Token = "0x4003E39")]
		footprint,
		// Token: 0x04003E3A RID: 15930
		[Token(Token = "0x4003E3A")]
		breakerSecurity,
		// Token: 0x04003E3B RID: 15931
		[Token(Token = "0x4003E3B")]
		breakerLights,
		// Token: 0x04003E3C RID: 15932
		[Token(Token = "0x4003E3C")]
		breakerDoors,
		// Token: 0x04003E3D RID: 15933
		[Token(Token = "0x4003E3D")]
		fridge,
		// Token: 0x04003E3E RID: 15934
		[Token(Token = "0x4003E3E")]
		stovetopKettle,
		// Token: 0x04003E3F RID: 15935
		[Token(Token = "0x4003E3F")]
		syncDiskUpgrade,
		// Token: 0x04003E40 RID: 15936
		[Token(Token = "0x4003E40")]
		otherSecuritySystem,
		// Token: 0x04003E41 RID: 15937
		[Token(Token = "0x4003E41")]
		gasReleaseSystem,
		// Token: 0x04003E42 RID: 15938
		[Token(Token = "0x4003E42")]
		tracker,
		// Token: 0x04003E43 RID: 15939
		[Token(Token = "0x4003E43")]
		grenade,
		// Token: 0x04003E44 RID: 15940
		[Token(Token = "0x4003E44")]
		ballisticArmour,
		// Token: 0x04003E45 RID: 15941
		[Token(Token = "0x4003E45")]
		forceStanding,
		// Token: 0x04003E46 RID: 15942
		[Token(Token = "0x4003E46")]
		lightswitch,
		// Token: 0x04003E47 RID: 15943
		[Token(Token = "0x4003E47")]
		airVent,
		// Token: 0x04003E48 RID: 15944
		[Token(Token = "0x4003E48")]
		burningBarrel,
		// Token: 0x04003E49 RID: 15945
		[Token(Token = "0x4003E49")]
		addressBook,
		// Token: 0x04003E4A RID: 15946
		[Token(Token = "0x4003E4A")]
		garbageDisposal,
		// Token: 0x04003E4B RID: 15947
		[Token(Token = "0x4003E4B")]
		glassBulletHole,
		// Token: 0x04003E4C RID: 15948
		[Token(Token = "0x4003E4C")]
		bloodPool,
		// Token: 0x04003E4D RID: 15949
		[Token(Token = "0x4003E4D")]
		briefcase,
		// Token: 0x04003E4E RID: 15950
		[Token(Token = "0x4003E4E")]
		umbrella,
		// Token: 0x04003E4F RID: 15951
		[Token(Token = "0x4003E4F")]
		basBouleCardCommon,
		// Token: 0x04003E50 RID: 15952
		[Token(Token = "0x4003E50")]
		basBouleCardRare,
		// Token: 0x04003E51 RID: 15953
		[Token(Token = "0x4003E51")]
		basBouleCardVeryRare,
		// Token: 0x04003E52 RID: 15954
		[Token(Token = "0x4003E52")]
		cigarettes,
		// Token: 0x04003E53 RID: 15955
		[Token(Token = "0x4003E53")]
		cigars
	}

	// Token: 0x02000822 RID: 2082
	[Token(Token = "0x2000822")]
	[Serializable]
	public class SubSpawnSlot
	{
		// Token: 0x060029A0 RID: 10656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public SubSpawnSlot()
		{
		}

		// Token: 0x04003E54 RID: 15956
		[Token(Token = "0x4003E54")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 localPos;

		// Token: 0x04003E55 RID: 15957
		[Token(Token = "0x4003E55")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 localEuler;
	}
}
