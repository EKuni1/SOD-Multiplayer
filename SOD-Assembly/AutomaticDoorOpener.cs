using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000268 RID: 616
[Token(Token = "0x2000268")]
public class AutomaticDoorOpener : MonoBehaviour
{
	// Token: 0x06000DDF RID: 3551 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DDF")]
	[Address(RVA = "0x63E0C0", Offset = "0x63D0C0", VA = "0x18063E0C0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DE0")]
	[Address(RVA = "0x63E370", Offset = "0x63D370", VA = "0x18063E370")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DE1")]
	[Address(RVA = "0x63E5A0", Offset = "0x63D5A0", VA = "0x18063E5A0")]
	private void Update()
	{
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DE2")]
	[Address(RVA = "0x63EA80", Offset = "0x63DA80", VA = "0x18063EA80")]
	private void OnDisable()
	{
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000DE3")]
	[Address(RVA = "0x63EB20", Offset = "0x63DB20", VA = "0x18063EB20")]
	public AutomaticDoorOpener()
	{
	}

	// Token: 0x04000FCE RID: 4046
	[Token(Token = "0x4000FCE")]
	[FieldOffset(Offset = "0x18")]
	public DoorMovementController door;

	// Token: 0x04000FCF RID: 4047
	[Token(Token = "0x4000FCF")]
	[FieldOffset(Offset = "0x20")]
	public bool closeTrigger;

	// Token: 0x04000FD0 RID: 4048
	[Token(Token = "0x4000FD0")]
	[FieldOffset(Offset = "0x28")]
	public List<Citizen> overlapping;
}
