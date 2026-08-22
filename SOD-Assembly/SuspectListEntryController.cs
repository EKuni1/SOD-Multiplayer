using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200068D RID: 1677
[Token(Token = "0x200068D")]
public class SuspectListEntryController : MonoBehaviour
{
	// Token: 0x06002532 RID: 9522 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002532")]
	[Address(RVA = "0xBB6B30", Offset = "0xBB5B30", VA = "0x180BB6B30")]
	public void Setup(GameplayController.History sec)
	{
	}

	// Token: 0x06002533 RID: 9523 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002533")]
	[Address(RVA = "0xBB6DB0", Offset = "0xBB5DB0", VA = "0x180BB6DB0")]
	public void OpenEvidence(ButtonController press)
	{
	}

	// Token: 0x06002534 RID: 9524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002534")]
	[Address(RVA = "0xBB6ED0", Offset = "0xBB5ED0", VA = "0x180BB6ED0")]
	public void VisualUpdate()
	{
	}

	// Token: 0x06002535 RID: 9525 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002535")]
	[Address(RVA = "0xBB77A0", Offset = "0xBB67A0", VA = "0x180BB77A0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002536 RID: 9526 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002536")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public SuspectListEntryController()
	{
	}

	// Token: 0x04002F6D RID: 12141
	[Token(Token = "0x4002F6D")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002F6E RID: 12142
	[Token(Token = "0x4002F6E")]
	[FieldOffset(Offset = "0x20")]
	public ButtonController button;

	// Token: 0x04002F6F RID: 12143
	[Token(Token = "0x4002F6F")]
	[FieldOffset(Offset = "0x28")]
	public Evidence evidence;

	// Token: 0x04002F70 RID: 12144
	[Token(Token = "0x4002F70")]
	[FieldOffset(Offset = "0x30")]
	public GameplayController.History key;

	// Token: 0x04002F71 RID: 12145
	[Token(Token = "0x4002F71")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI nameText;

	// Token: 0x04002F72 RID: 12146
	[Token(Token = "0x4002F72")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI timeText;

	// Token: 0x04002F73 RID: 12147
	[Token(Token = "0x4002F73")]
	[FieldOffset(Offset = "0x48")]
	public RawImage evidenceImage;
}
