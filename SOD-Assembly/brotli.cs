using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Networking;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class brotli
{
	// Token: 0x06000014 RID: 20
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x41E870", Offset = "0x41D870", VA = "0x18041E870")]
	[PreserveSig]
	internal static extern int brCompress(string inFile, string outFile, IntPtr proc, int quality, int lgwin, int lgblock, int mode);

	// Token: 0x06000015 RID: 21
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x41E970", Offset = "0x41D970", VA = "0x18041E970")]
	[PreserveSig]
	internal static extern int brDecompresss(string inFile, string outFile, IntPtr proc, IntPtr FileBuffer, int fileBufferLength);

	// Token: 0x06000016 RID: 22
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x41EA60", Offset = "0x41DA60", VA = "0x18041EA60")]
	[PreserveSig]
	public static extern void brReleaseBuffer(IntPtr buffer);

	// Token: 0x06000017 RID: 23
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x41EAE0", Offset = "0x41DAE0", VA = "0x18041EAE0")]
	[PreserveSig]
	public static extern IntPtr brCreate_Buffer(int size);

	// Token: 0x06000018 RID: 24
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x41EB60", Offset = "0x41DB60", VA = "0x18041EB60")]
	[PreserveSig]
	private static extern void brAddTo_Buffer(IntPtr destination, int offset, IntPtr buffer, int len);

	// Token: 0x06000019 RID: 25
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x41EC00", Offset = "0x41DC00", VA = "0x18041EC00")]
	[PreserveSig]
	internal static extern IntPtr brCompressBuffer(int bufferLength, IntPtr buffer, IntPtr encodedSize, IntPtr proc, int quality, int lgwin, int lgblock, int mode);

	// Token: 0x0600001A RID: 26
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x41ECB0", Offset = "0x41DCB0", VA = "0x18041ECB0")]
	[PreserveSig]
	internal static extern int brGetDecodedSize(int bufferLength, IntPtr buffer);

	// Token: 0x0600001B RID: 27
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x41ED40", Offset = "0x41DD40", VA = "0x18041ED40")]
	[PreserveSig]
	internal static extern int brDecompressBuffer(int bufferLength, IntPtr buffer, int outLength, IntPtr outbuffer);

	// Token: 0x0600001C RID: 28 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x41EDE0", Offset = "0x41DDE0", VA = "0x18041EDE0")]
	public static int setFilePermissions(string filePath, string _user, string _group, string _other)
	{
		return 0;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x41EDF0", Offset = "0x41DDF0", VA = "0x18041EDF0")]
	internal static GCHandle gcA(object o)
	{
		return default(GCHandle);
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x41EE00", Offset = "0x41DE00", VA = "0x18041EE00")]
	private static bool checkObject(object fileBuffer, string filePath, ref GCHandle fbuf, ref IntPtr fileBufferPointer, ref int fileBufferLength)
	{
		return default(bool);
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x41EF90", Offset = "0x41DF90", VA = "0x18041EF90")]
	public static int compressFile(string inFile, string outFile, ulong[] proc, int quality = 9, int lgwin = 19, int lgblock = 0, int mode = 0)
	{
		return 0;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x41F1A0", Offset = "0x41E1A0", VA = "0x18041F1A0")]
	public static int decompressFile(string inFile, string outFile, ulong[] proc, [Optional] object fileBuffer)
	{
		return 0;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x41F390", Offset = "0x41E390", VA = "0x18041F390")]
	public static int getDecodedSize(byte[] inBuffer)
	{
		return 0;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x41F490", Offset = "0x41E490", VA = "0x18041F490")]
	public static bool compressBuffer(byte[] inBuffer, ref byte[] outBuffer, ulong[] proc, bool includeSize = false, int quality = 9, int lgwin = 19, int lgblock = 0, int mode = 0)
	{
		return default(bool);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x41F9F0", Offset = "0x41E9F0", VA = "0x18041F9F0")]
	public static byte[] compressBuffer(byte[] inBuffer, int[] proc, bool includeSize = false, int quality = 9, int lgwin = 19, int lgblock = 0, int mode = 0)
	{
		return null;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x41FF20", Offset = "0x41EF20", VA = "0x18041FF20")]
	public static int compressBuffer(byte[] inBuffer, byte[] outBuffer, int[] proc, bool includeSize = false, int quality = 9, int lgwin = 19, int lgblock = 0, int mode = 0)
	{
		return 0;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x4203A0", Offset = "0x41F3A0", VA = "0x1804203A0")]
	public static bool decompressBuffer(byte[] inBuffer, ref byte[] outBuffer, bool useFooter = false, int unCompressedSize = 0)
	{
		return default(bool);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x420570", Offset = "0x41F570", VA = "0x180420570")]
	public static byte[] decompressBuffer(byte[] inBuffer, bool useFooter = false, int unCompressedSize = 0)
	{
		return null;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x420740", Offset = "0x41F740", VA = "0x180420740")]
	public static int decompressBuffer(byte[] inBuffer, byte[] outBuffer, bool useFooter = false, int unCompressedSize = 0)
	{
		return 0;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x4208F0", Offset = "0x41F8F0", VA = "0x1804208F0")]
	public static IEnumerator downloadBrFileNative(string url, Action<bool> downloadDone, [Optional] Action<IntPtr> pointer, [Optional] Action<int> fileSize)
	{
		return null;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public brotli()
	{
	}

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	private const string libname = "libbrotli";

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static IntPtr nativeBuffer;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static bool nativeBufferIsBeingUsed;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int nativeOffset;

	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class CustomWebRequest5 : DownloadHandlerScript
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x420B50", Offset = "0x41FB50", VA = "0x180420B50")]
		public CustomWebRequest5()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x420BB0", Offset = "0x41FBB0", VA = "0x180420BB0")]
		public CustomWebRequest5(byte[] buffer)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "7")]
		protected override byte[] GetData()
		{
			return null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x420BD0", Offset = "0x41FBD0", VA = "0x180420BD0", Slot = "9")]
		protected override bool ReceiveData(byte[] bytesFromServer, int dataLength)
		{
			return default(bool);
		}
	}

	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	private sealed class <downloadBrFileNative>d__24 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <downloadBrFileNative>d__24(int <>1__state)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x420E10", Offset = "0x41FE10", VA = "0x180420E10", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x420ED0", Offset = "0x41FED0", VA = "0x180420ED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x421730", Offset = "0x420730", VA = "0x180421730")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000005")]
		private object Current
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x421790", Offset = "0x420790", VA = "0x180421790", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000006")]
		private object Current
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool> downloadDone;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<IntPtr> pointer;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<int> fileSize;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <wr>5__2;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int <zipSize>5__3;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityWebRequest <wwwSK>5__4;
	}
}
