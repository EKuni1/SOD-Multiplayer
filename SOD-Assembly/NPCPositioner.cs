using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000030 RID: 48
[Token(Token = "0x2000030")]
public class NPCPositioner : MonoBehaviour
{
	// Token: 0x060001C8 RID: 456 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x5C8AC0", Offset = "0x5C7AC0", VA = "0x1805C8AC0")]
	public IEnumerator RepositionNPC(GameObject GrabbedNPC)
	{
		return null;
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public NPCPositioner()
	{
	}

	// Token: 0x04000110 RID: 272
	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x18")]
	public float GravitationSpeed;

	// Token: 0x04000111 RID: 273
	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PivotPoint;

	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	private sealed class <RepositionNPC>d__2 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <RepositionNPC>d__2(int <>1__state)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x5C8BD0", Offset = "0x5C7BD0", VA = "0x1805C8BD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001E")]
		private object Current
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x5C9090", Offset = "0x5C8090", VA = "0x1805C9090", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001F")]
		private object Current
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x20")]
		public GameObject GrabbedNPC;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x28")]
		public NPCPositioner <>4__this;
	}
}
