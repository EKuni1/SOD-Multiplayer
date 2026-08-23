using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005C8 RID: 1480
[Token(Token = "0x20005C8")]
public class ToggleController : MonoBehaviour
{
	// Token: 0x06002084 RID: 8324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002084")]
	[Address(RVA = "0xADD630", Offset = "0xADC630", VA = "0x180ADD630")]
	private void Start()
	{
	}

	// Token: 0x06002085 RID: 8325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002085")]
	[Address(RVA = "0xADD760", Offset = "0xADC760", VA = "0x180ADD760")]
	public void SetIsOnWithoutNotify(bool val)
	{
	}

	// Token: 0x06002086 RID: 8326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002086")]
	[Address(RVA = "0xADD770", Offset = "0xADC770", VA = "0x180ADD770")]
	public void SetOn()
	{
	}

	// Token: 0x06002087 RID: 8327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002087")]
	[Address(RVA = "0xADD7A0", Offset = "0xADC7A0", VA = "0x180ADD7A0")]
	public void SetOff()
	{
	}

	// Token: 0x06002088 RID: 8328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002088")]
	[Address(RVA = "0xADD7D0", Offset = "0xADC7D0", VA = "0x180ADD7D0")]
	public void ButtonsVisualUpdate()
	{
	}

	// Token: 0x06002089 RID: 8329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002089")]
	[Address(RVA = "0xADDC90", Offset = "0xADCC90", VA = "0x180ADDC90")]
	public void OnValueChange()
	{
	}

	// Token: 0x0600208A RID: 8330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600208A")]
	[Address(RVA = "0xADDD10", Offset = "0xADCD10", VA = "0x180ADDD10")]
	public ToggleController()
	{
	}

	// Token: 0x0600208B RID: 8331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600208B")]
	[Address(RVA = "0xADD770", Offset = "0xADC770", VA = "0x180ADD770")]
	private void <Start>b__4_0()
	{
	}

	// Token: 0x0600208C RID: 8332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600208C")]
	[Address(RVA = "0xADD7A0", Offset = "0xADC7A0", VA = "0x180ADD7A0")]
	private void <Start>b__4_1()
	{
	}

	// Token: 0x04002A1D RID: 10781
	[Token(Token = "0x4002A1D")]
	[FieldOffset(Offset = "0x18")]
	public ButtonController onButton;

	// Token: 0x04002A1E RID: 10782
	[Token(Token = "0x4002A1E")]
	[FieldOffset(Offset = "0x20")]
	public ButtonController offButton;

	// Token: 0x04002A1F RID: 10783
	[Token(Token = "0x4002A1F")]
	[FieldOffset(Offset = "0x28")]
	public bool isOn;

	// Token: 0x04002A20 RID: 10784
	[Token(Token = "0x4002A20")]
	[FieldOffset(Offset = "0x30")]
	public string playerPrefsID;
}
