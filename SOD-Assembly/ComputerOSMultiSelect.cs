using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C3 RID: 707
[Token(Token = "0x20002C3")]
public class ComputerOSMultiSelect : MonoBehaviour
{
	// Token: 0x14000018 RID: 24
	// (add) Token: 0x06000FCF RID: 4047 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000FD0 RID: 4048 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000018")]
	public event ComputerOSMultiSelect.NewSelection OnNewSelection
	{
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x688090", Offset = "0x687090", VA = "0x180688090")]
		add
		{
		}
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x688180", Offset = "0x687180", VA = "0x180688180")]
		remove
		{
		}
	}

	// Token: 0x14000019 RID: 25
	// (add) Token: 0x06000FD1 RID: 4049 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000FD2 RID: 4050 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x14000019")]
	public event ComputerOSMultiSelect.ChangePage OnChangePage
	{
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x688270", Offset = "0x687270", VA = "0x180688270")]
		add
		{
		}
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x688360", Offset = "0x687360", VA = "0x180688360")]
		remove
		{
		}
	}

	// Token: 0x06000FD3 RID: 4051 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD3")]
	[Address(RVA = "0x3ED9D0", Offset = "0x3EC9D0", VA = "0x1803ED9D0")]
	public void Setup(ComputerController newComp)
	{
	}

	// Token: 0x06000FD4 RID: 4052 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD4")]
	[Address(RVA = "0x688450", Offset = "0x687450", VA = "0x180688450")]
	public void UpdateElements(List<ComputerOSMultiSelect.OSMultiOption> newOptions)
	{
	}

	// Token: 0x06000FD5 RID: 4053 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD5")]
	[Address(RVA = "0x6884B0", Offset = "0x6874B0", VA = "0x1806884B0")]
	private void SpawnList()
	{
	}

	// Token: 0x06000FD6 RID: 4054 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD6")]
	[Address(RVA = "0x688E50", Offset = "0x687E50", VA = "0x180688E50")]
	public void NextPage(int newPage)
	{
	}

	// Token: 0x06000FD7 RID: 4055 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD7")]
	[Address(RVA = "0x688EF0", Offset = "0x687EF0", VA = "0x180688EF0")]
	public void SetSelected(ComputerOSMultiSelectElement newSelection)
	{
	}

	// Token: 0x06000FD8 RID: 4056 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FD8")]
	[Address(RVA = "0x6892C0", Offset = "0x6882C0", VA = "0x1806892C0")]
	public ComputerOSMultiSelect()
	{
	}

	// Token: 0x040012F8 RID: 4856
	[Token(Token = "0x40012F8")]
	[FieldOffset(Offset = "0x18")]
	public ComputerController controller;

	// Token: 0x040012F9 RID: 4857
	[Token(Token = "0x40012F9")]
	[FieldOffset(Offset = "0x20")]
	public GameObject elementPrefab;

	// Token: 0x040012FA RID: 4858
	[Token(Token = "0x40012FA")]
	[FieldOffset(Offset = "0x28")]
	public List<ComputerOSMultiSelectElement> options;

	// Token: 0x040012FB RID: 4859
	[Token(Token = "0x40012FB")]
	[FieldOffset(Offset = "0x30")]
	public RectTransform elementParent;

	// Token: 0x040012FC RID: 4860
	[Token(Token = "0x40012FC")]
	[FieldOffset(Offset = "0x38")]
	public ComputerOSMultiSelectElement selected;

	// Token: 0x040012FD RID: 4861
	[Token(Token = "0x40012FD")]
	[FieldOffset(Offset = "0x40")]
	public bool usePages;

	// Token: 0x040012FE RID: 4862
	[Token(Token = "0x40012FE")]
	[FieldOffset(Offset = "0x44")]
	public int page;

	// Token: 0x040012FF RID: 4863
	[Token(Token = "0x40012FF")]
	[FieldOffset(Offset = "0x48")]
	public int maxPerPage;

	// Token: 0x04001300 RID: 4864
	[Token(Token = "0x4001300")]
	[FieldOffset(Offset = "0x50")]
	public List<ComputerOSMultiSelect.OSMultiOption> allOptions;

	// Token: 0x020002C4 RID: 708
	// (Invoke) Token: 0x06000FDA RID: 4058
	[Token(Token = "0x20002C4")]
	public delegate void NewSelection();

	// Token: 0x020002C5 RID: 709
	// (Invoke) Token: 0x06000FDE RID: 4062
	[Token(Token = "0x20002C5")]
	public delegate void ChangePage();

	// Token: 0x020002C6 RID: 710
	[Token(Token = "0x20002C6")]
	[Serializable]
	public class OSMultiOption
	{
		// Token: 0x06000FE1 RID: 4065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE1")]
		[Address(RVA = "0x6893C0", Offset = "0x6883C0", VA = "0x1806893C0")]
		public OSMultiOption(string newText, Human newHuman)
		{
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE2")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public OSMultiOption()
		{
		}

		// Token: 0x04001303 RID: 4867
		[Token(Token = "0x4001303")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		// Token: 0x04001304 RID: 4868
		[Token(Token = "0x4001304")]
		[FieldOffset(Offset = "0x18")]
		public Human human;

		// Token: 0x04001305 RID: 4869
		[Token(Token = "0x4001305")]
		[FieldOffset(Offset = "0x20")]
		public StateSaveData.MessageThreadSave msgThread;

		// Token: 0x04001306 RID: 4870
		[Token(Token = "0x4001306")]
		[FieldOffset(Offset = "0x28")]
		public int msgIndex;

		// Token: 0x04001307 RID: 4871
		[Token(Token = "0x4001307")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Company.SalesRecord salesRecord;

		// Token: 0x04001308 RID: 4872
		[Token(Token = "0x4001308")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Sprite iconSprite;
	}
}
