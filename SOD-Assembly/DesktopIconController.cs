using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002D5 RID: 725
[Token(Token = "0x20002D5")]
public class DesktopIconController : ComputerOSUIComponent
{
	// Token: 0x0600101A RID: 4122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101A")]
	[Address(RVA = "0x690180", Offset = "0x68F180", VA = "0x180690180")]
	public void Setup(DesktopApp newDesktop, CruncherAppPreset newApp)
	{
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101B")]
	[Address(RVA = "0x690330", Offset = "0x68F330", VA = "0x180690330", Slot = "4")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600101C")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public DesktopIconController()
	{
	}

	// Token: 0x04001342 RID: 4930
	[Token(Token = "0x4001342")]
	[FieldOffset(Offset = "0x28")]
	public DesktopApp desktop;

	// Token: 0x04001343 RID: 4931
	[Token(Token = "0x4001343")]
	[FieldOffset(Offset = "0x30")]
	public CruncherAppPreset preset;

	// Token: 0x04001344 RID: 4932
	[Token(Token = "0x4001344")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform rect;

	// Token: 0x04001345 RID: 4933
	[Token(Token = "0x4001345")]
	[FieldOffset(Offset = "0x40")]
	public Image icon;

	// Token: 0x04001346 RID: 4934
	[Token(Token = "0x4001346")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI iconText;
}
