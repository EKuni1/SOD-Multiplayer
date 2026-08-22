using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000621 RID: 1569
[Token(Token = "0x2000621")]
public class StateElementController : ButtonController
{
	// Token: 0x06002272 RID: 8818 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002272")]
	[Address(RVA = "0xB330F0", Offset = "0xB320F0", VA = "0x180B330F0")]
	public void Setup(StatusController.StatusInstance newInstance)
	{
	}

	// Token: 0x06002273 RID: 8819 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002273")]
	[Address(RVA = "0xB2D620", Offset = "0xB2C620", VA = "0x180B2D620")]
	private void OnEnable()
	{
	}

	// Token: 0x06002274 RID: 8820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002274")]
	[Address(RVA = "0xB33520", Offset = "0xB32520", VA = "0x180B33520", Slot = "10")]
	public override void VisualUpdate()
	{
	}

	// Token: 0x06002275 RID: 8821 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002275")]
	[Address(RVA = "0xB34B90", Offset = "0xB33B90", VA = "0x180B34B90")]
	public void SetRemove(bool val)
	{
	}

	// Token: 0x06002276 RID: 8822 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
	[Token(Token = "0x6002276")]
	[Address(RVA = "0xB352E0", Offset = "0xB342E0", VA = "0x180B352E0")]
	public Color GetColour()
	{
		return default(Color);
	}

	// Token: 0x06002277 RID: 8823 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002277")]
	[Address(RVA = "0xB357D0", Offset = "0xB347D0", VA = "0x180B357D0")]
	public void SetMinimized(bool val)
	{
	}

	// Token: 0x06002278 RID: 8824 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002278")]
	[Address(RVA = "0xB357F0", Offset = "0xB347F0", VA = "0x180B357F0")]
	public void SetMaximized(bool val)
	{
	}

	// Token: 0x06002279 RID: 8825 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002279")]
	[Address(RVA = "0xB35810", Offset = "0xB34810", VA = "0x180B35810")]
	public StateElementController()
	{
	}

	// Token: 0x04002C14 RID: 11284
	[Token(Token = "0x4002C14")]
	[FieldOffset(Offset = "0x1A8")]
	public TextMeshProUGUI mainText;

	// Token: 0x04002C15 RID: 11285
	[Token(Token = "0x4002C15")]
	[FieldOffset(Offset = "0x1B0")]
	public TextMeshProUGUI detailText;

	// Token: 0x04002C16 RID: 11286
	[Token(Token = "0x4002C16")]
	[FieldOffset(Offset = "0x1B8")]
	public TextMeshProUGUI fineText;

	// Token: 0x04002C17 RID: 11287
	[Token(Token = "0x4002C17")]
	[FieldOffset(Offset = "0x1C0")]
	public int displayedFine;

	// Token: 0x04002C18 RID: 11288
	[Token(Token = "0x4002C18")]
	[FieldOffset(Offset = "0x1C4")]
	public int fineTotal;

	// Token: 0x04002C19 RID: 11289
	[Token(Token = "0x4002C19")]
	[FieldOffset(Offset = "0x1C8")]
	public JuiceController iconJuice;

	// Token: 0x04002C1A RID: 11290
	[Token(Token = "0x4002C1A")]
	[FieldOffset(Offset = "0x1D0")]
	public RectTransform progressBar;

	// Token: 0x04002C1B RID: 11291
	[Token(Token = "0x4002C1B")]
	[FieldOffset(Offset = "0x1D8")]
	public Image progressBarImg;

	// Token: 0x04002C1C RID: 11292
	[Token(Token = "0x4002C1C")]
	[FieldOffset(Offset = "0x1E0")]
	public StatusPreset preset;

	// Token: 0x04002C1D RID: 11293
	[Token(Token = "0x4002C1D")]
	[FieldOffset(Offset = "0x1E8")]
	public StatusController.StatusInstance statusInstance;

	// Token: 0x04002C1E RID: 11294
	[Token(Token = "0x4002C1E")]
	[FieldOffset(Offset = "0x200")]
	private List<StatusController.StatusCount> counts;

	// Token: 0x04002C1F RID: 11295
	[Token(Token = "0x4002C1F")]
	[FieldOffset(Offset = "0x208")]
	public List<CanvasRenderer> renderElements;

	// Token: 0x04002C20 RID: 11296
	[Token(Token = "0x4002C20")]
	[FieldOffset(Offset = "0x210")]
	public bool minimized;

	// Token: 0x04002C21 RID: 11297
	[Token(Token = "0x4002C21")]
	[FieldOffset(Offset = "0x214")]
	public float minimizeTimer;

	// Token: 0x04002C22 RID: 11298
	[Token(Token = "0x4002C22")]
	[FieldOffset(Offset = "0x218")]
	public float widthResizingProgress;

	// Token: 0x04002C23 RID: 11299
	[Token(Token = "0x4002C23")]
	[FieldOffset(Offset = "0x21C")]
	public bool removing;

	// Token: 0x04002C24 RID: 11300
	[Token(Token = "0x4002C24")]
	[FieldOffset(Offset = "0x220")]
	public float removalTimer;

	// Token: 0x04002C25 RID: 11301
	[Token(Token = "0x4002C25")]
	[FieldOffset(Offset = "0x228")]
	public RectTransform xIcon;

	// Token: 0x04002C26 RID: 11302
	[Token(Token = "0x4002C26")]
	[FieldOffset(Offset = "0x230")]
	public CanvasRenderer xIconRend;

	// Token: 0x04002C27 RID: 11303
	[Token(Token = "0x4002C27")]
	[FieldOffset(Offset = "0x238")]
	public float maximizeTimer;

	// Token: 0x04002C28 RID: 11304
	[Token(Token = "0x4002C28")]
	[FieldOffset(Offset = "0x23C")]
	public bool maximized;

	// Token: 0x04002C29 RID: 11305
	[Token(Token = "0x4002C29")]
	[FieldOffset(Offset = "0x240")]
	public float heightResizingProgress;

	// Token: 0x04002C2A RID: 11306
	[Token(Token = "0x4002C2A")]
	[FieldOffset(Offset = "0x244")]
	public float maximizedHeight;

	// Token: 0x04002C2B RID: 11307
	[Token(Token = "0x4002C2B")]
	[FieldOffset(Offset = "0x248")]
	public bool isWanted;

	// Token: 0x02000622 RID: 1570
	[Token(Token = "0x2000622")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600227B RID: 8827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		[Token(Token = "0x600227C")]
		[Address(RVA = "0xB35A80", Offset = "0xB34A80", VA = "0x180B35A80")]
		internal bool <VisualUpdate>b__26_0(StatusController.StatusCount item)
		{
			return default(bool);
		}

		// Token: 0x04002C2C RID: 11308
		[Token(Token = "0x4002C2C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly StateElementController.<>c <>9;

		// Token: 0x04002C2D RID: 11309
		[Token(Token = "0x4002C2D")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<StatusController.StatusCount> <>9__26_0;
	}
}
