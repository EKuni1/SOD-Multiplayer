using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000604 RID: 1540
[Token(Token = "0x2000604")]
public class ItemController : MonoBehaviour
{
	// Token: 0x1400003B RID: 59
	// (add) Token: 0x060021EB RID: 8683 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060021EC RID: 8684 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400003B")]
	public event ItemController.UpdateUnseenFacts OnUpdateUnseenFacts
	{
		[Token(Token = "0x60021EB")]
		[Address(RVA = "0xB1C9D0", Offset = "0xB1B9D0", VA = "0x180B1C9D0")]
		add
		{
		}
		[Token(Token = "0x60021EC")]
		[Address(RVA = "0xB1CAC0", Offset = "0xB1BAC0", VA = "0x180B1CAC0")]
		remove
		{
		}
	}

	// Token: 0x060021ED RID: 8685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021ED")]
	[Address(RVA = "0xB1CBB0", Offset = "0xB1BBB0", VA = "0x180B1CBB0")]
	public void Setup(InfoWindow newParent)
	{
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021EE")]
	[Address(RVA = "0xB1CDC0", Offset = "0xB1BDC0", VA = "0x180B1CDC0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060021EF RID: 8687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021EF")]
	[Address(RVA = "0xB1D080", Offset = "0xB1C080", VA = "0x180B1D080")]
	public void UpdateNameDisplay()
	{
	}

	// Token: 0x060021F0 RID: 8688 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021F0")]
	[Address(RVA = "0xB1D0D0", Offset = "0xB1C0D0", VA = "0x180B1D0D0")]
	public void UpdateFactsDisplay()
	{
	}

	// Token: 0x060021F1 RID: 8689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021F1")]
	[Address(RVA = "0xB1E200", Offset = "0xB1D200", VA = "0x180B1E200")]
	public void PositionSpawnedFacts(float edgeMargin = 10f, float iconMargin = 6f)
	{
	}

	// Token: 0x060021F2 RID: 8690 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021F2")]
	[Address(RVA = "0xB1EE30", Offset = "0xB1DE30", VA = "0x180B1EE30")]
	public void UpdateUnSeenFacts()
	{
	}

	// Token: 0x060021F3 RID: 8691 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021F3")]
	[Address(RVA = "0xB1F060", Offset = "0xB1E060", VA = "0x180B1F060")]
	public void NewCustomFactButton(ButtonController thisButton)
	{
	}

	// Token: 0x060021F4 RID: 8692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021F4")]
	[Address(RVA = "0xB1F2B0", Offset = "0xB1E2B0", VA = "0x180B1F2B0")]
	public ItemController()
	{
	}

	// Token: 0x04002BA0 RID: 11168
	[Token(Token = "0x4002BA0")]
	[FieldOffset(Offset = "0x18")]
	[NonSerialized]
	public InfoWindow parentWindow;

	// Token: 0x04002BA1 RID: 11169
	[Token(Token = "0x4002BA1")]
	[FieldOffset(Offset = "0x20")]
	public WindowContentController childEvContent;

	// Token: 0x04002BA2 RID: 11170
	[Token(Token = "0x4002BA2")]
	[FieldOffset(Offset = "0x28")]
	public List<ButtonController> spawnedChildEvButtons;

	// Token: 0x04002BA3 RID: 11171
	[Token(Token = "0x4002BA3")]
	[FieldOffset(Offset = "0x30")]
	public WindowContentController factContent;

	// Token: 0x04002BA4 RID: 11172
	[Token(Token = "0x4002BA4")]
	[FieldOffset(Offset = "0x38")]
	public List<FactButtonController> spawnedFactButtons;

	// Token: 0x04002BA5 RID: 11173
	[Token(Token = "0x4002BA5")]
	[FieldOffset(Offset = "0x40")]
	public ButtonController newCustomFactButton;

	// Token: 0x04002BA6 RID: 11174
	[Token(Token = "0x4002BA6")]
	[FieldOffset(Offset = "0x48")]
	public int unSeenFacts;

	// Token: 0x04002BA7 RID: 11175
	[Token(Token = "0x4002BA7")]
	[FieldOffset(Offset = "0x4C")]
	private int prevUnSeenFacts;

	// Token: 0x04002BA8 RID: 11176
	[Token(Token = "0x4002BA8")]
	[FieldOffset(Offset = "0x50")]
	public List<string> debugFacts;

	// Token: 0x02000605 RID: 1541
	// (Invoke) Token: 0x060021F6 RID: 8694
	[Token(Token = "0x2000605")]
	public delegate void UpdateUnseenFacts(int val);

	// Token: 0x02000606 RID: 1542
	[Token(Token = "0x2000606")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x060021F9 RID: 8697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x0000E178 File Offset: 0x0000C378
		[Token(Token = "0x60021FA")]
		[Address(RVA = "0xB1F580", Offset = "0xB1E580", VA = "0x180B1F580")]
		internal bool <UpdateFactsDisplay>b__0(Evidence.FactLink item)
		{
			return default(bool);
		}

		// Token: 0x04002BAA RID: 11178
		[Token(Token = "0x4002BAA")]
		[FieldOffset(Offset = "0x10")]
		public FactButtonController fbc;
	}

	// Token: 0x02000607 RID: 1543
	[Token(Token = "0x2000607")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060021FC RID: 8700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x0000E190 File Offset: 0x0000C390
		[Token(Token = "0x60021FD")]
		[Address(RVA = "0xB1F660", Offset = "0xB1E660", VA = "0x180B1F660")]
		internal int <PositionSpawnedFacts>b__17_0(FactButtonController p1, FactButtonController p2)
		{
			return 0;
		}

		// Token: 0x04002BAB RID: 11179
		[Token(Token = "0x4002BAB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ItemController.<>c <>9;

		// Token: 0x04002BAC RID: 11180
		[Token(Token = "0x4002BAC")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<FactButtonController> <>9__17_0;
	}
}
