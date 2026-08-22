using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004A9 RID: 1193
[Token(Token = "0x20004A9")]
public class ParticleDecalPool : MonoBehaviour
{
	// Token: 0x06001AE0 RID: 6880 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE0")]
	[Address(RVA = "0x99CCB0", Offset = "0x99BCB0", VA = "0x18099CCB0")]
	private void Start()
	{
	}

	// Token: 0x06001AE1 RID: 6881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE1")]
	[Address(RVA = "0x99CF40", Offset = "0x99BF40", VA = "0x18099CF40")]
	public void ParticleHit(ParticleCollisionEvent particleCollisionEvent, Gradient colorGradient)
	{
	}

	// Token: 0x06001AE2 RID: 6882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE2")]
	[Address(RVA = "0x99CF90", Offset = "0x99BF90", VA = "0x18099CF90")]
	private void SetParticleData(ParticleCollisionEvent particleCollisionEvent, Gradient colorGradient)
	{
	}

	// Token: 0x06001AE3 RID: 6883 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE3")]
	[Address(RVA = "0x99D2D0", Offset = "0x99C2D0", VA = "0x18099D2D0")]
	private void DisplayParticles()
	{
	}

	// Token: 0x06001AE4 RID: 6884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE4")]
	[Address(RVA = "0x99D650", Offset = "0x99C650", VA = "0x18099D650")]
	public ParticleDecalPool()
	{
	}

	// Token: 0x040020F7 RID: 8439
	[Token(Token = "0x40020F7")]
	[FieldOffset(Offset = "0x18")]
	public int maxDecals;

	// Token: 0x040020F8 RID: 8440
	[Token(Token = "0x40020F8")]
	[FieldOffset(Offset = "0x1C")]
	public float decalSizeMin;

	// Token: 0x040020F9 RID: 8441
	[Token(Token = "0x40020F9")]
	[FieldOffset(Offset = "0x20")]
	public float decalSizeMax;

	// Token: 0x040020FA RID: 8442
	[Token(Token = "0x40020FA")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem decalParticleSystem;

	// Token: 0x040020FB RID: 8443
	[Token(Token = "0x40020FB")]
	[FieldOffset(Offset = "0x30")]
	private int particleDecalDataIndex;

	// Token: 0x040020FC RID: 8444
	[Token(Token = "0x40020FC")]
	[FieldOffset(Offset = "0x38")]
	private ParticleDecalData[] particleData;

	// Token: 0x040020FD RID: 8445
	[Token(Token = "0x40020FD")]
	[FieldOffset(Offset = "0x40")]
	private ParticleSystem.Particle[] particles;
}
