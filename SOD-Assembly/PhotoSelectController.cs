using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000618 RID: 1560
[Token(Token = "0x2000618")]
public class PhotoSelectController : MonoBehaviour
{
	// Token: 0x06002247 RID: 8775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002247")]
	[Address(RVA = "0xB2B530", Offset = "0xB2A530", VA = "0x180B2B530")]
	public void Setup(WindowContentController newWcc)
	{
	}

	// Token: 0x06002248 RID: 8776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002248")]
	[Address(RVA = "0xB2C060", Offset = "0xB2B060", VA = "0x180B2C060")]
	public PhotoSelectController()
	{
	}

	// Token: 0x04002BE7 RID: 11239
	[Token(Token = "0x4002BE7")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform pageRect;

	// Token: 0x04002BE8 RID: 11240
	[Token(Token = "0x4002BE8")]
	[FieldOffset(Offset = "0x20")]
	public WindowContentController wcc;

	// Token: 0x04002BE9 RID: 11241
	[Token(Token = "0x4002BE9")]
	[FieldOffset(Offset = "0x28")]
	public GameObject photoPrefab;

	// Token: 0x04002BEA RID: 11242
	[Token(Token = "0x4002BEA")]
	[FieldOffset(Offset = "0x30")]
	private List<PhotoSelectButtonController> spawned;

	// Token: 0x02000619 RID: 1561
	[Token(Token = "0x2000619")]
	public class CitAsk
	{
		// Token: 0x06002249 RID: 8777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002249")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public CitAsk()
		{
		}

		// Token: 0x04002BEB RID: 11243
		[Token(Token = "0x4002BEB")]
		[FieldOffset(Offset = "0x10")]
		public Human citizen;

		// Token: 0x04002BEC RID: 11244
		[Token(Token = "0x4002BEC")]
		[FieldOffset(Offset = "0x18")]
		public Case.CaseElement element;
	}
}
