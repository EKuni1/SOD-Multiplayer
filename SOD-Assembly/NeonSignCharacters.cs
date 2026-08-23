using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200085F RID: 2143
[Token(Token = "0x200085F")]
public class NeonSignCharacters : SoCustomComparison
{
	// Token: 0x060029D0 RID: 10704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029D0")]
	[Address(RVA = "0xCAFEB0", Offset = "0xCAEEB0", VA = "0x180CAFEB0")]
	public NeonSignCharacters()
	{
	}

	// Token: 0x040040E9 RID: 16617
	[Token(Token = "0x40040E9")]
	[FieldOffset(Offset = "0x20")]
	public List<NeonSignCharacters.NeonCharacter> characterList;

	// Token: 0x02000860 RID: 2144
	[Token(Token = "0x2000860")]
	[Serializable]
	public class NeonCharacter
	{
		// Token: 0x060029D1 RID: 10705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029D1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public NeonCharacter()
		{
		}

		// Token: 0x040040EA RID: 16618
		[Token(Token = "0x40040EA")]
		[FieldOffset(Offset = "0x10")]
		public string character;

		// Token: 0x040040EB RID: 16619
		[Token(Token = "0x40040EB")]
		[FieldOffset(Offset = "0x18")]
		public GameObject prefab;
	}
}
