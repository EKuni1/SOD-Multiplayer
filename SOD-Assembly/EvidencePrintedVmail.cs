using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000703 RID: 1795
[Token(Token = "0x2000703")]
public class EvidencePrintedVmail : Evidence
{
	// Token: 0x060027DA RID: 10202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60027DA")]
	[Address(RVA = "0xC11380", Offset = "0xC10380", VA = "0x180C11380")]
	public EvidencePrintedVmail(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x040032BF RID: 12991
	[Token(Token = "0x40032BF")]
	[FieldOffset(Offset = "0x150")]
	public int threadID;

	// Token: 0x040032C0 RID: 12992
	[Token(Token = "0x40032C0")]
	[FieldOffset(Offset = "0x154")]
	public int msgIndexID;

	// Token: 0x040032C1 RID: 12993
	[Token(Token = "0x40032C1")]
	[FieldOffset(Offset = "0x158")]
	public StateSaveData.MessageThreadSave thread;
}
