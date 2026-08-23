using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using ModIO;
using Steamworks;
using UnityEngine;

// Token: 0x02000387 RID: 903
[Token(Token = "0x2000387")]
public class ModController : MonoBehaviour
{
	// Token: 0x170000AD RID: 173
	// (get) Token: 0x0600143C RID: 5180 RVA: 0x00009A38 File Offset: 0x00007C38
	[Token(Token = "0x170000AD")]
	private bool hasSpawned
	{
		[Token(Token = "0x600143C")]
		[Address(RVA = "0x7B1A50", Offset = "0x7B0A50", VA = "0x1807B1A50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x0600143D RID: 5181 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000AE")]
	public static ModController Instance
	{
		[Token(Token = "0x600143D")]
		[Address(RVA = "0x7B1B50", Offset = "0x7B0B50", VA = "0x1807B1B50")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600143E RID: 5182 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600143E")]
	[Address(RVA = "0x7B1B90", Offset = "0x7B0B90", VA = "0x1807B1B90")]
	private void Awake()
	{
	}

	// Token: 0x0600143F RID: 5183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600143F")]
	[Address(RVA = "0x7B2010", Offset = "0x7B1010", VA = "0x1807B2010")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001440 RID: 5184 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001440")]
	[Address(RVA = "0x7B2220", Offset = "0x7B1220", VA = "0x1807B2220")]
	private void Start()
	{
	}

	// Token: 0x06001441 RID: 5185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001441")]
	[Address(RVA = "0x7B2410", Offset = "0x7B1410", VA = "0x1807B2410")]
	public void OpenModBrowser()
	{
	}

	// Token: 0x06001442 RID: 5186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001442")]
	[Address(RVA = "0x7B2690", Offset = "0x7B1690", VA = "0x1807B2690")]
	public void OpenSteamWorkshop()
	{
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001443")]
	[Address(RVA = "0x7B2710", Offset = "0x7B1710", VA = "0x1807B2710")]
	public void OnBrowserClose()
	{
	}

	// Token: 0x06001444 RID: 5188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001444")]
	[Address(RVA = "0x7B2760", Offset = "0x7B1760", VA = "0x1807B2760")]
	public void UpdateModEntries()
	{
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001445")]
	[Address(RVA = "0x7B2CD0", Offset = "0x7B1CD0", VA = "0x1807B2CD0")]
	private IEnumerator WaitForGetModsComplete()
	{
		return null;
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001446")]
	[Address(RVA = "0x7B2D70", Offset = "0x7B1D70", VA = "0x1807B2D70")]
	public void SetModConfigChanged(bool val)
	{
	}

	// Token: 0x06001447 RID: 5191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001447")]
	[Address(RVA = "0x7B2DB0", Offset = "0x7B1DB0", VA = "0x1807B2DB0")]
	public void OnApplyRestartButton()
	{
	}

	// Token: 0x06001448 RID: 5192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001448")]
	[Address(RVA = "0x7B3050", Offset = "0x7B2050", VA = "0x1807B3050")]
	public void OnRestartConfirm()
	{
	}

	// Token: 0x06001449 RID: 5193 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001449")]
	[Address(RVA = "0x7B3630", Offset = "0x7B2630", VA = "0x1807B3630")]
	public void OnRestartCancel()
	{
	}

	// Token: 0x0600144A RID: 5194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600144A")]
	[Address(RVA = "0x7B37C0", Offset = "0x7B27C0", VA = "0x1807B37C0")]
	public void UploadToSteamWorkshop(ModSettingsData modSettingsData)
	{
	}

	// Token: 0x0600144B RID: 5195 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600144B")]
	[Address(RVA = "0x7B3900", Offset = "0x7B2900", VA = "0x1807B3900")]
	private IEnumerator UploadToWorkshop(ModSettingsData modSettingsData)
	{
		return null;
	}

	// Token: 0x0600144C RID: 5196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600144C")]
	[Address(RVA = "0x7B3A10", Offset = "0x7B2A10", VA = "0x1807B3A10")]
	private void CreateWorkshopItem()
	{
	}

	// Token: 0x0600144D RID: 5197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600144D")]
	[Address(RVA = "0x7B3B10", Offset = "0x7B2B10", VA = "0x1807B3B10")]
	private void HandleCreateItemResult(CreateItemResult_t result, bool bIOFailure)
	{
	}

	// Token: 0x0600144E RID: 5198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600144E")]
	[Address(RVA = "0x7B4100", Offset = "0x7B3100", VA = "0x1807B4100")]
	public void UpdateWorkshopItem(PublishedFileId_t itemId, ModSettingsData modSettings)
	{
	}

	// Token: 0x0600144F RID: 5199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600144F")]
	[Address(RVA = "0x7B44A0", Offset = "0x7B34A0", VA = "0x1807B44A0")]
	private void HandleItemUpdateResult(SubmitItemUpdateResult_t result, bool bIOFailure)
	{
	}

	// Token: 0x06001450 RID: 5200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001450")]
	[Address(RVA = "0x7B48D0", Offset = "0x7B38D0", VA = "0x1807B48D0")]
	public void OnInputModName()
	{
	}

	// Token: 0x06001451 RID: 5201 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001451")]
	[Address(RVA = "0x7B4C00", Offset = "0x7B3C00", VA = "0x1807B4C00")]
	public void OnInputModCreator()
	{
	}

	// Token: 0x06001452 RID: 5202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001452")]
	[Address(RVA = "0x7B4F30", Offset = "0x7B3F30", VA = "0x1807B4F30")]
	public void OnInputModDescription()
	{
	}

	// Token: 0x06001453 RID: 5203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001453")]
	[Address(RVA = "0x7B5260", Offset = "0x7B4260", VA = "0x1807B5260")]
	public void ValidationCancel()
	{
	}

	// Token: 0x06001454 RID: 5204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001454")]
	[Address(RVA = "0x7B54E0", Offset = "0x7B44E0", VA = "0x1807B54E0")]
	public void OnOpenWorkshopAgreement()
	{
	}

	// Token: 0x06001455 RID: 5205 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001455")]
	[Address(RVA = "0x7B5690", Offset = "0x7B4690", VA = "0x1807B5690")]
	public void OnCancelWorkshopAgreement()
	{
	}

	// Token: 0x06001456 RID: 5206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001456")]
	[Address(RVA = "0x7B57F0", Offset = "0x7B47F0", VA = "0x1807B57F0")]
	public void OpenModDocumentation()
	{
	}

	// Token: 0x06001457 RID: 5207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001457")]
	[Address(RVA = "0x7B5870", Offset = "0x7B4870", VA = "0x1807B5870")]
	public ModController()
	{
	}

	// Token: 0x040018BC RID: 6332
	[Token(Token = "0x40018BC")]
	[FieldOffset(Offset = "0x18")]
	public GameObject browserPrefab;

	// Token: 0x040018BD RID: 6333
	[Token(Token = "0x40018BD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject modElementPrefab;

	// Token: 0x040018BE RID: 6334
	[Token(Token = "0x40018BE")]
	[FieldOffset(Offset = "0x28")]
	public GameObject modLoaderPrefab;

	// Token: 0x040018BF RID: 6335
	[Token(Token = "0x40018BF")]
	[FieldOffset(Offset = "0x30")]
	public bool allowModIO;

	// Token: 0x040018C0 RID: 6336
	[Token(Token = "0x40018C0")]
	[FieldOffset(Offset = "0x31")]
	public bool allowSteamWorkshop;

	// Token: 0x040018C1 RID: 6337
	[Token(Token = "0x40018C1")]
	[FieldOffset(Offset = "0x32")]
	public bool modConfigChanged;

	// Token: 0x040018C2 RID: 6338
	[Token(Token = "0x40018C2")]
	[FieldOffset(Offset = "0x33")]
	public bool waitingForModUpdate;

	// Token: 0x040018C3 RID: 6339
	[Token(Token = "0x40018C3")]
	[FieldOffset(Offset = "0x34")]
	public bool uploadingToWorkshop;

	// Token: 0x040018C4 RID: 6340
	[Token(Token = "0x40018C4")]
	[FieldOffset(Offset = "0x38")]
	public ModSettingsData uploadingModSettings;

	// Token: 0x040018C5 RID: 6341
	[Token(Token = "0x40018C5")]
	[FieldOffset(Offset = "0x40")]
	private string workshopAgreementURL;

	// Token: 0x040018C6 RID: 6342
	[Token(Token = "0x40018C6")]
	[FieldOffset(Offset = "0x48")]
	private bool createdNewWorkshopItem;

	// Token: 0x040018C7 RID: 6343
	[Token(Token = "0x40018C7")]
	[FieldOffset(Offset = "0x50")]
	private PublishedFileId_t createdItemHandle;

	// Token: 0x040018C8 RID: 6344
	[Token(Token = "0x40018C8")]
	[FieldOffset(Offset = "0x58")]
	private bool workshopUpdateSuccess;

	// Token: 0x040018C9 RID: 6345
	[Token(Token = "0x40018C9")]
	[FieldOffset(Offset = "0x60")]
	private string finalModUploadURL;

	// Token: 0x040018CA RID: 6346
	[Token(Token = "0x40018CA")]
	[FieldOffset(Offset = "0x68")]
	public RectTransform modContentRect;

	// Token: 0x040018CB RID: 6347
	[Token(Token = "0x40018CB")]
	[FieldOffset(Offset = "0x70")]
	public GameObject spawnedBrowser;

	// Token: 0x040018CC RID: 6348
	[Token(Token = "0x40018CC")]
	[FieldOffset(Offset = "0x78")]
	public List<ModEntryController> spawnedModElements;

	// Token: 0x040018CD RID: 6349
	[Token(Token = "0x40018CD")]
	[FieldOffset(Offset = "0x80")]
	public ButtonController applyButton;

	// Token: 0x040018CE RID: 6350
	[Token(Token = "0x40018CE")]
	[FieldOffset(Offset = "0x88")]
	public ButtonController workshopButton;

	// Token: 0x040018CF RID: 6351
	[Token(Token = "0x40018CF")]
	[FieldOffset(Offset = "0x0")]
	private static ModController _instance;

	// Token: 0x02000388 RID: 904
	[Token(Token = "0x2000388")]
	[Serializable]
	public class ModIconSetup
	{
		// Token: 0x06001458 RID: 5208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ModIconSetup()
		{
		}

		// Token: 0x040018D0 RID: 6352
		[Token(Token = "0x40018D0")]
		[FieldOffset(Offset = "0x10")]
		public SubscribedModStatus state;

		// Token: 0x040018D1 RID: 6353
		[Token(Token = "0x40018D1")]
		[FieldOffset(Offset = "0x18")]
		public Sprite spriteEnabled;

		// Token: 0x040018D2 RID: 6354
		[Token(Token = "0x40018D2")]
		[FieldOffset(Offset = "0x20")]
		public Sprite spriteDisabled;
	}

	// Token: 0x02000389 RID: 905
	[Token(Token = "0x2000389")]
	private sealed class <WaitForGetModsComplete>d__32 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06001459 RID: 5209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001459")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <WaitForGetModsComplete>d__32(int <>1__state)
		{
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00009A50 File Offset: 0x00007C50
		[Token(Token = "0x600145B")]
		[Address(RVA = "0x7B5970", Offset = "0x7B4970", VA = "0x1807B5970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000AF")]
		private object Current
		{
			[Token(Token = "0x600145C")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145D")]
		[Address(RVA = "0x7B5EA0", Offset = "0x7B4EA0", VA = "0x1807B5EA0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B0")]
		private object Current
		{
			[Token(Token = "0x600145E")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040018D3 RID: 6355
		[Token(Token = "0x40018D3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040018D4 RID: 6356
		[Token(Token = "0x40018D4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040018D5 RID: 6357
		[Token(Token = "0x40018D5")]
		[FieldOffset(Offset = "0x20")]
		public ModController <>4__this;
	}

	// Token: 0x0200038A RID: 906
	[Token(Token = "0x200038A")]
	private sealed class <UploadToWorkshop>d__38 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600145F RID: 5215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145F")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <UploadToWorkshop>d__38(int <>1__state)
		{
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001460")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00009A68 File Offset: 0x00007C68
		[Token(Token = "0x6001461")]
		[Address(RVA = "0x7B5EF0", Offset = "0x7B4EF0", VA = "0x1807B5EF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B1")]
		private object Current
		{
			[Token(Token = "0x6001462")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001463")]
		[Address(RVA = "0x7B6A70", Offset = "0x7B5A70", VA = "0x1807B6A70", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B2")]
		private object Current
		{
			[Token(Token = "0x6001464")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040018D6 RID: 6358
		[Token(Token = "0x40018D6")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040018D7 RID: 6359
		[Token(Token = "0x40018D7")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040018D8 RID: 6360
		[Token(Token = "0x40018D8")]
		[FieldOffset(Offset = "0x20")]
		public ModController <>4__this;

		// Token: 0x040018D9 RID: 6361
		[Token(Token = "0x40018D9")]
		[FieldOffset(Offset = "0x28")]
		public ModSettingsData modSettingsData;

		// Token: 0x040018DA RID: 6362
		[Token(Token = "0x40018DA")]
		[FieldOffset(Offset = "0x30")]
		private bool <configValidated>5__2;

		// Token: 0x040018DB RID: 6363
		[Token(Token = "0x40018DB")]
		[FieldOffset(Offset = "0x31")]
		private bool <createdItemRequest>5__3;

		// Token: 0x040018DC RID: 6364
		[Token(Token = "0x40018DC")]
		[FieldOffset(Offset = "0x32")]
		private bool <updateItemRequest>5__4;
	}
}
