using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000039 RID: 57
[Token(Token = "0x2000039")]
public class MapScroller : MonoBehaviour
{
	// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x5CBE20", Offset = "0x5CAE20", VA = "0x1805CBE20")]
	private void Awake()
	{
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x5CBEB0", Offset = "0x5CAEB0", VA = "0x1805CBEB0")]
	private void Update()
	{
	}

	// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x5CC060", Offset = "0x5CB060", VA = "0x1805CC060")]
	public MapScroller()
	{
	}

	// Token: 0x04000129 RID: 297
	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x18")]
	public bool controlEnabled;

	// Token: 0x0400012A RID: 298
	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x20")]
	private CustomScrollRect _scrollRect;

	// Token: 0x0400012B RID: 299
	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x28")]
	public float sensitivity;
}
