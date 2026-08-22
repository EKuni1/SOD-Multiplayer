using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000656 RID: 1622
[Token(Token = "0x2000656")]
public class ProgressBarPipController : ButtonController
{
	// Token: 0x060023C7 RID: 9159 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023C7")]
	[Address(RVA = "0xB72800", Offset = "0xB71800", VA = "0x180B72800")]
	private void Awake()
	{
	}

	// Token: 0x060023C8 RID: 9160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023C8")]
	[Address(RVA = "0xB72A70", Offset = "0xB71A70", VA = "0x180B72A70", Slot = "25")]
	public override void OnHoverStart()
	{
	}

	// Token: 0x060023C9 RID: 9161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023C9")]
	[Address(RVA = "0xB72AF0", Offset = "0xB71AF0", VA = "0x180B72AF0", Slot = "26")]
	public override void OnHoverEnd()
	{
	}

	// Token: 0x060023CA RID: 9162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023CA")]
	[Address(RVA = "0xB72B60", Offset = "0xB71B60", VA = "0x180B72B60")]
	public void SetFilled(bool newVal, bool secondaryFilled)
	{
	}

	// Token: 0x060023CB RID: 9163 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
	[Token(Token = "0x60023CB")]
	[Address(RVA = "0xB72E60", Offset = "0xB71E60", VA = "0x180B72E60")]
	public int GetPipNumber()
	{
		return 0;
	}

	// Token: 0x060023CC RID: 9164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023CC")]
	[Address(RVA = "0xB72F50", Offset = "0xB71F50", VA = "0x180B72F50")]
	public ProgressBarPipController()
	{
	}

	// Token: 0x060023CD RID: 9165 RVA: 0x0000E700 File Offset: 0x0000C900
	[Token(Token = "0x60023CD")]
	[Address(RVA = "0xB72F90", Offset = "0xB71F90", VA = "0x180B72F90")]
	private bool <GetPipNumber>b__11_0(ProgressBarPipController item)
	{
		return default(bool);
	}

	// Token: 0x04002DB6 RID: 11702
	[Token(Token = "0x4002DB6")]
	[FieldOffset(Offset = "0x1A8")]
	public Image img;

	// Token: 0x04002DB7 RID: 11703
	[Token(Token = "0x4002DB7")]
	[FieldOffset(Offset = "0x1B0")]
	public Color unfilledColour;

	// Token: 0x04002DB8 RID: 11704
	[Token(Token = "0x4002DB8")]
	[FieldOffset(Offset = "0x1C0")]
	public Color filledColour;

	// Token: 0x04002DB9 RID: 11705
	[Token(Token = "0x4002DB9")]
	[FieldOffset(Offset = "0x1D0")]
	public Color secondaryColour;

	// Token: 0x04002DBA RID: 11706
	[Token(Token = "0x4002DBA")]
	[FieldOffset(Offset = "0x1E0")]
	public ProgressBarController bar;

	// Token: 0x04002DBB RID: 11707
	[Token(Token = "0x4002DBB")]
	[FieldOffset(Offset = "0x1E8")]
	public bool filled;

	// Token: 0x04002DBC RID: 11708
	[Token(Token = "0x4002DBC")]
	[FieldOffset(Offset = "0x1E9")]
	public bool secondaryFilled;
}
