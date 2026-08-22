using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200093A RID: 2362
	[Token(Token = "0x200093A")]
	public class InputBehaviorWindow : Window
	{
		// Token: 0x060031BD RID: 12733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031BD")]
		[Address(RVA = "0xD267C0", Offset = "0xD257C0", VA = "0x180D267C0", Slot = "5")]
		public override void Initialize(int id, Func<int, bool> isFocusedCallback)
		{
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031BE")]
		[Address(RVA = "0xD27170", Offset = "0xD26170", VA = "0x180D27170")]
		public void SetData(int playerId, ControlMapper.InputBehaviorSettings[] data)
		{
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031BF")]
		[Address(RVA = "0xD27800", Offset = "0xD26800", VA = "0x180D27800")]
		public void SetButtonCallback(InputBehaviorWindow.ButtonIdentifier buttonIdentifier, Action<int> callback)
		{
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C0")]
		[Address(RVA = "0xD27920", Offset = "0xD26920", VA = "0x180D27920", Slot = "9")]
		public override void Cancel()
		{
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C1")]
		[Address(RVA = "0xD27B30", Offset = "0xD26B30", VA = "0x180D27B30")]
		public void OnDone()
		{
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C2")]
		[Address(RVA = "0xCF36C0", Offset = "0xCF26C0", VA = "0x180CF36C0")]
		public void OnCancel()
		{
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C3")]
		[Address(RVA = "0xD27BC0", Offset = "0xD26BC0", VA = "0x180D27BC0")]
		public void OnRestoreDefault()
		{
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C4")]
		[Address(RVA = "0xD27D40", Offset = "0xD26D40", VA = "0x180D27D40")]
		private void JoystickAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value)
		{
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C5")]
		[Address(RVA = "0xD27DA0", Offset = "0xD26DA0", VA = "0x180D27DA0")]
		private void MouseXYAxisSensitivityValueChanged(int inputBehaviorId, int controlId, float value)
		{
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C6")]
		[Address(RVA = "0xD27E00", Offset = "0xD26E00", VA = "0x180D27E00")]
		private void JoystickAxisSensitivityCanceled(int inputBehaviorId, int controlId)
		{
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C7")]
		[Address(RVA = "0xD27E40", Offset = "0xD26E40", VA = "0x180D27E40")]
		private void MouseXYAxisSensitivityCanceled(int inputBehaviorId, int controlId)
		{
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C8")]
		[Address(RVA = "0xD27E80", Offset = "0xD26E80", VA = "0x180D27E80", Slot = "6")]
		public override void TakeInputFocus()
		{
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60031C9")]
		[Address(RVA = "0xD27E90", Offset = "0xD26E90", VA = "0x180D27E90")]
		private UIControlSet CreateControlSet()
		{
			return null;
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60031CA")]
		[Address(RVA = "0xD27FE0", Offset = "0xD26FE0", VA = "0x180D27FE0")]
		private UISliderControl CreateSlider(UIControlSet set, int inputBehaviorId, string defaultTitle, string overrideTitle, Sprite icon, float minValue, float maxValue, Action<int, int, float> valueChangedCallback, Action<int, int> cancelCallback)
		{
			return null;
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60031CB")]
		[Address(RVA = "0xD284E0", Offset = "0xD274E0", VA = "0x180D284E0")]
		private InputBehavior GetInputBehavior(int id)
		{
			return null;
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60031CC")]
		[Address(RVA = "0xD28560", Offset = "0xD27560", VA = "0x180D28560")]
		private InputBehaviorWindow.InputBehaviorInfo GetInputBehaviorInfo(int inputBehaviorId)
		{
			return null;
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CD")]
		[Address(RVA = "0xD28640", Offset = "0xD27640", VA = "0x180D28640")]
		public InputBehaviorWindow()
		{
		}

		// Token: 0x04004F27 RID: 20263
		[Token(Token = "0x4004F27")]
		private const float minSensitivity = 0.1f;

		// Token: 0x04004F28 RID: 20264
		[Token(Token = "0x4004F28")]
		[FieldOffset(Offset = "0x80")]
		private RectTransform spawnTransform;

		// Token: 0x04004F29 RID: 20265
		[Token(Token = "0x4004F29")]
		[FieldOffset(Offset = "0x88")]
		private Button doneButton;

		// Token: 0x04004F2A RID: 20266
		[Token(Token = "0x4004F2A")]
		[FieldOffset(Offset = "0x90")]
		private Button cancelButton;

		// Token: 0x04004F2B RID: 20267
		[Token(Token = "0x4004F2B")]
		[FieldOffset(Offset = "0x98")]
		private Button defaultButton;

		// Token: 0x04004F2C RID: 20268
		[Token(Token = "0x4004F2C")]
		[FieldOffset(Offset = "0xA0")]
		private TMP_Text doneButtonLabel;

		// Token: 0x04004F2D RID: 20269
		[Token(Token = "0x4004F2D")]
		[FieldOffset(Offset = "0xA8")]
		private TMP_Text cancelButtonLabel;

		// Token: 0x04004F2E RID: 20270
		[Token(Token = "0x4004F2E")]
		[FieldOffset(Offset = "0xB0")]
		private TMP_Text defaultButtonLabel;

		// Token: 0x04004F2F RID: 20271
		[Token(Token = "0x4004F2F")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject uiControlSetPrefab;

		// Token: 0x04004F30 RID: 20272
		[Token(Token = "0x4004F30")]
		[FieldOffset(Offset = "0xC0")]
		private GameObject uiSliderControlPrefab;

		// Token: 0x04004F31 RID: 20273
		[Token(Token = "0x4004F31")]
		[FieldOffset(Offset = "0xC8")]
		private List<InputBehaviorWindow.InputBehaviorInfo> inputBehaviorInfo;

		// Token: 0x04004F32 RID: 20274
		[Token(Token = "0x4004F32")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<int, Action<int>> buttonCallbacks;

		// Token: 0x04004F33 RID: 20275
		[Token(Token = "0x4004F33")]
		[FieldOffset(Offset = "0xD8")]
		private int playerId;

		// Token: 0x0200093B RID: 2363
		[Token(Token = "0x200093B")]
		private class InputBehaviorInfo
		{
			// Token: 0x1700046C RID: 1132
			// (get) Token: 0x060031CE RID: 12750 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700046C")]
			public InputBehavior inputBehavior
			{
				[Token(Token = "0x60031CE")]
				[Address(RVA = "0x3ED8F0", Offset = "0x3EC8F0", VA = "0x1803ED8F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700046D RID: 1133
			// (get) Token: 0x060031CF RID: 12751 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700046D")]
			public UIControlSet controlSet
			{
				[Token(Token = "0x60031CF")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x060031D0 RID: 12752 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031D0")]
			[Address(RVA = "0xD28690", Offset = "0xD27690", VA = "0x180D28690")]
			public InputBehaviorInfo(InputBehavior inputBehavior, UIControlSet controlSet, Dictionary<int, InputBehaviorWindow.PropertyType> idToProperty)
			{
			}

			// Token: 0x060031D1 RID: 12753 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031D1")]
			[Address(RVA = "0xD28890", Offset = "0xD27890", VA = "0x180D28890")]
			public void RestorePreviousData()
			{
			}

			// Token: 0x060031D2 RID: 12754 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031D2")]
			[Address(RVA = "0xD288C0", Offset = "0xD278C0", VA = "0x180D288C0")]
			public void RestoreDefaultData()
			{
			}

			// Token: 0x060031D3 RID: 12755 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031D3")]
			[Address(RVA = "0xD288F0", Offset = "0xD278F0", VA = "0x180D288F0")]
			public void RestoreData(InputBehaviorWindow.PropertyType propertyType, int controlId)
			{
			}

			// Token: 0x060031D4 RID: 12756 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031D4")]
			[Address(RVA = "0xD28AF0", Offset = "0xD27AF0", VA = "0x180D28AF0")]
			public void RefreshControls()
			{
			}

			// Token: 0x04004F34 RID: 20276
			[Token(Token = "0x4004F34")]
			[FieldOffset(Offset = "0x10")]
			private InputBehavior _inputBehavior;

			// Token: 0x04004F35 RID: 20277
			[Token(Token = "0x4004F35")]
			[FieldOffset(Offset = "0x18")]
			private UIControlSet _controlSet;

			// Token: 0x04004F36 RID: 20278
			[Token(Token = "0x4004F36")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<int, InputBehaviorWindow.PropertyType> idToProperty;

			// Token: 0x04004F37 RID: 20279
			[Token(Token = "0x4004F37")]
			[FieldOffset(Offset = "0x28")]
			private InputBehavior copyOfOriginal;
		}

		// Token: 0x0200093C RID: 2364
		[Token(Token = "0x200093C")]
		public enum ButtonIdentifier
		{
			// Token: 0x04004F39 RID: 20281
			[Token(Token = "0x4004F39")]
			Done,
			// Token: 0x04004F3A RID: 20282
			[Token(Token = "0x4004F3A")]
			Cancel,
			// Token: 0x04004F3B RID: 20283
			[Token(Token = "0x4004F3B")]
			Default
		}

		// Token: 0x0200093D RID: 2365
		[Token(Token = "0x200093D")]
		private enum PropertyType
		{
			// Token: 0x04004F3D RID: 20285
			[Token(Token = "0x4004F3D")]
			JoystickAxisSensitivity,
			// Token: 0x04004F3E RID: 20286
			[Token(Token = "0x4004F3E")]
			MouseXYAxisSensitivity
		}

		// Token: 0x0200093E RID: 2366
		[Token(Token = "0x200093E")]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x060031D5 RID: 12757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031D5")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x060031D6 RID: 12758 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031D6")]
			[Address(RVA = "0xD28ED0", Offset = "0xD27ED0", VA = "0x180D28ED0")]
			internal void <CreateSlider>b__0(int cId, float value)
			{
			}

			// Token: 0x060031D7 RID: 12759 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031D7")]
			[Address(RVA = "0xD28F10", Offset = "0xD27F10", VA = "0x180D28F10")]
			internal void <CreateSlider>b__1(int cId)
			{
			}

			// Token: 0x04004F3F RID: 20287
			[Token(Token = "0x4004F3F")]
			[FieldOffset(Offset = "0x10")]
			public Action<int, int, float> valueChangedCallback;

			// Token: 0x04004F40 RID: 20288
			[Token(Token = "0x4004F40")]
			[FieldOffset(Offset = "0x18")]
			public int inputBehaviorId;

			// Token: 0x04004F41 RID: 20289
			[Token(Token = "0x4004F41")]
			[FieldOffset(Offset = "0x20")]
			public Action<int, int> cancelCallback;
		}
	}
}
