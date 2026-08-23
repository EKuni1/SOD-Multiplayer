using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020006A2 RID: 1698
[Token(Token = "0x20006A2")]
public class PopUpButtonNavOverride : MonoBehaviour
{
	// Token: 0x060025BA RID: 9658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025BA")]
	[Address(RVA = "0xBD17B0", Offset = "0xBD07B0", VA = "0x180BD17B0")]
	private void Awake()
	{
	}

	// Token: 0x060025BB RID: 9659 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025BB")]
	[Address(RVA = "0xBD1C10", Offset = "0xBD0C10", VA = "0x180BD1C10")]
	private void Update()
	{
	}

	// Token: 0x060025BC RID: 9660 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025BC")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public PopUpButtonNavOverride()
	{
	}

	// Token: 0x04003013 RID: 12307
	[Token(Token = "0x4003013")]
	[FieldOffset(Offset = "0x18")]
	public TMP_InputField desiredUpTarget;

	// Token: 0x04003014 RID: 12308
	[Token(Token = "0x4003014")]
	[FieldOffset(Offset = "0x20")]
	public ButtonController desiredLeftTarget;

	// Token: 0x04003015 RID: 12309
	[Token(Token = "0x4003015")]
	[FieldOffset(Offset = "0x28")]
	public ButtonController desiredRightTarget;

	// Token: 0x04003016 RID: 12310
	[Token(Token = "0x4003016")]
	[FieldOffset(Offset = "0x30")]
	private Navigation _nav;

	// Token: 0x04003017 RID: 12311
	[Token(Token = "0x4003017")]
	[FieldOffset(Offset = "0x58")]
	private Navigation _previousNav;

	// Token: 0x04003018 RID: 12312
	[Token(Token = "0x4003018")]
	[FieldOffset(Offset = "0x80")]
	private ButtonController _buttonController;
}
