using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007F8 RID: 2040
[Token(Token = "0x20007F8")]
public class FurniturePreset : SoCustomComparison
{
	// Token: 0x06002985 RID: 10629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002985")]
	[Address(RVA = "0xCA8890", Offset = "0xCA7890", VA = "0x180CA8890")]
	public FurniturePreset()
	{
	}

	// Token: 0x04003BA6 RID: 15270
	[Token(Token = "0x4003BA6")]
	[FieldOffset(Offset = "0x20")]
	public List<FurnitureClass> classes;

	// Token: 0x04003BA7 RID: 15271
	[Token(Token = "0x4003BA7")]
	[FieldOffset(Offset = "0x28")]
	public GameObject prefab;

	// Token: 0x04003BA8 RID: 15272
	[Token(Token = "0x4003BA8")]
	[FieldOffset(Offset = "0x30")]
	public bool allowStaticBatching;

	// Token: 0x04003BA9 RID: 15273
	[Token(Token = "0x4003BA9")]
	[FieldOffset(Offset = "0x34")]
	public ObjectPoolingController.ObjectLoadRange spawnRange;

	// Token: 0x04003BAA RID: 15274
	[Token(Token = "0x4003BAA")]
	[FieldOffset(Offset = "0x38")]
	public bool allowWeatherAffectedMaterials;

	// Token: 0x04003BAB RID: 15275
	[Token(Token = "0x4003BAB")]
	[FieldOffset(Offset = "0x40")]
	public List<FurniturePreset.IntegratedInteractable> integratedInteractables;

	// Token: 0x04003BAC RID: 15276
	[Token(Token = "0x4003BAC")]
	[FieldOffset(Offset = "0x48")]
	public bool universalDesignStyle;

	// Token: 0x04003BAD RID: 15277
	[Token(Token = "0x4003BAD")]
	[FieldOffset(Offset = "0x50")]
	public List<DesignStylePreset> designStyles;

	// Token: 0x04003BAE RID: 15278
	[Token(Token = "0x4003BAE")]
	[FieldOffset(Offset = "0x58")]
	public bool inheritColouringFromDecor;

	// Token: 0x04003BAF RID: 15279
	[Token(Token = "0x4003BAF")]
	[FieldOffset(Offset = "0x5C")]
	public FurniturePreset.ShareColours shareColours;

	// Token: 0x04003BB0 RID: 15280
	[Token(Token = "0x4003BB0")]
	[FieldOffset(Offset = "0x60")]
	public bool inheritGrubFromDecor;

	// Token: 0x04003BB1 RID: 15281
	[Token(Token = "0x4003BB1")]
	[FieldOffset(Offset = "0x68")]
	public List<MaterialGroupPreset.MaterialVariation> variations;

	// Token: 0x04003BB2 RID: 15282
	[Token(Token = "0x4003BB2")]
	[FieldOffset(Offset = "0x70")]
	public FurniturePreset.FurnitureGroup furnitureGroup;

	// Token: 0x04003BB3 RID: 15283
	[Token(Token = "0x4003BB3")]
	[FieldOffset(Offset = "0x74")]
	public int groupID;

	// Token: 0x04003BB4 RID: 15284
	[Token(Token = "0x4003BB4")]
	[FieldOffset(Offset = "0x78")]
	public float concrete;

	// Token: 0x04003BB5 RID: 15285
	[Token(Token = "0x4003BB5")]
	[FieldOffset(Offset = "0x7C")]
	public float plaster;

	// Token: 0x04003BB6 RID: 15286
	[Token(Token = "0x4003BB6")]
	[FieldOffset(Offset = "0x80")]
	public float wood;

	// Token: 0x04003BB7 RID: 15287
	[Token(Token = "0x4003BB7")]
	[FieldOffset(Offset = "0x84")]
	public float carpet;

	// Token: 0x04003BB8 RID: 15288
	[Token(Token = "0x4003BB8")]
	[FieldOffset(Offset = "0x88")]
	public float tile;

	// Token: 0x04003BB9 RID: 15289
	[Token(Token = "0x4003BB9")]
	[FieldOffset(Offset = "0x8C")]
	public float metal;

	// Token: 0x04003BBA RID: 15290
	[Token(Token = "0x4003BBA")]
	[FieldOffset(Offset = "0x90")]
	public float glass;

	// Token: 0x04003BBB RID: 15291
	[Token(Token = "0x4003BBB")]
	[FieldOffset(Offset = "0x94")]
	public float fabric;

	// Token: 0x04003BBC RID: 15292
	[Token(Token = "0x4003BBC")]
	[FieldOffset(Offset = "0x98")]
	public int minimumRoomSize;

	// Token: 0x04003BBD RID: 15293
	[Token(Token = "0x4003BBD")]
	[FieldOffset(Offset = "0x9C")]
	public FurnitureCluster.AllowedOpenPlan allowedInOpenPlan;

	// Token: 0x04003BBE RID: 15294
	[Token(Token = "0x4003BBE")]
	[FieldOffset(Offset = "0xA0")]
	public bool onlyAllowInFollowing;

	// Token: 0x04003BBF RID: 15295
	[Token(Token = "0x4003BBF")]
	[FieldOffset(Offset = "0xA8")]
	public List<AddressPreset> allowedInAddressesOfType;

	// Token: 0x04003BC0 RID: 15296
	[Token(Token = "0x4003BC0")]
	[FieldOffset(Offset = "0xB0")]
	public bool banInFollowing;

	// Token: 0x04003BC1 RID: 15297
	[Token(Token = "0x4003BC1")]
	[FieldOffset(Offset = "0xB8")]
	public List<AddressPreset> bannedInAddressesOfType;

	// Token: 0x04003BC2 RID: 15298
	[Token(Token = "0x4003BC2")]
	[FieldOffset(Offset = "0xC0")]
	public bool OnlyAllowInBuildings;

	// Token: 0x04003BC3 RID: 15299
	[Token(Token = "0x4003BC3")]
	[FieldOffset(Offset = "0xC8")]
	public List<BuildingPreset> allowedInBuildings;

	// Token: 0x04003BC4 RID: 15300
	[Token(Token = "0x4003BC4")]
	[FieldOffset(Offset = "0xD0")]
	public bool banFromBuildings;

	// Token: 0x04003BC5 RID: 15301
	[Token(Token = "0x4003BC5")]
	[FieldOffset(Offset = "0xD8")]
	public List<BuildingPreset> notAllowedInBuildings;

	// Token: 0x04003BC6 RID: 15302
	[Token(Token = "0x4003BC6")]
	[FieldOffset(Offset = "0xE0")]
	public bool OnlyAllowInDistricts;

	// Token: 0x04003BC7 RID: 15303
	[Token(Token = "0x4003BC7")]
	[FieldOffset(Offset = "0xE8")]
	public List<DistrictPreset> allowedInDistricts;

	// Token: 0x04003BC8 RID: 15304
	[Token(Token = "0x4003BC8")]
	[FieldOffset(Offset = "0xF0")]
	public bool banFromDistricts;

	// Token: 0x04003BC9 RID: 15305
	[Token(Token = "0x4003BC9")]
	[FieldOffset(Offset = "0xF8")]
	public List<DistrictPreset> notAllowedInDistricts;

	// Token: 0x04003BCA RID: 15306
	[Token(Token = "0x4003BCA")]
	[FieldOffset(Offset = "0x100")]
	public bool requiresGenderedInhabitants;

	// Token: 0x04003BCB RID: 15307
	[Token(Token = "0x4003BCB")]
	[FieldOffset(Offset = "0x108")]
	public List<Human.Gender> enableIfGenderPresent;

	// Token: 0x04003BCC RID: 15308
	[Token(Token = "0x4003BCC")]
	[FieldOffset(Offset = "0x110")]
	public List<RoomTypeFilter> allowedRoomFilters;

	// Token: 0x04003BCD RID: 15309
	[Token(Token = "0x4003BCD")]
	[FieldOffset(Offset = "0x118")]
	public float minimumWealth;

	// Token: 0x04003BCE RID: 15310
	[Token(Token = "0x4003BCE")]
	[FieldOffset(Offset = "0x120")]
	public List<FurniturePreset.SubObject> subObjects;

	// Token: 0x04003BCF RID: 15311
	[Token(Token = "0x4003BCF")]
	[FieldOffset(Offset = "0x128")]
	public FurniturePreset.ModifierTest testForModifiers;

	// Token: 0x04003BD0 RID: 15312
	[Token(Token = "0x4003BD0")]
	[FieldOffset(Offset = "0x12C")]
	public bool forcePublicIllegal;

	// Token: 0x04003BD1 RID: 15313
	[Token(Token = "0x4003BD1")]
	[FieldOffset(Offset = "0x130")]
	public PlayerTransitionPreset hidingEnterTransition;

	// Token: 0x04003BD2 RID: 15314
	[Token(Token = "0x4003BD2")]
	[FieldOffset(Offset = "0x138")]
	public PlayerTransitionPreset hidingExitTransition;

	// Token: 0x04003BD3 RID: 15315
	[Token(Token = "0x4003BD3")]
	[FieldOffset(Offset = "0x140")]
	public PlayerTransitionPreset hidingEnterTransition2;

	// Token: 0x04003BD4 RID: 15316
	[Token(Token = "0x4003BD4")]
	[FieldOffset(Offset = "0x148")]
	public PlayerTransitionPreset hidingExitTransition2;

	// Token: 0x04003BD5 RID: 15317
	[Token(Token = "0x4003BD5")]
	[FieldOffset(Offset = "0x150")]
	public Texture2D map;

	// Token: 0x04003BD6 RID: 15318
	[Token(Token = "0x4003BD6")]
	[FieldOffset(Offset = "0x158")]
	public bool drawUnderWalls;

	// Token: 0x04003BD7 RID: 15319
	[Token(Token = "0x4003BD7")]
	[FieldOffset(Offset = "0x159")]
	public bool ignoreDirection;

	// Token: 0x04003BD8 RID: 15320
	[Token(Token = "0x4003BD8")]
	[FieldOffset(Offset = "0x15A")]
	public bool fingerprintsEnabled;

	// Token: 0x04003BD9 RID: 15321
	[Token(Token = "0x4003BD9")]
	[FieldOffset(Offset = "0x15C")]
	public RoomConfiguration.PrintsSource printsSource;

	// Token: 0x04003BDA RID: 15322
	[Token(Token = "0x4003BDA")]
	[FieldOffset(Offset = "0x160")]
	public float fingerprintDensity;

	// Token: 0x04003BDB RID: 15323
	[Token(Token = "0x4003BDB")]
	[FieldOffset(Offset = "0x164")]
	public bool alterAreaLighting;

	// Token: 0x04003BDC RID: 15324
	[Token(Token = "0x4003BDC")]
	[FieldOffset(Offset = "0x168")]
	public List<Color> possibleColours;

	// Token: 0x04003BDD RID: 15325
	[Token(Token = "0x4003BDD")]
	[FieldOffset(Offset = "0x170")]
	public DistrictPreset.AffectStreetAreaLights lightOperation;

	// Token: 0x04003BDE RID: 15326
	[Token(Token = "0x4003BDE")]
	[FieldOffset(Offset = "0x174")]
	public float lightAmount;

	// Token: 0x04003BDF RID: 15327
	[Token(Token = "0x4003BDF")]
	[FieldOffset(Offset = "0x178")]
	public float brightnessModifier;

	// Token: 0x04003BE0 RID: 15328
	[Token(Token = "0x4003BE0")]
	[FieldOffset(Offset = "0x17C")]
	public bool purchasable;

	// Token: 0x04003BE1 RID: 15329
	[Token(Token = "0x4003BE1")]
	[FieldOffset(Offset = "0x17D")]
	public bool disableFromDecorMenu;

	// Token: 0x04003BE2 RID: 15330
	[Token(Token = "0x4003BE2")]
	[FieldOffset(Offset = "0x180")]
	public int cost;

	// Token: 0x04003BE3 RID: 15331
	[Token(Token = "0x4003BE3")]
	[FieldOffset(Offset = "0x184")]
	public FurniturePreset.DecorClass decorClass;

	// Token: 0x04003BE4 RID: 15332
	[Token(Token = "0x4003BE4")]
	[FieldOffset(Offset = "0x188")]
	public Sprite staticImage;

	// Token: 0x04003BE5 RID: 15333
	[Token(Token = "0x4003BE5")]
	[FieldOffset(Offset = "0x190")]
	public Vector3 imagePos;

	// Token: 0x04003BE6 RID: 15334
	[Token(Token = "0x4003BE6")]
	[FieldOffset(Offset = "0x19C")]
	public Vector3 imageRot;

	// Token: 0x04003BE7 RID: 15335
	[Token(Token = "0x4003BE7")]
	[FieldOffset(Offset = "0x1A8")]
	public float imageScale;

	// Token: 0x04003BE8 RID: 15336
	[Token(Token = "0x4003BE8")]
	[FieldOffset(Offset = "0x1B0")]
	public GameObject imagePrefabOverride;

	// Token: 0x04003BE9 RID: 15337
	[Token(Token = "0x4003BE9")]
	[FieldOffset(Offset = "0x1B8")]
	public bool isJobBoard;

	// Token: 0x04003BEA RID: 15338
	[Token(Token = "0x4003BEA")]
	[FieldOffset(Offset = "0x1B9")]
	public bool isWorkPosition;

	// Token: 0x04003BEB RID: 15339
	[Token(Token = "0x4003BEB")]
	[FieldOffset(Offset = "0x1BA")]
	public bool isPlant;

	// Token: 0x04003BEC RID: 15340
	[Token(Token = "0x4003BEC")]
	[FieldOffset(Offset = "0x1BB")]
	public bool isArt;

	// Token: 0x04003BED RID: 15341
	[Token(Token = "0x4003BED")]
	[FieldOffset(Offset = "0x1BC")]
	public bool isSecurityCamera;

	// Token: 0x04003BEE RID: 15342
	[Token(Token = "0x4003BEE")]
	[FieldOffset(Offset = "0x1BD")]
	public bool onLoadAdjacentPlayerTeleport;

	// Token: 0x04003BEF RID: 15343
	[Token(Token = "0x4003BEF")]
	[FieldOffset(Offset = "0x1C0")]
	public ArtPreset.ArtOrientation artOrientation;

	// Token: 0x04003BF0 RID: 15344
	[Token(Token = "0x4003BF0")]
	[FieldOffset(Offset = "0x1C8")]
	public CompanyPreset createSelfEmployed;

	// Token: 0x04003BF1 RID: 15345
	[Token(Token = "0x4003BF1")]
	[FieldOffset(Offset = "0x1D0")]
	public InteractableController.InteractableID workPositionID;

	// Token: 0x04003BF2 RID: 15346
	[Token(Token = "0x4003BF2")]
	[FieldOffset(Offset = "0x1D4")]
	public float spawnObjectOnChance;

	// Token: 0x04003BF3 RID: 15347
	[Token(Token = "0x4003BF3")]
	[FieldOffset(Offset = "0x1D8")]
	public List<InteractablePreset> spawnObjectsOnPlacement;

	// Token: 0x020007F9 RID: 2041
	[Token(Token = "0x20007F9")]
	public enum SubObjectOwnership
	{
		// Token: 0x04003BF5 RID: 15349
		[Token(Token = "0x4003BF5")]
		nobody,
		// Token: 0x04003BF6 RID: 15350
		[Token(Token = "0x4003BF6")]
		everybody,
		// Token: 0x04003BF7 RID: 15351
		[Token(Token = "0x4003BF7")]
		person0,
		// Token: 0x04003BF8 RID: 15352
		[Token(Token = "0x4003BF8")]
		person1,
		// Token: 0x04003BF9 RID: 15353
		[Token(Token = "0x4003BF9")]
		person2,
		// Token: 0x04003BFA RID: 15354
		[Token(Token = "0x4003BFA")]
		person3,
		// Token: 0x04003BFB RID: 15355
		[Token(Token = "0x4003BFB")]
		person4,
		// Token: 0x04003BFC RID: 15356
		[Token(Token = "0x4003BFC")]
		person5,
		// Token: 0x04003BFD RID: 15357
		[Token(Token = "0x4003BFD")]
		person6,
		// Token: 0x04003BFE RID: 15358
		[Token(Token = "0x4003BFE")]
		person7,
		// Token: 0x04003BFF RID: 15359
		[Token(Token = "0x4003BFF")]
		person8,
		// Token: 0x04003C00 RID: 15360
		[Token(Token = "0x4003C00")]
		person9,
		// Token: 0x04003C01 RID: 15361
		[Token(Token = "0x4003C01")]
		person10,
		// Token: 0x04003C02 RID: 15362
		[Token(Token = "0x4003C02")]
		person11,
		// Token: 0x04003C03 RID: 15363
		[Token(Token = "0x4003C03")]
		person12,
		// Token: 0x04003C04 RID: 15364
		[Token(Token = "0x4003C04")]
		person13,
		// Token: 0x04003C05 RID: 15365
		[Token(Token = "0x4003C05")]
		person14,
		// Token: 0x04003C06 RID: 15366
		[Token(Token = "0x4003C06")]
		person15,
		// Token: 0x04003C07 RID: 15367
		[Token(Token = "0x4003C07")]
		person16,
		// Token: 0x04003C08 RID: 15368
		[Token(Token = "0x4003C08")]
		person17,
		// Token: 0x04003C09 RID: 15369
		[Token(Token = "0x4003C09")]
		person18,
		// Token: 0x04003C0A RID: 15370
		[Token(Token = "0x4003C0A")]
		person19,
		// Token: 0x04003C0B RID: 15371
		[Token(Token = "0x4003C0B")]
		person20,
		// Token: 0x04003C0C RID: 15372
		[Token(Token = "0x4003C0C")]
		person21,
		// Token: 0x04003C0D RID: 15373
		[Token(Token = "0x4003C0D")]
		person22,
		// Token: 0x04003C0E RID: 15374
		[Token(Token = "0x4003C0E")]
		person23,
		// Token: 0x04003C0F RID: 15375
		[Token(Token = "0x4003C0F")]
		person24,
		// Token: 0x04003C10 RID: 15376
		[Token(Token = "0x4003C10")]
		person25,
		// Token: 0x04003C11 RID: 15377
		[Token(Token = "0x4003C11")]
		person26,
		// Token: 0x04003C12 RID: 15378
		[Token(Token = "0x4003C12")]
		person27,
		// Token: 0x04003C13 RID: 15379
		[Token(Token = "0x4003C13")]
		person28,
		// Token: 0x04003C14 RID: 15380
		[Token(Token = "0x4003C14")]
		person29
	}

	// Token: 0x020007FA RID: 2042
	[Token(Token = "0x20007FA")]
	[Serializable]
	public class SubObject
	{
		// Token: 0x06002986 RID: 10630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002986")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public SubObject()
		{
		}

		// Token: 0x04003C15 RID: 15381
		[Token(Token = "0x4003C15")]
		[FieldOffset(Offset = "0x10")]
		public SubObjectClassPreset preset;

		// Token: 0x04003C16 RID: 15382
		[Token(Token = "0x4003C16")]
		[FieldOffset(Offset = "0x18")]
		public string parent;

		// Token: 0x04003C17 RID: 15383
		[Token(Token = "0x4003C17")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 localPos;

		// Token: 0x04003C18 RID: 15384
		[Token(Token = "0x4003C18")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 localRot;

		// Token: 0x04003C19 RID: 15385
		[Token(Token = "0x4003C19")]
		[FieldOffset(Offset = "0x38")]
		public FurniturePreset.SubObjectOwnership belongsTo;

		// Token: 0x04003C1A RID: 15386
		[Token(Token = "0x4003C1A")]
		[FieldOffset(Offset = "0x3C")]
		public int security;
	}

	// Token: 0x020007FB RID: 2043
	[Token(Token = "0x20007FB")]
	[Serializable]
	public class IntegratedInteractable
	{
		// Token: 0x06002987 RID: 10631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002987")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public IntegratedInteractable()
		{
		}

		// Token: 0x04003C1B RID: 15387
		[Token(Token = "0x4003C1B")]
		[FieldOffset(Offset = "0x10")]
		public InteractablePreset preset;

		// Token: 0x04003C1C RID: 15388
		[Token(Token = "0x4003C1C")]
		[FieldOffset(Offset = "0x18")]
		public InteractableController.InteractableID pairToController;

		// Token: 0x04003C1D RID: 15389
		[Token(Token = "0x4003C1D")]
		[FieldOffset(Offset = "0x1C")]
		public FurniturePreset.SubObjectOwnership belongsTo;
	}

	// Token: 0x020007FC RID: 2044
	[Token(Token = "0x20007FC")]
	public enum ShareColours
	{
		// Token: 0x04003C1F RID: 15391
		[Token(Token = "0x4003C1F")]
		none,
		// Token: 0x04003C20 RID: 15392
		[Token(Token = "0x4003C20")]
		seating,
		// Token: 0x04003C21 RID: 15393
		[Token(Token = "0x4003C21")]
		wallFrontage,
		// Token: 0x04003C22 RID: 15394
		[Token(Token = "0x4003C22")]
		cabinets,
		// Token: 0x04003C23 RID: 15395
		[Token(Token = "0x4003C23")]
		cubicles,
		// Token: 0x04003C24 RID: 15396
		[Token(Token = "0x4003C24")]
		curtains,
		// Token: 0x04003C25 RID: 15397
		[Token(Token = "0x4003C25")]
		telephone,
		// Token: 0x04003C26 RID: 15398
		[Token(Token = "0x4003C26")]
		wood,
		// Token: 0x04003C27 RID: 15399
		[Token(Token = "0x4003C27")]
		doors,
		// Token: 0x04003C28 RID: 15400
		[Token(Token = "0x4003C28")]
		shelving,
		// Token: 0x04003C29 RID: 15401
		[Token(Token = "0x4003C29")]
		bins,
		// Token: 0x04003C2A RID: 15402
		[Token(Token = "0x4003C2A")]
		blinds
	}

	// Token: 0x020007FD RID: 2045
	[Token(Token = "0x20007FD")]
	public enum FurnitureGroup
	{
		// Token: 0x04003C2C RID: 15404
		[Token(Token = "0x4003C2C")]
		none,
		// Token: 0x04003C2D RID: 15405
		[Token(Token = "0x4003C2D")]
		seating,
		// Token: 0x04003C2E RID: 15406
		[Token(Token = "0x4003C2E")]
		windowDecor
	}

	// Token: 0x020007FE RID: 2046
	[Token(Token = "0x20007FE")]
	public enum ModifierTest
	{
		// Token: 0x04003C30 RID: 15408
		[Token(Token = "0x4003C30")]
		none,
		// Token: 0x04003C31 RID: 15409
		[Token(Token = "0x4003C31")]
		testOwner,
		// Token: 0x04003C32 RID: 15410
		[Token(Token = "0x4003C32")]
		testInhbitants
	}

	// Token: 0x020007FF RID: 2047
	[Token(Token = "0x20007FF")]
	public enum DecorClass
	{
		// Token: 0x04003C34 RID: 15412
		[Token(Token = "0x4003C34")]
		chairs,
		// Token: 0x04003C35 RID: 15413
		[Token(Token = "0x4003C35")]
		tables,
		// Token: 0x04003C36 RID: 15414
		[Token(Token = "0x4003C36")]
		units,
		// Token: 0x04003C37 RID: 15415
		[Token(Token = "0x4003C37")]
		electronics,
		// Token: 0x04003C38 RID: 15416
		[Token(Token = "0x4003C38")]
		structural,
		// Token: 0x04003C39 RID: 15417
		[Token(Token = "0x4003C39")]
		decoration,
		// Token: 0x04003C3A RID: 15418
		[Token(Token = "0x4003C3A")]
		misc
	}
}
