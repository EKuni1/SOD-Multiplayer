using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020006A7 RID: 1703
[Token(Token = "0x20006A7")]
public class VirtualKeyboardController : MonoBehaviour
{
	// Token: 0x17000138 RID: 312
	// (get) Token: 0x060025D0 RID: 9680 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060025D1 RID: 9681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000138")]
	public static VirtualKeyboardController Instance
	{
		[Token(Token = "0x60025D0")]
		[Address(RVA = "0xBD4250", Offset = "0xBD3250", VA = "0x180BD4250")]
		get
		{
			return null;
		}
		[Token(Token = "0x60025D1")]
		[Address(RVA = "0xBD4290", Offset = "0xBD3290", VA = "0x180BD4290")]
		private set
		{
		}
	}

	// Token: 0x060025D2 RID: 9682 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025D2")]
	[Address(RVA = "0xBD4330", Offset = "0xBD3330", VA = "0x180BD4330")]
	private void OnEnable()
	{
	}

	// Token: 0x060025D3 RID: 9683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025D3")]
	[Address(RVA = "0xBD4800", Offset = "0xBD3800", VA = "0x180BD4800")]
	private void OnFloatingGamepadTextInputDismissed(FloatingGamepadTextInputDismissed_t callback)
	{
	}

	// Token: 0x060025D4 RID: 9684 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025D4")]
	[Address(RVA = "0xBD4920", Offset = "0xBD3920", VA = "0x180BD4920")]
	private void OnGamepadTextInputDismissed(GamepadTextInputDismissed_t callback)
	{
	}

	// Token: 0x060025D5 RID: 9685 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025D5")]
	[Address(RVA = "0xBD55E0", Offset = "0xBD45E0", VA = "0x180BD55E0")]
	private void Awake()
	{
	}

	// Token: 0x060025D6 RID: 9686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025D6")]
	[Address(RVA = "0xBD5940", Offset = "0xBD4940", VA = "0x180BD5940")]
	private void Start()
	{
	}

	// Token: 0x060025D7 RID: 9687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025D7")]
	[Address(RVA = "0xBD59F0", Offset = "0xBD49F0", VA = "0x180BD59F0")]
	private void Update()
	{
	}

	// Token: 0x060025D8 RID: 9688 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025D8")]
	[Address(RVA = "0xBD5A70", Offset = "0xBD4A70", VA = "0x180BD5A70")]
	private void ProcessHotkeys()
	{
	}

	// Token: 0x060025D9 RID: 9689 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025D9")]
	[Address(RVA = "0xBD5DB0", Offset = "0xBD4DB0", VA = "0x180BD5DB0")]
	private void SetButtonIcon(ButtonController buttonController, InteractablePreset.InteractionKey key, UnityAction action)
	{
	}

	// Token: 0x060025DA RID: 9690 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025DA")]
	[Address(RVA = "0xBD5FE0", Offset = "0xBD4FE0", VA = "0x180BD5FE0")]
	public void SetCaretVisible(int pos)
	{
	}

	// Token: 0x060025DB RID: 9691 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025DB")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void ToggleSymbols()
	{
	}

	// Token: 0x060025DC RID: 9692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025DC")]
	[Address(RVA = "0xBD61B0", Offset = "0xBD51B0", VA = "0x180BD61B0")]
	public void ToggleCapsLock()
	{
	}

	// Token: 0x060025DD RID: 9693 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025DD")]
	[Address(RVA = "0xBD6510", Offset = "0xBD5510", VA = "0x180BD6510")]
	public void EnterLineBreak()
	{
	}

	// Token: 0x060025DE RID: 9694 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025DE")]
	[Address(RVA = "0xBD65B0", Offset = "0xBD55B0", VA = "0x180BD65B0")]
	public void MoveCursorUp()
	{
	}

	// Token: 0x060025DF RID: 9695 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60025DF")]
	[Address(RVA = "0xBD6680", Offset = "0xBD5680", VA = "0x180BD6680")]
	private IEnumerable<string> EnumerateLines(TMP_Text text)
	{
		return null;
	}

	// Token: 0x060025E0 RID: 9696 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025E0")]
	[Address(RVA = "0xBD6740", Offset = "0xBD5740", VA = "0x180BD6740")]
	public void ForceSteamApiCall()
	{
	}

	// Token: 0x060025E1 RID: 9697 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025E1")]
	[Address(RVA = "0xBD67E0", Offset = "0xBD57E0", VA = "0x180BD67E0")]
	public void ActivateVirtualKeyboard(bool isMultiline, string labelText = "", string existingText = "")
	{
	}

	// Token: 0x060025E2 RID: 9698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025E2")]
	[Address(RVA = "0xBD71A0", Offset = "0xBD61A0", VA = "0x180BD71A0")]
	public void DeactivateVirtualKeyboard()
	{
	}

	// Token: 0x060025E3 RID: 9699 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025E3")]
	[Address(RVA = "0xBD7660", Offset = "0xBD6660", VA = "0x180BD7660")]
	public void SendStringToVirtualKeyboardInput(string letter)
	{
	}

	// Token: 0x060025E4 RID: 9700 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025E4")]
	[Address(RVA = "0xBD76E0", Offset = "0xBD66E0", VA = "0x180BD76E0")]
	public void InitializeTextFromTarget(TMP_InputField originInputField, string targetText)
	{
	}

	// Token: 0x060025E5 RID: 9701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025E5")]
	[Address(RVA = "0xBD7770", Offset = "0xBD6770", VA = "0x180BD7770")]
	public void UpdateVirtualKeyboardLabel(string labelText)
	{
	}

	// Token: 0x060025E6 RID: 9702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025E6")]
	[Address(RVA = "0xBD77A0", Offset = "0xBD67A0", VA = "0x180BD77A0")]
	public void SubmitText()
	{
	}

	// Token: 0x060025E7 RID: 9703 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025E7")]
	[Address(RVA = "0xBD7940", Offset = "0xBD6940", VA = "0x180BD7940")]
	private void ResetIndexes()
	{
	}

	// Token: 0x060025E8 RID: 9704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025E8")]
	[Address(RVA = "0xBD79B0", Offset = "0xBD69B0", VA = "0x180BD79B0")]
	public void SelectOnAwake()
	{
	}

	// Token: 0x060025E9 RID: 9705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025E9")]
	[Address(RVA = "0xBD7B70", Offset = "0xBD6B70", VA = "0x180BD7B70")]
	public void Backspace()
	{
	}

	// Token: 0x060025EA RID: 9706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025EA")]
	[Address(RVA = "0xBD7BF0", Offset = "0xBD6BF0", VA = "0x180BD7BF0")]
	public void MoveCursorBack()
	{
	}

	// Token: 0x060025EB RID: 9707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025EB")]
	[Address(RVA = "0xBD7C10", Offset = "0xBD6C10", VA = "0x180BD7C10")]
	public void SpaceBar()
	{
	}

	// Token: 0x060025EC RID: 9708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025EC")]
	[Address(RVA = "0xBD7CA0", Offset = "0xBD6CA0", VA = "0x180BD7CA0")]
	public void MoveCursorForward()
	{
	}

	// Token: 0x060025ED RID: 9709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60025ED")]
	[Address(RVA = "0xBD7CE0", Offset = "0xBD6CE0", VA = "0x180BD7CE0")]
	public VirtualKeyboardController()
	{
	}

	// Token: 0x04003036 RID: 12342
	[Token(Token = "0x4003036")]
	[FieldOffset(Offset = "0x0")]
	private static VirtualKeyboardController <Instance>k__BackingField;

	// Token: 0x04003037 RID: 12343
	[Token(Token = "0x4003037")]
	[FieldOffset(Offset = "0x18")]
	public List<ButtonController> keyboardButtons;

	// Token: 0x04003038 RID: 12344
	[Token(Token = "0x4003038")]
	[FieldOffset(Offset = "0x20")]
	public Image capsToggle;

	// Token: 0x04003039 RID: 12345
	[Token(Token = "0x4003039")]
	[FieldOffset(Offset = "0x28")]
	public Sprite capsSprite;

	// Token: 0x0400303A RID: 12346
	[Token(Token = "0x400303A")]
	[FieldOffset(Offset = "0x30")]
	public Sprite lowerCaseSprite;

	// Token: 0x0400303B RID: 12347
	[Token(Token = "0x400303B")]
	[FieldOffset(Offset = "0x8")]
	private static VirtualKeyboardController _instance;

	// Token: 0x0400303C RID: 12348
	[Token(Token = "0x400303C")]
	[FieldOffset(Offset = "0x38")]
	public bool isActive;

	// Token: 0x0400303D RID: 12349
	[Token(Token = "0x400303D")]
	[FieldOffset(Offset = "0x40")]
	public GameObject keyboardCanvas;

	// Token: 0x0400303E RID: 12350
	[Token(Token = "0x400303E")]
	[FieldOffset(Offset = "0x48")]
	public TMP_Text keyboardLabelText;

	// Token: 0x0400303F RID: 12351
	[Token(Token = "0x400303F")]
	[FieldOffset(Offset = "0x50")]
	public TMP_InputField virtualInputField;

	// Token: 0x04003040 RID: 12352
	[Token(Token = "0x4003040")]
	[FieldOffset(Offset = "0x58")]
	private TMP_InputField _targetInputField;

	// Token: 0x04003041 RID: 12353
	[Token(Token = "0x4003041")]
	[FieldOffset(Offset = "0x60")]
	private int _lineIndex;

	// Token: 0x04003042 RID: 12354
	[Token(Token = "0x4003042")]
	[FieldOffset(Offset = "0x64")]
	public int cursorIndex;

	// Token: 0x04003043 RID: 12355
	[Token(Token = "0x4003043")]
	[FieldOffset(Offset = "0x68")]
	private Rewired.Player _player;

	// Token: 0x04003044 RID: 12356
	[Token(Token = "0x4003044")]
	[FieldOffset(Offset = "0x70")]
	public ButtonController defaultButton;

	// Token: 0x04003045 RID: 12357
	[Token(Token = "0x4003045")]
	[FieldOffset(Offset = "0x78")]
	public bool isCapsLock;

	// Token: 0x04003046 RID: 12358
	[Token(Token = "0x4003046")]
	[FieldOffset(Offset = "0x79")]
	public bool isSymbols;

	// Token: 0x04003047 RID: 12359
	[Token(Token = "0x4003047")]
	[FieldOffset(Offset = "0x7A")]
	public bool isSingleLine;

	// Token: 0x04003048 RID: 12360
	[Token(Token = "0x4003048")]
	[FieldOffset(Offset = "0x7B")]
	public bool forceSteamInput;

	// Token: 0x04003049 RID: 12361
	[Token(Token = "0x4003049")]
	[FieldOffset(Offset = "0x80")]
	public ButtonController lineBreakButton;

	// Token: 0x0400304A RID: 12362
	[Token(Token = "0x400304A")]
	[FieldOffset(Offset = "0x88")]
	private Callback<GamepadTextInputDismissed_t> _gamepadTextInputDismissed;

	// Token: 0x0400304B RID: 12363
	[Token(Token = "0x400304B")]
	[FieldOffset(Offset = "0x90")]
	private Callback<FloatingGamepadTextInputDismissed_t> _floatingGamepadTextInputDismissed;

	// Token: 0x0400304C RID: 12364
	[Token(Token = "0x400304C")]
	[FieldOffset(Offset = "0x98")]
	public bool steamKeyboardLaunched;

	// Token: 0x0400304D RID: 12365
	[Token(Token = "0x400304D")]
	[FieldOffset(Offset = "0xA0")]
	public TMP_Text apiText;

	// Token: 0x0400304E RID: 12366
	[Token(Token = "0x400304E")]
	[FieldOffset(Offset = "0xA8")]
	public TMP_Text keyboardText;

	// Token: 0x020006A8 RID: 1704
	[Token(Token = "0x20006A8")]
	private sealed class <EnumerateLines>d__41 : IEnumerator<object>, IDisposable, IEnumerator, IEnumerator<object>, IDisposable
	{
		// Token: 0x060025EE RID: 9710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EE")]
		[Address(RVA = "0xBD7DE0", Offset = "0xBD6DE0", VA = "0x180BD7DE0")]
		public <EnumerateLines>d__41(int <>1__state)
		{
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "7")]
		private void Dispose()
		{
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x0000ED00 File Offset: 0x0000CF00
		[Token(Token = "0x60025F0")]
		[Address(RVA = "0xBD7E00", Offset = "0xBD6E00", VA = "0x180BD7E00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000139")]
		private string Current
		{
			[Token(Token = "0x60025F1")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F2")]
		[Address(RVA = "0xBD7FF0", Offset = "0xBD6FF0", VA = "0x180BD7FF0", Slot = "10")]
		private void Reset()
		{
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700013A")]
		private object Current
		{
			[Token(Token = "0x60025F3")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60025F4")]
		[Address(RVA = "0xBD8040", Offset = "0xBD7040", VA = "0x180BD8040", Slot = "4")]
		private IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60025F5")]
		[Address(RVA = "0xBD8040", Offset = "0xBD7040", VA = "0x180BD8040", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400304F RID: 12367
		[Token(Token = "0x400304F")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04003050 RID: 12368
		[Token(Token = "0x4003050")]
		[FieldOffset(Offset = "0x18")]
		private string <>2__current;

		// Token: 0x04003051 RID: 12369
		[Token(Token = "0x4003051")]
		[FieldOffset(Offset = "0x20")]
		private int <>l__initialThreadId;

		// Token: 0x04003052 RID: 12370
		[Token(Token = "0x4003052")]
		[FieldOffset(Offset = "0x28")]
		private TMP_Text text;

		// Token: 0x04003053 RID: 12371
		[Token(Token = "0x4003053")]
		[FieldOffset(Offset = "0x30")]
		public TMP_Text <>3__text;

		// Token: 0x04003054 RID: 12372
		[Token(Token = "0x4003054")]
		[FieldOffset(Offset = "0x38")]
		private TMP_TextInfo <textInfo>5__2;

		// Token: 0x04003055 RID: 12373
		[Token(Token = "0x4003055")]
		[FieldOffset(Offset = "0x40")]
		private int <i>5__3;
	}
}
