using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020005E6 RID: 1510
[Token(Token = "0x20005E6")]
public class CallLogsEntryController : MonoBehaviour
{
	// Token: 0x06002114 RID: 8468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002114")]
	[Address(RVA = "0xAF6590", Offset = "0xAF5590", VA = "0x180AF6590")]
	public void Setup(TelephoneController.PhoneCall newLogged, NewBuilding newBuilding)
	{
	}

	// Token: 0x06002115 RID: 8469 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002115")]
	[Address(RVA = "0xAF7840", Offset = "0xAF6840", VA = "0x180AF7840")]
	public void FromButton()
	{
	}

	// Token: 0x06002116 RID: 8470 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002116")]
	[Address(RVA = "0xAF8100", Offset = "0xAF7100", VA = "0x180AF8100")]
	public void ToButton()
	{
	}

	// Token: 0x06002117 RID: 8471 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002117")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public CallLogsEntryController()
	{
	}

	// Token: 0x04002AC9 RID: 10953
	[Token(Token = "0x4002AC9")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002ACA RID: 10954
	[Token(Token = "0x4002ACA")]
	[FieldOffset(Offset = "0x20")]
	public NewBuilding building;

	// Token: 0x04002ACB RID: 10955
	[Token(Token = "0x4002ACB")]
	[FieldOffset(Offset = "0x28")]
	public TelephoneController.PhoneCall logged;

	// Token: 0x04002ACC RID: 10956
	[Token(Token = "0x4002ACC")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI timeText;

	// Token: 0x04002ACD RID: 10957
	[Token(Token = "0x4002ACD")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI durationText;

	// Token: 0x04002ACE RID: 10958
	[Token(Token = "0x4002ACE")]
	[FieldOffset(Offset = "0x40")]
	public ButtonController fromButton;

	// Token: 0x04002ACF RID: 10959
	[Token(Token = "0x4002ACF")]
	[FieldOffset(Offset = "0x48")]
	public ButtonController toButton;
}
