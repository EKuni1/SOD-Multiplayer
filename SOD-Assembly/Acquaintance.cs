using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020000E0 RID: 224
[Token(Token = "0x20000E0")]
public class Acquaintance : IEnumerator<object>
{
	// Token: 0x06000659 RID: 1625 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000659")]
	[Address(RVA = "0xE15840", Offset = "0xE14840", VA = "0x180E15840")]
	public Acquaintance(Human newFrom, Human newWith, float newKnown, Acquaintance.ConnectionType newConnection, Acquaintance.ConnectionType newSecretConnection, GroupsController.SocialGroup newGroup)
	{
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600065A")]
	[Address(RVA = "0xE15BE0", Offset = "0xE14BE0", VA = "0x180E15BE0")]
	public void AddConnection(float newKnown, Acquaintance.ConnectionType newConnection)
	{
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600065B")]
	[Address(RVA = "0xE15D90", Offset = "0xE14D90", VA = "0x180E15D90")]
	public Acquaintance(CitySaveData.AcquaintanceCitySave data)
	{
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600065C")]
	[Address(RVA = "0xE16610", Offset = "0xE15610", VA = "0x180E16610")]
	public void SetupFacts()
	{
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00004A40 File Offset: 0x00002C40
	[Token(Token = "0x600065D")]
	[Address(RVA = "0xE179C0", Offset = "0xE169C0", VA = "0x180E179C0")]
	public float CalculateCompatible()
	{
		return 0f;
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600065E")]
	[Address(RVA = "0xE17B60", Offset = "0xE16B60", VA = "0x180E17B60")]
	public Human GetOther(Human other)
	{
		return null;
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600065F")]
	[Address(RVA = "0xE17D40", Offset = "0xE16D40", VA = "0x180E17D40")]
	public void AddKnow(float plusKnow)
	{
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000660")]
	[Address(RVA = "0xE17D80", Offset = "0xE16D80", VA = "0x180E17D80")]
	public void CalculateLike()
	{
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000661")]
	[Address(RVA = "0xE17E40", Offset = "0xE16E40", VA = "0x180E17E40")]
	public void OthersKnowledgeUpdate()
	{
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00004A58 File Offset: 0x00002C58
	[Token(Token = "0x6000662")]
	[Address(RVA = "0xE18FC0", Offset = "0xE17FC0", VA = "0x180E18FC0", Slot = "4")]
	public int CompareTo(Acquaintance comp)
	{
		return 0;
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000663")]
	[Address(RVA = "0xE19040", Offset = "0xE18040", VA = "0x180E19040")]
	public CitySaveData.AcquaintanceCitySave GenerateSaveData()
	{
		return null;
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x00004A70 File Offset: 0x00002C70
	[Token(Token = "0x6000665")]
	[Address(RVA = "0xE19480", Offset = "0xE18480", VA = "0x180E19480")]
	private bool <SetupFacts>b__15_0(Acquaintance item)
	{
		return default(bool);
	}

	// Token: 0x04000681 RID: 1665
	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0x10")]
	public Human from;

	// Token: 0x04000682 RID: 1666
	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0x18")]
	public Human with;

	// Token: 0x04000683 RID: 1667
	[Token(Token = "0x4000683")]
	[FieldOffset(Offset = "0x20")]
	public Acquaintance.ConnectionType secretConnection;

	// Token: 0x04000684 RID: 1668
	[Token(Token = "0x4000684")]
	[FieldOffset(Offset = "0x24")]
	public float compatible;

	// Token: 0x04000685 RID: 1669
	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0x28")]
	public float known;

	// Token: 0x04000686 RID: 1670
	[Token(Token = "0x4000686")]
	[FieldOffset(Offset = "0x2C")]
	public float like;

	// Token: 0x04000687 RID: 1671
	[Token(Token = "0x4000687")]
	[FieldOffset(Offset = "0x30")]
	[NonSerialized]
	public GroupsController.SocialGroup group;

	// Token: 0x04000688 RID: 1672
	[Token(Token = "0x4000688")]
	[FieldOffset(Offset = "0x38")]
	public List<Acquaintance.ConnectionType> connections;

	// Token: 0x04000689 RID: 1673
	[Token(Token = "0x4000689")]
	[FieldOffset(Offset = "0x40")]
	public float customSort;

	// Token: 0x0400068A RID: 1674
	[Token(Token = "0x400068A")]
	[FieldOffset(Offset = "0x48")]
	public List<Evidence.DataKey> dataKeys;

	// Token: 0x0400068B RID: 1675
	[Token(Token = "0x400068B")]
	[FieldOffset(Offset = "0x50")]
	public List<Fact> connectionFacts;

	// Token: 0x0400068C RID: 1676
	[Token(Token = "0x400068C")]
	[FieldOffset(Offset = "0x0")]
	public static Comparison<Acquaintance> customComparison;

	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	public enum ConnectionType
	{
		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		friend,
		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		neighbor,
		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		housemate,
		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		lover,
		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		boss,
		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		workTeam,
		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		workOther,
		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		regularCustomer,
		// Token: 0x04000696 RID: 1686
		[Token(Token = "0x4000696")]
		regularStaff,
		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000697")]
		familiarResidence,
		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		familiarWork,
		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000699")]
		publicFigure,
		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		stranger,
		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		paramour,
		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		player,
		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		anyoneNotPlayer,
		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		friendOrWork,
		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		knowsName,
		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		anyAcquaintance,
		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		anyone,
		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		workNotBoss,
		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		relationshipMatch,
		// Token: 0x040006A4 RID: 1700
		[Token(Token = "0x40006A4")]
		corpDove,
		// Token: 0x040006A5 RID: 1701
		[Token(Token = "0x40006A5")]
		spamVmail,
		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x40006A6")]
		corpStarch,
		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		corpIndigo,
		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		corpKaizen,
		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		corpElgen,
		// Token: 0x040006AA RID: 1706
		[Token(Token = "0x40006AA")]
		corpCandor,
		// Token: 0x040006AB RID: 1707
		[Token(Token = "0x40006AB")]
		flairQuotes,
		// Token: 0x040006AC RID: 1708
		[Token(Token = "0x40006AC")]
		randomSpamVmail,
		// Token: 0x040006AD RID: 1709
		[Token(Token = "0x40006AD")]
		noReplyVmail,
		// Token: 0x040006AE RID: 1710
		[Token(Token = "0x40006AE")]
		bookGrubs,
		// Token: 0x040006AF RID: 1711
		[Token(Token = "0x40006AF")]
		pestControl,
		// Token: 0x040006B0 RID: 1712
		[Token(Token = "0x40006B0")]
		landlord,
		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x40006B1")]
		groupMember,
		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x40006B2")]
		storyPartner
	}

	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x06000666 RID: 1638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x599460", Offset = "0x598460", VA = "0x180599460")]
		internal bool <.ctor>b__0(Citizen item)
		{
			return default(bool);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x6000668")]
		[Address(RVA = "0xE19630", Offset = "0xE18630", VA = "0x180E19630")]
		internal bool <.ctor>b__1(Citizen item)
		{
			return default(bool);
		}

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0x10")]
		public CitySaveData.AcquaintanceCitySave data;
	}

	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	private sealed class <>c__DisplayClass15_0
	{
		// Token: 0x06000669 RID: 1641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass15_0()
		{
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x600066A")]
		[Address(RVA = "0xE19660", Offset = "0xE18660", VA = "0x180E19660")]
		internal bool <SetupFacts>b__1(Acquaintance item)
		{
			return default(bool);
		}

		// Token: 0x040006B4 RID: 1716
		[Token(Token = "0x40006B4")]
		[FieldOffset(Offset = "0x10")]
		public Acquaintance.ConnectionType conn;

		// Token: 0x040006B5 RID: 1717
		[Token(Token = "0x40006B5")]
		[FieldOffset(Offset = "0x18")]
		public Acquaintance <>4__this;
	}

	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600066C RID: 1644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x600066D")]
		[Address(RVA = "0xE19910", Offset = "0xE18910", VA = "0x180E19910")]
		internal int <.cctor>b__24_0(Acquaintance object1, Acquaintance object2)
		{
			return 0;
		}

		// Token: 0x040006B6 RID: 1718
		[Token(Token = "0x40006B6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Acquaintance.<>c <>9;
	}
}
