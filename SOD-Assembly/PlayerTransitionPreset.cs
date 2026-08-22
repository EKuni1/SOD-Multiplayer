using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200086D RID: 2157
[Token(Token = "0x200086D")]
public class PlayerTransitionPreset : SoCustomComparison
{
	// Token: 0x060029D7 RID: 10711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029D7")]
	[Address(RVA = "0xCB09D0", Offset = "0xCAF9D0", VA = "0x180CB09D0")]
	public PlayerTransitionPreset()
	{
	}

	// Token: 0x04004186 RID: 16774
	[Token(Token = "0x4004186")]
	[FieldOffset(Offset = "0x20")]
	public float transitionTime;

	// Token: 0x04004187 RID: 16775
	[Token(Token = "0x4004187")]
	[FieldOffset(Offset = "0x24")]
	public bool retainMovementControl;

	// Token: 0x04004188 RID: 16776
	[Token(Token = "0x4004188")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve controlCurve;

	// Token: 0x04004189 RID: 16777
	[Token(Token = "0x4004189")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve mouseLookControlCurve;

	// Token: 0x0400418A RID: 16778
	[Token(Token = "0x400418A")]
	[FieldOffset(Offset = "0x38")]
	public float playerHeightMP;

	// Token: 0x0400418B RID: 16779
	[Token(Token = "0x400418B")]
	[FieldOffset(Offset = "0x3C")]
	public float CamHeightMP;

	// Token: 0x0400418C RID: 16780
	[Token(Token = "0x400418C")]
	[FieldOffset(Offset = "0x40")]
	public bool factorInCrouching;

	// Token: 0x0400418D RID: 16781
	[Token(Token = "0x400418D")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve heightCurve;

	// Token: 0x0400418E RID: 16782
	[Token(Token = "0x400418E")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve camHeightCurve;

	// Token: 0x0400418F RID: 16783
	[Token(Token = "0x400418F")]
	[FieldOffset(Offset = "0x58")]
	public bool useXMovement;

	// Token: 0x04004190 RID: 16784
	[Token(Token = "0x4004190")]
	[FieldOffset(Offset = "0x60")]
	public AnimationCurve playerXCurve;

	// Token: 0x04004191 RID: 16785
	[Token(Token = "0x4004191")]
	[FieldOffset(Offset = "0x68")]
	public bool useYMovement;

	// Token: 0x04004192 RID: 16786
	[Token(Token = "0x4004192")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve playerYCurve;

	// Token: 0x04004193 RID: 16787
	[Token(Token = "0x4004193")]
	[FieldOffset(Offset = "0x78")]
	public bool useZMovement;

	// Token: 0x04004194 RID: 16788
	[Token(Token = "0x4004194")]
	[FieldOffset(Offset = "0x80")]
	public AnimationCurve playerZCurve;

	// Token: 0x04004195 RID: 16789
	[Token(Token = "0x4004195")]
	[FieldOffset(Offset = "0x88")]
	public bool fixYMovementForRatController;

	// Token: 0x04004196 RID: 16790
	[Token(Token = "0x4004196")]
	[FieldOffset(Offset = "0x90")]
	public AnimationCurve playerYCurveIfRat;

	// Token: 0x04004197 RID: 16791
	[Token(Token = "0x4004197")]
	[FieldOffset(Offset = "0x98")]
	public PlayerTransitionPreset.TransitionPosition transitionRelativity;

	// Token: 0x04004198 RID: 16792
	[Token(Token = "0x4004198")]
	[FieldOffset(Offset = "0x9C")]
	public bool disableWriteReturnPosition;

	// Token: 0x04004199 RID: 16793
	[Token(Token = "0x4004199")]
	[FieldOffset(Offset = "0x9D")]
	public bool transitionToSavedReturnPosition;

	// Token: 0x0400419A RID: 16794
	[Token(Token = "0x400419A")]
	[FieldOffset(Offset = "0x9E")]
	public bool transitionFromExistingPosition;

	// Token: 0x0400419B RID: 16795
	[Token(Token = "0x400419B")]
	[FieldOffset(Offset = "0xA0")]
	public AnimationCurve positionTransitionCurve;

	// Token: 0x0400419C RID: 16796
	[Token(Token = "0x400419C")]
	[FieldOffset(Offset = "0xA8")]
	public bool invertXPositionBasedOnRelativePlayerX;

	// Token: 0x0400419D RID: 16797
	[Token(Token = "0x400419D")]
	[FieldOffset(Offset = "0xA9")]
	public bool invertYPositionBasedOnRelativePlayerY;

	// Token: 0x0400419E RID: 16798
	[Token(Token = "0x400419E")]
	[FieldOffset(Offset = "0xAA")]
	public bool invertZPositionBasedOnRelativePlayerZ;

	// Token: 0x0400419F RID: 16799
	[Token(Token = "0x400419F")]
	[FieldOffset(Offset = "0xAB")]
	public bool raycastCheck;

	// Token: 0x040041A0 RID: 16800
	[Token(Token = "0x40041A0")]
	[FieldOffset(Offset = "0xB0")]
	public PlayerTransitionPreset onFailUse;

	// Token: 0x040041A1 RID: 16801
	[Token(Token = "0x40041A1")]
	[FieldOffset(Offset = "0xB8")]
	public bool allowMovementOnEnd;

	// Token: 0x040041A2 RID: 16802
	[Token(Token = "0x40041A2")]
	[FieldOffset(Offset = "0xB9")]
	public bool restoreNormalMovementSpeed;

	// Token: 0x040041A3 RID: 16803
	[Token(Token = "0x40041A3")]
	[FieldOffset(Offset = "0xBC")]
	public float customMovementSpeed;

	// Token: 0x040041A4 RID: 16804
	[Token(Token = "0x40041A4")]
	[FieldOffset(Offset = "0xC0")]
	public bool disableGravity;

	// Token: 0x040041A5 RID: 16805
	[Token(Token = "0x40041A5")]
	[FieldOffset(Offset = "0xC1")]
	public bool disableHeadBob;

	// Token: 0x040041A6 RID: 16806
	[Token(Token = "0x40041A6")]
	[FieldOffset(Offset = "0xC2")]
	public bool useXLook;

	// Token: 0x040041A7 RID: 16807
	[Token(Token = "0x40041A7")]
	[FieldOffset(Offset = "0xC8")]
	public AnimationCurve playerXLookCurve;

	// Token: 0x040041A8 RID: 16808
	[Token(Token = "0x40041A8")]
	[FieldOffset(Offset = "0xD0")]
	public bool useYLook;

	// Token: 0x040041A9 RID: 16809
	[Token(Token = "0x40041A9")]
	[FieldOffset(Offset = "0xD8")]
	public AnimationCurve playerYLookCurve;

	// Token: 0x040041AA RID: 16810
	[Token(Token = "0x40041AA")]
	[FieldOffset(Offset = "0xE0")]
	public bool useZLook;

	// Token: 0x040041AB RID: 16811
	[Token(Token = "0x40041AB")]
	[FieldOffset(Offset = "0xE8")]
	public AnimationCurve playerZLookCurve;

	// Token: 0x040041AC RID: 16812
	[Token(Token = "0x40041AC")]
	[FieldOffset(Offset = "0xF0")]
	public PlayerTransitionPreset.TransitionPosition lookRelativity;

	// Token: 0x040041AD RID: 16813
	[Token(Token = "0x40041AD")]
	[FieldOffset(Offset = "0xF4")]
	public float forwardPositionModifier;

	// Token: 0x040041AE RID: 16814
	[Token(Token = "0x40041AE")]
	[FieldOffset(Offset = "0xF8")]
	public float lookMovementMultiplier;

	// Token: 0x040041AF RID: 16815
	[Token(Token = "0x40041AF")]
	[FieldOffset(Offset = "0xFC")]
	public bool applyCameraRoll;

	// Token: 0x040041B0 RID: 16816
	[Token(Token = "0x40041B0")]
	[FieldOffset(Offset = "0x100")]
	public AnimationCurve cameraRoll;

	// Token: 0x040041B1 RID: 16817
	[Token(Token = "0x40041B1")]
	[FieldOffset(Offset = "0x108")]
	public float rollMultiplier;

	// Token: 0x040041B2 RID: 16818
	[Token(Token = "0x40041B2")]
	[FieldOffset(Offset = "0x10C")]
	public bool resetCameraRoll;

	// Token: 0x040041B3 RID: 16819
	[Token(Token = "0x40041B3")]
	[FieldOffset(Offset = "0x10D")]
	public bool transitionFromExistingMouse;

	// Token: 0x040041B4 RID: 16820
	[Token(Token = "0x40041B4")]
	[FieldOffset(Offset = "0x110")]
	public AnimationCurve mouseTransitionCurve;

	// Token: 0x040041B5 RID: 16821
	[Token(Token = "0x40041B5")]
	[FieldOffset(Offset = "0x118")]
	public bool useChromaticAberration;

	// Token: 0x040041B6 RID: 16822
	[Token(Token = "0x40041B6")]
	[FieldOffset(Offset = "0x120")]
	public AnimationCurve chromaticAberrationCurve;

	// Token: 0x040041B7 RID: 16823
	[Token(Token = "0x40041B7")]
	[FieldOffset(Offset = "0x128")]
	public bool useGain;

	// Token: 0x040041B8 RID: 16824
	[Token(Token = "0x40041B8")]
	[FieldOffset(Offset = "0x130")]
	public AnimationCurve gainCurve;

	// Token: 0x040041B9 RID: 16825
	[Token(Token = "0x40041B9")]
	[FieldOffset(Offset = "0x138")]
	public List<PlayerTransitionPreset.SFXSetting> sfx;

	// Token: 0x040041BA RID: 16826
	[Token(Token = "0x40041BA")]
	[FieldOffset(Offset = "0x140")]
	public bool forceHolsterOnTransition;

	// Token: 0x040041BB RID: 16827
	[Token(Token = "0x40041BB")]
	[FieldOffset(Offset = "0x141")]
	public bool restoreHolsterOnTransitionEnd;

	// Token: 0x040041BC RID: 16828
	[Token(Token = "0x40041BC")]
	[FieldOffset(Offset = "0x142")]
	public bool allowWeaponSwitchingAfterTransition;

	// Token: 0x040041BD RID: 16829
	[Token(Token = "0x40041BD")]
	[FieldOffset(Offset = "0x148")]
	public AnimationCurve playerXRecoilLookCurve;

	// Token: 0x040041BE RID: 16830
	[Token(Token = "0x40041BE")]
	[FieldOffset(Offset = "0x150")]
	public AnimationCurve playerYRecoilLookCurve;

	// Token: 0x040041BF RID: 16831
	[Token(Token = "0x40041BF")]
	[FieldOffset(Offset = "0x158")]
	public AnimationCurve playerZRecoilLookCurve;

	// Token: 0x040041C0 RID: 16832
	[Token(Token = "0x40041C0")]
	[FieldOffset(Offset = "0x160")]
	public bool useCustomReturnPosition;

	// Token: 0x040041C1 RID: 16833
	[Token(Token = "0x40041C1")]
	[FieldOffset(Offset = "0x164")]
	public Vector3 returnPostion;

	// Token: 0x0200086E RID: 2158
	[Token(Token = "0x200086E")]
	public enum TransitionPosition
	{
		// Token: 0x040041C3 RID: 16835
		[Token(Token = "0x40041C3")]
		relativeToInteractable,
		// Token: 0x040041C4 RID: 16836
		[Token(Token = "0x40041C4")]
		relativeToPlayer
	}

	// Token: 0x0200086F RID: 2159
	[Token(Token = "0x200086F")]
	[Serializable]
	public class SFXSetting
	{
		// Token: 0x060029D8 RID: 10712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029D8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public SFXSetting()
		{
		}

		// Token: 0x040041C5 RID: 16837
		[Token(Token = "0x40041C5")]
		[FieldOffset(Offset = "0x10")]
		public AudioEvent soundEvent;

		// Token: 0x040041C6 RID: 16838
		[Token(Token = "0x40041C6")]
		[FieldOffset(Offset = "0x18")]
		public float atProgress;
	}
}
