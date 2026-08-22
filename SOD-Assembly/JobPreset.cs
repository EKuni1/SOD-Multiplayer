using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000823 RID: 2083
[Token(Token = "0x2000823")]
public class JobPreset : SoCustomComparison
{
	// Token: 0x060029A1 RID: 10657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029A1")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CopyAcquisitionData()
	{
	}

	// Token: 0x060029A2 RID: 10658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029A2")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CopyFrequencyData()
	{
	}

	// Token: 0x060029A3 RID: 10659 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029A3")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CopyStartingScenarios()
	{
	}

	// Token: 0x060029A4 RID: 10660 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029A4")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CopyItemSpawns()
	{
	}

	// Token: 0x060029A5 RID: 10661 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029A5")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CopyResolveQuestions()
	{
	}

	// Token: 0x060029A6 RID: 10662 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029A6")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CopyIntros()
	{
	}

	// Token: 0x060029A7 RID: 10663 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029A7")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CopyHandIns()
	{
	}

	// Token: 0x060029A8 RID: 10664 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029A8")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CopyAdditionalMainElements()
	{
	}

	// Token: 0x060029A9 RID: 10665 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029A9")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void CopyDialogReferences()
	{
	}

	// Token: 0x060029AA RID: 10666 RVA: 0x0000F978 File Offset: 0x0000DB78
	[Token(Token = "0x60029AA")]
	[Address(RVA = "0xCAB1A0", Offset = "0xCAA1A0", VA = "0x180CAB1A0")]
	public int GetDifficultyValue()
	{
		return 0;
	}

	// Token: 0x060029AB RID: 10667 RVA: 0x0000F990 File Offset: 0x0000DB90
	[Token(Token = "0x60029AB")]
	[Address(RVA = "0xCAB210", Offset = "0xCAA210", VA = "0x180CAB210")]
	public int GetFrequencyForSocialCreditLevel()
	{
		return 0;
	}

	// Token: 0x060029AC RID: 10668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60029AC")]
	[Address(RVA = "0xCAB380", Offset = "0xCAA380", VA = "0x180CAB380")]
	public JobPreset()
	{
	}

	// Token: 0x04003E56 RID: 15958
	[Token(Token = "0x4003E56")]
	[FieldOffset(Offset = "0x20")]
	public bool disabled;

	// Token: 0x04003E57 RID: 15959
	[Token(Token = "0x4003E57")]
	[FieldOffset(Offset = "0x28")]
	public string caseName;

	// Token: 0x04003E58 RID: 15960
	[Token(Token = "0x4003E58")]
	[FieldOffset(Offset = "0x30")]
	public InteractablePreset jobPosting;

	// Token: 0x04003E59 RID: 15961
	[Token(Token = "0x4003E59")]
	[FieldOffset(Offset = "0x38")]
	public string subClass;

	// Token: 0x04003E5A RID: 15962
	[Token(Token = "0x4003E5A")]
	[FieldOffset(Offset = "0x40")]
	public bool allowSyncDiskRewards;

	// Token: 0x04003E5B RID: 15963
	[Token(Token = "0x4003E5B")]
	[FieldOffset(Offset = "0x41")]
	public bool allowBlackMarketSyncDiskRewards;

	// Token: 0x04003E5C RID: 15964
	[Token(Token = "0x4003E5C")]
	[FieldOffset(Offset = "0x44")]
	public JobPreset.RewardLocation physicalRewardLocation;

	// Token: 0x04003E5D RID: 15965
	[Token(Token = "0x4003E5D")]
	[FieldOffset(Offset = "0x48")]
	public bool generateHidingLocation;

	// Token: 0x04003E5E RID: 15966
	[Token(Token = "0x4003E5E")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve socialCreditLevelMinSpawnFrequency;

	// Token: 0x04003E5F RID: 15967
	[Token(Token = "0x4003E5F")]
	[FieldOffset(Offset = "0x58")]
	public float activePerCitizen;

	// Token: 0x04003E60 RID: 15968
	[Token(Token = "0x4003E60")]
	[FieldOffset(Offset = "0x5C")]
	public int maxJobs;

	// Token: 0x04003E61 RID: 15969
	[Token(Token = "0x4003E61")]
	[FieldOffset(Offset = "0x60")]
	public int immediatePostCountThreshold;

	// Token: 0x04003E62 RID: 15970
	[Token(Token = "0x4003E62")]
	[FieldOffset(Offset = "0x64")]
	public JobPreset.DifficultyTag difficultyTag;

	// Token: 0x04003E63 RID: 15971
	[Token(Token = "0x4003E63")]
	[FieldOffset(Offset = "0x68")]
	public JobPreset.ParticipantCompliancy changePosterDialogCompliancy;

	// Token: 0x04003E64 RID: 15972
	[Token(Token = "0x4003E64")]
	[FieldOffset(Offset = "0x6C")]
	public JobPreset.ParticipantCompliancy changePerpDialogCompliancy;

	// Token: 0x04003E65 RID: 15973
	[Token(Token = "0x4003E65")]
	[FieldOffset(Offset = "0x70")]
	public List<MotivePreset> purpetratorMotives;

	// Token: 0x04003E66 RID: 15974
	[Token(Token = "0x4003E66")]
	[FieldOffset(Offset = "0x78")]
	public int penaltyForPurpAndPosterSameBuilding;

	// Token: 0x04003E67 RID: 15975
	[Token(Token = "0x4003E67")]
	[FieldOffset(Offset = "0x80")]
	public List<JobPreset.StartingScenario> startingScenarios;

	// Token: 0x04003E68 RID: 15976
	[Token(Token = "0x4003E68")]
	[FieldOffset(Offset = "0x88")]
	public List<JobPreset.IntroConfig> compatibleIntros;

	// Token: 0x04003E69 RID: 15977
	[Token(Token = "0x4003E69")]
	[FieldOffset(Offset = "0x90")]
	public int leadPoolData;

	// Token: 0x04003E6A RID: 15978
	[Token(Token = "0x4003E6A")]
	[FieldOffset(Offset = "0x98")]
	public List<JobPreset.FactCreation> createFactsOnInformationAcquisition;

	// Token: 0x04003E6B RID: 15979
	[Token(Token = "0x4003E6B")]
	[FieldOffset(Offset = "0xA0")]
	public List<JobPreset.StartingLead> informationAcquisitionLeads;

	// Token: 0x04003E6C RID: 15980
	[Token(Token = "0x4003E6C")]
	[FieldOffset(Offset = "0xA8")]
	public List<RevengeObjective> revengeObjectives;

	// Token: 0x04003E6D RID: 15981
	[Token(Token = "0x4003E6D")]
	[FieldOffset(Offset = "0xB0")]
	public List<JobPreset.StartingSpawnItem> spawnItems;

	// Token: 0x04003E6E RID: 15982
	[Token(Token = "0x4003E6E")]
	[FieldOffset(Offset = "0xB8")]
	public List<Case.ResolveQuestion> resolveQuestions;

	// Token: 0x04003E6F RID: 15983
	[Token(Token = "0x4003E6F")]
	[FieldOffset(Offset = "0xC0")]
	public List<SideMissionIntroPreset.SideMissionObjectiveBlock> additional;

	// Token: 0x04003E70 RID: 15984
	[Token(Token = "0x4003E70")]
	[FieldOffset(Offset = "0xC8")]
	public List<JobPreset.HandInConfig> compatibleHandIns;

	// Token: 0x04003E71 RID: 15985
	[Token(Token = "0x4003E71")]
	[FieldOffset(Offset = "0xD0")]
	public List<JobPreset.DialogReference> dialogReferences;

	// Token: 0x04003E72 RID: 15986
	[Token(Token = "0x4003E72")]
	[FieldOffset(Offset = "0xD8")]
	public JobPreset debugCopyFrom;

	// Token: 0x02000824 RID: 2084
	[Token(Token = "0x2000824")]
	public enum JobTag
	{
		// Token: 0x04003E74 RID: 15988
		[Token(Token = "0x4003E74")]
		A,
		// Token: 0x04003E75 RID: 15989
		[Token(Token = "0x4003E75")]
		B,
		// Token: 0x04003E76 RID: 15990
		[Token(Token = "0x4003E76")]
		C,
		// Token: 0x04003E77 RID: 15991
		[Token(Token = "0x4003E77")]
		D,
		// Token: 0x04003E78 RID: 15992
		[Token(Token = "0x4003E78")]
		E,
		// Token: 0x04003E79 RID: 15993
		[Token(Token = "0x4003E79")]
		F,
		// Token: 0x04003E7A RID: 15994
		[Token(Token = "0x4003E7A")]
		G,
		// Token: 0x04003E7B RID: 15995
		[Token(Token = "0x4003E7B")]
		H,
		// Token: 0x04003E7C RID: 15996
		[Token(Token = "0x4003E7C")]
		I,
		// Token: 0x04003E7D RID: 15997
		[Token(Token = "0x4003E7D")]
		J,
		// Token: 0x04003E7E RID: 15998
		[Token(Token = "0x4003E7E")]
		K,
		// Token: 0x04003E7F RID: 15999
		[Token(Token = "0x4003E7F")]
		L,
		// Token: 0x04003E80 RID: 16000
		[Token(Token = "0x4003E80")]
		M,
		// Token: 0x04003E81 RID: 16001
		[Token(Token = "0x4003E81")]
		N,
		// Token: 0x04003E82 RID: 16002
		[Token(Token = "0x4003E82")]
		O,
		// Token: 0x04003E83 RID: 16003
		[Token(Token = "0x4003E83")]
		P,
		// Token: 0x04003E84 RID: 16004
		[Token(Token = "0x4003E84")]
		Q,
		// Token: 0x04003E85 RID: 16005
		[Token(Token = "0x4003E85")]
		R,
		// Token: 0x04003E86 RID: 16006
		[Token(Token = "0x4003E86")]
		S,
		// Token: 0x04003E87 RID: 16007
		[Token(Token = "0x4003E87")]
		T,
		// Token: 0x04003E88 RID: 16008
		[Token(Token = "0x4003E88")]
		U,
		// Token: 0x04003E89 RID: 16009
		[Token(Token = "0x4003E89")]
		V,
		// Token: 0x04003E8A RID: 16010
		[Token(Token = "0x4003E8A")]
		W,
		// Token: 0x04003E8B RID: 16011
		[Token(Token = "0x4003E8B")]
		X,
		// Token: 0x04003E8C RID: 16012
		[Token(Token = "0x4003E8C")]
		Y,
		// Token: 0x04003E8D RID: 16013
		[Token(Token = "0x4003E8D")]
		Z
	}

	// Token: 0x02000825 RID: 2085
	[Token(Token = "0x2000825")]
	[Serializable]
	public class StartingScenario
	{
		// Token: 0x060029AD RID: 10669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AD")]
		[Address(RVA = "0xCABB60", Offset = "0xCAAB60", VA = "0x180CABB60")]
		public StartingScenario()
		{
		}

		// Token: 0x04003E8E RID: 16014
		[Token(Token = "0x4003E8E")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04003E8F RID: 16015
		[Token(Token = "0x4003E8F")]
		[FieldOffset(Offset = "0x18")]
		public string dds;

		// Token: 0x04003E90 RID: 16016
		[Token(Token = "0x4003E90")]
		[FieldOffset(Offset = "0x20")]
		public List<JobPreset.StartingLead> leads;
	}

	// Token: 0x02000826 RID: 2086
	[Token(Token = "0x2000826")]
	[Serializable]
	public class StartingLead
	{
		// Token: 0x060029AE RID: 10670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AE")]
		[Address(RVA = "0xCABC30", Offset = "0xCAAC30", VA = "0x180CABC30")]
		public StartingLead()
		{
		}

		// Token: 0x04003E91 RID: 16017
		[Token(Token = "0x4003E91")]
		[FieldOffset(Offset = "0x10")]
		public JobPreset.LeadEvidence leadEvidence;

		// Token: 0x04003E92 RID: 16018
		[Token(Token = "0x4003E92")]
		[FieldOffset(Offset = "0x18")]
		public List<Evidence.DataKey> keys;

		// Token: 0x04003E93 RID: 16019
		[Token(Token = "0x4003E93")]
		[FieldOffset(Offset = "0x20")]
		public bool useKeyFromLeadPool;

		// Token: 0x04003E94 RID: 16020
		[Token(Token = "0x4003E94")]
		[FieldOffset(Offset = "0x21")]
		public bool autoPin;

		// Token: 0x04003E95 RID: 16021
		[Token(Token = "0x4003E95")]
		[FieldOffset(Offset = "0x28")]
		public List<DialogPreset> addDialogOptions;

		// Token: 0x04003E96 RID: 16022
		[Token(Token = "0x4003E96")]
		[FieldOffset(Offset = "0x30")]
		public List<string> factsReveal;

		// Token: 0x04003E97 RID: 16023
		[Token(Token = "0x4003E97")]
		[FieldOffset(Offset = "0x38")]
		public List<Evidence.DataKey> mergeKeys;

		// Token: 0x04003E98 RID: 16024
		[Token(Token = "0x4003E98")]
		[FieldOffset(Offset = "0x40")]
		public List<Evidence.Discovery> discoveryApplication;
	}

	// Token: 0x02000827 RID: 2087
	[Token(Token = "0x2000827")]
	[Serializable]
	public class FactCreation
	{
		// Token: 0x060029AF RID: 10671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AF")]
		[Address(RVA = "0xCABF40", Offset = "0xCAAF40", VA = "0x180CABF40")]
		public FactCreation()
		{
		}

		// Token: 0x04003E99 RID: 16025
		[Token(Token = "0x4003E99")]
		[FieldOffset(Offset = "0x10")]
		public FactPreset factPreset;

		// Token: 0x04003E9A RID: 16026
		[Token(Token = "0x4003E9A")]
		[FieldOffset(Offset = "0x18")]
		public JobPreset.LeadEvidence from;

		// Token: 0x04003E9B RID: 16027
		[Token(Token = "0x4003E9B")]
		[FieldOffset(Offset = "0x1C")]
		public JobPreset.LeadEvidence to;

		// Token: 0x04003E9C RID: 16028
		[Token(Token = "0x4003E9C")]
		[FieldOffset(Offset = "0x20")]
		public bool overrideFromKeys;

		// Token: 0x04003E9D RID: 16029
		[Token(Token = "0x4003E9D")]
		[FieldOffset(Offset = "0x28")]
		public List<Evidence.DataKey> fromKeys;

		// Token: 0x04003E9E RID: 16030
		[Token(Token = "0x4003E9E")]
		[FieldOffset(Offset = "0x30")]
		public bool featureKeysFromLeadPool;

		// Token: 0x04003E9F RID: 16031
		[Token(Token = "0x4003E9F")]
		[FieldOffset(Offset = "0x31")]
		public bool overrideToKeys;

		// Token: 0x04003EA0 RID: 16032
		[Token(Token = "0x4003EA0")]
		[FieldOffset(Offset = "0x38")]
		public List<Evidence.DataKey> toKeys;

		// Token: 0x04003EA1 RID: 16033
		[Token(Token = "0x4003EA1")]
		[FieldOffset(Offset = "0x40")]
		public bool featureKeysFromLeadPoolTo;
	}

	// Token: 0x02000828 RID: 2088
	[Token(Token = "0x2000828")]
	public enum LeadEvidence
	{
		// Token: 0x04003EA3 RID: 16035
		[Token(Token = "0x4003EA3")]
		none,
		// Token: 0x04003EA4 RID: 16036
		[Token(Token = "0x4003EA4")]
		poster,
		// Token: 0x04003EA5 RID: 16037
		[Token(Token = "0x4003EA5")]
		purp,
		// Token: 0x04003EA6 RID: 16038
		[Token(Token = "0x4003EA6")]
		purpsParamour,
		// Token: 0x04003EA7 RID: 16039
		[Token(Token = "0x4003EA7")]
		postersHome,
		// Token: 0x04003EA8 RID: 16040
		[Token(Token = "0x4003EA8")]
		purpsHome,
		// Token: 0x04003EA9 RID: 16041
		[Token(Token = "0x4003EA9")]
		purpsParamourHome,
		// Token: 0x04003EAA RID: 16042
		[Token(Token = "0x4003EAA")]
		postersWorkplace,
		// Token: 0x04003EAB RID: 16043
		[Token(Token = "0x4003EAB")]
		purpsWorkplace,
		// Token: 0x04003EAC RID: 16044
		[Token(Token = "0x4003EAC")]
		purpsParamourWorkplace,
		// Token: 0x04003EAD RID: 16045
		[Token(Token = "0x4003EAD")]
		postersBuilding,
		// Token: 0x04003EAE RID: 16046
		[Token(Token = "0x4003EAE")]
		purpsBuilding,
		// Token: 0x04003EAF RID: 16047
		[Token(Token = "0x4003EAF")]
		purpsParamourBuilding,
		// Token: 0x04003EB0 RID: 16048
		[Token(Token = "0x4003EB0")]
		post,
		// Token: 0x04003EB1 RID: 16049
		[Token(Token = "0x4003EB1")]
		posterTelephone,
		// Token: 0x04003EB2 RID: 16050
		[Token(Token = "0x4003EB2")]
		purpsTelephone,
		// Token: 0x04003EB3 RID: 16051
		[Token(Token = "0x4003EB3")]
		purpsParamourTelephone,
		// Token: 0x04003EB4 RID: 16052
		[Token(Token = "0x4003EB4")]
		postersWorkplaceBuilding,
		// Token: 0x04003EB5 RID: 16053
		[Token(Token = "0x4003EB5")]
		purpsWorkplaceBuilding,
		// Token: 0x04003EB6 RID: 16054
		[Token(Token = "0x4003EB6")]
		purpsParamourWorkplaceBuilding,
		// Token: 0x04003EB7 RID: 16055
		[Token(Token = "0x4003EB7")]
		extraPerson1,
		// Token: 0x04003EB8 RID: 16056
		[Token(Token = "0x4003EB8")]
		itemA,
		// Token: 0x04003EB9 RID: 16057
		[Token(Token = "0x4003EB9")]
		itemB,
		// Token: 0x04003EBA RID: 16058
		[Token(Token = "0x4003EBA")]
		itemC,
		// Token: 0x04003EBB RID: 16059
		[Token(Token = "0x4003EBB")]
		itemD,
		// Token: 0x04003EBC RID: 16060
		[Token(Token = "0x4003EBC")]
		itemE
	}

	// Token: 0x02000829 RID: 2089
	[Token(Token = "0x2000829")]
	public enum BasicLeadPool
	{
		// Token: 0x04003EBE RID: 16062
		[Token(Token = "0x4003EBE")]
		hair,
		// Token: 0x04003EBF RID: 16063
		[Token(Token = "0x4003EBF")]
		eyeColour,
		// Token: 0x04003EC0 RID: 16064
		[Token(Token = "0x4003EC0")]
		shoeSize,
		// Token: 0x04003EC1 RID: 16065
		[Token(Token = "0x4003EC1")]
		build,
		// Token: 0x04003EC2 RID: 16066
		[Token(Token = "0x4003EC2")]
		height,
		// Token: 0x04003EC3 RID: 16067
		[Token(Token = "0x4003EC3")]
		fingerprint,
		// Token: 0x04003EC4 RID: 16068
		[Token(Token = "0x4003EC4")]
		age,
		// Token: 0x04003EC5 RID: 16069
		[Token(Token = "0x4003EC5")]
		jobTitle,
		// Token: 0x04003EC6 RID: 16070
		[Token(Token = "0x4003EC6")]
		randomInterest,
		// Token: 0x04003EC7 RID: 16071
		[Token(Token = "0x4003EC7")]
		partnerFirstName,
		// Token: 0x04003EC8 RID: 16072
		[Token(Token = "0x4003EC8")]
		partnerJobTitle,
		// Token: 0x04003EC9 RID: 16073
		[Token(Token = "0x4003EC9")]
		firstNameInitial,
		// Token: 0x04003ECA RID: 16074
		[Token(Token = "0x4003ECA")]
		socialClub,
		// Token: 0x04003ECB RID: 16075
		[Token(Token = "0x4003ECB")]
		partnerSocialClub,
		// Token: 0x04003ECC RID: 16076
		[Token(Token = "0x4003ECC")]
		notableFeatures,
		// Token: 0x04003ECD RID: 16077
		[Token(Token = "0x4003ECD")]
		salary,
		// Token: 0x04003ECE RID: 16078
		[Token(Token = "0x4003ECE")]
		bloodType,
		// Token: 0x04003ECF RID: 16079
		[Token(Token = "0x4003ECF")]
		randomAffliction,
		// Token: 0x04003ED0 RID: 16080
		[Token(Token = "0x4003ED0")]
		handwriting
	}

	// Token: 0x0200082A RID: 2090
	[Token(Token = "0x200082A")]
	public enum LeadCitizen
	{
		// Token: 0x04003ED2 RID: 16082
		[Token(Token = "0x4003ED2")]
		nobody,
		// Token: 0x04003ED3 RID: 16083
		[Token(Token = "0x4003ED3")]
		poster,
		// Token: 0x04003ED4 RID: 16084
		[Token(Token = "0x4003ED4")]
		purp,
		// Token: 0x04003ED5 RID: 16085
		[Token(Token = "0x4003ED5")]
		purpsParamour
	}

	// Token: 0x0200082B RID: 2091
	[Token(Token = "0x200082B")]
	public enum JobSpawnWhere
	{
		// Token: 0x04003ED7 RID: 16087
		[Token(Token = "0x4003ED7")]
		posterHome,
		// Token: 0x04003ED8 RID: 16088
		[Token(Token = "0x4003ED8")]
		posterWork,
		// Token: 0x04003ED9 RID: 16089
		[Token(Token = "0x4003ED9")]
		purpHome,
		// Token: 0x04003EDA RID: 16090
		[Token(Token = "0x4003EDA")]
		purpWork,
		// Token: 0x04003EDB RID: 16091
		[Token(Token = "0x4003EDB")]
		purpsParamourHome,
		// Token: 0x04003EDC RID: 16092
		[Token(Token = "0x4003EDC")]
		purpsParamourWork,
		// Token: 0x04003EDD RID: 16093
		[Token(Token = "0x4003EDD")]
		hiddenItemPlace,
		// Token: 0x04003EDE RID: 16094
		[Token(Token = "0x4003EDE")]
		nearbyGooseChase
	}

	// Token: 0x0200082C RID: 2092
	[Token(Token = "0x200082C")]
	public enum DifficultyTag
	{
		// Token: 0x04003EE0 RID: 16096
		[Token(Token = "0x4003EE0")]
		D0,
		// Token: 0x04003EE1 RID: 16097
		[Token(Token = "0x4003EE1")]
		D1,
		// Token: 0x04003EE2 RID: 16098
		[Token(Token = "0x4003EE2")]
		D2A,
		// Token: 0x04003EE3 RID: 16099
		[Token(Token = "0x4003EE3")]
		D2B,
		// Token: 0x04003EE4 RID: 16100
		[Token(Token = "0x4003EE4")]
		D3,
		// Token: 0x04003EE5 RID: 16101
		[Token(Token = "0x4003EE5")]
		D4A,
		// Token: 0x04003EE6 RID: 16102
		[Token(Token = "0x4003EE6")]
		D4B,
		// Token: 0x04003EE7 RID: 16103
		[Token(Token = "0x4003EE7")]
		D4C,
		// Token: 0x04003EE8 RID: 16104
		[Token(Token = "0x4003EE8")]
		D5,
		// Token: 0x04003EE9 RID: 16105
		[Token(Token = "0x4003EE9")]
		D6
	}

	// Token: 0x0200082D RID: 2093
	[Token(Token = "0x200082D")]
	[Serializable]
	public class JobModifierRule
	{
		// Token: 0x060029B0 RID: 10672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B0")]
		[Address(RVA = "0xCAC0A0", Offset = "0xCAB0A0", VA = "0x180CAC0A0")]
		public JobModifierRule()
		{
		}

		// Token: 0x04003EEA RID: 16106
		[Token(Token = "0x4003EEA")]
		[FieldOffset(Offset = "0x10")]
		public JobPreset.LeadCitizen who;

		// Token: 0x04003EEB RID: 16107
		[Token(Token = "0x4003EEB")]
		[FieldOffset(Offset = "0x14")]
		public CharacterTrait.RuleType rule;

		// Token: 0x04003EEC RID: 16108
		[Token(Token = "0x4003EEC")]
		[FieldOffset(Offset = "0x18")]
		public List<CharacterTrait> traitList;

		// Token: 0x04003EED RID: 16109
		[Token(Token = "0x4003EED")]
		[FieldOffset(Offset = "0x20")]
		public bool mustPassForApplication;

		// Token: 0x04003EEE RID: 16110
		[Token(Token = "0x4003EEE")]
		[FieldOffset(Offset = "0x24")]
		public float chanceModifier;
	}

	// Token: 0x0200082E RID: 2094
	[Token(Token = "0x200082E")]
	[Serializable]
	public class StartingSpawnItem
	{
		// Token: 0x060029B1 RID: 10673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B1")]
		[Address(RVA = "0xCAC170", Offset = "0xCAB170", VA = "0x180CAC170")]
		public StartingSpawnItem()
		{
		}

		// Token: 0x04003EEF RID: 16111
		[Token(Token = "0x4003EEF")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04003EF0 RID: 16112
		[Token(Token = "0x4003EF0")]
		[FieldOffset(Offset = "0x18")]
		public bool findExisting;

		// Token: 0x04003EF1 RID: 16113
		[Token(Token = "0x4003EF1")]
		[FieldOffset(Offset = "0x20")]
		public List<MotivePreset> compatibleWithMotives;

		// Token: 0x04003EF2 RID: 16114
		[Token(Token = "0x4003EF2")]
		[FieldOffset(Offset = "0x28")]
		public bool compatibleWithAllMotives;

		// Token: 0x04003EF3 RID: 16115
		[Token(Token = "0x4003EF3")]
		[FieldOffset(Offset = "0x2C")]
		public float chance;

		// Token: 0x04003EF4 RID: 16116
		[Token(Token = "0x4003EF4")]
		[FieldOffset(Offset = "0x30")]
		public bool useTraits;

		// Token: 0x04003EF5 RID: 16117
		[Token(Token = "0x4003EF5")]
		[FieldOffset(Offset = "0x38")]
		public List<JobPreset.JobModifierRule> traitModifiers;

		// Token: 0x04003EF6 RID: 16118
		[Token(Token = "0x4003EF6")]
		[FieldOffset(Offset = "0x40")]
		public bool useIf;

		// Token: 0x04003EF7 RID: 16119
		[Token(Token = "0x4003EF7")]
		[FieldOffset(Offset = "0x44")]
		public JobPreset.JobTag ifTag;

		// Token: 0x04003EF8 RID: 16120
		[Token(Token = "0x4003EF8")]
		[FieldOffset(Offset = "0x48")]
		public bool useOrGroup;

		// Token: 0x04003EF9 RID: 16121
		[Token(Token = "0x4003EF9")]
		[FieldOffset(Offset = "0x4C")]
		public JobPreset.JobTag orGroup;

		// Token: 0x04003EFA RID: 16122
		[Token(Token = "0x4003EFA")]
		[FieldOffset(Offset = "0x50")]
		public int chanceRatio;

		// Token: 0x04003EFB RID: 16123
		[Token(Token = "0x4003EFB")]
		[FieldOffset(Offset = "0x58")]
		public List<JobPreset.DifficultyTag> disableOnDifficulties;

		// Token: 0x04003EFC RID: 16124
		[Token(Token = "0x4003EFC")]
		[FieldOffset(Offset = "0x60")]
		public JobPreset.JobTag itemTag;

		// Token: 0x04003EFD RID: 16125
		[Token(Token = "0x4003EFD")]
		[FieldOffset(Offset = "0x68")]
		public InteractablePreset spawnItem;

		// Token: 0x04003EFE RID: 16126
		[Token(Token = "0x4003EFE")]
		[FieldOffset(Offset = "0x70")]
		public string vmailThread;

		// Token: 0x04003EFF RID: 16127
		[Token(Token = "0x4003EFF")]
		[FieldOffset(Offset = "0x78")]
		public Vector2 vmailProgressThreshold;

		// Token: 0x04003F00 RID: 16128
		[Token(Token = "0x4003F00")]
		[FieldOffset(Offset = "0x80")]
		public JobPreset.JobSpawnWhere where;

		// Token: 0x04003F01 RID: 16129
		[Token(Token = "0x4003F01")]
		[FieldOffset(Offset = "0x84")]
		public JobPreset.LeadCitizen belongsTo;

		// Token: 0x04003F02 RID: 16130
		[Token(Token = "0x4003F02")]
		[FieldOffset(Offset = "0x88")]
		public JobPreset.LeadCitizen writer;

		// Token: 0x04003F03 RID: 16131
		[Token(Token = "0x4003F03")]
		[FieldOffset(Offset = "0x8C")]
		public JobPreset.LeadCitizen receiver;

		// Token: 0x04003F04 RID: 16132
		[Token(Token = "0x4003F04")]
		[FieldOffset(Offset = "0x90")]
		public int security;

		// Token: 0x04003F05 RID: 16133
		[Token(Token = "0x4003F05")]
		[FieldOffset(Offset = "0x94")]
		public int priority;

		// Token: 0x04003F06 RID: 16134
		[Token(Token = "0x4003F06")]
		[FieldOffset(Offset = "0x98")]
		public InteractablePreset.OwnedPlacementRule ownershipRule;
	}

	// Token: 0x0200082F RID: 2095
	[Token(Token = "0x200082F")]
	[Serializable]
	public class HandInLocation
	{
		// Token: 0x060029B2 RID: 10674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public HandInLocation()
		{
		}

		// Token: 0x04003F07 RID: 16135
		[Token(Token = "0x4003F07")]
		[FieldOffset(Offset = "0x10")]
		public JobPreset.LeadCitizen who;
	}

	// Token: 0x02000830 RID: 2096
	[Token(Token = "0x2000830")]
	[Serializable]
	public class IntroConfig
	{
		// Token: 0x060029B3 RID: 10675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B3")]
		[Address(RVA = "0xCAC3B0", Offset = "0xCAB3B0", VA = "0x180CAC3B0")]
		public IntroConfig()
		{
		}

		// Token: 0x04003F08 RID: 16136
		[Token(Token = "0x4003F08")]
		[FieldOffset(Offset = "0x10")]
		public SideMissionIntroPreset preset;

		// Token: 0x04003F09 RID: 16137
		[Token(Token = "0x4003F09")]
		[FieldOffset(Offset = "0x18")]
		public int frequency;
	}

	// Token: 0x02000831 RID: 2097
	[Token(Token = "0x2000831")]
	[Serializable]
	public class HandInConfig
	{
		// Token: 0x060029B4 RID: 10676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B4")]
		[Address(RVA = "0xCAC3B0", Offset = "0xCAB3B0", VA = "0x180CAC3B0")]
		public HandInConfig()
		{
		}

		// Token: 0x04003F0A RID: 16138
		[Token(Token = "0x4003F0A")]
		[FieldOffset(Offset = "0x10")]
		public SideMissionHandInPreset preset;

		// Token: 0x04003F0B RID: 16139
		[Token(Token = "0x4003F0B")]
		[FieldOffset(Offset = "0x18")]
		public int frequency;
	}

	// Token: 0x02000832 RID: 2098
	[Token(Token = "0x2000832")]
	public enum RewardLocation
	{
		// Token: 0x04003F0D RID: 16141
		[Token(Token = "0x4003F0D")]
		none,
		// Token: 0x04003F0E RID: 16142
		[Token(Token = "0x4003F0E")]
		postersMailbox,
		// Token: 0x04003F0F RID: 16143
		[Token(Token = "0x4003F0F")]
		cityHallDesk,
		// Token: 0x04003F10 RID: 16144
		[Token(Token = "0x4003F10")]
		playersMailbox
	}

	// Token: 0x02000833 RID: 2099
	[Token(Token = "0x2000833")]
	public enum ParticipantCompliancy
	{
		// Token: 0x04003F12 RID: 16146
		[Token(Token = "0x4003F12")]
		noChange,
		// Token: 0x04003F13 RID: 16147
		[Token(Token = "0x4003F13")]
		alwaysSuccess,
		// Token: 0x04003F14 RID: 16148
		[Token(Token = "0x4003F14")]
		alwaysFail
	}

	// Token: 0x02000834 RID: 2100
	[Token(Token = "0x2000834")]
	[Serializable]
	public class DialogReference
	{
		// Token: 0x060029B5 RID: 10677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029B5")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public DialogReference()
		{
		}

		// Token: 0x04003F15 RID: 16149
		[Token(Token = "0x4003F15")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04003F16 RID: 16150
		[Token(Token = "0x4003F16")]
		[FieldOffset(Offset = "0x18")]
		public DialogPreset dialog;
	}
}
