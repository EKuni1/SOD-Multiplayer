using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000871 RID: 2161
[Token(Token = "0x2000871")]
public class RetailItemPreset : SoCustomComparison
{
	// Token: 0x060029DA RID: 10714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029DA")]
	[Address(RVA = "0xCB0B30", Offset = "0xCAFB30", VA = "0x180CB0B30")]
	public RetailItemPreset()
	{
	}

	// Token: 0x040041CB RID: 16843
	[Token(Token = "0x40041CB")]
	[FieldOffset(Offset = "0x20")]
	public InteractablePreset itemPreset;

	// Token: 0x040041CC RID: 16844
	[Token(Token = "0x40041CC")]
	[FieldOffset(Offset = "0x28")]
	public bool canBeFavourite;

	// Token: 0x040041CD RID: 16845
	[Token(Token = "0x40041CD")]
	[FieldOffset(Offset = "0x29")]
	public bool isHot;

	// Token: 0x040041CE RID: 16846
	[Token(Token = "0x40041CE")]
	[FieldOffset(Offset = "0x2A")]
	public bool isConsumable;

	// Token: 0x040041CF RID: 16847
	[Token(Token = "0x40041CF")]
	[FieldOffset(Offset = "0x30")]
	public string brandName;

	// Token: 0x040041D0 RID: 16848
	[Token(Token = "0x40041D0")]
	[FieldOffset(Offset = "0x38")]
	public List<RetailItemPreset.Tags> tags;

	// Token: 0x040041D1 RID: 16849
	[Token(Token = "0x40041D1")]
	[FieldOffset(Offset = "0x40")]
	public CompanyPreset.CompanyCategory desireCategory;

	// Token: 0x040041D2 RID: 16850
	[Token(Token = "0x40041D2")]
	[FieldOffset(Offset = "0x44")]
	public RetailItemPreset.MenuCategory menuCategory;

	// Token: 0x040041D3 RID: 16851
	[Token(Token = "0x40041D3")]
	[FieldOffset(Offset = "0x48")]
	public List<Descriptors.EthnicGroup> ethnicity;

	// Token: 0x040041D4 RID: 16852
	[Token(Token = "0x40041D4")]
	[FieldOffset(Offset = "0x50")]
	public float minimumWealth;

	// Token: 0x040041D5 RID: 16853
	[Token(Token = "0x40041D5")]
	[FieldOffset(Offset = "0x58")]
	public List<CharacterTrait> mustFeatureTraits;

	// Token: 0x040041D6 RID: 16854
	[Token(Token = "0x40041D6")]
	[FieldOffset(Offset = "0x60")]
	public List<CharacterTrait> cantFeatureTrait;

	// Token: 0x040041D7 RID: 16855
	[Token(Token = "0x40041D7")]
	[FieldOffset(Offset = "0x68")]
	public List<CharacterTrait> preferredTraits;

	// Token: 0x040041D8 RID: 16856
	[Token(Token = "0x40041D8")]
	[FieldOffset(Offset = "0x70")]
	public float nourishment;

	// Token: 0x040041D9 RID: 16857
	[Token(Token = "0x40041D9")]
	[FieldOffset(Offset = "0x74")]
	public float hydration;

	// Token: 0x040041DA RID: 16858
	[Token(Token = "0x40041DA")]
	[FieldOffset(Offset = "0x78")]
	public float alertness;

	// Token: 0x040041DB RID: 16859
	[Token(Token = "0x40041DB")]
	[FieldOffset(Offset = "0x7C")]
	public float energy;

	// Token: 0x040041DC RID: 16860
	[Token(Token = "0x40041DC")]
	[FieldOffset(Offset = "0x80")]
	public float excitement;

	// Token: 0x040041DD RID: 16861
	[Token(Token = "0x40041DD")]
	[FieldOffset(Offset = "0x84")]
	public float chores;

	// Token: 0x040041DE RID: 16862
	[Token(Token = "0x40041DE")]
	[FieldOffset(Offset = "0x88")]
	public float hygiene;

	// Token: 0x040041DF RID: 16863
	[Token(Token = "0x40041DF")]
	[FieldOffset(Offset = "0x8C")]
	public float bladder;

	// Token: 0x040041E0 RID: 16864
	[Token(Token = "0x40041E0")]
	[FieldOffset(Offset = "0x90")]
	public float heat;

	// Token: 0x040041E1 RID: 16865
	[Token(Token = "0x40041E1")]
	[FieldOffset(Offset = "0x94")]
	public float drunk;

	// Token: 0x040041E2 RID: 16866
	[Token(Token = "0x40041E2")]
	[FieldOffset(Offset = "0x98")]
	public float sick;

	// Token: 0x040041E3 RID: 16867
	[Token(Token = "0x40041E3")]
	[FieldOffset(Offset = "0x9C")]
	public float headache;

	// Token: 0x040041E4 RID: 16868
	[Token(Token = "0x40041E4")]
	[FieldOffset(Offset = "0xA0")]
	public float wet;

	// Token: 0x040041E5 RID: 16869
	[Token(Token = "0x40041E5")]
	[FieldOffset(Offset = "0xA4")]
	public float brokenLeg;

	// Token: 0x040041E6 RID: 16870
	[Token(Token = "0x40041E6")]
	[FieldOffset(Offset = "0xA8")]
	public float bruised;

	// Token: 0x040041E7 RID: 16871
	[Token(Token = "0x40041E7")]
	[FieldOffset(Offset = "0xAC")]
	public float blackEye;

	// Token: 0x040041E8 RID: 16872
	[Token(Token = "0x40041E8")]
	[FieldOffset(Offset = "0xB0")]
	public float blackedOut;

	// Token: 0x040041E9 RID: 16873
	[Token(Token = "0x40041E9")]
	[FieldOffset(Offset = "0xB4")]
	public float numb;

	// Token: 0x040041EA RID: 16874
	[Token(Token = "0x40041EA")]
	[FieldOffset(Offset = "0xB8")]
	public float bleeding;

	// Token: 0x040041EB RID: 16875
	[Token(Token = "0x40041EB")]
	[FieldOffset(Offset = "0xBC")]
	public float wellRested;

	// Token: 0x040041EC RID: 16876
	[Token(Token = "0x40041EC")]
	[FieldOffset(Offset = "0xC0")]
	public float breath;

	// Token: 0x040041ED RID: 16877
	[Token(Token = "0x40041ED")]
	[FieldOffset(Offset = "0xC4")]
	public float starchAddiction;

	// Token: 0x040041EE RID: 16878
	[Token(Token = "0x40041EE")]
	[FieldOffset(Offset = "0xC8")]
	public float poisoned;

	// Token: 0x040041EF RID: 16879
	[Token(Token = "0x40041EF")]
	[FieldOffset(Offset = "0xCC")]
	public float health;

	// Token: 0x02000872 RID: 2162
	[Token(Token = "0x2000872")]
	public enum Tags
	{
		// Token: 0x040041F1 RID: 16881
		[Token(Token = "0x40041F1")]
		starchProduct
	}

	// Token: 0x02000873 RID: 2163
	[Token(Token = "0x2000873")]
	public enum MenuCategory
	{
		// Token: 0x040041F3 RID: 16883
		[Token(Token = "0x40041F3")]
		food,
		// Token: 0x040041F4 RID: 16884
		[Token(Token = "0x40041F4")]
		drinks,
		// Token: 0x040041F5 RID: 16885
		[Token(Token = "0x40041F5")]
		snacks,
		// Token: 0x040041F6 RID: 16886
		[Token(Token = "0x40041F6")]
		none
	}
}
