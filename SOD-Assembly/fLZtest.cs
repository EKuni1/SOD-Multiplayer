using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
public class fLZtest : MonoBehaviour
{
	// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x4258F0", Offset = "0x4248F0", VA = "0x1804258F0")]
	private void Start()
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x419610", Offset = "0x418610", VA = "0x180419610")]
	private void Update()
	{
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x425B90", Offset = "0x424B90", VA = "0x180425B90")]
	private void OnGUI()
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x425F60", Offset = "0x424F60", VA = "0x180425F60")]
	private void DoTests()
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x426510", Offset = "0x425510", VA = "0x180426510")]
	private IEnumerator DownloadTestFile()
	{
		return null;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x4265B0", Offset = "0x4255B0", VA = "0x1804265B0")]
	public fLZtest()
	{
	}

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x18")]
	private int lz1;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x1C")]
	private int lz2;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x20")]
	private int lz3;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x24")]
	private int lz4;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x28")]
	private int fbuftest;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x2C")]
	private int nFbuftest;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x30")]
	private ulong[] progress;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x38")]
	private ulong[] progress2;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x40")]
	private string myFile;

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x48")]
	private string uri;

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x50")]
	private string ppath;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x58")]
	private bool compressionStarted;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x59")]
	private bool downloadDone;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x60")]
	private byte[] buff;

	// Token: 0x04000064 RID: 100
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x68")]
	private byte[] fixedOutBuffer;

	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	private sealed class <DownloadTestFile>d__19 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <DownloadTestFile>d__19(int <>1__state)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x426840", Offset = "0x425840", VA = "0x180426840", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x426900", Offset = "0x425900", VA = "0x180426900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x426E40", Offset = "0x425E40", VA = "0x180426E40")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000B")]
		private object Current
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x426EA0", Offset = "0x425EA0", VA = "0x180426EA0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000C")]
		private object Current
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x20")]
		public fLZtest <>4__this;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;
	}
}
