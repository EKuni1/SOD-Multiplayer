using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000896 RID: 2198
[Token(Token = "0x2000896")]
public class StreetTilePreset : SoCustomComparison
{
	// Token: 0x06002A03 RID: 10755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A03")]
	[Address(RVA = "0xCB3CE0", Offset = "0xCB2CE0", VA = "0x180CB3CE0")]
	public StreetTilePreset()
	{
	}

	// Token: 0x04004389 RID: 17289
	[Token(Token = "0x4004389")]
	[FieldOffset(Offset = "0x20")]
	public StreetTilePreset.StreetSection sectionType;

	// Token: 0x0400438A RID: 17290
	[Token(Token = "0x400438A")]
	[FieldOffset(Offset = "0x28")]
	public List<StreetTilePreset.StreetSectionModel> prefabList;

	// Token: 0x02000897 RID: 2199
	[Token(Token = "0x2000897")]
	[Serializable]
	public class StreetSectionModel
	{
		// Token: 0x06002A04 RID: 10756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A04")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public StreetSectionModel()
		{
		}

		// Token: 0x0400438B RID: 17291
		[Token(Token = "0x400438B")]
		[FieldOffset(Offset = "0x10")]
		public GameObject prefab;

		// Token: 0x0400438C RID: 17292
		[Token(Token = "0x400438C")]
		[FieldOffset(Offset = "0x18")]
		public Material normalMaterial;

		// Token: 0x0400438D RID: 17293
		[Token(Token = "0x400438D")]
		[FieldOffset(Offset = "0x20")]
		public Material rainMaterial;
	}

	// Token: 0x02000898 RID: 2200
	[Token(Token = "0x2000898")]
	public enum StreetSection
	{
		// Token: 0x0400438F RID: 17295
		[Token(Token = "0x400438F")]
		streetLong,
		// Token: 0x04004390 RID: 17296
		[Token(Token = "0x4004390")]
		streetShort,
		// Token: 0x04004391 RID: 17297
		[Token(Token = "0x4004391")]
		streetInsideCorner,
		// Token: 0x04004392 RID: 17298
		[Token(Token = "0x4004392")]
		streetJunctionCorner,
		// Token: 0x04004393 RID: 17299
		[Token(Token = "0x4004393")]
		streetOutsideCorner,
		// Token: 0x04004394 RID: 17300
		[Token(Token = "0x4004394")]
		joinerLong,
		// Token: 0x04004395 RID: 17301
		[Token(Token = "0x4004395")]
		joinerShort
	}
}
