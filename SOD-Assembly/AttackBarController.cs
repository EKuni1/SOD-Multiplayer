using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005B2 RID: 1458
[Token(Token = "0x20005B2")]
public class AttackBarController : MonoBehaviour
{
	// Token: 0x0600201E RID: 8222 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600201E")]
	[Address(RVA = "0xACEA00", Offset = "0xACDA00", VA = "0x180ACEA00")]
	public void Setup(NewAIController newAi)
	{
	}

	// Token: 0x0600201F RID: 8223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600201F")]
	[Address(RVA = "0xACEEF0", Offset = "0xACDEF0", VA = "0x180ACEEF0")]
	private void Update()
	{
	}

	// Token: 0x06002020 RID: 8224 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002020")]
	[Address(RVA = "0xAD0880", Offset = "0xACF880", VA = "0x180AD0880")]
	public AttackBarController()
	{
	}

	// Token: 0x04002982 RID: 10626
	[Token(Token = "0x4002982")]
	[FieldOffset(Offset = "0x18")]
	public NewAIController ai;

	// Token: 0x04002983 RID: 10627
	[Token(Token = "0x4002983")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform rect;

	// Token: 0x04002984 RID: 10628
	[Token(Token = "0x4002984")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform barAnchor;

	// Token: 0x04002985 RID: 10629
	[Token(Token = "0x4002985")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform attackProgress;

	// Token: 0x04002986 RID: 10630
	[Token(Token = "0x4002986")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform blockPoint;

	// Token: 0x04002987 RID: 10631
	[Token(Token = "0x4002987")]
	[FieldOffset(Offset = "0x40")]
	public RectTransform perfectBlockPoint;

	// Token: 0x04002988 RID: 10632
	[Token(Token = "0x4002988")]
	[FieldOffset(Offset = "0x48")]
	public float barProgress;

	// Token: 0x04002989 RID: 10633
	[Token(Token = "0x4002989")]
	[FieldOffset(Offset = "0x4C")]
	public bool displayOnScreen;

	// Token: 0x0400298A RID: 10634
	[Token(Token = "0x400298A")]
	[FieldOffset(Offset = "0x50")]
	public float distance;

	// Token: 0x0400298B RID: 10635
	[Token(Token = "0x400298B")]
	[FieldOffset(Offset = "0x58")]
	public List<CanvasRenderer> allGraphics;

	// Token: 0x0400298C RID: 10636
	[Token(Token = "0x400298C")]
	[FieldOffset(Offset = "0x60")]
	public List<CanvasRenderer> backgroundGraphics;

	// Token: 0x0400298D RID: 10637
	[Token(Token = "0x400298D")]
	[FieldOffset(Offset = "0x68")]
	public List<CanvasRenderer> blockGraphics;

	// Token: 0x0400298E RID: 10638
	[Token(Token = "0x400298E")]
	[FieldOffset(Offset = "0x70")]
	public List<CanvasRenderer> hitGraphics;

	// Token: 0x0400298F RID: 10639
	[Token(Token = "0x400298F")]
	[FieldOffset(Offset = "0x78")]
	public float removalProgress;

	// Token: 0x04002990 RID: 10640
	[Token(Token = "0x4002990")]
	[FieldOffset(Offset = "0x7C")]
	public bool removeHit;

	// Token: 0x04002991 RID: 10641
	[Token(Token = "0x4002991")]
	[FieldOffset(Offset = "0x7D")]
	public bool removeBlocked;

	// Token: 0x04002992 RID: 10642
	[Token(Token = "0x4002992")]
	[FieldOffset(Offset = "0x7E")]
	public bool removeAbort;

	// Token: 0x04002993 RID: 10643
	[Token(Token = "0x4002993")]
	[FieldOffset(Offset = "0x80")]
	public float abortProgress;
}
