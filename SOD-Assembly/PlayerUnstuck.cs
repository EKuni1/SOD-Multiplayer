using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

// Token: 0x0200030D RID: 781
[Token(Token = "0x200030D")]
public class PlayerUnstuck : MonoBehaviour
{
	// Token: 0x06001114 RID: 4372 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001114")]
	[Address(RVA = "0x6BA8F0", Offset = "0x6B98F0", VA = "0x1806BA8F0")]
	private void Start()
	{
	}

	// Token: 0x06001115 RID: 4373 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001115")]
	[Address(RVA = "0x6BAA10", Offset = "0x6B9A10", VA = "0x1806BAA10")]
	private void Update()
	{
	}

	// Token: 0x06001116 RID: 4374 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001116")]
	[Address(RVA = "0x6BB1A0", Offset = "0x6BA1A0", VA = "0x1806BB1A0")]
	private void UnstuckTeleportPlayer()
	{
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001117")]
	[Address(RVA = "0x6BB970", Offset = "0x6BA970", VA = "0x1806BB970")]
	public PlayerUnstuck()
	{
	}

	// Token: 0x040014E2 RID: 5346
	[Token(Token = "0x40014E2")]
	[FieldOffset(Offset = "0x18")]
	public bool isAutomatic;

	// Token: 0x040014E3 RID: 5347
	[Token(Token = "0x40014E3")]
	[FieldOffset(Offset = "0x1C")]
	public float secondsUntilUnstuck;

	// Token: 0x040014E4 RID: 5348
	[Token(Token = "0x40014E4")]
	[FieldOffset(Offset = "0x20")]
	public float maxTeleportDistance;

	// Token: 0x040014E5 RID: 5349
	[Token(Token = "0x40014E5")]
	[FieldOffset(Offset = "0x24")]
	public float ColliderSizePercent;

	// Token: 0x040014E6 RID: 5350
	[Token(Token = "0x40014E6")]
	[FieldOffset(Offset = "0x28")]
	private float currentAttemptedSecondsOfMovement;

	// Token: 0x040014E7 RID: 5351
	[Token(Token = "0x40014E7")]
	[FieldOffset(Offset = "0x2C")]
	public LayerMask layerMask;

	// Token: 0x040014E8 RID: 5352
	[Token(Token = "0x40014E8")]
	[FieldOffset(Offset = "0x30")]
	private FirstPersonController firstPersonController;

	// Token: 0x040014E9 RID: 5353
	[Token(Token = "0x40014E9")]
	[FieldOffset(Offset = "0x38")]
	private CharacterController characterController;

	// Token: 0x040014EA RID: 5354
	[Token(Token = "0x40014EA")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 previousPosition;
}
