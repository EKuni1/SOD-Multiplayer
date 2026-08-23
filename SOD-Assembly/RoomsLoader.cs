using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001AC RID: 428
[Token(Token = "0x20001AC")]
public class RoomsLoader : Creator
{
	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700005A")]
	public static RoomsLoader Instance
	{
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x540D20", Offset = "0x53FD20", VA = "0x180540D20")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AB1")]
	[Address(RVA = "0x540D60", Offset = "0x53FD60", VA = "0x180540D60")]
	private void Awake()
	{
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AB2")]
	[Address(RVA = "0x5410B0", Offset = "0x5400B0", VA = "0x1805410B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0x5412C0", Offset = "0x5402C0", VA = "0x1805412C0", Slot = "4")]
	public override void StartLoading()
	{
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0x541370", Offset = "0x540370", VA = "0x180541370")]
	private IEnumerator Load()
	{
		return null;
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0x541410", Offset = "0x540410", VA = "0x180541410")]
	private IEnumerator ThreadedRoomConnect(RoomsLoader.LoaderThread loaderReference)
	{
		return null;
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AB6")]
	[Address(RVA = "0x541520", Offset = "0x540520", VA = "0x180541520")]
	public RoomsLoader()
	{
	}

	// Token: 0x04000AAF RID: 2735
	[Token(Token = "0x4000AAF")]
	[FieldOffset(Offset = "0x18")]
	public int connectionChunk;

	// Token: 0x04000AB0 RID: 2736
	[Token(Token = "0x4000AB0")]
	[FieldOffset(Offset = "0x1C")]
	public int cullTreeChunk;

	// Token: 0x04000AB1 RID: 2737
	[Token(Token = "0x4000AB1")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public List<RoomsLoader.LoaderThread> threads;

	// Token: 0x04000AB2 RID: 2738
	[Token(Token = "0x4000AB2")]
	[FieldOffset(Offset = "0x0")]
	private static RoomsLoader _instance;

	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	public class LoaderThread
	{
		// Token: 0x06000AB7 RID: 2743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public LoaderThread()
		{
		}

		// Token: 0x04000AB3 RID: 2739
		[Token(Token = "0x4000AB3")]
		[FieldOffset(Offset = "0x10")]
		public Coroutine thread;

		// Token: 0x04000AB4 RID: 2740
		[Token(Token = "0x4000AB4")]
		[FieldOffset(Offset = "0x18")]
		public NewRoom room;

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x20")]
		public bool isDone;
	}

	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	private sealed class <Load>d__10 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000AB8 RID: 2744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Load>d__10(int <>1__state)
		{
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00006930 File Offset: 0x00004B30
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x541630", Offset = "0x540630", VA = "0x180541630", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005B")]
		private object Current
		{
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x542B00", Offset = "0x541B00", VA = "0x180542B00", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005C")]
		private object Current
		{
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000AB7 RID: 2743
		[Token(Token = "0x4000AB7")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000AB8 RID: 2744
		[Token(Token = "0x4000AB8")]
		[FieldOffset(Offset = "0x20")]
		public RoomsLoader <>4__this;

		// Token: 0x04000AB9 RID: 2745
		[Token(Token = "0x4000AB9")]
		[FieldOffset(Offset = "0x28")]
		private int <cursor>5__2;

		// Token: 0x04000ABA RID: 2746
		[Token(Token = "0x4000ABA")]
		[FieldOffset(Offset = "0x2C")]
		private int <phase2Chunk>5__3;
	}

	// Token: 0x020001AF RID: 431
	[Token(Token = "0x20001AF")]
	private sealed class <>c__DisplayClass11_0
	{
		// Token: 0x06000ABE RID: 2750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass11_0()
		{
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x542B50", Offset = "0x541B50", VA = "0x180542B50")]
		internal void <ThreadedRoomConnect>b__0()
		{
		}

		// Token: 0x04000ABB RID: 2747
		[Token(Token = "0x4000ABB")]
		[FieldOffset(Offset = "0x10")]
		public NewRoom room;

		// Token: 0x04000ABC RID: 2748
		[Token(Token = "0x4000ABC")]
		[FieldOffset(Offset = "0x18")]
		public RoomsLoader.LoaderThread loaderReference;
	}

	// Token: 0x020001B0 RID: 432
	[Token(Token = "0x20001B0")]
	private sealed class <ThreadedRoomConnect>d__11 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000AC0 RID: 2752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <ThreadedRoomConnect>d__11(int <>1__state)
		{
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00006948 File Offset: 0x00004B48
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x542B90", Offset = "0x541B90", VA = "0x180542B90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005D")]
		private object Current
		{
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x5430E0", Offset = "0x5420E0", VA = "0x1805430E0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005E")]
		private object Current
		{
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4000ABD")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000ABE RID: 2750
		[Token(Token = "0x4000ABE")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000ABF RID: 2751
		[Token(Token = "0x4000ABF")]
		[FieldOffset(Offset = "0x20")]
		public RoomsLoader.LoaderThread loaderReference;

		// Token: 0x04000AC0 RID: 2752
		[Token(Token = "0x4000AC0")]
		[FieldOffset(Offset = "0x28")]
		public RoomsLoader <>4__this;

		// Token: 0x04000AC1 RID: 2753
		[Token(Token = "0x4000AC1")]
		[FieldOffset(Offset = "0x30")]
		private RoomsLoader.<>c__DisplayClass11_0 <>8__1;

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4000AC2")]
		[FieldOffset(Offset = "0x38")]
		private Thread <thread>5__2;
	}
}
