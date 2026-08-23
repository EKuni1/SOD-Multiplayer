using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x02000979 RID: 2425
	[Token(Token = "0x2000979")]
	public class EightPlayersExample_Player : MonoBehaviour
	{
		// Token: 0x06003407 RID: 13319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003407")]
		[Address(RVA = "0xD4A010", Offset = "0xD49010", VA = "0x180D4A010")]
		private void Awake()
		{
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003408")]
		[Address(RVA = "0xD4A0A0", Offset = "0xD490A0", VA = "0x180D4A0A0")]
		private void Initialize()
		{
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003409")]
		[Address(RVA = "0xD4A160", Offset = "0xD49160", VA = "0x180D4A160")]
		private void Update()
		{
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340A")]
		[Address(RVA = "0xD4A350", Offset = "0xD49350", VA = "0x180D4A350")]
		private void GetInput()
		{
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340B")]
		[Address(RVA = "0xD4A400", Offset = "0xD49400", VA = "0x180D4A400")]
		private void ProcessInput()
		{
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340C")]
		[Address(RVA = "0xD4A8D0", Offset = "0xD498D0", VA = "0x180D4A8D0")]
		public EightPlayersExample_Player()
		{
		}

		// Token: 0x0400508E RID: 20622
		[Token(Token = "0x400508E")]
		[FieldOffset(Offset = "0x18")]
		public int playerId;

		// Token: 0x0400508F RID: 20623
		[Token(Token = "0x400508F")]
		[FieldOffset(Offset = "0x1C")]
		public float moveSpeed;

		// Token: 0x04005090 RID: 20624
		[Token(Token = "0x4005090")]
		[FieldOffset(Offset = "0x20")]
		public float bulletSpeed;

		// Token: 0x04005091 RID: 20625
		[Token(Token = "0x4005091")]
		[FieldOffset(Offset = "0x28")]
		public GameObject bulletPrefab;

		// Token: 0x04005092 RID: 20626
		[Token(Token = "0x4005092")]
		[FieldOffset(Offset = "0x30")]
		private Player player;

		// Token: 0x04005093 RID: 20627
		[Token(Token = "0x4005093")]
		[FieldOffset(Offset = "0x38")]
		private CharacterController cc;

		// Token: 0x04005094 RID: 20628
		[Token(Token = "0x4005094")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 moveVector;

		// Token: 0x04005095 RID: 20629
		[Token(Token = "0x4005095")]
		[FieldOffset(Offset = "0x4C")]
		private bool fire;

		// Token: 0x04005096 RID: 20630
		[Token(Token = "0x4005096")]
		[FieldOffset(Offset = "0x4D")]
		[NonSerialized]
		private bool initialized;
	}
}
