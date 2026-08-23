using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000683 RID: 1667
[Token(Token = "0x2000683")]
public class PageBasedContent : MonoBehaviour
{
	// Token: 0x060024ED RID: 9453 RVA: 0x0000EB20 File Offset: 0x0000CD20
	[Token(Token = "0x60024ED")]
	[Address(RVA = "0xBAA290", Offset = "0xBA9290", VA = "0x180BAA290", Slot = "4")]
	public virtual int GetMaxPages()
	{
		return 0;
	}

	// Token: 0x060024EE RID: 9454 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024EE")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
	public virtual void UpdateListDisplay()
	{
	}

	// Token: 0x060024EF RID: 9455 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024EF")]
	[Address(RVA = "0xBAA2A0", Offset = "0xBA92A0", VA = "0x180BAA2A0")]
	public PageBasedContent()
	{
	}

	// Token: 0x04002F0B RID: 12043
	[Token(Token = "0x4002F0B")]
	[FieldOffset(Offset = "0x18")]
	public int elementsPerPage;
}
