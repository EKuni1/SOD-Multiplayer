using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000481 RID: 1153
[Token(Token = "0x2000481")]
public class MeshToggleBehaviour : SwitchSyncBehaviour
{
	// Token: 0x06001A53 RID: 6739 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A53")]
	[Address(RVA = "0x97F2E0", Offset = "0x97E2E0", VA = "0x18097F2E0", Slot = "4")]
	public override void SetOn(bool val)
	{
	}

	// Token: 0x06001A54 RID: 6740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A54")]
	[Address(RVA = "0x97F610", Offset = "0x97E610", VA = "0x18097F610")]
	public MeshToggleBehaviour()
	{
	}

	// Token: 0x04001FDA RID: 8154
	[Token(Token = "0x4001FDA")]
	[FieldOffset(Offset = "0x40")]
	public List<MeshRenderer> objectsToToggle;
}
