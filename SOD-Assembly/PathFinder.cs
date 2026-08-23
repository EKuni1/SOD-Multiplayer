using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

// Token: 0x020001BE RID: 446
[Token(Token = "0x20001BE")]
public class PathFinder : MonoBehaviour
{
	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700006C")]
	public static PathFinder Instance
	{
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x54B560", Offset = "0x54A560", VA = "0x18054B560")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B10")]
	[Address(RVA = "0x54B5A0", Offset = "0x54A5A0", VA = "0x18054B5A0")]
	private void Awake()
	{
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B11")]
	[Address(RVA = "0x54B8F0", Offset = "0x54A8F0", VA = "0x18054B8F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B12")]
	[Address(RVA = "0x54BB00", Offset = "0x54AB00", VA = "0x18054BB00")]
	private void Start()
	{
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B13")]
	[Address(RVA = "0x54BB10", Offset = "0x54AB10", VA = "0x18054BB10")]
	public void DestroySelf()
	{
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B14")]
	[Address(RVA = "0x54BC20", Offset = "0x54AC20", VA = "0x18054BC20")]
	public void SetDimensions()
	{
	}

	// Token: 0x06000B15 RID: 2837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B15")]
	[Address(RVA = "0x54C2D0", Offset = "0x54B2D0", VA = "0x18054C2D0")]
	public void CompilePathFindingMap(bool calculateNewBuildingFacing = true)
	{
	}

	// Token: 0x06000B16 RID: 2838 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B16")]
	[Address(RVA = "0x54D740", Offset = "0x54C740", VA = "0x18054D740")]
	public void CreateStreetChunks()
	{
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B17")]
	[Address(RVA = "0x54F530", Offset = "0x54E530", VA = "0x18054F530")]
	private void FootTrafficSimulation()
	{
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x550810", Offset = "0x54F810", VA = "0x180550810")]
	private void CreateStreets()
	{
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B19")]
	[Address(RVA = "0x552C40", Offset = "0x551C40", VA = "0x180552C40")]
	private StreetController NewRoad(DistrictController dis)
	{
		return null;
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0x552ED0", Offset = "0x551ED0", VA = "0x180552ED0")]
	public PathFinder.PathData GetPath(NewNode origin, NewNode destination, Human human, [Optional] NewNode[] avoidNodes)
	{
		return null;
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x556080", Offset = "0x555080", VA = "0x180556080")]
	private List<NewNode.NodeAccess> GetGameLocationRoute(NewNode origin, NewNode destination, Human human)
	{
		return null;
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0x559FC0", Offset = "0x558FC0", VA = "0x180559FC0")]
	public List<NewNode.NodeAccess> GetInternalRoute(NewAddress.PathKey pathKey, NewGameLocation gameLocation)
	{
		return null;
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x55CDE0", Offset = "0x55BDE0", VA = "0x18055CDE0")]
	public void GenerateJobPathingData()
	{
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0x55DBA0", Offset = "0x55CBA0", VA = "0x18055DBA0")]
	public List<NewTile> GetTileRoute(NewTile origin, NewTile destination, [Optional] List<NewTile> avoidTiles)
	{
		return null;
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0x55E9E0", Offset = "0x55D9E0", VA = "0x18055E9E0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B20")]
	[Address(RVA = "0x55EBE0", Offset = "0x55DBE0", VA = "0x18055EBE0")]
	public PathFinder()
	{
	}

	// Token: 0x04000AE7 RID: 2791
	[Token(Token = "0x4000AE7")]
	private const int INITIAL_COLLECTION_SIZE = 96;

	// Token: 0x04000AE8 RID: 2792
	[Token(Token = "0x4000AE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 tileSize;

	// Token: 0x04000AE9 RID: 2793
	[Token(Token = "0x4000AE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 nodeSize;

	// Token: 0x04000AEA RID: 2794
	[Token(Token = "0x4000AEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 citySizeReal;

	// Token: 0x04000AEB RID: 2795
	[Token(Token = "0x4000AEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector2 halfCitySizeReal;

	// Token: 0x04000AEC RID: 2796
	[Token(Token = "0x4000AEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2 tileCitySize;

	// Token: 0x04000AED RID: 2797
	[Token(Token = "0x4000AED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector2 nodeCitySize;

	// Token: 0x04000AEE RID: 2798
	[Token(Token = "0x4000AEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector2 nodeRangeX;

	// Token: 0x04000AEF RID: 2799
	[Token(Token = "0x4000AEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector2 nodeRangeY;

	// Token: 0x04000AF0 RID: 2800
	[Token(Token = "0x4000AF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector2 nodeRangeZ;

	// Token: 0x04000AF1 RID: 2801
	[Token(Token = "0x4000AF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int totalPathCalls;

	// Token: 0x04000AF2 RID: 2802
	[Token(Token = "0x4000AF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int calculatedRoomRoutes;

	// Token: 0x04000AF3 RID: 2803
	[Token(Token = "0x4000AF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int returnedCachedRoomRoutes;

	// Token: 0x04000AF4 RID: 2804
	[Token(Token = "0x4000AF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int calculatedInternalRoutes;

	// Token: 0x04000AF5 RID: 2805
	[Token(Token = "0x4000AF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Dictionary<Vector3, NewNode> nodeMap;

	// Token: 0x04000AF6 RID: 2806
	[Token(Token = "0x4000AF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Dictionary<Vector3, NewTile> tileMap;

	// Token: 0x04000AF7 RID: 2807
	[Token(Token = "0x4000AF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Dictionary<PathFinder.GameLocationPathKey, List<NewNode.NodeAccess>> gameLocationRoutes;

	// Token: 0x04000AF8 RID: 2808
	[Token(Token = "0x4000AF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Dictionary<NewAddress.PathKey, List<NewNode.NodeAccess>> internalRoutes;

	// Token: 0x04000AF9 RID: 2809
	[Token(Token = "0x4000AF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<NewNode.NodeAccess> streetEntrances;

	// Token: 0x04000AFA RID: 2810
	[Token(Token = "0x4000AFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Dictionary<int, NewNode.NodeAccess> nodeAccessReference;

	// Token: 0x04000AFB RID: 2811
	[Token(Token = "0x4000AFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public NativeMultiHashMap<int3, int> streetAccessRef;

	// Token: 0x04000AFC RID: 2812
	[Token(Token = "0x4000AFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public NativeHashMap<int, float3> streetAccessPositions;

	// Token: 0x04000AFD RID: 2813
	[Token(Token = "0x4000AFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public NativeHashMap<int, int3> streetToNodeReference;

	// Token: 0x04000AFE RID: 2814
	[Token(Token = "0x4000AFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public NativeList<int3> streetNoPassRef;

	// Token: 0x04000AFF RID: 2815
	[Token(Token = "0x4000AFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<PathFinder.StreetChunk> streetChunks;

	// Token: 0x04000B00 RID: 2816
	[Token(Token = "0x4000B00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PathFinder _instance;

	// Token: 0x020001BF RID: 447
	[Token(Token = "0x20001BF")]
	public class PathData
	{
		// Token: 0x06000B21 RID: 2849 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x55F490", Offset = "0x55E490", VA = "0x18055F490")]
		public NewNode GetNodeAhead(int routeCursor)
		{
			return null;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x55F610", Offset = "0x55E610", VA = "0x18055F610")]
		public NewNode GetNodeBehind(int routeCursor)
		{
			return null;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x55F7C0", Offset = "0x55E7C0", VA = "0x18055F7C0")]
		public PathData()
		{
		}

		// Token: 0x04000B01 RID: 2817
		[Token(Token = "0x4000B01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<NewNode.NodeAccess> accessList;
	}

	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	public struct RoomPathKey : IEnumerator<object>
	{
		// Token: 0x06000B24 RID: 2852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x55F910", Offset = "0x55E910", VA = "0x18055F910")]
		public RoomPathKey(NewRoom locOne, NewRoom locTwo)
		{
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00006AC8 File Offset: 0x00004CC8
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x55F9D0", Offset = "0x55E9D0", VA = "0x18055F9D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00006AE0 File Offset: 0x00004CE0
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x55FA70", Offset = "0x55EA70", VA = "0x18055FA70", Slot = "4")]
		private bool Equals(PathFinder.RoomPathKey other)
		{
			return default(bool);
		}

		// Token: 0x04000B02 RID: 2818
		[Token(Token = "0x4000B02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public NewRoom originRoom;

		// Token: 0x04000B03 RID: 2819
		[Token(Token = "0x4000B03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public NewRoom destinationRoom;

		// Token: 0x04000B04 RID: 2820
		[Token(Token = "0x4000B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool hasHash;

		// Token: 0x04000B05 RID: 2821
		[Token(Token = "0x4000B05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int hash;
	}

	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	public struct GameLocationPathKey : IEnumerator<object>
	{
		// Token: 0x06000B27 RID: 2855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x55F910", Offset = "0x55E910", VA = "0x18055F910")]
		public GameLocationPathKey(NewGameLocation locOne, NewGameLocation locTwo)
		{
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00006AF8 File Offset: 0x00004CF8
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x55FAB0", Offset = "0x55EAB0", VA = "0x18055FAB0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00006B10 File Offset: 0x00004D10
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x55FB50", Offset = "0x55EB50", VA = "0x18055FB50", Slot = "4")]
		private bool Equals(PathFinder.GameLocationPathKey other)
		{
			return default(bool);
		}

		// Token: 0x04000B06 RID: 2822
		[Token(Token = "0x4000B06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public NewGameLocation originLocation;

		// Token: 0x04000B07 RID: 2823
		[Token(Token = "0x4000B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public NewGameLocation destinationLocation;

		// Token: 0x04000B08 RID: 2824
		[Token(Token = "0x4000B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool hasHash;

		// Token: 0x04000B09 RID: 2825
		[Token(Token = "0x4000B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int hash;
	}

	// Token: 0x020001C2 RID: 450
	[Token(Token = "0x20001C2")]
	public class StreetChunk
	{
		// Token: 0x06000B2A RID: 2858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x55FB90", Offset = "0x55EB90", VA = "0x18055FB90")]
		public StreetChunk(Vector3 newAnchor, List<Vector3> newList, bool newIsJunction)
		{
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x560360", Offset = "0x55F360", VA = "0x180560360")]
		public Dictionary<PathFinder.StreetChunk, bool> GetAdjacentChunks(bool horizontal)
		{
			return null;
		}

		// Token: 0x04000B0A RID: 2826
		[Token(Token = "0x4000B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000B0B RID: 2827
		[Token(Token = "0x4000B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int id;

		// Token: 0x04000B0C RID: 2828
		[Token(Token = "0x4000B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int assignID;

		// Token: 0x04000B0D RID: 2829
		[Token(Token = "0x4000B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 anchorTile;

		// Token: 0x04000B0E RID: 2830
		[Token(Token = "0x4000B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Vector3> allCoords;

		// Token: 0x04000B0F RID: 2831
		[Token(Token = "0x4000B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<NewTile> allTiles;

		// Token: 0x04000B10 RID: 2832
		[Token(Token = "0x4000B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isJunction;

		// Token: 0x04000B11 RID: 2833
		[Token(Token = "0x4000B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isHorizontal;

		// Token: 0x04000B12 RID: 2834
		[Token(Token = "0x4000B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float xMagnitude;

		// Token: 0x04000B13 RID: 2835
		[Token(Token = "0x4000B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float yMagnitude;

		// Token: 0x04000B14 RID: 2836
		[Token(Token = "0x4000B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector2 streetMaxSizeX;

		// Token: 0x04000B15 RID: 2837
		[Token(Token = "0x4000B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector2 streetMaxSizeY;

		// Token: 0x04000B16 RID: 2838
		[Token(Token = "0x4000B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int footfall;

		// Token: 0x04000B17 RID: 2839
		[Token(Token = "0x4000B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float footfallNormalized;
	}

	// Token: 0x020001C3 RID: 451
	[Token(Token = "0x20001C3")]
	public struct GetInternalRouteJob : IEnumerator<object>
	{
		// Token: 0x06000B2C RID: 2860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x5607D0", Offset = "0x55F7D0", VA = "0x1805607D0", Slot = "4")]
		public void Execute()
		{
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00006B28 File Offset: 0x00004D28
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x561F50", Offset = "0x560F50", VA = "0x180561F50")]
		public float DistanceInt3(int3 origin, int3 destination)
		{
			return 0f;
		}

		// Token: 0x04000B18 RID: 2840
		[Token(Token = "0x4000B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool pathfindSuccessful;

		// Token: 0x04000B19 RID: 2841
		[Token(Token = "0x4000B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int3 origin;

		// Token: 0x04000B1A RID: 2842
		[Token(Token = "0x4000B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int3 destination;

		// Token: 0x04000B1B RID: 2843
		[Token(Token = "0x4000B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int listIndex;

		// Token: 0x04000B1C RID: 2844
		[Token(Token = "0x4000B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NativeMultiHashMap<int3, int> accessRef;

		// Token: 0x04000B1D RID: 2845
		[Token(Token = "0x4000B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public NativeHashMap<int, float3> accessPositions;

		// Token: 0x04000B1E RID: 2846
		[Token(Token = "0x4000B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public NativeHashMap<int, int3> toNodeReference;

		// Token: 0x04000B1F RID: 2847
		[Token(Token = "0x4000B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public NativeList<int3> noPassRef;

		// Token: 0x04000B20 RID: 2848
		[Token(Token = "0x4000B20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public NativeList<int> output;
	}

	// Token: 0x020001C4 RID: 452
	[Token(Token = "0x20001C4")]
	private sealed class <>c__DisplayClass37_0
	{
		// Token: 0x06000B2E RID: 2862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass37_0()
		{
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x561FA0", Offset = "0x560FA0", VA = "0x180561FA0")]
		internal bool <CompilePathFindingMap>b__0(CitySaveData.CityTileCitySave item)
		{
			return default(bool);
		}

		// Token: 0x04000B21 RID: 2849
		[Token(Token = "0x4000B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CityTile currentCityTile;
	}

	// Token: 0x020001C5 RID: 453
	[Token(Token = "0x20001C5")]
	private sealed class <>c__DisplayClass37_1
	{
		// Token: 0x06000B30 RID: 2864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass37_1()
		{
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00006B58 File Offset: 0x00004D58
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x561FF0", Offset = "0x560FF0", VA = "0x180561FF0")]
		internal bool <CompilePathFindingMap>b__1(CitySaveData.TileCitySave item)
		{
			return default(bool);
		}

		// Token: 0x04000B22 RID: 2850
		[Token(Token = "0x4000B22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3Int currentTileCoord;
	}

	// Token: 0x020001C6 RID: 454
	[Token(Token = "0x20001C6")]
	private sealed class <>c__DisplayClass40_0
	{
		// Token: 0x06000B32 RID: 2866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass40_0()
		{
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00006B70 File Offset: 0x00004D70
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x562050", Offset = "0x561050", VA = "0x180562050")]
		internal bool <CreateStreets>b__1(NewTile item)
		{
			return default(bool);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00006B88 File Offset: 0x00004D88
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x4E8560", Offset = "0x4E7560", VA = "0x1804E8560")]
		internal bool <CreateStreets>b__2(NewTile item)
		{
			return default(bool);
		}

		// Token: 0x04000B23 RID: 2851
		[Token(Token = "0x4000B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewTile t;
	}

	// Token: 0x020001C7 RID: 455
	[Token(Token = "0x20001C7")]
	private sealed class <>c__DisplayClass40_1
	{
		// Token: 0x06000B35 RID: 2869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass40_1()
		{
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00006BA0 File Offset: 0x00004DA0
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x562080", Offset = "0x561080", VA = "0x180562080")]
		internal bool <CreateStreets>b__3(NewTile item)
		{
			return default(bool);
		}

		// Token: 0x04000B24 RID: 2852
		[Token(Token = "0x4000B24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public KeyValuePair<StreetController, List<NewTile>> pair;
	}

	// Token: 0x020001C8 RID: 456
	[Token(Token = "0x20001C8")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000B38 RID: 2872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00006BB8 File Offset: 0x00004DB8
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x5621E0", Offset = "0x5611E0", VA = "0x1805621E0")]
		internal int <CreateStreets>b__40_0(PathFinder.StreetChunk p1, PathFinder.StreetChunk p2)
		{
			return 0;
		}

		// Token: 0x04000B25 RID: 2853
		[Token(Token = "0x4000B25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly PathFinder.<>c <>9;

		// Token: 0x04000B26 RID: 2854
		[Token(Token = "0x4000B26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<PathFinder.StreetChunk> <>9__40_0;
	}

	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	private sealed class <>c__DisplayClass42_0
	{
		// Token: 0x06000B3A RID: 2874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass42_0()
		{
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00006BD0 File Offset: 0x00004DD0
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x562220", Offset = "0x561220", VA = "0x180562220")]
		internal bool <GetPath>b__0(PathFinder.GetInternalRouteJob item)
		{
			return default(bool);
		}

		// Token: 0x04000B27 RID: 2855
		[Token(Token = "0x4000B27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;
	}
}
