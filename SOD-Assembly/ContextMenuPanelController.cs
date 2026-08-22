using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000570 RID: 1392
[Token(Token = "0x2000570")]
public class ContextMenuPanelController : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x06001E45 RID: 7749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E45")]
	[Address(RVA = "0xA49E70", Offset = "0xA48E70", VA = "0x180A49E70")]
	public void Setup(ContextMenuController newController)
	{
	}

	// Token: 0x06001E46 RID: 7750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E46")]
	[Address(RVA = "0xA4A6F0", Offset = "0xA496F0", VA = "0x180A4A6F0", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06001E47 RID: 7751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E47")]
	[Address(RVA = "0xA4A750", Offset = "0xA49750", VA = "0x180A4A750", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06001E48 RID: 7752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E48")]
	[Address(RVA = "0xA4A8A0", Offset = "0xA498A0", VA = "0x180A4A8A0")]
	private void Update()
	{
	}

	// Token: 0x06001E49 RID: 7753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E49")]
	[Address(RVA = "0xA4AAC0", Offset = "0xA49AC0", VA = "0x180A4AAC0")]
	public ContextMenuPanelController()
	{
	}

	// Token: 0x040026D2 RID: 9938
	[Token(Token = "0x40026D2")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x040026D3 RID: 9939
	[Token(Token = "0x40026D3")]
	[FieldOffset(Offset = "0x20")]
	private bool isOver;

	// Token: 0x040026D4 RID: 9940
	[Token(Token = "0x40026D4")]
	[FieldOffset(Offset = "0x28")]
	public ContextMenuController cmc;

	// Token: 0x040026D5 RID: 9941
	[Token(Token = "0x40026D5")]
	[FieldOffset(Offset = "0x30")]
	public List<ContextButtonController> spawnedButtons;
}
