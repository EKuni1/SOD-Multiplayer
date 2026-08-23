using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005E2 RID: 1506
[Token(Token = "0x20005E2")]
public class BuyInterfaceController : MonoBehaviour
{
	// Token: 0x06002106 RID: 8454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002106")]
	[Address(RVA = "0xAF2BA0", Offset = "0xAF1BA0", VA = "0x180AF2BA0")]
	public void Setup(WindowContentController newWcc)
	{
	}

	// Token: 0x06002107 RID: 8455 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002107")]
	[Address(RVA = "0xAF2C00", Offset = "0xAF1C00", VA = "0x180AF2C00")]
	private void OnEnable()
	{
	}

	// Token: 0x06002108 RID: 8456 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002108")]
	[Address(RVA = "0xAF2C30", Offset = "0xAF1C30", VA = "0x180AF2C30")]
	public void UpdateElements()
	{
	}

	// Token: 0x06002109 RID: 8457 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002109")]
	[Address(RVA = "0xAF4D10", Offset = "0xAF3D10", VA = "0x180AF4D10")]
	public void UpdatePurchaseAbility()
	{
	}

	// Token: 0x0600210A RID: 8458 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600210A")]
	[Address(RVA = "0xAF4E60", Offset = "0xAF3E60", VA = "0x180AF4E60")]
	public BuyInterfaceController()
	{
	}

	// Token: 0x04002AB9 RID: 10937
	[Token(Token = "0x4002AB9")]
	[FieldOffset(Offset = "0x18")]
	public bool sellMode;

	// Token: 0x04002ABA RID: 10938
	[Token(Token = "0x4002ABA")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform pageRect;

	// Token: 0x04002ABB RID: 10939
	[Token(Token = "0x4002ABB")]
	[FieldOffset(Offset = "0x28")]
	public WindowContentController wcc;

	// Token: 0x04002ABC RID: 10940
	[Token(Token = "0x4002ABC")]
	[FieldOffset(Offset = "0x30")]
	public Company company;

	// Token: 0x04002ABD RID: 10941
	[Token(Token = "0x4002ABD")]
	[FieldOffset(Offset = "0x38")]
	public GameObject elementPrefab;

	// Token: 0x04002ABE RID: 10942
	[Token(Token = "0x4002ABE")]
	[FieldOffset(Offset = "0x40")]
	private List<ShopSelectButtonController> spawned;

	// Token: 0x020005E3 RID: 1507
	[Token(Token = "0x20005E3")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x0600210B RID: 8459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x0000E058 File Offset: 0x0000C258
		[Token(Token = "0x600210C")]
		[Address(RVA = "0xAF4F60", Offset = "0xAF3F60", VA = "0x180AF4F60")]
		internal bool <UpdateElements>b__0(SyncDiskPreset item)
		{
			return default(bool);
		}

		// Token: 0x04002ABF RID: 10943
		[Token(Token = "0x4002ABF")]
		[FieldOffset(Offset = "0x10")]
		public SyncDiskPreset newDisk;
	}
}
