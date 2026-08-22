using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos
{
	// Token: 0x02000974 RID: 2420
	[Token(Token = "0x2000974")]
	public class TouchButtonExample : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060033E4 RID: 13284 RVA: 0x000124B0 File Offset: 0x000106B0
		// (set) Token: 0x060033E5 RID: 13285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052E")]
		public bool isPressed
		{
			[Token(Token = "0x60033E4")]
			[Address(RVA = "0xCDB320", Offset = "0xCDA320", VA = "0x180CDB320")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60033E5")]
			[Address(RVA = "0xCDB330", Offset = "0xCDA330", VA = "0x180CDB330")]
			private set
			{
			}
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E6")]
		[Address(RVA = "0xD47250", Offset = "0xD46250", VA = "0x180D47250")]
		private void Awake()
		{
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E7")]
		[Address(RVA = "0xD472B0", Offset = "0xD462B0", VA = "0x180D472B0")]
		private void Restart()
		{
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E8")]
		[Address(RVA = "0xD472C0", Offset = "0xD462C0", VA = "0x180D472C0", Slot = "4")]
		private void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033E9")]
		[Address(RVA = "0xD47300", Offset = "0xD46300", VA = "0x180D47300", Slot = "5")]
		private void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x000124C8 File Offset: 0x000106C8
		[Token(Token = "0x60033EA")]
		[Address(RVA = "0xD47340", Offset = "0xD46340", VA = "0x180D47340")]
		private static bool IsMousePointerId(int id)
		{
			return default(bool);
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EB")]
		[Address(RVA = "0x3E9790", Offset = "0x3E8790", VA = "0x1803E9790")]
		public TouchButtonExample()
		{
		}

		// Token: 0x04005077 RID: 20599
		[Token(Token = "0x4005077")]
		[FieldOffset(Offset = "0x18")]
		public bool allowMouseControl;

		// Token: 0x04005078 RID: 20600
		[Token(Token = "0x4005078")]
		[FieldOffset(Offset = "0x19")]
		private bool <isPressed>k__BackingField;
	}
}
