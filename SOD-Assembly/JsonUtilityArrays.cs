using System;
using Il2CppDummyDll;

// Token: 0x02000034 RID: 52
[Token(Token = "0x2000034")]
public static class JsonUtilityArrays
{
	// Token: 0x060001D5 RID: 469 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001D5")]
	public static T[] FromJson<T>(string json)
	{
		return null;
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001D6")]
	public static string ToJson<T>(T[] array)
	{
		return null;
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60001D7")]
	public static string ToJson<T>(T[] array, bool prettyPrint)
	{
		return null;
	}

	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[Serializable]
	private class Wrapper<T>
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D8")]
		public Wrapper()
		{
		}

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x0")]
		public T[] Items;
	}
}
