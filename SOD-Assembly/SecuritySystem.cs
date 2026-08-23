using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200049C RID: 1180
[Token(Token = "0x200049C")]
public class SecuritySystem : Machine
{
	// Token: 0x06001ABB RID: 6843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ABB")]
	[Address(RVA = "0x991CF0", Offset = "0x990CF0", VA = "0x180991CF0")]
	public void Setup(Interactable newInteractable, bool inheritOpenStatusFromInteractable = true)
	{
	}

	// Token: 0x06001ABC RID: 6844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ABC")]
	[Address(RVA = "0x991F50", Offset = "0x990F50", VA = "0x180991F50", Slot = "5")]
	public override void CreateEvidence()
	{
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ABD")]
	[Address(RVA = "0x992100", Offset = "0x991100", VA = "0x180992100")]
	public void SetActive(bool open, bool skipAnimation = false)
	{
	}

	// Token: 0x06001ABE RID: 6846 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ABE")]
	[Address(RVA = "0x9927D0", Offset = "0x9917D0", VA = "0x1809927D0")]
	private void UpdateMaterial()
	{
	}

	// Token: 0x06001ABF RID: 6847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ABF")]
	[Address(RVA = "0x993120", Offset = "0x992120", VA = "0x180993120", Slot = "47")]
	public override void OnInvestigate(Actor newTarget, int escalation)
	{
	}

	// Token: 0x06001AC0 RID: 6848 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC0")]
	[Address(RVA = "0x993510", Offset = "0x992510", VA = "0x180993510")]
	private void Update()
	{
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC1")]
	[Address(RVA = "0x995B20", Offset = "0x994B20", VA = "0x180995B20")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001AC2 RID: 6850 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC2")]
	[Address(RVA = "0x995B20", Offset = "0x994B20", VA = "0x180995B20")]
	private void OnDisable()
	{
	}

	// Token: 0x06001AC3 RID: 6851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC3")]
	[Address(RVA = "0x995B30", Offset = "0x994B30", VA = "0x180995B30")]
	private void OnEnable()
	{
	}

	// Token: 0x06001AC4 RID: 6852 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC4")]
	[Address(RVA = "0x995BE0", Offset = "0x994BE0", VA = "0x180995BE0")]
	public void ResetFocus()
	{
	}

	// Token: 0x06001AC5 RID: 6853 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AC5")]
	[Address(RVA = "0x995CB0", Offset = "0x994CB0", VA = "0x180995CB0")]
	public SecuritySystem()
	{
	}

	// Token: 0x04002071 RID: 8305
	[Token(Token = "0x4002071")]
	[FieldOffset(Offset = "0x258")]
	public SecuritySystem.SecuritySystemType system;

	// Token: 0x04002072 RID: 8306
	[Token(Token = "0x4002072")]
	[FieldOffset(Offset = "0x260")]
	public Animator anim;

	// Token: 0x04002073 RID: 8307
	[Token(Token = "0x4002073")]
	[FieldOffset(Offset = "0x268")]
	public GameObject laser;

	// Token: 0x04002074 RID: 8308
	[Token(Token = "0x4002074")]
	[FieldOffset(Offset = "0x270")]
	public Light laserLight;

	// Token: 0x04002075 RID: 8309
	[Token(Token = "0x4002075")]
	[FieldOffset(Offset = "0x278")]
	public bool isActive;

	// Token: 0x04002076 RID: 8310
	[Token(Token = "0x4002076")]
	[FieldOffset(Offset = "0x279")]
	public bool isAnimating;

	// Token: 0x04002077 RID: 8311
	[Token(Token = "0x4002077")]
	[FieldOffset(Offset = "0x280")]
	public Actor trackingTarget;

	// Token: 0x04002078 RID: 8312
	[Token(Token = "0x4002078")]
	[FieldOffset(Offset = "0x288")]
	public bool acquiredTarget;

	// Token: 0x04002079 RID: 8313
	[Token(Token = "0x4002079")]
	[FieldOffset(Offset = "0x290")]
	public MeshRenderer rend;

	// Token: 0x0400207A RID: 8314
	[Token(Token = "0x400207A")]
	[FieldOffset(Offset = "0x298")]
	public Transform rotationPivotTransform;

	// Token: 0x0400207B RID: 8315
	[Token(Token = "0x400207B")]
	[FieldOffset(Offset = "0x2A0")]
	public Quaternion desiredPivotRotation;

	// Token: 0x0400207C RID: 8316
	[Token(Token = "0x400207C")]
	[FieldOffset(Offset = "0x2B0")]
	public Transform selfTransform;

	// Token: 0x0400207D RID: 8317
	[Token(Token = "0x400207D")]
	[FieldOffset(Offset = "0x2B8")]
	public Quaternion desiredSelfRotation;

	// Token: 0x0400207E RID: 8318
	[Token(Token = "0x400207E")]
	[FieldOffset(Offset = "0x2C8")]
	public Transform muzzleTransform;

	// Token: 0x0400207F RID: 8319
	[Token(Token = "0x400207F")]
	[FieldOffset(Offset = "0x2D0")]
	public float seekUpdateProgress;

	// Token: 0x04002080 RID: 8320
	[Token(Token = "0x4002080")]
	[FieldOffset(Offset = "0x2D4")]
	public float forgetProgress;

	// Token: 0x04002081 RID: 8321
	[Token(Token = "0x4002081")]
	[FieldOffset(Offset = "0x2D8")]
	private float pulseProgress;

	// Token: 0x04002082 RID: 8322
	[Token(Token = "0x4002082")]
	[FieldOffset(Offset = "0x2DC")]
	private float focusFlashCounter;

	// Token: 0x04002083 RID: 8323
	[Token(Token = "0x4002083")]
	[FieldOffset(Offset = "0x2E0")]
	public List<NewAIController.TrackingTarget> activeTargets;

	// Token: 0x04002084 RID: 8324
	[Token(Token = "0x4002084")]
	[FieldOffset(Offset = "0x2E8")]
	public float sweepProgress;

	// Token: 0x04002085 RID: 8325
	[Token(Token = "0x4002085")]
	[FieldOffset(Offset = "0x2F0")]
	private InterfaceController.AwarenessIcon awarenessIcon;

	// Token: 0x04002086 RID: 8326
	[Token(Token = "0x4002086")]
	[FieldOffset(Offset = "0x2F8")]
	private float sentryFireProgress;

	// Token: 0x04002087 RID: 8327
	[Token(Token = "0x4002087")]
	[FieldOffset(Offset = "0x300")]
	public AnimationCurve cameraSweep;

	// Token: 0x04002088 RID: 8328
	[Token(Token = "0x4002088")]
	[FieldOffset(Offset = "0x308")]
	public float focusGraceTime;

	// Token: 0x04002089 RID: 8329
	[Token(Token = "0x4002089")]
	[FieldOffset(Offset = "0x30C")]
	public float focusGiveUpTime;

	// Token: 0x0200049D RID: 1181
	[Token(Token = "0x200049D")]
	public enum SecuritySystemType
	{
		// Token: 0x0400208B RID: 8331
		[Token(Token = "0x400208B")]
		camera,
		// Token: 0x0400208C RID: 8332
		[Token(Token = "0x400208C")]
		sentry
	}
}
