using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000672 RID: 1650
[Token(Token = "0x2000672")]
public class ColourPickerController : MonoBehaviour
{
	// Token: 0x1400004A RID: 74
	// (add) Token: 0x06002485 RID: 9349 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002486 RID: 9350 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400004A")]
	public event ColourPickerController.NewColour OnNewColour
	{
		[Token(Token = "0x6002485")]
		[Address(RVA = "0xB98FE0", Offset = "0xB97FE0", VA = "0x180B98FE0")]
		add
		{
		}
		[Token(Token = "0x6002486")]
		[Address(RVA = "0xB990D0", Offset = "0xB980D0", VA = "0x180B990D0")]
		remove
		{
		}
	}

	// Token: 0x06002487 RID: 9351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002487")]
	[Address(RVA = "0xB991C0", Offset = "0xB981C0", VA = "0x180B991C0")]
	public void Setup(WindowContentController newContentController)
	{
	}

	// Token: 0x06002488 RID: 9352 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002488")]
	[Address(RVA = "0xB99340", Offset = "0xB98340", VA = "0x180B99340")]
	public void SetPageSize(Vector2 newSize)
	{
	}

	// Token: 0x06002489 RID: 9353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002489")]
	[Address(RVA = "0xB99430", Offset = "0xB98430", VA = "0x180B99430")]
	public void UpdateListDisplay()
	{
	}

	// Token: 0x0600248A RID: 9354 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600248A")]
	[Address(RVA = "0xB9A020", Offset = "0xB99020", VA = "0x180B9A020")]
	public void OnPickNewColour(SwatchController swatch)
	{
	}

	// Token: 0x0600248B RID: 9355 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600248B")]
	[Address(RVA = "0xB9A090", Offset = "0xB99090", VA = "0x180B9A090")]
	public ColourPickerController()
	{
	}

	// Token: 0x04002E8F RID: 11919
	[Token(Token = "0x4002E8F")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002E90 RID: 11920
	[Token(Token = "0x4002E90")]
	[FieldOffset(Offset = "0x20")]
	public WindowContentController wcc;

	// Token: 0x04002E91 RID: 11921
	[Token(Token = "0x4002E91")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform entryParent;

	// Token: 0x04002E92 RID: 11922
	[Token(Token = "0x4002E92")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform spawnParent;

	// Token: 0x04002E93 RID: 11923
	[Token(Token = "0x4002E93")]
	[FieldOffset(Offset = "0x38")]
	public GameObject swatchPrefab;

	// Token: 0x04002E94 RID: 11924
	[Token(Token = "0x4002E94")]
	[FieldOffset(Offset = "0x40")]
	public bool isSetup;

	// Token: 0x04002E95 RID: 11925
	[Token(Token = "0x4002E95")]
	[FieldOffset(Offset = "0x44")]
	public Color selectedColor;

	// Token: 0x04002E96 RID: 11926
	[Token(Token = "0x4002E96")]
	[FieldOffset(Offset = "0x58")]
	public List<SwatchController> spawnedEntries;

	// Token: 0x02000673 RID: 1651
	// (Invoke) Token: 0x0600248D RID: 9357
	[Token(Token = "0x2000673")]
	public delegate void NewColour(Color newColour);
}
