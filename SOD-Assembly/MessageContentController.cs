using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200060F RID: 1551
[Token(Token = "0x200060F")]
public class MessageContentController : MonoBehaviour
{
	// Token: 0x06002222 RID: 8738 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002222")]
	[Address(RVA = "0xB27640", Offset = "0xB26640", VA = "0x180B27640")]
	private void Awake()
	{
	}

	// Token: 0x06002223 RID: 8739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002223")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public MessageContentController()
	{
	}

	// Token: 0x04002BCE RID: 11214
	[Token(Token = "0x4002BCE")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI messageText;

	// Token: 0x04002BCF RID: 11215
	[Token(Token = "0x4002BCF")]
	[FieldOffset(Offset = "0x20")]
	public ProgressBarController progressBar;

	// Token: 0x04002BD0 RID: 11216
	[Token(Token = "0x4002BD0")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform minigame;

	// Token: 0x04002BD1 RID: 11217
	[Token(Token = "0x4002BD1")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform rect;
}
