using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200030E RID: 782
[Token(Token = "0x200030E")]
public class RagdollPositionUpdater : MonoBehaviour
{
	// Token: 0x06001118 RID: 4376 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001118")]
	[Address(RVA = "0x3ED9D0", Offset = "0x3EC9D0", VA = "0x1803ED9D0")]
	public void Setup(NewAIController newHuman)
	{
	}

	// Token: 0x06001119 RID: 4377 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001119")]
	[Address(RVA = "0x6BB9D0", Offset = "0x6BA9D0", VA = "0x1806BB9D0")]
	private void Update()
	{
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600111A")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public RagdollPositionUpdater()
	{
	}

	// Token: 0x040014EB RID: 5355
	[Token(Token = "0x40014EB")]
	[FieldOffset(Offset = "0x18")]
	public NewAIController ai;

	// Token: 0x040014EC RID: 5356
	[Token(Token = "0x40014EC")]
	[FieldOffset(Offset = "0x20")]
	public float freeFallForceTimer;
}
