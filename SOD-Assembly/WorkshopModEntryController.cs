using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020003A2 RID: 930
[Token(Token = "0x20003A2")]
public class WorkshopModEntryController : MonoBehaviour
{
	// Token: 0x060014CE RID: 5326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014CE")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void Setup()
	{
	}

	// Token: 0x060014CF RID: 5327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014CF")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public WorkshopModEntryController()
	{
	}

	// Token: 0x0400194B RID: 6475
	[Token(Token = "0x400194B")]
	[FieldOffset(Offset = "0x18")]
	public ModSettingsData mod;

	// Token: 0x0400194C RID: 6476
	[Token(Token = "0x400194C")]
	[FieldOffset(Offset = "0x20")]
	public Sprite enabledSprite;

	// Token: 0x0400194D RID: 6477
	[Token(Token = "0x400194D")]
	[FieldOffset(Offset = "0x28")]
	public Sprite disabledSprite;

	// Token: 0x0400194E RID: 6478
	[Token(Token = "0x400194E")]
	[FieldOffset(Offset = "0x30")]
	public Sprite updatePendingSprite;

	// Token: 0x0400194F RID: 6479
	[Token(Token = "0x400194F")]
	[FieldOffset(Offset = "0x38")]
	public float updateTimer;

	// Token: 0x04001950 RID: 6480
	[Token(Token = "0x4001950")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI nameText;

	// Token: 0x04001951 RID: 6481
	[Token(Token = "0x4001951")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI versionText;

	// Token: 0x04001952 RID: 6482
	[Token(Token = "0x4001952")]
	[FieldOffset(Offset = "0x50")]
	public Image iconImg;

	// Token: 0x04001953 RID: 6483
	[Token(Token = "0x4001953")]
	[FieldOffset(Offset = "0x58")]
	public ButtonController enableDisableButton;

	// Token: 0x04001954 RID: 6484
	[Token(Token = "0x4001954")]
	[FieldOffset(Offset = "0x60")]
	public ButtonController moveUpButton;

	// Token: 0x04001955 RID: 6485
	[Token(Token = "0x4001955")]
	[FieldOffset(Offset = "0x68")]
	public ButtonController moveDownButton;
}
