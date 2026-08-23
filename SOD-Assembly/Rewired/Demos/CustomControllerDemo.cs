using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	// Token: 0x02000972 RID: 2418
	[Token(Token = "0x2000972")]
	public class CustomControllerDemo : MonoBehaviour
	{
		// Token: 0x060033D5 RID: 13269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D5")]
		[Address(RVA = "0xD457F0", Offset = "0xD447F0", VA = "0x180D457F0")]
		private void Awake()
		{
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D6")]
		[Address(RVA = "0xD458A0", Offset = "0xD448A0", VA = "0x180D458A0")]
		private void Initialize()
		{
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D7")]
		[Address(RVA = "0xD461D0", Offset = "0xD451D0", VA = "0x180D461D0")]
		private void Update()
		{
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D8")]
		[Address(RVA = "0xD46280", Offset = "0xD45280", VA = "0x180D46280")]
		private void OnInputSourceUpdate()
		{
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D9")]
		[Address(RVA = "0xD463F0", Offset = "0xD453F0", VA = "0x180D463F0")]
		private void GetSourceAxisValues()
		{
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DA")]
		[Address(RVA = "0xD464B0", Offset = "0xD454B0", VA = "0x180D464B0")]
		private void GetSourceButtonValues()
		{
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DB")]
		[Address(RVA = "0xD46530", Offset = "0xD45530", VA = "0x180D46530")]
		private void SetControllerAxisValues()
		{
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DC")]
		[Address(RVA = "0xD46770", Offset = "0xD45770", VA = "0x180D46770")]
		private void SetControllerButtonValues()
		{
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x00012480 File Offset: 0x00010680
		[Token(Token = "0x60033DD")]
		[Address(RVA = "0xD469B0", Offset = "0xD459B0", VA = "0x180D469B0")]
		private float GetAxisValueCallback(int index)
		{
			return 0f;
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x00012498 File Offset: 0x00010698
		[Token(Token = "0x60033DE")]
		[Address(RVA = "0xD469F0", Offset = "0xD459F0", VA = "0x180D469F0")]
		private bool GetButtonValueCallback(int index)
		{
			return default(bool);
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DF")]
		[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
		public CustomControllerDemo()
		{
		}

		// Token: 0x04005066 RID: 20582
		[Token(Token = "0x4005066")]
		[FieldOffset(Offset = "0x18")]
		public int playerId;

		// Token: 0x04005067 RID: 20583
		[Token(Token = "0x4005067")]
		[FieldOffset(Offset = "0x20")]
		public string controllerTag;

		// Token: 0x04005068 RID: 20584
		[Token(Token = "0x4005068")]
		[FieldOffset(Offset = "0x28")]
		public bool useUpdateCallbacks;

		// Token: 0x04005069 RID: 20585
		[Token(Token = "0x4005069")]
		[FieldOffset(Offset = "0x2C")]
		private int buttonCount;

		// Token: 0x0400506A RID: 20586
		[Token(Token = "0x400506A")]
		[FieldOffset(Offset = "0x30")]
		private int axisCount;

		// Token: 0x0400506B RID: 20587
		[Token(Token = "0x400506B")]
		[FieldOffset(Offset = "0x38")]
		private float[] axisValues;

		// Token: 0x0400506C RID: 20588
		[Token(Token = "0x400506C")]
		[FieldOffset(Offset = "0x40")]
		private bool[] buttonValues;

		// Token: 0x0400506D RID: 20589
		[Token(Token = "0x400506D")]
		[FieldOffset(Offset = "0x48")]
		private TouchJoystickExample[] joysticks;

		// Token: 0x0400506E RID: 20590
		[Token(Token = "0x400506E")]
		[FieldOffset(Offset = "0x50")]
		private TouchButtonExample[] buttons;

		// Token: 0x0400506F RID: 20591
		[Token(Token = "0x400506F")]
		[FieldOffset(Offset = "0x58")]
		private CustomController controller;

		// Token: 0x04005070 RID: 20592
		[Token(Token = "0x4005070")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private bool initialized;
	}
}
