using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000378 RID: 888
[Token(Token = "0x2000378")]
public class LanguageConfigLoader : MonoBehaviour
{
	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x060013EE RID: 5102 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000A9")]
	public static LanguageConfigLoader Instance
	{
		[Token(Token = "0x60013EE")]
		[Address(RVA = "0x7A2E30", Offset = "0x7A1E30", VA = "0x1807A2E30")]
		get
		{
			return null;
		}
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013EF")]
	[Address(RVA = "0x7A2E70", Offset = "0x7A1E70", VA = "0x1807A2E70")]
	private void Awake()
	{
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F0")]
	[Address(RVA = "0x7A3260", Offset = "0x7A2260", VA = "0x1807A3260")]
	public void LoadLanguageConfig()
	{
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013F1")]
	[Address(RVA = "0x7A4150", Offset = "0x7A3150", VA = "0x1807A4150")]
	public LanguageConfigLoader()
	{
	}

	// Token: 0x0400183F RID: 6207
	[Token(Token = "0x400183F")]
	[FieldOffset(Offset = "0x18")]
	public bool loadedLanguageConfig;

	// Token: 0x04001840 RID: 6208
	[Token(Token = "0x4001840")]
	[FieldOffset(Offset = "0x20")]
	public List<LanguageConfigLoader.LocInput> fileInputConfig;

	// Token: 0x04001841 RID: 6209
	[Token(Token = "0x4001841")]
	[FieldOffset(Offset = "0x0")]
	private static LanguageConfigLoader _instance;

	// Token: 0x02000379 RID: 889
	[Token(Token = "0x2000379")]
	[Serializable]
	public class LocInput
	{
		// Token: 0x060013F2 RID: 5106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F2")]
		[Address(RVA = "0x7A4250", Offset = "0x7A3250", VA = "0x1807A4250")]
		public LocInput()
		{
		}

		// Token: 0x04001842 RID: 6210
		[Token(Token = "0x4001842")]
		[FieldOffset(Offset = "0x10")]
		public string languageCode;

		// Token: 0x04001843 RID: 6211
		[Token(Token = "0x4001843")]
		[FieldOffset(Offset = "0x18")]
		public string displayName;

		// Token: 0x04001844 RID: 6212
		[Token(Token = "0x4001844")]
		[FieldOffset(Offset = "0x20")]
		public int documentColumn;

		// Token: 0x04001845 RID: 6213
		[Token(Token = "0x4001845")]
		[FieldOffset(Offset = "0x24")]
		public SystemLanguage systemLanguage;

		// Token: 0x04001846 RID: 6214
		[Token(Token = "0x4001846")]
		[FieldOffset(Offset = "0x28")]
		public bool swapCitizenTitleOrder;

		// Token: 0x04001847 RID: 6215
		[Token(Token = "0x4001847")]
		[FieldOffset(Offset = "0x29")]
		public bool staticKillerMoniker;

		// Token: 0x04001848 RID: 6216
		[Token(Token = "0x4001848")]
		[FieldOffset(Offset = "0x30")]
		public string startText;

		// Token: 0x04001849 RID: 6217
		[Token(Token = "0x4001849")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public string path;

		// Token: 0x0400184A RID: 6218
		[Token(Token = "0x400184A")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Dictionary<string, FileInfo> modOverrideFiles;

		// Token: 0x0400184B RID: 6219
		[Token(Token = "0x400184B")]
		[FieldOffset(Offset = "0x48")]
		public List<string> debugOverrideFiles;

		// Token: 0x0400184C RID: 6220
		[Token(Token = "0x400184C")]
		[FieldOffset(Offset = "0x50")]
		public bool useShortenedDays;

		// Token: 0x0400184D RID: 6221
		[Token(Token = "0x400184D")]
		[FieldOffset(Offset = "0x54")]
		public int shortenedDaysLength;
	}

	// Token: 0x0200037A RID: 890
	[Token(Token = "0x200037A")]
	private sealed class <>c__DisplayClass7_0
	{
		// Token: 0x060013F3 RID: 5107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass7_0()
		{
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x000098D0 File Offset: 0x00007AD0
		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x7A43E0", Offset = "0x7A33E0", VA = "0x1807A43E0")]
		internal bool <LoadLanguageConfig>b__0(LanguageConfigLoader.LocInput item)
		{
			return default(bool);
		}

		// Token: 0x0400184E RID: 6222
		[Token(Token = "0x400184E")]
		[FieldOffset(Offset = "0x10")]
		public LanguageConfigLoader.LocInput locSettings;
	}
}
