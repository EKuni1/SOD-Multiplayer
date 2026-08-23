using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000765 RID: 1893
[Token(Token = "0x2000765")]
public class ArtPreset : SoCustomComparison
{
	// Token: 0x060028FA RID: 10490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028FA")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void GenerateColourMatching()
	{
	}

	// Token: 0x060028FB RID: 10491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028FB")]
	[Address(RVA = "0xC671A0", Offset = "0xC661A0", VA = "0x180C671A0")]
	public ArtPreset()
	{
	}

	// Token: 0x04003617 RID: 13847
	[Token(Token = "0x4003617")]
	[FieldOffset(Offset = "0x20")]
	public bool disable;

	// Token: 0x04003618 RID: 13848
	[Token(Token = "0x4003618")]
	[FieldOffset(Offset = "0x28")]
	public Texture2D texturePreview;

	// Token: 0x04003619 RID: 13849
	[Token(Token = "0x4003619")]
	[FieldOffset(Offset = "0x30")]
	public Material material;

	// Token: 0x0400361A RID: 13850
	[Token(Token = "0x400361A")]
	[FieldOffset(Offset = "0x38")]
	public List<ArtPreset.ArtOrientation> orientationCompatibility;

	// Token: 0x0400361B RID: 13851
	[Token(Token = "0x400361B")]
	[FieldOffset(Offset = "0x40")]
	public float pixelScaleMultiplier;

	// Token: 0x0400361C RID: 13852
	[Token(Token = "0x400361C")]
	[FieldOffset(Offset = "0x44")]
	public bool allowInResidential;

	// Token: 0x0400361D RID: 13853
	[Token(Token = "0x400361D")]
	[FieldOffset(Offset = "0x45")]
	public bool allowInCommerical;

	// Token: 0x0400361E RID: 13854
	[Token(Token = "0x400361E")]
	[FieldOffset(Offset = "0x46")]
	public bool allowInLobby;

	// Token: 0x0400361F RID: 13855
	[Token(Token = "0x400361F")]
	[FieldOffset(Offset = "0x47")]
	public bool allowOnStreet;

	// Token: 0x04003620 RID: 13856
	[Token(Token = "0x4003620")]
	[FieldOffset(Offset = "0x48")]
	public int basePriority;

	// Token: 0x04003621 RID: 13857
	[Token(Token = "0x4003621")]
	[FieldOffset(Offset = "0x50")]
	public List<Color> colourMatching;

	// Token: 0x04003622 RID: 13858
	[Token(Token = "0x4003622")]
	[FieldOffset(Offset = "0x58")]
	public int colourMatchingScale;

	// Token: 0x04003623 RID: 13859
	[Token(Token = "0x4003623")]
	[FieldOffset(Offset = "0x5C")]
	public float minimumWealth;

	// Token: 0x04003624 RID: 13860
	[Token(Token = "0x4003624")]
	[FieldOffset(Offset = "0x60")]
	public float maximumWealth;

	// Token: 0x04003625 RID: 13861
	[Token(Token = "0x4003625")]
	[FieldOffset(Offset = "0x64")]
	public int roomMatchingScale;

	// Token: 0x04003626 RID: 13862
	[Token(Token = "0x4003626")]
	[FieldOffset(Offset = "0x68")]
	public int modernity;

	// Token: 0x04003627 RID: 13863
	[Token(Token = "0x4003627")]
	[FieldOffset(Offset = "0x6C")]
	public int cleanness;

	// Token: 0x04003628 RID: 13864
	[Token(Token = "0x4003628")]
	[FieldOffset(Offset = "0x70")]
	public int loudness;

	// Token: 0x04003629 RID: 13865
	[Token(Token = "0x4003629")]
	[FieldOffset(Offset = "0x74")]
	public int emotive;

	// Token: 0x0400362A RID: 13866
	[Token(Token = "0x400362A")]
	[FieldOffset(Offset = "0x78")]
	public bool mustRequireTraitFromBelow;

	// Token: 0x0400362B RID: 13867
	[Token(Token = "0x400362B")]
	[FieldOffset(Offset = "0x80")]
	public List<ArtPreset.ArtPreference> traitModifiers;

	// Token: 0x0400362C RID: 13868
	[Token(Token = "0x400362C")]
	[FieldOffset(Offset = "0x88")]
	public bool useDynamicText;

	// Token: 0x0400362D RID: 13869
	[Token(Token = "0x400362D")]
	[FieldOffset(Offset = "0x8C")]
	public ArtPreset.DynamicTextSouce dynamicTextSource;

	// Token: 0x0400362E RID: 13870
	[Token(Token = "0x400362E")]
	[FieldOffset(Offset = "0x90")]
	public TMP_FontAsset textFont;

	// Token: 0x0400362F RID: 13871
	[Token(Token = "0x400362F")]
	[FieldOffset(Offset = "0x98")]
	public Color textColour;

	// Token: 0x04003630 RID: 13872
	[Token(Token = "0x4003630")]
	[FieldOffset(Offset = "0xA8")]
	public float textSize;

	// Token: 0x02000766 RID: 1894
	[Token(Token = "0x2000766")]
	public enum ArtOrientation
	{
		// Token: 0x04003632 RID: 13874
		[Token(Token = "0x4003632")]
		portrait,
		// Token: 0x04003633 RID: 13875
		[Token(Token = "0x4003633")]
		landscape,
		// Token: 0x04003634 RID: 13876
		[Token(Token = "0x4003634")]
		square,
		// Token: 0x04003635 RID: 13877
		[Token(Token = "0x4003635")]
		poster,
		// Token: 0x04003636 RID: 13878
		[Token(Token = "0x4003636")]
		litter,
		// Token: 0x04003637 RID: 13879
		[Token(Token = "0x4003637")]
		wallGrimeTop,
		// Token: 0x04003638 RID: 13880
		[Token(Token = "0x4003638")]
		wallGrimeBottom,
		// Token: 0x04003639 RID: 13881
		[Token(Token = "0x4003639")]
		dynamicClue,
		// Token: 0x0400363A RID: 13882
		[Token(Token = "0x400363A")]
		graffiti
	}

	// Token: 0x02000767 RID: 1895
	[Token(Token = "0x2000767")]
	[Serializable]
	public class ArtPreference
	{
		// Token: 0x060028FC RID: 10492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028FC")]
		[Address(RVA = "0xC67430", Offset = "0xC66430", VA = "0x180C67430")]
		public ArtPreference()
		{
		}

		// Token: 0x0400363B RID: 13883
		[Token(Token = "0x400363B")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait trait;

		// Token: 0x0400363C RID: 13884
		[Token(Token = "0x400363C")]
		[FieldOffset(Offset = "0x18")]
		public int modifier;
	}

	// Token: 0x02000768 RID: 1896
	[Token(Token = "0x2000768")]
	public enum DynamicTextSouce
	{
		// Token: 0x0400363E RID: 13886
		[Token(Token = "0x400363E")]
		weaponsDealerPassword,
		// Token: 0x0400363F RID: 13887
		[Token(Token = "0x400363F")]
		blackMarketTraderPassword
	}
}
