using System;
using Il2CppDummyDll;

// Token: 0x02000764 RID: 1892
[Token(Token = "0x2000764")]
public class AmbientZone : SoCustomComparison
{
	// Token: 0x060028F9 RID: 10489 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028F9")]
	[Address(RVA = "0xC67170", Offset = "0xC66170", VA = "0x180C67170")]
	public AmbientZone()
	{
	}

	// Token: 0x04003605 RID: 13829
	[Token(Token = "0x4003605")]
	[FieldOffset(Offset = "0x20")]
	public AudioEvent mainEvent;

	// Token: 0x04003606 RID: 13830
	[Token(Token = "0x4003606")]
	[FieldOffset(Offset = "0x28")]
	public bool useOcclusion;

	// Token: 0x04003607 RID: 13831
	[Token(Token = "0x4003607")]
	[FieldOffset(Offset = "0x2C")]
	public float maxRange;

	// Token: 0x04003608 RID: 13832
	[Token(Token = "0x4003608")]
	[FieldOffset(Offset = "0x30")]
	public bool canPenetrateClosedDoors;

	// Token: 0x04003609 RID: 13833
	[Token(Token = "0x4003609")]
	[FieldOffset(Offset = "0x31")]
	public bool overrideOcclusionModifier;

	// Token: 0x0400360A RID: 13834
	[Token(Token = "0x400360A")]
	[FieldOffset(Offset = "0x34")]
	public float occlusionUnitVolumeModifier;

	// Token: 0x0400360B RID: 13835
	[Token(Token = "0x400360B")]
	[FieldOffset(Offset = "0x38")]
	public bool isAirDuctAmbience;

	// Token: 0x0400360C RID: 13836
	[Token(Token = "0x400360C")]
	[FieldOffset(Offset = "0x39")]
	public bool passTimeOfDay;

	// Token: 0x0400360D RID: 13837
	[Token(Token = "0x400360D")]
	[FieldOffset(Offset = "0x3A")]
	public bool passWalla;

	// Token: 0x0400360E RID: 13838
	[Token(Token = "0x400360E")]
	[FieldOffset(Offset = "0x3B")]
	public bool passPlayerInVent;

	// Token: 0x0400360F RID: 13839
	[Token(Token = "0x400360F")]
	[FieldOffset(Offset = "0x3C")]
	public bool passPlayerVentExtInt;

	// Token: 0x04003610 RID: 13840
	[Token(Token = "0x4003610")]
	[FieldOffset(Offset = "0x3D")]
	public bool passDistanceToVent;

	// Token: 0x04003611 RID: 13841
	[Token(Token = "0x4003611")]
	[FieldOffset(Offset = "0x3E")]
	public bool passRain;

	// Token: 0x04003612 RID: 13842
	[Token(Token = "0x4003612")]
	[FieldOffset(Offset = "0x3F")]
	public bool passBasement;

	// Token: 0x04003613 RID: 13843
	[Token(Token = "0x4003613")]
	[FieldOffset(Offset = "0x40")]
	public bool passHeightWindSpeed;

	// Token: 0x04003614 RID: 13844
	[Token(Token = "0x4003614")]
	[FieldOffset(Offset = "0x41")]
	public bool passEdgeDistance;

	// Token: 0x04003615 RID: 13845
	[Token(Token = "0x4003615")]
	[FieldOffset(Offset = "0x44")]
	public float maxWallaRange;

	// Token: 0x04003616 RID: 13846
	[Token(Token = "0x4003616")]
	[FieldOffset(Offset = "0x48")]
	public float maxWallaCrowd;
}
