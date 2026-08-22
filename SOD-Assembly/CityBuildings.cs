using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EB RID: 491
[Token(Token = "0x20001EB")]
public class CityBuildings : HighlanderSingleton<CityBuildings>
{
	// Token: 0x06000BE7 RID: 3047 RVA: 0x00006F78 File Offset: 0x00005178
	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0x5823A0", Offset = "0x5813A0", VA = "0x1805823A0")]
	public UniTask GenerateBuildings()
	{
		return default(UniTask);
	}

	// Token: 0x06000BE8 RID: 3048 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BE8")]
	[Address(RVA = "0x5824E0", Offset = "0x5814E0", VA = "0x1805824E0")]
	public CityBuildings()
	{
	}

	// Token: 0x04000C52 RID: 3154
	[Token(Token = "0x4000C52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int loadChunk;

	// Token: 0x04000C53 RID: 3155
	[Token(Token = "0x4000C53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<BuildingPreset> buildingPresets;

	// Token: 0x04000C54 RID: 3156
	[Token(Token = "0x4000C54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<NewBuilding> buildingDirectory;

	// Token: 0x04000C55 RID: 3157
	[Token(Token = "0x4000C55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject buildingPrefab;

	// Token: 0x04000C56 RID: 3158
	[Token(Token = "0x4000C56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<CityBuildings.PickBuilding> selectionList;

	// Token: 0x020001EC RID: 492
	[Token(Token = "0x20001EC")]
	public class PickBuilding
	{
		// Token: 0x06000BE9 RID: 3049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public PickBuilding()
		{
		}

		// Token: 0x04000C57 RID: 3159
		[Token(Token = "0x4000C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BuildingPreset preset;

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rank;
	}

	// Token: 0x020001ED RID: 493
	[Token(Token = "0x20001ED")]
	private sealed class <>c__DisplayClass6_0
	{
		// Token: 0x06000BEA RID: 3050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00006F90 File Offset: 0x00005190
		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x561FA0", Offset = "0x560FA0", VA = "0x180561FA0")]
		internal bool <GenerateBuildings>b__2(CitySaveData.CityTileCitySave item)
		{
			return default(bool);
		}

		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CityTile current;
	}

	// Token: 0x020001EE RID: 494
	[Token(Token = "0x20001EE")]
	private sealed class <>c__DisplayClass6_1
	{
		// Token: 0x06000BEC RID: 3052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass6_1()
		{
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x00006FA8 File Offset: 0x000051A8
		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x57C5F0", Offset = "0x57B5F0", VA = "0x18057C5F0")]
		internal bool <GenerateBuildings>b__1(NewBuilding n)
		{
			return default(bool);
		}

		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BuildingPreset item;
	}

	// Token: 0x020001EF RID: 495
	[Token(Token = "0x20001EF")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000BEF RID: 3055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00006FC0 File Offset: 0x000051C0
		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x57C700", Offset = "0x57B700", VA = "0x18057C700")]
		internal int <GenerateBuildings>b__6_0(CityBuildings.PickBuilding p1, CityBuildings.PickBuilding p2)
		{
			return 0;
		}

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CityBuildings.<>c <>9;

		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<CityBuildings.PickBuilding> <>9__6_0;
	}

	// Token: 0x020001F0 RID: 496
	[Token(Token = "0x20001F0")]
	[StructLayout(3)]
	private struct <GenerateBuildings>d__6 : IEnumerator<object>
	{
		// Token: 0x06000BF1 RID: 3057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x582750", Offset = "0x581750", VA = "0x180582750", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04000C5D RID: 3165
		[Token(Token = "0x4000C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder <>t__builder;

		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CityBuildings <>4__this;

		// Token: 0x04000C60 RID: 3168
		[Token(Token = "0x4000C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<CityTile> <all>5__2;

		// Token: 0x04000C61 RID: 3169
		[Token(Token = "0x4000C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <loadBuildingsTotal>5__3;

		// Token: 0x04000C62 RID: 3170
		[Token(Token = "0x4000C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <loadBuildingsProgress>5__4;

		// Token: 0x04000C63 RID: 3171
		[Token(Token = "0x4000C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <loopFailSafe>5__5;

		// Token: 0x04000C64 RID: 3172
		[Token(Token = "0x4000C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;
	}
}
