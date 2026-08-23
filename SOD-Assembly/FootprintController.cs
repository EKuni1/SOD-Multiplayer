using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000425 RID: 1061
[Token(Token = "0x2000425")]
public class FootprintController : MonoBehaviour
{
	// Token: 0x060017E5 RID: 6117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017E5")]
	[Address(RVA = "0x8AF0B0", Offset = "0x8AE0B0", VA = "0x1808AF0B0")]
	public void Setup(GameplayController.Footprint newFootprint)
	{
	}

	// Token: 0x060017E6 RID: 6118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017E6")]
	[Address(RVA = "0x8AF810", Offset = "0x8AE810", VA = "0x1808AF810")]
	public void SetUseQuad(bool val)
	{
	}

	// Token: 0x060017E7 RID: 6119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017E7")]
	[Address(RVA = "0x8AFDD0", Offset = "0x8AEDD0", VA = "0x1808AFDD0")]
	public void ResetScan()
	{
	}

	// Token: 0x060017E8 RID: 6120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017E8")]
	[Address(RVA = "0x8AFDE0", Offset = "0x8AEDE0", VA = "0x1808AFDE0")]
	public void PrintConfirmed()
	{
	}

	// Token: 0x060017E9 RID: 6121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017E9")]
	[Address(RVA = "0x8B00B0", Offset = "0x8AF0B0", VA = "0x1808B00B0")]
	public static void InitialisePool()
	{
	}

	// Token: 0x060017EA RID: 6122 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60017EA")]
	[Address(RVA = "0x8B0380", Offset = "0x8AF380", VA = "0x1808B0380")]
	public static FootprintController GetNewFootprint()
	{
		return null;
	}

	// Token: 0x060017EB RID: 6123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017EB")]
	[Address(RVA = "0x8B07A0", Offset = "0x8AF7A0", VA = "0x1808B07A0")]
	public static void RecycleFootprint(FootprintController footprintController)
	{
	}

	// Token: 0x060017EC RID: 6124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017EC")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public FootprintController()
	{
	}

	// Token: 0x04001D50 RID: 7504
	[Token(Token = "0x4001D50")]
	private const int INITIAL_POOL_SIZE = 300;

	// Token: 0x04001D51 RID: 7505
	[Token(Token = "0x4001D51")]
	private const float RECYCLED_Y_POSITION = -1000f;

	// Token: 0x04001D52 RID: 7506
	[Token(Token = "0x4001D52")]
	[FieldOffset(Offset = "0x0")]
	private static Queue<FootprintController> footprintPool;

	// Token: 0x04001D53 RID: 7507
	[Token(Token = "0x4001D53")]
	[FieldOffset(Offset = "0x18")]
	public GameplayController.Footprint footprint;

	// Token: 0x04001D54 RID: 7508
	[Token(Token = "0x4001D54")]
	[FieldOffset(Offset = "0x20")]
	public MeshRenderer quad;

	// Token: 0x04001D55 RID: 7509
	[Token(Token = "0x4001D55")]
	[FieldOffset(Offset = "0x28")]
	public DecalProjector projector;

	// Token: 0x04001D56 RID: 7510
	[Token(Token = "0x4001D56")]
	[FieldOffset(Offset = "0x30")]
	public Human human;

	// Token: 0x04001D57 RID: 7511
	[Token(Token = "0x4001D57")]
	[FieldOffset(Offset = "0x38")]
	public bool useQuad;

	// Token: 0x04001D58 RID: 7512
	[Token(Token = "0x4001D58")]
	[FieldOffset(Offset = "0x3C")]
	public float scanProgress;

	// Token: 0x04001D59 RID: 7513
	[Token(Token = "0x4001D59")]
	[FieldOffset(Offset = "0x40")]
	public bool printConfirmed;

	// Token: 0x04001D5A RID: 7514
	[Token(Token = "0x4001D5A")]
	[FieldOffset(Offset = "0x48")]
	public InteractableController printInteractable;
}
