using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000121 RID: 289
[Token(Token = "0x2000121")]
public class MurderController : MonoBehaviour
{
	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06000846 RID: 2118 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000031")]
	public static MurderController Instance
	{
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x4B7080", Offset = "0x4B6080", VA = "0x1804B7080")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000847")]
	[Address(RVA = "0x4B70C0", Offset = "0x4B60C0", VA = "0x1804B70C0")]
	private void Awake()
	{
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000848")]
	[Address(RVA = "0x4B7410", Offset = "0x4B6410", VA = "0x1804B7410")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000849")]
	[Address(RVA = "0x4B7620", Offset = "0x4B6620", VA = "0x1804B7620")]
	public void SetProcGenKillerLoop(bool val)
	{
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600084A")]
	[Address(RVA = "0x4B7740", Offset = "0x4B6740", VA = "0x1804B7740")]
	public MurderController.Murder GetCurrentMurder()
	{
		return null;
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600084B")]
	[Address(RVA = "0x4B7A30", Offset = "0x4B6A30", VA = "0x1804B7A30")]
	public void Tick(float timePassed)
	{
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600084C")]
	[Address(RVA = "0x4B9420", Offset = "0x4B8420", VA = "0x1804B9420")]
	public void PickNewMurderer()
	{
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600084D")]
	[Address(RVA = "0x4BB5D0", Offset = "0x4BA5D0", VA = "0x1804BB5D0")]
	private void OnValidate()
	{
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600084E")]
	[Address(RVA = "0x4BB780", Offset = "0x4BA780", VA = "0x1804BB780")]
	public void OnVictimDiscovery()
	{
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600084F")]
	[Address(RVA = "0x4BBDE0", Offset = "0x4BADE0", VA = "0x1804BBDE0")]
	public void OnVictimKilled()
	{
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000850")]
	[Address(RVA = "0x4BBF70", Offset = "0x4BAF70", VA = "0x1804BBF70")]
	public void TriggerCoverUpTelephoneCall()
	{
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000851")]
	[Address(RVA = "0x4BC490", Offset = "0x4BB490", VA = "0x1804BC490")]
	public void OnCoverUpAccept()
	{
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000852")]
	[Address(RVA = "0x4BC490", Offset = "0x4BB490", VA = "0x1804BC490")]
	public void OnCoverUpReject()
	{
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000853")]
	[Address(RVA = "0x4BC500", Offset = "0x4BB500", VA = "0x1804BC500")]
	public void TriggerCoverUpObjective()
	{
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000854")]
	[Address(RVA = "0x4BCF30", Offset = "0x4BBF30", VA = "0x1804BCF30")]
	public void TriggerKidnappingCase()
	{
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000855")]
	[Address(RVA = "0x4BD9F0", Offset = "0x4BC9F0", VA = "0x1804BD9F0")]
	public void TriggerRansomDelivery()
	{
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000856")]
	[Address(RVA = "0x4BE310", Offset = "0x4BD310", VA = "0x1804BE310")]
	public void KidnapperCollectsRansom()
	{
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000857")]
	[Address(RVA = "0x4BE8C0", Offset = "0x4BD8C0", VA = "0x1804BE8C0")]
	public void KidnapperCollectedRansom()
	{
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000858")]
	[Address(RVA = "0x4BEE60", Offset = "0x4BDE60", VA = "0x1804BEE60")]
	public void TriggerRansomFail()
	{
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000859")]
	[Address(RVA = "0x4BF240", Offset = "0x4BE240", VA = "0x1804BF240")]
	public void VictimFreed()
	{
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085A")]
	[Address(RVA = "0x4BF900", Offset = "0x4BE900", VA = "0x1804BF900")]
	public void ResetKidnapper()
	{
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085B")]
	[Address(RVA = "0x4BF9C0", Offset = "0x4BE9C0", VA = "0x1804BF9C0")]
	public void OnCaseSolved()
	{
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085C")]
	[Address(RVA = "0x4BFD70", Offset = "0x4BED70", VA = "0x1804BFD70")]
	public void CitizenHasSeenBody(Human seenBody, Human seenBy)
	{
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085D")]
	[Address(RVA = "0x4C0800", Offset = "0x4BF800", VA = "0x1804C0800")]
	public void CoverUpFailCheck(Human seenBody)
	{
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085E")]
	[Address(RVA = "0x4C10D0", Offset = "0x4C00D0", VA = "0x1804C10D0")]
	public void TriggerSuccessfulCoverUp(Evidence passedCitizen)
	{
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600085F")]
	[Address(RVA = "0x4C1300", Offset = "0x4C0300", VA = "0x1804C1300")]
	public void TriggerCoverUpSuccessCall()
	{
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000860")]
	[Address(RVA = "0x4C18D0", Offset = "0x4C08D0", VA = "0x1804C18D0")]
	public void OnCoverUpSuccessEnd()
	{
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000861")]
	[Address(RVA = "0x4C19F0", Offset = "0x4C09F0", VA = "0x1804C19F0")]
	public void DisplayCoverUpTips()
	{
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000862")]
	[Address(RVA = "0x4C1C10", Offset = "0x4C0C10", VA = "0x1804C1C10")]
	public void AssignActiveCase(Case newCase)
	{
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000863")]
	[Address(RVA = "0x4C1C80", Offset = "0x4C0C80", VA = "0x1804C1C80")]
	public void UpdateCorrectResolveAnswers()
	{
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000864")]
	[Address(RVA = "0x4C3F40", Offset = "0x4C2F40", VA = "0x1804C3F40")]
	public void UpdateResolveQuestions(bool clearExisting)
	{
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000865")]
	[Address(RVA = "0x4C4A50", Offset = "0x4C3A50", VA = "0x1804C4A50")]
	public void PickNewVictim()
	{
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x000056D0 File Offset: 0x000038D0
	[Token(Token = "0x6000866")]
	[Address(RVA = "0x4C7330", Offset = "0x4C6330", VA = "0x1804C7330")]
	public bool TraitTest(Citizen cit, ref List<MurderPreset.MurdererModifierRule> rules, out float output)
	{
		return default(bool);
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000867")]
	[Address(RVA = "0x4C7D40", Offset = "0x4C6D40", VA = "0x1804C7D40")]
	public MurderController.Murder ExecuteNewMurder(Human newMurderer, Human newVictim, MurderPreset preset, MurderMO motive, [Optional] NewGameLocation victimSite)
	{
		return null;
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000868")]
	[Address(RVA = "0x4C8160", Offset = "0x4C7160", VA = "0x1804C8160")]
	private void Update()
	{
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000869")]
	[Address(RVA = "0x4CF8C0", Offset = "0x4CE8C0", VA = "0x1804CF8C0")]
	public void ExecuteSniperShot(Human victim, Human killer, Ray confirmationRay, RaycastHit confirmationHit, Transform victimTargetTransform, bool forceKill = false)
	{
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600086A")]
	[Address(RVA = "0x4D1E70", Offset = "0x4D0E70", VA = "0x1804D1E70")]
	public void SetUpdateEnabled(bool val)
	{
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600086B")]
	[Address(RVA = "0x4D1FC0", Offset = "0x4D0FC0", VA = "0x1804D1FC0")]
	public void OnStartGame()
	{
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600086C")]
	[Address(RVA = "0x4D2210", Offset = "0x4D1210", VA = "0x1804D2210")]
	public void TriggerNextMurder()
	{
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600086D")]
	[Address(RVA = "0x4D23C0", Offset = "0x4D13C0", VA = "0x1804D23C0", Slot = "4")]
	public virtual void SpawnItemsCheck(MurderController.Murder murder)
	{
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x000056E8 File Offset: 0x000038E8
	[Token(Token = "0x600086E")]
	[Address(RVA = "0x4D4FB0", Offset = "0x4D3FB0", VA = "0x1804D4FB0")]
	private bool SpawnItemIsValid(MurderController.Murder murder, MurderPreset.MurderLeadItem spawn, ref List<MurderPreset.MurderLeadItem> successsfullySpawned, bool useChance)
	{
		return default(bool);
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600086F")]
	[Address(RVA = "0x4D5CE0", Offset = "0x4D4CE0", VA = "0x1804D5CE0")]
	public Interactable SpawnItem(MurderController.Murder murder, InteractablePreset spawnItem, MurderPreset.LeadSpawnWhere spawnWhere, MurderPreset.LeadCitizen spawnBelongsTo, MurderPreset.LeadCitizen spawnWriter, MurderPreset.LeadCitizen spawnReceiver, int security, InteractablePreset.OwnedPlacementRule ownedRule, int priority, JobPreset.JobTag itemTag)
	{
		return null;
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000870")]
	[Address(RVA = "0x4D8A40", Offset = "0x4D7A40", VA = "0x1804D8A40")]
	public void LastMurderLocation()
	{
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000871")]
	[Address(RVA = "0x4D8AD0", Offset = "0x4D7AD0", VA = "0x1804D8AD0")]
	public void ListSpawnedMurderItems()
	{
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000872")]
	[Address(RVA = "0x4D9140", Offset = "0x4D8140", VA = "0x1804D9140")]
	public void SpawnPlayerTaunt()
	{
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000873")]
	[Address(RVA = "0x4D9940", Offset = "0x4D8940", VA = "0x1804D9940")]
	public MurderController()
	{
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x00005700 File Offset: 0x00003900
	[Token(Token = "0x6000874")]
	[Address(RVA = "0x4D9D60", Offset = "0x4D8D60", VA = "0x1804D9D60")]
	private bool <GetCurrentMurder>b__46_0(MurderController.Murder item)
	{
		return default(bool);
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00005718 File Offset: 0x00003918
	[Token(Token = "0x6000875")]
	[Address(RVA = "0x4DA050", Offset = "0x4D9050", VA = "0x1804DA050")]
	private bool <OnValidate>b__49_0(MurderPreset x)
	{
		return default(bool);
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00005730 File Offset: 0x00003930
	[Token(Token = "0x6000876")]
	[Address(RVA = "0x4DA090", Offset = "0x4D9090", VA = "0x1804DA090")]
	private bool <ListSpawnedMurderItems>b__85_0(MurderController.Murder item)
	{
		return default(bool);
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00005748 File Offset: 0x00003948
	[Token(Token = "0x6000877")]
	[Address(RVA = "0x4DA090", Offset = "0x4D9090", VA = "0x1804DA090")]
	private bool <ListSpawnedMurderItems>b__85_1(MurderController.Murder item)
	{
		return default(bool);
	}

	// Token: 0x0400087D RID: 2173
	[Token(Token = "0x400087D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool useDebugOverride;

	// Token: 0x0400087E RID: 2174
	[Token(Token = "0x400087E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MurderPreset debugMurderPreset;

	// Token: 0x0400087F RID: 2175
	[Token(Token = "0x400087F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MurderMO debugMO;

	// Token: 0x04000880 RID: 2176
	[Token(Token = "0x4000880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool procGenLoopActive;

	// Token: 0x04000881 RID: 2177
	[Token(Token = "0x4000881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool murderRoutineActive;

	// Token: 0x04000882 RID: 2178
	[Token(Token = "0x4000882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Human currentMurderer;

	// Token: 0x04000883 RID: 2179
	[Token(Token = "0x4000883")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Human currentVictim;

	// Token: 0x04000884 RID: 2180
	[Token(Token = "0x4000884")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[NonSerialized]
	public Case currentActiveCase;

	// Token: 0x04000885 RID: 2181
	[Token(Token = "0x4000885")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool debugActiveCaseExists;

	// Token: 0x04000886 RID: 2182
	[Token(Token = "0x4000886")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public MurderPreset murderPreset;

	// Token: 0x04000887 RID: 2183
	[Token(Token = "0x4000887")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public MurderMO chosenMO;

	// Token: 0x04000888 RID: 2184
	[Token(Token = "0x4000888")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Human> previousMurderers;

	// Token: 0x04000889 RID: 2185
	[Token(Token = "0x4000889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float pauseBetweenMurders;

	// Token: 0x0400088A RID: 2186
	[Token(Token = "0x400088A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float pauseBeforeKidnapperKill;

	// Token: 0x0400088B RID: 2187
	[Token(Token = "0x400088B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float locationUpdateTimer;

	// Token: 0x0400088C RID: 2188
	[Token(Token = "0x400088C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public int maxDifficultyLevel;

	// Token: 0x0400088D RID: 2189
	[Token(Token = "0x400088D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public NewGameLocation currentVictimSite;

	// Token: 0x0400088E RID: 2190
	[Token(Token = "0x400088E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool triggerCoverUpCall;

	// Token: 0x0400088F RID: 2191
	[Token(Token = "0x400088F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private TelephoneController.PhoneCall coverUpCall;

	// Token: 0x04000890 RID: 2192
	[Token(Token = "0x4000890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool playerAcceptedCoverUp;

	// Token: 0x04000891 RID: 2193
	[Token(Token = "0x4000891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool triggerCoverUpSuccess;

	// Token: 0x04000892 RID: 2194
	[Token(Token = "0x4000892")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private TelephoneController.PhoneCall successCall;

	// Token: 0x04000893 RID: 2195
	[Token(Token = "0x4000893")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool triggeredSeenWarning;

	// Token: 0x04000894 RID: 2196
	[Token(Token = "0x4000894")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private List<NewGameLocation> sniperVictimSites;

	// Token: 0x04000895 RID: 2197
	[Token(Token = "0x4000895")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<MurderController.MurderMethod> methodTypes;

	// Token: 0x04000896 RID: 2198
	[Token(Token = "0x4000896")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public int assignMurderID;

	// Token: 0x04000897 RID: 2199
	[Token(Token = "0x4000897")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<MurderController.Murder> activeMurders;

	// Token: 0x04000898 RID: 2200
	[Token(Token = "0x4000898")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public List<MurderController.Murder> inactiveMurders;

	// Token: 0x04000899 RID: 2201
	[Token(Token = "0x4000899")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float sniperShotDelay;

	// Token: 0x0400089A RID: 2202
	[Token(Token = "0x400089A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public float limbTargetCycleCounter;

	// Token: 0x0400089B RID: 2203
	[Token(Token = "0x400089B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public int limbTargetCycle;

	// Token: 0x0400089C RID: 2204
	[Token(Token = "0x400089C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public AIGoalPreset murderGoalPreset;

	// Token: 0x0400089D RID: 2205
	[Token(Token = "0x400089D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<MurderController.MurderPick> debugLastMurderPicks;

	// Token: 0x0400089E RID: 2206
	[Token(Token = "0x400089E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public int debugMurderID;

	// Token: 0x0400089F RID: 2207
	[Token(Token = "0x400089F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MurderController _instance;

	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000122")]
	[Serializable]
	public class MurderMethod
	{
		// Token: 0x06000878 RID: 2168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public MurderMethod()
		{
		}

		// Token: 0x040008A0 RID: 2208
		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MurderWeaponPreset.WeaponType type;

		// Token: 0x040008A1 RID: 2209
		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string blockDDS;
	}

	// Token: 0x02000123 RID: 291
	[Token(Token = "0x2000123")]
	public struct CachedSniperLocation
	{
		// Token: 0x040008A2 RID: 2210
		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public NewWall location;

		// Token: 0x040008A3 RID: 2211
		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float score;
	}

	// Token: 0x02000124 RID: 292
	[Token(Token = "0x2000124")]
	public enum MurderState
	{
		// Token: 0x040008A5 RID: 2213
		[Token(Token = "0x40008A5")]
		none,
		// Token: 0x040008A6 RID: 2214
		[Token(Token = "0x40008A6")]
		acquireEuipment,
		// Token: 0x040008A7 RID: 2215
		[Token(Token = "0x40008A7")]
		research,
		// Token: 0x040008A8 RID: 2216
		[Token(Token = "0x40008A8")]
		waitForLocation,
		// Token: 0x040008A9 RID: 2217
		[Token(Token = "0x40008A9")]
		travellingTo,
		// Token: 0x040008AA RID: 2218
		[Token(Token = "0x40008AA")]
		executing,
		// Token: 0x040008AB RID: 2219
		[Token(Token = "0x40008AB")]
		post,
		// Token: 0x040008AC RID: 2220
		[Token(Token = "0x40008AC")]
		escaping,
		// Token: 0x040008AD RID: 2221
		[Token(Token = "0x40008AD")]
		unsolved,
		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x40008AE")]
		solved
	}

	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	public enum KidnapRansomPhase
	{
		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		none,
		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		travellingToRansom,
		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		collectedRansom,
		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		freeingVictim,
		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		finishedFailed,
		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		finishedSuccess
	}

	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	[Serializable]
	public class MurderPick
	{
		// Token: 0x06000879 RID: 2169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public MurderPick()
		{
		}

		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human person;

		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MurderMO mo;

		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float score;
	}

	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	[Serializable]
	public class Murder
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600087A RID: 2170 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600087B RID: 2171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000C")]
		public event MurderController.Murder.OnMurderStateChange OnStateChanged
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x4DA280", Offset = "0x4D9280", VA = "0x1804DA280")]
			add
			{
			}
			[Token(Token = "0x600087B")]
			[Address(RVA = "0x4DA380", Offset = "0x4D9380", VA = "0x1804DA380")]
			remove
			{
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x4DA480", Offset = "0x4D9480", VA = "0x1804DA480")]
		public Murder(Human newMurderer, Human newVictim, MurderPreset newPreset, MurderMO newMotive, [Optional] NewGameLocation newVictimSite)
		{
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x4DB040", Offset = "0x4DA040", VA = "0x1804DB040")]
		public void LoadSerializedData()
		{
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x4DC730", Offset = "0x4DB730", VA = "0x1804DC730")]
		public void CreateMurderGoal()
		{
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x4DCA10", Offset = "0x4DBA10", VA = "0x1804DCA10")]
		public void SetMurderState(MurderController.MurderState newState, bool force = false, bool doSpawnItemsCheck = true)
		{
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x4DDAA0", Offset = "0x4DCAA0", VA = "0x1804DDAA0")]
		public void CancelCurrentMurder()
		{
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00005760 File Offset: 0x00003960
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x4DDE60", Offset = "0x4DCE60", VA = "0x1804DDE60")]
		public bool IsValidLocation(NewGameLocation newLoc)
		{
			return default(bool);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x4DE860", Offset = "0x4DD860", VA = "0x1804DE860")]
		public void PickNewMurderWeapon()
		{
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x4DFB00", Offset = "0x4DEB00", VA = "0x1804DFB00")]
		public void PickNewCallingCard()
		{
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x4DFF50", Offset = "0x4DEF50", VA = "0x1804DFF50")]
		public void SetMurderWeaponActual(Interactable newObj)
		{
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x4DFFC0", Offset = "0x4DEFC0", VA = "0x1804DFFC0")]
		public void SetMurderLocation(NewGameLocation newLoc)
		{
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x4E0430", Offset = "0x4DF430", VA = "0x1804E0430")]
		public void EuipmentCheck()
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x4E0AB0", Offset = "0x4DFAB0", VA = "0x1804E0AB0")]
		public string GetMonkier()
		{
			return null;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x4E1000", Offset = "0x4E0000", VA = "0x1804E1000")]
		public void GenerateMoniker()
		{
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x4E1F40", Offset = "0x4E0F40", VA = "0x1804E1F40")]
		public void PlaceCallingCard()
		{
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x4E2740", Offset = "0x4E1740", VA = "0x1804E2740")]
		public void WeaponDisposal()
		{
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x4E2A80", Offset = "0x4E1A80", VA = "0x1804E2A80")]
		public void GenerateGraffiti()
		{
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x4E4040", Offset = "0x4E3040", VA = "0x1804E4040")]
		public void OnCleanCrimeScene()
		{
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x4E4320", Offset = "0x4E3320", VA = "0x1804E4320")]
		public void GenerateRansomDetails()
		{
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x4E4790", Offset = "0x4E3790", VA = "0x1804E4790", Slot = "4")]
		public virtual void GenerateFakeNumber()
		{
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x4E4A10", Offset = "0x4E3A10", VA = "0x1804E4A10")]
		public void SetRansomPhase(MurderController.KidnapRansomPhase newPhase)
		{
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00005778 File Offset: 0x00003978
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x4E4A20", Offset = "0x4E3A20", VA = "0x1804E4A20")]
		public bool TryPickNewVictimSite(out NewGameLocation newTargetSite)
		{
			return default(bool);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00005790 File Offset: 0x00003990
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x4E5F80", Offset = "0x4E4F80", VA = "0x1804E5F80")]
		private bool <LoadSerializedData>b__69_0(StreetController item)
		{
			return default(bool);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x4E5FA0", Offset = "0x4E4FA0", VA = "0x1804E5FA0")]
		private bool <LoadSerializedData>b__69_1(Company item)
		{
			return default(bool);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x000057C0 File Offset: 0x000039C0
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x4E5FC0", Offset = "0x4E4FC0", VA = "0x1804E5FC0")]
		private bool <LoadSerializedData>b__69_2(StreetController item)
		{
			return default(bool);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000057D8 File Offset: 0x000039D8
		[Token(Token = "0x6000894")]
		[Address(RVA = "0x4E5FE0", Offset = "0x4E4FE0", VA = "0x1804E5FE0")]
		private bool <LoadSerializedData>b__69_3(NewBuilding item)
		{
			return default(bool);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000057F0 File Offset: 0x000039F0
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x4E6000", Offset = "0x4E5000", VA = "0x1804E6000")]
		private bool <LoadSerializedData>b__69_5(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00005808 File Offset: 0x00003A08
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x4E6020", Offset = "0x4E5020", VA = "0x1804E6020")]
		private bool <LoadSerializedData>b__69_6(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00005820 File Offset: 0x00003A20
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x4E6040", Offset = "0x4E5040", VA = "0x1804E6040")]
		private bool <EuipmentCheck>b__78_0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00005838 File Offset: 0x00003A38
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x4E60A0", Offset = "0x4E50A0", VA = "0x1804E60A0")]
		private bool <EuipmentCheck>b__78_1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00005850 File Offset: 0x00003A50
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x4E6100", Offset = "0x4E5100", VA = "0x1804E6100")]
		private bool <OnCleanCrimeScene>b__84_0(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string presetStr;

		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string moStr;

		// Token: 0x040008BB RID: 2235
		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float creationTime;

		// Token: 0x040008BC RID: 2236
		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int murderID;

		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int murdererID;

		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int victimID;

		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int streetID;

		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public MurderController.MurderState state;

		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int addressID;

		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float waitingTimestamp;

		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float time;

		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string monkierPre;

		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string monkierPost;

		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int victimSiteID;

		// Token: 0x040008C7 RID: 2247
		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool victimSiteIsStreet;

		// Token: 0x040008C8 RID: 2248
		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		public bool kidnapKillPhase;

		// Token: 0x040008C9 RID: 2249
		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3Int sniperKillShotNode;

		// Token: 0x040008CA RID: 2250
		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int ransomSiteID;

		// Token: 0x040008CB RID: 2251
		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int ransomAmount;

		// Token: 0x040008CC RID: 2252
		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int fakeNumber;

		// Token: 0x040008CD RID: 2253
		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string fakeNumberStr;

		// Token: 0x040008CE RID: 2254
		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MurderController.KidnapRansomPhase ransomPhase;

		// Token: 0x040008CF RID: 2255
		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float killTime;

		// Token: 0x040008D0 RID: 2256
		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int meetRestaurantID;

		// Token: 0x040008D1 RID: 2257
		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public int boothSeat1ID;

		// Token: 0x040008D2 RID: 2258
		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int boothSeat2ID;

		// Token: 0x040008D3 RID: 2259
		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float meetTimeTotal;

		// Token: 0x040008D4 RID: 2260
		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float meetTime;

		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string weaponStr;

		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string ammoStr;

		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int weaponID;

		// Token: 0x040008D8 RID: 2264
		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public int ammoID;

		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public int weaponSourceID;

		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool acquiredEquipment;

		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float dropChance;

		// Token: 0x040008DC RID: 2268
		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string callingCardStr;

		// Token: 0x040008DD RID: 2269
		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public MurderMO.CallingCardOrigin callingCardOrigin;

		// Token: 0x040008DE RID: 2270
		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int callingCardID;

		// Token: 0x040008DF RID: 2271
		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public List<int> graffitiIDs;

		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public string graffitiMsg;

		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public List<int> cullingActiveRooms;

		// Token: 0x040008E2 RID: 2274
		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[NonSerialized]
		public MurderPreset preset;

		// Token: 0x040008E3 RID: 2275
		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[NonSerialized]
		public MurderMO mo;

		// Token: 0x040008E4 RID: 2276
		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[NonSerialized]
		public Human murderer;

		// Token: 0x040008E5 RID: 2277
		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[NonSerialized]
		public Human victim;

		// Token: 0x040008E6 RID: 2278
		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[NonSerialized]
		public NewAIGoal murderGoal;

		// Token: 0x040008E7 RID: 2279
		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[NonSerialized]
		public NewGameLocation location;

		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[NonSerialized]
		public Human.Death death;

		// Token: 0x040008E9 RID: 2281
		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[NonSerialized]
		public Dictionary<JobPreset.JobTag, Interactable> activeMurderItems;

		// Token: 0x040008EA RID: 2282
		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[NonSerialized]
		public InteractablePreset weaponPreset;

		// Token: 0x040008EB RID: 2283
		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[NonSerialized]
		public InteractablePreset ammoPreset;

		// Token: 0x040008EC RID: 2284
		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[NonSerialized]
		public Interactable weapon;

		// Token: 0x040008ED RID: 2285
		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[NonSerialized]
		public Interactable ammo;

		// Token: 0x040008EE RID: 2286
		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[NonSerialized]
		public InteractablePreset callingCardPreset;

		// Token: 0x040008EF RID: 2287
		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[NonSerialized]
		public Interactable callingCard;

		// Token: 0x040008F0 RID: 2288
		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[NonSerialized]
		public Company weaponSource;

		// Token: 0x040008F1 RID: 2289
		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[NonSerialized]
		public List<Interactable> graffiti;

		// Token: 0x040008F2 RID: 2290
		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[NonSerialized]
		public NewGameLocation sniperVictimSite;

		// Token: 0x040008F3 RID: 2291
		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[NonSerialized]
		public NewBuilding ransomSite;

		// Token: 0x040008F4 RID: 2292
		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[NonSerialized]
		public NewAddress meetRestaurant;

		// Token: 0x040008F5 RID: 2293
		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[NonSerialized]
		public Interactable boothSeat1;

		// Token: 0x040008F6 RID: 2294
		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[NonSerialized]
		public Interactable boothSeat2;

		// Token: 0x040008F7 RID: 2295
		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[NonSerialized]
		public NewAIGoal meetGoal1;

		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[NonSerialized]
		public NewAIGoal meetGoal2;

		// Token: 0x02000128 RID: 296
		// (Invoke) Token: 0x0600089B RID: 2203
		[Token(Token = "0x2000128")]
		public delegate void OnMurderStateChange(MurderController.MurderState newState);

		// Token: 0x02000129 RID: 297
		[Token(Token = "0x2000129")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600089F RID: 2207 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c()
			{
			}

			// Token: 0x060008A0 RID: 2208 RVA: 0x00005868 File Offset: 0x00003A68
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x4E6390", Offset = "0x4E5390", VA = "0x1804E6390")]
			internal bool <LoadSerializedData>b__69_4(NewAIGoal item)
			{
				return default(bool);
			}

			// Token: 0x060008A1 RID: 2209 RVA: 0x00005880 File Offset: 0x00003A80
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x4E6430", Offset = "0x4E5430", VA = "0x1804E6430")]
			internal bool <LoadSerializedData>b__69_7(NewAIGoal item)
			{
				return default(bool);
			}

			// Token: 0x060008A2 RID: 2210 RVA: 0x00005898 File Offset: 0x00003A98
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x4E6430", Offset = "0x4E5430", VA = "0x1804E6430")]
			internal bool <LoadSerializedData>b__69_8(NewAIGoal item)
			{
				return default(bool);
			}

			// Token: 0x060008A3 RID: 2211 RVA: 0x000058B0 File Offset: 0x00003AB0
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x4E64D0", Offset = "0x4E54D0", VA = "0x1804E64D0")]
			internal bool <SetMurderState>b__71_0(Interactable item)
			{
				return default(bool);
			}

			// Token: 0x060008A4 RID: 2212 RVA: 0x000058C8 File Offset: 0x00003AC8
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x4E6580", Offset = "0x4E5580", VA = "0x1804E6580")]
			internal bool <GenerateGraffiti>b__83_0(FurnitureLocation item)
			{
				return default(bool);
			}

			// Token: 0x060008A5 RID: 2213 RVA: 0x000058E0 File Offset: 0x00003AE0
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x4E6600", Offset = "0x4E5600", VA = "0x1804E6600")]
			internal bool <GenerateGraffiti>b__83_1(FurnitureLocation item)
			{
				return default(bool);
			}

			// Token: 0x040008FA RID: 2298
			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly MurderController.Murder.<>c <>9;

			// Token: 0x040008FB RID: 2299
			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<NewAIGoal> <>9__69_4;

			// Token: 0x040008FC RID: 2300
			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<NewAIGoal> <>9__69_7;

			// Token: 0x040008FD RID: 2301
			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<NewAIGoal> <>9__69_8;

			// Token: 0x040008FE RID: 2302
			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Predicate<Interactable> <>9__71_0;

			// Token: 0x040008FF RID: 2303
			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Predicate<FurnitureLocation> <>9__83_0;

			// Token: 0x04000900 RID: 2304
			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Predicate<FurnitureLocation> <>9__83_1;
		}

		// Token: 0x0200012A RID: 298
		[Token(Token = "0x200012A")]
		private sealed class <>c__DisplayClass74_0
		{
			// Token: 0x060008A6 RID: 2214 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass74_0()
			{
			}

			// Token: 0x060008A7 RID: 2215 RVA: 0x000058F8 File Offset: 0x00003AF8
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x4E6680", Offset = "0x4E5680", VA = "0x1804E6680")]
			internal bool <PickNewMurderWeapon>b__0(Interactable item)
			{
				return default(bool);
			}

			// Token: 0x060008A8 RID: 2216 RVA: 0x00005910 File Offset: 0x00003B10
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x4E6680", Offset = "0x4E5680", VA = "0x1804E6680")]
			internal bool <PickNewMurderWeapon>b__1(Interactable item)
			{
				return default(bool);
			}

			// Token: 0x04000901 RID: 2305
			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MurderWeaponsPool.MurderWeaponPick wp;
		}

		// Token: 0x0200012B RID: 299
		[Token(Token = "0x200012B")]
		private sealed class <>c__DisplayClass80_0
		{
			// Token: 0x060008A9 RID: 2217 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass80_0()
			{
			}

			// Token: 0x060008AA RID: 2218 RVA: 0x00005928 File Offset: 0x00003B28
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x4E66F0", Offset = "0x4E56F0", VA = "0x1804E66F0")]
			internal bool <GenerateMoniker>b__0(MurderController.Murder item)
			{
				return default(bool);
			}

			// Token: 0x04000902 RID: 2306
			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DDSSaveClasses.DDSBlockCondition cond;
		}
	}

	// Token: 0x0200012C RID: 300
	[Token(Token = "0x200012C")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060008AC RID: 2220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00005940 File Offset: 0x00003B40
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x4E6810", Offset = "0x4E5810", VA = "0x1804E6810")]
		internal bool <Tick>b__47_0(Objective item)
		{
			return default(bool);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x4E68A0", Offset = "0x4E58A0", VA = "0x1804E68A0")]
		internal bool <Tick>b__47_1(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00005970 File Offset: 0x00003B70
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x4E6940", Offset = "0x4E5940", VA = "0x1804E6940")]
		internal bool <Tick>b__47_2(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x4E6A80", Offset = "0x4E5A80", VA = "0x1804E6A80")]
		internal bool <Tick>b__47_3(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x4E6B20", Offset = "0x4E5B20", VA = "0x1804E6B20")]
		internal bool <PickNewMurderer>b__48_2(NewGameLocation item)
		{
			return default(bool);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x4E6C70", Offset = "0x4E5C70", VA = "0x1804E6C70")]
		internal bool <PickNewMurderer>b__48_3(Occupation item)
		{
			return default(bool);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000059D0 File Offset: 0x00003BD0
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x4E6D90", Offset = "0x4E5D90", VA = "0x1804E6D90")]
		internal int <PickNewMurderer>b__48_0(MurderController.MurderPick p1, MurderController.MurderPick p2)
		{
			return 0;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x000059E8 File Offset: 0x00003BE8
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x4E6E20", Offset = "0x4E5E20", VA = "0x1804E6E20")]
		internal bool <OnVictimDiscovery>b__50_0(Case item)
		{
			return default(bool);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00005A00 File Offset: 0x00003C00
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x4E6E20", Offset = "0x4E5E20", VA = "0x1804E6E20")]
		internal bool <TriggerCoverUpObjective>b__55_0(Case item)
		{
			return default(bool);
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00005A18 File Offset: 0x00003C18
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x4E6E20", Offset = "0x4E5E20", VA = "0x1804E6E20")]
		internal bool <TriggerKidnappingCase>b__56_0(Case item)
		{
			return default(bool);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00005A30 File Offset: 0x00003C30
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x4E6E60", Offset = "0x4E5E60", VA = "0x1804E6E60")]
		internal bool <KidnapperCollectsRansom>b__58_0(Objective.ObjectiveTrigger item)
		{
			return default(bool);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00005A48 File Offset: 0x00003C48
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x4E6E60", Offset = "0x4E5E60", VA = "0x1804E6E60")]
		internal bool <TriggerRansomFail>b__60_0(Objective.ObjectiveTrigger item)
		{
			return default(bool);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00005A60 File Offset: 0x00003C60
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x4E6E90", Offset = "0x4E5E90", VA = "0x1804E6E90")]
		internal bool <VictimFreed>b__61_0(Objective.ObjectiveTrigger item)
		{
			return default(bool);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00005A78 File Offset: 0x00003C78
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x4E6EC0", Offset = "0x4E5EC0", VA = "0x1804E6EC0")]
		internal bool <CitizenHasSeenBody>b__64_0(Objective.ObjectiveTrigger item)
		{
			return default(bool);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00005A90 File Offset: 0x00003C90
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x4E6EC0", Offset = "0x4E5EC0", VA = "0x1804E6EC0")]
		internal bool <CoverUpFailCheck>b__65_0(Objective.ObjectiveTrigger item)
		{
			return default(bool);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x4E6F90", Offset = "0x4E5F90", VA = "0x1804E6F90")]
		internal bool <PickNewVictim>b__73_0(Occupation item)
		{
			return default(bool);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x4E70B0", Offset = "0x4E60B0", VA = "0x1804E70B0")]
		internal bool <Update>b__76_4(NewRoom item)
		{
			return default(bool);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x4E6430", Offset = "0x4E5430", VA = "0x1804E6430")]
		internal bool <Update>b__76_5(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x4E6430", Offset = "0x4E5430", VA = "0x1804E6430")]
		internal bool <Update>b__76_6(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x4E7220", Offset = "0x4E6220", VA = "0x1804E7220")]
		internal bool <Update>b__76_11(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x4E72C0", Offset = "0x4E62C0", VA = "0x1804E72C0")]
		internal int <Update>b__76_12(RaycastHit p1, RaycastHit p2)
		{
			return 0;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00005B38 File Offset: 0x00003D38
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x4E72C0", Offset = "0x4E62C0", VA = "0x1804E72C0")]
		internal int <ExecuteSniperShot>b__77_0(RaycastHit p1, RaycastHit p2)
		{
			return 0;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x4E7340", Offset = "0x4E6340", VA = "0x1804E7340")]
		internal bool <TriggerNextMurder>b__80_0(Objective item)
		{
			return default(bool);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x4E73D0", Offset = "0x4E63D0", VA = "0x1804E73D0")]
		internal bool <SpawnPlayerTaunt>b__86_0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly MurderController.<>c <>9;

		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Objective> <>9__47_0;

		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<NewAIGoal> <>9__47_1;

		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<Interactable> <>9__47_2;

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<NewAIGoal> <>9__47_3;

		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<NewGameLocation> <>9__48_2;

		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<Occupation> <>9__48_3;

		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Comparison<MurderController.MurderPick> <>9__48_0;

		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Predicate<Case> <>9__50_0;

		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Predicate<Case> <>9__55_0;

		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Predicate<Case> <>9__56_0;

		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Predicate<Objective.ObjectiveTrigger> <>9__58_0;

		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Predicate<Objective.ObjectiveTrigger> <>9__60_0;

		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Predicate<Objective.ObjectiveTrigger> <>9__61_0;

		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static Predicate<Objective.ObjectiveTrigger> <>9__64_0;

		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static Predicate<Objective.ObjectiveTrigger> <>9__65_0;

		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static Predicate<Occupation> <>9__73_0;

		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static Predicate<NewRoom> <>9__76_4;

		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static Predicate<NewAIGoal> <>9__76_5;

		// Token: 0x04000916 RID: 2326
		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static Predicate<NewAIGoal> <>9__76_6;

		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static Predicate<NewAIGoal> <>9__76_11;

		// Token: 0x04000918 RID: 2328
		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static Comparison<RaycastHit> <>9__76_12;

		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static Comparison<RaycastHit> <>9__77_0;

		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static Predicate<Objective> <>9__80_0;

		// Token: 0x0400091B RID: 2331
		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static Predicate<NewNode.NodeAccess> <>9__86_0;
	}

	// Token: 0x0200012D RID: 301
	[Token(Token = "0x200012D")]
	private sealed class <>c__DisplayClass48_0
	{
		// Token: 0x060008C5 RID: 2245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass48_0()
		{
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00005B80 File Offset: 0x00003D80
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x4E73F0", Offset = "0x4E63F0", VA = "0x1804E73F0")]
		internal bool <PickNewMurderer>b__1(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x0400091C RID: 2332
		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MurderMO wp;
	}

	// Token: 0x0200012E RID: 302
	[Token(Token = "0x200012E")]
	private sealed class <>c__DisplayClass64_0
	{
		// Token: 0x060008C7 RID: 2247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass64_0()
		{
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00005B98 File Offset: 0x00003D98
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x4E7450", Offset = "0x4E6450", VA = "0x1804E7450")]
		internal bool <CitizenHasSeenBody>b__1(Objective.ObjectiveTrigger item)
		{
			return default(bool);
		}

		// Token: 0x0400091D RID: 2333
		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human seenBody;

		// Token: 0x0400091E RID: 2334
		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<Objective.ObjectiveTrigger> <>9__1;
	}

	// Token: 0x0200012F RID: 303
	[Token(Token = "0x200012F")]
	private sealed class <>c__DisplayClass65_0
	{
		// Token: 0x060008C9 RID: 2249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass65_0()
		{
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x4E7450", Offset = "0x4E6450", VA = "0x1804E7450")]
		internal bool <CoverUpFailCheck>b__1(Objective.ObjectiveTrigger item)
		{
			return default(bool);
		}

		// Token: 0x0400091F RID: 2335
		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human seenBody;

		// Token: 0x04000920 RID: 2336
		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<Objective.ObjectiveTrigger> <>9__1;
	}

	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	private sealed class <>c__DisplayClass66_0
	{
		// Token: 0x060008CB RID: 2251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass66_0()
		{
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x4E74D0", Offset = "0x4E64D0", VA = "0x1804E74D0")]
		internal bool <TriggerSuccessfulCoverUp>b__0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x04000921 RID: 2337
		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Evidence passedCitizen;
	}

	// Token: 0x02000131 RID: 305
	[Token(Token = "0x2000131")]
	private sealed class <>c__DisplayClass71_0
	{
		// Token: 0x060008CD RID: 2253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass71_0()
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x4E7500", Offset = "0x4E6500", VA = "0x1804E7500")]
		internal bool <UpdateCorrectResolveAnswers>b__0(Interactable.DynamicFingerprint item)
		{
			return default(bool);
		}

		// Token: 0x04000922 RID: 2338
		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MurderController.Murder m;
	}

	// Token: 0x02000132 RID: 306
	[Token(Token = "0x2000132")]
	private sealed class <>c__DisplayClass71_1
	{
		// Token: 0x060008CF RID: 2255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass71_1()
		{
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x4E7530", Offset = "0x4E6530", VA = "0x1804E7530")]
		internal bool <UpdateCorrectResolveAnswers>b__1(SceneRecorder.ActorCapture item)
		{
			return default(bool);
		}

		// Token: 0x04000923 RID: 2339
		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MurderController.Murder m;

		// Token: 0x04000924 RID: 2340
		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<SceneRecorder.ActorCapture> <>9__1;
	}

	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	private sealed class <>c__DisplayClass74_0
	{
		// Token: 0x060008D1 RID: 2257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass74_0()
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <TraitTest>b__0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000925 RID: 2341
		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000134 RID: 308
	[Token(Token = "0x2000134")]
	private sealed class <>c__DisplayClass74_1
	{
		// Token: 0x060008D3 RID: 2259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass74_1()
		{
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <TraitTest>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000926 RID: 2342
		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000135 RID: 309
	[Token(Token = "0x2000135")]
	private sealed class <>c__DisplayClass74_2
	{
		// Token: 0x060008D5 RID: 2261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass74_2()
		{
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <TraitTest>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000927 RID: 2343
		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000136 RID: 310
	[Token(Token = "0x2000136")]
	private sealed class <>c__DisplayClass74_3
	{
		// Token: 0x060008D7 RID: 2263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass74_3()
		{
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <TraitTest>b__3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000928 RID: 2344
		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000137 RID: 311
	[Token(Token = "0x2000137")]
	private sealed class <>c__DisplayClass76_0
	{
		// Token: 0x060008D9 RID: 2265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass76_0()
		{
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00005C70 File Offset: 0x00003E70
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x4E75C0", Offset = "0x4E65C0", VA = "0x1804E75C0")]
		internal bool <Update>b__0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00005C88 File Offset: 0x00003E88
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x4E75F0", Offset = "0x4E65F0", VA = "0x1804E75F0")]
		internal bool <Update>b__1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x4E7620", Offset = "0x4E6620", VA = "0x1804E7620")]
		internal bool <Update>b__2(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00005CB8 File Offset: 0x00003EB8
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x4E7690", Offset = "0x4E6690", VA = "0x1804E7690")]
		internal bool <Update>b__3(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00005CD0 File Offset: 0x00003ED0
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x4E7700", Offset = "0x4E6700", VA = "0x1804E7700")]
		internal bool <Update>b__7(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x4E7990", Offset = "0x4E6990", VA = "0x1804E7990")]
		internal bool <Update>b__8(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00005D00 File Offset: 0x00003F00
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x4E7C40", Offset = "0x4E6C40", VA = "0x1804E7C40")]
		internal bool <Update>b__9(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00005D18 File Offset: 0x00003F18
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x4E7ED0", Offset = "0x4E6ED0", VA = "0x1804E7ED0")]
		internal bool <Update>b__10(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x04000929 RID: 2345
		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MurderController.Murder m;
	}

	// Token: 0x02000138 RID: 312
	[Token(Token = "0x2000138")]
	private sealed class <>c__DisplayClass77_0
	{
		// Token: 0x060008E2 RID: 2274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass77_0()
		{
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00005D30 File Offset: 0x00003F30
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x4E8150", Offset = "0x4E7150", VA = "0x1804E8150")]
		internal bool <ExecuteSniperShot>b__1(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00005D48 File Offset: 0x00003F48
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x4E8300", Offset = "0x4E7300", VA = "0x1804E8300")]
		internal bool <ExecuteSniperShot>b__2(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x0400092A RID: 2346
		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human victim;

		// Token: 0x0400092B RID: 2347
		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<MurderController.Murder> <>9__1;
	}

	// Token: 0x02000139 RID: 313
	[Token(Token = "0x2000139")]
	private sealed class <>c__DisplayClass81_0
	{
		// Token: 0x060008E5 RID: 2277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass81_0()
		{
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00005D60 File Offset: 0x00003F60
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x4E84B0", Offset = "0x4E74B0", VA = "0x1804E84B0")]
		internal bool <SpawnItemsCheck>b__0(MurderPreset.MurderLeadItem item)
		{
			return default(bool);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00005D78 File Offset: 0x00003F78
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x4E84B0", Offset = "0x4E74B0", VA = "0x1804E84B0")]
		internal bool <SpawnItemsCheck>b__1(MurderPreset.MurderLeadItem item)
		{
			return default(bool);
		}

		// Token: 0x0400092C RID: 2348
		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MurderController.Murder murder;

		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool firstMurder;

		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MurderController <>4__this;

		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<MurderPreset.MurderLeadItem> successsfullySpawned;
	}

	// Token: 0x0200013A RID: 314
	[Token(Token = "0x200013A")]
	private sealed class <>c__DisplayClass81_1
	{
		// Token: 0x060008E8 RID: 2280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass81_1()
		{
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00005D90 File Offset: 0x00003F90
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x4E84F0", Offset = "0x4E74F0", VA = "0x1804E84F0")]
		internal bool <SpawnItemsCheck>b__2(MurderPreset.MurderLeadItem item)
		{
			return default(bool);
		}

		// Token: 0x04000930 RID: 2352
		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MurderPreset.MurderLeadItem spawn;

		// Token: 0x04000931 RID: 2353
		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MurderController.<>c__DisplayClass81_0 CS$<>8__locals1;
	}

	// Token: 0x0200013B RID: 315
	[Token(Token = "0x200013B")]
	private sealed class <>c__DisplayClass82_0
	{
		// Token: 0x060008EA RID: 2282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass82_0()
		{
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x4E8560", Offset = "0x4E7560", VA = "0x1804E8560")]
		internal bool <SpawnItemIsValid>b__0(MurderPreset.MurderLeadItem item)
		{
			return default(bool);
		}

		// Token: 0x04000932 RID: 2354
		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MurderPreset.MurderLeadItem spawn;
	}

	// Token: 0x0200013C RID: 316
	[Token(Token = "0x200013C")]
	private sealed class <>c__DisplayClass82_1
	{
		// Token: 0x060008EC RID: 2284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass82_1()
		{
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00005DC0 File Offset: 0x00003FC0
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <SpawnItemIsValid>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000933 RID: 2355
		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	private sealed class <>c__DisplayClass82_2
	{
		// Token: 0x060008EE RID: 2286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass82_2()
		{
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00005DD8 File Offset: 0x00003FD8
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <SpawnItemIsValid>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000934 RID: 2356
		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x0200013E RID: 318
	[Token(Token = "0x200013E")]
	private sealed class <>c__DisplayClass82_3
	{
		// Token: 0x060008F0 RID: 2288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass82_3()
		{
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <SpawnItemIsValid>b__3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000935 RID: 2357
		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	private sealed class <>c__DisplayClass82_4
	{
		// Token: 0x060008F2 RID: 2290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass82_4()
		{
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00005E08 File Offset: 0x00004008
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <SpawnItemIsValid>b__4(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04000936 RID: 2358
		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000140 RID: 320
	[Token(Token = "0x2000140")]
	private sealed class <>c__DisplayClass83_0
	{
		// Token: 0x060008F4 RID: 2292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass83_0()
		{
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00005E20 File Offset: 0x00004020
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x4E8590", Offset = "0x4E7590", VA = "0x1804E8590")]
		internal bool <SpawnItem>b__0(Human item)
		{
			return default(bool);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00005E38 File Offset: 0x00004038
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x4E8740", Offset = "0x4E7740", VA = "0x1804E8740")]
		internal bool <SpawnItem>b__1(Human item)
		{
			return default(bool);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00005E50 File Offset: 0x00004050
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x4E88F0", Offset = "0x4E78F0", VA = "0x1804E88F0")]
		internal bool <SpawnItem>b__2(Human item)
		{
			return default(bool);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00005E68 File Offset: 0x00004068
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x4E8AA0", Offset = "0x4E7AA0", VA = "0x1804E8AA0")]
		internal bool <SpawnItem>b__3(Human item)
		{
			return default(bool);
		}

		// Token: 0x04000937 RID: 2359
		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MurderController.Murder murder;
	}
}
