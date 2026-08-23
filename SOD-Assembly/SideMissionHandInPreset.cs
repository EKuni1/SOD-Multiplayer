using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200088A RID: 2186
[Token(Token = "0x200088A")]
public class SideMissionHandInPreset : SoCustomComparison
{
	// Token: 0x060029F5 RID: 10741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029F5")]
	[Address(RVA = "0xCB3120", Offset = "0xCB2120", VA = "0x180CB3120")]
	public SideMissionHandInPreset()
	{
	}

	// Token: 0x040042FB RID: 17147
	[Token(Token = "0x40042FB")]
	[FieldOffset(Offset = "0x20")]
	public int rewardModifier;

	// Token: 0x040042FC RID: 17148
	[Token(Token = "0x40042FC")]
	[FieldOffset(Offset = "0x24")]
	public bool postersDoor;

	// Token: 0x040042FD RID: 17149
	[Token(Token = "0x40042FD")]
	[FieldOffset(Offset = "0x25")]
	public bool cityHall;

	// Token: 0x040042FE RID: 17150
	[Token(Token = "0x40042FE")]
	[FieldOffset(Offset = "0x28")]
	public List<SideMissionIntroPreset.SideMissionObjectiveBlock> blocks;
}
