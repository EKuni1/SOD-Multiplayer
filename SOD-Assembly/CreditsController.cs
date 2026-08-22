using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000577 RID: 1399
[Token(Token = "0x2000577")]
public class CreditsController : MonoBehaviour
{
	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06001E59 RID: 7769 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000F1")]
	public static CreditsController Instance
	{
		[Token(Token = "0x6001E59")]
		[Address(RVA = "0xA4E8E0", Offset = "0xA4D8E0", VA = "0x180A4E8E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001E5A RID: 7770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E5A")]
	[Address(RVA = "0xA4E920", Offset = "0xA4D920", VA = "0x180A4E920")]
	private void Awake()
	{
	}

	// Token: 0x06001E5B RID: 7771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E5B")]
	[Address(RVA = "0xA4ECB0", Offset = "0xA4DCB0", VA = "0x180A4ECB0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001E5C RID: 7772 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E5C")]
	[Address(RVA = "0xA4EEC0", Offset = "0xA4DEC0", VA = "0x180A4EEC0")]
	public string GetFormattedCreditsText()
	{
		return null;
	}

	// Token: 0x06001E5D RID: 7773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E5D")]
	[Address(RVA = "0xA4F500", Offset = "0xA4E500", VA = "0x180A4F500")]
	public CreditsController()
	{
	}

	// Token: 0x04002701 RID: 9985
	[Token(Token = "0x4002701")]
	[FieldOffset(Offset = "0x18")]
	public List<CreditsController.CreditCategory> credits;

	// Token: 0x04002702 RID: 9986
	[Token(Token = "0x4002702")]
	[FieldOffset(Offset = "0x0")]
	private static CreditsController _instance;

	// Token: 0x02000578 RID: 1400
	[Token(Token = "0x2000578")]
	[Serializable]
	public class CreditCategory
	{
		// Token: 0x06001E5E RID: 7774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E5E")]
		[Address(RVA = "0xA4F600", Offset = "0xA4E600", VA = "0x180A4F600")]
		public CreditCategory()
		{
		}

		// Token: 0x04002703 RID: 9987
		[Token(Token = "0x4002703")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04002704 RID: 9988
		[Token(Token = "0x4002704")]
		[FieldOffset(Offset = "0x18")]
		public bool localize;

		// Token: 0x04002705 RID: 9989
		[Token(Token = "0x4002705")]
		[FieldOffset(Offset = "0x20")]
		public string extra;

		// Token: 0x04002706 RID: 9990
		[Token(Token = "0x4002706")]
		[FieldOffset(Offset = "0x28")]
		public bool localizeExtra;

		// Token: 0x04002707 RID: 9991
		[Token(Token = "0x4002707")]
		[FieldOffset(Offset = "0x30")]
		public List<CreditsController.CreditEntry> credits;
	}

	// Token: 0x02000579 RID: 1401
	[Token(Token = "0x2000579")]
	[Serializable]
	public class CreditEntry
	{
		// Token: 0x06001E5F RID: 7775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E5F")]
		[Address(RVA = "0xA4F6D0", Offset = "0xA4E6D0", VA = "0x180A4F6D0")]
		public CreditEntry()
		{
		}

		// Token: 0x04002708 RID: 9992
		[Token(Token = "0x4002708")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		// Token: 0x04002709 RID: 9993
		[Token(Token = "0x4002709")]
		[FieldOffset(Offset = "0x18")]
		public List<CreditsController.CreditName> names;
	}

	// Token: 0x0200057A RID: 1402
	[Token(Token = "0x200057A")]
	[Serializable]
	public class CreditName
	{
		// Token: 0x06001E60 RID: 7776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E60")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public CreditName()
		{
		}

		// Token: 0x0400270A RID: 9994
		[Token(Token = "0x400270A")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400270B RID: 9995
		[Token(Token = "0x400270B")]
		[FieldOffset(Offset = "0x18")]
		public string additional;
	}
}
