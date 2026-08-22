using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000949 RID: 2377
	[Token(Token = "0x2000949")]
	[Serializable]
	public class ThemeSettings : ScriptableObject
	{
		// Token: 0x06003282 RID: 12930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003282")]
		[Address(RVA = "0xD2CCA0", Offset = "0xD2BCA0", VA = "0x180D2CCA0")]
		public void Apply(ThemedElement.ElementInfo[] elementInfo)
		{
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003283")]
		[Address(RVA = "0xD2CD10", Offset = "0xD2BD10", VA = "0x180D2CD10")]
		private void Apply(string themeClass, Component component)
		{
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003284")]
		[Address(RVA = "0xD2D330", Offset = "0xD2C330", VA = "0x180D2D330")]
		private void Apply(string themeClass, Selectable item)
		{
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003285")]
		[Address(RVA = "0xD2D960", Offset = "0xD2C960", VA = "0x180D2D960")]
		private void Apply(string themeClass, Image item)
		{
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003286")]
		[Address(RVA = "0xD2E030", Offset = "0xD2D030", VA = "0x180D2E030")]
		private void Apply(string themeClass, TMP_Text item)
		{
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003287")]
		[Address(RVA = "0xD2E4E0", Offset = "0xD2D4E0", VA = "0x180D2E4E0")]
		private void Apply(string themeClass, UIImageHelper item)
		{
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x00011D60 File Offset: 0x0000FF60
		[Token(Token = "0x6003288")]
		[Address(RVA = "0xD2E7A0", Offset = "0xD2D7A0", VA = "0x180D2E7A0")]
		private static FontStyles GetFontStyle(ThemeSettings.FontStyleOverride style)
		{
			return FontStyles.Normal;
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003289")]
		[Address(RVA = "0x5C7970", Offset = "0x5C6970", VA = "0x1805C7970")]
		public ThemeSettings()
		{
		}

		// Token: 0x04004F96 RID: 20374
		[Token(Token = "0x4004F96")]
		[FieldOffset(Offset = "0x18")]
		private ThemeSettings.ImageSettings _mainWindowBackground;

		// Token: 0x04004F97 RID: 20375
		[Token(Token = "0x4004F97")]
		[FieldOffset(Offset = "0x20")]
		private ThemeSettings.ImageSettings _popupWindowBackground;

		// Token: 0x04004F98 RID: 20376
		[Token(Token = "0x4004F98")]
		[FieldOffset(Offset = "0x28")]
		private ThemeSettings.ImageSettings _areaBackground;

		// Token: 0x04004F99 RID: 20377
		[Token(Token = "0x4004F99")]
		[FieldOffset(Offset = "0x30")]
		private ThemeSettings.SelectableSettings _selectableSettings;

		// Token: 0x04004F9A RID: 20378
		[Token(Token = "0x4004F9A")]
		[FieldOffset(Offset = "0x38")]
		private ThemeSettings.SelectableSettings _buttonSettings;

		// Token: 0x04004F9B RID: 20379
		[Token(Token = "0x4004F9B")]
		[FieldOffset(Offset = "0x40")]
		private ThemeSettings.SelectableSettings _inputGridFieldSettings;

		// Token: 0x04004F9C RID: 20380
		[Token(Token = "0x4004F9C")]
		[FieldOffset(Offset = "0x48")]
		private ThemeSettings.ScrollbarSettings _scrollbarSettings;

		// Token: 0x04004F9D RID: 20381
		[Token(Token = "0x4004F9D")]
		[FieldOffset(Offset = "0x50")]
		private ThemeSettings.SliderSettings _sliderSettings;

		// Token: 0x04004F9E RID: 20382
		[Token(Token = "0x4004F9E")]
		[FieldOffset(Offset = "0x58")]
		private ThemeSettings.ImageSettings _invertToggle;

		// Token: 0x04004F9F RID: 20383
		[Token(Token = "0x4004F9F")]
		[FieldOffset(Offset = "0x60")]
		private Color _invertToggleDisabledColor;

		// Token: 0x04004FA0 RID: 20384
		[Token(Token = "0x4004FA0")]
		[FieldOffset(Offset = "0x70")]
		private ThemeSettings.ImageSettings _calibrationBackground;

		// Token: 0x04004FA1 RID: 20385
		[Token(Token = "0x4004FA1")]
		[FieldOffset(Offset = "0x78")]
		private ThemeSettings.ImageSettings _calibrationValueMarker;

		// Token: 0x04004FA2 RID: 20386
		[Token(Token = "0x4004FA2")]
		[FieldOffset(Offset = "0x80")]
		private ThemeSettings.ImageSettings _calibrationRawValueMarker;

		// Token: 0x04004FA3 RID: 20387
		[Token(Token = "0x4004FA3")]
		[FieldOffset(Offset = "0x88")]
		private ThemeSettings.ImageSettings _calibrationZeroMarker;

		// Token: 0x04004FA4 RID: 20388
		[Token(Token = "0x4004FA4")]
		[FieldOffset(Offset = "0x90")]
		private ThemeSettings.ImageSettings _calibrationCalibratedZeroMarker;

		// Token: 0x04004FA5 RID: 20389
		[Token(Token = "0x4004FA5")]
		[FieldOffset(Offset = "0x98")]
		private ThemeSettings.ImageSettings _calibrationDeadzone;

		// Token: 0x04004FA6 RID: 20390
		[Token(Token = "0x4004FA6")]
		[FieldOffset(Offset = "0xA0")]
		private ThemeSettings.TextSettings _textSettings;

		// Token: 0x04004FA7 RID: 20391
		[Token(Token = "0x4004FA7")]
		[FieldOffset(Offset = "0xA8")]
		private ThemeSettings.TextSettings _buttonTextSettings;

		// Token: 0x04004FA8 RID: 20392
		[Token(Token = "0x4004FA8")]
		[FieldOffset(Offset = "0xB0")]
		private ThemeSettings.TextSettings _inputGridFieldTextSettings;

		// Token: 0x0200094A RID: 2378
		[Token(Token = "0x200094A")]
		[Serializable]
		private abstract class SelectableSettings_Base
		{
			// Token: 0x170004CF RID: 1231
			// (get) Token: 0x0600328A RID: 12938 RVA: 0x00011D78 File Offset: 0x0000FF78
			[Token(Token = "0x170004CF")]
			public Selectable.Transition transition
			{
				[Token(Token = "0x600328A")]
				[Address(RVA = "0x3F9850", Offset = "0x3F8850", VA = "0x1803F9850")]
				get
				{
					return Selectable.Transition.None;
				}
			}

			// Token: 0x170004D0 RID: 1232
			// (get) Token: 0x0600328B RID: 12939 RVA: 0x00011D90 File Offset: 0x0000FF90
			[Token(Token = "0x170004D0")]
			public ThemeSettings.CustomColorBlock selectableColors
			{
				[Token(Token = "0x600328B")]
				[Address(RVA = "0xD2E830", Offset = "0xD2D830", VA = "0x180D2E830")]
				get
				{
					return default(ThemeSettings.CustomColorBlock);
				}
			}

			// Token: 0x170004D1 RID: 1233
			// (get) Token: 0x0600328C RID: 12940 RVA: 0x00011DA8 File Offset: 0x0000FFA8
			[Token(Token = "0x170004D1")]
			public ThemeSettings.CustomSpriteState spriteState
			{
				[Token(Token = "0x600328C")]
				[Address(RVA = "0xD2E870", Offset = "0xD2D870", VA = "0x180D2E870")]
				get
				{
					return default(ThemeSettings.CustomSpriteState);
				}
			}

			// Token: 0x170004D2 RID: 1234
			// (get) Token: 0x0600328D RID: 12941 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004D2")]
			public ThemeSettings.CustomAnimationTriggers animationTriggers
			{
				[Token(Token = "0x600328D")]
				[Address(RVA = "0xD17270", Offset = "0xD16270", VA = "0x180D17270")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600328E RID: 12942 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600328E")]
			[Address(RVA = "0xD2E8A0", Offset = "0xD2D8A0", VA = "0x180D2E8A0", Slot = "4")]
			public virtual void Apply(Selectable item)
			{
			}

			// Token: 0x0600328F RID: 12943 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600328F")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			protected SelectableSettings_Base()
			{
			}

			// Token: 0x04004FA9 RID: 20393
			[Token(Token = "0x4004FA9")]
			[FieldOffset(Offset = "0x10")]
			protected Selectable.Transition _transition;

			// Token: 0x04004FAA RID: 20394
			[Token(Token = "0x4004FAA")]
			[FieldOffset(Offset = "0x14")]
			protected ThemeSettings.CustomColorBlock _colors;

			// Token: 0x04004FAB RID: 20395
			[Token(Token = "0x4004FAB")]
			[FieldOffset(Offset = "0x80")]
			protected ThemeSettings.CustomSpriteState _spriteState;

			// Token: 0x04004FAC RID: 20396
			[Token(Token = "0x4004FAC")]
			[FieldOffset(Offset = "0xA8")]
			protected ThemeSettings.CustomAnimationTriggers _animationTriggers;
		}

		// Token: 0x0200094B RID: 2379
		[Token(Token = "0x200094B")]
		[Serializable]
		private class SelectableSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x170004D3 RID: 1235
			// (get) Token: 0x06003290 RID: 12944 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004D3")]
			public ThemeSettings.ImageSettings imageSettings
			{
				[Token(Token = "0x6003290")]
				[Address(RVA = "0xD17280", Offset = "0xD16280", VA = "0x180D17280")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003291 RID: 12945 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003291")]
			[Address(RVA = "0xD2F030", Offset = "0xD2E030", VA = "0x180D2F030", Slot = "4")]
			public override void Apply(Selectable item)
			{
			}

			// Token: 0x06003292 RID: 12946 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003292")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public SelectableSettings()
			{
			}

			// Token: 0x04004FAD RID: 20397
			[Token(Token = "0x4004FAD")]
			[FieldOffset(Offset = "0xB0")]
			private ThemeSettings.ImageSettings _imageSettings;
		}

		// Token: 0x0200094C RID: 2380
		[Token(Token = "0x200094C")]
		[Serializable]
		private class SliderSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x170004D4 RID: 1236
			// (get) Token: 0x06003293 RID: 12947 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004D4")]
			public ThemeSettings.ImageSettings handleImageSettings
			{
				[Token(Token = "0x6003293")]
				[Address(RVA = "0xD17280", Offset = "0xD16280", VA = "0x180D17280")]
				get
				{
					return null;
				}
			}

			// Token: 0x170004D5 RID: 1237
			// (get) Token: 0x06003294 RID: 12948 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004D5")]
			public ThemeSettings.ImageSettings fillImageSettings
			{
				[Token(Token = "0x6003294")]
				[Address(RVA = "0xCEAB80", Offset = "0xCE9B80", VA = "0x180CEAB80")]
				get
				{
					return null;
				}
			}

			// Token: 0x170004D6 RID: 1238
			// (get) Token: 0x06003295 RID: 12949 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004D6")]
			public ThemeSettings.ImageSettings backgroundImageSettings
			{
				[Token(Token = "0x6003295")]
				[Address(RVA = "0xCEACC0", Offset = "0xCE9CC0", VA = "0x180CEACC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003296 RID: 12950 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003296")]
			[Address(RVA = "0xD2F1C0", Offset = "0xD2E1C0", VA = "0x180D2F1C0")]
			private void Apply(Slider item)
			{
			}

			// Token: 0x06003297 RID: 12951 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003297")]
			[Address(RVA = "0xD2F690", Offset = "0xD2E690", VA = "0x180D2F690", Slot = "4")]
			public override void Apply(Selectable item)
			{
			}

			// Token: 0x06003298 RID: 12952 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003298")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public SliderSettings()
			{
			}

			// Token: 0x04004FAE RID: 20398
			[Token(Token = "0x4004FAE")]
			[FieldOffset(Offset = "0xB0")]
			private ThemeSettings.ImageSettings _handleImageSettings;

			// Token: 0x04004FAF RID: 20399
			[Token(Token = "0x4004FAF")]
			[FieldOffset(Offset = "0xB8")]
			private ThemeSettings.ImageSettings _fillImageSettings;

			// Token: 0x04004FB0 RID: 20400
			[Token(Token = "0x4004FB0")]
			[FieldOffset(Offset = "0xC0")]
			private ThemeSettings.ImageSettings _backgroundImageSettings;
		}

		// Token: 0x0200094D RID: 2381
		[Token(Token = "0x200094D")]
		[Serializable]
		private class ScrollbarSettings : ThemeSettings.SelectableSettings_Base
		{
			// Token: 0x170004D7 RID: 1239
			// (get) Token: 0x06003299 RID: 12953 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004D7")]
			public ThemeSettings.ImageSettings handle
			{
				[Token(Token = "0x6003299")]
				[Address(RVA = "0xD17280", Offset = "0xD16280", VA = "0x180D17280")]
				get
				{
					return null;
				}
			}

			// Token: 0x170004D8 RID: 1240
			// (get) Token: 0x0600329A RID: 12954 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004D8")]
			public ThemeSettings.ImageSettings background
			{
				[Token(Token = "0x600329A")]
				[Address(RVA = "0xCEAB80", Offset = "0xCE9B80", VA = "0x180CEAB80")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600329B RID: 12955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600329B")]
			[Address(RVA = "0xD2F730", Offset = "0xD2E730", VA = "0x180D2F730")]
			private void Apply(Scrollbar item)
			{
			}

			// Token: 0x0600329C RID: 12956 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600329C")]
			[Address(RVA = "0xD2F900", Offset = "0xD2E900", VA = "0x180D2F900", Slot = "4")]
			public override void Apply(Selectable item)
			{
			}

			// Token: 0x0600329D RID: 12957 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600329D")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public ScrollbarSettings()
			{
			}

			// Token: 0x04004FB1 RID: 20401
			[Token(Token = "0x4004FB1")]
			[FieldOffset(Offset = "0xB0")]
			private ThemeSettings.ImageSettings _handleImageSettings;

			// Token: 0x04004FB2 RID: 20402
			[Token(Token = "0x4004FB2")]
			[FieldOffset(Offset = "0xB8")]
			private ThemeSettings.ImageSettings _backgroundImageSettings;
		}

		// Token: 0x0200094E RID: 2382
		[Token(Token = "0x200094E")]
		[Serializable]
		private class ImageSettings
		{
			// Token: 0x170004D9 RID: 1241
			// (get) Token: 0x0600329E RID: 12958 RVA: 0x00011DC0 File Offset: 0x0000FFC0
			[Token(Token = "0x170004D9")]
			public Color color
			{
				[Token(Token = "0x600329E")]
				[Address(RVA = "0x414F10", Offset = "0x413F10", VA = "0x180414F10")]
				get
				{
					return default(Color);
				}
			}

			// Token: 0x170004DA RID: 1242
			// (get) Token: 0x0600329F RID: 12959 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004DA")]
			public Sprite sprite
			{
				[Token(Token = "0x600329F")]
				[Address(RVA = "0x3EDA30", Offset = "0x3ECA30", VA = "0x1803EDA30")]
				get
				{
					return null;
				}
			}

			// Token: 0x170004DB RID: 1243
			// (get) Token: 0x060032A0 RID: 12960 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004DB")]
			public Material materal
			{
				[Token(Token = "0x60032A0")]
				[Address(RVA = "0xD166D0", Offset = "0xD156D0", VA = "0x180D166D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170004DC RID: 1244
			// (get) Token: 0x060032A1 RID: 12961 RVA: 0x00011DD8 File Offset: 0x0000FFD8
			[Token(Token = "0x170004DC")]
			public Image.Type type
			{
				[Token(Token = "0x60032A1")]
				[Address(RVA = "0xD181D0", Offset = "0xD171D0", VA = "0x180D181D0")]
				get
				{
					return Image.Type.Simple;
				}
			}

			// Token: 0x170004DD RID: 1245
			// (get) Token: 0x060032A2 RID: 12962 RVA: 0x00011DF0 File Offset: 0x0000FFF0
			[Token(Token = "0x170004DD")]
			public bool preserveAspect
			{
				[Token(Token = "0x60032A2")]
				[Address(RVA = "0xCD4210", Offset = "0xCD3210", VA = "0x180CD4210")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170004DE RID: 1246
			// (get) Token: 0x060032A3 RID: 12963 RVA: 0x00011E08 File Offset: 0x00010008
			[Token(Token = "0x170004DE")]
			public bool fillCenter
			{
				[Token(Token = "0x60032A3")]
				[Address(RVA = "0xD2F9A0", Offset = "0xD2E9A0", VA = "0x180D2F9A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170004DF RID: 1247
			// (get) Token: 0x060032A4 RID: 12964 RVA: 0x00011E20 File Offset: 0x00010020
			[Token(Token = "0x170004DF")]
			public Image.FillMethod fillMethod
			{
				[Token(Token = "0x60032A4")]
				[Address(RVA = "0xD28F40", Offset = "0xD27F40", VA = "0x180D28F40")]
				get
				{
					return Image.FillMethod.Horizontal;
				}
			}

			// Token: 0x170004E0 RID: 1248
			// (get) Token: 0x060032A5 RID: 12965 RVA: 0x00011E38 File Offset: 0x00010038
			[Token(Token = "0x170004E0")]
			public float fillAmout
			{
				[Token(Token = "0x60032A5")]
				[Address(RVA = "0x404DF0", Offset = "0x403DF0", VA = "0x180404DF0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170004E1 RID: 1249
			// (get) Token: 0x060032A6 RID: 12966 RVA: 0x00011E50 File Offset: 0x00010050
			[Token(Token = "0x170004E1")]
			public bool fillClockwise
			{
				[Token(Token = "0x60032A6")]
				[Address(RVA = "0xCF7230", Offset = "0xCF6230", VA = "0x180CF7230")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170004E2 RID: 1250
			// (get) Token: 0x060032A7 RID: 12967 RVA: 0x00011E68 File Offset: 0x00010068
			[Token(Token = "0x170004E2")]
			public int fillOrigin
			{
				[Token(Token = "0x60032A7")]
				[Address(RVA = "0xCF72A0", Offset = "0xCF62A0", VA = "0x180CF72A0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060032A8 RID: 12968 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60032A8")]
			[Address(RVA = "0xD2F9B0", Offset = "0xD2E9B0", VA = "0x180D2F9B0", Slot = "4")]
			public virtual void CopyTo(Image image)
			{
			}

			// Token: 0x060032A9 RID: 12969 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60032A9")]
			[Address(RVA = "0xD2FCC0", Offset = "0xD2ECC0", VA = "0x180D2FCC0")]
			public ImageSettings()
			{
			}

			// Token: 0x04004FB3 RID: 20403
			[Token(Token = "0x4004FB3")]
			[FieldOffset(Offset = "0x10")]
			private Color _color;

			// Token: 0x04004FB4 RID: 20404
			[Token(Token = "0x4004FB4")]
			[FieldOffset(Offset = "0x20")]
			private Sprite _sprite;

			// Token: 0x04004FB5 RID: 20405
			[Token(Token = "0x4004FB5")]
			[FieldOffset(Offset = "0x28")]
			private Material _materal;

			// Token: 0x04004FB6 RID: 20406
			[Token(Token = "0x4004FB6")]
			[FieldOffset(Offset = "0x30")]
			private Image.Type _type;

			// Token: 0x04004FB7 RID: 20407
			[Token(Token = "0x4004FB7")]
			[FieldOffset(Offset = "0x34")]
			private bool _preserveAspect;

			// Token: 0x04004FB8 RID: 20408
			[Token(Token = "0x4004FB8")]
			[FieldOffset(Offset = "0x35")]
			private bool _fillCenter;

			// Token: 0x04004FB9 RID: 20409
			[Token(Token = "0x4004FB9")]
			[FieldOffset(Offset = "0x38")]
			private Image.FillMethod _fillMethod;

			// Token: 0x04004FBA RID: 20410
			[Token(Token = "0x4004FBA")]
			[FieldOffset(Offset = "0x3C")]
			private float _fillAmout;

			// Token: 0x04004FBB RID: 20411
			[Token(Token = "0x4004FBB")]
			[FieldOffset(Offset = "0x40")]
			private bool _fillClockwise;

			// Token: 0x04004FBC RID: 20412
			[Token(Token = "0x4004FBC")]
			[FieldOffset(Offset = "0x44")]
			private int _fillOrigin;
		}

		// Token: 0x0200094F RID: 2383
		[Token(Token = "0x200094F")]
		[Serializable]
		private struct CustomColorBlock
		{
			// Token: 0x170004E3 RID: 1251
			// (get) Token: 0x060032AA RID: 12970 RVA: 0x00011E80 File Offset: 0x00010080
			// (set) Token: 0x060032AB RID: 12971 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004E3")]
			public float colorMultiplier
			{
				[Token(Token = "0x60032AA")]
				[Address(RVA = "0xD2FCD0", Offset = "0xD2ECD0", VA = "0x180D2FCD0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60032AB")]
				[Address(RVA = "0xD2FCE0", Offset = "0xD2ECE0", VA = "0x180D2FCE0")]
				set
				{
				}
			}

			// Token: 0x170004E4 RID: 1252
			// (get) Token: 0x060032AC RID: 12972 RVA: 0x00011E98 File Offset: 0x00010098
			// (set) Token: 0x060032AD RID: 12973 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004E4")]
			public Color disabledColor
			{
				[Token(Token = "0x60032AC")]
				[Address(RVA = "0xD2FCF0", Offset = "0xD2ECF0", VA = "0x180D2FCF0")]
				get
				{
					return default(Color);
				}
				[Token(Token = "0x60032AD")]
				[Address(RVA = "0xD2FD00", Offset = "0xD2ED00", VA = "0x180D2FD00")]
				set
				{
				}
			}

			// Token: 0x170004E5 RID: 1253
			// (get) Token: 0x060032AE RID: 12974 RVA: 0x00011EB0 File Offset: 0x000100B0
			// (set) Token: 0x060032AF RID: 12975 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004E5")]
			public float fadeDuration
			{
				[Token(Token = "0x60032AE")]
				[Address(RVA = "0xD2FD10", Offset = "0xD2ED10", VA = "0x180D2FD10")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60032AF")]
				[Address(RVA = "0xD2FD20", Offset = "0xD2ED20", VA = "0x180D2FD20")]
				set
				{
				}
			}

			// Token: 0x170004E6 RID: 1254
			// (get) Token: 0x060032B0 RID: 12976 RVA: 0x00011EC8 File Offset: 0x000100C8
			// (set) Token: 0x060032B1 RID: 12977 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004E6")]
			public Color highlightedColor
			{
				[Token(Token = "0x60032B0")]
				[Address(RVA = "0xD2FD30", Offset = "0xD2ED30", VA = "0x180D2FD30")]
				get
				{
					return default(Color);
				}
				[Token(Token = "0x60032B1")]
				[Address(RVA = "0xD2FD40", Offset = "0xD2ED40", VA = "0x180D2FD40")]
				set
				{
				}
			}

			// Token: 0x170004E7 RID: 1255
			// (get) Token: 0x060032B2 RID: 12978 RVA: 0x00011EE0 File Offset: 0x000100E0
			// (set) Token: 0x060032B3 RID: 12979 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004E7")]
			public Color normalColor
			{
				[Token(Token = "0x60032B2")]
				[Address(RVA = "0xD2FD50", Offset = "0xD2ED50", VA = "0x180D2FD50")]
				get
				{
					return default(Color);
				}
				[Token(Token = "0x60032B3")]
				[Address(RVA = "0xD2FD60", Offset = "0xD2ED60", VA = "0x180D2FD60")]
				set
				{
				}
			}

			// Token: 0x170004E8 RID: 1256
			// (get) Token: 0x060032B4 RID: 12980 RVA: 0x00011EF8 File Offset: 0x000100F8
			// (set) Token: 0x060032B5 RID: 12981 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004E8")]
			public Color pressedColor
			{
				[Token(Token = "0x60032B4")]
				[Address(RVA = "0xD2FD70", Offset = "0xD2ED70", VA = "0x180D2FD70")]
				get
				{
					return default(Color);
				}
				[Token(Token = "0x60032B5")]
				[Address(RVA = "0xD2FD80", Offset = "0xD2ED80", VA = "0x180D2FD80")]
				set
				{
				}
			}

			// Token: 0x170004E9 RID: 1257
			// (get) Token: 0x060032B6 RID: 12982 RVA: 0x00011F10 File Offset: 0x00010110
			// (set) Token: 0x060032B7 RID: 12983 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004E9")]
			public Color selectedColor
			{
				[Token(Token = "0x60032B6")]
				[Address(RVA = "0xD2FD90", Offset = "0xD2ED90", VA = "0x180D2FD90")]
				get
				{
					return default(Color);
				}
				[Token(Token = "0x60032B7")]
				[Address(RVA = "0xD2FDA0", Offset = "0xD2EDA0", VA = "0x180D2FDA0")]
				set
				{
				}
			}

			// Token: 0x170004EA RID: 1258
			// (get) Token: 0x060032B8 RID: 12984 RVA: 0x00011F28 File Offset: 0x00010128
			// (set) Token: 0x060032B9 RID: 12985 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004EA")]
			public Color disabledHighlightedColor
			{
				[Token(Token = "0x60032B8")]
				[Address(RVA = "0xD2FDB0", Offset = "0xD2EDB0", VA = "0x180D2FDB0")]
				get
				{
					return default(Color);
				}
				[Token(Token = "0x60032B9")]
				[Address(RVA = "0xD2FDC0", Offset = "0xD2EDC0", VA = "0x180D2FDC0")]
				set
				{
				}
			}

			// Token: 0x060032BA RID: 12986 RVA: 0x00011F40 File Offset: 0x00010140
			[Token(Token = "0x60032BA")]
			[Address(RVA = "0xD2FDD0", Offset = "0xD2EDD0", VA = "0x180D2FDD0")]
			public static implicit operator ColorBlock(ThemeSettings.CustomColorBlock item)
			{
				return default(ColorBlock);
			}

			// Token: 0x04004FBD RID: 20413
			[Token(Token = "0x4004FBD")]
			[FieldOffset(Offset = "0x0")]
			private float m_ColorMultiplier;

			// Token: 0x04004FBE RID: 20414
			[Token(Token = "0x4004FBE")]
			[FieldOffset(Offset = "0x4")]
			private Color m_DisabledColor;

			// Token: 0x04004FBF RID: 20415
			[Token(Token = "0x4004FBF")]
			[FieldOffset(Offset = "0x14")]
			private float m_FadeDuration;

			// Token: 0x04004FC0 RID: 20416
			[Token(Token = "0x4004FC0")]
			[FieldOffset(Offset = "0x18")]
			private Color m_HighlightedColor;

			// Token: 0x04004FC1 RID: 20417
			[Token(Token = "0x4004FC1")]
			[FieldOffset(Offset = "0x28")]
			private Color m_NormalColor;

			// Token: 0x04004FC2 RID: 20418
			[Token(Token = "0x4004FC2")]
			[FieldOffset(Offset = "0x38")]
			private Color m_PressedColor;

			// Token: 0x04004FC3 RID: 20419
			[Token(Token = "0x4004FC3")]
			[FieldOffset(Offset = "0x48")]
			private Color m_SelectedColor;

			// Token: 0x04004FC4 RID: 20420
			[Token(Token = "0x4004FC4")]
			[FieldOffset(Offset = "0x58")]
			private Color m_DisabledHighlightedColor;
		}

		// Token: 0x02000950 RID: 2384
		[Token(Token = "0x2000950")]
		[Serializable]
		private struct CustomSpriteState
		{
			// Token: 0x170004EB RID: 1259
			// (get) Token: 0x060032BB RID: 12987 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060032BC RID: 12988 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004EB")]
			public Sprite disabledSprite
			{
				[Token(Token = "0x60032BB")]
				[Address(RVA = "0x3EB790", Offset = "0x3EA790", VA = "0x1803EB790")]
				get
				{
					return null;
				}
				[Token(Token = "0x60032BC")]
				[Address(RVA = "0xD2FF60", Offset = "0xD2EF60", VA = "0x180D2FF60")]
				set
				{
				}
			}

			// Token: 0x170004EC RID: 1260
			// (get) Token: 0x060032BD RID: 12989 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060032BE RID: 12990 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004EC")]
			public Sprite highlightedSprite
			{
				[Token(Token = "0x60032BD")]
				[Address(RVA = "0x3EB7A0", Offset = "0x3EA7A0", VA = "0x1803EB7A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60032BE")]
				[Address(RVA = "0xA10F90", Offset = "0xA0FF90", VA = "0x180A10F90")]
				set
				{
				}
			}

			// Token: 0x170004ED RID: 1261
			// (get) Token: 0x060032BF RID: 12991 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060032C0 RID: 12992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004ED")]
			public Sprite pressedSprite
			{
				[Token(Token = "0x60032BF")]
				[Address(RVA = "0x3ED8F0", Offset = "0x3EC8F0", VA = "0x1803ED8F0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60032C0")]
				[Address(RVA = "0x3FE240", Offset = "0x3FD240", VA = "0x1803FE240")]
				set
				{
				}
			}

			// Token: 0x170004EE RID: 1262
			// (get) Token: 0x060032C1 RID: 12993 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060032C2 RID: 12994 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004EE")]
			public Sprite selectedSprite
			{
				[Token(Token = "0x60032C1")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60032C2")]
				[Address(RVA = "0x3ED9D0", Offset = "0x3EC9D0", VA = "0x1803ED9D0")]
				set
				{
				}
			}

			// Token: 0x170004EF RID: 1263
			// (get) Token: 0x060032C3 RID: 12995 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060032C4 RID: 12996 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004EF")]
			public Sprite disabledHighlightedSprite
			{
				[Token(Token = "0x60032C3")]
				[Address(RVA = "0x3EDA30", Offset = "0x3ECA30", VA = "0x1803EDA30")]
				get
				{
					return null;
				}
				[Token(Token = "0x60032C4")]
				[Address(RVA = "0x3EDA40", Offset = "0x3ECA40", VA = "0x1803EDA40")]
				set
				{
				}
			}

			// Token: 0x060032C5 RID: 12997 RVA: 0x00011F58 File Offset: 0x00010158
			[Token(Token = "0x60032C5")]
			[Address(RVA = "0xD2FFC0", Offset = "0xD2EFC0", VA = "0x180D2FFC0")]
			public static implicit operator SpriteState(ThemeSettings.CustomSpriteState item)
			{
				return default(SpriteState);
			}

			// Token: 0x04004FC5 RID: 20421
			[Token(Token = "0x4004FC5")]
			[FieldOffset(Offset = "0x0")]
			private Sprite m_DisabledSprite;

			// Token: 0x04004FC6 RID: 20422
			[Token(Token = "0x4004FC6")]
			[FieldOffset(Offset = "0x8")]
			private Sprite m_HighlightedSprite;

			// Token: 0x04004FC7 RID: 20423
			[Token(Token = "0x4004FC7")]
			[FieldOffset(Offset = "0x10")]
			private Sprite m_PressedSprite;

			// Token: 0x04004FC8 RID: 20424
			[Token(Token = "0x4004FC8")]
			[FieldOffset(Offset = "0x18")]
			private Sprite m_SelectedSprite;

			// Token: 0x04004FC9 RID: 20425
			[Token(Token = "0x4004FC9")]
			[FieldOffset(Offset = "0x20")]
			private Sprite m_DisabledHighlightedSprite;
		}

		// Token: 0x02000951 RID: 2385
		[Token(Token = "0x2000951")]
		[Serializable]
		private class CustomAnimationTriggers
		{
			// Token: 0x060032C6 RID: 12998 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60032C6")]
			[Address(RVA = "0xD30160", Offset = "0xD2F160", VA = "0x180D30160")]
			public CustomAnimationTriggers()
			{
			}

			// Token: 0x170004F0 RID: 1264
			// (get) Token: 0x060032C7 RID: 12999 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060032C8 RID: 13000 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004F0")]
			public string disabledTrigger
			{
				[Token(Token = "0x60032C7")]
				[Address(RVA = "0x3ED8F0", Offset = "0x3EC8F0", VA = "0x1803ED8F0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60032C8")]
				[Address(RVA = "0x3FE240", Offset = "0x3FD240", VA = "0x1803FE240")]
				set
				{
				}
			}

			// Token: 0x170004F1 RID: 1265
			// (get) Token: 0x060032C9 RID: 13001 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060032CA RID: 13002 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004F1")]
			public string highlightedTrigger
			{
				[Token(Token = "0x60032C9")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60032CA")]
				[Address(RVA = "0x3ED9D0", Offset = "0x3EC9D0", VA = "0x1803ED9D0")]
				set
				{
				}
			}

			// Token: 0x170004F2 RID: 1266
			// (get) Token: 0x060032CB RID: 13003 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060032CC RID: 13004 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004F2")]
			public string normalTrigger
			{
				[Token(Token = "0x60032CB")]
				[Address(RVA = "0x3EDA30", Offset = "0x3ECA30", VA = "0x1803EDA30")]
				get
				{
					return null;
				}
				[Token(Token = "0x60032CC")]
				[Address(RVA = "0x3EDA40", Offset = "0x3ECA40", VA = "0x1803EDA40")]
				set
				{
				}
			}

			// Token: 0x170004F3 RID: 1267
			// (get) Token: 0x060032CD RID: 13005 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060032CE RID: 13006 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004F3")]
			public string pressedTrigger
			{
				[Token(Token = "0x60032CD")]
				[Address(RVA = "0xD166D0", Offset = "0xD156D0", VA = "0x180D166D0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60032CE")]
				[Address(RVA = "0x3FE2A0", Offset = "0x3FD2A0", VA = "0x1803FE2A0")]
				set
				{
				}
			}

			// Token: 0x170004F4 RID: 1268
			// (get) Token: 0x060032CF RID: 13007 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060032D0 RID: 13008 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004F4")]
			public string selectedTrigger
			{
				[Token(Token = "0x60032CF")]
				[Address(RVA = "0xD166E0", Offset = "0xD156E0", VA = "0x180D166E0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60032D0")]
				[Address(RVA = "0x3F5F80", Offset = "0x3F4F80", VA = "0x1803F5F80")]
				set
				{
				}
			}

			// Token: 0x170004F5 RID: 1269
			// (get) Token: 0x060032D1 RID: 13009 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060032D2 RID: 13010 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004F5")]
			public string disabledHighlightedTrigger
			{
				[Token(Token = "0x60032D1")]
				[Address(RVA = "0xD166F0", Offset = "0xD156F0", VA = "0x180D166F0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60032D2")]
				[Address(RVA = "0xCE9340", Offset = "0xCE8340", VA = "0x180CE9340")]
				set
				{
				}
			}

			// Token: 0x060032D3 RID: 13011 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60032D3")]
			[Address(RVA = "0xD303E0", Offset = "0xD2F3E0", VA = "0x180D303E0")]
			public static implicit operator AnimationTriggers(ThemeSettings.CustomAnimationTriggers item)
			{
				return null;
			}

			// Token: 0x04004FCA RID: 20426
			[Token(Token = "0x4004FCA")]
			[FieldOffset(Offset = "0x10")]
			private string m_DisabledTrigger;

			// Token: 0x04004FCB RID: 20427
			[Token(Token = "0x4004FCB")]
			[FieldOffset(Offset = "0x18")]
			private string m_HighlightedTrigger;

			// Token: 0x04004FCC RID: 20428
			[Token(Token = "0x4004FCC")]
			[FieldOffset(Offset = "0x20")]
			private string m_NormalTrigger;

			// Token: 0x04004FCD RID: 20429
			[Token(Token = "0x4004FCD")]
			[FieldOffset(Offset = "0x28")]
			private string m_PressedTrigger;

			// Token: 0x04004FCE RID: 20430
			[Token(Token = "0x4004FCE")]
			[FieldOffset(Offset = "0x30")]
			private string m_SelectedTrigger;

			// Token: 0x04004FCF RID: 20431
			[Token(Token = "0x4004FCF")]
			[FieldOffset(Offset = "0x38")]
			private string m_DisabledHighlightedTrigger;
		}

		// Token: 0x02000952 RID: 2386
		[Token(Token = "0x2000952")]
		[Serializable]
		private class TextSettings
		{
			// Token: 0x170004F6 RID: 1270
			// (get) Token: 0x060032D4 RID: 13012 RVA: 0x00011F70 File Offset: 0x00010170
			[Token(Token = "0x170004F6")]
			public Color color
			{
				[Token(Token = "0x60032D4")]
				[Address(RVA = "0x414F10", Offset = "0x413F10", VA = "0x180414F10")]
				get
				{
					return default(Color);
				}
			}

			// Token: 0x170004F7 RID: 1271
			// (get) Token: 0x060032D5 RID: 13013 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170004F7")]
			public TMP_FontAsset font
			{
				[Token(Token = "0x60032D5")]
				[Address(RVA = "0x3EDA30", Offset = "0x3ECA30", VA = "0x1803EDA30")]
				get
				{
					return null;
				}
			}

			// Token: 0x170004F8 RID: 1272
			// (get) Token: 0x060032D6 RID: 13014 RVA: 0x00011F88 File Offset: 0x00010188
			[Token(Token = "0x170004F8")]
			public ThemeSettings.FontStyleOverride style
			{
				[Token(Token = "0x60032D6")]
				[Address(RVA = "0xCF6EB0", Offset = "0xCF5EB0", VA = "0x180CF6EB0")]
				get
				{
					return ThemeSettings.FontStyleOverride.Default;
				}
			}

			// Token: 0x170004F9 RID: 1273
			// (get) Token: 0x060032D7 RID: 13015 RVA: 0x00011FA0 File Offset: 0x000101A0
			[Token(Token = "0x170004F9")]
			public float sizeMultiplier
			{
				[Token(Token = "0x60032D7")]
				[Address(RVA = "0xD305F0", Offset = "0xD2F5F0", VA = "0x180D305F0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170004FA RID: 1274
			// (get) Token: 0x060032D8 RID: 13016 RVA: 0x00011FB8 File Offset: 0x000101B8
			[Token(Token = "0x170004FA")]
			public float lineSpacing
			{
				[Token(Token = "0x60032D8")]
				[Address(RVA = "0xD30600", Offset = "0xD2F600", VA = "0x180D30600")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170004FB RID: 1275
			// (get) Token: 0x060032D9 RID: 13017 RVA: 0x00011FD0 File Offset: 0x000101D0
			[Token(Token = "0x170004FB")]
			public float chracterSpacing
			{
				[Token(Token = "0x60032D9")]
				[Address(RVA = "0xD30610", Offset = "0xD2F610", VA = "0x180D30610")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170004FC RID: 1276
			// (get) Token: 0x060032DA RID: 13018 RVA: 0x00011FE8 File Offset: 0x000101E8
			[Token(Token = "0x170004FC")]
			public float wordSpacing
			{
				[Token(Token = "0x60032DA")]
				[Address(RVA = "0xD30620", Offset = "0xD2F620", VA = "0x180D30620")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060032DB RID: 13019 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60032DB")]
			[Address(RVA = "0xD30630", Offset = "0xD2F630", VA = "0x180D30630")]
			public TextSettings()
			{
			}

			// Token: 0x04004FD0 RID: 20432
			[Token(Token = "0x4004FD0")]
			[FieldOffset(Offset = "0x10")]
			private Color _color;

			// Token: 0x04004FD1 RID: 20433
			[Token(Token = "0x4004FD1")]
			[FieldOffset(Offset = "0x20")]
			private TMP_FontAsset _font;

			// Token: 0x04004FD2 RID: 20434
			[Token(Token = "0x4004FD2")]
			[FieldOffset(Offset = "0x28")]
			private ThemeSettings.FontStyleOverride _style;

			// Token: 0x04004FD3 RID: 20435
			[Token(Token = "0x4004FD3")]
			[FieldOffset(Offset = "0x2C")]
			private float _sizeMultiplier;

			// Token: 0x04004FD4 RID: 20436
			[Token(Token = "0x4004FD4")]
			[FieldOffset(Offset = "0x30")]
			private float _lineSpacing;

			// Token: 0x04004FD5 RID: 20437
			[Token(Token = "0x4004FD5")]
			[FieldOffset(Offset = "0x34")]
			private float _characterSpacing;

			// Token: 0x04004FD6 RID: 20438
			[Token(Token = "0x4004FD6")]
			[FieldOffset(Offset = "0x38")]
			private float _wordSpacing;
		}

		// Token: 0x02000953 RID: 2387
		[Token(Token = "0x2000953")]
		private enum FontStyleOverride
		{
			// Token: 0x04004FD8 RID: 20440
			[Token(Token = "0x4004FD8")]
			Default,
			// Token: 0x04004FD9 RID: 20441
			[Token(Token = "0x4004FD9")]
			Normal,
			// Token: 0x04004FDA RID: 20442
			[Token(Token = "0x4004FDA")]
			Bold,
			// Token: 0x04004FDB RID: 20443
			[Token(Token = "0x4004FDB")]
			Italic,
			// Token: 0x04004FDC RID: 20444
			[Token(Token = "0x4004FDC")]
			BoldAndItalic
		}
	}
}
