using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200018B RID: 395
[Token(Token = "0x200018B")]
public class CalculateNearest : Creator
{
	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700003E")]
	public static CalculateNearest Instance
	{
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x5305E0", Offset = "0x52F5E0", VA = "0x1805305E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A1D")]
	[Address(RVA = "0x530620", Offset = "0x52F620", VA = "0x180530620")]
	private void Awake()
	{
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A1E")]
	[Address(RVA = "0x530970", Offset = "0x52F970", VA = "0x180530970")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A1F")]
	[Address(RVA = "0x530B80", Offset = "0x52FB80", VA = "0x180530B80", Slot = "4")]
	public override void StartLoading()
	{
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A20")]
	[Address(RVA = "0x530BD0", Offset = "0x52FBD0", VA = "0x180530BD0")]
	private IEnumerator GenChunk()
	{
		return null;
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A21")]
	[Address(RVA = "0x530C70", Offset = "0x52FC70", VA = "0x180530C70")]
	public CalculateNearest()
	{
	}

	// Token: 0x04000A3C RID: 2620
	[Token(Token = "0x4000A3C")]
	[FieldOffset(Offset = "0x18")]
	public int loadChunk;

	// Token: 0x04000A3D RID: 2621
	[Token(Token = "0x4000A3D")]
	[FieldOffset(Offset = "0x0")]
	private static CalculateNearest _instance;

	// Token: 0x0200018C RID: 396
	[Token(Token = "0x200018C")]
	private sealed class <GenChunk>d__7 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000A22 RID: 2594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <GenChunk>d__7(int <>1__state)
		{
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x000066F0 File Offset: 0x000048F0
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x530CC0", Offset = "0x52FCC0", VA = "0x180530CC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003F")]
		private object Current
		{
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x530F30", Offset = "0x52FF30", VA = "0x180530F30", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000040")]
		private object Current
		{
			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A3E RID: 2622
		[Token(Token = "0x4000A3E")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000A3F RID: 2623
		[Token(Token = "0x4000A3F")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000A40 RID: 2624
		[Token(Token = "0x4000A40")]
		[FieldOffset(Offset = "0x20")]
		public CalculateNearest <>4__this;

		// Token: 0x04000A41 RID: 2625
		[Token(Token = "0x4000A41")]
		[FieldOffset(Offset = "0x28")]
		private int <cursor>5__2;
	}
}
