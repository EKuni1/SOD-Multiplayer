using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200051C RID: 1308
[Token(Token = "0x200051C")]
[Serializable]
public class TwitchRootObject
{
	// Token: 0x06001C15 RID: 7189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C15")]
	[Address(RVA = "0x9D0F30", Offset = "0x9CFF30", VA = "0x1809D0F30")]
	public TwitchRootObject()
	{
	}

	// Token: 0x040024D6 RID: 9430
	[Token(Token = "0x40024D6")]
	[FieldOffset(Offset = "0x10")]
	public List<TwitchUserData> data;
}
