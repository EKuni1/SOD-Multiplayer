using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x02000611 RID: 1553
[Token(Token = "0x2000611")]
public class ObjectivesContentController : MonoBehaviour
{
	// Token: 0x06002227 RID: 8743 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002227")]
	[Address(RVA = "0xB279A0", Offset = "0xB269A0", VA = "0x180B279A0")]
	public void Setup(WindowContentController newWcc)
	{
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002228")]
	[Address(RVA = "0xB27CA0", Offset = "0xB26CA0", VA = "0x180B27CA0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002229 RID: 8745 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002229")]
	[Address(RVA = "0xB27E10", Offset = "0xB26E10", VA = "0x180B27E10")]
	public void UpdateJobDetails()
	{
	}

	// Token: 0x0600222A RID: 8746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600222A")]
	[Address(RVA = "0xB281C0", Offset = "0xB271C0", VA = "0x180B281C0")]
	public ObjectivesContentController()
	{
	}

	// Token: 0x04002BD5 RID: 11221
	[Token(Token = "0x4002BD5")]
	[FieldOffset(Offset = "0x18")]
	public WindowContentController wcc;

	// Token: 0x04002BD6 RID: 11222
	[Token(Token = "0x4002BD6")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform pageRect;

	// Token: 0x04002BD7 RID: 11223
	[Token(Token = "0x4002BD7")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform objectiveContainer;

	// Token: 0x04002BD8 RID: 11224
	[Token(Token = "0x4002BD8")]
	[FieldOffset(Offset = "0x30")]
	public SideJob job;

	// Token: 0x04002BD9 RID: 11225
	[Token(Token = "0x4002BD9")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI jobDetails;

	// Token: 0x04002BDA RID: 11226
	[Token(Token = "0x4002BDA")]
	[FieldOffset(Offset = "0x40")]
	public List<ObjectiveContentListEntry> spawnedStartingObjectives;

	// Token: 0x04002BDB RID: 11227
	[Token(Token = "0x4002BDB")]
	[FieldOffset(Offset = "0x48")]
	public GameObject elementPrefab;
}
