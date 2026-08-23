using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020001A4 RID: 420
[Token(Token = "0x20001A4")]
public class PathCreator : Creator
{
	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700004E")]
	public static PathCreator Instance
	{
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x53D490", Offset = "0x53C490", VA = "0x18053D490")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0x53D4D0", Offset = "0x53C4D0", VA = "0x18053D4D0")]
	private void Awake()
	{
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A80")]
	[Address(RVA = "0x53D820", Offset = "0x53C820", VA = "0x18053D820")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000A81 RID: 2689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A81")]
	[Address(RVA = "0x53DA30", Offset = "0x53CA30", VA = "0x18053DA30", Slot = "4")]
	public override void StartLoading()
	{
	}

	// Token: 0x06000A82 RID: 2690 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A82")]
	[Address(RVA = "0x53DDD0", Offset = "0x53CDD0", VA = "0x18053DDD0")]
	private IEnumerator GenChunk()
	{
		return null;
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A83")]
	[Address(RVA = "0x53DE70", Offset = "0x53CE70", VA = "0x18053DE70")]
	public PathCreator()
	{
	}

	// Token: 0x04000A96 RID: 2710
	[Token(Token = "0x4000A96")]
	[FieldOffset(Offset = "0x18")]
	public int loadChunk;

	// Token: 0x04000A97 RID: 2711
	[Token(Token = "0x4000A97")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<NewNode, List<NewNode>> pathsNeededWalking;

	// Token: 0x04000A98 RID: 2712
	[Token(Token = "0x4000A98")]
	[FieldOffset(Offset = "0x0")]
	private static PathCreator _instance;

	// Token: 0x020001A5 RID: 421
	[Token(Token = "0x20001A5")]
	private sealed class <GenChunk>d__8 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000A84 RID: 2692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <GenChunk>d__8(int <>1__state)
		{
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x000068D0 File Offset: 0x00004AD0
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x53DF90", Offset = "0x53CF90", VA = "0x18053DF90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004F")]
		private object Current
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x53E290", Offset = "0x53D290", VA = "0x18053E290", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000050")]
		private object Current
		{
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A99 RID: 2713
		[Token(Token = "0x4000A99")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000A9A RID: 2714
		[Token(Token = "0x4000A9A")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000A9B RID: 2715
		[Token(Token = "0x4000A9B")]
		[FieldOffset(Offset = "0x20")]
		public PathCreator <>4__this;

		// Token: 0x04000A9C RID: 2716
		[Token(Token = "0x4000A9C")]
		[FieldOffset(Offset = "0x28")]
		private int <pathsProgress>5__2;
	}
}
