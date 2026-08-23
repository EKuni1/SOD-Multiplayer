using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200027F RID: 639
[Token(Token = "0x200027F")]
public class ChapterController : MonoBehaviour
{
	// Token: 0x14000015 RID: 21
	// (add) Token: 0x06000E2F RID: 3631 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000E30 RID: 3632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000015")]
	public event ChapterController.NewPart OnNewPart
	{
		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x64F660", Offset = "0x64E660", VA = "0x18064F660")]
		add
		{
		}
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x64F750", Offset = "0x64E750", VA = "0x18064F750")]
		remove
		{
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06000E31 RID: 3633 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000076")]
	public static ChapterController Instance
	{
		[Token(Token = "0x6000E31")]
		[Address(RVA = "0x64F840", Offset = "0x64E840", VA = "0x18064F840")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E32")]
	[Address(RVA = "0x64F880", Offset = "0x64E880", VA = "0x18064F880")]
	private void Awake()
	{
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E33")]
	[Address(RVA = "0x64FDD0", Offset = "0x64EDD0", VA = "0x18064FDD0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E34")]
	[Address(RVA = "0x64FFE0", Offset = "0x64EFE0", VA = "0x18064FFE0")]
	public void LoadChapter(ChapterPreset newChapter, bool newLoadFirstPartOnStart)
	{
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E35")]
	[Address(RVA = "0x650410", Offset = "0x64F410", VA = "0x180650410")]
	public void LoadPart(int partNumber, bool teleportPlayer = false, bool delay = true)
	{
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E36")]
	[Address(RVA = "0x650540", Offset = "0x64F540", VA = "0x180650540")]
	public void LoadPart(string chapterString)
	{
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E37")]
	[Address(RVA = "0x650720", Offset = "0x64F720", VA = "0x180650720")]
	public void SkipToChapterPart(int newPart, bool teleport, bool delay)
	{
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E38")]
	[Address(RVA = "0x650820", Offset = "0x64F820", VA = "0x180650820")]
	public void SkipToNextPart()
	{
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E39")]
	[Address(RVA = "0x650850", Offset = "0x64F850", VA = "0x180650850")]
	public void ResetThis()
	{
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E3A")]
	[Address(RVA = "0x650A50", Offset = "0x64FA50", VA = "0x180650A50")]
	public ChapterController()
	{
	}

	// Token: 0x04001070 RID: 4208
	[Token(Token = "0x4001070")]
	[FieldOffset(Offset = "0x18")]
	public List<ChapterPreset> allChapters;

	// Token: 0x04001071 RID: 4209
	[Token(Token = "0x4001071")]
	[FieldOffset(Offset = "0x20")]
	public ChapterPreset loadedChapter;

	// Token: 0x04001072 RID: 4210
	[Token(Token = "0x4001072")]
	[FieldOffset(Offset = "0x28")]
	public Chapter chapterScript;

	// Token: 0x04001073 RID: 4211
	[Token(Token = "0x4001073")]
	[FieldOffset(Offset = "0x30")]
	public GameObject chapterObject;

	// Token: 0x04001074 RID: 4212
	[Token(Token = "0x4001074")]
	[FieldOffset(Offset = "0x38")]
	public int currentPart;

	// Token: 0x04001075 RID: 4213
	[Token(Token = "0x4001075")]
	[FieldOffset(Offset = "0x40")]
	public string currentPartName;

	// Token: 0x04001076 RID: 4214
	[Token(Token = "0x4001076")]
	[FieldOffset(Offset = "0x48")]
	public bool loadFirstPartOnStart;

	// Token: 0x04001078 RID: 4216
	[Token(Token = "0x4001078")]
	[FieldOffset(Offset = "0x0")]
	private static ChapterController _instance;

	// Token: 0x02000280 RID: 640
	// (Invoke) Token: 0x06000E3C RID: 3644
	[Token(Token = "0x2000280")]
	public delegate void NewPart(bool delay, bool teleport);

	// Token: 0x02000281 RID: 641
	[Token(Token = "0x2000281")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000E40 RID: 3648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x6000E41")]
		[Address(RVA = "0x650E40", Offset = "0x64FE40", VA = "0x180650E40")]
		internal int <Awake>b__14_0(ChapterPreset p1, ChapterPreset p2)
		{
			return 0;
		}

		// Token: 0x04001079 RID: 4217
		[Token(Token = "0x4001079")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ChapterController.<>c <>9;

		// Token: 0x0400107A RID: 4218
		[Token(Token = "0x400107A")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<ChapterPreset> <>9__14_0;
	}

	// Token: 0x02000282 RID: 642
	[Token(Token = "0x2000282")]
	private sealed class <>c__DisplayClass18_0
	{
		// Token: 0x06000E42 RID: 3650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E42")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass18_0()
		{
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x6000E43")]
		[Address(RVA = "0x650E80", Offset = "0x64FE80", VA = "0x180650E80")]
		internal bool <LoadPart>b__0(string item)
		{
			return default(bool);
		}

		// Token: 0x0400107B RID: 4219
		[Token(Token = "0x400107B")]
		[FieldOffset(Offset = "0x10")]
		public string chapterString;
	}
}
