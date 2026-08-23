using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew
{
	// Token: 0x020009AE RID: 2478
	[Token(Token = "0x20009AE")]
	[Serializable]
	public class ToleranceSphere : ScriptableObject
	{
		// Token: 0x06003529 RID: 13609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003529")]
		[Address(RVA = "0xD691C0", Offset = "0xD681C0", VA = "0x180D691C0")]
		public ToleranceSphere(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600352A")]
		[Address(RVA = "0xD69230", Offset = "0xD68230", VA = "0x180D69230")]
		public void SetProperties(ToleranceSphereJson tSphereJson)
		{
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600352B")]
		[Address(RVA = "0xD69270", Offset = "0xD68270", VA = "0x180D69270")]
		public void SetProperties(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}

		// Token: 0x040051E3 RID: 20963
		[Token(Token = "0x40051E3")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 worldPosition;

		// Token: 0x040051E4 RID: 20964
		[Token(Token = "0x40051E4")]
		[FieldOffset(Offset = "0x24")]
		public float diameter;

		// Token: 0x040051E5 RID: 20965
		[Token(Token = "0x40051E5")]
		[FieldOffset(Offset = "0x28")]
		public Color color;

		// Token: 0x040051E6 RID: 20966
		[Token(Token = "0x40051E6")]
		[FieldOffset(Offset = "0x38")]
		public float preservationStrength;

		// Token: 0x040051E7 RID: 20967
		[Token(Token = "0x40051E7")]
		[FieldOffset(Offset = "0x3C")]
		public bool isHidden;
	}
}
