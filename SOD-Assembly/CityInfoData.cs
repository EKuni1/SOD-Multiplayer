using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004C8 RID: 1224
[Token(Token = "0x20004C8")]
[Serializable]
public class CityInfoData
{
	// Token: 0x06001B6B RID: 7019 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B6B")]
	[Address(RVA = "0x9BA2F0", Offset = "0x9B92F0", VA = "0x1809BA2F0")]
	public CityInfoData()
	{
	}

	// Token: 0x0400219D RID: 8605
	[Token(Token = "0x400219D")]
	[FieldOffset(Offset = "0x10")]
	public string cityName;

	// Token: 0x0400219E RID: 8606
	[Token(Token = "0x400219E")]
	[FieldOffset(Offset = "0x18")]
	public string build;

	// Token: 0x0400219F RID: 8607
	[Token(Token = "0x400219F")]
	[FieldOffset(Offset = "0x20")]
	public string shareCode;

	// Token: 0x040021A0 RID: 8608
	[Token(Token = "0x40021A0")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 citySize;

	// Token: 0x040021A1 RID: 8609
	[Token(Token = "0x40021A1")]
	[FieldOffset(Offset = "0x30")]
	public int population;
}
