using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Networking;

// Token: 0x02000017 RID: 23
[Token(Token = "0x2000017")]
public class lzma
{
	// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x42B4B0", Offset = "0x42A4B0", VA = "0x18042B4B0")]
	public static void setProps(int level = 5, int dictSize = 65536, int lc = 3, int lp = 0, int pb = 2, int fb = 32, int numThreads = 2)
	{
	}

	// Token: 0x060000A4 RID: 164
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x42B650", Offset = "0x42A650", VA = "0x18042B650")]
	[PreserveSig]
	internal static extern int decompress7zip(string filePath, string exctractionPath, bool fullPaths, string entry, IntPtr progress, IntPtr FileBuffer, int FileBufferLength);

	// Token: 0x060000A5 RID: 165
	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x42B770", Offset = "0x42A770", VA = "0x18042B770")]
	[PreserveSig]
	internal static extern int decompress7zip2(string filePath, string exctractionPath, bool fullPaths, string entry, IntPtr progress, IntPtr FileBuffer, int FileBufferLength);

	// Token: 0x060000A6 RID: 166
	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x42B890", Offset = "0x42A890", VA = "0x18042B890")]
	[PreserveSig]
	internal static extern IntPtr _getSize(string filePath, IntPtr FileBuffer, int FileBufferLength, bool justParse);

	// Token: 0x060000A7 RID: 167
	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x42B960", Offset = "0x42A960", VA = "0x18042B960")]
	[PreserveSig]
	internal static extern ulong entrySize(string filePath, string entry, IntPtr FileBuffer, int FileBufferLength);

	// Token: 0x060000A8 RID: 168
	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x42BA40", Offset = "0x42AA40", VA = "0x18042BA40")]
	[PreserveSig]
	internal static extern int lzmaUtil(bool encode, string inPath, string outPath, IntPtr Props);

	// Token: 0x060000A9 RID: 169
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x42BB20", Offset = "0x42AB20", VA = "0x18042BB20")]
	[PreserveSig]
	internal static extern int decode2Buf(string filePath, string entry, IntPtr buffer, IntPtr FileBuffer, int FileBufferLength);

	// Token: 0x060000AA RID: 170
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x42BC10", Offset = "0x42AC10", VA = "0x18042BC10")]
	[PreserveSig]
	public static extern void _releaseBuffer(IntPtr buffer);

	// Token: 0x060000AB RID: 171
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x42BC90", Offset = "0x42AC90", VA = "0x18042BC90")]
	[PreserveSig]
	public static extern IntPtr _createBuffer(int size);

	// Token: 0x060000AC RID: 172
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x42BD10", Offset = "0x42AD10", VA = "0x18042BD10")]
	[PreserveSig]
	private static extern void _addToBuffer(IntPtr destination, int offset, IntPtr buffer, int len);

	// Token: 0x060000AD RID: 173
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x42BDB0", Offset = "0x42ADB0", VA = "0x18042BDB0")]
	[PreserveSig]
	internal static extern IntPtr Lzma_Compress(IntPtr buffer, int bufferLength, bool makeHeader, ref int v, IntPtr Props);

	// Token: 0x060000AE RID: 174
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x42BE60", Offset = "0x42AE60", VA = "0x18042BE60")]
	[PreserveSig]
	internal static extern int Lzma_Uncompress(IntPtr buffer, int bufferLength, int uncompressedSize, IntPtr outbuffer, bool useHeader);

	// Token: 0x060000AF RID: 175
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x42BF20", Offset = "0x42AF20", VA = "0x18042BF20")]
	[PreserveSig]
	public static extern void sevenZcancel();

	// Token: 0x060000B0 RID: 176
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x42BF90", Offset = "0x42AF90", VA = "0x18042BF90")]
	[PreserveSig]
	public static extern void resetBytesRead();

	// Token: 0x060000B1 RID: 177
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x42C000", Offset = "0x42B000", VA = "0x18042C000")]
	[PreserveSig]
	public static extern ulong getBytesRead();

	// Token: 0x060000B2 RID: 178
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x42C070", Offset = "0x42B070", VA = "0x18042C070")]
	[PreserveSig]
	public static extern ulong getBytesWritten();

	// Token: 0x060000B3 RID: 179 RVA: 0x00002400 File Offset: 0x00000600
	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x41EDF0", Offset = "0x41DDF0", VA = "0x18041EDF0")]
	internal static GCHandle gcA(object o)
	{
		return default(GCHandle);
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002418 File Offset: 0x00000618
	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x41EDE0", Offset = "0x41DDE0", VA = "0x18041EDE0")]
	public static int setFilePermissions(string filePath, string _user, string _group, string _other)
	{
		return 0;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00002430 File Offset: 0x00000630
	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x42C0E0", Offset = "0x42B0E0", VA = "0x18042C0E0")]
	private static bool checkObject(object fileBuffer, string filePath, ref GCHandle fbuf, ref IntPtr fileBufferPointer, ref int fileBufferLength)
	{
		return default(bool);
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00002448 File Offset: 0x00000648
	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x42C270", Offset = "0x42B270", VA = "0x18042C270")]
	public static int doDecompress7zip(string filePath, [Optional] string exctractionPath, [Optional] int[] progress, bool largeFiles = false, bool fullPaths = true, [Optional] string entry, [Optional] object fileBuffer)
	{
		return 0;
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00002460 File Offset: 0x00000660
	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x42C530", Offset = "0x42B530", VA = "0x18042C530")]
	public static int doDecompress7zip(string filePath, [Optional] string exctractionPath, bool largeFiles = false, bool fullPaths = true, [Optional] string entry, [Optional] object fileBuffer)
	{
		return 0;
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00002478 File Offset: 0x00000678
	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x42C7E0", Offset = "0x42B7E0", VA = "0x18042C7E0")]
	public static int LzmaUtilEncode(string inPath, string outPath)
	{
		return 0;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00002490 File Offset: 0x00000690
	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x42C900", Offset = "0x42B900", VA = "0x18042C900")]
	public static int LzmaUtilDecode(string inPath, string outPath)
	{
		return 0;
	}

	// Token: 0x060000BA RID: 186 RVA: 0x000024A8 File Offset: 0x000006A8
	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x42C9A0", Offset = "0x42B9A0", VA = "0x18042C9A0")]
	public static ulong get7zInfo(string filePath, [Optional] object fileBuffer)
	{
		return 0UL;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x000024C0 File Offset: 0x000006C0
	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x42CEE0", Offset = "0x42BEE0", VA = "0x18042CEE0")]
	public static ulong get7zSize([Optional] string filePath, [Optional] string entry, [Optional] object fileBuffer)
	{
		return 0UL;
	}

	// Token: 0x060000BC RID: 188 RVA: 0x000024D8 File Offset: 0x000006D8
	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x42D070", Offset = "0x42C070", VA = "0x18042D070")]
	public static uint getHeadersSize(string filePath, [Optional] object fileBuffer)
	{
		return 0U;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x42D150", Offset = "0x42C150", VA = "0x18042D150")]
	public static byte[] decode2Buffer(string filePath, string entry, [Optional] object fileBuffer)
	{
		return null;
	}

	// Token: 0x060000BE RID: 190 RVA: 0x000024F0 File Offset: 0x000006F0
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x42D3A0", Offset = "0x42C3A0", VA = "0x18042D3A0")]
	public static int getAllFiles(string dir)
	{
		return 0;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002508 File Offset: 0x00000708
	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x42D400", Offset = "0x42C400", VA = "0x18042D400")]
	public static long getFileSize(string file)
	{
		return 0L;
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00002520 File Offset: 0x00000720
	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x42D4B0", Offset = "0x42C4B0", VA = "0x18042D4B0")]
	public static ulong getDirSize(string dir)
	{
		return 0UL;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00002538 File Offset: 0x00000738
	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x42D5E0", Offset = "0x42C5E0", VA = "0x18042D5E0")]
	public static bool compressBuffer(byte[] inBuffer, ref byte[] outBuffer, bool makeHeader = true)
	{
		return default(bool);
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x42D8C0", Offset = "0x42C8C0", VA = "0x18042D8C0")]
	public static byte[] compressBuffer(byte[] inBuffer, bool makeHeader = true)
	{
		return null;
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00002550 File Offset: 0x00000750
	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x42DB90", Offset = "0x42CB90", VA = "0x18042DB90")]
	public static bool compressBufferPartial(byte[] inBuffer, int inBufferPartialIndex, int inBufferPartialLength, ref byte[] outBuffer, bool makeHeader = true)
	{
		return default(bool);
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00002568 File Offset: 0x00000768
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x42DE70", Offset = "0x42CE70", VA = "0x18042DE70")]
	public static int compressBufferPartialFixed(byte[] inBuffer, int inBufferPartialIndex, int inBufferPartialLength, ref byte[] outBuffer, bool safe = true, bool makeHeader = true)
	{
		return 0;
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00002580 File Offset: 0x00000780
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x42E160", Offset = "0x42D160", VA = "0x18042E160")]
	public static int compressBufferFixed(byte[] inBuffer, ref byte[] outBuffer, bool safe = true, bool makeHeader = true)
	{
		return 0;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00002598 File Offset: 0x00000798
	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x42E450", Offset = "0x42D450", VA = "0x18042E450")]
	public static int decompressBuffer(byte[] inBuffer, ref byte[] outbuffer, bool useHeader = true, int customLength = 0)
	{
		return 0;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x42E640", Offset = "0x42D640", VA = "0x18042E640")]
	public static byte[] decompressBuffer(byte[] inBuffer, bool useHeader = true, int customLength = 0)
	{
		return null;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x000025B0 File Offset: 0x000007B0
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x42E830", Offset = "0x42D830", VA = "0x18042E830")]
	public static int decompressBufferFixed(byte[] inBuffer, ref byte[] outbuffer, bool safe = true, bool useHeader = true, int customLength = 0)
	{
		return 0;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x42EA20", Offset = "0x42DA20", VA = "0x18042EA20")]
	public static IEnumerator download7zFileNative(string url, Action<bool> downloadDone, [Optional] Action<IntPtr> pointer, [Optional] Action<int> fileSize)
	{
		return null;
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public lzma()
	{
	}

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string persitentDataPath;

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	internal static int[] props;

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal static bool defaultsSet;

	// Token: 0x0400008D RID: 141
	[Token(Token = "0x400008D")]
	private const string libname = "liblzma";

	// Token: 0x0400008E RID: 142
	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static List<string> ninfo;

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static List<ulong> sinfo;

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static int trueTotalFiles;

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static IntPtr nativeBuffer;

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static bool nativeBufferIsBeingUsed;

	// Token: 0x04000093 RID: 147
	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public static int nativeOffset;

	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public enum dic
	{
		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		K0004 = 4096,
		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		K0008 = 8192,
		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		K0016 = 16384,
		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		K0032 = 32768,
		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		K0064 = 65536,
		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		K0128 = 131072,
		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		K0256 = 262144,
		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		K0512 = 524288,
		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		K1024 = 1048576,
		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		K2048 = 2097152
	}

	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class CustomWebRequest2 : DownloadHandlerScript
	{
		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x420B50", Offset = "0x41FB50", VA = "0x180420B50")]
		public CustomWebRequest2()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x420BB0", Offset = "0x41FBB0", VA = "0x180420BB0")]
		public CustomWebRequest2(byte[] buffer)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "7")]
		protected override byte[] GetData()
		{
			return null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x42EF30", Offset = "0x42DF30", VA = "0x18042EF30", Slot = "9")]
		protected override bool ReceiveData(byte[] bytesFromServer, int dataLength)
		{
			return default(bool);
		}
	}

	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	private sealed class <download7zFileNative>d__49 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <download7zFileNative>d__49(int <>1__state)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x42F170", Offset = "0x42E170", VA = "0x18042F170", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x42F230", Offset = "0x42E230", VA = "0x18042F230", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x42FA90", Offset = "0x42EA90", VA = "0x18042FA90")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000011")]
		private object Current
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x42FAF0", Offset = "0x42EAF0", VA = "0x18042FAF0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000012")]
		private object Current
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool> downloadDone;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<IntPtr> pointer;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<int> fileSize;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <wr>5__2;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int <zipSize>5__3;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityWebRequest <wwwSK>5__4;
	}
}
