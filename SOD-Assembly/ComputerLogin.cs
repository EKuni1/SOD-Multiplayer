using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002C1 RID: 705
[Token(Token = "0x20002C1")]
public class ComputerLogin : CruncherAppContent
{
	// Token: 0x06000FBF RID: 4031 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FBF")]
	[Address(RVA = "0x684FC0", Offset = "0x683FC0", VA = "0x180684FC0", Slot = "5")]
	public override void OnSetup()
	{
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC0")]
	[Address(RVA = "0x685D70", Offset = "0x684D70", VA = "0x180685D70")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000FC1 RID: 4033 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC1")]
	[Address(RVA = "0x685E10", Offset = "0x684E10", VA = "0x180685E10")]
	public void OnNewUserSelected()
	{
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC2")]
	[Address(RVA = "0x686730", Offset = "0x685730", VA = "0x180686730")]
	public void PressNumberButton(int newInt)
	{
	}

	// Token: 0x06000FC3 RID: 4035 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC3")]
	[Address(RVA = "0x686BC0", Offset = "0x685BC0", VA = "0x180686BC0")]
	public void ClearCode(bool press = true)
	{
	}

	// Token: 0x06000FC4 RID: 4036 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC4")]
	[Address(RVA = "0x686EF0", Offset = "0x685EF0", VA = "0x180686EF0")]
	public void SubmitCode()
	{
	}

	// Token: 0x06000FC5 RID: 4037 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC5")]
	[Address(RVA = "0x6876A0", Offset = "0x6866A0", VA = "0x1806876A0")]
	private void Update()
	{
	}

	// Token: 0x06000FC6 RID: 4038 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC6")]
	[Address(RVA = "0x687B50", Offset = "0x686B50", VA = "0x180687B50")]
	public void OnInputCode(List<int> code, float keyDelay = 0.15f)
	{
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000FC7")]
	[Address(RVA = "0x687CA0", Offset = "0x686CA0", VA = "0x180687CA0")]
	private IEnumerator InputCode(List<int> code, float keyDelay = 0.15f)
	{
		return null;
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FC8")]
	[Address(RVA = "0x687DC0", Offset = "0x686DC0", VA = "0x180687DC0")]
	public ComputerLogin()
	{
	}

	// Token: 0x040012E8 RID: 4840
	[Token(Token = "0x40012E8")]
	[FieldOffset(Offset = "0x20")]
	public ComputerOSMultiSelect loginSelection;

	// Token: 0x040012E9 RID: 4841
	[Token(Token = "0x40012E9")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI inputText;

	// Token: 0x040012EA RID: 4842
	[Token(Token = "0x40012EA")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI instructionText;

	// Token: 0x040012EB RID: 4843
	[Token(Token = "0x40012EB")]
	[FieldOffset(Offset = "0x38")]
	public List<int> input;

	// Token: 0x040012EC RID: 4844
	[Token(Token = "0x40012EC")]
	[FieldOffset(Offset = "0x40")]
	public Color defaultTextColour;

	// Token: 0x040012ED RID: 4845
	[Token(Token = "0x40012ED")]
	[FieldOffset(Offset = "0x50")]
	public GameObject numPadParent;

	// Token: 0x040012EE RID: 4846
	[Token(Token = "0x40012EE")]
	[FieldOffset(Offset = "0x58")]
	public bool checking;

	// Token: 0x040012EF RID: 4847
	[Token(Token = "0x40012EF")]
	[FieldOffset(Offset = "0x59")]
	public bool correct;

	// Token: 0x040012F0 RID: 4848
	[Token(Token = "0x40012F0")]
	[FieldOffset(Offset = "0x5C")]
	public float checkCounter;

	// Token: 0x040012F1 RID: 4849
	[Token(Token = "0x40012F1")]
	[FieldOffset(Offset = "0x60")]
	public bool inputCodeActive;

	// Token: 0x020002C2 RID: 706
	[Token(Token = "0x20002C2")]
	private sealed class <InputCode>d__18 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06000FC9 RID: 4041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC9")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <InputCode>d__18(int <>1__state)
		{
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00008340 File Offset: 0x00006540
		[Token(Token = "0x6000FCB")]
		[Address(RVA = "0x687EC0", Offset = "0x686EC0", VA = "0x180687EC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007C")]
		private object Current
		{
			[Token(Token = "0x6000FCC")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCD")]
		[Address(RVA = "0x688040", Offset = "0x687040", VA = "0x180688040", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007D")]
		private object Current
		{
			[Token(Token = "0x6000FCE")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040012F2 RID: 4850
		[Token(Token = "0x40012F2")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040012F3 RID: 4851
		[Token(Token = "0x40012F3")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040012F4 RID: 4852
		[Token(Token = "0x40012F4")]
		[FieldOffset(Offset = "0x20")]
		public ComputerLogin <>4__this;

		// Token: 0x040012F5 RID: 4853
		[Token(Token = "0x40012F5")]
		[FieldOffset(Offset = "0x28")]
		public List<int> code;

		// Token: 0x040012F6 RID: 4854
		[Token(Token = "0x40012F6")]
		[FieldOffset(Offset = "0x30")]
		public float keyDelay;

		// Token: 0x040012F7 RID: 4855
		[Token(Token = "0x40012F7")]
		[FieldOffset(Offset = "0x34")]
		private int <codeCursor>5__2;
	}
}
