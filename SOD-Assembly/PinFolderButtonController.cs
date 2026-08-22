using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200061A RID: 1562
[Token(Token = "0x200061A")]
public class PinFolderButtonController : ButtonController, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x0600224A RID: 8778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600224A")]
	[Address(RVA = "0x72C200", Offset = "0x72B200", VA = "0x18072C200")]
	private void Start()
	{
	}

	// Token: 0x0600224B RID: 8779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600224B")]
	[Address(RVA = "0xB2C160", Offset = "0xB2B160", VA = "0x180B2C160", Slot = "15")]
	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	// Token: 0x0600224C RID: 8780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600224C")]
	[Address(RVA = "0xB2CB70", Offset = "0xB2BB70", VA = "0x180B2CB70")]
	public void OnCreateNewCasePopup()
	{
	}

	// Token: 0x0600224D RID: 8781 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600224D")]
	[Address(RVA = "0xB2CD10", Offset = "0xB2BD10", VA = "0x180B2CD10")]
	public void onCreateNewCasePopupCancel()
	{
	}

	// Token: 0x0600224E RID: 8782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600224E")]
	[Address(RVA = "0xB2CE70", Offset = "0xB2BE70", VA = "0x180B2CE70", Slot = "16")]
	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	// Token: 0x0600224F RID: 8783 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600224F")]
	[Address(RVA = "0xB2CF40", Offset = "0xB2BF40", VA = "0x180B2CF40")]
	public void ForcePointerUp()
	{
	}

	// Token: 0x06002250 RID: 8784 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002250")]
	[Address(RVA = "0xB2D3E0", Offset = "0xB2C3E0", VA = "0x180B2D3E0")]
	private IEnumerator PlacementFade()
	{
		return null;
	}

	// Token: 0x06002251 RID: 8785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002251")]
	[Address(RVA = "0xB2D480", Offset = "0xB2C480", VA = "0x180B2D480", Slot = "17")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x06002252 RID: 8786 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002252")]
	[Address(RVA = "0xB2D620", Offset = "0xB2C620", VA = "0x180B2D620", Slot = "25")]
	public override void OnHoverStart()
	{
	}

	// Token: 0x06002253 RID: 8787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002253")]
	[Address(RVA = "0xB2D620", Offset = "0xB2C620", VA = "0x180B2D620", Slot = "26")]
	public override void OnHoverEnd()
	{
	}

	// Token: 0x06002254 RID: 8788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002254")]
	[Address(RVA = "0xB2D640", Offset = "0xB2C640", VA = "0x180B2D640", Slot = "10")]
	public override void VisualUpdate()
	{
	}

	// Token: 0x06002255 RID: 8789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002255")]
	[Address(RVA = "0xA2C450", Offset = "0xA2B450", VA = "0x180A2C450")]
	public PinFolderButtonController()
	{
	}

	// Token: 0x04002BED RID: 11245
	[Token(Token = "0x4002BED")]
	[FieldOffset(Offset = "0x1A8")]
	public Sprite pinnedImage;

	// Token: 0x04002BEE RID: 11246
	[Token(Token = "0x4002BEE")]
	[FieldOffset(Offset = "0x1B0")]
	public Sprite pinnedMO;

	// Token: 0x04002BEF RID: 11247
	[Token(Token = "0x4002BEF")]
	[FieldOffset(Offset = "0x1B8")]
	public Sprite unpinnedImage;

	// Token: 0x04002BF0 RID: 11248
	[Token(Token = "0x4002BF0")]
	[FieldOffset(Offset = "0x1C0")]
	public Sprite unpinnedMO;

	// Token: 0x04002BF1 RID: 11249
	[Token(Token = "0x4002BF1")]
	[FieldOffset(Offset = "0x1C8")]
	public Sprite pinnedColour;

	// Token: 0x04002BF2 RID: 11250
	[Token(Token = "0x4002BF2")]
	[FieldOffset(Offset = "0x1D0")]
	public Sprite unpinnedColour;

	// Token: 0x04002BF3 RID: 11251
	[Token(Token = "0x4002BF3")]
	[FieldOffset(Offset = "0x1D8")]
	public ContextMenuController contextMenu;

	// Token: 0x04002BF4 RID: 11252
	[Token(Token = "0x4002BF4")]
	[FieldOffset(Offset = "0x1E0")]
	public bool placementActive;

	// Token: 0x04002BF5 RID: 11253
	[Token(Token = "0x4002BF5")]
	[FieldOffset(Offset = "0x1E1")]
	public bool pointerDown;

	// Token: 0x0200061B RID: 1563
	[Token(Token = "0x200061B")]
	private sealed class <PlacementFade>d__15 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06002256 RID: 8790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002256")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <PlacementFade>d__15(int <>1__state)
		{
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002257")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x0000E268 File Offset: 0x0000C468
		[Token(Token = "0x6002258")]
		[Address(RVA = "0xB2DA70", Offset = "0xB2CA70", VA = "0x180B2DA70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700011E")]
		private object Current
		{
			[Token(Token = "0x6002259")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600225A")]
		[Address(RVA = "0xB2E1B0", Offset = "0xB2D1B0", VA = "0x180B2E1B0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700011F")]
		private object Current
		{
			[Token(Token = "0x600225B")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002BF6 RID: 11254
		[Token(Token = "0x4002BF6")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002BF7 RID: 11255
		[Token(Token = "0x4002BF7")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002BF8 RID: 11256
		[Token(Token = "0x4002BF8")]
		[FieldOffset(Offset = "0x20")]
		public PinFolderButtonController <>4__this;
	}
}
