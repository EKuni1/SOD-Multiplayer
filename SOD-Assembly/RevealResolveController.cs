using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200068C RID: 1676
[Token(Token = "0x200068C")]
public class RevealResolveController : MonoBehaviour
{
	// Token: 0x0600252E RID: 9518 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600252E")]
	[Address(RVA = "0xBB6080", Offset = "0xBB5080", VA = "0x180BB6080")]
	public void Setup(Case.ResolveQuestion newQuestion, Case newCase, float newRevealAfter)
	{
	}

	// Token: 0x0600252F RID: 9519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600252F")]
	[Address(RVA = "0xBB63E0", Offset = "0xBB53E0", VA = "0x180BB63E0")]
	private void Update()
	{
	}

	// Token: 0x06002530 RID: 9520 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002530")]
	[Address(RVA = "0xBB6980", Offset = "0xBB5980", VA = "0x180BB6980")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002531 RID: 9521 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002531")]
	[Address(RVA = "0xBB6A20", Offset = "0xBB5A20", VA = "0x180BB6A20")]
	public RevealResolveController()
	{
	}

	// Token: 0x04002F5D RID: 12125
	[Token(Token = "0x4002F5D")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002F5E RID: 12126
	[Token(Token = "0x4002F5E")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI questionText;

	// Token: 0x04002F5F RID: 12127
	[Token(Token = "0x4002F5F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject tick;

	// Token: 0x04002F60 RID: 12128
	[Token(Token = "0x4002F60")]
	[FieldOffset(Offset = "0x30")]
	public GameObject cross;

	// Token: 0x04002F61 RID: 12129
	[Token(Token = "0x4002F61")]
	[FieldOffset(Offset = "0x38")]
	public JuiceController tickJuice;

	// Token: 0x04002F62 RID: 12130
	[Token(Token = "0x4002F62")]
	[FieldOffset(Offset = "0x40")]
	public JuiceController crossJuice;

	// Token: 0x04002F63 RID: 12131
	[Token(Token = "0x4002F63")]
	[FieldOffset(Offset = "0x48")]
	public List<CanvasRenderer> fadeInRenderers;

	// Token: 0x04002F64 RID: 12132
	[Token(Token = "0x4002F64")]
	[FieldOffset(Offset = "0x50")]
	public bool isCorrect;

	// Token: 0x04002F65 RID: 12133
	[Token(Token = "0x4002F65")]
	[FieldOffset(Offset = "0x54")]
	public float revealAfterTimer;

	// Token: 0x04002F66 RID: 12134
	[Token(Token = "0x4002F66")]
	[FieldOffset(Offset = "0x58")]
	public float fadeIn;

	// Token: 0x04002F67 RID: 12135
	[Token(Token = "0x4002F67")]
	[FieldOffset(Offset = "0x5C")]
	public float revealCorrectTimer;

	// Token: 0x04002F68 RID: 12136
	[Token(Token = "0x4002F68")]
	[FieldOffset(Offset = "0x60")]
	public float waitTimer;

	// Token: 0x04002F69 RID: 12137
	[Token(Token = "0x4002F69")]
	[FieldOffset(Offset = "0x64")]
	public float removeTimer;

	// Token: 0x04002F6A RID: 12138
	[Token(Token = "0x4002F6A")]
	[FieldOffset(Offset = "0x68")]
	public string qText;

	// Token: 0x04002F6B RID: 12139
	[Token(Token = "0x4002F6B")]
	[FieldOffset(Offset = "0x70")]
	public int revealPhase;

	// Token: 0x04002F6C RID: 12140
	[Token(Token = "0x4002F6C")]
	[FieldOffset(Offset = "0x78")]
	private Case.ResolveQuestion question;
}
