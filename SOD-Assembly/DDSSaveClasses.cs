using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000205 RID: 517
[Token(Token = "0x2000205")]
public class DDSSaveClasses
{
	// Token: 0x06000C5C RID: 3164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public DDSSaveClasses()
	{
	}

	// Token: 0x02000206 RID: 518
	[Token(Token = "0x2000206")]
	public enum TreeTriggers
	{
		// Token: 0x04000CC8 RID: 3272
		[Token(Token = "0x4000CC8")]
		awake,
		// Token: 0x04000CC9 RID: 3273
		[Token(Token = "0x4000CC9")]
		dead,
		// Token: 0x04000CCA RID: 3274
		[Token(Token = "0x4000CCA")]
		asleep,
		// Token: 0x04000CCB RID: 3275
		[Token(Token = "0x4000CCB")]
		unconscious,
		// Token: 0x04000CCC RID: 3276
		[Token(Token = "0x4000CCC")]
		noReactionState,
		// Token: 0x04000CCD RID: 3277
		[Token(Token = "0x4000CCD")]
		investigating,
		// Token: 0x04000CCE RID: 3278
		[Token(Token = "0x4000CCE")]
		investigatingVisual,
		// Token: 0x04000CCF RID: 3279
		[Token(Token = "0x4000CCF")]
		investigatingSound,
		// Token: 0x04000CD0 RID: 3280
		[Token(Token = "0x4000CD0")]
		persuing,
		// Token: 0x04000CD1 RID: 3281
		[Token(Token = "0x4000CD1")]
		searching,
		// Token: 0x04000CD2 RID: 3282
		[Token(Token = "0x4000CD2")]
		notInCombat,
		// Token: 0x04000CD3 RID: 3283
		[Token(Token = "0x4000CD3")]
		inCombat,
		// Token: 0x04000CD4 RID: 3284
		[Token(Token = "0x4000CD4")]
		legal,
		// Token: 0x04000CD5 RID: 3285
		[Token(Token = "0x4000CD5")]
		illegal,
		// Token: 0x04000CD6 RID: 3286
		[Token(Token = "0x4000CD6")]
		travelling,
		// Token: 0x04000CD7 RID: 3287
		[Token(Token = "0x4000CD7")]
		sat,
		// Token: 0x04000CD8 RID: 3288
		[Token(Token = "0x4000CD8")]
		employee,
		// Token: 0x04000CD9 RID: 3289
		[Token(Token = "0x4000CD9")]
		nonEmployee,
		// Token: 0x04000CDA RID: 3290
		[Token(Token = "0x4000CDA")]
		carrying,
		// Token: 0x04000CDB RID: 3291
		[Token(Token = "0x4000CDB")]
		notCarrying,
		// Token: 0x04000CDC RID: 3292
		[Token(Token = "0x4000CDC")]
		privateLocation,
		// Token: 0x04000CDD RID: 3293
		[Token(Token = "0x4000CDD")]
		publicLocation,
		// Token: 0x04000CDE RID: 3294
		[Token(Token = "0x4000CDE")]
		onStreet,
		// Token: 0x04000CDF RID: 3295
		[Token(Token = "0x4000CDF")]
		atHome,
		// Token: 0x04000CE0 RID: 3296
		[Token(Token = "0x4000CE0")]
		atWork,
		// Token: 0x04000CE1 RID: 3297
		[Token(Token = "0x4000CE1")]
		lightOnAny,
		// Token: 0x04000CE2 RID: 3298
		[Token(Token = "0x4000CE2")]
		lightOnMain,
		// Token: 0x04000CE3 RID: 3299
		[Token(Token = "0x4000CE3")]
		allLightsOff,
		// Token: 0x04000CE4 RID: 3300
		[Token(Token = "0x4000CE4")]
		rain,
		// Token: 0x04000CE5 RID: 3301
		[Token(Token = "0x4000CE5")]
		indoors,
		// Token: 0x04000CE6 RID: 3302
		[Token(Token = "0x4000CE6")]
		brokenSign,
		// Token: 0x04000CE7 RID: 3303
		[Token(Token = "0x4000CE7")]
		travellingToWork,
		// Token: 0x04000CE8 RID: 3304
		[Token(Token = "0x4000CE8")]
		notPresent,
		// Token: 0x04000CE9 RID: 3305
		[Token(Token = "0x4000CE9")]
		atEatery,
		// Token: 0x04000CEA RID: 3306
		[Token(Token = "0x4000CEA")]
		hasJob,
		// Token: 0x04000CEB RID: 3307
		[Token(Token = "0x4000CEB")]
		unemployed,
		// Token: 0x04000CEC RID: 3308
		[Token(Token = "0x4000CEC")]
		homeIntenseWallpaper,
		// Token: 0x04000CED RID: 3309
		[Token(Token = "0x4000CED")]
		homeBrightSign,
		// Token: 0x04000CEE RID: 3310
		[Token(Token = "0x4000CEE")]
		enforcerOnDuty,
		// Token: 0x04000CEF RID: 3311
		[Token(Token = "0x4000CEF")]
		notEnforcerOnDuty,
		// Token: 0x04000CF0 RID: 3312
		[Token(Token = "0x4000CF0")]
		trespassing,
		// Token: 0x04000CF1 RID: 3313
		[Token(Token = "0x4000CF1")]
		locationOfAuthority,
		// Token: 0x04000CF2 RID: 3314
		[Token(Token = "0x4000CF2")]
		drunk,
		// Token: 0x04000CF3 RID: 3315
		[Token(Token = "0x4000CF3")]
		restrained,
		// Token: 0x04000CF4 RID: 3316
		[Token(Token = "0x4000CF4")]
		sober,
		// Token: 0x04000CF5 RID: 3317
		[Token(Token = "0x4000CF5")]
		hasRoomAtHotel,
		// Token: 0x04000CF6 RID: 3318
		[Token(Token = "0x4000CF6")]
		hotelPaymentDue,
		// Token: 0x04000CF7 RID: 3319
		[Token(Token = "0x4000CF7")]
		hasNoRoomAtHotel,
		// Token: 0x04000CF8 RID: 3320
		[Token(Token = "0x4000CF8")]
		single,
		// Token: 0x04000CF9 RID: 3321
		[Token(Token = "0x4000CF9")]
		notSingle
	}

	// Token: 0x02000207 RID: 519
	[Token(Token = "0x2000207")]
	public enum RepeatSetting
	{
		// Token: 0x04000CFB RID: 3323
		[Token(Token = "0x4000CFB")]
		oneHour,
		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		sixHours,
		// Token: 0x04000CFD RID: 3325
		[Token(Token = "0x4000CFD")]
		twelveHours,
		// Token: 0x04000CFE RID: 3326
		[Token(Token = "0x4000CFE")]
		oneDay,
		// Token: 0x04000CFF RID: 3327
		[Token(Token = "0x4000CFF")]
		twoDays,
		// Token: 0x04000D00 RID: 3328
		[Token(Token = "0x4000D00")]
		threeDays,
		// Token: 0x04000D01 RID: 3329
		[Token(Token = "0x4000D01")]
		oneWeek,
		// Token: 0x04000D02 RID: 3330
		[Token(Token = "0x4000D02")]
		never,
		// Token: 0x04000D03 RID: 3331
		[Token(Token = "0x4000D03")]
		noLimit
	}

	// Token: 0x02000208 RID: 520
	[Token(Token = "0x2000208")]
	public enum TriggerPoint
	{
		// Token: 0x04000D05 RID: 3333
		[Token(Token = "0x4000D05")]
		onNewTrackTarget,
		// Token: 0x04000D06 RID: 3334
		[Token(Token = "0x4000D06")]
		onNewAction,
		// Token: 0x04000D07 RID: 3335
		[Token(Token = "0x4000D07")]
		whileTickOnTrackTarget,
		// Token: 0x04000D08 RID: 3336
		[Token(Token = "0x4000D08")]
		vmail,
		// Token: 0x04000D09 RID: 3337
		[Token(Token = "0x4000D09")]
		telephone,
		// Token: 0x04000D0A RID: 3338
		[Token(Token = "0x4000D0A")]
		never,
		// Token: 0x04000D0B RID: 3339
		[Token(Token = "0x4000D0B")]
		newspaperArticle,
		// Token: 0x04000D0C RID: 3340
		[Token(Token = "0x4000D0C")]
		onGameStart
	}

	// Token: 0x02000209 RID: 521
	[Token(Token = "0x2000209")]
	public enum TraitConditionType
	{
		// Token: 0x04000D0E RID: 3342
		[Token(Token = "0x4000D0E")]
		IfAnyOfThese,
		// Token: 0x04000D0F RID: 3343
		[Token(Token = "0x4000D0F")]
		IfAllOfThese,
		// Token: 0x04000D10 RID: 3344
		[Token(Token = "0x4000D10")]
		IfNoneOfThese,
		// Token: 0x04000D11 RID: 3345
		[Token(Token = "0x4000D11")]
		otherAnyOfThese,
		// Token: 0x04000D12 RID: 3346
		[Token(Token = "0x4000D12")]
		otherAllOfThese,
		// Token: 0x04000D13 RID: 3347
		[Token(Token = "0x4000D13")]
		otherNoneOfThese
	}

	// Token: 0x0200020A RID: 522
	[Token(Token = "0x200020A")]
	[Serializable]
	public class DDSComponent
	{
		// Token: 0x06000C5D RID: 3165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DDSComponent()
		{
		}

		// Token: 0x04000D14 RID: 3348
		[Token(Token = "0x4000D14")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000D15 RID: 3349
		[Token(Token = "0x4000D15")]
		[FieldOffset(Offset = "0x18")]
		public string id;
	}

	// Token: 0x0200020B RID: 523
	[Token(Token = "0x200020B")]
	[Serializable]
	public class DDSBlockSave : DDSSaveClasses.DDSComponent
	{
		// Token: 0x06000C5E RID: 3166 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x596090", Offset = "0x595090", VA = "0x180596090")]
		public DDSSaveClasses.DDSReplacement AddReplacement()
		{
			return null;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x596390", Offset = "0x595390", VA = "0x180596390")]
		public DDSBlockSave()
		{
		}

		// Token: 0x04000D16 RID: 3350
		[Token(Token = "0x4000D16")]
		[FieldOffset(Offset = "0x20")]
		public List<DDSSaveClasses.DDSReplacement> replacements;
	}

	// Token: 0x0200020C RID: 524
	[Token(Token = "0x200020C")]
	[Serializable]
	public class DDSReplacement
	{
		// Token: 0x06000C60 RID: 3168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x596460", Offset = "0x595460", VA = "0x180596460")]
		public DDSReplacement()
		{
		}

		// Token: 0x04000D17 RID: 3351
		[Token(Token = "0x4000D17")]
		[FieldOffset(Offset = "0x10")]
		public string replaceWithID;

		// Token: 0x04000D18 RID: 3352
		[Token(Token = "0x4000D18")]
		[FieldOffset(Offset = "0x18")]
		public bool useConnection;

		// Token: 0x04000D19 RID: 3353
		[Token(Token = "0x4000D19")]
		[FieldOffset(Offset = "0x1C")]
		public Acquaintance.ConnectionType connection;

		// Token: 0x04000D1A RID: 3354
		[Token(Token = "0x4000D1A")]
		[FieldOffset(Offset = "0x20")]
		public bool useDislikeLike;

		// Token: 0x04000D1B RID: 3355
		[Token(Token = "0x4000D1B")]
		[FieldOffset(Offset = "0x24")]
		public float strangerKnown;

		// Token: 0x04000D1C RID: 3356
		[Token(Token = "0x4000D1C")]
		[FieldOffset(Offset = "0x28")]
		public float dislikeLike;

		// Token: 0x04000D1D RID: 3357
		[Token(Token = "0x4000D1D")]
		[FieldOffset(Offset = "0x2C")]
		public bool useTraits;

		// Token: 0x04000D1E RID: 3358
		[Token(Token = "0x4000D1E")]
		[FieldOffset(Offset = "0x30")]
		public DDSSaveClasses.TraitConditionType traitCondition;

		// Token: 0x04000D1F RID: 3359
		[Token(Token = "0x4000D1F")]
		[FieldOffset(Offset = "0x38")]
		public List<string> traits;
	}

	// Token: 0x0200020D RID: 525
	[Token(Token = "0x200020D")]
	[Serializable]
	public class DDSMessageSave : DDSSaveClasses.DDSComponent
	{
		// Token: 0x06000C61 RID: 3169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x596540", Offset = "0x595540", VA = "0x180596540")]
		public void AddBlock(string newBlockID)
		{
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x596800", Offset = "0x595800", VA = "0x180596800")]
		public void RemoveBlock(string instID)
		{
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x596A20", Offset = "0x595A20", VA = "0x180596A20")]
		public DDSMessageSave()
		{
		}

		// Token: 0x04000D20 RID: 3360
		[Token(Token = "0x4000D20")]
		[FieldOffset(Offset = "0x20")]
		public List<DDSSaveClasses.DDSBlockCondition> blocks;

		// Token: 0x04000D21 RID: 3361
		[Token(Token = "0x4000D21")]
		[FieldOffset(Offset = "0x28")]
		public float baseSuccessChance;

		// Token: 0x04000D22 RID: 3362
		[Token(Token = "0x4000D22")]
		[FieldOffset(Offset = "0x30")]
		public List<DDSSaveClasses.DDSInteractionEvent> events;

		// Token: 0x0200020E RID: 526
		[Token(Token = "0x200020E")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06000C64 RID: 3172 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C64")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x06000C65 RID: 3173 RVA: 0x00007128 File Offset: 0x00005328
			[Token(Token = "0x6000C65")]
			[Address(RVA = "0x596BB0", Offset = "0x595BB0", VA = "0x180596BB0")]
			internal bool <RemoveBlock>b__0(DDSSaveClasses.DDSBlockCondition item)
			{
				return default(bool);
			}

			// Token: 0x04000D23 RID: 3363
			[Token(Token = "0x4000D23")]
			[FieldOffset(Offset = "0x10")]
			public string instID;
		}
	}

	// Token: 0x0200020F RID: 527
	[Token(Token = "0x200020F")]
	[Serializable]
	public class DDSBlockCondition
	{
		// Token: 0x06000C66 RID: 3174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x596C10", Offset = "0x595C10", VA = "0x180596C10")]
		public DDSBlockCondition()
		{
		}

		// Token: 0x04000D24 RID: 3364
		[Token(Token = "0x4000D24")]
		[FieldOffset(Offset = "0x10")]
		public string blockID;

		// Token: 0x04000D25 RID: 3365
		[Token(Token = "0x4000D25")]
		[FieldOffset(Offset = "0x18")]
		public string instanceID;

		// Token: 0x04000D26 RID: 3366
		[Token(Token = "0x4000D26")]
		[FieldOffset(Offset = "0x20")]
		public bool alwaysDisplay;

		// Token: 0x04000D27 RID: 3367
		[Token(Token = "0x4000D27")]
		[FieldOffset(Offset = "0x24")]
		public int group;

		// Token: 0x04000D28 RID: 3368
		[Token(Token = "0x4000D28")]
		[FieldOffset(Offset = "0x28")]
		public bool useTraits;

		// Token: 0x04000D29 RID: 3369
		[Token(Token = "0x4000D29")]
		[FieldOffset(Offset = "0x2C")]
		public DDSSaveClasses.TraitConditionType traitConditions;

		// Token: 0x04000D2A RID: 3370
		[Token(Token = "0x4000D2A")]
		[FieldOffset(Offset = "0x30")]
		public List<string> traits;
	}

	// Token: 0x02000210 RID: 528
	[Token(Token = "0x2000210")]
	public enum TreeType
	{
		// Token: 0x04000D2C RID: 3372
		[Token(Token = "0x4000D2C")]
		conversation,
		// Token: 0x04000D2D RID: 3373
		[Token(Token = "0x4000D2D")]
		vmail,
		// Token: 0x04000D2E RID: 3374
		[Token(Token = "0x4000D2E")]
		document,
		// Token: 0x04000D2F RID: 3375
		[Token(Token = "0x4000D2F")]
		newspaper,
		// Token: 0x04000D30 RID: 3376
		[Token(Token = "0x4000D30")]
		misc,
		// Token: 0x04000D31 RID: 3377
		[Token(Token = "0x4000D31")]
		interactionDialog
	}

	// Token: 0x02000211 RID: 529
	[Token(Token = "0x2000211")]
	[Serializable]
	public class DDSTreeSave : DDSSaveClasses.DDSComponent
	{
		// Token: 0x06000C67 RID: 3175 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x596CE0", Offset = "0x595CE0", VA = "0x180596CE0")]
		public string AddMessage(string newMsgID)
		{
			return null;
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x596F20", Offset = "0x595F20", VA = "0x180596F20")]
		public void RemoveMessage(string instID)
		{
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x597110", Offset = "0x596110", VA = "0x180597110")]
		public string AddElement(string elementName)
		{
			return null;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x597360", Offset = "0x596360", VA = "0x180597360")]
		public DDSTreeSave()
		{
		}

		// Token: 0x04000D32 RID: 3378
		[Token(Token = "0x4000D32")]
		[FieldOffset(Offset = "0x20")]
		public DDSSaveClasses.DDSParticipant participantA;

		// Token: 0x04000D33 RID: 3379
		[Token(Token = "0x4000D33")]
		[FieldOffset(Offset = "0x28")]
		public DDSSaveClasses.DDSParticipant participantB;

		// Token: 0x04000D34 RID: 3380
		[Token(Token = "0x4000D34")]
		[FieldOffset(Offset = "0x30")]
		public DDSSaveClasses.DDSParticipant participantC;

		// Token: 0x04000D35 RID: 3381
		[Token(Token = "0x4000D35")]
		[FieldOffset(Offset = "0x38")]
		public DDSSaveClasses.DDSParticipant participantD;

		// Token: 0x04000D36 RID: 3382
		[Token(Token = "0x4000D36")]
		[FieldOffset(Offset = "0x40")]
		public DDSSaveClasses.RepeatSetting repeat;

		// Token: 0x04000D37 RID: 3383
		[Token(Token = "0x4000D37")]
		[FieldOffset(Offset = "0x44")]
		public DDSSaveClasses.TriggerPoint triggerPoint;

		// Token: 0x04000D38 RID: 3384
		[Token(Token = "0x4000D38")]
		[FieldOffset(Offset = "0x48")]
		public List<DDSSaveClasses.DDSMessageSettings> messages;

		// Token: 0x04000D39 RID: 3385
		[Token(Token = "0x4000D39")]
		[FieldOffset(Offset = "0x50")]
		public bool stopMovement;

		// Token: 0x04000D3A RID: 3386
		[Token(Token = "0x4000D3A")]
		[FieldOffset(Offset = "0x51")]
		public bool ignoreGlobalRepeat;

		// Token: 0x04000D3B RID: 3387
		[Token(Token = "0x4000D3B")]
		[FieldOffset(Offset = "0x54")]
		public DDSSaveClasses.TreeType treeType;

		// Token: 0x04000D3C RID: 3388
		[Token(Token = "0x4000D3C")]
		[FieldOffset(Offset = "0x58")]
		public DDSSaveClasses.DDSDocument document;

		// Token: 0x04000D3D RID: 3389
		[Token(Token = "0x4000D3D")]
		[FieldOffset(Offset = "0x60")]
		public string startingMessage;

		// Token: 0x04000D3E RID: 3390
		[Token(Token = "0x4000D3E")]
		[FieldOffset(Offset = "0x68")]
		public float treeChance;

		// Token: 0x04000D3F RID: 3391
		[Token(Token = "0x4000D3F")]
		[FieldOffset(Offset = "0x6C")]
		public int priority;

		// Token: 0x04000D40 RID: 3392
		[Token(Token = "0x4000D40")]
		[FieldOffset(Offset = "0x70")]
		public int newspaperCategory;

		// Token: 0x04000D41 RID: 3393
		[Token(Token = "0x4000D41")]
		[FieldOffset(Offset = "0x74")]
		public int newspaperContext;

		// Token: 0x04000D42 RID: 3394
		[Token(Token = "0x4000D42")]
		[FieldOffset(Offset = "0x78")]
		public int interactionCitizenLimitation;

		// Token: 0x04000D43 RID: 3395
		[Token(Token = "0x4000D43")]
		[FieldOffset(Offset = "0x80")]
		public List<string> itemPool;

		// Token: 0x04000D44 RID: 3396
		[Token(Token = "0x4000D44")]
		[FieldOffset(Offset = "0x88")]
		public bool interactionOnePerCity;

		// Token: 0x04000D45 RID: 3397
		[Token(Token = "0x4000D45")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Dictionary<string, DDSSaveClasses.DDSMessageSettings> messageRef;

		// Token: 0x04000D46 RID: 3398
		[Token(Token = "0x4000D46")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public int citizenAddCount;

		// Token: 0x02000212 RID: 530
		[Token(Token = "0x2000212")]
		private sealed class <>c__DisplayClass22_0
		{
			// Token: 0x06000C6B RID: 3179 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C6B")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass22_0()
			{
			}

			// Token: 0x06000C6C RID: 3180 RVA: 0x00007140 File Offset: 0x00005340
			[Token(Token = "0x6000C6C")]
			[Address(RVA = "0x5976C0", Offset = "0x5966C0", VA = "0x1805976C0")]
			internal bool <RemoveMessage>b__0(DDSSaveClasses.DDSMessageSettings item)
			{
				return default(bool);
			}

			// Token: 0x04000D47 RID: 3399
			[Token(Token = "0x4000D47")]
			[FieldOffset(Offset = "0x10")]
			public string instID;
		}
	}

	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	[Serializable]
	public class DDSDocument
	{
		// Token: 0x06000C6D RID: 3181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x597720", Offset = "0x596720", VA = "0x180597720")]
		public DDSDocument()
		{
		}

		// Token: 0x04000D48 RID: 3400
		[Token(Token = "0x4000D48")]
		[FieldOffset(Offset = "0x10")]
		public string background;

		// Token: 0x04000D49 RID: 3401
		[Token(Token = "0x4000D49")]
		[FieldOffset(Offset = "0x18")]
		public Image.Type fill;

		// Token: 0x04000D4A RID: 3402
		[Token(Token = "0x4000D4A")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 size;

		// Token: 0x04000D4B RID: 3403
		[Token(Token = "0x4000D4B")]
		[FieldOffset(Offset = "0x24")]
		public Color colour;
	}

	// Token: 0x02000214 RID: 532
	[Token(Token = "0x2000214")]
	public enum ElementType
	{
		// Token: 0x04000D4D RID: 3405
		[Token(Token = "0x4000D4D")]
		messageText,
		// Token: 0x04000D4E RID: 3406
		[Token(Token = "0x4000D4E")]
		special
	}

	// Token: 0x02000215 RID: 533
	[Token(Token = "0x2000215")]
	[Serializable]
	public class DDSMessageSettings
	{
		// Token: 0x06000C6E RID: 3182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x597740", Offset = "0x596740", VA = "0x180597740")]
		public DDSMessageSettings()
		{
		}

		// Token: 0x04000D4F RID: 3407
		[Token(Token = "0x4000D4F")]
		[FieldOffset(Offset = "0x10")]
		public string msgID;

		// Token: 0x04000D50 RID: 3408
		[Token(Token = "0x4000D50")]
		[FieldOffset(Offset = "0x18")]
		public string elementName;

		// Token: 0x04000D51 RID: 3409
		[Token(Token = "0x4000D51")]
		[FieldOffset(Offset = "0x20")]
		public string instanceID;

		// Token: 0x04000D52 RID: 3410
		[Token(Token = "0x4000D52")]
		[FieldOffset(Offset = "0x28")]
		public int saidBy;

		// Token: 0x04000D53 RID: 3411
		[Token(Token = "0x4000D53")]
		[FieldOffset(Offset = "0x2C")]
		public int saidTo;

		// Token: 0x04000D54 RID: 3412
		[Token(Token = "0x4000D54")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 pos;

		// Token: 0x04000D55 RID: 3413
		[Token(Token = "0x4000D55")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 size;

		// Token: 0x04000D56 RID: 3414
		[Token(Token = "0x4000D56")]
		[FieldOffset(Offset = "0x40")]
		public float rot;

		// Token: 0x04000D57 RID: 3415
		[Token(Token = "0x4000D57")]
		[FieldOffset(Offset = "0x48")]
		public string font;

		// Token: 0x04000D58 RID: 3416
		[Token(Token = "0x4000D58")]
		[FieldOffset(Offset = "0x50")]
		public Color col;

		// Token: 0x04000D59 RID: 3417
		[Token(Token = "0x4000D59")]
		[FieldOffset(Offset = "0x60")]
		public float fontSize;

		// Token: 0x04000D5A RID: 3418
		[Token(Token = "0x4000D5A")]
		[FieldOffset(Offset = "0x64")]
		public float charSpace;

		// Token: 0x04000D5B RID: 3419
		[Token(Token = "0x4000D5B")]
		[FieldOffset(Offset = "0x68")]
		public float wordSpace;

		// Token: 0x04000D5C RID: 3420
		[Token(Token = "0x4000D5C")]
		[FieldOffset(Offset = "0x6C")]
		public float lineSpace;

		// Token: 0x04000D5D RID: 3421
		[Token(Token = "0x4000D5D")]
		[FieldOffset(Offset = "0x70")]
		public float paraSpace;

		// Token: 0x04000D5E RID: 3422
		[Token(Token = "0x4000D5E")]
		[FieldOffset(Offset = "0x74")]
		public int alignH;

		// Token: 0x04000D5F RID: 3423
		[Token(Token = "0x4000D5F")]
		[FieldOffset(Offset = "0x78")]
		public int alignV;

		// Token: 0x04000D60 RID: 3424
		[Token(Token = "0x4000D60")]
		[FieldOffset(Offset = "0x7C")]
		public int fontStyle;

		// Token: 0x04000D61 RID: 3425
		[Token(Token = "0x4000D61")]
		[FieldOffset(Offset = "0x80")]
		public int order;

		// Token: 0x04000D62 RID: 3426
		[Token(Token = "0x4000D62")]
		[FieldOffset(Offset = "0x84")]
		public bool usePages;

		// Token: 0x04000D63 RID: 3427
		[Token(Token = "0x4000D63")]
		[FieldOffset(Offset = "0x85")]
		public bool isHandwriting;

		// Token: 0x04000D64 RID: 3428
		[Token(Token = "0x4000D64")]
		[FieldOffset(Offset = "0x88")]
		public List<DDSSaveClasses.DDSMessageLink> links;
	}

	// Token: 0x02000216 RID: 534
	[Token(Token = "0x2000216")]
	[Serializable]
	public class DDSMessageLink
	{
		// Token: 0x06000C6F RID: 3183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x5978C0", Offset = "0x5968C0", VA = "0x1805978C0")]
		public DDSMessageLink()
		{
		}

		// Token: 0x04000D65 RID: 3429
		[Token(Token = "0x4000D65")]
		[FieldOffset(Offset = "0x10")]
		public string from;

		// Token: 0x04000D66 RID: 3430
		[Token(Token = "0x4000D66")]
		[FieldOffset(Offset = "0x18")]
		public string to;

		// Token: 0x04000D67 RID: 3431
		[Token(Token = "0x4000D67")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 delayInterval;

		// Token: 0x04000D68 RID: 3432
		[Token(Token = "0x4000D68")]
		[FieldOffset(Offset = "0x28")]
		public bool useWeights;

		// Token: 0x04000D69 RID: 3433
		[Token(Token = "0x4000D69")]
		[FieldOffset(Offset = "0x2C")]
		public float choiceWeight;

		// Token: 0x04000D6A RID: 3434
		[Token(Token = "0x4000D6A")]
		[FieldOffset(Offset = "0x30")]
		public bool useKnowLike;

		// Token: 0x04000D6B RID: 3435
		[Token(Token = "0x4000D6B")]
		[FieldOffset(Offset = "0x34")]
		public float know;

		// Token: 0x04000D6C RID: 3436
		[Token(Token = "0x4000D6C")]
		[FieldOffset(Offset = "0x38")]
		public float like;

		// Token: 0x04000D6D RID: 3437
		[Token(Token = "0x4000D6D")]
		[FieldOffset(Offset = "0x3C")]
		public bool isDialogSuccess;

		// Token: 0x04000D6E RID: 3438
		[Token(Token = "0x4000D6E")]
		[FieldOffset(Offset = "0x3D")]
		public bool secondaryBranchTrigger;

		// Token: 0x04000D6F RID: 3439
		[Token(Token = "0x4000D6F")]
		[FieldOffset(Offset = "0x40")]
		public float dialogSuccessModifier;

		// Token: 0x04000D70 RID: 3440
		[Token(Token = "0x4000D70")]
		[FieldOffset(Offset = "0x44")]
		public bool useTraits;

		// Token: 0x04000D71 RID: 3441
		[Token(Token = "0x4000D71")]
		[FieldOffset(Offset = "0x48")]
		public List<string> traits;

		// Token: 0x04000D72 RID: 3442
		[Token(Token = "0x4000D72")]
		[FieldOffset(Offset = "0x50")]
		public DDSSaveClasses.TraitConditionType traitConditions;
	}

	// Token: 0x02000217 RID: 535
	[Token(Token = "0x2000217")]
	[Serializable]
	public class DDSParticipant
	{
		// Token: 0x06000C70 RID: 3184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x5979B0", Offset = "0x5969B0", VA = "0x1805979B0")]
		public DDSParticipant()
		{
		}

		// Token: 0x04000D73 RID: 3443
		[Token(Token = "0x4000D73")]
		[FieldOffset(Offset = "0x10")]
		public bool required;

		// Token: 0x04000D74 RID: 3444
		[Token(Token = "0x4000D74")]
		[FieldOffset(Offset = "0x14")]
		public Acquaintance.ConnectionType connection;

		// Token: 0x04000D75 RID: 3445
		[Token(Token = "0x4000D75")]
		[FieldOffset(Offset = "0x18")]
		public bool useJobs;

		// Token: 0x04000D76 RID: 3446
		[Token(Token = "0x4000D76")]
		[FieldOffset(Offset = "0x19")]
		public bool disableInbox;

		// Token: 0x04000D77 RID: 3447
		[Token(Token = "0x4000D77")]
		[FieldOffset(Offset = "0x20")]
		public List<string> jobs;

		// Token: 0x04000D78 RID: 3448
		[Token(Token = "0x4000D78")]
		[FieldOffset(Offset = "0x28")]
		public bool useTraits;

		// Token: 0x04000D79 RID: 3449
		[Token(Token = "0x4000D79")]
		[FieldOffset(Offset = "0x30")]
		public List<string> traits;

		// Token: 0x04000D7A RID: 3450
		[Token(Token = "0x4000D7A")]
		[FieldOffset(Offset = "0x38")]
		public DDSSaveClasses.TraitConditionType traitConditions;

		// Token: 0x04000D7B RID: 3451
		[Token(Token = "0x4000D7B")]
		[FieldOffset(Offset = "0x40")]
		public List<DDSSaveClasses.TreeTriggers> triggers;
	}

	// Token: 0x02000218 RID: 536
	[Token(Token = "0x2000218")]
	[Serializable]
	public class DDSInteractionEvent
	{
		// Token: 0x06000C71 RID: 3185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DDSInteractionEvent()
		{
		}

		// Token: 0x04000D7C RID: 3452
		[Token(Token = "0x4000D7C")]
		[FieldOffset(Offset = "0x10")]
		public DDSSaveClasses.InteractionEvent on;

		// Token: 0x04000D7D RID: 3453
		[Token(Token = "0x4000D7D")]
		[FieldOffset(Offset = "0x18")]
		public string param;
	}

	// Token: 0x02000219 RID: 537
	[Token(Token = "0x2000219")]
	public enum InteractionEvent
	{
		// Token: 0x04000D7F RID: 3455
		[Token(Token = "0x4000D7F")]
		none,
		// Token: 0x04000D80 RID: 3456
		[Token(Token = "0x4000D80")]
		isInteractionDialog,
		// Token: 0x04000D81 RID: 3457
		[Token(Token = "0x4000D81")]
		generateNewItemFromPool,
		// Token: 0x04000D82 RID: 3458
		[Token(Token = "0x4000D82")]
		findWorldItemFromPool,
		// Token: 0x04000D83 RID: 3459
		[Token(Token = "0x4000D83")]
		giveMoney,
		// Token: 0x04000D84 RID: 3460
		[Token(Token = "0x4000D84")]
		testHasItem,
		// Token: 0x04000D85 RID: 3461
		[Token(Token = "0x4000D85")]
		testHasItemSameType,
		// Token: 0x04000D86 RID: 3462
		[Token(Token = "0x4000D86")]
		testHasItemSameTypeAndOwner,
		// Token: 0x04000D87 RID: 3463
		[Token(Token = "0x4000D87")]
		testHasItemSameTypeAndOwnerStat,
		// Token: 0x04000D88 RID: 3464
		[Token(Token = "0x4000D88")]
		clearItem,
		// Token: 0x04000D89 RID: 3465
		[Token(Token = "0x4000D89")]
		deleteItem,
		// Token: 0x04000D8A RID: 3466
		[Token(Token = "0x4000D8A")]
		clearAllAddedDialogOptions,
		// Token: 0x04000D8B RID: 3467
		[Token(Token = "0x4000D8B")]
		postNewspaperAd,
		// Token: 0x04000D8C RID: 3468
		[Token(Token = "0x4000D8C")]
		generateNewItem,
		// Token: 0x04000D8D RID: 3469
		[Token(Token = "0x4000D8D")]
		moveItemToInventory,
		// Token: 0x04000D8E RID: 3470
		[Token(Token = "0x4000D8E")]
		moveItem,
		// Token: 0x04000D8F RID: 3471
		[Token(Token = "0x4000D8F")]
		setItem,
		// Token: 0x04000D90 RID: 3472
		[Token(Token = "0x4000D90")]
		postJobNote,
		// Token: 0x04000D91 RID: 3473
		[Token(Token = "0x4000D91")]
		goTo,
		// Token: 0x04000D92 RID: 3474
		[Token(Token = "0x4000D92")]
		setNourishment,
		// Token: 0x04000D93 RID: 3475
		[Token(Token = "0x4000D93")]
		setHydration,
		// Token: 0x04000D94 RID: 3476
		[Token(Token = "0x4000D94")]
		setAlertness,
		// Token: 0x04000D95 RID: 3477
		[Token(Token = "0x4000D95")]
		setEnergy,
		// Token: 0x04000D96 RID: 3478
		[Token(Token = "0x4000D96")]
		setExcitement,
		// Token: 0x04000D97 RID: 3479
		[Token(Token = "0x4000D97")]
		setChores,
		// Token: 0x04000D98 RID: 3480
		[Token(Token = "0x4000D98")]
		setHygeine,
		// Token: 0x04000D99 RID: 3481
		[Token(Token = "0x4000D99")]
		setBladder,
		// Token: 0x04000D9A RID: 3482
		[Token(Token = "0x4000D9A")]
		setHeat,
		// Token: 0x04000D9B RID: 3483
		[Token(Token = "0x4000D9B")]
		setDrunk,
		// Token: 0x04000D9C RID: 3484
		[Token(Token = "0x4000D9C")]
		setPoisoned,
		// Token: 0x04000D9D RID: 3485
		[Token(Token = "0x4000D9D")]
		setHealth
	}
}
