using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.AsImpL
{
	// Token: 0x020009F2 RID: 2546
	[Token(Token = "0x20009F2")]
	public class MultiObjectImporter : ObjectImporter
	{
		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600363E RID: 13886 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000577")]
		public string RootPath
		{
			[Token(Token = "0x600363E")]
			[Address(RVA = "0xD93BA0", Offset = "0xD92BA0", VA = "0x180D93BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363F")]
		[Address(RVA = "0xD93CE0", Offset = "0xD92CE0", VA = "0x180D93CE0")]
		public void ImportModelListAsync(ModelImportInfo[] modelsInfo)
		{
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003640")]
		[Address(RVA = "0xD93F60", Offset = "0xD92F60", VA = "0x180D93F60", Slot = "10")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003641")]
		[Address(RVA = "0xD93FD0", Offset = "0xD92FD0", VA = "0x180D93FD0")]
		public MultiObjectImporter()
		{
		}

		// Token: 0x04005395 RID: 21397
		[Token(Token = "0x4005395")]
		[FieldOffset(Offset = "0x60")]
		public bool autoLoadOnStart;

		// Token: 0x04005396 RID: 21398
		[Token(Token = "0x4005396")]
		[FieldOffset(Offset = "0x68")]
		public List<ModelImportInfo> objectsList;

		// Token: 0x04005397 RID: 21399
		[Token(Token = "0x4005397")]
		[FieldOffset(Offset = "0x70")]
		public ImportOptions defaultImportOptions;

		// Token: 0x04005398 RID: 21400
		[Token(Token = "0x4005398")]
		[FieldOffset(Offset = "0x78")]
		private PathSettings pathSettings;
	}
}
