using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020006A9 RID: 1705
[Token(Token = "0x20006A9")]
public class VirtualSpaceBarMemory : MonoBehaviour, IEnumerator<object>, IDisposable
{
	// Token: 0x060025F6 RID: 9718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025F6")]
	[Address(RVA = "0xBD8130", Offset = "0xBD7130", VA = "0x180BD8130")]
	private void Awake()
	{
	}

	// Token: 0x060025F7 RID: 9719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025F7")]
	[Address(RVA = "0xBD81C0", Offset = "0xBD71C0", VA = "0x180BD81C0")]
	private void Start()
	{
	}

	// Token: 0x060025F8 RID: 9720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025F8")]
	[Address(RVA = "0xBD8260", Offset = "0xBD7260", VA = "0x180BD8260")]
	private void Update()
	{
	}

	// Token: 0x060025F9 RID: 9721 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025F9")]
	[Address(RVA = "0xBD83A0", Offset = "0xBD73A0", VA = "0x180BD83A0")]
	private void OnDisable()
	{
	}

	// Token: 0x060025FA RID: 9722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025FA")]
	[Address(RVA = "0xBD8400", Offset = "0xBD7400", VA = "0x180BD8400")]
	private void GetLastVirtualKeyboardCharacterButton()
	{
	}

	// Token: 0x060025FB RID: 9723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025FB")]
	[Address(RVA = "0xBD8670", Offset = "0xBD7670", VA = "0x180BD8670", Slot = "4")]
	public void OnSelect(BaseEventData eventData)
	{
	}

	// Token: 0x060025FC RID: 9724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025FC")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public VirtualSpaceBarMemory()
	{
	}

	// Token: 0x04003056 RID: 12374
	[Token(Token = "0x4003056")]
	[FieldOffset(Offset = "0x18")]
	private ButtonController _buttonController;

	// Token: 0x04003057 RID: 12375
	[Token(Token = "0x4003057")]
	[FieldOffset(Offset = "0x20")]
	private Rewired.Player _player;

	// Token: 0x04003058 RID: 12376
	[Token(Token = "0x4003058")]
	[FieldOffset(Offset = "0x28")]
	public GameObject lastSelectedButton;
}
