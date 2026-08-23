using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x020009C6 RID: 2502
	[Token(Token = "0x20009C6")]
	public class MaterialData
	{
		// Token: 0x0600357A RID: 13690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600357A")]
		[Address(RVA = "0xD74810", Offset = "0xD73810", VA = "0x180D74810")]
		public MaterialData()
		{
		}

		// Token: 0x04005258 RID: 21080
		[Token(Token = "0x4005258")]
		[FieldOffset(Offset = "0x10")]
		public string materialName;

		// Token: 0x04005259 RID: 21081
		[Token(Token = "0x4005259")]
		[FieldOffset(Offset = "0x18")]
		public Color ambientColor;

		// Token: 0x0400525A RID: 21082
		[Token(Token = "0x400525A")]
		[FieldOffset(Offset = "0x28")]
		public Color diffuseColor;

		// Token: 0x0400525B RID: 21083
		[Token(Token = "0x400525B")]
		[FieldOffset(Offset = "0x38")]
		public Color specularColor;

		// Token: 0x0400525C RID: 21084
		[Token(Token = "0x400525C")]
		[FieldOffset(Offset = "0x48")]
		public Color emissiveColor;

		// Token: 0x0400525D RID: 21085
		[Token(Token = "0x400525D")]
		[FieldOffset(Offset = "0x58")]
		public float shininess;

		// Token: 0x0400525E RID: 21086
		[Token(Token = "0x400525E")]
		[FieldOffset(Offset = "0x5C")]
		public float overallAlpha;

		// Token: 0x0400525F RID: 21087
		[Token(Token = "0x400525F")]
		[FieldOffset(Offset = "0x60")]
		public int illumType;

		// Token: 0x04005260 RID: 21088
		[Token(Token = "0x4005260")]
		[FieldOffset(Offset = "0x64")]
		public bool hasReflectionTex;

		// Token: 0x04005261 RID: 21089
		[Token(Token = "0x4005261")]
		[FieldOffset(Offset = "0x68")]
		public string diffuseTexPath;

		// Token: 0x04005262 RID: 21090
		[Token(Token = "0x4005262")]
		[FieldOffset(Offset = "0x70")]
		public Texture2D diffuseTex;

		// Token: 0x04005263 RID: 21091
		[Token(Token = "0x4005263")]
		[FieldOffset(Offset = "0x78")]
		public string bumpTexPath;

		// Token: 0x04005264 RID: 21092
		[Token(Token = "0x4005264")]
		[FieldOffset(Offset = "0x80")]
		public Texture2D bumpTex;

		// Token: 0x04005265 RID: 21093
		[Token(Token = "0x4005265")]
		[FieldOffset(Offset = "0x88")]
		public string specularTexPath;

		// Token: 0x04005266 RID: 21094
		[Token(Token = "0x4005266")]
		[FieldOffset(Offset = "0x90")]
		public Texture2D specularTex;

		// Token: 0x04005267 RID: 21095
		[Token(Token = "0x4005267")]
		[FieldOffset(Offset = "0x98")]
		public string opacityTexPath;

		// Token: 0x04005268 RID: 21096
		[Token(Token = "0x4005268")]
		[FieldOffset(Offset = "0xA0")]
		public Texture2D opacityTex;
	}
}
