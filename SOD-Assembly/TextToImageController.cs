using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200068F RID: 1679
[Token(Token = "0x200068F")]
public class TextToImageController : MonoBehaviour
{
	// Token: 0x1700012E RID: 302
	// (get) Token: 0x0600253A RID: 9530 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700012E")]
	public static TextToImageController Instance
	{
		[Token(Token = "0x600253A")]
		[Address(RVA = "0xBB7A60", Offset = "0xBB6A60", VA = "0x180BB7A60")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600253B RID: 9531 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600253B")]
	[Address(RVA = "0xBB7AA0", Offset = "0xBB6AA0", VA = "0x180BB7AA0")]
	private void Awake()
	{
	}

	// Token: 0x0600253C RID: 9532 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600253C")]
	[Address(RVA = "0xBB7DF0", Offset = "0xBB6DF0", VA = "0x180BB7DF0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600253D RID: 9533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600253D")]
	[Address(RVA = "0xBB8360", Offset = "0xBB7360", VA = "0x180BB8360")]
	private void Start()
	{
	}

	// Token: 0x0600253E RID: 9534 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600253E")]
	[Address(RVA = "0xBB8420", Offset = "0xBB7420", VA = "0x180BB8420")]
	public Texture2D CaptureTextToImage([Optional] TextToImageController.TextToImageSettings settings, bool returnReadOnly = true)
	{
		return null;
	}

	// Token: 0x0600253F RID: 9535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600253F")]
	[Address(RVA = "0xBB94D0", Offset = "0xBB84D0", VA = "0x180BB94D0")]
	public void UpdateNewsTickerHeadline(string newString = "")
	{
	}

	// Token: 0x06002540 RID: 9536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002540")]
	[Address(RVA = "0xBB99F0", Offset = "0xBB89F0", VA = "0x180BB99F0")]
	public void ProcessImage([Optional] TextToImageController.TextToImageSettings settings)
	{
	}

	// Token: 0x06002541 RID: 9537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002541")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void SavePNG()
	{
	}

	// Token: 0x06002542 RID: 9538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002542")]
	[Address(RVA = "0xBBA2C0", Offset = "0xBB92C0", VA = "0x180BBA2C0")]
	public TextToImageController()
	{
	}

	// Token: 0x04002F75 RID: 12149
	[Token(Token = "0x4002F75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform captureTextCanvasRect;

	// Token: 0x04002F76 RID: 12150
	[Token(Token = "0x4002F76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI captureText;

	// Token: 0x04002F77 RID: 12151
	[Token(Token = "0x4002F77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material newsTickerMaterial;

	// Token: 0x04002F78 RID: 12152
	[Token(Token = "0x4002F78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TMP_FontAsset newsTickerFont;

	// Token: 0x04002F79 RID: 12153
	[Token(Token = "0x4002F79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float newsTickerFontSize;

	// Token: 0x04002F7A RID: 12154
	[Token(Token = "0x4002F7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float newsTickerDivider;

	// Token: 0x04002F7B RID: 12155
	[Token(Token = "0x4002F7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float newsTickerSpeedDivider;

	// Token: 0x04002F7C RID: 12156
	[Token(Token = "0x4002F7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool saveDebugScreenshot;

	// Token: 0x04002F7D RID: 12157
	[Token(Token = "0x4002F7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector2 maxSize;

	// Token: 0x04002F7E RID: 12158
	[Token(Token = "0x4002F7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextToImageController.TextToImageSettings defaultSettings;

	// Token: 0x04002F7F RID: 12159
	[Token(Token = "0x4002F7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string lastText;

	// Token: 0x04002F80 RID: 12160
	[Token(Token = "0x4002F80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float lastFontSize;

	// Token: 0x04002F81 RID: 12161
	[Token(Token = "0x4002F81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector2 lastDimenstions;

	// Token: 0x04002F82 RID: 12162
	[Token(Token = "0x4002F82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Texture2D currentShot;

	// Token: 0x04002F83 RID: 12163
	[Token(Token = "0x4002F83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Texture2D tickerImg;

	// Token: 0x04002F84 RID: 12164
	[Token(Token = "0x4002F84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static TextToImageController _instance;

	// Token: 0x02000690 RID: 1680
	[Token(Token = "0x2000690")]
	[Serializable]
	public class TextToImageSettings
	{
		// Token: 0x06002543 RID: 9539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002543")]
		[Address(RVA = "0xBBA3C0", Offset = "0xBB93C0", VA = "0x180BBA3C0")]
		public TextToImageSettings()
		{
		}

		// Token: 0x04002F85 RID: 12165
		[Token(Token = "0x4002F85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string textString;

		// Token: 0x04002F86 RID: 12166
		[Token(Token = "0x4002F86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float textSize;

		// Token: 0x04002F87 RID: 12167
		[Token(Token = "0x4002F87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_FontAsset font;

		// Token: 0x04002F88 RID: 12168
		[Token(Token = "0x4002F88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool enableProcessing;

		// Token: 0x04002F89 RID: 12169
		[Token(Token = "0x4002F89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float contrast;

		// Token: 0x04002F8A RID: 12170
		[Token(Token = "0x4002F8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool trim;

		// Token: 0x04002F8B RID: 12171
		[Token(Token = "0x4002F8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int trimPadding;

		// Token: 0x04002F8C RID: 12172
		[Token(Token = "0x4002F8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useAlpha;

		// Token: 0x04002F8D RID: 12173
		[Token(Token = "0x4002F8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color color;
	}
}
