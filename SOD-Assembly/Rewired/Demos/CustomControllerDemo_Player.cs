using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x02000973 RID: 2419
	[Token(Token = "0x2000973")]
	public class CustomControllerDemo_Player : MonoBehaviour
	{
		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060033E0 RID: 13280 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700052D")]
		private Player player
		{
			[Token(Token = "0x60033E0")]
			[Address(RVA = "0xD46A30", Offset = "0xD45A30", VA = "0x180D46A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E1")]
		[Address(RVA = "0xD46B00", Offset = "0xD45B00", VA = "0x180D46B00")]
		private void Awake()
		{
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E2")]
		[Address(RVA = "0xD46B90", Offset = "0xD45B90", VA = "0x180D46B90")]
		private void Update()
		{
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E3")]
		[Address(RVA = "0xD471F0", Offset = "0xD461F0", VA = "0x180D471F0")]
		public CustomControllerDemo_Player()
		{
		}

		// Token: 0x04005071 RID: 20593
		[Token(Token = "0x4005071")]
		[FieldOffset(Offset = "0x18")]
		public int playerId;

		// Token: 0x04005072 RID: 20594
		[Token(Token = "0x4005072")]
		[FieldOffset(Offset = "0x1C")]
		public float speed;

		// Token: 0x04005073 RID: 20595
		[Token(Token = "0x4005073")]
		[FieldOffset(Offset = "0x20")]
		public float bulletSpeed;

		// Token: 0x04005074 RID: 20596
		[Token(Token = "0x4005074")]
		[FieldOffset(Offset = "0x28")]
		public GameObject bulletPrefab;

		// Token: 0x04005075 RID: 20597
		[Token(Token = "0x4005075")]
		[FieldOffset(Offset = "0x30")]
		private Player _player;

		// Token: 0x04005076 RID: 20598
		[Token(Token = "0x4005076")]
		[FieldOffset(Offset = "0x38")]
		private CharacterController cc;
	}
}
