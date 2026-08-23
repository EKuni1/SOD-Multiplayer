using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001BA RID: 442
[Token(Token = "0x20001BA")]
public class NameGenerator : MonoBehaviour
{
	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000068")]
	public static NameGenerator Instance
	{
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x548680", Offset = "0x547680", VA = "0x180548680")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AF5")]
	[Address(RVA = "0x5486C0", Offset = "0x5476C0", VA = "0x1805486C0")]
	private void Awake()
	{
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AF6")]
	[Address(RVA = "0x548A10", Offset = "0x547A10", VA = "0x180548A10")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AF7")]
	[Address(RVA = "0x548C20", Offset = "0x547C20", VA = "0x180548C20")]
	public string GenerateName(string prefixList, float prefixChance, string mainList, float mainChance, string suffixList, float suffixChance, string useCustomSeed = "")
	{
		return null;
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AF8")]
	[Address(RVA = "0x548CC0", Offset = "0x547CC0", VA = "0x180548CC0")]
	public string GenerateName(string prefixList, float prefixChance, string mainList, float mainChance, string suffixList, float suffixChance, out string prefixOutput, out string mainOutput, out string suffixOutput, out bool needsSuffixForShortName, out string alternateTags, string useCustomSeed = "")
	{
		return null;
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AF9")]
	[Address(RVA = "0x548D60", Offset = "0x547D60", VA = "0x180548D60")]
	public string GenerateName(string prefixList, float prefixChance, string mainList, float mainChance, string suffixList, float suffixChance, bool mainIsCitizenName, int prefixMainAlliterationWeight, int mainSuffixAlliterationWeight, out string prefixOutput, out string mainOutput, out string suffixOutput, out bool needsSuffixForShortName, out string alternateTags, string useCustomSeed = "")
	{
		return null;
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AFA")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public NameGenerator()
	{
	}

	// Token: 0x04000ADC RID: 2780
	[Token(Token = "0x4000ADC")]
	[FieldOffset(Offset = "0x0")]
	private static NameGenerator _instance;
}
