using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004A7 RID: 1191
[Token(Token = "0x20004A7")]
public class VehicleController : MonoBehaviour
{
	// Token: 0x06001ADC RID: 6876 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ADC")]
	[Address(RVA = "0x99C270", Offset = "0x99B270", VA = "0x18099C270")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06001ADD RID: 6877 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ADD")]
	[Address(RVA = "0x99C750", Offset = "0x99B750", VA = "0x18099C750")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06001ADE RID: 6878 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001ADE")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public VehicleController()
	{
	}

	// Token: 0x040020F2 RID: 8434
	[Token(Token = "0x40020F2")]
	[FieldOffset(Offset = "0x18")]
	public Transform vehicle;
}
