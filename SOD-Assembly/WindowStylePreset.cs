using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008A4 RID: 2212
[Token(Token = "0x20008A4")]
public class WindowStylePreset : SoCustomComparison
{
	// Token: 0x06002A0B RID: 10763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A0B")]
	[Address(RVA = "0xCB4A40", Offset = "0xCB3A40", VA = "0x180CB4A40")]
	public WindowStylePreset()
	{
	}

	// Token: 0x0400446B RID: 17515
	[Token(Token = "0x400446B")]
	[FieldOffset(Offset = "0x20")]
	public bool closable;

	// Token: 0x0400446C RID: 17516
	[Token(Token = "0x400446C")]
	[FieldOffset(Offset = "0x21")]
	public bool pinnable;

	// Token: 0x0400446D RID: 17517
	[Token(Token = "0x400446D")]
	[FieldOffset(Offset = "0x22")]
	public bool forceWorldInteraction;

	// Token: 0x0400446E RID: 17518
	[Token(Token = "0x400446E")]
	[FieldOffset(Offset = "0x23")]
	public bool useWindowFocusMode;

	// Token: 0x0400446F RID: 17519
	[Token(Token = "0x400446F")]
	[FieldOffset(Offset = "0x24")]
	public bool resizable;

	// Token: 0x04004470 RID: 17520
	[Token(Token = "0x4004470")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 defaultSize;

	// Token: 0x04004471 RID: 17521
	[Token(Token = "0x4004471")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 minSize;

	// Token: 0x04004472 RID: 17522
	[Token(Token = "0x4004472")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 maxSize;

	// Token: 0x04004473 RID: 17523
	[Token(Token = "0x4004473")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 DDSadditionalSize;

	// Token: 0x04004474 RID: 17524
	[Token(Token = "0x4004474")]
	[FieldOffset(Offset = "0x48")]
	public Sprite overrideIcon;

	// Token: 0x04004475 RID: 17525
	[Token(Token = "0x4004475")]
	[FieldOffset(Offset = "0x50")]
	public List<WindowTabPreset> tabs;
}
