using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008DD RID: 2269
[Token(Token = "0x20008DD")]
public class SkeletonCollisionChecker : MonoBehaviour
{
	// Token: 0x06002AE1 RID: 10977 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002AE1")]
	[Address(RVA = "0xCC52D0", Offset = "0xCC42D0", VA = "0x180CC52D0")]
	private void Start()
	{
	}

	// Token: 0x06002AE2 RID: 10978 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002AE2")]
	[Address(RVA = "0xCC5380", Offset = "0xCC4380", VA = "0x180CC5380")]
	private IEnumerator CheckCollision()
	{
		return null;
	}

	// Token: 0x06002AE3 RID: 10979 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002AE3")]
	[Address(RVA = "0xCC5420", Offset = "0xCC4420", VA = "0x180CC5420")]
	public SkeletonCollisionChecker()
	{
	}

	// Token: 0x04004B1D RID: 19229
	[Token(Token = "0x4004B1D")]
	[FieldOffset(Offset = "0x18")]
	public float delay;

	// Token: 0x04004B1E RID: 19230
	[Token(Token = "0x4004B1E")]
	[FieldOffset(Offset = "0x1C")]
	public int iterations;

	// Token: 0x04004B1F RID: 19231
	[Token(Token = "0x4004B1F")]
	[FieldOffset(Offset = "0x20")]
	public MeshCollider meshCollider;

	// Token: 0x04004B20 RID: 19232
	[Token(Token = "0x4004B20")]
	[FieldOffset(Offset = "0x28")]
	public LayerMask collisionMask;

	// Token: 0x04004B21 RID: 19233
	[Token(Token = "0x4004B21")]
	[FieldOffset(Offset = "0x30")]
	public CorpseCollisionCorrection corpseCollisionCorrection;

	// Token: 0x020008DE RID: 2270
	[Token(Token = "0x20008DE")]
	private sealed class <CheckCollision>d__6 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06002AE4 RID: 10980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE4")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <CheckCollision>d__6(int <>1__state)
		{
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x000100C8 File Offset: 0x0000E2C8
		[Token(Token = "0x6002AE6")]
		[Address(RVA = "0xCC5480", Offset = "0xCC4480", VA = "0x180CC5480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700015C")]
		private object Current
		{
			[Token(Token = "0x6002AE7")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE8")]
		[Address(RVA = "0xCC5E20", Offset = "0xCC4E20", VA = "0x180CC5E20", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700015D")]
		private object Current
		{
			[Token(Token = "0x6002AE9")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04004B22 RID: 19234
		[Token(Token = "0x4004B22")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04004B23 RID: 19235
		[Token(Token = "0x4004B23")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04004B24 RID: 19236
		[Token(Token = "0x4004B24")]
		[FieldOffset(Offset = "0x20")]
		public SkeletonCollisionChecker <>4__this;

		// Token: 0x04004B25 RID: 19237
		[Token(Token = "0x4004B25")]
		[FieldOffset(Offset = "0x28")]
		private int <i>5__2;
	}
}
