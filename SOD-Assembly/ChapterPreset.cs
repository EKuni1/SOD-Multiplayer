using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000793 RID: 1939
[Token(Token = "0x2000793")]
public class ChapterPreset : SoCustomComparison
{
	// Token: 0x06002930 RID: 10544 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002930")]
	[Address(RVA = "0xC6F840", Offset = "0xC6E840", VA = "0x180C6F840", Slot = "5")]
	public virtual void SkipToChapterPart()
	{
	}

	// Token: 0x06002931 RID: 10545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002931")]
	[Address(RVA = "0xC6F8B0", Offset = "0xC6E8B0", VA = "0x180C6F8B0")]
	public ChapterPreset()
	{
	}

	// Token: 0x040037A1 RID: 14241
	[Token(Token = "0x40037A1")]
	[FieldOffset(Offset = "0x20")]
	public int chapterNumber;

	// Token: 0x040037A2 RID: 14242
	[Token(Token = "0x40037A2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject scriptObject;

	// Token: 0x040037A3 RID: 14243
	[Token(Token = "0x40037A3")]
	[FieldOffset(Offset = "0x30")]
	public string dictionary;

	// Token: 0x040037A4 RID: 14244
	[Token(Token = "0x40037A4")]
	[FieldOffset(Offset = "0x38")]
	public bool askToEnableTutorial;

	// Token: 0x040037A5 RID: 14245
	[Token(Token = "0x40037A5")]
	[FieldOffset(Offset = "0x3C")]
	public float startingHour;

	// Token: 0x040037A6 RID: 14246
	[Token(Token = "0x40037A6")]
	[FieldOffset(Offset = "0x40")]
	public int startingDate;

	// Token: 0x040037A7 RID: 14247
	[Token(Token = "0x40037A7")]
	[FieldOffset(Offset = "0x44")]
	public int startingMonth;

	// Token: 0x040037A8 RID: 14248
	[Token(Token = "0x40037A8")]
	[FieldOffset(Offset = "0x48")]
	public int startingYear;

	// Token: 0x040037A9 RID: 14249
	[Token(Token = "0x40037A9")]
	[FieldOffset(Offset = "0x4C")]
	public int yearZeroLeapYearCycle;

	// Token: 0x040037AA RID: 14250
	[Token(Token = "0x40037AA")]
	[FieldOffset(Offset = "0x50")]
	public int dayZero;

	// Token: 0x040037AB RID: 14251
	[Token(Token = "0x40037AB")]
	[FieldOffset(Offset = "0x54")]
	public float rainAmount;

	// Token: 0x040037AC RID: 14252
	[Token(Token = "0x40037AC")]
	[FieldOffset(Offset = "0x58")]
	public float windAmount;

	// Token: 0x040037AD RID: 14253
	[Token(Token = "0x40037AD")]
	[FieldOffset(Offset = "0x5C")]
	public float snowAmount;

	// Token: 0x040037AE RID: 14254
	[Token(Token = "0x40037AE")]
	[FieldOffset(Offset = "0x60")]
	public float fogAmount;

	// Token: 0x040037AF RID: 14255
	[Token(Token = "0x40037AF")]
	[FieldOffset(Offset = "0x64")]
	public float lightningAmount;

	// Token: 0x040037B0 RID: 14256
	[Token(Token = "0x40037B0")]
	[FieldOffset(Offset = "0x68")]
	public float transitionSpeed;

	// Token: 0x040037B1 RID: 14257
	[Token(Token = "0x40037B1")]
	[FieldOffset(Offset = "0x6C")]
	public bool usePreSimulation;

	// Token: 0x040037B2 RID: 14258
	[Token(Token = "0x40037B2")]
	[FieldOffset(Offset = "0x70")]
	public float minimumPreSimLength;

	// Token: 0x040037B3 RID: 14259
	[Token(Token = "0x40037B3")]
	[FieldOffset(Offset = "0x78")]
	public List<AudioEvent> audioEvents;

	// Token: 0x040037B4 RID: 14260
	[Token(Token = "0x40037B4")]
	[FieldOffset(Offset = "0x80")]
	public List<DialogPreset> dialogEvents;

	// Token: 0x040037B5 RID: 14261
	[Token(Token = "0x40037B5")]
	[FieldOffset(Offset = "0x88")]
	public List<MurderPreset> crimePool;

	// Token: 0x040037B6 RID: 14262
	[Token(Token = "0x40037B6")]
	[FieldOffset(Offset = "0x90")]
	public List<MurderMO> MOPool;

	// Token: 0x040037B7 RID: 14263
	[Token(Token = "0x40037B7")]
	[FieldOffset(Offset = "0x98")]
	public List<string> partNames;

	// Token: 0x040037B8 RID: 14264
	[Token(Token = "0x40037B8")]
	[FieldOffset(Offset = "0xA0")]
	public int startingPart;
}
