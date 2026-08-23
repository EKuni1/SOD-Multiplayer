using System;
using Il2CppDummyDll;
using TMPro;

// Token: 0x02000610 RID: 1552
[Token(Token = "0x2000610")]
public class ObjectiveContentListEntry : ButtonController
{
	// Token: 0x06002224 RID: 8740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002224")]
	[Address(RVA = "0xB27720", Offset = "0xB26720", VA = "0x180B27720")]
	public void Setup(ObjectivesContentController newController, Case.ResolveQuestion newStarting)
	{
	}

	// Token: 0x06002225 RID: 8741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002225")]
	[Address(RVA = "0xB27830", Offset = "0xB26830", VA = "0x180B27830", Slot = "10")]
	public override void VisualUpdate()
	{
	}

	// Token: 0x06002226 RID: 8742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002226")]
	[Address(RVA = "0xA2C450", Offset = "0xA2B450", VA = "0x180A2C450")]
	public ObjectiveContentListEntry()
	{
	}

	// Token: 0x04002BD2 RID: 11218
	[Token(Token = "0x4002BD2")]
	[FieldOffset(Offset = "0x1A8")]
	public TextMeshProUGUI objectiveText;

	// Token: 0x04002BD3 RID: 11219
	[Token(Token = "0x4002BD3")]
	[FieldOffset(Offset = "0x1B0")]
	public Case.ResolveQuestion question;

	// Token: 0x04002BD4 RID: 11220
	[Token(Token = "0x4002BD4")]
	[FieldOffset(Offset = "0x1B8")]
	public ObjectivesContentController objectivesController;
}
