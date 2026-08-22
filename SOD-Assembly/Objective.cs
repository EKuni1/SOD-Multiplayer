using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000291 RID: 657
[Token(Token = "0x2000291")]
[Serializable]
public class Objective
{
	// Token: 0x14000016 RID: 22
	// (add) Token: 0x06000F29 RID: 3881 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000F2A RID: 3882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000016")]
	public event Objective.ProgressChange OnProgressChange
	{
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x65E0B0", Offset = "0x65D0B0", VA = "0x18065E0B0")]
		add
		{
		}
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x65E1B0", Offset = "0x65D1B0", VA = "0x18065E1B0")]
		remove
		{
		}
	}

	// Token: 0x14000017 RID: 23
	// (add) Token: 0x06000F2B RID: 3883 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000F2C RID: 3884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000017")]
	public event Objective.Completed OnComplete
	{
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x65E2B0", Offset = "0x65D2B0", VA = "0x18065E2B0")]
		add
		{
		}
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x65E3B0", Offset = "0x65D3B0", VA = "0x18065E3B0")]
		remove
		{
		}
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F2D")]
	[Address(RVA = "0x65E4B0", Offset = "0x65D4B0", VA = "0x18065E4B0")]
	public Objective(SpeechController.QueueElement newQueueElement)
	{
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F2E")]
	[Address(RVA = "0x65EBE0", Offset = "0x65DBE0", VA = "0x18065EBE0")]
	public void Setup(Case newCase)
	{
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F2F")]
	[Address(RVA = "0x660000", Offset = "0x65F000", VA = "0x180660000")]
	public void Activate(bool immediate = false)
	{
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F30")]
	[Address(RVA = "0x6607E0", Offset = "0x65F7E0", VA = "0x1806607E0")]
	public void OnPlayerAction(AIActionPreset action, Interactable what, NewNode where, Actor who)
	{
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F31")]
	[Address(RVA = "0x660FC0", Offset = "0x65FFC0", VA = "0x180660FC0")]
	public void Complete()
	{
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F32")]
	[Address(RVA = "0x661FC0", Offset = "0x660FC0", VA = "0x180661FC0")]
	public void Cancel()
	{
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F33")]
	[Address(RVA = "0x6623D0", Offset = "0x6613D0", VA = "0x1806623D0")]
	public void Remove()
	{
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F34")]
	[Address(RVA = "0x662E70", Offset = "0x661E70", VA = "0x180662E70")]
	public void CheckingLoop()
	{
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F35")]
	[Address(RVA = "0x66AFF0", Offset = "0x669FF0", VA = "0x18066AFF0")]
	public void SetProgress(float newProgress)
	{
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x00007E18 File Offset: 0x00006018
	[Token(Token = "0x6000F36")]
	[Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020")]
	private bool <.ctor>b__36_0(Case item)
	{
		return default(bool);
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x00007E30 File Offset: 0x00006030
	[Token(Token = "0x6000F37")]
	[Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020")]
	private bool <.ctor>b__36_1(Case item)
	{
		return default(bool);
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x00007E48 File Offset: 0x00006048
	[Token(Token = "0x6000F38")]
	[Address(RVA = "0x66B050", Offset = "0x66A050", VA = "0x18066B050")]
	private bool <Setup>b__37_0(InterfaceControls.IconConfig item)
	{
		return default(bool);
	}

	// Token: 0x0400117D RID: 4477
	[Token(Token = "0x400117D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public SpeechController.QueueElement queueElement;

	// Token: 0x0400117E RID: 4478
	[Token(Token = "0x400117E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string name;

	// Token: 0x0400117F RID: 4479
	[Token(Token = "0x400117F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float progress;

	// Token: 0x04001180 RID: 4480
	[Token(Token = "0x4001180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool isComplete;

	// Token: 0x04001181 RID: 4481
	[Token(Token = "0x4001181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool isCancelled;

	// Token: 0x04001182 RID: 4482
	[Token(Token = "0x4001182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Objective.DisplayPhase dispPhase;

	// Token: 0x04001183 RID: 4483
	[Token(Token = "0x4001183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float fadeInProgress;

	// Token: 0x04001184 RID: 4484
	[Token(Token = "0x4001184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float displayProgress;

	// Token: 0x04001185 RID: 4485
	[Token(Token = "0x4001185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float displayTime;

	// Token: 0x04001186 RID: 4486
	[Token(Token = "0x4001186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float crouchPromtTimer;

	// Token: 0x04001187 RID: 4487
	[Token(Token = "0x4001187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[NonSerialized]
	public Case thisCase;

	// Token: 0x04001188 RID: 4488
	[Token(Token = "0x4001188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[NonSerialized]
	public GameObject objectiveListItem;

	// Token: 0x04001189 RID: 4489
	[Token(Token = "0x4001189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public RectTransform objectiveListRect;

	// Token: 0x0400118A RID: 4490
	[Token(Token = "0x400118A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[NonSerialized]
	public ChecklistButtonController objectiveList;

	// Token: 0x0400118B RID: 4491
	[Token(Token = "0x400118B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[NonSerialized]
	private bool displayPointer;

	// Token: 0x0400118C RID: 4492
	[Token(Token = "0x400118C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[NonSerialized]
	public RectTransform pointerUIObject;

	// Token: 0x0400118D RID: 4493
	[Token(Token = "0x400118D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[NonSerialized]
	public InterfaceController.AwarenessIcon awarenessIcon;

	// Token: 0x0400118E RID: 4494
	[Token(Token = "0x400118E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[NonSerialized]
	public UIPointerController pointer;

	// Token: 0x0400118F RID: 4495
	[Token(Token = "0x400118F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[NonSerialized]
	public Sprite sprite;

	// Token: 0x04001190 RID: 4496
	[Token(Token = "0x4001190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[NonSerialized]
	public bool isSetup;

	// Token: 0x04001191 RID: 4497
	[Token(Token = "0x4001191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[NonSerialized]
	public List<Objective.ObjectiveTrigger> appliedProgress;

	// Token: 0x04001192 RID: 4498
	[Token(Token = "0x4001192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[NonSerialized]
	public bool clearedForAnimation;

	// Token: 0x04001193 RID: 4499
	[Token(Token = "0x4001193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Objective.ObjectiveTrigger objectiveAddOn;

	// Token: 0x04001194 RID: 4500
	[Token(Token = "0x4001194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float progressAdd;

	// Token: 0x02000292 RID: 658
	[Token(Token = "0x2000292")]
	public enum DisplayPhase
	{
		// Token: 0x04001198 RID: 4504
		[Token(Token = "0x4001198")]
		preDisplay,
		// Token: 0x04001199 RID: 4505
		[Token(Token = "0x4001199")]
		fadeInMainText,
		// Token: 0x0400119A RID: 4506
		[Token(Token = "0x400119A")]
		displayMainText,
		// Token: 0x0400119B RID: 4507
		[Token(Token = "0x400119B")]
		removeText,
		// Token: 0x0400119C RID: 4508
		[Token(Token = "0x400119C")]
		displayingList,
		// Token: 0x0400119D RID: 4509
		[Token(Token = "0x400119D")]
		waitForComplete
	}

	// Token: 0x02000293 RID: 659
	[Token(Token = "0x2000293")]
	public enum OnCompleteAction
	{
		// Token: 0x0400119F RID: 4511
		[Token(Token = "0x400119F")]
		nextChapterPart,
		// Token: 0x040011A0 RID: 4512
		[Token(Token = "0x40011A0")]
		nextPartWhenAllCompleted,
		// Token: 0x040011A1 RID: 4513
		[Token(Token = "0x40011A1")]
		specificChapterByString,
		// Token: 0x040011A2 RID: 4514
		[Token(Token = "0x40011A2")]
		specificChapterWhenAllCompleted,
		// Token: 0x040011A3 RID: 4515
		[Token(Token = "0x40011A3")]
		nothing,
		// Token: 0x040011A4 RID: 4516
		[Token(Token = "0x40011A4")]
		invokeFunction,
		// Token: 0x040011A5 RID: 4517
		[Token(Token = "0x40011A5")]
		triggerSideJobFunction,
		// Token: 0x040011A6 RID: 4518
		[Token(Token = "0x40011A6")]
		triggerSideJobHandIn,
		// Token: 0x040011A7 RID: 4519
		[Token(Token = "0x40011A7")]
		nextSideJobPhase,
		// Token: 0x040011A8 RID: 4520
		[Token(Token = "0x40011A8")]
		submitSideJob,
		// Token: 0x040011A9 RID: 4521
		[Token(Token = "0x40011A9")]
		completeCoverUp,
		// Token: 0x040011AA RID: 4522
		[Token(Token = "0x40011AA")]
		coverUpTips,
		// Token: 0x040011AB RID: 4523
		[Token(Token = "0x40011AB")]
		triggerRansomDelivery,
		// Token: 0x040011AC RID: 4524
		[Token(Token = "0x40011AC")]
		triggerRansomCollection,
		// Token: 0x040011AD RID: 4525
		[Token(Token = "0x40011AD")]
		triggerKidnapperRansomCollection,
		// Token: 0x040011AE RID: 4526
		[Token(Token = "0x40011AE")]
		kidnapperCollectedRansom,
		// Token: 0x040011AF RID: 4527
		[Token(Token = "0x40011AF")]
		kidnapperVictimFreed
	}

	// Token: 0x02000294 RID: 660
	[Token(Token = "0x2000294")]
	[Serializable]
	public class ObjectiveTrigger
	{
		// Token: 0x06000F39 RID: 3897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F39")]
		[Address(RVA = "0x66B080", Offset = "0x66A080", VA = "0x18066B080")]
		public ObjectiveTrigger(Objective.ObjectiveTriggerType newType, string newName, bool newForceProgressAmount = false, float newProgressAdd = 0f, [Optional] NewRoom newRoom, [Optional] Interactable newInteractable, [Optional] Evidence newEvidence, [Optional] NewNode newNode, [Optional] NewDoor newDoor, [Optional] NewGameLocation newGameLocation, [Optional] SideJob newJob, string newHighlightAction = "", bool newOrTrigger = false, [Optional] Vector3 newPosition)
		{
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x66BA30", Offset = "0x66AA30", VA = "0x18066BA30")]
		public void SetupNonSerialized()
		{
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0x66C540", Offset = "0x66B540", VA = "0x18066C540")]
		public void Trigger(bool onSetup = false)
		{
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00007E60 File Offset: 0x00006060
		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0x66D0B0", Offset = "0x66C0B0", VA = "0x18066D0B0")]
		private bool <SetupNonSerialized>b__25_0(StreetController item)
		{
			return default(bool);
		}

		// Token: 0x040011B0 RID: 4528
		[Token(Token = "0x40011B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Objective.ObjectiveTriggerType triggerType;

		// Token: 0x040011B1 RID: 4529
		[Token(Token = "0x40011B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool forceProgressAmount;

		// Token: 0x040011B2 RID: 4530
		[Token(Token = "0x40011B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float progressAdd;

		// Token: 0x040011B3 RID: 4531
		[Token(Token = "0x40011B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool triggered;

		// Token: 0x040011B4 RID: 4532
		[Token(Token = "0x40011B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x040011B5 RID: 4533
		[Token(Token = "0x40011B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string hightlightAction;

		// Token: 0x040011B6 RID: 4534
		[Token(Token = "0x40011B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool orTrigger;

		// Token: 0x040011B7 RID: 4535
		[Token(Token = "0x40011B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int roomID;

		// Token: 0x040011B8 RID: 4536
		[Token(Token = "0x40011B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int interactableID;

		// Token: 0x040011B9 RID: 4537
		[Token(Token = "0x40011B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string evidenceID;

		// Token: 0x040011BA RID: 4538
		[Token(Token = "0x40011BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3Int nodeCoord;

		// Token: 0x040011BB RID: 4539
		[Token(Token = "0x40011BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int doorID;

		// Token: 0x040011BC RID: 4540
		[Token(Token = "0x40011BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int addressID;

		// Token: 0x040011BD RID: 4541
		[Token(Token = "0x40011BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int streetID;

		// Token: 0x040011BE RID: 4542
		[Token(Token = "0x40011BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int jobID;

		// Token: 0x040011BF RID: 4543
		[Token(Token = "0x40011BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 position;

		// Token: 0x040011C0 RID: 4544
		[Token(Token = "0x40011C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public NewRoom room;

		// Token: 0x040011C1 RID: 4545
		[Token(Token = "0x40011C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Interactable interactable;

		// Token: 0x040011C2 RID: 4546
		[Token(Token = "0x40011C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Evidence evidence;

		// Token: 0x040011C3 RID: 4547
		[Token(Token = "0x40011C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public NewNode node;

		// Token: 0x040011C4 RID: 4548
		[Token(Token = "0x40011C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public NewDoor door;

		// Token: 0x040011C5 RID: 4549
		[Token(Token = "0x40011C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public NewGameLocation gameLocation;

		// Token: 0x040011C6 RID: 4550
		[Token(Token = "0x40011C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public SideJob job;

		// Token: 0x040011C7 RID: 4551
		[Token(Token = "0x40011C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public List<Objective> addedToObjectives;

		// Token: 0x02000295 RID: 661
		[Token(Token = "0x2000295")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000F3E RID: 3902 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F3E")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c()
			{
			}

			// Token: 0x06000F3F RID: 3903 RVA: 0x00007E78 File Offset: 0x00006078
			[Token(Token = "0x6000F3F")]
			[Address(RVA = "0x66D180", Offset = "0x66C180", VA = "0x18066D180")]
			internal bool <Trigger>b__26_0(Objective.ObjectiveTrigger item)
			{
				return default(bool);
			}

			// Token: 0x040011C8 RID: 4552
			[Token(Token = "0x40011C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Objective.ObjectiveTrigger.<>c <>9;

			// Token: 0x040011C9 RID: 4553
			[Token(Token = "0x40011C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<Objective.ObjectiveTrigger> <>9__26_0;
		}
	}

	// Token: 0x02000296 RID: 662
	[Token(Token = "0x2000296")]
	public enum ObjectiveTriggerType
	{
		// Token: 0x040011CB RID: 4555
		[Token(Token = "0x40011CB")]
		playerAction,
		// Token: 0x040011CC RID: 4556
		[Token(Token = "0x40011CC")]
		switchStateTrue,
		// Token: 0x040011CD RID: 4557
		[Token(Token = "0x40011CD")]
		switchStateFalse,
		// Token: 0x040011CE RID: 4558
		[Token(Token = "0x40011CE")]
		roomLightOn,
		// Token: 0x040011CF RID: 4559
		[Token(Token = "0x40011CF")]
		inspectInteractable,
		// Token: 0x040011D0 RID: 4560
		[Token(Token = "0x40011D0")]
		evidencePinned,
		// Token: 0x040011D1 RID: 4561
		[Token(Token = "0x40011D1")]
		goToNode,
		// Token: 0x040011D2 RID: 4562
		[Token(Token = "0x40011D2")]
		keyInventory,
		// Token: 0x040011D3 RID: 4563
		[Token(Token = "0x40011D3")]
		knowDoorLockedStatus,
		// Token: 0x040011D4 RID: 4564
		[Token(Token = "0x40011D4")]
		goToAddress,
		// Token: 0x040011D5 RID: 4565
		[Token(Token = "0x40011D5")]
		goToRoom,
		// Token: 0x040011D6 RID: 4566
		[Token(Token = "0x40011D6")]
		playerHidden,
		// Token: 0x040011D7 RID: 4567
		[Token(Token = "0x40011D7")]
		escapeGameLocation,
		// Token: 0x040011D8 RID: 4568
		[Token(Token = "0x40011D8")]
		escapeBuilding,
		// Token: 0x040011D9 RID: 4569
		[Token(Token = "0x40011D9")]
		answerPhone,
		// Token: 0x040011DA RID: 4570
		[Token(Token = "0x40011DA")]
		openEvidence,
		// Token: 0x040011DB RID: 4571
		[Token(Token = "0x40011DB")]
		plotRoute,
		// Token: 0x040011DC RID: 4572
		[Token(Token = "0x40011DC")]
		gameUnpaused,
		// Token: 0x040011DD RID: 4573
		[Token(Token = "0x40011DD")]
		unlockDoor,
		// Token: 0x040011DE RID: 4574
		[Token(Token = "0x40011DE")]
		goToPublicFacingAddress,
		// Token: 0x040011DF RID: 4575
		[Token(Token = "0x40011DF")]
		answerPhoneAndEndCall,
		// Token: 0x040011E0 RID: 4576
		[Token(Token = "0x40011E0")]
		switchStateTrueForType,
		// Token: 0x040011E1 RID: 4577
		[Token(Token = "0x40011E1")]
		linkImageWithName,
		// Token: 0x040011E2 RID: 4578
		[Token(Token = "0x40011E2")]
		viewInteractable,
		// Token: 0x040011E3 RID: 4579
		[Token(Token = "0x40011E3")]
		noMoreObjectives,
		// Token: 0x040011E4 RID: 4580
		[Token(Token = "0x40011E4")]
		findFingerprints,
		// Token: 0x040011E5 RID: 4581
		[Token(Token = "0x40011E5")]
		findSurveillanceWith,
		// Token: 0x040011E6 RID: 4582
		[Token(Token = "0x40011E6")]
		findFingerprintsOnObject,
		// Token: 0x040011E7 RID: 4583
		[Token(Token = "0x40011E7")]
		accessCruncher,
		// Token: 0x040011E8 RID: 4584
		[Token(Token = "0x40011E8")]
		printVmail,
		// Token: 0x040011E9 RID: 4585
		[Token(Token = "0x40011E9")]
		successsfulSolve,
		// Token: 0x040011EA RID: 4586
		[Token(Token = "0x40011EA")]
		makeCall,
		// Token: 0x040011EB RID: 4587
		[Token(Token = "0x40011EB")]
		discoverParamour,
		// Token: 0x040011EC RID: 4588
		[Token(Token = "0x40011EC")]
		onCompleteJob,
		// Token: 0x040011ED RID: 4589
		[Token(Token = "0x40011ED")]
		identifyFinerprints,
		// Token: 0x040011EE RID: 4590
		[Token(Token = "0x40011EE")]
		interactableRemoved,
		// Token: 0x040011EF RID: 4591
		[Token(Token = "0x40011EF")]
		checkRecentCalls,
		// Token: 0x040011F0 RID: 4592
		[Token(Token = "0x40011F0")]
		acquireLockpicks,
		// Token: 0x040011F1 RID: 4593
		[Token(Token = "0x40011F1")]
		unlockInteractable,
		// Token: 0x040011F2 RID: 4594
		[Token(Token = "0x40011F2")]
		gamePaused,
		// Token: 0x040011F3 RID: 4595
		[Token(Token = "0x40011F3")]
		evidenceOpenAndDisplayed,
		// Token: 0x040011F4 RID: 4596
		[Token(Token = "0x40011F4")]
		collectHandIn,
		// Token: 0x040011F5 RID: 4597
		[Token(Token = "0x40011F5")]
		viewHandIn,
		// Token: 0x040011F6 RID: 4598
		[Token(Token = "0x40011F6")]
		submitCase,
		// Token: 0x040011F7 RID: 4599
		[Token(Token = "0x40011F7")]
		waitForCaseProcessing,
		// Token: 0x040011F8 RID: 4600
		[Token(Token = "0x40011F8")]
		surveillanceFlagFootage,
		// Token: 0x040011F9 RID: 4601
		[Token(Token = "0x40011F9")]
		findFingerprintsAtLocation,
		// Token: 0x040011FA RID: 4602
		[Token(Token = "0x40011FA")]
		plotRouteToCallInvolving,
		// Token: 0x040011FB RID: 4603
		[Token(Token = "0x40011FB")]
		notewriterWarned,
		// Token: 0x040011FC RID: 4604
		[Token(Token = "0x40011FC")]
		exploreCrimeScene,
		// Token: 0x040011FD RID: 4605
		[Token(Token = "0x40011FD")]
		nothing,
		// Token: 0x040011FE RID: 4606
		[Token(Token = "0x40011FE")]
		playerHasApartment,
		// Token: 0x040011FF RID: 4607
		[Token(Token = "0x40011FF")]
		answerLEMCall,
		// Token: 0x04001200 RID: 4608
		[Token(Token = "0x4001200")]
		discoverEvidence,
		// Token: 0x04001201 RID: 4609
		[Token(Token = "0x4001201")]
		accessApp,
		// Token: 0x04001202 RID: 4610
		[Token(Token = "0x4001202")]
		syncDiskInstallTutorial,
		// Token: 0x04001203 RID: 4611
		[Token(Token = "0x4001203")]
		onDialogSuccess,
		// Token: 0x04001204 RID: 4612
		[Token(Token = "0x4001204")]
		raiseFirstPersonItem,
		// Token: 0x04001205 RID: 4613
		[Token(Token = "0x4001205")]
		hasFPSInventory,
		// Token: 0x04001206 RID: 4614
		[Token(Token = "0x4001206")]
		sideMissionMeetTriggered,
		// Token: 0x04001207 RID: 4615
		[Token(Token = "0x4001207")]
		itemInInventory,
		// Token: 0x04001208 RID: 4616
		[Token(Token = "0x4001208")]
		itemIsPlacedAtSecretLocation,
		// Token: 0x04001209 RID: 4617
		[Token(Token = "0x4001209")]
		destroyItem,
		// Token: 0x0400120A RID: 4618
		[Token(Token = "0x400120A")]
		itemIsNear,
		// Token: 0x0400120B RID: 4619
		[Token(Token = "0x400120B")]
		playerActionNobodyHome,
		// Token: 0x0400120C RID: 4620
		[Token(Token = "0x400120C")]
		accessAnyCruncher,
		// Token: 0x0400120D RID: 4621
		[Token(Token = "0x400120D")]
		itemOfTypeIsNear,
		// Token: 0x0400120E RID: 4622
		[Token(Token = "0x400120E")]
		disposeOfBody,
		// Token: 0x0400120F RID: 4623
		[Token(Token = "0x400120F")]
		ifValidRansomBriefcase,
		// Token: 0x04001210 RID: 4624
		[Token(Token = "0x4001210")]
		ifNoValidRansomBriefcase,
		// Token: 0x04001211 RID: 4625
		[Token(Token = "0x4001211")]
		kidnapperHasValidBriefcase,
		// Token: 0x04001212 RID: 4626
		[Token(Token = "0x4001212")]
		victimIsFreed
	}

	// Token: 0x02000297 RID: 663
	// (Invoke) Token: 0x06000F41 RID: 3905
	[Token(Token = "0x2000297")]
	public delegate void ProgressChange();

	// Token: 0x02000298 RID: 664
	// (Invoke) Token: 0x06000F45 RID: 3909
	[Token(Token = "0x2000298")]
	public delegate void Completed();

	// Token: 0x02000299 RID: 665
	[Token(Token = "0x2000299")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000F49 RID: 3913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00007E90 File Offset: 0x00006090
		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0x66D250", Offset = "0x66C250", VA = "0x18066D250")]
		internal bool <Complete>b__40_0(SpeechController.QueueElement item)
		{
			return default(bool);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00007EA8 File Offset: 0x000060A8
		[Token(Token = "0x6000F4B")]
		[Address(RVA = "0x66D250", Offset = "0x66C250", VA = "0x18066D250")]
		internal bool <Complete>b__40_1(SpeechController.QueueElement item)
		{
			return default(bool);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00007EC0 File Offset: 0x000060C0
		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0x66D270", Offset = "0x66C270", VA = "0x18066D270")]
		internal bool <CheckingLoop>b__43_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00007ED8 File Offset: 0x000060D8
		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0x66D290", Offset = "0x66C290", VA = "0x18066D290")]
		internal bool <CheckingLoop>b__43_19(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04001213 RID: 4627
		[Token(Token = "0x4001213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Objective.<>c <>9;

		// Token: 0x04001214 RID: 4628
		[Token(Token = "0x4001214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<SpeechController.QueueElement> <>9__40_0;

		// Token: 0x04001215 RID: 4629
		[Token(Token = "0x4001215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<SpeechController.QueueElement> <>9__40_1;

		// Token: 0x04001216 RID: 4630
		[Token(Token = "0x4001216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<Interactable.Passed> <>9__43_0;

		// Token: 0x04001217 RID: 4631
		[Token(Token = "0x4001217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<Interactable> <>9__43_19;
	}

	// Token: 0x0200029A RID: 666
	[Token(Token = "0x200029A")]
	private sealed class <>c__DisplayClass43_0
	{
		// Token: 0x06000F4E RID: 3918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass43_0()
		{
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00007EF0 File Offset: 0x000060F0
		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0x66D2D0", Offset = "0x66C2D0", VA = "0x18066D2D0")]
		internal bool <CheckingLoop>b__1(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00007F08 File Offset: 0x00006108
		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x66D310", Offset = "0x66C310", VA = "0x18066D310")]
		internal bool <CheckingLoop>b__7(Case.CaseElement item)
		{
			return default(bool);
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00007F20 File Offset: 0x00006120
		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x66D380", Offset = "0x66C380", VA = "0x18066D380")]
		internal bool <CheckingLoop>b__2(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00007F38 File Offset: 0x00006138
		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x66D310", Offset = "0x66C310", VA = "0x18066D310")]
		internal bool <CheckingLoop>b__8(Case.CaseElement item)
		{
			return default(bool);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00007F50 File Offset: 0x00006150
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x66D380", Offset = "0x66C380", VA = "0x18066D380")]
		internal bool <CheckingLoop>b__9(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00007F68 File Offset: 0x00006168
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x66D380", Offset = "0x66C380", VA = "0x18066D380")]
		internal bool <CheckingLoop>b__3(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00007F80 File Offset: 0x00006180
		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x66D380", Offset = "0x66C380", VA = "0x18066D380")]
		internal bool <CheckingLoop>b__4(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00007F98 File Offset: 0x00006198
		[Token(Token = "0x6000F56")]
		[Address(RVA = "0x66D310", Offset = "0x66C310", VA = "0x18066D310")]
		internal bool <CheckingLoop>b__10(Case.CaseElement item)
		{
			return default(bool);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00007FB0 File Offset: 0x000061B0
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x66D380", Offset = "0x66C380", VA = "0x18066D380")]
		internal bool <CheckingLoop>b__11(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00007FC8 File Offset: 0x000061C8
		[Token(Token = "0x6000F58")]
		[Address(RVA = "0x66D400", Offset = "0x66C400", VA = "0x18066D400")]
		internal bool <CheckingLoop>b__5(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00007FE0 File Offset: 0x000061E0
		[Token(Token = "0x6000F59")]
		[Address(RVA = "0x66D430", Offset = "0x66C430", VA = "0x18066D430")]
		internal bool <CheckingLoop>b__16(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00007FF8 File Offset: 0x000061F8
		[Token(Token = "0x6000F5A")]
		[Address(RVA = "0x66D570", Offset = "0x66C570", VA = "0x18066D570")]
		internal bool <CheckingLoop>b__6(TelephoneController.PhoneCall item)
		{
			return default(bool);
		}

		// Token: 0x04001218 RID: 4632
		[Token(Token = "0x4001218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Objective.ObjectiveTrigger trig;

		// Token: 0x04001219 RID: 4633
		[Token(Token = "0x4001219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<Case.CaseElement> <>9__7;

		// Token: 0x0400121A RID: 4634
		[Token(Token = "0x400121A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<Case.CaseElement> <>9__8;

		// Token: 0x0400121B RID: 4635
		[Token(Token = "0x400121B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Predicate<InfoWindow> <>9__9;

		// Token: 0x0400121C RID: 4636
		[Token(Token = "0x400121C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Predicate<Case.CaseElement> <>9__10;

		// Token: 0x0400121D RID: 4637
		[Token(Token = "0x400121D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Predicate<InfoWindow> <>9__11;
	}

	// Token: 0x0200029B RID: 667
	[Token(Token = "0x200029B")]
	private sealed class <>c__DisplayClass43_1
	{
		// Token: 0x06000F5B RID: 3931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass43_1()
		{
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00008010 File Offset: 0x00006210
		[Token(Token = "0x6000F5C")]
		[Address(RVA = "0x66DC60", Offset = "0x66CC60", VA = "0x18066DC60")]
		internal bool <CheckingLoop>b__12(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x0400121E RID: 4638
		[Token(Token = "0x400121E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human h;
	}

	// Token: 0x0200029C RID: 668
	[Token(Token = "0x200029C")]
	private sealed class <>c__DisplayClass43_2
	{
		// Token: 0x06000F5D RID: 3933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass43_2()
		{
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00008028 File Offset: 0x00006228
		[Token(Token = "0x6000F5E")]
		[Address(RVA = "0x66DE70", Offset = "0x66CE70", VA = "0x18066DE70")]
		internal bool <CheckingLoop>b__13(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x0400121F RID: 4639
		[Token(Token = "0x400121F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human h;
	}

	// Token: 0x0200029D RID: 669
	[Token(Token = "0x200029D")]
	private sealed class <>c__DisplayClass43_3
	{
		// Token: 0x06000F5F RID: 3935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass43_3()
		{
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00008040 File Offset: 0x00006240
		[Token(Token = "0x6000F60")]
		[Address(RVA = "0x66E080", Offset = "0x66D080", VA = "0x18066E080")]
		internal bool <CheckingLoop>b__14(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x04001220 RID: 4640
		[Token(Token = "0x4001220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human h;
	}

	// Token: 0x0200029E RID: 670
	[Token(Token = "0x200029E")]
	private sealed class <>c__DisplayClass43_4
	{
		// Token: 0x06000F61 RID: 3937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F61")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass43_4()
		{
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00008058 File Offset: 0x00006258
		[Token(Token = "0x6000F62")]
		[Address(RVA = "0x66E290", Offset = "0x66D290", VA = "0x18066E290")]
		internal bool <CheckingLoop>b__15(SceneRecorder.ActorCapture item)
		{
			return default(bool);
		}

		// Token: 0x04001221 RID: 4641
		[Token(Token = "0x4001221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human h;

		// Token: 0x04001222 RID: 4642
		[Token(Token = "0x4001222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<SceneRecorder.ActorCapture> <>9__15;
	}

	// Token: 0x0200029F RID: 671
	[Token(Token = "0x200029F")]
	private sealed class <>c__DisplayClass43_5
	{
		// Token: 0x06000F63 RID: 3939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass43_5()
		{
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00008070 File Offset: 0x00006270
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x66E2C0", Offset = "0x66D2C0", VA = "0x18066E2C0")]
		internal bool <CheckingLoop>b__17(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04001223 RID: 4643
		[Token(Token = "0x4001223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MurderController.Murder currentM;

		// Token: 0x04001224 RID: 4644
		[Token(Token = "0x4001224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<Interactable> <>9__17;
	}

	// Token: 0x020002A0 RID: 672
	[Token(Token = "0x20002A0")]
	private sealed class <>c__DisplayClass43_6
	{
		// Token: 0x06000F65 RID: 3941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F65")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass43_6()
		{
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00008088 File Offset: 0x00006288
		[Token(Token = "0x6000F66")]
		[Address(RVA = "0x66E5A0", Offset = "0x66D5A0", VA = "0x18066E5A0")]
		internal bool <CheckingLoop>b__18(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04001225 RID: 4645
		[Token(Token = "0x4001225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MurderController.Murder currentM;

		// Token: 0x04001226 RID: 4646
		[Token(Token = "0x4001226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<Interactable> <>9__18;
	}
}
