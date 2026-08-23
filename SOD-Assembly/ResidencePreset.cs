using System;
using Il2CppDummyDll;

// Token: 0x02000870 RID: 2160
[Token(Token = "0x2000870")]
public class ResidencePreset : SoCustomComparison
{
	// Token: 0x060029D9 RID: 10713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029D9")]
	[Address(RVA = "0xCB0B20", Offset = "0xCAFB20", VA = "0x180CB0B20")]
	public ResidencePreset()
	{
	}

	// Token: 0x040041C7 RID: 16839
	[Token(Token = "0x40041C7")]
	[FieldOffset(Offset = "0x20")]
	public bool habitable;

	// Token: 0x040041C8 RID: 16840
	[Token(Token = "0x40041C8")]
	[FieldOffset(Offset = "0x21")]
	public bool enableForSale;

	// Token: 0x040041C9 RID: 16841
	[Token(Token = "0x40041C9")]
	[FieldOffset(Offset = "0x22")]
	public bool furnitureIfUnihabited;

	// Token: 0x040041CA RID: 16842
	[Token(Token = "0x40041CA")]
	[FieldOffset(Offset = "0x23")]
	public bool isHotelRoom;
}
