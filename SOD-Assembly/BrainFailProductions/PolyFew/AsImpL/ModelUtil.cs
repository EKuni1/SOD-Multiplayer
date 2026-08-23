using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x020009C7 RID: 2503
	[Token(Token = "0x20009C7")]
	public class ModelUtil
	{
		// Token: 0x0600357B RID: 13691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600357B")]
		[Address(RVA = "0xD74820", Offset = "0xD73820", VA = "0x180D74820")]
		public static void SetupMaterialWithBlendMode(Material mtl, ModelUtil.MtlBlendMode mode)
		{
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x00012960 File Offset: 0x00010B60
		[Token(Token = "0x600357C")]
		[Address(RVA = "0xD74C70", Offset = "0xD73C70", VA = "0x180D74C70")]
		public static bool ScanTransparentPixels(Texture2D texture, ref ModelUtil.MtlBlendMode mode)
		{
			return default(bool);
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600357D")]
		[Address(RVA = "0xD74F30", Offset = "0xD73F30", VA = "0x180D74F30")]
		public static void DetectMtlBlendFadeOrCutout(float alpha, ref ModelUtil.MtlBlendMode mode, ref bool noDoubt)
		{
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600357E")]
		[Address(RVA = "0xD74F70", Offset = "0xD73F70", VA = "0x180D74F70")]
		public static Texture2D HeightToNormalMap(Texture2D bumpMap, float amount = 1f)
		{
			return null;
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x00012978 File Offset: 0x00010B78
		[Token(Token = "0x600357F")]
		[Address(RVA = "0xD75580", Offset = "0xD74580", VA = "0x180D75580")]
		private static int WrapInt(int pos, int boundary)
		{
			return 0;
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003580")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ModelUtil()
		{
		}

		// Token: 0x020009C8 RID: 2504
		[Token(Token = "0x20009C8")]
		public enum MtlBlendMode
		{
			// Token: 0x0400526A RID: 21098
			[Token(Token = "0x400526A")]
			OPAQUE,
			// Token: 0x0400526B RID: 21099
			[Token(Token = "0x400526B")]
			CUTOUT,
			// Token: 0x0400526C RID: 21100
			[Token(Token = "0x400526C")]
			FADE,
			// Token: 0x0400526D RID: 21101
			[Token(Token = "0x400526D")]
			TRANSPARENT
		}
	}
}
