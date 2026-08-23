using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
	// Token: 0x020008E4 RID: 2276
	[Token(Token = "0x20008E4")]
	[Serializable]
	public class MouseLook
	{
		// Token: 0x06002B0F RID: 11023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B0F")]
		[Address(RVA = "0xCD01E0", Offset = "0xCCF1E0", VA = "0x180CD01E0")]
		public void Init(Transform character, Transform camera)
		{
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B10")]
		[Address(RVA = "0xCD02D0", Offset = "0xCCF2D0", VA = "0x180CD02D0")]
		public void LookRotation(Transform character, Transform camera, bool disableClamp = false)
		{
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B11")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public void UpdateCursorLock()
		{
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x00010140 File Offset: 0x0000E340
		[Token(Token = "0x6002B12")]
		[Address(RVA = "0xCD2170", Offset = "0xCD1170", VA = "0x180CD2170")]
		public Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x00010158 File Offset: 0x0000E358
		[Token(Token = "0x6002B13")]
		[Address(RVA = "0xCD2230", Offset = "0xCD1230", VA = "0x180CD2230")]
		public Quaternion ClampRotationAroundYAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B14")]
		[Address(RVA = "0xCD22F0", Offset = "0xCD12F0", VA = "0x180CD22F0")]
		public MouseLook()
		{
		}

		// Token: 0x04004B8B RID: 19339
		[Token(Token = "0x4004B8B")]
		[FieldOffset(Offset = "0x10")]
		public bool clampVerticalRotation;

		// Token: 0x04004B8C RID: 19340
		[Token(Token = "0x4004B8C")]
		[FieldOffset(Offset = "0x14")]
		public float MinimumX;

		// Token: 0x04004B8D RID: 19341
		[Token(Token = "0x4004B8D")]
		[FieldOffset(Offset = "0x18")]
		public float MaximumX;

		// Token: 0x04004B8E RID: 19342
		[Token(Token = "0x4004B8E")]
		[FieldOffset(Offset = "0x1C")]
		public bool lockCursor;

		// Token: 0x04004B8F RID: 19343
		[Token(Token = "0x4004B8F")]
		[FieldOffset(Offset = "0x20")]
		public Quaternion charMovementThisFrame;

		// Token: 0x04004B90 RID: 19344
		[Token(Token = "0x4004B90")]
		[FieldOffset(Offset = "0x30")]
		public Quaternion camMovementThisFrame;

		// Token: 0x04004B91 RID: 19345
		[Token(Token = "0x4004B91")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion m_CharacterTargetRot;

		// Token: 0x04004B92 RID: 19346
		[Token(Token = "0x4004B92")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion m_CameraTargetRot;

		// Token: 0x04004B93 RID: 19347
		[Token(Token = "0x4004B93")]
		[FieldOffset(Offset = "0x60")]
		private float _controllerInputX;

		// Token: 0x04004B94 RID: 19348
		[Token(Token = "0x4004B94")]
		[FieldOffset(Offset = "0x64")]
		private float _controllerInputY;

		// Token: 0x04004B95 RID: 19349
		[Token(Token = "0x4004B95")]
		[FieldOffset(Offset = "0x68")]
		private float _controllerXRot;

		// Token: 0x04004B96 RID: 19350
		[Token(Token = "0x4004B96")]
		[FieldOffset(Offset = "0x6C")]
		private bool _invertY;
	}
}
