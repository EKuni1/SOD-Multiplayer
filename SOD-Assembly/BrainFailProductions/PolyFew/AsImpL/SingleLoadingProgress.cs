using System;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x020009EF RID: 2543
	[Token(Token = "0x20009EF")]
	public class SingleLoadingProgress
	{
		// Token: 0x0600363B RID: 13883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public SingleLoadingProgress()
		{
		}

		// Token: 0x0400538A RID: 21386
		[Token(Token = "0x400538A")]
		[FieldOffset(Offset = "0x10")]
		public string fileName;

		// Token: 0x0400538B RID: 21387
		[Token(Token = "0x400538B")]
		[FieldOffset(Offset = "0x18")]
		public string message;

		// Token: 0x0400538C RID: 21388
		[Token(Token = "0x400538C")]
		[FieldOffset(Offset = "0x20")]
		public float percentage;

		// Token: 0x0400538D RID: 21389
		[Token(Token = "0x400538D")]
		[FieldOffset(Offset = "0x24")]
		public int numObjects;

		// Token: 0x0400538E RID: 21390
		[Token(Token = "0x400538E")]
		[FieldOffset(Offset = "0x28")]
		public int numSubObjects;

		// Token: 0x0400538F RID: 21391
		[Token(Token = "0x400538F")]
		[FieldOffset(Offset = "0x2C")]
		public bool error;
	}
}
