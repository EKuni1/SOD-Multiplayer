using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000247 RID: 583
[Token(Token = "0x2000247")]
[Serializable]
public class AddressSaveData
{
	// Token: 0x06000D48 RID: 3400 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D48")]
	[Address(RVA = "0x5E6AF0", Offset = "0x5E5AF0", VA = "0x1805E6AF0")]
	public AddressSaveData()
	{
	}

	// Token: 0x04000EBD RID: 3773
	[Token(Token = "0x4000EBD")]
	[FieldOffset(Offset = "0x10")]
	public string p_n;

	// Token: 0x04000EBE RID: 3774
	[Token(Token = "0x4000EBE")]
	[FieldOffset(Offset = "0x18")]
	public Color e_c;

	// Token: 0x04000EBF RID: 3775
	[Token(Token = "0x4000EBF")]
	[FieldOffset(Offset = "0x28")]
	public List<AddressLayoutVariation> vs;
}
