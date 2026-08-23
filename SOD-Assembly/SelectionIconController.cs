using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005B5 RID: 1461
[Token(Token = "0x20005B5")]
public class SelectionIconController : MonoBehaviour
{
	// Token: 0x06002028 RID: 8232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002028")]
	[Address(RVA = "0xAD2A70", Offset = "0xAD1A70", VA = "0x180AD2A70")]
	public void Setup(Interactable newInteractable)
	{
	}

	// Token: 0x06002029 RID: 8233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002029")]
	[Address(RVA = "0xAD2C70", Offset = "0xAD1C70", VA = "0x180AD2C70")]
	private void Update()
	{
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600202A")]
	[Address(RVA = "0xAD30C0", Offset = "0xAD20C0", VA = "0x180AD30C0")]
	public void Remove()
	{
	}

	// Token: 0x0600202B RID: 8235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600202B")]
	[Address(RVA = "0xAD30D0", Offset = "0xAD20D0", VA = "0x180AD30D0")]
	public void SetHighlighted(bool val)
	{
	}

	// Token: 0x0600202C RID: 8236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600202C")]
	[Address(RVA = "0xAD30E0", Offset = "0xAD20E0", VA = "0x180AD30E0")]
	public SelectionIconController()
	{
	}

	// Token: 0x040029AC RID: 10668
	[Token(Token = "0x40029AC")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x040029AD RID: 10669
	[Token(Token = "0x40029AD")]
	[FieldOffset(Offset = "0x20")]
	public CanvasRenderer rend;

	// Token: 0x040029AE RID: 10670
	[Token(Token = "0x40029AE")]
	[FieldOffset(Offset = "0x28")]
	public Image image;

	// Token: 0x040029AF RID: 10671
	[Token(Token = "0x40029AF")]
	[FieldOffset(Offset = "0x30")]
	public bool highlighted;

	// Token: 0x040029B0 RID: 10672
	[Token(Token = "0x40029B0")]
	[FieldOffset(Offset = "0x31")]
	public bool fadeIn;

	// Token: 0x040029B1 RID: 10673
	[Token(Token = "0x40029B1")]
	[FieldOffset(Offset = "0x32")]
	public bool destroy;

	// Token: 0x040029B2 RID: 10674
	[Token(Token = "0x40029B2")]
	[FieldOffset(Offset = "0x34")]
	public float alpha;

	// Token: 0x040029B3 RID: 10675
	[Token(Token = "0x40029B3")]
	[FieldOffset(Offset = "0x38")]
	public Interactable interactable;

	// Token: 0x040029B4 RID: 10676
	[Token(Token = "0x40029B4")]
	[FieldOffset(Offset = "0x40")]
	public float highlightProgress;

	// Token: 0x040029B5 RID: 10677
	[Token(Token = "0x40029B5")]
	[FieldOffset(Offset = "0x44")]
	public Color highlightedColor;

	// Token: 0x040029B6 RID: 10678
	[Token(Token = "0x40029B6")]
	[FieldOffset(Offset = "0x54")]
	public Color unHighlightedColor;
}
