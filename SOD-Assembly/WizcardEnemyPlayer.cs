using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002F2 RID: 754
[Token(Token = "0x20002F2")]
public class WizcardEnemyPlayer : MonoBehaviour
{
	// Token: 0x17000086 RID: 134
	// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00008568 File Offset: 0x00006768
	// (set) Token: 0x060010A4 RID: 4260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000086")]
	public int enemyMana
	{
		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x6AA670", Offset = "0x6A9670", VA = "0x1806AA670")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60010A4")]
		[Address(RVA = "0x6AA680", Offset = "0x6A9680", VA = "0x1806AA680")]
		set
		{
		}
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010A5")]
	[Address(RVA = "0x6AA690", Offset = "0x6A9690", VA = "0x1806AA690")]
	public WizcardEnemyPlayer()
	{
	}

	// Token: 0x04001433 RID: 5171
	[Token(Token = "0x4001433")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] enemyDeck;

	// Token: 0x04001434 RID: 5172
	[Token(Token = "0x4001434")]
	[FieldOffset(Offset = "0x20")]
	private int _mana;
}
