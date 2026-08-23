using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000475 RID: 1141
[Token(Token = "0x2000475")]
public class InteractablePointer : MonoBehaviour
{
	// Token: 0x06001A24 RID: 6692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A24")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public InteractablePointer()
	{
	}

	// Token: 0x04001F90 RID: 8080
	[Token(Token = "0x4001F90")]
	[FieldOffset(Offset = "0x18")]
	public InteractableController pointTo;
}
