using System;
using Il2CppDummyDll;

// Token: 0x0200057C RID: 1404
[Token(Token = "0x200057C")]
public class DialogButtonController : ButtonController
{
	// Token: 0x06001E67 RID: 7783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E67")]
	[Address(RVA = "0xA4FCF0", Offset = "0xA4ECF0", VA = "0x180A4FCF0")]
	public void Setup(EvidenceWitness.DialogOption newPreset)
	{
	}

	// Token: 0x06001E68 RID: 7784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E68")]
	[Address(RVA = "0xA4FD90", Offset = "0xA4ED90", VA = "0x180A4FD90", Slot = "11")]
	public override void UpdateButtonText()
	{
	}

	// Token: 0x06001E69 RID: 7785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E69")]
	[Address(RVA = "0xA50390", Offset = "0xA4F390", VA = "0x180A50390")]
	public void SetSelectable(bool val)
	{
	}

	// Token: 0x06001E6A RID: 7786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E6A")]
	[Address(RVA = "0xA50440", Offset = "0xA4F440", VA = "0x180A50440")]
	public DialogButtonController()
	{
	}

	// Token: 0x0400270F RID: 9999
	[Token(Token = "0x400270F")]
	[FieldOffset(Offset = "0x1A8")]
	public EvidenceWitness.DialogOption option;

	// Token: 0x04002710 RID: 10000
	[Token(Token = "0x4002710")]
	[FieldOffset(Offset = "0x1B0")]
	public bool selectable;
}
