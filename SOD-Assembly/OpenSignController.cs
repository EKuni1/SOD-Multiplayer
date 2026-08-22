using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000488 RID: 1160
[Token(Token = "0x2000488")]
public class OpenSignController : SwitchSyncBehaviour
{
	// Token: 0x06001A74 RID: 6772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A74")]
	[Address(RVA = "0x984170", Offset = "0x983170", VA = "0x180984170", Slot = "4")]
	public override void SetOn(bool val)
	{
	}

	// Token: 0x06001A75 RID: 6773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A75")]
	[Address(RVA = "0x973900", Offset = "0x972900", VA = "0x180973900")]
	public OpenSignController()
	{
	}

	// Token: 0x04002024 RID: 8228
	[Token(Token = "0x4002024")]
	[FieldOffset(Offset = "0x40")]
	public MeshRenderer signRend;

	// Token: 0x04002025 RID: 8229
	[Token(Token = "0x4002025")]
	[FieldOffset(Offset = "0x48")]
	public Material onMat;

	// Token: 0x04002026 RID: 8230
	[Token(Token = "0x4002026")]
	[FieldOffset(Offset = "0x50")]
	public Material offMat;
}
