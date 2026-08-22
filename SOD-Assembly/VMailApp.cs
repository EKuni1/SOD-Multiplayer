using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002DD RID: 733
[Token(Token = "0x20002DD")]
public class VMailApp : CruncherAppContent
{
	// Token: 0x06001055 RID: 4181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001055")]
	[Address(RVA = "0x69D4B0", Offset = "0x69C4B0", VA = "0x18069D4B0", Slot = "5")]
	public override void OnSetup()
	{
	}

	// Token: 0x06001056 RID: 4182 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001056")]
	[Address(RVA = "0x69EA00", Offset = "0x69DA00", VA = "0x18069EA00")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001057 RID: 4183 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001057")]
	[Address(RVA = "0x69EAA0", Offset = "0x69DAA0", VA = "0x18069EAA0")]
	public void OnUpdatedSelection()
	{
	}

	// Token: 0x06001058 RID: 4184 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001058")]
	[Address(RVA = "0x69EAD0", Offset = "0x69DAD0", VA = "0x18069EAD0")]
	public void SetSelectedVmail(ComputerOSMultiSelectElement newSelection)
	{
	}

	// Token: 0x06001059 RID: 4185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001059")]
	[Address(RVA = "0x69FDD0", Offset = "0x69EDD0", VA = "0x18069FDD0")]
	public void NextButton()
	{
	}

	// Token: 0x0600105A RID: 4186 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105A")]
	[Address(RVA = "0x69FE20", Offset = "0x69EE20", VA = "0x18069FE20")]
	public void PrevButton()
	{
	}

	// Token: 0x0600105B RID: 4187 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105B")]
	[Address(RVA = "0x68D560", Offset = "0x68C560", VA = "0x18068D560")]
	public void ExitButton()
	{
	}

	// Token: 0x0600105C RID: 4188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105C")]
	[Address(RVA = "0x69FE70", Offset = "0x69EE70", VA = "0x18069FE70", Slot = "6")]
	public override void PrintButton()
	{
	}

	// Token: 0x0600105D RID: 4189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105D")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public VMailApp()
	{
	}

	// Token: 0x040013A2 RID: 5026
	[Token(Token = "0x40013A2")]
	[FieldOffset(Offset = "0x20")]
	public ComputerOSMultiSelect vmailList;

	// Token: 0x040013A3 RID: 5027
	[Token(Token = "0x40013A3")]
	[FieldOffset(Offset = "0x28")]
	public ComputerOSMultiSelectElement selectedVmailElement;

	// Token: 0x040013A4 RID: 5028
	[Token(Token = "0x40013A4")]
	[FieldOffset(Offset = "0x30")]
	private StateSaveData.MessageThreadSave selectedThread;

	// Token: 0x040013A5 RID: 5029
	[Token(Token = "0x40013A5")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI vmailHeaderText;

	// Token: 0x040013A6 RID: 5030
	[Token(Token = "0x40013A6")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI vmailBodyText;

	// Token: 0x040013A7 RID: 5031
	[Token(Token = "0x40013A7")]
	[FieldOffset(Offset = "0x48")]
	public Button nextPageButton;

	// Token: 0x040013A8 RID: 5032
	[Token(Token = "0x40013A8")]
	[FieldOffset(Offset = "0x50")]
	public Button prevPageButton;

	// Token: 0x040013A9 RID: 5033
	[Token(Token = "0x40013A9")]
	[FieldOffset(Offset = "0x58")]
	public Human emailSender;

	// Token: 0x040013AA RID: 5034
	[Token(Token = "0x40013AA")]
	[FieldOffset(Offset = "0x60")]
	public Human emailReciever;

	// Token: 0x040013AB RID: 5035
	[Token(Token = "0x40013AB")]
	[FieldOffset(Offset = "0x68")]
	public string emailTextContent;

	// Token: 0x040013AC RID: 5036
	[Token(Token = "0x40013AC")]
	[FieldOffset(Offset = "0x70")]
	private DDSSaveClasses.DDSTreeSave tree;

	// Token: 0x040013AD RID: 5037
	[Token(Token = "0x40013AD")]
	[FieldOffset(Offset = "0x78")]
	private StateSaveData.MessageThreadSave thread;

	// Token: 0x040013AE RID: 5038
	[Token(Token = "0x40013AE")]
	[FieldOffset(Offset = "0x80")]
	private int msgIndex;

	// Token: 0x040013AF RID: 5039
	[Token(Token = "0x40013AF")]
	[FieldOffset(Offset = "0x88")]
	public Sprite sentIcon;

	// Token: 0x040013B0 RID: 5040
	[Token(Token = "0x40013B0")]
	[FieldOffset(Offset = "0x90")]
	public Sprite receivedIcon;

	// Token: 0x020002DE RID: 734
	[Token(Token = "0x20002DE")]
	public class VmailParsingData
	{
		// Token: 0x0600105E RID: 4190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600105E")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public VmailParsingData()
		{
		}

		// Token: 0x040013B1 RID: 5041
		[Token(Token = "0x40013B1")]
		[FieldOffset(Offset = "0x10")]
		public StateSaveData.MessageThreadSave thread;

		// Token: 0x040013B2 RID: 5042
		[Token(Token = "0x40013B2")]
		[FieldOffset(Offset = "0x18")]
		public int messageIndex;
	}

	// Token: 0x020002DF RID: 735
	[Token(Token = "0x20002DF")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001060 RID: 4192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001060")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c()
		{
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x000084A8 File Offset: 0x000066A8
		[Token(Token = "0x6001061")]
		[Address(RVA = "0x6A0950", Offset = "0x69F950", VA = "0x1806A0950")]
		internal int <OnSetup>b__16_0(StateSaveData.MessageThreadSave p2, StateSaveData.MessageThreadSave p1)
		{
			return 0;
		}

		// Token: 0x040013B3 RID: 5043
		[Token(Token = "0x40013B3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly VMailApp.<>c <>9;

		// Token: 0x040013B4 RID: 5044
		[Token(Token = "0x40013B4")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<StateSaveData.MessageThreadSave> <>9__16_0;
	}
}
