using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000695 RID: 1685
[Token(Token = "0x2000695")]
public class SyncDiskElementController : MonoBehaviour
{
	// Token: 0x06002567 RID: 9575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002567")]
	[Address(RVA = "0xBBF390", Offset = "0xBBE390", VA = "0x180BBF390")]
	public void Setup(UpgradesController.Upgrades newUpgrade)
	{
	}

	// Token: 0x06002568 RID: 9576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002568")]
	[Address(RVA = "0xBC04D0", Offset = "0xBBF4D0", VA = "0x180BC04D0")]
	public void SetInstallAllowed(bool val)
	{
	}

	// Token: 0x06002569 RID: 9577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002569")]
	[Address(RVA = "0xBC04E0", Offset = "0xBBF4E0", VA = "0x180BC04E0")]
	public void VisualUpdate()
	{
	}

	// Token: 0x0600256A RID: 9578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600256A")]
	[Address(RVA = "0xBC5220", Offset = "0xBC4220", VA = "0x180BC5220")]
	public void SelectOptionButton(int val)
	{
	}

	// Token: 0x0600256B RID: 9579 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600256B")]
	[Address(RVA = "0xBC5230", Offset = "0xBC4230", VA = "0x180BC5230")]
	public void InstallButton()
	{
	}

	// Token: 0x0600256C RID: 9580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600256C")]
	[Address(RVA = "0xBC5820", Offset = "0xBC4820", VA = "0x180BC5820")]
	public void PopupCancel()
	{
	}

	// Token: 0x0600256D RID: 9581 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600256D")]
	[Address(RVA = "0xBC5A90", Offset = "0xBC4A90", VA = "0x180BC5A90")]
	public void InstallPromptSuccess()
	{
	}

	// Token: 0x0600256E RID: 9582 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600256E")]
	[Address(RVA = "0xBC5C50", Offset = "0xBC4C50", VA = "0x180BC5C50")]
	public void UninstallPromptSuccess()
	{
	}

	// Token: 0x0600256F RID: 9583 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600256F")]
	[Address(RVA = "0xBC5EF0", Offset = "0xBC4EF0", VA = "0x180BC5EF0")]
	public void UpgradeButton()
	{
	}

	// Token: 0x06002570 RID: 9584 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002570")]
	[Address(RVA = "0xBC6180", Offset = "0xBC5180", VA = "0x180BC6180")]
	public void UpgradePromptSuccess()
	{
	}

	// Token: 0x06002571 RID: 9585 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002571")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public SyncDiskElementController()
	{
	}

	// Token: 0x06002572 RID: 9586 RVA: 0x0000EB98 File Offset: 0x0000CD98
	[Token(Token = "0x6002572")]
	[Address(RVA = "0xBC6340", Offset = "0xBC5340", VA = "0x180BC6340")]
	private bool <InstallButton>b__27_0(UpgradesController.Upgrades item)
	{
		return default(bool);
	}

	// Token: 0x04002FBA RID: 12218
	[Token(Token = "0x4002FBA")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002FBB RID: 12219
	[Token(Token = "0x4002FBB")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI titleText;

	// Token: 0x04002FBC RID: 12220
	[Token(Token = "0x4002FBC")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI numberText;

	// Token: 0x04002FBD RID: 12221
	[Token(Token = "0x4002FBD")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI descriptionText;

	// Token: 0x04002FBE RID: 12222
	[Token(Token = "0x4002FBE")]
	[FieldOffset(Offset = "0x38")]
	public ButtonController option1Button;

	// Token: 0x04002FBF RID: 12223
	[Token(Token = "0x4002FBF")]
	[FieldOffset(Offset = "0x40")]
	public ButtonController option2Button;

	// Token: 0x04002FC0 RID: 12224
	[Token(Token = "0x4002FC0")]
	[FieldOffset(Offset = "0x48")]
	public ButtonController option3Button;

	// Token: 0x04002FC1 RID: 12225
	[Token(Token = "0x4002FC1")]
	[FieldOffset(Offset = "0x50")]
	public ButtonController upgradeButton;

	// Token: 0x04002FC2 RID: 12226
	[Token(Token = "0x4002FC2")]
	[FieldOffset(Offset = "0x58")]
	public ButtonController sideEffectButton;

	// Token: 0x04002FC3 RID: 12227
	[Token(Token = "0x4002FC3")]
	[FieldOffset(Offset = "0x60")]
	public ButtonController uninstallButton;

	// Token: 0x04002FC4 RID: 12228
	[Token(Token = "0x4002FC4")]
	[FieldOffset(Offset = "0x68")]
	public Image option1Icon;

	// Token: 0x04002FC5 RID: 12229
	[Token(Token = "0x4002FC5")]
	[FieldOffset(Offset = "0x70")]
	public Image option2Icon;

	// Token: 0x04002FC6 RID: 12230
	[Token(Token = "0x4002FC6")]
	[FieldOffset(Offset = "0x78")]
	public Image option3Icon;

	// Token: 0x04002FC7 RID: 12231
	[Token(Token = "0x4002FC7")]
	[FieldOffset(Offset = "0x80")]
	public ButtonController upgradePip1;

	// Token: 0x04002FC8 RID: 12232
	[Token(Token = "0x4002FC8")]
	[FieldOffset(Offset = "0x88")]
	public ButtonController upgradePip2;

	// Token: 0x04002FC9 RID: 12233
	[Token(Token = "0x4002FC9")]
	[FieldOffset(Offset = "0x90")]
	public ButtonController upgradePip3;

	// Token: 0x04002FCA RID: 12234
	[Token(Token = "0x4002FCA")]
	[FieldOffset(Offset = "0x98")]
	public Image manufacturerLogo;

	// Token: 0x04002FCB RID: 12235
	[Token(Token = "0x4002FCB")]
	[FieldOffset(Offset = "0xA0")]
	public Sprite upgradeEmptySprite;

	// Token: 0x04002FCC RID: 12236
	[Token(Token = "0x4002FCC")]
	[FieldOffset(Offset = "0xA8")]
	public Sprite upgradeEnabledSprite;

	// Token: 0x04002FCD RID: 12237
	[Token(Token = "0x4002FCD")]
	[FieldOffset(Offset = "0xB0")]
	public UpgradesController.Upgrades upgrade;

	// Token: 0x04002FCE RID: 12238
	[Token(Token = "0x4002FCE")]
	[FieldOffset(Offset = "0xB8")]
	public SyncDiskPreset preset;

	// Token: 0x04002FCF RID: 12239
	[Token(Token = "0x4002FCF")]
	[FieldOffset(Offset = "0xC0")]
	public int selectedOption;

	// Token: 0x04002FD0 RID: 12240
	[Token(Token = "0x4002FD0")]
	[FieldOffset(Offset = "0xC4")]
	public bool installAllowed;

	// Token: 0x02000696 RID: 1686
	[Token(Token = "0x2000696")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002574 RID: 9588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002574")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		[Token(Token = "0x6002575")]
		[Address(RVA = "0xBC6460", Offset = "0xBC5460", VA = "0x180BC6460")]
		internal bool <VisualUpdate>b__25_0(UpgradeEffectController.AppliedEffect item)
		{
			return default(bool);
		}

		// Token: 0x04002FD1 RID: 12241
		[Token(Token = "0x4002FD1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SyncDiskElementController.<>c <>9;

		// Token: 0x04002FD2 RID: 12242
		[Token(Token = "0x4002FD2")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<UpgradeEffectController.AppliedEffect> <>9__25_0;
	}
}
