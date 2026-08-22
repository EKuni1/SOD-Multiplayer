using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000194 RID: 404
[Token(Token = "0x2000194")]
public class InteriorCreator : Creator
{
	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000046")]
	public static InteriorCreator Instance
	{
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x536940", Offset = "0x535940", VA = "0x180536940")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A4A")]
	[Address(RVA = "0x536980", Offset = "0x535980", VA = "0x180536980")]
	private void Awake()
	{
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A4B")]
	[Address(RVA = "0x536CD0", Offset = "0x535CD0", VA = "0x180536CD0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0x536EE0", Offset = "0x535EE0", VA = "0x180536EE0", Slot = "4")]
	public override void StartLoading()
	{
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x536F50", Offset = "0x535F50", VA = "0x180536F50")]
	private IEnumerator GenChunk()
	{
		return null;
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0x536FF0", Offset = "0x535FF0", VA = "0x180536FF0")]
	private IEnumerator ThreadedInteriorGeneration(InteriorCreator.LoaderThread loaderReference)
	{
		return null;
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A4F")]
	[Address(RVA = "0x537100", Offset = "0x536100", VA = "0x180537100")]
	public InteriorCreator()
	{
	}

	// Token: 0x04000A73 RID: 2675
	[Token(Token = "0x4000A73")]
	[FieldOffset(Offset = "0x18")]
	public int loadChunk;

	// Token: 0x04000A74 RID: 2676
	[Token(Token = "0x4000A74")]
	[FieldOffset(Offset = "0x1C")]
	public bool threadedInteriorCreationActive;

	// Token: 0x04000A75 RID: 2677
	[Token(Token = "0x4000A75")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public List<InteriorCreator.LoaderThread> threads;

	// Token: 0x04000A76 RID: 2678
	[Token(Token = "0x4000A76")]
	[FieldOffset(Offset = "0x0")]
	private static InteriorCreator _instance;

	// Token: 0x02000195 RID: 405
	[Token(Token = "0x2000195")]
	public class LoaderThread
	{
		// Token: 0x06000A50 RID: 2640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public LoaderThread()
		{
		}

		// Token: 0x04000A77 RID: 2679
		[Token(Token = "0x4000A77")]
		[FieldOffset(Offset = "0x10")]
		public Coroutine thread;

		// Token: 0x04000A78 RID: 2680
		[Token(Token = "0x4000A78")]
		[FieldOffset(Offset = "0x18")]
		public StreetController street;

		// Token: 0x04000A79 RID: 2681
		[Token(Token = "0x4000A79")]
		[FieldOffset(Offset = "0x20")]
		public NewFloor floor;

		// Token: 0x04000A7A RID: 2682
		[Token(Token = "0x4000A7A")]
		[FieldOffset(Offset = "0x28")]
		public bool isDone;
	}

	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x06000A51 RID: 2641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x000067B0 File Offset: 0x000049B0
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GenChunk>b__0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000A7B RID: 2683
		[Token(Token = "0x4000A7B")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	private sealed class <>c__DisplayClass10_1
	{
		// Token: 0x06000A53 RID: 2643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass10_1()
		{
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000067C8 File Offset: 0x000049C8
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GenChunk>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000A7C RID: 2684
		[Token(Token = "0x4000A7C")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	private sealed class <>c__DisplayClass10_2
	{
		// Token: 0x06000A55 RID: 2645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass10_2()
		{
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x000067E0 File Offset: 0x000049E0
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GenChunk>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000A7D RID: 2685
		[Token(Token = "0x4000A7D")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	private sealed class <>c__DisplayClass10_3
	{
		// Token: 0x06000A57 RID: 2647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass10_3()
		{
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x000067F8 File Offset: 0x000049F8
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GenChunk>b__3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000A7E RID: 2686
		[Token(Token = "0x4000A7E")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x0200019A RID: 410
	[Token(Token = "0x200019A")]
	private sealed class <>c__DisplayClass10_4
	{
		// Token: 0x06000A59 RID: 2649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass10_4()
		{
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00006810 File Offset: 0x00004A10
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x537210", Offset = "0x536210", VA = "0x180537210")]
		internal bool <GenChunk>b__4(Citizen item)
		{
			return default(bool);
		}

		// Token: 0x04000A7F RID: 2687
		[Token(Token = "0x4000A7F")]
		[FieldOffset(Offset = "0x10")]
		public Citizen owner;
	}

	// Token: 0x0200019B RID: 411
	[Token(Token = "0x200019B")]
	private sealed class <>c__DisplayClass10_5
	{
		// Token: 0x06000A5B RID: 2651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass10_5()
		{
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00006828 File Offset: 0x00004A28
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x5373B0", Offset = "0x5363B0", VA = "0x1805373B0")]
		internal bool <GenChunk>b__6(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04000A80 RID: 2688
		[Token(Token = "0x4000A80")]
		[FieldOffset(Offset = "0x10")]
		public FurnitureLocation furniture;
	}

	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	private sealed class <>c__DisplayClass10_6
	{
		// Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass10_6()
		{
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00006840 File Offset: 0x00004A40
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x5373F0", Offset = "0x5363F0", VA = "0x1805373F0")]
		internal bool <GenChunk>b__7(Occupation item)
		{
			return default(bool);
		}

		// Token: 0x04000A81 RID: 2689
		[Token(Token = "0x4000A81")]
		[FieldOffset(Offset = "0x10")]
		public Interactable d;
	}

	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000A60 RID: 2656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00006858 File Offset: 0x00004A58
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x5375F0", Offset = "0x5365F0", VA = "0x1805375F0")]
		internal bool <GenChunk>b__10_5(Occupation item)
		{
			return default(bool);
		}

		// Token: 0x04000A82 RID: 2690
		[Token(Token = "0x4000A82")]
		[FieldOffset(Offset = "0x0")]
		public static readonly InteriorCreator.<>c <>9;

		// Token: 0x04000A83 RID: 2691
		[Token(Token = "0x4000A83")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Occupation> <>9__10_5;
	}

	// Token: 0x0200019E RID: 414
	[Token(Token = "0x200019E")]
	private sealed class <GenChunk>d__10 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000A62 RID: 2658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <GenChunk>d__10(int <>1__state)
		{
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00006870 File Offset: 0x00004A70
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x537800", Offset = "0x536800", VA = "0x180537800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000047")]
		private object Current
		{
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x53B5C0", Offset = "0x53A5C0", VA = "0x18053B5C0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000048")]
		private object Current
		{
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A84 RID: 2692
		[Token(Token = "0x4000A84")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000A85 RID: 2693
		[Token(Token = "0x4000A85")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000A86 RID: 2694
		[Token(Token = "0x4000A86")]
		[FieldOffset(Offset = "0x20")]
		public InteriorCreator <>4__this;

		// Token: 0x04000A87 RID: 2695
		[Token(Token = "0x4000A87")]
		[FieldOffset(Offset = "0x28")]
		private int <cursor>5__2;
	}

	// Token: 0x0200019F RID: 415
	[Token(Token = "0x200019F")]
	private sealed class <>c__DisplayClass11_0
	{
		// Token: 0x06000A68 RID: 2664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass11_0()
		{
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x53B710", Offset = "0x53A710", VA = "0x18053B710")]
		internal void <ThreadedInteriorGeneration>b__0()
		{
		}

		// Token: 0x04000A88 RID: 2696
		[Token(Token = "0x4000A88")]
		[FieldOffset(Offset = "0x10")]
		public InteriorCreator.LoaderThread loaderReference;
	}

	// Token: 0x020001A0 RID: 416
	[Token(Token = "0x20001A0")]
	private sealed class <ThreadedInteriorGeneration>d__11 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000A6A RID: 2666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <ThreadedInteriorGeneration>d__11(int <>1__state)
		{
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00006888 File Offset: 0x00004A88
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x53BF40", Offset = "0x53AF40", VA = "0x18053BF40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000049")]
		private object Current
		{
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x53C460", Offset = "0x53B460", VA = "0x18053C460", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004A")]
		private object Current
		{
			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A89 RID: 2697
		[Token(Token = "0x4000A89")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000A8A RID: 2698
		[Token(Token = "0x4000A8A")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000A8B RID: 2699
		[Token(Token = "0x4000A8B")]
		[FieldOffset(Offset = "0x20")]
		public InteriorCreator.LoaderThread loaderReference;

		// Token: 0x04000A8C RID: 2700
		[Token(Token = "0x4000A8C")]
		[FieldOffset(Offset = "0x28")]
		public InteriorCreator <>4__this;

		// Token: 0x04000A8D RID: 2701
		[Token(Token = "0x4000A8D")]
		[FieldOffset(Offset = "0x30")]
		private InteriorCreator.<>c__DisplayClass11_0 <>8__1;

		// Token: 0x04000A8E RID: 2702
		[Token(Token = "0x4000A8E")]
		[FieldOffset(Offset = "0x38")]
		private Thread <thread>5__2;
	}
}
