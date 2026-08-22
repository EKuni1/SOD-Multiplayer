using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
	// Token: 0x020008E5 RID: 2277
	[Token(Token = "0x20008E5")]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x00010170 File Offset: 0x0000E370
		[Token(Token = "0x17000160")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6002B15")]
			[Address(RVA = "0xCD2310", Offset = "0xCD1310", VA = "0x180CD2310")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06002B16 RID: 11030 RVA: 0x00010188 File Offset: 0x0000E388
		[Token(Token = "0x17000161")]
		public bool Grounded
		{
			[Token(Token = "0x6002B16")]
			[Address(RVA = "0xCD23A0", Offset = "0xCD13A0", VA = "0x180CD23A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06002B17 RID: 11031 RVA: 0x000101A0 File Offset: 0x0000E3A0
		[Token(Token = "0x17000162")]
		public bool Jumping
		{
			[Token(Token = "0x6002B17")]
			[Address(RVA = "0xCD23B0", Offset = "0xCD13B0", VA = "0x180CD23B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06002B18 RID: 11032 RVA: 0x000101B8 File Offset: 0x0000E3B8
		[Token(Token = "0x17000163")]
		public bool Running
		{
			[Token(Token = "0x6002B18")]
			[Address(RVA = "0xCD23C0", Offset = "0xCD13C0", VA = "0x180CD23C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B19")]
		[Address(RVA = "0xCD23E0", Offset = "0xCD13E0", VA = "0x180CD23E0")]
		private void Start()
		{
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1A")]
		[Address(RVA = "0xCD25B0", Offset = "0xCD15B0", VA = "0x180CD25B0")]
		private void Update()
		{
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1B")]
		[Address(RVA = "0xCD2630", Offset = "0xCD1630", VA = "0x180CD2630")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x000101D0 File Offset: 0x0000E3D0
		[Token(Token = "0x6002B1C")]
		[Address(RVA = "0xCD2EC0", Offset = "0xCD1EC0", VA = "0x180CD2EC0")]
		private float SlopeMultiplier()
		{
			return 0f;
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1D")]
		[Address(RVA = "0xCD2FB0", Offset = "0xCD1FB0", VA = "0x180CD2FB0")]
		private void StickToGroundHelper()
		{
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x000101E8 File Offset: 0x0000E3E8
		[Token(Token = "0x6002B1E")]
		[Address(RVA = "0xCD3480", Offset = "0xCD2480", VA = "0x180CD3480")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1F")]
		[Address(RVA = "0xCD36A0", Offset = "0xCD26A0", VA = "0x180CD36A0")]
		private void RotateView()
		{
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B20")]
		[Address(RVA = "0xCD3AE0", Offset = "0xCD2AE0", VA = "0x180CD3AE0")]
		private void GroundCheck()
		{
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B21")]
		[Address(RVA = "0xCD3EE0", Offset = "0xCD2EE0", VA = "0x180CD3EE0")]
		public RigidbodyFirstPersonController()
		{
		}

		// Token: 0x04004B97 RID: 19351
		[Token(Token = "0x4004B97")]
		[FieldOffset(Offset = "0x18")]
		public Camera cam;

		// Token: 0x04004B98 RID: 19352
		[Token(Token = "0x4004B98")]
		[FieldOffset(Offset = "0x20")]
		public RigidbodyFirstPersonController.MovementSettings movementSettings;

		// Token: 0x04004B99 RID: 19353
		[Token(Token = "0x4004B99")]
		[FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		// Token: 0x04004B9A RID: 19354
		[Token(Token = "0x4004B9A")]
		[FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController.AdvancedSettings advancedSettings;

		// Token: 0x04004B9B RID: 19355
		[Token(Token = "0x4004B9B")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		// Token: 0x04004B9C RID: 19356
		[Token(Token = "0x4004B9C")]
		[FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		// Token: 0x04004B9D RID: 19357
		[Token(Token = "0x4004B9D")]
		[FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		// Token: 0x04004B9E RID: 19358
		[Token(Token = "0x4004B9E")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		// Token: 0x04004B9F RID: 19359
		[Token(Token = "0x4004B9F")]
		[FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		// Token: 0x04004BA0 RID: 19360
		[Token(Token = "0x4004BA0")]
		[FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		// Token: 0x04004BA1 RID: 19361
		[Token(Token = "0x4004BA1")]
		[FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		// Token: 0x04004BA2 RID: 19362
		[Token(Token = "0x4004BA2")]
		[FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		// Token: 0x020008E6 RID: 2278
		[Token(Token = "0x20008E6")]
		[Serializable]
		public class MovementSettings
		{
			// Token: 0x06002B22 RID: 11042 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B22")]
			[Address(RVA = "0xCD40F0", Offset = "0xCD30F0", VA = "0x180CD40F0")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x06002B23 RID: 11043 RVA: 0x00010200 File Offset: 0x0000E400
			[Token(Token = "0x17000164")]
			public bool Running
			{
				[Token(Token = "0x6002B23")]
				[Address(RVA = "0xCD4210", Offset = "0xCD3210", VA = "0x180CD4210")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06002B24 RID: 11044 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B24")]
			[Address(RVA = "0xCD4220", Offset = "0xCD3220", VA = "0x180CD4220")]
			public MovementSettings()
			{
			}

			// Token: 0x04004BA3 RID: 19363
			[Token(Token = "0x4004BA3")]
			[FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			// Token: 0x04004BA4 RID: 19364
			[Token(Token = "0x4004BA4")]
			[FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			// Token: 0x04004BA5 RID: 19365
			[Token(Token = "0x4004BA5")]
			[FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			// Token: 0x04004BA6 RID: 19366
			[Token(Token = "0x4004BA6")]
			[FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			// Token: 0x04004BA7 RID: 19367
			[Token(Token = "0x4004BA7")]
			[FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			// Token: 0x04004BA8 RID: 19368
			[Token(Token = "0x4004BA8")]
			[FieldOffset(Offset = "0x24")]
			public float JumpForce;

			// Token: 0x04004BA9 RID: 19369
			[Token(Token = "0x4004BA9")]
			[FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			// Token: 0x04004BAA RID: 19370
			[Token(Token = "0x4004BAA")]
			[FieldOffset(Offset = "0x30")]
			public float CurrentTargetSpeed;

			// Token: 0x04004BAB RID: 19371
			[Token(Token = "0x4004BAB")]
			[FieldOffset(Offset = "0x34")]
			private bool m_Running;
		}

		// Token: 0x020008E7 RID: 2279
		[Token(Token = "0x20008E7")]
		[Serializable]
		public class AdvancedSettings
		{
			// Token: 0x06002B25 RID: 11045 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B25")]
			[Address(RVA = "0xCD4400", Offset = "0xCD3400", VA = "0x180CD4400")]
			public AdvancedSettings()
			{
			}

			// Token: 0x04004BAC RID: 19372
			[Token(Token = "0x4004BAC")]
			[FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			// Token: 0x04004BAD RID: 19373
			[Token(Token = "0x4004BAD")]
			[FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			// Token: 0x04004BAE RID: 19374
			[Token(Token = "0x4004BAE")]
			[FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			// Token: 0x04004BAF RID: 19375
			[Token(Token = "0x4004BAF")]
			[FieldOffset(Offset = "0x1C")]
			public bool airControl;

			// Token: 0x04004BB0 RID: 19376
			[Token(Token = "0x4004BB0")]
			[FieldOffset(Offset = "0x20")]
			public float shellOffset;
		}
	}
}
