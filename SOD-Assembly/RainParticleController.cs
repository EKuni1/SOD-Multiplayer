using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000541 RID: 1345
[Token(Token = "0x2000541")]
public class RainParticleController : MonoBehaviour
{
	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x06001D4E RID: 7502 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000E6")]
	public static RainParticleController Instance
	{
		[Token(Token = "0x6001D4E")]
		[Address(RVA = "0xA1B380", Offset = "0xA1A380", VA = "0x180A1B380")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001D4F RID: 7503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D4F")]
	[Address(RVA = "0xA1B3C0", Offset = "0xA1A3C0", VA = "0x180A1B3C0")]
	private void Awake()
	{
	}

	// Token: 0x06001D50 RID: 7504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D50")]
	[Address(RVA = "0xA1B720", Offset = "0xA1A720", VA = "0x180A1B720")]
	public void SetSnowMode(bool val, bool forceUpdate = false)
	{
	}

	// Token: 0x06001D51 RID: 7505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D51")]
	[Address(RVA = "0xA1B740", Offset = "0xA1A740", VA = "0x180A1B740")]
	public void UpdateValidSpawnNodes()
	{
	}

	// Token: 0x06001D52 RID: 7506 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D52")]
	[Address(RVA = "0xA1BE00", Offset = "0xA1AE00", VA = "0x180A1BE00")]
	private void Update()
	{
	}

	// Token: 0x06001D53 RID: 7507 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
	[Token(Token = "0x6001D53")]
	[Address(RVA = "0xA1D490", Offset = "0xA1C490", VA = "0x180A1D490")]
	private bool GetSpawnPosition(out Vector3 spawn)
	{
		return default(bool);
	}

	// Token: 0x06001D54 RID: 7508 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D54")]
	[Address(RVA = "0xA1DA00", Offset = "0xA1CA00", VA = "0x180A1DA00")]
	public RainParticleController()
	{
	}

	// Token: 0x040025C7 RID: 9671
	[Token(Token = "0x40025C7")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 speed;

	// Token: 0x040025C8 RID: 9672
	[Token(Token = "0x40025C8")]
	[FieldOffset(Offset = "0x20")]
	public float spawnHeight;

	// Token: 0x040025C9 RID: 9673
	[Token(Token = "0x40025C9")]
	[FieldOffset(Offset = "0x24")]
	public float rainFloorWorldYPos;

	// Token: 0x040025CA RID: 9674
	[Token(Token = "0x40025CA")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 spawnInterval;

	// Token: 0x040025CB RID: 9675
	[Token(Token = "0x40025CB")]
	[FieldOffset(Offset = "0x30")]
	public GameObject particlePrefab;

	// Token: 0x040025CC RID: 9676
	[Token(Token = "0x40025CC")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 rotationEuler;

	// Token: 0x040025CD RID: 9677
	[Token(Token = "0x40025CD")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 speedSnow;

	// Token: 0x040025CE RID: 9678
	[Token(Token = "0x40025CE")]
	[FieldOffset(Offset = "0x4C")]
	public float spawnHeightSnow;

	// Token: 0x040025CF RID: 9679
	[Token(Token = "0x40025CF")]
	[FieldOffset(Offset = "0x50")]
	public float snowFloorWorldYPos;

	// Token: 0x040025D0 RID: 9680
	[Token(Token = "0x40025D0")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 spawnIntervalSnow;

	// Token: 0x040025D1 RID: 9681
	[Token(Token = "0x40025D1")]
	[FieldOffset(Offset = "0x60")]
	public GameObject particlePrefabSnow;

	// Token: 0x040025D2 RID: 9682
	[Token(Token = "0x40025D2")]
	[FieldOffset(Offset = "0x68")]
	public Vector3 rotationEulerSnow;

	// Token: 0x040025D3 RID: 9683
	[Token(Token = "0x40025D3")]
	[FieldOffset(Offset = "0x74")]
	public bool billboard;

	// Token: 0x040025D4 RID: 9684
	[Token(Token = "0x40025D4")]
	[FieldOffset(Offset = "0x78")]
	public int desiredParticleCount;

	// Token: 0x040025D5 RID: 9685
	[Token(Token = "0x40025D5")]
	[FieldOffset(Offset = "0x7C")]
	public int actualParticleCount;

	// Token: 0x040025D6 RID: 9686
	[Token(Token = "0x40025D6")]
	[FieldOffset(Offset = "0x80")]
	public List<RainParticleController.RainParticle> particles;

	// Token: 0x040025D7 RID: 9687
	[Token(Token = "0x40025D7")]
	[FieldOffset(Offset = "0x88")]
	private float spawnIntervalTimer;

	// Token: 0x040025D8 RID: 9688
	[Token(Token = "0x40025D8")]
	[FieldOffset(Offset = "0x8C")]
	public bool snowMode;

	// Token: 0x040025D9 RID: 9689
	[Token(Token = "0x40025D9")]
	[FieldOffset(Offset = "0x90")]
	public List<NewNode> validSpawnNodes;

	// Token: 0x040025DA RID: 9690
	[Token(Token = "0x40025DA")]
	[FieldOffset(Offset = "0x0")]
	private static RainParticleController _instance;

	// Token: 0x02000542 RID: 1346
	[Token(Token = "0x2000542")]
	public class RainParticle
	{
		// Token: 0x06001D55 RID: 7509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D55")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public RainParticle()
		{
		}

		// Token: 0x040025DB RID: 9691
		[Token(Token = "0x40025DB")]
		[FieldOffset(Offset = "0x10")]
		public Transform trans;

		// Token: 0x040025DC RID: 9692
		[Token(Token = "0x40025DC")]
		[FieldOffset(Offset = "0x18")]
		public float speed;
	}
}
