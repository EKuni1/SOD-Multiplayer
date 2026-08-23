using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020001A8 RID: 424
[Token(Token = "0x20001A8")]
public class RelationshipCreator : Creator
{
	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000054")]
	public static RelationshipCreator Instance
	{
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x53F9D0", Offset = "0x53E9D0", VA = "0x18053F9D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A9A")]
	[Address(RVA = "0x53FA10", Offset = "0x53EA10", VA = "0x18053FA10")]
	private void Awake()
	{
	}

	// Token: 0x06000A9B RID: 2715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0x53FD60", Offset = "0x53ED60", VA = "0x18053FD60")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0x53FF70", Offset = "0x53EF70", VA = "0x18053FF70", Slot = "4")]
	public override void StartLoading()
	{
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0x53FFE0", Offset = "0x53EFE0", VA = "0x18053FFE0")]
	private IEnumerator Relationships()
	{
		return null;
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A9E")]
	[Address(RVA = "0x52F510", Offset = "0x52E510", VA = "0x18052F510")]
	public RelationshipCreator()
	{
	}

	// Token: 0x04000AA3 RID: 2723
	[Token(Token = "0x4000AA3")]
	[FieldOffset(Offset = "0x18")]
	public int loadChunk;

	// Token: 0x04000AA4 RID: 2724
	[Token(Token = "0x4000AA4")]
	[FieldOffset(Offset = "0x0")]
	private static RelationshipCreator _instance;

	// Token: 0x020001A9 RID: 425
	[Token(Token = "0x20001A9")]
	private sealed class <Relationships>d__7 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000A9F RID: 2719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Relationships>d__7(int <>1__state)
		{
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00006900 File Offset: 0x00004B00
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x540080", Offset = "0x53F080", VA = "0x180540080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000055")]
		private object Current
		{
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x540350", Offset = "0x53F350", VA = "0x180540350", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000056")]
		private object Current
		{
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AA5 RID: 2725
		[Token(Token = "0x4000AA5")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000AA6 RID: 2726
		[Token(Token = "0x4000AA6")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000AA7 RID: 2727
		[Token(Token = "0x4000AA7")]
		[FieldOffset(Offset = "0x20")]
		public RelationshipCreator <>4__this;

		// Token: 0x04000AA8 RID: 2728
		[Token(Token = "0x4000AA8")]
		[FieldOffset(Offset = "0x28")]
		private int <citizenCursor>5__2;
	}
}
