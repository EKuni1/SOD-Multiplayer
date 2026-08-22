using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200070C RID: 1804
[Token(Token = "0x200070C")]
public class EvidenceTelephoneCall : EvidenceTime
{
	// Token: 0x060027F5 RID: 10229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027F5")]
	[Address(RVA = "0xC15470", Offset = "0xC14470", VA = "0x180C15470")]
	public EvidenceTelephoneCall(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x040032D4 RID: 13012
	[Token(Token = "0x40032D4")]
	[FieldOffset(Offset = "0x160")]
	public Evidence callFrom;

	// Token: 0x040032D5 RID: 13013
	[Token(Token = "0x40032D5")]
	[FieldOffset(Offset = "0x168")]
	public Evidence callTo;
}
