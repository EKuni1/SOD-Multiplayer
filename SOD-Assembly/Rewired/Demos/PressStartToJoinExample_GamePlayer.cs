using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x02000982 RID: 2434
	[Token(Token = "0x2000982")]
	public class PressStartToJoinExample_GamePlayer : MonoBehaviour
	{
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06003444 RID: 13380 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000533")]
		private Player player
		{
			[Token(Token = "0x6003444")]
			[Address(RVA = "0xD51670", Offset = "0xD50670", VA = "0x180D51670")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003445")]
		[Address(RVA = "0xD51680", Offset = "0xD50680", VA = "0x180D51680")]
		private void OnEnable()
		{
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003446")]
		[Address(RVA = "0xD51710", Offset = "0xD50710", VA = "0x180D51710")]
		private void Update()
		{
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003447")]
		[Address(RVA = "0xD51880", Offset = "0xD50880", VA = "0x180D51880")]
		private void GetInput()
		{
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003448")]
		[Address(RVA = "0xD51950", Offset = "0xD50950", VA = "0x180D51950")]
		private void ProcessInput()
		{
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003449")]
		[Address(RVA = "0xD4A8D0", Offset = "0xD498D0", VA = "0x180D4A8D0")]
		public PressStartToJoinExample_GamePlayer()
		{
		}

		// Token: 0x040050BF RID: 20671
		[Token(Token = "0x40050BF")]
		[FieldOffset(Offset = "0x18")]
		public int gamePlayerId;

		// Token: 0x040050C0 RID: 20672
		[Token(Token = "0x40050C0")]
		[FieldOffset(Offset = "0x1C")]
		public float moveSpeed;

		// Token: 0x040050C1 RID: 20673
		[Token(Token = "0x40050C1")]
		[FieldOffset(Offset = "0x20")]
		public float bulletSpeed;

		// Token: 0x040050C2 RID: 20674
		[Token(Token = "0x40050C2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject bulletPrefab;

		// Token: 0x040050C3 RID: 20675
		[Token(Token = "0x40050C3")]
		[FieldOffset(Offset = "0x30")]
		private CharacterController cc;

		// Token: 0x040050C4 RID: 20676
		[Token(Token = "0x40050C4")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 moveVector;

		// Token: 0x040050C5 RID: 20677
		[Token(Token = "0x40050C5")]
		[FieldOffset(Offset = "0x44")]
		private bool fire;
	}
}
