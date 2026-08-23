using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002FC RID: 764
[Token(Token = "0x20002FC")]
public class DamageColliderController : MonoBehaviour
{
	// Token: 0x060010D3 RID: 4307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D3")]
	[Address(RVA = "0x6B0B00", Offset = "0x6AFB00", VA = "0x1806B0B00")]
	public void Setup(Actor newAttacker, Actor newTarget, float newDamage, Human newEnableKill, MurderWeaponPreset newWeapon)
	{
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D4")]
	[Address(RVA = "0x6B0FB0", Offset = "0x6AFFB0", VA = "0x1806B0FB0")]
	private void OnCollisionEnter(Collision other)
	{
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D5")]
	[Address(RVA = "0x6B1870", Offset = "0x6B0870", VA = "0x1806B1870")]
	private void OnControllerColliderHit(ControllerColliderHit other)
	{
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D6")]
	[Address(RVA = "0x6B1A10", Offset = "0x6B0A10", VA = "0x1806B1A10")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D7")]
	[Address(RVA = "0x6B1F70", Offset = "0x6B0F70", VA = "0x1806B1F70")]
	private void ProcessHit(Actor hit, Vector3 contactPoint, Vector3 contactNormal)
	{
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010D8")]
	[Address(RVA = "0x6B3080", Offset = "0x6B2080", VA = "0x1806B3080")]
	public DamageColliderController()
	{
	}

	// Token: 0x0400147C RID: 5244
	[Token(Token = "0x400147C")]
	[FieldOffset(Offset = "0x18")]
	public Collider coll;

	// Token: 0x0400147D RID: 5245
	[Token(Token = "0x400147D")]
	[FieldOffset(Offset = "0x20")]
	public Actor attacker;

	// Token: 0x0400147E RID: 5246
	[Token(Token = "0x400147E")]
	[FieldOffset(Offset = "0x28")]
	public Actor target;

	// Token: 0x0400147F RID: 5247
	[Token(Token = "0x400147F")]
	[FieldOffset(Offset = "0x30")]
	public float damage;

	// Token: 0x04001480 RID: 5248
	[Token(Token = "0x4001480")]
	[FieldOffset(Offset = "0x38")]
	public Human enableKill;

	// Token: 0x04001481 RID: 5249
	[Token(Token = "0x4001481")]
	[FieldOffset(Offset = "0x40")]
	public MurderWeaponPreset weapon;
}
