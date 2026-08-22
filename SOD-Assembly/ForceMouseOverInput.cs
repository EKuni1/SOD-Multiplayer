using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000587 RID: 1415
[Token(Token = "0x2000587")]
public class ForceMouseOverInput : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>
{
	// Token: 0x06001EB6 RID: 7862 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EB6")]
	[Address(RVA = "0xA56830", Offset = "0xA55830", VA = "0x180A56830")]
	private void Awake()
	{
	}

	// Token: 0x06001EB7 RID: 7863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EB7")]
	[Address(RVA = "0xA569C0", Offset = "0xA559C0", VA = "0x180A569C0", Slot = "4")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x06001EB8 RID: 7864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EB8")]
	[Address(RVA = "0xA56A70", Offset = "0xA55A70", VA = "0x180A56A70")]
	private void OnEnable()
	{
	}

	// Token: 0x06001EB9 RID: 7865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EB9")]
	[Address(RVA = "0xA56C40", Offset = "0xA55C40", VA = "0x180A56C40", Slot = "5")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x06001EBA RID: 7866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EBA")]
	[Address(RVA = "0xA56D80", Offset = "0xA55D80", VA = "0x180A56D80")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001EBB RID: 7867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EBB")]
	[Address(RVA = "0xA56F20", Offset = "0xA55F20", VA = "0x180A56F20")]
	private void OnDisable()
	{
	}

	// Token: 0x06001EBC RID: 7868 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EBC")]
	[Address(RVA = "0xA57100", Offset = "0xA56100", VA = "0x180A57100", Slot = "6")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x06001EBD RID: 7869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001EBD")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ForceMouseOverInput()
	{
	}

	// Token: 0x0400274B RID: 10059
	[Token(Token = "0x400274B")]
	[FieldOffset(Offset = "0x18")]
	public int cursorType;

	// Token: 0x0400274C RID: 10060
	[Token(Token = "0x400274C")]
	[FieldOffset(Offset = "0x1C")]
	public bool mouseOver;

	// Token: 0x0400274D RID: 10061
	[Token(Token = "0x400274D")]
	[FieldOffset(Offset = "0x20")]
	private TMP_InputField _inputField;

	// Token: 0x0400274E RID: 10062
	[Token(Token = "0x400274E")]
	[FieldOffset(Offset = "0x28")]
	private bool _isMultiline;
}
