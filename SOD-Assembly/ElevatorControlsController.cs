using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020005F0 RID: 1520
[Token(Token = "0x20005F0")]
public class ElevatorControlsController : MonoBehaviour
{
	// Token: 0x06002145 RID: 8517 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002145")]
	[Address(RVA = "0xAFDE60", Offset = "0xAFCE60", VA = "0x180AFDE60")]
	private void OnEnable()
	{
	}

	// Token: 0x06002146 RID: 8518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002146")]
	[Address(RVA = "0xAFE4B0", Offset = "0xAFD4B0", VA = "0x180AFE4B0")]
	public void PressNumberButton(int newInt)
	{
	}

	// Token: 0x06002147 RID: 8519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002147")]
	[Address(RVA = "0xAFE7F0", Offset = "0xAFD7F0", VA = "0x180AFE7F0")]
	public ElevatorControlsController()
	{
	}

	// Token: 0x04002AFD RID: 11005
	[Token(Token = "0x4002AFD")]
	[FieldOffset(Offset = "0x18")]
	public InfoWindow parentWindow;

	// Token: 0x04002AFE RID: 11006
	[Token(Token = "0x4002AFE")]
	[FieldOffset(Offset = "0x20")]
	public Evidence evidence;

	// Token: 0x04002AFF RID: 11007
	[Token(Token = "0x4002AFF")]
	[FieldOffset(Offset = "0x28")]
	public WindowContentController windowContent;

	// Token: 0x04002B00 RID: 11008
	[Token(Token = "0x4002B00")]
	[FieldOffset(Offset = "0x30")]
	public List<RectTransform> buttons;

	// Token: 0x04002B01 RID: 11009
	[Token(Token = "0x4002B01")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI inputText;
}
