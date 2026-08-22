using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200095F RID: 2399
	[Token(Token = "0x200095F")]
	public static class UITools
	{
		// Token: 0x06003307 RID: 13063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003307")]
		public static GameObject InstantiateGUIObject<T>(GameObject prefab, Transform parent, string name) where T : Component
		{
			return null;
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003308")]
		public static GameObject InstantiateGUIObject<T>(GameObject prefab, Transform parent, string name, Vector2 pivot, Vector2 anchorMin, Vector2 anchorMax, Vector2 anchoredPosition) where T : Component
		{
			return null;
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003309")]
		private static GameObject InstantiateGUIObject_Pre<T>(GameObject prefab, Transform parent, string name) where T : Component
		{
			return null;
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x00012078 File Offset: 0x00010278
		[Token(Token = "0x600330A")]
		[Address(RVA = "0xD33740", Offset = "0xD32740", VA = "0x180D33740")]
		public static Vector3 GetPointOnRectEdge(RectTransform rectTransform, Vector2 dir)
		{
			return default(Vector3);
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x00012090 File Offset: 0x00010290
		[Token(Token = "0x600330B")]
		[Address(RVA = "0xD339E0", Offset = "0xD329E0", VA = "0x180D339E0")]
		public static Rect GetWorldSpaceRect(RectTransform rt)
		{
			return default(Rect);
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x000120A8 File Offset: 0x000102A8
		[Token(Token = "0x600330C")]
		[Address(RVA = "0xD33D00", Offset = "0xD32D00", VA = "0x180D33D00")]
		public static Rect TransformRectTo(Transform from, Transform to, Rect rect)
		{
			return default(Rect);
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x000120C0 File Offset: 0x000102C0
		[Token(Token = "0x600330D")]
		[Address(RVA = "0xD342F0", Offset = "0xD332F0", VA = "0x180D342F0")]
		public static Rect InvertY(Rect rect)
		{
			return default(Rect);
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330E")]
		[Address(RVA = "0xD34320", Offset = "0xD33320", VA = "0x180D34320")]
		public static void SetInteractable(Selectable selectable, bool state, bool playTransition)
		{
		}
	}
}
