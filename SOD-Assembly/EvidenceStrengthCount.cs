using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005F5 RID: 1525
[Token(Token = "0x20005F5")]
public class EvidenceStrengthCount : CountController
{
	// Token: 0x0600216B RID: 8555 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600216B")]
	[Address(RVA = "0xB06FD0", Offset = "0xB05FD0", VA = "0x180B06FD0")]
	public void SetMultiplier(int newVal)
	{
	}

	// Token: 0x0600216C RID: 8556 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600216C")]
	[Address(RVA = "0xB07050", Offset = "0xB06050", VA = "0x180B07050")]
	public void SetBonus(int newVal)
	{
	}

	// Token: 0x0600216D RID: 8557 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600216D")]
	[Address(RVA = "0xAFC200", Offset = "0xAFB200", VA = "0x180AFC200")]
	public EvidenceStrengthCount()
	{
	}

	// Token: 0x04002B16 RID: 11030
	[Token(Token = "0x4002B16")]
	[FieldOffset(Offset = "0x30")]
	public int multiplierCount;

	// Token: 0x04002B17 RID: 11031
	[Token(Token = "0x4002B17")]
	[FieldOffset(Offset = "0x38")]
	public Image multiplierCountImg;

	// Token: 0x04002B18 RID: 11032
	[Token(Token = "0x4002B18")]
	[FieldOffset(Offset = "0x40")]
	public Sprite multiplierCount0Sprite;

	// Token: 0x04002B19 RID: 11033
	[Token(Token = "0x4002B19")]
	[FieldOffset(Offset = "0x48")]
	public Sprite multiplierCount1Sprite;

	// Token: 0x04002B1A RID: 11034
	[Token(Token = "0x4002B1A")]
	[FieldOffset(Offset = "0x50")]
	public Sprite multiplierCount2Sprite;

	// Token: 0x04002B1B RID: 11035
	[Token(Token = "0x4002B1B")]
	[FieldOffset(Offset = "0x58")]
	public Sprite multiplierCount3Sprite;

	// Token: 0x04002B1C RID: 11036
	[Token(Token = "0x4002B1C")]
	[FieldOffset(Offset = "0x60")]
	public int bonusCount;

	// Token: 0x04002B1D RID: 11037
	[Token(Token = "0x4002B1D")]
	[FieldOffset(Offset = "0x68")]
	public Image bonusImage;

	// Token: 0x04002B1E RID: 11038
	[Token(Token = "0x4002B1E")]
	[FieldOffset(Offset = "0x70")]
	public Sprite plusSprite;

	// Token: 0x04002B1F RID: 11039
	[Token(Token = "0x4002B1F")]
	[FieldOffset(Offset = "0x78")]
	public Sprite minusSprite;

	// Token: 0x04002B20 RID: 11040
	[Token(Token = "0x4002B20")]
	[FieldOffset(Offset = "0x80")]
	public Image adjEffectDisplay;

	// Token: 0x04002B21 RID: 11041
	[Token(Token = "0x4002B21")]
	[FieldOffset(Offset = "0x88")]
	public TooltipController adjTooltip;
}
