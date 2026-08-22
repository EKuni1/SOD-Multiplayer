using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200041F RID: 1055
[Token(Token = "0x200041F")]
public class ElevatorKillBox : MonoBehaviour
{
	// Token: 0x060017D0 RID: 6096 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017D0")]
	[Address(RVA = "0x8A4CB0", Offset = "0x8A3CB0", VA = "0x1808A4CB0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060017D1 RID: 6097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017D1")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ElevatorKillBox()
	{
	}

	// Token: 0x04001D1D RID: 7453
	[Token(Token = "0x4001D1D")]
	[FieldOffset(Offset = "0x18")]
	public Elevator elevator;

	// Token: 0x04001D1E RID: 7454
	[Token(Token = "0x4001D1E")]
	[FieldOffset(Offset = "0x20")]
	public ElevatorKillBox.CrushType crushType;

	// Token: 0x02000420 RID: 1056
	[Token(Token = "0x2000420")]
	public enum CrushType
	{
		// Token: 0x04001D20 RID: 7456
		[Token(Token = "0x4001D20")]
		whenElevatorMovesDown,
		// Token: 0x04001D21 RID: 7457
		[Token(Token = "0x4001D21")]
		whenElevatorMovesUp,
		// Token: 0x04001D22 RID: 7458
		[Token(Token = "0x4001D22")]
		either
	}
}
