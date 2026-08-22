using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002CA RID: 714
[Token(Token = "0x20002CA")]
public class CruncherAppContent : MonoBehaviour
{
	// Token: 0x06000FEC RID: 4076 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0x68AA00", Offset = "0x689A00", VA = "0x18068AA00", Slot = "4")]
	public virtual void Setup(ComputerController cc)
	{
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FED")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
	public virtual void OnSetup()
	{
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0x68AA70", Offset = "0x689A70", VA = "0x18068AA70", Slot = "6")]
	public virtual void PrintButton()
	{
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FEF")]
	[Address(RVA = "0x68AB00", Offset = "0x689B00", VA = "0x18068AB00")]
	public void OnPlayerTakePrint()
	{
	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FF0")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public CruncherAppContent()
	{
	}

	// Token: 0x0400131E RID: 4894
	[Token(Token = "0x400131E")]
	[FieldOffset(Offset = "0x18")]
	public ComputerController controller;
}
