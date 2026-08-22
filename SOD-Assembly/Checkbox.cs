using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000568 RID: 1384
[Token(Token = "0x2000568")]
public class Checkbox : MonoBehaviour
{
	// Token: 0x06001E27 RID: 7719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E27")]
	[Address(RVA = "0xA46970", Offset = "0xA45970", VA = "0x180A46970")]
	private void Awake()
	{
	}

	// Token: 0x06001E28 RID: 7720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E28")]
	[Address(RVA = "0xA469B0", Offset = "0xA459B0", VA = "0x180A469B0")]
	public void Toggle()
	{
	}

	// Token: 0x06001E29 RID: 7721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E29")]
	[Address(RVA = "0xA46B20", Offset = "0xA45B20", VA = "0x180A46B20")]
	public void Set(bool setTo)
	{
	}

	// Token: 0x06001E2A RID: 7722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E2A")]
	[Address(RVA = "0xA46970", Offset = "0xA45970", VA = "0x180A46970")]
	public void SetImage()
	{
	}

	// Token: 0x06001E2B RID: 7723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E2B")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public Checkbox()
	{
	}

	// Token: 0x040026A3 RID: 9891
	[Token(Token = "0x40026A3")]
	[FieldOffset(Offset = "0x18")]
	public bool ticked;

	// Token: 0x040026A4 RID: 9892
	[Token(Token = "0x40026A4")]
	[FieldOffset(Offset = "0x20")]
	public Image graphic;

	// Token: 0x040026A5 RID: 9893
	[Token(Token = "0x40026A5")]
	[FieldOffset(Offset = "0x28")]
	public Sprite unTickedSprite;

	// Token: 0x040026A6 RID: 9894
	[Token(Token = "0x40026A6")]
	[FieldOffset(Offset = "0x30")]
	public Sprite tickedSprite;

	// Token: 0x040026A7 RID: 9895
	[Token(Token = "0x40026A7")]
	[FieldOffset(Offset = "0x38")]
	public Checkbox orCheckbox;
}
