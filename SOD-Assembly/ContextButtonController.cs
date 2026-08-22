using System;
using Il2CppDummyDll;

// Token: 0x0200056B RID: 1387
[Token(Token = "0x200056B")]
public class ContextButtonController : ButtonController
{
	// Token: 0x06001E33 RID: 7731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E33")]
	[Address(RVA = "0xA47940", Offset = "0xA46940", VA = "0x180A47940")]
	public void Setup(ContextMenuController newCmc, ContextMenuPanelController newPanel, ContextMenuController.ContextMenuButtonSetup newSetup)
	{
	}

	// Token: 0x06001E34 RID: 7732 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E34")]
	[Address(RVA = "0xA47B90", Offset = "0xA46B90", VA = "0x180A47B90", Slot = "11")]
	public override void UpdateButtonText()
	{
	}

	// Token: 0x06001E35 RID: 7733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E35")]
	[Address(RVA = "0xA47EC0", Offset = "0xA46EC0", VA = "0x180A47EC0", Slot = "17")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x06001E36 RID: 7734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E36")]
	[Address(RVA = "0xA2C450", Offset = "0xA2B450", VA = "0x180A2C450")]
	public ContextButtonController()
	{
	}

	// Token: 0x040026B6 RID: 9910
	[Token(Token = "0x40026B6")]
	[FieldOffset(Offset = "0x1A8")]
	public ContextMenuController cmc;

	// Token: 0x040026B7 RID: 9911
	[Token(Token = "0x40026B7")]
	[FieldOffset(Offset = "0x1B0")]
	public ContextMenuPanelController panelController;

	// Token: 0x040026B8 RID: 9912
	[Token(Token = "0x40026B8")]
	[FieldOffset(Offset = "0x1B8")]
	public ContextMenuController.ContextMenuButtonSetup setup;
}
