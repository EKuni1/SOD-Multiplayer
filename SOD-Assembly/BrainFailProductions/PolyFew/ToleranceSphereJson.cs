using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BrainFailProductions.PolyFew
{
	// Token: 0x020009AF RID: 2479
	[Token(Token = "0x20009AF")]
	[Serializable]
	public class ToleranceSphereJson
	{
		// Token: 0x0600352C RID: 13612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600352C")]
		[Address(RVA = "0xD692A0", Offset = "0xD682A0", VA = "0x180D692A0")]
		public ToleranceSphereJson(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600352D")]
		[Address(RVA = "0xD692D0", Offset = "0xD682D0", VA = "0x180D692D0")]
		public ToleranceSphereJson(ToleranceSphere toleranceSphere)
		{
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600352E")]
		[Address(RVA = "0xD692A0", Offset = "0xD682A0", VA = "0x180D692A0")]
		public void SetProperties(Vector3 worldPosition, float diameter, Color color, float preservationStrength, bool isHidden = false)
		{
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600352F")]
		[Address(RVA = "0xD694E0", Offset = "0xD684E0", VA = "0x180D694E0")]
		public void DumpFromToleranceSphere(ToleranceSphere toleranceSphere)
		{
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003530")]
		[Address(RVA = "0xD69610", Offset = "0xD68610", VA = "0x180D69610")]
		public void DumpToToleranceSphere(ref ToleranceSphere toleranceSphere)
		{
		}

		// Token: 0x040051E8 RID: 20968
		[Token(Token = "0x40051E8")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 worldPosition;

		// Token: 0x040051E9 RID: 20969
		[Token(Token = "0x40051E9")]
		[FieldOffset(Offset = "0x1C")]
		public float diameter;

		// Token: 0x040051EA RID: 20970
		[Token(Token = "0x40051EA")]
		[FieldOffset(Offset = "0x20")]
		public Color color;

		// Token: 0x040051EB RID: 20971
		[Token(Token = "0x40051EB")]
		[FieldOffset(Offset = "0x30")]
		public float preservationStrength;

		// Token: 0x040051EC RID: 20972
		[Token(Token = "0x40051EC")]
		[FieldOffset(Offset = "0x34")]
		public bool isHidden;
	}
}
