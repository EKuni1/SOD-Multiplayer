using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007A4 RID: 1956
[Token(Token = "0x20007A4")]
public class ColourPalettePreset : SoCustomComparison
{
	// Token: 0x0600293B RID: 10555 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600293B")]
	[Address(RVA = "0xCA2010", Offset = "0xCA1010", VA = "0x180CA2010")]
	public ColourPalettePreset()
	{
	}

	// Token: 0x04003857 RID: 14423
	[Token(Token = "0x4003857")]
	[FieldOffset(Offset = "0x20")]
	public List<ColourPalettePreset.MaterialSettings> colours;

	// Token: 0x04003858 RID: 14424
	[Token(Token = "0x4003858")]
	[FieldOffset(Offset = "0x28")]
	public HEXACO hexaco;

	// Token: 0x020007A5 RID: 1957
	[Token(Token = "0x20007A5")]
	[Serializable]
	public class MaterialSettings
	{
		// Token: 0x0600293C RID: 10556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600293C")]
		[Address(RVA = "0xCA1F20", Offset = "0xCA0F20", VA = "0x180CA1F20")]
		public MaterialSettings()
		{
		}

		// Token: 0x04003859 RID: 14425
		[Token(Token = "0x4003859")]
		[FieldOffset(Offset = "0x10")]
		public Color colour;

		// Token: 0x0400385A RID: 14426
		[Token(Token = "0x400385A")]
		[FieldOffset(Offset = "0x20")]
		public int weighting;
	}
}
