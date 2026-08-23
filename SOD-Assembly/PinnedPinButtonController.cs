using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000562 RID: 1378
[Token(Token = "0x2000562")]
public class PinnedPinButtonController : ButtonController, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x06001DF0 RID: 7664 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DF0")]
	[Address(RVA = "0xA3E8F0", Offset = "0xA3D8F0", VA = "0x180A3E8F0")]
	public void Setup(PinnedItemController newItem)
	{
	}

	// Token: 0x06001DF1 RID: 7665 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DF1")]
	[Address(RVA = "0xA3E990", Offset = "0xA3D990", VA = "0x180A3E990")]
	public void UpdatePinColour()
	{
	}

	// Token: 0x06001DF2 RID: 7666 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DF2")]
	[Address(RVA = "0x72C200", Offset = "0x72B200", VA = "0x18072C200")]
	private void OnEnable()
	{
	}

	// Token: 0x06001DF3 RID: 7667 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DF3")]
	[Address(RVA = "0xA3EAE0", Offset = "0xA3DAE0", VA = "0x180A3EAE0", Slot = "17")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x06001DF4 RID: 7668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DF4")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "19")]
	public override void OnLeftDoubleClick()
	{
	}

	// Token: 0x06001DF5 RID: 7669 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DF5")]
	[Address(RVA = "0xA2C450", Offset = "0xA2B450", VA = "0x180A2C450")]
	public PinnedPinButtonController()
	{
	}

	// Token: 0x04002679 RID: 9849
	[Token(Token = "0x4002679")]
	[FieldOffset(Offset = "0x1A8")]
	public Image mainColour;

	// Token: 0x0400267A RID: 9850
	[Token(Token = "0x400267A")]
	[FieldOffset(Offset = "0x1B0")]
	public Image mainOverlay;

	// Token: 0x0400267B RID: 9851
	[Token(Token = "0x400267B")]
	[FieldOffset(Offset = "0x1B8")]
	public Image pressedColour;

	// Token: 0x0400267C RID: 9852
	[Token(Token = "0x400267C")]
	[FieldOffset(Offset = "0x1C0")]
	public Image pressedOverlay;

	// Token: 0x0400267D RID: 9853
	[Token(Token = "0x400267D")]
	[FieldOffset(Offset = "0x1C8")]
	public RectTransform mainMOOverlay;

	// Token: 0x0400267E RID: 9854
	[Token(Token = "0x400267E")]
	[FieldOffset(Offset = "0x1D0")]
	public Sprite pinnedOverlay;

	// Token: 0x0400267F RID: 9855
	[Token(Token = "0x400267F")]
	[FieldOffset(Offset = "0x1D8")]
	public Sprite pinnedOverlayMO;

	// Token: 0x04002680 RID: 9856
	[Token(Token = "0x4002680")]
	[FieldOffset(Offset = "0x1E0")]
	public PinnedItemController pinnedController;
}
