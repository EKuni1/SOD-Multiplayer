using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020005F1 RID: 1521
[Token(Token = "0x20005F1")]
public class EvidenceButtonController : ButtonController, IEnumerator<object>, IDisposable
{
	// Token: 0x06002148 RID: 8520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002148")]
	[Address(RVA = "0xAFE8F0", Offset = "0xAFD8F0", VA = "0x180AFE8F0", Slot = "30")]
	public virtual void Setup(Evidence newEvidence, List<Evidence.DataKey> newKeys, PinnedItemController newController)
	{
	}

	// Token: 0x06002149 RID: 8521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002149")]
	[Address(RVA = "0xAFEC70", Offset = "0xAFDC70", VA = "0x180AFEC70")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600214A RID: 8522 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600214A")]
	[Address(RVA = "0xAFEF00", Offset = "0xAFDF00", VA = "0x180AFEF00")]
	private void OnEnable()
	{
	}

	// Token: 0x0600214B RID: 8523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600214B")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "31")]
	public virtual void ExtraSetup()
	{
	}

	// Token: 0x0600214C RID: 8524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600214C")]
	[Address(RVA = "0xAFF120", Offset = "0xAFE120", VA = "0x180AFF120", Slot = "17")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x0600214D RID: 8525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600214D")]
	[Address(RVA = "0xAFF670", Offset = "0xAFE670", VA = "0x180AFF670", Slot = "25")]
	public override void OnHoverStart()
	{
	}

	// Token: 0x0600214E RID: 8526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600214E")]
	[Address(RVA = "0xAFF880", Offset = "0xAFE880", VA = "0x180AFF880", Slot = "15")]
	public override void OnPointerDown(PointerEventData data)
	{
	}

	// Token: 0x0600214F RID: 8527 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600214F")]
	[Address(RVA = "0xAFF8E0", Offset = "0xAFE8E0", VA = "0x180AFF8E0", Slot = "10")]
	public override void VisualUpdate()
	{
	}

	// Token: 0x06002150 RID: 8528 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002150")]
	[Address(RVA = "0xB001D0", Offset = "0xAFF1D0", VA = "0x180B001D0", Slot = "12")]
	public override void UpdateTooltipText()
	{
	}

	// Token: 0x06002151 RID: 8529 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002151")]
	[Address(RVA = "0xB00320", Offset = "0xAFF320", VA = "0x180B00320", Slot = "29")]
	public override void RefreshAutomaticNavigation(bool enableLeft, bool enableRight, bool enableUp, bool enableDown, bool includeInactive)
	{
	}

	// Token: 0x06002152 RID: 8530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002152")]
	[Address(RVA = "0xA2C450", Offset = "0xA2B450", VA = "0x180A2C450")]
	public EvidenceButtonController()
	{
	}

	// Token: 0x04002B02 RID: 11010
	[Token(Token = "0x4002B02")]
	[FieldOffset(Offset = "0x1A8")]
	public PinnedItemController pinnedController;

	// Token: 0x04002B03 RID: 11011
	[Token(Token = "0x4002B03")]
	[FieldOffset(Offset = "0x1B0")]
	public Evidence evidence;

	// Token: 0x04002B04 RID: 11012
	[Token(Token = "0x4002B04")]
	[FieldOffset(Offset = "0x1B8")]
	public List<Evidence.DataKey> evidenceKeys;

	// Token: 0x04002B05 RID: 11013
	[Token(Token = "0x4002B05")]
	[FieldOffset(Offset = "0x1C0")]
	public RawImage evPhoto;
}
