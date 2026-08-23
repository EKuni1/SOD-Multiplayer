using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000510 RID: 1296
[Token(Token = "0x2000510")]
public class StreamingOptionsController : MonoBehaviour
{
	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000D7")]
	public static StreamingOptionsController Instance
	{
		[Token(Token = "0x6001BE0")]
		[Address(RVA = "0x9C9190", Offset = "0x9C8190", VA = "0x1809C9190")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001BE1 RID: 7137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BE1")]
	[Address(RVA = "0x9C91D0", Offset = "0x9C81D0", VA = "0x1809C91D0")]
	private void Awake()
	{
	}

	// Token: 0x06001BE2 RID: 7138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BE2")]
	[Address(RVA = "0x9C9520", Offset = "0x9C8520", VA = "0x1809C9520")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001BE3 RID: 7139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BE3")]
	[Address(RVA = "0x9C9730", Offset = "0x9C8730", VA = "0x1809C9730")]
	private void Start()
	{
	}

	// Token: 0x06001BE4 RID: 7140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BE4")]
	[Address(RVA = "0x9C9890", Offset = "0x9C8890", VA = "0x1809C9890")]
	private void OnDisable()
	{
	}

	// Token: 0x06001BE5 RID: 7141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BE5")]
	[Address(RVA = "0x9C98E0", Offset = "0x9C88E0", VA = "0x1809C98E0")]
	private void Update()
	{
	}

	// Token: 0x06001BE6 RID: 7142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BE6")]
	[Address(RVA = "0x9C9BE0", Offset = "0x9C8BE0", VA = "0x1809C9BE0")]
	public void OnConnectButton()
	{
	}

	// Token: 0x06001BE7 RID: 7143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BE7")]
	[Address(RVA = "0x9C9D70", Offset = "0x9C8D70", VA = "0x1809C9D70")]
	public void OnAuthChange()
	{
	}

	// Token: 0x06001BE8 RID: 7144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BE8")]
	[Address(RVA = "0x9C9F40", Offset = "0x9C8F40", VA = "0x1809C9F40")]
	public void ResetTwitchAuthFlushGeneratedData()
	{
	}

	// Token: 0x06001BE9 RID: 7145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BE9")]
	[Address(RVA = "0x9CA140", Offset = "0x9C9140", VA = "0x1809CA140")]
	private void ForceTwitchAudienceCitizensToOff()
	{
	}

	// Token: 0x06001BEA RID: 7146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BEA")]
	[Address(RVA = "0x9CA3D0", Offset = "0x9C93D0", VA = "0x1809CA3D0")]
	public void SetEnableTwitchAudienceCitizens(bool val)
	{
	}

	// Token: 0x06001BEB RID: 7147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BEB")]
	[Address(RVA = "0x9CA720", Offset = "0x9C9720", VA = "0x1809CA720")]
	public void SetUpdateFrequency(int val)
	{
	}

	// Token: 0x06001BEC RID: 7148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BEC")]
	[Address(RVA = "0x9CA730", Offset = "0x9C9730", VA = "0x1809CA730")]
	public void UpdateTwitchCitizens()
	{
	}

	// Token: 0x06001BED RID: 7149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BED")]
	[Address(RVA = "0x9CA900", Offset = "0x9C9900", VA = "0x1809CA900")]
	private void AddUsersDataToNamePool(TwitchRootObject userData)
	{
	}

	// Token: 0x06001BEE RID: 7150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BEE")]
	[Address(RVA = "0x9CAA90", Offset = "0x9C9A90", VA = "0x1809CAA90")]
	private void FinalizeNamePool()
	{
	}

	// Token: 0x06001BEF RID: 7151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BEF")]
	[Address(RVA = "0x9CAD30", Offset = "0x9C9D30", VA = "0x1809CAD30")]
	private void ProcessNamePool()
	{
	}

	// Token: 0x06001BF0 RID: 7152 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
	[Token(Token = "0x6001BF0")]
	[Address(RVA = "0x9CB8D0", Offset = "0x9CA8D0", VA = "0x1809CB8D0")]
	public UniTask<bool> ValidateTokenUpdated()
	{
		return default(UniTask<bool>);
	}

	// Token: 0x06001BF1 RID: 7153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BF1")]
	[Address(RVA = "0x9CBA50", Offset = "0x9CAA50", VA = "0x1809CBA50")]
	public void SetStatusText(string newText)
	{
	}

	// Token: 0x06001BF2 RID: 7154 RVA: 0x0000CC00 File Offset: 0x0000AE00
	[Token(Token = "0x6001BF2")]
	[Address(RVA = "0x9CBB10", Offset = "0x9CAB10", VA = "0x1809CBB10")]
	public UniTask GetChattersUpdated()
	{
		return default(UniTask);
	}

	// Token: 0x06001BF3 RID: 7155 RVA: 0x0000CC18 File Offset: 0x0000AE18
	[Token(Token = "0x6001BF3")]
	[Address(RVA = "0x9CBC50", Offset = "0x9CAC50", VA = "0x1809CBC50")]
	public UniTask GetModeratorsUpdated()
	{
		return default(UniTask);
	}

	// Token: 0x06001BF4 RID: 7156 RVA: 0x0000CC30 File Offset: 0x0000AE30
	[Token(Token = "0x6001BF4")]
	[Address(RVA = "0x9CBD90", Offset = "0x9CAD90", VA = "0x1809CBD90")]
	public UniTask GetVipsUpdated()
	{
		return default(UniTask);
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BF5")]
	[Address(RVA = "0x9CBED0", Offset = "0x9CAED0", VA = "0x1809CBED0")]
	private IEnumerator GrabKnownOnlineBots()
	{
		return null;
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x0000CC48 File Offset: 0x0000AE48
	[Token(Token = "0x6001BF6")]
	[Address(RVA = "0x9CBF70", Offset = "0x9CAF70", VA = "0x1809CBF70")]
	private bool TryAddCustomName(string input)
	{
		return default(bool);
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BF7")]
	[Address(RVA = "0x9CCB00", Offset = "0x9CBB00", VA = "0x1809CCB00")]
	public void ParseNamesFromNameList()
	{
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BF8")]
	[Address(RVA = "0x9CCD40", Offset = "0x9CBD40", VA = "0x1809CCD40")]
	public StreamingOptionsController()
	{
	}

	// Token: 0x04002492 RID: 9362
	[Token(Token = "0x4002492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool enableTwitchAudienceCitizens;

	// Token: 0x04002493 RID: 9363
	[Token(Token = "0x4002493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int updateFrequency;

	// Token: 0x04002494 RID: 9364
	[Token(Token = "0x4002494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int maxListCount;

	// Token: 0x04002495 RID: 9365
	[Token(Token = "0x4002495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI twitchConnectStatusText;

	// Token: 0x04002496 RID: 9366
	[Token(Token = "0x4002496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ButtonController connectToTwitchButton;

	// Token: 0x04002497 RID: 9367
	[Token(Token = "0x4002497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ToggleController enableTwitchAudienceToggle;

	// Token: 0x04002498 RID: 9368
	[Token(Token = "0x4002498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI citizenUpdateText;

	// Token: 0x04002499 RID: 9369
	[Token(Token = "0x4002499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<ButtonController> disabledIfNoConnection;

	// Token: 0x0400249A RID: 9370
	[Token(Token = "0x400249A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool grabbedAudience;

	// Token: 0x0400249B RID: 9371
	[Token(Token = "0x400249B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool grabbingAudenceInProgress;

	// Token: 0x0400249C RID: 9372
	[Token(Token = "0x400249C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	public bool loginNameSet;

	// Token: 0x0400249D RID: 9373
	[Token(Token = "0x400249D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TwitchAudienceData audienceData;

	// Token: 0x0400249E RID: 9374
	[Token(Token = "0x400249E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float autoUpdateTime;

	// Token: 0x0400249F RID: 9375
	[Token(Token = "0x400249F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<CitizenReplacement> customNames;

	// Token: 0x040024A0 RID: 9376
	[Token(Token = "0x40024A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<CitizenReplacement> customNamesReserves;

	// Token: 0x040024A1 RID: 9377
	[Token(Token = "0x40024A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool _hasAuth;

	// Token: 0x040024A2 RID: 9378
	[Token(Token = "0x40024A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	private bool _hasValidToken;

	// Token: 0x040024A3 RID: 9379
	[Token(Token = "0x40024A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
	private bool _fetchingDataInProgress;

	// Token: 0x040024A4 RID: 9380
	[Token(Token = "0x40024A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<string> namePool;

	// Token: 0x040024A5 RID: 9381
	[Token(Token = "0x40024A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<string> activeKnownBots;

	// Token: 0x040024A6 RID: 9382
	[Token(Token = "0x40024A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private HashSet<string> finalNamePool;

	// Token: 0x040024A7 RID: 9383
	[Token(Token = "0x40024A7")]
	private const string twitchValidationEndpoint = "https://id.twitch.tv/oauth2/validate";

	// Token: 0x040024A8 RID: 9384
	[Token(Token = "0x40024A8")]
	private const string twitchChatterEndpoint = "https://api.twitch.tv/helix/chat/chatters?broadcaster_id=";

	// Token: 0x040024A9 RID: 9385
	[Token(Token = "0x40024A9")]
	private const string twitchModeratorEndpoint = "https://api.twitch.tv/helix/moderation/moderators?broadcaster_id=";

	// Token: 0x040024AA RID: 9386
	[Token(Token = "0x40024AA")]
	private const string twitchVipEndpoint = "https://api.twitch.tv/helix/channels/vips?broadcaster_id=";

	// Token: 0x040024AB RID: 9387
	[Token(Token = "0x40024AB")]
	private const string knownBotsEndpoints = "https://api.twitchinsights.net/v1/bots/online";

	// Token: 0x040024AC RID: 9388
	[Token(Token = "0x40024AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TextAsset customNameList;

	// Token: 0x040024AD RID: 9389
	[Token(Token = "0x40024AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static StreamingOptionsController _instance;

	// Token: 0x02000511 RID: 1297
	[Token(Token = "0x2000511")]
	[StructLayout(3)]
	private struct <OnAuthChange>d__36 : IEnumerator<object>
	{
		// Token: 0x06001BF9 RID: 7161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF9")]
		[Address(RVA = "0x9CD1A0", Offset = "0x9CC1A0", VA = "0x1809CD1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFA")]
		[Address(RVA = "0x6F8FA0", Offset = "0x6F7FA0", VA = "0x1806F8FA0", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040024AE RID: 9390
		[Token(Token = "0x40024AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040024AF RID: 9391
		[Token(Token = "0x40024AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		// Token: 0x040024B0 RID: 9392
		[Token(Token = "0x40024B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public StreamingOptionsController <>4__this;

		// Token: 0x040024B1 RID: 9393
		[Token(Token = "0x40024B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UniTask<bool>.Awaiter <>u__1;

		// Token: 0x040024B2 RID: 9394
		[Token(Token = "0x40024B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter <>u__2;
	}

	// Token: 0x02000512 RID: 1298
	[Token(Token = "0x2000512")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001BFC RID: 7164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0000CC60 File Offset: 0x0000AE60
		[Token(Token = "0x6001BFD")]
		[Address(RVA = "0x9CDE90", Offset = "0x9CCE90", VA = "0x1809CDE90")]
		internal bool <ForceTwitchAudienceCitizensToOff>b__38_0(PlayerPrefsController.GameSetting item)
		{
			return default(bool);
		}

		// Token: 0x040024B3 RID: 9395
		[Token(Token = "0x40024B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly StreamingOptionsController.<>c <>9;

		// Token: 0x040024B4 RID: 9396
		[Token(Token = "0x40024B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<PlayerPrefsController.GameSetting> <>9__38_0;
	}

	// Token: 0x02000513 RID: 1299
	[Token(Token = "0x2000513")]
	[StructLayout(3)]
	private struct <UpdateTwitchCitizens>d__41 : IEnumerator<object>
	{
		// Token: 0x06001BFE RID: 7166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFE")]
		[Address(RVA = "0x9CDF20", Offset = "0x9CCF20", VA = "0x1809CDF20", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFF")]
		[Address(RVA = "0x6F8FA0", Offset = "0x6F7FA0", VA = "0x1806F8FA0", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040024B5 RID: 9397
		[Token(Token = "0x40024B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040024B6 RID: 9398
		[Token(Token = "0x40024B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		// Token: 0x040024B7 RID: 9399
		[Token(Token = "0x40024B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public StreamingOptionsController <>4__this;

		// Token: 0x040024B8 RID: 9400
		[Token(Token = "0x40024B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UniTask<bool>.Awaiter <>u__1;

		// Token: 0x040024B9 RID: 9401
		[Token(Token = "0x40024B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UniTask.Awaiter <>u__2;
	}

	// Token: 0x02000514 RID: 1300
	[Token(Token = "0x2000514")]
	[StructLayout(3)]
	private struct <ValidateTokenUpdated>d__45 : IEnumerator<object>
	{
		// Token: 0x06001C00 RID: 7168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C00")]
		[Address(RVA = "0x9CE9F0", Offset = "0x9CD9F0", VA = "0x1809CE9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C01")]
		[Address(RVA = "0x9CF140", Offset = "0x9CE140", VA = "0x1809CF140", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040024BA RID: 9402
		[Token(Token = "0x40024BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040024BB RID: 9403
		[Token(Token = "0x40024BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder<bool> <>t__builder;

		// Token: 0x040024BC RID: 9404
		[Token(Token = "0x40024BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StreamingOptionsController <>4__this;

		// Token: 0x040024BD RID: 9405
		[Token(Token = "0x40024BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityWebRequest <webRequest>5__2;

		// Token: 0x040024BE RID: 9406
		[Token(Token = "0x40024BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter <>u__1;
	}

	// Token: 0x02000515 RID: 1301
	[Token(Token = "0x2000515")]
	[StructLayout(3)]
	private struct <GetChattersUpdated>d__47 : IEnumerator<object>
	{
		// Token: 0x06001C02 RID: 7170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C02")]
		[Address(RVA = "0x9CF170", Offset = "0x9CE170", VA = "0x1809CF170", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C03")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040024BF RID: 9407
		[Token(Token = "0x40024BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040024C0 RID: 9408
		[Token(Token = "0x40024C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder <>t__builder;

		// Token: 0x040024C1 RID: 9409
		[Token(Token = "0x40024C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StreamingOptionsController <>4__this;

		// Token: 0x040024C2 RID: 9410
		[Token(Token = "0x40024C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UnityWebRequest <webRequest>5__2;

		// Token: 0x040024C3 RID: 9411
		[Token(Token = "0x40024C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter <>u__1;
	}

	// Token: 0x02000516 RID: 1302
	[Token(Token = "0x2000516")]
	[StructLayout(3)]
	private struct <GetModeratorsUpdated>d__48 : IEnumerator<object>
	{
		// Token: 0x06001C04 RID: 7172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C04")]
		[Address(RVA = "0x9CF870", Offset = "0x9CE870", VA = "0x1809CF870", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C05")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040024C4 RID: 9412
		[Token(Token = "0x40024C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040024C5 RID: 9413
		[Token(Token = "0x40024C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder <>t__builder;

		// Token: 0x040024C6 RID: 9414
		[Token(Token = "0x40024C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StreamingOptionsController <>4__this;

		// Token: 0x040024C7 RID: 9415
		[Token(Token = "0x40024C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UnityWebRequest <webRequest>5__2;

		// Token: 0x040024C8 RID: 9416
		[Token(Token = "0x40024C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter <>u__1;
	}

	// Token: 0x02000517 RID: 1303
	[Token(Token = "0x2000517")]
	[StructLayout(3)]
	private struct <GetVipsUpdated>d__49 : IEnumerator<object>
	{
		// Token: 0x06001C06 RID: 7174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C06")]
		[Address(RVA = "0x9CFF50", Offset = "0x9CEF50", VA = "0x1809CFF50", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C07")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040024C9 RID: 9417
		[Token(Token = "0x40024C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x040024CA RID: 9418
		[Token(Token = "0x40024CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder <>t__builder;

		// Token: 0x040024CB RID: 9419
		[Token(Token = "0x40024CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StreamingOptionsController <>4__this;

		// Token: 0x040024CC RID: 9420
		[Token(Token = "0x40024CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UnityWebRequest <webRequest>5__2;

		// Token: 0x040024CD RID: 9421
		[Token(Token = "0x40024CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter <>u__1;
	}

	// Token: 0x02000518 RID: 1304
	[Token(Token = "0x2000518")]
	private sealed class <GrabKnownOnlineBots>d__50 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001C08 RID: 7176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <GrabKnownOnlineBots>d__50(int <>1__state)
		{
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C09")]
		[Address(RVA = "0x9D0640", Offset = "0x9CF640", VA = "0x1809D0640", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0000CC78 File Offset: 0x0000AE78
		[Token(Token = "0x6001C0A")]
		[Address(RVA = "0x9D0700", Offset = "0x9CF700", VA = "0x1809D0700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0B")]
		[Address(RVA = "0x9D0C80", Offset = "0x9CFC80", VA = "0x1809D0C80")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000D8")]
		private object Current
		{
			[Token(Token = "0x6001C0C")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0x9D0CE0", Offset = "0x9CFCE0", VA = "0x1809D0CE0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000D9")]
		private object Current
		{
			[Token(Token = "0x6001C0E")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040024CE RID: 9422
		[Token(Token = "0x40024CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040024CF RID: 9423
		[Token(Token = "0x40024CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040024D0 RID: 9424
		[Token(Token = "0x40024D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StreamingOptionsController <>4__this;

		// Token: 0x040024D1 RID: 9425
		[Token(Token = "0x40024D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityWebRequest <webRequest>5__2;
	}

	// Token: 0x02000519 RID: 1305
	[Token(Token = "0x2000519")]
	private sealed class <>c__DisplayClass51_0
	{
		// Token: 0x06001C0F RID: 7183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass51_0()
		{
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0000CC90 File Offset: 0x0000AE90
		[Token(Token = "0x6001C10")]
		[Address(RVA = "0x9D0D30", Offset = "0x9CFD30", VA = "0x1809D0D30")]
		internal bool <TryAddCustomName>b__0(CitizenReplacement p)
		{
			return default(bool);
		}

		// Token: 0x040024D2 RID: 9426
		[Token(Token = "0x40024D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CitizenReplacement newRep;
	}

	// Token: 0x0200051A RID: 1306
	[Token(Token = "0x200051A")]
	private sealed class <>c__DisplayClass51_1
	{
		// Token: 0x06001C11 RID: 7185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C11")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass51_1()
		{
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		[Token(Token = "0x6001C12")]
		[Address(RVA = "0x9D0D30", Offset = "0x9CFD30", VA = "0x1809D0D30")]
		internal bool <TryAddCustomName>b__1(CitizenReplacement p)
		{
			return default(bool);
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		[Token(Token = "0x6001C13")]
		[Address(RVA = "0x9D0D30", Offset = "0x9CFD30", VA = "0x1809D0D30")]
		internal bool <TryAddCustomName>b__2(CitizenReplacement p)
		{
			return default(bool);
		}

		// Token: 0x040024D3 RID: 9427
		[Token(Token = "0x40024D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CitizenReplacement newRep;
	}
}
