using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000890 RID: 2192
[Token(Token = "0x2000890")]
public class StairwellPreset : SoCustomComparison
{
	// Token: 0x06002A00 RID: 10752 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A00")]
	[Address(RVA = "0xCB3BB0", Offset = "0xCB2BB0", VA = "0x180CB3BB0")]
	public StairwellPreset()
	{
	}

	// Token: 0x0400432F RID: 17199
	[Token(Token = "0x400432F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject spawnObject;

	// Token: 0x04004330 RID: 17200
	[Token(Token = "0x4004330")]
	[FieldOffset(Offset = "0x28")]
	public GameObject objectTop;

	// Token: 0x04004331 RID: 17201
	[Token(Token = "0x4004331")]
	[FieldOffset(Offset = "0x30")]
	public GameObject centralSteps;

	// Token: 0x04004332 RID: 17202
	[Token(Token = "0x4004332")]
	[FieldOffset(Offset = "0x38")]
	public bool featuresElevator;

	// Token: 0x04004333 RID: 17203
	[Token(Token = "0x4004333")]
	[FieldOffset(Offset = "0x40")]
	public GameObject elevatorObject;

	// Token: 0x04004334 RID: 17204
	[Token(Token = "0x4004334")]
	[FieldOffset(Offset = "0x48")]
	public float elevatorMaxSpeed;

	// Token: 0x04004335 RID: 17205
	[Token(Token = "0x4004335")]
	[FieldOffset(Offset = "0x4C")]
	public float elevatorAcceleration;

	// Token: 0x04004336 RID: 17206
	[Token(Token = "0x4004336")]
	[FieldOffset(Offset = "0x50")]
	public float accelerateWhileThisFarAway;

	// Token: 0x04004337 RID: 17207
	[Token(Token = "0x4004337")]
	[FieldOffset(Offset = "0x54")]
	public float liftDelay;

	// Token: 0x04004338 RID: 17208
	[Token(Token = "0x4004338")]
	[FieldOffset(Offset = "0x58")]
	public float movementDelay;
}
