using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000940 RID: 2368
	[Token(Token = "0x2000940")]
	public class InputRow : MonoBehaviour
	{
		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060031E3 RID: 12771 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060031E4 RID: 12772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000473")]
		public ButtonInfo[] buttons
		{
			[Token(Token = "0x60031E3")]
			[Address(RVA = "0x3EDA30", Offset = "0x3ECA30", VA = "0x1803EDA30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60031E4")]
			[Address(RVA = "0x3EDA40", Offset = "0x3ECA40", VA = "0x1803EDA40")]
			private set
			{
			}
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031E5")]
		[Address(RVA = "0xD28FB0", Offset = "0xD27FB0", VA = "0x180D28FB0")]
		public void Initialize(int rowIndex, string label, Action<int, ButtonInfo> inputFieldActivatedCallback)
		{
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031E6")]
		[Address(RVA = "0xD29130", Offset = "0xD28130", VA = "0x180D29130")]
		public void OnButtonActivated(ButtonInfo buttonInfo)
		{
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031E7")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public InputRow()
		{
		}

		// Token: 0x04004F47 RID: 20295
		[Token(Token = "0x4004F47")]
		[FieldOffset(Offset = "0x18")]
		public TMP_Text label;

		// Token: 0x04004F48 RID: 20296
		[Token(Token = "0x4004F48")]
		[FieldOffset(Offset = "0x20")]
		private ButtonInfo[] <buttons>k__BackingField;

		// Token: 0x04004F49 RID: 20297
		[Token(Token = "0x4004F49")]
		[FieldOffset(Offset = "0x28")]
		private int rowIndex;

		// Token: 0x04004F4A RID: 20298
		[Token(Token = "0x4004F4A")]
		[FieldOffset(Offset = "0x30")]
		private Action<int, ButtonInfo> inputFieldActivatedCallback;
	}
}
