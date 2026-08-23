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
	// Token: 0x02000935 RID: 2357
	[Token(Token = "0x2000935")]
	public class CustomButton : Button, IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06003140 RID: 12608 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003141 RID: 12609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044B")]
		public Sprite disabledHighlightedSprite
		{
			[Token(Token = "0x6003140")]
			[Address(RVA = "0xD17400", Offset = "0xD16400", VA = "0x180D17400", Slot = "43")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003141")]
			[Address(RVA = "0xD17410", Offset = "0xD16410", VA = "0x180D17410", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06003142 RID: 12610 RVA: 0x00011B08 File Offset: 0x0000FD08
		// (set) Token: 0x06003143 RID: 12611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044C")]
		public Color disabledHighlightedColor
		{
			[Token(Token = "0x6003142")]
			[Address(RVA = "0xD217D0", Offset = "0xD207D0", VA = "0x180D217D0", Slot = "45")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6003143")]
			[Address(RVA = "0xD217E0", Offset = "0xD207E0", VA = "0x180D217E0", Slot = "46")]
			set
			{
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06003144 RID: 12612 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003145 RID: 12613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044D")]
		public string disabledHighlightedTrigger
		{
			[Token(Token = "0x6003144")]
			[Address(RVA = "0xD17550", Offset = "0xD16550", VA = "0x180D17550", Slot = "47")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003145")]
			[Address(RVA = "0xD17560", Offset = "0xD16560", VA = "0x180D17560", Slot = "48")]
			set
			{
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06003146 RID: 12614 RVA: 0x00011B20 File Offset: 0x0000FD20
		// (set) Token: 0x06003147 RID: 12615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044E")]
		public bool autoNavUp
		{
			[Token(Token = "0x6003146")]
			[Address(RVA = "0xD217F0", Offset = "0xD207F0", VA = "0x180D217F0", Slot = "49")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003147")]
			[Address(RVA = "0xD21800", Offset = "0xD20800", VA = "0x180D21800", Slot = "50")]
			set
			{
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06003148 RID: 12616 RVA: 0x00011B38 File Offset: 0x0000FD38
		// (set) Token: 0x06003149 RID: 12617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044F")]
		public bool autoNavDown
		{
			[Token(Token = "0x6003148")]
			[Address(RVA = "0xD21810", Offset = "0xD20810", VA = "0x180D21810", Slot = "51")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003149")]
			[Address(RVA = "0xD21820", Offset = "0xD20820", VA = "0x180D21820", Slot = "52")]
			set
			{
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x0600314A RID: 12618 RVA: 0x00011B50 File Offset: 0x0000FD50
		// (set) Token: 0x0600314B RID: 12619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000450")]
		public bool autoNavLeft
		{
			[Token(Token = "0x600314A")]
			[Address(RVA = "0xD21830", Offset = "0xD20830", VA = "0x180D21830", Slot = "53")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600314B")]
			[Address(RVA = "0xD21840", Offset = "0xD20840", VA = "0x180D21840", Slot = "54")]
			set
			{
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x00011B68 File Offset: 0x0000FD68
		// (set) Token: 0x0600314D RID: 12621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000451")]
		public bool autoNavRight
		{
			[Token(Token = "0x600314C")]
			[Address(RVA = "0xD21850", Offset = "0xD20850", VA = "0x180D21850", Slot = "55")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600314D")]
			[Address(RVA = "0xD21860", Offset = "0xD20860", VA = "0x180D21860", Slot = "56")]
			set
			{
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600314E RID: 12622 RVA: 0x00011B80 File Offset: 0x0000FD80
		[Token(Token = "0x17000452")]
		private bool isDisabled
		{
			[Token(Token = "0x600314E")]
			[Address(RVA = "0xD21870", Offset = "0xD20870", VA = "0x180D21870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000072 RID: 114
		// (add) Token: 0x0600314F RID: 12623 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003150 RID: 12624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000072")]
		private event UnityAction _CancelEvent
		{
			[Token(Token = "0x600314F")]
			[Address(RVA = "0xD218A0", Offset = "0xD208A0", VA = "0x180D218A0")]
			add
			{
			}
			[Token(Token = "0x6003150")]
			[Address(RVA = "0xD219A0", Offset = "0xD209A0", VA = "0x180D219A0")]
			remove
			{
			}
		}

		// Token: 0x14000073 RID: 115
		// (add) Token: 0x06003151 RID: 12625 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003152 RID: 12626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000073")]
		public event UnityAction CancelEvent
		{
			[Token(Token = "0x6003151")]
			[Address(RVA = "0xD218A0", Offset = "0xD208A0", VA = "0x180D218A0", Slot = "57")]
			add
			{
			}
			[Token(Token = "0x6003152")]
			[Address(RVA = "0xD219A0", Offset = "0xD209A0", VA = "0x180D219A0", Slot = "58")]
			remove
			{
			}
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003153")]
		[Address(RVA = "0xD21AA0", Offset = "0xD20AA0", VA = "0x180D21AA0", Slot = "27")]
		public override Selectable FindSelectableOnLeft()
		{
			return null;
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003154")]
		[Address(RVA = "0xD21BD0", Offset = "0xD20BD0", VA = "0x180D21BD0", Slot = "28")]
		public override Selectable FindSelectableOnRight()
		{
			return null;
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003155")]
		[Address(RVA = "0xD21D00", Offset = "0xD20D00", VA = "0x180D21D00", Slot = "29")]
		public override Selectable FindSelectableOnUp()
		{
			return null;
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003156")]
		[Address(RVA = "0xD21E30", Offset = "0xD20E30", VA = "0x180D21E30", Slot = "30")]
		public override Selectable FindSelectableOnDown()
		{
			return null;
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003157")]
		[Address(RVA = "0xD21F60", Offset = "0xD20F60", VA = "0x180D21F60", Slot = "14")]
		protected override void OnCanvasGroupChanged()
		{
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003158")]
		[Address(RVA = "0xD22280", Offset = "0xD21280", VA = "0x180D22280", Slot = "26")]
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003159")]
		[Address(RVA = "0xD22740", Offset = "0xD21740", VA = "0x180D22740")]
		private void StartColorTween(Color targetColor, bool instant)
		{
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315A")]
		[Address(RVA = "0xD22900", Offset = "0xD21900", VA = "0x180D22900")]
		private void DoSpriteSwap(Sprite newSprite)
		{
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315B")]
		[Address(RVA = "0xD22A40", Offset = "0xD21A40", VA = "0x180D22A40")]
		private void TriggerAnimation(string triggername)
		{
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315C")]
		[Address(RVA = "0xD22DF0", Offset = "0xD21DF0", VA = "0x180D22DF0", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315D")]
		[Address(RVA = "0xD22E60", Offset = "0xD21E60", VA = "0x180D22E60", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315E")]
		[Address(RVA = "0xD22EE0", Offset = "0xD21EE0", VA = "0x180D22EE0")]
		private void Press()
		{
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600315F")]
		[Address(RVA = "0xD22F40", Offset = "0xD21F40", VA = "0x180D22F40", Slot = "41")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003160")]
		[Address(RVA = "0xD23010", Offset = "0xD22010", VA = "0x180D23010", Slot = "42")]
		public override void OnSubmit(BaseEventData eventData)
		{
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003161")]
		[Address(RVA = "0xD23190", Offset = "0xD22190", VA = "0x180D23190")]
		private IEnumerator OnFinishSubmit()
		{
			return null;
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003162")]
		[Address(RVA = "0xD23230", Offset = "0xD22230", VA = "0x180D23230")]
		private void EvaluateHightlightDisabled(bool isSelected)
		{
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003163")]
		[Address(RVA = "0xD232F0", Offset = "0xD222F0", VA = "0x180D232F0", Slot = "59")]
		public void OnCancel(BaseEventData eventData)
		{
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003164")]
		[Address(RVA = "0xD23320", Offset = "0xD22320", VA = "0x180D23320")]
		public CustomButton()
		{
		}

		// Token: 0x04004F07 RID: 20231
		[Token(Token = "0x4004F07")]
		[FieldOffset(Offset = "0x100")]
		private Sprite _disabledHighlightedSprite;

		// Token: 0x04004F08 RID: 20232
		[Token(Token = "0x4004F08")]
		[FieldOffset(Offset = "0x108")]
		private Color _disabledHighlightedColor;

		// Token: 0x04004F09 RID: 20233
		[Token(Token = "0x4004F09")]
		[FieldOffset(Offset = "0x118")]
		private string _disabledHighlightedTrigger;

		// Token: 0x04004F0A RID: 20234
		[Token(Token = "0x4004F0A")]
		[FieldOffset(Offset = "0x120")]
		private bool _autoNavUp;

		// Token: 0x04004F0B RID: 20235
		[Token(Token = "0x4004F0B")]
		[FieldOffset(Offset = "0x121")]
		private bool _autoNavDown;

		// Token: 0x04004F0C RID: 20236
		[Token(Token = "0x4004F0C")]
		[FieldOffset(Offset = "0x122")]
		private bool _autoNavLeft;

		// Token: 0x04004F0D RID: 20237
		[Token(Token = "0x4004F0D")]
		[FieldOffset(Offset = "0x123")]
		private bool _autoNavRight;

		// Token: 0x04004F0E RID: 20238
		[Token(Token = "0x4004F0E")]
		[FieldOffset(Offset = "0x124")]
		private bool isHighlightDisabled;

		// Token: 0x02000936 RID: 2358
		[Token(Token = "0x2000936")]
		private sealed class <OnFinishSubmit>d__51 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x06003165 RID: 12645 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003165")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <OnFinishSubmit>d__51(int <>1__state)
			{
			}

			// Token: 0x06003166 RID: 12646 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003166")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x06003167 RID: 12647 RVA: 0x00011B98 File Offset: 0x0000FD98
			[Token(Token = "0x6003167")]
			[Address(RVA = "0xD23340", Offset = "0xD22340", VA = "0x180D23340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000453 RID: 1107
			// (get) Token: 0x06003168 RID: 12648 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000453")]
			private object Current
			{
				[Token(Token = "0x6003168")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003169 RID: 12649 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003169")]
			[Address(RVA = "0xD234F0", Offset = "0xD224F0", VA = "0x180D234F0", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000454 RID: 1108
			// (get) Token: 0x0600316A RID: 12650 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000454")]
			private object Current
			{
				[Token(Token = "0x600316A")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04004F10 RID: 20240
			[Token(Token = "0x4004F10")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04004F11 RID: 20241
			[Token(Token = "0x4004F11")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04004F12 RID: 20242
			[Token(Token = "0x4004F12")]
			[FieldOffset(Offset = "0x20")]
			public CustomButton <>4__this;

			// Token: 0x04004F13 RID: 20243
			[Token(Token = "0x4004F13")]
			[FieldOffset(Offset = "0x28")]
			private float <fadeTime>5__2;

			// Token: 0x04004F14 RID: 20244
			[Token(Token = "0x4004F14")]
			[FieldOffset(Offset = "0x2C")]
			private float <elapsedTime>5__3;
		}
	}
}
