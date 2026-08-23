using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008C3 RID: 2243
[Token(Token = "0x20008C3")]
public class RoutineControls : MonoBehaviour
{
	// Token: 0x17000156 RID: 342
	// (get) Token: 0x06002A4C RID: 10828 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000156")]
	public static RoutineControls Instance
	{
		[Token(Token = "0x6002A4C")]
		[Address(RVA = "0xCBE580", Offset = "0xCBD580", VA = "0x180CBE580")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002A4D RID: 10829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A4D")]
	[Address(RVA = "0xCBE5C0", Offset = "0xCBD5C0", VA = "0x180CBE5C0")]
	private void Awake()
	{
	}

	// Token: 0x06002A4E RID: 10830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A4E")]
	[Address(RVA = "0xCBE910", Offset = "0xCBD910", VA = "0x180CBE910")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002A4F RID: 10831 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002A4F")]
	[Address(RVA = "0xCBEB20", Offset = "0xCBDB20", VA = "0x180CBEB20")]
	public RoutineControls()
	{
	}

	// Token: 0x040049BF RID: 18879
	[Token(Token = "0x40049BF")]
	[FieldOffset(Offset = "0x0")]
	private static RoutineControls _instance;

	// Token: 0x040049C0 RID: 18880
	[Token(Token = "0x40049C0")]
	[FieldOffset(Offset = "0x18")]
	public float hungerRate;

	// Token: 0x040049C1 RID: 18881
	[Token(Token = "0x40049C1")]
	[FieldOffset(Offset = "0x1C")]
	public float thirstRate;

	// Token: 0x040049C2 RID: 18882
	[Token(Token = "0x40049C2")]
	[FieldOffset(Offset = "0x20")]
	public float tirednessRate;

	// Token: 0x040049C3 RID: 18883
	[Token(Token = "0x40049C3")]
	[FieldOffset(Offset = "0x24")]
	public float energyRate;

	// Token: 0x040049C4 RID: 18884
	[Token(Token = "0x40049C4")]
	[FieldOffset(Offset = "0x28")]
	public float boredemRate;

	// Token: 0x040049C5 RID: 18885
	[Token(Token = "0x40049C5")]
	[FieldOffset(Offset = "0x2C")]
	public float choresRate;

	// Token: 0x040049C6 RID: 18886
	[Token(Token = "0x40049C6")]
	[FieldOffset(Offset = "0x30")]
	public float hygeieneRate;

	// Token: 0x040049C7 RID: 18887
	[Token(Token = "0x40049C7")]
	[FieldOffset(Offset = "0x34")]
	public float bladderRate;

	// Token: 0x040049C8 RID: 18888
	[Token(Token = "0x40049C8")]
	[FieldOffset(Offset = "0x38")]
	public float drunkRate;

	// Token: 0x040049C9 RID: 18889
	[Token(Token = "0x40049C9")]
	[FieldOffset(Offset = "0x3C")]
	public float breathRate;

	// Token: 0x040049CA RID: 18890
	[Token(Token = "0x40049CA")]
	[FieldOffset(Offset = "0x40")]
	public float idleSoundRate;

	// Token: 0x040049CB RID: 18891
	[Token(Token = "0x40049CB")]
	[FieldOffset(Offset = "0x44")]
	public float poisonRate;

	// Token: 0x040049CC RID: 18892
	[Token(Token = "0x40049CC")]
	[FieldOffset(Offset = "0x48")]
	public float blindedRate;

	// Token: 0x040049CD RID: 18893
	[Token(Token = "0x40049CD")]
	[FieldOffset(Offset = "0x4C")]
	public float commericalDecisionMPTimeSpent;

	// Token: 0x040049CE RID: 18894
	[Token(Token = "0x40049CE")]
	[FieldOffset(Offset = "0x50")]
	public float commericalDecisionMPlayerSameBuilding;

	// Token: 0x040049CF RID: 18895
	[Token(Token = "0x40049CF")]
	[FieldOffset(Offset = "0x54")]
	public float commericalDecisionMPlayerSameLocation;

	// Token: 0x040049D0 RID: 18896
	[Token(Token = "0x40049D0")]
	[FieldOffset(Offset = "0x58")]
	public float commericalDecisionMPlayerElsewhere;

	// Token: 0x040049D1 RID: 18897
	[Token(Token = "0x40049D1")]
	[FieldOffset(Offset = "0x60")]
	public AIGoalPreset workGoal;

	// Token: 0x040049D2 RID: 18898
	[Token(Token = "0x40049D2")]
	[FieldOffset(Offset = "0x68")]
	public AIGoalPreset answerDoorGoal;

	// Token: 0x040049D3 RID: 18899
	[Token(Token = "0x40049D3")]
	[FieldOffset(Offset = "0x70")]
	public AIGoalPreset awakenGoal;

	// Token: 0x040049D4 RID: 18900
	[Token(Token = "0x40049D4")]
	[FieldOffset(Offset = "0x78")]
	public AIGoalPreset sleepGoal;

	// Token: 0x040049D5 RID: 18901
	[Token(Token = "0x40049D5")]
	[FieldOffset(Offset = "0x80")]
	public AIGoalPreset patrolGoal;

	// Token: 0x040049D6 RID: 18902
	[Token(Token = "0x40049D6")]
	[FieldOffset(Offset = "0x88")]
	public AIGoalPreset fleeGoal;

	// Token: 0x040049D7 RID: 18903
	[Token(Token = "0x40049D7")]
	[FieldOffset(Offset = "0x90")]
	public AIGoalPreset investigateGoal;

	// Token: 0x040049D8 RID: 18904
	[Token(Token = "0x40049D8")]
	[FieldOffset(Offset = "0x98")]
	public AIGoalPreset postJob;

	// Token: 0x040049D9 RID: 18905
	[Token(Token = "0x40049D9")]
	[FieldOffset(Offset = "0xA0")]
	public AIGoalPreset enforcerResponse;

	// Token: 0x040049DA RID: 18906
	[Token(Token = "0x40049DA")]
	[FieldOffset(Offset = "0xA8")]
	public AIGoalPreset enforcerGuardDuty;

	// Token: 0x040049DB RID: 18907
	[Token(Token = "0x40049DB")]
	[FieldOffset(Offset = "0xB0")]
	public AIGoalPreset makeSpecificCall;

	// Token: 0x040049DC RID: 18908
	[Token(Token = "0x40049DC")]
	[FieldOffset(Offset = "0xB8")]
	public AIGoalPreset layLow;

	// Token: 0x040049DD RID: 18909
	[Token(Token = "0x40049DD")]
	[FieldOffset(Offset = "0xC0")]
	public AIGoalPreset kidnapperCollectRansom;

	// Token: 0x040049DE RID: 18910
	[Token(Token = "0x40049DE")]
	[FieldOffset(Offset = "0xC8")]
	public AIGoalPreset kidnapperFreeVictim;

	// Token: 0x040049DF RID: 18911
	[Token(Token = "0x40049DF")]
	[FieldOffset(Offset = "0xD0")]
	public AIActionPreset searchArea;

	// Token: 0x040049E0 RID: 18912
	[Token(Token = "0x40049E0")]
	[FieldOffset(Offset = "0xD8")]
	public AIActionPreset searchAreaEnforcer;

	// Token: 0x040049E1 RID: 18913
	[Token(Token = "0x40049E1")]
	[FieldOffset(Offset = "0xE0")]
	public AIActionPreset hangUp;

	// Token: 0x040049E2 RID: 18914
	[Token(Token = "0x40049E2")]
	[FieldOffset(Offset = "0xE8")]
	public AIActionPreset raiseAlarm;

	// Token: 0x040049E3 RID: 18915
	[Token(Token = "0x40049E3")]
	[FieldOffset(Offset = "0xF0")]
	public AIActionPreset sleep;

	// Token: 0x040049E4 RID: 18916
	[Token(Token = "0x40049E4")]
	[FieldOffset(Offset = "0xF8")]
	public AIActionPreset audioFocus;

	// Token: 0x040049E5 RID: 18917
	[Token(Token = "0x40049E5")]
	[FieldOffset(Offset = "0x100")]
	public AIActionPreset mainLightOn;

	// Token: 0x040049E6 RID: 18918
	[Token(Token = "0x40049E6")]
	[FieldOffset(Offset = "0x108")]
	public AIActionPreset mainLightOff;

	// Token: 0x040049E7 RID: 18919
	[Token(Token = "0x40049E7")]
	[FieldOffset(Offset = "0x110")]
	public AIActionPreset secondaryLightOn;

	// Token: 0x040049E8 RID: 18920
	[Token(Token = "0x40049E8")]
	[FieldOffset(Offset = "0x118")]
	public AIActionPreset secondaryLightOff;

	// Token: 0x040049E9 RID: 18921
	[Token(Token = "0x40049E9")]
	[FieldOffset(Offset = "0x120")]
	public AIActionPreset lockDoor;

	// Token: 0x040049EA RID: 18922
	[Token(Token = "0x40049EA")]
	[FieldOffset(Offset = "0x128")]
	public AIActionPreset unlockDoor;

	// Token: 0x040049EB RID: 18923
	[Token(Token = "0x40049EB")]
	[FieldOffset(Offset = "0x130")]
	public AIActionPreset openDoor;

	// Token: 0x040049EC RID: 18924
	[Token(Token = "0x40049EC")]
	[FieldOffset(Offset = "0x138")]
	public AIActionPreset closeDoor;

	// Token: 0x040049ED RID: 18925
	[Token(Token = "0x40049ED")]
	[FieldOffset(Offset = "0x140")]
	public AIActionPreset knockOnDoor;

	// Token: 0x040049EE RID: 18926
	[Token(Token = "0x40049EE")]
	[FieldOffset(Offset = "0x148")]
	public AIActionPreset openLocker;

	// Token: 0x040049EF RID: 18927
	[Token(Token = "0x40049EF")]
	[FieldOffset(Offset = "0x150")]
	public AIActionPreset closeLocker;

	// Token: 0x040049F0 RID: 18928
	[Token(Token = "0x40049F0")]
	[FieldOffset(Offset = "0x158")]
	public AIActionPreset hide;

	// Token: 0x040049F1 RID: 18929
	[Token(Token = "0x40049F1")]
	[FieldOffset(Offset = "0x160")]
	public AIActionPreset pullPlayerFromHiding;

	// Token: 0x040049F2 RID: 18930
	[Token(Token = "0x40049F2")]
	[FieldOffset(Offset = "0x168")]
	public AIActionPreset answerTelephone;

	// Token: 0x040049F3 RID: 18931
	[Token(Token = "0x40049F3")]
	[FieldOffset(Offset = "0x170")]
	public AIActionPreset makeCall;

	// Token: 0x040049F4 RID: 18932
	[Token(Token = "0x40049F4")]
	[FieldOffset(Offset = "0x178")]
	public AIActionPreset takeMoney;

	// Token: 0x040049F5 RID: 18933
	[Token(Token = "0x40049F5")]
	[FieldOffset(Offset = "0x180")]
	public AIActionPreset pickupFromFloor;

	// Token: 0x040049F6 RID: 18934
	[Token(Token = "0x40049F6")]
	[FieldOffset(Offset = "0x188")]
	public AIActionPreset putBack;

	// Token: 0x040049F7 RID: 18935
	[Token(Token = "0x40049F7")]
	[FieldOffset(Offset = "0x190")]
	public AIActionPreset turnOnMusic;

	// Token: 0x040049F8 RID: 18936
	[Token(Token = "0x40049F8")]
	[FieldOffset(Offset = "0x198")]
	public AIActionPreset disposal;

	// Token: 0x040049F9 RID: 18937
	[Token(Token = "0x40049F9")]
	[FieldOffset(Offset = "0x1A0")]
	public AIActionPreset bargeDoor;

	// Token: 0x040049FA RID: 18938
	[Token(Token = "0x40049FA")]
	[FieldOffset(Offset = "0x1A8")]
	public AIActionPreset standAgainstWall;

	// Token: 0x040049FB RID: 18939
	[Token(Token = "0x40049FB")]
	[FieldOffset(Offset = "0x1B0")]
	public AIActionPreset standGuard;

	// Token: 0x040049FC RID: 18940
	[Token(Token = "0x40049FC")]
	[FieldOffset(Offset = "0x1B8")]
	public AIActionPreset putUpPoliceTape;

	// Token: 0x040049FD RID: 18941
	[Token(Token = "0x40049FD")]
	[FieldOffset(Offset = "0x1C0")]
	public AIActionPreset putUpStreetCrimeScene;

	// Token: 0x040049FE RID: 18942
	[Token(Token = "0x40049FE")]
	[FieldOffset(Offset = "0x1C8")]
	public AIActionPreset getHandIn;

	// Token: 0x040049FF RID: 18943
	[Token(Token = "0x40049FF")]
	[FieldOffset(Offset = "0x1D0")]
	public AIActionPreset AIPutDownItem;

	// Token: 0x04004A00 RID: 18944
	[Token(Token = "0x4004A00")]
	[FieldOffset(Offset = "0x1D8")]
	public AIActionPreset AIPickUpItem;

	// Token: 0x04004A01 RID: 18945
	[Token(Token = "0x4004A01")]
	[FieldOffset(Offset = "0x1E0")]
	public AIActionPreset purchaseItem;

	// Token: 0x04004A02 RID: 18946
	[Token(Token = "0x4004A02")]
	[FieldOffset(Offset = "0x1E8")]
	public AIActionPreset takeConsumable;

	// Token: 0x04004A03 RID: 18947
	[Token(Token = "0x4004A03")]
	[FieldOffset(Offset = "0x1F0")]
	public AIActionPreset sit;

	// Token: 0x04004A04 RID: 18948
	[Token(Token = "0x4004A04")]
	[FieldOffset(Offset = "0x1F8")]
	public AIActionPreset lookBehindSpooked;

	// Token: 0x04004A05 RID: 18949
	[Token(Token = "0x4004A05")]
	[FieldOffset(Offset = "0x200")]
	public AIActionPreset mugging;

	// Token: 0x04004A06 RID: 18950
	[Token(Token = "0x4004A06")]
	[FieldOffset(Offset = "0x208")]
	public AIActionPreset fameAndFortune;

	// Token: 0x04004A07 RID: 18951
	[Token(Token = "0x4004A07")]
	[FieldOffset(Offset = "0x210")]
	public AIActionPreset loiterConfront;

	// Token: 0x04004A08 RID: 18952
	[Token(Token = "0x4004A08")]
	[FieldOffset(Offset = "0x218")]
	public AIActionPreset takeFirstPersonItem;

	// Token: 0x04004A09 RID: 18953
	[Token(Token = "0x4004A09")]
	[FieldOffset(Offset = "0x220")]
	public AIActionPreset cleanUp;

	// Token: 0x04004A0A RID: 18954
	[Token(Token = "0x4004A0A")]
	[FieldOffset(Offset = "0x228")]
	public AIGoalPreset findDeadBody;

	// Token: 0x04004A0B RID: 18955
	[Token(Token = "0x4004A0B")]
	[FieldOffset(Offset = "0x230")]
	public AIGoalPreset smellDeadBody;

	// Token: 0x04004A0C RID: 18956
	[Token(Token = "0x4004A0C")]
	[FieldOffset(Offset = "0x238")]
	public AIGoalPreset mourn;

	// Token: 0x04004A0D RID: 18957
	[Token(Token = "0x4004A0D")]
	[FieldOffset(Offset = "0x240")]
	public AIGoalPreset stealItem;

	// Token: 0x04004A0E RID: 18958
	[Token(Token = "0x4004A0E")]
	[FieldOffset(Offset = "0x248")]
	public AIGoalPreset exitBuilding;

	// Token: 0x04004A0F RID: 18959
	[Token(Token = "0x4004A0F")]
	[FieldOffset(Offset = "0x250")]
	public AIGoalPreset missionMeetUpSpecific;

	// Token: 0x04004A10 RID: 18960
	[Token(Token = "0x4004A10")]
	[FieldOffset(Offset = "0x258")]
	public AIGoalPreset giveSelfUp;

	// Token: 0x04004A11 RID: 18961
	[Token(Token = "0x4004A11")]
	[FieldOffset(Offset = "0x260")]
	public AIGoalPreset meetFood;

	// Token: 0x04004A12 RID: 18962
	[Token(Token = "0x4004A12")]
	[FieldOffset(Offset = "0x268")]
	public GroupPreset meetUpFoodMission;

	// Token: 0x04004A13 RID: 18963
	[Token(Token = "0x4004A13")]
	[FieldOffset(Offset = "0x270")]
	public AIGoalPreset toGoGoal;

	// Token: 0x04004A14 RID: 18964
	[Token(Token = "0x4004A14")]
	[FieldOffset(Offset = "0x278")]
	public AIGoalPreset toGoWalkGoal;

	// Token: 0x04004A15 RID: 18965
	[Token(Token = "0x4004A15")]
	[FieldOffset(Offset = "0x280")]
	public BuildingPreset cityHall;

	// Token: 0x04004A16 RID: 18966
	[Token(Token = "0x4004A16")]
	[FieldOffset(Offset = "0x288")]
	public int salesRecordsThreshold;
}
