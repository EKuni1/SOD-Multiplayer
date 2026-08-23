using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020006BD RID: 1725
[Token(Token = "0x20006BD")]
[Serializable]
public class ModdedBook
{
	// Token: 0x060026A8 RID: 9896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026A8")]
	[Address(RVA = "0xBF0C40", Offset = "0xBEFC40", VA = "0x180BF0C40")]
	public ModdedBook()
	{
	}

	// Token: 0x040030D0 RID: 12496
	[Token(Token = "0x40030D0")]
	[FieldOffset(Offset = "0x10")]
	public string copyDataFrom;

	// Token: 0x040030D1 RID: 12497
	[Token(Token = "0x40030D1")]
	[FieldOffset(Offset = "0x18")]
	public string bookName;

	// Token: 0x040030D2 RID: 12498
	[Token(Token = "0x40030D2")]
	[FieldOffset(Offset = "0x20")]
	public string author;

	// Token: 0x040030D3 RID: 12499
	[Token(Token = "0x40030D3")]
	[FieldOffset(Offset = "0x28")]
	public List<string> genre;

	// Token: 0x040030D4 RID: 12500
	[Token(Token = "0x40030D4")]
	[FieldOffset(Offset = "0x30")]
	public string isSeries;

	// Token: 0x040030D5 RID: 12501
	[Token(Token = "0x40030D5")]
	[FieldOffset(Offset = "0x38")]
	public string seriesTag;

	// Token: 0x040030D6 RID: 12502
	[Token(Token = "0x40030D6")]
	[FieldOffset(Offset = "0x40")]
	public string seriesNumber;

	// Token: 0x040030D7 RID: 12503
	[Token(Token = "0x40030D7")]
	[FieldOffset(Offset = "0x48")]
	public string common;

	// Token: 0x040030D8 RID: 12504
	[Token(Token = "0x40030D8")]
	[FieldOffset(Offset = "0x50")]
	public string baseChance;

	// Token: 0x040030D9 RID: 12505
	[Token(Token = "0x40030D9")]
	[FieldOffset(Offset = "0x58")]
	public List<string> pickRules1;

	// Token: 0x040030DA RID: 12506
	[Token(Token = "0x40030DA")]
	[FieldOffset(Offset = "0x60")]
	public List<string> pickRules2;

	// Token: 0x040030DB RID: 12507
	[Token(Token = "0x40030DB")]
	[FieldOffset(Offset = "0x68")]
	public List<string> pickRules3;

	// Token: 0x040030DC RID: 12508
	[Token(Token = "0x40030DC")]
	[FieldOffset(Offset = "0x70")]
	public string spawnRule;

	// Token: 0x040030DD RID: 12509
	[Token(Token = "0x40030DD")]
	[FieldOffset(Offset = "0x78")]
	public string bookMesh;

	// Token: 0x040030DE RID: 12510
	[Token(Token = "0x40030DE")]
	[FieldOffset(Offset = "0x80")]
	public string bookMaterial;

	// Token: 0x040030DF RID: 12511
	[Token(Token = "0x40030DF")]
	[FieldOffset(Offset = "0x88")]
	public string ddsMessage;
}
