using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000658 RID: 1624
[Token(Token = "0x2000658")]
public class PulseGlowController : MonoBehaviour
{
	// Token: 0x060023D2 RID: 9170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023D2")]
	[Address(RVA = "0xB735B0", Offset = "0xB725B0", VA = "0x180B735B0")]
	private void Awake()
	{
	}

	// Token: 0x060023D3 RID: 9171 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023D3")]
	[Address(RVA = "0xB735C0", Offset = "0xB725C0", VA = "0x180B735C0")]
	public void SetGlow(bool onOff)
	{
	}

	// Token: 0x060023D4 RID: 9172 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023D4")]
	[Address(RVA = "0xB73960", Offset = "0xB72960", VA = "0x180B73960")]
	private void Update()
	{
	}

	// Token: 0x060023D5 RID: 9173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023D5")]
	[Address(RVA = "0xB73F70", Offset = "0xB72F70", VA = "0x180B73F70")]
	public PulseGlowController()
	{
	}

	// Token: 0x04002DC4 RID: 11716
	[Token(Token = "0x4002DC4")]
	[FieldOffset(Offset = "0x18")]
	public Image imageToGlow;

	// Token: 0x04002DC5 RID: 11717
	[Token(Token = "0x4002DC5")]
	[FieldOffset(Offset = "0x20")]
	public RawImage rawImageToGlow;

	// Token: 0x04002DC6 RID: 11718
	[Token(Token = "0x4002DC6")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI textToGlow;

	// Token: 0x04002DC7 RID: 11719
	[Token(Token = "0x4002DC7")]
	[FieldOffset(Offset = "0x30")]
	public bool glowActiveOnStart;

	// Token: 0x04002DC8 RID: 11720
	[Token(Token = "0x4002DC8")]
	[FieldOffset(Offset = "0x31")]
	public bool glowActive;

	// Token: 0x04002DC9 RID: 11721
	[Token(Token = "0x4002DC9")]
	[FieldOffset(Offset = "0x34")]
	public float pulseSpeed;

	// Token: 0x04002DCA RID: 11722
	[Token(Token = "0x4002DCA")]
	[FieldOffset(Offset = "0x38")]
	private float glowState;

	// Token: 0x04002DCB RID: 11723
	[Token(Token = "0x4002DCB")]
	[FieldOffset(Offset = "0x3C")]
	private bool glowSwitch;

	// Token: 0x04002DCC RID: 11724
	[Token(Token = "0x4002DCC")]
	[FieldOffset(Offset = "0x3D")]
	public bool useLerpColour;

	// Token: 0x04002DCD RID: 11725
	[Token(Token = "0x4002DCD")]
	[FieldOffset(Offset = "0x40")]
	public Color originalColour;

	// Token: 0x04002DCE RID: 11726
	[Token(Token = "0x4002DCE")]
	[FieldOffset(Offset = "0x50")]
	public Color lerpColour;
}
