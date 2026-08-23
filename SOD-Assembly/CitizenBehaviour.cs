using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000BB RID: 187
[Token(Token = "0x20000BB")]
public class CitizenBehaviour : MonoBehaviour
{
	// Token: 0x14000008 RID: 8
	// (add) Token: 0x0600059B RID: 1435 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600059C RID: 1436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000008")]
	public event CitizenBehaviour.GameWorldLoop OnGameWorldLoop
	{
		[Token(Token = "0x600059B")]
		[Address(RVA = "0xDD6120", Offset = "0xDD5120", VA = "0x180DD6120")]
		add
		{
		}
		[Token(Token = "0x600059C")]
		[Address(RVA = "0xDD6220", Offset = "0xDD5220", VA = "0x180DD6220")]
		remove
		{
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x0600059D RID: 1437 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000026")]
	public static CitizenBehaviour Instance
	{
		[Token(Token = "0x600059D")]
		[Address(RVA = "0xDD6320", Offset = "0xDD5320", VA = "0x180DD6320")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600059E")]
	[Address(RVA = "0xDD6360", Offset = "0xDD5360", VA = "0x180DD6360")]
	private void Awake()
	{
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600059F")]
	[Address(RVA = "0xDD66B0", Offset = "0xDD56B0", VA = "0x180DD66B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A0")]
	[Address(RVA = "0xDD68C0", Offset = "0xDD58C0", VA = "0x180DD68C0")]
	public void StartGame()
	{
	}

	// Token: 0x060005A1 RID: 1441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A1")]
	[Address(RVA = "0xDD68D0", Offset = "0xDD58D0", VA = "0x180DD68D0")]
	public void GameSpeedChange()
	{
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A2")]
	[Address(RVA = "0xDD7040", Offset = "0xDD6040", VA = "0x180DD7040")]
	public void RoutineCheck()
	{
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A3")]
	[Address(RVA = "0xDD7550", Offset = "0xDD6550", VA = "0x180DD7550")]
	public void AddToCitizenRenderQueue(Human human)
	{
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A4")]
	[Address(RVA = "0xDD7600", Offset = "0xDD6600", VA = "0x180DD7600")]
	public void RemoveFromCitizenRenderQueue(Human human)
	{
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A5")]
	[Address(RVA = "0xDD7660", Offset = "0xDD6660", VA = "0x180DD7660")]
	private void Update()
	{
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A6")]
	[Address(RVA = "0xDD9530", Offset = "0xDD8530", VA = "0x180DD9530")]
	private void LateUpdate()
	{
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A7")]
	[Address(RVA = "0xDD9F10", Offset = "0xDD8F10", VA = "0x180DD9F10")]
	private void GameWorldCheck()
	{
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A8")]
	[Address(RVA = "0xDE9C70", Offset = "0xDE8C70", VA = "0x180DE9C70")]
	private void UpdateRainHaptics()
	{
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A9")]
	[Address(RVA = "0xDEA200", Offset = "0xDE9200", VA = "0x180DEA200")]
	private void LightLevelLoop()
	{
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005AA")]
	[Address(RVA = "0xDEA410", Offset = "0xDE9410", VA = "0x180DEA410")]
	public void OnHourChange()
	{
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005AB")]
	[Address(RVA = "0xDEA920", Offset = "0xDE9920", VA = "0x180DEA920")]
	public void OnDayChange()
	{
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005AC")]
	[Address(RVA = "0xDEB4E0", Offset = "0xDEA4E0", VA = "0x180DEB4E0")]
	public void UpdateForSale()
	{
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005AD")]
	[Address(RVA = "0xDEC9F0", Offset = "0xDEB9F0", VA = "0x180DEC9F0")]
	public CitizenBehaviour()
	{
	}

	// Token: 0x04000564 RID: 1380
	[Token(Token = "0x4000564")]
	[FieldOffset(Offset = "0x18")]
	public List<NewAIController> veryLowTickRate;

	// Token: 0x04000565 RID: 1381
	[Token(Token = "0x4000565")]
	[FieldOffset(Offset = "0x20")]
	public List<NewAIController> lowTickRate;

	// Token: 0x04000566 RID: 1382
	[Token(Token = "0x4000566")]
	[FieldOffset(Offset = "0x28")]
	public List<NewAIController> mediumTickRate;

	// Token: 0x04000567 RID: 1383
	[Token(Token = "0x4000567")]
	[FieldOffset(Offset = "0x30")]
	public List<NewAIController> highTickRate;

	// Token: 0x04000568 RID: 1384
	[Token(Token = "0x4000568")]
	[FieldOffset(Offset = "0x38")]
	public List<NewAIController> veryHighTickRate;

	// Token: 0x04000569 RID: 1385
	[Token(Token = "0x4000569")]
	[FieldOffset(Offset = "0x40")]
	[NonSerialized]
	public List<NewAIController> updateList;

	// Token: 0x0400056A RID: 1386
	[Token(Token = "0x400056A")]
	[FieldOffset(Offset = "0x48")]
	public int tickCounter;

	// Token: 0x0400056B RID: 1387
	[Token(Token = "0x400056B")]
	[FieldOffset(Offset = "0x4C")]
	public int AITicksPerFrame;

	// Token: 0x0400056C RID: 1388
	[Token(Token = "0x400056C")]
	[FieldOffset(Offset = "0x50")]
	public int executionsThisFrame;

	// Token: 0x0400056D RID: 1389
	[Token(Token = "0x400056D")]
	[FieldOffset(Offset = "0x54")]
	public int aiTickBacklog;

	// Token: 0x0400056E RID: 1390
	[Token(Token = "0x400056E")]
	[FieldOffset(Offset = "0x58")]
	public int visibleHumans;

	// Token: 0x0400056F RID: 1391
	[Token(Token = "0x400056F")]
	[FieldOffset(Offset = "0x5C")]
	public int frequentTickCounter;

	// Token: 0x04000570 RID: 1392
	[Token(Token = "0x4000570")]
	[FieldOffset(Offset = "0x60")]
	private float frequentTick5FPS;

	// Token: 0x04000571 RID: 1393
	[Token(Token = "0x4000571")]
	[FieldOffset(Offset = "0x64")]
	private float frequentTick20FPS;

	// Token: 0x04000572 RID: 1394
	[Token(Token = "0x4000572")]
	[FieldOffset(Offset = "0x68")]
	private float frequentTick50FPS;

	// Token: 0x04000573 RID: 1395
	[Token(Token = "0x4000573")]
	[FieldOffset(Offset = "0x70")]
	private List<LightController> lightUpdateQueue;

	// Token: 0x04000574 RID: 1396
	[Token(Token = "0x4000574")]
	[FieldOffset(Offset = "0x78")]
	public HashSet<Actor> actorsInStealthMode;

	// Token: 0x04000575 RID: 1397
	[Token(Token = "0x4000575")]
	[FieldOffset(Offset = "0x80")]
	private float passiveIncomeTimer;

	// Token: 0x04000576 RID: 1398
	[Token(Token = "0x4000576")]
	[FieldOffset(Offset = "0x84")]
	public bool initialPositioning;

	// Token: 0x04000577 RID: 1399
	[Token(Token = "0x4000577")]
	[FieldOffset(Offset = "0x85")]
	public bool cancelUmbrellaAutoSelect;

	// Token: 0x04000578 RID: 1400
	[Token(Token = "0x4000578")]
	[FieldOffset(Offset = "0x86")]
	private bool umbrellaAutoSelected;

	// Token: 0x04000579 RID: 1401
	[Token(Token = "0x4000579")]
	[FieldOffset(Offset = "0x88")]
	public float triggerHeadache;

	// Token: 0x0400057A RID: 1402
	[Token(Token = "0x400057A")]
	public const float footprintMaxTime = 12f;

	// Token: 0x0400057B RID: 1403
	[Token(Token = "0x400057B")]
	[FieldOffset(Offset = "0x90")]
	public List<NewBuilding> buildingEmissionTexturesToUpdate;

	// Token: 0x0400057C RID: 1404
	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0x98")]
	public float timeOnLastGameWorldUpdate;

	// Token: 0x0400057D RID: 1405
	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x9C")]
	public int loadCitizensPerFrame;

	// Token: 0x0400057E RID: 1406
	[Token(Token = "0x400057E")]
	[FieldOffset(Offset = "0xA0")]
	public HashSet<Human> citizensRenderQueue;

	// Token: 0x0400057F RID: 1407
	[Token(Token = "0x400057F")]
	[FieldOffset(Offset = "0xA8")]
	public List<CitizenBehaviour.Smokestack> smokestacks;

	// Token: 0x04000580 RID: 1408
	[Token(Token = "0x4000580")]
	[FieldOffset(Offset = "0xB0")]
	public List<SceneRecorder> sceneRecorders;

	// Token: 0x04000581 RID: 1409
	[Token(Token = "0x4000581")]
	[FieldOffset(Offset = "0xB8")]
	public List<NewGameLocation> tempEscalationBoost;

	// Token: 0x04000583 RID: 1411
	[Token(Token = "0x4000583")]
	[FieldOffset(Offset = "0x0")]
	private static CitizenBehaviour _instance;

	// Token: 0x04000584 RID: 1412
	[Token(Token = "0x4000584")]
	[FieldOffset(Offset = "0xC8")]
	private List<Interactable> toRemove;

	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	[Serializable]
	public class Smokestack
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public Smokestack()
		{
		}

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x10")]
		public NewBuilding building;

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x18")]
		public float timer;
	}

	// Token: 0x020000BD RID: 189
	// (Invoke) Token: 0x060005B0 RID: 1456
	[Token(Token = "0x20000BD")]
	public delegate void GameWorldLoop();

	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	private sealed class <>c__DisplayClass48_0
	{
		// Token: 0x060005B3 RID: 1459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass48_0()
		{
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x64F390", Offset = "0x64E390", VA = "0x18064F390")]
		internal bool <GameWorldCheck>b__7(NewGameLocation item)
		{
			return default(bool);
		}

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x10")]
		public Case.ResolveQuestion detainQuestion;
	}

	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	private sealed class <>c__DisplayClass48_1
	{
		// Token: 0x060005B5 RID: 1461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass48_1()
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xA3B440", Offset = "0xA3A440", VA = "0x180A3B440")]
		internal bool <GameWorldCheck>b__10(Case.CaseElement item)
		{
			return default(bool);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xA3B440", Offset = "0xA3A440", VA = "0x180A3B440")]
		internal bool <GameWorldCheck>b__11(Case.CaseElement item)
		{
			return default(bool);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xC4F610", Offset = "0xC4E610", VA = "0x180C4F610")]
		internal bool <GameWorldCheck>b__8(GameplayController.History item)
		{
			return default(bool);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00004470 File Offset: 0x00002670
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xA71DE0", Offset = "0xA70DE0", VA = "0x180A71DE0")]
		internal bool <GameWorldCheck>b__9(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x10")]
		public EvidenceTime t;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x18")]
		public Predicate<Case.CaseElement> <>9__10;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x20")]
		public Predicate<Case.CaseElement> <>9__11;
	}

	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	private sealed class <>c__DisplayClass48_2
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass48_2()
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xA3B440", Offset = "0xA3A440", VA = "0x180A3B440")]
		internal bool <GameWorldCheck>b__14(Case.CaseElement item)
		{
			return default(bool);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xA3B440", Offset = "0xA3A440", VA = "0x180A3B440")]
		internal bool <GameWorldCheck>b__15(Case.CaseElement item)
		{
			return default(bool);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xC4F610", Offset = "0xC4E610", VA = "0x180C4F610")]
		internal bool <GameWorldCheck>b__12(GameplayController.History item)
		{
			return default(bool);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xA71DE0", Offset = "0xA70DE0", VA = "0x180A71DE0")]
		internal bool <GameWorldCheck>b__13(InfoWindow item)
		{
			return default(bool);
		}

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x10")]
		public EvidenceDate t;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x18")]
		public Predicate<Case.CaseElement> <>9__14;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x20")]
		public Predicate<Case.CaseElement> <>9__15;
	}

	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	private sealed class <>c__DisplayClass48_3
	{
		// Token: 0x060005BF RID: 1471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass48_3()
		{
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xDF0120", Offset = "0xDEF120", VA = "0x180DF0120")]
		internal bool <GameWorldCheck>b__19(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x10")]
		public Human h;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x18")]
		public Predicate<NewAIGoal> <>9__19;
	}

	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060005C2 RID: 1474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xA12170", Offset = "0xA11170", VA = "0x180A12170")]
		internal int <GameWorldCheck>b__48_0(SceneRecorder p1, SceneRecorder p2)
		{
			return 0;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x957C70", Offset = "0x956C70", VA = "0x180957C70")]
		internal bool <GameWorldCheck>b__48_1(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x957F70", Offset = "0x956F70", VA = "0x180957F70")]
		internal bool <GameWorldCheck>b__48_2(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xDF0340", Offset = "0xDEF340", VA = "0x180DF0340")]
		internal bool <GameWorldCheck>b__48_3(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x79BF30", Offset = "0x79AF30", VA = "0x18079BF30")]
		internal bool <GameWorldCheck>b__48_5(Case.ResolveQuestion item)
		{
			return default(bool);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x7A0B80", Offset = "0x79FB80", VA = "0x1807A0B80")]
		internal bool <GameWorldCheck>b__48_6(Case.ResolveQuestion item)
		{
			return default(bool);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xDF03E0", Offset = "0xDEF3E0", VA = "0x180DF03E0")]
		internal bool <GameWorldCheck>b__48_4(Objective item)
		{
			return default(bool);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xDF0470", Offset = "0xDEF470", VA = "0x180DF0470")]
		internal bool <GameWorldCheck>b__48_16(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x477780", Offset = "0x476780", VA = "0x180477780")]
		internal bool <GameWorldCheck>b__48_17(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x477780", Offset = "0x476780", VA = "0x180477780")]
		internal bool <GameWorldCheck>b__48_18(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xDF04D0", Offset = "0xDEF4D0", VA = "0x180DF04D0")]
		internal bool <GameWorldCheck>b__48_20(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xDF0570", Offset = "0xDEF570", VA = "0x180DF0570")]
		internal bool <GameWorldCheck>b__48_21(Company item)
		{
			return default(bool);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xDF06D0", Offset = "0xDEF6D0", VA = "0x180DF06D0")]
		internal bool <GameWorldCheck>b__48_22(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xDF06D0", Offset = "0xDEF6D0", VA = "0x180DF06D0")]
		internal bool <GameWorldCheck>b__48_23(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xDF06D0", Offset = "0xDEF6D0", VA = "0x180DF06D0")]
		internal bool <GameWorldCheck>b__48_24(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xDF0770", Offset = "0xDEF770", VA = "0x180DF0770")]
		internal bool <GameWorldCheck>b__48_25(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xDF0810", Offset = "0xDEF810", VA = "0x180DF0810")]
		internal bool <GameWorldCheck>b__48_26(Human item)
		{
			return default(bool);
		}

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CitizenBehaviour.<>c <>9;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<SceneRecorder> <>9__48_0;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<Interactable.Passed> <>9__48_1;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<Interactable.Passed> <>9__48_2;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x20")]
		public static Predicate<NewAIAction> <>9__48_3;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x28")]
		public static Predicate<Case.ResolveQuestion> <>9__48_5;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x30")]
		public static Predicate<Case.ResolveQuestion> <>9__48_6;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x38")]
		public static Predicate<Objective> <>9__48_4;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x40")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__48_16;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0x48")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__48_17;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x50")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__48_18;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x58")]
		public static Predicate<NewAIGoal> <>9__48_20;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x60")]
		public static Predicate<Company> <>9__48_21;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x68")]
		public static Predicate<NewAIGoal> <>9__48_22;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0x70")]
		public static Predicate<NewAIGoal> <>9__48_23;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0x78")]
		public static Predicate<NewAIGoal> <>9__48_24;

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x80")]
		public static Predicate<NewAIGoal> <>9__48_25;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x88")]
		public static Predicate<Human> <>9__48_26;
	}

	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	private sealed class <>c__DisplayClass52_0
	{
		// Token: 0x060005D4 RID: 1492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass52_0()
		{
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x4FEAA0", Offset = "0x4FDAA0", VA = "0x1804FEAA0")]
		internal bool <OnDayChange>b__0(EvidenceWitness.DialogOption item)
		{
			return default(bool);
		}

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x10")]
		public DialogPreset dia;
	}

	// Token: 0x020000C4 RID: 196
	[Token(Token = "0x20000C4")]
	private sealed class <>c__DisplayClass53_0
	{
		// Token: 0x060005D6 RID: 1494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass53_0()
		{
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xDF0830", Offset = "0xDEF830", VA = "0x180DF0830")]
		internal bool <UpdateForSale>b__0(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0x10")]
		public ResidenceController r;
	}

	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	private sealed class <>c__DisplayClass53_1
	{
		// Token: 0x060005D8 RID: 1496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass53_1()
		{
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x478670", Offset = "0x477670", VA = "0x180478670")]
		internal bool <UpdateForSale>b__1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x10")]
		public FurniturePreset.SubObject so;
	}
}
