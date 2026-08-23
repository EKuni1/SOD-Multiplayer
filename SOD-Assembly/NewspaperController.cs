using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000408 RID: 1032
[Token(Token = "0x2000408")]
public class NewspaperController : MonoBehaviour
{
	// Token: 0x170000BF RID: 191
	// (get) Token: 0x06001764 RID: 5988 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000BF")]
	public static NewspaperController Instance
	{
		[Token(Token = "0x6001764")]
		[Address(RVA = "0x8903D0", Offset = "0x88F3D0", VA = "0x1808903D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001765 RID: 5989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001765")]
	[Address(RVA = "0x890410", Offset = "0x88F410", VA = "0x180890410")]
	private void Awake()
	{
	}

	// Token: 0x06001766 RID: 5990 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001766")]
	[Address(RVA = "0x890760", Offset = "0x88F760", VA = "0x180890760")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001767 RID: 5991 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001767")]
	[Address(RVA = "0x890970", Offset = "0x88F970", VA = "0x180890970")]
	public void UpdateNewspaperReferences(NewspaperDisplayController disp)
	{
	}

	// Token: 0x06001768 RID: 5992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001768")]
	[Address(RVA = "0x8914A0", Offset = "0x8904A0", VA = "0x1808914A0")]
	public void UpdateText(bool updateNewsTicker = false)
	{
	}

	// Token: 0x06001769 RID: 5993 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001769")]
	[Address(RVA = "0x891E10", Offset = "0x890E10", VA = "0x180891E10")]
	public void SetTextForArticle(string msgID, int context, TextMeshProUGUI headline, TextMeshProUGUI[] columns, string lineBreaks = "\n\n")
	{
	}

	// Token: 0x0600176A RID: 5994 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600176A")]
	[Address(RVA = "0x892200", Offset = "0x891200", VA = "0x180892200")]
	private object GetContextObject(int contextEnum, string seed)
	{
		return null;
	}

	// Token: 0x0600176B RID: 5995 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600176B")]
	[Address(RVA = "0x892780", Offset = "0x891780", VA = "0x180892780")]
	public void SetAdText(string msgID, int context, TextMeshProUGUI adText)
	{
	}

	// Token: 0x0600176C RID: 5996 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600176C")]
	[Address(RVA = "0x892960", Offset = "0x891960", VA = "0x180892960")]
	public void GenerateNewNewspaper()
	{
	}

	// Token: 0x0600176D RID: 5997 RVA: 0x0000ACF8 File Offset: 0x00008EF8
	[Token(Token = "0x600176D")]
	[Address(RVA = "0x894090", Offset = "0x893090", VA = "0x180894090")]
	private bool PickArticleFromTrees(ref List<DDSSaveClasses.DDSTreeSave> trees, out string pickedArticleMsgID, out int pickedContext, [Optional] List<string> ignoreMsgIDs, bool includeDDSArticles = false)
	{
		return default(bool);
	}

	// Token: 0x0600176E RID: 5998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600176E")]
	[Address(RVA = "0x8948B0", Offset = "0x8938B0", VA = "0x1808948B0")]
	public NewspaperController()
	{
	}

	// Token: 0x0600176F RID: 5999 RVA: 0x0000AD10 File Offset: 0x00008F10
	[Token(Token = "0x600176F")]
	[Address(RVA = "0x8949B0", Offset = "0x8939B0", VA = "0x1808949B0")]
	private bool <GetContextObject>b__29_0(MurderController.Murder item)
	{
		return default(bool);
	}

	// Token: 0x06001770 RID: 6000 RVA: 0x0000AD28 File Offset: 0x00008F28
	[Token(Token = "0x6001770")]
	[Address(RVA = "0x8949B0", Offset = "0x8939B0", VA = "0x1808949B0")]
	private bool <GetContextObject>b__29_1(MurderController.Murder item)
	{
		return default(bool);
	}

	// Token: 0x04001C75 RID: 7285
	[Token(Token = "0x4001C75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI newspaperTitleText;

	// Token: 0x04001C76 RID: 7286
	[Token(Token = "0x4001C76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI newspaperDateText;

	// Token: 0x04001C77 RID: 7287
	[Token(Token = "0x4001C77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI mainArticleHeadline;

	// Token: 0x04001C78 RID: 7288
	[Token(Token = "0x4001C78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI mainArticleColumn1;

	// Token: 0x04001C79 RID: 7289
	[Token(Token = "0x4001C79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI mainArticleColumn2;

	// Token: 0x04001C7A RID: 7290
	[Token(Token = "0x4001C7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI mainArticleColumn3;

	// Token: 0x04001C7B RID: 7291
	[Token(Token = "0x4001C7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI article2Headline;

	// Token: 0x04001C7C RID: 7292
	[Token(Token = "0x4001C7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI article2Column1;

	// Token: 0x04001C7D RID: 7293
	[Token(Token = "0x4001C7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI article2Column2;

	// Token: 0x04001C7E RID: 7294
	[Token(Token = "0x4001C7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI article2Column3;

	// Token: 0x04001C7F RID: 7295
	[Token(Token = "0x4001C7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI article3Headline;

	// Token: 0x04001C80 RID: 7296
	[Token(Token = "0x4001C80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI article3Column1;

	// Token: 0x04001C81 RID: 7297
	[Token(Token = "0x4001C81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI article3Column2;

	// Token: 0x04001C82 RID: 7298
	[Token(Token = "0x4001C82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public TextMeshProUGUI ad1Text;

	// Token: 0x04001C83 RID: 7299
	[Token(Token = "0x4001C83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TextMeshProUGUI ad2Text;

	// Token: 0x04001C84 RID: 7300
	[Token(Token = "0x4001C84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TextMeshProUGUI ad3Text;

	// Token: 0x04001C85 RID: 7301
	[Token(Token = "0x4001C85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TextMeshProUGUI ad4Text;

	// Token: 0x04001C86 RID: 7302
	[Token(Token = "0x4001C86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public NewspaperController.NewspaperState currentState;

	// Token: 0x04001C87 RID: 7303
	[Token(Token = "0x4001C87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<NewspaperController.InteractionDialogFeature> ddsFeaturedArticles;

	// Token: 0x04001C88 RID: 7304
	[Token(Token = "0x4001C88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static NewspaperController _instance;

	// Token: 0x02000409 RID: 1033
	[Token(Token = "0x2000409")]
	[Serializable]
	public class InteractionDialogFeature
	{
		// Token: 0x06001771 RID: 6001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001771")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public InteractionDialogFeature()
		{
		}

		// Token: 0x04001C89 RID: 7305
		[Token(Token = "0x4001C89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string msgID;

		// Token: 0x04001C8A RID: 7306
		[Token(Token = "0x4001C8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int humanID;
	}

	// Token: 0x0200040A RID: 1034
	[Token(Token = "0x200040A")]
	[Serializable]
	public class NewspaperState
	{
		// Token: 0x06001772 RID: 6002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001772")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public void SerializeFields()
		{
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001773")]
		[Address(RVA = "0x791A40", Offset = "0x790A40", VA = "0x180791A40")]
		public NewspaperState()
		{
		}

		// Token: 0x04001C8B RID: 7307
		[Token(Token = "0x4001C8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float time;

		// Token: 0x04001C8C RID: 7308
		[Token(Token = "0x4001C8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string seed;

		// Token: 0x04001C8D RID: 7309
		[Token(Token = "0x4001C8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int murderID;

		// Token: 0x04001C8E RID: 7310
		[Token(Token = "0x4001C8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string mainArticle;

		// Token: 0x04001C8F RID: 7311
		[Token(Token = "0x4001C8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int mainContext;

		// Token: 0x04001C90 RID: 7312
		[Token(Token = "0x4001C90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string article2;

		// Token: 0x04001C91 RID: 7313
		[Token(Token = "0x4001C91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int art2Context;

		// Token: 0x04001C92 RID: 7314
		[Token(Token = "0x4001C92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string article3;

		// Token: 0x04001C93 RID: 7315
		[Token(Token = "0x4001C93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int art3Context;

		// Token: 0x04001C94 RID: 7316
		[Token(Token = "0x4001C94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string ad1;

		// Token: 0x04001C95 RID: 7317
		[Token(Token = "0x4001C95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int ad1Context;

		// Token: 0x04001C96 RID: 7318
		[Token(Token = "0x4001C96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string ad2;

		// Token: 0x04001C97 RID: 7319
		[Token(Token = "0x4001C97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int ad2Context;

		// Token: 0x04001C98 RID: 7320
		[Token(Token = "0x4001C98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string ad3;

		// Token: 0x04001C99 RID: 7321
		[Token(Token = "0x4001C99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int ad3Context;

		// Token: 0x04001C9A RID: 7322
		[Token(Token = "0x4001C9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string ad4;

		// Token: 0x04001C9B RID: 7323
		[Token(Token = "0x4001C9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int ad4Context;
	}

	// Token: 0x0200040B RID: 1035
	[Token(Token = "0x200040B")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001775 RID: 6005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001775")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0000AD40 File Offset: 0x00008F40
		[Token(Token = "0x6001776")]
		[Address(RVA = "0x894A90", Offset = "0x893A90", VA = "0x180894A90")]
		internal bool <GetContextObject>b__29_2(Citizen item)
		{
			return default(bool);
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x0000AD58 File Offset: 0x00008F58
		[Token(Token = "0x6001777")]
		[Address(RVA = "0x894AD0", Offset = "0x893AD0", VA = "0x180894AD0")]
		internal bool <GenerateNewNewspaper>b__31_1(DDSSaveClasses.DDSTreeSave item)
		{
			return default(bool);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x6001778")]
		[Address(RVA = "0x894AF0", Offset = "0x893AF0", VA = "0x180894AF0")]
		internal bool <GenerateNewNewspaper>b__31_3(DDSSaveClasses.DDSTreeSave item)
		{
			return default(bool);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x0000AD88 File Offset: 0x00008F88
		[Token(Token = "0x6001779")]
		[Address(RVA = "0x894B20", Offset = "0x893B20", VA = "0x180894B20")]
		internal bool <GenerateNewNewspaper>b__31_4(DDSSaveClasses.DDSTreeSave item)
		{
			return default(bool);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[Token(Token = "0x600177A")]
		[Address(RVA = "0x894B50", Offset = "0x893B50", VA = "0x180894B50")]
		internal bool <GenerateNewNewspaper>b__31_5(DDSSaveClasses.DDSTreeSave item)
		{
			return default(bool);
		}

		// Token: 0x04001C9C RID: 7324
		[Token(Token = "0x4001C9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NewspaperController.<>c <>9;

		// Token: 0x04001C9D RID: 7325
		[Token(Token = "0x4001C9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Citizen> <>9__29_2;

		// Token: 0x04001C9E RID: 7326
		[Token(Token = "0x4001C9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<DDSSaveClasses.DDSTreeSave> <>9__31_1;

		// Token: 0x04001C9F RID: 7327
		[Token(Token = "0x4001C9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<DDSSaveClasses.DDSTreeSave> <>9__31_3;

		// Token: 0x04001CA0 RID: 7328
		[Token(Token = "0x4001CA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<DDSSaveClasses.DDSTreeSave> <>9__31_4;

		// Token: 0x04001CA1 RID: 7329
		[Token(Token = "0x4001CA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<DDSSaveClasses.DDSTreeSave> <>9__31_5;
	}

	// Token: 0x0200040C RID: 1036
	[Token(Token = "0x200040C")]
	private sealed class <>c__DisplayClass31_0
	{
		// Token: 0x0600177B RID: 6011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600177B")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass31_0()
		{
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x600177C")]
		[Address(RVA = "0x894B80", Offset = "0x893B80", VA = "0x180894B80")]
		internal bool <GenerateNewNewspaper>b__0(MurderController.Murder item)
		{
			return default(bool);
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		[Token(Token = "0x600177D")]
		[Address(RVA = "0x894BC0", Offset = "0x893BC0", VA = "0x180894BC0")]
		internal bool <GenerateNewNewspaper>b__2(DDSSaveClasses.DDSTreeSave item)
		{
			return default(bool);
		}

		// Token: 0x04001CA2 RID: 7330
		[Token(Token = "0x4001CA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MurderController.Murder murderRef;

		// Token: 0x04001CA3 RID: 7331
		[Token(Token = "0x4001CA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NewspaperController <>4__this;

		// Token: 0x04001CA4 RID: 7332
		[Token(Token = "0x4001CA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool murderSecond;

		// Token: 0x04001CA5 RID: 7333
		[Token(Token = "0x4001CA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isKidnap;

		// Token: 0x04001CA6 RID: 7334
		[Token(Token = "0x4001CA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool murderIsActive;
	}
}
