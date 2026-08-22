using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200077A RID: 1914
[Token(Token = "0x200077A")]
public class BroadcastPreset : SoCustomComparison
{
	// Token: 0x06002911 RID: 10513 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002911")]
	[Address(RVA = "0xC68C10", Offset = "0xC67C10", VA = "0x180C68C10")]
	public BroadcastPreset()
	{
	}

	// Token: 0x040036D9 RID: 14041
	[Token(Token = "0x40036D9")]
	[FieldOffset(Offset = "0x20")]
	public AudioEvent audioEvent;

	// Token: 0x040036DA RID: 14042
	[Token(Token = "0x40036DA")]
	[FieldOffset(Offset = "0x28")]
	public float changeImageEvery;

	// Token: 0x040036DB RID: 14043
	[Token(Token = "0x40036DB")]
	[FieldOffset(Offset = "0x2C")]
	public BroadcastPreset.ImageOrder order;

	// Token: 0x040036DC RID: 14044
	[Token(Token = "0x40036DC")]
	[FieldOffset(Offset = "0x30")]
	public BroadcastPreset.EndOfShow endOfShowTrigger;

	// Token: 0x040036DD RID: 14045
	[Token(Token = "0x40036DD")]
	[FieldOffset(Offset = "0x38")]
	public Texture2D spriteSheet;

	// Token: 0x040036DE RID: 14046
	[Token(Token = "0x40036DE")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 spriteResolution;

	// Token: 0x040036DF RID: 14047
	[Token(Token = "0x40036DF")]
	[FieldOffset(Offset = "0x48")]
	public int indexWidth;

	// Token: 0x040036E0 RID: 14048
	[Token(Token = "0x40036E0")]
	[FieldOffset(Offset = "0x4C")]
	public int indexHeight;

	// Token: 0x040036E1 RID: 14049
	[Token(Token = "0x40036E1")]
	[FieldOffset(Offset = "0x50")]
	public int totalSpriteCount;

	// Token: 0x040036E2 RID: 14050
	[Token(Token = "0x40036E2")]
	[FieldOffset(Offset = "0x54")]
	public bool useDynamicClips;

	// Token: 0x040036E3 RID: 14051
	[Token(Token = "0x40036E3")]
	[FieldOffset(Offset = "0x58")]
	public List<BroadcastPreset.DynamicClip> dynamicClips;

	// Token: 0x0200077B RID: 1915
	[Token(Token = "0x200077B")]
	public enum ImageOrder
	{
		// Token: 0x040036E5 RID: 14053
		[Token(Token = "0x40036E5")]
		random,
		// Token: 0x040036E6 RID: 14054
		[Token(Token = "0x40036E6")]
		ordered
	}

	// Token: 0x0200077C RID: 1916
	[Token(Token = "0x200077C")]
	public enum EndOfShow
	{
		// Token: 0x040036E8 RID: 14056
		[Token(Token = "0x40036E8")]
		atEndOfAudioEvent,
		// Token: 0x040036E9 RID: 14057
		[Token(Token = "0x40036E9")]
		onEndOfDynamicClips
	}

	// Token: 0x0200077D RID: 1917
	[Token(Token = "0x200077D")]
	[Serializable]
	public class DynamicClip
	{
		// Token: 0x06002912 RID: 10514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002912")]
		[Address(RVA = "0xC68D00", Offset = "0xC67D00", VA = "0x180C68D00")]
		public DynamicClip()
		{
		}

		// Token: 0x040036EA RID: 14058
		[Token(Token = "0x40036EA")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040036EB RID: 14059
		[Token(Token = "0x40036EB")]
		[FieldOffset(Offset = "0x18")]
		public float chance;

		// Token: 0x040036EC RID: 14060
		[Token(Token = "0x40036EC")]
		[FieldOffset(Offset = "0x20")]
		public List<BroadcastPreset.DynamicClipEvent> possibleEvents;

		// Token: 0x040036ED RID: 14061
		[Token(Token = "0x40036ED")]
		[FieldOffset(Offset = "0x28")]
		public float followingDelay;

		// Token: 0x040036EE RID: 14062
		[Token(Token = "0x40036EE")]
		[FieldOffset(Offset = "0x2C")]
		public BroadcastPreset.FollowingIndexMode nextMode;

		// Token: 0x040036EF RID: 14063
		[Token(Token = "0x40036EF")]
		[FieldOffset(Offset = "0x30")]
		public int nextIndex;

		// Token: 0x040036F0 RID: 14064
		[Token(Token = "0x40036F0")]
		[FieldOffset(Offset = "0x34")]
		public BroadcastPreset.FollowingIndexMode onFailToGetEvent;

		// Token: 0x040036F1 RID: 14065
		[Token(Token = "0x40036F1")]
		[FieldOffset(Offset = "0x38")]
		public int onFailIndex;
	}

	// Token: 0x0200077E RID: 1918
	[Token(Token = "0x200077E")]
	[Serializable]
	public class DynamicClipEvent
	{
		// Token: 0x06002913 RID: 10515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002913")]
		[Address(RVA = "0xC68DE0", Offset = "0xC67DE0", VA = "0x180C68DE0")]
		public DynamicClipEvent()
		{
		}

		// Token: 0x040036F2 RID: 14066
		[Token(Token = "0x40036F2")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040036F3 RID: 14067
		[Token(Token = "0x40036F3")]
		[FieldOffset(Offset = "0x18")]
		public BroadcastPreset.ConditionMode conditionMode;

		// Token: 0x040036F4 RID: 14068
		[Token(Token = "0x40036F4")]
		[FieldOffset(Offset = "0x20")]
		public List<BroadcastPreset.DynamicShowCondition> OrConditions;

		// Token: 0x040036F5 RID: 14069
		[Token(Token = "0x40036F5")]
		[FieldOffset(Offset = "0x28")]
		public List<AudioEvent> audioEvents;

		// Token: 0x040036F6 RID: 14070
		[Token(Token = "0x40036F6")]
		[FieldOffset(Offset = "0x30")]
		public List<BroadcastPreset.DynamicShowParam> applyParameters;

		// Token: 0x040036F7 RID: 14071
		[Token(Token = "0x40036F7")]
		[FieldOffset(Offset = "0x38")]
		public bool overrideCrowdNoiseParam;

		// Token: 0x040036F8 RID: 14072
		[Token(Token = "0x40036F8")]
		[FieldOffset(Offset = "0x3C")]
		public float crowdLayerVolume;

		// Token: 0x040036F9 RID: 14073
		[Token(Token = "0x40036F9")]
		[FieldOffset(Offset = "0x40")]
		public BroadcastPreset.CrowdReaction triggerCrowdReaction;
	}

	// Token: 0x0200077F RID: 1919
	[Token(Token = "0x200077F")]
	[Serializable]
	public class DynamicShowCondition
	{
		// Token: 0x06002914 RID: 10516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002914")]
		[Address(RVA = "0xC68FF0", Offset = "0xC67FF0", VA = "0x180C68FF0")]
		public DynamicShowCondition()
		{
		}

		// Token: 0x040036FA RID: 14074
		[Token(Token = "0x40036FA")]
		[FieldOffset(Offset = "0x10")]
		public BroadcastPreset.DynamicConditionType condition;

		// Token: 0x040036FB RID: 14075
		[Token(Token = "0x40036FB")]
		[FieldOffset(Offset = "0x18")]
		public List<BroadcastPreset.DynamicShowParam> parametersList;
	}

	// Token: 0x02000780 RID: 1920
	[Token(Token = "0x2000780")]
	public enum DynamicConditionType
	{
		// Token: 0x040036FD RID: 14077
		[Token(Token = "0x40036FD")]
		IfParamIsPresent,
		// Token: 0x040036FE RID: 14078
		[Token(Token = "0x40036FE")]
		IfParamEquals,
		// Token: 0x040036FF RID: 14079
		[Token(Token = "0x40036FF")]
		IfParamDoesntEqual,
		// Token: 0x04003700 RID: 14080
		[Token(Token = "0x4003700")]
		team1TakesLeadWithCurrentScore,
		// Token: 0x04003701 RID: 14081
		[Token(Token = "0x4003701")]
		team2TakesLeadWithCurrentScore,
		// Token: 0x04003702 RID: 14082
		[Token(Token = "0x4003702")]
		isDraw,
		// Token: 0x04003703 RID: 14083
		[Token(Token = "0x4003703")]
		team1Wins,
		// Token: 0x04003704 RID: 14084
		[Token(Token = "0x4003704")]
		team2Wins
	}

	// Token: 0x02000781 RID: 1921
	[Token(Token = "0x2000781")]
	[Serializable]
	public class DynamicShowParam
	{
		// Token: 0x06002915 RID: 10517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002915")]
		[Address(RVA = "0xC690C0", Offset = "0xC680C0", VA = "0x180C690C0")]
		public DynamicShowParam(BroadcastPreset.ShowParamType newParameter, float newValue)
		{
		}

		// Token: 0x04003705 RID: 14085
		[Token(Token = "0x4003705")]
		[FieldOffset(Offset = "0x10")]
		public BroadcastPreset.ShowParamType paramType;

		// Token: 0x04003706 RID: 14086
		[Token(Token = "0x4003706")]
		[FieldOffset(Offset = "0x14")]
		public BroadcastPreset.ParamApplicationMode applicationMode;

		// Token: 0x04003707 RID: 14087
		[Token(Token = "0x4003707")]
		[FieldOffset(Offset = "0x18")]
		public float value;
	}

	// Token: 0x02000782 RID: 1922
	[Token(Token = "0x2000782")]
	public enum ShowParamType
	{
		// Token: 0x04003709 RID: 14089
		[Token(Token = "0x4003709")]
		team1,
		// Token: 0x0400370A RID: 14090
		[Token(Token = "0x400370A")]
		team2,
		// Token: 0x0400370B RID: 14091
		[Token(Token = "0x400370B")]
		scoreTeam1,
		// Token: 0x0400370C RID: 14092
		[Token(Token = "0x400370C")]
		scoreTeam2,
		// Token: 0x0400370D RID: 14093
		[Token(Token = "0x400370D")]
		playersTeamOne1,
		// Token: 0x0400370E RID: 14094
		[Token(Token = "0x400370E")]
		playersTeamTwo1,
		// Token: 0x0400370F RID: 14095
		[Token(Token = "0x400370F")]
		playersTeamOne2,
		// Token: 0x04003710 RID: 14096
		[Token(Token = "0x4003710")]
		playersTeamTwo2,
		// Token: 0x04003711 RID: 14097
		[Token(Token = "0x4003711")]
		playersTeamOne3,
		// Token: 0x04003712 RID: 14098
		[Token(Token = "0x4003712")]
		playersTeamTwo3,
		// Token: 0x04003713 RID: 14099
		[Token(Token = "0x4003713")]
		playerNameInterjection,
		// Token: 0x04003714 RID: 14100
		[Token(Token = "0x4003714")]
		lastPlay,
		// Token: 0x04003715 RID: 14101
		[Token(Token = "0x4003715")]
		currentBalls,
		// Token: 0x04003716 RID: 14102
		[Token(Token = "0x4003716")]
		playersPlayed,
		// Token: 0x04003717 RID: 14103
		[Token(Token = "0x4003717")]
		currentScore,
		// Token: 0x04003718 RID: 14104
		[Token(Token = "0x4003718")]
		currentTeam,
		// Token: 0x04003719 RID: 14105
		[Token(Token = "0x4003719")]
		innings
	}

	// Token: 0x02000783 RID: 1923
	[Token(Token = "0x2000783")]
	public enum ConditionMode
	{
		// Token: 0x0400371B RID: 14107
		[Token(Token = "0x400371B")]
		OR,
		// Token: 0x0400371C RID: 14108
		[Token(Token = "0x400371C")]
		AND
	}

	// Token: 0x02000784 RID: 1924
	[Token(Token = "0x2000784")]
	public enum CrowdReaction
	{
		// Token: 0x0400371E RID: 14110
		[Token(Token = "0x400371E")]
		none,
		// Token: 0x0400371F RID: 14111
		[Token(Token = "0x400371F")]
		cheerSmall,
		// Token: 0x04003720 RID: 14112
		[Token(Token = "0x4003720")]
		cheerMedium,
		// Token: 0x04003721 RID: 14113
		[Token(Token = "0x4003721")]
		cheerLarge,
		// Token: 0x04003722 RID: 14114
		[Token(Token = "0x4003722")]
		boo,
		// Token: 0x04003723 RID: 14115
		[Token(Token = "0x4003723")]
		nearMiss
	}

	// Token: 0x02000785 RID: 1925
	[Token(Token = "0x2000785")]
	public enum ParamApplicationMode
	{
		// Token: 0x04003725 RID: 14117
		[Token(Token = "0x4003725")]
		set,
		// Token: 0x04003726 RID: 14118
		[Token(Token = "0x4003726")]
		add
	}

	// Token: 0x02000786 RID: 1926
	[Token(Token = "0x2000786")]
	public enum FollowingIndexMode
	{
		// Token: 0x04003728 RID: 14120
		[Token(Token = "0x4003728")]
		next,
		// Token: 0x04003729 RID: 14121
		[Token(Token = "0x4003729")]
		goToIndex
	}
}
