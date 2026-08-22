using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000769 RID: 1897
[Token(Token = "0x2000769")]
public class AudioEvent : SoCustomComparison
{
	// Token: 0x060028FD RID: 10493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028FD")]
	[Address(RVA = "0xC67440", Offset = "0xC66440", VA = "0x180C67440")]
	private void OnGUIDValueChangedCallback()
	{
	}

	// Token: 0x060028FE RID: 10494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60028FE")]
	[Address(RVA = "0xC676D0", Offset = "0xC666D0", VA = "0x180C676D0")]
	public AudioEvent()
	{
	}

	// Token: 0x04003640 RID: 13888
	[Token(Token = "0x4003640")]
	[FieldOffset(Offset = "0x20")]
	public string guid;

	// Token: 0x04003641 RID: 13889
	[Token(Token = "0x4003641")]
	[FieldOffset(Offset = "0x28")]
	public bool disableOcclusion;

	// Token: 0x04003642 RID: 13890
	[Token(Token = "0x4003642")]
	[FieldOffset(Offset = "0x29")]
	public bool debug;

	// Token: 0x04003643 RID: 13891
	[Token(Token = "0x4003643")]
	[FieldOffset(Offset = "0x2A")]
	public bool isDummyEvent;

	// Token: 0x04003644 RID: 13892
	[Token(Token = "0x4003644")]
	[FieldOffset(Offset = "0x2B")]
	public bool isLicensed;

	// Token: 0x04003645 RID: 13893
	[Token(Token = "0x4003645")]
	[FieldOffset(Offset = "0x2C")]
	public bool pauseWhenGameIsPaused;

	// Token: 0x04003646 RID: 13894
	[Token(Token = "0x4003646")]
	[FieldOffset(Offset = "0x2D")]
	public bool disabled;

	// Token: 0x04003647 RID: 13895
	[Token(Token = "0x4003647")]
	[FieldOffset(Offset = "0x2E")]
	public bool canPenetrateWalls;

	// Token: 0x04003648 RID: 13896
	[Token(Token = "0x4003648")]
	[FieldOffset(Offset = "0x2F")]
	public bool canPenetrateFloors;

	// Token: 0x04003649 RID: 13897
	[Token(Token = "0x4003649")]
	[FieldOffset(Offset = "0x30")]
	public bool canPenetrateCeilings;

	// Token: 0x0400364A RID: 13898
	[Token(Token = "0x400364A")]
	[FieldOffset(Offset = "0x31")]
	public bool overrideMaximumLoops;

	// Token: 0x0400364B RID: 13899
	[Token(Token = "0x400364B")]
	[FieldOffset(Offset = "0x34")]
	public int overriddenMaxLoops;

	// Token: 0x0400364C RID: 13900
	[Token(Token = "0x400364C")]
	[FieldOffset(Offset = "0x38")]
	public bool overrideOcclusionModifier;

	// Token: 0x0400364D RID: 13901
	[Token(Token = "0x400364D")]
	[FieldOffset(Offset = "0x3C")]
	public float occlusionUnitVolumeModifier;

	// Token: 0x0400364E RID: 13902
	[Token(Token = "0x400364E")]
	[FieldOffset(Offset = "0x40")]
	public bool overrideOpenDoorOcclusion;

	// Token: 0x0400364F RID: 13903
	[Token(Token = "0x400364F")]
	[FieldOffset(Offset = "0x44")]
	public int openDoorOcclusionUnits;

	// Token: 0x04003650 RID: 13904
	[Token(Token = "0x4003650")]
	[FieldOffset(Offset = "0x48")]
	public bool overrideClosedDoorOcclusion;

	// Token: 0x04003651 RID: 13905
	[Token(Token = "0x4003651")]
	[FieldOffset(Offset = "0x4C")]
	public int closedDoorOcclusionUnits;

	// Token: 0x04003652 RID: 13906
	[Token(Token = "0x4003652")]
	[FieldOffset(Offset = "0x50")]
	public bool overrideWindowOcclusion;

	// Token: 0x04003653 RID: 13907
	[Token(Token = "0x4003653")]
	[FieldOffset(Offset = "0x54")]
	public int windowOcclusionUnits;

	// Token: 0x04003654 RID: 13908
	[Token(Token = "0x4003654")]
	[FieldOffset(Offset = "0x58")]
	public bool overrideWallOcclusion;

	// Token: 0x04003655 RID: 13909
	[Token(Token = "0x4003655")]
	[FieldOffset(Offset = "0x5C")]
	public int wallOcclusionUnits;

	// Token: 0x04003656 RID: 13910
	[Token(Token = "0x4003656")]
	[FieldOffset(Offset = "0x60")]
	public bool overrideCeilingOcclusion;

	// Token: 0x04003657 RID: 13911
	[Token(Token = "0x4003657")]
	[FieldOffset(Offset = "0x64")]
	public int ceilingOcclusionUnits;

	// Token: 0x04003658 RID: 13912
	[Token(Token = "0x4003658")]
	[FieldOffset(Offset = "0x68")]
	public bool overrideFloorOcclusion;

	// Token: 0x04003659 RID: 13913
	[Token(Token = "0x4003659")]
	[FieldOffset(Offset = "0x6C")]
	public int floorOcclusionUnits;

	// Token: 0x0400365A RID: 13914
	[Token(Token = "0x400365A")]
	[FieldOffset(Offset = "0x70")]
	public bool forceVolumeLevelFadeTime;

	// Token: 0x0400365B RID: 13915
	[Token(Token = "0x400365B")]
	[FieldOffset(Offset = "0x74")]
	public float volumeLevelFadeTime;

	// Token: 0x0400365C RID: 13916
	[Token(Token = "0x400365C")]
	[FieldOffset(Offset = "0x78")]
	public bool canBeSuspicious;

	// Token: 0x0400365D RID: 13917
	[Token(Token = "0x400365D")]
	[FieldOffset(Offset = "0x79")]
	public bool alwaysSuspicious;

	// Token: 0x0400365E RID: 13918
	[Token(Token = "0x400365E")]
	[FieldOffset(Offset = "0x7A")]
	public bool suspiciousIfTresspassing;

	// Token: 0x0400365F RID: 13919
	[Token(Token = "0x400365F")]
	[FieldOffset(Offset = "0x7B")]
	public bool suspiciousIfCantSeeSoundMaker;

	// Token: 0x04003660 RID: 13920
	[Token(Token = "0x4003660")]
	[FieldOffset(Offset = "0x7C")]
	public bool onlySuspiciousIfEmptyAddress;

	// Token: 0x04003661 RID: 13921
	[Token(Token = "0x4003661")]
	[FieldOffset(Offset = "0x7D")]
	public bool onlySuspiciousIfNotEnforcer;

	// Token: 0x04003662 RID: 13922
	[Token(Token = "0x4003662")]
	[FieldOffset(Offset = "0x80")]
	public int suspiciousIfCitizenCount;

	// Token: 0x04003663 RID: 13923
	[Token(Token = "0x4003663")]
	[FieldOffset(Offset = "0x84")]
	public bool urgentResponse;

	// Token: 0x04003664 RID: 13924
	[Token(Token = "0x4003664")]
	[FieldOffset(Offset = "0x88")]
	public float audioFocus;

	// Token: 0x04003665 RID: 13925
	[Token(Token = "0x4003665")]
	[FieldOffset(Offset = "0x8C")]
	public bool forceOutlineForLoopIfPlayerTrespassing;

	// Token: 0x04003666 RID: 13926
	[Token(Token = "0x4003666")]
	[FieldOffset(Offset = "0x90")]
	public AudioEvent.MemoryTag citizenMemoryTag;

	// Token: 0x04003667 RID: 13927
	[Token(Token = "0x4003667")]
	[FieldOffset(Offset = "0x94")]
	public float spookValue;

	// Token: 0x04003668 RID: 13928
	[Token(Token = "0x4003668")]
	[FieldOffset(Offset = "0x98")]
	public bool noSpookIfEnforcer;

	// Token: 0x04003669 RID: 13929
	[Token(Token = "0x4003669")]
	[FieldOffset(Offset = "0x9C")]
	public float awakenChance;

	// Token: 0x0400366A RID: 13930
	[Token(Token = "0x400366A")]
	[FieldOffset(Offset = "0xA0")]
	public float actualSoundRange;

	// Token: 0x0400366B RID: 13931
	[Token(Token = "0x400366B")]
	[FieldOffset(Offset = "0xA4")]
	public float hearingRange;

	// Token: 0x0400366C RID: 13932
	[Token(Token = "0x400366C")]
	[FieldOffset(Offset = "0xA8")]
	public float stealthModeModifier;

	// Token: 0x0400366D RID: 13933
	[Token(Token = "0x400366D")]
	[FieldOffset(Offset = "0xAC")]
	public float runModifier;

	// Token: 0x0400366E RID: 13934
	[Token(Token = "0x400366E")]
	[FieldOffset(Offset = "0xB0")]
	public bool canDanceTo;

	// Token: 0x0400366F RID: 13935
	[Token(Token = "0x400366F")]
	[FieldOffset(Offset = "0xB4")]
	public float masterVolumeScale;

	// Token: 0x04003670 RID: 13936
	[Token(Token = "0x4003670")]
	[FieldOffset(Offset = "0xB8")]
	public bool modifyBasedOnSurface;

	// Token: 0x04003671 RID: 13937
	[Token(Token = "0x4003671")]
	[FieldOffset(Offset = "0xBC")]
	public float concreteHearingRangeModifier;

	// Token: 0x04003672 RID: 13938
	[Token(Token = "0x4003672")]
	[FieldOffset(Offset = "0xC0")]
	public float woodHearingRangeModifier;

	// Token: 0x04003673 RID: 13939
	[Token(Token = "0x4003673")]
	[FieldOffset(Offset = "0xC4")]
	public float carpetHearingRangeModifier;

	// Token: 0x04003674 RID: 13940
	[Token(Token = "0x4003674")]
	[FieldOffset(Offset = "0xC8")]
	public float tileHearingRangeModifier;

	// Token: 0x04003675 RID: 13941
	[Token(Token = "0x4003675")]
	[FieldOffset(Offset = "0xCC")]
	public float plasterHearingRangeModifier;

	// Token: 0x04003676 RID: 13942
	[Token(Token = "0x4003676")]
	[FieldOffset(Offset = "0xD0")]
	public float fabricHearingRangeModifier;

	// Token: 0x04003677 RID: 13943
	[Token(Token = "0x4003677")]
	[FieldOffset(Offset = "0xD4")]
	public float metalHearingRangeModifier;

	// Token: 0x04003678 RID: 13944
	[Token(Token = "0x4003678")]
	[FieldOffset(Offset = "0xD8")]
	public float glassHearingRangeModifier;

	// Token: 0x04003679 RID: 13945
	[Token(Token = "0x4003679")]
	[FieldOffset(Offset = "0xDC")]
	public bool enableVibrationOnPlay;

	// Token: 0x0400367A RID: 13946
	[Token(Token = "0x400367A")]
	[FieldOffset(Offset = "0xDD")]
	public bool disableForPS5;

	// Token: 0x0400367B RID: 13947
	[Token(Token = "0x400367B")]
	[FieldOffset(Offset = "0xE0")]
	public List<InputController.ControllerVibration> vibrationSetup;

	// Token: 0x0200076A RID: 1898
	[Token(Token = "0x200076A")]
	public enum MemoryTag
	{
		// Token: 0x0400367D RID: 13949
		[Token(Token = "0x400367D")]
		none,
		// Token: 0x0400367E RID: 13950
		[Token(Token = "0x400367E")]
		gunshot,
		// Token: 0x0400367F RID: 13951
		[Token(Token = "0x400367F")]
		scream
	}
}
