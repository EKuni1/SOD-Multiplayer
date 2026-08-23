using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000633 RID: 1587
[Token(Token = "0x2000633")]
public class NotificationController : MonoBehaviour
{
	// Token: 0x060022D1 RID: 8913 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022D1")]
	[Address(RVA = "0xB400B0", Offset = "0xB3F0B0", VA = "0x180B400B0")]
	private void OnEnable()
	{
	}

	// Token: 0x060022D2 RID: 8914 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022D2")]
	[Address(RVA = "0xB400C0", Offset = "0xB3F0C0", VA = "0x180B400C0")]
	public void AddNotification(int val)
	{
	}

	// Token: 0x060022D3 RID: 8915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022D3")]
	[Address(RVA = "0xB400D0", Offset = "0xB3F0D0", VA = "0x180B400D0")]
	public void SetNotifications(int val)
	{
	}

	// Token: 0x060022D4 RID: 8916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022D4")]
	[Address(RVA = "0xB400E0", Offset = "0xB3F0E0", VA = "0x180B400E0")]
	public void UpdateNotifications()
	{
	}

	// Token: 0x060022D5 RID: 8917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022D5")]
	[Address(RVA = "0xB406C0", Offset = "0xB3F6C0", VA = "0x180B406C0")]
	private void Update()
	{
	}

	// Token: 0x060022D6 RID: 8918 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60022D6")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public NotificationController()
	{
	}

	// Token: 0x04002C9B RID: 11419
	[Token(Token = "0x4002C9B")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI numberText;

	// Token: 0x04002C9C RID: 11420
	[Token(Token = "0x4002C9C")]
	[FieldOffset(Offset = "0x20")]
	public JuiceController juice;

	// Token: 0x04002C9D RID: 11421
	[Token(Token = "0x4002C9D")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform glowRect;

	// Token: 0x04002C9E RID: 11422
	[Token(Token = "0x4002C9E")]
	[FieldOffset(Offset = "0x30")]
	public Image glowImg;

	// Token: 0x04002C9F RID: 11423
	[Token(Token = "0x4002C9F")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform HUDNotificationsIcon;

	// Token: 0x04002CA0 RID: 11424
	[Token(Token = "0x4002CA0")]
	[FieldOffset(Offset = "0x40")]
	private float time;

	// Token: 0x04002CA1 RID: 11425
	[Token(Token = "0x4002CA1")]
	[FieldOffset(Offset = "0x44")]
	public int notifications;
}
