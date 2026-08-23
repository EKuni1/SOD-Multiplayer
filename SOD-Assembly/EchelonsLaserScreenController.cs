using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000418 RID: 1048
[Token(Token = "0x2000418")]
public class EchelonsLaserScreenController : MonoBehaviour
{
	// Token: 0x060017B8 RID: 6072 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017B8")]
	[Address(RVA = "0x89EA60", Offset = "0x89DA60", VA = "0x18089EA60")]
	public void Setup(InteractableController newController)
	{
	}

	// Token: 0x060017B9 RID: 6073 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017B9")]
	[Address(RVA = "0x89F1C0", Offset = "0x89E1C0", VA = "0x18089F1C0")]
	private void OnEnable()
	{
	}

	// Token: 0x060017BA RID: 6074 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017BA")]
	[Address(RVA = "0x89F4F0", Offset = "0x89E4F0", VA = "0x18089F4F0")]
	private void OnDisable()
	{
	}

	// Token: 0x060017BB RID: 6075 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60017BB")]
	[Address(RVA = "0x3EF400", Offset = "0x3EE400", VA = "0x1803EF400")]
	public EchelonsLaserScreenController()
	{
	}

	// Token: 0x04001CF3 RID: 7411
	[Token(Token = "0x4001CF3")]
	[FieldOffset(Offset = "0x18")]
	private InteractableController controller;

	// Token: 0x04001CF4 RID: 7412
	[Token(Token = "0x4001CF4")]
	[FieldOffset(Offset = "0x20")]
	public AudioEvent laserBarrierLoop;

	// Token: 0x04001CF5 RID: 7413
	[Token(Token = "0x4001CF5")]
	[FieldOffset(Offset = "0x28")]
	private AudioController.LoopingSoundInfo _laserBarrierLoopInfo;
}
