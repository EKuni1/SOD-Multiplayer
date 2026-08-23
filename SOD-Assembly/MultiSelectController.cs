using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005BE RID: 1470
[Token(Token = "0x20005BE")]
public class MultiSelectController : MonoBehaviour
{
	// Token: 0x14000031 RID: 49
	// (add) Token: 0x06002051 RID: 8273 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002052 RID: 8274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000031")]
	public event MultiSelectController.Select OnSelect
	{
		[Token(Token = "0x6002051")]
		[Address(RVA = "0xADA790", Offset = "0xAD9790", VA = "0x180ADA790")]
		add
		{
		}
		[Token(Token = "0x6002052")]
		[Address(RVA = "0xADA880", Offset = "0xAD9880", VA = "0x180ADA880")]
		remove
		{
		}
	}

	// Token: 0x06002053 RID: 8275 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002053")]
	[Address(RVA = "0xADA970", Offset = "0xAD9970", VA = "0x180ADA970")]
	private void Start()
	{
	}

	// Token: 0x06002054 RID: 8276 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002054")]
	[Address(RVA = "0xADA980", Offset = "0xAD9980", VA = "0x180ADA980")]
	public void SetChosen(int newIndex)
	{
	}

	// Token: 0x06002055 RID: 8277 RVA: 0x0000DED8 File Offset: 0x0000C0D8
	[Token(Token = "0x6002055")]
	[Address(RVA = "0xADAB50", Offset = "0xAD9B50", VA = "0x180ADAB50")]
	public Color GetCurrentSelectedColourValue()
	{
		return default(Color);
	}

	// Token: 0x06002056 RID: 8278 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
	[Token(Token = "0x6002056")]
	[Address(RVA = "0xADABF0", Offset = "0xAD9BF0", VA = "0x180ADABF0")]
	public InterfaceControls.EvidenceColours GetCurrentSelectedEvidenceColourValue()
	{
		return InterfaceControls.EvidenceColours.red;
	}

	// Token: 0x06002057 RID: 8279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002057")]
	[Address(RVA = "0xADAC80", Offset = "0xAD9C80", VA = "0x180ADAC80")]
	public void OnValueChanged()
	{
	}

	// Token: 0x06002058 RID: 8280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002058")]
	[Address(RVA = "0xADAD10", Offset = "0xAD9D10", VA = "0x180ADAD10")]
	public MultiSelectController()
	{
	}

	// Token: 0x040029EB RID: 10731
	[Token(Token = "0x40029EB")]
	[FieldOffset(Offset = "0x18")]
	public List<MultiSelectController.MultiSelectValue> optionButtons;

	// Token: 0x040029EC RID: 10732
	[Token(Token = "0x40029EC")]
	[FieldOffset(Offset = "0x20")]
	public string playerPrefsID;

	// Token: 0x040029ED RID: 10733
	[Token(Token = "0x40029ED")]
	[FieldOffset(Offset = "0x28")]
	public int chosenIndex;

	// Token: 0x020005BF RID: 1471
	// (Invoke) Token: 0x0600205A RID: 8282
	[Token(Token = "0x20005BF")]
	public delegate void Select();

	// Token: 0x020005C0 RID: 1472
	[Token(Token = "0x20005C0")]
	[Serializable]
	public class MultiSelectValue
	{
		// Token: 0x0600205D RID: 8285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600205D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public MultiSelectValue()
		{
		}

		// Token: 0x040029EF RID: 10735
		[Token(Token = "0x40029EF")]
		[FieldOffset(Offset = "0x10")]
		public ButtonController button;

		// Token: 0x040029F0 RID: 10736
		[Token(Token = "0x40029F0")]
		[FieldOffset(Offset = "0x18")]
		public Color colourValue;

		// Token: 0x040029F1 RID: 10737
		[Token(Token = "0x40029F1")]
		[FieldOffset(Offset = "0x28")]
		public InterfaceControls.EvidenceColours evidenceColour;
	}
}
