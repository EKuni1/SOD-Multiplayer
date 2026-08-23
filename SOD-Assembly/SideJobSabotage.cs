using System;
using Il2CppDummyDll;

// Token: 0x02000371 RID: 881
[Token(Token = "0x2000371")]
[Serializable]
public class SideJobSabotage : SideJob
{
	// Token: 0x060013C4 RID: 5060 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C4")]
	[Address(RVA = "0x79A420", Offset = "0x799420", VA = "0x18079A420")]
	public SideJobSabotage(JobPreset newPreset, SideJobController.JobPickData newData, bool immediatePost)
	{
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C5")]
	[Address(RVA = "0x79A4C0", Offset = "0x7994C0", VA = "0x18079A4C0", Slot = "8")]
	public override void GameWorldLoop()
	{
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013C6")]
	[Address(RVA = "0x79B8E0", Offset = "0x79A8E0", VA = "0x18079B8E0", Slot = "28")]
	public override void UpdateResolveAnswers()
	{
	}

	// Token: 0x0400181E RID: 6174
	[Token(Token = "0x400181E")]
	[FieldOffset(Offset = "0x170")]
	public NewAddress chosenAddress;

	// Token: 0x0400181F RID: 6175
	[Token(Token = "0x400181F")]
	[FieldOffset(Offset = "0x178")]
	public float callTime;

	// Token: 0x04001820 RID: 6176
	[Token(Token = "0x4001820")]
	[FieldOffset(Offset = "0x17C")]
	private bool callTriggered;

	// Token: 0x04001821 RID: 6177
	[Token(Token = "0x4001821")]
	[FieldOffset(Offset = "0x180")]
	private TelephoneController.PhoneCall call;

	// Token: 0x04001822 RID: 6178
	[Token(Token = "0x4001822")]
	[FieldOffset(Offset = "0x188")]
	private Objective.ObjectiveTrigger getToPhone;

	// Token: 0x02000372 RID: 882
	[Token(Token = "0x2000372")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060013C8 RID: 5064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00009738 File Offset: 0x00007938
		[Token(Token = "0x60013C9")]
		[Address(RVA = "0x79BD90", Offset = "0x79AD90", VA = "0x18079BD90")]
		internal bool <GameWorldLoop>b__6_0(Telephone item)
		{
			return default(bool);
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00009750 File Offset: 0x00007950
		[Token(Token = "0x60013CA")]
		[Address(RVA = "0x79BDC0", Offset = "0x79ADC0", VA = "0x18079BDC0")]
		internal bool <GameWorldLoop>b__6_1(Telephone item)
		{
			return default(bool);
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00009768 File Offset: 0x00007968
		[Token(Token = "0x60013CB")]
		[Address(RVA = "0x657030", Offset = "0x656030", VA = "0x180657030")]
		internal bool <GameWorldLoop>b__6_2(Telephone item)
		{
			return default(bool);
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x00009780 File Offset: 0x00007980
		[Token(Token = "0x60013CC")]
		[Address(RVA = "0x79BF30", Offset = "0x79AF30", VA = "0x18079BF30")]
		internal bool <UpdateResolveAnswers>b__7_0(Case.ResolveQuestion item)
		{
			return default(bool);
		}

		// Token: 0x04001823 RID: 6179
		[Token(Token = "0x4001823")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SideJobSabotage.<>c <>9;

		// Token: 0x04001824 RID: 6180
		[Token(Token = "0x4001824")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Telephone> <>9__6_0;

		// Token: 0x04001825 RID: 6181
		[Token(Token = "0x4001825")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<Telephone> <>9__6_1;

		// Token: 0x04001826 RID: 6182
		[Token(Token = "0x4001826")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<Telephone> <>9__6_2;

		// Token: 0x04001827 RID: 6183
		[Token(Token = "0x4001827")]
		[FieldOffset(Offset = "0x20")]
		public static Predicate<Case.ResolveQuestion> <>9__7_0;
	}
}
