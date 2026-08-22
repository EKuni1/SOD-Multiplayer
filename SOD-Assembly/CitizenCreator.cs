using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200018D RID: 397
[Token(Token = "0x200018D")]
public class CitizenCreator : Creator
{
	// Token: 0x17000041 RID: 65
	// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000041")]
	public static CitizenCreator Instance
	{
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x530F80", Offset = "0x52FF80", VA = "0x180530F80")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A29")]
	[Address(RVA = "0x530FC0", Offset = "0x52FFC0", VA = "0x180530FC0")]
	private void Awake()
	{
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A2A")]
	[Address(RVA = "0x531310", Offset = "0x530310", VA = "0x180531310")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A2B")]
	[Address(RVA = "0x531520", Offset = "0x530520", VA = "0x180531520", Slot = "4")]
	public override void StartLoading()
	{
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A2C")]
	[Address(RVA = "0x5315D0", Offset = "0x5305D0", VA = "0x1805315D0")]
	private IEnumerator Populate()
	{
		return null;
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A2D")]
	[Address(RVA = "0x531670", Offset = "0x530670", VA = "0x180531670")]
	public Occupation CreateUnemployed()
	{
		return null;
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A2E")]
	[Address(RVA = "0x5318C0", Offset = "0x5308C0", VA = "0x1805318C0")]
	public Occupation CreateCriminal(OccupationPreset preset)
	{
		return null;
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A2F")]
	[Address(RVA = "0x531AA0", Offset = "0x530AA0", VA = "0x180531AA0")]
	public CitizenCreator()
	{
	}

	// Token: 0x04000A42 RID: 2626
	[Token(Token = "0x4000A42")]
	[FieldOffset(Offset = "0x18")]
	public int loadChunk;

	// Token: 0x04000A43 RID: 2627
	[Token(Token = "0x4000A43")]
	[FieldOffset(Offset = "0x20")]
	public GameObject unemploymentHolder;

	// Token: 0x04000A44 RID: 2628
	[Token(Token = "0x4000A44")]
	[FieldOffset(Offset = "0x28")]
	public GameObject criminalHolder;

	// Token: 0x04000A45 RID: 2629
	[Token(Token = "0x4000A45")]
	[FieldOffset(Offset = "0x30")]
	public OccupationPreset unemployedPreset;

	// Token: 0x04000A46 RID: 2630
	[Token(Token = "0x4000A46")]
	[FieldOffset(Offset = "0x38")]
	public OccupationPreset retiredPreset;

	// Token: 0x04000A47 RID: 2631
	[Token(Token = "0x4000A47")]
	[FieldOffset(Offset = "0x40")]
	public GameObject citizenObj;

	// Token: 0x04000A48 RID: 2632
	[Token(Token = "0x4000A48")]
	[FieldOffset(Offset = "0x48")]
	public Texture agentTexture;

	// Token: 0x04000A49 RID: 2633
	[Token(Token = "0x4000A49")]
	[FieldOffset(Offset = "0x50")]
	public Texture suspectTexture;

	// Token: 0x04000A4A RID: 2634
	[Token(Token = "0x4000A4A")]
	[FieldOffset(Offset = "0x58")]
	public GameObject citizenHolder;

	// Token: 0x04000A4B RID: 2635
	[Token(Token = "0x4000A4B")]
	[FieldOffset(Offset = "0x60")]
	public int rUnemployed;

	// Token: 0x04000A4C RID: 2636
	[Token(Token = "0x4000A4C")]
	[FieldOffset(Offset = "0x64")]
	public int rRetired;

	// Token: 0x04000A4D RID: 2637
	[Token(Token = "0x4000A4D")]
	[FieldOffset(Offset = "0x0")]
	private static CitizenCreator _instance;

	// Token: 0x0200018E RID: 398
	[Token(Token = "0x200018E")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000A31 RID: 2609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00006708 File Offset: 0x00004908
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x531BB0", Offset = "0x530BB0", VA = "0x180531BB0")]
		internal int <Populate>b__17_0(CompanyPreset p1, CompanyPreset p2)
		{
			return 0;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00006720 File Offset: 0x00004920
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x531BF0", Offset = "0x530BF0", VA = "0x180531BF0")]
		internal int <Populate>b__17_1(Citizen p1, Citizen p2)
		{
			return 0;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00006738 File Offset: 0x00004938
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x531C80", Offset = "0x530C80", VA = "0x180531C80")]
		internal bool <Populate>b__17_2(ResidenceController item)
		{
			return default(bool);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00006750 File Offset: 0x00004950
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x531D90", Offset = "0x530D90", VA = "0x180531D90")]
		internal bool <Populate>b__17_3(ResidenceController item)
		{
			return default(bool);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00006768 File Offset: 0x00004968
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x531E10", Offset = "0x530E10", VA = "0x180531E10")]
		internal bool <Populate>b__17_4(ResidenceController item)
		{
			return default(bool);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00006780 File Offset: 0x00004980
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x531E40", Offset = "0x530E40", VA = "0x180531E40")]
		internal bool <Populate>b__17_5(Human item)
		{
			return default(bool);
		}

		// Token: 0x04000A4E RID: 2638
		[Token(Token = "0x4000A4E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CitizenCreator.<>c <>9;

		// Token: 0x04000A4F RID: 2639
		[Token(Token = "0x4000A4F")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<CompanyPreset> <>9__17_0;

		// Token: 0x04000A50 RID: 2640
		[Token(Token = "0x4000A50")]
		[FieldOffset(Offset = "0x10")]
		public static Comparison<Citizen> <>9__17_1;

		// Token: 0x04000A51 RID: 2641
		[Token(Token = "0x4000A51")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<ResidenceController> <>9__17_2;

		// Token: 0x04000A52 RID: 2642
		[Token(Token = "0x4000A52")]
		[FieldOffset(Offset = "0x20")]
		public static Predicate<ResidenceController> <>9__17_3;

		// Token: 0x04000A53 RID: 2643
		[Token(Token = "0x4000A53")]
		[FieldOffset(Offset = "0x28")]
		public static Predicate<ResidenceController> <>9__17_4;

		// Token: 0x04000A54 RID: 2644
		[Token(Token = "0x4000A54")]
		[FieldOffset(Offset = "0x30")]
		public static Predicate<Human> <>9__17_5;
	}

	// Token: 0x0200018F RID: 399
	[Token(Token = "0x200018F")]
	private sealed class <Populate>d__17 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000A38 RID: 2616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Populate>d__17(int <>1__state)
		{
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00006798 File Offset: 0x00004998
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x531E80", Offset = "0x530E80", VA = "0x180531E80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000042")]
		private object Current
		{
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x535ED0", Offset = "0x534ED0", VA = "0x180535ED0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000043")]
		private object Current
		{
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A55 RID: 2645
		[Token(Token = "0x4000A55")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000A56 RID: 2646
		[Token(Token = "0x4000A56")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000A57 RID: 2647
		[Token(Token = "0x4000A57")]
		[FieldOffset(Offset = "0x20")]
		public CitizenCreator <>4__this;

		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4000A58")]
		[FieldOffset(Offset = "0x28")]
		private string <seed>5__2;

		// Token: 0x04000A59 RID: 2649
		[Token(Token = "0x4000A59")]
		[FieldOffset(Offset = "0x30")]
		private int <citCursor>5__3;

		// Token: 0x04000A5A RID: 2650
		[Token(Token = "0x4000A5A")]
		[FieldOffset(Offset = "0x34")]
		private int <employedCitizens>5__4;

		// Token: 0x04000A5B RID: 2651
		[Token(Token = "0x4000A5B")]
		[FieldOffset(Offset = "0x38")]
		private int <unemployedCitizens>5__5;

		// Token: 0x04000A5C RID: 2652
		[Token(Token = "0x4000A5C")]
		[FieldOffset(Offset = "0x3C")]
		private int <citizensOrCouplesToSpawn>5__6;

		// Token: 0x04000A5D RID: 2653
		[Token(Token = "0x4000A5D")]
		[FieldOffset(Offset = "0x40")]
		private List<ResidenceController> <allVacantResidences>5__7;

		// Token: 0x04000A5E RID: 2654
		[Token(Token = "0x4000A5E")]
		[FieldOffset(Offset = "0x48")]
		private int <apartmentCapacity>5__8;

		// Token: 0x04000A5F RID: 2655
		[Token(Token = "0x4000A5F")]
		[FieldOffset(Offset = "0x4C")]
		private int <homelessToSpawn>5__9;

		// Token: 0x04000A60 RID: 2656
		[Token(Token = "0x4000A60")]
		[FieldOffset(Offset = "0x50")]
		private int <totalHomelessToSpawn>5__10;

		// Token: 0x04000A61 RID: 2657
		[Token(Token = "0x4000A61")]
		[FieldOffset(Offset = "0x58")]
		private List<Citizen> <withoutJobs>5__11;

		// Token: 0x04000A62 RID: 2658
		[Token(Token = "0x4000A62")]
		[FieldOffset(Offset = "0x60")]
		private List<Occupation> <freeJobs>5__12;

		// Token: 0x04000A63 RID: 2659
		[Token(Token = "0x4000A63")]
		[FieldOffset(Offset = "0x68")]
		private List<CompanyPreset> <selfEmployedAutoCreate>5__13;

		// Token: 0x04000A64 RID: 2660
		[Token(Token = "0x4000A64")]
		[FieldOffset(Offset = "0x70")]
		private List<ResidenceController> <allInhabitedResidences>5__14;

		// Token: 0x04000A65 RID: 2661
		[Token(Token = "0x4000A65")]
		[FieldOffset(Offset = "0x78")]
		private List<Citizen> <citizensToHouse>5__15;

		// Token: 0x04000A66 RID: 2662
		[Token(Token = "0x4000A66")]
		[FieldOffset(Offset = "0x80")]
		private int <setupPhaseCursor>5__16;

		// Token: 0x04000A67 RID: 2663
		[Token(Token = "0x4000A67")]
		[FieldOffset(Offset = "0x84")]
		private int <populatePhase>5__17;

		// Token: 0x04000A68 RID: 2664
		[Token(Token = "0x4000A68")]
		[FieldOffset(Offset = "0x88")]
		private float <spawnProgress>5__18;

		// Token: 0x04000A69 RID: 2665
		[Token(Token = "0x4000A69")]
		[FieldOffset(Offset = "0x8C")]
		private float <jobProgress>5__19;

		// Token: 0x04000A6A RID: 2666
		[Token(Token = "0x4000A6A")]
		[FieldOffset(Offset = "0x90")]
		private float <housingProgress>5__20;

		// Token: 0x04000A6B RID: 2667
		[Token(Token = "0x4000A6B")]
		[FieldOffset(Offset = "0x94")]
		private float <homelessProgress>5__21;

		// Token: 0x04000A6C RID: 2668
		[Token(Token = "0x4000A6C")]
		[FieldOffset(Offset = "0x98")]
		private float <miscProgress>5__22;
	}
}
