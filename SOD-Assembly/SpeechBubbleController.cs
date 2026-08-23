using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005B6 RID: 1462
[Token(Token = "0x20005B6")]
public class SpeechBubbleController : MonoBehaviour
{
	// Token: 0x0600202D RID: 8237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600202D")]
	[Address(RVA = "0xAD3140", Offset = "0xAD2140", VA = "0x180AD3140")]
	public void Setup(SpeechController.QueueElement newSpeech, SpeechController newSpeechController)
	{
	}

	// Token: 0x0600202E RID: 8238 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600202E")]
	[Address(RVA = "0xAD4340", Offset = "0xAD3340", VA = "0x180AD4340")]
	private void Update()
	{
	}

	// Token: 0x0600202F RID: 8239 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600202F")]
	[Address(RVA = "0xAD66D0", Offset = "0xAD56D0", VA = "0x180AD66D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002030 RID: 8240 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002030")]
	[Address(RVA = "0xAD7150", Offset = "0xAD6150", VA = "0x180AD7150")]
	public SpeechBubbleController()
	{
	}

	// Token: 0x06002031 RID: 8241 RVA: 0x0000DE78 File Offset: 0x0000C078
	[Token(Token = "0x6002031")]
	[Address(RVA = "0xAD7250", Offset = "0xAD6250", VA = "0x180AD7250")]
	private bool <Setup>b__26_0(Human.InteractionDialogInstance item)
	{
		return default(bool);
	}

	// Token: 0x06002032 RID: 8242 RVA: 0x0000DE90 File Offset: 0x0000C090
	[Token(Token = "0x6002032")]
	[Address(RVA = "0xAD7250", Offset = "0xAD6250", VA = "0x180AD7250")]
	private bool <Setup>b__26_1(Human.InteractionDialogInstance item)
	{
		return default(bool);
	}

	// Token: 0x040029B7 RID: 10679
	[Token(Token = "0x40029B7")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x040029B8 RID: 10680
	[Token(Token = "0x40029B8")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform bubbleRect;

	// Token: 0x040029B9 RID: 10681
	[Token(Token = "0x40029B9")]
	[FieldOffset(Offset = "0x28")]
	public string actualString;

	// Token: 0x040029BA RID: 10682
	[Token(Token = "0x40029BA")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI text;

	// Token: 0x040029BB RID: 10683
	[Token(Token = "0x40029BB")]
	[FieldOffset(Offset = "0x38")]
	public float stringReveal;

	// Token: 0x040029BC RID: 10684
	[Token(Token = "0x40029BC")]
	[FieldOffset(Offset = "0x3C")]
	public int revealedChars;

	// Token: 0x040029BD RID: 10685
	[Token(Token = "0x40029BD")]
	[FieldOffset(Offset = "0x40")]
	public float distance;

	// Token: 0x040029BE RID: 10686
	[Token(Token = "0x40029BE")]
	[FieldOffset(Offset = "0x44")]
	public float timeStamp;

	// Token: 0x040029BF RID: 10687
	[Token(Token = "0x40029BF")]
	[FieldOffset(Offset = "0x48")]
	public float oncreenTime;

	// Token: 0x040029C0 RID: 10688
	[Token(Token = "0x40029C0")]
	[FieldOffset(Offset = "0x4C")]
	public float delayProgress;

	// Token: 0x040029C1 RID: 10689
	[Token(Token = "0x40029C1")]
	[FieldOffset(Offset = "0x50")]
	public float fadeProgress;

	// Token: 0x040029C2 RID: 10690
	[Token(Token = "0x40029C2")]
	[FieldOffset(Offset = "0x54")]
	private bool setFinalText;

	// Token: 0x040029C3 RID: 10691
	[Token(Token = "0x40029C3")]
	[FieldOffset(Offset = "0x58")]
	public SpeechController.QueueElement speech;

	// Token: 0x040029C4 RID: 10692
	[Token(Token = "0x40029C4")]
	[FieldOffset(Offset = "0x60")]
	public SpeechController speechController;

	// Token: 0x040029C5 RID: 10693
	[Token(Token = "0x40029C5")]
	[FieldOffset(Offset = "0x68")]
	public Vector2 sizeTreshold;

	// Token: 0x040029C6 RID: 10694
	[Token(Token = "0x40029C6")]
	[FieldOffset(Offset = "0x70")]
	public InterfaceController.AwarenessIcon awarenessIcon;

	// Token: 0x040029C7 RID: 10695
	[Token(Token = "0x40029C7")]
	[FieldOffset(Offset = "0x78")]
	public Image backgroundImg;

	// Token: 0x040029C8 RID: 10696
	[Token(Token = "0x40029C8")]
	[FieldOffset(Offset = "0x80")]
	public CanvasRenderer bgRend;

	// Token: 0x040029C9 RID: 10697
	[Token(Token = "0x40029C9")]
	[FieldOffset(Offset = "0x88")]
	public CanvasRenderer textRend;

	// Token: 0x040029CA RID: 10698
	[Token(Token = "0x40029CA")]
	[FieldOffset(Offset = "0x90")]
	public Vector2 bubbleDesiredSize;

	// Token: 0x040029CB RID: 10699
	[Token(Token = "0x40029CB")]
	[FieldOffset(Offset = "0x98")]
	public bool displayOnScreen;

	// Token: 0x040029CC RID: 10700
	[Token(Token = "0x40029CC")]
	[FieldOffset(Offset = "0x9C")]
	public Vector3 desiredPosition;

	// Token: 0x040029CD RID: 10701
	[Token(Token = "0x40029CD")]
	[FieldOffset(Offset = "0xA8")]
	public bool isPlayer;

	// Token: 0x040029CE RID: 10702
	[Token(Token = "0x40029CE")]
	[FieldOffset(Offset = "0xA9")]
	private bool firstPositionInit;

	// Token: 0x040029CF RID: 10703
	[Token(Token = "0x40029CF")]
	[FieldOffset(Offset = "0xB0")]
	private string[] words;

	// Token: 0x040029D0 RID: 10704
	[Token(Token = "0x40029D0")]
	[FieldOffset(Offset = "0xB8")]
	private int wordsRevealed;
}
