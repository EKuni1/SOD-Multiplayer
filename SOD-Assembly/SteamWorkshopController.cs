using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

// Token: 0x0200050E RID: 1294
[Token(Token = "0x200050E")]
public class SteamWorkshopController : MonoBehaviour
{
	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000D6")]
	public static SteamWorkshopController Instance
	{
		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0x9C6C90", Offset = "0x9C5C90", VA = "0x1809C6C90")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001BC9")]
		[Address(RVA = "0x9C6CF0", Offset = "0x9C5CF0", VA = "0x1809C6CF0")]
		private set
		{
		}
	}

	// Token: 0x06001BCA RID: 7114 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BCA")]
	[Address(RVA = "0x9C6DB0", Offset = "0x9C5DB0", VA = "0x1809C6DB0")]
	public List<string> GetListOfSubscribedItemsPaths()
	{
		return null;
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BCB")]
	[Address(RVA = "0x9C7410", Offset = "0x9C6410", VA = "0x1809C7410")]
	public void FindSnapshot()
	{
	}

	// Token: 0x06001BCC RID: 7116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BCC")]
	[Address(RVA = "0x9C7640", Offset = "0x9C6640", VA = "0x1809C7640")]
	public void TakeModSnapshot()
	{
	}

	// Token: 0x06001BCD RID: 7117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BCD")]
	[Address(RVA = "0x9C7750", Offset = "0x9C6750", VA = "0x1809C7750")]
	public void QueryApiTesting()
	{
	}

	// Token: 0x06001BCE RID: 7118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BCE")]
	[Address(RVA = "0x9C7A80", Offset = "0x9C6A80", VA = "0x1809C7A80")]
	private void OnAvailableItemsComplete(SteamUGCQueryCompleted_t p_callback, bool failure)
	{
	}

	// Token: 0x06001BCF RID: 7119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BCF")]
	public void Execute<T>(SteamAPICall_t p_steamCall, CallResult<T>.APIDispatchDelegate p_onCompleted)
	{
	}

	// Token: 0x06001BD0 RID: 7120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD0")]
	[Address(RVA = "0x9C7C60", Offset = "0x9C6C60", VA = "0x1809C7C60")]
	public void Unsubscribe(PublishedFileId_t pubFileId)
	{
	}

	// Token: 0x06001BD1 RID: 7121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD1")]
	[Address(RVA = "0x9C7CF0", Offset = "0x9C6CF0", VA = "0x1809C7CF0")]
	public void TestUpload()
	{
	}

	// Token: 0x06001BD2 RID: 7122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD2")]
	[Address(RVA = "0x9C7E60", Offset = "0x9C6E60", VA = "0x1809C7E60")]
	public void UploadContent(string itemTitle, string itemDescription, string contentFolderPath, string[] tags, string previewImagePath)
	{
	}

	// Token: 0x06001BD3 RID: 7123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD3")]
	[Address(RVA = "0x9C81A0", Offset = "0x9C71A0", VA = "0x1809C81A0")]
	private void Start()
	{
	}

	// Token: 0x06001BD4 RID: 7124 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BD4")]
	[Address(RVA = "0x9C84E0", Offset = "0x9C74E0", VA = "0x1809C84E0")]
	private List<DirectoryInfo> LoadLocalDDSMods()
	{
		return null;
	}

	// Token: 0x06001BD5 RID: 7125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD5")]
	[Address(RVA = "0x9C8750", Offset = "0x9C7750", VA = "0x1809C8750")]
	private void CreateItem()
	{
	}

	// Token: 0x06001BD6 RID: 7126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD6")]
	[Address(RVA = "0x9C8840", Offset = "0x9C7840", VA = "0x1809C8840")]
	private void CreateItemResult(CreateItemResult_t param, bool bIOFailure)
	{
	}

	// Token: 0x06001BD7 RID: 7127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD7")]
	[Address(RVA = "0x9C88C0", Offset = "0x9C78C0", VA = "0x1809C88C0")]
	private void UpdateItem()
	{
	}

	// Token: 0x06001BD8 RID: 7128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD8")]
	[Address(RVA = "0x9C8B00", Offset = "0x9C7B00", VA = "0x1809C8B00")]
	private void DeleteItem(PublishedFileId_t publishedFileIdT)
	{
	}

	// Token: 0x06001BD9 RID: 7129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BD9")]
	[Address(RVA = "0x9C8B90", Offset = "0x9C7B90", VA = "0x1809C8B90")]
	private void UpdateItemResult(SubmitItemUpdateResult_t param, bool bIOFailure)
	{
	}

	// Token: 0x06001BDA RID: 7130 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BDA")]
	[Address(RVA = "0x9C8BF0", Offset = "0x9C7BF0", VA = "0x1809C8BF0")]
	private List<DirectoryInfo> InitializeAndFetchLocalWorkshopDirectories()
	{
		return null;
	}

	// Token: 0x06001BDB RID: 7131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BDB")]
	[Address(RVA = "0x9C8E00", Offset = "0x9C7E00", VA = "0x1809C8E00")]
	public SteamWorkshopController()
	{
	}

	// Token: 0x04002481 RID: 9345
	[Token(Token = "0x4002481")]
	[FieldOffset(Offset = "0x18")]
	private SteamWorkshopItem currentSteamWorkshopItem;

	// Token: 0x04002482 RID: 9346
	[Token(Token = "0x4002482")]
	[FieldOffset(Offset = "0x58")]
	private PublishedFileId_t publishedFileID;

	// Token: 0x04002483 RID: 9347
	[Token(Token = "0x4002483")]
	[FieldOffset(Offset = "0x0")]
	private static UGCUpdateHandle_t curUpdateHandle;

	// Token: 0x04002484 RID: 9348
	[Token(Token = "0x4002484")]
	[FieldOffset(Offset = "0x8")]
	private static SteamWorkshopController <Instance>k__BackingField;

	// Token: 0x04002485 RID: 9349
	[Token(Token = "0x4002485")]
	[FieldOffset(Offset = "0x10")]
	private static string LocalDdsConfigPath;

	// Token: 0x04002486 RID: 9350
	[Token(Token = "0x4002486")]
	[FieldOffset(Offset = "0x60")]
	public List<SteamMod> subscribedMods;

	// Token: 0x04002487 RID: 9351
	[Token(Token = "0x4002487")]
	[FieldOffset(Offset = "0x68")]
	public ModSnapshot modSnapshot;

	// Token: 0x04002488 RID: 9352
	[Token(Token = "0x4002488")]
	[FieldOffset(Offset = "0x70")]
	public GameObject steamModeElementPrefab;

	// Token: 0x04002489 RID: 9353
	[Token(Token = "0x4002489")]
	[FieldOffset(Offset = "0x78")]
	public bool modConfigChanged;

	// Token: 0x0400248A RID: 9354
	[Token(Token = "0x400248A")]
	[FieldOffset(Offset = "0x80")]
	public List<WorkshopModEntryController> spawnedModElements;

	// Token: 0x0400248B RID: 9355
	[Token(Token = "0x400248B")]
	[FieldOffset(Offset = "0x88")]
	public ButtonController applyButton;

	// Token: 0x0400248C RID: 9356
	[Token(Token = "0x400248C")]
	[FieldOffset(Offset = "0x90")]
	public RectTransform modContentRect;

	// Token: 0x0400248D RID: 9357
	[Token(Token = "0x400248D")]
	[FieldOffset(Offset = "0x98")]
	private string itemContent;

	// Token: 0x0400248E RID: 9358
	[Token(Token = "0x400248E")]
	[FieldOffset(Offset = "0xA0")]
	public bool fetchedContent;

	// Token: 0x0400248F RID: 9359
	[Token(Token = "0x400248F")]
	[FieldOffset(Offset = "0xA8")]
	private UGCQueryHandle_t _ugcHandleT;

	// Token: 0x0200050F RID: 1295
	[Token(Token = "0x200050F")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001BDE RID: 7134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BDE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		[Token(Token = "0x6001BDF")]
		[Address(RVA = "0x9C9170", Offset = "0x9C8170", VA = "0x1809C9170")]
		internal int <GetListOfSubscribedItemsPaths>b__18_0(SteamMod x)
		{
			return 0;
		}

		// Token: 0x04002490 RID: 9360
		[Token(Token = "0x4002490")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SteamWorkshopController.<>c <>9;

		// Token: 0x04002491 RID: 9361
		[Token(Token = "0x4002491")]
		[FieldOffset(Offset = "0x8")]
		public static Func<SteamMod, int> <>9__18_0;
	}
}
