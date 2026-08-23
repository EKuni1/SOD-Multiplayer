using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005B3 RID: 1459
[Token(Token = "0x20005B3")]
public class HUDCrosshairReactionController : MonoBehaviour
{
	// Token: 0x06002021 RID: 8225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002021")]
	[Address(RVA = "0xAD0B00", Offset = "0xACFB00", VA = "0x180AD0B00")]
	private void Awake()
	{
	}

	// Token: 0x06002022 RID: 8226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002022")]
	[Address(RVA = "0xAD0B30", Offset = "0xACFB30", VA = "0x180AD0B30")]
	private void Update()
	{
	}

	// Token: 0x06002023 RID: 8227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002023")]
	[Address(RVA = "0xAD0DC0", Offset = "0xACFDC0", VA = "0x180AD0DC0")]
	public HUDCrosshairReactionController()
	{
	}

	// Token: 0x04002994 RID: 10644
	[Token(Token = "0x4002994")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002995 RID: 10645
	[Token(Token = "0x4002995")]
	[FieldOffset(Offset = "0x20")]
	public Image img;

	// Token: 0x04002996 RID: 10646
	[Token(Token = "0x4002996")]
	[FieldOffset(Offset = "0x28")]
	public float progress;

	// Token: 0x04002997 RID: 10647
	[Token(Token = "0x4002997")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve curve;

	// Token: 0x04002998 RID: 10648
	[Token(Token = "0x4002998")]
	[FieldOffset(Offset = "0x38")]
	public float maxSize;

	// Token: 0x04002999 RID: 10649
	[Token(Token = "0x4002999")]
	[FieldOffset(Offset = "0x40")]
	public CanvasRenderer rend;
}
