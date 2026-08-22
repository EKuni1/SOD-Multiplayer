using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Integration.UnityUI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.Demos
{
	// Token: 0x0200097C RID: 2428
	[Token(Token = "0x200097C")]
	public sealed class PlayerPointerEventHandlerExample : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>
	{
		// Token: 0x0600341C RID: 13340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341C")]
		[Address(RVA = "0xD4C740", Offset = "0xD4B740", VA = "0x180D4C740")]
		private void Log(string o)
		{
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341D")]
		[Address(RVA = "0xD4C7E0", Offset = "0xD4B7E0", VA = "0x180D4C7E0")]
		private void Update()
		{
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341E")]
		[Address(RVA = "0xD4CAB0", Offset = "0xD4BAB0", VA = "0x180D4CAB0", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600341F")]
		[Address(RVA = "0xD4CEA0", Offset = "0xD4BEA0", VA = "0x180D4CEA0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003420")]
		[Address(RVA = "0xD4D290", Offset = "0xD4C290", VA = "0x180D4D290", Slot = "6")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003421")]
		[Address(RVA = "0xD4D790", Offset = "0xD4C790", VA = "0x180D4D790", Slot = "7")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003422")]
		[Address(RVA = "0xD4DC90", Offset = "0xD4CC90", VA = "0x180D4DC90", Slot = "8")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003423")]
		[Address(RVA = "0xD4E190", Offset = "0xD4D190", VA = "0x180D4E190", Slot = "9")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003424")]
		[Address(RVA = "0xD4E580", Offset = "0xD4D580", VA = "0x180D4E580", Slot = "10")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003425")]
		[Address(RVA = "0xD4EA80", Offset = "0xD4DA80", VA = "0x180D4EA80", Slot = "11")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003426")]
		[Address(RVA = "0xD4EF80", Offset = "0xD4DF80", VA = "0x180D4EF80", Slot = "12")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003427")]
		[Address(RVA = "0xD4F480", Offset = "0xD4E480", VA = "0x180D4F480")]
		private static string GetSourceName(PlayerPointerEventData playerEventData)
		{
			return null;
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003428")]
		[Address(RVA = "0xD4F5B0", Offset = "0xD4E5B0", VA = "0x180D4F5B0")]
		public PlayerPointerEventHandlerExample()
		{
		}

		// Token: 0x040050AC RID: 20652
		[Token(Token = "0x40050AC")]
		[FieldOffset(Offset = "0x18")]
		public Text text;

		// Token: 0x040050AD RID: 20653
		[Token(Token = "0x40050AD")]
		private const int logLength = 10;

		// Token: 0x040050AE RID: 20654
		[Token(Token = "0x40050AE")]
		[FieldOffset(Offset = "0x20")]
		private List<string> log;
	}
}
