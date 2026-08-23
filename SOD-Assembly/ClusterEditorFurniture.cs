using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200021E RID: 542
[Token(Token = "0x200021E")]
public class ClusterEditorFurniture : MonoBehaviour
{
	// Token: 0x06000C81 RID: 3201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C81")]
	[Address(RVA = "0x599490", Offset = "0x598490", VA = "0x180599490")]
	public void Setup(FurniturePreset newFurn)
	{
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C82")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ClusterEditorFurniture()
	{
	}

	// Token: 0x04000DB0 RID: 3504
	[Token(Token = "0x4000DB0")]
	[FieldOffset(Offset = "0x18")]
	public FurniturePreset furnPreset;

	// Token: 0x04000DB1 RID: 3505
	[Token(Token = "0x4000DB1")]
	[FieldOffset(Offset = "0x20")]
	public FurnitureClass furnClass;
}
