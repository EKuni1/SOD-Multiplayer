using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200002C RID: 44
[Token(Token = "0x200002C")]
public class CardPreview : MonoBehaviour
{
	// Token: 0x1700001D RID: 29
	// (get) Token: 0x060001B8 RID: 440 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001D")]
	public static CardPreview Instance
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x5C7980", Offset = "0x5C6980", VA = "0x1805C7980")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x5C79C0", Offset = "0x5C69C0", VA = "0x1805C79C0")]
		private set
		{
		}
	}

	// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x5C7A60", Offset = "0x5C6A60", VA = "0x1805C7A60")]
	private void Awake()
	{
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x5C7EA0", Offset = "0x5C6EA0", VA = "0x1805C7EA0")]
	public void ShowCardInfo(Wizcard wizcard)
	{
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x5C8430", Offset = "0x5C7430", VA = "0x1805C8430")]
	public void HideCardInfo()
	{
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public CardPreview()
	{
	}

	// Token: 0x04000108 RID: 264
	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x0")]
	private static CardPreview <Instance>k__BackingField;

	// Token: 0x04000109 RID: 265
	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x18")]
	public Image cardImage;

	// Token: 0x0400010A RID: 266
	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI descriptionText;

	// Token: 0x0400010B RID: 267
	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI Attack;

	// Token: 0x0400010C RID: 268
	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI Health;

	// Token: 0x0400010D RID: 269
	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI Mana;

	// Token: 0x0400010E RID: 270
	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x40")]
	public GameObject[] infoObjects;

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x48")]
	public Wizcard showingWizcard;
}
