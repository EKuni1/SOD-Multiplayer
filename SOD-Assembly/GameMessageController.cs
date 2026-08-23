using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000588 RID: 1416
[Token(Token = "0x2000588")]
public class GameMessageController : MonoBehaviour
{
	// Token: 0x06001EBE RID: 7870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EBE")]
	[Address(RVA = "0xA57600", Offset = "0xA56600", VA = "0x180A57600")]
	private void OnEnable()
	{
	}

	// Token: 0x06001EBF RID: 7871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EBF")]
	[Address(RVA = "0xA577D0", Offset = "0xA567D0", VA = "0x180A577D0")]
	public void Setup(Sprite graphic, string message, RectTransform moveToTarget, bool colourOverride = false, [Optional] Color col, GameMessageController.PingOnComplete newPing = GameMessageController.PingOnComplete.none, [Optional] Evidence keyTieEvidence, [Optional] List<Evidence.DataKey> newTiedKeys, int value = 0)
	{
	}

	// Token: 0x06001EC0 RID: 7872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EC0")]
	[Address(RVA = "0xA58A70", Offset = "0xA57A70", VA = "0x180A58A70")]
	public void SocialScoreVisualUpdate(int points)
	{
	}

	// Token: 0x06001EC1 RID: 7873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EC1")]
	[Address(RVA = "0xA59730", Offset = "0xA58730", VA = "0x180A59730")]
	private void Update()
	{
	}

	// Token: 0x06001EC2 RID: 7874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EC2")]
	[Address(RVA = "0xA5A900", Offset = "0xA59900", VA = "0x180A5A900")]
	public GameMessageController()
	{
	}

	// Token: 0x0400274F RID: 10063
	[Token(Token = "0x400274F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002750 RID: 10064
	[Token(Token = "0x4002750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string displayMessage;

	// Token: 0x04002751 RID: 10065
	[Token(Token = "0x4002751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI messageText;

	// Token: 0x04002752 RID: 10066
	[Token(Token = "0x4002752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Image img;

	// Token: 0x04002753 RID: 10067
	[Token(Token = "0x4002753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public JuiceController juice;

	// Token: 0x04002754 RID: 10068
	[Token(Token = "0x4002754")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform lensFlare;

	// Token: 0x04002755 RID: 10069
	[Token(Token = "0x4002755")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool isKeyMergeMessage;

	// Token: 0x04002756 RID: 10070
	[Token(Token = "0x4002756")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ProgressBarController keyMergeProgress;

	// Token: 0x04002757 RID: 10071
	[Token(Token = "0x4002757")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool isSocialCreditMessage;

	// Token: 0x04002758 RID: 10072
	[Token(Token = "0x4002758")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int originalCredit;

	// Token: 0x04002759 RID: 10073
	[Token(Token = "0x4002759")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Sprite checkedSprite;

	// Token: 0x0400275A RID: 10074
	[Token(Token = "0x400275A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Image puzzleBG;

	// Token: 0x0400275B RID: 10075
	[Token(Token = "0x400275B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Image namePiece;

	// Token: 0x0400275C RID: 10076
	[Token(Token = "0x400275C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Image photoPiece;

	// Token: 0x0400275D RID: 10077
	[Token(Token = "0x400275D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Image voicePiece;

	// Token: 0x0400275E RID: 10078
	[Token(Token = "0x400275E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Image fingerprintPiece;

	// Token: 0x0400275F RID: 10079
	[Token(Token = "0x400275F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TextMeshProUGUI socialCreditLevelText;

	// Token: 0x04002760 RID: 10080
	[Token(Token = "0x4002760")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameMessageController.PingOnComplete ping;

	// Token: 0x04002761 RID: 10081
	[Token(Token = "0x4002761")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float progress;

	// Token: 0x04002762 RID: 10082
	[Token(Token = "0x4002762")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float delayProgress;

	// Token: 0x04002763 RID: 10083
	[Token(Token = "0x4002763")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float fadeProgress;

	// Token: 0x04002764 RID: 10084
	[Token(Token = "0x4002764")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float revealProgress;

	// Token: 0x04002765 RID: 10085
	[Token(Token = "0x4002765")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float keyTieProgress;

	// Token: 0x04002766 RID: 10086
	[Token(Token = "0x4002766")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float socCreditProgress;

	// Token: 0x04002767 RID: 10087
	[Token(Token = "0x4002767")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private int tiedKeysValue;

	// Token: 0x04002768 RID: 10088
	[Token(Token = "0x4002768")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<CanvasRenderer> renderers;

	// Token: 0x04002769 RID: 10089
	[Token(Token = "0x4002769")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public RectTransform moveToTargetOnDestroy;

	// Token: 0x02000589 RID: 1417
	[Token(Token = "0x2000589")]
	public enum PingOnComplete
	{
		// Token: 0x0400276B RID: 10091
		[Token(Token = "0x400276B")]
		none,
		// Token: 0x0400276C RID: 10092
		[Token(Token = "0x400276C")]
		lockpicks,
		// Token: 0x0400276D RID: 10093
		[Token(Token = "0x400276D")]
		money
	}

	// Token: 0x0200058A RID: 1418
	[Token(Token = "0x200058A")]
	private sealed class <>c__DisplayClass29_0
	{
		// Token: 0x06001EC3 RID: 7875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass29_0()
		{
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		[Token(Token = "0x6001EC4")]
		[Address(RVA = "0xA5AA00", Offset = "0xA59A00", VA = "0x180A5AA00")]
		internal bool <Setup>b__0(Evidence.DataKey item)
		{
			return default(bool);
		}

		// Token: 0x0400276E RID: 10094
		[Token(Token = "0x400276E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Evidence keyTieEvidence;
	}
}
