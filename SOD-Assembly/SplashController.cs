using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005C6 RID: 1478
[Token(Token = "0x20005C6")]
public class SplashController : MonoBehaviour
{
	// Token: 0x06002080 RID: 8320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002080")]
	[Address(RVA = "0xADCF60", Offset = "0xADBF60", VA = "0x180ADCF60")]
	private void Awake()
	{
	}

	// Token: 0x06002081 RID: 8321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002081")]
	[Address(RVA = "0xADD170", Offset = "0xADC170", VA = "0x180ADD170")]
	private void Update()
	{
	}

	// Token: 0x06002082 RID: 8322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002082")]
	[Address(RVA = "0xADD510", Offset = "0xADC510", VA = "0x180ADD510")]
	public SplashController()
	{
	}

	// Token: 0x04002A13 RID: 10771
	[Token(Token = "0x4002A13")]
	[FieldOffset(Offset = "0x18")]
	public Image blackBG;

	// Token: 0x04002A14 RID: 10772
	[Token(Token = "0x4002A14")]
	[FieldOffset(Offset = "0x20")]
	public List<SplashController.SplashImage> splashes;

	// Token: 0x04002A15 RID: 10773
	[Token(Token = "0x4002A15")]
	[FieldOffset(Offset = "0x28")]
	public float progress;

	// Token: 0x04002A16 RID: 10774
	[Token(Token = "0x4002A16")]
	[FieldOffset(Offset = "0x2C")]
	public int splash;

	// Token: 0x04002A17 RID: 10775
	[Token(Token = "0x4002A17")]
	[FieldOffset(Offset = "0x30")]
	public float fadeOutTime;

	// Token: 0x04002A18 RID: 10776
	[Token(Token = "0x4002A18")]
	[FieldOffset(Offset = "0x34")]
	public bool fadeOut;

	// Token: 0x04002A19 RID: 10777
	[Token(Token = "0x4002A19")]
	[FieldOffset(Offset = "0x38")]
	public float fadeProg;

	// Token: 0x020005C7 RID: 1479
	[Token(Token = "0x20005C7")]
	[Serializable]
	public class SplashImage
	{
		// Token: 0x06002083 RID: 8323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002083")]
		[Address(RVA = "0xADD620", Offset = "0xADC620", VA = "0x180ADD620")]
		public SplashImage()
		{
		}

		// Token: 0x04002A1A RID: 10778
		[Token(Token = "0x4002A1A")]
		[FieldOffset(Offset = "0x10")]
		public RectTransform rect;

		// Token: 0x04002A1B RID: 10779
		[Token(Token = "0x4002A1B")]
		[FieldOffset(Offset = "0x18")]
		public CanvasRenderer rend;

		// Token: 0x04002A1C RID: 10780
		[Token(Token = "0x4002A1C")]
		[FieldOffset(Offset = "0x20")]
		public float displayTime;
	}
}
