using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020006E6 RID: 1766
[Token(Token = "0x20006E6")]
public class EvidenceBuilding : Evidence
{
	// Token: 0x0600276E RID: 10094 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600276E")]
	[Address(RVA = "0xC038F0", Offset = "0xC028F0", VA = "0x180C038F0")]
	public EvidenceBuilding(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x0600276F RID: 10095 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600276F")]
	[Address(RVA = "0xC03A00", Offset = "0xC02A00", VA = "0x180C03A00", Slot = "24")]
	public override string GetNoteComposed(List<Evidence.DataKey> keys, bool useLinks = true)
	{
		return null;
	}

	// Token: 0x06002770 RID: 10096 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002770")]
	[Address(RVA = "0xC03AC0", Offset = "0xC02AC0", VA = "0x180C03AC0", Slot = "22")]
	public override string GetSummary(List<Evidence.DataKey> keys)
	{
		return null;
	}

	// Token: 0x06002771 RID: 10097 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002771")]
	[Address(RVA = "0xC03DD0", Offset = "0xC02DD0", VA = "0x180C03DD0", Slot = "8")]
	public override string GenerateName()
	{
		return null;
	}

	// Token: 0x06002772 RID: 10098 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002772")]
	[Address(RVA = "0xC03E00", Offset = "0xC02E00", VA = "0x180C03E00", Slot = "23")]
	public override string GetNote(List<Evidence.DataKey> keys)
	{
		return null;
	}

	// Token: 0x0400328E RID: 12942
	[Token(Token = "0x400328E")]
	[FieldOffset(Offset = "0x150")]
	public NewBuilding building;
}
