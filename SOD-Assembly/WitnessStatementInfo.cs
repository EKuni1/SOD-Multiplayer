using System;
using Il2CppDummyDll;

// Token: 0x020006C4 RID: 1732
[Token(Token = "0x20006C4")]
public class WitnessStatementInfo
{
	// Token: 0x060026AF RID: 9903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60026AF")]
	[Address(RVA = "0x417E30", Offset = "0x416E30", VA = "0x180417E30")]
	public WitnessStatementInfo(Citizen newCit, WitnessStatementInfo.StatementType newStatementType)
	{
	}

	// Token: 0x04003208 RID: 12808
	[Token(Token = "0x4003208")]
	[FieldOffset(Offset = "0x10")]
	public Citizen citizen;

	// Token: 0x04003209 RID: 12809
	[Token(Token = "0x4003209")]
	[FieldOffset(Offset = "0x18")]
	public WitnessStatementInfo.StatementType statementType;

	// Token: 0x020006C5 RID: 1733
	[Token(Token = "0x20006C5")]
	public enum StatementType
	{
		// Token: 0x0400320B RID: 12811
		[Token(Token = "0x400320B")]
		Alibi,
		// Token: 0x0400320C RID: 12812
		[Token(Token = "0x400320C")]
		knowVictim
	}
}
