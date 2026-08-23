using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000624 RID: 1572
[Token(Token = "0x2000624")]
public class ViewportMouseOver : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x06002282 RID: 8834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002282")]
	[Address(RVA = "0xB36490", Offset = "0xB35490", VA = "0x180B36490", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06002283 RID: 8835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002283")]
	[Address(RVA = "0xB364F0", Offset = "0xB354F0", VA = "0x180B364F0", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06002284 RID: 8836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002284")]
	[Address(RVA = "0x409BD0", Offset = "0x408BD0", VA = "0x180409BD0")]
	public void ForceMouseOver(bool val)
	{
	}

	// Token: 0x06002285 RID: 8837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002285")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ViewportMouseOver()
	{
	}

	// Token: 0x04002C33 RID: 11315
	[Token(Token = "0x4002C33")]
	[FieldOffset(Offset = "0x18")]
	public bool isOver;
}
