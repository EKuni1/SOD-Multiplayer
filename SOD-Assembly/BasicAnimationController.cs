using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000411 RID: 1041
[Token(Token = "0x2000411")]
public class BasicAnimationController : SwitchSyncBehaviour
{
	// Token: 0x0600178F RID: 6031 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600178F")]
	[Address(RVA = "0x897870", Offset = "0x896870", VA = "0x180897870")]
	private void Start()
	{
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001790")]
	[Address(RVA = "0x897880", Offset = "0x896880", VA = "0x180897880")]
	public void Setup()
	{
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001791")]
	[Address(RVA = "0x897CE0", Offset = "0x896CE0", VA = "0x180897CE0", Slot = "4")]
	public override void SetOn(bool val)
	{
	}

	// Token: 0x06001792 RID: 6034 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001792")]
	[Address(RVA = "0x897D50", Offset = "0x896D50", VA = "0x180897D50")]
	private void Update()
	{
	}

	// Token: 0x06001793 RID: 6035 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001793")]
	[Address(RVA = "0x898180", Offset = "0x897180", VA = "0x180898180")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06001794 RID: 6036 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001794")]
	[Address(RVA = "0x8985B0", Offset = "0x8975B0", VA = "0x1808985B0")]
	public BasicAnimationController()
	{
	}

	// Token: 0x04001CBA RID: 7354
	[Token(Token = "0x4001CBA")]
	[FieldOffset(Offset = "0x40")]
	public bool isSetup;

	// Token: 0x04001CBB RID: 7355
	[Token(Token = "0x4001CBB")]
	[FieldOffset(Offset = "0x48")]
	public InteractableController controller;

	// Token: 0x04001CBC RID: 7356
	[Token(Token = "0x4001CBC")]
	[FieldOffset(Offset = "0x50")]
	public DoorMovementPreset preset;

	// Token: 0x04001CBD RID: 7357
	[Token(Token = "0x4001CBD")]
	[FieldOffset(Offset = "0x58")]
	public bool oscillate;

	// Token: 0x04001CBE RID: 7358
	[Token(Token = "0x4001CBE")]
	[FieldOffset(Offset = "0x60")]
	public Transform animatedTransform;

	// Token: 0x04001CBF RID: 7359
	[Token(Token = "0x4001CBF")]
	[FieldOffset(Offset = "0x68")]
	public float normalizedSpeed;

	// Token: 0x04001CC0 RID: 7360
	[Token(Token = "0x4001CC0")]
	[FieldOffset(Offset = "0x6C")]
	public float progress;

	// Token: 0x04001CC1 RID: 7361
	[Token(Token = "0x4001CC1")]
	[FieldOffset(Offset = "0x70")]
	public bool inOut;

	// Token: 0x04001CC2 RID: 7362
	[Token(Token = "0x4001CC2")]
	[FieldOffset(Offset = "0x74")]
	public Vector3 closedLocalPos;

	// Token: 0x04001CC3 RID: 7363
	[Token(Token = "0x4001CC3")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 openLocalPos;

	// Token: 0x04001CC4 RID: 7364
	[Token(Token = "0x4001CC4")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 closedLocalEuler;

	// Token: 0x04001CC5 RID: 7365
	[Token(Token = "0x4001CC5")]
	[FieldOffset(Offset = "0x98")]
	public Vector3 openLocalEuler;

	// Token: 0x04001CC6 RID: 7366
	[Token(Token = "0x4001CC6")]
	[FieldOffset(Offset = "0xA4")]
	public Vector3 closedLocalScale;

	// Token: 0x04001CC7 RID: 7367
	[Token(Token = "0x4001CC7")]
	[FieldOffset(Offset = "0xB0")]
	public Vector3 openLocalScale;
}
