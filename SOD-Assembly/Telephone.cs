using System;
using System.Collections.Generic;
using FMOD.Studio;
using Il2CppDummyDll;

// Token: 0x02000403 RID: 1027
[Token(Token = "0x2000403")]
[Serializable]
public class Telephone
{
	// Token: 0x06001740 RID: 5952 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001740")]
	[Address(RVA = "0x887A10", Offset = "0x886A10", VA = "0x180887A10")]
	public Telephone(Interactable newTelephone)
	{
	}

	// Token: 0x06001741 RID: 5953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001741")]
	[Address(RVA = "0x887CF0", Offset = "0x886CF0", VA = "0x180887CF0")]
	public Telephone(Interactable newTelephone, int newNumber)
	{
	}

	// Token: 0x06001742 RID: 5954 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001742")]
	[Address(RVA = "0x887FD0", Offset = "0x886FD0", VA = "0x180887FD0")]
	public void LoadTelephoneNumber()
	{
	}

	// Token: 0x06001743 RID: 5955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001743")]
	[Address(RVA = "0x8881E0", Offset = "0x8871E0", VA = "0x1808881E0")]
	public void GenerateTelephoneNumber()
	{
	}

	// Token: 0x06001744 RID: 5956 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001744")]
	[Address(RVA = "0x8884F0", Offset = "0x8874F0", VA = "0x1808884F0")]
	public List<int> GetInputCode()
	{
		return null;
	}

	// Token: 0x06001745 RID: 5957 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001745")]
	[Address(RVA = "0x888790", Offset = "0x887790", VA = "0x180888790")]
	public void CreateEvidence()
	{
	}

	// Token: 0x06001746 RID: 5958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001746")]
	[Address(RVA = "0x888A30", Offset = "0x887A30", VA = "0x180888A30")]
	public void StopActiveCall()
	{
	}

	// Token: 0x06001747 RID: 5959 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001747")]
	[Address(RVA = "0x888C30", Offset = "0x887C30", VA = "0x180888C30")]
	public void SetActiveCall(TelephoneController.PhoneCall newCall)
	{
	}

	// Token: 0x06001748 RID: 5960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001748")]
	[Address(RVA = "0x888F90", Offset = "0x887F90", VA = "0x180888F90")]
	public void SetTelephoneAnswered(Human val)
	{
	}

	// Token: 0x04001C3A RID: 7226
	[Token(Token = "0x4001C3A")]
	[FieldOffset(Offset = "0x10")]
	public int number;

	// Token: 0x04001C3B RID: 7227
	[Token(Token = "0x4001C3B")]
	[FieldOffset(Offset = "0x18")]
	public string numberString;

	// Token: 0x04001C3C RID: 7228
	[Token(Token = "0x4001C3C")]
	[FieldOffset(Offset = "0x20")]
	public List<TelephoneController.PhoneCall> activeCall;

	// Token: 0x04001C3D RID: 7229
	[Token(Token = "0x4001C3D")]
	[FieldOffset(Offset = "0x28")]
	[NonSerialized]
	public bool setup;

	// Token: 0x04001C3E RID: 7230
	[Token(Token = "0x4001C3E")]
	[FieldOffset(Offset = "0x30")]
	[NonSerialized]
	public NewGameLocation location;

	// Token: 0x04001C3F RID: 7231
	[Token(Token = "0x4001C3F")]
	[FieldOffset(Offset = "0x38")]
	[NonSerialized]
	public Interactable interactable;

	// Token: 0x04001C40 RID: 7232
	[Token(Token = "0x4001C40")]
	[FieldOffset(Offset = "0x40")]
	[NonSerialized]
	public SpeechController speechController;

	// Token: 0x04001C41 RID: 7233
	[Token(Token = "0x4001C41")]
	[FieldOffset(Offset = "0x48")]
	[NonSerialized]
	public Human activeReceiver;

	// Token: 0x04001C42 RID: 7234
	[Token(Token = "0x4001C42")]
	[FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public AudioController.LoopingSoundInfo dialTone;

	// Token: 0x04001C43 RID: 7235
	[Token(Token = "0x4001C43")]
	[FieldOffset(Offset = "0x58")]
	[NonSerialized]
	public EventInstance engaged;

	// Token: 0x04001C44 RID: 7236
	[Token(Token = "0x4001C44")]
	[FieldOffset(Offset = "0x60")]
	[NonSerialized]
	public EvidenceLocation locationEntry;

	// Token: 0x04001C45 RID: 7237
	[Token(Token = "0x4001C45")]
	[FieldOffset(Offset = "0x68")]
	[NonSerialized]
	public EvidenceTelephone telephoneEntry;
}
