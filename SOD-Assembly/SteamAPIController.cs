using System;
using Il2CppDummyDll;
using Steamworks;
using TMPro;
using UnityEngine;

// Token: 0x02000509 RID: 1289
[Token(Token = "0x2000509")]
public class SteamAPIController : MonoBehaviour
{
	// Token: 0x06001BBF RID: 7103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BBF")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public SteamAPIController()
	{
	}

	// Token: 0x04002469 RID: 9321
	[Token(Token = "0x4002469")]
	[FieldOffset(Offset = "0x18")]
	protected Callback<SteamNetworkingIdentity> m_GameOverlayActivated;

	// Token: 0x0400246A RID: 9322
	[Token(Token = "0x400246A")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI steam64IDtext;
}
