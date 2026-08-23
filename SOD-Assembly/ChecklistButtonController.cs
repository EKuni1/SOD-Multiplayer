using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000569 RID: 1385
[Token(Token = "0x2000569")]
public class ChecklistButtonController : ButtonController
{
	// Token: 0x06001E2C RID: 7724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E2C")]
	[Address(RVA = "0xA46B60", Offset = "0xA45B60", VA = "0x180A46B60")]
	public void Setup(Objective newObjective)
	{
	}

	// Token: 0x06001E2D RID: 7725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E2D")]
	[Address(RVA = "0xA47060", Offset = "0xA46060", VA = "0x180A47060")]
	public void OnObjectiveProgressChange()
	{
	}

	// Token: 0x06001E2E RID: 7726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E2E")]
	[Address(RVA = "0xA47720", Offset = "0xA46720", VA = "0x180A47720")]
	public void OnComplete()
	{
	}

	// Token: 0x06001E2F RID: 7727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E2F")]
	[Address(RVA = "0xA47720", Offset = "0xA46720", VA = "0x180A47720")]
	public void Remove()
	{
	}

	// Token: 0x06001E30 RID: 7728 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E30")]
	[Address(RVA = "0xA47730", Offset = "0xA46730", VA = "0x180A47730")]
	public ChecklistButtonController()
	{
	}

	// Token: 0x040026A8 RID: 9896
	[Token(Token = "0x40026A8")]
	[FieldOffset(Offset = "0x1A8")]
	public Objective objective;

	// Token: 0x040026A9 RID: 9897
	[Token(Token = "0x40026A9")]
	[FieldOffset(Offset = "0x1B0")]
	public CanvasRenderer bgRend;

	// Token: 0x040026AA RID: 9898
	[Token(Token = "0x40026AA")]
	[FieldOffset(Offset = "0x1B8")]
	public CanvasRenderer textRend;

	// Token: 0x040026AB RID: 9899
	[Token(Token = "0x40026AB")]
	[FieldOffset(Offset = "0x1C0")]
	public CanvasRenderer progressBGrend;

	// Token: 0x040026AC RID: 9900
	[Token(Token = "0x40026AC")]
	[FieldOffset(Offset = "0x1C8")]
	public CanvasRenderer barRend;

	// Token: 0x040026AD RID: 9901
	[Token(Token = "0x40026AD")]
	[FieldOffset(Offset = "0x1D0")]
	public CanvasRenderer iconRend;

	// Token: 0x040026AE RID: 9902
	[Token(Token = "0x40026AE")]
	[FieldOffset(Offset = "0x1D8")]
	public float fadeInProgress;

	// Token: 0x040026AF RID: 9903
	[Token(Token = "0x40026AF")]
	[FieldOffset(Offset = "0x1DC")]
	public bool fadeOut;

	// Token: 0x040026B0 RID: 9904
	[Token(Token = "0x40026B0")]
	[FieldOffset(Offset = "0x1E0")]
	public float strikeThroughProgress;

	// Token: 0x040026B1 RID: 9905
	[Token(Token = "0x40026B1")]
	[FieldOffset(Offset = "0x1E4")]
	public Vector2 desiredAnchoredPosition;

	// Token: 0x040026B2 RID: 9906
	[Token(Token = "0x40026B2")]
	[FieldOffset(Offset = "0x1F0")]
	public Sprite checkedSprite;

	// Token: 0x040026B3 RID: 9907
	[Token(Token = "0x40026B3")]
	[FieldOffset(Offset = "0x1F8")]
	public RectTransform progressRect;

	// Token: 0x040026B4 RID: 9908
	[Token(Token = "0x40026B4")]
	[FieldOffset(Offset = "0x200")]
	public FlashController flash;

	// Token: 0x040026B5 RID: 9909
	[Token(Token = "0x40026B5")]
	[FieldOffset(Offset = "0x208")]
	public List<CanvasRenderer> childRendereres;
}
