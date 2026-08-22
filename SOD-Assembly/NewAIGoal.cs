using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x020000A3 RID: 163
[Token(Token = "0x20000A3")]
[Serializable]
public class NewAIGoal : IEnumerator<object>
{
	// Token: 0x0600052F RID: 1327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600052F")]
	[Address(RVA = "0xC2FF20", Offset = "0xC2EF20", VA = "0x180C2FF20")]
	public NewAIGoal(NewAIController newController, AIGoalPreset newPreset, float newTrigerTime, float newDuration, [Optional] NewNode newPassedNode, [Optional] Interactable newPassedInteractable, [Optional] NewGameLocation newPassedGameLocation, [Optional] GroupsController.SocialGroup newPassedGroup, [Optional] MurderController.Murder newMurderRef, float newTraitMultiplier = 1f, int newPassedVar = -2)
	{
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000530")]
	[Address(RVA = "0xC30870", Offset = "0xC2F870", VA = "0x180C30870")]
	public void UpdateNextWorkingTimes()
	{
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000531")]
	[Address(RVA = "0xC30A40", Offset = "0xC2FA40", VA = "0x180C30A40")]
	public void UpdateNextGroupTimes()
	{
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000532")]
	[Address(RVA = "0xC30B00", Offset = "0xC2FB00", VA = "0x180C30B00")]
	public void UpdatePriority(bool ignoreDelayTime = false)
	{
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000533")]
	[Address(RVA = "0xC33490", Offset = "0xC32490", VA = "0x180C33490")]
	public void OnActivate()
	{
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000534")]
	[Address(RVA = "0xC38170", Offset = "0xC37170", VA = "0x180C38170")]
	public void RefreshActions(bool refresh = false)
	{
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000535")]
	[Address(RVA = "0xC3A760", Offset = "0xC39760", VA = "0x180C3A760")]
	public void OnDeactivate(float delayReactivationTime)
	{
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000536")]
	[Address(RVA = "0xC3AD50", Offset = "0xC39D50", VA = "0x180C3AD50")]
	public void AITick()
	{
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000537")]
	[Address(RVA = "0xC3B620", Offset = "0xC3A620", VA = "0x180C3B620")]
	public void InsertActionsCheck()
	{
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000538")]
	[Address(RVA = "0xC41280", Offset = "0xC40280", VA = "0x180C41280")]
	public void CancelIrreleventActions()
	{
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000539")]
	[Address(RVA = "0xC41A20", Offset = "0xC40A20", VA = "0x180C41A20")]
	public void ResetBehaviourCheck(InteractablePreset.ObjectResetCondition currentCondition)
	{
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600053A")]
	[Address(RVA = "0xC425D0", Offset = "0xC415D0", VA = "0x180C425D0")]
	public void PutDownItem(Interactable inventoryItem, NewGameLocation location)
	{
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600053B")]
	[Address(RVA = "0xC427D0", Offset = "0xC417D0", VA = "0x180C427D0")]
	public void PickUpItem(Interactable inventoryItem)
	{
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600053C")]
	[Address(RVA = "0xC429D0", Offset = "0xC419D0", VA = "0x180C429D0")]
	public void RoomLightingCheck(NewRoom room, RoomConfiguration.AILightingBehaviour.LightingPreference pref)
	{
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x00003EA0 File Offset: 0x000020A0
	[Token(Token = "0x600053D")]
	[Address(RVA = "0xC42F40", Offset = "0xC41F40", VA = "0x180C42F40")]
	public bool IsLastOccupantOfRoom(NewRoom room, bool trueIfAsleep = false)
	{
		return default(bool);
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x00003EB8 File Offset: 0x000020B8
	[Token(Token = "0x600053E")]
	[Address(RVA = "0xC431E0", Offset = "0xC421E0", VA = "0x180C431E0")]
	public bool IsLastOccupantOfGameLocation(NewGameLocation gl, bool trueIfAsleep = false)
	{
		return default(bool);
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600053F")]
	[Address(RVA = "0xC43480", Offset = "0xC42480", VA = "0x180C43480")]
	public void PotterCheck()
	{
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000540")]
	[Address(RVA = "0xC453D0", Offset = "0xC443D0", VA = "0x180C453D0")]
	private void SetNextPotterTime()
	{
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x00003ED0 File Offset: 0x000020D0
	[Token(Token = "0x6000541")]
	[Address(RVA = "0xC45580", Offset = "0xC44580", VA = "0x180C45580")]
	public bool TryInsertInteractableAction(Interactable with, AIActionPreset newPreset, int priority, [Optional] NewNode forcedNode, bool duplicateActionCheck = true)
	{
		return default(bool);
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x00003EE8 File Offset: 0x000020E8
	[Token(Token = "0x6000542")]
	[Address(RVA = "0xC45B80", Offset = "0xC44B80", VA = "0x180C45B80")]
	public bool TryInsertDoorAction(NewDoor door, AIActionPreset preset, NewAIGoal.DoorSide doorSide, int priority, out NewAIGoal.DoorActionCheckResult result, [Optional] NewNode forcedNode, bool immediateTick = false, [Optional] NewAIAction createdFor)
	{
		return default(bool);
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000543")]
	[Address(RVA = "0xC47060", Offset = "0xC46060", VA = "0x180C47060")]
	private void TurnMainLightOn(NewRoom where)
	{
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000544")]
	[Address(RVA = "0xC476C0", Offset = "0xC466C0", VA = "0x180C476C0")]
	private void TurnMainLightOff(NewRoom where)
	{
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000545")]
	[Address(RVA = "0xC47D20", Offset = "0xC46D20", VA = "0x180C47D20")]
	private void TurnSecondaryLightOn(NewRoom where)
	{
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000546")]
	[Address(RVA = "0xC48390", Offset = "0xC47390", VA = "0x180C48390")]
	private void TurnSecondaryLightsOff(NewRoom where)
	{
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000547")]
	[Address(RVA = "0xC48CA0", Offset = "0xC47CA0", VA = "0x180C48CA0")]
	private void DeactivateInteractable(Interactable thisInteractable)
	{
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00003F00 File Offset: 0x00002100
	[Token(Token = "0x6000548")]
	[Address(RVA = "0xC48F30", Offset = "0xC47F30", VA = "0x180C48F30")]
	public bool InsertUnlockAction(NewDoor door, bool lockBehind)
	{
		return default(bool);
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00003F18 File Offset: 0x00002118
	[Token(Token = "0x6000549")]
	[Address(RVA = "0xC49B80", Offset = "0xC48B80", VA = "0x180C49B80")]
	public bool InsertLockAction(NewDoor door)
	{
		return default(bool);
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054A")]
	[Address(RVA = "0xC4A060", Offset = "0xC49060", VA = "0x180C4A060")]
	public void InsertPlayerHidingPlaceRemoval()
	{
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054B")]
	[Address(RVA = "0xC4A200", Offset = "0xC49200", VA = "0x180C4A200")]
	public void OnCompletedAction(NewAIAction completed)
	{
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054C")]
	[Address(RVA = "0xC4A2F0", Offset = "0xC492F0", VA = "0x180C4A2F0")]
	public void Complete()
	{
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600054D")]
	[Address(RVA = "0xC4A430", Offset = "0xC49430", VA = "0x180C4A430")]
	public void Remove()
	{
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00003F30 File Offset: 0x00002130
	[Token(Token = "0x600054E")]
	[Address(RVA = "0xC4A710", Offset = "0xC49710", VA = "0x180C4A710")]
	public float GetTimeActive()
	{
		return 0f;
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600054F")]
	[Address(RVA = "0xC4A770", Offset = "0xC49770", VA = "0x180C4A770")]
	public StateSaveData.CurrentGoalStateSave GetGoalStateSave()
	{
		return null;
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x00003F48 File Offset: 0x00002148
	[Token(Token = "0x6000550")]
	[Address(RVA = "0xC4B060", Offset = "0xC4A060", VA = "0x180C4B060", Slot = "4")]
	public int CompareTo(NewAIGoal otherObject)
	{
		return 0;
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000551")]
	[Address(RVA = "0xC4B0F0", Offset = "0xC4A0F0", VA = "0x180C4B0F0")]
	public AIActionPreset GetFirstAction(NewGameLocation loc)
	{
		return null;
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x00003F60 File Offset: 0x00002160
	[Token(Token = "0x6000552")]
	[Address(RVA = "0xC4B370", Offset = "0xC4A370", VA = "0x180C4B370")]
	public float GetActionChance(AIGoalPreset.GoalActionSetup actionSetup, NewGameLocation loc)
	{
		return 0f;
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x00003F78 File Offset: 0x00002178
	[Token(Token = "0x6000553")]
	[Address(RVA = "0xC4D210", Offset = "0xC4C210", VA = "0x180C4D210")]
	private bool <UpdatePriority>b__55_2(GameplayController.LoanDebt item)
	{
		return default(bool);
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x00003F90 File Offset: 0x00002190
	[Token(Token = "0x6000554")]
	[Address(RVA = "0xC4D260", Offset = "0xC4C260", VA = "0x180C4D260")]
	private bool <UpdatePriority>b__55_3(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x00003FA8 File Offset: 0x000021A8
	[Token(Token = "0x6000555")]
	[Address(RVA = "0xC4D450", Offset = "0xC4C450", VA = "0x180C4D450")]
	private bool <RefreshActions>b__57_0(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x00003FC0 File Offset: 0x000021C0
	[Token(Token = "0x6000556")]
	[Address(RVA = "0xC4D4C0", Offset = "0xC4C4C0", VA = "0x180C4D4C0")]
	private bool <RefreshActions>b__57_1(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x00003FD8 File Offset: 0x000021D8
	[Token(Token = "0x6000557")]
	[Address(RVA = "0xC4D530", Offset = "0xC4C530", VA = "0x180C4D530")]
	private bool <InsertActionsCheck>b__60_10(NewAIAction item)
	{
		return default(bool);
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00003FF0 File Offset: 0x000021F0
	[Token(Token = "0x6000558")]
	[Address(RVA = "0xC4D900", Offset = "0xC4C900", VA = "0x180C4D900")]
	private bool <InsertActionsCheck>b__60_3(MurderController.Murder item)
	{
		return default(bool);
	}

	// Token: 0x040004FC RID: 1276
	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	// Token: 0x040004FD RID: 1277
	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[NonSerialized]
	public NewAIController aiController;

	// Token: 0x040004FE RID: 1278
	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AIGoalPreset preset;

	// Token: 0x040004FF RID: 1279
	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float basePriority;

	// Token: 0x04000500 RID: 1280
	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float traitMultiplier;

	// Token: 0x04000501 RID: 1281
	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isActive;

	// Token: 0x04000502 RID: 1282
	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float triggerTime;

	// Token: 0x04000503 RID: 1283
	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float activeTimestamp;

	// Token: 0x04000504 RID: 1284
	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[NonSerialized]
	public float duration;

	// Token: 0x04000505 RID: 1285
	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float debugWorkStartHour;

	// Token: 0x04000506 RID: 1286
	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float debugWorkEndHour;

	// Token: 0x04000507 RID: 1287
	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NewGameLocation lastEstimatedTravelTime;

	// Token: 0x04000508 RID: 1288
	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public float travelTime;

	// Token: 0x04000509 RID: 1289
	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int jobID;

	// Token: 0x0400050A RID: 1290
	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[NonSerialized]
	public float timingWeight;

	// Token: 0x0400050B RID: 1291
	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[NonSerialized]
	public float nourishmentWeight;

	// Token: 0x0400050C RID: 1292
	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[NonSerialized]
	public float hydrationWeight;

	// Token: 0x0400050D RID: 1293
	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[NonSerialized]
	public float altertnessWeight;

	// Token: 0x0400050E RID: 1294
	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[NonSerialized]
	public float tirednessWeight;

	// Token: 0x0400050F RID: 1295
	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[NonSerialized]
	public float energyWeight;

	// Token: 0x04000510 RID: 1296
	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[NonSerialized]
	public float excitementWeight;

	// Token: 0x04000511 RID: 1297
	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[NonSerialized]
	public float choresWeight;

	// Token: 0x04000512 RID: 1298
	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[NonSerialized]
	public float hygeieneWeight;

	// Token: 0x04000513 RID: 1299
	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[NonSerialized]
	public float bladderWeight;

	// Token: 0x04000514 RID: 1300
	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[NonSerialized]
	public float heatWeight;

	// Token: 0x04000515 RID: 1301
	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[NonSerialized]
	public float drunkWeight;

	// Token: 0x04000516 RID: 1302
	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[NonSerialized]
	public float breathWeight;

	// Token: 0x04000517 RID: 1303
	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[NonSerialized]
	public float poisonedWeight;

	// Token: 0x04000518 RID: 1304
	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[NonSerialized]
	public float blindedWeight;

	// Token: 0x04000519 RID: 1305
	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float priority;

	// Token: 0x0400051A RID: 1306
	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<NewAIAction> actions;

	// Token: 0x0400051B RID: 1307
	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float nextPotterAction;

	// Token: 0x0400051C RID: 1308
	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private int doorCheckCycle;

	// Token: 0x0400051D RID: 1309
	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool workCleanUpStarted;

	// Token: 0x0400051E RID: 1310
	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<Interactable> chosenInteractablesThisGoal;

	// Token: 0x0400051F RID: 1311
	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public NewGameLocation gameLocation;

	// Token: 0x04000520 RID: 1312
	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public NewRoom roomLocation;

	// Token: 0x04000521 RID: 1313
	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public NewNode passedNode;

	// Token: 0x04000522 RID: 1314
	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[NonSerialized]
	public Interactable passedInteractable;

	// Token: 0x04000523 RID: 1315
	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public NewGameLocation passedGameLocation;

	// Token: 0x04000524 RID: 1316
	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public int passedVar;

	// Token: 0x04000525 RID: 1317
	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[NonSerialized]
	public GroupsController.SocialGroup passedGroup;

	// Token: 0x04000526 RID: 1318
	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public int searchProgress;

	// Token: 0x04000527 RID: 1319
	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public List<NewNode> searchedNodes;

	// Token: 0x04000528 RID: 1320
	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[NonSerialized]
	public MurderController.Murder murderRef;

	// Token: 0x04000529 RID: 1321
	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public float lastCheckedForWorkingDay;

	// Token: 0x0400052A RID: 1322
	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public float lastCheckedForGroupDay;

	// Token: 0x0400052B RID: 1323
	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private bool startGameWorkCheck;

	// Token: 0x0400052C RID: 1324
	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
	private bool startGameGroupCheck;

	// Token: 0x0400052D RID: 1325
	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private NewRoom arrivedRoom;

	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	public enum DoorActionCheckResult
	{
		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		success,
		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		noHandle,
		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		beingUsed,
		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		duplicate
	}

	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	public enum DoorSide
	{
		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		mySide,
		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		forceCurrentSide,
		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		forceCurrentOtherSide
	}

	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	private sealed class <>c__DisplayClass55_0
	{
		// Token: 0x06000559 RID: 1369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass55_0()
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00004008 File Offset: 0x00002208
		[Token(Token = "0x600055A")]
		[Address(RVA = "0xDD35C0", Offset = "0xDD25C0", VA = "0x180DD35C0")]
		internal bool <UpdatePriority>b__5(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AIGoalPreset p;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewAIGoal <>4__this;
	}

	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600055C RID: 1372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x600055D")]
		[Address(RVA = "0xDD1390", Offset = "0xDD0390", VA = "0x180DD1390")]
		internal bool <UpdatePriority>b__55_0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x600055E")]
		[Address(RVA = "0xDD36D0", Offset = "0xDD26D0", VA = "0x180DD36D0")]
		internal bool <UpdatePriority>b__55_4(AudioController.LoopingSoundInfo item)
		{
			return default(bool);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x600055F")]
		[Address(RVA = "0xDD3710", Offset = "0xDD2710", VA = "0x180DD3710")]
		internal bool <UpdatePriority>b__55_1(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x6000560")]
		[Address(RVA = "0xDD3750", Offset = "0xDD2750", VA = "0x180DD3750")]
		internal bool <InsertActionsCheck>b__60_0(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x6000561")]
		[Address(RVA = "0xDD37F0", Offset = "0xDD27F0", VA = "0x180DD37F0")]
		internal bool <InsertActionsCheck>b__60_7(Actor item)
		{
			return default(bool);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x6000562")]
		[Address(RVA = "0xDD3820", Offset = "0xDD2820", VA = "0x180DD3820")]
		internal bool <InsertActionsCheck>b__60_1(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x6000563")]
		[Address(RVA = "0xDD38C0", Offset = "0xDD28C0", VA = "0x180DD38C0")]
		internal bool <InsertActionsCheck>b__60_2(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x6000564")]
		[Address(RVA = "0xDC7670", Offset = "0xDC6670", VA = "0x180DC7670")]
		internal bool <InsertActionsCheck>b__60_4(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x6000565")]
		[Address(RVA = "0xDD3960", Offset = "0xDD2960", VA = "0x180DD3960")]
		internal bool <InsertActionsCheck>b__60_5(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x6000566")]
		[Address(RVA = "0xDD3960", Offset = "0xDD2960", VA = "0x180DD3960")]
		internal bool <InsertActionsCheck>b__60_6(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x6000567")]
		[Address(RVA = "0xDD3A00", Offset = "0xDD2A00", VA = "0x180DD3A00")]
		internal bool <InsertActionsCheck>b__60_11(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x6000568")]
		[Address(RVA = "0xDD3AA0", Offset = "0xDD2AA0", VA = "0x180DD3AA0")]
		internal bool <InsertActionsCheck>b__60_14(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x6000569")]
		[Address(RVA = "0xDD3B50", Offset = "0xDD2B50", VA = "0x180DD3B50")]
		internal bool <TurnSecondaryLightsOff>b__75_0(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x600056A")]
		[Address(RVA = "0xDD3CF0", Offset = "0xDD2CF0", VA = "0x180DD3CF0")]
		internal bool <TurnSecondaryLightsOff>b__75_2(InteractablePreset.SwitchState item2)
		{
			return default(bool);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x600056B")]
		[Address(RVA = "0xDD3D20", Offset = "0xDD2D20", VA = "0x180DD3D20")]
		internal bool <DeactivateInteractable>b__76_0(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NewAIGoal.<>c <>9;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<MurderController.Murder> <>9__55_0;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<AudioController.LoopingSoundInfo> <>9__55_4;

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<MurderController.Murder> <>9__55_1;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<NewAIAction> <>9__60_0;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<Actor> <>9__60_7;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<NewAIAction> <>9__60_1;

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<NewAIAction> <>9__60_2;

		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Predicate<NewAIGoal> <>9__60_4;

		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Predicate<NewAIAction> <>9__60_5;

		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Predicate<NewAIAction> <>9__60_6;

		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Predicate<NewAIAction> <>9__60_11;

		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Predicate<Interactable> <>9__60_14;

		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Predicate<InteractablePreset.SwitchState> <>9__75_2;

		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__75_0;

		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__76_0;
	}

	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	private sealed class <>c__DisplayClass56_0
	{
		// Token: 0x0600056C RID: 1388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass56_0()
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x600056D")]
		[Address(RVA = "0xDD3D50", Offset = "0xDD2D50", VA = "0x180DD3D50")]
		internal bool <OnActivate>b__0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RoomConfiguration r;
	}

	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	private sealed class <>c__DisplayClass60_0
	{
		// Token: 0x0600056E RID: 1390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass60_0()
		{
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x600056F")]
		[Address(RVA = "0xDD3DB0", Offset = "0xDD2DB0", VA = "0x180DD3DB0")]
		internal bool <InsertActionsCheck>b__8(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewRoom r;
	}

	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	private sealed class <>c__DisplayClass60_1
	{
		// Token: 0x06000570 RID: 1392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass60_1()
		{
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x6000571")]
		[Address(RVA = "0xDD4160", Offset = "0xDD3160", VA = "0x180DD4160")]
		internal bool <InsertActionsCheck>b__9(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewRoom r;
	}

	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	private sealed class <>c__DisplayClass60_2
	{
		// Token: 0x06000572 RID: 1394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass60_2()
		{
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x6000573")]
		[Address(RVA = "0xDD4510", Offset = "0xDD3510", VA = "0x180DD4510")]
		internal bool <InsertActionsCheck>b__12(Actor item)
		{
			return default(bool);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x6000574")]
		[Address(RVA = "0xDD4720", Offset = "0xDD3720", VA = "0x180DD4720")]
		internal bool <InsertActionsCheck>b__13(NewAIAction item2)
		{
			return default(bool);
		}

		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewNode.NodeAccess acc;

		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<NewAIAction> <>9__13;
	}

	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	private sealed class <>c__DisplayClass63_0
	{
		// Token: 0x06000575 RID: 1397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass63_0()
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x6000576")]
		[Address(RVA = "0xDD4800", Offset = "0xDD3800", VA = "0x180DD4800")]
		internal bool <PutDownItem>b__0(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Interactable inventoryItem;
	}

	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	private sealed class <>c__DisplayClass64_0
	{
		// Token: 0x06000577 RID: 1399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass64_0()
		{
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x6000578")]
		[Address(RVA = "0xDD48D0", Offset = "0xDD38D0", VA = "0x180DD48D0")]
		internal bool <PickUpItem>b__0(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Interactable inventoryItem;
	}

	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	private sealed class <>c__DisplayClass68_0
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass68_0()
		{
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x600057A")]
		[Address(RVA = "0xDD3D50", Offset = "0xDD2D50", VA = "0x180DD3D50")]
		internal bool <PotterCheck>b__0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x04000550 RID: 1360
		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RoomConfiguration r;
	}

	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	private sealed class <>c__DisplayClass68_1
	{
		// Token: 0x0600057B RID: 1403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass68_1()
		{
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x600057C")]
		[Address(RVA = "0xDD3D50", Offset = "0xDD2D50", VA = "0x180DD3D50")]
		internal bool <PotterCheck>b__1(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x04000551 RID: 1361
		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RoomConfiguration r;
	}

	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	private sealed class <>c__DisplayClass70_0
	{
		// Token: 0x0600057D RID: 1405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass70_0()
		{
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x600057E")]
		[Address(RVA = "0xDD49A0", Offset = "0xDD39A0", VA = "0x180DD49A0")]
		internal bool <TryInsertInteractableAction>b__0(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AIActionPreset newPreset;

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Interactable with;
	}

	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	private sealed class <>c__DisplayClass71_0
	{
		// Token: 0x0600057F RID: 1407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass71_0()
		{
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x6000580")]
		[Address(RVA = "0xDD4A30", Offset = "0xDD3A30", VA = "0x180DD4A30")]
		internal bool <TryInsertDoorAction>b__0(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AIActionPreset preset;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewDoor door;

		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NewNode forcedNode;
	}

	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	private sealed class <>c__DisplayClass72_0
	{
		// Token: 0x06000581 RID: 1409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass72_0()
		{
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x6000582")]
		[Address(RVA = "0xDD4AE0", Offset = "0xDD3AE0", VA = "0x180DD4AE0")]
		internal bool <TurnMainLightOn>b__0(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x6000583")]
		[Address(RVA = "0xDD4D30", Offset = "0xDD3D30", VA = "0x180DD4D30")]
		internal bool <TurnMainLightOn>b__1(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x6000584")]
		[Address(RVA = "0xDD4F80", Offset = "0xDD3F80", VA = "0x180DD4F80")]
		internal bool <TurnMainLightOn>b__2(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewRoom where;

		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<NewAIAction> <>9__1;
	}

	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	private sealed class <>c__DisplayClass73_0
	{
		// Token: 0x06000585 RID: 1413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass73_0()
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x6000586")]
		[Address(RVA = "0xDD51D0", Offset = "0xDD41D0", VA = "0x180DD51D0")]
		internal bool <TurnMainLightOff>b__0(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x6000587")]
		[Address(RVA = "0xDD5420", Offset = "0xDD4420", VA = "0x180DD5420")]
		internal bool <TurnMainLightOff>b__1(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x6000588")]
		[Address(RVA = "0xDD5670", Offset = "0xDD4670", VA = "0x180DD5670")]
		internal bool <TurnMainLightOff>b__2(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewRoom where;

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<NewAIAction> <>9__1;
	}

	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	private sealed class <>c__DisplayClass74_0
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass74_0()
		{
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x600058A")]
		[Address(RVA = "0xDD58C0", Offset = "0xDD48C0", VA = "0x180DD58C0")]
		internal bool <TurnSecondaryLightOn>b__0(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x600058B")]
		[Address(RVA = "0xDD5B10", Offset = "0xDD4B10", VA = "0x180DD5B10")]
		internal bool <TurnSecondaryLightOn>b__1(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x600058C")]
		[Address(RVA = "0xDD5D60", Offset = "0xDD4D60", VA = "0x180DD5D60")]
		internal bool <TurnSecondaryLightOn>b__2(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewRoom where;

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<NewAIAction> <>9__1;
	}

	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	private sealed class <>c__DisplayClass75_0
	{
		// Token: 0x0600058D RID: 1421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass75_0()
		{
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x600058E")]
		[Address(RVA = "0xDD5FB0", Offset = "0xDD4FB0", VA = "0x180DD5FB0")]
		internal bool <TurnSecondaryLightsOff>b__3(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x600058F")]
		[Address(RVA = "0xDD5FB0", Offset = "0xDD4FB0", VA = "0x180DD5FB0")]
		internal bool <TurnSecondaryLightsOff>b__1(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x6000590")]
		[Address(RVA = "0xDD5FB0", Offset = "0xDD4FB0", VA = "0x180DD5FB0")]
		internal bool <TurnSecondaryLightsOff>b__4(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Interactable inter;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AIActionPreset releventAction;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<NewAIAction> <>9__4;
	}

	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	private sealed class <>c__DisplayClass87_0
	{
		// Token: 0x06000591 RID: 1425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass87_0()
		{
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GetActionChance>b__0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	private sealed class <>c__DisplayClass87_1
	{
		// Token: 0x06000593 RID: 1427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass87_1()
		{
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GetActionChance>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	private sealed class <>c__DisplayClass87_2
	{
		// Token: 0x06000595 RID: 1429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass87_2()
		{
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GetActionChance>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	private sealed class <>c__DisplayClass87_3
	{
		// Token: 0x06000597 RID: 1431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass87_3()
		{
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GetActionChance>b__3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}
}
