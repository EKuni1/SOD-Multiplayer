using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200026B RID: 619
[Token(Token = "0x200026B")]
[Serializable]
public class Case
{
	// Token: 0x06000DEF RID: 3567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DEF")]
	[Address(RVA = "0x63FA30", Offset = "0x63EA30", VA = "0x18063FA30")]
	public void AddNewStringColour(Evidence.FactLink link, InterfaceControls.EvidenceColours col)
	{
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0x6403E0", Offset = "0x63F3E0", VA = "0x1806403E0")]
	public void SetHidden(Fact fact, bool val)
	{
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0x640D50", Offset = "0x63FD50", VA = "0x180640D50")]
	public void ToggleHidden(Fact fact)
	{
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DF2")]
	[Address(RVA = "0x6416E0", Offset = "0x6406E0", VA = "0x1806416E0")]
	public void SetStatus(Case.CaseStatus newStatus, bool cancelObjectives = true)
	{
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0x642910", Offset = "0x641910", VA = "0x180642910")]
	public void ApplyMonikerToCaseCheck()
	{
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DF4")]
	[Address(RVA = "0x6431A0", Offset = "0x6421A0", VA = "0x1806431A0")]
	public NewGameLocation GetGameLocationFromQuestionInput(Case.ResolveQuestion question)
	{
		return null;
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0x643510", Offset = "0x642510", VA = "0x180643510")]
	public Human GetCitizenFromQuestionInput(Case.ResolveQuestion question)
	{
		return null;
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0x643880", Offset = "0x642880", VA = "0x180643880")]
	public void OnQuestionProgressChange(Case.ResolveQuestion question)
	{
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0x6439F0", Offset = "0x6429F0", VA = "0x1806439F0")]
	public void Resolve()
	{
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x000074D0 File Offset: 0x000056D0
	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0x6459E0", Offset = "0x6449E0", VA = "0x1806459E0")]
	public bool ValidationCheck()
	{
		return default(bool);
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DF9")]
	[Address(RVA = "0x646560", Offset = "0x645560", VA = "0x180646560", Slot = "4")]
	public virtual void AddObjective(string entryRef, Objective.ObjectiveTrigger trigger, bool usePointer = false, [Optional] Vector3 pointerPosition, InterfaceControls.Icon useIcon = InterfaceControls.Icon.lookingGlass, Objective.OnCompleteAction onCompleteAction = Objective.OnCompleteAction.nextChapterPart, float delay = 0f, bool removePrevious = false, string chapterString = "", bool isSilent = false, bool allowCrouchPromt = false, [Optional] SideJob jobRef, bool forceBottomOfList = false, bool ignoreDuplicates = false, bool useParsing = true)
	{
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DFA")]
	[Address(RVA = "0x6474D0", Offset = "0x6464D0", VA = "0x1806474D0")]
	public Case(string newName, Case.CaseType newCaseType, Case.CaseStatus newCaseStatus)
	{
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000DFB")]
	[Address(RVA = "0x647DF0", Offset = "0x646DF0", VA = "0x180647DF0")]
	public Interactable GetClosestHandIn()
	{
		return null;
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DFC")]
	[Address(RVA = "0x648330", Offset = "0x647330", VA = "0x180648330")]
	public void ClearAllObjectives()
	{
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x000074E8 File Offset: 0x000056E8
	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0x648850", Offset = "0x647850", VA = "0x180648850")]
	private bool <ValidationCheck>b__42_0(Case.ResolveQuestion item)
	{
		return default(bool);
	}

	// Token: 0x04000FD8 RID: 4056
	[Token(Token = "0x4000FD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	// Token: 0x04000FD9 RID: 4057
	[Token(Token = "0x4000FD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int id;

	// Token: 0x04000FDA RID: 4058
	[Token(Token = "0x4000FDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int assignCaseID;

	// Token: 0x04000FDB RID: 4059
	[Token(Token = "0x4000FDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Case.CaseType caseType;

	// Token: 0x04000FDC RID: 4060
	[Token(Token = "0x4000FDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Case.CaseStatus caseStatus;

	// Token: 0x04000FDD RID: 4061
	[Token(Token = "0x4000FDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int jobReference;

	// Token: 0x04000FDE RID: 4062
	[Token(Token = "0x4000FDE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string mainStoryChapter;

	// Token: 0x04000FDF RID: 4063
	[Token(Token = "0x4000FDF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Case.CaseElement> caseElements;

	// Token: 0x04000FE0 RID: 4064
	[Token(Token = "0x4000FE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Case.StringColours> stringColours;

	// Token: 0x04000FE1 RID: 4065
	[Token(Token = "0x4000FE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<string> hiddenConnections;

	// Token: 0x04000FE2 RID: 4066
	[Token(Token = "0x4000FE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool isActive;

	// Token: 0x04000FE3 RID: 4067
	[Token(Token = "0x4000FE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool handInValid;

	// Token: 0x04000FE4 RID: 4068
	[Token(Token = "0x4000FE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool isSolved;

	// Token: 0x04000FE5 RID: 4069
	[Token(Token = "0x4000FE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float questionsRank;

	// Token: 0x04000FE6 RID: 4070
	[Token(Token = "0x4000FE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float victimsRank;

	// Token: 0x04000FE7 RID: 4071
	[Token(Token = "0x4000FE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Case.CaseRank rank;

	// Token: 0x04000FE8 RID: 4072
	[Token(Token = "0x4000FE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<Objective> currentActiveObjectives;

	// Token: 0x04000FE9 RID: 4073
	[Token(Token = "0x4000FE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<Objective> inactiveCurrentObjectives;

	// Token: 0x04000FEA RID: 4074
	[Token(Token = "0x4000FEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<Objective> endedObjectives;

	// Token: 0x04000FEB RID: 4075
	[Token(Token = "0x4000FEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<Case.ResolveQuestion> resolveQuestions;

	// Token: 0x04000FEC RID: 4076
	[Token(Token = "0x4000FEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<int> suspectsDetained;

	// Token: 0x04000FED RID: 4077
	[Token(Token = "0x4000FED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<int> handIn;

	// Token: 0x04000FEE RID: 4078
	[Token(Token = "0x4000FEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[NonSerialized]
	public List<Objective> waitForObjectives;

	// Token: 0x04000FEF RID: 4079
	[Token(Token = "0x4000FEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[NonSerialized]
	public SideJob job;

	// Token: 0x0200026C RID: 620
	[Token(Token = "0x200026C")]
	public enum CaseStatus
	{
		// Token: 0x04000FF1 RID: 4081
		[Token(Token = "0x4000FF1")]
		handInNotCollected,
		// Token: 0x04000FF2 RID: 4082
		[Token(Token = "0x4000FF2")]
		handInCollected,
		// Token: 0x04000FF3 RID: 4083
		[Token(Token = "0x4000FF3")]
		submitted,
		// Token: 0x04000FF4 RID: 4084
		[Token(Token = "0x4000FF4")]
		closable,
		// Token: 0x04000FF5 RID: 4085
		[Token(Token = "0x4000FF5")]
		archived,
		// Token: 0x04000FF6 RID: 4086
		[Token(Token = "0x4000FF6")]
		forced
	}

	// Token: 0x0200026D RID: 621
	[Token(Token = "0x200026D")]
	public enum CaseType
	{
		// Token: 0x04000FF8 RID: 4088
		[Token(Token = "0x4000FF8")]
		mainStory,
		// Token: 0x04000FF9 RID: 4089
		[Token(Token = "0x4000FF9")]
		murder,
		// Token: 0x04000FFA RID: 4090
		[Token(Token = "0x4000FFA")]
		sideJob,
		// Token: 0x04000FFB RID: 4091
		[Token(Token = "0x4000FFB")]
		custom,
		// Token: 0x04000FFC RID: 4092
		[Token(Token = "0x4000FFC")]
		retirement
	}

	// Token: 0x0200026E RID: 622
	[Token(Token = "0x200026E")]
	public enum CaseRank
	{
		// Token: 0x04000FFE RID: 4094
		[Token(Token = "0x4000FFE")]
		super,
		// Token: 0x04000FFF RID: 4095
		[Token(Token = "0x4000FFF")]
		A,
		// Token: 0x04001000 RID: 4096
		[Token(Token = "0x4001000")]
		B,
		// Token: 0x04001001 RID: 4097
		[Token(Token = "0x4001001")]
		C,
		// Token: 0x04001002 RID: 4098
		[Token(Token = "0x4001002")]
		D,
		// Token: 0x04001003 RID: 4099
		[Token(Token = "0x4001003")]
		unSolved
	}

	// Token: 0x0200026F RID: 623
	[Token(Token = "0x200026F")]
	[Serializable]
	public class CaseElement
	{
		// Token: 0x06000DFF RID: 3583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFF")]
		[Address(RVA = "0x648890", Offset = "0x647890", VA = "0x180648890")]
		public void SetColour(InterfaceControls.EvidenceColours newColour)
		{
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public CaseElement()
		{
		}

		// Token: 0x04001004 RID: 4100
		[Token(Token = "0x4001004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int caseID;

		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string n;

		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string id;

		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Evidence.DataKey> dk;

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 v;

		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Evidence.DataKey> sdk;

		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool ap;

		// Token: 0x0400100B RID: 4107
		[Token(Token = "0x400100B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool w;

		// Token: 0x0400100C RID: 4108
		[Token(Token = "0x400100C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 resPos;

		// Token: 0x0400100D RID: 4109
		[Token(Token = "0x400100D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector2 resPiv;

		// Token: 0x0400100E RID: 4110
		[Token(Token = "0x400100E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool co;

		// Token: 0x0400100F RID: 4111
		[Token(Token = "0x400100F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool m;

		// Token: 0x04001010 RID: 4112
		[Token(Token = "0x4001010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public InterfaceControls.EvidenceColours color;

		// Token: 0x04001011 RID: 4113
		[Token(Token = "0x4001011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public PinnedItemController pinnedController;
	}

	// Token: 0x02000270 RID: 624
	[Token(Token = "0x2000270")]
	[Serializable]
	public class StringColours
	{
		// Token: 0x06000E01 RID: 3585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public StringColours()
		{
		}

		// Token: 0x04001012 RID: 4114
		[Token(Token = "0x4001012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string fromEv;

		// Token: 0x04001013 RID: 4115
		[Token(Token = "0x4001013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> toEv;

		// Token: 0x04001014 RID: 4116
		[Token(Token = "0x4001014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Evidence.DataKey> fromDK;

		// Token: 0x04001015 RID: 4117
		[Token(Token = "0x4001015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Evidence.DataKey> toDK;

		// Token: 0x04001016 RID: 4118
		[Token(Token = "0x4001016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int colIndex;
	}

	// Token: 0x02000271 RID: 625
	[Token(Token = "0x2000271")]
	[Serializable]
	public class ResolveQuestion
	{
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000E02 RID: 3586 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E03 RID: 3587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000014")]
		public event Case.ResolveQuestion.ProgressChange OnProgressChange
		{
			[Token(Token = "0x6000E02")]
			[Address(RVA = "0x648C30", Offset = "0x647C30", VA = "0x180648C30")]
			add
			{
			}
			[Token(Token = "0x6000E03")]
			[Address(RVA = "0x648D30", Offset = "0x647D30", VA = "0x180648D30")]
			remove
			{
			}
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00007500 File Offset: 0x00005700
		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x648E30", Offset = "0x647E30", VA = "0x180648E30")]
		public bool UpdateCorrect(Case forCase, bool isMainStory = true)
		{
			return default(bool);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00007518 File Offset: 0x00005718
		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x64BBC0", Offset = "0x64ABC0", VA = "0x18064BBC0")]
		public bool UpdateValid(Case forCase)
		{
			return default(bool);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x64DED0", Offset = "0x64CED0", VA = "0x18064DED0")]
		public string GetText(Case belongsToCase, bool includeReward = true, bool includePenalty = true)
		{
			return null;
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x64E5D0", Offset = "0x64D5D0", VA = "0x18064E5D0")]
		public RevengeObjective GetRevengeObjective()
		{
			return null;
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x64E670", Offset = "0x64D670", VA = "0x18064E670")]
		public void SetProgress(float val, bool forceTrigger = false)
		{
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x64E810", Offset = "0x64D810", VA = "0x18064E810")]
		public ResolveQuestion()
		{
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00007530 File Offset: 0x00005730
		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0x64EBC0", Offset = "0x64DBC0", VA = "0x18064EBC0")]
		private bool <UpdateCorrect>b__36_0(Citizen item)
		{
			return default(bool);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00007548 File Offset: 0x00005748
		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0x64EC60", Offset = "0x64DC60", VA = "0x18064EC60")]
		private bool <UpdateCorrect>b__36_1(NewGameLocation item)
		{
			return default(bool);
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00007560 File Offset: 0x00005760
		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x64ED00", Offset = "0x64DD00", VA = "0x18064ED00")]
		private bool <UpdateCorrect>b__36_2(Case.ResolveQuestion item)
		{
			return default(bool);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00007578 File Offset: 0x00005778
		[Token(Token = "0x6000E0D")]
		[Address(RVA = "0x64ED00", Offset = "0x64DD00", VA = "0x18064ED00")]
		private bool <UpdateValid>b__37_1(Case.ResolveQuestion item)
		{
			return default(bool);
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00007590 File Offset: 0x00005790
		[Token(Token = "0x6000E0E")]
		[Address(RVA = "0x64EC60", Offset = "0x64DC60", VA = "0x18064EC60")]
		private bool <UpdateValid>b__37_0(NewGameLocation item)
		{
			return default(bool);
		}

		// Token: 0x04001017 RID: 4119
		[Token(Token = "0x4001017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04001018 RID: 4120
		[Token(Token = "0x4001018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool displayObjective;

		// Token: 0x04001019 RID: 4121
		[Token(Token = "0x4001019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool displayOnlyAtPhase;

		// Token: 0x0400101A RID: 4122
		[Token(Token = "0x400101A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int displayAtPhase;

		// Token: 0x0400101B RID: 4123
		[Token(Token = "0x400101B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float objectiveDelay;

		// Token: 0x0400101C RID: 4124
		[Token(Token = "0x400101C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<SideMissionIntroPreset> onlyCompatibleWithIntros;

		// Token: 0x0400101D RID: 4125
		[Token(Token = "0x400101D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<SideMissionHandInPreset> onlyCompatibleWithHandIns;

		// Token: 0x0400101E RID: 4126
		[Token(Token = "0x400101E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Case.InputType inputType;

		// Token: 0x0400101F RID: 4127
		[Token(Token = "0x400101F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<Case.AutoCorrectAnswer> automaticAnswers;

		// Token: 0x04001020 RID: 4128
		[Token(Token = "0x4001020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public JobPreset.JobTag tag;

		// Token: 0x04001021 RID: 4129
		[Token(Token = "0x4001021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public InterfaceControls.Icon icon;

		// Token: 0x04001022 RID: 4130
		[Token(Token = "0x4001022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector2 rewardRange;

		// Token: 0x04001023 RID: 4131
		[Token(Token = "0x4001023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector2 penaltyRange;

		// Token: 0x04001024 RID: 4132
		[Token(Token = "0x4001024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool isOptional;

		// Token: 0x04001025 RID: 4133
		[Token(Token = "0x4001025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool useAlternateName;

		// Token: 0x04001026 RID: 4134
		[Token(Token = "0x4001026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Case.RevengeObjectiveName useName;

		// Token: 0x04001027 RID: 4135
		[Token(Token = "0x4001027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public JobPreset.LeadCitizen target;

		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public JobPreset.JobSpawnWhere location;

		// Token: 0x04001029 RID: 4137
		[Token(Token = "0x4001029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string revengeObjective;

		// Token: 0x0400102A RID: 4138
		[Token(Token = "0x400102A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int revengeObjTarget;

		// Token: 0x0400102B RID: 4139
		[Token(Token = "0x400102B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int revengeObjLoc;

		// Token: 0x0400102C RID: 4140
		[Token(Token = "0x400102C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float revengeObjPassed;

		// Token: 0x0400102D RID: 4141
		[Token(Token = "0x400102D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool completedRevenge;

		// Token: 0x0400102E RID: 4142
		[Token(Token = "0x400102E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string input;

		// Token: 0x0400102F RID: 4143
		[Token(Token = "0x400102F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string inputtedEvidence;

		// Token: 0x04001030 RID: 4144
		[Token(Token = "0x4001030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<string> correctAnswers;

		// Token: 0x04001031 RID: 4145
		[Token(Token = "0x4001031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float progress;

		// Token: 0x04001032 RID: 4146
		[Token(Token = "0x4001032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int reward;

		// Token: 0x04001033 RID: 4147
		[Token(Token = "0x4001033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int penalty;

		// Token: 0x04001034 RID: 4148
		[Token(Token = "0x4001034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool isValid;

		// Token: 0x04001035 RID: 4149
		[Token(Token = "0x4001035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		public bool isCorrect;

		// Token: 0x04001036 RID: 4150
		[Token(Token = "0x4001036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		public InputFieldController inputField;

		// Token: 0x02000272 RID: 626
		// (Invoke) Token: 0x06000E10 RID: 3600
		[Token(Token = "0x2000272")]
		public delegate void ProgressChange(Case.ResolveQuestion resolve);

		// Token: 0x02000273 RID: 627
		[Token(Token = "0x2000273")]
		private sealed class <>c__DisplayClass37_0
		{
			// Token: 0x06000E13 RID: 3603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E13")]
			[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
			public <>c__DisplayClass37_0()
			{
			}

			// Token: 0x06000E14 RID: 3604 RVA: 0x000075A8 File Offset: 0x000057A8
			[Token(Token = "0x6000E14")]
			[Address(RVA = "0x64ED90", Offset = "0x64DD90", VA = "0x18064ED90")]
			internal bool <UpdateValid>b__2(Citizen item)
			{
				return default(bool);
			}

			// Token: 0x04001038 RID: 4152
			[Token(Token = "0x4001038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Case.ResolveQuestion getQ;
		}
	}

	// Token: 0x02000274 RID: 628
	[Token(Token = "0x2000274")]
	public enum RevengeObjectiveName
	{
		// Token: 0x0400103A RID: 4154
		[Token(Token = "0x400103A")]
		D0,
		// Token: 0x0400103B RID: 4155
		[Token(Token = "0x400103B")]
		D1,
		// Token: 0x0400103C RID: 4156
		[Token(Token = "0x400103C")]
		IDTarget
	}

	// Token: 0x02000275 RID: 629
	[Token(Token = "0x2000275")]
	public enum AutoCorrectAnswer
	{
		// Token: 0x0400103E RID: 4158
		[Token(Token = "0x400103E")]
		none,
		// Token: 0x0400103F RID: 4159
		[Token(Token = "0x400103F")]
		poster,
		// Token: 0x04001040 RID: 4160
		[Token(Token = "0x4001040")]
		purp,
		// Token: 0x04001041 RID: 4161
		[Token(Token = "0x4001041")]
		purpsParamour,
		// Token: 0x04001042 RID: 4162
		[Token(Token = "0x4001042")]
		posterHome,
		// Token: 0x04001043 RID: 4163
		[Token(Token = "0x4001043")]
		purpHome,
		// Token: 0x04001044 RID: 4164
		[Token(Token = "0x4001044")]
		purpsParamourHome,
		// Token: 0x04001045 RID: 4165
		[Token(Token = "0x4001045")]
		posterWork,
		// Token: 0x04001046 RID: 4166
		[Token(Token = "0x4001046")]
		purpWork,
		// Token: 0x04001047 RID: 4167
		[Token(Token = "0x4001047")]
		purpsParamourWork,
		// Token: 0x04001048 RID: 4168
		[Token(Token = "0x4001048")]
		posterPhoto,
		// Token: 0x04001049 RID: 4169
		[Token(Token = "0x4001049")]
		purpPhoto,
		// Token: 0x0400104A RID: 4170
		[Token(Token = "0x400104A")]
		purpsParamourPhoto,
		// Token: 0x0400104B RID: 4171
		[Token(Token = "0x400104B")]
		posterHomePhoto,
		// Token: 0x0400104C RID: 4172
		[Token(Token = "0x400104C")]
		purpHomePhoto,
		// Token: 0x0400104D RID: 4173
		[Token(Token = "0x400104D")]
		purpsParamourHomePhoto,
		// Token: 0x0400104E RID: 4174
		[Token(Token = "0x400104E")]
		posterWorkPhoto,
		// Token: 0x0400104F RID: 4175
		[Token(Token = "0x400104F")]
		purpWorkPhoto,
		// Token: 0x04001050 RID: 4176
		[Token(Token = "0x4001050")]
		purpsParamourWorkPhoto,
		// Token: 0x04001051 RID: 4177
		[Token(Token = "0x4001051")]
		spawnedItemA,
		// Token: 0x04001052 RID: 4178
		[Token(Token = "0x4001052")]
		spawnedItemB,
		// Token: 0x04001053 RID: 4179
		[Token(Token = "0x4001053")]
		spawnedItemC,
		// Token: 0x04001054 RID: 4180
		[Token(Token = "0x4001054")]
		spawnedItemD,
		// Token: 0x04001055 RID: 4181
		[Token(Token = "0x4001055")]
		spawnedItemE,
		// Token: 0x04001056 RID: 4182
		[Token(Token = "0x4001056")]
		spawnedItemF,
		// Token: 0x04001057 RID: 4183
		[Token(Token = "0x4001057")]
		spawnedItemTag
	}

	// Token: 0x02000276 RID: 630
	[Token(Token = "0x2000276")]
	public enum InputType
	{
		// Token: 0x04001059 RID: 4185
		[Token(Token = "0x4001059")]
		citizen,
		// Token: 0x0400105A RID: 4186
		[Token(Token = "0x400105A")]
		location,
		// Token: 0x0400105B RID: 4187
		[Token(Token = "0x400105B")]
		item,
		// Token: 0x0400105C RID: 4188
		[Token(Token = "0x400105C")]
		revengeObjective,
		// Token: 0x0400105D RID: 4189
		[Token(Token = "0x400105D")]
		objective,
		// Token: 0x0400105E RID: 4190
		[Token(Token = "0x400105E")]
		arrestPurp,
		// Token: 0x0400105F RID: 4191
		[Token(Token = "0x400105F")]
		saveVictim
	}

	// Token: 0x02000277 RID: 631
	[Token(Token = "0x2000277")]
	private sealed class <>c__DisplayClass34_0
	{
		// Token: 0x06000E15 RID: 3605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E15")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass34_0()
		{
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x000075C0 File Offset: 0x000057C0
		[Token(Token = "0x6000E16")]
		[Address(RVA = "0x64EF40", Offset = "0x64DF40", VA = "0x18064EF40")]
		internal bool <SetHidden>b__0(StringController item)
		{
			return default(bool);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000075D8 File Offset: 0x000057D8
		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x64EFE0", Offset = "0x64DFE0", VA = "0x18064EFE0")]
		internal bool <SetHidden>b__1(FactButtonController item)
		{
			return default(bool);
		}

		// Token: 0x04001060 RID: 4192
		[Token(Token = "0x4001060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Fact fact;

		// Token: 0x04001061 RID: 4193
		[Token(Token = "0x4001061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<FactButtonController> <>9__1;
	}

	// Token: 0x02000278 RID: 632
	[Token(Token = "0x2000278")]
	private sealed class <>c__DisplayClass35_0
	{
		// Token: 0x06000E18 RID: 3608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass35_0()
		{
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x000075F0 File Offset: 0x000057F0
		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x64F010", Offset = "0x64E010", VA = "0x18064F010")]
		internal bool <ToggleHidden>b__0(StringController item)
		{
			return default(bool);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00007608 File Offset: 0x00005808
		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x64EFE0", Offset = "0x64DFE0", VA = "0x18064EFE0")]
		internal bool <ToggleHidden>b__1(FactButtonController item)
		{
			return default(bool);
		}

		// Token: 0x04001062 RID: 4194
		[Token(Token = "0x4001062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Fact fact;

		// Token: 0x04001063 RID: 4195
		[Token(Token = "0x4001063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Predicate<FactButtonController> <>9__1;
	}

	// Token: 0x02000279 RID: 633
	[Token(Token = "0x2000279")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000E1C RID: 3612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00007620 File Offset: 0x00005820
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x64F160", Offset = "0x64E160", VA = "0x18064F160")]
		internal bool <SetStatus>b__36_1(NewBuilding item)
		{
			return default(bool);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00007638 File Offset: 0x00005838
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x64F210", Offset = "0x64E210", VA = "0x18064F210")]
		internal bool <SetStatus>b__36_0(Objective item)
		{
			return default(bool);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00007650 File Offset: 0x00005850
		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x64F2A0", Offset = "0x64E2A0", VA = "0x18064F2A0")]
		internal bool <GetGameLocationFromQuestionInput>b__38_0(Case.ResolveQuestion item)
		{
			return default(bool);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00007668 File Offset: 0x00005868
		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x64F2C0", Offset = "0x64E2C0", VA = "0x18064F2C0")]
		internal bool <GetCitizenFromQuestionInput>b__39_0(Case.ResolveQuestion item)
		{
			return default(bool);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00007680 File Offset: 0x00005880
		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x64F2E0", Offset = "0x64E2E0", VA = "0x18064F2E0")]
		internal bool <ValidationCheck>b__42_1(Objective item)
		{
			return default(bool);
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00007698 File Offset: 0x00005898
		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x64F370", Offset = "0x64E370", VA = "0x18064F370")]
		internal bool <AddObjective>b__43_3(SpeechController.QueueElement item)
		{
			return default(bool);
		}

		// Token: 0x04001064 RID: 4196
		[Token(Token = "0x4001064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Case.<>c <>9;

		// Token: 0x04001065 RID: 4197
		[Token(Token = "0x4001065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<NewBuilding> <>9__36_1;

		// Token: 0x04001066 RID: 4198
		[Token(Token = "0x4001066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<Objective> <>9__36_0;

		// Token: 0x04001067 RID: 4199
		[Token(Token = "0x4001067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<Case.ResolveQuestion> <>9__38_0;

		// Token: 0x04001068 RID: 4200
		[Token(Token = "0x4001068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<Case.ResolveQuestion> <>9__39_0;

		// Token: 0x04001069 RID: 4201
		[Token(Token = "0x4001069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<Objective> <>9__42_1;

		// Token: 0x0400106A RID: 4202
		[Token(Token = "0x400106A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<SpeechController.QueueElement> <>9__43_3;
	}

	// Token: 0x0200027A RID: 634
	[Token(Token = "0x200027A")]
	private sealed class <>c__DisplayClass38_0
	{
		// Token: 0x06000E23 RID: 3619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E23")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass38_0()
		{
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x6000E24")]
		[Address(RVA = "0x64F390", Offset = "0x64E390", VA = "0x18064F390")]
		internal bool <GetGameLocationFromQuestionInput>b__1(NewGameLocation item)
		{
			return default(bool);
		}

		// Token: 0x0400106B RID: 4203
		[Token(Token = "0x400106B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Case.ResolveQuestion addressQuestion;
	}

	// Token: 0x0200027B RID: 635
	[Token(Token = "0x200027B")]
	private sealed class <>c__DisplayClass39_0
	{
		// Token: 0x06000E25 RID: 3621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass39_0()
		{
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x64F440", Offset = "0x64E440", VA = "0x18064F440")]
		internal bool <GetCitizenFromQuestionInput>b__1(Citizen item)
		{
			return default(bool);
		}

		// Token: 0x0400106C RID: 4204
		[Token(Token = "0x400106C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Case.ResolveQuestion citizenQuestion;
	}

	// Token: 0x0200027C RID: 636
	[Token(Token = "0x200027C")]
	private sealed class <>c__DisplayClass40_0
	{
		// Token: 0x06000E27 RID: 3623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass40_0()
		{
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x64F4F0", Offset = "0x64E4F0", VA = "0x18064F4F0")]
		internal bool <OnQuestionProgressChange>b__0(Objective item)
		{
			return default(bool);
		}

		// Token: 0x0400106D RID: 4205
		[Token(Token = "0x400106D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Case.ResolveQuestion question;
	}

	// Token: 0x0200027D RID: 637
	[Token(Token = "0x200027D")]
	private sealed class <>c__DisplayClass41_0
	{
		// Token: 0x06000E29 RID: 3625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass41_0()
		{
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x000076F8 File Offset: 0x000058F8
		[Token(Token = "0x6000E2A")]
		[Address(RVA = "0x64F560", Offset = "0x64E560", VA = "0x18064F560")]
		internal bool <Resolve>b__0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x0400106E RID: 4206
		[Token(Token = "0x400106E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;
	}

	// Token: 0x0200027E RID: 638
	[Token(Token = "0x200027E")]
	private sealed class <>c__DisplayClass43_0
	{
		// Token: 0x06000E2B RID: 3627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass43_0()
		{
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0x64F580", Offset = "0x64E580", VA = "0x18064F580")]
		internal bool <AddObjective>b__0(Objective item)
		{
			return default(bool);
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00007728 File Offset: 0x00005928
		[Token(Token = "0x6000E2D")]
		[Address(RVA = "0x64F580", Offset = "0x64E580", VA = "0x18064F580")]
		internal bool <AddObjective>b__1(Objective item)
		{
			return default(bool);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x6000E2E")]
		[Address(RVA = "0x64F5F0", Offset = "0x64E5F0", VA = "0x18064F5F0")]
		internal bool <AddObjective>b__2(Objective item)
		{
			return default(bool);
		}

		// Token: 0x0400106F RID: 4207
		[Token(Token = "0x400106F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string entryRef;
	}
}
