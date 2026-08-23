using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020001B4 RID: 436
[Token(Token = "0x20001B4")]
public class WindowViewpointCreator : Creator
{
	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000064")]
	public static WindowViewpointCreator Instance
	{
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x544A70", Offset = "0x543A70", VA = "0x180544A70")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ADB")]
	[Address(RVA = "0x544AB0", Offset = "0x543AB0", VA = "0x180544AB0")]
	private void Awake()
	{
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ADC")]
	[Address(RVA = "0x544E00", Offset = "0x543E00", VA = "0x180544E00")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ADD")]
	[Address(RVA = "0x545010", Offset = "0x544010", VA = "0x180545010", Slot = "4")]
	public override void StartLoading()
	{
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ADE")]
	[Address(RVA = "0x545080", Offset = "0x544080", VA = "0x180545080")]
	private IEnumerator Load()
	{
		return null;
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ADF")]
	[Address(RVA = "0x545120", Offset = "0x544120", VA = "0x180545120")]
	public WindowViewpointCreator()
	{
	}

	// Token: 0x04000AD0 RID: 2768
	[Token(Token = "0x4000AD0")]
	[FieldOffset(Offset = "0x18")]
	public int loadChunk;

	// Token: 0x04000AD1 RID: 2769
	[Token(Token = "0x4000AD1")]
	[FieldOffset(Offset = "0x0")]
	private static WindowViewpointCreator _instance;

	// Token: 0x020001B5 RID: 437
	[Token(Token = "0x20001B5")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000AE1 RID: 2785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00006990 File Offset: 0x00004B90
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x545220", Offset = "0x544220", VA = "0x180545220")]
		internal bool <Load>b__7_0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04000AD2 RID: 2770
		[Token(Token = "0x4000AD2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly WindowViewpointCreator.<>c <>9;

		// Token: 0x04000AD3 RID: 2771
		[Token(Token = "0x4000AD3")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<NewWall> <>9__7_0;
	}

	// Token: 0x020001B6 RID: 438
	[Token(Token = "0x20001B6")]
	private sealed class <Load>d__7 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000AE3 RID: 2787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Load>d__7(int <>1__state)
		{
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x000069A8 File Offset: 0x00004BA8
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x545260", Offset = "0x544260", VA = "0x180545260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000065")]
		private object Current
		{
			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x5459C0", Offset = "0x5449C0", VA = "0x1805459C0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000066")]
		private object Current
		{
			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AD4 RID: 2772
		[Token(Token = "0x4000AD4")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000AD5 RID: 2773
		[Token(Token = "0x4000AD5")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000AD6 RID: 2774
		[Token(Token = "0x4000AD6")]
		[FieldOffset(Offset = "0x20")]
		public WindowViewpointCreator <>4__this;

		// Token: 0x04000AD7 RID: 2775
		[Token(Token = "0x4000AD7")]
		[FieldOffset(Offset = "0x28")]
		private int <roomCursor>5__2;
	}
}
