using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004AC RID: 1196
[Token(Token = "0x20004AC")]
public class PipeConstructor : MonoBehaviour
{
	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x06001AED RID: 6893 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000D1")]
	public static PipeConstructor Instance
	{
		[Token(Token = "0x6001AED")]
		[Address(RVA = "0x99E300", Offset = "0x99D300", VA = "0x18099E300")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AEE")]
	[Address(RVA = "0x99E340", Offset = "0x99D340", VA = "0x18099E340")]
	private void Awake()
	{
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AEF")]
	[Address(RVA = "0x99E690", Offset = "0x99D690", VA = "0x18099E690")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001AF0")]
	[Address(RVA = "0x99E8A0", Offset = "0x99D8A0", VA = "0x18099E8A0")]
	public List<NewWall> WallPathfind(NewWall from, NewWall to, PipeConstructor.PipeGroup existingGroup)
	{
		return null;
	}

	// Token: 0x06001AF1 RID: 6897 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
	[Token(Token = "0x6001AF1")]
	[Address(RVA = "0x9A0600", Offset = "0x99F600", VA = "0x1809A0600")]
	public bool IsLeftOf(NewWall one, NewWall two)
	{
		return default(bool);
	}

	// Token: 0x06001AF2 RID: 6898 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
	[Token(Token = "0x6001AF2")]
	[Address(RVA = "0x9A09B0", Offset = "0x99F9B0", VA = "0x1809A09B0")]
	public bool IsRightOf(NewWall one, NewWall two)
	{
		return default(bool);
	}

	// Token: 0x06001AF3 RID: 6899 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
	[Token(Token = "0x6001AF3")]
	[Address(RVA = "0x9A0D60", Offset = "0x99FD60", VA = "0x1809A0D60")]
	public bool IsFrontOf(NewWall one, NewWall two)
	{
		return default(bool);
	}

	// Token: 0x06001AF4 RID: 6900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF4")]
	[Address(RVA = "0x9A1110", Offset = "0x9A0110", VA = "0x1809A1110")]
	public void GeneratePipes()
	{
	}

	// Token: 0x06001AF5 RID: 6901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF5")]
	[Address(RVA = "0x9A2530", Offset = "0x9A1530", VA = "0x1809A2530")]
	public void GetWall()
	{
	}

	// Token: 0x06001AF6 RID: 6902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF6")]
	[Address(RVA = "0x9A2D90", Offset = "0x9A1D90", VA = "0x1809A2D90")]
	public void LeftRightCheck()
	{
	}

	// Token: 0x06001AF7 RID: 6903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AF7")]
	[Address(RVA = "0x9A3870", Offset = "0x9A2870", VA = "0x1809A3870")]
	public PipeConstructor()
	{
	}

	// Token: 0x04002108 RID: 8456
	[Token(Token = "0x4002108")]
	[FieldOffset(Offset = "0x18")]
	public List<PipeConstructor.PipeSetup> pipeConfig;

	// Token: 0x04002109 RID: 8457
	[Token(Token = "0x4002109")]
	[FieldOffset(Offset = "0x20")]
	public List<PipeConstructor.PipeGroup> generated;

	// Token: 0x0400210A RID: 8458
	[Token(Token = "0x400210A")]
	[FieldOffset(Offset = "0x28")]
	public int debugGetWall1;

	// Token: 0x0400210B RID: 8459
	[Token(Token = "0x400210B")]
	[FieldOffset(Offset = "0x2C")]
	public int debugGetWall2;

	// Token: 0x0400210C RID: 8460
	[Token(Token = "0x400210C")]
	[FieldOffset(Offset = "0x0")]
	private static PipeConstructor _instance;

	// Token: 0x020004AD RID: 1197
	[Token(Token = "0x20004AD")]
	[Serializable]
	public class PipeSetup
	{
		// Token: 0x06001AF8 RID: 6904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF8")]
		[Address(RVA = "0x9A3A20", Offset = "0x9A2A20", VA = "0x1809A3A20")]
		public PipeSetup()
		{
		}

		// Token: 0x0400210D RID: 8461
		[Token(Token = "0x400210D")]
		[FieldOffset(Offset = "0x10")]
		public PipeConstructor.PipeType type;

		// Token: 0x0400210E RID: 8462
		[Token(Token = "0x400210E")]
		[FieldOffset(Offset = "0x18")]
		public Material material;

		// Token: 0x0400210F RID: 8463
		[Token(Token = "0x400210F")]
		[FieldOffset(Offset = "0x20")]
		public List<GameObject> models;
	}

	// Token: 0x020004AE RID: 1198
	[Token(Token = "0x20004AE")]
	public enum PipeType
	{
		// Token: 0x04002111 RID: 8465
		[Token(Token = "0x4002111")]
		wire,
		// Token: 0x04002112 RID: 8466
		[Token(Token = "0x4002112")]
		wire2
	}

	// Token: 0x020004AF RID: 1199
	[Token(Token = "0x20004AF")]
	[Serializable]
	public class PipeGroup
	{
		// Token: 0x06001AF9 RID: 6905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0x9A3AF0", Offset = "0x9A2AF0", VA = "0x1809A3AF0")]
		public PipeGroup(PipeConstructor.PipeType newType)
		{
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0x9A3CE0", Offset = "0x9A2CE0", VA = "0x1809A3CE0")]
		public void AddPipeRoute(NewWall from, NewWall to, int sourceIndex, int endIndex)
		{
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0x9A3DC0", Offset = "0x9A2DC0", VA = "0x1809A3DC0")]
		public void AddPipeRoute(NewWall from, NewWall to, int[] sourceIndex, int[] endIndex)
		{
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x9A4850", Offset = "0x9A3850", VA = "0x1809A4850")]
		public void AddToRoomsAsReferences()
		{
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x9A4B50", Offset = "0x9A3B50", VA = "0x1809A4B50")]
		public void SetVisible(bool val)
		{
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x9A4CB0", Offset = "0x9A3CB0", VA = "0x1809A4CB0")]
		public void Spawn()
		{
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		[Token(Token = "0x6001AFF")]
		[Address(RVA = "0x9A5F30", Offset = "0x9A4F30", VA = "0x1809A5F30")]
		public bool TryGetWall(int input, out NewWall output)
		{
			return default(bool);
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0000C810 File Offset: 0x0000AA10
		[Token(Token = "0x6001B00")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		private bool <Spawn>b__10_0(PipeConstructor.PipeSetup item)
		{
			return default(bool);
		}

		// Token: 0x04002113 RID: 8467
		[Token(Token = "0x4002113")]
		[FieldOffset(Offset = "0x10")]
		public int type;

		// Token: 0x04002114 RID: 8468
		[Token(Token = "0x4002114")]
		[FieldOffset(Offset = "0x18")]
		public List<PipeConstructor.PipeRoute> routes;

		// Token: 0x04002115 RID: 8469
		[Token(Token = "0x4002115")]
		[FieldOffset(Offset = "0x20")]
		public List<int> rooms;

		// Token: 0x04002116 RID: 8470
		[Token(Token = "0x4002116")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public GameObject spawned;

		// Token: 0x04002117 RID: 8471
		[Token(Token = "0x4002117")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public bool isVisible;

		// Token: 0x020004B0 RID: 1200
		[Token(Token = "0x20004B0")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06001B01 RID: 6913 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001B01")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06001B02 RID: 6914 RVA: 0x0000C828 File Offset: 0x0000AA28
			[Token(Token = "0x6001B02")]
			[Address(RVA = "0x9A6440", Offset = "0x9A5440", VA = "0x1809A6440")]
			internal bool <AddPipeRoute>b__0(PipeConstructor.PipeRoute item)
			{
				return default(bool);
			}

			// Token: 0x04002118 RID: 8472
			[Token(Token = "0x4002118")]
			[FieldOffset(Offset = "0x10")]
			public NewWall current;
		}

		// Token: 0x020004B1 RID: 1201
		[Token(Token = "0x20004B1")]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06001B03 RID: 6915 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001B03")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x06001B04 RID: 6916 RVA: 0x0000C840 File Offset: 0x0000AA40
			[Token(Token = "0x6001B04")]
			[Address(RVA = "0x9A6470", Offset = "0x9A5470", VA = "0x1809A6470")]
			internal bool <TryGetWall>b__0(NewWall item)
			{
				return default(bool);
			}

			// Token: 0x04002119 RID: 8473
			[Token(Token = "0x4002119")]
			[FieldOffset(Offset = "0x10")]
			public int input;

			// Token: 0x0400211A RID: 8474
			[Token(Token = "0x400211A")]
			[FieldOffset(Offset = "0x18")]
			public Predicate<NewWall> <>9__0;
		}
	}

	// Token: 0x020004B2 RID: 1202
	[Token(Token = "0x20004B2")]
	[Serializable]
	public class PipeRoute
	{
		// Token: 0x06001B05 RID: 6917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x9A6490", Offset = "0x9A5490", VA = "0x1809A6490")]
		public PipeRoute()
		{
		}

		// Token: 0x0400211B RID: 8475
		[Token(Token = "0x400211B")]
		[FieldOffset(Offset = "0x10")]
		public int w;

		// Token: 0x0400211C RID: 8476
		[Token(Token = "0x400211C")]
		[FieldOffset(Offset = "0x18")]
		public List<int> s;
	}

	// Token: 0x020004B3 RID: 1203
	[Token(Token = "0x20004B3")]
	private sealed class <>c__DisplayClass13_0
	{
		// Token: 0x06001B06 RID: 6918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B06")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass13_0()
		{
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0000C858 File Offset: 0x0000AA58
		[Token(Token = "0x6001B07")]
		[Address(RVA = "0x9A6550", Offset = "0x9A5550", VA = "0x1809A6550")]
		internal bool <WallPathfind>b__2(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x0400211D RID: 8477
		[Token(Token = "0x400211D")]
		[FieldOffset(Offset = "0x10")]
		public NewWall current;

		// Token: 0x0400211E RID: 8478
		[Token(Token = "0x400211E")]
		[FieldOffset(Offset = "0x18")]
		public Predicate<NewWall> <>9__2;
	}

	// Token: 0x020004B4 RID: 1204
	[Token(Token = "0x20004B4")]
	private sealed class <>c__DisplayClass13_1
	{
		// Token: 0x06001B08 RID: 6920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B08")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass13_1()
		{
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0000C870 File Offset: 0x0000AA70
		[Token(Token = "0x6001B09")]
		[Address(RVA = "0x9A6440", Offset = "0x9A5440", VA = "0x1809A6440")]
		internal bool <WallPathfind>b__0(PipeConstructor.PipeRoute item)
		{
			return default(bool);
		}

		// Token: 0x0400211F RID: 8479
		[Token(Token = "0x400211F")]
		[FieldOffset(Offset = "0x10")]
		public NewWall w;
	}

	// Token: 0x020004B5 RID: 1205
	[Token(Token = "0x20004B5")]
	private sealed class <>c__DisplayClass13_2
	{
		// Token: 0x06001B0A RID: 6922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass13_2()
		{
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0000C888 File Offset: 0x0000AA88
		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x9A6440", Offset = "0x9A5440", VA = "0x1809A6440")]
		internal bool <WallPathfind>b__1(PipeConstructor.PipeRoute item)
		{
			return default(bool);
		}

		// Token: 0x04002120 RID: 8480
		[Token(Token = "0x4002120")]
		[FieldOffset(Offset = "0x10")]
		public NewWall w;
	}

	// Token: 0x020004B6 RID: 1206
	[Token(Token = "0x20004B6")]
	private sealed class <>c__DisplayClass13_3
	{
		// Token: 0x06001B0C RID: 6924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass13_3()
		{
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0x9A6440", Offset = "0x9A5440", VA = "0x1809A6440")]
		internal bool <WallPathfind>b__3(PipeConstructor.PipeRoute item)
		{
			return default(bool);
		}

		// Token: 0x04002121 RID: 8481
		[Token(Token = "0x4002121")]
		[FieldOffset(Offset = "0x10")]
		public NewWall w;
	}

	// Token: 0x020004B7 RID: 1207
	[Token(Token = "0x20004B7")]
	private sealed class <>c__DisplayClass17_0
	{
		// Token: 0x06001B0E RID: 6926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass17_0()
		{
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x9A65A0", Offset = "0x9A55A0", VA = "0x1809A65A0")]
		internal bool <GeneratePipes>b__0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04002122 RID: 8482
		[Token(Token = "0x4002122")]
		[FieldOffset(Offset = "0x10")]
		public FurnitureLocation furn;
	}

	// Token: 0x020004B8 RID: 1208
	[Token(Token = "0x20004B8")]
	private sealed class <>c__DisplayClass17_1
	{
		// Token: 0x06001B10 RID: 6928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass17_1()
		{
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x9A66F0", Offset = "0x9A56F0", VA = "0x1809A66F0")]
		internal bool <GeneratePipes>b__1(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x9A66F0", Offset = "0x9A56F0", VA = "0x1809A66F0")]
		internal bool <GeneratePipes>b__2(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x04002123 RID: 8483
		[Token(Token = "0x4002123")]
		[FieldOffset(Offset = "0x10")]
		public Interactable alarm;
	}
}
