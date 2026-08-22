using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200049E RID: 1182
[Token(Token = "0x200049E")]
public class SpeechController : MonoBehaviour
{
	// Token: 0x06001AC6 RID: 6854 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC6")]
	[Address(RVA = "0x995DA0", Offset = "0x994DA0", VA = "0x180995DA0", Slot = "4")]
	public virtual void TriggerBark(SpeechController.Bark newBark)
	{
	}

	// Token: 0x06001AC7 RID: 6855 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC7")]
	[Address(RVA = "0x996EA0", Offset = "0x995EA0", VA = "0x180996EA0", Slot = "5")]
	public virtual void Speak(ref List<AIActionPreset.AISpeechPreset> speechOptions, [Optional] Human speakAbout, [Optional] SideJob sideJob, [Optional] DialogPreset dialogPreset, [Optional] Interactable saysTo, [Optional] Human.InteractionDialogInstance interactionInstance)
	{
	}

	// Token: 0x06001AC8 RID: 6856 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC8")]
	[Address(RVA = "0x998870", Offset = "0x997870", VA = "0x180998870", Slot = "6")]
	public virtual void Speak(string ddsMessage, bool shout = false, bool interupt = false, [Optional] Human speakAbout, [Optional] SideJob sideJob, [Optional] Human.InteractionDialogInstance interactionInstance)
	{
	}

	// Token: 0x06001AC9 RID: 6857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC9")]
	[Address(RVA = "0x998D70", Offset = "0x997D70", VA = "0x180998D70", Slot = "7")]
	public virtual void Speak(string dictionary, string speechEntryRef, bool useParsing = false, bool shout = false, bool interupt = false, float delay = 0f, bool forceColour = false, [Optional] Color color, [Optional] Human speakingAbout, bool endsDialog = false, bool jobHandIn = false, [Optional] SideJob sideJob, [Optional] DialogPreset dialogPreset, [Optional] AIActionPreset.AISpeechPreset dialog, [Optional] Interactable speakingTo, [Optional] Human.InteractionDialogInstance interactionInstance)
	{
	}

	// Token: 0x06001ACA RID: 6858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ACA")]
	[Address(RVA = "0x9992F0", Offset = "0x9982F0", VA = "0x1809992F0")]
	private void Update()
	{
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ACB")]
	[Address(RVA = "0x99A950", Offset = "0x999950", VA = "0x18099A950")]
	public void SetSpeechActive(bool val)
	{
	}

	// Token: 0x06001ACC RID: 6860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ACC")]
	[Address(RVA = "0x99AA40", Offset = "0x999A40", VA = "0x18099AA40")]
	private void OnEnable()
	{
	}

	// Token: 0x06001ACD RID: 6861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ACD")]
	[Address(RVA = "0x99AAD0", Offset = "0x999AD0", VA = "0x18099AAD0")]
	public SpeechController()
	{
	}

	// Token: 0x0400208D RID: 8333
	[Token(Token = "0x400208D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Actor actor;

	// Token: 0x0400208E RID: 8334
	[Token(Token = "0x400208E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public Interactable interactable;

	// Token: 0x0400208F RID: 8335
	[Token(Token = "0x400208F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Telephone phoneLine;

	// Token: 0x04002090 RID: 8336
	[Token(Token = "0x4002090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SpeechBubbleController activeSpeechBubble;

	// Token: 0x04002091 RID: 8337
	[Token(Token = "0x4002091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool endAfterThisSpeech;

	// Token: 0x04002092 RID: 8338
	[Token(Token = "0x4002092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float lastSpeech;

	// Token: 0x04002093 RID: 8339
	[Token(Token = "0x4002093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<SpeechController.QueueElement> speechQueue;

	// Token: 0x04002094 RID: 8340
	[Token(Token = "0x4002094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float speechDelay;

	// Token: 0x04002095 RID: 8341
	[Token(Token = "0x4002095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool speechActive;

	// Token: 0x0200049F RID: 1183
	[Token(Token = "0x200049F")]
	[Serializable]
	public class QueueElement
	{
		// Token: 0x06001ACE RID: 6862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACE")]
		[Address(RVA = "0x99ABD0", Offset = "0x999BD0", VA = "0x18099ABD0")]
		public QueueElement(string newDictRef, string newEntryRef, bool newUseParsing, float newDelay, bool newIsShouting, bool newInterupt, bool newForceColour = false, [Optional] Color newColor, [Optional] Human newSpeakingAbout, bool newEndsDialog = false, bool newJobHandIn = false, [Optional] SideJob newJobRef, [Optional] DialogPreset newDialogPreset, [Optional] AIActionPreset.AISpeechPreset newDialog, [Optional] Interactable newSpeakingTo, [Optional] Human.InteractionDialogInstance newInteraction)
		{
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACF")]
		[Address(RVA = "0x99AF50", Offset = "0x999F50", VA = "0x18099AF50")]
		public QueueElement(int newCaseID, string newName, bool newUseUIPointer, Vector3 newUseUIPosition, InterfaceControls.Icon newIcon, List<Objective.ObjectiveTrigger> newTriggers, Objective.OnCompleteAction newOnCompleteAction, float newDelay = 0f, bool newRemoveObjectives = false, string newChapterString = "", bool newIsSilent = false, bool newAllowCrouchPromt = false, [Optional] SideJob newJobRef, bool newForceBottom = false, bool newUseParsing = true)
		{
		}

		// Token: 0x04002096 RID: 8342
		[Token(Token = "0x4002096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string dictRef;

		// Token: 0x04002097 RID: 8343
		[Token(Token = "0x4002097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string entryRef;

		// Token: 0x04002098 RID: 8344
		[Token(Token = "0x4002098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useParsing;

		// Token: 0x04002099 RID: 8345
		[Token(Token = "0x4002099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float delay;

		// Token: 0x0400209A RID: 8346
		[Token(Token = "0x400209A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool delayActivated;

		// Token: 0x0400209B RID: 8347
		[Token(Token = "0x400209B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool shouting;

		// Token: 0x0400209C RID: 8348
		[Token(Token = "0x400209C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool interupt;

		// Token: 0x0400209D RID: 8349
		[Token(Token = "0x400209D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool forceColour;

		// Token: 0x0400209E RID: 8350
		[Token(Token = "0x400209E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color color;

		// Token: 0x0400209F RID: 8351
		[Token(Token = "0x400209F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int speakingAbout;

		// Token: 0x040020A0 RID: 8352
		[Token(Token = "0x40020A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int jobRef;

		// Token: 0x040020A1 RID: 8353
		[Token(Token = "0x40020A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool endsDialog;

		// Token: 0x040020A2 RID: 8354
		[Token(Token = "0x40020A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		public bool jobHandIn;

		// Token: 0x040020A3 RID: 8355
		[Token(Token = "0x40020A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int speakingToRef;

		// Token: 0x040020A4 RID: 8356
		[Token(Token = "0x40020A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string interactionDialogRef;

		// Token: 0x040020A5 RID: 8357
		[Token(Token = "0x40020A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AIActionPreset.AISpeechPreset dialog;

		// Token: 0x040020A6 RID: 8358
		[Token(Token = "0x40020A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string dialogPreset;

		// Token: 0x040020A7 RID: 8359
		[Token(Token = "0x40020A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool isObjective;

		// Token: 0x040020A8 RID: 8360
		[Token(Token = "0x40020A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool usePointer;

		// Token: 0x040020A9 RID: 8361
		[Token(Token = "0x40020A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 pointerPosition;

		// Token: 0x040020AA RID: 8362
		[Token(Token = "0x40020AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<Objective.ObjectiveTrigger> triggers;

		// Token: 0x040020AB RID: 8363
		[Token(Token = "0x40020AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Objective.OnCompleteAction onComplete;

		// Token: 0x040020AC RID: 8364
		[Token(Token = "0x40020AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool removePreviousObjectives;

		// Token: 0x040020AD RID: 8365
		[Token(Token = "0x40020AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string chapterString;

		// Token: 0x040020AE RID: 8366
		[Token(Token = "0x40020AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool isSilent;

		// Token: 0x040020AF RID: 8367
		[Token(Token = "0x40020AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool allowCrouchPrompt;

		// Token: 0x040020B0 RID: 8368
		[Token(Token = "0x40020B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public InterfaceControls.Icon icon;

		// Token: 0x040020B1 RID: 8369
		[Token(Token = "0x40020B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int caseID;

		// Token: 0x040020B2 RID: 8370
		[Token(Token = "0x40020B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool forceBottom;
	}

	// Token: 0x020004A0 RID: 1184
	[Token(Token = "0x20004A0")]
	public enum Bark
	{
		// Token: 0x040020B4 RID: 8372
		[Token(Token = "0x40020B4")]
		persuit,
		// Token: 0x040020B5 RID: 8373
		[Token(Token = "0x40020B5")]
		lostTarget,
		// Token: 0x040020B6 RID: 8374
		[Token(Token = "0x40020B6")]
		answeringDoor,
		// Token: 0x040020B7 RID: 8375
		[Token(Token = "0x40020B7")]
		answerDoor,
		// Token: 0x040020B8 RID: 8376
		[Token(Token = "0x40020B8")]
		giveUpSearch,
		// Token: 0x040020B9 RID: 8377
		[Token(Token = "0x40020B9")]
		hearsSuspicious,
		// Token: 0x040020BA RID: 8378
		[Token(Token = "0x40020BA")]
		seesSuspicious,
		// Token: 0x040020BB RID: 8379
		[Token(Token = "0x40020BB")]
		enforcerRadio,
		// Token: 0x040020BC RID: 8380
		[Token(Token = "0x40020BC")]
		idleSounds,
		// Token: 0x040020BD RID: 8381
		[Token(Token = "0x40020BD")]
		discoverTamper,
		// Token: 0x040020BE RID: 8382
		[Token(Token = "0x40020BE")]
		fallOffChair,
		// Token: 0x040020BF RID: 8383
		[Token(Token = "0x40020BF")]
		sleeping,
		// Token: 0x040020C0 RID: 8384
		[Token(Token = "0x40020C0")]
		yawn,
		// Token: 0x040020C1 RID: 8385
		[Token(Token = "0x40020C1")]
		hearsObject,
		// Token: 0x040020C2 RID: 8386
		[Token(Token = "0x40020C2")]
		stench,
		// Token: 0x040020C3 RID: 8387
		[Token(Token = "0x40020C3")]
		seeBody,
		// Token: 0x040020C4 RID: 8388
		[Token(Token = "0x40020C4")]
		examineBody,
		// Token: 0x040020C5 RID: 8389
		[Token(Token = "0x40020C5")]
		mourn,
		// Token: 0x040020C6 RID: 8390
		[Token(Token = "0x40020C6")]
		enforcersKnock,
		// Token: 0x040020C7 RID: 8391
		[Token(Token = "0x40020C7")]
		scared,
		// Token: 0x040020C8 RID: 8392
		[Token(Token = "0x40020C8")]
		cower,
		// Token: 0x040020C9 RID: 8393
		[Token(Token = "0x40020C9")]
		attack,
		// Token: 0x040020CA RID: 8394
		[Token(Token = "0x40020CA")]
		confrontMessingAround,
		// Token: 0x040020CB RID: 8395
		[Token(Token = "0x40020CB")]
		pickUpMisplaced,
		// Token: 0x040020CC RID: 8396
		[Token(Token = "0x40020CC")]
		takeDamage,
		// Token: 0x040020CD RID: 8397
		[Token(Token = "0x40020CD")]
		frustration,
		// Token: 0x040020CE RID: 8398
		[Token(Token = "0x40020CE")]
		outOfBreath,
		// Token: 0x040020CF RID: 8399
		[Token(Token = "0x40020CF")]
		cold,
		// Token: 0x040020D0 RID: 8400
		[Token(Token = "0x40020D0")]
		drunkIdle,
		// Token: 0x040020D1 RID: 8401
		[Token(Token = "0x40020D1")]
		targetDown,
		// Token: 0x040020D2 RID: 8402
		[Token(Token = "0x40020D2")]
		restrained,
		// Token: 0x040020D3 RID: 8403
		[Token(Token = "0x40020D3")]
		restrainedIdle,
		// Token: 0x040020D4 RID: 8404
		[Token(Token = "0x40020D4")]
		dazed,
		// Token: 0x040020D5 RID: 8405
		[Token(Token = "0x40020D5")]
		trespass,
		// Token: 0x040020D6 RID: 8406
		[Token(Token = "0x40020D6")]
		threatenByItem,
		// Token: 0x040020D7 RID: 8407
		[Token(Token = "0x40020D7")]
		threatenByCombat,
		// Token: 0x040020D8 RID: 8408
		[Token(Token = "0x40020D8")]
		soundAlarm,
		// Token: 0x040020D9 RID: 8409
		[Token(Token = "0x40020D9")]
		doorBlocked,
		// Token: 0x040020DA RID: 8410
		[Token(Token = "0x40020DA")]
		spooked,
		// Token: 0x040020DB RID: 8411
		[Token(Token = "0x40020DB")]
		exposedConfront,
		// Token: 0x040020DC RID: 8412
		[Token(Token = "0x40020DC")]
		spookConfront,
		// Token: 0x040020DD RID: 8413
		[Token(Token = "0x40020DD")]
		loiteringConfront,
		// Token: 0x040020DE RID: 8414
		[Token(Token = "0x40020DE")]
		trespassClosed,
		// Token: 0x040020DF RID: 8415
		[Token(Token = "0x40020DF")]
		trespassLoiter,
		// Token: 0x040020E0 RID: 8416
		[Token(Token = "0x40020E0")]
		fameAndFortune,
		// Token: 0x040020E1 RID: 8417
		[Token(Token = "0x40020E1")]
		rat
	}

	// Token: 0x020004A1 RID: 1185
	[Token(Token = "0x20004A1")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x06001AD0 RID: 6864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x0000C738 File Offset: 0x0000A938
		[Token(Token = "0x6001AD1")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <Speak>b__0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040020E2 RID: 8418
		[Token(Token = "0x40020E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait t;
	}

	// Token: 0x020004A2 RID: 1186
	[Token(Token = "0x20004A2")]
	private sealed class <>c__DisplayClass12_1
	{
		// Token: 0x06001AD2 RID: 6866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass12_1()
		{
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0000C750 File Offset: 0x0000A950
		[Token(Token = "0x6001AD3")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <Speak>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040020E3 RID: 8419
		[Token(Token = "0x40020E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait t;
	}

	// Token: 0x020004A3 RID: 1187
	[Token(Token = "0x20004A3")]
	private sealed class <>c__DisplayClass15_0
	{
		// Token: 0x06001AD4 RID: 6868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass15_0()
		{
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0000C768 File Offset: 0x0000A968
		[Token(Token = "0x6001AD5")]
		[Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020")]
		internal bool <Update>b__0(Case item)
		{
			return default(bool);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0000C780 File Offset: 0x0000A980
		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020")]
		internal bool <Update>b__1(Case item)
		{
			return default(bool);
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0000C798 File Offset: 0x0000A998
		[Token(Token = "0x6001AD7")]
		[Address(RVA = "0x99B120", Offset = "0x99A120", VA = "0x18099B120")]
		internal bool <Update>b__2(Objective item)
		{
			return default(bool);
		}

		// Token: 0x040020E4 RID: 8420
		[Token(Token = "0x40020E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpeechController.QueueElement sp;
	}
}
