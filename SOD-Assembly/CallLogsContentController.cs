using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020005E4 RID: 1508
[Token(Token = "0x20005E4")]
public class CallLogsContentController : MonoBehaviour
{
	// Token: 0x0600210D RID: 8461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600210D")]
	[Address(RVA = "0xAF4FA0", Offset = "0xAF3FA0", VA = "0x180AF4FA0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600210E RID: 8462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600210E")]
	[Address(RVA = "0xAF5330", Offset = "0xAF4330", VA = "0x180AF5330")]
	private void OnDisable()
	{
	}

	// Token: 0x0600210F RID: 8463 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600210F")]
	[Address(RVA = "0xAF5500", Offset = "0xAF4500", VA = "0x180AF5500")]
	public void CheckEnabled()
	{
	}

	// Token: 0x06002110 RID: 8464 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002110")]
	[Address(RVA = "0xAF5E70", Offset = "0xAF4E70", VA = "0x180AF5E70")]
	public CallLogsContentController()
	{
	}

	// Token: 0x04002AC0 RID: 10944
	[Token(Token = "0x4002AC0")]
	[FieldOffset(Offset = "0x18")]
	public WindowContentController windowContent;

	// Token: 0x04002AC1 RID: 10945
	[Token(Token = "0x4002AC1")]
	[FieldOffset(Offset = "0x20")]
	public InfoWindow parentWindow;

	// Token: 0x04002AC2 RID: 10946
	[Token(Token = "0x4002AC2")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI descriptionText;

	// Token: 0x04002AC3 RID: 10947
	[Token(Token = "0x4002AC3")]
	[FieldOffset(Offset = "0x30")]
	public GameObject entryPrefab;

	// Token: 0x04002AC4 RID: 10948
	[Token(Token = "0x4002AC4")]
	[FieldOffset(Offset = "0x38")]
	public bool incoming;

	// Token: 0x04002AC5 RID: 10949
	[Token(Token = "0x4002AC5")]
	[FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI titleText;

	// Token: 0x04002AC6 RID: 10950
	[Token(Token = "0x4002AC6")]
	[FieldOffset(Offset = "0x48")]
	public List<CallLogsEntryController> spawnedEntries;

	// Token: 0x04002AC7 RID: 10951
	[Token(Token = "0x4002AC7")]
	[FieldOffset(Offset = "0x50")]
	public VerticalLayoutGroup layout;

	// Token: 0x020005E5 RID: 1509
	[Token(Token = "0x20005E5")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x06002111 RID: 8465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002111")]
		[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x0000E070 File Offset: 0x0000C270
		[Token(Token = "0x6002112")]
		[Address(RVA = "0xAF5F70", Offset = "0xAF4F70", VA = "0x180AF5F70")]
		internal bool <CheckEnabled>b__0(TelephoneController.PhoneCall item)
		{
			return default(bool);
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x0000E088 File Offset: 0x0000C288
		[Token(Token = "0x6002113")]
		[Address(RVA = "0xAF6280", Offset = "0xAF5280", VA = "0x180AF6280")]
		internal bool <CheckEnabled>b__1(TelephoneController.PhoneCall item)
		{
			return default(bool);
		}

		// Token: 0x04002AC8 RID: 10952
		[Token(Token = "0x4002AC8")]
		[FieldOffset(Offset = "0x10")]
		public NewBuilding building;
	}
}
