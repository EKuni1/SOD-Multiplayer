using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000629 RID: 1577
[Token(Token = "0x2000629")]
public class WindowRenameTitleController : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>
{
	// Token: 0x060022A0 RID: 8864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A0")]
	[Address(RVA = "0xB3D950", Offset = "0xB3C950", VA = "0x180B3D950", Slot = "7")]
	public virtual void OnPointerEnter(PointerEventData eventData)
	{
	}

	// Token: 0x060022A1 RID: 8865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A1")]
	[Address(RVA = "0xB3D9D0", Offset = "0xB3C9D0", VA = "0x180B3D9D0", Slot = "8")]
	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	// Token: 0x060022A2 RID: 8866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A2")]
	[Address(RVA = "0xB3DB00", Offset = "0xB3CB00", VA = "0x180B3DB00")]
	private void OnDestroy()
	{
	}

	// Token: 0x060022A3 RID: 8867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A3")]
	[Address(RVA = "0xB3DBB0", Offset = "0xB3CBB0", VA = "0x180B3DBB0", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	// Token: 0x060022A4 RID: 8868 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A4")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "9")]
	public virtual void OnLeftClick()
	{
	}

	// Token: 0x060022A5 RID: 8869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A5")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "10")]
	public virtual void OnRightClick()
	{
	}

	// Token: 0x060022A6 RID: 8870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A6")]
	[Address(RVA = "0xB3DE20", Offset = "0xB3CE20", VA = "0x180B3DE20", Slot = "11")]
	public virtual void OnLeftDoubleClick()
	{
	}

	// Token: 0x060022A7 RID: 8871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A7")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "12")]
	public virtual void OnRightDoubleClick()
	{
	}

	// Token: 0x060022A8 RID: 8872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022A8")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public WindowRenameTitleController()
	{
	}

	// Token: 0x04002C51 RID: 11345
	[Token(Token = "0x4002C51")]
	[FieldOffset(Offset = "0x18")]
	public InfoWindow window;

	// Token: 0x04002C52 RID: 11346
	[Token(Token = "0x4002C52")]
	[FieldOffset(Offset = "0x20")]
	public TMP_InputField inputField;

	// Token: 0x04002C53 RID: 11347
	[Token(Token = "0x4002C53")]
	[FieldOffset(Offset = "0x28")]
	private float lastLeftClick;

	// Token: 0x04002C54 RID: 11348
	[Token(Token = "0x4002C54")]
	[FieldOffset(Offset = "0x2C")]
	private float lastRightClick;
}
