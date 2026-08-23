using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000787 RID: 1927
[Token(Token = "0x2000787")]
public class BroadcastSchedule : SoCustomComparison
{
	// Token: 0x06002916 RID: 10518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002916")]
	[Address(RVA = "0xC690D0", Offset = "0xC680D0", VA = "0x180C690D0")]
	public BroadcastSchedule()
	{
	}

	// Token: 0x0400372A RID: 14122
	[Token(Token = "0x400372A")]
	[FieldOffset(Offset = "0x20")]
	public List<BroadcastPreset> broadcasts;
}
