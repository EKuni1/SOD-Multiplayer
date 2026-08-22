using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020006F1 RID: 1777
[Token(Token = "0x20006F1")]
public class EvidenceLocation : Evidence
{
	// Token: 0x0600279D RID: 10141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600279D")]
	[Address(RVA = "0xC0C890", Offset = "0xC0B890", VA = "0x180C0C890")]
	public EvidenceLocation(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x0600279E RID: 10142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600279E")]
	[Address(RVA = "0xC0C9A0", Offset = "0xC0B9A0", VA = "0x180C0C9A0", Slot = "11")]
	public override void Compile()
	{
	}

	// Token: 0x0600279F RID: 10143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600279F")]
	[Address(RVA = "0xC0CD20", Offset = "0xC0BD20", VA = "0x180C0CD20", Slot = "15")]
	public override void MergeDataKeys(Evidence.DataKey keyOne, Evidence.DataKey keyTwo)
	{
	}

	// Token: 0x060027A0 RID: 10144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027A0")]
	[Address(RVA = "0xC0CD30", Offset = "0xC0BD30", VA = "0x180C0CD30")]
	public void OnPlayerArrival()
	{
	}

	// Token: 0x060027A1 RID: 10145 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027A1")]
	[Address(RVA = "0xC0D0C0", Offset = "0xC0C0C0", VA = "0x180C0D0C0", Slot = "24")]
	public override string GetNoteComposed(List<Evidence.DataKey> keys, bool useLinks = true)
	{
		return null;
	}

	// Token: 0x060027A2 RID: 10146 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027A2")]
	[Address(RVA = "0xC0D180", Offset = "0xC0C180", VA = "0x180C0D180", Slot = "22")]
	public override string GetSummary(List<Evidence.DataKey> keys)
	{
		return null;
	}

	// Token: 0x060027A3 RID: 10147 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027A3")]
	[Address(RVA = "0xC0D490", Offset = "0xC0C490", VA = "0x180C0D490", Slot = "8")]
	public override string GenerateName()
	{
		return null;
	}

	// Token: 0x060027A4 RID: 10148 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027A4")]
	[Address(RVA = "0xC0D4C0", Offset = "0xC0C4C0", VA = "0x180C0D4C0", Slot = "19")]
	public override string GetNameForDataKey(List<Evidence.DataKey> inputKeys)
	{
		return null;
	}

	// Token: 0x060027A5 RID: 10149 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027A5")]
	[Address(RVA = "0xC0DA40", Offset = "0xC0CA40", VA = "0x180C0DA40", Slot = "23")]
	public override string GetNote(List<Evidence.DataKey> keys)
	{
		return null;
	}

	// Token: 0x0400329C RID: 12956
	[Token(Token = "0x400329C")]
	[FieldOffset(Offset = "0x150")]
	public NewGameLocation locationController;

	// Token: 0x020006F2 RID: 1778
	[Token(Token = "0x20006F2")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x060027A6 RID: 10150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027A6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x0000F108 File Offset: 0x0000D308
		[Token(Token = "0x60027A7")]
		[Address(RVA = "0xC0E220", Offset = "0xC0D220", VA = "0x180C0E220")]
		internal bool <GetNameForDataKey>b__0(Evidence.DataKey item)
		{
			return default(bool);
		}

		// Token: 0x0400329D RID: 12957
		[Token(Token = "0x400329D")]
		[FieldOffset(Offset = "0x10")]
		public List<Evidence.DataKey> inputKeys;
	}
}
