using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000228 RID: 552
[Token(Token = "0x2000228")]
public class FurnitureClusterDebug : MonoBehaviour
{
	// Token: 0x06000C9D RID: 3229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0x59C770", Offset = "0x59B770", VA = "0x18059C770")]
	public void Setup(FurnitureCluster newCluster, NewNode newNode)
	{
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0x59CA30", Offset = "0x59BA30", VA = "0x18059CA30")]
	public void AddEntry(FurnitureClusterDebug.DebugFurnitureAnglePlacement newEntry)
	{
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0x59CB30", Offset = "0x59BB30", VA = "0x18059CB30")]
	public FurnitureClusterDebug()
	{
	}

	// Token: 0x04000DF9 RID: 3577
	[Token(Token = "0x4000DF9")]
	[FieldOffset(Offset = "0x18")]
	public MeshRenderer rend;

	// Token: 0x04000DFA RID: 3578
	[Token(Token = "0x4000DFA")]
	[FieldOffset(Offset = "0x20")]
	public FurnitureCluster cluster;

	// Token: 0x04000DFB RID: 3579
	[Token(Token = "0x4000DFB")]
	[FieldOffset(Offset = "0x28")]
	public NewNode node;

	// Token: 0x04000DFC RID: 3580
	[Token(Token = "0x4000DFC")]
	[FieldOffset(Offset = "0x30")]
	public List<FurnitureClusterDebug.DebugFurnitureAnglePlacement> entries;

	// Token: 0x04000DFD RID: 3581
	[Token(Token = "0x4000DFD")]
	[FieldOffset(Offset = "0x38")]
	public Material validMaterial;

	// Token: 0x04000DFE RID: 3582
	[Token(Token = "0x4000DFE")]
	[FieldOffset(Offset = "0x40")]
	public Material invalidMaterial;

	// Token: 0x02000229 RID: 553
	[Token(Token = "0x2000229")]
	[Serializable]
	public class DebugFurnitureAnglePlacement
	{
		// Token: 0x06000CA0 RID: 3232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DebugFurnitureAnglePlacement()
		{
		}

		// Token: 0x04000DFF RID: 3583
		[Token(Token = "0x4000DFF")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000E00 RID: 3584
		[Token(Token = "0x4000E00")]
		[FieldOffset(Offset = "0x18")]
		public int angle;

		// Token: 0x04000E01 RID: 3585
		[Token(Token = "0x4000E01")]
		[FieldOffset(Offset = "0x1C")]
		public bool isValid;

		// Token: 0x04000E02 RID: 3586
		[Token(Token = "0x4000E02")]
		[FieldOffset(Offset = "0x20")]
		public List<NewNode> coversNodes;

		// Token: 0x04000E03 RID: 3587
		[Token(Token = "0x4000E03")]
		[FieldOffset(Offset = "0x28")]
		public List<string> log;

		// Token: 0x04000E04 RID: 3588
		[Token(Token = "0x4000E04")]
		[FieldOffset(Offset = "0x30")]
		public List<string> pathingLog;
	}
}
