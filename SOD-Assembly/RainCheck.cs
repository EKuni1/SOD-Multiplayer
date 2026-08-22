using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200048C RID: 1164
[Token(Token = "0x200048C")]
public class RainCheck : MonoBehaviour
{
	// Token: 0x06001A84 RID: 6788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A84")]
	[Address(RVA = "0x986830", Offset = "0x985830", VA = "0x180986830")]
	private void Start()
	{
	}

	// Token: 0x06001A85 RID: 6789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A85")]
	[Address(RVA = "0x9868C0", Offset = "0x9858C0", VA = "0x1809868C0")]
	private void OnEnable()
	{
	}

	// Token: 0x06001A86 RID: 6790 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A86")]
	[Address(RVA = "0x986970", Offset = "0x985970", VA = "0x180986970")]
	private IEnumerator DelayedCheck()
	{
		return null;
	}

	// Token: 0x06001A87 RID: 6791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A87")]
	[Address(RVA = "0x986A10", Offset = "0x985A10", VA = "0x180986A10")]
	public RainCheck()
	{
	}

	// Token: 0x04002035 RID: 8245
	[Token(Token = "0x4002035")]
	[FieldOffset(Offset = "0x18")]
	public float DelayInSeconds;

	// Token: 0x04002036 RID: 8246
	[Token(Token = "0x4002036")]
	[FieldOffset(Offset = "0x1C")]
	public float raycastOffset;

	// Token: 0x04002037 RID: 8247
	[Token(Token = "0x4002037")]
	[FieldOffset(Offset = "0x20")]
	public float raycastHeight;

	// Token: 0x04002038 RID: 8248
	[Token(Token = "0x4002038")]
	[FieldOffset(Offset = "0x24")]
	public LayerMask raycastLayerMask;

	// Token: 0x04002039 RID: 8249
	[Token(Token = "0x4002039")]
	[FieldOffset(Offset = "0x28")]
	public Material replacementMaterial;

	// Token: 0x0400203A RID: 8250
	[Token(Token = "0x400203A")]
	[FieldOffset(Offset = "0x30")]
	private Renderer renderer;

	// Token: 0x0200048D RID: 1165
	[Token(Token = "0x200048D")]
	private sealed class <DelayedCheck>d__8 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001A88 RID: 6792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A88")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <DelayedCheck>d__8(int <>1__state)
		{
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A89")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0000C660 File Offset: 0x0000A860
		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x986A70", Offset = "0x985A70", VA = "0x180986A70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000CF")]
		private object Current
		{
			[Token(Token = "0x6001A8B")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A8C")]
		[Address(RVA = "0x986FB0", Offset = "0x985FB0", VA = "0x180986FB0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000D0")]
		private object Current
		{
			[Token(Token = "0x6001A8D")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400203B RID: 8251
		[Token(Token = "0x400203B")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400203C RID: 8252
		[Token(Token = "0x400203C")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400203D RID: 8253
		[Token(Token = "0x400203D")]
		[FieldOffset(Offset = "0x20")]
		public RainCheck <>4__this;
	}
}
