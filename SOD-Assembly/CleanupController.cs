using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BA RID: 698
[Token(Token = "0x20002BA")]
public class CleanupController : MonoBehaviour
{
	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700007B")]
	public static CleanupController Instance
	{
		[Token(Token = "0x6000FAA")]
		[Address(RVA = "0x680620", Offset = "0x67F620", VA = "0x180680620")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FAB")]
	[Address(RVA = "0x680660", Offset = "0x67F660", VA = "0x180680660")]
	private void Awake()
	{
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FAC")]
	[Address(RVA = "0x6809B0", Offset = "0x67F9B0", VA = "0x1806809B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FAD")]
	[Address(RVA = "0x680BC0", Offset = "0x67FBC0", VA = "0x180680BC0")]
	public void TrashUpdate()
	{
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FAE")]
	[Address(RVA = "0x6812F0", Offset = "0x6802F0", VA = "0x1806812F0")]
	public void UpdateData()
	{
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FAF")]
	[Address(RVA = "0x683510", Offset = "0x682510", VA = "0x180683510")]
	public void RemoveUnusedPlayerPhotoCaptures(Interactable captureDevice)
	{
	}

	// Token: 0x06000FB0 RID: 4016 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FB0")]
	[Address(RVA = "0x6849B0", Offset = "0x6839B0", VA = "0x1806849B0")]
	public CleanupController()
	{
	}

	// Token: 0x040012BA RID: 4794
	[Token(Token = "0x40012BA")]
	public const int trashLimit = 250;

	// Token: 0x040012BB RID: 4795
	[Token(Token = "0x40012BB")]
	[FieldOffset(Offset = "0x18")]
	public int totalInteractables;

	// Token: 0x040012BC RID: 4796
	[Token(Token = "0x40012BC")]
	[FieldOffset(Offset = "0x1C")]
	public int removedCityDataInteractables;

	// Token: 0x040012BD RID: 4797
	[Token(Token = "0x40012BD")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public List<int> removedCityDataItems;

	// Token: 0x040012BE RID: 4798
	[Token(Token = "0x40012BE")]
	[FieldOffset(Offset = "0x28")]
	public int savableCount;

	// Token: 0x040012BF RID: 4799
	[Token(Token = "0x40012BF")]
	[FieldOffset(Offset = "0x2C")]
	public int savablePercent;

	// Token: 0x040012C0 RID: 4800
	[Token(Token = "0x40012C0")]
	[FieldOffset(Offset = "0x30")]
	public int trashCount;

	// Token: 0x040012C1 RID: 4801
	[Token(Token = "0x40012C1")]
	[FieldOffset(Offset = "0x34")]
	public int trashPercent;

	// Token: 0x040012C2 RID: 4802
	[Token(Token = "0x40012C2")]
	[FieldOffset(Offset = "0x38")]
	public int trashThreshold;

	// Token: 0x040012C3 RID: 4803
	[Token(Token = "0x40012C3")]
	[FieldOffset(Offset = "0x3C")]
	public int trashThresholdPercent;

	// Token: 0x040012C4 RID: 4804
	[Token(Token = "0x40012C4")]
	[FieldOffset(Offset = "0x40")]
	public int trashRemovedLastUpdate;

	// Token: 0x040012C5 RID: 4805
	[Token(Token = "0x40012C5")]
	[FieldOffset(Offset = "0x48")]
	public List<CleanupController.DebugInteractable> breakdownSavable;

	// Token: 0x040012C6 RID: 4806
	[Token(Token = "0x40012C6")]
	[FieldOffset(Offset = "0x50")]
	public List<CleanupController.DebugInteractable> breakdownNonSavable;

	// Token: 0x040012C7 RID: 4807
	[Token(Token = "0x40012C7")]
	[FieldOffset(Offset = "0x58")]
	public List<CleanupController.DebugInteractable> breakdownTrash;

	// Token: 0x040012C8 RID: 4808
	[Token(Token = "0x40012C8")]
	[FieldOffset(Offset = "0x60")]
	public int currentTrash;

	// Token: 0x040012C9 RID: 4809
	[Token(Token = "0x40012C9")]
	[FieldOffset(Offset = "0x68")]
	[NonSerialized]
	public List<Interactable> trash;

	// Token: 0x040012CA RID: 4810
	[Token(Token = "0x40012CA")]
	[FieldOffset(Offset = "0x70")]
	public int binTrash;

	// Token: 0x040012CB RID: 4811
	[Token(Token = "0x40012CB")]
	[FieldOffset(Offset = "0x74")]
	public int metaObjectsCount;

	// Token: 0x040012CC RID: 4812
	[Token(Token = "0x40012CC")]
	[FieldOffset(Offset = "0x78")]
	public int fingerprintsCount;

	// Token: 0x040012CD RID: 4813
	[Token(Token = "0x40012CD")]
	[FieldOffset(Offset = "0x7C")]
	public int fingerprintThreshold;

	// Token: 0x040012CE RID: 4814
	[Token(Token = "0x40012CE")]
	[FieldOffset(Offset = "0x80")]
	public int fingerprintThresholdPercent;

	// Token: 0x040012CF RID: 4815
	[Token(Token = "0x40012CF")]
	[FieldOffset(Offset = "0x84")]
	public int footprintsCount;

	// Token: 0x040012D0 RID: 4816
	[Token(Token = "0x40012D0")]
	[FieldOffset(Offset = "0x88")]
	public int footprintThreshold;

	// Token: 0x040012D1 RID: 4817
	[Token(Token = "0x40012D1")]
	[FieldOffset(Offset = "0x8C")]
	public int footprintThresholdPercent;

	// Token: 0x040012D2 RID: 4818
	[Token(Token = "0x40012D2")]
	[FieldOffset(Offset = "0x90")]
	public int cctvCount;

	// Token: 0x040012D3 RID: 4819
	[Token(Token = "0x40012D3")]
	[FieldOffset(Offset = "0x94")]
	public int cctvThreshold;

	// Token: 0x040012D4 RID: 4820
	[Token(Token = "0x40012D4")]
	[FieldOffset(Offset = "0x98")]
	public int cctvThresholdPercent;

	// Token: 0x040012D5 RID: 4821
	[Token(Token = "0x40012D5")]
	[FieldOffset(Offset = "0x9C")]
	public int evidenceCount;

	// Token: 0x040012D6 RID: 4822
	[Token(Token = "0x40012D6")]
	[FieldOffset(Offset = "0xA0")]
	public int factsCount;

	// Token: 0x040012D7 RID: 4823
	[Token(Token = "0x40012D7")]
	[FieldOffset(Offset = "0x0")]
	private static CleanupController _instance;

	// Token: 0x020002BB RID: 699
	[Token(Token = "0x20002BB")]
	[Serializable]
	public class DebugInteractable
	{
		// Token: 0x06000FB1 RID: 4017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x684CE0", Offset = "0x683CE0", VA = "0x180684CE0")]
		public DebugInteractable()
		{
		}

		// Token: 0x040012D8 RID: 4824
		[Token(Token = "0x40012D8")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040012D9 RID: 4825
		[Token(Token = "0x40012D9")]
		[FieldOffset(Offset = "0x18")]
		public int count;

		// Token: 0x040012DA RID: 4826
		[Token(Token = "0x40012DA")]
		[FieldOffset(Offset = "0x1C")]
		public int savablePercent;

		// Token: 0x040012DB RID: 4827
		[Token(Token = "0x40012DB")]
		[FieldOffset(Offset = "0x20")]
		public int trashPercent;

		// Token: 0x040012DC RID: 4828
		[Token(Token = "0x40012DC")]
		[FieldOffset(Offset = "0x28")]
		public List<CleanupController.SaveableBecause> savableDetails;

		// Token: 0x040012DD RID: 4829
		[Token(Token = "0x40012DD")]
		[FieldOffset(Offset = "0x30")]
		public List<Interactable> contents;
	}

	// Token: 0x020002BC RID: 700
	[Token(Token = "0x20002BC")]
	[Serializable]
	public class SaveableBecause
	{
		// Token: 0x06000FB2 RID: 4018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public SaveableBecause()
		{
		}

		// Token: 0x040012DE RID: 4830
		[Token(Token = "0x40012DE")]
		[FieldOffset(Offset = "0x10")]
		public string reason;

		// Token: 0x040012DF RID: 4831
		[Token(Token = "0x40012DF")]
		[FieldOffset(Offset = "0x18")]
		public int count;
	}

	// Token: 0x020002BD RID: 701
	[Token(Token = "0x20002BD")]
	private sealed class <>c__DisplayClass37_0
	{
		// Token: 0x06000FB3 RID: 4019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass37_0()
		{
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00008298 File Offset: 0x00006498
		[Token(Token = "0x6000FB4")]
		[Address(RVA = "0x51E980", Offset = "0x51D980", VA = "0x18051E980")]
		internal bool <UpdateData>b__4(CleanupController.SaveableBecause item)
		{
			return default(bool);
		}

		// Token: 0x040012E0 RID: 4832
		[Token(Token = "0x40012E0")]
		[FieldOffset(Offset = "0x10")]
		public string reason;
	}

	// Token: 0x020002BE RID: 702
	[Token(Token = "0x20002BE")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000FB6 RID: 4022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB6")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x000082B0 File Offset: 0x000064B0
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x684F00", Offset = "0x683F00", VA = "0x180684F00")]
		internal int <UpdateData>b__37_3(CleanupController.SaveableBecause p2, CleanupController.SaveableBecause p1)
		{
			return 0;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x000082C8 File Offset: 0x000064C8
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x684F00", Offset = "0x683F00", VA = "0x180684F00")]
		internal int <UpdateData>b__37_0(CleanupController.DebugInteractable p2, CleanupController.DebugInteractable p1)
		{
			return 0;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x000082E0 File Offset: 0x000064E0
		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0x684F00", Offset = "0x683F00", VA = "0x180684F00")]
		internal int <UpdateData>b__37_1(CleanupController.DebugInteractable p2, CleanupController.DebugInteractable p1)
		{
			return 0;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0x684F00", Offset = "0x683F00", VA = "0x180684F00")]
		internal int <UpdateData>b__37_2(CleanupController.DebugInteractable p2, CleanupController.DebugInteractable p1)
		{
			return 0;
		}

		// Token: 0x040012E1 RID: 4833
		[Token(Token = "0x40012E1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CleanupController.<>c <>9;

		// Token: 0x040012E2 RID: 4834
		[Token(Token = "0x40012E2")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<CleanupController.SaveableBecause> <>9__37_3;

		// Token: 0x040012E3 RID: 4835
		[Token(Token = "0x40012E3")]
		[FieldOffset(Offset = "0x10")]
		public static Comparison<CleanupController.DebugInteractable> <>9__37_0;

		// Token: 0x040012E4 RID: 4836
		[Token(Token = "0x40012E4")]
		[FieldOffset(Offset = "0x18")]
		public static Comparison<CleanupController.DebugInteractable> <>9__37_1;

		// Token: 0x040012E5 RID: 4837
		[Token(Token = "0x40012E5")]
		[FieldOffset(Offset = "0x20")]
		public static Comparison<CleanupController.DebugInteractable> <>9__37_2;
	}

	// Token: 0x020002BF RID: 703
	[Token(Token = "0x20002BF")]
	private sealed class <>c__DisplayClass38_0
	{
		// Token: 0x06000FBB RID: 4027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass38_0()
		{
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00008310 File Offset: 0x00006510
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x684F40", Offset = "0x683F40", VA = "0x180684F40")]
		internal bool <RemoveUnusedPlayerPhotoCaptures>b__0(SceneRecorder.SceneCapture item)
		{
			return default(bool);
		}

		// Token: 0x040012E6 RID: 4838
		[Token(Token = "0x40012E6")]
		[FieldOffset(Offset = "0x10")]
		public Interactable.Passed p;
	}

	// Token: 0x020002C0 RID: 704
	[Token(Token = "0x20002C0")]
	private sealed class <>c__DisplayClass38_1
	{
		// Token: 0x06000FBD RID: 4029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass38_1()
		{
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00008328 File Offset: 0x00006528
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x684F70", Offset = "0x683F70", VA = "0x180684F70")]
		internal bool <RemoveUnusedPlayerPhotoCaptures>b__1(SceneRecorder.SceneCapture item)
		{
			return default(bool);
		}

		// Token: 0x040012E7 RID: 4839
		[Token(Token = "0x40012E7")]
		[FieldOffset(Offset = "0x10")]
		public KeyValuePair<int, List<Interactable>> pair;
	}
}
