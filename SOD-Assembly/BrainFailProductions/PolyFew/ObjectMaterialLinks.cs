using System;
using System.Collections.Generic;
using BrainFailProductions.PolyFewRuntime;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew
{
	// Token: 0x020009A8 RID: 2472
	[Token(Token = "0x20009A8")]
	public class ObjectMaterialLinks : MonoBehaviour
	{
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060034F7 RID: 13559 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060034F8 RID: 13560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054A")]
		public List<CombiningInformation.MaterialEntity> linkedMaterialEntities
		{
			[Token(Token = "0x60034F7")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60034F8")]
			[Address(RVA = "0xD685F0", Offset = "0xD675F0", VA = "0x180D685F0")]
			set
			{
			}
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F9")]
		[Address(RVA = "0xD68AF0", Offset = "0xD67AF0", VA = "0x180D68AF0")]
		private void Start()
		{
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FA")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public ObjectMaterialLinks()
		{
		}

		// Token: 0x040051D1 RID: 20945
		[Token(Token = "0x40051D1")]
		[FieldOffset(Offset = "0x18")]
		private List<CombiningInformation.MaterialEntity> linkedEntities;

		// Token: 0x040051D2 RID: 20946
		[Token(Token = "0x40051D2")]
		[FieldOffset(Offset = "0x20")]
		public List<PolyfewRuntime.MaterialProperties> materialsProperties;

		// Token: 0x040051D3 RID: 20947
		[Token(Token = "0x40051D3")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D linkedAttrImg;
	}
}
