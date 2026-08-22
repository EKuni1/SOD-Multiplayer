using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000414 RID: 1044
[Token(Token = "0x2000414")]
public class ClockController : MonoBehaviour
{
	// Token: 0x0600179D RID: 6045 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600179D")]
	[Address(RVA = "0x898C20", Offset = "0x897C20", VA = "0x180898C20")]
	private void Start()
	{
	}

	// Token: 0x0600179E RID: 6046 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600179E")]
	[Address(RVA = "0x898F60", Offset = "0x897F60", VA = "0x180898F60")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600179F RID: 6047 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600179F")]
	[Address(RVA = "0x899230", Offset = "0x898230", VA = "0x180899230")]
	public void OnHourChange()
	{
	}

	// Token: 0x060017A0 RID: 6048 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017A0")]
	[Address(RVA = "0x899440", Offset = "0x898440", VA = "0x180899440")]
	private void Update()
	{
	}

	// Token: 0x060017A1 RID: 6049 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017A1")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public ClockController()
	{
	}

	// Token: 0x04001CCB RID: 7371
	[Token(Token = "0x4001CCB")]
	[FieldOffset(Offset = "0x18")]
	public InteractableController ic;

	// Token: 0x04001CCC RID: 7372
	[Token(Token = "0x4001CCC")]
	[FieldOffset(Offset = "0x20")]
	public Transform hourHand;

	// Token: 0x04001CCD RID: 7373
	[Token(Token = "0x4001CCD")]
	[FieldOffset(Offset = "0x28")]
	public Transform minuteHand;

	// Token: 0x04001CCE RID: 7374
	[Token(Token = "0x4001CCE")]
	[FieldOffset(Offset = "0x30")]
	public Animator hourlyAnimation;

	// Token: 0x04001CCF RID: 7375
	[Token(Token = "0x4001CCF")]
	[FieldOffset(Offset = "0x38")]
	public float animateTimer;
}
