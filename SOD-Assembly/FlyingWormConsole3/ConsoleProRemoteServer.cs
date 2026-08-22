using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FlyingWormConsole3
{
	// Token: 0x02000A30 RID: 2608
	[Token(Token = "0x2000A30")]
	public class ConsoleProRemoteServer : MonoBehaviour
	{
		// Token: 0x0600375A RID: 14170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600375A")]
		[Address(RVA = "0xDF0010", Offset = "0xDEF010", VA = "0x180DF0010")]
		public void Awake()
		{
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600375B")]
		[Address(RVA = "0xDF0070", Offset = "0xDEF070", VA = "0x180DF0070")]
		public ConsoleProRemoteServer()
		{
		}

		// Token: 0x04005543 RID: 21827
		[Token(Token = "0x4005543")]
		[FieldOffset(Offset = "0x18")]
		public bool useNATPunch;

		// Token: 0x04005544 RID: 21828
		[Token(Token = "0x4005544")]
		[FieldOffset(Offset = "0x1C")]
		public int port;
	}
}
