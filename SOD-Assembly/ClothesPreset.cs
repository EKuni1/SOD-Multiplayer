using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000799 RID: 1945
[Token(Token = "0x2000799")]
public class ClothesPreset : SoCustomComparison
{
	// Token: 0x06002935 RID: 10549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002935")]
	[Address(RVA = "0xCA1600", Offset = "0xCA0600", VA = "0x180CA1600")]
	public ClothesPreset()
	{
	}

	// Token: 0x04003805 RID: 14341
	[Token(Token = "0x4003805")]
	[FieldOffset(Offset = "0x20")]
	public List<CitizenOutfitController.CharacterAnchor> covers;

	// Token: 0x04003806 RID: 14342
	[Token(Token = "0x4003806")]
	[FieldOffset(Offset = "0x28")]
	public List<ClothesPreset.OutfitCategory> outfitCategories;

	// Token: 0x04003807 RID: 14343
	[Token(Token = "0x4003807")]
	[FieldOffset(Offset = "0x30")]
	public List<Human.Gender> suitableForGenders;

	// Token: 0x04003808 RID: 14344
	[Token(Token = "0x4003808")]
	[FieldOffset(Offset = "0x38")]
	public List<Descriptors.BuildType> suitableForBuilds;

	// Token: 0x04003809 RID: 14345
	[Token(Token = "0x4003809")]
	[FieldOffset(Offset = "0x40")]
	public List<ClothesPreset.ClothesTags> tags;

	// Token: 0x0400380A RID: 14346
	[Token(Token = "0x400380A")]
	[FieldOffset(Offset = "0x48")]
	public bool enableFacialFeatureSetup;

	// Token: 0x0400380B RID: 14347
	[Token(Token = "0x400380B")]
	[FieldOffset(Offset = "0x50")]
	public List<Descriptors.HairStyle> suitableForHairstyle;

	// Token: 0x0400380C RID: 14348
	[Token(Token = "0x400380C")]
	[FieldOffset(Offset = "0x58")]
	public bool isHead;

	// Token: 0x0400380D RID: 14349
	[Token(Token = "0x400380D")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 pupilsOffset;

	// Token: 0x0400380E RID: 14350
	[Token(Token = "0x400380E")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 eyebrowsOffset;

	// Token: 0x0400380F RID: 14351
	[Token(Token = "0x400380F")]
	[FieldOffset(Offset = "0x74")]
	public Vector3 mouthOffset;

	// Token: 0x04003810 RID: 14352
	[Token(Token = "0x4003810")]
	[FieldOffset(Offset = "0x80")]
	public bool hatRenderCompatible;

	// Token: 0x04003811 RID: 14353
	[Token(Token = "0x4003811")]
	[FieldOffset(Offset = "0x88")]
	public List<ClothesPreset> excludeHats;

	// Token: 0x04003812 RID: 14354
	[Token(Token = "0x4003812")]
	[FieldOffset(Offset = "0x90")]
	public ClothesPreset.HairRenderSetting hairRenderMode;

	// Token: 0x04003813 RID: 14355
	[Token(Token = "0x4003813")]
	[FieldOffset(Offset = "0x94")]
	public bool setFootwear;

	// Token: 0x04003814 RID: 14356
	[Token(Token = "0x4003814")]
	[FieldOffset(Offset = "0x98")]
	public Human.ShoeType footwear;

	// Token: 0x04003815 RID: 14357
	[Token(Token = "0x4003815")]
	[FieldOffset(Offset = "0x9C")]
	public int priority;

	// Token: 0x04003816 RID: 14358
	[Token(Token = "0x4003816")]
	[FieldOffset(Offset = "0xA0")]
	public bool onlyChooseIfAllModelPartsAreAvailable;

	// Token: 0x04003817 RID: 14359
	[Token(Token = "0x4003817")]
	[FieldOffset(Offset = "0xA8")]
	public List<ClothesPreset.IncompatibilitySetting> incompatibility;

	// Token: 0x04003818 RID: 14360
	[Token(Token = "0x4003818")]
	[FieldOffset(Offset = "0xB0")]
	public bool useWealthValues;

	// Token: 0x04003819 RID: 14361
	[Token(Token = "0x4003819")]
	[FieldOffset(Offset = "0xB4")]
	public float minimumWealth;

	// Token: 0x0400381A RID: 14362
	[Token(Token = "0x400381A")]
	[FieldOffset(Offset = "0xB8")]
	public float maximumWealth;

	// Token: 0x0400381B RID: 14363
	[Token(Token = "0x400381B")]
	[FieldOffset(Offset = "0xBC")]
	public ClothesPreset.ClothingColourSource baseColourSource;

	// Token: 0x0400381C RID: 14364
	[Token(Token = "0x400381C")]
	[FieldOffset(Offset = "0xC0")]
	public List<ColourPalettePreset> colourBase;

	// Token: 0x0400381D RID: 14365
	[Token(Token = "0x400381D")]
	[FieldOffset(Offset = "0xC8")]
	public ClothesPreset.ClothingColourSource colour1Source;

	// Token: 0x0400381E RID: 14366
	[Token(Token = "0x400381E")]
	[FieldOffset(Offset = "0xD0")]
	public List<ColourPalettePreset> colour1;

	// Token: 0x0400381F RID: 14367
	[Token(Token = "0x400381F")]
	[FieldOffset(Offset = "0xD8")]
	public ClothesPreset.ClothingColourSource colour2Source;

	// Token: 0x04003820 RID: 14368
	[Token(Token = "0x4003820")]
	[FieldOffset(Offset = "0xE0")]
	public List<ColourPalettePreset> colour2;

	// Token: 0x04003821 RID: 14369
	[Token(Token = "0x4003821")]
	[FieldOffset(Offset = "0xE8")]
	public ClothesPreset.ClothingColourSource colour3Source;

	// Token: 0x04003822 RID: 14370
	[Token(Token = "0x4003822")]
	[FieldOffset(Offset = "0xF0")]
	public List<ColourPalettePreset> colour3;

	// Token: 0x04003823 RID: 14371
	[Token(Token = "0x4003823")]
	[FieldOffset(Offset = "0xF8")]
	public bool includeInPersonalityMatching;

	// Token: 0x04003824 RID: 14372
	[Token(Token = "0x4003824")]
	[FieldOffset(Offset = "0xFC")]
	public int baseChance;

	// Token: 0x04003825 RID: 14373
	[Token(Token = "0x4003825")]
	[FieldOffset(Offset = "0x100")]
	public bool useHEXACO;

	// Token: 0x04003826 RID: 14374
	[Token(Token = "0x4003826")]
	[FieldOffset(Offset = "0x108")]
	public HEXACO hexaco;

	// Token: 0x04003827 RID: 14375
	[Token(Token = "0x4003827")]
	[FieldOffset(Offset = "0x110")]
	public bool useTraits;

	// Token: 0x04003828 RID: 14376
	[Token(Token = "0x4003828")]
	[FieldOffset(Offset = "0x118")]
	public List<ClothesPreset.TraitPickRule> characterTraits;

	// Token: 0x04003829 RID: 14377
	[Token(Token = "0x4003829")]
	[FieldOffset(Offset = "0x120")]
	public List<ClothesPreset.ModelSettings> models;

	// Token: 0x0200079A RID: 1946
	[Token(Token = "0x200079A")]
	[Serializable]
	public class MaterialSettings
	{
		// Token: 0x06002936 RID: 10550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002936")]
		[Address(RVA = "0xCA1F20", Offset = "0xCA0F20", VA = "0x180CA1F20")]
		public MaterialSettings()
		{
		}

		// Token: 0x0400382A RID: 14378
		[Token(Token = "0x400382A")]
		[FieldOffset(Offset = "0x10")]
		public Color colour;

		// Token: 0x0400382B RID: 14379
		[Token(Token = "0x400382B")]
		[FieldOffset(Offset = "0x20")]
		public int weighting;
	}

	// Token: 0x0200079B RID: 1947
	[Token(Token = "0x200079B")]
	[Serializable]
	public class ModelSettings
	{
		// Token: 0x06002937 RID: 10551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002937")]
		[Address(RVA = "0xCA1F30", Offset = "0xCA0F30", VA = "0x180CA1F30")]
		public ModelSettings()
		{
		}

		// Token: 0x0400382C RID: 14380
		[Token(Token = "0x400382C")]
		[FieldOffset(Offset = "0x10")]
		public GameObject prefab;

		// Token: 0x0400382D RID: 14381
		[Token(Token = "0x400382D")]
		[FieldOffset(Offset = "0x18")]
		public CitizenOutfitController.CharacterAnchor anchor;

		// Token: 0x0400382E RID: 14382
		[Token(Token = "0x400382E")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 offsetPosition;

		// Token: 0x0400382F RID: 14383
		[Token(Token = "0x400382F")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 offsetEuler;

		// Token: 0x04003830 RID: 14384
		[Token(Token = "0x4003830")]
		[FieldOffset(Offset = "0x34")]
		public bool exclusiveAnchorModel;
	}

	// Token: 0x0200079C RID: 1948
	[Token(Token = "0x200079C")]
	public enum OutfitCategory
	{
		// Token: 0x04003832 RID: 14386
		[Token(Token = "0x4003832")]
		casual,
		// Token: 0x04003833 RID: 14387
		[Token(Token = "0x4003833")]
		work,
		// Token: 0x04003834 RID: 14388
		[Token(Token = "0x4003834")]
		smart,
		// Token: 0x04003835 RID: 14389
		[Token(Token = "0x4003835")]
		outdoorsCasual,
		// Token: 0x04003836 RID: 14390
		[Token(Token = "0x4003836")]
		outdoorsWork,
		// Token: 0x04003837 RID: 14391
		[Token(Token = "0x4003837")]
		outdoorsSmart,
		// Token: 0x04003838 RID: 14392
		[Token(Token = "0x4003838")]
		undressed,
		// Token: 0x04003839 RID: 14393
		[Token(Token = "0x4003839")]
		bed,
		// Token: 0x0400383A RID: 14394
		[Token(Token = "0x400383A")]
		underwear
	}

	// Token: 0x0200079D RID: 1949
	[Token(Token = "0x200079D")]
	public enum ClothingColourSource
	{
		// Token: 0x0400383C RID: 14396
		[Token(Token = "0x400383C")]
		none,
		// Token: 0x0400383D RID: 14397
		[Token(Token = "0x400383D")]
		garment,
		// Token: 0x0400383E RID: 14398
		[Token(Token = "0x400383E")]
		skin,
		// Token: 0x0400383F RID: 14399
		[Token(Token = "0x400383F")]
		white,
		// Token: 0x04003840 RID: 14400
		[Token(Token = "0x4003840")]
		hair,
		// Token: 0x04003841 RID: 14401
		[Token(Token = "0x4003841")]
		underneathColour1,
		// Token: 0x04003842 RID: 14402
		[Token(Token = "0x4003842")]
		underneathColour2,
		// Token: 0x04003843 RID: 14403
		[Token(Token = "0x4003843")]
		underneathColour3,
		// Token: 0x04003844 RID: 14404
		[Token(Token = "0x4003844")]
		workUniformColour
	}

	// Token: 0x0200079E RID: 1950
	[Token(Token = "0x200079E")]
	public enum ClothesTags
	{
		// Token: 0x04003846 RID: 14406
		[Token(Token = "0x4003846")]
		longGarment,
		// Token: 0x04003847 RID: 14407
		[Token(Token = "0x4003847")]
		noLongGarments
	}

	// Token: 0x0200079F RID: 1951
	[Token(Token = "0x200079F")]
	public enum HairRenderSetting
	{
		// Token: 0x04003849 RID: 14409
		[Token(Token = "0x4003849")]
		renderHatCompatibleHair,
		// Token: 0x0400384A RID: 14410
		[Token(Token = "0x400384A")]
		renderAllHair,
		// Token: 0x0400384B RID: 14411
		[Token(Token = "0x400384B")]
		dontRenderAnyHair
	}

	// Token: 0x020007A0 RID: 1952
	[Token(Token = "0x20007A0")]
	public enum Incompatibility
	{
		// Token: 0x0400384D RID: 14413
		[Token(Token = "0x400384D")]
		inAnyCategory,
		// Token: 0x0400384E RID: 14414
		[Token(Token = "0x400384E")]
		inThisCategory
	}

	// Token: 0x020007A1 RID: 1953
	[Token(Token = "0x20007A1")]
	[Serializable]
	public class IncompatibilitySetting
	{
		// Token: 0x06002938 RID: 10552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002938")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public IncompatibilitySetting()
		{
		}

		// Token: 0x0400384F RID: 14415
		[Token(Token = "0x400384F")]
		[FieldOffset(Offset = "0x10")]
		public ClothesPreset.Incompatibility incompatibleIf;

		// Token: 0x04003850 RID: 14416
		[Token(Token = "0x4003850")]
		[FieldOffset(Offset = "0x18")]
		public List<ClothesPreset.ClothesTags> tags;

		// Token: 0x04003851 RID: 14417
		[Token(Token = "0x4003851")]
		[FieldOffset(Offset = "0x20")]
		public ClothesPreset featured;
	}

	// Token: 0x020007A2 RID: 1954
	[Token(Token = "0x20007A2")]
	[Serializable]
	public class TraitPickRule
	{
		// Token: 0x06002939 RID: 10553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002939")]
		[Address(RVA = "0xCA1F40", Offset = "0xCA0F40", VA = "0x180CA1F40")]
		public TraitPickRule()
		{
		}

		// Token: 0x04003852 RID: 14418
		[Token(Token = "0x4003852")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait.RuleType rule;

		// Token: 0x04003853 RID: 14419
		[Token(Token = "0x4003853")]
		[FieldOffset(Offset = "0x18")]
		public List<CharacterTrait> traitList;

		// Token: 0x04003854 RID: 14420
		[Token(Token = "0x4003854")]
		[FieldOffset(Offset = "0x20")]
		public bool mustPassForApplication;

		// Token: 0x04003855 RID: 14421
		[Token(Token = "0x4003855")]
		[FieldOffset(Offset = "0x24")]
		public int addChance;
	}
}
