using System;
using Il2CppDummyDll;

// Token: 0x0200051F RID: 1311
[Token(Token = "0x200051F")]
[Serializable]
public class Chatters
{
	// Token: 0x06001C18 RID: 7192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C18")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public Chatters()
	{
	}

	// Token: 0x040024E1 RID: 9441
	[Token(Token = "0x40024E1")]
	[FieldOffset(Offset = "0x10")]
	public string[] broadcaster;

	// Token: 0x040024E2 RID: 9442
	[Token(Token = "0x40024E2")]
	[FieldOffset(Offset = "0x18")]
	public string[] vips;

	// Token: 0x040024E3 RID: 9443
	[Token(Token = "0x40024E3")]
	[FieldOffset(Offset = "0x20")]
	public string[] moderators;

	// Token: 0x040024E4 RID: 9444
	[Token(Token = "0x40024E4")]
	[FieldOffset(Offset = "0x28")]
	public string[] staff;

	// Token: 0x040024E5 RID: 9445
	[Token(Token = "0x40024E5")]
	[FieldOffset(Offset = "0x30")]
	public string[] admins;

	// Token: 0x040024E6 RID: 9446
	[Token(Token = "0x40024E6")]
	[FieldOffset(Offset = "0x38")]
	public string[] global_mods;

	// Token: 0x040024E7 RID: 9447
	[Token(Token = "0x40024E7")]
	[FieldOffset(Offset = "0x40")]
	public string[] viewers;
}
