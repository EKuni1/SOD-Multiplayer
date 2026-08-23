using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020005E9 RID: 1513
[Token(Token = "0x20005E9")]
public class CityDirectoryController : MonoBehaviour
{
	// Token: 0x06002120 RID: 8480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002120")]
	[Address(RVA = "0xAF9DA0", Offset = "0xAF8DA0", VA = "0x180AF9DA0")]
	private void OnEnable()
	{
	}

	// Token: 0x06002121 RID: 8481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002121")]
	[Address(RVA = "0xAFA1F0", Offset = "0xAF91F0", VA = "0x180AFA1F0")]
	private void OnDisable()
	{
	}

	// Token: 0x06002122 RID: 8482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002122")]
	[Address(RVA = "0xAFA490", Offset = "0xAF9490", VA = "0x180AFA490")]
	public void CheckEnabled()
	{
	}

	// Token: 0x06002123 RID: 8483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002123")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public CityDirectoryController()
	{
	}

	// Token: 0x04002AD4 RID: 10964
	[Token(Token = "0x4002AD4")]
	[FieldOffset(Offset = "0x18")]
	public WindowContentController windowContent;

	// Token: 0x04002AD5 RID: 10965
	[Token(Token = "0x4002AD5")]
	[FieldOffset(Offset = "0x20")]
	public InfoWindow parentWindow;

	// Token: 0x04002AD6 RID: 10966
	[Token(Token = "0x4002AD6")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI descriptionText;
}
