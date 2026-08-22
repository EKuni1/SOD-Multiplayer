using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000254 RID: 596
[Token(Token = "0x2000254")]
public class AnimationFrameReference : MonoBehaviour
{
	// Token: 0x17000072 RID: 114
	// (get) Token: 0x06000D75 RID: 3445 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000072")]
	public static AnimationFrameReference Instance
	{
		[Token(Token = "0x6000D75")]
		[Address(RVA = "0x5EABE0", Offset = "0x5E9BE0", VA = "0x1805EABE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D76")]
	[Address(RVA = "0x5EAC20", Offset = "0x5E9C20", VA = "0x1805EAC20")]
	private void Awake()
	{
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D77")]
	[Address(RVA = "0x5EAF70", Offset = "0x5E9F70", VA = "0x1805EAF70")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000D78 RID: 3448 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D78")]
	[Address(RVA = "0x5EB180", Offset = "0x5EA180", VA = "0x1805EB180")]
	public AnimationFrameReference.AnimationReference GetAnimationReference(CitizenAnimationController.ArmsBoolSate arms, string seed)
	{
		return null;
	}

	// Token: 0x06000D79 RID: 3449 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000D79")]
	[Address(RVA = "0x5EB490", Offset = "0x5EA490", VA = "0x1805EB490")]
	public AnimationFrameReference.AnimationReference GetAnimationReference(CitizenAnimationController.IdleAnimationState idle, string seed)
	{
		return null;
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0x5EB650", Offset = "0x5EA650", VA = "0x1805EB650")]
	public void CaptureState()
	{
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0x5EB730", Offset = "0x5EA730", VA = "0x1805EB730")]
	public void CaptureWalkingState()
	{
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0x5EB810", Offset = "0x5EA810", VA = "0x1805EB810")]
	public void CaptureRunningState()
	{
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0x5EB8F0", Offset = "0x5EA8F0", VA = "0x1805EB8F0")]
	public AnimationFrameReference()
	{
	}

	// Token: 0x04000F0E RID: 3854
	[Token(Token = "0x4000F0E")]
	[FieldOffset(Offset = "0x18")]
	public List<AnimationFrameReference.AnimationReference> reference;

	// Token: 0x04000F0F RID: 3855
	[Token(Token = "0x4000F0F")]
	[FieldOffset(Offset = "0x20")]
	public List<AnimationFrameReference.AnimationReference> walkingReference;

	// Token: 0x04000F10 RID: 3856
	[Token(Token = "0x4000F10")]
	[FieldOffset(Offset = "0x28")]
	public List<AnimationFrameReference.AnimationReference> runningReference;

	// Token: 0x04000F11 RID: 3857
	[Token(Token = "0x4000F11")]
	[FieldOffset(Offset = "0x30")]
	public CitizenOutfitController captureFrom;

	// Token: 0x04000F12 RID: 3858
	[Token(Token = "0x4000F12")]
	[FieldOffset(Offset = "0x38")]
	public CitizenAnimationController.IdleAnimationState captureIdle;

	// Token: 0x04000F13 RID: 3859
	[Token(Token = "0x4000F13")]
	[FieldOffset(Offset = "0x3C")]
	public CitizenAnimationController.ArmsBoolSate captureArms;

	// Token: 0x04000F14 RID: 3860
	[Token(Token = "0x4000F14")]
	[FieldOffset(Offset = "0x0")]
	private static AnimationFrameReference _instance;

	// Token: 0x02000255 RID: 597
	[Token(Token = "0x2000255")]
	[Serializable]
	public class AnimationReference
	{
		// Token: 0x06000D7E RID: 3454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public AnimationReference()
		{
		}

		// Token: 0x04000F15 RID: 3861
		[Token(Token = "0x4000F15")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000F16 RID: 3862
		[Token(Token = "0x4000F16")]
		[FieldOffset(Offset = "0x18")]
		public bool isArms;

		// Token: 0x04000F17 RID: 3863
		[Token(Token = "0x4000F17")]
		[FieldOffset(Offset = "0x1C")]
		public CitizenAnimationController.IdleAnimationState idle;

		// Token: 0x04000F18 RID: 3864
		[Token(Token = "0x4000F18")]
		[FieldOffset(Offset = "0x20")]
		public CitizenAnimationController.ArmsBoolSate arms;

		// Token: 0x04000F19 RID: 3865
		[Token(Token = "0x4000F19")]
		[FieldOffset(Offset = "0x28")]
		public List<AnimationFrameReference.AnimationAnchorRef> anim;
	}

	// Token: 0x02000256 RID: 598
	[Token(Token = "0x2000256")]
	[Serializable]
	public class AnimationAnchorRef
	{
		// Token: 0x06000D7F RID: 3455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public AnimationAnchorRef()
		{
		}

		// Token: 0x04000F1A RID: 3866
		[Token(Token = "0x4000F1A")]
		[FieldOffset(Offset = "0x10")]
		public CitizenOutfitController.CharacterAnchor anchor;

		// Token: 0x04000F1B RID: 3867
		[Token(Token = "0x4000F1B")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 localPos;

		// Token: 0x04000F1C RID: 3868
		[Token(Token = "0x4000F1C")]
		[FieldOffset(Offset = "0x20")]
		public Quaternion localRot;
	}

	// Token: 0x02000257 RID: 599
	[Token(Token = "0x2000257")]
	private sealed class <>c__DisplayClass13_0
	{
		// Token: 0x06000D80 RID: 3456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D80")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass13_0()
		{
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00007368 File Offset: 0x00005568
		[Token(Token = "0x6000D81")]
		[Address(RVA = "0x5EBB00", Offset = "0x5EAB00", VA = "0x1805EBB00")]
		internal bool <GetAnimationReference>b__0(AnimationFrameReference.AnimationReference item)
		{
			return default(bool);
		}

		// Token: 0x04000F1D RID: 3869
		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0x10")]
		public CitizenAnimationController.ArmsBoolSate arms;
	}

	// Token: 0x02000258 RID: 600
	[Token(Token = "0x2000258")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000D83 RID: 3459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00007380 File Offset: 0x00005580
		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x5EBBE0", Offset = "0x5EABE0", VA = "0x1805EBBE0")]
		internal bool <GetAnimationReference>b__13_1(AnimationFrameReference.AnimationReference item)
		{
			return default(bool);
		}

		// Token: 0x04000F1E RID: 3870
		[Token(Token = "0x4000F1E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AnimationFrameReference.<>c <>9;

		// Token: 0x04000F1F RID: 3871
		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<AnimationFrameReference.AnimationReference> <>9__13_1;
	}

	// Token: 0x02000259 RID: 601
	[Token(Token = "0x2000259")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x06000D85 RID: 3461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00007398 File Offset: 0x00005598
		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x5EBC10", Offset = "0x5EAC10", VA = "0x1805EBC10")]
		internal bool <GetAnimationReference>b__0(AnimationFrameReference.AnimationReference item)
		{
			return default(bool);
		}

		// Token: 0x04000F20 RID: 3872
		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0x10")]
		public CitizenAnimationController.IdleAnimationState idle;
	}
}
