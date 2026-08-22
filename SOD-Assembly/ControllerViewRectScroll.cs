using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005ED RID: 1517
[Token(Token = "0x20005ED")]
public class ControllerViewRectScroll : MonoBehaviour
{
	// Token: 0x06002134 RID: 8500 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002134")]
	[Address(RVA = "0xAFB930", Offset = "0xAFA930", VA = "0x180AFB930")]
	private void Awake()
	{
	}

	// Token: 0x06002135 RID: 8501 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002135")]
	[Address(RVA = "0xAFBA20", Offset = "0xAFAA20", VA = "0x180AFBA20")]
	private void Update()
	{
	}

	// Token: 0x06002136 RID: 8502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002136")]
	[Address(RVA = "0x5CC060", Offset = "0x5CB060", VA = "0x1805CC060")]
	public ControllerViewRectScroll()
	{
	}

	// Token: 0x04002ADD RID: 10973
	[Token(Token = "0x4002ADD")]
	[FieldOffset(Offset = "0x18")]
	public bool controlEnabled;

	// Token: 0x04002ADE RID: 10974
	[Token(Token = "0x4002ADE")]
	[FieldOffset(Offset = "0x20")]
	public CustomScrollRect scrollRect;

	// Token: 0x04002ADF RID: 10975
	[Token(Token = "0x4002ADF")]
	[FieldOffset(Offset = "0x28")]
	public float sensitivity;

	// Token: 0x04002AE0 RID: 10976
	[Token(Token = "0x4002AE0")]
	[FieldOffset(Offset = "0x2C")]
	public bool ignore;

	// Token: 0x04002AE1 RID: 10977
	[Token(Token = "0x4002AE1")]
	[FieldOffset(Offset = "0x30")]
	public CanvasGroup canvasGroup;

	// Token: 0x04002AE2 RID: 10978
	[Token(Token = "0x4002AE2")]
	[FieldOffset(Offset = "0x38")]
	private ControllerViewRectScroll _previousViewRect;
}
