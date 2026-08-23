using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200050A RID: 1290
[Token(Token = "0x200050A")]
public class SteamController : MonoBehaviour
{
	// Token: 0x06001BC0 RID: 7104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BC0")]
	[Address(RVA = "0x9C5F50", Offset = "0x9C4F50", VA = "0x1809C5F50")]
	public void Setup(NewRoom newRoom)
	{
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BC1")]
	[Address(RVA = "0x9C6320", Offset = "0x9C5320", VA = "0x1809C6320")]
	public void SteamStateChanged()
	{
	}

	// Token: 0x06001BC2 RID: 7106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BC2")]
	[Address(RVA = "0x9C6380", Offset = "0x9C5380", VA = "0x1809C6380")]
	private void Update()
	{
	}

	// Token: 0x06001BC3 RID: 7107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BC3")]
	[Address(RVA = "0x9C6960", Offset = "0x9C5960", VA = "0x1809C6960")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001BC4 RID: 7108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BC4")]
	[Address(RVA = "0x9C6AD0", Offset = "0x9C5AD0", VA = "0x1809C6AD0")]
	public SteamController()
	{
	}

	// Token: 0x0400246B RID: 9323
	[Token(Token = "0x400246B")]
	[FieldOffset(Offset = "0x18")]
	public NewRoom room;

	// Token: 0x0400246C RID: 9324
	[Token(Token = "0x400246C")]
	[FieldOffset(Offset = "0x20")]
	private float existingSteamLevel;

	// Token: 0x0400246D RID: 9325
	[Token(Token = "0x400246D")]
	[FieldOffset(Offset = "0x24")]
	public float steamLevel;

	// Token: 0x0400246E RID: 9326
	[Token(Token = "0x400246E")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 blurScale;

	// Token: 0x0400246F RID: 9327
	[Token(Token = "0x400246F")]
	[FieldOffset(Offset = "0x30")]
	public float steamTime;

	// Token: 0x04002470 RID: 9328
	[Token(Token = "0x4002470")]
	[FieldOffset(Offset = "0x34")]
	public float desteamTime;

	// Token: 0x04002471 RID: 9329
	[Token(Token = "0x4002471")]
	[FieldOffset(Offset = "0x38")]
	public List<MeshRenderer> glassPanels;

	// Token: 0x04002472 RID: 9330
	[Token(Token = "0x4002472")]
	[FieldOffset(Offset = "0x40")]
	public Material glassMaterialOriginal;

	// Token: 0x04002473 RID: 9331
	[Token(Token = "0x4002473")]
	[FieldOffset(Offset = "0x48")]
	public Material glassMaterial;
}
