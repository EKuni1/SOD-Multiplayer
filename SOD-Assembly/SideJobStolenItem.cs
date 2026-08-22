using System;
using Il2CppDummyDll;

// Token: 0x02000376 RID: 886
[Token(Token = "0x2000376")]
[Serializable]
public class SideJobStolenItem : SideJob
{
	// Token: 0x060013E4 RID: 5092 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E4")]
	[Address(RVA = "0x7A0BA0", Offset = "0x79FBA0", VA = "0x1807A0BA0")]
	public SideJobStolenItem(JobPreset newPreset, SideJobController.JobPickData newData, bool immediatePost)
	{
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E5")]
	[Address(RVA = "0x7A0D80", Offset = "0x79FD80", VA = "0x1807A0D80")]
	public void SimulateTheft()
	{
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E6")]
	[Address(RVA = "0x7A2100", Offset = "0x7A1100", VA = "0x1807A2100", Slot = "16")]
	public override void Complete()
	{
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E7")]
	[Address(RVA = "0x7A2260", Offset = "0x7A1260", VA = "0x1807A2260")]
	public void ReturnItem()
	{
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E8")]
	[Address(RVA = "0x7A2420", Offset = "0x7A1420", VA = "0x1807A2420", Slot = "32")]
	public override void DebugDisplayAnswers()
	{
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013E9")]
	[Address(RVA = "0x7A2700", Offset = "0x7A1700", VA = "0x1807A2700", Slot = "26")]
	public override void OnAcquireJobInfo(string infoDialogMessage)
	{
	}

	// Token: 0x04001838 RID: 6200
	[Token(Token = "0x4001838")]
	[FieldOffset(Offset = "0x170")]
	public float theftTime;

	// Token: 0x04001839 RID: 6201
	[Token(Token = "0x4001839")]
	[FieldOffset(Offset = "0x174")]
	public float theftTimeFrom;

	// Token: 0x0400183A RID: 6202
	[Token(Token = "0x400183A")]
	[FieldOffset(Offset = "0x178")]
	public float theftTimeTo;

	// Token: 0x0400183B RID: 6203
	[Token(Token = "0x400183B")]
	[FieldOffset(Offset = "0x17C")]
	public int stolenItemRoom;

	// Token: 0x02000377 RID: 887
	[Token(Token = "0x2000377")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060013EB RID: 5099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013EB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x000098A0 File Offset: 0x00007AA0
		[Token(Token = "0x60013EC")]
		[Address(RVA = "0x4E73D0", Offset = "0x4E63D0", VA = "0x1804E73D0")]
		internal bool <SimulateTheft>b__5_0(NewNode.NodeAccess item)
		{
			return default(bool);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x000098B8 File Offset: 0x00007AB8
		[Token(Token = "0x60013ED")]
		[Address(RVA = "0x7A2DD0", Offset = "0x7A1DD0", VA = "0x1807A2DD0")]
		internal bool <OnAcquireJobInfo>b__9_0(NewAddress item)
		{
			return default(bool);
		}

		// Token: 0x0400183C RID: 6204
		[Token(Token = "0x400183C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SideJobStolenItem.<>c <>9;

		// Token: 0x0400183D RID: 6205
		[Token(Token = "0x400183D")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<NewNode.NodeAccess> <>9__5_0;

		// Token: 0x0400183E RID: 6206
		[Token(Token = "0x400183E")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<NewAddress> <>9__9_0;
	}
}
