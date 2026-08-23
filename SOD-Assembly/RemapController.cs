using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005C1 RID: 1473
[Token(Token = "0x20005C1")]
public class RemapController : MonoBehaviour
{
	// Token: 0x0600205E RID: 8286 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600205E")]
	[Address(RVA = "0xADAE10", Offset = "0xAD9E10", VA = "0x180ADAE10")]
	public void OnSetAlternateButton()
	{
	}

	// Token: 0x0600205F RID: 8287 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600205F")]
	[Address(RVA = "0xADAE50", Offset = "0xAD9E50", VA = "0x180ADAE50")]
	public void ShowBindingTimeLeftVisuals(float timer)
	{
	}

	// Token: 0x06002060 RID: 8288 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002060")]
	[Address(RVA = "0xADB290", Offset = "0xADA290", VA = "0x180ADB290")]
	public void HideBindingTimeLeftVisuals()
	{
	}

	// Token: 0x06002061 RID: 8289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002061")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public RemapController()
	{
	}

	// Token: 0x040029F2 RID: 10738
	[Token(Token = "0x40029F2")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x040029F3 RID: 10739
	[Token(Token = "0x40029F3")]
	[FieldOffset(Offset = "0x20")]
	public ButtonController primaryControlButton;

	// Token: 0x040029F4 RID: 10740
	[Token(Token = "0x40029F4")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI controlDescriptionText;

	// Token: 0x040029F5 RID: 10741
	[Token(Token = "0x40029F5")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI primaryText;

	// Token: 0x040029F6 RID: 10742
	[Token(Token = "0x40029F6")]
	[FieldOffset(Offset = "0x38")]
	public string actionName;

	// Token: 0x040029F7 RID: 10743
	[Token(Token = "0x40029F7")]
	[FieldOffset(Offset = "0x40")]
	public int actionId;

	// Token: 0x040029F8 RID: 10744
	[Token(Token = "0x40029F8")]
	[FieldOffset(Offset = "0x44")]
	public int index;

	// Token: 0x040029F9 RID: 10745
	[Token(Token = "0x40029F9")]
	[FieldOffset(Offset = "0x48")]
	public string category;

	// Token: 0x040029FA RID: 10746
	[Token(Token = "0x40029FA")]
	[FieldOffset(Offset = "0x50")]
	public Image bindTimerBackground;
}
