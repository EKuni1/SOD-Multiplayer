using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005CF RID: 1487
[Token(Token = "0x20005CF")]
public class BankStatementContentController : MonoBehaviour
{
	// Token: 0x060020AE RID: 8366 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020AE")]
	[Address(RVA = "0xAE5C70", Offset = "0xAE4C70", VA = "0x180AE5C70")]
	private void OnEnable()
	{
	}

	// Token: 0x060020AF RID: 8367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020AF")]
	[Address(RVA = "0xAE6190", Offset = "0xAE5190", VA = "0x180AE6190")]
	private void OnDisable()
	{
	}

	// Token: 0x060020B0 RID: 8368 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020B0")]
	[Address(RVA = "0xAE6430", Offset = "0xAE5430", VA = "0x180AE6430")]
	public void CheckEnabled()
	{
	}

	// Token: 0x060020B1 RID: 8369 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020B1")]
	[Address(RVA = "0xAE7B80", Offset = "0xAE6B80", VA = "0x180AE7B80")]
	public BankStatementContentController()
	{
	}

	// Token: 0x04002A40 RID: 10816
	[Token(Token = "0x4002A40")]
	[FieldOffset(Offset = "0x18")]
	public WindowContentController windowContent;

	// Token: 0x04002A41 RID: 10817
	[Token(Token = "0x4002A41")]
	[FieldOffset(Offset = "0x20")]
	public InfoWindow parentWindow;

	// Token: 0x04002A42 RID: 10818
	[Token(Token = "0x4002A42")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI descriptionText;

	// Token: 0x04002A43 RID: 10819
	[Token(Token = "0x4002A43")]
	[FieldOffset(Offset = "0x30")]
	public GameObject entryPrefab;

	// Token: 0x04002A44 RID: 10820
	[Token(Token = "0x4002A44")]
	[FieldOffset(Offset = "0x38")]
	public string transactionMessageID;

	// Token: 0x04002A45 RID: 10821
	[Token(Token = "0x4002A45")]
	[FieldOffset(Offset = "0x40")]
	public VerticalLayoutGroup entryLayoutGroup;

	// Token: 0x04002A46 RID: 10822
	[Token(Token = "0x4002A46")]
	[FieldOffset(Offset = "0x48")]
	public List<BankStatementEntryController> spawnedEntries;

	// Token: 0x020005D0 RID: 1488
	[Token(Token = "0x20005D0")]
	public class Transaction
	{
		// Token: 0x060020B2 RID: 8370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public Transaction()
		{
		}

		// Token: 0x04002A47 RID: 10823
		[Token(Token = "0x4002A47")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		// Token: 0x04002A48 RID: 10824
		[Token(Token = "0x4002A48")]
		[FieldOffset(Offset = "0x18")]
		public int amount;
	}

	// Token: 0x020005D1 RID: 1489
	[Token(Token = "0x20005D1")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x060020B3 RID: 8371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		[Token(Token = "0x60020B4")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <CheckEnabled>b__0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04002A49 RID: 10825
		[Token(Token = "0x4002A49")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait t;
	}

	// Token: 0x020005D2 RID: 1490
	[Token(Token = "0x20005D2")]
	private sealed class <>c__DisplayClass10_1
	{
		// Token: 0x060020B5 RID: 8373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass10_1()
		{
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		[Token(Token = "0x60020B6")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <CheckEnabled>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04002A4A RID: 10826
		[Token(Token = "0x4002A4A")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait t;
	}
}
