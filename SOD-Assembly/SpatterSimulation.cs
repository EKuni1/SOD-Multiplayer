using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000501 RID: 1281
[Token(Token = "0x2000501")]
[Serializable]
public class SpatterSimulation
{
	// Token: 0x06001BAF RID: 7087 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BAF")]
	[Address(RVA = "0x9C18C0", Offset = "0x9C08C0", VA = "0x1809C18C0")]
	public SpatterSimulation(Human newHuman, Vector3 newLocalPosition, Vector3 newDirection, SpatterPatternPreset spatter, SpatterSimulation.EraseMode newEraseMode, float newSpatterCountMultiplier = 1f, bool newStickToActors = true)
	{
	}

	// Token: 0x06001BB0 RID: 7088 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB0")]
	[Address(RVA = "0x9C1F80", Offset = "0x9C0F80", VA = "0x1809C1F80")]
	public SpatterSimulation(Vector3 newWorldPosition, Vector3 newWorldTarget, SpatterPatternPreset spatter, SpatterSimulation.EraseMode newEraseMode, float newSpatterCountMultiplier = 1f, bool newStickToActors = true)
	{
	}

	// Token: 0x06001BB1 RID: 7089 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB1")]
	[Address(RVA = "0x9C24E0", Offset = "0x9C14E0", VA = "0x1809C24E0")]
	public void Execute()
	{
	}

	// Token: 0x06001BB2 RID: 7090 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB2")]
	[Address(RVA = "0x9C37F0", Offset = "0x9C27F0", VA = "0x1809C37F0")]
	public void Remove()
	{
	}

	// Token: 0x06001BB3 RID: 7091 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB3")]
	[Address(RVA = "0x9C3D30", Offset = "0x9C2D30", VA = "0x1809C3D30")]
	public void LoadFromSerializedData()
	{
	}

	// Token: 0x06001BB4 RID: 7092 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BB4")]
	[Address(RVA = "0x9C3E30", Offset = "0x9C2E30", VA = "0x1809C3E30")]
	public void UpdateSpawning()
	{
	}

	// Token: 0x04002435 RID: 9269
	[Token(Token = "0x4002435")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 worldOrigin;

	// Token: 0x04002436 RID: 9270
	[Token(Token = "0x4002436")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 worldTarget;

	// Token: 0x04002437 RID: 9271
	[Token(Token = "0x4002437")]
	[FieldOffset(Offset = "0x28")]
	public Vector3Int nodeCoord;

	// Token: 0x04002438 RID: 9272
	[Token(Token = "0x4002438")]
	[FieldOffset(Offset = "0x38")]
	public string presetStr;

	// Token: 0x04002439 RID: 9273
	[Token(Token = "0x4002439")]
	[FieldOffset(Offset = "0x40")]
	public int roomID;

	// Token: 0x0400243A RID: 9274
	[Token(Token = "0x400243A")]
	[FieldOffset(Offset = "0x44")]
	public SpatterSimulation.EraseMode eraseMode;

	// Token: 0x0400243B RID: 9275
	[Token(Token = "0x400243B")]
	[FieldOffset(Offset = "0x48")]
	public SpatterSimulation.ForceType force;

	// Token: 0x0400243C RID: 9276
	[Token(Token = "0x400243C")]
	[FieldOffset(Offset = "0x4C")]
	public float spatterCountMultiplier;

	// Token: 0x0400243D RID: 9277
	[Token(Token = "0x400243D")]
	[FieldOffset(Offset = "0x50")]
	public float createdAt;

	// Token: 0x0400243E RID: 9278
	[Token(Token = "0x400243E")]
	[FieldOffset(Offset = "0x54")]
	public bool isExecuted;

	// Token: 0x0400243F RID: 9279
	[Token(Token = "0x400243F")]
	[FieldOffset(Offset = "0x58")]
	public float executedAt;

	// Token: 0x04002440 RID: 9280
	[Token(Token = "0x4002440")]
	[FieldOffset(Offset = "0x5C")]
	public float eraseModeTimeStamp;

	// Token: 0x04002441 RID: 9281
	[Token(Token = "0x4002441")]
	[FieldOffset(Offset = "0x60")]
	public bool stickToActors;

	// Token: 0x04002442 RID: 9282
	[Token(Token = "0x4002442")]
	[FieldOffset(Offset = "0x68")]
	public List<SpatterSimulation.DecalSpawnData> decalsSpawned;

	// Token: 0x04002443 RID: 9283
	[Token(Token = "0x4002443")]
	[FieldOffset(Offset = "0x70")]
	[NonSerialized]
	public NewRoom room;

	// Token: 0x04002444 RID: 9284
	[Token(Token = "0x4002444")]
	[FieldOffset(Offset = "0x78")]
	[NonSerialized]
	public SpatterPatternPreset preset;

	// Token: 0x04002445 RID: 9285
	[Token(Token = "0x4002445")]
	[FieldOffset(Offset = "0x0")]
	[NonSerialized]
	public static int spawnedProjectorsCount;

	// Token: 0x02000502 RID: 1282
	[Token(Token = "0x2000502")]
	public enum EraseMode
	{
		// Token: 0x04002447 RID: 9287
		[Token(Token = "0x4002447")]
		neverOrManual,
		// Token: 0x04002448 RID: 9288
		[Token(Token = "0x4002448")]
		onceExecutedAndOutOfBuildingPlusDespawnTime,
		// Token: 0x04002449 RID: 9289
		[Token(Token = "0x4002449")]
		onceExecutedAndOutOfAddressPlusDespawnTime,
		// Token: 0x0400244A RID: 9290
		[Token(Token = "0x400244A")]
		useDespawnTime,
		// Token: 0x0400244B RID: 9291
		[Token(Token = "0x400244B")]
		useDespawnTimeOnceExecuted,
		// Token: 0x0400244C RID: 9292
		[Token(Token = "0x400244C")]
		quickDespawn
	}

	// Token: 0x02000503 RID: 1283
	[Token(Token = "0x2000503")]
	public enum ForceType
	{
		// Token: 0x0400244E RID: 9294
		[Token(Token = "0x400244E")]
		bulletForward,
		// Token: 0x0400244F RID: 9295
		[Token(Token = "0x400244F")]
		bulletBack,
		// Token: 0x04002450 RID: 9296
		[Token(Token = "0x4002450")]
		punch
	}

	// Token: 0x02000504 RID: 1284
	[Token(Token = "0x2000504")]
	[Serializable]
	public class DecalSpawnData
	{
		// Token: 0x06001BB5 RID: 7093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB5")]
		[Address(RVA = "0x9C5230", Offset = "0x9C4230", VA = "0x1809C5230")]
		public void SpawnOnTransform(Transform spawnTransform)
		{
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB6")]
		[Address(RVA = "0x9C5700", Offset = "0x9C4700", VA = "0x1809C5700")]
		public static void InitialisePool()
		{
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001BB7")]
		[Address(RVA = "0x9C5A20", Offset = "0x9C4A20", VA = "0x1809C5A20")]
		public static DecalProjector GetNewDecalProjector()
		{
			return null;
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB8")]
		[Address(RVA = "0x9C5C50", Offset = "0x9C4C50", VA = "0x1809C5C50")]
		public static void RecycleDecalProjector(DecalProjector decalProjector)
		{
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB9")]
		[Address(RVA = "0x6DD8B0", Offset = "0x6DC8B0", VA = "0x1806DD8B0")]
		public DecalSpawnData()
		{
		}

		// Token: 0x04002451 RID: 9297
		[Token(Token = "0x4002451")]
		[FieldOffset(Offset = "0x10")]
		public SpatterSimulation.ParentID parentID;

		// Token: 0x04002452 RID: 9298
		[Token(Token = "0x4002452")]
		[FieldOffset(Offset = "0x14")]
		public int transformParentID;

		// Token: 0x04002453 RID: 9299
		[Token(Token = "0x4002453")]
		[FieldOffset(Offset = "0x18")]
		public string subObjectName;

		// Token: 0x04002454 RID: 9300
		[Token(Token = "0x4002454")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 worldPos;

		// Token: 0x04002455 RID: 9301
		[Token(Token = "0x4002455")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 worldEuler;

		// Token: 0x04002456 RID: 9302
		[Token(Token = "0x4002456")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 size;

		// Token: 0x04002457 RID: 9303
		[Token(Token = "0x4002457")]
		[FieldOffset(Offset = "0x44")]
		public SpatterSimulation.DecalMaterialType materialType;

		// Token: 0x04002458 RID: 9304
		[Token(Token = "0x4002458")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public DecalProjector spawnedProjector;

		// Token: 0x04002459 RID: 9305
		[Token(Token = "0x4002459")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Interactable i;

		// Token: 0x0400245A RID: 9306
		[Token(Token = "0x400245A")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public SpatterSimulation sim;

		// Token: 0x0400245B RID: 9307
		[Token(Token = "0x400245B")]
		private const int INITIAL_POOL_SIZE = 30;

		// Token: 0x0400245C RID: 9308
		[Token(Token = "0x400245C")]
		private const float RECYCLED_Y_POSITION = -1000f;

		// Token: 0x0400245D RID: 9309
		[Token(Token = "0x400245D")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static Queue<DecalProjector> decalPool;
	}

	// Token: 0x02000505 RID: 1285
	[Token(Token = "0x2000505")]
	public enum DecalMaterialType
	{
		// Token: 0x0400245F RID: 9311
		[Token(Token = "0x400245F")]
		light,
		// Token: 0x04002460 RID: 9312
		[Token(Token = "0x4002460")]
		medium,
		// Token: 0x04002461 RID: 9313
		[Token(Token = "0x4002461")]
		heavy
	}

	// Token: 0x02000506 RID: 1286
	[Token(Token = "0x2000506")]
	public enum ParentID
	{
		// Token: 0x04002463 RID: 9315
		[Token(Token = "0x4002463")]
		room,
		// Token: 0x04002464 RID: 9316
		[Token(Token = "0x4002464")]
		human,
		// Token: 0x04002465 RID: 9317
		[Token(Token = "0x4002465")]
		interactable,
		// Token: 0x04002466 RID: 9318
		[Token(Token = "0x4002466")]
		door
	}

	// Token: 0x02000507 RID: 1287
	[Token(Token = "0x2000507")]
	private sealed class <>c__DisplayClass25_0
	{
		// Token: 0x06001BBB RID: 7099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass25_0()
		{
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0000CB88 File Offset: 0x0000AD88
		[Token(Token = "0x6001BBC")]
		[Address(RVA = "0x9C5F20", Offset = "0x9C4F20", VA = "0x1809C5F20")]
		internal bool <Remove>b__0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04002467 RID: 9319
		[Token(Token = "0x4002467")]
		[FieldOffset(Offset = "0x10")]
		public SpatterSimulation.DecalSpawnData ds;
	}

	// Token: 0x02000508 RID: 1288
	[Token(Token = "0x2000508")]
	private sealed class <>c__DisplayClass27_0
	{
		// Token: 0x06001BBD RID: 7101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass27_0()
		{
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		[Token(Token = "0x6001BBE")]
		[Address(RVA = "0x9C5F20", Offset = "0x9C4F20", VA = "0x1809C5F20")]
		internal bool <UpdateSpawning>b__0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04002468 RID: 9320
		[Token(Token = "0x4002468")]
		[FieldOffset(Offset = "0x10")]
		public SpatterSimulation.DecalSpawnData ds;
	}
}
