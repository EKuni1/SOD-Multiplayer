using System;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x020009F1 RID: 2545
	[Token(Token = "0x20009F1")]
	[Serializable]
	public class ModelImportInfo
	{
		// Token: 0x0600363D RID: 13885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ModelImportInfo()
		{
		}

		// Token: 0x04005391 RID: 21393
		[Token(Token = "0x4005391")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04005392 RID: 21394
		[Token(Token = "0x4005392")]
		[FieldOffset(Offset = "0x18")]
		public string path;

		// Token: 0x04005393 RID: 21395
		[Token(Token = "0x4005393")]
		[FieldOffset(Offset = "0x20")]
		public bool skip;

		// Token: 0x04005394 RID: 21396
		[Token(Token = "0x4005394")]
		[FieldOffset(Offset = "0x28")]
		public ImportOptions loaderOptions;
	}
}
