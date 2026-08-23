using System;
using Il2CppDummyDll;

// Token: 0x020000F2 RID: 242
[Token(Token = "0x20000F2")]
public class Unemployed
{
	// Token: 0x06000688 RID: 1672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000688")]
	[Address(RVA = "0xE20C70", Offset = "0xE1FC70", VA = "0x180E20C70")]
	public Unemployed()
	{
	}

	// Token: 0x04000715 RID: 1813
	[Token(Token = "0x4000715")]
	[FieldOffset(Offset = "0x10")]
	public Unemployed.UnemployedType type;

	// Token: 0x04000716 RID: 1814
	[Token(Token = "0x4000716")]
	[FieldOffset(Offset = "0x14")]
	public float stateSalary;

	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x20000F3")]
	public enum UnemployedType
	{
		// Token: 0x04000718 RID: 1816
		[Token(Token = "0x4000718")]
		Student,
		// Token: 0x04000719 RID: 1817
		[Token(Token = "0x4000719")]
		Retired,
		// Token: 0x0400071A RID: 1818
		[Token(Token = "0x400071A")]
		Unemployed,
		// Token: 0x0400071B RID: 1819
		[Token(Token = "0x400071B")]
		Prison
	}
}
