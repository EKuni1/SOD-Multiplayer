using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008CA RID: 2250
[Token(Token = "0x20008CA")]
public class Strings : MonoBehaviour
{
	// Token: 0x17000159 RID: 345
	// (get) Token: 0x06002A5E RID: 10846 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000159")]
	public static Strings Instance
	{
		[Token(Token = "0x6002A5E")]
		[Address(RVA = "0xC6FDD0", Offset = "0xC6EDD0", VA = "0x180C6FDD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002A5F RID: 10847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A5F")]
	[Address(RVA = "0xC6FE30", Offset = "0xC6EE30", VA = "0x180C6FE30")]
	private void Awake()
	{
	}

	// Token: 0x06002A60 RID: 10848 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A60")]
	[Address(RVA = "0xC70370", Offset = "0xC6F370", VA = "0x180C70370")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002A61 RID: 10849 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A61")]
	[Address(RVA = "0xC705B0", Offset = "0xC6F5B0", VA = "0x180C705B0")]
	public void LoadTextFiles()
	{
	}

	// Token: 0x06002A62 RID: 10850 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A62")]
	[Address(RVA = "0xC727D0", Offset = "0xC717D0", VA = "0x180C727D0")]
	public static void LoadLanguageFileToGame(string fileName, string path, bool loadAsENGBackup = false, bool overwriteEntries = false)
	{
	}

	// Token: 0x06002A63 RID: 10851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A63")]
	[Address(RVA = "0xC72FD0", Offset = "0xC71FD0", VA = "0x180C72FD0")]
	public static void ParseLine(string input, out string key, out string notes, out string display, out string alt, out int frequency, out bool suffix, out string misc, bool useFieldQuotations = true)
	{
	}

	// Token: 0x06002A64 RID: 10852 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A64")]
	[Address(RVA = "0xC73830", Offset = "0xC72830", VA = "0x180C73830")]
	private static void LoadIntoDictionary(string fileName, int lineNo, string key, string display, string alternate, int frequency, bool suffix, bool overwrite = false)
	{
	}

	// Token: 0x06002A65 RID: 10853 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A65")]
	[Address(RVA = "0xC73FC0", Offset = "0xC72FC0", VA = "0x180C73FC0")]
	private static void LoadIntoDictionaryENG(string fileName, int lineNo, string key, string display, string alternate, int frequency, bool suffix, bool overwrite = false)
	{
	}

	// Token: 0x06002A66 RID: 10854 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A66")]
	[Address(RVA = "0xC74750", Offset = "0xC73750", VA = "0x180C74750")]
	public static string Get(string dictionary, string key, Strings.Casing casing = Strings.Casing.asIs, bool getAlternate = false, bool forceNoWrite = false, bool useGenderReference = false, [Optional] Human genderReference)
	{
		return null;
	}

	// Token: 0x06002A67 RID: 10855 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A67")]
	[Address(RVA = "0xC75180", Offset = "0xC74180", VA = "0x180C75180")]
	public static string GetENG(string dictionary, string key, bool getAlternate = false)
	{
		return null;
	}

	// Token: 0x06002A68 RID: 10856 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A68")]
	[Address(RVA = "0xC754E0", Offset = "0xC744E0", VA = "0x180C754E0")]
	public static string GetLineFromFile(string dictionary, int lineNumber)
	{
		return null;
	}

	// Token: 0x06002A69 RID: 10857 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A69")]
	[Address(RVA = "0xC75720", Offset = "0xC74720", VA = "0x180C75720")]
	public static string ApplyCasing(string input, Strings.Casing casing = Strings.Casing.asIs)
	{
		return null;
	}

	// Token: 0x06002A6A RID: 10858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A6A")]
	[Address(RVA = "0xC75990", Offset = "0xC74990", VA = "0x180C75990")]
	public static void WriteToDictionary(string dictionaryName, string key, string notes, string display, string alternate = "", int frequency = 0, bool requiresSuffix = false, string misc = "")
	{
	}

	// Token: 0x06002A6B RID: 10859 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A6B")]
	[Address(RVA = "0xC76390", Offset = "0xC75390", VA = "0x180C76390")]
	public static string GetRandom(string dictionary, out bool needsSuffixForShortName, out string alternate, string useCustomSeed = "")
	{
		return null;
	}

	// Token: 0x06002A6C RID: 10860 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A6C")]
	[Address(RVA = "0xC764A0", Offset = "0xC754A0", VA = "0x180C764A0")]
	public static string GetRandom(string dictionary, string alliterationStr, int alliterationWeight, out bool needsSuffixForShortName, out string alternate, string useCustomSeed = "")
	{
		return null;
	}

	// Token: 0x06002A6D RID: 10861 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A6D")]
	[Address(RVA = "0xC76CC0", Offset = "0xC75CC0", VA = "0x180C76CC0")]
	public static string[] CleanSplit(string input, char del, bool trimElements, bool removeEmpty = true)
	{
		return null;
	}

	// Token: 0x06002A6E RID: 10862 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A6E")]
	[Address(RVA = "0xC76ED0", Offset = "0xC75ED0", VA = "0x180C76ED0")]
	public static string[] CleanSplit(string input, string[] del, bool trimElements)
	{
		return null;
	}

	// Token: 0x06002A6F RID: 10863 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A6F")]
	[Address(RVA = "0xC77020", Offset = "0xC76020", VA = "0x180C77020")]
	public static string ConvertLineBreaksToSaveSafe(string input)
	{
		return null;
	}

	// Token: 0x06002A70 RID: 10864 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A70")]
	[Address(RVA = "0xC77110", Offset = "0xC76110", VA = "0x180C77110")]
	public static string ConvertLineBreaksToDisplay(string input)
	{
		return null;
	}

	// Token: 0x06002A71 RID: 10865 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A71")]
	[Address(RVA = "0xC77200", Offset = "0xC76200", VA = "0x180C77200")]
	public static string GetTextForComponent(string msgID, object obj, [Optional] Human from, [Optional] Human to, string lineBreaks = "\n", bool skipFirstBlock = false, [Optional] object additionalObject, Strings.LinkSetting linkSetting = Strings.LinkSetting.automatic, [Optional] List<Evidence.DataKey> dataKeys)
	{
		return null;
	}

	// Token: 0x06002A72 RID: 10866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A72")]
	[Address(RVA = "0xC77730", Offset = "0xC76730", VA = "0x180C77730")]
	public void OutputTextForLoc()
	{
	}

	// Token: 0x06002A73 RID: 10867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A73")]
	[Address(RVA = "0xC7AFA0", Offset = "0xC79FA0", VA = "0x180C7AFA0")]
	public void ImportNonEnglish()
	{
	}

	// Token: 0x06002A74 RID: 10868 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A74")]
	[Address(RVA = "0xC7F280", Offset = "0xC7E280", VA = "0x180C7F280")]
	public static Human GetVmailSender(StateSaveData.MessageThreadSave msgThread, int msgIndex, out string nameString)
	{
		return null;
	}

	// Token: 0x06002A75 RID: 10869 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A75")]
	[Address(RVA = "0xC7F9E0", Offset = "0xC7E9E0", VA = "0x180C7F9E0")]
	public static Human GetVmailReciever(StateSaveData.MessageThreadSave msgThread, int msgIndex, out string nameString)
	{
		return null;
	}

	// Token: 0x06002A76 RID: 10870 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A76")]
	[Address(RVA = "0xC80140", Offset = "0xC7F140", VA = "0x180C80140")]
	public static string ComposeText(string input, object baseObject, Strings.LinkSetting linkSetting = Strings.LinkSetting.automatic, [Optional] List<Evidence.DataKey> evidenceKeys, [Optional] object additionalObject, bool forceKnownCitizenGender = false)
	{
		return null;
	}

	// Token: 0x06002A77 RID: 10871 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A77")]
	[Address(RVA = "0xC81130", Offset = "0xC80130", VA = "0x180C81130")]
	public static string ScopeParser(string input, DDSScope baseScope, object baseObject, Strings.LinkSetting linkSetting = Strings.LinkSetting.automatic, [Optional] List<Evidence.DataKey> evidenceKeys, [Optional] object additionalObject, bool knowCitizenGender = false)
	{
		return null;
	}

	// Token: 0x06002A78 RID: 10872 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A78")]
	[Address(RVA = "0xC81AB0", Offset = "0xC80AB0", VA = "0x180C81AB0")]
	public static DDSScope GetContainedScope(DDSScope baseScope, DDSScope currentScope, string newScope, object inputObject, out object outputObject, object additionalObject)
	{
		return null;
	}

	// Token: 0x06002A79 RID: 10873 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A79")]
	[Address(RVA = "0xC82250", Offset = "0xC81250", VA = "0x180C82250")]
	public static object GetScopeObject(DDSScope baseScope, object inputObject, string withinScope, string newType, [Optional] List<Evidence.DataKey> evidenceKeys, [Optional] object additionalObject)
	{
		return null;
	}

	// Token: 0x06002A7A RID: 10874 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A7A")]
	[Address(RVA = "0xC8A370", Offset = "0xC89370", VA = "0x180C8A370")]
	public static string GetContainedValue(object baseObject, string withinScope, string newValue, object inputObject, Evidence baseEvidence, Strings.LinkSetting linkSetting = Strings.LinkSetting.automatic, [Optional] List<Evidence.DataKey> evidenceKeys, [Optional] object additionalObject, bool knowCitizenGender = false)
	{
		return null;
	}

	// Token: 0x06002A7B RID: 10875 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A7B")]
	[Address(RVA = "0xC96B40", Offset = "0xC95B40", VA = "0x180C96B40")]
	public static MurderController.Murder GetPreviousMurder(float specificTime)
	{
		return null;
	}

	// Token: 0x06002A7C RID: 10876 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A7C")]
	[Address(RVA = "0xC975F0", Offset = "0xC965F0", VA = "0x180C975F0")]
	public static MurderController.Murder GetNextMurder(float specificTime)
	{
		return null;
	}

	// Token: 0x06002A7D RID: 10877 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A7D")]
	[Address(RVA = "0xC979B0", Offset = "0xC969B0", VA = "0x180C979B0")]
	public static Evidence GetEvidenceFromBaseScope(object baseObject)
	{
		return null;
	}

	// Token: 0x06002A7E RID: 10878 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A7E")]
	[Address(RVA = "0xC98020", Offset = "0xC97020", VA = "0x180C98020")]
	public static Strings.LinkData AddOrGetLink(Evidence newEvidence, [Optional] List<Evidence.DataKey> overrideKeys)
	{
		return null;
	}

	// Token: 0x06002A7F RID: 10879 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A7F")]
	[Address(RVA = "0xC98390", Offset = "0xC97390", VA = "0x180C98390")]
	public static Strings.LinkData AddOrGetLink(Telephone newTelephone)
	{
		return null;
	}

	// Token: 0x06002A80 RID: 10880 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A80")]
	[Address(RVA = "0xC984C0", Offset = "0xC974C0", VA = "0x180C984C0")]
	public static Strings.LinkData AddOrGetLink(List<int> newInputCode)
	{
		return null;
	}

	// Token: 0x06002A81 RID: 10881 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A81")]
	[Address(RVA = "0xC987B0", Offset = "0xC977B0", VA = "0x180C987B0")]
	public static string GetMainTextFromInteractable(Interactable interactable, Strings.LinkSetting linkSetting = Strings.LinkSetting.automatic)
	{
		return null;
	}

	// Token: 0x06002A82 RID: 10882 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A82")]
	[Address(RVA = "0xC98F80", Offset = "0xC97F80", VA = "0x180C98F80")]
	public static string FilterInputtedText(string input, bool useCensor = true, int maxCharacters = 100)
	{
		return null;
	}

	// Token: 0x06002A83 RID: 10883 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002A83")]
	[Address(RVA = "0xC99050", Offset = "0xC98050", VA = "0x180C99050")]
	public static string RemoveCharacters(string input, bool removeSpecialCharacters, bool removeNumbers, bool removeDots, bool removeSpaces)
	{
		return null;
	}

	// Token: 0x06002A84 RID: 10884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A84")]
	[Address(RVA = "0xC99460", Offset = "0xC98460", VA = "0x180C99460")]
	public void FindBlockInMessages()
	{
	}

	// Token: 0x06002A85 RID: 10885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A85")]
	[Address(RVA = "0xC99B00", Offset = "0xC98B00", VA = "0x180C99B00")]
	public void OutputAllCharacters()
	{
	}

	// Token: 0x06002A86 RID: 10886 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
	[Token(Token = "0x6002A86")]
	[Address(RVA = "0xC9B710", Offset = "0xC9A710", VA = "0x180C9B710")]
	private bool CheckForNotLatin(char c)
	{
		return default(bool);
	}

	// Token: 0x06002A87 RID: 10887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A87")]
	[Address(RVA = "0xC9B730", Offset = "0xC9A730", VA = "0x180C9B730")]
	public void ImportCorrections()
	{
	}

	// Token: 0x06002A88 RID: 10888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A88")]
	[Address(RVA = "0xCA04F0", Offset = "0xC9F4F0", VA = "0x180CA04F0")]
	public void OutputSerializedLanguageConfig()
	{
	}

	// Token: 0x06002A89 RID: 10889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A89")]
	[Address(RVA = "0xCA0990", Offset = "0xC9F990", VA = "0x180CA0990")]
	public Strings()
	{
	}

	// Token: 0x06002A8B RID: 10891 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
	[Token(Token = "0x6002A8B")]
	[Address(RVA = "0xCA1390", Offset = "0xCA0390", VA = "0x180CA1390")]
	private bool <FindBlockInMessages>b__85_0(DDSSaveClasses.DDSBlockCondition item)
	{
		return default(bool);
	}

	// Token: 0x04004AA4 RID: 19108
	[Token(Token = "0x4004AA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject languageLoaderPrefab;

	// Token: 0x04004AA5 RID: 19109
	[Token(Token = "0x4004AA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool textFilesLoaded;

	// Token: 0x04004AA6 RID: 19110
	[Token(Token = "0x4004AA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool backupENGLoaded;

	// Token: 0x04004AA7 RID: 19111
	[Token(Token = "0x4004AA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static LanguageConfigLoader.LocInput loadedLanguage;

	// Token: 0x04004AA8 RID: 19112
	[Token(Token = "0x4004AA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Dictionary<string, Dictionary<string, Strings.DisplayString>> stringTable;

	// Token: 0x04004AA9 RID: 19113
	[Token(Token = "0x4004AA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static Dictionary<string, string> dictionaryPathnames;

	// Token: 0x04004AAA RID: 19114
	[Token(Token = "0x4004AAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static Dictionary<string, Dictionary<string, Strings.DisplayString>> stringTableENG;

	// Token: 0x04004AAB RID: 19115
	[Token(Token = "0x4004AAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static FileInfo templateFile;

	// Token: 0x04004AAC RID: 19116
	[Token(Token = "0x4004AAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static Dictionary<string, List<Strings.RandomDisplayString>> randomEntryLists;

	// Token: 0x04004AAD RID: 19117
	[Token(Token = "0x4004AAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static Dictionary<string, List<Strings.RandomDisplayString>> randomEntryListsENG;

	// Token: 0x04004AAE RID: 19118
	[Token(Token = "0x4004AAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<string> localisationIgnoreFileList;

	// Token: 0x04004AAF RID: 19119
	[Token(Token = "0x4004AAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<string> localisationIgnoreDirectoryList;

	// Token: 0x04004AB0 RID: 19120
	[Token(Token = "0x4004AB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool useIgnoreFlagInNotes;

	// Token: 0x04004AB1 RID: 19121
	[Token(Token = "0x4004AB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string ignoreFlag;

	// Token: 0x04004AB2 RID: 19122
	[Token(Token = "0x4004AB2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int extraLineBreaks;

	// Token: 0x04004AB3 RID: 19123
	[Token(Token = "0x4004AB3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool condenseIdenticalEnglishContentIntoOneKey;

	// Token: 0x04004AB4 RID: 19124
	[Token(Token = "0x4004AB4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool onlyOuputChangesSince;

	// Token: 0x04004AB5 RID: 19125
	[Token(Token = "0x4004AB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string outputSinceDate;

	// Token: 0x04004AB6 RID: 19126
	[Token(Token = "0x4004AB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool outputSinceContentConfirmation;

	// Token: 0x04004AB7 RID: 19127
	[Token(Token = "0x4004AB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<string> oldFileComparisonPaths;

	// Token: 0x04004AB8 RID: 19128
	[Token(Token = "0x4004AB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool missingKeyCheck;

	// Token: 0x04004AB9 RID: 19129
	[Token(Token = "0x4004AB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string localisationInputFile;

	// Token: 0x04004ABA RID: 19130
	[Token(Token = "0x4004ABA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string inputDate;

	// Token: 0x04004ABB RID: 19131
	[Token(Token = "0x4004ABB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string templateInputFile;

	// Token: 0x04004ABC RID: 19132
	[Token(Token = "0x4004ABC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool inputFeaturesLastColumnLineNumbers;

	// Token: 0x04004ABD RID: 19133
	[Token(Token = "0x4004ABD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string missingString;

	// Token: 0x04004ABE RID: 19134
	[Token(Token = "0x4004ABE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public string customUsedCharacters;

	// Token: 0x04004ABF RID: 19135
	[Token(Token = "0x4004ABF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool includeDefaultAsciiCharacters;

	// Token: 0x04004AC0 RID: 19136
	[Token(Token = "0x4004AC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string localisationCorrectionsInputFile;

	// Token: 0x04004AC1 RID: 19137
	[Token(Token = "0x4004AC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public string correctionsInputDate;

	// Token: 0x04004AC2 RID: 19138
	[Token(Token = "0x4004AC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public string correctionsLanguage;

	// Token: 0x04004AC3 RID: 19139
	[Token(Token = "0x4004AC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public bool checkCorrectionsDateBeforeOverwrite;

	// Token: 0x04004AC4 RID: 19140
	[Token(Token = "0x4004AC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
	public bool useGenderVariationFormatting;

	// Token: 0x04004AC5 RID: 19141
	[Token(Token = "0x4004AC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public int columnContent;

	// Token: 0x04004AC6 RID: 19142
	[Token(Token = "0x4004AC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool createMissingFiles;

	// Token: 0x04004AC7 RID: 19143
	[Token(Token = "0x4004AC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
	public bool createMissingKey;

	// Token: 0x04004AC8 RID: 19144
	[Token(Token = "0x4004AC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public string findBlock;

	// Token: 0x04004AC9 RID: 19145
	[Token(Token = "0x4004AC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Dictionary<object, Strings.LinkData> linkDictionary;

	// Token: 0x04004ACA RID: 19146
	[Token(Token = "0x4004ACA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Dictionary<Evidence, List<Strings.LinkData>> evidenceLinkDictionary;

	// Token: 0x04004ACB RID: 19147
	[Token(Token = "0x4004ACB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Dictionary<int, Strings.LinkData> linkIDReference;

	// Token: 0x04004ACC RID: 19148
	[Token(Token = "0x4004ACC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static Strings _instance;

	// Token: 0x020008CB RID: 2251
	[Token(Token = "0x20008CB")]
	public class DisplayString
	{
		// Token: 0x06002A8C RID: 10892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DisplayString()
		{
		}

		// Token: 0x04004ACD RID: 19149
		[Token(Token = "0x4004ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string displayStr;

		// Token: 0x04004ACE RID: 19150
		[Token(Token = "0x4004ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string alternateStr;
	}

	// Token: 0x020008CC RID: 2252
	[Token(Token = "0x20008CC")]
	public class RandomDisplayString
	{
		// Token: 0x06002A8D RID: 10893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public RandomDisplayString()
		{
		}

		// Token: 0x04004ACF RID: 19151
		[Token(Token = "0x4004ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string displayStr;

		// Token: 0x04004AD0 RID: 19152
		[Token(Token = "0x4004AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string alternateStr;

		// Token: 0x04004AD1 RID: 19153
		[Token(Token = "0x4004AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool needsSuffixForShortName;
	}

	// Token: 0x020008CD RID: 2253
	[Token(Token = "0x20008CD")]
	public enum Casing
	{
		// Token: 0x04004AD3 RID: 19155
		[Token(Token = "0x4004AD3")]
		asIs,
		// Token: 0x04004AD4 RID: 19156
		[Token(Token = "0x4004AD4")]
		firstLetterCaptial,
		// Token: 0x04004AD5 RID: 19157
		[Token(Token = "0x4004AD5")]
		pascalCase,
		// Token: 0x04004AD6 RID: 19158
		[Token(Token = "0x4004AD6")]
		upperCase,
		// Token: 0x04004AD7 RID: 19159
		[Token(Token = "0x4004AD7")]
		lowerCase
	}

	// Token: 0x020008CE RID: 2254
	[Token(Token = "0x20008CE")]
	public enum LinkSetting
	{
		// Token: 0x04004AD9 RID: 19161
		[Token(Token = "0x4004AD9")]
		automatic,
		// Token: 0x04004ADA RID: 19162
		[Token(Token = "0x4004ADA")]
		forceLinks,
		// Token: 0x04004ADB RID: 19163
		[Token(Token = "0x4004ADB")]
		forceNoLinks
	}

	// Token: 0x020008CF RID: 2255
	[Token(Token = "0x20008CF")]
	public class LinkData
	{
		// Token: 0x06002A8E RID: 10894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8E")]
		[Address(RVA = "0xCC0380", Offset = "0xCBF380", VA = "0x180CC0380")]
		public LinkData(Evidence newEvidence, List<Evidence.DataKey> overrideKeys)
		{
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A8F")]
		[Address(RVA = "0xCC06F0", Offset = "0xCBF6F0", VA = "0x180CC06F0")]
		public LinkData([Optional] Telephone newTelephone)
		{
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A90")]
		[Address(RVA = "0xCC09A0", Offset = "0xCBF9A0", VA = "0x180CC09A0")]
		public LinkData([Optional] List<int> newInputCode)
		{
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A91")]
		[Address(RVA = "0xCC0BE0", Offset = "0xCBFBE0", VA = "0x180CC0BE0")]
		public LinkData(string newHelpPage)
		{
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A92")]
		[Address(RVA = "0xCC0D80", Offset = "0xCBFD80", VA = "0x180CC0D80")]
		public void OnLink()
		{
		}

		// Token: 0x04004ADC RID: 19164
		[Token(Token = "0x4004ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04004ADD RID: 19165
		[Token(Token = "0x4004ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int assignID;

		// Token: 0x04004ADE RID: 19166
		[Token(Token = "0x4004ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Evidence evidence;

		// Token: 0x04004ADF RID: 19167
		[Token(Token = "0x4004ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Evidence.DataKey> dataKeys;

		// Token: 0x04004AE0 RID: 19168
		[Token(Token = "0x4004AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<int> inputCode;

		// Token: 0x04004AE1 RID: 19169
		[Token(Token = "0x4004AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string helpPage;
	}

	// Token: 0x020008D0 RID: 2256
	[Token(Token = "0x20008D0")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002A95 RID: 10901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A95")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		[Token(Token = "0x6002A96")]
		[Address(RVA = "0xCC16E0", Offset = "0xCC06E0", VA = "0x180CC16E0")]
		internal bool <LoadTextFiles>b__50_2(LanguageConfigLoader.LocInput item)
		{
			return default(bool);
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		[Token(Token = "0x6002A97")]
		[Address(RVA = "0xCC1750", Offset = "0xCC0750", VA = "0x180CC1750")]
		internal bool <LoadTextFiles>b__50_0(LanguageConfigLoader.LocInput item)
		{
			return default(bool);
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x0000FC00 File Offset: 0x0000DE00
		[Token(Token = "0x6002A98")]
		[Address(RVA = "0xCC1770", Offset = "0xCC0770", VA = "0x180CC1770")]
		internal bool <LoadTextFiles>b__50_1(LanguageConfigLoader.LocInput item)
		{
			return default(bool);
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x0000FC18 File Offset: 0x0000DE18
		[Token(Token = "0x6002A99")]
		[Address(RVA = "0xCC1770", Offset = "0xCC0770", VA = "0x180CC1770")]
		internal bool <LoadTextFiles>b__50_3(LanguageConfigLoader.LocInput item)
		{
			return default(bool);
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x0000FC30 File Offset: 0x0000DE30
		[Token(Token = "0x6002A9A")]
		[Address(RVA = "0xCC1830", Offset = "0xCC0830", VA = "0x180CC1830")]
		internal bool <GetScopeObject>b__74_0(GroupsController.SocialGroup item)
		{
			return default(bool);
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x0000FC48 File Offset: 0x0000DE48
		[Token(Token = "0x6002A9B")]
		[Address(RVA = "0xCC1970", Offset = "0xCC0970", VA = "0x180CC1970")]
		internal int <GetScopeObject>b__74_1(GroupsController.SocialGroup p1, GroupsController.SocialGroup p2)
		{
			return 0;
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x0000FC60 File Offset: 0x0000DE60
		[Token(Token = "0x6002A9C")]
		[Address(RVA = "0xCC19B0", Offset = "0xCC09B0", VA = "0x180CC19B0")]
		internal bool <GetScopeObject>b__74_2(GroupsController.SocialGroup item)
		{
			return default(bool);
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x0000FC78 File Offset: 0x0000DE78
		[Token(Token = "0x6002A9D")]
		[Address(RVA = "0xCC1970", Offset = "0xCC0970", VA = "0x180CC1970")]
		internal int <GetScopeObject>b__74_3(GroupsController.SocialGroup p1, GroupsController.SocialGroup p2)
		{
			return 0;
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x0000FC90 File Offset: 0x0000DE90
		[Token(Token = "0x6002A9E")]
		[Address(RVA = "0xCC1970", Offset = "0xCC0970", VA = "0x180CC1970")]
		internal int <GetScopeObject>b__74_5(GroupsController.SocialGroup p1, GroupsController.SocialGroup p2)
		{
			return 0;
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		[Token(Token = "0x6002A9F")]
		[Address(RVA = "0xCC1970", Offset = "0xCC0970", VA = "0x180CC1970")]
		internal int <GetScopeObject>b__74_6(GroupsController.SocialGroup p1, GroupsController.SocialGroup p2)
		{
			return 0;
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		[Token(Token = "0x6002AA0")]
		[Address(RVA = "0xCC1970", Offset = "0xCC0970", VA = "0x180CC1970")]
		internal int <GetScopeObject>b__74_7(GroupsController.SocialGroup p1, GroupsController.SocialGroup p2)
		{
			return 0;
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		[Token(Token = "0x6002AA1")]
		[Address(RVA = "0xCC1970", Offset = "0xCC0970", VA = "0x180CC1970")]
		internal int <GetScopeObject>b__74_8(GroupsController.SocialGroup p1, GroupsController.SocialGroup p2)
		{
			return 0;
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		[Token(Token = "0x6002AA2")]
		[Address(RVA = "0xCC1AF0", Offset = "0xCC0AF0", VA = "0x180CC1AF0")]
		internal bool <GetScopeObject>b__74_9(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x0000FD08 File Offset: 0x0000DF08
		[Token(Token = "0x6002AA3")]
		[Address(RVA = "0xCC1B90", Offset = "0xCC0B90", VA = "0x180CC1B90")]
		internal bool <GetScopeObject>b__74_10(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x0000FD20 File Offset: 0x0000DF20
		[Token(Token = "0x6002AA4")]
		[Address(RVA = "0xCC1C20", Offset = "0xCC0C20", VA = "0x180CC1C20")]
		internal bool <GetScopeObject>b__74_11(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x0000FD38 File Offset: 0x0000DF38
		[Token(Token = "0x6002AA5")]
		[Address(RVA = "0xCC1CB0", Offset = "0xCC0CB0", VA = "0x180CC1CB0")]
		internal bool <GetScopeObject>b__74_12(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x0000FD50 File Offset: 0x0000DF50
		[Token(Token = "0x6002AA6")]
		[Address(RVA = "0xCC1D40", Offset = "0xCC0D40", VA = "0x180CC1D40")]
		internal bool <GetScopeObject>b__74_13(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x0000FD68 File Offset: 0x0000DF68
		[Token(Token = "0x6002AA7")]
		[Address(RVA = "0xCC1DD0", Offset = "0xCC0DD0", VA = "0x180CC1DD0")]
		internal bool <GetScopeObject>b__74_14(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x0000FD80 File Offset: 0x0000DF80
		[Token(Token = "0x6002AA8")]
		[Address(RVA = "0xCC1E60", Offset = "0xCC0E60", VA = "0x180CC1E60")]
		internal bool <GetScopeObject>b__74_15(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x0000FD98 File Offset: 0x0000DF98
		[Token(Token = "0x6002AA9")]
		[Address(RVA = "0xCC1EF0", Offset = "0xCC0EF0", VA = "0x180CC1EF0")]
		internal bool <GetScopeObject>b__74_16(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		[Token(Token = "0x6002AAA")]
		[Address(RVA = "0xCC1F80", Offset = "0xCC0F80", VA = "0x180CC1F80")]
		internal bool <GetScopeObject>b__74_17(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		[Token(Token = "0x6002AAB")]
		[Address(RVA = "0xCC2010", Offset = "0xCC1010", VA = "0x180CC2010")]
		internal bool <GetScopeObject>b__74_18(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		[Token(Token = "0x6002AAC")]
		[Address(RVA = "0xCC20A0", Offset = "0xCC10A0", VA = "0x180CC20A0")]
		internal bool <GetScopeObject>b__74_19(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		[Token(Token = "0x6002AAD")]
		[Address(RVA = "0xCC2130", Offset = "0xCC1130", VA = "0x180CC2130")]
		internal bool <GetScopeObject>b__74_20(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x0000FE10 File Offset: 0x0000E010
		[Token(Token = "0x6002AAE")]
		[Address(RVA = "0xCC21C0", Offset = "0xCC11C0", VA = "0x180CC21C0")]
		internal bool <GetScopeObject>b__74_21(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x0000FE28 File Offset: 0x0000E028
		[Token(Token = "0x6002AAF")]
		[Address(RVA = "0xCC2250", Offset = "0xCC1250", VA = "0x180CC2250")]
		internal bool <GetScopeObject>b__74_22(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x0000FE40 File Offset: 0x0000E040
		[Token(Token = "0x6002AB0")]
		[Address(RVA = "0xCC22E0", Offset = "0xCC12E0", VA = "0x180CC22E0")]
		internal bool <GetScopeObject>b__74_23(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x0000FE58 File Offset: 0x0000E058
		[Token(Token = "0x6002AB1")]
		[Address(RVA = "0xCC2370", Offset = "0xCC1370", VA = "0x180CC2370")]
		internal bool <GetScopeObject>b__74_24(Company item)
		{
			return default(bool);
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x0000FE70 File Offset: 0x0000E070
		[Token(Token = "0x6002AB2")]
		[Address(RVA = "0x792140", Offset = "0x791140", VA = "0x180792140")]
		internal bool <GetContainedValue>b__75_2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x0000FE88 File Offset: 0x0000E088
		[Token(Token = "0x6002AB3")]
		[Address(RVA = "0x792170", Offset = "0x791170", VA = "0x180792170")]
		internal bool <GetContainedValue>b__75_3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		[Token(Token = "0x6002AB4")]
		[Address(RVA = "0xCC2400", Offset = "0xCC1400", VA = "0x180CC2400")]
		internal bool <GetContainedValue>b__75_7(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		[Token(Token = "0x6002AB5")]
		[Address(RVA = "0xCC25F0", Offset = "0xCC15F0", VA = "0x180CC25F0")]
		internal bool <GetContainedValue>b__75_8(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		[Token(Token = "0x6002AB6")]
		[Address(RVA = "0xCC27E0", Offset = "0xCC17E0", VA = "0x180CC27E0")]
		internal bool <GetContainedValue>b__75_9(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		[Token(Token = "0x6002AB7")]
		[Address(RVA = "0xCC2890", Offset = "0xCC1890", VA = "0x180CC2890")]
		internal bool <GetContainedValue>b__75_12(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x0000FF00 File Offset: 0x0000E100
		[Token(Token = "0x6002AB8")]
		[Address(RVA = "0xCC28B0", Offset = "0xCC18B0", VA = "0x180CC28B0")]
		internal bool <GetContainedValue>b__75_13(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0000FF18 File Offset: 0x0000E118
		[Token(Token = "0x6002AB9")]
		[Address(RVA = "0xCC28D0", Offset = "0xCC18D0", VA = "0x180CC28D0")]
		internal bool <GetContainedValue>b__75_15(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x0000FF30 File Offset: 0x0000E130
		[Token(Token = "0x6002ABA")]
		[Address(RVA = "0xCC28F0", Offset = "0xCC18F0", VA = "0x180CC28F0")]
		internal bool <GetContainedValue>b__75_16(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x0000FF48 File Offset: 0x0000E148
		[Token(Token = "0x6002ABB")]
		[Address(RVA = "0xCC2910", Offset = "0xCC1910", VA = "0x180CC2910")]
		internal bool <GetContainedValue>b__75_17(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x0000FF60 File Offset: 0x0000E160
		[Token(Token = "0x6002ABC")]
		[Address(RVA = "0xCC2930", Offset = "0xCC1930", VA = "0x180CC2930")]
		internal bool <GetContainedValue>b__75_18(Case.ResolveQuestion item)
		{
			return default(bool);
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x0000FF78 File Offset: 0x0000E178
		[Token(Token = "0x6002ABD")]
		[Address(RVA = "0xCC2970", Offset = "0xCC1970", VA = "0x180CC2970")]
		internal bool <RemoveCharacters>b__84_0(char c)
		{
			return default(bool);
		}

		// Token: 0x04004AE2 RID: 19170
		[Token(Token = "0x4004AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Strings.<>c <>9;

		// Token: 0x04004AE3 RID: 19171
		[Token(Token = "0x4004AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<LanguageConfigLoader.LocInput> <>9__50_2;

		// Token: 0x04004AE4 RID: 19172
		[Token(Token = "0x4004AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<LanguageConfigLoader.LocInput> <>9__50_0;

		// Token: 0x04004AE5 RID: 19173
		[Token(Token = "0x4004AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<LanguageConfigLoader.LocInput> <>9__50_1;

		// Token: 0x04004AE6 RID: 19174
		[Token(Token = "0x4004AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<LanguageConfigLoader.LocInput> <>9__50_3;

		// Token: 0x04004AE7 RID: 19175
		[Token(Token = "0x4004AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<GroupsController.SocialGroup> <>9__74_0;

		// Token: 0x04004AE8 RID: 19176
		[Token(Token = "0x4004AE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Comparison<GroupsController.SocialGroup> <>9__74_1;

		// Token: 0x04004AE9 RID: 19177
		[Token(Token = "0x4004AE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<GroupsController.SocialGroup> <>9__74_2;

		// Token: 0x04004AEA RID: 19178
		[Token(Token = "0x4004AEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Comparison<GroupsController.SocialGroup> <>9__74_3;

		// Token: 0x04004AEB RID: 19179
		[Token(Token = "0x4004AEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Comparison<GroupsController.SocialGroup> <>9__74_5;

		// Token: 0x04004AEC RID: 19180
		[Token(Token = "0x4004AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Comparison<GroupsController.SocialGroup> <>9__74_6;

		// Token: 0x04004AED RID: 19181
		[Token(Token = "0x4004AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Comparison<GroupsController.SocialGroup> <>9__74_7;

		// Token: 0x04004AEE RID: 19182
		[Token(Token = "0x4004AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Comparison<GroupsController.SocialGroup> <>9__74_8;

		// Token: 0x04004AEF RID: 19183
		[Token(Token = "0x4004AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Predicate<NewAddress> <>9__74_9;

		// Token: 0x04004AF0 RID: 19184
		[Token(Token = "0x4004AF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static Predicate<Company> <>9__74_10;

		// Token: 0x04004AF1 RID: 19185
		[Token(Token = "0x4004AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static Predicate<Company> <>9__74_11;

		// Token: 0x04004AF2 RID: 19186
		[Token(Token = "0x4004AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static Predicate<Company> <>9__74_12;

		// Token: 0x04004AF3 RID: 19187
		[Token(Token = "0x4004AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static Predicate<Company> <>9__74_13;

		// Token: 0x04004AF4 RID: 19188
		[Token(Token = "0x4004AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static Predicate<Company> <>9__74_14;

		// Token: 0x04004AF5 RID: 19189
		[Token(Token = "0x4004AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static Predicate<Company> <>9__74_15;

		// Token: 0x04004AF6 RID: 19190
		[Token(Token = "0x4004AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static Predicate<Company> <>9__74_16;

		// Token: 0x04004AF7 RID: 19191
		[Token(Token = "0x4004AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static Predicate<Company> <>9__74_17;

		// Token: 0x04004AF8 RID: 19192
		[Token(Token = "0x4004AF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static Predicate<Company> <>9__74_18;

		// Token: 0x04004AF9 RID: 19193
		[Token(Token = "0x4004AF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static Predicate<Company> <>9__74_19;

		// Token: 0x04004AFA RID: 19194
		[Token(Token = "0x4004AFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static Predicate<Company> <>9__74_20;

		// Token: 0x04004AFB RID: 19195
		[Token(Token = "0x4004AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static Predicate<Company> <>9__74_21;

		// Token: 0x04004AFC RID: 19196
		[Token(Token = "0x4004AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static Predicate<Company> <>9__74_22;

		// Token: 0x04004AFD RID: 19197
		[Token(Token = "0x4004AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static Predicate<Company> <>9__74_23;

		// Token: 0x04004AFE RID: 19198
		[Token(Token = "0x4004AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static Predicate<Company> <>9__74_24;

		// Token: 0x04004AFF RID: 19199
		[Token(Token = "0x4004AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static Predicate<Human.Trait> <>9__75_2;

		// Token: 0x04004B00 RID: 19200
		[Token(Token = "0x4004B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static Predicate<Human.Trait> <>9__75_3;

		// Token: 0x04004B01 RID: 19201
		[Token(Token = "0x4004B01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public static Predicate<MurderController.Murder> <>9__75_7;

		// Token: 0x04004B02 RID: 19202
		[Token(Token = "0x4004B02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static Predicate<MurderController.Murder> <>9__75_8;

		// Token: 0x04004B03 RID: 19203
		[Token(Token = "0x4004B03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static Predicate<NewRoom> <>9__75_9;

		// Token: 0x04004B04 RID: 19204
		[Token(Token = "0x4004B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static Predicate<Interactable.Passed> <>9__75_12;

		// Token: 0x04004B05 RID: 19205
		[Token(Token = "0x4004B05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public static Predicate<Interactable.Passed> <>9__75_13;

		// Token: 0x04004B06 RID: 19206
		[Token(Token = "0x4004B06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public static Predicate<Interactable.Passed> <>9__75_15;

		// Token: 0x04004B07 RID: 19207
		[Token(Token = "0x4004B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public static Predicate<Interactable.Passed> <>9__75_16;

		// Token: 0x04004B08 RID: 19208
		[Token(Token = "0x4004B08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public static Predicate<Interactable.Passed> <>9__75_17;

		// Token: 0x04004B09 RID: 19209
		[Token(Token = "0x4004B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public static Predicate<Case.ResolveQuestion> <>9__75_18;

		// Token: 0x04004B0A RID: 19210
		[Token(Token = "0x4004B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public static Predicate<char> <>9__84_0;
	}

	// Token: 0x020008D1 RID: 2257
	[Token(Token = "0x20008D1")]
	private sealed class <>c__DisplayClass68_0
	{
		// Token: 0x06002ABE RID: 10942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ABE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass68_0()
		{
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x0000FF90 File Offset: 0x0000E190
		[Token(Token = "0x6002ABF")]
		[Address(RVA = "0x527150", Offset = "0x526150", VA = "0x180527150")]
		internal bool <ImportNonEnglish>b__0(LanguageConfigLoader.LocInput item)
		{
			return default(bool);
		}

		// Token: 0x04004B0B RID: 19211
		[Token(Token = "0x4004B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;
	}

	// Token: 0x020008D2 RID: 2258
	[Token(Token = "0x20008D2")]
	private sealed class <>c__DisplayClass71_0
	{
		// Token: 0x06002AC0 RID: 10944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass71_0()
		{
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
		[Token(Token = "0x6002AC1")]
		[Address(RVA = "0xCC2A00", Offset = "0xCC1A00", VA = "0x180CC2A00")]
		internal bool <ComposeText>b__0(GroupsController.SocialGroup item)
		{
			return default(bool);
		}

		// Token: 0x04004B0C RID: 19212
		[Token(Token = "0x4004B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public VMailApp.VmailParsingData thread;
	}

	// Token: 0x020008D3 RID: 2259
	[Token(Token = "0x20008D3")]
	private sealed class <>c__DisplayClass73_0
	{
		// Token: 0x06002AC2 RID: 10946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass73_0()
		{
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		[Token(Token = "0x6002AC3")]
		[Address(RVA = "0x51E980", Offset = "0x51D980", VA = "0x18051E980")]
		internal bool <GetContainedScope>b__0(DDSScope.ContainedScope item)
		{
			return default(bool);
		}

		// Token: 0x04004B0D RID: 19213
		[Token(Token = "0x4004B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string newScope;
	}

	// Token: 0x020008D4 RID: 2260
	[Token(Token = "0x20008D4")]
	private sealed class <>c__DisplayClass74_0
	{
		// Token: 0x06002AC4 RID: 10948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass74_0()
		{
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		[Token(Token = "0x6002AC5")]
		[Address(RVA = "0xCC2A70", Offset = "0xCC1A70", VA = "0x180CC2A70")]
		internal bool <GetScopeObject>b__4(Occupation item)
		{
			return default(bool);
		}

		// Token: 0x04004B0E RID: 19214
		[Token(Token = "0x4004B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Company company;
	}

	// Token: 0x020008D5 RID: 2261
	[Token(Token = "0x20008D5")]
	private sealed class <>c__DisplayClass75_0
	{
		// Token: 0x06002AC6 RID: 10950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass75_0()
		{
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
		[Token(Token = "0x6002AC7")]
		[Address(RVA = "0xCC2D30", Offset = "0xCC1D30", VA = "0x180CC2D30")]
		internal bool <GetContainedValue>b__0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x00010008 File Offset: 0x0000E208
		[Token(Token = "0x6002AC8")]
		[Address(RVA = "0xCC2D30", Offset = "0xCC1D30", VA = "0x180CC2D30")]
		internal bool <GetContainedValue>b__1(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x04004B0F RID: 19215
		[Token(Token = "0x4004B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human human;

		// Token: 0x04004B10 RID: 19216
		[Token(Token = "0x4004B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Interactable objParent;
	}

	// Token: 0x020008D6 RID: 2262
	[Token(Token = "0x20008D6")]
	private sealed class <>c__DisplayClass75_1
	{
		// Token: 0x06002AC9 RID: 10953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass75_1()
		{
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x00010020 File Offset: 0x0000E220
		[Token(Token = "0x6002ACA")]
		[Address(RVA = "0xC506B0", Offset = "0xC4F6B0", VA = "0x180C506B0")]
		internal bool <GetContainedValue>b__4(GameplayController.LoanDebt item)
		{
			return default(bool);
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x00010038 File Offset: 0x0000E238
		[Token(Token = "0x6002ACB")]
		[Address(RVA = "0xC506B0", Offset = "0xC4F6B0", VA = "0x180C506B0")]
		internal bool <GetContainedValue>b__5(GameplayController.LoanDebt item)
		{
			return default(bool);
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x00010050 File Offset: 0x0000E250
		[Token(Token = "0x6002ACC")]
		[Address(RVA = "0xC506B0", Offset = "0xC4F6B0", VA = "0x180C506B0")]
		internal bool <GetContainedValue>b__6(GameplayController.LoanDebt item)
		{
			return default(bool);
		}

		// Token: 0x04004B11 RID: 19217
		[Token(Token = "0x4004B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Company company;
	}

	// Token: 0x020008D7 RID: 2263
	[Token(Token = "0x20008D7")]
	private sealed class <>c__DisplayClass75_2
	{
		// Token: 0x06002ACD RID: 10957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ACD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass75_2()
		{
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x00010068 File Offset: 0x0000E268
		[Token(Token = "0x6002ACE")]
		[Address(RVA = "0xCC2D80", Offset = "0xCC1D80", VA = "0x180CC2D80")]
		internal bool <GetContainedValue>b__10(MurderController.MurderMethod item)
		{
			return default(bool);
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x00010080 File Offset: 0x0000E280
		[Token(Token = "0x6002ACF")]
		[Address(RVA = "0xCC2D80", Offset = "0xCC1D80", VA = "0x180CC2D80")]
		internal bool <GetContainedValue>b__11(MurderController.MurderMethod item)
		{
			return default(bool);
		}

		// Token: 0x04004B12 RID: 19218
		[Token(Token = "0x4004B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MurderController.Murder m;
	}

	// Token: 0x020008D8 RID: 2264
	[Token(Token = "0x20008D8")]
	private sealed class <>c__DisplayClass75_3
	{
		// Token: 0x06002AD0 RID: 10960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass75_3()
		{
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x00010098 File Offset: 0x0000E298
		[Token(Token = "0x6002AD1")]
		[Address(RVA = "0x684F40", Offset = "0x683F40", VA = "0x180684F40")]
		internal bool <GetContainedValue>b__14(NewBuilding item)
		{
			return default(bool);
		}

		// Token: 0x04004B13 RID: 19219
		[Token(Token = "0x4004B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Interactable.Passed passed;
	}

	// Token: 0x020008D9 RID: 2265
	[Token(Token = "0x20008D9")]
	private sealed class <>c__DisplayClass75_4
	{
		// Token: 0x06002AD2 RID: 10962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AD2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass75_4()
		{
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x000100B0 File Offset: 0x0000E2B0
		[Token(Token = "0x6002AD3")]
		[Address(RVA = "0xCC2DC0", Offset = "0xCC1DC0", VA = "0x180CC2DC0")]
		internal bool <GetContainedValue>b__19(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x04004B14 RID: 19220
		[Token(Token = "0x4004B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SideJob job;
	}
}
