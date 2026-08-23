using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004C7 RID: 1223
[Token(Token = "0x20004C7")]
public class RestartSafeController : MonoBehaviour
{
	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x06001B68 RID: 7016 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000D5")]
	public static RestartSafeController Instance
	{
		[Token(Token = "0x6001B68")]
		[Address(RVA = "0x9B9CE0", Offset = "0x9B8CE0", VA = "0x1809B9CE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001B69 RID: 7017 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B69")]
	[Address(RVA = "0x9B9D20", Offset = "0x9B8D20", VA = "0x1809B9D20")]
	private void Awake()
	{
	}

	// Token: 0x06001B6A RID: 7018 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B6A")]
	[Address(RVA = "0x9BA150", Offset = "0x9B9150", VA = "0x1809BA150")]
	public RestartSafeController()
	{
	}

	// Token: 0x04002183 RID: 8579
	[Token(Token = "0x4002183")]
	[FieldOffset(Offset = "0x18")]
	public bool loadFromDirty;

	// Token: 0x04002184 RID: 8580
	[Token(Token = "0x4002184")]
	[FieldOffset(Offset = "0x19")]
	public bool generateNew;

	// Token: 0x04002185 RID: 8581
	[Token(Token = "0x4002185")]
	[FieldOffset(Offset = "0x1A")]
	public bool newGameLoadCity;

	// Token: 0x04002186 RID: 8582
	[Token(Token = "0x4002186")]
	[FieldOffset(Offset = "0x20")]
	public FileInfo loadCityFileInfo;

	// Token: 0x04002187 RID: 8583
	[Token(Token = "0x4002187")]
	[FieldOffset(Offset = "0x28")]
	public string cityName;

	// Token: 0x04002188 RID: 8584
	[Token(Token = "0x4002188")]
	[FieldOffset(Offset = "0x30")]
	public int cityX;

	// Token: 0x04002189 RID: 8585
	[Token(Token = "0x4002189")]
	[FieldOffset(Offset = "0x34")]
	public int cityY;

	// Token: 0x0400218A RID: 8586
	[Token(Token = "0x400218A")]
	[FieldOffset(Offset = "0x38")]
	public string seed;

	// Token: 0x0400218B RID: 8587
	[Token(Token = "0x400218B")]
	[FieldOffset(Offset = "0x40")]
	public bool sandbox;

	// Token: 0x0400218C RID: 8588
	[Token(Token = "0x400218C")]
	[FieldOffset(Offset = "0x48")]
	public string newGamePlayerFirstName;

	// Token: 0x0400218D RID: 8589
	[Token(Token = "0x400218D")]
	[FieldOffset(Offset = "0x50")]
	public string newGamePlayerSurname;

	// Token: 0x0400218E RID: 8590
	[Token(Token = "0x400218E")]
	[FieldOffset(Offset = "0x58")]
	public Human.Gender newGamePlayerGender;

	// Token: 0x0400218F RID: 8591
	[Token(Token = "0x400218F")]
	[FieldOffset(Offset = "0x5C")]
	public Human.Gender newGamePartnerGender;

	// Token: 0x04002190 RID: 8592
	[Token(Token = "0x4002190")]
	[FieldOffset(Offset = "0x60")]
	public Color newGamePlayerSkinTone;

	// Token: 0x04002191 RID: 8593
	[Token(Token = "0x4002191")]
	[FieldOffset(Offset = "0x70")]
	public bool loadSaveGame;

	// Token: 0x04002192 RID: 8594
	[Token(Token = "0x4002192")]
	[FieldOffset(Offset = "0x78")]
	public FileInfo saveStateFileInfo;

	// Token: 0x04002193 RID: 8595
	[Token(Token = "0x4002193")]
	[FieldOffset(Offset = "0x80")]
	public bool newFloor;

	// Token: 0x04002194 RID: 8596
	[Token(Token = "0x4002194")]
	[FieldOffset(Offset = "0x88")]
	public string newFloorName;

	// Token: 0x04002195 RID: 8597
	[Token(Token = "0x4002195")]
	[FieldOffset(Offset = "0x90")]
	public Vector2 newFloorSize;

	// Token: 0x04002196 RID: 8598
	[Token(Token = "0x4002196")]
	[FieldOffset(Offset = "0x98")]
	public int newFloorFloorHeight;

	// Token: 0x04002197 RID: 8599
	[Token(Token = "0x4002197")]
	[FieldOffset(Offset = "0x9C")]
	public int newFloorCeilingHeight;

	// Token: 0x04002198 RID: 8600
	[Token(Token = "0x4002198")]
	[FieldOffset(Offset = "0xA0")]
	public bool loadFloor;

	// Token: 0x04002199 RID: 8601
	[Token(Token = "0x4002199")]
	[FieldOffset(Offset = "0xA8")]
	public string loadFloorString;

	// Token: 0x0400219A RID: 8602
	[Token(Token = "0x400219A")]
	[FieldOffset(Offset = "0xB0")]
	public bool recalculateAll;

	// Token: 0x0400219B RID: 8603
	[Token(Token = "0x400219B")]
	[FieldOffset(Offset = "0xB8")]
	public List<string> floorList;

	// Token: 0x0400219C RID: 8604
	[Token(Token = "0x400219C")]
	[FieldOffset(Offset = "0x0")]
	private static RestartSafeController _instance;
}
