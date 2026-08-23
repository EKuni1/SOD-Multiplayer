using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000428 RID: 1064
[Token(Token = "0x2000428")]
[Serializable]
public class FurnitureClusterLocation : IEnumerator<object>
{
	// Token: 0x060017F9 RID: 6137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017F9")]
	[Address(RVA = "0x8B11E0", Offset = "0x8B01E0", VA = "0x1808B11E0")]
	public FurnitureClusterLocation(NewNode newAnchor, FurnitureCluster newPreset, int newAngle, float newRank)
	{
	}

	// Token: 0x060017FA RID: 6138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017FA")]
	[Address(RVA = "0x8B1440", Offset = "0x8B0440", VA = "0x1808B1440")]
	public void LoadFurnitureToWorld(bool forceSpawnImmediate = false)
	{
	}

	// Token: 0x060017FB RID: 6139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017FB")]
	[Address(RVA = "0x8B1AF0", Offset = "0x8B0AF0", VA = "0x1808B1AF0")]
	public void UnloadFurniture(bool removeIntegratedInteractables, FurnitureClusterLocation.RemoveInteractablesOption removeSpawnedInteractables)
	{
	}

	// Token: 0x060017FC RID: 6140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017FC")]
	[Address(RVA = "0x8B1F20", Offset = "0x8B0F20", VA = "0x1808B1F20")]
	public void DeleteCluster(bool removeIntegratedInteractables, FurnitureClusterLocation.RemoveInteractablesOption removeSpawnedInteractables)
	{
	}

	// Token: 0x060017FD RID: 6141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017FD")]
	[Address(RVA = "0x8B2290", Offset = "0x8B1290", VA = "0x1808B2290")]
	public void DeleteFurniture(int deleteID, bool removeIntegratedInteractables, FurnitureClusterLocation.RemoveInteractablesOption removeSpawnedInteractables)
	{
	}

	// Token: 0x060017FE RID: 6142 RVA: 0x0000AEC0 File Offset: 0x000090C0
	[Token(Token = "0x60017FE")]
	[Address(RVA = "0x8B2820", Offset = "0x8B1820", VA = "0x1808B2820", Slot = "4")]
	public int CompareTo(FurnitureClusterLocation otherObject)
	{
		return 0;
	}

	// Token: 0x060017FF RID: 6143 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017FF")]
	[Address(RVA = "0x8B28A0", Offset = "0x8B18A0", VA = "0x1808B28A0")]
	public CitySaveData.FurnitureClusterCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x04001D61 RID: 7521
	[Token(Token = "0x4001D61")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<NewNode, List<FurnitureLocation>> clusterObjectMap;

	// Token: 0x04001D62 RID: 7522
	[Token(Token = "0x4001D62")]
	[FieldOffset(Offset = "0x18")]
	[NonSerialized]
	public List<FurnitureLocation> clusterList;

	// Token: 0x04001D63 RID: 7523
	[Token(Token = "0x4001D63")]
	[FieldOffset(Offset = "0x20")]
	public FurnitureCluster cluster;

	// Token: 0x04001D64 RID: 7524
	[Token(Token = "0x4001D64")]
	[FieldOffset(Offset = "0x28")]
	public NewNode anchorNode;

	// Token: 0x04001D65 RID: 7525
	[Token(Token = "0x4001D65")]
	[FieldOffset(Offset = "0x30")]
	public int angle;

	// Token: 0x04001D66 RID: 7526
	[Token(Token = "0x4001D66")]
	[FieldOffset(Offset = "0x34")]
	public float ranking;

	// Token: 0x04001D67 RID: 7527
	[Token(Token = "0x4001D67")]
	[FieldOffset(Offset = "0x38")]
	public bool loadedGeometry;

	// Token: 0x02000429 RID: 1065
	[Token(Token = "0x2000429")]
	public enum RemoveInteractablesOption
	{
		// Token: 0x04001D69 RID: 7529
		[Token(Token = "0x4001D69")]
		keep,
		// Token: 0x04001D6A RID: 7530
		[Token(Token = "0x4001D6A")]
		remove,
		// Token: 0x04001D6B RID: 7531
		[Token(Token = "0x4001D6B")]
		moveToStorage
	}
}
