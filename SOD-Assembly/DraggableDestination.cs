using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000581 RID: 1409
[Token(Token = "0x2000581")]
public class DraggableDestination : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x1400002E RID: 46
	// (add) Token: 0x06001E87 RID: 7815 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001E88 RID: 7816 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400002E")]
	public event DraggableDestination.DragDestination OnDragged
	{
		[Token(Token = "0x6001E87")]
		[Address(RVA = "0xA51E60", Offset = "0xA50E60", VA = "0x180A51E60")]
		add
		{
		}
		[Token(Token = "0x6001E88")]
		[Address(RVA = "0xA51F50", Offset = "0xA50F50", VA = "0x180A51F50")]
		remove
		{
		}
	}

	// Token: 0x06001E89 RID: 7817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E89")]
	[Address(RVA = "0xA52040", Offset = "0xA51040", VA = "0x180A52040")]
	private void Awake()
	{
	}

	// Token: 0x06001E8A RID: 7818 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E8A")]
	[Address(RVA = "0xA52210", Offset = "0xA51210", VA = "0x180A52210", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06001E8B RID: 7819 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E8B")]
	[Address(RVA = "0xA52500", Offset = "0xA51500", VA = "0x180A52500", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06001E8C RID: 7820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E8C")]
	[Address(RVA = "0xA52640", Offset = "0xA51640", VA = "0x180A52640")]
	private void Update()
	{
	}

	// Token: 0x06001E8D RID: 7821 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E8D")]
	[Address(RVA = "0xA52770", Offset = "0xA51770", VA = "0x180A52770")]
	public DraggableDestination()
	{
	}

	// Token: 0x04002724 RID: 10020
	[Token(Token = "0x4002724")]
	[FieldOffset(Offset = "0x18")]
	public bool isOver;

	// Token: 0x04002725 RID: 10021
	[Token(Token = "0x4002725")]
	[FieldOffset(Offset = "0x20")]
	public Button but;

	// Token: 0x04002727 RID: 10023
	[Token(Token = "0x4002727")]
	[FieldOffset(Offset = "0x30")]
	public List<string> acceptedTags;

	// Token: 0x04002728 RID: 10024
	[Token(Token = "0x4002728")]
	[FieldOffset(Offset = "0x38")]
	private Image graphic;

	// Token: 0x04002729 RID: 10025
	[Token(Token = "0x4002729")]
	[FieldOffset(Offset = "0x40")]
	public Color originalColour;

	// Token: 0x0400272A RID: 10026
	[Token(Token = "0x400272A")]
	[FieldOffset(Offset = "0x50")]
	public bool useHoverColours;

	// Token: 0x0400272B RID: 10027
	[Token(Token = "0x400272B")]
	[FieldOffset(Offset = "0x54")]
	public Color hoverAcceptColour;

	// Token: 0x02000582 RID: 1410
	// (Invoke) Token: 0x06001E8F RID: 7823
	[Token(Token = "0x2000582")]
	public delegate void DragDestination(GameObject dragObj, string tag);
}
