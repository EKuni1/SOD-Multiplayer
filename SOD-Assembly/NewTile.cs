using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003F9 RID: 1017
[Token(Token = "0x20003F9")]
[Serializable]
public class NewTile
{
	// Token: 0x060016FC RID: 5884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016FC")]
	[Address(RVA = "0x876080", Offset = "0x875080", VA = "0x180876080")]
	public void SetupInterior(NewFloor newFloor, Vector2Int newCoord, bool newIsEdge)
	{
	}

	// Token: 0x060016FD RID: 5885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016FD")]
	[Address(RVA = "0x8764F0", Offset = "0x8754F0", VA = "0x1808764F0")]
	public void SetupExterior(CityTile newCityTile, Vector3Int newCityCoord)
	{
	}

	// Token: 0x060016FE RID: 5886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016FE")]
	[Address(RVA = "0x876740", Offset = "0x875740", VA = "0x180876740")]
	private void CommonSetup()
	{
	}

	// Token: 0x060016FF RID: 5887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016FF")]
	[Address(RVA = "0x8770D0", Offset = "0x8760D0", VA = "0x1808770D0")]
	public void LoadPathfindTileData(CitySaveData.TileCitySave data)
	{
	}

	// Token: 0x06001700 RID: 5888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001700")]
	[Address(RVA = "0x877110", Offset = "0x876110", VA = "0x180877110")]
	public void LoadExterior(CitySaveData.TileCitySave data)
	{
	}

	// Token: 0x06001701 RID: 5889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001701")]
	[Address(RVA = "0x877370", Offset = "0x876370", VA = "0x180877370")]
	public void LoadInterior(CitySaveData.TileCitySave data)
	{
	}

	// Token: 0x06001702 RID: 5890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001702")]
	[Address(RVA = "0x8775B0", Offset = "0x8765B0", VA = "0x1808775B0")]
	public void AddNewNode(NewNode newNode)
	{
	}

	// Token: 0x06001703 RID: 5891 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001703")]
	[Address(RVA = "0x8777A0", Offset = "0x8767A0", VA = "0x1808777A0")]
	public void RemoveNode(NewNode newNode)
	{
	}

	// Token: 0x06001704 RID: 5892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001704")]
	[Address(RVA = "0x877A00", Offset = "0x876A00", VA = "0x180877A00")]
	public void SetRotation(int newRot)
	{
	}

	// Token: 0x06001705 RID: 5893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001705")]
	[Address(RVA = "0x877CB0", Offset = "0x876CB0", VA = "0x180877CB0")]
	public void SetAsEntrance(bool val, bool mainEntrance, bool set = false)
	{
	}

	// Token: 0x06001706 RID: 5894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001706")]
	[Address(RVA = "0x878880", Offset = "0x877880", VA = "0x180878880")]
	public void SetAsStairwell(bool val, bool spawnPrefabs, bool isInverted)
	{
	}

	// Token: 0x06001707 RID: 5895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001707")]
	[Address(RVA = "0x879530", Offset = "0x878530", VA = "0x180879530")]
	public void SetStairwellRotation(int newRot)
	{
	}

	// Token: 0x06001708 RID: 5896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001708")]
	[Address(RVA = "0x879710", Offset = "0x878710", VA = "0x180879710")]
	public void SetAsTop(bool newIsTop)
	{
	}

	// Token: 0x06001709 RID: 5897 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001709")]
	[Address(RVA = "0x879AC0", Offset = "0x878AC0", VA = "0x180879AC0")]
	public void SetAsBottom(bool newIsBottom)
	{
	}

	// Token: 0x0600170A RID: 5898 RVA: 0x0000AB00 File Offset: 0x00008D00
	[Token(Token = "0x600170A")]
	[Address(RVA = "0x879C30", Offset = "0x878C30", VA = "0x180879C30")]
	public bool CanBeOptimized()
	{
		return default(bool);
	}

	// Token: 0x0600170B RID: 5899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600170B")]
	[Address(RVA = "0x879FC0", Offset = "0x878FC0", VA = "0x180879FC0")]
	public void SetFloorCeilingOptimization(bool val, bool spawnPrefabs)
	{
	}

	// Token: 0x0600170C RID: 5900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600170C")]
	[Address(RVA = "0x87A300", Offset = "0x879300", VA = "0x18087A300")]
	public void SetAsObstacle(bool val)
	{
	}

	// Token: 0x0600170D RID: 5901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600170D")]
	[Address(RVA = "0x87A460", Offset = "0x879460", VA = "0x18087A460")]
	public void SetAsOutside(bool val)
	{
	}

	// Token: 0x0600170E RID: 5902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600170E")]
	[Address(RVA = "0x87A5C0", Offset = "0x8795C0", VA = "0x18087A5C0")]
	public void CheckOffMap()
	{
	}

	// Token: 0x0600170F RID: 5903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600170F")]
	[Address(RVA = "0x87A770", Offset = "0x879770", VA = "0x18087A770")]
	public void ConnectStairwell()
	{
	}

	// Token: 0x06001710 RID: 5904 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001710")]
	[Address(RVA = "0x87BEC0", Offset = "0x87AEC0", VA = "0x18087BEC0")]
	public CitySaveData.TileCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001711")]
	[Address(RVA = "0x87BF90", Offset = "0x87AF90", VA = "0x18087BF90")]
	public NewTile()
	{
	}

	// Token: 0x04001BD7 RID: 7127
	[Token(Token = "0x4001BD7")]
	[FieldOffset(Offset = "0x10")]
	public int tileID;

	// Token: 0x04001BD8 RID: 7128
	[Token(Token = "0x4001BD8")]
	[FieldOffset(Offset = "0x0")]
	public static int assignID;

	// Token: 0x04001BD9 RID: 7129
	[Token(Token = "0x4001BD9")]
	[FieldOffset(Offset = "0x18")]
	public string name;

	// Token: 0x04001BDA RID: 7130
	[Token(Token = "0x4001BDA")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 position;

	// Token: 0x04001BDB RID: 7131
	[Token(Token = "0x4001BDB")]
	[FieldOffset(Offset = "0x30")]
	public Transform parent;

	// Token: 0x04001BDC RID: 7132
	[Token(Token = "0x4001BDC")]
	[FieldOffset(Offset = "0x38")]
	public NewBuilding building;

	// Token: 0x04001BDD RID: 7133
	[Token(Token = "0x4001BDD")]
	[FieldOffset(Offset = "0x40")]
	public NewFloor floor;

	// Token: 0x04001BDE RID: 7134
	[Token(Token = "0x4001BDE")]
	[FieldOffset(Offset = "0x48")]
	public CityTile cityTile;

	// Token: 0x04001BDF RID: 7135
	[Token(Token = "0x4001BDF")]
	[FieldOffset(Offset = "0x50")]
	public Vector2Int floorCoord;

	// Token: 0x04001BE0 RID: 7136
	[Token(Token = "0x4001BE0")]
	[FieldOffset(Offset = "0x58")]
	public Vector3Int globalTileCoord;

	// Token: 0x04001BE1 RID: 7137
	[Token(Token = "0x4001BE1")]
	[FieldOffset(Offset = "0x68")]
	public PathFinder.StreetChunk streetChunk;

	// Token: 0x04001BE2 RID: 7138
	[Token(Token = "0x4001BE2")]
	[FieldOffset(Offset = "0x70")]
	public List<NewNode> nodes;

	// Token: 0x04001BE3 RID: 7139
	[Token(Token = "0x4001BE3")]
	[FieldOffset(Offset = "0x78")]
	public NewNode anchorNode;

	// Token: 0x04001BE4 RID: 7140
	[Token(Token = "0x4001BE4")]
	[FieldOffset(Offset = "0x80")]
	public bool isSetup;

	// Token: 0x04001BE5 RID: 7141
	[Token(Token = "0x4001BE5")]
	[FieldOffset(Offset = "0x81")]
	public bool isLoaded;

	// Token: 0x04001BE6 RID: 7142
	[Token(Token = "0x4001BE6")]
	[FieldOffset(Offset = "0x82")]
	public bool isOutside;

	// Token: 0x04001BE7 RID: 7143
	[Token(Token = "0x4001BE7")]
	[FieldOffset(Offset = "0x83")]
	public bool isObstacle;

	// Token: 0x04001BE8 RID: 7144
	[Token(Token = "0x4001BE8")]
	[FieldOffset(Offset = "0x84")]
	public bool isMapCorner;

	// Token: 0x04001BE9 RID: 7145
	[Token(Token = "0x4001BE9")]
	[FieldOffset(Offset = "0x85")]
	public bool isEdge;

	// Token: 0x04001BEA RID: 7146
	[Token(Token = "0x4001BEA")]
	[FieldOffset(Offset = "0x88")]
	public int rotation;

	// Token: 0x04001BEB RID: 7147
	[Token(Token = "0x4001BEB")]
	[FieldOffset(Offset = "0x8C")]
	public bool isEntrance;

	// Token: 0x04001BEC RID: 7148
	[Token(Token = "0x4001BEC")]
	[FieldOffset(Offset = "0x8D")]
	public bool isMainEntrance;

	// Token: 0x04001BED RID: 7149
	[Token(Token = "0x4001BED")]
	[FieldOffset(Offset = "0x90")]
	public NewTile entrancePair;

	// Token: 0x04001BEE RID: 7150
	[Token(Token = "0x4001BEE")]
	[FieldOffset(Offset = "0x98")]
	public bool isStairwell;

	// Token: 0x04001BEF RID: 7151
	[Token(Token = "0x4001BEF")]
	[FieldOffset(Offset = "0x9C")]
	public int stairwellRotation;

	// Token: 0x04001BF0 RID: 7152
	[Token(Token = "0x4001BF0")]
	[FieldOffset(Offset = "0xA0")]
	public bool isInvertedStairwell;

	// Token: 0x04001BF1 RID: 7153
	[Token(Token = "0x4001BF1")]
	[FieldOffset(Offset = "0xA4")]
	public int elevatorRotation;

	// Token: 0x04001BF2 RID: 7154
	[Token(Token = "0x4001BF2")]
	[FieldOffset(Offset = "0xA8")]
	public bool isTop;

	// Token: 0x04001BF3 RID: 7155
	[Token(Token = "0x4001BF3")]
	[FieldOffset(Offset = "0xA9")]
	public bool isBottom;

	// Token: 0x04001BF4 RID: 7156
	[Token(Token = "0x4001BF4")]
	[FieldOffset(Offset = "0xB0")]
	public StreetController streetController;

	// Token: 0x04001BF5 RID: 7157
	[Token(Token = "0x4001BF5")]
	[FieldOffset(Offset = "0xB8")]
	public bool useOptimizedFloor;

	// Token: 0x04001BF6 RID: 7158
	[Token(Token = "0x4001BF6")]
	[FieldOffset(Offset = "0xB9")]
	public bool useOptimizedCeiling;

	// Token: 0x04001BF7 RID: 7159
	[Token(Token = "0x4001BF7")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject entranceArrow;

	// Token: 0x04001BF8 RID: 7160
	[Token(Token = "0x4001BF8")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject stairwell;

	// Token: 0x04001BF9 RID: 7161
	[Token(Token = "0x4001BF9")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject elevator;

	// Token: 0x04001BFA RID: 7162
	[Token(Token = "0x4001BFA")]
	[FieldOffset(Offset = "0xD8")]
	[NonSerialized]
	public Elevator stairwellAssign;
}
