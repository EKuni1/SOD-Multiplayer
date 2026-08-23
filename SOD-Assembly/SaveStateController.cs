using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000161 RID: 353
[Token(Token = "0x2000161")]
public class SaveStateController : MonoBehaviour
{
	// Token: 0x17000032 RID: 50
	// (get) Token: 0x06000973 RID: 2419 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000032")]
	public static SaveStateController Instance
	{
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x502420", Offset = "0x501420", VA = "0x180502420")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000974")]
	[Address(RVA = "0x502460", Offset = "0x501460", VA = "0x180502460")]
	private void Awake()
	{
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000975")]
	[Address(RVA = "0x5027B0", Offset = "0x5017B0", VA = "0x1805027B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000976")]
	[Address(RVA = "0x5029C0", Offset = "0x5019C0", VA = "0x1805029C0")]
	public Task CaptureSaveStateAsync(string path, bool isOverwrite = false)
	{
		return null;
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000977")]
	[Address(RVA = "0x502BA0", Offset = "0x501BA0", VA = "0x180502BA0")]
	public void PreLoadCases(ref StateSaveData load)
	{
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000978")]
	[Address(RVA = "0x5041E0", Offset = "0x5031E0", VA = "0x1805041E0")]
	public void LoadSaveState(StateSaveData load)
	{
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000979")]
	[Address(RVA = "0x513330", Offset = "0x512330", VA = "0x180513330")]
	private void LoadJob(SideJob job)
	{
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600097A")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public SaveStateController()
	{
	}

	// Token: 0x040009B9 RID: 2489
	[Token(Token = "0x40009B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SaveStateController _instance;

	// Token: 0x02000162 RID: 354
	[Token(Token = "0x2000162")]
	private sealed class <>c__DisplayClass5_0
	{
		// Token: 0x0600097B RID: 2427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass5_0()
		{
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x513430", Offset = "0x512430", VA = "0x180513430")]
		internal void <CaptureSaveStateAsync>b__1()
		{
		}

		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string path;

		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string jsonString;
	}

	// Token: 0x02000163 RID: 355
	[Token(Token = "0x2000163")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600097E RID: 2430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x000062E8 File Offset: 0x000044E8
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x513660", Offset = "0x512660", VA = "0x180513660")]
		internal bool <CaptureSaveStateAsync>b__5_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x040009BC RID: 2492
		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SaveStateController.<>c <>9;

		// Token: 0x040009BD RID: 2493
		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__5_0;
	}

	// Token: 0x02000164 RID: 356
	[Token(Token = "0x2000164")]
	[StructLayout(3)]
	private struct <CaptureSaveStateAsync>d__5 : IEnumerator<object>
	{
		// Token: 0x06000980 RID: 2432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x513680", Offset = "0x512680", VA = "0x180513680", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x51E730", Offset = "0x51D730", VA = "0x18051E730", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040009BE RID: 2494
		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040009BF RID: 2495
		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		// Token: 0x040009C0 RID: 2496
		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string path;

		// Token: 0x040009C1 RID: 2497
		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isOverwrite;

		// Token: 0x040009C2 RID: 2498
		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SaveStateController.<>c__DisplayClass5_0 <>8__1;

		// Token: 0x040009C3 RID: 2499
		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private StateSaveData <save>5__2;

		// Token: 0x040009C4 RID: 2500
		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Stopwatch <stopWatch>5__3;

		// Token: 0x040009C5 RID: 2501
		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<bool> <>u__1;

		// Token: 0x040009C6 RID: 2502
		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter <>u__2;
	}

	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	private sealed class <>c__DisplayClass7_0
	{
		// Token: 0x06000982 RID: 2434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_0()
		{
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00006300 File Offset: 0x00004500
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x51E890", Offset = "0x51D890", VA = "0x18051E890")]
		internal bool <LoadSaveState>b__0(StreetController item)
		{
			return default(bool);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00006318 File Offset: 0x00004518
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x51E8C0", Offset = "0x51D8C0", VA = "0x18051E8C0")]
		internal bool <LoadSaveState>b__1(Case item)
		{
			return default(bool);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00006330 File Offset: 0x00004530
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x51E8F0", Offset = "0x51D8F0", VA = "0x18051E8F0")]
		internal bool <LoadSaveState>b__24(AirDuctGroup item)
		{
			return default(bool);
		}

		// Token: 0x040009C7 RID: 2503
		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StateSaveData load;
	}

	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	private sealed class <>c__DisplayClass7_1
	{
		// Token: 0x06000986 RID: 2438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000986")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_1()
		{
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00006348 File Offset: 0x00004548
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x51E920", Offset = "0x51D920", VA = "0x18051E920")]
		internal bool <LoadSaveState>b__2(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x040009C8 RID: 2504
		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameplayController.Passcode code;
	}

	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000167")]
	private sealed class <>c__DisplayClass7_2
	{
		// Token: 0x06000988 RID: 2440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_2()
		{
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00006360 File Offset: 0x00004560
		[Token(Token = "0x6000989")]
		[Address(RVA = "0x51E950", Offset = "0x51D950", VA = "0x18051E950")]
		internal bool <LoadSaveState>b__3(StreetController item)
		{
			return default(bool);
		}

		// Token: 0x040009C9 RID: 2505
		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameplayController.EnforcerCall call;
	}

	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	private sealed class <>c__DisplayClass7_3
	{
		// Token: 0x0600098A RID: 2442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_3()
		{
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00006378 File Offset: 0x00004578
		[Token(Token = "0x600098B")]
		[Address(RVA = "0x51E980", Offset = "0x51D980", VA = "0x18051E980")]
		internal bool <LoadSaveState>b__4(SocialControls.SocialCreditBuff item)
		{
			return default(bool);
		}

		// Token: 0x040009CA RID: 2506
		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soc;
	}

	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	private sealed class <>c__DisplayClass7_4
	{
		// Token: 0x0600098C RID: 2444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_4()
		{
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00006390 File Offset: 0x00004590
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <LoadSaveState>b__5(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x040009CB RID: 2507
		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int d;
	}

	// Token: 0x0200016A RID: 362
	[Token(Token = "0x200016A")]
	private sealed class <>c__DisplayClass7_5
	{
		// Token: 0x0600098E RID: 2446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_5()
		{
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000063A8 File Offset: 0x000045A8
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x51E9E0", Offset = "0x51D9E0", VA = "0x18051E9E0")]
		internal bool <LoadSaveState>b__6(NewBuilding item)
		{
			return default(bool);
		}

		// Token: 0x040009CC RID: 2508
		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StateSaveData.BuildingStateSav b;
	}

	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	private sealed class <>c__DisplayClass7_6
	{
		// Token: 0x06000990 RID: 2448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000990")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_6()
		{
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x000063C0 File Offset: 0x000045C0
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x51EA10", Offset = "0x51DA10", VA = "0x18051EA10")]
		internal bool <LoadSaveState>b__7(Company item)
		{
			return default(bool);
		}

		// Token: 0x040009CD RID: 2509
		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StateSaveData.CompanyStateSave c;
	}

	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	private sealed class <>c__DisplayClass7_7
	{
		// Token: 0x06000992 RID: 2450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000992")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_7()
		{
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x000063D8 File Offset: 0x000045D8
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x51EA40", Offset = "0x51DA40", VA = "0x18051EA40")]
		internal bool <LoadSaveState>b__10(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x000063F0 File Offset: 0x000045F0
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x51EAF0", Offset = "0x51DAF0", VA = "0x18051EAF0")]
		internal bool <LoadSaveState>b__14(AIGoalPreset item)
		{
			return default(bool);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00006408 File Offset: 0x00004608
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x51EB70", Offset = "0x51DB70", VA = "0x18051EB70")]
		internal bool <LoadSaveState>b__15(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00006420 File Offset: 0x00004620
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x51EBB0", Offset = "0x51DBB0", VA = "0x18051EBB0")]
		internal bool <LoadSaveState>b__16(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00006438 File Offset: 0x00004638
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x51EBF0", Offset = "0x51DBF0", VA = "0x18051EBF0")]
		internal bool <LoadSaveState>b__17(StreetController item)
		{
			return default(bool);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00006450 File Offset: 0x00004650
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x51EC30", Offset = "0x51DC30", VA = "0x18051EC30")]
		internal bool <LoadSaveState>b__18(GroupsController.SocialGroup item)
		{
			return default(bool);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00006468 File Offset: 0x00004668
		[Token(Token = "0x6000999")]
		[Address(RVA = "0x51EBB0", Offset = "0x51DBB0", VA = "0x18051EBB0")]
		internal bool <LoadSaveState>b__11(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00006480 File Offset: 0x00004680
		[Token(Token = "0x600099A")]
		[Address(RVA = "0x51EBF0", Offset = "0x51DBF0", VA = "0x18051EBF0")]
		internal bool <LoadSaveState>b__12(StreetController item)
		{
			return default(bool);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00006498 File Offset: 0x00004698
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x51EC30", Offset = "0x51DC30", VA = "0x18051EC30")]
		internal bool <LoadSaveState>b__13(GroupsController.SocialGroup item)
		{
			return default(bool);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000064B0 File Offset: 0x000046B0
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x51EC70", Offset = "0x51DC70", VA = "0x18051EC70")]
		internal bool <LoadSaveState>b__8(StreetController item)
		{
			return default(bool);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000064C8 File Offset: 0x000046C8
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x51ECB0", Offset = "0x51DCB0", VA = "0x18051ECB0")]
		internal bool <LoadSaveState>b__9(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x040009CE RID: 2510
		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StateSaveData.CitizenStateSave h;
	}

	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	private sealed class <>c__DisplayClass7_8
	{
		// Token: 0x0600099E RID: 2462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_8()
		{
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000064E0 File Offset: 0x000046E0
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x51ECF0", Offset = "0x51DCF0", VA = "0x18051ECF0")]
		internal bool <LoadSaveState>b__19(GroupsController.SocialGroup item)
		{
			return default(bool);
		}

		// Token: 0x040009CF RID: 2511
		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StateSaveData.AIActionStateSave act;
	}

	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	private sealed class <>c__DisplayClass7_9
	{
		// Token: 0x060009A0 RID: 2464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_9()
		{
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000064F8 File Offset: 0x000046F8
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x51ED20", Offset = "0x51DD20", VA = "0x18051ED20")]
		internal bool <LoadSaveState>b__20(StreetController item)
		{
			return default(bool);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00006510 File Offset: 0x00004710
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x51ED50", Offset = "0x51DD50", VA = "0x18051ED50")]
		internal bool <LoadSaveState>b__21(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x040009D0 RID: 2512
		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StateSaveData.AvoidConfineStateSave d;
	}

	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	private sealed class <>c__DisplayClass7_10
	{
		// Token: 0x060009A3 RID: 2467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_10()
		{
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00006528 File Offset: 0x00004728
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x51ED50", Offset = "0x51DD50", VA = "0x18051ED50")]
		internal bool <LoadSaveState>b__22(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StateSaveData.GuestPassStateSave saveState;
	}

	// Token: 0x02000170 RID: 368
	[Token(Token = "0x2000170")]
	private sealed class <>c__DisplayClass7_11
	{
		// Token: 0x060009A5 RID: 2469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_11()
		{
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00006540 File Offset: 0x00004740
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x51E950", Offset = "0x51D950", VA = "0x18051E950")]
		internal bool <LoadSaveState>b__23(StreetController item)
		{
			return default(bool);
		}

		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StateSaveData.CrimeSceneCleanup cs;
	}

	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	private sealed class <>c__DisplayClass7_12
	{
		// Token: 0x060009A7 RID: 2471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_12()
		{
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00006558 File Offset: 0x00004758
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x51E9E0", Offset = "0x51D9E0", VA = "0x18051E9E0")]
		internal bool <LoadSaveState>b__25(AirDuctGroup item)
		{
			return default(bool);
		}

		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StateSaveData.AirDuctExplorationSave duct;
	}

	// Token: 0x02000172 RID: 370
	[Token(Token = "0x2000172")]
	private sealed class <>c__DisplayClass7_13
	{
		// Token: 0x060009A9 RID: 2473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_13()
		{
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00006570 File Offset: 0x00004770
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <LoadSaveState>b__26(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;
	}

	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	private sealed class <>c__DisplayClass7_14
	{
		// Token: 0x060009AB RID: 2475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_14()
		{
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00006588 File Offset: 0x00004788
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x51ED80", Offset = "0x51DD80", VA = "0x18051ED80")]
		internal bool <LoadSaveState>b__27(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3Int v3;
	}
}
