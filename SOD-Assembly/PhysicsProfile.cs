using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200086C RID: 2156
[Token(Token = "0x200086C")]
public class PhysicsProfile : SoCustomComparison
{
	// Token: 0x060029D6 RID: 10710 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029D6")]
	[Address(RVA = "0xCB09A0", Offset = "0xCAF9A0", VA = "0x180CB09A0")]
	public PhysicsProfile()
	{
	}

	// Token: 0x04004179 RID: 16761
	[Token(Token = "0x4004179")]
	[FieldOffset(Offset = "0x20")]
	public float mass;

	// Token: 0x0400417A RID: 16762
	[Token(Token = "0x400417A")]
	[FieldOffset(Offset = "0x24")]
	public float drag;

	// Token: 0x0400417B RID: 16763
	[Token(Token = "0x400417B")]
	[FieldOffset(Offset = "0x28")]
	public float angularDrag;

	// Token: 0x0400417C RID: 16764
	[Token(Token = "0x400417C")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 heldEuler;

	// Token: 0x0400417D RID: 16765
	[Token(Token = "0x400417D")]
	[FieldOffset(Offset = "0x38")]
	public float tamperDistanceModifier;

	// Token: 0x0400417E RID: 16766
	[Token(Token = "0x400417E")]
	[FieldOffset(Offset = "0x3C")]
	public float throwForceMultiplier;

	// Token: 0x0400417F RID: 16767
	[Token(Token = "0x400417F")]
	[FieldOffset(Offset = "0x40")]
	public float throwDamageMultiplier;

	// Token: 0x04004180 RID: 16768
	[Token(Token = "0x4004180")]
	[FieldOffset(Offset = "0x44")]
	public bool treatAsCausedByPlayer;

	// Token: 0x04004181 RID: 16769
	[Token(Token = "0x4004181")]
	[FieldOffset(Offset = "0x48")]
	public CollisionDetectionMode collisionMode;

	// Token: 0x04004182 RID: 16770
	[Token(Token = "0x4004182")]
	[FieldOffset(Offset = "0x4C")]
	public bool removeOnReset;

	// Token: 0x04004183 RID: 16771
	[Token(Token = "0x4004183")]
	[FieldOffset(Offset = "0x50")]
	public AudioEvent physicsCollisionAudio;

	// Token: 0x04004184 RID: 16772
	[Token(Token = "0x4004184")]
	[FieldOffset(Offset = "0x58")]
	public bool useDifferentSoundForWallImpacts;

	// Token: 0x04004185 RID: 16773
	[Token(Token = "0x4004185")]
	[FieldOffset(Offset = "0x60")]
	public AudioEvent wallCollisionAudio;
}
