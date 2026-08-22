using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020006EB RID: 1771
[Token(Token = "0x20006EB")]
public class EvidenceDebug : Evidence
{
	// Token: 0x06002786 RID: 10118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002786")]
	[Address(RVA = "0xC09C70", Offset = "0xC08C70", VA = "0x180C09C70")]
	public EvidenceDebug(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x06002787 RID: 10119 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002787")]
	[Address(RVA = "0xC09D20", Offset = "0xC08D20", VA = "0x180C09D20", Slot = "8")]
	public override string GenerateName()
	{
		return null;
	}

	// Token: 0x04003295 RID: 12949
	[Token(Token = "0x4003295")]
	[FieldOffset(Offset = "0x0")]
	public static int assignID;

	// Token: 0x04003296 RID: 12950
	[Token(Token = "0x4003296")]
	[FieldOffset(Offset = "0x150")]
	public int id;
}
