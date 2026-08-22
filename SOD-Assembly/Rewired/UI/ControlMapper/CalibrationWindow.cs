using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Integration.UnityUI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper
{
	// Token: 0x0200090B RID: 2315
	[Token(Token = "0x200090B")]
	public class CalibrationWindow : Window
	{
		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06002EA8 RID: 11944 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		[Token(Token = "0x170003A2")]
		private bool axisSelected
		{
			[Token(Token = "0x6002EA8")]
			[Address(RVA = "0xCF18B0", Offset = "0xCF08B0", VA = "0x180CF18B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06002EA9 RID: 11945 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003A3")]
		private AxisCalibration axisCalibration
		{
			[Token(Token = "0x6002EA9")]
			[Address(RVA = "0xCF1910", Offset = "0xCF0910", VA = "0x180CF1910")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAA")]
		[Address(RVA = "0xCF19A0", Offset = "0xCF09A0", VA = "0x180CF19A0", Slot = "5")]
		public override void Initialize(int id, Func<int, bool> isFocusedCallback)
		{
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAB")]
		[Address(RVA = "0xCF2780", Offset = "0xCF1780", VA = "0x180CF2780")]
		public void SetJoystick(int playerId, Joystick joystick)
		{
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAC")]
		[Address(RVA = "0xCF33D0", Offset = "0xCF23D0", VA = "0x180CF33D0")]
		public void SetButtonCallback(CalibrationWindow.ButtonIdentifier buttonIdentifier, Action<int> callback)
		{
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAD")]
		[Address(RVA = "0xCF34F0", Offset = "0xCF24F0", VA = "0x180CF34F0", Slot = "9")]
		public override void Cancel()
		{
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAE")]
		[Address(RVA = "0xCF35C0", Offset = "0xCF25C0", VA = "0x180CF35C0", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAF")]
		[Address(RVA = "0xCF3630", Offset = "0xCF2630", VA = "0x180CF3630")]
		public void OnDone()
		{
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB0")]
		[Address(RVA = "0xCF36C0", Offset = "0xCF26C0", VA = "0x180CF36C0")]
		public void OnCancel()
		{
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB1")]
		[Address(RVA = "0xCF36E0", Offset = "0xCF26E0", VA = "0x180CF36E0")]
		public void OnRestoreDefault()
		{
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB2")]
		[Address(RVA = "0xCF3830", Offset = "0xCF2830", VA = "0x180CF3830")]
		public void OnCalibrate()
		{
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB3")]
		[Address(RVA = "0xCF38C0", Offset = "0xCF28C0", VA = "0x180CF38C0")]
		public void OnInvert(bool state)
		{
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB4")]
		[Address(RVA = "0xCF3940", Offset = "0xCF2940", VA = "0x180CF3940")]
		public void OnZeroValueChange(float value)
		{
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB5")]
		[Address(RVA = "0xCF39D0", Offset = "0xCF29D0", VA = "0x180CF39D0")]
		public void OnZeroCancel()
		{
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB6")]
		[Address(RVA = "0xCF3A60", Offset = "0xCF2A60", VA = "0x180CF3A60")]
		public void OnDeadzoneValueChange(float value)
		{
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB7")]
		[Address(RVA = "0xCF3B60", Offset = "0xCF2B60", VA = "0x180CF3B60")]
		public void OnDeadzoneCancel()
		{
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB8")]
		[Address(RVA = "0xCF3C00", Offset = "0xCF2C00", VA = "0x180CF3C00")]
		public void OnSensitivityValueChange(float value)
		{
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB9")]
		[Address(RVA = "0xCF3D40", Offset = "0xCF2D40", VA = "0x180CF3D40")]
		public void OnSensitivityCancel(float value)
		{
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public void OnAxisScrollRectScroll(Vector2 pos)
		{
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBB")]
		[Address(RVA = "0xCF3DD0", Offset = "0xCF2DD0", VA = "0x180CF3DD0")]
		private void OnAxisSelected(int axisIndex, Button button)
		{
		}

		// Token: 0x06002EBC RID: 11964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBC")]
		[Address(RVA = "0xCF3E20", Offset = "0xCF2E20", VA = "0x180CF3E20")]
		private void UpdateDisplay()
		{
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBD")]
		[Address(RVA = "0xCF3E30", Offset = "0xCF2E30", VA = "0x180CF3E30")]
		private void Redraw()
		{
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBE")]
		[Address(RVA = "0xCF3E50", Offset = "0xCF2E50", VA = "0x180CF3E50")]
		private void RefreshControls()
		{
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBF")]
		[Address(RVA = "0xCF4080", Offset = "0xCF3080", VA = "0x180CF4080")]
		private void RedrawDeadzone()
		{
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC0")]
		[Address(RVA = "0xCF42F0", Offset = "0xCF32F0", VA = "0x180CF42F0")]
		private void RedrawCalibratedZero()
		{
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC1")]
		[Address(RVA = "0xCF44E0", Offset = "0xCF34E0", VA = "0x180CF44E0")]
		private void RedrawValueMarkers()
		{
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC2")]
		[Address(RVA = "0xCF4940", Offset = "0xCF3940", VA = "0x180CF4940")]
		private void SelectAxis(int index)
		{
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC3")]
		[Address(RVA = "0xCF4E30", Offset = "0xCF3E30", VA = "0x180CF4E30", Slot = "6")]
		public override void TakeInputFocus()
		{
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC4")]
		[Address(RVA = "0xCF4E80", Offset = "0xCF3E80", VA = "0x180CF4E80")]
		private void SetMinSensitivity()
		{
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00010FF8 File Offset: 0x0000F1F8
		[Token(Token = "0x6002EC5")]
		[Address(RVA = "0xCF5070", Offset = "0xCF4070", VA = "0x180CF5070")]
		private bool IsMenuAxis(int actionId, int axisIndex)
		{
			return default(bool);
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC6")]
		[Address(RVA = "0xCF53B0", Offset = "0xCF43B0", VA = "0x180CF53B0")]
		private void GetAxisButtonDeadZone(int playerId, int actionId, ref float value)
		{
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x00011010 File Offset: 0x0000F210
		[Token(Token = "0x6002EC7")]
		[Address(RVA = "0xCF5480", Offset = "0xCF4480", VA = "0x180CF5480")]
		private float GetSliderSensitivity(AxisCalibration axisCalibration)
		{
			return 0f;
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC8")]
		[Address(RVA = "0xCF54D0", Offset = "0xCF44D0", VA = "0x180CF54D0")]
		public void SetSensitivity(AxisCalibration axisCalibration, float sliderValue)
		{
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x00011028 File Offset: 0x0000F228
		[Token(Token = "0x6002EC9")]
		[Address(RVA = "0xCF5590", Offset = "0xCF4590", VA = "0x180CF5590")]
		private static float ProcessPowerValue(float value, float minValue, float maxValue)
		{
			return 0f;
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECA")]
		[Address(RVA = "0xCF5610", Offset = "0xCF4610", VA = "0x180CF5610")]
		public CalibrationWindow()
		{
		}

		// Token: 0x04004DB5 RID: 19893
		[Token(Token = "0x4004DB5")]
		private const float minSensitivityOtherAxes = 0.1f;

		// Token: 0x04004DB6 RID: 19894
		[Token(Token = "0x4004DB6")]
		private const float maxDeadzone = 0.8f;

		// Token: 0x04004DB7 RID: 19895
		[Token(Token = "0x4004DB7")]
		[FieldOffset(Offset = "0x80")]
		private RectTransform rightContentContainer;

		// Token: 0x04004DB8 RID: 19896
		[Token(Token = "0x4004DB8")]
		[FieldOffset(Offset = "0x88")]
		private RectTransform valueDisplayGroup;

		// Token: 0x04004DB9 RID: 19897
		[Token(Token = "0x4004DB9")]
		[FieldOffset(Offset = "0x90")]
		private RectTransform calibratedValueMarker;

		// Token: 0x04004DBA RID: 19898
		[Token(Token = "0x4004DBA")]
		[FieldOffset(Offset = "0x98")]
		private RectTransform rawValueMarker;

		// Token: 0x04004DBB RID: 19899
		[Token(Token = "0x4004DBB")]
		[FieldOffset(Offset = "0xA0")]
		private RectTransform calibratedZeroMarker;

		// Token: 0x04004DBC RID: 19900
		[Token(Token = "0x4004DBC")]
		[FieldOffset(Offset = "0xA8")]
		private RectTransform deadzoneArea;

		// Token: 0x04004DBD RID: 19901
		[Token(Token = "0x4004DBD")]
		[FieldOffset(Offset = "0xB0")]
		private Slider deadzoneSlider;

		// Token: 0x04004DBE RID: 19902
		[Token(Token = "0x4004DBE")]
		[FieldOffset(Offset = "0xB8")]
		private Slider zeroSlider;

		// Token: 0x04004DBF RID: 19903
		[Token(Token = "0x4004DBF")]
		[FieldOffset(Offset = "0xC0")]
		private Slider sensitivitySlider;

		// Token: 0x04004DC0 RID: 19904
		[Token(Token = "0x4004DC0")]
		[FieldOffset(Offset = "0xC8")]
		private Toggle invertToggle;

		// Token: 0x04004DC1 RID: 19905
		[Token(Token = "0x4004DC1")]
		[FieldOffset(Offset = "0xD0")]
		private RectTransform axisScrollAreaContent;

		// Token: 0x04004DC2 RID: 19906
		[Token(Token = "0x4004DC2")]
		[FieldOffset(Offset = "0xD8")]
		private Button doneButton;

		// Token: 0x04004DC3 RID: 19907
		[Token(Token = "0x4004DC3")]
		[FieldOffset(Offset = "0xE0")]
		private Button calibrateButton;

		// Token: 0x04004DC4 RID: 19908
		[Token(Token = "0x4004DC4")]
		[FieldOffset(Offset = "0xE8")]
		private TMP_Text doneButtonLabel;

		// Token: 0x04004DC5 RID: 19909
		[Token(Token = "0x4004DC5")]
		[FieldOffset(Offset = "0xF0")]
		private TMP_Text cancelButtonLabel;

		// Token: 0x04004DC6 RID: 19910
		[Token(Token = "0x4004DC6")]
		[FieldOffset(Offset = "0xF8")]
		private TMP_Text defaultButtonLabel;

		// Token: 0x04004DC7 RID: 19911
		[Token(Token = "0x4004DC7")]
		[FieldOffset(Offset = "0x100")]
		private TMP_Text deadzoneSliderLabel;

		// Token: 0x04004DC8 RID: 19912
		[Token(Token = "0x4004DC8")]
		[FieldOffset(Offset = "0x108")]
		private TMP_Text zeroSliderLabel;

		// Token: 0x04004DC9 RID: 19913
		[Token(Token = "0x4004DC9")]
		[FieldOffset(Offset = "0x110")]
		private TMP_Text sensitivitySliderLabel;

		// Token: 0x04004DCA RID: 19914
		[Token(Token = "0x4004DCA")]
		[FieldOffset(Offset = "0x118")]
		private TMP_Text invertToggleLabel;

		// Token: 0x04004DCB RID: 19915
		[Token(Token = "0x4004DCB")]
		[FieldOffset(Offset = "0x120")]
		private TMP_Text calibrateButtonLabel;

		// Token: 0x04004DCC RID: 19916
		[Token(Token = "0x4004DCC")]
		[FieldOffset(Offset = "0x128")]
		private GameObject axisButtonPrefab;

		// Token: 0x04004DCD RID: 19917
		[Token(Token = "0x4004DCD")]
		[FieldOffset(Offset = "0x130")]
		private Joystick joystick;

		// Token: 0x04004DCE RID: 19918
		[Token(Token = "0x4004DCE")]
		[FieldOffset(Offset = "0x138")]
		private string origCalibrationData;

		// Token: 0x04004DCF RID: 19919
		[Token(Token = "0x4004DCF")]
		[FieldOffset(Offset = "0x140")]
		private int selectedAxis;

		// Token: 0x04004DD0 RID: 19920
		[Token(Token = "0x4004DD0")]
		[FieldOffset(Offset = "0x148")]
		private AxisCalibrationData origSelectedAxisCalibrationData;

		// Token: 0x04004DD1 RID: 19921
		[Token(Token = "0x4004DD1")]
		[FieldOffset(Offset = "0x180")]
		private float displayAreaWidth;

		// Token: 0x04004DD2 RID: 19922
		[Token(Token = "0x4004DD2")]
		[FieldOffset(Offset = "0x188")]
		private List<Button> axisButtons;

		// Token: 0x04004DD3 RID: 19923
		[Token(Token = "0x4004DD3")]
		[FieldOffset(Offset = "0x190")]
		private Dictionary<int, Action<int>> buttonCallbacks;

		// Token: 0x04004DD4 RID: 19924
		[Token(Token = "0x4004DD4")]
		[FieldOffset(Offset = "0x198")]
		private int playerId;

		// Token: 0x04004DD5 RID: 19925
		[Token(Token = "0x4004DD5")]
		[FieldOffset(Offset = "0x1A0")]
		private RewiredStandaloneInputModule rewiredStandaloneInputModule;

		// Token: 0x04004DD6 RID: 19926
		[Token(Token = "0x4004DD6")]
		[FieldOffset(Offset = "0x1A8")]
		private int menuHorizActionId;

		// Token: 0x04004DD7 RID: 19927
		[Token(Token = "0x4004DD7")]
		[FieldOffset(Offset = "0x1AC")]
		private int menuVertActionId;

		// Token: 0x04004DD8 RID: 19928
		[Token(Token = "0x4004DD8")]
		[FieldOffset(Offset = "0x1B0")]
		private float minSensitivity;

		// Token: 0x0200090C RID: 2316
		[Token(Token = "0x200090C")]
		public enum ButtonIdentifier
		{
			// Token: 0x04004DDA RID: 19930
			[Token(Token = "0x4004DDA")]
			Done,
			// Token: 0x04004DDB RID: 19931
			[Token(Token = "0x4004DDB")]
			Cancel,
			// Token: 0x04004DDC RID: 19932
			[Token(Token = "0x4004DDC")]
			Default,
			// Token: 0x04004DDD RID: 19933
			[Token(Token = "0x4004DDD")]
			Calibrate
		}

		// Token: 0x0200090D RID: 2317
		[Token(Token = "0x200090D")]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x06002ECB RID: 11979 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002ECB")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x06002ECC RID: 11980 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002ECC")]
			[Address(RVA = "0xCF5670", Offset = "0xCF4670", VA = "0x180CF5670")]
			internal void <SetJoystick>b__0()
			{
			}

			// Token: 0x04004DDE RID: 19934
			[Token(Token = "0x4004DDE")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x04004DDF RID: 19935
			[Token(Token = "0x4004DDF")]
			[FieldOffset(Offset = "0x18")]
			public Button button;

			// Token: 0x04004DE0 RID: 19936
			[Token(Token = "0x4004DE0")]
			[FieldOffset(Offset = "0x20")]
			public CalibrationWindow <>4__this;
		}
	}
}
