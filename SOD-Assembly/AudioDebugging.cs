using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200021B RID: 539
[Token(Token = "0x200021B")]
public class AudioDebugging : MonoBehaviour
{
	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700006E")]
	public static AudioDebugging Instance
	{
		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x597B90", Offset = "0x596B90", VA = "0x180597B90")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C76")]
	[Address(RVA = "0x597BD0", Offset = "0x596BD0", VA = "0x180597BD0")]
	private void Awake()
	{
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x597F20", Offset = "0x596F20", VA = "0x180597F20")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C78")]
	[Address(RVA = "0x598130", Offset = "0x597130", VA = "0x180598130")]
	public void SpawnObject()
	{
	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x598510", Offset = "0x597510", VA = "0x180598510")]
	public void TriggerNextTVShow()
	{
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0x5985A0", Offset = "0x5975A0", VA = "0x1805985A0")]
	public AudioDebugging()
	{
	}

	// Token: 0x04000DA3 RID: 3491
	[Token(Token = "0x4000DA3")]
	[FieldOffset(Offset = "0x18")]
	public bool overrideSmokeStackEmissionFrequency;

	// Token: 0x04000DA4 RID: 3492
	[Token(Token = "0x4000DA4")]
	[FieldOffset(Offset = "0x1C")]
	public float chemSmokeStackEmissionFrequency;

	// Token: 0x04000DA5 RID: 3493
	[Token(Token = "0x4000DA5")]
	[FieldOffset(Offset = "0x20")]
	public bool overrideThunderDelay;

	// Token: 0x04000DA6 RID: 3494
	[Token(Token = "0x4000DA6")]
	[FieldOffset(Offset = "0x24")]
	public float thunderDelay;

	// Token: 0x04000DA7 RID: 3495
	[Token(Token = "0x4000DA7")]
	[FieldOffset(Offset = "0x28")]
	public float thunderDistanceThreshold;

	// Token: 0x04000DA8 RID: 3496
	[Token(Token = "0x4000DA8")]
	[FieldOffset(Offset = "0x2C")]
	public float doorCloseTriggerPoint;

	// Token: 0x04000DA9 RID: 3497
	[Token(Token = "0x4000DA9")]
	[FieldOffset(Offset = "0x30")]
	public float citizenFootstepDistanceMultiplier;

	// Token: 0x04000DAA RID: 3498
	[Token(Token = "0x4000DAA")]
	[FieldOffset(Offset = "0x38")]
	public InteractablePreset spawnObject;

	// Token: 0x04000DAB RID: 3499
	[Token(Token = "0x4000DAB")]
	[FieldOffset(Offset = "0x0")]
	private static AudioDebugging _instance;
}
