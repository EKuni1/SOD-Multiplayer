using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020001B1 RID: 433
[Token(Token = "0x20001B1")]
public class StartingEvidenceCreator : Creator
{
	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700005F")]
	public static StartingEvidenceCreator Instance
	{
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x543130", Offset = "0x542130", VA = "0x180543130")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AC7")]
	[Address(RVA = "0x543170", Offset = "0x542170", VA = "0x180543170")]
	private void Awake()
	{
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AC8")]
	[Address(RVA = "0x5434C0", Offset = "0x5424C0", VA = "0x1805434C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AC9")]
	[Address(RVA = "0x5436D0", Offset = "0x5426D0", VA = "0x1805436D0", Slot = "4")]
	public override void StartLoading()
	{
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ACA")]
	[Address(RVA = "0x543790", Offset = "0x542790", VA = "0x180543790")]
	private IEnumerator GenChunk()
	{
		return null;
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ACB")]
	[Address(RVA = "0x543830", Offset = "0x542830", VA = "0x180543830")]
	public void CompileEvidence()
	{
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000ACC")]
	[Address(RVA = "0x543880", Offset = "0x542880", VA = "0x180543880")]
	private IEnumerator Compile()
	{
		return null;
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ACD")]
	[Address(RVA = "0x543920", Offset = "0x542920", VA = "0x180543920")]
	public StartingEvidenceCreator()
	{
	}

	// Token: 0x04000AC3 RID: 2755
	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x18")]
	public int loadChunk;

	// Token: 0x04000AC4 RID: 2756
	[Token(Token = "0x4000AC4")]
	[FieldOffset(Offset = "0x1C")]
	public int loadChunkCompile;

	// Token: 0x04000AC5 RID: 2757
	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0x20")]
	public bool called;

	// Token: 0x04000AC6 RID: 2758
	[Token(Token = "0x4000AC6")]
	[FieldOffset(Offset = "0x0")]
	private static StartingEvidenceCreator _instance;

	// Token: 0x020001B2 RID: 434
	[Token(Token = "0x20001B2")]
	private sealed class <GenChunk>d__9 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000ACE RID: 2766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <GenChunk>d__9(int <>1__state)
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00006960 File Offset: 0x00004B60
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x543980", Offset = "0x542980", VA = "0x180543980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000060")]
		private object Current
		{
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x544700", Offset = "0x543700", VA = "0x180544700", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000061")]
		private object Current
		{
			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000AC7 RID: 2759
		[Token(Token = "0x4000AC7")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000AC8 RID: 2760
		[Token(Token = "0x4000AC8")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000AC9 RID: 2761
		[Token(Token = "0x4000AC9")]
		[FieldOffset(Offset = "0x20")]
		public StartingEvidenceCreator <>4__this;

		// Token: 0x04000ACA RID: 2762
		[Token(Token = "0x4000ACA")]
		[FieldOffset(Offset = "0x28")]
		private List<Controller> <evToCreate>5__2;

		// Token: 0x04000ACB RID: 2763
		[Token(Token = "0x4000ACB")]
		[FieldOffset(Offset = "0x30")]
		private int <evProgress>5__3;
	}

	// Token: 0x020001B3 RID: 435
	[Token(Token = "0x20001B3")]
	private sealed class <Compile>d__11 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000AD4 RID: 2772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Compile>d__11(int <>1__state)
		{
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00006978 File Offset: 0x00004B78
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x544750", Offset = "0x543750", VA = "0x180544750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000062")]
		private object Current
		{
			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x544A20", Offset = "0x543A20", VA = "0x180544A20", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000063")]
		private object Current
		{
			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000ACC RID: 2764
		[Token(Token = "0x4000ACC")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000ACD RID: 2765
		[Token(Token = "0x4000ACD")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000ACE RID: 2766
		[Token(Token = "0x4000ACE")]
		[FieldOffset(Offset = "0x20")]
		public StartingEvidenceCreator <>4__this;

		// Token: 0x04000ACF RID: 2767
		[Token(Token = "0x4000ACF")]
		[FieldOffset(Offset = "0x28")]
		private int <evProgress>5__2;
	}
}
