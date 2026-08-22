using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Rewired;
using UnityEngine;

// Token: 0x02000332 RID: 818
[Token(Token = "0x2000332")]
public class InputController : MonoBehaviour
{
	// Token: 0x1400001A RID: 26
	// (add) Token: 0x06001260 RID: 4704 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001261 RID: 4705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1400001A")]
	public event InputController.InputModeChange OnInputModeChange
	{
		[Token(Token = "0x6001260")]
		[Address(RVA = "0x7055B0", Offset = "0x7045B0", VA = "0x1807055B0")]
		add
		{
		}
		[Token(Token = "0x6001261")]
		[Address(RVA = "0x7056A0", Offset = "0x7046A0", VA = "0x1807056A0")]
		remove
		{
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06001262 RID: 4706 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000A2")]
	public static InputController Instance
	{
		[Token(Token = "0x6001262")]
		[Address(RVA = "0x705790", Offset = "0x704790", VA = "0x180705790")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001263 RID: 4707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001263")]
	[Address(RVA = "0x7057D0", Offset = "0x7047D0", VA = "0x1807057D0")]
	private void Awake()
	{
	}

	// Token: 0x06001264 RID: 4708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001264")]
	[Address(RVA = "0x705B20", Offset = "0x704B20", VA = "0x180705B20")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001265 RID: 4709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001265")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	private void Start()
	{
	}

	// Token: 0x06001266 RID: 4710 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001266")]
	[Address(RVA = "0x705D30", Offset = "0x704D30", VA = "0x180705D30")]
	private void Update()
	{
	}

	// Token: 0x06001267 RID: 4711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001267")]
	[Address(RVA = "0x70B930", Offset = "0x70A930", VA = "0x18070B930")]
	public void StartQuickSaveAsync()
	{
	}

	// Token: 0x06001268 RID: 4712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001268")]
	[Address(RVA = "0x70BA80", Offset = "0x70AA80", VA = "0x18070BA80")]
	public void ResetCurrentButtonDown()
	{
	}

	// Token: 0x06001269 RID: 4713 RVA: 0x00008BC8 File Offset: 0x00006DC8
	[Token(Token = "0x6001269")]
	[Address(RVA = "0x70BAE0", Offset = "0x70AAE0", VA = "0x18070BAE0")]
	public float GetAxisRelative(string actionId)
	{
		return 0f;
	}

	// Token: 0x0600126A RID: 4714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126A")]
	[Address(RVA = "0x70BBC0", Offset = "0x70ABC0", VA = "0x18070BBC0")]
	public void SetMouseInputMode(bool val, bool forceUpdate = false)
	{
	}

	// Token: 0x0600126B RID: 4715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126B")]
	[Address(RVA = "0x70C990", Offset = "0x70B990", VA = "0x18070C990")]
	public void SetCursorVisible(bool val)
	{
	}

	// Token: 0x0600126C RID: 4716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126C")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void RefreshControllers()
	{
	}

	// Token: 0x0600126D RID: 4717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126D")]
	[Address(RVA = "0x70CAA0", Offset = "0x70BAA0", VA = "0x18070CAA0")]
	public void SetCursorLock(bool value)
	{
	}

	// Token: 0x0600126E RID: 4718 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126E")]
	[Address(RVA = "0x70CCF0", Offset = "0x70BCF0", VA = "0x18070CCF0")]
	public void ExecuteControllerVibration(ref List<InputController.ControllerVibration> vibrationConfig, float soundDuration)
	{
	}

	// Token: 0x0600126F RID: 4719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600126F")]
	[Address(RVA = "0x70CF30", Offset = "0x70BF30", VA = "0x18070CF30")]
	public InputController()
	{
	}

	// Token: 0x040016F4 RID: 5876
	[Token(Token = "0x40016F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool enableInput;

	// Token: 0x040016F5 RID: 5877
	[Token(Token = "0x40016F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public Rewired.Player player;

	// Token: 0x040016F6 RID: 5878
	[Token(Token = "0x40016F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve nearestLookAtCurve;

	// Token: 0x040016F7 RID: 5879
	[Token(Token = "0x40016F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ControllerType lastActiveController;

	// Token: 0x040016F8 RID: 5880
	[Token(Token = "0x40016F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool mouseInputMode;

	// Token: 0x040016F9 RID: 5881
	[Token(Token = "0x40016F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	private bool initalInputModeSet;

	// Token: 0x040016FA RID: 5882
	[Token(Token = "0x40016FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	public bool cursorVisible;

	// Token: 0x040016FB RID: 5883
	[Token(Token = "0x40016FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ButtonController currentButtonDown;

	// Token: 0x040016FC RID: 5884
	[Token(Token = "0x40016FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float controlFallbackCheck;

	// Token: 0x040016FD RID: 5885
	[Token(Token = "0x40016FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool controllerStickNavigateReset;

	// Token: 0x040016FF RID: 5887
	[Token(Token = "0x40016FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static InputController _instance;

	// Token: 0x02000333 RID: 819
	// (Invoke) Token: 0x06001271 RID: 4721
	[Token(Token = "0x2000333")]
	public delegate void InputModeChange();

	// Token: 0x02000334 RID: 820
	[Token(Token = "0x2000334")]
	[Serializable]
	public class ControllerVibration
	{
		// Token: 0x06001274 RID: 4724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001274")]
		[Address(RVA = "0x70CF90", Offset = "0x70BF90", VA = "0x18070CF90")]
		public ControllerVibration()
		{
		}

		// Token: 0x04001700 RID: 5888
		[Token(Token = "0x4001700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int motorIndex;

		// Token: 0x04001701 RID: 5889
		[Token(Token = "0x4001701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float fullMotorSpeed;

		// Token: 0x04001702 RID: 5890
		[Token(Token = "0x4001702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool matchSoundDuration;

		// Token: 0x04001703 RID: 5891
		[Token(Token = "0x4001703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float duration;
	}

	// Token: 0x02000335 RID: 821
	[Token(Token = "0x2000335")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001276 RID: 4726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001276")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00008BE0 File Offset: 0x00006DE0
		[Token(Token = "0x6001277")]
		[Address(RVA = "0x70D060", Offset = "0x70C060", VA = "0x18070D060")]
		internal bool <Update>b__21_0(ButtonController item)
		{
			return default(bool);
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00008BF8 File Offset: 0x00006DF8
		[Token(Token = "0x6001278")]
		[Address(RVA = "0x70D170", Offset = "0x70C170", VA = "0x18070D170")]
		internal bool <Update>b__21_1(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00008C10 File Offset: 0x00006E10
		[Token(Token = "0x6001279")]
		[Address(RVA = "0x70D200", Offset = "0x70C200", VA = "0x18070D200")]
		internal bool <Update>b__21_2(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00008C28 File Offset: 0x00006E28
		[Token(Token = "0x600127A")]
		[Address(RVA = "0x70D290", Offset = "0x70C290", VA = "0x18070D290")]
		internal bool <Update>b__21_3(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00008C40 File Offset: 0x00006E40
		[Token(Token = "0x600127B")]
		[Address(RVA = "0x70D320", Offset = "0x70C320", VA = "0x18070D320")]
		internal bool <Update>b__21_4(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00008C58 File Offset: 0x00006E58
		[Token(Token = "0x600127C")]
		[Address(RVA = "0x70D3B0", Offset = "0x70C3B0", VA = "0x18070D3B0")]
		internal bool <Update>b__21_5(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x600127D")]
		[Address(RVA = "0x70D440", Offset = "0x70C440", VA = "0x18070D440")]
		internal bool <Update>b__21_6(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x600127E")]
		[Address(RVA = "0x70D4D0", Offset = "0x70C4D0", VA = "0x18070D4D0")]
		internal bool <Update>b__21_7(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x600127F")]
		[Address(RVA = "0x70D560", Offset = "0x70C560", VA = "0x18070D560")]
		internal bool <Update>b__21_8(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[Token(Token = "0x6001280")]
		[Address(RVA = "0x70D5F0", Offset = "0x70C5F0", VA = "0x18070D5F0")]
		internal bool <Update>b__21_9(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[Token(Token = "0x6001281")]
		[Address(RVA = "0x70D680", Offset = "0x70C680", VA = "0x18070D680")]
		internal bool <Update>b__21_10(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00008CE8 File Offset: 0x00006EE8
		[Token(Token = "0x6001282")]
		[Address(RVA = "0x477780", Offset = "0x476780", VA = "0x180477780")]
		internal bool <Update>b__21_11(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00008D00 File Offset: 0x00006F00
		[Token(Token = "0x6001283")]
		[Address(RVA = "0x70D710", Offset = "0x70C710", VA = "0x18070D710")]
		internal bool <SetMouseInputMode>b__25_0(PlayerPrefsController.GameSetting item)
		{
			return default(bool);
		}

		// Token: 0x04001704 RID: 5892
		[Token(Token = "0x4001704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly InputController.<>c <>9;

		// Token: 0x04001705 RID: 5893
		[Token(Token = "0x4001705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<ButtonController> <>9__21_0;

		// Token: 0x04001706 RID: 5894
		[Token(Token = "0x4001706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__21_1;

		// Token: 0x04001707 RID: 5895
		[Token(Token = "0x4001707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__21_2;

		// Token: 0x04001708 RID: 5896
		[Token(Token = "0x4001708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__21_3;

		// Token: 0x04001709 RID: 5897
		[Token(Token = "0x4001709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__21_4;

		// Token: 0x0400170A RID: 5898
		[Token(Token = "0x400170A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__21_5;

		// Token: 0x0400170B RID: 5899
		[Token(Token = "0x400170B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__21_6;

		// Token: 0x0400170C RID: 5900
		[Token(Token = "0x400170C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__21_7;

		// Token: 0x0400170D RID: 5901
		[Token(Token = "0x400170D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__21_8;

		// Token: 0x0400170E RID: 5902
		[Token(Token = "0x400170E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__21_9;

		// Token: 0x0400170F RID: 5903
		[Token(Token = "0x400170F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__21_10;

		// Token: 0x04001710 RID: 5904
		[Token(Token = "0x4001710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Predicate<FirstPersonItemController.InventorySlot> <>9__21_11;

		// Token: 0x04001711 RID: 5905
		[Token(Token = "0x4001711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Predicate<PlayerPrefsController.GameSetting> <>9__25_0;
	}

	// Token: 0x02000336 RID: 822
	[Token(Token = "0x2000336")]
	[StructLayout(3)]
	private struct <StartQuickSaveAsync>d__22 : IEnumerator<object>
	{
		// Token: 0x06001284 RID: 4740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001284")]
		[Address(RVA = "0x70D7A0", Offset = "0x70C7A0", VA = "0x18070D7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001285")]
		[Address(RVA = "0x6F8FA0", Offset = "0x6F7FA0", VA = "0x1806F8FA0", Slot = "5")]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x04001712 RID: 5906
		[Token(Token = "0x4001712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		// Token: 0x04001713 RID: 5907
		[Token(Token = "0x4001713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		// Token: 0x04001714 RID: 5908
		[Token(Token = "0x4001714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter <>u__1;
	}
}
