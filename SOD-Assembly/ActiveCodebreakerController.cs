using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x0200040E RID: 1038
[Token(Token = "0x200040E")]
public class ActiveCodebreakerController : MonoBehaviour
{
	// Token: 0x06001788 RID: 6024 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001788")]
	[Address(RVA = "0x896760", Offset = "0x895760", VA = "0x180896760")]
	private void Update()
	{
	}

	// Token: 0x06001789 RID: 6025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001789")]
	[Address(RVA = "0x896A20", Offset = "0x895A20", VA = "0x180896A20")]
	public void OnCrack(string codeStr)
	{
	}

	// Token: 0x0600178A RID: 6026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600178A")]
	[Address(RVA = "0x896B60", Offset = "0x895B60", VA = "0x180896B60")]
	public ActiveCodebreakerController()
	{
	}

	// Token: 0x04001CAF RID: 7343
	[Token(Token = "0x4001CAF")]
	[FieldOffset(Offset = "0x18")]
	public InteractableController controller;

	// Token: 0x04001CB0 RID: 7344
	[Token(Token = "0x4001CB0")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshPro text;

	// Token: 0x04001CB1 RID: 7345
	[Token(Token = "0x4001CB1")]
	[FieldOffset(Offset = "0x28")]
	public bool cracked;

	// Token: 0x04001CB2 RID: 7346
	[Token(Token = "0x4001CB2")]
	[FieldOffset(Offset = "0x30")]
	public MeshRenderer rend;

	// Token: 0x04001CB3 RID: 7347
	[Token(Token = "0x4001CB3")]
	[FieldOffset(Offset = "0x38")]
	public List<Material> activeMaterials;
}
