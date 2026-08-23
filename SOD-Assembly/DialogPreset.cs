using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x020007C3 RID: 1987
[Token(Token = "0x20007C3")]
public class DialogPreset : SoCustomComparison
{
	// Token: 0x06002953 RID: 10579 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
	[Token(Token = "0x6002953")]
	[Address(RVA = "0xCA3350", Offset = "0xCA2350", VA = "0x180CA3350")]
	public int GetCost(Actor talkingTo, [Optional] Actor talking)
	{
		return 0;
	}

	// Token: 0x06002954 RID: 10580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002954")]
	[Address(RVA = "0xCA37C0", Offset = "0xCA27C0", VA = "0x180CA37C0")]
	public DialogPreset()
	{
	}

	// Token: 0x04003926 RID: 14630
	[Token(Token = "0x4003926")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string msgID;

	// Token: 0x04003927 RID: 14631
	[Token(Token = "0x4003927")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool defaultOption;

	// Token: 0x04003928 RID: 14632
	[Token(Token = "0x4003928")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool telephoneCallOption;

	// Token: 0x04003929 RID: 14633
	[Token(Token = "0x4003929")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool hospitalDecisionOption;

	// Token: 0x0400392A RID: 14634
	[Token(Token = "0x400392A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Evidence.DataKey tiedToKey;

	// Token: 0x0400392B RID: 14635
	[Token(Token = "0x400392B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int ranking;

	// Token: 0x0400392C RID: 14636
	[Token(Token = "0x400392C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool removeAfterSaying;

	// Token: 0x0400392D RID: 14637
	[Token(Token = "0x400392D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool dailyReplenish;

	// Token: 0x0400392E RID: 14638
	[Token(Token = "0x400392E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	public bool isJobDetails;

	// Token: 0x0400392F RID: 14639
	[Token(Token = "0x400392F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
	public bool ignoreActiveJobRequirement;

	// Token: 0x04003930 RID: 14640
	[Token(Token = "0x4003930")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public DialogPreset.SpecialCase specialCase;

	// Token: 0x04003931 RID: 14641
	[Token(Token = "0x4003931")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int cost;

	// Token: 0x04003932 RID: 14642
	[Token(Token = "0x4003932")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool usePercentageCost;

	// Token: 0x04003933 RID: 14643
	[Token(Token = "0x4003933")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool useAllWealthIfNotEnough;

	// Token: 0x04003934 RID: 14644
	[Token(Token = "0x4003934")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public bool displayIfPasswordUnknown;

	// Token: 0x04003935 RID: 14645
	[Token(Token = "0x4003935")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public DialogPreset.InputSetting inputBox;

	// Token: 0x04003936 RID: 14646
	[Token(Token = "0x4003936")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool displayAsIllegal;

	// Token: 0x04003937 RID: 14647
	[Token(Token = "0x4003937")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string preceedingSyntax;

	// Token: 0x04003938 RID: 14648
	[Token(Token = "0x4003938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string followingSyntax;

	// Token: 0x04003939 RID: 14649
	[Token(Token = "0x4003939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool useSuccessTest;

	// Token: 0x0400393A RID: 14650
	[Token(Token = "0x400393A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool requiresPassword;

	// Token: 0x0400393B RID: 14651
	[Token(Token = "0x400393B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float baseChance;

	// Token: 0x0400393C RID: 14652
	[Token(Token = "0x400393C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float affectChanceIfRestrained;

	// Token: 0x0400393D RID: 14653
	[Token(Token = "0x400393D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<CharacterTrait.TraitPickRule> modifySuccessChanceTraits;

	// Token: 0x0400393E RID: 14654
	[Token(Token = "0x400393E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<AIActionPreset.AISpeechPreset> responses;

	// Token: 0x0400393F RID: 14655
	[Token(Token = "0x400393F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<DialogPreset> followUpDialogSuccess;

	// Token: 0x04003940 RID: 14656
	[Token(Token = "0x4003940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<DialogPreset> followUpDialogFail;

	// Token: 0x04003941 RID: 14657
	[Token(Token = "0x4003941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<DialogPreset> removeDialog;

	// Token: 0x04003942 RID: 14658
	[Token(Token = "0x4003942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<DialogPreset> removeDialogOnSuccess;

	// Token: 0x04003943 RID: 14659
	[Token(Token = "0x4003943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<DialogPreset> removeDialogOnFail;

	// Token: 0x020007C4 RID: 1988
	[Token(Token = "0x20007C4")]
	public enum InputSetting
	{
		// Token: 0x04003945 RID: 14661
		[Token(Token = "0x4003945")]
		none,
		// Token: 0x04003946 RID: 14662
		[Token(Token = "0x4003946")]
		addressPassword
	}

	// Token: 0x020007C5 RID: 1989
	[Token(Token = "0x20007C5")]
	public enum SpecialCase
	{
		// Token: 0x04003948 RID: 14664
		[Token(Token = "0x4003948")]
		none,
		// Token: 0x04003949 RID: 14665
		[Token(Token = "0x4003949")]
		backroomBribe,
		// Token: 0x0400394A RID: 14666
		[Token(Token = "0x400394A")]
		publicFacingWorkplace,
		// Token: 0x0400394B RID: 14667
		[Token(Token = "0x400394B")]
		working,
		// Token: 0x0400394C RID: 14668
		[Token(Token = "0x400394C")]
		workingGuestPass,
		// Token: 0x0400394D RID: 14669
		[Token(Token = "0x400394D")]
		callInSuspect,
		// Token: 0x0400394E RID: 14670
		[Token(Token = "0x400394E")]
		talkingToJobPoster,
		// Token: 0x0400394F RID: 14671
		[Token(Token = "0x400394F")]
		inputName,
		// Token: 0x04003950 RID: 14672
		[Token(Token = "0x4003950")]
		lastCaller,
		// Token: 0x04003951 RID: 14673
		[Token(Token = "0x4003951")]
		knowName,
		// Token: 0x04003952 RID: 14674
		[Token(Token = "0x4003952")]
		lookAroundHome,
		// Token: 0x04003953 RID: 14675
		[Token(Token = "0x4003953")]
		returnJobItemA,
		// Token: 0x04003954 RID: 14676
		[Token(Token = "0x4003954")]
		medicalCosts,
		// Token: 0x04003955 RID: 14677
		[Token(Token = "0x4003955")]
		starchPitch,
		// Token: 0x04003956 RID: 14678
		[Token(Token = "0x4003956")]
		mugging,
		// Token: 0x04003957 RID: 14679
		[Token(Token = "0x4003957")]
		neverDisplay,
		// Token: 0x04003958 RID: 14680
		[Token(Token = "0x4003958")]
		loanSharkAccept,
		// Token: 0x04003959 RID: 14681
		[Token(Token = "0x4003959")]
		loanSharkPayment,
		// Token: 0x0400395A RID: 14682
		[Token(Token = "0x400395A")]
		loanSharkPaymentRefuse,
		// Token: 0x0400395B RID: 14683
		[Token(Token = "0x400395B")]
		loanSharkAsk,
		// Token: 0x0400395C RID: 14684
		[Token(Token = "0x400395C")]
		revealHiddenitemPhoto,
		// Token: 0x0400395D RID: 14685
		[Token(Token = "0x400395D")]
		hotelBill,
		// Token: 0x0400395E RID: 14686
		[Token(Token = "0x400395E")]
		rentHotelRoomCheap,
		// Token: 0x0400395F RID: 14687
		[Token(Token = "0x400395F")]
		rentHotelRoomExpensive,
		// Token: 0x04003960 RID: 14688
		[Token(Token = "0x4003960")]
		hotelCheckOut,
		// Token: 0x04003961 RID: 14689
		[Token(Token = "0x4003961")]
		hotelRentRoom,
		// Token: 0x04003962 RID: 14690
		[Token(Token = "0x4003962")]
		mustHaveRoomAtHotel,
		// Token: 0x04003963 RID: 14691
		[Token(Token = "0x4003963")]
		mustBeMurdererForSuccess,
		// Token: 0x04003964 RID: 14692
		[Token(Token = "0x4003964")]
		killerCleanUp,
		// Token: 0x04003965 RID: 14693
		[Token(Token = "0x4003965")]
		killerCleanUpAccept,
		// Token: 0x04003966 RID: 14694
		[Token(Token = "0x4003966")]
		killerCleanUpReject,
		// Token: 0x04003967 RID: 14695
		[Token(Token = "0x4003967")]
		killerCleanUpSuccess,
		// Token: 0x04003968 RID: 14696
		[Token(Token = "0x4003968")]
		ransomInvestigate,
		// Token: 0x04003969 RID: 14697
		[Token(Token = "0x4003969")]
		kidnapperOnly,
		// Token: 0x0400396A RID: 14698
		[Token(Token = "0x400396A")]
		fameAndFortune
	}

	// Token: 0x020007C6 RID: 1990
	[Token(Token = "0x20007C6")]
	private sealed class <>c__DisplayClass32_0
	{
		// Token: 0x06002955 RID: 10581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002955")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass32_0()
		{
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		[Token(Token = "0x6002956")]
		[Address(RVA = "0x4AD1F0", Offset = "0x4AC1F0", VA = "0x1804AD1F0")]
		internal bool <GetCost>b__0(GameplayController.LoanDebt item)
		{
			return default(bool);
		}

		// Token: 0x0400396B RID: 14699
		[Token(Token = "0x400396B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Human hu;
	}
}
