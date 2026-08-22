using System;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

// Token: 0x020006A6 RID: 1702
[Token(Token = "0x20006A6")]
public class VirtualKeyboardButtonOverride : MonoBehaviour
{
	// Token: 0x060025CB RID: 9675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025CB")]
	[Address(RVA = "0xBD3D40", Offset = "0xBD2D40", VA = "0x180BD3D40")]
	private void Awake()
	{
	}

	// Token: 0x060025CC RID: 9676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025CC")]
	[Address(RVA = "0xBD3F00", Offset = "0xBD2F00", VA = "0x180BD3F00")]
	private void Update()
	{
	}

	// Token: 0x060025CD RID: 9677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025CD")]
	[Address(RVA = "0xBD4110", Offset = "0xBD3110", VA = "0x180BD4110")]
	private void OnEnable()
	{
	}

	// Token: 0x060025CE RID: 9678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025CE")]
	[Address(RVA = "0xBD4210", Offset = "0xBD3210", VA = "0x180BD4210")]
	private void OnDisable()
	{
	}

	// Token: 0x060025CF RID: 9679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025CF")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public VirtualKeyboardButtonOverride()
	{
	}

	// Token: 0x04003031 RID: 12337
	[Token(Token = "0x4003031")]
	[FieldOffset(Offset = "0x18")]
	public InteractablePreset.InteractionKey key;

	// Token: 0x04003032 RID: 12338
	[Token(Token = "0x4003032")]
	[FieldOffset(Offset = "0x20")]
	private ButtonController _buttonController;

	// Token: 0x04003033 RID: 12339
	[Token(Token = "0x4003033")]
	[FieldOffset(Offset = "0x28")]
	public bool performActionWithKey;

	// Token: 0x04003034 RID: 12340
	[Token(Token = "0x4003034")]
	[FieldOffset(Offset = "0x30")]
	private Rewired.Player _player;

	// Token: 0x04003035 RID: 12341
	[Token(Token = "0x4003035")]
	[FieldOffset(Offset = "0x38")]
	private string _originalText;
}
