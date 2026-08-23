using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000552 RID: 1362
[Token(Token = "0x2000552")]
public class CanvasMouseOver : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x170000EA RID: 234
	// (get) Token: 0x06001D84 RID: 7556 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000EA")]
	public static CanvasMouseOver Instance
	{
		[Token(Token = "0x6001D84")]
		[Address(RVA = "0xA2B320", Offset = "0xA2A320", VA = "0x180A2B320")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001D85 RID: 7557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D85")]
	[Address(RVA = "0xA2B360", Offset = "0xA2A360", VA = "0x180A2B360")]
	private void Awake()
	{
	}

	// Token: 0x06001D86 RID: 7558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D86")]
	[Address(RVA = "0xA2B6B0", Offset = "0xA2A6B0", VA = "0x180A2B6B0", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06001D87 RID: 7559 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D87")]
	[Address(RVA = "0xA2B830", Offset = "0xA2A830", VA = "0x180A2B830", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06001D88 RID: 7560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D88")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public CanvasMouseOver()
	{
	}

	// Token: 0x0400261C RID: 9756
	[Token(Token = "0x400261C")]
	[FieldOffset(Offset = "0x0")]
	private static CanvasMouseOver _instance;

	// Token: 0x0400261D RID: 9757
	[Token(Token = "0x400261D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject currentHover;
}
