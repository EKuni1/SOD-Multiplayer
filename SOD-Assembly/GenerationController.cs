using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000432 RID: 1074
[Token(Token = "0x2000432")]
public class GenerationController : MonoBehaviour
{
	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x06001822 RID: 6178 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000C3")]
	public static GenerationController Instance
	{
		[Token(Token = "0x6001822")]
		[Address(RVA = "0x8BE2D0", Offset = "0x8BD2D0", VA = "0x1808BE2D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001823 RID: 6179 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001823")]
	[Address(RVA = "0x8BE310", Offset = "0x8BD310", VA = "0x1808BE310")]
	private void Awake()
	{
	}

	// Token: 0x06001824 RID: 6180 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001824")]
	[Address(RVA = "0x8BE660", Offset = "0x8BD660", VA = "0x1808BE660")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001825 RID: 6181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001825")]
	[Address(RVA = "0x8BE870", Offset = "0x8BD870", VA = "0x1808BE870")]
	public void UpdateGeometryFloor(NewFloor editFloor, string debug = "")
	{
	}

	// Token: 0x06001826 RID: 6182 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001826")]
	[Address(RVA = "0x8BE9D0", Offset = "0x8BD9D0", VA = "0x1808BE9D0")]
	private IEnumerator ExeUpdateGeometryAtEndOfFrame()
	{
		return null;
	}

	// Token: 0x06001827 RID: 6183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001827")]
	[Address(RVA = "0x8BEA70", Offset = "0x8BDA70", VA = "0x1808BEA70")]
	public void LoadGeometryFloor(NewFloor editFloor)
	{
	}

	// Token: 0x06001828 RID: 6184 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001828")]
	[Address(RVA = "0x8BEBD0", Offset = "0x8BDBD0", VA = "0x1808BEBD0")]
	private IEnumerator LoadGeometryAtEndOfFrame()
	{
		return null;
	}

	// Token: 0x06001829 RID: 6185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001829")]
	[Address(RVA = "0x8BEC70", Offset = "0x8BDC70", VA = "0x1808BEC70")]
	public void LoadGeometryRoom(NewRoom room)
	{
	}

	// Token: 0x0600182A RID: 6186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600182A")]
	[Address(RVA = "0x8BF990", Offset = "0x8BE990", VA = "0x1808BF990")]
	public void UnloadOldestRooms()
	{
	}

	// Token: 0x0600182B RID: 6187 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600182B")]
	[Address(RVA = "0x8BFA70", Offset = "0x8BEA70", VA = "0x1808BFA70")]
	private IEnumerator UnloadOldestRoomsAtEndOfFrame()
	{
		return null;
	}

	// Token: 0x0600182C RID: 6188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600182C")]
	[Address(RVA = "0x8BFB10", Offset = "0x8BEB10", VA = "0x1808BFB10")]
	public void UpdateFloorCeilingFloor(NewFloor editFloor)
	{
	}

	// Token: 0x0600182D RID: 6189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600182D")]
	[Address(RVA = "0x8BFD80", Offset = "0x8BED80", VA = "0x1808BFD80")]
	public void UpdateFloorCeilingRoom(NewRoom room)
	{
	}

	// Token: 0x0600182E RID: 6190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600182E")]
	[Address(RVA = "0x8C01E0", Offset = "0x8BF1E0", VA = "0x1808C01E0")]
	public void UpdateWallsFloor(NewFloor editFloor)
	{
	}

	// Token: 0x0600182F RID: 6191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600182F")]
	[Address(RVA = "0x8C22B0", Offset = "0x8C12B0", VA = "0x1808C22B0")]
	public void UpdateWallsRoom(NewRoom room)
	{
	}

	// Token: 0x06001830 RID: 6192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001830")]
	[Address(RVA = "0x8C43A0", Offset = "0x8C33A0", VA = "0x1808C43A0")]
	public void LoadCornersRoom(NewRoom room)
	{
	}

	// Token: 0x06001831 RID: 6193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001831")]
	[Address(RVA = "0x8C4770", Offset = "0x8C3770", VA = "0x1808C4770")]
	public void GenerateAddressLayout(NewAddress ad)
	{
	}

	// Token: 0x06001832 RID: 6194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001832")]
	[Address(RVA = "0x8D0910", Offset = "0x8CF910", VA = "0x1808D0910")]
	public void ResetLayout(NewAddress ad, out GameObject newDebugParent)
	{
	}

	// Token: 0x06001833 RID: 6195 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001833")]
	[Address(RVA = "0x8D1B90", Offset = "0x8D0B90", VA = "0x1808D1B90")]
	private HashSet<NewRoom> GetUnreachableRooms(List<NewNode> entranceNodes, NewAddress ad)
	{
		return null;
	}

	// Token: 0x06001834 RID: 6196 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001834")]
	[Address(RVA = "0x8D2FE0", Offset = "0x8D1FE0", VA = "0x1808D2FE0")]
	private List<GenerationController.PossibleRoomLocation> GetPossibleRoomLocations(NewAddress address, RoomTypePreset config, List<NewNode> possibleNodes, List<NewNode> entranceNodes, List<NewNode> mainEntranceNodes, List<NewNode> edgeNodes, Transform debugParent)
	{
		return null;
	}

	// Token: 0x06001835 RID: 6197 RVA: 0x0000AFB0 File Offset: 0x000091B0
	[Token(Token = "0x6001835")]
	[Address(RVA = "0x8D6640", Offset = "0x8D5640", VA = "0x1808D6640")]
	private bool RoomMinimumShapeCheck(ref List<NewNode> nodes, Vector2 minimumShape, GenerationDebugController debug)
	{
		return default(bool);
	}

	// Token: 0x06001836 RID: 6198 RVA: 0x0000AFC8 File Offset: 0x000091C8
	[Token(Token = "0x6001836")]
	[Address(RVA = "0x8D6BC0", Offset = "0x8D5BC0", VA = "0x1808D6BC0")]
	private bool RoomMinimumShapeCheck(ref HashSet<NewNode> nodes, Vector2 minimumShape, GenerationDebugController debug, bool nodesMustBeUnoccupied = false)
	{
		return default(bool);
	}

	// Token: 0x06001837 RID: 6199 RVA: 0x0000AFE0 File Offset: 0x000091E0
	[Token(Token = "0x6001837")]
	[Address(RVA = "0x8D7170", Offset = "0x8D6170", VA = "0x1808D7170")]
	private bool TesselationShapeCheck(ref List<NewNode> nodes, Vector2 tessShape, GenerationDebugController debugController)
	{
		return default(bool);
	}

	// Token: 0x06001838 RID: 6200 RVA: 0x0000AFF8 File Offset: 0x000091F8
	[Token(Token = "0x6001838")]
	[Address(RVA = "0x8D7770", Offset = "0x8D6770", VA = "0x1808D7770")]
	private bool MustAdjoinOneOfCheck(ref List<NewNode> nodes, NewGameLocation thisGameLocation, List<RoomTypePreset> roomTypes, bool includeEntrance, out List<NewNode> internalAdjoiningRoomNodes, GenerationDebugController debug)
	{
		return default(bool);
	}

	// Token: 0x06001839 RID: 6201 RVA: 0x0000B010 File Offset: 0x00009210
	[Token(Token = "0x6001839")]
	[Address(RVA = "0x8D7FE0", Offset = "0x8D6FE0", VA = "0x1808D7FE0")]
	private bool CheckEntranceConnection(ref List<NewNode> nodes, NewGameLocation thisGameLocation, GenerationDebugController debug)
	{
		return default(bool);
	}

	// Token: 0x0600183A RID: 6202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600183A")]
	[Address(RVA = "0x8D87B0", Offset = "0x8D77B0", VA = "0x1808D87B0")]
	private void CreateForcedRooms(NewAddress ad)
	{
	}

	// Token: 0x0600183B RID: 6203 RVA: 0x0000B028 File Offset: 0x00009228
	[Token(Token = "0x600183B")]
	[Address(RVA = "0x8D8EE0", Offset = "0x8D7EE0", VA = "0x1808D8EE0")]
	private float GetRoomUniformity(List<NewNode> nodes, out int wallCount, out float shapeRatio)
	{
		return 0f;
	}

	// Token: 0x0600183C RID: 6204 RVA: 0x0000B040 File Offset: 0x00009240
	[Token(Token = "0x600183C")]
	[Address(RVA = "0x8D8FF0", Offset = "0x8D7FF0", VA = "0x1808D8FF0")]
	private int CalculateRoomEdges(List<NewNode> nodes, out int uniformWallCount, out Vector2 uniformBoundsSize)
	{
		return 0;
	}

	// Token: 0x0600183D RID: 6205 RVA: 0x0000B058 File Offset: 0x00009258
	[Token(Token = "0x600183D")]
	[Address(RVA = "0x8D9400", Offset = "0x8D8400", VA = "0x1808D9400")]
	private bool RoomSplitCheck(ref List<NewNode> nodes, GenerationDebugController debug)
	{
		return default(bool);
	}

	// Token: 0x0600183E RID: 6206 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600183E")]
	[Address(RVA = "0x8D9910", Offset = "0x8D8910", VA = "0x1808D9910")]
	private List<NewRoom> ConvertSplitRoom(ref HashSet<NewNode> nodes, NewAddress ad)
	{
		return null;
	}

	// Token: 0x0600183F RID: 6207 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600183F")]
	[Address(RVA = "0x8D9FA0", Offset = "0x8D8FA0", VA = "0x1808D9FA0")]
	private List<NewNode> HallwayPathfind(NewNode origin, NewNode destination, NewAddress address)
	{
		return null;
	}

	// Token: 0x06001840 RID: 6208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001840")]
	[Address(RVA = "0x8DB4C0", Offset = "0x8DA4C0", VA = "0x1808DB4C0")]
	public void GenerateGeometry(NewAddress ad)
	{
	}

	// Token: 0x06001841 RID: 6209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001841")]
	[Address(RVA = "0x8DDF40", Offset = "0x8DCF40", VA = "0x1808DDF40")]
	public void GenerateLightZones(NewRoom room)
	{
	}

	// Token: 0x06001842 RID: 6210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001842")]
	[Address(RVA = "0x8DECC0", Offset = "0x8DDCC0", VA = "0x1808DECC0")]
	public void GenerateAddressDecor(NewAddress ad)
	{
	}

	// Token: 0x06001843 RID: 6211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001843")]
	[Address(RVA = "0x8E0240", Offset = "0x8DF240", VA = "0x1808E0240")]
	public void FurnishRoom(NewRoom room)
	{
	}

	// Token: 0x06001844 RID: 6212 RVA: 0x0000B070 File Offset: 0x00009270
	[Token(Token = "0x6001844")]
	[Address(RVA = "0x8E5460", Offset = "0x8E4460", VA = "0x1808E5460")]
	private bool ClusterCountChecks(FurnitureCluster cluster, NewRoom room, bool enableDebug = false)
	{
		return default(bool);
	}

	// Token: 0x06001845 RID: 6213 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001845")]
	[Address(RVA = "0x8E5AC0", Offset = "0x8E4AC0", VA = "0x1808E5AC0")]
	public FurnitureClusterLocation GetBestFurnitureClusterLocation(NewRoom room, FurnitureCluster cluster, bool enableDebug = false, bool ignoreLimitations = false)
	{
		return null;
	}

	// Token: 0x06001846 RID: 6214 RVA: 0x0000B088 File Offset: 0x00009288
	[Token(Token = "0x6001846")]
	[Address(RVA = "0x59EBE0", Offset = "0x59DBE0", VA = "0x18059EBE0")]
	private int GetAngleForFurnitureFacing(FurnitureCluster.FurnitureFacing facing)
	{
		return 0;
	}

	// Token: 0x06001847 RID: 6215 RVA: 0x0000B0A0 File Offset: 0x000092A0
	[Token(Token = "0x6001847")]
	[Address(RVA = "0x8EF930", Offset = "0x8EE930", VA = "0x1808EF930")]
	public bool IsFurniturePlacementValid(NewRoom room, ref Dictionary<NewNode, List<NewNode>> newBlockAccess, ref List<NewNode> newNoPassNodes, ref List<NewNode> newNoAccessNodes, bool printDebug, out List<string> debugOutput, bool ignoreNoPassThrough = false)
	{
		return default(bool);
	}

	// Token: 0x06001848 RID: 6216 RVA: 0x0000B0B8 File Offset: 0x000092B8
	[Token(Token = "0x6001848")]
	[Address(RVA = "0x8F1330", Offset = "0x8F0330", VA = "0x1808F1330")]
	public bool IsFurniturePlacementValidOLD(NewRoom room, ref Dictionary<NewNode, List<NewNode>> newBlockAccess, [Optional] List<NewNode> newNoPassNodes, [Optional] List<NewNode> newNoAccessNodes, bool printDebug = false)
	{
		return default(bool);
	}

	// Token: 0x06001849 RID: 6217 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001849")]
	[Address(RVA = "0x8F1CD0", Offset = "0x8F0CD0", VA = "0x1808F1CD0")]
	public FurniturePreset PickFurniture(FurnitureClass furnClass, NewRoom room, string randomSeed, bool debug = false, bool ignoreLimitations = false, [Optional] DesignStylePreset styleOverride)
	{
		return null;
	}

	// Token: 0x0600184A RID: 6218 RVA: 0x0000B0D0 File Offset: 0x000092D0
	[Token(Token = "0x600184A")]
	[Address(RVA = "0x8F2160", Offset = "0x8F1160", VA = "0x1808F2160")]
	public bool GetValidFurniture(FurnitureClass furnClass, NewRoom room, bool returnList, out List<FurniturePreset> possibleFurniture, bool debug = false, bool ignoreLimitations = false, [Optional] DesignStylePreset designStyleOverride)
	{
		return default(bool);
	}

	// Token: 0x0600184B RID: 6219 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600184B")]
	[Address(RVA = "0x8F37C0", Offset = "0x8F27C0", VA = "0x1808F37C0")]
	public ArtPreset PickArt(ArtPreset.ArtOrientation orientation, NewRoom room)
	{
		return null;
	}

	// Token: 0x0600184C RID: 6220 RVA: 0x0000B0E8 File Offset: 0x000092E8
	[Token(Token = "0x600184C")]
	[Address(RVA = "0x8F5240", Offset = "0x8F4240", VA = "0x1808F5240")]
	private bool GetAdjacentNode(NewNode original, Vector2Int offset, out NewNode output)
	{
		return default(bool);
	}

	// Token: 0x0600184D RID: 6221 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600184D")]
	[Address(RVA = "0x8F53F0", Offset = "0x8F43F0", VA = "0x1808F53F0")]
	public List<FurnitureLocation> GetFurnitureInCity(FurnitureClass furnClass)
	{
		return null;
	}

	// Token: 0x0600184E RID: 6222 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600184E")]
	[Address(RVA = "0x8F5B00", Offset = "0x8F4B00", VA = "0x1808F5B00")]
	public List<FurnitureLocation> GetFurnitureInBuilding(NewBuilding building, FurnitureClass furnClass)
	{
		return null;
	}

	// Token: 0x0600184F RID: 6223 RVA: 0x0000B100 File Offset: 0x00009300
	[Token(Token = "0x600184F")]
	[Address(RVA = "0x8F5F20", Offset = "0x8F4F20", VA = "0x1808F5F20")]
	public int GetFurnitureInGameLocationCount(NewGameLocation address, FurnitureClass furnClass)
	{
		return 0;
	}

	// Token: 0x06001850 RID: 6224 RVA: 0x0000B118 File Offset: 0x00009318
	[Token(Token = "0x6001850")]
	[Address(RVA = "0x8F6080", Offset = "0x8F5080", VA = "0x1808F6080")]
	public int GetFurnitureInRoomCount(NewRoom room, FurnitureClass furnClass)
	{
		return 0;
	}

	// Token: 0x06001851 RID: 6225 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001851")]
	[Address(RVA = "0x8F61D0", Offset = "0x8F51D0", VA = "0x1808F61D0")]
	public List<FurnitureClusterLocation> GetClustersInCity(FurnitureCluster cluster)
	{
		return null;
	}

	// Token: 0x06001852 RID: 6226 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001852")]
	[Address(RVA = "0x8F6930", Offset = "0x8F5930", VA = "0x1808F6930")]
	public List<FurnitureClusterLocation> GetClustersInBuilding(NewBuilding building, FurnitureCluster cluster)
	{
		return null;
	}

	// Token: 0x06001853 RID: 6227 RVA: 0x0000B130 File Offset: 0x00009330
	[Token(Token = "0x6001853")]
	[Address(RVA = "0x8F6D60", Offset = "0x8F5D60", VA = "0x1808F6D60")]
	public int GetClusterCountInGameLocation(NewGameLocation address, FurnitureCluster cluster)
	{
		return 0;
	}

	// Token: 0x06001854 RID: 6228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001854")]
	[Address(RVA = "0x8F6F10", Offset = "0x8F5F10", VA = "0x1808F6F10")]
	public void ClearCache()
	{
	}

	// Token: 0x06001855 RID: 6229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001855")]
	[Address(RVA = "0x8F7090", Offset = "0x8F6090", VA = "0x1808F7090")]
	public GenerationController()
	{
	}

	// Token: 0x04001D96 RID: 7574
	[Token(Token = "0x4001D96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool updateGeometryActive;

	// Token: 0x04001D97 RID: 7575
	[Token(Token = "0x4001D97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<NewFloor> updateTheseFloors;

	// Token: 0x04001D98 RID: 7576
	[Token(Token = "0x4001D98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool loadGeometryActive;

	// Token: 0x04001D99 RID: 7577
	[Token(Token = "0x4001D99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<NewFloor> loadTheseFloors;

	// Token: 0x04001D9A RID: 7578
	[Token(Token = "0x4001D9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool roomUnloadCheckActive;

	// Token: 0x04001D9B RID: 7579
	[Token(Token = "0x4001D9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int oldestRoomUnloadTimer;

	// Token: 0x04001D9C RID: 7580
	[Token(Token = "0x4001D9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<NewRoom> spawnedRooms;

	// Token: 0x04001D9D RID: 7581
	[Token(Token = "0x4001D9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GenerationController _instance;

	// Token: 0x02000433 RID: 1075
	[Token(Token = "0x2000433")]
	[Serializable]
	public class PossibleRoomLocation : IEnumerator<object>
	{
		// Token: 0x06001856 RID: 6230 RVA: 0x0000B148 File Offset: 0x00009348
		[Token(Token = "0x6001856")]
		[Address(RVA = "0x94F2A0", Offset = "0x94E2A0", VA = "0x18094F2A0", Slot = "4")]
		public int CompareTo(GenerationController.PossibleRoomLocation otherObject)
		{
			return 0;
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001857")]
		[Address(RVA = "0x94F320", Offset = "0x94E320", VA = "0x18094F320")]
		public PossibleRoomLocation()
		{
		}

		// Token: 0x04001D9E RID: 7582
		[Token(Token = "0x4001D9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<NewNode> nodes;

		// Token: 0x04001D9F RID: 7583
		[Token(Token = "0x4001D9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float randomRanking;

		// Token: 0x04001DA0 RID: 7584
		[Token(Token = "0x4001DA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float exteriorWindowRanking;

		// Token: 0x04001DA1 RID: 7585
		[Token(Token = "0x4001DA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float exteriorWallsRanking;

		// Token: 0x04001DA2 RID: 7586
		[Token(Token = "0x4001DA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float floorSpaceRanking;

		// Token: 0x04001DA3 RID: 7587
		[Token(Token = "0x4001DA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float entrancesRanking;

		// Token: 0x04001DA4 RID: 7588
		[Token(Token = "0x4001DA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<GenerationController.OverrideData> overrideRankingData;

		// Token: 0x04001DA5 RID: 7589
		[Token(Token = "0x4001DA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float ranking;

		// Token: 0x04001DA6 RID: 7590
		[Token(Token = "0x4001DA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<NewNode> requiredAdjoiningOptions;

		// Token: 0x04001DA7 RID: 7591
		[Token(Token = "0x4001DA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<NewNode> requiredHallway;

		// Token: 0x04001DA8 RID: 7592
		[Token(Token = "0x4001DA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GenerationDebugController debugScript;
	}

	// Token: 0x02000434 RID: 1076
	[Token(Token = "0x2000434")]
	[Serializable]
	public struct OverrideData
	{
		// Token: 0x04001DA9 RID: 7593
		[Token(Token = "0x4001DA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public NewRoom room;

		// Token: 0x04001DAA RID: 7594
		[Token(Token = "0x4001DAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float floorSpacePenalty;

		// Token: 0x04001DAB RID: 7595
		[Token(Token = "0x4001DAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float exteriorWindowPenalty;

		// Token: 0x04001DAC RID: 7596
		[Token(Token = "0x4001DAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float exteriorWallPenalty;

		// Token: 0x04001DAD RID: 7597
		[Token(Token = "0x4001DAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float overridingPenalty;
	}

	// Token: 0x02000435 RID: 1077
	[Token(Token = "0x2000435")]
	[Serializable]
	public class PossibleDoorwayLocation : IEnumerator<object>
	{
		// Token: 0x06001858 RID: 6232 RVA: 0x0000B160 File Offset: 0x00009360
		[Token(Token = "0x6001858")]
		[Address(RVA = "0x94F570", Offset = "0x94E570", VA = "0x18094F570", Slot = "4")]
		public int CompareTo(GenerationController.PossibleDoorwayLocation otherObject)
		{
			return 0;
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001859")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public PossibleDoorwayLocation()
		{
		}

		// Token: 0x04001DAE RID: 7598
		[Token(Token = "0x4001DAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewWall wall;

		// Token: 0x04001DAF RID: 7599
		[Token(Token = "0x4001DAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float ranking;

		// Token: 0x04001DB0 RID: 7600
		[Token(Token = "0x4001DB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool requireFlatDoorway;

		// Token: 0x04001DB1 RID: 7601
		[Token(Token = "0x4001DB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<NewWall> roomDivider;
	}

	// Token: 0x02000436 RID: 1078
	[Token(Token = "0x2000436")]
	[Serializable]
	public class PossibleNullExpansion : IEnumerator<object>
	{
		// Token: 0x0600185A RID: 6234 RVA: 0x0000B178 File Offset: 0x00009378
		[Token(Token = "0x600185A")]
		[Address(RVA = "0x94F5F0", Offset = "0x94E5F0", VA = "0x18094F5F0", Slot = "4")]
		public int CompareTo(GenerationController.PossibleNullExpansion otherObject)
		{
			return 0;
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600185B")]
		[Address(RVA = "0x94F670", Offset = "0x94E670", VA = "0x18094F670")]
		public PossibleNullExpansion()
		{
		}

		// Token: 0x04001DB2 RID: 7602
		[Token(Token = "0x4001DB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<NewNode> nodesToExpand;

		// Token: 0x04001DB3 RID: 7603
		[Token(Token = "0x4001DB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewRoom addToRoom;

		// Token: 0x04001DB4 RID: 7604
		[Token(Token = "0x4001DB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ranking;
	}

	// Token: 0x02000437 RID: 1079
	[Token(Token = "0x2000437")]
	public struct ClusterRank
	{
		// Token: 0x04001DB5 RID: 7605
		[Token(Token = "0x4001DB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FurnitureCluster cluster;

		// Token: 0x04001DB6 RID: 7606
		[Token(Token = "0x4001DB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float rank;
	}

	// Token: 0x02000438 RID: 1080
	[Token(Token = "0x2000438")]
	private sealed class <ExeUpdateGeometryAtEndOfFrame>d__18 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600185C RID: 6236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600185C")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <ExeUpdateGeometryAtEndOfFrame>d__18(int <>1__state)
		{
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600185D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0000B190 File Offset: 0x00009390
		[Token(Token = "0x600185E")]
		[Address(RVA = "0x94F740", Offset = "0x94E740", VA = "0x18094F740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C4")]
		private object Current
		{
			[Token(Token = "0x600185F")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001860")]
		[Address(RVA = "0x94FC60", Offset = "0x94EC60", VA = "0x18094FC60", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C5")]
		private object Current
		{
			[Token(Token = "0x6001861")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001DB7 RID: 7607
		[Token(Token = "0x4001DB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001DB8 RID: 7608
		[Token(Token = "0x4001DB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001DB9 RID: 7609
		[Token(Token = "0x4001DB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GenerationController <>4__this;

		// Token: 0x04001DBA RID: 7610
		[Token(Token = "0x4001DBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <wait>5__2;
	}

	// Token: 0x02000439 RID: 1081
	[Token(Token = "0x2000439")]
	private sealed class <LoadGeometryAtEndOfFrame>d__20 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001862 RID: 6242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001862")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <LoadGeometryAtEndOfFrame>d__20(int <>1__state)
		{
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001863")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0000B1A8 File Offset: 0x000093A8
		[Token(Token = "0x6001864")]
		[Address(RVA = "0x94FCB0", Offset = "0x94ECB0", VA = "0x18094FCB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C6")]
		private object Current
		{
			[Token(Token = "0x6001865")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001866")]
		[Address(RVA = "0x950790", Offset = "0x94F790", VA = "0x180950790", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C7")]
		private object Current
		{
			[Token(Token = "0x6001867")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001DBB RID: 7611
		[Token(Token = "0x4001DBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001DBC RID: 7612
		[Token(Token = "0x4001DBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001DBD RID: 7613
		[Token(Token = "0x4001DBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GenerationController <>4__this;

		// Token: 0x04001DBE RID: 7614
		[Token(Token = "0x4001DBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <wait>5__2;
	}

	// Token: 0x0200043A RID: 1082
	[Token(Token = "0x200043A")]
	private sealed class <UnloadOldestRoomsAtEndOfFrame>d__23 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001868 RID: 6248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001868")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <UnloadOldestRoomsAtEndOfFrame>d__23(int <>1__state)
		{
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001869")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0000B1C0 File Offset: 0x000093C0
		[Token(Token = "0x600186A")]
		[Address(RVA = "0x9507E0", Offset = "0x94F7E0", VA = "0x1809507E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C8")]
		private object Current
		{
			[Token(Token = "0x600186B")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600186C")]
		[Address(RVA = "0x9509E0", Offset = "0x94F9E0", VA = "0x1809509E0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C9")]
		private object Current
		{
			[Token(Token = "0x600186D")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001DBF RID: 7615
		[Token(Token = "0x4001DBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001DC0 RID: 7616
		[Token(Token = "0x4001DC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001DC1 RID: 7617
		[Token(Token = "0x4001DC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GenerationController <>4__this;

		// Token: 0x04001DC2 RID: 7618
		[Token(Token = "0x4001DC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <wait>5__2;
	}

	// Token: 0x0200043B RID: 1083
	[Token(Token = "0x200043B")]
	private sealed class <>c__DisplayClass26_0
	{
		// Token: 0x0600186E RID: 6254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600186E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass26_0()
		{
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0000B1D8 File Offset: 0x000093D8
		[Token(Token = "0x600186F")]
		[Address(RVA = "0x950A30", Offset = "0x94FA30", VA = "0x180950A30")]
		internal bool <UpdateWallsFloor>b__0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001DC3 RID: 7619
		[Token(Token = "0x4001DC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 wallOffset;
	}

	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x200043C")]
	private sealed class <>c__DisplayClass26_1
	{
		// Token: 0x06001870 RID: 6256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001870")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass26_1()
		{
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0000B1F0 File Offset: 0x000093F0
		[Token(Token = "0x6001871")]
		[Address(RVA = "0x950A90", Offset = "0x94FA90", VA = "0x180950A90")]
		internal bool <UpdateWallsFloor>b__1(NewNode item)
		{
			return default(bool);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0000B208 File Offset: 0x00009408
		[Token(Token = "0x6001872")]
		[Address(RVA = "0x950A90", Offset = "0x94FA90", VA = "0x180950A90")]
		internal bool <UpdateWallsFloor>b__2(NewNode item)
		{
			return default(bool);
		}

		// Token: 0x04001DC4 RID: 7620
		[Token(Token = "0x4001DC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 check;
	}

	// Token: 0x0200043D RID: 1085
	[Token(Token = "0x200043D")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001874 RID: 6260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001874")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0000B220 File Offset: 0x00009420
		[Token(Token = "0x6001875")]
		[Address(RVA = "0x950B90", Offset = "0x94FB90", VA = "0x180950B90")]
		internal bool <UpdateWallsFloor>b__26_3(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x0000B238 File Offset: 0x00009438
		[Token(Token = "0x6001876")]
		[Address(RVA = "0x950BE0", Offset = "0x94FBE0", VA = "0x180950BE0")]
		internal bool <UpdateWallsFloor>b__26_4(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0000B250 File Offset: 0x00009450
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x950C20", Offset = "0x94FC20", VA = "0x180950C20")]
		internal bool <UpdateWallsFloor>b__26_5(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0000B268 File Offset: 0x00009468
		[Token(Token = "0x6001878")]
		[Address(RVA = "0x950C60", Offset = "0x94FC60", VA = "0x180950C60")]
		internal bool <UpdateWallsFloor>b__26_6(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x0000B280 File Offset: 0x00009480
		[Token(Token = "0x6001879")]
		[Address(RVA = "0x950B90", Offset = "0x94FB90", VA = "0x180950B90")]
		internal bool <UpdateWallsRoom>b__27_3(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x0000B298 File Offset: 0x00009498
		[Token(Token = "0x600187A")]
		[Address(RVA = "0x950BE0", Offset = "0x94FBE0", VA = "0x180950BE0")]
		internal bool <UpdateWallsRoom>b__27_4(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[Token(Token = "0x600187B")]
		[Address(RVA = "0x950C20", Offset = "0x94FC20", VA = "0x180950C20")]
		internal bool <UpdateWallsRoom>b__27_5(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x0000B2C8 File Offset: 0x000094C8
		[Token(Token = "0x600187C")]
		[Address(RVA = "0x950C60", Offset = "0x94FC60", VA = "0x180950C60")]
		internal bool <UpdateWallsRoom>b__27_6(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x0000B2E0 File Offset: 0x000094E0
		[Token(Token = "0x600187D")]
		[Address(RVA = "0x950CB0", Offset = "0x94FCB0", VA = "0x180950CB0")]
		internal int <GenerateAddressLayout>b__29_0(RoomTypePreset p1, RoomTypePreset p2)
		{
			return 0;
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x0000B2F8 File Offset: 0x000094F8
		[Token(Token = "0x600187E")]
		[Address(RVA = "0x950CF0", Offset = "0x94FCF0", VA = "0x180950CF0")]
		internal bool <GenerateAddressLayout>b__29_4(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x0000B310 File Offset: 0x00009510
		[Token(Token = "0x600187F")]
		[Address(RVA = "0x950CF0", Offset = "0x94FCF0", VA = "0x180950CF0")]
		internal bool <GenerateAddressLayout>b__29_5(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x0000B328 File Offset: 0x00009528
		[Token(Token = "0x6001880")]
		[Address(RVA = "0x80D510", Offset = "0x80C510", VA = "0x18080D510")]
		internal bool <GenerateAddressLayout>b__29_6(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x0000B340 File Offset: 0x00009540
		[Token(Token = "0x6001881")]
		[Address(RVA = "0x80D510", Offset = "0x80C510", VA = "0x18080D510")]
		internal bool <GenerateAddressLayout>b__29_7(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x0000B358 File Offset: 0x00009558
		[Token(Token = "0x6001882")]
		[Address(RVA = "0x950D30", Offset = "0x94FD30", VA = "0x180950D30")]
		internal bool <GenerateAddressLayout>b__29_12(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0000B370 File Offset: 0x00009570
		[Token(Token = "0x6001883")]
		[Address(RVA = "0x950D30", Offset = "0x94FD30", VA = "0x180950D30")]
		internal bool <GenerateAddressLayout>b__29_13(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x0000B388 File Offset: 0x00009588
		[Token(Token = "0x6001884")]
		[Address(RVA = "0x950D60", Offset = "0x94FD60", VA = "0x180950D60")]
		internal int <GenerateAddressLayout>b__29_16(NewWall item1)
		{
			return 0;
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x0000B3A0 File Offset: 0x000095A0
		[Token(Token = "0x6001885")]
		[Address(RVA = "0x950D60", Offset = "0x94FD60", VA = "0x180950D60")]
		internal int <GenerateAddressLayout>b__29_17(NewWall item1)
		{
			return 0;
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0000B3B8 File Offset: 0x000095B8
		[Token(Token = "0x6001886")]
		[Address(RVA = "0x950D80", Offset = "0x94FD80", VA = "0x180950D80")]
		internal int <GenerateAddressLayout>b__29_18(NewWall item1)
		{
			return 0;
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[Token(Token = "0x6001887")]
		[Address(RVA = "0x950D80", Offset = "0x94FD80", VA = "0x180950D80")]
		internal int <GenerateAddressLayout>b__29_19(NewWall item1)
		{
			return 0;
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0000B3E8 File Offset: 0x000095E8
		[Token(Token = "0x6001888")]
		[Address(RVA = "0x545220", Offset = "0x544220", VA = "0x180545220")]
		internal bool <GetPossibleRoomLocations>b__32_0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x0000B400 File Offset: 0x00009600
		[Token(Token = "0x6001889")]
		[Address(RVA = "0x950DA0", Offset = "0x94FDA0", VA = "0x180950DA0")]
		internal bool <GetPossibleRoomLocations>b__32_1(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0000B418 File Offset: 0x00009618
		[Token(Token = "0x600188A")]
		[Address(RVA = "0x950FA0", Offset = "0x94FFA0", VA = "0x180950FA0")]
		internal bool <GetPossibleRoomLocations>b__32_2(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0000B430 File Offset: 0x00009630
		[Token(Token = "0x600188B")]
		[Address(RVA = "0x545220", Offset = "0x544220", VA = "0x180545220")]
		internal bool <GetPossibleRoomLocations>b__32_3(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0000B448 File Offset: 0x00009648
		[Token(Token = "0x600188C")]
		[Address(RVA = "0x80D510", Offset = "0x80C510", VA = "0x18080D510")]
		internal bool <HallwayPathfind>b__43_0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0000B460 File Offset: 0x00009660
		[Token(Token = "0x600188D")]
		[Address(RVA = "0x951010", Offset = "0x950010", VA = "0x180951010")]
		internal bool <GenerateGeometry>b__44_2(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x600188E")]
		[Address(RVA = "0x951040", Offset = "0x950040", VA = "0x180951040")]
		internal int <GenerateLightZones>b__45_0(NewNode item)
		{
			return 0;
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0000B490 File Offset: 0x00009690
		[Token(Token = "0x600188F")]
		[Address(RVA = "0x951060", Offset = "0x950060", VA = "0x180951060")]
		internal int <GenerateLightZones>b__45_1(NewRoom.LightZoneData item)
		{
			return 0;
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0000B4A8 File Offset: 0x000096A8
		[Token(Token = "0x6001890")]
		[Address(RVA = "0x9510B0", Offset = "0x9500B0", VA = "0x1809510B0")]
		internal int <GenerateAddressDecor>b__46_0(NewRoom p1, NewRoom p2)
		{
			return 0;
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0000B4C0 File Offset: 0x000096C0
		[Token(Token = "0x6001891")]
		[Address(RVA = "0x951110", Offset = "0x950110", VA = "0x180951110")]
		internal bool <GenerateAddressDecor>b__46_1(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0000B4D8 File Offset: 0x000096D8
		[Token(Token = "0x6001892")]
		[Address(RVA = "0x951130", Offset = "0x950130", VA = "0x180951130")]
		internal int <FurnishRoom>b__47_0(GenerationController.ClusterRank p1, GenerationController.ClusterRank p2)
		{
			return 0;
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[Token(Token = "0x6001893")]
		[Address(RVA = "0x951130", Offset = "0x950130", VA = "0x180951130")]
		internal int <FurnishRoom>b__47_1(GenerationController.ClusterRank p1, GenerationController.ClusterRank p2)
		{
			return 0;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x0000B508 File Offset: 0x00009708
		[Token(Token = "0x6001894")]
		[Address(RVA = "0x9511B0", Offset = "0x9501B0", VA = "0x1809511B0")]
		internal bool <ClusterCountChecks>b__48_0(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0000B520 File Offset: 0x00009720
		[Token(Token = "0x6001895")]
		[Address(RVA = "0x9512D0", Offset = "0x9502D0", VA = "0x1809512D0")]
		internal bool <GetBestFurnitureClusterLocation>b__49_0(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0000B538 File Offset: 0x00009738
		[Token(Token = "0x6001896")]
		[Address(RVA = "0x874F10", Offset = "0x873F10", VA = "0x180874F10")]
		internal bool <GetBestFurnitureClusterLocation>b__49_1(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x0000B550 File Offset: 0x00009750
		[Token(Token = "0x6001897")]
		[Address(RVA = "0x4812A0", Offset = "0x4802A0", VA = "0x1804812A0")]
		internal bool <GetBestFurnitureClusterLocation>b__49_2(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x0000B568 File Offset: 0x00009768
		[Token(Token = "0x6001898")]
		[Address(RVA = "0x9513F0", Offset = "0x9503F0", VA = "0x1809513F0")]
		internal bool <GetBestFurnitureClusterLocation>b__49_3(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0000B580 File Offset: 0x00009780
		[Token(Token = "0x6001899")]
		[Address(RVA = "0x80D510", Offset = "0x80C510", VA = "0x18080D510")]
		internal bool <GetBestFurnitureClusterLocation>b__49_10(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x0000B598 File Offset: 0x00009798
		[Token(Token = "0x600189A")]
		[Address(RVA = "0x9514A0", Offset = "0x9504A0", VA = "0x1809514A0")]
		internal bool <GetBestFurnitureClusterLocation>b__49_11(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[Token(Token = "0x600189B")]
		[Address(RVA = "0x9514D0", Offset = "0x9504D0", VA = "0x1809514D0")]
		internal bool <GetBestFurnitureClusterLocation>b__49_4(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[Token(Token = "0x600189C")]
		[Address(RVA = "0x545220", Offset = "0x544220", VA = "0x180545220")]
		internal bool <GetBestFurnitureClusterLocation>b__49_5(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x0000B5E0 File Offset: 0x000097E0
		[Token(Token = "0x600189D")]
		[Address(RVA = "0x951550", Offset = "0x950550", VA = "0x180951550")]
		internal bool <GetBestFurnitureClusterLocation>b__49_6(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0000B5F8 File Offset: 0x000097F8
		[Token(Token = "0x600189E")]
		[Address(RVA = "0x951600", Offset = "0x950600", VA = "0x180951600")]
		internal bool <GetBestFurnitureClusterLocation>b__49_7(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0000B610 File Offset: 0x00009810
		[Token(Token = "0x600189F")]
		[Address(RVA = "0x951630", Offset = "0x950630", VA = "0x180951630")]
		internal bool <GetBestFurnitureClusterLocation>b__49_8(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0000B628 File Offset: 0x00009828
		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x9516B0", Offset = "0x9506B0", VA = "0x1809516B0")]
		internal bool <GetBestFurnitureClusterLocation>b__49_9(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0000B640 File Offset: 0x00009840
		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x9517D0", Offset = "0x9507D0", VA = "0x1809517D0")]
		internal bool <GetBestFurnitureClusterLocation>b__49_14(Vector3Int item)
		{
			return default(bool);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0000B658 File Offset: 0x00009858
		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x9517E0", Offset = "0x9507E0", VA = "0x1809517E0")]
		internal bool <GetBestFurnitureClusterLocation>b__49_15(FurnitureClass item)
		{
			return default(bool);
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0000B670 File Offset: 0x00009870
		[Token(Token = "0x60018A3")]
		[Address(RVA = "0x951800", Offset = "0x950800", VA = "0x180951800")]
		internal bool <GetBestFurnitureClusterLocation>b__49_16(FurnitureClass.BlockedAccess item)
		{
			return default(bool);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0000B688 File Offset: 0x00009888
		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x951850", Offset = "0x950850", VA = "0x180951850")]
		internal bool <GetValidFurniture>b__54_0(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x04001DC5 RID: 7621
		[Token(Token = "0x4001DC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly GenerationController.<>c <>9;

		// Token: 0x04001DC6 RID: 7622
		[Token(Token = "0x4001DC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<NewWall> <>9__26_3;

		// Token: 0x04001DC7 RID: 7623
		[Token(Token = "0x4001DC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<NewWall> <>9__26_4;

		// Token: 0x04001DC8 RID: 7624
		[Token(Token = "0x4001DC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<NewWall> <>9__26_5;

		// Token: 0x04001DC9 RID: 7625
		[Token(Token = "0x4001DC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<NewWall> <>9__26_6;

		// Token: 0x04001DCA RID: 7626
		[Token(Token = "0x4001DCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<NewWall> <>9__27_3;

		// Token: 0x04001DCB RID: 7627
		[Token(Token = "0x4001DCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<NewWall> <>9__27_4;

		// Token: 0x04001DCC RID: 7628
		[Token(Token = "0x4001DCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<NewWall> <>9__27_5;

		// Token: 0x04001DCD RID: 7629
		[Token(Token = "0x4001DCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Predicate<NewWall> <>9__27_6;

		// Token: 0x04001DCE RID: 7630
		[Token(Token = "0x4001DCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Comparison<RoomTypePreset> <>9__29_0;

		// Token: 0x04001DCF RID: 7631
		[Token(Token = "0x4001DCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Predicate<NewWall> <>9__29_4;

		// Token: 0x04001DD0 RID: 7632
		[Token(Token = "0x4001DD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Predicate<NewWall> <>9__29_5;

		// Token: 0x04001DD1 RID: 7633
		[Token(Token = "0x4001DD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Predicate<NewWall> <>9__29_6;

		// Token: 0x04001DD2 RID: 7634
		[Token(Token = "0x4001DD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Predicate<NewWall> <>9__29_7;

		// Token: 0x04001DD3 RID: 7635
		[Token(Token = "0x4001DD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static Predicate<NewWall> <>9__29_12;

		// Token: 0x04001DD4 RID: 7636
		[Token(Token = "0x4001DD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static Predicate<NewWall> <>9__29_13;

		// Token: 0x04001DD5 RID: 7637
		[Token(Token = "0x4001DD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static Func<NewWall, int> <>9__29_16;

		// Token: 0x04001DD6 RID: 7638
		[Token(Token = "0x4001DD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static Func<NewWall, int> <>9__29_17;

		// Token: 0x04001DD7 RID: 7639
		[Token(Token = "0x4001DD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static Func<NewWall, int> <>9__29_18;

		// Token: 0x04001DD8 RID: 7640
		[Token(Token = "0x4001DD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static Func<NewWall, int> <>9__29_19;

		// Token: 0x04001DD9 RID: 7641
		[Token(Token = "0x4001DD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static Predicate<NewWall> <>9__32_0;

		// Token: 0x04001DDA RID: 7642
		[Token(Token = "0x4001DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static Predicate<NewWall> <>9__32_1;

		// Token: 0x04001DDB RID: 7643
		[Token(Token = "0x4001DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static Predicate<NewWall> <>9__32_2;

		// Token: 0x04001DDC RID: 7644
		[Token(Token = "0x4001DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static Predicate<NewWall> <>9__32_3;

		// Token: 0x04001DDD RID: 7645
		[Token(Token = "0x4001DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static Predicate<NewWall> <>9__43_0;

		// Token: 0x04001DDE RID: 7646
		[Token(Token = "0x4001DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static Predicate<NewWall> <>9__44_2;

		// Token: 0x04001DDF RID: 7647
		[Token(Token = "0x4001DDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static Func<NewNode, int> <>9__45_0;

		// Token: 0x04001DE0 RID: 7648
		[Token(Token = "0x4001DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static Func<NewRoom.LightZoneData, int> <>9__45_1;

		// Token: 0x04001DE1 RID: 7649
		[Token(Token = "0x4001DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static Comparison<NewRoom> <>9__46_0;

		// Token: 0x04001DE2 RID: 7650
		[Token(Token = "0x4001DE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static Predicate<NewRoom> <>9__46_1;

		// Token: 0x04001DE3 RID: 7651
		[Token(Token = "0x4001DE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static Comparison<GenerationController.ClusterRank> <>9__47_0;

		// Token: 0x04001DE4 RID: 7652
		[Token(Token = "0x4001DE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public static Comparison<GenerationController.ClusterRank> <>9__47_1;

		// Token: 0x04001DE5 RID: 7653
		[Token(Token = "0x4001DE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static Predicate<NewAddress> <>9__48_0;

		// Token: 0x04001DE6 RID: 7654
		[Token(Token = "0x4001DE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static Predicate<NewAddress> <>9__49_0;

		// Token: 0x04001DE7 RID: 7655
		[Token(Token = "0x4001DE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static Predicate<AirDuctGroup.AirDuctSection> <>9__49_1;

		// Token: 0x04001DE8 RID: 7656
		[Token(Token = "0x4001DE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public static Predicate<AirDuctGroup.AirDuctSection> <>9__49_2;

		// Token: 0x04001DE9 RID: 7657
		[Token(Token = "0x4001DE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public static Predicate<FurnitureLocation> <>9__49_3;

		// Token: 0x04001DEA RID: 7658
		[Token(Token = "0x4001DEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public static Predicate<NewWall> <>9__49_10;

		// Token: 0x04001DEB RID: 7659
		[Token(Token = "0x4001DEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public static Predicate<NewWall> <>9__49_11;

		// Token: 0x04001DEC RID: 7660
		[Token(Token = "0x4001DEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public static Predicate<FurnitureLocation> <>9__49_4;

		// Token: 0x04001DED RID: 7661
		[Token(Token = "0x4001DED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public static Predicate<NewWall> <>9__49_5;

		// Token: 0x04001DEE RID: 7662
		[Token(Token = "0x4001DEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public static Predicate<FurnitureLocation> <>9__49_6;

		// Token: 0x04001DEF RID: 7663
		[Token(Token = "0x4001DEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public static Predicate<AirDuctGroup.AirDuctSection> <>9__49_7;

		// Token: 0x04001DF0 RID: 7664
		[Token(Token = "0x4001DF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public static Predicate<FurnitureLocation> <>9__49_8;

		// Token: 0x04001DF1 RID: 7665
		[Token(Token = "0x4001DF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public static Predicate<NewWall> <>9__49_9;

		// Token: 0x04001DF2 RID: 7666
		[Token(Token = "0x4001DF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public static Predicate<Vector3Int> <>9__49_14;

		// Token: 0x04001DF3 RID: 7667
		[Token(Token = "0x4001DF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public static Predicate<FurnitureClass> <>9__49_15;

		// Token: 0x04001DF4 RID: 7668
		[Token(Token = "0x4001DF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public static Predicate<FurnitureClass.BlockedAccess> <>9__49_16;

		// Token: 0x04001DF5 RID: 7669
		[Token(Token = "0x4001DF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public static Predicate<FurnitureLocation> <>9__54_0;
	}

	// Token: 0x0200043E RID: 1086
	[Token(Token = "0x200043E")]
	private sealed class <>c__DisplayClass27_0
	{
		// Token: 0x060018A5 RID: 6309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass27_0()
		{
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0000B6A0 File Offset: 0x000098A0
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x950A30", Offset = "0x94FA30", VA = "0x180950A30")]
		internal bool <UpdateWallsRoom>b__0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001DF6 RID: 7670
		[Token(Token = "0x4001DF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 wallOffset;
	}

	// Token: 0x0200043F RID: 1087
	[Token(Token = "0x200043F")]
	private sealed class <>c__DisplayClass27_1
	{
		// Token: 0x060018A7 RID: 6311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass27_1()
		{
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x950A90", Offset = "0x94FA90", VA = "0x180950A90")]
		internal bool <UpdateWallsRoom>b__1(NewNode item)
		{
			return default(bool);
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0000B6D0 File Offset: 0x000098D0
		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x950A90", Offset = "0x94FA90", VA = "0x180950A90")]
		internal bool <UpdateWallsRoom>b__2(NewNode item)
		{
			return default(bool);
		}

		// Token: 0x04001DF7 RID: 7671
		[Token(Token = "0x4001DF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 check;
	}

	// Token: 0x02000440 RID: 1088
	[Token(Token = "0x2000440")]
	private sealed class <>c__DisplayClass29_0
	{
		// Token: 0x060018AA RID: 6314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass29_0()
		{
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0000B6E8 File Offset: 0x000098E8
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x951880", Offset = "0x950880", VA = "0x180951880")]
		internal bool <GenerateAddressLayout>b__1(NewNode item)
		{
			return default(bool);
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0000B700 File Offset: 0x00009900
		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x951A60", Offset = "0x950A60", VA = "0x180951A60")]
		internal bool <GenerateAddressLayout>b__2(NewNode item)
		{
			return default(bool);
		}

		// Token: 0x04001DF8 RID: 7672
		[Token(Token = "0x4001DF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewAddress ad;

		// Token: 0x04001DF9 RID: 7673
		[Token(Token = "0x4001DF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<NewNode> <>9__1;

		// Token: 0x04001DFA RID: 7674
		[Token(Token = "0x4001DFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<NewNode> <>9__2;
	}

	// Token: 0x02000441 RID: 1089
	[Token(Token = "0x2000441")]
	private sealed class <>c__DisplayClass29_1
	{
		// Token: 0x060018AD RID: 6317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass29_1()
		{
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0000B718 File Offset: 0x00009918
		[Token(Token = "0x60018AE")]
		[Address(RVA = "0x951C20", Offset = "0x950C20", VA = "0x180951C20")]
		internal bool <GenerateAddressLayout>b__3(RoomTypePreset item)
		{
			return default(bool);
		}

		// Token: 0x04001DFB RID: 7675
		[Token(Token = "0x4001DFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewWall wall;
	}

	// Token: 0x02000442 RID: 1090
	[Token(Token = "0x2000442")]
	private sealed class <>c__DisplayClass29_2
	{
		// Token: 0x060018AF RID: 6319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass29_2()
		{
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x951CA0", Offset = "0x950CA0", VA = "0x180951CA0")]
		internal bool <GenerateAddressLayout>b__8(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x951D70", Offset = "0x950D70", VA = "0x180951D70")]
		internal bool <GenerateAddressLayout>b__9(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x951F40", Offset = "0x950F40", VA = "0x180951F40")]
		internal bool <GenerateAddressLayout>b__10(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0000B778 File Offset: 0x00009978
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x951C20", Offset = "0x950C20", VA = "0x180951C20")]
		internal bool <GenerateAddressLayout>b__11(RoomTypePreset item)
		{
			return default(bool);
		}

		// Token: 0x04001DFC RID: 7676
		[Token(Token = "0x4001DFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewWall wall;

		// Token: 0x04001DFD RID: 7677
		[Token(Token = "0x4001DFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<NewWall> <>9__8;
	}

	// Token: 0x02000443 RID: 1091
	[Token(Token = "0x2000443")]
	private sealed class <>c__DisplayClass29_3
	{
		// Token: 0x060018B4 RID: 6324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass29_3()
		{
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x952120", Offset = "0x951120", VA = "0x180952120")]
		internal bool <GenerateAddressLayout>b__14(NewRoom.RoomDivider item)
		{
			return default(bool);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x952470", Offset = "0x951470", VA = "0x180952470")]
		internal bool <GenerateAddressLayout>b__15(NewRoom.RoomDivider item)
		{
			return default(bool);
		}

		// Token: 0x04001DFE RID: 7678
		[Token(Token = "0x4001DFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GenerationController.PossibleDoorwayLocation newDoorway;
	}

	// Token: 0x02000444 RID: 1092
	[Token(Token = "0x2000444")]
	private sealed class <>c__DisplayClass29_4
	{
		// Token: 0x060018B7 RID: 6327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass29_4()
		{
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0000B7C0 File Offset: 0x000099C0
		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x9527C0", Offset = "0x9517C0", VA = "0x1809527C0")]
		internal bool <GenerateAddressLayout>b__20(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x04001DFF RID: 7679
		[Token(Token = "0x4001DFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewRoom.RoomDivider div;
	}

	// Token: 0x02000445 RID: 1093
	[Token(Token = "0x2000445")]
	private sealed class <>c__DisplayClass36_0
	{
		// Token: 0x060018B9 RID: 6329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass36_0()
		{
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x952DC0", Offset = "0x951DC0", VA = "0x180952DC0")]
		internal bool <MustAdjoinOneOfCheck>b__0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001E00 RID: 7680
		[Token(Token = "0x4001E00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewNode scanNode;
	}

	// Token: 0x02000446 RID: 1094
	[Token(Token = "0x2000446")]
	private sealed class <>c__DisplayClass37_0
	{
		// Token: 0x060018BB RID: 6331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass37_0()
		{
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0000B7F0 File Offset: 0x000099F0
		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x952DC0", Offset = "0x951DC0", VA = "0x180952DC0")]
		internal bool <CheckEntranceConnection>b__0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001E01 RID: 7681
		[Token(Token = "0x4001E01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewNode scanNode;
	}

	// Token: 0x02000447 RID: 1095
	[Token(Token = "0x2000447")]
	private sealed class <>c__DisplayClass43_0
	{
		// Token: 0x060018BD RID: 6333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass43_0()
		{
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0000B808 File Offset: 0x00009A08
		[Token(Token = "0x60018BE")]
		[Address(RVA = "0x952E00", Offset = "0x951E00", VA = "0x180952E00")]
		internal bool <HallwayPathfind>b__1(Vector2Int item)
		{
			return default(bool);
		}

		// Token: 0x04001E02 RID: 7682
		[Token(Token = "0x4001E02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2Int invertedEntranceOffset;
	}

	// Token: 0x02000448 RID: 1096
	[Token(Token = "0x2000448")]
	private sealed class <>c__DisplayClass44_0
	{
		// Token: 0x060018BF RID: 6335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass44_0()
		{
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0000B820 File Offset: 0x00009A20
		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x952E20", Offset = "0x951E20", VA = "0x180952E20")]
		internal bool <GenerateGeometry>b__0(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x04001E03 RID: 7683
		[Token(Token = "0x4001E03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewRoom room;
	}

	// Token: 0x02000449 RID: 1097
	[Token(Token = "0x2000449")]
	private sealed class <>c__DisplayClass44_1
	{
		// Token: 0x060018C1 RID: 6337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass44_1()
		{
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0000B838 File Offset: 0x00009A38
		[Token(Token = "0x60018C2")]
		[Address(RVA = "0x953020", Offset = "0x952020", VA = "0x180953020")]
		internal bool <GenerateGeometry>b__1(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001E04 RID: 7684
		[Token(Token = "0x4001E04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewWall doorway;

		// Token: 0x04001E05 RID: 7685
		[Token(Token = "0x4001E05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<NewWall> <>9__1;
	}

	// Token: 0x0200044A RID: 1098
	[Token(Token = "0x200044A")]
	private sealed class <>c__DisplayClass45_0
	{
		// Token: 0x060018C3 RID: 6339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass45_0()
		{
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x0000B850 File Offset: 0x00009A50
		[Token(Token = "0x60018C4")]
		[Address(RVA = "0x94F220", Offset = "0x94E220", VA = "0x18094F220")]
		internal bool <GenerateLightZones>b__2(NewNode item)
		{
			return default(bool);
		}

		// Token: 0x04001E06 RID: 7686
		[Token(Token = "0x4001E06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 localCoord;
	}

	// Token: 0x0200044B RID: 1099
	[Token(Token = "0x200044B")]
	private sealed class <>c__DisplayClass47_0
	{
		// Token: 0x060018C5 RID: 6341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass47_0()
		{
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0000B868 File Offset: 0x00009A68
		[Token(Token = "0x60018C6")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__2(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0000B880 File Offset: 0x00009A80
		[Token(Token = "0x60018C7")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__3(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x04001E07 RID: 7687
		[Token(Token = "0x4001E07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurnitureCluster cluster;
	}

	// Token: 0x0200044C RID: 1100
	[Token(Token = "0x200044C")]
	private sealed class <>c__DisplayClass47_1
	{
		// Token: 0x060018C8 RID: 6344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass47_1()
		{
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x0000B898 File Offset: 0x00009A98
		[Token(Token = "0x60018C9")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__4(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		[Token(Token = "0x60018CA")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__5(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		[Token(Token = "0x60018CB")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__10(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		[Token(Token = "0x60018CC")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__11(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		[Token(Token = "0x60018CD")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__6(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0000B910 File Offset: 0x00009B10
		[Token(Token = "0x60018CE")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__7(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0000B928 File Offset: 0x00009B28
		[Token(Token = "0x60018CF")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__8(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0000B940 File Offset: 0x00009B40
		[Token(Token = "0x60018D0")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__9(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x04001E08 RID: 7688
		[Token(Token = "0x4001E08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GenerationController.ClusterRank cluster;
	}

	// Token: 0x0200044D RID: 1101
	[Token(Token = "0x200044D")]
	private sealed class <>c__DisplayClass47_2
	{
		// Token: 0x060018D1 RID: 6353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass47_2()
		{
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0000B958 File Offset: 0x00009B58
		[Token(Token = "0x60018D2")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__12(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0000B970 File Offset: 0x00009B70
		[Token(Token = "0x60018D3")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__13(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x04001E09 RID: 7689
		[Token(Token = "0x4001E09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurnitureCluster cl;
	}

	// Token: 0x0200044E RID: 1102
	[Token(Token = "0x200044E")]
	private sealed class <>c__DisplayClass47_3
	{
		// Token: 0x060018D4 RID: 6356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass47_3()
		{
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0000B988 File Offset: 0x00009B88
		[Token(Token = "0x60018D5")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__14(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__15(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x04001E0A RID: 7690
		[Token(Token = "0x4001E0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurnitureCluster cl;
	}

	// Token: 0x0200044F RID: 1103
	[Token(Token = "0x200044F")]
	private sealed class <>c__DisplayClass47_4
	{
		// Token: 0x060018D7 RID: 6359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018D7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass47_4()
		{
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__16(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x60018D9")]
		[Address(RVA = "0x4FEB00", Offset = "0x4FDB00", VA = "0x1804FEB00")]
		internal bool <FurnishRoom>b__17(GenerationController.ClusterRank item)
		{
			return default(bool);
		}

		// Token: 0x04001E0B RID: 7691
		[Token(Token = "0x4001E0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurnitureCluster cl;
	}

	// Token: 0x02000450 RID: 1104
	[Token(Token = "0x2000450")]
	private sealed class <>c__DisplayClass49_0
	{
		// Token: 0x060018DA RID: 6362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass49_0()
		{
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[Token(Token = "0x60018DB")]
		[Address(RVA = "0x953080", Offset = "0x952080", VA = "0x180953080")]
		internal bool <GetBestFurnitureClusterLocation>b__12(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x04001E0C RID: 7692
		[Token(Token = "0x4001E0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurnitureClass furnClass;
	}

	// Token: 0x02000451 RID: 1105
	[Token(Token = "0x2000451")]
	private sealed class <>c__DisplayClass49_1
	{
		// Token: 0x060018DC RID: 6364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass49_1()
		{
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0000BA00 File Offset: 0x00009C00
		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x953110", Offset = "0x952110", VA = "0x180953110")]
		internal bool <GetBestFurnitureClusterLocation>b__13(NewNode item)
		{
			return default(bool);
		}

		// Token: 0x04001E0D RID: 7693
		[Token(Token = "0x4001E0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewWall foundWall;

		// Token: 0x04001E0E RID: 7694
		[Token(Token = "0x4001E0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<NewNode> <>9__13;
	}

	// Token: 0x02000452 RID: 1106
	[Token(Token = "0x2000452")]
	private sealed class <>c__DisplayClass51_0
	{
		// Token: 0x060018DE RID: 6366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass51_0()
		{
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0000BA18 File Offset: 0x00009C18
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x875AA0", Offset = "0x874AA0", VA = "0x180875AA0")]
		internal bool <IsFurniturePlacementValid>b__0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0000BA30 File Offset: 0x00009C30
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x875AA0", Offset = "0x874AA0", VA = "0x180875AA0")]
		internal bool <IsFurniturePlacementValid>b__1(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001E0F RID: 7695
		[Token(Token = "0x4001E0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 offset1;

		// Token: 0x04001E10 RID: 7696
		[Token(Token = "0x4001E10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 offset2;
	}

	// Token: 0x02000453 RID: 1107
	[Token(Token = "0x2000453")]
	private sealed class <>c__DisplayClass52_0
	{
		// Token: 0x060018E1 RID: 6369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass52_0()
		{
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0000BA48 File Offset: 0x00009C48
		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x875AA0", Offset = "0x874AA0", VA = "0x180875AA0")]
		internal bool <IsFurniturePlacementValidOLD>b__0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0000BA60 File Offset: 0x00009C60
		[Token(Token = "0x60018E3")]
		[Address(RVA = "0x875AA0", Offset = "0x874AA0", VA = "0x180875AA0")]
		internal bool <IsFurniturePlacementValidOLD>b__1(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001E11 RID: 7697
		[Token(Token = "0x4001E11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 offset1;

		// Token: 0x04001E12 RID: 7698
		[Token(Token = "0x4001E12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 offset2;
	}

	// Token: 0x02000454 RID: 1108
	[Token(Token = "0x2000454")]
	private sealed class <>c__DisplayClass55_0
	{
		// Token: 0x060018E4 RID: 6372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass55_0()
		{
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0000BA78 File Offset: 0x00009C78
		[Token(Token = "0x60018E5")]
		[Address(RVA = "0x953150", Offset = "0x952150", VA = "0x180953150")]
		internal bool <PickArt>b__0(ArtPreset item)
		{
			return default(bool);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0000BA90 File Offset: 0x00009C90
		[Token(Token = "0x60018E6")]
		[Address(RVA = "0x953270", Offset = "0x952270", VA = "0x180953270")]
		internal bool <PickArt>b__1(ArtPreset item)
		{
			return default(bool);
		}

		// Token: 0x04001E13 RID: 7699
		[Token(Token = "0x4001E13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ArtPreset.ArtOrientation orientation;

		// Token: 0x04001E14 RID: 7700
		[Token(Token = "0x4001E14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float wealthLevel;

		// Token: 0x04001E15 RID: 7701
		[Token(Token = "0x4001E15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewRoom room;
	}

	// Token: 0x02000455 RID: 1109
	[Token(Token = "0x2000455")]
	private sealed class <>c__DisplayClass55_1
	{
		// Token: 0x060018E7 RID: 6375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass55_1()
		{
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		[Token(Token = "0x60018E8")]
		[Address(RVA = "0x953310", Offset = "0x952310", VA = "0x180953310")]
		internal bool <PickArt>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04001E16 RID: 7702
		[Token(Token = "0x4001E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ArtPreset.ArtPreference pref;

		// Token: 0x04001E17 RID: 7703
		[Token(Token = "0x4001E17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<Human.Trait> <>9__2;
	}
}
