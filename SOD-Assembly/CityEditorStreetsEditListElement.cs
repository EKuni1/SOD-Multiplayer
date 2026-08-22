using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000203 RID: 515
[Token(Token = "0x2000203")]
public class CityEditorStreetsEditListElement : MonoBehaviour
{
	// Token: 0x06000C52 RID: 3154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x5952E0", Offset = "0x5942E0", VA = "0x1805952E0")]
	public void Setup(StreetController newStreet, CityEditorStreetEdit controller)
	{
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C53")]
	[Address(RVA = "0x595400", Offset = "0x594400", VA = "0x180595400")]
	public void UpdateSelection()
	{
	}

	// Token: 0x06000C54 RID: 3156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C54")]
	[Address(RVA = "0x595660", Offset = "0x594660", VA = "0x180595660")]
	public void OnSelectButton()
	{
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C55")]
	[Address(RVA = "0x595690", Offset = "0x594690", VA = "0x180595690")]
	public void OnRandomNameButton()
	{
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x5957C0", Offset = "0x5947C0", VA = "0x1805957C0")]
	public void OnEditNameButton()
	{
	}

	// Token: 0x06000C57 RID: 3159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C57")]
	[Address(RVA = "0x595800", Offset = "0x594800", VA = "0x180595800")]
	public void OnChangeStreetNameButton()
	{
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C58")]
	[Address(RVA = "0x595B00", Offset = "0x594B00", VA = "0x180595B00")]
	private void OnChangeStreetNamePopupCancel()
	{
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C59")]
	[Address(RVA = "0x595C60", Offset = "0x594C60", VA = "0x180595C60")]
	private void OnChangeStreetNamePopupConfirm()
	{
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public CityEditorStreetsEditListElement()
	{
	}

	// Token: 0x04000CBD RID: 3261
	[Token(Token = "0x4000CBD")]
	[FieldOffset(Offset = "0x18")]
	public CityEditorStreetEdit streetEdit;

	// Token: 0x04000CBE RID: 3262
	[Token(Token = "0x4000CBE")]
	[FieldOffset(Offset = "0x20")]
	public StreetController street;

	// Token: 0x04000CBF RID: 3263
	[Token(Token = "0x4000CBF")]
	[FieldOffset(Offset = "0x28")]
	public ButtonController selectButton;

	// Token: 0x04000CC0 RID: 3264
	[Token(Token = "0x4000CC0")]
	[FieldOffset(Offset = "0x30")]
	public ButtonController editNameButton;

	// Token: 0x04000CC1 RID: 3265
	[Token(Token = "0x4000CC1")]
	[FieldOffset(Offset = "0x38")]
	public ButtonController randomNameButton;

	// Token: 0x04000CC2 RID: 3266
	[Token(Token = "0x4000CC2")]
	[FieldOffset(Offset = "0x40")]
	public Image selectionImg;
}
