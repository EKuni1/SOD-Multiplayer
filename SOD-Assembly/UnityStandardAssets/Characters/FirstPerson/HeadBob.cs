using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Characters.FirstPerson
{
	// Token: 0x020008E3 RID: 2275
	[Token(Token = "0x20008E3")]
	public class HeadBob : MonoBehaviour
	{
		// Token: 0x06002B0C RID: 11020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B0C")]
		[Address(RVA = "0xCCF800", Offset = "0xCCE800", VA = "0x180CCF800")]
		private void Start()
		{
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B0D")]
		[Address(RVA = "0xCCFA00", Offset = "0xCCEA00", VA = "0x180CCFA00")]
		private void Update()
		{
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B0E")]
		[Address(RVA = "0xCD0080", Offset = "0xCCF080", VA = "0x180CD0080")]
		public HeadBob()
		{
		}

		// Token: 0x04004B83 RID: 19331
		[Token(Token = "0x4004B83")]
		[FieldOffset(Offset = "0x18")]
		public Camera Camera;

		// Token: 0x04004B84 RID: 19332
		[Token(Token = "0x4004B84")]
		[FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		// Token: 0x04004B85 RID: 19333
		[Token(Token = "0x4004B85")]
		[FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		// Token: 0x04004B86 RID: 19334
		[Token(Token = "0x4004B86")]
		[FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		// Token: 0x04004B87 RID: 19335
		[Token(Token = "0x4004B87")]
		[FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		// Token: 0x04004B88 RID: 19336
		[Token(Token = "0x4004B88")]
		[FieldOffset(Offset = "0x3C")]
		public float RunningStrideLengthen;

		// Token: 0x04004B89 RID: 19337
		[Token(Token = "0x4004B89")]
		[FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		// Token: 0x04004B8A RID: 19338
		[Token(Token = "0x4004B8A")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;
	}
}
