using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000224 RID: 548
[Token(Token = "0x2000224")]
public class DebugPathfind : MonoBehaviour
{
	// Token: 0x06000C94 RID: 3220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C94")]
	[Address(RVA = "0x59B6C0", Offset = "0x59A6C0", VA = "0x18059B6C0")]
	public void Setup(NewNode.NodeAccess newAccess, NewRoom newRoom, List<DebugPathfind.DebugLocationLink> linkList)
	{
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C95")]
	[Address(RVA = "0x59BF00", Offset = "0x59AF00", VA = "0x18059BF00")]
	public void TeleportPlayer()
	{
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C96")]
	[Address(RVA = "0x59BF90", Offset = "0x59AF90", VA = "0x18059BF90")]
	public DebugPathfind()
	{
	}

	// Token: 0x04000DDB RID: 3547
	[Token(Token = "0x4000DDB")]
	[FieldOffset(Offset = "0x18")]
	private NewNode.NodeAccess access;

	// Token: 0x04000DDC RID: 3548
	[Token(Token = "0x4000DDC")]
	[FieldOffset(Offset = "0x20")]
	public NewRoom room;

	// Token: 0x04000DDD RID: 3549
	[Token(Token = "0x4000DDD")]
	[FieldOffset(Offset = "0x28")]
	public NewGameLocation gameLocation;

	// Token: 0x04000DDE RID: 3550
	[Token(Token = "0x4000DDE")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 fromNodePos;

	// Token: 0x04000DDF RID: 3551
	[Token(Token = "0x4000DDF")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 toNodePos;

	// Token: 0x04000DE0 RID: 3552
	[Token(Token = "0x4000DE0")]
	[FieldOffset(Offset = "0x48")]
	public bool walkingAccess;

	// Token: 0x04000DE1 RID: 3553
	[Token(Token = "0x4000DE1")]
	[FieldOffset(Offset = "0x49")]
	public bool employeeDoor;

	// Token: 0x04000DE2 RID: 3554
	[Token(Token = "0x4000DE2")]
	[FieldOffset(Offset = "0x4A")]
	public bool noPassThroughOnFromNode;

	// Token: 0x04000DE3 RID: 3555
	[Token(Token = "0x4000DE3")]
	[FieldOffset(Offset = "0x4B")]
	public bool noPassThroughOnToNode;

	// Token: 0x04000DE4 RID: 3556
	[Token(Token = "0x4000DE4")]
	[FieldOffset(Offset = "0x4C")]
	public bool noAccessOnFromNode;

	// Token: 0x04000DE5 RID: 3557
	[Token(Token = "0x4000DE5")]
	[FieldOffset(Offset = "0x4D")]
	public bool noAccessOnToNode;

	// Token: 0x04000DE6 RID: 3558
	[Token(Token = "0x4000DE6")]
	[FieldOffset(Offset = "0x50")]
	public List<DebugPathfind.DebugLocationLink> locationLinkAttempts;

	// Token: 0x02000225 RID: 549
	[Token(Token = "0x2000225")]
	[Serializable]
	public class DebugLocationLink
	{
		// Token: 0x06000C97 RID: 3223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x59C090", Offset = "0x59B090", VA = "0x18059C090")]
		public DebugLocationLink(NewNode.NodeAccess acc, string reason)
		{
		}

		// Token: 0x04000DE7 RID: 3559
		[Token(Token = "0x4000DE7")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000DE8 RID: 3560
		[Token(Token = "0x4000DE8")]
		[FieldOffset(Offset = "0x18")]
		public NewNode.NodeAccess access;
	}
}
