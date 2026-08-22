using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000346 RID: 838
[Token(Token = "0x2000346")]
[Serializable]
public class SideJob
{
	// Token: 0x14000020 RID: 32
	// (add) Token: 0x060012F2 RID: 4850 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060012F3 RID: 4851 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000020")]
	public event SideJob.ObjectivesChange OnObjectivesChanged
	{
		[Token(Token = "0x60012F2")]
		[Address(RVA = "0x728B60", Offset = "0x727B60", VA = "0x180728B60")]
		add
		{
		}
		[Token(Token = "0x60012F3")]
		[Address(RVA = "0x728C60", Offset = "0x727C60", VA = "0x180728C60")]
		remove
		{
		}
	}

	// Token: 0x14000021 RID: 33
	// (add) Token: 0x060012F4 RID: 4852 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060012F5 RID: 4853 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000021")]
	public event SideJob.AcquireJobInfo AcquireInfo
	{
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x728D60", Offset = "0x727D60", VA = "0x180728D60")]
		add
		{
		}
		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x728E60", Offset = "0x727E60", VA = "0x180728E60")]
		remove
		{
		}
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F6")]
	[Address(RVA = "0x728F60", Offset = "0x727F60", VA = "0x180728F60")]
	public SideJob(JobPreset newPreset, SideJobController.JobPickData newData, bool immediatePost)
	{
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x7299B0", Offset = "0x7289B0", VA = "0x1807299B0", Slot = "4")]
	public virtual void GenerateFakeNumber()
	{
	}

	// Token: 0x060012F8 RID: 4856 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x729D30", Offset = "0x728D30", VA = "0x180729D30", Slot = "5")]
	public virtual void ChooseIntro()
	{
	}

	// Token: 0x060012F9 RID: 4857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012F9")]
	[Address(RVA = "0x72A0E0", Offset = "0x7290E0", VA = "0x18072A0E0", Slot = "6")]
	public virtual void ChooseHandIn()
	{
	}

	// Token: 0x060012FA RID: 4858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FA")]
	[Address(RVA = "0x72A490", Offset = "0x729490", VA = "0x18072A490", Slot = "7")]
	public virtual void SpawnItems(ref List<JobPreset.StartingSpawnItem> spawnThese)
	{
	}

	// Token: 0x060012FB RID: 4859 RVA: 0x00008F10 File Offset: 0x00007110
	[Token(Token = "0x60012FB")]
	[Address(RVA = "0x72B450", Offset = "0x72A450", VA = "0x18072B450")]
	private bool SpawnItemIsValid(JobPreset.StartingSpawnItem spawn, ref List<JobPreset.StartingSpawnItem> successsfullySpawned, bool useChance)
	{
		return default(bool);
	}

	// Token: 0x060012FC RID: 4860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FC")]
	[Address(RVA = "0x72C200", Offset = "0x72B200", VA = "0x18072C200", Slot = "8")]
	public virtual void GameWorldLoop()
	{
	}

	// Token: 0x060012FD RID: 4861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60012FD")]
	[Address(RVA = "0x72C240", Offset = "0x72B240", VA = "0x18072C240", Slot = "9")]
	public virtual void HandleObjectiveProgress()
	{
	}

	// Token: 0x060012FE RID: 4862 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012FE")]
	[Address(RVA = "0x72CF60", Offset = "0x72BF60", VA = "0x18072CF60")]
	public NewGameLocation GetGameLocationFromQuestionInput(Case.ResolveQuestion question)
	{
		return null;
	}

	// Token: 0x060012FF RID: 4863 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x72D2D0", Offset = "0x72C2D0", VA = "0x18072D2D0")]
	public Human GetCitizenFromQuestionInput(Case.ResolveQuestion question)
	{
		return null;
	}

	// Token: 0x06001300 RID: 4864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001300")]
	[Address(RVA = "0x72D630", Offset = "0x72C630", VA = "0x18072D630", Slot = "10")]
	public virtual void ObjectiveStateLoop()
	{
	}

	// Token: 0x06001301 RID: 4865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001301")]
	[Address(RVA = "0x732E10", Offset = "0x731E10", VA = "0x180732E10")]
	public void GenerateHidingLocation()
	{
	}

	// Token: 0x06001302 RID: 4866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001302")]
	[Address(RVA = "0x7333E0", Offset = "0x7323E0", VA = "0x1807333E0")]
	public void OnPlayerCall()
	{
	}

	// Token: 0x06001303 RID: 4867 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001303")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "11")]
	public virtual void OnGooseChaseCallTriggered()
	{
	}

	// Token: 0x06001304 RID: 4868 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001304")]
	[Address(RVA = "0x733570", Offset = "0x732570", VA = "0x180733570", Slot = "12")]
	public virtual void OnGooseChaseSuccess()
	{
	}

	// Token: 0x06001305 RID: 4869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001305")]
	[Address(RVA = "0x733640", Offset = "0x732640", VA = "0x180733640", Slot = "13")]
	public virtual void OnGooseChaseEnd()
	{
	}

	// Token: 0x06001306 RID: 4870 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001306")]
	[Address(RVA = "0x420BC0", Offset = "0x41FBC0", VA = "0x180420BC0", Slot = "14")]
	public virtual Human GetExtraPerson1()
	{
		return null;
	}

	// Token: 0x06001307 RID: 4871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001307")]
	[Address(RVA = "0x7337D0", Offset = "0x7327D0", VA = "0x1807337D0", Slot = "15")]
	public virtual void SubmitCase()
	{
	}

	// Token: 0x06001308 RID: 4872 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001308")]
	[Address(RVA = "0x733B80", Offset = "0x732B80", VA = "0x180733B80")]
	public Interactable SpawnJobItem(InteractablePreset spawnItem, JobPreset.JobSpawnWhere spawnWhere, JobPreset.LeadCitizen spawnBelongsTo, JobPreset.LeadCitizen spawnWriter, JobPreset.LeadCitizen spawnReceiver, int security, InteractablePreset.OwnedPlacementRule ownedRule, int priority, JobPreset.JobTag itemTag, bool tryFindExisting)
	{
		return null;
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001309")]
	[Address(RVA = "0x734A80", Offset = "0x733A80", VA = "0x180734A80")]
	public Interactable FindExisting(InteractablePreset what, NewGameLocation location, Human belongsTo, Human writer, Human receiver, JobPreset.JobTag itemTag)
	{
		return null;
	}

	// Token: 0x0600130A RID: 4874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130A")]
	[Address(RVA = "0x735970", Offset = "0x734970", VA = "0x180735970")]
	public void SetJobState(SideJob.JobState newState, bool forceUpdate = false)
	{
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130B")]
	[Address(RVA = "0x736150", Offset = "0x735150", VA = "0x180736150")]
	public void SetupNonSerializedData()
	{
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130C")]
	[Address(RVA = "0x7373C0", Offset = "0x7363C0", VA = "0x1807373C0", Slot = "16")]
	public virtual void Complete()
	{
	}

	// Token: 0x0600130D RID: 4877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130D")]
	[Address(RVA = "0x737510", Offset = "0x736510", VA = "0x180737510", Slot = "17")]
	public virtual void End()
	{
	}

	// Token: 0x0600130E RID: 4878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130E")]
	[Address(RVA = "0x738440", Offset = "0x737440", VA = "0x180738440", Slot = "18")]
	public virtual void OnRewarded()
	{
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600130F")]
	[Address(RVA = "0x739860", Offset = "0x738860", VA = "0x180739860", Slot = "19")]
	public virtual void PostJob()
	{
	}

	// Token: 0x06001310 RID: 4880 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001310")]
	[Address(RVA = "0x73B140", Offset = "0x73A140", VA = "0x18073B140", Slot = "20")]
	public virtual void AcceptJob()
	{
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001311")]
	[Address(RVA = "0x73B770", Offset = "0x73A770", VA = "0x18073B770", Slot = "21")]
	public virtual void SetHandIn()
	{
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001312")]
	[Address(RVA = "0x73BD20", Offset = "0x73AD20", VA = "0x18073BD20", Slot = "22")]
	public virtual void AddObjective(string entryRef, Objective.ObjectiveTrigger trigger, bool usePointer = false, [Optional] Vector3 pointerPosition, InterfaceControls.Icon useIcon = InterfaceControls.Icon.lookingGlass, Objective.OnCompleteAction onCompleteAction = Objective.OnCompleteAction.nextChapterPart, float delay = 0f, bool removePrevious = false, string chapterString = "", bool isSilent = false, bool allowCrouchPromt = false)
	{
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001313")]
	[Address(RVA = "0x73C090", Offset = "0x73B090", VA = "0x18073C090", Slot = "23")]
	public virtual void OnObjectiveChange()
	{
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001314")]
	[Address(RVA = "0x73C0C0", Offset = "0x73B0C0", VA = "0x18073C0C0", Slot = "24")]
	public virtual void AddDialogOption(Human person, Evidence.DataKey key, DialogPreset newPreset, [Optional] NewRoom roomRef)
	{
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001315")]
	[Address(RVA = "0x73C790", Offset = "0x73B790", VA = "0x18073C790", Slot = "25")]
	public virtual void OnAcquireJobInfo(DialogPreset dialog)
	{
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001316")]
	[Address(RVA = "0x73C9A0", Offset = "0x73B9A0", VA = "0x18073C9A0", Slot = "26")]
	public virtual void OnAcquireJobInfo(string infoDialogMessage)
	{
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001317")]
	[Address(RVA = "0x73CBF0", Offset = "0x73BBF0", VA = "0x18073CBF0")]
	public void CreateAcqusitionFacts()
	{
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001318")]
	[Address(RVA = "0x73D010", Offset = "0x73C010", VA = "0x18073D010")]
	private void PickPoolLeadOptions()
	{
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001319")]
	[Address(RVA = "0x73E250", Offset = "0x73D250", VA = "0x18073E250")]
	private void ApplyLeads(ref List<JobPreset.StartingLead> leads)
	{
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600131A")]
	[Address(RVA = "0x73FE60", Offset = "0x73EE60", VA = "0x18073FE60")]
	private Evidence GetEvidence(JobPreset.LeadEvidence lead)
	{
		return null;
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600131B")]
	[Address(RVA = "0x741420", Offset = "0x740420", VA = "0x180741420", Slot = "27")]
	public virtual void GenerateResolveQuestions(bool setRewardType)
	{
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600131C")]
	[Address(RVA = "0x742C50", Offset = "0x741C50", VA = "0x180742C50")]
	private RevengeObjective GetRevengeObjective(Case.ResolveQuestion resolveQ)
	{
		return null;
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600131D")]
	[Address(RVA = "0x743C30", Offset = "0x742C30", VA = "0x180743C30")]
	private NewGameLocation GetGameLocation(JobPreset.JobSpawnWhere spawnWhere)
	{
		return null;
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600131E")]
	[Address(RVA = "0x746340", Offset = "0x745340", VA = "0x180746340")]
	private Human GetTarget(JobPreset.LeadCitizen who)
	{
		return null;
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600131F")]
	[Address(RVA = "0x746390", Offset = "0x745390", VA = "0x180746390")]
	public Interactable GetItem(JobPreset.JobTag tag)
	{
		return null;
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001320")]
	[Address(RVA = "0x746400", Offset = "0x745400", VA = "0x180746400", Slot = "28")]
	public virtual void UpdateResolveAnswers()
	{
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x00008F28 File Offset: 0x00007128
	[Token(Token = "0x6001321")]
	[Address(RVA = "0x748B00", Offset = "0x747B00", VA = "0x180748B00")]
	public float GetDifficulty()
	{
		return 0f;
	}

	// Token: 0x06001322 RID: 4898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001322")]
	[Address(RVA = "0x748E60", Offset = "0x747E60", VA = "0x180748E60")]
	public void AddConfineLocation(Human who, NewAddress where)
	{
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001323")]
	[Address(RVA = "0x749190", Offset = "0x748190", VA = "0x180749190")]
	public void RemoveConfineLocation(Human who, NewAddress where)
	{
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001324")]
	[Address(RVA = "0x749600", Offset = "0x748600", VA = "0x180749600", Slot = "29")]
	public virtual void DisplayResolveObjectivesCheck()
	{
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001325")]
	[Address(RVA = "0x749EF0", Offset = "0x748EF0", VA = "0x180749EF0", Slot = "30")]
	public virtual void TriggerFail(string reason)
	{
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001326")]
	[Address(RVA = "0x74A120", Offset = "0x749120", VA = "0x18074A120", Slot = "31")]
	public virtual void OnDestroyMissionObject(Interactable destroyed)
	{
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001327")]
	[Address(RVA = "0x74A3F0", Offset = "0x7493F0", VA = "0x18074A3F0", Slot = "32")]
	public virtual void DebugDisplayAnswers()
	{
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x00008F40 File Offset: 0x00007140
	[Token(Token = "0x6001329")]
	[Address(RVA = "0x74A6A0", Offset = "0x7496A0", VA = "0x18074A6A0")]
	private bool <ObjectiveStateLoop>b__73_0(SideMissionHandInPreset item)
	{
		return default(bool);
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x00008F58 File Offset: 0x00007158
	[Token(Token = "0x600132A")]
	[Address(RVA = "0x74A740", Offset = "0x749740", VA = "0x18074A740")]
	private bool <ObjectiveStateLoop>b__73_1(SideMissionIntroPreset item)
	{
		return default(bool);
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x00008F70 File Offset: 0x00007170
	[Token(Token = "0x600132B")]
	[Address(RVA = "0x74A7E0", Offset = "0x7497E0", VA = "0x18074A7E0")]
	private bool <ObjectiveStateLoop>b__73_4(JobPreset.DialogReference item)
	{
		return default(bool);
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x00008F88 File Offset: 0x00007188
	[Token(Token = "0x600132C")]
	[Address(RVA = "0x74A7E0", Offset = "0x7497E0", VA = "0x18074A7E0")]
	private bool <ObjectiveStateLoop>b__73_5(JobPreset.DialogReference item)
	{
		return default(bool);
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x00008FA0 File Offset: 0x000071A0
	[Token(Token = "0x600132D")]
	[Address(RVA = "0x74A7E0", Offset = "0x7497E0", VA = "0x18074A7E0")]
	private bool <ObjectiveStateLoop>b__73_6(JobPreset.DialogReference item)
	{
		return default(bool);
	}

	// Token: 0x0600132E RID: 4910 RVA: 0x00008FB8 File Offset: 0x000071B8
	[Token(Token = "0x600132E")]
	[Address(RVA = "0x74A880", Offset = "0x749880", VA = "0x18074A880")]
	private bool <ObjectiveStateLoop>b__73_9(Telephone item)
	{
		return default(bool);
	}

	// Token: 0x0600132F RID: 4911 RVA: 0x00008FD0 File Offset: 0x000071D0
	[Token(Token = "0x600132F")]
	[Address(RVA = "0x74AC20", Offset = "0x749C20", VA = "0x18074AC20")]
	private bool <ObjectiveStateLoop>b__73_10(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x06001330 RID: 4912 RVA: 0x00008FE8 File Offset: 0x000071E8
	[Token(Token = "0x6001330")]
	[Address(RVA = "0x74A7E0", Offset = "0x7497E0", VA = "0x18074A7E0")]
	private bool <ObjectiveStateLoop>b__73_11(JobPreset.DialogReference item)
	{
		return default(bool);
	}

	// Token: 0x06001331 RID: 4913 RVA: 0x00009000 File Offset: 0x00007200
	[Token(Token = "0x6001331")]
	[Address(RVA = "0x74AEE0", Offset = "0x749EE0", VA = "0x18074AEE0")]
	private bool <ObjectiveStateLoop>b__73_12(NewAIGoal item)
	{
		return default(bool);
	}

	// Token: 0x06001332 RID: 4914 RVA: 0x00009018 File Offset: 0x00007218
	[Token(Token = "0x6001332")]
	[Address(RVA = "0x74A7E0", Offset = "0x7497E0", VA = "0x18074A7E0")]
	private bool <ObjectiveStateLoop>b__73_13(JobPreset.DialogReference item)
	{
		return default(bool);
	}

	// Token: 0x06001333 RID: 4915 RVA: 0x00009030 File Offset: 0x00007230
	[Token(Token = "0x6001333")]
	[Address(RVA = "0x74AFB0", Offset = "0x749FB0", VA = "0x18074AFB0")]
	private bool <ObjectiveStateLoop>b__73_14(Telephone item)
	{
		return default(bool);
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x00009048 File Offset: 0x00007248
	[Token(Token = "0x6001334")]
	[Address(RVA = "0x74A7E0", Offset = "0x7497E0", VA = "0x18074A7E0")]
	private bool <ObjectiveStateLoop>b__73_15(JobPreset.DialogReference item)
	{
		return default(bool);
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x00009060 File Offset: 0x00007260
	[Token(Token = "0x6001335")]
	[Address(RVA = "0x74AEE0", Offset = "0x749EE0", VA = "0x18074AEE0")]
	private bool <ObjectiveStateLoop>b__73_3(NewAIGoal item)
	{
		return default(bool);
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x00009078 File Offset: 0x00007278
	[Token(Token = "0x6001336")]
	[Address(RVA = "0x74A7E0", Offset = "0x7497E0", VA = "0x18074A7E0")]
	private bool <ObjectiveStateLoop>b__73_16(JobPreset.DialogReference item)
	{
		return default(bool);
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x00009090 File Offset: 0x00007290
	[Token(Token = "0x6001337")]
	[Address(RVA = "0x74A7E0", Offset = "0x7497E0", VA = "0x18074A7E0")]
	private bool <ObjectiveStateLoop>b__73_17(JobPreset.DialogReference item)
	{
		return default(bool);
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x000090A8 File Offset: 0x000072A8
	[Token(Token = "0x6001338")]
	[Address(RVA = "0x74B010", Offset = "0x74A010", VA = "0x18074B010")]
	private bool <SetJobState>b__83_0(SideJobController.JobTracking item)
	{
		return default(bool);
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x000090C0 File Offset: 0x000072C0
	[Token(Token = "0x6001339")]
	[Address(RVA = "0x74B010", Offset = "0x74A010", VA = "0x18074B010")]
	private bool <SetJobState>b__83_1(SideJobController.JobTracking item)
	{
		return default(bool);
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x000090D8 File Offset: 0x000072D8
	[Token(Token = "0x600133A")]
	[Address(RVA = "0x74B070", Offset = "0x74A070", VA = "0x18074B070")]
	private bool <SetupNonSerializedData>b__84_0(Case item)
	{
		return default(bool);
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x000090F0 File Offset: 0x000072F0
	[Token(Token = "0x600133B")]
	[Address(RVA = "0x74B090", Offset = "0x74A090", VA = "0x18074B090")]
	private bool <SetupNonSerializedData>b__84_1(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x00009108 File Offset: 0x00007308
	[Token(Token = "0x600133C")]
	[Address(RVA = "0x74B0B0", Offset = "0x74A0B0", VA = "0x18074B0B0")]
	private bool <SetupNonSerializedData>b__84_2(Interactable item)
	{
		return default(bool);
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x00009120 File Offset: 0x00007320
	[Token(Token = "0x600133D")]
	[Address(RVA = "0x74B0D0", Offset = "0x74A0D0", VA = "0x18074B0D0")]
	private bool <OnRewarded>b__87_0(SyncDiskPreset item)
	{
		return default(bool);
	}

	// Token: 0x0600133E RID: 4926 RVA: 0x00009138 File Offset: 0x00007338
	[Token(Token = "0x600133E")]
	[Address(RVA = "0x74A6A0", Offset = "0x7496A0", VA = "0x18074A6A0")]
	private bool <GenerateResolveQuestions>b__100_0(SideMissionHandInPreset item)
	{
		return default(bool);
	}

	// Token: 0x0600133F RID: 4927 RVA: 0x00009150 File Offset: 0x00007350
	[Token(Token = "0x600133F")]
	[Address(RVA = "0x74A740", Offset = "0x749740", VA = "0x18074A740")]
	private bool <GenerateResolveQuestions>b__100_1(SideMissionIntroPreset item)
	{
		return default(bool);
	}

	// Token: 0x06001340 RID: 4928 RVA: 0x00009168 File Offset: 0x00007368
	[Token(Token = "0x6001340")]
	[Address(RVA = "0x74B140", Offset = "0x74A140", VA = "0x18074B140")]
	private bool <UpdateResolveAnswers>b__105_1(SceneRecorder.ActorCapture item)
	{
		return default(bool);
	}

	// Token: 0x06001341 RID: 4929 RVA: 0x00009180 File Offset: 0x00007380
	[Token(Token = "0x6001341")]
	[Address(RVA = "0x74B170", Offset = "0x74A170", VA = "0x18074B170")]
	private bool <UpdateResolveAnswers>b__105_3(SceneRecorder.ActorCapture item)
	{
		return default(bool);
	}

	// Token: 0x06001342 RID: 4930 RVA: 0x00009198 File Offset: 0x00007398
	[Token(Token = "0x6001342")]
	[Address(RVA = "0x74B1A0", Offset = "0x74A1A0", VA = "0x18074B1A0")]
	private bool <UpdateResolveAnswers>b__105_5(SceneRecorder.ActorCapture item)
	{
		return default(bool);
	}

	// Token: 0x0400178A RID: 6026
	[Token(Token = "0x400178A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string presetStr;

	// Token: 0x0400178B RID: 6027
	[Token(Token = "0x400178B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string motiveStr;

	// Token: 0x0400178C RID: 6028
	[Token(Token = "0x400178C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int jobID;

	// Token: 0x0400178D RID: 6029
	[Token(Token = "0x400178D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int assignJobID;

	// Token: 0x0400178E RID: 6030
	[Token(Token = "0x400178E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public SideJob.JobState state;

	// Token: 0x0400178F RID: 6031
	[Token(Token = "0x400178F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool postImmediately;

	// Token: 0x04001790 RID: 6032
	[Token(Token = "0x4001790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int startingScenario;

	// Token: 0x04001791 RID: 6033
	[Token(Token = "0x4001791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string intro;

	// Token: 0x04001792 RID: 6034
	[Token(Token = "0x4001792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string handIn;

	// Token: 0x04001793 RID: 6035
	[Token(Token = "0x4001793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool accepted;

	// Token: 0x04001794 RID: 6036
	[Token(Token = "0x4001794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int caseID;

	// Token: 0x04001795 RID: 6037
	[Token(Token = "0x4001795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int phase;

	// Token: 0x04001796 RID: 6038
	[Token(Token = "0x4001796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int postID;

	// Token: 0x04001797 RID: 6039
	[Token(Token = "0x4001797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int gooseChasePhone;

	// Token: 0x04001798 RID: 6040
	[Token(Token = "0x4001798")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int gooseChaseFromPhone;

	// Token: 0x04001799 RID: 6041
	[Token(Token = "0x4001799")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool knowHandInLocation;

	// Token: 0x0400179A RID: 6042
	[Token(Token = "0x400179A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float gooseChaseCallTime;

	// Token: 0x0400179B RID: 6043
	[Token(Token = "0x400179B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool gooseChaseCallTriggered;

	// Token: 0x0400179C RID: 6044
	[Token(Token = "0x400179C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int meetingPoint;

	// Token: 0x0400179D RID: 6045
	[Token(Token = "0x400179D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int meetingConsumableIndex;

	// Token: 0x0400179E RID: 6046
	[Token(Token = "0x400179E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int secretLocationFurniture;

	// Token: 0x0400179F RID: 6047
	[Token(Token = "0x400179F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector3Int secretLocationNode;

	// Token: 0x040017A0 RID: 6048
	[Token(Token = "0x40017A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool failed;

	// Token: 0x040017A1 RID: 6049
	[Token(Token = "0x40017A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<Case.ResolveQuestion> resolveQuestions;

	// Token: 0x040017A2 RID: 6050
	[Token(Token = "0x40017A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public int posterID;

	// Token: 0x040017A3 RID: 6051
	[Token(Token = "0x40017A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public int purpID;

	// Token: 0x040017A4 RID: 6052
	[Token(Token = "0x40017A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int reward;

	// Token: 0x040017A5 RID: 6053
	[Token(Token = "0x40017A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string rewardSyncDisk;

	// Token: 0x040017A6 RID: 6054
	[Token(Token = "0x40017A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public int fakeNumber;

	// Token: 0x040017A7 RID: 6055
	[Token(Token = "0x40017A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public string fakeNumberStr;

	// Token: 0x040017A8 RID: 6056
	[Token(Token = "0x40017A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public string jobInfoDialogMsg;

	// Token: 0x040017A9 RID: 6057
	[Token(Token = "0x40017A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<JobPreset.BasicLeadPool> appliedBasicLeads;

	// Token: 0x040017AA RID: 6058
	[Token(Token = "0x40017AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<Evidence.DataKey> leadKeys;

	// Token: 0x040017AB RID: 6059
	[Token(Token = "0x40017AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<SideJob.ConfineLocation> confine;

	// Token: 0x040017AC RID: 6060
	[Token(Token = "0x40017AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public List<SideJob.AddedDialog> dialog;

	// Token: 0x040017AD RID: 6061
	[Token(Token = "0x40017AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[NonSerialized]
	public int phaseChange;

	// Token: 0x040017AE RID: 6062
	[Token(Token = "0x40017AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[NonSerialized]
	public JobPreset preset;

	// Token: 0x040017AF RID: 6063
	[Token(Token = "0x40017AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[NonSerialized]
	public MotivePreset motive;

	// Token: 0x040017B0 RID: 6064
	[Token(Token = "0x40017B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[NonSerialized]
	private JobPreset.IntroConfig chosenIntro;

	// Token: 0x040017B1 RID: 6065
	[Token(Token = "0x40017B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[NonSerialized]
	private JobPreset.HandInConfig chosenHandIn;

	// Token: 0x040017B2 RID: 6066
	[Token(Token = "0x40017B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[NonSerialized]
	public Human poster;

	// Token: 0x040017B3 RID: 6067
	[Token(Token = "0x40017B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[NonSerialized]
	public Human purp;

	// Token: 0x040017B4 RID: 6068
	[Token(Token = "0x40017B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[NonSerialized]
	public Interactable post;

	// Token: 0x040017B5 RID: 6069
	[Token(Token = "0x40017B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[NonSerialized]
	public Dictionary<JobPreset.JobTag, Interactable> activeJobItems;

	// Token: 0x040017B6 RID: 6070
	[Token(Token = "0x40017B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[NonSerialized]
	public Case thisCase;

	// Token: 0x040017B7 RID: 6071
	[Token(Token = "0x40017B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[NonSerialized]
	public Dictionary<string, List<Objective>> objectiveReference;

	// Token: 0x040017B8 RID: 6072
	[Token(Token = "0x40017B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[NonSerialized]
	public Interactable hiddenItemPhoto;

	// Token: 0x040017B9 RID: 6073
	[Token(Token = "0x40017B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[NonSerialized]
	public Interactable chosenGooseChasePhone;

	// Token: 0x040017BA RID: 6074
	[Token(Token = "0x40017BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[NonSerialized]
	public Interactable chosenMeetingPoint;

	// Token: 0x040017BB RID: 6075
	[Token(Token = "0x40017BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[NonSerialized]
	public TelephoneController.PhoneCall gooseChaseCall;

	// Token: 0x040017BC RID: 6076
	[Token(Token = "0x40017BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[NonSerialized]
	private SideMissionIntroPreset.SideMissionObjectiveBlock currentBlock;

	// Token: 0x040017BD RID: 6077
	[Token(Token = "0x40017BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[NonSerialized]
	private bool triggerHandIn;

	// Token: 0x02000347 RID: 839
	[Token(Token = "0x2000347")]
	public enum JobState
	{
		// Token: 0x040017C1 RID: 6081
		[Token(Token = "0x40017C1")]
		generated,
		// Token: 0x040017C2 RID: 6082
		[Token(Token = "0x40017C2")]
		posted,
		// Token: 0x040017C3 RID: 6083
		[Token(Token = "0x40017C3")]
		ended
	}

	// Token: 0x02000348 RID: 840
	[Token(Token = "0x2000348")]
	[Serializable]
	public class AddedDialog
	{
		// Token: 0x06001343 RID: 4931 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001343")]
		[Address(RVA = "0x791830", Offset = "0x790830", VA = "0x180791830")]
		public Human GetHuman()
		{
			return null;
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001344")]
		[Address(RVA = "0x7918B0", Offset = "0x7908B0", VA = "0x1807918B0")]
		public DialogPreset GetDialog()
		{
			return null;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001345")]
		[Address(RVA = "0x7919A0", Offset = "0x7909A0", VA = "0x1807919A0")]
		public NewRoom GetRoom()
		{
			return null;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001346")]
		[Address(RVA = "0x791A40", Offset = "0x790A40", VA = "0x180791A40")]
		public AddedDialog()
		{
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x000091B0 File Offset: 0x000073B0
		[Token(Token = "0x6001347")]
		[Address(RVA = "0x791A50", Offset = "0x790A50", VA = "0x180791A50")]
		private bool <GetDialog>b__6_0(DialogPreset item)
		{
			return default(bool);
		}

		// Token: 0x040017C4 RID: 6084
		[Token(Token = "0x40017C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int humanID;

		// Token: 0x040017C5 RID: 6085
		[Token(Token = "0x40017C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string dialogRef;

		// Token: 0x040017C6 RID: 6086
		[Token(Token = "0x40017C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int roomID;

		// Token: 0x040017C7 RID: 6087
		[Token(Token = "0x40017C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Evidence.DataKey key;

		// Token: 0x040017C8 RID: 6088
		[Token(Token = "0x40017C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public EvidenceWitness.DialogOption option;
	}

	// Token: 0x02000349 RID: 841
	[Token(Token = "0x2000349")]
	[Serializable]
	public class ConfineLocation
	{
		// Token: 0x06001348 RID: 4936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001348")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ConfineLocation()
		{
		}

		// Token: 0x040017C9 RID: 6089
		[Token(Token = "0x40017C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040017CA RID: 6090
		[Token(Token = "0x40017CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int address;
	}

	// Token: 0x0200034A RID: 842
	// (Invoke) Token: 0x0600134A RID: 4938
	[Token(Token = "0x200034A")]
	public delegate void ObjectivesChange();

	// Token: 0x0200034B RID: 843
	// (Invoke) Token: 0x0600134E RID: 4942
	[Token(Token = "0x200034B")]
	public delegate void AcquireJobInfo();

	// Token: 0x0200034C RID: 844
	[Token(Token = "0x200034C")]
	private sealed class <>c__DisplayClass67_0
	{
		// Token: 0x06001351 RID: 4945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001351")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass67_0()
		{
		}

		// Token: 0x040017CB RID: 6091
		[Token(Token = "0x40017CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SideJob <>4__this;

		// Token: 0x040017CC RID: 6092
		[Token(Token = "0x40017CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<JobPreset.StartingSpawnItem> successsfullySpawned;
	}

	// Token: 0x0200034D RID: 845
	[Token(Token = "0x200034D")]
	private sealed class <>c__DisplayClass67_1
	{
		// Token: 0x06001352 RID: 4946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001352")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass67_1()
		{
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x000091C8 File Offset: 0x000073C8
		[Token(Token = "0x6001353")]
		[Address(RVA = "0x791AF0", Offset = "0x790AF0", VA = "0x180791AF0")]
		internal bool <SpawnItems>b__0(JobPreset.StartingSpawnItem item)
		{
			return default(bool);
		}

		// Token: 0x040017CD RID: 6093
		[Token(Token = "0x40017CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public JobPreset.StartingSpawnItem spawn;

		// Token: 0x040017CE RID: 6094
		[Token(Token = "0x40017CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SideJob.<>c__DisplayClass67_0 CS$<>8__locals1;
	}

	// Token: 0x0200034E RID: 846
	[Token(Token = "0x200034E")]
	private sealed class <>c__DisplayClass68_0
	{
		// Token: 0x06001354 RID: 4948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001354")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass68_0()
		{
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x000091E0 File Offset: 0x000073E0
		[Token(Token = "0x6001355")]
		[Address(RVA = "0x791B50", Offset = "0x790B50", VA = "0x180791B50")]
		internal bool <SpawnItemIsValid>b__0(JobPreset.StartingSpawnItem item)
		{
			return default(bool);
		}

		// Token: 0x040017CF RID: 6095
		[Token(Token = "0x40017CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public JobPreset.StartingSpawnItem spawn;
	}

	// Token: 0x0200034F RID: 847
	[Token(Token = "0x200034F")]
	private sealed class <>c__DisplayClass68_1
	{
		// Token: 0x06001356 RID: 4950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001356")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass68_1()
		{
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x000091F8 File Offset: 0x000073F8
		[Token(Token = "0x6001357")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <SpawnItemIsValid>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040017D0 RID: 6096
		[Token(Token = "0x40017D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000350 RID: 848
	[Token(Token = "0x2000350")]
	private sealed class <>c__DisplayClass68_2
	{
		// Token: 0x06001358 RID: 4952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001358")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass68_2()
		{
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00009210 File Offset: 0x00007410
		[Token(Token = "0x6001359")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <SpawnItemIsValid>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040017D1 RID: 6097
		[Token(Token = "0x40017D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000351 RID: 849
	[Token(Token = "0x2000351")]
	private sealed class <>c__DisplayClass68_3
	{
		// Token: 0x0600135A RID: 4954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass68_3()
		{
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00009228 File Offset: 0x00007428
		[Token(Token = "0x600135B")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <SpawnItemIsValid>b__3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040017D2 RID: 6098
		[Token(Token = "0x40017D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000352 RID: 850
	[Token(Token = "0x2000352")]
	private sealed class <>c__DisplayClass68_4
	{
		// Token: 0x0600135C RID: 4956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass68_4()
		{
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00009240 File Offset: 0x00007440
		[Token(Token = "0x600135D")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <SpawnItemIsValid>b__4(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040017D3 RID: 6099
		[Token(Token = "0x40017D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x02000353 RID: 851
	[Token(Token = "0x2000353")]
	private sealed class <>c__DisplayClass71_0
	{
		// Token: 0x0600135E RID: 4958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass71_0()
		{
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00009258 File Offset: 0x00007458
		[Token(Token = "0x600135F")]
		[Address(RVA = "0x64F390", Offset = "0x64E390", VA = "0x18064F390")]
		internal bool <GetGameLocationFromQuestionInput>b__1(NewGameLocation item)
		{
			return default(bool);
		}

		// Token: 0x040017D4 RID: 6100
		[Token(Token = "0x40017D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Case.ResolveQuestion addressQuestion;
	}

	// Token: 0x02000354 RID: 852
	[Token(Token = "0x2000354")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001361 RID: 4961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001361")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00009270 File Offset: 0x00007470
		[Token(Token = "0x6001362")]
		[Address(RVA = "0x64F2A0", Offset = "0x64E2A0", VA = "0x18064F2A0")]
		internal bool <GetGameLocationFromQuestionInput>b__71_0(Case.ResolveQuestion item)
		{
			return default(bool);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00009288 File Offset: 0x00007488
		[Token(Token = "0x6001363")]
		[Address(RVA = "0x64F2C0", Offset = "0x64E2C0", VA = "0x18064F2C0")]
		internal bool <GetCitizenFromQuestionInput>b__72_0(Case.ResolveQuestion item)
		{
			return default(bool);
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x000092A0 File Offset: 0x000074A0
		[Token(Token = "0x6001364")]
		[Address(RVA = "0x791C30", Offset = "0x790C30", VA = "0x180791C30")]
		internal bool <ObjectiveStateLoop>b__73_7(Occupation item)
		{
			return default(bool);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x000092B8 File Offset: 0x000074B8
		[Token(Token = "0x6001365")]
		[Address(RVA = "0x791D60", Offset = "0x790D60", VA = "0x180791D60")]
		internal bool <ObjectiveStateLoop>b__73_2(SideJobController.JobTracking item)
		{
			return default(bool);
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x000092D0 File Offset: 0x000074D0
		[Token(Token = "0x6001366")]
		[Address(RVA = "0x791DF0", Offset = "0x790DF0", VA = "0x180791DF0")]
		internal bool <ObjectiveStateLoop>b__73_8(Telephone item)
		{
			return default(bool);
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x000092E8 File Offset: 0x000074E8
		[Token(Token = "0x6001367")]
		[Address(RVA = "0x481280", Offset = "0x480280", VA = "0x180481280")]
		internal bool <FindExisting>b__82_0(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00009300 File Offset: 0x00007500
		[Token(Token = "0x6001368")]
		[Address(RVA = "0x792040", Offset = "0x791040", VA = "0x180792040")]
		internal bool <FindExisting>b__82_1(Interactable.Passed item)
		{
			return default(bool);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x00009318 File Offset: 0x00007518
		[Token(Token = "0x6001369")]
		[Address(RVA = "0x792060", Offset = "0x791060", VA = "0x180792060")]
		internal bool <OnRewarded>b__87_1(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00009330 File Offset: 0x00007530
		[Token(Token = "0x600136A")]
		[Address(RVA = "0x7920F0", Offset = "0x7910F0", VA = "0x1807920F0")]
		internal bool <PostJob>b__88_0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00009348 File Offset: 0x00007548
		[Token(Token = "0x600136B")]
		[Address(RVA = "0x7920F0", Offset = "0x7910F0", VA = "0x1807920F0")]
		internal bool <PostJob>b__88_1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00009360 File Offset: 0x00007560
		[Token(Token = "0x600136C")]
		[Address(RVA = "0x790090", Offset = "0x78F090", VA = "0x180790090")]
		internal bool <OnAcquireJobInfo>b__94_0(AIActionPreset.AISpeechPreset item)
		{
			return default(bool);
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00009378 File Offset: 0x00007578
		[Token(Token = "0x600136D")]
		[Address(RVA = "0x792110", Offset = "0x791110", VA = "0x180792110")]
		internal bool <PickPoolLeadOptions>b__97_0(GroupsController.SocialGroup item)
		{
			return default(bool);
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00009390 File Offset: 0x00007590
		[Token(Token = "0x600136E")]
		[Address(RVA = "0x792110", Offset = "0x791110", VA = "0x180792110")]
		internal bool <PickPoolLeadOptions>b__97_1(GroupsController.SocialGroup item)
		{
			return default(bool);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x000093A8 File Offset: 0x000075A8
		[Token(Token = "0x600136F")]
		[Address(RVA = "0x792140", Offset = "0x791140", VA = "0x180792140")]
		internal bool <PickPoolLeadOptions>b__97_2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x000093C0 File Offset: 0x000075C0
		[Token(Token = "0x6001370")]
		[Address(RVA = "0x792170", Offset = "0x791170", VA = "0x180792170")]
		internal bool <PickPoolLeadOptions>b__97_3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x000093D8 File Offset: 0x000075D8
		[Token(Token = "0x6001371")]
		[Address(RVA = "0x7921A0", Offset = "0x7911A0", VA = "0x1807921A0")]
		internal bool <PickPoolLeadOptions>b__97_4(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x000093F0 File Offset: 0x000075F0
		[Token(Token = "0x6001372")]
		[Address(RVA = "0x792300", Offset = "0x791300", VA = "0x180792300")]
		internal bool <PickPoolLeadOptions>b__97_5(JobPreset.BasicLeadPool item)
		{
			return default(bool);
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00009408 File Offset: 0x00007608
		[Token(Token = "0x6001373")]
		[Address(RVA = "0x792320", Offset = "0x791320", VA = "0x180792320")]
		internal bool <GetRevengeObjective>b__101_0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00009420 File Offset: 0x00007620
		[Token(Token = "0x6001374")]
		[Address(RVA = "0x792340", Offset = "0x791340", VA = "0x180792340")]
		internal bool <GetGameLocation>b__102_0(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00009438 File Offset: 0x00007638
		[Token(Token = "0x6001375")]
		[Address(RVA = "0x792340", Offset = "0x791340", VA = "0x180792340")]
		internal bool <GetGameLocation>b__102_2(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00009450 File Offset: 0x00007650
		[Token(Token = "0x6001376")]
		[Address(RVA = "0x792340", Offset = "0x791340", VA = "0x180792340")]
		internal bool <GetGameLocation>b__102_4(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x6001377")]
		[Address(RVA = "0x792340", Offset = "0x791340", VA = "0x180792340")]
		internal bool <GetGameLocation>b__102_6(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00009480 File Offset: 0x00007680
		[Token(Token = "0x6001378")]
		[Address(RVA = "0x792340", Offset = "0x791340", VA = "0x180792340")]
		internal bool <GetGameLocation>b__102_8(FurniturePreset.SubObject item)
		{
			return default(bool);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00009498 File Offset: 0x00007698
		[Token(Token = "0x6001379")]
		[Address(RVA = "0x7923E0", Offset = "0x7913E0", VA = "0x1807923E0")]
		internal bool <UpdateResolveAnswers>b__105_0(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x000094B0 File Offset: 0x000076B0
		[Token(Token = "0x600137A")]
		[Address(RVA = "0x7923E0", Offset = "0x7913E0", VA = "0x1807923E0")]
		internal bool <UpdateResolveAnswers>b__105_2(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x000094C8 File Offset: 0x000076C8
		[Token(Token = "0x600137B")]
		[Address(RVA = "0x7923E0", Offset = "0x7913E0", VA = "0x1807923E0")]
		internal bool <UpdateResolveAnswers>b__105_4(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x040017D5 RID: 6101
		[Token(Token = "0x40017D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SideJob.<>c <>9;

		// Token: 0x040017D6 RID: 6102
		[Token(Token = "0x40017D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Case.ResolveQuestion> <>9__71_0;

		// Token: 0x040017D7 RID: 6103
		[Token(Token = "0x40017D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<Case.ResolveQuestion> <>9__72_0;

		// Token: 0x040017D8 RID: 6104
		[Token(Token = "0x40017D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<Occupation> <>9__73_7;

		// Token: 0x040017D9 RID: 6105
		[Token(Token = "0x40017D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<SideJobController.JobTracking> <>9__73_2;

		// Token: 0x040017DA RID: 6106
		[Token(Token = "0x40017DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<Telephone> <>9__73_8;

		// Token: 0x040017DB RID: 6107
		[Token(Token = "0x40017DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<Interactable.Passed> <>9__82_0;

		// Token: 0x040017DC RID: 6108
		[Token(Token = "0x40017DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Predicate<Interactable.Passed> <>9__82_1;

		// Token: 0x040017DD RID: 6109
		[Token(Token = "0x40017DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Predicate<FurniturePreset.SubObject> <>9__87_1;

		// Token: 0x040017DE RID: 6110
		[Token(Token = "0x40017DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Predicate<Interactable> <>9__88_0;

		// Token: 0x040017DF RID: 6111
		[Token(Token = "0x40017DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Predicate<Interactable> <>9__88_1;

		// Token: 0x040017E0 RID: 6112
		[Token(Token = "0x40017E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Predicate<AIActionPreset.AISpeechPreset> <>9__94_0;

		// Token: 0x040017E1 RID: 6113
		[Token(Token = "0x40017E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Predicate<GroupsController.SocialGroup> <>9__97_0;

		// Token: 0x040017E2 RID: 6114
		[Token(Token = "0x40017E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Predicate<GroupsController.SocialGroup> <>9__97_1;

		// Token: 0x040017E3 RID: 6115
		[Token(Token = "0x40017E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static Predicate<Human.Trait> <>9__97_2;

		// Token: 0x040017E4 RID: 6116
		[Token(Token = "0x40017E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static Predicate<Human.Trait> <>9__97_3;

		// Token: 0x040017E5 RID: 6117
		[Token(Token = "0x40017E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static Predicate<Human.Trait> <>9__97_4;

		// Token: 0x040017E6 RID: 6118
		[Token(Token = "0x40017E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static Predicate<JobPreset.BasicLeadPool> <>9__97_5;

		// Token: 0x040017E7 RID: 6119
		[Token(Token = "0x40017E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static Predicate<NewNode.NodeAccess> <>9__101_0;

		// Token: 0x040017E8 RID: 6120
		[Token(Token = "0x40017E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static Predicate<FurniturePreset.SubObject> <>9__102_0;

		// Token: 0x040017E9 RID: 6121
		[Token(Token = "0x40017E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static Predicate<FurniturePreset.SubObject> <>9__102_2;

		// Token: 0x040017EA RID: 6122
		[Token(Token = "0x40017EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static Predicate<FurniturePreset.SubObject> <>9__102_4;

		// Token: 0x040017EB RID: 6123
		[Token(Token = "0x40017EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public static Predicate<FurniturePreset.SubObject> <>9__102_6;

		// Token: 0x040017EC RID: 6124
		[Token(Token = "0x40017EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static Predicate<FurniturePreset.SubObject> <>9__102_8;

		// Token: 0x040017ED RID: 6125
		[Token(Token = "0x40017ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public static Predicate<Interactable> <>9__105_0;

		// Token: 0x040017EE RID: 6126
		[Token(Token = "0x40017EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public static Predicate<Interactable> <>9__105_2;

		// Token: 0x040017EF RID: 6127
		[Token(Token = "0x40017EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static Predicate<Interactable> <>9__105_4;
	}

	// Token: 0x02000355 RID: 853
	[Token(Token = "0x2000355")]
	private sealed class <>c__DisplayClass72_0
	{
		// Token: 0x0600137C RID: 4988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass72_0()
		{
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x000094E0 File Offset: 0x000076E0
		[Token(Token = "0x600137D")]
		[Address(RVA = "0x64F440", Offset = "0x64E440", VA = "0x18064F440")]
		internal bool <GetCitizenFromQuestionInput>b__1(Citizen item)
		{
			return default(bool);
		}

		// Token: 0x040017F0 RID: 6128
		[Token(Token = "0x40017F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Case.ResolveQuestion citizenQuestion;
	}

	// Token: 0x02000356 RID: 854
	[Token(Token = "0x2000356")]
	private sealed class <>c__DisplayClass74_0
	{
		// Token: 0x0600137E RID: 4990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass74_0()
		{
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x000094F8 File Offset: 0x000076F8
		[Token(Token = "0x600137F")]
		[Address(RVA = "0x792490", Offset = "0x791490", VA = "0x180792490")]
		internal bool <GenerateHidingLocation>b__0(FurnitureLocation item)
		{
			return default(bool);
		}

		// Token: 0x040017F1 RID: 6129
		[Token(Token = "0x40017F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurnitureLocation f;
	}

	// Token: 0x02000357 RID: 855
	[Token(Token = "0x2000357")]
	private sealed class <>c__DisplayClass87_0
	{
		// Token: 0x06001380 RID: 4992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001380")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass87_0()
		{
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00009510 File Offset: 0x00007710
		[Token(Token = "0x6001381")]
		[Address(RVA = "0x478670", Offset = "0x477670", VA = "0x180478670")]
		internal bool <OnRewarded>b__2(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x040017F2 RID: 6130
		[Token(Token = "0x40017F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurniturePreset.SubObject i;
	}

	// Token: 0x02000358 RID: 856
	[Token(Token = "0x2000358")]
	private sealed class <>c__DisplayClass88_0
	{
		// Token: 0x06001382 RID: 4994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001382")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass88_0()
		{
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00009528 File Offset: 0x00007728
		[Token(Token = "0x6001383")]
		[Address(RVA = "0x478670", Offset = "0x477670", VA = "0x180478670")]
		internal bool <PostJob>b__2(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x040017F3 RID: 6131
		[Token(Token = "0x40017F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FurniturePreset.SubObject so;
	}

	// Token: 0x02000359 RID: 857
	[Token(Token = "0x2000359")]
	private sealed class <>c__DisplayClass100_0
	{
		// Token: 0x06001384 RID: 4996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001384")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass100_0()
		{
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00009540 File Offset: 0x00007740
		[Token(Token = "0x6001385")]
		[Address(RVA = "0x792510", Offset = "0x791510", VA = "0x180792510")]
		internal bool <GenerateResolveQuestions>b__2(UpgradesController.Upgrades item)
		{
			return default(bool);
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00009558 File Offset: 0x00007758
		[Token(Token = "0x6001386")]
		[Address(RVA = "0x792570", Offset = "0x791570", VA = "0x180792570")]
		internal bool <GenerateResolveQuestions>b__3(FirstPersonItemController.InventorySlot item)
		{
			return default(bool);
		}

		// Token: 0x040017F4 RID: 6132
		[Token(Token = "0x40017F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SyncDiskPreset d;
	}

	// Token: 0x0200035A RID: 858
	[Token(Token = "0x200035A")]
	private sealed class <>c__DisplayClass102_0
	{
		// Token: 0x06001387 RID: 4999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001387")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass102_0()
		{
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00009570 File Offset: 0x00007770
		[Token(Token = "0x6001388")]
		[Address(RVA = "0x792610", Offset = "0x791610", VA = "0x180792610")]
		internal bool <GetGameLocation>b__1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x040017F5 RID: 6133
		[Token(Token = "0x40017F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<FurniturePreset.SubObject> subObjs;
	}

	// Token: 0x0200035B RID: 859
	[Token(Token = "0x200035B")]
	private sealed class <>c__DisplayClass102_1
	{
		// Token: 0x06001389 RID: 5001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001389")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass102_1()
		{
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00009588 File Offset: 0x00007788
		[Token(Token = "0x600138A")]
		[Address(RVA = "0x7926B0", Offset = "0x7916B0", VA = "0x1807926B0")]
		internal bool <GetGameLocation>b__3(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x040017F6 RID: 6134
		[Token(Token = "0x40017F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<FurniturePreset.SubObject> subObjs;
	}

	// Token: 0x0200035C RID: 860
	[Token(Token = "0x200035C")]
	private sealed class <>c__DisplayClass102_2
	{
		// Token: 0x0600138B RID: 5003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600138B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass102_2()
		{
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x600138C")]
		[Address(RVA = "0x792750", Offset = "0x791750", VA = "0x180792750")]
		internal bool <GetGameLocation>b__5(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x040017F7 RID: 6135
		[Token(Token = "0x40017F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<FurniturePreset.SubObject> subObjs;
	}

	// Token: 0x0200035D RID: 861
	[Token(Token = "0x200035D")]
	private sealed class <>c__DisplayClass102_3
	{
		// Token: 0x0600138D RID: 5005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600138D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass102_3()
		{
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x000095B8 File Offset: 0x000077B8
		[Token(Token = "0x600138E")]
		[Address(RVA = "0x7927F0", Offset = "0x7917F0", VA = "0x1807927F0")]
		internal bool <GetGameLocation>b__7(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x040017F8 RID: 6136
		[Token(Token = "0x40017F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<FurniturePreset.SubObject> subObjs;
	}

	// Token: 0x0200035E RID: 862
	[Token(Token = "0x200035E")]
	private sealed class <>c__DisplayClass102_4
	{
		// Token: 0x0600138F RID: 5007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600138F")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass102_4()
		{
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x000095D0 File Offset: 0x000077D0
		[Token(Token = "0x6001390")]
		[Address(RVA = "0x792890", Offset = "0x791890", VA = "0x180792890")]
		internal bool <GetGameLocation>b__9(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x040017F9 RID: 6137
		[Token(Token = "0x40017F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<FurniturePreset.SubObject> subObjs;
	}

	// Token: 0x0200035F RID: 863
	[Token(Token = "0x200035F")]
	private sealed class <>c__DisplayClass108_0
	{
		// Token: 0x06001391 RID: 5009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001391")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass108_0()
		{
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x6001392")]
		[Address(RVA = "0x792930", Offset = "0x791930", VA = "0x180792930")]
		internal bool <RemoveConfineLocation>b__0(SideJob.ConfineLocation item)
		{
			return default(bool);
		}

		// Token: 0x040017FA RID: 6138
		[Token(Token = "0x40017FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human who;

		// Token: 0x040017FB RID: 6139
		[Token(Token = "0x40017FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewAddress where;
	}

	// Token: 0x02000360 RID: 864
	[Token(Token = "0x2000360")]
	private sealed class <>c__DisplayClass109_0
	{
		// Token: 0x06001393 RID: 5011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001393")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass109_0()
		{
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00009600 File Offset: 0x00007800
		[Token(Token = "0x6001394")]
		[Address(RVA = "0x792980", Offset = "0x791980", VA = "0x180792980")]
		internal bool <DisplayResolveObjectivesCheck>b__0(SpeechController.QueueElement item)
		{
			return default(bool);
		}

		// Token: 0x040017FC RID: 6140
		[Token(Token = "0x40017FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Case.ResolveQuestion q;
	}
}
