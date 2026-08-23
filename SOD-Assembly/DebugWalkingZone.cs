using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000227 RID: 551
[Token(Token = "0x2000227")]
public class DebugWalkingZone : MonoBehaviour
{
	// Token: 0x06000C9B RID: 3227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x59C580", Offset = "0x59B580", VA = "0x18059C580")]
	private void Awake()
	{
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0x59C670", Offset = "0x59B670", VA = "0x18059C670")]
	public DebugWalkingZone()
	{
	}

	// Token: 0x04000DEF RID: 3567
	[Token(Token = "0x4000DEF")]
	[FieldOffset(Offset = "0x18")]
	public NewTile tile;

	// Token: 0x04000DF0 RID: 3568
	[Token(Token = "0x4000DF0")]
	[FieldOffset(Offset = "0x20")]
	private Renderer rend;

	// Token: 0x04000DF1 RID: 3569
	[Token(Token = "0x4000DF1")]
	[FieldOffset(Offset = "0x28")]
	public Texture green;

	// Token: 0x04000DF2 RID: 3570
	[Token(Token = "0x4000DF2")]
	[FieldOffset(Offset = "0x30")]
	public Texture yellow;

	// Token: 0x04000DF3 RID: 3571
	[Token(Token = "0x4000DF3")]
	[FieldOffset(Offset = "0x38")]
	public Texture red;

	// Token: 0x04000DF4 RID: 3572
	[Token(Token = "0x4000DF4")]
	[FieldOffset(Offset = "0x40")]
	public Texture orange;

	// Token: 0x04000DF5 RID: 3573
	[Token(Token = "0x4000DF5")]
	[FieldOffset(Offset = "0x48")]
	public Texture blue;

	// Token: 0x04000DF6 RID: 3574
	[Token(Token = "0x4000DF6")]
	[FieldOffset(Offset = "0x50")]
	public Texture violet;

	// Token: 0x04000DF7 RID: 3575
	[Token(Token = "0x4000DF7")]
	[FieldOffset(Offset = "0x58")]
	public Texture turqoise;

	// Token: 0x04000DF8 RID: 3576
	[Token(Token = "0x4000DF8")]
	[FieldOffset(Offset = "0x60")]
	private List<Texture> textureList;
}
