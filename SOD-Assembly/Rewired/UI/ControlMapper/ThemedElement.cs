using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000947 RID: 2375
	[Token(Token = "0x2000947")]
	public class ThemedElement : MonoBehaviour
	{
		// Token: 0x0600327D RID: 12925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327D")]
		[Address(RVA = "0xD2CC90", Offset = "0xD2BC90", VA = "0x180D2CC90")]
		private void Start()
		{
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327E")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public ThemedElement()
		{
		}

		// Token: 0x04004F93 RID: 20371
		[Token(Token = "0x4004F93")]
		[FieldOffset(Offset = "0x18")]
		private ThemedElement.ElementInfo[] _elements;

		// Token: 0x02000948 RID: 2376
		[Token(Token = "0x2000948")]
		[Serializable]
		public class ElementInfo
		{
			// Token: 0x170004CD RID: 1229
			// (get) Token: 0x0600327F RID: 12927 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004CD")]
			public string themeClass
			{
				[Token(Token = "0x600327F")]
				[Address(RVA = "0x3ED8F0", Offset = "0x3EC8F0", VA = "0x1803ED8F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170004CE RID: 1230
			// (get) Token: 0x06003280 RID: 12928 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004CE")]
			public Component component
			{
				[Token(Token = "0x6003280")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003281 RID: 12929 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003281")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public ElementInfo()
			{
			}

			// Token: 0x04004F94 RID: 20372
			[Token(Token = "0x4004F94")]
			[FieldOffset(Offset = "0x10")]
			private string _themeClass;

			// Token: 0x04004F95 RID: 20373
			[Token(Token = "0x4004F95")]
			[FieldOffset(Offset = "0x18")]
			private Component _component;
		}
	}
}
