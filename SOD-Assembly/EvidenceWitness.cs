using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x0200070E RID: 1806
[Token(Token = "0x200070E")]
public class EvidenceWitness : Evidence
{
	// Token: 0x060027FA RID: 10234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027FA")]
	[Address(RVA = "0xC16040", Offset = "0xC15040", VA = "0x180C16040")]
	public EvidenceWitness(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x060027FB RID: 10235 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027FB")]
	[Address(RVA = "0xC16330", Offset = "0xC15330", VA = "0x180C16330")]
	public EvidenceWitness.DialogOption AddDialogOption(Evidence.DataKey key, DialogPreset newPreset, [Optional] SideJob newSideJob, [Optional] NewRoom roomRef, [Optional] Human.InteractionDialogInstance interactionInstance, bool allowPresetDuplicates = true, bool allowPresetDuplicatesByMessage = true)
	{
		return null;
	}

	// Token: 0x060027FC RID: 10236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027FC")]
	[Address(RVA = "0xC16DB0", Offset = "0xC15DB0", VA = "0x180C16DB0")]
	public void RemoveDialogOption(Evidence.DataKey key, DialogPreset newPreset, [Optional] SideJob newSideJob, [Optional] NewRoom roomRef)
	{
	}

	// Token: 0x060027FD RID: 10237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027FD")]
	[Address(RVA = "0xC17130", Offset = "0xC16130", VA = "0x180C17130")]
	public void RemoveDialogOption(Evidence.DataKey key, EvidenceWitness.DialogOption newOption)
	{
	}

	// Token: 0x060027FE RID: 10238 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027FE")]
	[Address(RVA = "0xC17210", Offset = "0xC16210", VA = "0x180C17210")]
	public List<EvidenceWitness.DialogOption> GetDialogOptions(Evidence.DataKey key)
	{
		return null;
	}

	// Token: 0x060027FF RID: 10239 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60027FF")]
	[Address(RVA = "0xC172C0", Offset = "0xC162C0", VA = "0x180C172C0")]
	public List<EvidenceWitness.DialogOption> GetDialogOptions(List<Evidence.DataKey> keys)
	{
		return null;
	}

	// Token: 0x06002800 RID: 10240 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002800")]
	[Address(RVA = "0xC178A0", Offset = "0xC168A0", VA = "0x180C178A0", Slot = "18")]
	public override List<Evidence.DataKey> GetTiedKeys(List<Evidence.DataKey> inputKeys)
	{
		return null;
	}

	// Token: 0x040032D9 RID: 13017
	[Token(Token = "0x40032D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Dictionary<Evidence.DataKey, List<EvidenceWitness.DialogOption>> dialogOptions;

	// Token: 0x0200070F RID: 1807
	[Token(Token = "0x200070F")]
	[Serializable]
	public class DialogOption
	{
		// Token: 0x06002801 RID: 10241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002801")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DialogOption()
		{
		}

		// Token: 0x040032DA RID: 13018
		[Token(Token = "0x40032DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DialogPreset preset;

		// Token: 0x040032DB RID: 13019
		[Token(Token = "0x40032DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SideJob jobRef;

		// Token: 0x040032DC RID: 13020
		[Token(Token = "0x40032DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NewRoom roomRef;

		// Token: 0x040032DD RID: 13021
		[Token(Token = "0x40032DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Human.InteractionDialogInstance interactionInstance;
	}

	// Token: 0x02000710 RID: 1808
	[Token(Token = "0x2000710")]
	private sealed class <>c__DisplayClass4_0
	{
		// Token: 0x06002802 RID: 10242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002802")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass4_0()
		{
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x0000F300 File Offset: 0x0000D500
		[Token(Token = "0x6002803")]
		[Address(RVA = "0xC17D00", Offset = "0xC16D00", VA = "0x180C17D00")]
		internal bool <RemoveDialogOption>b__0(EvidenceWitness.DialogOption item)
		{
			return default(bool);
		}

		// Token: 0x040032DE RID: 13022
		[Token(Token = "0x40032DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DialogPreset newPreset;

		// Token: 0x040032DF RID: 13023
		[Token(Token = "0x40032DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SideJob newSideJob;

		// Token: 0x040032E0 RID: 13024
		[Token(Token = "0x40032E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NewRoom roomRef;
	}
}
