using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020005BA RID: 1466
[Token(Token = "0x20005BA")]
public class DropdownController : MonoBehaviour
{
	// Token: 0x0600203F RID: 8255 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600203F")]
	[Address(RVA = "0xAD78F0", Offset = "0xAD68F0", VA = "0x180AD78F0")]
	private void Start()
	{
	}

	// Token: 0x06002040 RID: 8256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002040")]
	[Address(RVA = "0xAD7B20", Offset = "0xAD6B20", VA = "0x180AD7B20")]
	public void AddOptions(List<string> newOptions, bool useDictionary, [Optional] List<string> newListedOptions)
	{
	}

	// Token: 0x06002041 RID: 8257 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002041")]
	[Address(RVA = "0xAD7E60", Offset = "0xAD6E60", VA = "0x180AD7E60")]
	public void SelectFromStaticOption(string staticOption)
	{
	}

	// Token: 0x06002042 RID: 8258 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002042")]
	[Address(RVA = "0xAD8150", Offset = "0xAD7150", VA = "0x180AD8150")]
	public string GetCurrentSelectedStaticOption()
	{
		return null;
	}

	// Token: 0x06002043 RID: 8259 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002043")]
	[Address(RVA = "0xAD8280", Offset = "0xAD7280", VA = "0x180AD8280")]
	public void OnControlModeChange()
	{
	}

	// Token: 0x06002044 RID: 8260 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002044")]
	[Address(RVA = "0xAD8E20", Offset = "0xAD7E20", VA = "0x180AD8E20")]
	public void OnNextButton()
	{
	}

	// Token: 0x06002045 RID: 8261 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002045")]
	[Address(RVA = "0xAD8E50", Offset = "0xAD7E50", VA = "0x180AD8E50")]
	public void OnPreviousButton()
	{
	}

	// Token: 0x06002046 RID: 8262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002046")]
	[Address(RVA = "0xAD8E80", Offset = "0xAD7E80", VA = "0x180AD8E80")]
	public void OnValueChange()
	{
	}

	// Token: 0x06002047 RID: 8263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002047")]
	[Address(RVA = "0xAD8F00", Offset = "0xAD7F00", VA = "0x180AD8F00")]
	public void SetInteractalbe(bool val)
	{
	}

	// Token: 0x06002048 RID: 8264 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002048")]
	[Address(RVA = "0xAD8F10", Offset = "0xAD7F10", VA = "0x180AD8F10")]
	public DropdownController()
	{
	}

	// Token: 0x06002049 RID: 8265 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002049")]
	[Address(RVA = "0xAD8E20", Offset = "0xAD7E20", VA = "0x180AD8E20")]
	private void <Start>b__10_0()
	{
	}

	// Token: 0x0600204A RID: 8266 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600204A")]
	[Address(RVA = "0xAD8E50", Offset = "0xAD7E50", VA = "0x180AD8E50")]
	private void <Start>b__10_1()
	{
	}

	// Token: 0x040029DC RID: 10716
	[Token(Token = "0x40029DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform dropdownRect;

	// Token: 0x040029DD RID: 10717
	[Token(Token = "0x40029DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RectTransform dropdownArrow;

	// Token: 0x040029DE RID: 10718
	[Token(Token = "0x40029DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TMP_Dropdown dropdown;

	// Token: 0x040029DF RID: 10719
	[Token(Token = "0x40029DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RectTransform buttonsRect;

	// Token: 0x040029E0 RID: 10720
	[Token(Token = "0x40029E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ButtonController prevButton;

	// Token: 0x040029E1 RID: 10721
	[Token(Token = "0x40029E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ButtonController nextButton;

	// Token: 0x040029E2 RID: 10722
	[Token(Token = "0x40029E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string playerPrefsID;

	// Token: 0x040029E3 RID: 10723
	[Token(Token = "0x40029E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<string> staticOptionReference;

	// Token: 0x040029E4 RID: 10724
	[Token(Token = "0x40029E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool isInteractable;

	// Token: 0x040029E5 RID: 10725
	[Token(Token = "0x40029E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float normalWidth;

	// Token: 0x020005BB RID: 1467
	[Token(Token = "0x20005BB")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x0600204B RID: 8267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		[Token(Token = "0x600204C")]
		[Address(RVA = "0xAD9020", Offset = "0xAD8020", VA = "0x180AD9020")]
		internal bool <SelectFromStaticOption>b__0(string item)
		{
			return default(bool);
		}

		// Token: 0x040029E6 RID: 10726
		[Token(Token = "0x40029E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string staticOption;
	}
}
