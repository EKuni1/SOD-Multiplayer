using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos.GamepadTemplateUI
{
	// Token: 0x02000999 RID: 2457
	[Token(Token = "0x2000999")]
	public class ControllerUIElement : MonoBehaviour
	{
		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x00012618 File Offset: 0x00010818
		[Token(Token = "0x17000547")]
		private bool hasEffects
		{
			[Token(Token = "0x60034C4")]
			[Address(RVA = "0xD5FDE0", Offset = "0xD5EDE0", VA = "0x180D5FDE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C5")]
		[Address(RVA = "0xD5FFC0", Offset = "0xD5EFC0", VA = "0x180D5FFC0")]
		private void Awake()
		{
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C6")]
		[Address(RVA = "0xD60090", Offset = "0xD5F090", VA = "0x180D60090")]
		public void Activate(float amount)
		{
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C7")]
		[Address(RVA = "0xD60710", Offset = "0xD5F710", VA = "0x180D60710")]
		public void Deactivate()
		{
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C8")]
		[Address(RVA = "0xD60AC0", Offset = "0xD5FAC0", VA = "0x180D60AC0")]
		public void SetLabel(string text, AxisRange labelType)
		{
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C9")]
		[Address(RVA = "0xD60D60", Offset = "0xD5FD60", VA = "0x180D60D60")]
		public void ClearLabels()
		{
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CA")]
		[Address(RVA = "0xD611E0", Offset = "0xD601E0", VA = "0x180D611E0")]
		private void RedrawImage()
		{
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034CB")]
		[Address(RVA = "0xD61220", Offset = "0xD60220", VA = "0x180D61220")]
		public ControllerUIElement()
		{
		}

		// Token: 0x0400514E RID: 20814
		[Token(Token = "0x400514E")]
		[FieldOffset(Offset = "0x18")]
		private Color _highlightColor;

		// Token: 0x0400514F RID: 20815
		[Token(Token = "0x400514F")]
		[FieldOffset(Offset = "0x28")]
		private ControllerUIEffect _positiveUIEffect;

		// Token: 0x04005150 RID: 20816
		[Token(Token = "0x4005150")]
		[FieldOffset(Offset = "0x30")]
		private ControllerUIEffect _negativeUIEffect;

		// Token: 0x04005151 RID: 20817
		[Token(Token = "0x4005151")]
		[FieldOffset(Offset = "0x38")]
		private Text _label;

		// Token: 0x04005152 RID: 20818
		[Token(Token = "0x4005152")]
		[FieldOffset(Offset = "0x40")]
		private Text _positiveLabel;

		// Token: 0x04005153 RID: 20819
		[Token(Token = "0x4005153")]
		[FieldOffset(Offset = "0x48")]
		private Text _negativeLabel;

		// Token: 0x04005154 RID: 20820
		[Token(Token = "0x4005154")]
		[FieldOffset(Offset = "0x50")]
		private ControllerUIElement[] _childElements;

		// Token: 0x04005155 RID: 20821
		[Token(Token = "0x4005155")]
		[FieldOffset(Offset = "0x58")]
		private Image _image;

		// Token: 0x04005156 RID: 20822
		[Token(Token = "0x4005156")]
		[FieldOffset(Offset = "0x60")]
		private Color _color;

		// Token: 0x04005157 RID: 20823
		[Token(Token = "0x4005157")]
		[FieldOffset(Offset = "0x70")]
		private Color _origColor;

		// Token: 0x04005158 RID: 20824
		[Token(Token = "0x4005158")]
		[FieldOffset(Offset = "0x80")]
		private bool _isActive;

		// Token: 0x04005159 RID: 20825
		[Token(Token = "0x4005159")]
		[FieldOffset(Offset = "0x84")]
		private float _highlightAmount;
	}
}
