using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E5 RID: 229
[Token(Token = "0x20000E5")]
public class CityTile : Controller, IEnumerator<object>
{
	// Token: 0x0600066E RID: 1646 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600066E")]
	[Address(RVA = "0xE199A0", Offset = "0xE189A0", VA = "0x180E199A0")]
	public void Setup(Vector2Int newCoord)
	{
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600066F")]
	[Address(RVA = "0xE19FA0", Offset = "0xE18FA0", VA = "0x180E19FA0")]
	public void LoadTileOnly(CitySaveData.CityTileCitySave data)
	{
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000670")]
	[Address(RVA = "0xE1A3F0", Offset = "0xE193F0", VA = "0x180E1A3F0")]
	public void SetDensity(BuildingPreset.Density newDensity)
	{
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000671")]
	[Address(RVA = "0xE1A540", Offset = "0xE19540", VA = "0x180E1A540")]
	public void SetLandVlaue(BuildingPreset.LandValue newLandvalue)
	{
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000672")]
	[Address(RVA = "0xE1A690", Offset = "0xE19690", VA = "0x180E1A690")]
	public void AddOutsideTile(NewTile newTile)
	{
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00004AE8 File Offset: 0x00002CE8
	[Token(Token = "0x6000673")]
	[Address(RVA = "0xE1A790", Offset = "0xE19790", VA = "0x180E1A790", Slot = "6")]
	public int CompareTo(CityTile compare)
	{
		return 0;
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000674")]
	[Address(RVA = "0xCE4AF0", Offset = "0xCE3AF0", VA = "0x180CE4AF0")]
	public void SetPlayerInVicinity(bool val)
	{
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000675")]
	[Address(RVA = "0xE1A820", Offset = "0xE19820", VA = "0x180E1A820")]
	public void SetPlayerPresentOnGroundmap(bool val)
	{
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000676")]
	[Address(RVA = "0xE1AF90", Offset = "0xE19F90", VA = "0x180E1AF90")]
	public CitySaveData.CityTileCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000677")]
	[Address(RVA = "0xE1B330", Offset = "0xE1A330", VA = "0x180E1B330")]
	public CityTile()
	{
	}

	// Token: 0x040006B7 RID: 1719
	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0x18")]
	public Vector2Int cityCoord;

	// Token: 0x040006B8 RID: 1720
	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x20")]
	public DistrictController district;

	// Token: 0x040006B9 RID: 1721
	[Token(Token = "0x40006B9")]
	[FieldOffset(Offset = "0x28")]
	public int districtID;

	// Token: 0x040006BA RID: 1722
	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x30")]
	public BlockController block;

	// Token: 0x040006BB RID: 1723
	[Token(Token = "0x40006BB")]
	[FieldOffset(Offset = "0x38")]
	public int blockID;

	// Token: 0x040006BC RID: 1724
	[Token(Token = "0x40006BC")]
	[FieldOffset(Offset = "0x40")]
	public NewBuilding building;

	// Token: 0x040006BD RID: 1725
	[Token(Token = "0x40006BD")]
	[FieldOffset(Offset = "0x48")]
	public List<NewTile> outsideTiles;

	// Token: 0x040006BE RID: 1726
	[Token(Token = "0x40006BE")]
	[FieldOffset(Offset = "0x50")]
	public bool isInPlayerVicinity;

	// Token: 0x040006BF RID: 1727
	[Token(Token = "0x40006BF")]
	[FieldOffset(Offset = "0x51")]
	public bool playerPresent;

	// Token: 0x040006C0 RID: 1728
	[Token(Token = "0x40006C0")]
	[FieldOffset(Offset = "0x54")]
	public BuildingPreset.Density density;

	// Token: 0x040006C1 RID: 1729
	[Token(Token = "0x40006C1")]
	[FieldOffset(Offset = "0x58")]
	public BuildingPreset.LandValue landValue;
}
