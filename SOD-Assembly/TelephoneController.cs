using System;
using System.Collections.Generic;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200017C RID: 380
[Token(Token = "0x200017C")]
public class TelephoneController : MonoBehaviour
{
	// Token: 0x1400000D RID: 13
	// (add) Token: 0x060009D5 RID: 2517 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060009D6 RID: 2518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400000D")]
	public event TelephoneController.PlayerCall OnPlayerCall
	{
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x527170", Offset = "0x526170", VA = "0x180527170")]
		add
		{
		}
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x527260", Offset = "0x526260", VA = "0x180527260")]
		remove
		{
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060009D7 RID: 2519 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000033")]
	public static TelephoneController Instance
	{
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x527350", Offset = "0x526350", VA = "0x180527350")]
		get
		{
			return null;
		}
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x527390", Offset = "0x526390", VA = "0x180527390")]
	private void Awake()
	{
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009D9")]
	[Address(RVA = "0x5276E0", Offset = "0x5266E0", VA = "0x1805276E0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009DA")]
	[Address(RVA = "0x5278F0", Offset = "0x5268F0", VA = "0x1805278F0")]
	public TelephoneController.PhoneCall CreateNewCall(int from, int to, Human caller, Human intendedReceiver, TelephoneController.CallSource callSource, float maxRingTime = 0.1f, bool specificRecevier = false)
	{
		return null;
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009DB")]
	[Address(RVA = "0x527A80", Offset = "0x526A80", VA = "0x180527A80")]
	public TelephoneController.PhoneCall CreateNewCall(Telephone from, Telephone to, Human caller, Human intendedReceiver, TelephoneController.CallSource callSource, float maxRingTime = 0.1f, bool specificRecevier = false)
	{
		return null;
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DC")]
	[Address(RVA = "0x528560", Offset = "0x527560", VA = "0x180528560")]
	public void OnPlayerCalls()
	{
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DD")]
	[Address(RVA = "0x528580", Offset = "0x527580", VA = "0x180528580")]
	public void AddFakeNumber(int number, TelephoneController.CallSource source)
	{
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DE")]
	[Address(RVA = "0x528650", Offset = "0x527650", VA = "0x180528650")]
	public void RemoveFakeNumber(int number)
	{
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DF")]
	[Address(RVA = "0x5286F0", Offset = "0x5276F0", VA = "0x1805286F0")]
	public void AddActiveCall(TelephoneController.PhoneCall newCall)
	{
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x528960", Offset = "0x527960", VA = "0x180528960")]
	public void RemoveActiveCall(TelephoneController.PhoneCall newCall)
	{
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E1")]
	[Address(RVA = "0x528D20", Offset = "0x527D20", VA = "0x180528D20")]
	private void Update()
	{
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E2")]
	[Address(RVA = "0x529F10", Offset = "0x528F10", VA = "0x180529F10")]
	public void FindTelephoneByNumber()
	{
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E3")]
	[Address(RVA = "0x52A330", Offset = "0x529330", VA = "0x18052A330")]
	public void FindTelephonesAtPlayerLocation()
	{
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E4")]
	[Address(RVA = "0x52A8A0", Offset = "0x5298A0", VA = "0x18052A8A0")]
	public TelephoneController()
	{
	}

	// Token: 0x040009F1 RID: 2545
	[Token(Token = "0x40009F1")]
	[FieldOffset(Offset = "0x18")]
	public List<TelephoneController.PhoneCall> activeCalls;

	// Token: 0x040009F2 RID: 2546
	[Token(Token = "0x40009F2")]
	[FieldOffset(Offset = "0x20")]
	private float gameTimeLastLoop;

	// Token: 0x040009F3 RID: 2547
	[Token(Token = "0x40009F3")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<Interactable, EventInstance> engagedEvents;

	// Token: 0x040009F4 RID: 2548
	[Token(Token = "0x40009F4")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<int, TelephoneController.CallSource> fakeTelephoneDictionary;

	// Token: 0x040009F5 RID: 2549
	[Token(Token = "0x40009F5")]
	[FieldOffset(Offset = "0x38")]
	public int debugNumber;

	// Token: 0x040009F7 RID: 2551
	[Token(Token = "0x40009F7")]
	[FieldOffset(Offset = "0x0")]
	private static TelephoneController _instance;

	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	public enum CallState
	{
		// Token: 0x040009F9 RID: 2553
		[Token(Token = "0x40009F9")]
		dialing,
		// Token: 0x040009FA RID: 2554
		[Token(Token = "0x40009FA")]
		denied,
		// Token: 0x040009FB RID: 2555
		[Token(Token = "0x40009FB")]
		ringing,
		// Token: 0x040009FC RID: 2556
		[Token(Token = "0x40009FC")]
		started,
		// Token: 0x040009FD RID: 2557
		[Token(Token = "0x40009FD")]
		ended
	}

	// Token: 0x0200017E RID: 382
	[Token(Token = "0x200017E")]
	public enum CallType
	{
		// Token: 0x040009FF RID: 2559
		[Token(Token = "0x40009FF")]
		dds,
		// Token: 0x04000A00 RID: 2560
		[Token(Token = "0x4000A00")]
		audioEvent,
		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4000A01")]
		player,
		// Token: 0x04000A02 RID: 2562
		[Token(Token = "0x4000A02")]
		fakeOutbound
	}

	// Token: 0x0200017F RID: 383
	[Token(Token = "0x200017F")]
	[Serializable]
	public class CallSource
	{
		// Token: 0x060009E5 RID: 2533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x52AB20", Offset = "0x529B20", VA = "0x18052AB20")]
		public CallSource(TelephoneController.CallType newType, string newDDS)
		{
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x52AB80", Offset = "0x529B80", VA = "0x18052AB80")]
		public CallSource(TelephoneController.CallType newType, AudioEvent newAudioEvent)
		{
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x52AC70", Offset = "0x529C70", VA = "0x18052AC70")]
		public CallSource(TelephoneController.CallType newType, DialogPreset newGreeting, InteractionController.ConversationType newConvoType = InteractionController.ConversationType.normal)
		{
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x52AE10", Offset = "0x529E10", VA = "0x18052AE10")]
		public CallSource(TelephoneController.CallType newType, DialogPreset newGreeting, SideJob newJob, InteractionController.ConversationType newConvoType = InteractionController.ConversationType.normal)
		{
		}

		// Token: 0x04000A03 RID: 2563
		[Token(Token = "0x4000A03")]
		[FieldOffset(Offset = "0x10")]
		public TelephoneController.CallType callType;

		// Token: 0x04000A04 RID: 2564
		[Token(Token = "0x4000A04")]
		[FieldOffset(Offset = "0x18")]
		public string dds;

		// Token: 0x04000A05 RID: 2565
		[Token(Token = "0x4000A05")]
		[FieldOffset(Offset = "0x20")]
		public string audio;

		// Token: 0x04000A06 RID: 2566
		[Token(Token = "0x4000A06")]
		[FieldOffset(Offset = "0x28")]
		public string dialog;

		// Token: 0x04000A07 RID: 2567
		[Token(Token = "0x4000A07")]
		[FieldOffset(Offset = "0x30")]
		public int job;

		// Token: 0x04000A08 RID: 2568
		[Token(Token = "0x4000A08")]
		[FieldOffset(Offset = "0x34")]
		public InteractionController.ConversationType convoType;

		// Token: 0x04000A09 RID: 2569
		[Token(Token = "0x4000A09")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public AudioEvent audioEvent;

		// Token: 0x04000A0A RID: 2570
		[Token(Token = "0x4000A0A")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public DialogPreset dialogGreeting;
	}

	// Token: 0x02000180 RID: 384
	[Token(Token = "0x2000180")]
	[Serializable]
	public class PhoneCall
	{
		// Token: 0x060009E9 RID: 2537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x52AFC0", Offset = "0x529FC0", VA = "0x18052AFC0")]
		public PhoneCall(Telephone newFrom, Telephone newTo, float newTime, Human newCaller, Human newIntendedReceiver, TelephoneController.CallSource newCallSource, float newMaxRingTime = 0.1f, bool newSpecificRecevier = false)
		{
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x52B3D0", Offset = "0x52A3D0", VA = "0x18052B3D0")]
		public void SetCallState(TelephoneController.CallState newState)
		{
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x52CEF0", Offset = "0x52BEF0", VA = "0x18052CEF0")]
		public void EndCall()
		{
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x52E070", Offset = "0x52D070", VA = "0x18052E070")]
		public void SetupNonSerializedData()
		{
		}

		// Token: 0x04000A0B RID: 2571
		[Token(Token = "0x4000A0B")]
		[FieldOffset(Offset = "0x10")]
		public int from;

		// Token: 0x04000A0C RID: 2572
		[Token(Token = "0x4000A0C")]
		[FieldOffset(Offset = "0x14")]
		public int to;

		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		[FieldOffset(Offset = "0x18")]
		public float time;

		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		[FieldOffset(Offset = "0x1C")]
		public int caller;

		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4000A0F")]
		[FieldOffset(Offset = "0x20")]
		public int receiver;

		// Token: 0x04000A10 RID: 2576
		[Token(Token = "0x4000A10")]
		[FieldOffset(Offset = "0x24")]
		public int intendedReceiver;

		// Token: 0x04000A11 RID: 2577
		[Token(Token = "0x4000A11")]
		[FieldOffset(Offset = "0x28")]
		public TelephoneController.CallSource source;

		// Token: 0x04000A12 RID: 2578
		[Token(Token = "0x4000A12")]
		[FieldOffset(Offset = "0x30")]
		public TelephoneController.CallState previousSate;

		// Token: 0x04000A13 RID: 2579
		[Token(Token = "0x4000A13")]
		[FieldOffset(Offset = "0x34")]
		public TelephoneController.CallState state;

		// Token: 0x04000A14 RID: 2580
		[Token(Token = "0x4000A14")]
		[FieldOffset(Offset = "0x38")]
		public float ringTime;

		// Token: 0x04000A15 RID: 2581
		[Token(Token = "0x4000A15")]
		[FieldOffset(Offset = "0x3C")]
		public bool specRecevier;

		// Token: 0x04000A16 RID: 2582
		[Token(Token = "0x4000A16")]
		[FieldOffset(Offset = "0x40")]
		public float dialingTimer;

		// Token: 0x04000A17 RID: 2583
		[Token(Token = "0x4000A17")]
		[FieldOffset(Offset = "0x44")]
		public float ringDelay;

		// Token: 0x04000A18 RID: 2584
		[Token(Token = "0x4000A18")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Telephone fromNS;

		// Token: 0x04000A19 RID: 2585
		[Token(Token = "0x4000A19")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Telephone toNS;

		// Token: 0x04000A1A RID: 2586
		[Token(Token = "0x4000A1A")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Human callerNS;

		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4000A1B")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Human recevierNS;

		// Token: 0x04000A1C RID: 2588
		[Token(Token = "0x4000A1C")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Human intendedReceiverNS;

		// Token: 0x04000A1D RID: 2589
		[Token(Token = "0x4000A1D")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public AudioController.LoopingSoundInfo lineRingingLoop;

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public AudioController.LoopingSoundInfo lineActiveLoopCaller;

		// Token: 0x04000A1F RID: 2591
		[Token(Token = "0x4000A1F")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public AudioController.LoopingSoundInfo lineActiveLoopReceiver;

		// Token: 0x04000A20 RID: 2592
		[Token(Token = "0x4000A20")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public EventInstance callAudioInstance;

		// Token: 0x04000A21 RID: 2593
		[Token(Token = "0x4000A21")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public EventInstance connecting;

		// Token: 0x04000A22 RID: 2594
		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public EventInstance hangUpCaller;

		// Token: 0x04000A23 RID: 2595
		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public EventInstance hangUpReciever;

		// Token: 0x02000181 RID: 385
		[Token(Token = "0x2000181")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060009EE RID: 2542 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c()
			{
			}

			// Token: 0x060009EF RID: 2543 RVA: 0x00006690 File Offset: 0x00004890
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x52E390", Offset = "0x52D390", VA = "0x18052E390")]
			internal bool <EndCall>b__27_0(NewAIAction item)
			{
				return default(bool);
			}

			// Token: 0x04000A24 RID: 2596
			[Token(Token = "0x4000A24")]
			[FieldOffset(Offset = "0x0")]
			public static readonly TelephoneController.PhoneCall.<>c <>9;

			// Token: 0x04000A25 RID: 2597
			[Token(Token = "0x4000A25")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<NewAIAction> <>9__27_0;
		}
	}

	// Token: 0x02000182 RID: 386
	// (Invoke) Token: 0x060009F1 RID: 2545
	[Token(Token = "0x2000182")]
	public delegate void PlayerCall();
}
