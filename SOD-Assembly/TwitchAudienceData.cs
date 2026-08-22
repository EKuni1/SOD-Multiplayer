using System;
using Il2CppDummyDll;

// Token: 0x0200051E RID: 1310
[Token(Token = "0x200051E")]
[Serializable]
public class TwitchAudienceData
{
	// Token: 0x06001C17 RID: 7191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C17")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public TwitchAudienceData()
	{
	}

	// Token: 0x040024D8 RID: 9432
	[Token(Token = "0x40024D8")]
	[FieldOffset(Offset = "0x10")]
	public string user_id;

	// Token: 0x040024D9 RID: 9433
	[Token(Token = "0x40024D9")]
	[FieldOffset(Offset = "0x18")]
	public string login;

	// Token: 0x040024DA RID: 9434
	[Token(Token = "0x40024DA")]
	[FieldOffset(Offset = "0x20")]
	public string _links;

	// Token: 0x040024DB RID: 9435
	[Token(Token = "0x40024DB")]
	[FieldOffset(Offset = "0x28")]
	public int chatter_count;

	// Token: 0x040024DC RID: 9436
	[Token(Token = "0x40024DC")]
	[FieldOffset(Offset = "0x30")]
	public Chatters chatters;

	// Token: 0x040024DD RID: 9437
	[Token(Token = "0x40024DD")]
	[FieldOffset(Offset = "0x38")]
	public TwitchRootObject followers;

	// Token: 0x040024DE RID: 9438
	[Token(Token = "0x40024DE")]
	[FieldOffset(Offset = "0x40")]
	public TwitchRootObject chattersNew;

	// Token: 0x040024DF RID: 9439
	[Token(Token = "0x40024DF")]
	[FieldOffset(Offset = "0x48")]
	public TwitchRootObject vipsNew;

	// Token: 0x040024E0 RID: 9440
	[Token(Token = "0x40024E0")]
	[FieldOffset(Offset = "0x50")]
	public TwitchRootObject moderatorsNew;
}
