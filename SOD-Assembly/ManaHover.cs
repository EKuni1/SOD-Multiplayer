using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002E6 RID: 742
[Token(Token = "0x20002E6")]
public class ManaHover : MonoBehaviour
{
	// Token: 0x06001079 RID: 4217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001079")]
	[Address(RVA = "0x6A4A60", Offset = "0x6A3A60", VA = "0x1806A4A60")]
	private void Start()
	{
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x000084F0 File Offset: 0x000066F0
	[Token(Token = "0x600107A")]
	[Address(RVA = "0x6A4BF0", Offset = "0x6A3BF0", VA = "0x1806A4BF0")]
	private bool IsCursorOverBar()
	{
		return default(bool);
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600107B")]
	[Address(RVA = "0x6A4F50", Offset = "0x6A3F50", VA = "0x1806A4F50")]
	private void FixedUpdate()
	{
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600107C")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ManaHover()
	{
	}

	// Token: 0x040013DA RID: 5082
	[Token(Token = "0x40013DA")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI ManaText;

	// Token: 0x040013DB RID: 5083
	[Token(Token = "0x40013DB")]
	[FieldOffset(Offset = "0x20")]
	public WizcardPlayer player;

	// Token: 0x040013DC RID: 5084
	[Token(Token = "0x40013DC")]
	[FieldOffset(Offset = "0x28")]
	private ComputerController comp;

	// Token: 0x040013DD RID: 5085
	[Token(Token = "0x40013DD")]
	[FieldOffset(Offset = "0x30")]
	private ComputerOSUIComponent hoverComponent;

	// Token: 0x040013DE RID: 5086
	[Token(Token = "0x40013DE")]
	[FieldOffset(Offset = "0x38")]
	private bool isHovered;

	// Token: 0x040013DF RID: 5087
	[Token(Token = "0x40013DF")]
	[FieldOffset(Offset = "0x40")]
	private RectTransform rectTransform;
}
