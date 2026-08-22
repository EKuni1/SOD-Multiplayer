using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000226 RID: 550
[Token(Token = "0x2000226")]
public class DebugWalkableSublocation : MonoBehaviour
{
	// Token: 0x06000C98 RID: 3224 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x59C3E0", Offset = "0x59B3E0", VA = "0x18059C3E0")]
	public void Setup(NewNode newNode, NewNode.NodeSpace newSpace)
	{
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C99")]
	[Address(RVA = "0x59C4F0", Offset = "0x59B4F0", VA = "0x18059C4F0")]
	private void Update()
	{
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public DebugWalkableSublocation()
	{
	}

	// Token: 0x04000DE9 RID: 3561
	[Token(Token = "0x4000DE9")]
	[FieldOffset(Offset = "0x18")]
	public NewNode node;

	// Token: 0x04000DEA RID: 3562
	[Token(Token = "0x4000DEA")]
	[FieldOffset(Offset = "0x20")]
	public MeshRenderer rend;

	// Token: 0x04000DEB RID: 3563
	[Token(Token = "0x4000DEB")]
	[FieldOffset(Offset = "0x28")]
	public Material unoccupiedMat;

	// Token: 0x04000DEC RID: 3564
	[Token(Token = "0x4000DEC")]
	[FieldOffset(Offset = "0x30")]
	public Material occupiedActualMat;

	// Token: 0x04000DED RID: 3565
	[Token(Token = "0x4000DED")]
	[FieldOffset(Offset = "0x38")]
	public Material occupiedDestinationMat;

	// Token: 0x04000DEE RID: 3566
	[Token(Token = "0x4000DEE")]
	[FieldOffset(Offset = "0x40")]
	public NewNode.NodeSpace space;
}
