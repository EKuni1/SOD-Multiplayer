using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Networking;

// Token: 0x0200001F RID: 31
[Token(Token = "0x200001F")]
public class lzip
{
	// Token: 0x060000F0 RID: 240
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x433320", Offset = "0x432320", VA = "0x180433320")]
	[PreserveSig]
	public static extern void setTarEncoding(uint encoding);

	// Token: 0x060000F1 RID: 241
	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x4333A0", Offset = "0x4323A0", VA = "0x1804333A0")]
	[PreserveSig]
	public static extern void setEncoding(uint encoding);

	// Token: 0x060000F2 RID: 242
	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x433420", Offset = "0x432420", VA = "0x180433420")]
	[PreserveSig]
	internal static extern bool zipValidateFile(string zipArchive, IntPtr FileBuffer, int fileBufferLength);

	// Token: 0x060000F3 RID: 243
	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x4334D0", Offset = "0x4324D0", VA = "0x1804334D0")]
	[PreserveSig]
	internal static extern int zipGetTotalFiles(string zipArchive, IntPtr FileBuffer, int fileBufferLength);

	// Token: 0x060000F4 RID: 244
	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x433570", Offset = "0x432570", VA = "0x180433570")]
	[PreserveSig]
	internal static extern int zipGetTotalEntries(string zipArchive, IntPtr FileBuffer, int fileBufferLength);

	// Token: 0x060000F5 RID: 245
	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x433610", Offset = "0x432610", VA = "0x180433610")]
	[PreserveSig]
	internal static extern int zipGetInfoA(string zipArchive, IntPtr total, IntPtr FileBuffer, int fileBufferLength);

	// Token: 0x060000F6 RID: 246
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x4336C0", Offset = "0x4326C0", VA = "0x1804336C0")]
	[PreserveSig]
	internal static extern IntPtr zipGetInfo(string zipArchive, int size, IntPtr unc, IntPtr comp, IntPtr offs, IntPtr FileBuffer, int fileBufferLength);

	// Token: 0x060000F7 RID: 247
	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x433770", Offset = "0x432770", VA = "0x180433770")]
	[PreserveSig]
	public static extern void releaseBuffer(IntPtr buffer);

	// Token: 0x060000F8 RID: 248
	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x4337F0", Offset = "0x4327F0", VA = "0x1804337F0")]
	[PreserveSig]
	public static extern IntPtr createBuffer(int size);

	// Token: 0x060000F9 RID: 249
	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x433870", Offset = "0x432870", VA = "0x180433870")]
	[PreserveSig]
	private static extern void addToBuffer(IntPtr destination, int offset, IntPtr buffer, int len);

	// Token: 0x060000FA RID: 250
	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x433910", Offset = "0x432910", VA = "0x180433910")]
	[PreserveSig]
	internal static extern ulong zipGetEntrySize(string zipArchive, string entry, IntPtr FileBuffer, int fileBufferLength);

	// Token: 0x060000FB RID: 251
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x4339D0", Offset = "0x4329D0", VA = "0x1804339D0")]
	[PreserveSig]
	internal static extern bool zipEntryExists(string zipArchive, string entry, IntPtr FileBuffer, int fileBufferLength);

	// Token: 0x060000FC RID: 252
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x433A90", Offset = "0x432A90", VA = "0x180433A90")]
	[PreserveSig]
	internal static extern int zipCD(int levelOfCompression, string zipArchive, string inFilePath, string fileName, string comment, string password, bool useBz2, int diskSize, IntPtr bprog);

	// Token: 0x060000FD RID: 253
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x433BD0", Offset = "0x432BD0", VA = "0x180433BD0")]
	[PreserveSig]
	internal static extern int zipCDList(int levelOfCompression, string zipArchive, IntPtr filename, int arrayLength, IntPtr prog, IntPtr filenameForced, string password, bool useBz2, int diskSize, IntPtr bprog);

	// Token: 0x060000FE RID: 254
	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x433D00", Offset = "0x432D00", VA = "0x180433D00")]
	[PreserveSig]
	internal static extern bool zipBuf2File(int levelOfCompression, string zipArchive, string arcFilename, IntPtr buffer, int bufferSize, string comment, string password, bool useBz2);

	// Token: 0x060000FF RID: 255
	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x433E20", Offset = "0x432E20", VA = "0x180433E20")]
	[PreserveSig]
	internal static extern int zipDeleteFile(string zipArchive, string arcFilename, string tempArchive);

	// Token: 0x06000100 RID: 256
	[Token(Token = "0x6000100")]
	[Address(RVA = "0x433ED0", Offset = "0x432ED0", VA = "0x180433ED0")]
	[PreserveSig]
	internal static extern int zipEntry2Buffer(string zipArchive, string entry, IntPtr buffer, int bufferSize, IntPtr FileBuffer, int fileBufferLength, string password);

	// Token: 0x06000101 RID: 257
	[Token(Token = "0x6000101")]
	[Address(RVA = "0x433FE0", Offset = "0x432FE0", VA = "0x180433FE0")]
	[PreserveSig]
	internal static extern IntPtr zipCompressBuffer(IntPtr source, int sourceLen, int levelOfCompression, ref int v);

	// Token: 0x06000102 RID: 258
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x434080", Offset = "0x433080", VA = "0x180434080")]
	[PreserveSig]
	internal static extern IntPtr zipDecompressBuffer(IntPtr source, int sourceLen, ref int v);

	// Token: 0x06000103 RID: 259
	[Token(Token = "0x6000103")]
	[Address(RVA = "0x434120", Offset = "0x433120", VA = "0x180434120")]
	[PreserveSig]
	internal static extern int zipEX(string zipArchive, string outPath, IntPtr progress, IntPtr FileBuffer, int fileBufferLength, IntPtr proc, string password);

	// Token: 0x06000104 RID: 260
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x434230", Offset = "0x433230", VA = "0x180434230")]
	[PreserveSig]
	internal static extern int zipEntry(string zipArchive, string arcFilename, string outpath, IntPtr FileBuffer, int fileBufferLength, IntPtr proc, string password);

	// Token: 0x06000105 RID: 261
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x434340", Offset = "0x433340", VA = "0x180434340")]
	[PreserveSig]
	internal static extern int zipEntryList(string zipArchive, IntPtr outpath, IntPtr filename, int arrayLength, IntPtr FileBuffer, int fileBufferLength, IntPtr proc, string password);

	// Token: 0x06000106 RID: 262
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x434450", Offset = "0x433450", VA = "0x180434450")]
	[PreserveSig]
	internal static extern uint getEntryDateTime(string zipArchive, string arcFilename, IntPtr FileBuffer, int fileBufferLength);

	// Token: 0x06000107 RID: 263
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x434510", Offset = "0x433510", VA = "0x180434510")]
	[PreserveSig]
	internal static extern int freeMemStruct(IntPtr buffer);

	// Token: 0x06000108 RID: 264
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x434590", Offset = "0x433590", VA = "0x180434590")]
	[PreserveSig]
	internal static extern IntPtr zipCDMem(IntPtr info, IntPtr pnt, int levelOfCompression, IntPtr source, int sourceLen, string fileName, string comment, string password, bool useBz2);

	// Token: 0x06000109 RID: 265
	[Token(Token = "0x6000109")]
	[Address(RVA = "0x4346C0", Offset = "0x4336C0", VA = "0x1804346C0")]
	[PreserveSig]
	internal static extern IntPtr initMemStruct();

	// Token: 0x0600010A RID: 266
	[Token(Token = "0x600010A")]
	[Address(RVA = "0x434730", Offset = "0x433730", VA = "0x180434730")]
	[PreserveSig]
	internal static extern IntPtr initFileStruct();

	// Token: 0x0600010B RID: 267
	[Token(Token = "0x600010B")]
	[Address(RVA = "0x4347A0", Offset = "0x4337A0", VA = "0x1804347A0")]
	[PreserveSig]
	internal static extern int freeMemZ(IntPtr pointer);

	// Token: 0x0600010C RID: 268
	[Token(Token = "0x600010C")]
	[Address(RVA = "0x434820", Offset = "0x433820", VA = "0x180434820")]
	[PreserveSig]
	internal static extern int freeFileZ(IntPtr pointer);

	// Token: 0x0600010D RID: 269
	[Token(Token = "0x600010D")]
	[Address(RVA = "0x4348A0", Offset = "0x4338A0", VA = "0x1804348A0")]
	[PreserveSig]
	internal static extern IntPtr zipCDMemStart(IntPtr info, IntPtr pnt, IntPtr fileStruct, IntPtr memStruct);

	// Token: 0x0600010E RID: 270
	[Token(Token = "0x600010E")]
	[Address(RVA = "0x434950", Offset = "0x433950", VA = "0x180434950")]
	[PreserveSig]
	internal static extern int zipCDMemAdd(IntPtr zf, int levelOfCompression, IntPtr source, int sourceLen, string fileName, string comment, string password, bool useBz2);

	// Token: 0x0600010F RID: 271
	[Token(Token = "0x600010F")]
	[Address(RVA = "0x434A70", Offset = "0x433A70", VA = "0x180434A70")]
	[PreserveSig]
	internal static extern IntPtr zipCDMemClose(IntPtr zf, IntPtr memStruct, IntPtr info, int err);

	// Token: 0x06000110 RID: 272
	[Token(Token = "0x6000110")]
	[Address(RVA = "0x434B20", Offset = "0x433B20", VA = "0x180434B20")]
	[PreserveSig]
	internal static extern int zipGzip(IntPtr source, int sourceLen, IntPtr outBuffer, int levelOfCompression, bool addHeader, bool addFooter);

	// Token: 0x06000111 RID: 273
	[Token(Token = "0x6000111")]
	[Address(RVA = "0x434BF0", Offset = "0x433BF0", VA = "0x180434BF0")]
	[PreserveSig]
	internal static extern int zipUnGzip(IntPtr source, int sourceLen, IntPtr outBuffer, int outLen, bool hasHeader, bool hasFooter);

	// Token: 0x06000112 RID: 274
	[Token(Token = "0x6000112")]
	[Address(RVA = "0x434CC0", Offset = "0x433CC0", VA = "0x180434CC0")]
	[PreserveSig]
	internal static extern int zipUnGzip2(IntPtr source, int sourceLen, IntPtr outBuffer, int outLen);

	// Token: 0x06000113 RID: 275
	[Token(Token = "0x6000113")]
	[Address(RVA = "0x434D60", Offset = "0x433D60", VA = "0x180434D60")]
	[PreserveSig]
	internal static extern int gzip_File(string inFile, string outFile, int level, IntPtr progress, bool addHeader);

	// Token: 0x06000114 RID: 276
	[Token(Token = "0x6000114")]
	[Address(RVA = "0x434E30", Offset = "0x433E30", VA = "0x180434E30")]
	[PreserveSig]
	internal static extern int ungzip_File(string inFile, string outFile, IntPtr progress);

	// Token: 0x06000115 RID: 277
	[Token(Token = "0x6000115")]
	[Address(RVA = "0x434EE0", Offset = "0x433EE0", VA = "0x180434EE0")]
	[PreserveSig]
	public static extern void setCancel();

	// Token: 0x06000116 RID: 278
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x434F50", Offset = "0x433F50", VA = "0x180434F50")]
	[PreserveSig]
	internal static extern int readTarA(string zipArchive, IntPtr total);

	// Token: 0x06000117 RID: 279
	[Token(Token = "0x6000117")]
	[Address(RVA = "0x434FE0", Offset = "0x433FE0", VA = "0x180434FE0")]
	[PreserveSig]
	internal static extern IntPtr readTar(string zipArchive, int size, IntPtr unc);

	// Token: 0x06000118 RID: 280
	[Token(Token = "0x6000118")]
	[Address(RVA = "0x435080", Offset = "0x434080", VA = "0x180435080")]
	[PreserveSig]
	internal static extern int createTar(string outFile, IntPtr filePath, IntPtr filename, int arrayLength, IntPtr prog, IntPtr bprog);

	// Token: 0x06000119 RID: 281
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x435130", Offset = "0x434130", VA = "0x180435130")]
	[PreserveSig]
	internal static extern int extractTar(string inFile, string outDir, string entry, IntPtr prog, IntPtr bprog, bool fullPaths);

	// Token: 0x0600011A RID: 282
	[Token(Token = "0x600011A")]
	[Address(RVA = "0x435210", Offset = "0x434210", VA = "0x180435210")]
	[PreserveSig]
	internal static extern int bz2(bool decompress, int level, string inFile, string outFile, IntPtr byteProgress);

	// Token: 0x0600011B RID: 283 RVA: 0x00002628 File Offset: 0x00000828
	[Token(Token = "0x600011B")]
	[Address(RVA = "0x41EDF0", Offset = "0x41DDF0", VA = "0x18041EDF0")]
	internal static GCHandle gcA(object o)
	{
		return default(GCHandle);
	}

	// Token: 0x0600011C RID: 284 RVA: 0x00002640 File Offset: 0x00000840
	[Token(Token = "0x600011C")]
	[Address(RVA = "0x4352D0", Offset = "0x4342D0", VA = "0x1804352D0")]
	private static bool checkObject(object o, string zipArchive, ref int len, ref IntPtr ptr)
	{
		return default(bool);
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00002658 File Offset: 0x00000858
	[Token(Token = "0x600011D")]
	[Address(RVA = "0x435410", Offset = "0x434410", VA = "0x180435410")]
	public static ulong getFileInfo(string zipArchive, [Optional] object fileBuffer)
	{
		return 0UL;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00002670 File Offset: 0x00000870
	[Token(Token = "0x600011E")]
	[Address(RVA = "0x4362A0", Offset = "0x4352A0", VA = "0x1804362A0")]
	public static int getEntryIndex(string entry)
	{
		return 0;
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00002688 File Offset: 0x00000888
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x436460", Offset = "0x435460", VA = "0x180436460")]
	public static int getTotalFiles(string zipArchive, [Optional] object fileBuffer)
	{
		return 0;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x000026A0 File Offset: 0x000008A0
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x436740", Offset = "0x435740", VA = "0x180436740")]
	public static int getTotalEntries(string zipArchive, [Optional] object fileBuffer)
	{
		return 0;
	}

	// Token: 0x06000121 RID: 289 RVA: 0x000026B8 File Offset: 0x000008B8
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x436A20", Offset = "0x435A20", VA = "0x180436A20")]
	public static ulong getEntrySize(string zipArchive, string entry, [Optional] object fileBuffer)
	{
		return 0UL;
	}

	// Token: 0x06000122 RID: 290 RVA: 0x000026D0 File Offset: 0x000008D0
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x436D90", Offset = "0x435D90", VA = "0x180436D90")]
	public static bool entryExists(string zipArchive, string entry, [Optional] object fileBuffer)
	{
		return default(bool);
	}

	// Token: 0x06000123 RID: 291 RVA: 0x000026E8 File Offset: 0x000008E8
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x41EDE0", Offset = "0x41DDE0", VA = "0x18041EDE0")]
	public static int setFilePermissions(string filePath, string _user, string _group, string _other)
	{
		return 0;
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00002700 File Offset: 0x00000900
	[Token(Token = "0x6000124")]
	[Address(RVA = "0x437110", Offset = "0x436110", VA = "0x180437110")]
	public static bool buffer2File(int levelOfCompression, string zipArchive, string arcFilename, byte[] buffer, bool append = false, [Optional] string comment, [Optional] string password, bool useBz2 = false)
	{
		return default(bool);
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00002718 File Offset: 0x00000918
	[Token(Token = "0x6000125")]
	[Address(RVA = "0x4373A0", Offset = "0x4363A0", VA = "0x1804373A0")]
	public static int delete_entry(string zipArchive, string arcFilename)
	{
		return 0;
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00002730 File Offset: 0x00000930
	[Token(Token = "0x6000126")]
	[Address(RVA = "0x437500", Offset = "0x436500", VA = "0x180437500")]
	public static int replace_entry(string zipArchive, string arcFilename, string newFilePath, int level = 9, [Optional] string comment, [Optional] string password, bool useBz2 = false)
	{
		return 0;
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00002748 File Offset: 0x00000948
	[Token(Token = "0x6000127")]
	[Address(RVA = "0x437790", Offset = "0x436790", VA = "0x180437790")]
	public static int replace_entry(string zipArchive, string arcFilename, byte[] newFileBuffer, int level = 9, [Optional] string password, bool useBz2 = false)
	{
		return 0;
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00002760 File Offset: 0x00000960
	[Token(Token = "0x6000128")]
	[Address(RVA = "0x437880", Offset = "0x436880", VA = "0x180437880")]
	public static int extract_entry(string zipArchive, string arcFilename, string outpath, [Optional] object fileBuffer, [Optional] ulong[] proc, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00002778 File Offset: 0x00000978
	[Token(Token = "0x6000129")]
	[Address(RVA = "0x437E50", Offset = "0x436E50", VA = "0x180437E50")]
	public static int extract_entries(string zipArchive, string[] fileList, string outpath, [Optional] object fileBuffer, [Optional] ulong[] proc, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00002790 File Offset: 0x00000990
	[Token(Token = "0x600012A")]
	[Address(RVA = "0x438CE0", Offset = "0x437CE0", VA = "0x180438CE0")]
	public static int decompress_File(string zipArchive, [Optional] string outPath, [Optional] int[] progress, [Optional] object fileBuffer, [Optional] ulong[] proc, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x000027A8 File Offset: 0x000009A8
	[Token(Token = "0x600012B")]
	[Address(RVA = "0x4391D0", Offset = "0x4381D0", VA = "0x1804391D0")]
	public static int compress_File(int levelOfCompression, string zipArchive, string inFilePath, bool append = false, string fileName = "", [Optional] string comment, [Optional] string password, bool useBz2 = false, int diskSize = 0, [Optional] ulong[] byteProgress)
	{
		return 0;
	}

	// Token: 0x0600012C RID: 300 RVA: 0x000027C0 File Offset: 0x000009C0
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x439630", Offset = "0x438630", VA = "0x180439630")]
	public static int compress_File_List(int levelOfCompression, string zipArchive, string[] inFilePath, [Optional] int[] progress, bool append = false, [Optional] string[] fileName, [Optional] string password, bool useBz2 = false, int diskSize = 0, [Optional] ulong[] byteProgress)
	{
		return 0;
	}

	// Token: 0x0600012D RID: 301 RVA: 0x000027D8 File Offset: 0x000009D8
	[Token(Token = "0x600012D")]
	[Address(RVA = "0x439D10", Offset = "0x438D10", VA = "0x180439D10")]
	public static int compressDir(string sourceDir, int levelOfCompression, [Optional] string zipArchive, bool includeRoot = false, [Optional] int[] progress, [Optional] string password, bool useBz2 = false, int diskSize = 0, bool append = false, [Optional] ulong[] byteProgress)
	{
		return 0;
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x43A0C0", Offset = "0x4390C0", VA = "0x18043A0C0")]
	private static void fillPointers(string outFile, string[] fileName, string[] inFilePath, ref IntPtr[] fp, ref IntPtr[] np)
	{
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x43A6B0", Offset = "0x4396B0", VA = "0x18043A6B0")]
	private static void fillLists(string fdir, bool includeRoot, ref List<string> inFilePath, ref List<string> fileName)
	{
	}

	// Token: 0x06000130 RID: 304 RVA: 0x000027F0 File Offset: 0x000009F0
	[Token(Token = "0x6000130")]
	[Address(RVA = "0x43A9F0", Offset = "0x4399F0", VA = "0x18043A9F0")]
	public static int getAllFiles(string dir)
	{
		return 0;
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00002808 File Offset: 0x00000A08
	[Token(Token = "0x6000131")]
	[Address(RVA = "0x43AA50", Offset = "0x439A50", VA = "0x18043AA50")]
	public static long getFileSize(string file)
	{
		return 0L;
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00002820 File Offset: 0x00000A20
	[Token(Token = "0x6000132")]
	[Address(RVA = "0x43AB00", Offset = "0x439B00", VA = "0x18043AB00")]
	public static ulong getDirSize(string dir)
	{
		return 0UL;
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00002838 File Offset: 0x00000A38
	[Token(Token = "0x6000133")]
	[Address(RVA = "0x43AC30", Offset = "0x439C30", VA = "0x18043AC30")]
	public static int tarExtract(string inFile, [Optional] string outPath, [Optional] int[] progress, [Optional] ulong[] byteProgress)
	{
		return 0;
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00002850 File Offset: 0x00000A50
	[Token(Token = "0x6000134")]
	[Address(RVA = "0x43AE60", Offset = "0x439E60", VA = "0x18043AE60")]
	public static int tarExtractEntry(string inFile, string entry, [Optional] string outPath, bool fullPaths = true, [Optional] ulong[] byteProgress)
	{
		return 0;
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00002868 File Offset: 0x00000A68
	[Token(Token = "0x6000135")]
	[Address(RVA = "0x43B150", Offset = "0x43A150", VA = "0x18043B150")]
	public static int tarDir(string sourceDir, [Optional] string outFile, bool includeRoot = false, [Optional] int[] progress, [Optional] ulong[] byteProgress)
	{
		return 0;
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00002880 File Offset: 0x00000A80
	[Token(Token = "0x6000136")]
	[Address(RVA = "0x43B4B0", Offset = "0x43A4B0", VA = "0x18043B4B0")]
	public static int tarList(string outFile, string[] inFilePath, [Optional] string[] fileName, [Optional] int[] progress, [Optional] ulong[] byteProgress)
	{
		return 0;
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00002898 File Offset: 0x00000A98
	[Token(Token = "0x6000137")]
	[Address(RVA = "0x43BA60", Offset = "0x43AA60", VA = "0x18043BA60")]
	public static ulong getTarInfo(string tarArchive)
	{
		return 0UL;
	}

	// Token: 0x06000138 RID: 312 RVA: 0x000028B0 File Offset: 0x00000AB0
	[Token(Token = "0x6000138")]
	[Address(RVA = "0x43C1F0", Offset = "0x43B1F0", VA = "0x18043C1F0")]
	public static DateTime entryDateTime(string zipArchive, string entry, [Optional] object fileBuffer)
	{
		return default(DateTime);
	}

	// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000139")]
	[Address(RVA = "0x43C740", Offset = "0x43B740", VA = "0x18043C740")]
	public static void free_inmemory(lzip.inMemory t)
	{
	}

	// Token: 0x0600013A RID: 314 RVA: 0x000028C8 File Offset: 0x00000AC8
	[Token(Token = "0x600013A")]
	[Address(RVA = "0x43CAA0", Offset = "0x43BAA0", VA = "0x18043CAA0")]
	public static bool inMemoryZipStart(lzip.inMemory t)
	{
		return default(bool);
	}

	// Token: 0x0600013B RID: 315 RVA: 0x000028E0 File Offset: 0x00000AE0
	[Token(Token = "0x600013B")]
	[Address(RVA = "0x43CD90", Offset = "0x43BD90", VA = "0x18043CD90")]
	public static int inMemoryZipAdd(lzip.inMemory t, int levelOfCompression, byte[] buffer, string fileName, [Optional] string comment, [Optional] string password, bool useBz2 = false)
	{
		return 0;
	}

	// Token: 0x0600013C RID: 316 RVA: 0x000028F8 File Offset: 0x00000AF8
	[Token(Token = "0x600013C")]
	[Address(RVA = "0x43D0C0", Offset = "0x43C0C0", VA = "0x18043D0C0")]
	public static IntPtr inMemoryZipClose(lzip.inMemory t)
	{
		return 0;
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00002910 File Offset: 0x00000B10
	[Token(Token = "0x600013D")]
	[Address(RVA = "0x43D2C0", Offset = "0x43C2C0", VA = "0x18043D2C0")]
	public static IntPtr compress_Buf2Mem(lzip.inMemory t, int levelOfCompression, byte[] buffer, string fileName, [Optional] string comment, [Optional] string password, bool useBz2 = false)
	{
		return 0;
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00002928 File Offset: 0x00000B28
	[Token(Token = "0x600013E")]
	[Address(RVA = "0x43D670", Offset = "0x43C670", VA = "0x18043D670")]
	public static int decompress_Mem2File(lzip.inMemory t, string outPath, [Optional] int[] progress, [Optional] ulong[] proc, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00002940 File Offset: 0x00000B40
	[Token(Token = "0x600013F")]
	[Address(RVA = "0x43D8F0", Offset = "0x43C8F0", VA = "0x18043D8F0")]
	public static int entry2BufferMem(lzip.inMemory t, string entry, ref byte[] buffer, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x06000140 RID: 320 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000140")]
	[Address(RVA = "0x43DBB0", Offset = "0x43CBB0", VA = "0x18043DBB0")]
	public static byte[] entry2BufferMem(lzip.inMemory t, string entry, [Optional] string password)
	{
		return null;
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00002958 File Offset: 0x00000B58
	[Token(Token = "0x6000141")]
	[Address(RVA = "0x43DE40", Offset = "0x43CE40", VA = "0x18043DE40")]
	public static int entry2FixedBufferMem(lzip.inMemory t, string entry, ref byte[] fixedBuffer, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00002970 File Offset: 0x00000B70
	[Token(Token = "0x6000142")]
	[Address(RVA = "0x43E0D0", Offset = "0x43D0D0", VA = "0x18043E0D0")]
	public static ulong getFileInfoMem(lzip.inMemory t)
	{
		return 0UL;
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00002988 File Offset: 0x00000B88
	[Token(Token = "0x6000143")]
	[Address(RVA = "0x43EAA0", Offset = "0x43DAA0", VA = "0x18043EAA0")]
	public static int entry2Buffer(string zipArchive, string entry, ref byte[] buffer, [Optional] object fileBuffer, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x06000144 RID: 324 RVA: 0x000029A0 File Offset: 0x00000BA0
	[Token(Token = "0x6000144")]
	[Address(RVA = "0x43F180", Offset = "0x43E180", VA = "0x18043F180")]
	public static int entry2FixedBuffer(string zipArchive, string entry, ref byte[] fixedBuffer, [Optional] object fileBuffer, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x06000145 RID: 325 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000145")]
	[Address(RVA = "0x43F7C0", Offset = "0x43E7C0", VA = "0x18043F7C0")]
	public static byte[] entry2Buffer(string zipArchive, string entry, [Optional] object fileBuffer, [Optional] string password)
	{
		return null;
	}

	// Token: 0x06000146 RID: 326 RVA: 0x000029B8 File Offset: 0x00000BB8
	[Token(Token = "0x6000146")]
	[Address(RVA = "0x43FDD0", Offset = "0x43EDD0", VA = "0x18043FDD0")]
	public static bool validateFile(string zipArchive, [Optional] object fileBuffer)
	{
		return default(bool);
	}

	// Token: 0x06000147 RID: 327 RVA: 0x000029D0 File Offset: 0x00000BD0
	[Token(Token = "0x6000147")]
	[Address(RVA = "0x440090", Offset = "0x43F090", VA = "0x180440090")]
	public static bool getZipInfo(string fileName)
	{
		return default(bool);
	}

	// Token: 0x06000148 RID: 328 RVA: 0x000029E8 File Offset: 0x00000BE8
	[Token(Token = "0x6000148")]
	[Address(RVA = "0x4403A0", Offset = "0x43F3A0", VA = "0x1804403A0")]
	public static bool getZipInfoMerged(string fileName, ref int pos, ref int size, bool getCentralDirectory = false)
	{
		return default(bool);
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00002A00 File Offset: 0x00000C00
	[Token(Token = "0x6000149")]
	[Address(RVA = "0x4406D0", Offset = "0x43F6D0", VA = "0x1804406D0")]
	public static bool getZipInfoMerged(byte[] buffer, ref int pos, ref int size, bool getCentralDirectory = false)
	{
		return default(bool);
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00002A18 File Offset: 0x00000C18
	[Token(Token = "0x600014A")]
	[Address(RVA = "0x440A10", Offset = "0x43FA10", VA = "0x180440A10")]
	public static bool getZipInfoMerged(byte[] buffer)
	{
		return default(bool);
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00002A30 File Offset: 0x00000C30
	[Token(Token = "0x600014B")]
	[Address(RVA = "0x440D40", Offset = "0x43FD40", VA = "0x180440D40")]
	private static bool findPK(BinaryReader reader)
	{
		return default(bool);
	}

	// Token: 0x0600014C RID: 332 RVA: 0x00002A48 File Offset: 0x00000C48
	[Token(Token = "0x600014C")]
	[Address(RVA = "0x440F50", Offset = "0x43FF50", VA = "0x180440F50")]
	private static int findEnd(BinaryReader reader, ref int pos, ref int size)
	{
		return 0;
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600014D")]
	[Address(RVA = "0x441350", Offset = "0x440350", VA = "0x180441350")]
	private static void getCentralDir(BinaryReader reader, int count)
	{
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600014E")]
	[Address(RVA = "0x441A60", Offset = "0x440A60", VA = "0x180441A60")]
	public static byte[] getMergedZip(string filePath, ref int position, ref int siz)
	{
		return null;
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600014F")]
	[Address(RVA = "0x441D10", Offset = "0x440D10", VA = "0x180441D10")]
	public static byte[] getMergedZip(string filePath)
	{
		return null;
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000150")]
	[Address(RVA = "0x441FC0", Offset = "0x440FC0", VA = "0x180441FC0")]
	public static byte[] getMergedZip(byte[] buffer, ref int position, ref int siz)
	{
		return null;
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000151")]
	[Address(RVA = "0x442290", Offset = "0x441290", VA = "0x180442290")]
	public static byte[] getMergedZip(byte[] buffer)
	{
		return null;
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00002A60 File Offset: 0x00000C60
	[Token(Token = "0x6000152")]
	[Address(RVA = "0x442570", Offset = "0x441570", VA = "0x180442570")]
	public static int decompressZipMerged(string file, string outPath, [Optional] int[] progress, [Optional] ulong[] proc, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x06000153 RID: 339 RVA: 0x00002A78 File Offset: 0x00000C78
	[Token(Token = "0x6000153")]
	[Address(RVA = "0x4427D0", Offset = "0x4417D0", VA = "0x1804427D0")]
	public static int decompressZipMerged(byte[] buffer, string outPath, [Optional] int[] progress, [Optional] ulong[] proc, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000154")]
	[Address(RVA = "0x442A30", Offset = "0x441A30", VA = "0x180442A30")]
	private static void writeFile(byte[] tb, string entry, string outPath, string overrideEntryName, ref int res)
	{
	}

	// Token: 0x06000155 RID: 341 RVA: 0x00002A90 File Offset: 0x00000C90
	[Token(Token = "0x6000155")]
	[Address(RVA = "0x442C40", Offset = "0x441C40", VA = "0x180442C40")]
	public static int entry2FileMerged(string file, string entry, string outPath, [Optional] string overrideEntryName, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00002AA8 File Offset: 0x00000CA8
	[Token(Token = "0x6000156")]
	[Address(RVA = "0x442EB0", Offset = "0x441EB0", VA = "0x180442EB0")]
	public static int entry2FileMerged(byte[] buffer, string entry, string outPath, [Optional] string overrideEntryName, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000157")]
	[Address(RVA = "0x443120", Offset = "0x442120", VA = "0x180443120")]
	public static byte[] entry2BufferMerged(string file, string entry, [Optional] string password)
	{
		return null;
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00002AC0 File Offset: 0x00000CC0
	[Token(Token = "0x6000158")]
	[Address(RVA = "0x443310", Offset = "0x442310", VA = "0x180443310")]
	public static int entry2BufferMerged(string file, string entry, ref byte[] refBuffer, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00002AD8 File Offset: 0x00000CD8
	[Token(Token = "0x6000159")]
	[Address(RVA = "0x443510", Offset = "0x442510", VA = "0x180443510")]
	public static int entry2FixedBufferMerged(string file, string entry, ref byte[] fixedBuffer, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600015A")]
	[Address(RVA = "0x443710", Offset = "0x442710", VA = "0x180443710")]
	public static byte[] entry2BufferMerged(byte[] buffer, string entry, [Optional] string password)
	{
		return null;
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00002AF0 File Offset: 0x00000CF0
	[Token(Token = "0x600015B")]
	[Address(RVA = "0x443900", Offset = "0x442900", VA = "0x180443900")]
	public static int entry2BufferMerged(byte[] buffer, string entry, ref byte[] refBuffer, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00002B08 File Offset: 0x00000D08
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x443AF0", Offset = "0x442AF0", VA = "0x180443AF0")]
	public static int entry2FixedBufferMerged(byte[] buffer, string entry, ref byte[] fixedBuffer, [Optional] string password)
	{
		return 0;
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00002B20 File Offset: 0x00000D20
	[Token(Token = "0x600015D")]
	[Address(RVA = "0x443CE0", Offset = "0x442CE0", VA = "0x180443CE0")]
	public static bool compressBuffer(byte[] source, ref byte[] outBuffer, int levelOfCompression)
	{
		return default(bool);
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00002B38 File Offset: 0x00000D38
	[Token(Token = "0x600015E")]
	[Address(RVA = "0x443F20", Offset = "0x442F20", VA = "0x180443F20")]
	public static int compressBufferFixed(byte[] source, ref byte[] outBuffer, int levelOfCompression, bool safe = true)
	{
		return 0;
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600015F")]
	[Address(RVA = "0x444160", Offset = "0x443160", VA = "0x180444160")]
	public static byte[] compressBuffer(byte[] source, int levelOfCompression)
	{
		return null;
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00002B50 File Offset: 0x00000D50
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x444390", Offset = "0x443390", VA = "0x180444390")]
	public static bool decompressBuffer(byte[] source, ref byte[] outBuffer)
	{
		return default(bool);
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00002B68 File Offset: 0x00000D68
	[Token(Token = "0x6000161")]
	[Address(RVA = "0x4445C0", Offset = "0x4435C0", VA = "0x1804445C0")]
	public static int decompressBufferFixed(byte[] source, ref byte[] outBuffer, bool safe = true)
	{
		return 0;
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000162")]
	[Address(RVA = "0x4447E0", Offset = "0x4437E0", VA = "0x1804447E0")]
	public static byte[] decompressBuffer(byte[] source)
	{
		return null;
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00002B80 File Offset: 0x00000D80
	[Token(Token = "0x6000163")]
	[Address(RVA = "0x444A00", Offset = "0x443A00", VA = "0x180444A00")]
	public static int gzip(byte[] source, byte[] outBuffer, int level, bool addHeader = true, bool addFooter = true, bool overrideDateTimeWithLength = false)
	{
		return 0;
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00002B98 File Offset: 0x00000D98
	[Token(Token = "0x6000164")]
	[Address(RVA = "0x444C20", Offset = "0x443C20", VA = "0x180444C20")]
	public static int gzipUncompressedSize(byte[] source)
	{
		return 0;
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00002BB0 File Offset: 0x00000DB0
	[Token(Token = "0x6000165")]
	[Address(RVA = "0x444C90", Offset = "0x443C90", VA = "0x180444C90")]
	public static int gzipCompressedSize(byte[] source, int offset = 0)
	{
		return 0;
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00002BC8 File Offset: 0x00000DC8
	[Token(Token = "0x6000166")]
	[Address(RVA = "0x444D90", Offset = "0x443D90", VA = "0x180444D90")]
	public static int findGzStart(byte[] buffer)
	{
		return 0;
	}

	// Token: 0x06000167 RID: 359 RVA: 0x00002BE0 File Offset: 0x00000DE0
	[Token(Token = "0x6000167")]
	[Address(RVA = "0x444E00", Offset = "0x443E00", VA = "0x180444E00")]
	public static int unGzip(byte[] source, byte[] outBuffer, bool hasHeader = true, bool hasFooter = true)
	{
		return 0;
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00002BF8 File Offset: 0x00000DF8
	[Token(Token = "0x6000168")]
	[Address(RVA = "0x444F90", Offset = "0x443F90", VA = "0x180444F90")]
	public static int unGzip2(object source, byte[] outBuffer, int intPtrLength = 0)
	{
		return 0;
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00002C10 File Offset: 0x00000E10
	[Token(Token = "0x6000169")]
	[Address(RVA = "0x4451B0", Offset = "0x4441B0", VA = "0x1804451B0")]
	public static int unGzip2Merged(byte[] source, int offset, int bufferLength, byte[] outBuffer)
	{
		return 0;
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00002C28 File Offset: 0x00000E28
	[Token(Token = "0x600016A")]
	[Address(RVA = "0x4452C0", Offset = "0x4442C0", VA = "0x1804452C0")]
	public static int gzipFile(string inFile, [Optional] string outFile, int level = 9, [Optional] ulong[] progress, bool addHeader = true)
	{
		return 0;
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00002C40 File Offset: 0x00000E40
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x4455E0", Offset = "0x4445E0", VA = "0x1804455E0")]
	public static int ungzipFile(string inFile, [Optional] string outFile, [Optional] ulong[] progress)
	{
		return 0;
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00002C58 File Offset: 0x00000E58
	[Token(Token = "0x600016C")]
	[Address(RVA = "0x445980", Offset = "0x444980", VA = "0x180445980")]
	public static int bz2Create(string inFile, [Optional] string outFile, int level = 9, [Optional] ulong[] byteProgress)
	{
		return 0;
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00002C70 File Offset: 0x00000E70
	[Token(Token = "0x600016D")]
	[Address(RVA = "0x445C60", Offset = "0x444C60", VA = "0x180445C60")]
	public static int bz2Decompress(string inFile, [Optional] string outFile, [Optional] ulong[] byteProgress)
	{
		return 0;
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600016E")]
	[Address(RVA = "0x446020", Offset = "0x445020", VA = "0x180446020")]
	public static IEnumerator downloadZipFileNative(string url, Action<bool> downloadDone, Action<lzip.inMemory> inmem, [Optional] Action<IntPtr> pointer, [Optional] Action<int> fileSize)
	{
		return null;
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600016F")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public lzip()
	{
	}

	// Token: 0x040000BB RID: 187
	[Token(Token = "0x40000BB")]
	private const string libname = "libzipw";

	// Token: 0x040000BC RID: 188
	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static IntPtr nativeBuffer;

	// Token: 0x040000BD RID: 189
	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static bool nativeBufferIsBeingUsed;

	// Token: 0x040000BE RID: 190
	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int nativeOffset;

	// Token: 0x040000BF RID: 191
	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static List<string> ninfo;

	// Token: 0x040000C0 RID: 192
	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static List<ulong> uinfo;

	// Token: 0x040000C1 RID: 193
	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static List<ulong> cinfo;

	// Token: 0x040000C2 RID: 194
	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static List<ulong> localOffset;

	// Token: 0x040000C3 RID: 195
	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static int zipFiles;

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public static int zipFolders;

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static ulong totalCompressedSize;

	// Token: 0x040000C6 RID: 198
	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static ulong totalUncompressedSize;

	// Token: 0x040000C7 RID: 199
	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static List<lzip.zipInfo> zinfo;

	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public class inMemory
	{
		// Token: 0x06000171 RID: 369 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x5BB4B0", Offset = "0x5BA4B0", VA = "0x1805BB4B0")]
		public int size()
		{
			return 0;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x3ED8F0", Offset = "0x3EC8F0", VA = "0x1803ED8F0")]
		public IntPtr memoryPointer()
		{
			return 0;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x5BB4E0", Offset = "0x5BA4E0", VA = "0x1805BB4E0")]
		public byte[] getZipBuffer()
		{
			return null;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x5BB600", Offset = "0x5BA600", VA = "0x1805BB600")]
		public inMemory()
		{
		}

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr pointer;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr zf;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr memStruct;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr fileStruct;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int[] info;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int lastResult;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool isClosed;
	}

	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public struct zipInfo
	{
		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short VersionMadeBy;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public short MinimumVersionToExtract;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public short BitFlag;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public short CompressionMethod;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public short FileLastModificationTime;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public short FileLastModificationDate;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int CRC;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int CompressedSize;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int UncompressedSize;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short DiskNumberWhereFileStarts;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public short InternalFileAttributes;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int ExternalFileAttributes;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int RelativeOffsetOfLocalFileHeader;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int AbsoluteOffsetOfLocalFileHeaderStore;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filename;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string extraField;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string fileComment;
	}

	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public class CustomWebRequest : DownloadHandlerScript
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x420B50", Offset = "0x41FB50", VA = "0x180420B50")]
		public CustomWebRequest()
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x420BB0", Offset = "0x41FBB0", VA = "0x180420BB0")]
		public CustomWebRequest(byte[] buffer)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "7")]
		protected override byte[] GetData()
		{
			return null;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x5BB6F0", Offset = "0x5BA6F0", VA = "0x1805BB6F0", Slot = "9")]
		protected override bool ReceiveData(byte[] bytesFromServer, int dataLength)
		{
			return default(bool);
		}
	}

	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	private sealed class <downloadZipFileNative>d__141 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <downloadZipFileNative>d__141(int <>1__state)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x5BB930", Offset = "0x5BA930", VA = "0x1805BB930", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x5BB9F0", Offset = "0x5BA9F0", VA = "0x1805BB9F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x5BC330", Offset = "0x5BB330", VA = "0x1805BC330")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000017")]
		private object Current
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x5BC390", Offset = "0x5BB390", VA = "0x1805BC390", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000018")]
		private object Current
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string url;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool> downloadDone;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<lzip.inMemory> inmem;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<IntPtr> pointer;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<int> fileSize;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <wr>5__2;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int <zipSize>5__3;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UnityWebRequest <wwwSK>5__4;
	}
}
