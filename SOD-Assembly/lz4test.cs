using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000014 RID: 20
[Token(Token = "0x2000014")]
public class lz4test : MonoBehaviour
{
	// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x429B80", Offset = "0x428B80", VA = "0x180429B80")]
	private void Start()
	{
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x419610", Offset = "0x418610", VA = "0x180419610")]
	private void Update()
	{
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x429E20", Offset = "0x428E20", VA = "0x180429E20")]
	private void OnGUI()
	{
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x42A240", Offset = "0x429240", VA = "0x18042A240")]
	private void DoTests()
	{
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000098")]
	[Address(RVA = "0x42AA30", Offset = "0x429A30", VA = "0x18042AA30")]
	private IEnumerator DownloadTestFile()
	{
		return null;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x42AAD0", Offset = "0x429AD0", VA = "0x18042AAD0")]
	public lz4test()
	{
	}

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x18")]
	private float lz1;

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x1C")]
	private int lz2;

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x20")]
	private int lz3;

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x24")]
	private int lz4;

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x28")]
	private int fbuftest;

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x2C")]
	private int nFbuftest;

	// Token: 0x0400007D RID: 125
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x30")]
	private ulong[] bytes;

	// Token: 0x0400007E RID: 126
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x38")]
	private float[] progress;

	// Token: 0x0400007F RID: 127
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x40")]
	private string myFile;

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x48")]
	private string uri;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x50")]
	private string ppath;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x58")]
	private bool compressionStarted;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x59")]
	private bool downloadDone;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x60")]
	private byte[] buff;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x68")]
	private byte[] fixedOutBuffer;

	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	private sealed class <DownloadTestFile>d__19 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <DownloadTestFile>d__19(int <>1__state)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x42AD80", Offset = "0x429D80", VA = "0x18042AD80", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x42AE40", Offset = "0x429E40", VA = "0x18042AE40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x42B380", Offset = "0x42A380", VA = "0x18042B380")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000F")]
		private object Current
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x42B3E0", Offset = "0x42A3E0", VA = "0x18042B3E0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000010")]
		private object Current
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x20")]
		public lz4test <>4__this;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;
	}
}
