using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000521 RID: 1313
[Token(Token = "0x2000521")]
public class TwitchOAuthController : MonoBehaviour
{
	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06001C1A RID: 7194 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000DA")]
	public static TwitchOAuthController Instance
	{
		[Token(Token = "0x6001C1A")]
		[Address(RVA = "0x9D1000", Offset = "0x9D0000", VA = "0x1809D1000")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001C1B RID: 7195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C1B")]
	[Address(RVA = "0x9D1040", Offset = "0x9D0040", VA = "0x1809D1040")]
	private void Awake()
	{
	}

	// Token: 0x06001C1C RID: 7196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C1C")]
	[Address(RVA = "0x9D1390", Offset = "0x9D0390", VA = "0x1809D1390")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001C1D RID: 7197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C1D")]
	[Address(RVA = "0x9D15A0", Offset = "0x9D05A0", VA = "0x1809D15A0")]
	private void QueueAuthorizationToken()
	{
	}

	// Token: 0x06001C1E RID: 7198 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C1E")]
	[Address(RVA = "0x9D1650", Offset = "0x9D0650", VA = "0x1809D1650")]
	public string GetAuthToken()
	{
		return null;
	}

	// Token: 0x06001C1F RID: 7199 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001C1F")]
	[Address(RVA = "0x9D16D0", Offset = "0x9D06D0", VA = "0x1809D16D0")]
	public string GetClientID()
	{
		return null;
	}

	// Token: 0x06001C20 RID: 7200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C20")]
	[Address(RVA = "0x9D1760", Offset = "0x9D0760", VA = "0x1809D1760")]
	public void TryTwitchAuthorization()
	{
	}

	// Token: 0x06001C21 RID: 7201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C21")]
	[Address(RVA = "0x9D1770", Offset = "0x9D0770", VA = "0x1809D1770")]
	public void InitiateTwitchAuth()
	{
	}

	// Token: 0x06001C22 RID: 7202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C22")]
	[Address(RVA = "0x9D1E80", Offset = "0x9D0E80", VA = "0x1809D1E80")]
	private void StartLocalWebserver()
	{
	}

	// Token: 0x06001C23 RID: 7203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C23")]
	[Address(RVA = "0x9D20D0", Offset = "0x9D10D0", VA = "0x1809D20D0")]
	private void IncomingHttpRequest(IAsyncResult result)
	{
	}

	// Token: 0x06001C24 RID: 7204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C24")]
	[Address(RVA = "0x9D2690", Offset = "0x9D1690", VA = "0x1809D2690")]
	private void IncomingAuth(IAsyncResult ar)
	{
	}

	// Token: 0x06001C25 RID: 7205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C25")]
	[Address(RVA = "0x9D2C80", Offset = "0x9D1C80", VA = "0x1809D2C80")]
	public TwitchOAuthController()
	{
	}

	// Token: 0x040024EB RID: 9451
	[Token(Token = "0x40024EB")]
	[FieldOffset(Offset = "0x0")]
	private static TwitchOAuthController _instance;

	// Token: 0x040024EC RID: 9452
	[Token(Token = "0x40024EC")]
	private const string TwitchAuthUrl = "https://id.twitch.tv/oauth2/authorize";

	// Token: 0x040024ED RID: 9453
	[Token(Token = "0x40024ED")]
	private const string ClientID = "bq0wyxhwa7xjlyomjjdv2o6wun6l2t";

	// Token: 0x040024EE RID: 9454
	[Token(Token = "0x40024EE")]
	private const string TwitchRedirectURL = "http://localhost:8085/";

	// Token: 0x040024EF RID: 9455
	[Token(Token = "0x40024EF")]
	[FieldOffset(Offset = "0x18")]
	private string _twitchAuthStateVerify;

	// Token: 0x040024F0 RID: 9456
	[Token(Token = "0x40024F0")]
	[FieldOffset(Offset = "0x20")]
	private string _authToken;

	// Token: 0x040024F1 RID: 9457
	[Token(Token = "0x40024F1")]
	[FieldOffset(Offset = "0x28")]
	private Queue<string> _tokenQueue;

	// Token: 0x040024F2 RID: 9458
	[Token(Token = "0x40024F2")]
	[FieldOffset(Offset = "0x30")]
	public bool _hasAuth;

	// Token: 0x040024F3 RID: 9459
	[Token(Token = "0x40024F3")]
	[FieldOffset(Offset = "0x31")]
	private bool _tryingValidation;
}
