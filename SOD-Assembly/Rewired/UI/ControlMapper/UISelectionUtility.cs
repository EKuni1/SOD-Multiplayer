using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200095C RID: 2396
	[Token(Token = "0x200095C")]
	public static class UISelectionUtility
	{
		// Token: 0x060032FC RID: 13052 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60032FC")]
		[Address(RVA = "0xD31EB0", Offset = "0xD30EB0", VA = "0x180D31EB0")]
		public static Selectable FindNextSelectable(Selectable selectable, Transform transform, Vector3 direction)
		{
			return null;
		}

		// Token: 0x04004FF0 RID: 20464
		[Token(Token = "0x4004FF0")]
		[FieldOffset(Offset = "0x0")]
		private static Selectable[] s_reusableAllSelectables;
	}
}
