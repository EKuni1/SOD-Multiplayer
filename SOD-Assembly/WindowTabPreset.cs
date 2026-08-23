using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020008A5 RID: 2213
[Token(Token = "0x20008A5")]
public class WindowTabPreset : SoCustomComparison
{
	// Token: 0x06002A0C RID: 10764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A0C")]
	[Address(RVA = "0xCB4B50", Offset = "0xCB3B50", VA = "0x180CB4B50")]
	public WindowTabPreset()
	{
	}

	// Token: 0x04004476 RID: 17526
	[Token(Token = "0x4004476")]
	[FieldOffset(Offset = "0x20")]
	public string tabName;

	// Token: 0x04004477 RID: 17527
	[Token(Token = "0x4004477")]
	[FieldOffset(Offset = "0x28")]
	public Color colour;

	// Token: 0x04004478 RID: 17528
	[Token(Token = "0x4004478")]
	[FieldOffset(Offset = "0x38")]
	public GameObject contentPrefab;

	// Token: 0x04004479 RID: 17529
	[Token(Token = "0x4004479")]
	[FieldOffset(Offset = "0x40")]
	public WindowTabPreset.TabContentType contentType;

	// Token: 0x0400447A RID: 17530
	[Token(Token = "0x400447A")]
	[FieldOffset(Offset = "0x44")]
	public bool scalableContent;

	// Token: 0x0400447B RID: 17531
	[Token(Token = "0x400447B")]
	[FieldOffset(Offset = "0x45")]
	public bool fitToScaleX;

	// Token: 0x0400447C RID: 17532
	[Token(Token = "0x400447C")]
	[FieldOffset(Offset = "0x46")]
	public bool fitToScaleY;

	// Token: 0x0400447D RID: 17533
	[Token(Token = "0x400447D")]
	[FieldOffset(Offset = "0x47")]
	public bool zoomWithMouseWheel;

	// Token: 0x0400447E RID: 17534
	[Token(Token = "0x400447E")]
	[FieldOffset(Offset = "0x48")]
	public bool scrollBars;

	// Token: 0x0400447F RID: 17535
	[Token(Token = "0x400447F")]
	[FieldOffset(Offset = "0x4C")]
	public ScrollRect.MovementType scrollRestrcition;

	// Token: 0x04004480 RID: 17536
	[Token(Token = "0x4004480")]
	[FieldOffset(Offset = "0x50")]
	public string displayContentWithTag;

	// Token: 0x020008A6 RID: 2214
	[Token(Token = "0x20008A6")]
	public enum TabContentType
	{
		// Token: 0x04004482 RID: 17538
		[Token(Token = "0x4004482")]
		generated,
		// Token: 0x04004483 RID: 17539
		[Token(Token = "0x4004483")]
		message,
		// Token: 0x04004484 RID: 17540
		[Token(Token = "0x4004484")]
		facts,
		// Token: 0x04004485 RID: 17541
		[Token(Token = "0x4004485")]
		history,
		// Token: 0x04004486 RID: 17542
		[Token(Token = "0x4004486")]
		help,
		// Token: 0x04004487 RID: 17543
		[Token(Token = "0x4004487")]
		photoSelect,
		// Token: 0x04004488 RID: 17544
		[Token(Token = "0x4004488")]
		shop,
		// Token: 0x04004489 RID: 17545
		[Token(Token = "0x4004489")]
		objectives,
		// Token: 0x0400448A RID: 17546
		[Token(Token = "0x400448A")]
		callLogsIncoming,
		// Token: 0x0400448B RID: 17547
		[Token(Token = "0x400448B")]
		callLogsOutgoing,
		// Token: 0x0400448C RID: 17548
		[Token(Token = "0x400448C")]
		passcodes,
		// Token: 0x0400448D RID: 17549
		[Token(Token = "0x400448D")]
		phoneNumbers,
		// Token: 0x0400448E RID: 17550
		[Token(Token = "0x400448E")]
		resolve,
		// Token: 0x0400448F RID: 17551
		[Token(Token = "0x400448F")]
		results,
		// Token: 0x04004490 RID: 17552
		[Token(Token = "0x4004490")]
		decor,
		// Token: 0x04004491 RID: 17553
		[Token(Token = "0x4004491")]
		furnishings,
		// Token: 0x04004492 RID: 17554
		[Token(Token = "0x4004492")]
		colourPicker,
		// Token: 0x04004493 RID: 17555
		[Token(Token = "0x4004493")]
		floors,
		// Token: 0x04004494 RID: 17556
		[Token(Token = "0x4004494")]
		ceiling,
		// Token: 0x04004495 RID: 17557
		[Token(Token = "0x4004495")]
		materialKey,
		// Token: 0x04004496 RID: 17558
		[Token(Token = "0x4004496")]
		caseOptions,
		// Token: 0x04004497 RID: 17559
		[Token(Token = "0x4004497")]
		items,
		// Token: 0x04004498 RID: 17560
		[Token(Token = "0x4004498")]
		itemSelect
	}
}
