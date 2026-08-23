using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200062A RID: 1578
[Token(Token = "0x200062A")]
public class WindowTabController : MonoBehaviour, IEnumerator<object>, IDisposable
{
	// Token: 0x060022A9 RID: 8873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A9")]
	[Address(RVA = "0xB3DE40", Offset = "0xB3CE40", VA = "0x180B3DE40")]
	private void Awake()
	{
	}

	// Token: 0x060022AA RID: 8874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022AA")]
	[Address(RVA = "0xB3E000", Offset = "0xB3D000", VA = "0x180B3E000")]
	public void SetupButton()
	{
	}

	// Token: 0x060022AB RID: 8875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022AB")]
	[Address(RVA = "0xB3E1B0", Offset = "0xB3D1B0", VA = "0x180B3E1B0", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x060022AC RID: 8876 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022AC")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void VisualUpdate()
	{
	}

	// Token: 0x060022AD RID: 8877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022AD")]
	[Address(RVA = "0xB3E290", Offset = "0xB3D290", VA = "0x180B3E290")]
	public void SetNewItems(int newItemCount)
	{
	}

	// Token: 0x060022AE RID: 8878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022AE")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public WindowTabController()
	{
	}

	// Token: 0x04002C55 RID: 11349
	[Token(Token = "0x4002C55")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002C56 RID: 11350
	[Token(Token = "0x4002C56")]
	[FieldOffset(Offset = "0x20")]
	public ButtonController tabButton;

	// Token: 0x04002C57 RID: 11351
	[Token(Token = "0x4002C57")]
	[FieldOffset(Offset = "0x28")]
	public WindowContentController content;

	// Token: 0x04002C58 RID: 11352
	[Token(Token = "0x4002C58")]
	[FieldOffset(Offset = "0x30")]
	public WindowTabPreset preset;

	// Token: 0x04002C59 RID: 11353
	[Token(Token = "0x4002C59")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI text;

	// Token: 0x04002C5A RID: 11354
	[Token(Token = "0x4002C5A")]
	[FieldOffset(Offset = "0x40")]
	public int newItems;

	// Token: 0x04002C5B RID: 11355
	[Token(Token = "0x4002C5B")]
	[FieldOffset(Offset = "0x48")]
	public PulsateController pulsateController;
}
