using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000946 RID: 2374
	[Token(Token = "0x2000946")]
	public class ScrollRectSelectableChild : MonoBehaviour, IEnumerator<object>, IDisposable
	{
		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06003277 RID: 12919 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004CA")]
		private RectTransform parentScrollRectContentTransform
		{
			[Token(Token = "0x6003277")]
			[Address(RVA = "0xD2C2A0", Offset = "0xD2B2A0", VA = "0x180D2C2A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004CB")]
		private Selectable selectable
		{
			[Token(Token = "0x6003278")]
			[Address(RVA = "0xD2C2C0", Offset = "0xD2B2C0", VA = "0x180D2C2C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06003279 RID: 12921 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004CC")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x6003279")]
			[Address(RVA = "0xD2C360", Offset = "0xD2B360", VA = "0x180D2C360")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327A")]
		[Address(RVA = "0xD2C3F0", Offset = "0xD2B3F0", VA = "0x180D2C3F0")]
		private void Start()
		{
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327B")]
		[Address(RVA = "0xD2C5F0", Offset = "0xD2B5F0", VA = "0x180D2C5F0", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327C")]
		[Address(RVA = "0xD2CC40", Offset = "0xD2BC40", VA = "0x180D2CC40")]
		public ScrollRectSelectableChild()
		{
		}

		// Token: 0x04004F8F RID: 20367
		[Token(Token = "0x4004F8F")]
		[FieldOffset(Offset = "0x18")]
		public bool useCustomEdgePadding;

		// Token: 0x04004F90 RID: 20368
		[Token(Token = "0x4004F90")]
		[FieldOffset(Offset = "0x1C")]
		public float customEdgePadding;

		// Token: 0x04004F91 RID: 20369
		[Token(Token = "0x4004F91")]
		[FieldOffset(Offset = "0x20")]
		private ScrollRect parentScrollRect;

		// Token: 0x04004F92 RID: 20370
		[Token(Token = "0x4004F92")]
		[FieldOffset(Offset = "0x28")]
		private Selectable _selectable;
	}
}
