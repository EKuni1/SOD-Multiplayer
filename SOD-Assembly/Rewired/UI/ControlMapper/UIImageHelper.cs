using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200095A RID: 2394
	[Token(Token = "0x200095A")]
	public class UIImageHelper : MonoBehaviour
	{
		// Token: 0x060032F5 RID: 13045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F5")]
		[Address(RVA = "0xD319C0", Offset = "0xD309C0", VA = "0x180D319C0")]
		public void SetEnabledState(bool newState)
		{
		}

		// Token: 0x060032F6 RID: 13046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F6")]
		[Address(RVA = "0xD31BB0", Offset = "0xD30BB0", VA = "0x180D31BB0")]
		public void SetEnabledStateColor(Color color)
		{
		}

		// Token: 0x060032F7 RID: 13047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F7")]
		[Address(RVA = "0xD31BD0", Offset = "0xD30BD0", VA = "0x180D31BD0")]
		public void SetDisabledStateColor(Color color)
		{
		}

		// Token: 0x060032F8 RID: 13048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F8")]
		[Address(RVA = "0xD31BF0", Offset = "0xD30BF0", VA = "0x180D31BF0")]
		public void Refresh()
		{
		}

		// Token: 0x060032F9 RID: 13049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F9")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public UIImageHelper()
		{
		}

		// Token: 0x04004FEC RID: 20460
		[Token(Token = "0x4004FEC")]
		[FieldOffset(Offset = "0x18")]
		private UIImageHelper.State enabledState;

		// Token: 0x04004FED RID: 20461
		[Token(Token = "0x4004FED")]
		[FieldOffset(Offset = "0x20")]
		private UIImageHelper.State disabledState;

		// Token: 0x04004FEE RID: 20462
		[Token(Token = "0x4004FEE")]
		[FieldOffset(Offset = "0x28")]
		private bool currentState;

		// Token: 0x0200095B RID: 2395
		[Token(Token = "0x200095B")]
		[Serializable]
		private class State
		{
			// Token: 0x060032FA RID: 13050 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60032FA")]
			[Address(RVA = "0xD31D90", Offset = "0xD30D90", VA = "0x180D31D90")]
			public void Set(Image image)
			{
			}

			// Token: 0x060032FB RID: 13051 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60032FB")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public State()
			{
			}

			// Token: 0x04004FEF RID: 20463
			[Token(Token = "0x4004FEF")]
			[FieldOffset(Offset = "0x10")]
			public Color color;
		}
	}
}
