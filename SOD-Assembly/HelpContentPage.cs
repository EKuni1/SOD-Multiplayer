using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

// Token: 0x02000807 RID: 2055
[Token(Token = "0x2000807")]
public class HelpContentPage : SoCustomComparison
{
	// Token: 0x0600298C RID: 10636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600298C")]
	[Address(RVA = "0xCA95F0", Offset = "0xCA85F0", VA = "0x180CA95F0")]
	public HelpContentPage()
	{
	}

	// Token: 0x04003C64 RID: 15460
	[Token(Token = "0x4003C64")]
	[FieldOffset(Offset = "0x20")]
	public bool disabled;

	// Token: 0x04003C65 RID: 15461
	[Token(Token = "0x4003C65")]
	[FieldOffset(Offset = "0x28")]
	public string messageID;

	// Token: 0x04003C66 RID: 15462
	[Token(Token = "0x4003C66")]
	[FieldOffset(Offset = "0x30")]
	public List<HelpContentPage.HelpContentDisplay> contentDisplay;

	// Token: 0x02000808 RID: 2056
	[Token(Token = "0x2000808")]
	[Serializable]
	public class HelpContentDisplay
	{
		// Token: 0x0600298D RID: 10637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600298D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public HelpContentDisplay()
		{
		}

		// Token: 0x04003C67 RID: 15463
		[Token(Token = "0x4003C67")]
		[FieldOffset(Offset = "0x10")]
		public HelpContentPage.DisplaySetting helpDisplaySetting;

		// Token: 0x04003C68 RID: 15464
		[Token(Token = "0x4003C68")]
		[FieldOffset(Offset = "0x18")]
		public VideoClip clip;

		// Token: 0x04003C69 RID: 15465
		[Token(Token = "0x4003C69")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D image;
	}

	// Token: 0x02000809 RID: 2057
	[Token(Token = "0x2000809")]
	public enum DisplaySetting
	{
		// Token: 0x04003C6B RID: 15467
		[Token(Token = "0x4003C6B")]
		dontDisplay,
		// Token: 0x04003C6C RID: 15468
		[Token(Token = "0x4003C6C")]
		displayBeforeText,
		// Token: 0x04003C6D RID: 15469
		[Token(Token = "0x4003C6D")]
		displayAfterText
	}
}
