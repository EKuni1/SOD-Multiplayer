using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000746 RID: 1862
[Token(Token = "0x2000746")]
public class AIActionPreset : SoCustomComparison
{
	// Token: 0x060028F1 RID: 10481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028F1")]
	[Address(RVA = "0xC65C60", Offset = "0xC64C60", VA = "0x180C65C60")]
	public AIActionPreset()
	{
	}

	// Token: 0x04003437 RID: 13367
	[Token(Token = "0x4003437")]
	[FieldOffset(Offset = "0x20")]
	public InteractablePreset.InteractionKey defaultKey;

	// Token: 0x04003438 RID: 13368
	[Token(Token = "0x4003438")]
	[FieldOffset(Offset = "0x24")]
	public bool debug;

	// Token: 0x04003439 RID: 13369
	[Token(Token = "0x4003439")]
	[FieldOffset(Offset = "0x28")]
	public int inputPriority;

	// Token: 0x0400343A RID: 13370
	[Token(Token = "0x400343A")]
	[FieldOffset(Offset = "0x2C")]
	public bool unavailableWhenItemSelected;

	// Token: 0x0400343B RID: 13371
	[Token(Token = "0x400343B")]
	[FieldOffset(Offset = "0x30")]
	public List<FirstPersonItem> unavailableWhenItemsSelected;

	// Token: 0x0400343C RID: 13372
	[Token(Token = "0x400343C")]
	[FieldOffset(Offset = "0x38")]
	public bool onlyAvailableWhenItemSelected;

	// Token: 0x0400343D RID: 13373
	[Token(Token = "0x400343D")]
	[FieldOffset(Offset = "0x40")]
	public List<FirstPersonItem> availableWhenItemsSelected;

	// Token: 0x0400343E RID: 13374
	[Token(Token = "0x400343E")]
	[FieldOffset(Offset = "0x48")]
	public bool holsterCurrentItemOnAction;

	// Token: 0x0400343F RID: 13375
	[Token(Token = "0x400343F")]
	[FieldOffset(Offset = "0x49")]
	public bool disableUIDisplay;

	// Token: 0x04003440 RID: 13376
	[Token(Token = "0x4003440")]
	[FieldOffset(Offset = "0x4A")]
	public bool allowInteractionAtRecognitionRange;

	// Token: 0x04003441 RID: 13377
	[Token(Token = "0x4003441")]
	[FieldOffset(Offset = "0x4C")]
	public AIActionPreset.ActionLocation actionLocation;

	// Token: 0x04003442 RID: 13378
	[Token(Token = "0x4003442")]
	[FieldOffset(Offset = "0x50")]
	public bool confirmActionLocation;

	// Token: 0x04003443 RID: 13379
	[Token(Token = "0x4003443")]
	[FieldOffset(Offset = "0x51")]
	public bool useRandomNodeSublocation;

	// Token: 0x04003444 RID: 13380
	[Token(Token = "0x4003444")]
	[FieldOffset(Offset = "0x54")]
	public AIActionPreset.ActionFinding onUnableToFindLocation;

	// Token: 0x04003445 RID: 13381
	[Token(Token = "0x4003445")]
	[FieldOffset(Offset = "0x58")]
	public AIActionPreset.FindSetting searchSetting;

	// Token: 0x04003446 RID: 13382
	[Token(Token = "0x4003446")]
	[FieldOffset(Offset = "0x5C")]
	public AIActionPreset.ActionBusy onUsePointBusy;

	// Token: 0x04003447 RID: 13383
	[Token(Token = "0x4003447")]
	[FieldOffset(Offset = "0x60")]
	public Interactable.UsePointSlot usageSlot;

	// Token: 0x04003448 RID: 13384
	[Token(Token = "0x4003448")]
	[FieldOffset(Offset = "0x64")]
	public bool useCloseEnoughSetting;

	// Token: 0x04003449 RID: 13385
	[Token(Token = "0x4003449")]
	[FieldOffset(Offset = "0x68")]
	public float robberyPriorityMultiplier;

	// Token: 0x0400344A RID: 13386
	[Token(Token = "0x400344A")]
	[FieldOffset(Offset = "0x6C")]
	public bool avoidRepeatingInteractables;

	// Token: 0x0400344B RID: 13387
	[Token(Token = "0x400344B")]
	[FieldOffset(Offset = "0x6D")]
	public bool filterSearchUsingRoomType;

	// Token: 0x0400344C RID: 13388
	[Token(Token = "0x400344C")]
	[FieldOffset(Offset = "0x70")]
	public List<RoomTypePreset> searchRoomType;

	// Token: 0x0400344D RID: 13389
	[Token(Token = "0x400344D")]
	[FieldOffset(Offset = "0x78")]
	public bool limitSearchToGoalLocation;

	// Token: 0x0400344E RID: 13390
	[Token(Token = "0x400344E")]
	[FieldOffset(Offset = "0x79")]
	public bool findOverrideWithHome;

	// Token: 0x0400344F RID: 13391
	[Token(Token = "0x400344F")]
	[FieldOffset(Offset = "0x7A")]
	public bool requiresTelephone;

	// Token: 0x04003450 RID: 13392
	[Token(Token = "0x4003450")]
	[FieldOffset(Offset = "0x7B")]
	public bool requiresTelephoneNoCall;

	// Token: 0x04003451 RID: 13393
	[Token(Token = "0x4003451")]
	[FieldOffset(Offset = "0x7C")]
	public bool activationRequiresConsumable;

	// Token: 0x04003452 RID: 13394
	[Token(Token = "0x4003452")]
	[FieldOffset(Offset = "0x80")]
	public AIActionPreset.SourceOfBannedRooms bannedRooms;

	// Token: 0x04003453 RID: 13395
	[Token(Token = "0x4003453")]
	[FieldOffset(Offset = "0x84")]
	public bool completableAction;

	// Token: 0x04003454 RID: 13396
	[Token(Token = "0x4003454")]
	[FieldOffset(Offset = "0x88")]
	public Vector2 minutesTakenRange;

	// Token: 0x04003455 RID: 13397
	[Token(Token = "0x4003455")]
	[FieldOffset(Offset = "0x90")]
	public bool completeOnSeeIllegal;

	// Token: 0x04003456 RID: 13398
	[Token(Token = "0x4003456")]
	[FieldOffset(Offset = "0x91")]
	public bool repeatOnComplete;

	// Token: 0x04003457 RID: 13399
	[Token(Token = "0x4003457")]
	[FieldOffset(Offset = "0x92")]
	public bool repeatWhileHavingConsumables;

	// Token: 0x04003458 RID: 13400
	[Token(Token = "0x4003458")]
	[FieldOffset(Offset = "0x93")]
	public bool requiresForcedUpdate;

	// Token: 0x04003459 RID: 13401
	[Token(Token = "0x4003459")]
	[FieldOffset(Offset = "0x94")]
	public bool enableImmediateCompletionWhenFarAway;

	// Token: 0x0400345A RID: 13402
	[Token(Token = "0x400345A")]
	[FieldOffset(Offset = "0x95")]
	public bool dontUpdateGoalPriorityWhileActive;

	// Token: 0x0400345B RID: 13403
	[Token(Token = "0x400345B")]
	[FieldOffset(Offset = "0x98")]
	public int dontUpdateGoalPriorityFor;

	// Token: 0x0400345C RID: 13404
	[Token(Token = "0x400345C")]
	[FieldOffset(Offset = "0x9C")]
	public bool limitTickRate;

	// Token: 0x0400345D RID: 13405
	[Token(Token = "0x400345D")]
	[FieldOffset(Offset = "0xA0")]
	public NewAIController.AITickRate minimumTickRate;

	// Token: 0x0400345E RID: 13406
	[Token(Token = "0x400345E")]
	[FieldOffset(Offset = "0xA4")]
	public NewAIController.AITickRate maximumTickRate;

	// Token: 0x0400345F RID: 13407
	[Token(Token = "0x400345F")]
	[FieldOffset(Offset = "0xA8")]
	public bool dontRemoveOnRefresh;

	// Token: 0x04003460 RID: 13408
	[Token(Token = "0x4003460")]
	[FieldOffset(Offset = "0xA9")]
	public bool nonRefreshable;

	// Token: 0x04003461 RID: 13409
	[Token(Token = "0x4003461")]
	[FieldOffset(Offset = "0xAA")]
	public bool useLOSCheck;

	// Token: 0x04003462 RID: 13410
	[Token(Token = "0x4003462")]
	[FieldOffset(Offset = "0xAB")]
	public bool cancelIfNonValidMugging;

	// Token: 0x04003463 RID: 13411
	[Token(Token = "0x4003463")]
	[FieldOffset(Offset = "0xAC")]
	public bool cancelIfPlayerNotLoitering;

	// Token: 0x04003464 RID: 13412
	[Token(Token = "0x4003464")]
	[FieldOffset(Offset = "0xAD")]
	public bool skipIfAIIsInState;

	// Token: 0x04003465 RID: 13413
	[Token(Token = "0x4003465")]
	[FieldOffset(Offset = "0xB0")]
	public NewAIController.ReactionState skipIfReaction;

	// Token: 0x04003466 RID: 13414
	[Token(Token = "0x4003466")]
	[FieldOffset(Offset = "0xB4")]
	public bool skipIfGuestPass;

	// Token: 0x04003467 RID: 13415
	[Token(Token = "0x4003467")]
	[FieldOffset(Offset = "0xB8")]
	public AIActionPreset.ActionFacingDirection facing;

	// Token: 0x04003468 RID: 13416
	[Token(Token = "0x4003468")]
	[FieldOffset(Offset = "0xBC")]
	public bool lookAround;

	// Token: 0x04003469 RID: 13417
	[Token(Token = "0x4003469")]
	[FieldOffset(Offset = "0xBD")]
	public bool cancelIfPersuitTargetNotInRange;

	// Token: 0x0400346A RID: 13418
	[Token(Token = "0x400346A")]
	[FieldOffset(Offset = "0xBE")]
	public bool facePlayerWhileTalkingTo;

	// Token: 0x0400346B RID: 13419
	[Token(Token = "0x400346B")]
	[FieldOffset(Offset = "0xBF")]
	public bool changeIdleOnActivate;

	// Token: 0x0400346C RID: 13420
	[Token(Token = "0x400346C")]
	[FieldOffset(Offset = "0xC0")]
	public CitizenAnimationController.IdleAnimationState idleAnimationOnActivate;

	// Token: 0x0400346D RID: 13421
	[Token(Token = "0x400346D")]
	[FieldOffset(Offset = "0xC4")]
	public bool changeIdleOnArrival;

	// Token: 0x0400346E RID: 13422
	[Token(Token = "0x400346E")]
	[FieldOffset(Offset = "0xC8")]
	public CitizenAnimationController.IdleAnimationState idleAnimationOnArrival;

	// Token: 0x0400346F RID: 13423
	[Token(Token = "0x400346F")]
	[FieldOffset(Offset = "0xCC")]
	public bool changeIdleOnDeactivate;

	// Token: 0x04003470 RID: 13424
	[Token(Token = "0x4003470")]
	[FieldOffset(Offset = "0xD0")]
	public CitizenAnimationController.IdleAnimationState idleAnimationOnDeactivate;

	// Token: 0x04003471 RID: 13425
	[Token(Token = "0x4003471")]
	[FieldOffset(Offset = "0xD4")]
	public bool changeIdleOnComplete;

	// Token: 0x04003472 RID: 13426
	[Token(Token = "0x4003472")]
	[FieldOffset(Offset = "0xD8")]
	public CitizenAnimationController.IdleAnimationState idleAnimationOnComplete;

	// Token: 0x04003473 RID: 13427
	[Token(Token = "0x4003473")]
	[FieldOffset(Offset = "0xDC")]
	public bool changeArmsOnActivate;

	// Token: 0x04003474 RID: 13428
	[Token(Token = "0x4003474")]
	[FieldOffset(Offset = "0xE0")]
	public CitizenAnimationController.ArmsBoolSate armsAnimationOnActivate;

	// Token: 0x04003475 RID: 13429
	[Token(Token = "0x4003475")]
	[FieldOffset(Offset = "0xE4")]
	public bool changeArmsOnArrival;

	// Token: 0x04003476 RID: 13430
	[Token(Token = "0x4003476")]
	[FieldOffset(Offset = "0xE8")]
	public CitizenAnimationController.ArmsBoolSate armsAnimationOnArrival;

	// Token: 0x04003477 RID: 13431
	[Token(Token = "0x4003477")]
	[FieldOffset(Offset = "0xEC")]
	public bool changeArmsOnDeactivate;

	// Token: 0x04003478 RID: 13432
	[Token(Token = "0x4003478")]
	[FieldOffset(Offset = "0xF0")]
	public CitizenAnimationController.ArmsBoolSate armsAnimationOnDeactivate;

	// Token: 0x04003479 RID: 13433
	[Token(Token = "0x4003479")]
	[FieldOffset(Offset = "0xF4")]
	public bool changeArmsOnComplete;

	// Token: 0x0400347A RID: 13434
	[Token(Token = "0x400347A")]
	[FieldOffset(Offset = "0xF8")]
	public CitizenAnimationController.ArmsBoolSate armsAnimationOnComplete;

	// Token: 0x0400347B RID: 13435
	[Token(Token = "0x400347B")]
	[FieldOffset(Offset = "0xFC")]
	public bool lying;

	// Token: 0x0400347C RID: 13436
	[Token(Token = "0x400347C")]
	[FieldOffset(Offset = "0xFD")]
	public bool lyingOnFloor;

	// Token: 0x0400347D RID: 13437
	[Token(Token = "0x400347D")]
	[FieldOffset(Offset = "0xFE")]
	public bool useCurrentConsumable;

	// Token: 0x0400347E RID: 13438
	[Token(Token = "0x400347E")]
	[FieldOffset(Offset = "0x100")]
	public float progressNourishment;

	// Token: 0x0400347F RID: 13439
	[Token(Token = "0x400347F")]
	[FieldOffset(Offset = "0x104")]
	public float progressHydration;

	// Token: 0x04003480 RID: 13440
	[Token(Token = "0x4003480")]
	[FieldOffset(Offset = "0x108")]
	public float progressAlertness;

	// Token: 0x04003481 RID: 13441
	[Token(Token = "0x4003481")]
	[FieldOffset(Offset = "0x10C")]
	public float progressEnergy;

	// Token: 0x04003482 RID: 13442
	[Token(Token = "0x4003482")]
	[FieldOffset(Offset = "0x110")]
	public float progressExcitement;

	// Token: 0x04003483 RID: 13443
	[Token(Token = "0x4003483")]
	[FieldOffset(Offset = "0x114")]
	public float progressChores;

	// Token: 0x04003484 RID: 13444
	[Token(Token = "0x4003484")]
	[FieldOffset(Offset = "0x118")]
	public float progressHygeiene;

	// Token: 0x04003485 RID: 13445
	[Token(Token = "0x4003485")]
	[FieldOffset(Offset = "0x11C")]
	public float progressBladder;

	// Token: 0x04003486 RID: 13446
	[Token(Token = "0x4003486")]
	[FieldOffset(Offset = "0x120")]
	public float progressHeat;

	// Token: 0x04003487 RID: 13447
	[Token(Token = "0x4003487")]
	[FieldOffset(Offset = "0x124")]
	public float progressDrunk;

	// Token: 0x04003488 RID: 13448
	[Token(Token = "0x4003488")]
	[FieldOffset(Offset = "0x128")]
	public float progressBreath;

	// Token: 0x04003489 RID: 13449
	[Token(Token = "0x4003489")]
	[FieldOffset(Offset = "0x12C")]
	public float progressPoisoned;

	// Token: 0x0400348A RID: 13450
	[Token(Token = "0x400348A")]
	[FieldOffset(Offset = "0x130")]
	public float overtimeNourishment;

	// Token: 0x0400348B RID: 13451
	[Token(Token = "0x400348B")]
	[FieldOffset(Offset = "0x134")]
	public float overtimeHydration;

	// Token: 0x0400348C RID: 13452
	[Token(Token = "0x400348C")]
	[FieldOffset(Offset = "0x138")]
	public float overtimeAlertness;

	// Token: 0x0400348D RID: 13453
	[Token(Token = "0x400348D")]
	[FieldOffset(Offset = "0x13C")]
	public float overtimeEnergy;

	// Token: 0x0400348E RID: 13454
	[Token(Token = "0x400348E")]
	[FieldOffset(Offset = "0x140")]
	public float overtimeExcitement;

	// Token: 0x0400348F RID: 13455
	[Token(Token = "0x400348F")]
	[FieldOffset(Offset = "0x144")]
	public float overtimeChores;

	// Token: 0x04003490 RID: 13456
	[Token(Token = "0x4003490")]
	[FieldOffset(Offset = "0x148")]
	public float overtimeHygiene;

	// Token: 0x04003491 RID: 13457
	[Token(Token = "0x4003491")]
	[FieldOffset(Offset = "0x14C")]
	public float overtimeBladder;

	// Token: 0x04003492 RID: 13458
	[Token(Token = "0x4003492")]
	[FieldOffset(Offset = "0x150")]
	public float overtimeHeat;

	// Token: 0x04003493 RID: 13459
	[Token(Token = "0x4003493")]
	[FieldOffset(Offset = "0x154")]
	public float overtimeDrunk;

	// Token: 0x04003494 RID: 13460
	[Token(Token = "0x4003494")]
	[FieldOffset(Offset = "0x158")]
	public float overtimeBreath;

	// Token: 0x04003495 RID: 13461
	[Token(Token = "0x4003495")]
	[FieldOffset(Offset = "0x15C")]
	public float overtimePoison;

	// Token: 0x04003496 RID: 13462
	[Token(Token = "0x4003496")]
	[FieldOffset(Offset = "0x160")]
	public bool useInvestigationUrgency;

	// Token: 0x04003497 RID: 13463
	[Token(Token = "0x4003497")]
	[FieldOffset(Offset = "0x161")]
	public bool forceRun;

	// Token: 0x04003498 RID: 13464
	[Token(Token = "0x4003498")]
	[FieldOffset(Offset = "0x162")]
	public bool runIfSeesPlayer;

	// Token: 0x04003499 RID: 13465
	[Token(Token = "0x4003499")]
	[FieldOffset(Offset = "0x163")]
	public bool socialRules;

	// Token: 0x0400349A RID: 13466
	[Token(Token = "0x400349A")]
	[FieldOffset(Offset = "0x164")]
	public bool spookAction;

	// Token: 0x0400349B RID: 13467
	[Token(Token = "0x400349B")]
	[FieldOffset(Offset = "0x165")]
	public bool disableSightingUpdates;

	// Token: 0x0400349C RID: 13468
	[Token(Token = "0x400349C")]
	[FieldOffset(Offset = "0x166")]
	public bool attackPersuitTargetOnProximity;

	// Token: 0x0400349D RID: 13469
	[Token(Token = "0x400349D")]
	[FieldOffset(Offset = "0x167")]
	public bool throwObjectsAtTarget;

	// Token: 0x0400349E RID: 13470
	[Token(Token = "0x400349E")]
	[FieldOffset(Offset = "0x168")]
	public AIActionPreset.CombatPose useCombatPose;

	// Token: 0x0400349F RID: 13471
	[Token(Token = "0x400349F")]
	[FieldOffset(Offset = "0x16C")]
	public bool onlyUseCombatPoseWithEscalationOne;

	// Token: 0x040034A0 RID: 13472
	[Token(Token = "0x40034A0")]
	[FieldOffset(Offset = "0x16D")]
	public bool sleepOnArrival;

	// Token: 0x040034A1 RID: 13473
	[Token(Token = "0x40034A1")]
	[FieldOffset(Offset = "0x16E")]
	public bool uninteruptableWhileAtLocation;

	// Token: 0x040034A2 RID: 13474
	[Token(Token = "0x40034A2")]
	[FieldOffset(Offset = "0x16F")]
	public bool progressVmailThreads;

	// Token: 0x040034A3 RID: 13475
	[Token(Token = "0x40034A3")]
	[FieldOffset(Offset = "0x170")]
	public bool disableConversationTriggers;

	// Token: 0x040034A4 RID: 13476
	[Token(Token = "0x40034A4")]
	[FieldOffset(Offset = "0x171")]
	public bool exitConversationOnActivate;

	// Token: 0x040034A5 RID: 13477
	[Token(Token = "0x40034A5")]
	[FieldOffset(Offset = "0x178")]
	public List<InteractablePreset> forcedActive;

	// Token: 0x040034A6 RID: 13478
	[Token(Token = "0x40034A6")]
	[FieldOffset(Offset = "0x180")]
	public List<AIActionPreset.AutomaticAction> forcedActionsOnArrival;

	// Token: 0x040034A7 RID: 13479
	[Token(Token = "0x40034A7")]
	[FieldOffset(Offset = "0x188")]
	public List<AIActionPreset.AutomaticAction> forcedActionsOnComplete;

	// Token: 0x040034A8 RID: 13480
	[Token(Token = "0x40034A8")]
	[FieldOffset(Offset = "0x190")]
	public AIActionPreset.ForcedActionsSearchLevel forcedActionsSearchLevel;

	// Token: 0x040034A9 RID: 13481
	[Token(Token = "0x40034A9")]
	[FieldOffset(Offset = "0x194")]
	public bool executeCompleteActionsOnEnd;

	// Token: 0x040034AA RID: 13482
	[Token(Token = "0x40034AA")]
	[FieldOffset(Offset = "0x195")]
	public bool executeCompleteActionsOnEndIfArrived;

	// Token: 0x040034AB RID: 13483
	[Token(Token = "0x40034AB")]
	[FieldOffset(Offset = "0x196")]
	public bool executeThisOnComplete;

	// Token: 0x040034AC RID: 13484
	[Token(Token = "0x40034AC")]
	[FieldOffset(Offset = "0x198")]
	public List<InteractablePreset.SwitchState> switchStatesOnEnd;

	// Token: 0x040034AD RID: 13485
	[Token(Token = "0x40034AD")]
	[FieldOffset(Offset = "0x1A0")]
	public bool tamperAction;

	// Token: 0x040034AE RID: 13486
	[Token(Token = "0x40034AE")]
	[FieldOffset(Offset = "0x1A1")]
	public bool tamperResetAction;

	// Token: 0x040034AF RID: 13487
	[Token(Token = "0x40034AF")]
	[FieldOffset(Offset = "0x1A4")]
	public int fallAsleepAfterMinimum;

	// Token: 0x040034B0 RID: 13488
	[Token(Token = "0x40034B0")]
	[FieldOffset(Offset = "0x1A8")]
	public bool allowSniperShot;

	// Token: 0x040034B1 RID: 13489
	[Token(Token = "0x40034B1")]
	[FieldOffset(Offset = "0x1B0")]
	public List<AIActionPreset.CheckActionAgainstState> checkActionAgainstState;

	// Token: 0x040034B2 RID: 13490
	[Token(Token = "0x40034B2")]
	[FieldOffset(Offset = "0x1B8")]
	public bool forceReactionState;

	// Token: 0x040034B3 RID: 13491
	[Token(Token = "0x40034B3")]
	[FieldOffset(Offset = "0x1BC")]
	public NewAIController.ReactionState setReactionState;

	// Token: 0x040034B4 RID: 13492
	[Token(Token = "0x40034B4")]
	[FieldOffset(Offset = "0x1C0")]
	public bool ignoreLockedDoors;

	// Token: 0x040034B5 RID: 13493
	[Token(Token = "0x40034B5")]
	[FieldOffset(Offset = "0x1C1")]
	public bool breakDownDoors;

	// Token: 0x040034B6 RID: 13494
	[Token(Token = "0x40034B6")]
	[FieldOffset(Offset = "0x1C2")]
	public bool doorsAllowed;

	// Token: 0x040034B7 RID: 13495
	[Token(Token = "0x40034B7")]
	[FieldOffset(Offset = "0x1C3")]
	public bool deactivateAllowed;

	// Token: 0x040034B8 RID: 13496
	[Token(Token = "0x40034B8")]
	[FieldOffset(Offset = "0x1C4")]
	public float repeatDelayOnActionFail;

	// Token: 0x040034B9 RID: 13497
	[Token(Token = "0x40034B9")]
	[FieldOffset(Offset = "0x1C8")]
	public float repeatDelayOnActionSuccess;

	// Token: 0x040034BA RID: 13498
	[Token(Token = "0x40034BA")]
	[FieldOffset(Offset = "0x1CC")]
	public bool turnAllGamelocationLightsOff;

	// Token: 0x040034BB RID: 13499
	[Token(Token = "0x40034BB")]
	[FieldOffset(Offset = "0x1CD")]
	public bool overrideGoalLightRule;

	// Token: 0x040034BC RID: 13500
	[Token(Token = "0x40034BC")]
	[FieldOffset(Offset = "0x1CE")]
	public bool onlyOverrideIfAtGamelocation;

	// Token: 0x040034BD RID: 13501
	[Token(Token = "0x40034BD")]
	[FieldOffset(Offset = "0x1D0")]
	public List<RoomConfiguration.AILightingBehaviour> lightingBehaviour;

	// Token: 0x040034BE RID: 13502
	[Token(Token = "0x40034BE")]
	[FieldOffset(Offset = "0x1D8")]
	public bool overrideGoalDoorRule;

	// Token: 0x040034BF RID: 13503
	[Token(Token = "0x40034BF")]
	[FieldOffset(Offset = "0x1DC")]
	public AIActionPreset.DoorRule doorRule;

	// Token: 0x040034C0 RID: 13504
	[Token(Token = "0x40034C0")]
	[FieldOffset(Offset = "0x1E0")]
	public bool spawnTauntOnSuccess;

	// Token: 0x040034C1 RID: 13505
	[Token(Token = "0x40034C1")]
	[FieldOffset(Offset = "0x1E8")]
	public AudioEvent onArrivalSound;

	// Token: 0x040034C2 RID: 13506
	[Token(Token = "0x40034C2")]
	[FieldOffset(Offset = "0x1F0")]
	public bool isLoop;

	// Token: 0x040034C3 RID: 13507
	[Token(Token = "0x40034C3")]
	[FieldOffset(Offset = "0x1F4")]
	public float soundDelay;

	// Token: 0x040034C4 RID: 13508
	[Token(Token = "0x40034C4")]
	[FieldOffset(Offset = "0x1F8")]
	public bool outdoorClothingCheck;

	// Token: 0x040034C5 RID: 13509
	[Token(Token = "0x40034C5")]
	[FieldOffset(Offset = "0x1F9")]
	public bool specificOutfitOnActivate;

	// Token: 0x040034C6 RID: 13510
	[Token(Token = "0x40034C6")]
	[FieldOffset(Offset = "0x1FC")]
	public ClothesPreset.OutfitCategory allowedOutfitOnActivate;

	// Token: 0x040034C7 RID: 13511
	[Token(Token = "0x40034C7")]
	[FieldOffset(Offset = "0x200")]
	public bool makeClothedOnActivate;

	// Token: 0x040034C8 RID: 13512
	[Token(Token = "0x40034C8")]
	[FieldOffset(Offset = "0x201")]
	public bool specificOutfitOnArrive;

	// Token: 0x040034C9 RID: 13513
	[Token(Token = "0x40034C9")]
	[FieldOffset(Offset = "0x204")]
	public ClothesPreset.OutfitCategory allowedOutfitOnArrive;

	// Token: 0x040034CA RID: 13514
	[Token(Token = "0x40034CA")]
	[FieldOffset(Offset = "0x208")]
	public bool makeClothedOnArrive;

	// Token: 0x040034CB RID: 13515
	[Token(Token = "0x40034CB")]
	[FieldOffset(Offset = "0x209")]
	public bool specificOutfitOnDeactivate;

	// Token: 0x040034CC RID: 13516
	[Token(Token = "0x40034CC")]
	[FieldOffset(Offset = "0x20C")]
	public ClothesPreset.OutfitCategory allowedOutfitOnDeactivate;

	// Token: 0x040034CD RID: 13517
	[Token(Token = "0x40034CD")]
	[FieldOffset(Offset = "0x210")]
	public bool makeClothedOnDeactivate;

	// Token: 0x040034CE RID: 13518
	[Token(Token = "0x40034CE")]
	[FieldOffset(Offset = "0x211")]
	public bool specificOutfitOnComplete;

	// Token: 0x040034CF RID: 13519
	[Token(Token = "0x40034CF")]
	[FieldOffset(Offset = "0x214")]
	public ClothesPreset.OutfitCategory allowedOutfitOnComplete;

	// Token: 0x040034D0 RID: 13520
	[Token(Token = "0x40034D0")]
	[FieldOffset(Offset = "0x218")]
	public bool makeClothedOnComplete;

	// Token: 0x040034D1 RID: 13521
	[Token(Token = "0x40034D1")]
	[FieldOffset(Offset = "0x219")]
	public bool setExpressionOnActivate;

	// Token: 0x040034D2 RID: 13522
	[Token(Token = "0x40034D2")]
	[FieldOffset(Offset = "0x21C")]
	public CitizenOutfitController.Expression activateExpression;

	// Token: 0x040034D3 RID: 13523
	[Token(Token = "0x40034D3")]
	[FieldOffset(Offset = "0x220")]
	public bool setExpressionOnArrive;

	// Token: 0x040034D4 RID: 13524
	[Token(Token = "0x40034D4")]
	[FieldOffset(Offset = "0x224")]
	public CitizenOutfitController.Expression arriveExpression;

	// Token: 0x040034D5 RID: 13525
	[Token(Token = "0x40034D5")]
	[FieldOffset(Offset = "0x228")]
	public bool setExpressionOnDeactivate;

	// Token: 0x040034D6 RID: 13526
	[Token(Token = "0x40034D6")]
	[FieldOffset(Offset = "0x22C")]
	public CitizenOutfitController.Expression deactivateExpression;

	// Token: 0x040034D7 RID: 13527
	[Token(Token = "0x40034D7")]
	[FieldOffset(Offset = "0x230")]
	public bool setExpressionOnComplete;

	// Token: 0x040034D8 RID: 13528
	[Token(Token = "0x40034D8")]
	[FieldOffset(Offset = "0x234")]
	public CitizenOutfitController.Expression completeExpression;

	// Token: 0x040034D9 RID: 13529
	[Token(Token = "0x40034D9")]
	[FieldOffset(Offset = "0x238")]
	public bool allowItems;

	// Token: 0x040034DA RID: 13530
	[Token(Token = "0x40034DA")]
	[FieldOffset(Offset = "0x239")]
	public bool enableCustomItem;

	// Token: 0x040034DB RID: 13531
	[Token(Token = "0x40034DB")]
	[FieldOffset(Offset = "0x240")]
	public GameObject itemRight;

	// Token: 0x040034DC RID: 13532
	[Token(Token = "0x40034DC")]
	[FieldOffset(Offset = "0x248")]
	public Vector3 itemRightLocalPos;

	// Token: 0x040034DD RID: 13533
	[Token(Token = "0x40034DD")]
	[FieldOffset(Offset = "0x254")]
	public Vector3 itemRightLocalEuler;

	// Token: 0x040034DE RID: 13534
	[Token(Token = "0x40034DE")]
	[FieldOffset(Offset = "0x260")]
	public GameObject itemLeft;

	// Token: 0x040034DF RID: 13535
	[Token(Token = "0x40034DF")]
	[FieldOffset(Offset = "0x268")]
	public Vector3 itemLeftLocalPos;

	// Token: 0x040034E0 RID: 13536
	[Token(Token = "0x40034E0")]
	[FieldOffset(Offset = "0x274")]
	public Vector3 itemLeftLocalEuler;

	// Token: 0x040034E1 RID: 13537
	[Token(Token = "0x40034E1")]
	[FieldOffset(Offset = "0x280")]
	public AIActionPreset.ActionStateFlag spawnCustomItemOn;

	// Token: 0x040034E2 RID: 13538
	[Token(Token = "0x40034E2")]
	[FieldOffset(Offset = "0x284")]
	public AIActionPreset.ActionStateFlag destroyCustomItemOn;

	// Token: 0x040034E3 RID: 13539
	[Token(Token = "0x40034E3")]
	[FieldOffset(Offset = "0x288")]
	public bool requiresCarryAnimation;

	// Token: 0x040034E4 RID: 13540
	[Token(Token = "0x40034E4")]
	[FieldOffset(Offset = "0x28C")]
	public int overrideCarryAnimation;

	// Token: 0x040034E5 RID: 13541
	[Token(Token = "0x40034E5")]
	[FieldOffset(Offset = "0x290")]
	public InteractablePreset dropItemOnEnd;

	// Token: 0x040034E6 RID: 13542
	[Token(Token = "0x40034E6")]
	[FieldOffset(Offset = "0x298")]
	public float chanceOfOnTrigger;

	// Token: 0x040034E7 RID: 13543
	[Token(Token = "0x40034E7")]
	[FieldOffset(Offset = "0x2A0")]
	public List<SpeechController.Bark> onTriggerBark;

	// Token: 0x040034E8 RID: 13544
	[Token(Token = "0x40034E8")]
	[FieldOffset(Offset = "0x2A8")]
	public float chanceOfWhileJourney;

	// Token: 0x040034E9 RID: 13545
	[Token(Token = "0x40034E9")]
	[FieldOffset(Offset = "0x2B0")]
	public List<SpeechController.Bark> whileJourneyBark;

	// Token: 0x040034EA RID: 13546
	[Token(Token = "0x40034EA")]
	[FieldOffset(Offset = "0x2B8")]
	public float chanceOfOnArrival;

	// Token: 0x040034EB RID: 13547
	[Token(Token = "0x40034EB")]
	[FieldOffset(Offset = "0x2C0")]
	public List<SpeechController.Bark> onArrivalBark;

	// Token: 0x040034EC RID: 13548
	[Token(Token = "0x40034EC")]
	[FieldOffset(Offset = "0x2C8")]
	public float chanceOfWhileArrived;

	// Token: 0x040034ED RID: 13549
	[Token(Token = "0x40034ED")]
	[FieldOffset(Offset = "0x2CC")]
	public bool mustSeeOtherCitizen;

	// Token: 0x040034EE RID: 13550
	[Token(Token = "0x40034EE")]
	[FieldOffset(Offset = "0x2D0")]
	public List<SpeechController.Bark> whileArrivedBark;

	// Token: 0x040034EF RID: 13551
	[Token(Token = "0x40034EF")]
	[FieldOffset(Offset = "0x2D8")]
	public float chanceOfOnComplete;

	// Token: 0x040034F0 RID: 13552
	[Token(Token = "0x40034F0")]
	[FieldOffset(Offset = "0x2E0")]
	public List<SpeechController.Bark> onCompleteBark;

	// Token: 0x02000747 RID: 1863
	[Token(Token = "0x2000747")]
	public enum ActionLocation
	{
		// Token: 0x040034F2 RID: 13554
		[Token(Token = "0x40034F2")]
		interactable,
		// Token: 0x040034F3 RID: 13555
		[Token(Token = "0x40034F3")]
		findNearest,
		// Token: 0x040034F4 RID: 13556
		[Token(Token = "0x40034F4")]
		investigate,
		// Token: 0x040034F5 RID: 13557
		[Token(Token = "0x40034F5")]
		nearbyInvestigate,
		// Token: 0x040034F6 RID: 13558
		[Token(Token = "0x40034F6")]
		pause,
		// Token: 0x040034F7 RID: 13559
		[Token(Token = "0x40034F7")]
		randomNodeWithinLocation,
		// Token: 0x040034F8 RID: 13560
		[Token(Token = "0x40034F8")]
		flee,
		// Token: 0x040034F9 RID: 13561
		[Token(Token = "0x40034F9")]
		interactableLOS,
		// Token: 0x040034FA RID: 13562
		[Token(Token = "0x40034FA")]
		meetOther,
		// Token: 0x040034FB RID: 13563
		[Token(Token = "0x40034FB")]
		NearbyStreetRandomNode,
		// Token: 0x040034FC RID: 13564
		[Token(Token = "0x40034FC")]
		putDownInteractable,
		// Token: 0x040034FD RID: 13565
		[Token(Token = "0x40034FD")]
		pickUpInteractable,
		// Token: 0x040034FE RID: 13566
		[Token(Token = "0x40034FE")]
		randomNodeWithinHome,
		// Token: 0x040034FF RID: 13567
		[Token(Token = "0x40034FF")]
		interactableSpawn,
		// Token: 0x04003500 RID: 13568
		[Token(Token = "0x4003500")]
		proximityToMusic,
		// Token: 0x04003501 RID: 13569
		[Token(Token = "0x4003501")]
		player,
		// Token: 0x04003502 RID: 13570
		[Token(Token = "0x4003502")]
		tailAndConfrontPlayer,
		// Token: 0x04003503 RID: 13571
		[Token(Token = "0x4003503")]
		sniperVantagePoint,
		// Token: 0x04003504 RID: 13572
		[Token(Token = "0x4003504")]
		randomNodeWithinLocationPrioritiseWindows,
		// Token: 0x04003505 RID: 13573
		[Token(Token = "0x4003505")]
		randomNodeWithinDen,
		// Token: 0x04003506 RID: 13574
		[Token(Token = "0x4003506")]
		victimApartmentDoor,
		// Token: 0x04003507 RID: 13575
		[Token(Token = "0x4003507")]
		playerApartmentDoorOutside
	}

	// Token: 0x02000748 RID: 1864
	[Token(Token = "0x2000748")]
	public enum ActionFacingDirection
	{
		// Token: 0x04003509 RID: 13577
		[Token(Token = "0x4003509")]
		towardsDestination,
		// Token: 0x0400350A RID: 13578
		[Token(Token = "0x400350A")]
		awayFromDestination,
		// Token: 0x0400350B RID: 13579
		[Token(Token = "0x400350B")]
		interactable,
		// Token: 0x0400350C RID: 13580
		[Token(Token = "0x400350C")]
		InverseInteractable,
		// Token: 0x0400350D RID: 13581
		[Token(Token = "0x400350D")]
		accessableDirection,
		// Token: 0x0400350E RID: 13582
		[Token(Token = "0x400350E")]
		investigate,
		// Token: 0x0400350F RID: 13583
		[Token(Token = "0x400350F")]
		door,
		// Token: 0x04003510 RID: 13584
		[Token(Token = "0x4003510")]
		interactableSetting,
		// Token: 0x04003511 RID: 13585
		[Token(Token = "0x4003511")]
		none,
		// Token: 0x04003512 RID: 13586
		[Token(Token = "0x4003512")]
		inverseInteractableSetting,
		// Token: 0x04003513 RID: 13587
		[Token(Token = "0x4003513")]
		player,
		// Token: 0x04003514 RID: 13588
		[Token(Token = "0x4003514")]
		sniperVantagePoint,
		// Token: 0x04003515 RID: 13589
		[Token(Token = "0x4003515")]
		victim,
		// Token: 0x04003516 RID: 13590
		[Token(Token = "0x4003516")]
		awayFromSniperVantagePoint
	}

	// Token: 0x02000749 RID: 1865
	[Token(Token = "0x2000749")]
	public enum ActionFinding
	{
		// Token: 0x04003518 RID: 13592
		[Token(Token = "0x4003518")]
		doNothing,
		// Token: 0x04003519 RID: 13593
		[Token(Token = "0x4003519")]
		findNearest,
		// Token: 0x0400351A RID: 13594
		[Token(Token = "0x400351A")]
		removeAction,
		// Token: 0x0400351B RID: 13595
		[Token(Token = "0x400351B")]
		removeGoal
	}

	// Token: 0x0200074A RID: 1866
	[Token(Token = "0x200074A")]
	public enum ActionBusy
	{
		// Token: 0x0400351D RID: 13597
		[Token(Token = "0x400351D")]
		findAlternate,
		// Token: 0x0400351E RID: 13598
		[Token(Token = "0x400351E")]
		skipAction,
		// Token: 0x0400351F RID: 13599
		[Token(Token = "0x400351F")]
		skipGoal,
		// Token: 0x04003520 RID: 13600
		[Token(Token = "0x4003520")]
		standGuard,
		// Token: 0x04003521 RID: 13601
		[Token(Token = "0x4003521")]
		standGuardIfEnforcerSkipGoalNot
	}

	// Token: 0x0200074B RID: 1867
	[Token(Token = "0x200074B")]
	public enum FindSetting
	{
		// Token: 0x04003523 RID: 13603
		[Token(Token = "0x4003523")]
		nonTrespassing,
		// Token: 0x04003524 RID: 13604
		[Token(Token = "0x4003524")]
		onlyPublic,
		// Token: 0x04003525 RID: 13605
		[Token(Token = "0x4003525")]
		allAreas,
		// Token: 0x04003526 RID: 13606
		[Token(Token = "0x4003526")]
		homeOnly,
		// Token: 0x04003527 RID: 13607
		[Token(Token = "0x4003527")]
		workOnly
	}

	// Token: 0x0200074C RID: 1868
	[Token(Token = "0x200074C")]
	[Serializable]
	public class AISpeechPreset
	{
		// Token: 0x060028F2 RID: 10482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F2")]
		[Address(RVA = "0xC66580", Offset = "0xC65580", VA = "0x180C66580")]
		public AISpeechPreset()
		{
		}

		// Token: 0x04003528 RID: 13608
		[Token(Token = "0x4003528")]
		[FieldOffset(Offset = "0x10")]
		public string dictionaryString;

		// Token: 0x04003529 RID: 13609
		[Token(Token = "0x4003529")]
		[FieldOffset(Offset = "0x18")]
		public string ddsMessageID;

		// Token: 0x0400352A RID: 13610
		[Token(Token = "0x400352A")]
		[FieldOffset(Offset = "0x20")]
		public bool isSuccessful;

		// Token: 0x0400352B RID: 13611
		[Token(Token = "0x400352B")]
		[FieldOffset(Offset = "0x24")]
		public int chance;

		// Token: 0x0400352C RID: 13612
		[Token(Token = "0x400352C")]
		[FieldOffset(Offset = "0x28")]
		public bool useParsing;

		// Token: 0x0400352D RID: 13613
		[Token(Token = "0x400352D")]
		[FieldOffset(Offset = "0x29")]
		public bool shout;

		// Token: 0x0400352E RID: 13614
		[Token(Token = "0x400352E")]
		[FieldOffset(Offset = "0x2A")]
		public bool interupt;

		// Token: 0x0400352F RID: 13615
		[Token(Token = "0x400352F")]
		[FieldOffset(Offset = "0x2B")]
		public bool onlyIfEnfocerOnDuty;

		// Token: 0x04003530 RID: 13616
		[Token(Token = "0x4003530")]
		[FieldOffset(Offset = "0x2C")]
		public bool onlyIfNotEnforcerOnDuty;

		// Token: 0x04003531 RID: 13617
		[Token(Token = "0x4003531")]
		[FieldOffset(Offset = "0x30")]
		public List<CharacterTrait> mustFeatureTrait;

		// Token: 0x04003532 RID: 13618
		[Token(Token = "0x4003532")]
		[FieldOffset(Offset = "0x38")]
		public List<CharacterTrait> cantFeatureTrait;

		// Token: 0x04003533 RID: 13619
		[Token(Token = "0x4003533")]
		[FieldOffset(Offset = "0x40")]
		public List<MurderMO> mustBeKillerWithMotive;

		// Token: 0x04003534 RID: 13620
		[Token(Token = "0x4003534")]
		[FieldOffset(Offset = "0x48")]
		public bool useMurderMOConfession;

		// Token: 0x04003535 RID: 13621
		[Token(Token = "0x4003535")]
		[FieldOffset(Offset = "0x50")]
		public List<Evidence.DataKey> tieKeys;

		// Token: 0x04003536 RID: 13622
		[Token(Token = "0x4003536")]
		[FieldOffset(Offset = "0x58")]
		public List<Evidence.Discovery> applyDiscovery;

		// Token: 0x04003537 RID: 13623
		[Token(Token = "0x4003537")]
		[FieldOffset(Offset = "0x60")]
		public bool endsDialog;

		// Token: 0x04003538 RID: 13624
		[Token(Token = "0x4003538")]
		[FieldOffset(Offset = "0x61")]
		public bool jobHandIn;

		// Token: 0x04003539 RID: 13625
		[Token(Token = "0x4003539")]
		[FieldOffset(Offset = "0x62")]
		public bool startCombat;

		// Token: 0x0400353A RID: 13626
		[Token(Token = "0x400353A")]
		[FieldOffset(Offset = "0x63")]
		public bool flee;

		// Token: 0x0400353B RID: 13627
		[Token(Token = "0x400353B")]
		[FieldOffset(Offset = "0x64")]
		public bool giveUpSelf;
	}

	// Token: 0x0200074D RID: 1869
	[Token(Token = "0x200074D")]
	[Serializable]
	public class AutomaticAction
	{
		// Token: 0x060028F3 RID: 10483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public AutomaticAction()
		{
		}

		// Token: 0x0400353C RID: 13628
		[Token(Token = "0x400353C")]
		[FieldOffset(Offset = "0x10")]
		public AIActionPreset forcedAction;

		// Token: 0x0400353D RID: 13629
		[Token(Token = "0x400353D")]
		[FieldOffset(Offset = "0x18")]
		public bool proximityCheck;

		// Token: 0x0400353E RID: 13630
		[Token(Token = "0x400353E")]
		[FieldOffset(Offset = "0x1C")]
		public float additionalDelay;
	}

	// Token: 0x0200074E RID: 1870
	[Token(Token = "0x200074E")]
	public enum SourceOfBannedRooms
	{
		// Token: 0x04003540 RID: 13632
		[Token(Token = "0x4003540")]
		none,
		// Token: 0x04003541 RID: 13633
		[Token(Token = "0x4003541")]
		jobPreset
	}

	// Token: 0x0200074F RID: 1871
	[Token(Token = "0x200074F")]
	public enum CombatPose
	{
		// Token: 0x04003543 RID: 13635
		[Token(Token = "0x4003543")]
		noChange,
		// Token: 0x04003544 RID: 13636
		[Token(Token = "0x4003544")]
		always,
		// Token: 0x04003545 RID: 13637
		[Token(Token = "0x4003545")]
		never,
		// Token: 0x04003546 RID: 13638
		[Token(Token = "0x4003546")]
		onlyWhenPreviouslyPersuing,
		// Token: 0x04003547 RID: 13639
		[Token(Token = "0x4003547")]
		onlyWhenAtDestination
	}

	// Token: 0x02000750 RID: 1872
	[Token(Token = "0x2000750")]
	public enum ForcedActionsSearchLevel
	{
		// Token: 0x04003549 RID: 13641
		[Token(Token = "0x4003549")]
		thisObjectOnly,
		// Token: 0x0400354A RID: 13642
		[Token(Token = "0x400354A")]
		otherIntegratedInteractables,
		// Token: 0x0400354B RID: 13643
		[Token(Token = "0x400354B")]
		spawnInteractablesChildren,
		// Token: 0x0400354C RID: 13644
		[Token(Token = "0x400354C")]
		spawnedInteractablesAll,
		// Token: 0x0400354D RID: 13645
		[Token(Token = "0x400354D")]
		InteractablesOnNode
	}

	// Token: 0x02000751 RID: 1873
	[Token(Token = "0x2000751")]
	[Serializable]
	public class CheckActionAgainstState
	{
		// Token: 0x060028F4 RID: 10484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public CheckActionAgainstState()
		{
		}

		// Token: 0x0400354E RID: 13646
		[Token(Token = "0x400354E")]
		[FieldOffset(Offset = "0x10")]
		public InteractablePreset.Switch switchState;

		// Token: 0x0400354F RID: 13647
		[Token(Token = "0x400354F")]
		[FieldOffset(Offset = "0x14")]
		public bool switchIs;

		// Token: 0x04003550 RID: 13648
		[Token(Token = "0x4003550")]
		[FieldOffset(Offset = "0x18")]
		public AIActionPreset.CheckActionOutcome outcome;
	}

	// Token: 0x02000752 RID: 1874
	[Token(Token = "0x2000752")]
	public enum CheckActionOutcome
	{
		// Token: 0x04003552 RID: 13650
		[Token(Token = "0x4003552")]
		cancelAction,
		// Token: 0x04003553 RID: 13651
		[Token(Token = "0x4003553")]
		cancelGoal
	}

	// Token: 0x02000753 RID: 1875
	[Token(Token = "0x2000753")]
	public enum DoorRule
	{
		// Token: 0x04003555 RID: 13653
		[Token(Token = "0x4003555")]
		normal,
		// Token: 0x04003556 RID: 13654
		[Token(Token = "0x4003556")]
		dontLock,
		// Token: 0x04003557 RID: 13655
		[Token(Token = "0x4003557")]
		dontClose,
		// Token: 0x04003558 RID: 13656
		[Token(Token = "0x4003558")]
		onlyCloseToLocation,
		// Token: 0x04003559 RID: 13657
		[Token(Token = "0x4003559")]
		onlyLockToLocation
	}

	// Token: 0x02000754 RID: 1876
	[Token(Token = "0x2000754")]
	public enum LightRule
	{
		// Token: 0x0400355B RID: 13659
		[Token(Token = "0x400355B")]
		normal,
		// Token: 0x0400355C RID: 13660
		[Token(Token = "0x400355C")]
		dontSwitch,
		// Token: 0x0400355D RID: 13661
		[Token(Token = "0x400355D")]
		onlyWhenArrived
	}

	// Token: 0x02000755 RID: 1877
	[Token(Token = "0x2000755")]
	public enum ActionStateFlag
	{
		// Token: 0x0400355F RID: 13663
		[Token(Token = "0x400355F")]
		onActivation,
		// Token: 0x04003560 RID: 13664
		[Token(Token = "0x4003560")]
		onArrival,
		// Token: 0x04003561 RID: 13665
		[Token(Token = "0x4003561")]
		onDeactivation,
		// Token: 0x04003562 RID: 13666
		[Token(Token = "0x4003562")]
		onGoalDeactivation,
		// Token: 0x04003563 RID: 13667
		[Token(Token = "0x4003563")]
		none
	}
}
