using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000096 RID: 150
[Token(Token = "0x2000096")]
[Serializable]
public class NewAIAction
{
	// Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600046B")]
	[Address(RVA = "0x8F7360", Offset = "0x8F6360", VA = "0x1808F7360")]
	public NewAIAction(NewAIGoal newGoal, AIActionPreset newPreset, bool newInsertedAction = false, [Optional] NewRoom newPassedRoom, [Optional] Interactable newPassedInteractable, [Optional] NewNode newForcedNode, [Optional] GroupsController.SocialGroup newPassedGroup, [Optional] List<InteractablePreset> newPassedAcquireItems, bool newForceRun = false, int newInsertedActionPriority = 3, [Optional] NewAIAction newCreatedFor)
	{
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600046C")]
	[Address(RVA = "0x8F93F0", Offset = "0x8F83F0", VA = "0x1808F93F0")]
	public void OnActivate()
	{
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x00003B10 File Offset: 0x00001D10
	[Token(Token = "0x600046D")]
	[Address(RVA = "0x9036A0", Offset = "0x9026A0", VA = "0x1809036A0")]
	public bool DestinationCheck(bool overflowLoop = false)
	{
		return default(bool);
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x00003B28 File Offset: 0x00001D28
	[Token(Token = "0x600046E")]
	[Address(RVA = "0x905600", Offset = "0x904600", VA = "0x180905600")]
	private bool IsCloseEnoughForAttack()
	{
		return default(bool);
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600046F")]
	[Address(RVA = "0x905F90", Offset = "0x904F90", VA = "0x180905F90")]
	public void MovementDestinationCheck(NewNode resetNode)
	{
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000470")]
	[Address(RVA = "0x906440", Offset = "0x905440", VA = "0x180906440")]
	public void SetUsagePoint(Interactable.UsagePoint newUsagePoint, Interactable.UsePointSlot newSlot)
	{
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x00003B40 File Offset: 0x00001D40
	[Token(Token = "0x6000471")]
	[Address(RVA = "0x9067E0", Offset = "0x9057E0", VA = "0x1809067E0")]
	public bool InteractableUsePointCheck()
	{
		return default(bool);
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000472")]
	[Address(RVA = "0x9072D0", Offset = "0x9062D0", VA = "0x1809072D0")]
	public void OnUsePointBusy()
	{
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000473")]
	[Address(RVA = "0x907A00", Offset = "0x906A00", VA = "0x180907A00")]
	public void UpdateCombatPose()
	{
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000474")]
	[Address(RVA = "0x907D50", Offset = "0x906D50", VA = "0x180907D50")]
	public void SetupPath(bool scanForNextNodeFurniture = true)
	{
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00003B58 File Offset: 0x00001D58
	[Token(Token = "0x6000475")]
	[Address(RVA = "0x9086C0", Offset = "0x9076C0", VA = "0x1809086C0")]
	public bool UsingFurnitureCheck()
	{
		return default(bool);
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000476")]
	[Address(RVA = "0x9094A0", Offset = "0x9084A0", VA = "0x1809094A0")]
	public void OnDeactivate(bool executeDeactivateAnimation = true)
	{
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000477")]
	[Address(RVA = "0x909F60", Offset = "0x908F60", VA = "0x180909F60")]
	public void CancelNextAIInteraction()
	{
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000478")]
	[Address(RVA = "0x909FE0", Offset = "0x908FE0", VA = "0x180909FE0")]
	public void Complete()
	{
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000479")]
	[Address(RVA = "0x90AD40", Offset = "0x909D40", VA = "0x18090AD40")]
	private void ExecuteAdditionalActions(ref List<AIActionPreset.AutomaticAction> actionPresets)
	{
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047A")]
	[Address(RVA = "0x90C340", Offset = "0x90B340", VA = "0x18090C340")]
	public void ExecuteEndSwitchChanges()
	{
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047B")]
	[Address(RVA = "0x90C520", Offset = "0x90B520", VA = "0x18090C520")]
	public void DropItemAtEnd()
	{
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047C")]
	[Address(RVA = "0x90CB10", Offset = "0x90BB10", VA = "0x18090CB10")]
	public void Remove(float delayReactivationTime = 0f)
	{
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047D")]
	[Address(RVA = "0x90D370", Offset = "0x90C370", VA = "0x18090D370")]
	public void TriggerArrivalSound()
	{
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047E")]
	[Address(RVA = "0x90D7A0", Offset = "0x90C7A0", VA = "0x18090D7A0")]
	public void EndSoundLoop()
	{
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600047F")]
	[Address(RVA = "0x90D870", Offset = "0x90C870", VA = "0x18090D870")]
	public void AITick()
	{
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x00003B70 File Offset: 0x00001D70
	[Token(Token = "0x6000480")]
	[Address(RVA = "0x911140", Offset = "0x910140", VA = "0x180911140")]
	public bool InteractableStateCheck(AIActionPreset.CheckActionAgainstState stateCheck)
	{
		return default(bool);
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000481")]
	[Address(RVA = "0x9117B0", Offset = "0x9107B0", VA = "0x1809117B0")]
	public void LOSCheck()
	{
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00003B88 File Offset: 0x00001D88
	[Token(Token = "0x6000482")]
	[Address(RVA = "0x911C10", Offset = "0x910C10", VA = "0x180911C10")]
	private bool IsPersuitTargetCatchable()
	{
		return default(bool);
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000483")]
	[Address(RVA = "0x912410", Offset = "0x911410", VA = "0x180912410")]
	public void SetAtDestination(bool val, bool forceUpdate = false)
	{
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000484")]
	[Address(RVA = "0x9147F0", Offset = "0x9137F0", VA = "0x1809147F0")]
	public void OnInvalidMovement(int attemptNumber)
	{
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x00003BA0 File Offset: 0x00001DA0
	[Token(Token = "0x6000485")]
	[Address(RVA = "0x9148A0", Offset = "0x9138A0", VA = "0x1809148A0")]
	public bool AllowImmediateCompletion()
	{
		return default(bool);
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00003BB8 File Offset: 0x00001DB8
	[Token(Token = "0x6000486")]
	[Address(RVA = "0x915220", Offset = "0x914220", VA = "0x180915220")]
	public bool AllowImmediateTeleportation()
	{
		return default(bool);
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000487")]
	[Address(RVA = "0x916250", Offset = "0x915250", VA = "0x180916250")]
	public void ImmediateComplete()
	{
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000488")]
	[Address(RVA = "0x916280", Offset = "0x915280", VA = "0x180916280")]
	public Interactable InteractablePicker(ref List<Interactable> opt, Vector3 currentWorldPosition, bool useSocialRules, out NewNode useNode, out Interactable.UsagePoint usePoint, [Optional] GroupsController.SocialGroup meetingGroup, bool useDistance = false, bool useDistanceIfInSameAddress = true, [Optional] List<Interactable> ignore)
	{
		return null;
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00003BD0 File Offset: 0x00001DD0
	[Token(Token = "0x6000489")]
	[Address(RVA = "0x919410", Offset = "0x918410", VA = "0x180919410")]
	private bool <ExecuteAdditionalActions>b__53_0(NewAIController.TrackingTarget item)
	{
		return default(bool);
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00003BE8 File Offset: 0x00001DE8
	[Token(Token = "0x600048A")]
	[Address(RVA = "0x9196C0", Offset = "0x9186C0", VA = "0x1809196C0")]
	private bool <ExecuteAdditionalActions>b__53_1(InteractableController item)
	{
		return default(bool);
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00003C00 File Offset: 0x00001E00
	[Token(Token = "0x600048B")]
	[Address(RVA = "0x9196F0", Offset = "0x9186F0", VA = "0x1809196F0")]
	private bool <InteractableStateCheck>b__60_0(Actor item)
	{
		return default(bool);
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00003C18 File Offset: 0x00001E18
	[Token(Token = "0x600048C")]
	[Address(RVA = "0x9198B0", Offset = "0x9188B0", VA = "0x1809198B0")]
	private bool <InteractablePicker>b__68_0(InteractablePreset.AIUsePriority item)
	{
		return default(bool);
	}

	// Token: 0x040003F1 RID: 1009
	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	// Token: 0x040003F2 RID: 1010
	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[NonSerialized]
	public NewAIGoal goal;

	// Token: 0x040003F3 RID: 1011
	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AIActionPreset preset;

	// Token: 0x040003F4 RID: 1012
	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isActive;

	// Token: 0x040003F5 RID: 1013
	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool completed;

	// Token: 0x040003F6 RID: 1014
	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool repeat;

	// Token: 0x040003F7 RID: 1015
	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	[NonSerialized]
	public bool checkedForInsertions;

	// Token: 0x040003F8 RID: 1016
	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool insertedAction;

	// Token: 0x040003F9 RID: 1017
	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int insertedActionPriority;

	// Token: 0x040003FA RID: 1018
	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[NonSerialized]
	public NewAIAction createdFor;

	// Token: 0x040003FB RID: 1019
	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public NewNode node;

	// Token: 0x040003FC RID: 1020
	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[NonSerialized]
	public Interactable interactable;

	// Token: 0x040003FD RID: 1021
	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public Interactable.UsagePoint usagePoint;

	// Token: 0x040003FE RID: 1022
	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool isAtLocation;

	// Token: 0x040003FF RID: 1023
	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public PathFinder.PathData path;

	// Token: 0x04000400 RID: 1024
	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[NonSerialized]
	public Interactable passedInteractable;

	// Token: 0x04000401 RID: 1025
	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public NewRoom passedRoom;

	// Token: 0x04000402 RID: 1026
	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public NewNode forcedNode;

	// Token: 0x04000403 RID: 1027
	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[NonSerialized]
	public GroupsController.SocialGroup passedGroup;

	// Token: 0x04000404 RID: 1028
	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[NonSerialized]
	public bool forceRun;

	// Token: 0x04000405 RID: 1029
	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float estimatedArrival;

	// Token: 0x04000406 RID: 1030
	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float arrivedAtDestination;

	// Token: 0x04000407 RID: 1031
	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool actionCheckRecursion;

	// Token: 0x04000408 RID: 1032
	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private NewGameLocation.ObjectPlacement bestPlacement;

	// Token: 0x04000409 RID: 1033
	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<InteractablePreset> passedAcquireItems;

	// Token: 0x0400040A RID: 1034
	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public NewWall vantagePoint;

	// Token: 0x0400040B RID: 1035
	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[NonSerialized]
	public AudioController.LoopingSoundInfo audioLoop;

	// Token: 0x0400040C RID: 1036
	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[NonSerialized]
	public float lastRecordedTickWhileAtDesitnation;

	// Token: 0x0400040D RID: 1037
	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public float timeThisWillTake;

	// Token: 0x0400040E RID: 1038
	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float progress;

	// Token: 0x0400040F RID: 1039
	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	[NonSerialized]
	public float dontUpdateGoalPriorityForExtraTime;

	// Token: 0x04000410 RID: 1040
	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float createdAt;

	// Token: 0x04000411 RID: 1041
	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public InteractableController debugPassedInteractable;

	// Token: 0x04000412 RID: 1042
	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public NewRoom debugPassedRoom;

	// Token: 0x04000413 RID: 1043
	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public bool debugForcedNode;

	// Token: 0x04000414 RID: 1044
	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public Vector3 debugForcedNodeWorldPos;

	// Token: 0x04000415 RID: 1045
	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<Interactable> debugPickupInteractable;

	// Token: 0x04000416 RID: 1046
	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public InteractableController debugInteractableController;

	// Token: 0x04000417 RID: 1047
	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Vector3 debugInteractionUsagePosition;

	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600048E RID: 1166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x600048F")]
		[Address(RVA = "0xDD1260", Offset = "0xDD0260", VA = "0x180DD1260")]
		internal bool <OnActivate>b__40_0(NewAIController.TrackingTarget item)
		{
			return default(bool);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x4E73D0", Offset = "0x4E63D0", VA = "0x1804E73D0")]
		internal bool <OnActivate>b__40_1(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x4E73D0", Offset = "0x4E63D0", VA = "0x1804E73D0")]
		internal bool <OnActivate>b__40_2(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x6000492")]
		[Address(RVA = "0xDD1390", Offset = "0xDD0390", VA = "0x180DD1390")]
		internal bool <DestinationCheck>b__41_0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NewAIAction.<>c <>9;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<NewAIController.TrackingTarget> <>9__40_0;

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<NewNode.NodeAccess> <>9__40_1;

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<NewNode.NodeAccess> <>9__40_2;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<MurderController.Murder> <>9__41_0;
	}
}
