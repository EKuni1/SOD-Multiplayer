using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000025 RID: 37
[Token(Token = "0x2000025")]
public class testZip : MonoBehaviour
{
	// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x5BC440", Offset = "0x5BB440", VA = "0x1805BC440")]
	private void plog(string t = "")
	{
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x5BC4E0", Offset = "0x5BB4E0", VA = "0x1805BC4E0")]
	private void Start()
	{
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000184")]
	[Address(RVA = "0x419610", Offset = "0x418610", VA = "0x180419610")]
	private void Update()
	{
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000185")]
	[Address(RVA = "0x5BC830", Offset = "0x5BB830", VA = "0x1805BC830")]
	private void OnGUI()
	{
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000186")]
	[Address(RVA = "0x5BD1B0", Offset = "0x5BC1B0", VA = "0x1805BD1B0")]
	private void DoDecompression()
	{
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x5BF8F0", Offset = "0x5BE8F0", VA = "0x1805BF8F0")]
	private void decompressFunc()
	{
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x5BFAD0", Offset = "0x5BEAD0", VA = "0x1805BFAD0")]
	private IEnumerator NativeFileBufferDownload()
	{
		return null;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x5BFB70", Offset = "0x5BEB70", VA = "0x1805BFB70")]
	private void DoDecompression_FileBuffer()
	{
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x5C0AA0", Offset = "0x5BFAA0", VA = "0x1805C0AA0")]
	private void DoInMemoryTest()
	{
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x5C1EB0", Offset = "0x5C0EB0", VA = "0x1805C1EB0")]
	private void DoGzipBz2Tests()
	{
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018C")]
	[Address(RVA = "0x5C2B90", Offset = "0x5C1B90", VA = "0x1805C2B90")]
	private void DoTarTests()
	{
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018D")]
	[Address(RVA = "0x5C3AA0", Offset = "0x5C2AA0", VA = "0x1805C3AA0")]
	private void DoDecompression_Merged()
	{
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600018E")]
	[Address(RVA = "0x5C5390", Offset = "0x5C4390", VA = "0x1805C5390")]
	private IEnumerator DownloadZipFile()
	{
		return null;
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600018F")]
	[Address(RVA = "0x5C5430", Offset = "0x5C4430", VA = "0x1805C5430")]
	public testZip()
	{
	}

	// Token: 0x040000EA RID: 234
	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x18")]
	private int zres;

	// Token: 0x040000EB RID: 235
	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x20")]
	private string myFile;

	// Token: 0x040000EC RID: 236
	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x28")]
	private string log;

	// Token: 0x040000ED RID: 237
	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x30")]
	private string ppath;

	// Token: 0x040000EE RID: 238
	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x38")]
	private bool compressionStarted;

	// Token: 0x040000EF RID: 239
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x39")]
	private bool pass;

	// Token: 0x040000F0 RID: 240
	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x3A")]
	private bool downloadDone;

	// Token: 0x040000F1 RID: 241
	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x3B")]
	private bool downloadDone2;

	// Token: 0x040000F2 RID: 242
	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x40")]
	private byte[] reusableBuffer;

	// Token: 0x040000F3 RID: 243
	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x48")]
	private byte[] reusableBuffer2;

	// Token: 0x040000F4 RID: 244
	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x50")]
	private byte[] reusableBuffer3;

	// Token: 0x040000F5 RID: 245
	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x58")]
	private byte[] fixedInBuffer;

	// Token: 0x040000F6 RID: 246
	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x60")]
	private byte[] fixedOutBuffer;

	// Token: 0x040000F7 RID: 247
	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x68")]
	private byte[] fixedBuffer;

	// Token: 0x040000F8 RID: 248
	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x70")]
	private int[] progress;

	// Token: 0x040000F9 RID: 249
	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x78")]
	private ulong[] progress2;

	// Token: 0x040000FA RID: 250
	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x80")]
	private ulong[] byteProgress;

	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	private sealed class <>c__DisplayClass23_0
	{
		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass23_0()
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x5C5710", Offset = "0x5C4710", VA = "0x1805C5710")]
		internal void <NativeFileBufferDownload>b__0(bool r)
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x3ED9D0", Offset = "0x3EC9D0", VA = "0x1803ED9D0")]
		internal void <NativeFileBufferDownload>b__1(lzip.inMemory result)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x5C5710", Offset = "0x5C4710", VA = "0x1805C5710")]
		internal void <NativeFileBufferDownload>b__2(bool r)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x5C5730", Offset = "0x5C4730", VA = "0x1805C5730")]
		internal void <NativeFileBufferDownload>b__3(IntPtr pointerResult)
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x5C5740", Offset = "0x5C4740", VA = "0x1805C5740")]
		internal void <NativeFileBufferDownload>b__4(int size)
		{
		}

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x10")]
		public testZip <>4__this;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x18")]
		public lzip.inMemory inMemZip;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x20")]
		public IntPtr nativePointer;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x28")]
		public int zipSize;
	}

	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	private sealed class <NativeFileBufferDownload>d__23 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <NativeFileBufferDownload>d__23(int <>1__state)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x5C5750", Offset = "0x5C4750", VA = "0x1805C5750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000019")]
		private object Current
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x5C6620", Offset = "0x5C5620", VA = "0x1805C6620", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001A")]
		private object Current
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x20")]
		public testZip <>4__this;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x28")]
		private testZip.<>c__DisplayClass23_0 <>8__1;
	}

	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	private sealed class <DownloadZipFile>d__29 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <DownloadZipFile>d__29(int <>1__state)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x5C6670", Offset = "0x5C5670", VA = "0x1805C6670", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x5C6730", Offset = "0x5C5730", VA = "0x1805C6730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x5C6CD0", Offset = "0x5C5CD0", VA = "0x1805C6CD0")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001B")]
		private object Current
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x5C6D30", Offset = "0x5C5D30", VA = "0x1805C6D30", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001C")]
		private object Current
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x20")]
		public testZip <>4__this;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;
	}
}
