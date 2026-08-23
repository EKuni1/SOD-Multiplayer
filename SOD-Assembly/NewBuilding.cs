using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020003B5 RID: 949
[Token(Token = "0x20003B5")]
public class NewBuilding : Controller
{
	// Token: 0x0600153B RID: 5435 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600153B")]
	[Address(RVA = "0x7EC650", Offset = "0x7EB650", VA = "0x1807EC650")]
	public void AddNewFloor(NewFloor newFloor)
	{
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600153C")]
	[Address(RVA = "0x7ECBD0", Offset = "0x7EBBD0", VA = "0x1807ECBD0")]
	public void Setup(CityTile newGroundmap, BuildingPreset newpreset, bool setupExistingBuilding = false, int replaceBuildingID = 0)
	{
	}

	// Token: 0x0600153D RID: 5437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600153D")]
	[Address(RVA = "0x7ED610", Offset = "0x7EC610", VA = "0x1807ED610")]
	public void RemoveBuilding()
	{
	}

	// Token: 0x0600153E RID: 5438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600153E")]
	[Address(RVA = "0x7ED920", Offset = "0x7EC920", VA = "0x1807ED920")]
	public void Load(CitySaveData.BuildingCitySave data, CityTile newCityTile)
	{
	}

	// Token: 0x0600153F RID: 5439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600153F")]
	[Address(RVA = "0x7EE4F0", Offset = "0x7ED4F0", VA = "0x1807EE4F0")]
	private void SetupModel()
	{
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001540")]
	[Address(RVA = "0x7EF800", Offset = "0x7EE800", VA = "0x1807EF800")]
	public void DrawGroundFloorBuildingModel()
	{
	}

	// Token: 0x06001541 RID: 5441 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001541")]
	[Address(RVA = "0x7F1950", Offset = "0x7F0950", VA = "0x1807F1950")]
	private GameObject CombineGroundFloorMeshes(ref List<MeshFilter> childMeshes, string objectName)
	{
		return null;
	}

	// Token: 0x06001542 RID: 5442 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001542")]
	[Address(RVA = "0x7F1ED0", Offset = "0x7F0ED0", VA = "0x1807F1ED0")]
	private List<NewWall.FrontageSetting> SelectFrontage(RoomConfiguration roomConfig, DoorPairPreset wallPreset)
	{
		return null;
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001543")]
	[Address(RVA = "0x7F2540", Offset = "0x7F1540", VA = "0x1807F2540")]
	public void RemoveGroundFloorBuildingModel()
	{
	}

	// Token: 0x06001544 RID: 5444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001544")]
	[Address(RVA = "0x7F2670", Offset = "0x7F1670", VA = "0x1807F2670")]
	private void SetupEmissionTexture()
	{
	}

	// Token: 0x06001545 RID: 5445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001545")]
	[Address(RVA = "0x7F3060", Offset = "0x7F2060", VA = "0x1807F3060")]
	public void SetTargetMode(NewBuilding.AlarmTargetMode newMode, bool setResetTimer = true)
	{
	}

	// Token: 0x06001546 RID: 5446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001546")]
	[Address(RVA = "0x7F3260", Offset = "0x7F2260", VA = "0x1807F3260")]
	private void SetupEnvironment()
	{
	}

	// Token: 0x06001547 RID: 5447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001547")]
	[Address(RVA = "0x7F33E0", Offset = "0x7F23E0", VA = "0x1807F33E0")]
	public void UpdateColourSchemeAndMaterials()
	{
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001548")]
	[Address(RVA = "0x7F4750", Offset = "0x7F3750", VA = "0x1807F4750")]
	public void LoadInterior()
	{
	}

	// Token: 0x06001549 RID: 5449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001549")]
	[Address(RVA = "0x7F70D0", Offset = "0x7F60D0", VA = "0x1807F70D0")]
	public void AddBuildingEntrance(NewWall wallTile, bool isMain = false)
	{
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x00009ED0 File Offset: 0x000080D0
	[Token(Token = "0x600154A")]
	[Address(RVA = "0x7F77F0", Offset = "0x7F67F0", VA = "0x1807F77F0")]
	public Vector2Int FaceLocalTileVector(Vector2Int r)
	{
		return default(Vector2Int);
	}

	// Token: 0x0600154B RID: 5451 RVA: 0x00009EE8 File Offset: 0x000080E8
	[Token(Token = "0x600154B")]
	[Address(RVA = "0x7F7B20", Offset = "0x7F6B20", VA = "0x1807F7B20")]
	public Vector2Int FaceLocalNodeVector(Vector2Int r)
	{
		return default(Vector2Int);
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x00009F00 File Offset: 0x00008100
	[Token(Token = "0x600154C")]
	[Address(RVA = "0x7F7F50", Offset = "0x7F6F50", VA = "0x1807F7F50")]
	public Vector2 FaceWallOffsetVector(Vector2 r)
	{
		return default(Vector2);
	}

	// Token: 0x0600154D RID: 5453 RVA: 0x00009F18 File Offset: 0x00008118
	[Token(Token = "0x600154D")]
	[Address(RVA = "0x7F8040", Offset = "0x7F7040", VA = "0x1807F8040")]
	public Vector2 GetOriginalWallOffset(Vector2 r)
	{
		return default(Vector2);
	}

	// Token: 0x0600154E RID: 5454 RVA: 0x00009F30 File Offset: 0x00008130
	[Token(Token = "0x600154E")]
	[Address(RVA = "0x7F8130", Offset = "0x7F7130", VA = "0x1807F8130")]
	public Vector3 LocalToGlobalPathmap(Vector3 r)
	{
		return default(Vector3);
	}

	// Token: 0x0600154F RID: 5455 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600154F")]
	[Address(RVA = "0x7F8280", Offset = "0x7F7280", VA = "0x1807F8280")]
	public void CalculateFacing()
	{
	}

	// Token: 0x06001550 RID: 5456 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001550")]
	[Address(RVA = "0x7F88E0", Offset = "0x7F78E0", VA = "0x1807F88E0")]
	private void CalculateRotations()
	{
	}

	// Token: 0x06001551 RID: 5457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001551")]
	[Address(RVA = "0x7F8930", Offset = "0x7F7930", VA = "0x1807F8930")]
	public void SetFacing(NewBuilding.Direction face, bool updateBuildingModel = true)
	{
	}

	// Token: 0x06001552 RID: 5458 RVA: 0x00009F48 File Offset: 0x00008148
	[Token(Token = "0x6001552")]
	[Address(RVA = "0x7F8B60", Offset = "0x7F7B60", VA = "0x1807F8B60")]
	public Vector3 GetBuildingEuler()
	{
		return default(Vector3);
	}

	// Token: 0x06001553 RID: 5459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001553")]
	[Address(RVA = "0x7F8BB0", Offset = "0x7F7BB0", VA = "0x1807F8BB0")]
	public void SetInaccessible()
	{
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001554")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "4")]
	public override void SetupEvidence()
	{
	}

	// Token: 0x06001555 RID: 5461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001555")]
	[Address(RVA = "0x7F8BC0", Offset = "0x7F7BC0", VA = "0x1807F8BC0")]
	public void AddLobby(NewAddress newLob)
	{
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001556")]
	[Address(RVA = "0x7F8C70", Offset = "0x7F7C70", VA = "0x1807F8C70")]
	public void SetDisplayBuildingModel(bool vis, bool coll, [Optional] List<string> hideModelChildOverride)
	{
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001557")]
	[Address(RVA = "0x7F9050", Offset = "0x7F8050", VA = "0x1807F9050")]
	public void SelectivelyHideModels(List<string> hideModelChildOverride)
	{
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001558")]
	[Address(RVA = "0x7F9430", Offset = "0x7F8430", VA = "0x1807F9430")]
	public void ResetSelectivelyHidden()
	{
	}

	// Token: 0x06001559 RID: 5465 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001559")]
	[Address(RVA = "0x7F9620", Offset = "0x7F8620", VA = "0x1807F9620")]
	public void SpawnStreetCables()
	{
	}

	// Token: 0x0600155A RID: 5466 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600155A")]
	[Address(RVA = "0x7FB910", Offset = "0x7FA910", VA = "0x1807FB910")]
	public void SpawnNeonSideSigns()
	{
	}

	// Token: 0x0600155B RID: 5467 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600155B")]
	[Address(RVA = "0x7FC250", Offset = "0x7FB250", VA = "0x1807FC250")]
	public void GenerateAirDucts()
	{
	}

	// Token: 0x0600155C RID: 5468 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600155C")]
	[Address(RVA = "0x7FF870", Offset = "0x7FE870", VA = "0x1807FF870")]
	public Elevator AddStairwellSystem(NewTile newTile, StairwellPreset stairPreset)
	{
		return null;
	}

	// Token: 0x0600155D RID: 5469 RVA: 0x00009F60 File Offset: 0x00008160
	[Token(Token = "0x600155D")]
	[Address(RVA = "0x7FFC30", Offset = "0x7FEC30", VA = "0x1807FFC30")]
	public int CompareTo(NewBuilding otherObject)
	{
		return 0;
	}

	// Token: 0x0600155E RID: 5470 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600155E")]
	[Address(RVA = "0x7FFCE0", Offset = "0x7FECE0", VA = "0x1807FFCE0")]
	public CitySaveData.BuildingCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x0600155F RID: 5471 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600155F")]
	[Address(RVA = "0x800660", Offset = "0x7FF660", VA = "0x180800660")]
	public void UpdateName(bool forceTrueRandom = false)
	{
	}

	// Token: 0x06001560 RID: 5472 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001560")]
	[Address(RVA = "0x8021B0", Offset = "0x8011B0", VA = "0x1808021B0", Slot = "5")]
	public override void CreateEvidence()
	{
	}

	// Token: 0x06001561 RID: 5473 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001561")]
	[Address(RVA = "0x8024B0", Offset = "0x8014B0", VA = "0x1808024B0")]
	public void SetAlarm(bool newVal, Human target, NewFloor forFloor)
	{
	}

	// Token: 0x06001562 RID: 5474 RVA: 0x00009F78 File Offset: 0x00008178
	[Token(Token = "0x6001562")]
	[Address(RVA = "0x7E65C0", Offset = "0x7E55C0", VA = "0x1807E65C0")]
	public float GetAlarmTime()
	{
		return 0f;
	}

	// Token: 0x06001563 RID: 5475 RVA: 0x00009F90 File Offset: 0x00008190
	[Token(Token = "0x6001563")]
	[Address(RVA = "0x803710", Offset = "0x802710", VA = "0x180803710")]
	public bool IsAlarmSystemTarget(Human human)
	{
		return default(bool);
	}

	// Token: 0x06001564 RID: 5476 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001564")]
	[Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0")]
	public void AddSecurityCamera(Interactable newInteractable)
	{
	}

	// Token: 0x06001565 RID: 5477 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001565")]
	[Address(RVA = "0x803B00", Offset = "0x802B00", VA = "0x180803B00")]
	public void AddSentryGun(Interactable newInteractable)
	{
	}

	// Token: 0x06001566 RID: 5478 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001566")]
	[Address(RVA = "0x803B60", Offset = "0x802B60", VA = "0x180803B60")]
	public void AddOtherSecurity(Interactable newInteractable)
	{
	}

	// Token: 0x06001567 RID: 5479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001567")]
	[Address(RVA = "0x63A040", Offset = "0x639040", VA = "0x18063A040")]
	public void SetExteriorWallMaterialDefault(MaterialGroupPreset newMat)
	{
	}

	// Token: 0x06001568 RID: 5480 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001568")]
	[Address(RVA = "0x803BC0", Offset = "0x802BC0", VA = "0x180803BC0")]
	public List<Vector3Int> GetVentRoute(Vector3Int origin, Vector3Int destination, ref Dictionary<Vector3Int, NewBuilding.DuctPlacementData> placedDucts)
	{
		return null;
	}

	// Token: 0x06001569 RID: 5481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001569")]
	[Address(RVA = "0x8056F0", Offset = "0x8046F0", VA = "0x1808056F0")]
	public void CalculateDirectionalCullingTrees()
	{
	}

	// Token: 0x0600156A RID: 5482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600156A")]
	[Address(RVA = "0x807500", Offset = "0x806500", VA = "0x180807500")]
	public void CountResidences()
	{
	}

	// Token: 0x0600156B RID: 5483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600156B")]
	[Address(RVA = "0x8078C0", Offset = "0x8068C0", VA = "0x1808078C0")]
	public void TriggerAlarmPASounds()
	{
	}

	// Token: 0x0600156C RID: 5484 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600156C")]
	[Address(RVA = "0x8081D0", Offset = "0x8071D0", VA = "0x1808081D0")]
	public void UpdateAlarmPAWindowDistance(float val)
	{
	}

	// Token: 0x0600156D RID: 5485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600156D")]
	[Address(RVA = "0x808480", Offset = "0x807480", VA = "0x180808480")]
	public void UpdateAlarmPAExternalDoorDistance(float val)
	{
	}

	// Token: 0x0600156E RID: 5486 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600156E")]
	[Address(RVA = "0x808730", Offset = "0x807730", VA = "0x180808730")]
	public void UpdateAlarmPAIntExt(float val)
	{
	}

	// Token: 0x0600156F RID: 5487 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600156F")]
	[Address(RVA = "0x8089E0", Offset = "0x8079E0", VA = "0x1808089E0")]
	private List<AudioController.FMODParam> GetAlarmPAParams()
	{
		return null;
	}

	// Token: 0x06001570 RID: 5488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001570")]
	[Address(RVA = "0x808EA0", Offset = "0x807EA0", VA = "0x180808EA0")]
	public void StopAlarmPASounds()
	{
	}

	// Token: 0x06001571 RID: 5489 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001571")]
	[Address(RVA = "0x809080", Offset = "0x808080", VA = "0x180809080")]
	public void TriggerNewLostAndFound()
	{
	}

	// Token: 0x06001572 RID: 5490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001572")]
	[Address(RVA = "0x80B030", Offset = "0x80A030", VA = "0x18080B030")]
	public void CompleteLostAndFound(Citizen owner, InteractablePreset itemType, bool giveReward = true)
	{
	}

	// Token: 0x06001573 RID: 5491 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001573")]
	[Address(RVA = "0x80B5E0", Offset = "0x80A5E0", VA = "0x18080B5E0")]
	private IEnumerator PayLostAndFoundReward(GameplayController.LostAndFound f)
	{
		return null;
	}

	// Token: 0x06001574 RID: 5492 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001574")]
	[Address(RVA = "0x80B680", Offset = "0x80A680", VA = "0x18080B680")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001575 RID: 5493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001575")]
	[Address(RVA = "0x80B890", Offset = "0x80A890", VA = "0x18080B890")]
	public NewBuilding()
	{
	}

	// Token: 0x06001577 RID: 5495 RVA: 0x00009FA8 File Offset: 0x000081A8
	[Token(Token = "0x6001577")]
	[Address(RVA = "0x80C9C0", Offset = "0x80B9C0", VA = "0x18080C9C0")]
	private bool <LoadInterior>b__86_0(CitySaveData.CityTileCitySave item)
	{
		return default(bool);
	}

	// Token: 0x06001578 RID: 5496 RVA: 0x00009FC0 File Offset: 0x000081C0
	[Token(Token = "0x6001578")]
	[Address(RVA = "0x80CA10", Offset = "0x80BA10", VA = "0x18080CA10")]
	private bool <UpdateName>b__110_0(NewBuilding item)
	{
		return default(bool);
	}

	// Token: 0x06001579 RID: 5497 RVA: 0x00009FD8 File Offset: 0x000081D8
	[Token(Token = "0x6001579")]
	[Address(RVA = "0x80CC00", Offset = "0x80BC00", VA = "0x18080CC00")]
	private bool <TriggerNewLostAndFound>b__128_0(InteractablePreset item)
	{
		return default(bool);
	}

	// Token: 0x0600157A RID: 5498 RVA: 0x00009FF0 File Offset: 0x000081F0
	[Token(Token = "0x600157A")]
	[Address(RVA = "0x80CD60", Offset = "0x80BD60", VA = "0x18080CD60")]
	private bool <TriggerNewLostAndFound>b__128_1(Citizen item)
	{
		return default(bool);
	}

	// Token: 0x040019BC RID: 6588
	[Token(Token = "0x40019BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int buildingID;

	// Token: 0x040019BD RID: 6589
	[Token(Token = "0x40019BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int assignID;

	// Token: 0x040019BE RID: 6590
	[Token(Token = "0x40019BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string seed;

	// Token: 0x040019BF RID: 6591
	[Token(Token = "0x40019BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isPlayerEditedName;

	// Token: 0x040019C0 RID: 6592
	[Token(Token = "0x40019C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string playerEditedBuildingName;

	// Token: 0x040019C1 RID: 6593
	[Token(Token = "0x40019C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Dictionary<int, NewFloor> floors;

	// Token: 0x040019C2 RID: 6594
	[Token(Token = "0x40019C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<NewAddress> lobbies;

	// Token: 0x040019C3 RID: 6595
	[Token(Token = "0x40019C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<GameObject> spawnedCables;

	// Token: 0x040019C4 RID: 6596
	[Token(Token = "0x40019C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<NewBuilding.SideSign> sideSigns;

	// Token: 0x040019C5 RID: 6597
	[Token(Token = "0x40019C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<AirDuctGroup> airDucts;

	// Token: 0x040019C6 RID: 6598
	[Token(Token = "0x40019C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Dictionary<Vector3Int, AirDuctGroup.AirDuctSection> ductMap;

	// Token: 0x040019C7 RID: 6599
	[Token(Token = "0x40019C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Interactable> alarms;

	// Token: 0x040019C8 RID: 6600
	[Token(Token = "0x40019C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<Interactable> sentryGuns;

	// Token: 0x040019C9 RID: 6601
	[Token(Token = "0x40019C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<Interactable> otherSecurity;

	// Token: 0x040019CA RID: 6602
	[Token(Token = "0x40019CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool alarmActive;

	// Token: 0x040019CB RID: 6603
	[Token(Token = "0x40019CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public NewBuilding.AlarmTargetMode targetMode;

	// Token: 0x040019CC RID: 6604
	[Token(Token = "0x40019CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float targetModeSetAt;

	// Token: 0x040019CD RID: 6605
	[Token(Token = "0x40019CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<Human> alarmTargets;

	// Token: 0x040019CE RID: 6606
	[Token(Token = "0x40019CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float alarmTimer;

	// Token: 0x040019CF RID: 6607
	[Token(Token = "0x40019CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<Interactable> securityCameras;

	// Token: 0x040019D0 RID: 6608
	[Token(Token = "0x40019D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float wantedInBuilding;

	// Token: 0x040019D1 RID: 6609
	[Token(Token = "0x40019D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<AudioController.LoopingSoundInfo> alarmPALoops;

	// Token: 0x040019D2 RID: 6610
	[Token(Token = "0x40019D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Dictionary<Vector2, Dictionary<NewRoom, List<NewRoom.CullTreeEntry>>> directionalCullingTrees;

	// Token: 0x040019D3 RID: 6611
	[Token(Token = "0x40019D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public MaterialGroupPreset extWallMaterial;

	// Token: 0x040019D4 RID: 6612
	[Token(Token = "0x40019D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Material extMat;

	// Token: 0x040019D5 RID: 6613
	[Token(Token = "0x40019D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Dictionary<Vector3Int, NewNode> validVentSpace;

	// Token: 0x040019D6 RID: 6614
	[Token(Token = "0x40019D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject buildingModelBase;

	// Token: 0x040019D7 RID: 6615
	[Token(Token = "0x40019D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public List<GameObject> buildingModelsActual;

	// Token: 0x040019D8 RID: 6616
	[Token(Token = "0x40019D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<GameObject> buildingModelsLights;

	// Token: 0x040019D9 RID: 6617
	[Token(Token = "0x40019D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<Collider> colliders;

	// Token: 0x040019DA RID: 6618
	[Token(Token = "0x40019DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Transform environmentalSettingsObject;

	// Token: 0x040019DB RID: 6619
	[Token(Token = "0x40019DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool displayBuildingModel;

	// Token: 0x040019DC RID: 6620
	[Token(Token = "0x40019DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
	public bool activeColliders;

	// Token: 0x040019DD RID: 6621
	[Token(Token = "0x40019DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private List<GameObject> selectivelyHidden;

	// Token: 0x040019DE RID: 6622
	[Token(Token = "0x40019DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public List<Collider> snowColliders;

	// Token: 0x040019DF RID: 6623
	[Token(Token = "0x40019DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public GameObject cityEditorGroundFloorRepresentation;

	// Token: 0x040019E0 RID: 6624
	[Token(Token = "0x40019E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public int interiorLightCullingLayer;

	// Token: 0x040019E1 RID: 6625
	[Token(Token = "0x40019E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public List<LightController> allInteriorMainLights;

	// Token: 0x040019E2 RID: 6626
	[Token(Token = "0x40019E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public BuildingPreset preset;

	// Token: 0x040019E3 RID: 6627
	[Token(Token = "0x40019E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public int rotations;

	// Token: 0x040019E4 RID: 6628
	[Token(Token = "0x40019E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public NewBuilding.Direction facing;

	// Token: 0x040019E5 RID: 6629
	[Token(Token = "0x40019E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public CityTile cityTile;

	// Token: 0x040019E6 RID: 6630
	[Token(Token = "0x40019E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Vector3Int globalTileCoords;

	// Token: 0x040019E7 RID: 6631
	[Token(Token = "0x40019E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public bool isInaccessible;

	// Token: 0x040019E8 RID: 6632
	[Token(Token = "0x40019E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private float distance;

	// Token: 0x040019E9 RID: 6633
	[Token(Token = "0x40019E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	public Vector3 worldPosition;

	// Token: 0x040019EA RID: 6634
	[Token(Token = "0x40019EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public NewWall mainEntrance;

	// Token: 0x040019EB RID: 6635
	[Token(Token = "0x40019EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public StreetController street;

	// Token: 0x040019EC RID: 6636
	[Token(Token = "0x40019EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public List<NewWall> additionalEntrances;

	// Token: 0x040019ED RID: 6637
	[Token(Token = "0x40019ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public Dictionary<NewTile, Elevator> stairwells;

	// Token: 0x040019EE RID: 6638
	[Token(Token = "0x40019EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public Texture2D emissionTextureInstanced;

	// Token: 0x040019EF RID: 6639
	[Token(Token = "0x40019EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public Texture2D emissionTextureUnlit;

	// Token: 0x040019F0 RID: 6640
	[Token(Token = "0x40019F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public Volume volume;

	// Token: 0x040019F1 RID: 6641
	[Token(Token = "0x40019F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	[NonSerialized]
	public EvidenceBuilding evidenceEntry;

	// Token: 0x040019F2 RID: 6642
	[Token(Token = "0x40019F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[NonSerialized]
	public EvidenceMultiPage residentRoster;

	// Token: 0x040019F3 RID: 6643
	[Token(Token = "0x40019F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public List<TelephoneController.PhoneCall> callLog;

	// Token: 0x040019F4 RID: 6644
	[Token(Token = "0x40019F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public DesignStylePreset designStyle;

	// Token: 0x040019F5 RID: 6645
	[Token(Token = "0x40019F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public Color wood;

	// Token: 0x040019F6 RID: 6646
	[Token(Token = "0x40019F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public MaterialGroupPreset floorMaterial;

	// Token: 0x040019F7 RID: 6647
	[Token(Token = "0x40019F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public Toolbox.MaterialKey floorMatKey;

	// Token: 0x040019F8 RID: 6648
	[Token(Token = "0x40019F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public MaterialGroupPreset ceilingMaterial;

	// Token: 0x040019F9 RID: 6649
	[Token(Token = "0x40019F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public Toolbox.MaterialKey ceilingMatKey;

	// Token: 0x040019FA RID: 6650
	[Token(Token = "0x40019FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public MaterialGroupPreset defaultWallMaterial;

	// Token: 0x040019FB RID: 6651
	[Token(Token = "0x40019FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public Toolbox.MaterialKey defaultWallKey;

	// Token: 0x040019FC RID: 6652
	[Token(Token = "0x40019FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public ColourSchemePreset colourScheme;

	// Token: 0x040019FD RID: 6653
	[Token(Token = "0x40019FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public NewAddress nameOverride;

	// Token: 0x040019FE RID: 6654
	[Token(Token = "0x40019FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private Material weatherMaterial;

	// Token: 0x040019FF RID: 6655
	[Token(Token = "0x40019FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public List<GameplayController.LostAndFound> lostAndFound;

	// Token: 0x04001A00 RID: 6656
	[Token(Token = "0x4001A00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public List<string> debugDecor;

	// Token: 0x04001A01 RID: 6657
	[Token(Token = "0x4001A01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Comparison<NewBuilding> DistanceComparison;

	// Token: 0x020003B6 RID: 950
	[Token(Token = "0x20003B6")]
	public enum AlarmTargetMode
	{
		// Token: 0x04001A03 RID: 6659
		[Token(Token = "0x4001A03")]
		illegalActivities,
		// Token: 0x04001A04 RID: 6660
		[Token(Token = "0x4001A04")]
		notPlayer,
		// Token: 0x04001A05 RID: 6661
		[Token(Token = "0x4001A05")]
		nonResidents,
		// Token: 0x04001A06 RID: 6662
		[Token(Token = "0x4001A06")]
		everybody,
		// Token: 0x04001A07 RID: 6663
		[Token(Token = "0x4001A07")]
		nobody
	}

	// Token: 0x020003B7 RID: 951
	[Token(Token = "0x20003B7")]
	public class DuctPlacementData
	{
		// Token: 0x0600157B RID: 5499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DuctPlacementData()
		{
		}

		// Token: 0x04001A08 RID: 6664
		[Token(Token = "0x4001A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AirDuctGroup.AirVent originVent;

		// Token: 0x04001A09 RID: 6665
		[Token(Token = "0x4001A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AirDuctGroup.AirVent destinationVent;

		// Token: 0x04001A0A RID: 6666
		[Token(Token = "0x4001A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3Int previous;

		// Token: 0x04001A0B RID: 6667
		[Token(Token = "0x4001A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3Int next;
	}

	// Token: 0x020003B8 RID: 952
	[Token(Token = "0x20003B8")]
	[Serializable]
	public class SideSign
	{
		// Token: 0x0600157C RID: 5500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public SideSign()
		{
		}

		// Token: 0x04001A0C RID: 6668
		[Token(Token = "0x4001A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int anchorPointIndex;

		// Token: 0x04001A0D RID: 6669
		[Token(Token = "0x4001A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int signPrefabIndex;
	}

	// Token: 0x020003B9 RID: 953
	[Token(Token = "0x20003B9")]
	public enum Direction
	{
		// Token: 0x04001A0F RID: 6671
		[Token(Token = "0x4001A0F")]
		North,
		// Token: 0x04001A10 RID: 6672
		[Token(Token = "0x4001A10")]
		East,
		// Token: 0x04001A11 RID: 6673
		[Token(Token = "0x4001A11")]
		South,
		// Token: 0x04001A12 RID: 6674
		[Token(Token = "0x4001A12")]
		West
	}

	// Token: 0x020003BA RID: 954
	[Token(Token = "0x20003BA")]
	private sealed class <>c__DisplayClass74_0
	{
		// Token: 0x0600157D RID: 5501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass74_0()
		{
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0000A008 File Offset: 0x00008208
		[Token(Token = "0x600157E")]
		[Address(RVA = "0x80D810", Offset = "0x80C810", VA = "0x18080D810")]
		internal bool <Setup>b__0(NewBuilding x)
		{
			return default(bool);
		}

		// Token: 0x04001A13 RID: 6675
		[Token(Token = "0x4001A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int replaceBuildingID;
	}

	// Token: 0x020003BB RID: 955
	[Token(Token = "0x20003BB")]
	private sealed class <>c__DisplayClass78_0
	{
		// Token: 0x0600157F RID: 5503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass78_0()
		{
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x0000A020 File Offset: 0x00008220
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x80D830", Offset = "0x80C830", VA = "0x18080D830")]
		internal bool <DrawGroundFloorBuildingModel>b__0(AddressPreset item)
		{
			return default(bool);
		}

		// Token: 0x04001A14 RID: 6676
		[Token(Token = "0x4001A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutConfiguration layoutPreset;
	}

	// Token: 0x020003BC RID: 956
	[Token(Token = "0x20003BC")]
	private sealed class <>c__DisplayClass78_1
	{
		// Token: 0x06001581 RID: 5505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass78_1()
		{
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x0000A038 File Offset: 0x00008238
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <DrawGroundFloorBuildingModel>b__1(RoomConfiguration item)
		{
			return default(bool);
		}

		// Token: 0x04001A15 RID: 6677
		[Token(Token = "0x4001A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RoomTypePreset config;
	}

	// Token: 0x020003BD RID: 957
	[Token(Token = "0x20003BD")]
	private sealed class <>c__DisplayClass86_0
	{
		// Token: 0x06001583 RID: 5507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001583")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass86_0()
		{
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x0000A050 File Offset: 0x00008250
		[Token(Token = "0x6001584")]
		[Address(RVA = "0x80D8C0", Offset = "0x80C8C0", VA = "0x18080D8C0")]
		internal bool <LoadInterior>b__1(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04001A16 RID: 6678
		[Token(Token = "0x4001A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CitySaveData.WallCitySave wallData;
	}

	// Token: 0x020003BE RID: 958
	[Token(Token = "0x20003BE")]
	private sealed class <>c__DisplayClass86_1
	{
		// Token: 0x06001585 RID: 5509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001585")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass86_1()
		{
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0000A068 File Offset: 0x00008268
		[Token(Token = "0x6001586")]
		[Address(RVA = "0x51E9E0", Offset = "0x51D9E0", VA = "0x18051E9E0")]
		internal bool <LoadInterior>b__2(AirDuctGroup item)
		{
			return default(bool);
		}

		// Token: 0x04001A17 RID: 6679
		[Token(Token = "0x4001A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CitySaveData.AirDuctGroupCitySave airDuct;
	}

	// Token: 0x020003BF RID: 959
	[Token(Token = "0x20003BF")]
	private sealed class <>c__DisplayClass86_2
	{
		// Token: 0x06001587 RID: 5511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001587")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass86_2()
		{
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0000A080 File Offset: 0x00008280
		[Token(Token = "0x6001588")]
		[Address(RVA = "0x80D810", Offset = "0x80C810", VA = "0x18080D810")]
		internal bool <LoadInterior>b__3(AirDuctGroup item)
		{
			return default(bool);
		}

		// Token: 0x04001A18 RID: 6680
		[Token(Token = "0x4001A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int adj;
	}

	// Token: 0x020003C0 RID: 960
	[Token(Token = "0x20003C0")]
	private sealed class <>c__DisplayClass86_3
	{
		// Token: 0x06001589 RID: 5513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001589")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass86_3()
		{
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0000A098 File Offset: 0x00008298
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x80D8F0", Offset = "0x80C8F0", VA = "0x18080D8F0")]
		internal bool <LoadInterior>b__4(NewTile item)
		{
			return default(bool);
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0000A0B0 File Offset: 0x000082B0
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x80D950", Offset = "0x80C950", VA = "0x18080D950")]
		internal bool <LoadInterior>b__5(NewTile item)
		{
			return default(bool);
		}

		// Token: 0x04001A19 RID: 6681
		[Token(Token = "0x4001A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewTile stair;
	}

	// Token: 0x020003C1 RID: 961
	[Token(Token = "0x20003C1")]
	private sealed class <>c__DisplayClass101_0
	{
		// Token: 0x0600158C RID: 5516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass101_0()
		{
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x0000A0C8 File Offset: 0x000082C8
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x5E6860", Offset = "0x5E5860", VA = "0x1805E6860")]
		internal bool <SelectivelyHideModels>b__0(GameObject item)
		{
			return default(bool);
		}

		// Token: 0x04001A1A RID: 6682
		[Token(Token = "0x4001A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string i;
	}

	// Token: 0x020003C2 RID: 962
	[Token(Token = "0x20003C2")]
	private sealed class <>c__DisplayClass103_0
	{
		// Token: 0x0600158E RID: 5518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass103_0()
		{
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x0000A0E0 File Offset: 0x000082E0
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x80D9B0", Offset = "0x80C9B0", VA = "0x18080D9B0")]
		internal bool <SpawnStreetCables>b__0(CityControls.StreetCable item)
		{
			return default(bool);
		}

		// Token: 0x04001A1B RID: 6683
		[Token(Token = "0x4001A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BuildingPreset.CableLinkPoint link;

		// Token: 0x04001A1C RID: 6684
		[Token(Token = "0x4001A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RaycastHit hit;

		// Token: 0x04001A1D RID: 6685
		[Token(Token = "0x4001A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public NewBuilding <>4__this;
	}

	// Token: 0x020003C3 RID: 963
	[Token(Token = "0x20003C3")]
	private sealed class <>c__DisplayClass105_0
	{
		// Token: 0x06001590 RID: 5520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass105_0()
		{
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x0000A0F8 File Offset: 0x000082F8
		[Token(Token = "0x6001591")]
		[Address(RVA = "0x51ED80", Offset = "0x51DD80", VA = "0x18051ED80")]
		internal bool <GenerateAirDucts>b__2(AirDuctGroup.AirDuctSection item)
		{
			return default(bool);
		}

		// Token: 0x04001A1E RID: 6686
		[Token(Token = "0x4001A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3Int searchCoord;

		// Token: 0x04001A1F RID: 6687
		[Token(Token = "0x4001A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<AirDuctGroup.AirDuctSection> <>9__2;
	}

	// Token: 0x020003C4 RID: 964
	[Token(Token = "0x20003C4")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001593 RID: 5523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x0000A110 File Offset: 0x00008310
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x80DAD0", Offset = "0x80CAD0", VA = "0x18080DAD0")]
		internal int <GenerateAirDucts>b__105_1(NewNode p1, NewNode p2)
		{
			return 0;
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x0000A128 File Offset: 0x00008328
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x80DB60", Offset = "0x80CB60", VA = "0x18080DB60")]
		internal bool <GenerateAirDucts>b__105_0(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x0000A140 File Offset: 0x00008340
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x80DC70", Offset = "0x80CC70", VA = "0x18080DC70")]
		internal bool <CountResidences>b__121_0(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x0000A158 File Offset: 0x00008358
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x80DD90", Offset = "0x80CD90", VA = "0x18080DD90")]
		internal bool <UpdateAlarmPAWindowDistance>b__123_0(AudioController.FMODParam item)
		{
			return default(bool);
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x0000A170 File Offset: 0x00008370
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x80DE10", Offset = "0x80CE10", VA = "0x18080DE10")]
		internal bool <UpdateAlarmPAExternalDoorDistance>b__124_0(AudioController.FMODParam item)
		{
			return default(bool);
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x0000A188 File Offset: 0x00008388
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x80DE90", Offset = "0x80CE90", VA = "0x18080DE90")]
		internal bool <UpdateAlarmPAIntExt>b__125_0(AudioController.FMODParam item)
		{
			return default(bool);
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0000A1A0 File Offset: 0x000083A0
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x80DF10", Offset = "0x80CF10", VA = "0x18080DF10")]
		internal int <.cctor>b__133_0(NewBuilding object1, NewBuilding object2)
		{
			return 0;
		}

		// Token: 0x04001A20 RID: 6688
		[Token(Token = "0x4001A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NewBuilding.<>c <>9;

		// Token: 0x04001A21 RID: 6689
		[Token(Token = "0x4001A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<NewNode> <>9__105_1;

		// Token: 0x04001A22 RID: 6690
		[Token(Token = "0x4001A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<AirDuctGroup.AirVent> <>9__105_0;

		// Token: 0x04001A23 RID: 6691
		[Token(Token = "0x4001A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<NewAddress> <>9__121_0;

		// Token: 0x04001A24 RID: 6692
		[Token(Token = "0x4001A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<AudioController.FMODParam> <>9__123_0;

		// Token: 0x04001A25 RID: 6693
		[Token(Token = "0x4001A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<AudioController.FMODParam> <>9__124_0;

		// Token: 0x04001A26 RID: 6694
		[Token(Token = "0x4001A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<AudioController.FMODParam> <>9__125_0;
	}

	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	private sealed class <>c__DisplayClass110_0
	{
		// Token: 0x0600159B RID: 5531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass110_0()
		{
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x0000A1B8 File Offset: 0x000083B8
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x80DFA0", Offset = "0x80CFA0", VA = "0x18080DFA0")]
		internal bool <UpdateName>b__1(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x04001A27 RID: 6695
		[Token(Token = "0x4001A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewAddress add;
	}

	// Token: 0x020003C6 RID: 966
	[Token(Token = "0x20003C6")]
	private sealed class <>c__DisplayClass119_0
	{
		// Token: 0x0600159D RID: 5533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass119_0()
		{
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0000A1D0 File Offset: 0x000083D0
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x80E010", Offset = "0x80D010", VA = "0x18080E010")]
		internal bool <GetVentRoute>b__0(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0000A1E8 File Offset: 0x000083E8
		[Token(Token = "0x600159F")]
		[Address(RVA = "0x80E030", Offset = "0x80D030", VA = "0x18080E030")]
		internal bool <GetVentRoute>b__1(AirDuctGroup.AirVent item)
		{
			return default(bool);
		}

		// Token: 0x04001A28 RID: 6696
		[Token(Token = "0x4001A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewWall wall;
	}

	// Token: 0x020003C7 RID: 967
	[Token(Token = "0x20003C7")]
	private sealed class <>c__DisplayClass128_0
	{
		// Token: 0x060015A0 RID: 5536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass128_0()
		{
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x0000A200 File Offset: 0x00008400
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x80E060", Offset = "0x80D060", VA = "0x18080E060")]
		internal bool <TriggerNewLostAndFound>b__2(GameplayController.LostAndFound item2)
		{
			return default(bool);
		}

		// Token: 0x04001A29 RID: 6697
		[Token(Token = "0x4001A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset item;
	}

	// Token: 0x020003C8 RID: 968
	[Token(Token = "0x20003C8")]
	private sealed class <>c__DisplayClass128_1
	{
		// Token: 0x060015A2 RID: 5538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass128_1()
		{
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x0000A218 File Offset: 0x00008418
		[Token(Token = "0x60015A3")]
		[Address(RVA = "0x80E0D0", Offset = "0x80D0D0", VA = "0x18080E0D0")]
		internal bool <TriggerNewLostAndFound>b__3(GameplayController.LostAndFound item2)
		{
			return default(bool);
		}

		// Token: 0x04001A2A RID: 6698
		[Token(Token = "0x4001A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Citizen item;
	}

	// Token: 0x020003C9 RID: 969
	[Token(Token = "0x20003C9")]
	private sealed class <>c__DisplayClass129_0
	{
		// Token: 0x060015A4 RID: 5540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass129_0()
		{
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0000A230 File Offset: 0x00008430
		[Token(Token = "0x60015A5")]
		[Address(RVA = "0x80E100", Offset = "0x80D100", VA = "0x18080E100")]
		internal bool <CompleteLostAndFound>b__0(GameplayController.LostAndFound item)
		{
			return default(bool);
		}

		// Token: 0x04001A2B RID: 6699
		[Token(Token = "0x4001A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Citizen owner;

		// Token: 0x04001A2C RID: 6700
		[Token(Token = "0x4001A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractablePreset itemType;

		// Token: 0x04001A2D RID: 6701
		[Token(Token = "0x4001A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NewBuilding <>4__this;
	}

	// Token: 0x020003CA RID: 970
	[Token(Token = "0x20003CA")]
	private sealed class <PayLostAndFoundReward>d__130 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060015A6 RID: 5542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A6")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <PayLostAndFoundReward>d__130(int <>1__state)
		{
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015A7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x0000A248 File Offset: 0x00008448
		[Token(Token = "0x60015A8")]
		[Address(RVA = "0x80E1A0", Offset = "0x80D1A0", VA = "0x18080E1A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B8")]
		private object Current
		{
			[Token(Token = "0x60015A9")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AA")]
		[Address(RVA = "0x80E4F0", Offset = "0x80D4F0", VA = "0x18080E4F0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B9")]
		private object Current
		{
			[Token(Token = "0x60015AB")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001A2E RID: 6702
		[Token(Token = "0x4001A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04001A2F RID: 6703
		[Token(Token = "0x4001A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04001A30 RID: 6704
		[Token(Token = "0x4001A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameplayController.LostAndFound f;

		// Token: 0x04001A31 RID: 6705
		[Token(Token = "0x4001A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;
	}
}
