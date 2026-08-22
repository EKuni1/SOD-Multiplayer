using System;
using Il2CppDummyDll;

// Token: 0x02000204 RID: 516
[Token(Token = "0x2000204")]
[Serializable]
public class DDSBundle
{
	// Token: 0x06000C5B RID: 3163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0x596000", Offset = "0x595000", VA = "0x180596000")]
	public DDSBundle()
	{
	}

	// Token: 0x04000CC3 RID: 3267
	[Token(Token = "0x4000CC3")]
	[FieldOffset(Offset = "0x10")]
	public string displayName;

	// Token: 0x04000CC4 RID: 3268
	[Token(Token = "0x4000CC4")]
	[FieldOffset(Offset = "0x18")]
	public string description;

	// Token: 0x04000CC5 RID: 3269
	[Token(Token = "0x4000CC5")]
	[FieldOffset(Offset = "0x20")]
	public string languageCode;

	// Token: 0x04000CC6 RID: 3270
	[Token(Token = "0x4000CC6")]
	[FieldOffset(Offset = "0x28")]
	[NonSerialized]
	public string path;
}
