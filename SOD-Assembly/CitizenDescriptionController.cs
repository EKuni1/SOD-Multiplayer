using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020005E7 RID: 1511
[Token(Token = "0x20005E7")]
public class CitizenDescriptionController : MonoBehaviour
{
	// Token: 0x06002118 RID: 8472 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002118")]
	[Address(RVA = "0xAF8A40", Offset = "0xAF7A40", VA = "0x180AF8A40")]
	private void OnEnable()
	{
	}

	// Token: 0x06002119 RID: 8473 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002119")]
	[Address(RVA = "0xAF8D50", Offset = "0xAF7D50", VA = "0x180AF8D50")]
	private void OnDisable()
	{
	}

	// Token: 0x0600211A RID: 8474 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600211A")]
	[Address(RVA = "0xAF8FF0", Offset = "0xAF7FF0", VA = "0x180AF8FF0")]
	public void CheckEnabled()
	{
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600211B")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public CitizenDescriptionController()
	{
	}

	// Token: 0x04002AD0 RID: 10960
	[Token(Token = "0x4002AD0")]
	[FieldOffset(Offset = "0x18")]
	public InfoWindow parentWindow;

	// Token: 0x04002AD1 RID: 10961
	[Token(Token = "0x4002AD1")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI descriptionText;
}
