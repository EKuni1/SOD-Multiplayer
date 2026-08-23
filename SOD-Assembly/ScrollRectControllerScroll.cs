using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005C2 RID: 1474
[Token(Token = "0x20005C2")]
public class ScrollRectControllerScroll : MonoBehaviour
{
	// Token: 0x06002062 RID: 8290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002062")]
	[Address(RVA = "0xADB430", Offset = "0xADA430", VA = "0x180ADB430")]
	private void Awake()
	{
	}

	// Token: 0x06002063 RID: 8291 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002063")]
	[Address(RVA = "0xADB4C0", Offset = "0xADA4C0", VA = "0x180ADB4C0")]
	private void Update()
	{
	}

	// Token: 0x06002064 RID: 8292 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002064")]
	[Address(RVA = "0xADB7D0", Offset = "0xADA7D0", VA = "0x180ADB7D0")]
	public ScrollRectControllerScroll()
	{
	}

	// Token: 0x040029FB RID: 10747
	[Token(Token = "0x40029FB")]
	[FieldOffset(Offset = "0x18")]
	public bool autoScrollingEnabled;

	// Token: 0x040029FC RID: 10748
	[Token(Token = "0x40029FC")]
	[FieldOffset(Offset = "0x1C")]
	public float scrollSpeed;

	// Token: 0x040029FD RID: 10749
	[Token(Token = "0x40029FD")]
	[FieldOffset(Offset = "0x20")]
	private CustomScrollRect scrollRect;
}
