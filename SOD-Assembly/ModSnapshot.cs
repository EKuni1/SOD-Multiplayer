using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200050D RID: 1293
[Token(Token = "0x200050D")]
[Serializable]
public class ModSnapshot
{
	// Token: 0x06001BC7 RID: 7111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BC7")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public ModSnapshot()
	{
	}

	// Token: 0x04002480 RID: 9344
	[Token(Token = "0x4002480")]
	[FieldOffset(Offset = "0x10")]
	public List<SteamMod> orderedMods;
}
