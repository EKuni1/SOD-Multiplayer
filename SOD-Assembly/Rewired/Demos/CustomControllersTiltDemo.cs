using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x02000971 RID: 2417
	[Token(Token = "0x2000971")]
	public class CustomControllersTiltDemo : MonoBehaviour
	{
		// Token: 0x060033D1 RID: 13265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D1")]
		[Address(RVA = "0xD450C0", Offset = "0xD440C0", VA = "0x180D450C0")]
		private void Awake()
		{
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D2")]
		[Address(RVA = "0xD45410", Offset = "0xD44410", VA = "0x180D45410")]
		private void Update()
		{
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D3")]
		[Address(RVA = "0xD456E0", Offset = "0xD446E0", VA = "0x180D456E0")]
		private void OnInputUpdate()
		{
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D4")]
		[Address(RVA = "0xD457A0", Offset = "0xD447A0", VA = "0x180D457A0")]
		public CustomControllersTiltDemo()
		{
		}

		// Token: 0x04005062 RID: 20578
		[Token(Token = "0x4005062")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		// Token: 0x04005063 RID: 20579
		[Token(Token = "0x4005063")]
		[FieldOffset(Offset = "0x20")]
		public float speed;

		// Token: 0x04005064 RID: 20580
		[Token(Token = "0x4005064")]
		[FieldOffset(Offset = "0x28")]
		private CustomController controller;

		// Token: 0x04005065 RID: 20581
		[Token(Token = "0x4005065")]
		[FieldOffset(Offset = "0x30")]
		private Player player;
	}
}
