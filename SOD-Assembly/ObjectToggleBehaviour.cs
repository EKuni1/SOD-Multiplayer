using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000487 RID: 1159
[Token(Token = "0x2000487")]
public class ObjectToggleBehaviour : SwitchSyncBehaviour
{
	// Token: 0x06001A72 RID: 6770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A72")]
	[Address(RVA = "0x983F00", Offset = "0x982F00", VA = "0x180983F00", Slot = "4")]
	public override void SetOn(bool val)
	{
	}

	// Token: 0x06001A73 RID: 6771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A73")]
	[Address(RVA = "0x9840A0", Offset = "0x9830A0", VA = "0x1809840A0")]
	public ObjectToggleBehaviour()
	{
	}

	// Token: 0x04002023 RID: 8227
	[Token(Token = "0x4002023")]
	[FieldOffset(Offset = "0x40")]
	public List<GameObject> objectsToToggle;
}
