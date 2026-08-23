using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200022A RID: 554
[Token(Token = "0x200022A")]
public class FurnitureClusterEditor : MonoBehaviour
{
	// Token: 0x06000CA1 RID: 3233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0x59CC30", Offset = "0x59BC30", VA = "0x18059CC30")]
	public void ScanTilesForFurniture()
	{
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0x59DB50", Offset = "0x59CB50", VA = "0x18059DB50")]
	public void SpawnAlternateFurniture()
	{
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CA3")]
	[Address(RVA = "0x59E3C0", Offset = "0x59D3C0", VA = "0x18059E3C0")]
	public void LoadCluster()
	{
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x00007170 File Offset: 0x00005370
	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0x59E4D0", Offset = "0x59D4D0", VA = "0x18059E4D0")]
	private Vector2 RotateVector2CW(Vector2 v, float degrees)
	{
		return default(Vector2);
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000CA5")]
	[Address(RVA = "0x59E570", Offset = "0x59D570", VA = "0x18059E570")]
	private FurniturePreset GetRandomFurnitureForElement(FurnitureCluster.FurnitureClusterRule inputElement)
	{
		return null;
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CA6")]
	[Address(RVA = "0x59E840", Offset = "0x59D840", VA = "0x18059E840")]
	public void SaveToCluster()
	{
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CA7")]
	[Address(RVA = "0x59E970", Offset = "0x59D970", VA = "0x18059E970")]
	public void ClearAllFurniture()
	{
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0x59EB70", Offset = "0x59DB70", VA = "0x18059EB70")]
	public void ClearClusterList()
	{
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x00007188 File Offset: 0x00005388
	[Token(Token = "0x6000CA9")]
	[Address(RVA = "0x59EBE0", Offset = "0x59DBE0", VA = "0x18059EBE0")]
	private int GetAngleForFurnitureFacing(FurnitureCluster.FurnitureFacing facing)
	{
		return 0;
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x000071A0 File Offset: 0x000053A0
	[Token(Token = "0x6000CAA")]
	[Address(RVA = "0x59EC10", Offset = "0x59DC10", VA = "0x18059EC10")]
	private FurnitureCluster.FurnitureFacing GetFacingForFurnitureAngle(float angle)
	{
		return FurnitureCluster.FurnitureFacing.down;
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CAB")]
	[Address(RVA = "0x59ECA0", Offset = "0x59DCA0", VA = "0x18059ECA0")]
	public FurnitureClusterEditor()
	{
	}

	// Token: 0x04000E05 RID: 3589
	[Token(Token = "0x4000E05")]
	[FieldOffset(Offset = "0x18")]
	public FurnitureCluster cluster;

	// Token: 0x04000E06 RID: 3590
	[Token(Token = "0x4000E06")]
	[FieldOffset(Offset = "0x20")]
	public List<FurnitureCluster.FurnitureClusterRule> clusterElements;

	// Token: 0x04000E07 RID: 3591
	[Token(Token = "0x4000E07")]
	[FieldOffset(Offset = "0x28")]
	public Transform furnitureParent;

	// Token: 0x04000E08 RID: 3592
	[Token(Token = "0x4000E08")]
	[FieldOffset(Offset = "0x30")]
	public List<WalkableRecorder.TileSetup> tiles;

	// Token: 0x04000E09 RID: 3593
	[Token(Token = "0x4000E09")]
	[FieldOffset(Offset = "0x38")]
	public List<ClusterEditorFurniture> spawnedFurniture;

	// Token: 0x0200022B RID: 555
	[Token(Token = "0x200022B")]
	private sealed class <>c__DisplayClass5_0
	{
		// Token: 0x06000CAC RID: 3244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass5_0()
		{
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x000071B8 File Offset: 0x000053B8
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x59EEF0", Offset = "0x59DEF0", VA = "0x18059EEF0")]
		internal bool <ScanTilesForFurniture>b__0(FurniturePreset item)
		{
			return default(bool);
		}

		// Token: 0x04000E0A RID: 3594
		[Token(Token = "0x4000E0A")]
		[FieldOffset(Offset = "0x10")]
		public string furnitureModelName;
	}

	// Token: 0x0200022C RID: 556
	[Token(Token = "0x200022C")]
	private sealed class <>c__DisplayClass6_0
	{
		// Token: 0x06000CAE RID: 3246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x000071D0 File Offset: 0x000053D0
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x59EF60", Offset = "0x59DF60", VA = "0x18059EF60")]
		internal bool <SpawnAlternateFurniture>b__0(WalkableRecorder.TileSetup item)
		{
			return default(bool);
		}

		// Token: 0x04000E0B RID: 3595
		[Token(Token = "0x4000E0B")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 placementPos;
	}
}
