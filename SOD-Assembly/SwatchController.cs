using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200068E RID: 1678
[Token(Token = "0x200068E")]
public class SwatchController : ButtonController
{
	// Token: 0x06002537 RID: 9527 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002537")]
	[Address(RVA = "0xBB7950", Offset = "0xBB6950", VA = "0x180BB7950")]
	public void Setup(Color newColor, ColourPickerController newController)
	{
	}

	// Token: 0x06002538 RID: 9528 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002538")]
	[Address(RVA = "0xBB79E0", Offset = "0xBB69E0", VA = "0x180BB79E0", Slot = "17")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x06002539 RID: 9529 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002539")]
	[Address(RVA = "0xA2C450", Offset = "0xA2B450", VA = "0x180A2C450")]
	public SwatchController()
	{
	}

	// Token: 0x04002F74 RID: 12148
	[Token(Token = "0x4002F74")]
	[FieldOffset(Offset = "0x1A8")]
	private ColourPickerController controller;
}
