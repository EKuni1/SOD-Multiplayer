using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000699 RID: 1689
[Token(Token = "0x2000699")]
public class UpgradesController : MonoBehaviour
{
	// Token: 0x17000132 RID: 306
	// (get) Token: 0x0600257F RID: 9599 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000132")]
	public static UpgradesController Instance
	{
		[Token(Token = "0x600257F")]
		[Address(RVA = "0xBC7160", Offset = "0xBC6160", VA = "0x180BC7160")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002580 RID: 9600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002580")]
	[Address(RVA = "0xBC71A0", Offset = "0xBC61A0", VA = "0x180BC71A0")]
	private void Awake()
	{
	}

	// Token: 0x06002581 RID: 9601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002581")]
	[Address(RVA = "0xBC74F0", Offset = "0xBC64F0", VA = "0x180BC74F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002582 RID: 9602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002582")]
	[Address(RVA = "0xBC7700", Offset = "0xBC6700", VA = "0x180BC7700")]
	public void SetupQuickRef()
	{
	}

	// Token: 0x06002583 RID: 9603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002583")]
	[Address(RVA = "0xBC7900", Offset = "0xBC6900", VA = "0x180BC7900")]
	public void Setup()
	{
	}

	// Token: 0x06002584 RID: 9604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002584")]
	[Address(RVA = "0xBC84B0", Offset = "0xBC74B0", VA = "0x180BC84B0")]
	public void UpdateUpgrades()
	{
	}

	// Token: 0x06002585 RID: 9605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002585")]
	[Address(RVA = "0xBC95E0", Offset = "0xBC85E0", VA = "0x180BC95E0")]
	public void InstallSyncDisk(UpgradesController.Upgrades application, int option)
	{
	}

	// Token: 0x06002586 RID: 9606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002586")]
	[Address(RVA = "0xBCA0C0", Offset = "0xBC90C0", VA = "0x180BCA0C0")]
	public void UninstallSyncDisk(UpgradesController.Upgrades removal)
	{
	}

	// Token: 0x06002587 RID: 9607 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002587")]
	[Address(RVA = "0xBCA510", Offset = "0xBC9510", VA = "0x180BCA510")]
	public void UpgradeSyncDisk(UpgradesController.Upgrades upgradeThis)
	{
	}

	// Token: 0x06002588 RID: 9608 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002588")]
	[Address(RVA = "0xBCAC60", Offset = "0xBC9C60", VA = "0x180BCAC60")]
	public void UpdateInstallButton(bool newInstallAllowed)
	{
	}

	// Token: 0x06002589 RID: 9609 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002589")]
	[Address(RVA = "0xBCADD0", Offset = "0xBC9DD0", VA = "0x180BCADD0")]
	public void UpdateInstalledAvailableText()
	{
	}

	// Token: 0x0600258A RID: 9610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600258A")]
	[Address(RVA = "0xBCB6B0", Offset = "0xBCA6B0", VA = "0x180BCB6B0")]
	public void OpenUpgrades(bool playSound = true)
	{
	}

	// Token: 0x0600258B RID: 9611 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600258B")]
	[Address(RVA = "0xBCBC90", Offset = "0xBCAC90", VA = "0x180BCBC90")]
	private IEnumerator Open()
	{
		return null;
	}

	// Token: 0x0600258C RID: 9612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600258C")]
	[Address(RVA = "0xBCBD30", Offset = "0xBCAD30", VA = "0x180BCBD30")]
	public void CloseUpgrades(bool playSound = true)
	{
	}

	// Token: 0x0600258D RID: 9613 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600258D")]
	[Address(RVA = "0xBCCE90", Offset = "0xBCBE90", VA = "0x180BCCE90")]
	private IEnumerator Close()
	{
		return null;
	}

	// Token: 0x0600258E RID: 9614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600258E")]
	[Address(RVA = "0xBCCF30", Offset = "0xBCBF30", VA = "0x180BCCF30")]
	public void UpdateActivation()
	{
	}

	// Token: 0x0600258F RID: 9615 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600258F")]
	[Address(RVA = "0xBCD410", Offset = "0xBCC410", VA = "0x180BCD410")]
	public void UpdateNavigation()
	{
	}

	// Token: 0x06002590 RID: 9616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002590")]
	[Address(RVA = "0xBCD5B0", Offset = "0xBCC5B0", VA = "0x180BCD5B0")]
	public UpgradesController()
	{
	}

	// Token: 0x04002FD8 RID: 12248
	[Token(Token = "0x4002FD8")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform mainContentRect;

	// Token: 0x04002FD9 RID: 12249
	[Token(Token = "0x4002FD9")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform mainViewport;

	// Token: 0x04002FDA RID: 12250
	[Token(Token = "0x4002FDA")]
	[FieldOffset(Offset = "0x28")]
	public CustomScrollRect mainScrollRect;

	// Token: 0x04002FDB RID: 12251
	[Token(Token = "0x4002FDB")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform listContentRect;

	// Token: 0x04002FDC RID: 12252
	[Token(Token = "0x4002FDC")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform listRect;

	// Token: 0x04002FDD RID: 12253
	[Token(Token = "0x4002FDD")]
	[FieldOffset(Offset = "0x40")]
	public ButtonController closeButton;

	// Token: 0x04002FDE RID: 12254
	[Token(Token = "0x4002FDE")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI installedDisksText;

	// Token: 0x04002FDF RID: 12255
	[Token(Token = "0x4002FDF")]
	[FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI syncClinicPromptText;

	// Token: 0x04002FE0 RID: 12256
	[Token(Token = "0x4002FE0")]
	[FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI configText;

	// Token: 0x04002FE1 RID: 12257
	[Token(Token = "0x4002FE1")]
	[FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI upgradesText;

	// Token: 0x04002FE2 RID: 12258
	[Token(Token = "0x4002FE2")]
	[FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI sideEffectsText;

	// Token: 0x04002FE3 RID: 12259
	[Token(Token = "0x4002FE3")]
	[FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI descriptionText;

	// Token: 0x04002FE4 RID: 12260
	[Token(Token = "0x4002FE4")]
	[FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI optionsText;

	// Token: 0x04002FE5 RID: 12261
	[Token(Token = "0x4002FE5")]
	[FieldOffset(Offset = "0x80")]
	public GameObject syncDiskElementPrefab;

	// Token: 0x04002FE6 RID: 12262
	[Token(Token = "0x4002FE6")]
	[FieldOffset(Offset = "0x88")]
	[NonSerialized]
	public float openProgress;

	// Token: 0x04002FE7 RID: 12263
	[Token(Token = "0x4002FE7")]
	[FieldOffset(Offset = "0x8C")]
	public bool isOpen;

	// Token: 0x04002FE8 RID: 12264
	[Token(Token = "0x4002FE8")]
	[FieldOffset(Offset = "0x8D")]
	public bool installedAllowed;

	// Token: 0x04002FE9 RID: 12265
	[Token(Token = "0x4002FE9")]
	[FieldOffset(Offset = "0x90")]
	public int notInstalled;

	// Token: 0x04002FEA RID: 12266
	[Token(Token = "0x4002FEA")]
	[FieldOffset(Offset = "0x94")]
	public bool playSyncDiskInstallAudio;

	// Token: 0x04002FEB RID: 12267
	[Token(Token = "0x4002FEB")]
	[FieldOffset(Offset = "0x98")]
	public List<UpgradesController.Upgrades> upgrades;

	// Token: 0x04002FEC RID: 12268
	[Token(Token = "0x4002FEC")]
	[FieldOffset(Offset = "0xA0")]
	public List<SyncDiskElementController> spawnedDisks;

	// Token: 0x04002FED RID: 12269
	[Token(Token = "0x4002FED")]
	[FieldOffset(Offset = "0xA8")]
	public Dictionary<string, SyncDiskPreset> upgradesQuickRef;

	// Token: 0x04002FEE RID: 12270
	[Token(Token = "0x4002FEE")]
	[FieldOffset(Offset = "0xB0")]
	public List<Interactable> upgradeVials;

	// Token: 0x04002FEF RID: 12271
	[Token(Token = "0x4002FEF")]
	[FieldOffset(Offset = "0x0")]
	private static UpgradesController _instance;

	// Token: 0x0200069A RID: 1690
	[Token(Token = "0x200069A")]
	public enum SyncDiskState
	{
		// Token: 0x04002FF1 RID: 12273
		[Token(Token = "0x4002FF1")]
		notInstalled,
		// Token: 0x04002FF2 RID: 12274
		[Token(Token = "0x4002FF2")]
		option1,
		// Token: 0x04002FF3 RID: 12275
		[Token(Token = "0x4002FF3")]
		option2,
		// Token: 0x04002FF4 RID: 12276
		[Token(Token = "0x4002FF4")]
		option3
	}

	// Token: 0x0200069B RID: 1691
	[Token(Token = "0x200069B")]
	[Serializable]
	public class Upgrades
	{
		// Token: 0x06002591 RID: 9617 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002591")]
		[Address(RVA = "0xBCD8D0", Offset = "0xBCC8D0", VA = "0x180BCD8D0")]
		public SyncDiskPreset GetPreset()
		{
			return null;
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002592")]
		[Address(RVA = "0xBCD960", Offset = "0xBCC960", VA = "0x180BCD960")]
		public Interactable GetObject()
		{
			return null;
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002593")]
		[Address(RVA = "0xBCDA00", Offset = "0xBCCA00", VA = "0x180BCDA00")]
		public List<UpgradeEffectController.AppliedEffect> GetAllEffects()
		{
			return null;
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002594")]
		[Address(RVA = "0xBCDDF0", Offset = "0xBCCDF0", VA = "0x180BCDDF0")]
		public List<UpgradeEffectController.AppliedEffect> GetMainEffects()
		{
			return null;
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002595")]
		[Address(RVA = "0xBCE330", Offset = "0xBCD330", VA = "0x180BCE330")]
		public List<UpgradeEffectController.AppliedEffect> GetUpgradeEffects()
		{
			return null;
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002596")]
		[Address(RVA = "0xBCFB10", Offset = "0xBCEB10", VA = "0x180BCFB10")]
		public List<UpgradeEffectController.AppliedEffect> GetSideEffects()
		{
			return null;
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		[Token(Token = "0x6002597")]
		[Address(RVA = "0xBCFF50", Offset = "0xBCEF50", VA = "0x180BCFF50")]
		public float GetEffectiveness()
		{
			return 0f;
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		[Token(Token = "0x6002598")]
		[Address(RVA = "0xBD0460", Offset = "0xBCF460", VA = "0x180BD0460")]
		public float GetSideEffectValue()
		{
			return 0f;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002599")]
		[Address(RVA = "0xBD0630", Offset = "0xBCF630", VA = "0x180BD0630")]
		public Upgrades()
		{
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x0000EC10 File Offset: 0x0000CE10
		[Token(Token = "0x600259A")]
		[Address(RVA = "0xBD0640", Offset = "0xBCF640", VA = "0x180BD0640")]
		private bool <GetUpgradeEffects>b__11_0(UpgradeEffectController.AppliedEffect item)
		{
			return default(bool);
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x0000EC28 File Offset: 0x0000CE28
		[Token(Token = "0x600259B")]
		[Address(RVA = "0xBD0670", Offset = "0xBCF670", VA = "0x180BD0670")]
		private bool <GetUpgradeEffects>b__11_1(UpgradeEffectController.AppliedEffect item)
		{
			return default(bool);
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x0000EC40 File Offset: 0x0000CE40
		[Token(Token = "0x600259C")]
		[Address(RVA = "0xBD06A0", Offset = "0xBCF6A0", VA = "0x180BD06A0")]
		private bool <GetUpgradeEffects>b__11_2(UpgradeEffectController.AppliedEffect item)
		{
			return default(bool);
		}

		// Token: 0x04002FF5 RID: 12277
		[Token(Token = "0x4002FF5")]
		[FieldOffset(Offset = "0x10")]
		public string upgrade;

		// Token: 0x04002FF6 RID: 12278
		[Token(Token = "0x4002FF6")]
		[FieldOffset(Offset = "0x18")]
		public UpgradesController.SyncDiskState state;

		// Token: 0x04002FF7 RID: 12279
		[Token(Token = "0x4002FF7")]
		[FieldOffset(Offset = "0x1C")]
		public int list;

		// Token: 0x04002FF8 RID: 12280
		[Token(Token = "0x4002FF8")]
		[FieldOffset(Offset = "0x20")]
		public int level;

		// Token: 0x04002FF9 RID: 12281
		[Token(Token = "0x4002FF9")]
		[FieldOffset(Offset = "0x24")]
		public int objId;

		// Token: 0x04002FFA RID: 12282
		[Token(Token = "0x4002FFA")]
		[FieldOffset(Offset = "0x28")]
		public int uninstallCost;

		// Token: 0x04002FFB RID: 12283
		[Token(Token = "0x4002FFB")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public SyncDiskPreset preset;

		// Token: 0x0200069C RID: 1692
		[Token(Token = "0x200069C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600259E RID: 9630 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600259E")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c()
			{
			}

			// Token: 0x0600259F RID: 9631 RVA: 0x0000EC58 File Offset: 0x0000CE58
			[Token(Token = "0x600259F")]
			[Address(RVA = "0xBC6460", Offset = "0xBC5460", VA = "0x180BC6460")]
			internal bool <GetSideEffectValue>b__14_0(UpgradeEffectController.AppliedEffect item)
			{
				return default(bool);
			}

			// Token: 0x04002FFC RID: 12284
			[Token(Token = "0x4002FFC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UpgradesController.Upgrades.<>c <>9;

			// Token: 0x04002FFD RID: 12285
			[Token(Token = "0x4002FFD")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<UpgradeEffectController.AppliedEffect> <>9__14_0;
		}
	}

	// Token: 0x0200069D RID: 1693
	[Token(Token = "0x200069D")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060025A1 RID: 9633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x0000EC70 File Offset: 0x0000CE70
		[Token(Token = "0x60025A2")]
		[Address(RVA = "0xBD0830", Offset = "0xBCF830", VA = "0x180BD0830")]
		internal int <UpdateUpgrades>b__32_0(SyncDiskElementController p2, SyncDiskElementController p1)
		{
			return 0;
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x0000EC88 File Offset: 0x0000CE88
		[Token(Token = "0x60025A3")]
		[Address(RVA = "0xBD08B0", Offset = "0xBCF8B0", VA = "0x180BD08B0")]
		internal bool <InstallSyncDisk>b__33_1(SyncDiskPreset item)
		{
			return default(bool);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		[Token(Token = "0x60025A4")]
		[Address(RVA = "0xBD08D0", Offset = "0xBCF8D0", VA = "0x180BD08D0")]
		internal bool <UpdateInstalledAvailableText>b__37_0(UpgradesController.Upgrades item)
		{
			return default(bool);
		}

		// Token: 0x04002FFE RID: 12286
		[Token(Token = "0x4002FFE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UpgradesController.<>c <>9;

		// Token: 0x04002FFF RID: 12287
		[Token(Token = "0x4002FFF")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<SyncDiskElementController> <>9__32_0;

		// Token: 0x04003000 RID: 12288
		[Token(Token = "0x4003000")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<SyncDiskPreset> <>9__33_1;

		// Token: 0x04003001 RID: 12289
		[Token(Token = "0x4003001")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<UpgradesController.Upgrades> <>9__37_0;
	}

	// Token: 0x0200069E RID: 1694
	[Token(Token = "0x200069E")]
	private sealed class <>c__DisplayClass33_0
	{
		// Token: 0x060025A5 RID: 9637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass33_0()
		{
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		[Token(Token = "0x60025A6")]
		[Address(RVA = "0xB7E910", Offset = "0xB7D910", VA = "0x180B7E910")]
		internal bool <InstallSyncDisk>b__0(UpgradesController.Upgrades item)
		{
			return default(bool);
		}

		// Token: 0x04003002 RID: 12290
		[Token(Token = "0x4003002")]
		[FieldOffset(Offset = "0x10")]
		public UpgradesController.Upgrades application;
	}

	// Token: 0x0200069F RID: 1695
	[Token(Token = "0x200069F")]
	private sealed class <Open>d__39 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060025A7 RID: 9639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A7")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Open>d__39(int <>1__state)
		{
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025A8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		[Token(Token = "0x60025A9")]
		[Address(RVA = "0xBD08F0", Offset = "0xBCF8F0", VA = "0x180BD08F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000133")]
		private object Current
		{
			[Token(Token = "0x60025AA")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AB")]
		[Address(RVA = "0xBD0AE0", Offset = "0xBCFAE0", VA = "0x180BD0AE0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000134")]
		private object Current
		{
			[Token(Token = "0x60025AC")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04003003 RID: 12291
		[Token(Token = "0x4003003")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04003004 RID: 12292
		[Token(Token = "0x4003004")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04003005 RID: 12293
		[Token(Token = "0x4003005")]
		[FieldOffset(Offset = "0x20")]
		public UpgradesController <>4__this;
	}

	// Token: 0x020006A0 RID: 1696
	[Token(Token = "0x20006A0")]
	private sealed class <Close>d__41 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060025AD RID: 9645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AD")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <Close>d__41(int <>1__state)
		{
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025AE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x0000ECE8 File Offset: 0x0000CEE8
		[Token(Token = "0x60025AF")]
		[Address(RVA = "0xBD0B30", Offset = "0xBCFB30", VA = "0x180BD0B30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000135")]
		private object Current
		{
			[Token(Token = "0x60025B0")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025B1")]
		[Address(RVA = "0xBD0E50", Offset = "0xBCFE50", VA = "0x180BD0E50", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000136")]
		private object Current
		{
			[Token(Token = "0x60025B2")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04003006 RID: 12294
		[Token(Token = "0x4003006")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04003007 RID: 12295
		[Token(Token = "0x4003007")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04003008 RID: 12296
		[Token(Token = "0x4003008")]
		[FieldOffset(Offset = "0x20")]
		public UpgradesController <>4__this;
	}
}
