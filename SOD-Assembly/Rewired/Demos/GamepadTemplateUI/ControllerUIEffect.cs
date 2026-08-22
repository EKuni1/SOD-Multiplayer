using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos.GamepadTemplateUI
{
	// Token: 0x02000998 RID: 2456
	[Token(Token = "0x2000998")]
	public class ControllerUIEffect : MonoBehaviour
	{
		// Token: 0x060034BF RID: 13503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034BF")]
		[Address(RVA = "0xD5FB10", Offset = "0xD5EB10", VA = "0x180D5FB10")]
		private void Awake()
		{
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C0")]
		[Address(RVA = "0xD5FBD0", Offset = "0xD5EBD0", VA = "0x180D5FBD0")]
		public void Activate(float amount)
		{
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C1")]
		[Address(RVA = "0xD5FCC0", Offset = "0xD5ECC0", VA = "0x180D5FCC0")]
		public void Deactivate()
		{
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C2")]
		[Address(RVA = "0xD5FCF0", Offset = "0xD5ECF0", VA = "0x180D5FCF0")]
		private void RedrawImage()
		{
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C3")]
		[Address(RVA = "0xD5FD90", Offset = "0xD5ED90", VA = "0x180D5FD90")]
		public ControllerUIEffect()
		{
		}

		// Token: 0x04005148 RID: 20808
		[Token(Token = "0x4005148")]
		[FieldOffset(Offset = "0x18")]
		private Color _highlightColor;

		// Token: 0x04005149 RID: 20809
		[Token(Token = "0x4005149")]
		[FieldOffset(Offset = "0x28")]
		private Image _image;

		// Token: 0x0400514A RID: 20810
		[Token(Token = "0x400514A")]
		[FieldOffset(Offset = "0x30")]
		private Color _color;

		// Token: 0x0400514B RID: 20811
		[Token(Token = "0x400514B")]
		[FieldOffset(Offset = "0x40")]
		private Color _origColor;

		// Token: 0x0400514C RID: 20812
		[Token(Token = "0x400514C")]
		[FieldOffset(Offset = "0x50")]
		private bool _isActive;

		// Token: 0x0400514D RID: 20813
		[Token(Token = "0x400514D")]
		[FieldOffset(Offset = "0x54")]
		private float _highlightAmount;
	}
}
