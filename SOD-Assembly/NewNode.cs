using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003DA RID: 986
[Token(Token = "0x20003DA")]
public class NewNode
{
	// Token: 0x0600161A RID: 5658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600161A")]
	[Address(RVA = "0x863670", Offset = "0x862670", VA = "0x180863670")]
	public void Setup(NewTile newTile, NewGameLocation newGameLoc, Vector2Int newLocalCoord)
	{
	}

	// Token: 0x0600161B RID: 5659 RVA: 0x0000A470 File Offset: 0x00008670
	[Token(Token = "0x600161B")]
	[Address(RVA = "0x864560", Offset = "0x863560", VA = "0x180864560")]
	public Vector3 TransformPoint(Vector3 localPos)
	{
		return default(Vector3);
	}

	// Token: 0x0600161C RID: 5660 RVA: 0x0000A488 File Offset: 0x00008688
	[Token(Token = "0x600161C")]
	[Address(RVA = "0x8645B0", Offset = "0x8635B0", VA = "0x1808645B0")]
	public Vector3 InverseTransformPoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600161D")]
	[Address(RVA = "0x864600", Offset = "0x863600", VA = "0x180864600")]
	public void Load(CitySaveData.NodeCitySave data, NewRoom newRoom)
	{
	}

	// Token: 0x0600161E RID: 5662 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600161E")]
	[Address(RVA = "0x864A40", Offset = "0x863A40", VA = "0x180864A40")]
	public void AddNewWall(NewWall newWall)
	{
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600161F")]
	[Address(RVA = "0x864C40", Offset = "0x863C40", VA = "0x180864C40")]
	public void RemoveWall(NewWall newWall)
	{
	}

	// Token: 0x06001620 RID: 5664 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001620")]
	[Address(RVA = "0x864D90", Offset = "0x863D90", VA = "0x180864D90")]
	public void SpawnFloor(bool prepForCombinedMeshes)
	{
	}

	// Token: 0x06001621 RID: 5665 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001621")]
	[Address(RVA = "0x865C50", Offset = "0x864C50", VA = "0x180865C50")]
	public void SpawnCeiling(bool prepForCombinedMeshes)
	{
	}

	// Token: 0x06001622 RID: 5666 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001622")]
	[Address(RVA = "0x866B40", Offset = "0x865B40", VA = "0x180866B40")]
	public void SetFloorType(NewNode.FloorTileType newType)
	{
	}

	// Token: 0x06001623 RID: 5667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001623")]
	[Address(RVA = "0x867020", Offset = "0x866020", VA = "0x180867020")]
	public void SetAsObstacle(bool val)
	{
	}

	// Token: 0x06001624 RID: 5668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001624")]
	[Address(RVA = "0x867030", Offset = "0x866030", VA = "0x180867030")]
	public void SetAsOutside(bool val)
	{
	}

	// Token: 0x06001625 RID: 5669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001625")]
	[Address(RVA = "0x867040", Offset = "0x866040", VA = "0x180867040")]
	public void AddAccessToOtherNode(NewNode newNode, bool twoWay = true, bool forceAccessType = false, NewNode.NodeAccess.AccessType forcedAccessType = NewNode.NodeAccess.AccessType.adjacent, bool forceWalkable = false)
	{
	}

	// Token: 0x06001626 RID: 5670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001626")]
	[Address(RVA = "0x8679F0", Offset = "0x8669F0", VA = "0x1808679F0")]
	public void RemoveAccessToOtherNode(NewNode newNode, bool twoWay = true)
	{
	}

	// Token: 0x06001627 RID: 5671 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001627")]
	[Address(RVA = "0x5BB450", Offset = "0x5BA450", VA = "0x1805BB450")]
	public void SetForcedRoom(RoomConfiguration newRoom)
	{
	}

	// Token: 0x06001628 RID: 5672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001628")]
	[Address(RVA = "0x868200", Offset = "0x867200", VA = "0x180868200")]
	public void AddInteractable(Interactable newInteractable)
	{
	}

	// Token: 0x06001629 RID: 5673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001629")]
	[Address(RVA = "0x8690C0", Offset = "0x8680C0", VA = "0x1808690C0")]
	public void RemoveInteractable(Interactable newInteractable)
	{
	}

	// Token: 0x0600162A RID: 5674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600162A")]
	[Address(RVA = "0x8698C0", Offset = "0x8688C0", VA = "0x1808698C0")]
	public void DebugTeleportPlayerToLocation()
	{
	}

	// Token: 0x0600162B RID: 5675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600162B")]
	[Address(RVA = "0x869940", Offset = "0x868940", VA = "0x180869940")]
	public void SetFloorHeight(int val, bool setTest = true)
	{
	}

	// Token: 0x0600162C RID: 5676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600162C")]
	[Address(RVA = "0x86A4D0", Offset = "0x8694D0", VA = "0x18086A4D0")]
	public void AddFurniture(FurnitureLocation newFurn)
	{
	}

	// Token: 0x0600162D RID: 5677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600162D")]
	[Address(RVA = "0x86A640", Offset = "0x869640", VA = "0x18086A640")]
	public void ResetFurniture()
	{
	}

	// Token: 0x0600162E RID: 5678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600162E")]
	[Address(RVA = "0x861910", Offset = "0x860910", VA = "0x180861910")]
	public void SetAllowNewFurniture(bool val)
	{
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600162F")]
	[Address(RVA = "0x86A710", Offset = "0x869710", VA = "0x18086A710")]
	public void AddToNodeWeightMultiplier(float val)
	{
	}

	// Token: 0x06001630 RID: 5680 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001630")]
	[Address(RVA = "0x86A730", Offset = "0x869730", VA = "0x18086A730")]
	public CitySaveData.NodeCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x06001631 RID: 5681 RVA: 0x0000A4A0 File Offset: 0x000086A0
	[Token(Token = "0x6001631")]
	[Address(RVA = "0x86AB20", Offset = "0x869B20", VA = "0x18086AB20")]
	public bool AddHumanTraveller(Actor newActor, Interactable.UsagePoint usagePoint, out Vector3 usePosition, bool useRandomNodeSublocation = false)
	{
		return default(bool);
	}

	// Token: 0x06001632 RID: 5682 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001632")]
	[Address(RVA = "0x86C470", Offset = "0x86B470", VA = "0x18086C470")]
	public void UpdateWalkableSublocations()
	{
	}

	// Token: 0x06001633 RID: 5683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001633")]
	[Address(RVA = "0x86CD70", Offset = "0x86BD70", VA = "0x18086CD70")]
	public void ClearTravellers()
	{
	}

	// Token: 0x06001634 RID: 5684 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001634")]
	[Address(RVA = "0x86CF30", Offset = "0x86BF30", VA = "0x18086CF30")]
	public void SetAsAudioSource(AudioEvent newEvent, Vector3 newOffset)
	{
	}

	// Token: 0x06001635 RID: 5685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001635")]
	[Address(RVA = "0x86D1C0", Offset = "0x86C1C0", VA = "0x18086D1C0")]
	public void SetCeilingVent(bool val)
	{
	}

	// Token: 0x06001636 RID: 5686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001636")]
	[Address(RVA = "0x86D410", Offset = "0x86C410", VA = "0x18086D410")]
	public void SetFloorVent(bool val)
	{
	}

	// Token: 0x06001637 RID: 5687 RVA: 0x0000A4B8 File Offset: 0x000086B8
	[Token(Token = "0x6001637")]
	[Address(RVA = "0x86D660", Offset = "0x86C660", VA = "0x18086D660")]
	public bool HasValidFloor()
	{
		return default(bool);
	}

	// Token: 0x06001638 RID: 5688 RVA: 0x0000A4D0 File Offset: 0x000086D0
	[Token(Token = "0x6001638")]
	[Address(RVA = "0x86D690", Offset = "0x86C690", VA = "0x18086D690")]
	public bool HasValidCeiling()
	{
		return default(bool);
	}

	// Token: 0x06001639 RID: 5689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001639")]
	[Address(RVA = "0x86D6C0", Offset = "0x86C6C0", VA = "0x18086D6C0")]
	public NewNode()
	{
	}

	// Token: 0x04001AAC RID: 6828
	[Token(Token = "0x4001AAC")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	// Token: 0x04001AAD RID: 6829
	[Token(Token = "0x4001AAD")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 position;

	// Token: 0x04001AAE RID: 6830
	[Token(Token = "0x4001AAE")]
	[FieldOffset(Offset = "0x28")]
	public GameObject physicalObject;

	// Token: 0x04001AAF RID: 6831
	[Token(Token = "0x4001AAF")]
	[FieldOffset(Offset = "0x30")]
	public NewBuilding building;

	// Token: 0x04001AB0 RID: 6832
	[Token(Token = "0x4001AB0")]
	[FieldOffset(Offset = "0x38")]
	public NewFloor floor;

	// Token: 0x04001AB1 RID: 6833
	[Token(Token = "0x4001AB1")]
	[FieldOffset(Offset = "0x40")]
	public NewGameLocation gameLocation;

	// Token: 0x04001AB2 RID: 6834
	[Token(Token = "0x4001AB2")]
	[FieldOffset(Offset = "0x48")]
	public NewRoom room;

	// Token: 0x04001AB3 RID: 6835
	[Token(Token = "0x4001AB3")]
	[FieldOffset(Offset = "0x50")]
	public NewTile tile;

	// Token: 0x04001AB4 RID: 6836
	[Token(Token = "0x4001AB4")]
	[FieldOffset(Offset = "0x58")]
	public Vector2Int floorCoord;

	// Token: 0x04001AB5 RID: 6837
	[Token(Token = "0x4001AB5")]
	[FieldOffset(Offset = "0x60")]
	public Vector2Int localTileCoord;

	// Token: 0x04001AB6 RID: 6838
	[Token(Token = "0x4001AB6")]
	[FieldOffset(Offset = "0x68")]
	public Vector3Int nodeCoord;

	// Token: 0x04001AB7 RID: 6839
	[Token(Token = "0x4001AB7")]
	[FieldOffset(Offset = "0x78")]
	public List<NewWall> walls;

	// Token: 0x04001AB8 RID: 6840
	[Token(Token = "0x4001AB8")]
	[FieldOffset(Offset = "0x80")]
	public Dictionary<Vector2, NewWall> wallDict;

	// Token: 0x04001AB9 RID: 6841
	[Token(Token = "0x4001AB9")]
	[FieldOffset(Offset = "0x88")]
	public int floorHeight;

	// Token: 0x04001ABA RID: 6842
	[Token(Token = "0x4001ABA")]
	[FieldOffset(Offset = "0x8C")]
	public NewNode.FloorTileType floorType;

	// Token: 0x04001ABB RID: 6843
	[Token(Token = "0x4001ABB")]
	[FieldOffset(Offset = "0x90")]
	public List<Vector2> preventEntrances;

	// Token: 0x04001ABC RID: 6844
	[Token(Token = "0x4001ABC")]
	[FieldOffset(Offset = "0x98")]
	public GameObject floorPrefab;

	// Token: 0x04001ABD RID: 6845
	[Token(Token = "0x4001ABD")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject spawnedFloor;

	// Token: 0x04001ABE RID: 6846
	[Token(Token = "0x4001ABE")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject ceilingPrefab;

	// Token: 0x04001ABF RID: 6847
	[Token(Token = "0x4001ABF")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject spawnedCeiling;

	// Token: 0x04001AC0 RID: 6848
	[Token(Token = "0x4001AC0")]
	[FieldOffset(Offset = "0xB8")]
	public float nodeWeightMultiplier;

	// Token: 0x04001AC1 RID: 6849
	[Token(Token = "0x4001AC1")]
	[FieldOffset(Offset = "0xBC")]
	public bool isObstacle;

	// Token: 0x04001AC2 RID: 6850
	[Token(Token = "0x4001AC2")]
	[FieldOffset(Offset = "0xBD")]
	public bool isOutside;

	// Token: 0x04001AC3 RID: 6851
	[Token(Token = "0x4001AC3")]
	[FieldOffset(Offset = "0xBE")]
	public bool isConnected;

	// Token: 0x04001AC4 RID: 6852
	[Token(Token = "0x4001AC4")]
	[FieldOffset(Offset = "0xBF")]
	public bool stairwellLowerLink;

	// Token: 0x04001AC5 RID: 6853
	[Token(Token = "0x4001AC5")]
	[FieldOffset(Offset = "0xC0")]
	public bool stairwellUpperLink;

	// Token: 0x04001AC6 RID: 6854
	[Token(Token = "0x4001AC6")]
	[FieldOffset(Offset = "0xC1")]
	public bool isInaccessable;

	// Token: 0x04001AC7 RID: 6855
	[Token(Token = "0x4001AC7")]
	[FieldOffset(Offset = "0xC2")]
	public bool isIndoorsEntrance;

	// Token: 0x04001AC8 RID: 6856
	[Token(Token = "0x4001AC8")]
	[FieldOffset(Offset = "0xC3")]
	public bool ceilingAirVent;

	// Token: 0x04001AC9 RID: 6857
	[Token(Token = "0x4001AC9")]
	[FieldOffset(Offset = "0xC4")]
	public bool floorAirVent;

	// Token: 0x04001ACA RID: 6858
	[Token(Token = "0x4001ACA")]
	[FieldOffset(Offset = "0xC5")]
	public bool noPassThrough;

	// Token: 0x04001ACB RID: 6859
	[Token(Token = "0x4001ACB")]
	[FieldOffset(Offset = "0xC6")]
	public bool noAccess;

	// Token: 0x04001ACC RID: 6860
	[Token(Token = "0x4001ACC")]
	[FieldOffset(Offset = "0xC8")]
	[NonSerialized]
	public RoomConfiguration forcedRoom;

	// Token: 0x04001ACD RID: 6861
	[Token(Token = "0x4001ACD")]
	[FieldOffset(Offset = "0xD0")]
	public string forcedRoomRef;

	// Token: 0x04001ACE RID: 6862
	[Token(Token = "0x4001ACE")]
	[FieldOffset(Offset = "0xD8")]
	public NewNode.NodeSpace defaultSpace;

	// Token: 0x04001ACF RID: 6863
	[Token(Token = "0x4001ACF")]
	[FieldOffset(Offset = "0xE0")]
	public Dictionary<Vector3, NewNode.NodeSpace> walkableNodeSpace;

	// Token: 0x04001AD0 RID: 6864
	[Token(Token = "0x4001AD0")]
	[FieldOffset(Offset = "0xE8")]
	public HashSet<NewNode.NodeSpace> occupiedSpace;

	// Token: 0x04001AD1 RID: 6865
	[Token(Token = "0x4001AD1")]
	[FieldOffset(Offset = "0xF0")]
	public bool detectGeometry;

	// Token: 0x04001AD2 RID: 6866
	[Token(Token = "0x4001AD2")]
	[FieldOffset(Offset = "0xF1")]
	public bool allowNewFurniture;

	// Token: 0x04001AD3 RID: 6867
	[Token(Token = "0x4001AD3")]
	[FieldOffset(Offset = "0xF8")]
	public List<FurnitureLocation> individualFurniture;

	// Token: 0x04001AD4 RID: 6868
	[Token(Token = "0x4001AD4")]
	[FieldOffset(Offset = "0x100")]
	public List<Interactable> interactables;

	// Token: 0x04001AD5 RID: 6869
	[Token(Token = "0x4001AD5")]
	[FieldOffset(Offset = "0x108")]
	public List<AirDuctGroup.AirDuctSection> airDucts;

	// Token: 0x04001AD6 RID: 6870
	[Token(Token = "0x4001AD6")]
	[FieldOffset(Offset = "0x110")]
	public AudioEvent audioEvent;

	// Token: 0x04001AD7 RID: 6871
	[Token(Token = "0x4001AD7")]
	[FieldOffset(Offset = "0x118")]
	public AudioController.LoopingSoundInfo loop;

	// Token: 0x04001AD8 RID: 6872
	[Token(Token = "0x4001AD8")]
	[FieldOffset(Offset = "0x120")]
	public Vector3 audioOffset;

	// Token: 0x04001AD9 RID: 6873
	[Token(Token = "0x4001AD9")]
	[FieldOffset(Offset = "0x130")]
	public Dictionary<NewNode, NewNode.NodeAccess> accessToOtherNodes;

	// Token: 0x020003DB RID: 987
	[Token(Token = "0x20003DB")]
	public enum FloorTileType
	{
		// Token: 0x04001ADB RID: 6875
		[Token(Token = "0x4001ADB")]
		none,
		// Token: 0x04001ADC RID: 6876
		[Token(Token = "0x4001ADC")]
		floorAndCeiling,
		// Token: 0x04001ADD RID: 6877
		[Token(Token = "0x4001ADD")]
		floorOnly,
		// Token: 0x04001ADE RID: 6878
		[Token(Token = "0x4001ADE")]
		CeilingOnly,
		// Token: 0x04001ADF RID: 6879
		[Token(Token = "0x4001ADF")]
		noneButIndoors
	}

	// Token: 0x020003DC RID: 988
	[Token(Token = "0x20003DC")]
	public class NodeSpace
	{
		// Token: 0x0600163A RID: 5690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163A")]
		[Address(RVA = "0x86DCA0", Offset = "0x86CCA0", VA = "0x18086DCA0")]
		public void SetEmpty()
		{
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163B")]
		[Address(RVA = "0x86DDA0", Offset = "0x86CDA0", VA = "0x18086DDA0")]
		public void SetOccuppier(Actor newOcc, NewNode.NodeSpaceOccupancy occType)
		{
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public NodeSpace()
		{
		}

		// Token: 0x04001AE0 RID: 6880
		[Token(Token = "0x4001AE0")]
		[FieldOffset(Offset = "0x10")]
		public NewNode node;

		// Token: 0x04001AE1 RID: 6881
		[Token(Token = "0x4001AE1")]
		[FieldOffset(Offset = "0x18")]
		public NewNode.NodeSpaceOccupancy occ;

		// Token: 0x04001AE2 RID: 6882
		[Token(Token = "0x4001AE2")]
		[FieldOffset(Offset = "0x20")]
		public Actor occupier;

		// Token: 0x04001AE3 RID: 6883
		[Token(Token = "0x4001AE3")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 position;
	}

	// Token: 0x020003DD RID: 989
	[Token(Token = "0x20003DD")]
	public enum NodeSpaceOccupancy
	{
		// Token: 0x04001AE5 RID: 6885
		[Token(Token = "0x4001AE5")]
		empty,
		// Token: 0x04001AE6 RID: 6886
		[Token(Token = "0x4001AE6")]
		position,
		// Token: 0x04001AE7 RID: 6887
		[Token(Token = "0x4001AE7")]
		reserved
	}

	// Token: 0x020003DE RID: 990
	[Token(Token = "0x20003DE")]
	[Serializable]
	public class NodeAccess : IEnumerator<object>
	{
		// Token: 0x0600163D RID: 5693 RVA: 0x0000A4E8 File Offset: 0x000086E8
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x82AE60", Offset = "0x829E60", VA = "0x18082AE60", Slot = "4")]
		private bool Equals(NewNode.NodeAccess other)
		{
			return default(bool);
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x0000A500 File Offset: 0x00008700
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x86E110", Offset = "0x86D110", VA = "0x18086E110", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x86E310", Offset = "0x86D310", VA = "0x18086E310")]
		public NodeAccess(NewNode newFrom, NewNode newTo, NewWall newWall, NewDoor newDoorway, bool forceAccessType = false, NewNode.NodeAccess.AccessType forcedAccessType = NewNode.NodeAccess.AccessType.adjacent, bool forceWalkable = false)
		{
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x86FC70", Offset = "0x86EC70", VA = "0x18086FC70")]
		public NewNode GetOther(NewNode fromThis)
		{
			return null;
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x86FC80", Offset = "0x86EC80", VA = "0x18086FC80")]
		public NewRoom GetOtherRoom(NewRoom fromThis)
		{
			return null;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001642")]
		[Address(RVA = "0x86FE30", Offset = "0x86EE30", VA = "0x18086FE30")]
		public NewRoom GetOtherRoom(NewGameLocation fromThis)
		{
			return null;
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001643")]
		[Address(RVA = "0x86FFE0", Offset = "0x86EFE0", VA = "0x18086FFE0")]
		public NewNode GetOtherGameLocation(NewNode fromThis)
		{
			return null;
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001644")]
		[Address(RVA = "0x8705A0", Offset = "0x86F5A0", VA = "0x1808705A0")]
		public NewGameLocation GetOtherGameLocation(NewGameLocation fromThis)
		{
			return null;
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x870AD0", Offset = "0x86FAD0", VA = "0x180870AD0")]
		public void PreComputeEntranceWeights()
		{
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x871600", Offset = "0x870600", VA = "0x180871600")]
		public void GetEntranceSidePoints(out Vector3 leftSide, out Vector3 rightSide)
		{
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x8716B0", Offset = "0x8706B0", VA = "0x1808716B0")]
		public void UpdateWorldAccessPoint()
		{
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0000A518 File Offset: 0x00008718
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x871720", Offset = "0x870720", VA = "0x180871720")]
		private bool <PreComputeEntranceWeights>b__25_0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x0000A530 File Offset: 0x00008730
		[Token(Token = "0x6001649")]
		[Address(RVA = "0x871720", Offset = "0x870720", VA = "0x180871720")]
		private bool <PreComputeEntranceWeights>b__25_1(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x04001AE8 RID: 6888
		[Token(Token = "0x4001AE8")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04001AE9 RID: 6889
		[Token(Token = "0x4001AE9")]
		[FieldOffset(Offset = "0x18")]
		public int id;

		// Token: 0x04001AEA RID: 6890
		[Token(Token = "0x4001AEA")]
		[FieldOffset(Offset = "0x0")]
		public static int assignId;

		// Token: 0x04001AEB RID: 6891
		[Token(Token = "0x4001AEB")]
		[FieldOffset(Offset = "0x1C")]
		public float weight;

		// Token: 0x04001AEC RID: 6892
		[Token(Token = "0x4001AEC")]
		[FieldOffset(Offset = "0x20")]
		public NewDoor door;

		// Token: 0x04001AED RID: 6893
		[Token(Token = "0x4001AED")]
		[FieldOffset(Offset = "0x28")]
		public NewWall wall;

		// Token: 0x04001AEE RID: 6894
		[Token(Token = "0x4001AEE")]
		[FieldOffset(Offset = "0x30")]
		public NewNode.NodeAccess.AccessType accessType;

		// Token: 0x04001AEF RID: 6895
		[Token(Token = "0x4001AEF")]
		[FieldOffset(Offset = "0x38")]
		public NewNode fromNode;

		// Token: 0x04001AF0 RID: 6896
		[Token(Token = "0x4001AF0")]
		[FieldOffset(Offset = "0x40")]
		public NewNode toNode;

		// Token: 0x04001AF1 RID: 6897
		[Token(Token = "0x4001AF1")]
		[FieldOffset(Offset = "0x48")]
		public bool walkingAccess;

		// Token: 0x04001AF2 RID: 6898
		[Token(Token = "0x4001AF2")]
		[FieldOffset(Offset = "0x49")]
		public bool employeeDoor;

		// Token: 0x04001AF3 RID: 6899
		[Token(Token = "0x4001AF3")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 worldAccessPoint;

		// Token: 0x04001AF4 RID: 6900
		[Token(Token = "0x4001AF4")]
		[FieldOffset(Offset = "0x58")]
		public NewNode.NodeAccess oppositeAccess;

		// Token: 0x04001AF5 RID: 6901
		[Token(Token = "0x4001AF5")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<NewNode.NodeAccess, float> entranceWeights;

		// Token: 0x04001AF6 RID: 6902
		[Token(Token = "0x4001AF6")]
		[FieldOffset(Offset = "0x68")]
		private bool hasHash;

		// Token: 0x04001AF7 RID: 6903
		[Token(Token = "0x4001AF7")]
		[FieldOffset(Offset = "0x6C")]
		private int hash;

		// Token: 0x020003DF RID: 991
		[Token(Token = "0x20003DF")]
		public enum AccessType
		{
			// Token: 0x04001AF9 RID: 6905
			[Token(Token = "0x4001AF9")]
			streetToStreet,
			// Token: 0x04001AFA RID: 6906
			[Token(Token = "0x4001AFA")]
			door,
			// Token: 0x04001AFB RID: 6907
			[Token(Token = "0x4001AFB")]
			openDoorway,
			// Token: 0x04001AFC RID: 6908
			[Token(Token = "0x4001AFC")]
			verticalSpace,
			// Token: 0x04001AFD RID: 6909
			[Token(Token = "0x4001AFD")]
			adjacent,
			// Token: 0x04001AFE RID: 6910
			[Token(Token = "0x4001AFE")]
			window,
			// Token: 0x04001AFF RID: 6911
			[Token(Token = "0x4001AFF")]
			bannister
		}
	}

	// Token: 0x020003E0 RID: 992
	[Token(Token = "0x20003E0")]
	private sealed class <>c__DisplayClass61_0
	{
		// Token: 0x0600164A RID: 5706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass61_0()
		{
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0000A548 File Offset: 0x00008748
		[Token(Token = "0x600164B")]
		[Address(RVA = "0x871750", Offset = "0x870750", VA = "0x180871750")]
		internal bool <AddAccessToOtherNode>b__0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001B00 RID: 6912
		[Token(Token = "0x4001B00")]
		[FieldOffset(Offset = "0x10")]
		public NewNode newNode;
	}

	// Token: 0x020003E1 RID: 993
	[Token(Token = "0x20003E1")]
	private sealed class <>c__DisplayClass62_0
	{
		// Token: 0x0600164C RID: 5708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass62_0()
		{
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x0000A560 File Offset: 0x00008760
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x4FE580", Offset = "0x4FD580", VA = "0x1804FE580")]
		internal bool <RemoveAccessToOtherNode>b__0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0000A578 File Offset: 0x00008778
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x871790", Offset = "0x870790", VA = "0x180871790")]
		internal bool <RemoveAccessToOtherNode>b__1(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x04001B01 RID: 6913
		[Token(Token = "0x4001B01")]
		[FieldOffset(Offset = "0x10")]
		public NewNode <>4__this;

		// Token: 0x04001B02 RID: 6914
		[Token(Token = "0x4001B02")]
		[FieldOffset(Offset = "0x18")]
		public NewNode newNode;
	}

	// Token: 0x020003E2 RID: 994
	[Token(Token = "0x20003E2")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001650 RID: 5712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0000A590 File Offset: 0x00008790
		[Token(Token = "0x6001651")]
		[Address(RVA = "0x871870", Offset = "0x870870", VA = "0x180871870")]
		internal int <AddInteractable>b__64_0(Interactable p1, Interactable p2)
		{
			return 0;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0000A5A8 File Offset: 0x000087A8
		[Token(Token = "0x6001652")]
		[Address(RVA = "0x871870", Offset = "0x870870", VA = "0x180871870")]
		internal int <AddInteractable>b__64_1(Interactable p1, Interactable p2)
		{
			return 0;
		}

		// Token: 0x04001B03 RID: 6915
		[Token(Token = "0x4001B03")]
		[FieldOffset(Offset = "0x0")]
		public static readonly NewNode.<>c <>9;

		// Token: 0x04001B04 RID: 6916
		[Token(Token = "0x4001B04")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<Interactable> <>9__64_0;

		// Token: 0x04001B05 RID: 6917
		[Token(Token = "0x4001B05")]
		[FieldOffset(Offset = "0x10")]
		public static Comparison<Interactable> <>9__64_1;
	}
}
