using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000684 RID: 1668
[Token(Token = "0x2000684")]
public class PasscodesController : MonoBehaviour
{
	// Token: 0x060024F0 RID: 9456 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024F0")]
	[Address(RVA = "0xBAA2F0", Offset = "0xBA92F0", VA = "0x180BAA2F0")]
	public void Setup(WindowContentController newContentController)
	{
	}

	// Token: 0x060024F1 RID: 9457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024F1")]
	[Address(RVA = "0xBAA5F0", Offset = "0xBA95F0", VA = "0x180BAA5F0")]
	public void SetPageSize(Vector2 newSize)
	{
	}

	// Token: 0x060024F2 RID: 9458 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024F2")]
	[Address(RVA = "0xBAA750", Offset = "0xBA9750", VA = "0x180BAA750")]
	private void OnEnable()
	{
	}

	// Token: 0x060024F3 RID: 9459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024F3")]
	[Address(RVA = "0xBAA830", Offset = "0xBA9830", VA = "0x180BAA830")]
	private void OnDisable()
	{
	}

	// Token: 0x060024F4 RID: 9460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024F4")]
	[Address(RVA = "0xBAAB20", Offset = "0xBA9B20", VA = "0x180BAAB20")]
	private void OnDestroy()
	{
	}

	// Token: 0x060024F5 RID: 9461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024F5")]
	[Address(RVA = "0xBAAE10", Offset = "0xBA9E10", VA = "0x180BAAE10")]
	public void UpdateListDisplay()
	{
	}

	// Token: 0x060024F6 RID: 9462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024F6")]
	[Address(RVA = "0xBABF10", Offset = "0xBAAF10", VA = "0x180BABF10")]
	public void ClearSearchButton()
	{
	}

	// Token: 0x060024F7 RID: 9463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024F7")]
	[Address(RVA = "0xBABF70", Offset = "0xBAAF70", VA = "0x180BABF70")]
	public PasscodesController()
	{
	}

	// Token: 0x04002F0C RID: 12044
	[Token(Token = "0x4002F0C")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002F0D RID: 12045
	[Token(Token = "0x4002F0D")]
	[FieldOffset(Offset = "0x20")]
	public WindowContentController wcc;

	// Token: 0x04002F0E RID: 12046
	[Token(Token = "0x4002F0E")]
	[FieldOffset(Offset = "0x28")]
	public bool isSetup;

	// Token: 0x04002F0F RID: 12047
	[Token(Token = "0x4002F0F")]
	[FieldOffset(Offset = "0x29")]
	public bool isMini;

	// Token: 0x04002F10 RID: 12048
	[Token(Token = "0x4002F10")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI contentsText;

	// Token: 0x04002F11 RID: 12049
	[Token(Token = "0x4002F11")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform entryParent;

	// Token: 0x04002F12 RID: 12050
	[Token(Token = "0x4002F12")]
	[FieldOffset(Offset = "0x40")]
	public TMP_InputField searchInputField;

	// Token: 0x04002F13 RID: 12051
	[Token(Token = "0x4002F13")]
	[FieldOffset(Offset = "0x48")]
	public List<PasscodesEntryController> spawnedEntries;
}
