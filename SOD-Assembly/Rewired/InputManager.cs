using System;
using Il2CppDummyDll;
using Rewired.Utils.Interfaces;
using UnityEngine.SceneManagement;

namespace Rewired
{
	// Token: 0x020008F4 RID: 2292
	[Token(Token = "0x20008F4")]
	public sealed class InputManager : InputManager_Base
	{
		// Token: 0x06002D2A RID: 11562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2A")]
		[Address(RVA = "0xCD9B90", Offset = "0xCD8B90", VA = "0x180CD9B90", Slot = "4")]
		protected override void OnInitialized()
		{
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2B")]
		[Address(RVA = "0xCD9BA0", Offset = "0xCD8BA0", VA = "0x180CD9BA0", Slot = "5")]
		protected override void OnDeinitialized()
		{
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2C")]
		[Address(RVA = "0xCD9BB0", Offset = "0xCD8BB0", VA = "0x180CD9BB0", Slot = "6")]
		protected override void DetectPlatform()
		{
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "7")]
		protected override void CheckRecompile()
		{
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D2E")]
		[Address(RVA = "0xCD9C80", Offset = "0xCD8C80", VA = "0x180CD9C80", Slot = "8")]
		protected override IExternalTools GetExternalTools()
		{
			return null;
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00010218 File Offset: 0x0000E418
		[Token(Token = "0x6002D2F")]
		[Address(RVA = "0xCD9CD0", Offset = "0xCD8CD0", VA = "0x180CD9CD0")]
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
		{
			return default(bool);
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D30")]
		[Address(RVA = "0xCD9D80", Offset = "0xCD8D80", VA = "0x180CD9D80")]
		private void SubscribeEvents()
		{
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D31")]
		[Address(RVA = "0xCD9F80", Offset = "0xCD8F80", VA = "0x180CD9F80")]
		private void UnsubscribeEvents()
		{
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D32")]
		[Address(RVA = "0xCDA170", Offset = "0xCD9170", VA = "0x180CDA170")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D33")]
		[Address(RVA = "0xCDA220", Offset = "0xCD9220", VA = "0x180CDA220")]
		public InputManager()
		{
		}

		// Token: 0x04004D47 RID: 19783
		[Token(Token = "0x4004D47")]
		[FieldOffset(Offset = "0x50")]
		private bool ignoreRecompile;
	}
}
