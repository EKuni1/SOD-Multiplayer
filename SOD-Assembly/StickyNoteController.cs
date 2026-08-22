using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000623 RID: 1571
[Token(Token = "0x2000623")]
public class StickyNoteController : MonoBehaviour
{
	// Token: 0x0600227D RID: 8829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600227D")]
	[Address(RVA = "0xB35AB0", Offset = "0xB34AB0", VA = "0x180B35AB0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600227E")]
	[Address(RVA = "0xB360D0", Offset = "0xB350D0", VA = "0x180B360D0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600227F RID: 8831 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600227F")]
	[Address(RVA = "0xB362A0", Offset = "0xB352A0", VA = "0x180B362A0")]
	public void OnNoteEdit()
	{
	}

	// Token: 0x06002280 RID: 8832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002280")]
	[Address(RVA = "0xB363E0", Offset = "0xB353E0", VA = "0x180B363E0")]
	public void SetPlayerTextInput(bool val)
	{
	}

	// Token: 0x06002281 RID: 8833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002281")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public StickyNoteController()
	{
	}

	// Token: 0x04002C2E RID: 11310
	[Token(Token = "0x4002C2E")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002C2F RID: 11311
	[Token(Token = "0x4002C2F")]
	[FieldOffset(Offset = "0x20")]
	public WindowContentController windowContent;

	// Token: 0x04002C30 RID: 11312
	[Token(Token = "0x4002C30")]
	[FieldOffset(Offset = "0x28")]
	public InfoWindow parentWindow;

	// Token: 0x04002C31 RID: 11313
	[Token(Token = "0x4002C31")]
	[FieldOffset(Offset = "0x30")]
	public TMP_InputField input;

	// Token: 0x04002C32 RID: 11314
	[Token(Token = "0x4002C32")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI text;
}
