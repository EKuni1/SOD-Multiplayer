using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007E5 RID: 2021
[Token(Token = "0x20007E5")]
public class FogPreset : SoCustomComparison
{
	// Token: 0x06002972 RID: 10610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002972")]
	[Address(RVA = "0xCA6260", Offset = "0xCA5260", VA = "0x180CA6260")]
	public FogPreset()
	{
	}

	// Token: 0x04003AB6 RID: 15030
	[Token(Token = "0x4003AB6")]
	[FieldOffset(Offset = "0x20")]
	public float sunRiseHour;

	// Token: 0x04003AB7 RID: 15031
	[Token(Token = "0x4003AB7")]
	[FieldOffset(Offset = "0x24")]
	public float sunSetHour;

	// Token: 0x04003AB8 RID: 15032
	[Token(Token = "0x4003AB8")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve daytimeSunIntensityCurve;

	// Token: 0x04003AB9 RID: 15033
	[Token(Token = "0x4003AB9")]
	[FieldOffset(Offset = "0x30")]
	public float sunIntensityBooster;

	// Token: 0x04003ABA RID: 15034
	[Token(Token = "0x4003ABA")]
	[FieldOffset(Offset = "0x34")]
	public Color morningSunColour;

	// Token: 0x04003ABB RID: 15035
	[Token(Token = "0x4003ABB")]
	[FieldOffset(Offset = "0x44")]
	public Color middaySunColour;

	// Token: 0x04003ABC RID: 15036
	[Token(Token = "0x4003ABC")]
	[FieldOffset(Offset = "0x54")]
	public Color eveningSunColour;

	// Token: 0x04003ABD RID: 15037
	[Token(Token = "0x4003ABD")]
	[FieldOffset(Offset = "0x68")]
	public AnimationCurve sunShadowStrengthCurve;

	// Token: 0x04003ABE RID: 15038
	[Token(Token = "0x4003ABE")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve sunVolumetricDimmer;

	// Token: 0x04003ABF RID: 15039
	[Token(Token = "0x4003ABF")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve sunVolumetricShadowDimmer;

	// Token: 0x04003AC0 RID: 15040
	[Token(Token = "0x4003AC0")]
	[FieldOffset(Offset = "0x80")]
	public AnimationCurve exteriorAmbientIntensityCurve;

	// Token: 0x04003AC1 RID: 15041
	[Token(Token = "0x4003AC1")]
	[FieldOffset(Offset = "0x88")]
	public float ambientExteriorBooster;

	// Token: 0x04003AC2 RID: 15042
	[Token(Token = "0x4003AC2")]
	[FieldOffset(Offset = "0x90")]
	public AnimationCurve interiorAmbientIntensityCurve;

	// Token: 0x04003AC3 RID: 15043
	[Token(Token = "0x4003AC3")]
	[FieldOffset(Offset = "0x98")]
	public float ambientInteriorBooster;

	// Token: 0x04003AC4 RID: 15044
	[Token(Token = "0x4003AC4")]
	[FieldOffset(Offset = "0xA0")]
	public List<SessionData.SkyboxGradient> skyboxGradientGrading;

	// Token: 0x04003AC5 RID: 15045
	[Token(Token = "0x4003AC5")]
	[FieldOffset(Offset = "0xA8")]
	public float skyColourMultiplier;

	// Token: 0x04003AC6 RID: 15046
	[Token(Token = "0x4003AC6")]
	[FieldOffset(Offset = "0xAC")]
	public float fogColourMultiplier;

	// Token: 0x04003AC7 RID: 15047
	[Token(Token = "0x4003AC7")]
	[FieldOffset(Offset = "0xB0")]
	public float ambientLightMultiplier;

	// Token: 0x04003AC8 RID: 15048
	[Token(Token = "0x4003AC8")]
	[FieldOffset(Offset = "0xB4")]
	public float globalLightIntensityMultiplier;

	// Token: 0x04003AC9 RID: 15049
	[Token(Token = "0x4003AC9")]
	[FieldOffset(Offset = "0xB8")]
	public Vector2 fogDistanceRange;

	// Token: 0x04003ACA RID: 15050
	[Token(Token = "0x4003ACA")]
	[FieldOffset(Offset = "0xC0")]
	public AnimationCurve fogDistanceCurve;

	// Token: 0x04003ACB RID: 15051
	[Token(Token = "0x4003ACB")]
	[FieldOffset(Offset = "0xC8")]
	public Vector2 maxFogDistanceRange;

	// Token: 0x04003ACC RID: 15052
	[Token(Token = "0x4003ACC")]
	[FieldOffset(Offset = "0xD0")]
	public AnimationCurve maxFogDistanceCurve;

	// Token: 0x04003ACD RID: 15053
	[Token(Token = "0x4003ACD")]
	[FieldOffset(Offset = "0xD8")]
	public AnimationCurve fogAttenuationCurve;

	// Token: 0x04003ACE RID: 15054
	[Token(Token = "0x4003ACE")]
	[FieldOffset(Offset = "0xE0")]
	public AnimationCurve volumetricFogDistanceCurve;

	// Token: 0x04003ACF RID: 15055
	[Token(Token = "0x4003ACF")]
	[FieldOffset(Offset = "0xE8")]
	public AnimationCurve skylineEmissionCurve;

	// Token: 0x04003AD0 RID: 15056
	[Token(Token = "0x4003AD0")]
	[FieldOffset(Offset = "0xF0")]
	public Color skylineEmissionColor;

	// Token: 0x04003AD1 RID: 15057
	[Token(Token = "0x4003AD1")]
	[FieldOffset(Offset = "0x100")]
	public AnimationCurve monthSnowChanceCurve;

	// Token: 0x04003AD2 RID: 15058
	[Token(Token = "0x4003AD2")]
	[FieldOffset(Offset = "0x108")]
	public AnimationCurve weatherExtremityCurve;

	// Token: 0x04003AD3 RID: 15059
	[Token(Token = "0x4003AD3")]
	[FieldOffset(Offset = "0x110")]
	public float thunderDelay;

	// Token: 0x04003AD4 RID: 15060
	[Token(Token = "0x4003AD4")]
	[FieldOffset(Offset = "0x118")]
	public AnimationCurve monthTempCurve;

	// Token: 0x04003AD5 RID: 15061
	[Token(Token = "0x4003AD5")]
	[FieldOffset(Offset = "0x120")]
	public AnimationCurve dayTempCurve;

	// Token: 0x04003AD6 RID: 15062
	[Token(Token = "0x4003AD6")]
	[FieldOffset(Offset = "0x128")]
	public float NoRainModifier;

	// Token: 0x04003AD7 RID: 15063
	[Token(Token = "0x4003AD7")]
	[FieldOffset(Offset = "0x12C")]
	public float NoWindModifier;

	// Token: 0x04003AD8 RID: 15064
	[Token(Token = "0x4003AD8")]
	[FieldOffset(Offset = "0x130")]
	public float NoSnowModifier;
}
