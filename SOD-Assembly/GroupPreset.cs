using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000800 RID: 2048
[Token(Token = "0x2000800")]
public class GroupPreset : SoCustomComparison
{
	// Token: 0x06002988 RID: 10632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002988")]
	[Address(RVA = "0xCA9240", Offset = "0xCA8240", VA = "0x180CA9240")]
	public GroupPreset()
	{
	}

	// Token: 0x04003C3B RID: 15419
	[Token(Token = "0x4003C3B")]
	[FieldOffset(Offset = "0x20")]
	public GroupPreset.GroupType groupType;

	// Token: 0x04003C3C RID: 15420
	[Token(Token = "0x4003C3C")]
	[FieldOffset(Offset = "0x24")]
	public float chance;

	// Token: 0x04003C3D RID: 15421
	[Token(Token = "0x4003C3D")]
	[FieldOffset(Offset = "0x28")]
	public int minMembers;

	// Token: 0x04003C3E RID: 15422
	[Token(Token = "0x4003C3E")]
	[FieldOffset(Offset = "0x2C")]
	public int maxMembers;

	// Token: 0x04003C3F RID: 15423
	[Token(Token = "0x4003C3F")]
	[FieldOffset(Offset = "0x30")]
	public List<CharacterTrait> requiredTraits;

	// Token: 0x04003C40 RID: 15424
	[Token(Token = "0x4003C40")]
	[FieldOffset(Offset = "0x38")]
	public float minimumExtraversion;

	// Token: 0x04003C41 RID: 15425
	[Token(Token = "0x4003C41")]
	[FieldOffset(Offset = "0x3C")]
	public bool enableMeetUps;

	// Token: 0x04003C42 RID: 15426
	[Token(Token = "0x4003C42")]
	[FieldOffset(Offset = "0x40")]
	public int daysPerWeek;

	// Token: 0x04003C43 RID: 15427
	[Token(Token = "0x4003C43")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 timeRange;

	// Token: 0x04003C44 RID: 15428
	[Token(Token = "0x4003C44")]
	[FieldOffset(Offset = "0x4C")]
	public float meetUpLength;

	// Token: 0x04003C45 RID: 15429
	[Token(Token = "0x4003C45")]
	[FieldOffset(Offset = "0x50")]
	public List<CompanyPreset> meetUpLocations;

	// Token: 0x04003C46 RID: 15430
	[Token(Token = "0x4003C46")]
	[FieldOffset(Offset = "0x58")]
	public AIGoalPreset meetUpGoal;

	// Token: 0x04003C47 RID: 15431
	[Token(Token = "0x4003C47")]
	[FieldOffset(Offset = "0x60")]
	public bool reserveSeats;

	// Token: 0x04003C48 RID: 15432
	[Token(Token = "0x4003C48")]
	[FieldOffset(Offset = "0x64")]
	public float useDistanceMultiplierModifier;

	// Token: 0x04003C49 RID: 15433
	[Token(Token = "0x4003C49")]
	[FieldOffset(Offset = "0x68")]
	public List<GroupPreset.ClubClue> clues;

	// Token: 0x04003C4A RID: 15434
	[Token(Token = "0x4003C4A")]
	[FieldOffset(Offset = "0x70")]
	public List<GroupPreset.MeetUpVmailThread> vmails;

	// Token: 0x02000801 RID: 2049
	[Token(Token = "0x2000801")]
	public enum GroupType
	{
		// Token: 0x04003C4C RID: 15436
		[Token(Token = "0x4003C4C")]
		interestGroup,
		// Token: 0x04003C4D RID: 15437
		[Token(Token = "0x4003C4D")]
		couples,
		// Token: 0x04003C4E RID: 15438
		[Token(Token = "0x4003C4E")]
		cheaters,
		// Token: 0x04003C4F RID: 15439
		[Token(Token = "0x4003C4F")]
		work
	}

	// Token: 0x02000802 RID: 2050
	[Token(Token = "0x2000802")]
	[Serializable]
	public class MeetUpVmailThread
	{
		// Token: 0x06002989 RID: 10633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002989")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public MeetUpVmailThread()
		{
		}

		// Token: 0x04003C50 RID: 15440
		[Token(Token = "0x4003C50")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04003C51 RID: 15441
		[Token(Token = "0x4003C51")]
		[FieldOffset(Offset = "0x18")]
		public string treeID;

		// Token: 0x04003C52 RID: 15442
		[Token(Token = "0x4003C52")]
		[FieldOffset(Offset = "0x20")]
		public GroupPreset.MeetUpVmailSender sender;

		// Token: 0x04003C53 RID: 15443
		[Token(Token = "0x4003C53")]
		[FieldOffset(Offset = "0x24")]
		public GroupPreset.MeetUpVmailSender recevier;
	}

	// Token: 0x02000803 RID: 2051
	[Token(Token = "0x2000803")]
	[Serializable]
	public class ClubClue
	{
		// Token: 0x0600298A RID: 10634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600298A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public ClubClue()
		{
		}

		// Token: 0x04003C54 RID: 15444
		[Token(Token = "0x4003C54")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04003C55 RID: 15445
		[Token(Token = "0x4003C55")]
		[FieldOffset(Offset = "0x18")]
		public InteractablePreset preset;

		// Token: 0x04003C56 RID: 15446
		[Token(Token = "0x4003C56")]
		[FieldOffset(Offset = "0x20")]
		public GroupPreset.SpawnAt spawnAt;
	}

	// Token: 0x02000804 RID: 2052
	[Token(Token = "0x2000804")]
	public enum SpawnAt
	{
		// Token: 0x04003C58 RID: 15448
		[Token(Token = "0x4003C58")]
		meetingPlace,
		// Token: 0x04003C59 RID: 15449
		[Token(Token = "0x4003C59")]
		leadersApartment,
		// Token: 0x04003C5A RID: 15450
		[Token(Token = "0x4003C5A")]
		entireGroupsApartments
	}

	// Token: 0x02000805 RID: 2053
	[Token(Token = "0x2000805")]
	public enum MeetUpVmailSender
	{
		// Token: 0x04003C5C RID: 15452
		[Token(Token = "0x4003C5C")]
		groupLeader,
		// Token: 0x04003C5D RID: 15453
		[Token(Token = "0x4003C5D")]
		groupRandom,
		// Token: 0x04003C5E RID: 15454
		[Token(Token = "0x4003C5E")]
		meetupPlace,
		// Token: 0x04003C5F RID: 15455
		[Token(Token = "0x4003C5F")]
		entireGroup,
		// Token: 0x04003C60 RID: 15456
		[Token(Token = "0x4003C60")]
		prioritiseFaithful
	}
}
