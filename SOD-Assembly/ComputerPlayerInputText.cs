using System;
using Il2CppDummyDll;
using TMPro;

// Token: 0x020002C9 RID: 713
[Token(Token = "0x20002C9")]
public class ComputerPlayerInputText : CruncherAppContent
{
	// Token: 0x06000FE9 RID: 4073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE9")]
	[Address(RVA = "0x68A410", Offset = "0x689410", VA = "0x18068A410", Slot = "5")]
	public override void OnSetup()
	{
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEA")]
	[Address(RVA = "0x68A600", Offset = "0x689600", VA = "0x18068A600")]
	private void Update()
	{
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEB")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ComputerPlayerInputText()
	{
	}

	// Token: 0x04001315 RID: 4885
	[Token(Token = "0x4001315")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI text;

	// Token: 0x04001316 RID: 4886
	[Token(Token = "0x4001316")]
	[FieldOffset(Offset = "0x28")]
	public string startingTextKey;

	// Token: 0x04001317 RID: 4887
	[Token(Token = "0x4001317")]
	[FieldOffset(Offset = "0x30")]
	public string fullTextKey;

	// Token: 0x04001318 RID: 4888
	[Token(Token = "0x4001318")]
	[FieldOffset(Offset = "0x38")]
	private string fullText;

	// Token: 0x04001319 RID: 4889
	[Token(Token = "0x4001319")]
	[FieldOffset(Offset = "0x40")]
	public float keystrokes;

	// Token: 0x0400131A RID: 4890
	[Token(Token = "0x400131A")]
	[FieldOffset(Offset = "0x44")]
	public int charsDisplayed;

	// Token: 0x0400131B RID: 4891
	[Token(Token = "0x400131B")]
	[FieldOffset(Offset = "0x48")]
	public bool displayCursor;

	// Token: 0x0400131C RID: 4892
	[Token(Token = "0x400131C")]
	[FieldOffset(Offset = "0x4C")]
	public float cursorTimer;

	// Token: 0x0400131D RID: 4893
	[Token(Token = "0x400131D")]
	[FieldOffset(Offset = "0x50")]
	private string revealedText;
}
