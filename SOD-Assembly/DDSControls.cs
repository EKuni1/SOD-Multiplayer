using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020008B8 RID: 2232
[Token(Token = "0x20008B8")]
public class DDSControls : MonoBehaviour
{
	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06002A33 RID: 10803 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000151")]
	public static DDSControls Instance
	{
		[Token(Token = "0x6002A33")]
		[Address(RVA = "0xCB9DD0", Offset = "0xCB8DD0", VA = "0x180CB9DD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002A34 RID: 10804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A34")]
	[Address(RVA = "0xCB9E10", Offset = "0xCB8E10", VA = "0x180CB9E10")]
	private void Awake()
	{
	}

	// Token: 0x06002A35 RID: 10805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A35")]
	[Address(RVA = "0xCBA160", Offset = "0xCB9160", VA = "0x180CBA160")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002A36 RID: 10806 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A36")]
	[Address(RVA = "0xCBA370", Offset = "0xCB9370", VA = "0x180CBA370")]
	public void ListUnusedDDSTrees()
	{
	}

	// Token: 0x06002A37 RID: 10807 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A37")]
	[Address(RVA = "0xCBAE30", Offset = "0xCB9E30", VA = "0x180CBAE30")]
	public DDSControls()
	{
	}

	// Token: 0x04004664 RID: 18020
	[Token(Token = "0x4004664")]
	[FieldOffset(Offset = "0x18")]
	public List<Sprite> backgroundSprites;

	// Token: 0x04004665 RID: 18021
	[Token(Token = "0x4004665")]
	[FieldOffset(Offset = "0x20")]
	public TMP_FontAsset defaultHandwritingFont;

	// Token: 0x04004666 RID: 18022
	[Token(Token = "0x4004666")]
	[FieldOffset(Offset = "0x28")]
	public TMP_FontAsset clearModeFont;

	// Token: 0x04004667 RID: 18023
	[Token(Token = "0x4004667")]
	[FieldOffset(Offset = "0x30")]
	public List<TMP_FontAsset> fonts;

	// Token: 0x04004668 RID: 18024
	[Token(Token = "0x4004668")]
	[FieldOffset(Offset = "0x38")]
	public GameObject textComponent;

	// Token: 0x04004669 RID: 18025
	[Token(Token = "0x4004669")]
	[FieldOffset(Offset = "0x40")]
	public GameObject elementPrefab;

	// Token: 0x0400466A RID: 18026
	[Token(Token = "0x400466A")]
	[FieldOffset(Offset = "0x48")]
	public List<GameObject> elementPrefabs;

	// Token: 0x0400466B RID: 18027
	[Token(Token = "0x400466B")]
	[FieldOffset(Offset = "0x50")]
	public string sourcePath;

	// Token: 0x0400466C RID: 18028
	[Token(Token = "0x400466C")]
	[FieldOffset(Offset = "0x0")]
	private static DDSControls _instance;
}
