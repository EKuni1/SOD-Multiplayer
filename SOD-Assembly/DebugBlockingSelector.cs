using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000221 RID: 545
[Token(Token = "0x2000221")]
public class DebugBlockingSelector : MonoBehaviour
{
	// Token: 0x06000C87 RID: 3207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C87")]
	[Address(RVA = "0x59A680", Offset = "0x599680", VA = "0x18059A680")]
	public void Setup(WalkableRecorder.TileSetup newTile, CityData.BlockingDirection newDir, WalkableRecorder newRecorder, Vector2 newOffset)
	{
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C88")]
	[Address(RVA = "0x59A840", Offset = "0x599840", VA = "0x18059A840")]
	public void SetB()
	{
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C89")]
	[Address(RVA = "0x59A850", Offset = "0x599850", VA = "0x18059A850")]
	public void SetUB()
	{
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C8A")]
	[Address(RVA = "0x59A860", Offset = "0x599860", VA = "0x18059A860")]
	private void SetBlocked(bool val)
	{
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C8B")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public DebugBlockingSelector()
	{
	}

	// Token: 0x04000DC5 RID: 3525
	[Token(Token = "0x4000DC5")]
	[FieldOffset(Offset = "0x18")]
	public WalkableRecorder.TileSetup tile;

	// Token: 0x04000DC6 RID: 3526
	[Token(Token = "0x4000DC6")]
	[FieldOffset(Offset = "0x20")]
	public CityData.BlockingDirection dir;

	// Token: 0x04000DC7 RID: 3527
	[Token(Token = "0x4000DC7")]
	[FieldOffset(Offset = "0x28")]
	public MeshRenderer rend;

	// Token: 0x04000DC8 RID: 3528
	[Token(Token = "0x4000DC8")]
	[FieldOffset(Offset = "0x30")]
	public bool blocked;

	// Token: 0x04000DC9 RID: 3529
	[Token(Token = "0x4000DC9")]
	[FieldOffset(Offset = "0x38")]
	public WalkableRecorder recorder;

	// Token: 0x04000DCA RID: 3530
	[Token(Token = "0x4000DCA")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 offset;
}
