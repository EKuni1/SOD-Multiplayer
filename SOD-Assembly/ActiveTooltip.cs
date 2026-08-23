using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000550 RID: 1360
[Token(Token = "0x2000550")]
public class ActiveTooltip : MonoBehaviour
{
	// Token: 0x06001D7F RID: 7551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D7F")]
	[Address(RVA = "0xA2AD90", Offset = "0xA29D90", VA = "0x180A2AD90")]
	private void Update()
	{
	}

	// Token: 0x06001D80 RID: 7552 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D80")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ActiveTooltip()
	{
	}

	// Token: 0x04002619 RID: 9753
	[Token(Token = "0x4002619")]
	[FieldOffset(Offset = "0x18")]
	public bool setupComplete;

	// Token: 0x0400261A RID: 9754
	[Token(Token = "0x400261A")]
	[FieldOffset(Offset = "0x20")]
	public TooltipController ttc;
}
