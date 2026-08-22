using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003A RID: 58
[Token(Token = "0x200003A")]
public class TestOutfitBuilder : MonoBehaviour
{
	// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x5CC0B0", Offset = "0x5CB0B0", VA = "0x1805CC0B0")]
	public void SpawnAndClotheCitizens()
	{
	}

	// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x5CC290", Offset = "0x5CB290", VA = "0x1805CC290")]
	public void RollRandomClothing(CitizenOutfitController controller)
	{
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x00002D48 File Offset: 0x00000F48
	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x5CD410", Offset = "0x5CC410", VA = "0x1805CD410")]
	public bool CoinFlip()
	{
		return default(bool);
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x5CD470", Offset = "0x5CC470", VA = "0x1805CD470")]
	public TestOutfitBuilder()
	{
	}

	// Token: 0x0400012C RID: 300
	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x18")]
	public bool hasFacialHair;

	// Token: 0x0400012D RID: 301
	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x19")]
	public bool hasHat;

	// Token: 0x0400012E RID: 302
	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x1A")]
	public bool hasGlasses;

	// Token: 0x0400012F RID: 303
	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x20")]
	public List<Mesh> Beards;

	// Token: 0x04000130 RID: 304
	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x28")]
	public List<Mesh> Feet;

	// Token: 0x04000131 RID: 305
	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x30")]
	public List<Mesh> Glasses;

	// Token: 0x04000132 RID: 306
	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x38")]
	public List<Mesh> Hair;

	// Token: 0x04000133 RID: 307
	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x40")]
	public List<Mesh> Hands;

	// Token: 0x04000134 RID: 308
	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x48")]
	public List<Mesh> Hats;

	// Token: 0x04000135 RID: 309
	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x50")]
	public List<Mesh> Heads;

	// Token: 0x04000136 RID: 310
	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x58")]
	public List<Mesh> LowerArms;

	// Token: 0x04000137 RID: 311
	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x60")]
	public List<Mesh> LowerLegs;

	// Token: 0x04000138 RID: 312
	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0x68")]
	public List<Mesh> LowerTorsos;

	// Token: 0x04000139 RID: 313
	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0x70")]
	public List<Mesh> Midriffs;

	// Token: 0x0400013A RID: 314
	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x78")]
	public List<Mesh> UpperArms;

	// Token: 0x0400013B RID: 315
	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x80")]
	public List<Mesh> UpperLegs;

	// Token: 0x0400013C RID: 316
	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x88")]
	public List<Mesh> UpperTorsos;

	// Token: 0x0400013D RID: 317
	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x90")]
	public Citizen citizenToSpawn;

	// Token: 0x0400013E RID: 318
	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x98")]
	public float citizenAmount;

	// Token: 0x0400013F RID: 319
	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x9C")]
	private float _xOffset;

	// Token: 0x04000140 RID: 320
	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0xA0")]
	private float _zOffset;
}
