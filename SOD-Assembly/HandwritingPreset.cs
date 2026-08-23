using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;

// Token: 0x02000806 RID: 2054
[Token(Token = "0x2000806")]
public class HandwritingPreset : SoCustomComparison
{
	// Token: 0x0600298B RID: 10635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600298B")]
	[Address(RVA = "0xCA9520", Offset = "0xCA8520", VA = "0x180CA9520")]
	public HandwritingPreset()
	{
	}

	// Token: 0x04003C61 RID: 15457
	[Token(Token = "0x4003C61")]
	[FieldOffset(Offset = "0x20")]
	public TMP_FontAsset fontAsset;

	// Token: 0x04003C62 RID: 15458
	[Token(Token = "0x4003C62")]
	[FieldOffset(Offset = "0x28")]
	public float baseChance;

	// Token: 0x04003C63 RID: 15459
	[Token(Token = "0x4003C63")]
	[FieldOffset(Offset = "0x30")]
	public List<CharacterTrait.TraitPickRule> characterTraits;
}
