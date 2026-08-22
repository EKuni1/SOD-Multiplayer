using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000687 RID: 1671
[Token(Token = "0x2000687")]
public class PhoneNumbersController : MonoBehaviour
{
	// Token: 0x06002509 RID: 9481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002509")]
	[Address(RVA = "0xBAF280", Offset = "0xBAE280", VA = "0x180BAF280")]
	public void Setup(WindowContentController newContentController)
	{
	}

	// Token: 0x0600250A RID: 9482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600250A")]
	[Address(RVA = "0xB99340", Offset = "0xB98340", VA = "0x180B99340")]
	public void SetPageSize(Vector2 newSize)
	{
	}

	// Token: 0x0600250B RID: 9483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600250B")]
	[Address(RVA = "0xBAF580", Offset = "0xBAE580", VA = "0x180BAF580")]
	private void OnEnable()
	{
	}

	// Token: 0x0600250C RID: 9484 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600250C")]
	[Address(RVA = "0xBAF660", Offset = "0xBAE660", VA = "0x180BAF660")]
	private void OnDisable()
	{
	}

	// Token: 0x0600250D RID: 9485 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600250D")]
	[Address(RVA = "0xBAF950", Offset = "0xBAE950", VA = "0x180BAF950")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600250E RID: 9486 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600250E")]
	[Address(RVA = "0xBAFC40", Offset = "0xBAEC40", VA = "0x180BAFC40")]
	public void UpdateListDisplay()
	{
	}

	// Token: 0x0600250F RID: 9487 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600250F")]
	[Address(RVA = "0xBB0950", Offset = "0xBAF950", VA = "0x180BB0950")]
	public void ClearSearchButton()
	{
	}

	// Token: 0x06002510 RID: 9488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002510")]
	[Address(RVA = "0xBB09B0", Offset = "0xBAF9B0", VA = "0x180BB09B0")]
	public PhoneNumbersController()
	{
	}

	// Token: 0x04002F2C RID: 12076
	[Token(Token = "0x4002F2C")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002F2D RID: 12077
	[Token(Token = "0x4002F2D")]
	[FieldOffset(Offset = "0x20")]
	public WindowContentController wcc;

	// Token: 0x04002F2E RID: 12078
	[Token(Token = "0x4002F2E")]
	[FieldOffset(Offset = "0x28")]
	public bool isSetup;

	// Token: 0x04002F2F RID: 12079
	[Token(Token = "0x4002F2F")]
	[FieldOffset(Offset = "0x29")]
	public bool isMini;

	// Token: 0x04002F30 RID: 12080
	[Token(Token = "0x4002F30")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI contentsText;

	// Token: 0x04002F31 RID: 12081
	[Token(Token = "0x4002F31")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform entryParent;

	// Token: 0x04002F32 RID: 12082
	[Token(Token = "0x4002F32")]
	[FieldOffset(Offset = "0x40")]
	public TMP_InputField searchInputField;

	// Token: 0x04002F33 RID: 12083
	[Token(Token = "0x4002F33")]
	[FieldOffset(Offset = "0x48")]
	public List<PhoneNumberEntryController> spawnedEntries;
}
