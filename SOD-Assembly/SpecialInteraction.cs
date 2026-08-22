using System;
using Il2CppDummyDll;

// Token: 0x020002EA RID: 746
[Token(Token = "0x20002EA")]
[Serializable]
public struct SpecialInteraction
{
	// Token: 0x040013EB RID: 5099
	[Token(Token = "0x40013EB")]
	[FieldOffset(Offset = "0x0")]
	public SpecialInteraction.Frequency frequency;

	// Token: 0x040013EC RID: 5100
	[Token(Token = "0x40013EC")]
	[FieldOffset(Offset = "0x4")]
	public SpecialInteraction.OthersLabels othersLabels;

	// Token: 0x040013ED RID: 5101
	[Token(Token = "0x40013ED")]
	[FieldOffset(Offset = "0x8")]
	public SpecialInteraction.SpecialEffects specialEffects;

	// Token: 0x040013EE RID: 5102
	[Token(Token = "0x40013EE")]
	[FieldOffset(Offset = "0x10")]
	public Wizcard wizcardToSpawn;

	// Token: 0x040013EF RID: 5103
	[Token(Token = "0x40013EF")]
	[FieldOffset(Offset = "0x18")]
	public int extraAttack;

	// Token: 0x040013F0 RID: 5104
	[Token(Token = "0x40013F0")]
	[FieldOffset(Offset = "0x1C")]
	public int extraHealth;

	// Token: 0x040013F1 RID: 5105
	[Token(Token = "0x40013F1")]
	[FieldOffset(Offset = "0x20")]
	public int bonusDamage;

	// Token: 0x020002EB RID: 747
	[Token(Token = "0x20002EB")]
	public enum Frequency
	{
		// Token: 0x040013F3 RID: 5107
		[Token(Token = "0x40013F3")]
		None,
		// Token: 0x040013F4 RID: 5108
		[Token(Token = "0x40013F4")]
		WhenSpawned,
		// Token: 0x040013F5 RID: 5109
		[Token(Token = "0x40013F5")]
		EveryTurn,
		// Token: 0x040013F6 RID: 5110
		[Token(Token = "0x40013F6")]
		WhenDies = 4
	}

	// Token: 0x020002EC RID: 748
	[Token(Token = "0x20002EC")]
	public enum OthersLabels
	{
		// Token: 0x040013F8 RID: 5112
		[Token(Token = "0x40013F8")]
		None,
		// Token: 0x040013F9 RID: 5113
		[Token(Token = "0x40013F9")]
		Monster,
		// Token: 0x040013FA RID: 5114
		[Token(Token = "0x40013FA")]
		Animal,
		// Token: 0x040013FB RID: 5115
		[Token(Token = "0x40013FB")]
		Building = 4,
		// Token: 0x040013FC RID: 5116
		[Token(Token = "0x40013FC")]
		Metallic = 8,
		// Token: 0x040013FD RID: 5117
		[Token(Token = "0x40013FD")]
		Wooden = 16,
		// Token: 0x040013FE RID: 5118
		[Token(Token = "0x40013FE")]
		Human = 32,
		// Token: 0x040013FF RID: 5119
		[Token(Token = "0x40013FF")]
		Mage = 64,
		// Token: 0x04001400 RID: 5120
		[Token(Token = "0x4001400")]
		Fabric = 128
	}

	// Token: 0x020002ED RID: 749
	[Token(Token = "0x20002ED")]
	public enum SpecialEffects
	{
		// Token: 0x04001402 RID: 5122
		[Token(Token = "0x4001402")]
		None,
		// Token: 0x04001403 RID: 5123
		[Token(Token = "0x4001403")]
		DoubleHP,
		// Token: 0x04001404 RID: 5124
		[Token(Token = "0x4001404")]
		DoubleAttack,
		// Token: 0x04001405 RID: 5125
		[Token(Token = "0x4001405")]
		DoubleMana = 4
	}
}
