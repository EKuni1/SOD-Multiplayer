using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020001AA RID: 426
[Token(Token = "0x20001AA")]
public class RoomsCreator : Creator
{
	// Token: 0x17000057 RID: 87
	// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000057")]
	public static RoomsCreator Instance
	{
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x5403A0", Offset = "0x53F3A0", VA = "0x1805403A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA6")]
	[Address(RVA = "0x5403E0", Offset = "0x53F3E0", VA = "0x1805403E0")]
	private void Awake()
	{
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA7")]
	[Address(RVA = "0x540730", Offset = "0x53F730", VA = "0x180540730", Slot = "4")]
	public override void StartLoading()
	{
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AA8")]
	[Address(RVA = "0x5407A0", Offset = "0x53F7A0", VA = "0x1805407A0")]
	private IEnumerator Load()
	{
		return null;
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA9")]
	[Address(RVA = "0x52EC70", Offset = "0x52DC70", VA = "0x18052EC70")]
	public RoomsCreator()
	{
	}

	// Token: 0x04000AA9 RID: 2729
	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x18")]
	public int loadChunk;

	// Token: 0x04000AAA RID: 2730
	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x0")]
	private static RoomsCreator _instance;

	// Token: 0x020001AB RID: 427
	[Token(Token = "0x20001AB")]
	private sealed class <Load>d__6 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000AAA RID: 2730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Load>d__6(int <>1__state)
		{
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00006918 File Offset: 0x00004B18
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x540840", Offset = "0x53F840", VA = "0x180540840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000058")]
		private object Current
		{
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x540CD0", Offset = "0x53FCD0", VA = "0x180540CD0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000059")]
		private object Current
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AAB RID: 2731
		[Token(Token = "0x4000AAB")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000AAC RID: 2732
		[Token(Token = "0x4000AAC")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000AAD RID: 2733
		[Token(Token = "0x4000AAD")]
		[FieldOffset(Offset = "0x20")]
		public RoomsCreator <>4__this;

		// Token: 0x04000AAE RID: 2734
		[Token(Token = "0x4000AAE")]
		[FieldOffset(Offset = "0x28")]
		private int <cursor>5__2;
	}
}
