using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Networking;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
public class fLZ
{
	// Token: 0x06000045 RID: 69
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x423220", Offset = "0x422220", VA = "0x180423220")]
	[PreserveSig]
	internal static extern int fLZcompressFile(int level, string inFile, string outFile, bool overwrite, IntPtr percent);

	// Token: 0x06000046 RID: 70
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x423310", Offset = "0x422310", VA = "0x180423310")]
	[PreserveSig]
	internal static extern int fLZdecompressFile(string inFile, string outFile, bool overwrite, IntPtr percent, IntPtr FileBuffer, int fileBufferLength);

	// Token: 0x06000047 RID: 71
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x423410", Offset = "0x422410", VA = "0x180423410")]
	[PreserveSig]
	public static extern void fLZreleaseBuffer(IntPtr buffer);

	// Token: 0x06000048 RID: 72
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x423490", Offset = "0x422490", VA = "0x180423490")]
	[PreserveSig]
	public static extern IntPtr create_Buffer(int size);

	// Token: 0x06000049 RID: 73
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x423510", Offset = "0x422510", VA = "0x180423510")]
	[PreserveSig]
	private static extern void addTo_Buffer(IntPtr destination, int offset, IntPtr buffer, int len);

	// Token: 0x0600004A RID: 74
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x4235B0", Offset = "0x4225B0", VA = "0x1804235B0")]
	[PreserveSig]
	internal static extern IntPtr fLZcompressBuffer(IntPtr buffer, int bufferLength, int level, ref int v);

	// Token: 0x0600004B RID: 75
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x423650", Offset = "0x422650", VA = "0x180423650")]
	[PreserveSig]
	internal static extern int fLZdecompressBuffer(IntPtr buffer, int bufferLength, IntPtr outbuffer);

	// Token: 0x0600004C RID: 76 RVA: 0x000021C0 File Offset: 0x000003C0
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x41EDE0", Offset = "0x41DDE0", VA = "0x18041EDE0")]
	public static int setFilePermissions(string filePath, string _user, string _group, string _other)
	{
		return 0;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x000021D8 File Offset: 0x000003D8
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x41EDF0", Offset = "0x41DDF0", VA = "0x18041EDF0")]
	internal static GCHandle gcA(object o)
	{
		return default(GCHandle);
	}

	// Token: 0x0600004E RID: 78 RVA: 0x000021F0 File Offset: 0x000003F0
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x4236F0", Offset = "0x4226F0", VA = "0x1804236F0")]
	private static bool checkObject(object fileBuffer, string filePath, ref GCHandle fbuf, ref IntPtr fileBufferPointer, ref int fileBufferLength)
	{
		return default(bool);
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002208 File Offset: 0x00000408
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x423880", Offset = "0x422880", VA = "0x180423880")]
	public static int compressFile(string inFile, string outFile, int level, bool overwrite, ulong[] progress)
	{
		return 0;
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002220 File Offset: 0x00000420
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x423A20", Offset = "0x422A20", VA = "0x180423A20")]
	public static int decompressFile(string inFile, string outFile, bool overwrite, ulong[] progress, [Optional] object fileBuffer)
	{
		return 0;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002238 File Offset: 0x00000438
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x423BE0", Offset = "0x422BE0", VA = "0x180423BE0")]
	public static bool compressBuffer(byte[] inBuffer, ref byte[] outBuffer, int level, bool includeSize = true)
	{
		return default(bool);
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x424060", Offset = "0x423060", VA = "0x180424060")]
	public static byte[] compressBuffer(byte[] inBuffer, int level, bool includeSize = true)
	{
		return null;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002250 File Offset: 0x00000450
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x4244D0", Offset = "0x4234D0", VA = "0x1804244D0")]
	public static bool decompressBuffer(byte[] inBuffer, ref byte[] outBuffer, bool useFooter = true, int customLength = 0)
	{
		return default(bool);
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002268 File Offset: 0x00000468
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x4246A0", Offset = "0x4236A0", VA = "0x1804246A0")]
	public static int decompressBufferFixed(byte[] inBuffer, ref byte[] outBuffer, bool safe = true, bool useFooter = true, int customLength = 0)
	{
		return 0;
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x424880", Offset = "0x423880", VA = "0x180424880")]
	public static byte[] decompressBuffer(byte[] inBuffer, bool useFooter = true, int customLength = 0)
	{
		return null;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x424A40", Offset = "0x423A40", VA = "0x180424A40")]
	public static IEnumerator downloadFlzFileNative(string url, Action<bool> downloadDone, [Optional] Action<IntPtr> pointer, [Optional] Action<int> fileSize)
	{
		return null;
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public fLZ()
	{
	}

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static bool isle;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	private const string libname = "libfastlz";

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static IntPtr nativeBuffer;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool nativeBufferIsBeingUsed;

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static int nativeOffset;

	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class CustomWebRequest3 : DownloadHandlerScript
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x420B50", Offset = "0x41FB50", VA = "0x180420B50")]
		public CustomWebRequest3()
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x420BB0", Offset = "0x41FBB0", VA = "0x180420BB0")]
		public CustomWebRequest3(byte[] buffer)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "7")]
		protected override byte[] GetData()
		{
			return null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x424CE0", Offset = "0x423CE0", VA = "0x180424CE0", Slot = "9")]
		protected override bool ReceiveData(byte[] bytesFromServer, int dataLength)
		{
			return default(bool);
		}
	}

	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	private sealed class <downloadFlzFileNative>d__22 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <downloadFlzFileNative>d__22(int <>1__state)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x424F20", Offset = "0x423F20", VA = "0x180424F20", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x424FE0", Offset = "0x423FE0", VA = "0x180424FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x425840", Offset = "0x424840", VA = "0x180425840")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000009")]
		private object Current
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x4258A0", Offset = "0x4248A0", VA = "0x1804258A0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000A")]
		private object Current
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool> downloadDone;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<IntPtr> pointer;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<int> fileSize;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <wr>5__2;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int <zipSize>5__3;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityWebRequest <wwwSK>5__4;
	}
}
