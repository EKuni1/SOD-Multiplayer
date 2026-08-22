using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007BF RID: 1983
[Token(Token = "0x20007BF")]
public class DDSScope : SoCustomComparison
{
	// Token: 0x06002950 RID: 10576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002950")]
	[Address(RVA = "0xCA30D0", Offset = "0xCA20D0", VA = "0x180CA30D0")]
	public DDSScope()
	{
	}

	// Token: 0x04003911 RID: 14609
	[Token(Token = "0x4003911")]
	[FieldOffset(Offset = "0x20")]
	public Color colour;

	// Token: 0x04003912 RID: 14610
	[Token(Token = "0x4003912")]
	[FieldOffset(Offset = "0x30")]
	public bool isGlobal;

	// Token: 0x04003913 RID: 14611
	[Token(Token = "0x4003913")]
	[FieldOffset(Offset = "0x34")]
	public DDSScope.SpecialCase specialCase;

	// Token: 0x04003914 RID: 14612
	[Token(Token = "0x4003914")]
	[FieldOffset(Offset = "0x38")]
	public List<DDSScope.ContainedScope> containedScopes;

	// Token: 0x04003915 RID: 14613
	[Token(Token = "0x4003915")]
	[FieldOffset(Offset = "0x40")]
	public List<string> containedValues;

	// Token: 0x020007C0 RID: 1984
	[Token(Token = "0x20007C0")]
	public enum SpecialCase
	{
		// Token: 0x04003917 RID: 14615
		[Token(Token = "0x4003917")]
		none
	}

	// Token: 0x020007C1 RID: 1985
	[Token(Token = "0x20007C1")]
	[Serializable]
	public class ContainedScope
	{
		// Token: 0x06002951 RID: 10577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002951")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ContainedScope()
		{
		}

		// Token: 0x04003918 RID: 14616
		[Token(Token = "0x4003918")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04003919 RID: 14617
		[Token(Token = "0x4003919")]
		[FieldOffset(Offset = "0x18")]
		public DDSScope type;
	}
}
