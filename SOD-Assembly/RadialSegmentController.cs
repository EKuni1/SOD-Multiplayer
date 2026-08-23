using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000337 RID: 823
[Token(Token = "0x2000337")]
public class RadialSegmentController : MonoBehaviour
{
	// Token: 0x06001286 RID: 4742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001286")]
	[Address(RVA = "0x70DF60", Offset = "0x70CF60", VA = "0x18070DF60")]
	public void UpdateSegment(FirstPersonItemController.InventorySlot newSlot)
	{
	}

	// Token: 0x06001287 RID: 4743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001287")]
	[Address(RVA = "0x70E150", Offset = "0x70D150", VA = "0x18070E150")]
	public void OnUpdateContent()
	{
	}

	// Token: 0x06001288 RID: 4744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001288")]
	[Address(RVA = "0x70E9C0", Offset = "0x70D9C0", VA = "0x18070E9C0")]
	public RadialSegmentController()
	{
	}

	// Token: 0x04001715 RID: 5909
	[Token(Token = "0x4001715")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04001716 RID: 5910
	[Token(Token = "0x4001716")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform segmentLineRect;

	// Token: 0x04001717 RID: 5911
	[Token(Token = "0x4001717")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform elementLineRect;

	// Token: 0x04001718 RID: 5912
	[Token(Token = "0x4001718")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform elementRect;

	// Token: 0x04001719 RID: 5913
	[Token(Token = "0x4001719")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform stolenIcon;

	// Token: 0x0400171A RID: 5914
	[Token(Token = "0x400171A")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI text;

	// Token: 0x0400171B RID: 5915
	[Token(Token = "0x400171B")]
	[FieldOffset(Offset = "0x48")]
	public Image img;

	// Token: 0x0400171C RID: 5916
	[Token(Token = "0x400171C")]
	[FieldOffset(Offset = "0x50")]
	public List<CanvasRenderer> renderers;

	// Token: 0x0400171D RID: 5917
	[Token(Token = "0x400171D")]
	[FieldOffset(Offset = "0x58")]
	public FirstPersonItemController.InventorySlot slot;

	// Token: 0x0400171E RID: 5918
	[Token(Token = "0x400171E")]
	[FieldOffset(Offset = "0x60")]
	public float segmentAngleSpace;

	// Token: 0x0400171F RID: 5919
	[Token(Token = "0x400171F")]
	[FieldOffset(Offset = "0x64")]
	public float angle;

	// Token: 0x04001720 RID: 5920
	[Token(Token = "0x4001720")]
	[FieldOffset(Offset = "0x68")]
	public float toAngle;

	// Token: 0x02000338 RID: 824
	[Token(Token = "0x2000338")]
	private sealed class <>c__DisplayClass13_0
	{
		// Token: 0x06001289 RID: 4745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001289")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass13_0()
		{
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00008D18 File Offset: 0x00006F18
		[Token(Token = "0x600128A")]
		[Address(RVA = "0x70EAC0", Offset = "0x70DAC0", VA = "0x18070EAC0")]
		internal bool <OnUpdateContent>b__2(StatusController.FineRecord item)
		{
			return default(bool);
		}

		// Token: 0x04001721 RID: 5921
		[Token(Token = "0x4001721")]
		[FieldOffset(Offset = "0x10")]
		public Interactable slotInteractable;
	}

	// Token: 0x02000339 RID: 825
	[Token(Token = "0x2000339")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600128C RID: 4748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00008D30 File Offset: 0x00006F30
		[Token(Token = "0x600128D")]
		[Address(RVA = "0x70EBB0", Offset = "0x70DBB0", VA = "0x18070EBB0")]
		internal bool <OnUpdateContent>b__13_0(InterfaceControls.IconConfig item)
		{
			return default(bool);
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00008D48 File Offset: 0x00006F48
		[Token(Token = "0x600128E")]
		[Address(RVA = "0x57B220", Offset = "0x57A220", VA = "0x18057B220")]
		internal bool <OnUpdateContent>b__13_1(InterfaceControls.IconConfig item)
		{
			return default(bool);
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00008D60 File Offset: 0x00006F60
		[Token(Token = "0x600128F")]
		[Address(RVA = "0x70EBB0", Offset = "0x70DBB0", VA = "0x18070EBB0")]
		internal bool <OnUpdateContent>b__13_3(InterfaceControls.IconConfig item)
		{
			return default(bool);
		}

		// Token: 0x04001722 RID: 5922
		[Token(Token = "0x4001722")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RadialSegmentController.<>c <>9;

		// Token: 0x04001723 RID: 5923
		[Token(Token = "0x4001723")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<InterfaceControls.IconConfig> <>9__13_0;

		// Token: 0x04001724 RID: 5924
		[Token(Token = "0x4001724")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<InterfaceControls.IconConfig> <>9__13_1;

		// Token: 0x04001725 RID: 5925
		[Token(Token = "0x4001725")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<InterfaceControls.IconConfig> <>9__13_3;
	}
}
