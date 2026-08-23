using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000857 RID: 2135
[Token(Token = "0x2000857")]
public class MurderWeaponsPool : SoCustomComparison
{
	// Token: 0x060029CC RID: 10700 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029CC")]
	[Address(RVA = "0xCAF650", Offset = "0xCAE650", VA = "0x180CAF650")]
	public MurderWeaponsPool()
	{
	}

	// Token: 0x040040A5 RID: 16549
	[Token(Token = "0x40040A5")]
	[FieldOffset(Offset = "0x20")]
	public List<MurderWeaponsPool.MurderWeaponPick> murderWeaponPool;

	// Token: 0x02000858 RID: 2136
	[Token(Token = "0x2000858")]
	[Serializable]
	public class MurderWeaponPick
	{
		// Token: 0x060029CD RID: 10701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029CD")]
		[Address(RVA = "0xCAF720", Offset = "0xCAE720", VA = "0x180CAF720")]
		public MurderWeaponPick()
		{
		}

		// Token: 0x040040A6 RID: 16550
		[Token(Token = "0x40040A6")]
		[FieldOffset(Offset = "0x10")]
		public InteractablePreset weapon;

		// Token: 0x040040A7 RID: 16551
		[Token(Token = "0x40040A7")]
		[FieldOffset(Offset = "0x18")]
		public float chanceOfDroppingAtScene;

		// Token: 0x040040A8 RID: 16552
		[Token(Token = "0x40040A8")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 randomScoreRange;

		// Token: 0x040040A9 RID: 16553
		[Token(Token = "0x40040A9")]
		[FieldOffset(Offset = "0x28")]
		public List<MurderPreset.MurdererModifierRule> traitModifiers;
	}
}
