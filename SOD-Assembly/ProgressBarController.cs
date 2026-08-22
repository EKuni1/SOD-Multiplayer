using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200064C RID: 1612
[Token(Token = "0x200064C")]
public class ProgressBarController : MonoBehaviour
{
	// Token: 0x14000043 RID: 67
	// (add) Token: 0x06002381 RID: 9089 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002382 RID: 9090 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000043")]
	public event ProgressBarController.ValueChange OnProgressChange
	{
		[Token(Token = "0x6002381")]
		[Address(RVA = "0xB66C60", Offset = "0xB65C60", VA = "0x180B66C60")]
		add
		{
		}
		[Token(Token = "0x6002382")]
		[Address(RVA = "0xB66D50", Offset = "0xB65D50", VA = "0x180B66D50")]
		remove
		{
		}
	}

	// Token: 0x06002383 RID: 9091 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002383")]
	[Address(RVA = "0xB66E40", Offset = "0xB65E40", VA = "0x180B66E40")]
	private void Awake()
	{
	}

	// Token: 0x06002384 RID: 9092 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002384")]
	[Address(RVA = "0xB67130", Offset = "0xB66130", VA = "0x180B67130")]
	public void SetupPips()
	{
	}

	// Token: 0x06002385 RID: 9093 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002385")]
	[Address(RVA = "0xB67750", Offset = "0xB66750", VA = "0x180B67750")]
	private void Start()
	{
	}

	// Token: 0x06002386 RID: 9094 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002386")]
	[Address(RVA = "0xB67770", Offset = "0xB66770", VA = "0x180B67770")]
	public void SetName(string newName)
	{
	}

	// Token: 0x06002387 RID: 9095 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002387")]
	[Address(RVA = "0xB67990", Offset = "0xB66990", VA = "0x180B67990")]
	public void SetValue(float setTo)
	{
	}

	// Token: 0x06002388 RID: 9096 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002388")]
	[Address(RVA = "0xB67A50", Offset = "0xB66A50", VA = "0x180B67A50")]
	public void SetSecondaryValue(float setTo)
	{
	}

	// Token: 0x06002389 RID: 9097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002389")]
	[Address(RVA = "0xB67AF0", Offset = "0xB66AF0", VA = "0x180B67AF0")]
	public void VisualUpdate()
	{
	}

	// Token: 0x0600238A RID: 9098 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600238A")]
	[Address(RVA = "0xB68E60", Offset = "0xB67E60", VA = "0x180B68E60")]
	public ProgressBarController()
	{
	}

	// Token: 0x04002D59 RID: 11609
	[Token(Token = "0x4002D59")]
	[FieldOffset(Offset = "0x18")]
	public string barName;

	// Token: 0x04002D5A RID: 11610
	[Token(Token = "0x4002D5A")]
	[FieldOffset(Offset = "0x20")]
	public float value;

	// Token: 0x04002D5B RID: 11611
	[Token(Token = "0x4002D5B")]
	[FieldOffset(Offset = "0x24")]
	public float secondaryValue;

	// Token: 0x04002D5C RID: 11612
	[Token(Token = "0x4002D5C")]
	[FieldOffset(Offset = "0x28")]
	public float barMin;

	// Token: 0x04002D5D RID: 11613
	[Token(Token = "0x4002D5D")]
	[FieldOffset(Offset = "0x2C")]
	public float barMax;

	// Token: 0x04002D5E RID: 11614
	[Token(Token = "0x4002D5E")]
	[FieldOffset(Offset = "0x30")]
	public float progress;

	// Token: 0x04002D5F RID: 11615
	[Token(Token = "0x4002D5F")]
	[FieldOffset(Offset = "0x34")]
	public float secondaryProgress;

	// Token: 0x04002D60 RID: 11616
	[Token(Token = "0x4002D60")]
	[FieldOffset(Offset = "0x38")]
	private int progressInt;

	// Token: 0x04002D61 RID: 11617
	[Token(Token = "0x4002D61")]
	[FieldOffset(Offset = "0x3C")]
	public bool usePips;

	// Token: 0x04002D62 RID: 11618
	[Token(Token = "0x4002D62")]
	[FieldOffset(Offset = "0x40")]
	public GameObject pipObject;

	// Token: 0x04002D63 RID: 11619
	[Token(Token = "0x4002D63")]
	[FieldOffset(Offset = "0x48")]
	public int pipValue;

	// Token: 0x04002D64 RID: 11620
	[Token(Token = "0x4002D64")]
	[FieldOffset(Offset = "0x4C")]
	public int pipNumber;

	// Token: 0x04002D65 RID: 11621
	[Token(Token = "0x4002D65")]
	[FieldOffset(Offset = "0x50")]
	public bool useSecondaryPipValue;

	// Token: 0x04002D66 RID: 11622
	[Token(Token = "0x4002D66")]
	[FieldOffset(Offset = "0x54")]
	public int secondaryPipValue;

	// Token: 0x04002D67 RID: 11623
	[Token(Token = "0x4002D67")]
	[FieldOffset(Offset = "0x58")]
	public bool displayProgress;

	// Token: 0x04002D68 RID: 11624
	[Token(Token = "0x4002D68")]
	[FieldOffset(Offset = "0x59")]
	public bool displayPercentageSign;

	// Token: 0x04002D69 RID: 11625
	[Token(Token = "0x4002D69")]
	[FieldOffset(Offset = "0x5A")]
	public bool setNameOnStart;

	// Token: 0x04002D6A RID: 11626
	[Token(Token = "0x4002D6A")]
	[FieldOffset(Offset = "0x5B")]
	public bool useFloorValueForPercent;

	// Token: 0x04002D6C RID: 11628
	[Token(Token = "0x4002D6C")]
	[FieldOffset(Offset = "0x68")]
	public RectTransform rect;

	// Token: 0x04002D6D RID: 11629
	[Token(Token = "0x4002D6D")]
	[FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI barTitle;

	// Token: 0x04002D6E RID: 11630
	[Token(Token = "0x4002D6E")]
	[FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI progressText;

	// Token: 0x04002D6F RID: 11631
	[Token(Token = "0x4002D6F")]
	[FieldOffset(Offset = "0x80")]
	public RectTransform barRect;

	// Token: 0x04002D70 RID: 11632
	[Token(Token = "0x4002D70")]
	[FieldOffset(Offset = "0x88")]
	public RectTransform progressRect;

	// Token: 0x04002D71 RID: 11633
	[Token(Token = "0x4002D71")]
	[FieldOffset(Offset = "0x90")]
	private RectTransform progressTextRect;

	// Token: 0x04002D72 RID: 11634
	[Token(Token = "0x4002D72")]
	[FieldOffset(Offset = "0x98")]
	private float pipXSize;

	// Token: 0x04002D73 RID: 11635
	[Token(Token = "0x4002D73")]
	[FieldOffset(Offset = "0xA0")]
	public List<ProgressBarPipController> pips;

	// Token: 0x04002D74 RID: 11636
	[Token(Token = "0x4002D74")]
	[FieldOffset(Offset = "0xA8")]
	public ProgressBarPipController hoverOverPip;

	// Token: 0x0200064D RID: 1613
	// (Invoke) Token: 0x0600238C RID: 9100
	[Token(Token = "0x200064D")]
	public delegate void ValueChange(float newValue, int percentage);
}
