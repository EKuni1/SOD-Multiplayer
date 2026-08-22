using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000861 RID: 2145
[Token(Token = "0x2000861")]
public class NewspaperArticle : SoCustomComparison
{
	// Token: 0x060029D2 RID: 10706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029D2")]
	[Address(RVA = "0xCAFF80", Offset = "0xCAEF80", VA = "0x180CAFF80")]
	public NewspaperArticle()
	{
	}

	// Token: 0x040040EC RID: 16620
	[Token(Token = "0x40040EC")]
	[FieldOffset(Offset = "0x20")]
	public bool disabled;

	// Token: 0x040040ED RID: 16621
	[Token(Token = "0x40040ED")]
	[FieldOffset(Offset = "0x28")]
	public string ddsReference;

	// Token: 0x040040EE RID: 16622
	[Token(Token = "0x40040EE")]
	[FieldOffset(Offset = "0x30")]
	public NewspaperArticle.Category category;

	// Token: 0x040040EF RID: 16623
	[Token(Token = "0x40040EF")]
	[FieldOffset(Offset = "0x38")]
	public List<NewspaperArticle> followupStories;

	// Token: 0x040040F0 RID: 16624
	[Token(Token = "0x40040F0")]
	[FieldOffset(Offset = "0x40")]
	public NewspaperArticle.ContextSource context;

	// Token: 0x02000862 RID: 2146
	[Token(Token = "0x2000862")]
	public enum Category
	{
		// Token: 0x040040F2 RID: 16626
		[Token(Token = "0x40040F2")]
		general,
		// Token: 0x040040F3 RID: 16627
		[Token(Token = "0x40040F3")]
		murder,
		// Token: 0x040040F4 RID: 16628
		[Token(Token = "0x40040F4")]
		ad,
		// Token: 0x040040F5 RID: 16629
		[Token(Token = "0x40040F5")]
		foreignAffairs,
		// Token: 0x040040F6 RID: 16630
		[Token(Token = "0x40040F6")]
		murderSecond
	}

	// Token: 0x02000863 RID: 2147
	[Token(Token = "0x2000863")]
	public enum ContextSource
	{
		// Token: 0x040040F8 RID: 16632
		[Token(Token = "0x40040F8")]
		nothing,
		// Token: 0x040040F9 RID: 16633
		[Token(Token = "0x40040F9")]
		lastMurder,
		// Token: 0x040040FA RID: 16634
		[Token(Token = "0x40040FA")]
		player,
		// Token: 0x040040FB RID: 16635
		[Token(Token = "0x40040FB")]
		randomCitizen,
		// Token: 0x040040FC RID: 16636
		[Token(Token = "0x40040FC")]
		randomCriminal,
		// Token: 0x040040FD RID: 16637
		[Token(Token = "0x40040FD")]
		randomGroup
	}
}
