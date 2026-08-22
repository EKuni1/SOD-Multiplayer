using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200024D RID: 589
[Token(Token = "0x200024D")]
public class GenerationDebugController : MonoBehaviour
{
	// Token: 0x06000D4E RID: 3406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D4E")]
	[Address(RVA = "0x5E6E30", Offset = "0x5E5E30", VA = "0x1805E6E30")]
	public void Setup(string newName, RoomTypePreset newPreset)
	{
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D4F")]
	[Address(RVA = "0x5E6EA0", Offset = "0x5E5EA0", VA = "0x1805E6EA0")]
	public void Log(string newLog)
	{
	}

	// Token: 0x06000D50 RID: 3408 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D50")]
	[Address(RVA = "0x5E6F00", Offset = "0x5E5F00", VA = "0x1805E6F00")]
	public void DisplayAttempedArea()
	{
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D51")]
	[Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public void RemoveAttempedArea()
	{
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000D52")]
	[Address(RVA = "0x5E7DF0", Offset = "0x5E6DF0", VA = "0x1805E7DF0")]
	public GenerationDebugController()
	{
	}

	// Token: 0x04000ED2 RID: 3794
	[Token(Token = "0x4000ED2")]
	[FieldOffset(Offset = "0x18")]
	public bool valid;

	// Token: 0x04000ED3 RID: 3795
	[Token(Token = "0x4000ED3")]
	[FieldOffset(Offset = "0x19")]
	public bool executed;

	// Token: 0x04000ED4 RID: 3796
	[Token(Token = "0x4000ED4")]
	[FieldOffset(Offset = "0x20")]
	public RoomTypePreset preset;

	// Token: 0x04000ED5 RID: 3797
	[Token(Token = "0x4000ED5")]
	[FieldOffset(Offset = "0x28")]
	public GenerationController.PossibleRoomLocation location;

	// Token: 0x04000ED6 RID: 3798
	[Token(Token = "0x4000ED6")]
	[FieldOffset(Offset = "0x30")]
	public List<string> log;

	// Token: 0x04000ED7 RID: 3799
	[Token(Token = "0x4000ED7")]
	[FieldOffset(Offset = "0x38")]
	[NonSerialized]
	public List<NewNode> attemptedValidNodes;

	// Token: 0x04000ED8 RID: 3800
	[Token(Token = "0x4000ED8")]
	[FieldOffset(Offset = "0x40")]
	public Dictionary<NewNode, string> overridenNodes;

	// Token: 0x04000ED9 RID: 3801
	[Token(Token = "0x4000ED9")]
	[FieldOffset(Offset = "0x48")]
	public Dictionary<NewNode, string> attemptedInvalidNodes;

	// Token: 0x04000EDA RID: 3802
	[Token(Token = "0x4000EDA")]
	[FieldOffset(Offset = "0x50")]
	private List<GameObject> spawnedObjects;
}
