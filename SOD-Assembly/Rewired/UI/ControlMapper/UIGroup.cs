using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000959 RID: 2393
	[Token(Token = "0x2000959")]
	public class UIGroup : MonoBehaviour
	{
		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060032F1 RID: 13041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000500")]
		public string labelText
		{
			[Token(Token = "0x60032F0")]
			[Address(RVA = "0xD31590", Offset = "0xD30590", VA = "0x180D31590")]
			get
			{
				return null;
			}
			[Token(Token = "0x60032F1")]
			[Address(RVA = "0xD316E0", Offset = "0xD306E0", VA = "0x180D316E0")]
			set
			{
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060032F2 RID: 13042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000501")]
		public Transform content
		{
			[Token(Token = "0x60032F2")]
			[Address(RVA = "0x3EDA30", Offset = "0x3ECA30", VA = "0x1803EDA30")]
			get
			{
				return null;
			}
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F3")]
		[Address(RVA = "0xD31810", Offset = "0xD30810", VA = "0x180D31810")]
		public void SetLabelActive(bool state)
		{
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032F4")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public UIGroup()
		{
		}

		// Token: 0x04004FEA RID: 20458
		[Token(Token = "0x4004FEA")]
		[FieldOffset(Offset = "0x18")]
		private TMP_Text _label;

		// Token: 0x04004FEB RID: 20459
		[Token(Token = "0x4004FEB")]
		[FieldOffset(Offset = "0x20")]
		private Transform _content;
	}
}
