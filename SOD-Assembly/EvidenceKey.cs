using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020006F0 RID: 1776
[Token(Token = "0x20006F0")]
public class EvidenceKey : Evidence
{
	// Token: 0x0600279C RID: 10140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600279C")]
	[Address(RVA = "0xC0C6F0", Offset = "0xC0B6F0", VA = "0x180C0C6F0")]
	public EvidenceKey(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x0400329B RID: 12955
	[Token(Token = "0x400329B")]
	[FieldOffset(Offset = "0x150")]
	public NewRoom keyTo;
}
