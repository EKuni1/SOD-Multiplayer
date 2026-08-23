using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x020009ED RID: 2541
	[Token(Token = "0x20009ED")]
	public class TextureLoader : MonoBehaviour
	{
		// Token: 0x06003633 RID: 13875 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003633")]
		[Address(RVA = "0xD927F0", Offset = "0xD917F0", VA = "0x180D927F0")]
		public static Texture2D LoadTextureFromUrl(string url)
		{
			return null;
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003634")]
		[Address(RVA = "0xD928F0", Offset = "0xD918F0", VA = "0x180D928F0")]
		public static Texture2D LoadTexture(string fileName)
		{
			return null;
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003635")]
		[Address(RVA = "0xD92BD0", Offset = "0xD91BD0", VA = "0x180D92BD0")]
		public static Texture2D LoadTGA(string fileName)
		{
			return null;
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003636")]
		[Address(RVA = "0xD92C90", Offset = "0xD91C90", VA = "0x180D92C90")]
		public static Texture2D LoadDDSManual(string ddsPath)
		{
			return null;
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003637")]
		[Address(RVA = "0xD93120", Offset = "0xD92120", VA = "0x180D93120")]
		public static Texture2D LoadTGA(Stream TGAStream)
		{
			return null;
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003638")]
		[Address(RVA = "0xD93630", Offset = "0xD92630", VA = "0x180D93630")]
		private static TextureLoader.TgaHeader LoadTgaHeader(BinaryReader r)
		{
			return null;
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003639")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public TextureLoader()
		{
		}

		// Token: 0x020009EE RID: 2542
		[Token(Token = "0x20009EE")]
		private class TgaHeader
		{
			// Token: 0x0600363A RID: 13882 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600363A")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public TgaHeader()
			{
			}

			// Token: 0x0400537E RID: 21374
			[Token(Token = "0x400537E")]
			[FieldOffset(Offset = "0x10")]
			public byte identSize;

			// Token: 0x0400537F RID: 21375
			[Token(Token = "0x400537F")]
			[FieldOffset(Offset = "0x11")]
			public byte colorMapType;

			// Token: 0x04005380 RID: 21376
			[Token(Token = "0x4005380")]
			[FieldOffset(Offset = "0x12")]
			public byte imageType;

			// Token: 0x04005381 RID: 21377
			[Token(Token = "0x4005381")]
			[FieldOffset(Offset = "0x14")]
			public ushort colorMapStart;

			// Token: 0x04005382 RID: 21378
			[Token(Token = "0x4005382")]
			[FieldOffset(Offset = "0x16")]
			public ushort colorMapLength;

			// Token: 0x04005383 RID: 21379
			[Token(Token = "0x4005383")]
			[FieldOffset(Offset = "0x18")]
			public byte colorMapBits;

			// Token: 0x04005384 RID: 21380
			[Token(Token = "0x4005384")]
			[FieldOffset(Offset = "0x1A")]
			public ushort xStart;

			// Token: 0x04005385 RID: 21381
			[Token(Token = "0x4005385")]
			[FieldOffset(Offset = "0x1C")]
			public ushort ySstart;

			// Token: 0x04005386 RID: 21382
			[Token(Token = "0x4005386")]
			[FieldOffset(Offset = "0x1E")]
			public ushort width;

			// Token: 0x04005387 RID: 21383
			[Token(Token = "0x4005387")]
			[FieldOffset(Offset = "0x20")]
			public ushort height;

			// Token: 0x04005388 RID: 21384
			[Token(Token = "0x4005388")]
			[FieldOffset(Offset = "0x22")]
			public byte bits;

			// Token: 0x04005389 RID: 21385
			[Token(Token = "0x4005389")]
			[FieldOffset(Offset = "0x23")]
			public byte descriptor;
		}
	}
}
