using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002CD RID: 717
[Token(Token = "0x20002CD")]
public class DatabaseApp : CruncherAppContent
{
	// Token: 0x06000FFE RID: 4094 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FFE")]
	[Address(RVA = "0x68BE00", Offset = "0x68AE00", VA = "0x18068BE00", Slot = "5")]
	public override void OnSetup()
	{
	}

	// Token: 0x06000FFF RID: 4095 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FFF")]
	[Address(RVA = "0x68BF10", Offset = "0x68AF10", VA = "0x18068BF10")]
	private void Update()
	{
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001000")]
	[Address(RVA = "0x68C650", Offset = "0x68B650", VA = "0x18068C650")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001001")]
	[Address(RVA = "0x68C6F0", Offset = "0x68B6F0", VA = "0x18068C6F0")]
	public void UpdateSelected()
	{
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001002")]
	[Address(RVA = "0x68CA50", Offset = "0x68BA50", VA = "0x18068CA50")]
	public void KeyboardButton(string charStr)
	{
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001003")]
	[Address(RVA = "0x68CD10", Offset = "0x68BD10", VA = "0x18068CD10")]
	public void BackspaceButton()
	{
	}

	// Token: 0x06001004 RID: 4100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001004")]
	[Address(RVA = "0x68CDA0", Offset = "0x68BDA0", VA = "0x18068CDA0")]
	public void UpdateSearch()
	{
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001005")]
	[Address(RVA = "0x68D560", Offset = "0x68C560", VA = "0x18068D560")]
	public void ExitButton()
	{
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001006")]
	[Address(RVA = "0x68D580", Offset = "0x68C580", VA = "0x18068D580")]
	public void OnPrintEntry()
	{
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001007")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public DatabaseApp()
	{
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x00008388 File Offset: 0x00006588
	[Token(Token = "0x6001008")]
	[Address(RVA = "0x68DED0", Offset = "0x68CED0", VA = "0x18068DED0")]
	private bool <UpdateSearch>b__15_0(Citizen item)
	{
		return default(bool);
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x000083A0 File Offset: 0x000065A0
	[Token(Token = "0x6001009")]
	[Address(RVA = "0x68DF40", Offset = "0x68CF40", VA = "0x18068DF40")]
	private bool <UpdateSearch>b__15_1(Citizen item)
	{
		return default(bool);
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x000083B8 File Offset: 0x000065B8
	[Token(Token = "0x600100A")]
	[Address(RVA = "0x68E180", Offset = "0x68D180", VA = "0x18068E180")]
	private bool <UpdateSearch>b__15_2(Citizen item)
	{
		return default(bool);
	}

	// Token: 0x0400132E RID: 4910
	[Token(Token = "0x400132E")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI titleText;

	// Token: 0x0400132F RID: 4911
	[Token(Token = "0x400132F")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI searchText;

	// Token: 0x04001330 RID: 4912
	[Token(Token = "0x4001330")]
	[FieldOffset(Offset = "0x30")]
	public ComputerOSMultiSelect list;

	// Token: 0x04001331 RID: 4913
	[Token(Token = "0x4001331")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform printButton;

	// Token: 0x04001332 RID: 4914
	[Token(Token = "0x4001332")]
	[FieldOffset(Offset = "0x40")]
	private Human selectedHuman;

	// Token: 0x04001333 RID: 4915
	[Token(Token = "0x4001333")]
	[FieldOffset(Offset = "0x48")]
	public string searchString;

	// Token: 0x04001334 RID: 4916
	[Token(Token = "0x4001334")]
	[FieldOffset(Offset = "0x50")]
	public InteractablePreset ddsPrintout;

	// Token: 0x04001335 RID: 4917
	[Token(Token = "0x4001335")]
	[FieldOffset(Offset = "0x58")]
	public DatabaseApp.CitizenPool citizenPool;

	// Token: 0x020002CE RID: 718
	[Token(Token = "0x20002CE")]
	public enum CitizenPool
	{
		// Token: 0x04001337 RID: 4919
		[Token(Token = "0x4001337")]
		allCitizens,
		// Token: 0x04001338 RID: 4920
		[Token(Token = "0x4001338")]
		companyOnly,
		// Token: 0x04001339 RID: 4921
		[Token(Token = "0x4001339")]
		buildingOnly
	}
}
