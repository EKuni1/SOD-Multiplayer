using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Utils
{
	// Token: 0x020008F5 RID: 2293
	[Token(Token = "0x20008F5")]
	public class ExternalTools : IEnumerator<object>
	{
		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06002D34 RID: 11572 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002D35 RID: 11573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035D")]
		public static Func<object> getPlatformInitializerDelegate
		{
			[Token(Token = "0x6002D34")]
			[Address(RVA = "0xCDA310", Offset = "0xCD9310", VA = "0x180CDA310")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D35")]
			[Address(RVA = "0xCDA350", Offset = "0xCD9350", VA = "0x180CDA350")]
			set
			{
			}
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D36")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ExternalTools()
		{
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D37")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "7")]
		public void Destroy()
		{
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x00010230 File Offset: 0x0000E430
		[Token(Token = "0x1700035E")]
		public bool isEditorPaused
		{
			[Token(Token = "0x6002D38")]
			[Address(RVA = "0xCDA3F0", Offset = "0xCD93F0", VA = "0x180CDA3F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x06002D39 RID: 11577 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002D3A RID: 11578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000064")]
		public event Action<bool> EditorPausedStateChangedEvent
		{
			[Token(Token = "0x6002D39")]
			[Address(RVA = "0xCDA400", Offset = "0xCD9400", VA = "0x180CDA400", Slot = "5")]
			add
			{
			}
			[Token(Token = "0x6002D3A")]
			[Address(RVA = "0xCDA500", Offset = "0xCD9500", VA = "0x180CDA500", Slot = "6")]
			remove
			{
			}
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D3B")]
		[Address(RVA = "0xCDA600", Offset = "0xCD9600", VA = "0x180CDA600", Slot = "8")]
		public object GetPlatformInitializer()
		{
			return null;
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D3C")]
		[Address(RVA = "0xCDA6C0", Offset = "0xCD96C0", VA = "0x180CDA6C0", Slot = "9")]
		public string GetFocusedEditorWindowTitle()
		{
			return null;
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x00010248 File Offset: 0x0000E448
		[Token(Token = "0x6002D3D")]
		[Address(RVA = "0x418400", Offset = "0x417400", VA = "0x180418400", Slot = "10")]
		public bool IsEditorSceneViewFocused()
		{
			return default(bool);
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x00010260 File Offset: 0x0000E460
		[Token(Token = "0x6002D3E")]
		[Address(RVA = "0x418400", Offset = "0x417400", VA = "0x180418400", Slot = "11")]
		public bool LinuxInput_IsJoystickPreconfigured(string name)
		{
			return default(bool);
		}

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x06002D3F RID: 11583 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002D40 RID: 11584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000065")]
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange
		{
			[Token(Token = "0x6002D3F")]
			[Address(RVA = "0xCDA700", Offset = "0xCD9700", VA = "0x180CDA700", Slot = "14")]
			add
			{
			}
			[Token(Token = "0x6002D40")]
			[Address(RVA = "0xCDA810", Offset = "0xCD9810", VA = "0x180CDA810", Slot = "15")]
			remove
			{
			}
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x00010278 File Offset: 0x0000E478
		[Token(Token = "0x6002D41")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "12")]
		public int XboxOneInput_GetUserIdForGamepad(uint id)
		{
			return 0;
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x00010290 File Offset: 0x0000E490
		[Token(Token = "0x6002D42")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "13")]
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
		{
			return 0UL;
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x000102A8 File Offset: 0x0000E4A8
		[Token(Token = "0x6002D43")]
		[Address(RVA = "0x418400", Offset = "0x417400", VA = "0x180418400", Slot = "16")]
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
		{
			return default(bool);
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D44")]
		[Address(RVA = "0xCDA920", Offset = "0xCD9920", VA = "0x180CDA920", Slot = "17")]
		public string XboxOneInput_GetControllerType(ulong xboxControllerId)
		{
			return null;
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x000102C0 File Offset: 0x0000E4C0
		[Token(Token = "0x6002D45")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "18")]
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
		{
			return 0U;
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D46")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "19")]
		public void XboxOne_Gamepad_UpdatePlugin()
		{
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x000102D8 File Offset: 0x0000E4D8
		[Token(Token = "0x6002D47")]
		[Address(RVA = "0x418400", Offset = "0x417400", VA = "0x180418400", Slot = "20")]
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
		{
			return default(bool);
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D48")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "21")]
		public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS)
		{
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x000102F0 File Offset: 0x0000E4F0
		[Token(Token = "0x6002D49")]
		[Address(RVA = "0x418750", Offset = "0x417750", VA = "0x180418750", Slot = "22")]
		public Vector3 PS4Input_GetLastAcceleration(int id)
		{
			return default(Vector3);
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x00010308 File Offset: 0x0000E508
		[Token(Token = "0x6002D4A")]
		[Address(RVA = "0x418750", Offset = "0x417750", VA = "0x180418750", Slot = "23")]
		public Vector3 PS4Input_GetLastGyro(int id)
		{
			return default(Vector3);
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x00010320 File Offset: 0x0000E520
		[Token(Token = "0x6002D4B")]
		[Address(RVA = "0xCDA960", Offset = "0xCD9960", VA = "0x180CDA960", Slot = "24")]
		public Vector4 PS4Input_GetLastOrientation(int id)
		{
			return default(Vector4);
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D4C")]
		[Address(RVA = "0xCDA9B0", Offset = "0xCD99B0", VA = "0x180CDA9B0", Slot = "25")]
		public void PS4Input_GetLastTouchData(int id, out int touchNum, out int touch0x, out int touch0y, out int touch0id, out int touch1x, out int touch1y, out int touch1id)
		{
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D4D")]
		[Address(RVA = "0xCDA9E0", Offset = "0xCD99E0", VA = "0x180CDA9E0", Slot = "26")]
		public void PS4Input_GetPadControllerInformation(int id, out float touchpixelDensity, out int touchResolutionX, out int touchResolutionY, out int analogDeadZoneLeft, out int analogDeadZoneright, out int connectionType)
		{
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D4E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "27")]
		public void PS4Input_PadSetMotionSensorState(int id, bool bEnable)
		{
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D4F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "28")]
		public void PS4Input_PadSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D50")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "29")]
		public void PS4Input_PadSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D51")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "30")]
		public void PS4Input_PadSetLightBar(int id, int red, int green, int blue)
		{
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D52")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "31")]
		public void PS4Input_PadResetLightBar(int id)
		{
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D53")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "32")]
		public void PS4Input_PadSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D54")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "33")]
		public void PS4Input_PadResetOrientation(int id)
		{
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x00010338 File Offset: 0x0000E538
		[Token(Token = "0x6002D55")]
		[Address(RVA = "0x418400", Offset = "0x417400", VA = "0x180418400", Slot = "34")]
		public bool PS4Input_PadIsConnected(int id)
		{
			return default(bool);
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D56")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "35")]
		public void PS4Input_GetUsersDetails(int slot, object loggedInUser)
		{
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x00010350 File Offset: 0x0000E550
		[Token(Token = "0x6002D57")]
		[Address(RVA = "0x41EDE0", Offset = "0x41DDE0", VA = "0x18041EDE0", Slot = "36")]
		public int PS4Input_GetDeviceClassForHandle(int handle)
		{
			return 0;
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D58")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "37")]
		public string PS4Input_GetDeviceClassString(int intValue)
		{
			return null;
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x00010368 File Offset: 0x0000E568
		[Token(Token = "0x6002D59")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "38")]
		public int PS4Input_PadGetUsersHandles2(int maxControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D5A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "39")]
		public void PS4Input_GetSpecialControllerInformation(int id, int padIndex, object controllerInformation)
		{
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x00010380 File Offset: 0x0000E580
		[Token(Token = "0x6002D5B")]
		[Address(RVA = "0x418750", Offset = "0x417750", VA = "0x180418750", Slot = "40")]
		public Vector3 PS4Input_SpecialGetLastAcceleration(int id)
		{
			return default(Vector3);
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x00010398 File Offset: 0x0000E598
		[Token(Token = "0x6002D5C")]
		[Address(RVA = "0x418750", Offset = "0x417750", VA = "0x180418750", Slot = "41")]
		public Vector3 PS4Input_SpecialGetLastGyro(int id)
		{
			return default(Vector3);
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x000103B0 File Offset: 0x0000E5B0
		[Token(Token = "0x6002D5D")]
		[Address(RVA = "0xCDA960", Offset = "0xCD9960", VA = "0x180CDA960", Slot = "42")]
		public Vector4 PS4Input_SpecialGetLastOrientation(int id)
		{
			return default(Vector4);
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x000103C8 File Offset: 0x0000E5C8
		[Token(Token = "0x6002D5E")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "43")]
		public int PS4Input_SpecialGetUsersHandles(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x000103E0 File Offset: 0x0000E5E0
		[Token(Token = "0x6002D5F")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "44")]
		public int PS4Input_SpecialGetUsersHandles2(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x000103F8 File Offset: 0x0000E5F8
		[Token(Token = "0x6002D60")]
		[Address(RVA = "0x418400", Offset = "0x417400", VA = "0x180418400", Slot = "45")]
		public bool PS4Input_SpecialIsConnected(int id)
		{
			return default(bool);
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D61")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "46")]
		public void PS4Input_SpecialResetLightSphere(int id)
		{
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D62")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "47")]
		public void PS4Input_SpecialResetOrientation(int id)
		{
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D63")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "48")]
		public void PS4Input_SpecialSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D64")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "49")]
		public void PS4Input_SpecialSetLightSphere(int id, int red, int green, int blue)
		{
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D65")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "50")]
		public void PS4Input_SpecialSetMotionSensorState(int id, bool bEnable)
		{
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D66")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "51")]
		public void PS4Input_SpecialSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D67")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "52")]
		public void PS4Input_SpecialSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x00010410 File Offset: 0x0000E610
		[Token(Token = "0x6002D68")]
		[Address(RVA = "0x418750", Offset = "0x417750", VA = "0x180418750", Slot = "53")]
		public Vector3 PS4Input_AimGetLastAcceleration(int id)
		{
			return default(Vector3);
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00010428 File Offset: 0x0000E628
		[Token(Token = "0x6002D69")]
		[Address(RVA = "0x418750", Offset = "0x417750", VA = "0x180418750", Slot = "54")]
		public Vector3 PS4Input_AimGetLastGyro(int id)
		{
			return default(Vector3);
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x00010440 File Offset: 0x0000E640
		[Token(Token = "0x6002D6A")]
		[Address(RVA = "0xCDA960", Offset = "0xCD9960", VA = "0x180CDA960", Slot = "55")]
		public Vector4 PS4Input_AimGetLastOrientation(int id)
		{
			return default(Vector4);
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x00010458 File Offset: 0x0000E658
		[Token(Token = "0x6002D6B")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "56")]
		public int PS4Input_AimGetUsersHandles(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x00010470 File Offset: 0x0000E670
		[Token(Token = "0x6002D6C")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "57")]
		public int PS4Input_AimGetUsersHandles2(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00010488 File Offset: 0x0000E688
		[Token(Token = "0x6002D6D")]
		[Address(RVA = "0x418400", Offset = "0x417400", VA = "0x180418400", Slot = "58")]
		public bool PS4Input_AimIsConnected(int id)
		{
			return default(bool);
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "59")]
		public void PS4Input_AimResetLightSphere(int id)
		{
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "60")]
		public void PS4Input_AimResetOrientation(int id)
		{
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D70")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "61")]
		public void PS4Input_AimSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D71")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "62")]
		public void PS4Input_AimSetLightSphere(int id, int red, int green, int blue)
		{
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D72")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "63")]
		public void PS4Input_AimSetMotionSensorState(int id, bool bEnable)
		{
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D73")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "64")]
		public void PS4Input_AimSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D74")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "65")]
		public void PS4Input_AimSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x000104A0 File Offset: 0x0000E6A0
		[Token(Token = "0x6002D75")]
		[Address(RVA = "0x418750", Offset = "0x417750", VA = "0x180418750", Slot = "66")]
		public Vector3 PS4Input_GetLastMoveAcceleration(int id, int index)
		{
			return default(Vector3);
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x000104B8 File Offset: 0x0000E6B8
		[Token(Token = "0x6002D76")]
		[Address(RVA = "0x418750", Offset = "0x417750", VA = "0x180418750", Slot = "67")]
		public Vector3 PS4Input_GetLastMoveGyro(int id, int index)
		{
			return default(Vector3);
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x000104D0 File Offset: 0x0000E6D0
		[Token(Token = "0x6002D77")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "68")]
		public int PS4Input_MoveGetButtons(int id, int index)
		{
			return 0;
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x000104E8 File Offset: 0x0000E6E8
		[Token(Token = "0x6002D78")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "69")]
		public int PS4Input_MoveGetAnalogButton(int id, int index)
		{
			return 0;
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00010500 File Offset: 0x0000E700
		[Token(Token = "0x6002D79")]
		[Address(RVA = "0x418400", Offset = "0x417400", VA = "0x180418400", Slot = "70")]
		public bool PS4Input_MoveIsConnected(int id, int index)
		{
			return default(bool);
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x00010518 File Offset: 0x0000E718
		[Token(Token = "0x6002D7A")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "71")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles, int[] secondaryHandles)
		{
			return 0;
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x00010530 File Offset: 0x0000E730
		[Token(Token = "0x6002D7B")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "72")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles)
		{
			return 0;
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x00010548 File Offset: 0x0000E748
		[Token(Token = "0x6002D7C")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "73")]
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers)
		{
			return 0;
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x00010560 File Offset: 0x0000E760
		[Token(Token = "0x6002D7D")]
		[Address(RVA = "0xCDAA10", Offset = "0xCD9A10", VA = "0x180CDAA10", Slot = "74")]
		public IntPtr PS4Input_MoveGetControllerInputForTracking()
		{
			return 0;
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x00010578 File Offset: 0x0000E778
		[Token(Token = "0x6002D7E")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "75")]
		public int PS4Input_MoveSetLightSphere(int id, int index, int red, int green, int blue)
		{
			return 0;
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x00010590 File Offset: 0x0000E790
		[Token(Token = "0x6002D7F")]
		[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "76")]
		public int PS4Input_MoveSetVibration(int id, int index, int motor)
		{
			return 0;
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D80")]
		[Address(RVA = "0xCDAA50", Offset = "0xCD9A50", VA = "0x180CDAA50", Slot = "77")]
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
		{
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x000105A8 File Offset: 0x0000E7A8
		[Token(Token = "0x6002D81")]
		[Address(RVA = "0x41EDE0", Offset = "0x41DDE0", VA = "0x18041EDE0", Slot = "78")]
		public int GetAndroidAPILevel()
		{
			return 0;
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D82")]
		[Address(RVA = "0xCDAB80", Offset = "0xCD9B80", VA = "0x180CDAB80", Slot = "79")]
		public void WindowsStandalone_ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize)
		{
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x000105C0 File Offset: 0x0000E7C0
		[Token(Token = "0x6002D83")]
		[Address(RVA = "0xCDAD20", Offset = "0xCD9D20", VA = "0x180CDAD20", Slot = "80")]
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
		{
			return default(bool);
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D84")]
		[Address(RVA = "0xCDAF10", Offset = "0xCD9F10", VA = "0x180CDAF10", Slot = "81")]
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
		{
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x000105D8 File Offset: 0x0000E7D8
		[Token(Token = "0x1700035F")]
		public bool UnityInput_IsTouchPressureSupported
		{
			[Token(Token = "0x6002D85")]
			[Address(RVA = "0xCDB100", Offset = "0xCDA100", VA = "0x180CDB100", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x000105F0 File Offset: 0x0000E7F0
		[Token(Token = "0x6002D86")]
		[Address(RVA = "0xCDB150", Offset = "0xCDA150", VA = "0x180CDB150", Slot = "83")]
		public float UnityInput_GetTouchPressure(ref Touch touch)
		{
			return 0f;
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x00010608 File Offset: 0x0000E808
		[Token(Token = "0x6002D87")]
		[Address(RVA = "0xCDB160", Offset = "0xCDA160", VA = "0x180CDB160", Slot = "84")]
		public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
		{
			return 0f;
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D88")]
		[Address(RVA = "0xCDB170", Offset = "0xCDA170", VA = "0x180CDB170", Slot = "85")]
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
		{
			return null;
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D89")]
		[Address(RVA = "0xCDB1E0", Offset = "0xCDA1E0", VA = "0x180CDB1E0", Slot = "86")]
		public Type[] GetControllerTemplateTypes()
		{
			return null;
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D8A")]
		[Address(RVA = "0xCDB280", Offset = "0xCDA280", VA = "0x180CDB280", Slot = "87")]
		public Type[] GetControllerTemplateInterfaceTypes()
		{
			return null;
		}

		// Token: 0x04004D48 RID: 19784
		[Token(Token = "0x4004D48")]
		[FieldOffset(Offset = "0x0")]
		private static Func<object> _getPlatformInitializerDelegate;

		// Token: 0x04004D49 RID: 19785
		[Token(Token = "0x4004D49")]
		[FieldOffset(Offset = "0x10")]
		private bool _isEditorPaused;

		// Token: 0x04004D4A RID: 19786
		[Token(Token = "0x4004D4A")]
		[FieldOffset(Offset = "0x18")]
		private Action<bool> _EditorPausedStateChangedEvent;
	}
}
