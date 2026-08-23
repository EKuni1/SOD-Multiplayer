using System;
using Il2CppDummyDll;

// Token: 0x0200060D RID: 1549
[Token(Token = "0x200060D")]
public class LinkButtonController : ButtonController
{
	// Token: 0x0600221B RID: 8731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600221B")]
	[Address(RVA = "0xB24560", Offset = "0xB23560", VA = "0x180B24560")]
	public void Setup(string newLinkID, TMP_SelectionController newSelectionController)
	{
	}

	// Token: 0x0600221C RID: 8732 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600221C")]
	[Address(RVA = "0xB249F0", Offset = "0xB239F0", VA = "0x180B249F0", Slot = "17")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x0600221D RID: 8733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600221D")]
	[Address(RVA = "0xA2C450", Offset = "0xA2B450", VA = "0x180A2C450")]
	public LinkButtonController()
	{
	}

	// Token: 0x04002BC9 RID: 11209
	[Token(Token = "0x4002BC9")]
	[FieldOffset(Offset = "0x1A8")]
	private TMP_SelectionController selectionController;

	// Token: 0x04002BCA RID: 11210
	[Token(Token = "0x4002BCA")]
	[FieldOffset(Offset = "0x1B0")]
	private string linkID;
}
