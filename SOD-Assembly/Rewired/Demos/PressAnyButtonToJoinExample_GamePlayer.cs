using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x0200097F RID: 2431
	[Token(Token = "0x200097F")]
	public class PressAnyButtonToJoinExample_GamePlayer : MonoBehaviour
	{
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06003437 RID: 13367 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000532")]
		private Player player
		{
			[Token(Token = "0x6003437")]
			[Address(RVA = "0xD50550", Offset = "0xD4F550", VA = "0x180D50550")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003438")]
		[Address(RVA = "0xD50620", Offset = "0xD4F620", VA = "0x180D50620")]
		private void OnEnable()
		{
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003439")]
		[Address(RVA = "0xD506B0", Offset = "0xD4F6B0", VA = "0x180D506B0")]
		private void Update()
		{
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600343A")]
		[Address(RVA = "0xD50820", Offset = "0xD4F820", VA = "0x180D50820")]
		private void GetInput()
		{
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600343B")]
		[Address(RVA = "0xD508F0", Offset = "0xD4F8F0", VA = "0x180D508F0")]
		private void ProcessInput()
		{
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600343C")]
		[Address(RVA = "0xD4A8D0", Offset = "0xD498D0", VA = "0x180D4A8D0")]
		public PressAnyButtonToJoinExample_GamePlayer()
		{
		}

		// Token: 0x040050B2 RID: 20658
		[Token(Token = "0x40050B2")]
		[FieldOffset(Offset = "0x18")]
		public int playerId;

		// Token: 0x040050B3 RID: 20659
		[Token(Token = "0x40050B3")]
		[FieldOffset(Offset = "0x1C")]
		public float moveSpeed;

		// Token: 0x040050B4 RID: 20660
		[Token(Token = "0x40050B4")]
		[FieldOffset(Offset = "0x20")]
		public float bulletSpeed;

		// Token: 0x040050B5 RID: 20661
		[Token(Token = "0x40050B5")]
		[FieldOffset(Offset = "0x28")]
		public GameObject bulletPrefab;

		// Token: 0x040050B6 RID: 20662
		[Token(Token = "0x40050B6")]
		[FieldOffset(Offset = "0x30")]
		private CharacterController cc;

		// Token: 0x040050B7 RID: 20663
		[Token(Token = "0x40050B7")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 moveVector;

		// Token: 0x040050B8 RID: 20664
		[Token(Token = "0x40050B8")]
		[FieldOffset(Offset = "0x44")]
		private bool fire;
	}
}
