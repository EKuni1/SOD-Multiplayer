using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200086A RID: 2154
[Token(Token = "0x200086A")]
public class ParticleEffect : SoCustomComparison
{
	// Token: 0x060029D5 RID: 10709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029D5")]
	[Address(RVA = "0xCB0710", Offset = "0xCAF710", VA = "0x180CB0710")]
	public ParticleEffect()
	{
	}

	// Token: 0x0400415F RID: 16735
	[Token(Token = "0x400415F")]
	[FieldOffset(Offset = "0x20")]
	public float damageBreakPoint;

	// Token: 0x04004160 RID: 16736
	[Token(Token = "0x4004160")]
	[FieldOffset(Offset = "0x24")]
	public bool deleteObject;

	// Token: 0x04004161 RID: 16737
	[Token(Token = "0x4004161")]
	[FieldOffset(Offset = "0x28")]
	public GameObject effectPrefab;

	// Token: 0x04004162 RID: 16738
	[Token(Token = "0x4004162")]
	[FieldOffset(Offset = "0x30")]
	public bool shatter;

	// Token: 0x04004163 RID: 16739
	[Token(Token = "0x4004163")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 shardSize;

	// Token: 0x04004164 RID: 16740
	[Token(Token = "0x4004164")]
	[FieldOffset(Offset = "0x40")]
	public int shardEveryXPixels;

	// Token: 0x04004165 RID: 16741
	[Token(Token = "0x4004165")]
	[FieldOffset(Offset = "0x44")]
	public float shatterForceMultiplier;

	// Token: 0x04004166 RID: 16742
	[Token(Token = "0x4004166")]
	[FieldOffset(Offset = "0x48")]
	public bool isGlass;

	// Token: 0x04004167 RID: 16743
	[Token(Token = "0x4004167")]
	[FieldOffset(Offset = "0x4C")]
	public ParticleEffect.SpatterTrigger spatterTrigger;

	// Token: 0x04004168 RID: 16744
	[Token(Token = "0x4004168")]
	[FieldOffset(Offset = "0x50")]
	public SpatterPatternPreset spatter;

	// Token: 0x04004169 RID: 16745
	[Token(Token = "0x4004169")]
	[FieldOffset(Offset = "0x58")]
	public float countMultiplier;

	// Token: 0x0400416A RID: 16746
	[Token(Token = "0x400416A")]
	[FieldOffset(Offset = "0x5C")]
	public bool stickToActors;

	// Token: 0x0400416B RID: 16747
	[Token(Token = "0x400416B")]
	[FieldOffset(Offset = "0x5D")]
	public bool spatterIsVandalism;

	// Token: 0x0400416C RID: 16748
	[Token(Token = "0x400416C")]
	[FieldOffset(Offset = "0x60")]
	public int vandalismFine;

	// Token: 0x0400416D RID: 16749
	[Token(Token = "0x400416D")]
	[FieldOffset(Offset = "0x64")]
	public ParticleEffect.SpatterTrigger creationTrigger;

	// Token: 0x0400416E RID: 16750
	[Token(Token = "0x400416E")]
	[FieldOffset(Offset = "0x68")]
	public List<GameObject> objectPool;

	// Token: 0x0400416F RID: 16751
	[Token(Token = "0x400416F")]
	[FieldOffset(Offset = "0x70")]
	public int instances;

	// Token: 0x04004170 RID: 16752
	[Token(Token = "0x4004170")]
	[FieldOffset(Offset = "0x74")]
	public bool useRandomRotation;

	// Token: 0x04004171 RID: 16753
	[Token(Token = "0x4004171")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 localEuler;

	// Token: 0x04004172 RID: 16754
	[Token(Token = "0x4004172")]
	[FieldOffset(Offset = "0x88")]
	public List<AudioEvent> impactEvents;

	// Token: 0x04004173 RID: 16755
	[Token(Token = "0x4004173")]
	[FieldOffset(Offset = "0x90")]
	public List<AudioEvent> breakEvents;

	// Token: 0x0200086B RID: 2155
	[Token(Token = "0x200086B")]
	public enum SpatterTrigger
	{
		// Token: 0x04004175 RID: 16757
		[Token(Token = "0x4004175")]
		off,
		// Token: 0x04004176 RID: 16758
		[Token(Token = "0x4004176")]
		onBreak,
		// Token: 0x04004177 RID: 16759
		[Token(Token = "0x4004177")]
		onAnyImpact,
		// Token: 0x04004178 RID: 16760
		[Token(Token = "0x4004178")]
		whileInAirOrAnyImpact
	}
}
