using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004AB RID: 1195
[Token(Token = "0x20004AB")]
public class SplatOnCollision : MonoBehaviour
{
	// Token: 0x06001AEA RID: 6890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AEA")]
	[Address(RVA = "0x99E130", Offset = "0x99D130", VA = "0x18099E130")]
	private void Start()
	{
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AEB")]
	[Address(RVA = "0x99E1F0", Offset = "0x99D1F0", VA = "0x18099E1F0")]
	private void OnParticleCollision(GameObject other)
	{
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AEC")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public SplatOnCollision()
	{
	}

	// Token: 0x04002104 RID: 8452
	[Token(Token = "0x4002104")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem particleLauncher;

	// Token: 0x04002105 RID: 8453
	[Token(Token = "0x4002105")]
	[FieldOffset(Offset = "0x20")]
	public Gradient particleColorGradient;

	// Token: 0x04002106 RID: 8454
	[Token(Token = "0x4002106")]
	[FieldOffset(Offset = "0x28")]
	public ParticleDecalPool dropletDecalPool;

	// Token: 0x04002107 RID: 8455
	[Token(Token = "0x4002107")]
	[FieldOffset(Offset = "0x30")]
	private List<ParticleCollisionEvent> collisionEvents;
}
