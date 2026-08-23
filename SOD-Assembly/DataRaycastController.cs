using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B7 RID: 439
[Token(Token = "0x20001B7")]
public class DataRaycastController : MonoBehaviour
{
	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000067")]
	public static DataRaycastController Instance
	{
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x545A10", Offset = "0x544A10", VA = "0x180545A10")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AEA")]
	[Address(RVA = "0x545A50", Offset = "0x544A50", VA = "0x180545A50")]
	private void Awake()
	{
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AEB")]
	[Address(RVA = "0x545DA0", Offset = "0x544DA0", VA = "0x180545DA0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x000069C0 File Offset: 0x00004BC0
	[Token(Token = "0x6000AEC")]
	[Address(RVA = "0x545FB0", Offset = "0x544FB0", VA = "0x180545FB0")]
	public bool EntranceRaycast(NewNode.NodeAccess fromEntrance, NewNode.NodeAccess toEntrance, out List<DataRaycastController.NodeRaycastHit> path, bool debugMode = false)
	{
		return default(bool);
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x000069D8 File Offset: 0x00004BD8
	[Token(Token = "0x6000AED")]
	[Address(RVA = "0x546000", Offset = "0x545000", VA = "0x180546000")]
	public bool NodeRaycast(NewNode fromNode, NewNode toNode, out List<DataRaycastController.NodeRaycastHit> path, [Optional] NewDoor startingDoor, bool debugMode = false)
	{
		return default(bool);
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x000069F0 File Offset: 0x00004BF0
	[Token(Token = "0x6000AEE")]
	[Address(RVA = "0x547880", Offset = "0x546880", VA = "0x180547880")]
	private bool TestAdjacentForNoCeilingAdjBannister(NewNode n)
	{
		return default(bool);
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x00006A08 File Offset: 0x00004C08
	[Token(Token = "0x6000AEF")]
	[Address(RVA = "0x547D50", Offset = "0x546D50", VA = "0x180547D50")]
	private bool TestAdjacentForNoFloorAdjBannister(NewNode n)
	{
		return default(bool);
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x00006A20 File Offset: 0x00004C20
	[Token(Token = "0x6000AF0")]
	[Address(RVA = "0x548220", Offset = "0x547220", VA = "0x180548220")]
	private bool TestAdjacentForNoWall(NewWall w)
	{
		return default(bool);
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AF1")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public DataRaycastController()
	{
	}

	// Token: 0x04000AD8 RID: 2776
	[Token(Token = "0x4000AD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static DataRaycastController _instance;

	// Token: 0x020001B8 RID: 440
	[Token(Token = "0x20001B8")]
	[Serializable]
	public struct NodeRaycastHit
	{
		// Token: 0x04000AD9 RID: 2777
		[Token(Token = "0x4000AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3Int coord;

		// Token: 0x04000ADA RID: 2778
		[Token(Token = "0x4000ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<int> conditionalDoors;
	}

	// Token: 0x020001B9 RID: 441
	[Token(Token = "0x20001B9")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x06000AF2 RID: 2802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00006A38 File Offset: 0x00004C38
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x548620", Offset = "0x547620", VA = "0x180548620")]
		internal bool <TestAdjacentForNoWall>b__0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04000ADB RID: 2779
		[Token(Token = "0x4000ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2Int v2;
	}
}
