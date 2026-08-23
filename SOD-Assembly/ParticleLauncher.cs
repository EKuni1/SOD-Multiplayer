using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004AA RID: 1194
[Token(Token = "0x20004AA")]
public class ParticleLauncher : MonoBehaviour
{
	// Token: 0x06001AE5 RID: 6885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE5")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	private void Awake()
	{
	}

	// Token: 0x06001AE6 RID: 6886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE6")]
	[Address(RVA = "0x99D6B0", Offset = "0x99C6B0", VA = "0x18099D6B0")]
	private void OnParticleCollision(GameObject other)
	{
	}

	// Token: 0x06001AE7 RID: 6887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE7")]
	[Address(RVA = "0x99D830", Offset = "0x99C830", VA = "0x18099D830")]
	private void EmitAtLocation(ParticleCollisionEvent particleCollisionEvent)
	{
	}

	// Token: 0x06001AE8 RID: 6888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE8")]
	[Address(RVA = "0x99DC90", Offset = "0x99CC90", VA = "0x18099DC90")]
	private void Update()
	{
	}

	// Token: 0x06001AE9 RID: 6889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AE9")]
	[Address(RVA = "0x99E030", Offset = "0x99D030", VA = "0x18099E030")]
	public ParticleLauncher()
	{
	}

	// Token: 0x040020FE RID: 8446
	[Token(Token = "0x40020FE")]
	[FieldOffset(Offset = "0x18")]
	public int particles;

	// Token: 0x040020FF RID: 8447
	[Token(Token = "0x40020FF")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem particleLauncher;

	// Token: 0x04002100 RID: 8448
	[Token(Token = "0x4002100")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem splatterParticles;

	// Token: 0x04002101 RID: 8449
	[Token(Token = "0x4002101")]
	[FieldOffset(Offset = "0x30")]
	public Gradient particleColorGradient;

	// Token: 0x04002102 RID: 8450
	[Token(Token = "0x4002102")]
	[FieldOffset(Offset = "0x38")]
	public ParticleDecalPool splatDecalPool;

	// Token: 0x04002103 RID: 8451
	[Token(Token = "0x4002103")]
	[FieldOffset(Offset = "0x40")]
	private List<ParticleCollisionEvent> collisionEvents;
}
