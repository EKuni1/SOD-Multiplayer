using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200071C RID: 1820
[Token(Token = "0x200071C")]
public class GameplayController : MonoBehaviour
{
	// Token: 0x14000061 RID: 97
	// (add) Token: 0x06002831 RID: 10289 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002832 RID: 10290 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000061")]
	public event GameplayController.MatchesChange OnMatchesChanged
	{
		[Token(Token = "0x6002831")]
		[Address(RVA = "0xC1E110", Offset = "0xC1D110", VA = "0x180C1E110")]
		add
		{
		}
		[Token(Token = "0x6002832")]
		[Address(RVA = "0xC1E210", Offset = "0xC1D210", VA = "0x180C1E210")]
		remove
		{
		}
	}

	// Token: 0x14000062 RID: 98
	// (add) Token: 0x06002833 RID: 10291 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002834 RID: 10292 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000062")]
	public event GameplayController.NewEvidenceHistory OnNewEvidenceHistory
	{
		[Token(Token = "0x6002833")]
		[Address(RVA = "0xC1E310", Offset = "0xC1D310", VA = "0x180C1E310")]
		add
		{
		}
		[Token(Token = "0x6002834")]
		[Address(RVA = "0xC1E410", Offset = "0xC1D410", VA = "0x180C1E410")]
		remove
		{
		}
	}

	// Token: 0x14000063 RID: 99
	// (add) Token: 0x06002835 RID: 10293 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06002836 RID: 10294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000063")]
	public event GameplayController.NewPhoneData OnNewPhoneData
	{
		[Token(Token = "0x6002835")]
		[Address(RVA = "0xC1E510", Offset = "0xC1D510", VA = "0x180C1E510")]
		add
		{
		}
		[Token(Token = "0x6002836")]
		[Address(RVA = "0xC1E610", Offset = "0xC1D610", VA = "0x180C1E610")]
		remove
		{
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x06002837 RID: 10295 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000144")]
	public static GameplayController Instance
	{
		[Token(Token = "0x6002837")]
		[Address(RVA = "0xC1E710", Offset = "0xC1D710", VA = "0x180C1E710")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002838 RID: 10296 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002838")]
	[Address(RVA = "0xC1E750", Offset = "0xC1D750", VA = "0x180C1E750")]
	private void Awake()
	{
	}

	// Token: 0x06002839 RID: 10297 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002839")]
	[Address(RVA = "0xC1EBC0", Offset = "0xC1DBC0", VA = "0x180C1EBC0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600283A RID: 10298 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600283A")]
	[Address(RVA = "0xC1F5C0", Offset = "0xC1E5C0", VA = "0x180C1F5C0")]
	private void Start()
	{
	}

	// Token: 0x0600283B RID: 10299 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600283B")]
	[Address(RVA = "0xC1F630", Offset = "0xC1E630", VA = "0x180C1F630")]
	public void DestroySelf()
	{
	}

	// Token: 0x0600283C RID: 10300 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600283C")]
	[Address(RVA = "0xC1F740", Offset = "0xC1E740", VA = "0x180C1F740")]
	public void UpdateConversationDelays()
	{
	}

	// Token: 0x0600283D RID: 10301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600283D")]
	[Address(RVA = "0xC1FB40", Offset = "0xC1EB40", VA = "0x180C1FB40")]
	public void AddNewMatch(MatchPreset match, Evidence newEntry)
	{
	}

	// Token: 0x0600283E RID: 10302 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600283E")]
	[Address(RVA = "0xC1FF20", Offset = "0xC1EF20", VA = "0x180C1FF20")]
	private void OnDiscoverMatchEvidence(Evidence ev)
	{
	}

	// Token: 0x0600283F RID: 10303 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600283F")]
	[Address(RVA = "0xC200A0", Offset = "0xC1F0A0", VA = "0x180C200A0")]
	public void UpdateMatchesEndOfFrame()
	{
	}

	// Token: 0x06002840 RID: 10304 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002840")]
	[Address(RVA = "0xC20170", Offset = "0xC1F170", VA = "0x180C20170")]
	public void RemoveMatch(MatchPreset match, Evidence newEntry)
	{
	}

	// Token: 0x06002841 RID: 10305 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002841")]
	[Address(RVA = "0xC203B0", Offset = "0xC1F3B0", VA = "0x180C203B0")]
	public void UpdateMatches()
	{
	}

	// Token: 0x06002842 RID: 10306 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002842")]
	[Address(RVA = "0xC21560", Offset = "0xC20560", VA = "0x180C21560")]
	public void AddHistory(Evidence entry, List<Evidence.DataKey> keys)
	{
	}

	// Token: 0x06002843 RID: 10307 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002843")]
	[Address(RVA = "0xC22880", Offset = "0xC21880", VA = "0x180C22880")]
	public void AddMoney(int addVal, bool displayMessage, string reason)
	{
	}

	// Token: 0x06002844 RID: 10308 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002844")]
	[Address(RVA = "0xC22DF0", Offset = "0xC21DF0", VA = "0x180C22DF0")]
	public void SetMoney(int newVal)
	{
	}

	// Token: 0x06002845 RID: 10309 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002845")]
	[Address(RVA = "0xC232A0", Offset = "0xC222A0", VA = "0x180C232A0")]
	public void AddSocialCredit(int addVal, bool displayMessage, string reason)
	{
	}

	// Token: 0x06002846 RID: 10310 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002846")]
	[Address(RVA = "0xC23590", Offset = "0xC22590", VA = "0x180C23590")]
	public void SetSocialCredit(int newVal)
	{
	}

	// Token: 0x06002847 RID: 10311 RVA: 0x0000F330 File Offset: 0x0000D530
	[Token(Token = "0x6002847")]
	[Address(RVA = "0xC236E0", Offset = "0xC226E0", VA = "0x180C236E0")]
	public int GetCurrentSocialCreditLevel()
	{
		return 0;
	}

	// Token: 0x06002848 RID: 10312 RVA: 0x0000F348 File Offset: 0x0000D548
	[Token(Token = "0x6002848")]
	[Address(RVA = "0xC236F0", Offset = "0xC226F0", VA = "0x180C236F0")]
	public int GetNextSocialCreditLevelThreshold()
	{
		return 0;
	}

	// Token: 0x06002849 RID: 10313 RVA: 0x0000F360 File Offset: 0x0000D560
	[Token(Token = "0x6002849")]
	[Address(RVA = "0xC23720", Offset = "0xC22720", VA = "0x180C23720")]
	public int GetSocialCreditLevel(int points)
	{
		return 0;
	}

	// Token: 0x0600284A RID: 10314 RVA: 0x0000F378 File Offset: 0x0000D578
	[Token(Token = "0x600284A")]
	[Address(RVA = "0xC23910", Offset = "0xC22910", VA = "0x180C23910")]
	public int GetSocialCreditThreshold(int points)
	{
		return 0;
	}

	// Token: 0x0600284B RID: 10315 RVA: 0x0000F390 File Offset: 0x0000D590
	[Token(Token = "0x600284B")]
	[Address(RVA = "0xC23940", Offset = "0xC22940", VA = "0x180C23940")]
	public int GetSocialCreditThresholdForLevel(int level)
	{
		return 0;
	}

	// Token: 0x0600284C RID: 10316 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600284C")]
	[Address(RVA = "0xC23A70", Offset = "0xC22A70", VA = "0x180C23A70")]
	public void AddLockpicks(int addVal, bool displayMessage)
	{
	}

	// Token: 0x0600284D RID: 10317 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600284D")]
	[Address(RVA = "0xC23D60", Offset = "0xC22D60", VA = "0x180C23D60")]
	public void SetLockpicks(int newVal)
	{
	}

	// Token: 0x0600284E RID: 10318 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600284E")]
	[Address(RVA = "0xC23ED0", Offset = "0xC22ED0", VA = "0x180C23ED0")]
	public void UseLockpick(float val)
	{
	}

	// Token: 0x0600284F RID: 10319 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600284F")]
	[Address(RVA = "0xC24050", Offset = "0xC23050", VA = "0x180C24050")]
	public void DepleteLockpick()
	{
	}

	// Token: 0x06002850 RID: 10320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002850")]
	[Address(RVA = "0xC24080", Offset = "0xC23080", VA = "0x180C24080")]
	public void AddGuestPass(NewAddress loc, float forHours)
	{
	}

	// Token: 0x06002851 RID: 10321 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002851")]
	[Address(RVA = "0xC246E0", Offset = "0xC236E0", VA = "0x180C246E0")]
	public void AddGuestPass(NewAddress loc, Vector2 directData)
	{
	}

	// Token: 0x06002852 RID: 10322 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002852")]
	[Address(RVA = "0xC24B00", Offset = "0xC23B00", VA = "0x180C24B00")]
	public void CallEnforcers(NewGameLocation newLocation, bool forceCrimeScene = false, bool immediateTeleport = false, float delay = 0f)
	{
	}

	// Token: 0x06002853 RID: 10323 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002853")]
	[Address(RVA = "0xC250E0", Offset = "0xC240E0", VA = "0x180C250E0")]
	private IEnumerator WaitForEndCall(NewGameLocation newLocation)
	{
		return null;
	}

	// Token: 0x06002854 RID: 10324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002854")]
	[Address(RVA = "0xC251F0", Offset = "0xC241F0", VA = "0x180C251F0")]
	private void NewMurderCaseNotify(NewGameLocation newLocation)
	{
	}

	// Token: 0x06002855 RID: 10325 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002855")]
	[Address(RVA = "0xC25BD0", Offset = "0xC24BD0", VA = "0x180C25BD0")]
	public void AddPasscode(GameplayController.Passcode newCode, bool displayMessage = true)
	{
	}

	// Token: 0x06002856 RID: 10326 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002856")]
	[Address(RVA = "0xC264C0", Offset = "0xC254C0", VA = "0x180C264C0")]
	public void AddOrMergePhoneNumberData(int newNumber, bool knowLocation, List<Human> knowCitizens, string textOverride = "", bool displayMessage = true)
	{
	}

	// Token: 0x06002857 RID: 10327 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002857")]
	[Address(RVA = "0xC26CC0", Offset = "0xC25CC0", VA = "0x180C26CC0")]
	public void AddDoorKnockAttempt(NewDoor door, Actor human)
	{
	}

	// Token: 0x06002858 RID: 10328 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
	[Token(Token = "0x6002858")]
	[Address(RVA = "0xC27010", Offset = "0xC26010", VA = "0x180C27010")]
	public float GetDoorKnockAttemptValue(NewDoor door, Actor human)
	{
		return 0f;
	}

	// Token: 0x06002859 RID: 10329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002859")]
	[Address(RVA = "0xC271F0", Offset = "0xC261F0", VA = "0x180C271F0")]
	public void KnockOnDoor(NewDoor door, Actor actor, int knocks = 2, float forceAdditionalUrgency = 0f)
	{
	}

	// Token: 0x0600285A RID: 10330 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600285A")]
	[Address(RVA = "0xC28010", Offset = "0xC27010", VA = "0x180C28010")]
	private IEnumerator DoorKnockSounds(NewDoor door, Actor actor, float nextUrgency, int knocks = 2)
	{
		return null;
	}

	// Token: 0x0600285B RID: 10331 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600285B")]
	[Address(RVA = "0x51E790", Offset = "0x51D790", VA = "0x18051E790")]
	public void SetJobDifficultyLevel(int newInt)
	{
	}

	// Token: 0x0600285C RID: 10332 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600285C")]
	[Address(RVA = "0xC28140", Offset = "0xC27140", VA = "0x180C28140")]
	public void AddToGraffitiCache(string obj, Material mat)
	{
	}

	// Token: 0x0600285D RID: 10333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600285D")]
	[Address(RVA = "0xC28350", Offset = "0xC27350", VA = "0x180C28350")]
	public void AddMotionTracker(Interactable newTracker, int range)
	{
	}

	// Token: 0x0600285E RID: 10334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600285E")]
	[Address(RVA = "0xC293F0", Offset = "0xC283F0", VA = "0x180C293F0")]
	public void RemoveMotionTracker(Interactable newTracker)
	{
	}

	// Token: 0x0600285F RID: 10335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600285F")]
	[Address(RVA = "0xC29850", Offset = "0xC28850", VA = "0x180C29850")]
	public void AddProxyDetonator(Interactable newTracker, float range)
	{
	}

	// Token: 0x06002860 RID: 10336 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002860")]
	[Address(RVA = "0xC29A80", Offset = "0xC28A80", VA = "0x180C29A80")]
	public void RemoveProxyDetonator(Interactable newTracker)
	{
	}

	// Token: 0x06002861 RID: 10337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002861")]
	[Address(RVA = "0xC29B80", Offset = "0xC28B80", VA = "0x180C29B80")]
	public void SetPlayerKnowsPassword(NewAddress newAddress)
	{
	}

	// Token: 0x06002862 RID: 10338 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002862")]
	[Address(RVA = "0xC29D60", Offset = "0xC28D60", VA = "0x180C29D60")]
	public void ProcessDynamicTextImages()
	{
	}

	// Token: 0x06002863 RID: 10339 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002863")]
	[Address(RVA = "0xC2AAA0", Offset = "0xC29AA0", VA = "0x180C2AAA0")]
	public void AddNewDebt(Company company, int amount, int paymentExtra, int repayments)
	{
	}

	// Token: 0x06002864 RID: 10340 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002864")]
	[Address(RVA = "0xC2B100", Offset = "0xC2A100", VA = "0x180C2B100")]
	public void DebtPayment(Company company)
	{
	}

	// Token: 0x06002865 RID: 10341 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002865")]
	[Address(RVA = "0xC2B710", Offset = "0xC2A710", VA = "0x180C2B710")]
	public void ShortDebtPayment(Company company, int amount)
	{
	}

	// Token: 0x06002866 RID: 10342 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002866")]
	[Address(RVA = "0xC2BBA0", Offset = "0xC2ABA0", VA = "0x180C2BBA0")]
	public void AddHotelGuest(Human human, bool expensiveRoom)
	{
	}

	// Token: 0x06002867 RID: 10343 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002867")]
	[Address(RVA = "0xC2CA10", Offset = "0xC2BA10", VA = "0x180C2CA10")]
	public void AddHotelGuest(NewAddress address, Human human, int cost)
	{
	}

	// Token: 0x06002868 RID: 10344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002868")]
	[Address(RVA = "0xC2D120", Offset = "0xC2C120", VA = "0x180C2D120")]
	public void RemoveHotelGuest(NewAddress address, Human human, bool removeKey = true)
	{
	}

	// Token: 0x06002869 RID: 10345 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002869")]
	[Address(RVA = "0xC2D530", Offset = "0xC2C530", VA = "0x180C2D530")]
	public GameplayController()
	{
	}

	// Token: 0x040032F2 RID: 13042
	[Token(Token = "0x40032F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<string, Evidence> evidenceDictionary;

	// Token: 0x040032F3 RID: 13043
	[Token(Token = "0x40032F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Fact> factList;

	// Token: 0x040032F4 RID: 13044
	[Token(Token = "0x40032F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Evidence> singletonEvidence;

	// Token: 0x040032F5 RID: 13045
	[Token(Token = "0x40032F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<EvidenceDate> dateEvidence;

	// Token: 0x040032F6 RID: 13046
	[Token(Token = "0x40032F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<EvidenceTime> timeEvidence;

	// Token: 0x040032F7 RID: 13047
	[Token(Token = "0x40032F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<EvidenceMultiPage> multiPageEvidence;

	// Token: 0x040032F8 RID: 13048
	[Token(Token = "0x40032F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<GameplayController.History> history;

	// Token: 0x040032F9 RID: 13049
	[Token(Token = "0x40032F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public List<GameplayController.History> itemOnlyHistory;

	// Token: 0x040032FA RID: 13050
	[Token(Token = "0x40032FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Dictionary<Vector3, Interactable> confirmedPrints;

	// Token: 0x040032FB RID: 13051
	[Token(Token = "0x40032FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int printsLetterLoop;

	// Token: 0x040032FC RID: 13052
	[Token(Token = "0x40032FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public HashSet<Interactable> objectsWithDynamicPrints;

	// Token: 0x040032FD RID: 13053
	[Token(Token = "0x40032FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Dictionary<MatchPreset, List<Evidence>> parentMatches;

	// Token: 0x040032FE RID: 13054
	[Token(Token = "0x40032FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Dictionary<MatchPreset, List<FactMatches>> matchesDetails;

	// Token: 0x040032FF RID: 13055
	[Token(Token = "0x40032FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Dictionary<NewAddress, Vector2> guestPasses;

	// Token: 0x04003300 RID: 13056
	[Token(Token = "0x4003300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Dictionary<int, StateSaveData.MessageThreadSave> messageThreads;

	// Token: 0x04003301 RID: 13057
	[Token(Token = "0x4003301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int assignMessageThreadID;

	// Token: 0x04003302 RID: 13058
	[Token(Token = "0x4003302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Human> enforcers;

	// Token: 0x04003303 RID: 13059
	[Token(Token = "0x4003303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Dictionary<NewGameLocation, GameplayController.EnforcerCall> enforcerCalls;

	// Token: 0x04003304 RID: 13060
	[Token(Token = "0x4003304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Dictionary<Case, float> caseProcessing;

	// Token: 0x04003305 RID: 13061
	[Token(Token = "0x4003305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<Interactable> hospitalBeds;

	// Token: 0x04003306 RID: 13062
	[Token(Token = "0x4003306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Dictionary<Vector3, float> brokenWindows;

	// Token: 0x04003307 RID: 13063
	[Token(Token = "0x4003307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Dictionary<NewDoor, List<GameplayController.DoorKnockAttempt>> doorKnockAttempts;

	// Token: 0x04003308 RID: 13064
	[Token(Token = "0x4003308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<Interactable> activeGadgets;

	// Token: 0x04003309 RID: 13065
	[Token(Token = "0x4003309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public HashSet<NewGameLocation> crimeScenes;

	// Token: 0x0400330A RID: 13066
	[Token(Token = "0x400330A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<NewDoor> policeTapeDoors;

	// Token: 0x0400330B RID: 13067
	[Token(Token = "0x400330B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public List<NewGameLocation> crimeSceneCleanups;

	// Token: 0x0400330C RID: 13068
	[Token(Token = "0x400330C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<Interactable> closedBreakers;

	// Token: 0x0400330D RID: 13069
	[Token(Token = "0x400330D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<Interactable> turnedOffSecurity;

	// Token: 0x0400330E RID: 13070
	[Token(Token = "0x400330E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public List<Interactable> burningBarrels;

	// Token: 0x0400330F RID: 13071
	[Token(Token = "0x400330F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Dictionary<Interactable, float> switchRessetingObjects;

	// Token: 0x04003310 RID: 13072
	[Token(Token = "0x4003310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public List<int> playerKnowsPasswords;

	// Token: 0x04003311 RID: 13073
	[Token(Token = "0x4003311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public List<NewRoom> gasRooms;

	// Token: 0x04003312 RID: 13074
	[Token(Token = "0x4003312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public List<string> companiesSabotaged;

	// Token: 0x04003313 RID: 13075
	[Token(Token = "0x4003313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Dictionary<string, float> globalConversationDelay;

	// Token: 0x04003314 RID: 13076
	[Token(Token = "0x4003314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public List<string> booksRead;

	// Token: 0x04003315 RID: 13077
	[Token(Token = "0x4003315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public List<Interactable> activeKettles;

	// Token: 0x04003316 RID: 13078
	[Token(Token = "0x4003316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public List<Interactable> activeMusicPlayers;

	// Token: 0x04003317 RID: 13079
	[Token(Token = "0x4003317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Dictionary<string, Material> graffitiCache;

	// Token: 0x04003318 RID: 13080
	[Token(Token = "0x4003318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Dictionary<Interactable, List<NewNode>> activeTrackers;

	// Token: 0x04003319 RID: 13081
	[Token(Token = "0x4003319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public HashSet<NewNode> trackedNodes;

	// Token: 0x0400331A RID: 13082
	[Token(Token = "0x400331A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Dictionary<Interactable, float> proxyTrackers;

	// Token: 0x0400331B RID: 13083
	[Token(Token = "0x400331B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public List<Interactable> activeGrenades;

	// Token: 0x0400331C RID: 13084
	[Token(Token = "0x400331C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public GameObject setDefaultItemButton;

	// Token: 0x0400331D RID: 13085
	[Token(Token = "0x400331D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public GameObject defaultItemButton;

	// Token: 0x0400331E RID: 13086
	[Token(Token = "0x400331E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public int money;

	// Token: 0x0400331F RID: 13087
	[Token(Token = "0x400331F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	public int lockPicks;

	// Token: 0x04003320 RID: 13088
	[Token(Token = "0x4003320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public int socialCredit;

	// Token: 0x04003321 RID: 13089
	[Token(Token = "0x4003321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public List<SocialControls.SocialCreditBuff> socialCreditPerks;

	// Token: 0x04003322 RID: 13090
	[Token(Token = "0x4003322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public float currentLockpickStrength;

	// Token: 0x04003323 RID: 13091
	[Token(Token = "0x4003323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	public int perilFine;

	// Token: 0x04003324 RID: 13092
	[Token(Token = "0x4003324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public string[] doeLetters;

	// Token: 0x04003325 RID: 13093
	[Token(Token = "0x4003325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public float timeSinceLastUpdateLoop;

	// Token: 0x04003326 RID: 13094
	[Token(Token = "0x4003326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	public float lastUpdateLoop;

	// Token: 0x04003327 RID: 13095
	[Token(Token = "0x4003327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public List<GameplayController.Passcode> acquiredPasscodes;

	// Token: 0x04003328 RID: 13096
	[Token(Token = "0x4003328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public List<GameplayController.PhoneNumber> acquiredNumbers;

	// Token: 0x04003329 RID: 13097
	[Token(Token = "0x4003329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public List<NewAddress> forSale;

	// Token: 0x0400332A RID: 13098
	[Token(Token = "0x400332A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public List<GameplayController.HotelGuest> hotelGuests;

	// Token: 0x0400332B RID: 13099
	[Token(Token = "0x400332B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public List<NewRoom> roomsVicinity;

	// Token: 0x0400332C RID: 13100
	[Token(Token = "0x400332C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public List<AirDuctGroup> ductsVicinity;

	// Token: 0x0400332D RID: 13101
	[Token(Token = "0x400332D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public HashSet<Human> activeRagdolls;

	// Token: 0x0400332E RID: 13102
	[Token(Token = "0x400332E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public HashSet<Interactable> activePhysics;

	// Token: 0x0400332F RID: 13103
	[Token(Token = "0x400332F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public List<SpatterSimulation> spatter;

	// Token: 0x04003330 RID: 13104
	[Token(Token = "0x4003330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	public List<Interactable> interactablesMoved;

	// Token: 0x04003331 RID: 13105
	[Token(Token = "0x4003331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	public HashSet<NewDoor> damagedDoors;

	// Token: 0x04003332 RID: 13106
	[Token(Token = "0x4003332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public List<NewBuilding> activeAlarmsBuildings;

	// Token: 0x04003333 RID: 13107
	[Token(Token = "0x4003333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public List<NewAddress> activeAlarmsLocations;

	// Token: 0x04003334 RID: 13108
	[Token(Token = "0x4003334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public List<NewBuilding> alteredSecurityTargetsBuildings;

	// Token: 0x04003335 RID: 13109
	[Token(Token = "0x4003335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public List<NewAddress> alteredSecurityTargetsLocations;

	// Token: 0x04003336 RID: 13110
	[Token(Token = "0x4003336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	public List<GameplayController.Footprint> footprintsList;

	// Token: 0x04003337 RID: 13111
	[Token(Token = "0x4003337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public Dictionary<NewRoom, List<GameplayController.Footprint>> activeFootprints;

	// Token: 0x04003338 RID: 13112
	[Token(Token = "0x4003338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public Dictionary<Vector3, Interactable> confirmedFootprints;

	// Token: 0x04003339 RID: 13113
	[Token(Token = "0x4003339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	public Dictionary<ArtPreset, Material> dynamicTextImages;

	// Token: 0x0400333A RID: 13114
	[Token(Token = "0x400333A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public List<Texture2D> generatedTextures;

	// Token: 0x0400333B RID: 13115
	[Token(Token = "0x400333B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public List<GameplayController.LoanDebt> debt;

	// Token: 0x0400333C RID: 13116
	[Token(Token = "0x400333C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public int jobDifficultyLevel;

	// Token: 0x04003340 RID: 13120
	[Token(Token = "0x4003340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	private Action UpdateMatch;

	// Token: 0x04003341 RID: 13121
	[Token(Token = "0x4003341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameplayController _instance;

	// Token: 0x0200071D RID: 1821
	[Token(Token = "0x200071D")]
	[Serializable]
	public class History
	{
		// Token: 0x0600286A RID: 10346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600286A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public History()
		{
		}

		// Token: 0x04003342 RID: 13122
		[Token(Token = "0x4003342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string evID;

		// Token: 0x04003343 RID: 13123
		[Token(Token = "0x4003343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Evidence.DataKey> keys;

		// Token: 0x04003344 RID: 13124
		[Token(Token = "0x4003344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float lastAccess;

		// Token: 0x04003345 RID: 13125
		[Token(Token = "0x4003345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int locationID;
	}

	// Token: 0x0200071E RID: 1822
	[Token(Token = "0x200071E")]
	[Serializable]
	public class LostAndFound
	{
		// Token: 0x0600286B RID: 10347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600286B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public LostAndFound()
		{
		}

		// Token: 0x04003346 RID: 13126
		[Token(Token = "0x4003346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string preset;

		// Token: 0x04003347 RID: 13127
		[Token(Token = "0x4003347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int ownerID;

		// Token: 0x04003348 RID: 13128
		[Token(Token = "0x4003348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int buildingID;

		// Token: 0x04003349 RID: 13129
		[Token(Token = "0x4003349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int spawnedItem;

		// Token: 0x0400334A RID: 13130
		[Token(Token = "0x400334A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int spawnedNote;

		// Token: 0x0400334B RID: 13131
		[Token(Token = "0x400334B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int rewardMoney;

		// Token: 0x0400334C RID: 13132
		[Token(Token = "0x400334C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int rewardSC;
	}

	// Token: 0x0200071F RID: 1823
	[Token(Token = "0x200071F")]
	public class DoorKnockAttempt
	{
		// Token: 0x0600286C RID: 10348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600286C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DoorKnockAttempt()
		{
		}

		// Token: 0x0400334D RID: 13133
		[Token(Token = "0x400334D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Actor human;

		// Token: 0x0400334E RID: 13134
		[Token(Token = "0x400334E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float value;
	}

	// Token: 0x02000720 RID: 1824
	[Token(Token = "0x2000720")]
	[Serializable]
	public class Passcode
	{
		// Token: 0x0600286D RID: 10349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600286D")]
		[Address(RVA = "0xC4DAC0", Offset = "0xC4CAC0", VA = "0x180C4DAC0")]
		public Passcode(GameplayController.PasscodeType newType)
		{
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600286E")]
		[Address(RVA = "0xC4DC20", Offset = "0xC4CC20", VA = "0x180C4DC20")]
		public string GetNotePlacements()
		{
			return null;
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600286F")]
		[Address(RVA = "0xC4E360", Offset = "0xC4D360", VA = "0x180C4E360")]
		public List<int> GetDigits()
		{
			return null;
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		[Token(Token = "0x6002870")]
		[Address(RVA = "0xC4E650", Offset = "0xC4D650", VA = "0x180C4E650")]
		public int GetDigit(int index)
		{
			return 0;
		}

		// Token: 0x0400334F RID: 13135
		[Token(Token = "0x400334F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<int> digits;

		// Token: 0x04003350 RID: 13136
		[Token(Token = "0x4003350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameplayController.PasscodeType type;

		// Token: 0x04003351 RID: 13137
		[Token(Token = "0x4003351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int id;

		// Token: 0x04003352 RID: 13138
		[Token(Token = "0x4003352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool used;

		// Token: 0x04003353 RID: 13139
		[Token(Token = "0x4003353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<int> notes;
	}

	// Token: 0x02000721 RID: 1825
	[Token(Token = "0x2000721")]
	public enum PasscodeType
	{
		// Token: 0x04003355 RID: 13141
		[Token(Token = "0x4003355")]
		citizen,
		// Token: 0x04003356 RID: 13142
		[Token(Token = "0x4003356")]
		room,
		// Token: 0x04003357 RID: 13143
		[Token(Token = "0x4003357")]
		address,
		// Token: 0x04003358 RID: 13144
		[Token(Token = "0x4003358")]
		interactable
	}

	// Token: 0x02000722 RID: 1826
	[Token(Token = "0x2000722")]
	[Serializable]
	public class PhoneNumber
	{
		// Token: 0x06002871 RID: 10353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002871")]
		[Address(RVA = "0xC4EA00", Offset = "0xC4DA00", VA = "0x180C4EA00")]
		public PhoneNumber()
		{
		}

		// Token: 0x04003359 RID: 13145
		[Token(Token = "0x4003359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int number;

		// Token: 0x0400335A RID: 13146
		[Token(Token = "0x400335A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string textOverride;

		// Token: 0x0400335B RID: 13147
		[Token(Token = "0x400335B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool loc;

		// Token: 0x0400335C RID: 13148
		[Token(Token = "0x400335C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<int> p;
	}

	// Token: 0x02000723 RID: 1827
	[Token(Token = "0x2000723")]
	[Serializable]
	public class HotelGuest
	{
		// Token: 0x06002872 RID: 10354 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002872")]
		[Address(RVA = "0x49F440", Offset = "0x49E440", VA = "0x18049F440")]
		public Human GetHuman()
		{
			return null;
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002873")]
		[Address(RVA = "0xC4EAC0", Offset = "0xC4DAC0", VA = "0x180C4EAC0")]
		public NewAddress GetAddress()
		{
			return null;
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002874")]
		[Address(RVA = "0xC4EB60", Offset = "0xC4DB60", VA = "0x180C4EB60")]
		public void PayBill(int amount)
		{
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002875")]
		[Address(RVA = "0xC4EBC0", Offset = "0xC4DBC0", VA = "0x180C4EBC0")]
		public void FromLoadGame()
		{
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002876")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public HotelGuest()
		{
		}

		// Token: 0x0400335D RID: 13149
		[Token(Token = "0x400335D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int addID;

		// Token: 0x0400335E RID: 13150
		[Token(Token = "0x400335E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int humanID;

		// Token: 0x0400335F RID: 13151
		[Token(Token = "0x400335F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int roomCost;

		// Token: 0x04003360 RID: 13152
		[Token(Token = "0x4003360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int bill;

		// Token: 0x04003361 RID: 13153
		[Token(Token = "0x4003361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float lastPayment;

		// Token: 0x04003362 RID: 13154
		[Token(Token = "0x4003362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float nextPayment;
	}

	// Token: 0x02000724 RID: 1828
	[Token(Token = "0x2000724")]
	[Serializable]
	public class EnforcerCall
	{
		// Token: 0x06002877 RID: 10359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002877")]
		[Address(RVA = "0xC4EDB0", Offset = "0xC4DDB0", VA = "0x180C4EDB0")]
		public EnforcerCall()
		{
		}

		// Token: 0x04003363 RID: 13155
		[Token(Token = "0x4003363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isStreet;

		// Token: 0x04003364 RID: 13156
		[Token(Token = "0x4003364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int id;

		// Token: 0x04003365 RID: 13157
		[Token(Token = "0x4003365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float logTime;

		// Token: 0x04003366 RID: 13158
		[Token(Token = "0x4003366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public GameplayController.EnforcerCallState state;

		// Token: 0x04003367 RID: 13159
		[Token(Token = "0x4003367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<int> response;

		// Token: 0x04003368 RID: 13160
		[Token(Token = "0x4003368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float arrivalTime;

		// Token: 0x04003369 RID: 13161
		[Token(Token = "0x4003369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool isCrimeScene;

		// Token: 0x0400336A RID: 13162
		[Token(Token = "0x400336A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool immedaiteTeleport;

		// Token: 0x0400336B RID: 13163
		[Token(Token = "0x400336B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int guard;

		// Token: 0x0400336C RID: 13164
		[Token(Token = "0x400336C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float delay;
	}

	// Token: 0x02000725 RID: 1829
	[Token(Token = "0x2000725")]
	public enum EnforcerCallState
	{
		// Token: 0x0400336E RID: 13166
		[Token(Token = "0x400336E")]
		logged,
		// Token: 0x0400336F RID: 13167
		[Token(Token = "0x400336F")]
		responding,
		// Token: 0x04003370 RID: 13168
		[Token(Token = "0x4003370")]
		arrived,
		// Token: 0x04003371 RID: 13169
		[Token(Token = "0x4003371")]
		completed
	}

	// Token: 0x02000726 RID: 1830
	[Token(Token = "0x2000726")]
	[Serializable]
	public class Footprint
	{
		// Token: 0x06002878 RID: 10360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002878")]
		[Address(RVA = "0xC4EDC0", Offset = "0xC4DDC0", VA = "0x180C4EDC0")]
		public Footprint(Human human, Vector3 position, Vector3 euler, float dirt, float blood, [Optional] NewRoom forceRoom)
		{
		}

		// Token: 0x04003372 RID: 13170
		[Token(Token = "0x4003372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int hID;

		// Token: 0x04003373 RID: 13171
		[Token(Token = "0x4003373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int rID;

		// Token: 0x04003374 RID: 13172
		[Token(Token = "0x4003374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 wP;

		// Token: 0x04003375 RID: 13173
		[Token(Token = "0x4003375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 eU;

		// Token: 0x04003376 RID: 13174
		[Token(Token = "0x4003376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float str;

		// Token: 0x04003377 RID: 13175
		[Token(Token = "0x4003377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float bl;

		// Token: 0x04003378 RID: 13176
		[Token(Token = "0x4003378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float t;
	}

	// Token: 0x02000727 RID: 1831
	[Token(Token = "0x2000727")]
	[Serializable]
	public class LoanDebt
	{
		// Token: 0x06002879 RID: 10361 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		[Token(Token = "0x6002879")]
		[Address(RVA = "0xC4F3F0", Offset = "0xC4E3F0", VA = "0x180C4F3F0")]
		public int GetRepaymentAmount()
		{
			return 0;
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600287A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public LoanDebt()
		{
		}

		// Token: 0x04003379 RID: 13177
		[Token(Token = "0x4003379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int companyID;

		// Token: 0x0400337A RID: 13178
		[Token(Token = "0x400337A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int debt;

		// Token: 0x0400337B RID: 13179
		[Token(Token = "0x400337B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int payments;

		// Token: 0x0400337C RID: 13180
		[Token(Token = "0x400337C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int missedPayments;

		// Token: 0x0400337D RID: 13181
		[Token(Token = "0x400337D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float nextPaymentDueBy;

		// Token: 0x0400337E RID: 13182
		[Token(Token = "0x400337E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dueCheck;
	}

	// Token: 0x02000728 RID: 1832
	// (Invoke) Token: 0x0600287C RID: 10364
	[Token(Token = "0x2000728")]
	public delegate void MatchesChange();

	// Token: 0x02000729 RID: 1833
	// (Invoke) Token: 0x06002880 RID: 10368
	[Token(Token = "0x2000729")]
	public delegate void NewEvidenceHistory();

	// Token: 0x0200072A RID: 1834
	// (Invoke) Token: 0x06002884 RID: 10372
	[Token(Token = "0x200072A")]
	public delegate void NewPhoneData();

	// Token: 0x0200072B RID: 1835
	[Token(Token = "0x200072B")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06002888 RID: 10376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002888")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		[Token(Token = "0x6002889")]
		[Address(RVA = "0xC4F4B0", Offset = "0xC4E4B0", VA = "0x180C4F4B0")]
		internal bool <UpdateMatches>b__111_0(Evidence item)
		{
			return default(bool);
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x0000F408 File Offset: 0x0000D608
		[Token(Token = "0x600288A")]
		[Address(RVA = "0xC4F4B0", Offset = "0xC4E4B0", VA = "0x180C4F4B0")]
		internal bool <UpdateMatches>b__111_1(Evidence item)
		{
			return default(bool);
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x0000F420 File Offset: 0x0000D620
		[Token(Token = "0x600288B")]
		[Address(RVA = "0xB2F380", Offset = "0xB2E380", VA = "0x180B2F380")]
		internal int <AddHistory>b__112_1(GameplayController.History p1, GameplayController.History p2)
		{
			return 0;
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x0000F438 File Offset: 0x0000D638
		[Token(Token = "0x600288C")]
		[Address(RVA = "0xB2F380", Offset = "0xB2E380", VA = "0x180B2F380")]
		internal int <AddHistory>b__112_2(GameplayController.History p1, GameplayController.History p2)
		{
			return 0;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0000F450 File Offset: 0x0000D650
		[Token(Token = "0x600288D")]
		[Address(RVA = "0xC4F4D0", Offset = "0xC4E4D0", VA = "0x180C4F4D0")]
		internal bool <ProcessDynamicTextImages>b__144_0(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x0000F468 File Offset: 0x0000D668
		[Token(Token = "0x600288E")]
		[Address(RVA = "0xC4F570", Offset = "0xC4E570", VA = "0x180C4F570")]
		internal bool <ProcessDynamicTextImages>b__144_1(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x0400337F RID: 13183
		[Token(Token = "0x400337F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly GameplayController.<>c <>9;

		// Token: 0x04003380 RID: 13184
		[Token(Token = "0x4003380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Evidence> <>9__111_0;

		// Token: 0x04003381 RID: 13185
		[Token(Token = "0x4003381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<Evidence> <>9__111_1;

		// Token: 0x04003382 RID: 13186
		[Token(Token = "0x4003382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Comparison<GameplayController.History> <>9__112_1;

		// Token: 0x04003383 RID: 13187
		[Token(Token = "0x4003383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Comparison<GameplayController.History> <>9__112_2;

		// Token: 0x04003384 RID: 13188
		[Token(Token = "0x4003384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<NewAddress> <>9__144_0;

		// Token: 0x04003385 RID: 13189
		[Token(Token = "0x4003385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<NewAddress> <>9__144_1;
	}

	// Token: 0x0200072C RID: 1836
	[Token(Token = "0x200072C")]
	private sealed class <>c__DisplayClass112_0
	{
		// Token: 0x0600288F RID: 10383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600288F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass112_0()
		{
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x0000F480 File Offset: 0x0000D680
		[Token(Token = "0x6002890")]
		[Address(RVA = "0xC4F610", Offset = "0xC4E610", VA = "0x180C4F610")]
		internal bool <AddHistory>b__0(GameplayController.History item)
		{
			return default(bool);
		}

		// Token: 0x04003386 RID: 13190
		[Token(Token = "0x4003386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Evidence entry;
	}

	// Token: 0x0200072D RID: 1837
	[Token(Token = "0x200072D")]
	private sealed class <>c__DisplayClass112_1
	{
		// Token: 0x06002891 RID: 10385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002891")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass112_1()
		{
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x0000F498 File Offset: 0x0000D698
		[Token(Token = "0x6002892")]
		[Address(RVA = "0xB7E910", Offset = "0xB7D910", VA = "0x180B7E910")]
		internal bool <AddHistory>b__3(GameplayController.History item)
		{
			return default(bool);
		}

		// Token: 0x04003387 RID: 13191
		[Token(Token = "0x4003387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameplayController.History lastItem;
	}

	// Token: 0x0200072E RID: 1838
	[Token(Token = "0x200072E")]
	private sealed class <WaitForEndCall>d__129 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x06002893 RID: 10387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002893")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <WaitForEndCall>d__129(int <>1__state)
		{
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002894")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		[Token(Token = "0x6002895")]
		[Address(RVA = "0xC4F680", Offset = "0xC4E680", VA = "0x180C4F680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000145")]
		private object Current
		{
			[Token(Token = "0x6002896")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002897")]
		[Address(RVA = "0xC4F780", Offset = "0xC4E780", VA = "0x180C4F780", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000146")]
		private object Current
		{
			[Token(Token = "0x6002898")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04003388 RID: 13192
		[Token(Token = "0x4003388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04003389 RID: 13193
		[Token(Token = "0x4003389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400338A RID: 13194
		[Token(Token = "0x400338A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameplayController <>4__this;

		// Token: 0x0400338B RID: 13195
		[Token(Token = "0x400338B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NewGameLocation newLocation;
	}

	// Token: 0x0200072F RID: 1839
	[Token(Token = "0x200072F")]
	private sealed class <>c__DisplayClass130_0
	{
		// Token: 0x06002899 RID: 10393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002899")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass130_0()
		{
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		[Token(Token = "0x600289A")]
		[Address(RVA = "0xC4F7D0", Offset = "0xC4E7D0", VA = "0x180C4F7D0")]
		internal bool <NewMurderCaseNotify>b__0(Actor item)
		{
			return default(bool);
		}

		// Token: 0x0400338C RID: 13196
		[Token(Token = "0x400338C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MurderController.Murder m;
	}

	// Token: 0x02000730 RID: 1840
	[Token(Token = "0x2000730")]
	private sealed class <>c__DisplayClass131_0
	{
		// Token: 0x0600289B RID: 10395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600289B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass131_0()
		{
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		[Token(Token = "0x600289C")]
		[Address(RVA = "0x51E920", Offset = "0x51D920", VA = "0x18051E920")]
		internal bool <AddPasscode>b__0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x0400338D RID: 13197
		[Token(Token = "0x400338D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameplayController.Passcode newCode;
	}

	// Token: 0x02000731 RID: 1841
	[Token(Token = "0x2000731")]
	private sealed class <>c__DisplayClass132_0
	{
		// Token: 0x0600289D RID: 10397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600289D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass132_0()
		{
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		[Token(Token = "0x600289E")]
		[Address(RVA = "0x480FC0", Offset = "0x47FFC0", VA = "0x180480FC0")]
		internal bool <AddOrMergePhoneNumberData>b__0(GameplayController.PhoneNumber item)
		{
			return default(bool);
		}

		// Token: 0x0400338E RID: 13198
		[Token(Token = "0x400338E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int newNumber;
	}

	// Token: 0x02000732 RID: 1842
	[Token(Token = "0x2000732")]
	private sealed class <>c__DisplayClass133_0
	{
		// Token: 0x0600289F RID: 10399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600289F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass133_0()
		{
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x0000F510 File Offset: 0x0000D710
		[Token(Token = "0x60028A0")]
		[Address(RVA = "0xC4F970", Offset = "0xC4E970", VA = "0x180C4F970")]
		internal bool <AddDoorKnockAttempt>b__0(GameplayController.DoorKnockAttempt item)
		{
			return default(bool);
		}

		// Token: 0x0400338F RID: 13199
		[Token(Token = "0x400338F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Actor human;
	}

	// Token: 0x02000733 RID: 1843
	[Token(Token = "0x2000733")]
	private sealed class <>c__DisplayClass134_0
	{
		// Token: 0x060028A1 RID: 10401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass134_0()
		{
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x0000F528 File Offset: 0x0000D728
		[Token(Token = "0x60028A2")]
		[Address(RVA = "0xC4FB20", Offset = "0xC4EB20", VA = "0x180C4FB20")]
		internal bool <GetDoorKnockAttemptValue>b__0(GameplayController.DoorKnockAttempt item)
		{
			return default(bool);
		}

		// Token: 0x04003390 RID: 13200
		[Token(Token = "0x4003390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Actor human;
	}

	// Token: 0x02000734 RID: 1844
	[Token(Token = "0x2000734")]
	private sealed class <DoorKnockSounds>d__136 : IEnumerator<object>, IDisposable, IEnumerator
	{
		// Token: 0x060028A3 RID: 10403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A3")]
		[Address(RVA = "0x3E8860", Offset = "0x3E7860", VA = "0x1803E8860")]
		public <DoorKnockSounds>d__136(int <>1__state)
		{
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x0000F540 File Offset: 0x0000D740
		[Token(Token = "0x60028A5")]
		[Address(RVA = "0xC4FCD0", Offset = "0xC4ECD0", VA = "0x180C4FCD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000147")]
		private object Current
		{
			[Token(Token = "0x60028A6")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A7")]
		[Address(RVA = "0xC50660", Offset = "0xC4F660", VA = "0x180C50660", Slot = "8")]
		private void Reset()
		{
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000148")]
		private object Current
		{
			[Token(Token = "0x60028A8")]
			[Address(RVA = "0x3E8CD0", Offset = "0x3E7CD0", VA = "0x1803E8CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x04003391 RID: 13201
		[Token(Token = "0x4003391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04003392 RID: 13202
		[Token(Token = "0x4003392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04003393 RID: 13203
		[Token(Token = "0x4003393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NewDoor door;

		// Token: 0x04003394 RID: 13204
		[Token(Token = "0x4003394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float nextUrgency;

		// Token: 0x04003395 RID: 13205
		[Token(Token = "0x4003395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Actor actor;

		// Token: 0x04003396 RID: 13206
		[Token(Token = "0x4003396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int knocks;

		// Token: 0x04003397 RID: 13207
		[Token(Token = "0x4003397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <vol>5__2;

		// Token: 0x04003398 RID: 13208
		[Token(Token = "0x4003398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <delay>5__3;

		// Token: 0x04003399 RID: 13209
		[Token(Token = "0x4003399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioEvent <knockAudio>5__4;
	}

	// Token: 0x02000735 RID: 1845
	[Token(Token = "0x2000735")]
	private sealed class <>c__DisplayClass145_0
	{
		// Token: 0x060028A9 RID: 10409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass145_0()
		{
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x0000F558 File Offset: 0x0000D758
		[Token(Token = "0x60028AA")]
		[Address(RVA = "0xC506B0", Offset = "0xC4F6B0", VA = "0x180C506B0")]
		internal bool <AddNewDebt>b__0(GameplayController.LoanDebt item)
		{
			return default(bool);
		}

		// Token: 0x0400339A RID: 13210
		[Token(Token = "0x400339A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Company company;
	}

	// Token: 0x02000736 RID: 1846
	[Token(Token = "0x2000736")]
	private sealed class <>c__DisplayClass146_0
	{
		// Token: 0x060028AB RID: 10411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass146_0()
		{
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x0000F570 File Offset: 0x0000D770
		[Token(Token = "0x60028AC")]
		[Address(RVA = "0xC506B0", Offset = "0xC4F6B0", VA = "0x180C506B0")]
		internal bool <DebtPayment>b__0(GameplayController.LoanDebt item)
		{
			return default(bool);
		}

		// Token: 0x0400339B RID: 13211
		[Token(Token = "0x400339B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Company company;
	}

	// Token: 0x02000737 RID: 1847
	[Token(Token = "0x2000737")]
	private sealed class <>c__DisplayClass147_0
	{
		// Token: 0x060028AD RID: 10413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass147_0()
		{
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x0000F588 File Offset: 0x0000D788
		[Token(Token = "0x60028AE")]
		[Address(RVA = "0xC506B0", Offset = "0xC4F6B0", VA = "0x180C506B0")]
		internal bool <ShortDebtPayment>b__0(GameplayController.LoanDebt item)
		{
			return default(bool);
		}

		// Token: 0x0400339C RID: 13212
		[Token(Token = "0x400339C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Company company;
	}

	// Token: 0x02000738 RID: 1848
	[Token(Token = "0x2000738")]
	private sealed class <>c__DisplayClass148_0
	{
		// Token: 0x060028AF RID: 10415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass148_0()
		{
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		[Token(Token = "0x60028B0")]
		[Address(RVA = "0xC506E0", Offset = "0xC4F6E0", VA = "0x180C506E0")]
		internal bool <AddHotelGuest>b__0(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x0400339D RID: 13213
		[Token(Token = "0x400339D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human human;
	}

	// Token: 0x02000739 RID: 1849
	[Token(Token = "0x2000739")]
	private sealed class <>c__DisplayClass148_1
	{
		// Token: 0x060028B1 RID: 10417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B1")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass148_1()
		{
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		[Token(Token = "0x60028B2")]
		[Address(RVA = "0x51ED50", Offset = "0x51DD50", VA = "0x18051ED50")]
		internal bool <AddHotelGuest>b__1(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x0400339E RID: 13214
		[Token(Token = "0x400339E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameplayController.HotelGuest g;
	}

	// Token: 0x0200073A RID: 1850
	[Token(Token = "0x200073A")]
	private sealed class <>c__DisplayClass150_0
	{
		// Token: 0x060028B3 RID: 10419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass150_0()
		{
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		[Token(Token = "0x60028B4")]
		[Address(RVA = "0xC50980", Offset = "0xC4F980", VA = "0x180C50980")]
		internal bool <RemoveHotelGuest>b__0(GameplayController.HotelGuest item)
		{
			return default(bool);
		}

		// Token: 0x0400339F RID: 13215
		[Token(Token = "0x400339F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewAddress address;

		// Token: 0x040033A0 RID: 13216
		[Token(Token = "0x40033A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Human human;
	}
}
