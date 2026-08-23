using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020005F3 RID: 1523
[Token(Token = "0x20005F3")]
public class EvidenceLocationalControls : MonoBehaviour
{
	// Token: 0x06002157 RID: 8535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002157")]
	[Address(RVA = "0xB021B0", Offset = "0xB011B0", VA = "0x180B021B0")]
	private void OnEnable()
	{
	}

	// Token: 0x06002158 RID: 8536 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002158")]
	[Address(RVA = "0xB03480", Offset = "0xB02480", VA = "0x180B03480")]
	private void OnDisable()
	{
	}

	// Token: 0x06002159 RID: 8537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002159")]
	[Address(RVA = "0xB04180", Offset = "0xB03180", VA = "0x180B04180")]
	public void OnNewRoutePlotted()
	{
	}

	// Token: 0x0600215A RID: 8538 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600215A")]
	[Address(RVA = "0xB04260", Offset = "0xB03260", VA = "0x180B04260")]
	public void OnRouteRemoved()
	{
	}

	// Token: 0x0600215B RID: 8539 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600215B")]
	[Address(RVA = "0xB04340", Offset = "0xB03340", VA = "0x180B04340")]
	public void OnFastTravelStarted()
	{
	}

	// Token: 0x0600215C RID: 8540 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600215C")]
	[Address(RVA = "0xB04420", Offset = "0xB03420", VA = "0x180B04420")]
	public void OnFastTravelEnded()
	{
	}

	// Token: 0x0600215D RID: 8541 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600215D")]
	[Address(RVA = "0xB04500", Offset = "0xB03500", VA = "0x180B04500")]
	private void UpdateRouteTooltip()
	{
	}

	// Token: 0x0600215E RID: 8542 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600215E")]
	[Address(RVA = "0xB04810", Offset = "0xB03810", VA = "0x180B04810")]
	private void UpdateAutoTravelTooltip()
	{
	}

	// Token: 0x0600215F RID: 8543 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600215F")]
	[Address(RVA = "0xB04AF0", Offset = "0xB03AF0", VA = "0x180B04AF0")]
	public void CheckEnabled()
	{
	}

	// Token: 0x06002160 RID: 8544 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002160")]
	[Address(RVA = "0xB05050", Offset = "0xB04050", VA = "0x180B05050")]
	private void UpdateFastTravelAvailability()
	{
	}

	// Token: 0x06002161 RID: 8545 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002161")]
	[Address(RVA = "0xB058F0", Offset = "0xB048F0", VA = "0x180B058F0")]
	public void OnLocateOnMap()
	{
	}

	// Token: 0x06002162 RID: 8546 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002162")]
	[Address(RVA = "0xB05960", Offset = "0xB04960", VA = "0x180B05960")]
	public void OnPlotRoute()
	{
	}

	// Token: 0x06002163 RID: 8547 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002163")]
	[Address(RVA = "0xB05EB0", Offset = "0xB04EB0", VA = "0x180B05EB0")]
	public void OnFastTravel()
	{
	}

	// Token: 0x06002164 RID: 8548 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002164")]
	[Address(RVA = "0xB06340", Offset = "0xB05340", VA = "0x180B06340")]
	public void OnAcceptJob()
	{
	}

	// Token: 0x06002165 RID: 8549 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002165")]
	[Address(RVA = "0xB06630", Offset = "0xB05630", VA = "0x180B06630")]
	public void OnTakeItem()
	{
	}

	// Token: 0x06002166 RID: 8550 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002166")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public EvidenceLocationalControls()
	{
	}

	// Token: 0x04002B09 RID: 11017
	[Token(Token = "0x4002B09")]
	[FieldOffset(Offset = "0x18")]
	public InfoWindow parentWindow;

	// Token: 0x04002B0A RID: 11018
	[Token(Token = "0x4002B0A")]
	[FieldOffset(Offset = "0x20")]
	public ButtonController locateOnMapButton;

	// Token: 0x04002B0B RID: 11019
	[Token(Token = "0x4002B0B")]
	[FieldOffset(Offset = "0x28")]
	public ButtonController plotRouteButton;

	// Token: 0x04002B0C RID: 11020
	[Token(Token = "0x4002B0C")]
	[FieldOffset(Offset = "0x30")]
	public ButtonController fastTravelButton;

	// Token: 0x04002B0D RID: 11021
	[Token(Token = "0x4002B0D")]
	[FieldOffset(Offset = "0x38")]
	public JuiceController plotRouteJuice;

	// Token: 0x04002B0E RID: 11022
	[Token(Token = "0x4002B0E")]
	[FieldOffset(Offset = "0x40")]
	public JuiceController autoTravelJuice;

	// Token: 0x04002B0F RID: 11023
	[Token(Token = "0x4002B0F")]
	[FieldOffset(Offset = "0x48")]
	public bool fastTravelEnabled;

	// Token: 0x04002B10 RID: 11024
	[Token(Token = "0x4002B10")]
	[FieldOffset(Offset = "0x50")]
	public ButtonController acceptJobButton;

	// Token: 0x04002B11 RID: 11025
	[Token(Token = "0x4002B11")]
	[FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI acceptJobText;

	// Token: 0x04002B12 RID: 11026
	[Token(Token = "0x4002B12")]
	[FieldOffset(Offset = "0x60")]
	public ButtonController takeItemButton;

	// Token: 0x04002B13 RID: 11027
	[Token(Token = "0x4002B13")]
	[FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI takeItemText;
}
