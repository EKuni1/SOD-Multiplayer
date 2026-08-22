using System;
using Il2CppDummyDll;

// Token: 0x02000185 RID: 389
[Token(Token = "0x2000185")]
public class BlocksCreator : Creator
{
	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000037")]
	public static BlocksCreator Instance
	{
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x52F110", Offset = "0x52E110", VA = "0x18052F110")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A01")]
	[Address(RVA = "0x52F150", Offset = "0x52E150", VA = "0x18052F150")]
	private void Awake()
	{
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A02")]
	[Address(RVA = "0x52F4A0", Offset = "0x52E4A0", VA = "0x18052F4A0", Slot = "4")]
	public override void StartLoading()
	{
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A03")]
	[Address(RVA = "0x52F510", Offset = "0x52E510", VA = "0x18052F510")]
	public BlocksCreator()
	{
	}

	// Token: 0x04000A2C RID: 2604
	[Token(Token = "0x4000A2C")]
	[FieldOffset(Offset = "0x18")]
	public int loadChunk;

	// Token: 0x04000A2D RID: 2605
	[Token(Token = "0x4000A2D")]
	[FieldOffset(Offset = "0x0")]
	private static BlocksCreator _instance;
}
