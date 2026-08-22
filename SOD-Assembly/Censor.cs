using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000036 RID: 54
[Token(Token = "0x2000036")]
public class Censor : MonoBehaviour
{
	// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x5C9A90", Offset = "0x5C8A90", VA = "0x1805C9A90")]
	private void Awake()
	{
	}

	// Token: 0x060001DA RID: 474 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x5C9D70", Offset = "0x5C8D70", VA = "0x1805C9D70")]
	public string CensorText(string text)
	{
		return null;
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x5C9DF0", Offset = "0x5C8DF0", VA = "0x1805C9DF0")]
	private string checkThisText(string text)
	{
		return null;
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x5CA390", Offset = "0x5C9390", VA = "0x1805CA390")]
	private string checkNumbers(string input)
	{
		return null;
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x5CA470", Offset = "0x5C9470", VA = "0x1805CA470")]
	private string checkForInterspersedNumbers(string input)
	{
		return null;
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x5CA550", Offset = "0x5C9550", VA = "0x1805CA550")]
	private string checkForLeet(string input)
	{
		return null;
	}

	// Token: 0x060001DF RID: 479 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x5CA950", Offset = "0x5C9950", VA = "0x1805CA950")]
	private string checkForReverses(string input)
	{
		return null;
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x5CA9A0", Offset = "0x5C99A0", VA = "0x1805CA9A0")]
	private string Reverse(string s)
	{
		return null;
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public Censor()
	{
	}

	// Token: 0x0400011C RID: 284
	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0x18")]
	private IList<string> CensoredWords;

	// Token: 0x0400011D RID: 285
	[Token(Token = "0x400011D")]
	[FieldOffset(Offset = "0x20")]
	private IList<string> OKWords;
}
