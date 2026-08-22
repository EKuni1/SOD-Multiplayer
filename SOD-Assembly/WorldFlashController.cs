using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200054E RID: 1358
[Token(Token = "0x200054E")]
public class WorldFlashController : MonoBehaviour
{
	// Token: 0x06001D75 RID: 7541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D75")]
	[Address(RVA = "0xA2A420", Offset = "0xA29420", VA = "0x180A2A420")]
	public void Flash(int newRepeat)
	{
	}

	// Token: 0x06001D76 RID: 7542 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D76")]
	[Address(RVA = "0xA2A4F0", Offset = "0xA294F0", VA = "0x180A2A4F0")]
	public IEnumerator FlashColour(int newRepeat)
	{
		return null;
	}

	// Token: 0x06001D77 RID: 7543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D77")]
	[Address(RVA = "0xA2A5A0", Offset = "0xA295A0", VA = "0x180A2A5A0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001D78 RID: 7544 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D78")]
	[Address(RVA = "0xA2A8F0", Offset = "0xA298F0", VA = "0x180A2A8F0")]
	public WorldFlashController()
	{
	}

	// Token: 0x0400260C RID: 9740
	[Token(Token = "0x400260C")]
	[FieldOffset(Offset = "0x18")]
	public InteractableController controller;

	// Token: 0x0400260D RID: 9741
	[Token(Token = "0x400260D")]
	[FieldOffset(Offset = "0x20")]
	public MeshRenderer rend;

	// Token: 0x0400260E RID: 9742
	[Token(Token = "0x400260E")]
	[FieldOffset(Offset = "0x28")]
	public Material offMaterial;

	// Token: 0x0400260F RID: 9743
	[Token(Token = "0x400260F")]
	[FieldOffset(Offset = "0x30")]
	public Material onMaterial;

	// Token: 0x04002610 RID: 9744
	[Token(Token = "0x4002610")]
	[FieldOffset(Offset = "0x38")]
	public float speed;

	// Token: 0x04002611 RID: 9745
	[Token(Token = "0x4002611")]
	[FieldOffset(Offset = "0x3C")]
	public bool flashActive;

	// Token: 0x04002612 RID: 9746
	[Token(Token = "0x4002612")]
	[FieldOffset(Offset = "0x40")]
	private int repeat;

	// Token: 0x0200054F RID: 1359
	[Token(Token = "0x200054F")]
	private sealed class <FlashColour>d__8 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001D79 RID: 7545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D79")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <FlashColour>d__8(int <>1__state)
		{
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D7A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0xA2A940", Offset = "0xA29940", VA = "0x180A2A940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E8")]
		private object Current
		{
			[Token(Token = "0x6001D7C")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D7D")]
		[Address(RVA = "0xA2AD40", Offset = "0xA29D40", VA = "0x180A2AD40", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E9")]
		private object Current
		{
			[Token(Token = "0x6001D7E")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002613 RID: 9747
		[Token(Token = "0x4002613")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002614 RID: 9748
		[Token(Token = "0x4002614")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002615 RID: 9749
		[Token(Token = "0x4002615")]
		[FieldOffset(Offset = "0x20")]
		public WorldFlashController <>4__this;

		// Token: 0x04002616 RID: 9750
		[Token(Token = "0x4002616")]
		[FieldOffset(Offset = "0x28")]
		public int newRepeat;

		// Token: 0x04002617 RID: 9751
		[Token(Token = "0x4002617")]
		[FieldOffset(Offset = "0x2C")]
		private int <cycle>5__2;

		// Token: 0x04002618 RID: 9752
		[Token(Token = "0x4002618")]
		[FieldOffset(Offset = "0x30")]
		private float <progress>5__3;
	}
}
