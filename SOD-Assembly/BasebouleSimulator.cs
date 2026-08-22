using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000774 RID: 1908
[Token(Token = "0x2000774")]
public class BasebouleSimulator : MonoBehaviour
{
	// Token: 0x06002906 RID: 10502 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002906")]
	[Address(RVA = "0xC67820", Offset = "0xC66820", VA = "0x180C67820")]
	private void SimGame()
	{
	}

	// Token: 0x06002907 RID: 10503 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002907")]
	[Address(RVA = "0xC68230", Offset = "0xC67230", VA = "0x180C68230")]
	private void RollIntroduction()
	{
	}

	// Token: 0x06002908 RID: 10504 RVA: 0x0000F738 File Offset: 0x0000D938
	[Token(Token = "0x6002908")]
	[Address(RVA = "0xC68390", Offset = "0xC67390", VA = "0x180C68390")]
	private bool TryNextAd()
	{
		return default(bool);
	}

	// Token: 0x06002909 RID: 10505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002909")]
	[Address(RVA = "0xC684A0", Offset = "0xC674A0", VA = "0x180C684A0")]
	private void RollTeams()
	{
	}

	// Token: 0x0600290A RID: 10506 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600290A")]
	[Address(RVA = "0xC687D0", Offset = "0xC677D0", VA = "0x180C687D0")]
	private void RollPlayerOrder()
	{
	}

	// Token: 0x0600290B RID: 10507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600290B")]
	[Address(RVA = "0xC68900", Offset = "0xC67900", VA = "0x180C68900")]
	private void RollAdOrder()
	{
	}

	// Token: 0x0600290C RID: 10508 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600290C")]
	private int[] GetShuffledIndexesOfList<T>(List<T> listToShuffle)
	{
		return null;
	}

	// Token: 0x0600290D RID: 10509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600290D")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public BasebouleSimulator()
	{
	}

	// Token: 0x0600290E RID: 10510 RVA: 0x0000F750 File Offset: 0x0000D950
	[Token(Token = "0x600290E")]
	[Address(RVA = "0xC689A0", Offset = "0xC679A0", VA = "0x180C689A0")]
	private bool <RollTeams>b__20_0(BasebouleTeam x)
	{
		return default(bool);
	}

	// Token: 0x04003693 RID: 13971
	[Token(Token = "0x4003693")]
	[FieldOffset(Offset = "0x18")]
	public List<BasebouleTeam> availableTeams;

	// Token: 0x04003694 RID: 13972
	[Token(Token = "0x4003694")]
	[FieldOffset(Offset = "0x20")]
	public List<BasebouleGameIntro> availableIntros;

	// Token: 0x04003695 RID: 13973
	[Token(Token = "0x4003695")]
	[FieldOffset(Offset = "0x28")]
	public List<BasebouleGameLineUpFollowUp> availableFollowUps;

	// Token: 0x04003696 RID: 13974
	[Token(Token = "0x4003696")]
	[FieldOffset(Offset = "0x30")]
	public List<BasebouleGameIntroClosingStatement> availableIntroClosingStatements;

	// Token: 0x04003697 RID: 13975
	[Token(Token = "0x4003697")]
	[FieldOffset(Offset = "0x38")]
	public List<BasebouleGameAdvert> availableAdverts;

	// Token: 0x04003698 RID: 13976
	[Token(Token = "0x4003698")]
	[FieldOffset(Offset = "0x40")]
	public BasebouleTeam homeTeam;

	// Token: 0x04003699 RID: 13977
	[Token(Token = "0x4003699")]
	[FieldOffset(Offset = "0x48")]
	public BasebouleTeam awayTeam;

	// Token: 0x0400369A RID: 13978
	[Token(Token = "0x400369A")]
	[FieldOffset(Offset = "0x50")]
	private BasebouleGameData _basebouleGame;

	// Token: 0x0400369B RID: 13979
	[Token(Token = "0x400369B")]
	[FieldOffset(Offset = "0x58")]
	public int _introSelection;

	// Token: 0x0400369C RID: 13980
	[Token(Token = "0x400369C")]
	[FieldOffset(Offset = "0x5C")]
	public int _followUpSelection;

	// Token: 0x0400369D RID: 13981
	[Token(Token = "0x400369D")]
	[FieldOffset(Offset = "0x60")]
	public int _closingSelection;

	// Token: 0x0400369E RID: 13982
	[Token(Token = "0x400369E")]
	[FieldOffset(Offset = "0x64")]
	public int _homeTeamIndex;

	// Token: 0x0400369F RID: 13983
	[Token(Token = "0x400369F")]
	[FieldOffset(Offset = "0x68")]
	public int _awayTeamIndex;

	// Token: 0x040036A0 RID: 13984
	[Token(Token = "0x40036A0")]
	[FieldOffset(Offset = "0x70")]
	public int[] _homeRosterPlayerOrder;

	// Token: 0x040036A1 RID: 13985
	[Token(Token = "0x40036A1")]
	[FieldOffset(Offset = "0x78")]
	public int[] _awayRosterPlayerOrder;

	// Token: 0x040036A2 RID: 13986
	[Token(Token = "0x40036A2")]
	[FieldOffset(Offset = "0x80")]
	public int _adsPlayed;

	// Token: 0x040036A3 RID: 13987
	[Token(Token = "0x40036A3")]
	[FieldOffset(Offset = "0x88")]
	public int[] _adOrder;
}
