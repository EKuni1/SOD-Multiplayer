using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200090F RID: 2319
	[Token(Token = "0x200090F")]
	public class CanvasScalerFitter : MonoBehaviour
	{
		// Token: 0x06002ECF RID: 11983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECF")]
		[Address(RVA = "0xCF5780", Offset = "0xCF4780", VA = "0x180CF5780")]
		private void OnEnable()
		{
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED0")]
		[Address(RVA = "0xCF5950", Offset = "0xCF4950", VA = "0x180CF5950")]
		private void Update()
		{
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED1")]
		[Address(RVA = "0xCF5A80", Offset = "0xCF4A80", VA = "0x180CF5A80")]
		private void UpdateSize()
		{
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED2")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public CanvasScalerFitter()
		{
		}

		// Token: 0x04004DE1 RID: 19937
		[Token(Token = "0x4004DE1")]
		[FieldOffset(Offset = "0x18")]
		private CanvasScalerFitter.BreakPoint[] breakPoints;

		// Token: 0x04004DE2 RID: 19938
		[Token(Token = "0x4004DE2")]
		[FieldOffset(Offset = "0x20")]
		private CanvasScalerExt canvasScaler;

		// Token: 0x04004DE3 RID: 19939
		[Token(Token = "0x4004DE3")]
		[FieldOffset(Offset = "0x28")]
		private int screenWidth;

		// Token: 0x04004DE4 RID: 19940
		[Token(Token = "0x4004DE4")]
		[FieldOffset(Offset = "0x2C")]
		private int screenHeight;

		// Token: 0x04004DE5 RID: 19941
		[Token(Token = "0x4004DE5")]
		[FieldOffset(Offset = "0x30")]
		private Action ScreenSizeChanged;

		// Token: 0x02000910 RID: 2320
		[Token(Token = "0x2000910")]
		[Serializable]
		private class BreakPoint
		{
			// Token: 0x06002ED3 RID: 11987 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002ED3")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public BreakPoint()
			{
			}

			// Token: 0x04004DE6 RID: 19942
			[Token(Token = "0x4004DE6")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04004DE7 RID: 19943
			[Token(Token = "0x4004DE7")]
			[FieldOffset(Offset = "0x18")]
			public float screenAspectRatio;

			// Token: 0x04004DE8 RID: 19944
			[Token(Token = "0x4004DE8")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 referenceResolution;
		}
	}
}
