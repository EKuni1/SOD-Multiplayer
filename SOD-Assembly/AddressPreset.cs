using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000743 RID: 1859
[Token(Token = "0x2000743")]
public class AddressPreset : SoCustomComparison
{
	// Token: 0x060028EF RID: 10479 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028EF")]
	[Address(RVA = "0xC65640", Offset = "0xC64640", VA = "0x180C65640")]
	public AddressPreset()
	{
	}

	// Token: 0x040033F5 RID: 13301
	[Token(Token = "0x40033F5")]
	[FieldOffset(Offset = "0x20")]
	public bool debug;

	// Token: 0x040033F6 RID: 13302
	[Token(Token = "0x40033F6")]
	[FieldOffset(Offset = "0x24")]
	public int fitsUnitSizeMin;

	// Token: 0x040033F7 RID: 13303
	[Token(Token = "0x40033F7")]
	[FieldOffset(Offset = "0x28")]
	public int fitsUnitSizeMax;

	// Token: 0x040033F8 RID: 13304
	[Token(Token = "0x40033F8")]
	[FieldOffset(Offset = "0x2C")]
	public bool hardSizeLimits;

	// Token: 0x040033F9 RID: 13305
	[Token(Token = "0x40033F9")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 minMaxFloors;

	// Token: 0x040033FA RID: 13306
	[Token(Token = "0x40033FA")]
	[FieldOffset(Offset = "0x38")]
	public bool important;

	// Token: 0x040033FB RID: 13307
	[Token(Token = "0x40033FB")]
	[FieldOffset(Offset = "0x3C")]
	public int maxInstances;

	// Token: 0x040033FC RID: 13308
	[Token(Token = "0x40033FC")]
	[FieldOffset(Offset = "0x40")]
	public int baseScore;

	// Token: 0x040033FD RID: 13309
	[Token(Token = "0x40033FD")]
	[FieldOffset(Offset = "0x44")]
	public int baseScoreFrequencyPenalty;

	// Token: 0x040033FE RID: 13310
	[Token(Token = "0x40033FE")]
	[FieldOffset(Offset = "0x48")]
	public float idealFootfall;

	// Token: 0x040033FF RID: 13311
	[Token(Token = "0x40033FF")]
	[FieldOffset(Offset = "0x4C")]
	public float footfallMultiplier;

	// Token: 0x04003400 RID: 13312
	[Token(Token = "0x4003400")]
	[FieldOffset(Offset = "0x50")]
	public List<AddressPreset.AddressRule> addressRules;

	// Token: 0x04003401 RID: 13313
	[Token(Token = "0x4003401")]
	[FieldOffset(Offset = "0x58")]
	public List<BuildingPreset> limitToBuildings;

	// Token: 0x04003402 RID: 13314
	[Token(Token = "0x4003402")]
	[FieldOffset(Offset = "0x60")]
	public bool forcePick;

	// Token: 0x04003403 RID: 13315
	[Token(Token = "0x4003403")]
	[FieldOffset(Offset = "0x61")]
	public bool ethnicityMatters;

	// Token: 0x04003404 RID: 13316
	[Token(Token = "0x4003404")]
	[FieldOffset(Offset = "0x64")]
	public Descriptors.EthnicGroup ethnicity;

	// Token: 0x04003405 RID: 13317
	[Token(Token = "0x4003405")]
	[FieldOffset(Offset = "0x68")]
	public List<LayoutConfiguration> compatible;

	// Token: 0x04003406 RID: 13318
	[Token(Token = "0x4003406")]
	[FieldOffset(Offset = "0x70")]
	public List<RoomConfiguration> roomConfig;

	// Token: 0x04003407 RID: 13319
	[Token(Token = "0x4003407")]
	[FieldOffset(Offset = "0x78")]
	public AddressPreset.AccessType access;

	// Token: 0x04003408 RID: 13320
	[Token(Token = "0x4003408")]
	[FieldOffset(Offset = "0x7C")]
	public bool canPassThrough;

	// Token: 0x04003409 RID: 13321
	[Token(Token = "0x4003409")]
	[FieldOffset(Offset = "0x7D")]
	public bool openHoursDicatedByAdjoiningCompany;

	// Token: 0x0400340A RID: 13322
	[Token(Token = "0x400340A")]
	[FieldOffset(Offset = "0x7E")]
	public bool needsPassword;

	// Token: 0x0400340B RID: 13323
	[Token(Token = "0x400340B")]
	[FieldOffset(Offset = "0x80")]
	public List<string> dictionaryPasswordSources;

	// Token: 0x0400340C RID: 13324
	[Token(Token = "0x400340C")]
	[FieldOffset(Offset = "0x88")]
	public CompanyPreset company;

	// Token: 0x0400340D RID: 13325
	[Token(Token = "0x400340D")]
	[FieldOffset(Offset = "0x90")]
	public ResidencePreset residence;

	// Token: 0x0400340E RID: 13326
	[Token(Token = "0x400340E")]
	[FieldOffset(Offset = "0x98")]
	public bool playerKnowsPurpose;

	// Token: 0x0400340F RID: 13327
	[Token(Token = "0x400340F")]
	[FieldOffset(Offset = "0xA0")]
	public Sprite evidenceIconLarge;

	// Token: 0x04003410 RID: 13328
	[Token(Token = "0x4003410")]
	[FieldOffset(Offset = "0xA8")]
	public float chanceOfNameSignHorizontal;

	// Token: 0x04003411 RID: 13329
	[Token(Token = "0x4003411")]
	[FieldOffset(Offset = "0xAC")]
	public Vector3 horizontalSignOffset;

	// Token: 0x04003412 RID: 13330
	[Token(Token = "0x4003412")]
	[FieldOffset(Offset = "0xB8")]
	public List<NeonSignCharacters> signCharacterSet;

	// Token: 0x04003413 RID: 13331
	[Token(Token = "0x4003413")]
	[FieldOffset(Offset = "0xC0")]
	public float chanceOfNameSignVertical;

	// Token: 0x04003414 RID: 13332
	[Token(Token = "0x4003414")]
	[FieldOffset(Offset = "0xC8")]
	public List<GameObject> possibleSigns;

	// Token: 0x04003415 RID: 13333
	[Token(Token = "0x4003415")]
	[FieldOffset(Offset = "0xD0")]
	public List<InteractablePreset> specialItems;

	// Token: 0x04003416 RID: 13334
	[Token(Token = "0x4003416")]
	[FieldOffset(Offset = "0xD8")]
	public float chanceOfExternalSpareKey;

	// Token: 0x04003417 RID: 13335
	[Token(Token = "0x4003417")]
	[FieldOffset(Offset = "0xDC")]
	public Vector2 airVentRange;

	// Token: 0x04003418 RID: 13336
	[Token(Token = "0x4003418")]
	[FieldOffset(Offset = "0xE4")]
	public bool useOwnSecuritySystem;

	// Token: 0x04003419 RID: 13337
	[Token(Token = "0x4003419")]
	[FieldOffset(Offset = "0xE5")]
	public bool useOwnBreakerBox;

	// Token: 0x0400341A RID: 13338
	[Token(Token = "0x400341A")]
	[FieldOffset(Offset = "0xE6")]
	public bool alarmLocksDownFloor;

	// Token: 0x0400341B RID: 13339
	[Token(Token = "0x400341B")]
	[FieldOffset(Offset = "0xE7")]
	public bool overrideBuildingEnvironment;

	// Token: 0x0400341C RID: 13340
	[Token(Token = "0x400341C")]
	[FieldOffset(Offset = "0xE8")]
	public SessionData.SceneProfile sceneProfile;

	// Token: 0x0400341D RID: 13341
	[Token(Token = "0x400341D")]
	[FieldOffset(Offset = "0xEC")]
	public bool entrancesLockedByDefault;

	// Token: 0x0400341E RID: 13342
	[Token(Token = "0x400341E")]
	[FieldOffset(Offset = "0xED")]
	public bool leaveLightsOn;

	// Token: 0x0400341F RID: 13343
	[Token(Token = "0x400341F")]
	[FieldOffset(Offset = "0xEE")]
	public bool disableLockingUp;

	// Token: 0x04003420 RID: 13344
	[Token(Token = "0x4003420")]
	[FieldOffset(Offset = "0xEF")]
	public bool disableLocationInformationDisplay;

	// Token: 0x04003421 RID: 13345
	[Token(Token = "0x4003421")]
	[FieldOffset(Offset = "0xF0")]
	public bool forceCityDirectoryInclusion;

	// Token: 0x04003422 RID: 13346
	[Token(Token = "0x4003422")]
	[FieldOffset(Offset = "0xF1")]
	public bool nameFeaturesBuildingReference;

	// Token: 0x04003423 RID: 13347
	[Token(Token = "0x4003423")]
	[FieldOffset(Offset = "0xF2")]
	public bool nameFeaturesTypeCount;

	// Token: 0x04003424 RID: 13348
	[Token(Token = "0x4003424")]
	[FieldOffset(Offset = "0xF3")]
	public bool overrideBuildingName;

	// Token: 0x04003425 RID: 13349
	[Token(Token = "0x4003425")]
	[FieldOffset(Offset = "0xF4")]
	public bool sameBuildingEmployeesAuthority;

	// Token: 0x04003426 RID: 13350
	[Token(Token = "0x4003426")]
	[FieldOffset(Offset = "0xF5")]
	public bool sameBuildingResidentsAuthority;

	// Token: 0x04003427 RID: 13351
	[Token(Token = "0x4003427")]
	[FieldOffset(Offset = "0xF6")]
	public bool canFeatureLostAndFound;

	// Token: 0x04003428 RID: 13352
	[Token(Token = "0x4003428")]
	[FieldOffset(Offset = "0xF8")]
	public float minimumLandValue;

	// Token: 0x04003429 RID: 13353
	[Token(Token = "0x4003429")]
	[FieldOffset(Offset = "0xFC")]
	public float maximumLandValue;

	// Token: 0x0400342A RID: 13354
	[Token(Token = "0x400342A")]
	[FieldOffset(Offset = "0x100")]
	public bool allowSniperVantagePoint;

	// Token: 0x0400342B RID: 13355
	[Token(Token = "0x400342B")]
	[FieldOffset(Offset = "0x104")]
	public float vantagePointBoost;

	// Token: 0x0400342C RID: 13356
	[Token(Token = "0x400342C")]
	[FieldOffset(Offset = "0x108")]
	public bool disableSniperTargetSite;

	// Token: 0x0400342D RID: 13357
	[Token(Token = "0x400342D")]
	[FieldOffset(Offset = "0x109")]
	public bool allowPublicToiletUse;

	// Token: 0x0400342E RID: 13358
	[Token(Token = "0x400342E")]
	[FieldOffset(Offset = "0x10A")]
	public bool disableThis;

	// Token: 0x02000744 RID: 1860
	[Token(Token = "0x2000744")]
	[Serializable]
	public class AddressRule
	{
		// Token: 0x060028F0 RID: 10480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public AddressRule()
		{
		}

		// Token: 0x0400342F RID: 13359
		[Token(Token = "0x400342F")]
		[FieldOffset(Offset = "0x10")]
		public DistrictPreset districtPreset;

		// Token: 0x04003430 RID: 13360
		[Token(Token = "0x4003430")]
		[FieldOffset(Offset = "0x18")]
		public int scoreModifier;
	}

	// Token: 0x02000745 RID: 1861
	[Token(Token = "0x2000745")]
	public enum AccessType
	{
		// Token: 0x04003432 RID: 13362
		[Token(Token = "0x4003432")]
		allPublic,
		// Token: 0x04003433 RID: 13363
		[Token(Token = "0x4003433")]
		residents,
		// Token: 0x04003434 RID: 13364
		[Token(Token = "0x4003434")]
		buildingInhabitants,
		// Token: 0x04003435 RID: 13365
		[Token(Token = "0x4003435")]
		employees,
		// Token: 0x04003436 RID: 13366
		[Token(Token = "0x4003436")]
		none
	}
}
