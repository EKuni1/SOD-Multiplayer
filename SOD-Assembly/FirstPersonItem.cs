using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007E1 RID: 2017
[Token(Token = "0x20007E1")]
public class FirstPersonItem : SoCustomComparison
{
	// Token: 0x06002970 RID: 10608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002970")]
	[Address(RVA = "0xCA5F80", Offset = "0xCA4F80", VA = "0x180CA5F80")]
	public FirstPersonItem()
	{
	}

	// Token: 0x04003A5A RID: 14938
	[Token(Token = "0x4003A5A")]
	[FieldOffset(Offset = "0x20")]
	public int slotPriority;

	// Token: 0x04003A5B RID: 14939
	[Token(Token = "0x4003A5B")]
	[FieldOffset(Offset = "0x24")]
	public bool modelActive;

	// Token: 0x04003A5C RID: 14940
	[Token(Token = "0x4003A5C")]
	[FieldOffset(Offset = "0x28")]
	public AnimationClip idleClip;

	// Token: 0x04003A5D RID: 14941
	[Token(Token = "0x4003A5D")]
	[FieldOffset(Offset = "0x30")]
	public Sprite selectionIcon;

	// Token: 0x04003A5E RID: 14942
	[Token(Token = "0x4003A5E")]
	[FieldOffset(Offset = "0x38")]
	public string summaryMsgID;

	// Token: 0x04003A5F RID: 14943
	[Token(Token = "0x4003A5F")]
	[FieldOffset(Offset = "0x40")]
	public string triggerTutorial;

	// Token: 0x04003A60 RID: 14944
	[Token(Token = "0x4003A60")]
	[FieldOffset(Offset = "0x48")]
	public bool disableBracketDisplayName;

	// Token: 0x04003A61 RID: 14945
	[Token(Token = "0x4003A61")]
	[FieldOffset(Offset = "0x4C")]
	public float drawSpeed;

	// Token: 0x04003A62 RID: 14946
	[Token(Token = "0x4003A62")]
	[FieldOffset(Offset = "0x50")]
	public float holsterSpeed;

	// Token: 0x04003A63 RID: 14947
	[Token(Token = "0x4003A63")]
	[FieldOffset(Offset = "0x58")]
	public GameObject leftHandObject;

	// Token: 0x04003A64 RID: 14948
	[Token(Token = "0x4003A64")]
	[FieldOffset(Offset = "0x60")]
	public GameObject rightHandObject;

	// Token: 0x04003A65 RID: 14949
	[Token(Token = "0x4003A65")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 spawnScale;

	// Token: 0x04003A66 RID: 14950
	[Token(Token = "0x4003A66")]
	[FieldOffset(Offset = "0x74")]
	public bool useFoodSlotItem;

	// Token: 0x04003A67 RID: 14951
	[Token(Token = "0x4003A67")]
	[FieldOffset(Offset = "0x75")]
	public bool useAlternateTrashObjects;

	// Token: 0x04003A68 RID: 14952
	[Token(Token = "0x4003A68")]
	[FieldOffset(Offset = "0x78")]
	public GameObject leftHandObjectTrash;

	// Token: 0x04003A69 RID: 14953
	[Token(Token = "0x4003A69")]
	[FieldOffset(Offset = "0x80")]
	public GameObject rightHandObjectTrash;

	// Token: 0x04003A6A RID: 14954
	[Token(Token = "0x4003A6A")]
	[FieldOffset(Offset = "0x88")]
	public List<FirstPersonItem.FPSInteractionAction> actions;

	// Token: 0x04003A6B RID: 14955
	[Token(Token = "0x4003A6B")]
	[FieldOffset(Offset = "0x90")]
	public float drawnNerveModifier;

	// Token: 0x04003A6C RID: 14956
	[Token(Token = "0x4003A6C")]
	[FieldOffset(Offset = "0x94")]
	public float barkTriggerChance;

	// Token: 0x04003A6D RID: 14957
	[Token(Token = "0x4003A6D")]
	[FieldOffset(Offset = "0x98")]
	public SpeechController.Bark bark;

	// Token: 0x04003A6E RID: 14958
	[Token(Token = "0x4003A6E")]
	[FieldOffset(Offset = "0x9C")]
	public bool compatibleWithLockedIn;

	// Token: 0x04003A6F RID: 14959
	[Token(Token = "0x4003A6F")]
	[FieldOffset(Offset = "0x9D")]
	public bool compatibleWithHidden;

	// Token: 0x04003A70 RID: 14960
	[Token(Token = "0x4003A70")]
	[FieldOffset(Offset = "0xA0")]
	public float equipSoundDelay;

	// Token: 0x04003A71 RID: 14961
	[Token(Token = "0x4003A71")]
	[FieldOffset(Offset = "0xA8")]
	public AudioEvent equipEvent;

	// Token: 0x04003A72 RID: 14962
	[Token(Token = "0x4003A72")]
	[FieldOffset(Offset = "0xB0")]
	public float holsterSoundDelay;

	// Token: 0x04003A73 RID: 14963
	[Token(Token = "0x4003A73")]
	[FieldOffset(Offset = "0xB8")]
	public AudioEvent holsterEvent;

	// Token: 0x04003A74 RID: 14964
	[Token(Token = "0x4003A74")]
	[FieldOffset(Offset = "0xC0")]
	public AudioEvent activeLoop;

	// Token: 0x04003A75 RID: 14965
	[Token(Token = "0x4003A75")]
	[FieldOffset(Offset = "0xC8")]
	public bool passRainParamsToActiveLoop;

	// Token: 0x020007E2 RID: 2018
	[Token(Token = "0x20007E2")]
	public enum SpecialAction
	{
		// Token: 0x04003A77 RID: 14967
		[Token(Token = "0x4003A77")]
		none,
		// Token: 0x04003A78 RID: 14968
		[Token(Token = "0x4003A78")]
		block,
		// Token: 0x04003A79 RID: 14969
		[Token(Token = "0x4003A79")]
		handcuff,
		// Token: 0x04003A7A RID: 14970
		[Token(Token = "0x4003A7A")]
		takedown,
		// Token: 0x04003A7B RID: 14971
		[Token(Token = "0x4003A7B")]
		punch,
		// Token: 0x04003A7C RID: 14972
		[Token(Token = "0x4003A7C")]
		consumeTrue,
		// Token: 0x04003A7D RID: 14973
		[Token(Token = "0x4003A7D")]
		consumeFalse,
		// Token: 0x04003A7E RID: 14974
		[Token(Token = "0x4003A7E")]
		putDown,
		// Token: 0x04003A7F RID: 14975
		[Token(Token = "0x4003A7F")]
		attack,
		// Token: 0x04003A80 RID: 14976
		[Token(Token = "0x4003A80")]
		raiseTrue,
		// Token: 0x04003A81 RID: 14977
		[Token(Token = "0x4003A81")]
		raiseFalse,
		// Token: 0x04003A82 RID: 14978
		[Token(Token = "0x4003A82")]
		takePicture,
		// Token: 0x04003A83 RID: 14979
		[Token(Token = "0x4003A83")]
		placeCodebreaker,
		// Token: 0x04003A84 RID: 14980
		[Token(Token = "0x4003A84")]
		placeDoorWedge,
		// Token: 0x04003A85 RID: 14981
		[Token(Token = "0x4003A85")]
		takeOne,
		// Token: 0x04003A86 RID: 14982
		[Token(Token = "0x4003A86")]
		placeFurniture,
		// Token: 0x04003A87 RID: 14983
		[Token(Token = "0x4003A87")]
		cancelFurniture,
		// Token: 0x04003A88 RID: 14984
		[Token(Token = "0x4003A88")]
		give,
		// Token: 0x04003A89 RID: 14985
		[Token(Token = "0x4003A89")]
		placeTracker,
		// Token: 0x04003A8A RID: 14986
		[Token(Token = "0x4003A8A")]
		placeFlashbomb,
		// Token: 0x04003A8B RID: 14987
		[Token(Token = "0x4003A8B")]
		placeIncapacitator,
		// Token: 0x04003A8C RID: 14988
		[Token(Token = "0x4003A8C")]
		takeBriefcaseCash,
		// Token: 0x04003A8D RID: 14989
		[Token(Token = "0x4003A8D")]
		openBriefcaseBomb,
		// Token: 0x04003A8E RID: 14990
		[Token(Token = "0x4003A8E")]
		rotateFurnLeft,
		// Token: 0x04003A8F RID: 14991
		[Token(Token = "0x4003A8F")]
		rotateFurnRight,
		// Token: 0x04003A90 RID: 14992
		[Token(Token = "0x4003A90")]
		putBriefcaseCash,
		// Token: 0x04003A91 RID: 14993
		[Token(Token = "0x4003A91")]
		camFlashOn,
		// Token: 0x04003A92 RID: 14994
		[Token(Token = "0x4003A92")]
		camFlashOff,
		// Token: 0x04003A93 RID: 14995
		[Token(Token = "0x4003A93")]
		smoke
	}

	// Token: 0x020007E3 RID: 2019
	[Token(Token = "0x20007E3")]
	[Serializable]
	public class FPSInteractionAction : InteractablePreset.InteractionAction
	{
		// Token: 0x06002971 RID: 10609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002971")]
		[Address(RVA = "0xCA60B0", Offset = "0xCA50B0", VA = "0x180CA60B0")]
		public FPSInteractionAction()
		{
		}

		// Token: 0x04003A94 RID: 14996
		[Token(Token = "0x4003A94")]
		[FieldOffset(Offset = "0x68")]
		public FirstPersonItem.AttackAvailability availability;

		// Token: 0x04003A95 RID: 14997
		[Token(Token = "0x4003A95")]
		[FieldOffset(Offset = "0x6C")]
		public bool steamVersionOnly;

		// Token: 0x04003A96 RID: 14998
		[Token(Token = "0x4003A96")]
		[FieldOffset(Offset = "0x70")]
		public float attackMainSpeed;

		// Token: 0x04003A97 RID: 14999
		[Token(Token = "0x4003A97")]
		[FieldOffset(Offset = "0x78")]
		public PlayerTransitionPreset attackTrasition;

		// Token: 0x04003A98 RID: 15000
		[Token(Token = "0x4003A98")]
		[FieldOffset(Offset = "0x80")]
		public float attackDelay;

		// Token: 0x04003A99 RID: 15001
		[Token(Token = "0x4003A99")]
		[FieldOffset(Offset = "0x84")]
		public FirstPersonItem.SpecialAction mainSpecialAction;

		// Token: 0x04003A9A RID: 15002
		[Token(Token = "0x4003A9A")]
		[FieldOffset(Offset = "0x88")]
		public bool mainUseSpecialColour;

		// Token: 0x04003A9B RID: 15003
		[Token(Token = "0x4003A9B")]
		[FieldOffset(Offset = "0x8C")]
		public Color mainSpecialColour;

		// Token: 0x04003A9C RID: 15004
		[Token(Token = "0x4003A9C")]
		[FieldOffset(Offset = "0xA0")]
		public AudioEvent attackEvent;

		// Token: 0x04003A9D RID: 15005
		[Token(Token = "0x4003A9D")]
		[FieldOffset(Offset = "0xA8")]
		public bool useCameraJolt;

		// Token: 0x04003A9E RID: 15006
		[Token(Token = "0x4003A9E")]
		[FieldOffset(Offset = "0xAC")]
		public Vector2 joltXRange;

		// Token: 0x04003A9F RID: 15007
		[Token(Token = "0x4003A9F")]
		[FieldOffset(Offset = "0xB4")]
		public Vector2 joltYRange;

		// Token: 0x04003AA0 RID: 15008
		[Token(Token = "0x4003AA0")]
		[FieldOffset(Offset = "0xBC")]
		public Vector2 joltZRange;

		// Token: 0x04003AA1 RID: 15009
		[Token(Token = "0x4003AA1")]
		[FieldOffset(Offset = "0xC4")]
		public float joltAmplitude;

		// Token: 0x04003AA2 RID: 15010
		[Token(Token = "0x4003AA2")]
		[FieldOffset(Offset = "0xC8")]
		public float joltSpeed;
	}

	// Token: 0x020007E4 RID: 2020
	[Token(Token = "0x20007E4")]
	public enum AttackAvailability
	{
		// Token: 0x04003AA4 RID: 15012
		[Token(Token = "0x4003AA4")]
		never,
		// Token: 0x04003AA5 RID: 15013
		[Token(Token = "0x4003AA5")]
		always,
		// Token: 0x04003AA6 RID: 15014
		[Token(Token = "0x4003AA6")]
		handcuffs,
		// Token: 0x04003AA7 RID: 15015
		[Token(Token = "0x4003AA7")]
		behindCitizen,
		// Token: 0x04003AA8 RID: 15016
		[Token(Token = "0x4003AA8")]
		onConsuming,
		// Token: 0x04003AA9 RID: 15017
		[Token(Token = "0x4003AA9")]
		onNotConsuming,
		// Token: 0x04003AAA RID: 15018
		[Token(Token = "0x4003AAA")]
		onNotConsumingButLeftovers,
		// Token: 0x04003AAB RID: 15019
		[Token(Token = "0x4003AAB")]
		nearPutDown,
		// Token: 0x04003AAC RID: 15020
		[Token(Token = "0x4003AAC")]
		onRaised,
		// Token: 0x04003AAD RID: 15021
		[Token(Token = "0x4003AAD")]
		onNotRaised,
		// Token: 0x04003AAE RID: 15022
		[Token(Token = "0x4003AAE")]
		codebreaker,
		// Token: 0x04003AAF RID: 15023
		[Token(Token = "0x4003AAF")]
		doorWedge,
		// Token: 0x04003AB0 RID: 15024
		[Token(Token = "0x4003AB0")]
		giveItem,
		// Token: 0x04003AB1 RID: 15025
		[Token(Token = "0x4003AB1")]
		tracker,
		// Token: 0x04003AB2 RID: 15026
		[Token(Token = "0x4003AB2")]
		onRaisedButLeftovers,
		// Token: 0x04003AB3 RID: 15027
		[Token(Token = "0x4003AB3")]
		onRaisedNotFull,
		// Token: 0x04003AB4 RID: 15028
		[Token(Token = "0x4003AB4")]
		whenCamFlashOn,
		// Token: 0x04003AB5 RID: 15029
		[Token(Token = "0x4003AB5")]
		whenCamFlashOff
	}
}
