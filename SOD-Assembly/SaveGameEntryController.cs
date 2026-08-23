using System;
using System.IO;
using Il2CppDummyDll;

// Token: 0x02000659 RID: 1625
[Token(Token = "0x2000659")]
public class SaveGameEntryController : ButtonController
{
	// Token: 0x060023D6 RID: 9174 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023D6")]
	[Address(RVA = "0xB73FE0", Offset = "0xB72FE0", VA = "0x180B73FE0")]
	public void Setup(FileInfo newInfo)
	{
	}

	// Token: 0x060023D7 RID: 9175 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023D7")]
	[Address(RVA = "0xB74080", Offset = "0xB73080", VA = "0x180B74080", Slot = "11")]
	public override void UpdateButtonText()
	{
	}

	// Token: 0x060023D8 RID: 9176 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023D8")]
	[Address(RVA = "0xB743B0", Offset = "0xB733B0", VA = "0x180B743B0", Slot = "17")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x060023D9 RID: 9177 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023D9")]
	[Address(RVA = "0xA2C450", Offset = "0xA2B450", VA = "0x180A2C450")]
	public SaveGameEntryController()
	{
	}

	// Token: 0x04002DCF RID: 11727
	[Token(Token = "0x4002DCF")]
	[FieldOffset(Offset = "0x1A8")]
	public FileInfo info;

	// Token: 0x04002DD0 RID: 11728
	[Token(Token = "0x4002DD0")]
	[FieldOffset(Offset = "0x1B0")]
	public bool selected;

	// Token: 0x04002DD1 RID: 11729
	[Token(Token = "0x4002DD1")]
	[FieldOffset(Offset = "0x1B1")]
	public bool isInternal;
}
