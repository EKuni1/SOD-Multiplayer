using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200031E RID: 798
[Token(Token = "0x200031E")]
public class GeometryCullingController : MonoBehaviour
{
	// Token: 0x1700009D RID: 157
	// (get) Token: 0x0600120B RID: 4619 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700009D")]
	public static GeometryCullingController Instance
	{
		[Token(Token = "0x600120B")]
		[Address(RVA = "0x6F0AB0", Offset = "0x6EFAB0", VA = "0x1806F0AB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600120C")]
	[Address(RVA = "0x6F0AF0", Offset = "0x6EFAF0", VA = "0x1806F0AF0")]
	private void Awake()
	{
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600120D")]
	[Address(RVA = "0x6F0E40", Offset = "0x6EFE40", VA = "0x1806F0E40")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600120E")]
	[Address(RVA = "0x6F1050", Offset = "0x6F0050", VA = "0x1806F1050")]
	public void UpdateCullingForRoom(NewRoom currentRoom, bool updateSound, bool inAirVent, AirDuctGroup currentDuct, bool immediateLoad = false)
	{
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600120F")]
	[Address(RVA = "0x6F3F10", Offset = "0x6F2F10", VA = "0x1806F3F10")]
	public void ExecuteCurrentCullingTree(bool immediateLoad)
	{
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001210")]
	[Address(RVA = "0x6F4A70", Offset = "0x6F3A70", VA = "0x1806F4A70")]
	public void GenerateDynamicCulling(NewRoom forRoom, int displayDebugLevel = 0)
	{
	}

	// Token: 0x06001211 RID: 4625 RVA: 0x00008A18 File Offset: 0x00006C18
	[Token(Token = "0x6001211")]
	[Address(RVA = "0x5221C0", Offset = "0x5211C0", VA = "0x1805221C0")]
	private bool IsRoomRenderableFromOrigin(NewRoom startingRoom, NewRoom destinationRoom, int displayDebugLevel)
	{
		return default(bool);
	}

	// Token: 0x06001212 RID: 4626 RVA: 0x00008A30 File Offset: 0x00006C30
	[Token(Token = "0x6001212")]
	[Address(RVA = "0x6F6690", Offset = "0x6F5690", VA = "0x1806F6690")]
	private bool IsRoomRenderableFromThisRoom(NewRoom adjacentRoom, NewRoom originRoom, NewRoom destinationRoom, NewNode.NodeAccess access, int displayDebugLevel)
	{
		return default(bool);
	}

	// Token: 0x06001213 RID: 4627 RVA: 0x00008A48 File Offset: 0x00006C48
	[Token(Token = "0x6001213")]
	[Address(RVA = "0x6F6CE0", Offset = "0x6F5CE0", VA = "0x1806F6CE0")]
	private bool IsAccessValid(NewRoom currentRoom, NewRoom destinationRoom, NewNode.NodeAccess access, int displayDebugLevel)
	{
		return default(bool);
	}

	// Token: 0x06001214 RID: 4628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001214")]
	[Address(RVA = "0x6F7220", Offset = "0x6F6220", VA = "0x1806F7220")]
	public void DebugDynamicCulling()
	{
	}

	// Token: 0x06001215 RID: 4629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001215")]
	[Address(RVA = "0x6F7290", Offset = "0x6F6290", VA = "0x1806F7290")]
	private void QueueDrawRay(Vector3 origin, Vector3 direction, Color colour, float duration, float delay)
	{
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001216")]
	[Address(RVA = "0x6F7370", Offset = "0x6F6370", VA = "0x1806F7370")]
	private void Update()
	{
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001217")]
	[Address(RVA = "0x6F7AC0", Offset = "0x6F6AC0", VA = "0x1806F7AC0")]
	public void OnStartGame()
	{
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001218")]
	[Address(RVA = "0x6F7B30", Offset = "0x6F6B30", VA = "0x1806F7B30")]
	public void StartCachingProcess()
	{
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x00008A60 File Offset: 0x00006C60
	[Token(Token = "0x6001219")]
	[Address(RVA = "0x6F7E80", Offset = "0x6F6E80", VA = "0x1806F7E80")]
	private bool IsBackgroundCachingAllowed()
	{
		return default(bool);
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x00008A78 File Offset: 0x00006C78
	[Token(Token = "0x600121A")]
	[Address(RVA = "0x6F7F90", Offset = "0x6F6F90", VA = "0x1806F7F90")]
	public bool IsAtLoadTime()
	{
		return default(bool);
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600121B")]
	[Address(RVA = "0x6F8170", Offset = "0x6F7170", VA = "0x1806F8170")]
	public void ProcessCullingTreeForRoom(NewRoom room)
	{
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600121C")]
	[Address(RVA = "0x6F8390", Offset = "0x6F7390", VA = "0x1806F8390")]
	public Task TaskedCullTreeGeneration(NewRoom room, bool debugMode)
	{
		return null;
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600121D")]
	[Address(RVA = "0x6F84D0", Offset = "0x6F74D0", VA = "0x1806F84D0")]
	public void GetVisibleRooms()
	{
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600121E")]
	[Address(RVA = "0x6F8580", Offset = "0x6F7580", VA = "0x1806F8580")]
	public GeometryCullingController()
	{
	}

	// Token: 0x0400166E RID: 5742
	[Token(Token = "0x400166E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float maxDistance;

	// Token: 0x0400166F RID: 5743
	[Token(Token = "0x400166F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxAngleAtMinDistance;

	// Token: 0x04001670 RID: 5744
	[Token(Token = "0x4001670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxAngleAtMaxDistance;

	// Token: 0x04001671 RID: 5745
	[Token(Token = "0x4001671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int maximumLoopCount;

	// Token: 0x04001672 RID: 5746
	[Token(Token = "0x4001672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool doorsBlockSight;

	// Token: 0x04001673 RID: 5747
	[Token(Token = "0x4001673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool backgroundCachingEnabled;

	// Token: 0x04001674 RID: 5748
	[Token(Token = "0x4001674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public HashSet<NewRoom> currentRoomsCullingTree;

	// Token: 0x04001675 RID: 5749
	[Token(Token = "0x4001675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private HashSet<NewRoom> currentRoomsCullingWithImmediateStuffLoad;

	// Token: 0x04001676 RID: 5750
	[Token(Token = "0x4001676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private HashSet<AirDuctGroup> currentDuctsCullingTree;

	// Token: 0x04001677 RID: 5751
	[Token(Token = "0x4001677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool transformSyncRequired;

	// Token: 0x04001678 RID: 5752
	[Token(Token = "0x4001678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int debugLevel;

	// Token: 0x04001679 RID: 5753
	[Token(Token = "0x4001679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool animateDrawDebugRays;

	// Token: 0x0400167A RID: 5754
	[Token(Token = "0x400167A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float rayDelay;

	// Token: 0x0400167B RID: 5755
	[Token(Token = "0x400167B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float rayTime;

	// Token: 0x0400167C RID: 5756
	[Token(Token = "0x400167C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<NewRoom> debugCurrentRoomsVisible;

	// Token: 0x0400167D RID: 5757
	[Token(Token = "0x400167D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<GeometryCullingController.DebugCullingRayCommands> debugRayCommands;

	// Token: 0x0400167E RID: 5758
	[Token(Token = "0x400167E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<NewRoom> toCalculateList;

	// Token: 0x0400167F RID: 5759
	[Token(Token = "0x400167F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int roomsCalculated;

	// Token: 0x04001680 RID: 5760
	[Token(Token = "0x4001680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool asyncCullingTreeActive;

	// Token: 0x04001681 RID: 5761
	[Token(Token = "0x4001681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GeometryCullingController _instance;

	// Token: 0x0200031F RID: 799
	[Token(Token = "0x200031F")]
	public class DebugCullingRayCommands
	{
		// Token: 0x0600121F RID: 4639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DebugCullingRayCommands()
		{
		}

		// Token: 0x04001682 RID: 5762
		[Token(Token = "0x4001682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 start;

		// Token: 0x04001683 RID: 5763
		[Token(Token = "0x4001683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 dir;

		// Token: 0x04001684 RID: 5764
		[Token(Token = "0x4001684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color color;

		// Token: 0x04001685 RID: 5765
		[Token(Token = "0x4001685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float duration;

		// Token: 0x04001686 RID: 5766
		[Token(Token = "0x4001686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float delay;
	}

	// Token: 0x02000320 RID: 800
	[Token(Token = "0x2000320")]
	public class CullingTreeData
	{
		// Token: 0x06001220 RID: 4640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001220")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public CullingTreeData()
		{
		}

		// Token: 0x04001687 RID: 5767
		[Token(Token = "0x4001687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewRoom room;

		// Token: 0x04001688 RID: 5768
		[Token(Token = "0x4001688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 initialAccessPoint;

		// Token: 0x04001689 RID: 5769
		[Token(Token = "0x4001689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 initialAccessFoward;

		// Token: 0x0400168A RID: 5770
		[Token(Token = "0x400168A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 pathPoint;

		// Token: 0x0400168B RID: 5771
		[Token(Token = "0x400168B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pathDistance;

		// Token: 0x0400168C RID: 5772
		[Token(Token = "0x400168C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int accessCount;

		// Token: 0x0400168D RID: 5773
		[Token(Token = "0x400168D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector2 angleThresholds;
	}

	// Token: 0x02000321 RID: 801
	[Token(Token = "0x2000321")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001222 RID: 4642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001222")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00008A90 File Offset: 0x00006C90
		[Token(Token = "0x6001223")]
		[Address(RVA = "0x6F8AE0", Offset = "0x6F7AE0", VA = "0x1806F8AE0")]
		internal int <GenerateDynamicCulling>b__28_0(GeometryCullingController.CullingTreeData p1, GeometryCullingController.CullingTreeData p2)
		{
			return 0;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00008AA8 File Offset: 0x00006CA8
		[Token(Token = "0x6001224")]
		[Address(RVA = "0x6F8B70", Offset = "0x6F7B70", VA = "0x1806F8B70")]
		internal int <StartCachingProcess>b__36_0(NewRoom p2, NewRoom p1)
		{
			return 0;
		}

		// Token: 0x0400168E RID: 5774
		[Token(Token = "0x400168E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly GeometryCullingController.<>c <>9;

		// Token: 0x0400168F RID: 5775
		[Token(Token = "0x400168F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<GeometryCullingController.CullingTreeData> <>9__28_0;

		// Token: 0x04001690 RID: 5776
		[Token(Token = "0x4001690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Comparison<NewRoom> <>9__36_0;
	}

	// Token: 0x02000322 RID: 802
	[Token(Token = "0x2000322")]
	[StructLayout(3)]
	private struct <ProcessCullingTreeForRoom>d__39 : IEnumerator<object>
	{
		// Token: 0x06001225 RID: 4645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001225")]
		[Address(RVA = "0x6F8BD0", Offset = "0x6F7BD0", VA = "0x1806F8BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001226")]
		[Address(RVA = "0x6F8FA0", Offset = "0x6F7FA0", VA = "0x1806F8FA0", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04001691 RID: 5777
		[Token(Token = "0x4001691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04001692 RID: 5778
		[Token(Token = "0x4001692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		// Token: 0x04001693 RID: 5779
		[Token(Token = "0x4001693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NewRoom room;

		// Token: 0x04001694 RID: 5780
		[Token(Token = "0x4001694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GeometryCullingController <>4__this;

		// Token: 0x04001695 RID: 5781
		[Token(Token = "0x4001695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter <>u__1;
	}

	// Token: 0x02000323 RID: 803
	[Token(Token = "0x2000323")]
	private sealed class <>c__DisplayClass40_0
	{
		// Token: 0x06001227 RID: 4647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001227")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass40_0()
		{
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001228")]
		[Address(RVA = "0x6F8FB0", Offset = "0x6F7FB0", VA = "0x1806F8FB0")]
		internal void <TaskedCullTreeGeneration>b__0()
		{
		}

		// Token: 0x04001696 RID: 5782
		[Token(Token = "0x4001696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewRoom room;

		// Token: 0x04001697 RID: 5783
		[Token(Token = "0x4001697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool debugMode;
	}
}
