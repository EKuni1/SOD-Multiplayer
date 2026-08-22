using System;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200030F RID: 783
[Token(Token = "0x200030F")]
public class RigidbodyDragObject : MonoBehaviour
{
	// Token: 0x0600111B RID: 4379 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600111B")]
	[Address(RVA = "0x6BC650", Offset = "0x6BB650", VA = "0x1806BC650")]
	public void OnEnterRagdollState(NewAIController newAI)
	{
	}

	// Token: 0x0600111C RID: 4380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600111C")]
	[Address(RVA = "0x6BC970", Offset = "0x6BB970", VA = "0x1806BC970")]
	public void OnExitRagdollState()
	{
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600111D")]
	[Address(RVA = "0x6BCA50", Offset = "0x6BBA50", VA = "0x1806BCA50")]
	public void OnAttemptPlayerInteraction()
	{
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600111E")]
	[Address(RVA = "0x6BD7C0", Offset = "0x6BC7C0", VA = "0x1806BD7C0")]
	public void CancelDrag()
	{
	}

	// Token: 0x0600111F RID: 4383 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600111F")]
	[Address(RVA = "0x6BDE90", Offset = "0x6BCE90", VA = "0x1806BDE90")]
	private void Update()
	{
	}

	// Token: 0x06001120 RID: 4384 RVA: 0x00008670 File Offset: 0x00006870
	[Token(Token = "0x6001120")]
	[Address(RVA = "0x6BE330", Offset = "0x6BD330", VA = "0x1806BE330")]
	public bool IsValidRagdollDragable()
	{
		return default(bool);
	}

	// Token: 0x06001121 RID: 4385 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001121")]
	[Address(RVA = "0x6BE690", Offset = "0x6BD690", VA = "0x1806BE690")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001122")]
	[Address(RVA = "0x6BE960", Offset = "0x6BD960", VA = "0x1806BE960")]
	private void UpdateMousePositionOffset()
	{
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x00008688 File Offset: 0x00006888
	[Token(Token = "0x6001123")]
	[Address(RVA = "0x6BEAF0", Offset = "0x6BDAF0", VA = "0x1806BEAF0")]
	private bool GetRigidbodyFromCamera(out Rigidbody targetedRigidbody, out float dragDistance, out Vector3 screenTargetPos, out Vector3 rigidBodyPos)
	{
		return default(bool);
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001124")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public RigidbodyDragObject()
	{
	}

	// Token: 0x040014ED RID: 5357
	[Token(Token = "0x40014ED")]
	[FieldOffset(Offset = "0x18")]
	public NewAIController ai;

	// Token: 0x040014EE RID: 5358
	[Token(Token = "0x40014EE")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody targetRigidbody;

	// Token: 0x040014EF RID: 5359
	[Token(Token = "0x40014EF")]
	[FieldOffset(Offset = "0x28")]
	private Camera _cam;

	// Token: 0x040014F0 RID: 5360
	[Token(Token = "0x40014F0")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 _screenTargetPos;

	// Token: 0x040014F1 RID: 5361
	[Token(Token = "0x40014F1")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 _rigidbodyPos;

	// Token: 0x040014F2 RID: 5362
	[Token(Token = "0x40014F2")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 mousePositionOffset;

	// Token: 0x040014F3 RID: 5363
	[Token(Token = "0x40014F3")]
	[FieldOffset(Offset = "0x54")]
	private float _dragDistance;

	// Token: 0x040014F4 RID: 5364
	[Token(Token = "0x40014F4")]
	[FieldOffset(Offset = "0x58")]
	public LayerMask mask;

	// Token: 0x040014F5 RID: 5365
	[Token(Token = "0x40014F5")]
	[FieldOffset(Offset = "0x5C")]
	public float draggableDistance;

	// Token: 0x040014F6 RID: 5366
	[Token(Token = "0x40014F6")]
	[FieldOffset(Offset = "0x60")]
	public bool dragIsActive;

	// Token: 0x040014F7 RID: 5367
	[Token(Token = "0x40014F7")]
	[FieldOffset(Offset = "0x68")]
	private EventInstance _dragAudioInstance;

	// Token: 0x040014F8 RID: 5368
	[Token(Token = "0x40014F8")]
	[FieldOffset(Offset = "0x70")]
	private AudioController.LoopingSoundInfo _dragBodyLoop;
}
