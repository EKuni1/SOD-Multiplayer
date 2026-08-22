using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200061C RID: 1564
[Token(Token = "0x200061C")]
public class SalesLedgerContentController : MonoBehaviour
{
	// Token: 0x0600225C RID: 8796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600225C")]
	[Address(RVA = "0xB2E200", Offset = "0xB2D200", VA = "0x180B2E200")]
	private void OnEnable()
	{
	}

	// Token: 0x0600225D RID: 8797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600225D")]
	[Address(RVA = "0xB2E650", Offset = "0xB2D650", VA = "0x180B2E650")]
	private void OnDisable()
	{
	}

	// Token: 0x0600225E RID: 8798 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600225E")]
	[Address(RVA = "0xB2E8F0", Offset = "0xB2D8F0", VA = "0x180B2E8F0")]
	public void CheckEnabled()
	{
	}

	// Token: 0x0600225F RID: 8799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600225F")]
	[Address(RVA = "0xB2F1D0", Offset = "0xB2E1D0", VA = "0x180B2F1D0")]
	public SalesLedgerContentController()
	{
	}

	// Token: 0x04002BF9 RID: 11257
	[Token(Token = "0x4002BF9")]
	[FieldOffset(Offset = "0x18")]
	public WindowContentController windowContent;

	// Token: 0x04002BFA RID: 11258
	[Token(Token = "0x4002BFA")]
	[FieldOffset(Offset = "0x20")]
	public InfoWindow parentWindow;

	// Token: 0x04002BFB RID: 11259
	[Token(Token = "0x4002BFB")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI descriptionText;

	// Token: 0x04002BFC RID: 11260
	[Token(Token = "0x4002BFC")]
	[FieldOffset(Offset = "0x30")]
	public GameObject entryPrefab;

	// Token: 0x04002BFD RID: 11261
	[Token(Token = "0x4002BFD")]
	[FieldOffset(Offset = "0x38")]
	public List<SalesLedgerEntryController> spawnedEntries;

	// Token: 0x0200061D RID: 1565
	[Token(Token = "0x200061D")]
	public class Transaction
	{
		// Token: 0x06002260 RID: 8800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002260")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public Transaction()
		{
		}

		// Token: 0x04002BFE RID: 11262
		[Token(Token = "0x4002BFE")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		// Token: 0x04002BFF RID: 11263
		[Token(Token = "0x4002BFF")]
		[FieldOffset(Offset = "0x18")]
		public int amount;
	}

	// Token: 0x0200061E RID: 1566
	[Token(Token = "0x200061E")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002262 RID: 8802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002262")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x0000E280 File Offset: 0x0000C480
		[Token(Token = "0x6002263")]
		[Address(RVA = "0xB2F380", Offset = "0xB2E380", VA = "0x180B2F380")]
		internal int <CheckEnabled>b__8_0(Company.SalesRecord p1, Company.SalesRecord p2)
		{
			return 0;
		}

		// Token: 0x04002C00 RID: 11264
		[Token(Token = "0x4002C00")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SalesLedgerContentController.<>c <>9;

		// Token: 0x04002C01 RID: 11265
		[Token(Token = "0x4002C01")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<Company.SalesRecord> <>9__8_0;
	}
}
