using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000887 RID: 2183
[Token(Token = "0x2000887")]
public class RoomTypeFilter : SoCustomComparison
{
	// Token: 0x060029ED RID: 10733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029ED")]
	[Address(RVA = "0xCB2AE0", Offset = "0xCB1AE0", VA = "0x180CB2AE0")]
	public RoomTypeFilter()
	{
	}

	// Token: 0x040042D5 RID: 17109
	[Token(Token = "0x40042D5")]
	[FieldOffset(Offset = "0x20")]
	public List<RoomClassPreset> roomClasses;
}
