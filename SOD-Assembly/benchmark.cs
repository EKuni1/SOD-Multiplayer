using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class benchmark : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x419190", Offset = "0x418190", VA = "0x180419190")]
	private void Start()
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x419610", Offset = "0x418610", VA = "0x180419610")]
	private void Update()
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x4196B0", Offset = "0x4186B0", VA = "0x1804196B0")]
	private void OnGUI()
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x419A80", Offset = "0x418A80", VA = "0x180419A80")]
	private IEnumerator decompressFunc()
	{
		return null;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x419B20", Offset = "0x418B20", VA = "0x180419B20")]
	private IEnumerator Download7ZFile()
	{
		return null;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x419BC0", Offset = "0x418BC0", VA = "0x180419BC0")]
	public benchmark()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	private int lzres;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x1C")]
	private int zipres;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	private int flzres;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x24")]
	private int brres;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x28")]
	private int lz4res;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x2C")]
	private int gzres;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x30")]
	private bool pass1;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x31")]
	private bool pass2;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x34")]
	private float t1;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x38")]
	private float tim;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x40")]
	private string myFile;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x48")]
	private string myFile2;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x50")]
	private string uncFile;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x58")]
	private string uri;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x60")]
	private string ppath;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x68")]
	private string log;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x70")]
	private bool downloadDone;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x71")]
	private bool benchmarkStarted;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x78")]
	private long tsize;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x80")]
	private GUIStyle style;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x88")]
	private int[] progress;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x90")]
	private ulong[] progress1;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x98")]
	private ulong[] progress2;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0xA0")]
	private float[] progress3;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0xA8")]
	private ulong[] progress4;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0xB0")]
	private ulong[] bytes;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0xB8")]
	private ulong[] gzProgress;

	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	private sealed class <decompressFunc>d__30 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <decompressFunc>d__30(int <>1__state)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x41A160", Offset = "0x419160", VA = "0x18041A160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000001")]
		private object Current
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x41E0E0", Offset = "0x41D0E0", VA = "0x18041E0E0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000002")]
		private object Current
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x20")]
		public benchmark <>4__this;
	}

	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	private sealed class <Download7ZFile>d__31 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Download7ZFile>d__31(int <>1__state)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x41E130", Offset = "0x41D130", VA = "0x18041E130", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x41E1F0", Offset = "0x41D1F0", VA = "0x18041E1F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x41E7C0", Offset = "0x41D7C0", VA = "0x18041E7C0")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000003")]
		private object Current
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x41E820", Offset = "0x41D820", VA = "0x18041E820", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000004")]
		private object Current
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x20")]
		public benchmark <>4__this;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;
	}
}
