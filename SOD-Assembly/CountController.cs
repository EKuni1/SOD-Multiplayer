using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020005EE RID: 1518
[Token(Token = "0x20005EE")]
public class CountController : MonoBehaviour
{
	// Token: 0x06002137 RID: 8503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002137")]
	[Address(RVA = "0xAFBD20", Offset = "0xAFAD20", VA = "0x180AFBD20")]
	private void Awake()
	{
	}

	// Token: 0x06002138 RID: 8504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002138")]
	[Address(RVA = "0xAFBEF0", Offset = "0xAFAEF0", VA = "0x180AFBEF0")]
	public void SetCount(int newVal)
	{
	}

	// Token: 0x06002139 RID: 8505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002139")]
	[Address(RVA = "0xAFC130", Offset = "0xAFB130", VA = "0x180AFC130")]
	public void VisibilityCheck()
	{
	}

	// Token: 0x0600213A RID: 8506 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600213A")]
	[Address(RVA = "0xAFC200", Offset = "0xAFB200", VA = "0x180AFC200")]
	public CountController()
	{
	}

	// Token: 0x04002AE3 RID: 10979
	[Token(Token = "0x4002AE3")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002AE4 RID: 10980
	[Token(Token = "0x4002AE4")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI countText;

	// Token: 0x04002AE5 RID: 10981
	[Token(Token = "0x4002AE5")]
	[FieldOffset(Offset = "0x28")]
	public int count;

	// Token: 0x04002AE6 RID: 10982
	[Token(Token = "0x4002AE6")]
	[FieldOffset(Offset = "0x2C")]
	public bool invisibleIfZero;
}
