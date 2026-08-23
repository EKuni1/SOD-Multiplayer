using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200060E RID: 1550
[Token(Token = "0x200060E")]
public class MenuContentController : MonoBehaviour
{
	// Token: 0x0600221E RID: 8734 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600221E")]
	[Address(RVA = "0xB24BA0", Offset = "0xB23BA0", VA = "0x180B24BA0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600221F RID: 8735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600221F")]
	[Address(RVA = "0xB24FF0", Offset = "0xB23FF0", VA = "0x180B24FF0")]
	private void OnDisable()
	{
	}

	// Token: 0x06002220 RID: 8736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002220")]
	[Address(RVA = "0xB25290", Offset = "0xB24290", VA = "0x180B25290")]
	public void CheckEnabled()
	{
	}

	// Token: 0x06002221 RID: 8737 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002221")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public MenuContentController()
	{
	}

	// Token: 0x04002BCB RID: 11211
	[Token(Token = "0x4002BCB")]
	[FieldOffset(Offset = "0x18")]
	public WindowContentController windowContent;

	// Token: 0x04002BCC RID: 11212
	[Token(Token = "0x4002BCC")]
	[FieldOffset(Offset = "0x20")]
	public InfoWindow parentWindow;

	// Token: 0x04002BCD RID: 11213
	[Token(Token = "0x4002BCD")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI descriptionText;
}
