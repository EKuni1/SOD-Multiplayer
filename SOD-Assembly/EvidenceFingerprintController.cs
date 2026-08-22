using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005F2 RID: 1522
[Token(Token = "0x20005F2")]
public class EvidenceFingerprintController : MonoBehaviour
{
	// Token: 0x06002153 RID: 8531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002153")]
	[Address(RVA = "0xB01580", Offset = "0xB00580", VA = "0x180B01580")]
	private void OnEnable()
	{
	}

	// Token: 0x06002154 RID: 8532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002154")]
	[Address(RVA = "0xB01830", Offset = "0xB00830", VA = "0x180B01830")]
	private void OnDisable()
	{
	}

	// Token: 0x06002155 RID: 8533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002155")]
	[Address(RVA = "0xB01AD0", Offset = "0xB00AD0", VA = "0x180B01AD0")]
	public void CheckEnabled()
	{
	}

	// Token: 0x06002156 RID: 8534 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002156")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public EvidenceFingerprintController()
	{
	}

	// Token: 0x04002B06 RID: 11014
	[Token(Token = "0x4002B06")]
	[FieldOffset(Offset = "0x18")]
	public InfoWindow parentWindow;

	// Token: 0x04002B07 RID: 11015
	[Token(Token = "0x4002B07")]
	[FieldOffset(Offset = "0x20")]
	public RawImage photoRaw;

	// Token: 0x04002B08 RID: 11016
	[Token(Token = "0x4002B08")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI identifierText;
}
