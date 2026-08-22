using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000410 RID: 1040
[Token(Token = "0x2000410")]
public class ApartmentNumberController : MonoBehaviour
{
	// Token: 0x0600178D RID: 6029 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600178D")]
	[Address(RVA = "0x896D90", Offset = "0x895D90", VA = "0x180896D90")]
	public void Setup(NewNode behindNode, NewDoor door)
	{
	}

	// Token: 0x0600178E RID: 6030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600178E")]
	[Address(RVA = "0x8976C0", Offset = "0x8966C0", VA = "0x1808976C0")]
	public ApartmentNumberController()
	{
	}

	// Token: 0x04001CB8 RID: 7352
	[Token(Token = "0x4001CB8")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> numberPrefabs;

	// Token: 0x04001CB9 RID: 7353
	[Token(Token = "0x4001CB9")]
	[FieldOffset(Offset = "0x20")]
	public List<Transform> spawned;
}
