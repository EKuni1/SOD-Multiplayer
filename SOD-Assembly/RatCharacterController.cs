using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200073B RID: 1851
[Token(Token = "0x200073B")]
public class RatCharacterController : MonoBehaviour
{
	// Token: 0x060028B5 RID: 10421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028B5")]
	[Address(RVA = "0xC509D0", Offset = "0xC4F9D0", VA = "0x180C509D0")]
	private void Awake()
	{
	}

	// Token: 0x060028B6 RID: 10422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028B6")]
	[Address(RVA = "0xC50A70", Offset = "0xC4FA70", VA = "0x180C50A70")]
	private void Update()
	{
	}

	// Token: 0x060028B7 RID: 10423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028B7")]
	[Address(RVA = "0xC50AB0", Offset = "0xC4FAB0", VA = "0x180C50AB0")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x060028B8 RID: 10424 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028B8")]
	[Address(RVA = "0xC511F0", Offset = "0xC501F0", VA = "0x180C511F0")]
	private void CheckWallCeilingCollision()
	{
	}

	// Token: 0x060028B9 RID: 10425 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028B9")]
	[Address(RVA = "0xC51800", Offset = "0xC50800", VA = "0x180C51800")]
	private void EvaluateGround()
	{
	}

	// Token: 0x060028BA RID: 10426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028BA")]
	[Address(RVA = "0xC51BC0", Offset = "0xC50BC0", VA = "0x180C51BC0")]
	private void EvaluateMouseMovement()
	{
	}

	// Token: 0x060028BB RID: 10427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028BB")]
	[Address(RVA = "0xC51F90", Offset = "0xC50F90", VA = "0x180C51F90")]
	private void ApplyMovement()
	{
	}

	// Token: 0x060028BC RID: 10428 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028BC")]
	[Address(RVA = "0xC528E0", Offset = "0xC518E0", VA = "0x180C528E0")]
	private void HandleJumping()
	{
	}

	// Token: 0x060028BD RID: 10429 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60028BD")]
	[Address(RVA = "0xC52B30", Offset = "0xC51B30", VA = "0x180C52B30")]
	private IEnumerator JumpCooldown(float delay)
	{
		return null;
	}

	// Token: 0x060028BE RID: 10430 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028BE")]
	[Address(RVA = "0xC52BE0", Offset = "0xC51BE0", VA = "0x180C52BE0")]
	public RatCharacterController()
	{
	}

	// Token: 0x040033A1 RID: 13217
	[Token(Token = "0x40033A1")]
	[FieldOffset(Offset = "0x18")]
	public CharacterController charController;

	// Token: 0x040033A2 RID: 13218
	[Token(Token = "0x40033A2")]
	[FieldOffset(Offset = "0x20")]
	public float slopeLimitForAddedJumpCooldown;

	// Token: 0x040033A3 RID: 13219
	[Token(Token = "0x40033A3")]
	[FieldOffset(Offset = "0x24")]
	public float maxGroundedDistance;

	// Token: 0x040033A4 RID: 13220
	[Token(Token = "0x40033A4")]
	[FieldOffset(Offset = "0x28")]
	public float maxWallRunDistance;

	// Token: 0x040033A5 RID: 13221
	[Token(Token = "0x40033A5")]
	[FieldOffset(Offset = "0x2C")]
	public float _ratJumpHeight;

	// Token: 0x040033A6 RID: 13222
	[Token(Token = "0x40033A6")]
	[FieldOffset(Offset = "0x30")]
	public float ratMoveSpeed;

	// Token: 0x040033A7 RID: 13223
	[Token(Token = "0x40033A7")]
	[FieldOffset(Offset = "0x34")]
	public float mouseSensitivity;

	// Token: 0x040033A8 RID: 13224
	[Token(Token = "0x40033A8")]
	[FieldOffset(Offset = "0x38")]
	public float wallJumpDelay;

	// Token: 0x040033A9 RID: 13225
	[Token(Token = "0x40033A9")]
	[FieldOffset(Offset = "0x3C")]
	public float slopeGroundJumpDelay;

	// Token: 0x040033AA RID: 13226
	[Token(Token = "0x40033AA")]
	[FieldOffset(Offset = "0x40")]
	public float groundJumpDelay;

	// Token: 0x040033AB RID: 13227
	[Token(Token = "0x40033AB")]
	[FieldOffset(Offset = "0x44")]
	public float minCamAngle;

	// Token: 0x040033AC RID: 13228
	[Token(Token = "0x40033AC")]
	[FieldOffset(Offset = "0x48")]
	public float maxCamAngle;

	// Token: 0x040033AD RID: 13229
	[Token(Token = "0x40033AD")]
	[FieldOffset(Offset = "0x4C")]
	public LayerMask _ratGroundMask;

	// Token: 0x040033AE RID: 13230
	[Token(Token = "0x40033AE")]
	[FieldOffset(Offset = "0x50")]
	private Vector2 _ratMoveDir;

	// Token: 0x040033AF RID: 13231
	[Token(Token = "0x40033AF")]
	[FieldOffset(Offset = "0x58")]
	private RaycastHit _groundHitInfo;

	// Token: 0x040033B0 RID: 13232
	[Token(Token = "0x40033B0")]
	[FieldOffset(Offset = "0x84")]
	private RaycastHit _wallHitInfo;

	// Token: 0x040033B1 RID: 13233
	[Token(Token = "0x40033B1")]
	[FieldOffset(Offset = "0xB0")]
	private bool _isRatGrounded;

	// Token: 0x040033B2 RID: 13234
	[Token(Token = "0x40033B2")]
	[FieldOffset(Offset = "0xB1")]
	private bool _ratGroundedPossible;

	// Token: 0x040033B3 RID: 13235
	[Token(Token = "0x40033B3")]
	[FieldOffset(Offset = "0xB2")]
	private bool _isWallRunning;

	// Token: 0x040033B4 RID: 13236
	[Token(Token = "0x40033B4")]
	[FieldOffset(Offset = "0xB3")]
	private bool _ratJumpCooldownActive;

	// Token: 0x040033B5 RID: 13237
	[Token(Token = "0x40033B5")]
	[FieldOffset(Offset = "0xB4")]
	private Vector3 _ratVelocity;

	// Token: 0x040033B6 RID: 13238
	[Token(Token = "0x40033B6")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 _groundHitPoint;

	// Token: 0x040033B7 RID: 13239
	[Token(Token = "0x40033B7")]
	[FieldOffset(Offset = "0xCC")]
	private Vector3 _groundHitNormal;

	// Token: 0x040033B8 RID: 13240
	[Token(Token = "0x40033B8")]
	[FieldOffset(Offset = "0xD8")]
	private Vector3 _groundForwardVector;

	// Token: 0x040033B9 RID: 13241
	[Token(Token = "0x40033B9")]
	[FieldOffset(Offset = "0xE4")]
	private Vector3 _moveVector;

	// Token: 0x040033BA RID: 13242
	[Token(Token = "0x40033BA")]
	[FieldOffset(Offset = "0xF0")]
	private Vector3 _wallRunHitPoint;

	// Token: 0x040033BB RID: 13243
	[Token(Token = "0x40033BB")]
	[FieldOffset(Offset = "0xFC")]
	private Vector3 _wallRunHitNormal;

	// Token: 0x040033BC RID: 13244
	[Token(Token = "0x40033BC")]
	[FieldOffset(Offset = "0x108")]
	private Vector3 _wallRunHitForwardVector;

	// Token: 0x040033BD RID: 13245
	[Token(Token = "0x40033BD")]
	[FieldOffset(Offset = "0x114")]
	private Vector3 _inputVector;

	// Token: 0x040033BE RID: 13246
	[Token(Token = "0x40033BE")]
	[FieldOffset(Offset = "0x120")]
	private Vector2 _mouseInput;

	// Token: 0x040033BF RID: 13247
	[Token(Token = "0x40033BF")]
	[FieldOffset(Offset = "0x128")]
	private float _currentSlopeAngle;

	// Token: 0x040033C0 RID: 13248
	[Token(Token = "0x40033C0")]
	[FieldOffset(Offset = "0x12C")]
	private float _camRotX;

	// Token: 0x040033C1 RID: 13249
	[Token(Token = "0x40033C1")]
	[FieldOffset(Offset = "0x130")]
	private float _camRotY;

	// Token: 0x040033C2 RID: 13250
	[Token(Token = "0x40033C2")]
	[FieldOffset(Offset = "0x138")]
	private Camera _camera;

	// Token: 0x0200073C RID: 1852
	[Token(Token = "0x200073C")]
	private sealed class <JumpCooldown>d__42 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060028BF RID: 10431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028BF")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <JumpCooldown>d__42(int <>1__state)
		{
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
		[Token(Token = "0x60028C1")]
		[Address(RVA = "0xC52C70", Offset = "0xC51C70", VA = "0x180C52C70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060028C2 RID: 10434 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000149")]
		private object Current
		{
			[Token(Token = "0x60028C2")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028C3")]
		[Address(RVA = "0xC52D80", Offset = "0xC51D80", VA = "0x180C52D80", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700014A")]
		private object Current
		{
			[Token(Token = "0x60028C4")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040033C3 RID: 13251
		[Token(Token = "0x40033C3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040033C4 RID: 13252
		[Token(Token = "0x40033C4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040033C5 RID: 13253
		[Token(Token = "0x40033C5")]
		[FieldOffset(Offset = "0x20")]
		public RatCharacterController <>4__this;

		// Token: 0x040033C6 RID: 13254
		[Token(Token = "0x40033C6")]
		[FieldOffset(Offset = "0x28")]
		public float delay;
	}
}
