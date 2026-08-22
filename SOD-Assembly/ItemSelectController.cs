using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000609 RID: 1545
[Token(Token = "0x2000609")]
public class ItemSelectController : MonoBehaviour
{
	// Token: 0x06002203 RID: 8707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002203")]
	[Address(RVA = "0xB1FC10", Offset = "0xB1EC10", VA = "0x180B1FC10")]
	public void Setup(WindowContentController newWcc)
	{
	}

	// Token: 0x06002204 RID: 8708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002204")]
	[Address(RVA = "0xB201E0", Offset = "0xB1F1E0", VA = "0x180B201E0")]
	public ItemSelectController()
	{
	}

	// Token: 0x04002BB0 RID: 11184
	[Token(Token = "0x4002BB0")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform pageRect;

	// Token: 0x04002BB1 RID: 11185
	[Token(Token = "0x4002BB1")]
	[FieldOffset(Offset = "0x20")]
	public WindowContentController wcc;

	// Token: 0x04002BB2 RID: 11186
	[Token(Token = "0x4002BB2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject selectPrefab;

	// Token: 0x04002BB3 RID: 11187
	[Token(Token = "0x4002BB3")]
	[FieldOffset(Offset = "0x30")]
	private List<ItemSelectButtonController> spawned;
}
