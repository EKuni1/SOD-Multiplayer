using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000362 RID: 866
[Token(Token = "0x2000362")]
public class SideJobController : MonoBehaviour
{
	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x06001396 RID: 5014 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000A8")]
	public static SideJobController Instance
	{
		[Token(Token = "0x6001396")]
		[Address(RVA = "0x792A80", Offset = "0x791A80", VA = "0x180792A80")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001397")]
	[Address(RVA = "0x792AC0", Offset = "0x791AC0", VA = "0x180792AC0")]
	private void Awake()
	{
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001398")]
	[Address(RVA = "0x792E10", Offset = "0x791E10", VA = "0x180792E10")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001399")]
	[Address(RVA = "0x793020", Offset = "0x792020", VA = "0x180793020")]
	private void Start()
	{
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600139A")]
	[Address(RVA = "0x793620", Offset = "0x792620", VA = "0x180793620")]
	public void JobCreationCheck()
	{
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600139B")]
	[Address(RVA = "0x795EA0", Offset = "0x794EA0", VA = "0x180795EA0")]
	public void AddExemptFromPostersJob(Human cit, SideJob job)
	{
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600139C")]
	[Address(RVA = "0x796120", Offset = "0x795120", VA = "0x180796120")]
	public void AddExemptFromPurpJob(Human cit, SideJob job)
	{
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600139D")]
	[Address(RVA = "0x796470", Offset = "0x795470", VA = "0x180796470")]
	public void RemoveExemptFromPosters(Human cit, SideJob job)
	{
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600139E")]
	[Address(RVA = "0x796680", Offset = "0x795680", VA = "0x180796680")]
	public void RemoveExemptFromPurps(Human cit, SideJob job)
	{
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x00009618 File Offset: 0x00007818
	[Token(Token = "0x600139F")]
	[Address(RVA = "0x7968D0", Offset = "0x7958D0", VA = "0x1807968D0")]
	private bool MotivePass(ref List<MotivePreset.ModifierRule> rules, Citizen cit, out int score)
	{
		return default(bool);
	}

	// Token: 0x060013A0 RID: 5024 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A0")]
	[Address(RVA = "0x7972A0", Offset = "0x7962A0", VA = "0x1807972A0")]
	public void SideJobObjectiveComplete(SideJob job, Objective objective)
	{
	}

	// Token: 0x060013A1 RID: 5025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A1")]
	[Address(RVA = "0x797450", Offset = "0x796450", VA = "0x180797450")]
	public void DeadPeopleJobCheck()
	{
	}

	// Token: 0x060013A2 RID: 5026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A2")]
	[Address(RVA = "0x797B60", Offset = "0x796B60", VA = "0x180797B60")]
	public void CallPoster()
	{
	}

	// Token: 0x060013A3 RID: 5027 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A3")]
	[Address(RVA = "0x797BA0", Offset = "0x796BA0", VA = "0x180797BA0")]
	public void CallFake()
	{
	}

	// Token: 0x060013A4 RID: 5028 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A4")]
	[Address(RVA = "0x797BE0", Offset = "0x796BE0", VA = "0x180797BE0")]
	public void SabotageRecoverInfo()
	{
	}

	// Token: 0x060013A5 RID: 5029 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A5")]
	[Address(RVA = "0x797C20", Offset = "0x796C20", VA = "0x180797C20")]
	public void ListSpawnedItemsForJob()
	{
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A6")]
	[Address(RVA = "0x7985F0", Offset = "0x7975F0", VA = "0x1807985F0")]
	public SideJobController()
	{
	}

	// Token: 0x040017FD RID: 6141
	[Token(Token = "0x40017FD")]
	[FieldOffset(Offset = "0x18")]
	public bool enableJobs;

	// Token: 0x040017FE RID: 6142
	[Token(Token = "0x40017FE")]
	[FieldOffset(Offset = "0x20")]
	public List<SideJobController.JobTracking> jobTracking;

	// Token: 0x040017FF RID: 6143
	[Token(Token = "0x40017FF")]
	[FieldOffset(Offset = "0x28")]
	public List<Human> exemptFromPosters;

	// Token: 0x04001800 RID: 6144
	[Token(Token = "0x4001800")]
	[FieldOffset(Offset = "0x30")]
	public List<Human> exemptFromPurps;

	// Token: 0x04001801 RID: 6145
	[Token(Token = "0x4001801")]
	[FieldOffset(Offset = "0x38")]
	public Dictionary<Human, List<SideJob>> exemptFromPostersJobs;

	// Token: 0x04001802 RID: 6146
	[Token(Token = "0x4001802")]
	[FieldOffset(Offset = "0x40")]
	public Dictionary<Human, List<SideJob>> exemptFromPurpsJobs;

	// Token: 0x04001803 RID: 6147
	[Token(Token = "0x4001803")]
	[FieldOffset(Offset = "0x48")]
	public Dictionary<int, SideJob> allJobsDictionary;

	// Token: 0x04001804 RID: 6148
	[Token(Token = "0x4001804")]
	[FieldOffset(Offset = "0x50")]
	[NonSerialized]
	public SideJob invokedSideJob;

	// Token: 0x04001805 RID: 6149
	[Token(Token = "0x4001805")]
	[FieldOffset(Offset = "0x58")]
	[NonSerialized]
	public Objective invokedObjective;

	// Token: 0x04001806 RID: 6150
	[Token(Token = "0x4001806")]
	[FieldOffset(Offset = "0x60")]
	public int debugJobID;

	// Token: 0x04001807 RID: 6151
	[Token(Token = "0x4001807")]
	[FieldOffset(Offset = "0x0")]
	private static SideJobController _instance;

	// Token: 0x02000363 RID: 867
	[Token(Token = "0x2000363")]
	[Serializable]
	public class JobTracking
	{
		// Token: 0x060013A7 RID: 5031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x798A10", Offset = "0x797A10", VA = "0x180798A10")]
		public JobTracking()
		{
		}

		// Token: 0x04001808 RID: 6152
		[Token(Token = "0x4001808")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04001809 RID: 6153
		[Token(Token = "0x4001809")]
		[FieldOffset(Offset = "0x18")]
		public JobPreset preset;

		// Token: 0x0400180A RID: 6154
		[Token(Token = "0x400180A")]
		[FieldOffset(Offset = "0x20")]
		public List<SideJob> activeJobs;

		// Token: 0x0400180B RID: 6155
		[Token(Token = "0x400180B")]
		[FieldOffset(Offset = "0x28")]
		public List<SideJob> endedJobs;

		// Token: 0x0400180C RID: 6156
		[Token(Token = "0x400180C")]
		[FieldOffset(Offset = "0x30")]
		public int desiredActiveInstances;
	}

	// Token: 0x02000364 RID: 868
	[Token(Token = "0x2000364")]
	[Serializable]
	public class JobPickData
	{
		// Token: 0x060013A8 RID: 5032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public JobPickData()
		{
		}

		// Token: 0x0400180D RID: 6157
		[Token(Token = "0x400180D")]
		[FieldOffset(Offset = "0x10")]
		public MotivePreset motive;

		// Token: 0x0400180E RID: 6158
		[Token(Token = "0x400180E")]
		[FieldOffset(Offset = "0x18")]
		public Citizen poster;

		// Token: 0x0400180F RID: 6159
		[Token(Token = "0x400180F")]
		[FieldOffset(Offset = "0x20")]
		public Citizen purp;

		// Token: 0x04001810 RID: 6160
		[Token(Token = "0x4001810")]
		[FieldOffset(Offset = "0x28")]
		public float score;
	}

	// Token: 0x02000365 RID: 869
	[Token(Token = "0x2000365")]
	private sealed class <>c__DisplayClass17_0
	{
		// Token: 0x060013A9 RID: 5033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A9")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass17_0()
		{
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00009630 File Offset: 0x00007830
		[Token(Token = "0x60013AA")]
		[Address(RVA = "0x798B60", Offset = "0x797B60", VA = "0x180798B60")]
		internal bool <Start>b__0(SideJobController.JobTracking item)
		{
			return default(bool);
		}

		// Token: 0x04001811 RID: 6161
		[Token(Token = "0x4001811")]
		[FieldOffset(Offset = "0x10")]
		public JobPreset p;
	}

	// Token: 0x02000366 RID: 870
	[Token(Token = "0x2000366")]
	private sealed class <>c__DisplayClass18_0
	{
		// Token: 0x060013AB RID: 5035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass18_0()
		{
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00009648 File Offset: 0x00007848
		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x798BD0", Offset = "0x797BD0", VA = "0x180798BD0")]
		internal bool <JobCreationCheck>b__1(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x04001812 RID: 6162
		[Token(Token = "0x4001812")]
		[FieldOffset(Offset = "0x10")]
		public Citizen cit;
	}

	// Token: 0x02000367 RID: 871
	[Token(Token = "0x2000367")]
	private sealed class <>c__DisplayClass18_1
	{
		// Token: 0x060013AD RID: 5037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass18_1()
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00009660 File Offset: 0x00007860
		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x798EC0", Offset = "0x797EC0", VA = "0x180798EC0")]
		internal bool <JobCreationCheck>b__2(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x04001813 RID: 6163
		[Token(Token = "0x4001813")]
		[FieldOffset(Offset = "0x10")]
		public Acquaintance aq;
	}

	// Token: 0x02000368 RID: 872
	[Token(Token = "0x2000368")]
	private sealed class <>c__DisplayClass18_2
	{
		// Token: 0x060013AF RID: 5039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass18_2()
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00009678 File Offset: 0x00007878
		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x7991D0", Offset = "0x7981D0", VA = "0x1807991D0")]
		internal bool <JobCreationCheck>b__3(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x04001814 RID: 6164
		[Token(Token = "0x4001814")]
		[FieldOffset(Offset = "0x10")]
		public Citizen h;
	}

	// Token: 0x02000369 RID: 873
	[Token(Token = "0x2000369")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060013B2 RID: 5042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00009690 File Offset: 0x00007890
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x799570", Offset = "0x798570", VA = "0x180799570")]
		internal int <JobCreationCheck>b__18_0(SideJobController.JobPickData p1, SideJobController.JobPickData p2)
		{
			return 0;
		}

		// Token: 0x04001815 RID: 6165
		[Token(Token = "0x4001815")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SideJobController.<>c <>9;

		// Token: 0x04001816 RID: 6166
		[Token(Token = "0x4001816")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<SideJobController.JobPickData> <>9__18_0;
	}

	// Token: 0x0200036A RID: 874
	[Token(Token = "0x200036A")]
	private sealed class <>c__DisplayClass23_0
	{
		// Token: 0x060013B4 RID: 5044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass23_0()
		{
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x000096A8 File Offset: 0x000078A8
		[Token(Token = "0x60013B5")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <MotivePass>b__0(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04001817 RID: 6167
		[Token(Token = "0x4001817")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x0200036B RID: 875
	[Token(Token = "0x200036B")]
	private sealed class <>c__DisplayClass23_1
	{
		// Token: 0x060013B6 RID: 5046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass23_1()
		{
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x000096C0 File Offset: 0x000078C0
		[Token(Token = "0x60013B7")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <MotivePass>b__1(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04001818 RID: 6168
		[Token(Token = "0x4001818")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x0200036C RID: 876
	[Token(Token = "0x200036C")]
	private sealed class <>c__DisplayClass23_2
	{
		// Token: 0x060013B8 RID: 5048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B8")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass23_2()
		{
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x000096D8 File Offset: 0x000078D8
		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <MotivePass>b__2(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x04001819 RID: 6169
		[Token(Token = "0x4001819")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x0200036D RID: 877
	[Token(Token = "0x200036D")]
	private sealed class <>c__DisplayClass23_3
	{
		// Token: 0x060013BA RID: 5050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BA")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass23_3()
		{
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x000096F0 File Offset: 0x000078F0
		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x4E7560", Offset = "0x4E6560", VA = "0x1804E7560")]
		internal bool <MotivePass>b__3(Human.Trait item)
		{
			return default(bool);
		}

		// Token: 0x0400181A RID: 6170
		[Token(Token = "0x400181A")]
		[FieldOffset(Offset = "0x10")]
		public CharacterTrait searchTrait;
	}

	// Token: 0x0200036E RID: 878
	[Token(Token = "0x200036E")]
	private sealed class <>c__DisplayClass25_0
	{
		// Token: 0x060013BC RID: 5052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BC")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass25_0()
		{
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00009708 File Offset: 0x00007908
		[Token(Token = "0x60013BD")]
		[Address(RVA = "0x799600", Offset = "0x798600", VA = "0x180799600")]
		internal bool <DeadPeopleJobCheck>b__0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00009720 File Offset: 0x00007920
		[Token(Token = "0x60013BE")]
		[Address(RVA = "0x799910", Offset = "0x798910", VA = "0x180799910")]
		internal bool <DeadPeopleJobCheck>b__1(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x0400181B RID: 6171
		[Token(Token = "0x400181B")]
		[FieldOffset(Offset = "0x10")]
		public SideJob job;
	}
}
