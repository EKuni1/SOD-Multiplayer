using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000852 RID: 2130
[Token(Token = "0x2000852")]
public class MurderWeaponPreset : SoCustomComparison
{
	// Token: 0x060029CA RID: 10698 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
	[Token(Token = "0x60029CA")]
	[Address(RVA = "0xCAEFC0", Offset = "0xCADFC0", VA = "0x180CAEFC0")]
	public float GetAttackValue(MurderWeaponPreset.AttackValue valueType, Human human)
	{
		return 0f;
	}

	// Token: 0x060029CB RID: 10699 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029CB")]
	[Address(RVA = "0xCAF1E0", Offset = "0xCAE1E0", VA = "0x180CAF1E0")]
	public MurderWeaponPreset()
	{
	}

	// Token: 0x04004056 RID: 16470
	[Token(Token = "0x4004056")]
	[FieldOffset(Offset = "0x20")]
	public MurderWeaponPreset.WeaponType type;

	// Token: 0x04004057 RID: 16471
	[Token(Token = "0x4004057")]
	[FieldOffset(Offset = "0x28")]
	public List<InteractablePreset> ammunition;

	// Token: 0x04004058 RID: 16472
	[Token(Token = "0x4004058")]
	[FieldOffset(Offset = "0x30")]
	public int murderDifficultyModifier;

	// Token: 0x04004059 RID: 16473
	[Token(Token = "0x4004059")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 muzzleOffset;

	// Token: 0x0400405A RID: 16474
	[Token(Token = "0x400405A")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 brassEjectOffset;

	// Token: 0x0400405B RID: 16475
	[Token(Token = "0x400405B")]
	[FieldOffset(Offset = "0x50")]
	public GameObject itemRightOverride;

	// Token: 0x0400405C RID: 16476
	[Token(Token = "0x400405C")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 itemRightLocalPos;

	// Token: 0x0400405D RID: 16477
	[Token(Token = "0x400405D")]
	[FieldOffset(Offset = "0x64")]
	public Vector3 itemRightLocalEuler;

	// Token: 0x0400405E RID: 16478
	[Token(Token = "0x400405E")]
	[FieldOffset(Offset = "0x70")]
	public GameObject itemLeftOverride;

	// Token: 0x0400405F RID: 16479
	[Token(Token = "0x400405F")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 itemLeftLocalPos;

	// Token: 0x04004060 RID: 16480
	[Token(Token = "0x4004060")]
	[FieldOffset(Offset = "0x84")]
	public Vector3 itemLeftLocalEuler;

	// Token: 0x04004061 RID: 16481
	[Token(Token = "0x4004061")]
	[FieldOffset(Offset = "0x90")]
	public bool overideUsesCarryAnimation;

	// Token: 0x04004062 RID: 16482
	[Token(Token = "0x4004062")]
	[FieldOffset(Offset = "0x94")]
	public int overrideCarryAnimation;

	// Token: 0x04004063 RID: 16483
	[Token(Token = "0x4004063")]
	[FieldOffset(Offset = "0x98")]
	public bool usedInPersonalDefence;

	// Token: 0x04004064 RID: 16484
	[Token(Token = "0x4004064")]
	[FieldOffset(Offset = "0x99")]
	public bool disabled;

	// Token: 0x04004065 RID: 16485
	[Token(Token = "0x4004065")]
	[FieldOffset(Offset = "0x9C")]
	public int basePriority;

	// Token: 0x04004066 RID: 16486
	[Token(Token = "0x4004066")]
	[FieldOffset(Offset = "0xA0")]
	public Vector2 socialClassRange;

	// Token: 0x04004067 RID: 16487
	[Token(Token = "0x4004067")]
	[FieldOffset(Offset = "0xA8")]
	public int citizenSpawningWithScore;

	// Token: 0x04004068 RID: 16488
	[Token(Token = "0x4004068")]
	[FieldOffset(Offset = "0xB0")]
	public List<MurderPreset.MurdererModifierRule> personalDefenceTraitModifiers;

	// Token: 0x04004069 RID: 16489
	[Token(Token = "0x4004069")]
	[FieldOffset(Offset = "0xB8")]
	public List<OccupationPreset> jobModifierList;

	// Token: 0x0400406A RID: 16490
	[Token(Token = "0x400406A")]
	[FieldOffset(Offset = "0xC0")]
	public int jobScoreModifier;

	// Token: 0x0400406B RID: 16491
	[Token(Token = "0x400406B")]
	[FieldOffset(Offset = "0xC4")]
	public float drawnNerveModifier;

	// Token: 0x0400406C RID: 16492
	[Token(Token = "0x400406C")]
	[FieldOffset(Offset = "0xC8")]
	public float barkTriggerChance;

	// Token: 0x0400406D RID: 16493
	[Token(Token = "0x400406D")]
	[FieldOffset(Offset = "0xCC")]
	public SpeechController.Bark bark;

	// Token: 0x0400406E RID: 16494
	[Token(Token = "0x400406E")]
	[FieldOffset(Offset = "0xD0")]
	public float incomingNerveDamageMultiplier;

	// Token: 0x0400406F RID: 16495
	[Token(Token = "0x400406F")]
	[FieldOffset(Offset = "0xD4")]
	public float attackTriggerPoint;

	// Token: 0x04004070 RID: 16496
	[Token(Token = "0x4004070")]
	[FieldOffset(Offset = "0xD8")]
	public float attackRemovePoint;

	// Token: 0x04004071 RID: 16497
	[Token(Token = "0x4004071")]
	[FieldOffset(Offset = "0xDC")]
	public int shots;

	// Token: 0x04004072 RID: 16498
	[Token(Token = "0x4004072")]
	[FieldOffset(Offset = "0xE0")]
	public Vector2 weaponMaxRange;

	// Token: 0x04004073 RID: 16499
	[Token(Token = "0x4004073")]
	[FieldOffset(Offset = "0xE8")]
	public float minimumRange;

	// Token: 0x04004074 RID: 16500
	[Token(Token = "0x4004074")]
	[FieldOffset(Offset = "0xEC")]
	public float maximumBulletRange;

	// Token: 0x04004075 RID: 16501
	[Token(Token = "0x4004075")]
	[FieldOffset(Offset = "0xF0")]
	public MurderWeaponPreset.StatMultiplier weaponRangeLerpSource;

	// Token: 0x04004076 RID: 16502
	[Token(Token = "0x4004076")]
	[FieldOffset(Offset = "0xF4")]
	public Vector2 fireDelay;

	// Token: 0x04004077 RID: 16503
	[Token(Token = "0x4004077")]
	[FieldOffset(Offset = "0xFC")]
	public MurderWeaponPreset.StatMultiplier fireDelayLerpSource;

	// Token: 0x04004078 RID: 16504
	[Token(Token = "0x4004078")]
	[FieldOffset(Offset = "0x100")]
	public Vector2 attackAccuracy;

	// Token: 0x04004079 RID: 16505
	[Token(Token = "0x4004079")]
	[FieldOffset(Offset = "0x108")]
	public MurderWeaponPreset.StatMultiplier attackAccuracyLerpSource;

	// Token: 0x0400407A RID: 16506
	[Token(Token = "0x400407A")]
	[FieldOffset(Offset = "0x10C")]
	public Vector2 attackDamage;

	// Token: 0x0400407B RID: 16507
	[Token(Token = "0x400407B")]
	[FieldOffset(Offset = "0x114")]
	public MurderWeaponPreset.StatMultiplier attackDamageLerpSource;

	// Token: 0x0400407C RID: 16508
	[Token(Token = "0x400407C")]
	[FieldOffset(Offset = "0x118")]
	public float applyPoison;

	// Token: 0x0400407D RID: 16509
	[Token(Token = "0x400407D")]
	[FieldOffset(Offset = "0x120")]
	public InteractablePreset shellCasing;

	// Token: 0x0400407E RID: 16510
	[Token(Token = "0x400407E")]
	[FieldOffset(Offset = "0x128")]
	public MurderWeaponPreset.EjectBrass ejectBrassSetting;

	// Token: 0x0400407F RID: 16511
	[Token(Token = "0x400407F")]
	[FieldOffset(Offset = "0x130")]
	public InteractablePreset bulletHole;

	// Token: 0x04004080 RID: 16512
	[Token(Token = "0x4004080")]
	[FieldOffset(Offset = "0x138")]
	public InteractablePreset glassBulletHole;

	// Token: 0x04004081 RID: 16513
	[Token(Token = "0x4004081")]
	[FieldOffset(Offset = "0x140")]
	public InteractablePreset entryWound;

	// Token: 0x04004082 RID: 16514
	[Token(Token = "0x4004082")]
	[FieldOffset(Offset = "0x148")]
	public GameObject bulletRicochet;

	// Token: 0x04004083 RID: 16515
	[Token(Token = "0x4004083")]
	[FieldOffset(Offset = "0x150")]
	public GameObject bulletImpactSpray;

	// Token: 0x04004084 RID: 16516
	[Token(Token = "0x4004084")]
	[FieldOffset(Offset = "0x158")]
	public GameObject muzzleFlash;

	// Token: 0x04004085 RID: 16517
	[Token(Token = "0x4004085")]
	[FieldOffset(Offset = "0x160")]
	public float bloodPoolAmount;

	// Token: 0x04004086 RID: 16518
	[Token(Token = "0x4004086")]
	[FieldOffset(Offset = "0x168")]
	public SpatterPatternPreset forwardSpatter;

	// Token: 0x04004087 RID: 16519
	[Token(Token = "0x4004087")]
	[FieldOffset(Offset = "0x170")]
	public SpatterPatternPreset backSpatter;

	// Token: 0x04004088 RID: 16520
	[Token(Token = "0x4004088")]
	[FieldOffset(Offset = "0x178")]
	public AudioEvent fireEvent;

	// Token: 0x04004089 RID: 16521
	[Token(Token = "0x4004089")]
	[FieldOffset(Offset = "0x180")]
	public AudioEvent impactEvent;

	// Token: 0x0400408A RID: 16522
	[Token(Token = "0x400408A")]
	[FieldOffset(Offset = "0x188")]
	public AudioEvent impactEventBody;

	// Token: 0x0400408B RID: 16523
	[Token(Token = "0x400408B")]
	[FieldOffset(Offset = "0x190")]
	public AudioEvent impactEventPlayer;

	// Token: 0x02000853 RID: 2131
	[Token(Token = "0x2000853")]
	public enum WeaponType
	{
		// Token: 0x0400408D RID: 16525
		[Token(Token = "0x400408D")]
		handgun,
		// Token: 0x0400408E RID: 16526
		[Token(Token = "0x400408E")]
		rifle,
		// Token: 0x0400408F RID: 16527
		[Token(Token = "0x400408F")]
		shotgun,
		// Token: 0x04004090 RID: 16528
		[Token(Token = "0x4004090")]
		blade,
		// Token: 0x04004091 RID: 16529
		[Token(Token = "0x4004091")]
		bluntObject,
		// Token: 0x04004092 RID: 16530
		[Token(Token = "0x4004092")]
		poison,
		// Token: 0x04004093 RID: 16531
		[Token(Token = "0x4004093")]
		strangulation,
		// Token: 0x04004094 RID: 16532
		[Token(Token = "0x4004094")]
		fists
	}

	// Token: 0x02000854 RID: 2132
	[Token(Token = "0x2000854")]
	public enum StatMultiplier
	{
		// Token: 0x04004096 RID: 16534
		[Token(Token = "0x4004096")]
		zero,
		// Token: 0x04004097 RID: 16535
		[Token(Token = "0x4004097")]
		one,
		// Token: 0x04004098 RID: 16536
		[Token(Token = "0x4004098")]
		random,
		// Token: 0x04004099 RID: 16537
		[Token(Token = "0x4004099")]
		combatSkill,
		// Token: 0x0400409A RID: 16538
		[Token(Token = "0x400409A")]
		combatHeft
	}

	// Token: 0x02000855 RID: 2133
	[Token(Token = "0x2000855")]
	public enum EjectBrass
	{
		// Token: 0x0400409C RID: 16540
		[Token(Token = "0x400409C")]
		none,
		// Token: 0x0400409D RID: 16541
		[Token(Token = "0x400409D")]
		onFire,
		// Token: 0x0400409E RID: 16542
		[Token(Token = "0x400409E")]
		onPumpAction,
		// Token: 0x0400409F RID: 16543
		[Token(Token = "0x400409F")]
		revolver
	}

	// Token: 0x02000856 RID: 2134
	[Token(Token = "0x2000856")]
	public enum AttackValue
	{
		// Token: 0x040040A1 RID: 16545
		[Token(Token = "0x40040A1")]
		range,
		// Token: 0x040040A2 RID: 16546
		[Token(Token = "0x40040A2")]
		fireDelay,
		// Token: 0x040040A3 RID: 16547
		[Token(Token = "0x40040A3")]
		accuracy,
		// Token: 0x040040A4 RID: 16548
		[Token(Token = "0x40040A4")]
		damage
	}
}
