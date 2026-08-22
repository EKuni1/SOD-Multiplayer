using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000373 RID: 883
[Token(Token = "0x2000373")]
[Serializable]
public class SideJobStealBriefcase : SideJob
{
	// Token: 0x060013CD RID: 5069 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013CD")]
	[Address(RVA = "0x79BF50", Offset = "0x79AF50", VA = "0x18079BF50")]
	public SideJobStealBriefcase(JobPreset newPreset, SideJobController.JobPickData newData, bool immediatePost)
	{
	}

	// Token: 0x060013CE RID: 5070 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013CE")]
	[Address(RVA = "0x79BFE0", Offset = "0x79AFE0", VA = "0x18079BFE0")]
	private void PickMeet()
	{
	}

	// Token: 0x060013CF RID: 5071 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013CF")]
	[Address(RVA = "0x79CFD0", Offset = "0x79BFD0", VA = "0x18079CFD0", Slot = "12")]
	public override void OnGooseChaseSuccess()
	{
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D0")]
	[Address(RVA = "0x79D0B0", Offset = "0x79C0B0", VA = "0x18079D0B0")]
	public void SetupCarrier()
	{
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D1")]
	[Address(RVA = "0x79DAD0", Offset = "0x79CAD0", VA = "0x18079DAD0", Slot = "26")]
	public override void OnAcquireJobInfo(string infoDialogMessage)
	{
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013D2")]
	[Address(RVA = "0x79DB90", Offset = "0x79CB90", VA = "0x18079DB90")]
	public NewNode GetLocationNode()
	{
		return null;
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60013D3")]
	[Address(RVA = "0x79DD20", Offset = "0x79CD20", VA = "0x18079DD20", Slot = "14")]
	public override Human GetExtraPerson1()
	{
		return null;
	}

	// Token: 0x060013D4 RID: 5076 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D4")]
	[Address(RVA = "0x79DE90", Offset = "0x79CE90", VA = "0x18079DE90", Slot = "8")]
	public override void GameWorldLoop()
	{
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x79FA60", Offset = "0x79EA60", VA = "0x18079FA60", Slot = "28")]
	public override void UpdateResolveAnswers()
	{
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x7A0250", Offset = "0x79F250", VA = "0x1807A0250", Slot = "31")]
	public override void OnDestroyMissionObject(Interactable destroyed)
	{
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x00009798 File Offset: 0x00007998
	[Token(Token = "0x60013D7")]
	[Address(RVA = "0x7A0260", Offset = "0x79F260", VA = "0x1807A0260")]
	private bool <SetupCarrier>b__13_0(Citizen item)
	{
		return default(bool);
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x000097B0 File Offset: 0x000079B0
	[Token(Token = "0x60013D8")]
	[Address(RVA = "0x7A04A0", Offset = "0x79F4A0", VA = "0x1807A04A0")]
	private bool <GameWorldLoop>b__17_3(NewAIGoal item)
	{
		return default(bool);
	}

	// Token: 0x060013D9 RID: 5081 RVA: 0x000097C8 File Offset: 0x000079C8
	[Token(Token = "0x60013D9")]
	[Address(RVA = "0x7A0570", Offset = "0x79F570", VA = "0x1807A0570")]
	private bool <GameWorldLoop>b__17_4(NewAIGoal item)
	{
		return default(bool);
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x000097E0 File Offset: 0x000079E0
	[Token(Token = "0x60013DA")]
	[Address(RVA = "0x7A0640", Offset = "0x79F640", VA = "0x1807A0640")]
	private bool <GameWorldLoop>b__17_0(NewAIController.TrackingTarget item)
	{
		return default(bool);
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x000097F8 File Offset: 0x000079F8
	[Token(Token = "0x60013DB")]
	[Address(RVA = "0x7A07F0", Offset = "0x79F7F0", VA = "0x1807A07F0")]
	private bool <GameWorldLoop>b__17_1(NewAIController.TrackingTarget item)
	{
		return default(bool);
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x00009810 File Offset: 0x00007A10
	[Token(Token = "0x60013DC")]
	[Address(RVA = "0x74B170", Offset = "0x74A170", VA = "0x18074B170")]
	private bool <UpdateResolveAnswers>b__18_2(SceneRecorder.ActorCapture item)
	{
		return default(bool);
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x00009828 File Offset: 0x00007A28
	[Token(Token = "0x60013DD")]
	[Address(RVA = "0x7A09A0", Offset = "0x79F9A0", VA = "0x1807A09A0")]
	private bool <UpdateResolveAnswers>b__18_3(SceneRecorder.ActorCapture item)
	{
		return default(bool);
	}

	// Token: 0x04001828 RID: 6184
	[Token(Token = "0x4001828")]
	[FieldOffset(Offset = "0x170")]
	public int carrier;

	// Token: 0x04001829 RID: 6185
	[Token(Token = "0x4001829")]
	[FieldOffset(Offset = "0x174")]
	public Vector3Int meetNodeLocation;

	// Token: 0x0400182A RID: 6186
	[Token(Token = "0x400182A")]
	[FieldOffset(Offset = "0x180")]
	public bool triggeredSwitch;

	// Token: 0x0400182B RID: 6187
	[Token(Token = "0x400182B")]
	[FieldOffset(Offset = "0x181")]
	public bool triggeredMeet;

	// Token: 0x0400182C RID: 6188
	[Token(Token = "0x400182C")]
	[FieldOffset(Offset = "0x184")]
	public float meetTimer;

	// Token: 0x0400182D RID: 6189
	[Token(Token = "0x400182D")]
	[FieldOffset(Offset = "0x188")]
	[NonSerialized]
	public Human caseCarrier;

	// Token: 0x0400182E RID: 6190
	[Token(Token = "0x400182E")]
	[FieldOffset(Offset = "0x190")]
	[NonSerialized]
	public NewNode destination;

	// Token: 0x0400182F RID: 6191
	[Token(Token = "0x400182F")]
	[FieldOffset(Offset = "0x198")]
	private float gwTime;

	// Token: 0x04001830 RID: 6192
	[Token(Token = "0x4001830")]
	[FieldOffset(Offset = "0x1A0")]
	private Objective waitObjective;

	// Token: 0x02000374 RID: 884
	[Token(Token = "0x2000374")]
	public struct NodeCompare
	{
		// Token: 0x04001831 RID: 6193
		[Token(Token = "0x4001831")]
		[FieldOffset(Offset = "0x0")]
		public NewNode node;

		// Token: 0x04001832 RID: 6194
		[Token(Token = "0x4001832")]
		[FieldOffset(Offset = "0x8")]
		public float score;
	}

	// Token: 0x02000375 RID: 885
	[Token(Token = "0x2000375")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060013DF RID: 5087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00009840 File Offset: 0x00007A40
		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x7A0A70", Offset = "0x79FA70", VA = "0x1807A0A70")]
		internal int <PickMeet>b__11_0(SideJobStealBriefcase.NodeCompare p1, SideJobStealBriefcase.NodeCompare p2)
		{
			return 0;
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00009858 File Offset: 0x00007A58
		[Token(Token = "0x60013E1")]
		[Address(RVA = "0x7A0AF0", Offset = "0x79FAF0", VA = "0x1807A0AF0")]
		internal bool <GameWorldLoop>b__17_2(Objective item)
		{
			return default(bool);
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00009870 File Offset: 0x00007A70
		[Token(Token = "0x60013E2")]
		[Address(RVA = "0x7A0B80", Offset = "0x79FB80", VA = "0x1807A0B80")]
		internal bool <UpdateResolveAnswers>b__18_0(Case.ResolveQuestion item)
		{
			return default(bool);
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00009888 File Offset: 0x00007A88
		[Token(Token = "0x60013E3")]
		[Address(RVA = "0x7923E0", Offset = "0x7913E0", VA = "0x1807923E0")]
		internal bool <UpdateResolveAnswers>b__18_1(Interactable item)
		{
			return default(bool);
		}

		// Token: 0x04001833 RID: 6195
		[Token(Token = "0x4001833")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SideJobStealBriefcase.<>c <>9;

		// Token: 0x04001834 RID: 6196
		[Token(Token = "0x4001834")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<SideJobStealBriefcase.NodeCompare> <>9__11_0;

		// Token: 0x04001835 RID: 6197
		[Token(Token = "0x4001835")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<Objective> <>9__17_2;

		// Token: 0x04001836 RID: 6198
		[Token(Token = "0x4001836")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<Case.ResolveQuestion> <>9__18_0;

		// Token: 0x04001837 RID: 6199
		[Token(Token = "0x4001837")]
		[FieldOffset(Offset = "0x20")]
		public static Predicate<Interactable> <>9__18_1;
	}
}
