using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020006B7 RID: 1719
[Token(Token = "0x20006B7")]
public class HighlightController : MonoBehaviour, IEnumerator<object>, IDisposable, IEnumerator
{
	// Token: 0x06002681 RID: 9857 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002681")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	private void Start()
	{
	}

	// Token: 0x06002682 RID: 9858 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002682")]
	[Address(RVA = "0xBEB080", Offset = "0xBEA080", VA = "0x180BEB080")]
	public void SetSelectable(bool tf)
	{
	}

	// Token: 0x06002683 RID: 9859 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002683")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002684 RID: 9860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002684")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810", Slot = "4")]
	public void OnPointerEnter(PointerEventData data)
	{
	}

	// Token: 0x06002685 RID: 9861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002685")]
	[Address(RVA = "0xBEB120", Offset = "0xBEA120", VA = "0x180BEB120", Slot = "5")]
	public void OnPointerExit(PointerEventData data)
	{
	}

	// Token: 0x06002686 RID: 9862 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002686")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	private void Update()
	{
	}

	// Token: 0x06002687 RID: 9863 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002687")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void Hightlight()
	{
	}

	// Token: 0x06002688 RID: 9864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002688")]
	[Address(RVA = "0x3E7810", Offset = "0x3E6810", VA = "0x1803E7810")]
	public void Restore()
	{
	}

	// Token: 0x06002689 RID: 9865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002689")]
	[Address(RVA = "0xBEB220", Offset = "0xBEA220", VA = "0x180BEB220")]
	public HighlightController()
	{
	}

	// Token: 0x0400309F RID: 12447
	[Token(Token = "0x400309F")]
	[FieldOffset(Offset = "0x18")]
	[NonSerialized]
	public InfoWindow window;

	// Token: 0x040030A0 RID: 12448
	[Token(Token = "0x40030A0")]
	[FieldOffset(Offset = "0x20")]
	public string selectableType;

	// Token: 0x040030A1 RID: 12449
	[Token(Token = "0x40030A1")]
	[FieldOffset(Offset = "0x28")]
	public bool selectable;

	// Token: 0x040030A2 RID: 12450
	[Token(Token = "0x40030A2")]
	[FieldOffset(Offset = "0x29")]
	public bool highlighted;
}
