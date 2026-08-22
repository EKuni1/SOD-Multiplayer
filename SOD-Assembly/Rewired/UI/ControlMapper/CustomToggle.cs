using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000938 RID: 2360
	[Token(Token = "0x2000938")]
	public class CustomToggle : Toggle, IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x0600318C RID: 12684 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600318D RID: 12685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045D")]
		public Sprite disabledHighlightedSprite
		{
			[Token(Token = "0x600318C")]
			[Address(RVA = "0xD175C0", Offset = "0xD165C0", VA = "0x180D175C0", Slot = "51")]
			get
			{
				return null;
			}
			[Token(Token = "0x600318D")]
			[Address(RVA = "0xD175D0", Offset = "0xD165D0", VA = "0x180D175D0", Slot = "52")]
			set
			{
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x0600318E RID: 12686 RVA: 0x00011C40 File Offset: 0x0000FE40
		// (set) Token: 0x0600318F RID: 12687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045E")]
		public Color disabledHighlightedColor
		{
			[Token(Token = "0x600318E")]
			[Address(RVA = "0xD24F60", Offset = "0xD23F60", VA = "0x180D24F60", Slot = "53")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600318F")]
			[Address(RVA = "0xD24F70", Offset = "0xD23F70", VA = "0x180D24F70", Slot = "54")]
			set
			{
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06003190 RID: 12688 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003191 RID: 12689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045F")]
		public string disabledHighlightedTrigger
		{
			[Token(Token = "0x6003190")]
			[Address(RVA = "0xD24F80", Offset = "0xD23F80", VA = "0x180D24F80", Slot = "55")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003191")]
			[Address(RVA = "0xD24F90", Offset = "0xD23F90", VA = "0x180D24F90", Slot = "56")]
			set
			{
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x00011C58 File Offset: 0x0000FE58
		// (set) Token: 0x06003193 RID: 12691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000460")]
		public bool autoNavUp
		{
			[Token(Token = "0x6003192")]
			[Address(RVA = "0xD24FF0", Offset = "0xD23FF0", VA = "0x180D24FF0", Slot = "57")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003193")]
			[Address(RVA = "0xD25000", Offset = "0xD24000", VA = "0x180D25000", Slot = "58")]
			set
			{
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x00011C70 File Offset: 0x0000FE70
		// (set) Token: 0x06003195 RID: 12693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000461")]
		public bool autoNavDown
		{
			[Token(Token = "0x6003194")]
			[Address(RVA = "0xD25010", Offset = "0xD24010", VA = "0x180D25010", Slot = "59")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003195")]
			[Address(RVA = "0xD25020", Offset = "0xD24020", VA = "0x180D25020", Slot = "60")]
			set
			{
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x00011C88 File Offset: 0x0000FE88
		// (set) Token: 0x06003197 RID: 12695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000462")]
		public bool autoNavLeft
		{
			[Token(Token = "0x6003196")]
			[Address(RVA = "0xD25030", Offset = "0xD24030", VA = "0x180D25030", Slot = "61")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003197")]
			[Address(RVA = "0xD25040", Offset = "0xD24040", VA = "0x180D25040", Slot = "62")]
			set
			{
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x00011CA0 File Offset: 0x0000FEA0
		// (set) Token: 0x06003199 RID: 12697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000463")]
		public bool autoNavRight
		{
			[Token(Token = "0x6003198")]
			[Address(RVA = "0xD25050", Offset = "0xD24050", VA = "0x180D25050", Slot = "63")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003199")]
			[Address(RVA = "0xD25060", Offset = "0xD24060", VA = "0x180D25060", Slot = "64")]
			set
			{
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x0600319A RID: 12698 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		[Token(Token = "0x17000464")]
		private bool isDisabled
		{
			[Token(Token = "0x600319A")]
			[Address(RVA = "0xD21870", Offset = "0xD20870", VA = "0x180D21870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000076 RID: 118
		// (add) Token: 0x0600319B RID: 12699 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600319C RID: 12700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000076")]
		private event UnityAction _CancelEvent
		{
			[Token(Token = "0x600319B")]
			[Address(RVA = "0xD25070", Offset = "0xD24070", VA = "0x180D25070")]
			add
			{
			}
			[Token(Token = "0x600319C")]
			[Address(RVA = "0xD25170", Offset = "0xD24170", VA = "0x180D25170")]
			remove
			{
			}
		}

		// Token: 0x14000077 RID: 119
		// (add) Token: 0x0600319D RID: 12701 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600319E RID: 12702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000077")]
		public event UnityAction CancelEvent
		{
			[Token(Token = "0x600319D")]
			[Address(RVA = "0xD25070", Offset = "0xD24070", VA = "0x180D25070", Slot = "65")]
			add
			{
			}
			[Token(Token = "0x600319E")]
			[Address(RVA = "0xD25170", Offset = "0xD24170", VA = "0x180D25170", Slot = "66")]
			remove
			{
			}
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600319F")]
		[Address(RVA = "0xD25270", Offset = "0xD24270", VA = "0x180D25270", Slot = "27")]
		public override Selectable FindSelectableOnLeft()
		{
			return null;
		}

		// Token: 0x060031A0 RID: 12704 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60031A0")]
		[Address(RVA = "0xD253A0", Offset = "0xD243A0", VA = "0x180D253A0", Slot = "28")]
		public override Selectable FindSelectableOnRight()
		{
			return null;
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60031A1")]
		[Address(RVA = "0xD254D0", Offset = "0xD244D0", VA = "0x180D254D0", Slot = "29")]
		public override Selectable FindSelectableOnUp()
		{
			return null;
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60031A2")]
		[Address(RVA = "0xD25600", Offset = "0xD24600", VA = "0x180D25600", Slot = "30")]
		public override Selectable FindSelectableOnDown()
		{
			return null;
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A3")]
		[Address(RVA = "0xD25730", Offset = "0xD24730", VA = "0x180D25730", Slot = "14")]
		protected override void OnCanvasGroupChanged()
		{
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A4")]
		[Address(RVA = "0xD25A50", Offset = "0xD24A50", VA = "0x180D25A50", Slot = "26")]
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A5")]
		[Address(RVA = "0xD25F10", Offset = "0xD24F10", VA = "0x180D25F10")]
		private void StartColorTween(Color targetColor, bool instant)
		{
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A6")]
		[Address(RVA = "0xD260D0", Offset = "0xD250D0", VA = "0x180D260D0")]
		private void DoSpriteSwap(Sprite newSprite)
		{
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A7")]
		[Address(RVA = "0xD26210", Offset = "0xD25210", VA = "0x180D26210")]
		private void TriggerAnimation(string triggername)
		{
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A8")]
		[Address(RVA = "0xD265C0", Offset = "0xD255C0", VA = "0x180D265C0", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x060031A9 RID: 12713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031A9")]
		[Address(RVA = "0xD26630", Offset = "0xD25630", VA = "0x180D26630", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031AA")]
		[Address(RVA = "0xD266B0", Offset = "0xD256B0", VA = "0x180D266B0")]
		private void EvaluateHightlightDisabled(bool isSelected)
		{
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031AB")]
		[Address(RVA = "0xD26770", Offset = "0xD25770", VA = "0x180D26770", Slot = "67")]
		public void OnCancel(BaseEventData eventData)
		{
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031AC")]
		[Address(RVA = "0xD267A0", Offset = "0xD257A0", VA = "0x180D267A0")]
		public CustomToggle()
		{
		}

		// Token: 0x04004F1E RID: 20254
		[Token(Token = "0x4004F1E")]
		[FieldOffset(Offset = "0x120")]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x04004F1F RID: 20255
		[Token(Token = "0x4004F1F")]
		[FieldOffset(Offset = "0x128")]
		private Color _disabledHighlightedColor;

		// Token: 0x04004F20 RID: 20256
		[Token(Token = "0x4004F20")]
		[FieldOffset(Offset = "0x138")]
		private string _disabledHighlightedTrigger;

		// Token: 0x04004F21 RID: 20257
		[Token(Token = "0x4004F21")]
		[FieldOffset(Offset = "0x140")]
		private bool _autoNavUp;

		// Token: 0x04004F22 RID: 20258
		[Token(Token = "0x4004F22")]
		[FieldOffset(Offset = "0x141")]
		private bool _autoNavDown;

		// Token: 0x04004F23 RID: 20259
		[Token(Token = "0x4004F23")]
		[FieldOffset(Offset = "0x142")]
		private bool _autoNavLeft;

		// Token: 0x04004F24 RID: 20260
		[Token(Token = "0x4004F24")]
		[FieldOffset(Offset = "0x143")]
		private bool _autoNavRight;

		// Token: 0x04004F25 RID: 20261
		[Token(Token = "0x4004F25")]
		[FieldOffset(Offset = "0x144")]
		private bool isHighlightDisabled;
	}
}
