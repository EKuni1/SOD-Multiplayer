using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002F4 RID: 756
[Token(Token = "0x20002F4")]
public class WizcardStats : MonoBehaviour
{
	// Token: 0x060010A9 RID: 4265 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010A9")]
	[Address(RVA = "0x6AA700", Offset = "0x6A9700", VA = "0x1806AA700")]
	private void Start()
	{
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010AA")]
	[Address(RVA = "0x6AA820", Offset = "0x6A9820", VA = "0x1806AA820")]
	public void UpdateStats()
	{
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010AB")]
	[Address(RVA = "0x6AAF40", Offset = "0x6A9F40", VA = "0x1806AAF40")]
	public WizcardStats()
	{
	}

	// Token: 0x04001437 RID: 5175
	[Token(Token = "0x4001437")]
	[FieldOffset(Offset = "0x18")]
	private BoardSpace boardSpace;

	// Token: 0x04001438 RID: 5176
	[Token(Token = "0x4001438")]
	[FieldOffset(Offset = "0x20")]
	private TextMeshProUGUI textMeshPro;

	// Token: 0x04001439 RID: 5177
	[Token(Token = "0x4001439")]
	[FieldOffset(Offset = "0x28")]
	public WizcardStats.CopyStat copyStat;

	// Token: 0x020002F5 RID: 757
	[Token(Token = "0x20002F5")]
	public enum CopyStat
	{
		// Token: 0x0400143B RID: 5179
		[Token(Token = "0x400143B")]
		None,
		// Token: 0x0400143C RID: 5180
		[Token(Token = "0x400143C")]
		Attack,
		// Token: 0x0400143D RID: 5181
		[Token(Token = "0x400143D")]
		Health,
		// Token: 0x0400143E RID: 5182
		[Token(Token = "0x400143E")]
		Both
	}

	// Token: 0x020002F6 RID: 758
	[Token(Token = "0x20002F6")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060010AD RID: 4269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010AD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00008598 File Offset: 0x00006798
		[Token(Token = "0x60010AE")]
		[Address(RVA = "0x6AB040", Offset = "0x6AA040", VA = "0x1806AB040")]
		internal bool <UpdateStats>b__5_0(string s)
		{
			return default(bool);
		}

		// Token: 0x0400143F RID: 5183
		[Token(Token = "0x400143F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly WizcardStats.<>c <>9;

		// Token: 0x04001440 RID: 5184
		[Token(Token = "0x4001440")]
		[FieldOffset(Offset = "0x8")]
		public static Func<string, bool> <>9__5_0;
	}
}
