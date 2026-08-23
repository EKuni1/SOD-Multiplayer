using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000657 RID: 1623
[Token(Token = "0x2000657")]
public class PulsateController : MonoBehaviour
{
	// Token: 0x060023CE RID: 9166 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023CE")]
	[Address(RVA = "0xB73130", Offset = "0xB72130", VA = "0x180B73130")]
	private void Start()
	{
	}

	// Token: 0x060023CF RID: 9167 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023CF")]
	[Address(RVA = "0xB73320", Offset = "0xB72320", VA = "0x180B73320")]
	private void Update()
	{
	}

	// Token: 0x060023D0 RID: 9168 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023D0")]
	[Address(RVA = "0xB734F0", Offset = "0xB724F0", VA = "0x180B734F0")]
	private void OnDisable()
	{
	}

	// Token: 0x060023D1 RID: 9169 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023D1")]
	[Address(RVA = "0xB73540", Offset = "0xB72540", VA = "0x180B73540")]
	public PulsateController()
	{
	}

	// Token: 0x04002DBD RID: 11709
	[Token(Token = "0x4002DBD")]
	[FieldOffset(Offset = "0x18")]
	public Image img;

	// Token: 0x04002DBE RID: 11710
	[Token(Token = "0x4002DBE")]
	[FieldOffset(Offset = "0x20")]
	public bool getNormalColourAtStart;

	// Token: 0x04002DBF RID: 11711
	[Token(Token = "0x4002DBF")]
	[FieldOffset(Offset = "0x24")]
	public Color normalColour;

	// Token: 0x04002DC0 RID: 11712
	[Token(Token = "0x4002DC0")]
	[FieldOffset(Offset = "0x34")]
	public Color pulsateColour;

	// Token: 0x04002DC1 RID: 11713
	[Token(Token = "0x4002DC1")]
	[FieldOffset(Offset = "0x44")]
	public float speed;

	// Token: 0x04002DC2 RID: 11714
	[Token(Token = "0x4002DC2")]
	[FieldOffset(Offset = "0x48")]
	public float progress;

	// Token: 0x04002DC3 RID: 11715
	[Token(Token = "0x4002DC3")]
	[FieldOffset(Offset = "0x4C")]
	public bool onoff;
}
