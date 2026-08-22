using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000776 RID: 1910
[Token(Token = "0x2000776")]
public class BookPreset : SoCustomComparison
{
	// Token: 0x06002910 RID: 10512 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002910")]
	[Address(RVA = "0xC68B40", Offset = "0xC67B40", VA = "0x180C68B40")]
	public BookPreset()
	{
	}

	// Token: 0x040036A8 RID: 13992
	[Token(Token = "0x40036A8")]
	[FieldOffset(Offset = "0x20")]
	public string bookName;

	// Token: 0x040036A9 RID: 13993
	[Token(Token = "0x40036A9")]
	[FieldOffset(Offset = "0x28")]
	public string author;

	// Token: 0x040036AA RID: 13994
	[Token(Token = "0x40036AA")]
	[FieldOffset(Offset = "0x30")]
	public List<BookPreset.BookGenre> genre;

	// Token: 0x040036AB RID: 13995
	[Token(Token = "0x40036AB")]
	[FieldOffset(Offset = "0x38")]
	public bool isSeries;

	// Token: 0x040036AC RID: 13996
	[Token(Token = "0x40036AC")]
	[FieldOffset(Offset = "0x3C")]
	public BookPreset.BookSeries seriesTag;

	// Token: 0x040036AD RID: 13997
	[Token(Token = "0x40036AD")]
	[FieldOffset(Offset = "0x40")]
	public int seriesNumber;

	// Token: 0x040036AE RID: 13998
	[Token(Token = "0x40036AE")]
	[FieldOffset(Offset = "0x44")]
	public float common;

	// Token: 0x040036AF RID: 13999
	[Token(Token = "0x40036AF")]
	[FieldOffset(Offset = "0x48")]
	public float baseChance;

	// Token: 0x040036B0 RID: 14000
	[Token(Token = "0x40036B0")]
	[FieldOffset(Offset = "0x50")]
	public List<CharacterTrait.TraitPickRule> pickRules;

	// Token: 0x040036B1 RID: 14001
	[Token(Token = "0x40036B1")]
	[FieldOffset(Offset = "0x58")]
	public BookPreset.SpawnRules spawnRule;

	// Token: 0x040036B2 RID: 14002
	[Token(Token = "0x40036B2")]
	[FieldOffset(Offset = "0x60")]
	public Mesh bookMesh;

	// Token: 0x040036B3 RID: 14003
	[Token(Token = "0x40036B3")]
	[FieldOffset(Offset = "0x68")]
	public Material bookMaterial;

	// Token: 0x040036B4 RID: 14004
	[Token(Token = "0x40036B4")]
	[FieldOffset(Offset = "0x70")]
	public string ddsMessage;

	// Token: 0x02000777 RID: 1911
	[Token(Token = "0x2000777")]
	public enum BookGenre
	{
		// Token: 0x040036B6 RID: 14006
		[Token(Token = "0x40036B6")]
		crime,
		// Token: 0x040036B7 RID: 14007
		[Token(Token = "0x40036B7")]
		history,
		// Token: 0x040036B8 RID: 14008
		[Token(Token = "0x40036B8")]
		esoteric,
		// Token: 0x040036B9 RID: 14009
		[Token(Token = "0x40036B9")]
		romance,
		// Token: 0x040036BA RID: 14010
		[Token(Token = "0x40036BA")]
		medical,
		// Token: 0x040036BB RID: 14011
		[Token(Token = "0x40036BB")]
		science,
		// Token: 0x040036BC RID: 14012
		[Token(Token = "0x40036BC")]
		architecture,
		// Token: 0x040036BD RID: 14013
		[Token(Token = "0x40036BD")]
		sciFi,
		// Token: 0x040036BE RID: 14014
		[Token(Token = "0x40036BE")]
		memoir,
		// Token: 0x040036BF RID: 14015
		[Token(Token = "0x40036BF")]
		propaganda,
		// Token: 0x040036C0 RID: 14016
		[Token(Token = "0x40036C0")]
		politics,
		// Token: 0x040036C1 RID: 14017
		[Token(Token = "0x40036C1")]
		beauty,
		// Token: 0x040036C2 RID: 14018
		[Token(Token = "0x40036C2")]
		food,
		// Token: 0x040036C3 RID: 14019
		[Token(Token = "0x40036C3")]
		nature,
		// Token: 0x040036C4 RID: 14020
		[Token(Token = "0x40036C4")]
		poetry
	}

	// Token: 0x02000778 RID: 1912
	[Token(Token = "0x2000778")]
	public enum BookSeries
	{
		// Token: 0x040036C6 RID: 14022
		[Token(Token = "0x40036C6")]
		none,
		// Token: 0x040036C7 RID: 14023
		[Token(Token = "0x40036C7")]
		detectiveGill,
		// Token: 0x040036C8 RID: 14024
		[Token(Token = "0x40036C8")]
		talesOfTheHeart,
		// Token: 0x040036C9 RID: 14025
		[Token(Token = "0x40036C9")]
		candorHistory,
		// Token: 0x040036CA RID: 14026
		[Token(Token = "0x40036CA")]
		customSeries1,
		// Token: 0x040036CB RID: 14027
		[Token(Token = "0x40036CB")]
		customSeries2,
		// Token: 0x040036CC RID: 14028
		[Token(Token = "0x40036CC")]
		customSeries3,
		// Token: 0x040036CD RID: 14029
		[Token(Token = "0x40036CD")]
		customSeries4,
		// Token: 0x040036CE RID: 14030
		[Token(Token = "0x40036CE")]
		customSeries5,
		// Token: 0x040036CF RID: 14031
		[Token(Token = "0x40036CF")]
		customSeries6,
		// Token: 0x040036D0 RID: 14032
		[Token(Token = "0x40036D0")]
		customSeries7,
		// Token: 0x040036D1 RID: 14033
		[Token(Token = "0x40036D1")]
		customSeries8,
		// Token: 0x040036D2 RID: 14034
		[Token(Token = "0x40036D2")]
		customSeries9,
		// Token: 0x040036D3 RID: 14035
		[Token(Token = "0x40036D3")]
		customSeries10
	}

	// Token: 0x02000779 RID: 1913
	[Token(Token = "0x2000779")]
	public enum SpawnRules
	{
		// Token: 0x040036D5 RID: 14037
		[Token(Token = "0x40036D5")]
		onlyAtHome,
		// Token: 0x040036D6 RID: 14038
		[Token(Token = "0x40036D6")]
		onlyAtWork,
		// Token: 0x040036D7 RID: 14039
		[Token(Token = "0x40036D7")]
		homeOrWork,
		// Token: 0x040036D8 RID: 14040
		[Token(Token = "0x40036D8")]
		secret
	}
}
