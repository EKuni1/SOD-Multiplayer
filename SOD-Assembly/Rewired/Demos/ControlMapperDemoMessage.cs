using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.UI.ControlMapper;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos
{
	// Token: 0x0200098D RID: 2445
	[Token(Token = "0x200098D")]
	public class ControlMapperDemoMessage : MonoBehaviour
	{
		// Token: 0x0600347C RID: 13436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347C")]
		[Address(RVA = "0xD56AB0", Offset = "0xD55AB0", VA = "0x180D56AB0")]
		private void Awake()
		{
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347D")]
		[Address(RVA = "0xD56E40", Offset = "0xD55E40", VA = "0x180D56E40")]
		private void Start()
		{
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347E")]
		[Address(RVA = "0xD56E50", Offset = "0xD55E50", VA = "0x180D56E50")]
		private void OnControlMapperClosed()
		{
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347F")]
		[Address(RVA = "0xD56FA0", Offset = "0xD55FA0", VA = "0x180D56FA0")]
		private void OnControlMapperOpened()
		{
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003480")]
		[Address(RVA = "0xD57040", Offset = "0xD56040", VA = "0x180D57040")]
		private void SelectDefault()
		{
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003481")]
		[Address(RVA = "0xD572C0", Offset = "0xD562C0", VA = "0x180D572C0")]
		private IEnumerator SelectDefaultDeferred()
		{
			return null;
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003482")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public ControlMapperDemoMessage()
		{
		}

		// Token: 0x040050FF RID: 20735
		[Token(Token = "0x40050FF")]
		[FieldOffset(Offset = "0x18")]
		public ControlMapper controlMapper;

		// Token: 0x04005100 RID: 20736
		[Token(Token = "0x4005100")]
		[FieldOffset(Offset = "0x20")]
		public Selectable defaultSelectable;

		// Token: 0x0200098E RID: 2446
		[Token(Token = "0x200098E")]
		private sealed class <SelectDefaultDeferred>d__7 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x06003483 RID: 13443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003483")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <SelectDefaultDeferred>d__7(int <>1__state)
			{
			}

			// Token: 0x06003484 RID: 13444 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003484")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x06003485 RID: 13445 RVA: 0x000125A0 File Offset: 0x000107A0
			[Token(Token = "0x6003485")]
			[Address(RVA = "0xD57360", Offset = "0xD56360", VA = "0x180D57360", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700053C RID: 1340
			// (get) Token: 0x06003486 RID: 13446 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700053C")]
			private object Current
			{
				[Token(Token = "0x6003486")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003487 RID: 13447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003487")]
			[Address(RVA = "0xD57410", Offset = "0xD56410", VA = "0x180D57410", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x1700053D RID: 1341
			// (get) Token: 0x06003488 RID: 13448 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700053D")]
			private object Current
			{
				[Token(Token = "0x6003488")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04005101 RID: 20737
			[Token(Token = "0x4005101")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04005102 RID: 20738
			[Token(Token = "0x4005102")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04005103 RID: 20739
			[Token(Token = "0x4005103")]
			[FieldOffset(Offset = "0x20")]
			public ControlMapperDemoMessage <>4__this;
		}
	}
}
