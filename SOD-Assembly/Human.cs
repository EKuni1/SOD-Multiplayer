using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000053 RID: 83
[Token(Token = "0x2000053")]
public class Human : Actor, IEnumerator<object>
{
	// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600032E")]
	[Address(RVA = "0x74B1E0", Offset = "0x74A1E0", VA = "0x18074B1E0")]
	public void SetJob(Occupation newJob)
	{
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600032F")]
	[Address(RVA = "0x74C7C0", Offset = "0x74B7C0", VA = "0x18074C7C0")]
	public void SetPlayerGender()
	{
	}

	// Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000330")]
	[Address(RVA = "0x74C910", Offset = "0x74B910", VA = "0x18074C910")]
	public void SetSexualityAndGender()
	{
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000331")]
	[Address(RVA = "0x74D490", Offset = "0x74C490", VA = "0x18074D490")]
	private void SetBirthGender()
	{
	}

	// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000332")]
	[Address(RVA = "0x74D620", Offset = "0x74C620", VA = "0x18074D620")]
	public void GenerateSuitableGenderAndSexualityForParnter(Citizen newPartner)
	{
	}

	// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000333")]
	[Address(RVA = "0x74E680", Offset = "0x74D680", VA = "0x18074E680")]
	public void SetPersonality()
	{
	}

	// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000334")]
	[Address(RVA = "0x750430", Offset = "0x74F430", VA = "0x180750430")]
	private void SetupPotentialModifierFlagsByTraits()
	{
	}

	// Token: 0x06000335 RID: 821 RVA: 0x00003078 File Offset: 0x00001278
	[Token(Token = "0x6000335")]
	[Address(RVA = "0x7509A0", Offset = "0x74F9A0", VA = "0x1807509A0")]
	private float GetTraitChance(CharacterTrait trait)
	{
		return 0f;
	}

	// Token: 0x06000336 RID: 822 RVA: 0x00003090 File Offset: 0x00001290
	[Token(Token = "0x6000336")]
	[Address(RVA = "0x751220", Offset = "0x750220", VA = "0x180751220")]
	public bool TraitExists(CharacterTrait searchTrait)
	{
		return default(bool);
	}

	// Token: 0x06000337 RID: 823 RVA: 0x000030A8 File Offset: 0x000012A8
	[Token(Token = "0x6000337")]
	[Address(RVA = "0x751390", Offset = "0x750390", VA = "0x180751390")]
	public float GetChance(ref List<CharacterTrait.TraitPickRule> pickRules, float baseChance)
	{
		return 0f;
	}

	// Token: 0x06000338 RID: 824 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000338")]
	[Address(RVA = "0x751D00", Offset = "0x750D00", VA = "0x180751D00")]
	public Human.Trait AddCharacterTrait(CharacterTrait newTrait)
	{
		return null;
	}

	// Token: 0x06000339 RID: 825 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000339")]
	[Address(RVA = "0x7534C0", Offset = "0x7524C0", VA = "0x1807534C0")]
	public void SetPartner(Citizen newLover)
	{
	}

	// Token: 0x0600033A RID: 826 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600033A")]
	[Address(RVA = "0x753670", Offset = "0x752670", VA = "0x180753670", Slot = "58")]
	public virtual void SetResidence(ResidenceController newHome, bool removePreviousResidence = true)
	{
	}

	// Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600033B")]
	[Address(RVA = "0x754560", Offset = "0x753560", VA = "0x180754560", Slot = "59")]
	public virtual void SetDen(NewAddress newAddress, [Optional] MurderMO decorateUsingRules)
	{
	}

	// Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600033C")]
	[Address(RVA = "0x754F20", Offset = "0x753F20", VA = "0x180754F20")]
	public void UpdateTickRateOnProx()
	{
	}

	// Token: 0x0600033D RID: 829 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600033D")]
	[Address(RVA = "0x7558C0", Offset = "0x7548C0", VA = "0x1807558C0")]
	public void SetupGeneral()
	{
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600033E")]
	[Address(RVA = "0x756370", Offset = "0x755370", VA = "0x180756370")]
	private void GenerateBloodType()
	{
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600033F")]
	[Address(RVA = "0x7568C0", Offset = "0x7558C0", VA = "0x1807568C0")]
	public string GetBloodTypeString()
	{
		return null;
	}

	// Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000340")]
	[Address(RVA = "0x7569B0", Offset = "0x7559B0", VA = "0x1807569B0")]
	public void GenerateSlang()
	{
	}

	// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000341")]
	[Address(RVA = "0x757070", Offset = "0x756070", VA = "0x180757070")]
	public void SetPhysicalModelParams()
	{
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000342")]
	[Address(RVA = "0x7571F0", Offset = "0x7561F0", VA = "0x1807571F0", Slot = "5")]
	public override void CreateEvidence()
	{
	}

	// Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000343")]
	[Address(RVA = "0x7573A0", Offset = "0x7563A0", VA = "0x1807573A0")]
	public void CreateDetails()
	{
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000344")]
	[Address(RVA = "0x758CB0", Offset = "0x757CB0", VA = "0x180758CB0")]
	public void CalculateAge()
	{
	}

	// Token: 0x06000345 RID: 837 RVA: 0x000030C0 File Offset: 0x000012C0
	[Token(Token = "0x6000345")]
	[Address(RVA = "0x759A80", Offset = "0x758A80", VA = "0x180759A80")]
	public int GetAge()
	{
		return 0;
	}

	// Token: 0x06000346 RID: 838 RVA: 0x000030D8 File Offset: 0x000012D8
	[Token(Token = "0x6000346")]
	[Address(RVA = "0x759F60", Offset = "0x758F60", VA = "0x180759F60")]
	public Descriptors.Age GetAgeGroup()
	{
		return Descriptors.Age.youngAdult;
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000347")]
	[Address(RVA = "0x759F90", Offset = "0x758F90", VA = "0x180759F90")]
	public void PickPassword()
	{
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000348")]
	[Address(RVA = "0x75C4D0", Offset = "0x75B4D0", VA = "0x18075C4D0", Slot = "60")]
	public virtual void PrepForStart()
	{
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000349")]
	[Address(RVA = "0x75E480", Offset = "0x75D480", VA = "0x18075E480")]
	public void GenerateVocab()
	{
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600034A")]
	[Address(RVA = "0x75E850", Offset = "0x75D850", VA = "0x18075E850", Slot = "61")]
	public virtual void AddDDSVocab(DDSSaveClasses.DDSTreeSave newTree)
	{
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600034B")]
	[Address(RVA = "0x75E9F0", Offset = "0x75D9F0", VA = "0x18075E9F0")]
	public void GeneratePastVmails()
	{
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600034C")]
	[Address(RVA = "0x75F1D0", Offset = "0x75E1D0", VA = "0x18075F1D0")]
	public void GenerateDDSInteractionDialog()
	{
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600034D")]
	[Address(RVA = "0x75F4E0", Offset = "0x75E4E0", VA = "0x18075F4E0")]
	public void TestInteractionInstances([Optional] EvidenceWitness.DialogOption justSpokeDialogOption)
	{
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600034E")]
	[Address(RVA = "0x7609E0", Offset = "0x75F9E0", VA = "0x1807609E0")]
	private Human.InteractionDialogInstance.Branch StartSecondaryBranch(Human.InteractionDialogInstance inst, DDSSaveClasses.DDSMessageLink link)
	{
		return null;
	}

	// Token: 0x0600034F RID: 847 RVA: 0x000030F0 File Offset: 0x000012F0
	[Token(Token = "0x600034F")]
	[Address(RVA = "0x760B50", Offset = "0x75FB50", VA = "0x180760B50")]
	private Human.InteractionDialogInstance.EventsTestResult ExecuteAndTestCurrentInteractionEvent(Human.InteractionDialogInstance.Branch branch, out bool usedJustSpoken, [Optional] EvidenceWitness.DialogOption justSpokeDialogOption)
	{
		return Human.InteractionDialogInstance.EventsTestResult.fail;
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000350")]
	[Address(RVA = "0x765260", Offset = "0x764260", VA = "0x180765260")]
	public void SetupInteractables()
	{
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000351")]
	[Address(RVA = "0x765F10", Offset = "0x764F10", VA = "0x180765F10")]
	public void Load(CitySaveData.HumanCitySave data)
	{
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000352")]
	[Address(RVA = "0x767AF0", Offset = "0x766AF0", VA = "0x180767AF0")]
	public void LoadAcquaintances(CitySaveData.HumanCitySave data)
	{
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000353")]
	[Address(RVA = "0x767C70", Offset = "0x766C70", VA = "0x180767C70")]
	public void LoadFavourites(CitySaveData.HumanCitySave data)
	{
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000354")]
	[Address(RVA = "0x768110", Offset = "0x767110", VA = "0x180768110")]
	public void GenerateRoutineGoals()
	{
	}

	// Token: 0x06000355 RID: 853 RVA: 0x00003108 File Offset: 0x00001308
	[Token(Token = "0x6000355")]
	[Address(RVA = "0x768AE0", Offset = "0x767AE0", VA = "0x180768AE0")]
	public bool TraitGoalTest(AIGoalPreset goalPreset, out float priorityMultiplier)
	{
		return default(bool);
	}

	// Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000356")]
	[Address(RVA = "0x769490", Offset = "0x768490", VA = "0x180769490", Slot = "20")]
	public override void SetVisible(bool vis, bool force = false)
	{
	}

	// Token: 0x06000357 RID: 855 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000357")]
	[Address(RVA = "0x769A10", Offset = "0x768A10", VA = "0x180769A10", Slot = "12")]
	public override void OnGameLocationChange(bool enableSocialSightings = true, bool forceDisableLocationMemory = false)
	{
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000358")]
	[Address(RVA = "0x76A3B0", Offset = "0x7693B0", VA = "0x18076A3B0", Slot = "14")]
	public override void OnRoomChange()
	{
	}

	// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000359")]
	[Address(RVA = "0x76A750", Offset = "0x769750", VA = "0x18076A750", Slot = "13")]
	public override void OnNodeChange()
	{
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00003120 File Offset: 0x00001320
	[Token(Token = "0x600035A")]
	[Address(RVA = "0x76B210", Offset = "0x76A210", VA = "0x18076B210", Slot = "55")]
	public override bool IsTrespassing(NewRoom room, out int trespassEscalation, bool enforcersAllowedEverywhere = true)
	{
		return default(bool);
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035B")]
	[Address(RVA = "0x76C4E0", Offset = "0x76B4E0", VA = "0x18076C4E0")]
	public void CreateAcquaintances()
	{
	}

	// Token: 0x0600035C RID: 860 RVA: 0x00003138 File Offset: 0x00001338
	[Token(Token = "0x600035C")]
	[Address(RVA = "0x76EBA0", Offset = "0x76DBA0", VA = "0x18076EBA0")]
	public bool FindAcquaintanceExists(Human findC, out Acquaintance returnAcq)
	{
		return default(bool);
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035D")]
	[Address(RVA = "0x76EF90", Offset = "0x76DF90", VA = "0x18076EF90")]
	public void AddAcquaintance(Human addC, float known, Acquaintance.ConnectionType newConnection, bool addInverse = true, bool secretConnection = false, Acquaintance.ConnectionType newSecretConnection = Acquaintance.ConnectionType.friend, [Optional] GroupsController.SocialGroup group)
	{
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035E")]
	[Address(RVA = "0x76F380", Offset = "0x76E380", VA = "0x18076F380")]
	public void AddDetailToDict(string key, Fact det)
	{
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035F")]
	[Address(RVA = "0x76F660", Offset = "0x76E660", VA = "0x18076F660")]
	public void Murder(Human killer, bool setTimeOfDeath, MurderController.Murder murder, Interactable weapon, float chanceToScream = 1f)
	{
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000360")]
	[Address(RVA = "0x770830", Offset = "0x76F830", VA = "0x180770830")]
	public void RemoveFromWorld(bool val)
	{
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000361")]
	[Address(RVA = "0x771410", Offset = "0x770410", VA = "0x180771410", Slot = "21")]
	public override void GoToSleep()
	{
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000362")]
	[Address(RVA = "0x7716B0", Offset = "0x7706B0", VA = "0x1807716B0", Slot = "22")]
	public override void WakeUp(bool forceImmediate = false)
	{
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000363")]
	[Address(RVA = "0x771F30", Offset = "0x770F30", VA = "0x180771F30", Slot = "62")]
	public virtual void AddNourishment(float addVal)
	{
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000364")]
	[Address(RVA = "0x771F60", Offset = "0x770F60", VA = "0x180771F60", Slot = "63")]
	public virtual void AddHydration(float addVal)
	{
	}

	// Token: 0x06000365 RID: 869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000365")]
	[Address(RVA = "0x771F90", Offset = "0x770F90", VA = "0x180771F90", Slot = "64")]
	public virtual void AddAlertness(float addVal)
	{
	}

	// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000366")]
	[Address(RVA = "0x771FC0", Offset = "0x770FC0", VA = "0x180771FC0", Slot = "65")]
	public virtual void AddEnergy(float addVal)
	{
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000367")]
	[Address(RVA = "0x771FF0", Offset = "0x770FF0", VA = "0x180771FF0", Slot = "66")]
	public virtual void AddExcitement(float addVal)
	{
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000368")]
	[Address(RVA = "0x772020", Offset = "0x771020", VA = "0x180772020", Slot = "67")]
	public virtual void AddChores(float addVal)
	{
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000369")]
	[Address(RVA = "0x772050", Offset = "0x771050", VA = "0x180772050", Slot = "68")]
	public virtual void AddHygiene(float addVal)
	{
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036A")]
	[Address(RVA = "0x772080", Offset = "0x771080", VA = "0x180772080")]
	public void AddBladder(float addVal)
	{
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036B")]
	[Address(RVA = "0x7720B0", Offset = "0x7710B0", VA = "0x1807720B0")]
	public void AddBreath(float addVal)
	{
	}

	// Token: 0x0600036C RID: 876 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036C")]
	[Address(RVA = "0x772260", Offset = "0x771260", VA = "0x180772260", Slot = "69")]
	public virtual void AddHeat(float addVal)
	{
	}

	// Token: 0x0600036D RID: 877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036D")]
	[Address(RVA = "0x772290", Offset = "0x771290", VA = "0x180772290", Slot = "70")]
	public virtual void AddDrunk(float addVal)
	{
	}

	// Token: 0x0600036E RID: 878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036E")]
	[Address(RVA = "0x7722C0", Offset = "0x7712C0", VA = "0x1807722C0", Slot = "71")]
	public virtual void AddSick(float addVal)
	{
	}

	// Token: 0x0600036F RID: 879 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600036F")]
	[Address(RVA = "0x7722F0", Offset = "0x7712F0", VA = "0x1807722F0", Slot = "72")]
	public virtual void AddHeadache(float addVal)
	{
	}

	// Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000370")]
	[Address(RVA = "0x772320", Offset = "0x771320", VA = "0x180772320", Slot = "73")]
	public virtual void AddWet(float addVal)
	{
	}

	// Token: 0x06000371 RID: 881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000371")]
	[Address(RVA = "0x772350", Offset = "0x771350", VA = "0x180772350", Slot = "74")]
	public virtual void AddBrokenLeg(float addVal)
	{
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000372")]
	[Address(RVA = "0x772380", Offset = "0x771380", VA = "0x180772380", Slot = "75")]
	public virtual void AddBruised(float addVal)
	{
	}

	// Token: 0x06000373 RID: 883 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000373")]
	[Address(RVA = "0x7723B0", Offset = "0x7713B0", VA = "0x1807723B0", Slot = "76")]
	public virtual void AddBlackEye(float addVal)
	{
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000374")]
	[Address(RVA = "0x7723E0", Offset = "0x7713E0", VA = "0x1807723E0", Slot = "77")]
	public virtual void AddBlackedOut(float addVal)
	{
	}

	// Token: 0x06000375 RID: 885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000375")]
	[Address(RVA = "0x772410", Offset = "0x771410", VA = "0x180772410", Slot = "78")]
	public virtual void AddNumb(float addVal)
	{
	}

	// Token: 0x06000376 RID: 886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000376")]
	[Address(RVA = "0x772440", Offset = "0x771440", VA = "0x180772440", Slot = "79")]
	public virtual void AddPoisoned(float addVal, Human byWho)
	{
	}

	// Token: 0x06000377 RID: 887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000377")]
	[Address(RVA = "0x772670", Offset = "0x771670", VA = "0x180772670", Slot = "80")]
	public virtual void AddBleeding(float addVal)
	{
	}

	// Token: 0x06000378 RID: 888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000378")]
	[Address(RVA = "0x7726A0", Offset = "0x7716A0", VA = "0x1807726A0", Slot = "81")]
	public virtual void AddBlinded(float addVal)
	{
	}

	// Token: 0x06000379 RID: 889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000379")]
	[Address(RVA = "0x7726D0", Offset = "0x7716D0", VA = "0x1807726D0", Slot = "82")]
	public virtual void AddStarchAddiction(float addVal)
	{
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600037A")]
	[Address(RVA = "0x772700", Offset = "0x771700", VA = "0x180772700", Slot = "83")]
	public virtual void AddWellRested(float addVal)
	{
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600037B")]
	[Address(RVA = "0x772730", Offset = "0x771730", VA = "0x180772730", Slot = "84")]
	public virtual void AddSyncDiskInstall(float addVal)
	{
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600037C")]
	[Address(RVA = "0x772760", Offset = "0x771760", VA = "0x180772760")]
	public void SetAsDirector(Company newComp)
	{
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600037D")]
	[Address(RVA = "0x772940", Offset = "0x771940", VA = "0x180772940", Slot = "85")]
	public virtual void SetFootwear(Human.ShoeType newType)
	{
	}

	// Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600037E")]
	[Address(RVA = "0x772BF0", Offset = "0x771BF0", VA = "0x180772BF0")]
	public void OnFootstep(bool isRight)
	{
	}

	// Token: 0x0600037F RID: 895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600037F")]
	[Address(RVA = "0x773910", Offset = "0x772910", VA = "0x180773910")]
	public void AddPersonalAffect(InteractablePreset interactable, bool isWork = false)
	{
	}

	// Token: 0x06000380 RID: 896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000380")]
	[Address(RVA = "0x773F20", Offset = "0x772F20", VA = "0x180773F20")]
	public void RemovePersonalAffect(InteractablePreset interactable, bool isWork = false)
	{
	}

	// Token: 0x06000381 RID: 897 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000381")]
	[Address(RVA = "0x774070", Offset = "0x773070", VA = "0x180774070")]
	public NewNode FindSafeTeleport(NewGameLocation gameLoc, bool prioritiseWindows = false, bool allowTrespass = true)
	{
		return null;
	}

	// Token: 0x06000382 RID: 898 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000382")]
	[Address(RVA = "0x774950", Offset = "0x773950", VA = "0x180774950")]
	public NewNode FindSafeTeleport(NewRoom room, bool prioritiseWindows = false)
	{
		return null;
	}

	// Token: 0x06000383 RID: 899 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000383")]
	[Address(RVA = "0x774980", Offset = "0x773980", VA = "0x180774980")]
	public NewNode FindSafeTeleport(NewRoom room, out float bestScore, bool prioritiseWindows = false)
	{
		return null;
	}

	// Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000384")]
	[Address(RVA = "0x775A10", Offset = "0x774A10", VA = "0x180775A10")]
	public void GenerateItemFavs()
	{
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000385")]
	[Address(RVA = "0x7773A0", Offset = "0x7763A0", VA = "0x1807773A0")]
	public void SpawnInventoryItems()
	{
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00003150 File Offset: 0x00001350
	[Token(Token = "0x6000386")]
	[Address(RVA = "0x778620", Offset = "0x777620", VA = "0x180778620")]
	public bool WeaponTraitTest(Citizen cit, ref List<MurderPreset.MurdererModifierRule> rules, out float output)
	{
		return default(bool);
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000387")]
	[Address(RVA = "0x779010", Offset = "0x778010", VA = "0x180779010")]
	public void PlaceFavouriteItems()
	{
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00003168 File Offset: 0x00001368
	[Token(Token = "0x6000388")]
	[Address(RVA = "0x7790F0", Offset = "0x7780F0", VA = "0x1807790F0")]
	public float GetSimulatedTimeRange(NewGameLocation where, float maxTimeAgo)
	{
		return 0f;
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000389")]
	[Address(RVA = "0x7794C0", Offset = "0x7784C0", VA = "0x1807794C0")]
	public Interactable WriteNote(Human.NoteObject newPresetType, string treeID, Human reciever, NewGameLocation placement, int security = 0, InteractablePreset.OwnedPlacementRule ownershipPlacement = InteractablePreset.OwnedPlacementRule.both, int priority = 1, [Optional] HashSet<NewRoom> dontPlaceInRooms, bool printDebug = false, int toneFriendly = 0, int toneFormal = 0, [Optional] string loadGUID)
	{
		return null;
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600038A")]
	[Address(RVA = "0x7795E0", Offset = "0x7785E0", VA = "0x1807795E0")]
	public Interactable WriteNote(List<Human.NoteObject> newPresetType, string treeID, Human reciever, NewGameLocation placement, int security = 0, InteractablePreset.OwnedPlacementRule ownershipPlacement = InteractablePreset.OwnedPlacementRule.both, int priority = 1, [Optional] HashSet<NewRoom> dontPlaceInRooms, bool printDebug = false, int toneFriendly = 0, int toneFormal = 0, [Optional] string loadGUID)
	{
		return null;
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600038B")]
	[Address(RVA = "0x779890", Offset = "0x778890", VA = "0x180779890")]
	public CitySaveData.HumanCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00003180 File Offset: 0x00001380
	[Token(Token = "0x600038C")]
	[Address(RVA = "0x77ABD0", Offset = "0x779BD0", VA = "0x18077ABD0", Slot = "57")]
	public int CompareTo(Human comp)
	{
		return 0;
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600038D")]
	[Address(RVA = "0x77ACC0", Offset = "0x779CC0", VA = "0x18077ACC0")]
	public void SpeechTriggerPoint(DDSSaveClasses.TriggerPoint triggerPoint, Actor trackedTarget, [Optional] AIActionPreset onAction)
	{
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00003198 File Offset: 0x00001398
	[Token(Token = "0x600038E")]
	[Address(RVA = "0x77C090", Offset = "0x77B090", VA = "0x18077C090")]
	public bool DDSParticipantConditionCheck(Human initiator, DDSSaveClasses.DDSParticipant conditions, DDSSaveClasses.TreeType treeType)
	{
		return default(bool);
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600038F")]
	[Address(RVA = "0x77E0E0", Offset = "0x77D0E0", VA = "0x18077E0E0")]
	public void ExecuteConversationTree(DDSSaveClasses.DDSTreeSave newTree, List<Human> otherParticipants)
	{
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000390")]
	[Address(RVA = "0x77EDE0", Offset = "0x77DDE0", VA = "0x18077EDE0", Slot = "86")]
	public virtual void SetInConversation(Human.ConversationInstance newInstance, bool endCall = true)
	{
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000391")]
	[Address(RVA = "0x77F400", Offset = "0x77E400", VA = "0x18077F400")]
	public List<string> ParseDDSMessage(DDSSaveClasses.DDSMessageSettings settings, Acquaintance aq, [Optional] object passedObject)
	{
		return null;
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000392")]
	[Address(RVA = "0x77F440", Offset = "0x77E440", VA = "0x18077F440")]
	public List<string> ParseDDSMessage(string msgID, Acquaintance aq, out List<int> outputDisplayGroups, bool forceRealRandom = false, [Optional] object passedObject, bool debug = false)
	{
		return null;
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000393")]
	[Address(RVA = "0x781CC0", Offset = "0x780CC0", VA = "0x180781CC0", Slot = "87")]
	public virtual void SetDesiredSpeed(float newSpeedRatio)
	{
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000394")]
	[Address(RVA = "0x781FF0", Offset = "0x780FF0", VA = "0x180781FF0", Slot = "88")]
	public virtual void SetDesiredSpeed(Human.MovementSpeed newMovement)
	{
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000395")]
	[Address(RVA = "0x782270", Offset = "0x781270", VA = "0x180782270", Slot = "89")]
	public virtual void UpdateMovementSpeed()
	{
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000396")]
	[Address(RVA = "0x7822E0", Offset = "0x7812E0", VA = "0x1807822E0", Slot = "90")]
	public virtual void SetBed(Interactable passSpecificInteractable)
	{
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000397")]
	[Address(RVA = "0x782340", Offset = "0x781340", VA = "0x180782340", Slot = "91")]
	public virtual void SetWorkFurniture(Interactable passSpecificInteractable)
	{
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000398")]
	[Address(RVA = "0x7823A0", Offset = "0x7813A0", VA = "0x1807823A0", Slot = "92")]
	public virtual void UpdateConversation()
	{
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000399")]
	[Address(RVA = "0x782DB0", Offset = "0x781DB0", VA = "0x180782DB0")]
	public List<Human.DDSRank> GetConversationTreeLinkRankings(DDSSaveClasses.DDSMessageSettings thisMsg, ref List<DDSSaveClasses.DDSMessageLink> links)
	{
		return null;
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039A")]
	[Address(RVA = "0x783440", Offset = "0x782440", VA = "0x180783440")]
	public void AddCurrentConsumable(InteractablePreset newPreset)
	{
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039B")]
	[Address(RVA = "0x7835A0", Offset = "0x7825A0", VA = "0x1807835A0")]
	public void RemoveCurrentConsumable(InteractablePreset newPreset)
	{
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600039C")]
	[Address(RVA = "0x783890", Offset = "0x782890", VA = "0x180783890")]
	public void AddTrash(InteractablePreset trashItem, Human writer, [Optional] List<Interactable.Passed> passedVars)
	{
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600039D")]
	[Address(RVA = "0x783AB0", Offset = "0x782AB0", VA = "0x180783AB0")]
	public InteractablePreset PickConsumable(ref Dictionary<InteractablePreset, int> prices, out int price, [Optional] List<InteractablePreset> ignore)
	{
		return null;
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600039E")]
	[Address(RVA = "0x784210", Offset = "0x783210", VA = "0x180784210")]
	public Human GetDoctor()
	{
		return null;
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600039F")]
	[Address(RVA = "0x784550", Offset = "0x783550", VA = "0x180784550")]
	public Human GetLandlord()
	{
		return null;
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x784A60", Offset = "0x783A60", VA = "0x180784A60", Slot = "93")]
	public virtual void AddMeshes(List<MeshRenderer> renderers, bool addToOutline = true, bool forceMeshListUpdate = false)
	{
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x784C40", Offset = "0x783C40", VA = "0x180784C40", Slot = "94")]
	public virtual void AddMesh(GameObject newObject, bool addToOutline = true, bool forceMeshListUpdate = false)
	{
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x7851A0", Offset = "0x7841A0", VA = "0x1807851A0", Slot = "95")]
	public virtual void AddMesh(MeshRenderer newMesh, bool addToOutline = true, bool forceMeshListUpdate = false, bool addToLOD1 = false, bool addToBoth = false)
	{
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x7855D0", Offset = "0x7845D0", VA = "0x1807855D0", Slot = "96")]
	public virtual void RemoveMesh(MeshRenderer newMesh, bool removeFromOutline = true, bool forceMeshListUpdate = false)
	{
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x7858A0", Offset = "0x7848A0", VA = "0x1807858A0", Slot = "97")]
	public virtual void UpdateMeshList()
	{
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x785FB0", Offset = "0x784FB0", VA = "0x180785FB0", Slot = "30")]
	public override void AddNerve(float amount, [Optional] Actor scaredBy)
	{
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x786150", Offset = "0x785150", VA = "0x180786150")]
	public void UpdateLODs()
	{
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x000031B0 File Offset: 0x000013B0
	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x7868F0", Offset = "0x7858F0", VA = "0x1807868F0")]
	public int GetHexacoScore(ref HEXACO hex)
	{
		return 0;
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x786BA0", Offset = "0x785BA0", VA = "0x180786BA0")]
	public void WalletItemCheck(int maxNewItems, bool dailyReplenish)
	{
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x787710", Offset = "0x786710", VA = "0x180787710")]
	public void UpdateLastSighting(Human citizen, bool phoneCall = false, int isSound = 0)
	{
	}

	// Token: 0x060003AA RID: 938 RVA: 0x000031C8 File Offset: 0x000013C8
	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x788910", Offset = "0x787910", VA = "0x180788910")]
	public Vector2 GetSightingDirection(Human.Sighting sighting, out NewGameLocation newDestination)
	{
		return default(Vector2);
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x788E90", Offset = "0x787E90", VA = "0x180788E90")]
	public void RevealSighting(Human prospectCitizen, bool allowCalls, bool allowSounds, SpeechController sc, bool allowGeneralClue = true)
	{
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x789560", Offset = "0x788560", VA = "0x180789560")]
	public void RevealSighting(Human prospectCitizen, Human.Sighting sighting, SpeechController sc)
	{
	}

	// Token: 0x060003AD RID: 941 RVA: 0x000031E0 File Offset: 0x000013E0
	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x789D50", Offset = "0x788D50", VA = "0x180789D50")]
	public Vector3 GetNearestVert(Vector3 worldPosition, out CitizenOutfitController.CharacterAnchor nearestBodyPart)
	{
		return default(Vector3);
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x78A870", Offset = "0x789870", VA = "0x18078A870")]
	public string GetCitizenName()
	{
		return null;
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x78AB40", Offset = "0x789B40", VA = "0x18078AB40")]
	public string GetFirstName()
	{
		return null;
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x78AED0", Offset = "0x789ED0", VA = "0x18078AED0")]
	public string GetCasualName()
	{
		return null;
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x78B080", Offset = "0x78A080", VA = "0x18078B080")]
	public string GetSurName()
	{
		return null;
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x78B3C0", Offset = "0x78A3C0", VA = "0x18078B3C0")]
	public string GetInitialledName()
	{
		return null;
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x78B460", Offset = "0x78A460", VA = "0x18078B460")]
	public string GetInitials()
	{
		return null;
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x78B530", Offset = "0x78A530", VA = "0x18078B530")]
	public string GetFirstInitial()
	{
		return null;
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x78B5B0", Offset = "0x78A5B0", VA = "0x18078B5B0")]
	public void DebugGetAge()
	{
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x000031F8 File Offset: 0x000013F8
	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x78B6E0", Offset = "0x78A6E0", VA = "0x18078B6E0")]
	public bool TryGiveItem(Interactable givenItem, Human givenBy, bool defaultSuccess, bool enableSpeech = true)
	{
		return default(bool);
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00003210 File Offset: 0x00001410
	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x78C8A0", Offset = "0x78B8A0", VA = "0x18078C8A0")]
	public int GetReceiptDifficulty()
	{
		return 0;
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x78C970", Offset = "0x78B970", VA = "0x18078C970")]
	public string GetReceiptDifficultyBaseNameInfo(bool includeLink, out Strings.LinkData nameLink)
	{
		return null;
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x78D2F0", Offset = "0x78C2F0", VA = "0x18078D2F0", Slot = "98")]
	public virtual void SetVehicle(Transform newVehicle)
	{
	}

	// Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x78DAE0", Offset = "0x78CAE0", VA = "0x18078DAE0")]
	public void RemoveFromGameWorld()
	{
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x78DB00", Offset = "0x78CB00", VA = "0x18078DB00")]
	public void TeleportChosenInteractionWorldItemsToPlayer()
	{
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x78DCB0", Offset = "0x78CCB0", VA = "0x18078DCB0")]
	public Human()
	{
	}

	// Token: 0x060003BE RID: 958 RVA: 0x00003228 File Offset: 0x00001428
	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x78F140", Offset = "0x78E140", VA = "0x18078F140")]
	private bool <GenerateRoutineGoals>b__197_0(AIGoalPreset item)
	{
		return default(bool);
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00003240 File Offset: 0x00001440
	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x78F220", Offset = "0x78E220", VA = "0x18078F220")]
	private bool <SpeechTriggerPoint>b__254_0(Telephone item)
	{
		return default(bool);
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00003258 File Offset: 0x00001458
	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x78F3D0", Offset = "0x78E3D0", VA = "0x18078F3D0")]
	private bool <DDSParticipantConditionCheck>b__255_0(Telephone item)
	{
		return default(bool);
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00003270 File Offset: 0x00001470
	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x78F580", Offset = "0x78E580", VA = "0x18078F580")]
	private bool <SetInConversation>b__257_0(Telephone item)
	{
		return default(bool);
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00003288 File Offset: 0x00001488
	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x78F730", Offset = "0x78E730", VA = "0x18078F730")]
	private bool <GetDoctor>b__271_0(Occupation item)
	{
		return default(bool);
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x000032A0 File Offset: 0x000014A0
	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x78FAE0", Offset = "0x78EAE0", VA = "0x18078FAE0")]
	private bool <RevealSighting>b__284_0(MurderController.Murder item)
	{
		return default(bool);
	}

	// Token: 0x0400028F RID: 655
	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	public int humanID;

	// Token: 0x04000290 RID: 656
	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[NonSerialized]
	public static int assignID;

	// Token: 0x04000291 RID: 657
	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	[NonSerialized]
	public static int assignTraitID;

	// Token: 0x04000292 RID: 658
	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	[NonSerialized]
	public string seed;

	// Token: 0x04000293 RID: 659
	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public Human.ShoeType footwear;

	// Token: 0x04000294 RID: 660
	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	[NonSerialized]
	public AudioEvent footstepEvent;

	// Token: 0x04000295 RID: 661
	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	public float footstepDirt;

	// Token: 0x04000296 RID: 662
	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
	public float footstepBlood;

	// Token: 0x04000297 RID: 663
	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	public Transform leftFoot;

	// Token: 0x04000298 RID: 664
	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	public Transform rightFoot;

	// Token: 0x04000299 RID: 665
	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	public bool removedFromWorld;

	// Token: 0x0400029A RID: 666
	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	public NewAddress home;

	// Token: 0x0400029B RID: 667
	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	[NonSerialized]
	public ResidenceController residence;

	// Token: 0x0400029C RID: 668
	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	public NewAddress den;

	// Token: 0x0400029D RID: 669
	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	public bool scaredOfRats;

	// Token: 0x0400029E RID: 670
	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B1")]
	public bool likesRats;

	// Token: 0x0400029F RID: 671
	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B2")]
	public bool dislikesRats;

	// Token: 0x040002A0 RID: 672
	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B3")]
	public bool hatesRats;

	// Token: 0x040002A1 RID: 673
	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
	public float speedMultiplier;

	// Token: 0x040002A2 RID: 674
	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	public float movementWalkSpeed;

	// Token: 0x040002A3 RID: 675
	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
	public float movementRunSpeed;

	// Token: 0x040002A4 RID: 676
	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	[NonSerialized]
	public float walkingSpeedRatio;

	// Token: 0x040002A5 RID: 677
	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C4")]
	public float currentNormalizedSpeed;

	// Token: 0x040002A6 RID: 678
	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	public float desiredNormalizedSpeed;

	// Token: 0x040002A7 RID: 679
	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2CC")]
	public float currentMovementSpeed;

	// Token: 0x040002A8 RID: 680
	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	public float breathRecoveryRate;

	// Token: 0x040002A9 RID: 681
	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
	public Transform currentVehicle;

	// Token: 0x040002AA RID: 682
	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
	public Occupation job;

	// Token: 0x040002AB RID: 683
	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
	public Company director;

	// Token: 0x040002AC RID: 684
	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
	public float societalClass;

	// Token: 0x040002AD RID: 685
	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
	public Descriptors descriptors;

	// Token: 0x040002AE RID: 686
	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
	public CitizenOutfitController outfitController;

	// Token: 0x040002AF RID: 687
	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
	public HandwritingPreset handwriting;

	// Token: 0x040002B0 RID: 688
	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
	public string birthday;

	// Token: 0x040002B1 RID: 689
	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
	public string citizenName;

	// Token: 0x040002B2 RID: 690
	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
	[NonSerialized]
	public string firstName;

	// Token: 0x040002B3 RID: 691
	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
	[NonSerialized]
	public string casualName;

	// Token: 0x040002B4 RID: 692
	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
	[NonSerialized]
	public string surName;

	// Token: 0x040002B5 RID: 693
	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
	[NonSerialized]
	public float genderScale;

	// Token: 0x040002B6 RID: 694
	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
	public Human.Gender gender;

	// Token: 0x040002B7 RID: 695
	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
	public Human.Gender birthGender;

	// Token: 0x040002B8 RID: 696
	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
	public float slangUsage;

	// Token: 0x040002B9 RID: 697
	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
	public float sexuality;

	// Token: 0x040002BA RID: 698
	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34C")]
	public float homosexuality;

	// Token: 0x040002BB RID: 699
	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
	[NonSerialized]
	public List<Human.Gender> attractedTo;

	// Token: 0x040002BC RID: 700
	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
	public Citizen partner;

	// Token: 0x040002BD RID: 701
	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
	public string anniversary;

	// Token: 0x040002BE RID: 702
	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
	public Citizen paramour;

	// Token: 0x040002BF RID: 703
	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
	[NonSerialized]
	public int fingerprintLoop;

	// Token: 0x040002C0 RID: 704
	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x374")]
	public Human.BloodType bloodType;

	// Token: 0x040002C1 RID: 705
	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
	[NonSerialized]
	public int favColourIndex;

	// Token: 0x040002C2 RID: 706
	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37C")]
	public float humility;

	// Token: 0x040002C3 RID: 707
	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
	public float emotionality;

	// Token: 0x040002C4 RID: 708
	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x384")]
	public float extraversion;

	// Token: 0x040002C5 RID: 709
	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
	public float agreeableness;

	// Token: 0x040002C6 RID: 710
	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38C")]
	public float conscientiousness;

	// Token: 0x040002C7 RID: 711
	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
	public float creativity;

	// Token: 0x040002C8 RID: 712
	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x394")]
	[NonSerialized]
	public float sleepNeedMultiplier;

	// Token: 0x040002C9 RID: 713
	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
	[NonSerialized]
	public float snoring;

	// Token: 0x040002CA RID: 714
	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39C")]
	[NonSerialized]
	public float snoreDelay;

	// Token: 0x040002CB RID: 715
	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
	[NonSerialized]
	public Vector2 limitHumility;

	// Token: 0x040002CC RID: 716
	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
	[NonSerialized]
	public Vector2 limitEmotionality;

	// Token: 0x040002CD RID: 717
	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
	[NonSerialized]
	public Vector2 limitExtraversion;

	// Token: 0x040002CE RID: 718
	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
	[NonSerialized]
	public Vector2 limitAgreeableness;

	// Token: 0x040002CF RID: 719
	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
	[NonSerialized]
	public Vector2 limitConscientiousness;

	// Token: 0x040002D0 RID: 720
	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
	[NonSerialized]
	public Vector2 limitCreativity;

	// Token: 0x040002D1 RID: 721
	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
	public List<Human.Trait> characterTraits;

	// Token: 0x040002D2 RID: 722
	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
	public List<Human.WeightedTrait> aggressiveTraits;

	// Token: 0x040002D3 RID: 723
	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
	public List<Human.WeightedTrait> peacefulTraits;

	// Token: 0x040002D4 RID: 724
	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
	public List<Human.WeightedTrait> fearfulTraits;

	// Token: 0x040002D5 RID: 725
	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
	public List<GroupsController.SocialGroup> groups;

	// Token: 0x040002D6 RID: 726
	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
	public float nourishment;

	// Token: 0x040002D7 RID: 727
	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3FC")]
	public float hydration;

	// Token: 0x040002D8 RID: 728
	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
	public float alertness;

	// Token: 0x040002D9 RID: 729
	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x404")]
	public float energy;

	// Token: 0x040002DA RID: 730
	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
	public float excitement;

	// Token: 0x040002DB RID: 731
	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40C")]
	public float chores;

	// Token: 0x040002DC RID: 732
	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
	public float hygiene;

	// Token: 0x040002DD RID: 733
	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x414")]
	public float bladder;

	// Token: 0x040002DE RID: 734
	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
	public float breath;

	// Token: 0x040002DF RID: 735
	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41C")]
	public float heat;

	// Token: 0x040002E0 RID: 736
	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
	public float drunk;

	// Token: 0x040002E1 RID: 737
	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x424")]
	public float sick;

	// Token: 0x040002E2 RID: 738
	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
	public float headache;

	// Token: 0x040002E3 RID: 739
	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42C")]
	public float wet;

	// Token: 0x040002E4 RID: 740
	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
	public float brokenLeg;

	// Token: 0x040002E5 RID: 741
	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x434")]
	public float bruised;

	// Token: 0x040002E6 RID: 742
	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
	public float blackEye;

	// Token: 0x040002E7 RID: 743
	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x43C")]
	public float blackedOut;

	// Token: 0x040002E8 RID: 744
	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
	public float numb;

	// Token: 0x040002E9 RID: 745
	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x444")]
	public float poisoned;

	// Token: 0x040002EA RID: 746
	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
	public float bleeding;

	// Token: 0x040002EB RID: 747
	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44C")]
	public float wellRested;

	// Token: 0x040002EC RID: 748
	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
	public float starchAddiction;

	// Token: 0x040002ED RID: 749
	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x454")]
	public float syncDiskInstall;

	// Token: 0x040002EE RID: 750
	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
	public float blinded;

	// Token: 0x040002EF RID: 751
	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
	public Human poisoner;

	// Token: 0x040002F0 RID: 752
	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
	public GameObject CorpseCollisionCorrection;

	// Token: 0x040002F1 RID: 753
	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
	[NonSerialized]
	public List<Acquaintance> acquaintances;

	// Token: 0x040002F2 RID: 754
	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
	public Dictionary<DDSSaveClasses.TriggerPoint, List<DDSSaveClasses.DDSTreeSave>> dds;

	// Token: 0x040002F3 RID: 755
	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
	public List<Human.InteractionDialogInstance> interactionEvents;

	// Token: 0x040002F4 RID: 756
	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
	private bool interactionEventsTestingRecursionProtect;

	// Token: 0x040002F5 RID: 757
	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
	[NonSerialized]
	public Human.ConversationInstance currentConversation;

	// Token: 0x040002F6 RID: 758
	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
	public float nextCasualSpeechValidAt;

	// Token: 0x040002F7 RID: 759
	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
	public Dictionary<Human, Human.Sighting> lastSightings;

	// Token: 0x040002F8 RID: 760
	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
	public int sightingMemoryLimit;

	// Token: 0x040002F9 RID: 761
	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4AC")]
	private Human.MovementSpeed lastMovementSpeed;

	// Token: 0x040002FA RID: 762
	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
	private Dictionary<DDSSaveClasses.DDSTreeSave, List<Human.SpeechHistory>> speechHistory;

	// Token: 0x040002FB RID: 763
	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
	[NonSerialized]
	public List<StateSaveData.MessageThreadSave> messageThreadsStarted;

	// Token: 0x040002FC RID: 764
	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
	[NonSerialized]
	public List<StateSaveData.MessageThreadSave> messageThreadFeatures;

	// Token: 0x040002FD RID: 765
	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
	[NonSerialized]
	public List<StateSaveData.MessageThreadSave> messageThreadCCd;

	// Token: 0x040002FE RID: 766
	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
	[NonSerialized]
	public Evidence addressBook;

	// Token: 0x040002FF RID: 767
	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
	[NonSerialized]
	public bool setupAddressBook;

	// Token: 0x04000300 RID: 768
	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
	[NonSerialized]
	public Evidence workID;

	// Token: 0x04000301 RID: 769
	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
	[NonSerialized]
	public List<Interactable> birthdayCards;

	// Token: 0x04000302 RID: 770
	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
	public List<InteractablePreset> currentConsumables;

	// Token: 0x04000303 RID: 771
	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
	public List<int> trash;

	// Token: 0x04000304 RID: 772
	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
	public int anywhereTrash;

	// Token: 0x04000305 RID: 773
	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
	public Human.Death death;

	// Token: 0x04000306 RID: 774
	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x510")]
	public List<Human.Wound> currentWounds;

	// Token: 0x04000307 RID: 775
	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
	public List<Human.WalletItem> walletItems;

	// Token: 0x04000308 RID: 776
	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
	public Dictionary<string, Fact> factDictionary;

	// Token: 0x04000309 RID: 777
	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
	public List<InteractablePreset> personalAffects;

	// Token: 0x0400030A RID: 778
	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x530")]
	public List<InteractablePreset> workAffects;

	// Token: 0x0400030B RID: 779
	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
	[NonSerialized]
	public Interactable workPosition;

	// Token: 0x0400030C RID: 780
	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
	[NonSerialized]
	public Interactable sleepPosition;

	// Token: 0x0400030D RID: 781
	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
	private int preferredBookCount;

	// Token: 0x0400030E RID: 782
	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x550")]
	public List<BookPreset> library;

	// Token: 0x0400030F RID: 783
	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x558")]
	public List<BookPreset> nonShelfBooks;

	// Token: 0x04000310 RID: 784
	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x560")]
	[NonSerialized]
	public int booksAwayFromShelf;

	// Token: 0x04000311 RID: 785
	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x568")]
	public Dictionary<RetailItemPreset, int> itemRanking;

	// Token: 0x04000312 RID: 786
	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x570")]
	public Dictionary<CompanyPreset.CompanyCategory, NewAddress> favouritePlaces;

	// Token: 0x04000313 RID: 787
	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
	public Dictionary<RetailItemPreset, float> recentPurchases;

	// Token: 0x04000314 RID: 788
	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x580")]
	public GameplayController.Passcode passcode;

	// Token: 0x04000315 RID: 789
	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x588")]
	public CharacterTrait passwordTrait;

	// Token: 0x04000316 RID: 790
	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x590")]
	private List<float> simulatedPreviousBehaviour;

	// Token: 0x04000317 RID: 791
	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
	public Vector2 lastUsedCCTVScreenPoint;

	// Token: 0x04000318 RID: 792
	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A0")]
	public bool updateMeshList;

	// Token: 0x04000319 RID: 793
	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A8")]
	public Human.ConversationInstance debugConversation;

	// Token: 0x0400031A RID: 794
	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5B0")]
	public float debugLastChangedNodeAt;

	// Token: 0x0400031B RID: 795
	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5B4")]
	public float debugLastAITick;

	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public enum ShoeType
	{
		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		normal,
		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		boots,
		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		heel,
		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		barefoot
	}

	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public enum MovementSpeed
	{
		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		stopped,
		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		walking,
		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		running
	}

	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	public enum Gender
	{
		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		male,
		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		female,
		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		nonBinary
	}

	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	public enum BloodType
	{
		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		unassigned,
		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		Apos,
		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		Aneg,
		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		Bpos,
		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		Bneg,
		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		Opos,
		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		Oneg,
		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		ABpos,
		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		ABneg
	}

	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	[Serializable]
	public class Trait
	{
		// Token: 0x060003C4 RID: 964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public Trait()
		{
		}

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int traitID;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CharacterTrait trait;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Human.Trait reason;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string date;
	}

	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	[Serializable]
	public class WeightedTrait
	{
		// Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public WeightedTrait()
		{
		}

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait trait;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float traitValue;
	}

	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[Serializable]
	public class Sighting
	{
		// Token: 0x060003C6 RID: 966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public Sighting()
		{
		}

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float time;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 node;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mov;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 dest;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool run;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int exp;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool drunk;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool phone;

		// Token: 0x04000342 RID: 834
		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool poi;

		// Token: 0x04000343 RID: 835
		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int sound;
	}

	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[Serializable]
	public class ConversationInstance
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xDCB0B0", Offset = "0xDCA0B0", VA = "0x180DCB0B0")]
		public void EndConversation()
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xDCBA50", Offset = "0xDCAA50", VA = "0x180DCBA50")]
		public void SetCurrentMessage(string instanceID)
		{
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ConversationInstance()
		{
		}

		// Token: 0x04000344 RID: 836
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool active;

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewRoom room;

		// Token: 0x04000346 RID: 838
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public DDSSaveClasses.DDSTreeSave tree;

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Human participantA;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Human participantB;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Human participantC;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Human participantD;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Human previouslyTalking;

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Human currentlyTalking;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Human currentlyTalkingTo;

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool speechTriggered;

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public DDSSaveClasses.DDSMessageSettings currentMessage;

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public DDSSaveClasses.DDSMessageLink currentLink;

		// Token: 0x04000351 RID: 849
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float linkDelay;

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float timeUntilNextSpeech;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int currentlyTalkingSpeechQueue;

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string treeName;

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x060003CA RID: 970 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x060003CB RID: 971 RVA: 0x000032B8 File Offset: 0x000014B8
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x5976C0", Offset = "0x5966C0", VA = "0x1805976C0")]
			internal bool <SetCurrentMessage>b__0(DDSSaveClasses.DDSMessageSettings item)
			{
				return default(bool);
			}

			// Token: 0x04000355 RID: 853
			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string instanceID;
		}
	}

	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	[Serializable]
	public class InteractionDialogInstance
	{
		// Token: 0x060003CC RID: 972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xDCC170", Offset = "0xDCB170", VA = "0x180DCC170")]
		public InteractionDialogInstance(DDSSaveClasses.DDSTreeSave newTree)
		{
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xDCC5A0", Offset = "0xDCB5A0", VA = "0x180DCC5A0")]
		public void OnLoad(Human human)
		{
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xDCC8F0", Offset = "0xDCB8F0", VA = "0x180DCC8F0")]
		public DDSSaveClasses.DDSTreeSave GetTree()
		{
			return null;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xDCC9A0", Offset = "0xDCB9A0", VA = "0x180DCC9A0")]
		public Interactable GetItem()
		{
			return null;
		}

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string treeID;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string pickedItem;

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int pickedWorldItemID;

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Human.InteractionDialogInstance.Branch mainBranch;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Human.InteractionDialogInstance.Branch> secondaryBranches;

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<NewspaperController.InteractionDialogFeature> newspaperFeatures;

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public DDSSaveClasses.DDSTreeSave tree;

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public List<EvidenceWitness.DialogOption> generatedDialogOptions;

		// Token: 0x0200005E RID: 94
		[Token(Token = "0x200005E")]
		public enum EventsTestResult
		{
			// Token: 0x04000360 RID: 864
			[Token(Token = "0x4000360")]
			fail,
			// Token: 0x04000361 RID: 865
			[Token(Token = "0x4000361")]
			success,
			// Token: 0x04000362 RID: 866
			[Token(Token = "0x4000362")]
			wait
		}

		// Token: 0x0200005F RID: 95
		[Token(Token = "0x200005F")]
		[Serializable]
		public class Branch
		{
			// Token: 0x060003D0 RID: 976 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0xDCCA60", Offset = "0xDCBA60", VA = "0x180DCCA60")]
			public Branch(Human.InteractionDialogInstance dialogInstance)
			{
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0xDCCB80", Offset = "0xDCBB80", VA = "0x180DCCB80")]
			public DDSSaveClasses.DDSMessageSettings GetMessageInstance()
			{
				return null;
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0xDCCC10", Offset = "0xDCBC10", VA = "0x180DCCC10")]
			public DDSSaveClasses.DDSMessageSave GetMessage()
			{
				return null;
			}

			// Token: 0x060003D3 RID: 979 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0xDCCCD0", Offset = "0xDCBCD0", VA = "0x180DCCCD0")]
			public void NewInteractionInstanceMessage(string newMsgInstanceID, Human human)
			{
			}

			// Token: 0x04000363 RID: 867
			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string msgInstanceID;

			// Token: 0x04000364 RID: 868
			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<int> completedEventIndexes;

			// Token: 0x04000365 RID: 869
			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[NonSerialized]
			public Human.InteractionDialogInstance inst;

			// Token: 0x02000060 RID: 96
			[Token(Token = "0x2000060")]
			private sealed class <>c__DisplayClass6_0
			{
				// Token: 0x060003D4 RID: 980 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60003D4")]
				[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
				public <>c__DisplayClass6_0()
				{
				}

				// Token: 0x060003D5 RID: 981 RVA: 0x000032D0 File Offset: 0x000014D0
				[Token(Token = "0x60003D5")]
				[Address(RVA = "0xDCD7C0", Offset = "0xDCC7C0", VA = "0x180DCD7C0")]
				internal bool <NewInteractionInstanceMessage>b__1(SpeechController.QueueElement item)
				{
					return default(bool);
				}

				// Token: 0x04000366 RID: 870
				[Token(Token = "0x4000366")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public DDSSaveClasses.DDSMessageSave msg;
			}

			// Token: 0x02000061 RID: 97
			[Token(Token = "0x2000061")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x060003D7 RID: 983 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60003D7")]
				[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
				public <>c()
				{
				}

				// Token: 0x060003D8 RID: 984 RVA: 0x000032E8 File Offset: 0x000014E8
				[Token(Token = "0x60003D8")]
				[Address(RVA = "0x874F10", Offset = "0x873F10", VA = "0x180874F10")]
				internal bool <NewInteractionInstanceMessage>b__6_0(DDSSaveClasses.DDSInteractionEvent item)
				{
					return default(bool);
				}

				// Token: 0x04000367 RID: 871
				[Token(Token = "0x4000367")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly Human.InteractionDialogInstance.Branch.<>c <>9;

				// Token: 0x04000368 RID: 872
				[Token(Token = "0x4000368")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static Predicate<DDSSaveClasses.DDSInteractionEvent> <>9__6_0;
			}
		}
	}

	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	public class DDSRank
	{
		// Token: 0x060003D9 RID: 985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DDSRank()
		{
		}

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DDSSaveClasses.DDSMessageLink linkRef;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rankRef;
	}

	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public class SpeechHistory
	{
		// Token: 0x060003DA RID: 986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xDCD8E0", Offset = "0xDCC8E0", VA = "0x180DCD8E0")]
		public SpeechHistory()
		{
		}

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float timeStamp;

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Human> participants;
	}

	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public enum DisposalType
	{
		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		anywhere,
		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		homeOnly,
		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		workOnly,
		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		homeOrWork
	}

	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	[Serializable]
	public class Wound
	{
		// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xDCD9B0", Offset = "0xDCC9B0", VA = "0x180DCD9B0")]
		public void Load()
		{
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xDCDBF0", Offset = "0xDCCBF0", VA = "0x180DCDBF0")]
		public void ProcessBloodPoolForWound()
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x9C0730", Offset = "0x9BF730", VA = "0x1809C0730")]
		public Wound()
		{
		}

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int humanID;

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Interactable interactable;

		// Token: 0x04000375 RID: 885
		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CitizenOutfitController.CharacterAnchor anchor;

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float timestamp;

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int bloodPoolID;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float bloodPoolAmount;

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Human human;

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Interactable bloodPool;
	}

	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	[Serializable]
	public class Death
	{
		// Token: 0x060003DE RID: 990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xDCE270", Offset = "0xDCD270", VA = "0x180DCE270")]
		public Death(Human newVictim, MurderController.Murder newMurder, Human newKiller, Interactable newWeapon)
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xDCE7A0", Offset = "0xDCD7A0", VA = "0x180DCE7A0")]
		public void UpdateDeathLocation(NewNode newNode)
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xDCE7F0", Offset = "0xDCD7F0", VA = "0x180DCE7F0")]
		public void SetReported(Human newFoundBy, Human.Death.ReportType newReportType)
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xDCF070", Offset = "0xDCE070", VA = "0x180DCF070")]
		public Human GetVictim()
		{
			return null;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xDCF0F0", Offset = "0xDCE0F0", VA = "0x180DCF0F0")]
		public Human GetKiller()
		{
			return null;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xDCF170", Offset = "0xDCE170", VA = "0x180DCF170")]
		public Human GetDiscoverer()
		{
			return null;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xDCF1F0", Offset = "0xDCE1F0", VA = "0x180DCF1F0")]
		public EvidenceTime GetTimeOfDeathEvidence()
		{
			return null;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xDCF300", Offset = "0xDCE300", VA = "0x180DCF300")]
		public NewGameLocation GetDeathLocation()
		{
			return null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xDCF4B0", Offset = "0xDCE4B0", VA = "0x180DCF4B0")]
		public MurderController.Murder GetMurder()
		{
			return null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xDCF640", Offset = "0xDCE640", VA = "0x180DCF640")]
		private bool <GetMurder>b__22_0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xDCF640", Offset = "0xDCE640", VA = "0x180DCF640")]
		private bool <GetMurder>b__22_1(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isDead;

		// Token: 0x0400037C RID: 892
		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 location;

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float time;

		// Token: 0x0400037E RID: 894
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 timeOfDeathRange;

		// Token: 0x0400037F RID: 895
		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int weapon;

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int murder;

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int victim;

		// Token: 0x04000382 RID: 898
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int killer;

		// Token: 0x04000383 RID: 899
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int discoveredBy;

		// Token: 0x04000384 RID: 900
		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float discoveredAt;

		// Token: 0x04000385 RID: 901
		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool reported;

		// Token: 0x04000386 RID: 902
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Human.Death.ReportType reportType;

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float smell;

		// Token: 0x02000067 RID: 103
		[Token(Token = "0x2000067")]
		public enum ReportType
		{
			// Token: 0x04000389 RID: 905
			[Token(Token = "0x4000389")]
			visual,
			// Token: 0x0400038A RID: 906
			[Token(Token = "0x400038A")]
			smell,
			// Token: 0x0400038B RID: 907
			[Token(Token = "0x400038B")]
			audio
		}

		// Token: 0x02000068 RID: 104
		[Token(Token = "0x2000068")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060003EA RID: 1002 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c()
			{
			}

			// Token: 0x060003EB RID: 1003 RVA: 0x00003330 File Offset: 0x00001530
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0xDC7670", Offset = "0xDC6670", VA = "0x180DC7670")]
			internal bool <SetReported>b__16_0(NewAIGoal item)
			{
				return default(bool);
			}

			// Token: 0x0400038C RID: 908
			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Human.Death.<>c <>9;

			// Token: 0x0400038D RID: 909
			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<NewAIGoal> <>9__16_0;
		}
	}

	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[Serializable]
	public class WalletItem
	{
		// Token: 0x060003EC RID: 1004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x6DD8B0", Offset = "0x6DC8B0", VA = "0x1806DD8B0")]
		public WalletItem()
		{
		}

		// Token: 0x0400038E RID: 910
		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human.WalletItemType itemType;

		// Token: 0x0400038F RID: 911
		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int meta;

		// Token: 0x04000390 RID: 912
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int money;
	}

	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	public enum WalletItemType
	{
		// Token: 0x04000392 RID: 914
		[Token(Token = "0x4000392")]
		nothing,
		// Token: 0x04000393 RID: 915
		[Token(Token = "0x4000393")]
		money,
		// Token: 0x04000394 RID: 916
		[Token(Token = "0x4000394")]
		evidence,
		// Token: 0x04000395 RID: 917
		[Token(Token = "0x4000395")]
		key
	}

	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	public struct BookChoice
	{
		// Token: 0x04000396 RID: 918
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BookPreset p;

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float rank;
	}

	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	public enum NoteObject
	{
		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		note,
		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		letter,
		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		travelReceipt,
		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		vmailLetter
	}

	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060003EE RID: 1006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x49FAE0", Offset = "0x49EAE0", VA = "0x18049FAE0")]
		internal bool <SetJob>b__159_1(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x49FAE0", Offset = "0x49EAE0", VA = "0x18049FAE0")]
		internal bool <SetJob>b__159_0(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x7A0A70", Offset = "0x79FA70", VA = "0x1807A0A70")]
		internal int <SetPersonality>b__164_0(Human.BookChoice p1, Human.BookChoice p2)
		{
			return 0;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x7900D0", Offset = "0x78F0D0", VA = "0x1807900D0")]
		internal bool <SetPersonality>b__164_2(DDSSaveClasses.DDSBlockCondition item)
		{
			return default(bool);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xDCF7C0", Offset = "0xDCE7C0", VA = "0x180DCF7C0")]
		internal bool <PickPassword>b__184_0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xDCF850", Offset = "0xDCE850", VA = "0x180DCF850")]
		internal bool <PickPassword>b__184_1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xDCF8E0", Offset = "0xDCE8E0", VA = "0x180DCF8E0")]
		internal bool <PickPassword>b__184_2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xDCF970", Offset = "0xDCE970", VA = "0x180DCF970")]
		internal bool <PickPassword>b__184_3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xDCFA00", Offset = "0xDCEA00", VA = "0x180DCFA00")]
		internal bool <TestInteractionInstances>b__190_0(DDSSaveClasses.DDSMessageLink item)
		{
			return default(bool);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xDCFA30", Offset = "0xDCEA30", VA = "0x180DCFA30")]
		internal bool <TestInteractionInstances>b__190_1(DDSSaveClasses.DDSMessageLink item)
		{
			return default(bool);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xDCFA60", Offset = "0xDCEA60", VA = "0x180DCFA60")]
		internal bool <TestInteractionInstances>b__190_2(DDSSaveClasses.DDSMessageLink item)
		{
			return default(bool);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xDCFA90", Offset = "0xDCEA90", VA = "0x180DCFA90")]
		internal bool <TestInteractionInstances>b__190_3(DDSSaveClasses.DDSMessageLink item)
		{
			return default(bool);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x7920F0", Offset = "0x7910F0", VA = "0x1807920F0")]
		internal bool <ExecuteAndTestCurrentInteractionEvent>b__192_4(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x957BA0", Offset = "0x956BA0", VA = "0x180957BA0")]
		internal bool <SetupInteractables>b__193_0(InteractableController item)
		{
			return default(bool);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xDCFAC0", Offset = "0xDCEAC0", VA = "0x180DCFAC0")]
		internal bool <SetupInteractables>b__193_1(InteractableController item)
		{
			return default(bool);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xDCFAE0", Offset = "0xDCEAE0", VA = "0x180DCFAE0")]
		internal bool <SetupInteractables>b__193_2(InteractableController item)
		{
			return default(bool);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xDCFB00", Offset = "0xDCEB00", VA = "0x180DCFB00")]
		internal bool <CreateAcquaintances>b__204_1(Occupation item)
		{
			return default(bool);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x6000400")]
		[Address(RVA = "0xDCFC30", Offset = "0xDCEC30", VA = "0x180DCFC30")]
		internal bool <CreateAcquaintances>b__204_0(Acquaintance item)
		{
			return default(bool);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x6000401")]
		[Address(RVA = "0xDCFCB0", Offset = "0xDCECB0", VA = "0x180DCFCB0")]
		internal bool <WakeUp>b__211_0(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x6000402")]
		[Address(RVA = "0xDCFD50", Offset = "0xDCED50", VA = "0x180DCFD50")]
		internal bool <WakeUp>b__211_1(NewAIGoal item)
		{
			return default(bool);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x6000403")]
		[Address(RVA = "0xDCFDF0", Offset = "0xDCEDF0", VA = "0x180DCFDF0")]
		internal bool <WakeUp>b__211_2(NewAIAction item)
		{
			return default(bool);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x6000404")]
		[Address(RVA = "0xDCFE90", Offset = "0xDCEE90", VA = "0x180DCFE90")]
		internal bool <FindSafeTeleport>b__242_0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x6000405")]
		[Address(RVA = "0xDCFEC0", Offset = "0xDCEEC0", VA = "0x180DCFEC0")]
		internal bool <FindSafeTeleport>b__244_0(NewWall item)
		{
			return default(bool);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x6000406")]
		[Address(RVA = "0xDCFFE0", Offset = "0xDCEFE0", VA = "0x180DCFFE0")]
		internal bool <SpawnInventoryItems>b__246_1(Game.DebugCitizenWeapons item)
		{
			return default(bool);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x6000407")]
		[Address(RVA = "0xDD0000", Offset = "0xDCF000", VA = "0x180DD0000")]
		internal int <SpeechTriggerPoint>b__254_1(DDSSaveClasses.DDSTreeSave p1, DDSSaveClasses.DDSTreeSave p2)
		{
			return 0;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x6000408")]
		[Address(RVA = "0xDD0040", Offset = "0xDCF040", VA = "0x180DD0040")]
		internal bool <ParseDDSMessage>b__259_2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x6000409")]
		[Address(RVA = "0xDD0120", Offset = "0xDCF120", VA = "0x180DD0120")]
		internal bool <ParseDDSMessage>b__259_3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x600040A")]
		[Address(RVA = "0xDD01B0", Offset = "0xDCF1B0", VA = "0x180DD01B0")]
		internal bool <ParseDDSMessage>b__259_4(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x600040B")]
		[Address(RVA = "0xCC28B0", Offset = "0xCC18B0", VA = "0x180CC28B0")]
		internal bool <ParseDDSMessage>b__259_5(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x600040C")]
		[Address(RVA = "0xCC28B0", Offset = "0xCC18B0", VA = "0x180CC28B0")]
		internal bool <ParseDDSMessage>b__259_7(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x600040D")]
		[Address(RVA = "0xB2F380", Offset = "0xB2E380", VA = "0x180B2F380")]
		internal int <ParseDDSMessage>b__259_9(Human.DDSRank p1, Human.DDSRank p2)
		{
			return 0;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x4E6D90", Offset = "0x4E5D90", VA = "0x1804E6D90")]
		internal int <GetConversationTreeLinkRankings>b__266_0(Human.DDSRank p1, Human.DDSRank p2)
		{
			return 0;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x600040F")]
		[Address(RVA = "0xDD0240", Offset = "0xDCF240", VA = "0x180DD0240")]
		internal int <GetDoctor>b__271_1(Occupation p1, Occupation p2)
		{
			return 0;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x6000410")]
		[Address(RVA = "0xDD02A0", Offset = "0xDCF2A0", VA = "0x180DD02A0")]
		internal bool <GetLandlord>b__272_0(Occupation item)
		{
			return default(bool);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x6000411")]
		[Address(RVA = "0xDD0240", Offset = "0xDCF240", VA = "0x180DD0240")]
		internal int <GetLandlord>b__272_1(Occupation p1, Occupation p2)
		{
			return 0;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x6000412")]
		[Address(RVA = "0xDD0430", Offset = "0xDCF430", VA = "0x180DD0430")]
		internal bool <WalletItemCheck>b__281_0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x6000413")]
		[Address(RVA = "0xDD04D0", Offset = "0xDCF4D0", VA = "0x180DD04D0")]
		internal bool <WalletItemCheck>b__281_1(Human.WalletItem item)
		{
			return default(bool);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x6000414")]
		[Address(RVA = "0xDD0630", Offset = "0xDCF630", VA = "0x180DD0630")]
		internal bool <WalletItemCheck>b__281_2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x6000415")]
		[Address(RVA = "0xDD06D0", Offset = "0xDCF6D0", VA = "0x180DD06D0")]
		internal bool <WalletItemCheck>b__281_3(Human.WalletItem item)
		{
			return default(bool);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x477740", Offset = "0x476740", VA = "0x180477740")]
		internal bool <WalletItemCheck>b__281_4(Human.WalletItem item)
		{
			return default(bool);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x874F10", Offset = "0x873F10", VA = "0x180874F10")]
		internal bool <WalletItemCheck>b__281_5(Human.WalletItem item)
		{
			return default(bool);
		}

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Human.<>c <>9;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<NewAIGoal> <>9__159_1;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<NewAIGoal> <>9__159_0;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Comparison<Human.BookChoice> <>9__164_0;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<DDSSaveClasses.DDSBlockCondition> <>9__164_2;

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<Human.Trait> <>9__184_0;

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<Human.Trait> <>9__184_1;

		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<Human.Trait> <>9__184_2;

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Predicate<Human.Trait> <>9__184_3;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Predicate<DDSSaveClasses.DDSMessageLink> <>9__190_0;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Predicate<DDSSaveClasses.DDSMessageLink> <>9__190_1;

		// Token: 0x040003A8 RID: 936
		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Predicate<DDSSaveClasses.DDSMessageLink> <>9__190_2;

		// Token: 0x040003A9 RID: 937
		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Predicate<DDSSaveClasses.DDSMessageLink> <>9__190_3;

		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Predicate<Interactable> <>9__192_4;

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static Predicate<InteractableController> <>9__193_0;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static Predicate<InteractableController> <>9__193_1;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static Predicate<InteractableController> <>9__193_2;

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static Predicate<Occupation> <>9__204_1;

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static Predicate<Acquaintance> <>9__204_0;

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static Predicate<NewAIGoal> <>9__211_0;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static Predicate<NewAIGoal> <>9__211_1;

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static Predicate<NewAIAction> <>9__211_2;

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static Predicate<NewNode.NodeAccess> <>9__242_0;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static Predicate<NewWall> <>9__244_0;

		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static Predicate<Game.DebugCitizenWeapons> <>9__246_1;

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static Comparison<DDSSaveClasses.DDSTreeSave> <>9__254_1;

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static Predicate<Human.Trait> <>9__259_2;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public static Predicate<Human.Trait> <>9__259_3;

		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public static Predicate<Human.Trait> <>9__259_4;

		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static Predicate<Interactable.Passed> <>9__259_5;

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public static Predicate<Interactable.Passed> <>9__259_7;

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public static Comparison<Human.DDSRank> <>9__259_9;

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public static Comparison<Human.DDSRank> <>9__266_0;

		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public static Comparison<Occupation> <>9__271_1;

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public static Predicate<Occupation> <>9__272_0;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public static Comparison<Occupation> <>9__272_1;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public static Predicate<Human.Trait> <>9__281_0;

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public static Predicate<Human.WalletItem> <>9__281_1;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public static Predicate<Human.Trait> <>9__281_2;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public static Predicate<Human.WalletItem> <>9__281_3;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public static Predicate<Human.WalletItem> <>9__281_4;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public static Predicate<Human.WalletItem> <>9__281_5;
	}

	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	private sealed class <>c__DisplayClass164_0
	{
		// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass164_0()
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <SetPersonality>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait trait;
	}

	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	private sealed class <>c__DisplayClass167_0
	{
		// Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass167_0()
		{
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x600041B")]
		[Address(RVA = "0xDD0830", Offset = "0xDCF830", VA = "0x180DD0830")]
		internal bool <TraitExists>b__0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	private sealed class <>c__DisplayClass168_0
	{
		// Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass168_0()
		{
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GetChance>b__0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	private sealed class <>c__DisplayClass168_1
	{
		// Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass168_1()
		{
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GetChance>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	private sealed class <>c__DisplayClass168_2
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass168_2()
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GetChance>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	private sealed class <>c__DisplayClass168_3
	{
		// Token: 0x06000422 RID: 1058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass168_3()
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GetChance>b__3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	private sealed class <>c__DisplayClass169_0
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass169_0()
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <AddCharacterTrait>b__0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	private sealed class <>c__DisplayClass169_1
	{
		// Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass169_1()
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <AddCharacterTrait>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	private sealed class <>c__DisplayClass169_2
	{
		// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass169_2()
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <AddCharacterTrait>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	private sealed class <>c__DisplayClass169_3
	{
		// Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass169_3()
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <AddCharacterTrait>b__3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	private sealed class <>c__DisplayClass188_0
	{
		// Token: 0x0600042C RID: 1068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass188_0()
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x600042D")]
		[Address(RVA = "0xDD0870", Offset = "0xDCF870", VA = "0x180DD0870")]
		internal bool <GeneratePastVmails>b__0(StateSaveData.MessageThreadSave item)
		{
			return default(bool);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x600042E")]
		[Address(RVA = "0xDD0870", Offset = "0xDCF870", VA = "0x180DD0870")]
		internal bool <GeneratePastVmails>b__1(StateSaveData.MessageThreadSave item)
		{
			return default(bool);
		}

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DDSSaveClasses.DDSTreeSave sp;
	}

	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	private sealed class <>c__DisplayClass192_0
	{
		// Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass192_0()
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x80E060", Offset = "0x80D060", VA = "0x18080E060")]
		internal bool <ExecuteAndTestCurrentInteractionEvent>b__0(NewspaperController.InteractionDialogFeature item)
		{
			return default(bool);
		}

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DDSSaveClasses.DDSMessageSave msg;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<NewspaperController.InteractionDialogFeature> <>9__0;
	}

	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	private sealed class <>c__DisplayClass192_1
	{
		// Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass192_1()
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x6000432")]
		[Address(RVA = "0xDD08E0", Offset = "0xDCF8E0", VA = "0x180DD08E0")]
		internal bool <ExecuteAndTestCurrentInteractionEvent>b__1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset newItem;
	}

	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	private sealed class <>c__DisplayClass192_2
	{
		// Token: 0x06000433 RID: 1075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass192_2()
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x6000434")]
		[Address(RVA = "0xDD0A70", Offset = "0xDCFA70", VA = "0x180DD0A70")]
		internal bool <ExecuteAndTestCurrentInteractionEvent>b__2(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x6000435")]
		[Address(RVA = "0xDD0AE0", Offset = "0xDCFAE0", VA = "0x180DD0AE0")]
		internal bool <ExecuteAndTestCurrentInteractionEvent>b__3(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Interactable testingForItem;
	}

	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	private sealed class <>c__DisplayClass192_3
	{
		// Token: 0x06000436 RID: 1078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass192_3()
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x478670", Offset = "0x477670", VA = "0x180478670")]
		internal bool <ExecuteAndTestCurrentInteractionEvent>b__5(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurniturePreset.SubObject so;
	}

	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	private sealed class <>c__DisplayClass194_0
	{
		// Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass194_0()
		{
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x51E920", Offset = "0x51D920", VA = "0x18051E920")]
		internal bool <Load>b__0(Occupation item)
		{
			return default(bool);
		}

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CitySaveData.HumanCitySave data;
	}

	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	private sealed class <>c__DisplayClass194_1
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass194_1()
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x600043B")]
		[Address(RVA = "0xB3D8D0", Offset = "0xB3C8D0", VA = "0x180B3D8D0")]
		internal bool <Load>b__1(CharacterTrait item)
		{
			return default(bool);
		}

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CitySaveData.CharTraitSave traitSave;
	}

	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	private sealed class <>c__DisplayClass194_2
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass194_2()
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x51E9E0", Offset = "0x51D9E0", VA = "0x18051E9E0")]
		internal bool <Load>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x600043E")]
		[Address(RVA = "0xDD0D00", Offset = "0xDCFD00", VA = "0x180DD0D00")]
		internal bool <Load>b__3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CitySaveData.CharTraitSave traitSave;
	}

	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	private sealed class <>c__DisplayClass196_0
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass196_0()
		{
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x6000440")]
		[Address(RVA = "0xDD0D30", Offset = "0xDCFD30", VA = "0x180DD0D30")]
		internal bool <LoadFavourites>b__0(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CitySaveData.HumanCitySave data;

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int i;

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Predicate<NewAddress> <>9__0;
	}

	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	private sealed class <>c__DisplayClass198_0
	{
		// Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass198_0()
		{
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <TraitGoalTest>b__0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	private sealed class <>c__DisplayClass198_1
	{
		// Token: 0x06000443 RID: 1091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass198_1()
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <TraitGoalTest>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	private sealed class <>c__DisplayClass198_2
	{
		// Token: 0x06000445 RID: 1093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass198_2()
		{
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <TraitGoalTest>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	private sealed class <>c__DisplayClass198_3
	{
		// Token: 0x06000447 RID: 1095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass198_3()
		{
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <TraitGoalTest>b__3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	private sealed class <>c__DisplayClass245_0
	{
		// Token: 0x06000449 RID: 1097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass245_0()
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GenerateItemFavs>b__0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait blockedTrait;
	}

	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	private sealed class <>c__DisplayClass245_1
	{
		// Token: 0x0600044B RID: 1099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass245_1()
		{
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GenerateItemFavs>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait blockedTrait;
	}

	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	private sealed class <>c__DisplayClass245_2
	{
		// Token: 0x0600044D RID: 1101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass245_2()
		{
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <GenerateItemFavs>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait blockedTrait;
	}

	// Token: 0x02000088 RID: 136
	[Token(Token = "0x2000088")]
	private sealed class <>c__DisplayClass245_3
	{
		// Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass245_3()
		{
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x6000450")]
		[Address(RVA = "0xDD0DC0", Offset = "0xDCFDC0", VA = "0x180DD0DC0")]
		internal bool <GenerateItemFavs>b__3(Company item)
		{
			return default(bool);
		}

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CompanyPreset.CompanyCategory cat;
	}

	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	private sealed class <>c__DisplayClass246_0
	{
		// Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass246_0()
		{
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x6000452")]
		[Address(RVA = "0xDD0E60", Offset = "0xDCFE60", VA = "0x180DD0E60")]
		internal bool <SpawnInventoryItems>b__0(Game.DebugCitizenWeapons item)
		{
			return default(bool);
		}

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InteractablePreset chosen;
	}

	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	private sealed class <>c__DisplayClass247_0
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass247_0()
		{
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <WeaponTraitTest>b__0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	private sealed class <>c__DisplayClass247_1
	{
		// Token: 0x06000455 RID: 1109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass247_1()
		{
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <WeaponTraitTest>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	private sealed class <>c__DisplayClass247_2
	{
		// Token: 0x06000457 RID: 1111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass247_2()
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <WeaponTraitTest>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	private sealed class <>c__DisplayClass247_3
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass247_3()
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <WeaponTraitTest>b__3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	private sealed class <>c__DisplayClass259_0
	{
		// Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass259_0()
		{
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x600045C")]
		[Address(RVA = "0xDD0ED0", Offset = "0xDCFED0", VA = "0x180DD0ED0")]
		internal bool <ParseDDSMessage>b__0(Case.ResolveQuestion item)
		{
			return default(bool);
		}

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DDSSaveClasses.DDSBlockCondition conditions;
	}

	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	private sealed class <>c__DisplayClass259_1
	{
		// Token: 0x0600045D RID: 1117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass259_1()
		{
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x600045E")]
		[Address(RVA = "0xDD0F40", Offset = "0xDCFF40", VA = "0x180DD0F40")]
		internal bool <ParseDDSMessage>b__1(DDSSaveClasses.DDSBlockCondition item)
		{
			return default(bool);
		}

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int displayGroupFromLeadPool;
	}

	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	private sealed class <>c__DisplayClass259_2
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass259_2()
		{
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x684F40", Offset = "0x683F40", VA = "0x180684F40")]
		internal bool <ParseDDSMessage>b__6(NewBuilding item)
		{
			return default(bool);
		}

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Interactable.Passed passedLost;
	}

	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	private sealed class <>c__DisplayClass259_3
	{
		// Token: 0x06000461 RID: 1121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass259_3()
		{
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x684F40", Offset = "0x683F40", VA = "0x180684F40")]
		internal bool <ParseDDSMessage>b__8(NewBuilding item)
		{
			return default(bool);
		}

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Interactable.Passed passedLost;
	}

	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	private sealed class <>c__DisplayClass282_0
	{
		// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass282_0()
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x6000464")]
		[Address(RVA = "0xDD0F60", Offset = "0xDCFF60", VA = "0x180DD0F60")]
		internal bool <UpdateLastSighting>b__0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human citizen;
	}

	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	private sealed class <>c__DisplayClass295_0
	{
		// Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass295_0()
		{
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x6000466")]
		[Address(RVA = "0xDD1140", Offset = "0xDD0140", VA = "0x180DD1140")]
		internal bool <TryGiveItem>b__1(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Interactable givenItem;
	}

	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	private sealed class <>c__DisplayClass295_1
	{
		// Token: 0x06000467 RID: 1127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass295_1()
		{
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x6000468")]
		[Address(RVA = "0xDD1170", Offset = "0xDD0170", VA = "0x180DD1170")]
		internal bool <TryGiveItem>b__0(Human item)
		{
			return default(bool);
		}

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameplayController.LostAndFound lf;
	}
}
