using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002FD RID: 765
[Token(Token = "0x20002FD")]
public class DataCompressionController : MonoBehaviour
{
	// Token: 0x1700008D RID: 141
	// (get) Token: 0x060010D9 RID: 4313 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700008D")]
	public static DataCompressionController Instance
	{
		[Token(Token = "0x60010D9")]
		[Address(RVA = "0x6B30D0", Offset = "0x6B20D0", VA = "0x1806B30D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010DA")]
	[Address(RVA = "0x6B3110", Offset = "0x6B2110", VA = "0x1806B3110")]
	private void Awake()
	{
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010DB")]
	[Address(RVA = "0x6B3460", Offset = "0x6B2460", VA = "0x1806B3460")]
	private void OnDestroy()
	{
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010DC")]
	public Task<bool> CompressAndSaveDataAsync<T>(T input, string filePath, int compressionQuality = 9) where T : class
	{
		return null;
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010DD")]
	public Task<bool> LoadCompressedDataAsync<T>(string filePath, Action<T> onComplete) where T : class
	{
		return null;
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010DE")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public DataCompressionController()
	{
	}

	// Token: 0x04001482 RID: 5250
	[Token(Token = "0x4001482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static DataCompressionController _instance;

	// Token: 0x020002FE RID: 766
	[Token(Token = "0x20002FE")]
	private sealed class <>c__DisplayClass5_0<T> where T : class
	{
		// Token: 0x060010DF RID: 4319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DF")]
		public <>c__DisplayClass5_0()
		{
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E0")]
		internal void <CompressAndSaveDataAsync>b__0()
		{
		}

		// Token: 0x04001483 RID: 5251
		[Token(Token = "0x4001483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string jsonString;

		// Token: 0x04001484 RID: 5252
		[Token(Token = "0x4001484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int compressionQuality;

		// Token: 0x04001485 RID: 5253
		[Token(Token = "0x4001485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string filePath;

		// Token: 0x04001486 RID: 5254
		[Token(Token = "0x4001486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool success;
	}

	// Token: 0x020002FF RID: 767
	[Token(Token = "0x20002FF")]
	[StructLayout(3)]
	private struct <CompressAndSaveDataAsync>d__5<T> : IEnumerator<object> where T : class
	{
		// Token: 0x060010E1 RID: 4321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E1")]
		private void MoveNext()
		{
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E2")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04001487 RID: 5255
		[Token(Token = "0x4001487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04001488 RID: 5256
		[Token(Token = "0x4001488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		// Token: 0x04001489 RID: 5257
		[Token(Token = "0x4001489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int compressionQuality;

		// Token: 0x0400148A RID: 5258
		[Token(Token = "0x400148A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string filePath;

		// Token: 0x0400148B RID: 5259
		[Token(Token = "0x400148B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T input;

		// Token: 0x0400148C RID: 5260
		[Token(Token = "0x400148C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private DataCompressionController.<>c__DisplayClass5_0<T> <>8__1;

		// Token: 0x0400148D RID: 5261
		[Token(Token = "0x400148D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TaskAwaiter <>u__1;
	}

	// Token: 0x02000300 RID: 768
	[Token(Token = "0x2000300")]
	private sealed class <>c__DisplayClass6_0<T> where T : class
	{
		// Token: 0x060010E3 RID: 4323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E3")]
		public <>c__DisplayClass6_0()
		{
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E4")]
		internal void <LoadCompressedDataAsync>b__0()
		{
		}

		// Token: 0x0400148E RID: 5262
		[Token(Token = "0x400148E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte[] loadedBytes;

		// Token: 0x0400148F RID: 5263
		[Token(Token = "0x400148F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string filePath;

		// Token: 0x04001490 RID: 5264
		[Token(Token = "0x4001490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Type typeParameterType;
	}

	// Token: 0x02000301 RID: 769
	[Token(Token = "0x2000301")]
	private sealed class <>c__DisplayClass6_1<T> where T : class
	{
		// Token: 0x060010E5 RID: 4325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E5")]
		public <>c__DisplayClass6_1()
		{
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E6")]
		internal void <LoadCompressedDataAsync>b__1()
		{
		}

		// Token: 0x04001491 RID: 5265
		[Token(Token = "0x4001491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string jsonString;

		// Token: 0x04001492 RID: 5266
		[Token(Token = "0x4001492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DataCompressionController.<>c__DisplayClass6_0<T> CS$<>8__locals1;
	}

	// Token: 0x02000302 RID: 770
	[Token(Token = "0x2000302")]
	private sealed class <>c__DisplayClass6_2<T> where T : class
	{
		// Token: 0x060010E7 RID: 4327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E7")]
		public <>c__DisplayClass6_2()
		{
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E8")]
		internal void <LoadCompressedDataAsync>b__2()
		{
		}

		// Token: 0x04001493 RID: 5267
		[Token(Token = "0x4001493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string tempFile;

		// Token: 0x04001494 RID: 5268
		[Token(Token = "0x4001494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong[] progress;

		// Token: 0x04001495 RID: 5269
		[Token(Token = "0x4001495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string jsonString;
	}

	// Token: 0x02000303 RID: 771
	[Token(Token = "0x2000303")]
	[StructLayout(3)]
	private struct <LoadCompressedDataAsync>d__6<T> : IEnumerator<object> where T : class
	{
		// Token: 0x060010E9 RID: 4329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E9")]
		private void MoveNext()
		{
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010EA")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04001496 RID: 5270
		[Token(Token = "0x4001496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04001497 RID: 5271
		[Token(Token = "0x4001497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		// Token: 0x04001498 RID: 5272
		[Token(Token = "0x4001498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string filePath;

		// Token: 0x04001499 RID: 5273
		[Token(Token = "0x4001499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private DataCompressionController.<>c__DisplayClass6_0<T> <>8__1;

		// Token: 0x0400149A RID: 5274
		[Token(Token = "0x400149A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private DataCompressionController.<>c__DisplayClass6_1<T> <>8__2;

		// Token: 0x0400149B RID: 5275
		[Token(Token = "0x400149B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private DataCompressionController.<>c__DisplayClass6_2<T> <>8__3;

		// Token: 0x0400149C RID: 5276
		[Token(Token = "0x400149C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> onComplete;

		// Token: 0x0400149D RID: 5277
		[Token(Token = "0x400149D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T <output>5__2;

		// Token: 0x0400149E RID: 5278
		[Token(Token = "0x400149E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool <success>5__3;

		// Token: 0x0400149F RID: 5279
		[Token(Token = "0x400149F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TaskAwaiter <>u__1;
	}
}
