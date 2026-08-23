using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200024F RID: 591
[Token(Token = "0x200024F")]
public class AnimatedTextureController : MonoBehaviour
{
	// Token: 0x06000D55 RID: 3413 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D55")]
	[Address(RVA = "0x5E8190", Offset = "0x5E7190", VA = "0x1805E8190", Slot = "4")]
	public virtual void Play()
	{
	}

	// Token: 0x06000D56 RID: 3414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D56")]
	[Address(RVA = "0x5E8580", Offset = "0x5E7580", VA = "0x1805E8580", Slot = "5")]
	public virtual void Stop()
	{
	}

	// Token: 0x06000D57 RID: 3415 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D57")]
	[Address(RVA = "0x5E85F0", Offset = "0x5E75F0", VA = "0x1805E85F0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000D58 RID: 3416 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D58")]
	[Address(RVA = "0x5E8690", Offset = "0x5E7690", VA = "0x1805E8690", Slot = "6")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D59")]
	[Address(RVA = "0x5E8A40", Offset = "0x5E7A40", VA = "0x1805E8A40", Slot = "7")]
	protected virtual void Start()
	{
	}

	// Token: 0x06000D5A RID: 3418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5A")]
	[Address(RVA = "0x5E8A60", Offset = "0x5E7A60", VA = "0x1805E8A60")]
	private void Update()
	{
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5B")]
	[Address(RVA = "0x5E9020", Offset = "0x5E8020", VA = "0x1805E9020")]
	private void Billboard()
	{
	}

	// Token: 0x06000D5C RID: 3420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5C")]
	[Address(RVA = "0x5E9630", Offset = "0x5E8630", VA = "0x1805E9630", Slot = "8")]
	protected virtual void ApplyOffset(Vector2 offset)
	{
	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5D")]
	[Address(RVA = "0x5E9830", Offset = "0x5E8830", VA = "0x1805E9830", Slot = "9")]
	protected virtual void ApplyScale(Vector2 scale)
	{
	}

	// Token: 0x06000D5E RID: 3422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D5E")]
	[Address(RVA = "0x5E9A30", Offset = "0x5E8A30", VA = "0x1805E9A30")]
	public AnimatedTextureController()
	{
	}

	// Token: 0x04000EDC RID: 3804
	[Token(Token = "0x4000EDC")]
	[FieldOffset(Offset = "0x18")]
	public Renderer animatedRenderer;

	// Token: 0x04000EDD RID: 3805
	[Token(Token = "0x4000EDD")]
	[FieldOffset(Offset = "0x20")]
	public float animationCycleTime;

	// Token: 0x04000EDE RID: 3806
	[Token(Token = "0x4000EDE")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 texTileCount;

	// Token: 0x04000EDF RID: 3807
	[Token(Token = "0x4000EDF")]
	[FieldOffset(Offset = "0x2C")]
	public bool playOnStart;

	// Token: 0x04000EE0 RID: 3808
	[Token(Token = "0x4000EE0")]
	[FieldOffset(Offset = "0x2D")]
	public bool destroyOnEnd;

	// Token: 0x04000EE1 RID: 3809
	[Token(Token = "0x4000EE1")]
	[FieldOffset(Offset = "0x2E")]
	public bool destroyIfInactive;

	// Token: 0x04000EE2 RID: 3810
	[Token(Token = "0x4000EE2")]
	[FieldOffset(Offset = "0x2F")]
	public bool billboardingOn;

	// Token: 0x04000EE3 RID: 3811
	[Token(Token = "0x4000EE3")]
	[FieldOffset(Offset = "0x30")]
	public bool faceOnStartOnly;

	// Token: 0x04000EE4 RID: 3812
	[Token(Token = "0x4000EE4")]
	[FieldOffset(Offset = "0x34")]
	public AnimatedTextureController.SpecialCase specialCase;

	// Token: 0x04000EE5 RID: 3813
	[Token(Token = "0x4000EE5")]
	[FieldOffset(Offset = "0x38")]
	public bool alterEmission;

	// Token: 0x04000EE6 RID: 3814
	[Token(Token = "0x4000EE6")]
	[FieldOffset(Offset = "0x3C")]
	public Color startingEmission;

	// Token: 0x04000EE7 RID: 3815
	[Token(Token = "0x4000EE7")]
	[FieldOffset(Offset = "0x4C")]
	public Color midEmission;

	// Token: 0x04000EE8 RID: 3816
	[Token(Token = "0x4000EE8")]
	[FieldOffset(Offset = "0x5C")]
	public Color endEmission;

	// Token: 0x04000EE9 RID: 3817
	[Token(Token = "0x4000EE9")]
	[FieldOffset(Offset = "0x6C")]
	public bool alterScale;

	// Token: 0x04000EEA RID: 3818
	[Token(Token = "0x4000EEA")]
	[FieldOffset(Offset = "0x70")]
	public Transform parentScaleTransform;

	// Token: 0x04000EEB RID: 3819
	[Token(Token = "0x4000EEB")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve scaleX;

	// Token: 0x04000EEC RID: 3820
	[Token(Token = "0x4000EEC")]
	[FieldOffset(Offset = "0x80")]
	public AnimationCurve scaleY;

	// Token: 0x04000EED RID: 3821
	[Token(Token = "0x4000EED")]
	[FieldOffset(Offset = "0x88")]
	public AnimationCurve scaleZ;

	// Token: 0x04000EEE RID: 3822
	[Token(Token = "0x4000EEE")]
	[FieldOffset(Offset = "0x90")]
	public AudioEvent triggerAudio;

	// Token: 0x04000EEF RID: 3823
	[Token(Token = "0x4000EEF")]
	[FieldOffset(Offset = "0x98")]
	public bool useSpeedOfSound;

	// Token: 0x04000EF0 RID: 3824
	[Token(Token = "0x4000EF0")]
	[FieldOffset(Offset = "0x9C")]
	private float animtionTimer;

	// Token: 0x04000EF1 RID: 3825
	[Token(Token = "0x4000EF1")]
	[FieldOffset(Offset = "0xA0")]
	public float animationProgress;

	// Token: 0x04000EF2 RID: 3826
	[Token(Token = "0x4000EF2")]
	[FieldOffset(Offset = "0xA4")]
	public bool isPlaying;

	// Token: 0x04000EF3 RID: 3827
	[Token(Token = "0x4000EF3")]
	[FieldOffset(Offset = "0xA5")]
	public bool loop;

	// Token: 0x04000EF4 RID: 3828
	[Token(Token = "0x4000EF4")]
	[FieldOffset(Offset = "0xA8")]
	public float nextFrameTimer;

	// Token: 0x04000EF5 RID: 3829
	[Token(Token = "0x4000EF5")]
	[FieldOffset(Offset = "0xAC")]
	public int spriteCursorX;

	// Token: 0x04000EF6 RID: 3830
	[Token(Token = "0x4000EF6")]
	[FieldOffset(Offset = "0xB0")]
	public int spriteCursorY;

	// Token: 0x02000250 RID: 592
	[Token(Token = "0x2000250")]
	public enum SpecialCase
	{
		// Token: 0x04000EF8 RID: 3832
		[Token(Token = "0x4000EF8")]
		fireSmoke
	}
}
