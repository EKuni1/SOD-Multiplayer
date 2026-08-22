using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000756 RID: 1878
[Token(Token = "0x2000756")]
public class AIGoalPreset : SoCustomComparison
{
	// Token: 0x060028F5 RID: 10485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028F5")]
	[Address(RVA = "0xC668A0", Offset = "0xC658A0", VA = "0x180C668A0")]
	public AIGoalPreset()
	{
	}

	// Token: 0x04003564 RID: 13668
	[Token(Token = "0x4003564")]
	[FieldOffset(Offset = "0x20")]
	public bool startingGoal;

	// Token: 0x04003565 RID: 13669
	[Token(Token = "0x4003565")]
	[FieldOffset(Offset = "0x24")]
	public AIGoalPreset.StartingGoal appliesTo;

	// Token: 0x04003566 RID: 13670
	[Token(Token = "0x4003566")]
	[FieldOffset(Offset = "0x28")]
	public List<OccupationPreset> appliedToTheseJobs;

	// Token: 0x04003567 RID: 13671
	[Token(Token = "0x4003567")]
	[FieldOffset(Offset = "0x30")]
	public List<InteractablePreset> onlyIfFeaturesItemsAtHome;

	// Token: 0x04003568 RID: 13672
	[Token(Token = "0x4003568")]
	[FieldOffset(Offset = "0x38")]
	public bool disableSave;

	// Token: 0x04003569 RID: 13673
	[Token(Token = "0x4003569")]
	[FieldOffset(Offset = "0x3C")]
	public AIGoalPreset.GoalCategory category;

	// Token: 0x0400356A RID: 13674
	[Token(Token = "0x400356A")]
	[FieldOffset(Offset = "0x40")]
	public int basePriority;

	// Token: 0x0400356B RID: 13675
	[Token(Token = "0x400356B")]
	[FieldOffset(Offset = "0x44")]
	public int randomVariance;

	// Token: 0x0400356C RID: 13676
	[Token(Token = "0x400356C")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 minMaxPriority;

	// Token: 0x0400356D RID: 13677
	[Token(Token = "0x400356D")]
	[FieldOffset(Offset = "0x50")]
	public bool multiplyUsingTrashCarried;

	// Token: 0x0400356E RID: 13678
	[Token(Token = "0x400356E")]
	[FieldOffset(Offset = "0x51")]
	public bool useLateDebtPriority;

	// Token: 0x0400356F RID: 13679
	[Token(Token = "0x400356F")]
	[FieldOffset(Offset = "0x52")]
	public bool onlyImportantBetweenHours;

	// Token: 0x04003570 RID: 13680
	[Token(Token = "0x4003570")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 validBetweenHours;

	// Token: 0x04003571 RID: 13681
	[Token(Token = "0x4003571")]
	[FieldOffset(Offset = "0x5C")]
	public bool dontUpdateGoalPriorityWhileActive;

	// Token: 0x04003572 RID: 13682
	[Token(Token = "0x4003572")]
	[FieldOffset(Offset = "0x5D")]
	public bool forcePriorityUpdateOnCreation;

	// Token: 0x04003573 RID: 13683
	[Token(Token = "0x4003573")]
	[FieldOffset(Offset = "0x60")]
	public AIGoalPreset.RainFactor rainFactor;

	// Token: 0x04003574 RID: 13684
	[Token(Token = "0x4003574")]
	[FieldOffset(Offset = "0x64")]
	public bool useMusic;

	// Token: 0x04003575 RID: 13685
	[Token(Token = "0x4003575")]
	[FieldOffset(Offset = "0x65")]
	public bool useTrespassing;

	// Token: 0x04003576 RID: 13686
	[Token(Token = "0x4003576")]
	[FieldOffset(Offset = "0x66")]
	public bool affectPriorityOverTime;

	// Token: 0x04003577 RID: 13687
	[Token(Token = "0x4003577")]
	[FieldOffset(Offset = "0x68")]
	public float multiplierModifierOverOneHour;

	// Token: 0x04003578 RID: 13688
	[Token(Token = "0x4003578")]
	[FieldOffset(Offset = "0x6C")]
	public bool sniperVictimBoost;

	// Token: 0x04003579 RID: 13689
	[Token(Token = "0x4003579")]
	[FieldOffset(Offset = "0x70")]
	public List<AIGoalPreset.GoalModifierRule> goalModifiers;

	// Token: 0x0400357A RID: 13690
	[Token(Token = "0x400357A")]
	[FieldOffset(Offset = "0x78")]
	public List<AIGoalPreset> ifGoalsPresent;

	// Token: 0x0400357B RID: 13691
	[Token(Token = "0x400357B")]
	[FieldOffset(Offset = "0x80")]
	public float otherGoalPriorityModifier;

	// Token: 0x0400357C RID: 13692
	[Token(Token = "0x400357C")]
	[FieldOffset(Offset = "0x84")]
	public bool useTiming;

	// Token: 0x0400357D RID: 13693
	[Token(Token = "0x400357D")]
	[FieldOffset(Offset = "0x88")]
	public int timingImportance;

	// Token: 0x0400357E RID: 13694
	[Token(Token = "0x400357E")]
	[FieldOffset(Offset = "0x8C")]
	public float earlyTimingWindow;

	// Token: 0x0400357F RID: 13695
	[Token(Token = "0x400357F")]
	[FieldOffset(Offset = "0x90")]
	public bool cancelIfLate;

	// Token: 0x04003580 RID: 13696
	[Token(Token = "0x4003580")]
	[FieldOffset(Offset = "0x94")]
	public float cancelIfThisLate;

	// Token: 0x04003581 RID: 13697
	[Token(Token = "0x4003581")]
	[FieldOffset(Offset = "0x98")]
	public bool cancelAfterTime;

	// Token: 0x04003582 RID: 13698
	[Token(Token = "0x4003582")]
	[FieldOffset(Offset = "0x9C")]
	public float cancelAfter;

	// Token: 0x04003583 RID: 13699
	[Token(Token = "0x4003583")]
	[FieldOffset(Offset = "0xA0")]
	public bool runIfLate;

	// Token: 0x04003584 RID: 13700
	[Token(Token = "0x4003584")]
	[FieldOffset(Offset = "0xA4")]
	public int nourishmentImportance;

	// Token: 0x04003585 RID: 13701
	[Token(Token = "0x4003585")]
	[FieldOffset(Offset = "0xA8")]
	public int hydrationImportance;

	// Token: 0x04003586 RID: 13702
	[Token(Token = "0x4003586")]
	[FieldOffset(Offset = "0xAC")]
	public int alertnessImportance;

	// Token: 0x04003587 RID: 13703
	[Token(Token = "0x4003587")]
	[FieldOffset(Offset = "0xB0")]
	public int energyImportance;

	// Token: 0x04003588 RID: 13704
	[Token(Token = "0x4003588")]
	[FieldOffset(Offset = "0xB4")]
	public int excitementImportance;

	// Token: 0x04003589 RID: 13705
	[Token(Token = "0x4003589")]
	[FieldOffset(Offset = "0xB8")]
	public int choresImportance;

	// Token: 0x0400358A RID: 13706
	[Token(Token = "0x400358A")]
	[FieldOffset(Offset = "0xBC")]
	public int hygieneImportance;

	// Token: 0x0400358B RID: 13707
	[Token(Token = "0x400358B")]
	[FieldOffset(Offset = "0xC0")]
	public int bladderImportance;

	// Token: 0x0400358C RID: 13708
	[Token(Token = "0x400358C")]
	[FieldOffset(Offset = "0xC4")]
	public int heatImportance;

	// Token: 0x0400358D RID: 13709
	[Token(Token = "0x400358D")]
	[FieldOffset(Offset = "0xC8")]
	public int drunkImportance;

	// Token: 0x0400358E RID: 13710
	[Token(Token = "0x400358E")]
	[FieldOffset(Offset = "0xCC")]
	public int breathImportance;

	// Token: 0x0400358F RID: 13711
	[Token(Token = "0x400358F")]
	[FieldOffset(Offset = "0xD0")]
	public int poisonImportance;

	// Token: 0x04003590 RID: 13712
	[Token(Token = "0x4003590")]
	[FieldOffset(Offset = "0xD4")]
	public int blindedImportance;

	// Token: 0x04003591 RID: 13713
	[Token(Token = "0x4003591")]
	[FieldOffset(Offset = "0xD8")]
	public bool completable;

	// Token: 0x04003592 RID: 13714
	[Token(Token = "0x4003592")]
	[FieldOffset(Offset = "0xD9")]
	public bool loopingActions;

	// Token: 0x04003593 RID: 13715
	[Token(Token = "0x4003593")]
	[FieldOffset(Offset = "0xDA")]
	public bool interuptable;

	// Token: 0x04003594 RID: 13716
	[Token(Token = "0x4003594")]
	[FieldOffset(Offset = "0xDB")]
	public bool unteruptableByFollowingCategories;

	// Token: 0x04003595 RID: 13717
	[Token(Token = "0x4003595")]
	[FieldOffset(Offset = "0xE0")]
	public List<AIGoalPreset.GoalCategory> uninteruptableByCategories;

	// Token: 0x04003596 RID: 13718
	[Token(Token = "0x4003596")]
	[FieldOffset(Offset = "0xE8")]
	public bool useInteruptionThreshold;

	// Token: 0x04003597 RID: 13719
	[Token(Token = "0x4003597")]
	[FieldOffset(Offset = "0xEC")]
	public float interuptionThreshold;

	// Token: 0x04003598 RID: 13720
	[Token(Token = "0x4003598")]
	[FieldOffset(Offset = "0xF0")]
	public float repeatDelayOnBusy;

	// Token: 0x04003599 RID: 13721
	[Token(Token = "0x4003599")]
	[FieldOffset(Offset = "0xF4")]
	public float repeatDelayOnInterupt;

	// Token: 0x0400359A RID: 13722
	[Token(Token = "0x400359A")]
	[FieldOffset(Offset = "0xF8")]
	public float repeatDelayOnFinishActions;

	// Token: 0x0400359B RID: 13723
	[Token(Token = "0x400359B")]
	[FieldOffset(Offset = "0xFC")]
	public bool allowEnforcersEverywhere;

	// Token: 0x0400359C RID: 13724
	[Token(Token = "0x400359C")]
	[FieldOffset(Offset = "0x100")]
	public AIGoalPreset.LocationOption locationOption;

	// Token: 0x0400359D RID: 13725
	[Token(Token = "0x400359D")]
	[FieldOffset(Offset = "0x104")]
	public bool useToiletSettings;

	// Token: 0x0400359E RID: 13726
	[Token(Token = "0x400359E")]
	[FieldOffset(Offset = "0x108")]
	public CompanyPreset.CompanyCategory desireCategory;

	// Token: 0x0400359F RID: 13727
	[Token(Token = "0x400359F")]
	[FieldOffset(Offset = "0x10C")]
	public AIGoalPreset.RoomOption roomOption;

	// Token: 0x040035A0 RID: 13728
	[Token(Token = "0x40035A0")]
	[FieldOffset(Offset = "0x110")]
	public AIGoalPreset.FurnitureOption furnitureOption;

	// Token: 0x040035A1 RID: 13729
	[Token(Token = "0x40035A1")]
	[FieldOffset(Offset = "0x114")]
	public bool actionFoundRoomBecomesPassedRoom;

	// Token: 0x040035A2 RID: 13730
	[Token(Token = "0x40035A2")]
	[FieldOffset(Offset = "0x115")]
	public bool passedGamelocationIsImportant;

	// Token: 0x040035A3 RID: 13731
	[Token(Token = "0x40035A3")]
	[FieldOffset(Offset = "0x118")]
	public AIGoalPreset.GoalActionSource actionSource;

	// Token: 0x040035A4 RID: 13732
	[Token(Token = "0x40035A4")]
	[FieldOffset(Offset = "0x120")]
	public List<AIGoalPreset.GoalActionSetup> actionsSetup;

	// Token: 0x040035A5 RID: 13733
	[Token(Token = "0x40035A5")]
	[FieldOffset(Offset = "0x128")]
	public bool raiseAlarm;

	// Token: 0x040035A6 RID: 13734
	[Token(Token = "0x40035A6")]
	[FieldOffset(Offset = "0x129")]
	public bool allowTrespass;

	// Token: 0x040035A7 RID: 13735
	[Token(Token = "0x40035A7")]
	[FieldOffset(Offset = "0x12A")]
	public bool disableActionInsertions;

	// Token: 0x040035A8 RID: 13736
	[Token(Token = "0x40035A8")]
	[FieldOffset(Offset = "0x12B")]
	public bool trashConsumablesOnActivate;

	// Token: 0x040035A9 RID: 13737
	[Token(Token = "0x40035A9")]
	[FieldOffset(Offset = "0x12C")]
	public bool disableThrowing;

	// Token: 0x040035AA RID: 13738
	[Token(Token = "0x40035AA")]
	[FieldOffset(Offset = "0x12D")]
	public bool diabledMugging;

	// Token: 0x040035AB RID: 13739
	[Token(Token = "0x40035AB")]
	[FieldOffset(Offset = "0x12E")]
	public bool allowPottering;

	// Token: 0x040035AC RID: 13740
	[Token(Token = "0x40035AC")]
	[FieldOffset(Offset = "0x130")]
	public AIGoalPreset.GoalActionSource potterSource;

	// Token: 0x040035AD RID: 13741
	[Token(Token = "0x40035AD")]
	[FieldOffset(Offset = "0x134")]
	public Vector2 potterFrequency;

	// Token: 0x040035AE RID: 13742
	[Token(Token = "0x40035AE")]
	[FieldOffset(Offset = "0x140")]
	public List<AIActionPreset> potterActions;

	// Token: 0x040035AF RID: 13743
	[Token(Token = "0x40035AF")]
	[FieldOffset(Offset = "0x148")]
	public bool overrideLightingBehaviour;

	// Token: 0x040035B0 RID: 13744
	[Token(Token = "0x40035B0")]
	[FieldOffset(Offset = "0x149")]
	public bool onlyOverrideIfAtGamelocation;

	// Token: 0x040035B1 RID: 13745
	[Token(Token = "0x40035B1")]
	[FieldOffset(Offset = "0x150")]
	public List<RoomConfiguration.AILightingBehaviour> lightingBehaviour;

	// Token: 0x040035B2 RID: 13746
	[Token(Token = "0x40035B2")]
	[FieldOffset(Offset = "0x158")]
	public AIActionPreset.DoorRule doorRule;

	// Token: 0x040035B3 RID: 13747
	[Token(Token = "0x40035B3")]
	[FieldOffset(Offset = "0x15C")]
	public float chanceOfOnTrigger;

	// Token: 0x040035B4 RID: 13748
	[Token(Token = "0x40035B4")]
	[FieldOffset(Offset = "0x160")]
	public List<SpeechController.Bark> onTriggerBark;

	// Token: 0x02000757 RID: 1879
	[Token(Token = "0x2000757")]
	public enum GoalCategory
	{
		// Token: 0x040035B6 RID: 13750
		[Token(Token = "0x40035B6")]
		trivial,
		// Token: 0x040035B7 RID: 13751
		[Token(Token = "0x40035B7")]
		important,
		// Token: 0x040035B8 RID: 13752
		[Token(Token = "0x40035B8")]
		vital
	}

	// Token: 0x02000758 RID: 1880
	[Token(Token = "0x2000758")]
	public enum StartingGoal
	{
		// Token: 0x040035BA RID: 13754
		[Token(Token = "0x40035BA")]
		all,
		// Token: 0x040035BB RID: 13755
		[Token(Token = "0x40035BB")]
		nonHomelessOnly,
		// Token: 0x040035BC RID: 13756
		[Token(Token = "0x40035BC")]
		homelessOnly
	}

	// Token: 0x02000759 RID: 1881
	[Token(Token = "0x2000759")]
	public enum RainFactor
	{
		// Token: 0x040035BE RID: 13758
		[Token(Token = "0x40035BE")]
		none,
		// Token: 0x040035BF RID: 13759
		[Token(Token = "0x40035BF")]
		onlyDoWhenRaining,
		// Token: 0x040035C0 RID: 13760
		[Token(Token = "0x40035C0")]
		dontDoWhenRaining
	}

	// Token: 0x0200075A RID: 1882
	[Token(Token = "0x200075A")]
	[Serializable]
	public class GoalModifierRule
	{
		// Token: 0x060028F6 RID: 10486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F6")]
		[Address(RVA = "0xC66E80", Offset = "0xC65E80", VA = "0x180C66E80")]
		public GoalModifierRule()
		{
		}

		// Token: 0x040035C1 RID: 13761
		[Token(Token = "0x40035C1")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait.RuleType rule;

		// Token: 0x040035C2 RID: 13762
		[Token(Token = "0x40035C2")]
		[FieldOffset(Offset = "0x18")]
		public List<CharacterTrait> traitList;

		// Token: 0x040035C3 RID: 13763
		[Token(Token = "0x40035C3")]
		[FieldOffset(Offset = "0x20")]
		public bool mustPassForApplication;

		// Token: 0x040035C4 RID: 13764
		[Token(Token = "0x40035C4")]
		[FieldOffset(Offset = "0x24")]
		public float priorityMultiplier;
	}

	// Token: 0x0200075B RID: 1883
	[Token(Token = "0x200075B")]
	public enum LocationOption
	{
		// Token: 0x040035C6 RID: 13766
		[Token(Token = "0x40035C6")]
		useCurrent,
		// Token: 0x040035C7 RID: 13767
		[Token(Token = "0x40035C7")]
		home,
		// Token: 0x040035C8 RID: 13768
		[Token(Token = "0x40035C8")]
		work,
		// Token: 0x040035C9 RID: 13769
		[Token(Token = "0x40035C9")]
		commercial,
		// Token: 0x040035CA RID: 13770
		[Token(Token = "0x40035CA")]
		nearestAvailable,
		// Token: 0x040035CB RID: 13771
		[Token(Token = "0x40035CB")]
		investigate,
		// Token: 0x040035CC RID: 13772
		[Token(Token = "0x40035CC")]
		commercialDecision,
		// Token: 0x040035CD RID: 13773
		[Token(Token = "0x40035CD")]
		patrolLocation,
		// Token: 0x040035CE RID: 13774
		[Token(Token = "0x40035CE")]
		passedInteractable,
		// Token: 0x040035CF RID: 13775
		[Token(Token = "0x40035CF")]
		passedGamelocation,
		// Token: 0x040035D0 RID: 13776
		[Token(Token = "0x40035D0")]
		murderLocation
	}

	// Token: 0x0200075C RID: 1884
	[Token(Token = "0x200075C")]
	public enum RoomOption
	{
		// Token: 0x040035D2 RID: 13778
		[Token(Token = "0x40035D2")]
		none,
		// Token: 0x040035D3 RID: 13779
		[Token(Token = "0x40035D3")]
		bedroom,
		// Token: 0x040035D4 RID: 13780
		[Token(Token = "0x40035D4")]
		job
	}

	// Token: 0x0200075D RID: 1885
	[Token(Token = "0x200075D")]
	public enum FurnitureOption
	{
		// Token: 0x040035D6 RID: 13782
		[Token(Token = "0x40035D6")]
		none,
		// Token: 0x040035D7 RID: 13783
		[Token(Token = "0x40035D7")]
		bed,
		// Token: 0x040035D8 RID: 13784
		[Token(Token = "0x40035D8")]
		job
	}

	// Token: 0x0200075E RID: 1886
	[Token(Token = "0x200075E")]
	[Serializable]
	public class GoalActionSetup
	{
		// Token: 0x060028F7 RID: 10487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F7")]
		[Address(RVA = "0xC66F50", Offset = "0xC65F50", VA = "0x180C66F50")]
		public GoalActionSetup()
		{
		}

		// Token: 0x040035D9 RID: 13785
		[Token(Token = "0x40035D9")]
		[FieldOffset(Offset = "0x10")]
		public List<AIActionPreset> actions;

		// Token: 0x040035DA RID: 13786
		[Token(Token = "0x40035DA")]
		[FieldOffset(Offset = "0x18")]
		public AIGoalPreset.ActionCondition condition;

		// Token: 0x040035DB RID: 13787
		[Token(Token = "0x40035DB")]
		[FieldOffset(Offset = "0x1C")]
		public float chance;

		// Token: 0x040035DC RID: 13788
		[Token(Token = "0x40035DC")]
		[FieldOffset(Offset = "0x20")]
		public List<AIGoalPreset.GoalModifierRule> traitModifiers;

		// Token: 0x040035DD RID: 13789
		[Token(Token = "0x40035DD")]
		[FieldOffset(Offset = "0x28")]
		public List<AIGoalPreset.StatusModifierRule> statusModifiers;
	}

	// Token: 0x0200075F RID: 1887
	[Token(Token = "0x200075F")]
	[Serializable]
	public class StatusModifierRule
	{
		// Token: 0x060028F8 RID: 10488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public StatusModifierRule()
		{
		}

		// Token: 0x040035DE RID: 13790
		[Token(Token = "0x40035DE")]
		[FieldOffset(Offset = "0x10")]
		public AIGoalPreset.StatusType status;

		// Token: 0x040035DF RID: 13791
		[Token(Token = "0x40035DF")]
		[FieldOffset(Offset = "0x14")]
		public AIGoalPreset.StatusCondition condition;

		// Token: 0x040035E0 RID: 13792
		[Token(Token = "0x40035E0")]
		[FieldOffset(Offset = "0x18")]
		public float value;

		// Token: 0x040035E1 RID: 13793
		[Token(Token = "0x40035E1")]
		[FieldOffset(Offset = "0x1C")]
		public float chanceModifier;
	}

	// Token: 0x02000760 RID: 1888
	[Token(Token = "0x2000760")]
	public enum StatusType
	{
		// Token: 0x040035E3 RID: 13795
		[Token(Token = "0x40035E3")]
		health,
		// Token: 0x040035E4 RID: 13796
		[Token(Token = "0x40035E4")]
		nerve,
		// Token: 0x040035E5 RID: 13797
		[Token(Token = "0x40035E5")]
		nourishment,
		// Token: 0x040035E6 RID: 13798
		[Token(Token = "0x40035E6")]
		hydration,
		// Token: 0x040035E7 RID: 13799
		[Token(Token = "0x40035E7")]
		alertness,
		// Token: 0x040035E8 RID: 13800
		[Token(Token = "0x40035E8")]
		energy,
		// Token: 0x040035E9 RID: 13801
		[Token(Token = "0x40035E9")]
		excitement,
		// Token: 0x040035EA RID: 13802
		[Token(Token = "0x40035EA")]
		chores,
		// Token: 0x040035EB RID: 13803
		[Token(Token = "0x40035EB")]
		hygeine,
		// Token: 0x040035EC RID: 13804
		[Token(Token = "0x40035EC")]
		bladder,
		// Token: 0x040035ED RID: 13805
		[Token(Token = "0x40035ED")]
		heat,
		// Token: 0x040035EE RID: 13806
		[Token(Token = "0x40035EE")]
		breath,
		// Token: 0x040035EF RID: 13807
		[Token(Token = "0x40035EF")]
		onDutyEnforcer
	}

	// Token: 0x02000761 RID: 1889
	[Token(Token = "0x2000761")]
	public enum StatusCondition
	{
		// Token: 0x040035F1 RID: 13809
		[Token(Token = "0x40035F1")]
		isEqualOrAbove,
		// Token: 0x040035F2 RID: 13810
		[Token(Token = "0x40035F2")]
		isEqualOrBelow,
		// Token: 0x040035F3 RID: 13811
		[Token(Token = "0x40035F3")]
		isTrue,
		// Token: 0x040035F4 RID: 13812
		[Token(Token = "0x40035F4")]
		isFalse
	}

	// Token: 0x02000762 RID: 1890
	[Token(Token = "0x2000762")]
	public enum ActionCondition
	{
		// Token: 0x040035F6 RID: 13814
		[Token(Token = "0x40035F6")]
		always,
		// Token: 0x040035F7 RID: 13815
		[Token(Token = "0x40035F7")]
		atHomeOnly,
		// Token: 0x040035F8 RID: 13816
		[Token(Token = "0x40035F8")]
		inPublicOnly,
		// Token: 0x040035F9 RID: 13817
		[Token(Token = "0x40035F9")]
		atWorkOnly,
		// Token: 0x040035FA RID: 13818
		[Token(Token = "0x40035FA")]
		onlyIfEscalated,
		// Token: 0x040035FB RID: 13819
		[Token(Token = "0x40035FB")]
		onlyIfDead,
		// Token: 0x040035FC RID: 13820
		[Token(Token = "0x40035FC")]
		atHomeNoGuestPass,
		// Token: 0x040035FD RID: 13821
		[Token(Token = "0x40035FD")]
		noGuestPass,
		// Token: 0x040035FE RID: 13822
		[Token(Token = "0x40035FE")]
		kidnapOnly,
		// Token: 0x040035FF RID: 13823
		[Token(Token = "0x40035FF")]
		nonKidnapOnly,
		// Token: 0x04003600 RID: 13824
		[Token(Token = "0x4003600")]
		killerTauntChance
	}

	// Token: 0x02000763 RID: 1891
	[Token(Token = "0x2000763")]
	public enum GoalActionSource
	{
		// Token: 0x04003602 RID: 13826
		[Token(Token = "0x4003602")]
		thisConfiguration,
		// Token: 0x04003603 RID: 13827
		[Token(Token = "0x4003603")]
		jobPreset,
		// Token: 0x04003604 RID: 13828
		[Token(Token = "0x4003604")]
		murderPreset
	}
}
