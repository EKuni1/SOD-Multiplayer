using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

// Token: 0x020006A1 RID: 1697
[Token(Token = "0x20006A1")]
public class AccentedVirtualKeyCharacter : MonoBehaviour
{
	// Token: 0x060025B3 RID: 9651 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025B3")]
	[Address(RVA = "0xBD0EA0", Offset = "0xBCFEA0", VA = "0x180BD0EA0")]
	private void Awake()
	{
	}

	// Token: 0x060025B4 RID: 9652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025B4")]
	[Address(RVA = "0xBD1090", Offset = "0xBD0090", VA = "0x180BD1090")]
	private void OnEnable()
	{
	}

	// Token: 0x060025B5 RID: 9653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025B5")]
	[Address(RVA = "0xBD10F0", Offset = "0xBD00F0", VA = "0x180BD10F0")]
	private void SetLanguage(string language)
	{
	}

	// Token: 0x060025B6 RID: 9654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025B6")]
	[Address(RVA = "0xBD1380", Offset = "0xBD0380", VA = "0x180BD1380")]
	private void OnDisable()
	{
	}

	// Token: 0x060025B7 RID: 9655 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025B7")]
	[Address(RVA = "0xBD13F0", Offset = "0xBD03F0", VA = "0x180BD13F0")]
	private void Update()
	{
	}

	// Token: 0x060025B8 RID: 9656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025B8")]
	[Address(RVA = "0xBD1640", Offset = "0xBD0640", VA = "0x180BD1640")]
	private void CycleTextCharacter()
	{
	}

	// Token: 0x060025B9 RID: 9657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025B9")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public AccentedVirtualKeyCharacter()
	{
	}

	// Token: 0x04003009 RID: 12297
	[Token(Token = "0x4003009")]
	[FieldOffset(Offset = "0x18")]
	public List<string> spanishAccentCharacters;

	// Token: 0x0400300A RID: 12298
	[Token(Token = "0x400300A")]
	[FieldOffset(Offset = "0x20")]
	public List<string> frenchAccentCharacters;

	// Token: 0x0400300B RID: 12299
	[Token(Token = "0x400300B")]
	[FieldOffset(Offset = "0x28")]
	public List<string> portugueseAccentCharacters;

	// Token: 0x0400300C RID: 12300
	[Token(Token = "0x400300C")]
	[FieldOffset(Offset = "0x30")]
	public List<string> germanAccentCharacters;

	// Token: 0x0400300D RID: 12301
	[Token(Token = "0x400300D")]
	[FieldOffset(Offset = "0x38")]
	private List<string> _selectedLanguageSet;

	// Token: 0x0400300E RID: 12302
	[Token(Token = "0x400300E")]
	[FieldOffset(Offset = "0x40")]
	private string _originalCharacter;

	// Token: 0x0400300F RID: 12303
	[Token(Token = "0x400300F")]
	[FieldOffset(Offset = "0x48")]
	private ButtonController _buttonController;

	// Token: 0x04003010 RID: 12304
	[Token(Token = "0x4003010")]
	[FieldOffset(Offset = "0x50")]
	private Rewired.Player _player;

	// Token: 0x04003011 RID: 12305
	[Token(Token = "0x4003011")]
	[FieldOffset(Offset = "0x58")]
	private bool _accentToggleHeld;

	// Token: 0x04003012 RID: 12306
	[Token(Token = "0x4003012")]
	[FieldOffset(Offset = "0x5C")]
	private int _charIndex;
}
