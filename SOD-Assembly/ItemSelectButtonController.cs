using System;
using Il2CppDummyDll;
using UnityEngine.UI;

// Token: 0x02000608 RID: 1544
[Token(Token = "0x2000608")]
public class ItemSelectButtonController : ButtonController
{
	// Token: 0x060021FE RID: 8702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021FE")]
	[Address(RVA = "0xB1F6C0", Offset = "0xB1E6C0", VA = "0x180B1F6C0")]
	public void Setup(Interactable newInteractable, InfoWindow newThisWindow)
	{
	}

	// Token: 0x060021FF RID: 8703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60021FF")]
	[Address(RVA = "0xB1F7C0", Offset = "0xB1E7C0", VA = "0x180B1F7C0", Slot = "11")]
	public override void UpdateButtonText()
	{
	}

	// Token: 0x06002200 RID: 8704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002200")]
	[Address(RVA = "0xB1F850", Offset = "0xB1E850", VA = "0x180B1F850", Slot = "17")]
	public override void OnLeftClick()
	{
	}

	// Token: 0x06002201 RID: 8705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002201")]
	[Address(RVA = "0xB1FBD0", Offset = "0xB1EBD0", VA = "0x180B1FBD0")]
	private void End()
	{
	}

	// Token: 0x06002202 RID: 8706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002202")]
	[Address(RVA = "0xA2C450", Offset = "0xA2B450", VA = "0x180A2C450")]
	public ItemSelectButtonController()
	{
	}

	// Token: 0x04002BAD RID: 11181
	[Token(Token = "0x4002BAD")]
	[FieldOffset(Offset = "0x1A8")]
	[NonSerialized]
	public Interactable obj;

	// Token: 0x04002BAE RID: 11182
	[Token(Token = "0x4002BAE")]
	[FieldOffset(Offset = "0x1B0")]
	public Image photo;

	// Token: 0x04002BAF RID: 11183
	[Token(Token = "0x4002BAF")]
	[FieldOffset(Offset = "0x1B8")]
	public InfoWindow thisWindow;
}
