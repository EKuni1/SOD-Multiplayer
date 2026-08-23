using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000685 RID: 1669
[Token(Token = "0x2000685")]
public class PasscodesEntryController : MonoBehaviour
{
	// Token: 0x060024F8 RID: 9464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024F8")]
	[Address(RVA = "0xBAC070", Offset = "0xBAB070", VA = "0x180BAC070")]
	public void Setup(GameplayController.Passcode newPasscode)
	{
	}

	// Token: 0x060024F9 RID: 9465 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024F9")]
	[Address(RVA = "0xBAC7A0", Offset = "0xBAB7A0", VA = "0x180BAC7A0")]
	public void VisualUpdate()
	{
	}

	// Token: 0x060024FA RID: 9466 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024FA")]
	[Address(RVA = "0xBACDC0", Offset = "0xBABDC0", VA = "0x180BACDC0")]
	public void ActiveCodeInputCheck(KeypadController keypad)
	{
	}

	// Token: 0x060024FB RID: 9467 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024FB")]
	[Address(RVA = "0xBACFC0", Offset = "0xBABFC0", VA = "0x180BACFC0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060024FC RID: 9468 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024FC")]
	[Address(RVA = "0xBAD190", Offset = "0xBAC190", VA = "0x180BAD190")]
	public void OpenEvidence()
	{
	}

	// Token: 0x060024FD RID: 9469 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024FD")]
	[Address(RVA = "0xBAD260", Offset = "0xBAC260", VA = "0x180BAD260")]
	public void LocateOnMap()
	{
	}

	// Token: 0x060024FE RID: 9470 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024FE")]
	[Address(RVA = "0xBAD480", Offset = "0xBAC480", VA = "0x180BAD480")]
	public void EnterCode()
	{
	}

	// Token: 0x060024FF RID: 9471 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024FF")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public PasscodesEntryController()
	{
	}

	// Token: 0x06002500 RID: 9472 RVA: 0x0000EB38 File Offset: 0x0000CD38
	[Token(Token = "0x6002500")]
	[Address(RVA = "0xBAD700", Offset = "0xBAC700", VA = "0x180BAD700")]
	private bool <Setup>b__13_0(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x04002F14 RID: 12052
	[Token(Token = "0x4002F14")]
	[FieldOffset(Offset = "0x18")]
	public NewAddress address;

	// Token: 0x04002F15 RID: 12053
	[Token(Token = "0x4002F15")]
	[FieldOffset(Offset = "0x20")]
	public NewRoom room;

	// Token: 0x04002F16 RID: 12054
	[Token(Token = "0x4002F16")]
	[FieldOffset(Offset = "0x28")]
	public Human human;

	// Token: 0x04002F17 RID: 12055
	[Token(Token = "0x4002F17")]
	[FieldOffset(Offset = "0x30")]
	public Interactable interactable;

	// Token: 0x04002F18 RID: 12056
	[Token(Token = "0x4002F18")]
	[FieldOffset(Offset = "0x38")]
	public Evidence evidence;

	// Token: 0x04002F19 RID: 12057
	[Token(Token = "0x4002F19")]
	[FieldOffset(Offset = "0x40")]
	public GameplayController.Passcode passcode;

	// Token: 0x04002F1A RID: 12058
	[Token(Token = "0x4002F1A")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI text;

	// Token: 0x04002F1B RID: 12059
	[Token(Token = "0x4002F1B")]
	[FieldOffset(Offset = "0x50")]
	public ButtonController locateOnMapButton;

	// Token: 0x04002F1C RID: 12060
	[Token(Token = "0x4002F1C")]
	[FieldOffset(Offset = "0x58")]
	public ButtonController enterCodeButton;

	// Token: 0x04002F1D RID: 12061
	[Token(Token = "0x4002F1D")]
	[FieldOffset(Offset = "0x60")]
	public RawImage evidenceImage;

	// Token: 0x04002F1E RID: 12062
	[Token(Token = "0x4002F1E")]
	[FieldOffset(Offset = "0x68")]
	public Image icon;

	// Token: 0x04002F1F RID: 12063
	[Token(Token = "0x4002F1F")]
	[FieldOffset(Offset = "0x70")]
	public string nameString;

	// Token: 0x04002F20 RID: 12064
	[Token(Token = "0x4002F20")]
	[FieldOffset(Offset = "0x78")]
	public string passcodeString;
}
