using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x02000980 RID: 2432
	[Token(Token = "0x2000980")]
	public class PressStartToJoinExample_Assigner : MonoBehaviour
	{
		// Token: 0x0600343D RID: 13373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600343D")]
		[Address(RVA = "0xD50DC0", Offset = "0xD4FDC0", VA = "0x180D50DC0")]
		public static Player GetRewiredPlayer(int gamePlayerId)
		{
			return null;
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600343E")]
		[Address(RVA = "0xD510D0", Offset = "0xD500D0", VA = "0x180D510D0")]
		private void Awake()
		{
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600343F")]
		[Address(RVA = "0xD51210", Offset = "0xD50210", VA = "0x180D51210")]
		private void Update()
		{
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003440")]
		[Address(RVA = "0xD51370", Offset = "0xD50370", VA = "0x180D51370")]
		private void AssignNextPlayer(int rewiredPlayerId)
		{
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x00012558 File Offset: 0x00010758
		[Token(Token = "0x6003441")]
		[Address(RVA = "0xD51660", Offset = "0xD50660", VA = "0x180D51660")]
		private int GetNextGamePlayerId()
		{
			return 0;
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003442")]
		[Address(RVA = "0xBAA2A0", Offset = "0xBA92A0", VA = "0x180BAA2A0")]
		public PressStartToJoinExample_Assigner()
		{
		}

		// Token: 0x040050B9 RID: 20665
		[Token(Token = "0x40050B9")]
		[FieldOffset(Offset = "0x0")]
		private static PressStartToJoinExample_Assigner instance;

		// Token: 0x040050BA RID: 20666
		[Token(Token = "0x40050BA")]
		[FieldOffset(Offset = "0x18")]
		public int maxPlayers;

		// Token: 0x040050BB RID: 20667
		[Token(Token = "0x40050BB")]
		[FieldOffset(Offset = "0x20")]
		private List<PressStartToJoinExample_Assigner.PlayerMap> playerMap;

		// Token: 0x040050BC RID: 20668
		[Token(Token = "0x40050BC")]
		[FieldOffset(Offset = "0x28")]
		private int gamePlayerIdCounter;

		// Token: 0x02000981 RID: 2433
		[Token(Token = "0x2000981")]
		private class PlayerMap
		{
			// Token: 0x06003443 RID: 13379 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003443")]
			[Address(RVA = "0xD181C0", Offset = "0xD171C0", VA = "0x180D181C0")]
			public PlayerMap(int rewiredPlayerId, int gamePlayerId)
			{
			}

			// Token: 0x040050BD RID: 20669
			[Token(Token = "0x40050BD")]
			[FieldOffset(Offset = "0x10")]
			public int rewiredPlayerId;

			// Token: 0x040050BE RID: 20670
			[Token(Token = "0x40050BE")]
			[FieldOffset(Offset = "0x14")]
			public int gamePlayerId;
		}
	}
}
