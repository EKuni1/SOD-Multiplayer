using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200060A RID: 1546
[Token(Token = "0x200060A")]
public class KeypadController : MonoBehaviour
{
	// Token: 0x06002205 RID: 8709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002205")]
	[Address(RVA = "0xB202E0", Offset = "0xB1F2E0", VA = "0x180B202E0")]
	private void OnEnable()
	{
	}

	// Token: 0x06002206 RID: 8710 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002206")]
	[Address(RVA = "0xB20980", Offset = "0xB1F980", VA = "0x180B20980")]
	private void OnDisable()
	{
	}

	// Token: 0x06002207 RID: 8711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002207")]
	[Address(RVA = "0xB20B60", Offset = "0xB1FB60", VA = "0x180B20B60")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002208 RID: 8712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002208")]
	[Address(RVA = "0xB20D80", Offset = "0xB1FD80", VA = "0x180B20D80")]
	public void PressNumberButton(int newInt)
	{
	}

	// Token: 0x06002209 RID: 8713 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002209")]
	[Address(RVA = "0xB21350", Offset = "0xB20350", VA = "0x180B21350")]
	public void OnKeypadButtonDown()
	{
	}

	// Token: 0x0600220A RID: 8714 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600220A")]
	[Address(RVA = "0xB215D0", Offset = "0xB205D0", VA = "0x180B215D0")]
	public void ClearCode(bool press = true)
	{
	}

	// Token: 0x0600220B RID: 8715 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600220B")]
	[Address(RVA = "0xB219C0", Offset = "0xB209C0", VA = "0x180B219C0")]
	public void SubmitCode()
	{
	}

	// Token: 0x0600220C RID: 8716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600220C")]
	[Address(RVA = "0xB22DF0", Offset = "0xB21DF0", VA = "0x180B22DF0")]
	private void Update()
	{
	}

	// Token: 0x0600220D RID: 8717 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600220D")]
	[Address(RVA = "0xB23B20", Offset = "0xB22B20", VA = "0x180B23B20")]
	public void OnInputCode(List<int> code)
	{
	}

	// Token: 0x0600220E RID: 8718 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600220E")]
	[Address(RVA = "0xB23D50", Offset = "0xB22D50", VA = "0x180B23D50")]
	private IEnumerator InputCode(List<int> code)
	{
		return null;
	}

	// Token: 0x0600220F RID: 8719 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600220F")]
	[Address(RVA = "0xB23E60", Offset = "0xB22E60", VA = "0x180B23E60")]
	public KeypadController()
	{
	}

	// Token: 0x04002BB4 RID: 11188
	[Token(Token = "0x4002BB4")]
	[FieldOffset(Offset = "0x18")]
	public InfoWindow parentWindow;

	// Token: 0x04002BB5 RID: 11189
	[Token(Token = "0x4002BB5")]
	[FieldOffset(Offset = "0x20")]
	public Evidence evidence;

	// Token: 0x04002BB6 RID: 11190
	[Token(Token = "0x4002BB6")]
	[FieldOffset(Offset = "0x28")]
	public WindowContentController windowContent;

	// Token: 0x04002BB7 RID: 11191
	[Token(Token = "0x4002BB7")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI inputText;

	// Token: 0x04002BB8 RID: 11192
	[Token(Token = "0x4002BB8")]
	[FieldOffset(Offset = "0x38")]
	public List<int> input;

	// Token: 0x04002BB9 RID: 11193
	[Token(Token = "0x4002BB9")]
	[FieldOffset(Offset = "0x40")]
	public Color defaultTextColour;

	// Token: 0x04002BBA RID: 11194
	[Token(Token = "0x4002BBA")]
	[FieldOffset(Offset = "0x50")]
	public bool checking;

	// Token: 0x04002BBB RID: 11195
	[Token(Token = "0x4002BBB")]
	[FieldOffset(Offset = "0x51")]
	public bool correct;

	// Token: 0x04002BBC RID: 11196
	[Token(Token = "0x4002BBC")]
	[FieldOffset(Offset = "0x54")]
	public float checkCounter;

	// Token: 0x04002BBD RID: 11197
	[Token(Token = "0x4002BBD")]
	[FieldOffset(Offset = "0x58")]
	public bool inputCodeActive;

	// Token: 0x04002BBE RID: 11198
	[Token(Token = "0x4002BBE")]
	[FieldOffset(Offset = "0x59")]
	public bool isTelephone;

	// Token: 0x04002BBF RID: 11199
	[Token(Token = "0x4002BBF")]
	[FieldOffset(Offset = "0x5C")]
	public int digits;

	// Token: 0x0200060B RID: 1547
	[Token(Token = "0x200060B")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002211 RID: 8721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002211")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		[Token(Token = "0x6002212")]
		[Address(RVA = "0xB24010", Offset = "0xB23010", VA = "0x180B24010")]
		internal bool <SubmitCode>b__18_0(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		[Token(Token = "0x6002213")]
		[Address(RVA = "0xB24190", Offset = "0xB23190", VA = "0x180B24190")]
		internal bool <Update>b__19_0(InteractablePreset.InteractionAction item)
		{
			return default(bool);
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		[Token(Token = "0x6002214")]
		[Address(RVA = "0xB24330", Offset = "0xB23330", VA = "0x180B24330")]
		internal bool <Update>b__19_1(InteractablePreset.SwitchState item2)
		{
			return default(bool);
		}

		// Token: 0x04002BC0 RID: 11200
		[Token(Token = "0x4002BC0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly KeypadController.<>c <>9;

		// Token: 0x04002BC1 RID: 11201
		[Token(Token = "0x4002BC1")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<NewAddress> <>9__18_0;

		// Token: 0x04002BC2 RID: 11202
		[Token(Token = "0x4002BC2")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<InteractablePreset.SwitchState> <>9__19_1;

		// Token: 0x04002BC3 RID: 11203
		[Token(Token = "0x4002BC3")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<InteractablePreset.InteractionAction> <>9__19_0;
	}

	// Token: 0x0200060C RID: 1548
	[Token(Token = "0x200060C")]
	private sealed class <InputCode>d__21 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06002215 RID: 8725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002215")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <InputCode>d__21(int <>1__state)
		{
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002216")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		[Token(Token = "0x6002217")]
		[Address(RVA = "0xB24360", Offset = "0xB23360", VA = "0x180B24360", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700011C")]
		private object Current
		{
			[Token(Token = "0x6002218")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002219")]
		[Address(RVA = "0xB24510", Offset = "0xB23510", VA = "0x180B24510", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700011D")]
		private object Current
		{
			[Token(Token = "0x600221A")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002BC4 RID: 11204
		[Token(Token = "0x4002BC4")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04002BC5 RID: 11205
		[Token(Token = "0x4002BC5")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04002BC6 RID: 11206
		[Token(Token = "0x4002BC6")]
		[FieldOffset(Offset = "0x20")]
		public KeypadController <>4__this;

		// Token: 0x04002BC7 RID: 11207
		[Token(Token = "0x4002BC7")]
		[FieldOffset(Offset = "0x28")]
		public List<int> code;

		// Token: 0x04002BC8 RID: 11208
		[Token(Token = "0x4002BC8")]
		[FieldOffset(Offset = "0x30")]
		private int <codeCursor>5__2;
	}
}
