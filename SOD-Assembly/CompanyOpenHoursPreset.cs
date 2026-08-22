using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007A7 RID: 1959
[Token(Token = "0x20007A7")]
public class CompanyOpenHoursPreset : SoCustomComparison
{
	// Token: 0x0600293E RID: 10558 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600293E")]
	[Address(RVA = "0xCA2110", Offset = "0xCA1110", VA = "0x180CA2110")]
	public CompanyOpenHoursPreset()
	{
	}

	// Token: 0x04003864 RID: 14436
	[Token(Token = "0x4003864")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 retailOpenHours;

	// Token: 0x04003865 RID: 14437
	[Token(Token = "0x4003865")]
	[FieldOffset(Offset = "0x28")]
	public bool monday;

	// Token: 0x04003866 RID: 14438
	[Token(Token = "0x4003866")]
	[FieldOffset(Offset = "0x29")]
	public bool tuesday;

	// Token: 0x04003867 RID: 14439
	[Token(Token = "0x4003867")]
	[FieldOffset(Offset = "0x2A")]
	public bool wednesday;

	// Token: 0x04003868 RID: 14440
	[Token(Token = "0x4003868")]
	[FieldOffset(Offset = "0x2B")]
	public bool thursday;

	// Token: 0x04003869 RID: 14441
	[Token(Token = "0x4003869")]
	[FieldOffset(Offset = "0x2C")]
	public bool friday;

	// Token: 0x0400386A RID: 14442
	[Token(Token = "0x400386A")]
	[FieldOffset(Offset = "0x2D")]
	public bool saturday;

	// Token: 0x0400386B RID: 14443
	[Token(Token = "0x400386B")]
	[FieldOffset(Offset = "0x2E")]
	public bool sunday;

	// Token: 0x0400386C RID: 14444
	[Token(Token = "0x400386C")]
	[FieldOffset(Offset = "0x30")]
	public List<CompanyOpenHoursPreset.CompanyShift> shifts;

	// Token: 0x020007A8 RID: 1960
	[Token(Token = "0x20007A8")]
	[Serializable]
	public class CompanyShift
	{
		// Token: 0x0600293F RID: 10559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600293F")]
		[Address(RVA = "0xCA21F0", Offset = "0xCA11F0", VA = "0x180CA21F0")]
		public CompanyShift()
		{
		}

		// Token: 0x0400386D RID: 14445
		[Token(Token = "0x400386D")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400386E RID: 14446
		[Token(Token = "0x400386E")]
		[FieldOffset(Offset = "0x18")]
		public OccupationPreset.ShiftType shiftType;

		// Token: 0x0400386F RID: 14447
		[Token(Token = "0x400386F")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 decimalHours;

		// Token: 0x04003870 RID: 14448
		[Token(Token = "0x4003870")]
		[FieldOffset(Offset = "0x24")]
		public bool monday;

		// Token: 0x04003871 RID: 14449
		[Token(Token = "0x4003871")]
		[FieldOffset(Offset = "0x25")]
		public bool tuesday;

		// Token: 0x04003872 RID: 14450
		[Token(Token = "0x4003872")]
		[FieldOffset(Offset = "0x26")]
		public bool wednesday;

		// Token: 0x04003873 RID: 14451
		[Token(Token = "0x4003873")]
		[FieldOffset(Offset = "0x27")]
		public bool thursday;

		// Token: 0x04003874 RID: 14452
		[Token(Token = "0x4003874")]
		[FieldOffset(Offset = "0x28")]
		public bool friday;

		// Token: 0x04003875 RID: 14453
		[Token(Token = "0x4003875")]
		[FieldOffset(Offset = "0x29")]
		public bool saturday;

		// Token: 0x04003876 RID: 14454
		[Token(Token = "0x4003876")]
		[FieldOffset(Offset = "0x2A")]
		public bool sunday;

		// Token: 0x04003877 RID: 14455
		[Token(Token = "0x4003877")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public List<Occupation> assigned;

		// Token: 0x04003878 RID: 14456
		[Token(Token = "0x4003878")]
		[FieldOffset(Offset = "0x38")]
		public int debugAssigned;
	}
}
