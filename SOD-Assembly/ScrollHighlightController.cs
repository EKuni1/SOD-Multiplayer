using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000047 RID: 71
[Token(Token = "0x2000047")]
public class ScrollHighlightController : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x5D1FD0", Offset = "0x5D0FD0", VA = "0x1805D1FD0", Slot = "4")]
	public void OnPointerEnter(PointerEventData data)
	{
	}

	// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x5D2210", Offset = "0x5D1210", VA = "0x1805D2210", Slot = "5")]
	public void OnPointerExit(PointerEventData data)
	{
	}

	// Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x5D2360", Offset = "0x5D1360", VA = "0x1805D2360")]
	public ScrollHighlightController()
	{
	}

	// Token: 0x04000202 RID: 514
	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 scrollPositionPathmap;
}
