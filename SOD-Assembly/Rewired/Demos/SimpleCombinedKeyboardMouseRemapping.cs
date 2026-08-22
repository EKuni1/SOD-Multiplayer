using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos
{
	// Token: 0x02000984 RID: 2436
	[Token(Token = "0x2000984")]
	public class SimpleCombinedKeyboardMouseRemapping : MonoBehaviour
	{
		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000534")]
		private Player player
		{
			[Token(Token = "0x600344D")]
			[Address(RVA = "0xD51F70", Offset = "0xD50F70", VA = "0x180D51F70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344E")]
		[Address(RVA = "0xD51FD0", Offset = "0xD50FD0", VA = "0x180D51FD0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344F")]
		[Address(RVA = "0xD522B0", Offset = "0xD512B0", VA = "0x180D522B0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003450")]
		[Address(RVA = "0xD52390", Offset = "0xD51390", VA = "0x180D52390")]
		private void RedrawUI()
		{
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003451")]
		[Address(RVA = "0xD528A0", Offset = "0xD518A0", VA = "0x180D528A0")]
		private void ClearUI()
		{
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003452")]
		[Address(RVA = "0xD529D0", Offset = "0xD519D0", VA = "0x180D529D0")]
		private void InitializeUI()
		{
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003453")]
		[Address(RVA = "0xD532B0", Offset = "0xD522B0", VA = "0x180D532B0")]
		private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
		{
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003454")]
		[Address(RVA = "0xD537D0", Offset = "0xD527D0", VA = "0x180D537D0")]
		private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
		{
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003455")]
		[Address(RVA = "0xD53B40", Offset = "0xD52B40", VA = "0x180D53B40")]
		private IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId)
		{
			return null;
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003456")]
		[Address(RVA = "0xD53CC0", Offset = "0xD52CC0", VA = "0x180D53CC0")]
		private void OnInputMapped(InputMapper.InputMappedEventData data)
		{
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003457")]
		[Address(RVA = "0xD53DD0", Offset = "0xD52DD0", VA = "0x180D53DD0")]
		private void OnStopped(InputMapper.StoppedEventData data)
		{
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003458")]
		[Address(RVA = "0xD53EC0", Offset = "0xD52EC0", VA = "0x180D53EC0")]
		public SimpleCombinedKeyboardMouseRemapping()
		{
		}

		// Token: 0x040050C9 RID: 20681
		[Token(Token = "0x40050C9")]
		private const string category = "Default";

		// Token: 0x040050CA RID: 20682
		[Token(Token = "0x40050CA")]
		private const string layout = "Default";

		// Token: 0x040050CB RID: 20683
		[Token(Token = "0x40050CB")]
		private const string uiCategory = "UI";

		// Token: 0x040050CC RID: 20684
		[Token(Token = "0x40050CC")]
		[FieldOffset(Offset = "0x18")]
		private InputMapper inputMapper_keyboard;

		// Token: 0x040050CD RID: 20685
		[Token(Token = "0x40050CD")]
		[FieldOffset(Offset = "0x20")]
		private InputMapper inputMapper_mouse;

		// Token: 0x040050CE RID: 20686
		[Token(Token = "0x40050CE")]
		[FieldOffset(Offset = "0x28")]
		public GameObject buttonPrefab;

		// Token: 0x040050CF RID: 20687
		[Token(Token = "0x40050CF")]
		[FieldOffset(Offset = "0x30")]
		public GameObject textPrefab;

		// Token: 0x040050D0 RID: 20688
		[Token(Token = "0x40050D0")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform fieldGroupTransform;

		// Token: 0x040050D1 RID: 20689
		[Token(Token = "0x40050D1")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform actionGroupTransform;

		// Token: 0x040050D2 RID: 20690
		[Token(Token = "0x40050D2")]
		[FieldOffset(Offset = "0x48")]
		public Text controllerNameUIText;

		// Token: 0x040050D3 RID: 20691
		[Token(Token = "0x40050D3")]
		[FieldOffset(Offset = "0x50")]
		public Text statusUIText;

		// Token: 0x040050D4 RID: 20692
		[Token(Token = "0x40050D4")]
		[FieldOffset(Offset = "0x58")]
		private List<SimpleCombinedKeyboardMouseRemapping.Row> rows;

		// Token: 0x040050D5 RID: 20693
		[Token(Token = "0x40050D5")]
		[FieldOffset(Offset = "0x60")]
		private SimpleCombinedKeyboardMouseRemapping.TargetMapping _replaceTargetMapping;

		// Token: 0x02000985 RID: 2437
		[Token(Token = "0x2000985")]
		private class Row
		{
			// Token: 0x06003459 RID: 13401 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003459")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public Row()
			{
			}

			// Token: 0x040050D6 RID: 20694
			[Token(Token = "0x40050D6")]
			[FieldOffset(Offset = "0x10")]
			public InputAction action;

			// Token: 0x040050D7 RID: 20695
			[Token(Token = "0x40050D7")]
			[FieldOffset(Offset = "0x18")]
			public AxisRange actionRange;

			// Token: 0x040050D8 RID: 20696
			[Token(Token = "0x40050D8")]
			[FieldOffset(Offset = "0x20")]
			public Button button;

			// Token: 0x040050D9 RID: 20697
			[Token(Token = "0x40050D9")]
			[FieldOffset(Offset = "0x28")]
			public Text text;
		}

		// Token: 0x02000986 RID: 2438
		[Token(Token = "0x2000986")]
		private struct TargetMapping
		{
			// Token: 0x040050DA RID: 20698
			[Token(Token = "0x40050DA")]
			[FieldOffset(Offset = "0x0")]
			public ControllerMap controllerMap;

			// Token: 0x040050DB RID: 20699
			[Token(Token = "0x40050DB")]
			[FieldOffset(Offset = "0x8")]
			public int actionElementMapId;
		}

		// Token: 0x02000987 RID: 2439
		[Token(Token = "0x2000987")]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x0600345A RID: 13402 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600345A")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass17_0()
			{
			}

			// Token: 0x0600345B RID: 13403 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600345B")]
			[Address(RVA = "0xD540C0", Offset = "0xD530C0", VA = "0x180D540C0")]
			internal void <RedrawUI>b__0()
			{
			}

			// Token: 0x040050DC RID: 20700
			[Token(Token = "0x40050DC")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x040050DD RID: 20701
			[Token(Token = "0x40050DD")]
			[FieldOffset(Offset = "0x14")]
			public int actionElementMapId;

			// Token: 0x040050DE RID: 20702
			[Token(Token = "0x40050DE")]
			[FieldOffset(Offset = "0x18")]
			public SimpleCombinedKeyboardMouseRemapping <>4__this;
		}

		// Token: 0x02000988 RID: 2440
		[Token(Token = "0x2000988")]
		private sealed class <StartListeningDelayed>d__22 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x0600345C RID: 13404 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600345C")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <StartListeningDelayed>d__22(int <>1__state)
			{
			}

			// Token: 0x0600345D RID: 13405 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600345D")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x0600345E RID: 13406 RVA: 0x00012570 File Offset: 0x00010770
			[Token(Token = "0x600345E")]
			[Address(RVA = "0xD540F0", Offset = "0xD530F0", VA = "0x180D540F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000535 RID: 1333
			// (get) Token: 0x0600345F RID: 13407 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000535")]
			private object Current
			{
				[Token(Token = "0x600345F")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003460 RID: 13408 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003460")]
			[Address(RVA = "0xD544E0", Offset = "0xD534E0", VA = "0x180D544E0", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000536 RID: 1334
			// (get) Token: 0x06003461 RID: 13409 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000536")]
			private object Current
			{
				[Token(Token = "0x6003461")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x040050DF RID: 20703
			[Token(Token = "0x40050DF")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040050E0 RID: 20704
			[Token(Token = "0x40050E0")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040050E1 RID: 20705
			[Token(Token = "0x40050E1")]
			[FieldOffset(Offset = "0x20")]
			public SimpleCombinedKeyboardMouseRemapping <>4__this;

			// Token: 0x040050E2 RID: 20706
			[Token(Token = "0x40050E2")]
			[FieldOffset(Offset = "0x28")]
			public int index;

			// Token: 0x040050E3 RID: 20707
			[Token(Token = "0x40050E3")]
			[FieldOffset(Offset = "0x30")]
			public ControllerMap keyboardMap;

			// Token: 0x040050E4 RID: 20708
			[Token(Token = "0x40050E4")]
			[FieldOffset(Offset = "0x38")]
			public int actionElementMapToReplaceId;

			// Token: 0x040050E5 RID: 20709
			[Token(Token = "0x40050E5")]
			[FieldOffset(Offset = "0x40")]
			public ControllerMap mouseMap;
		}
	}
}
