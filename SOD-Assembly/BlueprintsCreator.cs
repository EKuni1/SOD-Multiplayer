using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000186 RID: 390
[Token(Token = "0x2000186")]
public class BlueprintsCreator : Creator
{
	// Token: 0x17000038 RID: 56
	// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000038")]
	public static BlueprintsCreator Instance
	{
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x52F560", Offset = "0x52E560", VA = "0x18052F560")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A05")]
	[Address(RVA = "0x52F5A0", Offset = "0x52E5A0", VA = "0x18052F5A0")]
	private void Awake()
	{
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A06")]
	[Address(RVA = "0x52F8F0", Offset = "0x52E8F0", VA = "0x18052F8F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A07")]
	[Address(RVA = "0x52FB00", Offset = "0x52EB00", VA = "0x18052FB00", Slot = "4")]
	public override void StartLoading()
	{
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A08")]
	[Address(RVA = "0x52FC70", Offset = "0x52EC70", VA = "0x18052FC70")]
	private IEnumerator Load()
	{
		return null;
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A09")]
	[Address(RVA = "0x52EC70", Offset = "0x52DC70", VA = "0x18052EC70")]
	public BlueprintsCreator()
	{
	}

	// Token: 0x04000A2E RID: 2606
	[Token(Token = "0x4000A2E")]
	[FieldOffset(Offset = "0x18")]
	public int loadChunk;

	// Token: 0x04000A2F RID: 2607
	[Token(Token = "0x4000A2F")]
	[FieldOffset(Offset = "0x0")]
	private static BlueprintsCreator _instance;

	// Token: 0x02000187 RID: 391
	[Token(Token = "0x2000187")]
	private sealed class <Load>d__7 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000A0A RID: 2570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Load>d__7(int <>1__state)
		{
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x000066C0 File Offset: 0x000048C0
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x52FD10", Offset = "0x52ED10", VA = "0x18052FD10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000039")]
		private object Current
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x52FF60", Offset = "0x52EF60", VA = "0x18052FF60", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003A")]
		private object Current
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A30 RID: 2608
		[Token(Token = "0x4000A30")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000A31 RID: 2609
		[Token(Token = "0x4000A31")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000A32 RID: 2610
		[Token(Token = "0x4000A32")]
		[FieldOffset(Offset = "0x20")]
		public BlueprintsCreator <>4__this;

		// Token: 0x04000A33 RID: 2611
		[Token(Token = "0x4000A33")]
		[FieldOffset(Offset = "0x28")]
		private int <cursor>5__2;
	}
}
