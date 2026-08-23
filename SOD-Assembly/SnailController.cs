using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200073D RID: 1853
[Token(Token = "0x200073D")]
public class SnailController : MonoBehaviour
{
	// Token: 0x060028C5 RID: 10437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028C5")]
	[Address(RVA = "0xC52DD0", Offset = "0xC51DD0", VA = "0x180C52DD0")]
	public void SetupNewSnail(NewNode startingNode)
	{
	}

	// Token: 0x060028C6 RID: 10438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028C6")]
	[Address(RVA = "0xC53050", Offset = "0xC52050", VA = "0x180C53050")]
	public void SetupNewSnail(SnailController.SnailSaveData loadSnailPos)
	{
	}

	// Token: 0x060028C7 RID: 10439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028C7")]
	[Address(RVA = "0xC53860", Offset = "0xC52860", VA = "0x180C53860")]
	public void StartAudio()
	{
	}

	// Token: 0x060028C8 RID: 10440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028C8")]
	[Address(RVA = "0xC53A90", Offset = "0xC52A90", VA = "0x180C53A90")]
	private void OnDestroy()
	{
	}

	// Token: 0x060028C9 RID: 10441 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60028C9")]
	[Address(RVA = "0xC53C20", Offset = "0xC52C20", VA = "0x180C53C20")]
	public SnailController.SnailSaveData GetSaveData()
	{
		return null;
	}

	// Token: 0x060028CA RID: 10442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028CA")]
	[Address(RVA = "0xC53ED0", Offset = "0xC52ED0", VA = "0x180C53ED0")]
	public void UpdatePath()
	{
	}

	// Token: 0x060028CB RID: 10443 RVA: 0x0000F600 File Offset: 0x0000D800
	[Token(Token = "0x60028CB")]
	[Address(RVA = "0xC54B50", Offset = "0xC53B50", VA = "0x180C54B50")]
	private SnailController.SnailPath GenerateStuckPath()
	{
		return default(SnailController.SnailPath);
	}

	// Token: 0x060028CC RID: 10444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028CC")]
	[Address(RVA = "0xC55680", Offset = "0xC54680", VA = "0x180C55680")]
	private void Update()
	{
	}

	// Token: 0x060028CD RID: 10445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028CD")]
	[Address(RVA = "0xC56470", Offset = "0xC55470", VA = "0x180C56470")]
	public void ResolveSnailMovement()
	{
	}

	// Token: 0x060028CE RID: 10446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028CE")]
	[Address(RVA = "0xC56550", Offset = "0xC55550", VA = "0x180C56550")]
	public void MoveSnail(float movementAmount)
	{
	}

	// Token: 0x060028CF RID: 10447 RVA: 0x0000F618 File Offset: 0x0000D818
	[Token(Token = "0x60028CF")]
	[Address(RVA = "0xC584F0", Offset = "0xC574F0", VA = "0x180C584F0")]
	public Vector3 ApplyTraversalYConditions(Vector3 input, NewNode currentNode)
	{
		return default(Vector3);
	}

	// Token: 0x060028D0 RID: 10448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028D0")]
	[Address(RVA = "0xC58550", Offset = "0xC57550", VA = "0x180C58550")]
	private void PathAdvanceCheck()
	{
	}

	// Token: 0x060028D1 RID: 10449 RVA: 0x0000F630 File Offset: 0x0000D830
	[Token(Token = "0x60028D1")]
	[Address(RVA = "0xC58660", Offset = "0xC57660", VA = "0x180C58660")]
	private bool FindSurface(out RaycastHit bestHit, out bool useGroundLevelTarget, bool includeBackwardsDiagonal = false)
	{
		return default(bool);
	}

	// Token: 0x060028D2 RID: 10450 RVA: 0x0000F648 File Offset: 0x0000D848
	[Token(Token = "0x60028D2")]
	[Address(RVA = "0xC59270", Offset = "0xC58270", VA = "0x180C59270")]
	private bool IsInRenderedRoom(out NewNode currentNode)
	{
		return default(bool);
	}

	// Token: 0x060028D3 RID: 10451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028D3")]
	[Address(RVA = "0xC596A0", Offset = "0xC586A0", VA = "0x180C596A0")]
	private void SamplePositionTest()
	{
	}

	// Token: 0x060028D4 RID: 10452 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028D4")]
	[Address(RVA = "0xC59CD0", Offset = "0xC58CD0", VA = "0x180C59CD0")]
	private void AdvancePath()
	{
	}

	// Token: 0x060028D5 RID: 10453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028D5")]
	[Address(RVA = "0xC5A0D0", Offset = "0xC590D0", VA = "0x180C5A0D0")]
	public void TouchPlayerCheck()
	{
	}

	// Token: 0x060028D6 RID: 10454 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60028D6")]
	[Address(RVA = "0xC5A930", Offset = "0xC59930", VA = "0x180C5A930")]
	public List<SnailController.SnailPath> SnailCustomPathfind()
	{
		return null;
	}

	// Token: 0x060028D7 RID: 10455 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60028D7")]
	[Address(RVA = "0xC5B230", Offset = "0xC5A230", VA = "0x180C5B230")]
	public List<SnailController.SnailPath> PathfindIncludingVentSystem()
	{
		return null;
	}

	// Token: 0x060028D8 RID: 10456 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60028D8")]
	[Address(RVA = "0xC5D490", Offset = "0xC5C490", VA = "0x180C5D490")]
	private AirDuctGroup.AirVent FindClosestVentThatConnectsToPlayer()
	{
		return null;
	}

	// Token: 0x060028D9 RID: 10457 RVA: 0x0000F660 File Offset: 0x0000D860
	[Token(Token = "0x60028D9")]
	[Address(RVA = "0xC5DB20", Offset = "0xC5CB20", VA = "0x180C5DB20")]
	private bool DoesCurrentDuctConnectWithPlayer()
	{
		return default(bool);
	}

	// Token: 0x060028DA RID: 10458 RVA: 0x0000F678 File Offset: 0x0000D878
	[Token(Token = "0x60028DA")]
	[Address(RVA = "0xC5DBB0", Offset = "0xC5CBB0", VA = "0x180C5DBB0")]
	public bool TryAirDuctPathfind(AirDuctGroup.AirDuctSection origin, AirDuctGroup.AirDuctSection destination, bool findNearestExitInstead, out List<AirDuctGroup.AirDuctSection> ret)
	{
		return default(bool);
	}

	// Token: 0x060028DB RID: 10459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028DB")]
	[Address(RVA = "0xC5E280", Offset = "0xC5D280", VA = "0x180C5E280")]
	public void SetInAirDuct(bool isIn, AirDuctGroup.AirDuctSection setToSection)
	{
	}

	// Token: 0x060028DC RID: 10460 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60028DC")]
	[Address(RVA = "0xC5E420", Offset = "0xC5D420", VA = "0x180C5E420")]
	public NewNode GetCurrentNodePos()
	{
		return null;
	}

	// Token: 0x060028DD RID: 10461 RVA: 0x0000F690 File Offset: 0x0000D890
	[Token(Token = "0x60028DD")]
	[Address(RVA = "0xC5EAE0", Offset = "0xC5DAE0", VA = "0x180C5EAE0")]
	public Vector3 GetGroundLevelPlayerPosition()
	{
		return default(Vector3);
	}

	// Token: 0x060028DE RID: 10462 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60028DE")]
	[Address(RVA = "0xC5ECD0", Offset = "0xC5DCD0", VA = "0x180C5ECD0")]
	public List<SnailController.SnailPath> GetSameRoomPathingRoute()
	{
		return null;
	}

	// Token: 0x060028DF RID: 10463 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60028DF")]
	[Address(RVA = "0xC5FC40", Offset = "0xC5EC40", VA = "0x180C5FC40")]
	private List<SnailController.SnailPath> TrimPath(List<SnailController.SnailPath> input)
	{
		return null;
	}

	// Token: 0x060028E0 RID: 10464 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
	[Token(Token = "0x60028E0")]
	[Address(RVA = "0xC5FF60", Offset = "0xC5EF60", VA = "0x180C5FF60")]
	private bool SnailRaycast(Vector3 origin, Vector3 direction, out RaycastHit hit, float range, int layerMask)
	{
		return default(bool);
	}

	// Token: 0x060028E1 RID: 10465 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028E1")]
	[Address(RVA = "0xC60860", Offset = "0xC5F860", VA = "0x180C60860")]
	public void GenerateCurrentRoomPointCloud()
	{
	}

	// Token: 0x060028E2 RID: 10466 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028E2")]
	[Address(RVA = "0xC625D0", Offset = "0xC615D0", VA = "0x180C625D0")]
	private void AddPlayerLocationPoints(int count)
	{
	}

	// Token: 0x060028E3 RID: 10467 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
	[Token(Token = "0x60028E3")]
	[Address(RVA = "0xC638D0", Offset = "0xC628D0", VA = "0x180C638D0")]
	private Vector3 GetClosestPlayerCloudPoint()
	{
		return default(Vector3);
	}

	// Token: 0x060028E4 RID: 10468 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
	[Token(Token = "0x60028E4")]
	[Address(RVA = "0xC63CA0", Offset = "0xC62CA0", VA = "0x180C63CA0")]
	public bool GetRouteFromPointCloud(out List<SnailController.SnailPath> ret)
	{
		return default(bool);
	}

	// Token: 0x060028E5 RID: 10469 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
	[Token(Token = "0x60028E5")]
	[Address(RVA = "0xC64E30", Offset = "0xC63E30", VA = "0x180C64E30")]
	private float GetCeilingHeight(NewNode forNode)
	{
		return 0f;
	}

	// Token: 0x060028E6 RID: 10470 RVA: 0x0000F708 File Offset: 0x0000D908
	[Token(Token = "0x60028E6")]
	[Address(RVA = "0xC64FA0", Offset = "0xC63FA0", VA = "0x180C64FA0")]
	private Vector3 GetRoundedVector3(Vector3 v3)
	{
		return default(Vector3);
	}

	// Token: 0x060028E7 RID: 10471 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028E7")]
	[Address(RVA = "0xC65100", Offset = "0xC64100", VA = "0x180C65100")]
	public SnailController()
	{
	}

	// Token: 0x040033C7 RID: 13255
	[Token(Token = "0x40033C7")]
	[FieldOffset(Offset = "0x18")]
	public bool inAirVent;

	// Token: 0x040033C8 RID: 13256
	[Token(Token = "0x40033C8")]
	[FieldOffset(Offset = "0x20")]
	public AirDuctGroup currentAirDuctGroup;

	// Token: 0x040033C9 RID: 13257
	[Token(Token = "0x40033C9")]
	[FieldOffset(Offset = "0x28")]
	public AirDuctGroup.AirDuctSection currentAirDuctSection;

	// Token: 0x040033CA RID: 13258
	[Token(Token = "0x40033CA")]
	[FieldOffset(Offset = "0x30")]
	public int snailLayerMask;

	// Token: 0x040033CB RID: 13259
	[Token(Token = "0x40033CB")]
	[FieldOffset(Offset = "0x34")]
	public int pointCloudLayerMask;

	// Token: 0x040033CC RID: 13260
	[Token(Token = "0x40033CC")]
	[FieldOffset(Offset = "0x38")]
	private AudioController.LoopingSoundInfo audioLoop;

	// Token: 0x040033CD RID: 13261
	[Token(Token = "0x40033CD")]
	[FieldOffset(Offset = "0x40")]
	public GameObject snailSlimePrefab;

	// Token: 0x040033CE RID: 13262
	[Token(Token = "0x40033CE")]
	[FieldOffset(Offset = "0x48")]
	public float slimeTimer;

	// Token: 0x040033CF RID: 13263
	[Token(Token = "0x40033CF")]
	[FieldOffset(Offset = "0x50")]
	public List<SnailController.SnailPath> currentPath;

	// Token: 0x040033D0 RID: 13264
	[Token(Token = "0x40033D0")]
	[FieldOffset(Offset = "0x58")]
	public int pathCursor;

	// Token: 0x040033D1 RID: 13265
	[Token(Token = "0x40033D1")]
	[FieldOffset(Offset = "0x60")]
	private NewNode lastRouteWhenPlayerWasAt;

	// Token: 0x040033D2 RID: 13266
	[Token(Token = "0x40033D2")]
	[FieldOffset(Offset = "0x68")]
	public float closePathUpdateTimer;

	// Token: 0x040033D3 RID: 13267
	[Token(Token = "0x40033D3")]
	[FieldOffset(Offset = "0x6C")]
	public float distancePathUpdateTimer;

	// Token: 0x040033D4 RID: 13268
	[Token(Token = "0x40033D4")]
	[FieldOffset(Offset = "0x70")]
	private float playerXZDistance;

	// Token: 0x040033D5 RID: 13269
	[Token(Token = "0x40033D5")]
	[FieldOffset(Offset = "0x74")]
	private float movementAmount;

	// Token: 0x040033D6 RID: 13270
	[Token(Token = "0x40033D6")]
	[FieldOffset(Offset = "0x78")]
	public float surfaceOffset;

	// Token: 0x040033D7 RID: 13271
	[Token(Token = "0x40033D7")]
	[FieldOffset(Offset = "0x7C")]
	public Vector3 surfaceNormal;

	// Token: 0x040033D8 RID: 13272
	[Token(Token = "0x40033D8")]
	[FieldOffset(Offset = "0x88")]
	public float probeRange;

	// Token: 0x040033D9 RID: 13273
	[Token(Token = "0x40033D9")]
	[FieldOffset(Offset = "0x8C")]
	public float faceDirectionSpeed;

	// Token: 0x040033DA RID: 13274
	[Token(Token = "0x40033DA")]
	[FieldOffset(Offset = "0x90")]
	public float psuedoGravity;

	// Token: 0x040033DB RID: 13275
	[Token(Token = "0x40033DB")]
	[FieldOffset(Offset = "0x94")]
	public float snailSpeed;

	// Token: 0x040033DC RID: 13276
	[Token(Token = "0x40033DC")]
	[FieldOffset(Offset = "0x98")]
	public Vector3 currentDestination;

	// Token: 0x040033DD RID: 13277
	[Token(Token = "0x40033DD")]
	[FieldOffset(Offset = "0xA4")]
	public float stopDistance;

	// Token: 0x040033DE RID: 13278
	[Token(Token = "0x40033DE")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<Vector3, List<Vector3>> points;

	// Token: 0x040033DF RID: 13279
	[Token(Token = "0x40033DF")]
	[FieldOffset(Offset = "0xB0")]
	public NewRoom pointsGeneratedForRoom;

	// Token: 0x040033E0 RID: 13280
	[Token(Token = "0x40033E0")]
	[FieldOffset(Offset = "0xB8")]
	public Vector3 lastPointCloudPathNodeReached;

	// Token: 0x040033E1 RID: 13281
	[Token(Token = "0x40033E1")]
	[FieldOffset(Offset = "0xC4")]
	public Vector3 closestPlayerCloudPoint;

	// Token: 0x040033E2 RID: 13282
	[Token(Token = "0x40033E2")]
	[FieldOffset(Offset = "0xD0")]
	public float sampleTimer;

	// Token: 0x040033E3 RID: 13283
	[Token(Token = "0x40033E3")]
	[FieldOffset(Offset = "0xD8")]
	private List<Vector3> samplePositions;

	// Token: 0x040033E4 RID: 13284
	[Token(Token = "0x40033E4")]
	[FieldOffset(Offset = "0xE0")]
	public float snailUnstuckTimer;

	// Token: 0x040033E5 RID: 13285
	[Token(Token = "0x40033E5")]
	[FieldOffset(Offset = "0xE4")]
	public Vector3 currentNormal;

	// Token: 0x040033E6 RID: 13286
	[Token(Token = "0x40033E6")]
	[FieldOffset(Offset = "0xF0")]
	public float upAlignSpeed;

	// Token: 0x040033E7 RID: 13287
	[Token(Token = "0x40033E7")]
	[FieldOffset(Offset = "0xF4")]
	public float forwardTurnSpeed;

	// Token: 0x0200073E RID: 1854
	[Token(Token = "0x200073E")]
	[Serializable]
	public class SnailSaveData
	{
		// Token: 0x060028E8 RID: 10472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public SnailSaveData()
		{
		}

		// Token: 0x040033E8 RID: 13288
		[Token(Token = "0x40033E8")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 pos;

		// Token: 0x040033E9 RID: 13289
		[Token(Token = "0x40033E9")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion rot;

		// Token: 0x040033EA RID: 13290
		[Token(Token = "0x40033EA")]
		[FieldOffset(Offset = "0x2C")]
		public bool inAirVent;

		// Token: 0x040033EB RID: 13291
		[Token(Token = "0x40033EB")]
		[FieldOffset(Offset = "0x30")]
		public int duct;
	}

	// Token: 0x0200073F RID: 1855
	[Token(Token = "0x200073F")]
	[Serializable]
	public struct SnailSearchVector
	{
		// Token: 0x040033EC RID: 13292
		[Token(Token = "0x40033EC")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 startPoint;

		// Token: 0x040033ED RID: 13293
		[Token(Token = "0x40033ED")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 forwards;

		// Token: 0x040033EE RID: 13294
		[Token(Token = "0x40033EE")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 up;

		// Token: 0x040033EF RID: 13295
		[Token(Token = "0x40033EF")]
		[FieldOffset(Offset = "0x28")]
		public List<Vector3> previousPoints;
	}

	// Token: 0x02000740 RID: 1856
	[Token(Token = "0x2000740")]
	[Serializable]
	public struct SnailPath
	{
		// Token: 0x060028E9 RID: 10473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028E9")]
		[Address(RVA = "0xC65470", Offset = "0xC64470", VA = "0x180C65470")]
		public SnailPath(Vector3 newPos)
		{
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028EA")]
		[Address(RVA = "0xC654E0", Offset = "0xC644E0", VA = "0x180C654E0")]
		public SnailPath(Vector3 newPos, AirDuctGroup.AirDuctSection newDuct)
		{
		}

		// Token: 0x040033F0 RID: 13296
		[Token(Token = "0x40033F0")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 pos;

		// Token: 0x040033F1 RID: 13297
		[Token(Token = "0x40033F1")]
		[FieldOffset(Offset = "0xC")]
		public bool vent;

		// Token: 0x040033F2 RID: 13298
		[Token(Token = "0x40033F2")]
		[FieldOffset(Offset = "0x10")]
		public AirDuctGroup.AirDuctSection duct;
	}

	// Token: 0x02000741 RID: 1857
	[Token(Token = "0x2000741")]
	private sealed class <>c__DisplayClass37_0
	{
		// Token: 0x060028EB RID: 10475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028EB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass37_0()
		{
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x0000F720 File Offset: 0x0000D920
		[Token(Token = "0x60028EC")]
		[Address(RVA = "0x51ECF0", Offset = "0x51DCF0", VA = "0x18051ECF0")]
		internal bool <SetupNewSnail>b__0(AirDuctGroup item)
		{
			return default(bool);
		}

		// Token: 0x040033F3 RID: 13299
		[Token(Token = "0x40033F3")]
		[FieldOffset(Offset = "0x10")]
		public SnailController.SnailSaveData loadSnailPos;
	}
}
