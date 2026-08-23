using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004A5 RID: 1189
[Token(Token = "0x20004A5")]
public class SwitchSyncBehaviour : MonoBehaviour
{
	// Token: 0x06001ADA RID: 6874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ADA")]
	[Address(RVA = "0x99BC10", Offset = "0x99AC10", VA = "0x18099BC10", Slot = "4")]
	public virtual void SetOn(bool val)
	{
	}

	// Token: 0x06001ADB RID: 6875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ADB")]
	[Address(RVA = "0x99C170", Offset = "0x99B170", VA = "0x18099C170")]
	public SwitchSyncBehaviour()
	{
	}

	// Token: 0x040020E7 RID: 8423
	[Token(Token = "0x40020E7")]
	[FieldOffset(Offset = "0x18")]
	public InteractablePreset.Switch syncWithState;

	// Token: 0x040020E8 RID: 8424
	[Token(Token = "0x40020E8")]
	[FieldOffset(Offset = "0x1C")]
	public bool isOn;

	// Token: 0x040020E9 RID: 8425
	[Token(Token = "0x40020E9")]
	[FieldOffset(Offset = "0x1D")]
	public bool inverted;

	// Token: 0x040020EA RID: 8426
	[Token(Token = "0x40020EA")]
	[FieldOffset(Offset = "0x20")]
	public SwitchSyncBehaviour.BasicBehaviour basicBehaviour;

	// Token: 0x040020EB RID: 8427
	[Token(Token = "0x40020EB")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> basicBehaviourObjects;

	// Token: 0x040020EC RID: 8428
	[Token(Token = "0x40020EC")]
	[FieldOffset(Offset = "0x30")]
	public InteractableController syncInteractable;

	// Token: 0x040020ED RID: 8429
	[Token(Token = "0x40020ED")]
	[FieldOffset(Offset = "0x38")]
	public bool onlySyncWhenParentIsOn;

	// Token: 0x020004A6 RID: 1190
	[Token(Token = "0x20004A6")]
	public enum BasicBehaviour
	{
		// Token: 0x040020EF RID: 8431
		[Token(Token = "0x40020EF")]
		none,
		// Token: 0x040020F0 RID: 8432
		[Token(Token = "0x40020F0")]
		hideWhenOn,
		// Token: 0x040020F1 RID: 8433
		[Token(Token = "0x40020F1")]
		hideWhenOff
	}
}
