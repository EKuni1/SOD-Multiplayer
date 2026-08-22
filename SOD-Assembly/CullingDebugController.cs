using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200021F RID: 543
[Token(Token = "0x200021F")]
public class CullingDebugController : MonoBehaviour
{
	// Token: 0x06000C83 RID: 3203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C83")]
	[Address(RVA = "0x5995C0", Offset = "0x5985C0", VA = "0x1805995C0")]
	public void Setup(NewRoom newRoom, NewNode.NodeAccess newPEntrance, List<NewDoor> newDoors, CullingDebugController.CullDebugType newCullType, [Optional] NewRoom newAtriumTopOf, [Optional] NewNode.NodeAccess newOEntrance)
	{
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C84")]
	[Address(RVA = "0x599B40", Offset = "0x598B40", VA = "0x180599B40")]
	public void ToggleParentsEntrance()
	{
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C85")]
	[Address(RVA = "0x599EE0", Offset = "0x598EE0", VA = "0x180599EE0")]
	public void RunDataRaycast()
	{
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C86")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public CullingDebugController()
	{
	}

	// Token: 0x04000DB2 RID: 3506
	[Token(Token = "0x4000DB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer rend;

	// Token: 0x04000DB3 RID: 3507
	[Token(Token = "0x4000DB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public NewRoom room;

	// Token: 0x04000DB4 RID: 3508
	[Token(Token = "0x4000DB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public NewNode.NodeAccess parentEntrance;

	// Token: 0x04000DB5 RID: 3509
	[Token(Token = "0x4000DB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public NewNode.NodeAccess otherEntrance;

	// Token: 0x04000DB6 RID: 3510
	[Token(Token = "0x4000DB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<NewDoor> dependentDoors;

	// Token: 0x04000DB7 RID: 3511
	[Token(Token = "0x4000DB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public NewRoom atriumTopOf;

	// Token: 0x04000DB8 RID: 3512
	[Token(Token = "0x4000DB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject parentObjectMarker;

	// Token: 0x04000DB9 RID: 3513
	[Token(Token = "0x4000DB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public CullingDebugController.CullDebugType cullType;

	// Token: 0x04000DBA RID: 3514
	[Token(Token = "0x4000DBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material red;

	// Token: 0x04000DBB RID: 3515
	[Token(Token = "0x4000DBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Material white;

	// Token: 0x04000DBC RID: 3516
	[Token(Token = "0x4000DBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Material yellow;

	// Token: 0x04000DBD RID: 3517
	[Token(Token = "0x4000DBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Material green;

	// Token: 0x04000DBE RID: 3518
	[Token(Token = "0x4000DBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Material blue;

	// Token: 0x02000220 RID: 544
	[Token(Token = "0x2000220")]
	public enum CullDebugType
	{
		// Token: 0x04000DC0 RID: 3520
		[Token(Token = "0x4000DC0")]
		none,
		// Token: 0x04000DC1 RID: 3521
		[Token(Token = "0x4000DC1")]
		succeededNew,
		// Token: 0x04000DC2 RID: 3522
		[Token(Token = "0x4000DC2")]
		succeededOvr,
		// Token: 0x04000DC3 RID: 3523
		[Token(Token = "0x4000DC3")]
		adjacent,
		// Token: 0x04000DC4 RID: 3524
		[Token(Token = "0x4000DC4")]
		atriumTop
	}
}
