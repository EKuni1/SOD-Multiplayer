using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020002D9 RID: 729
[Token(Token = "0x20002D9")]
public class SalesRecordsApp : CruncherAppContent
{
	// Token: 0x06001025 RID: 4133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001025")]
	[Address(RVA = "0x6920F0", Offset = "0x6910F0", VA = "0x1806920F0", Slot = "5")]
	public override void OnSetup()
	{
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001026")]
	[Address(RVA = "0x6922D0", Offset = "0x6912D0", VA = "0x1806922D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001027")]
	[Address(RVA = "0x6924A0", Offset = "0x6914A0", VA = "0x1806924A0")]
	public void UpdateEntries()
	{
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001028")]
	[Address(RVA = "0x692860", Offset = "0x691860", VA = "0x180692860")]
	public void OnChangePage()
	{
	}

	// Token: 0x06001029 RID: 4137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001029")]
	[Address(RVA = "0x692C40", Offset = "0x691C40", VA = "0x180692C40")]
	public void UpdateSelected()
	{
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102A")]
	[Address(RVA = "0x68D560", Offset = "0x68C560", VA = "0x18068D560")]
	public void ExitButton()
	{
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102B")]
	[Address(RVA = "0x692EA0", Offset = "0x691EA0", VA = "0x180692EA0")]
	public void OnPrintEntry()
	{
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600102C")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public SalesRecordsApp()
	{
	}

	// Token: 0x0400134F RID: 4943
	[Token(Token = "0x400134F")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI titleText;

	// Token: 0x04001350 RID: 4944
	[Token(Token = "0x4001350")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI displayText;

	// Token: 0x04001351 RID: 4945
	[Token(Token = "0x4001351")]
	[FieldOffset(Offset = "0x30")]
	public ComputerOSMultiSelect list;

	// Token: 0x04001352 RID: 4946
	[Token(Token = "0x4001352")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform printButton;

	// Token: 0x04001353 RID: 4947
	[Token(Token = "0x4001353")]
	[FieldOffset(Offset = "0x40")]
	public InteractablePreset ddsPrintout;

	// Token: 0x020002DA RID: 730
	[Token(Token = "0x20002DA")]
	public enum CitizenPool
	{
		// Token: 0x04001355 RID: 4949
		[Token(Token = "0x4001355")]
		allCitizens,
		// Token: 0x04001356 RID: 4950
		[Token(Token = "0x4001356")]
		companyOnly,
		// Token: 0x04001357 RID: 4951
		[Token(Token = "0x4001357")]
		buildingOnly
	}
}
