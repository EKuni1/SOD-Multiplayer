using System;
using Il2CppDummyDll;
using Steamworks;

// Token: 0x0200050B RID: 1291
[Token(Token = "0x200050B")]
internal struct SteamWorkshopItem
{
	// Token: 0x06001BC5 RID: 7109 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
	[Token(Token = "0x6001BC5")]
	[Address(RVA = "0x9C6B30", Offset = "0x9C5B30", VA = "0x1809C6B30")]
	public SteamWorkshopItem ParseItem(UGCQueryHandle_t p_handle, uint p_indexInHandle, SteamUGCDetails_t p_itemDetails)
	{
		return default(SteamWorkshopItem);
	}

	// Token: 0x04002474 RID: 9332
	[Token(Token = "0x4002474")]
	[FieldOffset(Offset = "0x0")]
	public string ContentFolderPath;

	// Token: 0x04002475 RID: 9333
	[Token(Token = "0x4002475")]
	[FieldOffset(Offset = "0x8")]
	public string Description;

	// Token: 0x04002476 RID: 9334
	[Token(Token = "0x4002476")]
	[FieldOffset(Offset = "0x10")]
	public string PreviewImagePath;

	// Token: 0x04002477 RID: 9335
	[Token(Token = "0x4002477")]
	[FieldOffset(Offset = "0x18")]
	public string[] Tags;

	// Token: 0x04002478 RID: 9336
	[Token(Token = "0x4002478")]
	[FieldOffset(Offset = "0x20")]
	public string Title;

	// Token: 0x04002479 RID: 9337
	[Token(Token = "0x4002479")]
	[FieldOffset(Offset = "0x28")]
	public string Name;

	// Token: 0x0400247A RID: 9338
	[Token(Token = "0x400247A")]
	[FieldOffset(Offset = "0x30")]
	public string OwnerName;

	// Token: 0x0400247B RID: 9339
	[Token(Token = "0x400247B")]
	[FieldOffset(Offset = "0x38")]
	public string PreviewImageURL;
}
