using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008B9 RID: 2233
[Token(Token = "0x20008B9")]
public class GameplayControls : MonoBehaviour
{
	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06002A38 RID: 10808 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000152")]
	public static GameplayControls Instance
	{
		[Token(Token = "0x6002A38")]
		[Address(RVA = "0xCBB080", Offset = "0xCBA080", VA = "0x180CBB080")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002A39 RID: 10809 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A39")]
	[Address(RVA = "0xCBB0C0", Offset = "0xCBA0C0", VA = "0x180CBB0C0")]
	private void Awake()
	{
	}

	// Token: 0x06002A3A RID: 10810 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A3A")]
	[Address(RVA = "0xCBB450", Offset = "0xCBA450", VA = "0x180CBB450")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002A3B RID: 10811 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A3B")]
	[Address(RVA = "0xCBB660", Offset = "0xCBA660", VA = "0x180CBB660")]
	public GameplayControls()
	{
	}

	// Token: 0x0400466D RID: 18029
	[Token(Token = "0x400466D")]
	[FieldOffset(Offset = "0x18")]
	public CutScenePreset intro;

	// Token: 0x0400466E RID: 18030
	[Token(Token = "0x400466E")]
	[FieldOffset(Offset = "0x20")]
	public CutScenePreset outro;

	// Token: 0x0400466F RID: 18031
	[Token(Token = "0x400466F")]
	[FieldOffset(Offset = "0x28")]
	public SessionData.TimeSpeed startingTimeSpeed;

	// Token: 0x04004670 RID: 18032
	[Token(Token = "0x4004670")]
	[FieldOffset(Offset = "0x30")]
	public List<float> timeMultipliers;

	// Token: 0x04004671 RID: 18033
	[Token(Token = "0x4004671")]
	[FieldOffset(Offset = "0x38")]
	public int startingDate;

	// Token: 0x04004672 RID: 18034
	[Token(Token = "0x4004672")]
	[FieldOffset(Offset = "0x3C")]
	public int startingMonth;

	// Token: 0x04004673 RID: 18035
	[Token(Token = "0x4004673")]
	[FieldOffset(Offset = "0x40")]
	public int startingYear;

	// Token: 0x04004674 RID: 18036
	[Token(Token = "0x4004674")]
	[FieldOffset(Offset = "0x44")]
	public int yearZeroLeapYearCycle;

	// Token: 0x04004675 RID: 18037
	[Token(Token = "0x4004675")]
	[FieldOffset(Offset = "0x48")]
	public int dayZero;

	// Token: 0x04004676 RID: 18038
	[Token(Token = "0x4004676")]
	[FieldOffset(Offset = "0x4C")]
	public int publicYearZero;

	// Token: 0x04004677 RID: 18039
	[Token(Token = "0x4004677")]
	[FieldOffset(Offset = "0x50")]
	public float routineUpdateFrequency;

	// Token: 0x04004678 RID: 18040
	[Token(Token = "0x4004678")]
	[FieldOffset(Offset = "0x54")]
	public float gameWorldUpdateFrequency;

	// Token: 0x04004679 RID: 18041
	[Token(Token = "0x4004679")]
	[FieldOffset(Offset = "0x58")]
	public float doorSequenceUpdateFrequency;

	// Token: 0x0400467A RID: 18042
	[Token(Token = "0x400467A")]
	[FieldOffset(Offset = "0x5C")]
	public float stealthModeLoopUpdateFrequency;

	// Token: 0x0400467B RID: 18043
	[Token(Token = "0x400467B")]
	[FieldOffset(Offset = "0x60")]
	public float playerHeightNormal;

	// Token: 0x0400467C RID: 18044
	[Token(Token = "0x400467C")]
	[FieldOffset(Offset = "0x64")]
	public float playerHeightCrouched;

	// Token: 0x0400467D RID: 18045
	[Token(Token = "0x400467D")]
	[FieldOffset(Offset = "0x68")]
	public AnimationCurve crouchHeightCurve;

	// Token: 0x0400467E RID: 18046
	[Token(Token = "0x400467E")]
	[FieldOffset(Offset = "0x70")]
	public AnimationCurve leanCurve;

	// Token: 0x0400467F RID: 18047
	[Token(Token = "0x400467F")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve joltCurve;

	// Token: 0x04004680 RID: 18048
	[Token(Token = "0x4004680")]
	[FieldOffset(Offset = "0x80")]
	public float cameraHeightNormal;

	// Token: 0x04004681 RID: 18049
	[Token(Token = "0x4004681")]
	[FieldOffset(Offset = "0x84")]
	public float cameraHeightCrouched;

	// Token: 0x04004682 RID: 18050
	[Token(Token = "0x4004682")]
	[FieldOffset(Offset = "0x88")]
	public float interactionRange;

	// Token: 0x04004683 RID: 18051
	[Token(Token = "0x4004683")]
	[FieldOffset(Offset = "0x8C")]
	public float readingRange;

	// Token: 0x04004684 RID: 18052
	[Token(Token = "0x4004684")]
	[FieldOffset(Offset = "0x90")]
	public float carryDistance;

	// Token: 0x04004685 RID: 18053
	[Token(Token = "0x4004685")]
	[FieldOffset(Offset = "0x94")]
	public float throwForce;

	// Token: 0x04004686 RID: 18054
	[Token(Token = "0x4004686")]
	[FieldOffset(Offset = "0x98")]
	public float fovNormal;

	// Token: 0x04004687 RID: 18055
	[Token(Token = "0x4004687")]
	[FieldOffset(Offset = "0x9C")]
	public float fovInteraction;

	// Token: 0x04004688 RID: 18056
	[Token(Token = "0x4004688")]
	[FieldOffset(Offset = "0xA0")]
	public float fpsModelLag;

	// Token: 0x04004689 RID: 18057
	[Token(Token = "0x4004689")]
	[FieldOffset(Offset = "0xA4")]
	public float playerWalkSpeed;

	// Token: 0x0400468A RID: 18058
	[Token(Token = "0x400468A")]
	[FieldOffset(Offset = "0xA8")]
	public float playerRunSpeed;

	// Token: 0x0400468B RID: 18059
	[Token(Token = "0x400468B")]
	[FieldOffset(Offset = "0xAC")]
	public float jumpHeight;

	// Token: 0x0400468C RID: 18060
	[Token(Token = "0x400468C")]
	[FieldOffset(Offset = "0xB0")]
	public float playerStealthWalkMuliplier;

	// Token: 0x0400468D RID: 18061
	[Token(Token = "0x400468D")]
	[FieldOffset(Offset = "0xB4")]
	public float playerStealthRunMultiplier;

	// Token: 0x0400468E RID: 18062
	[Token(Token = "0x400468E")]
	[FieldOffset(Offset = "0xB8")]
	public float headBobMultiplier;

	// Token: 0x0400468F RID: 18063
	[Token(Token = "0x400468F")]
	[FieldOffset(Offset = "0xBC")]
	public float ductPlayerHeight;

	// Token: 0x04004690 RID: 18064
	[Token(Token = "0x4004690")]
	[FieldOffset(Offset = "0xC0")]
	public float ductCamHeight;

	// Token: 0x04004691 RID: 18065
	[Token(Token = "0x4004691")]
	[FieldOffset(Offset = "0xC4")]
	public float ductPlayerPosY;

	// Token: 0x04004692 RID: 18066
	[Token(Token = "0x4004692")]
	[FieldOffset(Offset = "0xC8")]
	public Vector3 airDuctEntry;

	// Token: 0x04004693 RID: 18067
	[Token(Token = "0x4004693")]
	[FieldOffset(Offset = "0xD4")]
	public Vector3 airDuctExit;

	// Token: 0x04004694 RID: 18068
	[Token(Token = "0x4004694")]
	[FieldOffset(Offset = "0xE0")]
	public float normalSkinWidth;

	// Token: 0x04004695 RID: 18069
	[Token(Token = "0x4004695")]
	[FieldOffset(Offset = "0xE4")]
	public float carryingSkinWidth;

	// Token: 0x04004696 RID: 18070
	[Token(Token = "0x4004696")]
	[FieldOffset(Offset = "0xE8")]
	public float ductSkinWidth;

	// Token: 0x04004697 RID: 18071
	[Token(Token = "0x4004697")]
	[FieldOffset(Offset = "0xF0")]
	public PlayerTransitionPreset defaultReturnTransition;

	// Token: 0x04004698 RID: 18072
	[Token(Token = "0x4004698")]
	[FieldOffset(Offset = "0xF8")]
	public PlayerTransitionPreset enterVentTransition;

	// Token: 0x04004699 RID: 18073
	[Token(Token = "0x4004699")]
	[FieldOffset(Offset = "0x100")]
	public PlayerTransitionPreset exitVentTransition;

	// Token: 0x0400469A RID: 18074
	[Token(Token = "0x400469A")]
	[FieldOffset(Offset = "0x108")]
	public PlayerTransitionPreset citizensArrestTranstion;

	// Token: 0x0400469B RID: 18075
	[Token(Token = "0x400469B")]
	[FieldOffset(Offset = "0x110")]
	public PlayerTransitionPreset citizenTalkToTransition;

	// Token: 0x0400469C RID: 18076
	[Token(Token = "0x400469C")]
	[FieldOffset(Offset = "0x118")]
	public PlayerTransitionPreset doorPeekEnter;

	// Token: 0x0400469D RID: 18077
	[Token(Token = "0x400469D")]
	[FieldOffset(Offset = "0x120")]
	public PlayerTransitionPreset doorPeekExit;

	// Token: 0x0400469E RID: 18078
	[Token(Token = "0x400469E")]
	[FieldOffset(Offset = "0x128")]
	public PlayerTransitionPreset lockpickEnter;

	// Token: 0x0400469F RID: 18079
	[Token(Token = "0x400469F")]
	[FieldOffset(Offset = "0x130")]
	public PlayerTransitionPreset lockpickExit;

	// Token: 0x040046A0 RID: 18080
	[Token(Token = "0x40046A0")]
	[FieldOffset(Offset = "0x138")]
	public PlayerTransitionPreset sabotageEnter;

	// Token: 0x040046A1 RID: 18081
	[Token(Token = "0x40046A1")]
	[FieldOffset(Offset = "0x140")]
	public PlayerTransitionPreset sabotageExit;

	// Token: 0x040046A2 RID: 18082
	[Token(Token = "0x40046A2")]
	[FieldOffset(Offset = "0x148")]
	public PlayerTransitionPreset bargeDoorEnter;

	// Token: 0x040046A3 RID: 18083
	[Token(Token = "0x40046A3")]
	[FieldOffset(Offset = "0x150")]
	public PlayerTransitionPreset bargeDoorFail;

	// Token: 0x040046A4 RID: 18084
	[Token(Token = "0x40046A4")]
	[FieldOffset(Offset = "0x158")]
	public PlayerTransitionPreset bargeDoorSuccess;

	// Token: 0x040046A5 RID: 18085
	[Token(Token = "0x40046A5")]
	[FieldOffset(Offset = "0x160")]
	public PlayerTransitionPreset punchedReaction;

	// Token: 0x040046A6 RID: 18086
	[Token(Token = "0x40046A6")]
	[FieldOffset(Offset = "0x168")]
	public PlayerTransitionPreset playerKO;

	// Token: 0x040046A7 RID: 18087
	[Token(Token = "0x40046A7")]
	[FieldOffset(Offset = "0x170")]
	public PlayerTransitionPreset playerUseComputer;

	// Token: 0x040046A8 RID: 18088
	[Token(Token = "0x40046A8")]
	[FieldOffset(Offset = "0x178")]
	public PlayerTransitionPreset playerComputerExit;

	// Token: 0x040046A9 RID: 18089
	[Token(Token = "0x40046A9")]
	[FieldOffset(Offset = "0x180")]
	public PlayerTransitionPreset playerTakePrint;

	// Token: 0x040046AA RID: 18090
	[Token(Token = "0x40046AA")]
	[FieldOffset(Offset = "0x188")]
	public PlayerTransitionPreset playerTakePrintExit;

	// Token: 0x040046AB RID: 18091
	[Token(Token = "0x40046AB")]
	[FieldOffset(Offset = "0x190")]
	public PlayerTransitionPreset playerSearch;

	// Token: 0x040046AC RID: 18092
	[Token(Token = "0x40046AC")]
	[FieldOffset(Offset = "0x198")]
	public PlayerTransitionPreset playerSearchExit;

	// Token: 0x040046AD RID: 18093
	[Token(Token = "0x40046AD")]
	[FieldOffset(Offset = "0x1A0")]
	public PlayerTransitionPreset focusOnInteractable;

	// Token: 0x040046AE RID: 18094
	[Token(Token = "0x40046AE")]
	[FieldOffset(Offset = "0x1A8")]
	public PlayerTransitionPreset waterCoolerEnter;

	// Token: 0x040046AF RID: 18095
	[Token(Token = "0x40046AF")]
	[FieldOffset(Offset = "0x1B0")]
	public float dragForceAmount;

	// Token: 0x040046B0 RID: 18096
	[Token(Token = "0x40046B0")]
	[FieldOffset(Offset = "0x1B4")]
	public float maxAngleMovementWhenDragging;

	// Token: 0x040046B1 RID: 18097
	[Token(Token = "0x40046B1")]
	[FieldOffset(Offset = "0x1B8")]
	public float ragdollCarryMaxDistance;

	// Token: 0x040046B2 RID: 18098
	[Token(Token = "0x40046B2")]
	[FieldOffset(Offset = "0x1BC")]
	public bool ragdollJointPreprocessing;

	// Token: 0x040046B3 RID: 18099
	[Token(Token = "0x40046B3")]
	[FieldOffset(Offset = "0x1BD")]
	public bool ragdollJointCollision;

	// Token: 0x040046B4 RID: 18100
	[Token(Token = "0x40046B4")]
	[FieldOffset(Offset = "0x1BE")]
	public bool ragdollJointProjection;

	// Token: 0x040046B5 RID: 18101
	[Token(Token = "0x40046B5")]
	[FieldOffset(Offset = "0x1C0")]
	public float ragdollJointContactDistance;

	// Token: 0x040046B6 RID: 18102
	[Token(Token = "0x40046B6")]
	[FieldOffset(Offset = "0x1C4")]
	public bool ragdollRigidbodyCollision;

	// Token: 0x040046B7 RID: 18103
	[Token(Token = "0x40046B7")]
	[FieldOffset(Offset = "0x1C8")]
	public float ragdollJointBounce;

	// Token: 0x040046B8 RID: 18104
	[Token(Token = "0x40046B8")]
	[FieldOffset(Offset = "0x1CC")]
	public float ragdollJointDampen;

	// Token: 0x040046B9 RID: 18105
	[Token(Token = "0x40046B9")]
	[FieldOffset(Offset = "0x1D0")]
	public float ragdollJointSpring;

	// Token: 0x040046BA RID: 18106
	[Token(Token = "0x40046BA")]
	[FieldOffset(Offset = "0x1D4")]
	public float dofNormalNearStart;

	// Token: 0x040046BB RID: 18107
	[Token(Token = "0x40046BB")]
	[FieldOffset(Offset = "0x1D8")]
	public float dofNormalNearEnd;

	// Token: 0x040046BC RID: 18108
	[Token(Token = "0x40046BC")]
	[FieldOffset(Offset = "0x1DC")]
	public float dofNormalFarStart;

	// Token: 0x040046BD RID: 18109
	[Token(Token = "0x40046BD")]
	[FieldOffset(Offset = "0x1E0")]
	public float dofNormalFarEnd;

	// Token: 0x040046BE RID: 18110
	[Token(Token = "0x40046BE")]
	[FieldOffset(Offset = "0x1E4")]
	public float dofTalkingNearStart;

	// Token: 0x040046BF RID: 18111
	[Token(Token = "0x40046BF")]
	[FieldOffset(Offset = "0x1E8")]
	public float dofTalkingNearEnd;

	// Token: 0x040046C0 RID: 18112
	[Token(Token = "0x40046C0")]
	[FieldOffset(Offset = "0x1EC")]
	public float dofTalkingFarStart;

	// Token: 0x040046C1 RID: 18113
	[Token(Token = "0x40046C1")]
	[FieldOffset(Offset = "0x1F0")]
	public float dofTalkingFarEnd;

	// Token: 0x040046C2 RID: 18114
	[Token(Token = "0x40046C2")]
	[FieldOffset(Offset = "0x1F4")]
	public float dofPausedNearStart;

	// Token: 0x040046C3 RID: 18115
	[Token(Token = "0x40046C3")]
	[FieldOffset(Offset = "0x1F8")]
	public float dofPausedNearEnd;

	// Token: 0x040046C4 RID: 18116
	[Token(Token = "0x40046C4")]
	[FieldOffset(Offset = "0x1FC")]
	public float dofPausedFarStart;

	// Token: 0x040046C5 RID: 18117
	[Token(Token = "0x40046C5")]
	[FieldOffset(Offset = "0x200")]
	public float dofPausedFarEnd;

	// Token: 0x040046C6 RID: 18118
	[Token(Token = "0x40046C6")]
	[FieldOffset(Offset = "0x204")]
	public float dofCityEditNearStart;

	// Token: 0x040046C7 RID: 18119
	[Token(Token = "0x40046C7")]
	[FieldOffset(Offset = "0x208")]
	public float dofCityEditNearEnd;

	// Token: 0x040046C8 RID: 18120
	[Token(Token = "0x40046C8")]
	[FieldOffset(Offset = "0x20C")]
	public float dofCityEditFarStart;

	// Token: 0x040046C9 RID: 18121
	[Token(Token = "0x40046C9")]
	[FieldOffset(Offset = "0x210")]
	public float dofCityEditFarEnd;

	// Token: 0x040046CA RID: 18122
	[Token(Token = "0x40046CA")]
	[FieldOffset(Offset = "0x214")]
	public float dofChangeTime;

	// Token: 0x040046CB RID: 18123
	[Token(Token = "0x40046CB")]
	[FieldOffset(Offset = "0x218")]
	public List<FirstPersonItem> startingItems;

	// Token: 0x040046CC RID: 18124
	[Token(Token = "0x40046CC")]
	[FieldOffset(Offset = "0x220")]
	public FirstPersonItem nothingItem;

	// Token: 0x040046CD RID: 18125
	[Token(Token = "0x40046CD")]
	[FieldOffset(Offset = "0x228")]
	public FirstPersonItem watchItem;

	// Token: 0x040046CE RID: 18126
	[Token(Token = "0x40046CE")]
	[FieldOffset(Offset = "0x230")]
	public FirstPersonItem fistsItem;

	// Token: 0x040046CF RID: 18127
	[Token(Token = "0x40046CF")]
	[FieldOffset(Offset = "0x238")]
	public FirstPersonItem coinItem;

	// Token: 0x040046D0 RID: 18128
	[Token(Token = "0x40046D0")]
	[FieldOffset(Offset = "0x240")]
	public FirstPersonItem printReader;

	// Token: 0x040046D1 RID: 18129
	[Token(Token = "0x40046D1")]
	[FieldOffset(Offset = "0x248")]
	public float itemSwitchCounter;

	// Token: 0x040046D2 RID: 18130
	[Token(Token = "0x40046D2")]
	[FieldOffset(Offset = "0x250")]
	public AnimationCurve stealthAmbientLightLevel;

	// Token: 0x040046D3 RID: 18131
	[Token(Token = "0x40046D3")]
	[FieldOffset(Offset = "0x258")]
	public float interiorAmbientLightMultiplier;

	// Token: 0x040046D4 RID: 18132
	[Token(Token = "0x40046D4")]
	[FieldOffset(Offset = "0x260")]
	public Transform floorLightMeasure;

	// Token: 0x040046D5 RID: 18133
	[Token(Token = "0x40046D5")]
	[FieldOffset(Offset = "0x268")]
	public AnimationCurve stealthSunLightLevel;

	// Token: 0x040046D6 RID: 18134
	[Token(Token = "0x40046D6")]
	[FieldOffset(Offset = "0x270")]
	public Vector2 buildingAlarmTime;

	// Token: 0x040046D7 RID: 18135
	[Token(Token = "0x40046D7")]
	[FieldOffset(Offset = "0x278")]
	public float securityTrackSpeed;

	// Token: 0x040046D8 RID: 18136
	[Token(Token = "0x40046D8")]
	[FieldOffset(Offset = "0x27C")]
	public float citizenFOV;

	// Token: 0x040046D9 RID: 18137
	[Token(Token = "0x40046D9")]
	[FieldOffset(Offset = "0x280")]
	public float securityFOV;

	// Token: 0x040046DA RID: 18138
	[Token(Token = "0x40046DA")]
	[FieldOffset(Offset = "0x284")]
	public float sabotageLandValueMP;

	// Token: 0x040046DB RID: 18139
	[Token(Token = "0x40046DB")]
	[FieldOffset(Offset = "0x288")]
	public float citizenSightRange;

	// Token: 0x040046DC RID: 18140
	[Token(Token = "0x40046DC")]
	[FieldOffset(Offset = "0x28C")]
	public float securitySightRange;

	// Token: 0x040046DD RID: 18141
	[Token(Token = "0x40046DD")]
	[FieldOffset(Offset = "0x290")]
	public float minimumStealthDetectionRange;

	// Token: 0x040046DE RID: 18142
	[Token(Token = "0x40046DE")]
	[FieldOffset(Offset = "0x298")]
	public MurderWeaponPreset sentryGunWeapon;

	// Token: 0x040046DF RID: 18143
	[Token(Token = "0x40046DF")]
	[FieldOffset(Offset = "0x2A0")]
	public float sentryGunROF;

	// Token: 0x040046E0 RID: 18144
	[Token(Token = "0x40046E0")]
	[FieldOffset(Offset = "0x2A4")]
	public float sentryGunDamage;

	// Token: 0x040046E1 RID: 18145
	[Token(Token = "0x40046E1")]
	[FieldOffset(Offset = "0x2A8")]
	public float sentryGunAccuracy;

	// Token: 0x040046E2 RID: 18146
	[Token(Token = "0x40046E2")]
	[FieldOffset(Offset = "0x2AC")]
	public float playerMaxSpotDistance;

	// Token: 0x040046E3 RID: 18147
	[Token(Token = "0x40046E3")]
	[FieldOffset(Offset = "0x2B0")]
	public int playerSpotUpdateEveryXFrame;

	// Token: 0x040046E4 RID: 18148
	[Token(Token = "0x40046E4")]
	[FieldOffset(Offset = "0x2B4")]
	public float spottedGraceTime;

	// Token: 0x040046E5 RID: 18149
	[Token(Token = "0x40046E5")]
	[FieldOffset(Offset = "0x2B8")]
	public float spottedFadeSpeed;

	// Token: 0x040046E6 RID: 18150
	[Token(Token = "0x40046E6")]
	[FieldOffset(Offset = "0x2BC")]
	public float audioOnlySpotGraceTimeMultiplier;

	// Token: 0x040046E7 RID: 18151
	[Token(Token = "0x40046E7")]
	[FieldOffset(Offset = "0x2C0")]
	public float playerImageCaptureMaxRange;

	// Token: 0x040046E8 RID: 18152
	[Token(Token = "0x40046E8")]
	[FieldOffset(Offset = "0x2C4")]
	public float buildingWantedTime;

	// Token: 0x040046E9 RID: 18153
	[Token(Token = "0x40046E9")]
	[FieldOffset(Offset = "0x2C8")]
	public float breakerResetTime;

	// Token: 0x040046EA RID: 18154
	[Token(Token = "0x40046EA")]
	[FieldOffset(Offset = "0x2CC")]
	public float securityResetTime;

	// Token: 0x040046EB RID: 18155
	[Token(Token = "0x40046EB")]
	[FieldOffset(Offset = "0x2D0")]
	public float gasFillTime;

	// Token: 0x040046EC RID: 18156
	[Token(Token = "0x40046EC")]
	[FieldOffset(Offset = "0x2D4")]
	public float gasEmptyTime;

	// Token: 0x040046ED RID: 18157
	[Token(Token = "0x40046ED")]
	[FieldOffset(Offset = "0x2D8")]
	public float additionalEscalationTime;

	// Token: 0x040046EE RID: 18158
	[Token(Token = "0x40046EE")]
	[FieldOffset(Offset = "0x2DC")]
	public int startingMoney;

	// Token: 0x040046EF RID: 18159
	[Token(Token = "0x40046EF")]
	[FieldOffset(Offset = "0x2E0")]
	public int startingLockpicks;

	// Token: 0x040046F0 RID: 18160
	[Token(Token = "0x40046F0")]
	[FieldOffset(Offset = "0x2E4")]
	public Vector2 lockpickEffectivenessRange;

	// Token: 0x040046F1 RID: 18161
	[Token(Token = "0x40046F1")]
	[FieldOffset(Offset = "0x2EC")]
	public Vector2 lockpickSpeedRange;

	// Token: 0x040046F2 RID: 18162
	[Token(Token = "0x40046F2")]
	[FieldOffset(Offset = "0x2F4")]
	public Vector2 bargeDamageRange;

	// Token: 0x040046F3 RID: 18163
	[Token(Token = "0x40046F3")]
	[FieldOffset(Offset = "0x2FC")]
	public float baseMaxPlayerHealth;

	// Token: 0x040046F4 RID: 18164
	[Token(Token = "0x40046F4")]
	[FieldOffset(Offset = "0x300")]
	public float playerRecoveryRate;

	// Token: 0x040046F5 RID: 18165
	[Token(Token = "0x40046F5")]
	[FieldOffset(Offset = "0x304")]
	public float playerCombatSkill;

	// Token: 0x040046F6 RID: 18166
	[Token(Token = "0x40046F6")]
	[FieldOffset(Offset = "0x308")]
	public float playerCombatHeft;

	// Token: 0x040046F7 RID: 18167
	[Token(Token = "0x40046F7")]
	[FieldOffset(Offset = "0x30C")]
	public int defaultInventorySlots;

	// Token: 0x040046F8 RID: 18168
	[Token(Token = "0x40046F8")]
	[FieldOffset(Offset = "0x310")]
	public float incomingPlayerPhysicsDamageMultiplier;

	// Token: 0x040046F9 RID: 18169
	[Token(Token = "0x40046F9")]
	[FieldOffset(Offset = "0x314")]
	public float commonSyncDisksPer200Citizens;

	// Token: 0x040046FA RID: 18170
	[Token(Token = "0x40046FA")]
	[FieldOffset(Offset = "0x318")]
	public float mediumSyncDisksPer200Citizens;

	// Token: 0x040046FB RID: 18171
	[Token(Token = "0x40046FB")]
	[FieldOffset(Offset = "0x31C")]
	public float rareSyncDisksPer200Citizens;

	// Token: 0x040046FC RID: 18172
	[Token(Token = "0x40046FC")]
	[FieldOffset(Offset = "0x320")]
	public float veryRareSyncDisksPer200Citizens;

	// Token: 0x040046FD RID: 18173
	[Token(Token = "0x40046FD")]
	[FieldOffset(Offset = "0x324")]
	public int corpSabotageMoney;

	// Token: 0x040046FE RID: 18174
	[Token(Token = "0x40046FE")]
	[FieldOffset(Offset = "0x328")]
	public int corpSabotageManagementBonus;

	// Token: 0x040046FF RID: 18175
	[Token(Token = "0x40046FF")]
	[FieldOffset(Offset = "0x32C")]
	public int moneyForAddresses;

	// Token: 0x04004700 RID: 18176
	[Token(Token = "0x4004700")]
	[FieldOffset(Offset = "0x330")]
	public int moneyForNewLocations;

	// Token: 0x04004701 RID: 18177
	[Token(Token = "0x4004701")]
	[FieldOffset(Offset = "0x334")]
	public int moneyForAirDucts;

	// Token: 0x04004702 RID: 18178
	[Token(Token = "0x4004702")]
	[FieldOffset(Offset = "0x338")]
	public int moneyForPasscodes;

	// Token: 0x04004703 RID: 18179
	[Token(Token = "0x4004703")]
	[FieldOffset(Offset = "0x33C")]
	public int moneyForReading;

	// Token: 0x04004704 RID: 18180
	[Token(Token = "0x4004704")]
	[FieldOffset(Offset = "0x340")]
	public int moneyForStreetCleaning;

	// Token: 0x04004705 RID: 18181
	[Token(Token = "0x4004705")]
	[FieldOffset(Offset = "0x344")]
	public int passiveIncome;

	// Token: 0x04004706 RID: 18182
	[Token(Token = "0x4004706")]
	[FieldOffset(Offset = "0x348")]
	public float upgradeHeightModifier;

	// Token: 0x04004707 RID: 18183
	[Token(Token = "0x4004707")]
	[FieldOffset(Offset = "0x34C")]
	public float upgradeRunSpeed;

	// Token: 0x04004708 RID: 18184
	[Token(Token = "0x4004708")]
	[FieldOffset(Offset = "0x350")]
	public float upgradeReach;

	// Token: 0x04004709 RID: 18185
	[Token(Token = "0x4004709")]
	[FieldOffset(Offset = "0x354")]
	public float upgradeHealth;

	// Token: 0x0400470A RID: 18186
	[Token(Token = "0x400470A")]
	[FieldOffset(Offset = "0x358")]
	public float upgradeRegen;

	// Token: 0x0400470B RID: 18187
	[Token(Token = "0x400470B")]
	[FieldOffset(Offset = "0x35C")]
	public Vector2 legalInsuranceMultiplier;

	// Token: 0x0400470C RID: 18188
	[Token(Token = "0x400470C")]
	[FieldOffset(Offset = "0x364")]
	public int socialCreditForLostAndFound;

	// Token: 0x0400470D RID: 18189
	[Token(Token = "0x400470D")]
	[FieldOffset(Offset = "0x368")]
	public int socialCreditForSideJobs;

	// Token: 0x0400470E RID: 18190
	[Token(Token = "0x400470E")]
	[FieldOffset(Offset = "0x36C")]
	public int socialCreditForMurders;

	// Token: 0x0400470F RID: 18191
	[Token(Token = "0x400470F")]
	[FieldOffset(Offset = "0x370")]
	public AnimationCurve socialCreditLevelCurve;

	// Token: 0x04004710 RID: 18192
	[Token(Token = "0x4004710")]
	[FieldOffset(Offset = "0x378")]
	public float foodHotTime;

	// Token: 0x04004711 RID: 18193
	[Token(Token = "0x4004711")]
	[FieldOffset(Offset = "0x37C")]
	public float timeOfDeathAccuracy;

	// Token: 0x04004712 RID: 18194
	[Token(Token = "0x4004712")]
	[FieldOffset(Offset = "0x380")]
	public EvidencePreset retailItemSoldDiscovery;

	// Token: 0x04004713 RID: 18195
	[Token(Token = "0x4004713")]
	[FieldOffset(Offset = "0x388")]
	public EvidencePreset retailItemNoSoldDiscovery;

	// Token: 0x04004714 RID: 18196
	[Token(Token = "0x4004714")]
	[FieldOffset(Offset = "0x390")]
	public Material fistMaterial;

	// Token: 0x04004715 RID: 18197
	[Token(Token = "0x4004715")]
	[FieldOffset(Offset = "0x398")]
	public Material fingerUpperMaterial;

	// Token: 0x04004716 RID: 18198
	[Token(Token = "0x4004716")]
	[FieldOffset(Offset = "0x3A0")]
	public Material fingerLowerMaterial;

	// Token: 0x04004717 RID: 18199
	[Token(Token = "0x4004717")]
	[FieldOffset(Offset = "0x3A8")]
	public Material fingerTipMaterial;

	// Token: 0x04004718 RID: 18200
	[Token(Token = "0x4004718")]
	[FieldOffset(Offset = "0x3B0")]
	public Material thumbJointMaterial;

	// Token: 0x04004719 RID: 18201
	[Token(Token = "0x4004719")]
	[FieldOffset(Offset = "0x3B8")]
	public RigidbodyInterpolation interpolation;

	// Token: 0x0400471A RID: 18202
	[Token(Token = "0x400471A")]
	[FieldOffset(Offset = "0x3BC")]
	public float physicsOffTime;

	// Token: 0x0400471B RID: 18203
	[Token(Token = "0x400471B")]
	[FieldOffset(Offset = "0x3C0")]
	public PhysicsProfile defaultObjectPhysicsProfile;

	// Token: 0x0400471C RID: 18204
	[Token(Token = "0x400471C")]
	[FieldOffset(Offset = "0x3C8")]
	public int binTrashLimit;

	// Token: 0x0400471D RID: 18205
	[Token(Token = "0x400471D")]
	[FieldOffset(Offset = "0x3CC")]
	public int buildingCallLogMax;

	// Token: 0x0400471E RID: 18206
	[Token(Token = "0x400471E")]
	[FieldOffset(Offset = "0x3D0")]
	public float preSimSpeedMultiplier;

	// Token: 0x0400471F RID: 18207
	[Token(Token = "0x400471F")]
	[FieldOffset(Offset = "0x3D8")]
	public AnimationCurve walletCashAmountBasedOnWealth;

	// Token: 0x04004720 RID: 18208
	[Token(Token = "0x4004720")]
	[FieldOffset(Offset = "0x3E0")]
	public CharacterTrait creditCardTrait;

	// Token: 0x04004721 RID: 18209
	[Token(Token = "0x4004721")]
	[FieldOffset(Offset = "0x3E8")]
	public CharacterTrait donorCardTrait;

	// Token: 0x04004722 RID: 18210
	[Token(Token = "0x4004722")]
	[FieldOffset(Offset = "0x3F0")]
	public float successfulBlockThreshold;

	// Token: 0x04004723 RID: 18211
	[Token(Token = "0x4004723")]
	[FieldOffset(Offset = "0x3F4")]
	public float perfectBlockThreshold;

	// Token: 0x04004724 RID: 18212
	[Token(Token = "0x4004724")]
	[FieldOffset(Offset = "0x3F8")]
	public Vector2 baseAttackDelay;

	// Token: 0x04004725 RID: 18213
	[Token(Token = "0x4004725")]
	[FieldOffset(Offset = "0x400")]
	public Vector2 blockedAttackDelay;

	// Token: 0x04004726 RID: 18214
	[Token(Token = "0x4004726")]
	[FieldOffset(Offset = "0x408")]
	public Vector2 perfectBlockAttackDelay;

	// Token: 0x04004727 RID: 18215
	[Token(Token = "0x4004727")]
	[FieldOffset(Offset = "0x410")]
	public Vector2 koTimeRange;

	// Token: 0x04004728 RID: 18216
	[Token(Token = "0x4004728")]
	[FieldOffset(Offset = "0x418")]
	public float playerKOPunchForce;

	// Token: 0x04004729 RID: 18217
	[Token(Token = "0x4004729")]
	[FieldOffset(Offset = "0x41C")]
	public float koTimePass;

	// Token: 0x0400472A RID: 18218
	[Token(Token = "0x400472A")]
	[FieldOffset(Offset = "0x420")]
	public float restrainedTimer;

	// Token: 0x0400472B RID: 18219
	[Token(Token = "0x400472B")]
	[FieldOffset(Offset = "0x424")]
	public float takedownTimer;

	// Token: 0x0400472C RID: 18220
	[Token(Token = "0x400472C")]
	[FieldOffset(Offset = "0x428")]
	public float thrownGrenadeFuse;

	// Token: 0x0400472D RID: 18221
	[Token(Token = "0x400472D")]
	[FieldOffset(Offset = "0x42C")]
	public float proxyGrenadeFuse;

	// Token: 0x0400472E RID: 18222
	[Token(Token = "0x400472E")]
	[FieldOffset(Offset = "0x430")]
	public float bloodAmountMultiplier;

	// Token: 0x0400472F RID: 18223
	[Token(Token = "0x400472F")]
	[FieldOffset(Offset = "0x438")]
	public PlayerTransitionPreset successfulBlockTransition;

	// Token: 0x04004730 RID: 18224
	[Token(Token = "0x4004730")]
	[FieldOffset(Offset = "0x440")]
	public PlayerTransitionPreset unsuccessfulBlockTransition;

	// Token: 0x04004731 RID: 18225
	[Token(Token = "0x4004731")]
	[FieldOffset(Offset = "0x448")]
	public PlayerTransitionPreset counterTransition;

	// Token: 0x04004732 RID: 18226
	[Token(Token = "0x4004732")]
	[FieldOffset(Offset = "0x450")]
	public float maxPlayerLookAtTailingDistance;

	// Token: 0x04004733 RID: 18227
	[Token(Token = "0x4004733")]
	[FieldOffset(Offset = "0x454")]
	public float playerLookAtSpookRate;

	// Token: 0x04004734 RID: 18228
	[Token(Token = "0x4004734")]
	[FieldOffset(Offset = "0x458")]
	public float loseSpookedRate;

	// Token: 0x04004735 RID: 18229
	[Token(Token = "0x4004735")]
	[FieldOffset(Offset = "0x460")]
	public AnimationCurve screenCentreSpookCurve;

	// Token: 0x04004736 RID: 18230
	[Token(Token = "0x4004736")]
	[FieldOffset(Offset = "0x468")]
	public float muggingChance;

	// Token: 0x04004737 RID: 18231
	[Token(Token = "0x4004737")]
	[FieldOffset(Offset = "0x46C")]
	public float spatterRemovalTime;

	// Token: 0x04004738 RID: 18232
	[Token(Token = "0x4004738")]
	[FieldOffset(Offset = "0x470")]
	public float objectPositionResetTime;

	// Token: 0x04004739 RID: 18233
	[Token(Token = "0x4004739")]
	[FieldOffset(Offset = "0x474")]
	public float brokenWindowBoardTime;

	// Token: 0x0400473A RID: 18234
	[Token(Token = "0x400473A")]
	[FieldOffset(Offset = "0x478")]
	public float brokenWindowResetTime;

	// Token: 0x0400473B RID: 18235
	[Token(Token = "0x400473B")]
	[FieldOffset(Offset = "0x47C")]
	public int breakingWindowsFine;

	// Token: 0x0400473C RID: 18236
	[Token(Token = "0x400473C")]
	[FieldOffset(Offset = "0x480")]
	public int vandalismFineMultiplier;

	// Token: 0x0400473D RID: 18237
	[Token(Token = "0x400473D")]
	[FieldOffset(Offset = "0x484")]
	public float vandalismTimeout;

	// Token: 0x0400473E RID: 18238
	[Token(Token = "0x400473E")]
	[FieldOffset(Offset = "0x488")]
	public float illegalActionMinimumTime;

	// Token: 0x0400473F RID: 18239
	[Token(Token = "0x400473F")]
	[FieldOffset(Offset = "0x48C")]
	public int tamperGrace;

	// Token: 0x04004740 RID: 18240
	[Token(Token = "0x4004740")]
	[FieldOffset(Offset = "0x490")]
	public float physicsTamperDistance;

	// Token: 0x04004741 RID: 18241
	[Token(Token = "0x4004741")]
	[FieldOffset(Offset = "0x498")]
	public InteractablePreset fignerprintPreset;

	// Token: 0x04004742 RID: 18242
	[Token(Token = "0x4004742")]
	[FieldOffset(Offset = "0x4A0")]
	public float detainDelay;

	// Token: 0x04004743 RID: 18243
	[Token(Token = "0x4004743")]
	[FieldOffset(Offset = "0x4A4")]
	public float caseResultProcessTime;

	// Token: 0x04004744 RID: 18244
	[Token(Token = "0x4004744")]
	[FieldOffset(Offset = "0x4A8")]
	public int bestCaseVictimCount;

	// Token: 0x04004745 RID: 18245
	[Token(Token = "0x4004745")]
	[FieldOffset(Offset = "0x4AC")]
	public int worstCaseVictimCount;

	// Token: 0x04004746 RID: 18246
	[Token(Token = "0x4004746")]
	[FieldOffset(Offset = "0x4B0")]
	public AnimationCurve sideJobDifficultyRewardMultiplier;

	// Token: 0x04004747 RID: 18247
	[Token(Token = "0x4004747")]
	[FieldOffset(Offset = "0x4B8")]
	public List<FurniturePreset> secretLocationFurniture;

	// Token: 0x04004748 RID: 18248
	[Token(Token = "0x4004748")]
	[FieldOffset(Offset = "0x4C0")]
	public float stealTriggerChance;

	// Token: 0x04004749 RID: 18249
	[Token(Token = "0x4004749")]
	[FieldOffset(Offset = "0x4C4")]
	public int maxCases;

	// Token: 0x0400474A RID: 18250
	[Token(Token = "0x400474A")]
	[FieldOffset(Offset = "0x4C8")]
	public float crimeSceneCleanupDelay;

	// Token: 0x0400474B RID: 18251
	[Token(Token = "0x400474B")]
	[FieldOffset(Offset = "0x4CC")]
	public Vector2 missionPhotoMinMaxDistance;

	// Token: 0x0400474C RID: 18252
	[Token(Token = "0x400474C")]
	[FieldOffset(Offset = "0x4D8")]
	public AnimationCurve missionPhotoDistanceScoreCurve;

	// Token: 0x0400474D RID: 18253
	[Token(Token = "0x400474D")]
	[FieldOffset(Offset = "0x4E0")]
	public bool enableCoverUps;

	// Token: 0x0400474E RID: 18254
	[Token(Token = "0x400474E")]
	[FieldOffset(Offset = "0x4E4")]
	public int coverUpAvailableDuringCase;

	// Token: 0x0400474F RID: 18255
	[Token(Token = "0x400474F")]
	[FieldOffset(Offset = "0x4E8")]
	public float coverUpChance;

	// Token: 0x04004750 RID: 18256
	[Token(Token = "0x4004750")]
	[FieldOffset(Offset = "0x4EC")]
	public int coverUpReward;

	// Token: 0x04004751 RID: 18257
	[Token(Token = "0x4004751")]
	[FieldOffset(Offset = "0x4F0")]
	public float coverUpDelayTime;

	// Token: 0x04004752 RID: 18258
	[Token(Token = "0x4004752")]
	[FieldOffset(Offset = "0x4F4")]
	public int maximumFootprintsPerRoom;

	// Token: 0x04004753 RID: 18259
	[Token(Token = "0x4004753")]
	[FieldOffset(Offset = "0x4F8")]
	public Vector2 footprintScaleRange;

	// Token: 0x04004754 RID: 18260
	[Token(Token = "0x4004754")]
	[FieldOffset(Offset = "0x500")]
	public float stepDirtRemoval;

	// Token: 0x04004755 RID: 18261
	[Token(Token = "0x4004755")]
	[FieldOffset(Offset = "0x504")]
	public float stepBloodRemoval;

	// Token: 0x04004756 RID: 18262
	[Token(Token = "0x4004756")]
	[FieldOffset(Offset = "0x508")]
	public float outdoorStepDirtAccumulation;

	// Token: 0x04004757 RID: 18263
	[Token(Token = "0x4004757")]
	[FieldOffset(Offset = "0x510")]
	public InteractablePreset footprintPreset;

	// Token: 0x04004758 RID: 18264
	[Token(Token = "0x4004758")]
	[FieldOffset(Offset = "0x518")]
	public float crimeSceneSearchLength;

	// Token: 0x04004759 RID: 18265
	[Token(Token = "0x4004759")]
	[FieldOffset(Offset = "0x51C")]
	public float crimeSceneLength;

	// Token: 0x0400475A RID: 18266
	[Token(Token = "0x400475A")]
	[FieldOffset(Offset = "0x520")]
	public float smellTime;

	// Token: 0x0400475B RID: 18267
	[Token(Token = "0x400475B")]
	[FieldOffset(Offset = "0x528")]
	public List<Case.ResolveQuestion> murderResolveQuestions;

	// Token: 0x0400475C RID: 18268
	[Token(Token = "0x400475C")]
	[FieldOffset(Offset = "0x530")]
	public List<Case.ResolveQuestion> retirementResolveQuestions;

	// Token: 0x0400475D RID: 18269
	[Token(Token = "0x400475D")]
	[FieldOffset(Offset = "0x538")]
	public DialogPreset kidnapperCallTriggerDialog;

	// Token: 0x0400475E RID: 18270
	[Token(Token = "0x400475E")]
	[FieldOffset(Offset = "0x540")]
	public GameObject OScursor;

	// Token: 0x0400475F RID: 18271
	[Token(Token = "0x400475F")]
	[FieldOffset(Offset = "0x548")]
	public Sprite loadCursor;

	// Token: 0x04004760 RID: 18272
	[Token(Token = "0x4004760")]
	[FieldOffset(Offset = "0x550")]
	public float captureFoV;

	// Token: 0x04004761 RID: 18273
	[Token(Token = "0x4004761")]
	[FieldOffset(Offset = "0x554")]
	public float captureRange;

	// Token: 0x04004762 RID: 18274
	[Token(Token = "0x4004762")]
	[FieldOffset(Offset = "0x558")]
	public float humanCaptureRange;

	// Token: 0x04004763 RID: 18275
	[Token(Token = "0x4004763")]
	[FieldOffset(Offset = "0x55C")]
	public float captureInterval;

	// Token: 0x04004764 RID: 18276
	[Token(Token = "0x4004764")]
	[FieldOffset(Offset = "0x560")]
	public int cameraCaptureMemory;

	// Token: 0x04004765 RID: 18277
	[Token(Token = "0x4004765")]
	[FieldOffset(Offset = "0x564")]
	public float cameraCaptureMaxTime;

	// Token: 0x04004766 RID: 18278
	[Token(Token = "0x4004766")]
	[FieldOffset(Offset = "0x568")]
	public int maxCapturesPerFrame;

	// Token: 0x04004767 RID: 18279
	[Token(Token = "0x4004767")]
	[FieldOffset(Offset = "0x570")]
	public List<GameplayControls.SyncDiskColour> syncDiskColours;

	// Token: 0x04004768 RID: 18280
	[Token(Token = "0x4004768")]
	[FieldOffset(Offset = "0x578")]
	public int defaultDiskSlots;

	// Token: 0x04004769 RID: 18281
	[Token(Token = "0x4004769")]
	[FieldOffset(Offset = "0x57C")]
	public int mouseWheelEvidenceScrollSensitivity;

	// Token: 0x0400476A RID: 18282
	[Token(Token = "0x400476A")]
	[FieldOffset(Offset = "0x580")]
	public float indoorTemperature;

	// Token: 0x0400476B RID: 18283
	[Token(Token = "0x400476B")]
	[FieldOffset(Offset = "0x584")]
	public float airDuctTemperature;

	// Token: 0x0400476C RID: 18284
	[Token(Token = "0x400476C")]
	[FieldOffset(Offset = "0x588")]
	public float heatSourceTemperature;

	// Token: 0x0400476D RID: 18285
	[Token(Token = "0x400476D")]
	[FieldOffset(Offset = "0x590")]
	public AnimationCurve oscillatorX;

	// Token: 0x0400476E RID: 18286
	[Token(Token = "0x400476E")]
	[FieldOffset(Offset = "0x598")]
	public AnimationCurve oscillatorY;

	// Token: 0x0400476F RID: 18287
	[Token(Token = "0x400476F")]
	[FieldOffset(Offset = "0x5A0")]
	public Vector2 drunkOscillationSpeed;

	// Token: 0x04004770 RID: 18288
	[Token(Token = "0x4004770")]
	[FieldOffset(Offset = "0x5A8")]
	public AnimationCurve shiverFluctuation;

	// Token: 0x04004771 RID: 18289
	[Token(Token = "0x4004771")]
	[FieldOffset(Offset = "0x5B0")]
	public Vector2 shiverOscillationSpeed;

	// Token: 0x04004772 RID: 18290
	[Token(Token = "0x4004772")]
	[FieldOffset(Offset = "0x5B8")]
	public AnimationCurve drunkLensDistortOscillator;

	// Token: 0x04004773 RID: 18291
	[Token(Token = "0x4004773")]
	[FieldOffset(Offset = "0x5C0")]
	public Vector2 drunkLensDistortSpeed;

	// Token: 0x04004774 RID: 18292
	[Token(Token = "0x4004774")]
	[FieldOffset(Offset = "0x5C8")]
	public PlayerTransitionPreset tripTransition;

	// Token: 0x04004775 RID: 18293
	[Token(Token = "0x4004775")]
	[FieldOffset(Offset = "0x5D0")]
	public AnimationCurve headacheFluctuation;

	// Token: 0x04004776 RID: 18294
	[Token(Token = "0x4004776")]
	[FieldOffset(Offset = "0x5D8")]
	public SpatterPatternPreset bleedingSpatter;

	// Token: 0x04004777 RID: 18295
	[Token(Token = "0x4004777")]
	[FieldOffset(Offset = "0x5E0")]
	public float fallDamageMultiplier;

	// Token: 0x04004778 RID: 18296
	[Token(Token = "0x4004778")]
	[FieldOffset(Offset = "0x5E8")]
	public StatusPreset detainedStatus;

	// Token: 0x04004779 RID: 18297
	[Token(Token = "0x4004779")]
	[FieldOffset(Offset = "0x5F0")]
	public StatusPreset wantedInBuildingStatus;

	// Token: 0x0400477A RID: 18298
	[Token(Token = "0x400477A")]
	[FieldOffset(Offset = "0x5F8")]
	public float playerHungerRate;

	// Token: 0x0400477B RID: 18299
	[Token(Token = "0x400477B")]
	[FieldOffset(Offset = "0x5FC")]
	public float playerThirstRate;

	// Token: 0x0400477C RID: 18300
	[Token(Token = "0x400477C")]
	[FieldOffset(Offset = "0x600")]
	public float playerTirednessRate;

	// Token: 0x0400477D RID: 18301
	[Token(Token = "0x400477D")]
	[FieldOffset(Offset = "0x604")]
	public float playerEnergyRate;

	// Token: 0x0400477E RID: 18302
	[Token(Token = "0x400477E")]
	[FieldOffset(Offset = "0x608")]
	public float combatHitChanceOfBruised;

	// Token: 0x0400477F RID: 18303
	[Token(Token = "0x400477F")]
	[FieldOffset(Offset = "0x60C")]
	public float combatHitChanceOfBlackEye;

	// Token: 0x04004780 RID: 18304
	[Token(Token = "0x4004780")]
	[FieldOffset(Offset = "0x610")]
	public float combatHitChanceOfBrokenLeg;

	// Token: 0x04004781 RID: 18305
	[Token(Token = "0x4004781")]
	[FieldOffset(Offset = "0x614")]
	public float combatHitChanceOfBleeding;

	// Token: 0x04004782 RID: 18306
	[Token(Token = "0x4004782")]
	[FieldOffset(Offset = "0x618")]
	public Vector2 propertyValueRange;

	// Token: 0x04004783 RID: 18307
	[Token(Token = "0x4004783")]
	[FieldOffset(Offset = "0x620")]
	public AnimationCurve propertyValueCurve;

	// Token: 0x04004784 RID: 18308
	[Token(Token = "0x4004784")]
	[FieldOffset(Offset = "0x628")]
	public int defaultLoanAmount;

	// Token: 0x04004785 RID: 18309
	[Token(Token = "0x4004785")]
	[FieldOffset(Offset = "0x62C")]
	public int defaultLoanExtra;

	// Token: 0x04004786 RID: 18310
	[Token(Token = "0x4004786")]
	[FieldOffset(Offset = "0x630")]
	public int defaultLoanRepayment;

	// Token: 0x04004787 RID: 18311
	[Token(Token = "0x4004787")]
	[FieldOffset(Offset = "0x634")]
	public float loiteringCommentThreshold;

	// Token: 0x04004788 RID: 18312
	[Token(Token = "0x4004788")]
	[FieldOffset(Offset = "0x638")]
	public float loiteringConfrontThreshold;

	// Token: 0x04004789 RID: 18313
	[Token(Token = "0x4004789")]
	[FieldOffset(Offset = "0x63C")]
	public float loiteringTrespassThreshold;

	// Token: 0x0400478A RID: 18314
	[Token(Token = "0x400478A")]
	[FieldOffset(Offset = "0x640")]
	public float loiteringPurchaseResetValue;

	// Token: 0x0400478B RID: 18315
	[Token(Token = "0x400478B")]
	[FieldOffset(Offset = "0x648")]
	public DDSScope humanScope;

	// Token: 0x0400478C RID: 18316
	[Token(Token = "0x400478C")]
	[FieldOffset(Offset = "0x650")]
	public DDSScope itemScope;

	// Token: 0x0400478D RID: 18317
	[Token(Token = "0x400478D")]
	[FieldOffset(Offset = "0x658")]
	public DDSScope murderScope;

	// Token: 0x0400478E RID: 18318
	[Token(Token = "0x400478E")]
	[FieldOffset(Offset = "0x660")]
	public DDSScope locationScope;

	// Token: 0x0400478F RID: 18319
	[Token(Token = "0x400478F")]
	[FieldOffset(Offset = "0x668")]
	public DDSScope evidenceScope;

	// Token: 0x04004790 RID: 18320
	[Token(Token = "0x4004790")]
	[FieldOffset(Offset = "0x670")]
	public DDSScope sideJobScope;

	// Token: 0x04004791 RID: 18321
	[Token(Token = "0x4004791")]
	[FieldOffset(Offset = "0x678")]
	public DDSScope syncDiskScope;

	// Token: 0x04004792 RID: 18322
	[Token(Token = "0x4004792")]
	[FieldOffset(Offset = "0x680")]
	public DDSScope groupScope;

	// Token: 0x04004793 RID: 18323
	[Token(Token = "0x4004793")]
	[FieldOffset(Offset = "0x0")]
	private static GameplayControls _instance;

	// Token: 0x020008BA RID: 2234
	[Token(Token = "0x20008BA")]
	[Serializable]
	public class SyncDiskColour
	{
		// Token: 0x06002A3C RID: 10812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A3C")]
		[Address(RVA = "0xCBC2A0", Offset = "0xCBB2A0", VA = "0x180CBC2A0")]
		public SyncDiskColour()
		{
		}

		// Token: 0x04004794 RID: 18324
		[Token(Token = "0x4004794")]
		[FieldOffset(Offset = "0x10")]
		public SyncDiskPreset.Manufacturer category;

		// Token: 0x04004795 RID: 18325
		[Token(Token = "0x4004795")]
		[FieldOffset(Offset = "0x14")]
		public Color mainColour;

		// Token: 0x04004796 RID: 18326
		[Token(Token = "0x4004796")]
		[FieldOffset(Offset = "0x24")]
		public Color colour1;

		// Token: 0x04004797 RID: 18327
		[Token(Token = "0x4004797")]
		[FieldOffset(Offset = "0x34")]
		public Color colour2;

		// Token: 0x04004798 RID: 18328
		[Token(Token = "0x4004798")]
		[FieldOffset(Offset = "0x44")]
		public Color colour3;
	}
}
