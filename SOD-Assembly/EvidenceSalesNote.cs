using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000708 RID: 1800
[Token(Token = "0x2000708")]
public class EvidenceSalesNote : Evidence
{
	// Token: 0x060027E8 RID: 10216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027E8")]
	[Address(RVA = "0xC13280", Offset = "0xC12280", VA = "0x180C13280")]
	public EvidenceSalesNote(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x040032CF RID: 13007
	[Token(Token = "0x40032CF")]
	[FieldOffset(Offset = "0x150")]
	public NewAddress forSale;
}
