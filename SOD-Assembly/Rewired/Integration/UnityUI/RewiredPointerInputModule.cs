using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x02000902 RID: 2306
	[Token(Token = "0x2000902")]
	public abstract class RewiredPointerInputModule : BaseInputModule
	{
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000377")]
		private RewiredPointerInputModule.UnityInputSource defaultInputSource
		{
			[Token(Token = "0x6002E0D")]
			[Address(RVA = "0xCE5040", Offset = "0xCE4040", VA = "0x180CE5040")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06002E0E RID: 11790 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000378")]
		private IMouseInputSource defaultMouseInputSource
		{
			[Token(Token = "0x6002E0E")]
			[Address(RVA = "0xCE50F0", Offset = "0xCE40F0", VA = "0x180CE50F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06002E0F RID: 11791 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000379")]
		protected ITouchInputSource defaultTouchInputSource
		{
			[Token(Token = "0x6002E0F")]
			[Address(RVA = "0xCE50F0", Offset = "0xCE40F0", VA = "0x180CE50F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x000109F8 File Offset: 0x0000EBF8
		[Token(Token = "0x6002E10")]
		[Address(RVA = "0xCE5100", Offset = "0xCE4100", VA = "0x180CE5100")]
		protected bool IsDefaultMouse(IMouseInputSource mouse)
		{
			return default(bool);
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E11")]
		[Address(RVA = "0xCE5120", Offset = "0xCE4120", VA = "0x180CE5120")]
		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
		{
			return null;
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E12")]
		[Address(RVA = "0xCE5360", Offset = "0xCE4360", VA = "0x180CE5360")]
		public void RemoveMouseInputSource(IMouseInputSource source)
		{
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E13")]
		[Address(RVA = "0xCE5410", Offset = "0xCE4410", VA = "0x180CE5410")]
		public void AddMouseInputSource(IMouseInputSource source)
		{
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x00010A10 File Offset: 0x0000EC10
		[Token(Token = "0x6002E14")]
		[Address(RVA = "0xCE5510", Offset = "0xCE4510", VA = "0x180CE5510")]
		public int GetMouseInputSourceCount(int playerId)
		{
			return 0;
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E15")]
		[Address(RVA = "0xCE56C0", Offset = "0xCE46C0", VA = "0x180CE56C0")]
		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
		{
			return null;
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E16")]
		[Address(RVA = "0xCE5750", Offset = "0xCE4750", VA = "0x180CE5750")]
		public void RemoveTouchInputSource(ITouchInputSource source)
		{
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E17")]
		[Address(RVA = "0xCE5820", Offset = "0xCE4820", VA = "0x180CE5820")]
		public void AddTouchInputSource(ITouchInputSource source)
		{
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x00010A28 File Offset: 0x0000EC28
		[Token(Token = "0x6002E18")]
		[Address(RVA = "0xCE5930", Offset = "0xCE4930", VA = "0x180CE5930")]
		public int GetTouchInputSourceCount(int playerId)
		{
			return 0;
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E19")]
		[Address(RVA = "0xCE5960", Offset = "0xCE4960", VA = "0x180CE5960")]
		protected void ClearMouseInputSources()
		{
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x00010A40 File Offset: 0x0000EC40
		[Token(Token = "0x1700037A")]
		protected virtual bool isMouseSupported
		{
			[Token(Token = "0x6002E1A")]
			[Address(RVA = "0xCE59D0", Offset = "0xCE49D0", VA = "0x180CE59D0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002E1B RID: 11803
		[Token(Token = "0x6002E1B")]
		protected abstract bool IsDefaultPlayer(int playerId);

		// Token: 0x06002E1C RID: 11804 RVA: 0x00010A58 File Offset: 0x0000EC58
		[Token(Token = "0x6002E1C")]
		[Address(RVA = "0xCE5B10", Offset = "0xCE4B10", VA = "0x180CE5B10")]
		protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
		{
			return default(bool);
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E1D")]
		[Address(RVA = "0xCE6340", Offset = "0xCE5340", VA = "0x180CE6340")]
		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
		{
			return null;
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E1E")]
		[Address(RVA = "0xCE64D0", Offset = "0xCE54D0", VA = "0x180CE64D0")]
		protected void RemovePointerData(PlayerPointerEventData data)
		{
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E1F")]
		[Address(RVA = "0xCE6590", Offset = "0xCE5590", VA = "0x180CE6590")]
		protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
		{
			return null;
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E20")]
		[Address(RVA = "0xCE6890", Offset = "0xCE5890", VA = "0x180CE6890", Slot = "29")]
		protected virtual RewiredPointerInputModule.MouseState GetMousePointerEventData(int playerId, int mouseIndex)
		{
			return null;
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E21")]
		[Address(RVA = "0xCE7580", Offset = "0xCE6580", VA = "0x180CE7580")]
		protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
		{
			return null;
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x00010A70 File Offset: 0x0000EC70
		[Token(Token = "0x6002E22")]
		[Address(RVA = "0xCE77D0", Offset = "0xCE67D0", VA = "0x180CE77D0")]
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return default(bool);
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E23")]
		[Address(RVA = "0xCE7820", Offset = "0xCE6820", VA = "0x180CE7820", Slot = "30")]
		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
		{
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E24")]
		[Address(RVA = "0xCE7950", Offset = "0xCE6950", VA = "0x180CE7950", Slot = "31")]
		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
		{
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x00010A88 File Offset: 0x0000EC88
		[Token(Token = "0x6002E25")]
		[Address(RVA = "0xCE7DD0", Offset = "0xCE6DD0", VA = "0x180CE7DD0", Slot = "20")]
		public override bool IsPointerOverGameObject(int pointerTypeId)
		{
			return default(bool);
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E26")]
		[Address(RVA = "0xCE80E0", Offset = "0xCE70E0", VA = "0x180CE80E0")]
		protected void ClearSelection()
		{
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E27")]
		[Address(RVA = "0xCE8490", Offset = "0xCE7490", VA = "0x180CE8490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E28")]
		[Address(RVA = "0xCE8AE0", Offset = "0xCE7AE0", VA = "0x180CE8AE0")]
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E29")]
		[Address(RVA = "0xCE8CF0", Offset = "0xCE7CF0", VA = "0x180CE8CF0")]
		protected void CopyFromTo(PointerEventData from, PointerEventData to)
		{
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x00010AA0 File Offset: 0x0000ECA0
		[Token(Token = "0x6002E2A")]
		[Address(RVA = "0xCE8E60", Offset = "0xCE7E60", VA = "0x180CE8E60")]
		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
		{
			return PointerEventData.FramePressState.Pressed;
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E2B")]
		[Address(RVA = "0xCE8F30", Offset = "0xCE7F30", VA = "0x180CE8F30")]
		protected RewiredPointerInputModule()
		{
		}

		// Token: 0x04004D79 RID: 19833
		[Token(Token = "0x4004D79")]
		public const int kMouseLeftId = -1;

		// Token: 0x04004D7A RID: 19834
		[Token(Token = "0x4004D7A")]
		public const int kMouseRightId = -2;

		// Token: 0x04004D7B RID: 19835
		[Token(Token = "0x4004D7B")]
		public const int kMouseMiddleId = -3;

		// Token: 0x04004D7C RID: 19836
		[Token(Token = "0x4004D7C")]
		public const int kFakeTouchesId = -4;

		// Token: 0x04004D7D RID: 19837
		[Token(Token = "0x4004D7D")]
		private const int customButtonsStartingId = -2147483520;

		// Token: 0x04004D7E RID: 19838
		[Token(Token = "0x4004D7E")]
		private const int customButtonsMaxCount = 128;

		// Token: 0x04004D7F RID: 19839
		[Token(Token = "0x4004D7F")]
		private const int customButtonsLastId = -2147483392;

		// Token: 0x04004D80 RID: 19840
		[Token(Token = "0x4004D80")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<IMouseInputSource> m_MouseInputSourcesList;

		// Token: 0x04004D81 RID: 19841
		[Token(Token = "0x4004D81")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData;

		// Token: 0x04004D82 RID: 19842
		[Token(Token = "0x4004D82")]
		[FieldOffset(Offset = "0x60")]
		private ITouchInputSource m_UserDefaultTouchInputSource;

		// Token: 0x04004D83 RID: 19843
		[Token(Token = "0x4004D83")]
		[FieldOffset(Offset = "0x68")]
		private RewiredPointerInputModule.UnityInputSource __m_DefaultInputSource;

		// Token: 0x04004D84 RID: 19844
		[Token(Token = "0x4004D84")]
		[FieldOffset(Offset = "0x70")]
		private readonly RewiredPointerInputModule.MouseState m_MouseState;

		// Token: 0x02000903 RID: 2307
		[Token(Token = "0x2000903")]
		protected class MouseState
		{
			// Token: 0x06002E2C RID: 11820 RVA: 0x00010AB8 File Offset: 0x0000ECB8
			[Token(Token = "0x6002E2C")]
			[Address(RVA = "0xCE9400", Offset = "0xCE8400", VA = "0x180CE9400")]
			public bool AnyPressesThisFrame()
			{
				return default(bool);
			}

			// Token: 0x06002E2D RID: 11821 RVA: 0x00010AD0 File Offset: 0x0000ECD0
			[Token(Token = "0x6002E2D")]
			[Address(RVA = "0xCE94C0", Offset = "0xCE84C0", VA = "0x180CE94C0")]
			public bool AnyReleasesThisFrame()
			{
				return default(bool);
			}

			// Token: 0x06002E2E RID: 11822 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6002E2E")]
			[Address(RVA = "0xCE9580", Offset = "0xCE8580", VA = "0x180CE9580")]
			public RewiredPointerInputModule.ButtonState GetButtonState(int button)
			{
				return null;
			}

			// Token: 0x06002E2F RID: 11823 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E2F")]
			[Address(RVA = "0xCE9720", Offset = "0xCE8720", VA = "0x180CE9720")]
			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
			{
			}

			// Token: 0x06002E30 RID: 11824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E30")]
			[Address(RVA = "0xCE97C0", Offset = "0xCE87C0", VA = "0x180CE97C0")]
			public MouseState()
			{
			}

			// Token: 0x04004D85 RID: 19845
			[Token(Token = "0x4004D85")]
			[FieldOffset(Offset = "0x10")]
			private List<RewiredPointerInputModule.ButtonState> m_TrackedButtons;
		}

		// Token: 0x02000904 RID: 2308
		[Token(Token = "0x2000904")]
		public class MouseButtonEventData
		{
			// Token: 0x06002E31 RID: 11825 RVA: 0x00010AE8 File Offset: 0x0000ECE8
			[Token(Token = "0x6002E31")]
			[Address(RVA = "0xCE9890", Offset = "0xCE8890", VA = "0x180CE9890")]
			public bool PressedThisFrame()
			{
				return default(bool);
			}

			// Token: 0x06002E32 RID: 11826 RVA: 0x00010B00 File Offset: 0x0000ED00
			[Token(Token = "0x6002E32")]
			[Address(RVA = "0xCE98B0", Offset = "0xCE88B0", VA = "0x180CE98B0")]
			public bool ReleasedThisFrame()
			{
				return default(bool);
			}

			// Token: 0x06002E33 RID: 11827 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E33")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public MouseButtonEventData()
			{
			}

			// Token: 0x04004D86 RID: 19846
			[Token(Token = "0x4004D86")]
			[FieldOffset(Offset = "0x10")]
			public PointerEventData.FramePressState buttonState;

			// Token: 0x04004D87 RID: 19847
			[Token(Token = "0x4004D87")]
			[FieldOffset(Offset = "0x18")]
			public PlayerPointerEventData buttonData;
		}

		// Token: 0x02000905 RID: 2309
		[Token(Token = "0x2000905")]
		protected class ButtonState
		{
			// Token: 0x1700037B RID: 891
			// (get) Token: 0x06002E34 RID: 11828 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06002E35 RID: 11829 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700037B")]
			public RewiredPointerInputModule.MouseButtonEventData eventData
			{
				[Token(Token = "0x6002E34")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002E35")]
				[Address(RVA = "0x3ED9D0", Offset = "0x3EC9D0", VA = "0x1803ED9D0")]
				set
				{
				}
			}

			// Token: 0x1700037C RID: 892
			// (get) Token: 0x06002E36 RID: 11830 RVA: 0x00010B18 File Offset: 0x0000ED18
			// (set) Token: 0x06002E37 RID: 11831 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700037C")]
			public int button
			{
				[Token(Token = "0x6002E36")]
				[Address(RVA = "0x3F9850", Offset = "0x3F8850", VA = "0x1803F9850")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6002E37")]
				[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
				set
				{
				}
			}

			// Token: 0x06002E38 RID: 11832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E38")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public ButtonState()
			{
			}

			// Token: 0x04004D88 RID: 19848
			[Token(Token = "0x4004D88")]
			[FieldOffset(Offset = "0x10")]
			private int m_Button;

			// Token: 0x04004D89 RID: 19849
			[Token(Token = "0x4004D89")]
			[FieldOffset(Offset = "0x18")]
			private RewiredPointerInputModule.MouseButtonEventData m_EventData;
		}

		// Token: 0x02000906 RID: 2310
		[Token(Token = "0x2000906")]
		private sealed class UnityInputSource : IEnumerator<object>, IDisposable
		{
			// Token: 0x1700037D RID: 893
			// (get) Token: 0x06002E39 RID: 11833 RVA: 0x00010B30 File Offset: 0x0000ED30
			[Token(Token = "0x1700037D")]
			private int playerId
			{
				[Token(Token = "0x6002E39")]
				[Address(RVA = "0xCE98D0", Offset = "0xCE88D0", VA = "0x180CE98D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700037E RID: 894
			// (get) Token: 0x06002E3A RID: 11834 RVA: 0x00010B48 File Offset: 0x0000ED48
			[Token(Token = "0x1700037E")]
			private int playerId
			{
				[Token(Token = "0x6002E3A")]
				[Address(RVA = "0xCE98D0", Offset = "0xCE88D0", VA = "0x180CE98D0", Slot = "14")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700037F RID: 895
			// (get) Token: 0x06002E3B RID: 11835 RVA: 0x00010B60 File Offset: 0x0000ED60
			[Token(Token = "0x1700037F")]
			private bool enabled
			{
				[Token(Token = "0x6002E3B")]
				[Address(RVA = "0xCE98F0", Offset = "0xCE88F0", VA = "0x180CE98F0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000380 RID: 896
			// (get) Token: 0x06002E3C RID: 11836 RVA: 0x00010B78 File Offset: 0x0000ED78
			[Token(Token = "0x17000380")]
			private bool locked
			{
				[Token(Token = "0x6002E3C")]
				[Address(RVA = "0xCE9910", Offset = "0xCE8910", VA = "0x180CE9910", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000381 RID: 897
			// (get) Token: 0x06002E3D RID: 11837 RVA: 0x00010B90 File Offset: 0x0000ED90
			[Token(Token = "0x17000381")]
			private int buttonCount
			{
				[Token(Token = "0x6002E3D")]
				[Address(RVA = "0xCE9970", Offset = "0xCE8970", VA = "0x180CE9970", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06002E3E RID: 11838 RVA: 0x00010BA8 File Offset: 0x0000EDA8
			[Token(Token = "0x6002E3E")]
			[Address(RVA = "0xCE9990", Offset = "0xCE8990", VA = "0x180CE9990", Slot = "8")]
			private bool GetButtonDown(int button)
			{
				return default(bool);
			}

			// Token: 0x06002E3F RID: 11839 RVA: 0x00010BC0 File Offset: 0x0000EDC0
			[Token(Token = "0x6002E3F")]
			[Address(RVA = "0xCE99F0", Offset = "0xCE89F0", VA = "0x180CE99F0", Slot = "9")]
			private bool GetButtonUp(int button)
			{
				return default(bool);
			}

			// Token: 0x06002E40 RID: 11840 RVA: 0x00010BD8 File Offset: 0x0000EDD8
			[Token(Token = "0x6002E40")]
			[Address(RVA = "0xCE9A50", Offset = "0xCE8A50", VA = "0x180CE9A50", Slot = "10")]
			private bool GetButton(int button)
			{
				return default(bool);
			}

			// Token: 0x17000382 RID: 898
			// (get) Token: 0x06002E41 RID: 11841 RVA: 0x00010BF0 File Offset: 0x0000EDF0
			[Token(Token = "0x17000382")]
			private Vector2 screenPosition
			{
				[Token(Token = "0x6002E41")]
				[Address(RVA = "0xCE9AB0", Offset = "0xCE8AB0", VA = "0x180CE9AB0", Slot = "11")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x17000383 RID: 899
			// (get) Token: 0x06002E42 RID: 11842 RVA: 0x00010C08 File Offset: 0x0000EE08
			[Token(Token = "0x17000383")]
			private Vector2 screenPositionDelta
			{
				[Token(Token = "0x6002E42")]
				[Address(RVA = "0xCE9B30", Offset = "0xCE8B30", VA = "0x180CE9B30", Slot = "12")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x17000384 RID: 900
			// (get) Token: 0x06002E43 RID: 11843 RVA: 0x00010C20 File Offset: 0x0000EE20
			[Token(Token = "0x17000384")]
			private Vector2 wheelDelta
			{
				[Token(Token = "0x6002E43")]
				[Address(RVA = "0xCE9B70", Offset = "0xCE8B70", VA = "0x180CE9B70", Slot = "13")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x17000385 RID: 901
			// (get) Token: 0x06002E44 RID: 11844 RVA: 0x00010C38 File Offset: 0x0000EE38
			[Token(Token = "0x17000385")]
			private bool touchSupported
			{
				[Token(Token = "0x6002E44")]
				[Address(RVA = "0xCE9BD0", Offset = "0xCE8BD0", VA = "0x180CE9BD0", Slot = "15")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000386 RID: 902
			// (get) Token: 0x06002E45 RID: 11845 RVA: 0x00010C50 File Offset: 0x0000EE50
			[Token(Token = "0x17000386")]
			private int touchCount
			{
				[Token(Token = "0x6002E45")]
				[Address(RVA = "0xCE9C20", Offset = "0xCE8C20", VA = "0x180CE9C20", Slot = "16")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06002E46 RID: 11846 RVA: 0x00010C68 File Offset: 0x0000EE68
			[Token(Token = "0x6002E46")]
			[Address(RVA = "0xCE9C70", Offset = "0xCE8C70", VA = "0x180CE9C70", Slot = "17")]
			private Touch GetTouch(int index)
			{
				return default(Touch);
			}

			// Token: 0x06002E47 RID: 11847 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E47")]
			[Address(RVA = "0xCE9D30", Offset = "0xCE8D30", VA = "0x180CE9D30")]
			private void TryUpdate()
			{
			}

			// Token: 0x06002E48 RID: 11848 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E48")]
			[Address(RVA = "0x791A40", Offset = "0x790A40", VA = "0x180791A40")]
			public UnityInputSource()
			{
			}

			// Token: 0x04004D8A RID: 19850
			[Token(Token = "0x4004D8A")]
			[FieldOffset(Offset = "0x10")]
			private Vector2 m_MousePosition;

			// Token: 0x04004D8B RID: 19851
			[Token(Token = "0x4004D8B")]
			[FieldOffset(Offset = "0x18")]
			private Vector2 m_MousePositionPrev;

			// Token: 0x04004D8C RID: 19852
			[Token(Token = "0x4004D8C")]
			[FieldOffset(Offset = "0x20")]
			private int m_LastUpdatedFrame;
		}
	}
}
