using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008A3 RID: 2211
[Token(Token = "0x20008A3")]
public class WallFrontagePreset : SoCustomComparison
{
	// Token: 0x06002A0A RID: 10762 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A0A")]
	[Address(RVA = "0xCB4790", Offset = "0xCB3790", VA = "0x180CB4790")]
	public WallFrontagePreset()
	{
	}

	// Token: 0x0400445F RID: 17503
	[Token(Token = "0x400445F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject gameObject;

	// Token: 0x04004460 RID: 17504
	[Token(Token = "0x4004460")]
	[FieldOffset(Offset = "0x28")]
	public bool allowStaticBatching;

	// Token: 0x04004461 RID: 17505
	[Token(Token = "0x4004461")]
	[FieldOffset(Offset = "0x29")]
	public bool isRainyWindow;

	// Token: 0x04004462 RID: 17506
	[Token(Token = "0x4004462")]
	[FieldOffset(Offset = "0x30")]
	public Material regularGlass;

	// Token: 0x04004463 RID: 17507
	[Token(Token = "0x4004463")]
	[FieldOffset(Offset = "0x38")]
	public Material rainyGlass;

	// Token: 0x04004464 RID: 17508
	[Token(Token = "0x4004464")]
	[FieldOffset(Offset = "0x40")]
	public bool universalDesignStyle;

	// Token: 0x04004465 RID: 17509
	[Token(Token = "0x4004465")]
	[FieldOffset(Offset = "0x48")]
	public List<DesignStylePreset> designStyles;

	// Token: 0x04004466 RID: 17510
	[Token(Token = "0x4004466")]
	[FieldOffset(Offset = "0x50")]
	public bool inheritColouringFromDecor;

	// Token: 0x04004467 RID: 17511
	[Token(Token = "0x4004467")]
	[FieldOffset(Offset = "0x54")]
	public FurniturePreset.ShareColours shareColours;

	// Token: 0x04004468 RID: 17512
	[Token(Token = "0x4004468")]
	[FieldOffset(Offset = "0x58")]
	public List<MaterialGroupPreset.MaterialVariation> variations;

	// Token: 0x04004469 RID: 17513
	[Token(Token = "0x4004469")]
	[FieldOffset(Offset = "0x60")]
	public List<FurniturePreset.IntegratedInteractable> integratedInteractables;

	// Token: 0x0400446A RID: 17514
	[Token(Token = "0x400446A")]
	[FieldOffset(Offset = "0x68")]
	public List<WallFrontageClass> classes;
}
