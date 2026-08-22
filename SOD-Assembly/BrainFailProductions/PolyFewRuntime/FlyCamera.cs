using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFewRuntime
{
	// Token: 0x020009FE RID: 2558
	[Token(Token = "0x20009FE")]
	public class FlyCamera : MonoBehaviour
	{
		// Token: 0x06003680 RID: 13952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003680")]
		[Address(RVA = "0xD9ACE0", Offset = "0xD99CE0", VA = "0x180D9ACE0")]
		private void Start()
		{
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003681")]
		[Address(RVA = "0xD9AF80", Offset = "0xD99F80", VA = "0x180D9AF80")]
		private void Update()
		{
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x00012CA8 File Offset: 0x00010EA8
		[Token(Token = "0x6003682")]
		[Address(RVA = "0xD9B730", Offset = "0xD9A730", VA = "0x180D9B730")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003683")]
		[Address(RVA = "0xD9B770", Offset = "0xD9A770", VA = "0x180D9B770")]
		public FlyCamera()
		{
		}

		// Token: 0x040053DB RID: 21467
		[Token(Token = "0x40053DB")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		// Token: 0x040053DC RID: 21468
		[Token(Token = "0x40053DC")]
		[FieldOffset(Offset = "0x20")]
		public float distance;

		// Token: 0x040053DD RID: 21469
		[Token(Token = "0x40053DD")]
		[FieldOffset(Offset = "0x24")]
		public float xSpeed;

		// Token: 0x040053DE RID: 21470
		[Token(Token = "0x40053DE")]
		[FieldOffset(Offset = "0x28")]
		public float ySpeed;

		// Token: 0x040053DF RID: 21471
		[Token(Token = "0x40053DF")]
		[FieldOffset(Offset = "0x2C")]
		public float panSpeed;

		// Token: 0x040053E0 RID: 21472
		[Token(Token = "0x40053E0")]
		[FieldOffset(Offset = "0x30")]
		public float yMinLimit;

		// Token: 0x040053E1 RID: 21473
		[Token(Token = "0x40053E1")]
		[FieldOffset(Offset = "0x34")]
		public float yMaxLimit;

		// Token: 0x040053E2 RID: 21474
		[Token(Token = "0x40053E2")]
		[FieldOffset(Offset = "0x38")]
		public float distanceMin;

		// Token: 0x040053E3 RID: 21475
		[Token(Token = "0x40053E3")]
		[FieldOffset(Offset = "0x3C")]
		public float distanceMax;

		// Token: 0x040053E4 RID: 21476
		[Token(Token = "0x40053E4")]
		[FieldOffset(Offset = "0x40")]
		private Rigidbody rigidbody;

		// Token: 0x040053E5 RID: 21477
		[Token(Token = "0x40053E5")]
		[FieldOffset(Offset = "0x48")]
		private float x;

		// Token: 0x040053E6 RID: 21478
		[Token(Token = "0x40053E6")]
		[FieldOffset(Offset = "0x4C")]
		private float y;

		// Token: 0x040053E7 RID: 21479
		[Token(Token = "0x40053E7")]
		[FieldOffset(Offset = "0x0")]
		public static bool deactivated;
	}
}
