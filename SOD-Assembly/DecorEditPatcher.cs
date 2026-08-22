using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005B8 RID: 1464
[Token(Token = "0x20005B8")]
public class DecorEditPatcher : MonoBehaviour
{
	// Token: 0x06002035 RID: 8245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002035")]
	[Address(RVA = "0xAD7460", Offset = "0xAD6460", VA = "0x180AD7460")]
	private void Start()
	{
	}

	// Token: 0x06002036 RID: 8246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002036")]
	[Address(RVA = "0xAD74F0", Offset = "0xAD64F0", VA = "0x180AD74F0")]
	private void Update()
	{
	}

	// Token: 0x06002037 RID: 8247 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002037")]
	[Address(RVA = "0xAD7640", Offset = "0xAD6640", VA = "0x180AD7640")]
	private IEnumerator WindowSwitchFix()
	{
		return null;
	}

	// Token: 0x06002038 RID: 8248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002038")]
	[Address(RVA = "0x545120", Offset = "0x544120", VA = "0x180545120")]
	public DecorEditPatcher()
	{
	}

	// Token: 0x040029D5 RID: 10709
	[Token(Token = "0x40029D5")]
	[FieldOffset(Offset = "0x18")]
	public int FramesUntilReInstigatingInventory;

	// Token: 0x040029D6 RID: 10710
	[Token(Token = "0x40029D6")]
	[FieldOffset(Offset = "0x20")]
	private SessionData sessionData;

	// Token: 0x040029D7 RID: 10711
	[Token(Token = "0x40029D7")]
	[FieldOffset(Offset = "0x28")]
	private Player player;

	// Token: 0x020005B9 RID: 1465
	[Token(Token = "0x20005B9")]
	private sealed class <WindowSwitchFix>d__5 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06002039 RID: 8249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002039")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <WindowSwitchFix>d__5(int <>1__state)
		{
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		[Token(Token = "0x600203B")]
		[Address(RVA = "0xAD76E0", Offset = "0xAD66E0", VA = "0x180AD76E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000110")]
		private object Current
		{
			[Token(Token = "0x600203C")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600203D")]
		[Address(RVA = "0xAD78A0", Offset = "0xAD68A0", VA = "0x180AD78A0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000111")]
		private object Current
		{
			[Token(Token = "0x600203E")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040029D8 RID: 10712
		[Token(Token = "0x40029D8")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040029D9 RID: 10713
		[Token(Token = "0x40029D9")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040029DA RID: 10714
		[Token(Token = "0x40029DA")]
		[FieldOffset(Offset = "0x20")]
		public DecorEditPatcher <>4__this;

		// Token: 0x040029DB RID: 10715
		[Token(Token = "0x40029DB")]
		[FieldOffset(Offset = "0x28")]
		private int <i>5__2;
	}
}
