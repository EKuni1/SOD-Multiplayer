using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

// Token: 0x0200038C RID: 908
[Token(Token = "0x200038C")]
public class ModLoader : MonoBehaviour
{
	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06001470 RID: 5232 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000B3")]
	public static ModLoader Instance
	{
		[Token(Token = "0x6001470")]
		[Address(RVA = "0x7B8FF0", Offset = "0x7B7FF0", VA = "0x1807B8FF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001471 RID: 5233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001471")]
	[Address(RVA = "0x7B9030", Offset = "0x7B8030", VA = "0x1807B9030")]
	private void Awake()
	{
	}

	// Token: 0x06001472 RID: 5234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001472")]
	[Address(RVA = "0x7B9430", Offset = "0x7B8430", VA = "0x1807B9430")]
	public void GetMods(bool allowDelayedSteamworksCheck = false)
	{
	}

	// Token: 0x06001473 RID: 5235 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001473")]
	[Address(RVA = "0x7B9930", Offset = "0x7B8930", VA = "0x1807B9930")]
	private IEnumerator SteamworksModLoadingCheck()
	{
		return null;
	}

	// Token: 0x06001474 RID: 5236 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001474")]
	[Address(RVA = "0x7B99D0", Offset = "0x7B89D0", VA = "0x1807B99D0")]
	public void GetModsComplete()
	{
	}

	// Token: 0x06001475 RID: 5237 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001475")]
	[Address(RVA = "0x7B9F70", Offset = "0x7B8F70", VA = "0x1807B9F70")]
	private IEnumerator WaitForLoadingModdedFiles()
	{
		return null;
	}

	// Token: 0x06001476 RID: 5238 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001476")]
	[Address(RVA = "0x7BA010", Offset = "0x7B9010", VA = "0x1807BA010")]
	public List<ModSettingsData> GetLocalMods()
	{
		return null;
	}

	// Token: 0x06001477 RID: 5239 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001477")]
	[Address(RVA = "0x7BA5E0", Offset = "0x7B95E0", VA = "0x1807BA5E0")]
	public List<ModSettingsData> GetModIOMods()
	{
		return null;
	}

	// Token: 0x06001478 RID: 5240 RVA: 0x00009A80 File Offset: 0x00007C80
	[Token(Token = "0x6001478")]
	[Address(RVA = "0x7BAE20", Offset = "0x7B9E20", VA = "0x1807BAE20")]
	private bool TryGetSteamWorkshopItems()
	{
		return default(bool);
	}

	// Token: 0x06001479 RID: 5241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001479")]
	[Address(RVA = "0x7BB380", Offset = "0x7BA380", VA = "0x1807BB380")]
	private void SteamWorkshopContentQueryCompleted(SteamUGCQueryCompleted_t response, bool bIOFailure)
	{
	}

	// Token: 0x0600147A RID: 5242 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600147A")]
	[Address(RVA = "0x7BC240", Offset = "0x7BB240", VA = "0x1807BC240")]
	private ModSettingsData GetOrCreateModSettings(string path, string modName, ModSettingsData.ModSource source, string creator, string summary, string alternatePath = "", bool modEnabled = true, bool disableCreateFile = false, string workshopID = "", [Optional] List<string> tags)
	{
		return null;
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600147B")]
	[Address(RVA = "0x7BCB10", Offset = "0x7BBB10", VA = "0x1807BCB10")]
	public List<FileInfo> GetFilesWithinActiveMods(string subPath, string[] fileExtensions)
	{
		return null;
	}

	// Token: 0x0600147C RID: 5244 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600147C")]
	[Address(RVA = "0x7BD240", Offset = "0x7BC240", VA = "0x1807BD240")]
	public List<DirectoryInfo> GetActiveLanguageModDirectories()
	{
		return null;
	}

	// Token: 0x0600147D RID: 5245 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600147D")]
	[Address(RVA = "0x7BD6C0", Offset = "0x7BC6C0", VA = "0x1807BD6C0")]
	public List<FileInfo> GetActiveCities()
	{
		return null;
	}

	// Token: 0x0600147E RID: 5246 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600147E")]
	[Address(RVA = "0x7BD850", Offset = "0x7BC850", VA = "0x1807BD850")]
	public List<FileInfo> GetActiveSaves()
	{
		return null;
	}

	// Token: 0x0600147F RID: 5247 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600147F")]
	[Address(RVA = "0x7BD980", Offset = "0x7BC980", VA = "0x1807BD980")]
	public List<DirectoryInfo> GetActiveDDSModDirectories()
	{
		return null;
	}

	// Token: 0x06001480 RID: 5248 RVA: 0x00009A98 File Offset: 0x00007C98
	[Token(Token = "0x6001480")]
	[Address(RVA = "0x418400", Offset = "0x417400", VA = "0x180418400")]
	public bool IsConsole()
	{
		return default(bool);
	}

	// Token: 0x06001481 RID: 5249 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001481")]
	[Address(RVA = "0x7BDE50", Offset = "0x7BCE50", VA = "0x1807BDE50")]
	private void AddSOToModResources(ScriptableObject so)
	{
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x00009AB0 File Offset: 0x00007CB0
	[Token(Token = "0x6001482")]
	public bool GetDataFromModResources<T>(string searchName, out T output) where T : ScriptableObject
	{
		return default(bool);
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001483")]
	[Address(RVA = "0x7BE1C0", Offset = "0x7BD1C0", VA = "0x1807BE1C0")]
	public void LoadInModdedFiles()
	{
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001484")]
	[Address(RVA = "0x7BE380", Offset = "0x7BD380", VA = "0x1807BE380")]
	public Task PerformModdedFileLoadAsync()
	{
		return null;
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001485")]
	[Address(RVA = "0x7BE560", Offset = "0x7BD560", VA = "0x1807BE560")]
	public void LoadModdedResources()
	{
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001486")]
	[Address(RVA = "0x7BED80", Offset = "0x7BDD80", VA = "0x1807BED80")]
	public InteractablePreset CreateItemFromModdedItemData(ModdedInteractable modItemData)
	{
		return null;
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001487")]
	[Address(RVA = "0x7C24A0", Offset = "0x7C14A0", VA = "0x1807C24A0")]
	public MenuPreset CreateMenuFromModdedItemData(ModdedMenu modMenuData)
	{
		return null;
	}

	// Token: 0x06001488 RID: 5256 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001488")]
	[Address(RVA = "0x7C2F80", Offset = "0x7C1F80", VA = "0x1807C2F80")]
	public RetailItemPreset CreateRetailItemFromModdedItemData(ModdedRetailItem modRetailItemData)
	{
		return null;
	}

	// Token: 0x06001489 RID: 5257 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001489")]
	[Address(RVA = "0x7C3E20", Offset = "0x7C2E20", VA = "0x1807C3E20")]
	public MurderWeaponPreset CreateMurderWeaponFromModdedItemData(ModdedMurderWeapon modWeaponData)
	{
		return null;
	}

	// Token: 0x0600148A RID: 5258 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600148A")]
	[Address(RVA = "0x7C5850", Offset = "0x7C4850", VA = "0x1807C5850")]
	public BookPreset CreateBookFromModdedItemData(ModdedBook modBookData)
	{
		return null;
	}

	// Token: 0x0600148B RID: 5259 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600148B")]
	[Address(RVA = "0x7C6780", Offset = "0x7C5780", VA = "0x1807C6780")]
	public ColourSchemePreset CreateColourSchemeModdedItemData(ModdedColourScheme modColourData)
	{
		return null;
	}

	// Token: 0x0600148C RID: 5260 RVA: 0x00009AC8 File Offset: 0x00007CC8
	[Token(Token = "0x600148C")]
	[Address(RVA = "0x7C6C20", Offset = "0x7C5C20", VA = "0x1807C6C20")]
	private bool TryFindPrefab(string prefabName, out GameObject prefab)
	{
		return default(bool);
	}

	// Token: 0x0600148D RID: 5261 RVA: 0x00009AE0 File Offset: 0x00007CE0
	[Token(Token = "0x600148D")]
	[Address(RVA = "0x7C7020", Offset = "0x7C6020", VA = "0x1807C7020")]
	private bool TryFindObjectSprite(string objectName, out Sprite sprite)
	{
		return default(bool);
	}

	// Token: 0x0600148E RID: 5262 RVA: 0x00009AF8 File Offset: 0x00007CF8
	[Token(Token = "0x600148E")]
	[Address(RVA = "0x7C7400", Offset = "0x7C6400", VA = "0x1807C7400")]
	private bool TryParseTraitPick(ref List<string> input, out InteractablePreset.TraitPick pick)
	{
		return default(bool);
	}

	// Token: 0x0600148F RID: 5263 RVA: 0x00009B10 File Offset: 0x00007D10
	[Token(Token = "0x600148F")]
	[Address(RVA = "0x7C7960", Offset = "0x7C6960", VA = "0x1807C7960")]
	private bool TryParseTraitPick(ref List<string> input, out MurderPreset.MurdererModifierRule pick)
	{
		return default(bool);
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x00009B28 File Offset: 0x00007D28
	[Token(Token = "0x6001490")]
	[Address(RVA = "0x7C7F00", Offset = "0x7C6F00", VA = "0x1807C7F00")]
	private bool TryParseTraitPick(ref List<string> input, out CharacterTrait.TraitPickRule pick)
	{
		return default(bool);
	}

	// Token: 0x06001491 RID: 5265 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001491")]
	[Address(RVA = "0x7C83C0", Offset = "0x7C73C0", VA = "0x1807C83C0")]
	public void CopyItemData(ref InteractablePreset copyTo, ref InteractablePreset copyFrom)
	{
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001492")]
	[Address(RVA = "0x7CB120", Offset = "0x7CA120", VA = "0x1807CB120")]
	public void CopyMenuData(ref MenuPreset copyTo, ref MenuPreset copyFrom)
	{
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001493")]
	[Address(RVA = "0x7CB3D0", Offset = "0x7CA3D0", VA = "0x1807CB3D0")]
	public void CopyRetailItemData(ref RetailItemPreset copyTo, ref RetailItemPreset copyFrom)
	{
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001494")]
	[Address(RVA = "0x7CB870", Offset = "0x7CA870", VA = "0x1807CB870")]
	public void CopyMurderWeaponData(ref MurderWeaponPreset copyTo, ref MurderWeaponPreset copyFrom)
	{
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001495")]
	[Address(RVA = "0x7CC780", Offset = "0x7CB780", VA = "0x1807CC780")]
	public void CopyBookData(ref BookPreset copyTo, ref BookPreset copyFrom)
	{
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001496")]
	[Address(RVA = "0x7CCC20", Offset = "0x7CBC20", VA = "0x1807CCC20")]
	public void CopyColourSchemeData(ref ColourSchemePreset copyTo, ref ColourSchemePreset copyFrom)
	{
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001497")]
	[Address(RVA = "0x7CCD20", Offset = "0x7CBD20", VA = "0x1807CCD20")]
	private void ParseBool(ref string input, ref bool boolRef)
	{
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001498")]
	[Address(RVA = "0x7CCE30", Offset = "0x7CBE30", VA = "0x1807CCE30")]
	private void ParseInt(ref string input, ref int intRef)
	{
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001499")]
	[Address(RVA = "0x7CCF30", Offset = "0x7CBF30", VA = "0x1807CCF30")]
	private void ParseFloat(ref string input, ref float floatRef)
	{
	}

	// Token: 0x0600149A RID: 5274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600149A")]
	private void ParseEnum<T>(ref string input, ref T enumRef)
	{
	}

	// Token: 0x0600149B RID: 5275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600149B")]
	[Address(RVA = "0x7CCFF0", Offset = "0x7CBFF0", VA = "0x1807CCFF0")]
	public ModLoader()
	{
	}

	// Token: 0x040018EA RID: 6378
	[Token(Token = "0x40018EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool modsLoaded;

	// Token: 0x040018EB RID: 6379
	[Token(Token = "0x40018EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool waitingForSteamworksMods;

	// Token: 0x040018EC RID: 6380
	[Token(Token = "0x40018EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<ModSettingsData> sortedModsList;

	// Token: 0x040018ED RID: 6381
	[Token(Token = "0x40018ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<ModSettingsData> modsListTemp;

	// Token: 0x040018EE RID: 6382
	[Token(Token = "0x40018EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<string> latestSteamworksSubscribedList;

	// Token: 0x040018EF RID: 6383
	[Token(Token = "0x40018EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Dictionary<Type, Dictionary<string, ScriptableObject>> createdModResources;

	// Token: 0x040018F0 RID: 6384
	[Token(Token = "0x40018F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<string> modStringFiles;

	// Token: 0x040018F1 RID: 6385
	[Token(Token = "0x40018F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool loadedModdedFiles;

	// Token: 0x040018F2 RID: 6386
	[Token(Token = "0x40018F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool waitingForModdedFileLoad;

	// Token: 0x040018F3 RID: 6387
	[Token(Token = "0x40018F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ModLoader _instance;

	// Token: 0x0200038D RID: 909
	[Token(Token = "0x200038D")]
	private sealed class <SteamworksModLoadingCheck>d__14 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600149C RID: 5276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149C")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <SteamworksModLoadingCheck>d__14(int <>1__state)
		{
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00009B40 File Offset: 0x00007D40
		[Token(Token = "0x600149E")]
		[Address(RVA = "0x7CD3D0", Offset = "0x7CC3D0", VA = "0x1807CD3D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B4")]
		private object Current
		{
			[Token(Token = "0x600149F")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A0")]
		[Address(RVA = "0x7CD660", Offset = "0x7CC660", VA = "0x1807CD660", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B5")]
		private object Current
		{
			[Token(Token = "0x60014A1")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040018F4 RID: 6388
		[Token(Token = "0x40018F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040018F5 RID: 6389
		[Token(Token = "0x40018F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040018F6 RID: 6390
		[Token(Token = "0x40018F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ModLoader <>4__this;

		// Token: 0x040018F7 RID: 6391
		[Token(Token = "0x40018F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <waiting>5__2;

		// Token: 0x040018F8 RID: 6392
		[Token(Token = "0x40018F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool <doSteamworksCheck>5__3;

		// Token: 0x040018F9 RID: 6393
		[Token(Token = "0x40018F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timeout>5__4;
	}

	// Token: 0x0200038E RID: 910
	[Token(Token = "0x200038E")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060014A3 RID: 5283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00009B58 File Offset: 0x00007D58
		[Token(Token = "0x60014A4")]
		[Address(RVA = "0x650E40", Offset = "0x64FE40", VA = "0x180650E40")]
		internal int <GetModsComplete>b__15_0(ModSettingsData p1, ModSettingsData p2)
		{
			return 0;
		}

		// Token: 0x040018FA RID: 6394
		[Token(Token = "0x40018FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ModLoader.<>c <>9;

		// Token: 0x040018FB RID: 6395
		[Token(Token = "0x40018FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<ModSettingsData> <>9__15_0;
	}

	// Token: 0x0200038F RID: 911
	[Token(Token = "0x200038F")]
	private sealed class <WaitForLoadingModdedFiles>d__16 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060014A5 RID: 5285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <WaitForLoadingModdedFiles>d__16(int <>1__state)
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00009B70 File Offset: 0x00007D70
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x7CD760", Offset = "0x7CC760", VA = "0x1807CD760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B6")]
		private object Current
		{
			[Token(Token = "0x60014A8")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x7CDBE0", Offset = "0x7CCBE0", VA = "0x1807CDBE0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B7")]
		private object Current
		{
			[Token(Token = "0x60014AA")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040018FC RID: 6396
		[Token(Token = "0x40018FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040018FD RID: 6397
		[Token(Token = "0x40018FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040018FE RID: 6398
		[Token(Token = "0x40018FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ModLoader <>4__this;
	}

	// Token: 0x02000390 RID: 912
	[Token(Token = "0x2000390")]
	[StructLayout(3)]
	private struct <LoadInModdedFiles>d__30 : IEnumerator<object>
	{
		// Token: 0x060014AB RID: 5291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x7CDC30", Offset = "0x7CCC30", VA = "0x1807CDC30", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x6F8FA0", Offset = "0x6F7FA0", VA = "0x1806F8FA0", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x040018FF RID: 6399
		[Token(Token = "0x40018FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04001900 RID: 6400
		[Token(Token = "0x4001900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		// Token: 0x04001901 RID: 6401
		[Token(Token = "0x4001901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ModLoader <>4__this;

		// Token: 0x04001902 RID: 6402
		[Token(Token = "0x4001902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter <>u__1;
	}

	// Token: 0x02000391 RID: 913
	[Token(Token = "0x2000391")]
	private sealed class <>c__DisplayClass31_0
	{
		// Token: 0x060014AD RID: 5293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_0()
		{
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x7CE030", Offset = "0x7CD030", VA = "0x1807CE030")]
		internal void <PerformModdedFileLoadAsync>b__0()
		{
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x7CE640", Offset = "0x7CD640", VA = "0x1807CE640")]
		internal void <PerformModdedFileLoadAsync>b__1()
		{
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B0")]
		[Address(RVA = "0x7CE710", Offset = "0x7CD710", VA = "0x1807CE710")]
		internal void <PerformModdedFileLoadAsync>b__2()
		{
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x7CE7E0", Offset = "0x7CD7E0", VA = "0x1807CE7E0")]
		internal void <PerformModdedFileLoadAsync>b__3()
		{
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x7CE8B0", Offset = "0x7CD8B0", VA = "0x1807CE8B0")]
		internal void <PerformModdedFileLoadAsync>b__4()
		{
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B3")]
		[Address(RVA = "0x7CE980", Offset = "0x7CD980", VA = "0x1807CE980")]
		internal void <PerformModdedFileLoadAsync>b__5()
		{
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x7CEA50", Offset = "0x7CDA50", VA = "0x1807CEA50")]
		internal void <PerformModdedFileLoadAsync>b__6()
		{
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x7CEB20", Offset = "0x7CDB20", VA = "0x1807CEB20")]
		internal void <PerformModdedFileLoadAsync>b__7()
		{
		}

		// Token: 0x04001903 RID: 6403
		[Token(Token = "0x4001903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<FileInfo> moddedInteractableFiles;

		// Token: 0x04001904 RID: 6404
		[Token(Token = "0x4001904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ModLoader <>4__this;

		// Token: 0x04001905 RID: 6405
		[Token(Token = "0x4001905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FileInfo> moddedMenuFiles;

		// Token: 0x04001906 RID: 6406
		[Token(Token = "0x4001906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<FileInfo> moddedRetailItems;

		// Token: 0x04001907 RID: 6407
		[Token(Token = "0x4001907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<FileInfo> moddedMurderWeapons;

		// Token: 0x04001908 RID: 6408
		[Token(Token = "0x4001908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<FileInfo> moddedBooks;

		// Token: 0x04001909 RID: 6409
		[Token(Token = "0x4001909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<FileInfo> moddedColourSchemes;

		// Token: 0x0400190A RID: 6410
		[Token(Token = "0x400190A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<ModdedInteractable> parsedInteractableFiles;

		// Token: 0x0400190B RID: 6411
		[Token(Token = "0x400190B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<ModdedMenu> parsedMenuFiles;

		// Token: 0x0400190C RID: 6412
		[Token(Token = "0x400190C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<ModdedRetailItem> parsedRetailItemFiles;

		// Token: 0x0400190D RID: 6413
		[Token(Token = "0x400190D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<ModdedMurderWeapon> parsedMurderWeaponFiles;

		// Token: 0x0400190E RID: 6414
		[Token(Token = "0x400190E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<ModdedBook> parsedBookFiles;

		// Token: 0x0400190F RID: 6415
		[Token(Token = "0x400190F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<ModdedColourScheme> parsedColourSchemeFiles;
	}

	// Token: 0x02000392 RID: 914
	[Token(Token = "0x2000392")]
	private sealed class <>c__DisplayClass31_1
	{
		// Token: 0x060014B6 RID: 5302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_1()
		{
		}

		// Token: 0x04001910 RID: 6416
		[Token(Token = "0x4001910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		// Token: 0x04001911 RID: 6417
		[Token(Token = "0x4001911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ModLoader.<>c__DisplayClass31_0 CS$<>8__locals1;
	}

	// Token: 0x02000393 RID: 915
	[Token(Token = "0x2000393")]
	private sealed class <>c__DisplayClass31_2
	{
		// Token: 0x060014B7 RID: 5303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_2()
		{
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x7CEBF0", Offset = "0x7CDBF0", VA = "0x1807CEBF0")]
		internal void <PerformModdedFileLoadAsync>b__8()
		{
		}

		// Token: 0x04001912 RID: 6418
		[Token(Token = "0x4001912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModdedInteractable moddedInteractable;

		// Token: 0x04001913 RID: 6419
		[Token(Token = "0x4001913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ModLoader.<>c__DisplayClass31_1 CS$<>8__locals2;
	}

	// Token: 0x02000394 RID: 916
	[Token(Token = "0x2000394")]
	private sealed class <>c__DisplayClass31_3
	{
		// Token: 0x060014B9 RID: 5305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_3()
		{
		}

		// Token: 0x04001914 RID: 6420
		[Token(Token = "0x4001914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		// Token: 0x04001915 RID: 6421
		[Token(Token = "0x4001915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ModLoader.<>c__DisplayClass31_0 CS$<>8__locals3;
	}

	// Token: 0x02000395 RID: 917
	[Token(Token = "0x2000395")]
	private sealed class <>c__DisplayClass31_4
	{
		// Token: 0x060014BA RID: 5306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_4()
		{
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x7CEF10", Offset = "0x7CDF10", VA = "0x1807CEF10")]
		internal void <PerformModdedFileLoadAsync>b__9()
		{
		}

		// Token: 0x04001916 RID: 6422
		[Token(Token = "0x4001916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModdedMenu moddedMenu;

		// Token: 0x04001917 RID: 6423
		[Token(Token = "0x4001917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ModLoader.<>c__DisplayClass31_3 CS$<>8__locals4;
	}

	// Token: 0x02000396 RID: 918
	[Token(Token = "0x2000396")]
	private sealed class <>c__DisplayClass31_5
	{
		// Token: 0x060014BC RID: 5308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_5()
		{
		}

		// Token: 0x04001918 RID: 6424
		[Token(Token = "0x4001918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		// Token: 0x04001919 RID: 6425
		[Token(Token = "0x4001919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ModLoader.<>c__DisplayClass31_0 CS$<>8__locals5;
	}

	// Token: 0x02000397 RID: 919
	[Token(Token = "0x2000397")]
	private sealed class <>c__DisplayClass31_6
	{
		// Token: 0x060014BD RID: 5309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_6()
		{
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x7CF230", Offset = "0x7CE230", VA = "0x1807CF230")]
		internal void <PerformModdedFileLoadAsync>b__10()
		{
		}

		// Token: 0x0400191A RID: 6426
		[Token(Token = "0x400191A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModdedRetailItem moddedRetailItem;

		// Token: 0x0400191B RID: 6427
		[Token(Token = "0x400191B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ModLoader.<>c__DisplayClass31_5 CS$<>8__locals6;
	}

	// Token: 0x02000398 RID: 920
	[Token(Token = "0x2000398")]
	private sealed class <>c__DisplayClass31_7
	{
		// Token: 0x060014BF RID: 5311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_7()
		{
		}

		// Token: 0x0400191C RID: 6428
		[Token(Token = "0x400191C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		// Token: 0x0400191D RID: 6429
		[Token(Token = "0x400191D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ModLoader.<>c__DisplayClass31_0 CS$<>8__locals7;
	}

	// Token: 0x02000399 RID: 921
	[Token(Token = "0x2000399")]
	private sealed class <>c__DisplayClass31_8
	{
		// Token: 0x060014C0 RID: 5312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_8()
		{
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x7CF550", Offset = "0x7CE550", VA = "0x1807CF550")]
		internal void <PerformModdedFileLoadAsync>b__11()
		{
		}

		// Token: 0x0400191E RID: 6430
		[Token(Token = "0x400191E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModdedMurderWeapon moddedMurderWeapon;

		// Token: 0x0400191F RID: 6431
		[Token(Token = "0x400191F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ModLoader.<>c__DisplayClass31_7 CS$<>8__locals8;
	}

	// Token: 0x0200039A RID: 922
	[Token(Token = "0x200039A")]
	private sealed class <>c__DisplayClass31_9
	{
		// Token: 0x060014C2 RID: 5314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_9()
		{
		}

		// Token: 0x04001920 RID: 6432
		[Token(Token = "0x4001920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		// Token: 0x04001921 RID: 6433
		[Token(Token = "0x4001921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ModLoader.<>c__DisplayClass31_0 CS$<>8__locals9;
	}

	// Token: 0x0200039B RID: 923
	[Token(Token = "0x200039B")]
	private sealed class <>c__DisplayClass31_10
	{
		// Token: 0x060014C3 RID: 5315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_10()
		{
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x7CF870", Offset = "0x7CE870", VA = "0x1807CF870")]
		internal void <PerformModdedFileLoadAsync>b__12()
		{
		}

		// Token: 0x04001922 RID: 6434
		[Token(Token = "0x4001922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModdedBook moddedBook;

		// Token: 0x04001923 RID: 6435
		[Token(Token = "0x4001923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ModLoader.<>c__DisplayClass31_9 CS$<>8__locals10;
	}

	// Token: 0x0200039C RID: 924
	[Token(Token = "0x200039C")]
	private sealed class <>c__DisplayClass31_11
	{
		// Token: 0x060014C5 RID: 5317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_11()
		{
		}

		// Token: 0x04001924 RID: 6436
		[Token(Token = "0x4001924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		// Token: 0x04001925 RID: 6437
		[Token(Token = "0x4001925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ModLoader.<>c__DisplayClass31_0 CS$<>8__locals11;
	}

	// Token: 0x0200039D RID: 925
	[Token(Token = "0x200039D")]
	private sealed class <>c__DisplayClass31_12
	{
		// Token: 0x060014C6 RID: 5318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_12()
		{
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C7")]
		[Address(RVA = "0x7CFB90", Offset = "0x7CEB90", VA = "0x1807CFB90")]
		internal void <PerformModdedFileLoadAsync>b__13()
		{
		}

		// Token: 0x04001926 RID: 6438
		[Token(Token = "0x4001926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModdedColourScheme moddedColourScheme;

		// Token: 0x04001927 RID: 6439
		[Token(Token = "0x4001927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ModLoader.<>c__DisplayClass31_11 CS$<>8__locals12;
	}

	// Token: 0x0200039E RID: 926
	[Token(Token = "0x200039E")]
	[StructLayout(3)]
	private struct <PerformModdedFileLoadAsync>d__31 : IEnumerator<object>
	{
		// Token: 0x060014C8 RID: 5320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x7CFEB0", Offset = "0x7CEEB0", VA = "0x1807CFEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x7D37A0", Offset = "0x7D27A0", VA = "0x1807D37A0", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04001928 RID: 6440
		[Token(Token = "0x4001928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04001929 RID: 6441
		[Token(Token = "0x4001929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		// Token: 0x0400192A RID: 6442
		[Token(Token = "0x400192A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ModLoader <>4__this;

		// Token: 0x0400192B RID: 6443
		[Token(Token = "0x400192B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ModLoader.<>c__DisplayClass31_0 <>8__1;

		// Token: 0x0400192C RID: 6444
		[Token(Token = "0x400192C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ModLoader.<>c__DisplayClass31_1 <>8__2;

		// Token: 0x0400192D RID: 6445
		[Token(Token = "0x400192D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ModLoader.<>c__DisplayClass31_2 <>8__3;

		// Token: 0x0400192E RID: 6446
		[Token(Token = "0x400192E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ModLoader.<>c__DisplayClass31_3 <>8__4;

		// Token: 0x0400192F RID: 6447
		[Token(Token = "0x400192F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ModLoader.<>c__DisplayClass31_4 <>8__5;

		// Token: 0x04001930 RID: 6448
		[Token(Token = "0x4001930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ModLoader.<>c__DisplayClass31_5 <>8__6;

		// Token: 0x04001931 RID: 6449
		[Token(Token = "0x4001931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ModLoader.<>c__DisplayClass31_6 <>8__7;

		// Token: 0x04001932 RID: 6450
		[Token(Token = "0x4001932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ModLoader.<>c__DisplayClass31_7 <>8__8;

		// Token: 0x04001933 RID: 6451
		[Token(Token = "0x4001933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ModLoader.<>c__DisplayClass31_8 <>8__9;

		// Token: 0x04001934 RID: 6452
		[Token(Token = "0x4001934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ModLoader.<>c__DisplayClass31_9 <>8__10;

		// Token: 0x04001935 RID: 6453
		[Token(Token = "0x4001935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ModLoader.<>c__DisplayClass31_10 <>8__11;

		// Token: 0x04001936 RID: 6454
		[Token(Token = "0x4001936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ModLoader.<>c__DisplayClass31_11 <>8__12;

		// Token: 0x04001937 RID: 6455
		[Token(Token = "0x4001937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ModLoader.<>c__DisplayClass31_12 <>8__13;

		// Token: 0x04001938 RID: 6456
		[Token(Token = "0x4001938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TaskAwaiter <>u__1;
	}
}
