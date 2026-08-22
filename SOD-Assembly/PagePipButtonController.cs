using System;
using Il2CppDummyDll;

// Token: 0x02000613 RID: 1555
[Token(Token = "0x2000613")]
public class PagePipButtonController : ButtonController
{
	// Token: 0x0600222D RID: 8749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600222D")]
	[Address(RVA = "0xB285B0", Offset = "0xB275B0", VA = "0x180B285B0", Slot = "17")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600222E")]
	[Address(RVA = "0xB28870", Offset = "0xB27870", VA = "0x180B28870", Slot = "10")]
	public override void VisualUpdate()
	{
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600222F")]
	[Address(RVA = "0xB28AC0", Offset = "0xB27AC0", VA = "0x180B28AC0")]
	public PagePipButtonController()
	{
	}

	// Token: 0x04002BDD RID: 11229
	[Token(Token = "0x4002BDD")]
	[FieldOffset(Offset = "0x1A8")]
	public WindowContentController wcc;

	// Token: 0x04002BDE RID: 11230
	[Token(Token = "0x4002BDE")]
	[FieldOffset(Offset = "0x1B0")]
	public int page;
}
