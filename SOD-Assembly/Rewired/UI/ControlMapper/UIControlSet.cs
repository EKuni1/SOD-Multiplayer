using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x02000956 RID: 2390
	[Token(Token = "0x2000956")]
	public class UIControlSet : MonoBehaviour
	{
		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060032E4 RID: 13028 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004FF")]
		private Dictionary<int, UIControl> controls
		{
			[Token(Token = "0x60032E4")]
			[Address(RVA = "0xD308F0", Offset = "0xD2F8F0", VA = "0x180D308F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E5")]
		[Address(RVA = "0xD309E0", Offset = "0xD2F9E0", VA = "0x180D309E0")]
		public void SetTitle(string text)
		{
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60032E6")]
		public T GetControl<T>(int uniqueId) where T : UIControl
		{
			return null;
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60032E7")]
		[Address(RVA = "0xD30B10", Offset = "0xD2FB10", VA = "0x180D30B10")]
		public UISliderControl CreateSlider(GameObject prefab, Sprite icon, float minValue, float maxValue, Action<int, float> valueChangedCallback, Action<int> cancelCallback)
		{
			return null;
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60032E8")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public UIControlSet()
		{
		}

		// Token: 0x04004FE1 RID: 20449
		[Token(Token = "0x4004FE1")]
		[FieldOffset(Offset = "0x18")]
		private TMP_Text title;

		// Token: 0x04004FE2 RID: 20450
		[Token(Token = "0x4004FE2")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, UIControl> _controls;

		// Token: 0x02000957 RID: 2391
		[Token(Token = "0x2000957")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x060032E9 RID: 13033 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60032E9")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x060032EA RID: 13034 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60032EA")]
			[Address(RVA = "0xD31270", Offset = "0xD30270", VA = "0x180D31270")]
			internal void <CreateSlider>b__0(float value)
			{
			}

			// Token: 0x060032EB RID: 13035 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60032EB")]
			[Address(RVA = "0xD312B0", Offset = "0xD302B0", VA = "0x180D312B0")]
			internal void <CreateSlider>b__1()
			{
			}

			// Token: 0x04004FE3 RID: 20451
			[Token(Token = "0x4004FE3")]
			[FieldOffset(Offset = "0x10")]
			public Action<int, float> valueChangedCallback;

			// Token: 0x04004FE4 RID: 20452
			[Token(Token = "0x4004FE4")]
			[FieldOffset(Offset = "0x18")]
			public UISliderControl control;

			// Token: 0x04004FE5 RID: 20453
			[Token(Token = "0x4004FE5")]
			[FieldOffset(Offset = "0x20")]
			public Action<int> cancelCallback;
		}
	}
}
