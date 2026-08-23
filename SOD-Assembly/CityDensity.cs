using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;

// Token: 0x020001F1 RID: 497
[Token(Token = "0x20001F1")]
public class CityDensity : HighlanderSingleton<CityDensity>
{
	// Token: 0x06000BF3 RID: 3059 RVA: 0x00006FD8 File Offset: 0x000051D8
	[Token(Token = "0x6000BF3")]
	[Address(RVA = "0x583AE0", Offset = "0x582AE0", VA = "0x180583AE0")]
	public UniTask GenerateDensity()
	{
		return default(UniTask);
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BF4")]
	[Address(RVA = "0x583BA0", Offset = "0x582BA0", VA = "0x180583BA0")]
	public CityDensity()
	{
	}

	// Token: 0x020001F2 RID: 498
	[Token(Token = "0x20001F2")]
	[StructLayout(3)]
	private struct <GenerateDensity>d__0 : IEnumerator<object>
	{
		// Token: 0x06000BF5 RID: 3061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x583C10", Offset = "0x582C10", VA = "0x180583C10", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04000C65 RID: 3173
		[Token(Token = "0x4000C65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04000C66 RID: 3174
		[Token(Token = "0x4000C66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncUniTaskMethodBuilder <>t__builder;

		// Token: 0x04000C67 RID: 3175
		[Token(Token = "0x4000C67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Cysharp.Threading.Tasks.YieldAwaitable.Awaiter <>u__1;
	}
}
