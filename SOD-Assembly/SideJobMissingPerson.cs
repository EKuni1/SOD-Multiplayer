using System;
using Il2CppDummyDll;

// Token: 0x0200036F RID: 879
[Token(Token = "0x200036F")]
[Serializable]
public class SideJobMissingPerson : SideJob
{
	// Token: 0x060013BF RID: 5055 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013BF")]
	[Address(RVA = "0x799C20", Offset = "0x798C20", VA = "0x180799C20")]
	public SideJobMissingPerson(JobPreset newPreset, SideJobController.JobPickData newData, bool immediatePost)
	{
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C0")]
	[Address(RVA = "0x799CB0", Offset = "0x798CB0", VA = "0x180799CB0", Slot = "19")]
	public override void PostJob()
	{
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C1")]
	[Address(RVA = "0x799CD0", Offset = "0x798CD0", VA = "0x180799CD0", Slot = "20")]
	public override void AcceptJob()
	{
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C2")]
	[Address(RVA = "0x79A030", Offset = "0x799030", VA = "0x18079A030", Slot = "8")]
	public override void GameWorldLoop()
	{
	}

	// Token: 0x0400181C RID: 6172
	[Token(Token = "0x400181C")]
	[FieldOffset(Offset = "0x170")]
	public bool readyToPost;

	// Token: 0x0400181D RID: 6173
	[Token(Token = "0x400181D")]
	[FieldOffset(Offset = "0x178")]
	private NewAIGoal exitBuilding;
}
