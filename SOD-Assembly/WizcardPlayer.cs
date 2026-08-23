using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002F3 RID: 755
[Token(Token = "0x20002F3")]
public class WizcardPlayer : MonoBehaviour
{
	// Token: 0x17000087 RID: 135
	// (get) Token: 0x060010A6 RID: 4262 RVA: 0x00008580 File Offset: 0x00006780
	// (set) Token: 0x060010A7 RID: 4263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000087")]
	public int mana
	{
		[Token(Token = "0x60010A6")]
		[Address(RVA = "0x6AA6E0", Offset = "0x6A96E0", VA = "0x1806AA6E0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60010A7")]
		[Address(RVA = "0x6AA6F0", Offset = "0x6A96F0", VA = "0x1806AA6F0")]
		set
		{
		}
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010A8")]
	[Address(RVA = "0x52F510", Offset = "0x52E510", VA = "0x18052F510")]
	public WizcardPlayer()
	{
	}

	// Token: 0x04001435 RID: 5173
	[Token(Token = "0x4001435")]
	[FieldOffset(Offset = "0x18")]
	private int _mana;

	// Token: 0x04001436 RID: 5174
	[Token(Token = "0x4001436")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] WizcardDeck;
}
