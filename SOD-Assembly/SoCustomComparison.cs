using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200088E RID: 2190
[Token(Token = "0x200088E")]
public class SoCustomComparison : ScriptableObject
{
	// Token: 0x060029F8 RID: 10744 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
	[Token(Token = "0x60029F8")]
	[Address(RVA = "0xA10FF0", Offset = "0xA0FFF0", VA = "0x180A10FF0")]
	public bool Equals(SoCustomComparison other)
	{
		return default(bool);
	}

	// Token: 0x060029F9 RID: 10745 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60029F9")]
	[Address(RVA = "0xCB3730", Offset = "0xCB2730", VA = "0x180CB3730", Slot = "4")]
	public virtual string GetPresetName()
	{
		return null;
	}

	// Token: 0x060029FA RID: 10746 RVA: 0x0000FB10 File Offset: 0x0000DD10
	[Token(Token = "0x60029FA")]
	[Address(RVA = "0xCB37C0", Offset = "0xCB27C0", VA = "0x180CB37C0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	// Token: 0x060029FB RID: 10747 RVA: 0x0000FB28 File Offset: 0x0000DD28
	[Token(Token = "0x60029FB")]
	[Address(RVA = "0xCB3960", Offset = "0xCB2960", VA = "0x180CB3960", Slot = "2")]
	public override int GetHashCode()
	{
		return 0;
	}

	// Token: 0x060029FC RID: 10748 RVA: 0x0000FB40 File Offset: 0x0000DD40
	[Token(Token = "0x60029FC")]
	[Address(RVA = "0xCB3AF0", Offset = "0xCB2AF0", VA = "0x180CB3AF0")]
	public static bool operator ==(SoCustomComparison c1, SoCustomComparison c2)
	{
		return default(bool);
	}

	// Token: 0x060029FD RID: 10749 RVA: 0x0000FB58 File Offset: 0x0000DD58
	[Token(Token = "0x60029FD")]
	[Address(RVA = "0xCB3B30", Offset = "0xCB2B30", VA = "0x180CB3B30")]
	public static bool operator !=(SoCustomComparison c1, SoCustomComparison c2)
	{
		return default(bool);
	}

	// Token: 0x060029FE RID: 10750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029FE")]
	[Address(RVA = "0x5C7970", Offset = "0x5C6970", VA = "0x1805C7970")]
	public SoCustomComparison()
	{
	}

	// Token: 0x04004326 RID: 17190
	[Token(Token = "0x4004326")]
	[FieldOffset(Offset = "0x18")]
	public string presetName;
}
