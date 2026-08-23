using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000305 RID: 773
[Token(Token = "0x2000305")]
public class DoorMovementController : MonoBehaviour
{
	// Token: 0x060010EC RID: 4332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010EC")]
	[Address(RVA = "0x6B3670", Offset = "0x6B2670", VA = "0x1806B3670")]
	private void Start()
	{
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010ED")]
	[Address(RVA = "0x6B3810", Offset = "0x6B2810", VA = "0x1806B3810")]
	public void Setup(Interactable newInteractable, bool inheritOpenStatusFromInteractable = true)
	{
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010EE")]
	[Address(RVA = "0x6B42F0", Offset = "0x6B32F0", VA = "0x1806B42F0", Slot = "4")]
	public virtual void SetOpen(float newAjar, Actor interactor, bool skipAnimation = false)
	{
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010EF")]
	[Address(RVA = "0x6B49A0", Offset = "0x6B39A0", VA = "0x1806B49A0")]
	public void SetCollisionsWithPlayerActive(bool val)
	{
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F0")]
	[Address(RVA = "0x6B4DD0", Offset = "0x6B3DD0", VA = "0x1806B4DD0")]
	private void OnEnable()
	{
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010F1")]
	[Address(RVA = "0x6B4E10", Offset = "0x6B3E10", VA = "0x1806B4E10")]
	private IEnumerator OpenDoor(Actor interactor)
	{
		return null;
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F2")]
	[Address(RVA = "0x6B4F20", Offset = "0x6B3F20", VA = "0x1806B4F20")]
	public void SetDoorPosition()
	{
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F3")]
	[Address(RVA = "0x6B5220", Offset = "0x6B4220", VA = "0x1806B5220")]
	public void OnClose(Actor interactor, bool playSound = true)
	{
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F4")]
	[Address(RVA = "0x6B5670", Offset = "0x6B4670", VA = "0x1806B5670")]
	public void OnOpen(Actor interactor, bool playSound = true)
	{
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F5")]
	[Address(RVA = "0x6B58D0", Offset = "0x6B48D0", VA = "0x1806B58D0")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F6")]
	[Address(RVA = "0x6B63C0", Offset = "0x6B53C0", VA = "0x1806B63C0")]
	public void OnCollisionExit(Collision collision)
	{
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010F7")]
	[Address(RVA = "0x6B6450", Offset = "0x6B5450", VA = "0x1806B6450")]
	public DoorMovementController()
	{
	}

	// Token: 0x040014A5 RID: 5285
	[Token(Token = "0x40014A5")]
	[FieldOffset(Offset = "0x18")]
	public Transform door;

	// Token: 0x040014A6 RID: 5286
	[Token(Token = "0x40014A6")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public Interactable interactable;

	// Token: 0x040014A7 RID: 5287
	[Token(Token = "0x40014A7")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<Collider, int> spawnedDoorColliders;

	// Token: 0x040014A8 RID: 5288
	[Token(Token = "0x40014A8")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 closedLocalPos;

	// Token: 0x040014A9 RID: 5289
	[Token(Token = "0x40014A9")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 openLocalPos;

	// Token: 0x040014AA RID: 5290
	[Token(Token = "0x40014AA")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 closedLocalEuler;

	// Token: 0x040014AB RID: 5291
	[Token(Token = "0x40014AB")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 openLocalEuler;

	// Token: 0x040014AC RID: 5292
	[Token(Token = "0x40014AC")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 closedLocalScale;

	// Token: 0x040014AD RID: 5293
	[Token(Token = "0x40014AD")]
	[FieldOffset(Offset = "0x6C")]
	public Vector3 openLocalScale;

	// Token: 0x040014AE RID: 5294
	[Token(Token = "0x40014AE")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 desiredPos;

	// Token: 0x040014AF RID: 5295
	[Token(Token = "0x40014AF")]
	[FieldOffset(Offset = "0x84")]
	public Vector3 desiredEuler;

	// Token: 0x040014B0 RID: 5296
	[Token(Token = "0x40014B0")]
	[FieldOffset(Offset = "0x90")]
	public Vector3 desiredScale;

	// Token: 0x040014B1 RID: 5297
	[Token(Token = "0x40014B1")]
	[FieldOffset(Offset = "0xA0")]
	public DoorMovementPreset preset;

	// Token: 0x040014B2 RID: 5298
	[Token(Token = "0x40014B2")]
	[FieldOffset(Offset = "0xA8")]
	public float desiredTransition;

	// Token: 0x040014B3 RID: 5299
	[Token(Token = "0x40014B3")]
	[FieldOffset(Offset = "0xAC")]
	public float currentTransition;

	// Token: 0x040014B4 RID: 5300
	[Token(Token = "0x40014B4")]
	[FieldOffset(Offset = "0xB0")]
	public bool isOpen;

	// Token: 0x040014B5 RID: 5301
	[Token(Token = "0x40014B5")]
	[FieldOffset(Offset = "0xB8")]
	public Actor interacting;

	// Token: 0x040014B6 RID: 5302
	[Token(Token = "0x40014B6")]
	[FieldOffset(Offset = "0xC0")]
	public bool isAnimating;

	// Token: 0x040014B7 RID: 5303
	[Token(Token = "0x40014B7")]
	[FieldOffset(Offset = "0xC1")]
	public bool isSetup;

	// Token: 0x040014B8 RID: 5304
	[Token(Token = "0x40014B8")]
	[FieldOffset(Offset = "0xC2")]
	public bool isOpening;

	// Token: 0x040014B9 RID: 5305
	[Token(Token = "0x40014B9")]
	[FieldOffset(Offset = "0xC3")]
	public bool isClosing;

	// Token: 0x040014BA RID: 5306
	[Token(Token = "0x40014BA")]
	[FieldOffset(Offset = "0xC4")]
	public bool updateLoopingParams;

	// Token: 0x040014BB RID: 5307
	[Token(Token = "0x40014BB")]
	[FieldOffset(Offset = "0xC5")]
	public bool removePlayerCollisionsWhileAnimating;

	// Token: 0x02000306 RID: 774
	[Token(Token = "0x2000306")]
	private sealed class <OpenDoor>d__28 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060010F8 RID: 4344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F8")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <OpenDoor>d__28(int <>1__state)
		{
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00008610 File Offset: 0x00006810
		[Token(Token = "0x60010FA")]
		[Address(RVA = "0x6B67B0", Offset = "0x6B57B0", VA = "0x1806B67B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700008E")]
		private object Current
		{
			[Token(Token = "0x60010FB")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010FC")]
		[Address(RVA = "0x6B7450", Offset = "0x6B6450", VA = "0x1806B7450", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700008F")]
		private object Current
		{
			[Token(Token = "0x60010FD")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x040014BC RID: 5308
		[Token(Token = "0x40014BC")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040014BD RID: 5309
		[Token(Token = "0x40014BD")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040014BE RID: 5310
		[Token(Token = "0x40014BE")]
		[FieldOffset(Offset = "0x20")]
		public DoorMovementController <>4__this;

		// Token: 0x040014BF RID: 5311
		[Token(Token = "0x40014BF")]
		[FieldOffset(Offset = "0x28")]
		public Actor interactor;
	}
}
