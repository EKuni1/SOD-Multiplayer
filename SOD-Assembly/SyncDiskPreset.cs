using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200089B RID: 2203
[Token(Token = "0x200089B")]
public class SyncDiskPreset : SoCustomComparison
{
	// Token: 0x06002A06 RID: 10758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A06")]
	[Address(RVA = "0xCB3E90", Offset = "0xCB2E90", VA = "0x180CB3E90")]
	public void CopyOwnershipStats()
	{
	}

	// Token: 0x06002A07 RID: 10759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A07")]
	[Address(RVA = "0xCB4040", Offset = "0xCB3040", VA = "0x180CB4040")]
	public SyncDiskPreset()
	{
	}

	// Token: 0x040043A2 RID: 17314
	[Token(Token = "0x40043A2")]
	[FieldOffset(Offset = "0x20")]
	public bool disabled;

	// Token: 0x040043A3 RID: 17315
	[Token(Token = "0x40043A3")]
	[FieldOffset(Offset = "0x24")]
	public int syncDiskNumber;

	// Token: 0x040043A4 RID: 17316
	[Token(Token = "0x40043A4")]
	[FieldOffset(Offset = "0x28")]
	public InteractablePreset interactable;

	// Token: 0x040043A5 RID: 17317
	[Token(Token = "0x40043A5")]
	[FieldOffset(Offset = "0x30")]
	public SyncDiskPreset.Rarity rarity;

	// Token: 0x040043A6 RID: 17318
	[Token(Token = "0x40043A6")]
	[FieldOffset(Offset = "0x34")]
	public SyncDiskPreset.Manufacturer manufacturer;

	// Token: 0x040043A7 RID: 17319
	[Token(Token = "0x40043A7")]
	[FieldOffset(Offset = "0x38")]
	public bool canBeSideJobReward;

	// Token: 0x040043A8 RID: 17320
	[Token(Token = "0x40043A8")]
	[FieldOffset(Offset = "0x40")]
	public string mainEffect1Name;

	// Token: 0x040043A9 RID: 17321
	[Token(Token = "0x40043A9")]
	[FieldOffset(Offset = "0x48")]
	public string mainEffect1Description;

	// Token: 0x040043AA RID: 17322
	[Token(Token = "0x40043AA")]
	[FieldOffset(Offset = "0x50")]
	public SyncDiskPreset.Effect mainEffect1;

	// Token: 0x040043AB RID: 17323
	[Token(Token = "0x40043AB")]
	[FieldOffset(Offset = "0x54")]
	public float mainEffect1Value;

	// Token: 0x040043AC RID: 17324
	[Token(Token = "0x40043AC")]
	[FieldOffset(Offset = "0x58")]
	public Sprite mainEffect1Icon;

	// Token: 0x040043AD RID: 17325
	[Token(Token = "0x40043AD")]
	[FieldOffset(Offset = "0x60")]
	public string mainEffect2Name;

	// Token: 0x040043AE RID: 17326
	[Token(Token = "0x40043AE")]
	[FieldOffset(Offset = "0x68")]
	public string mainEffect2Description;

	// Token: 0x040043AF RID: 17327
	[Token(Token = "0x40043AF")]
	[FieldOffset(Offset = "0x70")]
	public SyncDiskPreset.Effect mainEffect2;

	// Token: 0x040043B0 RID: 17328
	[Token(Token = "0x40043B0")]
	[FieldOffset(Offset = "0x74")]
	public float mainEffect2Value;

	// Token: 0x040043B1 RID: 17329
	[Token(Token = "0x40043B1")]
	[FieldOffset(Offset = "0x78")]
	public Sprite mainEffect2Icon;

	// Token: 0x040043B2 RID: 17330
	[Token(Token = "0x40043B2")]
	[FieldOffset(Offset = "0x80")]
	public string mainEffect3Name;

	// Token: 0x040043B3 RID: 17331
	[Token(Token = "0x40043B3")]
	[FieldOffset(Offset = "0x88")]
	public string mainEffect3Description;

	// Token: 0x040043B4 RID: 17332
	[Token(Token = "0x40043B4")]
	[FieldOffset(Offset = "0x90")]
	public SyncDiskPreset.Effect mainEffect3;

	// Token: 0x040043B5 RID: 17333
	[Token(Token = "0x40043B5")]
	[FieldOffset(Offset = "0x94")]
	public float mainEffect3Value;

	// Token: 0x040043B6 RID: 17334
	[Token(Token = "0x40043B6")]
	[FieldOffset(Offset = "0x98")]
	public Sprite mainEffect3Icon;

	// Token: 0x040043B7 RID: 17335
	[Token(Token = "0x40043B7")]
	[FieldOffset(Offset = "0xA0")]
	public List<string> option1UpgradeNameReferences;

	// Token: 0x040043B8 RID: 17336
	[Token(Token = "0x40043B8")]
	[FieldOffset(Offset = "0xA8")]
	public List<SyncDiskPreset.UpgradeEffect> option1UpgradeEffects;

	// Token: 0x040043B9 RID: 17337
	[Token(Token = "0x40043B9")]
	[FieldOffset(Offset = "0xB0")]
	public List<float> option1UpgradeValues;

	// Token: 0x040043BA RID: 17338
	[Token(Token = "0x40043BA")]
	[FieldOffset(Offset = "0xB8")]
	public List<string> option2UpgradeNameReferences;

	// Token: 0x040043BB RID: 17339
	[Token(Token = "0x40043BB")]
	[FieldOffset(Offset = "0xC0")]
	public List<SyncDiskPreset.UpgradeEffect> option2UpgradeEffects;

	// Token: 0x040043BC RID: 17340
	[Token(Token = "0x40043BC")]
	[FieldOffset(Offset = "0xC8")]
	public List<float> option2UpgradeValues;

	// Token: 0x040043BD RID: 17341
	[Token(Token = "0x40043BD")]
	[FieldOffset(Offset = "0xD0")]
	public List<string> option3UpgradeNameReferences;

	// Token: 0x040043BE RID: 17342
	[Token(Token = "0x40043BE")]
	[FieldOffset(Offset = "0xD8")]
	public List<SyncDiskPreset.UpgradeEffect> option3UpgradeEffects;

	// Token: 0x040043BF RID: 17343
	[Token(Token = "0x40043BF")]
	[FieldOffset(Offset = "0xE0")]
	public List<float> option3UpgradeValues;

	// Token: 0x040043C0 RID: 17344
	[Token(Token = "0x40043C0")]
	[FieldOffset(Offset = "0xE8")]
	public string sideEffectDescription;

	// Token: 0x040043C1 RID: 17345
	[Token(Token = "0x40043C1")]
	[FieldOffset(Offset = "0xF0")]
	public SyncDiskPreset.Effect sideEffect;

	// Token: 0x040043C2 RID: 17346
	[Token(Token = "0x40043C2")]
	[FieldOffset(Offset = "0xF4")]
	public float sideEffectValue;

	// Token: 0x040043C3 RID: 17347
	[Token(Token = "0x40043C3")]
	[FieldOffset(Offset = "0xF8")]
	public int price;

	// Token: 0x040043C4 RID: 17348
	[Token(Token = "0x40043C4")]
	[FieldOffset(Offset = "0xFC")]
	public int uninstallCost;

	// Token: 0x040043C5 RID: 17349
	[Token(Token = "0x40043C5")]
	[FieldOffset(Offset = "0x100")]
	public float minimumWealthLevel;

	// Token: 0x040043C6 RID: 17350
	[Token(Token = "0x40043C6")]
	[FieldOffset(Offset = "0x104")]
	public int traitWeight;

	// Token: 0x040043C7 RID: 17351
	[Token(Token = "0x40043C7")]
	[FieldOffset(Offset = "0x108")]
	public List<SyncDiskPreset.TraitPick> traits;

	// Token: 0x040043C8 RID: 17352
	[Token(Token = "0x40043C8")]
	[FieldOffset(Offset = "0x110")]
	public int occupationWeight;

	// Token: 0x040043C9 RID: 17353
	[Token(Token = "0x40043C9")]
	[FieldOffset(Offset = "0x118")]
	public List<OccupationPreset> occupation;

	// Token: 0x040043CA RID: 17354
	[Token(Token = "0x40043CA")]
	[FieldOffset(Offset = "0x120")]
	public SyncDiskPreset copyFrom;

	// Token: 0x0200089C RID: 2204
	[Token(Token = "0x200089C")]
	public enum Rarity
	{
		// Token: 0x040043CC RID: 17356
		[Token(Token = "0x40043CC")]
		common,
		// Token: 0x040043CD RID: 17357
		[Token(Token = "0x40043CD")]
		medium,
		// Token: 0x040043CE RID: 17358
		[Token(Token = "0x40043CE")]
		rare,
		// Token: 0x040043CF RID: 17359
		[Token(Token = "0x40043CF")]
		veryRare
	}

	// Token: 0x0200089D RID: 2205
	[Token(Token = "0x200089D")]
	public enum Manufacturer
	{
		// Token: 0x040043D1 RID: 17361
		[Token(Token = "0x40043D1")]
		ElGen,
		// Token: 0x040043D2 RID: 17362
		[Token(Token = "0x40043D2")]
		Kaizen,
		// Token: 0x040043D3 RID: 17363
		[Token(Token = "0x40043D3")]
		KensingtonIndigo,
		// Token: 0x040043D4 RID: 17364
		[Token(Token = "0x40043D4")]
		StarchKola,
		// Token: 0x040043D5 RID: 17365
		[Token(Token = "0x40043D5")]
		CandorNews,
		// Token: 0x040043D6 RID: 17366
		[Token(Token = "0x40043D6")]
		BlackMarket
	}

	// Token: 0x0200089E RID: 2206
	[Token(Token = "0x200089E")]
	public enum Effect
	{
		// Token: 0x040043D8 RID: 17368
		[Token(Token = "0x40043D8")]
		none,
		// Token: 0x040043D9 RID: 17369
		[Token(Token = "0x40043D9")]
		streetCleaningMoney,
		// Token: 0x040043DA RID: 17370
		[Token(Token = "0x40043DA")]
		readingMoney,
		// Token: 0x040043DB RID: 17371
		[Token(Token = "0x40043DB")]
		readingSeriesBonus,
		// Token: 0x040043DC RID: 17372
		[Token(Token = "0x40043DC")]
		starchLoan,
		// Token: 0x040043DD RID: 17373
		[Token(Token = "0x40043DD")]
		starchAddiction,
		// Token: 0x040043DE RID: 17374
		[Token(Token = "0x40043DE")]
		reduceMedicalCosts,
		// Token: 0x040043DF RID: 17375
		[Token(Token = "0x40043DF")]
		legalInsurance,
		// Token: 0x040043E0 RID: 17376
		[Token(Token = "0x40043E0")]
		accidentCover,
		// Token: 0x040043E1 RID: 17377
		[Token(Token = "0x40043E1")]
		awakenAtHome,
		// Token: 0x040043E2 RID: 17378
		[Token(Token = "0x40043E2")]
		increaseHealth,
		// Token: 0x040043E3 RID: 17379
		[Token(Token = "0x40043E3")]
		increaseInventory,
		// Token: 0x040043E4 RID: 17380
		[Token(Token = "0x40043E4")]
		increaseRegeneration,
		// Token: 0x040043E5 RID: 17381
		[Token(Token = "0x40043E5")]
		priceModifier,
		// Token: 0x040043E6 RID: 17382
		[Token(Token = "0x40043E6")]
		dialogChanceModifier,
		// Token: 0x040043E7 RID: 17383
		[Token(Token = "0x40043E7")]
		doorBargeModifier,
		// Token: 0x040043E8 RID: 17384
		[Token(Token = "0x40043E8")]
		fallDamageModifier,
		// Token: 0x040043E9 RID: 17385
		[Token(Token = "0x40043E9")]
		sideJobPayModifier,
		// Token: 0x040043EA RID: 17386
		[Token(Token = "0x40043EA")]
		punchPowerModifier,
		// Token: 0x040043EB RID: 17387
		[Token(Token = "0x40043EB")]
		throwPowerModifier,
		// Token: 0x040043EC RID: 17388
		[Token(Token = "0x40043EC")]
		blockIncoming,
		// Token: 0x040043ED RID: 17389
		[Token(Token = "0x40043ED")]
		focusFromDamage,
		// Token: 0x040043EE RID: 17390
		[Token(Token = "0x40043EE")]
		noBrokenBones,
		// Token: 0x040043EF RID: 17391
		[Token(Token = "0x40043EF")]
		reachModifier,
		// Token: 0x040043F0 RID: 17392
		[Token(Token = "0x40043F0")]
		holdingBlocksBullets,
		// Token: 0x040043F1 RID: 17393
		[Token(Token = "0x40043F1")]
		fistsThreatModifier,
		// Token: 0x040043F2 RID: 17394
		[Token(Token = "0x40043F2")]
		noBleeding,
		// Token: 0x040043F3 RID: 17395
		[Token(Token = "0x40043F3")]
		incomingDamageModifier,
		// Token: 0x040043F4 RID: 17396
		[Token(Token = "0x40043F4")]
		passiveIncome,
		// Token: 0x040043F5 RID: 17397
		[Token(Token = "0x40043F5")]
		installMalware,
		// Token: 0x040043F6 RID: 17398
		[Token(Token = "0x40043F6")]
		malwareOwnerBonus,
		// Token: 0x040043F7 RID: 17399
		[Token(Token = "0x40043F7")]
		footSizePerception,
		// Token: 0x040043F8 RID: 17400
		[Token(Token = "0x40043F8")]
		heightPerception,
		// Token: 0x040043F9 RID: 17401
		[Token(Token = "0x40043F9")]
		wealthPerception,
		// Token: 0x040043FA RID: 17402
		[Token(Token = "0x40043FA")]
		salaryPerception,
		// Token: 0x040043FB RID: 17403
		[Token(Token = "0x40043FB")]
		singlePerception,
		// Token: 0x040043FC RID: 17404
		[Token(Token = "0x40043FC")]
		agePerception,
		// Token: 0x040043FD RID: 17405
		[Token(Token = "0x40043FD")]
		starchAmbassador,
		// Token: 0x040043FE RID: 17406
		[Token(Token = "0x40043FE")]
		starchGive,
		// Token: 0x040043FF RID: 17407
		[Token(Token = "0x40043FF")]
		lockpickingSpeedModifier,
		// Token: 0x04004400 RID: 17408
		[Token(Token = "0x4004400")]
		lockpickingEfficiencyModifier,
		// Token: 0x04004401 RID: 17409
		[Token(Token = "0x4004401")]
		triggerIllegalOnPick,
		// Token: 0x04004402 RID: 17410
		[Token(Token = "0x4004402")]
		KOTimeModifier,
		// Token: 0x04004403 RID: 17411
		[Token(Token = "0x4004403")]
		securityBreakerModifier,
		// Token: 0x04004404 RID: 17412
		[Token(Token = "0x4004404")]
		securityGraceTimeModifier,
		// Token: 0x04004405 RID: 17413
		[Token(Token = "0x4004405")]
		noSmelly,
		// Token: 0x04004406 RID: 17414
		[Token(Token = "0x4004406")]
		noCold,
		// Token: 0x04004407 RID: 17415
		[Token(Token = "0x4004407")]
		noTired,
		// Token: 0x04004408 RID: 17416
		[Token(Token = "0x4004408")]
		kitchenPhotos,
		// Token: 0x04004409 RID: 17417
		[Token(Token = "0x4004409")]
		bathroomPhotos,
		// Token: 0x0400440A RID: 17418
		[Token(Token = "0x400440A")]
		illegalOpsPhotos,
		// Token: 0x0400440B RID: 17419
		[Token(Token = "0x400440B")]
		playerHeightModifier,
		// Token: 0x0400440C RID: 17420
		[Token(Token = "0x400440C")]
		removeSideEffect,
		// Token: 0x0400440D RID: 17421
		[Token(Token = "0x400440D")]
		moneyForLocations,
		// Token: 0x0400440E RID: 17422
		[Token(Token = "0x400440E")]
		moneyForDucts,
		// Token: 0x0400440F RID: 17423
		[Token(Token = "0x400440F")]
		moneyForAddresses,
		// Token: 0x04004410 RID: 17424
		[Token(Token = "0x4004410")]
		moneyForPasscodes,
		// Token: 0x04004411 RID: 17425
		[Token(Token = "0x4004411")]
		maxSpeedModifier,
		// Token: 0x04004412 RID: 17426
		[Token(Token = "0x4004412")]
		payPhoneCostModifier,
		// Token: 0x04004413 RID: 17427
		[Token(Token = "0x4004413")]
		allowApartmentPurchases,
		// Token: 0x04004414 RID: 17428
		[Token(Token = "0x4004414")]
		apartmentStatusReset,
		// Token: 0x04004415 RID: 17429
		[Token(Token = "0x4004415")]
		allowedAtCrimeScenes,
		// Token: 0x04004416 RID: 17430
		[Token(Token = "0x4004416")]
		spookedMultiplier,
		// Token: 0x04004417 RID: 17431
		[Token(Token = "0x4004417")]
		trespassGraceModifier,
		// Token: 0x04004418 RID: 17432
		[Token(Token = "0x4004418")]
		guestPassIssueModifier,
		// Token: 0x04004419 RID: 17433
		[Token(Token = "0x4004419")]
		fastTravelToApartment,
		// Token: 0x0400441A RID: 17434
		[Token(Token = "0x400441A")]
		fastTravelFromApartment,
		// Token: 0x0400441B RID: 17435
		[Token(Token = "0x400441B")]
		fastTravelUsingSignage,
		// Token: 0x0400441C RID: 17436
		[Token(Token = "0x400441C")]
		allowedInEchelons,
		// Token: 0x0400441D RID: 17437
		[Token(Token = "0x400441D")]
		disableLoitering
	}

	// Token: 0x0200089F RID: 2207
	[Token(Token = "0x200089F")]
	public enum UpgradeEffect
	{
		// Token: 0x0400441F RID: 17439
		[Token(Token = "0x400441F")]
		none,
		// Token: 0x04004420 RID: 17440
		[Token(Token = "0x4004420")]
		modifyEffect,
		// Token: 0x04004421 RID: 17441
		[Token(Token = "0x4004421")]
		bothConfigurations,
		// Token: 0x04004422 RID: 17442
		[Token(Token = "0x4004422")]
		readingSeriesBonus,
		// Token: 0x04004423 RID: 17443
		[Token(Token = "0x4004423")]
		reduceUninstallCost,
		// Token: 0x04004424 RID: 17444
		[Token(Token = "0x4004424")]
		reduceMedicalCosts,
		// Token: 0x04004425 RID: 17445
		[Token(Token = "0x4004425")]
		accidentCover,
		// Token: 0x04004426 RID: 17446
		[Token(Token = "0x4004426")]
		legalInsurance,
		// Token: 0x04004427 RID: 17447
		[Token(Token = "0x4004427")]
		awakenAtHome,
		// Token: 0x04004428 RID: 17448
		[Token(Token = "0x4004428")]
		increaseHealth,
		// Token: 0x04004429 RID: 17449
		[Token(Token = "0x4004429")]
		increaseInventory,
		// Token: 0x0400442A RID: 17450
		[Token(Token = "0x400442A")]
		increaseRegeneration,
		// Token: 0x0400442B RID: 17451
		[Token(Token = "0x400442B")]
		priceModifier,
		// Token: 0x0400442C RID: 17452
		[Token(Token = "0x400442C")]
		dialogChanceModifier,
		// Token: 0x0400442D RID: 17453
		[Token(Token = "0x400442D")]
		doorBargeModifier,
		// Token: 0x0400442E RID: 17454
		[Token(Token = "0x400442E")]
		fallDamageModifier,
		// Token: 0x0400442F RID: 17455
		[Token(Token = "0x400442F")]
		sideJobPayModifier,
		// Token: 0x04004430 RID: 17456
		[Token(Token = "0x4004430")]
		punchPowerModifier,
		// Token: 0x04004431 RID: 17457
		[Token(Token = "0x4004431")]
		throwPowerModifier,
		// Token: 0x04004432 RID: 17458
		[Token(Token = "0x4004432")]
		blockIncoming,
		// Token: 0x04004433 RID: 17459
		[Token(Token = "0x4004433")]
		focusFromDamage,
		// Token: 0x04004434 RID: 17460
		[Token(Token = "0x4004434")]
		noBrokenBones,
		// Token: 0x04004435 RID: 17461
		[Token(Token = "0x4004435")]
		reachModifier,
		// Token: 0x04004436 RID: 17462
		[Token(Token = "0x4004436")]
		holdingBlocksBullets,
		// Token: 0x04004437 RID: 17463
		[Token(Token = "0x4004437")]
		fistsThreatModifier,
		// Token: 0x04004438 RID: 17464
		[Token(Token = "0x4004438")]
		noBleeding,
		// Token: 0x04004439 RID: 17465
		[Token(Token = "0x4004439")]
		incomingDamageModifier,
		// Token: 0x0400443A RID: 17466
		[Token(Token = "0x400443A")]
		passiveIncome,
		// Token: 0x0400443B RID: 17467
		[Token(Token = "0x400443B")]
		installMalware,
		// Token: 0x0400443C RID: 17468
		[Token(Token = "0x400443C")]
		malwareOwnerBonus,
		// Token: 0x0400443D RID: 17469
		[Token(Token = "0x400443D")]
		footSizePerception,
		// Token: 0x0400443E RID: 17470
		[Token(Token = "0x400443E")]
		heightPerception,
		// Token: 0x0400443F RID: 17471
		[Token(Token = "0x400443F")]
		wealthPerception,
		// Token: 0x04004440 RID: 17472
		[Token(Token = "0x4004440")]
		removeSideEffect,
		// Token: 0x04004441 RID: 17473
		[Token(Token = "0x4004441")]
		salaryPerception,
		// Token: 0x04004442 RID: 17474
		[Token(Token = "0x4004442")]
		singlePerception,
		// Token: 0x04004443 RID: 17475
		[Token(Token = "0x4004443")]
		agePerception,
		// Token: 0x04004444 RID: 17476
		[Token(Token = "0x4004444")]
		starchAmbassador,
		// Token: 0x04004445 RID: 17477
		[Token(Token = "0x4004445")]
		starchGive,
		// Token: 0x04004446 RID: 17478
		[Token(Token = "0x4004446")]
		lockpickingSpeedModifier,
		// Token: 0x04004447 RID: 17479
		[Token(Token = "0x4004447")]
		lockpickingEfficiencyModifier,
		// Token: 0x04004448 RID: 17480
		[Token(Token = "0x4004448")]
		triggerIllegalOnPick,
		// Token: 0x04004449 RID: 17481
		[Token(Token = "0x4004449")]
		KOTimeModifier,
		// Token: 0x0400444A RID: 17482
		[Token(Token = "0x400444A")]
		securityBreakerModifier,
		// Token: 0x0400444B RID: 17483
		[Token(Token = "0x400444B")]
		securityGraceTimeModifier,
		// Token: 0x0400444C RID: 17484
		[Token(Token = "0x400444C")]
		noSmelly,
		// Token: 0x0400444D RID: 17485
		[Token(Token = "0x400444D")]
		noCold,
		// Token: 0x0400444E RID: 17486
		[Token(Token = "0x400444E")]
		noTired,
		// Token: 0x0400444F RID: 17487
		[Token(Token = "0x400444F")]
		kitchenPhotos,
		// Token: 0x04004450 RID: 17488
		[Token(Token = "0x4004450")]
		bathroomPhotos,
		// Token: 0x04004451 RID: 17489
		[Token(Token = "0x4004451")]
		illegalOpsPhotos,
		// Token: 0x04004452 RID: 17490
		[Token(Token = "0x4004452")]
		playerHeightModifier,
		// Token: 0x04004453 RID: 17491
		[Token(Token = "0x4004453")]
		moneyForLocations,
		// Token: 0x04004454 RID: 17492
		[Token(Token = "0x4004454")]
		moneyForDucts,
		// Token: 0x04004455 RID: 17493
		[Token(Token = "0x4004455")]
		moneyForAddresses,
		// Token: 0x04004456 RID: 17494
		[Token(Token = "0x4004456")]
		moneyForPasscodes,
		// Token: 0x04004457 RID: 17495
		[Token(Token = "0x4004457")]
		maxSpeedModifier
	}

	// Token: 0x020008A0 RID: 2208
	[Token(Token = "0x20008A0")]
	public enum SpecialCase
	{
		// Token: 0x04004459 RID: 17497
		[Token(Token = "0x4004459")]
		none,
		// Token: 0x0400445A RID: 17498
		[Token(Token = "0x400445A")]
		cancelSideEffect
	}

	// Token: 0x020008A1 RID: 2209
	[Token(Token = "0x20008A1")]
	[Serializable]
	public class TraitPick
	{
		// Token: 0x06002A08 RID: 10760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A08")]
		[Address(RVA = "0xCB46C0", Offset = "0xCB36C0", VA = "0x180CB46C0")]
		public TraitPick()
		{
		}

		// Token: 0x0400445B RID: 17499
		[Token(Token = "0x400445B")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait.RuleType rule;

		// Token: 0x0400445C RID: 17500
		[Token(Token = "0x400445C")]
		[FieldOffset(Offset = "0x18")]
		public List<CharacterTrait> traitList;

		// Token: 0x0400445D RID: 17501
		[Token(Token = "0x400445D")]
		[FieldOffset(Offset = "0x20")]
		public bool mustPassForApplication;

		// Token: 0x0400445E RID: 17502
		[Token(Token = "0x400445E")]
		[FieldOffset(Offset = "0x24")]
		public int appliedFrequency;
	}
}
