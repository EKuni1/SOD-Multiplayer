using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000836 RID: 2102
[Token(Token = "0x2000836")]
public class LightingPreset : SoCustomComparison
{
	// Token: 0x060029B7 RID: 10679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029B7")]
	[Address(RVA = "0xCAC780", Offset = "0xCAB780", VA = "0x180CAC780")]
	public LightingPreset()
	{
	}

	// Token: 0x04003F29 RID: 16169
	[Token(Token = "0x4003F29")]
	[FieldOffset(Offset = "0x20")]
	public List<CityControls.WindowColour> coolColours;

	// Token: 0x04003F2A RID: 16170
	[Token(Token = "0x4003F2A")]
	[FieldOffset(Offset = "0x28")]
	public List<CityControls.WindowColour> warmColours;

	// Token: 0x04003F2B RID: 16171
	[Token(Token = "0x4003F2B")]
	[FieldOffset(Offset = "0x30")]
	public float defaultIntensity;

	// Token: 0x04003F2C RID: 16172
	[Token(Token = "0x4003F2C")]
	[FieldOffset(Offset = "0x34")]
	public float defaultRange;

	// Token: 0x04003F2D RID: 16173
	[Token(Token = "0x4003F2D")]
	[FieldOffset(Offset = "0x38")]
	public float intensityRoomSizeMultiplier;

	// Token: 0x04003F2E RID: 16174
	[Token(Token = "0x4003F2E")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 intensityRange;

	// Token: 0x04003F2F RID: 16175
	[Token(Token = "0x4003F2F")]
	[FieldOffset(Offset = "0x44")]
	public bool fadeOnOff;

	// Token: 0x04003F30 RID: 16176
	[Token(Token = "0x4003F30")]
	[FieldOffset(Offset = "0x48")]
	public float fadeSpeed;

	// Token: 0x04003F31 RID: 16177
	[Token(Token = "0x4003F31")]
	[FieldOffset(Offset = "0x4C")]
	public bool onByDefault;

	// Token: 0x04003F32 RID: 16178
	[Token(Token = "0x4003F32")]
	[FieldOffset(Offset = "0x50")]
	public float fadeDistance;

	// Token: 0x04003F33 RID: 16179
	[Token(Token = "0x4003F33")]
	[FieldOffset(Offset = "0x54")]
	public bool useBroadcastMaterial;

	// Token: 0x04003F34 RID: 16180
	[Token(Token = "0x4003F34")]
	[FieldOffset(Offset = "0x58")]
	public Material useOnMaterial;

	// Token: 0x04003F35 RID: 16181
	[Token(Token = "0x4003F35")]
	[FieldOffset(Offset = "0x60")]
	public bool useInstancedEmissive;

	// Token: 0x04003F36 RID: 16182
	[Token(Token = "0x4003F36")]
	[FieldOffset(Offset = "0x64")]
	public float emissionMultiplier;

	// Token: 0x04003F37 RID: 16183
	[Token(Token = "0x4003F37")]
	[FieldOffset(Offset = "0x68")]
	public bool isAtriumLight;

	// Token: 0x04003F38 RID: 16184
	[Token(Token = "0x4003F38")]
	[FieldOffset(Offset = "0x6C")]
	public int minimumFloors;

	// Token: 0x04003F39 RID: 16185
	[Token(Token = "0x4003F39")]
	[FieldOffset(Offset = "0x70")]
	public GameObject cablePrefab;

	// Token: 0x04003F3A RID: 16186
	[Token(Token = "0x4003F3A")]
	[FieldOffset(Offset = "0x78")]
	public GameObject bulbPrefab;

	// Token: 0x04003F3B RID: 16187
	[Token(Token = "0x4003F3B")]
	[FieldOffset(Offset = "0x80")]
	public GameObject endBulbPrefab;

	// Token: 0x04003F3C RID: 16188
	[Token(Token = "0x4003F3C")]
	[FieldOffset(Offset = "0x88")]
	public float heightInterval;

	// Token: 0x04003F3D RID: 16189
	[Token(Token = "0x4003F3D")]
	[FieldOffset(Offset = "0x8C")]
	public bool allowCeilingFans;

	// Token: 0x04003F3E RID: 16190
	[Token(Token = "0x4003F3E")]
	[FieldOffset(Offset = "0x8D")]
	public bool enableVolumetrics;

	// Token: 0x04003F3F RID: 16191
	[Token(Token = "0x4003F3F")]
	[FieldOffset(Offset = "0x90")]
	public float atmosphereMultiplier;

	// Token: 0x04003F40 RID: 16192
	[Token(Token = "0x4003F40")]
	[FieldOffset(Offset = "0x94")]
	public bool enableShadows;

	// Token: 0x04003F41 RID: 16193
	[Token(Token = "0x4003F41")]
	[FieldOffset(Offset = "0x98")]
	public LightingPreset.ShadowMode shadowMode;

	// Token: 0x04003F42 RID: 16194
	[Token(Token = "0x4003F42")]
	[FieldOffset(Offset = "0x9C")]
	public LightingPreset.ShadowResolution resolution;

	// Token: 0x04003F43 RID: 16195
	[Token(Token = "0x4003F43")]
	[FieldOffset(Offset = "0xA0")]
	public float shadowFadeDistance;

	// Token: 0x04003F44 RID: 16196
	[Token(Token = "0x4003F44")]
	[FieldOffset(Offset = "0xA4")]
	public float chanceOfFlicker;

	// Token: 0x04003F45 RID: 16197
	[Token(Token = "0x4003F45")]
	[FieldOffset(Offset = "0xA8")]
	public Vector2 flickerMultiplierRange;

	// Token: 0x04003F46 RID: 16198
	[Token(Token = "0x4003F46")]
	[FieldOffset(Offset = "0xB0")]
	public Vector2 flickerPulseRange;

	// Token: 0x04003F47 RID: 16199
	[Token(Token = "0x4003F47")]
	[FieldOffset(Offset = "0xB8")]
	public Vector2 flickerIntervalRange;

	// Token: 0x04003F48 RID: 16200
	[Token(Token = "0x4003F48")]
	[FieldOffset(Offset = "0xC0")]
	public Vector2 flickerNormalityIntervalRange;

	// Token: 0x02000837 RID: 2103
	[Token(Token = "0x2000837")]
	public enum ShadowMode
	{
		// Token: 0x04003F4A RID: 16202
		[Token(Token = "0x4003F4A")]
		everyFrame,
		// Token: 0x04003F4B RID: 16203
		[Token(Token = "0x4003F4B")]
		onEnable,
		// Token: 0x04003F4C RID: 16204
		[Token(Token = "0x4003F4C")]
		onDemand,
		// Token: 0x04003F4D RID: 16205
		[Token(Token = "0x4003F4D")]
		dynamicSystemStatic,
		// Token: 0x04003F4E RID: 16206
		[Token(Token = "0x4003F4E")]
		dynamicSystemSlowerUpdate
	}

	// Token: 0x02000838 RID: 2104
	[Token(Token = "0x2000838")]
	public enum ShadowResolution
	{
		// Token: 0x04003F50 RID: 16208
		[Token(Token = "0x4003F50")]
		low,
		// Token: 0x04003F51 RID: 16209
		[Token(Token = "0x4003F51")]
		medium,
		// Token: 0x04003F52 RID: 16210
		[Token(Token = "0x4003F52")]
		high,
		// Token: 0x04003F53 RID: 16211
		[Token(Token = "0x4003F53")]
		ultra
	}
}
