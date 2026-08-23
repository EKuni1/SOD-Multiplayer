using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200067A RID: 1658
[Token(Token = "0x200067A")]
public class HistoryController : MonoBehaviour
{
	// Token: 0x1700012B RID: 299
	// (get) Token: 0x060024C5 RID: 9413 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700012B")]
	public static HistoryController Instance
	{
		[Token(Token = "0x60024C5")]
		[Address(RVA = "0xBA3910", Offset = "0xBA2910", VA = "0x180BA3910")]
		get
		{
			return null;
		}
	}

	// Token: 0x060024C6 RID: 9414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024C6")]
	[Address(RVA = "0xBA3950", Offset = "0xBA2950", VA = "0x180BA3950")]
	public void Setup(WindowContentController newContentController)
	{
	}

	// Token: 0x060024C7 RID: 9415 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024C7")]
	[Address(RVA = "0xB99340", Offset = "0xB98340", VA = "0x180B99340")]
	public void SetPageSize(Vector2 newSize)
	{
	}

	// Token: 0x060024C8 RID: 9416 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024C8")]
	[Address(RVA = "0xBA3E30", Offset = "0xBA2E30", VA = "0x180BA3E30")]
	private void OnEnable()
	{
	}

	// Token: 0x060024C9 RID: 9417 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024C9")]
	[Address(RVA = "0xBA4040", Offset = "0xBA3040", VA = "0x180BA4040")]
	private void OnDisable()
	{
	}

	// Token: 0x060024CA RID: 9418 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024CA")]
	[Address(RVA = "0xBA4330", Offset = "0xBA3330", VA = "0x180BA4330")]
	private void OnDestroy()
	{
	}

	// Token: 0x060024CB RID: 9419 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024CB")]
	[Address(RVA = "0xBA4500", Offset = "0xBA3500", VA = "0x180BA4500")]
	public void UpdateListDisplay()
	{
	}

	// Token: 0x060024CC RID: 9420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024CC")]
	[Address(RVA = "0xBA5CA0", Offset = "0xBA4CA0", VA = "0x180BA5CA0")]
	public void ClearSearchButton()
	{
	}

	// Token: 0x060024CD RID: 9421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60024CD")]
	[Address(RVA = "0xBA5D00", Offset = "0xBA4D00", VA = "0x180BA5D00")]
	public HistoryController()
	{
	}

	// Token: 0x04002EDB RID: 11995
	[Token(Token = "0x4002EDB")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform rect;

	// Token: 0x04002EDC RID: 11996
	[Token(Token = "0x4002EDC")]
	[FieldOffset(Offset = "0x20")]
	public WindowContentController wcc;

	// Token: 0x04002EDD RID: 11997
	[Token(Token = "0x4002EDD")]
	[FieldOffset(Offset = "0x28")]
	public bool isSetup;

	// Token: 0x04002EDE RID: 11998
	[Token(Token = "0x4002EDE")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI contentsText;

	// Token: 0x04002EDF RID: 11999
	[Token(Token = "0x4002EDF")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform entryParent;

	// Token: 0x04002EE0 RID: 12000
	[Token(Token = "0x4002EE0")]
	[FieldOffset(Offset = "0x40")]
	public TMP_InputField searchInputField;

	// Token: 0x04002EE1 RID: 12001
	[Token(Token = "0x4002EE1")]
	[FieldOffset(Offset = "0x48")]
	public List<SuspectListEntryController> spawnedEntries;

	// Token: 0x04002EE2 RID: 12002
	[Token(Token = "0x4002EE2")]
	[FieldOffset(Offset = "0x0")]
	private static HistoryController _instance;

	// Token: 0x0200067B RID: 1659
	[Token(Token = "0x200067B")]
	private sealed class <>c__DisplayClass15_0
	{
		// Token: 0x060024CE RID: 9422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024CE")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass15_0()
		{
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		[Token(Token = "0x60024CF")]
		[Address(RVA = "0xBA5E00", Offset = "0xBA4E00", VA = "0x180BA5E00")]
		internal bool <UpdateListDisplay>b__1(GameplayController.History item)
		{
			return default(bool);
		}

		// Token: 0x04002EE3 RID: 12003
		[Token(Token = "0x4002EE3")]
		[FieldOffset(Offset = "0x10")]
		public NewGameLocation location;
	}

	// Token: 0x0200067C RID: 1660
	[Token(Token = "0x200067C")]
	private sealed class <>c__DisplayClass15_1
	{
		// Token: 0x060024D0 RID: 9424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D0")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass15_1()
		{
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		[Token(Token = "0x60024D1")]
		[Address(RVA = "0xBA5E70", Offset = "0xBA4E70", VA = "0x180BA5E70")]
		internal bool <UpdateListDisplay>b__2(GameplayController.History item)
		{
			return default(bool);
		}

		// Token: 0x04002EE4 RID: 12004
		[Token(Token = "0x4002EE4")]
		[FieldOffset(Offset = "0x10")]
		public NewBuilding building;
	}

	// Token: 0x0200067D RID: 1661
	[Token(Token = "0x200067D")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060024D3 RID: 9427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D3")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		[Token(Token = "0x60024D4")]
		[Address(RVA = "0xBA5F90", Offset = "0xBA4F90", VA = "0x180BA5F90")]
		internal int <UpdateListDisplay>b__15_0(SuspectListEntryController p2, SuspectListEntryController p1)
		{
			return 0;
		}

		// Token: 0x04002EE5 RID: 12005
		[Token(Token = "0x4002EE5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HistoryController.<>c <>9;

		// Token: 0x04002EE6 RID: 12006
		[Token(Token = "0x4002EE6")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<SuspectListEntryController> <>9__15_0;
	}
}
