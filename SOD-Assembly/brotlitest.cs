using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
public class brotlitest : MonoBehaviour
{
	// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x4217E0", Offset = "0x4207E0", VA = "0x1804217E0")]
	private void Start()
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x419610", Offset = "0x418610", VA = "0x180419610")]
	private void Update()
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x421A80", Offset = "0x420A80", VA = "0x180421A80")]
	private void OnGUI()
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x421ED0", Offset = "0x420ED0", VA = "0x180421ED0")]
	private void DoTests()
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x4226F0", Offset = "0x4216F0", VA = "0x1804226F0")]
	private IEnumerator DownloadTestFile()
	{
		return null;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x422790", Offset = "0x421790", VA = "0x180422790")]
	public brotlitest()
	{
	}

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x18")]
	private int lz1;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x1C")]
	private int lz2;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x20")]
	private int lz3;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x24")]
	private int lz4;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x28")]
	private int fbuftest;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x2C")]
	private int nFbuftest;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x30")]
	private ulong[] progress;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x38")]
	private ulong[] progress2;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x40")]
	private ulong[] progress3;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x48")]
	private ulong[] progress4;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x50")]
	private string myFile;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x58")]
	private string uri;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x60")]
	private string ppath;

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x68")]
	private bool compressionStarted;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x69")]
	private bool downloadDone;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x6A")]
	private bool downloadError;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x70")]
	private byte[] buff;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x78")]
	private byte[] bt;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x80")]
	private byte[] bt2;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x88")]
	private byte[] fixedOutBuffer;

	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	private sealed class <DownloadTestFile>d__24 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <DownloadTestFile>d__24(int <>1__state)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x422AE0", Offset = "0x421AE0", VA = "0x180422AE0", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x422BA0", Offset = "0x421BA0", VA = "0x180422BA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x4230F0", Offset = "0x4220F0", VA = "0x1804230F0")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000007")]
		private object Current
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x423150", Offset = "0x422150", VA = "0x180423150", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000008")]
		private object Current
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x20")]
		public brotlitest <>4__this;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;
	}
}
