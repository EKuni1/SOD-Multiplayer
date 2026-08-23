using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos
{
	// Token: 0x0200098F RID: 2447
	[Token(Token = "0x200098F")]
	public class SimpleControlRemappingSOD : MonoBehaviour
	{
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06003489 RID: 13449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700053E")]
		public static SimpleControlRemappingSOD Instance
		{
			[Token(Token = "0x6003489")]
			[Address(RVA = "0xD57460", Offset = "0xD56460", VA = "0x180D57460")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348A")]
		[Address(RVA = "0xD574A0", Offset = "0xD564A0", VA = "0x180D574A0")]
		private void Awake()
		{
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348B")]
		[Address(RVA = "0xD57890", Offset = "0xD56890", VA = "0x180D57890")]
		public void UpdateSelectedCategory(string newCategory)
		{
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348C")]
		[Address(RVA = "0xD57900", Offset = "0xD56900", VA = "0x180D57900")]
		private void OnEnable()
		{
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348D")]
		[Address(RVA = "0xD57F90", Offset = "0xD56F90", VA = "0x180D57F90")]
		private void OnDisable()
		{
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348E")]
		[Address(RVA = "0xD581B0", Offset = "0xD571B0", VA = "0x180D581B0")]
		private void RedrawUI()
		{
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348F")]
		[Address(RVA = "0xD59430", Offset = "0xD58430", VA = "0x180D59430")]
		private void ClearUI()
		{
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003490")]
		[Address(RVA = "0xD599F0", Offset = "0xD589F0", VA = "0x180D599F0")]
		public void InitializeUI()
		{
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003491")]
		[Address(RVA = "0xD59F70", Offset = "0xD58F70", VA = "0x180D59F70")]
		private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
		{
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003492")]
		[Address(RVA = "0xD5AF20", Offset = "0xD59F20", VA = "0x180D5AF20")]
		private void SetSelectedController(ControllerType controllerType)
		{
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003493")]
		[Address(RVA = "0xD5B400", Offset = "0xD5A400", VA = "0x180D5B400")]
		public void OnControllerSelected(int controllerType)
		{
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003494")]
		[Address(RVA = "0xD5B410", Offset = "0xD5A410", VA = "0x180D5B410")]
		public void ResetControls()
		{
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003495")]
		[Address(RVA = "0xD5B880", Offset = "0xD5A880", VA = "0x180D5B880")]
		public void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
		{
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003496")]
		[Address(RVA = "0xD5BF80", Offset = "0xD5AF80", VA = "0x180D5BF80")]
		private IEnumerator StartListeningJoystickDelayed(int index, ControllerMap joyMap, int actionElementMapToReplaceId)
		{
			return null;
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003497")]
		[Address(RVA = "0xD5C0B0", Offset = "0xD5B0B0", VA = "0x180D5C0B0")]
		private IEnumerator StartListeningMkbDelayed(int index, ControllerMap keyMap, ControllerMap mouseMap, int actionElementMapToReplaceId)
		{
			return null;
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003498")]
		[Address(RVA = "0xD5C230", Offset = "0xD5B230", VA = "0x180D5C230")]
		private IEnumerator ListeningAutoCancel(ButtonController uiButton)
		{
			return null;
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003499")]
		[Address(RVA = "0xD5C340", Offset = "0xD5B340", VA = "0x180D5C340")]
		private void UpdateUIText(ButtonController uiButton, int counter)
		{
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600349A")]
		[Address(RVA = "0xD5C600", Offset = "0xD5B600", VA = "0x180D5C600")]
		private void UpdateButtonInteractability(bool isInteractable)
		{
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600349B")]
		[Address(RVA = "0xD5CD50", Offset = "0xD5BD50", VA = "0x180D5CD50")]
		private void OnInputMapped(InputMapper.InputMappedEventData data)
		{
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600349C")]
		[Address(RVA = "0xD5D020", Offset = "0xD5C020", VA = "0x180D5D020")]
		private void OnStopped(InputMapper.StoppedEventData data)
		{
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600349D")]
		[Address(RVA = "0xD5D380", Offset = "0xD5C380", VA = "0x180D5D380")]
		public void ReplaceControl(ControllerMap map, ElementAssignmentConflictInfo info)
		{
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600349E")]
		[Address(RVA = "0xD5D760", Offset = "0xD5C760", VA = "0x180D5D760")]
		public void TestAssign()
		{
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600349F")]
		[Address(RVA = "0xD5DD90", Offset = "0xD5CD90", VA = "0x180D5DD90")]
		public void RevertControl(ControllerMap map, ElementAssignmentConflictInfo info)
		{
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public void StopMapping(bool removeEvents = false)
		{
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034A1")]
		[Address(RVA = "0xD5E0E0", Offset = "0xD5D0E0", VA = "0x180D5E0E0")]
		private IEnumerator RemapDelay()
		{
			return null;
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A2")]
		[Address(RVA = "0xD5E180", Offset = "0xD5D180", VA = "0x180D5E180")]
		private void OnControllerChanged(ControllerStatusChangedEventArgs args)
		{
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A3")]
		[Address(RVA = "0xD5E190", Offset = "0xD5D190", VA = "0x180D5E190")]
		public SimpleControlRemappingSOD()
		{
		}

		// Token: 0x04005104 RID: 20740
		[Token(Token = "0x4005104")]
		[FieldOffset(Offset = "0x18")]
		public string category;

		// Token: 0x04005105 RID: 20741
		[Token(Token = "0x4005105")]
		[FieldOffset(Offset = "0x20")]
		private List<string> categories;

		// Token: 0x04005106 RID: 20742
		[Token(Token = "0x4005106")]
		private const string layout = "Default";

		// Token: 0x04005107 RID: 20743
		[Token(Token = "0x4005107")]
		private const string uiCategory = "JoystickUI";

		// Token: 0x04005108 RID: 20744
		[Token(Token = "0x4005108")]
		[FieldOffset(Offset = "0x28")]
		public bool enableInputMapping;

		// Token: 0x04005109 RID: 20745
		[Token(Token = "0x4005109")]
		[FieldOffset(Offset = "0x29")]
		public bool listeningForRemap;

		// Token: 0x0400510A RID: 20746
		[Token(Token = "0x400510A")]
		[FieldOffset(Offset = "0x30")]
		public List<string> mkbExceptions;

		// Token: 0x0400510B RID: 20747
		[Token(Token = "0x400510B")]
		[FieldOffset(Offset = "0x38")]
		public List<string> joystickExceptions;

		// Token: 0x0400510C RID: 20748
		[Token(Token = "0x400510C")]
		[FieldOffset(Offset = "0x40")]
		private InputMapper keyboardMapper;

		// Token: 0x0400510D RID: 20749
		[Token(Token = "0x400510D")]
		[FieldOffset(Offset = "0x48")]
		private InputMapper mouseMapper;

		// Token: 0x0400510E RID: 20750
		[Token(Token = "0x400510E")]
		[FieldOffset(Offset = "0x50")]
		private InputMapper gamepadMapper;

		// Token: 0x0400510F RID: 20751
		[Token(Token = "0x400510F")]
		[FieldOffset(Offset = "0x58")]
		public GameObject buttonPrefab;

		// Token: 0x04005110 RID: 20752
		[Token(Token = "0x4005110")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform fieldGroupTransform;

		// Token: 0x04005111 RID: 20753
		[Token(Token = "0x4005111")]
		[FieldOffset(Offset = "0x68")]
		public TextMeshProUGUI statusUIText;

		// Token: 0x04005112 RID: 20754
		[Token(Token = "0x4005112")]
		[FieldOffset(Offset = "0x70")]
		public ToggleController schemeToggle;

		// Token: 0x04005113 RID: 20755
		[Token(Token = "0x4005113")]
		[FieldOffset(Offset = "0x78")]
		public ButtonController backButton;

		// Token: 0x04005114 RID: 20756
		[Token(Token = "0x4005114")]
		[FieldOffset(Offset = "0x80")]
		public ButtonController resetControlsButton;

		// Token: 0x04005115 RID: 20757
		[Token(Token = "0x4005115")]
		[FieldOffset(Offset = "0x88")]
		public Button aboveButton;

		// Token: 0x04005116 RID: 20758
		[Token(Token = "0x4005116")]
		[FieldOffset(Offset = "0x90")]
		public Button aboveButton2;

		// Token: 0x04005117 RID: 20759
		[Token(Token = "0x4005117")]
		[FieldOffset(Offset = "0x98")]
		public ButtonController interactionButton;

		// Token: 0x04005118 RID: 20760
		[Token(Token = "0x4005118")]
		[FieldOffset(Offset = "0xA0")]
		public ButtonController movementButton;

		// Token: 0x04005119 RID: 20761
		[Token(Token = "0x4005119")]
		[FieldOffset(Offset = "0xA8")]
		public ButtonController menuButton;

		// Token: 0x0400511A RID: 20762
		[Token(Token = "0x400511A")]
		[FieldOffset(Offset = "0xB0")]
		public ButtonController cityEditButton;

		// Token: 0x0400511B RID: 20763
		[Token(Token = "0x400511B")]
		[FieldOffset(Offset = "0xB8")]
		public VerticalLayoutGroup layoutGroup;

		// Token: 0x0400511C RID: 20764
		[Token(Token = "0x400511C")]
		[FieldOffset(Offset = "0xC0")]
		public ControllerType selectedControllerType;

		// Token: 0x0400511D RID: 20765
		[Token(Token = "0x400511D")]
		[FieldOffset(Offset = "0xC4")]
		private int selectedControllerId;

		// Token: 0x0400511E RID: 20766
		[Token(Token = "0x400511E")]
		[FieldOffset(Offset = "0xC8")]
		public int debugInt;

		// Token: 0x0400511F RID: 20767
		[Token(Token = "0x400511F")]
		[FieldOffset(Offset = "0xCC")]
		public int debugSwap;

		// Token: 0x04005120 RID: 20768
		[Token(Token = "0x4005120")]
		[FieldOffset(Offset = "0xD0")]
		public List<SimpleControlRemappingSOD.Row> rows;

		// Token: 0x04005121 RID: 20769
		[Token(Token = "0x4005121")]
		[FieldOffset(Offset = "0xD8")]
		public List<UITextSeparator> labels;

		// Token: 0x04005122 RID: 20770
		[Token(Token = "0x4005122")]
		[FieldOffset(Offset = "0xE0")]
		private SimpleControlRemappingSOD.TargetMapping _replaceTargetMapping;

		// Token: 0x04005123 RID: 20771
		[Token(Token = "0x4005123")]
		[FieldOffset(Offset = "0xF0")]
		private SimpleControlRemappingSOD.Row _currentRow;

		// Token: 0x04005124 RID: 20772
		[Token(Token = "0x4005124")]
		[FieldOffset(Offset = "0xF8")]
		private List<Controller> controllers;

		// Token: 0x04005125 RID: 20773
		[Token(Token = "0x4005125")]
		[FieldOffset(Offset = "0x100")]
		private List<ControllerMap> controllerMaps;

		// Token: 0x04005126 RID: 20774
		[Token(Token = "0x4005126")]
		[FieldOffset(Offset = "0x108")]
		private Player _player;

		// Token: 0x04005127 RID: 20775
		[Token(Token = "0x4005127")]
		[FieldOffset(Offset = "0x0")]
		private static SimpleControlRemappingSOD _instance;

		// Token: 0x02000990 RID: 2448
		[Token(Token = "0x2000990")]
		[Serializable]
		public class Row
		{
			// Token: 0x060034A4 RID: 13476 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034A4")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public Row()
			{
			}

			// Token: 0x04005128 RID: 20776
			[Token(Token = "0x4005128")]
			[FieldOffset(Offset = "0x10")]
			public InputAction action;

			// Token: 0x04005129 RID: 20777
			[Token(Token = "0x4005129")]
			[FieldOffset(Offset = "0x18")]
			public AxisRange actionRange;

			// Token: 0x0400512A RID: 20778
			[Token(Token = "0x400512A")]
			[FieldOffset(Offset = "0x20")]
			public RemapController button;
		}

		// Token: 0x02000991 RID: 2449
		[Token(Token = "0x2000991")]
		[Serializable]
		private struct TargetMapping
		{
			// Token: 0x0400512B RID: 20779
			[Token(Token = "0x400512B")]
			[FieldOffset(Offset = "0x0")]
			public ControllerMap controllerMap;

			// Token: 0x0400512C RID: 20780
			[Token(Token = "0x400512C")]
			[FieldOffset(Offset = "0x8")]
			public int actionElementMapId;
		}

		// Token: 0x02000992 RID: 2450
		[Token(Token = "0x2000992")]
		[Serializable]
		private struct Mapping
		{
			// Token: 0x0400512D RID: 20781
			[Token(Token = "0x400512D")]
			[FieldOffset(Offset = "0x0")]
			public InputMapper mapper;

			// Token: 0x0400512E RID: 20782
			[Token(Token = "0x400512E")]
			[FieldOffset(Offset = "0x8")]
			public ControllerMap map;
		}

		// Token: 0x02000993 RID: 2451
		[Token(Token = "0x2000993")]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x060034A5 RID: 13477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034A5")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass42_0()
			{
			}

			// Token: 0x060034A6 RID: 13478 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034A6")]
			[Address(RVA = "0xD5E890", Offset = "0xD5D890", VA = "0x180D5E890")]
			internal void <RedrawUI>b__0()
			{
			}

			// Token: 0x0400512F RID: 20783
			[Token(Token = "0x400512F")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x04005130 RID: 20784
			[Token(Token = "0x4005130")]
			[FieldOffset(Offset = "0x14")]
			public int actionElementMapId;

			// Token: 0x04005131 RID: 20785
			[Token(Token = "0x4005131")]
			[FieldOffset(Offset = "0x18")]
			public SimpleControlRemappingSOD <>4__this;
		}

		// Token: 0x02000994 RID: 2452
		[Token(Token = "0x2000994")]
		private sealed class <StartListeningJoystickDelayed>d__50 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x060034A7 RID: 13479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034A7")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <StartListeningJoystickDelayed>d__50(int <>1__state)
			{
			}

			// Token: 0x060034A8 RID: 13480 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034A8")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x060034A9 RID: 13481 RVA: 0x000125B8 File Offset: 0x000107B8
			[Token(Token = "0x60034A9")]
			[Address(RVA = "0xD5E8C0", Offset = "0xD5D8C0", VA = "0x180D5E8C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700053F RID: 1343
			// (get) Token: 0x060034AA RID: 13482 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700053F")]
			private object Current
			{
				[Token(Token = "0x60034AA")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060034AB RID: 13483 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034AB")]
			[Address(RVA = "0xD5EED0", Offset = "0xD5DED0", VA = "0x180D5EED0", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000540 RID: 1344
			// (get) Token: 0x060034AC RID: 13484 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000540")]
			private object Current
			{
				[Token(Token = "0x60034AC")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04005132 RID: 20786
			[Token(Token = "0x4005132")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04005133 RID: 20787
			[Token(Token = "0x4005133")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04005134 RID: 20788
			[Token(Token = "0x4005134")]
			[FieldOffset(Offset = "0x20")]
			public SimpleControlRemappingSOD <>4__this;

			// Token: 0x04005135 RID: 20789
			[Token(Token = "0x4005135")]
			[FieldOffset(Offset = "0x28")]
			public int index;

			// Token: 0x04005136 RID: 20790
			[Token(Token = "0x4005136")]
			[FieldOffset(Offset = "0x30")]
			public ControllerMap joyMap;

			// Token: 0x04005137 RID: 20791
			[Token(Token = "0x4005137")]
			[FieldOffset(Offset = "0x38")]
			public int actionElementMapToReplaceId;
		}

		// Token: 0x02000995 RID: 2453
		[Token(Token = "0x2000995")]
		private sealed class <StartListeningMkbDelayed>d__51 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x060034AD RID: 13485 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034AD")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <StartListeningMkbDelayed>d__51(int <>1__state)
			{
			}

			// Token: 0x060034AE RID: 13486 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034AE")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x060034AF RID: 13487 RVA: 0x000125D0 File Offset: 0x000107D0
			[Token(Token = "0x60034AF")]
			[Address(RVA = "0xD5EF20", Offset = "0xD5DF20", VA = "0x180D5EF20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000541 RID: 1345
			// (get) Token: 0x060034B0 RID: 13488 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000541")]
			private object Current
			{
				[Token(Token = "0x60034B0")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060034B1 RID: 13489 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034B1")]
			[Address(RVA = "0xD5F660", Offset = "0xD5E660", VA = "0x180D5F660", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000542 RID: 1346
			// (get) Token: 0x060034B2 RID: 13490 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000542")]
			private object Current
			{
				[Token(Token = "0x60034B2")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04005138 RID: 20792
			[Token(Token = "0x4005138")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04005139 RID: 20793
			[Token(Token = "0x4005139")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400513A RID: 20794
			[Token(Token = "0x400513A")]
			[FieldOffset(Offset = "0x20")]
			public SimpleControlRemappingSOD <>4__this;

			// Token: 0x0400513B RID: 20795
			[Token(Token = "0x400513B")]
			[FieldOffset(Offset = "0x28")]
			public int index;

			// Token: 0x0400513C RID: 20796
			[Token(Token = "0x400513C")]
			[FieldOffset(Offset = "0x30")]
			public ControllerMap keyMap;

			// Token: 0x0400513D RID: 20797
			[Token(Token = "0x400513D")]
			[FieldOffset(Offset = "0x38")]
			public int actionElementMapToReplaceId;

			// Token: 0x0400513E RID: 20798
			[Token(Token = "0x400513E")]
			[FieldOffset(Offset = "0x40")]
			public ControllerMap mouseMap;
		}

		// Token: 0x02000996 RID: 2454
		[Token(Token = "0x2000996")]
		private sealed class <ListeningAutoCancel>d__52 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x060034B3 RID: 13491 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034B3")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <ListeningAutoCancel>d__52(int <>1__state)
			{
			}

			// Token: 0x060034B4 RID: 13492 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034B4")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x060034B5 RID: 13493 RVA: 0x000125E8 File Offset: 0x000107E8
			[Token(Token = "0x60034B5")]
			[Address(RVA = "0xD5F6B0", Offset = "0xD5E6B0", VA = "0x180D5F6B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000543 RID: 1347
			// (get) Token: 0x060034B6 RID: 13494 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000543")]
			private object Current
			{
				[Token(Token = "0x60034B6")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060034B7 RID: 13495 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034B7")]
			[Address(RVA = "0xD5F990", Offset = "0xD5E990", VA = "0x180D5F990", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000544 RID: 1348
			// (get) Token: 0x060034B8 RID: 13496 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000544")]
			private object Current
			{
				[Token(Token = "0x60034B8")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400513F RID: 20799
			[Token(Token = "0x400513F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04005140 RID: 20800
			[Token(Token = "0x4005140")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04005141 RID: 20801
			[Token(Token = "0x4005141")]
			[FieldOffset(Offset = "0x20")]
			public SimpleControlRemappingSOD <>4__this;

			// Token: 0x04005142 RID: 20802
			[Token(Token = "0x4005142")]
			[FieldOffset(Offset = "0x28")]
			public ButtonController uiButton;

			// Token: 0x04005143 RID: 20803
			[Token(Token = "0x4005143")]
			[FieldOffset(Offset = "0x30")]
			private int <counter>5__2;
		}

		// Token: 0x02000997 RID: 2455
		[Token(Token = "0x2000997")]
		private sealed class <RemapDelay>d__61 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x060034B9 RID: 13497 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034B9")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <RemapDelay>d__61(int <>1__state)
			{
			}

			// Token: 0x060034BA RID: 13498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034BA")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x060034BB RID: 13499 RVA: 0x00012600 File Offset: 0x00010800
			[Token(Token = "0x60034BB")]
			[Address(RVA = "0xD5F9E0", Offset = "0xD5E9E0", VA = "0x180D5F9E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000545 RID: 1349
			// (get) Token: 0x060034BC RID: 13500 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000545")]
			private object Current
			{
				[Token(Token = "0x60034BC")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060034BD RID: 13501 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034BD")]
			[Address(RVA = "0xD5FAC0", Offset = "0xD5EAC0", VA = "0x180D5FAC0", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x17000546 RID: 1350
			// (get) Token: 0x060034BE RID: 13502 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000546")]
			private object Current
			{
				[Token(Token = "0x60034BE")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04005144 RID: 20804
			[Token(Token = "0x4005144")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04005145 RID: 20805
			[Token(Token = "0x4005145")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04005146 RID: 20806
			[Token(Token = "0x4005146")]
			[FieldOffset(Offset = "0x20")]
			public SimpleControlRemappingSOD <>4__this;

			// Token: 0x04005147 RID: 20807
			[Token(Token = "0x4005147")]
			[FieldOffset(Offset = "0x28")]
			private float <delay>5__2;
		}
	}
}
