using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200084A RID: 2122
[Token(Token = "0x200084A")]
public class MurderPreset : SoCustomComparison
{
	// Token: 0x060029C5 RID: 10693 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029C5")]
	[Address(RVA = "0xCAE540", Offset = "0xCAD540", VA = "0x180CAE540")]
	public void CopyLeads()
	{
	}

	// Token: 0x060029C6 RID: 10694 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029C6")]
	[Address(RVA = "0xCAE640", Offset = "0xCAD640", VA = "0x180CAE640")]
	public MurderPreset()
	{
	}

	// Token: 0x04003FF4 RID: 16372
	[Token(Token = "0x4003FF4")]
	[FieldOffset(Offset = "0x20")]
	public MurderPreset.CaseType caseType;

	// Token: 0x04003FF5 RID: 16373
	[Token(Token = "0x4003FF5")]
	[FieldOffset(Offset = "0x24")]
	public bool disabled;

	// Token: 0x04003FF6 RID: 16374
	[Token(Token = "0x4003FF6")]
	[FieldOffset(Offset = "0x28")]
	public int frequency;

	// Token: 0x04003FF7 RID: 16375
	[Token(Token = "0x4003FF7")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 murdererRandomScoreRange;

	// Token: 0x04003FF8 RID: 16376
	[Token(Token = "0x4003FF8")]
	[FieldOffset(Offset = "0x38")]
	public List<MurderPreset.MurdererModifierRule> murdererTraitModifiers;

	// Token: 0x04003FF9 RID: 16377
	[Token(Token = "0x4003FF9")]
	[FieldOffset(Offset = "0x40")]
	public bool useHexaco;

	// Token: 0x04003FFA RID: 16378
	[Token(Token = "0x4003FFA")]
	[FieldOffset(Offset = "0x48")]
	public HEXACO hexaco;

	// Token: 0x04003FFB RID: 16379
	[Token(Token = "0x4003FFB")]
	[FieldOffset(Offset = "0x50")]
	public bool pickDen;

	// Token: 0x04003FFC RID: 16380
	[Token(Token = "0x4003FFC")]
	[FieldOffset(Offset = "0x54")]
	public float kidnapperTimeUntilKill;

	// Token: 0x04003FFD RID: 16381
	[Token(Token = "0x4003FFD")]
	[FieldOffset(Offset = "0x58")]
	public float minimumTimeBetweenMurders;

	// Token: 0x04003FFE RID: 16382
	[Token(Token = "0x4003FFE")]
	[FieldOffset(Offset = "0x5C")]
	public int nonHomeMaximumOccupantsTrigger;

	// Token: 0x04003FFF RID: 16383
	[Token(Token = "0x4003FFF")]
	[FieldOffset(Offset = "0x60")]
	public int nonHomeMaximumOccupantsCancel;

	// Token: 0x04004000 RID: 16384
	[Token(Token = "0x4004000")]
	[FieldOffset(Offset = "0x64")]
	public bool requiresAcquirePhase;

	// Token: 0x04004001 RID: 16385
	[Token(Token = "0x4004001")]
	[FieldOffset(Offset = "0x65")]
	public bool acquirePassInteractable;

	// Token: 0x04004002 RID: 16386
	[Token(Token = "0x4004002")]
	[FieldOffset(Offset = "0x66")]
	public bool acquirePassRoom;

	// Token: 0x04004003 RID: 16387
	[Token(Token = "0x4004003")]
	[FieldOffset(Offset = "0x68")]
	public List<AIGoalPreset.GoalActionSetup> acquireActionSetup;

	// Token: 0x04004004 RID: 16388
	[Token(Token = "0x4004004")]
	[FieldOffset(Offset = "0x70")]
	public bool requiresResearchPhase;

	// Token: 0x04004005 RID: 16389
	[Token(Token = "0x4004005")]
	[FieldOffset(Offset = "0x71")]
	public bool killerMeetsVicim;

	// Token: 0x04004006 RID: 16390
	[Token(Token = "0x4004006")]
	[FieldOffset(Offset = "0x72")]
	public bool researchPassInteractable;

	// Token: 0x04004007 RID: 16391
	[Token(Token = "0x4004007")]
	[FieldOffset(Offset = "0x73")]
	public bool researchPassRoom;

	// Token: 0x04004008 RID: 16392
	[Token(Token = "0x4004008")]
	[FieldOffset(Offset = "0x78")]
	public List<AIGoalPreset.GoalActionSetup> researchActionSetup;

	// Token: 0x04004009 RID: 16393
	[Token(Token = "0x4004009")]
	[FieldOffset(Offset = "0x80")]
	public bool blockVictimFromLeavingLocation;

	// Token: 0x0400400A RID: 16394
	[Token(Token = "0x400400A")]
	[FieldOffset(Offset = "0x84")]
	public MurderPreset.SuccessfulTravelTrigger travelSuccessTrigger;

	// Token: 0x0400400B RID: 16395
	[Token(Token = "0x400400B")]
	[FieldOffset(Offset = "0x88")]
	public bool travelPassInteractable;

	// Token: 0x0400400C RID: 16396
	[Token(Token = "0x400400C")]
	[FieldOffset(Offset = "0x89")]
	public bool travelPassRoom;

	// Token: 0x0400400D RID: 16397
	[Token(Token = "0x400400D")]
	[FieldOffset(Offset = "0x90")]
	public List<AIGoalPreset.GoalActionSetup> travelActionSetup;

	// Token: 0x0400400E RID: 16398
	[Token(Token = "0x400400E")]
	[FieldOffset(Offset = "0x98")]
	public bool executePassInteractable;

	// Token: 0x0400400F RID: 16399
	[Token(Token = "0x400400F")]
	[FieldOffset(Offset = "0x99")]
	public bool executePassRoom;

	// Token: 0x04004010 RID: 16400
	[Token(Token = "0x4004010")]
	[FieldOffset(Offset = "0xA0")]
	public List<AIGoalPreset.GoalActionSetup> executionActionSetup;

	// Token: 0x04004011 RID: 16401
	[Token(Token = "0x4004011")]
	[FieldOffset(Offset = "0xA8")]
	public bool postPassInteractable;

	// Token: 0x04004012 RID: 16402
	[Token(Token = "0x4004012")]
	[FieldOffset(Offset = "0xA9")]
	public bool postPassRoom;

	// Token: 0x04004013 RID: 16403
	[Token(Token = "0x4004013")]
	[FieldOffset(Offset = "0xB0")]
	public List<AIGoalPreset.GoalActionSetup> postActionSetup;

	// Token: 0x04004014 RID: 16404
	[Token(Token = "0x4004014")]
	[FieldOffset(Offset = "0xB8")]
	public bool escapePassInteractable;

	// Token: 0x04004015 RID: 16405
	[Token(Token = "0x4004015")]
	[FieldOffset(Offset = "0xB9")]
	public bool escapePassRoom;

	// Token: 0x04004016 RID: 16406
	[Token(Token = "0x4004016")]
	[FieldOffset(Offset = "0xC0")]
	public List<AIGoalPreset.GoalActionSetup> escapeActionSetup;

	// Token: 0x04004017 RID: 16407
	[Token(Token = "0x4004017")]
	[FieldOffset(Offset = "0xC8")]
	public List<MurderPreset.MurderLeadItem> leads;

	// Token: 0x04004018 RID: 16408
	[Token(Token = "0x4004018")]
	[FieldOffset(Offset = "0xD0")]
	public bool useCustomResolveQuestions;

	// Token: 0x04004019 RID: 16409
	[Token(Token = "0x4004019")]
	[FieldOffset(Offset = "0xD8")]
	public List<Case.ResolveQuestion> customResolveQuestions;

	// Token: 0x0400401A RID: 16410
	[Token(Token = "0x400401A")]
	[FieldOffset(Offset = "0xE0")]
	public MurderPreset copyFrom;

	// Token: 0x0200084B RID: 2123
	[Token(Token = "0x200084B")]
	public enum CaseType
	{
		// Token: 0x0400401C RID: 16412
		[Token(Token = "0x400401C")]
		murder,
		// Token: 0x0400401D RID: 16413
		[Token(Token = "0x400401D")]
		sniper,
		// Token: 0x0400401E RID: 16414
		[Token(Token = "0x400401E")]
		kidnap
	}

	// Token: 0x0200084C RID: 2124
	[Token(Token = "0x200084C")]
	[Serializable]
	public class MurdererModifierRule
	{
		// Token: 0x060029C7 RID: 10695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C7")]
		[Address(RVA = "0xCAEBD0", Offset = "0xCADBD0", VA = "0x180CAEBD0")]
		public MurdererModifierRule()
		{
		}

		// Token: 0x0400401F RID: 16415
		[Token(Token = "0x400401F")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait.RuleType rule;

		// Token: 0x04004020 RID: 16416
		[Token(Token = "0x4004020")]
		[FieldOffset(Offset = "0x18")]
		public List<CharacterTrait> traitList;

		// Token: 0x04004021 RID: 16417
		[Token(Token = "0x4004021")]
		[FieldOffset(Offset = "0x20")]
		public bool mustPassForApplication;

		// Token: 0x04004022 RID: 16418
		[Token(Token = "0x4004022")]
		[FieldOffset(Offset = "0x24")]
		public float scoreModifier;
	}

	// Token: 0x0200084D RID: 2125
	[Token(Token = "0x200084D")]
	public enum SuccessfulTravelTrigger
	{
		// Token: 0x04004024 RID: 16420
		[Token(Token = "0x4004024")]
		whenMurdererIsAtTheSameLocation,
		// Token: 0x04004025 RID: 16421
		[Token(Token = "0x4004025")]
		whenMurdererIsAtVantagePoint
	}

	// Token: 0x0200084E RID: 2126
	[Token(Token = "0x200084E")]
	public enum LeadCitizen
	{
		// Token: 0x04004027 RID: 16423
		[Token(Token = "0x4004027")]
		nobody,
		// Token: 0x04004028 RID: 16424
		[Token(Token = "0x4004028")]
		victim,
		// Token: 0x04004029 RID: 16425
		[Token(Token = "0x4004029")]
		killer,
		// Token: 0x0400402A RID: 16426
		[Token(Token = "0x400402A")]
		victimsClosest,
		// Token: 0x0400402B RID: 16427
		[Token(Token = "0x400402B")]
		killersClosest,
		// Token: 0x0400402C RID: 16428
		[Token(Token = "0x400402C")]
		victimsDoctor,
		// Token: 0x0400402D RID: 16429
		[Token(Token = "0x400402D")]
		killersDoctor,
		// Token: 0x0400402E RID: 16430
		[Token(Token = "0x400402E")]
		ransom,
		// Token: 0x0400402F RID: 16431
		[Token(Token = "0x400402F")]
		victimsLandlord,
		// Token: 0x04004030 RID: 16432
		[Token(Token = "0x4004030")]
		KillersLandlord
	}

	// Token: 0x0200084F RID: 2127
	[Token(Token = "0x200084F")]
	public enum LeadSpawnWhere
	{
		// Token: 0x04004032 RID: 16434
		[Token(Token = "0x4004032")]
		victimHome,
		// Token: 0x04004033 RID: 16435
		[Token(Token = "0x4004033")]
		victimWork,
		// Token: 0x04004034 RID: 16436
		[Token(Token = "0x4004034")]
		killerHome,
		// Token: 0x04004035 RID: 16437
		[Token(Token = "0x4004035")]
		killerWork,
		// Token: 0x04004036 RID: 16438
		[Token(Token = "0x4004036")]
		ransom,
		// Token: 0x04004037 RID: 16439
		[Token(Token = "0x4004037")]
		killerDen
	}

	// Token: 0x02000850 RID: 2128
	[Token(Token = "0x2000850")]
	[Serializable]
	public class MurderModifierRule
	{
		// Token: 0x060029C8 RID: 10696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C8")]
		[Address(RVA = "0xCAECA0", Offset = "0xCADCA0", VA = "0x180CAECA0")]
		public MurderModifierRule()
		{
		}

		// Token: 0x04004038 RID: 16440
		[Token(Token = "0x4004038")]
		[FieldOffset(Offset = "0x10")]
		public MurderPreset.LeadCitizen who;

		// Token: 0x04004039 RID: 16441
		[Token(Token = "0x4004039")]
		[FieldOffset(Offset = "0x14")]
		public CharacterTrait.RuleType rule;

		// Token: 0x0400403A RID: 16442
		[Token(Token = "0x400403A")]
		[FieldOffset(Offset = "0x18")]
		public List<CharacterTrait> traitList;

		// Token: 0x0400403B RID: 16443
		[Token(Token = "0x400403B")]
		[FieldOffset(Offset = "0x20")]
		public bool mustPassForApplication;

		// Token: 0x0400403C RID: 16444
		[Token(Token = "0x400403C")]
		[FieldOffset(Offset = "0x24")]
		public float chanceModifier;
	}

	// Token: 0x02000851 RID: 2129
	[Token(Token = "0x2000851")]
	[Serializable]
	public class MurderLeadItem
	{
		// Token: 0x060029C9 RID: 10697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C9")]
		[Address(RVA = "0xCAED70", Offset = "0xCADD70", VA = "0x180CAED70")]
		public MurderLeadItem()
		{
		}

		// Token: 0x0400403D RID: 16445
		[Token(Token = "0x400403D")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400403E RID: 16446
		[Token(Token = "0x400403E")]
		[FieldOffset(Offset = "0x18")]
		public bool compatibleWithAllMotives;

		// Token: 0x0400403F RID: 16447
		[Token(Token = "0x400403F")]
		[FieldOffset(Offset = "0x20")]
		public List<MurderMO> compatibleWithMotives;

		// Token: 0x04004040 RID: 16448
		[Token(Token = "0x4004040")]
		[FieldOffset(Offset = "0x28")]
		public MurderController.MurderState spawnOnPhase;

		// Token: 0x04004041 RID: 16449
		[Token(Token = "0x4004041")]
		[FieldOffset(Offset = "0x2C")]
		public bool tryToSpawnWithEachNewMurder;

		// Token: 0x04004042 RID: 16450
		[Token(Token = "0x4004042")]
		[FieldOffset(Offset = "0x30")]
		public MurderPreset.LeadCitizen belongsTo;

		// Token: 0x04004043 RID: 16451
		[Token(Token = "0x4004043")]
		[FieldOffset(Offset = "0x34")]
		public float chance;

		// Token: 0x04004044 RID: 16452
		[Token(Token = "0x4004044")]
		[FieldOffset(Offset = "0x38")]
		public bool useTraits;

		// Token: 0x04004045 RID: 16453
		[Token(Token = "0x4004045")]
		[FieldOffset(Offset = "0x40")]
		public List<MurderPreset.MurderModifierRule> traitModifiers;

		// Token: 0x04004046 RID: 16454
		[Token(Token = "0x4004046")]
		[FieldOffset(Offset = "0x48")]
		public bool useIf;

		// Token: 0x04004047 RID: 16455
		[Token(Token = "0x4004047")]
		[FieldOffset(Offset = "0x4C")]
		public JobPreset.JobTag ifTag;

		// Token: 0x04004048 RID: 16456
		[Token(Token = "0x4004048")]
		[FieldOffset(Offset = "0x50")]
		public bool useOrGroup;

		// Token: 0x04004049 RID: 16457
		[Token(Token = "0x4004049")]
		[FieldOffset(Offset = "0x54")]
		public JobPreset.JobTag orGroup;

		// Token: 0x0400404A RID: 16458
		[Token(Token = "0x400404A")]
		[FieldOffset(Offset = "0x58")]
		public int chanceRatio;

		// Token: 0x0400404B RID: 16459
		[Token(Token = "0x400404B")]
		[FieldOffset(Offset = "0x5C")]
		public JobPreset.JobTag itemTag;

		// Token: 0x0400404C RID: 16460
		[Token(Token = "0x400404C")]
		[FieldOffset(Offset = "0x60")]
		public InteractablePreset spawnItem;

		// Token: 0x0400404D RID: 16461
		[Token(Token = "0x400404D")]
		[FieldOffset(Offset = "0x68")]
		public string vmailThread;

		// Token: 0x0400404E RID: 16462
		[Token(Token = "0x400404E")]
		[FieldOffset(Offset = "0x70")]
		public Vector2 vmailProgressThreshold;

		// Token: 0x0400404F RID: 16463
		[Token(Token = "0x400404F")]
		[FieldOffset(Offset = "0x78")]
		public MurderPreset.LeadCitizen writer;

		// Token: 0x04004050 RID: 16464
		[Token(Token = "0x4004050")]
		[FieldOffset(Offset = "0x7C")]
		public MurderPreset.LeadCitizen receiver;

		// Token: 0x04004051 RID: 16465
		[Token(Token = "0x4004051")]
		[FieldOffset(Offset = "0x80")]
		public List<MurderPreset.LeadCitizen> vmailOtherParticipants;

		// Token: 0x04004052 RID: 16466
		[Token(Token = "0x4004052")]
		[FieldOffset(Offset = "0x88")]
		public MurderPreset.LeadSpawnWhere where;

		// Token: 0x04004053 RID: 16467
		[Token(Token = "0x4004053")]
		[FieldOffset(Offset = "0x8C")]
		public int security;

		// Token: 0x04004054 RID: 16468
		[Token(Token = "0x4004054")]
		[FieldOffset(Offset = "0x90")]
		public int priority;

		// Token: 0x04004055 RID: 16469
		[Token(Token = "0x4004055")]
		[FieldOffset(Offset = "0x94")]
		public InteractablePreset.OwnedPlacementRule ownershipRule;
	}
}
