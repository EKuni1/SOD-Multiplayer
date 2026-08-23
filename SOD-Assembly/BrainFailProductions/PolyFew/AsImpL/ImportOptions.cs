using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x020009CD RID: 2509
	[Token(Token = "0x20009CD")]
	[Serializable]
	public class ImportOptions
	{
		// Token: 0x06003593 RID: 13715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003593")]
		[Address(RVA = "0xD7B0A0", Offset = "0xD7A0A0", VA = "0x180D7B0A0")]
		public ImportOptions()
		{
		}

		// Token: 0x04005286 RID: 21126
		[Token(Token = "0x4005286")]
		[FieldOffset(Offset = "0x10")]
		public bool zUp;

		// Token: 0x04005287 RID: 21127
		[Token(Token = "0x4005287")]
		[FieldOffset(Offset = "0x11")]
		public bool litDiffuse;

		// Token: 0x04005288 RID: 21128
		[Token(Token = "0x4005288")]
		[FieldOffset(Offset = "0x12")]
		public bool convertToDoubleSided;

		// Token: 0x04005289 RID: 21129
		[Token(Token = "0x4005289")]
		[FieldOffset(Offset = "0x14")]
		public float modelScaling;

		// Token: 0x0400528A RID: 21130
		[Token(Token = "0x400528A")]
		[FieldOffset(Offset = "0x18")]
		public bool reuseLoaded;

		// Token: 0x0400528B RID: 21131
		[Token(Token = "0x400528B")]
		[FieldOffset(Offset = "0x19")]
		public bool inheritLayer;

		// Token: 0x0400528C RID: 21132
		[Token(Token = "0x400528C")]
		[FieldOffset(Offset = "0x1A")]
		public bool buildColliders;

		// Token: 0x0400528D RID: 21133
		[Token(Token = "0x400528D")]
		[FieldOffset(Offset = "0x1B")]
		public bool colliderConvex;

		// Token: 0x0400528E RID: 21134
		[Token(Token = "0x400528E")]
		[FieldOffset(Offset = "0x1C")]
		public bool colliderTrigger;

		// Token: 0x0400528F RID: 21135
		[Token(Token = "0x400528F")]
		[FieldOffset(Offset = "0x1D")]
		public bool use32bitIndices;

		// Token: 0x04005290 RID: 21136
		[Token(Token = "0x4005290")]
		[FieldOffset(Offset = "0x1E")]
		public bool hideWhileLoading;

		// Token: 0x04005291 RID: 21137
		[Token(Token = "0x4005291")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 localPosition;

		// Token: 0x04005292 RID: 21138
		[Token(Token = "0x4005292")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 localEulerAngles;

		// Token: 0x04005293 RID: 21139
		[Token(Token = "0x4005293")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 localScale;
	}
}
