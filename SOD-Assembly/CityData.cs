using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D9 RID: 217
[Token(Token = "0x20000D9")]
public class CityData : MonoBehaviour
{
	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000631 RID: 1585 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700002A")]
	public static CityData Instance
	{
		[Token(Token = "0x6000631")]
		[Address(RVA = "0xE0C320", Offset = "0xE0B320", VA = "0x180E0C320")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000632")]
	[Address(RVA = "0xE0C360", Offset = "0xE0B360", VA = "0x180E0C360")]
	private void Awake()
	{
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000633")]
	[Address(RVA = "0xE0C6B0", Offset = "0xE0B6B0", VA = "0x180E0C6B0")]
	private void Start()
	{
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000634")]
	[Address(RVA = "0xE0C7B0", Offset = "0xE0B7B0", VA = "0x180E0C7B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000635")]
	[Address(RVA = "0xE0C9C0", Offset = "0xE0B9C0", VA = "0x180E0C9C0")]
	public void DestroySelf()
	{
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000636")]
	[Address(RVA = "0xE0CAD0", Offset = "0xE0BAD0", VA = "0x180E0CAD0")]
	public void ParseFloorData()
	{
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x00004818 File Offset: 0x00002A18
	[Token(Token = "0x6000637")]
	[Address(RVA = "0xE0CD70", Offset = "0xE0BD70", VA = "0x180E0CD70")]
	public Vector3Int CityTileToTile(Vector2Int coords)
	{
		return default(Vector3Int);
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x00004830 File Offset: 0x00002A30
	[Token(Token = "0x6000638")]
	[Address(RVA = "0xE0CFD0", Offset = "0xE0BFD0", VA = "0x180E0CFD0")]
	public Vector2Int PathmapToGroundmap(Vector3Int coords)
	{
		return default(Vector2Int);
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x00004848 File Offset: 0x00002A48
	[Token(Token = "0x6000639")]
	[Address(RVA = "0xE0D180", Offset = "0xE0C180", VA = "0x180E0D180")]
	public Vector2Int RealPosToGroundmap(Vector3 coords)
	{
		return default(Vector2Int);
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00004860 File Offset: 0x00002A60
	[Token(Token = "0x600063A")]
	[Address(RVA = "0xE0D3C0", Offset = "0xE0C3C0", VA = "0x180E0D3C0")]
	public Vector3Int RealPosToPathmap(Vector3 coords)
	{
		return default(Vector3Int);
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x00004878 File Offset: 0x00002A78
	[Token(Token = "0x600063B")]
	[Address(RVA = "0xE0D620", Offset = "0xE0C620", VA = "0x180E0D620")]
	public Vector3Int RealPosToPathmapIncludingZ(Vector3 coords)
	{
		return default(Vector3Int);
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00004890 File Offset: 0x00002A90
	[Token(Token = "0x600063C")]
	[Address(RVA = "0xE0D8C0", Offset = "0xE0C8C0", VA = "0x180E0D8C0")]
	public Vector3 RealPosToNode(Vector3 coords)
	{
		return default(Vector3);
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x000048A8 File Offset: 0x00002AA8
	[Token(Token = "0x600063D")]
	[Address(RVA = "0xE0DB80", Offset = "0xE0CB80", VA = "0x180E0DB80")]
	public Vector3 RealPosToNodeFloat(Vector3 coords)
	{
		return default(Vector3);
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x000048C0 File Offset: 0x00002AC0
	[Token(Token = "0x600063E")]
	[Address(RVA = "0xE0DE10", Offset = "0xE0CE10", VA = "0x180E0DE10")]
	public Vector3Int RealPosToNodeInt(Vector3 coords)
	{
		return default(Vector3Int);
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x000048D8 File Offset: 0x00002AD8
	[Token(Token = "0x600063F")]
	[Address(RVA = "0xE0E0D0", Offset = "0xE0D0D0", VA = "0x180E0E0D0")]
	public Vector3 CityTileToRealpos(Vector2 coords)
	{
		return default(Vector3);
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x000048F0 File Offset: 0x00002AF0
	[Token(Token = "0x6000640")]
	[Address(RVA = "0xE0E3C0", Offset = "0xE0D3C0", VA = "0x180E0E3C0")]
	public Vector3 TileToRealpos(Vector3Int coords)
	{
		return default(Vector3);
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x00004908 File Offset: 0x00002B08
	[Token(Token = "0x6000641")]
	[Address(RVA = "0xE0E730", Offset = "0xE0D730", VA = "0x180E0E730")]
	public Vector3 TileToRealpos(Vector3 coords)
	{
		return default(Vector3);
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x00004920 File Offset: 0x00002B20
	[Token(Token = "0x6000642")]
	[Address(RVA = "0xE0EA90", Offset = "0xE0DA90", VA = "0x180E0EA90")]
	public Vector3 NodeToRealpos(Vector3 coords)
	{
		return default(Vector3);
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x00004938 File Offset: 0x00002B38
	[Token(Token = "0x6000643")]
	[Address(RVA = "0xE0EDF0", Offset = "0xE0DDF0", VA = "0x180E0EDF0")]
	public Vector3 NodeToRealposInt(Vector3Int coords)
	{
		return default(Vector3);
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00004950 File Offset: 0x00002B50
	[Token(Token = "0x6000644")]
	[Address(RVA = "0xE0F160", Offset = "0xE0E160", VA = "0x180E0F160")]
	public float GetTileHeight(Vector2 coords)
	{
		return 0f;
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000645")]
	[Address(RVA = "0xE0F3B0", Offset = "0xE0E3B0", VA = "0x180E0F3B0")]
	public void CreateSingletons()
	{
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000646")]
	[Address(RVA = "0xE102C0", Offset = "0xE0F2C0", VA = "0x180E102C0")]
	public void CreateCityDirectory()
	{
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000647")]
	[Address(RVA = "0xE11F20", Offset = "0xE10F20", VA = "0x180E11F20")]
	public void GenerateEchelonDecorData()
	{
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00004968 File Offset: 0x00002B68
	[Token(Token = "0x6000648")]
	[Address(RVA = "0xE12360", Offset = "0xE11360", VA = "0x180E12360")]
	public Vector2Int GetOffsetFromDirection(CityData.BlockingDirection dir)
	{
		return default(Vector2Int);
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000649")]
	[Address(RVA = "0xE123D0", Offset = "0xE113D0", VA = "0x180E123D0")]
	public MetaObject FindMetaObject(int id)
	{
		return null;
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x00004980 File Offset: 0x00002B80
	[Token(Token = "0x600064A")]
	[Address(RVA = "0xE124D0", Offset = "0xE114D0", VA = "0x180E124D0")]
	public bool GetHuman(int id, out Human output, bool includePlayer = true)
	{
		return default(bool);
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600064B")]
	[Address(RVA = "0xE12830", Offset = "0xE11830", VA = "0x180E12830")]
	public string GetCurrentGameInstanceID()
	{
		return null;
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600064C")]
	[Address(RVA = "0xE128E0", Offset = "0xE118E0", VA = "0x180E128E0")]
	public CityData()
	{
	}

	// Token: 0x04000612 RID: 1554
	[Token(Token = "0x4000612")]
	[FieldOffset(Offset = "0x18")]
	public string cityName;

	// Token: 0x04000613 RID: 1555
	[Token(Token = "0x4000613")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 citySize;

	// Token: 0x04000614 RID: 1556
	[Token(Token = "0x4000614")]
	[FieldOffset(Offset = "0x28")]
	public string cityBuiltWith;

	// Token: 0x04000615 RID: 1557
	[Token(Token = "0x4000615")]
	[FieldOffset(Offset = "0x30")]
	public int citizensToGenerate;

	// Token: 0x04000616 RID: 1558
	[Token(Token = "0x4000616")]
	[FieldOffset(Offset = "0x34")]
	public float populationMultiplier;

	// Token: 0x04000617 RID: 1559
	[Token(Token = "0x4000617")]
	[FieldOffset(Offset = "0x38")]
	public string seed;

	// Token: 0x04000618 RID: 1560
	[Token(Token = "0x4000618")]
	[FieldOffset(Offset = "0x40")]
	public List<string> instanceIDs;

	// Token: 0x04000619 RID: 1561
	[Token(Token = "0x4000619")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 maxCoord;

	// Token: 0x0400061A RID: 1562
	[Token(Token = "0x400061A")]
	[FieldOffset(Offset = "0x50")]
	public float boundaryLeft;

	// Token: 0x0400061B RID: 1563
	[Token(Token = "0x400061B")]
	[FieldOffset(Offset = "0x54")]
	public float boundaryRight;

	// Token: 0x0400061C RID: 1564
	[Token(Token = "0x400061C")]
	[FieldOffset(Offset = "0x58")]
	public float boundaryUp;

	// Token: 0x0400061D RID: 1565
	[Token(Token = "0x400061D")]
	[FieldOffset(Offset = "0x5C")]
	public float boundaryDown;

	// Token: 0x0400061E RID: 1566
	[Token(Token = "0x400061E")]
	[FieldOffset(Offset = "0x60")]
	public BlockController borderBlock;

	// Token: 0x0400061F RID: 1567
	[Token(Token = "0x400061F")]
	[FieldOffset(Offset = "0x68")]
	public Dictionary<string, FloorSaveData> floorData;

	// Token: 0x04000620 RID: 1568
	[Token(Token = "0x4000620")]
	[FieldOffset(Offset = "0x70")]
	public List<StreetController> streetDirectory;

	// Token: 0x04000621 RID: 1569
	[Token(Token = "0x4000621")]
	[FieldOffset(Offset = "0x78")]
	public List<NewAddress> addressDirectory;

	// Token: 0x04000622 RID: 1570
	[Token(Token = "0x4000622")]
	[FieldOffset(Offset = "0x80")]
	public List<NewFloor> floorDirectory;

	// Token: 0x04000623 RID: 1571
	[Token(Token = "0x4000623")]
	[FieldOffset(Offset = "0x88")]
	public Dictionary<int, NewAddress> addressDictionary;

	// Token: 0x04000624 RID: 1572
	[Token(Token = "0x4000624")]
	[FieldOffset(Offset = "0x90")]
	public List<NewGameLocation> gameLocationDirectory;

	// Token: 0x04000625 RID: 1573
	[Token(Token = "0x4000625")]
	[FieldOffset(Offset = "0x98")]
	public List<NewRoom> roomDirectory;

	// Token: 0x04000626 RID: 1574
	[Token(Token = "0x4000626")]
	[FieldOffset(Offset = "0xA0")]
	public Dictionary<int, NewRoom> roomDictionary;

	// Token: 0x04000627 RID: 1575
	[Token(Token = "0x4000627")]
	[FieldOffset(Offset = "0xA8")]
	public List<ResidenceController> residenceDirectory;

	// Token: 0x04000628 RID: 1576
	[Token(Token = "0x4000628")]
	[FieldOffset(Offset = "0xB0")]
	public List<Company> companyDirectory;

	// Token: 0x04000629 RID: 1577
	[Token(Token = "0x4000629")]
	[FieldOffset(Offset = "0xB8")]
	public List<Citizen> citizenDirectory;

	// Token: 0x0400062A RID: 1578
	[Token(Token = "0x400062A")]
	[FieldOffset(Offset = "0xC0")]
	public List<Citizen> homelessDirectory;

	// Token: 0x0400062B RID: 1579
	[Token(Token = "0x400062B")]
	[FieldOffset(Offset = "0xC8")]
	public List<Citizen> homedDirectory;

	// Token: 0x0400062C RID: 1580
	[Token(Token = "0x400062C")]
	[FieldOffset(Offset = "0xD0")]
	public Dictionary<int, Human> citizenDictionary;

	// Token: 0x0400062D RID: 1581
	[Token(Token = "0x400062D")]
	[FieldOffset(Offset = "0xD8")]
	public List<Human> deadCitizensDirectory;

	// Token: 0x0400062E RID: 1582
	[Token(Token = "0x400062E")]
	[FieldOffset(Offset = "0xE0")]
	public List<Occupation> jobsDirectory;

	// Token: 0x0400062F RID: 1583
	[Token(Token = "0x400062F")]
	[FieldOffset(Offset = "0xE8")]
	public List<Occupation> assignedJobsDirectory;

	// Token: 0x04000630 RID: 1584
	[Token(Token = "0x4000630")]
	[FieldOffset(Offset = "0xF0")]
	public List<Occupation> unemployedDirectory;

	// Token: 0x04000631 RID: 1585
	[Token(Token = "0x4000631")]
	[FieldOffset(Offset = "0xF8")]
	public List<Occupation> criminalJobDirectory;

	// Token: 0x04000632 RID: 1586
	[Token(Token = "0x4000632")]
	[FieldOffset(Offset = "0x100")]
	public List<ReflectionProbeController> reflectionProbeDirectory;

	// Token: 0x04000633 RID: 1587
	[Token(Token = "0x4000633")]
	[FieldOffset(Offset = "0x108")]
	public List<FurnitureLocation> jobBoardsDirectory;

	// Token: 0x04000634 RID: 1588
	[Token(Token = "0x4000634")]
	[FieldOffset(Offset = "0x110")]
	public Dictionary<int, NewDoor> doorDictionary;

	// Token: 0x04000635 RID: 1589
	[Token(Token = "0x4000635")]
	[FieldOffset(Offset = "0x118")]
	public List<AirDuctGroup> airDuctGroupDirectory;

	// Token: 0x04000636 RID: 1590
	[Token(Token = "0x4000636")]
	[FieldOffset(Offset = "0x120")]
	public List<AirDuctGroup.AirVent> airVentDirectory;

	// Token: 0x04000637 RID: 1591
	[Token(Token = "0x4000637")]
	[FieldOffset(Offset = "0x128")]
	public List<Interactable> interactableDirectory;

	// Token: 0x04000638 RID: 1592
	[Token(Token = "0x4000638")]
	[FieldOffset(Offset = "0x130")]
	public List<SceneRecorder> surveillanceDirectory;

	// Token: 0x04000639 RID: 1593
	[Token(Token = "0x4000639")]
	[FieldOffset(Offset = "0x138")]
	public Dictionary<int, Telephone> phoneDictionary;

	// Token: 0x0400063A RID: 1594
	[Token(Token = "0x400063A")]
	[FieldOffset(Offset = "0x140")]
	public Dictionary<int, Interactable> savableInteractableDictionary;

	// Token: 0x0400063B RID: 1595
	[Token(Token = "0x400063B")]
	[FieldOffset(Offset = "0x148")]
	public List<Interactable> caseTrays;

	// Token: 0x0400063C RID: 1596
	[Token(Token = "0x400063C")]
	[FieldOffset(Offset = "0x150")]
	public Dictionary<int, MetaObject> metaObjectDictionary;

	// Token: 0x0400063D RID: 1597
	[Token(Token = "0x400063D")]
	[FieldOffset(Offset = "0x158")]
	public List<LightController> dynamicShadowSystemLights;

	// Token: 0x0400063E RID: 1598
	[Token(Token = "0x400063E")]
	[FieldOffset(Offset = "0x160")]
	public List<Citizen> homlessAssign;

	// Token: 0x0400063F RID: 1599
	[Token(Token = "0x400063F")]
	[FieldOffset(Offset = "0x168")]
	public Dictionary<AddressPreset, List<NewAddress>> addressTypeReference;

	// Token: 0x04000640 RID: 1600
	[Token(Token = "0x4000640")]
	[FieldOffset(Offset = "0x170")]
	public Dictionary<RetailItemPreset, Evidence> itemSingletons;

	// Token: 0x04000641 RID: 1601
	[Token(Token = "0x4000641")]
	[FieldOffset(Offset = "0x178")]
	public HashSet<NewRoom> visibleRooms;

	// Token: 0x04000642 RID: 1602
	[Token(Token = "0x4000642")]
	[FieldOffset(Offset = "0x180")]
	public List<Actor> visibleActors;

	// Token: 0x04000643 RID: 1603
	[Token(Token = "0x4000643")]
	[FieldOffset(Offset = "0x188")]
	public Vector2 floorRange;

	// Token: 0x04000644 RID: 1604
	[Token(Token = "0x4000644")]
	[FieldOffset(Offset = "0x190")]
	public int residentialBuildings;

	// Token: 0x04000645 RID: 1605
	[Token(Token = "0x4000645")]
	[FieldOffset(Offset = "0x194")]
	public int commercialBuildings;

	// Token: 0x04000646 RID: 1606
	[Token(Token = "0x4000646")]
	[FieldOffset(Offset = "0x198")]
	public int industrialBuildings;

	// Token: 0x04000647 RID: 1607
	[Token(Token = "0x4000647")]
	[FieldOffset(Offset = "0x19C")]
	public int municipalBuildings;

	// Token: 0x04000648 RID: 1608
	[Token(Token = "0x4000648")]
	[FieldOffset(Offset = "0x1A0")]
	public int parkBuildings;

	// Token: 0x04000649 RID: 1609
	[Token(Token = "0x4000649")]
	[FieldOffset(Offset = "0x1A4")]
	public int inhabitedResidences;

	// Token: 0x0400064A RID: 1610
	[Token(Token = "0x400064A")]
	[FieldOffset(Offset = "0x1A8")]
	public int employedCitizens;

	// Token: 0x0400064B RID: 1611
	[Token(Token = "0x400064B")]
	[FieldOffset(Offset = "0x1AC")]
	public int extraUnemloyedCreated;

	// Token: 0x0400064C RID: 1612
	[Token(Token = "0x400064C")]
	[FieldOffset(Offset = "0x1B0")]
	public float averageShoeSize;

	// Token: 0x0400064D RID: 1613
	[Token(Token = "0x400064D")]
	[FieldOffset(Offset = "0x1B8")]
	public Evidence cityDirectory;

	// Token: 0x0400064E RID: 1614
	[Token(Token = "0x400064E")]
	[FieldOffset(Offset = "0x1C0")]
	public Evidence elevatorControls;

	// Token: 0x0400064F RID: 1615
	[Token(Token = "0x400064F")]
	[FieldOffset(Offset = "0x1C8")]
	public EvidenceWitness telephone;

	// Token: 0x04000650 RID: 1616
	[Token(Token = "0x4000650")]
	[FieldOffset(Offset = "0x1D0")]
	public EvidenceWitness hospitalBed;

	// Token: 0x04000651 RID: 1617
	[Token(Token = "0x4000651")]
	[FieldOffset(Offset = "0x1D8")]
	public Dictionary<int, string> cityDirText;

	// Token: 0x04000652 RID: 1618
	[Token(Token = "0x4000652")]
	[FieldOffset(Offset = "0x1E0")]
	public Toolbox.MaterialKey echelonFloorMatKey;

	// Token: 0x04000653 RID: 1619
	[Token(Token = "0x4000653")]
	[FieldOffset(Offset = "0x1E8")]
	public Toolbox.MaterialKey echelonCeilingMatKey;

	// Token: 0x04000654 RID: 1620
	[Token(Token = "0x4000654")]
	[FieldOffset(Offset = "0x1F0")]
	public Toolbox.MaterialKey echelonDefaultWallKey;

	// Token: 0x04000655 RID: 1621
	[Token(Token = "0x4000655")]
	[FieldOffset(Offset = "0x0")]
	private static CityData _instance;

	// Token: 0x04000656 RID: 1622
	[Token(Token = "0x4000656")]
	[FieldOffset(Offset = "0x1F8")]
	public Vector2Int[] offsetArrayX4;

	// Token: 0x04000657 RID: 1623
	[Token(Token = "0x4000657")]
	[FieldOffset(Offset = "0x200")]
	public Vector2[] offsetArrayX4StreetJunction;

	// Token: 0x04000658 RID: 1624
	[Token(Token = "0x4000658")]
	[FieldOffset(Offset = "0x208")]
	public Vector2Int[] offsetArrayX4Diagonal;

	// Token: 0x04000659 RID: 1625
	[Token(Token = "0x4000659")]
	[FieldOffset(Offset = "0x210")]
	public Vector2Int[] offsetArrayX8;

	// Token: 0x0400065A RID: 1626
	[Token(Token = "0x400065A")]
	[FieldOffset(Offset = "0x218")]
	public Vector3Int[] offsetArrayX6;

	// Token: 0x0400065B RID: 1627
	[Token(Token = "0x400065B")]
	[FieldOffset(Offset = "0x220")]
	public Vector2Int[] offsetArrayX24;

	// Token: 0x0400065C RID: 1628
	[Token(Token = "0x400065C")]
	[FieldOffset(Offset = "0x228")]
	public int[] angleArrayX4;

	// Token: 0x0400065D RID: 1629
	[Token(Token = "0x400065D")]
	[FieldOffset(Offset = "0x230")]
	public int[] angleArrayX8;

	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	public struct ParsedFloorTile
	{
		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 tileLocation;

		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0x8")]
		public int roomID;

		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x4000660")]
		[FieldOffset(Offset = "0x10")]
		public List<Vector2> tileAccessList;

		// Token: 0x04000661 RID: 1633
		[Token(Token = "0x4000661")]
		[FieldOffset(Offset = "0x18")]
		public int designation;

		// Token: 0x04000662 RID: 1634
		[Token(Token = "0x4000662")]
		[FieldOffset(Offset = "0x1C")]
		public int tileType;

		// Token: 0x04000663 RID: 1635
		[Token(Token = "0x4000663")]
		[FieldOffset(Offset = "0x20")]
		public bool addressAnchor;

		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x24")]
		public float floorRotation;

		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x28")]
		public List<Vector2> doorsAccess;

		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<Vector2, int> windowsAccess;

		// Token: 0x04000667 RID: 1639
		[Token(Token = "0x4000667")]
		[FieldOffset(Offset = "0x38")]
		public bool lightswitch;

		// Token: 0x04000668 RID: 1640
		[Token(Token = "0x4000668")]
		[FieldOffset(Offset = "0x3C")]
		public int cctv;
	}

	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	public class ParsedFloorData
	{
		// Token: 0x0600064D RID: 1613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064D")]
		[Address(RVA = "0xE14960", Offset = "0xE13960", VA = "0x180E14960")]
		public ParsedFloorData()
		{
		}

		// Token: 0x04000669 RID: 1641
		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, List<CityData.ParsedFloorTile>> unitData;

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x18")]
		public List<CityData.ParsedFloorTile> allTiles;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 mainEntranceOutside;

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 mainEntranceInside;

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<Vector2, Vector2> additionalEntrances;

		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x38")]
		public float floorHeight;

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x3C")]
		public float ceilingHeight;
	}

	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	public class CityDirectoryEntry
	{
		// Token: 0x0600064E RID: 1614 RVA: 0x00004998 File Offset: 0x00002B98
		[Token(Token = "0x600064E")]
		[Address(RVA = "0xE14BC0", Offset = "0xE13BC0", VA = "0x180E14BC0")]
		public static int PhoneBookSort(CityData.CityDirectoryEntry other1, CityData.CityDirectoryEntry other2)
		{
			return 0;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public CityDirectoryEntry()
		{
		}

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x10")]
		public int linkID;

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x18")]
		public string entryName;

		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x20")]
		public string sortString;
	}

	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	public enum BlockingDirection
	{
		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		none,
		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		behindLeft,
		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000676")]
		behind,
		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		behindRight,
		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000678")]
		left,
		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000679")]
		right,
		// Token: 0x0400067A RID: 1658
		[Token(Token = "0x400067A")]
		frontLeft,
		// Token: 0x0400067B RID: 1659
		[Token(Token = "0x400067B")]
		front,
		// Token: 0x0400067C RID: 1660
		[Token(Token = "0x400067C")]
		frontRight
	}

	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000DE")]
	private sealed class <>c__DisplayClass102_0
	{
		// Token: 0x06000650 RID: 1616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass102_0()
		{
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Token(Token = "0x6000651")]
		[Address(RVA = "0xE14C60", Offset = "0xE13C60", VA = "0x180E14C60")]
		internal bool <CreateCityDirectory>b__0(Company item)
		{
			return default(bool);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Token(Token = "0x6000652")]
		[Address(RVA = "0xE14E30", Offset = "0xE13E30", VA = "0x180E14E30")]
		internal bool <CreateCityDirectory>b__1(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x6000653")]
		[Address(RVA = "0xE15010", Offset = "0xE14010", VA = "0x180E15010")]
		internal bool <CreateCityDirectory>b__2(Citizen item)
		{
			return default(bool);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000049F8 File Offset: 0x00002BF8
		[Token(Token = "0x6000654")]
		[Address(RVA = "0xE152D0", Offset = "0xE142D0", VA = "0x180E152D0")]
		internal bool <CreateCityDirectory>b__4(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x400067D")]
		[FieldOffset(Offset = "0x10")]
		public char character;
	}

	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000656 RID: 1622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00004A10 File Offset: 0x00002C10
		[Token(Token = "0x6000657")]
		[Address(RVA = "0xE15560", Offset = "0xE14560", VA = "0x180E15560")]
		internal bool <CreateCityDirectory>b__102_3(Company item)
		{
			return default(bool);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00004A28 File Offset: 0x00002C28
		[Token(Token = "0x6000658")]
		[Address(RVA = "0xE15650", Offset = "0xE14650", VA = "0x180E15650")]
		internal bool <CreateCityDirectory>b__102_5(Citizen item)
		{
			return default(bool);
		}

		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400067E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CityData.<>c <>9;

		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400067F")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Company> <>9__102_3;

		// Token: 0x04000680 RID: 1664
		[Token(Token = "0x4000680")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<Citizen> <>9__102_5;
	}
}
