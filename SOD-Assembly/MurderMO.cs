using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000843 RID: 2115
[Token(Token = "0x2000843")]
public class MurderMO : SoCustomComparison
{
	// Token: 0x060029BF RID: 10687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029BF")]
	[Address(RVA = "0xCAD3A0", Offset = "0xCAC3A0", VA = "0x180CAD3A0")]
	private void OnGUIDValueChangedCallback()
	{
	}

	// Token: 0x060029C0 RID: 10688 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029C0")]
	[Address(RVA = "0xCAD8F0", Offset = "0xCAC8F0", VA = "0x180CAD8F0")]
	public MurderMO()
	{
	}

	// Token: 0x04003FB1 RID: 16305
	[Token(Token = "0x4003FB1")]
	[FieldOffset(Offset = "0x20")]
	public string notes;

	// Token: 0x04003FB2 RID: 16306
	[Token(Token = "0x4003FB2")]
	[FieldOffset(Offset = "0x28")]
	public bool disabled;

	// Token: 0x04003FB3 RID: 16307
	[Token(Token = "0x4003FB3")]
	[FieldOffset(Offset = "0x30")]
	public List<MurderPreset> compatibleWith;

	// Token: 0x04003FB4 RID: 16308
	[Token(Token = "0x4003FB4")]
	[FieldOffset(Offset = "0x38")]
	public int baseDifficulty;

	// Token: 0x04003FB5 RID: 16309
	[Token(Token = "0x4003FB5")]
	[FieldOffset(Offset = "0x3C")]
	public float maximumPotentialScore;

	// Token: 0x04003FB6 RID: 16310
	[Token(Token = "0x4003FB6")]
	[FieldOffset(Offset = "0x40")]
	public bool updateThis;

	// Token: 0x04003FB7 RID: 16311
	[Token(Token = "0x4003FB7")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 pickRandomScoreRange;

	// Token: 0x04003FB8 RID: 16312
	[Token(Token = "0x4003FB8")]
	[FieldOffset(Offset = "0x50")]
	public List<MurderPreset.MurdererModifierRule> murdererTraitModifiers;

	// Token: 0x04003FB9 RID: 16313
	[Token(Token = "0x4003FB9")]
	[FieldOffset(Offset = "0x58")]
	public List<MurderMO.JobModifier> murdererJobModifiers;

	// Token: 0x04003FBA RID: 16314
	[Token(Token = "0x4003FBA")]
	[FieldOffset(Offset = "0x60")]
	public List<MurderMO.CompanyModifier> murdererCompanyModifiers;

	// Token: 0x04003FBB RID: 16315
	[Token(Token = "0x4003FBB")]
	[FieldOffset(Offset = "0x68")]
	public bool useMurdererSocialClassRange;

	// Token: 0x04003FBC RID: 16316
	[Token(Token = "0x4003FBC")]
	[FieldOffset(Offset = "0x6C")]
	public Vector2 murdererClassRange;

	// Token: 0x04003FBD RID: 16317
	[Token(Token = "0x4003FBD")]
	[FieldOffset(Offset = "0x74")]
	public int murdererClassRangeBoost;

	// Token: 0x04003FBE RID: 16318
	[Token(Token = "0x4003FBE")]
	[FieldOffset(Offset = "0x78")]
	public bool useHexaco;

	// Token: 0x04003FBF RID: 16319
	[Token(Token = "0x4003FBF")]
	[FieldOffset(Offset = "0x80")]
	public HEXACO hexaco;

	// Token: 0x04003FC0 RID: 16320
	[Token(Token = "0x4003FC0")]
	[FieldOffset(Offset = "0x88")]
	public bool requiresSniperVantageAtHome;

	// Token: 0x04003FC1 RID: 16321
	[Token(Token = "0x4003FC1")]
	[FieldOffset(Offset = "0x90")]
	public List<MurderWeaponsPool> weaponsPool;

	// Token: 0x04003FC2 RID: 16322
	[Token(Token = "0x4003FC2")]
	[FieldOffset(Offset = "0x98")]
	public bool blockDroppingWeapons;

	// Token: 0x04003FC3 RID: 16323
	[Token(Token = "0x4003FC3")]
	[FieldOffset(Offset = "0x99")]
	public bool allowAnywhere;

	// Token: 0x04003FC4 RID: 16324
	[Token(Token = "0x4003FC4")]
	[FieldOffset(Offset = "0x9A")]
	public bool allowHome;

	// Token: 0x04003FC5 RID: 16325
	[Token(Token = "0x4003FC5")]
	[FieldOffset(Offset = "0x9B")]
	public bool allowWork;

	// Token: 0x04003FC6 RID: 16326
	[Token(Token = "0x4003FC6")]
	[FieldOffset(Offset = "0x9C")]
	public bool allowPublic;

	// Token: 0x04003FC7 RID: 16327
	[Token(Token = "0x4003FC7")]
	[FieldOffset(Offset = "0x9D")]
	public bool allowStreets;

	// Token: 0x04003FC8 RID: 16328
	[Token(Token = "0x4003FC8")]
	[FieldOffset(Offset = "0x9E")]
	public bool allowDen;

	// Token: 0x04003FC9 RID: 16329
	[Token(Token = "0x4003FC9")]
	[FieldOffset(Offset = "0xA0")]
	public List<FurnitureCluster> denFurniture;

	// Token: 0x04003FCA RID: 16330
	[Token(Token = "0x4003FCA")]
	[FieldOffset(Offset = "0xA8")]
	public List<DesignStylePreset> denStyleOverride;

	// Token: 0x04003FCB RID: 16331
	[Token(Token = "0x4003FCB")]
	[FieldOffset(Offset = "0xB0")]
	public List<InteractablePreset> denItems;

	// Token: 0x04003FCC RID: 16332
	[Token(Token = "0x4003FCC")]
	[FieldOffset(Offset = "0xB8")]
	public int acquaintedSuitabilityBoost;

	// Token: 0x04003FCD RID: 16333
	[Token(Token = "0x4003FCD")]
	[FieldOffset(Offset = "0xBC")]
	public int attractedToSuitabilityBoost;

	// Token: 0x04003FCE RID: 16334
	[Token(Token = "0x4003FCE")]
	[FieldOffset(Offset = "0xC0")]
	public int likeSuitabilityBoost;

	// Token: 0x04003FCF RID: 16335
	[Token(Token = "0x4003FCF")]
	[FieldOffset(Offset = "0xC4")]
	public int sameWorkplaceBoost;

	// Token: 0x04003FD0 RID: 16336
	[Token(Token = "0x4003FD0")]
	[FieldOffset(Offset = "0xC8")]
	public int murdererIsTenantBoost;

	// Token: 0x04003FD1 RID: 16337
	[Token(Token = "0x4003FD1")]
	[FieldOffset(Offset = "0xCC")]
	public Vector2 victimRandomScoreRange;

	// Token: 0x04003FD2 RID: 16338
	[Token(Token = "0x4003FD2")]
	[FieldOffset(Offset = "0xD8")]
	public List<MurderPreset.MurdererModifierRule> victimTraitModifiers;

	// Token: 0x04003FD3 RID: 16339
	[Token(Token = "0x4003FD3")]
	[FieldOffset(Offset = "0xE0")]
	public List<MurderMO.JobModifier> victimJobModifiers;

	// Token: 0x04003FD4 RID: 16340
	[Token(Token = "0x4003FD4")]
	[FieldOffset(Offset = "0xE8")]
	public List<MurderMO.CompanyModifier> victimCompanyModifiers;

	// Token: 0x04003FD5 RID: 16341
	[Token(Token = "0x4003FD5")]
	[FieldOffset(Offset = "0xF0")]
	public bool useVictimSocialClassRange;

	// Token: 0x04003FD6 RID: 16342
	[Token(Token = "0x4003FD6")]
	[FieldOffset(Offset = "0xF4")]
	public Vector2 victimClassRange;

	// Token: 0x04003FD7 RID: 16343
	[Token(Token = "0x4003FD7")]
	[FieldOffset(Offset = "0xFC")]
	public int victimClassRangeBoost;

	// Token: 0x04003FD8 RID: 16344
	[Token(Token = "0x4003FD8")]
	[FieldOffset(Offset = "0x100")]
	public string monkierDDSMessageList;

	// Token: 0x04003FD9 RID: 16345
	[Token(Token = "0x4003FD9")]
	[FieldOffset(Offset = "0x108")]
	public List<string> confessionalDDSResponses;

	// Token: 0x04003FDA RID: 16346
	[Token(Token = "0x4003FDA")]
	[FieldOffset(Offset = "0x110")]
	public List<MurderPreset.MurderLeadItem> MOleads;

	// Token: 0x04003FDB RID: 16347
	[Token(Token = "0x4003FDB")]
	[FieldOffset(Offset = "0x118")]
	public List<MurderMO.Graffiti> graffiti;

	// Token: 0x04003FDC RID: 16348
	[Token(Token = "0x4003FDC")]
	[FieldOffset(Offset = "0x120")]
	public List<MurderMO.CallingCardPick> callingCardPool;

	// Token: 0x04003FDD RID: 16349
	[Token(Token = "0x4003FDD")]
	[FieldOffset(Offset = "0x128")]
	public List<InteractablePreset> playerTaunts;

	// Token: 0x02000844 RID: 2116
	[Token(Token = "0x2000844")]
	[Serializable]
	public class CallingCardPick
	{
		// Token: 0x060029C1 RID: 10689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C1")]
		[Address(RVA = "0xCAE2D0", Offset = "0xCAD2D0", VA = "0x180CAE2D0")]
		public CallingCardPick()
		{
		}

		// Token: 0x04003FDE RID: 16350
		[Token(Token = "0x4003FDE")]
		[FieldOffset(Offset = "0x10")]
		public InteractablePreset item;

		// Token: 0x04003FDF RID: 16351
		[Token(Token = "0x4003FDF")]
		[FieldOffset(Offset = "0x18")]
		public MurderMO.CallingCardOrigin origin;

		// Token: 0x04003FE0 RID: 16352
		[Token(Token = "0x4003FE0")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 randomScoreRange;

		// Token: 0x04003FE1 RID: 16353
		[Token(Token = "0x4003FE1")]
		[FieldOffset(Offset = "0x28")]
		public List<MurderPreset.MurdererModifierRule> traitModifiers;
	}

	// Token: 0x02000845 RID: 2117
	[Token(Token = "0x2000845")]
	public enum CallingCardOrigin
	{
		// Token: 0x04003FE3 RID: 16355
		[Token(Token = "0x4003FE3")]
		createAtScene,
		// Token: 0x04003FE4 RID: 16356
		[Token(Token = "0x4003FE4")]
		createOnGoToLocation
	}

	// Token: 0x02000846 RID: 2118
	[Token(Token = "0x2000846")]
	[Serializable]
	public class Graffiti
	{
		// Token: 0x060029C2 RID: 10690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C2")]
		[Address(RVA = "0xA7D030", Offset = "0xA7C030", VA = "0x180A7D030")]
		public Graffiti()
		{
		}

		// Token: 0x04003FE5 RID: 16357
		[Token(Token = "0x4003FE5")]
		[FieldOffset(Offset = "0x10")]
		public InteractablePreset preset;

		// Token: 0x04003FE6 RID: 16358
		[Token(Token = "0x4003FE6")]
		[FieldOffset(Offset = "0x18")]
		public MurderMO.Graffiti.GraffitiPosition pos;

		// Token: 0x04003FE7 RID: 16359
		[Token(Token = "0x4003FE7")]
		[FieldOffset(Offset = "0x20")]
		public ArtPreset artImage;

		// Token: 0x04003FE8 RID: 16360
		[Token(Token = "0x4003FE8")]
		[FieldOffset(Offset = "0x28")]
		public string ddsMessageTextList;

		// Token: 0x04003FE9 RID: 16361
		[Token(Token = "0x4003FE9")]
		[FieldOffset(Offset = "0x30")]
		public Color color;

		// Token: 0x04003FEA RID: 16362
		[Token(Token = "0x4003FEA")]
		[FieldOffset(Offset = "0x40")]
		public float size;

		// Token: 0x02000847 RID: 2119
		[Token(Token = "0x2000847")]
		public enum GraffitiPosition
		{
			// Token: 0x04003FEC RID: 16364
			[Token(Token = "0x4003FEC")]
			victim,
			// Token: 0x04003FED RID: 16365
			[Token(Token = "0x4003FED")]
			nearbyWall
		}
	}

	// Token: 0x02000848 RID: 2120
	[Token(Token = "0x2000848")]
	[Serializable]
	public class JobModifier
	{
		// Token: 0x060029C3 RID: 10691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C3")]
		[Address(RVA = "0xCAE3A0", Offset = "0xCAD3A0", VA = "0x180CAE3A0")]
		public JobModifier()
		{
		}

		// Token: 0x04003FEE RID: 16366
		[Token(Token = "0x4003FEE")]
		[FieldOffset(Offset = "0x10")]
		public List<OccupationPreset> jobs;

		// Token: 0x04003FEF RID: 16367
		[Token(Token = "0x4003FEF")]
		[FieldOffset(Offset = "0x18")]
		public int jobBoost;
	}

	// Token: 0x02000849 RID: 2121
	[Token(Token = "0x2000849")]
	[Serializable]
	public class CompanyModifier
	{
		// Token: 0x060029C4 RID: 10692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C4")]
		[Address(RVA = "0xCAE470", Offset = "0xCAD470", VA = "0x180CAE470")]
		public CompanyModifier()
		{
		}

		// Token: 0x04003FF0 RID: 16368
		[Token(Token = "0x4003FF0")]
		[FieldOffset(Offset = "0x10")]
		public List<CompanyPreset> companies;

		// Token: 0x04003FF1 RID: 16369
		[Token(Token = "0x4003FF1")]
		[FieldOffset(Offset = "0x18")]
		public int mininumEmployees;

		// Token: 0x04003FF2 RID: 16370
		[Token(Token = "0x4003FF2")]
		[FieldOffset(Offset = "0x1C")]
		public int companyBoost;

		// Token: 0x04003FF3 RID: 16371
		[Token(Token = "0x4003FF3")]
		[FieldOffset(Offset = "0x20")]
		public int boostPerEmployeeOverMinimum;
	}
}
