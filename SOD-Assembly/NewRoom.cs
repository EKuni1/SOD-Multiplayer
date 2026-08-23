using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x020003E3 RID: 995
[Token(Token = "0x20003E3")]
public class NewRoom : Controller, IEnumerator<object>, IDisposable
{
	// Token: 0x06001653 RID: 5715 RVA: 0x0000A5C0 File Offset: 0x000087C0
	[Token(Token = "0x6001653")]
	[Address(RVA = "0x82AE60", Offset = "0x829E60", VA = "0x18082AE60", Slot = "7")]
	private bool Equals(NewRoom other)
	{
		return default(bool);
	}

	// Token: 0x06001654 RID: 5716 RVA: 0x0000A5D8 File Offset: 0x000087D8
	[Token(Token = "0x6001654")]
	[Address(RVA = "0x82AEC0", Offset = "0x829EC0", VA = "0x18082AEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return 0;
	}

	// Token: 0x06001655 RID: 5717 RVA: 0x0000A5F0 File Offset: 0x000087F0
	[Token(Token = "0x6001655")]
	[Address(RVA = "0x82AED0", Offset = "0x829ED0", VA = "0x18082AED0")]
	public Color GetShadowTint(Color lightColour, float intensity)
	{
		return default(Color);
	}

	// Token: 0x06001656 RID: 5718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001656")]
	[Address(RVA = "0x82B230", Offset = "0x82A230", VA = "0x18082B230")]
	public void SetupLayoutOnly(NewGameLocation newAddress, RoomTypePreset newRoomType, int loadFloorRoomID = -1)
	{
	}

	// Token: 0x06001657 RID: 5719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001657")]
	[Address(RVA = "0x82C0F0", Offset = "0x82B0F0", VA = "0x18082C0F0")]
	public void SetupAll(NewGameLocation newAddress, RoomConfiguration newPreset, int loadFloorRoomID = -1)
	{
	}

	// Token: 0x06001658 RID: 5720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001658")]
	[Address(RVA = "0x82C250", Offset = "0x82B250", VA = "0x18082C250")]
	public void SetConfiguration(RoomConfiguration newPreset)
	{
	}

	// Token: 0x06001659 RID: 5721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001659")]
	[Address(RVA = "0x82D180", Offset = "0x82C180", VA = "0x18082D180")]
	public void SetType(RoomTypePreset newRoomType)
	{
	}

	// Token: 0x0600165A RID: 5722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600165A")]
	[Address(RVA = "0x82D440", Offset = "0x82C440", VA = "0x18082D440")]
	public void Load(CitySaveData.RoomCitySave data, NewGameLocation newGameLoc)
	{
	}

	// Token: 0x0600165B RID: 5723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600165B")]
	[Address(RVA = "0x8302E0", Offset = "0x82F2E0", VA = "0x1808302E0")]
	public void LoadCullingTree()
	{
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600165C")]
	[Address(RVA = "0x831400", Offset = "0x830400", VA = "0x180831400")]
	public void UpdateColourSchemeAndMaterials()
	{
	}

	// Token: 0x0600165D RID: 5725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600165D")]
	[Address(RVA = "0x832DE0", Offset = "0x831DE0", VA = "0x180832DE0")]
	public void AddNewNode(NewNode newNode)
	{
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600165E")]
	[Address(RVA = "0x833F50", Offset = "0x832F50", VA = "0x180833F50")]
	public string GetName()
	{
		return null;
	}

	// Token: 0x0600165F RID: 5727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600165F")]
	[Address(RVA = "0x834190", Offset = "0x833190", VA = "0x180834190")]
	public void SetRoomName()
	{
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001660")]
	[Address(RVA = "0x8344D0", Offset = "0x8334D0", VA = "0x1808344D0")]
	public void RemoveNode(NewNode newNode)
	{
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001661")]
	[Address(RVA = "0x834E90", Offset = "0x833E90", VA = "0x180834E90")]
	public void UpdateWorldPositionAndBoundsSize()
	{
	}

	// Token: 0x06001662 RID: 5730 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001662")]
	[Address(RVA = "0x835190", Offset = "0x834190", VA = "0x180835190")]
	public void AddOpenPlanElement(RoomConfiguration newElement)
	{
	}

	// Token: 0x06001663 RID: 5731 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001663")]
	[Address(RVA = "0x835240", Offset = "0x834240", VA = "0x180835240")]
	public void SetFloorMaterial(MaterialGroupPreset newMat, MaterialGroupPreset.MaterialVariation newVar, bool getNewKey = true, bool getMaterial = true)
	{
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001664")]
	[Address(RVA = "0x835790", Offset = "0x834790", VA = "0x180835790")]
	public void SetCeilingMaterial(MaterialGroupPreset newMat, MaterialGroupPreset.MaterialVariation newVar, bool getNewKey = true, bool getMaterial = true)
	{
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001665")]
	[Address(RVA = "0x836460", Offset = "0x835460", VA = "0x180836460")]
	public void SetWallMaterialDefault(MaterialGroupPreset newMat, MaterialGroupPreset.MaterialVariation newVar, bool getNewKey = true, bool getMaterial = true)
	{
	}

	// Token: 0x06001666 RID: 5734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001666")]
	[Address(RVA = "0x836B40", Offset = "0x835B40", VA = "0x180836B40")]
	public void ToggleMainLights([Optional] Actor actor)
	{
	}

	// Token: 0x06001667 RID: 5735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001667")]
	[Address(RVA = "0x836BE0", Offset = "0x835BE0", VA = "0x180836BE0")]
	public void SetMainLights(bool newVal, string debug, [Optional] Actor actor, bool forceInstant = false, bool forceUpdate = false)
	{
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001668")]
	[Address(RVA = "0x838770", Offset = "0x837770", VA = "0x180838770")]
	public void SetSecondaryLight(bool newVal, bool forceUpdate = false)
	{
	}

	// Token: 0x06001669 RID: 5737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001669")]
	[Address(RVA = "0x838A80", Offset = "0x837A80", VA = "0x180838A80")]
	public void UpdateEmissionEndOfFrame()
	{
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600166A")]
	[Address(RVA = "0x838B10", Offset = "0x837B10", VA = "0x180838B10")]
	public void UpdateEmissionTex()
	{
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600166B")]
	[Address(RVA = "0x839760", Offset = "0x838760", VA = "0x180839760")]
	public void AddMainLight(Interactable newLight)
	{
	}

	// Token: 0x0600166C RID: 5740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600166C")]
	[Address(RVA = "0x839850", Offset = "0x838850", VA = "0x180839850")]
	public void AddSecondaryLight(Interactable newLight)
	{
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600166D")]
	[Address(RVA = "0x839900", Offset = "0x838900", VA = "0x180839900")]
	public void AddEntrance(NewNode fromNode, NewNode toNode, bool forceAccessType = false, NewNode.NodeAccess.AccessType forcedAccessType = NewNode.NodeAccess.AccessType.adjacent, bool forceWalkable = false)
	{
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600166E")]
	[Address(RVA = "0x839E00", Offset = "0x838E00", VA = "0x180839E00")]
	public void RemoveEntrance(NewNode fromNode, NewNode toNode)
	{
	}

	// Token: 0x0600166F RID: 5743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600166F")]
	[Address(RVA = "0x83A470", Offset = "0x839470", VA = "0x18083A470")]
	public void SetVisible(bool val, bool forceUpdate, bool immediateLoad = false, bool immediatelyLoadStuff = true)
	{
	}

	// Token: 0x06001670 RID: 5744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001670")]
	[Address(RVA = "0x83C5E0", Offset = "0x83B5E0", VA = "0x18083C5E0")]
	public void LoadRoomStuff(bool immediateLoad = false)
	{
	}

	// Token: 0x06001671 RID: 5745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001671")]
	[Address(RVA = "0x83CEF0", Offset = "0x83BEF0", VA = "0x18083CEF0")]
	public void AddForStaticBatching(FurnitureLocation loc)
	{
	}

	// Token: 0x06001672 RID: 5746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001672")]
	[Address(RVA = "0x83D540", Offset = "0x83C540", VA = "0x18083D540")]
	public void AddForStaticBatching(GameObject obj, MeshFilter objectFilter, Mesh objectMesh, Material objectMat)
	{
	}

	// Token: 0x06001673 RID: 5747 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001673")]
	[Address(RVA = "0x83DC00", Offset = "0x83CC00", VA = "0x18083DC00")]
	public void ExecuteStaticBatching()
	{
	}

	// Token: 0x06001674 RID: 5748 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001674")]
	[Address(RVA = "0x83E0F0", Offset = "0x83D0F0", VA = "0x18083E0F0")]
	public void QueueFootprintUpdate()
	{
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001675")]
	[Address(RVA = "0x83E110", Offset = "0x83D110", VA = "0x18083E110")]
	public void UpdateFootprints(bool forceRemoveAll = false)
	{
	}

	// Token: 0x06001676 RID: 5750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001676")]
	[Address(RVA = "0x83E700", Offset = "0x83D700", VA = "0x18083E700")]
	public void EnableLight(bool val)
	{
	}

	// Token: 0x06001677 RID: 5751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001677")]
	[Address(RVA = "0x83E990", Offset = "0x83D990", VA = "0x18083E990")]
	public void ConnectNodes()
	{
	}

	// Token: 0x06001678 RID: 5752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001678")]
	[Address(RVA = "0x840420", Offset = "0x83F420", VA = "0x180840420")]
	public void ApplyBlockedAccess()
	{
	}

	// Token: 0x06001679 RID: 5753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001679")]
	[Address(RVA = "0x8408B0", Offset = "0x83F8B0", VA = "0x1808408B0")]
	public void GenerateCullingTree(bool debugMode = false)
	{
	}

	// Token: 0x0600167A RID: 5754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600167A")]
	[Address(RVA = "0x8463C0", Offset = "0x8453C0", VA = "0x1808463C0")]
	private void SpawnDebugCullingObject(Vector3 worldPos, NewRoom room, NewNode.NodeAccess parentEntrance, List<int> depDoors, CullingDebugController.CullDebugType newType, [Optional] NewRoom atriumTopOf, [Optional] NewNode.NodeAccess otherEntrance)
	{
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600167B")]
	[Address(RVA = "0x846BE0", Offset = "0x845BE0", VA = "0x180846BE0")]
	public void SetLowerRoom(NewRoom newRoom)
	{
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600167C")]
	[Address(RVA = "0x846C50", Offset = "0x845C50", VA = "0x180846C50")]
	public void AddOccupant(Actor newOcc)
	{
	}

	// Token: 0x0600167D RID: 5757 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600167D")]
	[Address(RVA = "0x846DC0", Offset = "0x845DC0", VA = "0x180846DC0")]
	public void RemoveOccupant(Actor remOcc)
	{
	}

	// Token: 0x0600167E RID: 5758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600167E")]
	[Address(RVA = "0x846FE0", Offset = "0x845FE0", VA = "0x180846FE0")]
	public void AddFurniture(FurnitureClusterLocation newFurn, bool generateNew, bool addPathBlocking = true, bool immediateSpawn = false, bool ignoreLimitations = false, [Optional] DesignStylePreset styleOverride)
	{
	}

	// Token: 0x0600167F RID: 5759 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600167F")]
	[Address(RVA = "0x84BD10", Offset = "0x84AD10", VA = "0x18084BD10")]
	public FurnitureLocation AddFurnitureCustom(PlayerApartmentController.FurniturePlacement newPlacement)
	{
		return null;
	}

	// Token: 0x06001680 RID: 5760 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001680")]
	[Address(RVA = "0x84C3B0", Offset = "0x84B3B0", VA = "0x18084C3B0")]
	public FurnitureLocation AddFurnitureCustom(FurnitureLocation newPlacement)
	{
		return null;
	}

	// Token: 0x06001681 RID: 5761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001681")]
	[Address(RVA = "0x84CAD0", Offset = "0x84BAD0", VA = "0x18084CAD0")]
	public void AddFurnitureBlockedAccess(FurnitureLocation obj)
	{
	}

	// Token: 0x06001682 RID: 5762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001682")]
	[Address(RVA = "0x84DA90", Offset = "0x84CA90", VA = "0x18084DA90")]
	public void AddCustomNodeWeights(FurnitureLocation obj)
	{
	}

	// Token: 0x06001683 RID: 5763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001683")]
	[Address(RVA = "0x84DEE0", Offset = "0x84CEE0", VA = "0x18084DEE0")]
	private void AddFOVBlock(FurnitureLocation obj)
	{
	}

	// Token: 0x06001684 RID: 5764 RVA: 0x0000A608 File Offset: 0x00008808
	[Token(Token = "0x6001684")]
	[Address(RVA = "0x84E3B0", Offset = "0x84D3B0", VA = "0x18084E3B0")]
	public bool AddRandomAirVent(NewAddress.AirVent ventType)
	{
		return default(bool);
	}

	// Token: 0x06001685 RID: 5765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001685")]
	[Address(RVA = "0x84FC90", Offset = "0x84EC90", VA = "0x18084FC90")]
	private void LoadVent(AirDuctGroup.AirVent vent)
	{
	}

	// Token: 0x06001686 RID: 5766 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001686")]
	[Address(RVA = "0x84FD70", Offset = "0x84ED70", VA = "0x18084FD70")]
	public void AddDuctGroup(AirDuctGroup newGroup)
	{
	}

	// Token: 0x06001687 RID: 5767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001687")]
	[Address(RVA = "0x84FE20", Offset = "0x84EE20", VA = "0x18084FE20")]
	public void AddOwner(Human newOwner)
	{
	}

	// Token: 0x06001688 RID: 5768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001688")]
	[Address(RVA = "0x850260", Offset = "0x84F260", VA = "0x180850260")]
	public void LoadOwners()
	{
	}

	// Token: 0x06001689 RID: 5769 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001689")]
	[Address(RVA = "0x850860", Offset = "0x84F860", VA = "0x180850860")]
	public void PickPassword()
	{
	}

	// Token: 0x0600168A RID: 5770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600168A")]
	[Address(RVA = "0x851960", Offset = "0x850960", VA = "0x180851960")]
	public void SetupEnvrionment()
	{
	}

	// Token: 0x0600168B RID: 5771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600168B")]
	[Address(RVA = "0x851B70", Offset = "0x850B70", VA = "0x180851B70")]
	public void SetExplorationLevel(int newLevel)
	{
	}

	// Token: 0x0600168C RID: 5772 RVA: 0x0000A620 File Offset: 0x00008820
	[Token(Token = "0x600168C")]
	[Address(RVA = "0x852690", Offset = "0x851690", VA = "0x180852690")]
	public bool TestForDynamicShadowsUpdate()
	{
		return default(bool);
	}

	// Token: 0x0600168D RID: 5773 RVA: 0x0000A638 File Offset: 0x00008838
	[Token(Token = "0x600168D")]
	[Address(RVA = "0x853200", Offset = "0x852200", VA = "0x180853200", Slot = "6")]
	public int CompareTo(NewRoom otherObject)
	{
		return 0;
	}

	// Token: 0x0600168E RID: 5774 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600168E")]
	[Address(RVA = "0x853250", Offset = "0x852250", VA = "0x180853250")]
	public CitySaveData.RoomCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x0600168F RID: 5775 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600168F")]
	[Address(RVA = "0x854EF0", Offset = "0x853EF0", VA = "0x180854EF0")]
	public NewNode GetRandomNode()
	{
		return null;
	}

	// Token: 0x06001690 RID: 5776 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001690")]
	[Address(RVA = "0x855050", Offset = "0x854050", VA = "0x180855050")]
	public NewNode GetRandomEntranceNode()
	{
		return null;
	}

	// Token: 0x06001691 RID: 5777 RVA: 0x0000A650 File Offset: 0x00008850
	[Token(Token = "0x6001691")]
	[Address(RVA = "0x8552A0", Offset = "0x8542A0", VA = "0x1808552A0")]
	public bool IsAccessAllowed(Human human)
	{
		return default(bool);
	}

	// Token: 0x06001692 RID: 5778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001692")]
	[Address(RVA = "0x8552F0", Offset = "0x8542F0", VA = "0x1808552F0")]
	public void RemoveAllInhabitantFurniture(bool removeSkipAddressInhabitantsFurniture, FurnitureClusterLocation.RemoveInteractablesOption spawnedOnFurnitureRemovalOption)
	{
	}

	// Token: 0x06001693 RID: 5779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001693")]
	[Address(RVA = "0x855B60", Offset = "0x854B60", VA = "0x180855B60")]
	public void SetSteam(bool val)
	{
	}

	// Token: 0x06001694 RID: 5780 RVA: 0x0000A668 File Offset: 0x00008868
	[Token(Token = "0x6001694")]
	[Address(RVA = "0x855E80", Offset = "0x854E80", VA = "0x180855E80")]
	public bool IsOutside()
	{
		return default(bool);
	}

	// Token: 0x06001695 RID: 5781 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001695")]
	[Address(RVA = "0x855EF0", Offset = "0x854EF0", VA = "0x180855EF0")]
	public List<NewRoom> GetAdjacentRooms()
	{
		return null;
	}

	// Token: 0x06001696 RID: 5782 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001696")]
	[Address(RVA = "0x8564E0", Offset = "0x8554E0", VA = "0x1808564E0")]
	public List<NewRoom> GetAboveRooms()
	{
		return null;
	}

	// Token: 0x06001697 RID: 5783 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001697")]
	[Address(RVA = "0x8568C0", Offset = "0x8558C0", VA = "0x1808568C0")]
	public List<NewRoom> GetBelowRooms()
	{
		return null;
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001698")]
	[Address(RVA = "0x856CA0", Offset = "0x855CA0", VA = "0x180856CA0")]
	public List<NewRoom> GetAboveAndBelowRooms()
	{
		return null;
	}

	// Token: 0x06001699 RID: 5785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001699")]
	[Address(RVA = "0x857160", Offset = "0x856160", VA = "0x180857160")]
	public void DisplaySublocations()
	{
	}

	// Token: 0x0600169A RID: 5786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600169A")]
	[Address(RVA = "0x857E50", Offset = "0x856E50", VA = "0x180857E50")]
	public void RemoveSublocationsDisplay()
	{
	}

	// Token: 0x0600169B RID: 5787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600169B")]
	[Address(RVA = "0x857F80", Offset = "0x856F80", VA = "0x180857F80")]
	public void DebugTeleportPlayerToLocation()
	{
	}

	// Token: 0x0600169C RID: 5788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600169C")]
	[Address(RVA = "0x858150", Offset = "0x857150", VA = "0x180858150")]
	public void DebugCullingDisplay()
	{
	}

	// Token: 0x0600169D RID: 5789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600169D")]
	[Address(RVA = "0x8582E0", Offset = "0x8572E0", VA = "0x1808582E0")]
	public void GetMainLightData()
	{
	}

	// Token: 0x0600169E RID: 5790 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600169E")]
	[Address(RVA = "0x8585B0", Offset = "0x8575B0", VA = "0x1808585B0")]
	public void ToggleExteriorWindowDebug()
	{
	}

	// Token: 0x0600169F RID: 5791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600169F")]
	[Address(RVA = "0x859130", Offset = "0x858130", VA = "0x180859130")]
	public void TestFurniturePlacementBlockingCheck()
	{
	}

	// Token: 0x060016A0 RID: 5792 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016A0")]
	[Address(RVA = "0x859460", Offset = "0x858460", VA = "0x180859460")]
	public void TestFurniturePlacementBlockingCheckIgnoreNoPassthrough()
	{
	}

	// Token: 0x060016A1 RID: 5793 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016A1")]
	[Address(RVA = "0x859790", Offset = "0x858790", VA = "0x180859790")]
	public void DisplayNodePositions()
	{
	}

	// Token: 0x060016A2 RID: 5794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016A2")]
	[Address(RVA = "0x85A140", Offset = "0x859140", VA = "0x18085A140")]
	public void RemoveNodePositions()
	{
	}

	// Token: 0x060016A3 RID: 5795 RVA: 0x0000A680 File Offset: 0x00008880
	[Token(Token = "0x60016A3")]
	[Address(RVA = "0x85A2D0", Offset = "0x8592D0", VA = "0x18085A2D0")]
	public int GetWallCount()
	{
		return 0;
	}

	// Token: 0x060016A4 RID: 5796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016A4")]
	[Address(RVA = "0x85A460", Offset = "0x859460", VA = "0x18085A460")]
	public void GetAIActions()
	{
	}

	// Token: 0x060016A5 RID: 5797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016A5")]
	[Address(RVA = "0x85A730", Offset = "0x859730", VA = "0x18085A730")]
	public void GetInteractables()
	{
	}

	// Token: 0x060016A6 RID: 5798 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016A6")]
	[Address(RVA = "0x85AA60", Offset = "0x859A60", VA = "0x18085AA60")]
	public void ListContainedInteractables()
	{
	}

	// Token: 0x060016A7 RID: 5799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016A7")]
	[Address(RVA = "0x85AC90", Offset = "0x859C90", VA = "0x18085AC90")]
	public void ListActionReferences()
	{
	}

	// Token: 0x060016A8 RID: 5800 RVA: 0x0000A698 File Offset: 0x00008898
	[Token(Token = "0x60016A8")]
	[Address(RVA = "0x85B2B0", Offset = "0x85A2B0", VA = "0x18085B2B0")]
	public SessionData.SceneProfile GetEnvironment()
	{
		return SessionData.SceneProfile.outdoors;
	}

	// Token: 0x060016A9 RID: 5801 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016A9")]
	[Address(RVA = "0x85B8A0", Offset = "0x85A8A0", VA = "0x18085B8A0")]
	public void AddGas(float amount)
	{
	}

	// Token: 0x060016AA RID: 5802 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016AA")]
	[Address(RVA = "0x85BAD0", Offset = "0x85AAD0", VA = "0x18085BAD0")]
	public void RebuildCullingTree()
	{
	}

	// Token: 0x060016AB RID: 5803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016AB")]
	[Address(RVA = "0x85BCF0", Offset = "0x85ACF0", VA = "0x18085BCF0")]
	public void IsThisOutside()
	{
	}

	// Token: 0x060016AC RID: 5804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016AC")]
	[Address(RVA = "0x85BD50", Offset = "0x85AD50", VA = "0x18085BD50")]
	public void SpawnModularRoomElements()
	{
	}

	// Token: 0x060016AD RID: 5805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016AD")]
	[Address(RVA = "0x85BDF0", Offset = "0x85ADF0", VA = "0x18085BDF0")]
	public void ListLoadedFurniture()
	{
	}

	// Token: 0x060016AE RID: 5806 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016AE")]
	[Address(RVA = "0x85C020", Offset = "0x85B020", VA = "0x18085C020")]
	public void UnloadRoomGeometry()
	{
	}

	// Token: 0x060016AF RID: 5807 RVA: 0x0000A6B0 File Offset: 0x000088B0
	[Token(Token = "0x60016AF")]
	[Address(RVA = "0x85C0E0", Offset = "0x85B0E0", VA = "0x18085C0E0")]
	public bool GetSecondaryLightStatus()
	{
		return default(bool);
	}

	// Token: 0x060016B0 RID: 5808 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016B0")]
	[Address(RVA = "0x85C280", Offset = "0x85B280", VA = "0x18085C280")]
	public void UnloadRoomGeometry(int spawnedRoomIndex, bool despawnObjects = true)
	{
	}

	// Token: 0x060016B1 RID: 5809 RVA: 0x0000A6C8 File Offset: 0x000088C8
	[Token(Token = "0x60016B1")]
	[Address(RVA = "0x85DCF0", Offset = "0x85CCF0", VA = "0x18085DCF0")]
	public int GetMeshGenerationCachePriority()
	{
		return 0;
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x0000A6E0 File Offset: 0x000088E0
	[Token(Token = "0x60016B2")]
	[Address(RVA = "0x85E5D0", Offset = "0x85D5D0", VA = "0x18085E5D0")]
	public int GetRoomCullingCachePriority()
	{
		return 0;
	}

	// Token: 0x060016B3 RID: 5811 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016B3")]
	[Address(RVA = "0x85EEB0", Offset = "0x85DEB0", VA = "0x18085EEB0")]
	public void ExecuteLightswitchesOverrides()
	{
	}

	// Token: 0x060016B4 RID: 5812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016B4")]
	[Address(RVA = "0x85F320", Offset = "0x85E320", VA = "0x18085F320")]
	private void OnDestroy()
	{
	}

	// Token: 0x060016B5 RID: 5813 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016B5")]
	[Address(RVA = "0x85F5C0", Offset = "0x85E5C0", VA = "0x18085F5C0")]
	public void ListCurrentOccupants()
	{
	}

	// Token: 0x060016B6 RID: 5814 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016B6")]
	[Address(RVA = "0x85F7A0", Offset = "0x85E7A0", VA = "0x18085F7A0")]
	public NewRoom()
	{
	}

	// Token: 0x060016B8 RID: 5816 RVA: 0x0000A6F8 File Offset: 0x000088F8
	[Token(Token = "0x60016B8")]
	[Address(RVA = "0x8617C0", Offset = "0x8607C0", VA = "0x1808617C0")]
	private bool <GenerateCullingTree>b__194_0(NewNode.NodeAccess item)
	{
		return default(bool);
	}

	// Token: 0x060016B9 RID: 5817 RVA: 0x0000A710 File Offset: 0x00008910
	[Token(Token = "0x60016B9")]
	[Address(RVA = "0x861800", Offset = "0x860800", VA = "0x180861800")]
	private bool <RemoveAllInhabitantFurniture>b__219_0(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x04001B06 RID: 6918
	[Token(Token = "0x4001B06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public new string name;

	// Token: 0x04001B07 RID: 6919
	[Token(Token = "0x4001B07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public NewBuilding building;

	// Token: 0x04001B08 RID: 6920
	[Token(Token = "0x4001B08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public NewFloor floor;

	// Token: 0x04001B09 RID: 6921
	[Token(Token = "0x4001B09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public NewGameLocation gameLocation;

	// Token: 0x04001B0A RID: 6922
	[Token(Token = "0x4001B0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public NewRoom lowerRoom;

	// Token: 0x04001B0B RID: 6923
	[Token(Token = "0x4001B0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int furnitureAssignID;

	// Token: 0x04001B0C RID: 6924
	[Token(Token = "0x4001B0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int interactableAssignID;

	// Token: 0x04001B0D RID: 6925
	[Token(Token = "0x4001B0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject contentsParent;

	// Token: 0x04001B0E RID: 6926
	[Token(Token = "0x4001B0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public HashSet<NewNode> nodes;

	// Token: 0x04001B0F RID: 6927
	[Token(Token = "0x4001B0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<RoomConfiguration> openPlanElements;

	// Token: 0x04001B10 RID: 6928
	[Token(Token = "0x4001B10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<NewNode.NodeAccess> entrances;

	// Token: 0x04001B11 RID: 6929
	[Token(Token = "0x4001B11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<NewRoom.RoomDivider> roomDividers;

	// Token: 0x04001B12 RID: 6930
	[Token(Token = "0x4001B12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<NewRoom.LightZoneData> lightZones;

	// Token: 0x04001B13 RID: 6931
	[Token(Token = "0x4001B13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3 middleRoomPosition;

	// Token: 0x04001B14 RID: 6932
	[Token(Token = "0x4001B14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<NewRoom> commonRooms;

	// Token: 0x04001B15 RID: 6933
	[Token(Token = "0x4001B15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public HashSet<Actor> currentOccupants;

	// Token: 0x04001B16 RID: 6934
	[Token(Token = "0x4001B16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject streetObjectContainer;

	// Token: 0x04001B17 RID: 6935
	[Token(Token = "0x4001B17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public HashSet<Interactable> tamperedInteractables;

	// Token: 0x04001B18 RID: 6936
	[Token(Token = "0x4001B18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<NewNode> noAccessNodes;

	// Token: 0x04001B19 RID: 6937
	[Token(Token = "0x4001B19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public HashSet<Interactable> worldObjects;

	// Token: 0x04001B1A RID: 6938
	[Token(Token = "0x4001B1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<Human.ConversationInstance> activeConversations;

	// Token: 0x04001B1B RID: 6939
	[Token(Token = "0x4001B1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<NewWall> windows;

	// Token: 0x04001B1C RID: 6940
	[Token(Token = "0x4001B1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<AudioController.LoopingSoundInfo> audibleLoopingSounds;

	// Token: 0x04001B1D RID: 6941
	[Token(Token = "0x4001B1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Dictionary<FurniturePreset.FurnitureGroup, int> furnitureGroups;

	// Token: 0x04001B1E RID: 6942
	[Token(Token = "0x4001B1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<Interactable> heatSources;

	// Token: 0x04001B1F RID: 6943
	[Token(Token = "0x4001B1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public List<PipeConstructor.PipeGroup> pipes;

	// Token: 0x04001B20 RID: 6944
	[Token(Token = "0x4001B20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<StateSaveData.ChangedLightswitch> lightswitchOverrides;

	// Token: 0x04001B21 RID: 6945
	[Token(Token = "0x4001B21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public int roomFloorID;

	// Token: 0x04001B22 RID: 6946
	[Token(Token = "0x4001B22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int assignRoomFloorID;

	// Token: 0x04001B23 RID: 6947
	[Token(Token = "0x4001B23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public int roomID;

	// Token: 0x04001B24 RID: 6948
	[Token(Token = "0x4001B24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int assignRoomID;

	// Token: 0x04001B25 RID: 6949
	[Token(Token = "0x4001B25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public string seed;

	// Token: 0x04001B26 RID: 6950
	[Token(Token = "0x4001B26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public int assignWallID;

	// Token: 0x04001B27 RID: 6951
	[Token(Token = "0x4001B27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public RoomTypePreset roomType;

	// Token: 0x04001B28 RID: 6952
	[Token(Token = "0x4001B28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public RoomConfiguration preset;

	// Token: 0x04001B29 RID: 6953
	[Token(Token = "0x4001B29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Vector3 worldPos;

	// Token: 0x04001B2A RID: 6954
	[Token(Token = "0x4001B2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public bool calculatedWorldPos;

	// Token: 0x04001B2B RID: 6955
	[Token(Token = "0x4001B2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Vector2 boundsSize;

	// Token: 0x04001B2C RID: 6956
	[Token(Token = "0x4001B2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public bool geometryLoaded;

	// Token: 0x04001B2D RID: 6957
	[Token(Token = "0x4001B2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
	public bool reachableFromEntrance;

	// Token: 0x04001B2E RID: 6958
	[Token(Token = "0x4001B2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
	public bool isOutsideWindow;

	// Token: 0x04001B2F RID: 6959
	[Token(Token = "0x4001B2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x133")]
	public bool isNullRoom;

	// Token: 0x04001B30 RID: 6960
	[Token(Token = "0x4001B30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public bool isBaseNullRoom;

	// Token: 0x04001B31 RID: 6961
	[Token(Token = "0x4001B31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x135")]
	public bool featuresStairwell;

	// Token: 0x04001B32 RID: 6962
	[Token(Token = "0x4001B32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x136")]
	public bool uniqueCeilingMaterial;

	// Token: 0x04001B33 RID: 6963
	[Token(Token = "0x4001B33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x137")]
	public bool containsDead;

	// Token: 0x04001B34 RID: 6964
	[Token(Token = "0x4001B34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public bool decorEdit;

	// Token: 0x04001B35 RID: 6965
	[Token(Token = "0x4001B35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
	public bool isVisible;

	// Token: 0x04001B36 RID: 6966
	[Token(Token = "0x4001B36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
	public bool musicPlaying;

	// Token: 0x04001B37 RID: 6967
	[Token(Token = "0x4001B37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public float musicStartedAt;

	// Token: 0x04001B38 RID: 6968
	[Token(Token = "0x4001B38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public bool allowCoving;

	// Token: 0x04001B39 RID: 6969
	[Token(Token = "0x4001B39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public MaterialGroupPreset floorMaterial;

	// Token: 0x04001B3A RID: 6970
	[Token(Token = "0x4001B3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Toolbox.MaterialKey floorMatKey;

	// Token: 0x04001B3B RID: 6971
	[Token(Token = "0x4001B3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Material floorMat;

	// Token: 0x04001B3C RID: 6972
	[Token(Token = "0x4001B3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public MaterialGroupPreset ceilingMaterial;

	// Token: 0x04001B3D RID: 6973
	[Token(Token = "0x4001B3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Toolbox.MaterialKey ceilingMatKey;

	// Token: 0x04001B3E RID: 6974
	[Token(Token = "0x4001B3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public Material ceilingMat;

	// Token: 0x04001B3F RID: 6975
	[Token(Token = "0x4001B3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public MaterialGroupPreset defaultWallMaterial;

	// Token: 0x04001B40 RID: 6976
	[Token(Token = "0x4001B40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public Toolbox.MaterialKey defaultWallKey;

	// Token: 0x04001B41 RID: 6977
	[Token(Token = "0x4001B41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public Material wallMat;

	// Token: 0x04001B42 RID: 6978
	[Token(Token = "0x4001B42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public bool hasBeenDecorated;

	// Token: 0x04001B43 RID: 6979
	[Token(Token = "0x4001B43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public Toolbox.MaterialKey miscKey;

	// Token: 0x04001B44 RID: 6980
	[Token(Token = "0x4001B44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public ColourSchemePreset colourScheme;

	// Token: 0x04001B45 RID: 6981
	[Token(Token = "0x4001B45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public RoomLightingPreset mainLightPreset;

	// Token: 0x04001B46 RID: 6982
	[Token(Token = "0x4001B46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public bool mainLightStatus;

	// Token: 0x04001B47 RID: 6983
	[Token(Token = "0x4001B47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public List<NewWall> lightswitches;

	// Token: 0x04001B48 RID: 6984
	[Token(Token = "0x4001B48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public List<Interactable> lightswitchInteractables;

	// Token: 0x04001B49 RID: 6985
	[Token(Token = "0x4001B49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public List<Interactable> mainLights;

	// Token: 0x04001B4A RID: 6986
	[Token(Token = "0x4001B4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public List<Interactable> secondaryLights;

	// Token: 0x04001B4B RID: 6987
	[Token(Token = "0x4001B4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public bool enabledLights;

	// Token: 0x04001B4C RID: 6988
	[Token(Token = "0x4001B4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public List<NewWall> windowsWithUVData;

	// Token: 0x04001B4D RID: 6989
	[Token(Token = "0x4001B4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public int ceilingFans;

	// Token: 0x04001B4E RID: 6990
	[Token(Token = "0x4001B4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public List<GenerationController.OverrideData> overrideData;

	// Token: 0x04001B4F RID: 6991
	[Token(Token = "0x4001B4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private bool actorUpdate;

	// Token: 0x04001B50 RID: 6992
	[Token(Token = "0x4001B50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public Dictionary<NewRoom, List<NewRoom.CullTreeEntry>> cullingTree;

	// Token: 0x04001B51 RID: 6993
	[Token(Token = "0x4001B51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public HashSet<int> doorCheckSet;

	// Token: 0x04001B52 RID: 6994
	[Token(Token = "0x4001B52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public HashSet<NewRoom> nonAudioOccludedRooms;

	// Token: 0x04001B53 RID: 6995
	[Token(Token = "0x4001B53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public HashSet<NewDoor> openDoors;

	// Token: 0x04001B54 RID: 6996
	[Token(Token = "0x4001B54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public HashSet<NewDoor> closedDoors;

	// Token: 0x04001B55 RID: 6997
	[Token(Token = "0x4001B55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public HashSet<NewRoom> adjacentRooms;

	// Token: 0x04001B56 RID: 6998
	[Token(Token = "0x4001B56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public HashSet<NewRoom> aboveRooms;

	// Token: 0x04001B57 RID: 6999
	[Token(Token = "0x4001B57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public HashSet<NewRoom> belowRooms;

	// Token: 0x04001B58 RID: 7000
	[Token(Token = "0x4001B58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public NewRoom atriumTop;

	// Token: 0x04001B59 RID: 7001
	[Token(Token = "0x4001B59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public List<NewRoom> atriumRooms;

	// Token: 0x04001B5A RID: 7002
	[Token(Token = "0x4001B5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public GameObject combinedWalls;

	// Token: 0x04001B5B RID: 7003
	[Token(Token = "0x4001B5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	public MeshRenderer combinedWallRend;

	// Token: 0x04001B5C RID: 7004
	[Token(Token = "0x4001B5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public Dictionary<NewBuilding, GameObject> additionalWalls;

	// Token: 0x04001B5D RID: 7005
	[Token(Token = "0x4001B5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public GameObject combinedFloor;

	// Token: 0x04001B5E RID: 7006
	[Token(Token = "0x4001B5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	public MeshRenderer combinedFloorRend;

	// Token: 0x04001B5F RID: 7007
	[Token(Token = "0x4001B5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	public GameObject combinedCeiling;

	// Token: 0x04001B60 RID: 7008
	[Token(Token = "0x4001B60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	public MeshRenderer combinedCeilingRend;

	// Token: 0x04001B61 RID: 7009
	[Token(Token = "0x4001B61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	public int ambientSoundLevel;

	// Token: 0x04001B62 RID: 7010
	[Token(Token = "0x4001B62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private List<CitySaveData.CullTreeSave> ct;

	// Token: 0x04001B63 RID: 7011
	[Token(Token = "0x4001B63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private List<int> above;

	// Token: 0x04001B64 RID: 7012
	[Token(Token = "0x4001B64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	private List<int> below;

	// Token: 0x04001B65 RID: 7013
	[Token(Token = "0x4001B65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private List<int> adj;

	// Token: 0x04001B66 RID: 7014
	[Token(Token = "0x4001B66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	private List<int> occ;

	// Token: 0x04001B67 RID: 7015
	[Token(Token = "0x4001B67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	public List<FurnitureClusterLocation> furniture;

	// Token: 0x04001B68 RID: 7016
	[Token(Token = "0x4001B68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	public List<FurnitureLocation> individualFurniture;

	// Token: 0x04001B69 RID: 7017
	[Token(Token = "0x4001B69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	private Dictionary<NewRoom.StaticBatchKey, List<GameObject>> staticBatchDictionary;

	// Token: 0x04001B6A RID: 7018
	[Token(Token = "0x4001B6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	public List<Mesh> staticBatchedGeneratedMeshes;

	// Token: 0x04001B6B RID: 7019
	[Token(Token = "0x4001B6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	[NonSerialized]
	public Dictionary<FurnitureClass, List<FurniturePreset>> pickFurnitureCache;

	// Token: 0x04001B6C RID: 7020
	[Token(Token = "0x4001B6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	[NonSerialized]
	public Dictionary<Vector3, NewNode> localizedRoomNodeMaps;

	// Token: 0x04001B6D RID: 7021
	[Token(Token = "0x4001B6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	public bool footprintUpdateQueued;

	// Token: 0x04001B6E RID: 7022
	[Token(Token = "0x4001B6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	public List<FootprintController> spawnedFootprints;

	// Token: 0x04001B6F RID: 7023
	[Token(Token = "0x4001B6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	public Dictionary<NewNode, List<NewNode>> blockedAccess;

	// Token: 0x04001B70 RID: 7024
	[Token(Token = "0x4001B70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	public Dictionary<AIActionPreset, List<Interactable>> actionReference;

	// Token: 0x04001B71 RID: 7025
	[Token(Token = "0x4001B71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	public Dictionary<InteractablePreset.SpecialCase, List<Interactable>> specialCaseInteractables;

	// Token: 0x04001B72 RID: 7026
	[Token(Token = "0x4001B72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	private List<int> loadBelongsTo;

	// Token: 0x04001B73 RID: 7027
	[Token(Token = "0x4001B73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	public List<Human> belongsTo;

	// Token: 0x04001B74 RID: 7028
	[Token(Token = "0x4001B74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	public int explorationLevel;

	// Token: 0x04001B75 RID: 7029
	[Token(Token = "0x4001B75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	public List<RectTransform> mapDoors;

	// Token: 0x04001B76 RID: 7030
	[Token(Token = "0x4001B76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	public List<AirDuctGroup.AirVent> airVents;

	// Token: 0x04001B77 RID: 7031
	[Token(Token = "0x4001B77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	public List<AirDuctGroup> ductGroups;

	// Token: 0x04001B78 RID: 7032
	[Token(Token = "0x4001B78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	public GameplayController.Passcode passcode;

	// Token: 0x04001B79 RID: 7033
	[Token(Token = "0x4001B79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	public List<SpatterSimulation> spatter;

	// Token: 0x04001B7A RID: 7034
	[Token(Token = "0x4001B7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	public List<Interactable> steamControllingInteractables;

	// Token: 0x04001B7B RID: 7035
	[Token(Token = "0x4001B7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	public bool steamOn;

	// Token: 0x04001B7C RID: 7036
	[Token(Token = "0x4001B7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35C")]
	public float steamLastSwitched;

	// Token: 0x04001B7D RID: 7037
	[Token(Token = "0x4001B7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	public SteamController steamController;

	// Token: 0x04001B7E RID: 7038
	[Token(Token = "0x4001B7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	public List<BugController> spawnedBugs;

	// Token: 0x04001B7F RID: 7039
	[Token(Token = "0x4001B7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	public float gasLevel;

	// Token: 0x04001B80 RID: 7040
	[Token(Token = "0x4001B80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
	public float lastRoomGassed;

	// Token: 0x04001B81 RID: 7041
	[Token(Token = "0x4001B81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	public GenerationDebugController debugController;

	// Token: 0x04001B82 RID: 7042
	[Token(Token = "0x4001B82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	public Action UpdateEmission;

	// Token: 0x04001B83 RID: 7043
	[Token(Token = "0x4001B83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	public bool completedTreeCull;

	// Token: 0x04001B84 RID: 7044
	[Token(Token = "0x4001B84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	public List<string> debugLightswitches;

	// Token: 0x04001B85 RID: 7045
	[Token(Token = "0x4001B85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	public int cullingDebugLoadReference;

	// Token: 0x04001B86 RID: 7046
	[Token(Token = "0x4001B86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	private List<CullingDebugController> spawnPathDebug;

	// Token: 0x04001B87 RID: 7047
	[Token(Token = "0x4001B87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
	public string debugCulling;

	// Token: 0x04001B88 RID: 7048
	[Token(Token = "0x4001B88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
	public NewRoom specificRoomCullingDebug;

	// Token: 0x04001B89 RID: 7049
	[Token(Token = "0x4001B89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
	public bool loadedCullTreeFromSave;

	// Token: 0x04001B8A RID: 7050
	[Token(Token = "0x4001B8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
	public List<InteractableController> mainLightObjects;

	// Token: 0x04001B8B RID: 7051
	[Token(Token = "0x4001B8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
	public List<string> debugDecor;

	// Token: 0x04001B8C RID: 7052
	[Token(Token = "0x4001B8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	private List<GameObject> exteriorWindowDebug;

	// Token: 0x04001B8D RID: 7053
	[Token(Token = "0x4001B8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
	private List<GameObject> nodeDebug;

	// Token: 0x04001B8E RID: 7054
	[Token(Token = "0x4001B8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	public List<string> debugAddActions;

	// Token: 0x04001B8F RID: 7055
	[Token(Token = "0x4001B8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
	public string clustersPlaced;

	// Token: 0x04001B90 RID: 7056
	[Token(Token = "0x4001B90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
	public string itemsPlaced;

	// Token: 0x04001B91 RID: 7057
	[Token(Token = "0x4001B91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	public int poolSizeOnPlacement;

	// Token: 0x04001B92 RID: 7058
	[Token(Token = "0x4001B92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
	public string palcementKey1;

	// Token: 0x04001B93 RID: 7059
	[Token(Token = "0x4001B93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
	public string palcementKey2;

	// Token: 0x04001B94 RID: 7060
	[Token(Token = "0x4001B94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
	public string palcementKey3;

	// Token: 0x04001B95 RID: 7061
	[Token(Token = "0x4001B95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
	public string palcementKey4;

	// Token: 0x04001B96 RID: 7062
	[Token(Token = "0x4001B96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
	public string palcementKey5;

	// Token: 0x04001B97 RID: 7063
	[Token(Token = "0x4001B97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
	public string palcementKey51;

	// Token: 0x04001B98 RID: 7064
	[Token(Token = "0x4001B98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
	public string palcementKey52;

	// Token: 0x04001B99 RID: 7065
	[Token(Token = "0x4001B99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
	public string palcementKey6;

	// Token: 0x04001B9A RID: 7066
	[Token(Token = "0x4001B9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
	public string keyAtStart;

	// Token: 0x04001B9B RID: 7067
	[Token(Token = "0x4001B9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
	private GameObject sublocationParent;

	// Token: 0x04001B9C RID: 7068
	[Token(Token = "0x4001B9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
	private List<GameObject> sublocationDebugObjects;

	// Token: 0x020003E4 RID: 996
	[Token(Token = "0x20003E4")]
	[Serializable]
	public class RoomDivider
	{
		// Token: 0x060016BA RID: 5818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016BA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public RoomDivider()
		{
		}

		// Token: 0x04001B9D RID: 7069
		[Token(Token = "0x4001B9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewRoom fromRoom;

		// Token: 0x04001B9E RID: 7070
		[Token(Token = "0x4001B9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewRoom toRoom;

		// Token: 0x04001B9F RID: 7071
		[Token(Token = "0x4001B9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<NewWall> dividerWalls;
	}

	// Token: 0x020003E5 RID: 997
	[Token(Token = "0x20003E5")]
	[Serializable]
	public class LightZoneData
	{
		// Token: 0x060016BB RID: 5819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016BB")]
		[Address(RVA = "0x8718D0", Offset = "0x8708D0", VA = "0x1808718D0")]
		public LightZoneData(NewRoom newRoom, List<NewNode> newNodeList)
		{
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016BC")]
		[Address(RVA = "0x872980", Offset = "0x871980", VA = "0x180872980")]
		private void FindBestLightPosition()
		{
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016BD")]
		[Address(RVA = "0x873860", Offset = "0x872860", VA = "0x180873860")]
		public void CreateMainLight()
		{
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x0000A728 File Offset: 0x00008928
		[Token(Token = "0x60016BE")]
		[Address(RVA = "0x873EA0", Offset = "0x872EA0", VA = "0x180873EA0")]
		public bool CreateAreaLight()
		{
			return default(bool);
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016BF")]
		[Address(RVA = "0x874C70", Offset = "0x873C70", VA = "0x180874C70")]
		public void RemoveAreaLight()
		{
		}

		// Token: 0x04001BA0 RID: 7072
		[Token(Token = "0x4001BA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewRoom room;

		// Token: 0x04001BA1 RID: 7073
		[Token(Token = "0x4001BA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<NewNode> nodeList;

		// Token: 0x04001BA2 RID: 7074
		[Token(Token = "0x4001BA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 centreWorldPosition;

		// Token: 0x04001BA3 RID: 7075
		[Token(Token = "0x4001BA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 lightSpawnPosition;

		// Token: 0x04001BA4 RID: 7076
		[Token(Token = "0x4001BA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2 worldSize;

		// Token: 0x04001BA5 RID: 7077
		[Token(Token = "0x4001BA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public NewNode centreNode;

		// Token: 0x04001BA6 RID: 7078
		[Token(Token = "0x4001BA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Light spawnedAreaLight;

		// Token: 0x04001BA7 RID: 7079
		[Token(Token = "0x4001BA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public HDAdditionalLightData aAdditional;

		// Token: 0x04001BA8 RID: 7080
		[Token(Token = "0x4001BA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool allowLight;

		// Token: 0x04001BA9 RID: 7081
		[Token(Token = "0x4001BA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool bestPosFound;

		// Token: 0x04001BAA RID: 7082
		[Token(Token = "0x4001BAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<string> debug;

		// Token: 0x04001BAB RID: 7083
		[Token(Token = "0x4001BAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Color areaLightColour;

		// Token: 0x04001BAC RID: 7084
		[Token(Token = "0x4001BAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float areaLightBrightness;

		// Token: 0x020003E6 RID: 998
		[Token(Token = "0x20003E6")]
		public class LightNodeRank
		{
			// Token: 0x060016C0 RID: 5824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016C0")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public LightNodeRank()
			{
			}

			// Token: 0x04001BAD RID: 7085
			[Token(Token = "0x4001BAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NewNode node;

			// Token: 0x04001BAE RID: 7086
			[Token(Token = "0x4001BAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float rank;
		}

		// Token: 0x020003E7 RID: 999
		[Token(Token = "0x20003E7")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060016C2 RID: 5826 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016C2")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c()
			{
			}

			// Token: 0x060016C3 RID: 5827 RVA: 0x0000A740 File Offset: 0x00008940
			[Token(Token = "0x60016C3")]
			[Address(RVA = "0x874EF0", Offset = "0x873EF0", VA = "0x180874EF0")]
			internal bool <FindBestLightPosition>b__15_0(AirDuctGroup.AirDuctSection item)
			{
				return default(bool);
			}

			// Token: 0x060016C4 RID: 5828 RVA: 0x0000A758 File Offset: 0x00008958
			[Token(Token = "0x60016C4")]
			[Address(RVA = "0x874F10", Offset = "0x873F10", VA = "0x180874F10")]
			internal bool <FindBestLightPosition>b__15_1(AirDuctGroup.AirDuctSection item)
			{
				return default(bool);
			}

			// Token: 0x060016C5 RID: 5829 RVA: 0x0000A770 File Offset: 0x00008970
			[Token(Token = "0x60016C5")]
			[Address(RVA = "0x874F30", Offset = "0x873F30", VA = "0x180874F30")]
			internal bool <FindBestLightPosition>b__15_2(FurnitureLocation item)
			{
				return default(bool);
			}

			// Token: 0x060016C6 RID: 5830 RVA: 0x0000A788 File Offset: 0x00008988
			[Token(Token = "0x60016C6")]
			[Address(RVA = "0x874FD0", Offset = "0x873FD0", VA = "0x180874FD0")]
			internal int <FindBestLightPosition>b__15_3(NewRoom.LightZoneData.LightNodeRank p1, NewRoom.LightZoneData.LightNodeRank p2)
			{
				return 0;
			}

			// Token: 0x04001BAF RID: 7087
			[Token(Token = "0x4001BAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly NewRoom.LightZoneData.<>c <>9;

			// Token: 0x04001BB0 RID: 7088
			[Token(Token = "0x4001BB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<AirDuctGroup.AirDuctSection> <>9__15_0;

			// Token: 0x04001BB1 RID: 7089
			[Token(Token = "0x4001BB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<AirDuctGroup.AirDuctSection> <>9__15_1;

			// Token: 0x04001BB2 RID: 7090
			[Token(Token = "0x4001BB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<FurnitureLocation> <>9__15_2;

			// Token: 0x04001BB3 RID: 7091
			[Token(Token = "0x4001BB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Comparison<NewRoom.LightZoneData.LightNodeRank> <>9__15_3;
		}
	}

	// Token: 0x020003E8 RID: 1000
	[Token(Token = "0x20003E8")]
	public struct StaticBatchKey
	{
		// Token: 0x060016C7 RID: 5831 RVA: 0x0000A7A0 File Offset: 0x000089A0
		[Token(Token = "0x60016C7")]
		[Address(RVA = "0x875060", Offset = "0x874060", VA = "0x180875060")]
		public bool Equals(NewRoom.StaticBatchKey other)
		{
			return default(bool);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x0000A7B8 File Offset: 0x000089B8
		[Token(Token = "0x60016C8")]
		[Address(RVA = "0x875130", Offset = "0x874130", VA = "0x180875130", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x0000A7D0 File Offset: 0x000089D0
		[Token(Token = "0x60016C9")]
		[Address(RVA = "0x8754F0", Offset = "0x8744F0", VA = "0x1808754F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x0000A7E8 File Offset: 0x000089E8
		[Token(Token = "0x60016CA")]
		[Address(RVA = "0x875660", Offset = "0x874660", VA = "0x180875660")]
		public static bool operator ==(NewRoom.StaticBatchKey c1, NewRoom.StaticBatchKey c2)
		{
			return default(bool);
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x0000A800 File Offset: 0x00008A00
		[Token(Token = "0x60016CB")]
		[Address(RVA = "0x875690", Offset = "0x874690", VA = "0x180875690")]
		public static bool operator !=(NewRoom.StaticBatchKey c1, NewRoom.StaticBatchKey c2)
		{
			return default(bool);
		}

		// Token: 0x04001BB4 RID: 7092
		[Token(Token = "0x4001BB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MeshFilter filter;

		// Token: 0x04001BB5 RID: 7093
		[Token(Token = "0x4001BB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Mesh mesh;

		// Token: 0x04001BB6 RID: 7094
		[Token(Token = "0x4001BB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material mat;
	}

	// Token: 0x020003E9 RID: 1001
	[Token(Token = "0x20003E9")]
	public struct PathKey : IEnumerator<object>
	{
		// Token: 0x060016CC RID: 5836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CC")]
		[Address(RVA = "0x55F910", Offset = "0x55E910", VA = "0x18055F910")]
		public PathKey(NewNode locOne, NewNode locTwo)
		{
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x0000A818 File Offset: 0x00008A18
		[Token(Token = "0x60016CD")]
		[Address(RVA = "0x8756C0", Offset = "0x8746C0", VA = "0x1808756C0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0000A830 File Offset: 0x00008A30
		[Token(Token = "0x60016CE")]
		[Address(RVA = "0x875760", Offset = "0x874760", VA = "0x180875760", Slot = "4")]
		private bool Equals(NewRoom.PathKey other)
		{
			return default(bool);
		}

		// Token: 0x04001BB7 RID: 7095
		[Token(Token = "0x4001BB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public NewNode origin;

		// Token: 0x04001BB8 RID: 7096
		[Token(Token = "0x4001BB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public NewNode destination;

		// Token: 0x04001BB9 RID: 7097
		[Token(Token = "0x4001BB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool hasHash;

		// Token: 0x04001BBA RID: 7098
		[Token(Token = "0x4001BBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int hash;
	}

	// Token: 0x020003EA RID: 1002
	[Token(Token = "0x20003EA")]
	[Serializable]
	public class CullTreeEntry
	{
		// Token: 0x060016CF RID: 5839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CF")]
		[Address(RVA = "0x3FE240", Offset = "0x3FD240", VA = "0x1803FE240")]
		public CullTreeEntry(List<int> newRequiredDoors)
		{
		}

		// Token: 0x04001BBB RID: 7099
		[Token(Token = "0x4001BBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<int> requiredOpenDoors;
	}

	// Token: 0x020003EB RID: 1003
	[Token(Token = "0x20003EB")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060016D1 RID: 5841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x0000A848 File Offset: 0x00008A48
		[Token(Token = "0x60016D2")]
		[Address(RVA = "0x875850", Offset = "0x874850", VA = "0x180875850")]
		internal bool <SetWallMaterialDefault>b__174_0(NewNode item)
		{
			return default(bool);
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x0000A860 File Offset: 0x00008A60
		[Token(Token = "0x60016D3")]
		[Address(RVA = "0x8758A0", Offset = "0x8748A0", VA = "0x1808758A0")]
		internal int <AddFurniture>b__199_2(NewAddress p1, NewAddress p2)
		{
			return 0;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x0000A878 File Offset: 0x00008A78
		[Token(Token = "0x60016D4")]
		[Address(RVA = "0x875910", Offset = "0x874910", VA = "0x180875910")]
		internal bool <AddFurniture>b__199_0(FurnitureClass item)
		{
			return default(bool);
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x0000A890 File Offset: 0x00008A90
		[Token(Token = "0x60016D5")]
		[Address(RVA = "0x875930", Offset = "0x874930", VA = "0x180875930")]
		internal bool <AddRandomAirVent>b__205_6(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		[Token(Token = "0x60016D6")]
		[Address(RVA = "0x875930", Offset = "0x874930", VA = "0x180875930")]
		internal bool <AddRandomAirVent>b__205_7(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		[Token(Token = "0x60016D7")]
		[Address(RVA = "0x875960", Offset = "0x874960", VA = "0x180875960")]
		internal bool <AddRandomAirVent>b__205_8(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		[Token(Token = "0x60016D8")]
		[Address(RVA = "0x875960", Offset = "0x874960", VA = "0x180875960")]
		internal bool <AddRandomAirVent>b__205_9(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		[Token(Token = "0x60016D9")]
		[Address(RVA = "0x875990", Offset = "0x874990", VA = "0x180875990")]
		internal bool <PickPassword>b__210_0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x0000A908 File Offset: 0x00008B08
		[Token(Token = "0x60016DA")]
		[Address(RVA = "0x875A20", Offset = "0x874A20", VA = "0x180875A20")]
		internal bool <SetSteam>b__220_0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x0000A920 File Offset: 0x00008B20
		[Token(Token = "0x60016DB")]
		[Address(RVA = "0x875A20", Offset = "0x874A20", VA = "0x180875A20")]
		internal bool <GetSecondaryLightStatus>b__248_0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04001BBC RID: 7100
		[Token(Token = "0x4001BBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NewRoom.<>c <>9;

		// Token: 0x04001BBD RID: 7101
		[Token(Token = "0x4001BBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<NewNode, bool> <>9__174_0;

		// Token: 0x04001BBE RID: 7102
		[Token(Token = "0x4001BBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Comparison<NewAddress> <>9__199_2;

		// Token: 0x04001BBF RID: 7103
		[Token(Token = "0x4001BBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<FurnitureClass> <>9__199_0;

		// Token: 0x04001BC0 RID: 7104
		[Token(Token = "0x4001BC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<NewWall> <>9__205_6;

		// Token: 0x04001BC1 RID: 7105
		[Token(Token = "0x4001BC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<NewWall> <>9__205_7;

		// Token: 0x04001BC2 RID: 7106
		[Token(Token = "0x4001BC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<NewWall> <>9__205_8;

		// Token: 0x04001BC3 RID: 7107
		[Token(Token = "0x4001BC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<NewWall> <>9__205_9;

		// Token: 0x04001BC4 RID: 7108
		[Token(Token = "0x4001BC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Predicate<Human.Trait> <>9__210_0;

		// Token: 0x04001BC5 RID: 7109
		[Token(Token = "0x4001BC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Predicate<Interactable> <>9__220_0;

		// Token: 0x04001BC6 RID: 7110
		[Token(Token = "0x4001BC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Predicate<Interactable> <>9__248_0;
	}

	// Token: 0x020003EC RID: 1004
	[Token(Token = "0x20003EC")]
	private sealed class <>c__DisplayClass182_0
	{
		// Token: 0x060016DC RID: 5852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016DC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass182_0()
		{
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0000A938 File Offset: 0x00008B38
		[Token(Token = "0x60016DD")]
		[Address(RVA = "0x4FE580", Offset = "0x4FD580", VA = "0x1804FE580")]
		internal bool <AddEntrance>b__0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x0000A950 File Offset: 0x00008B50
		[Token(Token = "0x60016DE")]
		[Address(RVA = "0x875A40", Offset = "0x874A40", VA = "0x180875A40")]
		internal bool <AddEntrance>b__1(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001BC7 RID: 7111
		[Token(Token = "0x4001BC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewNode fromNode;

		// Token: 0x04001BC8 RID: 7112
		[Token(Token = "0x4001BC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewNode toNode;
	}

	// Token: 0x020003ED RID: 1005
	[Token(Token = "0x20003ED")]
	private sealed class <>c__DisplayClass183_0
	{
		// Token: 0x060016DF RID: 5855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016DF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass183_0()
		{
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x0000A968 File Offset: 0x00008B68
		[Token(Token = "0x60016E0")]
		[Address(RVA = "0x4FE580", Offset = "0x4FD580", VA = "0x1804FE580")]
		internal bool <RemoveEntrance>b__0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x0000A980 File Offset: 0x00008B80
		[Token(Token = "0x60016E1")]
		[Address(RVA = "0x4FE580", Offset = "0x4FD580", VA = "0x1804FE580")]
		internal bool <RemoveEntrance>b__1(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x04001BC9 RID: 7113
		[Token(Token = "0x4001BC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewNode fromNode;

		// Token: 0x04001BCA RID: 7114
		[Token(Token = "0x4001BCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewNode toNode;
	}

	// Token: 0x020003EE RID: 1006
	[Token(Token = "0x20003EE")]
	private sealed class <>c__DisplayClass192_0
	{
		// Token: 0x060016E2 RID: 5858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass192_0()
		{
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x0000A998 File Offset: 0x00008B98
		[Token(Token = "0x60016E3")]
		[Address(RVA = "0x548620", Offset = "0x547620", VA = "0x180548620")]
		internal bool <ConnectNodes>b__0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001BCB RID: 7115
		[Token(Token = "0x4001BCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2Int v2;
	}

	// Token: 0x020003EF RID: 1007
	[Token(Token = "0x20003EF")]
	private sealed class <>c__DisplayClass192_1
	{
		// Token: 0x060016E4 RID: 5860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass192_1()
		{
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		[Token(Token = "0x60016E5")]
		[Address(RVA = "0x875AA0", Offset = "0x874AA0", VA = "0x180875AA0")]
		internal bool <ConnectNodes>b__1(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		[Token(Token = "0x60016E6")]
		[Address(RVA = "0x875AA0", Offset = "0x874AA0", VA = "0x180875AA0")]
		internal bool <ConnectNodes>b__2(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001BCC RID: 7116
		[Token(Token = "0x4001BCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 offset1;

		// Token: 0x04001BCD RID: 7117
		[Token(Token = "0x4001BCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 offset2;
	}

	// Token: 0x020003F0 RID: 1008
	[Token(Token = "0x20003F0")]
	private sealed class <>c__DisplayClass195_0
	{
		// Token: 0x060016E7 RID: 5863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass195_0()
		{
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		[Token(Token = "0x60016E8")]
		[Address(RVA = "0x875B10", Offset = "0x874B10", VA = "0x180875B10")]
		internal bool <SpawnDebugCullingObject>b__0(CullingDebugController item)
		{
			return default(bool);
		}

		// Token: 0x04001BCE RID: 7118
		[Token(Token = "0x4001BCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 worldPos;
	}

	// Token: 0x020003F1 RID: 1009
	[Token(Token = "0x20003F1")]
	private sealed class <>c__DisplayClass199_0
	{
		// Token: 0x060016E9 RID: 5865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass199_0()
		{
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		[Token(Token = "0x60016EA")]
		[Address(RVA = "0x875C30", Offset = "0x874C30", VA = "0x180875C30")]
		internal bool <AddFurniture>b__1(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x04001BCF RID: 7119
		[Token(Token = "0x4001BCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurnitureLocation obj;
	}

	// Token: 0x020003F2 RID: 1010
	[Token(Token = "0x20003F2")]
	private sealed class <>c__DisplayClass199_1
	{
		// Token: 0x060016EB RID: 5867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass199_1()
		{
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0000AA10 File Offset: 0x00008C10
		[Token(Token = "0x60016EC")]
		[Address(RVA = "0x875C80", Offset = "0x874C80", VA = "0x180875C80")]
		internal bool <AddFurniture>b__3(Human item)
		{
			return default(bool);
		}

		// Token: 0x04001BD0 RID: 7120
		[Token(Token = "0x4001BD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human h;
	}

	// Token: 0x020003F3 RID: 1011
	[Token(Token = "0x20003F3")]
	private sealed class <>c__DisplayClass199_2
	{
		// Token: 0x060016ED RID: 5869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass199_2()
		{
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x0000AA28 File Offset: 0x00008C28
		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x875E40", Offset = "0x874E40", VA = "0x180875E40")]
		internal bool <AddFurniture>b__4(FurniturePreset.IntegratedInteractable item)
		{
			return default(bool);
		}

		// Token: 0x04001BD1 RID: 7121
		[Token(Token = "0x4001BD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human human;
	}

	// Token: 0x020003F4 RID: 1012
	[Token(Token = "0x20003F4")]
	private sealed class <>c__DisplayClass199_3
	{
		// Token: 0x060016EF RID: 5871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016EF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass199_3()
		{
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x0000AA40 File Offset: 0x00008C40
		[Token(Token = "0x60016F0")]
		[Address(RVA = "0x8634F0", Offset = "0x8624F0", VA = "0x1808634F0")]
		internal bool <AddFurniture>b__5(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001BD2 RID: 7122
		[Token(Token = "0x4001BD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 rotatedWallOffset;
	}

	// Token: 0x020003F5 RID: 1013
	[Token(Token = "0x20003F5")]
	private sealed class <>c__DisplayClass205_0
	{
		// Token: 0x060016F1 RID: 5873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass205_0()
		{
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x0000AA58 File Offset: 0x00008C58
		[Token(Token = "0x60016F2")]
		[Address(RVA = "0x875E90", Offset = "0x874E90", VA = "0x180875E90")]
		internal bool <AddRandomAirVent>b__0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x0000AA70 File Offset: 0x00008C70
		[Token(Token = "0x60016F3")]
		[Address(RVA = "0x875EC0", Offset = "0x874EC0", VA = "0x180875EC0")]
		internal bool <AddRandomAirVent>b__1(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x04001BD3 RID: 7123
		[Token(Token = "0x4001BD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewNode node;
	}

	// Token: 0x020003F6 RID: 1014
	[Token(Token = "0x20003F6")]
	private sealed class <>c__DisplayClass205_1
	{
		// Token: 0x060016F4 RID: 5876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass205_1()
		{
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x0000AA88 File Offset: 0x00008C88
		[Token(Token = "0x60016F5")]
		[Address(RVA = "0x875EE0", Offset = "0x874EE0", VA = "0x180875EE0")]
		internal bool <AddRandomAirVent>b__2(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x04001BD4 RID: 7124
		[Token(Token = "0x4001BD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewWall wall;
	}

	// Token: 0x020003F7 RID: 1015
	[Token(Token = "0x20003F7")]
	private sealed class <>c__DisplayClass205_2
	{
		// Token: 0x060016F6 RID: 5878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016F6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass205_2()
		{
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		[Token(Token = "0x60016F7")]
		[Address(RVA = "0x875F20", Offset = "0x874F20", VA = "0x180875F20")]
		internal bool <AddRandomAirVent>b__3(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		[Token(Token = "0x60016F8")]
		[Address(RVA = "0x875F20", Offset = "0x874F20", VA = "0x180875F20")]
		internal bool <AddRandomAirVent>b__4(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		[Token(Token = "0x60016F9")]
		[Address(RVA = "0x875F60", Offset = "0x874F60", VA = "0x180875F60")]
		internal bool <AddRandomAirVent>b__5(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x04001BD5 RID: 7125
		[Token(Token = "0x4001BD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewWall wall;
	}

	// Token: 0x020003F8 RID: 1016
	[Token(Token = "0x20003F8")]
	private sealed class <>c__DisplayClass252_0
	{
		// Token: 0x060016FA RID: 5882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016FA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass252_0()
		{
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		[Token(Token = "0x60016FB")]
		[Address(RVA = "0x875FC0", Offset = "0x874FC0", VA = "0x180875FC0")]
		internal bool <ExecuteLightswitchesOverrides>b__0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04001BD6 RID: 7126
		[Token(Token = "0x4001BD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StateSaveData.ChangedLightswitch ls;
	}
}
