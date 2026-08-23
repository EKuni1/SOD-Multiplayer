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
	// Token: 0x02000937 RID: 2359
	[Token(Token = "0x2000937")]
	public class CustomSlider : Slider, IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600316C RID: 12652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000455")]
		public Sprite disabledHighlightedSprite
		{
			[Token(Token = "0x600316B")]
			[Address(RVA = "0xD23540", Offset = "0xD22540", VA = "0x180D23540", Slot = "56")]
			get
			{
				return null;
			}
			[Token(Token = "0x600316C")]
			[Address(RVA = "0xD23550", Offset = "0xD22550", VA = "0x180D23550", Slot = "57")]
			set
			{
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000456")]
		public Color disabledHighlightedColor
		{
			[Token(Token = "0x600316D")]
			[Address(RVA = "0xD235B0", Offset = "0xD225B0", VA = "0x180D235B0", Slot = "58")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600316E")]
			[Address(RVA = "0xD235C0", Offset = "0xD225C0", VA = "0x180D235C0", Slot = "59")]
			set
			{
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003170 RID: 12656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000457")]
		public string disabledHighlightedTrigger
		{
			[Token(Token = "0x600316F")]
			[Address(RVA = "0xCE4530", Offset = "0xCE3530", VA = "0x180CE4530", Slot = "60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003170")]
			[Address(RVA = "0xCE4540", Offset = "0xCE3540", VA = "0x180CE4540", Slot = "61")]
			set
			{
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06003171 RID: 12657 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		// (set) Token: 0x06003172 RID: 12658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000458")]
		public bool autoNavUp
		{
			[Token(Token = "0x6003171")]
			[Address(RVA = "0xD235D0", Offset = "0xD225D0", VA = "0x180D235D0", Slot = "62")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003172")]
			[Address(RVA = "0xD235E0", Offset = "0xD225E0", VA = "0x180D235E0", Slot = "63")]
			set
			{
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06003173 RID: 12659 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		// (set) Token: 0x06003174 RID: 12660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000459")]
		public bool autoNavDown
		{
			[Token(Token = "0x6003173")]
			[Address(RVA = "0xD235F0", Offset = "0xD225F0", VA = "0x180D235F0", Slot = "64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003174")]
			[Address(RVA = "0xD23600", Offset = "0xD22600", VA = "0x180D23600", Slot = "65")]
			set
			{
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06003175 RID: 12661 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		// (set) Token: 0x06003176 RID: 12662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045A")]
		public bool autoNavLeft
		{
			[Token(Token = "0x6003175")]
			[Address(RVA = "0xD23610", Offset = "0xD22610", VA = "0x180D23610", Slot = "66")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003176")]
			[Address(RVA = "0xD23620", Offset = "0xD22620", VA = "0x180D23620", Slot = "67")]
			set
			{
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06003177 RID: 12663 RVA: 0x00011C10 File Offset: 0x0000FE10
		// (set) Token: 0x06003178 RID: 12664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045B")]
		public bool autoNavRight
		{
			[Token(Token = "0x6003177")]
			[Address(RVA = "0xD23630", Offset = "0xD22630", VA = "0x180D23630", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003178")]
			[Address(RVA = "0xD23640", Offset = "0xD22640", VA = "0x180D23640", Slot = "69")]
			set
			{
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06003179 RID: 12665 RVA: 0x00011C28 File Offset: 0x0000FE28
		[Token(Token = "0x1700045C")]
		private bool isDisabled
		{
			[Token(Token = "0x6003179")]
			[Address(RVA = "0xD21870", Offset = "0xD20870", VA = "0x180D21870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000074 RID: 116
		// (add) Token: 0x0600317A RID: 12666 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600317B RID: 12667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000074")]
		private event UnityAction _CancelEvent
		{
			[Token(Token = "0x600317A")]
			[Address(RVA = "0xD23650", Offset = "0xD22650", VA = "0x180D23650")]
			add
			{
			}
			[Token(Token = "0x600317B")]
			[Address(RVA = "0xD23750", Offset = "0xD22750", VA = "0x180D23750")]
			remove
			{
			}
		}

		// Token: 0x14000075 RID: 117
		// (add) Token: 0x0600317C RID: 12668 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600317D RID: 12669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000075")]
		public event UnityAction CancelEvent
		{
			[Token(Token = "0x600317C")]
			[Address(RVA = "0xD23650", Offset = "0xD22650", VA = "0x180D23650", Slot = "70")]
			add
			{
			}
			[Token(Token = "0x600317D")]
			[Address(RVA = "0xD23750", Offset = "0xD22750", VA = "0x180D23750", Slot = "71")]
			remove
			{
			}
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600317E")]
		[Address(RVA = "0xD23850", Offset = "0xD22850", VA = "0x180D23850", Slot = "27")]
		public override Selectable FindSelectableOnLeft()
		{
			return null;
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600317F")]
		[Address(RVA = "0xD239A0", Offset = "0xD229A0", VA = "0x180D239A0", Slot = "28")]
		public override Selectable FindSelectableOnRight()
		{
			return null;
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003180")]
		[Address(RVA = "0xD23AF0", Offset = "0xD22AF0", VA = "0x180D23AF0", Slot = "29")]
		public override Selectable FindSelectableOnUp()
		{
			return null;
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003181")]
		[Address(RVA = "0xD23C40", Offset = "0xD22C40", VA = "0x180D23C40", Slot = "30")]
		public override Selectable FindSelectableOnDown()
		{
			return null;
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003182")]
		[Address(RVA = "0xD23D90", Offset = "0xD22D90", VA = "0x180D23D90", Slot = "14")]
		protected override void OnCanvasGroupChanged()
		{
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003183")]
		[Address(RVA = "0xD240B0", Offset = "0xD230B0", VA = "0x180D240B0", Slot = "26")]
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003184")]
		[Address(RVA = "0xD24570", Offset = "0xD23570", VA = "0x180D24570")]
		private void StartColorTween(Color targetColor, bool instant)
		{
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003185")]
		[Address(RVA = "0xD24730", Offset = "0xD23730", VA = "0x180D24730")]
		private void DoSpriteSwap(Sprite newSprite)
		{
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003186")]
		[Address(RVA = "0xD24870", Offset = "0xD23870", VA = "0x180D24870")]
		private void TriggerAnimation(string triggername)
		{
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003187")]
		[Address(RVA = "0xD24C20", Offset = "0xD23C20", VA = "0x180D24C20", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003188")]
		[Address(RVA = "0xD24C90", Offset = "0xD23C90", VA = "0x180D24C90", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003189")]
		[Address(RVA = "0xD24D10", Offset = "0xD23D10", VA = "0x180D24D10")]
		private void EvaluateHightlightDisabled(bool isSelected)
		{
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318A")]
		[Address(RVA = "0xD24DD0", Offset = "0xD23DD0", VA = "0x180D24DD0", Slot = "72")]
		public void OnCancel(BaseEventData eventData)
		{
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318B")]
		[Address(RVA = "0xD24E00", Offset = "0xD23E00", VA = "0x180D24E00")]
		public CustomSlider()
		{
		}

		// Token: 0x04004F15 RID: 20245
		[Token(Token = "0x4004F15")]
		[FieldOffset(Offset = "0x160")]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x04004F16 RID: 20246
		[Token(Token = "0x4004F16")]
		[FieldOffset(Offset = "0x168")]
		private Color _disabledHighlightedColor;

		// Token: 0x04004F17 RID: 20247
		[Token(Token = "0x4004F17")]
		[FieldOffset(Offset = "0x178")]
		private string _disabledHighlightedTrigger;

		// Token: 0x04004F18 RID: 20248
		[Token(Token = "0x4004F18")]
		[FieldOffset(Offset = "0x180")]
		private bool _autoNavUp;

		// Token: 0x04004F19 RID: 20249
		[Token(Token = "0x4004F19")]
		[FieldOffset(Offset = "0x181")]
		private bool _autoNavDown;

		// Token: 0x04004F1A RID: 20250
		[Token(Token = "0x4004F1A")]
		[FieldOffset(Offset = "0x182")]
		private bool _autoNavLeft;

		// Token: 0x04004F1B RID: 20251
		[Token(Token = "0x4004F1B")]
		[FieldOffset(Offset = "0x183")]
		private bool _autoNavRight;

		// Token: 0x04004F1C RID: 20252
		[Token(Token = "0x4004F1C")]
		[FieldOffset(Offset = "0x184")]
		private bool isHighlightDisabled;
	}
}
