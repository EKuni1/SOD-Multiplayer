using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000245 RID: 581
[Token(Token = "0x2000245")]
public class FloorEditWallDetector : MonoBehaviour
{
	// Token: 0x06000D46 RID: 3398 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D46")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public FloorEditWallDetector()
	{
	}

	// Token: 0x04000EB4 RID: 3764
	[Token(Token = "0x4000EB4")]
	[FieldOffset(Offset = "0x18")]
	public NewWall wall;

	// Token: 0x04000EB5 RID: 3765
	[Token(Token = "0x4000EB5")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 debugNodePosition;

	// Token: 0x04000EB6 RID: 3766
	[Token(Token = "0x4000EB6")]
	[FieldOffset(Offset = "0x2C")]
	public int debugFloorHeight;
}
