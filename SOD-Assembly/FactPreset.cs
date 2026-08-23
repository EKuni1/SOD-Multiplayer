using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007E0 RID: 2016
[Token(Token = "0x20007E0")]
public class FactPreset : SoCustomComparison
{
	// Token: 0x0600296F RID: 10607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600296F")]
	[Address(RVA = "0xCA5C30", Offset = "0xCA4C30", VA = "0x180CA5C30")]
	public FactPreset()
	{
	}

	// Token: 0x04003A4E RID: 14926
	[Token(Token = "0x4003A4E")]
	[FieldOffset(Offset = "0x20")]
	public Sprite iconSpriteLarge;

	// Token: 0x04003A4F RID: 14927
	[Token(Token = "0x4003A4F")]
	[FieldOffset(Offset = "0x28")]
	public string subClass;

	// Token: 0x04003A50 RID: 14928
	[Token(Token = "0x4003A50")]
	[FieldOffset(Offset = "0x30")]
	public bool allowDuplicates;

	// Token: 0x04003A51 RID: 14929
	[Token(Token = "0x4003A51")]
	[FieldOffset(Offset = "0x31")]
	public bool allowReverseDuplicates;

	// Token: 0x04003A52 RID: 14930
	[Token(Token = "0x4003A52")]
	[FieldOffset(Offset = "0x38")]
	public List<Evidence.DataKey> fromDataKeys;

	// Token: 0x04003A53 RID: 14931
	[Token(Token = "0x4003A53")]
	[FieldOffset(Offset = "0x40")]
	public List<Evidence.DataKey> toDataKeys;

	// Token: 0x04003A54 RID: 14932
	[Token(Token = "0x4003A54")]
	[FieldOffset(Offset = "0x48")]
	public bool discoverOnCreate;

	// Token: 0x04003A55 RID: 14933
	[Token(Token = "0x4003A55")]
	[FieldOffset(Offset = "0x49")]
	public bool countsAsNewInformationOnDiscovery;

	// Token: 0x04003A56 RID: 14934
	[Token(Token = "0x4003A56")]
	[FieldOffset(Offset = "0x50")]
	public List<Evidence.DataKey> applyFromKeysOnDiscovery;

	// Token: 0x04003A57 RID: 14935
	[Token(Token = "0x4003A57")]
	[FieldOffset(Offset = "0x58")]
	public List<Evidence.DataKey> applyToKeysOnDiscovery;

	// Token: 0x04003A58 RID: 14936
	[Token(Token = "0x4003A58")]
	[FieldOffset(Offset = "0x60")]
	public List<Evidence.Discovery> discoveryTriggers;

	// Token: 0x04003A59 RID: 14937
	[Token(Token = "0x4003A59")]
	[FieldOffset(Offset = "0x68")]
	public int factRank;
}
