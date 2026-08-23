using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x02000983 RID: 2435
	[Token(Token = "0x2000983")]
	public class Bullet : MonoBehaviour
	{
		// Token: 0x0600344A RID: 13386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344A")]
		[Address(RVA = "0xD51E20", Offset = "0xD50E20", VA = "0x180D51E20")]
		private void Start()
		{
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344B")]
		[Address(RVA = "0xD51E90", Offset = "0xD50E90", VA = "0x180D51E90")]
		private void Update()
		{
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344C")]
		[Address(RVA = "0xA29F90", Offset = "0xA28F90", VA = "0x180A29F90")]
		public Bullet()
		{
		}

		// Token: 0x040050C6 RID: 20678
		[Token(Token = "0x40050C6")]
		[FieldOffset(Offset = "0x18")]
		public float lifeTime;

		// Token: 0x040050C7 RID: 20679
		[Token(Token = "0x40050C7")]
		[FieldOffset(Offset = "0x1C")]
		private bool die;

		// Token: 0x040050C8 RID: 20680
		[Token(Token = "0x40050C8")]
		[FieldOffset(Offset = "0x20")]
		private float deathTime;
	}
}
