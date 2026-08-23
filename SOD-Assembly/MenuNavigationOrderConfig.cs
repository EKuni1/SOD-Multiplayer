using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005BD RID: 1469
[Token(Token = "0x20005BD")]
public class MenuNavigationOrderConfig : MonoBehaviour
{
	// Token: 0x0600204F RID: 8271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600204F")]
	[Address(RVA = "0xAD90F0", Offset = "0xAD80F0", VA = "0x180AD90F0")]
	public void Configure()
	{
	}

	// Token: 0x06002050 RID: 8272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002050")]
	[Address(RVA = "0xADA690", Offset = "0xAD9690", VA = "0x180ADA690")]
	public MenuNavigationOrderConfig()
	{
	}

	// Token: 0x040029E9 RID: 10729
	[Token(Token = "0x40029E9")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> contentParentHierarchy;

	// Token: 0x040029EA RID: 10730
	[Token(Token = "0x40029EA")]
	[FieldOffset(Offset = "0x20")]
	public bool leftMovesUpHierarchy;
}
