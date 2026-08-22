using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200095D RID: 2397
	[Token(Token = "0x200095D")]
	public class UISliderControl : UIControl
	{
		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060032FE RID: 13054 RVA: 0x00012048 File Offset: 0x00010248
		// (set) Token: 0x060032FF RID: 13055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000502")]
		public bool showIcon
		{
			[Token(Token = "0x60032FE")]
			[Address(RVA = "0xD32E10", Offset = "0xD31E10", VA = "0x180D32E10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032FF")]
			[Address(RVA = "0xD32E20", Offset = "0xD31E20", VA = "0x180D32E20")]
			set
			{
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x00012060 File Offset: 0x00010260
		// (set) Token: 0x06003301 RID: 13057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000503")]
		public bool showSlider
		{
			[Token(Token = "0x6003300")]
			[Address(RVA = "0xCF7070", Offset = "0xCF6070", VA = "0x180CF7070")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003301")]
			[Address(RVA = "0xD32FD0", Offset = "0xD31FD0", VA = "0x180D32FD0")]
			set
			{
			}
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003302")]
		[Address(RVA = "0xD33180", Offset = "0xD32180", VA = "0x180D33180", Slot = "4")]
		public override void SetCancelCallback(Action cancelCallback)
		{
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003303")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public UISliderControl()
		{
		}

		// Token: 0x04004FF1 RID: 20465
		[Token(Token = "0x4004FF1")]
		[FieldOffset(Offset = "0x28")]
		public Image iconImage;

		// Token: 0x04004FF2 RID: 20466
		[Token(Token = "0x4004FF2")]
		[FieldOffset(Offset = "0x30")]
		public Slider slider;

		// Token: 0x04004FF3 RID: 20467
		[Token(Token = "0x4004FF3")]
		[FieldOffset(Offset = "0x38")]
		private bool _showIcon;

		// Token: 0x04004FF4 RID: 20468
		[Token(Token = "0x4004FF4")]
		[FieldOffset(Offset = "0x39")]
		private bool _showSlider;

		// Token: 0x0200095E RID: 2398
		[Token(Token = "0x200095E")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06003304 RID: 13060 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003304")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06003305 RID: 13061 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003305")]
			[Address(RVA = "0xD33710", Offset = "0xD32710", VA = "0x180D33710")]
			internal void <SetCancelCallback>b__0()
			{
			}

			// Token: 0x06003306 RID: 13062 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003306")]
			[Address(RVA = "0xD33710", Offset = "0xD32710", VA = "0x180D33710")]
			internal void <SetCancelCallback>b__1(BaseEventData data)
			{
			}

			// Token: 0x04004FF5 RID: 20469
			[Token(Token = "0x4004FF5")]
			[FieldOffset(Offset = "0x10")]
			public Action cancelCallback;
		}
	}
}
