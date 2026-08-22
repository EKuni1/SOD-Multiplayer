using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200038B RID: 907
[Token(Token = "0x200038B")]
public class ModEntryController : MonoBehaviour
{
	// Token: 0x06001465 RID: 5221 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001465")]
	[Address(RVA = "0x7B6AC0", Offset = "0x7B5AC0", VA = "0x1807B6AC0")]
	public void Setup(ModSettingsData newMod)
	{
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001466")]
	[Address(RVA = "0x7B6CE0", Offset = "0x7B5CE0", VA = "0x1807B6CE0")]
	private void Update()
	{
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001467")]
	[Address(RVA = "0x7B7210", Offset = "0x7B6210", VA = "0x1807B7210")]
	public void StateRefresh()
	{
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001468")]
	[Address(RVA = "0x7B7AE0", Offset = "0x7B6AE0", VA = "0x1807B7AE0")]
	public void OnEnableDisableButton()
	{
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001469")]
	[Address(RVA = "0x7B7CA0", Offset = "0x7B6CA0", VA = "0x1807B7CA0")]
	public void OnMoveDownButton()
	{
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600146A")]
	[Address(RVA = "0x7B8140", Offset = "0x7B7140", VA = "0x1807B8140")]
	public void OnMoveUpButton()
	{
	}

	// Token: 0x0600146B RID: 5227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600146B")]
	[Address(RVA = "0x7B8500", Offset = "0x7B7500", VA = "0x1807B8500")]
	public void OnUploadButton()
	{
	}

	// Token: 0x0600146C RID: 5228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600146C")]
	[Address(RVA = "0x7B8850", Offset = "0x7B7850", VA = "0x1807B8850")]
	public void OnUploadConfirm()
	{
	}

	// Token: 0x0600146D RID: 5229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600146D")]
	[Address(RVA = "0x7B8BA0", Offset = "0x7B7BA0", VA = "0x1807B8BA0")]
	public void OnModDocumentation()
	{
	}

	// Token: 0x0600146E RID: 5230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600146E")]
	[Address(RVA = "0x7B8DF0", Offset = "0x7B7DF0", VA = "0x1807B8DF0")]
	public void OnUploadCancel()
	{
	}

	// Token: 0x0600146F RID: 5231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600146F")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ModEntryController()
	{
	}

	// Token: 0x040018DD RID: 6365
	[Token(Token = "0x40018DD")]
	[FieldOffset(Offset = "0x18")]
	public ModSettingsData mod;

	// Token: 0x040018DE RID: 6366
	[Token(Token = "0x40018DE")]
	[FieldOffset(Offset = "0x20")]
	public Sprite updatePendingSprite;

	// Token: 0x040018DF RID: 6367
	[Token(Token = "0x40018DF")]
	[FieldOffset(Offset = "0x28")]
	public Sprite localSprite;

	// Token: 0x040018E0 RID: 6368
	[Token(Token = "0x40018E0")]
	[FieldOffset(Offset = "0x30")]
	public Sprite modioSprite;

	// Token: 0x040018E1 RID: 6369
	[Token(Token = "0x40018E1")]
	[FieldOffset(Offset = "0x38")]
	public Sprite workshopSprite;

	// Token: 0x040018E2 RID: 6370
	[Token(Token = "0x40018E2")]
	[FieldOffset(Offset = "0x40")]
	public float updateTimer;

	// Token: 0x040018E3 RID: 6371
	[Token(Token = "0x40018E3")]
	[FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI nameText;

	// Token: 0x040018E4 RID: 6372
	[Token(Token = "0x40018E4")]
	[FieldOffset(Offset = "0x50")]
	public Image iconImg;

	// Token: 0x040018E5 RID: 6373
	[Token(Token = "0x40018E5")]
	[FieldOffset(Offset = "0x58")]
	public ButtonController enableDisableButton;

	// Token: 0x040018E6 RID: 6374
	[Token(Token = "0x40018E6")]
	[FieldOffset(Offset = "0x60")]
	public ButtonController moveUpButton;

	// Token: 0x040018E7 RID: 6375
	[Token(Token = "0x40018E7")]
	[FieldOffset(Offset = "0x68")]
	public ButtonController moveDownButton;

	// Token: 0x040018E8 RID: 6376
	[Token(Token = "0x40018E8")]
	[FieldOffset(Offset = "0x70")]
	public ButtonController uploadButton;

	// Token: 0x040018E9 RID: 6377
	[Token(Token = "0x40018E9")]
	[FieldOffset(Offset = "0x78")]
	public TooltipController tooltip;
}
