using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200080A RID: 2058
[Token(Token = "0x200080A")]
public class InteractableActionsPreset : SoCustomComparison
{
	// Token: 0x0600298E RID: 10638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600298E")]
	[Address(RVA = "0xCA96C0", Offset = "0xCA86C0", VA = "0x180CA96C0")]
	public InteractableActionsPreset()
	{
	}

	// Token: 0x04003C6E RID: 15470
	[Token(Token = "0x4003C6E")]
	[FieldOffset(Offset = "0x20")]
	public List<InteractablePreset.InteractionAction> actions;

	// Token: 0x04003C6F RID: 15471
	[Token(Token = "0x4003C6F")]
	[FieldOffset(Offset = "0x28")]
	public bool disableCollider;

	// Token: 0x04003C70 RID: 15472
	[Token(Token = "0x4003C70")]
	[FieldOffset(Offset = "0x30")]
	public List<InteractablePreset.InteractionAction> lockedInActions1;

	// Token: 0x04003C71 RID: 15473
	[Token(Token = "0x4003C71")]
	[FieldOffset(Offset = "0x38")]
	public List<InteractablePreset.InteractionAction> lockedInActions2;

	// Token: 0x04003C72 RID: 15474
	[Token(Token = "0x4003C72")]
	[FieldOffset(Offset = "0x40")]
	public List<InteractablePreset.InteractionAction> physicsActions;
}
