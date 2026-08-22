using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007C9 RID: 1993
[Token(Token = "0x20007C9")]
public class DoorMovementPreset : SoCustomComparison
{
	// Token: 0x06002959 RID: 10585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002959")]
	[Address(RVA = "0xCA4260", Offset = "0xCA3260", VA = "0x180CA4260")]
	public DoorMovementPreset()
	{
	}

	// Token: 0x0400398A RID: 14730
	[Token(Token = "0x400398A")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 closedRelativePos;

	// Token: 0x0400398B RID: 14731
	[Token(Token = "0x400398B")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 openRelativePos;

	// Token: 0x0400398C RID: 14732
	[Token(Token = "0x400398C")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 closedRelativeEuler;

	// Token: 0x0400398D RID: 14733
	[Token(Token = "0x400398D")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 openRelativeEuler;

	// Token: 0x0400398E RID: 14734
	[Token(Token = "0x400398E")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 closedRelativeScale;

	// Token: 0x0400398F RID: 14735
	[Token(Token = "0x400398F")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 openRelativeScale;

	// Token: 0x04003990 RID: 14736
	[Token(Token = "0x4003990")]
	[FieldOffset(Offset = "0x68")]
	public float doorOpenSpeed;

	// Token: 0x04003991 RID: 14737
	[Token(Token = "0x4003991")]
	[FieldOffset(Offset = "0x6C")]
	public float doorCloseSpeed;

	// Token: 0x04003992 RID: 14738
	[Token(Token = "0x4003992")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve animationCurve;

	// Token: 0x04003993 RID: 14739
	[Token(Token = "0x4003993")]
	[FieldOffset(Offset = "0x78")]
	public DoorMovementPreset.PhysicsBehaviour collisionBehaviour;

	// Token: 0x04003994 RID: 14740
	[Token(Token = "0x4003994")]
	[FieldOffset(Offset = "0x7C")]
	public bool behaviourAppliesWhenOpening;

	// Token: 0x04003995 RID: 14741
	[Token(Token = "0x4003995")]
	[FieldOffset(Offset = "0x7D")]
	public bool behaviourAppliesWhenClosing;

	// Token: 0x04003996 RID: 14742
	[Token(Token = "0x4003996")]
	[FieldOffset(Offset = "0x80")]
	public AudioEvent openAction;

	// Token: 0x04003997 RID: 14743
	[Token(Token = "0x4003997")]
	[FieldOffset(Offset = "0x88")]
	public AudioEvent closeAction;

	// Token: 0x04003998 RID: 14744
	[Token(Token = "0x4003998")]
	[FieldOffset(Offset = "0x90")]
	public AudioEvent openFinished;

	// Token: 0x04003999 RID: 14745
	[Token(Token = "0x4003999")]
	[FieldOffset(Offset = "0x98")]
	public AudioEvent closeFinished;

	// Token: 0x0400399A RID: 14746
	[Token(Token = "0x400399A")]
	[FieldOffset(Offset = "0xA0")]
	public AudioEvent objectImpact;

	// Token: 0x0400399B RID: 14747
	[Token(Token = "0x400399B")]
	[FieldOffset(Offset = "0xA8")]
	public bool ignoreOcclusion;

	// Token: 0x0400399C RID: 14748
	[Token(Token = "0x400399C")]
	[FieldOffset(Offset = "0xA9")]
	public bool switchState1AnimationSync;

	// Token: 0x0400399D RID: 14749
	[Token(Token = "0x400399D")]
	[FieldOffset(Offset = "0xAA")]
	public bool useFixedUpdate;

	// Token: 0x020007CA RID: 1994
	[Token(Token = "0x20007CA")]
	public enum PhysicsBehaviour
	{
		// Token: 0x0400399F RID: 14751
		[Token(Token = "0x400399F")]
		ignore,
		// Token: 0x040039A0 RID: 14752
		[Token(Token = "0x40039A0")]
		physicsEnabled,
		// Token: 0x040039A1 RID: 14753
		[Token(Token = "0x40039A1")]
		stopDoorMovement
	}
}
