using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000309 RID: 777
[Token(Token = "0x2000309")]
public class FileSystemController : MonoBehaviour
{
	// Token: 0x0600110B RID: 4363 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600110B")]
	[Address(RVA = "0x6B85D0", Offset = "0x6B75D0", VA = "0x1806B85D0")]
	public void Setup(InteractableController newController)
	{
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600110C")]
	[Address(RVA = "0x6B8E00", Offset = "0x6B7E00", VA = "0x1806B8E00")]
	public void SetPage(int newPage, bool instant = false)
	{
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600110D")]
	[Address(RVA = "0x6B92A0", Offset = "0x6B82A0", VA = "0x1806B92A0")]
	private void Update()
	{
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600110E")]
	[Address(RVA = "0x6B9AB0", Offset = "0x6B8AB0", VA = "0x1806B9AB0")]
	public FileSystemController()
	{
	}

	// Token: 0x040014C9 RID: 5321
	[Token(Token = "0x40014C9")]
	[FieldOffset(Offset = "0x18")]
	public FileSystemController.StackType stackMode;

	// Token: 0x040014CA RID: 5322
	[Token(Token = "0x40014CA")]
	[FieldOffset(Offset = "0x20")]
	public InteractableController controller;

	// Token: 0x040014CB RID: 5323
	[Token(Token = "0x40014CB")]
	[FieldOffset(Offset = "0x28")]
	public GameObject filePrefab;

	// Token: 0x040014CC RID: 5324
	[Token(Token = "0x40014CC")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 pagesOffset;

	// Token: 0x040014CD RID: 5325
	[Token(Token = "0x40014CD")]
	[FieldOffset(Offset = "0x40")]
	public EvidenceMultiPage ev;

	// Token: 0x040014CE RID: 5326
	[Token(Token = "0x40014CE")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 frontPagesPos;

	// Token: 0x040014CF RID: 5327
	[Token(Token = "0x40014CF")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 frontPagesEuler;

	// Token: 0x040014D0 RID: 5328
	[Token(Token = "0x40014D0")]
	[FieldOffset(Offset = "0x60")]
	public Dictionary<int, List<EvidenceMultiPage.MultiPageContent>> content;

	// Token: 0x040014D1 RID: 5329
	[Token(Token = "0x40014D1")]
	[FieldOffset(Offset = "0x68")]
	public int pageCount;

	// Token: 0x040014D2 RID: 5330
	[Token(Token = "0x40014D2")]
	[FieldOffset(Offset = "0x70")]
	public Transform frontBunch;

	// Token: 0x040014D3 RID: 5331
	[Token(Token = "0x40014D3")]
	[FieldOffset(Offset = "0x78")]
	public Transform rearBunch;

	// Token: 0x040014D4 RID: 5332
	[Token(Token = "0x40014D4")]
	[FieldOffset(Offset = "0x80")]
	public int currentPage;

	// Token: 0x040014D5 RID: 5333
	[Token(Token = "0x40014D5")]
	[FieldOffset(Offset = "0x88")]
	public List<Transform> fontPages;

	// Token: 0x040014D6 RID: 5334
	[Token(Token = "0x40014D6")]
	[FieldOffset(Offset = "0x90")]
	public List<Transform> rearPages;

	// Token: 0x040014D7 RID: 5335
	[Token(Token = "0x40014D7")]
	[FieldOffset(Offset = "0x98")]
	private float moveProgress;

	// Token: 0x0200030A RID: 778
	[Token(Token = "0x200030A")]
	public enum StackType
	{
		// Token: 0x040014D9 RID: 5337
		[Token(Token = "0x40014D9")]
		filingSystem,
		// Token: 0x040014DA RID: 5338
		[Token(Token = "0x40014DA")]
		pile
	}
}
