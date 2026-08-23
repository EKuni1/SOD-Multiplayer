using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005C3 RID: 1475
[Token(Token = "0x20005C3")]
public class SliderController : MonoBehaviour
{
	// Token: 0x06002065 RID: 8293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002065")]
	[Address(RVA = "0xADB820", Offset = "0xADA820", VA = "0x180ADB820")]
	private void Start()
	{
	}

	// Token: 0x06002066 RID: 8294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002066")]
	[Address(RVA = "0xADBBA0", Offset = "0xADABA0", VA = "0x180ADBBA0")]
	private void OnEnable()
	{
	}

	// Token: 0x06002067 RID: 8295 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002067")]
	[Address(RVA = "0xADBD90", Offset = "0xADAD90", VA = "0x180ADBD90")]
	private void OnDisable()
	{
	}

	// Token: 0x06002068 RID: 8296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002068")]
	[Address(RVA = "0xADBF80", Offset = "0xADAF80", VA = "0x180ADBF80")]
	public void OnButtonsDown(ButtonController thisButton)
	{
	}

	// Token: 0x06002069 RID: 8297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002069")]
	[Address(RVA = "0xADC310", Offset = "0xADB310", VA = "0x180ADC310")]
	public void OnButtonsUp(ButtonController thisButton)
	{
	}

	// Token: 0x0600206A RID: 8298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600206A")]
	[Address(RVA = "0xADC3D0", Offset = "0xADB3D0", VA = "0x180ADC3D0")]
	public void OnNextButton()
	{
	}

	// Token: 0x0600206B RID: 8299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600206B")]
	[Address(RVA = "0xADC460", Offset = "0xADB460", VA = "0x180ADC460")]
	public void OnPreviousButton()
	{
	}

	// Token: 0x0600206C RID: 8300 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600206C")]
	[Address(RVA = "0xADC4F0", Offset = "0xADB4F0", VA = "0x180ADC4F0")]
	private IEnumerator RunEnd()
	{
		return null;
	}

	// Token: 0x0600206D RID: 8301 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600206D")]
	[Address(RVA = "0xADC590", Offset = "0xADB590", VA = "0x180ADC590")]
	private IEnumerator ControllerQuickValueAlter(int alterValue)
	{
		return null;
	}

	// Token: 0x0600206E RID: 8302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600206E")]
	[Address(RVA = "0xADC640", Offset = "0xADB640", VA = "0x180ADC640")]
	public void SetValueWithoutNotify(int newVal)
	{
	}

	// Token: 0x0600206F RID: 8303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600206F")]
	[Address(RVA = "0xADC690", Offset = "0xADB690", VA = "0x180ADC690")]
	public void OnValueChange()
	{
	}

	// Token: 0x06002070 RID: 8304 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002070")]
	[Address(RVA = "0xADC710", Offset = "0xADB710", VA = "0x180ADC710")]
	public void UpdateDisplayValue()
	{
	}

	// Token: 0x06002071 RID: 8305 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002071")]
	[Address(RVA = "0xADCA70", Offset = "0xADBA70", VA = "0x180ADCA70")]
	public SliderController()
	{
	}

	// Token: 0x06002072 RID: 8306 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002072")]
	[Address(RVA = "0xADC3D0", Offset = "0xADB3D0", VA = "0x180ADC3D0")]
	private void <Start>b__11_0()
	{
	}

	// Token: 0x06002073 RID: 8307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002073")]
	[Address(RVA = "0xADC460", Offset = "0xADB460", VA = "0x180ADC460")]
	private void <Start>b__11_1()
	{
	}

	// Token: 0x040029FE RID: 10750
	[Token(Token = "0x40029FE")]
	[FieldOffset(Offset = "0x18")]
	public Slider slider;

	// Token: 0x040029FF RID: 10751
	[Token(Token = "0x40029FF")]
	[FieldOffset(Offset = "0x20")]
	public ButtonController prevButton;

	// Token: 0x04002A00 RID: 10752
	[Token(Token = "0x4002A00")]
	[FieldOffset(Offset = "0x28")]
	public ButtonController nextButton;

	// Token: 0x04002A01 RID: 10753
	[Token(Token = "0x4002A01")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI label;

	// Token: 0x04002A02 RID: 10754
	[Token(Token = "0x4002A02")]
	[FieldOffset(Offset = "0x38")]
	public string labelDictRef;

	// Token: 0x04002A03 RID: 10755
	[Token(Token = "0x4002A03")]
	[FieldOffset(Offset = "0x40")]
	public string playerPrefsID;

	// Token: 0x04002A04 RID: 10756
	[Token(Token = "0x4002A04")]
	[FieldOffset(Offset = "0x48")]
	public bool displayValue;

	// Token: 0x04002A05 RID: 10757
	[Token(Token = "0x4002A05")]
	[FieldOffset(Offset = "0x49")]
	public bool isPercentage;

	// Token: 0x04002A06 RID: 10758
	[Token(Token = "0x4002A06")]
	[FieldOffset(Offset = "0x4A")]
	private bool clickThisFrame;

	// Token: 0x04002A07 RID: 10759
	[Token(Token = "0x4002A07")]
	[FieldOffset(Offset = "0x4B")]
	public bool displayPasscodeFormat;

	// Token: 0x04002A08 RID: 10760
	[Token(Token = "0x4002A08")]
	[FieldOffset(Offset = "0x50")]
	public ButtonController heldButton;

	// Token: 0x020005C4 RID: 1476
	[Token(Token = "0x20005C4")]
	private sealed class <RunEnd>d__18 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06002074 RID: 8308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002074")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <RunEnd>d__18(int <>1__state)
		{
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002075")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x0000DF08 File Offset: 0x0000C108
		[Token(Token = "0x6002076")]
		[Address(RVA = "0xADCAC0", Offset = "0xADBAC0", VA = "0x180ADCAC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000112")]
		private object Current
		{
			[Token(Token = "0x6002077")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002078")]
		[Address(RVA = "0xADCBA0", Offset = "0xADBBA0", VA = "0x180ADCBA0", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000113")]
		private object Current
		{
			[Token(Token = "0x6002079")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002A09 RID: 10761
		[Token(Token = "0x4002A09")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002A0A RID: 10762
		[Token(Token = "0x4002A0A")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002A0B RID: 10763
		[Token(Token = "0x4002A0B")]
		[FieldOffset(Offset = "0x20")]
		public SliderController <>4__this;

		// Token: 0x04002A0C RID: 10764
		[Token(Token = "0x4002A0C")]
		[FieldOffset(Offset = "0x28")]
		private bool <runOnce>5__2;
	}

	// Token: 0x020005C5 RID: 1477
	[Token(Token = "0x20005C5")]
	private sealed class <ControllerQuickValueAlter>d__19 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x0600207A RID: 8314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207A")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <ControllerQuickValueAlter>d__19(int <>1__state)
		{
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x0000DF20 File Offset: 0x0000C120
		[Token(Token = "0x600207C")]
		[Address(RVA = "0xADCBF0", Offset = "0xADBBF0", VA = "0x180ADCBF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000114")]
		private object Current
		{
			[Token(Token = "0x600207D")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207E")]
		[Address(RVA = "0xADCF10", Offset = "0xADBF10", VA = "0x180ADCF10", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000115")]
		private object Current
		{
			[Token(Token = "0x600207F")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002A0D RID: 10765
		[Token(Token = "0x4002A0D")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002A0E RID: 10766
		[Token(Token = "0x4002A0E")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002A0F RID: 10767
		[Token(Token = "0x4002A0F")]
		[FieldOffset(Offset = "0x20")]
		public SliderController <>4__this;

		// Token: 0x04002A10 RID: 10768
		[Token(Token = "0x4002A10")]
		[FieldOffset(Offset = "0x28")]
		public int alterValue;

		// Token: 0x04002A11 RID: 10769
		[Token(Token = "0x4002A11")]
		[FieldOffset(Offset = "0x2C")]
		private float <heldDown>5__2;

		// Token: 0x04002A12 RID: 10770
		[Token(Token = "0x4002A12")]
		[FieldOffset(Offset = "0x30")]
		private float <delayModify>5__3;
	}
}
