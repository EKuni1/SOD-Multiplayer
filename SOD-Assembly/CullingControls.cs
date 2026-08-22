using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008B5 RID: 2229
[Token(Token = "0x20008B5")]
public class CullingControls : MonoBehaviour
{
	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06002A2A RID: 10794 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700014F")]
	public static CullingControls Instance
	{
		[Token(Token = "0x6002A2A")]
		[Address(RVA = "0xCB91E0", Offset = "0xCB81E0", VA = "0x180CB91E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002A2B RID: 10795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A2B")]
	[Address(RVA = "0xCB9220", Offset = "0xCB8220", VA = "0x180CB9220")]
	private void Awake()
	{
	}

	// Token: 0x06002A2C RID: 10796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A2C")]
	[Address(RVA = "0xCB9570", Offset = "0xCB8570", VA = "0x180CB9570")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002A2D RID: 10797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A2D")]
	[Address(RVA = "0xCB9780", Offset = "0xCB8780", VA = "0x180CB9780")]
	public CullingControls()
	{
	}

	// Token: 0x04004654 RID: 18004
	[Token(Token = "0x4004654")]
	[FieldOffset(Offset = "0x18")]
	public float visibleBuildingFoV;

	// Token: 0x04004655 RID: 18005
	[Token(Token = "0x4004655")]
	[FieldOffset(Offset = "0x1C")]
	public float visibleRoomFoV;

	// Token: 0x04004656 RID: 18006
	[Token(Token = "0x4004656")]
	[FieldOffset(Offset = "0x20")]
	public float fromOutsideToInsideDistanceMax;

	// Token: 0x04004657 RID: 18007
	[Token(Token = "0x4004657")]
	[FieldOffset(Offset = "0x24")]
	public float fromInsideToInsideDistanceMax;

	// Token: 0x04004658 RID: 18008
	[Token(Token = "0x4004658")]
	[FieldOffset(Offset = "0x28")]
	public float outsideDistanceMax;

	// Token: 0x04004659 RID: 18009
	[Token(Token = "0x4004659")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 outsideHeightDistanceBoost;

	// Token: 0x0400465A RID: 18010
	[Token(Token = "0x400465A")]
	[FieldOffset(Offset = "0x34")]
	public float windowCullingRange;

	// Token: 0x0400465B RID: 18011
	[Token(Token = "0x400465B")]
	[FieldOffset(Offset = "0x38")]
	public float doorCullingRange;

	// Token: 0x0400465C RID: 18012
	[Token(Token = "0x400465C")]
	[FieldOffset(Offset = "0x3C")]
	public float exteriorDuctCullingRange;

	// Token: 0x0400465D RID: 18013
	[Token(Token = "0x400465D")]
	[FieldOffset(Offset = "0x40")]
	public float ductRoomCullingRange;

	// Token: 0x0400465E RID: 18014
	[Token(Token = "0x400465E")]
	[FieldOffset(Offset = "0x44")]
	public float airDuctLODThreshold;

	// Token: 0x0400465F RID: 18015
	[Token(Token = "0x400465F")]
	[FieldOffset(Offset = "0x0")]
	private static CullingControls _instance;
}
