using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BD RID: 445
[Token(Token = "0x20001BD")]
public class FastVector3Comparer : IEnumerator<object>
{
	// Token: 0x06000B0B RID: 2827 RVA: 0x00006A98 File Offset: 0x00004C98
	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0x54B350", Offset = "0x54A350", VA = "0x18054B350", Slot = "4")]
	private bool Equals(Vector3 x, Vector3 y)
	{
		return default(bool);
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x00006AB0 File Offset: 0x00004CB0
	[Token(Token = "0x6000B0C")]
	[Address(RVA = "0x54B400", Offset = "0x54A400", VA = "0x18054B400", Slot = "5")]
	private int GetHashCode(Vector3 obj)
	{
		return 0;
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700006B")]
	public static FastVector3Comparer SharedFastVector3Comparer
	{
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x54B4A0", Offset = "0x54A4A0", VA = "0x18054B4A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000B0E RID: 2830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B0E")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public FastVector3Comparer()
	{
	}

	// Token: 0x04000AE6 RID: 2790
	[Token(Token = "0x4000AE6")]
	[FieldOffset(Offset = "0x0")]
	private static FastVector3Comparer sharedFastVector3Comparer;
}
