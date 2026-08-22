using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000223 RID: 547
[Token(Token = "0x2000223")]
public class DebugNode : MonoBehaviour
{
	// Token: 0x06000C90 RID: 3216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x59ACB0", Offset = "0x599CB0", VA = "0x18059ACB0")]
	public void Setup(NewNode newNode)
	{
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x59AD10", Offset = "0x599D10", VA = "0x18059AD10")]
	public void RefreshData()
	{
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C92")]
	[Address(RVA = "0x59AF50", Offset = "0x599F50", VA = "0x18059AF50")]
	public void ToggleDisplayConnections()
	{
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C93")]
	[Address(RVA = "0x59B510", Offset = "0x59A510", VA = "0x18059B510")]
	public DebugNode()
	{
	}

	// Token: 0x04000DCE RID: 3534
	[Token(Token = "0x4000DCE")]
	[FieldOffset(Offset = "0x18")]
	public NewNode node;

	// Token: 0x04000DCF RID: 3535
	[Token(Token = "0x4000DCF")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 coordinate;

	// Token: 0x04000DD0 RID: 3536
	[Token(Token = "0x4000DD0")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 tileCoordinate;

	// Token: 0x04000DD1 RID: 3537
	[Token(Token = "0x4000DD1")]
	[FieldOffset(Offset = "0x38")]
	public Vector2Int localTileCoordinate;

	// Token: 0x04000DD2 RID: 3538
	[Token(Token = "0x4000DD2")]
	[FieldOffset(Offset = "0x40")]
	public bool isConnected;

	// Token: 0x04000DD3 RID: 3539
	[Token(Token = "0x4000DD3")]
	[FieldOffset(Offset = "0x48")]
	public List<NewNode.NodeAccess> accessToOtherNodes;

	// Token: 0x04000DD4 RID: 3540
	[Token(Token = "0x4000DD4")]
	[FieldOffset(Offset = "0x50")]
	public bool upperStairwellLink;

	// Token: 0x04000DD5 RID: 3541
	[Token(Token = "0x4000DD5")]
	[FieldOffset(Offset = "0x51")]
	public bool lowerStairwellLink;

	// Token: 0x04000DD6 RID: 3542
	[Token(Token = "0x4000DD6")]
	[FieldOffset(Offset = "0x52")]
	public bool isTileStairwell;

	// Token: 0x04000DD7 RID: 3543
	[Token(Token = "0x4000DD7")]
	[FieldOffset(Offset = "0x53")]
	public bool isTileInvertedStairwell;

	// Token: 0x04000DD8 RID: 3544
	[Token(Token = "0x4000DD8")]
	[FieldOffset(Offset = "0x54")]
	public NewNode.FloorTileType floorType;

	// Token: 0x04000DD9 RID: 3545
	[Token(Token = "0x4000DD9")]
	[FieldOffset(Offset = "0x58")]
	private bool displaySpawnedConnections;

	// Token: 0x04000DDA RID: 3546
	[Token(Token = "0x4000DDA")]
	[FieldOffset(Offset = "0x60")]
	public List<GameObject> spawnedConnections;
}
