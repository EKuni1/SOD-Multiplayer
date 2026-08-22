using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000479 RID: 1145
[Token(Token = "0x2000479")]
public class MeshPoolingController : MonoBehaviour
{
	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06001A2C RID: 6700 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000CB")]
	public static MeshPoolingController Instance
	{
		[Token(Token = "0x6001A2C")]
		[Address(RVA = "0x974B80", Offset = "0x973B80", VA = "0x180974B80")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001A2D RID: 6701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A2D")]
	[Address(RVA = "0x974BC0", Offset = "0x973BC0", VA = "0x180974BC0")]
	private void Awake()
	{
	}

	// Token: 0x06001A2E RID: 6702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A2E")]
	[Address(RVA = "0x974F10", Offset = "0x973F10", VA = "0x180974F10")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001A2F RID: 6703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A2F")]
	[Address(RVA = "0x9751B0", Offset = "0x9741B0", VA = "0x1809751B0")]
	public void SpawnMeshesForRoom(NewRoom room)
	{
	}

	// Token: 0x06001A30 RID: 6704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A30")]
	[Address(RVA = "0x9753F0", Offset = "0x9743F0", VA = "0x1809753F0")]
	public void SpawnModularRoomElements(NewRoom room, bool prepForCombineMeshes, out List<MeshFilter> wallChildMeshes, out Dictionary<NewBuilding, List<MeshFilter>> separateWallChildMeshes, out List<MeshFilter> floorChildMeshes, out List<MeshFilter> ceilingChildMeshes)
	{
	}

	// Token: 0x06001A31 RID: 6705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A31")]
	[Address(RVA = "0x9763F0", Offset = "0x9753F0", VA = "0x1809763F0")]
	public void SpawnExtraRoomElements(NewRoom room)
	{
	}

	// Token: 0x06001A32 RID: 6706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A32")]
	[Address(RVA = "0x976930", Offset = "0x975930", VA = "0x180976930")]
	public void GetCombinedRoomMeshes(NewRoom room, out GameObject floor, out GameObject walls, out Dictionary<NewBuilding, GameObject> additionalWalls, out GameObject ceiling, out MeshRenderer floorRend, out MeshRenderer wallsRend, out MeshRenderer ceilingRend)
	{
	}

	// Token: 0x06001A33 RID: 6707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A33")]
	[Address(RVA = "0x9772D0", Offset = "0x9762D0", VA = "0x1809772D0")]
	public void BuildCombinedMeshesForRoom(NewRoom room, out Mesh floorMesh, out Mesh wallMesh, out Dictionary<NewBuilding, Mesh> additionalWallMeshes, out Mesh ceilingMesh, bool returnGameObjects, out GameObject floor, out GameObject walls, out Dictionary<NewBuilding, GameObject> additionalWalls, out GameObject ceiling, out MeshRenderer floorRend, out MeshRenderer wallsRend, out MeshRenderer ceilingRend)
	{
	}

	// Token: 0x06001A34 RID: 6708 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A34")]
	[Address(RVA = "0x979B80", Offset = "0x978B80", VA = "0x180979B80")]
	public Mesh CombineMeshes(ref List<MeshFilter> childMeshes, bool markNoLongerReadable = true, bool bakePhysics = true, string meshName = "CombinedMesh")
	{
		return null;
	}

	// Token: 0x06001A35 RID: 6709 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A35")]
	[Address(RVA = "0x97A260", Offset = "0x979260", VA = "0x18097A260")]
	public Mesh CombineMeshesWithMeshAPI(ref List<MeshFilter> meshFilters, bool markNoLongerReadable = true, bool bakePhysics = true, string meshName = "CombinedMesh")
	{
		return null;
	}

	// Token: 0x06001A36 RID: 6710 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A36")]
	[Address(RVA = "0x97B190", Offset = "0x97A190", VA = "0x18097B190")]
	public static Mesh WeldVertices(Mesh aMesh)
	{
		return null;
	}

	// Token: 0x06001A37 RID: 6711 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A37")]
	[Address(RVA = "0x97B1A0", Offset = "0x97A1A0", VA = "0x18097B1A0")]
	public GameObject CreateGameObjectFromMesh(Mesh mesh, NewRoom room, string newName, ShadowCastingMode shadowMode, out MeshRenderer meshRenderer)
	{
		return null;
	}

	// Token: 0x06001A38 RID: 6712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A38")]
	[Address(RVA = "0x97B840", Offset = "0x97A840", VA = "0x18097B840")]
	public void ProcessWall(GameObject wallObject, NewRoom room, [Optional] NewBuilding building)
	{
	}

	// Token: 0x06001A39 RID: 6713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A39")]
	[Address(RVA = "0x97C390", Offset = "0x97B390", VA = "0x18097C390")]
	public void ProcessFloor(GameObject floorObject, NewRoom room)
	{
	}

	// Token: 0x06001A3A RID: 6714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A3A")]
	[Address(RVA = "0x97C690", Offset = "0x97B690", VA = "0x18097C690")]
	public void ProcessCeiling(GameObject ceilingObject, NewRoom room)
	{
	}

	// Token: 0x06001A3B RID: 6715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A3B")]
	[Address(RVA = "0x97CD00", Offset = "0x97BD00", VA = "0x18097CD00")]
	private void Update()
	{
	}

	// Token: 0x06001A3C RID: 6716 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
	[Token(Token = "0x6001A3C")]
	[Address(RVA = "0x97D2B0", Offset = "0x97C2B0", VA = "0x18097D2B0")]
	private bool IsBackgroundCachingAllowed()
	{
		return default(bool);
	}

	// Token: 0x06001A3D RID: 6717 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001A3D")]
	[Address(RVA = "0x97D3C0", Offset = "0x97C3C0", VA = "0x18097D3C0")]
	private IEnumerator ThreadedMeshGeneration(MeshPoolingController.LoaderThread loaderReference)
	{
		return null;
	}

	// Token: 0x06001A3E RID: 6718 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
	[Token(Token = "0x6001A3E")]
	[Address(RVA = "0x97D4D0", Offset = "0x97C4D0", VA = "0x18097D4D0")]
	public bool IsAtLoadTime()
	{
		return default(bool);
	}

	// Token: 0x06001A3F RID: 6719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A3F")]
	[Address(RVA = "0x97D6B0", Offset = "0x97C6B0", VA = "0x18097D6B0")]
	public void StartCachingProcess()
	{
	}

	// Token: 0x06001A40 RID: 6720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A40")]
	[Address(RVA = "0x97DBC0", Offset = "0x97CBC0", VA = "0x18097DBC0")]
	public MeshPoolingController()
	{
	}

	// Token: 0x04001FB0 RID: 8112
	[Token(Token = "0x4001FB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int generatedRoomMeshes;

	// Token: 0x04001FB1 RID: 8113
	[Token(Token = "0x4001FB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public MeshColliderCookingOptions colliderCookingOptions;

	// Token: 0x04001FB2 RID: 8114
	[Token(Token = "0x4001FB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool bakeMeshesWithJobSystem;

	// Token: 0x04001FB3 RID: 8115
	[Token(Token = "0x4001FB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool backgroundCachingEnabled;

	// Token: 0x04001FB4 RID: 8116
	[Token(Token = "0x4001FB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int cacheRoomPerXFrames;

	// Token: 0x04001FB5 RID: 8117
	[Token(Token = "0x4001FB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int frameCounter;

	// Token: 0x04001FB6 RID: 8118
	[Token(Token = "0x4001FB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int maxCache;

	// Token: 0x04001FB7 RID: 8119
	[Token(Token = "0x4001FB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int uncachedRooms;

	// Token: 0x04001FB8 RID: 8120
	[Token(Token = "0x4001FB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<NewRoom> toCache;

	// Token: 0x04001FB9 RID: 8121
	[Token(Token = "0x4001FB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[NonSerialized]
	public List<MeshPoolingController.LoaderThread> threads;

	// Token: 0x04001FBA RID: 8122
	[Token(Token = "0x4001FBA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Dictionary<NewRoom, MeshPoolingController.RoomMeshCache> roomMeshes;

	// Token: 0x04001FBB RID: 8123
	[Token(Token = "0x4001FBB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MeshPoolingController _instance;

	// Token: 0x0200047A RID: 1146
	[Token(Token = "0x200047A")]
	[Serializable]
	public class RoomMeshCache
	{
		// Token: 0x06001A41 RID: 6721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A41")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public RoomMeshCache()
		{
		}

		// Token: 0x04001FBC RID: 8124
		[Token(Token = "0x4001FBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh floorMesh;

		// Token: 0x04001FBD RID: 8125
		[Token(Token = "0x4001FBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mesh wallMesh;

		// Token: 0x04001FBE RID: 8126
		[Token(Token = "0x4001FBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<NewBuilding, Mesh> additionalWallMesh;

		// Token: 0x04001FBF RID: 8127
		[Token(Token = "0x4001FBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Mesh ceilingMesh;

		// Token: 0x04001FC0 RID: 8128
		[Token(Token = "0x4001FC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float lastAccessed;
	}

	// Token: 0x0200047B RID: 1147
	[Token(Token = "0x200047B")]
	public class LoaderThread
	{
		// Token: 0x06001A42 RID: 6722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A42")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public LoaderThread()
		{
		}

		// Token: 0x04001FC1 RID: 8129
		[Token(Token = "0x4001FC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Coroutine thread;

		// Token: 0x04001FC2 RID: 8130
		[Token(Token = "0x4001FC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewRoom location;

		// Token: 0x04001FC3 RID: 8131
		[Token(Token = "0x4001FC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isDone;
	}

	// Token: 0x0200047C RID: 1148
	[Token(Token = "0x200047C")]
	private struct ProcessMeshDataJob : IEnumerator<object>
	{
		// Token: 0x06001A43 RID: 6723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A43")]
		[Address(RVA = "0x97DE30", Offset = "0x97CE30", VA = "0x18097DE30")]
		public void CreateInputArrays(int meshCount)
		{
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A44")]
		[Address(RVA = "0x97DF60", Offset = "0x97CF60", VA = "0x18097DF60", Slot = "4")]
		public void Execute(int index)
		{
		}

		// Token: 0x04001FC4 RID: 8132
		[Token(Token = "0x4001FC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Mesh.MeshDataArray meshData;

		// Token: 0x04001FC5 RID: 8133
		[Token(Token = "0x4001FC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh.MeshData outputMesh;

		// Token: 0x04001FC6 RID: 8134
		[Token(Token = "0x4001FC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NativeArray<int> vertexStart;

		// Token: 0x04001FC7 RID: 8135
		[Token(Token = "0x4001FC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NativeArray<int> indexStart;

		// Token: 0x04001FC8 RID: 8136
		[Token(Token = "0x4001FC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public NativeArray<float4x4> xform;

		// Token: 0x04001FC9 RID: 8137
		[Token(Token = "0x4001FC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public NativeArray<float3x2> bounds;

		// Token: 0x04001FCA RID: 8138
		[Token(Token = "0x4001FCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private NativeArray<float3> tempVertices;

		// Token: 0x04001FCB RID: 8139
		[Token(Token = "0x4001FCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private NativeArray<float3> tempNormals;

		// Token: 0x04001FCC RID: 8140
		[Token(Token = "0x4001FCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private NativeArray<float4> tempTangents;

		// Token: 0x04001FCD RID: 8141
		[Token(Token = "0x4001FCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private NativeArray<float2> tempUVs;
	}

	// Token: 0x0200047D RID: 1149
	[Token(Token = "0x200047D")]
	public struct BakeJob : IEnumerator<object>
	{
		// Token: 0x06001A45 RID: 6725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A45")]
		[Address(RVA = "0x97EB40", Offset = "0x97DB40", VA = "0x18097EB40")]
		public BakeJob(int mId)
		{
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A46")]
		[Address(RVA = "0x97EB50", Offset = "0x97DB50", VA = "0x18097EB50", Slot = "4")]
		public void Execute(int index)
		{
		}

		// Token: 0x04001FCE RID: 8142
		[Token(Token = "0x4001FCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int meshId;
	}

	// Token: 0x0200047E RID: 1150
	[Token(Token = "0x200047E")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001A48 RID: 6728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A48")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		[Token(Token = "0x6001A49")]
		[Address(RVA = "0x875850", Offset = "0x874850", VA = "0x180875850")]
		internal bool <ProcessWall>b__29_0(NewNode item)
		{
			return default(bool);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0x97EC50", Offset = "0x97DC50", VA = "0x18097EC50")]
		internal int <StartCachingProcess>b__36_0(NewRoom p2, NewRoom p1)
		{
			return 0;
		}

		// Token: 0x04001FCF RID: 8143
		[Token(Token = "0x4001FCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly MeshPoolingController.<>c <>9;

		// Token: 0x04001FD0 RID: 8144
		[Token(Token = "0x4001FD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<NewNode, bool> <>9__29_0;

		// Token: 0x04001FD1 RID: 8145
		[Token(Token = "0x4001FD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Comparison<NewRoom> <>9__36_0;
	}

	// Token: 0x0200047F RID: 1151
	[Token(Token = "0x200047F")]
	private sealed class <>c__DisplayClass34_0
	{
		// Token: 0x06001A4B RID: 6731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass34_0()
		{
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4C")]
		[Address(RVA = "0x97ECB0", Offset = "0x97DCB0", VA = "0x18097ECB0")]
		internal void <ThreadedMeshGeneration>b__0()
		{
		}

		// Token: 0x04001FD2 RID: 8146
		[Token(Token = "0x4001FD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MeshPoolingController <>4__this;

		// Token: 0x04001FD3 RID: 8147
		[Token(Token = "0x4001FD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MeshPoolingController.LoaderThread loaderReference;
	}

	// Token: 0x02000480 RID: 1152
	[Token(Token = "0x2000480")]
	private sealed class <ThreadedMeshGeneration>d__34 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001A4D RID: 6733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4D")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <ThreadedMeshGeneration>d__34(int <>1__state)
		{
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0000C600 File Offset: 0x0000A800
		[Token(Token = "0x6001A4F")]
		[Address(RVA = "0x97ED90", Offset = "0x97DD90", VA = "0x18097ED90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000CC")]
		private object Current
		{
			[Token(Token = "0x6001A50")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A51")]
		[Address(RVA = "0x97F290", Offset = "0x97E290", VA = "0x18097F290", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000CD")]
		private object Current
		{
			[Token(Token = "0x6001A52")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001FD4 RID: 8148
		[Token(Token = "0x4001FD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001FD5 RID: 8149
		[Token(Token = "0x4001FD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001FD6 RID: 8150
		[Token(Token = "0x4001FD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MeshPoolingController <>4__this;

		// Token: 0x04001FD7 RID: 8151
		[Token(Token = "0x4001FD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MeshPoolingController.LoaderThread loaderReference;

		// Token: 0x04001FD8 RID: 8152
		[Token(Token = "0x4001FD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MeshPoolingController.<>c__DisplayClass34_0 <>8__1;

		// Token: 0x04001FD9 RID: 8153
		[Token(Token = "0x4001FD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Thread <thread>5__2;
	}
}
