using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200067E RID: 1662
[Token(Token = "0x200067E")]
public class MaterialKeyController : MonoBehaviour
{
	// Token: 0x1400004B RID: 75
	// (add) Token: 0x060024D5 RID: 9429 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060024D6 RID: 9430 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400004B")]
	public event MaterialKeyController.ColourKeyUpdate OnColourKeyUpdate
	{
		[Token(Token = "0x60024D5")]
		[Address(RVA = "0xBA6030", Offset = "0xBA5030", VA = "0x180BA6030")]
		add
		{
		}
		[Token(Token = "0x60024D6")]
		[Address(RVA = "0xBA6130", Offset = "0xBA5130", VA = "0x180BA6130")]
		remove
		{
		}
	}

	// Token: 0x060024D7 RID: 9431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024D7")]
	[Address(RVA = "0xBA6230", Offset = "0xBA5230", VA = "0x180BA6230")]
	public void Setup(WindowContentController newContentController)
	{
	}

	// Token: 0x060024D8 RID: 9432 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024D8")]
	[Address(RVA = "0xB99340", Offset = "0xB98340", VA = "0x180B99340")]
	public void SetPageSize(Vector2 newSize)
	{
	}

	// Token: 0x060024D9 RID: 9433 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024D9")]
	[Address(RVA = "0xBA6640", Offset = "0xBA5640", VA = "0x180BA6640")]
	public void UpdateButtonsBasedOnFurniture(FurniturePreset furn)
	{
	}

	// Token: 0x060024DA RID: 9434 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024DA")]
	[Address(RVA = "0xBA6A90", Offset = "0xBA5A90", VA = "0x180BA6A90")]
	public void UpdateButtonsBasedOnMaterial(Material mat, bool setColour, MaterialKeyController.SliderPickerType sliderType = MaterialKeyController.SliderPickerType.grub, bool forceGrub = false, float forcedGrub = 0f)
	{
	}

	// Token: 0x060024DB RID: 9435 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024DB")]
	[Address(RVA = "0xBA8310", Offset = "0xBA7310", VA = "0x180BA8310")]
	public void SetButtonsToKey(Toolbox.MaterialKey key)
	{
	}

	// Token: 0x060024DC RID: 9436 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024DC")]
	[Address(RVA = "0xBA8860", Offset = "0xBA7860", VA = "0x180BA8860")]
	public void ColourSelectButton(int val)
	{
	}

	// Token: 0x060024DD RID: 9437 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024DD")]
	[Address(RVA = "0xBA8C40", Offset = "0xBA7C40", VA = "0x180BA8C40")]
	public void OnNewColourSelect(Color newColour)
	{
	}

	// Token: 0x060024DE RID: 9438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024DE")]
	[Address(RVA = "0xBA9020", Offset = "0xBA8020", VA = "0x180BA9020")]
	public void OnGrubUpdate()
	{
	}

	// Token: 0x060024DF RID: 9439 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024DF")]
	[Address(RVA = "0xBA90A0", Offset = "0xBA80A0", VA = "0x180BA90A0")]
	public void ChangeColourKey()
	{
	}

	// Token: 0x060024E0 RID: 9440 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024E0")]
	[Address(RVA = "0xBA96B0", Offset = "0xBA86B0", VA = "0x180BA96B0")]
	public void PlacementButton()
	{
	}

	// Token: 0x060024E1 RID: 9441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024E1")]
	[Address(RVA = "0xBA98F0", Offset = "0xBA88F0", VA = "0x180BA98F0")]
	public void UpdatePlacementText()
	{
	}

	// Token: 0x060024E2 RID: 9442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024E2")]
	[Address(RVA = "0xBA9BB0", Offset = "0xBA8BB0", VA = "0x180BA9BB0")]
	public void CancelButton()
	{
	}

	// Token: 0x060024E3 RID: 9443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024E3")]
	[Address(RVA = "0xBA9C20", Offset = "0xBA8C20", VA = "0x180BA9C20")]
	private void OnDestroy()
	{
	}

	// Token: 0x060024E4 RID: 9444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024E4")]
	[Address(RVA = "0xBAA070", Offset = "0xBA9070", VA = "0x180BAA070")]
	public MaterialKeyController()
	{
	}

	// Token: 0x04002EE7 RID: 12007
	[Token(Token = "0x4002EE7")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002EE8 RID: 12008
	[Token(Token = "0x4002EE8")]
	[FieldOffset(Offset = "0x20")]
	public WindowContentController wcc;

	// Token: 0x04002EE9 RID: 12009
	[Token(Token = "0x4002EE9")]
	[FieldOffset(Offset = "0x28")]
	public ButtonController placementButton;

	// Token: 0x04002EEA RID: 12010
	[Token(Token = "0x4002EEA")]
	[FieldOffset(Offset = "0x30")]
	public InfoWindow colourWindow;

	// Token: 0x04002EEB RID: 12011
	[Token(Token = "0x4002EEB")]
	[FieldOffset(Offset = "0x38")]
	public ColourPickerController colourPick;

	// Token: 0x04002EEC RID: 12012
	[Token(Token = "0x4002EEC")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI mainColourSelectText;

	// Token: 0x04002EED RID: 12013
	[Token(Token = "0x4002EED")]
	[FieldOffset(Offset = "0x48")]
	public ButtonController mainColourButton;

	// Token: 0x04002EEE RID: 12014
	[Token(Token = "0x4002EEE")]
	[FieldOffset(Offset = "0x50")]
	public RectTransform mainColourUnused;

	// Token: 0x04002EEF RID: 12015
	[Token(Token = "0x4002EEF")]
	[FieldOffset(Offset = "0x58")]
	public ButtonController colour1Button;

	// Token: 0x04002EF0 RID: 12016
	[Token(Token = "0x4002EF0")]
	[FieldOffset(Offset = "0x60")]
	public RectTransform colour1Unused;

	// Token: 0x04002EF1 RID: 12017
	[Token(Token = "0x4002EF1")]
	[FieldOffset(Offset = "0x68")]
	public ButtonController colour2Button;

	// Token: 0x04002EF2 RID: 12018
	[Token(Token = "0x4002EF2")]
	[FieldOffset(Offset = "0x70")]
	public RectTransform colour2Unused;

	// Token: 0x04002EF3 RID: 12019
	[Token(Token = "0x4002EF3")]
	[FieldOffset(Offset = "0x78")]
	public ButtonController colour3Button;

	// Token: 0x04002EF4 RID: 12020
	[Token(Token = "0x4002EF4")]
	[FieldOffset(Offset = "0x80")]
	public RectTransform colour3Unused;

	// Token: 0x04002EF5 RID: 12021
	[Token(Token = "0x4002EF5")]
	[FieldOffset(Offset = "0x88")]
	public TextMeshProUGUI detailsColourSelectText;

	// Token: 0x04002EF6 RID: 12022
	[Token(Token = "0x4002EF6")]
	[FieldOffset(Offset = "0x90")]
	public MaterialKeyController.SliderPickerType sliderType;

	// Token: 0x04002EF7 RID: 12023
	[Token(Token = "0x4002EF7")]
	[FieldOffset(Offset = "0x98")]
	public TextMeshProUGUI grubSelectText;

	// Token: 0x04002EF8 RID: 12024
	[Token(Token = "0x4002EF8")]
	[FieldOffset(Offset = "0xA0")]
	public SliderController grubSlider;

	// Token: 0x04002EF9 RID: 12025
	[Token(Token = "0x4002EF9")]
	[FieldOffset(Offset = "0xA8")]
	public bool isSetup;

	// Token: 0x04002EFA RID: 12026
	[Token(Token = "0x4002EFA")]
	[FieldOffset(Offset = "0xB0")]
	public Toolbox.MaterialKey matKey;

	// Token: 0x04002EFB RID: 12027
	[Token(Token = "0x4002EFB")]
	[FieldOffset(Offset = "0xB8")]
	private int colourEdit;

	// Token: 0x0200067F RID: 1663
	[Token(Token = "0x200067F")]
	public enum SliderPickerType
	{
		// Token: 0x04002EFE RID: 12030
		[Token(Token = "0x4002EFE")]
		grub,
		// Token: 0x04002EFF RID: 12031
		[Token(Token = "0x4002EFF")]
		plants,
		// Token: 0x04002F00 RID: 12032
		[Token(Token = "0x4002F00")]
		artPortrait,
		// Token: 0x04002F01 RID: 12033
		[Token(Token = "0x4002F01")]
		artLandscape,
		// Token: 0x04002F02 RID: 12034
		[Token(Token = "0x4002F02")]
		artSquare,
		// Token: 0x04002F03 RID: 12035
		[Token(Token = "0x4002F03")]
		artPoster,
		// Token: 0x04002F04 RID: 12036
		[Token(Token = "0x4002F04")]
		artLitter,
		// Token: 0x04002F05 RID: 12037
		[Token(Token = "0x4002F05")]
		artWallGrimeTop,
		// Token: 0x04002F06 RID: 12038
		[Token(Token = "0x4002F06")]
		artWallGrimeBottom,
		// Token: 0x04002F07 RID: 12039
		[Token(Token = "0x4002F07")]
		artDynamicClue,
		// Token: 0x04002F08 RID: 12040
		[Token(Token = "0x4002F08")]
		artGraffiti
	}

	// Token: 0x02000680 RID: 1664
	// (Invoke) Token: 0x060024E6 RID: 9446
	[Token(Token = "0x2000680")]
	public delegate void ColourKeyUpdate();

	// Token: 0x02000681 RID: 1665
	[Token(Token = "0x2000681")]
	private sealed class <>c__DisplayClass29_0
	{
		// Token: 0x060024E9 RID: 9449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024E9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass29_0()
		{
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		[Token(Token = "0x60024EA")]
		[Address(RVA = "0xBAA150", Offset = "0xBA9150", VA = "0x180BAA150")]
		internal bool <UpdateButtonsBasedOnMaterial>b__0(ArtPreset item)
		{
			return default(bool);
		}

		// Token: 0x04002F09 RID: 12041
		[Token(Token = "0x4002F09")]
		[FieldOffset(Offset = "0x10")]
		public ArtPreset.ArtOrientation orientation;
	}

	// Token: 0x02000682 RID: 1666
	[Token(Token = "0x2000682")]
	private sealed class <>c__DisplayClass34_0
	{
		// Token: 0x060024EB RID: 9451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024EB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass34_0()
		{
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x0000EB08 File Offset: 0x0000CD08
		[Token(Token = "0x60024EC")]
		[Address(RVA = "0xBAA1F0", Offset = "0xBA91F0", VA = "0x180BAA1F0")]
		internal bool <ChangeColourKey>b__0(ArtPreset item)
		{
			return default(bool);
		}

		// Token: 0x04002F0A RID: 12042
		[Token(Token = "0x4002F0A")]
		[FieldOffset(Offset = "0x10")]
		public ArtPreset.ArtOrientation orientation;
	}
}
