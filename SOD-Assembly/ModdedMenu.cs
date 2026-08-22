using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020006C0 RID: 1728
[Token(Token = "0x20006C0")]
[Serializable]
public class ModdedMenu
{
	// Token: 0x060026AB RID: 9899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026AB")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public ModdedMenu()
	{
	}

	// Token: 0x04003199 RID: 12697
	[Token(Token = "0x4003199")]
	[FieldOffset(Offset = "0x10")]
	public string copyDataFrom;

	// Token: 0x0400319A RID: 12698
	[Token(Token = "0x400319A")]
	[FieldOffset(Offset = "0x18")]
	public string presetName;

	// Token: 0x0400319B RID: 12699
	[Token(Token = "0x400319B")]
	[FieldOffset(Offset = "0x20")]
	public List<string> itemsSold;

	// Token: 0x0400319C RID: 12700
	[Token(Token = "0x400319C")]
	[FieldOffset(Offset = "0x28")]
	public string createReceipt;

	// Token: 0x0400319D RID: 12701
	[Token(Token = "0x400319D")]
	[FieldOffset(Offset = "0x30")]
	public string syncDiskSlots;

	// Token: 0x0400319E RID: 12702
	[Token(Token = "0x400319E")]
	[FieldOffset(Offset = "0x38")]
	public List<string> fromManufacturers;

	// Token: 0x0400319F RID: 12703
	[Token(Token = "0x400319F")]
	[FieldOffset(Offset = "0x40")]
	public List<string> syncDisks;
}
