using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityStandardAssets.Utility;

namespace UnityStandardAssets.Characters.FirstPerson
{
	// Token: 0x020008E0 RID: 2272
	[Token(Token = "0x20008E0")]
	public class FirstPersonController : MonoBehaviour
	{
		// Token: 0x06002AEE RID: 10990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AEE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		private void Start()
		{
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AEF")]
		[Address(RVA = "0xCC5EA0", Offset = "0xCC4EA0", VA = "0x180CC5EA0")]
		public void InitialiseController(bool setOriginalCamPosition, bool initMouslook = true)
		{
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF0")]
		[Address(RVA = "0xCC6430", Offset = "0xCC5430", VA = "0x180CC6430")]
		private void Update()
		{
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF1")]
		[Address(RVA = "0xCC7420", Offset = "0xCC6420", VA = "0x180CC7420")]
		private void PlayLandingSound()
		{
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF2")]
		[Address(RVA = "0xCC74B0", Offset = "0xCC64B0", VA = "0x180CC74B0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x000100E0 File Offset: 0x0000E2E0
		[Token(Token = "0x6002AF3")]
		[Address(RVA = "0xCC7520", Offset = "0xCC6520", VA = "0x180CC7520")]
		public bool PlayerOutOfWorldCheck()
		{
			return default(bool);
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF4")]
		[Address(RVA = "0xCC8200", Offset = "0xCC7200", VA = "0x180CC8200")]
		public void UpdateMovement()
		{
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF5")]
		[Address(RVA = "0xCCA010", Offset = "0xCC9010", VA = "0x180CCA010")]
		public void JoltCamera(Vector3 direction, float amplitude, float speed)
		{
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF6")]
		[Address(RVA = "0xCCA120", Offset = "0xCC9120", VA = "0x180CCA120")]
		public void ProgressStepCycle(float speed, float deltaTime)
		{
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF7")]
		[Address(RVA = "0xCCAA50", Offset = "0xCC9A50", VA = "0x180CCAA50")]
		public void UpdateCameraPosition(float speed)
		{
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF8")]
		[Address(RVA = "0xCCAFF0", Offset = "0xCC9FF0", VA = "0x180CCAFF0")]
		public void UpdateCameraPositionRatController(float speed)
		{
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF9")]
		[Address(RVA = "0xCCB400", Offset = "0xCCA400", VA = "0x180CCB400")]
		private void GetInput(out float speed)
		{
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFA")]
		[Address(RVA = "0xCCC5C0", Offset = "0xCCB5C0", VA = "0x180CCC5C0")]
		private void RotateView()
		{
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFB")]
		[Address(RVA = "0xCCC780", Offset = "0xCCB780", VA = "0x180CCC780")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x000100F8 File Offset: 0x0000E2F8
		[Token(Token = "0x6002AFC")]
		[Address(RVA = "0xCCCA50", Offset = "0xCCBA50", VA = "0x180CCCA50")]
		public Vector3 DoHeadBob(CurveControlledBob bob, float speed, float multiplier)
		{
			return default(Vector3);
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFD")]
		[Address(RVA = "0xCCD000", Offset = "0xCCC000", VA = "0x180CCD000")]
		private void EvaluateGroundAsRat()
		{
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFE")]
		[Address(RVA = "0xCCD3D0", Offset = "0xCCC3D0", VA = "0x180CCD3D0")]
		private void EvaluateRatMouseMovement()
		{
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AFF")]
		[Address(RVA = "0xCCD7B0", Offset = "0xCCC7B0", VA = "0x180CCD7B0")]
		private void ApplyRatMovement()
		{
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B00")]
		[Address(RVA = "0xCCE460", Offset = "0xCCD460", VA = "0x180CCE460")]
		private void HandleRatJumping()
		{
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002B01")]
		[Address(RVA = "0xCCE700", Offset = "0xCCD700", VA = "0x180CCE700")]
		private IEnumerator RatJumpCooldown(float delay)
		{
			return null;
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x00010110 File Offset: 0x0000E310
		[Token(Token = "0x6002B02")]
		[Address(RVA = "0xCCE7B0", Offset = "0xCCD7B0", VA = "0x180CCE7B0")]
		private bool AreWeClimbingABuilding()
		{
			return default(bool);
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B03")]
		[Address(RVA = "0xCCED10", Offset = "0xCCDD10", VA = "0x180CCED10")]
		private void CheckWallCeilingCollision()
		{
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B04")]
		[Address(RVA = "0xCCF290", Offset = "0xCCE290", VA = "0x180CCF290")]
		public FirstPersonController()
		{
		}

		// Token: 0x04004B27 RID: 19239
		[Token(Token = "0x4004B27")]
		[FieldOffset(Offset = "0x18")]
		public bool enableMovement;

		// Token: 0x04004B28 RID: 19240
		[Token(Token = "0x4004B28")]
		[FieldOffset(Offset = "0x19")]
		public bool enableLook;

		// Token: 0x04004B29 RID: 19241
		[Token(Token = "0x4004B29")]
		[FieldOffset(Offset = "0x1A")]
		public bool isMoving;

		// Token: 0x04004B2A RID: 19242
		[Token(Token = "0x4004B2A")]
		[FieldOffset(Offset = "0x1B")]
		public bool movementChange;

		// Token: 0x04004B2B RID: 19243
		[Token(Token = "0x4004B2B")]
		[FieldOffset(Offset = "0x1C")]
		public bool enableHeadBob;

		// Token: 0x04004B2C RID: 19244
		[Token(Token = "0x4004B2C")]
		[FieldOffset(Offset = "0x1D")]
		public bool ghostMovement;

		// Token: 0x04004B2D RID: 19245
		[Token(Token = "0x4004B2D")]
		[FieldOffset(Offset = "0x1E")]
		public bool clipping;

		// Token: 0x04004B2E RID: 19246
		[Token(Token = "0x4004B2E")]
		[FieldOffset(Offset = "0x1F")]
		public bool syncTransforms;

		// Token: 0x04004B2F RID: 19247
		[Token(Token = "0x4004B2F")]
		[FieldOffset(Offset = "0x20")]
		public Player playerScript;

		// Token: 0x04004B30 RID: 19248
		[Token(Token = "0x4004B30")]
		[FieldOffset(Offset = "0x28")]
		public bool m_IsWalking;

		// Token: 0x04004B31 RID: 19249
		[Token(Token = "0x4004B31")]
		[FieldOffset(Offset = "0x29")]
		public bool m_RunToggle;

		// Token: 0x04004B32 RID: 19250
		[Token(Token = "0x4004B32")]
		[FieldOffset(Offset = "0x2C")]
		public float m_WalkSpeed;

		// Token: 0x04004B33 RID: 19251
		[Token(Token = "0x4004B33")]
		[FieldOffset(Offset = "0x30")]
		public float m_RunSpeed;

		// Token: 0x04004B34 RID: 19252
		[Token(Token = "0x4004B34")]
		[FieldOffset(Offset = "0x34")]
		public float speed;

		// Token: 0x04004B35 RID: 19253
		[Token(Token = "0x4004B35")]
		[FieldOffset(Offset = "0x38")]
		private float m_RunstepLenghten;

		// Token: 0x04004B36 RID: 19254
		[Token(Token = "0x4004B36")]
		[FieldOffset(Offset = "0x3C")]
		public float m_StickToGroundForce;

		// Token: 0x04004B37 RID: 19255
		[Token(Token = "0x4004B37")]
		[FieldOffset(Offset = "0x40")]
		public float m_GravityMultiplier;

		// Token: 0x04004B38 RID: 19256
		[Token(Token = "0x4004B38")]
		[FieldOffset(Offset = "0x48")]
		public MouseLook m_MouseLook;

		// Token: 0x04004B39 RID: 19257
		[Token(Token = "0x4004B39")]
		[FieldOffset(Offset = "0x50")]
		private bool m_UseFovKick;

		// Token: 0x04004B3A RID: 19258
		[Token(Token = "0x4004B3A")]
		[FieldOffset(Offset = "0x58")]
		private FOVKick m_FovKick;

		// Token: 0x04004B3B RID: 19259
		[Token(Token = "0x4004B3B")]
		[FieldOffset(Offset = "0x60")]
		public CurveControlledBob m_HeadBob;

		// Token: 0x04004B3C RID: 19260
		[Token(Token = "0x4004B3C")]
		[FieldOffset(Offset = "0x68")]
		public bool m_UseJumpBob;

		// Token: 0x04004B3D RID: 19261
		[Token(Token = "0x4004B3D")]
		[FieldOffset(Offset = "0x70")]
		public LerpControlledBob m_JumpBob;

		// Token: 0x04004B3E RID: 19262
		[Token(Token = "0x4004B3E")]
		[FieldOffset(Offset = "0x78")]
		public float m_StepInterval;

		// Token: 0x04004B3F RID: 19263
		[Token(Token = "0x4004B3F")]
		[FieldOffset(Offset = "0x7C")]
		private bool rightFootNext;

		// Token: 0x04004B40 RID: 19264
		[Token(Token = "0x4004B40")]
		[FieldOffset(Offset = "0x80")]
		private Transform leanPivot;

		// Token: 0x04004B41 RID: 19265
		[Token(Token = "0x4004B41")]
		[FieldOffset(Offset = "0x88")]
		private float leanSpeed;

		// Token: 0x04004B42 RID: 19266
		[Token(Token = "0x4004B42")]
		[FieldOffset(Offset = "0x8C")]
		private float maxLeanAngle;

		// Token: 0x04004B43 RID: 19267
		[Token(Token = "0x4004B43")]
		[FieldOffset(Offset = "0x90")]
		private float maxLeanMovement;

		// Token: 0x04004B44 RID: 19268
		[Token(Token = "0x4004B44")]
		[FieldOffset(Offset = "0x98")]
		public Camera m_Camera;

		// Token: 0x04004B45 RID: 19269
		[Token(Token = "0x4004B45")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_Jump;

		// Token: 0x04004B46 RID: 19270
		[Token(Token = "0x4004B46")]
		[FieldOffset(Offset = "0xA4")]
		private float m_YRotation;

		// Token: 0x04004B47 RID: 19271
		[Token(Token = "0x4004B47")]
		[FieldOffset(Offset = "0xA8")]
		public Vector2 m_Input;

		// Token: 0x04004B48 RID: 19272
		[Token(Token = "0x4004B48")]
		[FieldOffset(Offset = "0xB0")]
		public Vector3 m_MoveDir;

		// Token: 0x04004B49 RID: 19273
		[Token(Token = "0x4004B49")]
		[FieldOffset(Offset = "0xC0")]
		public CharacterController m_CharacterController;

		// Token: 0x04004B4A RID: 19274
		[Token(Token = "0x4004B4A")]
		[FieldOffset(Offset = "0xC8")]
		public CollisionFlags m_CollisionFlags;

		// Token: 0x04004B4B RID: 19275
		[Token(Token = "0x4004B4B")]
		[FieldOffset(Offset = "0xCC")]
		private bool m_PreviouslyGrounded;

		// Token: 0x04004B4C RID: 19276
		[Token(Token = "0x4004B4C")]
		[FieldOffset(Offset = "0xD0")]
		public Vector3 m_OriginalCameraPosition;

		// Token: 0x04004B4D RID: 19277
		[Token(Token = "0x4004B4D")]
		[FieldOffset(Offset = "0xDC")]
		public float m_StepCycle;

		// Token: 0x04004B4E RID: 19278
		[Token(Token = "0x4004B4E")]
		[FieldOffset(Offset = "0xE0")]
		public float m_NextStep;

		// Token: 0x04004B4F RID: 19279
		[Token(Token = "0x4004B4F")]
		[FieldOffset(Offset = "0xE4")]
		public bool m_Jumping;

		// Token: 0x04004B50 RID: 19280
		[Token(Token = "0x4004B50")]
		[FieldOffset(Offset = "0xE8")]
		public int leanState;

		// Token: 0x04004B51 RID: 19281
		[Token(Token = "0x4004B51")]
		[FieldOffset(Offset = "0xEC")]
		public float leanProgress;

		// Token: 0x04004B52 RID: 19282
		[Token(Token = "0x4004B52")]
		[FieldOffset(Offset = "0xF0")]
		public float currentLeanAngle;

		// Token: 0x04004B53 RID: 19283
		[Token(Token = "0x4004B53")]
		[FieldOffset(Offset = "0xF4")]
		public float currentLeanMovement;

		// Token: 0x04004B54 RID: 19284
		[Token(Token = "0x4004B54")]
		[FieldOffset(Offset = "0xF8")]
		public List<FirstPersonController.CameraJolt> activeJolts;

		// Token: 0x04004B55 RID: 19285
		[Token(Token = "0x4004B55")]
		[FieldOffset(Offset = "0x100")]
		public float lastY;

		// Token: 0x04004B56 RID: 19286
		[Token(Token = "0x4004B56")]
		[FieldOffset(Offset = "0x104")]
		public float fallCount;

		// Token: 0x04004B57 RID: 19287
		[Token(Token = "0x4004B57")]
		[FieldOffset(Offset = "0x108")]
		private Vector3 previousMovement;

		// Token: 0x04004B58 RID: 19288
		[Token(Token = "0x4004B58")]
		[FieldOffset(Offset = "0x114")]
		public Vector3 movementThisUpdate;

		// Token: 0x04004B59 RID: 19289
		[Token(Token = "0x4004B59")]
		[FieldOffset(Offset = "0x120")]
		private RaycastHit[] hitInfoArray;

		// Token: 0x04004B5A RID: 19290
		[Token(Token = "0x4004B5A")]
		[FieldOffset(Offset = "0x128")]
		public float slopeLimitForAddedJumpCooldown;

		// Token: 0x04004B5B RID: 19291
		[Token(Token = "0x4004B5B")]
		[FieldOffset(Offset = "0x12C")]
		public float maxGroundedDistance;

		// Token: 0x04004B5C RID: 19292
		[Token(Token = "0x4004B5C")]
		[FieldOffset(Offset = "0x130")]
		public float maxWallRunDistance;

		// Token: 0x04004B5D RID: 19293
		[Token(Token = "0x4004B5D")]
		[FieldOffset(Offset = "0x134")]
		public float _ratJumpHeight;

		// Token: 0x04004B5E RID: 19294
		[Token(Token = "0x4004B5E")]
		[FieldOffset(Offset = "0x138")]
		public float ratMoveSpeed;

		// Token: 0x04004B5F RID: 19295
		[Token(Token = "0x4004B5F")]
		[FieldOffset(Offset = "0x13C")]
		public float addedSprintValue;

		// Token: 0x04004B60 RID: 19296
		[Token(Token = "0x4004B60")]
		[FieldOffset(Offset = "0x140")]
		public float mouseSensitivity;

		// Token: 0x04004B61 RID: 19297
		[Token(Token = "0x4004B61")]
		[FieldOffset(Offset = "0x144")]
		public float wallJumpDelay;

		// Token: 0x04004B62 RID: 19298
		[Token(Token = "0x4004B62")]
		[FieldOffset(Offset = "0x148")]
		public float slopeGroundJumpDelay;

		// Token: 0x04004B63 RID: 19299
		[Token(Token = "0x4004B63")]
		[FieldOffset(Offset = "0x14C")]
		public float groundJumpDelay;

		// Token: 0x04004B64 RID: 19300
		[Token(Token = "0x4004B64")]
		[FieldOffset(Offset = "0x150")]
		public float minCamAngle;

		// Token: 0x04004B65 RID: 19301
		[Token(Token = "0x4004B65")]
		[FieldOffset(Offset = "0x154")]
		public float maxCamAngle;

		// Token: 0x04004B66 RID: 19302
		[Token(Token = "0x4004B66")]
		[FieldOffset(Offset = "0x158")]
		public LayerMask _ratGroundMask;

		// Token: 0x04004B67 RID: 19303
		[Token(Token = "0x4004B67")]
		[FieldOffset(Offset = "0x15C")]
		public LayerMask buildingMask;

		// Token: 0x04004B68 RID: 19304
		[Token(Token = "0x4004B68")]
		[FieldOffset(Offset = "0x160")]
		private Vector2 _ratMoveDir;

		// Token: 0x04004B69 RID: 19305
		[Token(Token = "0x4004B69")]
		[FieldOffset(Offset = "0x168")]
		private RaycastHit _groundHitInfo;

		// Token: 0x04004B6A RID: 19306
		[Token(Token = "0x4004B6A")]
		[FieldOffset(Offset = "0x194")]
		private RaycastHit _wallHitInfo;

		// Token: 0x04004B6B RID: 19307
		[Token(Token = "0x4004B6B")]
		[FieldOffset(Offset = "0x1C0")]
		private bool _isRatGrounded;

		// Token: 0x04004B6C RID: 19308
		[Token(Token = "0x4004B6C")]
		[FieldOffset(Offset = "0x1C1")]
		private bool _ratGroundedPossible;

		// Token: 0x04004B6D RID: 19309
		[Token(Token = "0x4004B6D")]
		[FieldOffset(Offset = "0x1C2")]
		private bool _isWallRunning;

		// Token: 0x04004B6E RID: 19310
		[Token(Token = "0x4004B6E")]
		[FieldOffset(Offset = "0x1C3")]
		private bool _ratJumpCooldownActive;

		// Token: 0x04004B6F RID: 19311
		[Token(Token = "0x4004B6F")]
		[FieldOffset(Offset = "0x1C4")]
		private Vector3 _ratVelocity;

		// Token: 0x04004B70 RID: 19312
		[Token(Token = "0x4004B70")]
		[FieldOffset(Offset = "0x1D0")]
		private Vector3 _groundHitPoint;

		// Token: 0x04004B71 RID: 19313
		[Token(Token = "0x4004B71")]
		[FieldOffset(Offset = "0x1DC")]
		private Vector3 _groundHitNormal;

		// Token: 0x04004B72 RID: 19314
		[Token(Token = "0x4004B72")]
		[FieldOffset(Offset = "0x1E8")]
		private Vector3 _groundForwardVector;

		// Token: 0x04004B73 RID: 19315
		[Token(Token = "0x4004B73")]
		[FieldOffset(Offset = "0x1F4")]
		private Vector3 _moveVector;

		// Token: 0x04004B74 RID: 19316
		[Token(Token = "0x4004B74")]
		[FieldOffset(Offset = "0x200")]
		private Vector3 _wallRunHitPoint;

		// Token: 0x04004B75 RID: 19317
		[Token(Token = "0x4004B75")]
		[FieldOffset(Offset = "0x20C")]
		private Vector3 _wallRunHitNormal;

		// Token: 0x04004B76 RID: 19318
		[Token(Token = "0x4004B76")]
		[FieldOffset(Offset = "0x218")]
		private Vector3 _wallRunHitForwardVector;

		// Token: 0x04004B77 RID: 19319
		[Token(Token = "0x4004B77")]
		[FieldOffset(Offset = "0x224")]
		private Vector3 _inputVector;

		// Token: 0x04004B78 RID: 19320
		[Token(Token = "0x4004B78")]
		[FieldOffset(Offset = "0x230")]
		private Vector2 _mouseInput;

		// Token: 0x04004B79 RID: 19321
		[Token(Token = "0x4004B79")]
		[FieldOffset(Offset = "0x238")]
		private float _currentSlopeAngle;

		// Token: 0x04004B7A RID: 19322
		[Token(Token = "0x4004B7A")]
		[FieldOffset(Offset = "0x23C")]
		private float _camRotX;

		// Token: 0x04004B7B RID: 19323
		[Token(Token = "0x4004B7B")]
		[FieldOffset(Offset = "0x240")]
		private float _camRotY;

		// Token: 0x020008E1 RID: 2273
		[Token(Token = "0x20008E1")]
		public class CameraJolt
		{
			// Token: 0x06002B05 RID: 11013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B05")]
			[Address(RVA = "0xCCF680", Offset = "0xCCE680", VA = "0x180CCF680")]
			public CameraJolt(Vector3 newDirection, float newSpeed)
			{
			}

			// Token: 0x04004B7C RID: 19324
			[Token(Token = "0x4004B7C")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 direction;

			// Token: 0x04004B7D RID: 19325
			[Token(Token = "0x4004B7D")]
			[FieldOffset(Offset = "0x1C")]
			public float progress;

			// Token: 0x04004B7E RID: 19326
			[Token(Token = "0x4004B7E")]
			[FieldOffset(Offset = "0x20")]
			public float speed;
		}

		// Token: 0x020008E2 RID: 2274
		[Token(Token = "0x20008E2")]
		private sealed class <RatJumpCooldown>d__105 : IEnumerator<object>, IDisposable, IEnumerator
		{
			// Token: 0x06002B06 RID: 11014 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B06")]
			[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
			public <RatJumpCooldown>d__105(int <>1__state)
			{
			}

			// Token: 0x06002B07 RID: 11015 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B07")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x06002B08 RID: 11016 RVA: 0x00010128 File Offset: 0x0000E328
			[Token(Token = "0x6002B08")]
			[Address(RVA = "0xCCF6A0", Offset = "0xCCE6A0", VA = "0x180CCF6A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x06002B09 RID: 11017 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700015E")]
			private object Current
			{
				[Token(Token = "0x6002B09")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002B0A RID: 11018 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002B0A")]
			[Address(RVA = "0xCCF7B0", Offset = "0xCCE7B0", VA = "0x180CCF7B0", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x06002B0B RID: 11019 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700015F")]
			private object Current
			{
				[Token(Token = "0x6002B0B")]
				[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x04004B7F RID: 19327
			[Token(Token = "0x4004B7F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04004B80 RID: 19328
			[Token(Token = "0x4004B80")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04004B81 RID: 19329
			[Token(Token = "0x4004B81")]
			[FieldOffset(Offset = "0x20")]
			public FirstPersonController <>4__this;

			// Token: 0x04004B82 RID: 19330
			[Token(Token = "0x4004B82")]
			[FieldOffset(Offset = "0x28")]
			public float delay;
		}
	}
}
