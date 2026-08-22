using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000958 RID: 2392
	[Token(Token = "0x2000958")]
	public abstract class UIElementInfo : MonoBehaviour, IEnumerator<object>, IDisposable
	{
		// Token: 0x14000079 RID: 121
		// (add) Token: 0x060032EC RID: 13036 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060032ED RID: 13037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000079")]
		public event Action<GameObject> OnSelectedEvent
		{
			[Token(Token = "0x60032EC")]
			[Address(RVA = "0xD312F0", Offset = "0xD302F0", VA = "0x180D312F0")]
			add
			{
			}
			[Token(Token = "0x60032ED")]
			[Address(RVA = "0xD31400", Offset = "0xD30400", VA = "0x180D31400")]
			remove
			{
			}
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032EE")]
		[Address(RVA = "0xD31510", Offset = "0xD30510", VA = "0x180D31510", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032EF")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		protected UIElementInfo()
		{
		}

		// Token: 0x04004FE6 RID: 20454
		[Token(Token = "0x4004FE6")]
		[FieldOffset(Offset = "0x18")]
		public string identifier;

		// Token: 0x04004FE7 RID: 20455
		[Token(Token = "0x4004FE7")]
		[FieldOffset(Offset = "0x20")]
		public int intData;

		// Token: 0x04004FE8 RID: 20456
		[Token(Token = "0x4004FE8")]
		[FieldOffset(Offset = "0x28")]
		public TMP_Text text;
	}
}
