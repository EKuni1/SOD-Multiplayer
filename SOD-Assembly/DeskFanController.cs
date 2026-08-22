using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000417 RID: 1047
[Token(Token = "0x2000417")]
public class DeskFanController : SwitchSyncBehaviour
{
	// Token: 0x060017B5 RID: 6069 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017B5")]
	[Address(RVA = "0x89E7F0", Offset = "0x89D7F0", VA = "0x18089E7F0", Slot = "4")]
	public override void SetOn(bool val)
	{
	}

	// Token: 0x060017B6 RID: 6070 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017B6")]
	[Address(RVA = "0x89E870", Offset = "0x89D870", VA = "0x18089E870")]
	private void Update()
	{
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017B7")]
	[Address(RVA = "0x89EA50", Offset = "0x89DA50", VA = "0x18089EA50")]
	public DeskFanController()
	{
	}

	// Token: 0x04001CEF RID: 7407
	[Token(Token = "0x4001CEF")]
	[FieldOffset(Offset = "0x40")]
	public InteractableController ic;

	// Token: 0x04001CF0 RID: 7408
	[Token(Token = "0x4001CF0")]
	[FieldOffset(Offset = "0x48")]
	public Transform fanBlade;

	// Token: 0x04001CF1 RID: 7409
	[Token(Token = "0x4001CF1")]
	[FieldOffset(Offset = "0x50")]
	public float speedProgress;

	// Token: 0x04001CF2 RID: 7410
	[Token(Token = "0x4001CF2")]
	[FieldOffset(Offset = "0x54")]
	public float fanSpeed;
}
