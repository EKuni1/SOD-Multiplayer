using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000050 RID: 80
[Token(Token = "0x2000050")]
public class Citizen : Human
{
	// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000323")]
	[Address(RVA = "0xDC78C0", Offset = "0xDC68C0", VA = "0x180DC78C0", Slot = "4")]
	public override void SetupEvidence()
	{
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000324")]
	[Address(RVA = "0xDC7A80", Offset = "0xDC6A80", VA = "0x180DC7A80")]
	public void BirthdayCheck()
	{
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000325")]
	[Address(RVA = "0xDC88B0", Offset = "0xDC78B0", VA = "0x180DC88B0", Slot = "27")]
	public override void RecieveDamage(float amount, Actor fromWho, Vector3 damagePosition, Vector3 damageDirection, SpatterPatternPreset forwardSpatter, SpatterPatternPreset backSpatter, SpatterSimulation.EraseMode spatterErase = SpatterSimulation.EraseMode.onceExecutedAndOutOfAddressPlusDespawnTime, bool alertSurrounding = true, bool forceRagdoll = false, float forcedRagdollDuration = 0f, float shockMP = 1f, bool enableKill = false, bool allowRecoil = true, float ragdollForceMP = 1f)
	{
	}

	// Token: 0x06000326 RID: 806 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000326")]
	[Address(RVA = "0xDCA200", Offset = "0xDC9200", VA = "0x180DCA200", Slot = "39")]
	public override void SetCombatSkill(float newSkill)
	{
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000327")]
	[Address(RVA = "0xDCA380", Offset = "0xDC9380", VA = "0x180DCA380")]
	public void CreateWoundClosestToPoint(Vector3 point, Vector3 normal, InteractablePreset woundPreset, MurderWeaponPreset weapon)
	{
	}

	// Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000328")]
	[Address(RVA = "0xDCAC20", Offset = "0xDC9C20", VA = "0x180DCAC20")]
	public Citizen()
	{
	}

	// Token: 0x04000289 RID: 649
	[Token(Token = "0x4000289")]
	[FieldOffset(Offset = "0x5B8")]
	public bool alwaysPassDialogSuccess;

	// Token: 0x0400028A RID: 650
	[Token(Token = "0x400028A")]
	[FieldOffset(Offset = "0x5BC")]
	[NonSerialized]
	public float customSort;

	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	private sealed class <>c__DisplayClass4_0
	{
		// Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass4_0()
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x600032A")]
		[Address(RVA = "0xDCAC70", Offset = "0xDC9C70", VA = "0x180DCAC70")]
		internal bool <RecieveDamage>b__1(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x10")]
		public Citizen <>4__this;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x18")]
		public Actor fromWho;
	}

	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600032C RID: 812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x600032D")]
		[Address(RVA = "0xDCB010", Offset = "0xDCA010", VA = "0x180DCB010")]
		internal bool <RecieveDamage>b__4_0(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Citizen.<>c <>9;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<NewAIGoal> <>9__4_0;
	}
}
