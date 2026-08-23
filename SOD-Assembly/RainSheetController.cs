using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000543 RID: 1347
[Token(Token = "0x2000543")]
public class RainSheetController : MonoBehaviour
{
	// Token: 0x06001D56 RID: 7510 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D56")]
	[Address(RVA = "0xA1DC40", Offset = "0xA1CC40", VA = "0x180A1DC40")]
	private void Start()
	{
	}

	// Token: 0x06001D57 RID: 7511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D57")]
	[Address(RVA = "0xA1DF00", Offset = "0xA1CF00", VA = "0x180A1DF00")]
	public void SetSnowMode(bool val, bool forceUpdate = false)
	{
	}

	// Token: 0x06001D58 RID: 7512 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D58")]
	[Address(RVA = "0xA1E0D0", Offset = "0xA1D0D0", VA = "0x180A1E0D0")]
	public void SetEnabled(bool val)
	{
	}

	// Token: 0x06001D59 RID: 7513 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D59")]
	[Address(RVA = "0xA1E180", Offset = "0xA1D180", VA = "0x180A1E180")]
	private void Update()
	{
	}

	// Token: 0x06001D5A RID: 7514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D5A")]
	[Address(RVA = "0xA1F090", Offset = "0xA1E090", VA = "0x180A1F090")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001D5B RID: 7515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D5B")]
	[Address(RVA = "0xA1F2A0", Offset = "0xA1E2A0", VA = "0x180A1F2A0")]
	public RainSheetController()
	{
	}

	// Token: 0x040025DD RID: 9693
	[Token(Token = "0x40025DD")]
	[FieldOffset(Offset = "0x18")]
	public List<RainSheetController.RainSheet> sheets;

	// Token: 0x040025DE RID: 9694
	[Token(Token = "0x40025DE")]
	[FieldOffset(Offset = "0x20")]
	public bool indoorRaycast;

	// Token: 0x040025DF RID: 9695
	[Token(Token = "0x40025DF")]
	[FieldOffset(Offset = "0x24")]
	public int raycastsPerFrame;

	// Token: 0x040025E0 RID: 9696
	[Token(Token = "0x40025E0")]
	[FieldOffset(Offset = "0x28")]
	private int rainBlockOnlyMask;

	// Token: 0x040025E1 RID: 9697
	[Token(Token = "0x40025E1")]
	[FieldOffset(Offset = "0x2C")]
	private int rainBlockAndRoomMeshMask;

	// Token: 0x040025E2 RID: 9698
	[Token(Token = "0x40025E2")]
	[FieldOffset(Offset = "0x30")]
	private int sheetCursor;

	// Token: 0x040025E3 RID: 9699
	[Token(Token = "0x40025E3")]
	[FieldOffset(Offset = "0x34")]
	public float rainSheetHeight;

	// Token: 0x040025E4 RID: 9700
	[Token(Token = "0x40025E4")]
	[FieldOffset(Offset = "0x38")]
	public bool snowMode;

	// Token: 0x040025E5 RID: 9701
	[Token(Token = "0x40025E5")]
	[FieldOffset(Offset = "0x40")]
	public Material material;

	// Token: 0x040025E6 RID: 9702
	[Token(Token = "0x40025E6")]
	[FieldOffset(Offset = "0x48")]
	public Material snowMaterial;

	// Token: 0x02000544 RID: 1348
	[Token(Token = "0x2000544")]
	[Serializable]
	public class RainSheet
	{
		// Token: 0x06001D5C RID: 7516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D5C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public RainSheet()
		{
		}

		// Token: 0x040025E7 RID: 9703
		[Token(Token = "0x40025E7")]
		[FieldOffset(Offset = "0x10")]
		public Transform rainSheetTransform;

		// Token: 0x040025E8 RID: 9704
		[Token(Token = "0x40025E8")]
		[FieldOffset(Offset = "0x18")]
		public MeshRenderer renderer;
	}
}
