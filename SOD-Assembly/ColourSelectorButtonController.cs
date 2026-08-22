using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020005EB RID: 1515
[Token(Token = "0x20005EB")]
public class ColourSelectorButtonController : ButtonController, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x14000036 RID: 54
	// (add) Token: 0x0600212A RID: 8490 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600212B RID: 8491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000036")]
	public event ColourSelectorButtonController.ChangeColour OnChangeColour
	{
		[Token(Token = "0x600212A")]
		[Address(RVA = "0xAFB000", Offset = "0xAFA000", VA = "0x180AFB000")]
		add
		{
		}
		[Token(Token = "0x600212B")]
		[Address(RVA = "0xAFB100", Offset = "0xAFA100", VA = "0x180AFB100")]
		remove
		{
		}
	}

	// Token: 0x0600212C RID: 8492 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600212C")]
	[Address(RVA = "0xAFB200", Offset = "0xAFA200", VA = "0x180AFB200", Slot = "10")]
	public override void VisualUpdate()
	{
	}

	// Token: 0x0600212D RID: 8493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600212D")]
	[Address(RVA = "0xAFB260", Offset = "0xAFA260", VA = "0x180AFB260", Slot = "15")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x0600212E RID: 8494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600212E")]
	[Address(RVA = "0xAFB420", Offset = "0xAFA420", VA = "0x180AFB420", Slot = "16")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x0600212F RID: 8495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600212F")]
	[Address(RVA = "0xAFB850", Offset = "0xAFA850", VA = "0x180AFB850")]
	public ColourSelectorButtonController()
	{
	}

	// Token: 0x04002AD9 RID: 10969
	[Token(Token = "0x4002AD9")]
	[FieldOffset(Offset = "0x1A8")]
	public RectTransform selector;

	// Token: 0x04002ADA RID: 10970
	[Token(Token = "0x4002ADA")]
	[FieldOffset(Offset = "0x1B0")]
	public List<Button> colourButtons;

	// Token: 0x04002ADB RID: 10971
	[Token(Token = "0x4002ADB")]
	[FieldOffset(Offset = "0x1B8")]
	public Color selectedColour;

	// Token: 0x020005EC RID: 1516
	// (Invoke) Token: 0x06002131 RID: 8497
	[Token(Token = "0x20005EC")]
	public delegate void ChangeColour();
}
