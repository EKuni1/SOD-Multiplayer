using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005A7 RID: 1447
[Token(Token = "0x20005A7")]
public class LockpickProgressController : MonoBehaviour
{
	// Token: 0x06001F8D RID: 8077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F8D")]
	[Address(RVA = "0xA7D040", Offset = "0xA7C040", VA = "0x180A7D040")]
	public void SetBarMax(float val)
	{
	}

	// Token: 0x06001F8E RID: 8078 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F8E")]
	[Address(RVA = "0xA7D050", Offset = "0xA7C050", VA = "0x180A7D050")]
	public void SetAmount(float val)
	{
	}

	// Token: 0x06001F8F RID: 8079 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F8F")]
	[Address(RVA = "0xA7D1D0", Offset = "0xA7C1D0", VA = "0x180A7D1D0")]
	public void UpdateBar()
	{
	}

	// Token: 0x06001F90 RID: 8080 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F90")]
	[Address(RVA = "0xA7D360", Offset = "0xA7C360", VA = "0x180A7D360")]
	public LockpickProgressController()
	{
	}

	// Token: 0x040028C8 RID: 10440
	[Token(Token = "0x40028C8")]
	[FieldOffset(Offset = "0x18")]
	public float amount;

	// Token: 0x040028C9 RID: 10441
	[Token(Token = "0x40028C9")]
	[FieldOffset(Offset = "0x1C")]
	public float barMax;

	// Token: 0x040028CA RID: 10442
	[Token(Token = "0x40028CA")]
	[FieldOffset(Offset = "0x20")]
	public float progress;

	// Token: 0x040028CB RID: 10443
	[Token(Token = "0x40028CB")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform rect;

	// Token: 0x040028CC RID: 10444
	[Token(Token = "0x40028CC")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform bar;

	// Token: 0x040028CD RID: 10445
	[Token(Token = "0x40028CD")]
	[FieldOffset(Offset = "0x38")]
	public JuiceController juice;

	// Token: 0x040028CE RID: 10446
	[Token(Token = "0x40028CE")]
	[FieldOffset(Offset = "0x40")]
	public Color depletedColor;

	// Token: 0x040028CF RID: 10447
	[Token(Token = "0x40028CF")]
	[FieldOffset(Offset = "0x50")]
	private bool completed;
}
