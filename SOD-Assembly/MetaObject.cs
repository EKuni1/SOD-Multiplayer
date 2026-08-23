using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000482 RID: 1154
[Token(Token = "0x2000482")]
[Serializable]
public class MetaObject
{
	// Token: 0x06001A55 RID: 6741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A55")]
	[Address(RVA = "0x97F6E0", Offset = "0x97E6E0", VA = "0x18097F6E0")]
	public MetaObject(InteractablePreset newPreset, Human newOwner, Human newWriter, Human newReciever, List<Interactable.Passed> newPassed)
	{
	}

	// Token: 0x06001A56 RID: 6742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A56")]
	[Address(RVA = "0x97FE50", Offset = "0x97EE50", VA = "0x18097FE50")]
	public void Remove()
	{
	}

	// Token: 0x06001A57 RID: 6743 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A57")]
	[Address(RVA = "0x97FF70", Offset = "0x97EF70", VA = "0x18097FF70")]
	public Evidence GetEvidence(bool setPosition = false, [Optional] Vector3Int nodeCoord)
	{
		return null;
	}

	// Token: 0x06001A58 RID: 6744 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A58")]
	[Address(RVA = "0x9803B0", Offset = "0x97F3B0", VA = "0x1809803B0")]
	public InteractablePreset GetPreset()
	{
		return null;
	}

	// Token: 0x04001FDB RID: 8155
	[Token(Token = "0x4001FDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	// Token: 0x04001FDC RID: 8156
	[Token(Token = "0x4001FDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string preset;

	// Token: 0x04001FDD RID: 8157
	[Token(Token = "0x4001FDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int owner;

	// Token: 0x04001FDE RID: 8158
	[Token(Token = "0x4001FDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int writer;

	// Token: 0x04001FDF RID: 8159
	[Token(Token = "0x4001FDF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int reciever;

	// Token: 0x04001FE0 RID: 8160
	[Token(Token = "0x4001FE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string dds;

	// Token: 0x04001FE1 RID: 8161
	[Token(Token = "0x4001FE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Interactable.Passed> passed;

	// Token: 0x04001FE2 RID: 8162
	[Token(Token = "0x4001FE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3Int n;

	// Token: 0x04001FE3 RID: 8163
	[Token(Token = "0x4001FE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool cd;
}
