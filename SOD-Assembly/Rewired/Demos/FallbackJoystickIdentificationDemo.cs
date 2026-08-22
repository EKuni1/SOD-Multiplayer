using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x0200097A RID: 2426
	[Token(Token = "0x200097A")]
	public class FallbackJoystickIdentificationDemo : MonoBehaviour
	{
		// Token: 0x0600340D RID: 13325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340D")]
		[Address(RVA = "0xD4A930", Offset = "0xD49930", VA = "0x180D4A930")]
		private void Awake()
		{
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340E")]
		[Address(RVA = "0xD4AA50", Offset = "0xD49A50", VA = "0x180D4AA50")]
		private void JoystickConnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340F")]
		[Address(RVA = "0xD4AA50", Offset = "0xD49A50", VA = "0x180D4AA50")]
		private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003410")]
		[Address(RVA = "0xD4AA60", Offset = "0xD49A60", VA = "0x180D4AA60")]
		public void IdentifyAllJoysticks()
		{
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003411")]
		[Address(RVA = "0xD4AD20", Offset = "0xD49D20", VA = "0x180D4AD20")]
		private void SetInputDelay()
		{
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003412")]
		[Address(RVA = "0xD4AD80", Offset = "0xD49D80", VA = "0x180D4AD80")]
		private void OnGUI()
		{
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003413")]
		[Address(RVA = "0xD4B000", Offset = "0xD4A000", VA = "0x180D4B000")]
		private void DrawDialogWindow(int windowId)
		{
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003414")]
		[Address(RVA = "0xD4B280", Offset = "0xD4A280", VA = "0x180D4B280")]
		private void Reset()
		{
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003415")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public FallbackJoystickIdentificationDemo()
		{
		}

		// Token: 0x04005097 RID: 20631
		[Token(Token = "0x4005097")]
		private const float windowWidth = 250f;

		// Token: 0x04005098 RID: 20632
		[Token(Token = "0x4005098")]
		private const float windowHeight = 250f;

		// Token: 0x04005099 RID: 20633
		[Token(Token = "0x4005099")]
		private const float inputDelay = 1f;

		// Token: 0x0400509A RID: 20634
		[Token(Token = "0x400509A")]
		[FieldOffset(Offset = "0x18")]
		private bool identifyRequired;

		// Token: 0x0400509B RID: 20635
		[Token(Token = "0x400509B")]
		[FieldOffset(Offset = "0x20")]
		private Queue<Joystick> joysticksToIdentify;

		// Token: 0x0400509C RID: 20636
		[Token(Token = "0x400509C")]
		[FieldOffset(Offset = "0x28")]
		private float nextInputAllowedTime;

		// Token: 0x0400509D RID: 20637
		[Token(Token = "0x400509D")]
		[FieldOffset(Offset = "0x30")]
		private GUIStyle style;
	}
}
