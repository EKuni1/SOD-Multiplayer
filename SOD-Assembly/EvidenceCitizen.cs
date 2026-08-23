using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x020006E7 RID: 1767
[Token(Token = "0x20006E7")]
public class EvidenceCitizen : EvidenceWitness
{
	// Token: 0x06002773 RID: 10099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002773")]
	[Address(RVA = "0xC04490", Offset = "0xC03490", VA = "0x180C04490")]
	public EvidenceCitizen(EvidencePreset newPreset, string evID, Controller newController, List<object> newPassedObjects)
	{
	}

	// Token: 0x06002774 RID: 10100 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002774")]
	[Address(RVA = "0xC045A0", Offset = "0xC035A0", VA = "0x180C045A0", Slot = "23")]
	public override string GetNote(List<Evidence.DataKey> keys)
	{
		return null;
	}

	// Token: 0x06002775 RID: 10101 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002775")]
	[Address(RVA = "0xC08780", Offset = "0xC07780", VA = "0x180C08780", Slot = "8")]
	public override string GenerateName()
	{
		return null;
	}

	// Token: 0x06002776 RID: 10102 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002776")]
	[Address(RVA = "0xC087B0", Offset = "0xC077B0", VA = "0x180C087B0", Slot = "19")]
	public override string GetNameForDataKey(List<Evidence.DataKey> inputKeys)
	{
		return null;
	}

	// Token: 0x06002777 RID: 10103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002777")]
	[Address(RVA = "0xC09240", Offset = "0xC08240", VA = "0x180C09240", Slot = "16")]
	public override void NamePhotoMerge()
	{
	}

	// Token: 0x06002778 RID: 10104 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6002778")]
	[Address(RVA = "0xC092A0", Offset = "0xC082A0", VA = "0x180C092A0", Slot = "24")]
	public override string GetNoteComposed(List<Evidence.DataKey> keys, bool useLinks = true)
	{
		return null;
	}

	// Token: 0x0400328F RID: 12943
	[Token(Token = "0x400328F")]
	[FieldOffset(Offset = "0x158")]
	public Human witnessController;

	// Token: 0x020006E8 RID: 1768
	[Token(Token = "0x20006E8")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600277A RID: 10106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277A")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x0000F018 File Offset: 0x0000D218
		[Token(Token = "0x600277B")]
		[Address(RVA = "0xC09450", Offset = "0xC08450", VA = "0x180C09450")]
		internal bool <GetNote>b__2_0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x0000F030 File Offset: 0x0000D230
		[Token(Token = "0x600277C")]
		[Address(RVA = "0xC09530", Offset = "0xC08530", VA = "0x180C09530")]
		internal bool <GetNote>b__2_1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04003290 RID: 12944
		[Token(Token = "0x4003290")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EvidenceCitizen.<>c <>9;

		// Token: 0x04003291 RID: 12945
		[Token(Token = "0x4003291")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Human.Trait> <>9__2_0;

		// Token: 0x04003292 RID: 12946
		[Token(Token = "0x4003292")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<Human.Trait> <>9__2_1;
	}

	// Token: 0x020006E9 RID: 1769
	[Token(Token = "0x20006E9")]
	private sealed class <>c__DisplayClass4_0
	{
		// Token: 0x0600277D RID: 10109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600277D")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass4_0()
		{
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x0000F048 File Offset: 0x0000D248
		[Token(Token = "0x600277E")]
		[Address(RVA = "0xC095C0", Offset = "0xC085C0", VA = "0x180C095C0")]
		internal bool <GetNameForDataKey>b__0(Evidence.DataKey item)
		{
			return default(bool);
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x0000F060 File Offset: 0x0000D260
		[Token(Token = "0x600277F")]
		[Address(RVA = "0xC09650", Offset = "0xC08650", VA = "0x180C09650")]
		internal bool <GetNameForDataKey>b__1(Evidence.DataKey item)
		{
			return default(bool);
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x0000F078 File Offset: 0x0000D278
		[Token(Token = "0x6002780")]
		[Address(RVA = "0xC096E0", Offset = "0xC086E0", VA = "0x180C096E0")]
		internal bool <GetNameForDataKey>b__2(Evidence.DataKey item)
		{
			return default(bool);
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x0000F090 File Offset: 0x0000D290
		[Token(Token = "0x6002781")]
		[Address(RVA = "0xC09770", Offset = "0xC08770", VA = "0x180C09770")]
		internal bool <GetNameForDataKey>b__3(Evidence.DataKey item)
		{
			return default(bool);
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		[Token(Token = "0x6002782")]
		[Address(RVA = "0xC09800", Offset = "0xC08800", VA = "0x180C09800")]
		internal bool <GetNameForDataKey>b__4(Evidence.DataKey item)
		{
			return default(bool);
		}

		// Token: 0x04003293 RID: 12947
		[Token(Token = "0x4003293")]
		[FieldOffset(Offset = "0x10")]
		public List<Evidence.DataKey> inputKeys;
	}
}
