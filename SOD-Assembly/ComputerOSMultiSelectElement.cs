using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002C7 RID: 711
[Token(Token = "0x20002C7")]
public class ComputerOSMultiSelectElement : ComputerOSUIComponent
{
	// Token: 0x06000FE3 RID: 4067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE3")]
	[Address(RVA = "0x689470", Offset = "0x688470", VA = "0x180689470")]
	public void Setup(ComputerOSMultiSelect.OSMultiOption newOpt, ComputerOSMultiSelect newMulti)
	{
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE4")]
	[Address(RVA = "0x68A020", Offset = "0x689020", VA = "0x18068A020", Slot = "4")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FE5")]
	[Address(RVA = "0x68A1E0", Offset = "0x6891E0", VA = "0x18068A1E0")]
	public ComputerOSMultiSelectElement()
	{
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x00008358 File Offset: 0x00006558
	[Token(Token = "0x6000FE6")]
	[Address(RVA = "0x68A240", Offset = "0x689240", VA = "0x18068A240")]
	private bool <Setup>b__10_0(Company item)
	{
		return default(bool);
	}

	// Token: 0x04001309 RID: 4873
	[Token(Token = "0x4001309")]
	[FieldOffset(Offset = "0x28")]
	public ComputerOSMultiSelect multiSelect;

	// Token: 0x0400130A RID: 4874
	[Token(Token = "0x400130A")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform rect;

	// Token: 0x0400130B RID: 4875
	[Token(Token = "0x400130B")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI elementText;

	// Token: 0x0400130C RID: 4876
	[Token(Token = "0x400130C")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI elementText2;

	// Token: 0x0400130D RID: 4877
	[Token(Token = "0x400130D")]
	[FieldOffset(Offset = "0x48")]
	public ComputerOSMultiSelect.OSMultiOption option;

	// Token: 0x0400130E RID: 4878
	[Token(Token = "0x400130E")]
	[FieldOffset(Offset = "0x50")]
	public Image backgroundImage;

	// Token: 0x0400130F RID: 4879
	[Token(Token = "0x400130F")]
	[FieldOffset(Offset = "0x58")]
	public Image iconImage;

	// Token: 0x04001310 RID: 4880
	[Token(Token = "0x4001310")]
	[FieldOffset(Offset = "0x60")]
	public Color backgroundColourNormal;

	// Token: 0x04001311 RID: 4881
	[Token(Token = "0x4001311")]
	[FieldOffset(Offset = "0x70")]
	public Color backgroundColourSelected;

	// Token: 0x04001312 RID: 4882
	[Token(Token = "0x4001312")]
	[FieldOffset(Offset = "0x80")]
	public bool selected;
}
