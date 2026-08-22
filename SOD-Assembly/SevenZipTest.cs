using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x0200001B RID: 27
[Token(Token = "0x200001B")]
public class SevenZipTest : MonoBehaviour
{
	// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x42FB40", Offset = "0x42EB40", VA = "0x18042FB40")]
	private void plog(string t = "")
	{
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x42FBE0", Offset = "0x42EBE0", VA = "0x18042FBE0")]
	private void Start()
	{
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x419610", Offset = "0x418610", VA = "0x180419610")]
	private void Update()
	{
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x42FF20", Offset = "0x42EF20", VA = "0x18042FF20")]
	private void OnGUI()
	{
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x430520", Offset = "0x42F520", VA = "0x180430520")]
	private void DoDecompression()
	{
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x431AD0", Offset = "0x430AD0", VA = "0x180431AD0")]
	private void Decompress()
	{
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x431BD0", Offset = "0x430BD0", VA = "0x180431BD0")]
	private IEnumerator Download7ZFile()
	{
		return null;
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x431C70", Offset = "0x430C70", VA = "0x180431C70")]
	private IEnumerator buff2buffTest()
	{
		return null;
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x431D10", Offset = "0x430D10", VA = "0x180431D10")]
	public SevenZipTest()
	{
	}

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x18")]
	private string myFile;

	// Token: 0x040000A9 RID: 169
	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x20")]
	private string uri;

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x28")]
	private string ppath;

	// Token: 0x040000AB RID: 171
	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x30")]
	private string log;

	// Token: 0x040000AC RID: 172
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x38")]
	private bool downloadDone;

	// Token: 0x040000AD RID: 173
	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x40")]
	private ulong tsize;

	// Token: 0x040000AE RID: 174
	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x48")]
	private byte[] buff;

	// Token: 0x040000AF RID: 175
	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x50")]
	private byte[] fixedInBuffer;

	// Token: 0x040000B0 RID: 176
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x58")]
	private byte[] fixedOutBuffer;

	// Token: 0x040000B1 RID: 177
	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x60")]
	private Thread th;

	// Token: 0x040000B2 RID: 178
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x68")]
	private int[] fileProgress;

	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	private sealed class <Download7ZFile>d__17 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Download7ZFile>d__17(int <>1__state)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x432010", Offset = "0x431010", VA = "0x180432010", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x4320D0", Offset = "0x4310D0", VA = "0x1804320D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x432630", Offset = "0x431630", VA = "0x180432630")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000013")]
		private object Current
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x432690", Offset = "0x431690", VA = "0x180432690", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000014")]
		private object Current
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x20")]
		public SevenZipTest <>4__this;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;
	}

	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	private sealed class <buff2buffTest>d__18 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <buff2buffTest>d__18(int <>1__state)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x4326E0", Offset = "0x4316E0", VA = "0x1804326E0", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x4327A0", Offset = "0x4317A0", VA = "0x1804327A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x4331F0", Offset = "0x4321F0", VA = "0x1804331F0")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000015")]
		private object Current
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x433250", Offset = "0x432250", VA = "0x180433250", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000016")]
		private object Current
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x20")]
		public SevenZipTest <>4__this;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x28")]
		private UnityWebRequest <w>5__2;
	}
}
