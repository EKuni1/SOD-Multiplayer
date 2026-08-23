using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000188 RID: 392
[Token(Token = "0x2000188")]
public class BuildingCreator : Creator
{
	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700003B")]
	public static BuildingCreator Instance
	{
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x52FFB0", Offset = "0x52EFB0", VA = "0x18052FFB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A11")]
	[Address(RVA = "0x52FFF0", Offset = "0x52EFF0", VA = "0x18052FFF0")]
	private void Awake()
	{
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A12")]
	[Address(RVA = "0x530340", Offset = "0x52F340", VA = "0x180530340", Slot = "4")]
	public override void StartLoading()
	{
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A13")]
	[Address(RVA = "0x5303B0", Offset = "0x52F3B0", VA = "0x1805303B0")]
	private IEnumerator Load()
	{
		return null;
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A14")]
	[Address(RVA = "0x530400", Offset = "0x52F400", VA = "0x180530400")]
	public BuildingCreator()
	{
	}

	// Token: 0x04000A34 RID: 2612
	[Token(Token = "0x4000A34")]
	[FieldOffset(Offset = "0x18")]
	public int loadChunk;

	// Token: 0x04000A35 RID: 2613
	[Token(Token = "0x4000A35")]
	[FieldOffset(Offset = "0x20")]
	private List<BuildingPreset> buildingPresets;

	// Token: 0x04000A36 RID: 2614
	[Token(Token = "0x4000A36")]
	[FieldOffset(Offset = "0x28")]
	private List<BuildingCreator.PickBuilding> selectionList;

	// Token: 0x04000A37 RID: 2615
	[Token(Token = "0x4000A37")]
	[FieldOffset(Offset = "0x0")]
	private static BuildingCreator _instance;

	// Token: 0x02000189 RID: 393
	[Token(Token = "0x2000189")]
	public class PickBuilding
	{
		// Token: 0x06000A15 RID: 2581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public PickBuilding()
		{
		}

		// Token: 0x04000A38 RID: 2616
		[Token(Token = "0x4000A38")]
		[FieldOffset(Offset = "0x10")]
		public BuildingPreset preset;

		// Token: 0x04000A39 RID: 2617
		[Token(Token = "0x4000A39")]
		[FieldOffset(Offset = "0x18")]
		public float rank;
	}

	// Token: 0x0200018A RID: 394
	[Token(Token = "0x200018A")]
	private sealed class <Load>d__9 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000A16 RID: 2582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Load>d__9(int <>1__state)
		{
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000066D8 File Offset: 0x000048D8
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x530510", Offset = "0x52F510", VA = "0x180530510", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003C")]
		private object Current
		{
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x530590", Offset = "0x52F590", VA = "0x180530590", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003D")]
		private object Current
		{
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A3A RID: 2618
		[Token(Token = "0x4000A3A")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000A3B RID: 2619
		[Token(Token = "0x4000A3B")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}
}
