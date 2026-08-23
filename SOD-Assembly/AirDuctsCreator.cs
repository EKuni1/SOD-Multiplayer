using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000183 RID: 387
[Token(Token = "0x2000183")]
public class AirDuctsCreator : Creator
{
	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000034")]
	public static AirDuctsCreator Instance
	{
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x52E580", Offset = "0x52D580", VA = "0x18052E580")]
		get
		{
			return null;
		}
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009F5")]
	[Address(RVA = "0x52E5C0", Offset = "0x52D5C0", VA = "0x18052E5C0")]
	private void Awake()
	{
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009F6")]
	[Address(RVA = "0x52E910", Offset = "0x52D910", VA = "0x18052E910")]
	private void OnDestroy()
	{
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009F7")]
	[Address(RVA = "0x52EB20", Offset = "0x52DB20", VA = "0x18052EB20", Slot = "4")]
	public override void StartLoading()
	{
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009F8")]
	[Address(RVA = "0x52EBD0", Offset = "0x52DBD0", VA = "0x18052EBD0")]
	private IEnumerator Load()
	{
		return null;
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009F9")]
	[Address(RVA = "0x52EC70", Offset = "0x52DC70", VA = "0x18052EC70")]
	public AirDuctsCreator()
	{
	}

	// Token: 0x04000A26 RID: 2598
	[Token(Token = "0x4000A26")]
	[FieldOffset(Offset = "0x18")]
	public int loadChunk;

	// Token: 0x04000A27 RID: 2599
	[Token(Token = "0x4000A27")]
	[FieldOffset(Offset = "0x0")]
	private static AirDuctsCreator _instance;

	// Token: 0x02000184 RID: 388
	[Token(Token = "0x2000184")]
	private sealed class <Load>d__7 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060009FA RID: 2554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Load>d__7(int <>1__state)
		{
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000066A8 File Offset: 0x000048A8
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x52ECC0", Offset = "0x52DCC0", VA = "0x18052ECC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000035")]
		private object Current
		{
			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x52F0C0", Offset = "0x52E0C0", VA = "0x18052F0C0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000036")]
		private object Current
		{
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A28 RID: 2600
		[Token(Token = "0x4000A28")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000A29 RID: 2601
		[Token(Token = "0x4000A29")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000A2A RID: 2602
		[Token(Token = "0x4000A2A")]
		[FieldOffset(Offset = "0x20")]
		public AirDuctsCreator <>4__this;

		// Token: 0x04000A2B RID: 2603
		[Token(Token = "0x4000A2B")]
		[FieldOffset(Offset = "0x28")]
		private int <cursor>5__2;
	}
}
