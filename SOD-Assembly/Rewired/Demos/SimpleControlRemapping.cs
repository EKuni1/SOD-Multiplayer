using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos
{
	// Token: 0x02000989 RID: 2441
	[Token(Token = "0x2000989")]
	public class SimpleControlRemapping : MonoBehaviour
	{
		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06003462 RID: 13410 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000537")]
		private Player player
		{
			[Token(Token = "0x6003462")]
			[Address(RVA = "0xD54530", Offset = "0xD53530", VA = "0x180D54530")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06003463 RID: 13411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000538")]
		private ControllerMap controllerMap
		{
			[Token(Token = "0x6003463")]
			[Address(RVA = "0xD54590", Offset = "0xD53590", VA = "0x180D54590")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06003464 RID: 13412 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000539")]
		private Controller controller
		{
			[Token(Token = "0x6003464")]
			[Address(RVA = "0xD546B0", Offset = "0xD536B0", VA = "0x180D546B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003465")]
		[Address(RVA = "0xD54730", Offset = "0xD53730", VA = "0x180D54730")]
		private void OnEnable()
		{
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003466")]
		[Address(RVA = "0xD549C0", Offset = "0xD539C0", VA = "0x180D549C0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003467")]
		[Address(RVA = "0xD54B00", Offset = "0xD53B00", VA = "0x180D54B00")]
		private void RedrawUI()
		{
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003468")]
		[Address(RVA = "0xD550E0", Offset = "0xD540E0", VA = "0x180D550E0")]
		private void ClearUI()
		{
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003469")]
		[Address(RVA = "0xD55240", Offset = "0xD54240", VA = "0x180D55240")]
		private void InitializeUI()
		{
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600346A")]
		[Address(RVA = "0xD55B20", Offset = "0xD54B20", VA = "0x180D55B20")]
		private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
		{
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600346B")]
		[Address(RVA = "0xD56040", Offset = "0xD55040", VA = "0x180D56040")]
		private void SetSelectedController(ControllerType controllerType)
		{
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600346C")]
		[Address(RVA = "0xD561D0", Offset = "0xD551D0", VA = "0x180D561D0")]
		public void OnControllerSelected(int controllerType)
		{
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600346D")]
		[Address(RVA = "0xD561E0", Offset = "0xD551E0", VA = "0x180D561E0")]
		private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
		{
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600346E")]
		[Address(RVA = "0xD56300", Offset = "0xD55300", VA = "0x180D56300")]
		private IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId)
		{
			return null;
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600346F")]
		[Address(RVA = "0xD563C0", Offset = "0xD553C0", VA = "0x180D563C0")]
		private void OnControllerChanged(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003470")]
		[Address(RVA = "0xD563D0", Offset = "0xD553D0", VA = "0x180D563D0")]
		private void OnInputMapped(InputMapper.InputMappedEventData data)
		{
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003471")]
		[Address(RVA = "0xD563E0", Offset = "0xD553E0", VA = "0x180D563E0")]
		private void OnStopped(InputMapper.StoppedEventData data)
		{
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003472")]
		[Address(RVA = "0xD564D0", Offset = "0xD554D0", VA = "0x180D564D0")]
		public SimpleControlRemapping()
		{
		}

		// Token: 0x040050E6 RID: 20710
		[Token(Token = "0x40050E6")]
		private const string category = "Default";

		// Token: 0x040050E7 RID: 20711
		[Token(Token = "0x40050E7")]
		private const string layout = "Default";

		// Token: 0x040050E8 RID: 20712
		[Token(Token = "0x40050E8")]
		private const string uiCategory = "UI";

		// Token: 0x040050E9 RID: 20713
		[Token(Token = "0x40050E9")]
		[FieldOffset(Offset = "0x18")]
		private InputMapper inputMapper;

		// Token: 0x040050EA RID: 20714
		[Token(Token = "0x40050EA")]
		[FieldOffset(Offset = "0x20")]
		public GameObject buttonPrefab;

		// Token: 0x040050EB RID: 20715
		[Token(Token = "0x40050EB")]
		[FieldOffset(Offset = "0x28")]
		public GameObject textPrefab;

		// Token: 0x040050EC RID: 20716
		[Token(Token = "0x40050EC")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform fieldGroupTransform;

		// Token: 0x040050ED RID: 20717
		[Token(Token = "0x40050ED")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform actionGroupTransform;

		// Token: 0x040050EE RID: 20718
		[Token(Token = "0x40050EE")]
		[FieldOffset(Offset = "0x40")]
		public Text controllerNameUIText;

		// Token: 0x040050EF RID: 20719
		[Token(Token = "0x40050EF")]
		[FieldOffset(Offset = "0x48")]
		public Text statusUIText;

		// Token: 0x040050F0 RID: 20720
		[Token(Token = "0x40050F0")]
		[FieldOffset(Offset = "0x50")]
		private ControllerType selectedControllerType;

		// Token: 0x040050F1 RID: 20721
		[Token(Token = "0x40050F1")]
		[FieldOffset(Offset = "0x54")]
		private int selectedControllerId;

		// Token: 0x040050F2 RID: 20722
		[Token(Token = "0x40050F2")]
		[FieldOffset(Offset = "0x58")]
		private List<SimpleControlRemapping.Row> rows;

		// Token: 0x0200098A RID: 2442
		[Token(Token = "0x200098A")]
		private class Row
		{
			// Token: 0x06003473 RID: 13427 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003473")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public Row()
			{
			}

			// Token: 0x040050F3 RID: 20723
			[Token(Token = "0x40050F3")]
			[FieldOffset(Offset = "0x10")]
			public InputAction action;

			// Token: 0x040050F4 RID: 20724
			[Token(Token = "0x40050F4")]
			[FieldOffset(Offset = "0x18")]
			public AxisRange actionRange;

			// Token: 0x040050F5 RID: 20725
			[Token(Token = "0x40050F5")]
			[FieldOffset(Offset = "0x20")]
			public Button button;

			// Token: 0x040050F6 RID: 20726
			[Token(Token = "0x40050F6")]
			[FieldOffset(Offset = "0x28")]
			public Text text;
		}

		// Token: 0x0200098B RID: 2443
		[Token(Token = "0x200098B")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06003474 RID: 13428 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003474")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x06003475 RID: 13429 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003475")]
			[Address(RVA = "0xD56660", Offset = "0xD55660", VA = "0x180D56660")]
			internal void <RedrawUI>b__0()
			{
			}

			// Token: 0x040050F7 RID: 20727
			[Token(Token = "0x40050F7")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x040050F8 RID: 20728
			[Token(Token = "0x40050F8")]
			[FieldOffset(Offset = "0x14")]
			public int actionElementMapId;

			// Token: 0x040050F9 RID: 20729
			[Token(Token = "0x40050F9")]
			[FieldOffset(Offset = "0x18")]
			public SimpleControlRemapping <>4__this;
		}

		// Token: 0x0200098C RID: 2444
		[Token(Token = "0x200098C")]
		private sealed class <StartListeningDelayed>d__28 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x06003476 RID: 13430 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003476")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <StartListeningDelayed>d__28(int <>1__state)
			{
			}

			// Token: 0x06003477 RID: 13431 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003477")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x06003478 RID: 13432 RVA: 0x00012588 File Offset: 0x00010788
			[Token(Token = "0x6003478")]
			[Address(RVA = "0xD56790", Offset = "0xD55790", VA = "0x180D56790", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700053A RID: 1338
			// (get) Token: 0x06003479 RID: 13433 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700053A")]
			private object Current
			{
				[Token(Token = "0x6003479")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600347A RID: 13434 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600347A")]
			[Address(RVA = "0xD56A60", Offset = "0xD55A60", VA = "0x180D56A60", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x1700053B RID: 1339
			// (get) Token: 0x0600347B RID: 13435 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700053B")]
			private object Current
			{
				[Token(Token = "0x600347B")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x040050FA RID: 20730
			[Token(Token = "0x40050FA")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040050FB RID: 20731
			[Token(Token = "0x40050FB")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040050FC RID: 20732
			[Token(Token = "0x40050FC")]
			[FieldOffset(Offset = "0x20")]
			public SimpleControlRemapping <>4__this;

			// Token: 0x040050FD RID: 20733
			[Token(Token = "0x40050FD")]
			[FieldOffset(Offset = "0x28")]
			public int index;

			// Token: 0x040050FE RID: 20734
			[Token(Token = "0x40050FE")]
			[FieldOffset(Offset = "0x2C")]
			public int actionElementMapToReplaceId;
		}
	}
}
