using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000794 RID: 1940
[Token(Token = "0x2000794")]
public class CharacterTrait : SoCustomComparison
{
	// Token: 0x06002932 RID: 10546 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002932")]
	[Address(RVA = "0xCA13F0", Offset = "0xCA03F0", VA = "0x180CA13F0")]
	public CharacterTrait()
	{
	}

	// Token: 0x040037B9 RID: 14265
	[Token(Token = "0x40037B9")]
	[FieldOffset(Offset = "0x20")]
	public bool isTrait;

	// Token: 0x040037BA RID: 14266
	[Token(Token = "0x40037BA")]
	[FieldOffset(Offset = "0x21")]
	public bool needsReson;

	// Token: 0x040037BB RID: 14267
	[Token(Token = "0x40037BB")]
	[FieldOffset(Offset = "0x22")]
	public bool requiresPartner;

	// Token: 0x040037BC RID: 14268
	[Token(Token = "0x40037BC")]
	[FieldOffset(Offset = "0x23")]
	public bool requiresSingle;

	// Token: 0x040037BD RID: 14269
	[Token(Token = "0x40037BD")]
	[FieldOffset(Offset = "0x24")]
	public bool requiresHome;

	// Token: 0x040037BE RID: 14270
	[Token(Token = "0x40037BE")]
	[FieldOffset(Offset = "0x25")]
	public bool requiresEmployment;

	// Token: 0x040037BF RID: 14271
	[Token(Token = "0x40037BF")]
	[FieldOffset(Offset = "0x26")]
	public bool needsDate;

	// Token: 0x040037C0 RID: 14272
	[Token(Token = "0x40037C0")]
	[FieldOffset(Offset = "0x27")]
	public bool featureInInterestPool;

	// Token: 0x040037C1 RID: 14273
	[Token(Token = "0x40037C1")]
	[FieldOffset(Offset = "0x28")]
	public bool featureInAfflictionPool;

	// Token: 0x040037C2 RID: 14274
	[Token(Token = "0x40037C2")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 ageDateRange;

	// Token: 0x040037C3 RID: 14275
	[Token(Token = "0x40037C3")]
	[FieldOffset(Offset = "0x34")]
	public bool useCouplesAnniversary;

	// Token: 0x040037C4 RID: 14276
	[Token(Token = "0x40037C4")]
	[FieldOffset(Offset = "0x35")]
	public bool isPassword;

	// Token: 0x040037C5 RID: 14277
	[Token(Token = "0x40037C5")]
	[FieldOffset(Offset = "0x36")]
	public bool disabled;

	// Token: 0x040037C6 RID: 14278
	[Token(Token = "0x40037C6")]
	[FieldOffset(Offset = "0x38")]
	public CharacterTrait.PosNeg postiveNegative;

	// Token: 0x040037C7 RID: 14279
	[Token(Token = "0x40037C7")]
	[FieldOffset(Offset = "0x3C")]
	public int pickStage;

	// Token: 0x040037C8 RID: 14280
	[Token(Token = "0x40037C8")]
	[FieldOffset(Offset = "0x40")]
	public float primeBaseChance;

	// Token: 0x040037C9 RID: 14281
	[Token(Token = "0x40037C9")]
	[FieldOffset(Offset = "0x48")]
	public List<CharacterTrait.TraitPickRule> pickRules;

	// Token: 0x040037CA RID: 14282
	[Token(Token = "0x40037CA")]
	[FieldOffset(Offset = "0x50")]
	public float matchChance;

	// Token: 0x040037CB RID: 14283
	[Token(Token = "0x40037CB")]
	[FieldOffset(Offset = "0x54")]
	public bool useHumilityMatch;

	// Token: 0x040037CC RID: 14284
	[Token(Token = "0x40037CC")]
	[FieldOffset(Offset = "0x58")]
	public float matchHumility;

	// Token: 0x040037CD RID: 14285
	[Token(Token = "0x40037CD")]
	[FieldOffset(Offset = "0x5C")]
	public bool useEmotionalityMatch;

	// Token: 0x040037CE RID: 14286
	[Token(Token = "0x40037CE")]
	[FieldOffset(Offset = "0x60")]
	public float matchEmotionality;

	// Token: 0x040037CF RID: 14287
	[Token(Token = "0x40037CF")]
	[FieldOffset(Offset = "0x64")]
	public bool useExtraversionMatch;

	// Token: 0x040037D0 RID: 14288
	[Token(Token = "0x40037D0")]
	[FieldOffset(Offset = "0x68")]
	public float matchExtraversion;

	// Token: 0x040037D1 RID: 14289
	[Token(Token = "0x40037D1")]
	[FieldOffset(Offset = "0x6C")]
	public bool useAgreeablenessMatch;

	// Token: 0x040037D2 RID: 14290
	[Token(Token = "0x40037D2")]
	[FieldOffset(Offset = "0x70")]
	public float matchAgreeableness;

	// Token: 0x040037D3 RID: 14291
	[Token(Token = "0x40037D3")]
	[FieldOffset(Offset = "0x74")]
	public bool useConscientiousnessMatch;

	// Token: 0x040037D4 RID: 14292
	[Token(Token = "0x40037D4")]
	[FieldOffset(Offset = "0x78")]
	public float matchConscientiousness;

	// Token: 0x040037D5 RID: 14293
	[Token(Token = "0x40037D5")]
	[FieldOffset(Offset = "0x7C")]
	public bool useCreativityMatch;

	// Token: 0x040037D6 RID: 14294
	[Token(Token = "0x40037D6")]
	[FieldOffset(Offset = "0x80")]
	public float matchCreativity;

	// Token: 0x040037D7 RID: 14295
	[Token(Token = "0x40037D7")]
	[FieldOffset(Offset = "0x84")]
	public bool useSocietalClassMatch;

	// Token: 0x040037D8 RID: 14296
	[Token(Token = "0x40037D8")]
	[FieldOffset(Offset = "0x88")]
	public float matchSocietalClass;

	// Token: 0x040037D9 RID: 14297
	[Token(Token = "0x40037D9")]
	[FieldOffset(Offset = "0x8C")]
	public float effectHumility;

	// Token: 0x040037DA RID: 14298
	[Token(Token = "0x40037DA")]
	[FieldOffset(Offset = "0x90")]
	public float effectEmotionality;

	// Token: 0x040037DB RID: 14299
	[Token(Token = "0x40037DB")]
	[FieldOffset(Offset = "0x94")]
	public float effectExtraversion;

	// Token: 0x040037DC RID: 14300
	[Token(Token = "0x40037DC")]
	[FieldOffset(Offset = "0x98")]
	public float effectAgreeableness;

	// Token: 0x040037DD RID: 14301
	[Token(Token = "0x40037DD")]
	[FieldOffset(Offset = "0x9C")]
	public float effectConscientiousness;

	// Token: 0x040037DE RID: 14302
	[Token(Token = "0x40037DE")]
	[FieldOffset(Offset = "0xA0")]
	public float effectCreativity;

	// Token: 0x040037DF RID: 14303
	[Token(Token = "0x40037DF")]
	[FieldOffset(Offset = "0xA4")]
	public float maxHealthModifier;

	// Token: 0x040037E0 RID: 14304
	[Token(Token = "0x40037E0")]
	[FieldOffset(Offset = "0xA8")]
	public float recoveryRateModifier;

	// Token: 0x040037E1 RID: 14305
	[Token(Token = "0x40037E1")]
	[FieldOffset(Offset = "0xAC")]
	public float combatSkillModifier;

	// Token: 0x040037E2 RID: 14306
	[Token(Token = "0x40037E2")]
	[FieldOffset(Offset = "0xB0")]
	public float combatHeftModifier;

	// Token: 0x040037E3 RID: 14307
	[Token(Token = "0x40037E3")]
	[FieldOffset(Offset = "0xB4")]
	public float maxNerveModifier;

	// Token: 0x040037E4 RID: 14308
	[Token(Token = "0x40037E4")]
	[FieldOffset(Offset = "0xB8")]
	public float breathRecoveryModifier;

	// Token: 0x040037E5 RID: 14309
	[Token(Token = "0x40037E5")]
	[FieldOffset(Offset = "0xBC")]
	public Vector2 limitHumility;

	// Token: 0x040037E6 RID: 14310
	[Token(Token = "0x40037E6")]
	[FieldOffset(Offset = "0xC4")]
	public Vector2 limitEmotionality;

	// Token: 0x040037E7 RID: 14311
	[Token(Token = "0x40037E7")]
	[FieldOffset(Offset = "0xCC")]
	public Vector2 limitExtraversion;

	// Token: 0x040037E8 RID: 14312
	[Token(Token = "0x40037E8")]
	[FieldOffset(Offset = "0xD4")]
	public Vector2 limitAgreeableness;

	// Token: 0x040037E9 RID: 14313
	[Token(Token = "0x40037E9")]
	[FieldOffset(Offset = "0xDC")]
	public Vector2 limitConscientiousness;

	// Token: 0x040037EA RID: 14314
	[Token(Token = "0x40037EA")]
	[FieldOffset(Offset = "0xE4")]
	public Vector2 limitCreativity;

	// Token: 0x040037EB RID: 14315
	[Token(Token = "0x40037EB")]
	[FieldOffset(Offset = "0xEC")]
	public float slangUsageModifier;

	// Token: 0x040037EC RID: 14316
	[Token(Token = "0x40037EC")]
	[FieldOffset(Offset = "0xF0")]
	public List<string> slangGreetingDefault;

	// Token: 0x040037ED RID: 14317
	[Token(Token = "0x40037ED")]
	[FieldOffset(Offset = "0xF8")]
	public List<string> slangGreetingMale;

	// Token: 0x040037EE RID: 14318
	[Token(Token = "0x40037EE")]
	[FieldOffset(Offset = "0x100")]
	public List<string> slangGreetingFemale;

	// Token: 0x040037EF RID: 14319
	[Token(Token = "0x40037EF")]
	[FieldOffset(Offset = "0x108")]
	public List<string> slangGreetingLover;

	// Token: 0x040037F0 RID: 14320
	[Token(Token = "0x40037F0")]
	[FieldOffset(Offset = "0x110")]
	public List<string> slangCurse;

	// Token: 0x040037F1 RID: 14321
	[Token(Token = "0x40037F1")]
	[FieldOffset(Offset = "0x118")]
	public List<string> slangCurseNoun;

	// Token: 0x040037F2 RID: 14322
	[Token(Token = "0x40037F2")]
	[FieldOffset(Offset = "0x120")]
	public List<string> slangPraiseNoun;

	// Token: 0x040037F3 RID: 14323
	[Token(Token = "0x40037F3")]
	[FieldOffset(Offset = "0x128")]
	public int preferredBookCountModifier;

	// Token: 0x040037F4 RID: 14324
	[Token(Token = "0x40037F4")]
	[FieldOffset(Offset = "0x12C")]
	public int sightingLimitMemoryModifier;

	// Token: 0x02000795 RID: 1941
	[Token(Token = "0x2000795")]
	public enum PosNeg
	{
		// Token: 0x040037F6 RID: 14326
		[Token(Token = "0x40037F6")]
		postive,
		// Token: 0x040037F7 RID: 14327
		[Token(Token = "0x40037F7")]
		neutral,
		// Token: 0x040037F8 RID: 14328
		[Token(Token = "0x40037F8")]
		negative
	}

	// Token: 0x02000796 RID: 1942
	[Token(Token = "0x2000796")]
	public enum RuleType
	{
		// Token: 0x040037FA RID: 14330
		[Token(Token = "0x40037FA")]
		ifAnyOfThese,
		// Token: 0x040037FB RID: 14331
		[Token(Token = "0x40037FB")]
		ifAllOfThese,
		// Token: 0x040037FC RID: 14332
		[Token(Token = "0x40037FC")]
		ifNoneOfThese,
		// Token: 0x040037FD RID: 14333
		[Token(Token = "0x40037FD")]
		ifPartnerAnyOfThese
	}

	// Token: 0x02000797 RID: 1943
	[Token(Token = "0x2000797")]
	[Serializable]
	public class TraitPickRule
	{
		// Token: 0x06002933 RID: 10547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002933")]
		[Address(RVA = "0xCA1520", Offset = "0xCA0520", VA = "0x180CA1520")]
		public TraitPickRule()
		{
		}

		// Token: 0x040037FE RID: 14334
		[Token(Token = "0x40037FE")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait.RuleType rule;

		// Token: 0x040037FF RID: 14335
		[Token(Token = "0x40037FF")]
		[FieldOffset(Offset = "0x18")]
		public List<CharacterTrait> traitList;

		// Token: 0x04003800 RID: 14336
		[Token(Token = "0x4003800")]
		[FieldOffset(Offset = "0x20")]
		public bool mustPassForApplication;

		// Token: 0x04003801 RID: 14337
		[Token(Token = "0x4003801")]
		[FieldOffset(Offset = "0x24")]
		public float baseChance;

		// Token: 0x04003802 RID: 14338
		[Token(Token = "0x4003802")]
		[FieldOffset(Offset = "0x28")]
		public int reasonChance;
	}

	// Token: 0x02000798 RID: 1944
	[Token(Token = "0x2000798")]
	[Serializable]
	public class SpecialItemPlacementRule
	{
		// Token: 0x06002934 RID: 10548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002934")]
		[Address(RVA = "0xCA15F0", Offset = "0xCA05F0", VA = "0x180CA15F0")]
		public SpecialItemPlacementRule()
		{
		}

		// Token: 0x04003803 RID: 14339
		[Token(Token = "0x4003803")]
		[FieldOffset(Offset = "0x10")]
		public InteractablePreset preset;

		// Token: 0x04003804 RID: 14340
		[Token(Token = "0x4003804")]
		[FieldOffset(Offset = "0x18")]
		public float chance;
	}
}
