using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000835 RID: 2101
[Token(Token = "0x2000835")]
public class LayoutConfiguration : SoCustomComparison
{
	// Token: 0x060029B6 RID: 10678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029B6")]
	[Address(RVA = "0xCAC3C0", Offset = "0xCAB3C0", VA = "0x180CAC3C0")]
	public LayoutConfiguration()
	{
	}

	// Token: 0x04003F17 RID: 16151
	[Token(Token = "0x4003F17")]
	[FieldOffset(Offset = "0x20")]
	public bool assignPurpose;

	// Token: 0x04003F18 RID: 16152
	[Token(Token = "0x4003F18")]
	[FieldOffset(Offset = "0x28")]
	public AddressPreset addressPreset;

	// Token: 0x04003F19 RID: 16153
	[Token(Token = "0x4003F19")]
	[FieldOffset(Offset = "0x30")]
	public bool publicFacing;

	// Token: 0x04003F1A RID: 16154
	[Token(Token = "0x4003F1A")]
	[FieldOffset(Offset = "0x31")]
	public bool isOutside;

	// Token: 0x04003F1B RID: 16155
	[Token(Token = "0x4003F1B")]
	[FieldOffset(Offset = "0x32")]
	public bool isLobby;

	// Token: 0x04003F1C RID: 16156
	[Token(Token = "0x4003F1C")]
	[FieldOffset(Offset = "0x38")]
	public List<RoomTypePreset> roomLayout;

	// Token: 0x04003F1D RID: 16157
	[Token(Token = "0x4003F1D")]
	[FieldOffset(Offset = "0x40")]
	public bool requiresHallway;

	// Token: 0x04003F1E RID: 16158
	[Token(Token = "0x4003F1E")]
	[FieldOffset(Offset = "0x48")]
	public RoomConfiguration hallway;

	// Token: 0x04003F1F RID: 16159
	[Token(Token = "0x4003F1F")]
	[FieldOffset(Offset = "0x50")]
	public int hallwayDistanceThreshold;

	// Token: 0x04003F20 RID: 16160
	[Token(Token = "0x4003F20")]
	[FieldOffset(Offset = "0x54")]
	public bool useBuildingDesignStyle;

	// Token: 0x04003F21 RID: 16161
	[Token(Token = "0x4003F21")]
	[FieldOffset(Offset = "0x55")]
	public bool overrideEvidencePhotoSettings;

	// Token: 0x04003F22 RID: 16162
	[Token(Token = "0x4003F22")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 relativeCamPhotoPos;

	// Token: 0x04003F23 RID: 16163
	[Token(Token = "0x4003F23")]
	[FieldOffset(Offset = "0x64")]
	public Vector3 relativeCamPhotoEuler;

	// Token: 0x04003F24 RID: 16164
	[Token(Token = "0x4003F24")]
	[FieldOffset(Offset = "0x70")]
	public List<DoorPairPreset> doorwaysNormal;

	// Token: 0x04003F25 RID: 16165
	[Token(Token = "0x4003F25")]
	[FieldOffset(Offset = "0x78")]
	public List<DoorPairPreset> doorwaysFlat;

	// Token: 0x04003F26 RID: 16166
	[Token(Token = "0x4003F26")]
	[FieldOffset(Offset = "0x80")]
	public List<DoorPairPreset> roomDividersLeft;

	// Token: 0x04003F27 RID: 16167
	[Token(Token = "0x4003F27")]
	[FieldOffset(Offset = "0x88")]
	public List<DoorPairPreset> roomDividersCentre;

	// Token: 0x04003F28 RID: 16168
	[Token(Token = "0x4003F28")]
	[FieldOffset(Offset = "0x90")]
	public List<DoorPairPreset> roomDividersRight;
}
