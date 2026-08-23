using System;
using Il2CppDummyDll;
using Steamworks;

// Token: 0x0200050C RID: 1292
[Token(Token = "0x200050C")]
[Serializable]
public class SteamMod
{
	// Token: 0x06001BC6 RID: 7110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BC6")]
	[Address(RVA = "0x9C6C30", Offset = "0x9C5C30", VA = "0x1809C6C30")]
	public SteamMod(string path, PublishedFileId_t fileId)
	{
	}

	// Token: 0x0400247C RID: 9340
	[Token(Token = "0x400247C")]
	[FieldOffset(Offset = "0x10")]
	public string installPath;

	// Token: 0x0400247D RID: 9341
	[Token(Token = "0x400247D")]
	[FieldOffset(Offset = "0x18")]
	public PublishedFileId_t PublishedFileIdT;

	// Token: 0x0400247E RID: 9342
	[Token(Token = "0x400247E")]
	[FieldOffset(Offset = "0x20")]
	public bool isEnabled;

	// Token: 0x0400247F RID: 9343
	[Token(Token = "0x400247F")]
	[FieldOffset(Offset = "0x24")]
	public int orderToLoad;
}
