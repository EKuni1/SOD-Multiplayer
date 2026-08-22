using System;
using DG.Tweening;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000655 RID: 1621
[Token(Token = "0x2000655")]
public class PrintOverlay : MonoBehaviour
{
	// Token: 0x060023BD RID: 9149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023BD")]
	[Address(RVA = "0xB711E0", Offset = "0xB701E0", VA = "0x180B711E0")]
	private void Awake()
	{
	}

	// Token: 0x060023BE RID: 9150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023BE")]
	[Address(RVA = "0xB715A0", Offset = "0xB705A0", VA = "0x180B715A0")]
	public void LateUpdate()
	{
	}

	// Token: 0x060023BF RID: 9151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023BF")]
	[Address(RVA = "0xB71AD0", Offset = "0xB70AD0", VA = "0x180B71AD0")]
	public void Setup(Transform trackThis, PrintController caller)
	{
	}

	// Token: 0x060023C0 RID: 9152 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
	[Token(Token = "0x60023C0")]
	[Address(RVA = "0xB71B80", Offset = "0xB70B80", VA = "0x180B71B80")]
	private bool IsFacingPlayer()
	{
		return default(bool);
	}

	// Token: 0x060023C1 RID: 9153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023C1")]
	[Address(RVA = "0xB71EC0", Offset = "0xB70EC0", VA = "0x180B71EC0")]
	public void RevealLetter()
	{
	}

	// Token: 0x060023C2 RID: 9154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023C2")]
	[Address(RVA = "0xB72590", Offset = "0xB71590", VA = "0x180B72590")]
	public void ResetLetter()
	{
	}

	// Token: 0x060023C3 RID: 9155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023C3")]
	[Address(RVA = "0xB72590", Offset = "0xB71590", VA = "0x180B72590")]
	private void OnEnable()
	{
	}

	// Token: 0x060023C4 RID: 9156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023C4")]
	[Address(RVA = "0xB72600", Offset = "0xB71600", VA = "0x180B72600")]
	public PrintOverlay()
	{
	}

	// Token: 0x060023C5 RID: 9157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023C5")]
	[Address(RVA = "0xB72650", Offset = "0xB71650", VA = "0x180B72650")]
	private void <RevealLetter>b__19_0()
	{
	}

	// Token: 0x060023C6 RID: 9158 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60023C6")]
	[Address(RVA = "0xB72780", Offset = "0xB71780", VA = "0x180B72780")]
	private void <RevealLetter>b__19_1()
	{
	}

	// Token: 0x04002DA7 RID: 11687
	[Token(Token = "0x4002DA7")]
	[FieldOffset(Offset = "0x18")]
	private Renderer _renderer;

	// Token: 0x04002DA8 RID: 11688
	[Token(Token = "0x4002DA8")]
	[FieldOffset(Offset = "0x20")]
	private Material _instancedMat;

	// Token: 0x04002DA9 RID: 11689
	[Token(Token = "0x4002DA9")]
	[FieldOffset(Offset = "0x28")]
	private TMP_Text _text;

	// Token: 0x04002DAA RID: 11690
	[Token(Token = "0x4002DAA")]
	[FieldOffset(Offset = "0x30")]
	private Image _image;

	// Token: 0x04002DAB RID: 11691
	[Token(Token = "0x4002DAB")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform _rectTransform;

	// Token: 0x04002DAC RID: 11692
	[Token(Token = "0x4002DAC")]
	[FieldOffset(Offset = "0x40")]
	public float speed;

	// Token: 0x04002DAD RID: 11693
	[Token(Token = "0x4002DAD")]
	[FieldOffset(Offset = "0x44")]
	public Ease ease;

	// Token: 0x04002DAE RID: 11694
	[Token(Token = "0x4002DAE")]
	[FieldOffset(Offset = "0x48")]
	public float beamSpeed;

	// Token: 0x04002DAF RID: 11695
	[Token(Token = "0x4002DAF")]
	[FieldOffset(Offset = "0x4C")]
	public Ease beamEase;

	// Token: 0x04002DB0 RID: 11696
	[Token(Token = "0x4002DB0")]
	[FieldOffset(Offset = "0x50")]
	private Transform _trackThis;

	// Token: 0x04002DB1 RID: 11697
	[Token(Token = "0x4002DB1")]
	[FieldOffset(Offset = "0x58")]
	private Camera _mainCam;

	// Token: 0x04002DB2 RID: 11698
	[Token(Token = "0x4002DB2")]
	[FieldOffset(Offset = "0x60")]
	private Canvas _canvas;

	// Token: 0x04002DB3 RID: 11699
	[Token(Token = "0x4002DB3")]
	[FieldOffset(Offset = "0x68")]
	private PrintController _printControllerReference;

	// Token: 0x04002DB4 RID: 11700
	[Token(Token = "0x4002DB4")]
	[FieldOffset(Offset = "0x70")]
	private bool _isRevealed;

	// Token: 0x04002DB5 RID: 11701
	[Token(Token = "0x4002DB5")]
	[FieldOffset(Offset = "0x71")]
	private bool _facingPlayer;
}
