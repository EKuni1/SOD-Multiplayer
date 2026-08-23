using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200054C RID: 1356
[Token(Token = "0x200054C")]
public class ShardController : MonoBehaviour
{
	// Token: 0x06001D6E RID: 7534 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D6E")]
	[Address(RVA = "0xA29C60", Offset = "0xA28C60", VA = "0x180A29C60")]
	private void Awake()
	{
	}

	// Token: 0x06001D6F RID: 7535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D6F")]
	[Address(RVA = "0xA29D40", Offset = "0xA28D40", VA = "0x180A29D40")]
	private void Update()
	{
	}

	// Token: 0x06001D70 RID: 7536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D70")]
	[Address(RVA = "0xA29EB0", Offset = "0xA28EB0", VA = "0x180A29EB0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001D71 RID: 7537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D71")]
	[Address(RVA = "0xA29F50", Offset = "0xA28F50", VA = "0x180A29F50")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001D72 RID: 7538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D72")]
	[Address(RVA = "0xA29F90", Offset = "0xA28F90", VA = "0x180A29F90")]
	public ShardController()
	{
	}

	// Token: 0x04002608 RID: 9736
	[Token(Token = "0x4002608")]
	[FieldOffset(Offset = "0x18")]
	public float baseTime;

	// Token: 0x04002609 RID: 9737
	[Token(Token = "0x4002609")]
	[FieldOffset(Offset = "0x1C")]
	public float timer;

	// Token: 0x0400260A RID: 9738
	[Token(Token = "0x400260A")]
	[FieldOffset(Offset = "0x0")]
	public static int shardCounter;
}
