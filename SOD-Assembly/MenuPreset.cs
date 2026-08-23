using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000840 RID: 2112
[Token(Token = "0x2000840")]
public class MenuPreset : SoCustomComparison
{
	// Token: 0x060029BC RID: 10684 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029BC")]
	[Address(RVA = "0xCACE00", Offset = "0xCABE00", VA = "0x180CACE00")]
	public MenuPreset()
	{
	}

	// Token: 0x04003F95 RID: 16277
	[Token(Token = "0x4003F95")]
	[FieldOffset(Offset = "0x20")]
	public List<InteractablePreset> itemsSold;

	// Token: 0x04003F96 RID: 16278
	[Token(Token = "0x4003F96")]
	[FieldOffset(Offset = "0x28")]
	public bool createReceipt;

	// Token: 0x04003F97 RID: 16279
	[Token(Token = "0x4003F97")]
	[FieldOffset(Offset = "0x30")]
	public AudioEvent purchaseAudio;

	// Token: 0x04003F98 RID: 16280
	[Token(Token = "0x4003F98")]
	[FieldOffset(Offset = "0x38")]
	public int syncDiskSlots;

	// Token: 0x04003F99 RID: 16281
	[Token(Token = "0x4003F99")]
	[FieldOffset(Offset = "0x40")]
	public List<SyncDiskPreset.Manufacturer> fromManufacturers;

	// Token: 0x04003F9A RID: 16282
	[Token(Token = "0x4003F9A")]
	[FieldOffset(Offset = "0x48")]
	public List<SyncDiskPreset> syncDisks;
}
