using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002D8 RID: 728
[Token(Token = "0x20002D8")]
public class SabotageApp : CruncherAppContent
{
	// Token: 0x06001023 RID: 4131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001023")]
	[Address(RVA = "0x6916F0", Offset = "0x6906F0", VA = "0x1806916F0")]
	private void Update()
	{
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001024")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public SabotageApp()
	{
	}

	// Token: 0x0400134A RID: 4938
	[Token(Token = "0x400134A")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI titleText;

	// Token: 0x0400134B RID: 4939
	[Token(Token = "0x400134B")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI percentageText;

	// Token: 0x0400134C RID: 4940
	[Token(Token = "0x400134C")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform progressBar;

	// Token: 0x0400134D RID: 4941
	[Token(Token = "0x400134D")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform progressBarFill;

	// Token: 0x0400134E RID: 4942
	[Token(Token = "0x400134E")]
	[FieldOffset(Offset = "0x40")]
	public float progress;
}
