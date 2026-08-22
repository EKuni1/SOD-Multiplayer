using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000324 RID: 804
[Token(Token = "0x2000324")]
public class GroupsController : MonoBehaviour
{
	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06001229 RID: 4649 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700009E")]
	public static GroupsController Instance
	{
		[Token(Token = "0x6001229")]
		[Address(RVA = "0x6F8FE0", Offset = "0x6F7FE0", VA = "0x1806F8FE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600122A RID: 4650 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600122A")]
	[Address(RVA = "0x6F9040", Offset = "0x6F8040", VA = "0x1806F9040")]
	private void Awake()
	{
	}

	// Token: 0x0600122B RID: 4651 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600122B")]
	[Address(RVA = "0x6F93E0", Offset = "0x6F83E0", VA = "0x1806F93E0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600122C RID: 4652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600122C")]
	[Address(RVA = "0x6F9620", Offset = "0x6F8620", VA = "0x1806F9620")]
	public void CreateGroups()
	{
	}

	// Token: 0x0600122D RID: 4653 RVA: 0x00008AC0 File Offset: 0x00006CC0
	[Token(Token = "0x600122D")]
	[Address(RVA = "0x6FCB20", Offset = "0x6FBB20", VA = "0x1806FCB20")]
	public bool GetVmailGroupParticiapnts(GroupsController.SocialGroup group, GroupPreset.MeetUpVmailSender setting, out List<Human> particiapnts)
	{
		return default(bool);
	}

	// Token: 0x0600122E RID: 4654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600122E")]
	[Address(RVA = "0x6FD530", Offset = "0x6FC530", VA = "0x1806FD530")]
	public void LoadGroups()
	{
	}

	// Token: 0x0600122F RID: 4655 RVA: 0x00008AD8 File Offset: 0x00006CD8
	[Token(Token = "0x600122F")]
	[Address(RVA = "0x6FDB60", Offset = "0x6FCB60", VA = "0x1806FDB60")]
	public bool DecimalTimeFinder(GroupPreset g, List<Citizen> people, out float appropriateTime, out List<SessionData.WeekDay> availableDays)
	{
		return default(bool);
	}

	// Token: 0x06001230 RID: 4656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001230")]
	[Address(RVA = "0x6FE410", Offset = "0x6FD410", VA = "0x1806FE410")]
	public void ListCurrentMeetupLocations()
	{
	}

	// Token: 0x06001231 RID: 4657 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001231")]
	[Address(RVA = "0x6FEA60", Offset = "0x6FDA60", VA = "0x1806FEA60")]
	public GroupsController()
	{
	}

	// Token: 0x04001698 RID: 5784
	[Token(Token = "0x4001698")]
	[FieldOffset(Offset = "0x18")]
	public List<GroupsController.SocialGroup> groups;

	// Token: 0x04001699 RID: 5785
	[Token(Token = "0x4001699")]
	[FieldOffset(Offset = "0x0")]
	public static int assignID;

	// Token: 0x0400169A RID: 5786
	[Token(Token = "0x400169A")]
	[FieldOffset(Offset = "0x8")]
	private static GroupsController _instance;

	// Token: 0x02000325 RID: 805
	[Token(Token = "0x2000325")]
	[Serializable]
	public class SocialGroup
	{
		// Token: 0x06001233 RID: 4659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001233")]
		[Address(RVA = "0x6FEBA0", Offset = "0x6FDBA0", VA = "0x1806FEBA0")]
		public NewAddress GetMeetingPlace()
		{
			return null;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00008AF0 File Offset: 0x00006CF0
		[Token(Token = "0x6001234")]
		[Address(RVA = "0x6FEC40", Offset = "0x6FDC40", VA = "0x1806FEC40")]
		public float GetNextMeetingTime()
		{
			return 0f;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001235")]
		[Address(RVA = "0x6FED80", Offset = "0x6FDD80", VA = "0x1806FED80")]
		public GroupPreset GetPreset()
		{
			return null;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001236")]
		[Address(RVA = "0x6FEE10", Offset = "0x6FDE10", VA = "0x1806FEE10")]
		public SocialGroup()
		{
		}

		// Token: 0x0400169B RID: 5787
		[Token(Token = "0x400169B")]
		[FieldOffset(Offset = "0x10")]
		public string preset;

		// Token: 0x0400169C RID: 5788
		[Token(Token = "0x400169C")]
		[FieldOffset(Offset = "0x18")]
		public int id;

		// Token: 0x0400169D RID: 5789
		[Token(Token = "0x400169D")]
		[FieldOffset(Offset = "0x1C")]
		public float decimalStartTime;

		// Token: 0x0400169E RID: 5790
		[Token(Token = "0x400169E")]
		[FieldOffset(Offset = "0x20")]
		public List<SessionData.WeekDay> weekDays;

		// Token: 0x0400169F RID: 5791
		[Token(Token = "0x400169F")]
		[FieldOffset(Offset = "0x28")]
		public List<int> members;

		// Token: 0x040016A0 RID: 5792
		[Token(Token = "0x40016A0")]
		[FieldOffset(Offset = "0x30")]
		public int meetingPlace;

		// Token: 0x040016A1 RID: 5793
		[Token(Token = "0x40016A1")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public List<Interactable> reserved;
	}

	// Token: 0x02000326 RID: 806
	[Token(Token = "0x2000326")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x06001237 RID: 4663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001237")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x00008B08 File Offset: 0x00006D08
		[Token(Token = "0x6001238")]
		[Address(RVA = "0x6FEEE0", Offset = "0x6FDEE0", VA = "0x1806FEEE0")]
		internal bool <CreateGroups>b__0(Company item)
		{
			return default(bool);
		}

		// Token: 0x040016A2 RID: 5794
		[Token(Token = "0x40016A2")]
		[FieldOffset(Offset = "0x10")]
		public GroupPreset g;

		// Token: 0x040016A3 RID: 5795
		[Token(Token = "0x40016A3")]
		[FieldOffset(Offset = "0x18")]
		public Predicate<Company> <>9__0;
	}

	// Token: 0x02000327 RID: 807
	[Token(Token = "0x2000327")]
	private sealed class <>c__DisplayClass8_1
	{
		// Token: 0x06001239 RID: 4665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001239")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass8_1()
		{
		}

		// Token: 0x040016A4 RID: 5796
		[Token(Token = "0x40016A4")]
		[FieldOffset(Offset = "0x10")]
		public float startingDecimalHour;

		// Token: 0x040016A5 RID: 5797
		[Token(Token = "0x40016A5")]
		[FieldOffset(Offset = "0x18")]
		public GroupsController.<>c__DisplayClass8_0 CS$<>8__locals1;
	}

	// Token: 0x02000328 RID: 808
	[Token(Token = "0x2000328")]
	private sealed class <>c__DisplayClass8_2
	{
		// Token: 0x0600123A RID: 4666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600123A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass8_2()
		{
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00008B20 File Offset: 0x00006D20
		[Token(Token = "0x600123B")]
		[Address(RVA = "0x6FF050", Offset = "0x6FE050", VA = "0x1806FF050")]
		internal bool <CreateGroups>b__1(Company item)
		{
			return default(bool);
		}

		// Token: 0x040016A6 RID: 5798
		[Token(Token = "0x40016A6")]
		[FieldOffset(Offset = "0x10")]
		public SessionData.WeekDay d;

		// Token: 0x040016A7 RID: 5799
		[Token(Token = "0x40016A7")]
		[FieldOffset(Offset = "0x18")]
		public GroupsController.<>c__DisplayClass8_1 CS$<>8__locals2;
	}

	// Token: 0x02000329 RID: 809
	[Token(Token = "0x2000329")]
	private sealed class <>c__DisplayClass8_3
	{
		// Token: 0x0600123C RID: 4668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600123C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass8_3()
		{
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00008B38 File Offset: 0x00006D38
		[Token(Token = "0x600123D")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <CreateGroups>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x040016A8 RID: 5800
		[Token(Token = "0x40016A8")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait t;
	}
}
