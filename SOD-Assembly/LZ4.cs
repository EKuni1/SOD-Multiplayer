using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Networking;

// Token: 0x02000011 RID: 17
[Token(Token = "0x2000011")]
public class LZ4
{
	// Token: 0x06000073 RID: 115
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x426F70", Offset = "0x425F70", VA = "0x180426F70")]
	[PreserveSig]
	internal static extern int LZ4DecompressFile(string inFile, string outFile, IntPtr bytes, IntPtr FileBuffer, int fileBufferLength);

	// Token: 0x06000074 RID: 116
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x427060", Offset = "0x426060", VA = "0x180427060")]
	[PreserveSig]
	internal static extern int LZ4CompressFile(string inFile, string outFile, int level, IntPtr percentage, ref float rate);

	// Token: 0x06000075 RID: 117
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x427150", Offset = "0x426150", VA = "0x180427150")]
	[PreserveSig]
	public static extern void LZ4releaseBuffer(IntPtr buffer);

	// Token: 0x06000076 RID: 118
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x4271D0", Offset = "0x4261D0", VA = "0x1804271D0")]
	[PreserveSig]
	public static extern IntPtr LZ4Create_Buffer(int size);

	// Token: 0x06000077 RID: 119
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x427250", Offset = "0x426250", VA = "0x180427250")]
	[PreserveSig]
	private static extern void LZ4AddTo_Buffer(IntPtr destination, int offset, IntPtr buffer, int len);

	// Token: 0x06000078 RID: 120
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x4272F0", Offset = "0x4262F0", VA = "0x1804272F0")]
	[PreserveSig]
	internal static extern IntPtr LZ4CompressBuffer(IntPtr buffer, int bufferLength, ref int v, int level);

	// Token: 0x06000079 RID: 121
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x427390", Offset = "0x426390", VA = "0x180427390")]
	[PreserveSig]
	internal static extern int LZ4DecompressBuffer(IntPtr buffer, IntPtr outbuffer, int bufferLength);

	// Token: 0x0600007A RID: 122 RVA: 0x000022C8 File Offset: 0x000004C8
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x41EDF0", Offset = "0x41DDF0", VA = "0x18041EDF0")]
	internal static GCHandle gcA(object o)
	{
		return default(GCHandle);
	}

	// Token: 0x0600007B RID: 123 RVA: 0x000022E0 File Offset: 0x000004E0
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x41EDE0", Offset = "0x41DDE0", VA = "0x18041EDE0")]
	public static int setFilePermissions(string filePath, string _user, string _group, string _other)
	{
		return 0;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x000022F8 File Offset: 0x000004F8
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x427430", Offset = "0x426430", VA = "0x180427430")]
	private static bool checkObject(object fileBuffer, string filePath, ref GCHandle fbuf, ref IntPtr fileBufferPointer, ref int fileBufferLength)
	{
		return default(bool);
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002310 File Offset: 0x00000510
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x4275C0", Offset = "0x4265C0", VA = "0x1804275C0")]
	public static float compress(string inFile, string outFile, int level, float[] progress)
	{
		return 0f;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00002328 File Offset: 0x00000528
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x4277B0", Offset = "0x4267B0", VA = "0x1804277B0")]
	public static int decompress(string inFile, string outFile, ulong[] bytes, [Optional] object fileBuffer)
	{
		return 0;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00002340 File Offset: 0x00000540
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x427990", Offset = "0x426990", VA = "0x180427990")]
	public static bool compressBuffer(byte[] inBuffer, ref byte[] outBuffer, int level, bool includeSize = true)
	{
		return default(bool);
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x427E10", Offset = "0x426E10", VA = "0x180427E10")]
	public static byte[] compressBuffer(byte[] inBuffer, int level, bool includeSize = true)
	{
		return null;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00002358 File Offset: 0x00000558
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x428280", Offset = "0x427280", VA = "0x180428280")]
	public static int compressBufferPartialFixed(byte[] inBuffer, ref byte[] outBuffer, int outBufferPartialIndex, int level, bool includeSize = true)
	{
		return 0;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002370 File Offset: 0x00000570
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x428650", Offset = "0x427650", VA = "0x180428650")]
	public static int decompressBufferPartialFixed(byte[] inBuffer, ref byte[] outBuffer, int partialIndex, int compressedBufferSize, bool safe = true, bool useFooter = true, int customLength = 0)
	{
		return 0;
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002388 File Offset: 0x00000588
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x428810", Offset = "0x427810", VA = "0x180428810")]
	public static bool decompressBuffer(byte[] inBuffer, ref byte[] outBuffer, bool useFooter = true, int customLength = 0)
	{
		return default(bool);
	}

	// Token: 0x06000084 RID: 132 RVA: 0x000023A0 File Offset: 0x000005A0
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x4289A0", Offset = "0x4279A0", VA = "0x1804289A0")]
	public static int decompressBufferFixed(byte[] inBuffer, ref byte[] outBuffer, bool safe = true, bool useFooter = true, int customLength = 0)
	{
		return 0;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x428B40", Offset = "0x427B40", VA = "0x180428B40")]
	public static byte[] decompressBuffer(byte[] inBuffer, bool useFooter = true, int customLength = 0)
	{
		return null;
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x428CD0", Offset = "0x427CD0", VA = "0x180428CD0")]
	public static IEnumerator downloadLZ4FileNative(string url, Action<bool> downloadDone, [Optional] Action<IntPtr> pointer, [Optional] Action<int> fileSize)
	{
		return null;
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public LZ4()
	{
	}

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static bool isle;

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	private const string libname = "liblz4";

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static IntPtr nativeBuffer;

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool nativeBufferIsBeingUsed;

	// Token: 0x0400006D RID: 109
	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static int nativeOffset;

	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public class CustomWebRequest4 : DownloadHandlerScript
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x420B50", Offset = "0x41FB50", VA = "0x180420B50")]
		public CustomWebRequest4()
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x420BB0", Offset = "0x41FBB0", VA = "0x180420BB0")]
		public CustomWebRequest4(byte[] buffer)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "7")]
		protected override byte[] GetData()
		{
			return null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x428F70", Offset = "0x427F70", VA = "0x180428F70", Slot = "9")]
		protected override bool ReceiveData(byte[] bytesFromServer, int dataLength)
		{
			return default(bool);
		}
	}

	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	private sealed class <downloadLZ4FileNative>d__24 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <downloadLZ4FileNative>d__24(int <>1__state)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x4291B0", Offset = "0x4281B0", VA = "0x1804291B0", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x429270", Offset = "0x428270", VA = "0x180429270", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x429AD0", Offset = "0x428AD0", VA = "0x180429AD0")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000D")]
		private object Current
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x429B30", Offset = "0x428B30", VA = "0x180429B30", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000E")]
		private object Current
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool> downloadDone;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<IntPtr> pointer;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<int> fileSize;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <wr>5__2;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int <zipSize>5__3;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityWebRequest <wwwSK>5__4;
	}
}
