using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020006A3 RID: 1699
[Token(Token = "0x20006A3")]
public class PopUpInputFieldNavOverride : MonoBehaviour
{
	// Token: 0x060025BD RID: 9661 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025BD")]
	[Address(RVA = "0xBD1CD0", Offset = "0xBD0CD0", VA = "0x180BD1CD0")]
	private void Awake()
	{
	}

	// Token: 0x060025BE RID: 9662 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025BE")]
	[Address(RVA = "0xBD2070", Offset = "0xBD1070", VA = "0x180BD2070")]
	private void Update()
	{
	}

	// Token: 0x060025BF RID: 9663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025BF")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public PopUpInputFieldNavOverride()
	{
	}

	// Token: 0x04003019 RID: 12313
	[Token(Token = "0x4003019")]
	[FieldOffset(Offset = "0x18")]
	public Button desiredNavTarget;

	// Token: 0x0400301A RID: 12314
	[Token(Token = "0x400301A")]
	[FieldOffset(Offset = "0x20")]
	private Navigation _nav;

	// Token: 0x0400301B RID: 12315
	[Token(Token = "0x400301B")]
	[FieldOffset(Offset = "0x48")]
	private Navigation _previousNav;

	// Token: 0x0400301C RID: 12316
	[Token(Token = "0x400301C")]
	[FieldOffset(Offset = "0x70")]
	private TMP_InputField _inputField;
}
